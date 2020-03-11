Imports System.Security.AccessControl
Imports System.Security.Principal
Public Class clsDataConnection
    Private Shared ReadOnly conn As New MySql.Data.MySqlClient.MySqlConnection
    Public Shared databaseName As String = "mariadb_climsoft_test_db_v4"
    ' Get Application Data folder to all users, e.g. C:\ProgramData
    ' Storing config.inf here ensures that it will still be available when Climsoft is updated
    Private Shared commonPath As String = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData)
    Private Shared directoryPath As String = IO.Path.Combine(commonPath, "Climsoft4")
    Private Shared filePath As String = IO.Path.Combine(directoryPath, "config.inf")


    Public Shared ReadOnly Property OpenedConnection As MySql.Data.MySqlClient.MySqlConnection
        Get
            OpenConnection()
            Return conn
        End Get
    End Property

    Public Shared Sub OpenNewConnection(strConnectionString As String)
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
        conn.ConnectionString = strConnectionString
        conn.Open()
    End Sub

    Public Shared Function IsValidConnection() As Boolean
        'todo. check how to determine if a connection is valid
        'this is just done temporary
        If conn.State = ConnectionState.Open Then
            Return True
        Else
            Return False
        End If
    End Function

    Public Shared Sub OpenConnection()
        If Not conn.State = ConnectionState.Open Then
            conn.ConnectionString = frmLogin.txtusrpwd.Text 'temporary connection string. This should come from somewhere else
            conn.Open()
        End If
    End Sub

    Public Shared Sub CloseConnection()
        If conn.State = ConnectionState.Open Then
            conn.Close()
        End If
    End Sub

    Public Shared Function GetConnectionString() As String
        Return OpenedConnection.ConnectionString
    End Function


    Public Shared Function ReadConnectionDetails() As Dictionary(Of String, String)
        Dim dctConnectionDetails As New Dictionary(Of String, String)
        Dim parts As String()
        Dim line As String

        If IO.File.Exists(filePath) Then
            Using r As IO.StreamReader = New IO.StreamReader(filePath)
                line = r.ReadLine
                Do While (Not IsNothing(line))
                    'A valid line should contain a connection name, a pipe character `|` and a connection string
                    'To be here, we know that line is not empty, therefore there must be a part(0) and part(1) after split
                    Try
                        parts = line.Split("|")
                        dctConnectionDetails.Add(parts(0), parts(1))
                    Catch ex As Exception
                        'If a line cannot be read for any reason then we skip it. It is invalid, therefore it will
                        'not be displayed and it will not be written back to the file.
                    End Try
                    line = r.ReadLine
                Loop
            End Using
        ElseIf IO.File.Exists("config.inf") Then
            'In the case where `filePath` does NOT exist, attempt to read legacy connection information
            'from the folder Climsoft is installed in (in previous versoins this file was also called `config.inf`)
            Using r As IO.StreamReader = New IO.StreamReader("config.inf")
                line = r.ReadLine
                Try
                    dctConnectionDetails.Add("Climsoft4", line)
                Catch ex As Exception
                    'If a line cannot be read for any reason then we skip it. It is invalid
                End Try
            End Using
        Else
            dctConnectionDetails.Add("Default database", My.Settings.defaultDatabase)
        End If

        Return dctConnectionDetails
    End Function

    ''' <summary>
    ''' takes a dictionary of 2 strings. The Connection name as the key and the connection string as the value
    ''' e.g key = "default connection", value = "server=localhost;database=mariadb_climsoft_test_db_v4";port=80;uid=myusername;pwd=12345!"
    ''' </summary>
    ''' <param name="dctNewConnectionDetails"></param>
    Public Shared Sub WriteConnectionDetails(dctNewConnectionDetails As Dictionary(Of String, String))
        Dim dInfo As IO.DirectoryInfo
        Dim dSecurity As DirectorySecurity
        Dim builder As New System.Data.Common.DbConnectionStringBuilder()

        Try
            'If `filePath` already exists then Create() will clear the current contents
            IO.Directory.CreateDirectory(directoryPath)
            IO.File.Create(filePath).Dispose()
            'Grant full access on `filePath` for all users (allows any user to write to file)
            'This is currently necessary because some Climsoft installers are not Windows Administrators
            dInfo = New IO.DirectoryInfo(filePath)
            dSecurity = dInfo.GetAccessControl()
            dSecurity.AddAccessRule(New FileSystemAccessRule(
                      New SecurityIdentifier(WellKnownSidType.WorldSid, Nothing),
                      FileSystemRights.FullControl, InheritanceFlags.ObjectInherit Or InheritanceFlags.ContainerInherit,
                      PropagationFlags.NoPropagateInherit, AccessControlType.Allow))
            dInfo.SetAccessControl(dSecurity)

            ' Loop over validated rows and add details from each row to `filePath`
            Using writer As IO.StreamWriter = New IO.StreamWriter(filePath)
                For Each kvp As KeyValuePair(Of String, String) In dctNewConnectionDetails
                    'Check that the connection string is accepted by the connection string builder
                    '(otherwise warn and continue)
                    Try
                        builder.Clear()
                        builder.ConnectionString = kvp.Value
                        If String.IsNullOrEmpty(builder.ConnectionString) Then
                            MsgBox("Unable to save connection information for connection """ & kvp.Key & """" &
                                    Environment.NewLine & Environment.NewLine & "Connection details missing")
                            Continue For
                        End If
                        'check for server, database, port, username and password details
                        If String.IsNullOrEmpty(builder("database")) Then
                            MsgBox("Unable to save connection information for connection """ & kvp.Key & """" &
                                     Environment.NewLine & Environment.NewLine & "Database name mising")
                            Continue For
                        End If

                        If String.IsNullOrEmpty(builder("port")) Then
                            MsgBox("Unable to save connection information for connection """ & kvp.Key & """" &
                                     Environment.NewLine & Environment.NewLine & "Port number mising")
                            Continue For
                        End If

                        If String.IsNullOrEmpty(builder("uid")) Then
                            MsgBox("Unable to save connection information for connection """ & kvp.Key & """" &
                                    Environment.NewLine & Environment.NewLine & "username missing mising")
                            Continue For
                        End If

                        If String.IsNullOrEmpty(builder("pwd")) Then
                            MsgBox("Unable to save connection information for connection """ & kvp.Key & """" &
                                    Environment.NewLine & Environment.NewLine & "Password mising")
                            Continue For
                        End If


                        'only save valid connection string values
                        'A valid connection detail should contain a connection name, a pipe character `|` and a connection string
                        writer.WriteLine(kvp.Key & "|" & builder.ConnectionString)

                    Catch ex As Exception
                        MsgBox("Unable to save connection information for connection """ & kvp.Key & """" &
                                Environment.NewLine & Environment.NewLine & ex.Message)
                        Continue For
                    End Try
                Next

            End Using

        Catch ex As Exception
            MsgBox("Error in writing connection details" & Environment.NewLine & Environment.NewLine & ex.Message)
        End Try

    End Sub


    'temporary code for visual studio design time
    Public Shared Function IsInDesignMode() As Boolean
        'temporary for developers to prevent visual studio from executing code during design mode
        Dim process As System.Diagnostics.Process = System.Diagnostics.Process.GetCurrentProcess()
        If process.ProcessName = "devenv" Then
            process.Dispose()
            Return True
        End If
        Return False
    End Function

End Class
