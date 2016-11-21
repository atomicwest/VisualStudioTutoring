Public Class Form1

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles grpEducation.Enter

    End Sub

    Private Sub btnCompute_Click(sender As Object, e As EventArgs) Handles btnCompute.Click
        Dim tally As Integer = 0
        Dim rating As String

        'Add all radio buttons together
        'Education Level
        If radEdu4yr.Checked Then tally = tally + 5
        If radEdu2yr.Checked Then tally = tally + 3
        If radEduHS.Checked Then tally = tally + 1
        If radEduNoHS.Checked Then tally = tally + 0

        'Education Field
        If radEngineering.Checked Then tally = tally + 5
        If radBusiness.Checked Then tally = tally + 3
        If radOther.Checked Then tally = tally + 1

        'Experience Years
        If radExp5plus.Checked Then tally = tally + 5
        If radExp3to5.Checked Then tally = tally + 3
        If radExpLess3.Checked Then tally = tally + 1

        'Experience Field
        If radMnf.Checked Then tally = tally + 5
        If radSales.Checked Then tally = tally + 3
        If radOtherField.Checked Then tally = tally + 1

        'Computer Experience
        If radYes.Checked Then tally = tally + 5
        If radNo.Checked Then tally = tally + 5

        Select Case tally
            Case Is > 20
                rating = "Desirable"
            Case 10 To 20
                rating = "Possible"
            Case Else
                rating = "Unacceptable"
        End Select

        lblTally.Text = "Final Tally: " & tally.ToString()
        lblRating.Text = "Rating: " & rating

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtApplicantName.Text = "Applicant Name"

        radEdu4yr.Checked = False
        radEdu2yr.Checked = False
        radEduHS.Checked = False
        radEduNoHS.Checked = True

        radEngineering.Checked = False
        radBusiness.Checked = False
        radOther.Checked = True

        radExp5plus.Checked = False
        radExp3to5.Checked = False
        radExpLess3.Checked = True

        radMnf.Checked = False
        radSales.Checked = False
        radOtherField.Checked = True

        radYes.Checked = False
        radNo.Checked = True

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txtApplicantName.Focus()

        radEduNoHS.Checked = True
        radOther.Checked = True
        radExpLess3.Checked = True
        radOtherField.Checked = True
        radNo.Checked = True
    End Sub
End Class
