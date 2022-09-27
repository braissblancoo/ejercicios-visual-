Module bol_2_ejer_12
    Sub Main()
        Dim lado, area, perimetro, diagonal As Double

        Console.WriteLine("introduzca el lado de un cuadrado: ")
        lado = Convert.ToDouble(Console.ReadLine)

        area = lado ^ 2
        Console.WriteLine("el area del cuadrado es: " & area)

        perimetro = 4 * lado
        Console.WriteLine("el perímetro del cuadrado es: " & perimetro)


        diagonal = lado * Math.Sqrt(2)
        Console.WriteLine("la diagonal del cuadrado es: " & diagonal)

        Console.ReadLine()

    End Sub
End Module
