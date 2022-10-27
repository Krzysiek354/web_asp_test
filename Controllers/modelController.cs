using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;


namespace WebApplication2.Controllers
{
    public class modelController : Controller
    {
        // GET: model
        public ActionResult model()
        {
            var dana = new WebApplication2.Models.dane();
            dana.dana = "GOGOGOGO";
            ViewBag.dane = dana.dana;
            return View();
        }
        [HttpPost]
        public ActionResult form(string txttId)
        {
            ViewBag.Id = txttId;
            var z = new WebApplication2.Models.zapis(txttId);
            return View("model");
        }



       
    }
}