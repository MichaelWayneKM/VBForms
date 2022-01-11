Public Class Form1
    Private Sub LblTitle(sender As Object, e As EventArgs) Handles TitleNm.Click
        TitleNm.Text = "Mike"
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If (ProgressBar1.Value < 100) Then


            ProgressBar1.Value += 10
        ElseIf (ProgressBar1.Value >= 100) Then

        End If
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Label4.Text = TextBox1.Text

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label4.Text = "Hello " & TextBox1.Text & " " & TextBox2.Text

    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub
End Class
