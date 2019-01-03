using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MahekarusProfile.Models;
using MahekarusProfile.Models.Access_Modifier;

namespace MahekarusProfile.Controllers
{
    public class MethodOverridingController : Controller
    {
        // GET: MethodOverrriding
        public ActionResult Index()
        {
            WriteToScreen wts = new WriteToScreen();
            wts.MethodOverridingMain();

            return View(wts);
        }
    }
}