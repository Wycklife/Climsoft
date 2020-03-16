Public Class ucrElementSelectorNew
    Private ucrLinkedStation As ucrStationSelectorNew
    Private ucrLinkedInstrument As ucrInstrumentSelectorNew
    Private strElementTableName As String
    Private strElementName As String
    Private strElementId As String
    Private strIDsAndElements As String

    Public Sub setInstrumentLink(ucrInstrumentSelector As ucrInstrumentSelectorNew)
        ucrLinkedInstrument = ucrInstrumentSelector
        AddHandler ucrLinkedInstrument.evtValueChanged, AddressOf InstrumentEvtValueChanged
    End Sub

    Public Sub SetStationLink(ucrStationSelector As ucrStationSelectorNew)
        ucrLinkedStation = ucrStationSelector
        AddHandler ucrLinkedStation.evtValueChanged, AddressOf StationEvtValueChanged
    End Sub
    Private Sub StationEvtValueChanged()
        'TODO.Filter out the stations with the specific elements and update the station selectors combo box with the 
        'relevant stations
    End Sub

    Private Sub InstrumentEvtValueChanged()
        'TODO.Filter out the instrument for the seleected element and update the instrument selector with those 
        'instrument
    End Sub

    Public Overrides Sub UpdateValueChoices()
        SetValueFromDataStructure()
        'TODO update this variables
        'strElementTableName 
        ' strElementName 
        'strElementId
        'strIDsAndElements 
    End Sub

    Public Sub SetViewTypeAsElements()
        'TODO sets the list of elements from the datastructure list of elements
        SetDisplayMember(strElementName)
    End Sub

    Public Sub SetViewTypeAsIDs()
        'TODO. Refer to the SetDisplayMember(),in UcrComboBoxNew,while passing in theelementID to get the list of specified IDS
        'SetDisplayMember(strElementId)
    End Sub

    Public Sub SetViewTypeAsIDsAndElements()
        'TODO. Refer to the SetDisplayMember(),in UcrComboBoxNew,while passing in the element names and IDs to get the list of specified IDS
        'SetDisplayMember(strIDsAndElements)
    End Sub

    Private Sub SortByID()
        'use the sortBy(),with ElementID as the argument,function in ucrComboboxNew to sort the Elements
        'SortBy(strElementId)
        'cmsElementSortByID.Checked = True
        'cmsElementSortyByName.Checked = False
    End Sub

    Private Sub SortByElementName()
        'use the sortBy(),with ElementName as the argument,function in ucrComboboxNew to sort the Elements
        'SortBy(strElementName)
        'cmsElementSortByID.Checked = False
        'cmsElementSortyByName.Checked = True
    End Sub

    Private Sub cmsElementsNames_Click(sender As Object, e As EventArgs) Handles cmsElementNames.Click
        SetViewTypeAsElements()
    End Sub

    Private Sub cmsElementIDs_Click(sender As Object, e As EventArgs) Handles cmsElementIDs.Click
        SetViewTypeAsIDs()
    End Sub

    Private Sub cmsElemntIDName_Click(sender As Object, e As EventArgs) Handles cmsElementIDAndStation.Click
        SetViewTypeAsIDsAndElements()
    End Sub

    Private Sub tsmSortByID_Click(sender As Object, e As EventArgs) Handles cmsElementSortByID.Click
        SortByID()
    End Sub

    Private Sub cmsElementSortyByName_Click(sender As Object, e As EventArgs) Handles cmsElementSortyByName.Click
        SortByElementName()
    End Sub

    Private Sub cmsElementsFilter_Click(sender As Object, e As EventArgs) Handles cmsFilterElements.Click
        ' TODOD SetDataTable() in sdgFilter needs to be created
        'sdgFilter.SetDataTable(dtbElements)
        'sdgFilter.ShowDialog()
        'PopulateControl()
    End Sub

    Public Overrides Function ValidateValue() As Boolean
        Dim bValid As Boolean
        bValid = MyBase.ValidateValue()

        If Not bValid Then
            If Not String.IsNullOrEmpty(cboValues.ValueMember) Then
                'TODO Requires datatable to  go through this loop
                'For Each rTemp As DataRow In dtbRecords.Rows
                '    If rTemp.Item(cboValues.ValueMember).ToString = cboValues.Text Then
                '        bValid = True
                '        Exit For
                '    End If
                'Next
            End If

            SetBackColor(If(bValid, clValidColor, clInValidColor))
        End If

        Return bValid
    End Function
End Class
