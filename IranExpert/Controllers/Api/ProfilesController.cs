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

        // GET /api/Profiles
        public IHttpActionResult GetProfiles(string id)
        {
            var profilesQuery = _context.Profiles
                .Include(c => c.Status)
                .Include(c => c.Degree)
                .Include(c => c.Country)
                .Include(c => c.University)
                .Include(c => c.City).SingleOrDefault(c => c.UserId == id);

            return Ok(Mapper.Map<Profiles, ProfilesDto>(profilesQuery));
        }

        // GET /api/Profile  -- Verwendung in SearchProfile
        public IHttpActionResult GetProfile()
        {
            var profilesQuery = _context.Profiles
                .Include(c => c.Status)
                .Include(c => c.Degree)
                .Include(c => c.Country)
                .Include(c => c.University)
                .Include(c => c.City);

            var profileDtos = profilesQuery.ToList()
                .Select(Mapper.Map<Profiles, ProfileSearchDto>);

            return Ok(profileDtos);
        }

        [HttpPost]
        public IHttpActionResult CreateProfile(string id, ProfilesDto profileDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var profileInDb = _context.Profiles.SingleOrDefault(c => c.UserId == id);
            if (profileInDb == null)
            {
                var profile = Mapper.Map<ProfilesDto, Profiles>(profileDto);
                _context.Profiles.Add(profile);
                profileDto.Id = profile.Id;
            }
            else
            {
                Mapper.Map<ProfilesDto, Profiles>(profileDto, profileInDb);
            }
            _context.SaveChanges();
            return Ok();
        }
    }
}
