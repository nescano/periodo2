Module Module1

    Sub Main()
        NumerosImpares()
        SumaNumeros()
        Adivinanza()
        Factorial()
        InvertirCadena()
        ListaAlumnos()
        ContadorPalabras()
        AritmeticaConConjuntos()
    End Sub

    Sub NumerosImpares()
        Dim e As Integer = 1
        While e <= 40
            If (e Mod 2 <> 0) Then
                Console.WriteLine(e)
            End If
            e += 1
        End While

        Console.ReadLine()
    End Sub

    Sub SumaNumeros()

        Dim u As Integer
        Console.WriteLine("Ingrese un numero para la suma: ")
        u = Console.ReadLine()
        Dim suma As Integer = 0

        Dim contar As Integer = 1
        While contar <= u
            suma += contar
            contar += 1
        End While

        Console.WriteLine("La suma es: " & suma)
        Console.ReadLine()

    End Sub

    Sub Adivinanza()
        Dim maxOpor As Integer = 5
        Dim oporActual As Integer = 1
        Dim numGenerado As Int16 = New Random().Next(11)

        Do
            Console.WriteLine("Ingrese un numero: ")
            If (numGenerado = Console.ReadLine()) Then
                Console.WriteLine("Adivino el numero.")
                Console.ReadLine()
                Return
            Else
                Console.WriteLine("No ha adivinado. Tiene " & (maxOpor - oporActual) & " oportunidades restantes.")
            End If
            oporActual += 1
        Loop While oporActual <= maxOpor

        Console.ReadLine()
    End Sub

    Sub Factorial()
        Dim a As Integer
        Console.WriteLine("Ingrese un numero: ")
        a = Console.ReadLine()

        Dim fact As Integer = 1
        For o = 1 To a
            fact = fact * o
        Next

        Console.WriteLine("El factorial de " & a & " es " & fact)
        Console.ReadLine()
    End Sub

    Sub InvertirCadena()
        Dim cadena As String
        Console.WriteLine("Ingrese una cadena: ")
        cadena = Console.ReadLine()
        For i = cadena.Length - 1 To 0 Step -1
            Console.Write(cadena(i))
        Next
        Console.ReadLine()
    End Sub

    Sub ListaAlumnos()
        Console.WriteLine("ESTUDIANTES DE PROGRAMACION ORIENTADA A OBJETOS")
        Dim Alum() As String = {"Mauricio", "Kevin", "Fernando", "Elmer", "Franklin"}
        For Each nombre As String In Alum
            Console.WriteLine(nombre)
        Next
        Console.ReadLine()
    End Sub

    Sub ContadorPalabras()
        Dim cade As String
        Console.WriteLine("Ingrese la frase que desee: ")
        cade = Console.ReadLine()

        Dim palab() As String = cade.Split(" ")

        Console.WriteLine("La frase '" & cade & "' tiene " & palab.Count & " palabras.")
        For Each palabra As String In palab
            Console.WriteLine("La palabra '" & palabra & "' tiene " & palabra.Length & " letras.")
        Next

        Console.ReadLine()
    End Sub

    Sub AritmeticaConConjuntos()
        Dim grupo1() As Integer = {3, 6, 9, 12, 15}
        Dim grupo2() As Integer = {2, 4, 6, 8, 10}

        'Sumas
        Console.WriteLine("Sumas: ")
        For a = 0 To grupo1.Length - 1
            Console.WriteLine(grupo1(a) & " + " & grupo2(a) & " = " & (grupo1(a) + grupo2(a)))
        Next

        Console.WriteLine()

        Console.WriteLine("Restas: ")
        For a = 0 To grupo1.Length - 1
            Console.WriteLine(grupo1(a) & " - " & grupo2(a) & " = " & (grupo1(a) - grupo2(a)))
        Next

        Console.WriteLine()

        Console.WriteLine("Multiplicacion: ")
        For a = 0 To grupo1.Length - 1
            Console.WriteLine(grupo1(a) & " * " & grupo2(a) & " = " & (grupo1(a) * grupo2(a)))
        Next

        Console.WriteLine()

        Console.WriteLine("Division: ")
        For a = 0 To grupo1.Length - 1
            Console.WriteLine(grupo1(a) & " / " & grupo2(a) & " = " & (grupo1(a) / grupo2(a)))
        Next

        Console.ReadLine()
    End Sub


End Module
