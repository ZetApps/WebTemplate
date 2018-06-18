Imports System.Web.Mvc

Namespace Controllers
    Public Class ContactController
        Inherits Controller

        ' GET: Contact
        Function Contacts() As ActionResult
            ViewData("PageName") = "Contacts"
            ViewData("SiteName") = SiteName
            ViewData("PageHeader") = "КОНТАКТЫ"
            Return View()
        End Function
    End Class
End Namespace