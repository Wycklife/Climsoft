Public Class ucrMonthlyNew
    'Private strMonthsTableName As String = "months"
    Private strMonthName As String = "MonthName"
    Private strMonthId As String = "MonthId"
    Private strShortMonthName As String = "ShortMonthName"

    Public Overrides Sub UpdateValueChoices()
        'TODO datatable required here 

        'dtbRecords = New DataTable
        'dtbRecords.Columns.Add(strMonthId, GetType(Integer))
        'dtbRecords.Columns.Add(strMonthName, GetType(String))
        'dtbRecords.Columns.Add(strShortMonthName, GetType(String))
        'For i As Integer = 1 To 12
        '    dtbRecords.Rows.Add(i, DateAndTime.MonthName(i, False), DateAndTime.MonthName(i, True))
        'Next

        'bSuppressChangedEvents = True
        'dtbRecords.DefaultView.Sort = strMonthId & " ASC"
        'cboValues.DataSource = dtbRecords
        'cboValues.ValueMember = strMonthId
        'If bFirstLoad Then
        '    SetViewTypeAsMonthIds()
        'End If
        'bSuppressChangedEvents = False
        ''OnevtValueChanged(Me, Nothing)
    End Sub

    Private Sub ucrMonth_Load(sender As Object, e As EventArgs) Handles Me.Load
        cboValues.ContextMenuStrip = cmsMonthNew
    End Sub

    Public Sub SetViewTypeAsMonthsNames()
        SetDisplayMember(strMonthName)
    End Sub

    Public Sub SetViewTypeAsMonthIds()
        SetDisplayMember(strMonthId)
    End Sub

    Public Sub SetViewTypeAsShortMonthName()
        SetDisplayMember(strShortMonthName)
    End Sub

    Private Sub cmsMonthIDs_Click(sender As Object, e As EventArgs) Handles cmsMonthIDsNew.Click
        SetViewTypeAsMonthIds()
        cmsMonthIDsNew.Checked = True
        cmsMonthNamesNew.Checked = False
        cmsMonthShortMonthNamesNew.Checked = False
    End Sub

    Private Sub cmsMonthNames_Click(sender As Object, e As EventArgs) Handles cmsMonthNamesNew.Click
        SetViewTypeAsMonthsNames()
        cmsMonthIDsNew.Checked = False
        cmsMonthNamesNew.Checked = True
        cmsMonthShortMonthNamesNew.Checked = False
    End Sub

    Private Sub cmsMonthShortMonthNames_Click(sender As Object, e As EventArgs) Handles cmsMonthShortMonthNamesNew.Click
        SetViewTypeAsShortMonthName()
        cmsMonthIDsNew.Checked = False
        cmsMonthNamesNew.Checked = False
        cmsMonthShortMonthNamesNew.Checked = True
    End Sub

    Protected Overrides Sub ucrComboBoxSelector_Load(sender As Object, e As EventArgs) Handles Me.Load
        If clsDataConnection.IsInDesignMode Then
            Exit Sub
        End If

        If bFirstLoad Then
            bValidateEmpty = True
            strValidationType = ClsGlobals.EnumValidationType.Exist
            UpdateValueChoices()
            bFirstLoad = False
        End If
    End Sub
End Class
