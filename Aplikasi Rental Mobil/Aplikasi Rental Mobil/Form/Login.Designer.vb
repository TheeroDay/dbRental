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
        Me.Invisible = New System.Windows.Forms.PictureBox()
        Me.visibleEye = New System.Windows.Forms.PictureBox()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Create = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.Invisible, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.visibleEye, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
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
        Me.BtnLogin.Location = New System.Drawing.Point(67, 543)
        Me.BtnLogin.Name = "BtnLogin"
        Me.BtnLogin.Size = New System.Drawing.Size(145, 43)
        Me.BtnLogin.TabIndex = 2
        Me.BtnLogin.UseVisualStyleBackColor = False
        '
        'Invisible
        '
        Me.Invisible.BackColor = System.Drawing.Color.Transparent
        Me.Invisible.BackgroundImage = CType(resources.GetObject("Invisible.BackgroundImage"), System.Drawing.Image)
        Me.Invisible.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Invisible.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Invisible.Location = New System.Drawing.Point(377, 473)
        Me.Invisible.Name = "Invisible"
        Me.Invisible.Size = New System.Drawing.Size(26, 24)
        Me.Invisible.TabIndex = 19
        Me.Invisible.TabStop = False
        '
        'visibleEye
        '
        Me.visibleEye.BackColor = System.Drawing.Color.Transparent
        Me.visibleEye.BackgroundImage = CType(resources.GetObject("visibleEye.BackgroundImage"), System.Drawing.Image)
        Me.visibleEye.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.visibleEye.Cursor = System.Windows.Forms.Cursors.Hand
        Me.visibleEye.Location = New System.Drawing.Point(377, 473)
        Me.visibleEye.Name = "visibleEye"
        Me.visibleEye.Size = New System.Drawing.Size(26, 24)
        Me.visibleEye.TabIndex = 15
        Me.visibleEye.TabStop = False
        Me.visibleEye.Visible = False
        '
        'txtusername
        '
        Me.txtusername.BackColor = System.Drawing.Color.White
        Me.txtusername.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtusername.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.ForeColor = System.Drawing.Color.Gray
        Me.txtusername.Location = New System.Drawing.Point(126, 381)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(277, 23)
        Me.txtusername.TabIndex = 4
        '
        'Create
        '
        Me.Create.AutoSize = True
        Me.Create.BackColor = System.Drawing.Color.Transparent
        Me.Create.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Create.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Create.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Create.ForeColor = System.Drawing.Color.Gray
        Me.Create.Location = New System.Drawing.Point(258, 549)
        Me.Create.Name = "Create"
        Me.Create.Size = New System.Drawing.Size(157, 28)
        Me.Create.TabIndex = 12
        Me.Create.Text = "Create Account"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(225, 552)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 23)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Or"
        '
        'txtpass
        '
        Me.txtpass.BackColor = System.Drawing.Color.White
        Me.txtpass.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtpass.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.ForeColor = System.Drawing.Color.Gray
        Me.txtpass.Location = New System.Drawing.Point(126, 473)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(277, 23)
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
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(454, 744)
        Me.Panel1.TabIndex = 20
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Transparent
        Me.Panel2.BackgroundImage = CType(resources.GetObject("Panel2.BackgroundImage"), System.Drawing.Image)
        Me.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Panel2.Controls.Add(Me.visibleEye)
        Me.Panel2.Controls.Add(Me.BtnLogin)
        Me.Panel2.Controls.Add(Me.Invisible)
        Me.Panel2.Controls.Add(Me.Create)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtpass)
        Me.Panel2.Controls.Add(Me.txtusername)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(454, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(843, 744)
        Me.Panel2.TabIndex = 21
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1297, 744)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.Invisible, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.visibleEye, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnLogin As Button
    Friend WithEvents txtpass As TextBox
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Create As Label
    Friend WithEvents visibleEye As PictureBox
    Friend WithEvents Invisible As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
End Class
