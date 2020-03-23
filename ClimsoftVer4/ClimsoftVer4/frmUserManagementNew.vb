Public Class frmUserManagementNew
    Private Sub frmUserManagementNew_Load(sender As Object, e As EventArgs) Handles Me.Load
        PopulateDataGridWithUsers()
    End Sub

    Private Sub txt_TextChanged(sender As Object, e As EventArgs) Handles txtUserName.TextChanged, txtPassword.TextChanged, txtConfirmPassword.TextChanged
        btnAddNew.Enabled = IsValidUsername(False) AndAlso IsValidUserRole(False) AndAlso IsValidPassword(False)
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click

        If Not IsValidUsername(True) OrElse IsValidUserRole(True) OrElse IsValidPassword(True) Then
            Exit Sub
        End If
        'todo. implement as climsoft database action
        'todo. get the permissions of the user role 
        'todo. grant the permissions to the user
        'todo. add the new user



        'If cboUserRole.Text = "ClimsoftAdmin" Then
        'ElseIf cboUserRole.Text = "ClimsoftOperator" Then
        'ElseIf cboUserRole.Text = "ClimsoftRainfall" Then
        'ElseIf cboUserRole.Text = "ClimsoftOperatorSupervisor" Then
        'ElseIf cboUserRole.Text = "ClimsoftQC" Then
        'ElseIf cboUserRole.Text = "ClimsoftMetadata" Then
        'ElseIf cboUserRole.Text = "ClimsoftProducts" Then
        'ElseIf cboUserRole.Text = "ClimsoftDeveloper" Then
        'ElseIf cboUserRole.Text = "ClimsoftTranslator" Then
        'End If


    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Help.ShowHelp(Me, Application.StartupPath & "\climsoft4.chm", "usersmanagement.htm#useraccount")
    End Sub

    Private Sub PopulateDataGridWithUsers()

        'todo. get all the users from the datastructure then populate the grid 

    End Sub


    Public Function IsValidUsername(Optional bValidateSilently As Boolean = False) As Boolean
        'just used the logged in user to validate if the password is valid
        Return ClsGlobals.objOperatorInstance.ValidateUsernameCharacters(txtUserName.Text, bValidateSilently)
    End Function

    Public Function IsValidPassword(Optional bValidateSilently As Boolean = False) As Boolean
        'just used the logged in user to validate if the password is valid
        Return ClsGlobals.objOperatorInstance.ValidatePassword(txtPassword.Text, txtConfirmPassword.Text, bValidateSilently)
    End Function

    Public Function IsValidUserRole(Optional bValidateSilently As Boolean = False) As Boolean
        If cboUserRole.SelectedIndex < 0 Then
            If Not bValidateSilently Then
                MsgBox("Enter a valid user role")
            End If
            Return False
        End If

        Return True
    End Function


End Class