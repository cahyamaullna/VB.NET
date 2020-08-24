Public Class Form5

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TextBox1.Text = Mid(Label5.Text, 1, 2)
        TextBox2.Text = Mid(Label5.Text, 6, 2)
        TextBox3.Text = Mid(Label5.Text, 11, 2)
    End Sub


    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class