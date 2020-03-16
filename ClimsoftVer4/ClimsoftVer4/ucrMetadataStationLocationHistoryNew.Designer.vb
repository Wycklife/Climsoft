<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucrMetadataStationLocationHistoryNew
    Inherits ClimsoftVer4.ucrPage

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
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.lblStationType = New System.Windows.Forms.Label()
        Me.lblGeoLocationMethod = New System.Windows.Forms.Label()
        Me.lblGeoLocationAccuracy = New System.Windows.Forms.Label()
        Me.lblOpeningDate = New System.Windows.Forms.Label()
        Me.lblClosingDate = New System.Windows.Forms.Label()
        Me.lblLatitude = New System.Windows.Forms.Label()
        Me.lblLongitude = New System.Windows.Forms.Label()
        Me.lblElevation = New System.Windows.Forms.Label()
        Me.lblAuthority = New System.Windows.Forms.Label()
        Me.AdministrationRegionLabel = New System.Windows.Forms.Label()
        Me.DrainageBasinLabel = New System.Windows.Forms.Label()
        Me.grpCommandStationLocationHistory = New System.Windows.Forms.GroupBox()
        Me.ucrNavigator = New ClimsoftVer4.ucrNavigator()
        Me.ucrDatePickerOpeningDate = New ClimsoftVer4.ucrDatePickerNew()
        Me.ucrDatePickerClosingDate = New ClimsoftVer4.ucrDatePickerNew()
        Me.ucrStationSelectorStation = New ClimsoftVer4.ucrStationSelectorNew()
        Me.ucrTextBoxStationType = New ClimsoftVer4.ucrTextBoxNew()
        Me.ucrTextBoxLongitude = New ClimsoftVer4.ucrTextBoxNew()
        Me.ucrTextBoxAdministrationRegion = New ClimsoftVer4.ucrTextBoxNew()
        Me.ucrTextBoxLatitude = New ClimsoftVer4.ucrTextBoxNew()
        Me.ucrTextBoxGeoLocationAccuracy = New ClimsoftVer4.ucrTextBoxNew()
        Me.ucrTextBoxGeoLocationMethod = New ClimsoftVer4.ucrTextBoxNew()
        Me.ucrTextBoxElevation = New ClimsoftVer4.ucrTextBoxNew()
        Me.ucrTextBoxAuthority = New ClimsoftVer4.ucrTextBoxNew()
        Me.ucrTextBoxDrainageBasin = New ClimsoftVer4.ucrTextBoxNew()
        Me.ucrBtnView = New ClimsoftVer4.ucrButton()
        Me.ucrBtnDelete = New ClimsoftVer4.ucrButton()
        Me.ucrBtnUpdate = New ClimsoftVer4.ucrButton()
        Me.ucrBtnAddNew = New ClimsoftVer4.ucrButton()
        Me.ucrBtnSave = New ClimsoftVer4.ucrButton()
        Me.ucrBtnClear = New ClimsoftVer4.ucrButton()
        Me.grpCommandStationLocationHistory.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(227, 9)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(159, 15)
        Me.Label19.TabIndex = 1
        Me.Label19.Text = "Station Location History"
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(143, 53)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(40, 13)
        Me.lblStation.TabIndex = 2
        Me.lblStation.Text = "Station"
        '
        'lblStationType
        '
        Me.lblStationType.AutoSize = True
        Me.lblStationType.Location = New System.Drawing.Point(143, 80)
        Me.lblStationType.Name = "lblStationType"
        Me.lblStationType.Size = New System.Drawing.Size(67, 13)
        Me.lblStationType.TabIndex = 4
        Me.lblStationType.Text = "Station Type"
        '
        'lblGeoLocationMethod
        '
        Me.lblGeoLocationMethod.AutoSize = True
        Me.lblGeoLocationMethod.Location = New System.Drawing.Point(143, 107)
        Me.lblGeoLocationMethod.Name = "lblGeoLocationMethod"
        Me.lblGeoLocationMethod.Size = New System.Drawing.Size(107, 13)
        Me.lblGeoLocationMethod.TabIndex = 6
        Me.lblGeoLocationMethod.Text = "GeoLocation Method"
        '
        'lblGeoLocationAccuracy
        '
        Me.lblGeoLocationAccuracy.AutoSize = True
        Me.lblGeoLocationAccuracy.Location = New System.Drawing.Point(143, 134)
        Me.lblGeoLocationAccuracy.Name = "lblGeoLocationAccuracy"
        Me.lblGeoLocationAccuracy.Size = New System.Drawing.Size(116, 13)
        Me.lblGeoLocationAccuracy.TabIndex = 8
        Me.lblGeoLocationAccuracy.Text = "GeoLocation Accuracy"
        '
        'lblOpeningDate
        '
        Me.lblOpeningDate.AutoSize = True
        Me.lblOpeningDate.Location = New System.Drawing.Point(143, 161)
        Me.lblOpeningDate.Name = "lblOpeningDate"
        Me.lblOpeningDate.Size = New System.Drawing.Size(73, 13)
        Me.lblOpeningDate.TabIndex = 10
        Me.lblOpeningDate.Text = "Opening Date"
        '
        'lblClosingDate
        '
        Me.lblClosingDate.AutoSize = True
        Me.lblClosingDate.Location = New System.Drawing.Point(143, 188)
        Me.lblClosingDate.Name = "lblClosingDate"
        Me.lblClosingDate.Size = New System.Drawing.Size(67, 13)
        Me.lblClosingDate.TabIndex = 12
        Me.lblClosingDate.Text = "Closing Date"
        '
        'lblLatitude
        '
        Me.lblLatitude.AutoSize = True
        Me.lblLatitude.Location = New System.Drawing.Point(143, 215)
        Me.lblLatitude.Name = "lblLatitude"
        Me.lblLatitude.Size = New System.Drawing.Size(45, 13)
        Me.lblLatitude.TabIndex = 14
        Me.lblLatitude.Text = "Latitude"
        '
        'lblLongitude
        '
        Me.lblLongitude.AutoSize = True
        Me.lblLongitude.Location = New System.Drawing.Point(143, 242)
        Me.lblLongitude.Name = "lblLongitude"
        Me.lblLongitude.Size = New System.Drawing.Size(54, 13)
        Me.lblLongitude.TabIndex = 16
        Me.lblLongitude.Text = "Longitude"
        '
        'lblElevation
        '
        Me.lblElevation.AutoSize = True
        Me.lblElevation.Location = New System.Drawing.Point(143, 269)
        Me.lblElevation.Name = "lblElevation"
        Me.lblElevation.Size = New System.Drawing.Size(51, 13)
        Me.lblElevation.TabIndex = 18
        Me.lblElevation.Text = "Elevation"
        '
        'lblAuthority
        '
        Me.lblAuthority.AutoSize = True
        Me.lblAuthority.Location = New System.Drawing.Point(143, 296)
        Me.lblAuthority.Name = "lblAuthority"
        Me.lblAuthority.Size = New System.Drawing.Size(48, 13)
        Me.lblAuthority.TabIndex = 20
        Me.lblAuthority.Text = "Authority"
        '
        'AdministrationRegionLabel
        '
        Me.AdministrationRegionLabel.AutoSize = True
        Me.AdministrationRegionLabel.Location = New System.Drawing.Point(143, 328)
        Me.AdministrationRegionLabel.Name = "AdministrationRegionLabel"
        Me.AdministrationRegionLabel.Size = New System.Drawing.Size(109, 13)
        Me.AdministrationRegionLabel.TabIndex = 22
        Me.AdministrationRegionLabel.Text = "Administration Region"
        '
        'DrainageBasinLabel
        '
        Me.DrainageBasinLabel.AutoSize = True
        Me.DrainageBasinLabel.Location = New System.Drawing.Point(143, 357)
        Me.DrainageBasinLabel.Name = "DrainageBasinLabel"
        Me.DrainageBasinLabel.Size = New System.Drawing.Size(79, 13)
        Me.DrainageBasinLabel.TabIndex = 24
        Me.DrainageBasinLabel.Text = "Drainage Basin"
        '
        'grpCommandStationLocationHistory
        '
        Me.grpCommandStationLocationHistory.Controls.Add(Me.ucrBtnView)
        Me.grpCommandStationLocationHistory.Controls.Add(Me.ucrBtnDelete)
        Me.grpCommandStationLocationHistory.Controls.Add(Me.ucrBtnUpdate)
        Me.grpCommandStationLocationHistory.Controls.Add(Me.ucrBtnAddNew)
        Me.grpCommandStationLocationHistory.Controls.Add(Me.ucrBtnSave)
        Me.grpCommandStationLocationHistory.Controls.Add(Me.ucrBtnClear)
        Me.grpCommandStationLocationHistory.Location = New System.Drawing.Point(37, 391)
        Me.grpCommandStationLocationHistory.Name = "grpCommandStationLocationHistory"
        Me.grpCommandStationLocationHistory.Size = New System.Drawing.Size(601, 31)
        Me.grpCommandStationLocationHistory.TabIndex = 25
        Me.grpCommandStationLocationHistory.TabStop = False
        '
        'ucrNavigator
        '
        Me.ucrNavigator.Location = New System.Drawing.Point(146, 438)
        Me.ucrNavigator.Name = "ucrNavigator"
        Me.ucrNavigator.Size = New System.Drawing.Size(338, 28)
        Me.ucrNavigator.TabIndex = 26
        '
        'ucrDatePickerOpeningDate
        '
        Me.ucrDatePickerOpeningDate.Location = New System.Drawing.Point(275, 153)
        Me.ucrDatePickerOpeningDate.Name = "ucrDatePickerOpeningDate"
        Me.ucrDatePickerOpeningDate.Size = New System.Drawing.Size(129, 21)
        Me.ucrDatePickerOpeningDate.TabIndex = 27
        '
        'ucrDatePickerClosingDate
        '
        Me.ucrDatePickerClosingDate.Location = New System.Drawing.Point(275, 180)
        Me.ucrDatePickerClosingDate.Name = "ucrDatePickerClosingDate"
        Me.ucrDatePickerClosingDate.Size = New System.Drawing.Size(129, 21)
        Me.ucrDatePickerClosingDate.TabIndex = 28
        '
        'ucrStationSelectorStation
        '
        Me.ucrStationSelectorStation.Location = New System.Drawing.Point(275, 39)
        Me.ucrStationSelectorStation.Name = "ucrStationSelectorStation"
        Me.ucrStationSelectorStation.Size = New System.Drawing.Size(129, 27)
        Me.ucrStationSelectorStation.TabIndex = 29
        '
        'ucrTextBoxStationType
        '
        Me.ucrTextBoxStationType.Location = New System.Drawing.Point(275, 71)
        Me.ucrTextBoxStationType.Name = "ucrTextBoxStationType"
        Me.ucrTextBoxStationType.Size = New System.Drawing.Size(129, 20)
        Me.ucrTextBoxStationType.TabIndex = 30
        Me.ucrTextBoxStationType.TextboxValue = ""
        '
        'ucrTextBoxLongitude
        '
        Me.ucrTextBoxLongitude.Location = New System.Drawing.Point(276, 242)
        Me.ucrTextBoxLongitude.Name = "ucrTextBoxLongitude"
        Me.ucrTextBoxLongitude.Size = New System.Drawing.Size(128, 20)
        Me.ucrTextBoxLongitude.TabIndex = 31
        Me.ucrTextBoxLongitude.TextboxValue = ""
        '
        'ucrTextBoxAdministrationRegion
        '
        Me.ucrTextBoxAdministrationRegion.Location = New System.Drawing.Point(276, 321)
        Me.ucrTextBoxAdministrationRegion.Name = "ucrTextBoxAdministrationRegion"
        Me.ucrTextBoxAdministrationRegion.Size = New System.Drawing.Size(51, 20)
        Me.ucrTextBoxAdministrationRegion.TabIndex = 32
        Me.ucrTextBoxAdministrationRegion.TextboxValue = ""
        '
        'ucrTextBoxLatitude
        '
        Me.ucrTextBoxLatitude.Location = New System.Drawing.Point(275, 214)
        Me.ucrTextBoxLatitude.Name = "ucrTextBoxLatitude"
        Me.ucrTextBoxLatitude.Size = New System.Drawing.Size(129, 20)
        Me.ucrTextBoxLatitude.TabIndex = 33
        Me.ucrTextBoxLatitude.TextboxValue = ""
        '
        'ucrTextBoxGeoLocationAccuracy
        '
        Me.ucrTextBoxGeoLocationAccuracy.Location = New System.Drawing.Point(275, 127)
        Me.ucrTextBoxGeoLocationAccuracy.Name = "ucrTextBoxGeoLocationAccuracy"
        Me.ucrTextBoxGeoLocationAccuracy.Size = New System.Drawing.Size(129, 24)
        Me.ucrTextBoxGeoLocationAccuracy.TabIndex = 34
        Me.ucrTextBoxGeoLocationAccuracy.TextboxValue = ""
        '
        'ucrTextBoxGeoLocationMethod
        '
        Me.ucrTextBoxGeoLocationMethod.Location = New System.Drawing.Point(275, 99)
        Me.ucrTextBoxGeoLocationMethod.Name = "ucrTextBoxGeoLocationMethod"
        Me.ucrTextBoxGeoLocationMethod.Size = New System.Drawing.Size(129, 22)
        Me.ucrTextBoxGeoLocationMethod.TabIndex = 35
        Me.ucrTextBoxGeoLocationMethod.TextboxValue = ""
        '
        'ucrTextBoxElevation
        '
        Me.ucrTextBoxElevation.Location = New System.Drawing.Point(276, 267)
        Me.ucrTextBoxElevation.Name = "ucrTextBoxElevation"
        Me.ucrTextBoxElevation.Size = New System.Drawing.Size(50, 20)
        Me.ucrTextBoxElevation.TabIndex = 36
        Me.ucrTextBoxElevation.TextboxValue = ""
        '
        'ucrTextBoxAuthority
        '
        Me.ucrTextBoxAuthority.Location = New System.Drawing.Point(277, 293)
        Me.ucrTextBoxAuthority.Name = "ucrTextBoxAuthority"
        Me.ucrTextBoxAuthority.Size = New System.Drawing.Size(128, 20)
        Me.ucrTextBoxAuthority.TabIndex = 37
        Me.ucrTextBoxAuthority.TextboxValue = ""
        '
        'ucrTextBoxDrainageBasin
        '
        Me.ucrTextBoxDrainageBasin.Location = New System.Drawing.Point(276, 354)
        Me.ucrTextBoxDrainageBasin.Name = "ucrTextBoxDrainageBasin"
        Me.ucrTextBoxDrainageBasin.Size = New System.Drawing.Size(51, 20)
        Me.ucrTextBoxDrainageBasin.TabIndex = 38
        Me.ucrTextBoxDrainageBasin.TextboxValue = ""
        '
        'ucrBtnView
        '
        Me.ucrBtnView.ActionTypeId = 0
        Me.ucrBtnView.ButtonText = "View"
        Me.ucrBtnView.FieldName = Nothing
        Me.ucrBtnView.KeyControl = False
        Me.ucrBtnView.Location = New System.Drawing.Point(505, 5)
        Me.ucrBtnView.Name = "ucrBtnView"
        Me.ucrBtnView.Size = New System.Drawing.Size(75, 23)
        Me.ucrBtnView.TabIndex = 61
        '
        'ucrBtnDelete
        '
        Me.ucrBtnDelete.ActionTypeId = 0
        Me.ucrBtnDelete.ButtonText = "Delete"
        Me.ucrBtnDelete.FieldName = Nothing
        Me.ucrBtnDelete.KeyControl = False
        Me.ucrBtnDelete.Location = New System.Drawing.Point(311, 5)
        Me.ucrBtnDelete.Name = "ucrBtnDelete"
        Me.ucrBtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.ucrBtnDelete.TabIndex = 63
        '
        'ucrBtnUpdate
        '
        Me.ucrBtnUpdate.ActionTypeId = 0
        Me.ucrBtnUpdate.ButtonText = "Update"
        Me.ucrBtnUpdate.FieldName = Nothing
        Me.ucrBtnUpdate.KeyControl = False
        Me.ucrBtnUpdate.Location = New System.Drawing.Point(214, 5)
        Me.ucrBtnUpdate.Name = "ucrBtnUpdate"
        Me.ucrBtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.ucrBtnUpdate.TabIndex = 64
        '
        'ucrBtnAddNew
        '
        Me.ucrBtnAddNew.ActionTypeId = 0
        Me.ucrBtnAddNew.ButtonText = "AdddNew"
        Me.ucrBtnAddNew.FieldName = Nothing
        Me.ucrBtnAddNew.KeyControl = False
        Me.ucrBtnAddNew.Location = New System.Drawing.Point(20, 4)
        Me.ucrBtnAddNew.Name = "ucrBtnAddNew"
        Me.ucrBtnAddNew.Size = New System.Drawing.Size(75, 23)
        Me.ucrBtnAddNew.TabIndex = 59
        '
        'ucrBtnSave
        '
        Me.ucrBtnSave.ActionTypeId = 0
        Me.ucrBtnSave.ButtonText = "Save"
        Me.ucrBtnSave.FieldName = Nothing
        Me.ucrBtnSave.KeyControl = False
        Me.ucrBtnSave.Location = New System.Drawing.Point(117, 5)
        Me.ucrBtnSave.Name = "ucrBtnSave"
        Me.ucrBtnSave.Size = New System.Drawing.Size(75, 23)
        Me.ucrBtnSave.TabIndex = 60
        '
        'ucrBtnClear
        '
        Me.ucrBtnClear.ActionTypeId = 0
        Me.ucrBtnClear.ButtonText = "Clear"
        Me.ucrBtnClear.FieldName = Nothing
        Me.ucrBtnClear.KeyControl = False
        Me.ucrBtnClear.Location = New System.Drawing.Point(408, 6)
        Me.ucrBtnClear.Name = "ucrBtnClear"
        Me.ucrBtnClear.Size = New System.Drawing.Size(75, 23)
        Me.ucrBtnClear.TabIndex = 62
        '
        'ucrMetadataStationLocationHistoryNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrTextBoxDrainageBasin)
        Me.Controls.Add(Me.ucrTextBoxAuthority)
        Me.Controls.Add(Me.ucrTextBoxElevation)
        Me.Controls.Add(Me.ucrTextBoxGeoLocationMethod)
        Me.Controls.Add(Me.ucrTextBoxGeoLocationAccuracy)
        Me.Controls.Add(Me.ucrTextBoxLatitude)
        Me.Controls.Add(Me.ucrTextBoxAdministrationRegion)
        Me.Controls.Add(Me.ucrTextBoxLongitude)
        Me.Controls.Add(Me.ucrTextBoxStationType)
        Me.Controls.Add(Me.ucrStationSelectorStation)
        Me.Controls.Add(Me.ucrDatePickerClosingDate)
        Me.Controls.Add(Me.ucrDatePickerOpeningDate)
        Me.Controls.Add(Me.ucrNavigator)
        Me.Controls.Add(Me.grpCommandStationLocationHistory)
        Me.Controls.Add(Me.DrainageBasinLabel)
        Me.Controls.Add(Me.AdministrationRegionLabel)
        Me.Controls.Add(Me.lblAuthority)
        Me.Controls.Add(Me.lblElevation)
        Me.Controls.Add(Me.lblLongitude)
        Me.Controls.Add(Me.lblLatitude)
        Me.Controls.Add(Me.lblClosingDate)
        Me.Controls.Add(Me.lblOpeningDate)
        Me.Controls.Add(Me.lblGeoLocationAccuracy)
        Me.Controls.Add(Me.lblGeoLocationMethod)
        Me.Controls.Add(Me.lblStationType)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(Me.Label19)
        Me.Name = "ucrMetadataStationLocationHistoryNew"
        Me.Size = New System.Drawing.Size(674, 479)
        Me.grpCommandStationLocationHistory.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label19 As Label
    Friend WithEvents lblStation As Label
    Friend WithEvents lblStationType As Label
    Friend WithEvents lblGeoLocationMethod As Label
    Friend WithEvents lblGeoLocationAccuracy As Label
    Friend WithEvents lblOpeningDate As Label
    Friend WithEvents lblClosingDate As Label
    Friend WithEvents lblLatitude As Label
    Friend WithEvents lblLongitude As Label
    Friend WithEvents lblElevation As Label
    Friend WithEvents lblAuthority As Label
    Friend WithEvents AdministrationRegionLabel As Label
    Friend WithEvents DrainageBasinLabel As Label
    Friend WithEvents grpCommandStationLocationHistory As GroupBox
    Friend WithEvents ucrNavigator As ucrNavigator
    Friend WithEvents ucrDatePickerOpeningDate As ucrDatePickerNew
    Friend WithEvents ucrDatePickerClosingDate As ucrDatePickerNew
    Friend WithEvents ucrStationSelectorStation As ucrStationSelectorNew
    Friend WithEvents ucrTextBoxStationType As ucrTextBoxNew
    Friend WithEvents ucrTextBoxLongitude As ucrTextBoxNew
    Friend WithEvents ucrTextBoxAdministrationRegion As ucrTextBoxNew
    Friend WithEvents ucrTextBoxLatitude As ucrTextBoxNew
    Friend WithEvents ucrTextBoxGeoLocationAccuracy As ucrTextBoxNew
    Friend WithEvents ucrTextBoxGeoLocationMethod As ucrTextBoxNew
    Friend WithEvents ucrTextBoxElevation As ucrTextBoxNew
    Friend WithEvents ucrTextBoxAuthority As ucrTextBoxNew
    Friend WithEvents ucrTextBoxDrainageBasin As ucrTextBoxNew
    Friend WithEvents ucrBtnView As ucrButton
    Friend WithEvents ucrBtnDelete As ucrButton
    Friend WithEvents ucrBtnUpdate As ucrButton
    Friend WithEvents ucrBtnAddNew As ucrButton
    Friend WithEvents ucrBtnSave As ucrButton
    Friend WithEvents ucrBtnClear As ucrButton
End Class
