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
Public Class frmLoginNew
    Public HTMLHelp As New clsHelp

    Private Sub frmLoginNew_Load(sender As Object, e As EventArgs) Handles Me.Load
        '-------Code for translation added 20160207,ASM
        'Translate text for controls on login form.
        'Other Translation after successful login will come from language translation table stored in database

        msgKeyentryFormsListUpdated = "List of key-entry forms updated!"
        msgStationInformationNotFound = "Station information Not found. Please add station information And try again!"

        Dim lanCulture As String
        lanCulture = System.Globalization.CultureInfo.CurrentCulture.Name
        If Strings.Left(lanCulture, 2) = "en" Then
            ' MsgBox("Current language Is: English-UK")
            Me.Text = "Login"
            lblUsername.Text = "User name:"
            lblPassword.Text = "Password:"
            'lblDbdetails.Text = "Show and Configure Database Connection....."
            btnOk.Text = "OK"
            btnCancel.Text = "Cancel"
        ElseIf Strings.Left(lanCulture, 2) = "fr" Then
            Me.Text = "s'identifier"
            lblUsername.Text = "Nom d'utilisateur:"
            lblPassword.Text = "Mot de passe:"
            'lblDbdetails.Text = "Afficher et configurer la base de données de connexion....."
            btnOk.Text = "OK"
            btnCancel.Text = "Annuler"
        ElseIf Strings.Left(lanCulture, 2) = "de" Then
            Me.Text = "Anmeldung"
            lblUsername.Text = "Benutzername:"
            lblPassword.Text = "Passwort:"
            'lblDbdetails.Text = "Anzeige und Konfiguration der Verbindungsdatenbank....."
            btnOk.Text = "OK"
            btnCancel.Text = "Stornieren"
        ElseIf Strings.Left(lanCulture, 2) = "pt" Then
            Me.Text = "Entrar"
            lblUsername.Text = "Nome de usuário:"
            lblPassword.Text = "Senha:"
            'lblDbdetails.Text = "Mostrar e configurar o banco de dados de conexão....."
            btnOk.Text = "OK"
            btnCancel.Text = "Cancelar"
        End If

        If My.Settings.rememberUsername Then
            chkRememberUsername.Checked = True
            txtUsername.Text = My.Settings.rememberedUsername
            ' When loading, we have to show the form before we can give password the focus
            Me.Show()
            txtPassword.Focus()
        End If

        RefreshDatabasesAndAddToCombobox()
        SetUpAndOpenDatabaseConnection()
        EnableDisableControlsOnValidConnections()

    End Sub

    Private Sub RefreshDatabasesAndAddToCombobox()
        'dictionary of Key = connection name , Value = "connection details"
        Dim dctConnectionDetails As Dictionary(Of String, String)

        Try
            'Clear and then populate combobox 
            cboDatabases.Items.Clear()

            'Read the configuration file for the latest details
            dctConnectionDetails = clsDataConnection.ReadConnectionDetails

            If dctConnectionDetails.Count > 0 Then
                'set the connection details to be shown by the combobox
                cboDatabases.DataSource = New BindingSource(dctConnectionDetails, Nothing)
                cboDatabases.ValueMember = "Value"
                cboDatabases.DisplayMember = "Key"
                cboDatabases.SelectedIndex = 0
            End If
        Catch
            'todo. display message??
        End Try
    End Sub

    Private Sub SetUpAndOpenDatabaseConnection()

        If cboDatabases.Items.Count < 1 Then
            MsgBox("Please set up database connections in 'manage database connections' ")
            Exit Sub
        End If

        If cboDatabases.SelectedIndex < 0 Then
            MsgBox("Please select a database from the list, or manage database connections")
            Exit Sub
        End If

        'try to open connection 
        Try
            clsDataConnection.OpenNewConnection(cboDatabases.SelectedValue & ";Convert Zero Datetime=True")
            'The connection string has historically been stored in this control
            'So this is set up here because there are other locations in the software that may access this
            frmLogin.txtusrpwd.Text = clsDataConnection.GetConnectionString
        Catch ex As Exception
            If ex.Message.IndexOf("Access denied for user") >= 0 Then
                MsgBox("Access denied. Please try again.")
                ' Move cursor to password box and clear password to encourage the user to try again
                txtPassword.Text = ""
                txtPassword.Select()
            ElseIf ex.Message.IndexOf("Unable to connect") >= 0 Then
                MsgBox("Unable to connect to database, please test database connection using " &
                       """Manage database connections""")
            Else
                MsgBox("Login failed: " & ex.Message)
            End If
        End Try
    End Sub

    Private Sub EnableDisableControlsOnValidConnections()
        If clsDataConnection.IsValidConnection Then
            cboDatabases.BackColor = Color.Green
            txtUsername.Enabled = True
            txtPassword.Enabled = True
            btnOk.Enabled = True
            btnCancel.Enabled = True
        Else
            cboDatabases.BackColor = Color.Red
            txtUsername.Enabled = False
            txtPassword.Enabled = False
            btnOk.Enabled = False
            btnCancel.Enabled = False
        End If
    End Sub

    Public Sub UpdateRememberedUsername()
        ' Check whether the username should be saved for next time and update accordingly
        If chkRememberUsername.Checked Then
            My.Settings.rememberUsername = True
            My.Settings.rememberedUsername = txtUsername.Text
        Else
            My.Settings.rememberUsername = False
            My.Settings.rememberedUsername = ""
        End If

        My.Settings.Save()
    End Sub

    Sub climsoftuserRoles()
        'Set SQL for populating user roles
        rolesSQL = "SELECT * from climsoftusers"
        daClimsoftUserRoles = New MySql.Data.MySqlClient.MySqlDataAdapter(rolesSQL, clsDataConnection.OpenedConnection)
        daClimsoftUserRoles.Fill(dsClimsoftUserRoles, "userRoles")
    End Sub

    Sub languageTableInit()
        'Set SQL string for populating "regData" dataset
        languageTableSQL = "SELECT * from language_translation"     '
        daLanguageTable = New MySql.Data.MySqlClient.MySqlDataAdapter(languageTableSQL, clsDataConnection.OpenedConnection)
        daLanguageTable.Fill(dsLanguageTable, "languageTranslation")
    End Sub

    Sub regDataInit()
        'Set SQL string for populating "regData" dataset
        regSQL = "SELECT keyName,keyValue FROM regkeys"     '
        daReg = New MySql.Data.MySqlClient.MySqlDataAdapter(regSQL, clsDataConnection.OpenedConnection)
        daReg.Fill(dsReg, "regData")
    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Dim strPassword As String
        Dim strUsername As String

        Try
            strUsername = txtUsername.Text
            strPassword = txtPassword.Text

            'Ensure username and password are not empty
            If String.IsNullOrEmpty(strUsername) OrElse String.IsNullOrEmpty(strPassword) Then
                MsgBox("Please enter a username and password")
                Exit Sub
            End If

            If Not clsDataConnection.IsValidConnection Then
                MsgBox("Please set up a valid database connection")
                Exit Sub
            End If

            'instantiate operator and validate username and password
            'ClsGlobals.objOperatorInstance = New ClsOperator()
            If Not ClsGlobals.objOperatorInstance.Login(strUsername, strPassword) Then
                MsgBox("Access denied. Wrong username or password. Please try again.")
                'Move cursor to password box and clear password to encourage the user to try again
                txtPassword.Text = ""
                txtPassword.Select()
                Exit Sub
            End If

            UpdateRememberedUsername()

            regDataInit()
            languageTableInit()
            climsoftuserRoles()
            frmSplashScreen.Show()
            Me.Hide()
        Catch ex As Exception
            'todo. display a message
        End Try

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        'Me.Close() ??
        Application.Exit()
    End Sub

    Private Sub lblDbdetails_Click(sender As Object, e As EventArgs) Handles lblDbdetails.Click
        'If My.User.IsInRole(ApplicationServices.BuiltInRole.Administrator) Or My.Computer.Keyboard.CtrlKeyDown Then
        '    frmDatabaseConnections.ShowDialog()
        'Else
        '    MsgBox("You must be an Administrator in order to manage database connections. When starting the program, right-click on the Climsoft icon and choose ""Run as administrator""")
        '    ' It's useful to refresh the databases here so that you don't need to restart if reg has been updated externally
        '    refreshDatabases()
        'End If
        frmDatabaseConnections.ShowDialog()
        RefreshDatabasesAndAddToCombobox()
        SetUpAndOpenDatabaseConnection()
    End Sub

    Private Sub btndHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Help.ShowHelp(Me, Application.StartupPath & "\climsoft4.chm", "login.htm")
    End Sub

    Private Sub chkRememberUsername_CheckedChanged(sender As Object, e As EventArgs) Handles chkRememberUsername.CheckedChanged
        UpdateRememberedUsername()
    End Sub

    Private Sub cboDatabases_DropDownClosed(sender As Object, e As EventArgs) Handles cboDatabases.DropDownClosed
        SetUpAndOpenDatabaseConnection()
    End Sub

End Class