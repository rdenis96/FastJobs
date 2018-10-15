using System.Web;
using System.Web.Optimization;

namespace WebPlatform
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                      "~/Content/bootstrap.css"));

            //StartPage bundles
            bundles.Add(new ScriptBundle("~/bundles/StartPage/js").Include("~/Content/StartPage/js/jquery-min.js")
                                                                .Include("~/Content/StartPage/js/popper.min.js")
                                                                .Include("~/Content/StartPage/js/bootstrap.min.js")
                                                                .Include("~/Content/StartPage/js/jquery.mixitup.js")
                                                                .Include("~/Content/StartPage/js/nivo-lightbox.js")
                                                                .Include("~/Content/StartPage/js/owl.carousel.js")
                                                                .Include("~/Content/StartPage/js/jquery.stellar.min.js")
                                                                .Include("~/Content/StartPage/js/jquery.nav.js")
                                                                .Include("~/Content/StartPage/js/scrolling-nav.js")
                                                                .Include("~/Content/StartPage/js/jquery.easing.min.js")
                                                                .Include("~/Content/StartPage/js/smoothscroll.js")
                                                                .Include("~/Content/StartPage/js/jquery.slicknav.js")
                                                                .Include("~/Content/StartPage/js/wow.js")
                                                                .Include("~/Content/StartPage/js/jquery.vide.js")
                                                                .Include("~/Content/StartPage/js/jquery.counterup.min.js")
                                                                .Include("~/Content/StartPage/js/jquery.magnific-popup.min.js")
                                                                .Include("~/Content/StartPage/js/waypoints.min.js")
                                                                .Include("~/Content/StartPage/js/form-validator.min.js")
                                                                .Include("~/Content/StartPage/js/contact-form-script.js")
                                                                .Include("~/Content/StartPage/js/main.js"));

            bundles.Add(new StyleBundle("~/bundles/StartPage/css").IncludeDirectory(
                        "~/Content/StartPage/css",
                        "*.css",
                        true));

            bundles.Add(new StyleBundle("~/bundles/Global/css").Include(
                        "~/Content/Global/Navbar.css"));

            bundles.Add(new StyleBundle("~/bundles/Profile/css/Preview").Include(
                        "~/Content/Profile/Preview.css"));
        }
    }
}