using BloodBank.Data;
using BloodBank.Models;
using Microsoft.AspNetCore.Mvc;

namespace BloodBank.Controllers
{
    public class NeedController : Controller
    {
        ApplicationDBContext db;
        public NeedController(ApplicationDBContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult needs()
        {
            return View(new Needers());
        }

        [HttpPost]
        public IActionResult needs(IFormCollection frm)
        {
            Needers n = new Needers() { };
            n.needer_name = frm["name"].ToString();
            n.email = frm["email"].ToString();
            n.phone = frm["phone"].ToString();
            n.gender = frm["gender"].ToString();
            n.BloodType = frm["BloodType"].ToString();
            db.Needers.Add(n);
            db.SaveChanges();

            return View();
        }
    }
}
