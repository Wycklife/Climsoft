Public Class ucrAction

    Public Event EvtDoAction(sender As Object, iActionTypeId As Integer, iActionOperator As Integer)
    Public Property ActionTypeId() As Integer
    Protected enumPermissionType As ClsGlobals.PermissionTypes

    Private Sub ucrAction_Load(sender As Object, e As EventArgs) Handles Me.Load
        'todo set the permission type name from the global operator instance
        enumPermissionType = ClsGlobals.objOperatorInstance.GetPermission().GetPermissionType(ActionTypeId)

        If enumPermissionType = ClsGlobals.PermissionTypes.Disabled Then
            Me.Enabled = False
        Else
            Me.Enabled = True
        End If



    End Sub


    Public Sub OnEvtDoAction(sender As Object, iActionTypeId As Integer, iActionOperatorId As Integer)
        RaiseEvent EvtDoAction(sender, iActionTypeId, iActionOperatorId)
    End Sub


End Class
