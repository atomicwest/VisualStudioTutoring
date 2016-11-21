Public Class Form1

    Dim intCount As Integer = 0

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim blnGender As Boolean
        Dim intQuantity As Integer = 1234
        Dim strFirstName As String = "Jenny"
        lblPrice.Text = intQuantity.ToString("c")
        txtQuantity.Focus()
        'Dim intCount As Integer = 0
        'intCount = intCount + 1I
        lblAdd.Text = intCount.ToString()
        Dim decYTD As Decimal = 100000.23
        Dim decGrossPay As Decimal = 100.41
        decYTD = decYTD + decGrossPay

    End Sub

    Private Sub lblPrice_Click(sender As Object, e As EventArgs) Handles lblPrice.Click

    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        intCount = intCount + 1I
        lblAdd.Text = intCount
    End Sub
End Class
