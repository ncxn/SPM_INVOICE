Imports MySql.Data.MySqlClient
Public Class MYSQLSERVER
    Public Property Server = "173.254.231.108"
    Public Property UserName = "root"
    Public Property Password = "mmttmhh"
    Public Property Database = "spm"

    Public Function connstr() As String
        connstr = "server=" & Server & ";" & "userid=" & UserName & ";" & "password=" & Password & ";" & "database=" & Database
        Return connstr
    End Function
    Public Function Get_Row(SQLStatement As String) As ArrayList
        Dim Result As New ArrayList
        Dim conn As New MySqlConnection(connstr)

        Try
            conn.Open()
            Dim cmd As New MySqlCommand(SQLStatement, conn)
            Dim reader As MySqlDataReader = cmd.ExecuteReader()

            While reader.Read()
                Dim dict As New Dictionary(Of String, Object)
                For count As Integer = 0 To (reader.FieldCount - 1)
                    dict.Add(reader.GetName(count), reader(count))
                Next
                Result.Add(dict)
            End While
            reader.Close()

        Catch ex As Exception
            MessageBox.Show("không thể kết nối với dữ liệu: " & ex.Message & Err.Number)
        Finally
            conn.Close()
        End Try
        GC.Collect()
        Return Result
    End Function
    Public Function Get_Value(SQLStatement As String) As String
        Dim conn As New MySqlConnection(connstr)
        Dim Result As String
        Try
            conn.Open()
            Dim cmd As New MySqlCommand(SQLStatement, conn)
            Result = cmd.ExecuteScalar()
            conn.Close()
        Catch ex As Exception
            Console.WriteLine("MySQL retrieve value: " & ex.Message & Err.Number)
            Result = Nothing
        Finally
            conn.Dispose()
            conn = Nothing
        End Try
        GC.Collect()
        Return Result
    End Function
    Public Function Get_Table(SQLStatement As String) As DataTable
        Dim table As New DataTable
        Dim Reader As MySqlDataReader
        Dim conn As New MySqlConnection(connstr)
        Dim MySQL_Command As New MySqlCommand
        Try
            conn.Open()
            Dim da As New MySqlDataAdapter(SQLStatement, conn)
            table.Load(Reader)
            Reader.Close()
            MySQL_Connection.Close()
        Catch ex As Exception
            MessageBox.Show("Không thể kết nối với dữ liệu: " & ex.Message & Err.Number)
            table = Nothing
        Finally
            MySQL_Connection.Dispose()
            MySQL_Connection = Nothing
            Reader = Nothing
        End Try
        GC.Collect()
        Return table
    End Function
    Public Function Insert_Row(SQLStatement As String) As Boolean
        Insert_Row = False
        Dim MySQL_Connection As New MySqlConnection
        Dim MySQL_Command As New MySqlCommand
        Try
            MySQL_Connection.ConnectionString = Connect_Server()
            MySQL_Command.CommandText = SQLStatement
            MySQL_Command.Connection = MySQL_Connection
            MySQL_Connection.Open()
            MySQL_Command.ExecuteNonQuery()
            MySQL_Connection.Close()
            Insert_Row = True
        Catch ex As MySqlException
            Console.WriteLine("MySQL insert: " & ex.Message & Err.Number)
            Insert_Row = False
        Finally
            MySQL_Connection.Dispose()
            MySQL_Connection = Nothing
        End Try
        GC.Collect()
    End Function
    Public Function Delete_Row(SQLStatement As String) As Boolean
        Delete_Row = False
        Dim MySQL_Connection As New MySqlConnection
        Dim MySQL_Command As New MySqlCommand
        Try
            MySQL_Connection.ConnectionString = Connect_Server()
            MySQL_Command.CommandText = SQLStatement
            MySQL_Command.Connection = MySQL_Connection
            MySQL_Connection.Open()
            MySQL_Command.ExecuteNonQuery()
            MySQL_Connection.Close()
            Delete_Row = True
        Catch ex As MySqlException
            Console.WriteLine("MySQL delete: " & ex.Message & Err.Number)
            Delete_Row = False
        Finally
            MySQL_Connection.Dispose()
            MySQL_Connection = Nothing
        End Try
        GC.Collect()
    End Function
End Class
