<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrElementInformation
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
        Dim ElementtypeLabel As System.Windows.Forms.Label
        Dim UnitsLabel As System.Windows.Forms.Label
        Dim LowerLimitLabel As System.Windows.Forms.Label
        Dim UpperLimitLabel As System.Windows.Forms.Label
        Dim ElementScaleLabel As System.Windows.Forms.Label
        Dim DescriptionLabel As System.Windows.Forms.Label
        Dim ElementNameLabel As System.Windows.Forms.Label
        Dim AbbreviationLabel As System.Windows.Forms.Label
        Dim CodeLabel As System.Windows.Forms.Label
        Dim ucrTxtLowerLimit As ClimsoftVer4.ucrTextBoxNew
        Dim ucrTxtUpperLimit As ClimsoftVer4.ucrTextBoxNew
        Dim ucrTxtUnits As ClimsoftVer4.ucrTextBoxNew
        Dim ucrTxtElementScale As ClimsoftVer4.ucrTextBoxNew
        Dim ucrTxtElementType As ClimsoftVer4.ucrTextBoxNew
        Me.UcrNavigator1 = New ClimsoftVer4.ucrNavigator()
        Me.ucrBtnAddNew = New ClimsoftVer4.ucrButton()
        Me.ucrBtnSave = New ClimsoftVer4.ucrButton()
        Me.ucrBtnUpdate = New ClimsoftVer4.ucrButton()
        Me.ucrBtnDelete = New ClimsoftVer4.ucrButton()
        Me.ucrBtnClear = New ClimsoftVer4.ucrButton()
        Me.ucrClose = New ClimsoftVer4.ucrButton()
        Me.ucrBtnHelp = New ClimsoftVer4.ucrButton()
        Me.ucrTxtCodeTextBox = New ClimsoftVer4.ucrTextBoxNew()
        Me.ucrTextAbbreviationText = New ClimsoftVer4.ucrTextBoxNew()
        Me.ucrTxtElementname = New ClimsoftVer4.ucrTextBoxNew()
        Me.ucrTxtDescription = New ClimsoftVer4.ucrTextBoxNew()
        ElementtypeLabel = New System.Windows.Forms.Label()
        UnitsLabel = New System.Windows.Forms.Label()
        LowerLimitLabel = New System.Windows.Forms.Label()
        UpperLimitLabel = New System.Windows.Forms.Label()
        ElementScaleLabel = New System.Windows.Forms.Label()
        DescriptionLabel = New System.Windows.Forms.Label()
        ElementNameLabel = New System.Windows.Forms.Label()
        AbbreviationLabel = New System.Windows.Forms.Label()
        CodeLabel = New System.Windows.Forms.Label()
        ucrTxtLowerLimit = New ClimsoftVer4.ucrTextBoxNew()
        ucrTxtUpperLimit = New ClimsoftVer4.ucrTextBoxNew()
        ucrTxtUnits = New ClimsoftVer4.ucrTextBoxNew()
        ucrTxtElementScale = New ClimsoftVer4.ucrTextBoxNew()
        ucrTxtElementType = New ClimsoftVer4.ucrTextBoxNew()
        Me.SuspendLayout()
        '
        'ElementtypeLabel
        '
        ElementtypeLabel.AutoSize = True
        ElementtypeLabel.Location = New System.Drawing.Point(83, 241)
        ElementtypeLabel.Name = "ElementtypeLabel"
        ElementtypeLabel.Size = New System.Drawing.Size(75, 13)
        ElementtypeLabel.TabIndex = 26
        ElementtypeLabel.Text = "Element Type:"
        '
        'UnitsLabel
        '
        UnitsLabel.AutoSize = True
        UnitsLabel.Location = New System.Drawing.Point(83, 205)
        UnitsLabel.Name = "UnitsLabel"
        UnitsLabel.Size = New System.Drawing.Size(34, 13)
        UnitsLabel.TabIndex = 25
        UnitsLabel.Text = "Units:"
        '
        'LowerLimitLabel
        '
        LowerLimitLabel.AutoSize = True
        LowerLimitLabel.Location = New System.Drawing.Point(82, 161)
        LowerLimitLabel.Name = "LowerLimitLabel"
        LowerLimitLabel.Size = New System.Drawing.Size(63, 13)
        LowerLimitLabel.TabIndex = 24
        LowerLimitLabel.Text = "Lower Limit:"
        '
        'UpperLimitLabel
        '
        UpperLimitLabel.AutoSize = True
        UpperLimitLabel.Location = New System.Drawing.Point(296, 161)
        UpperLimitLabel.Name = "UpperLimitLabel"
        UpperLimitLabel.Size = New System.Drawing.Size(63, 13)
        UpperLimitLabel.TabIndex = 23
        UpperLimitLabel.Text = "Upper Limit:"
        '
        'ElementScaleLabel
        '
        ElementScaleLabel.AutoSize = True
        ElementScaleLabel.Location = New System.Drawing.Point(297, 205)
        ElementScaleLabel.Name = "ElementScaleLabel"
        ElementScaleLabel.Size = New System.Drawing.Size(78, 13)
        ElementScaleLabel.TabIndex = 22
        ElementScaleLabel.Text = "Element Scale:"
        '
        'DescriptionLabel
        '
        DescriptionLabel.AutoSize = True
        DescriptionLabel.Location = New System.Drawing.Point(83, 121)
        DescriptionLabel.Name = "DescriptionLabel"
        DescriptionLabel.Size = New System.Drawing.Size(63, 13)
        DescriptionLabel.TabIndex = 21
        DescriptionLabel.Text = "Description:"
        '
        'ElementNameLabel
        '
        ElementNameLabel.AutoSize = True
        ElementNameLabel.Location = New System.Drawing.Point(82, 81)
        ElementNameLabel.Name = "ElementNameLabel"
        ElementNameLabel.Size = New System.Drawing.Size(79, 13)
        ElementNameLabel.TabIndex = 20
        ElementNameLabel.Text = "Element Name:"
        '
        'AbbreviationLabel
        '
        AbbreviationLabel.AutoSize = True
        AbbreviationLabel.Location = New System.Drawing.Point(297, 43)
        AbbreviationLabel.Name = "AbbreviationLabel"
        AbbreviationLabel.Size = New System.Drawing.Size(69, 13)
        AbbreviationLabel.TabIndex = 19
        AbbreviationLabel.Text = "Abbreviation:"
        '
        'CodeLabel
        '
        CodeLabel.AutoSize = True
        CodeLabel.Location = New System.Drawing.Point(83, 40)
        CodeLabel.Name = "CodeLabel"
        CodeLabel.Size = New System.Drawing.Size(62, 13)
        CodeLabel.TabIndex = 18
        CodeLabel.Text = "Element ID:"
        '
        'ucrTxtLowerLimit
        '
        ucrTxtLowerLimit.FieldName = Nothing
        ucrTxtLowerLimit.Location = New System.Drawing.Point(166, 158)
        ucrTxtLowerLimit.Name = "ucrTxtLowerLimit"
        ucrTxtLowerLimit.Size = New System.Drawing.Size(100, 20)
        ucrTxtLowerLimit.TabIndex = 31
        ucrTxtLowerLimit.TextboxValue = ""
        '
        'ucrTxtUpperLimit
        '
        ucrTxtUpperLimit.FieldName = Nothing
        ucrTxtUpperLimit.Location = New System.Drawing.Point(380, 158)
        ucrTxtUpperLimit.Name = "ucrTxtUpperLimit"
        ucrTxtUpperLimit.Size = New System.Drawing.Size(100, 20)
        ucrTxtUpperLimit.TabIndex = 32
        ucrTxtUpperLimit.TextboxValue = ""
        '
        'ucrTxtUnits
        '
        ucrTxtUnits.FieldName = Nothing
        ucrTxtUnits.Location = New System.Drawing.Point(166, 202)
        ucrTxtUnits.Name = "ucrTxtUnits"
        ucrTxtUnits.Size = New System.Drawing.Size(100, 20)
        ucrTxtUnits.TabIndex = 33
        ucrTxtUnits.TextboxValue = ""
        '
        'ucrTxtElementScale
        '
        ucrTxtElementScale.FieldName = Nothing
        ucrTxtElementScale.Location = New System.Drawing.Point(380, 202)
        ucrTxtElementScale.Name = "ucrTxtElementScale"
        ucrTxtElementScale.Size = New System.Drawing.Size(100, 20)
        ucrTxtElementScale.TabIndex = 34
        ucrTxtElementScale.TextboxValue = ""
        '
        'ucrTxtElementType
        '
        ucrTxtElementType.FieldName = Nothing
        ucrTxtElementType.Location = New System.Drawing.Point(166, 238)
        ucrTxtElementType.Name = "ucrTxtElementType"
        ucrTxtElementType.Size = New System.Drawing.Size(100, 20)
        ucrTxtElementType.TabIndex = 35
        ucrTxtElementType.TextboxValue = ""
        '
        'UcrNavigator1
        '
        Me.UcrNavigator1.Location = New System.Drawing.Point(148, 281)
        Me.UcrNavigator1.Name = "UcrNavigator1"
        Me.UcrNavigator1.Size = New System.Drawing.Size(340, 30)
        Me.UcrNavigator1.TabIndex = 0
        '
        'ucrBtnAddNew
        '
        Me.ucrBtnAddNew.ActionTypeId = ClimsoftVer4.ClsGlobals.EnumActionCode.AddNew
        Me.ucrBtnAddNew.ButtonText = "Add New"
        Me.ucrBtnAddNew.Location = New System.Drawing.Point(29, 319)
        Me.ucrBtnAddNew.Name = "ucrBtnAddNew"
        Me.ucrBtnAddNew.Size = New System.Drawing.Size(75, 23)
        Me.ucrBtnAddNew.TabIndex = 1
        '
        'ucrBtnSave
        '
        Me.ucrBtnSave.ActionTypeId = ClimsoftVer4.ClsGlobals.EnumActionCode.Save
        Me.ucrBtnSave.ButtonText = "Save"
        Me.ucrBtnSave.Location = New System.Drawing.Point(110, 319)
        Me.ucrBtnSave.Name = "ucrBtnSave"
        Me.ucrBtnSave.Size = New System.Drawing.Size(75, 23)
        Me.ucrBtnSave.TabIndex = 2
        '
        'ucrBtnUpdate
        '
        Me.ucrBtnUpdate.ActionTypeId = ClimsoftVer4.ClsGlobals.EnumActionCode.Update
        Me.ucrBtnUpdate.ButtonText = "Update"
        Me.ucrBtnUpdate.Location = New System.Drawing.Point(191, 319)
        Me.ucrBtnUpdate.Name = "ucrBtnUpdate"
        Me.ucrBtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.ucrBtnUpdate.TabIndex = 3
        '
        'ucrBtnDelete
        '
        Me.ucrBtnDelete.ActionTypeId = ClimsoftVer4.ClsGlobals.EnumActionCode.Delete
        Me.ucrBtnDelete.ButtonText = "Delete"
        Me.ucrBtnDelete.Location = New System.Drawing.Point(272, 319)
        Me.ucrBtnDelete.Name = "ucrBtnDelete"
        Me.ucrBtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.ucrBtnDelete.TabIndex = 4
        '
        'ucrBtnClear
        '
        Me.ucrBtnClear.ButtonText = "Clear"
        Me.ucrBtnClear.Location = New System.Drawing.Point(357, 319)
        Me.ucrBtnClear.Name = "ucrBtnClear"
        Me.ucrBtnClear.Size = New System.Drawing.Size(75, 23)
        Me.ucrBtnClear.TabIndex = 5
        '
        'ucrClose
        '
        Me.ucrClose.ButtonText = "Close"
        Me.ucrClose.Location = New System.Drawing.Point(438, 319)
        Me.ucrClose.Name = "ucrClose"
        Me.ucrClose.Size = New System.Drawing.Size(75, 23)
        Me.ucrClose.TabIndex = 6
        '
        'ucrBtnHelp
        '
        Me.ucrBtnHelp.ButtonText = "Help"
        Me.ucrBtnHelp.Location = New System.Drawing.Point(519, 319)
        Me.ucrBtnHelp.Name = "ucrBtnHelp"
        Me.ucrBtnHelp.Size = New System.Drawing.Size(75, 23)
        Me.ucrBtnHelp.TabIndex = 7
        '
        'ucrTxtCodeTextBox
        '
        Me.ucrTxtCodeTextBox.FieldName = Nothing
        Me.ucrTxtCodeTextBox.Location = New System.Drawing.Point(166, 37)
        Me.ucrTxtCodeTextBox.Name = "ucrTxtCodeTextBox"
        Me.ucrTxtCodeTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ucrTxtCodeTextBox.TabIndex = 27
        Me.ucrTxtCodeTextBox.TextboxValue = ""
        '
        'ucrTextAbbreviationText
        '
        Me.ucrTextAbbreviationText.FieldName = Nothing
        Me.ucrTextAbbreviationText.Location = New System.Drawing.Point(380, 40)
        Me.ucrTextAbbreviationText.Name = "ucrTextAbbreviationText"
        Me.ucrTextAbbreviationText.Size = New System.Drawing.Size(100, 20)
        Me.ucrTextAbbreviationText.TabIndex = 28
        Me.ucrTextAbbreviationText.TextboxValue = ""
        '
        'ucrTxtElementname
        '
        Me.ucrTxtElementname.FieldName = Nothing
        Me.ucrTxtElementname.Location = New System.Drawing.Point(166, 78)
        Me.ucrTxtElementname.Name = "ucrTxtElementname"
        Me.ucrTxtElementname.Size = New System.Drawing.Size(314, 20)
        Me.ucrTxtElementname.TabIndex = 29
        Me.ucrTxtElementname.TextboxValue = ""
        '
        'ucrTxtDescription
        '
        Me.ucrTxtDescription.FieldName = Nothing
        Me.ucrTxtDescription.Location = New System.Drawing.Point(166, 118)
        Me.ucrTxtDescription.Name = "ucrTxtDescription"
        Me.ucrTxtDescription.Size = New System.Drawing.Size(314, 20)
        Me.ucrTxtDescription.TabIndex = 30
        Me.ucrTxtDescription.TextboxValue = ""
        '
        'ucrElementInformation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(ucrTxtElementType)
        Me.Controls.Add(ucrTxtElementScale)
        Me.Controls.Add(ucrTxtUnits)
        Me.Controls.Add(ucrTxtUpperLimit)
        Me.Controls.Add(ucrTxtLowerLimit)
        Me.Controls.Add(Me.ucrTxtDescription)
        Me.Controls.Add(Me.ucrTxtElementname)
        Me.Controls.Add(Me.ucrTextAbbreviationText)
        Me.Controls.Add(Me.ucrTxtCodeTextBox)
        Me.Controls.Add(ElementtypeLabel)
        Me.Controls.Add(UnitsLabel)
        Me.Controls.Add(LowerLimitLabel)
        Me.Controls.Add(UpperLimitLabel)
        Me.Controls.Add(ElementScaleLabel)
        Me.Controls.Add(DescriptionLabel)
        Me.Controls.Add(ElementNameLabel)
        Me.Controls.Add(AbbreviationLabel)
        Me.Controls.Add(CodeLabel)
        Me.Controls.Add(Me.ucrBtnHelp)
        Me.Controls.Add(Me.ucrClose)
        Me.Controls.Add(Me.ucrBtnClear)
        Me.Controls.Add(Me.ucrBtnDelete)
        Me.Controls.Add(Me.ucrBtnUpdate)
        Me.Controls.Add(Me.ucrBtnSave)
        Me.Controls.Add(Me.ucrBtnAddNew)
        Me.Controls.Add(Me.UcrNavigator1)
        Me.Name = "ucrElementInformation"
        Me.Size = New System.Drawing.Size(629, 402)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UcrNavigator1 As ucrNavigator
    Friend WithEvents ucrBtnAddNew As ucrButton
    Friend WithEvents ucrBtnSave As ucrButton
    Friend WithEvents ucrBtnUpdate As ucrButton
    Friend WithEvents ucrBtnDelete As ucrButton
    Friend WithEvents ucrBtnClear As ucrButton
    Friend WithEvents ucrClose As ucrButton
    Friend WithEvents ucrBtnHelp As ucrButton
    Friend WithEvents ucrTxtCodeTextBox As ucrTextBoxNew
    Friend WithEvents ucrTextAbbreviationText As ucrTextBoxNew
    Friend WithEvents ucrTxtElementname As ucrTextBoxNew
    Friend WithEvents ucrTxtDescription As ucrTextBoxNew
End Class
