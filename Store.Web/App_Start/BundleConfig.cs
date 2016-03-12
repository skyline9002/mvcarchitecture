using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace Store.Web.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {


            #region Example CSS and JS Bundles
            bundles.Add(new ScriptBundle("~/bootstrap/js").Include("~/js/bootstrap.js", "~/js/site.js"));
            bundles.Add(new StyleBundle("~/bootstrap/css").Include("~/css/bootstrap.css", "~/css/site.css")); 
            #endregion

            #region CV CSS Bundles
            bundles.Add(new StyleBundle("~/cv/css")
              .Include(
              "~/bstemplate/bootstrap/css/bootstrap.min.css",
              "~/bstemplate/css/owl.theme.css",
              "~/bstemplate/css/owl.carousel.css",
              "~/bstemplate/css/magnific-popup.css",
              "~/bstemplate/css/simpletextrotator.css",
              "~/bstemplate/css/font-awesome.min.css",
              "~/bstemplate/css/animate.css"
              )); 
            #endregion

            #region CV JS Bundles
            bundles.Add(new ScriptBundle("~/cv/js")
                .Include(
                "~/bstemplate/js/jquery-1.11.0.min.js",
                "~/bstemplate/bootstrap/js/bootstrap.min.js",
                "~/bstemplate/js/jquery.backstretch.min.js",
                "~/bstemplate/js/owl.carousel.min.js",
                "~/bstemplate/js/jquery.magnific-popup.min.js",
                "~/bstemplate/js/jquery.simple-text-rotator.min.js",
                "~/bstemplate/js/jquery.waypoints.js",
                "~/bstemplate/js/jquery.countTo.js",
                "~/bstemplate/js/wow.min.js",
                "~/bstemplate/js/smoothscroll.js",
                "~/bstemplate/js/jquery.fitvids.js"
                )); 
            #endregion
            BundleTable.EnableOptimizations = true;
           
        }
    }
}