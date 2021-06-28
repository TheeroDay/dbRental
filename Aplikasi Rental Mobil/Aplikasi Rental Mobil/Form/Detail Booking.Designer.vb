<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Detail_Booking
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Detail_Booking))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.xNama = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.xMulai = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.xTotal = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.xNopol = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.xMobil = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.xDriver = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.xLokasi = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.xSelesai = New System.Windows.Forms.Label()
        Me.xTanggal = New System.Windows.Forms.Label()
        Me.TPTanggal = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.xHari = New System.Windows.Forms.Label()
        Me.Hari = New System.Windows.Forms.Label()
        Me.xHarga = New System.Windows.Forms.Label()
        Me.Harga = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(92, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama            :"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(557, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(112, 20)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Hari/Tanggal  :"
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(309, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(258, 46)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Detail Booking"
        '
        'xNama
        '
        Me.xNama.AutoSize = True
        Me.xNama.BackColor = System.Drawing.Color.Transparent
        Me.xNama.Font = New System.Drawing.Font("Segoe UI", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xNama.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.xNama.Location = New System.Drawing.Point(233, 117)
        Me.xNama.Name = "xNama"
        Me.xNama.Size = New System.Drawing.Size(21, 23)
        Me.xNama.TabIndex = 10
        Me.xNama.Text = "X"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.BackColor = System.Drawing.Color.Transparent
        Me.Label17.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(92, 164)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(124, 23)
        Me.Label17.TabIndex = 23
        Me.Label17.Text = "Tgl Mulai       :"
        '
        'xMulai
        '
        Me.xMulai.AutoSize = True
        Me.xMulai.BackColor = System.Drawing.Color.Transparent
        Me.xMulai.Font = New System.Drawing.Font("Segoe UI", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xMulai.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.xMulai.Location = New System.Drawing.Point(237, 164)
        Me.xMulai.Name = "xMulai"
        Me.xMulai.Size = New System.Drawing.Size(21, 23)
        Me.xMulai.TabIndex = 24
        Me.xMulai.Text = "X"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(469, 618)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(129, 23)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Total               :"
        '
        'xTotal
        '
        Me.xTotal.AutoSize = True
        Me.xTotal.BackColor = System.Drawing.Color.Transparent
        Me.xTotal.Font = New System.Drawing.Font("Segoe UI", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xTotal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.xTotal.Location = New System.Drawing.Point(614, 618)
        Me.xTotal.Name = "xTotal"
        Me.xTotal.Size = New System.Drawing.Size(21, 23)
        Me.xTotal.TabIndex = 12
        Me.xTotal.Text = "X"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(89, 374)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(124, 23)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "No.Polisi        :"
        '
        'xNopol
        '
        Me.xNopol.AutoSize = True
        Me.xNopol.BackColor = System.Drawing.Color.Transparent
        Me.xNopol.Font = New System.Drawing.Font("Segoe UI", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xNopol.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.xNopol.Location = New System.Drawing.Point(234, 374)
        Me.xNopol.Name = "xNopol"
        Me.xNopol.Size = New System.Drawing.Size(21, 23)
        Me.xNopol.TabIndex = 14
        Me.xNopol.Text = "X"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(89, 331)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 23)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Mobil             :"
        '
        'xMobil
        '
        Me.xMobil.AutoSize = True
        Me.xMobil.BackColor = System.Drawing.Color.Transparent
        Me.xMobil.Font = New System.Drawing.Font("Segoe UI", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xMobil.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.xMobil.Location = New System.Drawing.Point(234, 331)
        Me.xMobil.Name = "xMobil"
        Me.xMobil.Size = New System.Drawing.Size(21, 23)
        Me.xMobil.TabIndex = 16
        Me.xMobil.Text = "X"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(89, 290)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(125, 23)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Driver            :"
        '
        'xDriver
        '
        Me.xDriver.AutoSize = True
        Me.xDriver.BackColor = System.Drawing.Color.Transparent
        Me.xDriver.Font = New System.Drawing.Font("Segoe UI", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xDriver.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.xDriver.Location = New System.Drawing.Point(234, 290)
        Me.xDriver.Name = "xDriver"
        Me.xDriver.Size = New System.Drawing.Size(21, 23)
        Me.xDriver.TabIndex = 18
        Me.xDriver.Text = "X"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(89, 247)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(125, 23)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = "Lokasi            :"
        '
        'xLokasi
        '
        Me.xLokasi.AutoSize = True
        Me.xLokasi.BackColor = System.Drawing.Color.Transparent
        Me.xLokasi.Font = New System.Drawing.Font("Segoe UI", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xLokasi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.xLokasi.Location = New System.Drawing.Point(234, 247)
        Me.xLokasi.Name = "xLokasi"
        Me.xLokasi.Size = New System.Drawing.Size(21, 23)
        Me.xLokasi.TabIndex = 20
        Me.xLokasi.Text = "X"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(91, 207)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(123, 23)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = "Tgl Selesai     :"
        '
        'xSelesai
        '
        Me.xSelesai.AutoSize = True
        Me.xSelesai.BackColor = System.Drawing.Color.Transparent
        Me.xSelesai.Font = New System.Drawing.Font("Segoe UI", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xSelesai.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.xSelesai.Location = New System.Drawing.Point(236, 207)
        Me.xSelesai.Name = "xSelesai"
        Me.xSelesai.Size = New System.Drawing.Size(21, 23)
        Me.xSelesai.TabIndex = 22
        Me.xSelesai.Text = "X"
        '
        'xTanggal
        '
        Me.xTanggal.AutoSize = True
        Me.xTanggal.BackColor = System.Drawing.Color.Transparent
        Me.xTanggal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xTanggal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.xTanggal.Location = New System.Drawing.Point(675, 105)
        Me.xTanggal.Name = "xTanggal"
        Me.xTanggal.Size = New System.Drawing.Size(19, 20)
        Me.xTanggal.TabIndex = 25
        Me.xTanggal.Text = "X"
        '
        'TPTanggal
        '
        Me.TPTanggal.Enabled = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(96, 594)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(658, 3)
        Me.TextBox1.TabIndex = 26
        '
        'xHari
        '
        Me.xHari.AutoSize = True
        Me.xHari.BackColor = System.Drawing.Color.Transparent
        Me.xHari.Font = New System.Drawing.Font("Segoe UI", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xHari.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.xHari.Location = New System.Drawing.Point(614, 542)
        Me.xHari.Name = "xHari"
        Me.xHari.Size = New System.Drawing.Size(21, 23)
        Me.xHari.TabIndex = 28
        Me.xHari.Text = "X"
        '
        'Hari
        '
        Me.Hari.AutoSize = True
        Me.Hari.BackColor = System.Drawing.Color.Transparent
        Me.Hari.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hari.Location = New System.Drawing.Point(469, 542)
        Me.Hari.Name = "Hari"
        Me.Hari.Size = New System.Drawing.Size(129, 23)
        Me.Hari.TabIndex = 27
        Me.Hari.Text = "Hari                :"
        '
        'xHarga
        '
        Me.xHarga.AutoSize = True
        Me.xHarga.BackColor = System.Drawing.Color.Transparent
        Me.xHarga.Font = New System.Drawing.Font("Segoe UI", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.xHarga.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.xHarga.Location = New System.Drawing.Point(614, 496)
        Me.xHarga.Name = "xHarga"
        Me.xHarga.Size = New System.Drawing.Size(21, 23)
        Me.xHarga.TabIndex = 30
        Me.xHarga.Text = "X"
        '
        'Harga
        '
        Me.Harga.AutoSize = True
        Me.Harga.BackColor = System.Drawing.Color.Transparent
        Me.Harga.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Harga.Location = New System.Drawing.Point(469, 496)
        Me.Harga.Name = "Harga"
        Me.Harga.Size = New System.Drawing.Size(129, 23)
        Me.Harga.TabIndex = 29
        Me.Harga.Text = "Harga             :"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(813, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 35)
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'Detail_Booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 740)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.xHarga)
        Me.Controls.Add(Me.Harga)
        Me.Controls.Add(Me.xHari)
        Me.Controls.Add(Me.Hari)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.xTanggal)
        Me.Controls.Add(Me.xMulai)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.xSelesai)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.xLokasi)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.xDriver)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.xMobil)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.xNopol)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.xTotal)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.xNama)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Detail_Booking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detail Booking"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents xNama As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents xMulai As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents xTotal As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents xNopol As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents xMobil As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents xDriver As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents xLokasi As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents xSelesai As Label
    Friend WithEvents xTanggal As Label
    Friend WithEvents TPTanggal As Timer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents xHari As Label
    Friend WithEvents Hari As Label
    Friend WithEvents xHarga As Label
    Friend WithEvents Harga As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
