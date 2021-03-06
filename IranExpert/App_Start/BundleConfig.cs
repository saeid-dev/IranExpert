﻿using System.Web.Optimization;

namespace IranExpert
{
    public class BundleConfig
    {
        // Weitere Informationen zur Bündelung finden Sie unter https://go.microsoft.com/fwlink/?LinkId=301862.
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery.min.js",
                        "~/Scripts/jquery.easing.min.js",
                        "~/Scripts/sb-admin-2.js",
                         "~/Scripts/typeahead.bundle.js",
                         "~/Scripts/jquery-3.3.1.js",
                         "~/Scripts/toastr.js",
                         "~/Scripts/datatables/jquery.datatables.js",
                         "~/Scripts/datatables/datatables.bootstrap.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Verwenden Sie die Entwicklungsversion von Modernizr zum Entwickeln und Erweitern Ihrer Kenntnisse. Wenn Sie dann
            // bereit ist für die Produktion, verwenden Sie das Buildtool unter https://modernizr.com, um nur die benötigten Tests auszuwählen.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/bootstrap.bundle.js",
                      "~/Scripts/bootstrap.bundle.min.js"
                      ));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/sb-admin-2.css",
                      "~/Content/all.min.css",
                      "~/Content/fontawesome-free/css/all.min.css",
                      "~/Content/site.css",
                      "~/Content/typeahead.css",
                      "~/Content/toastr.css",
                      "~/Content/jquery-ui.css",
                      "~/Content/datatables/css/datatables.bootstrap.css"
                      ));
        }
    }
}
