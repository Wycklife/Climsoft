<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrNewYearSelector
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
        Me.cmsYearNew = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsYearViewLongYearNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsYearViewShortYearNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsYearNew.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmsYearNew
        '
        Me.cmsYearNew.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsYearViewLongYearNew, Me.cmsYearViewShortYearNew})
        Me.cmsYearNew.Name = "cmsYear"
        Me.cmsYearNew.Size = New System.Drawing.Size(156, 48)
        '
        'cmsYearViewLongYearNew
        '
        Me.cmsYearViewLongYearNew.Checked = True
        Me.cmsYearViewLongYearNew.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cmsYearViewLongYearNew.Name = "cmsYearViewLongYearNew"
        Me.cmsYearViewLongYearNew.Size = New System.Drawing.Size(155, 22)
        Me.cmsYearViewLongYearNew.Text = "View Long Year"
        '
        'cmsYearViewShortYearNew
        '
        Me.cmsYearViewShortYearNew.Name = "cmsYearViewShortYearNew"
        Me.cmsYearViewShortYearNew.Size = New System.Drawing.Size(155, 22)
        Me.cmsYearViewShortYearNew.Text = "View Short Year"
        '
        'ucrNewYearSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucrNewYearSelector"
        Me.cmsYearNew.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmsYearNew As ContextMenuStrip
    Friend WithEvents cmsYearViewLongYearNew As ToolStripMenuItem
    Friend WithEvents cmsYearViewShortYearNew As ToolStripMenuItem
End Class
