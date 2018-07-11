<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgBillDDInfo
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
        Me.grp締日 = New BaseUI.Control.GroupBox()
        Me.txt締日 = New BaseUI.Control.TextBox()
        Me.grpfind = New BaseUI.Control.GroupBox()
        Me.grp締日.SuspendLayout()
        Me.grpfind.SuspendLayout()
        Me.SuspendLayout()
        '
        'grp締日
        '
        Me.grp締日.Controls.Add(Me.txt締日)
        Me.grp締日.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grp締日.Location = New System.Drawing.Point(8, 17)
        Me.grp締日.Name = "grp締日"
        Me.grp締日.Size = New System.Drawing.Size(66, 46)
        Me.grp締日.TabIndex = 12
        Me.grp締日.TabStop = False
        Me.grp締日.Text = "締日"
        '
        'txt締日
        '
        Me.txt締日.FieldLockType = BaseContents.Field.LockType.None
        Me.txt締日.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.txt締日.HelpKeys = ""
        Me.txt締日.HelpLink = ""
        Me.txt締日.HelpType = NodeUI.Help.Type.None
        Me.txt締日.IsError = False
        Me.txt締日.Location = New System.Drawing.Point(11, 17)
        Me.txt締日.Name = "txt締日"
        Me.txt締日.Required = False
        Me.txt締日.Size = New System.Drawing.Size(23, 19)
        Me.txt締日.StringLength = 65535
        Me.txt締日.TabIndex = 4
        Me.txt締日.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt締日.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grpfind
        '
        Me.grpfind.Controls.Add(Me.grp締日)
        Me.grpfind.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grpfind.Location = New System.Drawing.Point(287, 10)
        Me.grpfind.Name = "grpfind"
        Me.grpfind.Size = New System.Drawing.Size(109, 70)
        Me.grpfind.TabIndex = 27
        Me.grpfind.TabStop = False
        Me.grpfind.Text = "検索項目"
        '
        'dlgBillDDInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 475)
        Me.Controls.Add(Me.grpfind)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "dlgBillDDInfo"
        Me.Text = "dlgPaste"
        Me.Controls.SetChildIndex(Me.grpfind, 0)
        Me.grp締日.ResumeLayout(False)
        Me.grp締日.PerformLayout()
        Me.grpfind.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp締日 As BaseUI.Control.GroupBox
    Friend WithEvents txt締日 As BaseUI.Control.TextBox
    Friend WithEvents grpfind As BaseUI.Control.GroupBox
End Class
