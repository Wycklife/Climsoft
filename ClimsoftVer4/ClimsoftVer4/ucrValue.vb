Public Class ucrValue
    Protected bFirstLoad As Boolean = True
    Public Event evtKeyDown(sender As Object, e As KeyEventArgs)
    Public Event evtTextChanged(sender As Object, e As EventArgs)
    Public Event evtValueChanged(sender As Object, e As EventArgs)

    ' When True, ValueChanged and TextChanged etc. events will not be raised
    ' Used when wanting to update several controls without linked controls updating inbetween.
    Public bSuppressChangedEvents As Boolean = False

    Protected clValidColor As Color = Color.White 'used to set the default back color to show when the value input is  valid 
    Protected clInValidColor As Color = Color.Red 'used to set the default back color to show when the value input is invalid 
    Public bValidate As Boolean = True 'switches the validation on and off
    Public bValidateSilently As Boolean = True 'this will inhibit showing message boxes when invalid values are written 
    Public bValidateEmpty As Boolean = False
    Protected strValidationType As ClsGlobals.EnumValidationType = ClsGlobals.EnumValidationType.None
    Protected objDefaultValue As Object = Nothing
    Private Sub ucrValue_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Public Property FieldName() As String
        Get
            Return Me.Tag
        End Get
        Set(value As String)
            Me.Tag = value
        End Set
    End Property

    Public Overridable Sub SetDefaultValue(objNewValue As Object)
        objDefaultValue = objNewValue
    End Sub

    Public Function HasDefaultValue() As Boolean
        Return Not IsNothing(GetDefaultValue())
    End Function
    Public Overridable Sub UpdateValueChoices()
        'Todo. get the data from the datastructure
    End Sub
    Public Overridable Function GetDefaultValue() As Object
        Return objDefaultValue
    End Function
    Public Overridable Sub SelectDefaultValue()
        SetValue(GetDefaultValue())
    End Sub
    Public Sub SetDataIdentifier(objDataIdentifier As Object)
        'specifies the identifier that would be usd by the datastructure to get the data 
        'the identifier will have a field name
    End Sub


    Public Overridable Sub GetValidationParametersFromDataStructure()
        'todo. gets the validation parameters from the datastructure
    End Sub

    'this will be the event handler that listens to changes to record in the datastructure
    Private Sub ChangesToRecordInDataStructure(sender As Object, e As EventArgs)
        SetValueFromDataStructure()
    End Sub

    Public Overridable Sub SetValueFromDataStructure()
        'todo. reads value from the datastructure
    End Sub

    Public Overridable Sub SetValueToDataStructure()
        'todo. writes value to the datastructure
    End Sub

    Public Overridable Sub SetValue(objNewValue As Object)
        'todo. Set the value top the control then write it to the datasctrure
    End Sub

    Public Overridable Function GetValue(Optional objSpecification As Object = Nothing) As Object
        'gets the value of the control.
        'Possibly pass in a parameter that specifies the value to get incase the control has more than one value
        Return Nothing
    End Function

    Public Overridable Sub SetBackColor(backColor As Color)
    End Sub

    ''' <summary>
    ''' Sets the default back color for when this control has a valid value
    ''' </summary>
    ''' <param name="backColor"></param>
    Public Sub SetValidColor(backColor As Color)
        clValidColor = backColor
    End Sub

    Public Function GetValidColor() As Color
        Return clValidColor
    End Function

    Public Sub SetInValidColor(backColor As Color)
        clInValidColor = backColor
    End Sub

    Public Function GetInValidColor() As Color
        Return clInValidColor
    End Function

    Public Overridable Sub SetContextMenuStrip(contextMenuStrip As ContextMenuStrip)
        'sets the context menu of the control
    End Sub

    Public Overridable Sub GetFocus()

    End Sub

    Public Overridable Sub Clear()

    End Sub

    Public Overridable Function ValidateValue() As Boolean
        Return True
    End Function

    Public Overridable Function IsValid() As Boolean
        Return True
    End Function

    Public Overridable Function IsEmpty() As Boolean
        Return True 'to be overidden by the child controls
    End Function

    Public Overridable Sub SetAsReadOnly()
        'set th control to read only
    End Sub

    Public Overridable Sub AddFieldstoList(lstFields As List(Of String))
        If Not String.IsNullOrEmpty(FieldName) Then
            lstFields.Add(FieldName)
        End If
    End Sub

    Public Overridable Sub AddEventValueChangedHandle(ehSub As evtValueChangedEventHandler)
        If Not String.IsNullOrEmpty(FieldName) Then
            AddHandler evtValueChanged, ehSub
        End If
    End Sub
    Public Overridable Sub SetValueFromDataTable(dtbValues As DataTable)
        Dim lstTemp As New List(Of Object)
        Dim lstDistinct As New List(Of Object)

        If String.IsNullOrEmpty(FieldName) Then
            SetValue(Nothing)
        Else
            If dtbValues.Rows.Count = 1 Then
                SetValue(dtbValues.Rows(0).Item(FieldName))
            ElseIf dtbValues.Rows.Count > 1 Then
                For Each tempRow As DataRow In dtbValues.Rows
                    lstTemp.Add(tempRow.Item(FieldName))
                Next
                lstDistinct = lstTemp.Distinct().ToList
                If lstDistinct.Count = 1 Then
                    SetValue(lstDistinct(0))
                Else
                    SetValue(lstTemp)
                End If
            Else
                SetValue(Nothing)
            End If
        End If
    End Sub
    Public Overridable Sub SetValueToDataTable(dtbValues As DataTable)
        Dim lstTemp As New List(Of Object)
        Dim lstDistinct As New List(Of Object)

        If String.IsNullOrEmpty(FieldName) Then
            'TODO?
        Else
            If dtbValues.Rows.Count = 1 Then
                If ValidateValue() Then
                    'dtbValues.Rows(0).Item(FieldName) = If(IsNothing(GetValue()), DBNull.Value, GetValue())
                    Try
                        dtbValues.Rows(0).Item(FieldName) = GetValue()
                    Catch ex As ArgumentException
                        dtbValues.Rows(0).Item(FieldName) = DBNull.Value
                    End Try
                Else
                    dtbValues.Rows(0).Item(FieldName) = DBNull.Value
                End If
            ElseIf dtbValues.Rows.Count > 1 Then
                'TODO
            Else
                'TODO
            End If
        End If
    End Sub

    Public Sub OnevtKeyDown(sender As Object, e As KeyEventArgs)
        RaiseEvent evtKeyDown(sender, e)
    End Sub

    Public Sub OnevtTextChanged(sender As Object, e As EventArgs)
        If Not bSuppressChangedEvents Then
            RaiseEvent evtTextChanged(sender, e)
        End If
    End Sub

    Public Sub OnevtValueChanged(sender As Object, e As EventArgs)
        If Not bSuppressChangedEvents Then
            RaiseEvent evtValueChanged(sender, e)
        End If
    End Sub
End Class
