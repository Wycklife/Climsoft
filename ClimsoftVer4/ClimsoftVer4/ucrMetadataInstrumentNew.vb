Public Class ucrMetadataInstrumentNew
    Private Sub ucrMetadataInstrumentNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then

            SetUpButtonAddNew(ucrBtnAddNew, ucrBtnAddNew.ActionTypeId)
            SetUpButtonSave(ucrBtnSave, ucrBtnSave.ActionTypeId)
            SetUpButtonUpdate(ucrBtnUpdate, (ucrBtnUpdate.ActionTypeId)
            SetUpButtonDelete(ucrBtnDelete, ucrBtnDelete.ActionTypeId)
            SetUpButtonClear(ucrBtnClear, ucrBtnClear.ActionTypeId)
            SetUpButtonView(ucrBtnView, ucrBtnView.ActionTypeId)

            'todo pass in the data identifier here in place of nothing.
            'This will be used by the data definition
            SetDataIdentifier(Nothing)
            SetValueControlProperties()
            SetUpValueControls()
            InitialiseDatastructure()

            bFirstLoad = False
        End If
    End Sub

    Public Sub SetValueControlProperties()
        For Each ctr As ucrValue In lstUcrValues
            'set the properties that will be used as part of the data definition
            'todo. set up the properties of the child controls and the definition of the data structure
            'the properties will be the field name...
        Next
    End Sub
End Class
