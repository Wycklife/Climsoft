Public Class ucrStationSelectorNew
    Private ucrLinkedElement As ucrElementSelectorNew
    Private ucrLinkedInstrument As ucrInstrumentSelectorNew
    '?Load statement?

    Public Sub setInstrumentLink(ucrInstrumentSelector As ucrInstrumentSelectorNew)
        ucrLinkedInstrument = ucrInstrumentSelector
        AddHandler ucrLinkedInstrument.evtValueChanged, AddressOf InstrumentEvtValueChanged
    End Sub

    Public Sub SetElementLink(ucrElementSelector As ucrElementSelectorNew)
        ucrLinkedElement = ucrElementSelector
        AddHandler ucrLinkedElement.evtValueChanged, AddressOf ElementEvtValueChanged
    End Sub
    Private Sub ElementEvtValueChanged()
        'TODO. Filter out the  elements specific for the selected station
    End Sub

    Private Sub InstrumentEvtValueChanged()
        'TODO.Filter out the instruments specific for the selected station
    End Sub
    Public Overrides Sub UpdateValueChoices()
        'TODO Fill the selector combo box with the list of required values ie station ID or station Name
    End Sub

    Public Overrides Function ValidateValue() As Boolean
        'TODO.
    End Function
    Private Sub cboValues_Leave(sender As Object, e As EventArgs) Handles cboValues.Leave
        'TODO
    End Sub
    Private Sub cmsStationIDs_Click(sender As Object, e As EventArgs) Handles cmsStationIDs.Click
        SetViewTypeAsIDs()
    End Sub

    Private Sub cmsStationIDAndStation_Click(sender As Object, e As EventArgs) Handles cmsStationIDAndStation.Click
        SetViewTypeAsIDsAndStations()
    End Sub

    Private Sub cmsStationSortByID_Click(sender As Object, e As EventArgs) Handles cmsStationSortByID.Click
        SortByID()
    End Sub

    Private Sub cmsStationSortyByName_Click(sender As Object, e As EventArgs) Handles cmsStationSortyByName.Click
        SortByStationName()
    End Sub

    Private Sub cmsFilterStations_Click(sender As Object, e As EventArgs) Handles cmsFilterStations.Click
        ' TODO SetDataTable() in sdgFilter needs to be created
        'sdgFilter.SetDataTable(dtbStations)
        sdgFilter.ShowDialog()
        UpdateValueChoices()
    End Sub

    Public Sub SetViewTypeAsStations()
        'TODO. Refer to the SetDisplayMember(),in UcrComboBoxNew,while passing in the station names to get the list of specified IDS
    End Sub

    Public Sub SetViewTypeAsIDs()
        'TODO. Refer to the SetDisplayMember(),in UcrComboBoxNew,while passing in the station ID to get the list of specified IDS
    End Sub

    Public Sub SetViewTypeAsIDsAndStations()
        'TODO. Refer to the SetDisplayMember(),in UcrComboBoxNew,while passing in the station ID and Station to get the list of specified IDS
    End Sub

    Public Sub SortByID()
        'use the sortBy(),with Id as the argument,function in ucrComboboxNew to sort the Station
        'cmsStationSortByID.Checked = True
        'cmsStationSortyByName.Checked = False
    End Sub

    Public Sub SortByStationName()
        'use the sortBy(),with statioName as the argument,function in ucrComboboxNew to sort the Station
        'cmsStationSortByID.Checked = False
        'cmsStationSortyByName.Checked = True
    End Sub
End Class
