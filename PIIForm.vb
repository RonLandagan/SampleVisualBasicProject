Option Strict On
Imports System.IO

Public Class PIIForm

    'Closes the program
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    'Opens the Phone Number Verification form
    Private Sub VerifyPhoneButton_Click(sender As Object, e As EventArgs) Handles VerifyPhoneButton.Click
        Dim PhoneVerifyForm As New PhoneCheckForm
        PhoneVerifyForm.ShowDialog()
    End Sub

    'Generates a user-chosen number of Personal Identity Records in a ListBox
    Private Sub GenerateButton_Click(sender As Object, e As EventArgs) Handles GenerateButton.Click

        'Creates a random seed
        Dim rand As New Random

        Dim numberOfRecords As Integer = 0
        RecordsListBox.Items.Clear()

        'Uses try-catch statements to validate user input
        Try
            numberOfRecords = CInt(RecordsToGenerateTextBox.Text)
        Catch ex As Exception
            MessageBox.Show("Invalid number of records. Please input a number.")
        End Try

        For intCount = 0 To numberOfRecords - 1
            'Creates an entry by using functions from GenerateRecords Module
            Dim record = GenerateName(rand) + " " + GenerateNumber(rand)
            RecordsListBox.Items.Add(record)
        Next
    End Sub

    'Prints contents of the ListBox into a .txt file
    Private Sub PrintButton_Click(sender As Object, e As EventArgs) Handles PrintButton.Click

        'Opens a StreamWriter file
        Dim recordsFile As StreamWriter

        'Opens a .txt file called PII.txt
        recordsFile = File.AppendText("c:\temp\PII.txt")

        'Loops through each item in RecordsListBox and writes it into the .txt file on its own line
        For Each record In RecordsListBox.Items
            recordsFile.WriteLine(record)
        Next

        'Closes the StreamWriter File
        recordsFile.Close()
    End Sub
End Class
