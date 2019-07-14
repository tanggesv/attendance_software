Imports System.Data.Sql
Imports System.Data.SqlClient

Module ModConnection
    Public CONN As SqlConnection
    Public DS As DataSet
    Public DR As SqlDataReader
    Public DA As SqlDataAdapter
    Public CMD As SqlCommand
    Public TBL As DataTable
    Public sql As String
    Public Save, Delete, ubah As String

    Public Sub OpenDB()
        sql = "Data Source=192.168.86.133;Initial Catalog=HITFPTA;Persist Security Info=True;UID=sa;PWD=asd"

        conn = New SqlConnection(sql)
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
        Catch ex As Exception
            MsgBox(Err.Description, MsgBoxStyle.Critical, "Error")
            End
        End Try
    End Sub
End Module
