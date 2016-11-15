Public Class Form1
    Private Sub BtnAgr_Click(sender As Object, e As EventArgs) Handles BtnAgr.Click
        OrdenarCombo(TxtUsuari.Text)

    End Sub

    Private Sub OrdenarCombo(text As String)
        Dim numero As Integer
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
                Dim Tabla

                For j As Integer = 0 To ComboObligatorio.Items.Count() - 1

                Next
                If (ComboBox.SelectedIndex) Then

                End If
            Case 2
                Lista.Items.Add(TxtUsuari.Text)

        End Select
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboObligatorio.SelectedIndex = 1
    End Sub

End Class
