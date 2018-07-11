<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgYamatoKind
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
        Me.grpCD = New BaseUI.Control.GroupBox()
        Me.txtヤマト種別 = New BaseUI.Control.TextBox()
        Me.grpfind = New BaseUI.Control.GroupBox()
        Me.grpヤマト区分 = New BaseUI.Control.GroupBox()
        Me.namヤマト区分名 = New BaseUI.Control.NameBox()
        Me.txtヤマト区分 = New BaseUI.Control.TextBox()
        Me.grpCD.SuspendLayout()
        Me.grpfind.SuspendLayout()
        Me.grpヤマト区分.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBoxCond
        '
        Me.GroupBoxCond.Location = New System.Drawing.Point(101, 25)
        '
        'grpCD
        '
        Me.grpCD.Controls.Add(Me.txtヤマト種別)
        Me.grpCD.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grpCD.Location = New System.Drawing.Point(10, 72)
        Me.grpCD.Name = "grpCD"
        Me.grpCD.Size = New System.Drawing.Size(72, 46)
        Me.grpCD.TabIndex = 1
        Me.grpCD.TabStop = False
        Me.grpCD.Text = "CD"
        '
        'txtヤマト種別
        '
        Me.txtヤマト種別.FieldLockType = BaseContents.Field.LockType.None
        Me.txtヤマト種別.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.txtヤマト種別.HelpKeys = ""
        Me.txtヤマト種別.HelpLink = ""
        Me.txtヤマト種別.HelpType = NodeUI.Help.Type.None
        Me.txtヤマト種別.IsError = False
        Me.txtヤマト種別.Location = New System.Drawing.Point(9, 18)
        Me.txtヤマト種別.Name = "txtヤマト種別"
        Me.txtヤマト種別.Required = False
        Me.txtヤマト種別.Size = New System.Drawing.Size(18, 19)
        Me.txtヤマト種別.StringLength = 65535
        Me.txtヤマト種別.TabIndex = 0
        Me.txtヤマト種別.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grpfind
        '
        Me.grpfind.Controls.Add(Me.grpヤマト区分)
        Me.grpfind.Controls.Add(Me.grpCD)
        Me.grpfind.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grpfind.Location = New System.Drawing.Point(352, 10)
        Me.grpfind.Name = "grpfind"
        Me.grpfind.Size = New System.Drawing.Size(320, 132)
        Me.grpfind.TabIndex = 0
        Me.grpfind.TabStop = False
        Me.grpfind.Text = "検索項目"
        '
        'grpヤマト区分
        '
        Me.grpヤマト区分.Controls.Add(Me.namヤマト区分名)
        Me.grpヤマト区分.Controls.Add(Me.txtヤマト区分)
        Me.grpヤマト区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grpヤマト区分.Location = New System.Drawing.Point(10, 19)
        Me.grpヤマト区分.Name = "grpヤマト区分"
        Me.grpヤマト区分.Size = New System.Drawing.Size(300, 46)
        Me.grpヤマト区分.TabIndex = 0
        Me.grpヤマト区分.TabStop = False
        Me.grpヤマト区分.Text = "ﾃﾞｰﾀ区分"
        '
        'namヤマト区分名
        '
        Me.namヤマト区分名.BackColor = System.Drawing.SystemColors.Control
        Me.namヤマト区分名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.namヤマト区分名.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.namヤマト区分名.Location = New System.Drawing.Point(37, 17)
        Me.namヤマト区分名.Margin = New System.Windows.Forms.Padding(3)
        Me.namヤマト区分名.Name = "namヤマト区分名"
        Me.namヤマト区分名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.namヤマト区分名.Size = New System.Drawing.Size(240, 19)
        Me.namヤマト区分名.StringLength = 65535
        Me.namヤマト区分名.TabIndex = 1
        Me.namヤマト区分名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txtヤマト区分
        '
        Me.txtヤマト区分.Enabled = False
        Me.txtヤマト区分.FieldLockType = BaseContents.Field.LockType.None
        Me.txtヤマト区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.txtヤマト区分.HelpKeys = ""
        Me.txtヤマト区分.HelpLink = ""
        Me.txtヤマト区分.HelpType = NodeUI.Help.Type.None
        Me.txtヤマト区分.IsError = False
        Me.txtヤマト区分.Location = New System.Drawing.Point(9, 17)
        Me.txtヤマト区分.Name = "txtヤマト区分"
        Me.txtヤマト区分.Required = False
        Me.txtヤマト区分.Size = New System.Drawing.Size(27, 19)
        Me.txtヤマト区分.StringLength = 65535
        Me.txtヤマト区分.TabIndex = 0
        Me.txtヤマト区分.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'dlgYamatoKind
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 475)
        Me.Controls.Add(Me.grpfind)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "dlgYamatoKind"
        Me.Text = "dlgYamatoKind"
        Me.Controls.SetChildIndex(Me.grpfind, 0)
        Me.grpCD.ResumeLayout(False)
        Me.grpCD.PerformLayout()
        Me.grpfind.ResumeLayout(False)
        Me.grpヤマト区分.ResumeLayout(False)
        Me.grpヤマト区分.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpCD As BaseUI.Control.GroupBox
    Friend WithEvents txtヤマト種別 As BaseUI.Control.TextBox
    Friend WithEvents grpfind As BaseUI.Control.GroupBox
    Friend WithEvents grpヤマト区分 As BaseUI.Control.GroupBox
    Friend WithEvents namヤマト区分名 As BaseUI.Control.NameBox
    Friend WithEvents txtヤマト区分 As BaseUI.Control.TextBox
End Class
