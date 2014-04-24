Public Class Form1
    Dim hp, mp As Integer

    Private Sub TextBoxHp_TextChanged(sender As Object, e As EventArgs) Handles TextBoxHp.TextChanged
        hp = TextBoxHp.Text
    End Sub

    Private Sub TextBoxMp_TextChanged(sender As Object, e As EventArgs) Handles TextBoxMp.TextChanged
        mp = TextBoxMp.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If hp = 0 And mp = 0 Then MsgBox("ゲームオーバー") Else MsgBox("続行")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If hp = 0 Or mp = 0 Then MsgBox("ゲームオーバー") Else MsgBox("続行")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If hp <= 10 Then MsgBox("瀕死")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If 10 < hp <= 20 Then MsgBox("危険") 'VBならこの書き方正解なのに"And使わないとエラーが起こる"って言っちゃうくらいにはこの先生あれ
    End Sub
End Class
