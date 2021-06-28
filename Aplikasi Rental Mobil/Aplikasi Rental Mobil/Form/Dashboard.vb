Public Class Dashboard

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub LBooking_Click(sender As Object, e As EventArgs) Handles LBooking.Click
        Detail.Close()
        Booking.Show()
        Profile.Close()

        tBook.Visible = True
        tDBook.Visible = False
        tProfile.Visible = False

        LDBooking.ForeColor = Color.White
        LBooking.ForeColor = Color.Blue
        LProfile.ForeColor = Color.White

    End Sub

    Private Sub LDBooking_Click(sender As Object, e As EventArgs) Handles LDBooking.Click
        Booking.Close()
        Detail.Show()
        Profile.Close()


        tBook.Visible = False
        tDBook.Visible = True
        tProfile.Visible = False

        LDBooking.ForeColor = Color.Blue
        LBooking.ForeColor = Color.White
        LProfile.ForeColor = Color.White
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub LProfile_Click(sender As Object, e As EventArgs) Handles LProfile.Click
        Booking.Close()
        Detail.Close()
        Profile.Show()

        tBook.Visible = False
        tDBook.Visible = False
        tProfile.Visible = True

        LDBooking.ForeColor = Color.White
        LBooking.ForeColor = Color.White
        LProfile.ForeColor = Color.Blue
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        WindowState = FormWindowState.Maximized

    End Sub
End Class