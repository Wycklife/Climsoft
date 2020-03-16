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
        'todo. use the data save the updated details of the operator
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

End Class
