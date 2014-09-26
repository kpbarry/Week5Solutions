using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcPractice.Controllers
{
    public class DonorDataController : Controller
    {
        Models.Blood_BankEntities db = new Models.Blood_BankEntities();
        //
        // GET: /DonorData/
        public ActionResult Index()
        {
            return View(db.Donors);
        }

        public ActionResult Details(int id)
        {
            return View(db.Donors.Find(id));
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(db.Donors.Find(id));
        }
        [HttpPost]
        public ActionResult Edit(int id, Models.Donor donor)
        {
            db.Entry(donor).State = System.Data.EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index", "DonorData");
        }

        public ActionResult Delete(int id)
        {
            return View(db.Donors.Find(id));
        }

        public ActionResult DeleteConfirm(int id)
        {
            Models.Donor formToDelete = db.Donors.Find(id);
            db.Donors.Remove(formToDelete);
            db.SaveChanges();

            return RedirectToAction("Index", "DonorData");
        }
    }
}
