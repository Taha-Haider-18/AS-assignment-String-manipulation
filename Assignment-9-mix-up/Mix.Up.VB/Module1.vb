Module Module1

    Sub Main()

        Dim a As String
        Dim b As String

        a = ""
        b = ""

        Console.Write("String a: ")
        a = Console.ReadLine()
        Console.Write("String b: ")
        b = Console.ReadLine()

        If Len(a) < 2 Or Len(b) < 2 Then
            Console.WriteLine("Please input two or more characters in both strings")
        Else
            Console.WriteLine("Result:")
            Console.WriteLine(Left(b, 2) + Mid(a, 3, Len(a) - 2) + " " + Left(a, 2) + Mid(b, 3, Len(b) - 2))
        End If

        Console.ReadKey()

    End Sub

End Module
