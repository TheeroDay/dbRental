<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Profile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Profile))
        Me.lblProfile = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Nama = New System.Windows.Forms.Label()
        Me.Gender = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tuNama = New System.Windows.Forms.TextBox()
        Me.cmbuGender = New System.Windows.Forms.ComboBox()
        Me.tuAlamat = New System.Windows.Forms.TextBox()
        Me.tuEmail = New System.Windows.Forms.TextBox()
        Me.tuUsername = New System.Windows.Forms.TextBox()
        Me.tuPassword = New System.Windows.Forms.TextBox()
        Me.tuNotel = New System.Windows.Forms.TextBox()
        Me.tuNoKTP = New System.Windows.Forms.TextBox()
        Me.uEdit = New System.Windows.Forms.PictureBox()
        Me.sUpdate = New System.Windows.Forms.PictureBox()
        Me.lblEdit = New System.Windows.Forms.Label()
        CType(Me.uEdit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sUpdate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblProfile
        '
        Me.lblProfile.AutoSize = True
        Me.lblProfile.BackColor = System.Drawing.Color.Transparent
        Me.lblProfile.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProfile.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.lblProfile.Location = New System.Drawing.Point(225, 187)
        Me.lblProfile.Name = "lblProfile"
        Me.lblProfile.Size = New System.Drawing.Size(104, 38)
        Me.lblProfile.TabIndex = 0
        Me.lblProfile.Text = "Profile"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Silver
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Location = New System.Drawing.Point(197, 238)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(900, 2)
        Me.TextBox1.TabIndex = 1
        '
        'Nama
        '
        Me.Nama.AutoSize = True
        Me.Nama.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nama.ForeColor = System.Drawing.Color.DimGray
        Me.Nama.Location = New System.Drawing.Point(227, 283)
        Me.Nama.Name = "Nama"
        Me.Nama.Size = New System.Drawing.Size(68, 28)
        Me.Nama.TabIndex = 2
        Me.Nama.Text = "Nama"
        '
        'Gender
        '
        Me.Gender.AutoSize = True
        Me.Gender.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gender.ForeColor = System.Drawing.Color.DimGray
        Me.Gender.Location = New System.Drawing.Point(227, 353)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(64, 28)
        Me.Gender.TabIndex = 3
        Me.Gender.Text = "Email"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.DimGray
        Me.Label4.Location = New System.Drawing.Point(225, 420)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 28)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.DimGray
        Me.Label5.Location = New System.Drawing.Point(225, 490)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 28)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Gender"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.DimGray
        Me.Label6.Location = New System.Drawing.Point(225, 557)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 28)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Username"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(227, 628)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(101, 28)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Password"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.DimGray
        Me.Label8.Location = New System.Drawing.Point(227, 701)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(148, 28)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "No. Telephone"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.DimGray
        Me.Label9.Location = New System.Drawing.Point(227, 765)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(88, 28)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "No. KTP"
        '
        'tuNama
        '
        Me.tuNama.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tuNama.Enabled = False
        Me.tuNama.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tuNama.Location = New System.Drawing.Point(709, 281)
        Me.tuNama.Name = "tuNama"
        Me.tuNama.Size = New System.Drawing.Size(352, 23)
        Me.tuNama.TabIndex = 10
        '
        'cmbuGender
        '
        Me.cmbuGender.Enabled = False
        Me.cmbuGender.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbuGender.FormattingEnabled = True
        Me.cmbuGender.Location = New System.Drawing.Point(709, 485)
        Me.cmbuGender.Name = "cmbuGender"
        Me.cmbuGender.Size = New System.Drawing.Size(352, 31)
        Me.cmbuGender.TabIndex = 11
        '
        'tuAlamat
        '
        Me.tuAlamat.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tuAlamat.Enabled = False
        Me.tuAlamat.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tuAlamat.Location = New System.Drawing.Point(709, 420)
        Me.tuAlamat.Name = "tuAlamat"
        Me.tuAlamat.Size = New System.Drawing.Size(352, 23)
        Me.tuAlamat.TabIndex = 12
        '
        'tuEmail
        '
        Me.tuEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tuEmail.Enabled = False
        Me.tuEmail.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tuEmail.Location = New System.Drawing.Point(709, 351)
        Me.tuEmail.Name = "tuEmail"
        Me.tuEmail.Size = New System.Drawing.Size(352, 23)
        Me.tuEmail.TabIndex = 13
        '
        'tuUsername
        '
        Me.tuUsername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tuUsername.Enabled = False
        Me.tuUsername.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tuUsername.Location = New System.Drawing.Point(709, 555)
        Me.tuUsername.Name = "tuUsername"
        Me.tuUsername.Size = New System.Drawing.Size(352, 23)
        Me.tuUsername.TabIndex = 14
        '
        'tuPassword
        '
        Me.tuPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tuPassword.Enabled = False
        Me.tuPassword.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tuPassword.Location = New System.Drawing.Point(709, 626)
        Me.tuPassword.Name = "tuPassword"
        Me.tuPassword.Size = New System.Drawing.Size(352, 23)
        Me.tuPassword.TabIndex = 15
        Me.tuPassword.UseSystemPasswordChar = True
        '
        'tuNotel
        '
        Me.tuNotel.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tuNotel.Enabled = False
        Me.tuNotel.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tuNotel.Location = New System.Drawing.Point(709, 699)
        Me.tuNotel.Name = "tuNotel"
        Me.tuNotel.Size = New System.Drawing.Size(352, 23)
        Me.tuNotel.TabIndex = 16
        '
        'tuNoKTP
        '
        Me.tuNoKTP.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tuNoKTP.Enabled = False
        Me.tuNoKTP.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tuNoKTP.Location = New System.Drawing.Point(709, 763)
        Me.tuNoKTP.Name = "tuNoKTP"
        Me.tuNoKTP.Size = New System.Drawing.Size(352, 23)
        Me.tuNoKTP.TabIndex = 17
        '
        'uEdit
        '
        Me.uEdit.BackColor = System.Drawing.Color.Transparent
        Me.uEdit.BackgroundImage = CType(resources.GetObject("uEdit.BackgroundImage"), System.Drawing.Image)
        Me.uEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.uEdit.Cursor = System.Windows.Forms.Cursors.Hand
        Me.uEdit.Location = New System.Drawing.Point(1000, 183)
        Me.uEdit.Name = "uEdit"
        Me.uEdit.Size = New System.Drawing.Size(40, 42)
        Me.uEdit.TabIndex = 18
        Me.uEdit.TabStop = False
        '
        'sUpdate
        '
        Me.sUpdate.BackColor = System.Drawing.Color.Transparent
        Me.sUpdate.BackgroundImage = CType(resources.GetObject("sUpdate.BackgroundImage"), System.Drawing.Image)
        Me.sUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.sUpdate.Cursor = System.Windows.Forms.Cursors.Hand
        Me.sUpdate.Location = New System.Drawing.Point(1000, 183)
        Me.sUpdate.Name = "sUpdate"
        Me.sUpdate.Size = New System.Drawing.Size(40, 42)
        Me.sUpdate.TabIndex = 19
        Me.sUpdate.TabStop = False
        Me.sUpdate.Visible = False
        '
        'lblEdit
        '
        Me.lblEdit.AutoSize = True
        Me.lblEdit.BackColor = System.Drawing.Color.Transparent
        Me.lblEdit.Font = New System.Drawing.Font("Segoe UI", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEdit.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.lblEdit.Location = New System.Drawing.Point(225, 187)
        Me.lblEdit.Name = "lblEdit"
        Me.lblEdit.Size = New System.Drawing.Size(163, 38)
        Me.lblEdit.TabIndex = 20
        Me.lblEdit.Text = "Edit Profile"
        Me.lblEdit.Visible = False
        '
        'Profile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(1297, 882)
        Me.Controls.Add(Me.lblProfile)
        Me.Controls.Add(Me.lblEdit)
        Me.Controls.Add(Me.uEdit)
        Me.Controls.Add(Me.sUpdate)
        Me.Controls.Add(Me.tuNoKTP)
        Me.Controls.Add(Me.tuNotel)
        Me.Controls.Add(Me.tuPassword)
        Me.Controls.Add(Me.tuUsername)
        Me.Controls.Add(Me.tuEmail)
        Me.Controls.Add(Me.tuAlamat)
        Me.Controls.Add(Me.cmbuGender)
        Me.Controls.Add(Me.tuNama)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Gender)
        Me.Controls.Add(Me.Nama)
        Me.Controls.Add(Me.TextBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Profile"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Profile"
        CType(Me.uEdit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sUpdate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblProfile As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Nama As Label
    Friend WithEvents Gender As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents tuNama As TextBox
    Friend WithEvents cmbuGender As ComboBox
    Friend WithEvents tuAlamat As TextBox
    Friend WithEvents tuEmail As TextBox
    Friend WithEvents tuUsername As TextBox
    Friend WithEvents tuPassword As TextBox
    Friend WithEvents tuNotel As TextBox
    Friend WithEvents tuNoKTP As TextBox
    Friend WithEvents uEdit As PictureBox
    Friend WithEvents sUpdate As PictureBox
    Friend WithEvents lblEdit As Label
End Class
