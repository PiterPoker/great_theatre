using System.Web.Optimization;

namespace great_theatre
{
    public class BundleConfig
    {
        //Дополнительные сведения об объединении см. по адресу: http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                "~/Scripts/jquery.validate*"));

            // Используйте версию Modernizr для разработчиков, чтобы учиться работать. Когда вы будете готовы перейти к работе,
            // используйте средство сборки на сайте http://modernizr.com, чтобы выбрать только нужные тесты.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                "~/Scripts/bootstrap.js",
                "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                "~/Content/bootstrap.css",
                "~/Content/style.css"));
            bundles.Add(new StyleBundle("~/Content/admin").Include(
                "~/Content/bootstrap.min.css",
                "~/Content/style-admin.css",
                "~/Content/lines.css",
                "~/Content/font-awesome.css",
                "~/Content/custom.css"));
            bundles.Add(new ScriptBundle("~/bundles/adminJS").Include(
                "~/Scripts/jquery.min.js",
                "~/Scripts/jquery.vmap.js",
                "~/Scripts/jquery.vmap.sampledata.js",
                "~/Scripts/jquery.vmap.world.js",
                "~/Scripts/bootstrap.min.js",
                "~/Scripts/Chart.js",
                "~/Scripts/clndr.js",
                "~/Scripts/d3.v3.js",
                "~/Scripts/metisMenu.min.js",
                "~/Scripts/moment-2.2.1.js",
                "~/Scripts/rickshaw.js",
                "~/Scripts/site.js",
                "~/Scripts/underscore-min.js",
                "~/Scripts/custom.js"));
        }
    }
}