Public Class ucrComboboxNew
    Public bFillFromDataBase As Boolean = True

    Protected dcmMinimum As Decimal = Decimal.MinValue
    Protected dcmMaximum As Decimal = Decimal.MaxValue
    Protected bMinimumIncluded, bMaximumIncluded As Boolean
    Protected Overridable Sub ucrCombobox_Load(sender As Object, e As EventArgs) Handles Me.Load
        If clsDataConnection.IsInDesignMode() Then
            Exit Sub ' temporary code to remove the bugs thrown during design time
        End If

        If bFirstLoad Then
            bValidateEmpty = True
            strValidationType = ClsGlobals.EnumValidationType.Exist
            UpdateValueChoices()
            bFirstLoad = False
        End If
        'TODO have the combo box filled by the datatables
        'cboValues.DataSource = dtbRecords
    End Sub

    Protected Overridable Sub ucrComboBoxSelector_Load(sender As Object, e As EventArgs) Handles Me.Load
        If clsDataConnection.IsInDesignMode() Then
            Exit Sub ' temporary code to remove the bugs thrown during design time
        End If

        If bFirstLoad Then
            bValidateEmpty = True
            strValidationType = ClsGlobals.EnumValidationType.Exist
            UpdateValueChoices()
            bFirstLoad = False
        End If
    End Sub

    ''' <summary>
    ''' Populates the controls form the datastructure
    ''' </summary>
    Public Overrides Sub UpdateValueChoices()
        SetValueFromDataStructure()
    End Sub
    Public Sub SetValidationTypeAsNumeric(Optional dcmMin As Decimal = Decimal.MinValue, Optional bIncludeMin As Boolean = True, Optional dcmMax As Decimal = Decimal.MaxValue, Optional bIncludeMax As Boolean = True)
        strValidationType = ClsGlobals.EnumValidationType.Numeric
        If dcmMin <> Decimal.MinValue Then
            dcmMinimum = dcmMin
            bMinimumIncluded = bIncludeMin
        End If
        If dcmMax <> Decimal.MaxValue Then
            dcmMaximum = dcmMax
            bMaximumIncluded = bIncludeMax
        End If
    End Sub
    Private Sub cboValues_KeyDown(sender As Object, e As KeyEventArgs) Handles cboValues.KeyDown
        OnevtKeyDown(Me, e)
    End Sub

    Private Sub cboValues_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboValues.SelectedValueChanged
        OnevtValueChanged(Me, e)
    End Sub

    Private Sub cboValues_TextChanged(sender As Object, e As EventArgs) Handles cboValues.TextChanged
        ValidateValue()
        OnevtTextChanged(Me, e)
    End Sub

    Private Sub cboValues_Leave(sender As Object, e As EventArgs) Handles cboValues.Leave
        'ValidateValue()
        OnevtValueChanged(Me, e)
    End Sub


    Public Overrides Sub SetValueFromDataStructure()
        'todo. reads value from the datastructure
    End Sub

    Public Overrides Sub SetValueToDataStructure()
        'todo. writes value to the datastructure
    End Sub

    ''' <summary>
    ''' Gets the set or selected value of the combobox. if strFieldName is not empty the value of the passed field will be returned
    ''' </summary>
    ''' <param name="objSpecification"></param>
    ''' <returns></returns>
    Public Overrides Function GetValue(Optional objSpecification As Object = Nothing) As Object
        If Not String.IsNullOrEmpty(cboValues.DisplayMember) Then
            If Not String.IsNullOrEmpty(objSpecification) OrElse Not String.IsNullOrEmpty(cboValues.ValueMember) Then
                'TODO datatables were also required for this loop
                'For Each rTemp As DataRow In dtbRecords.Rows
                '    If rTemp.Item(cboValues.DisplayMember).ToString = cboValues.Text Then
                '        If objSpecification = "" Then
                '            'Return cboValues.SelectedValue
                '            'get the value from the value column
                '            Return rTemp.Item(cboValues.ValueMember)
                '        Else
                '            Return rTemp.Item(objSpecification)
                '        End If
                '    End If
                'Next
            End If
        End If

        Return cboValues.Text
    End Function
    Public Overrides Sub Clear()
        SetValue("")
        SetBackColor(clValidColor)
    End Sub

    Public Sub SetValidationTypeAsMustExist()
        strValidationType = ClsGlobals.EnumValidationType.Exist
    End Sub

    Public Overrides Function ValidateValue() As Boolean
        Dim bValid As Boolean = False

        If bValidate Then
            'if set to not validate empty values and textbox is empty then don't proceed with validation
            If Not bValidateEmpty AndAlso IsEmpty() Then
                SetBackColor(clValidColor)
                Return True
            End If

            If strValidationType = ClsGlobals.EnumValidationType.None Then
                bValid = True
                SetBackColor(clValidColor)
            ElseIf strValidationType = ClsGlobals.EnumValidationType.Exist Then
                bValid = False
                If cboValues.DisplayMember <> "" Then
                    'TODO have the datatable for this loop 
                    'For Each rTemp As DataRow In dtbRecords.Rows
                    '    If rTemp.Item(cboValues.DisplayMember).ToString = cboValues.Text Then
                    '        bValid = True
                    '        Exit For
                    '    End If
                    'Next
                End If
                SetBackColor(If(bValid, clValidColor, clInValidColor))
            ElseIf strValidationType = ClsGlobals.EnumValidationType.Numeric Then
                Dim iValidationCode As Integer = ValidateNumeric(cboValues.Text)
                Select Case iValidationCode
                    Case 0
                        bValid = True
                        SetBackColor(clValidColor)
                    Case 1
                        bValid = False
                        SetBackColor(clInValidColor)
                        If Not bValidateSilently Then
                            MessageBox.Show("Number expected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    Case 2
                        bValid = False
                        'check if it was lower and upper limit violation
                        If Not (GetDcmMinimum() <= Val(cboValues.Text)) Then
                            SetBackColor(Color.Cyan)
                            If Not bValidateSilently Then
                                MessageBox.Show("Value lower than lowerlimit of: " & GetDcmMinimum(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            End If
                        ElseIf Not (GetDcmMaximum() >= Val(cboValues.Text)) Then
                            SetBackColor(Color.Cyan)
                            If Not bValidateSilently Then
                                MessageBox.Show("Value higher than upperlimit of: " & GetDcmMaximum(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            End If
                        End If
                End Select

            End If
        Else
            bValid = True
            SetBackColor(clValidColor)
        End If
        Return bValid
    End Function
    Public Overrides Sub SelectDefaultValue()
        'TODO dataTables are required for the checking below
        'If HasDefaultValue() AndAlso dtbRecords IsNot Nothing AndAlso dtbRecords.Rows.Count > 0 Then
        '    SetValue(GetDefaultValue())
        'Else
        '    SelectFirst()
        'End If
    End Sub

    Public Overrides Function IsEmpty() As Boolean
        Return String.IsNullOrEmpty(cboValues.Text)
    End Function

    Public Overrides Sub SetBackColor(backColor As Color)
        cboValues.BackColor = backColor
    End Sub

    Public Sub SelectFirst()
        'TODO..dataStructures are required here to set the values

        'If dtbRecords IsNot Nothing AndAlso dtbRecords.Rows.Count > 0 Then
        '    SetValue(dtbRecords.Rows.Item(0).Item(cboValues.ValueMember))
        'End If
    End Sub

    Public Sub SelectLast()
        'TODO..dataStructures are required here to set the values

        'If dtbRecords IsNot Nothing AndAlso dtbRecords.Rows.Count > 0 Then
        '    SetValue(dtbRecords.Rows.Item(dtbRecords.Rows.Count - 1).Item(cboValues.ValueMember))
        'End If
    End Sub

    Public Sub SetDisplayMember(strDisplay As String)

        'TODO dataStructures are required here to set the comboboxes display member
    End Sub

    Public Sub SetValueMember(strValue As String)
        'TODO dataStructures are required here to set the comboboxes value member
    End Sub

    Public Sub SetDisplayAndValueMember(strDisplay As String, strValue As String)
        SetDisplayMember(strDisplay)
        SetValueMember(strValue)
    End Sub

    Public Sub SetDisplayAndValueMember(strDisplayAndValue As String)
        SetDisplayAndValueMember(strDisplayAndValue, strDisplayAndValue)
    End Sub

    Protected Sub SetComboBoxSelectorProperties(Optional comboBoxStyle As ComboBoxStyle = ComboBoxStyle.DropDown, Optional autoCompletSource As AutoCompleteSource = AutoCompleteSource.ListItems, Optional autoCompleteMode As AutoCompleteMode = AutoCompleteMode.SuggestAppend)
        cboValues.DropDownStyle = comboBoxStyle
        cboValues.AutoCompleteSource = autoCompletSource
        cboValues.AutoCompleteMode = autoCompleteMode
    End Sub

    'todo. change the parameter to appropriate datastructure type
    Public Sub SetPossibleValues(dtbNewRecords As DataTable)
        'todo. what should be done for the controls that don't read from the database. 
        'What kind datastructure will they use  . Previously they use a datatable
        ' dtbRecords = dtbNewRecords
        bFillFromDataBase = False
    End Sub

    Public Sub SortBy(strCol As String)
        'TODO datastructure is required here to provide the necessary list of element or station for sorting

        'If dtbRecords IsNot Nothing Then
        '    'Datatable Sorting affects cboValues.SelectedValue
        '    'thus SuppressChange And retain previous cboValues.SelectedValue 
        '    Dim prevSelected = GetValue()
        '    bSuppressChangedEvents = True
        '    dtbRecords.DefaultView.Sort = strCol & " ASC"
        '    SetValue(prevSelected)
        '    bSuppressChangedEvents = False
        'End If
    End Sub
    Public Sub SetPossibleValues(strColumnName As String, tColumnType As Type, lstValues As IEnumerable(Of Object))
        SetPossibleValues(New DataTable)
        'TODO..Datatables were also required for this
        'dtbRecords.Columns.Add(strColumnName, tColumnType)
        'For Each objVal In lstValues
        '    dtbRecords.Rows.Add(objVal)
        'Next
        UpdateValueChoices()
    End Sub

    'TODO LinkedControls_evtValueChanged() existed in the ucrBaseDatalink 
    'Protected Overrides Sub LinkedControls_evtValueChanged()
    'End Sub

    Private Function ValidateNumeric(strText As String) As Integer
        Dim dcmText As Decimal
        Dim iType As Integer = 0

        If strText <> "" Then
            If Not IsNumeric(strText) Then
                iType = 1
            Else
                dcmText = Convert.ToDecimal(strText)
                If (dcmText < dcmMinimum) OrElse (dcmText > dcmMaximum) OrElse (Not bMinimumIncluded And dcmText <= dcmMinimum) OrElse (Not bMaximumIncluded And dcmText >= dcmMaximum) Then
                    iType = 2
                End If
            End If
        Else
            iType = 1
        End If
        Return iType
    End Function


    ''' <summary>
    ''' Returns the numeric range for the control
    ''' </summary>
    ''' <returns></returns>
    Public Function GetNumericRange() As String
        Dim strRange As String = ""
        If strValidationType = ClsGlobals.EnumValidationType.Numeric Then
            If dcmMinimum <> Decimal.MinValue Then
                If bMinimumIncluded Then
                    strRange = ">= " & dcmMinimum.ToString()
                Else
                    strRange = "> " & dcmMinimum.ToString()
                End If
                If dcmMaximum <> Decimal.MaxValue Then
                    strRange = strRange & " and "
                End If
            End If
            If dcmMaximum <> Decimal.MaxValue Then
                If bMaximumIncluded Then
                    strRange = strRange & "<= " & dcmMaximum.ToString()
                Else
                    strRange = strRange & "< " & dcmMaximum.ToString()
                End If
            End If
        End If
        Return strRange
    End Function

    ''' <summary>
    ''' Returns the minimum decimal number for the control
    ''' </summary>
    ''' <returns></returns>
    Public Function GetDcmMinimum() As Decimal
        Return dcmMinimum
    End Function

    ''' <summary>
    ''' Returns the maximum decimal number for the control
    ''' </summary>
    ''' <returns></returns>
    Public Function GetDcmMaximum() As Decimal
        Return dcmMaximum
    End Function

    Public Overrides Sub SetValue(objNewValue As Object)
        Dim strNewValueToSet As String = ""
        Dim bValueFound As Boolean = False


        If IsDBNull(objNewValue) OrElse String.IsNullOrEmpty(objNewValue) Then
            strNewValueToSet = ""
        Else
            'TODO..datatable were required here ,what should be done?
            'For Each rTemp As DataRow In dtbRecords.Rows
            '    'Calling ToString to prevent invalid casting
            '    If rTemp.Item(cboValues.ValueMember).ToString = objNewValue.ToString Then
            '        'set the text using the display column
            '        'cboValues.Text = rTemp.Item(cboValues.DisplayMember)
            '        strNewValueToSet = rTemp.Item(cboValues.DisplayMember)
            '        'cboValues.SelectedValue = objNewValue
            '        bValueFound = True
            '        Exit For
            '    End If
            'Next

            If Not bValueFound Then
                'cboValues.Text = objNewValue
                strNewValueToSet = objNewValue
            End If

        End If

        If cboValues.Text <> strNewValueToSet Then
            cboValues.Text = strNewValueToSet
            OnevtValueChanged(Me, Nothing)
        End If

    End Sub
End Class
