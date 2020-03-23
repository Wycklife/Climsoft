<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDataFormsNew
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
        Me.lblSelection = New System.Windows.Forms.Label()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.lstViewForms = New System.Windows.Forms.ListView()
        Me.formName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.formDescription = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'lblSelection
        '
        Me.lblSelection.AutoSize = True
        Me.lblSelection.Location = New System.Drawing.Point(4, 5)
        Me.lblSelection.Name = "lblSelection"
        Me.lblSelection.Size = New System.Drawing.Size(146, 13)
        Me.lblSelection.TabIndex = 17
        Me.lblSelection.Text = "Select the entry form to open:"
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(521, 262)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(69, 27)
        Me.btnCancel.TabIndex = 16
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHelp.Location = New System.Drawing.Point(596, 262)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(69, 27)
        Me.btnHelp.TabIndex = 15
        Me.btnHelp.Text = "Help"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'btnOk
        '
        Me.btnOk.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOk.Location = New System.Drawing.Point(446, 262)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(69, 27)
        Me.btnOk.TabIndex = 14
        Me.btnOk.Text = "Open"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'lstViewForms
        '
        Me.lstViewForms.AllowColumnReorder = True
        Me.lstViewForms.AllowDrop = True
        Me.lstViewForms.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.formName, Me.formDescription})
        Me.lstViewForms.FullRowSelect = True
        Me.lstViewForms.GridLines = True
        Me.lstViewForms.HideSelection = False
        Me.lstViewForms.HoverSelection = True
        Me.lstViewForms.Location = New System.Drawing.Point(4, 24)
        Me.lstViewForms.Name = "lstViewForms"
        Me.lstViewForms.RightToLeftLayout = True
        Me.lstViewForms.Scrollable = False
        Me.lstViewForms.Size = New System.Drawing.Size(659, 235)
        Me.lstViewForms.TabIndex = 13
        Me.lstViewForms.UseCompatibleStateImageBehavior = False
        Me.lstViewForms.View = System.Windows.Forms.View.Details
        '
        'formName
        '
        Me.formName.Text = "Form Name"
        Me.formName.Width = 150
        '
        'formDescription
        '
        Me.formDescription.Text = "Form Description"
        Me.formDescription.Width = 500
        '
        'frmDataFormsNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(667, 295)
        Me.Controls.Add(Me.lblSelection)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.lstViewForms)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmDataFormsNew"
        Me.Text = "Select Data Entry Form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblSelection As Label
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnHelp As Button
    Friend WithEvents btnOk As Button
    Public WithEvents lstViewForms As ListView
    Friend WithEvents formName As ColumnHeader
    Friend WithEvents formDescription As ColumnHeader
End Class
