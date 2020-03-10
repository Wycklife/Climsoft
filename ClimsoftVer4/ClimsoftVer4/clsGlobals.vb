Public Class ClsGlobals
    Public Shared objOperatorInstance As ClsOperator 'this is instantiated during the login

    Public Enum PermissionTypes
        Enabled = 1
        Disabled = 2
        DataOwner = 3
        WithPermission = 4
        WithPermissionDataOwner = 5
    End Enum

End Class
