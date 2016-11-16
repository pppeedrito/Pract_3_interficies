Public Class Form1
    Private Sub BtnAgr_Click(sender As Object, e As EventArgs) Handles BtnAgr.Click
        OrdenarCombo(TxtUsuari.Text)

    End Sub

    Private Sub OrdenarCombo(text As String)
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
        i = ComboObligatorio.SelectedIndex
        Select Case i
            Case 0
                Lista.Items.Insert(0, TxtUsuari.Text)
                TxtUsuari.Text = ""
            Case 1
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
                Lista.Items.Add(TxtUsuari.Text)
                TxtUsuari.Text = ""

        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboObligatorio.SelectedIndex = 0
    End Sub

    Private Sub Btn_Eliminar_Click(sender As Object, e As EventArgs) Handles Btn_Eliminar.Click
        Dim posicion As Integer

        posicion = (Lista.SelectedIndex)
        Try
            Lista.Items.RemoveAt(posicion)
        Catch ex As Exception
            MsgBox("Tienes que seleccionar un valor para borrar.")
        End Try
    End Sub

    Private Sub Btn_info_Click(sender As Object, e As EventArgs) Handles Btn_info.Click
        Dim maximo As Integer
        Dim minimo As Integer
        Dim suma As Integer
        Dim media As Integer
        Dim j As Integer

        Try
            maximo = Lista.Items.Item(0)
            minimo = Lista.Items.Item(0)
        Catch
            MsgBox("No hay datos en la tabla")
            Exit Sub
        End Try


        For j = 0 To Lista.SelectedItems.Count() - 1 Step 1
            suma = suma + Lista.Items.Item(j)

            If (CDbl(Lista.Items.Item(j) > maximo)) Then
                maximo = Lista.Items.Item(j)

            ElseIf (CDbl(Lista.Items.Item(j) < maximo)) Then
                minimo = Lista.Items.Item(j)

            End If
        Next j

        media = suma / j
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

    Private Sub Btn_ord_asci_Click(sender As Object, e As EventArgs) Handles Btn_ord_asci.Click
        Lista.Sorted = True
        Lista.Sorted = False

    End Sub

    Private Sub Btn_preg_Click(sender As Object, e As EventArgs) Handles Btn_preg.Click
        'tienes que preguntar que qioere intorducir con un aceptar o cancelar y controlando que combo haya pillado algo.

    End Sub

End Class
