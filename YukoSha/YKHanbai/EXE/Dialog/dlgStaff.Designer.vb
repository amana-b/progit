<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgStaff
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
        Me.grp担当者名 = New BaseUI.Control.GroupBox()
        Me.txt担当者名 = New BaseUI.Control.TextBox()
        Me.grp担当者CD = New BaseUI.Control.GroupBox()
        Me.txt担当者CD = New BaseUI.Control.TextBox()
        Me.grpfind = New BaseUI.Control.GroupBox()
        Me.grp担当者名.SuspendLayout()
        Me.grp担当者CD.SuspendLayout()
        Me.grpfind.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp担当者名
        '
        Me.grp担当者名.Controls.Add(Me.txt担当者名)
        Me.grp担当者名.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grp担当者名.Location = New System.Drawing.Point(7, 17)
        Me.grp担当者名.Name = "grp担当者名"
        Me.grp担当者名.Size = New System.Drawing.Size(143, 46)
        Me.grp担当者名.TabIndex = 0
        Me.grp担当者名.TabStop = False
        Me.grp担当者名.Text = "担当者名"
        '
        'txt担当者名
        '
        Me.txt担当者名.FieldLockType = BaseContents.Field.LockType.None
        Me.txt担当者名.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.txt担当者名.HelpKeys = ""
        Me.txt担当者名.HelpLink = ""
        Me.txt担当者名.HelpType = NodeUI.Help.Type.None
        Me.txt担当者名.IsError = False
        Me.txt担当者名.Location = New System.Drawing.Point(9, 19)
        Me.txt担当者名.Name = "txt担当者名"
        Me.txt担当者名.Required = False
        Me.txt担当者名.Size = New System.Drawing.Size(105, 19)
        Me.txt担当者名.StringLength = 65535
        Me.txt担当者名.TabIndex = 0
        Me.txt担当者名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp担当者CD
        '
        Me.grp担当者CD.Controls.Add(Me.txt担当者CD)
        Me.grp担当者CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grp担当者CD.Location = New System.Drawing.Point(7, 69)
        Me.grp担当者CD.Name = "grp担当者CD"
        Me.grp担当者CD.Size = New System.Drawing.Size(80, 46)
        Me.grp担当者CD.TabIndex = 1
        Me.grp担当者CD.TabStop = False
        Me.grp担当者CD.Text = "担当者CD"
        '
        'txt担当者CD
        '
        Me.txt担当者CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt担当者CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.txt担当者CD.HelpKeys = ""
        Me.txt担当者CD.HelpLink = ""
        Me.txt担当者CD.HelpType = NodeUI.Help.Type.None
        Me.txt担当者CD.IsError = False
        Me.txt担当者CD.Location = New System.Drawing.Point(9, 19)
        Me.txt担当者CD.Name = "txt担当者CD"
        Me.txt担当者CD.Required = False
        Me.txt担当者CD.Size = New System.Drawing.Size(30, 19)
        Me.txt担当者CD.StringLength = 65535
        Me.txt担当者CD.TabIndex = 0
        Me.txt担当者CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grpfind
        '
        Me.grpfind.Controls.Add(Me.grp担当者名)
        Me.grpfind.Controls.Add(Me.grp担当者CD)
        Me.grpfind.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grpfind.Location = New System.Drawing.Point(287, 10)
        Me.grpfind.Name = "grpfind"
        Me.grpfind.Size = New System.Drawing.Size(165, 124)
        Me.grpfind.TabIndex = 1
        Me.grpfind.TabStop = False
        Me.grpfind.Text = "検索項目"
        '
        'dlgStaff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 475)
        Me.Controls.Add(Me.grpfind)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "dlgStaff"
        Me.Text = "dlgMachine"
        Me.Controls.SetChildIndex(Me.grpfind, 0)
        Me.grp担当者名.ResumeLayout(False)
        Me.grp担当者名.PerformLayout()
        Me.grp担当者CD.ResumeLayout(False)
        Me.grp担当者CD.PerformLayout()
        Me.grpfind.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp担当者名 As BaseUI.Control.GroupBox
    Friend WithEvents txt担当者名 As BaseUI.Control.TextBox
    Friend WithEvents grp担当者CD As BaseUI.Control.GroupBox
    Friend WithEvents txt担当者CD As BaseUI.Control.TextBox
    Friend WithEvents grpfind As BaseUI.Control.GroupBox
End Class
