using IranExpert.Models;
using System.Web.Mvc;
using IranExpert.ViewModels;
using Microsoft.AspNet.Identity;

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
                Profile = new Profile(),
                statuses = _context.Statuses,
                Cities = _context.Cities
                
            };

            return View("Profile", viewModel);
        }

        [HttpPost]
        public ActionResult Save(ProfileFormViewModel profileFormViewModel)
        {
            var profile = new Profile()
            {
                Name = profileFormViewModel.Profile.Name,
                Family = profileFormViewModel.Profile.Family,
                StatusId = profileFormViewModel.Profile.StatusId,
                UserId = User.Identity.GetUserId(),
                CityId = profileFormViewModel.Profile.CityId,
                CountryId = 1,
                UniversityId = 1,
                DegreeId = 1
            };

            _context.Profiles.Add(profile);
            _context.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
    }
}
