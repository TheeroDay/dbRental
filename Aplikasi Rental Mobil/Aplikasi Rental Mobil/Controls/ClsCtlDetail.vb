Imports System.Data.Odbc

Public Class ClsCtlDetail : Implements InfProses

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
            DTA = New OdbcDataAdapter("Select * from tbl_transaksi where id_user = '" & kunci & "'", Koneksiopen)
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
