Public Class ClsOperator
    Private iOperatorId As Integer
    Private strOperatorName As String
    Private objOperatorDataStructure As Object
    Private objPermission As ClsPermission


    Public Function GetOperatorId() As Integer
        Return iOperatorId
    End Function

    Public Function GetOperatorName() As String
        Return strOperatorName
    End Function

    Public Function GetPermission() As ClsPermission
        Return objPermission
    End Function

    Public Function SaveOperator() As Boolean
        'todo. use the data save the updated details of the operator
        Return True
    End Function

    Public Function Login(strUsername As String, strPassword As String) As Boolean
        'todo.authenticate the operator in the database
        'todo. then get the operator details 

        Return True
    End Function

End Class
