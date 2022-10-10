Module ejerc7bol3
    Sub Main()
        Dim n1, n2, suma, raiz As Double

        n1 = Convert.ToDouble(InputBox("introduzca un numero"))
        n2 = Convert.ToDouble(InputBox("introduzca un numero"))

        suma = n1 + n2

        If suma > 0 Then
            raiz = Math.Sqrt(suma)
            Console.WriteLine("la raiz es" & raiz)
        Else
            Console.WriteLine("no se puede calcular la raiz")
        End If
        Console.ReadLine()

    End Sub
End Module
