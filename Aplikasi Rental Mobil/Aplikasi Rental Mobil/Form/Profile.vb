Imports System.Data.Odbc

Public Class Profile

    Sub TampilGender()
        cmbuGender.Items.Add("Laki-Laki")
        cmbuGender.Items.Add("Perempuan")
    End Sub

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
            txtFoto.Text = (Replace(DTR.Item("foto_user"), ";", "\"))
            PBUser.ImageLocation = txtFoto.Text
            PBUser.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub sUpdate_Click(sender As Object, e As EventArgs) Handles sUpdate.Click

        sUpdate.Visible = False
        uEdit.Visible = True
        lblEdit.Visible = False
        lblProfile.Visible = True
        btnBrowse.Visible = False
        txtFoto.Visible = False
        btnCancel.Visible = False
        visibleEye.Visible = False
        Invisible.Visible = False
        tuPassword.UseSystemPasswordChar = True

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
            .FotoUser = (Replace(txtFoto.Text, "\", ";"))
        End With

        With Dashboard
            .lblNama.Text = tuNama.Text
            .lblEmail.Text = tuEmail.Text
            .lblAlamat.Text = tuAlamat.Text
            .PBDashbboard.ImageLocation = txtFoto.Text
            .PBDashbboard.SizeMode = PictureBoxSizeMode.StretchImage
        End With

        KontrolRegister.updateData(EntitasRegister)

        MsgBox("Data berhasil diupdate", MsgBoxStyle.OkOnly, "Information")

        tuNama.Enabled = False
        tuEmail.Enabled = False
        tuAlamat.Enabled = False
        cmbuGender.Enabled = False
        tuUsername.Enabled = False
        tuPassword.Enabled = False
        tuNotel.Enabled = False
        tuNoKTP.Enabled = False
        txtFoto.Enabled = False

    End Sub

    Private Sub uEdit_Click(sender As Object, e As EventArgs) Handles uEdit.Click

        sUpdate.Visible = True
        uEdit.Visible = False
        lblProfile.Visible = False
        lblEdit.Visible = True
        btnBrowse.Visible = True
        txtFoto.Visible = True
        btnCancel.Visible = True
        visibleEye.Visible = False
        Invisible.Visible = True

        tuNama.Enabled = True
        tuEmail.Enabled = True
        tuAlamat.Enabled = True
        cmbuGender.Enabled = True
        tuUsername.Enabled = True
        tuPassword.Enabled = True
        tuNotel.Enabled = True
        tuNoKTP.Enabled = True
        txtFoto.Enabled = True

        PBnama.Enabled = True
        PBemail.Enabled = True
        PBalamat.Enabled = True
        PBgender.Enabled = True
        PBusername.Enabled = True
        PBpassword.Enabled = True
        PBnotel.Enabled = True
        PBnoktp.Enabled = True
    End Sub

    Private Sub Profile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilProfile()
        MdiParent = Dashboard
        TampilGender()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OPDialog2.Filter = "Jpeg|*.JPG|Bitmap| *.BMP|Gif| *.GIF"
        OPDialog2.RestoreDirectory = True
        OPDialog2.ShowDialog()
        txtFoto.Text = OPDialog2.FileName
        PBUser.ImageLocation = txtFoto.Text
        PBUser.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        sUpdate.Visible = False
        uEdit.Visible = True
        lblEdit.Visible = False
        lblProfile.Visible = True
        btnBrowse.Visible = False
        txtFoto.Visible = False
        btnCancel.Visible = False
        visibleEye.Visible = False
        Invisible.Visible = False

        tuPassword.UseSystemPasswordChar = True

        tuNama.Enabled = False
        tuEmail.Enabled = False
        tuAlamat.Enabled = False
        cmbuGender.Enabled = False
        tuUsername.Enabled = False
        tuPassword.Enabled = False
        tuNotel.Enabled = False
        tuNoKTP.Enabled = False
        txtFoto.Enabled = False

        PBnama.Enabled = False
        PBemail.Enabled = False
        PBalamat.Enabled = False
        PBgender.Enabled = False
        PBusername.Enabled = False
        PBpassword.Enabled = False
        PBnotel.Enabled = False
        PBnoktp.Enabled = False

        TampilProfile()
    End Sub

    Private Sub PBUser_Click(sender As Object, e As EventArgs) Handles PBUser.Click
        PBUser.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub visibleEye_Click(sender As Object, e As EventArgs) Handles visibleEye.Click
        tuPassword.UseSystemPasswordChar = True
        visibleEye.Visible = False
        Invisible.Visible = True
    End Sub

    Private Sub Invisible_Click(sender As Object, e As EventArgs) Handles Invisible.Click
        tuPassword.UseSystemPasswordChar = False
        visibleEye.Visible = True
        Invisible.Visible = False
    End Sub
End Class