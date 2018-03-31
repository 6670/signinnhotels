using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Optimization;

namespace SignInnHotel.App_Start
{
    public class BundleConfig
    {
            public static void RegisterBundles(BundleCollection bundles)
            {

                bundles.ResetAll();
                // create an object of ScriptBundle and 
                // specify bundle name (as virtual path) as constructor parameter 
                ScriptBundle scriptJs = new ScriptBundle("~/bundles/js");
               // StyleBundle styleCss = new StyleBundle("~/content/css/bundles");

                //use Include() method to add all the script files with their paths 
                scriptJs.Include(
                                    "~/content/js/vendor/jquery-1.11.2.min.js",
                                    "~/content/js/jquery.validate.min.js",                       
                                    "~/content/js/bootstrap.min.js",
                                    "~/content/js/rev-slider/rs-plugin/jquery.themepunch.plugins.min.js",
                                    "~/content/js/rev-slider/rs-plugin/jquery.themepunch.revolution.js",
                                    "~/content/js/rev-slider/rs.home.js",
                                    "~/content/js/uikit.min.js",
                                    "~/content/js/jquery.easing.1.3.min.js",
                                    "~/content/js/datepicker.js",
                                    "~/content/js/jquery.scrollUp.min.js",
                                    "~/content/js/owl.carousel.min.js",
                                    "~/content/js/lightslider.js",
                                    "~/content/js/wow.min.js",
                                    "~/content/js/myscript.js"
                                  );

                //styleCss.Include(
                //    "~/content/css/bootstrap.css",
                //    "~/content/css/style.css",
                //     "~/content/css/responsive.css"
                //     );

                ////Add the bundle into BundleCollection

               // bundles.Add(styleCss);
                bundles.Add(scriptJs);


                BundleTable.EnableOptimizations = true;
            }
        }
    }
