<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrMetadataStationElementNew
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
        Me.lblstation = New System.Windows.Forms.Label()
        Me.lblElement = New System.Windows.Forms.Label()
        Me.lblInstrument = New System.Windows.Forms.Label()
        Me.lblInstumentType = New System.Windows.Forms.Label()
        Me.lblSchedule = New System.Windows.Forms.Label()
        Me.lblHeight = New System.Windows.Forms.Label()
        Me.lblBdate = New System.Windows.Forms.Label()
        Me.lblEdate = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnAddNew = New System.Windows.Forms.Button()
        Me.btnView = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.ucrNavigator = New ClimsoftVer4.ucrNavigator()
        Me.ucrStationSelectorStationID = New ClimsoftVer4.ucrStationSelectorNew()
        Me.ucrComboBoxInstrumentID = New ClimsoftVer4.ucrComboboxNew()
        Me.ucrTextBoxInstrumentType = New ClimsoftVer4.ucrTextBoxNew()
        Me.ucrComboBoxScheduleClass = New ClimsoftVer4.ucrComboboxNew()
        Me.ucrTextBoxHeight = New ClimsoftVer4.ucrTextBoxNew()
        Me.ucrDatePickerEndDate = New ClimsoftVer4.ucrDatePickerNew()
        Me.ucrDatePickerBeginDate = New ClimsoftVer4.ucrDatePicker()
        Me.lblStationElement = New System.Windows.Forms.Label()
        Me.ucrElementSelectorElementID = New ClimsoftVer4.ucrElementSelectorNew()
        Me.GroupBox7.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblstation
        '
        Me.lblstation.AutoSize = True
        Me.lblstation.Location = New System.Drawing.Point(148, 88)
        Me.lblstation.Name = "lblstation"
        Me.lblstation.Size = New System.Drawing.Size(54, 13)
        Me.lblstation.TabIndex = 2
        Me.lblstation.Text = "Station ID"
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.Location = New System.Drawing.Point(148, 120)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(59, 13)
        Me.lblElement.TabIndex = 4
        Me.lblElement.Text = "Element ID"
        '
        'lblInstrument
        '
        Me.lblInstrument.AutoSize = True
        Me.lblInstrument.Location = New System.Drawing.Point(148, 148)
        Me.lblInstrument.Name = "lblInstrument"
        Me.lblInstrument.Size = New System.Drawing.Size(70, 13)
        Me.lblInstrument.TabIndex = 6
        Me.lblInstrument.Text = "Instrument ID"
        '
        'lblInstumentType
        '
        Me.lblInstumentType.AutoSize = True
        Me.lblInstumentType.Location = New System.Drawing.Point(148, 178)
        Me.lblInstumentType.Name = "lblInstumentType"
        Me.lblInstumentType.Size = New System.Drawing.Size(83, 13)
        Me.lblInstumentType.TabIndex = 8
        Me.lblInstumentType.Text = "Instrument Type"
        '
        'lblSchedule
        '
        Me.lblSchedule.AutoSize = True
        Me.lblSchedule.Location = New System.Drawing.Point(148, 209)
        Me.lblSchedule.Name = "lblSchedule"
        Me.lblSchedule.Size = New System.Drawing.Size(80, 13)
        Me.lblSchedule.TabIndex = 11
        Me.lblSchedule.Text = "Schedule Class"
        '
        'lblHeight
        '
        Me.lblHeight.AutoSize = True
        Me.lblHeight.Location = New System.Drawing.Point(148, 240)
        Me.lblHeight.Name = "lblHeight"
        Me.lblHeight.Size = New System.Drawing.Size(38, 13)
        Me.lblHeight.TabIndex = 13
        Me.lblHeight.Text = "Height"
        '
        'lblBdate
        '
        Me.lblBdate.AutoSize = True
        Me.lblBdate.Location = New System.Drawing.Point(149, 269)
        Me.lblBdate.Name = "lblBdate"
        Me.lblBdate.Size = New System.Drawing.Size(60, 13)
        Me.lblBdate.TabIndex = 15
        Me.lblBdate.Text = "Begin Date"
        '
        'lblEdate
        '
        Me.lblEdate.AutoSize = True
        Me.lblEdate.Location = New System.Drawing.Point(148, 300)
        Me.lblEdate.Name = "lblEdate"
        Me.lblEdate.Size = New System.Drawing.Size(52, 13)
        Me.lblEdate.TabIndex = 17
        Me.lblEdate.Text = "End Date"
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.btnClear)
        Me.GroupBox7.Controls.Add(Me.btnAddNew)
        Me.GroupBox7.Controls.Add(Me.btnView)
        Me.GroupBox7.Controls.Add(Me.btnDelete)
        Me.GroupBox7.Controls.Add(Me.btnUpdate)
        Me.GroupBox7.Controls.Add(Me.btnSave)
        Me.GroupBox7.Location = New System.Drawing.Point(0, 363)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(643, 41)
        Me.GroupBox7.TabIndex = 19
        Me.GroupBox7.TabStop = False
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(443, 10)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnAddNew
        '
        Me.btnAddNew.Location = New System.Drawing.Point(19, 10)
        Me.btnAddNew.Name = "btnAddNew"
        Me.btnAddNew.Size = New System.Drawing.Size(75, 23)
        Me.btnAddNew.TabIndex = 0
        Me.btnAddNew.Text = "AddNew"
        Me.btnAddNew.UseVisualStyleBackColor = True
        '
        'btnView
        '
        Me.btnView.Location = New System.Drawing.Point(549, 10)
        Me.btnView.Name = "btnView"
        Me.btnView.Size = New System.Drawing.Size(75, 23)
        Me.btnView.TabIndex = 5
        Me.btnView.Text = "View"
        Me.btnView.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(337, 10)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 3
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(231, 10)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 2
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(125, 10)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 1
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'ucrNavigator
        '
        Me.ucrNavigator.Location = New System.Drawing.Point(138, 412)
        Me.ucrNavigator.Name = "ucrNavigator"
        Me.ucrNavigator.Size = New System.Drawing.Size(367, 25)
        Me.ucrNavigator.TabIndex = 20
        '
        'ucrStationSelectorStationID
        '
        Me.ucrStationSelectorStationID.Location = New System.Drawing.Point(242, 83)
        Me.ucrStationSelectorStationID.Name = "ucrStationSelectorStationID"
        Me.ucrStationSelectorStationID.Size = New System.Drawing.Size(178, 24)
        Me.ucrStationSelectorStationID.TabIndex = 21
        '
        'ucrComboBoxInstrumentID
        '
        Me.ucrComboBoxInstrumentID.Location = New System.Drawing.Point(242, 140)
        Me.ucrComboBoxInstrumentID.Name = "ucrComboBoxInstrumentID"
        Me.ucrComboBoxInstrumentID.Size = New System.Drawing.Size(178, 21)
        Me.ucrComboBoxInstrumentID.TabIndex = 22
        '
        'ucrTextBoxInstrumentType
        '
        Me.ucrTextBoxInstrumentType.Location = New System.Drawing.Point(243, 171)
        Me.ucrTextBoxInstrumentType.Name = "ucrTextBoxInstrumentType"
        Me.ucrTextBoxInstrumentType.Size = New System.Drawing.Size(51, 20)
        Me.ucrTextBoxInstrumentType.TabIndex = 23
        Me.ucrTextBoxInstrumentType.TextboxValue = ""
        '
        'ucrComboBoxScheduleClass
        '
        Me.ucrComboBoxScheduleClass.Location = New System.Drawing.Point(242, 201)
        Me.ucrComboBoxScheduleClass.Name = "ucrComboBoxScheduleClass"
        Me.ucrComboBoxScheduleClass.Size = New System.Drawing.Size(178, 21)
        Me.ucrComboBoxScheduleClass.TabIndex = 24
        '
        'ucrTextBoxHeight
        '
        Me.ucrTextBoxHeight.Location = New System.Drawing.Point(242, 233)
        Me.ucrTextBoxHeight.Name = "ucrTextBoxHeight"
        Me.ucrTextBoxHeight.Size = New System.Drawing.Size(51, 20)
        Me.ucrTextBoxHeight.TabIndex = 25
        Me.ucrTextBoxHeight.TextboxValue = ""
        '
        'ucrDatePickerEndDate
        '
        Me.ucrDatePickerEndDate.Location = New System.Drawing.Point(242, 292)
        Me.ucrDatePickerEndDate.Name = "ucrDatePickerEndDate"
        Me.ucrDatePickerEndDate.Size = New System.Drawing.Size(178, 21)
        Me.ucrDatePickerEndDate.TabIndex = 26
        '
        'ucrDatePickerBeginDate
        '
        Me.ucrDatePickerBeginDate.FieldName = Nothing
        Me.ucrDatePickerBeginDate.KeyControl = False
        Me.ucrDatePickerBeginDate.Location = New System.Drawing.Point(242, 261)
        Me.ucrDatePickerBeginDate.Name = "ucrDatePickerBeginDate"
        Me.ucrDatePickerBeginDate.Size = New System.Drawing.Size(178, 21)
        Me.ucrDatePickerBeginDate.TabIndex = 27
        '
        'lblStationElement
        '
        Me.lblStationElement.AutoSize = True
        Me.lblStationElement.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStationElement.Location = New System.Drawing.Point(295, 21)
        Me.lblStationElement.Name = "lblStationElement"
        Me.lblStationElement.Size = New System.Drawing.Size(109, 15)
        Me.lblStationElement.TabIndex = 28
        Me.lblStationElement.Text = "Station Element"
        '
        'ucrElementSelectorElementID
        '
        Me.ucrElementSelectorElementID.Location = New System.Drawing.Point(242, 112)
        Me.ucrElementSelectorElementID.Name = "ucrElementSelectorElementID"
        Me.ucrElementSelectorElementID.Size = New System.Drawing.Size(178, 21)
        Me.ucrElementSelectorElementID.TabIndex = 29
        '
        'ucrMetadataStationElementNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrElementSelectorElementID)
        Me.Controls.Add(Me.lblStationElement)
        Me.Controls.Add(Me.ucrDatePickerBeginDate)
        Me.Controls.Add(Me.ucrDatePickerEndDate)
        Me.Controls.Add(Me.ucrTextBoxHeight)
        Me.Controls.Add(Me.ucrComboBoxScheduleClass)
        Me.Controls.Add(Me.ucrTextBoxInstrumentType)
        Me.Controls.Add(Me.ucrComboBoxInstrumentID)
        Me.Controls.Add(Me.ucrStationSelectorStationID)
        Me.Controls.Add(Me.ucrNavigator)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.lblEdate)
        Me.Controls.Add(Me.lblBdate)
        Me.Controls.Add(Me.lblHeight)
        Me.Controls.Add(Me.lblSchedule)
        Me.Controls.Add(Me.lblInstumentType)
        Me.Controls.Add(Me.lblInstrument)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.lblstation)
        Me.Name = "ucrMetadataStationElementNew"
        Me.Size = New System.Drawing.Size(643, 442)
        Me.GroupBox7.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblstation As Label
    Friend WithEvents lblElement As Label
    Friend WithEvents lblInstrument As Label
    Friend WithEvents lblInstumentType As Label
    Friend WithEvents lblSchedule As Label
    Friend WithEvents lblHeight As Label
    Friend WithEvents lblBdate As Label
    Friend WithEvents lblEdate As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents btnClear As Button
    Friend WithEvents btnAddNew As Button
    Friend WithEvents btnView As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents ucrNavigator As ucrNavigator
    Friend WithEvents ucrStationSelectorStationID As ucrStationSelectorNew
    Friend WithEvents ucrComboBoxInstrumentID As ucrComboboxNew
    Friend WithEvents ucrTextBoxInstrumentType As ucrTextBoxNew
    Friend WithEvents ucrComboBoxScheduleClass As ucrComboboxNew
    Friend WithEvents ucrTextBoxHeight As ucrTextBoxNew
    Friend WithEvents ucrDatePickerEndDate As ucrDatePickerNew
    Friend WithEvents ucrDatePickerBeginDate As ucrDatePicker
    Friend WithEvents lblStationElement As Label
    Friend WithEvents ucrElementSelectorElementID As ucrElementSelectorNew
End Class
