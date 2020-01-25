<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PhoneCheckForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.PhoneNumberMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.PhoneNumberLabel = New System.Windows.Forms.Label()
        Me.VerifyButton = New System.Windows.Forms.Button()
        Me.CloseButton = New System.Windows.Forms.Button()
        Me.ResultStatusStrip = New System.Windows.Forms.StatusStrip()
        Me.ResultStatusStripLabel = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ResultStatusStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'PhoneNumberMaskedTextBox
        '
        Me.PhoneNumberMaskedTextBox.Location = New System.Drawing.Point(210, 64)
        Me.PhoneNumberMaskedTextBox.Mask = "(999) 000-0000"
        Me.PhoneNumberMaskedTextBox.Name = "PhoneNumberMaskedTextBox"
        Me.PhoneNumberMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.PhoneNumberMaskedTextBox.TabIndex = 1
        '
        'PhoneNumberLabel
        '
        Me.PhoneNumberLabel.AutoSize = True
        Me.PhoneNumberLabel.Location = New System.Drawing.Point(198, 29)
        Me.PhoneNumberLabel.Name = "PhoneNumberLabel"
        Me.PhoneNumberLabel.Size = New System.Drawing.Size(123, 13)
        Me.PhoneNumberLabel.TabIndex = 2
        Me.PhoneNumberLabel.Text = "Phone Number To Verify"
        '
        'VerifyButton
        '
        Me.VerifyButton.Location = New System.Drawing.Point(167, 106)
        Me.VerifyButton.Name = "VerifyButton"
        Me.VerifyButton.Size = New System.Drawing.Size(75, 23)
        Me.VerifyButton.TabIndex = 3
        Me.VerifyButton.Text = "Verify"
        Me.VerifyButton.UseVisualStyleBackColor = True
        '
        'CloseButton
        '
        Me.CloseButton.Location = New System.Drawing.Point(275, 106)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(75, 23)
        Me.CloseButton.TabIndex = 4
        Me.CloseButton.Text = "Close"
        Me.CloseButton.UseVisualStyleBackColor = True
        '
        'ResultStatusStrip
        '
        Me.ResultStatusStrip.BackColor = System.Drawing.SystemColors.Control
        Me.ResultStatusStrip.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.ResultStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ResultStatusStripLabel})
        Me.ResultStatusStrip.Location = New System.Drawing.Point(0, 164)
        Me.ResultStatusStrip.Name = "ResultStatusStrip"
        Me.ResultStatusStrip.Size = New System.Drawing.Size(508, 22)
        Me.ResultStatusStrip.TabIndex = 5
        Me.ResultStatusStrip.Text = "StatusStrip1"
        '
        'ResultStatusStripLabel
        '
        Me.ResultStatusStripLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.ResultStatusStripLabel.Name = "ResultStatusStripLabel"
        Me.ResultStatusStripLabel.Size = New System.Drawing.Size(121, 17)
        Me.ResultStatusStripLabel.Text = "ToolStripStatusLabel1"
        '
        'PhoneCheckForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(508, 186)
        Me.Controls.Add(Me.ResultStatusStrip)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.VerifyButton)
        Me.Controls.Add(Me.PhoneNumberLabel)
        Me.Controls.Add(Me.PhoneNumberMaskedTextBox)
        Me.Name = "PhoneCheckForm"
        Me.Text = "Form1"
        Me.ResultStatusStrip.ResumeLayout(False)
        Me.ResultStatusStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PhoneNumberMaskedTextBox As MaskedTextBox
    Friend WithEvents PhoneNumberLabel As Label
    Friend WithEvents VerifyButton As Button
    Friend WithEvents CloseButton As Button
    Friend WithEvents ResultStatusStrip As StatusStrip
    Friend WithEvents ResultStatusStripLabel As ToolStripStatusLabel
End Class
