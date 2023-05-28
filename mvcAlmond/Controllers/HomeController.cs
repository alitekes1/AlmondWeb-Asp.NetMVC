using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvcAlmond.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()//bu metodların mutlaka view kısmında bir karşılığı olmalı.
        {
            return View();
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
    }
}