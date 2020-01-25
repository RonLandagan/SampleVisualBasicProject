Option Strict On
Module PhoneVerificationModule

    'This functions retruns a string informing the user why a number is invalid.
    'If the number is valid, it returns an empty string.
    Public Function VerifyNumber(ByVal phoneNumber As String) As String
        Dim result As String
        result = ""

        'Removes the (, ), -, and the space in the string
        phoneNumber = phoneNumber.Replace("(", String.Empty)
        phoneNumber = phoneNumber.Replace(")", String.Empty)
        phoneNumber = phoneNumber.Replace("-", String.Empty)
        phoneNumber = phoneNumber.Replace(" ", String.Empty)

        'Checks the Numbering plan area code

        'Invalid if (0XX) XXX-XXXX form or (1XX) XXX-XXXX
        If phoneNumber(0) = "1" Or phoneNumber(0) = "0" Then
            result = "Invalid phone number. Area Codes cannot begin with a 1 or 0."
        End If
        'Invalid if (X9X) XXX-XXXX form
        If phoneNumber(1) = "9" Then
            result = "Invalid phone number. The NANP is not assigning area codes with 9 as the second digit."
        End If

        'Checks the Central office code

        'Invalid if (XXX) 0XX-XXXX form or (XXX) 1XX-XXXX
        If phoneNumber(3) = "1" Or phoneNumber(3) = "0" Then
            result = "Invalid phone number. Exchange Codes cannot begin with a 1 or 0."
        End If
        'Invalid if (XXX) X11-XXXX form
        If phoneNumber(4) = "1" And phoneNumber(5) = "1" Then
            result = "Invalid phone number. Exchange Codes cannot end with two 1s."
        End If
        'Invalid if (XXX) 555-XXXX form
        If phoneNumber(3) = "5" And phoneNumber(4) = "5" And phoneNumber(5) = "5" Then
            result = "Invalid phone number. This Exchange Code is reserved for fictitious numbers"
        End If

        'Checks for length of phone number
        If phoneNumber.Length() < 10 Then
            result = "Invalid entry. Please enter a complete phone number."
        End If

        Return result
    End Function
End Module
