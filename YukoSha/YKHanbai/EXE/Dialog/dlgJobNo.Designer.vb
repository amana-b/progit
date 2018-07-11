<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgJobNo
    Inherits System.Windows.Forms.Form

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
        Me.grp得意先 = New BaseUI.Control.GroupBox()
        Me.btn得意先 = New BaseUI.Control.Button()
        Me.nam得意先名 = New BaseUI.Control.NameBox()
        Me.txt得意先CD = New BaseUI.Control.TextBox()
        Me.grpFunc = New BaseUI.Control.GroupBox()
        Me.lblESC = New BaseUI.Control.Label()
        Me.btnESC = New BaseUI.Control.Button()
        Me.lblF12 = New BaseUI.Control.Label()
        Me.btnF12 = New BaseUI.Control.Button()
        Me.grp受注日 = New BaseUI.Control.GroupBox()
        Me.txt受注日付T = New BaseUI.Control.TextBox()
        Me.lbl受注日付 = New BaseUI.Control.Label()
        Me.txt受注日付F = New BaseUI.Control.TextBox()
        Me.grp表示区分 = New BaseUI.Control.GroupBox()
        Me.opt再販 = New BaseUI.Control.RadioButton()
        Me.opt新版 = New BaseUI.Control.RadioButton()
        Me.opt両方 = New BaseUI.Control.RadioButton()
        Me.grp顧客商品 = New BaseUI.Control.GroupBox()
        Me.txt顧客商品 = New BaseUI.Control.TextBox()
        Me.btn検索 = New BaseUI.Control.Button()
        Me.grp商品名 = New BaseUI.Control.GroupBox()
        Me.txt商品名 = New BaseUI.Control.TextBox()
        Me.grp受注区分 = New BaseUI.Control.GroupBox()
        Me.ddl受注区分 = New BaseUI.Control.ComboBox()
        Me.grdView = New BaseUI.Control.GridView()
        Me.grp得意先.SuspendLayout()
        Me.grpFunc.SuspendLayout()
        Me.grp受注日.SuspendLayout()
        Me.grp表示区分.SuspendLayout()
        Me.grp顧客商品.SuspendLayout()
        Me.grp商品名.SuspendLayout()
        Me.grp受注区分.SuspendLayout()
        CType(Me.grdView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grp得意先
        '
        Me.grp得意先.Controls.Add(Me.btn得意先)
        Me.grp得意先.Controls.Add(Me.nam得意先名)
        Me.grp得意先.Controls.Add(Me.txt得意先CD)
        Me.grp得意先.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grp得意先.Location = New System.Drawing.Point(6, 2)
        Me.grp得意先.Name = "grp得意先"
        Me.grp得意先.Size = New System.Drawing.Size(360, 45)
        Me.grp得意先.TabIndex = 3
        Me.grp得意先.TabStop = False
        Me.grp得意先.Text = "得意先ｺｰﾄﾞ"
        '
        'btn得意先
        '
        Me.btn得意先.FieldLockType = BaseContents.Field.LockType.None
        Me.btn得意先.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn得意先.Location = New System.Drawing.Point(264, 13)
        Me.btn得意先.Name = "btn得意先"
        Me.btn得意先.Size = New System.Drawing.Size(80, 26)
        Me.btn得意先.TabIndex = 24
        Me.btn得意先.TabStop = False
        Me.btn得意先.Text = "得意先検索"
        Me.btn得意先.UseVisualStyleBackColor = True
        '
        'nam得意先名
        '
        Me.nam得意先名.BackColor = System.Drawing.SystemColors.Control
        Me.nam得意先名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam得意先名.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.nam得意先名.Location = New System.Drawing.Point(58, 16)
        Me.nam得意先名.Margin = New System.Windows.Forms.Padding(3)
        Me.nam得意先名.Name = "nam得意先名"
        Me.nam得意先名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.nam得意先名.Size = New System.Drawing.Size(200, 19)
        Me.nam得意先名.StringLength = 65535
        Me.nam得意先名.TabIndex = 1
        Me.nam得意先名.Text = "ああああああああああいいいいいい"
        Me.nam得意先名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt得意先CD
        '
        Me.txt得意先CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt得意先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.txt得意先CD.HelpKeys = ""
        Me.txt得意先CD.HelpLink = ""
        Me.txt得意先CD.HelpType = NodeUI.Help.Type.None
        Me.txt得意先CD.IsError = False
        Me.txt得意先CD.Location = New System.Drawing.Point(10, 16)
        Me.txt得意先CD.Name = "txt得意先CD"
        Me.txt得意先CD.Required = False
        Me.txt得意先CD.Size = New System.Drawing.Size(46, 19)
        Me.txt得意先CD.StringLength = 65535
        Me.txt得意先CD.TabIndex = 0
        Me.txt得意先CD.Text = "999999"
        Me.txt得意先CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grpFunc
        '
        Me.grpFunc.Controls.Add(Me.lblESC)
        Me.grpFunc.Controls.Add(Me.btnESC)
        Me.grpFunc.Controls.Add(Me.lblF12)
        Me.grpFunc.Controls.Add(Me.btnF12)
        Me.grpFunc.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grpFunc.Location = New System.Drawing.Point(768, 482)
        Me.grpFunc.Name = "grpFunc"
        Me.grpFunc.Size = New System.Drawing.Size(147, 74)
        Me.grpFunc.TabIndex = 26
        Me.grpFunc.TabStop = False
        '
        'lblESC
        '
        Me.lblESC.AutoSize = True
        Me.lblESC.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblESC.Location = New System.Drawing.Point(18, 51)
        Me.lblESC.Name = "lblESC"
        Me.lblESC.Size = New System.Drawing.Size(41, 12)
        Me.lblESC.TabIndex = 24
        Me.lblESC.Text = "「ESC]"
        '
        'btnESC
        '
        Me.btnESC.FieldLockType = BaseContents.Field.LockType.None
        Me.btnESC.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnESC.Location = New System.Drawing.Point(9, 12)
        Me.btnESC.Name = "btnESC"
        Me.btnESC.Size = New System.Drawing.Size(60, 34)
        Me.btnESC.TabIndex = 23
        Me.btnESC.TabStop = False
        Me.btnESC.Text = "戻る"
        Me.btnESC.UseVisualStyleBackColor = True
        '
        'lblF12
        '
        Me.lblF12.AutoSize = True
        Me.lblF12.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblF12.Location = New System.Drawing.Point(93, 51)
        Me.lblF12.Name = "lblF12"
        Me.lblF12.Size = New System.Drawing.Size(35, 12)
        Me.lblF12.TabIndex = 22
        Me.lblF12.Text = "[F12]"
        '
        'btnF12
        '
        Me.btnF12.FieldLockType = BaseContents.Field.LockType.None
        Me.btnF12.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnF12.Location = New System.Drawing.Point(78, 12)
        Me.btnF12.Name = "btnF12"
        Me.btnF12.Size = New System.Drawing.Size(60, 34)
        Me.btnF12.TabIndex = 21
        Me.btnF12.TabStop = False
        Me.btnF12.Text = "決定"
        Me.btnF12.UseVisualStyleBackColor = True
        '
        'grp受注日
        '
        Me.grp受注日.Controls.Add(Me.txt受注日付T)
        Me.grp受注日.Controls.Add(Me.lbl受注日付)
        Me.grp受注日.Controls.Add(Me.txt受注日付F)
        Me.grp受注日.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grp受注日.Location = New System.Drawing.Point(372, 2)
        Me.grp受注日.Name = "grp受注日"
        Me.grp受注日.Size = New System.Drawing.Size(190, 45)
        Me.grp受注日.TabIndex = 25
        Me.grp受注日.TabStop = False
        Me.grp受注日.Text = "受注日"
        '
        'txt受注日付T
        '
        Me.txt受注日付T.FieldLockType = BaseContents.Field.LockType.None
        Me.txt受注日付T.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.txt受注日付T.HelpKeys = ""
        Me.txt受注日付T.HelpLink = ""
        Me.txt受注日付T.HelpType = NodeUI.Help.Type.None
        Me.txt受注日付T.IsError = False
        Me.txt受注日付T.Location = New System.Drawing.Point(105, 16)
        Me.txt受注日付T.Name = "txt受注日付T"
        Me.txt受注日付T.Required = False
        Me.txt受注日付T.Size = New System.Drawing.Size(70, 19)
        Me.txt受注日付T.StringLength = 65535
        Me.txt受注日付T.TabIndex = 26
        Me.txt受注日付T.Text = "yyyy/mm/dd"
        Me.txt受注日付T.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'lbl受注日付
        '
        Me.lbl受注日付.AutoSize = True
        Me.lbl受注日付.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lbl受注日付.Location = New System.Drawing.Point(84, 19)
        Me.lbl受注日付.Name = "lbl受注日付"
        Me.lbl受注日付.Size = New System.Drawing.Size(17, 12)
        Me.lbl受注日付.TabIndex = 25
        Me.lbl受注日付.Text = "～"
        '
        'txt受注日付F
        '
        Me.txt受注日付F.FieldLockType = BaseContents.Field.LockType.None
        Me.txt受注日付F.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.txt受注日付F.HelpKeys = ""
        Me.txt受注日付F.HelpLink = ""
        Me.txt受注日付F.HelpType = NodeUI.Help.Type.None
        Me.txt受注日付F.IsError = False
        Me.txt受注日付F.Location = New System.Drawing.Point(10, 16)
        Me.txt受注日付F.Name = "txt受注日付F"
        Me.txt受注日付F.Required = False
        Me.txt受注日付F.Size = New System.Drawing.Size(70, 19)
        Me.txt受注日付F.StringLength = 65535
        Me.txt受注日付F.TabIndex = 0
        Me.txt受注日付F.Text = "yyyy/mm/dd"
        Me.txt受注日付F.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp表示区分
        '
        Me.grp表示区分.Controls.Add(Me.opt再販)
        Me.grp表示区分.Controls.Add(Me.opt新版)
        Me.grp表示区分.Controls.Add(Me.opt両方)
        Me.grp表示区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grp表示区分.Location = New System.Drawing.Point(568, 2)
        Me.grp表示区分.Name = "grp表示区分"
        Me.grp表示区分.Size = New System.Drawing.Size(248, 45)
        Me.grp表示区分.TabIndex = 27
        Me.grp表示区分.TabStop = False
        Me.grp表示区分.Text = "表示区分"
        '
        'opt再販
        '
        Me.opt再販.AutoSize = True
        Me.opt再販.FieldLockType = BaseContents.Field.LockType.None
        Me.opt再販.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.opt再販.IsError = False
        Me.opt再販.Location = New System.Drawing.Point(164, 19)
        Me.opt再販.Name = "opt再販"
        Me.opt再販.Required = False
        Me.opt再販.Size = New System.Drawing.Size(71, 16)
        Me.opt再販.TabIndex = 4
        Me.opt再販.Text = "再販のみ"
        Me.opt再販.UseVisualStyleBackColor = True
        '
        'opt新版
        '
        Me.opt新版.AutoSize = True
        Me.opt新版.FieldLockType = BaseContents.Field.LockType.None
        Me.opt新版.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.opt新版.IsError = False
        Me.opt新版.Location = New System.Drawing.Point(78, 19)
        Me.opt新版.Name = "opt新版"
        Me.opt新版.Required = False
        Me.opt新版.Size = New System.Drawing.Size(71, 16)
        Me.opt新版.TabIndex = 3
        Me.opt新版.Text = "新版のみ"
        Me.opt新版.UseVisualStyleBackColor = True
        '
        'opt両方
        '
        Me.opt両方.AutoSize = True
        Me.opt両方.FieldLockType = BaseContents.Field.LockType.None
        Me.opt両方.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.opt両方.IsError = False
        Me.opt両方.Location = New System.Drawing.Point(14, 19)
        Me.opt両方.Name = "opt両方"
        Me.opt両方.Required = False
        Me.opt両方.Size = New System.Drawing.Size(47, 16)
        Me.opt両方.TabIndex = 2
        Me.opt両方.Text = "両方"
        Me.opt両方.UseVisualStyleBackColor = True
        '
        'grp顧客商品
        '
        Me.grp顧客商品.Controls.Add(Me.txt顧客商品)
        Me.grp顧客商品.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grp顧客商品.Location = New System.Drawing.Point(6, 53)
        Me.grp顧客商品.Name = "grp顧客商品"
        Me.grp顧客商品.Size = New System.Drawing.Size(131, 45)
        Me.grp顧客商品.TabIndex = 28
        Me.grp顧客商品.TabStop = False
        Me.grp顧客商品.Text = "顧客商品ｺｰﾄﾞ"
        '
        'txt顧客商品
        '
        Me.txt顧客商品.FieldLockType = BaseContents.Field.LockType.None
        Me.txt顧客商品.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.txt顧客商品.HelpKeys = ""
        Me.txt顧客商品.HelpLink = ""
        Me.txt顧客商品.HelpType = NodeUI.Help.Type.None
        Me.txt顧客商品.IsError = False
        Me.txt顧客商品.Location = New System.Drawing.Point(10, 16)
        Me.txt顧客商品.Name = "txt顧客商品"
        Me.txt顧客商品.Required = False
        Me.txt顧客商品.Size = New System.Drawing.Size(110, 19)
        Me.txt顧客商品.StringLength = 65535
        Me.txt顧客商品.TabIndex = 0
        Me.txt顧客商品.Text = "12345678901234567"
        Me.txt顧客商品.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'btn検索
        '
        Me.btn検索.FieldLockType = BaseContents.Field.LockType.None
        Me.btn検索.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btn検索.Location = New System.Drawing.Point(533, 58)
        Me.btn検索.Name = "btn検索"
        Me.btn検索.Size = New System.Drawing.Size(141, 42)
        Me.btn検索.TabIndex = 29
        Me.btn検索.TabStop = False
        Me.btn検索.Text = "検 索 開 始"
        Me.btn検索.UseVisualStyleBackColor = True
        '
        'grp商品名
        '
        Me.grp商品名.Controls.Add(Me.txt商品名)
        Me.grp商品名.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grp商品名.Location = New System.Drawing.Point(143, 53)
        Me.grp商品名.Name = "grp商品名"
        Me.grp商品名.Size = New System.Drawing.Size(223, 45)
        Me.grp商品名.TabIndex = 30
        Me.grp商品名.TabStop = False
        Me.grp商品名.Text = "商品名(代表)"
        '
        'txt商品名
        '
        Me.txt商品名.FieldLockType = BaseContents.Field.LockType.None
        Me.txt商品名.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.txt商品名.HelpKeys = ""
        Me.txt商品名.HelpLink = ""
        Me.txt商品名.HelpType = NodeUI.Help.Type.None
        Me.txt商品名.IsError = False
        Me.txt商品名.Location = New System.Drawing.Point(10, 16)
        Me.txt商品名.Name = "txt商品名"
        Me.txt商品名.Required = False
        Me.txt商品名.Size = New System.Drawing.Size(200, 19)
        Me.txt商品名.StringLength = 65535
        Me.txt商品名.TabIndex = 0
        Me.txt商品名.Text = "ああああああああああいいいいいい"
        Me.txt商品名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp受注区分
        '
        Me.grp受注区分.Controls.Add(Me.ddl受注区分)
        Me.grp受注区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grp受注区分.Location = New System.Drawing.Point(372, 53)
        Me.grp受注区分.Name = "grp受注区分"
        Me.grp受注区分.Size = New System.Drawing.Size(155, 47)
        Me.grp受注区分.TabIndex = 31
        Me.grp受注区分.TabStop = False
        Me.grp受注区分.Text = "受注区分"
        '
        'ddl受注区分
        '
        Me.ddl受注区分.AutoDropDown = True
        Me.ddl受注区分.DisplayMember = "Display"
        Me.ddl受注区分.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddl受注区分.FieldLockType = BaseContents.Field.LockType.None
        Me.ddl受注区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.ddl受注区分.FormattingEnabled = True
        Me.ddl受注区分.IsError = False
        Me.ddl受注区分.ListType = NodeUI.List.Type.None
        Me.ddl受注区分.Location = New System.Drawing.Point(9, 15)
        Me.ddl受注区分.Name = "ddl受注区分"
        Me.ddl受注区分.Required = False
        Me.ddl受注区分.Size = New System.Drawing.Size(137, 20)
        Me.ddl受注区分.TabIndex = 1
        Me.ddl受注区分.ValueMember = "Value"
        '
        'grdView
        '
        Me.grdView.AllowUserToAddRows = False
        Me.grdView.AllowUserToDeleteRows = False
        Me.grdView.AllowUserToResizeRows = False
        Me.grdView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdView.DataKeyNames = ""
        Me.grdView.FieldLockType = BaseContents.Field.LockType.None
        Me.grdView.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grdView.IsError = False
        Me.grdView.Location = New System.Drawing.Point(6, 105)
        Me.grdView.Name = "grdView"
        Me.grdView.Required = False
        Me.grdView.RowTemplate.Height = 21
        Me.grdView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdView.Size = New System.Drawing.Size(756, 452)
        Me.grdView.TabIndex = 32
        '
        'dlgJobNo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(927, 569)
        Me.Controls.Add(Me.grdView)
        Me.Controls.Add(Me.grp受注区分)
        Me.Controls.Add(Me.grp商品名)
        Me.Controls.Add(Me.btn検索)
        Me.Controls.Add(Me.grp顧客商品)
        Me.Controls.Add(Me.grp表示区分)
        Me.Controls.Add(Me.grp受注日)
        Me.Controls.Add(Me.grpFunc)
        Me.Controls.Add(Me.grp得意先)
        Me.Name = "dlgJobNo"
        Me.Text = "dlgJobNo"
        Me.grp得意先.ResumeLayout(False)
        Me.grp得意先.PerformLayout()
        Me.grpFunc.ResumeLayout(False)
        Me.grpFunc.PerformLayout()
        Me.grp受注日.ResumeLayout(False)
        Me.grp受注日.PerformLayout()
        Me.grp表示区分.ResumeLayout(False)
        Me.grp表示区分.PerformLayout()
        Me.grp顧客商品.ResumeLayout(False)
        Me.grp顧客商品.PerformLayout()
        Me.grp商品名.ResumeLayout(False)
        Me.grp商品名.PerformLayout()
        Me.grp受注区分.ResumeLayout(False)
        CType(Me.grdView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp得意先 As BaseUI.Control.GroupBox
    Friend WithEvents nam得意先名 As BaseUI.Control.NameBox
    Friend WithEvents txt得意先CD As BaseUI.Control.TextBox
    Friend WithEvents grpFunc As BaseUI.Control.GroupBox
    Friend WithEvents lblESC As BaseUI.Control.Label
    Protected WithEvents btnESC As BaseUI.Control.Button
    Friend WithEvents lblF12 As BaseUI.Control.Label
    Protected WithEvents btnF12 As BaseUI.Control.Button
    Protected WithEvents btn得意先 As BaseUI.Control.Button
    Friend WithEvents grp受注日 As BaseUI.Control.GroupBox
    Friend WithEvents txt受注日付F As BaseUI.Control.TextBox
    Friend WithEvents txt受注日付T As BaseUI.Control.TextBox
    Friend WithEvents lbl受注日付 As BaseUI.Control.Label
    Friend WithEvents grp表示区分 As BaseUI.Control.GroupBox
    Friend WithEvents opt再販 As BaseUI.Control.RadioButton
    Friend WithEvents opt新版 As BaseUI.Control.RadioButton
    Friend WithEvents opt両方 As BaseUI.Control.RadioButton
    Friend WithEvents grp顧客商品 As BaseUI.Control.GroupBox
    Friend WithEvents txt顧客商品 As BaseUI.Control.TextBox
    Protected WithEvents btn検索 As BaseUI.Control.Button
    Friend WithEvents grp商品名 As BaseUI.Control.GroupBox
    Friend WithEvents txt商品名 As BaseUI.Control.TextBox
    Friend WithEvents grp受注区分 As BaseUI.Control.GroupBox
    Friend WithEvents ddl受注区分 As BaseUI.Control.ComboBox
    Friend WithEvents grdView As BaseUI.Control.GridView
End Class
