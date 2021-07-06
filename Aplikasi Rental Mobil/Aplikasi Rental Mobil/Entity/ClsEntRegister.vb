Public Class ClsEntRegister
    Private _idUser As String
    Private _namaUser As String
    Private _gender As String
    Private _alamat As String
    Private _email As String
    Private _usenameUser As String
    Private _passwordUser As String
    Private _noTelp As String
    Private _noKtp As String
    Private _fotoUser As String


    Public Property NamaUser As String
        Get
            Return _namaUser
        End Get
        Set(value As String)
            _namaUser = value
        End Set
    End Property

    Public Property Gender As String
        Get
            Return _gender
        End Get
        Set(value As String)
            _gender = value
        End Set
    End Property

    Public Property Alamat As String
        Get
            Return _alamat
        End Get
        Set(value As String)
            _alamat = value
        End Set
    End Property

    Public Property Email As String
        Get
            Return _email
        End Get
        Set(value As String)
            _email = value
        End Set
    End Property

    Public Property UsenameUser As String
        Get
            Return _usenameUser
        End Get
        Set(value As String)
            _usenameUser = value
        End Set
    End Property

    Public Property PasswordUser As String
        Get
            Return _passwordUser
        End Get
        Set(value As String)
            _passwordUser = value
        End Set
    End Property

    Public Property NoTelp As String
        Get
            Return _noTelp
        End Get
        Set(value As String)
            _noTelp = value
        End Set
    End Property

    Public Property NoKtp As String
        Get
            Return _noKtp
        End Get
        Set(value As String)
            _noKtp = value
        End Set
    End Property

    Public Property IdUser As String
        Get
            Return _idUser
        End Get
        Set(value As String)
            _idUser = value
        End Set
    End Property

    Public Property FotoUser As String
        Get
            Return _fotoUser
        End Get
        Set(value As String)
            _fotoUser = value
        End Set
    End Property
End Class
