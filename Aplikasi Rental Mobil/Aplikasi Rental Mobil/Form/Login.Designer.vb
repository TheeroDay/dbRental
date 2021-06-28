<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.BtnLogin = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Invisible = New System.Windows.Forms.PictureBox()
        Me.invisibleEye = New System.Windows.Forms.PictureBox()
        Me.visibleEye = New System.Windows.Forms.PictureBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Create = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.Invisible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.invisibleEye, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.visibleEye, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BtnLogin
        '
        Me.BtnLogin.BackColor = System.Drawing.Color.Transparent
        Me.BtnLogin.BackgroundImage = CType(resources.GetObject("BtnLogin.BackgroundImage"), System.Drawing.Image)
        Me.BtnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.BtnLogin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnLogin.FlatAppearance.BorderSize = 0
        Me.BtnLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.BtnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.BtnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnLogin.Font = New System.Drawing.Font("Segoe UI", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLogin.ForeColor = System.Drawing.SystemColors.Window
        Me.BtnLogin.Location = New System.Drawing.Point(34, 388)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(188, 44)
        Me.BtnLogin.TabIndex = 2
        Me.BtnLogin.Text = "LOG IN"
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Controls.Add(Me.Invisible)
        Me.Panel1.Controls.Add(Me.invisibleEye)
        Me.Panel1.Controls.Add(Me.visibleEye)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtusername)
        Me.Panel1.Controls.Add(Me.Create)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.txtpass)
        Me.Panel1.Controls.Add(Me.BtnLogin)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(834, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(463, 744)
        Me.Panel1.TabIndex = 7
        '
        'Invisible
        '
        Me.Invisible.BackColor = System.Drawing.Color.Transparent
        Me.Invisible.BackgroundImage = CType(resources.GetObject("Invisible.BackgroundImage"), System.Drawing.Image)
        Me.Invisible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Invisible.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Invisible.Location = New System.Drawing.Point(403, 304)
        Me.Invisible.Name = "Invisible"
        Me.Invisible.Size = New System.Drawing.Size(35, 33)
        Me.Invisible.TabIndex = 19
        Me.Invisible.TabStop = False
        '
        'invisibleEye
        '
        Me.invisibleEye.BackColor = System.Drawing.Color.Transparent
        Me.invisibleEye.BackgroundImage = CType(resources.GetObject("invisibleEye.BackgroundImage"), System.Drawing.Image)
        Me.invisibleEye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.invisibleEye.Cursor = System.Windows.Forms.Cursors.Hand
        Me.invisibleEye.Location = New System.Drawing.Point(880, 177)
        Me.invisibleEye.Name = "invisibleEye"
        Me.invisibleEye.Size = New System.Drawing.Size(35, 33)
        Me.invisibleEye.TabIndex = 16
        Me.invisibleEye.TabStop = False
        '
        'visibleEye
        '
        Me.visibleEye.BackColor = System.Drawing.Color.Transparent
        Me.visibleEye.BackgroundImage = CType(resources.GetObject("visibleEye.BackgroundImage"), System.Drawing.Image)
        Me.visibleEye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.visibleEye.Cursor = System.Windows.Forms.Cursors.Hand
        Me.visibleEye.Location = New System.Drawing.Point(403, 304)
        Me.visibleEye.Name = "visibleEye"
        Me.visibleEye.Size = New System.Drawing.Size(35, 33)
        Me.visibleEye.TabIndex = 15
        Me.visibleEye.TabStop = False
        Me.visibleEye.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(37, 597)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(383, 85)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Lorem Ipsum has been the industry's standard dummy" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "text ever since the 1500s, wh" &
    "en an unknown printer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "took a galley of type and scrambled it to make a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "type sp" &
    "ecimen book."
        Me.Label4.UseCompatibleTextRendering = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(32, 125)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(239, 30)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Login to your account"
        '
        'txtusername
        '
        Me.txtusername.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtusername.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.ForeColor = System.Drawing.Color.Silver
        Me.txtusername.Location = New System.Drawing.Point(95, 248)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(282, 23)
        Me.txtusername.TabIndex = 4
        '
        'Create
        '
        Me.Create.AutoSize = True
        Me.Create.BackColor = System.Drawing.Color.Transparent
        Me.Create.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Create.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Create.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Create.Location = New System.Drawing.Point(270, 398)
        Me.Create.Name = "Create"
        Me.Create.Size = New System.Drawing.Size(132, 23)
        Me.Create.TabIndex = 12
        Me.Create.Text = "Create Account"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(47, 304)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 33)
        Me.PictureBox2.TabIndex = 11
        Me.PictureBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(240, 398)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Or"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(47, 243)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(35, 34)
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        '
        'txtpass
        '
        Me.txtpass.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpass.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.ForeColor = System.Drawing.Color.Silver
        Me.txtpass.Location = New System.Drawing.Point(95, 307)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(282, 23)
        Me.txtpass.TabIndex = 5
        Me.txtpass.UseSystemPasswordChar = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(344, 177)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(34, 484)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(434, 96)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Lorem Ipsum has been the industry's standard dummy" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "text ever since the 1500s, wh" &
    "en an unknown printer" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "took a galley of type and scrambled it to make a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "type sp" &
    "ecimen book."
        Me.Label5.UseCompatibleTextRendering = True
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(1297, 744)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.Invisible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.invisibleEye, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.visibleEye, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnLogin As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtpass As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Create As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents invisibleEye As PictureBox
    Friend WithEvents visibleEye As PictureBox
    Friend WithEvents Invisible As PictureBox
End Class
