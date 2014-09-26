using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPractice.Controllers
{
    public class PatientFormsController : Controller
    {
        //
        // GET: /DonorForm/

        [HttpGet]
        public ActionResult Index()
        {
            return View(new Models.Patient());
        }

        [HttpPost]
        public ActionResult Index(Models.Patient patient)
        {
            Models.Blood_BankEntities db = new Models.Blood_BankEntities();
            db.Patients.Add(patient);
            db.SaveChanges();
            return RedirectToAction("ThankYou", "PatientForm");
            }
        public ActionResult ThankYou()
        {
            return View();
        }
    }
}
