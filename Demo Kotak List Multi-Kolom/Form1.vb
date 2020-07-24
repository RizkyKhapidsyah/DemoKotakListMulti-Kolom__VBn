Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For intNilai = 0 To 300
            listNilai.Items.Add(intNilai)
        Next
    End Sub

End Class