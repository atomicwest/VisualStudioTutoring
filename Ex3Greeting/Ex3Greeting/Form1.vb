Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnEnglish_Click(sender As Object, e As EventArgs) Handles btnEnglish.Click
        lblGreeting.Text = "Hello, " & TextBox1.Text
    End Sub

    Private Sub btnSpanish_Click(sender As Object, e As EventArgs) Handles btnSpanish.Click
        lblGreeting.Text = "Hola, " & TextBox1.Text
    End Sub

    Private Sub btnFrench_Click(sender As Object, e As EventArgs) Handles btnFrench.Click
        lblGreeting.Text = "Bonjour, " & TextBox1.Text
    End Sub

    Private Sub btnItalian_Click(sender As Object, e As EventArgs) Handles btnItalian.Click
        lblGreeting.Text = "Ciao, " & TextBox1.Text
    End Sub
End Class
