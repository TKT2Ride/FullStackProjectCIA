using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CTWMasterClass_WebAppActivities.Controllers
{
    public class CubeController : Controller
    {
        private CubeService service = new CubeService();
        public ActionResult Index()
        {
            return View(service.GetAllCubes());
        }
    }
}