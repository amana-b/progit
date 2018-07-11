<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgType2
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
        Me.grp小分類CD = New BaseUI.Control.GroupBox()
        Me.txt小分類CD = New BaseUI.Control.TextBox()
        Me.grpfind = New BaseUI.Control.GroupBox()
        Me.grp小分類CD.SuspendLayout()
        Me.grpfind.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp小分類CD
        '
        Me.grp小分類CD.Controls.Add(Me.txt小分類CD)
        Me.grp小分類CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grp小分類CD.Location = New System.Drawing.Point(8, 16)
        Me.grp小分類CD.Name = "grp小分類CD"
        Me.grp小分類CD.Size = New System.Drawing.Size(87, 46)
        Me.grp小分類CD.TabIndex = 0
        Me.grp小分類CD.TabStop = False
        Me.grp小分類CD.Text = "小分類CD"
        '
        'txt小分類CD
        '
        Me.txt小分類CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt小分類CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.txt小分類CD.HelpKeys = ""
        Me.txt小分類CD.HelpLink = ""
        Me.txt小分類CD.HelpType = NodeUI.Help.Type.None
        Me.txt小分類CD.IsError = False
        Me.txt小分類CD.Location = New System.Drawing.Point(8, 18)
        Me.txt小分類CD.Name = "txt小分類CD"
        Me.txt小分類CD.Required = False
        Me.txt小分類CD.Size = New System.Drawing.Size(52, 19)
        Me.txt小分類CD.StringLength = 65535
        Me.txt小分類CD.TabIndex = 0
        Me.txt小分類CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grpfind
        '
        Me.grpfind.Controls.Add(Me.grp小分類CD)
        Me.grpfind.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grpfind.Location = New System.Drawing.Point(287, 10)
        Me.grpfind.Name = "grpfind"
        Me.grpfind.Size = New System.Drawing.Size(117, 71)
        Me.grpfind.TabIndex = 1
        Me.grpfind.TabStop = False
        Me.grpfind.Text = "検索項目"
        '
        'dlgType2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 475)
        Me.Controls.Add(Me.grpfind)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "dlgType2"
        Me.Text = "dlgMachine"
        Me.Controls.SetChildIndex(Me.grpfind, 0)
        Me.grp小分類CD.ResumeLayout(False)
        Me.grp小分類CD.PerformLayout()
        Me.grpfind.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp小分類CD As BaseUI.Control.GroupBox
    Friend WithEvents txt小分類CD As BaseUI.Control.TextBox
    Friend WithEvents grpfind As BaseUI.Control.GroupBox
End Class
