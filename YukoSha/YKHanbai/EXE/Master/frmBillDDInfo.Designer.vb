<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBillDDInfo
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
        Me.grp締日 = New BaseUI.Control.GroupBox()
        Me.Label1 = New BaseUI.Control.Label()
        Me.txt締日 = New BaseUI.Control.TextBox()
        Me.grp今回請求年月日 = New BaseUI.Control.GroupBox()
        Me.txt請求日付 = New BaseUI.Control.TextBox()
        Me.grp処理区分.SuspendLayout()
        Me.grp締日.SuspendLayout()
        Me.grp今回請求年月日.SuspendLayout()
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
        'grp締日
        '
        Me.grp締日.Controls.Add(Me.Label1)
        Me.grp締日.Controls.Add(Me.txt締日)
        Me.grp締日.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp締日.Location = New System.Drawing.Point(29, 108)
        Me.grp締日.Name = "grp締日"
        Me.grp締日.Size = New System.Drawing.Size(193, 61)
        Me.grp締日.TabIndex = 1
        Me.grp締日.TabStop = False
        Me.grp締日.Text = "締日"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Label1.Location = New System.Drawing.Point(52, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(127, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "日締　(99:末締)"
        '
        'txt締日
        '
        Me.txt締日.FieldLockType = BaseContents.Field.LockType.None
        Me.txt締日.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt締日.HelpKeys = ""
        Me.txt締日.HelpLink = ""
        Me.txt締日.HelpType = NodeUI.Help.Type.None
        Me.txt締日.IsError = False
        Me.txt締日.Location = New System.Drawing.Point(19, 25)
        Me.txt締日.Name = "txt締日"
        Me.txt締日.Required = False
        Me.txt締日.Size = New System.Drawing.Size(23, 23)
        Me.txt締日.TabIndex = 0
        Me.txt締日.Text = "99"
        Me.txt締日.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp今回請求年月日
        '
        Me.grp今回請求年月日.Controls.Add(Me.txt請求日付)
        Me.grp今回請求年月日.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp今回請求年月日.Location = New System.Drawing.Point(29, 196)
        Me.grp今回請求年月日.Name = "grp今回請求年月日"
        Me.grp今回請求年月日.Size = New System.Drawing.Size(315, 61)
        Me.grp今回請求年月日.TabIndex = 2
        Me.grp今回請求年月日.TabStop = False
        Me.grp今回請求年月日.Text = "今回請求対象年月日まで"
        '
        'txt請求日付
        '
        Me.txt請求日付.BackColor = System.Drawing.SystemColors.Window
        Me.txt請求日付.FieldLockType = BaseContents.Field.LockType.None
        Me.txt請求日付.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt請求日付.HelpKeys = ""
        Me.txt請求日付.HelpLink = ""
        Me.txt請求日付.HelpType = NodeUI.Help.Type.None
        Me.txt請求日付.IsError = False
        Me.txt請求日付.Location = New System.Drawing.Point(19, 25)
        Me.txt請求日付.Name = "txt請求日付"
        Me.txt請求日付.Required = False
        Me.txt請求日付.Size = New System.Drawing.Size(94, 23)
        Me.txt請求日付.TabIndex = 0
        Me.txt請求日付.Text = "yyyy/MM/dd"
        Me.txt請求日付.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'frmBillDDInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.grp今回請求年月日)
        Me.Controls.Add(Me.grp締日)
        Me.Controls.Add(Me.grp処理区分)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmBillDDInfo"
        Me.Text = ""
        Me.Controls.SetChildIndex(Me.grp処理区分, 0)
        Me.Controls.SetChildIndex(Me.grp締日, 0)
        Me.Controls.SetChildIndex(Me.grp今回請求年月日, 0)
        Me.grp処理区分.ResumeLayout(False)
        Me.grp処理区分.PerformLayout()
        Me.grp締日.ResumeLayout(False)
        Me.grp締日.PerformLayout()
        Me.grp今回請求年月日.ResumeLayout(False)
        Me.grp今回請求年月日.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp処理区分 As BaseUI.Control.GroupBox
    Friend WithEvents opt削除 As BaseUI.Control.RadioButton
    Friend WithEvents opt修正 As BaseUI.Control.RadioButton
    Friend WithEvents opt登録 As BaseUI.Control.RadioButton
    Friend WithEvents grp締日 As BaseUI.Control.GroupBox
    Friend WithEvents txt締日 As BaseUI.Control.TextBox
    Friend WithEvents grp今回請求年月日 As BaseUI.Control.GroupBox
    Friend WithEvents txt請求日付 As BaseUI.Control.TextBox
    Friend WithEvents Label1 As BaseUI.Control.Label

End Class
