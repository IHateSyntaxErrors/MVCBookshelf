﻿using System.Web.Mvc;

namespace MVCBookshelf.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}