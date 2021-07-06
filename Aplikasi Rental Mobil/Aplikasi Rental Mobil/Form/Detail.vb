Public Class Detail

    Sub Buattabel()
        LVTransaksi.Columns.Add("ID", 120, HorizontalAlignment.Center)
        LVTransaksi.Columns.Add("Nama", 400, HorizontalAlignment.Center)
        LVTransaksi.Columns.Add("Tanggal Transaksi", 400, HorizontalAlignment.Center)
        LVTransaksi.View = View.Details
        LVTransaksi.GridLines = True
        LVTransaksi.FullRowSelect = True
    End Sub '

    Sub TampilTransaksi()
        DTGrid = KontrolDetail.cariData(KodeLog).ToTable
        LVTransaksi.Items.Clear()
        Dim strItem(3) As String
        If DTGrid.Rows.Count > 0 Then
            For i = 0 To DTGrid.Rows.Count - 1
                strItem(0) = DTGrid.Rows(i).Item(0).ToString
                strItem(1) = NameLog
                strItem(2) = DTGrid.Rows(i).Item(2).ToString

                LVTransaksi.Items.Add(New ListViewItem(strItem))
            Next
        End If
    End Sub

    Private Sub Detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Buattabel()
        TampilTransaksi()
        MdiParent = Dashboard
    End Sub

    Private Sub btnDetail_Click(sender As Object, e As EventArgs) Handles btnDetail.Click
        Dim idTransaksi = LVTransaksi.SelectedItems(0).SubItems(0).Text
        DTGrid = KontrolDetail.cariTransaksi(idTransaksi).ToTable

        If DTGrid.Rows.Count > 0 Then
            For i = 0 To DTGrid.Rows.Count - 1
                If DTGrid.Rows(i).Item(15).ToString = "Belum Lunas" Then
                    With Detail_Booking
                        .xId.Text = DTGrid.Rows(i).Item(0).ToString
                        .xNama.Text = DTGrid.Rows(i).Item(1).ToString
                        .xMulai.Text = DTGrid.Rows(i).Item(6).ToString
                        .xSelesai.Text = DTGrid.Rows(i).Item(7).ToString
                        .xLokasi.Text = DTGrid.Rows(i).Item(8).ToString
                        .xDriver.Text = (Replace(DTGrid.Rows(i).Item(2).ToString, "null", "-"))
                        .xMobil.Text = DTGrid.Rows(i).Item(4).ToString
                        .xNopol.Text = DTGrid.Rows(i).Item(5).ToString
                        .xNotel.Text = (Replace(DTGrid.Rows(i).Item(3).ToString, "", "-"))
                        .xHarga.Text = DTGrid.Rows(i).Item(10).ToString
                        .xHari.Text = DTGrid.Rows(i).Item(9).ToString
                        .xTotal1.Text = DTGrid.Rows(i).Item(11).ToString

                        Detail_Booking.StartPosition = FormStartPosition.CenterScreen
                        Detail_Booking.Show()
                    End With
                Else
                    With TransaksiSelesai
                        .xId.Text = DTGrid.Rows(i).Item(0).ToString
                        .xNama.Text = DTGrid.Rows(i).Item(1).ToString
                        .xMulai.Text = DTGrid.Rows(i).Item(6).ToString
                        .xSelesai.Text = DTGrid.Rows(i).Item(7).ToString
                        .xLokasi.Text = DTGrid.Rows(i).Item(8).ToString
                        .xDriver.Text = (Replace(DTGrid.Rows(i).Item(2).ToString, "null", "-"))
                        .xMobil.Text = DTGrid.Rows(i).Item(4).ToString
                        .xNopol.Text = DTGrid.Rows(i).Item(5).ToString
                        .xNotel.Text = (Replace(DTGrid.Rows(i).Item(3).ToString, "", "-"))
                        .xHarga.Text = DTGrid.Rows(i).Item(10).ToString
                        .xHari.Text = DTGrid.Rows(i).Item(9).ToString
                        .xTotal.Text = DTGrid.Rows(i).Item(11).ToString
                        .xBayar.Text = DTGrid.Rows(i).Item(12).ToString
                        .lblKembali.Text = DTGrid.Rows(i).Item(13).ToString

                        TransaksiSelesai.StartPosition = FormStartPosition.CenterScreen
                        TransaksiSelesai.Show()
                    End With
                End If
            Next
        End If


    End Sub
End Class