<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgPaper
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
        Me.grp紙名 = New BaseUI.Control.GroupBox()
        Me.txt紙名 = New BaseUI.Control.TextBox()
        Me.grp紙CD = New BaseUI.Control.GroupBox()
        Me.txt紙CD = New BaseUI.Control.TextBox()
        Me.grpfind = New BaseUI.Control.GroupBox()
        Me.GroupBox1 = New BaseUI.Control.GroupBox()
        Me.opt全て = New BaseUI.Control.RadioButton()
        Me.opt紙その他 = New BaseUI.Control.RadioButton()
        Me.opt箔 = New BaseUI.Control.RadioButton()
        Me.optオーバーコード = New BaseUI.Control.RadioButton()
        Me.opt紙 = New BaseUI.Control.RadioButton()
        Me.grp紙名.SuspendLayout()
        Me.grp紙CD.SuspendLayout()
        Me.grpfind.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxCond
        '
        Me.GroupBoxCond.Location = New System.Drawing.Point(101, 25)
        '
        'grp紙名
        '
        Me.grp紙名.Controls.Add(Me.txt紙名)
        Me.grp紙名.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grp紙名.Location = New System.Drawing.Point(8, 153)
        Me.grp紙名.Name = "grp紙名"
        Me.grp紙名.Size = New System.Drawing.Size(143, 54)
        Me.grp紙名.TabIndex = 1
        Me.grp紙名.TabStop = False
        Me.grp紙名.Text = "紙名"
        '
        'txt紙名
        '
        Me.txt紙名.FieldLockType = BaseContents.Field.LockType.None
        Me.txt紙名.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.txt紙名.HelpKeys = ""
        Me.txt紙名.HelpLink = ""
        Me.txt紙名.HelpType = NodeUI.Help.Type.None
        Me.txt紙名.IsError = False
        Me.txt紙名.Location = New System.Drawing.Point(10, 21)
        Me.txt紙名.Name = "txt紙名"
        Me.txt紙名.Required = False
        Me.txt紙名.Size = New System.Drawing.Size(105, 19)
        Me.txt紙名.TabIndex = 0
        Me.txt紙名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp紙CD
        '
        Me.grp紙CD.Controls.Add(Me.txt紙CD)
        Me.grp紙CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grp紙CD.Location = New System.Drawing.Point(8, 216)
        Me.grp紙CD.Name = "grp紙CD"
        Me.grp紙CD.Size = New System.Drawing.Size(89, 54)
        Me.grp紙CD.TabIndex = 2
        Me.grp紙CD.TabStop = False
        Me.grp紙CD.Text = "紙CD"
        '
        'txt紙CD
        '
        Me.txt紙CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt紙CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.txt紙CD.HelpKeys = ""
        Me.txt紙CD.HelpLink = ""
        Me.txt紙CD.HelpType = NodeUI.Help.Type.None
        Me.txt紙CD.IsError = False
        Me.txt紙CD.Location = New System.Drawing.Point(10, 19)
        Me.txt紙CD.Name = "txt紙CD"
        Me.txt紙CD.Required = False
        Me.txt紙CD.Size = New System.Drawing.Size(38, 19)
        Me.txt紙CD.TabIndex = 0
        Me.txt紙CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grpfind
        '
        Me.grpfind.Controls.Add(Me.GroupBox1)
        Me.grpfind.Controls.Add(Me.grp紙名)
        Me.grpfind.Controls.Add(Me.grp紙CD)
        Me.grpfind.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grpfind.Location = New System.Drawing.Point(287, 10)
        Me.grpfind.Name = "grpfind"
        Me.grpfind.Size = New System.Drawing.Size(184, 282)
        Me.grpfind.TabIndex = 1
        Me.grpfind.TabStop = False
        Me.grpfind.Text = "検索項目"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.opt全て)
        Me.GroupBox1.Controls.Add(Me.opt紙その他)
        Me.GroupBox1.Controls.Add(Me.opt箔)
        Me.GroupBox1.Controls.Add(Me.optオーバーコード)
        Me.GroupBox1.Controls.Add(Me.opt紙)
        Me.GroupBox1.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 18)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(143, 132)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "紙名"
        '
        'opt全て
        '
        Me.opt全て.AutoSize = True
        Me.opt全て.Checked = True
        Me.opt全て.FieldLockType = BaseContents.Field.LockType.None
        Me.opt全て.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.opt全て.IsError = False
        Me.opt全て.Location = New System.Drawing.Point(10, 106)
        Me.opt全て.Name = "opt全て"
        Me.opt全て.Required = False
        Me.opt全て.Size = New System.Drawing.Size(47, 16)
        Me.opt全て.TabIndex = 4
        Me.opt全て.TabStop = True
        Me.opt全て.Text = "全て"
        Me.opt全て.UseVisualStyleBackColor = True
        '
        'opt紙その他
        '
        Me.opt紙その他.AutoSize = True
        Me.opt紙その他.FieldLockType = BaseContents.Field.LockType.None
        Me.opt紙その他.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.opt紙その他.IsError = False
        Me.opt紙その他.Location = New System.Drawing.Point(10, 84)
        Me.opt紙その他.Name = "opt紙その他"
        Me.opt紙その他.Required = False
        Me.opt紙その他.Size = New System.Drawing.Size(95, 16)
        Me.opt紙その他.TabIndex = 3
        Me.opt紙その他.Text = "紙その他のみ"
        Me.opt紙その他.UseVisualStyleBackColor = True
        '
        'opt箔
        '
        Me.opt箔.AutoSize = True
        Me.opt箔.FieldLockType = BaseContents.Field.LockType.None
        Me.opt箔.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.opt箔.IsError = False
        Me.opt箔.Location = New System.Drawing.Point(10, 62)
        Me.opt箔.Name = "opt箔"
        Me.opt箔.Required = False
        Me.opt箔.Size = New System.Drawing.Size(59, 16)
        Me.opt箔.TabIndex = 2
        Me.opt箔.Text = "箔のみ"
        Me.opt箔.UseVisualStyleBackColor = True
        '
        'optオーバーコード
        '
        Me.optオーバーコード.AutoSize = True
        Me.optオーバーコード.FieldLockType = BaseContents.Field.LockType.None
        Me.optオーバーコード.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.optオーバーコード.IsError = False
        Me.optオーバーコード.Location = New System.Drawing.Point(10, 40)
        Me.optオーバーコード.Name = "optオーバーコード"
        Me.optオーバーコード.Required = False
        Me.optオーバーコード.Size = New System.Drawing.Size(101, 16)
        Me.optオーバーコード.TabIndex = 1
        Me.optオーバーコード.Text = "ｵｰﾊﾞｰｺｰﾄﾞのみ"
        Me.optオーバーコード.UseVisualStyleBackColor = True
        '
        'opt紙
        '
        Me.opt紙.AutoSize = True
        Me.opt紙.FieldLockType = BaseContents.Field.LockType.None
        Me.opt紙.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.opt紙.IsError = False
        Me.opt紙.Location = New System.Drawing.Point(10, 18)
        Me.opt紙.Name = "opt紙"
        Me.opt紙.Required = False
        Me.opt紙.Size = New System.Drawing.Size(59, 16)
        Me.opt紙.TabIndex = 0
        Me.opt紙.Text = "紙のみ"
        Me.opt紙.UseVisualStyleBackColor = True
        '
        'dlgPaper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(494, 475)
        Me.Controls.Add(Me.grpfind)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "dlgPaper"
        Me.Text = "dlgPaper"
        Me.Controls.SetChildIndex(Me.grpfind, 0)
        Me.grp紙名.ResumeLayout(False)
        Me.grp紙名.PerformLayout()
        Me.grp紙CD.ResumeLayout(False)
        Me.grp紙CD.PerformLayout()
        Me.grpfind.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grp紙名 As BaseUI.Control.GroupBox
    Friend WithEvents txt紙名 As BaseUI.Control.TextBox
    Friend WithEvents grp紙CD As BaseUI.Control.GroupBox
    Friend WithEvents txt紙CD As BaseUI.Control.TextBox
    Friend WithEvents grpfind As BaseUI.Control.GroupBox
    Friend WithEvents GroupBox1 As BaseUI.Control.GroupBox
    Friend WithEvents opt全て As BaseUI.Control.RadioButton
    Friend WithEvents opt紙その他 As BaseUI.Control.RadioButton
    Friend WithEvents opt箔 As BaseUI.Control.RadioButton
    Friend WithEvents optオーバーコード As BaseUI.Control.RadioButton
    Friend WithEvents opt紙 As BaseUI.Control.RadioButton
End Class
