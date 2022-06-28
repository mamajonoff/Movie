using Microsoft.AspNetCore.Mvc;
using MovieMVC.Models;
using System.Diagnostics;

namespace MovieMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Serial()
        {
            return View();
        }
    }
}