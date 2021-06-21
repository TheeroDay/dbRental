Public Class Login
    Private Sub Form2_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        DTGrid = KontrolLogin.Login(txtusername.Text).ToTable

        If txtusername.Text = "" Or txtpass.Text = "" Then
            MessageBox.Show("Silahkan masukkan Username atau Password")
        Else
            If DTGrid.Rows.Count > 0 Then
                EntitasLogin.IdAdmin = DTGrid.Rows(0).Item(0)
                EntitasLogin.NameAdmin = DTGrid.Rows(0).Item(1)
                EntitasLogin.EmailAdmin = DTGrid.Rows(0).Item(2)
                EntitasLogin.UserAdmin = DTGrid.Rows(0).Item(3)
                EntitasLogin.PassAdmin = DTGrid.Rows(0).Item(4)

                KodeLog = EntitasLogin.IdAdmin
                NameLog = EntitasLogin.NameAdmin

                If txtpass.Text = EntitasLogin.PassAdmin Then
                    Dim dashboard = New Fdashboard()
                    dashboard.Show()
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
End Class