<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAgro1New
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
        Me.UcrFormAgro11 = New ClimsoftVer4.ucrFormAgro1()
        Me.SuspendLayout()
        '
        'UcrFormAgro11
        '
        Me.UcrFormAgro11.Location = New System.Drawing.Point(1, 1)
        Me.UcrFormAgro11.Margin = New System.Windows.Forms.Padding(4)
        Me.UcrFormAgro11.Name = "UcrFormAgro11"
        Me.UcrFormAgro11.Size = New System.Drawing.Size(771, 621)
        Me.UcrFormAgro11.TabIndex = 0
        '
        'FormAgro1New
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(776, 629)
        Me.Controls.Add(Me.UcrFormAgro11)
        Me.KeyPreview = True
        Me.Name = "FormAgro1New"
        Me.Text = "Kenya Agromet data"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents UcrFormAgro11 As ucrFormAgro1
End Class
