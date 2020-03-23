Public Class frmDataForms
    Private dataCall As New DataCall
    Private dataTable As DataTable

    Private Sub frmDataForms_Load(sender As Object, e As EventArgs) Handles Me.Load

        Try
            'todo. this should be done through our actions and permissions system

            Dim itm As ListViewItem
            lstViewForms.Items.Clear()
            'set the database name and columns, set the key field for updating, then add the retrieved data to the listview
            dataCall.SetTableNameAndFields("data_forms", {"form_name", "description", "selected"})
            dataCall.AddKeyField("form_name")
            dataTable = dataCall.GetDataTable()
            For Each row As DataRow In dataTable.Rows
                itm = New ListViewItem({row.Item("form_name"), row.Item("description")})
                lstViewForms.Items.Add(itm)
                If row.Item("selected") = 1 Then
                    itm.Checked = True
                End If
            Next
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message)
        End Try
    End Sub

    Private Sub cmdApply_Click(sender As Object, e As EventArgs) Handles btnApply.Click
        Try
            'update the datatable
            For i = 0 To lstViewForms.Items.Count - 1
                dataTable.Rows(i).Item("selected") = If(lstViewForms.Items(i).Checked, 1, 0)
            Next
            'save the changes in the datatable
            dataCall.Save(dataTable)
            MessageBox.Show("Form selection updated successfully")
        Catch ex As Exception
            MessageBox.Show("Error : " & ex.Message)
        End Try
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        Help.ShowHelp(Me, Application.StartupPath & "\climsoft4.chm", "settingupkeyentryformlist.htm")
    End Sub
End Class