Public Class Form1
    Private Sub ButtonToRight_Click(sender As Object, e As EventArgs) Handles ButtonToRight.Click
        Label.Left += 1
    End Sub

    Private Sub ButtonTest_Click(sender As Object, e As EventArgs) Handles ButtonTest.Click
        Label.Text = "テスト"
    End Sub

    Private Sub ButtonChangeColor_Click(sender As Object, e As EventArgs) Handles ButtonChangeColor.Click
        Label.BackColor = Color.Blue
    End Sub

    Private Sub ButtonToDown_Click(sender As Object, e As EventArgs) Handles ButtonToDown.Click
        Label.Top += 1
    End Sub

    Private Sub ButtonReset_Click(sender As Object, e As EventArgs) Handles ButtonReset.Click
        Label.Text = "ラベル"
        Label.BackColor = Color.Red
        Label.Top = 13
        Label.Left = 15
        Label.Height = 50
        Label.Width = 100
    End Sub

    Private Sub ButtonExpansion_Click(sender As Object, e As EventArgs) Handles ButtonExpansion.Click
        Label.Width *= 1.1
        Label.Height *= 1.1
    End Sub

    Private Sub ButtonSendString_Click(sender As Object, e As EventArgs) Handles ButtonSendString.Click
        Label.Text = TextBox.Text
    End Sub
End Class

'Visual Basicとかいうクソ助長言語辞めたい
