using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace ScrapeIG.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Debug.WriteLine(WebConfigurationManager.AppSettings["InstagramAccessToken"]);

            //http://localhost/ScrapeIG/?code=fa9f830bd43b4942ba1e886daa2a2ed3

            HttpClient aClient = new HttpClient();
            //aClient.BaseAddress = "";


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