<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmType1
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
        Me.grp大分類CD = New BaseUI.Control.GroupBox()
        Me.txt大分類CD = New BaseUI.Control.TextBox()
        Me.grp大分類名 = New BaseUI.Control.GroupBox()
        Me.txt大分類名 = New BaseUI.Control.TextBox()
        Me.grp月当り人件費 = New BaseUI.Control.GroupBox()
        Me.txt月当り人件費 = New BaseUI.Control.TextBox()
        Me.Label1 = New BaseUI.Control.Label()
        Me.grp月当り間接固定経費 = New BaseUI.Control.GroupBox()
        Me.txt月当り間接固定経費 = New BaseUI.Control.TextBox()
        Me.Label2 = New BaseUI.Control.Label()
        Me.grp処理区分.SuspendLayout()
        Me.grp大分類CD.SuspendLayout()
        Me.grp大分類名.SuspendLayout()
        Me.grp月当り人件費.SuspendLayout()
        Me.grp月当り間接固定経費.SuspendLayout()
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
        Me.grp処理区分.Location = New System.Drawing.Point(84, 25)
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
        'grp大分類CD
        '
        Me.grp大分類CD.Controls.Add(Me.txt大分類CD)
        Me.grp大分類CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp大分類CD.Location = New System.Drawing.Point(84, 125)
        Me.grp大分類CD.Name = "grp大分類CD"
        Me.grp大分類CD.Size = New System.Drawing.Size(100, 61)
        Me.grp大分類CD.TabIndex = 1
        Me.grp大分類CD.TabStop = False
        Me.grp大分類CD.Text = "大分類CD"
        '
        'txt大分類CD
        '
        Me.txt大分類CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt大分類CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt大分類CD.HelpKeys = ""
        Me.txt大分類CD.HelpLink = ""
        Me.txt大分類CD.HelpType = NodeUI.Help.Type.None
        Me.txt大分類CD.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt大分類CD.IsError = False
        Me.txt大分類CD.Location = New System.Drawing.Point(32, 22)
        Me.txt大分類CD.Name = "txt大分類CD"
        Me.txt大分類CD.Required = False
        Me.txt大分類CD.Size = New System.Drawing.Size(17, 23)
        Me.txt大分類CD.StringLength = 65535
        Me.txt大分類CD.TabIndex = 0
        Me.txt大分類CD.Text = "1"
        Me.txt大分類CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp大分類名
        '
        Me.grp大分類名.Controls.Add(Me.txt大分類名)
        Me.grp大分類名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp大分類名.Location = New System.Drawing.Point(84, 223)
        Me.grp大分類名.Name = "grp大分類名"
        Me.grp大分類名.Size = New System.Drawing.Size(154, 61)
        Me.grp大分類名.TabIndex = 2
        Me.grp大分類名.TabStop = False
        Me.grp大分類名.Text = "大分類名"
        '
        'txt大分類名
        '
        Me.txt大分類名.FieldLockType = BaseContents.Field.LockType.None
        Me.txt大分類名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt大分類名.HelpKeys = ""
        Me.txt大分類名.HelpLink = ""
        Me.txt大分類名.HelpType = NodeUI.Help.Type.None
        Me.txt大分類名.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt大分類名.IsError = False
        Me.txt大分類名.Location = New System.Drawing.Point(19, 24)
        Me.txt大分類名.Name = "txt大分類名"
        Me.txt大分類名.Required = False
        Me.txt大分類名.Size = New System.Drawing.Size(91, 23)
        Me.txt大分類名.StringLength = 65535
        Me.txt大分類名.TabIndex = 0
        Me.txt大分類名.Text = "AAAAAAAAAA"
        Me.txt大分類名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp月当り人件費
        '
        Me.grp月当り人件費.Controls.Add(Me.txt月当り人件費)
        Me.grp月当り人件費.Controls.Add(Me.Label1)
        Me.grp月当り人件費.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp月当り人件費.Location = New System.Drawing.Point(85, 325)
        Me.grp月当り人件費.Name = "grp月当り人件費"
        Me.grp月当り人件費.Size = New System.Drawing.Size(209, 65)
        Me.grp月当り人件費.TabIndex = 3
        Me.grp月当り人件費.TabStop = False
        Me.grp月当り人件費.Text = "1ヶ月当り人件費"
        '
        'txt月当り人件費
        '
        Me.txt月当り人件費.FieldLockType = BaseContents.Field.LockType.None
        Me.txt月当り人件費.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt月当り人件費.HelpKeys = ""
        Me.txt月当り人件費.HelpLink = ""
        Me.txt月当り人件費.HelpType = NodeUI.Help.Type.None
        Me.txt月当り人件費.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt月当り人件費.IsError = False
        Me.txt月当り人件費.Location = New System.Drawing.Point(21, 24)
        Me.txt月当り人件費.Name = "txt月当り人件費"
        Me.txt月当り人件費.Required = False
        Me.txt月当り人件費.Size = New System.Drawing.Size(132, 23)
        Me.txt月当り人件費.StringLength = 65535
        Me.txt月当り人件費.TabIndex = 0
        Me.txt月当り人件費.Text = "1,234,567"
        Me.txt月当り人件費.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt月当り人件費.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(159, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 16)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "円"
        '
        'grp月当り間接固定経費
        '
        Me.grp月当り間接固定経費.Controls.Add(Me.txt月当り間接固定経費)
        Me.grp月当り間接固定経費.Controls.Add(Me.Label2)
        Me.grp月当り間接固定経費.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp月当り間接固定経費.Location = New System.Drawing.Point(84, 431)
        Me.grp月当り間接固定経費.Name = "grp月当り間接固定経費"
        Me.grp月当り間接固定経費.Size = New System.Drawing.Size(210, 65)
        Me.grp月当り間接固定経費.TabIndex = 4
        Me.grp月当り間接固定経費.TabStop = False
        Me.grp月当り間接固定経費.Text = "1ヶ月当り間接固定経費"
        '
        'txt月当り間接固定経費
        '
        Me.txt月当り間接固定経費.FieldLockType = BaseContents.Field.LockType.None
        Me.txt月当り間接固定経費.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt月当り間接固定経費.HelpKeys = ""
        Me.txt月当り間接固定経費.HelpLink = ""
        Me.txt月当り間接固定経費.HelpType = NodeUI.Help.Type.None
        Me.txt月当り間接固定経費.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt月当り間接固定経費.IsError = False
        Me.txt月当り間接固定経費.Location = New System.Drawing.Point(22, 24)
        Me.txt月当り間接固定経費.Name = "txt月当り間接固定経費"
        Me.txt月当り間接固定経費.Required = False
        Me.txt月当り間接固定経費.Size = New System.Drawing.Size(132, 23)
        Me.txt月当り間接固定経費.StringLength = 65535
        Me.txt月当り間接固定経費.TabIndex = 0
        Me.txt月当り間接固定経費.Text = "1,234,567"
        Me.txt月当り間接固定経費.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt月当り間接固定経費.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(160, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "円"
        '
        'frmType1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.grp月当り間接固定経費)
        Me.Controls.Add(Me.grp月当り人件費)
        Me.Controls.Add(Me.grp大分類名)
        Me.Controls.Add(Me.grp大分類CD)
        Me.Controls.Add(Me.grp処理区分)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmType1"
        Me.Text = ""
        Me.Controls.SetChildIndex(Me.grp処理区分, 0)
        Me.Controls.SetChildIndex(Me.grp大分類CD, 0)
        Me.Controls.SetChildIndex(Me.grp大分類名, 0)
        Me.Controls.SetChildIndex(Me.grp月当り人件費, 0)
        Me.Controls.SetChildIndex(Me.grp月当り間接固定経費, 0)
        Me.grp処理区分.ResumeLayout(False)
        Me.grp処理区分.PerformLayout()
        Me.grp大分類CD.ResumeLayout(False)
        Me.grp大分類CD.PerformLayout()
        Me.grp大分類名.ResumeLayout(False)
        Me.grp大分類名.PerformLayout()
        Me.grp月当り人件費.ResumeLayout(False)
        Me.grp月当り人件費.PerformLayout()
        Me.grp月当り間接固定経費.ResumeLayout(False)
        Me.grp月当り間接固定経費.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp処理区分 As BaseUI.Control.GroupBox
    Friend WithEvents opt削除 As BaseUI.Control.RadioButton
    Friend WithEvents opt修正 As BaseUI.Control.RadioButton
    Friend WithEvents opt登録 As BaseUI.Control.RadioButton
    Friend WithEvents grp大分類CD As BaseUI.Control.GroupBox
    Friend WithEvents txt大分類CD As BaseUI.Control.TextBox
    Friend WithEvents grp大分類名 As BaseUI.Control.GroupBox
    Friend WithEvents txt大分類名 As BaseUI.Control.TextBox
    Friend WithEvents grp月当り人件費 As BaseUI.Control.GroupBox
    Friend WithEvents txt月当り人件費 As BaseUI.Control.TextBox
    Friend WithEvents Label1 As BaseUI.Control.Label
    Friend WithEvents grp月当り間接固定経費 As BaseUI.Control.GroupBox
    Friend WithEvents Label2 As BaseUI.Control.Label
    Friend WithEvents txt月当り間接固定経費 As BaseUI.Control.TextBox
End Class
