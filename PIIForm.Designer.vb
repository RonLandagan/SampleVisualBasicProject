<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PIIForm
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
        Me.RecordsToGenerateLabel = New System.Windows.Forms.Label()
        Me.RecordsToGenerateTextBox = New System.Windows.Forms.TextBox()
        Me.RecordsListBox = New System.Windows.Forms.ListBox()
        Me.GenerateButton = New System.Windows.Forms.Button()
        Me.VerifyPhoneButton = New System.Windows.Forms.Button()
        Me.PrintButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RecordsToGenerateLabel
        '
        Me.RecordsToGenerateLabel.AutoSize = True
        Me.RecordsToGenerateLabel.Location = New System.Drawing.Point(20, 44)
        Me.RecordsToGenerateLabel.Name = "RecordsToGenerateLabel"
        Me.RecordsToGenerateLabel.Size = New System.Drawing.Size(122, 13)
        Me.RecordsToGenerateLabel.TabIndex = 0
        Me.RecordsToGenerateLabel.Text = "PII Records to Generate"
        '
        'RecordsToGenerateTextBox
        '
        Me.RecordsToGenerateTextBox.Location = New System.Drawing.Point(180, 41)
        Me.RecordsToGenerateTextBox.Name = "RecordsToGenerateTextBox"
        Me.RecordsToGenerateTextBox.Size = New System.Drawing.Size(61, 20)
        Me.RecordsToGenerateTextBox.TabIndex = 1
        '
        'RecordsListBox
        '
        Me.RecordsListBox.FormattingEnabled = True
        Me.RecordsListBox.Location = New System.Drawing.Point(23, 84)
        Me.RecordsListBox.Name = "RecordsListBox"
        Me.RecordsListBox.Size = New System.Drawing.Size(300, 147)
        Me.RecordsListBox.TabIndex = 2
        '
        'GenerateButton
        '
        Me.GenerateButton.Location = New System.Drawing.Point(23, 250)
        Me.GenerateButton.Name = "GenerateButton"
        Me.GenerateButton.Size = New System.Drawing.Size(75, 23)
        Me.GenerateButton.TabIndex = 3
        Me.GenerateButton.Text = "Generate"
        Me.GenerateButton.UseVisualStyleBackColor = True
        '
        'VerifyPhoneButton
        '
        Me.VerifyPhoneButton.Location = New System.Drawing.Point(104, 250)
        Me.VerifyPhoneButton.Name = "VerifyPhoneButton"
        Me.VerifyPhoneButton.Size = New System.Drawing.Size(75, 23)
        Me.VerifyPhoneButton.TabIndex = 4
        Me.VerifyPhoneButton.Text = "Verify Phone"
        Me.VerifyPhoneButton.UseVisualStyleBackColor = True
        '
        'PrintButton
        '
        Me.PrintButton.Location = New System.Drawing.Point(185, 250)
        Me.PrintButton.Name = "PrintButton"
        Me.PrintButton.Size = New System.Drawing.Size(75, 23)
        Me.PrintButton.TabIndex = 5
        Me.PrintButton.Text = "Print"
        Me.PrintButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(266, 250)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 6
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'PIIForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 295)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.PrintButton)
        Me.Controls.Add(Me.VerifyPhoneButton)
        Me.Controls.Add(Me.GenerateButton)
        Me.Controls.Add(Me.RecordsListBox)
        Me.Controls.Add(Me.RecordsToGenerateTextBox)
        Me.Controls.Add(Me.RecordsToGenerateLabel)
        Me.Name = "PIIForm"
        Me.Text = "Personally Identifiable Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RecordsToGenerateLabel As Label
    Friend WithEvents RecordsToGenerateTextBox As TextBox
    Friend WithEvents RecordsListBox As ListBox
    Friend WithEvents GenerateButton As Button
    Friend WithEvents VerifyPhoneButton As Button
    Friend WithEvents PrintButton As Button
    Friend WithEvents ExitButton As Button
End Class
