Public Class ClsPermission

    Private objPermissionDataStructure As Object


    Public Function GetPermissionType(iActionTypeId As Integer) As ClsGlobals.PermissionTypes
        'todo. get the permission type name from the PermissionDataStructure

        Return ClsGlobals.PermissionTypes.Disabled
    End Function


    Public Function IsMenuAdministrationDisabled() As Boolean
        'todo.
        Return False
    End Function

    Public Function IsMenuToolsDisabled() As Boolean
        'todo.
        Return False
    End Function

    Public Function IsMenuLanguageTranslationsDisabled() As Boolean
        'todo.
        Return False
    End Function

    Public Function IsMenuQCsDisabled() As Boolean
        'todo.
        Return False
    End Function

    Public Function IsMenuSettingsAwsDisabled() As Boolean
        'todo.
        Return False
    End Function

    Public Function IsMenuUserManagementDisabled() As Boolean
        'todo.
        Return False
    End Function

    Public Function IsMenuProductsDisabled() As Boolean
        'todo.
        Return False
    End Function

    Public Function IsMenuMetadataDisabled() As Boolean
        'todo.
        Return False
    End Function

    Public Function IsMenuDatatransferDisabled() As Boolean
        'todo.
        Return False
    End Function

    Public Function IsMenuKeyEntryDisabled() As Boolean
        'todo.
        Return False
    End Function

    Public Function IsMenuPaperArchiveDisabled() As Boolean
        'todo.
        Return False
    End Function

    Public Function IsVisibleFormDaily2() As Boolean
        'todo. use the datastrucre to determine if formDaily2 should be visible or not
        Return False
    End Function



End Class
