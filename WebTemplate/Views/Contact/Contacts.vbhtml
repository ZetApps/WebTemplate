@Code
    Layout = "~/Views/Shared/_ContactLayout.vbhtml"
End Code
@Section Contacts
    <div class="sectionContact">
        @Code                 
            Dim title As String
            Dim text As String
            Dim email As String
            For Each contact As String In Split(ViewData("contactList"), Chr(10))
                If contact <> "" Then
                    title = Split(contact, "/")(0)
                    text = Split(contact, "/")(1)
                    email = Split(contact, "/")(2)
        End Code
            <div class="contact">
                <div class="title">
                    @title
                </div>
                <div Class="text">
                    @text
                </div>
                <div Class="email">
                    @email
                </div>
            </div>
        @Code
                End If
            Next
        End Code
    </div>
End Section
