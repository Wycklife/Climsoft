Public Class frmChangePasswordNew

    Private Sub frmChangePasswordNew_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub txt_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged, txtNewPassword.TextChanged, txtConfirmPassword.TextChanged
        btnOK.Enabled = IsValidUsername(False) AndAlso IsValidPassword(False)
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim objOperator As New ClsOperator

        If Not IsValidUsername(True) OrElse IsValidPassword(True) Then
            Exit Sub
        End If

        'todo. implement as climsoft database action
        'if it's the current user then just change the password and save
        If ClsGlobals.objOperatorInstance.GetOperatorUserName = txtUsername.Text Then

            If ClsGlobals.objOperatorInstance.ChangePassword(txtNewPassword.Text) Then
                MsgBox("New password set for '" & txtUsername.Text)
            Else
                MsgBox("Password for '" & txtUsername.Text & "' NOT set ")
            End If

        Else
            'get the operator with the given username. then change the password 
            If objOperator.FetchByOperatorUsername(txtUsername.Text) Then

                If objOperator.ChangePassword(txtNewPassword.Text) Then
                    MsgBox("New password set for '" & txtUsername.Text)
                Else
                    MsgBox("Password for '" & txtUsername.Text & "' NOT set ")
                End If

            Else
                MsgBox("username NOT found")
            End If

        End If


    End Sub


    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Help.ShowHelp(Me, Application.StartupPath & "\climsoft4.chm", "changepassword.htm#userspassword")
    End Sub

    Public Function IsValidUsername(Optional bValidateSilently As Boolean = False) As Boolean
        Return ClsGlobals.objOperatorInstance.ValidateUsernameCharacters(txtUsername.Text, bValidateSilently)
    End Function

    Public Function IsValidPassword(Optional bValidateSilently As Boolean = False) As Boolean
        'just used the logged in user to validate if the password is valid
        Return ClsGlobals.objOperatorInstance.ValidatePassword(txtNewPassword.Text, txtConfirmPassword.Text, bValidateSilently)
    End Function



End Class