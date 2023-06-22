Public Class Form1
    Private Sub cmdEjecutar_Click(sender As Object, e As EventArgs) Handles cmdEjecutar.Click
        Dim matriz(5, 4) As Integer
        Dim suma As Integer = 0
        Dim may As Integer
        For f = 1 To 5
            For c = 1 To 4
                matriz(f, c) = InputBox("Ingrese los valores de la matriz", "Matriz")
            Next
        Next
        For f = 2 To 5
            For c = 1 To 4
                suma = suma + matriz(f, c)
            Next
        Next
        For f = 1 To 5
            For c = 2 To 4
                If matriz(f, c) > may Then
                    may = matriz(f, c)
                End If
            Next
        Next


        grdMostrarMatriz.Columns.Clear()
        For j = 1 To 4
            grdMostrarMatriz.Columns.Add("", "")
        Next
        grdMostrarMatriz.Rows.Add(5)


        For f = 1 To 5
            For c = 1 To 4
                grdMostrarMatriz.Item(c - 1, f - 1).Value = matriz(f, c)
            Next
        Next
        lblMayor.Text = "El mayor valor de las ultimas 3 columnas es: " & may
        lblSuma.Text = "La suma de las ultimas 4 filas es: " & suma
    End Sub
End Class
