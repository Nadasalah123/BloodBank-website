using Microsoft.AspNetCore.Mvc;

namespace BloodBank.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About_Us()
        {
            return View();
        }
    }
}
