using Microsoft.AspNetCore.Mvc;

namespace BloodBank.Controllers
{
    public class StockController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
