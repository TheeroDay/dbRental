<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dashboard
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.LProfile = New System.Windows.Forms.Label()
        Me.tProfile = New System.Windows.Forms.TextBox()
        Me.LDBooking = New System.Windows.Forms.Label()
        Me.tDBook = New System.Windows.Forms.TextBox()
        Me.LBooking = New System.Windows.Forms.Label()
        Me.tBook = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer), CType(CType(51, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.LProfile)
        Me.Panel1.Controls.Add(Me.tProfile)
        Me.Panel1.Controls.Add(Me.LDBooking)
        Me.Panel1.Controls.Add(Me.tDBook)
        Me.Panel1.Controls.Add(Me.LBooking)
        Me.Panel1.Controls.Add(Me.tBook)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(206, 834)
        Me.Panel1.TabIndex = 0
        '
        'PictureBox3
        '
        Me.PictureBox3.BackgroundImage = CType(resources.GetObject("PictureBox3.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Location = New System.Drawing.Point(12, 779)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(45, 43)
        Me.PictureBox3.TabIndex = 2
        Me.PictureBox3.TabStop = False
        '
        'LProfile
        '
        Me.LProfile.AutoSize = True
        Me.LProfile.BackColor = System.Drawing.Color.Transparent
        Me.LProfile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LProfile.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LProfile.ForeColor = System.Drawing.SystemColors.Window
        Me.LProfile.Location = New System.Drawing.Point(12, 453)
        Me.LProfile.Name = "LProfile"
        Me.LProfile.Size = New System.Drawing.Size(63, 23)
        Me.LProfile.TabIndex = 3
        Me.LProfile.Text = "Profile"
        '
        'tProfile
        '
        Me.tProfile.BackColor = System.Drawing.SystemColors.Highlight
        Me.tProfile.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tProfile.Enabled = False
        Me.tProfile.Location = New System.Drawing.Point(1, 450)
        Me.tProfile.Multiline = True
        Me.tProfile.Name = "tProfile"
        Me.tProfile.Size = New System.Drawing.Size(5, 30)
        Me.tProfile.TabIndex = 4
        Me.tProfile.Visible = False
        '
        'LDBooking
        '
        Me.LDBooking.AutoSize = True
        Me.LDBooking.BackColor = System.Drawing.Color.Transparent
        Me.LDBooking.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LDBooking.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LDBooking.ForeColor = System.Drawing.SystemColors.Window
        Me.LDBooking.Location = New System.Drawing.Point(12, 397)
        Me.LDBooking.Name = "LDBooking"
        Me.LDBooking.Size = New System.Drawing.Size(130, 23)
        Me.LDBooking.TabIndex = 1
        Me.LDBooking.Text = "Detail Booking"
        '
        'tDBook
        '
        Me.tDBook.BackColor = System.Drawing.SystemColors.Highlight
        Me.tDBook.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tDBook.Enabled = False
        Me.tDBook.Location = New System.Drawing.Point(1, 393)
        Me.tDBook.Multiline = True
        Me.tDBook.Name = "tDBook"
        Me.tDBook.Size = New System.Drawing.Size(5, 30)
        Me.tDBook.TabIndex = 2
        Me.tDBook.Visible = False
        '
        'LBooking
        '
        Me.LBooking.AutoSize = True
        Me.LBooking.BackColor = System.Drawing.Color.Transparent
        Me.LBooking.Cursor = System.Windows.Forms.Cursors.Hand
        Me.LBooking.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LBooking.ForeColor = System.Drawing.SystemColors.Window
        Me.LBooking.Location = New System.Drawing.Point(12, 340)
        Me.LBooking.Name = "LBooking"
        Me.LBooking.Size = New System.Drawing.Size(77, 23)
        Me.LBooking.TabIndex = 0
        Me.LBooking.Text = "Booking"
        '
        'tBook
        '
        Me.tBook.BackColor = System.Drawing.SystemColors.Highlight
        Me.tBook.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tBook.Enabled = False
        Me.tBook.Location = New System.Drawing.Point(1, 337)
        Me.tBook.Multiline = True
        Me.tBook.Name = "tBook"
        Me.tBook.Size = New System.Drawing.Size(5, 30)
        Me.tBook.TabIndex = 0
        Me.tBook.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Silver
        Me.Panel2.Controls.Add(Me.PictureBox2)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(206, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1288, 52)
        Me.Panel2.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = CType(resources.GetObject("PictureBox2.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox2.Location = New System.Drawing.Point(5, 8)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(37, 35)
        Me.PictureBox2.TabIndex = 1
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox1.Location = New System.Drawing.Point(56, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 35)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Dashboard
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1494, 834)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.IsMdiContainer = True
        Me.Name = "Dashboard"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dashboard"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents tBook As TextBox
    Friend WithEvents LBooking As Label
    Friend WithEvents LDBooking As Label
    Friend WithEvents LProfile As Label
    Friend WithEvents tProfile As TextBox
    Friend WithEvents tDBook As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
