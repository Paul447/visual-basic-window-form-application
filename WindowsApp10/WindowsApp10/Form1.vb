Public Class Form1
    Dim n1, n2 As Integer
    Dim operators As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub buttons(sender As Object, e As EventArgs) Handles Button1.Click, Button2.Click, Button3.Click, Button4.Click, Button5.Click, Button6.Click, Button7.Click, Button8.Click, Button9.Click, Button10.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = sender.text
        Else
            TextBox1.Text = TextBox1.Text & sender.text

        End If
    End Sub
    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Operators = "+"
        n1 = TextBox1.Text
        TextBox1.Text = 0
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        operators = "-"
        n1 = TextBox1.Text
        TextBox1.Text = 0
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        operators = "*"
        n1 = TextBox1.Text
        TextBox1.Text = 0
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        operators = "/"
        n1 = TextBox1.Text
        TextBox1.Text = 0
    End Sub
    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        n2 = TextBox1.Text
        If operators = "+" Then
            TextBox1.Text = Val(n1) + Val(n2)
        ElseIf operators = "-" Then
            TextBox1.Text = Val(n1) - Val(n2)
        ElseIf operators = "*" Then
            TextBox1.Text = Val(n1) * Val(n2)
        ElseIf operators = "/" Then
            TextBox1.Text = Val(n1) / Val(n2)
        End If


    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        TextBox1.Text = 0

    End Sub


End Class
