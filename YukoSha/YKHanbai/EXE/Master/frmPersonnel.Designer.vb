<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPersonnel
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
        Me.grp担当者CD = New BaseUI.Control.GroupBox()
        Me.txt担当者CD = New BaseUI.Control.TextBox()
        Me.grp売上日計表 = New BaseUI.Control.GroupBox()
        Me.chk売上日計表対象有無 = New BaseUI.Control.CheckBox()
        Me.grpコーター通数 = New BaseUI.Control.GroupBox()
        Me.txtコーター通数 = New BaseUI.Control.TextBox()
        Me.grp担当者名 = New BaseUI.Control.GroupBox()
        Me.txt担当者名 = New BaseUI.Control.TextBox()
        Me.grpコーター金額 = New BaseUI.Control.GroupBox()
        Me.txtコーター金額 = New BaseUI.Control.TextBox()
        Me.grp開始見積NO = New BaseUI.Control.GroupBox()
        Me.txt開始見積 = New BaseUI.Control.TextBox()
        Me.grp処理区分.SuspendLayout()
        Me.grp担当者CD.SuspendLayout()
        Me.grp売上日計表.SuspendLayout()
        Me.grpコーター通数.SuspendLayout()
        Me.grp担当者名.SuspendLayout()
        Me.grpコーター金額.SuspendLayout()
        Me.grp開始見積NO.SuspendLayout()
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
        Me.grp処理区分.Location = New System.Drawing.Point(29, 22)
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
        'grp担当者CD
        '
        Me.grp担当者CD.Controls.Add(Me.txt担当者CD)
        Me.grp担当者CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp担当者CD.Location = New System.Drawing.Point(29, 108)
        Me.grp担当者CD.Name = "grp担当者CD"
        Me.grp担当者CD.Size = New System.Drawing.Size(115, 61)
        Me.grp担当者CD.TabIndex = 1
        Me.grp担当者CD.TabStop = False
        Me.grp担当者CD.Text = "担当者CD"
        '
        'txt担当者CD
        '
        Me.txt担当者CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt担当者CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt担当者CD.HelpKeys = ""
        Me.txt担当者CD.HelpLink = ""
        Me.txt担当者CD.HelpType = NodeUI.Help.Type.None
        Me.txt担当者CD.IsError = False
        Me.txt担当者CD.Location = New System.Drawing.Point(19, 25)
        Me.txt担当者CD.Name = "txt担当者CD"
        Me.txt担当者CD.Required = False
        Me.txt担当者CD.Size = New System.Drawing.Size(38, 23)
        Me.txt担当者CD.TabIndex = 0
        Me.txt担当者CD.Text = "999"
        Me.txt担当者CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp売上日計表
        '
        Me.grp売上日計表.Controls.Add(Me.chk売上日計表対象有無)
        Me.grp売上日計表.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp売上日計表.Location = New System.Drawing.Point(29, 383)
        Me.grp売上日計表.Name = "grp売上日計表"
        Me.grp売上日計表.Size = New System.Drawing.Size(191, 61)
        Me.grp売上日計表.TabIndex = 5
        Me.grp売上日計表.TabStop = False
        Me.grp売上日計表.Text = "売上日計表"
        '
        'chk売上日計表対象有無
        '
        Me.chk売上日計表対象有無.AutoSize = True
        Me.chk売上日計表対象有無.FieldLockType = BaseContents.Field.LockType.None
        Me.chk売上日計表対象有無.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.chk売上日計表対象有無.IsError = False
        Me.chk売上日計表対象有無.Location = New System.Drawing.Point(25, 24)
        Me.chk売上日計表対象有無.Name = "chk売上日計表対象有無"
        Me.chk売上日計表対象有無.Required = False
        Me.chk売上日計表対象有無.Size = New System.Drawing.Size(107, 20)
        Me.chk売上日計表対象有無.TabIndex = 10
        Me.chk売上日計表対象有無.Text = "対象とする"
        Me.chk売上日計表対象有無.UseVisualStyleBackColor = True
        '
        'grpコーター通数
        '
        Me.grpコーター通数.Controls.Add(Me.txtコーター通数)
        Me.grpコーター通数.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grpコーター通数.Location = New System.Drawing.Point(29, 196)
        Me.grpコーター通数.Name = "grpコーター通数"
        Me.grpコーター通数.Size = New System.Drawing.Size(166, 61)
        Me.grpコーター通数.TabIndex = 3
        Me.grpコーター通数.TabStop = False
        Me.grpコーター通数.Text = "コーター通数"
        '
        'txtコーター通数
        '
        Me.txtコーター通数.FieldLockType = BaseContents.Field.LockType.None
        Me.txtコーター通数.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txtコーター通数.HelpKeys = ""
        Me.txtコーター通数.HelpLink = ""
        Me.txtコーター通数.HelpType = NodeUI.Help.Type.None
        Me.txtコーター通数.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtコーター通数.IsError = False
        Me.txtコーター通数.Location = New System.Drawing.Point(19, 25)
        Me.txtコーター通数.Name = "txtコーター通数"
        Me.txtコーター通数.Required = False
        Me.txtコーター通数.Size = New System.Drawing.Size(124, 23)
        Me.txtコーター通数.TabIndex = 0
        Me.txtコーター通数.Text = "999,999,999"
        Me.txtコーター通数.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtコーター通数.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp担当者名
        '
        Me.grp担当者名.Controls.Add(Me.txt担当者名)
        Me.grp担当者名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp担当者名.Location = New System.Drawing.Point(157, 108)
        Me.grp担当者名.Name = "grp担当者名"
        Me.grp担当者名.Size = New System.Drawing.Size(206, 61)
        Me.grp担当者名.TabIndex = 2
        Me.grp担当者名.TabStop = False
        Me.grp担当者名.Text = "担当者名"
        '
        'txt担当者名
        '
        Me.txt担当者名.FieldLockType = BaseContents.Field.LockType.None
        Me.txt担当者名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt担当者名.HelpKeys = ""
        Me.txt担当者名.HelpLink = ""
        Me.txt担当者名.HelpType = NodeUI.Help.Type.None
        Me.txt担当者名.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt担当者名.IsError = False
        Me.txt担当者名.Location = New System.Drawing.Point(19, 25)
        Me.txt担当者名.Name = "txt担当者名"
        Me.txt担当者名.Required = False
        Me.txt担当者名.Size = New System.Drawing.Size(157, 23)
        Me.txt担当者名.TabIndex = 0
        Me.txt担当者名.Text = "あああああいいい"
        Me.txt担当者名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grpコーター金額
        '
        Me.grpコーター金額.Controls.Add(Me.txtコーター金額)
        Me.grpコーター金額.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grpコーター金額.Location = New System.Drawing.Point(218, 196)
        Me.grpコーター金額.Name = "grpコーター金額"
        Me.grpコーター金額.Size = New System.Drawing.Size(172, 61)
        Me.grpコーター金額.TabIndex = 4
        Me.grpコーター金額.TabStop = False
        Me.grpコーター金額.Text = "コーター金額"
        '
        'txtコーター金額
        '
        Me.txtコーター金額.FieldLockType = BaseContents.Field.LockType.None
        Me.txtコーター金額.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txtコーター金額.HelpKeys = ""
        Me.txtコーター金額.HelpLink = ""
        Me.txtコーター金額.HelpType = NodeUI.Help.Type.None
        Me.txtコーター金額.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtコーター金額.IsError = False
        Me.txtコーター金額.Location = New System.Drawing.Point(19, 25)
        Me.txtコーター金額.Name = "txtコーター金額"
        Me.txtコーター金額.Required = False
        Me.txtコーター金額.Size = New System.Drawing.Size(126, 23)
        Me.txtコーター金額.TabIndex = 0
        Me.txtコーター金額.Text = "999,999,999"
        Me.txtコーター金額.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtコーター金額.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp開始見積NO
        '
        Me.grp開始見積NO.Controls.Add(Me.txt開始見積)
        Me.grp開始見積NO.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp開始見積NO.Location = New System.Drawing.Point(29, 286)
        Me.grp開始見積NO.Name = "grp開始見積NO"
        Me.grp開始見積NO.Size = New System.Drawing.Size(133, 61)
        Me.grp開始見積NO.TabIndex = 3
        Me.grp開始見積NO.TabStop = False
        Me.grp開始見積NO.Text = "開始見積NO"
        '
        'txt開始見積
        '
        Me.txt開始見積.FieldLockType = BaseContents.Field.LockType.None
        Me.txt開始見積.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt開始見積.HelpKeys = ""
        Me.txt開始見積.HelpLink = ""
        Me.txt開始見積.HelpType = NodeUI.Help.Type.None
        Me.txt開始見積.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt開始見積.IsError = False
        Me.txt開始見積.Location = New System.Drawing.Point(32, 25)
        Me.txt開始見積.Name = "txt開始見積"
        Me.txt開始見積.Required = False
        Me.txt開始見積.Size = New System.Drawing.Size(70, 23)
        Me.txt開始見積.TabIndex = 0
        Me.txt開始見積.Text = "999999"
        Me.txt開始見積.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'frmPersonnel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.grpコーター金額)
        Me.Controls.Add(Me.grp開始見積NO)
        Me.Controls.Add(Me.grpコーター通数)
        Me.Controls.Add(Me.grp売上日計表)
        Me.Controls.Add(Me.grp担当者名)
        Me.Controls.Add(Me.grp担当者CD)
        Me.Controls.Add(Me.grp処理区分)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmPersonnel"
        Me.Text = ""
        Me.Controls.SetChildIndex(Me.grp処理区分, 0)
        Me.Controls.SetChildIndex(Me.grp担当者CD, 0)
        Me.Controls.SetChildIndex(Me.grp担当者名, 0)
        Me.Controls.SetChildIndex(Me.grp売上日計表, 0)
        Me.Controls.SetChildIndex(Me.grpコーター通数, 0)
        Me.Controls.SetChildIndex(Me.grp開始見積NO, 0)
        Me.Controls.SetChildIndex(Me.grpコーター金額, 0)
        Me.grp処理区分.ResumeLayout(False)
        Me.grp処理区分.PerformLayout()
        Me.grp担当者CD.ResumeLayout(False)
        Me.grp担当者CD.PerformLayout()
        Me.grp売上日計表.ResumeLayout(False)
        Me.grp売上日計表.PerformLayout()
        Me.grpコーター通数.ResumeLayout(False)
        Me.grpコーター通数.PerformLayout()
        Me.grp担当者名.ResumeLayout(False)
        Me.grp担当者名.PerformLayout()
        Me.grpコーター金額.ResumeLayout(False)
        Me.grpコーター金額.PerformLayout()
        Me.grp開始見積NO.ResumeLayout(False)
        Me.grp開始見積NO.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp処理区分 As BaseUI.Control.GroupBox
    Friend WithEvents opt削除 As BaseUI.Control.RadioButton
    Friend WithEvents opt修正 As BaseUI.Control.RadioButton
    Friend WithEvents opt登録 As BaseUI.Control.RadioButton
    Friend WithEvents grp担当者CD As BaseUI.Control.GroupBox
    Friend WithEvents txt担当者CD As BaseUI.Control.TextBox
    Friend WithEvents grp売上日計表 As BaseUI.Control.GroupBox
    Friend WithEvents grpコーター通数 As BaseUI.Control.GroupBox
    Friend WithEvents txtコーター通数 As BaseUI.Control.TextBox
    Friend WithEvents grp担当者名 As BaseUI.Control.GroupBox
    Friend WithEvents txt担当者名 As BaseUI.Control.TextBox
    Friend WithEvents grpコーター金額 As BaseUI.Control.GroupBox
    Friend WithEvents txtコーター金額 As BaseUI.Control.TextBox
    Friend WithEvents chk売上日計表対象有無 As BaseUI.Control.CheckBox
    Friend WithEvents grp開始見積NO As BaseUI.Control.GroupBox
    Friend WithEvents txt開始見積 As BaseUI.Control.TextBox
End Class
