<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgPaste
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
        Me.grp糊名 = New BaseUI.Control.GroupBox()
        Me.txt糊名 = New BaseUI.Control.TextBox()
        Me.grp糊CD = New BaseUI.Control.GroupBox()
        Me.txt糊CD = New BaseUI.Control.TextBox()
        Me.grpfind = New BaseUI.Control.GroupBox()
        Me.grp糊名.SuspendLayout()
        Me.grp糊CD.SuspendLayout()
        Me.grpfind.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxCond
        '
        Me.GroupBoxCond.Location = New System.Drawing.Point(101, 25)
        '
        'grp糊名
        '
        Me.grp糊名.Controls.Add(Me.txt糊名)
        Me.grp糊名.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grp糊名.Location = New System.Drawing.Point(8, 19)
        Me.grp糊名.Name = "grp糊名"
        Me.grp糊名.Size = New System.Drawing.Size(143, 46)
        Me.grp糊名.TabIndex = 0
        Me.grp糊名.TabStop = False
        Me.grp糊名.Text = "糊名"
        '
        'txt糊名
        '
        Me.txt糊名.FieldLockType = BaseContents.Field.LockType.None
        Me.txt糊名.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.txt糊名.HelpKeys = ""
        Me.txt糊名.HelpLink = ""
        Me.txt糊名.HelpType = NodeUI.Help.Type.None
        Me.txt糊名.IsError = False
        Me.txt糊名.Location = New System.Drawing.Point(9, 18)
        Me.txt糊名.Name = "txt糊名"
        Me.txt糊名.Required = False
        Me.txt糊名.Size = New System.Drawing.Size(105, 19)
        Me.txt糊名.TabIndex = 0
        Me.txt糊名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp糊CD
        '
        Me.grp糊CD.Controls.Add(Me.txt糊CD)
        Me.grp糊CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grp糊CD.Location = New System.Drawing.Point(8, 72)
        Me.grp糊CD.Name = "grp糊CD"
        Me.grp糊CD.Size = New System.Drawing.Size(89, 46)
        Me.grp糊CD.TabIndex = 1
        Me.grp糊CD.TabStop = False
        Me.grp糊CD.Text = "糊CD"
        '
        'txt糊CD
        '
        Me.txt糊CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt糊CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.txt糊CD.HelpKeys = ""
        Me.txt糊CD.HelpLink = ""
        Me.txt糊CD.HelpType = NodeUI.Help.Type.None
        Me.txt糊CD.IsError = False
        Me.txt糊CD.Location = New System.Drawing.Point(9, 17)
        Me.txt糊CD.Name = "txt糊CD"
        Me.txt糊CD.Required = False
        Me.txt糊CD.Size = New System.Drawing.Size(30, 19)
        Me.txt糊CD.TabIndex = 0
        Me.txt糊CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grpfind
        '
        Me.grpfind.Controls.Add(Me.grp糊名)
        Me.grpfind.Controls.Add(Me.grp糊CD)
        Me.grpfind.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grpfind.Location = New System.Drawing.Point(287, 10)
        Me.grpfind.Name = "grpfind"
        Me.grpfind.Size = New System.Drawing.Size(162, 132)
        Me.grpfind.TabIndex = 1
        Me.grpfind.TabStop = False
        Me.grpfind.Text = "検索項目"
        '
        'dlgPaste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 475)
        Me.Controls.Add(Me.grpfind)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "dlgPaste"
        Me.Text = "dlgPaste"
        Me.Controls.SetChildIndex(Me.grpfind, 0)
        Me.grp糊名.ResumeLayout(False)
        Me.grp糊名.PerformLayout()
        Me.grp糊CD.ResumeLayout(False)
        Me.grp糊CD.PerformLayout()
        Me.grpfind.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grp糊名 As BaseUI.Control.GroupBox
    Friend WithEvents txt糊名 As BaseUI.Control.TextBox
    Friend WithEvents grp糊CD As BaseUI.Control.GroupBox
    Friend WithEvents txt糊CD As BaseUI.Control.TextBox
    Friend WithEvents grpfind As BaseUI.Control.GroupBox
End Class
