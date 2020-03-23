Public Class ClsOperator
    Private iOperatorId As Integer
    Private strOperatorUserName As String
    Private objOperatorDataStructure As Object
    Private objPermission As ClsPermission
    Private Shared bLoggedIn As Boolean = False

    Public Function IsLoggedIn() As Boolean
        Return bLoggedIn
    End Function

    Public Function GetOperatorId() As Integer
        Return iOperatorId
    End Function

    Public Function GetOperatorUserName() As String
        Return strOperatorUserName
    End Function

    Public Function GetPermission() As ClsPermission
        Return objPermission
    End Function

    Public Function SaveOperator() As Boolean
        'todo. use the data save the updated details of the operator
        Return True
    End Function

    Public Function ChangePassword(strNewPassword As String) As Boolean
        'todo. change the password in the database tbhrough the datastructure


        Return True
    End Function

    Public Function Login(strUsername As String, strPassword As String) As Boolean
        'todo. authenticate the operator in the database
        'todo. then get the operator details 
        'todo. set logged in flag to true on successful login
        bLoggedIn = True
        Return True
    End Function

    Public Function FetchByOperatorUsername(strUsername As String) As Boolean
        'todo. fetch the operator by username then get the operator details
        Return True
    End Function

    Public Function ValidateUsernameCharacters(strUsername As String, Optional bValidateSilently As Boolean = False) As Boolean
        If String.IsNullOrWhiteSpace(strUsername) Then
            If Not bValidateSilently Then
                MsgBox("Enter username")
            End If
            Return False
        End If

        'check if the characters are allowed

        Return True
    End Function

    Public Function ValidatePassword(strPassword As String, Optional strConfirmedPassword As String = Nothing, Optional bValidateSilently As Boolean = False) As Boolean
        If String.IsNullOrWhiteSpace(strPassword) Then
            If Not bValidateSilently Then
                MsgBox("Enter password")
            End If
            Return False
        End If

        'if there is a confirmation password then validate it too
        If Not IsNothing(strConfirmedPassword) Then
            If String.IsNullOrWhiteSpace(strConfirmedPassword) Then
                If Not bValidateSilently Then
                    MsgBox("Enter confirmation password")
                End If
                Return False
            End If

            If strPassword <> strConfirmedPassword Then
                If Not bValidateSilently Then
                    MsgBox("Wrong confirmation of password!")
                End If
                Return False
            End If

        End If

        If strPassword < 6 Then
            If Not bValidateSilently Then
                MsgBox("Password length must be >=6 characters!")
            End If
            Return False
        End If



        'todo. do more validations like regular expressions for characters allowed

        Return True
    End Function

End Class
