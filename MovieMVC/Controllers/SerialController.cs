using Microsoft.AspNetCore.Mvc;

namespace MovieMVC.Controllers
{
    public class SerialController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
