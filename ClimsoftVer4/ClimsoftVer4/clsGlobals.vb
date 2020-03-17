Public Class ClsGlobals
    Public Shared objOperatorInstance As New ClsOperator

    Public Enum PermissionTypes
        Enabled = 1
        Disabled = 2
        WithApproval = 3
        SameOperator = 4
        WithApprovalSameOperator = 5
    End Enum



    Public Enum EnumValidationType
        Exist = 1
        Flag = 2
        Numeric = 3
        None = 4
    End Enum

    Public Enum EnumActionCode
        Update = 1
        Delete = 2
        AddNew = 3
        Save = 4
    End Enum


End Class
