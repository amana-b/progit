<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmType2
    Inherits BaseUI.BaseForm

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
        Me.grp処理区分 = New BaseUI.Control.GroupBox()
        Me.opt削除 = New BaseUI.Control.RadioButton()
        Me.opt修正 = New BaseUI.Control.RadioButton()
        Me.opt登録 = New BaseUI.Control.RadioButton()
        Me.grp小分類CD = New BaseUI.Control.GroupBox()
        Me.txt小分類CD = New BaseUI.Control.TextBox()
        Me.grp小分類名 = New BaseUI.Control.GroupBox()
        Me.txt小分類名 = New BaseUI.Control.TextBox()
        Me.grp処理区分.SuspendLayout()
        Me.grp小分類CD.SuspendLayout()
        Me.grp小分類名.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnESC
        '
        Me.btnESC.Text = "閉じる"
        '
        'grp処理区分
        '
        Me.grp処理区分.Controls.Add(Me.opt削除)
        Me.grp処理区分.Controls.Add(Me.opt修正)
        Me.grp処理区分.Controls.Add(Me.opt登録)
        Me.grp処理区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp処理区分.Location = New System.Drawing.Point(36, 25)
        Me.grp処理区分.Name = "grp処理区分"
        Me.grp処理区分.Size = New System.Drawing.Size(267, 61)
        Me.grp処理区分.TabIndex = 0
        Me.grp処理区分.TabStop = False
        Me.grp処理区分.Text = "処理区分"
        '
        'opt削除
        '
        Me.opt削除.AutoSize = True
        Me.opt削除.FieldLockType = BaseContents.Field.LockType.None
        Me.opt削除.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.opt削除.IsError = False
        Me.opt削除.Location = New System.Drawing.Point(197, 27)
        Me.opt削除.Name = "opt削除"
        Me.opt削除.Required = False
        Me.opt削除.Size = New System.Drawing.Size(58, 20)
        Me.opt削除.TabIndex = 2
        Me.opt削除.TabStop = True
        Me.opt削除.Text = "削除"
        Me.opt削除.UseVisualStyleBackColor = True
        '
        'opt修正
        '
        Me.opt修正.AutoSize = True
        Me.opt修正.FieldLockType = BaseContents.Field.LockType.None
        Me.opt修正.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.opt修正.IsError = False
        Me.opt修正.Location = New System.Drawing.Point(108, 27)
        Me.opt修正.Name = "opt修正"
        Me.opt修正.Required = False
        Me.opt修正.Size = New System.Drawing.Size(58, 20)
        Me.opt修正.TabIndex = 1
        Me.opt修正.Text = "修正"
        Me.opt修正.UseVisualStyleBackColor = True
        '
        'opt登録
        '
        Me.opt登録.AutoSize = True
        Me.opt登録.FieldLockType = BaseContents.Field.LockType.None
        Me.opt登録.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.opt登録.IsError = False
        Me.opt登録.Location = New System.Drawing.Point(19, 27)
        Me.opt登録.Name = "opt登録"
        Me.opt登録.Required = False
        Me.opt登録.Size = New System.Drawing.Size(58, 20)
        Me.opt登録.TabIndex = 0
        Me.opt登録.Text = "登録"
        Me.opt登録.UseVisualStyleBackColor = True
        '
        'grp小分類CD
        '
        Me.grp小分類CD.Controls.Add(Me.txt小分類CD)
        Me.grp小分類CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp小分類CD.Location = New System.Drawing.Point(36, 125)
        Me.grp小分類CD.Name = "grp小分類CD"
        Me.grp小分類CD.Size = New System.Drawing.Size(100, 61)
        Me.grp小分類CD.TabIndex = 1
        Me.grp小分類CD.TabStop = False
        Me.grp小分類CD.Text = "小分類CD"
        '
        'txt小分類CD
        '
        Me.txt小分類CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt小分類CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt小分類CD.HelpKeys = ""
        Me.txt小分類CD.HelpLink = ""
        Me.txt小分類CD.HelpType = NodeUI.Help.Type.None
        Me.txt小分類CD.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt小分類CD.IsError = False
        Me.txt小分類CD.Location = New System.Drawing.Point(32, 22)
        Me.txt小分類CD.Name = "txt小分類CD"
        Me.txt小分類CD.Required = False
        Me.txt小分類CD.Size = New System.Drawing.Size(26, 23)
        Me.txt小分類CD.StringLength = 65535
        Me.txt小分類CD.TabIndex = 0
        Me.txt小分類CD.Text = "11"
        Me.txt小分類CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp小分類名
        '
        Me.grp小分類名.Controls.Add(Me.txt小分類名)
        Me.grp小分類名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp小分類名.Location = New System.Drawing.Point(36, 223)
        Me.grp小分類名.Name = "grp小分類名"
        Me.grp小分類名.Size = New System.Drawing.Size(166, 61)
        Me.grp小分類名.TabIndex = 2
        Me.grp小分類名.TabStop = False
        Me.grp小分類名.Text = "小分類名"
        '
        'txt小分類名
        '
        Me.txt小分類名.FieldLockType = BaseContents.Field.LockType.None
        Me.txt小分類名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt小分類名.HelpKeys = ""
        Me.txt小分類名.HelpLink = ""
        Me.txt小分類名.HelpType = NodeUI.Help.Type.None
        Me.txt小分類名.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt小分類名.IsError = False
        Me.txt小分類名.Location = New System.Drawing.Point(19, 24)
        Me.txt小分類名.Name = "txt小分類名"
        Me.txt小分類名.Required = False
        Me.txt小分類名.Size = New System.Drawing.Size(129, 23)
        Me.txt小分類名.StringLength = 65535
        Me.txt小分類名.TabIndex = 0
        Me.txt小分類名.Text = "AAAAAAAAAA"
        Me.txt小分類名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'frmType2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.grp小分類名)
        Me.Controls.Add(Me.grp小分類CD)
        Me.Controls.Add(Me.grp処理区分)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmType2"
        Me.Text = ""
        Me.Controls.SetChildIndex(Me.grp処理区分, 0)
        Me.Controls.SetChildIndex(Me.grp小分類CD, 0)
        Me.Controls.SetChildIndex(Me.grp小分類名, 0)
        Me.grp処理区分.ResumeLayout(False)
        Me.grp処理区分.PerformLayout()
        Me.grp小分類CD.ResumeLayout(False)
        Me.grp小分類CD.PerformLayout()
        Me.grp小分類名.ResumeLayout(False)
        Me.grp小分類名.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp処理区分 As BaseUI.Control.GroupBox
    Friend WithEvents opt削除 As BaseUI.Control.RadioButton
    Friend WithEvents opt修正 As BaseUI.Control.RadioButton
    Friend WithEvents opt登録 As BaseUI.Control.RadioButton
    Friend WithEvents grp小分類CD As BaseUI.Control.GroupBox
    Friend WithEvents txt小分類CD As BaseUI.Control.TextBox
    Friend WithEvents grp小分類名 As BaseUI.Control.GroupBox
    Friend WithEvents txt小分類名 As BaseUI.Control.TextBox
End Class
