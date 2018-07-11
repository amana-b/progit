<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgMount
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
        Me.grp台紙名 = New BaseUI.Control.GroupBox()
        Me.txt台紙名 = New BaseUI.Control.TextBox()
        Me.grp台紙CD = New BaseUI.Control.GroupBox()
        Me.txt台紙CD = New BaseUI.Control.TextBox()
        Me.grpfind = New BaseUI.Control.GroupBox()
        Me.grp台紙名.SuspendLayout()
        Me.grp台紙CD.SuspendLayout()
        Me.grpfind.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp台紙名
        '
        Me.grp台紙名.Controls.Add(Me.txt台紙名)
        Me.grp台紙名.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grp台紙名.Location = New System.Drawing.Point(8, 17)
        Me.grp台紙名.Name = "grp台紙名"
        Me.grp台紙名.Size = New System.Drawing.Size(143, 46)
        Me.grp台紙名.TabIndex = 0
        Me.grp台紙名.TabStop = False
        Me.grp台紙名.Text = "台紙名"
        '
        'txt台紙名
        '
        Me.txt台紙名.FieldLockType = BaseContents.Field.LockType.None
        Me.txt台紙名.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.txt台紙名.HelpKeys = ""
        Me.txt台紙名.HelpLink = ""
        Me.txt台紙名.HelpType = NodeUI.Help.Type.None
        Me.txt台紙名.IsError = False
        Me.txt台紙名.Location = New System.Drawing.Point(8, 17)
        Me.txt台紙名.Name = "txt台紙名"
        Me.txt台紙名.Required = False
        Me.txt台紙名.Size = New System.Drawing.Size(105, 19)
        Me.txt台紙名.StringLength = 65535
        Me.txt台紙名.TabIndex = 0
        Me.txt台紙名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp台紙CD
        '
        Me.grp台紙CD.Controls.Add(Me.txt台紙CD)
        Me.grp台紙CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grp台紙CD.Location = New System.Drawing.Point(9, 70)
        Me.grp台紙CD.Name = "grp台紙CD"
        Me.grp台紙CD.Size = New System.Drawing.Size(89, 46)
        Me.grp台紙CD.TabIndex = 1
        Me.grp台紙CD.TabStop = False
        Me.grp台紙CD.Text = "台紙CD"
        '
        'txt台紙CD
        '
        Me.txt台紙CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt台紙CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.txt台紙CD.HelpKeys = ""
        Me.txt台紙CD.HelpLink = ""
        Me.txt台紙CD.HelpType = NodeUI.Help.Type.None
        Me.txt台紙CD.IsError = False
        Me.txt台紙CD.Location = New System.Drawing.Point(12, 19)
        Me.txt台紙CD.Name = "txt台紙CD"
        Me.txt台紙CD.Required = False
        Me.txt台紙CD.Size = New System.Drawing.Size(23, 19)
        Me.txt台紙CD.StringLength = 65535
        Me.txt台紙CD.TabIndex = 0
        Me.txt台紙CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grpfind
        '
        Me.grpfind.Controls.Add(Me.grp台紙名)
        Me.grpfind.Controls.Add(Me.grp台紙CD)
        Me.grpfind.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grpfind.Location = New System.Drawing.Point(287, 10)
        Me.grpfind.Name = "grpfind"
        Me.grpfind.Size = New System.Drawing.Size(161, 125)
        Me.grpfind.TabIndex = 1
        Me.grpfind.TabStop = False
        Me.grpfind.Text = "検索項目"
        '
        'dlgMount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 475)
        Me.Controls.Add(Me.grpfind)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "dlgMount"
        Me.Text = "dlgPaper"
        Me.Controls.SetChildIndex(Me.grpfind, 0)
        Me.grp台紙名.ResumeLayout(False)
        Me.grp台紙名.PerformLayout()
        Me.grp台紙CD.ResumeLayout(False)
        Me.grp台紙CD.PerformLayout()
        Me.grpfind.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp台紙名 As BaseUI.Control.GroupBox
    Friend WithEvents txt台紙名 As BaseUI.Control.TextBox
    Friend WithEvents grp台紙CD As BaseUI.Control.GroupBox
    Friend WithEvents txt台紙CD As BaseUI.Control.TextBox
    Friend WithEvents grpfind As BaseUI.Control.GroupBox
End Class
