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
    End Sub

    Public Sub SetViewTypeAsElements()
        SetDisplayMember(strElementName)
    End Sub

    Public Sub SetViewTypeAsIDs()
        SetDisplayMember(strElementId)
    End Sub

    Public Sub SetViewTypeAsIDsAndElements()
        SetDisplayMember(strIDsAndElements)
    End Sub

    Private Sub SortByID()
        SortBy(strElementId)
        cmsElementSortByID.Checked = True
        cmsElementSortyByName.Checked = False
    End Sub

    Private Sub SortByElementName()
        SortBy(strElementName)
        cmsElementSortByID.Checked = False
        cmsElementSortyByName.Checked = True
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
                '    For Each rTemp As DataRow In dtbRecords.Rows
                '        If rTemp.Item(cboValues.ValueMember).ToString = cboValues.Text Then
                '            bValid = True
                '            Exit For
                '        End If
                '    Next
            End If

            SetBackColor(If(bValid, clValidColor, clInValidColor))
        End If

        Return bValid
    End Function

    Protected Overrides Sub ucrComboBoxSelector_Load(sender As Object, e As EventArgs) Handles Me.Load
        If clsDataConnection.IsInDesignMode() Then
            Exit Sub ' temporary code to remove the bugs thrown during design time
        End If

        Dim dct As New Dictionary(Of String, List(Of String))
        If bFirstLoad Then

            cboValues.ContextMenuStrip = cmsElement
            SetComboBoxSelectorProperties()
            bValidateEmpty = True
            strValidationType = ClsGlobals.EnumValidationType.Exist

            dct.Add(strElementName, New List(Of String)({strElementName}))
            dct.Add(strElementId, New List(Of String)({strElementId}))
            dct.Add(strIDsAndElements, New List(Of String)({strElementId, strElementName}))
            'TODO.
            'SetTableNameAndFields(strElementTableName, dct)
            'SetFilter("selected", "=", "1", bIsPositiveCondition:=True)
            UpdateValueChoices()
            bFirstLoad = False
        End If
    End Sub

    Private Sub cboValues_Leave(sender As Object, e As EventArgs)
        If Not cboValues.DisplayMember = strElementId Then
            If IsNumeric(cboValues.Text) Then
                If ValidateValue() Then
                    Dim bChangedEvents As Boolean = Me.bSuppressChangedEvents
                    bSuppressChangedEvents = True
                    SetValue(cboValues.Text)
                    bSuppressChangedEvents = bChangedEvents
                End If
            End If
        End If
    End Sub
End Class
