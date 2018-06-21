Imports System.Web.Mvc

Namespace Controllers
    Public Class ContactController
        Inherits Controller

        ' GET: Contact
        Function Contacts() As ActionResult
            ViewData("PageName") = "Contacts"
            ViewData("SiteName") = SiteName
            ViewData("PageHeader") = "КОНТАКТЫ"
            ViewData("contactList") = "Заголовок1/texttexttext1/email1" & Chr(10) &
                                      "Заголовок2/texttexttext2/email2" & Chr(10) &
                                      "Заголовок3/texttexttext3/email3" & Chr(10)
            Return View()
        End Function
    End Class
End Namespace
