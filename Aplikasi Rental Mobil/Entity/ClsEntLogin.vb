Public Class ClsEntLogin
    Private _idUser As String
    Private _nameUser As String
    Private _emailUser As String
    Private _userUser As String
    Private _passUser As String

    Public Property IdUser As String
        Get
            Return _idUser
        End Get
        Set(value As String)
            _idUser = value
        End Set
    End Property

    Public Property NameUser As String
        Get
            Return _nameUser
        End Get
        Set(value As String)
            _nameUser = value
        End Set
    End Property

    Public Property EmailUser As String
        Get
            Return _emailUser
        End Get
        Set(value As String)
            _emailUser = value
        End Set
    End Property

    Public Property UserUser As String
        Get
            Return _userUser
        End Get
        Set(value As String)
            _userUser = value
        End Set
    End Property

    Public Property PassUser As String
        Get
            Return _passUser
        End Get
        Set(value As String)
            _passUser = value
        End Set
    End Property
End Class
