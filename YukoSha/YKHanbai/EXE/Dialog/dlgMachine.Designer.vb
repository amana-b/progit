<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgMachine
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
        Me.grp機械CD = New BaseUI.Control.GroupBox()
        Me.txt機械CD = New BaseUI.Control.TextBox()
        Me.grpfind = New BaseUI.Control.GroupBox()
        Me.grp機械CD.SuspendLayout()
        Me.grpfind.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp機械CD
        '
        Me.grp機械CD.Controls.Add(Me.txt機械CD)
        Me.grp機械CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grp機械CD.Location = New System.Drawing.Point(8, 16)
        Me.grp機械CD.Name = "grp機械CD"
        Me.grp機械CD.Size = New System.Drawing.Size(87, 46)
        Me.grp機械CD.TabIndex = 0
        Me.grp機械CD.TabStop = False
        Me.grp機械CD.Text = "機械CD"
        '
        'txt機械CD
        '
        Me.txt機械CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt機械CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.txt機械CD.HelpKeys = ""
        Me.txt機械CD.HelpLink = ""
        Me.txt機械CD.HelpType = NodeUI.Help.Type.None
        Me.txt機械CD.IsError = False
        Me.txt機械CD.Location = New System.Drawing.Point(8, 18)
        Me.txt機械CD.Name = "txt機械CD"
        Me.txt機械CD.Required = False
        Me.txt機械CD.Size = New System.Drawing.Size(52, 19)
        Me.txt機械CD.StringLength = 65535
        Me.txt機械CD.TabIndex = 0
        Me.txt機械CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grpfind
        '
        Me.grpfind.Controls.Add(Me.grp機械CD)
        Me.grpfind.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grpfind.Location = New System.Drawing.Point(287, 10)
        Me.grpfind.Name = "grpfind"
        Me.grpfind.Size = New System.Drawing.Size(117, 71)
        Me.grpfind.TabIndex = 1
        Me.grpfind.TabStop = False
        Me.grpfind.Text = "検索項目"
        '
        'dlgMachine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 475)
        Me.Controls.Add(Me.grpfind)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "dlgMachine"
        Me.Text = "dlgMachine"
        Me.Controls.SetChildIndex(Me.grpfind, 0)
        Me.grp機械CD.ResumeLayout(False)
        Me.grp機械CD.PerformLayout()
        Me.grpfind.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp機械CD As BaseUI.Control.GroupBox
    Friend WithEvents txt機械CD As BaseUI.Control.TextBox
    Friend WithEvents grpfind As BaseUI.Control.GroupBox
End Class
