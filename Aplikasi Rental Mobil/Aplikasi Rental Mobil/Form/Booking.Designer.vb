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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtNotel = New System.Windows.Forms.TextBox()
        Me.lblDriver = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'LVMobil
        '
        Me.LVMobil.BackColor = System.Drawing.Color.White
        Me.LVMobil.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.LVMobil.ForeColor = System.Drawing.Color.Black
        Me.LVMobil.HideSelection = False
        Me.LVMobil.Location = New System.Drawing.Point(46, 503)
        Me.LVMobil.Name = "LVMobil"
        Me.LVMobil.Size = New System.Drawing.Size(1201, 185)
        Me.LVMobil.TabIndex = 0
        Me.LVMobil.UseCompatibleStateImageBehavior = False
        '
        'cbDriver
        '
        Me.cbDriver.AutoSize = True
        Me.cbDriver.BackColor = System.Drawing.Color.Transparent
        Me.cbDriver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbDriver.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbDriver.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cbDriver.Location = New System.Drawing.Point(115, 349)
        Me.cbDriver.Name = "cbDriver"
        Me.cbDriver.Size = New System.Drawing.Size(135, 21)
        Me.cbDriver.TabIndex = 1
        Me.cbDriver.Text = "Dengan Driver"
        Me.cbDriver.UseVisualStyleBackColor = False
        '
        'DTPMulai
        '
        Me.DTPMulai.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DTPMulai.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DTPMulai.Location = New System.Drawing.Point(120, 209)
        Me.DTPMulai.Name = "DTPMulai"
        Me.DTPMulai.Size = New System.Drawing.Size(241, 22)
        Me.DTPMulai.TabIndex = 2
        Me.DTPMulai.Value = New Date(2021, 6, 26, 0, 0, 0, 0)
        '
        'cariMobil
        '
        Me.cariMobil.BackColor = System.Drawing.Color.Transparent
        Me.cariMobil.BackgroundImage = CType(resources.GetObject("cariMobil.BackgroundImage"), System.Drawing.Image)
        Me.cariMobil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.cariMobil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cariMobil.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.cariMobil.FlatAppearance.BorderSize = 0
        Me.cariMobil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.cariMobil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.cariMobil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cariMobil.Location = New System.Drawing.Point(798, 377)
        Me.cariMobil.Name = "cariMobil"
        Me.cariMobil.Size = New System.Drawing.Size(154, 46)
        Me.cariMobil.TabIndex = 4
        Me.cariMobil.UseVisualStyleBackColor = False
        '
        'cmbMobil
        '
        Me.cmbMobil.BackColor = System.Drawing.Color.White
        Me.cmbMobil.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbMobil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbMobil.ForeColor = System.Drawing.Color.Black
        Me.cmbMobil.FormattingEnabled = True
        Me.cmbMobil.Location = New System.Drawing.Point(486, 379)
        Me.cmbMobil.Name = "cmbMobil"
        Me.cmbMobil.Size = New System.Drawing.Size(240, 24)
        Me.cmbMobil.TabIndex = 5
        '
        'txtMobil
        '
        Me.txtMobil.Location = New System.Drawing.Point(655, 352)
        Me.txtMobil.Name = "txtMobil"
        Me.txtMobil.Size = New System.Drawing.Size(71, 22)
        Me.txtMobil.TabIndex = 6
        Me.txtMobil.Visible = False
        '
        'Book
        '
        Me.Book.BackColor = System.Drawing.Color.Transparent
        Me.Book.BackgroundImage = CType(resources.GetObject("Book.BackgroundImage"), System.Drawing.Image)
        Me.Book.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Book.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Book.FlatAppearance.BorderSize = 0
        Me.Book.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Book.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Book.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Book.Location = New System.Drawing.Point(1017, 377)
        Me.Book.Name = "Book"
        Me.Book.Size = New System.Drawing.Size(154, 46)
        Me.Book.TabIndex = 7
        Me.Book.UseVisualStyleBackColor = False
        '
        'DTPSelesai
        '
        Me.DTPSelesai.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DTPSelesai.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DTPSelesai.Location = New System.Drawing.Point(120, 297)
        Me.DTPSelesai.Name = "DTPSelesai"
        Me.DTPSelesai.Size = New System.Drawing.Size(241, 22)
        Me.DTPSelesai.TabIndex = 8
        Me.DTPSelesai.Value = New Date(2021, 6, 26, 0, 0, 0, 0)
        '
        'cmbDriver
        '
        Me.cmbDriver.BackColor = System.Drawing.Color.White
        Me.cmbDriver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cmbDriver.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbDriver.ForeColor = System.Drawing.Color.Black
        Me.cmbDriver.FormattingEnabled = True
        Me.cmbDriver.Location = New System.Drawing.Point(120, 400)
        Me.cmbDriver.Name = "cmbDriver"
        Me.cmbDriver.Size = New System.Drawing.Size(241, 24)
        Me.cmbDriver.TabIndex = 9
        '
        'txtLokasi
        '
        Me.txtLokasi.BackColor = System.Drawing.Color.White
        Me.txtLokasi.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLokasi.ForeColor = System.Drawing.Color.Black
        Me.txtLokasi.Location = New System.Drawing.Point(491, 216)
        Me.txtLokasi.Multiline = True
        Me.txtLokasi.Name = "txtLokasi"
        Me.txtLokasi.Size = New System.Drawing.Size(227, 94)
        Me.txtLokasi.TabIndex = 10
        '
        'txtDriver
        '
        Me.txtDriver.Location = New System.Drawing.Point(292, 374)
        Me.txtDriver.Name = "txtDriver"
        Me.txtDriver.Size = New System.Drawing.Size(71, 22)
        Me.txtDriver.TabIndex = 11
        Me.txtDriver.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.txtNotel)
        Me.Panel1.Controls.Add(Me.lblDriver)
        Me.Panel1.Controls.Add(Me.DTPMulai)
        Me.Panel1.Controls.Add(Me.DTPSelesai)
        Me.Panel1.Controls.Add(Me.LVMobil)
        Me.Panel1.Controls.Add(Me.cariMobil)
        Me.Panel1.Controls.Add(Me.Book)
        Me.Panel1.Controls.Add(Me.txtDriver)
        Me.Panel1.Controls.Add(Me.cmbMobil)
        Me.Panel1.Controls.Add(Me.cbDriver)
        Me.Panel1.Controls.Add(Me.cmbDriver)
        Me.Panel1.Controls.Add(Me.txtMobil)
        Me.Panel1.Controls.Add(Me.txtLokasi)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1293, 740)
        Me.Panel1.TabIndex = 17
        '
        'txtNotel
        '
        Me.txtNotel.Location = New System.Drawing.Point(292, 346)
        Me.txtNotel.Name = "txtNotel"
        Me.txtNotel.Size = New System.Drawing.Size(71, 22)
        Me.txtNotel.TabIndex = 13
        Me.txtNotel.Visible = False
        '
        'lblDriver
        '
        Me.lblDriver.AutoSize = True
        Me.lblDriver.BackColor = System.Drawing.Color.Transparent
        Me.lblDriver.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDriver.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblDriver.Location = New System.Drawing.Point(112, 376)
        Me.lblDriver.Name = "lblDriver"
        Me.lblDriver.Size = New System.Drawing.Size(52, 20)
        Me.lblDriver.TabIndex = 12
        Me.lblDriver.Text = "Driver"
        '
        'Booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1293, 740)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Booking"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Booking"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

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
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblDriver As Label
    Friend WithEvents txtNotel As TextBox
End Class
