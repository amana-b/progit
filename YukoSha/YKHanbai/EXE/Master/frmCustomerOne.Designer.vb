<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerOne
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
        Me.grp得意先CD = New BaseUI.Control.GroupBox()
        Me.txt得意先CD = New BaseUI.Control.TextBox()
        Me.grp得意先名 = New BaseUI.Control.GroupBox()
        Me.txt得意先名 = New BaseUI.Control.TextBox()
        Me.grp住所 = New BaseUI.Control.GroupBox()
        Me.txt住所2 = New BaseUI.Control.TextBox()
        Me.txt住所1 = New BaseUI.Control.TextBox()
        Me.grpTEL = New BaseUI.Control.GroupBox()
        Me.txtTEL = New BaseUI.Control.TextBox()
        Me.txt郵便番号 = New BaseUI.Control.TextBox()
        Me.grp郵便番号 = New BaseUI.Control.GroupBox()
        Me.grpカナ名 = New BaseUI.Control.GroupBox()
        Me.txtカナ名 = New BaseUI.Control.TextBox()
        Me.grp役職_担当者名 = New BaseUI.Control.GroupBox()
        Me.txt役職_担当者名 = New BaseUI.Control.TextBox()
        Me.grp代表者役職_代表者名 = New BaseUI.Control.GroupBox()
        Me.txt代表者役職_代表者名 = New BaseUI.Control.TextBox()
        Me.grp処理区分.SuspendLayout()
        Me.grp得意先CD.SuspendLayout()
        Me.grp得意先名.SuspendLayout()
        Me.grp住所.SuspendLayout()
        Me.grpTEL.SuspendLayout()
        Me.grp郵便番号.SuspendLayout()
        Me.grpカナ名.SuspendLayout()
        Me.grp役職_担当者名.SuspendLayout()
        Me.grp代表者役職_代表者名.SuspendLayout()
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
        'grp得意先CD
        '
        Me.grp得意先CD.Controls.Add(Me.txt得意先CD)
        Me.grp得意先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp得意先CD.Location = New System.Drawing.Point(29, 103)
        Me.grp得意先CD.Name = "grp得意先CD"
        Me.grp得意先CD.Size = New System.Drawing.Size(104, 61)
        Me.grp得意先CD.TabIndex = 1
        Me.grp得意先CD.TabStop = False
        Me.grp得意先CD.Text = "得意先CD"
        '
        'txt得意先CD
        '
        Me.txt得意先CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt得意先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt得意先CD.HelpKeys = ""
        Me.txt得意先CD.HelpLink = ""
        Me.txt得意先CD.HelpType = NodeUI.Help.Type.None
        Me.txt得意先CD.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt得意先CD.IsError = False
        Me.txt得意先CD.Location = New System.Drawing.Point(19, 25)
        Me.txt得意先CD.Name = "txt得意先CD"
        Me.txt得意先CD.Required = False
        Me.txt得意先CD.Size = New System.Drawing.Size(61, 23)
        Me.txt得意先CD.TabIndex = 0
        Me.txt得意先CD.Text = "999999"
        Me.txt得意先CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp得意先名
        '
        Me.grp得意先名.Controls.Add(Me.txt得意先名)
        Me.grp得意先名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp得意先名.Location = New System.Drawing.Point(140, 103)
        Me.grp得意先名.Name = "grp得意先名"
        Me.grp得意先名.Size = New System.Drawing.Size(312, 61)
        Me.grp得意先名.TabIndex = 2
        Me.grp得意先名.TabStop = False
        Me.grp得意先名.Text = "得意先名"
        '
        'txt得意先名
        '
        Me.txt得意先名.FieldLockType = BaseContents.Field.LockType.None
        Me.txt得意先名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt得意先名.HelpKeys = ""
        Me.txt得意先名.HelpLink = ""
        Me.txt得意先名.HelpType = NodeUI.Help.Type.None
        Me.txt得意先名.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt得意先名.IsError = False
        Me.txt得意先名.Location = New System.Drawing.Point(19, 25)
        Me.txt得意先名.Name = "txt得意先名"
        Me.txt得意先名.Required = False
        Me.txt得意先名.Size = New System.Drawing.Size(264, 23)
        Me.txt得意先名.TabIndex = 0
        Me.txt得意先名.Text = "ああああああああああいいいいいい"
        Me.txt得意先名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp住所
        '
        Me.grp住所.Controls.Add(Me.txt住所2)
        Me.grp住所.Controls.Add(Me.txt住所1)
        Me.grp住所.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp住所.Location = New System.Drawing.Point(150, 183)
        Me.grp住所.Name = "grp住所"
        Me.grp住所.Size = New System.Drawing.Size(303, 85)
        Me.grp住所.TabIndex = 5
        Me.grp住所.TabStop = False
        Me.grp住所.Text = "住所"
        '
        'txt住所2
        '
        Me.txt住所2.FieldLockType = BaseContents.Field.LockType.None
        Me.txt住所2.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt住所2.HelpKeys = ""
        Me.txt住所2.HelpLink = ""
        Me.txt住所2.HelpType = NodeUI.Help.Type.None
        Me.txt住所2.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt住所2.IsError = False
        Me.txt住所2.Location = New System.Drawing.Point(19, 45)
        Me.txt住所2.Name = "txt住所2"
        Me.txt住所2.Required = False
        Me.txt住所2.Size = New System.Drawing.Size(264, 23)
        Me.txt住所2.TabIndex = 1
        Me.txt住所2.Text = "ああああああああああいいいいいい"
        Me.txt住所2.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt住所1
        '
        Me.txt住所1.FieldLockType = BaseContents.Field.LockType.None
        Me.txt住所1.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt住所1.HelpKeys = ""
        Me.txt住所1.HelpLink = ""
        Me.txt住所1.HelpType = NodeUI.Help.Type.None
        Me.txt住所1.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt住所1.IsError = False
        Me.txt住所1.Location = New System.Drawing.Point(19, 25)
        Me.txt住所1.Name = "txt住所1"
        Me.txt住所1.Required = False
        Me.txt住所1.Size = New System.Drawing.Size(264, 23)
        Me.txt住所1.TabIndex = 0
        Me.txt住所1.Text = "ああああああああああいいいいいい"
        Me.txt住所1.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grpTEL
        '
        Me.grpTEL.Controls.Add(Me.txtTEL)
        Me.grpTEL.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grpTEL.Location = New System.Drawing.Point(461, 183)
        Me.grpTEL.Name = "grpTEL"
        Me.grpTEL.Size = New System.Drawing.Size(152, 61)
        Me.grpTEL.TabIndex = 6
        Me.grpTEL.TabStop = False
        Me.grpTEL.Text = "ＴＥＬ"
        '
        'txtTEL
        '
        Me.txtTEL.FieldLockType = BaseContents.Field.LockType.None
        Me.txtTEL.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txtTEL.HelpKeys = ""
        Me.txtTEL.HelpLink = ""
        Me.txtTEL.HelpType = NodeUI.Help.Type.None
        Me.txtTEL.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtTEL.IsError = False
        Me.txtTEL.Location = New System.Drawing.Point(19, 25)
        Me.txtTEL.Name = "txtTEL"
        Me.txtTEL.Required = False
        Me.txtTEL.Size = New System.Drawing.Size(114, 23)
        Me.txtTEL.TabIndex = 0
        Me.txtTEL.Text = "999-9999-9999"
        Me.txtTEL.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt郵便番号
        '
        Me.txt郵便番号.FieldLockType = BaseContents.Field.LockType.None
        Me.txt郵便番号.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt郵便番号.HelpKeys = ""
        Me.txt郵便番号.HelpLink = ""
        Me.txt郵便番号.HelpType = NodeUI.Help.Type.None
        Me.txt郵便番号.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt郵便番号.IsError = False
        Me.txt郵便番号.Location = New System.Drawing.Point(19, 25)
        Me.txt郵便番号.Name = "txt郵便番号"
        Me.txt郵便番号.Required = False
        Me.txt郵便番号.Size = New System.Drawing.Size(79, 23)
        Me.txt郵便番号.TabIndex = 0
        Me.txt郵便番号.Text = "999-9999"
        Me.txt郵便番号.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp郵便番号
        '
        Me.grp郵便番号.Controls.Add(Me.txt郵便番号)
        Me.grp郵便番号.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp郵便番号.Location = New System.Drawing.Point(29, 183)
        Me.grp郵便番号.Name = "grp郵便番号"
        Me.grp郵便番号.Size = New System.Drawing.Size(115, 61)
        Me.grp郵便番号.TabIndex = 4
        Me.grp郵便番号.TabStop = False
        Me.grp郵便番号.Text = "郵便番号"
        '
        'grpカナ名
        '
        Me.grpカナ名.Controls.Add(Me.txtカナ名)
        Me.grpカナ名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grpカナ名.Location = New System.Drawing.Point(461, 103)
        Me.grpカナ名.Name = "grpカナ名"
        Me.grpカナ名.Size = New System.Drawing.Size(152, 61)
        Me.grpカナ名.TabIndex = 3
        Me.grpカナ名.TabStop = False
        Me.grpカナ名.Text = "カナ名"
        '
        'txtカナ名
        '
        Me.txtカナ名.FieldLockType = BaseContents.Field.LockType.None
        Me.txtカナ名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txtカナ名.HelpKeys = ""
        Me.txtカナ名.HelpLink = ""
        Me.txtカナ名.HelpType = NodeUI.Help.Type.None
        Me.txtカナ名.ImeMode = System.Windows.Forms.ImeMode.Katakana
        Me.txtカナ名.IsError = False
        Me.txtカナ名.Location = New System.Drawing.Point(19, 25)
        Me.txtカナ名.Name = "txtカナ名"
        Me.txtカナ名.Required = False
        Me.txtカナ名.Size = New System.Drawing.Size(90, 23)
        Me.txtカナ名.TabIndex = 0
        Me.txtカナ名.Text = "あああああ"
        Me.txtカナ名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp役職_担当者名
        '
        Me.grp役職_担当者名.Controls.Add(Me.txt役職_担当者名)
        Me.grp役職_担当者名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp役職_担当者名.Location = New System.Drawing.Point(29, 285)
        Me.grp役職_担当者名.Name = "grp役職_担当者名"
        Me.grp役職_担当者名.Size = New System.Drawing.Size(220, 61)
        Me.grp役職_担当者名.TabIndex = 7
        Me.grp役職_担当者名.TabStop = False
        Me.grp役職_担当者名.Text = "役職/担当者名"
        '
        'txt役職_担当者名
        '
        Me.txt役職_担当者名.FieldLockType = BaseContents.Field.LockType.None
        Me.txt役職_担当者名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt役職_担当者名.HelpKeys = ""
        Me.txt役職_担当者名.HelpLink = ""
        Me.txt役職_担当者名.HelpType = NodeUI.Help.Type.None
        Me.txt役職_担当者名.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt役職_担当者名.IsError = False
        Me.txt役職_担当者名.Location = New System.Drawing.Point(19, 25)
        Me.txt役職_担当者名.Name = "txt役職_担当者名"
        Me.txt役職_担当者名.Required = False
        Me.txt役職_担当者名.Size = New System.Drawing.Size(190, 23)
        Me.txt役職_担当者名.TabIndex = 0
        Me.txt役職_担当者名.Text = "ああああああああああい"
        Me.txt役職_担当者名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp代表者役職_代表者名
        '
        Me.grp代表者役職_代表者名.Controls.Add(Me.txt代表者役職_代表者名)
        Me.grp代表者役職_代表者名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp代表者役職_代表者名.Location = New System.Drawing.Point(260, 285)
        Me.grp代表者役職_代表者名.Name = "grp代表者役職_代表者名"
        Me.grp代表者役職_代表者名.Size = New System.Drawing.Size(312, 61)
        Me.grp代表者役職_代表者名.TabIndex = 8
        Me.grp代表者役職_代表者名.TabStop = False
        Me.grp代表者役職_代表者名.Text = "代表者役職/代表者名"
        '
        'txt代表者役職_代表者名
        '
        Me.txt代表者役職_代表者名.FieldLockType = BaseContents.Field.LockType.None
        Me.txt代表者役職_代表者名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt代表者役職_代表者名.HelpKeys = ""
        Me.txt代表者役職_代表者名.HelpLink = ""
        Me.txt代表者役職_代表者名.HelpType = NodeUI.Help.Type.None
        Me.txt代表者役職_代表者名.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt代表者役職_代表者名.IsError = False
        Me.txt代表者役職_代表者名.Location = New System.Drawing.Point(19, 25)
        Me.txt代表者役職_代表者名.Name = "txt代表者役職_代表者名"
        Me.txt代表者役職_代表者名.Required = False
        Me.txt代表者役職_代表者名.Size = New System.Drawing.Size(264, 23)
        Me.txt代表者役職_代表者名.TabIndex = 0
        Me.txt代表者役職_代表者名.Text = "ああああああああああいいいいいい"
        Me.txt代表者役職_代表者名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'frmCustomerOne
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.grp代表者役職_代表者名)
        Me.Controls.Add(Me.grp役職_担当者名)
        Me.Controls.Add(Me.grpカナ名)
        Me.Controls.Add(Me.grpTEL)
        Me.Controls.Add(Me.grp住所)
        Me.Controls.Add(Me.grp郵便番号)
        Me.Controls.Add(Me.grp得意先名)
        Me.Controls.Add(Me.grp得意先CD)
        Me.Controls.Add(Me.grp処理区分)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmCustomerOne"
        Me.Text = ""
        Me.Controls.SetChildIndex(Me.grp処理区分, 0)
        Me.Controls.SetChildIndex(Me.grp得意先CD, 0)
        Me.Controls.SetChildIndex(Me.grp得意先名, 0)
        Me.Controls.SetChildIndex(Me.grp郵便番号, 0)
        Me.Controls.SetChildIndex(Me.grp住所, 0)
        Me.Controls.SetChildIndex(Me.grpTEL, 0)
        Me.Controls.SetChildIndex(Me.grpカナ名, 0)
        Me.Controls.SetChildIndex(Me.grp役職_担当者名, 0)
        Me.Controls.SetChildIndex(Me.grp代表者役職_代表者名, 0)
        Me.grp処理区分.ResumeLayout(False)
        Me.grp処理区分.PerformLayout()
        Me.grp得意先CD.ResumeLayout(False)
        Me.grp得意先CD.PerformLayout()
        Me.grp得意先名.ResumeLayout(False)
        Me.grp得意先名.PerformLayout()
        Me.grp住所.ResumeLayout(False)
        Me.grp住所.PerformLayout()
        Me.grpTEL.ResumeLayout(False)
        Me.grpTEL.PerformLayout()
        Me.grp郵便番号.ResumeLayout(False)
        Me.grp郵便番号.PerformLayout()
        Me.grpカナ名.ResumeLayout(False)
        Me.grpカナ名.PerformLayout()
        Me.grp役職_担当者名.ResumeLayout(False)
        Me.grp役職_担当者名.PerformLayout()
        Me.grp代表者役職_代表者名.ResumeLayout(False)
        Me.grp代表者役職_代表者名.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp処理区分 As BaseUI.Control.GroupBox
    Friend WithEvents opt削除 As BaseUI.Control.RadioButton
    Friend WithEvents opt修正 As BaseUI.Control.RadioButton
    Friend WithEvents opt登録 As BaseUI.Control.RadioButton
    Friend WithEvents grp得意先CD As BaseUI.Control.GroupBox
    Friend WithEvents txt得意先CD As BaseUI.Control.TextBox
    Friend WithEvents grp得意先名 As BaseUI.Control.GroupBox
    Friend WithEvents txt得意先名 As BaseUI.Control.TextBox
    Friend WithEvents grp住所 As BaseUI.Control.GroupBox
    Friend WithEvents txt住所2 As BaseUI.Control.TextBox
    Friend WithEvents txt住所1 As BaseUI.Control.TextBox
    Friend WithEvents grpTEL As BaseUI.Control.GroupBox
    Friend WithEvents txtTEL As BaseUI.Control.TextBox
    Friend WithEvents txt郵便番号 As BaseUI.Control.TextBox
    Friend WithEvents grp郵便番号 As BaseUI.Control.GroupBox
    Friend WithEvents grpカナ名 As BaseUI.Control.GroupBox
    Friend WithEvents txtカナ名 As BaseUI.Control.TextBox
    Friend WithEvents grp役職_担当者名 As BaseUI.Control.GroupBox
    Friend WithEvents txt役職_担当者名 As BaseUI.Control.TextBox
    Friend WithEvents grp代表者役職_代表者名 As BaseUI.Control.GroupBox
    Friend WithEvents txt代表者役職_代表者名 As BaseUI.Control.TextBox
End Class
