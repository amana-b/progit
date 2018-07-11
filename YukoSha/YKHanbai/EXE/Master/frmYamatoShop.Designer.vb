<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYamatoShop
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
        Me.grp店所名 = New BaseUI.Control.GroupBox()
        Me.txt店所名 = New BaseUI.Control.TextBox()
        Me.gｒｐ店所CD = New BaseUI.Control.GroupBox()
        Me.txt店所CD = New BaseUI.Control.TextBox()
        Me.grpTEL = New BaseUI.Control.GroupBox()
        Me.txtTEL = New BaseUI.Control.TextBox()
        Me.grp処理区分.SuspendLayout()
        Me.grp店所名.SuspendLayout()
        Me.gｒｐ店所CD.SuspendLayout()
        Me.grpTEL.SuspendLayout()
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
        'grp店所名
        '
        Me.grp店所名.Controls.Add(Me.txt店所名)
        Me.grp店所名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp店所名.Location = New System.Drawing.Point(29, 230)
        Me.grp店所名.Name = "grp店所名"
        Me.grp店所名.Size = New System.Drawing.Size(323, 61)
        Me.grp店所名.TabIndex = 2
        Me.grp店所名.TabStop = False
        Me.grp店所名.Text = "店所名"
        '
        'txt店所名
        '
        Me.txt店所名.FieldLockType = BaseContents.Field.LockType.None
        Me.txt店所名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt店所名.HelpKeys = ""
        Me.txt店所名.HelpLink = ""
        Me.txt店所名.HelpType = NodeUI.Help.Type.None
        Me.txt店所名.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt店所名.IsError = False
        Me.txt店所名.Location = New System.Drawing.Point(19, 25)
        Me.txt店所名.Name = "txt店所名"
        Me.txt店所名.Required = False
        Me.txt店所名.Size = New System.Drawing.Size(271, 23)
        Me.txt店所名.TabIndex = 0
        Me.txt店所名.Text = "ああああああああああいいいいいい"
        Me.txt店所名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'gｒｐ店所CD
        '
        Me.gｒｐ店所CD.Controls.Add(Me.txt店所CD)
        Me.gｒｐ店所CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.gｒｐ店所CD.Location = New System.Drawing.Point(29, 121)
        Me.gｒｐ店所CD.Name = "gｒｐ店所CD"
        Me.gｒｐ店所CD.Size = New System.Drawing.Size(113, 61)
        Me.gｒｐ店所CD.TabIndex = 1
        Me.gｒｐ店所CD.TabStop = False
        Me.gｒｐ店所CD.Text = "店所CD"
        '
        'txt店所CD
        '
        Me.txt店所CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt店所CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt店所CD.HelpKeys = ""
        Me.txt店所CD.HelpLink = ""
        Me.txt店所CD.HelpType = NodeUI.Help.Type.None
        Me.txt店所CD.IsError = False
        Me.txt店所CD.Location = New System.Drawing.Point(19, 24)
        Me.txt店所CD.Name = "txt店所CD"
        Me.txt店所CD.Required = False
        Me.txt店所CD.Size = New System.Drawing.Size(58, 23)
        Me.txt店所CD.TabIndex = 0
        Me.txt店所CD.Text = "123456"
        Me.txt店所CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grpTEL
        '
        Me.grpTEL.Controls.Add(Me.txtTEL)
        Me.grpTEL.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grpTEL.Location = New System.Drawing.Point(29, 342)
        Me.grpTEL.Name = "grpTEL"
        Me.grpTEL.Size = New System.Drawing.Size(178, 61)
        Me.grpTEL.TabIndex = 3
        Me.grpTEL.TabStop = False
        Me.grpTEL.Text = "TEL"
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
        Me.txtTEL.Size = New System.Drawing.Size(119, 23)
        Me.txtTEL.TabIndex = 0
        Me.txtTEL.Text = "000-0000-0000"
        Me.txtTEL.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'frmYamatoShop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.grpTEL)
        Me.Controls.Add(Me.gｒｐ店所CD)
        Me.Controls.Add(Me.grp店所名)
        Me.Controls.Add(Me.grp処理区分)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmYamatoShop"
        Me.Text = ""
        Me.Controls.SetChildIndex(Me.grp処理区分, 0)
        Me.Controls.SetChildIndex(Me.grp店所名, 0)
        Me.Controls.SetChildIndex(Me.gｒｐ店所CD, 0)
        Me.Controls.SetChildIndex(Me.grpTEL, 0)
        Me.grp処理区分.ResumeLayout(False)
        Me.grp処理区分.PerformLayout()
        Me.grp店所名.ResumeLayout(False)
        Me.grp店所名.PerformLayout()
        Me.gｒｐ店所CD.ResumeLayout(False)
        Me.gｒｐ店所CD.PerformLayout()
        Me.grpTEL.ResumeLayout(False)
        Me.grpTEL.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp処理区分 As BaseUI.Control.GroupBox
    Friend WithEvents opt削除 As BaseUI.Control.RadioButton
    Friend WithEvents opt修正 As BaseUI.Control.RadioButton
    Friend WithEvents opt登録 As BaseUI.Control.RadioButton
    Friend WithEvents grp店所名 As BaseUI.Control.GroupBox
    Friend WithEvents txt店所名 As BaseUI.Control.TextBox
    Friend WithEvents gｒｐ店所CD As BaseUI.Control.GroupBox
    Friend WithEvents txt店所CD As BaseUI.Control.TextBox
    Friend WithEvents grpTEL As BaseUI.Control.GroupBox
    Friend WithEvents txtTEL As BaseUI.Control.TextBox
End Class
