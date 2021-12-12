Module Module1

    Sub Main()

        Dim str As String
        Dim chr1 As Char
        Dim chr2 As Char
        Dim count As Integer
        Dim i As Integer
        Dim chr1count As Integer
        Dim chr2count As Integer

        str = ""
        chr1 = ""
        chr2 = ""
        count = 0
        i = 0


        Console.Write("String: ")
        str = LCase(Console.ReadLine())
        chr1 = Left(str, 1)

        For count = 1 To Len(str)
            chr2 = Mid(str, count, 1)
            chr1count = 0
            chr2count = 0
            For i = 1 To Len(str)
                If chr1 = Mid(str, i, 1) Then
                    chr1count = chr1count + 1
                End If

                If chr2 = Mid(str, i, 1) Then
                    chr2count = chr2count + 1
                End If
            Next
            If chr2count > chr1count Then
                chr1 = chr2
            End If

        Next


        Console.WriteLine("Character that appeared the most: " & chr1 & ", count: " & chr1count)
        Console.ReadKey()





    End Sub

End Module
