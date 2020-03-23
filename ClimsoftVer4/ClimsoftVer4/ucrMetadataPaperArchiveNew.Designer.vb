<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrMetadataPaperArchiveNew
    Inherits ClimsoftVer4.ucrPage

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
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblFormId = New System.Windows.Forms.Label()
        Me.ucrTextboxNewFormID = New ClimsoftVer4.ucrTextBoxNew()
        Me.lbldescri = New System.Windows.Forms.Label()
        Me.ucrTextBoxNewDescription = New ClimsoftVer4.ucrTextBoxNew()
        Me.GroupBox13 = New System.Windows.Forms.GroupBox()
        Me.ucrBtnDelete = New ClimsoftVer4.ucrButton()
        Me.ucrBtnClear = New ClimsoftVer4.ucrButton()
        Me.ucrBtnView = New ClimsoftVer4.ucrButton()
        Me.ucrBtnAddNew = New ClimsoftVer4.ucrButton()
        Me.ucrBtnUpdate = New ClimsoftVer4.ucrButton()
        Me.ucrBtnSave = New ClimsoftVer4.ucrButton()
        Me.ucrNavigatorPaperArchive = New ClimsoftVer4.ucrNavigator()
        Me.GroupBox13.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(224, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(175, 16)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Paper Archive Definition"
        '
        'lblFormId
        '
        Me.lblFormId.AutoSize = True
        Me.lblFormId.Location = New System.Drawing.Point(202, 102)
        Me.lblFormId.Name = "lblFormId"
        Me.lblFormId.Size = New System.Drawing.Size(44, 13)
        Me.lblFormId.TabIndex = 2
        Me.lblFormId.Text = "Form ID"
        '
        'ucrTextboxNewFormID
        '
        Me.ucrTextboxNewFormID.Location = New System.Drawing.Point(278, 99)
        Me.ucrTextboxNewFormID.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrTextboxNewFormID.Name = "ucrTextboxNewFormID"
        Me.ucrTextboxNewFormID.Size = New System.Drawing.Size(136, 20)
        Me.ucrTextboxNewFormID.TabIndex = 3
        Me.ucrTextboxNewFormID.TextboxValue = ""
        '
        'lbldescri
        '
        Me.lbldescri.AutoSize = True
        Me.lbldescri.Location = New System.Drawing.Point(202, 143)
        Me.lbldescri.Name = "lbldescri"
        Me.lbldescri.Size = New System.Drawing.Size(60, 13)
        Me.lbldescri.TabIndex = 4
        Me.lbldescri.Text = "Description"
        '
        'ucrTextBoxNewDescription
        '
        Me.ucrTextBoxNewDescription.Location = New System.Drawing.Point(278, 141)
        Me.ucrTextBoxNewDescription.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrTextBoxNewDescription.Name = "ucrTextBoxNewDescription"
        Me.ucrTextBoxNewDescription.Size = New System.Drawing.Size(136, 20)
        Me.ucrTextBoxNewDescription.TabIndex = 5
        Me.ucrTextBoxNewDescription.TextboxValue = ""
        '
        'GroupBox13
        '
        Me.GroupBox13.Controls.Add(Me.ucrBtnDelete)
        Me.GroupBox13.Controls.Add(Me.ucrBtnClear)
        Me.GroupBox13.Controls.Add(Me.ucrBtnView)
        Me.GroupBox13.Controls.Add(Me.ucrBtnAddNew)
        Me.GroupBox13.Controls.Add(Me.ucrBtnUpdate)
        Me.GroupBox13.Controls.Add(Me.ucrBtnSave)
        Me.GroupBox13.Location = New System.Drawing.Point(6, 241)
        Me.GroupBox13.Name = "GroupBox13"
        Me.GroupBox13.Size = New System.Drawing.Size(606, 34)
        Me.GroupBox13.TabIndex = 6
        Me.GroupBox13.TabStop = False
        '
        'ucrBtnDelete
        '
        Me.ucrBtnDelete.ActionTypeId = ClimsoftVer4.ClsGlobals.EnumActionCode.Delete
        Me.ucrBtnDelete.ButtonText = "Delete"
        Me.ucrBtnDelete.Location = New System.Drawing.Point(308, 5)
        Me.ucrBtnDelete.Name = "ucrBtnDelete"
        Me.ucrBtnDelete.Size = New System.Drawing.Size(81, 27)
        Me.ucrBtnDelete.TabIndex = 65
        '
        'ucrBtnClear
        '
        Me.ucrBtnClear.ButtonText = "Clear"
        Me.ucrBtnClear.Location = New System.Drawing.Point(403, 5)
        Me.ucrBtnClear.Name = "ucrBtnClear"
        Me.ucrBtnClear.Size = New System.Drawing.Size(81, 27)
        Me.ucrBtnClear.TabIndex = 67
        '
        'ucrBtnView
        '
        Me.ucrBtnView.ButtonText = "View"
        Me.ucrBtnView.Location = New System.Drawing.Point(498, 5)
        Me.ucrBtnView.Name = "ucrBtnView"
        Me.ucrBtnView.Size = New System.Drawing.Size(81, 27)
        Me.ucrBtnView.TabIndex = 64
        '
        'ucrBtnAddNew
        '
        Me.ucrBtnAddNew.ActionTypeId = ClimsoftVer4.ClsGlobals.EnumActionCode.AddNew
        Me.ucrBtnAddNew.ButtonText = "AddNew"
        Me.ucrBtnAddNew.Location = New System.Drawing.Point(23, 5)
        Me.ucrBtnAddNew.Name = "ucrBtnAddNew"
        Me.ucrBtnAddNew.Size = New System.Drawing.Size(81, 27)
        Me.ucrBtnAddNew.TabIndex = 68
        '
        'ucrBtnUpdate
        '
        Me.ucrBtnUpdate.ActionTypeId = ClimsoftVer4.ClsGlobals.EnumActionCode.Update
        Me.ucrBtnUpdate.ButtonText = "Update"
        Me.ucrBtnUpdate.Location = New System.Drawing.Point(213, 5)
        Me.ucrBtnUpdate.Name = "ucrBtnUpdate"
        Me.ucrBtnUpdate.Size = New System.Drawing.Size(81, 27)
        Me.ucrBtnUpdate.TabIndex = 63
        '
        'ucrBtnSave
        '
        Me.ucrBtnSave.ActionTypeId = ClimsoftVer4.ClsGlobals.EnumActionCode.Save
        Me.ucrBtnSave.ButtonText = "Save"
        Me.ucrBtnSave.Location = New System.Drawing.Point(118, 5)
        Me.ucrBtnSave.Name = "ucrBtnSave"
        Me.ucrBtnSave.Size = New System.Drawing.Size(81, 27)
        Me.ucrBtnSave.TabIndex = 66
        '
        'ucrNavigatorPaperArchive
        '
        Me.ucrNavigatorPaperArchive.Location = New System.Drawing.Point(140, 286)
        Me.ucrNavigatorPaperArchive.Name = "ucrNavigatorPaperArchive"
        Me.ucrNavigatorPaperArchive.Size = New System.Drawing.Size(336, 25)
        Me.ucrNavigatorPaperArchive.TabIndex = 8
        '
        'ucrMetadataPaperArchiveNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrNavigatorPaperArchive)
        Me.Controls.Add(Me.GroupBox13)
        Me.Controls.Add(Me.ucrTextBoxNewDescription)
        Me.Controls.Add(Me.lbldescri)
        Me.Controls.Add(Me.ucrTextboxNewFormID)
        Me.Controls.Add(Me.lblFormId)
        Me.Controls.Add(Me.Label7)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ucrMetadataPaperArchiveNew"
        Me.Size = New System.Drawing.Size(617, 316)
        Me.GroupBox13.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label7 As Label
    Friend WithEvents lblFormId As Label
    Friend WithEvents ucrTextboxNewFormID As ucrTextBoxNew
    Friend WithEvents lbldescri As Label
    Friend WithEvents ucrTextBoxNewDescription As ucrTextBoxNew
    Friend WithEvents GroupBox13 As GroupBox
    Friend WithEvents ucrNavigatorPaperArchive As ucrNavigator
    Friend WithEvents ucrBtnDelete As ucrButton
    Friend WithEvents ucrBtnClear As ucrButton
    Friend WithEvents ucrBtnView As ucrButton
    Friend WithEvents ucrBtnAddNew As ucrButton
    Friend WithEvents ucrBtnUpdate As ucrButton
    Friend WithEvents ucrBtnSave As ucrButton
End Class
