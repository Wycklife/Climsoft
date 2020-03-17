Public Class ucrMetadataElementNew
    Private Sub ucrMetadataElementNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            'TODO Have a method that sets up the table to be used from the datastructure as before   SetUpTableEntry("obselement") 
            ucrDataLinkElementID.UpdateValueChoices()
            ucrDataLinkElementID.SetDisplayAndValueMember("elementId")
            'TODO set the table to be used from the datatructure
            'ucrDataLinkElementID.SetTableNameAndField("obselement", "elementId")
            ucrDataLinkElementID.SetValidationTypeAsNumeric(dcmMin:=1)

            ucrDataLinkType.SetPossibleValues("elementtypes", GetType(String), {"Daily", "Hourly", "Monthly", "AWS"})
            ucrDataLinkType.SetDisplayAndValueMember("elementtypes")
            ucrDataLinkType.bValidateEmpty = False

            ucrTextboxName.bValidateEmpty = True
            ucrTextBoxScale.SetValidationTypeAsNumeric()
            ucrTextBoxUpperLimit.SetValidationTypeAsNumeric()
            'ucrTextBoxUpperLimit.bValidateEmpty = False
            ucrTextBoxLowerLimit.SetValidationTypeAsNumeric()
            'ucrTextBoxLowerLimit.bValidateEmpty = False

            ucrNewElementSelector.SetInValidColor(ucrNewElementSelector.GetValidColor)

            'TODO impliment Linked control filters
            'AddLinkedControlFilters(ucrDataLinkElementID, ucrDataLinkElementID.FieldName(), "=", strLinkedFieldName:=ucrDataLinkElementID.FieldName(), bForceValuesAsString:=False)

            SetUpButtonAddNew(ucrBtnAddNew)
            SetUpButtonSave(ucrBtnSave)
            SetUpButtonUpdate(ucrBtnUpdate)
            SetUpButtonDelete(ucrBtnDelete)
            SetUpButtonClear(ucrBtnClear)
            SetUpButtonView(ucrBtnView)

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
