<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucrElementSelectorNew
    Inherits ucrComboboxNew

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.cmsStation = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.cmsElementNames = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsElementIDs = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsElementIDAndStation = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmsElementSortByID = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsElementSortyByName = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsFilterElements = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.cmsStation.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmsStation
        '
        Me.cmsStation.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.cmsElementNames, Me.cmsElementIDs, Me.cmsElementIDAndStation, Me.ToolStripSeparator2, Me.cmsElementSortByID, Me.cmsElementSortyByName, Me.cmsFilterElements, Me.ToolStripSeparator1})
        Me.cmsStation.Name = "cmsStation"
        Me.cmsStation.Size = New System.Drawing.Size(187, 170)
        '
        'cmsElementNames
        '
        Me.cmsElementNames.Name = "cmsElementNames"
        Me.cmsElementNames.Size = New System.Drawing.Size(186, 22)
        Me.cmsElementNames.Text = "Station Names"
        '
        'cmsElementIDs
        '
        Me.cmsElementIDs.Name = "cmsElementIDs"
        Me.cmsElementIDs.Size = New System.Drawing.Size(186, 22)
        Me.cmsElementIDs.Text = "IDs"
        '
        'cmsElementIDAndStation
        '
        Me.cmsElementIDAndStation.Name = "cmsElementIDAndStation"
        Me.cmsElementIDAndStation.Size = New System.Drawing.Size(186, 22)
        Me.cmsElementIDAndStation.Text = "ID and Station"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(183, 6)
        '
        'cmsElementSortByID
        '
        Me.cmsElementSortByID.Name = "cmsElementSortByID"
        Me.cmsElementSortByID.Size = New System.Drawing.Size(186, 22)
        Me.cmsElementSortByID.Text = "Sort By ID"
        '
        'cmsElementSortyByName
        '
        Me.cmsElementSortyByName.Name = "cmsElementSortyByName"
        Me.cmsElementSortyByName.Size = New System.Drawing.Size(186, 22)
        Me.cmsElementSortyByName.Text = "Sort By Station Name"
        '
        'cmsFilterElements
        '
        Me.cmsFilterElements.Name = "cmsFilterElements"
        Me.cmsFilterElements.Size = New System.Drawing.Size(186, 22)
        Me.cmsFilterElements.Text = "Filter Stations"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(183, 6)
        '
        'ucrElementSelectorNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "ucrElementSelectorNew"
        Me.Size = New System.Drawing.Size(183, 21)
        Me.cmsStation.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents cmsStation As ContextMenuStrip
    Friend WithEvents cmsElementNames As ToolStripMenuItem
    Friend WithEvents cmsElementIDs As ToolStripMenuItem
    Friend WithEvents cmsElementIDAndStation As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents cmsElementSortByID As ToolStripMenuItem
    Friend WithEvents cmsElementSortyByName As ToolStripMenuItem
    Friend WithEvents cmsFilterElements As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
End Class
