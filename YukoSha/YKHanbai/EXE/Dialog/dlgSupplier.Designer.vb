<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgSupplier
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
        Me.grp仕入先名 = New BaseUI.Control.GroupBox()
        Me.txt仕入先名 = New BaseUI.Control.TextBox()
        Me.grp仕入先CD = New BaseUI.Control.GroupBox()
        Me.txt仕入先CD = New BaseUI.Control.TextBox()
        Me.grpfind = New BaseUI.Control.GroupBox()
        Me.grpソート = New BaseUI.Control.GroupBox()
        Me.opt名前 = New BaseUI.Control.RadioButton()
        Me.optコード = New BaseUI.Control.RadioButton()
        Me.grp仕入先名.SuspendLayout()
        Me.grp仕入先CD.SuspendLayout()
        Me.grpfind.SuspendLayout()
        Me.grpソート.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnF12
        '
        Me.btnF12.TabIndex = 0
        '
        'btnESC
        '
        Me.btnESC.TabIndex = 1
        '
        'grp仕入先名
        '
        Me.grp仕入先名.Controls.Add(Me.txt仕入先名)
        Me.grp仕入先名.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grp仕入先名.Location = New System.Drawing.Point(7, 72)
        Me.grp仕入先名.Name = "grp仕入先名"
        Me.grp仕入先名.Size = New System.Drawing.Size(143, 46)
        Me.grp仕入先名.TabIndex = 13
        Me.grp仕入先名.TabStop = False
        Me.grp仕入先名.Text = "仕入先名"
        '
        'txt仕入先名
        '
        Me.txt仕入先名.FieldLockType = BaseContents.Field.LockType.None
        Me.txt仕入先名.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.txt仕入先名.HelpKeys = ""
        Me.txt仕入先名.HelpLink = ""
        Me.txt仕入先名.HelpType = NodeUI.Help.Type.None
        Me.txt仕入先名.IsError = False
        Me.txt仕入先名.Location = New System.Drawing.Point(8, 18)
        Me.txt仕入先名.Name = "txt仕入先名"
        Me.txt仕入先名.Required = False
        Me.txt仕入先名.Size = New System.Drawing.Size(129, 19)
        Me.txt仕入先名.StringLength = 65535
        Me.txt仕入先名.TabIndex = 0
        Me.txt仕入先名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp仕入先CD
        '
        Me.grp仕入先CD.Controls.Add(Me.txt仕入先CD)
        Me.grp仕入先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grp仕入先CD.Location = New System.Drawing.Point(7, 125)
        Me.grp仕入先CD.Name = "grp仕入先CD"
        Me.grp仕入先CD.Size = New System.Drawing.Size(143, 46)
        Me.grp仕入先CD.TabIndex = 12
        Me.grp仕入先CD.TabStop = False
        Me.grp仕入先CD.Text = "仕入先CD"
        '
        'txt仕入先CD
        '
        Me.txt仕入先CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt仕入先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.txt仕入先CD.HelpKeys = ""
        Me.txt仕入先CD.HelpLink = ""
        Me.txt仕入先CD.HelpType = NodeUI.Help.Type.None
        Me.txt仕入先CD.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt仕入先CD.IsError = False
        Me.txt仕入先CD.Location = New System.Drawing.Point(8, 18)
        Me.txt仕入先CD.Name = "txt仕入先CD"
        Me.txt仕入先CD.Required = False
        Me.txt仕入先CD.Size = New System.Drawing.Size(58, 19)
        Me.txt仕入先CD.StringLength = 65535
        Me.txt仕入先CD.TabIndex = 0
        Me.txt仕入先CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grpfind
        '
        Me.grpfind.Controls.Add(Me.grpソート)
        Me.grpfind.Controls.Add(Me.grp仕入先名)
        Me.grpfind.Controls.Add(Me.grp仕入先CD)
        Me.grpfind.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grpfind.Location = New System.Drawing.Point(287, 10)
        Me.grpfind.Name = "grpfind"
        Me.grpfind.Size = New System.Drawing.Size(164, 185)
        Me.grpfind.TabIndex = 27
        Me.grpfind.TabStop = False
        Me.grpfind.Text = "検索項目"
        '
        'grpソート
        '
        Me.grpソート.Controls.Add(Me.opt名前)
        Me.grpソート.Controls.Add(Me.optコード)
        Me.grpソート.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grpソート.Location = New System.Drawing.Point(7, 17)
        Me.grpソート.Name = "grpソート"
        Me.grpソート.Size = New System.Drawing.Size(143, 46)
        Me.grpソート.TabIndex = 14
        Me.grpソート.TabStop = False
        Me.grpソート.Text = "ｿｰﾄ"
        '
        'opt名前
        '
        Me.opt名前.AutoSize = True
        Me.opt名前.FieldLockType = BaseContents.Field.LockType.None
        Me.opt名前.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.opt名前.IsError = False
        Me.opt名前.Location = New System.Drawing.Point(74, 18)
        Me.opt名前.Name = "opt名前"
        Me.opt名前.Required = False
        Me.opt名前.Size = New System.Drawing.Size(47, 16)
        Me.opt名前.TabIndex = 2
        Me.opt名前.Text = "名前"
        Me.opt名前.UseVisualStyleBackColor = True
        '
        'optコード
        '
        Me.optコード.AutoSize = True
        Me.optコード.Checked = True
        Me.optコード.FieldLockType = BaseContents.Field.LockType.None
        Me.optコード.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.optコード.IsError = False
        Me.optコード.Location = New System.Drawing.Point(8, 18)
        Me.optコード.Name = "optコード"
        Me.optコード.Required = False
        Me.optコード.Size = New System.Drawing.Size(47, 16)
        Me.optコード.TabIndex = 1
        Me.optコード.TabStop = True
        Me.optコード.Text = "ｺｰﾄﾞ"
        Me.optコード.UseVisualStyleBackColor = True
        '
        'dlgSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 475)
        Me.Controls.Add(Me.grpfind)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "dlgSupplier"
        Me.Text = "dlgPaper"
        Me.Controls.SetChildIndex(Me.grpfind, 0)
        Me.grp仕入先名.ResumeLayout(False)
        Me.grp仕入先名.PerformLayout()
        Me.grp仕入先CD.ResumeLayout(False)
        Me.grp仕入先CD.PerformLayout()
        Me.grpfind.ResumeLayout(False)
        Me.grpソート.ResumeLayout(False)
        Me.grpソート.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp仕入先名 As BaseUI.Control.GroupBox
    Friend WithEvents txt仕入先名 As BaseUI.Control.TextBox
    Friend WithEvents grp仕入先CD As BaseUI.Control.GroupBox
    Friend WithEvents txt仕入先CD As BaseUI.Control.TextBox
    Friend WithEvents grpfind As BaseUI.Control.GroupBox
    Friend WithEvents grpソート As BaseUI.Control.GroupBox
    Friend WithEvents opt名前 As BaseUI.Control.RadioButton
    Friend WithEvents optコード As BaseUI.Control.RadioButton
End Class
