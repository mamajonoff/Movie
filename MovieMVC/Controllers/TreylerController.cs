using Microsoft.AspNetCore.Mvc;

namespace MovieMVC.Controllers
{
    public class TreylerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
