Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim d, year As Integer
        d = TextBox1.Text
        year = Int(d / 365)
        TextBox2.Text = year
        TextBox3.Text = Int((d Mod 365) / 30)
        TextBox4.Text = Int((d Mod 365) Mod 30)
    End Sub
End Class
