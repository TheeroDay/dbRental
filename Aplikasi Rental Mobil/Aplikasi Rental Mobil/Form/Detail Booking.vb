Public Class Detail_Booking
    Private Sub TPTanggal_Tick(sender As Object, e As EventArgs) Handles TPTanggal.Tick
        Dim namaHari As String()
        namaHari = New String() {" \M\i\n\g\g\u", "\S\e\n\i\n", "\S\e\l\a\s\a", "\R\a\b\u", "\K\a\m\i\s", "\J\u\m\a\t", "\S\a\b\t\u"}
        xTanggal.Text = Format(Now, namaHari(Now.DayOfWeek()) & ", dd MMMM yyyy ")
    End Sub

    Private Sub Detail_Booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        xNama.Text = NameLog
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub
End Class