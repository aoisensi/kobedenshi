Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hp As Integer
        If hp = 0 Then
            MsgBox("ゲームオーバー")
        ElseIf hp = 100 Then
            MsgBox("全回復")
        Else
            MsgBox("続行")
        End If
        'どうやらVBの先生によるとC言語にはデバッガが存在しないらしい
    End Sub
End Class
