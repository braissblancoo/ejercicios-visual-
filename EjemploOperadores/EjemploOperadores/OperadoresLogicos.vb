Module OperadoresLogicos
    Sub Main()
        'operadores lógicos ---> AND, OR, Not
        'AND ---> Y Lógico ---> Devuelve True si las dos condicioes son True 

        Dim x As Boolean = True
        Dim y As Boolean = False

        Dim condicionAND As Boolean = x And y
        Dim condicionAND2 As Boolean = True And False
        Dim condicionAND3 As Boolean = False And True
        Dim condicionAND4 As Boolean = False And False

        'Or ---> Devuelve true si una de las condiciones es true 
        'Los niños deben llevas SPI si son menores de 8 años o miden menos de 1,35m
        Dim altura As Single = 1.2
        Dim edad As Byte = 8
        Dim silla As Boolean = altura < 1.35 Or edad < 8

        Console.WriteLine("silla: " & silla)





    End Sub
End Module
