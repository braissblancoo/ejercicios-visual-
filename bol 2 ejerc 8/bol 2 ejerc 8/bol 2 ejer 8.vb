Module Module1

    Sub Main()
        Dim P, V, n, R, T As Double

        Console.WriteLine("Escribe el valor del volumen: ")
        V = Convert.ToDouble(Console.ReadLine)
        Console.WriteLine("Escribe el valor de los moles: ")
        n = Convert.ToDouble(Console.ReadLine)
        Console.WriteLine("Escribe el valor de la temperatura: ")
        T = Convert.ToDouble(Console.ReadLine)
        R = 0.082



        P = (n * R * T) / V

        Console.WriteLine("el valor de P es: " & P)
        Console.ReadLine()



    End Sub

End Module
