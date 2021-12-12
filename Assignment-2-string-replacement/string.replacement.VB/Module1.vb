Module Module1

    Sub Main()

        Dim str As String
        Dim result As String
        Dim chr As String
        Dim repl As String
        Dim i As Integer

        str = ""
        result = ""
        chr = ""
        repl = ""
        i = 0

        Console.Write("Enter your string: ")
        str = Console.ReadLine()
        Console.Write("Character to be replaced: ")
        chr = Console.ReadLine()
        Console.Write("Replacement: ")
        repl = Console.ReadLine()

        For i = 1 To Len(str)
            If chr = Mid(str, i, 1) Then
                result = result & repl
            Else
                result = result & Mid(str, i, 1)
            End If
        Next

        Console.WriteLine("Result: " & result)
        Console.ReadKey()

    End Sub



End Module
