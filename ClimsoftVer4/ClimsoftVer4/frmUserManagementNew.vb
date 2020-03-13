Public Class frmUserManagementNew
    Private Sub frmUserManagementNew_Load(sender As Object, e As EventArgs) Handles Me.Load
        PopulateDataGridWithUsers()
    End Sub


    Private Sub txtConfirmPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged, txtConfirmPassword.TextChanged

        btnAddNew.Enabled = ValidateNewUser()

    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click

        If Not ValidateNewUser() Then
            MsgBox("Invalid user credentials")
            Exit Sub
        End If
        'todo. get the permissions of the user role 
        'todo. grant the permissions to the user

        If cboUserRole.Text = "ClimsoftAdmin" Then
        ElseIf cboUserRole.Text = "ClimsoftOperator" Then
        ElseIf cboUserRole.Text = "ClimsoftRainfall" Then
        ElseIf cboUserRole.Text = "ClimsoftOperatorSupervisor" Then
            '4. Operator Supervisor
        ElseIf cboUserRole.Text = "ClimsoftQC" Then
            '5 QC
        ElseIf cboUserRole.Text = "ClimsoftMetadata" Then
            '6. Metadata
        ElseIf cboUserRole.Text = "ClimsoftProducts" Then
            '7. Products
        ElseIf cboUserRole.Text = "ClimsoftDeveloper" Then
            '8. Developer
        ElseIf cboUserRole.Text = "ClimsoftTranslator" Then
            '9. Translator
        End If
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

    Public Function ValidateNewUser() As Boolean
        Return IsValidNewUsername() AndAlso IsValidPassword() AndAlso IsValidUserRole()
    End Function

    Public Function IsValidNewUsername() As Boolean
        If String.IsNullOrWhiteSpace(txtUserName.Text) Then
            Return False
        End If

        'todo. do more validations like if username exists in the database or not, characters allowed

        Return True
    End Function

    Public Function IsValidPassword() As Boolean
        If String.IsNullOrWhiteSpace(txtConfirmPassword.Text) OrElse String.IsNullOrWhiteSpace(txtPassword.Text) OrElse
           txtPassword.Text <> txtConfirmPassword.Text OrElse txtPassword.Text < 6 Then
            Return False
        End If



        'todo. do more validations like regular expressions for characters allowed

        Return True
    End Function

    Public Function IsValidUserRole() As Boolean
        Return cboUserRole.SelectedIndex >= 0
    End Function




End Class