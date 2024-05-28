using BloodBank.Data;
using BloodBank.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BloodBank.Controllers
{
    public class ContactController : Controller
    {
        ApplicationDBContext db;
        public ContactController(ApplicationDBContext db)
        {
            this.db = db;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Contact_Us()
        {
            return View(new Communucation());
        }

        [HttpPost]
        public IActionResult Contact_Us(IFormCollection frm)
        {
            Communucation c = new Communucation() { };
            c.person_name = frm["name"].ToString();
            c.email = frm["email"].ToString();
            c.subject = frm["subject"].ToString();
            c.message = frm["message"].ToString();
            db.Communucations.Add(c);
            db.SaveChanges();
            
            return View();
        }
    }
}
