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
    public class ProfileController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.UserId = User.Identity.GetUserId();

            return View();
        }

        // GET: Profiles
        public ActionResult SearchProfile()
        {
            return View();
        }

    }
}