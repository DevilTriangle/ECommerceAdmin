using System.Web.Optimization;

namespace AdminECommerceWeb
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
            bundles.Add(new ScriptBundle("~/Content/customJs").Include(
                        "~/Content/assets/plugins/pace/pace.min.js",
                        "~/Content/assets/plugins/jquery/jquery-3.3.1.min.js",
                        "~/Content/assets/plugins/jquery-ui/jquery-ui.min.js",
                        "~/Content/assets/plugins/bootstrap/4.1.3/js/bootstrap.bundle.min.js",
                        "~/Content/assets/plugins/slimscroll/jquery.slimscroll.min.js",
                        "~/Content/assets/plugins/js-cookie/js.cookie.js",
                        "~/Content/assets/js/theme/default.min.js",
                        "~/Content/assets/js/apps.min.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            bundles.Add(new StyleBundle("~/Content/customCss").Include(
                        "~/Content/assets/plugins/jquery-ui/jquery-ui.min.css",
                        "~/Content/assets/plugins/bootstrap/4.1.3/css/bootstrap.min.css",
                        "~/Content/assets/plugins/font-awesome/5.3/css/all.min.css",
                        "~/Content/assets/plugins/animate/animate.min.css",
                        "~/Content/assets/css/default/style.min.css",
                        "~/Content/assets/css/default/style-responsive.min.css",
                        "~/Content/assets/css/default/theme/default.css"));
        }
    }

}
