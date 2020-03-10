Public Class ucrInstrumentSelector
    Private ucrLinkedElement As ucrElementSelectorNew
    Private ucrLinkedStation As ucrStationSelectorNew

    Public Sub setStationLink(ucrStationSelector As ucrStationSelectorNew)
        ucrLinkedStation = ucrStationSelector
        AddHandler ucrLinkedStation.evtValueChanged, AddressOf StationEvtValueChanged
    End Sub

    Public Sub SetElementLink(ucrElementSelector As ucrElementSelectorNew)
        ucrLinkedElement = ucrElementSelector
        AddHandler ucrLinkedElement.evtValueChanged, AddressOf ElementEvtValueChanged
    End Sub
    Private Sub ElementEvtValueChanged()
        'TODO. Filter out the elements for the specific Instruments when the eveent is raised
    End Sub

    Private Sub StationEvtValueChanged()
        'TODO.Filter out the stations with the instruments
    End Sub
End Class
