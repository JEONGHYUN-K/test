Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a, n, s As Long
        n = Val(TextBox1.Text)
        s = 0
        For i = 1 To n Step 2
            s += i
        Next i
        TextBox2.Text = s
    End Sub
End Class
