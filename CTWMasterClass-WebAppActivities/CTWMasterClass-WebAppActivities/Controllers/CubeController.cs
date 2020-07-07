using CTWMasterClass_WebAppActivities.Models;
using CTWMasterClass_WebAppActivities.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace CTWMasterClass_WebAppActivities.Controllers
{
    public class CubeController : Controller
    {
        private CubeService service = new CubeService();
        // GET: Cube
        public ActionResult Index()
        {
            return View(service.GetAllCubes());
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cube Cube = service.GetCubeById((int)id);
            if (Cube == null)
            {
                return HttpNotFound();
            }
            return View(Cube);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Radius,Height,Weight,ConstructionMaterial,Contents,CurrentLocation,DateCreated")] Cube Cube)
        {
            if (ModelState.IsValid)
            {
                service.AddCube(Cube);
                return RedirectToAction("Index");
            }

            return View(Cube);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Radius,Height,Weight,ConstructionMaterial,Contents,CurrentLocation,DateCreated")] Cube Cube)
        {
            if (ModelState.IsValid)
            {
                service.SaveEdits(Cube);
                return RedirectToAction("Index");
            }
            return View(Cube);
        }





    }
}

