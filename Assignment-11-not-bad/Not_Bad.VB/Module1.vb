Module Module1

    Sub Main()

        Dim str As String
        Dim x As Integer
        Dim y As Integer

        str = " "
        x = 0
        y = 0


        Console.Write("String: ")
        str = Console.ReadLine()

        x = InStr(str, "not")
        y = InStr(str, "bad") + 2

        If x > 0 And y > 2 And x < y Then

            str = Left(str, x - 1) & "good" & Mid(str, y + 1, Len(str) - y)

        End If

        Console.WriteLine("Result: " & str)
        Console.ReadKey()

    End Sub

End Module
