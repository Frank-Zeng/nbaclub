﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ClubMall.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Test
            return View();
        }

        public ActionResult About()
        {
        //Test
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
