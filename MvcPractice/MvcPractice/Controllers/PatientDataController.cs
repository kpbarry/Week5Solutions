using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPractice.Controllers
{
    public class PatientDataController : Controller
    {
        Models.Blood_BankEntities db = new Models.Blood_BankEntities();
        //
        // GET: /PatientData/

        public ActionResult Index()
        {
            return View(db.Patients);
        }

        public ActionResult Details(int id)
        {
            return View(db.Patients.Find(id));
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(db.Patients.Find(id));
        }
        [HttpPost]
        public ActionResult Edit(int id, Models.Patient patient)
        {
            db.Entry(patient).State = System.Data.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index", "PatientData");
        }

        public ActionResult Delete(int id)
        {
            return View(db.Patients.Find(id));
        }

        public ActionResult DeleteConfirm(int id)
        {
            Models.Patient formToDelete = db.Patients.Find(id);
            db.Patients.Remove(formToDelete);
            db.SaveChanges();

            return RedirectToAction("Index", "PatientData");
        }
    }
}
