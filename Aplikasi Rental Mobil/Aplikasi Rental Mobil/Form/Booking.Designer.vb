<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Booking
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Booking))
        Me.LVMobil = New System.Windows.Forms.ListView()
        Me.cbDriver = New System.Windows.Forms.CheckBox()
        Me.DTPMulai = New System.Windows.Forms.DateTimePicker()
        Me.cariMobil = New System.Windows.Forms.Button()
        Me.cmbMobil = New System.Windows.Forms.ComboBox()
        Me.txtMobil = New System.Windows.Forms.TextBox()
        Me.Book = New System.Windows.Forms.Button()
        Me.DTPSelesai = New System.Windows.Forms.DateTimePicker()
        Me.cmbDriver = New System.Windows.Forms.ComboBox()
        Me.txtLokasi = New System.Windows.Forms.TextBox()
        Me.txtDriver = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblDriver = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'LVMobil
        '
        Me.LVMobil.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.LVMobil.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LVMobil.ForeColor = System.Drawing.SystemColors.Window
        Me.LVMobil.HideSelection = False
        Me.LVMobil.Location = New System.Drawing.Point(0, 360)
        Me.LVMobil.Name = "LVMobil"
        Me.LVMobil.Size = New System.Drawing.Size(1297, 384)
        Me.LVMobil.TabIndex = 0
        Me.LVMobil.UseCompatibleStateImageBehavior = False
        '
        'cbDriver
        '
        Me.cbDriver.AutoSize = True
        Me.cbDriver.BackColor = System.Drawing.Color.Transparent
        Me.cbDriver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbDriver.ForeColor = System.Drawing.SystemColors.Window
        Me.cbDriver.Location = New System.Drawing.Point(46, 249)
        Me.cbDriver.Name = "cbDriver"
        Me.cbDriver.Size = New System.Drawing.Size(122, 21)
        Me.cbDriver.TabIndex = 1
        Me.cbDriver.Text = "Dengan Driver"
        Me.cbDriver.UseVisualStyleBackColor = False
        '
        'DTPMulai
        '
        Me.DTPMulai.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DTPMulai.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DTPMulai.Location = New System.Drawing.Point(47, 110)
        Me.DTPMulai.Name = "DTPMulai"
        Me.DTPMulai.Size = New System.Drawing.Size(251, 22)
        Me.DTPMulai.TabIndex = 2
        Me.DTPMulai.Value = New Date(2021, 6, 26, 0, 0, 0, 0)
        '
        'cariMobil
        '
        Me.cariMobil.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cariMobil.BackgroundImage = CType(resources.GetObject("cariMobil.BackgroundImage"), System.Drawing.Image)
        Me.cariMobil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cariMobil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cariMobil.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cariMobil.FlatAppearance.BorderSize = 0
        Me.cariMobil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cariMobil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cariMobil.Location = New System.Drawing.Point(678, 275)
        Me.cariMobil.Name = "cariMobil"
        Me.cariMobil.Size = New System.Drawing.Size(71, 60)
        Me.cariMobil.TabIndex = 4
        Me.cariMobil.UseVisualStyleBackColor = False
        '
        'cmbMobil
        '
        Me.cmbMobil.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.cmbMobil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbMobil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMobil.ForeColor = System.Drawing.SystemColors.Window
        Me.cmbMobil.FormattingEnabled = True
        Me.cmbMobil.Location = New System.Drawing.Point(384, 300)
        Me.cmbMobil.Name = "cmbMobil"
        Me.cmbMobil.Size = New System.Drawing.Size(153, 24)
        Me.cmbMobil.TabIndex = 5
        '
        'txtMobil
        '
        Me.txtMobil.Location = New System.Drawing.Point(564, 300)
        Me.txtMobil.Name = "txtMobil"
        Me.txtMobil.Size = New System.Drawing.Size(71, 22)
        Me.txtMobil.TabIndex = 6
        Me.txtMobil.Visible = False
        '
        'Book
        '
        Me.Book.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Book.BackgroundImage = CType(resources.GetObject("Book.BackgroundImage"), System.Drawing.Image)
        Me.Book.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Book.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Book.FlatAppearance.BorderSize = 0
        Me.Book.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Book.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Book.Location = New System.Drawing.Point(1060, 242)
        Me.Book.Name = "Book"
        Me.Book.Size = New System.Drawing.Size(97, 82)
        Me.Book.TabIndex = 7
        Me.Book.UseVisualStyleBackColor = False
        '
        'DTPSelesai
        '
        Me.DTPSelesai.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DTPSelesai.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DTPSelesai.Location = New System.Drawing.Point(46, 191)
        Me.DTPSelesai.Name = "DTPSelesai"
        Me.DTPSelesai.Size = New System.Drawing.Size(251, 22)
        Me.DTPSelesai.TabIndex = 8
        Me.DTPSelesai.Value = New Date(2021, 6, 26, 0, 0, 0, 0)
        '
        'cmbDriver
        '
        Me.cmbDriver.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.cmbDriver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDriver.ForeColor = System.Drawing.SystemColors.Window
        Me.cmbDriver.FormattingEnabled = True
        Me.cmbDriver.Location = New System.Drawing.Point(46, 311)
        Me.cmbDriver.Name = "cmbDriver"
        Me.cmbDriver.Size = New System.Drawing.Size(154, 24)
        Me.cmbDriver.TabIndex = 9
        '
        'txtLokasi
        '
        Me.txtLokasi.BackColor = System.Drawing.Color.FromArgb(CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(66, Byte), Integer))
        Me.txtLokasi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLokasi.ForeColor = System.Drawing.SystemColors.Window
        Me.txtLokasi.Location = New System.Drawing.Point(384, 110)
        Me.txtLokasi.Multiline = True
        Me.txtLokasi.Name = "txtLokasi"
        Me.txtLokasi.Size = New System.Drawing.Size(527, 123)
        Me.txtLokasi.TabIndex = 10
        '
        'txtDriver
        '
        Me.txtDriver.Location = New System.Drawing.Point(206, 311)
        Me.txtDriver.Name = "txtDriver"
        Me.txtDriver.Size = New System.Drawing.Size(71, 22)
        Me.txtDriver.TabIndex = 11
        Me.txtDriver.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(44, 79)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 19)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Tanggal Mulai"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.Window
        Me.Label2.Location = New System.Drawing.Point(43, 160)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 19)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Tanggal Selesai"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(380, 270)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 19)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Mobil"
        '
        'lblDriver
        '
        Me.lblDriver.AutoSize = True
        Me.lblDriver.BackColor = System.Drawing.Color.Transparent
        Me.lblDriver.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDriver.ForeColor = System.Drawing.SystemColors.Window
        Me.lblDriver.Location = New System.Drawing.Point(42, 281)
        Me.lblDriver.Name = "lblDriver"
        Me.lblDriver.Size = New System.Drawing.Size(51, 19)
        Me.lblDriver.TabIndex = 15
        Me.lblDriver.Text = "Driver"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Window
        Me.Label4.Location = New System.Drawing.Point(380, 79)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 19)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Lokasi Penjemputan"
        '
        'Booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1293, 740)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblDriver)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDriver)
        Me.Controls.Add(Me.txtLokasi)
        Me.Controls.Add(Me.cmbDriver)
        Me.Controls.Add(Me.DTPSelesai)
        Me.Controls.Add(Me.Book)
        Me.Controls.Add(Me.txtMobil)
        Me.Controls.Add(Me.cmbMobil)
        Me.Controls.Add(Me.cariMobil)
        Me.Controls.Add(Me.DTPMulai)
        Me.Controls.Add(Me.cbDriver)
        Me.Controls.Add(Me.LVMobil)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Booking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Booking"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LVMobil As ListView
    Friend WithEvents cbDriver As CheckBox
    Friend WithEvents DTPMulai As DateTimePicker
    Friend WithEvents cariMobil As Button
    Friend WithEvents cmbMobil As ComboBox
    Friend WithEvents txtMobil As TextBox
    Friend WithEvents Book As Button
    Friend WithEvents DTPSelesai As DateTimePicker
    Friend WithEvents cmbDriver As ComboBox
    Friend WithEvents txtLokasi As TextBox
    Friend WithEvents txtDriver As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lblDriver As Label
    Friend WithEvents Label4 As Label
End Class
