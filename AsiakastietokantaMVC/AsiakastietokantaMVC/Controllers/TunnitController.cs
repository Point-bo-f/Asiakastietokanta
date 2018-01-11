using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AsiakastietokantaMVC.Models;
using Newtonsoft.Json;

namespace AsiakastietokantaMVC.Controllers
{
    public class TunnitController : Controller
    {
        private AsiakastietokantaEntities db = new AsiakastietokantaEntities();

        // GET: Tunnits
        public ActionResult Index()
        {
            return View(db.Tunnit.ToList());
        }

        // GET: Tunnits/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tunnit tunnit = db.Tunnit.Find(id);
            if (tunnit == null)
            {
                return HttpNotFound();
            }
            return View(tunnit);
        }

        // GET: Tunnits/Create
        public ActionResult Create()
        {
            AsiakastietokantaEntities db = new AsiakastietokantaEntities();

            Tunnit model = new Tunnit();

            return View(model);
        }

        // POST: Tunnits/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TuntiID,ProjektiID,HenkiloID,Pvm,Projektitunnit")] Tunnit tunnit)
        {
            if (ModelState.IsValid)
            {
                db.Tunnit.Add(tunnit);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tunnit);
        }

        // GET: Tunnits/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tunnit tunnit = db.Tunnit.Find(id);
            if (tunnit == null)
            {
                return HttpNotFound();
            }
            return View(tunnit);
        }

        // POST: Tunnits/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TuntiID,ProjektiID,HenkiloID,Pvm,Projektitunnit")] Tunnit tunnit)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tunnit).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tunnit);
        }

        // GET: Tunnits/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Tunnit tunnit = db.Tunnit.Find(id);
            if (tunnit == null)
            {
                return HttpNotFound();
            }
            return View(tunnit);
        }

        // POST: Tunnits/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Tunnit tunnit = db.Tunnit.Find(id);
            db.Tunnit.Remove(tunnit);
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