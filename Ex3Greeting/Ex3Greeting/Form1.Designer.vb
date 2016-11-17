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
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblGreeting = New System.Windows.Forms.Label()
        Me.btnEnglish = New System.Windows.Forms.Button()
        Me.btnSpanish = New System.Windows.Forms.Button()
        Me.btnFrench = New System.Windows.Forms.Button()
        Me.btnItalian = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(40, 12)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(187, 59)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Text = "Enter your name"
        '
        'lblGreeting
        '
        Me.lblGreeting.AutoSize = True
        Me.lblGreeting.Location = New System.Drawing.Point(229, 108)
        Me.lblGreeting.Name = "lblGreeting"
        Me.lblGreeting.Size = New System.Drawing.Size(47, 13)
        Me.lblGreeting.TabIndex = 1
        Me.lblGreeting.Text = "Greeting"
        '
        'btnEnglish
        '
        Me.btnEnglish.Location = New System.Drawing.Point(40, 98)
        Me.btnEnglish.Name = "btnEnglish"
        Me.btnEnglish.Size = New System.Drawing.Size(75, 32)
        Me.btnEnglish.TabIndex = 2
        Me.btnEnglish.Text = "English"
        Me.btnEnglish.UseVisualStyleBackColor = True
        '
        'btnSpanish
        '
        Me.btnSpanish.Location = New System.Drawing.Point(40, 136)
        Me.btnSpanish.Name = "btnSpanish"
        Me.btnSpanish.Size = New System.Drawing.Size(75, 32)
        Me.btnSpanish.TabIndex = 3
        Me.btnSpanish.Text = "Spanish"
        Me.btnSpanish.UseVisualStyleBackColor = True
        '
        'btnFrench
        '
        Me.btnFrench.Location = New System.Drawing.Point(40, 174)
        Me.btnFrench.Name = "btnFrench"
        Me.btnFrench.Size = New System.Drawing.Size(75, 32)
        Me.btnFrench.TabIndex = 4
        Me.btnFrench.Text = "French"
        Me.btnFrench.UseVisualStyleBackColor = True
        '
        'btnItalian
        '
        Me.btnItalian.Location = New System.Drawing.Point(40, 212)
        Me.btnItalian.Name = "btnItalian"
        Me.btnItalian.Size = New System.Drawing.Size(75, 32)
        Me.btnItalian.TabIndex = 5
        Me.btnItalian.Text = "Italian"
        Me.btnItalian.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(40, 306)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 32)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 462)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnItalian)
        Me.Controls.Add(Me.btnFrench)
        Me.Controls.Add(Me.btnSpanish)
        Me.Controls.Add(Me.btnEnglish)
        Me.Controls.Add(Me.lblGreeting)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Foreign Language Greeting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents lblGreeting As System.Windows.Forms.Label
    Friend WithEvents btnEnglish As System.Windows.Forms.Button
    Friend WithEvents btnSpanish As System.Windows.Forms.Button
    Friend WithEvents btnFrench As System.Windows.Forms.Button
    Friend WithEvents btnItalian As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button

End Class
