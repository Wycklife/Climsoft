Public Class ucrMetadataPhysicalFeatureNew
    Private Sub ucrMetadataPhysicalFeatureNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            SetUpButtonAddNew(ucrBtnAddNew)
            SetUpButtonClear(ucrBtnClear)
            SetUpButtonDelete(ucrBtnDelete)
            SetUpButtonSave(ucrBtnSave)
            SetUpButtonUpdate(ucrBtnUpdate)
            SetUpButtonView(ucrBtnView)
            SetUpNavigator(MyBase.ucrNavigator)
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
