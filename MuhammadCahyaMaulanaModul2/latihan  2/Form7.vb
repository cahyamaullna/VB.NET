Public Class Form7

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "Alek" And TextBox2.Text = "tampan" Then
            MsgBox("Selamat Datang")
        Else
            MsgBox("Passoword atau Username yang Anda Masukan Salah")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub
End Class