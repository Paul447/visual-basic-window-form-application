Imports System.Drawing.Drawing2D
Imports System.Drawing.Brushes
Public Class Form1
    Dim g As Graphics
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        g = Panel2.CreateGraphics
    End Sub

    Private Sub btnRectangle_Click(sender As Object, e As EventArgs) Handles btnRectangle.Click
        Dim r As New Rectangle(10, 10, 300, 200)
        g.DrawRectangle(Pens.Blue, r)
        Panel2.CreateGraphics.FillRectangle(Brushes.Gray, r)
        Panel2.Refresh()
    End Sub

    Private Sub btnCircle_Click(sender As Object, e As EventArgs) Handles btnCircle.Click
        Dim r As New Rectangle(10, 10, 200, 200)
        g.DrawEllipse(Pens.Blue, r)

    End Sub

    Private Sub btnEllipse_Click(sender As Object, e As EventArgs) Handles btnEllipse.Click
        Dim r As New Rectangle(10, 10, 300, 200)
        g.DrawEllipse(Pens.Blue, r)
    End Sub

    Private Sub btnPolygon_Click(sender As Object, e As EventArgs) Handles btnPolygon.Click
        Dim p(3) As Point
        p(0) = New Point(20, 60)
        p(1) = New Point(40, 10)
        p(3) = New Point(40, 10)
    End Sub
    Private Sub btnLine_Click(sender As Object, e As EventArgs) Handles btnLine.Click
        g.DrawLine(Pens.Red, 20, 65, 750, 65)
    End Sub
End Class
