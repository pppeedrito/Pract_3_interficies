Public Class Form1
    Private MAX As Integer
    Private Sub BtnAgr_Click(sender As Object, e As EventArgs) Handles BtnAgr.Click
        OrdenarCombo(TxtUsuari.Text)

    End Sub

    Private Sub OrdenarCombo(text As String)
        Dim numero As Integer
        MAX = Lista.SelectedItems.Count() - 1
        Try
            numero = text
        Catch ex As Exception
            MsgBox("Error introducido malo.")
            TxtUsuari.Clear()
            TxtUsuari.Focus()

        End Try
        Dim i As Integer
        i = ComboObligatorio.SelectedIndex
        Select Case i
            Case 0
                Lista.Items.Insert(0, TxtUsuari.Text)
            Case 1
                If CInt(Lista.Items.Count()) = CInt("0") Then
                    Lista.Items.Add(text)

                Else
                    Dim j = 0
                    For j = 0 To MAX Step 1
                        If (CDbl(text) < CDbl(Lista.Items.Item(j))) Then
                            Lista.Items.Insert(j, CDbl(text))
                            Exit For

                        ElseIf (i = MAX) Then
                            Lista.Items.Add(text)
                            Exit For

                        End If
                    Next j

                    j = 0
                End If
            Case 2
                Lista.Items.Add(TxtUsuari.Text)

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


        For j = 0 To MAX Step 1
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
        Dim resultat As Integer
        If (Rdbtn_Desc.Checked = False) Then
            For I = 0 To MAX
                For J = 0 To MAX
                    If CDbl(Lista.Items.Item(I)) < CDbl(Lista.Items.Item(J)) Then
                        resultat = CDbl(Lista.Items.Item(J))
                        Lista.Items.Item(J) = Lista.Items.Item(I)
                        Lista.Items.Item(I) = resultat
                    End If
                Next J
            Next I



        ElseIf (Rdbtn_Desc.Checked = True) Then
            For I = 0 To MAX
                For J = 0 To MAX
                    If CDbl(Lista.Items.Item(I)) > CDbl(Lista.Items.Item(J)) Then
                        resultat = CDbl(Lista.Items.Item(J))
                        Lista.Items.Item(J) = Lista.Items.Item(I)
                        Lista.Items.Item(I) = resultat
                    End If
                Next J
            Next I


        End If
    End Sub
End Class
