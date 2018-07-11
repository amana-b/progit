<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgItemName
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
        Me.grp品名 = New BaseUI.Control.GroupBox()
        Me.txt品名 = New BaseUI.Control.TextBox()
        Me.grp品名CD = New BaseUI.Control.GroupBox()
        Me.txt品名CD = New BaseUI.Control.TextBox()
        Me.grpfind = New BaseUI.Control.GroupBox()
        Me.grp得意先 = New BaseUI.Control.GroupBox()
        Me.btn得意先 = New BaseUI.Control.Button()
        Me.nam得意先名 = New BaseUI.Control.NameBox()
        Me.txt得意先CD = New BaseUI.Control.TextBox()
        Me.grp品名.SuspendLayout()
        Me.grp品名CD.SuspendLayout()
        Me.grpfind.SuspendLayout()
        Me.grp得意先.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxCond
        '
        Me.GroupBoxCond.Location = New System.Drawing.Point(101, 25)
        '
        'grp品名
        '
        Me.grp品名.Controls.Add(Me.txt品名)
        Me.grp品名.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grp品名.Location = New System.Drawing.Point(13, 68)
        Me.grp品名.Name = "grp品名"
        Me.grp品名.Size = New System.Drawing.Size(284, 46)
        Me.grp品名.TabIndex = 1
        Me.grp品名.TabStop = False
        Me.grp品名.Text = "品名"
        '
        'txt品名
        '
        Me.txt品名.FieldLockType = BaseContents.Field.LockType.None
        Me.txt品名.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.txt品名.HelpKeys = ""
        Me.txt品名.HelpLink = ""
        Me.txt品名.HelpType = NodeUI.Help.Type.None
        Me.txt品名.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt品名.IsError = False
        Me.txt品名.Location = New System.Drawing.Point(7, 18)
        Me.txt品名.Name = "txt品名"
        Me.txt品名.Required = False
        Me.txt品名.Size = New System.Drawing.Size(264, 19)
        Me.txt品名.StringLength = 65535
        Me.txt品名.TabIndex = 0
        Me.txt品名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp品名CD
        '
        Me.grp品名CD.Controls.Add(Me.txt品名CD)
        Me.grp品名CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grp品名CD.Location = New System.Drawing.Point(13, 120)
        Me.grp品名CD.Name = "grp品名CD"
        Me.grp品名CD.Size = New System.Drawing.Size(129, 46)
        Me.grp品名CD.TabIndex = 2
        Me.grp品名CD.TabStop = False
        Me.grp品名CD.Text = "品名CD"
        '
        'txt品名CD
        '
        Me.txt品名CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt品名CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.txt品名CD.HelpKeys = ""
        Me.txt品名CD.HelpLink = ""
        Me.txt品名CD.HelpType = NodeUI.Help.Type.None
        Me.txt品名CD.IsError = False
        Me.txt品名CD.Location = New System.Drawing.Point(7, 18)
        Me.txt品名CD.Name = "txt品名CD"
        Me.txt品名CD.Required = False
        Me.txt品名CD.Size = New System.Drawing.Size(112, 19)
        Me.txt品名CD.StringLength = 65535
        Me.txt品名CD.TabIndex = 0
        Me.txt品名CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grpfind
        '
        Me.grpfind.Controls.Add(Me.grp得意先)
        Me.grpfind.Controls.Add(Me.grp品名)
        Me.grpfind.Controls.Add(Me.grp品名CD)
        Me.grpfind.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grpfind.Location = New System.Drawing.Point(368, 10)
        Me.grpfind.Name = "grpfind"
        Me.grpfind.Size = New System.Drawing.Size(386, 183)
        Me.grpfind.TabIndex = 1
        Me.grpfind.TabStop = False
        Me.grpfind.Text = "検索項目"
        '
        'grp得意先
        '
        Me.grp得意先.Controls.Add(Me.btn得意先)
        Me.grp得意先.Controls.Add(Me.nam得意先名)
        Me.grp得意先.Controls.Add(Me.txt得意先CD)
        Me.grp得意先.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grp得意先.Location = New System.Drawing.Point(13, 18)
        Me.grp得意先.Name = "grp得意先"
        Me.grp得意先.Size = New System.Drawing.Size(357, 46)
        Me.grp得意先.TabIndex = 0
        Me.grp得意先.TabStop = False
        Me.grp得意先.Text = "得意先CD"
        '
        'btn得意先
        '
        Me.btn得意先.FieldLockType = BaseContents.Field.LockType.None
        Me.btn得意先.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn得意先.Location = New System.Drawing.Point(269, 13)
        Me.btn得意先.Name = "btn得意先"
        Me.btn得意先.Size = New System.Drawing.Size(80, 26)
        Me.btn得意先.TabIndex = 26
        Me.btn得意先.TabStop = False
        Me.btn得意先.Text = "得意先検索"
        Me.btn得意先.UseVisualStyleBackColor = True
        '
        'nam得意先名
        '
        Me.nam得意先名.BackColor = System.Drawing.SystemColors.Control
        Me.nam得意先名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam得意先名.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.nam得意先名.Location = New System.Drawing.Point(67, 18)
        Me.nam得意先名.Margin = New System.Windows.Forms.Padding(3)
        Me.nam得意先名.Name = "nam得意先名"
        Me.nam得意先名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.nam得意先名.Size = New System.Drawing.Size(200, 19)
        Me.nam得意先名.StringLength = 65535
        Me.nam得意先名.TabIndex = 1
        Me.nam得意先名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt得意先CD
        '
        Me.txt得意先CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt得意先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.txt得意先CD.HelpKeys = ""
        Me.txt得意先CD.HelpLink = ""
        Me.txt得意先CD.HelpType = NodeUI.Help.Type.None
        Me.txt得意先CD.IsError = False
        Me.txt得意先CD.Location = New System.Drawing.Point(7, 18)
        Me.txt得意先CD.Name = "txt得意先CD"
        Me.txt得意先CD.Required = False
        Me.txt得意先CD.Size = New System.Drawing.Size(61, 19)
        Me.txt得意先CD.TabIndex = 0
        Me.txt得意先CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'dlgItemName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 475)
        Me.Controls.Add(Me.grpfind)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "dlgItemName"
        Me.Text = "dlgItemName"
        Me.Controls.SetChildIndex(Me.grpfind, 0)
        Me.grp品名.ResumeLayout(False)
        Me.grp品名.PerformLayout()
        Me.grp品名CD.ResumeLayout(False)
        Me.grp品名CD.PerformLayout()
        Me.grpfind.ResumeLayout(False)
        Me.grp得意先.ResumeLayout(False)
        Me.grp得意先.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grp品名 As BaseUI.Control.GroupBox
    Friend WithEvents txt品名 As BaseUI.Control.TextBox
    Friend WithEvents grp品名CD As BaseUI.Control.GroupBox
    Friend WithEvents txt品名CD As BaseUI.Control.TextBox
    Friend WithEvents grpfind As BaseUI.Control.GroupBox
    Friend WithEvents grp得意先 As BaseUI.Control.GroupBox
    Friend WithEvents nam得意先名 As BaseUI.Control.NameBox
    Friend WithEvents txt得意先CD As BaseUI.Control.TextBox
    Protected WithEvents btn得意先 As BaseUI.Control.Button
End Class
