using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Http;

namespace MahekarusProfile.Controllers
{
    public class AppsController : Controller
    {
        
        // GET: Apps
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Game()
        {
            return View();
        }

        public ActionResult WebAPI()
        {
            return View("API");
        }

    }
}