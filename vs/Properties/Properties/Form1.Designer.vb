<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'フォームがコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
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

    'Windows フォーム デザイナーで必要です。
    Private components As System.ComponentModel.IContainer

    'メモ: 以下のプロシージャは Windows フォーム デザイナーで必要です。
    'Windows フォーム デザイナーを使用して変更できます。  
    'コード エディターを使って変更しないでください。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label = New System.Windows.Forms.Label()
        Me.ButtonToRight = New System.Windows.Forms.Button()
        Me.ButtonToDown = New System.Windows.Forms.Button()
        Me.ButtonExpansion = New System.Windows.Forms.Button()
        Me.ButtonChangeColor = New System.Windows.Forms.Button()
        Me.ButtonSendString = New System.Windows.Forms.Button()
        Me.ButtonReset = New System.Windows.Forms.Button()
        Me.TextBox = New System.Windows.Forms.TextBox()
        Me.ButtonTest = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label
        '
        Me.Label.BackColor = System.Drawing.Color.Red
        Me.Label.Location = New System.Drawing.Point(15, 13)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(100, 50)
        Me.Label.TabIndex = 0
        Me.Label.Text = "ラベル"
        '
        'ButtonToRight
        '
        Me.ButtonToRight.Location = New System.Drawing.Point(250, 205)
        Me.ButtonToRight.Name = "ButtonToRight"
        Me.ButtonToRight.Size = New System.Drawing.Size(75, 23)
        Me.ButtonToRight.TabIndex = 1
        Me.ButtonToRight.Text = "右移動"
        Me.ButtonToRight.UseVisualStyleBackColor = True
        '
        'ButtonToDown
        '
        Me.ButtonToDown.Location = New System.Drawing.Point(250, 235)
        Me.ButtonToDown.Name = "ButtonToDown"
        Me.ButtonToDown.Size = New System.Drawing.Size(75, 23)
        Me.ButtonToDown.TabIndex = 2
        Me.ButtonToDown.Text = "下移動"
        Me.ButtonToDown.UseVisualStyleBackColor = True
        '
        'ButtonExpansion
        '
        Me.ButtonExpansion.Location = New System.Drawing.Point(250, 265)
        Me.ButtonExpansion.Name = "ButtonExpansion"
        Me.ButtonExpansion.Size = New System.Drawing.Size(75, 23)
        Me.ButtonExpansion.TabIndex = 3
        Me.ButtonExpansion.Text = "拡大"
        Me.ButtonExpansion.UseVisualStyleBackColor = True
        '
        'ButtonChangeColor
        '
        Me.ButtonChangeColor.Location = New System.Drawing.Point(332, 205)
        Me.ButtonChangeColor.Name = "ButtonChangeColor"
        Me.ButtonChangeColor.Size = New System.Drawing.Size(75, 23)
        Me.ButtonChangeColor.TabIndex = 4
        Me.ButtonChangeColor.Text = "色変更"
        Me.ButtonChangeColor.UseVisualStyleBackColor = True
        '
        'ButtonSendString
        '
        Me.ButtonSendString.Location = New System.Drawing.Point(332, 235)
        Me.ButtonSendString.Name = "ButtonSendString"
        Me.ButtonSendString.Size = New System.Drawing.Size(75, 23)
        Me.ButtonSendString.TabIndex = 5
        Me.ButtonSendString.Text = "文字転送"
        Me.ButtonSendString.UseVisualStyleBackColor = True
        '
        'ButtonReset
        '
        Me.ButtonReset.Location = New System.Drawing.Point(332, 265)
        Me.ButtonReset.Name = "ButtonReset"
        Me.ButtonReset.Size = New System.Drawing.Size(75, 23)
        Me.ButtonReset.TabIndex = 6
        Me.ButtonReset.Text = "リセット"
        Me.ButtonReset.UseVisualStyleBackColor = True
        '
        'TextBox
        '
        Me.TextBox.Location = New System.Drawing.Point(332, 294)
        Me.TextBox.Name = "TextBox"
        Me.TextBox.Size = New System.Drawing.Size(75, 19)
        Me.TextBox.TabIndex = 7
        '
        'ButtonTest
        '
        Me.ButtonTest.Location = New System.Drawing.Point(250, 292)
        Me.ButtonTest.Name = "ButtonTest"
        Me.ButtonTest.Size = New System.Drawing.Size(75, 23)
        Me.ButtonTest.TabIndex = 8
        Me.ButtonTest.Text = "テスト"
        Me.ButtonTest.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(419, 325)
        Me.Controls.Add(Me.ButtonTest)
        Me.Controls.Add(Me.TextBox)
        Me.Controls.Add(Me.ButtonReset)
        Me.Controls.Add(Me.ButtonSendString)
        Me.Controls.Add(Me.ButtonChangeColor)
        Me.Controls.Add(Me.ButtonExpansion)
        Me.Controls.Add(Me.ButtonToDown)
        Me.Controls.Add(Me.ButtonToRight)
        Me.Controls.Add(Me.Label)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label As System.Windows.Forms.Label
    Friend WithEvents ButtonToRight As System.Windows.Forms.Button
    Friend WithEvents ButtonToDown As System.Windows.Forms.Button
    Friend WithEvents ButtonExpansion As System.Windows.Forms.Button
    Friend WithEvents ButtonChangeColor As System.Windows.Forms.Button
    Friend WithEvents ButtonSendString As System.Windows.Forms.Button
    Friend WithEvents ButtonReset As System.Windows.Forms.Button
    Friend WithEvents TextBox As System.Windows.Forms.TextBox
    Friend WithEvents ButtonTest As System.Windows.Forms.Button

End Class
