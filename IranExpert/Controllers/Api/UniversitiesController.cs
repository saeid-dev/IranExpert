using IranExpert.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using IranExpert.Dto;
using AutoMapper;
using System.Globalization;

namespace IranExpert.Controllers.Api
{
    public class UniversitiesController : ApiController
    {
        private ApplicationDbContext _context;

        public UniversitiesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/Universities/id
        [HttpGet]
        public IHttpActionResult GetUniversities (int id)
        {
            var university = _context.Universities.SingleOrDefault(c => c.Id == id);
            if (university == null)
                return NotFound();

            return Ok(Mapper.Map<University, UniversityDto>(university));
        }

        //// GET /api/Universities
        public IHttpActionResult GetUniversities (string query = null)
        {



            var universityQuery = _context.Universities.ToList();

            if (!String.IsNullOrWhiteSpace(query))

                //universityQuery = universityQuery.Where(c => c.Name.Contains(query)).ToList();

                universityQuery = universityQuery.Where(p => CultureInfo.CurrentCulture.CompareInfo.IndexOf(p.Name,query, CompareOptions.IgnoreCase) >= 0).ToList();

            var universityDto = universityQuery.ToList().Select(Mapper.Map<University, UniversityDto>);
            return Ok(universityDto);
        }
    }
}
