<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderOut
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
        Me.grdDetall = New BaseUI.Control.GridInput()
        Me.grp商品内訳 = New BaseUI.Control.GroupBox()
        Me.nam枝番Title = New BaseUI.Control.NameBox()
        Me.txt発注単価商品 = New BaseUI.Control.TextBox()
        Me.nam発注単価商品Title = New BaseUI.Control.NameBox()
        Me.nam受注単価商品 = New BaseUI.Control.NameBox()
        Me.nam受注数 = New BaseUI.Control.NameBox()
        Me.nam定番CD = New BaseUI.Control.NameBox()
        Me.nam枝番 = New BaseUI.Control.NameBox()
        Me.nam商品名 = New BaseUI.Control.NameBox()
        Me.nam内製造数 = New BaseUI.Control.NameBox()
        Me.nam内製造数Title = New BaseUI.Control.NameBox()
        Me.nam内在庫引当数 = New BaseUI.Control.NameBox()
        Me.nam内在庫引当数Title = New BaseUI.Control.NameBox()
        Me.nam商品名Title = New BaseUI.Control.NameBox()
        Me.nam受注単価商品Title = New BaseUI.Control.NameBox()
        Me.nam受注数Title = New BaseUI.Control.NameBox()
        Me.nam定番CDTitle = New BaseUI.Control.NameBox()
        Me.btn戻る = New BaseUI.Control.Button()
        Me.grp外注先 = New BaseUI.Control.GroupBox()
        Me.nam外注先名 = New BaseUI.Control.NameBox()
        Me.txt外注先CD = New BaseUI.Control.TextBox()
        Me.grp受注日付 = New BaseUI.Control.GroupBox()
        Me.txt発注納期 = New BaseUI.Control.TextBox()
        Me.nam本台帳NO = New BaseUI.Control.NameBox()
        Me.nam本台帳NOTitle = New BaseUI.Control.NameBox()
        Me.nam商品名代表 = New BaseUI.Control.NameBox()
        Me.nam商品名代表Title = New BaseUI.Control.NameBox()
        Me.nam内製造数合計 = New BaseUI.Control.NameBox()
        Me.nam内製造数合計Title = New BaseUI.Control.NameBox()
        Me.nam内在庫引当数合計 = New BaseUI.Control.NameBox()
        Me.nam内在庫引当数合計Title = New BaseUI.Control.NameBox()
        Me.nam受注数合計 = New BaseUI.Control.NameBox()
        Me.nam受注数合計Title = New BaseUI.Control.NameBox()
        Me.nam受注単価 = New BaseUI.Control.NameBox()
        Me.nam受注単価Title = New BaseUI.Control.NameBox()
        Me.nam受注金額 = New BaseUI.Control.NameBox()
        Me.nam受注金額Title = New BaseUI.Control.NameBox()
        Me.txt発注単価 = New BaseUI.Control.TextBox()
        Me.nam発注単価Title = New BaseUI.Control.NameBox()
        Me.txt発注金額 = New BaseUI.Control.TextBox()
        Me.nam発注金額Title = New BaseUI.Control.NameBox()
        CType(Me.grdDetall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp商品内訳.SuspendLayout()
        Me.grp外注先.SuspendLayout()
        Me.grp受注日付.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnESC
        '
        Me.btnESC.Text = "閉じる"
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
        Me.grdDetall.Location = New System.Drawing.Point(14, 21)
        Me.grdDetall.MultiSelect = False
        Me.grdDetall.Name = "grdDetall"
        Me.grdDetall.Required = False
        Me.grdDetall.RowHeadersVisible = False
        Me.grdDetall.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdDetall.Size = New System.Drawing.Size(945, 330)
        Me.grdDetall.TabIndex = 0
        Me.grdDetall.TabStop = False
        Me.grdDetall.TextBoxAddBtm = Nothing
        Me.grdDetall.TextBoxAddTop = Nothing
        '
        'grp商品内訳
        '
        Me.grp商品内訳.Controls.Add(Me.nam枝番Title)
        Me.grp商品内訳.Controls.Add(Me.txt発注単価商品)
        Me.grp商品内訳.Controls.Add(Me.nam発注単価商品Title)
        Me.grp商品内訳.Controls.Add(Me.nam受注単価商品)
        Me.grp商品内訳.Controls.Add(Me.nam受注数)
        Me.grp商品内訳.Controls.Add(Me.nam定番CD)
        Me.grp商品内訳.Controls.Add(Me.nam枝番)
        Me.grp商品内訳.Controls.Add(Me.nam商品名)
        Me.grp商品内訳.Controls.Add(Me.nam内製造数)
        Me.grp商品内訳.Controls.Add(Me.nam内製造数Title)
        Me.grp商品内訳.Controls.Add(Me.nam内在庫引当数)
        Me.grp商品内訳.Controls.Add(Me.nam内在庫引当数Title)
        Me.grp商品内訳.Controls.Add(Me.nam商品名Title)
        Me.grp商品内訳.Controls.Add(Me.nam受注単価商品Title)
        Me.grp商品内訳.Controls.Add(Me.nam受注数Title)
        Me.grp商品内訳.Controls.Add(Me.nam定番CDTitle)
        Me.grp商品内訳.Controls.Add(Me.grdDetall)
        Me.grp商品内訳.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp商品内訳.Location = New System.Drawing.Point(24, 166)
        Me.grp商品内訳.Name = "grp商品内訳"
        Me.grp商品内訳.Size = New System.Drawing.Size(975, 420)
        Me.grp商品内訳.TabIndex = 4
        Me.grp商品内訳.TabStop = False
        Me.grp商品内訳.Text = "【商品発注内訳】"
        '
        'nam枝番Title
        '
        Me.nam枝番Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam枝番Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 7.0!)
        Me.nam枝番Title.Location = New System.Drawing.Point(53, 363)
        Me.nam枝番Title.Name = "nam枝番Title"
        Me.nam枝番Title.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.nam枝番Title.Size = New System.Drawing.Size(23, 23)
        Me.nam枝番Title.StringLength = 0
        Me.nam枝番Title.TabIndex = 112
        Me.nam枝番Title.Text = "枝" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "番"
        Me.nam枝番Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam枝番Title.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt発注単価商品
        '
        Me.txt発注単価商品.FieldLockType = BaseContents.Field.LockType.None
        Me.txt発注単価商品.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt発注単価商品.HelpKeys = ""
        Me.txt発注単価商品.HelpLink = ""
        Me.txt発注単価商品.HelpType = NodeUI.Help.Type.None
        Me.txt発注単価商品.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt発注単価商品.IsError = False
        Me.txt発注単価商品.Location = New System.Drawing.Point(840, 389)
        Me.txt発注単価商品.Name = "txt発注単価商品"
        Me.txt発注単価商品.Required = False
        Me.txt発注単価商品.Size = New System.Drawing.Size(95, 23)
        Me.txt発注単価商品.StringLength = 0
        Me.txt発注単価商品.TabIndex = 1
        Me.txt発注単価商品.Text = "123,456,789"
        Me.txt発注単価商品.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam発注単価商品Title
        '
        Me.nam発注単価商品Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam発注単価商品Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam発注単価商品Title.Location = New System.Drawing.Point(840, 363)
        Me.nam発注単価商品Title.Name = "nam発注単価商品Title"
        Me.nam発注単価商品Title.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam発注単価商品Title.Size = New System.Drawing.Size(95, 23)
        Me.nam発注単価商品Title.StringLength = 0
        Me.nam発注単価商品Title.TabIndex = 111
        Me.nam発注単価商品Title.Text = "発注単価"
        Me.nam発注単価商品Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam発注単価商品Title.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam受注単価商品
        '
        Me.nam受注単価商品.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam受注単価商品.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam受注単価商品.Location = New System.Drawing.Point(744, 389)
        Me.nam受注単価商品.Name = "nam受注単価商品"
        Me.nam受注単価商品.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam受注単価商品.Size = New System.Drawing.Size(95, 23)
        Me.nam受注単価商品.StringLength = 0
        Me.nam受注単価商品.TabIndex = 109
        Me.nam受注単価商品.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam受注単価商品.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam受注数
        '
        Me.nam受注数.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam受注数.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam受注数.Location = New System.Drawing.Point(456, 389)
        Me.nam受注数.Name = "nam受注数"
        Me.nam受注数.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam受注数.Size = New System.Drawing.Size(95, 23)
        Me.nam受注数.StringLength = 0
        Me.nam受注数.TabIndex = 108
        Me.nam受注数.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nam受注数.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam定番CD
        '
        Me.nam定番CD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam定番CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam定番CD.Location = New System.Drawing.Point(77, 389)
        Me.nam定番CD.Name = "nam定番CD"
        Me.nam定番CD.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam定番CD.Size = New System.Drawing.Size(106, 23)
        Me.nam定番CD.StringLength = 0
        Me.nam定番CD.TabIndex = 107
        Me.nam定番CD.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam定番CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam枝番
        '
        Me.nam枝番.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam枝番.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam枝番.Location = New System.Drawing.Point(53, 389)
        Me.nam枝番.Name = "nam枝番"
        Me.nam枝番.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam枝番.Size = New System.Drawing.Size(23, 23)
        Me.nam枝番.StringLength = 0
        Me.nam枝番.TabIndex = 106
        Me.nam枝番.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam商品名
        '
        Me.nam商品名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam商品名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam商品名.Location = New System.Drawing.Point(185, 389)
        Me.nam商品名.Name = "nam商品名"
        Me.nam商品名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam商品名.Size = New System.Drawing.Size(270, 23)
        Me.nam商品名.StringLength = 0
        Me.nam商品名.TabIndex = 104
        Me.nam商品名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam内製造数
        '
        Me.nam内製造数.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam内製造数.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam内製造数.Location = New System.Drawing.Point(648, 389)
        Me.nam内製造数.Name = "nam内製造数"
        Me.nam内製造数.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam内製造数.Size = New System.Drawing.Size(95, 23)
        Me.nam内製造数.StringLength = 0
        Me.nam内製造数.TabIndex = 105
        Me.nam内製造数.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam内製造数Title
        '
        Me.nam内製造数Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam内製造数Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.nam内製造数Title.Location = New System.Drawing.Point(648, 363)
        Me.nam内製造数Title.Name = "nam内製造数Title"
        Me.nam内製造数Title.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam内製造数Title.Size = New System.Drawing.Size(95, 23)
        Me.nam内製造数Title.StringLength = 0
        Me.nam内製造数Title.TabIndex = 104
        Me.nam内製造数Title.Text = "内製造数"
        Me.nam内製造数Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nam内製造数Title.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam内在庫引当数
        '
        Me.nam内在庫引当数.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam内在庫引当数.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam内在庫引当数.Location = New System.Drawing.Point(552, 389)
        Me.nam内在庫引当数.Name = "nam内在庫引当数"
        Me.nam内在庫引当数.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam内在庫引当数.Size = New System.Drawing.Size(95, 23)
        Me.nam内在庫引当数.StringLength = 0
        Me.nam内在庫引当数.TabIndex = 103
        Me.nam内在庫引当数.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam内在庫引当数Title
        '
        Me.nam内在庫引当数Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam内在庫引当数Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.nam内在庫引当数Title.Location = New System.Drawing.Point(552, 363)
        Me.nam内在庫引当数Title.Name = "nam内在庫引当数Title"
        Me.nam内在庫引当数Title.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam内在庫引当数Title.Size = New System.Drawing.Size(95, 23)
        Me.nam内在庫引当数Title.StringLength = 0
        Me.nam内在庫引当数Title.TabIndex = 102
        Me.nam内在庫引当数Title.Text = "内在庫引当数"
        Me.nam内在庫引当数Title.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.nam内在庫引当数Title.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam商品名Title
        '
        Me.nam商品名Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam商品名Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam商品名Title.Location = New System.Drawing.Point(185, 363)
        Me.nam商品名Title.Name = "nam商品名Title"
        Me.nam商品名Title.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam商品名Title.Size = New System.Drawing.Size(270, 23)
        Me.nam商品名Title.StringLength = 0
        Me.nam商品名Title.TabIndex = 101
        Me.nam商品名Title.Text = "商   品   名"
        Me.nam商品名Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nam商品名Title.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam受注単価商品Title
        '
        Me.nam受注単価商品Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam受注単価商品Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam受注単価商品Title.Location = New System.Drawing.Point(744, 363)
        Me.nam受注単価商品Title.Name = "nam受注単価商品Title"
        Me.nam受注単価商品Title.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam受注単価商品Title.Size = New System.Drawing.Size(95, 23)
        Me.nam受注単価商品Title.StringLength = 0
        Me.nam受注単価商品Title.TabIndex = 99
        Me.nam受注単価商品Title.Text = "受注単価"
        Me.nam受注単価商品Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam受注単価商品Title.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam受注数Title
        '
        Me.nam受注数Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam受注数Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam受注数Title.Location = New System.Drawing.Point(456, 363)
        Me.nam受注数Title.Name = "nam受注数Title"
        Me.nam受注数Title.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam受注数Title.Size = New System.Drawing.Size(95, 23)
        Me.nam受注数Title.StringLength = 0
        Me.nam受注数Title.TabIndex = 97
        Me.nam受注数Title.Text = "受注数"
        Me.nam受注数Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nam受注数Title.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam定番CDTitle
        '
        Me.nam定番CDTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam定番CDTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam定番CDTitle.Location = New System.Drawing.Point(77, 363)
        Me.nam定番CDTitle.Name = "nam定番CDTitle"
        Me.nam定番CDTitle.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam定番CDTitle.Size = New System.Drawing.Size(106, 23)
        Me.nam定番CDTitle.StringLength = 0
        Me.nam定番CDTitle.TabIndex = 96
        Me.nam定番CDTitle.Text = "定番ｺｰﾄﾞ"
        Me.nam定番CDTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam定番CDTitle.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'btn戻る
        '
        Me.btn戻る.FieldLockType = BaseContents.Field.LockType.Data
        Me.btn戻る.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.btn戻る.Location = New System.Drawing.Point(761, 593)
        Me.btn戻る.Name = "btn戻る"
        Me.btn戻る.Size = New System.Drawing.Size(208, 48)
        Me.btn戻る.TabIndex = 5
        Me.btn戻る.Text = "前画面へ戻る"
        Me.btn戻る.UseVisualStyleBackColor = True
        '
        'grp外注先
        '
        Me.grp外注先.Controls.Add(Me.nam外注先名)
        Me.grp外注先.Controls.Add(Me.txt外注先CD)
        Me.grp外注先.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp外注先.Location = New System.Drawing.Point(43, 5)
        Me.grp外注先.Name = "grp外注先"
        Me.grp外注先.Size = New System.Drawing.Size(347, 54)
        Me.grp外注先.TabIndex = 0
        Me.grp外注先.TabStop = False
        Me.grp外注先.Text = "外注先ｺｰﾄﾞ"
        '
        'nam外注先名
        '
        Me.nam外注先名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam外注先名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam外注先名.Location = New System.Drawing.Point(70, 21)
        Me.nam外注先名.Name = "nam外注先名"
        Me.nam外注先名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam外注先名.Size = New System.Drawing.Size(270, 23)
        Me.nam外注先名.StringLength = 0
        Me.nam外注先名.TabIndex = 1
        Me.nam外注先名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt外注先CD
        '
        Me.txt外注先CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt外注先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt外注先CD.HelpKeys = ""
        Me.txt外注先CD.HelpLink = ""
        Me.txt外注先CD.HelpType = NodeUI.Help.Type.None
        Me.txt外注先CD.IsError = False
        Me.txt外注先CD.Location = New System.Drawing.Point(9, 21)
        Me.txt外注先CD.Name = "txt外注先CD"
        Me.txt外注先CD.Required = False
        Me.txt外注先CD.Size = New System.Drawing.Size(60, 23)
        Me.txt外注先CD.TabIndex = 0
        Me.txt外注先CD.Text = "XXXXXX"
        Me.txt外注先CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp受注日付
        '
        Me.grp受注日付.Controls.Add(Me.txt発注納期)
        Me.grp受注日付.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp受注日付.Location = New System.Drawing.Point(396, 5)
        Me.grp受注日付.Name = "grp受注日付"
        Me.grp受注日付.Size = New System.Drawing.Size(110, 54)
        Me.grp受注日付.TabIndex = 1
        Me.grp受注日付.TabStop = False
        Me.grp受注日付.Text = "発注納期"
        '
        'txt発注納期
        '
        Me.txt発注納期.FieldLockType = BaseContents.Field.LockType.None
        Me.txt発注納期.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt発注納期.HelpKeys = ""
        Me.txt発注納期.HelpLink = ""
        Me.txt発注納期.HelpType = NodeUI.Help.Type.None
        Me.txt発注納期.IsError = False
        Me.txt発注納期.Location = New System.Drawing.Point(9, 21)
        Me.txt発注納期.Name = "txt発注納期"
        Me.txt発注納期.Required = False
        Me.txt発注納期.Size = New System.Drawing.Size(90, 23)
        Me.txt発注納期.TabIndex = 0
        Me.txt発注納期.Text = "YYYY/MM/DD"
        Me.txt発注納期.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam本台帳NO
        '
        Me.nam本台帳NO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam本台帳NO.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam本台帳NO.Location = New System.Drawing.Point(43, 94)
        Me.nam本台帳NO.Name = "nam本台帳NO"
        Me.nam本台帳NO.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam本台帳NO.Size = New System.Drawing.Size(60, 23)
        Me.nam本台帳NO.StringLength = 0
        Me.nam本台帳NO.TabIndex = 61
        Me.nam本台帳NO.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam本台帳NOTitle
        '
        Me.nam本台帳NOTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam本台帳NOTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.nam本台帳NOTitle.Location = New System.Drawing.Point(43, 69)
        Me.nam本台帳NOTitle.Name = "nam本台帳NOTitle"
        Me.nam本台帳NOTitle.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam本台帳NOTitle.Size = New System.Drawing.Size(60, 23)
        Me.nam本台帳NOTitle.StringLength = 0
        Me.nam本台帳NOTitle.TabIndex = 60
        Me.nam本台帳NOTitle.Text = "本台帳NO"
        Me.nam本台帳NOTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam本台帳NOTitle.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam商品名代表
        '
        Me.nam商品名代表.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam商品名代表.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam商品名代表.Location = New System.Drawing.Point(104, 94)
        Me.nam商品名代表.Name = "nam商品名代表"
        Me.nam商品名代表.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam商品名代表.Size = New System.Drawing.Size(270, 23)
        Me.nam商品名代表.StringLength = 0
        Me.nam商品名代表.TabIndex = 63
        Me.nam商品名代表.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam商品名代表Title
        '
        Me.nam商品名代表Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam商品名代表Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam商品名代表Title.Location = New System.Drawing.Point(104, 69)
        Me.nam商品名代表Title.Name = "nam商品名代表Title"
        Me.nam商品名代表Title.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam商品名代表Title.Size = New System.Drawing.Size(270, 23)
        Me.nam商品名代表Title.StringLength = 0
        Me.nam商品名代表Title.TabIndex = 62
        Me.nam商品名代表Title.Text = "商品名(代表)"
        Me.nam商品名代表Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.nam商品名代表Title.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam内製造数合計
        '
        Me.nam内製造数合計.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam内製造数合計.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam内製造数合計.Location = New System.Drawing.Point(567, 94)
        Me.nam内製造数合計.Name = "nam内製造数合計"
        Me.nam内製造数合計.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam内製造数合計.Size = New System.Drawing.Size(95, 23)
        Me.nam内製造数合計.StringLength = 0
        Me.nam内製造数合計.TabIndex = 91
        Me.nam内製造数合計.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam内製造数合計Title
        '
        Me.nam内製造数合計Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam内製造数合計Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.nam内製造数合計Title.Location = New System.Drawing.Point(567, 69)
        Me.nam内製造数合計Title.Name = "nam内製造数合計Title"
        Me.nam内製造数合計Title.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam内製造数合計Title.Size = New System.Drawing.Size(95, 23)
        Me.nam内製造数合計Title.StringLength = 0
        Me.nam内製造数合計Title.TabIndex = 90
        Me.nam内製造数合計Title.Text = "内製造数合計"
        Me.nam内製造数合計Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nam内製造数合計Title.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam内在庫引当数合計
        '
        Me.nam内在庫引当数合計.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam内在庫引当数合計.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam内在庫引当数合計.Location = New System.Drawing.Point(471, 94)
        Me.nam内在庫引当数合計.Name = "nam内在庫引当数合計"
        Me.nam内在庫引当数合計.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam内在庫引当数合計.Size = New System.Drawing.Size(95, 23)
        Me.nam内在庫引当数合計.StringLength = 0
        Me.nam内在庫引当数合計.TabIndex = 89
        Me.nam内在庫引当数合計.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam内在庫引当数合計Title
        '
        Me.nam内在庫引当数合計Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam内在庫引当数合計Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.nam内在庫引当数合計Title.Location = New System.Drawing.Point(471, 69)
        Me.nam内在庫引当数合計Title.Name = "nam内在庫引当数合計Title"
        Me.nam内在庫引当数合計Title.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam内在庫引当数合計Title.Size = New System.Drawing.Size(95, 23)
        Me.nam内在庫引当数合計Title.StringLength = 0
        Me.nam内在庫引当数合計Title.TabIndex = 88
        Me.nam内在庫引当数合計Title.Text = "内在庫引当合計"
        Me.nam内在庫引当数合計Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nam内在庫引当数合計Title.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam受注数合計
        '
        Me.nam受注数合計.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam受注数合計.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam受注数合計.Location = New System.Drawing.Point(375, 94)
        Me.nam受注数合計.Name = "nam受注数合計"
        Me.nam受注数合計.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam受注数合計.Size = New System.Drawing.Size(95, 23)
        Me.nam受注数合計.StringLength = 0
        Me.nam受注数合計.TabIndex = 93
        Me.nam受注数合計.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam受注数合計Title
        '
        Me.nam受注数合計Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam受注数合計Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.nam受注数合計Title.Location = New System.Drawing.Point(375, 69)
        Me.nam受注数合計Title.Name = "nam受注数合計Title"
        Me.nam受注数合計Title.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam受注数合計Title.Size = New System.Drawing.Size(95, 23)
        Me.nam受注数合計Title.StringLength = 0
        Me.nam受注数合計Title.TabIndex = 92
        Me.nam受注数合計Title.Text = "受注数合計"
        Me.nam受注数合計Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nam受注数合計Title.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam受注単価
        '
        Me.nam受注単価.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam受注単価.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam受注単価.Location = New System.Drawing.Point(663, 94)
        Me.nam受注単価.Name = "nam受注単価"
        Me.nam受注単価.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam受注単価.Size = New System.Drawing.Size(95, 23)
        Me.nam受注単価.StringLength = 0
        Me.nam受注単価.TabIndex = 95
        Me.nam受注単価.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam受注単価Title
        '
        Me.nam受注単価Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam受注単価Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam受注単価Title.Location = New System.Drawing.Point(663, 69)
        Me.nam受注単価Title.Name = "nam受注単価Title"
        Me.nam受注単価Title.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam受注単価Title.Size = New System.Drawing.Size(95, 23)
        Me.nam受注単価Title.StringLength = 0
        Me.nam受注単価Title.TabIndex = 94
        Me.nam受注単価Title.Text = "受注単価"
        Me.nam受注単価Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nam受注単価Title.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam受注金額
        '
        Me.nam受注金額.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam受注金額.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam受注金額.Location = New System.Drawing.Point(759, 94)
        Me.nam受注金額.Name = "nam受注金額"
        Me.nam受注金額.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam受注金額.Size = New System.Drawing.Size(95, 23)
        Me.nam受注金額.StringLength = 0
        Me.nam受注金額.TabIndex = 97
        Me.nam受注金額.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam受注金額Title
        '
        Me.nam受注金額Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam受注金額Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam受注金額Title.Location = New System.Drawing.Point(759, 69)
        Me.nam受注金額Title.Name = "nam受注金額Title"
        Me.nam受注金額Title.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam受注金額Title.Size = New System.Drawing.Size(95, 23)
        Me.nam受注金額Title.StringLength = 0
        Me.nam受注金額Title.TabIndex = 96
        Me.nam受注金額Title.Text = "受注金額"
        Me.nam受注金額Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nam受注金額Title.TextStyle = BaseContents.TextBox.TextStyle.None
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
        Me.txt発注単価.Location = New System.Drawing.Point(663, 144)
        Me.txt発注単価.Name = "txt発注単価"
        Me.txt発注単価.Required = False
        Me.txt発注単価.Size = New System.Drawing.Size(95, 23)
        Me.txt発注単価.StringLength = 0
        Me.txt発注単価.TabIndex = 2
        Me.txt発注単価.Text = "123,456,789"
        Me.txt発注単価.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam発注単価Title
        '
        Me.nam発注単価Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam発注単価Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam発注単価Title.Location = New System.Drawing.Point(663, 118)
        Me.nam発注単価Title.Name = "nam発注単価Title"
        Me.nam発注単価Title.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam発注単価Title.Size = New System.Drawing.Size(95, 23)
        Me.nam発注単価Title.StringLength = 0
        Me.nam発注単価Title.TabIndex = 101
        Me.nam発注単価Title.Text = "発注単価"
        Me.nam発注単価Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam発注単価Title.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt発注金額
        '
        Me.txt発注金額.FieldLockType = BaseContents.Field.LockType.None
        Me.txt発注金額.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt発注金額.HelpKeys = ""
        Me.txt発注金額.HelpLink = ""
        Me.txt発注金額.HelpType = NodeUI.Help.Type.None
        Me.txt発注金額.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt発注金額.IsError = False
        Me.txt発注金額.Location = New System.Drawing.Point(759, 144)
        Me.txt発注金額.Name = "txt発注金額"
        Me.txt発注金額.Required = False
        Me.txt発注金額.Size = New System.Drawing.Size(95, 23)
        Me.txt発注金額.StringLength = 0
        Me.txt発注金額.TabIndex = 3
        Me.txt発注金額.Text = "123,456,789"
        Me.txt発注金額.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam発注金額Title
        '
        Me.nam発注金額Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam発注金額Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam発注金額Title.Location = New System.Drawing.Point(759, 118)
        Me.nam発注金額Title.Name = "nam発注金額Title"
        Me.nam発注金額Title.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam発注金額Title.Size = New System.Drawing.Size(95, 23)
        Me.nam発注金額Title.StringLength = 0
        Me.nam発注金額Title.TabIndex = 103
        Me.nam発注金額Title.Text = "発注金額"
        Me.nam発注金額Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam発注金額Title.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'frmOrderOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.txt発注金額)
        Me.Controls.Add(Me.nam発注金額Title)
        Me.Controls.Add(Me.txt発注単価)
        Me.Controls.Add(Me.nam発注単価Title)
        Me.Controls.Add(Me.nam受注金額)
        Me.Controls.Add(Me.nam受注金額Title)
        Me.Controls.Add(Me.nam受注単価)
        Me.Controls.Add(Me.nam受注単価Title)
        Me.Controls.Add(Me.nam受注数合計)
        Me.Controls.Add(Me.nam受注数合計Title)
        Me.Controls.Add(Me.nam内製造数合計)
        Me.Controls.Add(Me.nam内製造数合計Title)
        Me.Controls.Add(Me.nam内在庫引当数合計)
        Me.Controls.Add(Me.nam内在庫引当数合計Title)
        Me.Controls.Add(Me.nam商品名代表)
        Me.Controls.Add(Me.nam商品名代表Title)
        Me.Controls.Add(Me.nam本台帳NO)
        Me.Controls.Add(Me.nam本台帳NOTitle)
        Me.Controls.Add(Me.grp受注日付)
        Me.Controls.Add(Me.grp外注先)
        Me.Controls.Add(Me.btn戻る)
        Me.Controls.Add(Me.grp商品内訳)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmOrderOut"
        Me.Controls.SetChildIndex(Me.grp商品内訳, 0)
        Me.Controls.SetChildIndex(Me.btn戻る, 0)
        Me.Controls.SetChildIndex(Me.grp外注先, 0)
        Me.Controls.SetChildIndex(Me.grp受注日付, 0)
        Me.Controls.SetChildIndex(Me.nam本台帳NOTitle, 0)
        Me.Controls.SetChildIndex(Me.nam本台帳NO, 0)
        Me.Controls.SetChildIndex(Me.nam商品名代表Title, 0)
        Me.Controls.SetChildIndex(Me.nam商品名代表, 0)
        Me.Controls.SetChildIndex(Me.nam内在庫引当数合計Title, 0)
        Me.Controls.SetChildIndex(Me.nam内在庫引当数合計, 0)
        Me.Controls.SetChildIndex(Me.nam内製造数合計Title, 0)
        Me.Controls.SetChildIndex(Me.nam内製造数合計, 0)
        Me.Controls.SetChildIndex(Me.nam受注数合計Title, 0)
        Me.Controls.SetChildIndex(Me.nam受注数合計, 0)
        Me.Controls.SetChildIndex(Me.nam受注単価Title, 0)
        Me.Controls.SetChildIndex(Me.nam受注単価, 0)
        Me.Controls.SetChildIndex(Me.nam受注金額Title, 0)
        Me.Controls.SetChildIndex(Me.nam受注金額, 0)
        Me.Controls.SetChildIndex(Me.nam発注単価Title, 0)
        Me.Controls.SetChildIndex(Me.txt発注単価, 0)
        Me.Controls.SetChildIndex(Me.nam発注金額Title, 0)
        Me.Controls.SetChildIndex(Me.txt発注金額, 0)
        CType(Me.grdDetall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp商品内訳.ResumeLayout(False)
        Me.grp商品内訳.PerformLayout()
        Me.grp外注先.ResumeLayout(False)
        Me.grp外注先.PerformLayout()
        Me.grp受注日付.ResumeLayout(False)
        Me.grp受注日付.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdDetall As BaseUI.Control.GridInput
    Friend WithEvents grp商品内訳 As BaseUI.Control.GroupBox
    Friend WithEvents btn戻る As BaseUI.Control.Button
    Friend WithEvents nam内製造数 As BaseUI.Control.NameBox
    Friend WithEvents nam内製造数Title As BaseUI.Control.NameBox
    Friend WithEvents nam内在庫引当数 As BaseUI.Control.NameBox
    Friend WithEvents nam内在庫引当数Title As BaseUI.Control.NameBox
    Friend WithEvents nam商品名Title As BaseUI.Control.NameBox
    Friend WithEvents nam受注単価商品Title As BaseUI.Control.NameBox
    Friend WithEvents nam受注数Title As BaseUI.Control.NameBox
    Friend WithEvents grp外注先 As BaseUI.Control.GroupBox
    Friend WithEvents nam外注先名 As BaseUI.Control.NameBox
    Friend WithEvents txt外注先CD As BaseUI.Control.TextBox
    Friend WithEvents grp受注日付 As BaseUI.Control.GroupBox
    Friend WithEvents txt発注納期 As BaseUI.Control.TextBox
    Friend WithEvents nam本台帳NO As BaseUI.Control.NameBox
    Friend WithEvents nam本台帳NOTitle As BaseUI.Control.NameBox
    Friend WithEvents nam商品名代表 As BaseUI.Control.NameBox
    Friend WithEvents nam商品名代表Title As BaseUI.Control.NameBox
    Friend WithEvents nam内製造数合計 As BaseUI.Control.NameBox
    Friend WithEvents nam内製造数合計Title As BaseUI.Control.NameBox
    Friend WithEvents nam内在庫引当数合計 As BaseUI.Control.NameBox
    Friend WithEvents nam内在庫引当数合計Title As BaseUI.Control.NameBox
    Friend WithEvents nam受注数合計 As BaseUI.Control.NameBox
    Friend WithEvents nam受注数合計Title As BaseUI.Control.NameBox
    Friend WithEvents nam受注単価 As BaseUI.Control.NameBox
    Friend WithEvents nam受注単価Title As BaseUI.Control.NameBox
    Friend WithEvents nam受注金額 As BaseUI.Control.NameBox
    Friend WithEvents nam受注金額Title As BaseUI.Control.NameBox
    Friend WithEvents txt発注単価 As BaseUI.Control.TextBox
    Friend WithEvents nam発注単価Title As BaseUI.Control.NameBox
    Friend WithEvents txt発注金額 As BaseUI.Control.TextBox
    Friend WithEvents nam発注金額Title As BaseUI.Control.NameBox
    Friend WithEvents nam商品名 As BaseUI.Control.NameBox
    Friend WithEvents nam枝番 As BaseUI.Control.NameBox
    Friend WithEvents nam定番CD As BaseUI.Control.NameBox
    Friend WithEvents nam定番CDTitle As BaseUI.Control.NameBox
    Friend WithEvents nam受注数 As BaseUI.Control.NameBox
    Friend WithEvents nam受注単価商品 As BaseUI.Control.NameBox
    Friend WithEvents txt発注単価商品 As BaseUI.Control.TextBox
    Friend WithEvents nam発注単価商品Title As BaseUI.Control.NameBox
    Friend WithEvents nam枝番Title As BaseUI.Control.NameBox

End Class
