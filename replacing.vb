Module Module1

    Sub Main()
        Dim Str1, Str2 As String
        Dim thischar, char1, char2 As Char
        Dim count As Integer

        Str1 = ""
        Str2 = ""
        thischar = ""
        char1 = ""
        char2 = ""

        Console.Write("Please Enter the text:")
        Str1 = Console.ReadLine
        Console.Write("please add characher you want to Remove:")
        char1 = Console.ReadLine
        Console.Write("please add the charachter you want to replace with:")
        char2 = Console.ReadLine

        For count = 1 To Len(Str1)
            thischar = Mid(Str1, count, 1)
            If thischar = char1 Then
                Str2 = Str2 & char2
            Else : Str2 = Str2 & thischar
            End If
        Next
        Console.Write("the new string is:")
        Console.WriteLine(Str2)
        Console.ReadKey()

    End Sub

End Module
