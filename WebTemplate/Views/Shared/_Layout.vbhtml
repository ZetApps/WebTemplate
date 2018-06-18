<!DOCTYPE html>
<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>@ViewData("Title") – приложение ASP.NET</title>
    @Styles.Render("~/Content/maincss")
    @Scripts.Render("~/bundles/modernizr")
</head>
<body>
    @Code
        If IsSectionDefined(ViewData("PageName")) Then
            Dim imagesrc = "/Content/img/bg_" & ViewData("PageName") & ".jpg"
    End Code
            <img Class="mainbgimage" src='@imagesrc'>
    @Code
        End If
    End Code
    <div Class="logo">
    @*<img src="~/Content/img/nologo.jpg" alt="nologo" />*@
    @Code
        If ViewData("PageHeader") <> "" Then
    End Code
        <span>@ViewData("SiteName") - @ViewData("PageHeader")</span>
    @Code
        Else
    End Code
        <span>@ViewData("SiteName")</span>
    @Code
        End If
    End Code
        
    </div>
    <div Class="pagewrapper">
        <div Class="navigation">
            <div class="nav">
                @Html.Action("generateMenu", "Main")
            </div>
        </div>
        <div class="content">
            @If IsSectionDefined(ViewData("PageName")) Then
                @RenderSection(ViewData("PageName"))
            End If
        </div>
    </div>

    @Scripts.Render("~/bundles/jquery")
    @Scripts.Render("~/bundles/bootstrap")
    @Scripts.Render("~/bundles/jquery")
</body>
</html>
