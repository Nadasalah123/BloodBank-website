using BloodBank.Data;
using BloodBank.Models;
using Microsoft.AspNetCore.Mvc;

namespace BloodBank.Controllers
{
    public class DonateController : Controller
    {
        ApplicationDBContext db;
        public DonateController(ApplicationDBContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Donation()
        {
            return View(new Donors());
        }

        
        [HttpPost]
        public IActionResult Donation(IFormCollection frm)
        {
            Donors d = new Donors() { };
            d.donor_name = frm["name"].ToString();
            d.email = frm["email"].ToString();
            d.phone = frm["phone"].ToString();
            d.gender = frm["gender"].ToString();
            d.BloodType = frm["BloodType"].ToString();
            db.Donors.Add(d);
            db.SaveChanges();

            return View();
        }
    }
}
