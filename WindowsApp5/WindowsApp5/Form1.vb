Public Class Form1

    Dim a, b, mul, add, supt, div As Integer

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        a = TextBox1.Text
        b = TextBox2.Text
        supt = a - b
        Label1.Text = supt
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        a = TextBox1.Text
        b = TextBox2.Text
        add = a + b
        Label1.Text = add


    End Sub
End Class
