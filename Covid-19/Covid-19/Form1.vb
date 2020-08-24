Public Class Form1
    Dim sqlnya, hasil As String
    Dim tot As Integer = 0
    Sub panggildata()
        konek()
        DA = New OleDb.OleDbDataAdapter("SELECT * FROM tb_corona", conn)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "tb_corona")
        DataGridView1.DataSource = DS.Tables("tb_corona")
        DataGridView1.Enabled = True
    End Sub
    Sub jalan()
        Dim objcmd As New System.Data.OleDb.OleDbCommand
        Call konek()
        objcmd.Connection = conn
        objcmd.CommandType = CommandType.Text
        objcmd.CommandText = sqlnya
        objcmd.ExecuteNonQuery()
        objcmd.Dispose()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call panggildata()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        sqlnya = "insert into tb_corona(Nama,Umur,Tempat_Tinggal) values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')"
        Call jalan()
        MsgBox("Data Berhasil Tersimpan")
        Call panggildata()
    End Sub

    Private Sub DataGridView1_RowHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.RowHeaderMouseClick
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        TextBox1.Text = DataGridView1.Item(0, i).Value
        TextBox2.Text = DataGridView1.Item(1, i).Value
        TextBox3.Text = DataGridView1.Item(2, i).Value
    End Sub


    Private Sub Button2_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        sqlnya = "delete from tb_corona where Nama='" & TextBox1.Text & "'"
        Call jalan()
        MsgBox("Data Berhasil Terhapus")
        Call panggildata()
    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label26_Click(sender As Object, e As EventArgs) Handles Label26.Click

    End Sub

    Private Sub Label46_Click(sender As Object, e As EventArgs) Handles Label46.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If CheckBox1.Checked = True Then
            tot += 1
        End If
        If CheckBox3.Checked = True Then
            tot += 1
        End If
        If CheckBox5.Checked = True Then
            tot += 1
        End If
        If CheckBox7.Checked = True Then
            tot += 1
        End If
        If CheckBox9.Checked = True Then
            tot += 1
        End If
        If CheckBox11.Checked = True Then
            tot += 1
        End If
        If CheckBox13.Checked = True Then
            tot += 1
        End If
        If CheckBox15.Checked = True Then
            tot += 1
        End If
        If CheckBox17.Checked = True Then
            tot += 1
        End If
        If CheckBox19.Checked = True Then
            tot += 1
        End If
        If CheckBox21.Checked = True Then
            tot += 1
        End If
        If CheckBox23.Checked = True Then
            tot += 1
        End If
        If CheckBox25.Checked = True Then
            tot += 1
        End If
        If CheckBox27.Checked = True Then
            tot += 1
        End If
        If CheckBox29.Checked = True Then
            tot += 1
        End If
        If CheckBox31.Checked = True Then
            tot += 1
        End If
        If CheckBox33.Checked = True Then
            tot += 1
        End If
        If CheckBox35.Checked = True Then
            tot += 1
        End If
        If CheckBox37.Checked = True Then
            tot += 1
        End If
        If CheckBox39.Checked = True Then
            tot += 1
        End If
        If CheckBox41.Checked = True Then
            tot += 1
        End If
        If tot < 8 Then
            hasil = "Resiko Rendah"
            MsgBox("Resiko Anda Rendah")
        ElseIf tot < 15 Then
            hasil = "Resiko Sedang"
            MsgBox("Anda Lumayan Beresiko")
        ElseIf tot > 14 Then
            hasil = "Resiko Tinggi"
            MsgBox("Resiko Anda Sangat Tinggi")
        End If

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
