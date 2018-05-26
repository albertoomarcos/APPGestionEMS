using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace APPGestionEMS.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Enunciado de la práctica";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "¿En qué consiste este proyecto?";

            return View();
        }
    }
}