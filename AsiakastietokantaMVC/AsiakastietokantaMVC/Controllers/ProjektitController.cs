using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AsiakastietokantaMVC.Models;

namespace AsiakastietokantaMVC.Controllers
{
    public class ProjektitController : Controller
    {
        AsiakastietokantaEntities4 db = new AsiakastietokantaEntities4();

        // GET: Projektits
        public ActionResult Index()
        {
            {
                List<Projektit> model = new List<Projektit>();
                try
                {
                    AsiakastietokantaEntities4 entities = new AsiakastietokantaEntities4();
                    model = entities.Projektit.ToList();

                    entities.Dispose();
                }

                catch (Exception ex)
                {
                    ViewBag.ErrorMessage = ex.GetType() + ": " + ex.Message;
                }

                return View(model);
            }
        }

        // GET: Projektits/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Projektit projektit = db.Projektit.Find(id);
            if (projektit == null)
            {
                return HttpNotFound();
            }
            return View(projektit);
        }

        // GET: Projektits/Create
        public ActionResult Create()
        {
            AsiakastietokantaEntities4 db = new AsiakastietokantaEntities4();

            Projektit model = new Projektit();

            return View(model);

        }

        // POST: Projektits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProjektiID,Projektinimi")] Projektit projektit)
        {
            if (ModelState.IsValid)
            {
                db.Projektit.Add(projektit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(projektit);
        }

        // GET: Projektits/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Projektit projektit = db.Projektit.Find(id);
            if (projektit == null)
            {
                return HttpNotFound();
            }
            return View(projektit);
        }

        // POST: Projektits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProjektiID,Projektinimi")] Projektit projektit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(projektit).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(projektit);
        }

        // GET: Projektits/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Projektit projektit = db.Projektit.Find(id);
            if (projektit == null)
            {
                return HttpNotFound();
            }
            return View(projektit);
        }

        // POST: Projektits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Projektit projektit = db.Projektit.Find(id);
            db.Projektit.Remove(projektit);
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
