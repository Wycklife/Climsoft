Public Class ucrDatePickerNew
    Protected Overridable Sub ucrDatePicker_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            'SetDateFormat("")   Default is not format (empty).
            bFirstLoad = False
        End If
    End Sub
    Public Overrides Function IsEmpty() As Boolean
        Return True 'to be overidden by the child controls
    End Function

    Public Overrides Sub Clear()
        'TODO Have the date picker reset to its default date
    End Sub

    Public Overrides Function ValidateValue() As Boolean
        'TODO Validate the value if the date text box is not empty and return true if the value is valid or false if the value is invalid
        'TODO there should also be changing of color in the text text box when the text is valid or invalid.This can be done throught the function SetBackColor()
        Return True
    End Function
    Public Overrides Sub GetFocus()
        '
    End Sub

    Public Overrides Sub GetValidationParametersFromDataStructure()
        'todo. gets the validation parameters from the datastructure
    End Sub

    Public Overrides Sub SetValueFromDataStructure()
        'todo. reads value from the datastructure
    End Sub

    Public Overrides Sub SetValueToDataStructure()
        'todo. writes value to the datastructure
    End Sub

    Public Overrides Function GetValue(Optional objSpecification As Object = Nothing) As Object
        'gets the value of the control.
        'Possibly pass in a parameter that specifies the value to get incase the control has more than one value
        Return Nothing
    End Function

    Public Sub SetDateFormat(strNewDateFormat As String)
        'TODO set the default format of the date
    End Sub
    Private Sub txtDate_Leave(sender As Object, e As EventArgs) Handles txtDate.Leave
        If ValidateValue() Then
            SetValue(txtDate.Text)
        End If
        OnevtValueChanged(Me, e)
    End Sub

    Public Sub SetValueReturnTypeAsString()
        'TODO sets the date value as a string type
    End Sub

    Public Sub SetValueReturnTypeAsDate()
        'TODO sets the date value as a Date type
    End Sub
    Public Overrides Sub SetBackColor(backColor As Color)
        txtDate.BackColor = backColor
    End Sub
End Class
