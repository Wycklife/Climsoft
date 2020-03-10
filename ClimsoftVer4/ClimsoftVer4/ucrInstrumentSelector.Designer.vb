<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrInstrumentSelector
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
        Me.cmsInstruments = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsInstrumentNames = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsInstrumentIDs = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsInstrumentIDName = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmsInstrumentSortByID = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsInstrumentSortyByName = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsInstrumentFilter = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmsInstruments.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmsInstruments
        '
        Me.cmsInstruments.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsInstrumentNames, Me.cmsInstrumentIDs, Me.cmsInstrumentIDName, Me.ToolStripSeparator2, Me.cmsInstrumentSortByID, Me.cmsInstrumentSortyByName, Me.cmsInstrumentFilter, Me.ToolStripSeparator1})
        Me.cmsInstruments.Name = "cmsStation"
        Me.cmsInstruments.Size = New System.Drawing.Size(193, 148)
        '
        'cmsInstrumentNames
        '
        Me.cmsInstrumentNames.Name = "cmsInstrumentNames"
        Me.cmsInstrumentNames.Size = New System.Drawing.Size(192, 22)
        Me.cmsInstrumentNames.Text = "Element Names"
        '
        'cmsInstrumentIDs
        '
        Me.cmsInstrumentIDs.Name = "cmsInstrumentIDs"
        Me.cmsInstrumentIDs.Size = New System.Drawing.Size(192, 22)
        Me.cmsInstrumentIDs.Text = "IDs"
        '
        'cmsInstrumentIDName
        '
        Me.cmsInstrumentIDName.Name = "cmsInstrumentIDName"
        Me.cmsInstrumentIDName.Size = New System.Drawing.Size(192, 22)
        Me.cmsInstrumentIDName.Text = "ID and Element Name"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(189, 6)
        '
        'cmsInstrumentSortByID
        '
        Me.cmsInstrumentSortByID.Name = "cmsInstrumentSortByID"
        Me.cmsInstrumentSortByID.Size = New System.Drawing.Size(192, 22)
        Me.cmsInstrumentSortByID.Text = "Sort By ID"
        '
        'cmsInstrumentSortyByName
        '
        Me.cmsInstrumentSortyByName.Name = "cmsInstrumentSortyByName"
        Me.cmsInstrumentSortyByName.Size = New System.Drawing.Size(192, 22)
        Me.cmsInstrumentSortyByName.Text = "Sort By Element Name"
        '
        'cmsInstrumentFilter
        '
        Me.cmsInstrumentFilter.Name = "cmsInstrumentFilter"
        Me.cmsInstrumentFilter.Size = New System.Drawing.Size(192, 22)
        Me.cmsInstrumentFilter.Text = "Filter Stations"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(189, 6)
        '
        'ucrInstrumentSelector
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucrInstrumentSelector"
        Me.cmsInstruments.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmsInstruments As ContextMenuStrip
    Friend WithEvents cmsInstrumentNames As ToolStripMenuItem
    Friend WithEvents cmsInstrumentIDs As ToolStripMenuItem
    Friend WithEvents cmsInstrumentIDName As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents cmsInstrumentSortByID As ToolStripMenuItem
    Friend WithEvents cmsInstrumentSortyByName As ToolStripMenuItem
    Friend WithEvents cmsInstrumentFilter As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class
