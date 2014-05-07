Public Class Form1

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hy, hi As Integer
        hy = TextBox1.Text * TextBox1.Text * 22 / 10000
        hi = (TextBox1.Text - hy) / hy * 100 & "%"
        TextBox1.Text = hy
        TextBox2.Text = hi
        If hi <= -20 Then
            Label3.Text = "やせすぎ"
        ElseIf hi <= -10 Then
            Label3.Text = "やせぎみ"
        ElseIf hi <= 9 Then
            Label3.Text = "標準"
        ElseIf hi <= 19 Then
            Label3.Text = "やや肥満"
        Else
            Label3.Text = "肥満"
        End If
        '糞助長かつ非明示的でブチ切れそう
    End Sub
End Class
