<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Detail
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
        Me.LVTransaksi = New System.Windows.Forms.ListView()
        Me.SuspendLayout()
        '
        'LVTransaksi
        '
        Me.LVTransaksi.BackColor = System.Drawing.Color.Silver
        Me.LVTransaksi.HideSelection = False
        Me.LVTransaksi.Location = New System.Drawing.Point(0, 0)
        Me.LVTransaksi.Name = "LVTransaksi"
        Me.LVTransaksi.Size = New System.Drawing.Size(1296, 745)
        Me.LVTransaksi.TabIndex = 0
        Me.LVTransaksi.UseCompatibleStateImageBehavior = False
        '
        'Detail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1297, 744)
        Me.Controls.Add(Me.LVTransaksi)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Detail"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detail"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LVTransaksi As ListView
End Class
