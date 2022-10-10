Module ejer6bol3
    Sub Main()
        Dim a, b, c, media As Double
        a = Convert.ToDouble(InputBox("introduzca la primera nota"))
        b = Convert.ToDouble(InputBox("introduzca a segunda nota"))
        c = Convert.ToDouble(InputBox("introduzca la segunda nota"))

        media = (a + b + c) / 3

        If media > 5 Then
            Console.WriteLine("aprobado")
        Else
            Console.WriteLine("suspenso")
        End If
        Console.ReadLine()

    End Sub
End Module
