<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgPrintType
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
        Me.grp印刷機械種別名 = New BaseUI.Control.GroupBox()
        Me.txt印刷機械種別名 = New BaseUI.Control.TextBox()
        Me.grp印刷機械種別CD = New BaseUI.Control.GroupBox()
        Me.txt印刷機械種別CD = New BaseUI.Control.TextBox()
        Me.grpfind = New BaseUI.Control.GroupBox()
        Me.grp印刷機械種別名.SuspendLayout()
        Me.grp印刷機械種別CD.SuspendLayout()
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
        'grp印刷機械種別名
        '
        Me.grp印刷機械種別名.Controls.Add(Me.txt印刷機械種別名)
        Me.grp印刷機械種別名.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grp印刷機械種別名.Location = New System.Drawing.Point(7, 18)
        Me.grp印刷機械種別名.Name = "grp印刷機械種別名"
        Me.grp印刷機械種別名.Size = New System.Drawing.Size(123, 46)
        Me.grp印刷機械種別名.TabIndex = 13
        Me.grp印刷機械種別名.TabStop = False
        Me.grp印刷機械種別名.Text = "印刷機械種別名"
        '
        'txt印刷機械種別名
        '
        Me.txt印刷機械種別名.FieldLockType = BaseContents.Field.LockType.None
        Me.txt印刷機械種別名.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.txt印刷機械種別名.HelpKeys = ""
        Me.txt印刷機械種別名.HelpLink = ""
        Me.txt印刷機械種別名.HelpType = NodeUI.Help.Type.None
        Me.txt印刷機械種別名.IsError = False
        Me.txt印刷機械種別名.Location = New System.Drawing.Point(9, 17)
        Me.txt印刷機械種別名.Name = "txt印刷機械種別名"
        Me.txt印刷機械種別名.Required = False
        Me.txt印刷機械種別名.Size = New System.Drawing.Size(105, 19)
        Me.txt印刷機械種別名.StringLength = 65535
        Me.txt印刷機械種別名.TabIndex = 0
        Me.txt印刷機械種別名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp印刷機械種別CD
        '
        Me.grp印刷機械種別CD.Controls.Add(Me.txt印刷機械種別CD)
        Me.grp印刷機械種別CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grp印刷機械種別CD.Location = New System.Drawing.Point(7, 71)
        Me.grp印刷機械種別CD.Name = "grp印刷機械種別CD"
        Me.grp印刷機械種別CD.Size = New System.Drawing.Size(123, 46)
        Me.grp印刷機械種別CD.TabIndex = 12
        Me.grp印刷機械種別CD.TabStop = False
        Me.grp印刷機械種別CD.Text = "印刷機械種別CD"
        '
        'txt印刷機械種別CD
        '
        Me.txt印刷機械種別CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt印刷機械種別CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.txt印刷機械種別CD.HelpKeys = ""
        Me.txt印刷機械種別CD.HelpLink = ""
        Me.txt印刷機械種別CD.HelpType = NodeUI.Help.Type.None
        Me.txt印刷機械種別CD.ImeMode = System.Windows.Forms.ImeMode.Disable
        Me.txt印刷機械種別CD.IsError = False
        Me.txt印刷機械種別CD.Location = New System.Drawing.Point(9, 17)
        Me.txt印刷機械種別CD.Name = "txt印刷機械種別CD"
        Me.txt印刷機械種別CD.Required = False
        Me.txt印刷機械種別CD.Size = New System.Drawing.Size(25, 19)
        Me.txt印刷機械種別CD.StringLength = 65535
        Me.txt印刷機械種別CD.TabIndex = 0
        Me.txt印刷機械種別CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grpfind
        '
        Me.grpfind.Controls.Add(Me.grp印刷機械種別名)
        Me.grpfind.Controls.Add(Me.grp印刷機械種別CD)
        Me.grpfind.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grpfind.Location = New System.Drawing.Point(287, 10)
        Me.grpfind.Name = "grpfind"
        Me.grpfind.Size = New System.Drawing.Size(142, 125)
        Me.grpfind.TabIndex = 27
        Me.grpfind.TabStop = False
        Me.grpfind.Text = "検索項目"
        '
        'dlgPrintType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 475)
        Me.Controls.Add(Me.grpfind)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "dlgPrintType"
        Me.Text = ""
        Me.Controls.SetChildIndex(Me.grpfind, 0)
        Me.grp印刷機械種別名.ResumeLayout(False)
        Me.grp印刷機械種別名.PerformLayout()
        Me.grp印刷機械種別CD.ResumeLayout(False)
        Me.grp印刷機械種別CD.PerformLayout()
        Me.grpfind.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp印刷機械種別名 As BaseUI.Control.GroupBox
    Friend WithEvents txt印刷機械種別名 As BaseUI.Control.TextBox
    Friend WithEvents grp印刷機械種別CD As BaseUI.Control.GroupBox
    Friend WithEvents txt印刷機械種別CD As BaseUI.Control.TextBox
    Friend WithEvents grpfind As BaseUI.Control.GroupBox
End Class
