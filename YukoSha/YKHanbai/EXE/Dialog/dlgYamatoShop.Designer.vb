<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgYamatoShop
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
        Me.grp店所名 = New BaseUI.Control.GroupBox()
        Me.txt店所名 = New BaseUI.Control.TextBox()
        Me.grpfind = New BaseUI.Control.GroupBox()
        Me.grpTEL = New BaseUI.Control.GroupBox()
        Me.txtTEL = New BaseUI.Control.TextBox()
        Me.grp店所CD = New BaseUI.Control.GroupBox()
        Me.txt店所CD = New BaseUI.Control.TextBox()
        Me.grp店所名.SuspendLayout()
        Me.grpfind.SuspendLayout()
        Me.grpTEL.SuspendLayout()
        Me.grp店所CD.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp店所名
        '
        Me.grp店所名.Controls.Add(Me.txt店所名)
        Me.grp店所名.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grp店所名.Location = New System.Drawing.Point(11, 70)
        Me.grp店所名.Name = "grp店所名"
        Me.grp店所名.Size = New System.Drawing.Size(290, 46)
        Me.grp店所名.TabIndex = 1
        Me.grp店所名.TabStop = False
        Me.grp店所名.Text = "店所名"
        '
        'txt店所名
        '
        Me.txt店所名.FieldLockType = BaseContents.Field.LockType.None
        Me.txt店所名.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.txt店所名.HelpKeys = ""
        Me.txt店所名.HelpLink = ""
        Me.txt店所名.HelpType = NodeUI.Help.Type.None
        Me.txt店所名.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt店所名.IsError = False
        Me.txt店所名.Location = New System.Drawing.Point(8, 17)
        Me.txt店所名.Name = "txt店所名"
        Me.txt店所名.Required = False
        Me.txt店所名.Size = New System.Drawing.Size(270, 19)
        Me.txt店所名.StringLength = 65535
        Me.txt店所名.TabIndex = 0
        Me.txt店所名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grpfind
        '
        Me.grpfind.Controls.Add(Me.grpTEL)
        Me.grpfind.Controls.Add(Me.grp店所CD)
        Me.grpfind.Controls.Add(Me.grp店所名)
        Me.grpfind.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grpfind.Location = New System.Drawing.Point(352, 10)
        Me.grpfind.Name = "grpfind"
        Me.grpfind.Size = New System.Drawing.Size(314, 179)
        Me.grpfind.TabIndex = 0
        Me.grpfind.TabStop = False
        Me.grpfind.Text = "検索項目"
        '
        'grpTEL
        '
        Me.grpTEL.Controls.Add(Me.txtTEL)
        Me.grpTEL.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grpTEL.Location = New System.Drawing.Point(11, 18)
        Me.grpTEL.Name = "grpTEL"
        Me.grpTEL.Size = New System.Drawing.Size(139, 46)
        Me.grpTEL.TabIndex = 0
        Me.grpTEL.TabStop = False
        Me.grpTEL.Text = "TEL"
        '
        'txtTEL
        '
        Me.txtTEL.FieldLockType = BaseContents.Field.LockType.None
        Me.txtTEL.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.txtTEL.HelpKeys = ""
        Me.txtTEL.HelpLink = ""
        Me.txtTEL.HelpType = NodeUI.Help.Type.None
        Me.txtTEL.IsError = False
        Me.txtTEL.Location = New System.Drawing.Point(8, 17)
        Me.txtTEL.Name = "txtTEL"
        Me.txtTEL.Required = False
        Me.txtTEL.Size = New System.Drawing.Size(119, 19)
        Me.txtTEL.StringLength = 65535
        Me.txtTEL.TabIndex = 0
        Me.txtTEL.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp店所CD
        '
        Me.grp店所CD.Controls.Add(Me.txt店所CD)
        Me.grp店所CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grp店所CD.Location = New System.Drawing.Point(11, 120)
        Me.grp店所CD.Name = "grp店所CD"
        Me.grp店所CD.Size = New System.Drawing.Size(116, 46)
        Me.grp店所CD.TabIndex = 2
        Me.grp店所CD.TabStop = False
        Me.grp店所CD.Text = "店所CD"
        '
        'txt店所CD
        '
        Me.txt店所CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt店所CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.txt店所CD.HelpKeys = ""
        Me.txt店所CD.HelpLink = ""
        Me.txt店所CD.HelpType = NodeUI.Help.Type.None
        Me.txt店所CD.IsError = False
        Me.txt店所CD.Location = New System.Drawing.Point(8, 16)
        Me.txt店所CD.Name = "txt店所CD"
        Me.txt店所CD.Required = False
        Me.txt店所CD.Size = New System.Drawing.Size(63, 19)
        Me.txt店所CD.StringLength = 65535
        Me.txt店所CD.TabIndex = 0
        Me.txt店所CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'dlgYamatoShop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 475)
        Me.Controls.Add(Me.grpfind)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "dlgYamatoShop"
        Me.Text = "dlgYamatoKind"
        Me.Controls.SetChildIndex(Me.grpfind, 0)
        Me.grp店所名.ResumeLayout(False)
        Me.grp店所名.PerformLayout()
        Me.grpfind.ResumeLayout(False)
        Me.grpTEL.ResumeLayout(False)
        Me.grpTEL.PerformLayout()
        Me.grp店所CD.ResumeLayout(False)
        Me.grp店所CD.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp店所名 As BaseUI.Control.GroupBox
    Friend WithEvents txt店所名 As BaseUI.Control.TextBox
    Friend WithEvents grpfind As BaseUI.Control.GroupBox
    Friend WithEvents grp店所CD As BaseUI.Control.GroupBox
    Friend WithEvents txt店所CD As BaseUI.Control.TextBox
    Friend WithEvents grpTEL As BaseUI.Control.GroupBox
    Friend WithEvents txtTEL As BaseUI.Control.TextBox
End Class
