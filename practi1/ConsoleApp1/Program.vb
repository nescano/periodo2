Imports System

Module Program
    Sub Main(args As String())
        Menu()
    End Sub

    Sub Multiplo()
        Console.Clear()
        Dim numero1 As Integer
        Dim numero2 As Integer
        Console.WriteLine("Escriba el primer numero")
        numero1 = Console.ReadLine()
        Console.WriteLine("Escriba el segundo numero")
        numero2 = Console.ReadLine()
        If numero1 Mod 5 = 0 Then
            Console.WriteLine("El primer numero introducido es multiplo de 5", numero1)
        Else
            Console.WriteLine("El primer numero introducido no es multiplo de 5", numero1)
        End If
        If numero2 Mod 3 = 0 Then

            Console.WriteLine("El segundo numero introducido es multiplo de 3", numero2)
            Console.ReadLine()
        Else

            Console.WriteLine("El segundo numero introducido no es multiplo de 3", numero2)
            Console.ReadLine()
        End If
        Console.ReadLine()
        Console.Clear()

        Menu()
    End Sub

    Sub ResultadoAcademico()
        Console.Clear()
        Dim nombre As String
        Dim apellido As String
        Dim calificacion As Double
        Dim asistencia As Integer

        Dim resultadoFinal As String


        resultadoFinal = ""
        Console.Write("Ingrese el nombre del alumno:")
        nombre = Console.ReadLine()
        Console.Write("Ingrese el apellido del alumno:")
        apellido = Console.ReadLine()
        Console.Write("Ingrese la calificación del alumno:")
        calificacion = Console.ReadLine()
        Console.Write("Ingrese la asistencia del alumno:")
        asistencia = Console.ReadLine()

        If calificacion > 0 And calificacion < 5 Then
            resultadoFinal = "REPROBADO"
        ElseIf calificacion >= 5 And calificacion < 6 Then
            resultadoFinal = "COMPLEMENTARIO"
        ElseIf calificacion >= 6 And calificacion <= 10 Then
            If asistencia >= 80 And asistencia <= 100 Then
                resultadoFinal = "APROBADO"
            Else
                resultadoFinal = "REPROBADO"
            End If

        End If

        Console.WriteLine("Con una calificación de " & calificacion & " y asistencia de" & asistencia & "%," & nombre & " " & apellido & " tiene un resultado de: " & resultadoFinal)
        Console.ReadLine()
        Console.Clear()
        Menu()
    End Sub

    Sub Temperatura()
        Console.Clear()

        Dim temperatura As Integer
        Dim valida As Integer
        valida = 1

        While valida = 1
            Console.Write("Ingrese la temperatura:")
            temperatura = Console.ReadLine()
            If temperatura < -100 Or temperatura > 100 Then
                valida = 1
                Console.Write("Valor de temperatura no válido")
                Console.ReadLine()
                Console.Clear()
            Else
                valida = 0
            End If
        End While


        Select Case temperatura
                Case -100 To 0
                    Console.WriteLine("Temperatura por debajo de Cero grados, no salir de su casa, mantenerse abrigado y con calefacción.")
                Case 0 To 20
                    Console.WriteLine("Clima extremadamente Frio, debe abrigarse bien, evite realizar actividades fuera de casa")
                Case 20 To 35
                    Console.WriteLine("Clima agradable, para realizar actividades.")
                Case 35 To 100
                    Console.WriteLine("Temperaturas extremas! debe hidratarse bien y evitar la exposición al sol.")
            End Select


            Console.ReadLine()
        Console.Clear()
        Menu()
    End Sub

    Sub TickTock()
        Console.Clear()

        Dim numero1 As Integer
        Dim numero2 As Integer
        Dim valida As Integer
        Dim imprime1 As String
        Dim imprime2 As String


        valida = 1
        imprime1 = ""
        imprime2 = ""
        While valida = 1
            Console.WriteLine("Digite dos números entre 3 y 9 donde el segundo NO sea múltiplo del primer:")
            Console.WriteLine("Número 1:")
            numero1 = Console.ReadLine()
            Console.WriteLine("Número 2")
            numero2 = Console.ReadLine()
            If numero1 < 3 Or numero1 > 9 Then
                valida = 1
                Console.Write("Valor ingresado en el número1 está fuera de rango")
                Console.ReadLine()
                Console.Clear()
            ElseIf numero2 < 3 Or numero2 > 9 Then
                valida = 1
                Console.Write("Valor ingresado en el número2 está fuera de rango")
                Console.ReadLine()
                Console.Clear()
            ElseIf numero2 Mod numero1 = 0 Then
                valida = 1
                Console.Write("Valor ingresado en el número2 es múltiplo del número1")
                Console.ReadLine()
                Console.Clear()
            Else
                valida = 0
            End If
        End While

        For index = 1 To 100
            If index Mod numero1 = 0 Then
                imprime1 = "Tick"
            Else
                imprime1 = ""
            End If
            If index Mod numero2 = 0 Then
                imprime2 = "Tock"
            Else
                imprime2 = ""
            End If
            Console.Write("#" & index & " - " & imprime1 & imprime2 & System.Environment.NewLine)

        Next
        Console.ReadLine()
        Console.Clear()
        Menu()
    End Sub

    Sub PersonajesFavoritos()
        Console.Clear()
        Dim opcion As Integer
        Dim opcion2 As Integer
        Dim valida1 As Integer
        Dim valida2 As Integer
        Dim grupo As String
        Dim favorito As String

        valida1 = 1
        valida2 = 1
        grupo = ""
        favorito = ""

        While valida1 = 1
            Console.WriteLine("Seleccione una opción:
                                    1. Futbol
                                    2. Cine
                                    3. Musica
                              ")
            Console.WriteLine("Ingrese la opción:")
            opcion = Console.ReadLine()
            If opcion = 1 Or opcion = 2 Or opcion = 3 Then
                valida1 = 0
            Else
                valida1 = 1
                Console.WriteLine("Debe ingresar una opción válida")
                Console.ReadLine()
                Console.Clear()
            End If

        End While

        If opcion = 1 Then grupo = "Futbol"
        If opcion = 2 Then grupo = "Cine"
        If opcion = 3 Then grupo = "Musica"

        While valida2 = 1
            Select Case opcion
                Case 1
                    Console.WriteLine("Seleccione un Futbolista:
                                        1. Cristiano Ronaldo
                                        2. Lionel Messi
                                        3. Neymar Jr.
                                  ")
                    Console.WriteLine("Ingrese la opción:")
                    opcion2 = Console.ReadLine()
                    grupo = "Futbol"
                Case 2
                    Console.WriteLine("Seleccione un Artista de Cine:
                                        1. Chris Hemsworth
                                        2. Robert Downey
                                        3. Chris Evans
                                  ")
                    Console.WriteLine("Ingrese la opción:")
                    opcion2 = Console.ReadLine()
                    grupo = "Cine"
                Case 3
                    Console.WriteLine("Seleccione un Cantante:
                                        1. Daddy Yankee
                                        2. José Jose
                                        3. Marc Anthony
                                  ")
                    Console.WriteLine("Ingrese la opción:")
                    opcion2 = Console.ReadLine()
                    grupo = "Musica"
            End Select

            If opcion2 = 1 Or opcion2 = 2 Or opcion2 = 3 Then
                valida2 = 0
            Else
                valida1 = 1
                Console.WriteLine("Debe ingresar una opción válida")
                Console.ReadLine()
                Console.Clear()
            End If
        End While

        Select Case opcion
            Case 1
                If opcion2 = 1 Then favorito = "Cristiano Ronaldo"
                If opcion2 = 2 Then favorito = "Lionel Messi"
                If opcion2 = 3 Then favorito = "Neymar Jr."
            Case 2
                If opcion2 = 1 Then favorito = "Chris Hemsworth"
                If opcion2 = 2 Then favorito = "Robert Downey"
                If opcion2 = 3 Then favorito = "Chris Evans"
            Case 3
                If opcion2 = 1 Then favorito = "Daddy Yankee"
                If opcion2 = 2 Then favorito = "José Jose"
                If opcion2 = 3 Then favorito = "Marc Anthony"
        End Select


        Console.WriteLine("Su personaje favorito es: " & favorito & " del género " & grupo)
        Console.ReadLine()
        Console.Clear()
        Menu()

    End Sub
    Sub Menu()
        Dim opcion As Integer
        Console.WriteLine("Seleccione una opción:
                                1. Multiplo
                                2. Resultado Académico
                                3. Temperatura
                                4. TickTock
                                5. Personajes Favoritos
                                6. Salir
                          ")
        Console.WriteLine("Ingrese la opción:")
        opcion = Console.ReadLine()
        If opcion = 1 Then Multiplo()
        If opcion = 2 Then ResultadoAcademico()
        If opcion = 3 Then Temperatura()
        If opcion = 4 Then TickTock()
        If opcion = 5 Then PersonajesFavoritos()
        If opcion = 6 Then Environment.Exit(0)
    End Sub
End Module