﻿Imports System.Web.Optimization

Public Module BundleConfig
    ' Дополнительные сведения об объединении см. на странице https://go.microsoft.com/fwlink/?LinkId=301862
    Public Sub RegisterBundles(ByVal bundles As BundleCollection)

        bundles.Add(New ScriptBundle("~/bundles/jquery").Include(
                    "~/Scripts/jquery-{version}.js"))

        bundles.Add(New ScriptBundle("~/bundles/jqueryval").Include(
                    "~/Scripts/jquery.validate*"))

        ' Используйте версию Modernizr для разработчиков, чтобы учиться работать. Когда вы будете готовы перейти к работе,
        ' готово к выпуску, используйте средство сборки по адресу https://modernizr.com, чтобы выбрать только необходимые тесты.
        bundles.Add(New ScriptBundle("~/bundles/modernizr").Include(
                    "~/Scripts/modernizr-*"))

        bundles.Add(New ScriptBundle("~/bundles/bootstrap").Include(
                  "~/Scripts/bootstrap.js"))

        bundles.Add(New StyleBundle("~/Content/maincss").Include(
                  "~/Content/bootstrap/bootstrap.css",
                  "~/Content/Style/common.css",
                  "~/Content/Style/Site.css"))

        bundles.Add(New StyleBundle("~/Content/contactcss").Include(
                  "~/Content/bootstrap/bootstrap.css",
                  "~/Content/Style/common.css",
                  "~/Content/Style/contact.css"))
    End Sub
End Module

