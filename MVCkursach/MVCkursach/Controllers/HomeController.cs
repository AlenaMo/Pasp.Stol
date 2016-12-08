using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCkursach.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Доброе утро" : "Доброго дня";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Здесь вы найдете краткую инфрмацию.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Наши контакты.";

            return View();
        }
    }
}
