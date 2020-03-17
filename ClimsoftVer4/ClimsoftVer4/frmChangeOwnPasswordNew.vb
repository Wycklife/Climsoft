Public Class frmChangeOwnPasswordNew

    Private Sub frmChangeOwnPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtNewPassword.TextChanged, txtConfirmPassword.TextChanged
        btnOK.Enabled = IsValidPassword(False)
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

        If IsValidPassword(True) Then
            Exit Sub
        End If

        If ClsGlobals.objOperatorInstance.ChangePassword(txtNewPassword.Text) AndAlso ClsGlobals.objOperatorInstance.SaveOperator() Then
            MsgBox("Your new password has been set!")
        Else
            MsgBox("Password NOT set")
        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Help.ShowHelp(Me, Application.StartupPath & "\climsoft4.chm", "changepassword.htm#ownpassword")
    End Sub

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