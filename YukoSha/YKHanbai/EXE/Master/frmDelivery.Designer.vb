<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDelivery
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
        Me.grp得意先 = New BaseUI.Control.GroupBox()
        Me.nam得意先名 = New BaseUI.Control.NameBox()
        Me.txt得意先CD = New BaseUI.Control.TextBox()
        Me.grp出荷先CD = New BaseUI.Control.GroupBox()
        Me.txt出荷先CD = New BaseUI.Control.TextBox()
        Me.GroupBox1 = New BaseUI.Control.GroupBox()
        Me.txt出荷先名 = New BaseUI.Control.TextBox()
        Me.grp住所 = New BaseUI.Control.GroupBox()
        Me.txt住所2 = New BaseUI.Control.TextBox()
        Me.txt住所1 = New BaseUI.Control.TextBox()
        Me.grpTEL = New BaseUI.Control.GroupBox()
        Me.txtTEL = New BaseUI.Control.TextBox()
        Me.txt郵便番号 = New BaseUI.Control.TextBox()
        Me.grp郵便番号 = New BaseUI.Control.GroupBox()
        Me.grpFAX = New BaseUI.Control.GroupBox()
        Me.txtFAX = New BaseUI.Control.TextBox()
        Me.grp処理区分.SuspendLayout()
        Me.grp得意先.SuspendLayout()
        Me.grp出荷先CD.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grp住所.SuspendLayout()
        Me.grpTEL.SuspendLayout()
        Me.grp郵便番号.SuspendLayout()
        Me.grpFAX.SuspendLayout()
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
        'grp得意先
        '
        Me.grp得意先.Controls.Add(Me.nam得意先名)
        Me.grp得意先.Controls.Add(Me.txt得意先CD)
        Me.grp得意先.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp得意先.Location = New System.Drawing.Point(29, 108)
        Me.grp得意先.Name = "grp得意先"
        Me.grp得意先.Size = New System.Drawing.Size(361, 61)
        Me.grp得意先.TabIndex = 1
        Me.grp得意先.TabStop = False
        Me.grp得意先.Text = "得意先CD"
        '
        'nam得意先名
        '
        Me.nam得意先名.BackColor = System.Drawing.SystemColors.Control
        Me.nam得意先名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam得意先名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam得意先名.Location = New System.Drawing.Point(79, 24)
        Me.nam得意先名.Margin = New System.Windows.Forms.Padding(3)
        Me.nam得意先名.Name = "nam得意先名"
        Me.nam得意先名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.nam得意先名.Size = New System.Drawing.Size(260, 23)
        Me.nam得意先名.TabIndex = 9
        Me.nam得意先名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt得意先CD
        '
        Me.txt得意先CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt得意先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt得意先CD.HelpKeys = ""
        Me.txt得意先CD.HelpLink = ""
        Me.txt得意先CD.HelpType = NodeUI.Help.Type.None
        Me.txt得意先CD.IsError = False
        Me.txt得意先CD.Location = New System.Drawing.Point(19, 24)
        Me.txt得意先CD.Name = "txt得意先CD"
        Me.txt得意先CD.Required = False
        Me.txt得意先CD.Size = New System.Drawing.Size(61, 23)
        Me.txt得意先CD.TabIndex = 0
        Me.txt得意先CD.Text = "999999"
        Me.txt得意先CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp出荷先CD
        '
        Me.grp出荷先CD.Controls.Add(Me.txt出荷先CD)
        Me.grp出荷先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp出荷先CD.Location = New System.Drawing.Point(29, 193)
        Me.grp出荷先CD.Name = "grp出荷先CD"
        Me.grp出荷先CD.Size = New System.Drawing.Size(104, 61)
        Me.grp出荷先CD.TabIndex = 2
        Me.grp出荷先CD.TabStop = False
        Me.grp出荷先CD.Text = "出荷先CD"
        '
        'txt出荷先CD
        '
        Me.txt出荷先CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt出荷先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt出荷先CD.HelpKeys = ""
        Me.txt出荷先CD.HelpLink = ""
        Me.txt出荷先CD.HelpType = NodeUI.Help.Type.None
        Me.txt出荷先CD.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt出荷先CD.IsError = False
        Me.txt出荷先CD.Location = New System.Drawing.Point(19, 25)
        Me.txt出荷先CD.Name = "txt出荷先CD"
        Me.txt出荷先CD.Required = False
        Me.txt出荷先CD.Size = New System.Drawing.Size(38, 23)
        Me.txt出荷先CD.TabIndex = 0
        Me.txt出荷先CD.Text = "999"
        Me.txt出荷先CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt出荷先名)
        Me.GroupBox1.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(140, 193)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 61)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "出荷先名"
        '
        'txt出荷先名
        '
        Me.txt出荷先名.FieldLockType = BaseContents.Field.LockType.None
        Me.txt出荷先名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt出荷先名.HelpKeys = ""
        Me.txt出荷先名.HelpLink = ""
        Me.txt出荷先名.HelpType = NodeUI.Help.Type.None
        Me.txt出荷先名.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt出荷先名.IsError = False
        Me.txt出荷先名.Location = New System.Drawing.Point(19, 25)
        Me.txt出荷先名.Name = "txt出荷先名"
        Me.txt出荷先名.Required = False
        Me.txt出荷先名.Size = New System.Drawing.Size(264, 23)
        Me.txt出荷先名.TabIndex = 0
        Me.txt出荷先名.Text = "ああああああああああいいいいいい"
        Me.txt出荷先名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp住所
        '
        Me.grp住所.Controls.Add(Me.txt住所2)
        Me.grp住所.Controls.Add(Me.txt住所1)
        Me.grp住所.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp住所.Location = New System.Drawing.Point(29, 365)
        Me.grp住所.Name = "grp住所"
        Me.grp住所.Size = New System.Drawing.Size(312, 85)
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
        Me.grpTEL.Location = New System.Drawing.Point(29, 477)
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
        Me.grp郵便番号.Location = New System.Drawing.Point(29, 278)
        Me.grp郵便番号.Name = "grp郵便番号"
        Me.grp郵便番号.Size = New System.Drawing.Size(115, 61)
        Me.grp郵便番号.TabIndex = 4
        Me.grp郵便番号.TabStop = False
        Me.grp郵便番号.Text = "郵便番号"
        '
        'grpFAX
        '
        Me.grpFAX.Controls.Add(Me.txtFAX)
        Me.grpFAX.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grpFAX.Location = New System.Drawing.Point(189, 477)
        Me.grpFAX.Name = "grpFAX"
        Me.grpFAX.Size = New System.Drawing.Size(152, 61)
        Me.grpFAX.TabIndex = 7
        Me.grpFAX.TabStop = False
        Me.grpFAX.Text = "ＦＡＸ"
        '
        'txtFAX
        '
        Me.txtFAX.FieldLockType = BaseContents.Field.LockType.None
        Me.txtFAX.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txtFAX.HelpKeys = ""
        Me.txtFAX.HelpLink = ""
        Me.txtFAX.HelpType = NodeUI.Help.Type.None
        Me.txtFAX.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtFAX.IsError = False
        Me.txtFAX.Location = New System.Drawing.Point(19, 25)
        Me.txtFAX.Name = "txtFAX"
        Me.txtFAX.Required = False
        Me.txtFAX.Size = New System.Drawing.Size(114, 23)
        Me.txtFAX.TabIndex = 0
        Me.txtFAX.Text = "999-9999-9999"
        Me.txtFAX.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'frmDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.grpFAX)
        Me.Controls.Add(Me.grpTEL)
        Me.Controls.Add(Me.grp住所)
        Me.Controls.Add(Me.grp郵便番号)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grp出荷先CD)
        Me.Controls.Add(Me.grp得意先)
        Me.Controls.Add(Me.grp処理区分)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmDelivery"
        Me.Text = ""
        Me.Controls.SetChildIndex(Me.grp処理区分, 0)
        Me.Controls.SetChildIndex(Me.grp得意先, 0)
        Me.Controls.SetChildIndex(Me.grp出荷先CD, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.grp郵便番号, 0)
        Me.Controls.SetChildIndex(Me.grp住所, 0)
        Me.Controls.SetChildIndex(Me.grpTEL, 0)
        Me.Controls.SetChildIndex(Me.grpFAX, 0)
        Me.grp処理区分.ResumeLayout(False)
        Me.grp処理区分.PerformLayout()
        Me.grp得意先.ResumeLayout(False)
        Me.grp得意先.PerformLayout()
        Me.grp出荷先CD.ResumeLayout(False)
        Me.grp出荷先CD.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grp住所.ResumeLayout(False)
        Me.grp住所.PerformLayout()
        Me.grpTEL.ResumeLayout(False)
        Me.grpTEL.PerformLayout()
        Me.grp郵便番号.ResumeLayout(False)
        Me.grp郵便番号.PerformLayout()
        Me.grpFAX.ResumeLayout(False)
        Me.grpFAX.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp処理区分 As BaseUI.Control.GroupBox
    Friend WithEvents opt削除 As BaseUI.Control.RadioButton
    Friend WithEvents opt修正 As BaseUI.Control.RadioButton
    Friend WithEvents opt登録 As BaseUI.Control.RadioButton
    Friend WithEvents grp得意先 As BaseUI.Control.GroupBox
    Friend WithEvents grp出荷先CD As BaseUI.Control.GroupBox
    Friend WithEvents txt出荷先CD As BaseUI.Control.TextBox
    Friend WithEvents txt得意先CD As BaseUI.Control.TextBox
    Friend WithEvents GroupBox1 As BaseUI.Control.GroupBox
    Friend WithEvents txt出荷先名 As BaseUI.Control.TextBox
    Friend WithEvents grp住所 As BaseUI.Control.GroupBox
    Friend WithEvents txt住所2 As BaseUI.Control.TextBox
    Friend WithEvents txt住所1 As BaseUI.Control.TextBox
    Friend WithEvents grpTEL As BaseUI.Control.GroupBox
    Friend WithEvents txtTEL As BaseUI.Control.TextBox
    Friend WithEvents txt郵便番号 As BaseUI.Control.TextBox
    Friend WithEvents grp郵便番号 As BaseUI.Control.GroupBox
    Friend WithEvents grpFAX As BaseUI.Control.GroupBox
    Friend WithEvents txtFAX As BaseUI.Control.TextBox
    Friend WithEvents nam得意先名 As BaseUI.Control.NameBox
End Class
