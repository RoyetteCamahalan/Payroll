Imports System.Data
Imports System.Data.SqlClient
Public Class sqlbridge
    Public sqlCommand As New SqlCommand
    Private dt As New DataTable
    Private sqladapter As New SqlDataAdapter

    Public Function Fetchdata(ByRef SP_Name As String, ByRef Param_Name As String(), ByRef Param_Value As String()) As DataTable
        Try
            dt.Clear()
            sqlCommand = New SqlCommand
            sqlCommand.Connection = conn
            sqlCommand.CommandText = SP_Name
            sqlCommand.CommandType = CommandType.StoredProcedure

            For i As Integer = 0 To Param_Name.Length - 1
                sqlCommand.Parameters.AddWithValue(Param_Name(i), Param_Value(i))
            Next

            sqladapter = New SqlDataAdapter(sqlCommand)
            sqladapter.Fill(dt)
        Catch ex As Exception

        End Try
        Return dt
    End Function
    Public Function ReturnNewPK(ByRef SP_Name As String, ByRef Param_Name As String(), ByRef Param_Value As Object()) As Long
        Try
            sqlCommand = New SqlCommand
            sqlCommand.Connection = conn
            sqlCommand.CommandText = SP_Name
            sqlCommand.CommandType = CommandType.StoredProcedure

            For i As Integer = 0 To Param_Name.Length - 1
                sqlCommand.Parameters.AddWithValue(Param_Name(i), Param_Value(i))
            Next
            sqlCommand.Parameters.Add("NewPK", SqlDbType.BigInt).Direction = ParameterDirection.Output
            sqlCommand.ExecuteNonQuery()
            Return sqlCommand.Parameters("NewPK").Value
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Transact(ByRef SP_Name As String, ByRef Param_Name As String(), ByRef Param_Value As Object()) As Boolean
        Try
            sqlCommand = New SqlCommand
            sqlCommand.Connection = conn
            sqlCommand.CommandText = SP_Name
            sqlCommand.CommandType = CommandType.StoredProcedure

            For i As Integer = 0 To Param_Name.Length - 1
                sqlCommand.Parameters.AddWithValue(Param_Name(i), Param_Value(i))
            Next
            Return sqlCommand.ExecuteNonQuery > 0
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
