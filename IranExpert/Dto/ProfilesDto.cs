using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using IranExpert.Models;

namespace IranExpert.Dto
{
    public class ProfilesDto
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public CityDto City { get; set; }

        public int CityId { get; set; }

        public CountryDto Country { get; set; }

        public byte CountryId { get; set; }

        public StatusDto Status { get; set; }

        public byte StatusId { get; set; }

        public UniversityDto University { get; set; }

        public int UniversityId { get; set; }

        public DegreeDto Degree { get; set; }

        public byte DegreeId { get; set; }

        public DateTime? BirthDate { get; set; }

        public string CellPhone { get; set; }

        public string AlternateEmail { get; set; }

        public string WebSite { get; set; }

        public string Business { get; set; }

        public ApplicationUser User { get; set; }

        public string UserId { get; set; }
    }
}