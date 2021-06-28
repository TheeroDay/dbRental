Public Class ClsEntBooking
    Private _tglSewa As String
    Private _tglKembali As String
    Private _idUser As String
    Private _idDriver As String
    Private _kdJenismobil As String
    Private _hari As String
    Private _harga As String
    Private _totalHarga As String
    Private _statusPembayaran As String

    Public Property TglSewa As String
        Get
            Return _tglSewa
        End Get
        Set(value As String)
            _tglSewa = value
        End Set
    End Property

    Public Property TglKembali As String
        Get
            Return _tglKembali
        End Get
        Set(value As String)
            _tglKembali = value
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

    Public Property IdDriver As String
        Get
            Return _idDriver
        End Get
        Set(value As String)
            _idDriver = value
        End Set
    End Property

    Public Property KdJenismobil As String
        Get
            Return _kdJenismobil
        End Get
        Set(value As String)
            _kdJenismobil = value
        End Set
    End Property

    Public Property TotalHarga As String
        Get
            Return _totalHarga
        End Get
        Set(value As String)
            _totalHarga = value
        End Set
    End Property

    Public Property StatusPembayaran As String
        Get
            Return _statusPembayaran
        End Get
        Set(value As String)
            _statusPembayaran = value
        End Set
    End Property

    Public Property Hari As String
        Get
            Return _hari
        End Get
        Set(value As String)
            _hari = value
        End Set
    End Property

    Public Property Harga As String
        Get
            Return _harga
        End Get
        Set(value As String)
            _harga = value
        End Set
    End Property
End Class
