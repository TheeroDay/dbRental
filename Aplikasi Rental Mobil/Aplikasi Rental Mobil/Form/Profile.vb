Imports System.Data.Odbc

Public Class Profile

    Sub TampilProfile()
        CMD = New OdbcCommand("select * from tbl_user where id_user = '" & KodeLog & "'", Koneksiopen)
        DTR = CMD.ExecuteReader
        DTR.Read()
        If DTR.HasRows Then
            tuNama.Text = DTR.Item("nama_user")
            tuEmail.Text = DTR.Item("email")
            tuAlamat.Text = DTR.Item("alamat")
            cmbuGender.Text = DTR.Item("gender")
            tuUsername.Text = DTR.Item("username_user")
            tuPassword.Text = DTR.Item("password_user")
            tuNotel.Text = DTR.Item("no_telp")
            tuNoKTP.Text = DTR.Item("no_ktp")
        End If

    End Sub

    Private Sub sUpdate_Click(sender As Object, e As EventArgs) Handles sUpdate.Click
        sUpdate.Visible = False
        uEdit.Visible = True
        lblEdit.Visible = False
        lblProfile.Visible = True

        With EntitasRegister
            .IdUser = KodeLog
            .NamaUser = tuNama.Text
            .Gender = cmbuGender.Text
            .Alamat = tuAlamat.Text
            .Email = tuEmail.Text
            .UsenameUser = tuUsername.Text
            .PasswordUser = tuPassword.Text
            .NoTelp = tuNotel.Text
            .NoKtp = tuNoKTP.Text
        End With

        KontrolRegister.updateData(EntitasRegister)

        tuNama.Enabled = False
        tuEmail.Enabled = False
        tuAlamat.Enabled = False
        cmbuGender.Enabled = False
        tuUsername.Enabled = False
        tuPassword.Enabled = False
        tuNotel.Enabled = False
        tuNoKTP.Enabled = False
    End Sub

    Private Sub uEdit_Click(sender As Object, e As EventArgs) Handles uEdit.Click
        sUpdate.Visible = True
        uEdit.Visible = False
        lblProfile.Visible = False
        lblEdit.Visible = True

        tuNama.Enabled = True
        tuEmail.Enabled = True
        tuAlamat.Enabled = True
        cmbuGender.Enabled = True
        tuUsername.Enabled = True
        tuPassword.Enabled = True
        tuNotel.Enabled = True
        tuNoKTP.Enabled = True
    End Sub

    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilProfile()
        MdiParent = Dashboard

    End Sub
End Class