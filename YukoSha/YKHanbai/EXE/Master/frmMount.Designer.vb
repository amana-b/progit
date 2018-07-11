<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMount
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
        Me.grp糊CD = New BaseUI.Control.GroupBox()
        Me.txt台紙CD = New BaseUI.Control.TextBox()
        Me.grp糊名 = New BaseUI.Control.GroupBox()
        Me.txt台紙名 = New BaseUI.Control.TextBox()
        Me.grp再利用区分 = New BaseUI.Control.GroupBox()
        Me.ddl再利用区分 = New BaseUI.Control.ComboBox()
        Me.grp処理区分.SuspendLayout()
        Me.grp糊CD.SuspendLayout()
        Me.grp糊名.SuspendLayout()
        Me.grp再利用区分.SuspendLayout()
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
        Me.opt修正.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
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
        'grp糊CD
        '
        Me.grp糊CD.Controls.Add(Me.txt台紙CD)
        Me.grp糊CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp糊CD.Location = New System.Drawing.Point(29, 108)
        Me.grp糊CD.Name = "grp糊CD"
        Me.grp糊CD.Size = New System.Drawing.Size(89, 61)
        Me.grp糊CD.TabIndex = 1
        Me.grp糊CD.TabStop = False
        Me.grp糊CD.Text = "台紙CD"
        '
        'txt台紙CD
        '
        Me.txt台紙CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt台紙CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt台紙CD.HelpKeys = ""
        Me.txt台紙CD.HelpLink = ""
        Me.txt台紙CD.HelpType = NodeUI.Help.Type.None
        Me.txt台紙CD.IsError = False
        Me.txt台紙CD.Location = New System.Drawing.Point(19, 25)
        Me.txt台紙CD.Name = "txt台紙CD"
        Me.txt台紙CD.Required = False
        Me.txt台紙CD.Size = New System.Drawing.Size(23, 23)
        Me.txt台紙CD.TabIndex = 0
        Me.txt台紙CD.Text = "99"
        Me.txt台紙CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp糊名
        '
        Me.grp糊名.Controls.Add(Me.txt台紙名)
        Me.grp糊名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp糊名.Location = New System.Drawing.Point(29, 196)
        Me.grp糊名.Name = "grp糊名"
        Me.grp糊名.Size = New System.Drawing.Size(143, 61)
        Me.grp糊名.TabIndex = 2
        Me.grp糊名.TabStop = False
        Me.grp糊名.Text = "台紙名"
        '
        'txt台紙名
        '
        Me.txt台紙名.FieldLockType = BaseContents.Field.LockType.None
        Me.txt台紙名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt台紙名.HelpKeys = ""
        Me.txt台紙名.HelpLink = ""
        Me.txt台紙名.HelpType = NodeUI.Help.Type.None
        Me.txt台紙名.IsError = False
        Me.txt台紙名.Location = New System.Drawing.Point(19, 25)
        Me.txt台紙名.Name = "txt台紙名"
        Me.txt台紙名.Required = False
        Me.txt台紙名.Size = New System.Drawing.Size(105, 23)
        Me.txt台紙名.TabIndex = 0
        Me.txt台紙名.Text = "あああああい"
        Me.txt台紙名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp再利用区分
        '
        Me.grp再利用区分.Controls.Add(Me.ddl再利用区分)
        Me.grp再利用区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp再利用区分.Location = New System.Drawing.Point(29, 283)
        Me.grp再利用区分.Name = "grp再利用区分"
        Me.grp再利用区分.Size = New System.Drawing.Size(215, 61)
        Me.grp再利用区分.TabIndex = 3
        Me.grp再利用区分.TabStop = False
        Me.grp再利用区分.Text = "再利用区分"
        '
        'ddl再利用区分
        '
        Me.ddl再利用区分.AutoDropDown = True
        Me.ddl再利用区分.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddl再利用区分.FieldLockType = BaseContents.Field.LockType.None
        Me.ddl再利用区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.ddl再利用区分.FormattingEnabled = True
        Me.ddl再利用区分.IsError = False
        Me.ddl再利用区分.ListType = NodeUI.List.Type.None
        Me.ddl再利用区分.Location = New System.Drawing.Point(19, 23)
        Me.ddl再利用区分.Name = "ddl再利用区分"
        Me.ddl再利用区分.Required = False
        Me.ddl再利用区分.Size = New System.Drawing.Size(180, 24)
        Me.ddl再利用区分.TabIndex = 0
        '
        'frmMount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.grp再利用区分)
        Me.Controls.Add(Me.grp糊名)
        Me.Controls.Add(Me.grp糊CD)
        Me.Controls.Add(Me.grp処理区分)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmMount"
        Me.Text = ""
        Me.Controls.SetChildIndex(Me.grp処理区分, 0)
        Me.Controls.SetChildIndex(Me.grp糊CD, 0)
        Me.Controls.SetChildIndex(Me.grp糊名, 0)
        Me.Controls.SetChildIndex(Me.grp再利用区分, 0)
        Me.grp処理区分.ResumeLayout(False)
        Me.grp処理区分.PerformLayout()
        Me.grp糊CD.ResumeLayout(False)
        Me.grp糊CD.PerformLayout()
        Me.grp糊名.ResumeLayout(False)
        Me.grp糊名.PerformLayout()
        Me.grp再利用区分.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp処理区分 As BaseUI.Control.GroupBox
    Friend WithEvents opt削除 As BaseUI.Control.RadioButton
    Friend WithEvents opt修正 As BaseUI.Control.RadioButton
    Friend WithEvents opt登録 As BaseUI.Control.RadioButton
    Friend WithEvents grp糊CD As BaseUI.Control.GroupBox
    Friend WithEvents txt台紙CD As BaseUI.Control.TextBox
    Friend WithEvents grp糊名 As BaseUI.Control.GroupBox
    Friend WithEvents txt台紙名 As BaseUI.Control.TextBox
    Friend WithEvents grp再利用区分 As BaseUI.Control.GroupBox
    Friend WithEvents ddl再利用区分 As BaseUI.Control.ComboBox

End Class
