<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrMetadataInstrumentNew
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
        Me.lblInstrumentID = New System.Windows.Forms.Label()
        Me.lblInstrumentName = New System.Windows.Forms.Label()
        Me.ucrTextBoxNewInstrumentName = New ClimsoftVer4.ucrTextBoxNew()
        Me.lblInstrumentAbbreviation = New System.Windows.Forms.Label()
        Me.ucrTextBoxNewAbbreviation = New ClimsoftVer4.ucrTextBoxNew()
        Me.lbStationID = New System.Windows.Forms.Label()
        Me.lblSerialNumber = New System.Windows.Forms.Label()
        Me.ucrTextBoxNewSerialNumber = New ClimsoftVer4.ucrTextBoxNew()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.ucrTextBoxNewModel = New ClimsoftVer4.ucrTextBoxNew()
        Me.lblManufacturer = New System.Windows.Forms.Label()
        Me.ucrTextBoxNewManufacturer = New ClimsoftVer4.ucrTextBoxNew()
        Me.lblUncertainity = New System.Windows.Forms.Label()
        Me.ucrTextBoxNewUncertainity = New ClimsoftVer4.ucrTextBoxNew()
        Me.lblIinstallationDate = New System.Windows.Forms.Label()
        Me.ucrDatePickerNewInstallationDate = New ClimsoftVer4.ucrDatePickerNew()
        Me.lblDeinstallationDate = New System.Windows.Forms.Label()
        Me.ucrDatePickerNewDeinstallationDate = New ClimsoftVer4.ucrDatePickerNew()
        Me.lblInstalledAt = New System.Windows.Forms.Label()
        Me.ucrTextBoxNewHeight = New ClimsoftVer4.ucrTextBoxNew()
        Me.lblImageFile = New System.Windows.Forms.Label()
        Me.ucrTextBoxNewImageFile = New ClimsoftVer4.ucrTextBoxNew()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.grpCommand2 = New System.Windows.Forms.GroupBox()
        Me.ucrNavigatorInstrument = New ClimsoftVer4.ucrNavigator()
        Me.pbInstrument = New System.Windows.Forms.PictureBox()
        Me.lblInstrumentPic = New System.Windows.Forms.Label()
        Me.lblInstruments = New System.Windows.Forms.Label()
        Me.ucrSelectorInstrumentID = New ClimsoftVer4.ucrInstrumentSelector()
        Me.ucrStationSelectorID = New ClimsoftVer4.ucrStationSelectorNew()
        Me.ucrBtnAddNew = New ClimsoftVer4.ucrButton()
        Me.ucrBtnSave = New ClimsoftVer4.ucrButton()
        Me.ucrBtnUpdate = New ClimsoftVer4.ucrButton()
        Me.ucrBtnDelete = New ClimsoftVer4.ucrButton()
        Me.ucrBtnClear = New ClimsoftVer4.ucrButton()
        Me.ucrBtnView = New ClimsoftVer4.ucrButton()
        Me.grpCommand2.SuspendLayout()
        CType(Me.pbInstrument, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblInstrumentID
        '
        Me.lblInstrumentID.AutoSize = True
        Me.lblInstrumentID.Location = New System.Drawing.Point(29, 54)
        Me.lblInstrumentID.Name = "lblInstrumentID"
        Me.lblInstrumentID.Size = New System.Drawing.Size(70, 13)
        Me.lblInstrumentID.TabIndex = 2
        Me.lblInstrumentID.Text = "Instrument ID"
        '
        'lblInstrumentName
        '
        Me.lblInstrumentName.AutoSize = True
        Me.lblInstrumentName.Location = New System.Drawing.Point(29, 82)
        Me.lblInstrumentName.Name = "lblInstrumentName"
        Me.lblInstrumentName.Size = New System.Drawing.Size(35, 13)
        Me.lblInstrumentName.TabIndex = 4
        Me.lblInstrumentName.Text = "Name"
        '
        'ucrTextBoxNewInstrumentName
        '
        Me.ucrTextBoxNewInstrumentName.Location = New System.Drawing.Point(132, 76)
        Me.ucrTextBoxNewInstrumentName.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrTextBoxNewInstrumentName.Name = "ucrTextBoxNewInstrumentName"
        Me.ucrTextBoxNewInstrumentName.Size = New System.Drawing.Size(139, 20)
        Me.ucrTextBoxNewInstrumentName.TabIndex = 5
        Me.ucrTextBoxNewInstrumentName.TextboxValue = ""
        '
        'lblInstrumentAbbreviation
        '
        Me.lblInstrumentAbbreviation.AutoSize = True
        Me.lblInstrumentAbbreviation.Location = New System.Drawing.Point(29, 110)
        Me.lblInstrumentAbbreviation.Name = "lblInstrumentAbbreviation"
        Me.lblInstrumentAbbreviation.Size = New System.Drawing.Size(66, 13)
        Me.lblInstrumentAbbreviation.TabIndex = 6
        Me.lblInstrumentAbbreviation.Text = "Abbreviation"
        '
        'ucrTextBoxNewAbbreviation
        '
        Me.ucrTextBoxNewAbbreviation.Location = New System.Drawing.Point(132, 108)
        Me.ucrTextBoxNewAbbreviation.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrTextBoxNewAbbreviation.Name = "ucrTextBoxNewAbbreviation"
        Me.ucrTextBoxNewAbbreviation.Size = New System.Drawing.Size(139, 20)
        Me.ucrTextBoxNewAbbreviation.TabIndex = 7
        Me.ucrTextBoxNewAbbreviation.TextboxValue = ""
        '
        'lbStationID
        '
        Me.lbStationID.AutoSize = True
        Me.lbStationID.Location = New System.Drawing.Point(29, 138)
        Me.lbStationID.Name = "lbStationID"
        Me.lbStationID.Size = New System.Drawing.Size(54, 13)
        Me.lbStationID.TabIndex = 8
        Me.lbStationID.Text = "Station ID"
        '
        'lblSerialNumber
        '
        Me.lblSerialNumber.AutoSize = True
        Me.lblSerialNumber.Location = New System.Drawing.Point(29, 166)
        Me.lblSerialNumber.Name = "lblSerialNumber"
        Me.lblSerialNumber.Size = New System.Drawing.Size(73, 13)
        Me.lblSerialNumber.TabIndex = 10
        Me.lblSerialNumber.Text = "Serial Number"
        '
        'ucrTextBoxNewSerialNumber
        '
        Me.ucrTextBoxNewSerialNumber.Location = New System.Drawing.Point(132, 166)
        Me.ucrTextBoxNewSerialNumber.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrTextBoxNewSerialNumber.Name = "ucrTextBoxNewSerialNumber"
        Me.ucrTextBoxNewSerialNumber.Size = New System.Drawing.Size(139, 20)
        Me.ucrTextBoxNewSerialNumber.TabIndex = 11
        Me.ucrTextBoxNewSerialNumber.TextboxValue = ""
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Location = New System.Drawing.Point(29, 194)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(36, 13)
        Me.lblModel.TabIndex = 12
        Me.lblModel.Text = "Model"
        '
        'ucrTextBoxNewModel
        '
        Me.ucrTextBoxNewModel.Location = New System.Drawing.Point(132, 194)
        Me.ucrTextBoxNewModel.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrTextBoxNewModel.Name = "ucrTextBoxNewModel"
        Me.ucrTextBoxNewModel.Size = New System.Drawing.Size(139, 20)
        Me.ucrTextBoxNewModel.TabIndex = 13
        Me.ucrTextBoxNewModel.TextboxValue = ""
        '
        'lblManufacturer
        '
        Me.lblManufacturer.AutoSize = True
        Me.lblManufacturer.Location = New System.Drawing.Point(29, 222)
        Me.lblManufacturer.Name = "lblManufacturer"
        Me.lblManufacturer.Size = New System.Drawing.Size(70, 13)
        Me.lblManufacturer.TabIndex = 14
        Me.lblManufacturer.Text = "Manufacturer"
        '
        'ucrTextBoxNewManufacturer
        '
        Me.ucrTextBoxNewManufacturer.Location = New System.Drawing.Point(132, 222)
        Me.ucrTextBoxNewManufacturer.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrTextBoxNewManufacturer.Name = "ucrTextBoxNewManufacturer"
        Me.ucrTextBoxNewManufacturer.Size = New System.Drawing.Size(139, 20)
        Me.ucrTextBoxNewManufacturer.TabIndex = 15
        Me.ucrTextBoxNewManufacturer.TextboxValue = ""
        '
        'lblUncertainity
        '
        Me.lblUncertainity.AutoSize = True
        Me.lblUncertainity.Location = New System.Drawing.Point(29, 250)
        Me.lblUncertainity.Name = "lblUncertainity"
        Me.lblUncertainity.Size = New System.Drawing.Size(63, 13)
        Me.lblUncertainity.TabIndex = 16
        Me.lblUncertainity.Text = "Uncertainity"
        '
        'ucrTextBoxNewUncertainity
        '
        Me.ucrTextBoxNewUncertainity.Location = New System.Drawing.Point(132, 250)
        Me.ucrTextBoxNewUncertainity.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrTextBoxNewUncertainity.Name = "ucrTextBoxNewUncertainity"
        Me.ucrTextBoxNewUncertainity.Size = New System.Drawing.Size(139, 20)
        Me.ucrTextBoxNewUncertainity.TabIndex = 17
        Me.ucrTextBoxNewUncertainity.TextboxValue = ""
        '
        'lblIinstallationDate
        '
        Me.lblIinstallationDate.AutoSize = True
        Me.lblIinstallationDate.Location = New System.Drawing.Point(29, 278)
        Me.lblIinstallationDate.Name = "lblIinstallationDate"
        Me.lblIinstallationDate.Size = New System.Drawing.Size(83, 13)
        Me.lblIinstallationDate.TabIndex = 18
        Me.lblIinstallationDate.Text = "Installation Date"
        '
        'ucrDatePickerNewInstallationDate
        '
        Me.ucrDatePickerNewInstallationDate.Location = New System.Drawing.Point(132, 278)
        Me.ucrDatePickerNewInstallationDate.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrDatePickerNewInstallationDate.Name = "ucrDatePickerNewInstallationDate"
        Me.ucrDatePickerNewInstallationDate.Size = New System.Drawing.Size(139, 23)
        Me.ucrDatePickerNewInstallationDate.TabIndex = 19
        '
        'lblDeinstallationDate
        '
        Me.lblDeinstallationDate.AutoSize = True
        Me.lblDeinstallationDate.Location = New System.Drawing.Point(28, 306)
        Me.lblDeinstallationDate.Name = "lblDeinstallationDate"
        Me.lblDeinstallationDate.Size = New System.Drawing.Size(96, 13)
        Me.lblDeinstallationDate.TabIndex = 20
        Me.lblDeinstallationDate.Text = "Deinstallation Date"
        '
        'ucrDatePickerNewDeinstallationDate
        '
        Me.ucrDatePickerNewDeinstallationDate.Location = New System.Drawing.Point(130, 303)
        Me.ucrDatePickerNewDeinstallationDate.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrDatePickerNewDeinstallationDate.Name = "ucrDatePickerNewDeinstallationDate"
        Me.ucrDatePickerNewDeinstallationDate.Size = New System.Drawing.Size(139, 23)
        Me.ucrDatePickerNewDeinstallationDate.TabIndex = 21
        '
        'lblInstalledAt
        '
        Me.lblInstalledAt.AutoSize = True
        Me.lblInstalledAt.Location = New System.Drawing.Point(28, 334)
        Me.lblInstalledAt.Name = "lblInstalledAt"
        Me.lblInstalledAt.Size = New System.Drawing.Size(38, 13)
        Me.lblInstalledAt.TabIndex = 22
        Me.lblInstalledAt.Text = "Height"
        '
        'ucrTextBoxNewHeight
        '
        Me.ucrTextBoxNewHeight.Location = New System.Drawing.Point(132, 334)
        Me.ucrTextBoxNewHeight.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrTextBoxNewHeight.Name = "ucrTextBoxNewHeight"
        Me.ucrTextBoxNewHeight.Size = New System.Drawing.Size(51, 20)
        Me.ucrTextBoxNewHeight.TabIndex = 23
        Me.ucrTextBoxNewHeight.TextboxValue = ""
        '
        'lblImageFile
        '
        Me.lblImageFile.AutoSize = True
        Me.lblImageFile.Location = New System.Drawing.Point(28, 362)
        Me.lblImageFile.Name = "lblImageFile"
        Me.lblImageFile.Size = New System.Drawing.Size(55, 13)
        Me.lblImageFile.TabIndex = 24
        Me.lblImageFile.Text = "Image File"
        '
        'ucrTextBoxNewImageFile
        '
        Me.ucrTextBoxNewImageFile.Location = New System.Drawing.Point(132, 362)
        Me.ucrTextBoxNewImageFile.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrTextBoxNewImageFile.Name = "ucrTextBoxNewImageFile"
        Me.ucrTextBoxNewImageFile.Size = New System.Drawing.Size(301, 20)
        Me.ucrTextBoxNewImageFile.TabIndex = 25
        Me.ucrTextBoxNewImageFile.TextboxValue = ""
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Location = New System.Drawing.Point(441, 358)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(47, 29)
        Me.btnOpenFile.TabIndex = 26
        Me.btnOpenFile.Text = "Open"
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'grpCommand2
        '
        Me.grpCommand2.Controls.Add(Me.ucrBtnView)
        Me.grpCommand2.Controls.Add(Me.ucrBtnClear)
        Me.grpCommand2.Controls.Add(Me.ucrBtnDelete)
        Me.grpCommand2.Controls.Add(Me.ucrBtnUpdate)
        Me.grpCommand2.Controls.Add(Me.ucrBtnSave)
        Me.grpCommand2.Controls.Add(Me.ucrBtnAddNew)
        Me.grpCommand2.Location = New System.Drawing.Point(3, 404)
        Me.grpCommand2.Name = "grpCommand2"
        Me.grpCommand2.Size = New System.Drawing.Size(670, 31)
        Me.grpCommand2.TabIndex = 28
        Me.grpCommand2.TabStop = False
        '
        'ucrNavigatorInstrument
        '
        Me.ucrNavigatorInstrument.Location = New System.Drawing.Point(170, 444)
        Me.ucrNavigatorInstrument.Name = "ucrNavigatorInstrument"
        Me.ucrNavigatorInstrument.Size = New System.Drawing.Size(336, 25)
        Me.ucrNavigatorInstrument.TabIndex = 29
        '
        'pbInstrument
        '
        Me.pbInstrument.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbInstrument.Location = New System.Drawing.Point(370, 46)
        Me.pbInstrument.Name = "pbInstrument"
        Me.pbInstrument.Size = New System.Drawing.Size(288, 291)
        Me.pbInstrument.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbInstrument.TabIndex = 91
        Me.pbInstrument.TabStop = False
        '
        'lblInstrumentPic
        '
        Me.lblInstrumentPic.AutoSize = True
        Me.lblInstrumentPic.Location = New System.Drawing.Point(487, 336)
        Me.lblInstrumentPic.Name = "lblInstrumentPic"
        Me.lblInstrumentPic.Size = New System.Drawing.Size(92, 13)
        Me.lblInstrumentPic.TabIndex = 92
        Me.lblInstrumentPic.Text = "Instrument Picture"
        '
        'lblInstruments
        '
        Me.lblInstruments.AutoSize = True
        Me.lblInstruments.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstruments.Location = New System.Drawing.Point(301, 11)
        Me.lblInstruments.Name = "lblInstruments"
        Me.lblInstruments.Size = New System.Drawing.Size(75, 15)
        Me.lblInstruments.TabIndex = 93
        Me.lblInstruments.Text = "Instrument"
        '
        'ucrSelectorInstrumentID
        '
        Me.ucrSelectorInstrumentID.Location = New System.Drawing.Point(132, 48)
        Me.ucrSelectorInstrumentID.Name = "ucrSelectorInstrumentID"
        Me.ucrSelectorInstrumentID.Size = New System.Drawing.Size(139, 21)
        Me.ucrSelectorInstrumentID.TabIndex = 94
        '
        'ucrStationSelectorID
        '
        Me.ucrStationSelectorID.Location = New System.Drawing.Point(130, 134)
        Me.ucrStationSelectorID.Name = "ucrStationSelectorID"
        Me.ucrStationSelectorID.Size = New System.Drawing.Size(141, 25)
        Me.ucrStationSelectorID.TabIndex = 95
        '
        'ucrBtnAddNew
        '
        Me.ucrBtnAddNew.ActionTypeId = 0
        Me.ucrBtnAddNew.ButtonText = "AddNew"
        Me.ucrBtnAddNew.FieldName = Nothing
        Me.ucrBtnAddNew.KeyControl = False
        Me.ucrBtnAddNew.Location = New System.Drawing.Point(29, 4)
        Me.ucrBtnAddNew.Name = "ucrBtnAddNew"
        Me.ucrBtnAddNew.Size = New System.Drawing.Size(75, 23)
        Me.ucrBtnAddNew.TabIndex = 32
        '
        'ucrBtnSave
        '
        Me.ucrBtnSave.ActionTypeId = 0
        Me.ucrBtnSave.ButtonText = "Save"
        Me.ucrBtnSave.FieldName = Nothing
        Me.ucrBtnSave.KeyControl = False
        Me.ucrBtnSave.Location = New System.Drawing.Point(139, 5)
        Me.ucrBtnSave.Name = "ucrBtnSave"
        Me.ucrBtnSave.Size = New System.Drawing.Size(75, 23)
        Me.ucrBtnSave.TabIndex = 33
        '
        'ucrBtnUpdate
        '
        Me.ucrBtnUpdate.ActionTypeId = 0
        Me.ucrBtnUpdate.ButtonText = "Update"
        Me.ucrBtnUpdate.FieldName = Nothing
        Me.ucrBtnUpdate.KeyControl = False
        Me.ucrBtnUpdate.Location = New System.Drawing.Point(249, 5)
        Me.ucrBtnUpdate.Name = "ucrBtnUpdate"
        Me.ucrBtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.ucrBtnUpdate.TabIndex = 34
        '
        'ucrBtnDelete
        '
        Me.ucrBtnDelete.ActionTypeId = 0
        Me.ucrBtnDelete.ButtonText = "Delete"
        Me.ucrBtnDelete.FieldName = Nothing
        Me.ucrBtnDelete.KeyControl = False
        Me.ucrBtnDelete.Location = New System.Drawing.Point(359, 5)
        Me.ucrBtnDelete.Name = "ucrBtnDelete"
        Me.ucrBtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.ucrBtnDelete.TabIndex = 35
        '
        'ucrBtnClear
        '
        Me.ucrBtnClear.ActionTypeId = 0
        Me.ucrBtnClear.ButtonText = "Clear"
        Me.ucrBtnClear.FieldName = Nothing
        Me.ucrBtnClear.KeyControl = False
        Me.ucrBtnClear.Location = New System.Drawing.Point(469, 5)
        Me.ucrBtnClear.Name = "ucrBtnClear"
        Me.ucrBtnClear.Size = New System.Drawing.Size(75, 23)
        Me.ucrBtnClear.TabIndex = 36
        '
        'ucrBtnView
        '
        Me.ucrBtnView.ActionTypeId = 0
        Me.ucrBtnView.ButtonText = "View"
        Me.ucrBtnView.FieldName = Nothing
        Me.ucrBtnView.KeyControl = False
        Me.ucrBtnView.Location = New System.Drawing.Point(579, 6)
        Me.ucrBtnView.Name = "ucrBtnView"
        Me.ucrBtnView.Size = New System.Drawing.Size(75, 23)
        Me.ucrBtnView.TabIndex = 37
        '
        'ucrMetadataInstrumentNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrStationSelectorID)
        Me.Controls.Add(Me.ucrSelectorInstrumentID)
        Me.Controls.Add(Me.lblInstruments)
        Me.Controls.Add(Me.lblInstrumentPic)
        Me.Controls.Add(Me.pbInstrument)
        Me.Controls.Add(Me.ucrNavigatorInstrument)
        Me.Controls.Add(Me.grpCommand2)
        Me.Controls.Add(Me.btnOpenFile)
        Me.Controls.Add(Me.ucrTextBoxNewImageFile)
        Me.Controls.Add(Me.lblImageFile)
        Me.Controls.Add(Me.ucrTextBoxNewHeight)
        Me.Controls.Add(Me.lblInstalledAt)
        Me.Controls.Add(Me.ucrDatePickerNewDeinstallationDate)
        Me.Controls.Add(Me.lblDeinstallationDate)
        Me.Controls.Add(Me.ucrDatePickerNewInstallationDate)
        Me.Controls.Add(Me.lblIinstallationDate)
        Me.Controls.Add(Me.ucrTextBoxNewUncertainity)
        Me.Controls.Add(Me.lblUncertainity)
        Me.Controls.Add(Me.ucrTextBoxNewManufacturer)
        Me.Controls.Add(Me.lblManufacturer)
        Me.Controls.Add(Me.ucrTextBoxNewModel)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.ucrTextBoxNewSerialNumber)
        Me.Controls.Add(Me.lblSerialNumber)
        Me.Controls.Add(Me.lbStationID)
        Me.Controls.Add(Me.ucrTextBoxNewAbbreviation)
        Me.Controls.Add(Me.lblInstrumentAbbreviation)
        Me.Controls.Add(Me.ucrTextBoxNewInstrumentName)
        Me.Controls.Add(Me.lblInstrumentName)
        Me.Controls.Add(Me.lblInstrumentID)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ucrMetadataInstrumentNew"
        Me.Size = New System.Drawing.Size(676, 478)
        Me.grpCommand2.ResumeLayout(False)
        CType(Me.pbInstrument, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblInstrumentID As Label
    Friend WithEvents lblInstrumentName As Label
    Friend WithEvents ucrTextBoxNewInstrumentName As ucrTextBoxNew
    Friend WithEvents lblInstrumentAbbreviation As Label
    Friend WithEvents ucrTextBoxNewAbbreviation As ucrTextBoxNew
    Friend WithEvents lbStationID As Label
    Friend WithEvents lblSerialNumber As Label
    Friend WithEvents ucrTextBoxNewSerialNumber As ucrTextBoxNew
    Friend WithEvents lblModel As Label
    Friend WithEvents ucrTextBoxNewModel As ucrTextBoxNew
    Friend WithEvents lblManufacturer As Label
    Friend WithEvents ucrTextBoxNewManufacturer As ucrTextBoxNew
    Friend WithEvents lblUncertainity As Label
    Friend WithEvents ucrTextBoxNewUncertainity As ucrTextBoxNew
    Friend WithEvents lblIinstallationDate As Label
    Friend WithEvents ucrDatePickerNewInstallationDate As ucrDatePickerNew
    Friend WithEvents lblDeinstallationDate As Label
    Friend WithEvents ucrDatePickerNewDeinstallationDate As ucrDatePickerNew
    Friend WithEvents lblInstalledAt As Label
    Friend WithEvents ucrTextBoxNewHeight As ucrTextBoxNew
    Friend WithEvents lblImageFile As Label
    Friend WithEvents ucrTextBoxNewImageFile As ucrTextBoxNew
    Friend WithEvents btnOpenFile As Button
    Friend WithEvents grpCommand2 As GroupBox
    Friend WithEvents ucrNavigatorInstrument As ucrNavigator
    Friend WithEvents pbInstrument As PictureBox
    Friend WithEvents lblInstrumentPic As Label
    Friend WithEvents lblInstruments As Label
    Friend WithEvents ucrSelectorInstrumentID As ucrInstrumentSelector
    Friend WithEvents ucrStationSelectorID As ucrStationSelectorNew
    Friend WithEvents ucrBtnAddNew As ucrButton
    Friend WithEvents ucrBtnSave As ucrButton
    Friend WithEvents ucrBtnUpdate As ucrButton
    Friend WithEvents ucrBtnDelete As ucrButton
    Friend WithEvents ucrBtnClear As ucrButton
    Friend WithEvents ucrBtnView As ucrButton
End Class
