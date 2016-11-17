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
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSaying1 = New System.Windows.Forms.Button()
        Me.btnSaying2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.Location = New System.Drawing.Point(78, 9)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(81, 13)
        Me.lblDisplay.TabIndex = 0
        Me.lblDisplay.Text = "Display Proverb"
        Me.lblDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(81, 61)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(120, 44)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "End"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnSaying1
        '
        Me.btnSaying1.Location = New System.Drawing.Point(81, 124)
        Me.btnSaying1.Name = "btnSaying1"
        Me.btnSaying1.Size = New System.Drawing.Size(120, 44)
        Me.btnSaying1.TabIndex = 2
        Me.btnSaying1.Text = "Proverb 1"
        Me.btnSaying1.UseVisualStyleBackColor = True
        '
        'btnSaying2
        '
        Me.btnSaying2.Location = New System.Drawing.Point(81, 188)
        Me.btnSaying2.Name = "btnSaying2"
        Me.btnSaying2.Size = New System.Drawing.Size(120, 44)
        Me.btnSaying2.TabIndex = 3
        Me.btnSaying2.Text = "Proverb 2"
        Me.btnSaying2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.btnSaying2)
        Me.Controls.Add(Me.btnSaying1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblDisplay)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Proverb Buttons"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblDisplay As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnSaying1 As System.Windows.Forms.Button
    Friend WithEvents btnSaying2 As System.Windows.Forms.Button

End Class
