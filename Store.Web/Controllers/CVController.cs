﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Store.Web.Controllers
{
    public class CVController : Controller
    {
        // GET: CV
        public ActionResult Index()
        {
            return View();
        }

        [ChildActionOnly]
        public ActionResult IntroductionSection()
        {
            return PartialView("_IntroductionSection");
        }

    }
}