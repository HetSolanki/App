Public Class Login_Page
    Private Sub Login_Page_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim d As New DAO
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim d As New DAO
        Dim obj As SqlClient.SqlDataReader
        Dim flag As Boolean = False
        Dim u_type As String
        obj = d.getData("Select * from Admin where username = '" & TextBox1.Text & "' and password = '" & TextBox2.Text & "'")
        While obj.Read
            flag = True
            u_type = obj.Item("u_type")
        End While

        d.close_conn()

        If flag Then
            uname = TextBox1.Text
            utype = u_type
            Dim mainpage As New Form1
            Me.Hide()
            mainpage.Show()
        Else
            MsgBox("Enter Valid Username And Password")
            TextBox2.Text = ""
            TextBox1.Focus()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown, TextBox2.KeyDown, Button1.KeyDown, TextBox1.TextChanged
        If e.KeyCode = Keys.Enter Then
            If sender.name = TextBox1.Name Then
                TextBox2.Focus()
            ElseIf sender.name = TextBox2.Name Then
                Button1_Click(sender, e)
            End If

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

End Class