using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MahekarusProfile.Models.Access_Modifier;

namespace MahekarusProfile.Controllers
{
    public class AccessModifierController : Controller
    {
        // GET: AccessModifier
        public ActionResult Index()
        {
            WriteToScreen wts = new WriteToScreen();
            wts.AccessModifierMain();

            return View(wts);
        }
    }
}