using AsiakastietokantaMVC.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AsiakastietokantaMVC.Controllers
{
    public class ProjektitController : Controller
    {
        // GET: Projektit
        public ActionResult Index()
        {
            return View();
        }
        //public JsonResult GetList()
        //{

        //    // GET: Projektit
        //    AsiakastietokantaEntities2 entities = new AsiakastietokantaEntities2();
        //    //List<Tunti> model = entities.Projektit.ToList();

        //    var model = (from p in entities.Projektit
        //                 select new
        //                 {
        //                     ProjektiID = p.ProjektiID,
        //                     Nimi = p.Nimi
        //                     }).ToList();

        //    string json = JsonConvert.SerializeObject(model);


        //    entities.Dispose();

        //    Response.Expires = -1;
        //    Response.CacheControl = "no-cache";

        //    return Json(json, JsonRequestBehavior.AllowGet);
        //}
        //public JsonResult GetSingleProjekti(int id)
                        
        //{
        //    AsiakastietokantaEntities2 entities = new AsiakastietokantaEntities2();
        //    var model = (from p in entities.Projektit
        //                 where p.ProjektiID == id

        //                 select new
        //                 {
        //                     ProjektiID = p.ProjektiID,
        //                     Nimi = p.Nimi
        //                 }).FirstOrDefault();

        //    string json = JsonConvert.SerializeObject(model);


        //    entities.Dispose();

        //    Response.Expires = -1;
        //    Response.CacheControl = "no-cache";

        //    return Json(json, JsonRequestBehavior.AllowGet);
        //}

        //public ActionResult Update(Models.Projektit proj)
        //{
        //    AsiakastietokantaEntities2 entities = new AsiakastietokantaEntities2();
        //    string id = proj.ProjektiID;

        //    bool OK = false;

        //    // onko kyseessä muokkaus vai uuden lisääminen?
        //    if (id == "(uusi)")
        //    {
        //        // kyseessä on uuden asiakkaan lisääminen, kopioidaan kentät
        //        Models.Projektit dbItem = new Models.Projektit()
        //        {
        //            ProjektiID = proj.Nimi.Substring(0, 5).Trim().ToUpper(),
                    
        //        };

        //        // tallennus tietokantaan
        //        entities.Projektit.Add(dbItem);
        //        entities.SaveChanges();
        //        OK = true;
        //    }
        //    else
        //    {
        //        // muokkaus, haetaan id:n perusteella riviä tietokannasta
        //        Models.Projektit dbItem = (from p in entities.Projektit
        //                                  where p.ProjektiID == id
        //                                  select p).FirstOrDefault();
        //        if (dbItem != null)
        //        {
        //            dbItem.Nimi = proj.Nimi;
                    
        //            // tallennus tietokantaan
        //            entities.SaveChanges();
        //            OK = true;
        //        }
        //    }
        //    entities.Dispose();

        //    return Json(OK, JsonRequestBehavior.AllowGet);
        //}

        //public ActionResult Delete(string id)
        //{
        //    AsiakastietokantaEntities2 entities = new AsiakastietokantaEntities2();

        //    // etsitään id:n perusteella asiakasrivi kannasta
        //    bool OK = false;
        //    Projektit dbItem = (from p in entities.Projektit
        //                       where p.ProjektiID == id
        //                       select p).FirstOrDefault();
        //    if (dbItem != null)
        //    {
        //        // tietokannasta poisto
        //        entities.Projektit.Remove(dbItem);
        //        entities.SaveChanges();
        //        OK = true;
        //    }
        //    entities.Dispose();

        //    return Json(OK, JsonRequestBehavior.AllowGet);
        //}
    }
}