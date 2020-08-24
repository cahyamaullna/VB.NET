Public Class Form8
    Dim a, b As Integer

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        a = Val(TextBox1.Text)
        b = Val(TextBox2.Text)
        If a > b Then
            MsgBox("Nilai Terbesar Adalah : " & a & vbCrLf & "Nilai Terkecil Adalah :" & b)
        ElseIf a = b Then
            MsgBox("Nilai Pertama Dan Kedua Sama")
        Else
            MsgBox("Nilai Terbesar Adalah :" & b & vbCrLf & "Nilai Terkecil Adalah : " & a)
        End If
    End Sub
End Class