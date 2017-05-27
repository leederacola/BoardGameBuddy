using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace BoardGameBuddy.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        //adds date time info in viewbag.greating......passes it to view
        //returns view() by deafult index (name of method)
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }

        //returns view from html.ActionLinker in index html
         public ViewResult GameLibrary()
        {
            return View();
        }
    }
}