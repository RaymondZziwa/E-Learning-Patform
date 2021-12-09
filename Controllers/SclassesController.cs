using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using E_Learning_Platform.Data;
using E_Learning_Platform.Models;

namespace E_Learning_Platform.Controllers
{
    public class SclassesController : Controller
    {
        private E_Learning_PlatformContext db = new E_Learning_PlatformContext();

        // GET: Sclasses
        public ActionResult Index()
        {
            return View(db.Sclasses.ToList());
        }

        // GET: Sclasses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sclass sclass = db.Sclasses.Find(id);
            if (sclass == null)
            {
                return HttpNotFound();
            }
            return View(sclass);
        }

        // GET: Sclasses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sclasses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,ClassName")] Sclass sclass)
        {
            if (ModelState.IsValid)
            {
                db.Sclasses.Add(sclass);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(sclass);
        }

        // GET: Sclasses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sclass sclass = db.Sclasses.Find(id);
            if (sclass == null)
            {
                return HttpNotFound();
            }
            return View(sclass);
        }

        // POST: Sclasses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ClassName")] Sclass sclass)
        {
            if (ModelState.IsValid)
            {
                db.Entry(sclass).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(sclass);
        }

        // GET: Sclasses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Sclass sclass = db.Sclasses.Find(id);
            if (sclass == null)
            {
                return HttpNotFound();
            }
            return View(sclass);
        }

        // POST: Sclasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Sclass sclass = db.Sclasses.Find(id);
            db.Sclasses.Remove(sclass);
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
