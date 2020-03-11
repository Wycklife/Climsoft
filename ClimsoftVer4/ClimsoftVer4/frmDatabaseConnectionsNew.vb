' CLIMSOFT - Climate Database Management System
' Copyright (C) 2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License
' along with this program.  If not, see <http://www.gnu.org/licenses/>.
Public Class frmDatabaseConnectionsNew
    Private Sub frmDatabaseConnectionsNew_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim builder As New System.Data.Common.DbConnectionStringBuilder()
        Dim strProcessedPassword As String
        Dim dctConnectionDetails As Dictionary(Of String, String)

        dataGridConnections.Rows.Clear()
        dctConnectionDetails = clsDataConnection.ReadConnectionDetails()

        For Each kvp As KeyValuePair(Of String, String) In dctConnectionDetails
            Try
                'use the connection string builder to access the connection details
                builder.Clear()
                builder.ConnectionString = kvp.Value

                'todo. what should be done to the password ?? mask the characters
                strProcessedPassword = builder("pwd")

                dataGridConnections.Rows.Add(kvp.Key, builder("server"), builder("database"), builder("port"), builder("uid"), strProcessedPassword)
            Catch ex As Exception
                ' If a line fails for any reason then we skip it. It is invalid, therefore it will
                ' not be displayed and it will not be written back to the file.
            End Try
        Next
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Dim builder As New System.Data.Common.DbConnectionStringBuilder()
        Dim dctConnectionDetails As New Dictionary(Of String, String)
        Dim strConnectionName As String
        Dim strDatabase As String
        Dim strPort As String
        Dim strServer As String
        Dim strUsername As String
        Dim strPassword As String

        For Each row As DataGridViewRow In dataGridConnections.Rows

            strConnectionName = row.Cells(0).Value
            strServer = row.Cells(1).Value
            strDatabase = row.Cells(2).Value
            strPort = row.Cells(3).Value
            strUsername = row.Cells(4).Value
            strPassword = row.Cells(5).Value

            'Skip empty rows (and continue to process other rows)
            If String.IsNullOrEmpty(strConnectionName) AndAlso String.IsNullOrEmpty(strServer) AndAlso
                    String.IsNullOrEmpty(strDatabase) AndAlso String.IsNullOrEmpty(strPort) AndAlso
                    String.IsNullOrEmpty(strUsername) AndAlso String.IsNullOrEmpty(strPassword) Then
                Continue For
            End If

            'Connection name: must not be empty (abort save)
            If String.IsNullOrEmpty(strConnectionName) Then
                MsgBox("Unable to save connections. Please ensure that each connection has a connection name")
                Exit Sub
            End If

            'Connection name: Match one or more letters, numbers or underscores (otherwise abort save)
            If Not System.Text.RegularExpressions.Regex.IsMatch(strConnectionName, "^[a-zA-Z0-9_]+$") Then
                MsgBox("Unable to save connection information due to connection """ & strConnectionName & """" &
                       Environment.NewLine & Environment.NewLine &
                       "The connection name must only contain letters, numbers and underscores")
                Exit Sub
            End If

            ' Server address: Match one or more letters, numbers or hyphen or
            '                 match numbers and period allowing IP addresses (otherwise abort save)
            If String.IsNullOrEmpty(strServer) OrElse
                (Not System.Text.RegularExpressions.Regex.IsMatch(strServer, "^[a-zA-Z0-9-]+$") AndAlso
                 Not System.Text.RegularExpressions.Regex.IsMatch(strServer, "^[0-9.]+$")) Then

                MsgBox("Unable to save connection information due to connection """ & strConnectionName & """" &
                       Environment.NewLine & Environment.NewLine &
                       "The server address must only contain letters, numbers and hyphens (or numbers " &
                       "and periods for IP addresses, e.g. 127.0.0.1)")
                Exit Sub
            End If

            ' Database name: Match one or more letters, numbers or underscores (otherwise abort save)
            If String.IsNullOrEmpty(strDatabase) OrElse Not System.Text.RegularExpressions.Regex.IsMatch(strDatabase, "^[a-zA-Z0-9_]+$") Then

                MsgBox("Unable to save connection information due to connection """ & strConnectionName & """" &
                       Environment.NewLine & Environment.NewLine &
                       "The database name must only contain letters, numbers and underscores")
                Exit Sub
            End If

            ' Port number: Match one or more numbers (otherwise abort save)
            If String.IsNullOrEmpty(strPort) OrElse Not System.Text.RegularExpressions.Regex.IsMatch(strPort, "^[0-9]+$") Then

                MsgBox("Unable to save connection information due to connection """ & strConnectionName & """" &
                       Environment.NewLine & Environment.NewLine &
                       "The port number must be a whole number (e.g. 3306 or 3308)")
                Exit Sub
            End If

            'todo. do validation for username input in terms of the allowable characters
            If String.IsNullOrEmpty(strUsername) Then
                Exit Sub
            End If

            'todo. do validation for password input in terms of the allowable characters
            If String.IsNullOrEmpty(strPassword) Then
                Exit Sub
            End If

            'todo. what should be done to the password ?? unmask the password 

            'use the builder to construct the connection string in the approrpriate format in preparation for storage
            builder.Clear()
            builder.Add("server", strServer)
            builder.Add("database", strDatabase)
            builder.Add("port", strPort)
            builder.Add("uid", strUsername)
            builder.Add("pwd", strPassword)

            'builder.ConnectionString = "server=" & strServer & ";database=" & strDatabase & ";port=" & strPort & ";uid=" & strUsername & ";pwd=" & strPassword
            dctConnectionDetails.Add(strConnectionName, builder.ConnectionString)
        Next


        'after validating all the rows write the details
        If dctConnectionDetails.Count > 0 Then
            clsDataConnection.WriteConnectionDetails(dctConnectionDetails)
        End If


        Me.Close()

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub dataGridConnections_SelectionChanged(sender As Object, e As EventArgs) Handles dataGridConnections.SelectionChanged
        Try
            If dataGridConnections.CurrentCell.RowIndex + 1 = dataGridConnections.Rows.Count Then
                grpCurrentSelection.Enabled = False
            Else
                grpCurrentSelection.Enabled = True
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnMakeDefault_Click(sender As Object, e As EventArgs) Handles btnMakeDefault.Click
        Dim colIndex As Integer
        Dim row As DataGridViewRow
        Try
            'this just takes the selected row and sets it as the first row in the datagrid, 
            'thus when saving it becomes the first to be saved which makes it to always be the first slected in the login form
            colIndex = dataGridConnections.SelectedCells(0).OwningColumn.Index
            row = dataGridConnections.Rows(dataGridConnections.CurrentCell.RowIndex)
            dataGridConnections.Rows.Remove(row)
            dataGridConnections.Rows.Insert(0, row)
            dataGridConnections.Refresh()
            dataGridConnections.ClearSelection()
            dataGridConnections.Rows(0).Cells(colIndex).Selected = True
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnTest_Click(sender As Object, e As EventArgs) Handles btnTest.Click
        Dim conn As New MySql.Data.MySqlClient.MySqlConnection
        Dim builder As New System.Data.Common.DbConnectionStringBuilder()
        Dim row As DataGridViewRow
        Try
            row = dataGridConnections.Rows(dataGridConnections.CurrentCell.RowIndex)

            'use the builder to construct the connection string in the approrpriate format in preparation for storage
            builder.Add("server", row.Cells(1).Value)
            builder.Add("database", row.Cells(2).Value)
            builder.Add("port", row.Cells(3).Value)
            builder.Add("uid", row.Cells(4).Value)
            builder.Add("pwd", row.Cells(5).Value) ' do more processing to get the password

            conn.ConnectionString = builder.ConnectionString & ";Convert Zero Datetime=True"
            conn.Open()
        Catch ex As Exception
            If ex.Message.IndexOf("Access denied for user") >= 0 Then
                MsgBox("Access denied. Please try again.")
            ElseIf ex.Message.IndexOf("Unable to connect") >= 0 Then
                MsgBox("Unable to connect to database")
            Else
                MsgBox("Login failed: " & ex.Message)
            End If
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        Try
            dataGridConnections.Rows.RemoveAt(dataGridConnections.CurrentCell.RowIndex)
            dataGridConnections.Refresh()
        Catch ex As Exception

        End Try
    End Sub
End Class