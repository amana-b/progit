<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgCustomerOne
    Inherits BaseUI.BaseDialog

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
        Me.grp得意先名 = New BaseUI.Control.GroupBox()
        Me.txt得意先名 = New BaseUI.Control.TextBox()
        Me.grp得意先CD = New BaseUI.Control.GroupBox()
        Me.txt得意先CD = New BaseUI.Control.TextBox()
        Me.grpfind = New BaseUI.Control.GroupBox()
        Me.GroupBox1 = New BaseUI.Control.GroupBox()
        Me.optコード = New BaseUI.Control.RadioButton()
        Me.opt名前 = New BaseUI.Control.RadioButton()
        Me.grp電話番号 = New BaseUI.Control.GroupBox()
        Me.txt電話番号 = New BaseUI.Control.TextBox()
        Me.grp得意先名.SuspendLayout()
        Me.grp得意先CD.SuspendLayout()
        Me.grpfind.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grp電話番号.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp得意先名
        '
        Me.grp得意先名.Controls.Add(Me.txt得意先名)
        Me.grp得意先名.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grp得意先名.Location = New System.Drawing.Point(13, 131)
        Me.grp得意先名.Name = "grp得意先名"
        Me.grp得意先名.Size = New System.Drawing.Size(223, 48)
        Me.grp得意先名.TabIndex = 2
        Me.grp得意先名.TabStop = False
        Me.grp得意先名.Text = "得意先名"
        '
        'txt得意先名
        '
        Me.txt得意先名.FieldLockType = BaseContents.Field.LockType.None
        Me.txt得意先名.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.txt得意先名.HelpKeys = ""
        Me.txt得意先名.HelpLink = ""
        Me.txt得意先名.HelpType = NodeUI.Help.Type.None
        Me.txt得意先名.IsError = False
        Me.txt得意先名.Location = New System.Drawing.Point(8, 18)
        Me.txt得意先名.Name = "txt得意先名"
        Me.txt得意先名.Required = False
        Me.txt得意先名.Size = New System.Drawing.Size(200, 19)
        Me.txt得意先名.StringLength = 65535
        Me.txt得意先名.TabIndex = 6
        Me.txt得意先名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp得意先CD
        '
        Me.grp得意先CD.Controls.Add(Me.txt得意先CD)
        Me.grp得意先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grp得意先CD.Location = New System.Drawing.Point(13, 189)
        Me.grp得意先CD.Name = "grp得意先CD"
        Me.grp得意先CD.Size = New System.Drawing.Size(89, 48)
        Me.grp得意先CD.TabIndex = 3
        Me.grp得意先CD.TabStop = False
        Me.grp得意先CD.Text = "得意先CD"
        '
        'txt得意先CD
        '
        Me.txt得意先CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt得意先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.txt得意先CD.HelpKeys = ""
        Me.txt得意先CD.HelpLink = ""
        Me.txt得意先CD.HelpType = NodeUI.Help.Type.None
        Me.txt得意先CD.IsError = False
        Me.txt得意先CD.Location = New System.Drawing.Point(11, 17)
        Me.txt得意先CD.Name = "txt得意先CD"
        Me.txt得意先CD.Required = False
        Me.txt得意先CD.Size = New System.Drawing.Size(46, 19)
        Me.txt得意先CD.StringLength = 65535
        Me.txt得意先CD.TabIndex = 4
        Me.txt得意先CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grpfind
        '
        Me.grpfind.Controls.Add(Me.GroupBox1)
        Me.grpfind.Controls.Add(Me.grp電話番号)
        Me.grpfind.Controls.Add(Me.grp得意先名)
        Me.grpfind.Controls.Add(Me.grp得意先CD)
        Me.grpfind.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grpfind.Location = New System.Drawing.Point(435, 10)
        Me.grpfind.Name = "grpfind"
        Me.grpfind.Size = New System.Drawing.Size(250, 255)
        Me.grpfind.TabIndex = 1
        Me.grpfind.TabStop = False
        Me.grpfind.Text = "検索項目"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optコード)
        Me.GroupBox1.Controls.Add(Me.opt名前)
        Me.GroupBox1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(208, 48)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ｿｰﾄ"
        '
        'optコード
        '
        Me.optコード.AutoSize = True
        Me.optコード.Checked = True
        Me.optコード.FieldLockType = BaseContents.Field.LockType.None
        Me.optコード.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.optコード.IsError = False
        Me.optコード.Location = New System.Drawing.Point(10, 18)
        Me.optコード.Name = "optコード"
        Me.optコード.Required = False
        Me.optコード.Size = New System.Drawing.Size(47, 16)
        Me.optコード.TabIndex = 0
        Me.optコード.TabStop = True
        Me.optコード.Text = "ｺｰﾄﾞ"
        Me.optコード.UseVisualStyleBackColor = True
        '
        'opt名前
        '
        Me.opt名前.AutoSize = True
        Me.opt名前.FieldLockType = BaseContents.Field.LockType.None
        Me.opt名前.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.opt名前.IsError = False
        Me.opt名前.Location = New System.Drawing.Point(86, 18)
        Me.opt名前.Name = "opt名前"
        Me.opt名前.Required = False
        Me.opt名前.Size = New System.Drawing.Size(47, 16)
        Me.opt名前.TabIndex = 1
        Me.opt名前.Text = "名前"
        Me.opt名前.UseVisualStyleBackColor = True
        '
        'grp電話番号
        '
        Me.grp電話番号.Controls.Add(Me.txt電話番号)
        Me.grp電話番号.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grp電話番号.Location = New System.Drawing.Point(13, 70)
        Me.grp電話番号.Name = "grp電話番号"
        Me.grp電話番号.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.grp電話番号.Size = New System.Drawing.Size(133, 48)
        Me.grp電話番号.TabIndex = 1
        Me.grp電話番号.TabStop = False
        Me.grp電話番号.Text = "電話番号"
        '
        'txt電話番号
        '
        Me.txt電話番号.FieldLockType = BaseContents.Field.LockType.None
        Me.txt電話番号.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.txt電話番号.HelpKeys = ""
        Me.txt電話番号.HelpLink = ""
        Me.txt電話番号.HelpType = NodeUI.Help.Type.None
        Me.txt電話番号.IsError = False
        Me.txt電話番号.Location = New System.Drawing.Point(8, 18)
        Me.txt電話番号.Name = "txt電話番号"
        Me.txt電話番号.Required = False
        Me.txt電話番号.Size = New System.Drawing.Size(114, 19)
        Me.txt電話番号.StringLength = 65535
        Me.txt電話番号.TabIndex = 6
        Me.txt電話番号.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'dlgCustomerOne
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 475)
        Me.Controls.Add(Me.grpfind)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "dlgCustomerOne"
        Me.Text = "dlgCustomer"
        Me.Controls.SetChildIndex(Me.grpfind, 0)
        Me.grp得意先名.ResumeLayout(False)
        Me.grp得意先名.PerformLayout()
        Me.grp得意先CD.ResumeLayout(False)
        Me.grp得意先CD.PerformLayout()
        Me.grpfind.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grp電話番号.ResumeLayout(False)
        Me.grp電話番号.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp得意先名 As BaseUI.Control.GroupBox
    Friend WithEvents txt得意先名 As BaseUI.Control.TextBox
    Friend WithEvents grp得意先CD As BaseUI.Control.GroupBox
    Friend WithEvents txt得意先CD As BaseUI.Control.TextBox
    Friend WithEvents grpfind As BaseUI.Control.GroupBox
    Friend WithEvents grp電話番号 As BaseUI.Control.GroupBox
    Friend WithEvents txt電話番号 As BaseUI.Control.TextBox
    Friend WithEvents GroupBox1 As BaseUI.Control.GroupBox
    Friend WithEvents optコード As BaseUI.Control.RadioButton
    Friend WithEvents opt名前 As BaseUI.Control.RadioButton
End Class
