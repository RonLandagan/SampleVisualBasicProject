Option Strict On
Module GenerateRecords
    Function GenerateName(ByVal rand As Random) As String
        Dim fullName As String = ""

        'Holds various common American last names
        Dim lastNameArray() As String = {"Smith", "Johnson", "Williams", "Garcia", "Jones", "Brown",
                                           "Miller", "Davis", "Wilson", "Moore", "Taylor", "Anderson",
                                           "Thomas", "Jackson", "White", "Harris", "Martin", "Thompson",
                                           "Martinez", "Robinson", "Hall", "Allen", "Young", "Hernandez"}

        'Holds various common American first names
        Dim firstNameArray() As String = {"Mary", "Patricia", "Linda", "Barbara", "Elizabeth", "Jessica",
                                            "James", "John", "William", "Robert", "Michael", "Sam", "David",
                                            "Richard", "Susan", "Joseph", "Thomas", "Sarah", "Charles",
                                            "Maragaret", "Christopher", "Karen", "Daniel", "Nancy", "Matthew"}

        'Creates randomly generated full name
        fullName += firstNameArray(rand.Next(firstNameArray.Length)) + " " +
                    lastNameArray(rand.Next(lastNameArray.Length))

        Return fullName
    End Function

    Function GenerateNumber(ByVal rand As Random) As String
        Dim generatedPhoneNumber As String
        Dim areaCode As Integer
        Dim exchangeCode As Integer
        Dim lineNumber As Integer

        'Loops until it generates a phone Number that doesn't violate NAMP rules
        Do
            generatedPhoneNumber = String.Empty

            'Generates first three digits
            areaCode = rand.Next(1000)

            'Generates second three digits
            exchangeCode = rand.Next(1000)

            'Generates last four digits
            lineNumber = rand.Next(10000)

            'Appends the pieces into a full phone number
            generatedPhoneNumber += areaCode.ToString + "-" + exchangeCode.ToString +
                                    "-" + lineNumber.ToString
        Loop Until VerifyNumber(generatedPhoneNumber).Equals("")

        Return generatedPhoneNumber
    End Function
End Module
