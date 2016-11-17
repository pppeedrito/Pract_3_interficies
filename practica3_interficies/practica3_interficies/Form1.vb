Public Class Form1
    Private Sub BtnAgr_Click(sender As Object, e As EventArgs) Handles BtnAgr.Click
        OrdenarCombo(TxtUsuari.Text)

    End Sub

    Private Sub OrdenarCombo(text As String)
        'controlamos  lo que introducen.
        Dim numero As Integer
        Try
            numero = CDbl(text)
        Catch ex As Exception
            MsgBox("Error introducido malo.")
            TxtUsuari.Clear()
            TxtUsuari.Focus()
            Exit Sub

        End Try
        Dim i As Integer
        'switch para las 3 obciones 
        i = ComboObligatorio.SelectedIndex
        Select Case i
            Case 0
                'insertamos el numero al principio
                Lista.Items.Insert(0, TxtUsuari.Text)
                TxtUsuari.Text = ""
            Case 1
                'insertamos el numero por el numero mas grande que ese 
                Dim cont As Integer
                Dim agregar As Boolean
                cont = 0
                agregar = False
                While cont < Lista.Items.Count And agregar = False
                    If CDbl(Lista.Items.Item(cont)) >= CDbl(text) Then
                        Lista.Items.Insert(cont, text)
                        TxtUsuari.Text = ""
                        agregar = True
                    End If
                    cont = cont + 1
                End While
                If agregar = False Then
                    Lista.Items.Add(TxtUsuari.Text)
                    TxtUsuari.Text = ""

                End If


            Case 2
                'insertamos el numero al final 
                Lista.Items.Add(TxtUsuari.Text)
                TxtUsuari.Text = ""

        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' por defecto que se carge con el insetar al principio
        ComboObligatorio.SelectedIndex = 0
    End Sub

    Private Sub Btn_Eliminar_Click(sender As Object, e As EventArgs) Handles Btn_Eliminar.Click
        'aqui eliminamos el elemento seleccionado y controlamos que no de un error.
        Dim posicion As Integer

        posicion = (Lista.SelectedIndex)
        Try
            Lista.Items.RemoveAt(posicion)
        Catch ex As Exception
            MsgBox("Tienes que seleccionar un valor para borrar.")
        End Try
    End Sub

    Private Sub Btn_info_Click(sender As Object, e As EventArgs) Handles Btn_info.Click
        Dim minimo, maximo, media As Double
        Dim contador As Integer

        Try
            maximo = Lista.Items.Item(0)
            minimo = Lista.Items.Item(0)
            contador = Lista.Items.Count()
        Catch
            MsgBox("No hay datos en la tabla")
            Exit Sub
        End Try


        For j = 0 To contador - 1
            If j = 0 Then
                minimo = CInt(Lista.Items.Item(j))
            End If
            If (CDbl(Lista.Items.Item(j) > maximo)) Then
                maximo = CInt(Lista.Items.Item(j))

            ElseIf (CDbl(Lista.Items.Item(j) < minimo)) Then
                minimo = CInt(Lista.Items.Item(j))

            End If
            media = media + CInt(Lista.Items.Item(j))
        Next

        media = media / contador
        MsgBox("El numero mas grande es: " + CStr(maximo) + vbCr + "El numero mas pequeño es: " + CStr(minimo) + vbCr + "La media de los numeros  es: " + CStr(media))

    End Sub

    Private Sub btn_ord_num_Click(sender As Object, e As EventArgs) Handles btn_ord_num.Click
        Dim aux As Integer
        If Chck_desc.Checked = True Then
            For I = 0 To Lista.Items.Count - 1 Step +1
                For J = 0 To Lista.Items.Count - 1 Step +1
                    If CDbl(Lista.Items.Item(I)) < CDbl(Lista.Items.Item(J)) Then
                        aux = CDbl(Lista.Items.Item(J))
                        Lista.Items.Item(J) = Lista.Items.Item(I)
                        Lista.Items.Item(I) = aux
                    End If
                Next
            Next
        ElseIf Chck_desc.Checked = False Then

            For I = 0 To Lista.Items.Count - 1 Step +1
                For J = 0 To Lista.Items.Count - 1 Step +1
                    If CDbl(Lista.Items.Item(I)) > CDbl(Lista.Items.Item(J)) Then
                        aux = CDbl(Lista.Items.Item(J))
                        Lista.Items.Item(J) = Lista.Items.Item(I)
                        Lista.Items.Item(I) = aux
                    End If
                Next
            Next
        End If
    End Sub

    Private Sub Btn_ord_asci_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_ord_asci.Click
        'asci desencidente asci ascendiente ! 
        If Chck_desc.Checked = False Then
            Lista.Sorted = True
            Lista.Sorted = False
        ElseIf Chck_desc.Checked = True Then
            StrReverse(CStr(Lista.Sorted = True))
            StrReverse(CStr(Lista.Sorted = False))
        End If
    End Sub

    Private Sub Btn_preg_Click(sender As Object, e As EventArgs) Handles Btn_preg.Click
        'tienes que preguntar que qioere intorducir con un aceptar o cancelar y controlando que combo haya pillado algo.
        Dim resposta As Integer
        resposta = InputBox("Introduce valor para meterlo en el listbox:", "Imprimir")

        If (ComboObligatorio.SelectedIndex = 0) Then
            Lista.Items.Insert(0, resposta)

        ElseIf (ComboObligatorio.SelectedIndex = 2) Then
            Lista.Items.Add(resposta)
        Else
            Dim cont As Integer
            Dim agregar As Boolean
            cont = 0
            agregar = False
            While cont < Lista.Items.Count And agregar = False
                If CDbl(Lista.Items.Item(cont)) >= CDbl(resposta) Then
                    Lista.Items.Insert(cont, resposta)

                    agregar = True
                End If
                cont = cont + 1
            End While
            If agregar = False Then
                Lista.Items.Add(resposta)


            End If
        End If

    End Sub
End Class
