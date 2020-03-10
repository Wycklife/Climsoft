Public Class ucrButton

    Public Property ButtonText() As String
        Get
            Return btn.Text
        End Get
        Set(value As String)
            Me.btn.Text = value
        End Set
    End Property

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        Dim iActionOperatorId As Integer
        Dim tempOperator As ClsOperator


        'todo. set the operator id for the validated operator responsible for the action 
        If enumPermissionType = ClsGlobals.PermissionTypes.Disabled Then
            Exit Sub
        ElseIf enumPermissionType = ClsGlobals.PermissionTypes.DataOwner Then
            'todo. check if the current operator is the one who entered the data. if true then do the following
            iActionOperatorId = ClsGlobals.objOperatorInstance.GetOperatorId
        ElseIf enumPermissionType = ClsGlobals.PermissionTypes.WithPermission Then
            'todo. prompt the user to supply the credentials for an authorised operator
            'todo. if credentials are correct 
            'todo. then set up the temporary operator and get the operator id
            iActionOperatorId = tempOperator.GetOperatorId
        ElseIf enumPermissionType = ClsGlobals.PermissionTypes.WithPermissionDataOwner Then
            'todo
            iActionOperatorId = ClsGlobals.objOperatorInstance.GetOperatorId
        End If

        OnEvtDoAction(Me, ActionTypeId, iActionOperatorId)

    End Sub
End Class
