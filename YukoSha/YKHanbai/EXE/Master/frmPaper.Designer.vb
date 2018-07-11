<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaper
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
        Me.grp紙CD = New BaseUI.Control.GroupBox()
        Me.txt紙CD = New BaseUI.Control.TextBox()
        Me.grp紙種別区分 = New BaseUI.Control.GroupBox()
        Me.ddl紙種別区分 = New BaseUI.Control.ComboBox()
        Me.grp紙名 = New BaseUI.Control.GroupBox()
        Me.txt紙名 = New BaseUI.Control.TextBox()
        Me.grp処理区分.SuspendLayout()
        Me.grp紙CD.SuspendLayout()
        Me.grp紙種別区分.SuspendLayout()
        Me.grp紙名.SuspendLayout()
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
        'grp紙CD
        '
        Me.grp紙CD.Controls.Add(Me.txt紙CD)
        Me.grp紙CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp紙CD.Location = New System.Drawing.Point(29, 108)
        Me.grp紙CD.Name = "grp紙CD"
        Me.grp紙CD.Size = New System.Drawing.Size(89, 61)
        Me.grp紙CD.TabIndex = 1
        Me.grp紙CD.TabStop = False
        Me.grp紙CD.Text = "紙CD"
        '
        'txt紙CD
        '
        Me.txt紙CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt紙CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt紙CD.HelpKeys = ""
        Me.txt紙CD.HelpLink = ""
        Me.txt紙CD.HelpType = NodeUI.Help.Type.None
        Me.txt紙CD.IsError = False
        Me.txt紙CD.Location = New System.Drawing.Point(19, 25)
        Me.txt紙CD.Name = "txt紙CD"
        Me.txt紙CD.Required = False
        Me.txt紙CD.Size = New System.Drawing.Size(38, 23)
        Me.txt紙CD.TabIndex = 0
        Me.txt紙CD.Text = "999"
        Me.txt紙CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp紙種別区分
        '
        Me.grp紙種別区分.Controls.Add(Me.ddl紙種別区分)
        Me.grp紙種別区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp紙種別区分.Location = New System.Drawing.Point(29, 283)
        Me.grp紙種別区分.Name = "grp紙種別区分"
        Me.grp紙種別区分.Size = New System.Drawing.Size(143, 61)
        Me.grp紙種別区分.TabIndex = 3
        Me.grp紙種別区分.TabStop = False
        Me.grp紙種別区分.Text = "紙種別区分"
        '
        'ddl紙種別区分
        '
        Me.ddl紙種別区分.AutoDropDown = True
        Me.ddl紙種別区分.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddl紙種別区分.FieldLockType = BaseContents.Field.LockType.None
        Me.ddl紙種別区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.ddl紙種別区分.FormattingEnabled = True
        Me.ddl紙種別区分.IsError = False
        Me.ddl紙種別区分.ListType = NodeUI.List.Type.None
        Me.ddl紙種別区分.Location = New System.Drawing.Point(19, 23)
        Me.ddl紙種別区分.Name = "ddl紙種別区分"
        Me.ddl紙種別区分.Required = False
        Me.ddl紙種別区分.Size = New System.Drawing.Size(121, 24)
        Me.ddl紙種別区分.TabIndex = 0
        '
        'grp紙名
        '
        Me.grp紙名.Controls.Add(Me.txt紙名)
        Me.grp紙名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp紙名.Location = New System.Drawing.Point(29, 196)
        Me.grp紙名.Name = "grp紙名"
        Me.grp紙名.Size = New System.Drawing.Size(143, 61)
        Me.grp紙名.TabIndex = 2
        Me.grp紙名.TabStop = False
        Me.grp紙名.Text = "紙名"
        '
        'txt紙名
        '
        Me.txt紙名.FieldLockType = BaseContents.Field.LockType.None
        Me.txt紙名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt紙名.HelpKeys = ""
        Me.txt紙名.HelpLink = ""
        Me.txt紙名.HelpType = NodeUI.Help.Type.None
        Me.txt紙名.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt紙名.IsError = False
        Me.txt紙名.Location = New System.Drawing.Point(19, 25)
        Me.txt紙名.Name = "txt紙名"
        Me.txt紙名.Required = False
        Me.txt紙名.Size = New System.Drawing.Size(105, 23)
        Me.txt紙名.TabIndex = 0
        Me.txt紙名.Text = "あああああい"
        Me.txt紙名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'frmPaper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.grp紙名)
        Me.Controls.Add(Me.grp紙種別区分)
        Me.Controls.Add(Me.grp紙CD)
        Me.Controls.Add(Me.grp処理区分)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmPaper"
        Me.Text = ""
        Me.Controls.SetChildIndex(Me.grp処理区分, 0)
        Me.Controls.SetChildIndex(Me.grp紙CD, 0)
        Me.Controls.SetChildIndex(Me.grp紙種別区分, 0)
        Me.Controls.SetChildIndex(Me.grp紙名, 0)
        Me.grp処理区分.ResumeLayout(False)
        Me.grp処理区分.PerformLayout()
        Me.grp紙CD.ResumeLayout(False)
        Me.grp紙CD.PerformLayout()
        Me.grp紙種別区分.ResumeLayout(False)
        Me.grp紙名.ResumeLayout(False)
        Me.grp紙名.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp処理区分 As BaseUI.Control.GroupBox
    Friend WithEvents opt削除 As BaseUI.Control.RadioButton
    Friend WithEvents opt修正 As BaseUI.Control.RadioButton
    Friend WithEvents opt登録 As BaseUI.Control.RadioButton
    Friend WithEvents grp紙CD As BaseUI.Control.GroupBox
    Friend WithEvents txt紙CD As BaseUI.Control.TextBox
    Friend WithEvents grp紙種別区分 As BaseUI.Control.GroupBox
    Friend WithEvents ddl紙種別区分 As BaseUI.Control.ComboBox
    Friend WithEvents grp紙名 As BaseUI.Control.GroupBox
    Friend WithEvents txt紙名 As BaseUI.Control.TextBox
End Class
