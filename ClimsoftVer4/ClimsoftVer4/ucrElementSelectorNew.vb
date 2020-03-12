Public Class ucrElementSelectorNew
    Public Overrides Function ValidateValue() As Boolean
        Dim bValid As Boolean
        'TODO validate values while setting the back color to indicate if the value is valid or invalid
        Return bValid
    End Function

    Public Sub SetViewTypeAsElements()
        'TODO set view type as the element name
    End Sub

    Public Sub SetViewTypeAsIDs()
        'TODO set the view type as the element ID
    End Sub

    Public Sub SetViewTypeAsIDsAndElements()
        'TODO set the view type as the elements ID and element name
    End Sub

    Private Sub SortByID()
        'TODO sort by the elemnts ID using the sortBY() function
        'SortBy(strElementId)
        cmsElementSortByID.Checked = True
        cmsElementSortyByName.Checked = False
    End Sub

    Private Sub SortByElementName()
        'TODO sort by the elemnts Name using the ,sortBY(), function
        'SortBy(strElementId)
        'SortBy(strElementName)
        cmsElementSortByID.Checked = False
        cmsElementSortyByName.Checked = True
    End Sub

End Class
