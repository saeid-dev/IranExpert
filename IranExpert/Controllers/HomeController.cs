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
    }
}
