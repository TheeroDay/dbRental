Public Class ClsEntLogin
    Private _idAdmin As String
    Private _nameAdmin As String
    Private _emailAdmin As String
    Private _userAdmin As String
    Private _passAdmin As String

    Public Property IdAdmin As String
        Get
            Return _idAdmin
        End Get
        Set(value As String)
            _idAdmin = value
        End Set
    End Property

    Public Property NameAdmin As String
        Get
            Return _nameAdmin
        End Get
        Set(value As String)
            _nameAdmin = value
        End Set
    End Property

    Public Property EmailAdmin As String
        Get
            Return _emailAdmin
        End Get
        Set(value As String)
            _emailAdmin = value
        End Set
    End Property

    Public Property UserAdmin As String
        Get
            Return _userAdmin
        End Get
        Set(value As String)
            _userAdmin = value
        End Set
    End Property

    Public Property PassAdmin As String
        Get
            Return _passAdmin
        End Get
        Set(value As String)
            _passAdmin = value
        End Set
    End Property
End Class
