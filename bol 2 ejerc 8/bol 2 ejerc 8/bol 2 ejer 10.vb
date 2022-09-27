Module bol_2_ejer_10
    Sub Main()
        Dim horasTrabajadas, tasa, IRPF, salarioBruto, salarioNeto, totalHoras As Double
        horasTrabajadas = Convert.ToDouble(InputBox("introduzca las horas trabajadas"))
        tasa = Convert.ToDouble(InputBox("introduzca la tasa"))
        IRPF = Convert.ToDouble(InputBox("introduzca el IRPF"))

        totalHoras = horasTrabajadas * tasa
        salarioBruto = 52 * totalHoras
        salarioNeto = salarioBruto / (IRPF / 100)

        Console.WriteLine("el salario bruto es: " & salarioBruto)
        Console.WriteLine("el salario neto es: " & salarioNeto)

        Console.ReadLine()


    End Sub
End Module
