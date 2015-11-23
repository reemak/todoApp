using System.Web;
using System.Web.Optimization;

namespace TodoApp
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/bower_components/jquery/dist/jquery.min.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bower_components").Include(
                    "~/bower_components/bootstrap/dist/js/bootstrap.min.js"
                    , "~/bower_components/angular/angular.min.js"
                    , "~/bower_components/angular-bootstrap/ui-bootstrap.min.js"
                    , "~/bower_components/angular-ui-router/release/angular-ui-router.min.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/bower_components/bootstrap/dist/css/bootstrap.min.css"
                      , "~/Content/site.css"
                     
                      ));

            bundles.Add(new ScriptBundle("~/app").Include(
                "~/app/app.js"
                ,"~/app/lists/lists.directive.js"
                ));
        }
    }
}
