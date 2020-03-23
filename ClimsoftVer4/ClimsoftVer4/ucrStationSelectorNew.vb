﻿Public Class ucrStationSelectorNew
    Private ucrLinkedElement As ucrElementSelectorNew
    Private ucrLinkedInstrument As ucrInstrumentSelectorNew
    Private strStationsTableName As String
    Private strStationName As String
    Private strStationId As String
    Private strIDsAndStations As String

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
        MyBase.UpdateValueChoices()
        'TODO update the following variables
        'strStationsTableName
        'strStationName
        'strStationId
        'strIDsAndStations
    End Sub

    Public Overrides Function ValidateValue() As Boolean
        Dim bValid As Boolean = False
        bValid = MyBase.ValidateValue()

        If Not bValid Then
            If Not String.IsNullOrEmpty(cboValues.ValueMember) Then
                'TODO get the datatable from the datastructure here
                'For Each rTemp As DataRow In dtbRecords.Rows
                '    If rTemp.Item(cboValues.ValueMember).ToString = cboValues.Text Then
                '        bValid = True
                '        Exit For
                '    End If
                'Next
            End If
        End If

        SetBackColor(If(bValid, clValidColor, clInValidColor))
        Return bValid
    End Function
    Public Sub SetViewTypeAsStations()
        SetDisplayMember(strStationName)
    End Sub

    Public Sub SetViewTypeAsIDs()
        SetDisplayMember(strStationId)
    End Sub

    Public Sub SetViewTypeAsIDsAndStations()
        SetDisplayMember(strIDsAndStations)
    End Sub

    Public Sub SortByID()
        SortBy(strStationId)
        cmsStationSortByID.Checked = True
        cmsStationSortyByName.Checked = False
    End Sub

    Public Sub SortByStationName()
        SortBy(strStationName)
        cmsStationSortByID.Checked = False
        cmsStationSortyByName.Checked = True
    End Sub

    Protected Overrides Sub ucrComboBoxSelector_Load(sender As Object, e As EventArgs) Handles Me.Load
        If clsDataConnection.IsInDesignMode() Then
            Exit Sub ' temporary code to remove the bugs thrown during design time
        End If

        Dim dct As New Dictionary(Of String, List(Of String))
        If bFirstLoad Then
            cboValues.ContextMenuStrip = cmsStation
            SetComboBoxSelectorProperties()
            bValidateEmpty = True
            strValidationType = "exists"

            'SortByStationName()

            dct.Add(strStationId, New List(Of String)({strStationId}))
            dct.Add(strStationName, New List(Of String)({strStationName}))
            dct.Add(strIDsAndStations, New List(Of String)({strStationId, strStationName}))
            'SetTableNameAndFields(strStationsTableName, dct)
            UpdateValueChoices()
            bFirstLoad = False
        End If
    End Sub
    Private Sub cboValues_Leave(sender As Object, e As EventArgs) Handles cboValues.Leave
        If Not cboValues.DisplayMember = strStationId Then
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
End Class
