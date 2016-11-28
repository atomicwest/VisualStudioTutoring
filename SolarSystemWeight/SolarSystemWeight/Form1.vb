Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim weight As Integer = Integer.Parse(txtWeight.Text)
        Dim newWeight As Decimal

        Select Case cboPlanets.SelectedItem
            Case "Mercury"
                newWeight = 0.378 * weight
            Case "Venus"
                newWeight = 0.905 * weight
            Case "Earth"
                newWeight = 1.0 * weight
            Case "Mars"
                newWeight = 0.379 * weight
            Case "Jupiter"
                newWeight = 2.529 * weight
            Case "Saturn"
                newWeight = 1.066 * weight
            Case "Uranus"
                newWeight = 0.903 * weight
            Case "Neptune"
                newWeight = 1.096 * weight
            Case "Pluto"
                newWeight = 0.069 * weight
        End Select

        lblResult.Text = "Your weight on " & cboPlanets.SelectedItem & " is " & newWeight.ToString("n0") & " pounds."

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtWeight.Focus()
    End Sub
End Class
