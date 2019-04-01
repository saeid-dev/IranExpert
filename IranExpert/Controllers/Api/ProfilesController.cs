using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using IranExpert.Models;
using System.Data.Entity;
using IranExpert.Dto;
using AutoMapper;

namespace IranExpert.Controllers.Api
{
    public class ProfilesController : ApiController
    {
        private ApplicationDbContext _context;

        public ProfilesController()
        {
            _context = new ApplicationDbContext();
        }

        //// GET /api/customers
        public IHttpActionResult GetProfiles(string query = null)
        {
            var profilesQuery = _context.Profiles
                .Include(c => c.Status)
                .Include(c => c.Degree)
                .Include(c => c.Country)
                .Include(c => c.University)
                .Include(c => c.City);

            if (!String.IsNullOrWhiteSpace(query))
                profilesQuery = profilesQuery.Where(c => c.FullName.Contains(query));


            var profileDtos = profilesQuery.ToList()
                .Select(Mapper.Map<Profiles, ProfilesDto>);

            return Ok(profileDtos);
        }

        public IHttpActionResult GetProfiles(int id)
        {
            var profile = _context.Profiles.SingleOrDefault(p => p.Id == id);
            if (profile == null)
                return NotFound();

            return Ok(Mapper.Map<Profiles,ProfilesDto>(profile)) ;
        }

        [HttpPost]
        public IHttpActionResult CreateProfile(ProfilesDto profileDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var profile = Mapper.Map<ProfilesDto, Profiles>(profileDto);
            _context.Profiles.Add(profile);
            _context.SaveChanges();

            profileDto.Id = profile.Id;
            return Created(new Uri(Request.RequestUri + "/" + profile.Id), profileDto);
        }

        [HttpPut]
        public IHttpActionResult UpdateProfile(int id, ProfilesDto profileDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var profileInDb = _context.Profiles.SingleOrDefault(c => c.Id == id);
            if (profileInDb == null)
                return NotFound();

            Mapper.Map<ProfilesDto, Profiles>(profileDto, profileInDb);

            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult DeleteProfile(int id)
        {
            var profileInDb = _context.Profiles.SingleOrDefault(c => c.Id == id);

            if (profileInDb == null)
                return NotFound();
            
            _context.Profiles.Remove(profileInDb);
            _context.SaveChanges();

            return Ok();
        }



    }
}
