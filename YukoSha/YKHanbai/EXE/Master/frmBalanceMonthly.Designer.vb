<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBalanceMonthly
    Inherits BaseUI.BaseForm

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
        Me.grp内訳 = New BaseUI.Control.GroupBox()
        Me.grp月次残高 = New BaseUI.Control.GroupBox()
        Me.txt月次残高 = New BaseUI.Control.TextBox()
        Me.grp月次日付 = New BaseUI.Control.GroupBox()
        Me.txt月次年月 = New BaseUI.Control.TextBox()
        Me.grdDetall = New BaseUI.Control.GridInput()
        Me.grp取引先 = New BaseUI.Control.GroupBox()
        Me.lbl締日 = New BaseUI.Control.Label()
        Me.txt取引先CD = New BaseUI.Control.TextBox()
        Me.nam締日 = New BaseUI.Control.NameBox()
        Me.nam取引先名 = New BaseUI.Control.NameBox()
        Me.grp取引先区分 = New BaseUI.Control.GroupBox()
        Me.ddl取引先区分 = New BaseUI.Control.ComboBox()
        Me.grp内訳.SuspendLayout()
        Me.grp月次残高.SuspendLayout()
        Me.grp月次日付.SuspendLayout()
        CType(Me.grdDetall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp取引先.SuspendLayout()
        Me.grp取引先区分.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnESC
        '
        Me.btnESC.Text = "閉じる"
        '
        'grp内訳
        '
        Me.grp内訳.Controls.Add(Me.grp月次残高)
        Me.grp内訳.Controls.Add(Me.grp月次日付)
        Me.grp内訳.Controls.Add(Me.grdDetall)
        Me.grp内訳.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp内訳.Location = New System.Drawing.Point(28, 91)
        Me.grp内訳.Name = "grp内訳"
        Me.grp内訳.Size = New System.Drawing.Size(506, 545)
        Me.grp内訳.TabIndex = 2
        Me.grp内訳.TabStop = False
        Me.grp内訳.Text = "内訳"
        '
        'grp月次残高
        '
        Me.grp月次残高.Controls.Add(Me.txt月次残高)
        Me.grp月次残高.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp月次残高.Location = New System.Drawing.Point(225, 472)
        Me.grp月次残高.Name = "grp月次残高"
        Me.grp月次残高.Size = New System.Drawing.Size(193, 61)
        Me.grp月次残高.TabIndex = 2
        Me.grp月次残高.TabStop = False
        Me.grp月次残高.Text = "確定済月末残高"
        '
        'txt月次残高
        '
        Me.txt月次残高.FieldLockType = BaseContents.Field.LockType.None
        Me.txt月次残高.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt月次残高.HelpKeys = ""
        Me.txt月次残高.HelpLink = ""
        Me.txt月次残高.HelpType = NodeUI.Help.Type.None
        Me.txt月次残高.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt月次残高.IsError = False
        Me.txt月次残高.Location = New System.Drawing.Point(27, 25)
        Me.txt月次残高.Name = "txt月次残高"
        Me.txt月次残高.Required = False
        Me.txt月次残高.Size = New System.Drawing.Size(127, 23)
        Me.txt月次残高.StringLength = 65535
        Me.txt月次残高.TabIndex = 0
        Me.txt月次残高.Text = "12,345,678,901"
        Me.txt月次残高.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp月次日付
        '
        Me.grp月次日付.Controls.Add(Me.txt月次年月)
        Me.grp月次日付.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp月次日付.Location = New System.Drawing.Point(16, 472)
        Me.grp月次日付.Name = "grp月次日付"
        Me.grp月次日付.Size = New System.Drawing.Size(195, 61)
        Me.grp月次日付.TabIndex = 1
        Me.grp月次日付.TabStop = False
        Me.grp月次日付.Text = "確定済対象年月"
        '
        'txt月次年月
        '
        Me.txt月次年月.FieldLockType = BaseContents.Field.LockType.None
        Me.txt月次年月.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt月次年月.HelpKeys = ""
        Me.txt月次年月.HelpLink = ""
        Me.txt月次年月.HelpType = NodeUI.Help.Type.None
        Me.txt月次年月.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt月次年月.IsError = False
        Me.txt月次年月.Location = New System.Drawing.Point(48, 25)
        Me.txt月次年月.Name = "txt月次年月"
        Me.txt月次年月.Required = False
        Me.txt月次年月.Size = New System.Drawing.Size(91, 23)
        Me.txt月次年月.StringLength = 65535
        Me.txt月次年月.TabIndex = 0
        Me.txt月次年月.Text = "YYYY/MM"
        Me.txt月次年月.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grdDetall
        '
        Me.grdDetall.AllowUserToAddRows = False
        Me.grdDetall.AllowUserToResizeRows = False
        Me.grdDetall.ButtonDelete = Nothing
        Me.grdDetall.ButtonInsert = Nothing
        Me.grdDetall.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdDetall.FieldLockType = BaseContents.Field.LockType.None
        Me.grdDetall.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grdDetall.IsError = False
        Me.grdDetall.Location = New System.Drawing.Point(16, 22)
        Me.grdDetall.MultiSelect = False
        Me.grdDetall.Name = "grdDetall"
        Me.grdDetall.Required = False
        Me.grdDetall.RowHeadersVisible = False
        Me.grdDetall.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdDetall.Size = New System.Drawing.Size(432, 444)
        Me.grdDetall.TabIndex = 0
        Me.grdDetall.TextBoxAddBtm = Nothing
        Me.grdDetall.TextBoxAddTop = Nothing
        '
        'grp取引先
        '
        Me.grp取引先.Controls.Add(Me.lbl締日)
        Me.grp取引先.Controls.Add(Me.txt取引先CD)
        Me.grp取引先.Controls.Add(Me.nam締日)
        Me.grp取引先.Controls.Add(Me.nam取引先名)
        Me.grp取引先.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp取引先.Location = New System.Drawing.Point(233, 5)
        Me.grp取引先.Name = "grp取引先"
        Me.grp取引先.Size = New System.Drawing.Size(508, 73)
        Me.grp取引先.TabIndex = 1
        Me.grp取引先.TabStop = False
        Me.grp取引先.Text = "得意先又は仕入先"
        '
        'lbl締日
        '
        Me.lbl締日.AutoSize = True
        Me.lbl締日.Enabled = False
        Me.lbl締日.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.0!)
        Me.lbl締日.Location = New System.Drawing.Point(363, 29)
        Me.lbl締日.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl締日.Name = "lbl締日"
        Me.lbl締日.Size = New System.Drawing.Size(39, 15)
        Me.lbl締日.TabIndex = 2
        Me.lbl締日.Text = "締日"
        '
        'txt取引先CD
        '
        Me.txt取引先CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt取引先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt取引先CD.HelpKeys = ""
        Me.txt取引先CD.HelpLink = ""
        Me.txt取引先CD.HelpType = NodeUI.Help.Type.None
        Me.txt取引先CD.IsError = False
        Me.txt取引先CD.Location = New System.Drawing.Point(23, 25)
        Me.txt取引先CD.Name = "txt取引先CD"
        Me.txt取引先CD.Required = False
        Me.txt取引先CD.Size = New System.Drawing.Size(61, 23)
        Me.txt取引先CD.StringLength = 65535
        Me.txt取引先CD.TabIndex = 0
        Me.txt取引先CD.Text = "123456"
        Me.txt取引先CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam締日
        '
        Me.nam締日.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam締日.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam締日.Location = New System.Drawing.Point(405, 25)
        Me.nam締日.Name = "nam締日"
        Me.nam締日.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam締日.Size = New System.Drawing.Size(61, 23)
        Me.nam締日.StringLength = 65535
        Me.nam締日.TabIndex = 3
        Me.nam締日.Text = "99日締"
        Me.nam締日.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam締日.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam取引先名
        '
        Me.nam取引先名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam取引先名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam取引先名.Location = New System.Drawing.Point(86, 25)
        Me.nam取引先名.Name = "nam取引先名"
        Me.nam取引先名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam取引先名.Size = New System.Drawing.Size(270, 23)
        Me.nam取引先名.StringLength = 65535
        Me.nam取引先名.TabIndex = 1
        Me.nam取引先名.Text = "*XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX*"
        Me.nam取引先名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp取引先区分
        '
        Me.grp取引先区分.Controls.Add(Me.ddl取引先区分)
        Me.grp取引先区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp取引先区分.Location = New System.Drawing.Point(28, 5)
        Me.grp取引先区分.Name = "grp取引先区分"
        Me.grp取引先区分.Size = New System.Drawing.Size(130, 73)
        Me.grp取引先区分.TabIndex = 0
        Me.grp取引先区分.TabStop = False
        Me.grp取引先区分.Text = "取引先区分"
        '
        'ddl取引先区分
        '
        Me.ddl取引先区分.AutoDropDown = True
        Me.ddl取引先区分.DisplayMember = "Display"
        Me.ddl取引先区分.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddl取引先区分.FieldLockType = BaseContents.Field.LockType.None
        Me.ddl取引先区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.ddl取引先区分.FormattingEnabled = True
        Me.ddl取引先区分.IsError = False
        Me.ddl取引先区分.ListType = NodeUI.List.Type.None
        Me.ddl取引先区分.Location = New System.Drawing.Point(10, 24)
        Me.ddl取引先区分.Name = "ddl取引先区分"
        Me.ddl取引先区分.Required = True
        Me.ddl取引先区分.Size = New System.Drawing.Size(100, 24)
        Me.ddl取引先区分.TabIndex = 0
        Me.ddl取引先区分.ValueMember = "Value"
        '
        'frmBalanceMonthly
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.grp取引先区分)
        Me.Controls.Add(Me.grp内訳)
        Me.Controls.Add(Me.grp取引先)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmBalanceMonthly"
        Me.Controls.SetChildIndex(Me.grp取引先, 0)
        Me.Controls.SetChildIndex(Me.grp内訳, 0)
        Me.Controls.SetChildIndex(Me.grp取引先区分, 0)
        Me.grp内訳.ResumeLayout(False)
        Me.grp月次残高.ResumeLayout(False)
        Me.grp月次残高.PerformLayout()
        Me.grp月次日付.ResumeLayout(False)
        Me.grp月次日付.PerformLayout()
        CType(Me.grdDetall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp取引先.ResumeLayout(False)
        Me.grp取引先.PerformLayout()
        Me.grp取引先区分.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp内訳 As BaseUI.Control.GroupBox
    Friend WithEvents grp月次残高 As BaseUI.Control.GroupBox
    Friend WithEvents txt月次残高 As BaseUI.Control.TextBox
    Friend WithEvents grp月次日付 As BaseUI.Control.GroupBox
    Friend WithEvents txt月次年月 As BaseUI.Control.TextBox
    Friend WithEvents grdDetall As BaseUI.Control.GridInput
    Friend WithEvents grp取引先 As BaseUI.Control.GroupBox
    Friend WithEvents lbl締日 As BaseUI.Control.Label
    Friend WithEvents txt取引先CD As BaseUI.Control.TextBox
    Friend WithEvents nam締日 As BaseUI.Control.NameBox
    Friend WithEvents nam取引先名 As BaseUI.Control.NameBox
    Friend WithEvents grp取引先区分 As BaseUI.Control.GroupBox
    Friend WithEvents ddl取引先区分 As BaseUI.Control.ComboBox

End Class
