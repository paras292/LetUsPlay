using LetUsPlay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LetUsPlay.Controllers
{
  
    [Authorize]
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            return RedirectToAction("SelectOptions");
        }

        [Authorize(Roles = "Admin")]
        public ActionResult ListOfLocations()
        {
            return View(db.Locations.ToList());
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult SelectOptions()
        {
            return View();
        }
    }
}