Public Class Form6

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = TextBox2.Text Then
            label3.text = "SAMA"
        Else
            label3.text = "TIDAK SAMA "
        End If
    End Sub
End Class