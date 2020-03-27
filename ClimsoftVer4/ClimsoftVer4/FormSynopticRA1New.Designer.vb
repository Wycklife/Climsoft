<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSynopticRA1New
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
        Me.UcrSynopticRA1New1 = New ClimsoftVer4.ucrSynopticRA1New()
        Me.SuspendLayout()
        '
        'UcrSynopticRA1New1
        '
        Me.UcrSynopticRA1New1.Location = New System.Drawing.Point(13, 12)
        Me.UcrSynopticRA1New1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcrSynopticRA1New1.Name = "UcrSynopticRA1New1"
        Me.UcrSynopticRA1New1.Size = New System.Drawing.Size(864, 659)
        Me.UcrSynopticRA1New1.TabIndex = 0
        '
        'FormSynopticRA1New
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 685)
        Me.Controls.Add(Me.UcrSynopticRA1New1)
        Me.Name = "FormSynopticRA1New"
        Me.Text = "FormSynopticRA1New"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcrSynopticRA1New1 As ucrSynopticRA1New
End Class
