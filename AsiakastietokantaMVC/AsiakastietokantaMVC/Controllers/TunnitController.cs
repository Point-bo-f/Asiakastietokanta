using AsiakastietokantaMVC.Models;
using Newtonsoft.Json;
using System.Linq;
using System.Web.Mvc;

namespace AsiakastietokantaMVC.Controllers
{
    public class TunnitController : Controller
    {
        // GET: Tunnit
        public ActionResult Index()
        {
            return View();
        }
    //    public JsonResult GetList()
    //    {

    //        // GET: Projektit
    //        AsiakastietokantaEntities2 entities = new AsiakastietokantaEntities2();
    //        //List<Tunti> model = entities.Projektit.ToList();

    //        var model = (from t in entities.Tunnit
    //                     select new
    //                     {
    //                         TuntiID = t.TuntiID,
    //                         ProjektiID = t.ProjektiID,
    //                         HenkilöID = t.HenkiloID,
    //                         Pvm = t.Pvm,
    //                         Tyotunnit = t.Tunnit1
    //                     }).ToList();

    //        string json = JsonConvert.SerializeObject(model);

    //        entities.Dispose();

    //        Response.Expires = -1;
    //        Response.CacheControl = "no-cache";

    //        return Json(json, JsonRequestBehavior.AllowGet);

    //    }
    //    public JsonResult GetSingleTunti(string id)
    //    {
    //        AsiakastietokantaEntities2 entities = new AsiakastietokantaEntities2();
    //                    var model = (from t in entities.Tunnit
    //                        where t.TuntiID == id

    //                                 select new
    //                     {
    //                         TuntiID = t.TuntiID,
    //                         ProjektiID = t.ProjektiID,
    //                         HenkilöID = t.HenkiloID,
    //                         Pvm = t.Pvm,
    //                         Tyotunnit = t.Tunnit1

    //                     }).FirstOrDefault();

    //        string json = JsonConvert.SerializeObject(model);
    //        entities.Dispose();

    //        return Json(json, JsonRequestBehavior.AllowGet);
    //    }

    //    public ActionResult Update(Models.Tunnit tunt)
    //    {
    //        AsiakastietokantaEntities2 entities = new AsiakastietokantaEntities2();
    //        string id = tunt.TuntiID;

    //        bool OK = false;

    //        // onko kyseessä muokkaus vai uuden lisääminen?
    //        if (id == "(uusi)")
    //        {
    //            // kyseessä on uuden asiakkaan lisääminen, kopioidaan kentät
    //            Models.Tunnit dbItem = new Models.Tunnit()
    //            {
    //                TuntiID = tunt.ProjektiID.Substring(0, 5).Trim().ToUpper(),
    //                HenkiloID = tunt.HenkiloID,
    //                Pvm = tunt.Pvm,
    //                Tunnit1 = tunt.Tunnit1
    //            };

    //            // tallennus tietokantaan
    //            entities.Tunnit.Add(dbItem);
    //            entities.SaveChanges();
    //            OK = true;
    //        }
    //        else
    //        {
    //            // muokkaus, haetaan id:n perusteella riviä tietokannasta
    //            Models.Tunnit dbItem = (from t in entities.Tunnit
    //                                      where t.TuntiID == id
    //                                      select t).FirstOrDefault();
    //            if (dbItem != null)
    //            {
    //                dbItem.ProjektiID = tunt.ProjektiID;
    //                dbItem.HenkiloID = tunt.HenkiloID;
    //                dbItem.Pvm = tunt.Pvm;
    //                dbItem.Tunnit1 = tunt.Tunnit1;

    //                // tallennus tietokantaan
    //                entities.SaveChanges();
    //                OK = true;
    //            }
    //        }
    //        entities.Dispose();

    //        return Json(OK, JsonRequestBehavior.AllowGet);
    //    }

    //    public ActionResult Delete(int id)
    //    {
    //        AsiakastietokantaEntities2 entities = new AsiakastietokantaEntities2();

    //        // etsitään id:n perusteella asiakasrivi kannasta
    //        bool OK = false;
    //        Tunnit dbItem = (from t in entities.Tunnit
    //                          where t.TuntiID == id
    //                          select t).FirstOrDefault();
    //        if (dbItem != null)
    //        {
    //            // tietokannasta poisto
    //            entities.Tunnit.Remove(dbItem);
    //            entities.SaveChanges();
    //            OK = true;
    //        }
    //        entities.Dispose();

    //        return Json(OK, JsonRequestBehavior.AllowGet);
    //    }
    }
}