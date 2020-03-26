<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formHourlyNew
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
        Me.UcrHourlyNew1 = New ClimsoftVer4.ucrHourlyNew()
        Me.SuspendLayout()
        '
        'UcrHourlyNew1
        '
        Me.UcrHourlyNew1.Location = New System.Drawing.Point(1, 2)
        Me.UcrHourlyNew1.Name = "UcrHourlyNew1"
        Me.UcrHourlyNew1.Size = New System.Drawing.Size(674, 602)
        Me.UcrHourlyNew1.TabIndex = 0
        '
        'formHourlyNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(681, 615)
        Me.Controls.Add(Me.UcrHourlyNew1)
        Me.Name = "formHourlyNew"
        Me.Text = "formHourlyNew"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcrHourlyNew1 As ucrHourlyNew
End Class
