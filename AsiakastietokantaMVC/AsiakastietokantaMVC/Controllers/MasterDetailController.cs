using AsiakastietokantaMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AsiakastietokantaMVC.Controllers
{
    public class MasterDetailController : Controller
    {
        // GET: MasterDetail
        public ActionResult Index()
        
        {
            AsiakastietokantaEntities entities = new AsiakastietokantaEntities();
           
            try
            {
                List<Henkilot> model = entities.Henkilot.ToList();
                return View(model);
            }
            finally
            {
                entities.Dispose();
            }
            
        }
    }
}