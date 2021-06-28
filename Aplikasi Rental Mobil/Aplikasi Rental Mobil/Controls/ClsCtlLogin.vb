Imports System.Data.Odbc

Public Class ClsCtlLogin : Implements InfProses
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
        Throw New NotImplementedException()
    End Function

    Public Function Login(username As String) As DataView Implements InfProses.Login
        Try
            DTA = New OdbcDataAdapter("select * from tbl_user where username_user = '" & username & "'", Koneksiopen)
            DTS = New DataSet()
            DTA.Fill(DTS, "Cari_Tbl_user")
            Dim grid As New DataView(DTS.Tables("Cari_Tbl_user"))
            Return grid
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
