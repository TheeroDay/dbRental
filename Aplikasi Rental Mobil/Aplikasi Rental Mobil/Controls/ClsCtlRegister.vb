Imports System.Data.Odbc

Public Class ClsCtlRegister : Implements InfProses

    Public Function InsertData(Ob As Object) As OdbcCommand Implements InfProses.InsertData
        Dim data As New ClsEntRegister
        data = Ob
        CMD = New OdbcCommand("insert into tbl_user(nama_user, gender, alamat, email, username_user, password_user, no_telp, no_ktp) values('" & data.NamaUser & "','" & data.Gender & "','" & data.Alamat & "','" & data.Email & "','" & data.UsenameUser & "','" & data.PasswordUser & "','" & data.NoTelp & "','" & data.NoKtp & "')", Koneksiopen)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", koneksiclose)
        Return CMD
    End Function

    Public Function updateData(Ob As Object) As OdbcCommand Implements InfProses.updateData
        Dim data As New ClsEntRegister
        data = Ob
        CMD = New OdbcCommand("update tbl_user set nama_user = '" & data.NamaUser & "', gender = '" & data.Gender & "', alamat = '" & data.Alamat & "', email = '" & data.Email & "', username_user = '" & data.UsenameUser & "', password_user = '" & data.PasswordUser & "', no_telp = '" & data.NoTelp & "', no_ktp = '" & data.NoKtp & "' where id_user = '" & data.IdUser & "'", Koneksiopen)
        CMD.CommandType = CommandType.Text
        CMD.ExecuteNonQuery()
        CMD = New OdbcCommand("", koneksiclose)
        Return CMD
    End Function

    Public Function deleteData(Ob As String) As OdbcCommand Implements InfProses.deleteData
        Throw New NotImplementedException()
    End Function

    Public Function tampilData() As DataView Implements InfProses.tampilData

    End Function

    Public Function cariData(kunci As String) As DataView Implements InfProses.cariData
        Throw New NotImplementedException()
    End Function

    Public Function Login(username As String) As DataView Implements InfProses.Login
        Throw New NotImplementedException()
    End Function
End Class
