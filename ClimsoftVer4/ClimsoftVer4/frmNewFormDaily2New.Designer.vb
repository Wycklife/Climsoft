<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNewFormDaily2New
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
        Me.ucrFormDaily2New = New ClimsoftVer4.ucrFormDaily2New()
        Me.SuspendLayout()
        '
        'ucrFormDaily2New
        '
        Me.ucrFormDaily2New.Location = New System.Drawing.Point(8, 7)
        Me.ucrFormDaily2New.Name = "ucrFormDaily2New"
        Me.ucrFormDaily2New.Size = New System.Drawing.Size(709, 597)
        Me.ucrFormDaily2New.TabIndex = 0
        '
        'frmNewFormDaily2New
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 631)
        Me.Controls.Add(Me.ucrFormDaily2New)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmNewFormDaily2New"
        Me.Text = "Daily data for the whole month"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ucrFormDaily2New As ucrFormDaily2New
End Class
