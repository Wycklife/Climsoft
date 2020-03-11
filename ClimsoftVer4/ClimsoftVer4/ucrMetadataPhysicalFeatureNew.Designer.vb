<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucrMetadataPhysicalFeatureNew
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
        Me.lblStationID = New System.Windows.Forms.Label()
        Me.lblBeginDate = New System.Windows.Forms.Label()
        Me.lblEndDate = New System.Windows.Forms.Label()
        Me.lblFeatureDescription = New System.Windows.Forms.Label()
        Me.lblFeatureClass = New System.Windows.Forms.Label()
        Me.lblFeatureImageFile = New System.Windows.Forms.Label()
        Me.grpPhysicalFeature = New System.Windows.Forms.GroupBox()
        Me.ucrBtnView = New ClimsoftVer4.ucrButton()
        Me.ucrBtnClear = New ClimsoftVer4.ucrButton()
        Me.ucrBtnDelete = New ClimsoftVer4.ucrButton()
        Me.ucrBtnUpdate = New ClimsoftVer4.ucrButton()
        Me.ucrBtnSave = New ClimsoftVer4.ucrButton()
        Me.ucrBtnAddNew = New ClimsoftVer4.ucrButton()
        Me.ucrNavigator = New ClimsoftVer4.ucrNavigator()
        Me.pbFeaturePicture = New System.Windows.Forms.PictureBox()
        Me.btnOpenFile = New System.Windows.Forms.Button()
        Me.ucrTextBoxFeatureDescription = New ClimsoftVer4.ucrTextBoxNew()
        Me.ucrTextBoxFeatureClass = New ClimsoftVer4.ucrTextBoxNew()
        Me.ucrTextBoxFeatureImageFile = New ClimsoftVer4.ucrTextBoxNew()
        Me.lblFeaturePicture = New System.Windows.Forms.Label()
        Me.ucrDatePickerBeginDate = New ClimsoftVer4.ucrDatePickerNew()
        Me.ucrDatePickerEndDate = New ClimsoftVer4.ucrDatePickerNew()
        Me.ucrStationSelectorStationID = New ClimsoftVer4.ucrStationSelectorNew()
        Me.lblPhysicalFeature = New System.Windows.Forms.Label()
        Me.grpPhysicalFeature.SuspendLayout()
        CType(Me.pbFeaturePicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblStationID
        '
        Me.lblStationID.AutoSize = True
        Me.lblStationID.Location = New System.Drawing.Point(40, 117)
        Me.lblStationID.Name = "lblStationID"
        Me.lblStationID.Size = New System.Drawing.Size(54, 13)
        Me.lblStationID.TabIndex = 2
        Me.lblStationID.Text = "Station ID"
        '
        'lblBeginDate
        '
        Me.lblBeginDate.AutoSize = True
        Me.lblBeginDate.Location = New System.Drawing.Point(39, 149)
        Me.lblBeginDate.Name = "lblBeginDate"
        Me.lblBeginDate.Size = New System.Drawing.Size(60, 13)
        Me.lblBeginDate.TabIndex = 4
        Me.lblBeginDate.Text = "Begin Date"
        '
        'lblEndDate
        '
        Me.lblEndDate.AutoSize = True
        Me.lblEndDate.Location = New System.Drawing.Point(39, 180)
        Me.lblEndDate.Name = "lblEndDate"
        Me.lblEndDate.Size = New System.Drawing.Size(52, 13)
        Me.lblEndDate.TabIndex = 6
        Me.lblEndDate.Text = "End Date"
        '
        'lblFeatureDescription
        '
        Me.lblFeatureDescription.AutoSize = True
        Me.lblFeatureDescription.Location = New System.Drawing.Point(39, 211)
        Me.lblFeatureDescription.Name = "lblFeatureDescription"
        Me.lblFeatureDescription.Size = New System.Drawing.Size(99, 13)
        Me.lblFeatureDescription.TabIndex = 8
        Me.lblFeatureDescription.Text = "Feature Description"
        '
        'lblFeatureClass
        '
        Me.lblFeatureClass.AutoSize = True
        Me.lblFeatureClass.Location = New System.Drawing.Point(41, 242)
        Me.lblFeatureClass.Name = "lblFeatureClass"
        Me.lblFeatureClass.Size = New System.Drawing.Size(71, 13)
        Me.lblFeatureClass.TabIndex = 10
        Me.lblFeatureClass.Text = "Feature Class"
        '
        'lblFeatureImageFile
        '
        Me.lblFeatureImageFile.AutoSize = True
        Me.lblFeatureImageFile.Location = New System.Drawing.Point(41, 304)
        Me.lblFeatureImageFile.Name = "lblFeatureImageFile"
        Me.lblFeatureImageFile.Size = New System.Drawing.Size(94, 13)
        Me.lblFeatureImageFile.TabIndex = 14
        Me.lblFeatureImageFile.Text = "Feature Image File"
        '
        'grpPhysicalFeature
        '
        Me.grpPhysicalFeature.Controls.Add(Me.ucrBtnView)
        Me.grpPhysicalFeature.Controls.Add(Me.ucrBtnClear)
        Me.grpPhysicalFeature.Controls.Add(Me.ucrBtnDelete)
        Me.grpPhysicalFeature.Controls.Add(Me.ucrBtnUpdate)
        Me.grpPhysicalFeature.Controls.Add(Me.ucrBtnSave)
        Me.grpPhysicalFeature.Controls.Add(Me.ucrBtnAddNew)
        Me.grpPhysicalFeature.Location = New System.Drawing.Point(3, 352)
        Me.grpPhysicalFeature.Name = "grpPhysicalFeature"
        Me.grpPhysicalFeature.Size = New System.Drawing.Size(611, 34)
        Me.grpPhysicalFeature.TabIndex = 18
        Me.grpPhysicalFeature.TabStop = False
        '
        'ucrBtnView
        '
        Me.ucrBtnView.ActionTypeId = 0
        Me.ucrBtnView.ButtonText = "View"
        Me.ucrBtnView.FieldName = Nothing
        Me.ucrBtnView.KeyControl = False
        Me.ucrBtnView.Location = New System.Drawing.Point(515, 7)
        Me.ucrBtnView.Name = "ucrBtnView"
        Me.ucrBtnView.Size = New System.Drawing.Size(75, 23)
        Me.ucrBtnView.TabIndex = 37
        '
        'ucrBtnClear
        '
        Me.ucrBtnClear.ActionTypeId = 0
        Me.ucrBtnClear.ButtonText = "Clear"
        Me.ucrBtnClear.FieldName = Nothing
        Me.ucrBtnClear.KeyControl = False
        Me.ucrBtnClear.Location = New System.Drawing.Point(416, 7)
        Me.ucrBtnClear.Name = "ucrBtnClear"
        Me.ucrBtnClear.Size = New System.Drawing.Size(75, 23)
        Me.ucrBtnClear.TabIndex = 36
        '
        'ucrBtnDelete
        '
        Me.ucrBtnDelete.ActionTypeId = 0
        Me.ucrBtnDelete.ButtonText = "Delete"
        Me.ucrBtnDelete.FieldName = Nothing
        Me.ucrBtnDelete.KeyControl = False
        Me.ucrBtnDelete.Location = New System.Drawing.Point(317, 7)
        Me.ucrBtnDelete.Name = "ucrBtnDelete"
        Me.ucrBtnDelete.Size = New System.Drawing.Size(75, 23)
        Me.ucrBtnDelete.TabIndex = 35
        '
        'ucrBtnUpdate
        '
        Me.ucrBtnUpdate.ActionTypeId = 0
        Me.ucrBtnUpdate.ButtonText = "Update"
        Me.ucrBtnUpdate.FieldName = Nothing
        Me.ucrBtnUpdate.KeyControl = False
        Me.ucrBtnUpdate.Location = New System.Drawing.Point(218, 7)
        Me.ucrBtnUpdate.Name = "ucrBtnUpdate"
        Me.ucrBtnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.ucrBtnUpdate.TabIndex = 34
        '
        'ucrBtnSave
        '
        Me.ucrBtnSave.ActionTypeId = 0
        Me.ucrBtnSave.ButtonText = "Save"
        Me.ucrBtnSave.FieldName = Nothing
        Me.ucrBtnSave.KeyControl = False
        Me.ucrBtnSave.Location = New System.Drawing.Point(119, 7)
        Me.ucrBtnSave.Name = "ucrBtnSave"
        Me.ucrBtnSave.Size = New System.Drawing.Size(75, 23)
        Me.ucrBtnSave.TabIndex = 33
        '
        'ucrBtnAddNew
        '
        Me.ucrBtnAddNew.ActionTypeId = 0
        Me.ucrBtnAddNew.ButtonText = "AddNew"
        Me.ucrBtnAddNew.FieldName = Nothing
        Me.ucrBtnAddNew.KeyControl = False
        Me.ucrBtnAddNew.Location = New System.Drawing.Point(20, 7)
        Me.ucrBtnAddNew.Name = "ucrBtnAddNew"
        Me.ucrBtnAddNew.Size = New System.Drawing.Size(75, 23)
        Me.ucrBtnAddNew.TabIndex = 32
        '
        'ucrNavigator
        '
        Me.ucrNavigator.Location = New System.Drawing.Point(163, 397)
        Me.ucrNavigator.Name = "ucrNavigator"
        Me.ucrNavigator.Size = New System.Drawing.Size(336, 25)
        Me.ucrNavigator.TabIndex = 19
        '
        'pbFeaturePicture
        '
        Me.pbFeaturePicture.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pbFeaturePicture.BackColor = System.Drawing.Color.Ivory
        Me.pbFeaturePicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.pbFeaturePicture.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pbFeaturePicture.ImageLocation = ""
        Me.pbFeaturePicture.InitialImage = Nothing
        Me.pbFeaturePicture.Location = New System.Drawing.Point(377, 93)
        Me.pbFeaturePicture.Name = "pbFeaturePicture"
        Me.pbFeaturePicture.Size = New System.Drawing.Size(258, 227)
        Me.pbFeaturePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbFeaturePicture.TabIndex = 81
        Me.pbFeaturePicture.TabStop = False
        '
        'btnOpenFile
        '
        Me.btnOpenFile.Location = New System.Drawing.Point(326, 295)
        Me.btnOpenFile.Name = "btnOpenFile"
        Me.btnOpenFile.Size = New System.Drawing.Size(49, 27)
        Me.btnOpenFile.TabIndex = 82
        Me.btnOpenFile.Text = "Open"
        Me.btnOpenFile.UseVisualStyleBackColor = True
        '
        'ucrTextBoxFeatureDescription
        '
        Me.ucrTextBoxFeatureDescription.Location = New System.Drawing.Point(141, 204)
        Me.ucrTextBoxFeatureDescription.Name = "ucrTextBoxFeatureDescription"
        Me.ucrTextBoxFeatureDescription.Size = New System.Drawing.Size(154, 20)
        Me.ucrTextBoxFeatureDescription.TabIndex = 83
        Me.ucrTextBoxFeatureDescription.TextboxValue = ""
        '
        'ucrTextBoxFeatureClass
        '
        Me.ucrTextBoxFeatureClass.Location = New System.Drawing.Point(141, 234)
        Me.ucrTextBoxFeatureClass.Name = "ucrTextBoxFeatureClass"
        Me.ucrTextBoxFeatureClass.Size = New System.Drawing.Size(154, 20)
        Me.ucrTextBoxFeatureClass.TabIndex = 84
        Me.ucrTextBoxFeatureClass.TextboxValue = ""
        '
        'ucrTextBoxFeatureImageFile
        '
        Me.ucrTextBoxFeatureImageFile.Location = New System.Drawing.Point(141, 300)
        Me.ucrTextBoxFeatureImageFile.Name = "ucrTextBoxFeatureImageFile"
        Me.ucrTextBoxFeatureImageFile.Size = New System.Drawing.Size(180, 20)
        Me.ucrTextBoxFeatureImageFile.TabIndex = 85
        Me.ucrTextBoxFeatureImageFile.TextboxValue = ""
        '
        'lblFeaturePicture
        '
        Me.lblFeaturePicture.AutoSize = True
        Me.lblFeaturePicture.Location = New System.Drawing.Point(471, 321)
        Me.lblFeaturePicture.Name = "lblFeaturePicture"
        Me.lblFeaturePicture.Size = New System.Drawing.Size(79, 13)
        Me.lblFeaturePicture.TabIndex = 88
        Me.lblFeaturePicture.Text = "Feature Picture"
        '
        'ucrDatePickerBeginDate
        '
        Me.ucrDatePickerBeginDate.Location = New System.Drawing.Point(140, 140)
        Me.ucrDatePickerBeginDate.Name = "ucrDatePickerBeginDate"
        Me.ucrDatePickerBeginDate.Size = New System.Drawing.Size(154, 21)
        Me.ucrDatePickerBeginDate.TabIndex = 89
        '
        'ucrDatePickerEndDate
        '
        Me.ucrDatePickerEndDate.Location = New System.Drawing.Point(140, 171)
        Me.ucrDatePickerEndDate.Name = "ucrDatePickerEndDate"
        Me.ucrDatePickerEndDate.Size = New System.Drawing.Size(154, 21)
        Me.ucrDatePickerEndDate.TabIndex = 90
        '
        'ucrStationSelectorStationID
        '
        Me.ucrStationSelectorStationID.Location = New System.Drawing.Point(141, 106)
        Me.ucrStationSelectorStationID.Name = "ucrStationSelectorStationID"
        Me.ucrStationSelectorStationID.Size = New System.Drawing.Size(154, 24)
        Me.ucrStationSelectorStationID.TabIndex = 91
        '
        'lblPhysicalFeature
        '
        Me.lblPhysicalFeature.AutoSize = True
        Me.lblPhysicalFeature.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhysicalFeature.Location = New System.Drawing.Point(269, 15)
        Me.lblPhysicalFeature.Name = "lblPhysicalFeature"
        Me.lblPhysicalFeature.Size = New System.Drawing.Size(124, 16)
        Me.lblPhysicalFeature.TabIndex = 92
        Me.lblPhysicalFeature.Text = "Physical Feature"
        '
        'ucrMetadataPhysicalFeatureNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.lblPhysicalFeature)
        Me.Controls.Add(Me.ucrStationSelectorStationID)
        Me.Controls.Add(Me.ucrDatePickerEndDate)
        Me.Controls.Add(Me.ucrDatePickerBeginDate)
        Me.Controls.Add(Me.lblFeaturePicture)
        Me.Controls.Add(Me.ucrTextBoxFeatureImageFile)
        Me.Controls.Add(Me.ucrTextBoxFeatureClass)
        Me.Controls.Add(Me.ucrTextBoxFeatureDescription)
        Me.Controls.Add(Me.btnOpenFile)
        Me.Controls.Add(Me.pbFeaturePicture)
        Me.Controls.Add(Me.ucrNavigator)
        Me.Controls.Add(Me.grpPhysicalFeature)
        Me.Controls.Add(Me.lblFeatureImageFile)
        Me.Controls.Add(Me.lblFeatureClass)
        Me.Controls.Add(Me.lblFeatureDescription)
        Me.Controls.Add(Me.lblEndDate)
        Me.Controls.Add(Me.lblBeginDate)
        Me.Controls.Add(Me.lblStationID)
        Me.Name = "ucrMetadataPhysicalFeatureNew"
        Me.Size = New System.Drawing.Size(662, 427)
        Me.grpPhysicalFeature.ResumeLayout(False)
        CType(Me.pbFeaturePicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblStationID As Label
    Friend WithEvents lblBeginDate As Label
    Friend WithEvents lblEndDate As Label
    Friend WithEvents lblFeatureDescription As Label
    Friend WithEvents lblFeatureClass As Label
    Friend WithEvents lblFeatureImageFile As Label
    Friend WithEvents grpPhysicalFeature As GroupBox
    Friend WithEvents ucrNavigator As ucrNavigator
    Friend WithEvents pbFeaturePicture As PictureBox
    Friend WithEvents btnOpenFile As Button
    Friend WithEvents ucrTextBoxFeatureDescription As ucrTextBoxNew
    Friend WithEvents ucrTextBoxFeatureClass As ucrTextBoxNew
    Friend WithEvents ucrTextBoxFeatureImageFile As ucrTextBoxNew
    Friend WithEvents lblFeaturePicture As Label
    Friend WithEvents ucrDatePickerBeginDate As ucrDatePickerNew
    Friend WithEvents ucrDatePickerEndDate As ucrDatePickerNew
    Friend WithEvents ucrStationSelectorStationID As ucrStationSelectorNew
    Friend WithEvents lblPhysicalFeature As Label
    Friend WithEvents ucrBtnAddNew As ucrButton
    Friend WithEvents ucrBtnSave As ucrButton
    Friend WithEvents ucrBtnUpdate As ucrButton
    Friend WithEvents ucrBtnDelete As ucrButton
    Friend WithEvents ucrBtnClear As ucrButton
    Friend WithEvents ucrBtnView As ucrButton
End Class
