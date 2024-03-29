﻿using OnlineFoodDelivery.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OnlineFoodDelivery.Web.Controllers
{
    public class HomeController : Controller
    {
       private readonly IRestaurantService db;
        public HomeController(IRestaurantService db)
        {
            this.db = db;
        }
        public ActionResult Index()
        {
            var model = db.GetAllRestaurants();
            return View(model);
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