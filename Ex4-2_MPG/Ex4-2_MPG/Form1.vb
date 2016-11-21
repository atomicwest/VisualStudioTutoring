Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnMPG_Click(sender As Object, e As EventArgs) Handles btnMPG.Click
        Dim myMiles As Decimal
        Dim myGallons As Decimal
        Dim mpg As Decimal
        myMiles = Decimal.Parse(txtMiles.Text)
        myGallons = Decimal.Parse(txtGallons.Text)
        mpg = myMiles / myGallons
        lblMPG.Text = "Miles Per Gallon: " & mpg.ToString("n1")

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtGallons.Text = ""
        txtMiles.Text = ""
    End Sub
End Class
