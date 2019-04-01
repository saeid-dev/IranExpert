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
    public class CitiesController : ApiController
    {
        private ApplicationDbContext _context;

        public CitiesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/Cities/id
        [HttpGet]
        public IHttpActionResult GetCities(int id)
        {
            var city = _context.Cities.SingleOrDefault(c => c.Id == id);
            if (city == null)
                return NotFound();

            return Ok(Mapper.Map<City, CityDto>(city));
        }

        //// GET /api/Cities
        public IHttpActionResult GetCities(string query = null)
        {
            var cityQuery = _context.Cities.ToList();
            if (!String.IsNullOrWhiteSpace(query))
                cityQuery = cityQuery.Where(p => CultureInfo.CurrentCulture.CompareInfo.IndexOf(p.Name, query, CompareOptions.IgnoreCase) >= 0).ToList();

            var cityDto = cityQuery.ToList().Select(Mapper.Map<City, CityDto>);
            return Ok(cityDto);
        }
    }
}
