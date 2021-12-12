Module Module1

    Sub Main()

        Dim donut As Integer

        donut = 0

        Console.Write("Donuts? ")
        donut = Console.ReadLine()

        If donut > 9 Then
            Console.WriteLine("Number of donuts: many")
        Else
            Console.WriteLine("Number of donuts:" & Str(donut))
        End If

        Console.ReadKey()

    End Sub

    'Console.WriteLine("Number of donuts:" & IIf(donut <= 9, donut, "many"))


End Module
