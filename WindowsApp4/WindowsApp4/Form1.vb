﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If PictureBox1.Visible Then
            PictureBox1.Visible = False
            PictureBox2.Visible = True
            PictureBox3.Visible = False
        ElseIf PictureBox2.Visible Then
            PictureBox1.Visible = False
            PictureBox2.Visible = False
            PictureBox3.Visible = True
        ElseIf PictureBox3.Visible Then
            PictureBox1.Visible = True
            PictureBox2.Visible = False
            PictureBox3.Visible = False
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Interval = 3000

    End Sub
End Class
