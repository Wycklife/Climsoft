Public Class ucrPage
    Protected bFirstLoad As Boolean = True
    Protected lstUcrValues As New List(Of ucrValue)
    Protected ucrNavigator As ucrNavigator
    Protected WithEvents btnAddNew As ucrButton
    Protected WithEvents btnSave As ucrButton
    Protected WithEvents btnUpdate As ucrButton
    Protected WithEvents btnDelete As ucrButton
    Protected WithEvents btnClear As ucrButton
    Protected WithEvents btnCancel As ucrButton
    Protected WithEvents btnView As ucrButton
    Protected WithEvents btnUpload As ucrButton
    Protected iSaveActionTypeID As ClsGlobals.EnumActionCode
    Protected iDeleteActionTypeID As ClsGlobals.EnumActionCode
    Protected iUpdateActionTypeID As ClsGlobals.EnumActionCode
    Protected iAddNewActionTypeID As ClsGlobals.EnumActionCode
    Protected iClearActionTypeID As ClsGlobals.EnumActionCode
    Protected iCancelActionTypeID As ClsGlobals.EnumActionCode
    Protected iUploadActionTypeID As ClsGlobals.EnumActionCode
    Protected iViewActionTypeID As ClsGlobals.EnumActionCode

    Private Sub ucrPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            SetValueControlsList()
            'bFirstLoad = False
        End If
    End Sub

    Protected Overridable Sub ValidateDataEntryPermission()
    End Sub
    Public Sub SetUpButtonAddNew(newAddNewBtn As ucrButton)
        btnAddNew = newAddNewBtn
        iAddNewActionTypeID = newAddNewBtn.ActionTypeId
    End Sub

    Public Sub SetUpButtonSave(newSaveBtn As ucrButton)
        btnSave = newSaveBtn
        iSaveActionTypeID = newSaveBtn.ActionTypeId
    End Sub

    Public Sub SetUpButtonUpdate(newUpdateBtn As ucrButton)
        btnUpdate = newUpdateBtn
        iUpdateActionTypeID = newUpdateBtn.ActionTypeId
    End Sub

    Public Sub SetUpButtonDelete(newDeleteBtn As ucrButton)
        btnDelete = newDeleteBtn
        iDeleteActionTypeID = newDeleteBtn.ActionTypeId
    End Sub

    Public Sub SetUpButtonClear(newClearBtn As ucrButton)
        btnClear = newClearBtn
        iClearActionTypeID = newClearBtn.ActionTypeId
    End Sub

    Public Sub SetUpButtonCancel(newCancelBtn As ucrButton)
        btnCancel = newCancelBtn
        iCancelActionTypeID = newCancelBtn.ActionTypeId
    End Sub

    Public Sub SetUpButtonView(newViewBtn As ucrButton)
        btnView = newViewBtn
        iViewActionTypeID = newViewBtn.ActionTypeId
    End Sub

    Public Sub SetUpButtonUpload(newUploadBtn As ucrButton)
        btnUpload = newUploadBtn
        iUpdateActionTypeID = newUploadBtn.ActionTypeId
    End Sub

    Public Sub SetUpButtonImport(newImportBtn As ucrButton)
        btnUpload = newImportBtn
        iUpdateActionTypeID = newImportBtn.ActionTypeId
    End Sub

    Public Sub SetUpNavigator(newUcrNavigator As ucrNavigator)
        ucrNavigator = newUcrNavigator
        'todo. setup the datastructure to the navigator . 
    End Sub

    Public Sub SetValueControlsList()
        lstUcrValues.Clear()
        For Each ctr As Control In Me.Controls
            If TypeOf ctr Is ucrValue Then
                lstUcrValues.Add(DirectCast(ctr, ucrValue))
            End If
        Next
    End Sub

    Public Sub SetDataIdentifier(objDataIdentifier As Object)
        'specifies the identifier that would be usd by the datastructure to get the data 
    End Sub

    Public Sub SetUpValueControls()
        For Each ctr As ucrValue In lstUcrValues
            AddHandler ctr.evtKeyDown, AddressOf GoToNextChildControl
            'todo. set up the properties of the child controls and the defination of the data structure
            'the properties will be field name... 
        Next
    End Sub

    Protected Sub InitialiseDatastructure()
        'todo. initilise the datastructure object and set it's defaults
    End Sub


    'this will be the event handler that listens to changes to record in the datastructure
    Private Sub ChangesToRecordInDataStructure(sender As Object, e As EventArgs)
        UpdateDisplay()
    End Sub

    Public Sub UpdateDisplay()
        'called 
        'also call upon the populating of the form by the datastructure
    End Sub


    Public Overridable Sub AddNewRecord()
        'todo. add new record
    End Sub
    Public Overridable Sub SaveRecord()
        'todo. calls the save record method of the datastructure

        Try
            'todo. calls the validateValue method of the data structure
            'If Not ValidateValue() Then
            'Exit Sub
            'End If

            'Confirm if you want to continue and save data from key-entry form to database table
            If MessageBox.Show("Do you want to continue and commit to database table?", "Save Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                'todo. have the insert method in the  datastructure
                'If InsertRecord() Then
                'todo have the GoToNewRecord in the ucrNavigator
                'ucrNavigator.GoToNewRecord()
                SaveEnable()
                    MessageBox.Show("New record added to database table!", "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            'End If
        Catch ex As Exception
            MessageBox.Show("New Record has NOT been added to database table. Error: " & ex.Message, "Save Record", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Overridable Sub UpdateRecord()
        'todo. calls the update record method of the datastructure

        Try
            'todo. calls the validateValue method of the data structure 
            'and displays the error message
            'if there is errors then don't proceed with updating

            'If Not datastructure.ValidateValue() Then
            ' display message then exit sub 
            'Exit Sub
            'End If

            'Dispaly a  message box cheecking if the user wants to update the record.If true then
            'If ucrNavigator.UpdateRecord() then Display a message displayiny SuccessfulUpdate of the record
        Catch ex As Exception
            MessageBox.Show("Record has NOT been updated. Error: " & ex.Message, "Update Record", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Overridable Sub DeleteRecord()
        'todo. calls the delete record method of the datastructure ie datastructure.DeleteRecords

        Try
            'todo. calls the validateValue method of the data structure 
            'and displays the error message
            'if there is errors then don't proceed with saving

            'If Not datastructure.ValidateValue() Then
            ' display message then exit sub 
            'Exit Sub
            'End If

            If MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
                'todo. calls the DeleteRecord method of the data structure
                'If DeleteRecord() return True Then
                'If the records can be deleted ,through ucrNavigator.RemoveRecords method ,then
                'enable the Delete button through the SaveEnable() method
                'If the record has been deleted succesfully then display a massage indicating succesful deletion
                MessageBox.Show("Record has been deleted", "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show("Record has NOT been deleted. Error: " & ex.Message, "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Public Overridable Sub Cancel()
        'todo. cancel the entry of the records and goes back to the record that was previously selected
    End Sub

    Public Overridable Sub Clear()
        'Either clear the controls which will clear the datastrucre 
        'or call the datastructure clear function which will inturn clear the controls

        'todo. have a method,Movefirst(),in the ucrNavigator for moving to the first record of the datatable
        'Move to the first record of datatable through ucrNavigator.MoveFirst()
        'Enable appropriate base buttons through the saveEnable() function


    End Sub

    Public Overridable Sub Close()
        'todo. check if you have unsaved changes to determine warn the user beforee closing the form
        FindForm.Close()
    End Sub
    Public Overridable Sub Upload()
        'todo. call the datastructure method
    End Sub

    Public Overridable Sub View()
        'todo. call the datastructure method
    End Sub

    Private Sub GoToNextChildControl(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            If TypeOf sender Is ucrValue Then
                'on enter only go next if what has been typed in is valid
                If DirectCast(sender, ucrValue).ValidateValue() Then
                    Me.SelectNextControl(sender, True, True, True, True)
                End If
                'this handles the "noise" on  return key down
                e.SuppressKeyPress = True
            End If
        End If

    End Sub

    Public Overridable Function ValidateValue() As Boolean
        Dim ucr As ucrValueView
        For Each ctr As Control In Controls
            If TypeOf ctr Is ucrValueView Then
                ucr = DirectCast(ctr, ucrValueView)
                'TODO. What should we do for controls without field names
                If Not String.IsNullOrEmpty(ucr.FieldName) AndAlso Not ucr.ValidateValue() Then
                    ctr.Focus()
                    Return False
                End If
            End If
        Next
        Return True
    End Function
    Public Sub SaveEnable()
        btnAddNew.Enabled = True
        btnSave.Enabled = False
        btnClear.Enabled = False
        btnDelete.Enabled = False
        btnUpdate.Enabled = False

        'todo. have the ucrNavigator contain the position of the selected row and number of maximum rows for the current record 
        'todo. in th ucrNavigator have the variable having the position of the current row and maximum row available
        'If there is no selected row then disable the Delete and Update buttons .At the same time Enable the Clear and Save buttons
        'If the maximum row is 0,Enable the save Button and Disable the AddNew button
        'If the maximum row is greater than 0 then Enable the Delete and Update buttons
    End Sub

    Private Sub btnAddNew_Click(sender As Object, e As EventArgs) Handles btnAddNew.Click
        'AddNewRecord()
        'todo have a method,NewRecord(),in ucrNavigator for Adding a new record

        'ucrNavigator.NewRecord()
        'Enable the required buttons using the saveEnable() method

        '#Not sure if this funtion below is necessary
        'ucrDataLinkInstrumentID.GetFocus()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveRecord()
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        UpdateRecord()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        DeleteRecord()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Clear()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Cancel()
    End Sub

    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click
        View()
    End Sub

    Private Sub btnUpload_Click(sender As Object, e As EventArgs) Handles btnUpload.Click
        Upload()
    End Sub

    Protected Overridable Sub SetValuesValidation()
    End Sub

End Class
