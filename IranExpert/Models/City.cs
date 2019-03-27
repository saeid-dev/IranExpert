using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace IranExpert.Models
{
    public class City
    {
        public byte Id { get; set; }

        [StringLength(20)]
        public string Name { get; set; }
    }
}