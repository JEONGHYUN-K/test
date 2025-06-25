Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a As New Random
        Dim i As Integer
        i = a.Next(1, 7)
        PictureBox1.Visible = False
        PictureBox2.Visible = False
        PictureBox3.Visible = False
        PictureBox4.Visible = False
        PictureBox5.Visible = False
        PictureBox6.Visible = False
        If i = 1 Then PictureBox1.Visible = True
        If i = 2 Then PictureBox2.Visible = True
        If i = 3 Then PictureBox3.Visible = True
        If i = 4 Then PictureBox4.Visible = True
        If i = 5 Then PictureBox5.Visible = True
        If i = 6 Then PictureBox6.Visible = True
    End Sub
End Class
