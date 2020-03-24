' CLIMSOFT - Climate Database Management System
' Copyright (C) 2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports ClimsoftVer4.Translations
Public Class frmMainMenuNew
    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles Me.Load

        'Disable controls that do not correspond to the user role
        mnuAdministration.Enabled = ClsGlobals.objOperatorInstance.GetPermission.IsMenuAdministrationEnabled
        mnuTools.Enabled = ClsGlobals.objOperatorInstance.GetPermission.IsMenuToolsEnabled
        mnuLanguageTranslation.Enabled = ClsGlobals.objOperatorInstance.GetPermission.IsMenuLanguageTranslationsEnabled
        mnuQC.Enabled = ClsGlobals.objOperatorInstance.GetPermission.IsMenuQCsEnabled
        mnuProducts.Enabled = ClsGlobals.objOperatorInstance.GetPermission.IsMenuProductsEnabled
        mnuInputKeyEntry.Enabled = ClsGlobals.objOperatorInstance.GetPermission.IsMenuKeyEntryEnabled
        mnuInputPaperArchive.Enabled = ClsGlobals.objOperatorInstance.GetPermission.IsMenuPaperArchiveEnabled

        btnKeyEntry.Enabled = ClsGlobals.objOperatorInstance.GetPermission.IsMenuKeyEntryEnabled
        btnPaperArchive.Enabled = ClsGlobals.objOperatorInstance.GetPermission.IsMenuPaperArchiveEnabled
        btnDataTransfer.Enabled = ClsGlobals.objOperatorInstance.GetPermission.IsMenuDatatransferEnabled
        btnSettingsAWS.Enabled = ClsGlobals.objOperatorInstance.GetPermission.IsMenuSettingsAwsEnabled
        btnUserManagement.Enabled = ClsGlobals.objOperatorInstance.GetPermission.IsMenuUserManagementEnabled
        btnQC.Enabled = ClsGlobals.objOperatorInstance.GetPermission.IsMenuQCsEnabled
        btnProducts.Enabled = ClsGlobals.objOperatorInstance.GetPermission.IsMenuProductsEnabled
        btnMetadata.Enabled = ClsGlobals.objOperatorInstance.GetPermission.IsMenuMetadataEnabled

        frmGeneral.HTMLHelp.HelpPage = "welcome.htm"

    End Sub


    Private Sub btnKeyEntry_Click(sender As Object, e As EventArgs) Handles btnKeyEntry.Click
        frmDataEntryNew.ShowDialog()
    End Sub

    Private Sub btnPaperArchive_Click(sender As Object, e As EventArgs) Handles btnPaperArchive.Click
        formPaperArchive.Show()
    End Sub

    Private Sub btnDataTransfer_Click(sender As Object, e As EventArgs) Handles btnDataTransfer.Click
        frmDBUtilities.ShowDialog()
    End Sub

    Private Sub btnQC_Click(sender As Object, e As EventArgs) Handles btnQC.Click
        frmQC.ShowDialog()
    End Sub

    Private Sub btnProducts_Click(sender As Object, e As EventArgs) Handles btnProducts.Click
        frmProducts.ShowDialog()
    End Sub

    Private Sub btnUserManagement_Click(sender As Object, e As EventArgs) Handles btnUserManagement.Click
        'frmUsers.Show()
        frmUserManagement.Show()
    End Sub

    Private Sub btnMetadata_Click(sender As Object, e As EventArgs) Handles btnMetadata.Click
        'frmLaunchPad.ShowDialog()
        formMetadata.Show()
    End Sub

    Private Sub btnSettingsAWS_Click(sender As Object, e As EventArgs) Handles btnSettingsAWS.Click
        formAWSRealTime.Show()
    End Sub

    Private Sub btnRedCloseButton_Click(sender As Object, e As EventArgs) Handles btnCloseButton.Click
        Application.Exit()
    End Sub


    ' Methods for menu items.
    ' Input Menu items
    Private Sub mnuInputKeyEntry_Click(sender As Object, e As EventArgs) Handles mnuInputKeyEntry.Click
        frmDataEntryNew.ShowDialog()
    End Sub

    Private Sub mnuInputPaperArchive_Click(sender As Object, e As EventArgs) Handles mnuInputPaperArchive.Click
        formPaperArchive.Show()
    End Sub

    ' Accessories Menu items
    Private Sub mnuAccessoriesDewPointRH_Click(sender As Object, e As EventArgs) Handles mnuAccessoriesDewPointRH.Click
        FrmConversionDewPointRh.Show()
    End Sub

    ' QC Menu items
    Private Sub mnuQC_Click(sender As Object, e As EventArgs) Handles mnuQC.Click
        frmQC.ShowDialog()
    End Sub

    ' Products menu items
    Private Sub ProductsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuProducts.Click
        frmProducts.ShowDialog()
    End Sub

    ' Administration Menu items
    ' (currently not implemeted)

    ' Tools Menu Items
    Private Sub mnuToolsOptions_Click(sender As Object, e As EventArgs)
        formOptions.Show()
    End Sub

    Private Sub SelectLanguageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectLanguageToolStripMenuItem.Click
        frmLanguage.ShowDialog()
        ' When dialog is closed - update language in this window (will any other windows also be open?)
        autoTranslate(Me)
    End Sub

    ' Help Menu Items
    Private Sub mnuHelpContents_Click(sender As Object, e As EventArgs) Handles mnuHelpContents.Click
        'HTMLHelp.HelpPage = "aboutclimsoft4.htm"
        Help.ShowHelp(Me, Application.StartupPath & "\" & frmGeneral.HelpProvider1.HelpNamespace, frmGeneral.HTMLHelp.HelpPage)
    End Sub

    Private Sub DataFormsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataFormsToolStripMenuItem.Click
        frmDataFormsNew.Show()
    End Sub

    Private Sub GenerlSettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GenerlSettingsToolStripMenuItem.Click
        frmGeneralSettings.Show()
    End Sub

    Private Sub DailyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DailyToolStripMenuItem.Click
        frmElementSequencerHourly.Show()
    End Sub

    Private Sub FormHourlyTimeSelectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormHourlyTimeSelectionToolStripMenuItem.Click
        frmHourlyTimeSelection.Show()
    End Sub

    Private Sub HourlyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HourlyToolStripMenuItem.Click
        frmElementSequencerDaily.Show()
    End Sub

    Private Sub LanguageTranslationToolStripMenuItem_Click(sender As Object, e As EventArgs)
        frmLanguageTranslation.Show()
    End Sub

    Private Sub PasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PasswordToolStripMenuItem.Click
        frmChangePasswordNew.Show()
    End Sub

    Private Sub ChangeOwnPasswordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeOwnPasswordToolStripMenuItem.Click
        frmChangeOwnPassword.Show()
    End Sub

    Private Sub mnuLanguageTranslation_Click(sender As Object, e As EventArgs) Handles mnuLanguageTranslation.Click
        frmLanguageTranslation.Show()
    End Sub

    Private Sub UserAdminToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserAdminToolStripMenuItem.Click
        frmUserManagement.Show()
    End Sub

    Private Sub AWSElementsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AWSElementsToolStripMenuItem.Click
        frmAWSelements.Show()
    End Sub

    Private Sub AWSStationsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AWSStationsToolStripMenuItem.Click
        frmAWSstations.Show()
    End Sub

    Private Sub ConfigurationForTDCFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfigurationForTDCFToolStripMenuItem.Click
        'With frmSynopTDCF
        '    .TabProcessing.SelectedTab = .TabSettings
        '    .TabProcess.Hide()
        '    .Show()
        '    '.TabProcess.Refresh()
        'End With

        frmTDCFindicators.Show()
    End Sub

    Private Sub MetadataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MetadataToolStripMenuItem.Click
        formMetadata.Show()
    End Sub

    Private Sub UpdateObservationsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UpdateObservationsToolStripMenuItem1.Click
        frmModifyObservations.Show()
    End Sub

    Private Sub OpeartionsMonitoringToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpeartionsMonitoringToolStripMenuItem.Click
        frmMonitoring.Show()
    End Sub

    Private Sub UserRecordsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles UserRecordsToolStripMenuItem1.Click
        'todo. check on what this does
        With frmMonitoring
            .grpPerformance.Enabled = False
            .grpVerify.Enabled = False
            .grpSettings.Enabled = False
            .optAll.Enabled = False
            .cboUser.Enabled = False
            .cboUser.Text = frmLogin.txtUsername.Text
            .optUsers.Enabled = False
            .Show()
        End With
    End Sub

    Private Sub frmMainMenu_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        'closes the opened database connection
        clsDataConnection.CloseConnection()
    End Sub

    Private Sub MonthlyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonthlyToolStripMenuItem.Click
        frmElementSequencerMonthly.Show()
    End Sub

    Private Sub EmptyKeyEntryTablesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmptyKeyEntryTablesToolStripMenuItem.Click
        frmEntryForms.Show()
    End Sub
End Class