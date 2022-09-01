Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim date1 As Date
        Dim date2 As Date
        Dim year, year1, month, days As Integer
        Dim diff As Double
        Dim datet As TimeSpan
        date1 = DateTimePicker1.Value.ToShortDateString
        date2 = DateTimePicker2.Value.ToShortDateString
        datet = date2 - date1
        diff = datet.Days
        year = Int(diff / 365)
        year1 = diff Mod 365
        month = Int(year1 / 30)
        days = year1 Mod 30
        TextBox1.Text = year
        TextBox2.Text = month
        TextBox3.Text = days
    End Sub
End Class
