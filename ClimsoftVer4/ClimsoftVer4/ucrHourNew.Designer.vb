<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrHourNew
    Inherits ClimsoftVer4.ucrComboboxNew

    'UserControl overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.cmsHourNew = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsHour24New = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsHour12New = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsHourNew.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmsHourNew
        '
        Me.cmsHourNew.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsHour24New, Me.cmsHour12New})
        Me.cmsHourNew.Name = "cmsYear"
        Me.cmsHourNew.Size = New System.Drawing.Size(158, 48)
        '
        'cmsHour24New
        '
        Me.cmsHour24New.Checked = True
        Me.cmsHour24New.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cmsHour24New.Name = "cmsHour24New"
        Me.cmsHour24New.Size = New System.Drawing.Size(157, 22)
        Me.cmsHour24New.Text = "View in 24hours"
        '
        'cmsHour12New
        '
        Me.cmsHour12New.Name = "cmsHour12New"
        Me.cmsHour12New.Size = New System.Drawing.Size(157, 22)
        Me.cmsHour12New.Text = "View in 12hrs"
        '
        'ucrHourNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucrHourNew"
        Me.cmsHourNew.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmsHourNew As ContextMenuStrip
    Friend WithEvents cmsHour24New As ToolStripMenuItem
    Friend WithEvents cmsHour12New As ToolStripMenuItem
End Class
