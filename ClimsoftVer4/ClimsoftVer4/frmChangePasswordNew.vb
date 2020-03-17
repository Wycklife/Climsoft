Public Class frmChangePasswordNew

    Private Sub frmChangePasswordNew_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        btnOK.Enabled = IsValidUsername(False) AndAlso IsValidPassword(False)
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtNewPassword.TextChanged, txtConfirmPassword.TextChanged
        btnOK.Enabled = IsValidUsername(False) AndAlso IsValidPassword(False)
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim objOperator As New ClsOperator

        If Not IsValidUsername(True) OrElse IsValidPassword(True) Then
            Exit Sub
        End If

        'if it's the current user then just change the password and save
        If ClsGlobals.objOperatorInstance.GetOperatorUserName = txtUsername.Text Then

            If ClsGlobals.objOperatorInstance.ChangePassword(txtNewPassword.Text) AndAlso ClsGlobals.objOperatorInstance.SaveOperator() Then
                MsgBox("New password set for '" & txtUsername.Text)
            Else
                MsgBox("Password for '" & txtUsername.Text & "' NOT set ")
            End If

        Else
            'get the operator with the given username. then change the password 
            If objOperator.FetchByOperatorUsername(txtUsername.Text) Then

                If objOperator.ChangePassword(txtNewPassword.Text) AndAlso ClsGlobals.objOperatorInstance.SaveOperator() Then
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
        If String.IsNullOrWhiteSpace(txtUsername.Text) Then
            If Not bValidateSilently Then
                'todo. give feedback
            End If
            Return False
        End If

        'todo. do more validations like if username exists in the database or not, characters allowed

        Return True
    End Function

    Public Function IsValidPassword(Optional bValidateSilently As Boolean = False) As Boolean
        If String.IsNullOrWhiteSpace(txtNewPassword.Text) Then
            If Not bValidateSilently Then
                MsgBox("Enter password")
            End If
            Return False
        End If

        If String.IsNullOrWhiteSpace(txtConfirmPassword.Text) Then
            If Not bValidateSilently Then
                MsgBox("Enter confirmation password")
            End If
            Return False
        End If

        If txtNewPassword.Text <> txtConfirmPassword.Text Then
            If Not bValidateSilently Then
                MsgBox("Wrong confirmation of password!")
            End If
            Return False
        End If

        If txtNewPassword.Text < 6 Then
            If Not bValidateSilently Then
                MsgBox("Password length must be >=6 characters!")
            End If
            Return False
        End If



        'todo. do more validations like regular expressions for characters allowed

        Return True
    End Function



End Class