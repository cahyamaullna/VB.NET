﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(177, 30)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(343, 22)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(177, 84)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(71, 27)
        Me.TextBox2.TabIndex = 1
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(263, 84)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox1.TabIndex = 2
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(399, 84)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 24)
        Me.ComboBox2.TabIndex = 3
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(177, 139)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(86, 21)
        Me.RadioButton1.TabIndex = 4
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Laki-Laki"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(334, 139)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(102, 21)
        Me.RadioButton2.TabIndex = 5
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Perempuan"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(177, 174)
        Me.TextBox3.Multiline = True
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(346, 140)
        Me.TextBox3.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(59, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(59, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Tanggal Lahir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 143)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Jenis Kelamin"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(59, 199)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Alamat "
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(177, 322)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(345, 32)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Simpan"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(551, 381)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "Form5"
        Me.Text = "Form5"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
