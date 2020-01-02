using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proj.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.CurrentTime1 = DateTime.Now.ToString();
            return RedirectToAction("ShowHomePage", "Home");
            //return View();
        }

        public ActionResult ShowHomePage()
        {
            //ViewData["CurrentTime"] = DateTime.Now.ToString();
            return View();
        }


    }
}