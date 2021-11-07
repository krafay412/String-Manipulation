Module Module1

    Sub Main()
        Dim Str1, Str2 As String
        Dim char1, thischar As Char

        Str1 = ""
        thischar = ""
        char1 = ""
        Str2 = ""

        Console.Write("Enter string: ")
        Str1 = Console.ReadLine

        Console.Write("enter charachter u want to remove: ")
        char1 = Console.ReadLine



        For count = 1 To Len(Str1)
            thischar = Mid(Str1, count, 1)
            If char1 <> thischar Then
                Str2 = Str2 & thischar


            End If


        Next
        Console.WriteLine("Processed string after truncation is: " & Str2)
        Console.ReadKey()
    End Sub

End Module
