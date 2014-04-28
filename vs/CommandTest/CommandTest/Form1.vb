Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = 1 Then
            Label1.Text = "攻撃"
        ElseIf TextBox1.Text = 2 Then
            Label1.Text = "防御"
        ElseIf TextBox1.Text = 3 Then
            Label1.Text = "魔法"
        Else
            Label1.Text = "コマンドエラー"
        End If
    End Sub
End Class

'switch使おうとしたら "Switchは型です" !??!?!!!??!???
