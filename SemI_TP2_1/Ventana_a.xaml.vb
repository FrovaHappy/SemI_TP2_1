Class MainWindow
    Dim a, b, c, x, y, z, resultado_cache As Double
    Dim comprovacion As String

    Private Function Cargar()
        Try 'captura error
            If comprovacion = "primera" Then
                a = Convert.ToDouble(Textbox_a.Text)
                b = Convert.ToDouble(Textbox_b.Text)
                c = Convert.ToDouble(Textbox_c.Text)
            ElseIf comprovacion = "segunda" Then
                a = Convert.ToDouble(Textbox_a.Text)
                x = Convert.ToDouble(Textbox_x.Text)
                y = Convert.ToDouble(Textbox_y.Text)
            ElseIf comprovacion = "tercera" Then
                x = Convert.ToDouble(Textbox_x.Text)
                y = Convert.ToDouble(Textbox_y.Text)
                z = Convert.ToDouble(Textbox_z.Text)
            End If
        Catch exc As Exception
            Return False
        Finally
            Console.ReadLine() 'no se muy bien que hace
        End Try
        Return True 'devuelve verdadero en caso de que no se produsca error
    End Function

    Private Sub Calcular_1_Click(sender As Object, e As RoutedEventArgs) Handles Calcular_1.Click
        comprovacion = "primera"
        If Cargar() = True Then ' si no hay error ejecuta
            resultado_cache = ((Math.Pow(b, 3.0) - 4 * a * c) / (2 * a))
            Label_Resultado_1.Content = Convert.ToString(resultado_cache)
        Else
            Label_Resultado_1.Content = "Null"
        End If
    End Sub

    Private Sub Calcular_2_Click(sender As Object, e As RoutedEventArgs) Handles Calcular_2.Click
        comprovacion = "segunda"
        If Cargar() = True Then ' si no hay error ejecuta
            resultado_cache = (((16 * x) + (2 * y - 8)) / (4 * Math.Pow(a, 2.0)))
            Label_Resultado_2.Content = Convert.ToString(resultado_cache)
        Else
            Label_Resultado_2.Content = "Null"
        End If
    End Sub

    Private Sub Calcular_3_Click(sender As Object, e As RoutedEventArgs) Handles Calcular_3.Click
        comprovacion = "tercera"
        If Cargar() = True Then ' si no hay error ejecuta
            resultado_cache = (((3 * x) + (2 * y)) / (2 * Math.Pow(z, 2.0)))
            Label_Resultado_3.Content = Convert.ToString(resultado_cache)
        Else
            Label_Resultado_3.Content = "Null"
        End If
    End Sub

End Class
