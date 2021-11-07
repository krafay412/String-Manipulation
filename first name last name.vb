Module Module1

    Sub Main()
        Dim Name1, Name2, FN, LN As String

        Dim SpsPos As Integer

        Name1 = ""
        Name2 = ""
        FN = ""
        LN = ""
        SpsPos = 0


        Console.WriteLine("Please enter your fisrst name: ")
        Name1 = Console.ReadLine()


        Console.WriteLine("Please enter your second name: ")
        Name2 = Console.ReadLine()

        SpsPos = InStr(Name1, " ")
        FN = Left(Name1, SpsPos - 1)
        SpsPos = InStr(Name2, " ")

        LN = Right(Name2, Len(Name2) - SpsPos)
        Console.WriteLine(FN & " " & LN)
        Console.ReadKey()






    End Sub

End Module
