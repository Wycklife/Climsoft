Public Class ucrComboboxNew

    Public bFillFromDataBase As Boolean = True


    Protected Overridable Sub ucrCombobox_Load(sender As Object, e As EventArgs) Handles Me.Load
        If clsDataConnection.IsInDesignMode() Then
            Exit Sub ' temporary code to remove the bugs thrown during design time
        End If

        If bFirstLoad Then


            bFirstLoad = False
        End If
    End Sub

    Public Overrides Sub PopulateControl()
        'Todo. Fill the control 
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

    Public Overrides Function GetValue(Optional objSpecification As Object = Nothing) As Object
        'todo. get the value of the control.
        'possibly always get this from the datastrure?
        Return Nothing
    End Function
    Public Overrides Sub Clear()
        SetValue("")
        SetBackColor(clValidColor)
    End Sub

    Public Overrides Function ValidateValue() As Boolean
        'todo .validate based on the validation parameters of the datastructure
        Return True
    End Function

    Public Overrides Function IsEmpty() As Boolean
        Return String.IsNullOrEmpty(cboValues.Text)
    End Function

    Public Overrides Sub SetBackColor(backColor As Color)
        cboValues.BackColor = backColor
    End Sub

    Public Sub SelectFirst()
        'TODO
    End Sub

    Public Sub SelectLast()
        'TODO
    End Sub

    Public Sub SetDisplayMember(strDisplay As String)
        'TODO. Check if the datastructure contains the data table with list of required station or elements.This
        'will be used by the selector for stations and selector for elements
        'If the datatable contains a column with the required type eg elements or stations then fill the combobox with the column contents ie list of elements or list of stations
    End Sub

    Public Sub SetValueMember(strValue As String)
        'TODO
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
        'TODO. if the datatable is not empty then sort the Datatable
        'Datatable Sorting affects cboValues.SelectedValue
        'thus SuppressChange And retain previous cboValues.SelectedValue 
    End Sub
    Public Sub SetPossibleValues(strColumnName As String, tColumnType As Type, lstValues As IEnumerable(Of Object))
        SetPossibleValues(New DataTable)
        'todo.

        'dtbRecords.Columns.Add(strColumnName, tColumnType)
        'For Each objVal In lstValues
        '    dtbRecords.Rows.Add(objVal)
        'Next
        'PopulateControl()
    End Sub

    Public Overrides Sub SetValue(objNewValue As Object)
        'If IsDBNull(objNewValue) OrElse String.IsNullOrEmpty(objNewValue) Then set the cboValues.Text =objNewValue
        'else For Each rTemp As DataRow In dtbRecords.Rows
        'Calling ToString to prevent invalid casting
        'If rTemp.Item(cboValues.ValueMember).ToString = objNewValue.ToString Then
        'set the text using the display column
        'cboValues.Text = rTemp.Item(cboValues.DisplayMember)
        OnevtValueChanged(Me, Nothing)

    End Sub
End Class
