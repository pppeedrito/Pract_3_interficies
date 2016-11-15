Public Class Form1
    Private Sub BtnAgr_Click(sender As Object, e As EventArgs) Handles BtnAgr.Click

        OrdenarCombo(TxtUsuari.Text)

    End Sub

    Private Sub OrdenarCombo(text As String)
        Dim numero As Integer
        Try
            numero = CInt(text)
        Catch
            MsgBox("Error introducido malo.")
            TxtUsuari.Clear()
            TxtUsuari.Focus()
            Exit Sub
        End Try

        Dim i As Integer
        Dim MAX As Integer
        MAX = Lista.Items.Count() - 1
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
                        ElseIf j = MAX Then
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
        ComboObligatorio.SelectedIndex = 1
    End Sub

    Private Sub TxtUsuari_TextChanged(sender As Object, e As EventArgs) Handles TxtUsuari.TextChanged

    End Sub

    Private Sub Lista_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Lista.SelectedIndexChanged

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim posicion As Integer
        posicion = (Lista.SelectedIndex)
        Try
            Lista.Items.RemoveAt(posicion)
        Catch ex As Exception
            MsgBox("Tienes que seleccionar un numero de la lista para borrarlo.")
        End Try
    End Sub

    Private Sub Btn_Inf_Click(sender As Object, e As EventArgs) Handles Btn_Inf.Click
        Dim suma As Integer
        Dim media As Integer
        Dim max As Integer
        Dim i As Integer
        Dim min As Integer

        Try
            max = Lista.Items.Item(0)
            MinimizeBox = Lista.Items.Item(0)

        Catch ex As Exception
            MsgBox("No hay valores en la tabla")
            Exit Sub
        End Try
        max = Lista.Items.Count() - 1
        For i = 0 To Lista.Items.Count() - 1 Step 1
            suma = suma + Lista.Items.Item(i)

            If (CDbl(Lista.Items.Item(i) > max)) Then
                max = Lista.Items.Item(i)
            ElseIf (CDbl(Lista.Items.Item(i) < max)) Then
                min = Lista.Items.Item(i)

            End If
        Next i
        media = suma / i
        MsgBox("El numero mas grandes es: " + CStr(max) + vbCr + "El mas pequeño es: " + CStr(min) + vbCr + "La media es: " + CStr(media))


    End Sub

    Private Sub Btn_OrdNum_Click(sender As Object, e As EventArgs) Handles Btn_OrdNum.Click
        Dim i, j, max, res As Integer
        max = Lista.Items.Count() - 1
        For i = 0 To max
            For j = 0 To max
                If CDbl(Lista.Items.Item(i)) > CDbl(Lista.Items.Item(j)) Then
                    res = CDbl(Lista.Items.Item(j))
                    Lista.Items.Item(j) = Lista.Items.Item(i)
                    Lista.Items.Item(i) = res
                End If
            Next j
        Next i


        End If
    End Sub
End Class
