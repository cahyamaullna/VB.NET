Public Class Form6
    Private Sub TextBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Click
        Call Nama()
    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Nama()
    End Sub
    Sub nama()
        Dim a As String
        a = InputBox("Ketikkan Nama Anda", "Informasi")
        TextBox1.TextAlign = a
    End Sub
    Private Sub Button1_click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MsgBox("Nama : " & TextBox1.Text & vbCrLf & "Alamat : " & TextBox2.Text & vbCrLf & "Tanggal Lahir : " & TextBox3 + " - " + TextBox4.Text + " - " + TextBox5.Text, vbInformation, "Informasi Tentang Diri Anda")
    End Sub
    Private Sub BUtton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
    End Sub
End Class