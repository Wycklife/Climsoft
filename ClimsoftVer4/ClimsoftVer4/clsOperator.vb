Public Class clsOperator
    Private iOperatorId As Integer
    Private strOperatorName As String
    Private objOperatorDataStructure As Object
    Private objPermission As clsPermission


    Public Function GetOperatorId() As Integer
        Return iOperatorId
    End Function

    Public Function GetOperatorName() As String
        Return strOperatorName
    End Function

    Public Function GetPermission() As Object
        Return objPermission
    End Function

    Public Function SaveOperator() As Boolean
        'todo. use the data save the updated details of the operator
        Return False
    End Function

    Public Function Login() As Boolean
        'todo.authenticate the operator in the database
        'todo. then get the operator details 

        Return True
    End Function

End Class
