Module operadoresAsignacion
    Sub Main()
        'operadores de asignación: = , += , -= , *= , /=
        Dim x As Integer = 1
        'sumar 1 a x ---> x = x + 1
        x += 1

        'restar 1 a x ---> x = x - 1
        x -= 1
        Console.WriteLine("x = " & x)

        Console.ReadLine()

    End Sub
End Module
