<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrMonthlyDataNew
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
        Dim lblYear As System.Windows.Forms.Label
        Me.lblElement = New System.Windows.Forms.Label()
        Me.lblStation = New System.Windows.Forms.Label()
        Me.ucrStationSelector = New ClimsoftVer4.ucrStationSelectorNew()
        Me.ucrElementSelector = New ClimsoftVer4.ucrElementSelectorNew()
        Me.ucrYearSelector = New ClimsoftVer4.ucrYearSelectorNew()
        Me.lblPeriod = New System.Windows.Forms.Label()
        Me.lblFlag = New System.Windows.Forms.Label()
        Me.lblValue = New System.Windows.Forms.Label()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lbl12 = New System.Windows.Forms.Label()
        Me.lbl11 = New System.Windows.Forms.Label()
        Me.lbl10 = New System.Windows.Forms.Label()
        Me.lbl09 = New System.Windows.Forms.Label()
        Me.lbl08 = New System.Windows.Forms.Label()
        Me.lbl07 = New System.Windows.Forms.Label()
        Me.lbl06 = New System.Windows.Forms.Label()
        Me.lbl05 = New System.Windows.Forms.Label()
        Me.lbl04 = New System.Windows.Forms.Label()
        Me.lbl03 = New System.Windows.Forms.Label()
        Me.lbl02 = New System.Windows.Forms.Label()
        Me.lbl01 = New System.Windows.Forms.Label()
        Me.UcrNavigator1 = New ClimsoftVer4.ucrNavigator()
        Me.btnUpload = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSequencer = New System.Windows.Forms.TextBox()
        Me.UcrValueFlagPeriodNew1 = New ClimsoftVer4.ucrValueFlagPeriodNew()
        Me.UcrValueFlagPeriod1 = New ClimsoftVer4.ucrValueFlagPeriod()
        Me.UcrValueFlagPeriod2 = New ClimsoftVer4.ucrValueFlagPeriod()
        Me.UcrValueFlagPeriod3 = New ClimsoftVer4.ucrValueFlagPeriod()
        Me.UcrValueFlagPeriod4 = New ClimsoftVer4.ucrValueFlagPeriod()
        Me.UcrValueFlagPeriod5 = New ClimsoftVer4.ucrValueFlagPeriod()
        Me.UcrValueFlagPeriod6 = New ClimsoftVer4.ucrValueFlagPeriod()
        Me.UcrValueFlagPeriod7 = New ClimsoftVer4.ucrValueFlagPeriod()
        Me.UcrValueFlagPeriod8 = New ClimsoftVer4.ucrValueFlagPeriod()
        Me.UcrValueFlagPeriod9 = New ClimsoftVer4.ucrValueFlagPeriod()
        Me.UcrValueFlagPeriod10 = New ClimsoftVer4.ucrValueFlagPeriod()
        Me.UcrValueFlagPeriod11 = New ClimsoftVer4.ucrValueFlagPeriod()
        Me.ucrBtnAddNew = New ClimsoftVer4.ucrButton()
        Me.ucrBtnDelete = New ClimsoftVer4.ucrButton()
        Me.ucrBtnSave = New ClimsoftVer4.ucrButton()
        Me.ucrBtnUpdate = New ClimsoftVer4.ucrButton()
        Me.ucrBtnClear = New ClimsoftVer4.ucrButton()
        Me.ucrBtnCancel = New ClimsoftVer4.ucrButton()
        Me.ucrBtnClose = New ClimsoftVer4.ucrButton()
        Me.ucrBtnHelp = New ClimsoftVer4.ucrButton()
        Me.ucrBtnView = New ClimsoftVer4.ucrButton()
        lblYear = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblYear
        '
        lblYear.AutoSize = True
        lblYear.Location = New System.Drawing.Point(434, 13)
        lblYear.Name = "lblYear"
        lblYear.Size = New System.Drawing.Size(32, 13)
        lblYear.TabIndex = 592
        lblYear.Text = "Year:"
        '
        'lblElement
        '
        Me.lblElement.AutoSize = True
        Me.lblElement.Location = New System.Drawing.Point(231, 13)
        Me.lblElement.Name = "lblElement"
        Me.lblElement.Size = New System.Drawing.Size(48, 13)
        Me.lblElement.TabIndex = 594
        Me.lblElement.Text = "Element:"
        '
        'lblStation
        '
        Me.lblStation.AutoSize = True
        Me.lblStation.Location = New System.Drawing.Point(35, 13)
        Me.lblStation.Name = "lblStation"
        Me.lblStation.Size = New System.Drawing.Size(43, 13)
        Me.lblStation.TabIndex = 593
        Me.lblStation.Text = "Station:"
        '
        'ucrStationSelector
        '
        Me.ucrStationSelector.FieldName = Nothing
        Me.ucrStationSelector.Location = New System.Drawing.Point(32, 29)
        Me.ucrStationSelector.Name = "ucrStationSelector"
        Me.ucrStationSelector.Size = New System.Drawing.Size(187, 21)
        Me.ucrStationSelector.TabIndex = 595
        '
        'ucrElementSelector
        '
        Me.ucrElementSelector.FieldName = Nothing
        Me.ucrElementSelector.Location = New System.Drawing.Point(234, 29)
        Me.ucrElementSelector.Name = "ucrElementSelector"
        Me.ucrElementSelector.Size = New System.Drawing.Size(178, 21)
        Me.ucrElementSelector.TabIndex = 596
        '
        'ucrYearSelector
        '
        Me.ucrYearSelector.FieldName = Nothing
        Me.ucrYearSelector.Location = New System.Drawing.Point(437, 29)
        Me.ucrYearSelector.Name = "ucrYearSelector"
        Me.ucrYearSelector.Size = New System.Drawing.Size(85, 25)
        Me.ucrYearSelector.TabIndex = 597
        '
        'lblPeriod
        '
        Me.lblPeriod.AutoSize = True
        Me.lblPeriod.Location = New System.Drawing.Point(322, 76)
        Me.lblPeriod.Name = "lblPeriod"
        Me.lblPeriod.Size = New System.Drawing.Size(37, 13)
        Me.lblPeriod.TabIndex = 601
        Me.lblPeriod.Text = "Period"
        '
        'lblFlag
        '
        Me.lblFlag.AutoSize = True
        Me.lblFlag.Location = New System.Drawing.Point(285, 75)
        Me.lblFlag.Name = "lblFlag"
        Me.lblFlag.Size = New System.Drawing.Size(27, 13)
        Me.lblFlag.TabIndex = 600
        Me.lblFlag.Text = "Flag"
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Location = New System.Drawing.Point(233, 75)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(34, 13)
        Me.lblValue.TabIndex = 599
        Me.lblValue.Text = "Value"
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Location = New System.Drawing.Point(174, 74)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(37, 13)
        Me.lblMonth.TabIndex = 598
        Me.lblMonth.Text = "Month"
        '
        'lbl12
        '
        Me.lbl12.AutoSize = True
        Me.lbl12.Location = New System.Drawing.Point(166, 422)
        Me.lbl12.Name = "lbl12"
        Me.lbl12.Size = New System.Drawing.Size(56, 13)
        Me.lbl12.TabIndex = 613
        Me.lbl12.Text = "December"
        '
        'lbl11
        '
        Me.lbl11.AutoSize = True
        Me.lbl11.Location = New System.Drawing.Point(166, 392)
        Me.lbl11.Name = "lbl11"
        Me.lbl11.Size = New System.Drawing.Size(62, 13)
        Me.lbl11.TabIndex = 612
        Me.lbl11.Text = "Novemeber"
        '
        'lbl10
        '
        Me.lbl10.AutoSize = True
        Me.lbl10.Location = New System.Drawing.Point(166, 362)
        Me.lbl10.Name = "lbl10"
        Me.lbl10.Size = New System.Drawing.Size(45, 13)
        Me.lbl10.TabIndex = 611
        Me.lbl10.Text = "October"
        '
        'lbl09
        '
        Me.lbl09.AutoSize = True
        Me.lbl09.Location = New System.Drawing.Point(166, 331)
        Me.lbl09.Name = "lbl09"
        Me.lbl09.Size = New System.Drawing.Size(58, 13)
        Me.lbl09.TabIndex = 610
        Me.lbl09.Text = "September"
        '
        'lbl08
        '
        Me.lbl08.AutoSize = True
        Me.lbl08.Location = New System.Drawing.Point(166, 303)
        Me.lbl08.Name = "lbl08"
        Me.lbl08.Size = New System.Drawing.Size(40, 13)
        Me.lbl08.TabIndex = 609
        Me.lbl08.Text = "August"
        '
        'lbl07
        '
        Me.lbl07.AutoSize = True
        Me.lbl07.Location = New System.Drawing.Point(166, 275)
        Me.lbl07.Name = "lbl07"
        Me.lbl07.Size = New System.Drawing.Size(25, 13)
        Me.lbl07.TabIndex = 608
        Me.lbl07.Text = "July"
        '
        'lbl06
        '
        Me.lbl06.AutoSize = True
        Me.lbl06.Location = New System.Drawing.Point(166, 245)
        Me.lbl06.Name = "lbl06"
        Me.lbl06.Size = New System.Drawing.Size(30, 13)
        Me.lbl06.TabIndex = 607
        Me.lbl06.Text = "June"
        '
        'lbl05
        '
        Me.lbl05.AutoSize = True
        Me.lbl05.Location = New System.Drawing.Point(166, 214)
        Me.lbl05.Name = "lbl05"
        Me.lbl05.Size = New System.Drawing.Size(27, 13)
        Me.lbl05.TabIndex = 606
        Me.lbl05.Text = "May"
        '
        'lbl04
        '
        Me.lbl04.AutoSize = True
        Me.lbl04.Location = New System.Drawing.Point(166, 184)
        Me.lbl04.Name = "lbl04"
        Me.lbl04.Size = New System.Drawing.Size(27, 13)
        Me.lbl04.TabIndex = 605
        Me.lbl04.Text = "April"
        '
        'lbl03
        '
        Me.lbl03.AutoSize = True
        Me.lbl03.Location = New System.Drawing.Point(166, 158)
        Me.lbl03.Name = "lbl03"
        Me.lbl03.Size = New System.Drawing.Size(37, 13)
        Me.lbl03.TabIndex = 604
        Me.lbl03.Text = "March"
        '
        'lbl02
        '
        Me.lbl02.AutoSize = True
        Me.lbl02.Location = New System.Drawing.Point(166, 128)
        Me.lbl02.Name = "lbl02"
        Me.lbl02.Size = New System.Drawing.Size(48, 13)
        Me.lbl02.TabIndex = 603
        Me.lbl02.Text = "February"
        '
        'lbl01
        '
        Me.lbl01.AutoSize = True
        Me.lbl01.Location = New System.Drawing.Point(166, 95)
        Me.lbl01.Name = "lbl01"
        Me.lbl01.Size = New System.Drawing.Size(44, 13)
        Me.lbl01.TabIndex = 602
        Me.lbl01.Text = "January"
        '
        'UcrNavigator1
        '
        Me.UcrNavigator1.Location = New System.Drawing.Point(124, 467)
        Me.UcrNavigator1.Name = "UcrNavigator1"
        Me.UcrNavigator1.Size = New System.Drawing.Size(336, 25)
        Me.UcrNavigator1.TabIndex = 614
        '
        'btnUpload
        '
        Me.btnUpload.BackColor = System.Drawing.Color.Lime
        Me.btnUpload.Location = New System.Drawing.Point(532, 540)
        Me.btnUpload.Name = "btnUpload"
        Me.btnUpload.Size = New System.Drawing.Size(75, 23)
        Me.btnUpload.TabIndex = 688
        Me.btnUpload.Text = "Upload"
        Me.btnUpload.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(168, 547)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 690
        Me.Label5.Text = "Sequencer:"
        '
        'txtSequencer
        '
        Me.txtSequencer.Location = New System.Drawing.Point(233, 544)
        Me.txtSequencer.Name = "txtSequencer"
        Me.txtSequencer.ReadOnly = True
        Me.txtSequencer.Size = New System.Drawing.Size(200, 20)
        Me.txtSequencer.TabIndex = 689
        Me.txtSequencer.Text = "seq_monthly_element"
        '
        'UcrValueFlagPeriodNew1
        '
        Me.UcrValueFlagPeriodNew1.FieldName = Nothing
        Me.UcrValueFlagPeriodNew1.IncludePeriod = True
        Me.UcrValueFlagPeriodNew1.Location = New System.Drawing.Point(232, 121)
        Me.UcrValueFlagPeriodNew1.Name = "UcrValueFlagPeriodNew1"
        Me.UcrValueFlagPeriodNew1.Size = New System.Drawing.Size(127, 28)
        Me.UcrValueFlagPeriodNew1.TabIndex = 691
        '
        'UcrValueFlagPeriod1
        '
        Me.UcrValueFlagPeriod1.FieldName = Nothing
        Me.UcrValueFlagPeriod1.IncludePeriod = True
        Me.UcrValueFlagPeriod1.KeyControl = False
        Me.UcrValueFlagPeriod1.Location = New System.Drawing.Point(232, 209)
        Me.UcrValueFlagPeriod1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcrValueFlagPeriod1.Name = "UcrValueFlagPeriod1"
        Me.UcrValueFlagPeriod1.Size = New System.Drawing.Size(127, 28)
        Me.UcrValueFlagPeriod1.TabIndex = 692
        '
        'UcrValueFlagPeriod2
        '
        Me.UcrValueFlagPeriod2.FieldName = Nothing
        Me.UcrValueFlagPeriod2.IncludePeriod = True
        Me.UcrValueFlagPeriod2.KeyControl = False
        Me.UcrValueFlagPeriod2.Location = New System.Drawing.Point(232, 91)
        Me.UcrValueFlagPeriod2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcrValueFlagPeriod2.Name = "UcrValueFlagPeriod2"
        Me.UcrValueFlagPeriod2.Size = New System.Drawing.Size(127, 28)
        Me.UcrValueFlagPeriod2.TabIndex = 693
        '
        'UcrValueFlagPeriod3
        '
        Me.UcrValueFlagPeriod3.FieldName = Nothing
        Me.UcrValueFlagPeriod3.IncludePeriod = True
        Me.UcrValueFlagPeriod3.KeyControl = False
        Me.UcrValueFlagPeriod3.Location = New System.Drawing.Point(232, 152)
        Me.UcrValueFlagPeriod3.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcrValueFlagPeriod3.Name = "UcrValueFlagPeriod3"
        Me.UcrValueFlagPeriod3.Size = New System.Drawing.Size(127, 28)
        Me.UcrValueFlagPeriod3.TabIndex = 694
        '
        'UcrValueFlagPeriod4
        '
        Me.UcrValueFlagPeriod4.FieldName = Nothing
        Me.UcrValueFlagPeriod4.IncludePeriod = True
        Me.UcrValueFlagPeriod4.KeyControl = False
        Me.UcrValueFlagPeriod4.Location = New System.Drawing.Point(232, 179)
        Me.UcrValueFlagPeriod4.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcrValueFlagPeriod4.Name = "UcrValueFlagPeriod4"
        Me.UcrValueFlagPeriod4.Size = New System.Drawing.Size(127, 28)
        Me.UcrValueFlagPeriod4.TabIndex = 695
        '
        'UcrValueFlagPeriod5
        '
        Me.UcrValueFlagPeriod5.FieldName = Nothing
        Me.UcrValueFlagPeriod5.IncludePeriod = True
        Me.UcrValueFlagPeriod5.KeyControl = False
        Me.UcrValueFlagPeriod5.Location = New System.Drawing.Point(232, 239)
        Me.UcrValueFlagPeriod5.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcrValueFlagPeriod5.Name = "UcrValueFlagPeriod5"
        Me.UcrValueFlagPeriod5.Size = New System.Drawing.Size(127, 28)
        Me.UcrValueFlagPeriod5.TabIndex = 696
        '
        'UcrValueFlagPeriod6
        '
        Me.UcrValueFlagPeriod6.FieldName = Nothing
        Me.UcrValueFlagPeriod6.IncludePeriod = True
        Me.UcrValueFlagPeriod6.KeyControl = False
        Me.UcrValueFlagPeriod6.Location = New System.Drawing.Point(232, 269)
        Me.UcrValueFlagPeriod6.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcrValueFlagPeriod6.Name = "UcrValueFlagPeriod6"
        Me.UcrValueFlagPeriod6.Size = New System.Drawing.Size(127, 28)
        Me.UcrValueFlagPeriod6.TabIndex = 697
        '
        'UcrValueFlagPeriod7
        '
        Me.UcrValueFlagPeriod7.FieldName = Nothing
        Me.UcrValueFlagPeriod7.IncludePeriod = True
        Me.UcrValueFlagPeriod7.KeyControl = False
        Me.UcrValueFlagPeriod7.Location = New System.Drawing.Point(232, 299)
        Me.UcrValueFlagPeriod7.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcrValueFlagPeriod7.Name = "UcrValueFlagPeriod7"
        Me.UcrValueFlagPeriod7.Size = New System.Drawing.Size(127, 28)
        Me.UcrValueFlagPeriod7.TabIndex = 698
        '
        'UcrValueFlagPeriod8
        '
        Me.UcrValueFlagPeriod8.FieldName = Nothing
        Me.UcrValueFlagPeriod8.IncludePeriod = True
        Me.UcrValueFlagPeriod8.KeyControl = False
        Me.UcrValueFlagPeriod8.Location = New System.Drawing.Point(232, 329)
        Me.UcrValueFlagPeriod8.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcrValueFlagPeriod8.Name = "UcrValueFlagPeriod8"
        Me.UcrValueFlagPeriod8.Size = New System.Drawing.Size(127, 28)
        Me.UcrValueFlagPeriod8.TabIndex = 699
        '
        'UcrValueFlagPeriod9
        '
        Me.UcrValueFlagPeriod9.FieldName = Nothing
        Me.UcrValueFlagPeriod9.IncludePeriod = True
        Me.UcrValueFlagPeriod9.KeyControl = False
        Me.UcrValueFlagPeriod9.Location = New System.Drawing.Point(232, 359)
        Me.UcrValueFlagPeriod9.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcrValueFlagPeriod9.Name = "UcrValueFlagPeriod9"
        Me.UcrValueFlagPeriod9.Size = New System.Drawing.Size(127, 28)
        Me.UcrValueFlagPeriod9.TabIndex = 700
        '
        'UcrValueFlagPeriod10
        '
        Me.UcrValueFlagPeriod10.FieldName = Nothing
        Me.UcrValueFlagPeriod10.IncludePeriod = True
        Me.UcrValueFlagPeriod10.KeyControl = False
        Me.UcrValueFlagPeriod10.Location = New System.Drawing.Point(232, 389)
        Me.UcrValueFlagPeriod10.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcrValueFlagPeriod10.Name = "UcrValueFlagPeriod10"
        Me.UcrValueFlagPeriod10.Size = New System.Drawing.Size(127, 28)
        Me.UcrValueFlagPeriod10.TabIndex = 701
        '
        'UcrValueFlagPeriod11
        '
        Me.UcrValueFlagPeriod11.FieldName = Nothing
        Me.UcrValueFlagPeriod11.IncludePeriod = True
        Me.UcrValueFlagPeriod11.KeyControl = False
        Me.UcrValueFlagPeriod11.Location = New System.Drawing.Point(232, 419)
        Me.UcrValueFlagPeriod11.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UcrValueFlagPeriod11.Name = "UcrValueFlagPeriod11"
        Me.UcrValueFlagPeriod11.Size = New System.Drawing.Size(127, 28)
        Me.UcrValueFlagPeriod11.TabIndex = 702
        '
        'ucrBtnAddNew
        '
        Me.ucrBtnAddNew.ActionTypeId = ClimsoftVer4.ClsGlobals.EnumActionCode.AddNew
        Me.ucrBtnAddNew.ButtonText = "Add New"
        Me.ucrBtnAddNew.Location = New System.Drawing.Point(6, 507)
        Me.ucrBtnAddNew.Name = "ucrBtnAddNew"
        Me.ucrBtnAddNew.Size = New System.Drawing.Size(60, 23)
        Me.ucrBtnAddNew.TabIndex = 703
        '
        'ucrBtnDelete
        '
        Me.ucrBtnDelete.ActionTypeId = ClimsoftVer4.ClsGlobals.EnumActionCode.Delete
        Me.ucrBtnDelete.ButtonText = "Delete"
        Me.ucrBtnDelete.Location = New System.Drawing.Point(206, 507)
        Me.ucrBtnDelete.Name = "ucrBtnDelete"
        Me.ucrBtnDelete.Size = New System.Drawing.Size(60, 23)
        Me.ucrBtnDelete.TabIndex = 704
        '
        'ucrBtnSave
        '
        Me.ucrBtnSave.ActionTypeId = ClimsoftVer4.ClsGlobals.EnumActionCode.Save
        Me.ucrBtnSave.ButtonText = "Save"
        Me.ucrBtnSave.Location = New System.Drawing.Point(72, 507)
        Me.ucrBtnSave.Name = "ucrBtnSave"
        Me.ucrBtnSave.Size = New System.Drawing.Size(60, 23)
        Me.ucrBtnSave.TabIndex = 705
        '
        'ucrBtnUpdate
        '
        Me.ucrBtnUpdate.ActionTypeId = ClimsoftVer4.ClsGlobals.EnumActionCode.Update
        Me.ucrBtnUpdate.ButtonText = "Update"
        Me.ucrBtnUpdate.Location = New System.Drawing.Point(139, 507)
        Me.ucrBtnUpdate.Name = "ucrBtnUpdate"
        Me.ucrBtnUpdate.Size = New System.Drawing.Size(60, 23)
        Me.ucrBtnUpdate.TabIndex = 707
        '
        'ucrBtnClear
        '
        Me.ucrBtnClear.ButtonText = "Clear"
        Me.ucrBtnClear.Location = New System.Drawing.Point(275, 507)
        Me.ucrBtnClear.Name = "ucrBtnClear"
        Me.ucrBtnClear.Size = New System.Drawing.Size(60, 23)
        Me.ucrBtnClear.TabIndex = 708
        '
        'ucrBtnCancel
        '
        Me.ucrBtnCancel.ButtonText = "Cancel"
        Me.ucrBtnCancel.Location = New System.Drawing.Point(344, 507)
        Me.ucrBtnCancel.Name = "ucrBtnCancel"
        Me.ucrBtnCancel.Size = New System.Drawing.Size(60, 23)
        Me.ucrBtnCancel.TabIndex = 710
        '
        'ucrBtnClose
        '
        Me.ucrBtnClose.ButtonText = "Close"
        Me.ucrBtnClose.Location = New System.Drawing.Point(481, 507)
        Me.ucrBtnClose.Name = "ucrBtnClose"
        Me.ucrBtnClose.Size = New System.Drawing.Size(60, 23)
        Me.ucrBtnClose.TabIndex = 711
        '
        'ucrBtnHelp
        '
        Me.ucrBtnHelp.ButtonText = "Help"
        Me.ucrBtnHelp.Location = New System.Drawing.Point(547, 507)
        Me.ucrBtnHelp.Name = "ucrBtnHelp"
        Me.ucrBtnHelp.Size = New System.Drawing.Size(60, 23)
        Me.ucrBtnHelp.TabIndex = 712
        '
        'ucrBtnView
        '
        Me.ucrBtnView.ButtonText = "View"
        Me.ucrBtnView.Location = New System.Drawing.Point(412, 507)
        Me.ucrBtnView.Name = "ucrBtnView"
        Me.ucrBtnView.Size = New System.Drawing.Size(60, 23)
        Me.ucrBtnView.TabIndex = 713
        '
        'ucrMonthlyDataNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrBtnView)
        Me.Controls.Add(Me.ucrBtnHelp)
        Me.Controls.Add(Me.ucrBtnClose)
        Me.Controls.Add(Me.ucrBtnCancel)
        Me.Controls.Add(Me.ucrBtnClear)
        Me.Controls.Add(Me.ucrBtnUpdate)
        Me.Controls.Add(Me.ucrBtnSave)
        Me.Controls.Add(Me.ucrBtnDelete)
        Me.Controls.Add(Me.ucrBtnAddNew)
        Me.Controls.Add(Me.UcrValueFlagPeriod11)
        Me.Controls.Add(Me.UcrValueFlagPeriod10)
        Me.Controls.Add(Me.UcrValueFlagPeriod9)
        Me.Controls.Add(Me.UcrValueFlagPeriod8)
        Me.Controls.Add(Me.UcrValueFlagPeriod7)
        Me.Controls.Add(Me.UcrValueFlagPeriod6)
        Me.Controls.Add(Me.UcrValueFlagPeriod5)
        Me.Controls.Add(Me.UcrValueFlagPeriod4)
        Me.Controls.Add(Me.UcrValueFlagPeriod3)
        Me.Controls.Add(Me.UcrValueFlagPeriod2)
        Me.Controls.Add(Me.UcrValueFlagPeriod1)
        Me.Controls.Add(Me.UcrValueFlagPeriodNew1)
        Me.Controls.Add(Me.btnUpload)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSequencer)
        Me.Controls.Add(Me.UcrNavigator1)
        Me.Controls.Add(Me.lbl12)
        Me.Controls.Add(Me.lbl11)
        Me.Controls.Add(Me.lbl10)
        Me.Controls.Add(Me.lbl09)
        Me.Controls.Add(Me.lbl08)
        Me.Controls.Add(Me.lbl07)
        Me.Controls.Add(Me.lbl06)
        Me.Controls.Add(Me.lbl05)
        Me.Controls.Add(Me.lbl04)
        Me.Controls.Add(Me.lbl03)
        Me.Controls.Add(Me.lbl02)
        Me.Controls.Add(Me.lbl01)
        Me.Controls.Add(Me.lblPeriod)
        Me.Controls.Add(Me.lblFlag)
        Me.Controls.Add(Me.lblValue)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.ucrYearSelector)
        Me.Controls.Add(Me.ucrElementSelector)
        Me.Controls.Add(Me.ucrStationSelector)
        Me.Controls.Add(Me.lblElement)
        Me.Controls.Add(Me.lblStation)
        Me.Controls.Add(lblYear)
        Me.Name = "ucrMonthlyDataNew"
        Me.Size = New System.Drawing.Size(623, 581)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblElement As Label
    Friend WithEvents lblStation As Label
    Friend WithEvents ucrStationSelector As ucrStationSelectorNew
    Friend WithEvents ucrElementSelector As ucrElementSelectorNew
    Friend WithEvents ucrYearSelector As ucrYearSelectorNew
    Friend WithEvents lblPeriod As Label
    Friend WithEvents lblFlag As Label
    Friend WithEvents lblValue As Label
    Friend WithEvents lblMonth As Label
    Friend WithEvents lbl12 As Label
    Friend WithEvents lbl11 As Label
    Friend WithEvents lbl10 As Label
    Friend WithEvents lbl09 As Label
    Friend WithEvents lbl08 As Label
    Friend WithEvents lbl07 As Label
    Friend WithEvents lbl06 As Label
    Friend WithEvents lbl05 As Label
    Friend WithEvents lbl04 As Label
    Friend WithEvents lbl03 As Label
    Friend WithEvents lbl02 As Label
    Friend WithEvents lbl01 As Label
    Friend WithEvents UcrNavigator1 As ucrNavigator
    Friend WithEvents btnUpload As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSequencer As TextBox
    Friend WithEvents UcrValueFlagPeriodNew1 As ucrValueFlagPeriodNew
    Friend WithEvents UcrValueFlagPeriod1 As ucrValueFlagPeriod
    Friend WithEvents UcrValueFlagPeriod2 As ucrValueFlagPeriod
    Friend WithEvents UcrValueFlagPeriod3 As ucrValueFlagPeriod
    Friend WithEvents UcrValueFlagPeriod4 As ucrValueFlagPeriod
    Friend WithEvents UcrValueFlagPeriod5 As ucrValueFlagPeriod
    Friend WithEvents UcrValueFlagPeriod6 As ucrValueFlagPeriod
    Friend WithEvents UcrValueFlagPeriod7 As ucrValueFlagPeriod
    Friend WithEvents UcrValueFlagPeriod8 As ucrValueFlagPeriod
    Friend WithEvents UcrValueFlagPeriod9 As ucrValueFlagPeriod
    Friend WithEvents UcrValueFlagPeriod10 As ucrValueFlagPeriod
    Friend WithEvents UcrValueFlagPeriod11 As ucrValueFlagPeriod
    Friend WithEvents ucrBtnAddNew As ucrButton
    Friend WithEvents ucrBtnDelete As ucrButton
    Friend WithEvents ucrBtnSave As ucrButton
    Friend WithEvents ucrBtnUpdate As ucrButton
    Friend WithEvents ucrBtnClear As ucrButton
    Friend WithEvents ucrBtnCancel As ucrButton
    Friend WithEvents ucrBtnClose As ucrButton
    Friend WithEvents ucrBtnHelp As ucrButton
    Friend WithEvents ucrBtnView As ucrButton
End Class
