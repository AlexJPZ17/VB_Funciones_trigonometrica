Public Class Form1
    Public Sub Trigonometria()
        'Declaro 6 variables de tipo doublé
        Dim adyacente, hipotenusa, opuesto, a, b, r As Double
        'Condición que evalúa el RadioButton si es seleccionado
        If RadioButton_Adyacente.Checked Then
            'Condición que valida los TextBox si  estos están vacío
            If TextBox_Hipotenusa.Text="" Then
                MessageBox.Show("Ingrese un valor al campo del texto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                'Coloca el Focus en el TextBox_Hipotenusa
                TextBox_Hipotenusa.Focus()
            Else
                If TextBox_Opuesto.Text = "" Then
                    MessageBox.Show("Ingrese un valor al campo del texto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'Coloca el Focus en el TextBox_Opuesto
                    TextBox_Opuesto.Focus()
                Else
                    ' Para sacar el Adyacente
                    'Funciones que convierte en un tipo doublé el valor que se ingrese por 
                    'los TextBox y lo almacena en la variable opuesto y hipotenusa
                    hipotenusa = Convert.ToDouble(TextBox_Hipotenusa.Text)
                    opuesto = Convert.ToDouble(TextBox_Opuesto.Text)
                    'Eleva al cuadrado el dato almacenado en las variable 
                    'opuesto hipotenusa y loa almacena  en las variables a,b
                    a = Math.Pow(hipotenusa, 2)
                    b = Math.Pow(opuesto, 2)
                    ' Resta los datos almacenado en las variables a, b
                    r = a - b
                    ' Saca la raíz cuadrada del dato almacenado en la variable r y lo 
                    ' almacena en la variable adyacente
                    adyacente = Math.Sqrt(r)
                    MessageBox.Show("El lado adyacente es :  " & adyacente & "Cm")
                End If

            End If
        Else 'Del RadioButton_Adyacente

            'Condición que evalúa el RadioButton si es seleccionado
            If RadioButton_Hipotenusa.Checked Then
                'Condición que valida los TextBox si  estos están vacío
                If TextBox_Opuesto.Text = "" Then
                    MessageBox.Show("Ingrese un valor al campo del texto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    'Coloca el Focus en el TextBox_Opuesto
                    TextBox_Opuesto.Focus()
                Else
                    If TextBox_Adyacente.Text = "" Then
                        MessageBox.Show("Ingrese un valor al campo del texto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'Coloca el Focus en el TextBox_Adyacente
                        TextBox_Adyacente.Focus()
                    Else
                        ' Para sacar la Hipotenusa
                        'Funciones que convierte en un tipo doublé el valor que se ingrese por 
                        'los TextBox y lo almacena en la variable opuesto y adyacente
                        adyacente = Convert.ToDouble(TextBox_Adyacente.Text)
                        opuesto = Convert.ToDouble(TextBox_Opuesto.Text)
                        'Eleva al cuadrado el dato almacenado en las variable 
                        'opuesto hipotenusa y loa almacena  en las variables a,b
                        a = Math.Pow(adyacente, 2)
                        b = Math.Pow(opuesto, 2)
                        ' Suma los datos almacenado en las variables a, b
                        r = a + b
                        ' Saca la raíz cuadrada del dato almacenado en la variable r y lo 
                        ' almacena en la variable hipotenusa
                        hipotenusa = Math.Sqrt(r)
                        MessageBox.Show("La hipotenusa es :  " & hipotenusa & " Cm")
                    End If

                End If
            Else 'Del RadioButton_Hipoptenusa

                'Condición que evalúa el RadioButton si es seleccionado
                If RadioButton_Opuesto.Checked Then
                    'Condición que valida los TextBox si  estos están vacío
                    If TextBox_Hipotenusa.Text = "" Then
                        MessageBox.Show("Ingrese un valor al campo del texto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        'Coloca el Focus en el TextBox_Hipotenusa
                        TextBox_Hipotenusa.Focus()
                    Else
                        If TextBox_Adyacente.Text = "" Then
                            MessageBox.Show("Ingrese un valor al campo del texto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            'Coloca el Focus en el TextBox_Adyacente
                            TextBox_Adyacente.Focus()
                        Else
                            ' Para sacar el lado Opuesto

                            'Funciones que convierte en un tipo doublé el valor que se ingrese por 
                            'los TextBox y lo almacena en la variable adyacente y hipotenusa
                            hipotenusa = Convert.ToDouble(TextBox_Hipotenusa.Text)
                            adyacente = Convert.ToDouble(TextBox_Adyacente.Text)
                            'Eleva al cuadrado el dato almacenado en las variable 
                            'opuesto hipotenusa y loa almacena  en las variables a,b
                            a = Math.Pow(hipotenusa, 2)
                            b = Math.Pow(adyacente, 2)
                            ' Resta los datos almacenado en las variables a, b
                            r = a - b
                            ' Saca la raíz cuadrada del dato almacenado en la variable r y lo 
                            ' almacena en la variable Opuesto
                            opuesto = Math.Sqrt(r)
                            MessageBox.Show("El lado opuesto es :  " & opuesto & " Cm")
                        End If

                    End If
                Else 'Del RadioButton_Hipoptenusa

                End If
            End If
        End If

    End Sub

    Private Sub RadioButton_Adyacente_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Adyacente.CheckedChanged
        TextBox_Adyacente.Visible = False
        TextBox_Hipotenusa.Visible = True
        TextBox_Opuesto.Visible = True
        TextBox_Hipotenusa.Text = ""
        TextBox_Opuesto.Text = ""

    End Sub

    Private Sub RadioButton_Hipotenusa_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Hipotenusa.CheckedChanged
        TextBox_Adyacente.Visible = True
        TextBox_Hipotenusa.Visible = False
        TextBox_Opuesto.Visible = True
        TextBox_Adyacente.Text = ""
        TextBox_Opuesto.Text = ""

    End Sub

    Private Sub RadioButton_Opuesto_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton_Opuesto.CheckedChanged
        TextBox_Adyacente.Visible = True
        TextBox_Hipotenusa.Visible = True
        TextBox_Opuesto.Visible = False
        TextBox_Hipotenusa.Text = ""
        TextBox_Adyacente.Text = ""

    End Sub

    Private Sub Button_Run_Click(sender As Object, e As EventArgs) Handles Button_Run.Click
        Trigonometria()
    End Sub
End Class
