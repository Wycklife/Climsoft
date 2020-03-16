Public Class ucrCheckboxNew

    Public Overrides Sub UpdateValueChoices()
        If Not bFirstLoad Then
            MyBase.UpdateValueChoices()
            'TODO
        End If
    End Sub

    Public Property CheckBoxText() As String
        Get
            Return chkCheck.Text
        End Get
        Set(value As String)
            chkCheck.Text = value
        End Set
    End Property

    Private Sub ucrCheckboxNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then

            bFirstLoad = False
        End If
    End Sub

    Private Sub chkCheck_KeyDown(sender As Object, e As KeyEventArgs) Handles chkCheck.KeyDown
        OnevtKeyDown(Me, e)
    End Sub

    Private Sub chkCheck_CheckedChanged(sender As Object, e As EventArgs) Handles chkCheck.CheckedChanged
        OnevtValueChanged(Me, e)
    End Sub

    Public Overrides Function GetValue(Optional objSpecification As Object = Nothing) As Object
        'TODO probably do a check to determine if a boolean is the one needed ?
        Return If(chkCheck.Checked, 1, 0)
        Return Nothing
    End Function

    Public Overrides Sub SetValueToDataStructure()
        'todo. writes value to the datastructure
    End Sub

    Public Overrides Sub SetValue(objNewValue As Object)
        If IsDBNull(objNewValue) OrElse IsNothing(objNewValue) Then
            chkCheck.Checked = False
        ElseIf TypeOf objNewValue Is Boolean Then
            chkCheck.Checked = objNewValue
        ElseIf IsNumeric(objNewValue) Then
            chkCheck.Checked = Not (Val(objNewValue) = 0)
        Else
            MessageBox.Show("Developer error: Checkbox can only accept true,false(booleans) or 0,1. Control: " & Me.Name, caption:="Developer error")
        End If
        OnevtValueChanged(Me, Nothing)
    End Sub

    Public Overrides Sub Clear()
        SetValue(False)
    End Sub

End Class
