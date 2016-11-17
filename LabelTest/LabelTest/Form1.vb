Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub lblDisplay_Click(sender As Object, e As EventArgs) Handles lblDisplay.Click

    End Sub

    Private Sub btnSaying1_Click(sender As Object, e As EventArgs) Handles btnSaying1.Click
        lblDisplay.Text = "A penny saved is a penny earned"
    End Sub

    Private Sub btnSaying2_Click(sender As Object, e As EventArgs) Handles btnSaying2.Click
        lblDisplay.Text = "An apple a day keeps the doctor away"
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
