<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrMonthlyNew
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
        Me.cmsMonthNew = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsMonthIDsNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsMonthNamesNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsMonthShortMonthNamesNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsMonthNew.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmsMonthNew
        '
        Me.cmsMonthNew.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsMonthIDsNew, Me.cmsMonthNamesNew, Me.cmsMonthShortMonthNamesNew})
        Me.cmsMonthNew.Name = "cmsYear"
        Me.cmsMonthNew.Size = New System.Drawing.Size(210, 70)
        '
        'cmsMonthIDsNew
        '
        Me.cmsMonthIDsNew.Checked = True
        Me.cmsMonthIDsNew.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cmsMonthIDsNew.Name = "cmsMonthIDsNew"
        Me.cmsMonthIDsNew.Size = New System.Drawing.Size(209, 22)
        Me.cmsMonthIDsNew.Text = "View Month IDs"
        '
        'cmsMonthNamesNew
        '
        Me.cmsMonthNamesNew.Name = "cmsMonthNamesNew"
        Me.cmsMonthNamesNew.Size = New System.Drawing.Size(209, 22)
        Me.cmsMonthNamesNew.Text = "View Month Names"
        '
        'cmsMonthShortMonthNamesNew
        '
        Me.cmsMonthShortMonthNamesNew.Name = "cmsMonthShortMonthNamesNew"
        Me.cmsMonthShortMonthNamesNew.Size = New System.Drawing.Size(209, 22)
        Me.cmsMonthShortMonthNamesNew.Text = "View Short Month Names"
        '
        'ucrMonthlyNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucrMonthlyNew"
        Me.cmsMonthNew.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmsMonthNew As ContextMenuStrip
    Friend WithEvents cmsMonthIDsNew As ToolStripMenuItem
    Friend WithEvents cmsMonthNamesNew As ToolStripMenuItem
    Friend WithEvents cmsMonthShortMonthNamesNew As ToolStripMenuItem
End Class
