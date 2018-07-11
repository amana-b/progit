<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmaaaOffSet
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
        Me.grp作業NO = New BaseUI.Control.GroupBox()
        Me.txt作業NO = New BaseUI.Control.TextBox()
        Me.grp受注情報 = New BaseUI.Control.GroupBox()
        Me.nam商品名 = New BaseUI.Control.NameBox()
        Me.nam得意先名 = New BaseUI.Control.NameBox()
        Me.nam商品名Title = New BaseUI.Control.NameBox()
        Me.nam得意先名Title = New BaseUI.Control.NameBox()
        Me.btn紙発注 = New BaseUI.Control.Button()
        Me.grp処理区分.SuspendLayout()
        Me.grp作業NO.SuspendLayout()
        Me.grp受注情報.SuspendLayout()
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
        'grp作業NO
        '
        Me.grp作業NO.Controls.Add(Me.txt作業NO)
        Me.grp作業NO.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp作業NO.Location = New System.Drawing.Point(337, 22)
        Me.grp作業NO.Name = "grp作業NO"
        Me.grp作業NO.Size = New System.Drawing.Size(96, 61)
        Me.grp作業NO.TabIndex = 1
        Me.grp作業NO.TabStop = False
        Me.grp作業NO.Text = "作業NO"
        '
        'txt作業NO
        '
        Me.txt作業NO.FieldLockType = BaseContents.Field.LockType.None
        Me.txt作業NO.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt作業NO.HelpKeys = ""
        Me.txt作業NO.HelpLink = ""
        Me.txt作業NO.HelpType = NodeUI.Help.Type.None
        Me.txt作業NO.IsError = False
        Me.txt作業NO.Location = New System.Drawing.Point(19, 25)
        Me.txt作業NO.Name = "txt作業NO"
        Me.txt作業NO.Required = False
        Me.txt作業NO.Size = New System.Drawing.Size(60, 23)
        Me.txt作業NO.TabIndex = 0
        Me.txt作業NO.Text = "XXXXXX"
        Me.txt作業NO.TextStyle = BaseContents.TextBox.TextStyle.Code
        '
        'grp受注情報
        '
        Me.grp受注情報.Controls.Add(Me.nam商品名)
        Me.grp受注情報.Controls.Add(Me.nam得意先名)
        Me.grp受注情報.Controls.Add(Me.nam商品名Title)
        Me.grp受注情報.Controls.Add(Me.nam得意先名Title)
        Me.grp受注情報.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp受注情報.Location = New System.Drawing.Point(29, 99)
        Me.grp受注情報.Name = "grp受注情報"
        Me.grp受注情報.Size = New System.Drawing.Size(902, 91)
        Me.grp受注情報.TabIndex = 2
        Me.grp受注情報.TabStop = False
        Me.grp受注情報.Text = "【受注情報】"
        '
        'nam商品名
        '
        Me.nam商品名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam商品名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam商品名.Location = New System.Drawing.Point(291, 52)
        Me.nam商品名.Name = "nam商品名"
        Me.nam商品名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam商品名.Size = New System.Drawing.Size(270, 23)
        Me.nam商品名.StringLength = 0
        Me.nam商品名.TabIndex = 9
        Me.nam商品名.Text = "*XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX*"
        Me.nam商品名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam得意先名
        '
        Me.nam得意先名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam得意先名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam得意先名.Location = New System.Drawing.Point(19, 52)
        Me.nam得意先名.Name = "nam得意先名"
        Me.nam得意先名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam得意先名.Size = New System.Drawing.Size(270, 23)
        Me.nam得意先名.StringLength = 0
        Me.nam得意先名.TabIndex = 3
        Me.nam得意先名.Text = "*XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX*"
        Me.nam得意先名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam商品名Title
        '
        Me.nam商品名Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam商品名Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam商品名Title.Location = New System.Drawing.Point(291, 27)
        Me.nam商品名Title.Name = "nam商品名Title"
        Me.nam商品名Title.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam商品名Title.Size = New System.Drawing.Size(270, 23)
        Me.nam商品名Title.StringLength = 0
        Me.nam商品名Title.TabIndex = 1
        Me.nam商品名Title.Text = "商　　　品　　　名"
        Me.nam商品名Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam商品名Title.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam得意先名Title
        '
        Me.nam得意先名Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam得意先名Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam得意先名Title.Location = New System.Drawing.Point(19, 27)
        Me.nam得意先名Title.Name = "nam得意先名Title"
        Me.nam得意先名Title.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam得意先名Title.Size = New System.Drawing.Size(270, 23)
        Me.nam得意先名Title.StringLength = 0
        Me.nam得意先名Title.TabIndex = 0
        Me.nam得意先名Title.Text = "得　　意　　先　　名"
        Me.nam得意先名Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam得意先名Title.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'btn紙発注
        '
        Me.btn紙発注.FieldLockType = BaseContents.Field.LockType.None
        Me.btn紙発注.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.btn紙発注.Location = New System.Drawing.Point(458, 346)
        Me.btn紙発注.Name = "btn紙発注"
        Me.btn紙発注.Size = New System.Drawing.Size(100, 48)
        Me.btn紙発注.TabIndex = 76
        Me.btn紙発注.Text = "紙発注情報画面へ進む"
        Me.btn紙発注.UseVisualStyleBackColor = True
        '
        'frmaaaOffSet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.btn紙発注)
        Me.Controls.Add(Me.grp受注情報)
        Me.Controls.Add(Me.grp作業NO)
        Me.Controls.Add(Me.grp処理区分)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmaaaOffSet"
        Me.Controls.SetChildIndex(Me.grp処理区分, 0)
        Me.Controls.SetChildIndex(Me.grp作業NO, 0)
        Me.Controls.SetChildIndex(Me.grp受注情報, 0)
        Me.Controls.SetChildIndex(Me.btn紙発注, 0)
        Me.grp処理区分.ResumeLayout(False)
        Me.grp処理区分.PerformLayout()
        Me.grp作業NO.ResumeLayout(False)
        Me.grp作業NO.PerformLayout()
        Me.grp受注情報.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp処理区分 As BaseUI.Control.GroupBox
    Friend WithEvents opt削除 As BaseUI.Control.RadioButton
    Friend WithEvents opt修正 As BaseUI.Control.RadioButton
    Friend WithEvents opt登録 As BaseUI.Control.RadioButton
    Friend WithEvents grp作業NO As BaseUI.Control.GroupBox
    Friend WithEvents txt作業NO As BaseUI.Control.TextBox
    Friend WithEvents grp受注情報 As BaseUI.Control.GroupBox
    Friend WithEvents nam得意先名Title As BaseUI.Control.NameBox
    Friend WithEvents nam商品名 As BaseUI.Control.NameBox
    Friend WithEvents nam得意先名 As BaseUI.Control.NameBox
    Friend WithEvents nam商品名Title As BaseUI.Control.NameBox
    Friend WithEvents btn紙発注 As BaseUI.Control.Button

End Class
