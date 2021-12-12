Module Module1

    Sub Main()

        Dim s As String

        s = ""

        Console.Write("String: ")
        s = Console.ReadLine()

        If Len(s) < 2 Then
            Console.WriteLine("S output: " & s)
        Else
            Console.WriteLine("S output: " & Left(s, 2) & Right(s, 2))
        End If

        Console.ReadKey()

    End Sub

End Module

