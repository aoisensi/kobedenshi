Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        PictureBox1.Left -= 10
        If PictureBox1.Left < 0 Then PictureBox1.Left = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PictureBox1.Top -= 10
        If PictureBox1.Top < 0 Then PictureBox1.Top = 0
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PictureBox1.Left += 10
        If PictureBox1.Right > Me.Width Then PictureBox1.Left = Me.Width - PictureBox1.Width
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        PictureBox1.Top += 10
        If PictureBox1.Bottom > Me.Height Then PictureBox1.Top = Me.Height - PictureBox1.Height
    End Sub
End Class
