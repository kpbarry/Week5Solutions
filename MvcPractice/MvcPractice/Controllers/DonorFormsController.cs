using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPractice.Controllers
{
    public class DonorFormsController : Controller
    {
        //
        // GET: /DonorForms/
        [HttpGet]
        public ActionResult Index()
        {
            return View(new Models.Donor());
        }
        [HttpPost]
        public ActionResult Index(Models.Donor donor)
        {
            Models.Blood_BankEntities db = new Models.Blood_BankEntities();
            db.Donors.Add(donor);
            db.SaveChanges();
            return RedirectToAction("ThankYou", "DonorForm");
        }


        public ActionResult ThankYou()
        {
            return View();
        }
    }
}
