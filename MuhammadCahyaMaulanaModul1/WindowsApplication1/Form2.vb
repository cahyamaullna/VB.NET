Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim Tampung As String
        TextBox3.Text = TextBox2.Text
        TextBox2.Text = TextBox1.Text
        TextBox1.Text = tampung

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class