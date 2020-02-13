using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AdiasWebpage.Controllers
{
    public class CvController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SwedishCv()
        {
            return View();
        }

    }
}