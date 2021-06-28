Imports System.Data.Odbc

Public Class Booking
    Sub TampilMobil()
        CMD = New OdbcCommand("select merk from tbl_mobil", Koneksiopen)
        DTR = CMD.ExecuteReader
        cmbMobil.Items.Clear()
        Do While DTR.Read
            cmbMobil.Items.Add(DTR.Item("merk"))
        Loop
        Koneksiopen.Close()
    End Sub

    Sub TampilDriver()
        CMD = New OdbcCommand("select nama_driver from tbl_driver", Koneksiopen)
        DTR = CMD.ExecuteReader
        cmbDriver.Items.Clear()
        Do While DTR.Read
            cmbDriver.Items.Add(DTR.Item("nama_driver"))
        Loop
        Koneksiopen.Close()
    End Sub

    Sub Buattabel()
        LVMobil.Columns.Add("ID Mobil", 120, HorizontalAlignment.Center)
        LVMobil.Columns.Add("Merk", 120, HorizontalAlignment.Center)
        LVMobil.Columns.Add("Seri Mobil", 130, HorizontalAlignment.Center)
        LVMobil.Columns.Add("Tahun Keluaran", 120, HorizontalAlignment.Center)
        LVMobil.Columns.Add("No. Polisi", 120, HorizontalAlignment.Center)
        LVMobil.Columns.Add("Status", 120, HorizontalAlignment.Center)
        LVMobil.Columns.Add("Kapasitas Penumpang", 120, HorizontalAlignment.Center)
        LVMobil.Columns.Add("Harga", 120, HorizontalAlignment.Center)
        LVMobil.View = View.Details
        LVMobil.GridLines = True
        LVMobil.FullRowSelect = True
    End Sub

    Private Sub Booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilMobil()
        TampilDriver()
        Buattabel()
        MdiParent = Dashboard

        txtMobil.Enabled = False
        lblDriver.Enabled = False
        cmbDriver.Enabled = False
    End Sub

    Private Sub cmbMobil_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbMobil.SelectedIndexChanged
        CMD = New OdbcCommand("select * from tbl_mobil where merk = '" & cmbMobil.Text & "'", Koneksiopen)
        DTR = CMD.ExecuteReader
        DTR.Read()
        If DTR.HasRows Then
            txtMobil.Text = DTR.Item("kd_mobil")
        Else
            MessageBox.Show("Merk mobil tidak terdaftar")
        End If
    End Sub

    Private Sub cmbDriver_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDriver.SelectedIndexChanged
        CMD = New OdbcCommand("select * from tbl_driver where nama_driver = '" & cmbDriver.Text & "'", Koneksiopen)
        DTR = CMD.ExecuteReader
        DTR.Read()
        If DTR.HasRows Then
            txtDriver.Text = DTR.Item("id_driver")
        End If
    End Sub

    Private Sub cariMobil_Click(sender As Object, e As EventArgs) Handles cariMobil.Click
        DTGrid = KontrolBooking.cariData(txtMobil.Text).ToTable
        LVMobil.Items.Clear()
        If txtMobil.Text = "" Then
            MsgBox("Masukkan mobil yang ingin dicari", MsgBoxStyle.OkOnly)
        Else
            Dim strItem(8) As String
            If DTGrid.Rows.Count > 0 Then
                For i = 0 To DTGrid.Rows.Count - 1
                    strItem(0) = DTGrid.Rows(i).Item(0).ToString
                    strItem(1) = DTGrid.Rows(i).Item(1).ToString
                    strItem(2) = DTGrid.Rows(i).Item(2).ToString
                    strItem(3) = DTGrid.Rows(i).Item(3).ToString
                    strItem(4) = DTGrid.Rows(i).Item(5).ToString
                    strItem(5) = DTGrid.Rows(i).Item(6).ToString
                    strItem(6) = DTGrid.Rows(i).Item(7).ToString
                    strItem(7) = DTGrid.Rows(i).Item(4).ToString

                    LVMobil.Items.Add(New ListViewItem(strItem))
                Next
            Else
                MsgBox("Maaf, mobil " & cmbMobil.Text & " sedang tidak ada", MsgBoxStyle.OkOnly)
            End If
        End If

    End Sub

    Private Sub cbDriver_CheckedChanged(sender As Object, e As EventArgs) Handles cbDriver.CheckedChanged
        If cbDriver.Checked = True Then
            lblDriver.Enabled = True
            cmbDriver.Enabled = True
        Else
            cmbDriver.Enabled = False
            lblDriver.Enabled = False
        End If
    End Sub

    Private Sub Book_Click(sender As Object, e As EventArgs) Handles Book.Click
        With EntitasBooking
            .TglSewa = Format(DTPMulai.Value, "yyyy-MM-dd")
            .TglKembali = Format(DTPSelesai.Value, "yyyy-MM-dd")
            .IdUser = KodeLog
            If txtDriver.Text = "" Then
                .IdDriver = "0"
            Else
                .IdDriver = txtDriver.Text
            End If

            .KdJenismobil = LVMobil.SelectedItems(0).SubItems(0).Text
            .Hari = DateDiff(DateInterval.Day, CDate(DTPMulai.Text), CDate(DTPSelesai.Text))
            .Harga = LVMobil.SelectedItems(0).SubItems(7).Text
            .TotalHarga = LVMobil.SelectedItems(0).SubItems(7).Text * DateDiff(DateInterval.Day, CDate(DTPMulai.Text), CDate(DTPSelesai.Text))
        End With

        KontrolBooking.InsertData(EntitasBooking)

        With Detail_Booking
            .xMulai.Text = DTPMulai.Text
            .xSelesai.Text = DTPSelesai.Text
            .xLokasi.Text = txtLokasi.Text
            If DTPMulai.Value < DTPSelesai.Value Then
                .xHari.Text = DateDiff(DateInterval.Day, CDate(DTPMulai.Text), CDate(DTPSelesai.Text))
            End If
            If cmbDriver.Text = "" Then
                .xDriver.Text = "-"
            Else
                .xDriver.Text = cmbDriver.Text
            End If
            .xMobil.Text = cmbMobil.Text
            .xHarga.Text = LVMobil.SelectedItems(0).SubItems(7).Text
            .xNopol.Text = LVMobil.SelectedItems(0).SubItems(4).Text
            .xTotal.Text = .xHarga.Text * .xHari.Text
        End With

        Detail_Booking.Show()
    End Sub
End Class