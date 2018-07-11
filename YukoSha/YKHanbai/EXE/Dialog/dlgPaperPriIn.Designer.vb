<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgPaperPriIn
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
        Me.grp名称 = New BaseUI.Control.GroupBox()
        Me.txt名称 = New BaseUI.Control.TextBox()
        Me.grpfind = New BaseUI.Control.GroupBox()
        Me.grp仕入先 = New BaseUI.Control.GroupBox()
        Me.btn仕入先 = New BaseUI.Control.Button()
        Me.nam仕入先名 = New BaseUI.Control.NameBox()
        Me.txt仕入先CD = New BaseUI.Control.TextBox()
        Me.grp名称.SuspendLayout()
        Me.grpfind.SuspendLayout()
        Me.grp仕入先.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxCond
        '
        Me.GroupBoxCond.Location = New System.Drawing.Point(101, 25)
        '
        'grp名称
        '
        Me.grp名称.Controls.Add(Me.txt名称)
        Me.grp名称.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grp名称.Location = New System.Drawing.Point(13, 68)
        Me.grp名称.Name = "grp名称"
        Me.grp名称.Size = New System.Drawing.Size(284, 46)
        Me.grp名称.TabIndex = 1
        Me.grp名称.TabStop = False
        Me.grp名称.Text = "絞込名称(紙･糊･台紙)"
        '
        'txt名称
        '
        Me.txt名称.FieldLockType = BaseContents.Field.LockType.None
        Me.txt名称.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.txt名称.HelpKeys = ""
        Me.txt名称.HelpLink = ""
        Me.txt名称.HelpType = NodeUI.Help.Type.None
        Me.txt名称.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt名称.IsError = False
        Me.txt名称.Location = New System.Drawing.Point(7, 18)
        Me.txt名称.Name = "txt名称"
        Me.txt名称.Required = False
        Me.txt名称.Size = New System.Drawing.Size(264, 19)
        Me.txt名称.TabIndex = 0
        Me.txt名称.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grpfind
        '
        Me.grpfind.Controls.Add(Me.grp仕入先)
        Me.grpfind.Controls.Add(Me.grp名称)
        Me.grpfind.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grpfind.Location = New System.Drawing.Point(368, 10)
        Me.grpfind.Name = "grpfind"
        Me.grpfind.Size = New System.Drawing.Size(386, 130)
        Me.grpfind.TabIndex = 1
        Me.grpfind.TabStop = False
        Me.grpfind.Text = "検索項目"
        '
        'grp仕入先
        '
        Me.grp仕入先.Controls.Add(Me.btn仕入先)
        Me.grp仕入先.Controls.Add(Me.nam仕入先名)
        Me.grp仕入先.Controls.Add(Me.txt仕入先CD)
        Me.grp仕入先.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grp仕入先.Location = New System.Drawing.Point(13, 18)
        Me.grp仕入先.Name = "grp仕入先"
        Me.grp仕入先.Size = New System.Drawing.Size(357, 46)
        Me.grp仕入先.TabIndex = 0
        Me.grp仕入先.TabStop = False
        Me.grp仕入先.Text = "仕入先CD"
        '
        'btn仕入先
        '
        Me.btn仕入先.FieldLockType = BaseContents.Field.LockType.None
        Me.btn仕入先.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn仕入先.Location = New System.Drawing.Point(269, 13)
        Me.btn仕入先.Name = "btn仕入先"
        Me.btn仕入先.Size = New System.Drawing.Size(80, 26)
        Me.btn仕入先.TabIndex = 26
        Me.btn仕入先.TabStop = False
        Me.btn仕入先.Text = "仕入先検索"
        Me.btn仕入先.UseVisualStyleBackColor = True
        '
        'nam仕入先名
        '
        Me.nam仕入先名.BackColor = System.Drawing.SystemColors.Control
        Me.nam仕入先名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam仕入先名.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.nam仕入先名.Location = New System.Drawing.Point(67, 18)
        Me.nam仕入先名.Margin = New System.Windows.Forms.Padding(3)
        Me.nam仕入先名.Name = "nam仕入先名"
        Me.nam仕入先名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.nam仕入先名.Size = New System.Drawing.Size(200, 19)
        Me.nam仕入先名.TabIndex = 1
        Me.nam仕入先名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt仕入先CD
        '
        Me.txt仕入先CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt仕入先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.txt仕入先CD.HelpKeys = ""
        Me.txt仕入先CD.HelpLink = ""
        Me.txt仕入先CD.HelpType = NodeUI.Help.Type.None
        Me.txt仕入先CD.IsError = False
        Me.txt仕入先CD.Location = New System.Drawing.Point(7, 18)
        Me.txt仕入先CD.Name = "txt仕入先CD"
        Me.txt仕入先CD.Required = False
        Me.txt仕入先CD.Size = New System.Drawing.Size(61, 19)
        Me.txt仕入先CD.TabIndex = 0
        Me.txt仕入先CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'dlgItemName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 475)
        Me.Controls.Add(Me.grpfind)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "dlgItemName"
        Me.Text = "dlgItemName"
        Me.Controls.SetChildIndex(Me.grpfind, 0)
        Me.grp名称.ResumeLayout(False)
        Me.grp名称.PerformLayout()
        Me.grpfind.ResumeLayout(False)
        Me.grp仕入先.ResumeLayout(False)
        Me.grp仕入先.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grp名称 As BaseUI.Control.GroupBox
    Friend WithEvents txt名称 As BaseUI.Control.TextBox
    Friend WithEvents grpfind As BaseUI.Control.GroupBox
    Friend WithEvents grp仕入先 As BaseUI.Control.GroupBox
    Friend WithEvents nam仕入先名 As BaseUI.Control.NameBox
    Friend WithEvents txt仕入先CD As BaseUI.Control.TextBox
    Protected WithEvents btn仕入先 As BaseUI.Control.Button
End Class
