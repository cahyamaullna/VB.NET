﻿Public Class Form10

    Private Sub Form10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'BULAN==================================='
        ComboBox1.Items.Add("01")
        ComboBox1.Items.Add("02")
        ComboBox1.Items.Add("03")
        ComboBox1.Items.Add("04")
        ComboBox1.Items.Add("05")
        ComboBox1.Items.Add("06")
        ComboBox1.Items.Add("07")
        ComboBox1.Items.Add("08")
        'TAHUN=================================='
        ComboBox2.Items.Add("1998")
        ComboBox2.Items.Add("1999")
        ComboBox2.Items.Add("2000")
        'AGAMA================================='
        ComboBox3.Items.Add("Islam")
        ComboBox3.Items.Add("Kristen")
        ComboBox3.Items.Add("Hindu")
        ComboBox3.Items.Add("Budha")
        ComboBox3.Items.Add("Kong Hu cu")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Label11.Text = Val(TextBox5.Text) + Val(TextBox6.Text) + Val(TextBox8.Text)
        Label12.Text = Val(Label11.Text) / 4
        If Val(Label12.Text) >= 75 Then
            MsgBox("Selamat Anda Lulus ", vbInformation, "100 program says")
        Else
            MsgBox("Maaf Anda Belum Lulus ", vbInformation, "100 program says")
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class