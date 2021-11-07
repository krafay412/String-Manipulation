Module Module1

    Sub Main()
        Dim Str1 As String
        Dim char1 As Char
        Dim count, alphacounter, digitcounter, specialcasecounter As Integer

        Str1 = ""
        char1 = ""
        count = 0
        alphacounter = 0
        digitcounter = 0
        specialcasecounter = 0

        Console.Write("Please Enter text: ")
        Str1 = Console.ReadLine

        For count = 1 To Len(Str1)
            char1 = Mid(Str1, count, 1)
            char1 = UCase(char1)

            If char1 >= "A" And char1 <= "Z" Then
                alphacounter = alphacounter + 1
            ElseIf char1 >= "1" And char1 <= "9" Then
                digitcounter = digitcounter + 1
            Else : specialcasecounter = specialcasecounter + 1

            End If

        Next

        Console.WriteLine("Alphabets are: " & alphacounter)
        Console.WriteLine("Digits are: " & digitcounter)
        Console.WriteLine("Special Case are: " & specialcasecounter)

        Console.ReadKey()

    End Sub

End Module
