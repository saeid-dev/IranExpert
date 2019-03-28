using IranExpert.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace IranExpert.ViewModels
{
    public class ProfileFormViewModel
    {
        public Profile Profile { get; set; }

        public IEnumerable<Status> statuses { get; set; }

        public IEnumerable<City> Cities { get; set; }

        public IEnumerable<University> Universities { get; set; }

        public IEnumerable<Country> Countries { get; set; }

        public IEnumerable<Degree> Degrees { get; set; }
    }
}