Public Class Login
    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        DTGrid = KontrolLogin.Login(txtusername.Text).ToTable

        If txtusername.Text = "" Or txtpass.Text = "" Then
            MessageBox.Show("Silahkan masukkan Username atau Password")
        Else
            If DTGrid.Rows.Count > 0 Then
                EntitasLogin.IdUser = DTGrid.Rows(0).Item(0)
                EntitasLogin.NameUser = DTGrid.Rows(0).Item(1)
                EntitasLogin.EmailUser = DTGrid.Rows(0).Item(4)
                EntitasLogin.UserUser = DTGrid.Rows(0).Item(5)
                EntitasLogin.PassUser = DTGrid.Rows(0).Item(6)

                KodeLog = EntitasLogin.IdUser
                NameLog = EntitasLogin.NameUser

                If txtpass.Text = EntitasLogin.PassUser Then
                    Dashboard.Show()
                    txtusername.Text = ""
                    txtpass.Text = ""
                    Me.Hide()

                Else
                    MessageBox.Show("PASSWORD SALAH!!", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    txtpass.Text = ""
                    txtusername.Focus()
                End If

            Else
                MessageBox.Show("ID Tidak Dikenali!", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                txtusername.Text = ""
                txtpass.Text = ""
                txtusername.Focus()
            End If
        End If
    End Sub

    Private Sub Create_Click(sender As Object, e As EventArgs) Handles Create.Click
        Me.Hide()
        Register.Show()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub visibleEye_Click(sender As Object, e As EventArgs) Handles visibleEye.Click
        txtpass.UseSystemPasswordChar = True
        visibleEye.Visible = False
        Invisible.Visible = True
    End Sub

    Private Sub Invisible_Click(sender As Object, e As EventArgs) Handles Invisible.Click
        txtpass.UseSystemPasswordChar = False
        visibleEye.Visible = True
        Invisible.Visible = False
    End Sub

    Private Sub txtusername_MouseEnter(sender As Object, e As EventArgs) Handles txtusername.MouseEnter
        If txtusername.Text = "Username" Then
            txtusername.Text = ""
            txtusername.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtusername_MouseLeave(sender As Object, e As EventArgs) Handles txtusername.MouseLeave
        If txtusername.Text = "" Then
            txtusername.Text = "Username"
            txtusername.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub txtpass_MouseEnter(sender As Object, e As EventArgs) Handles txtpass.MouseEnter
        If txtpass.Text = "Password" Then
            txtpass.Text = ""
            txtpass.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtpass_MouseLeave(sender As Object, e As EventArgs) Handles txtpass.MouseLeave
        If txtpass.Text = "" Then
            txtpass.Text = "Password"
            txtpass.ForeColor = Color.Gray
        End If
    End Sub
End Class