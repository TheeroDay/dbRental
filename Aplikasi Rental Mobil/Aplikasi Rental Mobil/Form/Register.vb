Public Class Register

    Sub TampilGender()
        cmbGender.Items.Add("Laki-Laki")
        cmbGender.Items.Add("Perempuan")
    End Sub

    Private Sub btnRegistrasi_Click(sender As Object, e As EventArgs) Handles btnRegistrasi.Click
        With EntitasRegister
            .NamaUser = txtNama.Text
            .Gender = cmbGender.Text
            .Alamat = txtAlamat.Text
            .Email = txtEmail.Text
            .UsenameUser = txtUsername.Text
            .PasswordUser = txtPassword.Text
            .NoTelp = txtNotelp.Text
            .NoKtp = txtNoktp.Text
            .FotoUser = txtFoto.Text
        End With

        If txtPassword.Text = "" Or txtNama.Text = "" Or cmbGender.Text = "" Or txtAlamat.Text = "" Or txtEmail.Text = "" Or txtUsername.Text = "" Or txtNotelp.Text = "" Or txtNoktp.Text = "" Then
            MsgBox("Data belum lengkap", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Information")
        Else
            KontrolRegister.InsertData(EntitasRegister)
            If MsgBox("Berhasil Registrasi, Apakah ingin login sekarang?", MsgBoxStyle.YesNo, "Information") = MsgBoxResult.Yes Then
                Me.Hide()
                Login.Show()
            End If
        End If
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.Hide()
        Login.Show()
    End Sub

    Private Sub Register_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilGender()
    End Sub

    Private Sub visibleEye_Click(sender As Object, e As EventArgs) Handles visibleEye.Click
        txtPassword.UseSystemPasswordChar = True
        visibleEye.Visible = False
        invisibleEye.Visible = True

    End Sub

    Private Sub invisibleEye_Click(sender As Object, e As EventArgs) Handles invisibleEye.Click
        txtPassword.UseSystemPasswordChar = False
        visibleEye.Visible = True
        invisibleEye.Visible = False
    End Sub

    Private Sub Browse_Click(sender As Object, e As EventArgs) Handles Browse.Click
        OFDialog.Filter = "Jpeg|*.JPG|Bitmap| *.BMP|Gif| *.GIF"
        OFDialog.RestoreDirectory = True
        OFDialog.ShowDialog()
        txtFoto.Text = OFDialog.FileName
    End Sub

    Private Sub txtFoto_TextChanged(sender As Object, e As EventArgs) Handles txtFoto.TextChanged
        txtFoto.Text = (Replace(txtFoto.Text, "\", ";"))
    End Sub
End Class