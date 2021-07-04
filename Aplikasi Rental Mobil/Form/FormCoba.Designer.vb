<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormCoba
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
        Me.pCoba = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'pCoba
        '
        Me.pCoba.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.pCoba.Location = New System.Drawing.Point(36, 46)
        Me.pCoba.Name = "pCoba"
        Me.pCoba.Size = New System.Drawing.Size(208, 49)
        Me.pCoba.TabIndex = 0
        Me.pCoba.Visible = False
        '
        'FormCoba
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.pCoba)
        Me.Name = "FormCoba"
        Me.Text = "FormCoba"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pCoba As Panel
End Class
