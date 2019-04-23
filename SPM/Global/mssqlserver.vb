Imports System.Data.SqlClient

Public Class Mssqlserver
    Public Shared Function GetDBConnection(ByVal datasource As String, ByVal database As String, ByVal username As String, ByVal password As String) As SqlConnection
        Dim connString As String = "Data Source=" & datasource & ";Initial Catalog=" & database & ";Persist Security Info=True;User ID=" & username & ";Password=" & password
        Dim conn As SqlConnection = New SqlConnection(connString)
        Return conn
    End Function
    Public Shared Function GetDBConnection() As SqlConnection
        Dim datasource As String = "ServerKT"
        Dim database As String = "spm_09"
        Dim username As String = "sa"
        Dim password As String = "1"
        Return GetDBConnection(datasource, database, username, password)
    End Function
    'SqlConnection conn = DBUtils.GetDBConnection();

    '// Way 1
    '-----------

    '// Create a Command from Connection object.
    'SqlCommand cmd = conn.CreateCommand();

    '// Set Command Text
    'cmd.CommandText = sql;

    '// Way 2
    '-----------

    '// Create a Command.
    'SqlCommand cmd = New SqlCommand(Sql);

    '// Set Connection for Command.
    'cmd.Connection = conn;

    '// Way 3
    '------------

    '// Create a Command with 2 parameter: Command Text & Connection.
    'SqlCommand cmd = New SqlCommand(Sql, conn);
    Public Sub ExecuteNonQuery(cmdTxt As String, params As Dictionary(Of String, Object))
        Using cmd As SqlCommand = BuildCommand(cmdTxt, params)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

    Public Function ExecuteReader(cmdTxt As String, params As Dictionary(Of String, Object)) As SqlDataReader
        Using cmd As SqlCommand = BuildCommand(cmdTxt, params)
            Return cmd.ExecuteReader()
        End Using
    End Function

    Public Function ExecuteScalar(cmdTxt As String, params As Dictionary(Of String, Object)) As Object
        Using cmd As SqlCommand = BuildCommand(cmdTxt, params)
            Return cmd.ExecuteScalar()
        End Using
    End Function

    Private Function BuildCommand(cmdTxt As String, params As Dictionary(Of String, Object)) As SqlCommand
        Using con = GetDBConnection()
            Using cmd As SqlCommand = con.CreateCommand()
                cmd.CommandType = CommandType.StoredProcedure
                cmd.CommandText = cmdTxt
                AddParameters(cmd, params)
                con.Open() 'working on the assumption this command will be run as soon as it's retuned; so this open is left as late as possible but here to avoid duplicate code
                Return cmd
            End Using
        End Using
    End Function

    Private Sub AddParameters(ByRef cmd As SqlCommand, params As Dictionary(Of String, Object))
        If Not params Is Nothing Then
            For Each kvp As KeyValuePair(Of String, Object) In params
                cmd.Parameters.AddWithValue(kvp.Key, kvp.Value)
            Next
        End If
    End Sub
End Class
