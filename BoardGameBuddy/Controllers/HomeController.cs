﻿using BoardGameBuddy.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace BoardGameBuddy.Controllers
{
    public class HomeController : Controller
    {
        //! field - BoardGameRepository
        private BoardGameRepository _boardGameRepository = null;

       public HomeController ()
       //! constructor - created ionstance of BoardGameRepository
        {
            _boardGameRepository = new BoardGameRepository();
        }
      


        public ActionResult Index()
        //! GET: Home
        //! date/time var passed through viewBag
        //! returns view, by default returns method path/name...
        //! ...HomeController/Index method...returns Views/Home/Index
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 12 ? "Good Morning" : "Good Afternoon";
            return View();
        }

        
         public ViewResult GameLibrary()
        //! returns view Home/GameLibiary
        //! Action Linker located in Index view
        {
            return View();
        }

        public ActionResult Detail()
        {
            return View();
        }
    }
}