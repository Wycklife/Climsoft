Public Class ucrDatePickerNew
    Private strDateFormat As String
    Private strValueReturnType As String
    Protected Overridable Sub ucrDatePicker_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            SetDateFormat("")
            SetValueReturnTypeAsString()
            'SetDateFormat("")   Default is not format (empty).
            bFirstLoad = False
        End If
    End Sub

    Public Overrides Sub UpdateValueChoices()
        '?TODO probably set value to the control from SetValueFromDataStructure()
    End Sub
    Public Overrides Function ValidateValue() As Boolean
        Dim bValid As Boolean = False

        If bValidate Then
            'if set to not validate empty values and textbox is empty then don't proceed with validation
            If Not bValidateEmpty AndAlso IsEmpty() Then
                SetBackColor(clValidColor)
                Return True
            ElseIf bValidateEmpty AndAlso IsEmpty() Then
                SetBackColor(clInValidColor)
                Return False
            End If

            'TODO. Restrict this also based on the return type
            Try
                Dim dte As DateTime
                If strDateFormat = "" Then
                    dte = DateTime.Parse(txtDate.Text)
                Else
                    dte = DateTime.ParseExact(txtDate.Text, strDateFormat, Nothing)
                End If
                bValid = True
            Catch ex As Exception
                bValid = False
            End Try
        Else
            bValid = True
        End If

        SetBackColor(If(bValid, clValidColor, clInValidColor))
        Return bValid
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
        If String.IsNullOrWhiteSpace(txtDate.Text) Then
            'Return If(strValueReturnType = "date", Nothing, "")
            Return Nothing
        Else
            If strValueReturnType = "date" Then
                If strDateFormat = "" Then
                    Return DateTime.Parse(txtDate.Text)
                Else
                    Return DateTime.ParseExact(txtDate.Text, strDateFormat, Nothing)
                End If
                'Return dtpDate.Value
            Else
                'return date in string format
                Return txtDate.Text
            End If
        End If
    End Function

    Public Overrides Sub SetValue(objNewValue As Object)
        If IsDBNull(objNewValue) OrElse IsNothing(objNewValue) OrElse (TypeOf objNewValue Is String AndAlso String.IsNullOrWhiteSpace(objNewValue)) Then
            txtDate.Text = ""
        Else
            Try
                'TODO. Restrict this also based on the return type not on the object type
                If TypeOf objNewValue Is DateTime Then
                    dtpDate.Value = objNewValue
                    txtDate.Text = If(strDateFormat = "", dtpDate.Value, dtpDate.Value.ToString(strDateFormat))
                Else
                    If strDateFormat = "" Then
                        'will use the systems default date format
                        dtpDate.Value = DateTime.Parse(objNewValue)
                        txtDate.Text = dtpDate.Value
                    Else
                        'use specified date format
                        dtpDate.Value = DateTime.ParseExact(objNewValue, strDateFormat, Nothing)
                        txtDate.Text = dtpDate.Value.ToString(strDateFormat)
                    End If
                End If
            Catch ex As Exception
                txtDate.Text = ""
            End Try
        End If

        OnevtValueChanged(Me, Nothing)
    End Sub


    Public Sub SetDateFormat(strNewDateFormat As String)
        strDateFormat = strNewDateFormat
    End Sub
    Private Sub txtDate_Leave(sender As Object, e As EventArgs) Handles txtDate.Leave
        If ValidateValue() Then
            SetValue(txtDate.Text)
        End If
        OnevtValueChanged(Me, e)
    End Sub

    Public Sub SetValueReturnTypeAsString()
        strValueReturnType = "string"
    End Sub

    Public Sub SetValueReturnTypeAsDate()
        strValueReturnType = "date"
    End Sub
    Public Overrides Sub SetBackColor(backColor As Color)
        txtDate.BackColor = backColor
    End Sub

    Public Overrides Sub Clear()
        'Dim bPrevValidate As Boolean = bValidate
        'bValidate = False
        SetValue("") 'TODO
        SetBackColor(clValidColor)
        'bValidate = bPrevValidate
    End Sub

    Private Sub dtpDate_CloseUp(sender As Object, e As EventArgs) Handles dtpDate.CloseUp
        SetValue(dtpDate.Value)
    End Sub

    Private Sub dtpDatetxtDate_KeyDown(sender As Object, e As KeyEventArgs) Handles dtpDate.KeyDown, txtDate.KeyDown
        OnevtKeyDown(Me, e)
    End Sub


End Class
