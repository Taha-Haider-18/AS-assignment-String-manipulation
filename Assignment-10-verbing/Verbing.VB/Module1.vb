Module Module1

    Sub Main()


        Dim str As String

        str = ""

        Console.Write("String: ")
        str = Console.ReadLine()

        If Len(str) > 2 Then
            If "ing" = Right(str, 3) Then
                Console.WriteLine("Result: " & str & "ly")
            Else
                Console.WriteLine("Result: " & str & "ing")
            End If
        Else
            Console.WriteLine("Result: " & str)
        End If

        Console.ReadKey()

    End Sub

End Module
