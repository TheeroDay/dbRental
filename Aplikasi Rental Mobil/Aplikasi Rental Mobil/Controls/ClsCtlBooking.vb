Imports System.Data.Odbc

Public Class ClsCtlBooking : Implements InfProses
    Public Function InsertData(Ob As Object) As OdbcCommand Implements InfProses.InsertData
        Dim data As New ClsEntBooking
        data = Ob
        CMD = New OdbcCommand("insert into tbl_transaksi(tgl_sewa, tgl_kembali, id_user, id_driver, no_telp, kd_jenismobil, lokasi, hari, harga, total_harga, tgl_Transaksi, status_pembayaran) values('" & data.TglSewa & "','" & data.TglKembali & "','" & data.IdUser & "'," & data.IdDriver & ",'" & data.NoTelp & "','" & data.KdJenismobil & "','" & data.Lokasi & "','" & data.Hari & "','" & data.Harga & "','" & data.TotalHarga & "','" & data.TglTransaksi & "','" & data.StatusPembayaran & "')", Koneksiopen)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", koneksiclose)
        Return CMD
    End Function

    Public Function updateData(Ob As Object) As OdbcCommand Implements InfProses.updateData
        Dim data As New ClsEntBooking
        data = Ob
        CMD = New OdbcCommand("update tbl_transaksi set Bayar = '" & data.Bayar & "', Kembali = '" & data.Kembali & "', tgl_Transaksi = '" & data.TglTransaksi & "', status_pembayaran = '" & data.StatusPembayaran & "' where id_transaksi = '" & data.IdTransaksi & "'", Koneksiopen)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", koneksiclose)
        Return CMD
    End Function

    Public Function deleteData(Ob As String) As OdbcCommand Implements InfProses.deleteData
        Throw New NotImplementedException()
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData
        Throw New NotImplementedException()
    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Try
            DTA = New OdbcDataAdapter("Select * from tbl_jenismobil where kd_mobil " & " Like '%" & kunci & "%'", Koneksiopen)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_mobil")
            Dim grid As New DataView(DTS.Tables("Cari_mobil"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function Login(username As String) As DataView Implements InfProses.Login
        Throw New NotImplementedException()
    End Function
End Class
