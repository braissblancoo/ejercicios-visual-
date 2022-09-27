Module bol_2_ejer_13
    Sub Main()
        Dim catetoA, catetoB, hipotenusa As Double
        Console.WriteLine("introduce el valor del cateto A: ")
        catetoA = Convert.ToDouble(Console.ReadLine())

        Console.WriteLine("introduce el valor del cateto B: ")
        catetoB = Convert.ToDouble(Console.ReadLine())


        hipotenusa = Math.Round(((catetoA ^ 2 + catetoB ^ 2) * Math.Sqrt(2)), 2)
        Console.WriteLine("el valor de la hipotenusa es: " & hipotenusa)

        Console.ReadLine()



    End Sub
End Module
