Public Class Detail_Booking

    Private Sub TPTanggal_Tick(sender As Object, e As EventArgs) Handles TPTanggal.Tick
        Dim namaHari As String()
        namaHari = New String() {" \M\i\n\g\g\u", "\S\e\n\i\n", "\S\e\l\a\s\a", "\R\a\b\u", "\K\a\m\i\s", "\J\u\m\a\t", "\S\a\b\t\u"}
        xTanggal.Text = Format(Now, namaHari(Now.DayOfWeek()) & ", dd MMMM yyyy ")
    End Sub

    Private Sub Detail_Booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        xNama.Text = NameLog
        StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles btnBayar.Click

        If Val(xBayar1.Text) >= Val(xTotal1.Text) Then

            With EntitasBooking
                .IdTransaksi = xId.Text
                .Bayar = xBayar1.Text
                .Kembali = Val(xBayar1.Text) - Val(xTotal1.Text)
                .TglTransaksi = Format(Now, "yyyy-MM-dd")
                .StatusPembayaran = "Lunas"
            End With

            KontrolBooking.updateData(EntitasBooking)

            With TransaksiSelesai
                .lblKembali.Text = xBayar1.Text - xTotal1.Text
                .xNama.Text = xNama.Text
                .xMulai.Text = xMulai.Text
                .xSelesai.Text = xSelesai.Text
                .xLokasi.Text = xLokasi.Text
                .xDriver.Text = xDriver.Text
                .xMobil.Text = xMobil.Text
                .xNopol.Text = xNopol.Text
                .xNotel.Text = xNotel.Text
                .xHarga.Text = xHarga.Text
                .xHari.Text = xHari.Text
                .xTotal.Text = xTotal1.Text
                .xBayar.Text = xBayar1.Text
                .xTanggal.Text = xTanggal.Text

                Me.Close()
                TransaksiSelesai.StartPosition = FormStartPosition.CenterScreen
                TransaksiSelesai.Show()
            End With

        Else
            MessageBox.Show("Saldo anda tidak cukup untuk melakukan transaksi ini!!", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class