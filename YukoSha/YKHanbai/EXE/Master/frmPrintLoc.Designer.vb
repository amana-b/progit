<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintLoc
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
        Me.grp印刷場所CD = New BaseUI.Control.GroupBox()
        Me.txt印刷場所CD = New BaseUI.Control.TextBox()
        Me.grp印刷場所名 = New BaseUI.Control.GroupBox()
        Me.txt印刷場所名 = New BaseUI.Control.TextBox()
        Me.grp印刷機械種別 = New BaseUI.Control.GroupBox()
        Me.txt印刷機械種別CD = New BaseUI.Control.TextBox()
        Me.nam印刷機械種別名 = New BaseUI.Control.NameBox()
        Me.grp場所区分 = New BaseUI.Control.GroupBox()
        Me.ddl場所区分 = New BaseUI.Control.ComboBox()
        Me.grp処理区分.SuspendLayout()
        Me.grp印刷場所CD.SuspendLayout()
        Me.grp印刷場所名.SuspendLayout()
        Me.grp印刷機械種別.SuspendLayout()
        Me.grp場所区分.SuspendLayout()
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
        Me.grp処理区分.Location = New System.Drawing.Point(90, 22)
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
        'grp印刷場所CD
        '
        Me.grp印刷場所CD.Controls.Add(Me.txt印刷場所CD)
        Me.grp印刷場所CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp印刷場所CD.Location = New System.Drawing.Point(90, 108)
        Me.grp印刷場所CD.Name = "grp印刷場所CD"
        Me.grp印刷場所CD.Size = New System.Drawing.Size(111, 61)
        Me.grp印刷場所CD.TabIndex = 1
        Me.grp印刷場所CD.TabStop = False
        Me.grp印刷場所CD.Text = "印刷場所CD"
        '
        'txt印刷場所CD
        '
        Me.txt印刷場所CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt印刷場所CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt印刷場所CD.HelpKeys = ""
        Me.txt印刷場所CD.HelpLink = ""
        Me.txt印刷場所CD.HelpType = NodeUI.Help.Type.None
        Me.txt印刷場所CD.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt印刷場所CD.IsError = False
        Me.txt印刷場所CD.Location = New System.Drawing.Point(30, 25)
        Me.txt印刷場所CD.Name = "txt印刷場所CD"
        Me.txt印刷場所CD.Required = False
        Me.txt印刷場所CD.Size = New System.Drawing.Size(25, 23)
        Me.txt印刷場所CD.TabIndex = 0
        Me.txt印刷場所CD.Text = "99"
        Me.txt印刷場所CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp印刷場所名
        '
        Me.grp印刷場所名.Controls.Add(Me.txt印刷場所名)
        Me.grp印刷場所名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp印刷場所名.Location = New System.Drawing.Point(90, 194)
        Me.grp印刷場所名.Name = "grp印刷場所名"
        Me.grp印刷場所名.Size = New System.Drawing.Size(143, 61)
        Me.grp印刷場所名.TabIndex = 2
        Me.grp印刷場所名.TabStop = False
        Me.grp印刷場所名.Text = "印刷場所名"
        '
        'txt印刷場所名
        '
        Me.txt印刷場所名.FieldLockType = BaseContents.Field.LockType.None
        Me.txt印刷場所名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt印刷場所名.HelpKeys = ""
        Me.txt印刷場所名.HelpLink = ""
        Me.txt印刷場所名.HelpType = NodeUI.Help.Type.None
        Me.txt印刷場所名.IsError = False
        Me.txt印刷場所名.Location = New System.Drawing.Point(30, 25)
        Me.txt印刷場所名.Name = "txt印刷場所名"
        Me.txt印刷場所名.Required = False
        Me.txt印刷場所名.Size = New System.Drawing.Size(81, 23)
        Me.txt印刷場所名.TabIndex = 0
        Me.txt印刷場所名.Text = "テストテ"
        Me.txt印刷場所名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp印刷機械種別
        '
        Me.grp印刷機械種別.Controls.Add(Me.txt印刷機械種別CD)
        Me.grp印刷機械種別.Controls.Add(Me.nam印刷機械種別名)
        Me.grp印刷機械種別.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp印刷機械種別.Location = New System.Drawing.Point(90, 294)
        Me.grp印刷機械種別.Name = "grp印刷機械種別"
        Me.grp印刷機械種別.Size = New System.Drawing.Size(166, 61)
        Me.grp印刷機械種別.TabIndex = 9
        Me.grp印刷機械種別.TabStop = False
        Me.grp印刷機械種別.Text = "印刷機械種別"
        '
        'txt印刷機械種別CD
        '
        Me.txt印刷機械種別CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt印刷機械種別CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt印刷機械種別CD.HelpKeys = ""
        Me.txt印刷機械種別CD.HelpLink = ""
        Me.txt印刷機械種別CD.HelpType = NodeUI.Help.Type.None
        Me.txt印刷機械種別CD.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt印刷機械種別CD.IsError = False
        Me.txt印刷機械種別CD.Location = New System.Drawing.Point(30, 27)
        Me.txt印刷機械種別CD.Name = "txt印刷機械種別CD"
        Me.txt印刷機械種別CD.Required = False
        Me.txt印刷機械種別CD.Size = New System.Drawing.Size(25, 23)
        Me.txt印刷機械種別CD.TabIndex = 0
        Me.txt印刷機械種別CD.Text = "99"
        Me.txt印刷機械種別CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam印刷機械種別名
        '
        Me.nam印刷機械種別名.BackColor = System.Drawing.SystemColors.Control
        Me.nam印刷機械種別名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam印刷機械種別名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam印刷機械種別名.Location = New System.Drawing.Point(56, 27)
        Me.nam印刷機械種別名.Margin = New System.Windows.Forms.Padding(3)
        Me.nam印刷機械種別名.Name = "nam印刷機械種別名"
        Me.nam印刷機械種別名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.nam印刷機械種別名.Size = New System.Drawing.Size(92, 23)
        Me.nam印刷機械種別名.TabIndex = 13
        Me.nam印刷機械種別名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp場所区分
        '
        Me.grp場所区分.Controls.Add(Me.ddl場所区分)
        Me.grp場所区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp場所区分.Location = New System.Drawing.Point(90, 392)
        Me.grp場所区分.Name = "grp場所区分"
        Me.grp場所区分.Size = New System.Drawing.Size(224, 61)
        Me.grp場所区分.TabIndex = 12
        Me.grp場所区分.TabStop = False
        Me.grp場所区分.Text = "場所区分"
        '
        'ddl場所区分
        '
        Me.ddl場所区分.AutoDropDown = True
        Me.ddl場所区分.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddl場所区分.FieldLockType = BaseContents.Field.LockType.None
        Me.ddl場所区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.ddl場所区分.FormattingEnabled = True
        Me.ddl場所区分.IsError = False
        Me.ddl場所区分.ListType = NodeUI.List.Type.None
        Me.ddl場所区分.Location = New System.Drawing.Point(30, 23)
        Me.ddl場所区分.Name = "ddl場所区分"
        Me.ddl場所区分.Required = False
        Me.ddl場所区分.Size = New System.Drawing.Size(176, 24)
        Me.ddl場所区分.TabIndex = 0
        '
        'frmPrintLoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.grp場所区分)
        Me.Controls.Add(Me.grp印刷機械種別)
        Me.Controls.Add(Me.grp印刷場所名)
        Me.Controls.Add(Me.grp印刷場所CD)
        Me.Controls.Add(Me.grp処理区分)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmPrintLoc"
        Me.Text = ""
        Me.Controls.SetChildIndex(Me.grp処理区分, 0)
        Me.Controls.SetChildIndex(Me.grp印刷場所CD, 0)
        Me.Controls.SetChildIndex(Me.grp印刷場所名, 0)
        Me.Controls.SetChildIndex(Me.grp印刷機械種別, 0)
        Me.Controls.SetChildIndex(Me.grp場所区分, 0)
        Me.grp処理区分.ResumeLayout(False)
        Me.grp処理区分.PerformLayout()
        Me.grp印刷場所CD.ResumeLayout(False)
        Me.grp印刷場所CD.PerformLayout()
        Me.grp印刷場所名.ResumeLayout(False)
        Me.grp印刷場所名.PerformLayout()
        Me.grp印刷機械種別.ResumeLayout(False)
        Me.grp印刷機械種別.PerformLayout()
        Me.grp場所区分.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp処理区分 As BaseUI.Control.GroupBox
    Friend WithEvents opt削除 As BaseUI.Control.RadioButton
    Friend WithEvents opt修正 As BaseUI.Control.RadioButton
    Friend WithEvents opt登録 As BaseUI.Control.RadioButton
    Friend WithEvents grp印刷場所CD As BaseUI.Control.GroupBox
    Friend WithEvents txt印刷場所CD As BaseUI.Control.TextBox
    Friend WithEvents grp印刷場所名 As BaseUI.Control.GroupBox
    Friend WithEvents txt印刷場所名 As BaseUI.Control.TextBox
    Friend WithEvents grp印刷機械種別 As BaseUI.Control.GroupBox
    Friend WithEvents grp場所区分 As BaseUI.Control.GroupBox
    Friend WithEvents ddl場所区分 As BaseUI.Control.ComboBox
    Friend WithEvents nam印刷機械種別名 As BaseUI.Control.NameBox
    Friend WithEvents txt印刷機械種別CD As BaseUI.Control.TextBox

End Class
