Public Class MenuItemModel
    Private _text As String
    Private _controller As String
    Private _action As String
    Private _selected As Boolean

    Public Property Text As String
        Get
            Return _text
        End Get
        Set(value As String)
            _text = value
        End Set
    End Property

    Public Property Controller As String
        Get
            Return _controller
        End Get
        Set(value As String)
            _controller = value
        End Set
    End Property

    Public Property Action As String
        Get
            Return _action
        End Get
        Set(value As String)
            _action = value
        End Set
    End Property

    Public Property Selected As Boolean
        Get
            Return _selected
        End Get
        Set(value As Boolean)
            _selected = value
        End Set
    End Property

    Public Sub New(ItemText As String, ItemAction As String, ItemController As String)
        Text = ItemText
        Action = ItemAction
        Controller = ItemController
    End Sub


End Class
