Imports System.Data.Odbc

Public Class ClsCtlProses : Implements InfProses

    Public Function InsertData(Ob As Object) As OdbcCommand Implements InfProses.InsertData
        Throw New NotImplementedException()
    End Function

    Public Function updateData(Ob As Object) As OdbcCommand Implements InfProses.updateData
        Throw New NotImplementedException()
    End Function

    Public Function deleteData(Ob As String) As OdbcCommand Implements InfProses.deleteData
        Throw New NotImplementedException()
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Throw New NotImplementedException()
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OdbcDataAdapter("SELECT tbl_user.nama_user, tbl_driver.nama_driver, tbl_mobil.merk, tbl_transaksi.tgl_sewa, tbl_transaksi.tgl_kembali, tbl_transaksi.hari, tbl_transaksi.harga, tbl_transaksi.total_harga, tbl_transaksi.Bayar, tbl_transaksi.Kembali, tbl_transaksi.tgl_Transaksi
            FROM tbl_transaksi JOIN tbl_user
            ON tbl_user.id_user = tbl_transaksi.id_user JOIN tbl_driver
            ON tbl_driver.id_driver = tbl_transaksi.id_driver JOIN tbl_jenismobil
            ON tbl_transaksi.kd_jenismobil = tbl_jenismobil.kd_jenismobil JOIN tbl_mobil
            ON tbl_jenismobil.kd_mobil = tbl_mobil.kd_mobil
            WHERE tbl_user.id_transaksi = '" & kunci & "'", Koneksiopen)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_id_user")
            Dim grid As New DataView(DTS.Tables("Cari_id_user"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function Login(username As String) As DataView Implements InfProses.Login
        Throw New NotImplementedException()
    End Function
End Class
