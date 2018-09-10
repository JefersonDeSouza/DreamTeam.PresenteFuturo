using System.Web;
using System.Web.Optimization;

namespace Site
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

            bundles.Add(new ScriptBundle("~/Scripts").Include(
                      "~/Scripts/main.js"));

            bundles.Add(new ScriptBundle("~/Content/vendor").Include(
                     "~/Content/vendor/animsition/js/animsition.js",
                     "~/Content/vendor/animsition/js/animsition.min.js",
                     "~/Content/vendor/bootstrap/js/bootstrap.js",
                     "~/Content/vendor/bootstrap/js/bootstrap.min.js",
                     "~/Content/vendor/bootstrap/js/popper.js",
                     "~/Content/vendor/bootstrap/js/popper.min.js",
                     "~/Content/vendor/bootstrap/js/tooltip.js",
                     "~/Content/vendor/countdowntime/countdowntime.js",
                     "~/Content/vendor/daterangepicker/daterangepicker.js",
                     "~/Content/vendor/daterangepicker/moment.js",
                     "~/Content/vendor/daterangepicker/moment.min.js",
                     "~/Content/vendor/jquery/jquery-3.2.1.min.js",
                     "~/Content/vendor/perfect-scrollbar/perfect-scrollbar.min.js",
                     "~/Content/vendor/select2/select2.js",
                     "~/Content/vendor/select2/select2.min.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/bootstrap.min.css",
                      "~/Content/bootstrap-theme.css",
                      "~/Content/bootstrap-theme.min.css",
                      //"~/Content/site.css",
                      "~/Content/main.css",
                      "~/Content/util.css"));

            bundles.Add(new StyleBundle("~/Content/vendor").Include(
                     "~/Content/vendor/animate/animate.css",
                     "~/Content/vendor/animsition/animsition.css",
                     "~/Content/vendor/bootstrap/css/bootstrap-grid.css",
                     "~/Content/vendor/bootstrap/css/bootstrap-grid.min.css",
                     "~/Content/vendor/bootstrap/css/bootstrap-reboot.css",
                     "~/Content/vendor/bootstrap/css/bootstrap-reboot.min.css",
                     "~/Content/vendor/bootstrap/css/bootstrap.min.css",
                     "~/Content/vendor/bootstrap/css/bootstrap.css",
                     "~/Content/vendor/css-hamburgers/hamburgers.css",
                     "~/Content/vendor/css-hamburgers/hamburgers.min.css",
                     "~/Content/vendor/daterangepicker/daterangepicker.css",
                     "~/Content/vendor/perfect-scrollbar/perfect-scrollbar.css",
                     "~/Content/vendor/select2/select2.css",
                     "~/Content/vendor/select2/select2.min.css"
                     ));
        }
    }
}
