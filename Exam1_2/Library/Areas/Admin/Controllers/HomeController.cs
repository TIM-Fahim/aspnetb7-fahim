﻿using Microsoft.AspNetCore.Mvc;
//Exam1_2.Library.Areas.Admin.Controllers
namespace Exam1_2.Library.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
