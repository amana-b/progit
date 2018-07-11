<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaperPriIn
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
        Me.grp処理区分 = New BaseUI.Control.GroupBox()
        Me.opt削除 = New BaseUI.Control.RadioButton()
        Me.opt修正 = New BaseUI.Control.RadioButton()
        Me.opt登録 = New BaseUI.Control.RadioButton()
        Me.grp仕入先CD = New BaseUI.Control.GroupBox()
        Me.nam仕入先名 = New BaseUI.Control.NameBox()
        Me.txt仕入先CD = New BaseUI.Control.TextBox()
        Me.grp単価区分 = New BaseUI.Control.GroupBox()
        Me.ddl単価区分 = New BaseUI.Control.ComboBox()
        Me.grp発注用 = New BaseUI.Control.GroupBox()
        Me.grp発注用台紙 = New BaseUI.Control.GroupBox()
        Me.txt発注用台紙CD = New BaseUI.Control.TextBox()
        Me.nam発注用台紙名 = New BaseUI.Control.NameBox()
        Me.grp発注用糊 = New BaseUI.Control.GroupBox()
        Me.txt発注用糊CD = New BaseUI.Control.TextBox()
        Me.nam発注用糊名 = New BaseUI.Control.NameBox()
        Me.grp発注用紙 = New BaseUI.Control.GroupBox()
        Me.txt発注用紙CD = New BaseUI.Control.TextBox()
        Me.nam発注用紙名 = New BaseUI.Control.NameBox()
        Me.grp社内単価 = New BaseUI.Control.GroupBox()
        Me.txt社内単価 = New BaseUI.Control.TextBox()
        Me.grp発注単価 = New BaseUI.Control.GroupBox()
        Me.txt発注単価 = New BaseUI.Control.TextBox()
        Me.grp社内用紙 = New BaseUI.Control.GroupBox()
        Me.txt社内用紙CD = New BaseUI.Control.TextBox()
        Me.nam社内用紙名 = New BaseUI.Control.NameBox()
        Me.grp社内用糊CD = New BaseUI.Control.GroupBox()
        Me.txt社内用糊CD = New BaseUI.Control.TextBox()
        Me.nam社内用糊名 = New BaseUI.Control.NameBox()
        Me.grp社内用台紙 = New BaseUI.Control.GroupBox()
        Me.txt社内用台紙CD = New BaseUI.Control.TextBox()
        Me.nam社内用台紙名 = New BaseUI.Control.NameBox()
        Me.grp社内用 = New BaseUI.Control.GroupBox()
        Me.grp処理区分.SuspendLayout()
        Me.grp仕入先CD.SuspendLayout()
        Me.grp単価区分.SuspendLayout()
        Me.grp発注用.SuspendLayout()
        Me.grp発注用台紙.SuspendLayout()
        Me.grp発注用糊.SuspendLayout()
        Me.grp発注用紙.SuspendLayout()
        Me.grp社内単価.SuspendLayout()
        Me.grp発注単価.SuspendLayout()
        Me.grp社内用紙.SuspendLayout()
        Me.grp社内用糊CD.SuspendLayout()
        Me.grp社内用台紙.SuspendLayout()
        Me.grp社内用.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnESC
        '
        Me.btnESC.Text = "閉じる"
        '
        'grp処理区分
        '
        Me.grp処理区分.Controls.Add(Me.opt削除)
        Me.grp処理区分.Controls.Add(Me.opt修正)
        Me.grp処理区分.Controls.Add(Me.opt登録)
        Me.grp処理区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp処理区分.Location = New System.Drawing.Point(90, 22)
        Me.grp処理区分.Name = "grp処理区分"
        Me.grp処理区分.Size = New System.Drawing.Size(267, 61)
        Me.grp処理区分.TabIndex = 0
        Me.grp処理区分.TabStop = False
        Me.grp処理区分.Text = "処理区分"
        '
        'opt削除
        '
        Me.opt削除.AutoSize = True
        Me.opt削除.FieldLockType = BaseContents.Field.LockType.None
        Me.opt削除.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.opt削除.IsError = False
        Me.opt削除.Location = New System.Drawing.Point(197, 27)
        Me.opt削除.Name = "opt削除"
        Me.opt削除.Required = False
        Me.opt削除.Size = New System.Drawing.Size(58, 20)
        Me.opt削除.TabIndex = 2
        Me.opt削除.Text = "削除"
        Me.opt削除.UseVisualStyleBackColor = True
        '
        'opt修正
        '
        Me.opt修正.AutoSize = True
        Me.opt修正.FieldLockType = BaseContents.Field.LockType.None
        Me.opt修正.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.opt修正.IsError = False
        Me.opt修正.Location = New System.Drawing.Point(108, 27)
        Me.opt修正.Name = "opt修正"
        Me.opt修正.Required = False
        Me.opt修正.Size = New System.Drawing.Size(58, 20)
        Me.opt修正.TabIndex = 1
        Me.opt修正.Text = "修正"
        Me.opt修正.UseVisualStyleBackColor = True
        '
        'opt登録
        '
        Me.opt登録.AutoSize = True
        Me.opt登録.FieldLockType = BaseContents.Field.LockType.None
        Me.opt登録.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.opt登録.IsError = False
        Me.opt登録.Location = New System.Drawing.Point(19, 27)
        Me.opt登録.Name = "opt登録"
        Me.opt登録.Required = False
        Me.opt登録.Size = New System.Drawing.Size(58, 20)
        Me.opt登録.TabIndex = 0
        Me.opt登録.Text = "登録"
        Me.opt登録.UseVisualStyleBackColor = True
        '
        'grp仕入先CD
        '
        Me.grp仕入先CD.Controls.Add(Me.nam仕入先名)
        Me.grp仕入先CD.Controls.Add(Me.txt仕入先CD)
        Me.grp仕入先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp仕入先CD.Location = New System.Drawing.Point(90, 108)
        Me.grp仕入先CD.Name = "grp仕入先CD"
        Me.grp仕入先CD.Size = New System.Drawing.Size(255, 61)
        Me.grp仕入先CD.TabIndex = 1
        Me.grp仕入先CD.TabStop = False
        Me.grp仕入先CD.Text = "仕入先コード"
        '
        'nam仕入先名
        '
        Me.nam仕入先名.BackColor = System.Drawing.SystemColors.Control
        Me.nam仕入先名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam仕入先名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam仕入先名.Location = New System.Drawing.Point(68, 25)
        Me.nam仕入先名.Margin = New System.Windows.Forms.Padding(3)
        Me.nam仕入先名.Name = "nam仕入先名"
        Me.nam仕入先名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.nam仕入先名.Size = New System.Drawing.Size(163, 23)
        Me.nam仕入先名.TabIndex = 1
        Me.nam仕入先名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt仕入先CD
        '
        Me.txt仕入先CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt仕入先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt仕入先CD.HelpKeys = ""
        Me.txt仕入先CD.HelpLink = ""
        Me.txt仕入先CD.HelpType = NodeUI.Help.Type.None
        Me.txt仕入先CD.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt仕入先CD.IsError = False
        Me.txt仕入先CD.Location = New System.Drawing.Point(10, 25)
        Me.txt仕入先CD.Name = "txt仕入先CD"
        Me.txt仕入先CD.Required = False
        Me.txt仕入先CD.Size = New System.Drawing.Size(57, 23)
        Me.txt仕入先CD.TabIndex = 0
        Me.txt仕入先CD.Text = "999999"
        Me.txt仕入先CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp単価区分
        '
        Me.grp単価区分.Controls.Add(Me.ddl単価区分)
        Me.grp単価区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp単価区分.Location = New System.Drawing.Point(90, 494)
        Me.grp単価区分.Name = "grp単価区分"
        Me.grp単価区分.Size = New System.Drawing.Size(224, 61)
        Me.grp単価区分.TabIndex = 3
        Me.grp単価区分.TabStop = False
        Me.grp単価区分.Text = "単価区分"
        '
        'ddl単価区分
        '
        Me.ddl単価区分.AutoDropDown = True
        Me.ddl単価区分.DisplayMember = "Display"
        Me.ddl単価区分.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddl単価区分.FieldLockType = BaseContents.Field.LockType.None
        Me.ddl単価区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.ddl単価区分.FormattingEnabled = True
        Me.ddl単価区分.IsError = False
        Me.ddl単価区分.ListType = NodeUI.List.Type.None
        Me.ddl単価区分.Location = New System.Drawing.Point(26, 26)
        Me.ddl単価区分.Name = "ddl単価区分"
        Me.ddl単価区分.Required = False
        Me.ddl単価区分.Size = New System.Drawing.Size(176, 24)
        Me.ddl単価区分.TabIndex = 0
        Me.ddl単価区分.ValueMember = "Value"
        '
        'grp発注用
        '
        Me.grp発注用.Controls.Add(Me.grp発注用台紙)
        Me.grp発注用.Controls.Add(Me.grp発注用糊)
        Me.grp発注用.Controls.Add(Me.grp発注用紙)
        Me.grp発注用.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp発注用.Location = New System.Drawing.Point(379, 192)
        Me.grp発注用.Name = "grp発注用"
        Me.grp発注用.Size = New System.Drawing.Size(274, 269)
        Me.grp発注用.TabIndex = 4
        Me.grp発注用.TabStop = False
        Me.grp発注用.Text = "発注用"
        '
        'grp発注用台紙
        '
        Me.grp発注用台紙.Controls.Add(Me.txt発注用台紙CD)
        Me.grp発注用台紙.Controls.Add(Me.nam発注用台紙名)
        Me.grp発注用台紙.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp発注用台紙.Location = New System.Drawing.Point(23, 190)
        Me.grp発注用台紙.Name = "grp発注用台紙"
        Me.grp発注用台紙.Size = New System.Drawing.Size(166, 61)
        Me.grp発注用台紙.TabIndex = 2
        Me.grp発注用台紙.TabStop = False
        Me.grp発注用台紙.Text = "台紙コード"
        '
        'txt発注用台紙CD
        '
        Me.txt発注用台紙CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt発注用台紙CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt発注用台紙CD.HelpKeys = ""
        Me.txt発注用台紙CD.HelpLink = ""
        Me.txt発注用台紙CD.HelpType = NodeUI.Help.Type.None
        Me.txt発注用台紙CD.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt発注用台紙CD.IsError = False
        Me.txt発注用台紙CD.Location = New System.Drawing.Point(30, 27)
        Me.txt発注用台紙CD.Name = "txt発注用台紙CD"
        Me.txt発注用台紙CD.Required = False
        Me.txt発注用台紙CD.Size = New System.Drawing.Size(25, 23)
        Me.txt発注用台紙CD.TabIndex = 0
        Me.txt発注用台紙CD.Text = "99"
        Me.txt発注用台紙CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam発注用台紙名
        '
        Me.nam発注用台紙名.BackColor = System.Drawing.SystemColors.Control
        Me.nam発注用台紙名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam発注用台紙名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam発注用台紙名.Location = New System.Drawing.Point(56, 27)
        Me.nam発注用台紙名.Margin = New System.Windows.Forms.Padding(3)
        Me.nam発注用台紙名.Name = "nam発注用台紙名"
        Me.nam発注用台紙名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.nam発注用台紙名.Size = New System.Drawing.Size(104, 23)
        Me.nam発注用台紙名.TabIndex = 1
        Me.nam発注用台紙名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp発注用糊
        '
        Me.grp発注用糊.Controls.Add(Me.txt発注用糊CD)
        Me.grp発注用糊.Controls.Add(Me.nam発注用糊名)
        Me.grp発注用糊.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp発注用糊.Location = New System.Drawing.Point(23, 123)
        Me.grp発注用糊.Name = "grp発注用糊"
        Me.grp発注用糊.Size = New System.Drawing.Size(166, 61)
        Me.grp発注用糊.TabIndex = 1
        Me.grp発注用糊.TabStop = False
        Me.grp発注用糊.Text = "糊コード"
        '
        'txt発注用糊CD
        '
        Me.txt発注用糊CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt発注用糊CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt発注用糊CD.HelpKeys = ""
        Me.txt発注用糊CD.HelpLink = ""
        Me.txt発注用糊CD.HelpType = NodeUI.Help.Type.None
        Me.txt発注用糊CD.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt発注用糊CD.IsError = False
        Me.txt発注用糊CD.Location = New System.Drawing.Point(24, 27)
        Me.txt発注用糊CD.Name = "txt発注用糊CD"
        Me.txt発注用糊CD.Required = False
        Me.txt発注用糊CD.Size = New System.Drawing.Size(31, 23)
        Me.txt発注用糊CD.TabIndex = 0
        Me.txt発注用糊CD.Text = "999"
        Me.txt発注用糊CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam発注用糊名
        '
        Me.nam発注用糊名.BackColor = System.Drawing.SystemColors.Control
        Me.nam発注用糊名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam発注用糊名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam発注用糊名.Location = New System.Drawing.Point(56, 27)
        Me.nam発注用糊名.Margin = New System.Windows.Forms.Padding(3)
        Me.nam発注用糊名.Name = "nam発注用糊名"
        Me.nam発注用糊名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.nam発注用糊名.Size = New System.Drawing.Size(104, 23)
        Me.nam発注用糊名.TabIndex = 1
        Me.nam発注用糊名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp発注用紙
        '
        Me.grp発注用紙.Controls.Add(Me.txt発注用紙CD)
        Me.grp発注用紙.Controls.Add(Me.nam発注用紙名)
        Me.grp発注用紙.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp発注用紙.Location = New System.Drawing.Point(23, 40)
        Me.grp発注用紙.Name = "grp発注用紙"
        Me.grp発注用紙.Size = New System.Drawing.Size(166, 61)
        Me.grp発注用紙.TabIndex = 0
        Me.grp発注用紙.TabStop = False
        Me.grp発注用紙.Text = "紙コード"
        '
        'txt発注用紙CD
        '
        Me.txt発注用紙CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt発注用紙CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt発注用紙CD.HelpKeys = ""
        Me.txt発注用紙CD.HelpLink = ""
        Me.txt発注用紙CD.HelpType = NodeUI.Help.Type.None
        Me.txt発注用紙CD.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt発注用紙CD.IsError = False
        Me.txt発注用紙CD.Location = New System.Drawing.Point(17, 27)
        Me.txt発注用紙CD.Name = "txt発注用紙CD"
        Me.txt発注用紙CD.Required = False
        Me.txt発注用紙CD.Size = New System.Drawing.Size(38, 23)
        Me.txt発注用紙CD.TabIndex = 0
        Me.txt発注用紙CD.Text = "9999"
        Me.txt発注用紙CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam発注用紙名
        '
        Me.nam発注用紙名.BackColor = System.Drawing.SystemColors.Control
        Me.nam発注用紙名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam発注用紙名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam発注用紙名.Location = New System.Drawing.Point(56, 27)
        Me.nam発注用紙名.Margin = New System.Windows.Forms.Padding(3)
        Me.nam発注用紙名.Name = "nam発注用紙名"
        Me.nam発注用紙名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.nam発注用紙名.Size = New System.Drawing.Size(104, 23)
        Me.nam発注用紙名.TabIndex = 1
        Me.nam発注用紙名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp社内単価
        '
        Me.grp社内単価.Controls.Add(Me.txt社内単価)
        Me.grp社内単価.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp社内単価.Location = New System.Drawing.Point(379, 494)
        Me.grp社内単価.Name = "grp社内単価"
        Me.grp社内単価.Size = New System.Drawing.Size(128, 61)
        Me.grp社内単価.TabIndex = 5
        Me.grp社内単価.TabStop = False
        Me.grp社内単価.Text = "社内単価"
        '
        'txt社内単価
        '
        Me.txt社内単価.FieldLockType = BaseContents.Field.LockType.None
        Me.txt社内単価.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt社内単価.HelpKeys = ""
        Me.txt社内単価.HelpLink = ""
        Me.txt社内単価.HelpType = NodeUI.Help.Type.None
        Me.txt社内単価.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt社内単価.IsError = False
        Me.txt社内単価.Location = New System.Drawing.Point(13, 27)
        Me.txt社内単価.Name = "txt社内単価"
        Me.txt社内単価.Required = False
        Me.txt社内単価.Size = New System.Drawing.Size(106, 23)
        Me.txt社内単価.TabIndex = 0
        Me.txt社内単価.Text = "1234567.89"
        Me.txt社内単価.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt社内単価.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp発注単価
        '
        Me.grp発注単価.Controls.Add(Me.txt発注単価)
        Me.grp発注単価.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp発注単価.Location = New System.Drawing.Point(525, 494)
        Me.grp発注単価.Name = "grp発注単価"
        Me.grp発注単価.Size = New System.Drawing.Size(128, 61)
        Me.grp発注単価.TabIndex = 6
        Me.grp発注単価.TabStop = False
        Me.grp発注単価.Text = "発注単価"
        '
        'txt発注単価
        '
        Me.txt発注単価.FieldLockType = BaseContents.Field.LockType.None
        Me.txt発注単価.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt発注単価.HelpKeys = ""
        Me.txt発注単価.HelpLink = ""
        Me.txt発注単価.HelpType = NodeUI.Help.Type.None
        Me.txt発注単価.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt発注単価.IsError = False
        Me.txt発注単価.Location = New System.Drawing.Point(11, 27)
        Me.txt発注単価.Name = "txt発注単価"
        Me.txt発注単価.Required = False
        Me.txt発注単価.Size = New System.Drawing.Size(107, 23)
        Me.txt発注単価.TabIndex = 0
        Me.txt発注単価.Text = "1234567.89"
        Me.txt発注単価.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt発注単価.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp社内用紙
        '
        Me.grp社内用紙.Controls.Add(Me.txt社内用紙CD)
        Me.grp社内用紙.Controls.Add(Me.nam社内用紙名)
        Me.grp社内用紙.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp社内用紙.Location = New System.Drawing.Point(23, 40)
        Me.grp社内用紙.Name = "grp社内用紙"
        Me.grp社内用紙.Size = New System.Drawing.Size(166, 61)
        Me.grp社内用紙.TabIndex = 0
        Me.grp社内用紙.TabStop = False
        Me.grp社内用紙.Text = "紙コード"
        '
        'txt社内用紙CD
        '
        Me.txt社内用紙CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt社内用紙CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt社内用紙CD.HelpKeys = ""
        Me.txt社内用紙CD.HelpLink = ""
        Me.txt社内用紙CD.HelpType = NodeUI.Help.Type.None
        Me.txt社内用紙CD.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt社内用紙CD.IsError = False
        Me.txt社内用紙CD.Location = New System.Drawing.Point(17, 27)
        Me.txt社内用紙CD.Name = "txt社内用紙CD"
        Me.txt社内用紙CD.Required = False
        Me.txt社内用紙CD.Size = New System.Drawing.Size(38, 23)
        Me.txt社内用紙CD.TabIndex = 0
        Me.txt社内用紙CD.Text = "9999"
        Me.txt社内用紙CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam社内用紙名
        '
        Me.nam社内用紙名.BackColor = System.Drawing.SystemColors.Control
        Me.nam社内用紙名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam社内用紙名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam社内用紙名.Location = New System.Drawing.Point(56, 27)
        Me.nam社内用紙名.Margin = New System.Windows.Forms.Padding(3)
        Me.nam社内用紙名.Name = "nam社内用紙名"
        Me.nam社内用紙名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.nam社内用紙名.Size = New System.Drawing.Size(104, 23)
        Me.nam社内用紙名.TabIndex = 1
        Me.nam社内用紙名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp社内用糊CD
        '
        Me.grp社内用糊CD.Controls.Add(Me.txt社内用糊CD)
        Me.grp社内用糊CD.Controls.Add(Me.nam社内用糊名)
        Me.grp社内用糊CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp社内用糊CD.Location = New System.Drawing.Point(23, 123)
        Me.grp社内用糊CD.Name = "grp社内用糊CD"
        Me.grp社内用糊CD.Size = New System.Drawing.Size(166, 61)
        Me.grp社内用糊CD.TabIndex = 1
        Me.grp社内用糊CD.TabStop = False
        Me.grp社内用糊CD.Text = "糊コード"
        '
        'txt社内用糊CD
        '
        Me.txt社内用糊CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt社内用糊CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt社内用糊CD.HelpKeys = ""
        Me.txt社内用糊CD.HelpLink = ""
        Me.txt社内用糊CD.HelpType = NodeUI.Help.Type.None
        Me.txt社内用糊CD.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt社内用糊CD.IsError = False
        Me.txt社内用糊CD.Location = New System.Drawing.Point(25, 27)
        Me.txt社内用糊CD.Name = "txt社内用糊CD"
        Me.txt社内用糊CD.Required = False
        Me.txt社内用糊CD.Size = New System.Drawing.Size(30, 23)
        Me.txt社内用糊CD.TabIndex = 0
        Me.txt社内用糊CD.Text = "999"
        Me.txt社内用糊CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam社内用糊名
        '
        Me.nam社内用糊名.BackColor = System.Drawing.SystemColors.Control
        Me.nam社内用糊名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam社内用糊名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam社内用糊名.Location = New System.Drawing.Point(56, 27)
        Me.nam社内用糊名.Margin = New System.Windows.Forms.Padding(3)
        Me.nam社内用糊名.Name = "nam社内用糊名"
        Me.nam社内用糊名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.nam社内用糊名.Size = New System.Drawing.Size(104, 23)
        Me.nam社内用糊名.TabIndex = 1
        Me.nam社内用糊名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp社内用台紙
        '
        Me.grp社内用台紙.Controls.Add(Me.txt社内用台紙CD)
        Me.grp社内用台紙.Controls.Add(Me.nam社内用台紙名)
        Me.grp社内用台紙.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp社内用台紙.Location = New System.Drawing.Point(23, 190)
        Me.grp社内用台紙.Name = "grp社内用台紙"
        Me.grp社内用台紙.Size = New System.Drawing.Size(166, 61)
        Me.grp社内用台紙.TabIndex = 2
        Me.grp社内用台紙.TabStop = False
        Me.grp社内用台紙.Text = "台紙コード"
        '
        'txt社内用台紙CD
        '
        Me.txt社内用台紙CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt社内用台紙CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt社内用台紙CD.HelpKeys = ""
        Me.txt社内用台紙CD.HelpLink = ""
        Me.txt社内用台紙CD.HelpType = NodeUI.Help.Type.None
        Me.txt社内用台紙CD.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt社内用台紙CD.IsError = False
        Me.txt社内用台紙CD.Location = New System.Drawing.Point(30, 27)
        Me.txt社内用台紙CD.Name = "txt社内用台紙CD"
        Me.txt社内用台紙CD.Required = False
        Me.txt社内用台紙CD.Size = New System.Drawing.Size(25, 23)
        Me.txt社内用台紙CD.TabIndex = 0
        Me.txt社内用台紙CD.Text = "99"
        Me.txt社内用台紙CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam社内用台紙名
        '
        Me.nam社内用台紙名.BackColor = System.Drawing.SystemColors.Control
        Me.nam社内用台紙名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam社内用台紙名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam社内用台紙名.Location = New System.Drawing.Point(56, 27)
        Me.nam社内用台紙名.Margin = New System.Windows.Forms.Padding(3)
        Me.nam社内用台紙名.Name = "nam社内用台紙名"
        Me.nam社内用台紙名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.nam社内用台紙名.Size = New System.Drawing.Size(104, 23)
        Me.nam社内用台紙名.TabIndex = 1
        Me.nam社内用台紙名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp社内用
        '
        Me.grp社内用.Controls.Add(Me.grp社内用台紙)
        Me.grp社内用.Controls.Add(Me.grp社内用糊CD)
        Me.grp社内用.Controls.Add(Me.grp社内用紙)
        Me.grp社内用.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp社内用.Location = New System.Drawing.Point(90, 192)
        Me.grp社内用.Name = "grp社内用"
        Me.grp社内用.Size = New System.Drawing.Size(255, 269)
        Me.grp社内用.TabIndex = 2
        Me.grp社内用.TabStop = False
        Me.grp社内用.Text = "社内用"
        '
        'frmPaperPriIn
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.grp発注単価)
        Me.Controls.Add(Me.grp社内単価)
        Me.Controls.Add(Me.grp発注用)
        Me.Controls.Add(Me.grp社内用)
        Me.Controls.Add(Me.grp単価区分)
        Me.Controls.Add(Me.grp仕入先CD)
        Me.Controls.Add(Me.grp処理区分)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmPaperPriIn"
        Me.Text = ""
        Me.Controls.SetChildIndex(Me.grp処理区分, 0)
        Me.Controls.SetChildIndex(Me.grp仕入先CD, 0)
        Me.Controls.SetChildIndex(Me.grp単価区分, 0)
        Me.Controls.SetChildIndex(Me.grp社内用, 0)
        Me.Controls.SetChildIndex(Me.grp発注用, 0)
        Me.Controls.SetChildIndex(Me.grp社内単価, 0)
        Me.Controls.SetChildIndex(Me.grp発注単価, 0)
        Me.grp処理区分.ResumeLayout(False)
        Me.grp処理区分.PerformLayout()
        Me.grp仕入先CD.ResumeLayout(False)
        Me.grp仕入先CD.PerformLayout()
        Me.grp単価区分.ResumeLayout(False)
        Me.grp発注用.ResumeLayout(False)
        Me.grp発注用台紙.ResumeLayout(False)
        Me.grp発注用台紙.PerformLayout()
        Me.grp発注用糊.ResumeLayout(False)
        Me.grp発注用糊.PerformLayout()
        Me.grp発注用紙.ResumeLayout(False)
        Me.grp発注用紙.PerformLayout()
        Me.grp社内単価.ResumeLayout(False)
        Me.grp社内単価.PerformLayout()
        Me.grp発注単価.ResumeLayout(False)
        Me.grp発注単価.PerformLayout()
        Me.grp社内用紙.ResumeLayout(False)
        Me.grp社内用紙.PerformLayout()
        Me.grp社内用糊CD.ResumeLayout(False)
        Me.grp社内用糊CD.PerformLayout()
        Me.grp社内用台紙.ResumeLayout(False)
        Me.grp社内用台紙.PerformLayout()
        Me.grp社内用.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp処理区分 As BaseUI.Control.GroupBox
    Friend WithEvents opt削除 As BaseUI.Control.RadioButton
    Friend WithEvents opt修正 As BaseUI.Control.RadioButton
    Friend WithEvents opt登録 As BaseUI.Control.RadioButton
    Friend WithEvents grp仕入先CD As BaseUI.Control.GroupBox
    Friend WithEvents txt仕入先CD As BaseUI.Control.TextBox
    Friend WithEvents grp単価区分 As BaseUI.Control.GroupBox
    Friend WithEvents ddl単価区分 As BaseUI.Control.ComboBox
    Friend WithEvents nam仕入先名 As BaseUI.Control.NameBox
    Friend WithEvents grp発注用 As BaseUI.Control.GroupBox
    Friend WithEvents grp発注用台紙 As BaseUI.Control.GroupBox
    Friend WithEvents txt発注用台紙CD As BaseUI.Control.TextBox
    Friend WithEvents nam発注用台紙名 As BaseUI.Control.NameBox
    Friend WithEvents grp発注用糊 As BaseUI.Control.GroupBox
    Friend WithEvents txt発注用糊CD As BaseUI.Control.TextBox
    Friend WithEvents nam発注用糊名 As BaseUI.Control.NameBox
    Friend WithEvents grp発注用紙 As BaseUI.Control.GroupBox
    Friend WithEvents txt発注用紙CD As BaseUI.Control.TextBox
    Friend WithEvents nam発注用紙名 As BaseUI.Control.NameBox
    Friend WithEvents grp社内単価 As BaseUI.Control.GroupBox
    Friend WithEvents grp発注単価 As BaseUI.Control.GroupBox
    Friend WithEvents txt発注単価 As BaseUI.Control.TextBox
    Friend WithEvents txt社内単価 As BaseUI.Control.TextBox
    Friend WithEvents grp社内用紙 As BaseUI.Control.GroupBox
    Friend WithEvents txt社内用紙CD As BaseUI.Control.TextBox
    Friend WithEvents nam社内用紙名 As BaseUI.Control.NameBox
    Friend WithEvents grp社内用糊CD As BaseUI.Control.GroupBox
    Friend WithEvents txt社内用糊CD As BaseUI.Control.TextBox
    Friend WithEvents nam社内用糊名 As BaseUI.Control.NameBox
    Friend WithEvents grp社内用台紙 As BaseUI.Control.GroupBox
    Friend WithEvents txt社内用台紙CD As BaseUI.Control.TextBox
    Friend WithEvents nam社内用台紙名 As BaseUI.Control.NameBox
    Friend WithEvents grp社内用 As BaseUI.Control.GroupBox

End Class
