Imports System.Data.Odbc

Public Class Dashboard

    Sub TampilProfile()
        CMD = New OdbcCommand("select nama_user, email, alamat, foto_user from tbl_user where id_user = '" & KodeLog & "'", Koneksiopen)
        DTR = CMD.ExecuteReader
        DTR.Read()
        If DTR.HasRows Then
            lblNama.Text = DTR.Item("nama_user")
            lblEmail.Text = DTR.Item("email")
            lblAlamat.Text = DTR.Item("alamat")
            txtFoto.Text = (Replace(DTR.Item("foto_user"), ";", "\"))
            PBDashbboard.ImageLocation = txtFoto.Text
            PBDashbboard.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Environment.Exit(1)
    End Sub

    Private Sub LBooking_Click(sender As Object, e As EventArgs) Handles LBooking.Click
        Detail.Close()
        Booking.Show()
        Profile.Close()

        mBooking.Visible = True
        mDBooking.Visible = False
        mProfile.Visible = False

        LDBooking.ForeColor = Color.White
        LProfile.ForeColor = Color.White

    End Sub

    Private Sub LDBooking_Click(sender As Object, e As EventArgs) Handles LDBooking.Click
        Booking.Close()
        Detail.Show()
        Profile.Close()

        mBooking.Visible = False
        mDBooking.Visible = True
        mProfile.Visible = False

        LBooking.ForeColor = Color.White
        LProfile.ForeColor = Color.White
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LProfile_Click(sender As Object, e As EventArgs) Handles LProfile.Click
        Booking.Close()
        Detail.Close()
        Profile.Show()

        mBooking.Visible = False
        mDBooking.Visible = False
        mProfile.Visible = True

        LDBooking.ForeColor = Color.White
        LBooking.ForeColor = Color.White
        LProfile.ForeColor = Color.Blue
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        btnNormal.Visible = True
        PictureBox2.Visible = False
        WindowState = FormWindowState.Maximized

    End Sub

    Private Sub btnNormal_Click(sender As Object, e As EventArgs) Handles btnNormal.Click
        btnNormal.Visible = False
        PictureBox2.Visible = True
        WindowState = FormWindowState.Normal

    End Sub

    Private Sub btnMinimized_Click(sender As Object, e As EventArgs) Handles btnMinimized.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Close()
        Login.Show()
    End Sub
End Class