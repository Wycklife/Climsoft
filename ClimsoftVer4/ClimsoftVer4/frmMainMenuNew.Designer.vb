<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenuNew
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMainMenuNew))
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.mnuInput = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInputKeyEntry = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuInputPaperArchive = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAccessories = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAccessoriesDewPointRH = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAccessoriesXMLOutput = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserRecordsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuProducts = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuQC = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAdministration = New System.Windows.Forms.ToolStripMenuItem()
        Me.UserAdminToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MetadataToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DataFormsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateElementsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UpdateObservationsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpeartionsMonitoringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmptyKeyEntryTablesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeOwnPasswordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTools = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuToolsModifyForms = New System.Windows.Forms.ToolStripMenuItem()
        Me.SelectLanguageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerlSettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SequencerConfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HourlyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DailyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonthlyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormHourlyTimeSelectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AWSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AWSElementsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AWSStationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConfigurationForTDCFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLanguageTranslation = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpContents = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelpAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCloseButton = New System.Windows.Forms.Button()
        Me.btnSettingsAWS = New System.Windows.Forms.Button()
        Me.btnMetadata = New System.Windows.Forms.Button()
        Me.btnUserManagement = New System.Windows.Forms.Button()
        Me.btnProducts = New System.Windows.Forms.Button()
        Me.btnQC = New System.Windows.Forms.Button()
        Me.btnDataTransfer = New System.Windows.Forms.Button()
        Me.btnPaperArchive = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnKeyEntry = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MenuStrip2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip2
        '
        Me.MenuStrip2.AllowItemReorder = True
        Me.MenuStrip2.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuInput, Me.mnuAccessories, Me.mnuProducts, Me.mnuQC, Me.mnuAdministration, Me.ChangeOwnPasswordToolStripMenuItem, Me.mnuTools, Me.mnuLanguageTranslation, Me.mnuHelp})
        Me.MenuStrip2.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.ShowItemToolTips = True
        Me.MenuStrip2.Size = New System.Drawing.Size(853, 27)
        Me.MenuStrip2.TabIndex = 8
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'mnuInput
        '
        Me.mnuInput.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuInputKeyEntry, Me.mnuInputPaperArchive})
        Me.mnuInput.Name = "mnuInput"
        Me.mnuInput.ShortcutKeyDisplayString = ""
        Me.mnuInput.Size = New System.Drawing.Size(54, 23)
        Me.mnuInput.Tag = "Input"
        Me.mnuInput.Text = "Input"
        '
        'mnuInputKeyEntry
        '
        Me.mnuInputKeyEntry.Name = "mnuInputKeyEntry"
        Me.mnuInputKeyEntry.Size = New System.Drawing.Size(180, 24)
        Me.mnuInputKeyEntry.Tag = "Key_Entry"
        Me.mnuInputKeyEntry.Text = "Key Entry"
        '
        'mnuInputPaperArchive
        '
        Me.mnuInputPaperArchive.Name = "mnuInputPaperArchive"
        Me.mnuInputPaperArchive.Size = New System.Drawing.Size(180, 24)
        Me.mnuInputPaperArchive.Tag = "Paper_Archive"
        Me.mnuInputPaperArchive.Text = "Paper Archive"
        '
        'mnuAccessories
        '
        Me.mnuAccessories.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAccessoriesDewPointRH, Me.mnuAccessoriesXMLOutput, Me.UserRecordsToolStripMenuItem1})
        Me.mnuAccessories.Name = "mnuAccessories"
        Me.mnuAccessories.Size = New System.Drawing.Size(90, 23)
        Me.mnuAccessories.Tag = "Accessories"
        Me.mnuAccessories.Text = "Accessories"
        '
        'mnuAccessoriesDewPointRH
        '
        Me.mnuAccessoriesDewPointRH.Name = "mnuAccessoriesDewPointRH"
        Me.mnuAccessoriesDewPointRH.Size = New System.Drawing.Size(274, 24)
        Me.mnuAccessoriesDewPointRH.Tag = "Calculation_of_dew_Point_and_RH"
        Me.mnuAccessoriesDewPointRH.Text = "Calculation of dew Point and RH"
        '
        'mnuAccessoriesXMLOutput
        '
        Me.mnuAccessoriesXMLOutput.Name = "mnuAccessoriesXMLOutput"
        Me.mnuAccessoriesXMLOutput.Size = New System.Drawing.Size(274, 24)
        Me.mnuAccessoriesXMLOutput.Tag = "Generate_XML_Output"
        Me.mnuAccessoriesXMLOutput.Text = "Generate XML Output"
        '
        'UserRecordsToolStripMenuItem1
        '
        Me.UserRecordsToolStripMenuItem1.Name = "UserRecordsToolStripMenuItem1"
        Me.UserRecordsToolStripMenuItem1.Size = New System.Drawing.Size(274, 24)
        Me.UserRecordsToolStripMenuItem1.Text = "User Records"
        '
        'mnuProducts
        '
        Me.mnuProducts.Name = "mnuProducts"
        Me.mnuProducts.Size = New System.Drawing.Size(75, 23)
        Me.mnuProducts.Tag = "Products"
        Me.mnuProducts.Text = "Products"
        '
        'mnuQC
        '
        Me.mnuQC.Name = "mnuQC"
        Me.mnuQC.Size = New System.Drawing.Size(41, 23)
        Me.mnuQC.Tag = "QC"
        Me.mnuQC.Text = "QC"
        '
        'mnuAdministration
        '
        Me.mnuAdministration.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UserAdminToolStripMenuItem, Me.MetadataToolStripMenuItem, Me.PasswordToolStripMenuItem, Me.DataFormsToolStripMenuItem, Me.UpdateElementsToolStripMenuItem, Me.UpdateObservationsToolStripMenuItem1, Me.OpeartionsMonitoringToolStripMenuItem, Me.EmptyKeyEntryTablesToolStripMenuItem})
        Me.mnuAdministration.Name = "mnuAdministration"
        Me.mnuAdministration.Size = New System.Drawing.Size(111, 23)
        Me.mnuAdministration.Tag = "Administration"
        Me.mnuAdministration.Text = "Administration"
        '
        'UserAdminToolStripMenuItem
        '
        Me.UserAdminToolStripMenuItem.Name = "UserAdminToolStripMenuItem"
        Me.UserAdminToolStripMenuItem.Size = New System.Drawing.Size(221, 24)
        Me.UserAdminToolStripMenuItem.Tag = "User_Admin"
        Me.UserAdminToolStripMenuItem.Text = "User Admin"
        '
        'MetadataToolStripMenuItem
        '
        Me.MetadataToolStripMenuItem.Name = "MetadataToolStripMenuItem"
        Me.MetadataToolStripMenuItem.Size = New System.Drawing.Size(221, 24)
        Me.MetadataToolStripMenuItem.Tag = "Metadata"
        Me.MetadataToolStripMenuItem.Text = "Metadata"
        '
        'PasswordToolStripMenuItem
        '
        Me.PasswordToolStripMenuItem.Name = "PasswordToolStripMenuItem"
        Me.PasswordToolStripMenuItem.Size = New System.Drawing.Size(221, 24)
        Me.PasswordToolStripMenuItem.Text = "Change Password"
        '
        'DataFormsToolStripMenuItem
        '
        Me.DataFormsToolStripMenuItem.Name = "DataFormsToolStripMenuItem"
        Me.DataFormsToolStripMenuItem.Size = New System.Drawing.Size(221, 24)
        Me.DataFormsToolStripMenuItem.Tag = "Data_Forms"
        Me.DataFormsToolStripMenuItem.Text = "Data Forms"
        '
        'UpdateElementsToolStripMenuItem
        '
        Me.UpdateElementsToolStripMenuItem.Name = "UpdateElementsToolStripMenuItem"
        Me.UpdateElementsToolStripMenuItem.Size = New System.Drawing.Size(221, 24)
        Me.UpdateElementsToolStripMenuItem.Tag = "Update_Element_Limits"
        Me.UpdateElementsToolStripMenuItem.Text = "Update Element Limits"
        Me.UpdateElementsToolStripMenuItem.Visible = False
        '
        'UpdateObservationsToolStripMenuItem1
        '
        Me.UpdateObservationsToolStripMenuItem1.Name = "UpdateObservationsToolStripMenuItem1"
        Me.UpdateObservationsToolStripMenuItem1.Size = New System.Drawing.Size(221, 24)
        Me.UpdateObservationsToolStripMenuItem1.Text = "Update Observations"
        '
        'OpeartionsMonitoringToolStripMenuItem
        '
        Me.OpeartionsMonitoringToolStripMenuItem.Name = "OpeartionsMonitoringToolStripMenuItem"
        Me.OpeartionsMonitoringToolStripMenuItem.Size = New System.Drawing.Size(221, 24)
        Me.OpeartionsMonitoringToolStripMenuItem.Text = "Operations Monitoring"
        '
        'EmptyKeyEntryTablesToolStripMenuItem
        '
        Me.EmptyKeyEntryTablesToolStripMenuItem.Name = "EmptyKeyEntryTablesToolStripMenuItem"
        Me.EmptyKeyEntryTablesToolStripMenuItem.Size = New System.Drawing.Size(221, 24)
        Me.EmptyKeyEntryTablesToolStripMenuItem.Text = "Empty Key Entry Forms"
        '
        'ChangeOwnPasswordToolStripMenuItem
        '
        Me.ChangeOwnPasswordToolStripMenuItem.Name = "ChangeOwnPasswordToolStripMenuItem"
        Me.ChangeOwnPasswordToolStripMenuItem.Size = New System.Drawing.Size(160, 23)
        Me.ChangeOwnPasswordToolStripMenuItem.Text = "Change own password"
        '
        'mnuTools
        '
        Me.mnuTools.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuToolsModifyForms, Me.SelectLanguageToolStripMenuItem, Me.GenerlSettingsToolStripMenuItem, Me.SequencerConfigurationToolStripMenuItem, Me.FormHourlyTimeSelectionToolStripMenuItem, Me.AWSToolStripMenuItem, Me.ConfigurationForTDCFToolStripMenuItem})
        Me.mnuTools.Name = "mnuTools"
        Me.mnuTools.Size = New System.Drawing.Size(52, 23)
        Me.mnuTools.Tag = "Tools"
        Me.mnuTools.Text = "Tools"
        '
        'mnuToolsModifyForms
        '
        Me.mnuToolsModifyForms.Name = "mnuToolsModifyForms"
        Me.mnuToolsModifyForms.Size = New System.Drawing.Size(242, 24)
        Me.mnuToolsModifyForms.Tag = "Modify_Forms"
        Me.mnuToolsModifyForms.Text = "Modify Forms"
        Me.mnuToolsModifyForms.Visible = False
        '
        'SelectLanguageToolStripMenuItem
        '
        Me.SelectLanguageToolStripMenuItem.Name = "SelectLanguageToolStripMenuItem"
        Me.SelectLanguageToolStripMenuItem.Size = New System.Drawing.Size(242, 24)
        Me.SelectLanguageToolStripMenuItem.Tag = "Select_Language"
        Me.SelectLanguageToolStripMenuItem.Text = "Select Language"
        '
        'GenerlSettingsToolStripMenuItem
        '
        Me.GenerlSettingsToolStripMenuItem.Name = "GenerlSettingsToolStripMenuItem"
        Me.GenerlSettingsToolStripMenuItem.Size = New System.Drawing.Size(242, 24)
        Me.GenerlSettingsToolStripMenuItem.Text = "General Settings"
        '
        'SequencerConfigurationToolStripMenuItem
        '
        Me.SequencerConfigurationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HourlyToolStripMenuItem, Me.DailyToolStripMenuItem, Me.MonthlyToolStripMenuItem})
        Me.SequencerConfigurationToolStripMenuItem.Name = "SequencerConfigurationToolStripMenuItem"
        Me.SequencerConfigurationToolStripMenuItem.Size = New System.Drawing.Size(242, 24)
        Me.SequencerConfigurationToolStripMenuItem.Text = "Sequencer Configuration"
        '
        'HourlyToolStripMenuItem
        '
        Me.HourlyToolStripMenuItem.Name = "HourlyToolStripMenuItem"
        Me.HourlyToolStripMenuItem.Size = New System.Drawing.Size(130, 24)
        Me.HourlyToolStripMenuItem.Text = "Daily"
        '
        'DailyToolStripMenuItem
        '
        Me.DailyToolStripMenuItem.Name = "DailyToolStripMenuItem"
        Me.DailyToolStripMenuItem.Size = New System.Drawing.Size(130, 24)
        Me.DailyToolStripMenuItem.Text = "Hourly"
        '
        'MonthlyToolStripMenuItem
        '
        Me.MonthlyToolStripMenuItem.Name = "MonthlyToolStripMenuItem"
        Me.MonthlyToolStripMenuItem.Size = New System.Drawing.Size(130, 24)
        Me.MonthlyToolStripMenuItem.Text = "Monthly"
        '
        'FormHourlyTimeSelectionToolStripMenuItem
        '
        Me.FormHourlyTimeSelectionToolStripMenuItem.Name = "FormHourlyTimeSelectionToolStripMenuItem"
        Me.FormHourlyTimeSelectionToolStripMenuItem.Size = New System.Drawing.Size(242, 24)
        Me.FormHourlyTimeSelectionToolStripMenuItem.Text = "FormHourly Time Selection"
        '
        'AWSToolStripMenuItem
        '
        Me.AWSToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AWSElementsToolStripMenuItem, Me.AWSStationsToolStripMenuItem})
        Me.AWSToolStripMenuItem.Name = "AWSToolStripMenuItem"
        Me.AWSToolStripMenuItem.Size = New System.Drawing.Size(242, 24)
        Me.AWSToolStripMenuItem.Text = "AWS"
        Me.AWSToolStripMenuItem.Visible = False
        '
        'AWSElementsToolStripMenuItem
        '
        Me.AWSElementsToolStripMenuItem.Name = "AWSElementsToolStripMenuItem"
        Me.AWSElementsToolStripMenuItem.Size = New System.Drawing.Size(165, 24)
        Me.AWSElementsToolStripMenuItem.Text = "AWS Elements"
        '
        'AWSStationsToolStripMenuItem
        '
        Me.AWSStationsToolStripMenuItem.Name = "AWSStationsToolStripMenuItem"
        Me.AWSStationsToolStripMenuItem.Size = New System.Drawing.Size(165, 24)
        Me.AWSStationsToolStripMenuItem.Text = "AWS Stations"
        '
        'ConfigurationForTDCFToolStripMenuItem
        '
        Me.ConfigurationForTDCFToolStripMenuItem.Name = "ConfigurationForTDCFToolStripMenuItem"
        Me.ConfigurationForTDCFToolStripMenuItem.Size = New System.Drawing.Size(242, 24)
        Me.ConfigurationForTDCFToolStripMenuItem.Text = "TDCF Settings"
        '
        'mnuLanguageTranslation
        '
        Me.mnuLanguageTranslation.Name = "mnuLanguageTranslation"
        Me.mnuLanguageTranslation.Size = New System.Drawing.Size(151, 23)
        Me.mnuLanguageTranslation.Text = "Language Translation"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuHelpContents, Me.mnuHelpAbout})
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(49, 23)
        Me.mnuHelp.Tag = "Help"
        Me.mnuHelp.Text = "Help"
        '
        'mnuHelpContents
        '
        Me.mnuHelpContents.Name = "mnuHelpContents"
        Me.mnuHelpContents.Size = New System.Drawing.Size(180, 24)
        Me.mnuHelpContents.Tag = "Contents"
        Me.mnuHelpContents.Text = "Contents"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Name = "mnuHelpAbout"
        Me.mnuHelpAbout.Size = New System.Drawing.Size(180, 24)
        Me.mnuHelpAbout.Tag = "About"
        Me.mnuHelpAbout.Text = "About"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Linen
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnCloseButton)
        Me.Panel1.Controls.Add(Me.btnSettingsAWS)
        Me.Panel1.Controls.Add(Me.btnMetadata)
        Me.Panel1.Controls.Add(Me.btnUserManagement)
        Me.Panel1.Controls.Add(Me.btnProducts)
        Me.Panel1.Controls.Add(Me.btnQC)
        Me.Panel1.Controls.Add(Me.btnDataTransfer)
        Me.Panel1.Controls.Add(Me.btnPaperArchive)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnKeyEntry)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 27)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(0, 3, 3, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(840, 525)
        Me.Panel1.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(393, 436)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 16)
        Me.Label5.TabIndex = 36
        Me.Label5.Tag = "Close"
        Me.Label5.Text = "Close"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(332, 7)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 25)
        Me.Label11.TabIndex = 35
        Me.Label11.Text = "Welcome"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(110, 436)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(176, 16)
        Me.Label9.TabIndex = 33
        Me.Label9.Tag = "AWS_Real_Time_Processing"
        Me.Label9.Text = "AWS Real Time Processing"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(555, 436)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(133, 16)
        Me.Label8.TabIndex = 32
        Me.Label8.Tag = "Metadata_Information"
        Me.Label8.Text = "Metadata Information"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(133, 324)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(131, 16)
        Me.Label7.TabIndex = 31
        Me.Label7.Tag = "Users_Administration"
        Me.Label7.Text = "Users Administration"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(566, 323)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(109, 16)
        Me.Label6.TabIndex = 30
        Me.Label6.Tag = "Climate_Products"
        Me.Label6.Text = "Climate Products"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(551, 217)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(142, 16)
        Me.Label4.TabIndex = 28
        Me.Label4.Tag = "Quality_Control_Checks"
        Me.Label4.Text = "Quality Control Checks"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(153, 219)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 16)
        Me.Label3.TabIndex = 27
        Me.Label3.Tag = "Data_Transfer"
        Me.Label3.Text = "Data Transfer"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(556, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 16)
        Me.Label2.TabIndex = 26
        Me.Label2.Tag = "Archive_Paper_Image"
        Me.Label2.Text = "Archive Paper Image"
        '
        'btnCloseButton
        '
        Me.btnCloseButton.BackgroundImage = CType(resources.GetObject("btnCloseButton.BackgroundImage"), System.Drawing.Image)
        Me.btnCloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCloseButton.FlatAppearance.BorderSize = 4
        Me.btnCloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCloseButton.Location = New System.Drawing.Point(368, 364)
        Me.btnCloseButton.Margin = New System.Windows.Forms.Padding(0)
        Me.btnCloseButton.Name = "btnCloseButton"
        Me.btnCloseButton.Padding = New System.Windows.Forms.Padding(5)
        Me.btnCloseButton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnCloseButton.Size = New System.Drawing.Size(96, 69)
        Me.btnCloseButton.TabIndex = 25
        Me.btnCloseButton.UseCompatibleTextRendering = True
        Me.btnCloseButton.UseVisualStyleBackColor = True
        '
        'btnSettingsAWS
        '
        Me.btnSettingsAWS.BackgroundImage = CType(resources.GetObject("btnSettingsAWS.BackgroundImage"), System.Drawing.Image)
        Me.btnSettingsAWS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSettingsAWS.FlatAppearance.BorderSize = 4
        Me.btnSettingsAWS.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSettingsAWS.ForeColor = System.Drawing.Color.Red
        Me.btnSettingsAWS.Location = New System.Drawing.Point(135, 360)
        Me.btnSettingsAWS.Margin = New System.Windows.Forms.Padding(0)
        Me.btnSettingsAWS.Name = "btnSettingsAWS"
        Me.btnSettingsAWS.Padding = New System.Windows.Forms.Padding(5)
        Me.btnSettingsAWS.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnSettingsAWS.Size = New System.Drawing.Size(126, 76)
        Me.btnSettingsAWS.TabIndex = 24
        Me.btnSettingsAWS.UseCompatibleTextRendering = True
        Me.btnSettingsAWS.UseVisualStyleBackColor = True
        '
        'btnMetadata
        '
        Me.btnMetadata.BackgroundImage = CType(resources.GetObject("btnMetadata.BackgroundImage"), System.Drawing.Image)
        Me.btnMetadata.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnMetadata.FlatAppearance.BorderSize = 4
        Me.btnMetadata.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMetadata.ForeColor = System.Drawing.Color.Red
        Me.btnMetadata.Location = New System.Drawing.Point(558, 360)
        Me.btnMetadata.Margin = New System.Windows.Forms.Padding(0)
        Me.btnMetadata.Name = "btnMetadata"
        Me.btnMetadata.Padding = New System.Windows.Forms.Padding(5)
        Me.btnMetadata.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnMetadata.Size = New System.Drawing.Size(126, 76)
        Me.btnMetadata.TabIndex = 23
        Me.btnMetadata.UseCompatibleTextRendering = True
        Me.btnMetadata.UseVisualStyleBackColor = True
        '
        'btnUserManagement
        '
        Me.btnUserManagement.BackgroundImage = CType(resources.GetObject("btnUserManagement.BackgroundImage"), System.Drawing.Image)
        Me.btnUserManagement.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnUserManagement.FlatAppearance.BorderSize = 4
        Me.btnUserManagement.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUserManagement.ForeColor = System.Drawing.Color.Red
        Me.btnUserManagement.Location = New System.Drawing.Point(135, 248)
        Me.btnUserManagement.Margin = New System.Windows.Forms.Padding(0)
        Me.btnUserManagement.Name = "btnUserManagement"
        Me.btnUserManagement.Padding = New System.Windows.Forms.Padding(5)
        Me.btnUserManagement.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnUserManagement.Size = New System.Drawing.Size(126, 76)
        Me.btnUserManagement.TabIndex = 22
        Me.btnUserManagement.UseCompatibleTextRendering = True
        Me.btnUserManagement.UseVisualStyleBackColor = True
        '
        'btnProducts
        '
        Me.btnProducts.BackgroundImage = CType(resources.GetObject("btnProducts.BackgroundImage"), System.Drawing.Image)
        Me.btnProducts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnProducts.FlatAppearance.BorderSize = 4
        Me.btnProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProducts.ForeColor = System.Drawing.Color.Red
        Me.btnProducts.Location = New System.Drawing.Point(558, 247)
        Me.btnProducts.Margin = New System.Windows.Forms.Padding(0)
        Me.btnProducts.Name = "btnProducts"
        Me.btnProducts.Padding = New System.Windows.Forms.Padding(5)
        Me.btnProducts.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnProducts.Size = New System.Drawing.Size(126, 76)
        Me.btnProducts.TabIndex = 21
        Me.btnProducts.UseCompatibleTextRendering = True
        Me.btnProducts.UseVisualStyleBackColor = True
        '
        'btnQC
        '
        Me.btnQC.BackgroundImage = CType(resources.GetObject("btnQC.BackgroundImage"), System.Drawing.Image)
        Me.btnQC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnQC.FlatAppearance.BorderSize = 4
        Me.btnQC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQC.ForeColor = System.Drawing.Color.Red
        Me.btnQC.Location = New System.Drawing.Point(559, 143)
        Me.btnQC.Margin = New System.Windows.Forms.Padding(0)
        Me.btnQC.Name = "btnQC"
        Me.btnQC.Padding = New System.Windows.Forms.Padding(5)
        Me.btnQC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnQC.Size = New System.Drawing.Size(126, 76)
        Me.btnQC.TabIndex = 20
        Me.btnQC.UseCompatibleTextRendering = True
        Me.btnQC.UseVisualStyleBackColor = True
        '
        'btnDataTransfer
        '
        Me.btnDataTransfer.BackgroundImage = CType(resources.GetObject("btnDataTransfer.BackgroundImage"), System.Drawing.Image)
        Me.btnDataTransfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnDataTransfer.FlatAppearance.BorderSize = 4
        Me.btnDataTransfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDataTransfer.ForeColor = System.Drawing.Color.Red
        Me.btnDataTransfer.Location = New System.Drawing.Point(135, 143)
        Me.btnDataTransfer.Margin = New System.Windows.Forms.Padding(0)
        Me.btnDataTransfer.Name = "btnDataTransfer"
        Me.btnDataTransfer.Padding = New System.Windows.Forms.Padding(5)
        Me.btnDataTransfer.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnDataTransfer.Size = New System.Drawing.Size(126, 76)
        Me.btnDataTransfer.TabIndex = 19
        Me.btnDataTransfer.UseCompatibleTextRendering = True
        Me.btnDataTransfer.UseVisualStyleBackColor = True
        '
        'btnPaperArchive
        '
        Me.btnPaperArchive.BackgroundImage = CType(resources.GetObject("btnPaperArchive.BackgroundImage"), System.Drawing.Image)
        Me.btnPaperArchive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnPaperArchive.FlatAppearance.BorderSize = 4
        Me.btnPaperArchive.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPaperArchive.ForeColor = System.Drawing.Color.Red
        Me.btnPaperArchive.Location = New System.Drawing.Point(559, 28)
        Me.btnPaperArchive.Margin = New System.Windows.Forms.Padding(0)
        Me.btnPaperArchive.Name = "btnPaperArchive"
        Me.btnPaperArchive.Padding = New System.Windows.Forms.Padding(5)
        Me.btnPaperArchive.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnPaperArchive.Size = New System.Drawing.Size(126, 76)
        Me.btnPaperArchive.TabIndex = 5
        Me.btnPaperArchive.UseCompatibleTextRendering = True
        Me.btnPaperArchive.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(163, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Tag = "Data_Entry"
        Me.Label1.Text = "Data Entry"
        '
        'btnKeyEntry
        '
        Me.btnKeyEntry.AutoEllipsis = True
        Me.btnKeyEntry.BackgroundImage = CType(resources.GetObject("btnKeyEntry.BackgroundImage"), System.Drawing.Image)
        Me.btnKeyEntry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnKeyEntry.FlatAppearance.BorderSize = 10
        Me.btnKeyEntry.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnKeyEntry.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeyEntry.ForeColor = System.Drawing.Color.Red
        Me.btnKeyEntry.Location = New System.Drawing.Point(135, 37)
        Me.btnKeyEntry.Name = "btnKeyEntry"
        Me.btnKeyEntry.Size = New System.Drawing.Size(126, 76)
        Me.btnKeyEntry.TabIndex = 3
        Me.btnKeyEntry.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnKeyEntry.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnKeyEntry.UseVisualStyleBackColor = True
        '
        'frmMainMenuNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(853, 552)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.MenuStrip2)
        Me.Name = "frmMainMenuNew"
        Me.Text = "frmMainMenuNew"
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip2 As MenuStrip
    Friend WithEvents mnuInput As ToolStripMenuItem
    Friend WithEvents mnuInputKeyEntry As ToolStripMenuItem
    Friend WithEvents mnuInputPaperArchive As ToolStripMenuItem
    Friend WithEvents mnuAccessories As ToolStripMenuItem
    Friend WithEvents mnuAccessoriesDewPointRH As ToolStripMenuItem
    Friend WithEvents mnuAccessoriesXMLOutput As ToolStripMenuItem
    Friend WithEvents UserRecordsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents mnuProducts As ToolStripMenuItem
    Friend WithEvents mnuQC As ToolStripMenuItem
    Friend WithEvents mnuAdministration As ToolStripMenuItem
    Friend WithEvents UserAdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MetadataToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DataFormsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateElementsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UpdateObservationsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents OpeartionsMonitoringToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EmptyKeyEntryTablesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ChangeOwnPasswordToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuTools As ToolStripMenuItem
    Friend WithEvents mnuToolsModifyForms As ToolStripMenuItem
    Friend WithEvents SelectLanguageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerlSettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SequencerConfigurationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HourlyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DailyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MonthlyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormHourlyTimeSelectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AWSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AWSElementsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AWSStationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ConfigurationForTDCFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuLanguageTranslation As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuHelpContents As ToolStripMenuItem
    Friend WithEvents mnuHelpAbout As ToolStripMenuItem
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCloseButton As Button
    Friend WithEvents btnSettingsAWS As Button
    Friend WithEvents btnMetadata As Button
    Friend WithEvents btnUserManagement As Button
    Friend WithEvents btnProducts As Button
    Friend WithEvents btnQC As Button
    Friend WithEvents btnDataTransfer As Button
    Friend WithEvents btnPaperArchive As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents btnKeyEntry As Button
    Friend WithEvents BindingSource1 As BindingSource
End Class
