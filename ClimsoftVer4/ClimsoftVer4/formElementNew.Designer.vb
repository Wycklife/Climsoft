<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formElementNew
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
        Me.UcrElementInformation1 = New ClimsoftVer4.ucrElementInformation()
        Me.SuspendLayout()
        '
        'UcrElementInformation1
        '
        Me.UcrElementInformation1.Location = New System.Drawing.Point(6, 8)
        Me.UcrElementInformation1.Name = "UcrElementInformation1"
        Me.UcrElementInformation1.Size = New System.Drawing.Size(601, 351)
        Me.UcrElementInformation1.TabIndex = 0
        '
        'formElementNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(613, 363)
        Me.Controls.Add(Me.UcrElementInformation1)
        Me.MaximizeBox = False
        Me.Name = "formElementNew"
        Me.Text = "formElementNew"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcrElementInformation1 As ucrElementInformation
End Class
