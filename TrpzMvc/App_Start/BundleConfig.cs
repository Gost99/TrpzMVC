using System.Web;
using System.Web.Optimization;

namespace TrpzMvc
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/Vendor/js").Include(
                      "~/Content/Vendor/js/jquery-3.3.1.min.js", 
                      "~/Content/Vendor/js/bootstrap.bundle.min.js",
                      "~/Content/Vendor/js/jquery-ui.js",
                      "~/Content/Vendor/js/jquery.validate.js"));

            bundles.Add(new StyleBundle("~/Vendor/css").Include(
                      "~/Content/Vendor/css/bootstrap.min.css",
                      "~/Content/Vendor/css/jquery-ui.css"));

            bundles.Add(new ScriptBundle("~/Content/js").Include(
                "~/Content/js/main.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/css/theme.css"));

        }
    }
}
