Option Strict On
Public Class PhoneCheckForm

    'Closes the program
    Private Sub CloseButton_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Me.Close()
    End Sub

    'Informs the user if a phone number is invalid
    Private Sub VerifyButton_Click(sender As Object, e As EventArgs) Handles VerifyButton.Click
        Dim phoneNumber As String
        Dim result As String
        phoneNumber = PhoneNumberMaskedTextBox.Text
        result = VerifyNumber(phoneNumber)

        If result = "" Then
            'If the VerifyNumber function returns an empty string, it is a valid phone number
            ResultStatusStripLabel.Text = "Valid Phone Number"
            ResultStatusStrip.BackColor = Color.Green
        Else
            'Or else it returns the reason why it's invalid
            ResultStatusStripLabel.Text = result
            ResultStatusStrip.BackColor = Color.Red
        End If
    End Sub
End Class
