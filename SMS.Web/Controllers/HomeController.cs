using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SMS.Web.Models;
using SMS.Data.Models;

namespace SMS.Web.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            // return Content("The home page");                   
            //return Content("<html><h2>The Home page</h2></html>", "text/html");
                
            ViewBag.Date = DateTime.Now;
            ViewBag.Message = "This is the home page!";
            return View();
        }

        public IActionResult About()
        {       
            var about = new AboutViewModel();
            about.Formed = new DateTime(2019, 01, 01);
            about.Days = (DateTime.Now - about.Formed).Days;
            
            return View(about);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
