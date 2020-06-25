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
    public class BarrelController : Controller
    {
        private BarrelService service = new BarrelService();
        // GET: Barrel
        public ActionResult Index()
        {
            return View(service.GetAllBarrels());
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
            Barrel barrel = service.GetBarrelById((int)id);
            if (barrel == null)
            {
                return HttpNotFound();
            }
            return View(barrel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Radius,Height,Weight,ConstructionMaterial,Contents,CurrentLocation,DateCreated")] Barrel barrel)
        {
            if (ModelState.IsValid)
            {
                service.AddBarrel(barrel);
                return RedirectToAction("Index");
            }

            return View(barrel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Radius,Height,Weight,ConstructionMaterial,Contents,CurrentLocation,DateCreated")] Barrel barrel)
        {
            if (ModelState.IsValid)
            {
                service.SaveEdits(barrel);
                return RedirectToAction("Index");
            }
            return View(barrel);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Barrel barrel = service.GetBarrelById((int)id);
            if (barrel == null)
            {
                return HttpNotFound();
            }
            return View(barrel);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Barrel barr = service.GetBarrelById((int)id);
            if (barr == null)
            {
                return HttpNotFound();
            }
            return View(barr);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Barrel bar = service.GetBarrelById(id);
            service.DeleteBarrel(bar);
            return RedirectToAction("Index");
        }
        public ActionResult ShowOverWeight(double weight)
        {
            return View(service.GetAboveWeight(weight));
        }

        [HttpPost]
        public ActionResult Filtered(int heavierThan)
        {
            return View("Index", service.GetAboveWeight(heavierThan));
        }
    }
}

