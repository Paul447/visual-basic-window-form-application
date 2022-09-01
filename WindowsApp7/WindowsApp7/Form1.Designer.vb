<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnRectangle = New System.Windows.Forms.Button()
        Me.btnCircle = New System.Windows.Forms.Button()
        Me.btnEllipse = New System.Windows.Forms.Button()
        Me.btnPolygon = New System.Windows.Forms.Button()
        Me.btnLine = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.Location = New System.Drawing.Point(266, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(502, 426)
        Me.Panel2.TabIndex = 1
        '
        'btnRectangle
        '
        Me.btnRectangle.Location = New System.Drawing.Point(54, 57)
        Me.btnRectangle.Name = "btnRectangle"
        Me.btnRectangle.Size = New System.Drawing.Size(143, 37)
        Me.btnRectangle.TabIndex = 2
        Me.btnRectangle.Text = "Rectangle"
        Me.btnRectangle.UseVisualStyleBackColor = True
        '
        'btnCircle
        '
        Me.btnCircle.Location = New System.Drawing.Point(54, 123)
        Me.btnCircle.Name = "btnCircle"
        Me.btnCircle.Size = New System.Drawing.Size(143, 37)
        Me.btnCircle.TabIndex = 3
        Me.btnCircle.Text = "Circle"
        Me.btnCircle.UseVisualStyleBackColor = True
        '
        'btnEllipse
        '
        Me.btnEllipse.Location = New System.Drawing.Point(54, 194)
        Me.btnEllipse.Name = "btnEllipse"
        Me.btnEllipse.Size = New System.Drawing.Size(143, 37)
        Me.btnEllipse.TabIndex = 4
        Me.btnEllipse.Text = "Ellipse"
        Me.btnEllipse.UseVisualStyleBackColor = True
        '
        'btnPolygon
        '
        Me.btnPolygon.Location = New System.Drawing.Point(54, 268)
        Me.btnPolygon.Name = "btnPolygon"
        Me.btnPolygon.Size = New System.Drawing.Size(143, 37)
        Me.btnPolygon.TabIndex = 5
        Me.btnPolygon.Text = "Polygon"
        Me.btnPolygon.UseVisualStyleBackColor = True
        '
        'btnLine
        '
        Me.btnLine.Location = New System.Drawing.Point(54, 330)
        Me.btnLine.Name = "btnLine"
        Me.btnLine.Size = New System.Drawing.Size(143, 37)
        Me.btnLine.TabIndex = 6
        Me.btnLine.Text = "Line"
        Me.btnLine.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnLine)
        Me.Controls.Add(Me.btnPolygon)
        Me.Controls.Add(Me.btnEllipse)
        Me.Controls.Add(Me.btnCircle)
        Me.Controls.Add(Me.btnRectangle)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnRectangle As Button
    Friend WithEvents btnCircle As Button
    Friend WithEvents btnEllipse As Button
    Friend WithEvents btnPolygon As Button
    Friend WithEvents btnLine As Button
End Class
