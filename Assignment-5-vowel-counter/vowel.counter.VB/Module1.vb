Module Module1

    Sub Main()

        Dim vowel As String
        Dim str As String
        Dim chr As Char
        Dim count As Integer
        Dim i As Integer
        Dim x As Integer

        str = ""
        chr = ""
        i = 0
        x = 0

        vowel = "aeiou"
        Console.Write("String: ")
        str = Console.ReadLine()

        For x = 1 To 5
            count = 0
            chr = Mid(vowel, x, 1)
            For i = 1 To Len(str)
                If chr = Mid(str, i, 1) Then
                    count = count + 1
                End If
            Next

            Console.WriteLine(chr & ": " & count)
        Next

        Console.ReadKey()

    End Sub

End Module
