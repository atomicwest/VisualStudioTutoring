<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtApplicantName = New System.Windows.Forms.TextBox()
        Me.lblTally = New System.Windows.Forms.Label()
        Me.btnCompute = New System.Windows.Forms.Button()
        Me.grpEducation = New System.Windows.Forms.GroupBox()
        Me.radEduNoHS = New System.Windows.Forms.RadioButton()
        Me.radEduHS = New System.Windows.Forms.RadioButton()
        Me.radEdu2yr = New System.Windows.Forms.RadioButton()
        Me.radEdu4yr = New System.Windows.Forms.RadioButton()
        Me.grpEduField = New System.Windows.Forms.GroupBox()
        Me.radOther = New System.Windows.Forms.RadioButton()
        Me.radBusiness = New System.Windows.Forms.RadioButton()
        Me.radEngineering = New System.Windows.Forms.RadioButton()
        Me.grpExpYears = New System.Windows.Forms.GroupBox()
        Me.radExpLess3 = New System.Windows.Forms.RadioButton()
        Me.radExp3to5 = New System.Windows.Forms.RadioButton()
        Me.radExp5plus = New System.Windows.Forms.RadioButton()
        Me.grpExpField = New System.Windows.Forms.GroupBox()
        Me.radOtherField = New System.Windows.Forms.RadioButton()
        Me.radSales = New System.Windows.Forms.RadioButton()
        Me.radMnf = New System.Windows.Forms.RadioButton()
        Me.grpCompExp = New System.Windows.Forms.GroupBox()
        Me.radNo = New System.Windows.Forms.RadioButton()
        Me.radYes = New System.Windows.Forms.RadioButton()
        Me.lblRating = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.grpEducation.SuspendLayout()
        Me.grpEduField.SuspendLayout()
        Me.grpExpYears.SuspendLayout()
        Me.grpExpField.SuspendLayout()
        Me.grpCompExp.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtApplicantName
        '
        Me.txtApplicantName.Location = New System.Drawing.Point(22, 10)
        Me.txtApplicantName.Name = "txtApplicantName"
        Me.txtApplicantName.Size = New System.Drawing.Size(197, 20)
        Me.txtApplicantName.TabIndex = 0
        Me.txtApplicantName.Text = "Applicant Name"
        '
        'lblTally
        '
        Me.lblTally.AutoSize = True
        Me.lblTally.Location = New System.Drawing.Point(20, 458)
        Me.lblTally.Name = "lblTally"
        Me.lblTally.Size = New System.Drawing.Size(60, 13)
        Me.lblTally.TabIndex = 7
        Me.lblTally.Text = "Final Tally: "
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(22, 413)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(64, 29)
        Me.btnCompute.TabIndex = 6
        Me.btnCompute.Text = "Compute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'grpEducation
        '
        Me.grpEducation.Controls.Add(Me.radEduNoHS)
        Me.grpEducation.Controls.Add(Me.radEduHS)
        Me.grpEducation.Controls.Add(Me.radEdu2yr)
        Me.grpEducation.Controls.Add(Me.radEdu4yr)
        Me.grpEducation.Location = New System.Drawing.Point(22, 50)
        Me.grpEducation.Name = "grpEducation"
        Me.grpEducation.Size = New System.Drawing.Size(200, 124)
        Me.grpEducation.TabIndex = 1
        Me.grpEducation.TabStop = False
        Me.grpEducation.Text = "Education Level"
        '
        'radEduNoHS
        '
        Me.radEduNoHS.AutoSize = True
        Me.radEduNoHS.Location = New System.Drawing.Point(15, 94)
        Me.radEduNoHS.Name = "radEduNoHS"
        Me.radEduNoHS.Size = New System.Drawing.Size(129, 17)
        Me.radEduNoHS.TabIndex = 3
        Me.radEduNoHS.TabStop = True
        Me.radEduNoHS.Text = "Not High School Grad"
        Me.radEduNoHS.UseVisualStyleBackColor = True
        '
        'radEduHS
        '
        Me.radEduHS.AutoSize = True
        Me.radEduHS.Location = New System.Drawing.Point(15, 71)
        Me.radEduHS.Name = "radEduHS"
        Me.radEduHS.Size = New System.Drawing.Size(109, 17)
        Me.radEduHS.TabIndex = 2
        Me.radEduHS.TabStop = True
        Me.radEduHS.Text = "High School Grad"
        Me.radEduHS.UseVisualStyleBackColor = True
        '
        'radEdu2yr
        '
        Me.radEdu2yr.AutoSize = True
        Me.radEdu2yr.Location = New System.Drawing.Point(15, 48)
        Me.radEdu2yr.Name = "radEdu2yr"
        Me.radEdu2yr.Size = New System.Drawing.Size(114, 17)
        Me.radEdu2yr.TabIndex = 1
        Me.radEdu2yr.TabStop = True
        Me.radEdu2yr.Text = "2 Years  of College"
        Me.radEdu2yr.UseVisualStyleBackColor = True
        '
        'radEdu4yr
        '
        Me.radEdu4yr.AutoSize = True
        Me.radEdu4yr.Location = New System.Drawing.Point(15, 25)
        Me.radEdu4yr.Name = "radEdu4yr"
        Me.radEdu4yr.Size = New System.Drawing.Size(114, 17)
        Me.radEdu4yr.TabIndex = 0
        Me.radEdu4yr.TabStop = True
        Me.radEdu4yr.Text = "4 Years  of College"
        Me.radEdu4yr.UseVisualStyleBackColor = True
        '
        'grpEduField
        '
        Me.grpEduField.Controls.Add(Me.radOther)
        Me.grpEduField.Controls.Add(Me.radBusiness)
        Me.grpEduField.Controls.Add(Me.radEngineering)
        Me.grpEduField.Location = New System.Drawing.Point(249, 50)
        Me.grpEduField.Name = "grpEduField"
        Me.grpEduField.Size = New System.Drawing.Size(200, 124)
        Me.grpEduField.TabIndex = 2
        Me.grpEduField.TabStop = False
        Me.grpEduField.Text = "Education Field"
        '
        'radOther
        '
        Me.radOther.AutoSize = True
        Me.radOther.Location = New System.Drawing.Point(15, 71)
        Me.radOther.Name = "radOther"
        Me.radOther.Size = New System.Drawing.Size(51, 17)
        Me.radOther.TabIndex = 2
        Me.radOther.TabStop = True
        Me.radOther.Text = "Other"
        Me.radOther.UseVisualStyleBackColor = True
        '
        'radBusiness
        '
        Me.radBusiness.AutoSize = True
        Me.radBusiness.Location = New System.Drawing.Point(15, 48)
        Me.radBusiness.Name = "radBusiness"
        Me.radBusiness.Size = New System.Drawing.Size(67, 17)
        Me.radBusiness.TabIndex = 1
        Me.radBusiness.TabStop = True
        Me.radBusiness.Text = "Business"
        Me.radBusiness.UseVisualStyleBackColor = True
        '
        'radEngineering
        '
        Me.radEngineering.AutoSize = True
        Me.radEngineering.Location = New System.Drawing.Point(15, 25)
        Me.radEngineering.Name = "radEngineering"
        Me.radEngineering.Size = New System.Drawing.Size(81, 17)
        Me.radEngineering.TabIndex = 0
        Me.radEngineering.TabStop = True
        Me.radEngineering.Text = "Engineering"
        Me.radEngineering.UseVisualStyleBackColor = True
        '
        'grpExpYears
        '
        Me.grpExpYears.Controls.Add(Me.radExpLess3)
        Me.grpExpYears.Controls.Add(Me.radExp3to5)
        Me.grpExpYears.Controls.Add(Me.radExp5plus)
        Me.grpExpYears.Location = New System.Drawing.Point(22, 200)
        Me.grpExpYears.Name = "grpExpYears"
        Me.grpExpYears.Size = New System.Drawing.Size(200, 103)
        Me.grpExpYears.TabIndex = 3
        Me.grpExpYears.TabStop = False
        Me.grpExpYears.Text = "Experience in Years"
        '
        'radExpLess3
        '
        Me.radExpLess3.AutoSize = True
        Me.radExpLess3.Location = New System.Drawing.Point(15, 71)
        Me.radExpLess3.Name = "radExpLess3"
        Me.radExpLess3.Size = New System.Drawing.Size(108, 17)
        Me.radExpLess3.TabIndex = 2
        Me.radExpLess3.TabStop = True
        Me.radExpLess3.Text = "Less than 3 years"
        Me.radExpLess3.UseVisualStyleBackColor = True
        '
        'radExp3to5
        '
        Me.radExp3to5.AutoSize = True
        Me.radExp3to5.Location = New System.Drawing.Point(15, 48)
        Me.radExp3to5.Name = "radExp3to5"
        Me.radExp3to5.Size = New System.Drawing.Size(80, 17)
        Me.radExp3to5.TabIndex = 1
        Me.radExp3to5.TabStop = True
        Me.radExp3to5.Text = "3 to 5 years"
        Me.radExp3to5.UseVisualStyleBackColor = True
        '
        'radExp5plus
        '
        Me.radExp5plus.AutoSize = True
        Me.radExp5plus.Location = New System.Drawing.Point(15, 25)
        Me.radExp5plus.Name = "radExp5plus"
        Me.radExp5plus.Size = New System.Drawing.Size(110, 17)
        Me.radExp5plus.TabIndex = 0
        Me.radExp5plus.TabStop = True
        Me.radExp5plus.Text = "More than 5 years"
        Me.radExp5plus.UseVisualStyleBackColor = True
        '
        'grpExpField
        '
        Me.grpExpField.Controls.Add(Me.radOtherField)
        Me.grpExpField.Controls.Add(Me.radSales)
        Me.grpExpField.Controls.Add(Me.radMnf)
        Me.grpExpField.Location = New System.Drawing.Point(249, 200)
        Me.grpExpField.Name = "grpExpField"
        Me.grpExpField.Size = New System.Drawing.Size(200, 103)
        Me.grpExpField.TabIndex = 4
        Me.grpExpField.TabStop = False
        Me.grpExpField.Text = "Experience in Field"
        '
        'radOtherField
        '
        Me.radOtherField.AutoSize = True
        Me.radOtherField.Location = New System.Drawing.Point(15, 71)
        Me.radOtherField.Name = "radOtherField"
        Me.radOtherField.Size = New System.Drawing.Size(51, 17)
        Me.radOtherField.TabIndex = 2
        Me.radOtherField.TabStop = True
        Me.radOtherField.Text = "Other"
        Me.radOtherField.UseVisualStyleBackColor = True
        '
        'radSales
        '
        Me.radSales.AutoSize = True
        Me.radSales.Location = New System.Drawing.Point(15, 48)
        Me.radSales.Name = "radSales"
        Me.radSales.Size = New System.Drawing.Size(51, 17)
        Me.radSales.TabIndex = 1
        Me.radSales.TabStop = True
        Me.radSales.Text = "Sales"
        Me.radSales.UseVisualStyleBackColor = True
        '
        'radMnf
        '
        Me.radMnf.AutoSize = True
        Me.radMnf.Location = New System.Drawing.Point(15, 25)
        Me.radMnf.Name = "radMnf"
        Me.radMnf.Size = New System.Drawing.Size(93, 17)
        Me.radMnf.TabIndex = 0
        Me.radMnf.TabStop = True
        Me.radMnf.Text = "Manufacturing"
        Me.radMnf.UseVisualStyleBackColor = True
        '
        'grpCompExp
        '
        Me.grpCompExp.Controls.Add(Me.radNo)
        Me.grpCompExp.Controls.Add(Me.radYes)
        Me.grpCompExp.Location = New System.Drawing.Point(22, 323)
        Me.grpCompExp.Name = "grpCompExp"
        Me.grpCompExp.Size = New System.Drawing.Size(200, 79)
        Me.grpCompExp.TabIndex = 5
        Me.grpCompExp.TabStop = False
        Me.grpCompExp.Text = "Computer Experience"
        '
        'radNo
        '
        Me.radNo.AutoSize = True
        Me.radNo.Location = New System.Drawing.Point(15, 48)
        Me.radNo.Name = "radNo"
        Me.radNo.Size = New System.Drawing.Size(39, 17)
        Me.radNo.TabIndex = 1
        Me.radNo.TabStop = True
        Me.radNo.Text = "No"
        Me.radNo.UseVisualStyleBackColor = True
        '
        'radYes
        '
        Me.radYes.AutoSize = True
        Me.radYes.Location = New System.Drawing.Point(15, 25)
        Me.radYes.Name = "radYes"
        Me.radYes.Size = New System.Drawing.Size(43, 17)
        Me.radYes.TabIndex = 0
        Me.radYes.TabStop = True
        Me.radYes.Text = "Yes"
        Me.radYes.UseVisualStyleBackColor = True
        '
        'lblRating
        '
        Me.lblRating.AutoSize = True
        Me.lblRating.Location = New System.Drawing.Point(20, 483)
        Me.lblRating.Name = "lblRating"
        Me.lblRating.Size = New System.Drawing.Size(44, 13)
        Me.lblRating.TabIndex = 8
        Me.lblRating.Text = "Rating: "
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(295, 413)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(87, 29)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(295, 458)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(87, 29)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 523)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblRating)
        Me.Controls.Add(Me.grpCompExp)
        Me.Controls.Add(Me.grpExpField)
        Me.Controls.Add(Me.grpExpYears)
        Me.Controls.Add(Me.grpEduField)
        Me.Controls.Add(Me.grpEducation)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.lblTally)
        Me.Controls.Add(Me.txtApplicantName)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Job Applicant Screening"
        Me.grpEducation.ResumeLayout(False)
        Me.grpEducation.PerformLayout()
        Me.grpEduField.ResumeLayout(False)
        Me.grpEduField.PerformLayout()
        Me.grpExpYears.ResumeLayout(False)
        Me.grpExpYears.PerformLayout()
        Me.grpExpField.ResumeLayout(False)
        Me.grpExpField.PerformLayout()
        Me.grpCompExp.ResumeLayout(False)
        Me.grpCompExp.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtApplicantName As System.Windows.Forms.TextBox
    Friend WithEvents lblTally As System.Windows.Forms.Label
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents grpEducation As System.Windows.Forms.GroupBox
    Friend WithEvents radEduNoHS As System.Windows.Forms.RadioButton
    Friend WithEvents radEduHS As System.Windows.Forms.RadioButton
    Friend WithEvents radEdu2yr As System.Windows.Forms.RadioButton
    Friend WithEvents radEdu4yr As System.Windows.Forms.RadioButton
    Friend WithEvents grpEduField As System.Windows.Forms.GroupBox
    Friend WithEvents radOther As System.Windows.Forms.RadioButton
    Friend WithEvents radBusiness As System.Windows.Forms.RadioButton
    Friend WithEvents radEngineering As System.Windows.Forms.RadioButton
    Friend WithEvents grpExpYears As System.Windows.Forms.GroupBox
    Friend WithEvents radExpLess3 As System.Windows.Forms.RadioButton
    Friend WithEvents radExp3to5 As System.Windows.Forms.RadioButton
    Friend WithEvents radExp5plus As System.Windows.Forms.RadioButton
    Friend WithEvents grpExpField As System.Windows.Forms.GroupBox
    Friend WithEvents radOtherField As System.Windows.Forms.RadioButton
    Friend WithEvents radSales As System.Windows.Forms.RadioButton
    Friend WithEvents radMnf As System.Windows.Forms.RadioButton
    Friend WithEvents grpCompExp As System.Windows.Forms.GroupBox
    Friend WithEvents radNo As System.Windows.Forms.RadioButton
    Friend WithEvents radYes As System.Windows.Forms.RadioButton
    Friend WithEvents lblRating As System.Windows.Forms.Label
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
