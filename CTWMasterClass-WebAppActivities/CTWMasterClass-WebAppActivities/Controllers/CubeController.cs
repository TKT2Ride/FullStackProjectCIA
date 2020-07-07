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
        public ActionResult Index()
        {
            return View(service.GetAllCubes());
        }

        public ActionResult ShowOverLength(double length)
        {
            return View(service.GetAboveLength(length));
        }

        [HttpPost]
        public ActionResult Filtered(int longerThan)
        {
            return View("Index", service.GetAboveLength(longerThan));
        }
    }
}
