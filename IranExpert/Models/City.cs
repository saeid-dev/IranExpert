using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IranExpert.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        [StringLength(60)]
        public string Name { get; set; }
    }
}