using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace IranExpert.Models
{
    public class Profiles
    {
        public int Id { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources.ValidationResource), ErrorMessageResourceName = "RequiredField_FullName")]
        //[MinLength(6 , ErrorMessageResourceType = typeof(Resources.ValidationResource), ErrorMessageResourceName = "ValidField_FullName")]
        [StringLength(60)]
        [Display(Name = "نام و نام خانوادگی :")]
        public string FullName { get; set; }
    
        public City City { get; set; }

        [Required]
        [Display(Name = "شهر محل سکونت :")]
        public int CityId { get; set; }

        public Country Country { get; set; }

        [Required]
        [Display(Name = "کشور محل سکونت :")]
        public byte CountryId { get; set; }

        public Status Status { get; set; }

        [Display(Name = "وضعیت تحصیلی و شغلی :")]
        public byte StatusId { get; set; }

        public University University { get; set; }
        
        [Display(Name = "نام دانشگاه :")]
        public int UniversityId { get; set; }

        public Degree Degree { get; set; }

        [Display(Name = "مقطع تحصیلی :")]
        public byte DegreeId { get; set; }

        [Display(Name = "حرفه یا شغل :")]
        [StringLength(100)]
        public string Business { get; set; }

        [Display(Name = "تاریخ تولد :")]
        public DateTime? BirthDate { get; set; }

        [StringLength(50)]
        [Display(Name = "تلفن همراه :")]
        public string CellPhone { get; set; }

        [EmailAddress]
        [StringLength(50)]
        [Display(Name = "آدرس ایمیل :")]
        public string AlternateEmail { get; set; }

        [StringLength(50)]
        [Display(Name = "آدرس وب سایت :")]
        public string WebSite { get; set; }

        public ApplicationUser User { get; set; }

        public string UserId { get; set; }

    }
}