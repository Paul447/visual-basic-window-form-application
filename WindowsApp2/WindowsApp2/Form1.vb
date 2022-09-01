Public Class Form1

    Dim p, t, r, si

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Text = String.Empty
        TextBox2.Text = String.Empty
        TextBox3.Text = String.Empty
        Label4 = String.Empty
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        p = TextBox1.Text
        t = TextBox2.Text
        r = TextBox3.Text
        si = (p * t * r) / 100
        Label4.Text = si
    End Sub
End Class
