<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYamatoKind
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
        Me.grpヤマト種別 = New BaseUI.Control.GroupBox()
        Me.txtヤマト種別 = New BaseUI.Control.TextBox()
        Me.grpヤマト種別名 = New BaseUI.Control.GroupBox()
        Me.txtヤマト種別名 = New BaseUI.Control.TextBox()
        Me.grp品名CD = New BaseUI.Control.GroupBox()
        Me.nam品名 = New BaseUI.Control.NameBox()
        Me.txt品名CD = New BaseUI.Control.TextBox()
        Me.grpヤマト区分 = New BaseUI.Control.GroupBox()
        Me.namヤマト区分名 = New BaseUI.Control.NameBox()
        Me.txtヤマト区分 = New BaseUI.Control.TextBox()
        Me.grp処理区分.SuspendLayout()
        Me.grpヤマト種別.SuspendLayout()
        Me.grpヤマト種別名.SuspendLayout()
        Me.grp品名CD.SuspendLayout()
        Me.grpヤマト区分.SuspendLayout()
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
        'grpヤマト種別
        '
        Me.grpヤマト種別.Controls.Add(Me.txtヤマト種別)
        Me.grpヤマト種別.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grpヤマト種別.Location = New System.Drawing.Point(29, 227)
        Me.grpヤマト種別.Name = "grpヤマト種別"
        Me.grpヤマト種別.Size = New System.Drawing.Size(90, 61)
        Me.grpヤマト種別.TabIndex = 2
        Me.grpヤマト種別.TabStop = False
        Me.grpヤマト種別.Text = "種別区分"
        '
        'txtヤマト種別
        '
        Me.txtヤマト種別.FieldLockType = BaseContents.Field.LockType.None
        Me.txtヤマト種別.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txtヤマト種別.HelpKeys = ""
        Me.txtヤマト種別.HelpLink = ""
        Me.txtヤマト種別.HelpType = NodeUI.Help.Type.None
        Me.txtヤマト種別.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtヤマト種別.IsError = False
        Me.txtヤマト種別.Location = New System.Drawing.Point(19, 25)
        Me.txtヤマト種別.Name = "txtヤマト種別"
        Me.txtヤマト種別.Required = False
        Me.txtヤマト種別.Size = New System.Drawing.Size(22, 23)
        Me.txtヤマト種別.TabIndex = 0
        Me.txtヤマト種別.Text = "1"
        Me.txtヤマト種別.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grpヤマト種別名
        '
        Me.grpヤマト種別名.Controls.Add(Me.txtヤマト種別名)
        Me.grpヤマト種別名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grpヤマト種別名.Location = New System.Drawing.Point(160, 227)
        Me.grpヤマト種別名.Name = "grpヤマト種別名"
        Me.grpヤマト種別名.Size = New System.Drawing.Size(110, 61)
        Me.grpヤマト種別名.TabIndex = 3
        Me.grpヤマト種別名.TabStop = False
        Me.grpヤマト種別名.Text = "種別区分名"
        '
        'txtヤマト種別名
        '
        Me.txtヤマト種別名.FieldLockType = BaseContents.Field.LockType.None
        Me.txtヤマト種別名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txtヤマト種別名.HelpKeys = ""
        Me.txtヤマト種別名.HelpLink = ""
        Me.txtヤマト種別名.HelpType = NodeUI.Help.Type.None
        Me.txtヤマト種別名.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtヤマト種別名.IsError = False
        Me.txtヤマト種別名.Location = New System.Drawing.Point(19, 25)
        Me.txtヤマト種別名.Name = "txtヤマト種別名"
        Me.txtヤマト種別名.Required = False
        Me.txtヤマト種別名.Size = New System.Drawing.Size(39, 23)
        Me.txtヤマト種別名.TabIndex = 0
        Me.txtヤマト種別名.Text = "ああ"
        Me.txtヤマト種別名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp品名CD
        '
        Me.grp品名CD.Controls.Add(Me.nam品名)
        Me.grp品名CD.Controls.Add(Me.txt品名CD)
        Me.grp品名CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp品名CD.Location = New System.Drawing.Point(29, 347)
        Me.grp品名CD.Name = "grp品名CD"
        Me.grp品名CD.Size = New System.Drawing.Size(421, 61)
        Me.grp品名CD.TabIndex = 4
        Me.grp品名CD.TabStop = False
        Me.grp品名CD.Text = "品名CD"
        '
        'nam品名
        '
        Me.nam品名.BackColor = System.Drawing.SystemColors.Control
        Me.nam品名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam品名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam品名.Location = New System.Drawing.Point(132, 24)
        Me.nam品名.Margin = New System.Windows.Forms.Padding(3)
        Me.nam品名.Name = "nam品名"
        Me.nam品名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.nam品名.Size = New System.Drawing.Size(264, 23)
        Me.nam品名.TabIndex = 1
        Me.nam品名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt品名CD
        '
        Me.txt品名CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt品名CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt品名CD.HelpKeys = ""
        Me.txt品名CD.HelpLink = ""
        Me.txt品名CD.HelpType = NodeUI.Help.Type.None
        Me.txt品名CD.IsError = False
        Me.txt品名CD.Location = New System.Drawing.Point(19, 24)
        Me.txt品名CD.Name = "txt品名CD"
        Me.txt品名CD.Required = False
        Me.txt品名CD.Size = New System.Drawing.Size(113, 23)
        Me.txt品名CD.TabIndex = 0
        Me.txt品名CD.Text = "1234567890123"
        Me.txt品名CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grpヤマト区分
        '
        Me.grpヤマト区分.Controls.Add(Me.namヤマト区分名)
        Me.grpヤマト区分.Controls.Add(Me.txtヤマト区分)
        Me.grpヤマト区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grpヤマト区分.Location = New System.Drawing.Point(29, 121)
        Me.grpヤマト区分.Name = "grpヤマト区分"
        Me.grpヤマト区分.Size = New System.Drawing.Size(267, 61)
        Me.grpヤマト区分.TabIndex = 1
        Me.grpヤマト区分.TabStop = False
        Me.grpヤマト区分.Text = "ﾃﾞｰﾀ区分"
        '
        'namヤマト区分名
        '
        Me.namヤマト区分名.BackColor = System.Drawing.SystemColors.Control
        Me.namヤマト区分名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.namヤマト区分名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.namヤマト区分名.Location = New System.Drawing.Point(45, 24)
        Me.namヤマト区分名.Margin = New System.Windows.Forms.Padding(3)
        Me.namヤマト区分名.Name = "namヤマト区分名"
        Me.namヤマト区分名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.namヤマト区分名.Size = New System.Drawing.Size(196, 23)
        Me.namヤマト区分名.TabIndex = 1
        Me.namヤマト区分名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txtヤマト区分
        '
        Me.txtヤマト区分.FieldLockType = BaseContents.Field.LockType.None
        Me.txtヤマト区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txtヤマト区分.HelpKeys = ""
        Me.txtヤマト区分.HelpLink = ""
        Me.txtヤマト区分.HelpType = NodeUI.Help.Type.None
        Me.txtヤマト区分.IsError = False
        Me.txtヤマト区分.Location = New System.Drawing.Point(19, 24)
        Me.txtヤマト区分.Name = "txtヤマト区分"
        Me.txtヤマト区分.Required = False
        Me.txtヤマト区分.Size = New System.Drawing.Size(26, 23)
        Me.txtヤマト区分.TabIndex = 0
        Me.txtヤマト区分.Text = "12"
        Me.txtヤマト区分.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'frmYamatoKind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.grpヤマト区分)
        Me.Controls.Add(Me.grp品名CD)
        Me.Controls.Add(Me.grpヤマト種別名)
        Me.Controls.Add(Me.grpヤマト種別)
        Me.Controls.Add(Me.grp処理区分)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmYamatoKind"
        Me.Text = ""
        Me.Controls.SetChildIndex(Me.grp処理区分, 0)
        Me.Controls.SetChildIndex(Me.grpヤマト種別, 0)
        Me.Controls.SetChildIndex(Me.grpヤマト種別名, 0)
        Me.Controls.SetChildIndex(Me.grp品名CD, 0)
        Me.Controls.SetChildIndex(Me.grpヤマト区分, 0)
        Me.grp処理区分.ResumeLayout(False)
        Me.grp処理区分.PerformLayout()
        Me.grpヤマト種別.ResumeLayout(False)
        Me.grpヤマト種別.PerformLayout()
        Me.grpヤマト種別名.ResumeLayout(False)
        Me.grpヤマト種別名.PerformLayout()
        Me.grp品名CD.ResumeLayout(False)
        Me.grp品名CD.PerformLayout()
        Me.grpヤマト区分.ResumeLayout(False)
        Me.grpヤマト区分.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp処理区分 As BaseUI.Control.GroupBox
    Friend WithEvents opt削除 As BaseUI.Control.RadioButton
    Friend WithEvents opt修正 As BaseUI.Control.RadioButton
    Friend WithEvents opt登録 As BaseUI.Control.RadioButton
    Friend WithEvents grpヤマト種別 As BaseUI.Control.GroupBox
    Friend WithEvents txtヤマト種別 As BaseUI.Control.TextBox
    Friend WithEvents grpヤマト種別名 As BaseUI.Control.GroupBox
    Friend WithEvents txtヤマト種別名 As BaseUI.Control.TextBox
    Friend WithEvents grp品名CD As BaseUI.Control.GroupBox
    Friend WithEvents nam品名 As BaseUI.Control.NameBox
    Friend WithEvents txt品名CD As BaseUI.Control.TextBox
    Friend WithEvents grpヤマト区分 As BaseUI.Control.GroupBox
    Friend WithEvents namヤマト区分名 As BaseUI.Control.NameBox
    Friend WithEvents txtヤマト区分 As BaseUI.Control.TextBox
End Class
