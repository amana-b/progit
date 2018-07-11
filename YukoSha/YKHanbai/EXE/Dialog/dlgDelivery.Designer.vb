<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgDelivery
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
        Me.grp出荷先名 = New BaseUI.Control.GroupBox()
        Me.txt出荷先名 = New BaseUI.Control.TextBox()
        Me.grp出荷先CD = New BaseUI.Control.GroupBox()
        Me.txt出荷先CD = New BaseUI.Control.TextBox()
        Me.grpfind = New BaseUI.Control.GroupBox()
        Me.grp得意先 = New BaseUI.Control.GroupBox()
        Me.nam得意先名 = New BaseUI.Control.NameBox()
        Me.txt得意先CD = New BaseUI.Control.TextBox()
        Me.grp出荷先名.SuspendLayout()
        Me.grp出荷先CD.SuspendLayout()
        Me.grpfind.SuspendLayout()
        Me.grp得意先.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxCond
        '
        Me.GroupBoxCond.Location = New System.Drawing.Point(101, 10)
        '
        'grp出荷先名
        '
        Me.grp出荷先名.Controls.Add(Me.txt出荷先名)
        Me.grp出荷先名.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grp出荷先名.Location = New System.Drawing.Point(13, 72)
        Me.grp出荷先名.Name = "grp出荷先名"
        Me.grp出荷先名.Size = New System.Drawing.Size(260, 46)
        Me.grp出荷先名.TabIndex = 13
        Me.grp出荷先名.TabStop = False
        Me.grp出荷先名.Text = "出荷先名"
        '
        'txt出荷先名
        '
        Me.txt出荷先名.FieldLockType = BaseContents.Field.LockType.None
        Me.txt出荷先名.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.txt出荷先名.HelpKeys = ""
        Me.txt出荷先名.HelpLink = ""
        Me.txt出荷先名.HelpType = NodeUI.Help.Type.None
        Me.txt出荷先名.IsError = False
        Me.txt出荷先名.Location = New System.Drawing.Point(6, 18)
        Me.txt出荷先名.Name = "txt出荷先名"
        Me.txt出荷先名.Required = False
        Me.txt出荷先名.Size = New System.Drawing.Size(245, 19)
        Me.txt出荷先名.StringLength = 65535
        Me.txt出荷先名.TabIndex = 6
        Me.txt出荷先名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp出荷先CD
        '
        Me.grp出荷先CD.Controls.Add(Me.txt出荷先CD)
        Me.grp出荷先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grp出荷先CD.Location = New System.Drawing.Point(13, 124)
        Me.grp出荷先CD.Name = "grp出荷先CD"
        Me.grp出荷先CD.Size = New System.Drawing.Size(89, 46)
        Me.grp出荷先CD.TabIndex = 12
        Me.grp出荷先CD.TabStop = False
        Me.grp出荷先CD.Text = "出荷先CD"
        '
        'txt出荷先CD
        '
        Me.txt出荷先CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt出荷先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.txt出荷先CD.HelpKeys = ""
        Me.txt出荷先CD.HelpLink = ""
        Me.txt出荷先CD.HelpType = NodeUI.Help.Type.None
        Me.txt出荷先CD.IsError = False
        Me.txt出荷先CD.Location = New System.Drawing.Point(6, 18)
        Me.txt出荷先CD.Name = "txt出荷先CD"
        Me.txt出荷先CD.Required = False
        Me.txt出荷先CD.Size = New System.Drawing.Size(30, 19)
        Me.txt出荷先CD.StringLength = 65535
        Me.txt出荷先CD.TabIndex = 4
        Me.txt出荷先CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grpfind
        '
        Me.grpfind.Controls.Add(Me.grp得意先)
        Me.grpfind.Controls.Add(Me.grp出荷先名)
        Me.grpfind.Controls.Add(Me.grp出荷先CD)
        Me.grpfind.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grpfind.Location = New System.Drawing.Point(435, 10)
        Me.grpfind.Name = "grpfind"
        Me.grpfind.Size = New System.Drawing.Size(280, 185)
        Me.grpfind.TabIndex = 27
        Me.grpfind.TabStop = False
        Me.grpfind.Text = "検索項目"
        '
        'grp得意先
        '
        Me.grp得意先.Controls.Add(Me.nam得意先名)
        Me.grp得意先.Controls.Add(Me.txt得意先CD)
        Me.grp得意先.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grp得意先.Location = New System.Drawing.Point(13, 17)
        Me.grp得意先.Name = "grp得意先"
        Me.grp得意先.Size = New System.Drawing.Size(260, 46)
        Me.grp得意先.TabIndex = 13
        Me.grp得意先.TabStop = False
        Me.grp得意先.Text = "得意先CD"
        '
        'nam得意先名
        '
        Me.nam得意先名.BackColor = System.Drawing.SystemColors.Control
        Me.nam得意先名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam得意先名.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.nam得意先名.Location = New System.Drawing.Point(52, 18)
        Me.nam得意先名.Margin = New System.Windows.Forms.Padding(3)
        Me.nam得意先名.Name = "nam得意先名"
        Me.nam得意先名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.nam得意先名.Size = New System.Drawing.Size(200, 19)
        Me.nam得意先名.StringLength = 65535
        Me.nam得意先名.TabIndex = 10
        Me.nam得意先名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt得意先CD
        '
        Me.txt得意先CD.Enabled = False
        Me.txt得意先CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt得意先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.txt得意先CD.HelpKeys = ""
        Me.txt得意先CD.HelpLink = ""
        Me.txt得意先CD.HelpType = NodeUI.Help.Type.None
        Me.txt得意先CD.IsError = False
        Me.txt得意先CD.Location = New System.Drawing.Point(6, 18)
        Me.txt得意先CD.Name = "txt得意先CD"
        Me.txt得意先CD.Required = False
        Me.txt得意先CD.Size = New System.Drawing.Size(45, 19)
        Me.txt得意先CD.StringLength = 65535
        Me.txt得意先CD.TabIndex = 4
        Me.txt得意先CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'dlgDelivery
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 475)
        Me.Controls.Add(Me.grpfind)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "dlgDelivery"
        Me.Text = "dlgDelivery"
        Me.Controls.SetChildIndex(Me.grpfind, 0)
        Me.grp出荷先名.ResumeLayout(False)
        Me.grp出荷先名.PerformLayout()
        Me.grp出荷先CD.ResumeLayout(False)
        Me.grp出荷先CD.PerformLayout()
        Me.grpfind.ResumeLayout(False)
        Me.grp得意先.ResumeLayout(False)
        Me.grp得意先.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp出荷先名 As BaseUI.Control.GroupBox
    Friend WithEvents txt出荷先名 As BaseUI.Control.TextBox
    Friend WithEvents grp出荷先CD As BaseUI.Control.GroupBox
    Friend WithEvents txt出荷先CD As BaseUI.Control.TextBox
    Friend WithEvents grpfind As BaseUI.Control.GroupBox
    Friend WithEvents grp得意先 As BaseUI.Control.GroupBox
    Friend WithEvents txt得意先CD As BaseUI.Control.TextBox
    Friend WithEvents nam得意先名 As BaseUI.Control.NameBox
End Class
