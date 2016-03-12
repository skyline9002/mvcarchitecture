using System;
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

        [ChildActionOnly]
        public ActionResult ContactSection()
        {
            return PartialView("_ContactSection");
        }

        [ChildActionOnly]
        public ActionResult ProfileSection()
        {
            return PartialView("_ProfileSection");
        }
        
        [ChildActionOnly]
        public ActionResult StatsSection()
        {
            return PartialView("_StatsSection");
        }

        [ChildActionOnly]
        public ActionResult CalloutSection()
        {
            return PartialView("_CalloutSection");
        }

        [ChildActionOnly]
        public ActionResult ClientSection()
        {
            return PartialView("_ClientSection");
        }

        [ChildActionOnly]
        public ActionResult ResumeSection()
        {
            return PartialView("_ResumeSection");
        }

        [ChildActionOnly]
        public ActionResult PortfolioSection()
        {
            return PartialView("_PortfolioSection");
        }

        [ChildActionOnly]
        public ActionResult FooterContactSection()
        {
            return PartialView("_FooterContactSection");
        }

        [ChildActionOnly]
        public ActionResult FooterSection()
        {
            return PartialView("_FooterSection");
        }

        [ChildActionOnly]
        public ActionResult ServiceSection()
        {
            return PartialView("_ServiceSection");
        }

    }
}