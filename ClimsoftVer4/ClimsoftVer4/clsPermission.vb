Public Class ClsPermission

    Private objPermissionDataStructure As Object


    Public Function GetPermissionType(iActionTypeId As Integer) As ClsGlobals.PermissionTypes
        'todo. get the permission type name from the PermissionDataStructure

        Return ClsGlobals.PermissionTypes.Disabled
    End Function

    Public Function IsVisibleFormDaily2() As Boolean
        'todo. use the datastrucre to determine if formDaily2 should be visible or not
        Return False
    End Function



End Class
