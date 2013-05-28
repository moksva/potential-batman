using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GPS.Models;
using System.Text;
using System.Security.Cryptography;
using System.Web.Security;


namespace GPS.Controllers
{

    public class AutomovilController : Controller
    {
        GpsDataContext gps = new GpsDataContext();
        //
        // GET: /Automovil/

        public ActionResult Consultas()
        {
            return View();
        }

        [HttpPost]
        public JsonResult gps_ultposicion(int id)
        {
            var consulta = (from p in gps.Ctrl_Gps_Posicion select new { cve_ctrl_gps = p.Cve_Ctrl_Gps ,cve_gps = p.Cve_Gps, latitud = p.Latitud_Gps, longitud = p.Longitud_Gps }).OrderByDescending(p => p.cve_gps).Take(1);
            return Json(consulta, "application/json", Encoding.UTF8, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult gps_ultimaposicion(int id)
        {
            var posicion = gps.SP_GPS();
               /* foreach (var consulta in posicion){ }  */

            //var consulta = (from p in gps.Ctrl_Gps_Posicion select new { cve_ctrl_gps = p.Cve_Ctrl_Gps, cve_gps = p.Cve_Gps, latitud = p.Latitud_Gps, longitud = p.Longitud_Gps }).OrderByDescending(p => p.cve_gps).Take(1);
            return Json(posicion, "application/json", Encoding.UTF8, JsonRequestBehavior.AllowGet);
        }
        

        //
        // GET: /Automovil/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Automovil/Create

        public ActionResult Create()
        {
            return View();
        } 

        //
        // POST: /Automovil/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /Automovil/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Automovil/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Automovil/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Automovil/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
