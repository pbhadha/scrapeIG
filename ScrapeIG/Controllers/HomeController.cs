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

            //Using statement is used for types that implement IDisposable
            //After the use is complete, it disposes it
            using (HttpClient aClient = new HttpClient()) {
                var postParameters = new Dictionary<string, string> {
                    { "client_id", " d77b5e5cdd794485a10b72a5377bfb3d" },
                    { "client_secret", "d77b5e5cdd794485a10b72a5377bfb3d" },
                    { "grant_type", "authorization_code" },
                    { "redirect_uri", "http://localhost/ScrapeIG/" },
                    { "code", " fa9f830bd43b4942ba1e886daa2a2ed3" }
                };
                var content = new FormUrlEncodedContent(postParameters);

                var response = aClient.PostAsync("https://api.instagram.com/oauth/access_token", content);

                var responseString = response.Result;
            }

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