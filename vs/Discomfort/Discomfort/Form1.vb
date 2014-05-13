Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As String
        Select Case Integer.Parse(TextBox1.Text)
            Case Is < 55
                result = "寒い"
            Case Is < 60
                result = "肌寒い"
            Case Is < 65
                result = "何も感じない"
            Case Is < 75
                result = "快適"
            Case 75
                result = "最も快適"
            Case Is < 80
                result = "やや暑い"
            Case Is < 85
                result = "暑くて汗がでる"
            Case Else
                result = "暑くてたまらない"
        End Select
        Label1.Text = result
    End Sub
End Class

'VBに対する不快指数はとっくにオーバーフローしています
