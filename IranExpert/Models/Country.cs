using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace IranExpert.Models
{
    public class Country
    {
        public byte Id { get; set; }

        [StringLength(30)]
        public string Name { get; set; }
    }
}