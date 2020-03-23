Public Class ClsPermission

    Private objPermissionDataStructure As Object


    Public Function GetPermissionType(iActionTypeId As Integer) As ClsGlobals.PermissionTypes
        'todo. get the permission type name from the PermissionDataStructure

        Return ClsGlobals.PermissionTypes.Disabled
    End Function


    Public Function IsMenuAdministrationEnabled() As Boolean
        'todo.
        Return False
    End Function

    Public Function IsMenuToolsEnabled() As Boolean
        'todo.
        Return False
    End Function

    Public Function IsMenuLanguageTranslationsEnabled() As Boolean
        'todo.
        Return False
    End Function

    Public Function IsMenuQCsEnabled() As Boolean
        'todo.
        Return False
    End Function

    Public Function IsMenuSettingsAwsEnabled() As Boolean
        'todo.
        Return False
    End Function

    Public Function IsMenuUserManagementEnabled() As Boolean
        'todo.
        Return False
    End Function

    Public Function IsMenuProductsEnabled() As Boolean
        'todo.
        Return False
    End Function

    Public Function IsMenuMetadataEnabled() As Boolean
        'todo.
        Return False
    End Function

    Public Function IsMenuDatatransferEnabled() As Boolean
        'todo.
        Return False
    End Function

    Public Function IsMenuKeyEntryEnabled() As Boolean
        'todo.
        Return False
    End Function

    Public Function IsMenuPaperArchiveEnabled() As Boolean
        'todo.
        Return False
    End Function

    Public Function IsVisibleFormDaily2() As Boolean
        'todo. use the datastrucre to determine if formDaily2 should be visible or not
        Return False
    End Function



End Class
