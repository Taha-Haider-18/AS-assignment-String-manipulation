Module Module1

    Sub Main()

        Dim str As String
        Dim chr As Char
        Dim count As Integer
        Dim i As Integer

        str = ""
        chr = ""
        count = 0
        i = 0

        Console.Write("String: ")
        str = Console.ReadLine()
        Console.Write("Character to be counted: ")
        chr = Console.ReadLine()

        For i = 1 To Len(str)

            If chr = Mid(str, i, 1) Then

                count = count + 1
            End If
        Next

        Console.WriteLine("Total characters in string: " & Len(str))
        Console.WriteLine("Number of '" & chr & "' in the string: " & count)
        Console.ReadKey()




    End Sub

End Module
