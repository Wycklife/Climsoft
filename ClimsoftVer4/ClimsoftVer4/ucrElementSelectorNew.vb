Public Class ucrElementSelectorNew
    Private ucrLinkedStation As ucrStationSelectorNew
    Private ucrLinkedInstrument As ucrInstrumentSelector

    Public Sub setInstrumentLink(ucrInstrumentSelector As ucrInstrumentSelector)
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

    Public Overrides Sub PopulateControl()
        'TODO Fills the elementSelector combobox with the list of elements

    End Sub

    Public Overrides Function ValidateValue() As Boolean
        'TODO..Validates the user input values
    End Function

    Public Sub SetViewTypeAsElements()
        'TODO. Refer to the SetDisplayMember(),in UcrComboBoxNew,while passing in the elementNames to get the list of specified IDS
        'SetDisplayMember(strElementName)
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

    Private Sub cmsElementsNames_Click(sender As Object, e As EventArgs) Handles cmsElementsNames.Click
        SetViewTypeAsElements()
    End Sub

    Private Sub cmsElementIDs_Click(sender As Object, e As EventArgs) Handles cmsElementIDs.Click
        SetViewTypeAsIDs()
    End Sub

    Private Sub cmsElemntIDName_Click(sender As Object, e As EventArgs) Handles cmsElemntIDName.Click
        SetViewTypeAsIDsAndElements()
    End Sub

    Private Sub tsmSortByID_Click(sender As Object, e As EventArgs) Handles cmsElementSortByID.Click
        SortByID()
    End Sub

    Private Sub cmsElementSortyByName_Click(sender As Object, e As EventArgs) Handles cmsElementSortyByName.Click
        SortByElementName()
    End Sub

    Private Sub cmsElementsFilter_Click(sender As Object, e As EventArgs) Handles cmsElementsFilter.Click
        ' TODOD SetDataTable() in sdgFilter needs to be created
        'sdgFilter.SetDataTable(dtbElements)
        'sdgFilter.ShowDialog()
        'PopulateControl()
    End Sub
End Class
