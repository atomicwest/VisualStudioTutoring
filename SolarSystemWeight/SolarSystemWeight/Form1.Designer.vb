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
        Me.txtWeight = New System.Windows.Forms.TextBox()
        Me.lblStaticWeight = New System.Windows.Forms.Label()
        Me.cboPlanets = New System.Windows.Forms.ComboBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.lblResult = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtWeight
        '
        Me.txtWeight.Location = New System.Drawing.Point(30, 28)
        Me.txtWeight.Name = "txtWeight"
        Me.txtWeight.Size = New System.Drawing.Size(119, 20)
        Me.txtWeight.TabIndex = 0
        Me.txtWeight.Text = "0"
        '
        'lblStaticWeight
        '
        Me.lblStaticWeight.AutoSize = True
        Me.lblStaticWeight.Location = New System.Drawing.Point(27, 9)
        Me.lblStaticWeight.Name = "lblStaticWeight"
        Me.lblStaticWeight.Size = New System.Drawing.Size(92, 13)
        Me.lblStaticWeight.TabIndex = 1
        Me.lblStaticWeight.Text = "Enter your weight:"
        '
        'cboPlanets
        '
        Me.cboPlanets.FormattingEnabled = True
        Me.cboPlanets.Items.AddRange(New Object() {"Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune", "Pluto"})
        Me.cboPlanets.Location = New System.Drawing.Point(30, 74)
        Me.cboPlanets.Name = "cboPlanets"
        Me.cboPlanets.Size = New System.Drawing.Size(118, 21)
        Me.cboPlanets.TabIndex = 2
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(30, 141)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(107, 32)
        Me.btnCalc.TabIndex = 3
        Me.btnCalc.Text = "Calculate Weight"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'lblResult
        '
        Me.lblResult.AutoSize = True
        Me.lblResult.Location = New System.Drawing.Point(27, 196)
        Me.lblResult.Name = "lblResult"
        Me.lblResult.Size = New System.Drawing.Size(63, 13)
        Me.lblResult.TabIndex = 4
        Me.lblResult.Text = "Your weight"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(188, 227)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.lblResult)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.cboPlanets)
        Me.Controls.Add(Me.lblStaticWeight)
        Me.Controls.Add(Me.txtWeight)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Solar System Weight Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtWeight As System.Windows.Forms.TextBox
    Friend WithEvents lblStaticWeight As System.Windows.Forms.Label
    Friend WithEvents cboPlanets As System.Windows.Forms.ComboBox
    Friend WithEvents btnCalc As System.Windows.Forms.Button
    Friend WithEvents lblResult As System.Windows.Forms.Label
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
