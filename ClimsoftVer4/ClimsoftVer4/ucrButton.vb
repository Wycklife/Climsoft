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

        'todo. set the operator id for the validated operator responsible for the action 

        OnEvtDoAction(Me, ActionTypeId, iActionOperatorId)

    End Sub
End Class
