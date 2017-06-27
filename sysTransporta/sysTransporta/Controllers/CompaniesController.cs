using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using sysTransporta.Models;

namespace sysTransporta.Controllers
{
    public class CompaniesController : Controller
    {
        private Tr2Context db = new Tr2Context();

        // GET: Companies
        public ActionResult Index()
        {
            var companies = db.Companies.Include(c => c.plan);
            return View(companies.ToList());
        }

        // GET: Companies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Company company = db.Companies.Include(c => c.plan).FirstOrDefault(x => x.Id == id);
            if (company == null)
            {
                return HttpNotFound();
            }
            return PartialView(company);
        }

        // GET: Companies/Create
        public ActionResult Create()
        {
            ViewBag.PlanId = new SelectList(db.Plans.Where(x => x.enable), "Id", "Name");
            return PartialView();
        }

        // POST: Companies/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateNew([Bind(Include = "Id,LegalName,Nit,ResolucionNumber,QualificationYear,Street,Phone1,Phone2,EMail,ContactName,Manager,VehicleCant,PlanId,LastContractNumber")] Company company)
        {
            if (ModelState.IsValid)
            {
                db.Companies.Add(company);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.PlanId = new SelectList(db.Plans.Where(x => x.enable), "Id", "Name", company.PlanId);
            return PartialView(company);
        }

        // GET: Companies/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Company company = db.Companies.Find(id);
            if (company == null)
            {
                return HttpNotFound();
            }
            ViewBag.PlanId = new SelectList(db.Plans.Where(x => x.enable), "Id", "Name", company.PlanId);
            return PartialView(company);
        }

        // POST: Companies/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditItem([Bind(Include = "Id,LegalName,Nit,ResolucionNumber,QualificationYear,Street,Phone1,Phone2,EMail,ContactName,Manager,VehicleCant,PlanId,LastContractNumber")] Company company)
        {
            if (ModelState.IsValid)
            {
                db.Entry(company).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.PlanId = new SelectList(db.Plans.Where(x => x.enable), "Id", "Name", company.PlanId);
            return PartialView(company);
        }

        // GET: Companies/Delete/5
        public ActionResult DeleteItem(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Company company = db.Companies.Find(id);
            if (company == null)
            {
                return HttpNotFound();
            }
            return PartialView("Delete", company);
        }

        // POST: Companies/Delete/5
        [HttpPost, ActionName("DeleteConfirmed")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Company company = db.Companies.Find(id);
            company.enable = false;
            db.Entry(company).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
