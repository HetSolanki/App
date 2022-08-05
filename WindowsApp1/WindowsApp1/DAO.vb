Imports System.Data.SqlClient
Public Class DAO
    Private con As SqlClient.SqlConnection

    Public Sub New()
        con = New SqlConnection("Data Source=103.212.121.67;User ID=data_stu4;Password=Lovecoding@6750")

        Try
            con.Open()
            con.Close()
        Catch ex As Exception
            MessageBox.Show("Please check database connectivity..!")
        End Try
    End Sub

    Public Function getData(ByVal str As String) As SqlDataReader
        Dim obj As SqlDataReader
        con.Open()
        Dim cmd As New SqlCommand(str, con)
        obj = cmd.ExecuteReader
        Return obj
    End Function

    Public Sub close_conn()
        If con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub
End Class
