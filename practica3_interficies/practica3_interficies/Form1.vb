Public Class Form1
    Private Sub BtnAgr_Click(sender As Object, e As EventArgs) Handles BtnAgr.Click
        If (ComboObligatorio.SelectedIndex = 0) Then
            Lista.Items.Insert(0, Text)
        ElseIf (ComboObligatorio.SelectedIndex = 0) Then
            Lista.Items.Add(Text)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboObligatorio.SelectedIndex = 1
    End Sub

End Class
