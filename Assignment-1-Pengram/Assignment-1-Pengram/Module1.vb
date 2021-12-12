Module Module1
    Sub Main()

        Dim str As String
        Dim alph As String
        Dim i As Integer
        Dim x As Integer
        Dim ascii As Integer

        str = ""
        alph = ""
        i = 1
        ascii = 96
        x = 0

        Console.Write("String: ")
        str = Console.ReadLine()
        str = LCase(str)

        For i = 1 To 26
            alph = Chr(ascii + i)
            x = InStr(str, alph)
            If x = 0 Then

                Exit For

            End If
        Next
        If x = 0 Then
            Console.WriteLine("String is not a pengram")
        Else
            Console.WriteLine("String is a pengram.")
        End If

        Console.ReadKey()




    End Sub

End Module
