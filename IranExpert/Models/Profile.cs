using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace IranExpert.Models
{
    public class Profile
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "نام :")]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "نام خانوادگی :")]
        public string Family { get; set; }
    
        [Display(Name = "ساکن آلمان هستم :")]
        public bool? IsInGermany { get; set; }

        public City City { get; set; }

        [Required]
        [Display(Name = "شهر محل سکونت :")]
        public byte CityId { get; set; }

        public Country Country { get; set; }

        [Required]
        [Display(Name = "کشور محل سکونت :")]
        public byte CountryId { get; set; }

        public Status Status { get; set; }

        [Display(Name = "وضعیت تحصیلی و شغلی :")]
        public byte StatusId { get; set; }

        public University University { get; set; }
        
        [Display(Name = "نام دانشگاه :")]
        public byte UniversityId { get; set; }

        public Degree Degree { get; set; }

        [Display(Name = "مقطع تحصیلی :")]
        public byte DegreeId { get; set; }

        [Display(Name = "تاریخ تولد :")]
        public DateTime? BirthDate { get; set; }

        [StringLength(50)]
        [Display(Name = "تلفن همراه :")]
        public string CellPhone { get; set; }

        [Display(Name = "نمایش ایمیل اختیاری در پروفایل :")]
        public bool? ViewAlternateEmail { get; set; }

        [EmailAddress]
        [StringLength(50)]
        [Display(Name = "ایمیل دوم جهت نمایش در پروفایل :")]
        public string AlternateEmail { get; set; }

        [StringLength(50)]
        [Display(Name = "آدرس وب سایت :")]
        public string WebSite { get; set; }

        public ApplicationUser User { get; set; }

        public string UserId { get; set; }

    }
}