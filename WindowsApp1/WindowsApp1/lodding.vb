Public Class lodding
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        If ProgressBar1.Value = 120 Then
            Me.Visible = False
            Timer1.Enabled = False
            Main_Page.Show()
        Else
            ProgressBar1.Increment(1)
        End If
    End Sub

    Private Sub lodding_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class