Module bol_2_ejer_11
    Sub Main()
        Dim espacio, tiempo, velocidad As Double

        Console.WriteLine("introduzca el valor del espacio: ")
        espacio = Convert.ToDouble(Console.ReadLine)
        Console.WriteLine("introduzca el valor del tiempo: ")
        tiempo = Convert.ToDouble(Console.ReadLine)

        velocidad = espacio / tiempo

        Console.Write("la velocidad es: " & velocidad)
        Console.WriteLine(" m/s")
        Console.ReadLine()

    End Sub
End Module
