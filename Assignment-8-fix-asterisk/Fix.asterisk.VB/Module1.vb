Module Module1

    Sub Main()

        Dim str As String
        Dim result As String
        Dim chr As Char
        Dim i As Integer

        str = ""
        result = ""
        chr = ""
        i = 0

        Console.Write("String: ")
        str = Console.ReadLine()
        chr = Left(str, 1)

        For i = 1 To Len(str)
            If i > 1 Then
                If chr = Mid(str, i, 1) Then
                    result = result & "*"
                Else
                    result = result & Mid(str, i, 1)
                End If
            Else
                result = chr
            End If
        Next

        Console.WriteLine("Result: " & result)
        Console.ReadKey()



    End Sub


End Module
