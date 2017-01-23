using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Autofac.Builder;
using Autofac;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public Iserver _Iserver;

        public HomeController(Iserver  server)
        {
            _Iserver = server;
        }
        public HomeController()
        {
        }

        public ActionResult Index()
        {
           string tt=_Iserver.Show();

            return Content(tt);
        }

        public ActionResult ZZZ()
        {
            string tt = _Iserver.Show();

            return Content(tt);
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