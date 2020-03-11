Public Class ucrButton

    Public Property ButtonText() As String
        Get
            Return btn.Text
        End Get
        Set(value As String)
            Me.btn.Text = value
        End Set
    End Property

    Private Sub Btn_Click(sender As Object, e As EventArgs) Handles btn.Click
        Dim iActionOperatorId As Integer = -1
        Dim objTempOperator As ClsOperator

        'set the operator id for the validated operator responsible for the action 
        If enumPermissionType = ClsGlobals.PermissionTypes.Disabled Then
            'todo. display a message 
            Exit Sub
        End If

        If enumPermissionType = ClsGlobals.PermissionTypes.SameOperator OrElse enumPermissionType = ClsGlobals.PermissionTypes.WithApprovalSameOperator Then
            'todo. check if the current operator is the one who entered the data. if true then do the following
            If True Then
                iActionOperatorId = ClsGlobals.objOperatorInstance.GetOperatorId
            Else
                If enumPermissionType = ClsGlobals.PermissionTypes.SameOperator Then
                    'todo. display a message 
                    Exit Sub
                End If
            End If
        End If

        If enumPermissionType = ClsGlobals.PermissionTypes.WithApproval OrElse (iActionOperatorId < 0 AndAlso enumPermissionType = ClsGlobals.PermissionTypes.WithApprovalSameOperator) Then
            'todo. prompt the user to supply the credentials for an authorised operator in objTempOperator
            'todo. if credentials are correct and has permission then true
            If True Then
                iActionOperatorId = objTempOperator.GetOperatorId
            Else
                'todo. display a message 
                Exit Sub
            End If
        End If

        If iActionOperatorId < 0 Then
            If enumPermissionType = ClsGlobals.PermissionTypes.Enabled Then
                iActionOperatorId = ClsGlobals.objOperatorInstance.GetOperatorId
            Else
                'todo. display a developer error
                Exit Sub
            End If
        End If

            OnEvtDoAction(Me, ActionTypeId, iActionOperatorId)

    End Sub



End Class
