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
    public class HenkilotsController : Controller
    {
        AsiakastietokantaEntities4 db = new AsiakastietokantaEntities4();

        // GET: Henkilots
        public ActionResult Index()
        {
            {
                List<Henkilot> model = new List<Henkilot>();
                try
                {
                    AsiakastietokantaEntities4 entities = new AsiakastietokantaEntities4();
                    model = entities.Henkilot.ToList();

                    entities.Dispose();
                }

                catch (Exception ex)
                {
                    ViewBag.ErrorMessage = ex.GetType() + ": " + ex.Message;
                }

                return View(model);
            }
        }

        // GET: Henkilots/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Henkilot henkilot = db.Henkilot.Find(id);
            if (henkilot == null)
            {
                return HttpNotFound();
            }
            return View(henkilot);
        }

        // GET: Henkilots/Create
        public ActionResult Create()
        {
            AsiakastietokantaEntities4 db = new AsiakastietokantaEntities4();

            Henkilot model = new Henkilot();
            
            return View(model);
            
             
        }

        // POST: Henkilots/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Henkilot model)
        {
            AsiakastietokantaEntities4 db = new AsiakastietokantaEntities4();

            Henkilot henkilot = new Henkilot();
            henkilot.HenkiloID = model.HenkiloID;
            henkilot.Etunimi = model.Etunimi;
            henkilot.Sukunimi = model.Sukunimi;
            henkilot.Osoite = model.Osoite;
            henkilot.Esimies = model.Esimies;

            db.Henkilot.Add(henkilot);

            try
            {
                db.SaveChanges();
            }

            catch (Exception ex)
            {
            }
       
            
                return RedirectToAction("Index");
            }

    
        

        // GET: Henkilots/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Henkilot henkilot = db.Henkilot.Find(id);
            if (henkilot == null)
            {
                return HttpNotFound();
            }
            return View(henkilot);
        }

        // POST: Henkilots/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "HenkiloID,Etunimi,Sukunimi,Osoite,Esimies")] Henkilot henkilot)
        {
            if (ModelState.IsValid)
            {
                db.Entry(henkilot).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(henkilot);
        }

        // GET: Henkilots/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Henkilot henkilot = db.Henkilot.Find(id);
            if (henkilot == null)
            {
                return HttpNotFound();
            }
            return View(henkilot);
        }

        // POST: Henkilots/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Henkilot henkilot = db.Henkilot.Find(id);
            db.Henkilot.Remove(henkilot);
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
