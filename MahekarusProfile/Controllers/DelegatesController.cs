﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MahekarusProfile.Models.Delegates;

namespace MahekarusProfile.Controllers
{
    public class DelegatesController : Controller
    {
        // GET: Delegates
        public ActionResult Index()
        {
            var program = new Program();

            return View(program);
        }
    }
}