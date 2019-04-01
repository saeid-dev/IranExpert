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
    public class NewProfilesController : ApiController
    {
        private ApplicationDbContext _context;

        public NewProfilesController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateNewProfile(ProfilesDto profileDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var profile = Mapper.Map<ProfilesDto, Profiles>(profileDto);
            _context.Profiles.Add(profile);
            _context.SaveChanges();

            profileDto.Id = profile.Id;
            return Created(new Uri(Request.RequestUri + "/" + profile.Id), profileDto);
        }
    }
}
