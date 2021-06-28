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
        End With

        If txtPassword.Text = "" Then
            MsgBox("Data belum lengkap", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Information")
        ElseIf txtNama.Text = "" Then
            MsgBox("Data belum lengkap", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Information")
        ElseIf cmbGender.Text = "" Then
            MsgBox("Data belum lengkap", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Information")
        ElseIf txtAlamat.Text = "" Then
            MsgBox("Data belum lengkap", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Information")
        ElseIf txtEmail.Text = "" Then
            MsgBox("Data belum lengkap", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Information")
        ElseIf txtUsername.Text = "" Then
            MsgBox("Data belum lengkap", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Information")
        ElseIf txtNotelp.Text = "" Then
            MsgBox("Data belum lengkap", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Information")
        ElseIf txtNoktp.Text = "" Then
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
End Class