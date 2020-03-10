Public Class ClsGlobals
    Public Shared objOperatorInstance As ClsOperator 'this is instantiated during the login

    Public Enum PermissionTypes
        Enabled = 1
        Disabled = 2
        WithApproval = 3
        SameOperator = 4
        WithApprovalSameOperator = 5
    End Enum

End Class
