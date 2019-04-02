using IranExpert.Models;
using System.Web.Mvc;
using IranExpert.ViewModels;
using Microsoft.AspNet.Identity;
using System.Collections.Generic;
using IranExpert.Dto;
using System.Linq;
using System.Data.Entity;




namespace IranExpert.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        ApplicationDbContext _context;

        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult New()
        {
            /*  var viewModel = new AuthorFormViewModel()*/
            var viewModel = new ProfileFormViewModel
            {
                Profile = new Profiles(),
                statuses = _context.Statuses,
                Cities = _context.Cities,
                Universities = _context.Universities,
                Countries = _context.Countries,
                Degrees = _context.Degrees
            };

            return View("Profile", viewModel);
        }

        [HttpPost]
        public ActionResult Save(ProfileFormViewModel profileFormViewModel)
        {
            //var profile = new Profiles()
            //{
            //    FullName = profileFormViewModel.Profile.FullName,
            //    StatusId = profileFormViewModel.Profile.StatusId,
            //    UserId = User.Identity.GetUserId(),
            //    CityId = profileFormViewModel.Profile.CityId,
            //    CountryId = profileFormViewModel.Profile.CountryId,
            //    UniversityId = profileFormViewModel.Profile.UniversityId,
            //    DegreeId = profileFormViewModel.Profile.DegreeId,

            //    BirthDate = profileFormViewModel.Profile.BirthDate,
            //    AlternateEmail = profileFormViewModel.Profile.AlternateEmail,
            //    CellPhone = profileFormViewModel.Profile.CellPhone,
            //    WebSite = profileFormViewModel.Profile.WebSite
            //};

            //_context.Profiles.Add(profile);
            //_context.SaveChanges();

            return RedirectToAction("New", "Home");
        }

        public ActionResult Test()
        {
            return View();
        }

        public ActionResult Profile()
        {
            //var profile = _context.Profiles.SingleOrDefault(c => c.UserId == User.Identity.GetUserId());


            //var profile = _context.Profiles.Include(c => c.Status).Include(c => c.Degree).Include(c => c.Country).Include(c => c.University).Include(c => c.City).SingleOrDefault(c => c.UserId == User.Identity.GetUserId());

            ViewBag.UserId = User.Identity.GetUserId();

            return View();
        }
    }
}
