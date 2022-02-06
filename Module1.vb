Module Module1

    Sub Main()
        Dim menu As Integer
        Console.WriteLine("Seleccione el punto del ejercicio que quiere ejecutar")
        Console.WriteLine("Punto 1")
        Console.WriteLine("Punto 2")
        Console.WriteLine("Punto 3")
        Console.WriteLine("Punto 4")
        Console.WriteLine("Punto 5")
        Console.WriteLine("Punto 6")
        Console.WriteLine("Punto 7")
        Console.WriteLine("Punto 8")

        menu = Console.ReadLine()
        Select Case menu
            Case 1
                PrimerPunto()
            Case 2
                SegundoPunto()
            Case 3
                TercerPunto()
            Case 4
                CuartoPunto()
            Case 5
                QuintoPunto()
            Case 6
                SextoPunto()
            Case 7
                SeptimoPunto()
            Case 8
                OctavoPunto()

            Case Else
                Console.WriteLine("Digite una opción valida")

        End Select

    End Sub

    Sub PrimerPunto()
        Dim size As Integer
        Dim a As Integer
        Do
            Console.WriteLine("Inserte el tamaño de su arreglo")
            size = Console.ReadLine()
        Loop While (size <= 2)
        Dim Array(size) As Double
        size = 2
        For i = 0 To Array.GetUpperBound(0) - 1
            Array(i) += a
            a += 2
        Next
        For i = 0 To Array.GetUpperBound(0) - 1
            Console.WriteLine(Array(i))
        Next
    End Sub
    Sub SegundoPunto()

        Dim size As Integer

        Do
            Console.WriteLine("Inserte el tamaño de su arreglo")
            size = Console.ReadLine()
        Loop While (size <= 2)
        Console.WriteLine("Inserte el número de la tabla de multiplicar que desee")

        Dim num As Integer
        num = Console.ReadLine()
        Dim arreglo(size) As Double
        For i = 0 To arreglo.GetUpperBound(0) - 1
            arreglo(i) = size * (i + 1)
        Next
        For i = 0 To arreglo.GetUpperBound(0) - 1
            Console.WriteLine(arreglo(i))
        Next
    End Sub

    Sub TercerPunto()
        Dim tam As Integer
        Dim aux As Integer
        Console.WriteLine("Inserte la dimensión de la matriz que desea")
        tam = Console.ReadLine()
        aux = 1
        Dim matriz(tam, tam) As Integer
        For i = 0 To matriz.GetUpperBound(0) - 1
            For k = 0 To matriz.GetUpperBound(1) - 1
                matriz(i, k) = aux
                aux += 2
            Next
        Next
        For i = 0 To matriz.GetUpperBound(0) - 1
            For k = 0 To matriz.GetUpperBound(1) - 1
                Console.Write(matriz(i, k) & " ")
            Next
        Next

    End Sub
    Sub CuartoPunto()
        Dim tam As Integer
        Dim multi As Integer

        Console.WriteLine("Inserte el tamaño de la matriz")
        tam = Console.ReadLine()
        Console.WriteLine("Inserte el número de la tabla de multiplicar que desee")
        multi = Console.ReadLine()
        Dim matriz(tam, tam) As String
        For i = 0 To matriz.GetUpperBound(0) - 1
            For k = 0 To matriz.GetUpperBound(1) - 1
                matriz(i, k) = multi * i & "," & multi * k
            Next
        Next
        For i = 0 To matriz.GetUpperBound(0) - 1
            For k = 0 To matriz.GetUpperBound(1) - 1
                Console.Write(matriz(i, k) & " ")
            Next
        Next

    End Sub

    Sub QuintoPunto()
        Dim matriz(10, 10) As String
        For i = 0 To matriz.GetUpperBound(0) - 1
            For k = 0 To matriz.GetUpperBound(1) - 1
                If (i = k) Then
                    matriz(i, k) = "?"
                End If
            Next
        Next
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                Console.Write(matriz(i, j) & " ")
            Next
            Console.WriteLine()
        Next
    End Sub

    Sub SextoPunto()
        Dim matriz(10, 10) As String
        For i = 0 To matriz.GetUpperBound(0) - 1
            For k = 0 To matriz.GetUpperBound(1) - 1
                If (i + k = matriz.GetUpperBound(0) - 1) Then
                    matriz(i, k) = "?"
                End If
            Next
        Next
        For i = 0 To matriz.GetUpperBound(0) - 1
            For k = 0 To matriz.GetUpperBound(1) - 1
                Console.Write(matriz(i, k) & " ")
            Next
            Console.WriteLine()
        Next
    End Sub

    Sub SeptimoPunto()
        Dim matriz(10, 10) As String
        For i = 0 To matriz.GetUpperBound(0) - 1
            For k = 0 To matriz.GetUpperBound(1) - 1
                If (i = k) Then
                    matriz(i, k) = "?"
                ElseIf (i + k = matriz.GetUpperBound(0) - 1) Then
                    matriz(i, k) = "?"
                End If
            Next
        Next
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                Console.Write(matriz(i, j) & " ")
            Next
            Console.WriteLine()
        Next
    End Sub

    Sub OctavoPunto()
        Dim matriz(10, 10) As String
        For i = 0 To matriz.GetUpperBound(0) - 1
            For k = 0 To matriz.GetUpperBound(1) - 1
                If (i = 0 Or i = matriz.GetUpperBound(0) - 1) And (k = 0 Or k = matriz.GetUpperBound(1) - 1) Then
                    matriz(i, k) = "0"
                End If
            Next
        Next
        For i = 0 To matriz.GetUpperBound(0) - 1
            For j = 0 To matriz.GetUpperBound(1) - 1
                Console.Write(matriz(i, j) & " ")
            Next
            Console.WriteLine()
        Next
    End Sub
End Module
