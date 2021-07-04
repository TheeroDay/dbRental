<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Register
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Register))
        Me.Browse = New System.Windows.Forms.Button()
        Me.invisibleEye = New System.Windows.Forms.PictureBox()
        Me.visibleEye = New System.Windows.Forms.PictureBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtNoktp = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtNotelp = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.cmbGender = New System.Windows.Forms.ComboBox()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnRegistrasi = New System.Windows.Forms.Button()
        Me.OFDialog = New System.Windows.Forms.OpenFileDialog()
        Me.txtFoto = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.invisibleEye, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.visibleEye, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Browse
        '
        Me.Browse.BackColor = System.Drawing.Color.Transparent
        Me.Browse.BackgroundImage = CType(resources.GetObject("Browse.BackgroundImage"), System.Drawing.Image)
        Me.Browse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Browse.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Browse.FlatAppearance.BorderSize = 0
        Me.Browse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.Browse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.Browse.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Browse.Location = New System.Drawing.Point(680, 631)
        Me.Browse.Name = "Browse"
        Me.Browse.Size = New System.Drawing.Size(92, 27)
        Me.Browse.TabIndex = 27
        Me.Browse.UseVisualStyleBackColor = False
        '
        'invisibleEye
        '
        Me.invisibleEye.BackColor = System.Drawing.Color.Transparent
        Me.invisibleEye.BackgroundImage = CType(resources.GetObject("invisibleEye.BackgroundImage"), System.Drawing.Image)
        Me.invisibleEye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.invisibleEye.Cursor = System.Windows.Forms.Cursors.Hand
        Me.invisibleEye.Location = New System.Drawing.Point(746, 401)
        Me.invisibleEye.Name = "invisibleEye"
        Me.invisibleEye.Size = New System.Drawing.Size(26, 24)
        Me.invisibleEye.TabIndex = 18
        Me.invisibleEye.TabStop = False
        '
        'visibleEye
        '
        Me.visibleEye.BackColor = System.Drawing.Color.Transparent
        Me.visibleEye.BackgroundImage = CType(resources.GetObject("visibleEye.BackgroundImage"), System.Drawing.Image)
        Me.visibleEye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.visibleEye.Cursor = System.Windows.Forms.Cursors.Hand
        Me.visibleEye.Location = New System.Drawing.Point(746, 401)
        Me.visibleEye.Name = "visibleEye"
        Me.visibleEye.Size = New System.Drawing.Size(26, 24)
        Me.visibleEye.TabIndex = 17
        Me.visibleEye.TabStop = False
        Me.visibleEye.Visible = False
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.Transparent
        Me.btnLogin.BackgroundImage = CType(resources.GetObject("btnLogin.BackgroundImage"), System.Drawing.Image)
        Me.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLogin.FlatAppearance.BorderSize = 0
        Me.btnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.SystemColors.Window
        Me.btnLogin.Location = New System.Drawing.Point(441, 647)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(155, 48)
        Me.btnLogin.TabIndex = 18
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtNoktp
        '
        Me.txtNoktp.BackColor = System.Drawing.Color.White
        Me.txtNoktp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNoktp.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoktp.ForeColor = System.Drawing.Color.Silver
        Me.txtNoktp.Location = New System.Drawing.Point(458, 582)
        Me.txtNoktp.Name = "txtNoktp"
        Me.txtNoktp.Size = New System.Drawing.Size(298, 23)
        Me.txtNoktp.TabIndex = 16
        '
        'txtNama
        '
        Me.txtNama.BackColor = System.Drawing.Color.White
        Me.txtNama.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNama.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNama.ForeColor = System.Drawing.Color.Silver
        Me.txtNama.Location = New System.Drawing.Point(122, 311)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(267, 23)
        Me.txtNama.TabIndex = 0
        '
        'txtNotelp
        '
        Me.txtNotelp.BackColor = System.Drawing.Color.White
        Me.txtNotelp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNotelp.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotelp.ForeColor = System.Drawing.Color.Silver
        Me.txtNotelp.Location = New System.Drawing.Point(122, 583)
        Me.txtNotelp.Name = "txtNotelp"
        Me.txtNotelp.Size = New System.Drawing.Size(267, 23)
        Me.txtNotelp.TabIndex = 15
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.White
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.Silver
        Me.txtEmail.Location = New System.Drawing.Point(489, 311)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(267, 23)
        Me.txtEmail.TabIndex = 10
        '
        'cmbGender
        '
        Me.cmbGender.BackColor = System.Drawing.Color.White
        Me.cmbGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cmbGender.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbGender.ForeColor = System.Drawing.Color.Silver
        Me.cmbGender.FormattingEnabled = True
        Me.cmbGender.Location = New System.Drawing.Point(122, 488)
        Me.cmbGender.Name = "cmbGender"
        Me.cmbGender.Size = New System.Drawing.Size(286, 31)
        Me.cmbGender.TabIndex = 13
        '
        'txtAlamat
        '
        Me.txtAlamat.BackColor = System.Drawing.Color.White
        Me.txtAlamat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAlamat.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlamat.ForeColor = System.Drawing.Color.Silver
        Me.txtAlamat.Location = New System.Drawing.Point(489, 491)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(267, 23)
        Me.txtAlamat.TabIndex = 14
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtUsername.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsername.ForeColor = System.Drawing.Color.Silver
        Me.txtUsername.Location = New System.Drawing.Point(122, 402)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(267, 23)
        Me.txtUsername.TabIndex = 11
        '
        'txtPassword
        '
        Me.txtPassword.BackColor = System.Drawing.Color.White
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.Color.Silver
        Me.txtPassword.Location = New System.Drawing.Point(489, 402)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(251, 23)
        Me.txtPassword.TabIndex = 12
        Me.txtPassword.UseSystemPasswordChar = True
        '
        'btnRegistrasi
        '
        Me.btnRegistrasi.BackColor = System.Drawing.Color.Transparent
        Me.btnRegistrasi.BackgroundImage = CType(resources.GetObject("btnRegistrasi.BackgroundImage"), System.Drawing.Image)
        Me.btnRegistrasi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRegistrasi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRegistrasi.FlatAppearance.BorderSize = 0
        Me.btnRegistrasi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btnRegistrasi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btnRegistrasi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegistrasi.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegistrasi.ForeColor = System.Drawing.SystemColors.Window
        Me.btnRegistrasi.Location = New System.Drawing.Point(245, 647)
        Me.btnRegistrasi.Name = "btnRegistrasi"
        Me.btnRegistrasi.Size = New System.Drawing.Size(155, 48)
        Me.btnRegistrasi.TabIndex = 17
        Me.btnRegistrasi.UseVisualStyleBackColor = False
        '
        'OFDialog
        '
        Me.OFDialog.FileName = "OpenFileDialog1"
        '
        'txtFoto
        '
        Me.txtFoto.BackColor = System.Drawing.Color.White
        Me.txtFoto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFoto.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFoto.ForeColor = System.Drawing.SystemColors.Window
        Me.txtFoto.Location = New System.Drawing.Point(12, 12)
        Me.txtFoto.Name = "txtFoto"
        Me.txtFoto.Size = New System.Drawing.Size(201, 18)
        Me.txtFoto.TabIndex = 28
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.txtFoto)
        Me.Panel1.Controls.Add(Me.visibleEye)
        Me.Panel1.Controls.Add(Me.btnRegistrasi)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.btnLogin)
        Me.Panel1.Controls.Add(Me.invisibleEye)
        Me.Panel1.Controls.Add(Me.txtUsername)
        Me.Panel1.Controls.Add(Me.Browse)
        Me.Panel1.Controls.Add(Me.cmbGender)
        Me.Panel1.Controls.Add(Me.txtAlamat)
        Me.Panel1.Controls.Add(Me.txtNotelp)
        Me.Panel1.Controls.Add(Me.txtNoktp)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1297, 744)
        Me.Panel1.TabIndex = 29
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(617, 632)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 23)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Photo"
        '
        'Register
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1297, 744)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Panel1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Register"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = " Registration"
        CType(Me.invisibleEye, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.visibleEye, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtNoktp As TextBox
    Friend WithEvents txtNotelp As TextBox
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents cmbGender As ComboBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents btnRegistrasi As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents invisibleEye As PictureBox
    Friend WithEvents visibleEye As PictureBox
    Friend WithEvents Browse As Button
    Friend WithEvents OFDialog As OpenFileDialog
    Friend WithEvents txtFoto As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
End Class
