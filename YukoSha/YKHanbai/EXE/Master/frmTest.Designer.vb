<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTest
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
        Me.grpテストCD = New BaseUI.Control.GroupBox()
        Me.txtテストCD = New BaseUI.Control.TextBox()
        Me.grpテスト名 = New BaseUI.Control.GroupBox()
        Me.txtテスト名 = New BaseUI.Control.TextBox()
        Me.grp処理区分.SuspendLayout()
        Me.grpテストCD.SuspendLayout()
        Me.grpテスト名.SuspendLayout()
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
        'grpテストCD
        '
        Me.grpテストCD.Controls.Add(Me.txtテストCD)
        Me.grpテストCD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grpテストCD.Location = New System.Drawing.Point(29, 108)
        Me.grpテストCD.Name = "grpテストCD"
        Me.grpテストCD.Size = New System.Drawing.Size(89, 61)
        Me.grpテストCD.TabIndex = 1
        Me.grpテストCD.TabStop = False
        Me.grpテストCD.Text = "テストCD"
        '
        'txtテストCD
        '
        Me.txtテストCD.FieldLockType = BaseContents.Field.LockType.None
        Me.txtテストCD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txtテストCD.HelpKeys = ""
        Me.txtテストCD.HelpLink = ""
        Me.txtテストCD.HelpType = NodeUI.Help.Type.None
        Me.txtテストCD.IsError = False
        Me.txtテストCD.Location = New System.Drawing.Point(19, 25)
        Me.txtテストCD.Name = "txtテストCD"
        Me.txtテストCD.Required = False
        Me.txtテストCD.Size = New System.Drawing.Size(30, 23)
        Me.txtテストCD.TabIndex = 0
        Me.txtテストCD.Text = "999"
        Me.txtテストCD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grpテスト名
        '
        Me.grpテスト名.Controls.Add(Me.txtテスト名)
        Me.grpテスト名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grpテスト名.Location = New System.Drawing.Point(29, 194)
        Me.grpテスト名.Name = "grpテスト名"
        Me.grpテスト名.Size = New System.Drawing.Size(143, 61)
        Me.grpテスト名.TabIndex = 2
        Me.grpテスト名.TabStop = False
        Me.grpテスト名.Text = "テスト名"
        '
        'txtテスト名
        '
        Me.txtテスト名.FieldLockType = BaseContents.Field.LockType.None
        Me.txtテスト名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txtテスト名.HelpKeys = ""
        Me.txtテスト名.HelpLink = ""
        Me.txtテスト名.HelpType = NodeUI.Help.Type.None
        Me.txtテスト名.IsError = False
        Me.txtテスト名.Location = New System.Drawing.Point(19, 25)
        Me.txtテスト名.Name = "txtテスト名"
        Me.txtテスト名.Required = False
        Me.txtテスト名.Size = New System.Drawing.Size(105, 23)
        Me.txtテスト名.TabIndex = 0
        Me.txtテスト名.Text = "あああああい"
        Me.txtテスト名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'frmPaste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.grpテスト名)
        Me.Controls.Add(Me.grpテストCD)
        Me.Controls.Add(Me.grp処理区分)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmPaste"
        Me.Text = ""
        Me.Controls.SetChildIndex(Me.grp処理区分, 0)
        Me.Controls.SetChildIndex(Me.grpテストCD, 0)
        Me.Controls.SetChildIndex(Me.grpテスト名, 0)
        Me.grp処理区分.ResumeLayout(False)
        Me.grp処理区分.PerformLayout()
        Me.grpテストCD.ResumeLayout(False)
        Me.grpテストCD.PerformLayout()
        Me.grpテスト名.ResumeLayout(False)
        Me.grpテスト名.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp処理区分 As BaseUI.Control.GroupBox
    Friend WithEvents opt削除 As BaseUI.Control.RadioButton
    Friend WithEvents opt修正 As BaseUI.Control.RadioButton
    Friend WithEvents opt登録 As BaseUI.Control.RadioButton
    Friend WithEvents grpテストCD As BaseUI.Control.GroupBox
    Friend WithEvents txtテストCD As BaseUI.Control.TextBox
    Friend WithEvents grpテスト名 As BaseUI.Control.GroupBox
    Friend WithEvents txtテスト名 As BaseUI.Control.TextBox

End Class
