<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgPrintLoc
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
        Me.grp印刷場所CD = New BaseUI.Control.GroupBox()
        Me.txt印刷場所CD = New BaseUI.Control.TextBox()
        Me.grpfind = New BaseUI.Control.GroupBox()
        Me.grp印刷場所CD.SuspendLayout()
        Me.grpfind.SuspendLayout()
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
        'grp印刷場所CD
        '
        Me.grp印刷場所CD.Controls.Add(Me.txt印刷場所CD)
        Me.grp印刷場所CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grp印刷場所CD.Location = New System.Drawing.Point(8, 18)
        Me.grp印刷場所CD.Name = "grp印刷場所CD"
        Me.grp印刷場所CD.Size = New System.Drawing.Size(90, 46)
        Me.grp印刷場所CD.TabIndex = 0
        Me.grp印刷場所CD.TabStop = False
        Me.grp印刷場所CD.Text = "印刷場所CD"
        '
        'txt印刷場所CD
        '
        Me.txt印刷場所CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt印刷場所CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.txt印刷場所CD.HelpKeys = ""
        Me.txt印刷場所CD.HelpLink = ""
        Me.txt印刷場所CD.HelpType = NodeUI.Help.Type.None
        Me.txt印刷場所CD.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt印刷場所CD.IsError = False
        Me.txt印刷場所CD.Location = New System.Drawing.Point(9, 18)
        Me.txt印刷場所CD.Name = "txt印刷場所CD"
        Me.txt印刷場所CD.Required = False
        Me.txt印刷場所CD.Size = New System.Drawing.Size(25, 19)
        Me.txt印刷場所CD.StringLength = 65535
        Me.txt印刷場所CD.TabIndex = 0
        Me.txt印刷場所CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grpfind
        '
        Me.grpfind.Controls.Add(Me.grp印刷場所CD)
        Me.grpfind.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grpfind.Location = New System.Drawing.Point(287, 10)
        Me.grpfind.Name = "grpfind"
        Me.grpfind.Size = New System.Drawing.Size(113, 75)
        Me.grpfind.TabIndex = 1
        Me.grpfind.TabStop = False
        Me.grpfind.Text = "検索項目"
        '
        'dlgPrintLoc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 475)
        Me.Controls.Add(Me.grpfind)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "dlgPrintLoc"
        Me.Text = "dlgPaper"
        Me.Controls.SetChildIndex(Me.grpfind, 0)
        Me.grp印刷場所CD.ResumeLayout(False)
        Me.grp印刷場所CD.PerformLayout()
        Me.grpfind.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp印刷場所CD As BaseUI.Control.GroupBox
    Friend WithEvents txt印刷場所CD As BaseUI.Control.TextBox
    Friend WithEvents grpfind As BaseUI.Control.GroupBox
End Class
