//using AsiakastietokantaMVC.Models;
//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;

//namespace AsiakastietokantaMVC.Controllers
//{
//    //public class HenkilotController : Controller
//    //{
//    //    // GET: Projektit
//    //   // public ActionResult Index()
//    //   // {
//    //        //List<Henkilot> model = new AsiakastietokantaEntities3();
//    //        //try
//    //        {
//    //            AsiakastietokantaEntities3 entities = new AsiakastietokantaEntities3();
//    //           // model = entities.Henkilot.ToList();

//    //           // entities.Dispose();
//    //        }

//            //catch (Exception ex)
//            //{
//               // ViewBag.ErrorMessage = ex.GetType() + ": " + ex.Message;
//            }

//            //return View(model);

//            //{

//            //    // GET: Projektit
//            //    AsiakastietokantaEntities2 entities = new AsiakastietokantaEntities2();
//            //    //List<Projektit> model = entities.Projektit.ToList();

//            //    var model = (from h in entities.Henkilot
//            //                 select new
//            //                 {
//            //                     HenkilöId = h.HenkiloID,
//            //                     Etunimi = h.Etunimi,
//            //                     Sukunimi = h.Sukunimi,
//            //                     Osoite = h.Osoite,
//            //                     Esimies = h.Esimies
//            //                 }).ToList();

//            //    string json = JsonConvert.SerializeObject(model);


//            //    entities.Dispose();

//            //    Response.Expires = -1;
//            //    Response.CacheControl = "no-cache";

//            //    return Json(json, JsonRequestBehavior.AllowGet);
//            //}
//            //public JsonResult GetSingleHenkilo(int id)
//            //{
//            //    AsiakastietokantaEntities2 entities = new AsiakastietokantaEntities2();
//            //    var model = (from h in entities.Henkilot

//            //                 where h.HenkiloID == id

//            //                 select new
//            //                 {
//            //                     HenkilöId = h.HenkiloID,
//            //                     Etunimi = h.Etunimi,
//            //                     Sukunimi = h.Sukunimi,
//            //                     Osoite = h.Osoite,
//            //                     Esimies = h.Esimies                                        

//            //                 }).FirstOrDefault();

//            //    string json = JsonConvert.SerializeObject(model);
//            //    entities.Dispose();

//            //    return Json(json, JsonRequestBehavior.AllowGet);
//            //}
//            //public ActionResult Update(Models.Henkilot henk)
//            //{
//            //    AsiakastietokantaEntities2 entities = new AsiakastietokantaEntities2();
//            //    int id = henk.HenkiloID;

//            //    bool OK = false;

//            //    // onko kyseessä muokkaus vai uuden lisääminen?
//            //    if (id = "(uusi)")
//            //    {
//            //        // kyseessä on uuden asiakkaan lisääminen, kopioidaan kentät
//            //        Models.Henkilot dbItem = new Models.Henkilot()
//            //        {
//            //            //HenkiloID = henk.Etunimi.Substring(0, 5).Trim().ToUpper(),
//            //            Etunimi = henk.Etunimi,
//            //            Sukunimi = henk.Sukunimi,
//            //            Osoite = henk.Osoite,
//            //            Esimies = henk.Esimies
//            //        };

//            //        // tallennus tietokantaan
//            //        entities.Henkilot.Add(dbItem);
//            //        entities.SaveChanges();
//            //        OK = true;
//            //    }
//            //    else
//            //    {
//            //        // muokkaus, haetaan id:n perusteella riviä tietokannasta
//            //        Models.Henkilot dbItem = (from c in entities.Henkilot
//            //                           where c.HenkiloID == id
//            //                           select c).FirstOrDefault();
//            //        if (dbItem != null)
//            //        {
//            //            dbItem.Etunimi = henk.Etunimi;
//            //            dbItem.Sukunimi = henk.Sukunimi;
//            //            dbItem.Osoite = henk.Osoite;
//            //            dbItem.Esimies = henk.Esimies;

//            //            // tallennus tietokantaan
//            //            entities.SaveChanges();
//            //            OK = true;
//            //        }
//            //    }
//            //    entities.Dispose();

//            //    return Json(OK, JsonRequestBehavior.AllowGet);
//            //}

//            //public ActionResult Delete(int id)
//            //{
//            //    AsiakastietokantaEntities2 entities = new AsiakastietokantaEntities2();

//            //    // etsitään id:n perusteella asiakasrivi kannasta
//            //    bool OK = false;
//            //    Henkilot dbItem = (from h in entities.Henkilot
//            //                       where h.HenkiloID == id
//            //                       select h).FirstOrDefault();
//            //    if (dbItem != null)
//            //    {
//            //        // tietokannasta poisto
//            //        entities.Henkilot.Remove(dbItem);
//            //        entities.SaveChanges();
//            //        OK = true;
//            //    }
//            //    entities.Dispose();

//            //    return Json(OK, JsonRequestBehavior.AllowGet);
//            //}
//        }
//    }
//}