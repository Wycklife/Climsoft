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

        'todo. implement as climsoft database action
        If ClsGlobals.objOperatorInstance.ChangePassword(txtNewPassword.Text) Then
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
        'just used the logged in user to validate if the password is valid
        Return ClsGlobals.objOperatorInstance.ValidatePassword(txtNewPassword.Text, txtConfirmPassword.Text, bValidateSilently)
    End Function

End Class