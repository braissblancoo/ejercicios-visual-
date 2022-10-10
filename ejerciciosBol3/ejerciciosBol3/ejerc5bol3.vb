Module ejerc5bol3
    Sub Main()
        Dim n1 As Integer
        n1 = Convert.ToInt32(InputBox("ingrese un numero"))


        If n1 Mod 2 = 0 Then
            Console.WriteLine("el numero es par")
        Else
            Console.WriteLine("el numero es impar")
        End If
        Console.ReadLine()

    End Sub
End Module
