Public Class MainController
    Inherits System.Web.Mvc.Controller
    Dim items As New List(Of MenuItemModel)

    Function Index() As ActionResult
        ViewData("Title") = "Index"
        ViewData("PageName") = "Index"
        ViewData("SiteName") = SiteName
        ViewData("PageHeader") = ""
        Return View()
    End Function

    Function About()
        ViewData("Title") = "About"
        ViewData("PageName") = "About"
        ViewData("SiteName") = SiteName
        ViewData("PageHeader") = "О НАС"
        Return View()
    End Function

    Function generateMenu()

        If items.Count() = 0 Then createMenu()
        Dim result As String = "<ul>"
        For Each item As MenuItemModel In items
            If item.Action = HttpContext.Request.RequestContext.RouteData.Values.Item("Action") Then
                result = result & "<li class='active'><a href='/" & item.Controller & "/" & item.Action & "'>" & item.Text & "</a></li>"
            Else
                result = result & "<li><a href='/" & item.Controller & "/" & item.Action & "'>" & item.Text & "</a></li>"
            End If
        Next
        result = result & "</ul>"
        Return Content(result)
    End Function


    Private Sub createMenu()
        With items
            .Add(New MenuItemModel("Главная", "Index", "Main"))
            .Add(New MenuItemModel("О нас", "About", "Main"))
            .Add(New MenuItemModel("Контакты", "Contacts", "Contact"))
            .Add(New MenuItemModel("Информационная страница", "About", "Main"))
            .Add(New MenuItemModel("Форма сообщения", "About", "Main"))
        End With
    End Sub

End Class
