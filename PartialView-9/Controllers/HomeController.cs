﻿using Microsoft.AspNetCore.Mvc;

namespace PartialView_9.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
