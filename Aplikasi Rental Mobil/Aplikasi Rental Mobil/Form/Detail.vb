Public Class Detail

    Sub Buattabel()
        LVTransaksi.Columns.Add("Nama", 120, HorizontalAlignment.Center)
        LVTransaksi.Columns.Add("Driver", 120, HorizontalAlignment.Center)
        LVTransaksi.Columns.Add("Mobil", 130, HorizontalAlignment.Center)
        LVTransaksi.Columns.Add("Tanggal Mulai", 120, HorizontalAlignment.Center)
        LVTransaksi.Columns.Add("Tanggal Selesai", 120, HorizontalAlignment.Center)
        LVTransaksi.Columns.Add("Harga", 120, HorizontalAlignment.Center)
        LVTransaksi.Columns.Add("Hari", 120, HorizontalAlignment.Center)
        LVTransaksi.Columns.Add("Total Harga", 120, HorizontalAlignment.Center)
        LVTransaksi.View = View.Details
        LVTransaksi.GridLines = True
        LVTransaksi.FullRowSelect = True
    End Sub '

    Sub TampilTransaksi()
        DTGrid = KontrolDetail.cariData(KodeLog).ToTable
        LVTransaksi.Items.Clear()
        Dim strItem(8) As String
        If DTGrid.Rows.Count > 0 Then
            For i = 0 To DTGrid.Rows.Count - 1
                strItem(0) = NameLog
                strItem(1) = DTGrid.Rows(i).Item(4).ToString
                strItem(2) = DTGrid.Rows(i).Item(5).ToString
                strItem(3) = DTGrid.Rows(i).Item(1).ToString
                strItem(4) = DTGrid.Rows(i).Item(2).ToString
                strItem(5) = DTGrid.Rows(i).Item(7).ToString
                strItem(6) = DTGrid.Rows(i).Item(6).ToString
                strItem(7) = DTGrid.Rows(i).Item(8).ToString

                LVTransaksi.Items.Add(New ListViewItem(strItem))
            Next
        End If
    End Sub

    Private Sub Detail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Buattabel()
        TampilTransaksi()
        MdiParent = Dashboard
    End Sub
End Class