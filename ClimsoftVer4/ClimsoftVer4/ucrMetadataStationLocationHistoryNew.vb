Public Class ucrMetadataStationLocationHistoryNew
    Private iNwSaveActionTypeID As Integer
    Private iNwDeleteActionTypeID As Integer
    Private iNwUpdateActionTypeID As Integer
    Private iNwAddNewActionTypeID As Integer
    Private iNwClearActionTypeID As Integer
    Private iNwCancelActionTypeID As Integer
    Private iNwUploadActionTypeID As Integer
    Private iNwViewActionTypeID As Integer
    Private Sub ucrMetadataStationLocationHistoryNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            SetUpButtonAddNew(btnAddNew, iNwAddNewActionTypeID)
            SetUpButtonCancel(btnCancel, iNwCancelActionTypeID)
            SetUpButtonCancel(btnClear, iNwClearActionTypeID)
            SetUpButtonDelete(btnDelete, iNwDeleteActionTypeID)
            SetUpButtonSave(btnSave, iNwSaveActionTypeID)
            SetUpButtonUpdate(btnUpdate, iNwUpdateActionTypeID)
            SetUpButtonUpload(btnUpload, iNwUploadActionTypeID)
            SetUpButtonView(btnView, iNwViewActionTypeID)
            SetUpNavigator(ucrNavigator)
            SetUpValueControls()

            'todo pass in the data identifier here in place of nothing. 
            'This will be used by the data defination
            SetDataIdentifier(Nothing)
            'SetValueControlProperties()
            InitialiseDatastructure()

            bFirstLoad = False
        End If

    End Sub

    Public Sub SetValueControlProperties()
        For Each ctr As ucrValue In lstUcrValues
            'set the properties that will be used as part of the data defination
            'todo. set up the properties of the child controls and the defination of the data structure
            'the properties will be field name... 
        Next
    End Sub
End Class
