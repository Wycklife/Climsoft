<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrMetadataStationQualifierNew
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
        Me.lblStationQualifier = New System.Windows.Forms.Label()
        Me.lblQualifier = New System.Windows.Forms.Label()
        Me.ucrTextBoxNewQualifier = New ClimsoftVer4.ucrTextBoxNew()
        Me.lblStationID = New System.Windows.Forms.Label()
        Me.UcrComboboxNew1 = New ClimsoftVer4.ucrComboboxNew()
        Me.lblBeginDate = New System.Windows.Forms.Label()
        Me.ucrDatePickerNewBeginDate = New ClimsoftVer4.ucrDatePickerNew()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.ucrDatePickerNewEndDate = New ClimsoftVer4.ucrDatePickerNew()
        Me.lblTimeZone = New System.Windows.Forms.Label()
        Me.ucrTextBoxNewTimeZone = New ClimsoftVer4.ucrTextBoxNew()
        Me.lblNetworkType = New System.Windows.Forms.Label()
        Me.ucrTextBoxNewNetworkType = New ClimsoftVer4.ucrTextBoxNew()
        Me.grpCommand2 = New System.Windows.Forms.GroupBox()
        Me.UcrNavigator1 = New ClimsoftVer4.ucrNavigator()
        Me.ucrBtnView = New ClimsoftVer4.ucrButton()
        Me.ucrBtnDelete = New ClimsoftVer4.ucrButton()
        Me.ucrBtnUpdate = New ClimsoftVer4.ucrButton()
        Me.ucrBtnAddNew = New ClimsoftVer4.ucrButton()
        Me.ucrBtnSave = New ClimsoftVer4.ucrButton()
        Me.ucrBtnClear = New ClimsoftVer4.ucrButton()
        Me.grpCommand2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblStationQualifier
        '
        Me.lblStationQualifier.AutoSize = True
        Me.lblStationQualifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStationQualifier.Location = New System.Drawing.Point(281, 30)
        Me.lblStationQualifier.Name = "lblStationQualifier"
        Me.lblStationQualifier.Size = New System.Drawing.Size(118, 16)
        Me.lblStationQualifier.TabIndex = 1
        Me.lblStationQualifier.Text = "Station Qualifier"
        '
        'lblQualifier
        '
        Me.lblQualifier.AutoSize = True
        Me.lblQualifier.Location = New System.Drawing.Point(224, 89)
        Me.lblQualifier.Name = "lblQualifier"
        Me.lblQualifier.Size = New System.Drawing.Size(45, 13)
        Me.lblQualifier.TabIndex = 2
        Me.lblQualifier.Text = "Qualifier"
        '
        'ucrTextBoxNewQualifier
        '
        Me.ucrTextBoxNewQualifier.Location = New System.Drawing.Point(301, 89)
        Me.ucrTextBoxNewQualifier.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucrTextBoxNewQualifier.Name = "ucrTextBoxNewQualifier"
        Me.ucrTextBoxNewQualifier.Size = New System.Drawing.Size(154, 20)
        Me.ucrTextBoxNewQualifier.TabIndex = 3
        Me.ucrTextBoxNewQualifier.TextboxValue = ""
        '
        'lblStationID
        '
        Me.lblStationID.AutoSize = True
        Me.lblStationID.Location = New System.Drawing.Point(224, 126)
        Me.lblStationID.Name = "lblStationID"
        Me.lblStationID.Size = New System.Drawing.Size(54, 13)
        Me.lblStationID.TabIndex = 4
        Me.lblStationID.Text = "Station ID"
        '
        'UcrComboboxNew1
        '
        Me.UcrComboboxNew1.Location = New System.Drawing.Point(301, 126)
        Me.UcrComboboxNew1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.UcrComboboxNew1.Name = "UcrComboboxNew1"
        Me.UcrComboboxNew1.Size = New System.Drawing.Size(155, 24)
        Me.UcrComboboxNew1.TabIndex = 5
        '
        'lblBeginDate
        '
        Me.lblBeginDate.AutoSize = True
        Me.lblBeginDate.Location = New System.Drawing.Point(224, 164)
        Me.lblBeginDate.Name = "lblBeginDate"
        Me.lblBeginDate.Size = New System.Drawing.Size(60, 13)
        Me.lblBeginDate.TabIndex = 6
        Me.lblBeginDate.Text = "Begin Date"
        '
        'ucrDatePickerNewBeginDate
        '
        Me.ucrDatePickerNewBeginDate.Location = New System.Drawing.Point(301, 160)
        Me.ucrDatePickerNewBeginDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucrDatePickerNewBeginDate.Name = "ucrDatePickerNewBeginDate"
        Me.ucrDatePickerNewBeginDate.Size = New System.Drawing.Size(155, 21)
        Me.ucrDatePickerNewBeginDate.TabIndex = 7
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.Location = New System.Drawing.Point(224, 201)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(52, 13)
        Me.lblEndDate.TabIndex = 8
        Me.lblEndDate.Text = "End Date"
        '
        'ucrDatePickerNewEndDate
        '
        Me.ucrDatePickerNewEndDate.Location = New System.Drawing.Point(301, 196)
        Me.ucrDatePickerNewEndDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucrDatePickerNewEndDate.Name = "ucrDatePickerNewEndDate"
        Me.ucrDatePickerNewEndDate.Size = New System.Drawing.Size(155, 21)
        Me.ucrDatePickerNewEndDate.TabIndex = 9
        '
        'lblTimeZone
        '
        Me.lblTimeZone.AutoSize = True
        Me.lblTimeZone.Location = New System.Drawing.Point(224, 238)
        Me.lblTimeZone.Name = "lblTimeZone"
        Me.lblTimeZone.Size = New System.Drawing.Size(58, 13)
        Me.lblTimeZone.TabIndex = 10
        Me.lblTimeZone.Text = "Time Zone"
        '
        'ucrTextBoxNewTimeZone
        '
        Me.ucrTextBoxNewTimeZone.Location = New System.Drawing.Point(301, 237)
        Me.ucrTextBoxNewTimeZone.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucrTextBoxNewTimeZone.Name = "ucrTextBoxNewTimeZone"
        Me.ucrTextBoxNewTimeZone.Size = New System.Drawing.Size(154, 20)
        Me.ucrTextBoxNewTimeZone.TabIndex = 11
        Me.ucrTextBoxNewTimeZone.TextboxValue = ""
        '
        'lblNetworkType
        '
        Me.lblNetworkType.AutoSize = True
        Me.lblNetworkType.Location = New System.Drawing.Point(224, 275)
        Me.lblNetworkType.Name = "lblNetworkType"
        Me.lblNetworkType.Size = New System.Drawing.Size(74, 13)
        Me.lblNetworkType.TabIndex = 12
        Me.lblNetworkType.Text = "Network Type"
        '
        'ucrTextBoxNewNetworkType
        '
        Me.ucrTextBoxNewNetworkType.Location = New System.Drawing.Point(301, 274)
        Me.ucrTextBoxNewNetworkType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ucrTextBoxNewNetworkType.Name = "ucrTextBoxNewNetworkType"
        Me.ucrTextBoxNewNetworkType.Size = New System.Drawing.Size(154, 20)
        Me.ucrTextBoxNewNetworkType.TabIndex = 13
        Me.ucrTextBoxNewNetworkType.TextboxValue = ""
        '
        'grpCommand2
        '
        Me.grpCommand2.Controls.Add(Me.ucrBtnView)
        Me.grpCommand2.Controls.Add(Me.ucrBtnDelete)
        Me.grpCommand2.Controls.Add(Me.ucrBtnUpdate)
        Me.grpCommand2.Controls.Add(Me.ucrBtnAddNew)
        Me.grpCommand2.Controls.Add(Me.ucrBtnSave)
        Me.grpCommand2.Controls.Add(Me.ucrBtnClear)
        Me.grpCommand2.Location = New System.Drawing.Point(3, 335)
        Me.grpCommand2.Name = "grpCommand2"
        Me.grpCommand2.Size = New System.Drawing.Size(670, 31)
        Me.grpCommand2.TabIndex = 14
        Me.grpCommand2.TabStop = False
        '
        'UcrNavigator1
        '
        Me.UcrNavigator1.Location = New System.Drawing.Point(172, 375)
        Me.UcrNavigator1.Name = "UcrNavigator1"
        Me.UcrNavigator1.Size = New System.Drawing.Size(336, 25)
        Me.UcrNavigator1.TabIndex = 15
        '
        'ucrBtnView
        '
        Me.ucrBtnView.ActionTypeId = 0
        Me.ucrBtnView.ButtonText = "View"
        Me.ucrBtnView.FieldName = Nothing
        Me.ucrBtnView.KeyControl = False
        Me.ucrBtnView.Location = New System.Drawing.Point(578, 5)
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
        Me.ucrBtnDelete.Location = New System.Drawing.Point(354, 5)
        Me.ucrBtnDelete.Name = "ucrBtnDelete"
        Me.ucrBtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.ucrBtnDelete.TabIndex = 64
        '
        'ucrBtnUpdate
        '
        Me.ucrBtnUpdate.ActionTypeId = 0
        Me.ucrBtnUpdate.ButtonText = "Update"
        Me.ucrBtnUpdate.FieldName = Nothing
        Me.ucrBtnUpdate.KeyControl = False
        Me.ucrBtnUpdate.Location = New System.Drawing.Point(242, 5)
        Me.ucrBtnUpdate.Name = "ucrBtnUpdate"
        Me.ucrBtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.ucrBtnUpdate.TabIndex = 65
        '
        'ucrBtnAddNew
        '
        Me.ucrBtnAddNew.ActionTypeId = 0
        Me.ucrBtnAddNew.ButtonText = "AdddNew"
        Me.ucrBtnAddNew.FieldName = Nothing
        Me.ucrBtnAddNew.KeyControl = False
        Me.ucrBtnAddNew.Location = New System.Drawing.Point(18, 4)
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
        Me.ucrBtnSave.Location = New System.Drawing.Point(130, 5)
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
        Me.ucrBtnClear.Location = New System.Drawing.Point(466, 6)
        Me.ucrBtnClear.Name = "ucrBtnClear"
        Me.ucrBtnClear.Size = New System.Drawing.Size(75, 23)
        Me.ucrBtnClear.TabIndex = 62
        '
        'ucrMetadataStationQualifierNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.UcrNavigator1)
        Me.Controls.Add(Me.grpCommand2)
        Me.Controls.Add(Me.ucrTextBoxNewNetworkType)
        Me.Controls.Add(Me.lblNetworkType)
        Me.Controls.Add(Me.ucrTextBoxNewTimeZone)
        Me.Controls.Add(Me.lblTimeZone)
        Me.Controls.Add(Me.ucrDatePickerNewEndDate)
        Me.Controls.Add(Me.lblEndDate)
        Me.Controls.Add(Me.ucrDatePickerNewBeginDate)
        Me.Controls.Add(Me.lblBeginDate)
        Me.Controls.Add(Me.UcrComboboxNew1)
        Me.Controls.Add(Me.lblStationID)
        Me.Controls.Add(Me.ucrTextBoxNewQualifier)
        Me.Controls.Add(Me.lblQualifier)
        Me.Controls.Add(Me.lblStationQualifier)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "ucrMetadataStationQualifierNew"
        Me.Size = New System.Drawing.Size(680, 402)
        Me.grpCommand2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStationQualifier As Label
    Friend WithEvents lblQualifier As Label
    Friend WithEvents ucrTextBoxNewQualifier As ucrTextBoxNew
    Friend WithEvents lblStationID As Label
    Friend WithEvents UcrComboboxNew1 As ucrComboboxNew
    Friend WithEvents lblBeginDate As Label
    Friend WithEvents ucrDatePickerNewBeginDate As ucrDatePickerNew
    Friend WithEvents lblEndDate As Label
    Friend WithEvents ucrDatePickerNewEndDate As ucrDatePickerNew
    Friend WithEvents lblTimeZone As Label
    Friend WithEvents ucrTextBoxNewTimeZone As ucrTextBoxNew
    Friend WithEvents lblNetworkType As Label
    Friend WithEvents ucrTextBoxNewNetworkType As ucrTextBoxNew
    Friend WithEvents grpCommand2 As GroupBox
    Friend WithEvents UcrNavigator1 As ucrNavigator
    Friend WithEvents ucrBtnView As ucrButton
    Friend WithEvents ucrBtnDelete As ucrButton
    Friend WithEvents ucrBtnUpdate As ucrButton
    Friend WithEvents ucrBtnAddNew As ucrButton
    Friend WithEvents ucrBtnSave As ucrButton
    Friend WithEvents ucrBtnClear As ucrButton
End Class
