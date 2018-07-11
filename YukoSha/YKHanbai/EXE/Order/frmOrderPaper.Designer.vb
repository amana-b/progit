<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderPaper
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
        Me.grp商品内訳入力 = New BaseUI.Control.GroupBox()
        Me.nam単価区分 = New BaseUI.Control.NameBox()
        Me.ddl単価区分 = New BaseUI.Control.ComboBox()
        Me.nam仕入先名 = New BaseUI.Control.NameBox()
        Me.nam仕入先名Title = New BaseUI.Control.NameBox()
        Me.grp発注用摘要 = New BaseUI.Control.GroupBox()
        Me.txt発注用摘要3 = New BaseUI.Control.TextBox()
        Me.txt発注用摘要2 = New BaseUI.Control.TextBox()
        Me.txt発注用摘要1 = New BaseUI.Control.TextBox()
        Me.nam仕入先CD = New BaseUI.Control.NameBox()
        Me.grp発注用詳細情報 = New BaseUI.Control.GroupBox()
        Me.txt基準長 = New BaseUI.Control.TextBox()
        Me.nam基準長 = New BaseUI.Control.NameBox()
        Me.ddl希望時間帯区分 = New BaseUI.Control.ComboBox()
        Me.nam希望時間帯区分 = New BaseUI.Control.NameBox()
        Me.nam希望納期日付 = New BaseUI.Control.NameBox()
        Me.txt希望納期日付 = New BaseUI.Control.TextBox()
        Me.txt仕入先CD = New BaseUI.Control.TextBox()
        Me.grp長さ算出詳細情報 = New BaseUI.Control.GroupBox()
        Me.txtその他m = New BaseUI.Control.TextBox()
        Me.namその他m = New BaseUI.Control.NameBox()
        Me.txtつなぎロス = New BaseUI.Control.TextBox()
        Me.namつなぎロス = New BaseUI.Control.NameBox()
        Me.txt刷出m = New BaseUI.Control.TextBox()
        Me.nam刷出m = New BaseUI.Control.NameBox()
        Me.nam送りmm = New BaseUI.Control.NameBox()
        Me.txt送りmm = New BaseUI.Control.TextBox()
        Me.txt通数 = New BaseUI.Control.TextBox()
        Me.nam通数 = New BaseUI.Control.NameBox()
        Me.nam発注日付 = New BaseUI.Control.NameBox()
        Me.txt発注日付 = New BaseUI.Control.TextBox()
        Me.txt有償支給単価 = New BaseUI.Control.TextBox()
        Me.nam有償支給単価 = New BaseUI.Control.NameBox()
        Me.ddl支給区分 = New BaseUI.Control.ComboBox()
        Me.nam支給区分 = New BaseUI.Control.NameBox()
        Me.txt発注単価 = New BaseUI.Control.TextBox()
        Me.nam発注単価 = New BaseUI.Control.NameBox()
        Me.ddl仕入先指定区分 = New BaseUI.Control.ComboBox()
        Me.nam仕入先指定区分 = New BaseUI.Control.NameBox()
        Me.namサイズ = New BaseUI.Control.NameBox()
        Me.txt長さm = New BaseUI.Control.TextBox()
        Me.txt巾mm = New BaseUI.Control.TextBox()
        Me.Label2 = New BaseUI.Control.Label()
        Me.nam台紙名 = New BaseUI.Control.NameBox()
        Me.txt台紙名 = New BaseUI.Control.TextBox()
        Me.nam台紙CD = New BaseUI.Control.NameBox()
        Me.txt台紙CD = New BaseUI.Control.TextBox()
        Me.nam糊名 = New BaseUI.Control.NameBox()
        Me.txt糊名 = New BaseUI.Control.TextBox()
        Me.nam糊CD = New BaseUI.Control.NameBox()
        Me.txt糊CD = New BaseUI.Control.TextBox()
        Me.nam紙名 = New BaseUI.Control.NameBox()
        Me.txt紙名 = New BaseUI.Control.TextBox()
        Me.nam紙CD = New BaseUI.Control.NameBox()
        Me.txt紙CD = New BaseUI.Control.TextBox()
        Me.btn戻る = New BaseUI.Control.Button()
        Me.grp仕上方法 = New BaseUI.Control.GroupBox()
        Me.txt送りピッチ = New BaseUI.Control.TextBox()
        Me.nam送りピッチ = New BaseUI.Control.NameBox()
        Me.txt梱包枚数 = New BaseUI.Control.TextBox()
        Me.nam梱包枚数 = New BaseUI.Control.NameBox()
        Me.namカット = New BaseUI.Control.NameBox()
        Me.txtカット3 = New BaseUI.Control.TextBox()
        Me.txtカット2 = New BaseUI.Control.TextBox()
        Me.txtスリッター区分名 = New BaseUI.Control.TextBox()
        Me.ddlスリッター区分 = New BaseUI.Control.ComboBox()
        Me.txtカット1 = New BaseUI.Control.TextBox()
        Me.namスリッター = New BaseUI.Control.NameBox()
        Me.Label1 = New BaseUI.Control.Label()
        Me.txt枚数 = New BaseUI.Control.TextBox()
        Me.lbl刃型サイズ一面角単位 = New BaseUI.Control.Label()
        Me.nam枚数 = New BaseUI.Control.NameBox()
        Me.txt紙管 = New BaseUI.Control.TextBox()
        Me.nam紙管 = New BaseUI.Control.NameBox()
        Me.txt出し方向区分名 = New BaseUI.Control.TextBox()
        Me.ddl出し方向区分 = New BaseUI.Control.ComboBox()
        Me.nam出し方向 = New BaseUI.Control.NameBox()
        Me.txt巻取区分名 = New BaseUI.Control.TextBox()
        Me.ddl巻取区分 = New BaseUI.Control.ComboBox()
        Me.txtスリッター巾 = New BaseUI.Control.TextBox()
        Me.namスリッター巾 = New BaseUI.Control.NameBox()
        Me.nam巻取 = New BaseUI.Control.NameBox()
        Me.ddl社内外区分 = New BaseUI.Control.ComboBox()
        Me.grp社内外区分 = New BaseUI.Control.GroupBox()
        Me.btn外注 = New BaseUI.Control.Button()
        CType(Me.grdDetall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp商品内訳.SuspendLayout()
        Me.grp商品内訳入力.SuspendLayout()
        Me.grp発注用摘要.SuspendLayout()
        Me.grp発注用詳細情報.SuspendLayout()
        Me.grp長さ算出詳細情報.SuspendLayout()
        Me.grp仕上方法.SuspendLayout()
        Me.grp社内外区分.SuspendLayout()
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
        Me.grdDetall.Location = New System.Drawing.Point(6, 22)
        Me.grdDetall.MultiSelect = False
        Me.grdDetall.Name = "grdDetall"
        Me.grdDetall.Required = False
        Me.grdDetall.RowHeadersVisible = False
        Me.grdDetall.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdDetall.Size = New System.Drawing.Size(1265, 180)
        Me.grdDetall.TabIndex = 11
        Me.grdDetall.TabStop = False
        Me.grdDetall.TextBoxAddBtm = Nothing
        Me.grdDetall.TextBoxAddTop = Nothing
        '
        'grp商品内訳
        '
        Me.grp商品内訳.Controls.Add(Me.grp商品内訳入力)
        Me.grp商品内訳.Controls.Add(Me.grdDetall)
        Me.grp商品内訳.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp商品内訳.Location = New System.Drawing.Point(0, 106)
        Me.grp商品内訳.Name = "grp商品内訳"
        Me.grp商品内訳.Size = New System.Drawing.Size(1280, 390)
        Me.grp商品内訳.TabIndex = 1
        Me.grp商品内訳.TabStop = False
        Me.grp商品内訳.Text = "【紙発注】"
        '
        'grp商品内訳入力
        '
        Me.grp商品内訳入力.Controls.Add(Me.nam単価区分)
        Me.grp商品内訳入力.Controls.Add(Me.ddl単価区分)
        Me.grp商品内訳入力.Controls.Add(Me.nam仕入先名)
        Me.grp商品内訳入力.Controls.Add(Me.nam仕入先名Title)
        Me.grp商品内訳入力.Controls.Add(Me.grp発注用摘要)
        Me.grp商品内訳入力.Controls.Add(Me.nam仕入先CD)
        Me.grp商品内訳入力.Controls.Add(Me.grp発注用詳細情報)
        Me.grp商品内訳入力.Controls.Add(Me.txt仕入先CD)
        Me.grp商品内訳入力.Controls.Add(Me.grp長さ算出詳細情報)
        Me.grp商品内訳入力.Controls.Add(Me.nam発注日付)
        Me.grp商品内訳入力.Controls.Add(Me.txt発注日付)
        Me.grp商品内訳入力.Controls.Add(Me.txt有償支給単価)
        Me.grp商品内訳入力.Controls.Add(Me.nam有償支給単価)
        Me.grp商品内訳入力.Controls.Add(Me.ddl支給区分)
        Me.grp商品内訳入力.Controls.Add(Me.nam支給区分)
        Me.grp商品内訳入力.Controls.Add(Me.txt発注単価)
        Me.grp商品内訳入力.Controls.Add(Me.nam発注単価)
        Me.grp商品内訳入力.Controls.Add(Me.ddl仕入先指定区分)
        Me.grp商品内訳入力.Controls.Add(Me.nam仕入先指定区分)
        Me.grp商品内訳入力.Controls.Add(Me.namサイズ)
        Me.grp商品内訳入力.Controls.Add(Me.txt長さm)
        Me.grp商品内訳入力.Controls.Add(Me.txt巾mm)
        Me.grp商品内訳入力.Controls.Add(Me.Label2)
        Me.grp商品内訳入力.Controls.Add(Me.nam台紙名)
        Me.grp商品内訳入力.Controls.Add(Me.txt台紙名)
        Me.grp商品内訳入力.Controls.Add(Me.nam台紙CD)
        Me.grp商品内訳入力.Controls.Add(Me.txt台紙CD)
        Me.grp商品内訳入力.Controls.Add(Me.nam糊名)
        Me.grp商品内訳入力.Controls.Add(Me.txt糊名)
        Me.grp商品内訳入力.Controls.Add(Me.nam糊CD)
        Me.grp商品内訳入力.Controls.Add(Me.txt糊CD)
        Me.grp商品内訳入力.Controls.Add(Me.nam紙名)
        Me.grp商品内訳入力.Controls.Add(Me.txt紙名)
        Me.grp商品内訳入力.Controls.Add(Me.nam紙CD)
        Me.grp商品内訳入力.Controls.Add(Me.txt紙CD)
        Me.grp商品内訳入力.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp商品内訳入力.Location = New System.Drawing.Point(5, 209)
        Me.grp商品内訳入力.Name = "grp商品内訳入力"
        Me.grp商品内訳入力.Size = New System.Drawing.Size(1270, 175)
        Me.grp商品内訳入力.TabIndex = 0
        Me.grp商品内訳入力.TabStop = False
        '
        'nam単価区分
        '
        Me.nam単価区分.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam単価区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.nam単価区分.Location = New System.Drawing.Point(888, 15)
        Me.nam単価区分.Name = "nam単価区分"
        Me.nam単価区分.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.nam単価区分.Size = New System.Drawing.Size(87, 24)
        Me.nam単価区分.StringLength = 0
        Me.nam単価区分.TabIndex = 150
        Me.nam単価区分.Text = "単価区分"
        Me.nam単価区分.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nam単価区分.TextStyle = BaseContents.TextBox.TextStyle.None
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
        Me.ddl単価区分.Location = New System.Drawing.Point(888, 40)
        Me.ddl単価区分.Name = "ddl単価区分"
        Me.ddl単価区分.Required = False
        Me.ddl単価区分.Size = New System.Drawing.Size(87, 24)
        Me.ddl単価区分.TabIndex = 12
        Me.ddl単価区分.ValueMember = "Value"
        '
        'nam仕入先名
        '
        Me.nam仕入先名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam仕入先名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam仕入先名.Location = New System.Drawing.Point(709, 41)
        Me.nam仕入先名.Name = "nam仕入先名"
        Me.nam仕入先名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam仕入先名.Size = New System.Drawing.Size(178, 23)
        Me.nam仕入先名.StringLength = 0
        Me.nam仕入先名.TabIndex = 11
        Me.nam仕入先名.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nam仕入先名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam仕入先名Title
        '
        Me.nam仕入先名Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam仕入先名Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam仕入先名Title.Location = New System.Drawing.Point(709, 15)
        Me.nam仕入先名Title.Name = "nam仕入先名Title"
        Me.nam仕入先名Title.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam仕入先名Title.Size = New System.Drawing.Size(178, 24)
        Me.nam仕入先名Title.StringLength = 0
        Me.nam仕入先名Title.TabIndex = 147
        Me.nam仕入先名Title.Text = "仕入先名"
        Me.nam仕入先名Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nam仕入先名Title.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp発注用摘要
        '
        Me.grp発注用摘要.Controls.Add(Me.txt発注用摘要3)
        Me.grp発注用摘要.Controls.Add(Me.txt発注用摘要2)
        Me.grp発注用摘要.Controls.Add(Me.txt発注用摘要1)
        Me.grp発注用摘要.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.grp発注用摘要.Location = New System.Drawing.Point(1036, 75)
        Me.grp発注用摘要.Name = "grp発注用摘要"
        Me.grp発注用摘要.Size = New System.Drawing.Size(230, 93)
        Me.grp発注用摘要.TabIndex = 146
        Me.grp発注用摘要.TabStop = False
        Me.grp発注用摘要.Text = "発注用摘要"
        '
        'txt発注用摘要3
        '
        Me.txt発注用摘要3.FieldLockType = BaseContents.Field.LockType.None
        Me.txt発注用摘要3.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt発注用摘要3.HelpKeys = ""
        Me.txt発注用摘要3.HelpLink = ""
        Me.txt発注用摘要3.HelpType = NodeUI.Help.Type.None
        Me.txt発注用摘要3.IsError = False
        Me.txt発注用摘要3.Location = New System.Drawing.Point(6, 63)
        Me.txt発注用摘要3.Name = "txt発注用摘要3"
        Me.txt発注用摘要3.Required = False
        Me.txt発注用摘要3.Size = New System.Drawing.Size(218, 23)
        Me.txt発注用摘要3.StringLength = 0
        Me.txt発注用摘要3.TabIndex = 2
        Me.txt発注用摘要3.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.txt発注用摘要3.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt発注用摘要2
        '
        Me.txt発注用摘要2.FieldLockType = BaseContents.Field.LockType.None
        Me.txt発注用摘要2.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt発注用摘要2.HelpKeys = ""
        Me.txt発注用摘要2.HelpLink = ""
        Me.txt発注用摘要2.HelpType = NodeUI.Help.Type.None
        Me.txt発注用摘要2.IsError = False
        Me.txt発注用摘要2.Location = New System.Drawing.Point(6, 40)
        Me.txt発注用摘要2.Name = "txt発注用摘要2"
        Me.txt発注用摘要2.Required = False
        Me.txt発注用摘要2.Size = New System.Drawing.Size(218, 23)
        Me.txt発注用摘要2.StringLength = 0
        Me.txt発注用摘要2.TabIndex = 1
        Me.txt発注用摘要2.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.txt発注用摘要2.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt発注用摘要1
        '
        Me.txt発注用摘要1.FieldLockType = BaseContents.Field.LockType.None
        Me.txt発注用摘要1.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt発注用摘要1.HelpKeys = ""
        Me.txt発注用摘要1.HelpLink = ""
        Me.txt発注用摘要1.HelpType = NodeUI.Help.Type.None
        Me.txt発注用摘要1.IsError = False
        Me.txt発注用摘要1.Location = New System.Drawing.Point(6, 17)
        Me.txt発注用摘要1.Name = "txt発注用摘要1"
        Me.txt発注用摘要1.Required = False
        Me.txt発注用摘要1.Size = New System.Drawing.Size(218, 23)
        Me.txt発注用摘要1.StringLength = 0
        Me.txt発注用摘要1.TabIndex = 0
        Me.txt発注用摘要1.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.txt発注用摘要1.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam仕入先CD
        '
        Me.nam仕入先CD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam仕入先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.nam仕入先CD.Location = New System.Drawing.Point(651, 15)
        Me.nam仕入先CD.Name = "nam仕入先CD"
        Me.nam仕入先CD.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam仕入先CD.Size = New System.Drawing.Size(57, 24)
        Me.nam仕入先CD.StringLength = 0
        Me.nam仕入先CD.TabIndex = 145
        Me.nam仕入先CD.Text = "仕入先CD"
        Me.nam仕入先CD.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam仕入先CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp発注用詳細情報
        '
        Me.grp発注用詳細情報.Controls.Add(Me.txt基準長)
        Me.grp発注用詳細情報.Controls.Add(Me.nam基準長)
        Me.grp発注用詳細情報.Controls.Add(Me.ddl希望時間帯区分)
        Me.grp発注用詳細情報.Controls.Add(Me.nam希望時間帯区分)
        Me.grp発注用詳細情報.Controls.Add(Me.nam希望納期日付)
        Me.grp発注用詳細情報.Controls.Add(Me.txt希望納期日付)
        Me.grp発注用詳細情報.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.grp発注用詳細情報.Location = New System.Drawing.Point(742, 75)
        Me.grp発注用詳細情報.Name = "grp発注用詳細情報"
        Me.grp発注用詳細情報.Size = New System.Drawing.Size(290, 70)
        Me.grp発注用詳細情報.TabIndex = 142
        Me.grp発注用詳細情報.TabStop = False
        Me.grp発注用詳細情報.Text = "発注用詳細情報"
        '
        'txt基準長
        '
        Me.txt基準長.FieldLockType = BaseContents.Field.LockType.None
        Me.txt基準長.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt基準長.HelpKeys = ""
        Me.txt基準長.HelpLink = ""
        Me.txt基準長.HelpType = NodeUI.Help.Type.None
        Me.txt基準長.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt基準長.IsError = False
        Me.txt基準長.Location = New System.Drawing.Point(234, 41)
        Me.txt基準長.Name = "txt基準長"
        Me.txt基準長.Required = False
        Me.txt基準長.Size = New System.Drawing.Size(50, 23)
        Me.txt基準長.StringLength = 0
        Me.txt基準長.TabIndex = 2
        Me.txt基準長.Text = "1,234"
        Me.txt基準長.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt基準長.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam基準長
        '
        Me.nam基準長.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam基準長.Font = New System.Drawing.Font("ＭＳ ゴシック", 7.0!)
        Me.nam基準長.Location = New System.Drawing.Point(234, 15)
        Me.nam基準長.Name = "nam基準長"
        Me.nam基準長.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.nam基準長.Size = New System.Drawing.Size(50, 24)
        Me.nam基準長.StringLength = 0
        Me.nam基準長.TabIndex = 145
        Me.nam基準長.Text = "1巻当り" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "m"
        Me.nam基準長.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam基準長.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'ddl希望時間帯区分
        '
        Me.ddl希望時間帯区分.AutoDropDown = True
        Me.ddl希望時間帯区分.DisplayMember = "Display"
        Me.ddl希望時間帯区分.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddl希望時間帯区分.FieldLockType = BaseContents.Field.LockType.None
        Me.ddl希望時間帯区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.ddl希望時間帯区分.FormattingEnabled = True
        Me.ddl希望時間帯区分.IsError = False
        Me.ddl希望時間帯区分.ListType = NodeUI.List.Type.None
        Me.ddl希望時間帯区分.Location = New System.Drawing.Point(98, 40)
        Me.ddl希望時間帯区分.Name = "ddl希望時間帯区分"
        Me.ddl希望時間帯区分.Required = False
        Me.ddl希望時間帯区分.Size = New System.Drawing.Size(135, 24)
        Me.ddl希望時間帯区分.TabIndex = 1
        Me.ddl希望時間帯区分.ValueMember = "Value"
        '
        'nam希望時間帯区分
        '
        Me.nam希望時間帯区分.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam希望時間帯区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.nam希望時間帯区分.Location = New System.Drawing.Point(98, 15)
        Me.nam希望時間帯区分.Name = "nam希望時間帯区分"
        Me.nam希望時間帯区分.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam希望時間帯区分.Size = New System.Drawing.Size(135, 24)
        Me.nam希望時間帯区分.StringLength = 0
        Me.nam希望時間帯区分.TabIndex = 136
        Me.nam希望時間帯区分.Text = "納入希望時間帯"
        Me.nam希望時間帯区分.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nam希望時間帯区分.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam希望納期日付
        '
        Me.nam希望納期日付.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam希望納期日付.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam希望納期日付.Location = New System.Drawing.Point(6, 15)
        Me.nam希望納期日付.Name = "nam希望納期日付"
        Me.nam希望納期日付.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam希望納期日付.Size = New System.Drawing.Size(90, 24)
        Me.nam希望納期日付.StringLength = 0
        Me.nam希望納期日付.TabIndex = 135
        Me.nam希望納期日付.Text = "希 望 日"
        Me.nam希望納期日付.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nam希望納期日付.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt希望納期日付
        '
        Me.txt希望納期日付.FieldLockType = BaseContents.Field.LockType.None
        Me.txt希望納期日付.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt希望納期日付.HelpKeys = ""
        Me.txt希望納期日付.HelpLink = ""
        Me.txt希望納期日付.HelpType = NodeUI.Help.Type.None
        Me.txt希望納期日付.IsError = False
        Me.txt希望納期日付.Location = New System.Drawing.Point(7, 41)
        Me.txt希望納期日付.Name = "txt希望納期日付"
        Me.txt希望納期日付.Required = False
        Me.txt希望納期日付.Size = New System.Drawing.Size(90, 23)
        Me.txt希望納期日付.StringLength = 0
        Me.txt希望納期日付.TabIndex = 0
        Me.txt希望納期日付.Text = "YYYY/MM/DD"
        Me.txt希望納期日付.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt仕入先CD
        '
        Me.txt仕入先CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt仕入先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt仕入先CD.HelpKeys = ""
        Me.txt仕入先CD.HelpLink = ""
        Me.txt仕入先CD.HelpType = NodeUI.Help.Type.None
        Me.txt仕入先CD.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt仕入先CD.IsError = False
        Me.txt仕入先CD.Location = New System.Drawing.Point(651, 41)
        Me.txt仕入先CD.Name = "txt仕入先CD"
        Me.txt仕入先CD.NumberMinor = 2
        Me.txt仕入先CD.Required = False
        Me.txt仕入先CD.Size = New System.Drawing.Size(57, 23)
        Me.txt仕入先CD.StringLength = 0
        Me.txt仕入先CD.TabIndex = 10
        Me.txt仕入先CD.Text = "XXXXXX"
        Me.txt仕入先CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp長さ算出詳細情報
        '
        Me.grp長さ算出詳細情報.Controls.Add(Me.txtその他m)
        Me.grp長さ算出詳細情報.Controls.Add(Me.namその他m)
        Me.grp長さ算出詳細情報.Controls.Add(Me.txtつなぎロス)
        Me.grp長さ算出詳細情報.Controls.Add(Me.namつなぎロス)
        Me.grp長さ算出詳細情報.Controls.Add(Me.txt刷出m)
        Me.grp長さ算出詳細情報.Controls.Add(Me.nam刷出m)
        Me.grp長さ算出詳細情報.Controls.Add(Me.nam送りmm)
        Me.grp長さ算出詳細情報.Controls.Add(Me.txt送りmm)
        Me.grp長さ算出詳細情報.Controls.Add(Me.txt通数)
        Me.grp長さ算出詳細情報.Controls.Add(Me.nam通数)
        Me.grp長さ算出詳細情報.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.grp長さ算出詳細情報.Location = New System.Drawing.Point(352, 75)
        Me.grp長さ算出詳細情報.Name = "grp長さ算出詳細情報"
        Me.grp長さ算出詳細情報.Size = New System.Drawing.Size(385, 70)
        Me.grp長さ算出詳細情報.TabIndex = 142
        Me.grp長さ算出詳細情報.TabStop = False
        Me.grp長さ算出詳細情報.Text = "長さ算出詳細情報"
        '
        'txtその他m
        '
        Me.txtその他m.FieldLockType = BaseContents.Field.LockType.None
        Me.txtその他m.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txtその他m.HelpKeys = ""
        Me.txtその他m.HelpLink = ""
        Me.txtその他m.HelpType = NodeUI.Help.Type.None
        Me.txtその他m.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtその他m.IsError = False
        Me.txtその他m.Location = New System.Drawing.Point(318, 42)
        Me.txtその他m.Name = "txtその他m"
        Me.txtその他m.Required = False
        Me.txtその他m.Size = New System.Drawing.Size(60, 23)
        Me.txtその他m.StringLength = 0
        Me.txtその他m.TabIndex = 4
        Me.txtその他m.Text = "12,345"
        Me.txtその他m.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtその他m.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'namその他m
        '
        Me.namその他m.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.namその他m.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.namその他m.Location = New System.Drawing.Point(318, 16)
        Me.namその他m.Name = "namその他m"
        Me.namその他m.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.namその他m.Size = New System.Drawing.Size(60, 24)
        Me.namその他m.StringLength = 0
        Me.namその他m.TabIndex = 143
        Me.namその他m.Text = "その他m"
        Me.namその他m.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.namその他m.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txtつなぎロス
        '
        Me.txtつなぎロス.FieldLockType = BaseContents.Field.LockType.None
        Me.txtつなぎロス.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txtつなぎロス.HelpKeys = ""
        Me.txtつなぎロス.HelpLink = ""
        Me.txtつなぎロス.HelpType = NodeUI.Help.Type.None
        Me.txtつなぎロス.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtつなぎロス.IsError = False
        Me.txtつなぎロス.Location = New System.Drawing.Point(257, 42)
        Me.txtつなぎロス.Name = "txtつなぎロス"
        Me.txtつなぎロス.Required = False
        Me.txtつなぎロス.Size = New System.Drawing.Size(60, 23)
        Me.txtつなぎロス.StringLength = 0
        Me.txtつなぎロス.TabIndex = 3
        Me.txtつなぎロス.Text = "123.45"
        Me.txtつなぎロス.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtつなぎロス.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'namつなぎロス
        '
        Me.namつなぎロス.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.namつなぎロス.Font = New System.Drawing.Font("ＭＳ ゴシック", 7.0!)
        Me.namつなぎロス.Location = New System.Drawing.Point(257, 16)
        Me.namつなぎロス.Name = "namつなぎロス"
        Me.namつなぎロス.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.namつなぎロス.Size = New System.Drawing.Size(60, 24)
        Me.namつなぎロス.StringLength = 0
        Me.namつなぎロス.TabIndex = 141
        Me.namつなぎロス.Text = "つなぎ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ﾛｽ%"
        Me.namつなぎロス.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.namつなぎロス.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt刷出m
        '
        Me.txt刷出m.FieldLockType = BaseContents.Field.LockType.None
        Me.txt刷出m.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt刷出m.HelpKeys = ""
        Me.txt刷出m.HelpLink = ""
        Me.txt刷出m.HelpType = NodeUI.Help.Type.None
        Me.txt刷出m.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt刷出m.IsError = False
        Me.txt刷出m.Location = New System.Drawing.Point(196, 42)
        Me.txt刷出m.Name = "txt刷出m"
        Me.txt刷出m.Required = False
        Me.txt刷出m.Size = New System.Drawing.Size(60, 23)
        Me.txt刷出m.StringLength = 0
        Me.txt刷出m.TabIndex = 2
        Me.txt刷出m.Text = "12,345"
        Me.txt刷出m.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt刷出m.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam刷出m
        '
        Me.nam刷出m.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam刷出m.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam刷出m.Location = New System.Drawing.Point(196, 16)
        Me.nam刷出m.Name = "nam刷出m"
        Me.nam刷出m.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam刷出m.Size = New System.Drawing.Size(60, 24)
        Me.nam刷出m.StringLength = 0
        Me.nam刷出m.TabIndex = 139
        Me.nam刷出m.Text = "刷出m"
        Me.nam刷出m.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam刷出m.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam送りmm
        '
        Me.nam送りmm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam送りmm.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam送りmm.Location = New System.Drawing.Point(105, 16)
        Me.nam送りmm.Name = "nam送りmm"
        Me.nam送りmm.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam送りmm.Size = New System.Drawing.Size(90, 24)
        Me.nam送りmm.StringLength = 0
        Me.nam送りmm.TabIndex = 138
        Me.nam送りmm.Text = "送りmm"
        Me.nam送りmm.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam送りmm.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt送りmm
        '
        Me.txt送りmm.FieldLockType = BaseContents.Field.LockType.None
        Me.txt送りmm.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt送りmm.HelpKeys = ""
        Me.txt送りmm.HelpLink = ""
        Me.txt送りmm.HelpType = NodeUI.Help.Type.None
        Me.txt送りmm.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt送りmm.IsError = False
        Me.txt送りmm.Location = New System.Drawing.Point(105, 42)
        Me.txt送りmm.Name = "txt送りmm"
        Me.txt送りmm.NumberMinor = 2
        Me.txt送りmm.Required = False
        Me.txt送りmm.Size = New System.Drawing.Size(90, 23)
        Me.txt送りmm.StringLength = 0
        Me.txt送りmm.TabIndex = 1
        Me.txt送りmm.Text = "123,456.78"
        Me.txt送りmm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt送りmm.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt通数
        '
        Me.txt通数.FieldLockType = BaseContents.Field.LockType.None
        Me.txt通数.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt通数.HelpKeys = ""
        Me.txt通数.HelpLink = ""
        Me.txt通数.HelpType = NodeUI.Help.Type.None
        Me.txt通数.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt通数.IsError = False
        Me.txt通数.Location = New System.Drawing.Point(8, 42)
        Me.txt通数.Name = "txt通数"
        Me.txt通数.Required = False
        Me.txt通数.Size = New System.Drawing.Size(95, 23)
        Me.txt通数.StringLength = 0
        Me.txt通数.TabIndex = 0
        Me.txt通数.Text = "123,456,789"
        Me.txt通数.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt通数.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam通数
        '
        Me.nam通数.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam通数.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam通数.Location = New System.Drawing.Point(8, 16)
        Me.nam通数.Name = "nam通数"
        Me.nam通数.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam通数.Size = New System.Drawing.Size(95, 24)
        Me.nam通数.StringLength = 0
        Me.nam通数.TabIndex = 137
        Me.nam通数.Text = "通  数"
        Me.nam通数.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam通数.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam発注日付
        '
        Me.nam発注日付.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam発注日付.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam発注日付.Location = New System.Drawing.Point(1175, 15)
        Me.nam発注日付.Name = "nam発注日付"
        Me.nam発注日付.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam発注日付.Size = New System.Drawing.Size(90, 24)
        Me.nam発注日付.StringLength = 0
        Me.nam発注日付.TabIndex = 133
        Me.nam発注日付.Text = "発注年月日"
        Me.nam発注日付.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nam発注日付.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt発注日付
        '
        Me.txt発注日付.FieldLockType = BaseContents.Field.LockType.None
        Me.txt発注日付.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt発注日付.HelpKeys = ""
        Me.txt発注日付.HelpLink = ""
        Me.txt発注日付.HelpType = NodeUI.Help.Type.None
        Me.txt発注日付.IsError = False
        Me.txt発注日付.Location = New System.Drawing.Point(1175, 41)
        Me.txt発注日付.Name = "txt発注日付"
        Me.txt発注日付.Required = False
        Me.txt発注日付.Size = New System.Drawing.Size(90, 23)
        Me.txt発注日付.StringLength = 0
        Me.txt発注日付.TabIndex = 16
        Me.txt発注日付.Text = "YYYY/MM/DD"
        Me.txt発注日付.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt有償支給単価
        '
        Me.txt有償支給単価.FieldLockType = BaseContents.Field.LockType.None
        Me.txt有償支給単価.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt有償支給単価.HelpKeys = ""
        Me.txt有償支給単価.HelpLink = ""
        Me.txt有償支給単価.HelpType = NodeUI.Help.Type.None
        Me.txt有償支給単価.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt有償支給単価.IsError = False
        Me.txt有償支給単価.Location = New System.Drawing.Point(1116, 41)
        Me.txt有償支給単価.Name = "txt有償支給単価"
        Me.txt有償支給単価.Required = False
        Me.txt有償支給単価.Size = New System.Drawing.Size(58, 23)
        Me.txt有償支給単価.StringLength = 0
        Me.txt有償支給単価.TabIndex = 15
        Me.txt有償支給単価.Text = "123.45"
        Me.txt有償支給単価.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt有償支給単価.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam有償支給単価
        '
        Me.nam有償支給単価.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam有償支給単価.Font = New System.Drawing.Font("ＭＳ ゴシック", 7.0!)
        Me.nam有償支給単価.Location = New System.Drawing.Point(1116, 15)
        Me.nam有償支給単価.Name = "nam有償支給単価"
        Me.nam有償支給単価.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.nam有償支給単価.Size = New System.Drawing.Size(58, 24)
        Me.nam有償支給単価.StringLength = 0
        Me.nam有償支給単価.TabIndex = 131
        Me.nam有償支給単価.Text = "有償支給" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "単価"
        Me.nam有償支給単価.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nam有償支給単価.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'ddl支給区分
        '
        Me.ddl支給区分.AutoDropDown = True
        Me.ddl支給区分.DisplayMember = "Display"
        Me.ddl支給区分.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddl支給区分.FieldLockType = BaseContents.Field.LockType.None
        Me.ddl支給区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.ddl支給区分.FormattingEnabled = True
        Me.ddl支給区分.IsError = False
        Me.ddl支給区分.ListType = NodeUI.List.Type.None
        Me.ddl支給区分.Location = New System.Drawing.Point(1059, 40)
        Me.ddl支給区分.Name = "ddl支給区分"
        Me.ddl支給区分.Required = False
        Me.ddl支給区分.Size = New System.Drawing.Size(55, 24)
        Me.ddl支給区分.TabIndex = 14
        Me.ddl支給区分.ValueMember = "Value"
        '
        'nam支給区分
        '
        Me.nam支給区分.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam支給区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 8.5!)
        Me.nam支給区分.Location = New System.Drawing.Point(1059, 15)
        Me.nam支給区分.Name = "nam支給区分"
        Me.nam支給区分.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.nam支給区分.Size = New System.Drawing.Size(55, 24)
        Me.nam支給区分.StringLength = 0
        Me.nam支給区分.TabIndex = 128
        Me.nam支給区分.Text = "支給" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "区分"
        Me.nam支給区分.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nam支給区分.TextStyle = BaseContents.TextBox.TextStyle.None
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
        Me.txt発注単価.Location = New System.Drawing.Point(976, 41)
        Me.txt発注単価.Name = "txt発注単価"
        Me.txt発注単価.Required = False
        Me.txt発注単価.Size = New System.Drawing.Size(82, 23)
        Me.txt発注単価.StringLength = 0
        Me.txt発注単価.TabIndex = 13
        Me.txt発注単価.Text = "12,345.67"
        Me.txt発注単価.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt発注単価.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam発注単価
        '
        Me.nam発注単価.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam発注単価.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam発注単価.Location = New System.Drawing.Point(976, 15)
        Me.nam発注単価.Name = "nam発注単価"
        Me.nam発注単価.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam発注単価.Size = New System.Drawing.Size(82, 24)
        Me.nam発注単価.StringLength = 0
        Me.nam発注単価.TabIndex = 127
        Me.nam発注単価.Text = "発注単価"
        Me.nam発注単価.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nam発注単価.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'ddl仕入先指定区分
        '
        Me.ddl仕入先指定区分.AutoDropDown = True
        Me.ddl仕入先指定区分.DisplayMember = "Display"
        Me.ddl仕入先指定区分.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddl仕入先指定区分.FieldLockType = BaseContents.Field.LockType.None
        Me.ddl仕入先指定区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.ddl仕入先指定区分.FormattingEnabled = True
        Me.ddl仕入先指定区分.IsError = False
        Me.ddl仕入先指定区分.ListType = NodeUI.List.Type.None
        Me.ddl仕入先指定区分.Location = New System.Drawing.Point(605, 40)
        Me.ddl仕入先指定区分.Name = "ddl仕入先指定区分"
        Me.ddl仕入先指定区分.Required = False
        Me.ddl仕入先指定区分.Size = New System.Drawing.Size(45, 24)
        Me.ddl仕入先指定区分.TabIndex = 9
        Me.ddl仕入先指定区分.ValueMember = "Value"
        '
        'nam仕入先指定区分
        '
        Me.nam仕入先指定区分.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam仕入先指定区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 7.0!)
        Me.nam仕入先指定区分.Location = New System.Drawing.Point(605, 15)
        Me.nam仕入先指定区分.Name = "nam仕入先指定区分"
        Me.nam仕入先指定区分.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.nam仕入先指定区分.Size = New System.Drawing.Size(45, 24)
        Me.nam仕入先指定区分.StringLength = 0
        Me.nam仕入先指定区分.TabIndex = 124
        Me.nam仕入先指定区分.Text = "仕入先" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "指定"
        Me.nam仕入先指定区分.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nam仕入先指定区分.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'namサイズ
        '
        Me.namサイズ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.namサイズ.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.namサイズ.Location = New System.Drawing.Point(485, 15)
        Me.namサイズ.Name = "namサイズ"
        Me.namサイズ.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.namサイズ.Size = New System.Drawing.Size(119, 24)
        Me.namサイズ.StringLength = 0
        Me.namサイズ.TabIndex = 123
        Me.namサイズ.Text = "巾mm×  長さm"
        Me.namサイズ.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.namサイズ.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt長さm
        '
        Me.txt長さm.FieldLockType = BaseContents.Field.LockType.None
        Me.txt長さm.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt長さm.HelpKeys = ""
        Me.txt長さm.HelpLink = ""
        Me.txt長さm.HelpType = NodeUI.Help.Type.None
        Me.txt長さm.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt長さm.IsError = False
        Me.txt長さm.Location = New System.Drawing.Point(536, 41)
        Me.txt長さm.Name = "txt長さm"
        Me.txt長さm.Required = False
        Me.txt長さm.Size = New System.Drawing.Size(68, 23)
        Me.txt長さm.StringLength = 0
        Me.txt長さm.TabIndex = 8
        Me.txt長さm.Text = "123,456"
        Me.txt長さm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt長さm.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt巾mm
        '
        Me.txt巾mm.FieldLockType = BaseContents.Field.LockType.None
        Me.txt巾mm.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt巾mm.HelpKeys = ""
        Me.txt巾mm.HelpLink = ""
        Me.txt巾mm.HelpType = NodeUI.Help.Type.None
        Me.txt巾mm.IsError = False
        Me.txt巾mm.Location = New System.Drawing.Point(485, 41)
        Me.txt巾mm.Name = "txt巾mm"
        Me.txt巾mm.Required = False
        Me.txt巾mm.Size = New System.Drawing.Size(35, 23)
        Me.txt巾mm.StringLength = 0
        Me.txt巾mm.TabIndex = 6
        Me.txt巾mm.Text = "123"
        Me.txt巾mm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt巾mm.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(517, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "×"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'nam台紙名
        '
        Me.nam台紙名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam台紙名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam台紙名.Location = New System.Drawing.Point(379, 15)
        Me.nam台紙名.Name = "nam台紙名"
        Me.nam台紙名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam台紙名.Size = New System.Drawing.Size(105, 24)
        Me.nam台紙名.StringLength = 0
        Me.nam台紙名.TabIndex = 107
        Me.nam台紙名.Text = "台 紙 名"
        Me.nam台紙名.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nam台紙名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt台紙名
        '
        Me.txt台紙名.FieldLockType = BaseContents.Field.LockType.None
        Me.txt台紙名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt台紙名.HelpKeys = ""
        Me.txt台紙名.HelpLink = ""
        Me.txt台紙名.HelpType = NodeUI.Help.Type.None
        Me.txt台紙名.IsError = False
        Me.txt台紙名.Location = New System.Drawing.Point(379, 41)
        Me.txt台紙名.Name = "txt台紙名"
        Me.txt台紙名.Required = False
        Me.txt台紙名.Size = New System.Drawing.Size(105, 23)
        Me.txt台紙名.StringLength = 0
        Me.txt台紙名.TabIndex = 5
        Me.txt台紙名.Text = "XXXXXXXXXXXX"
        Me.txt台紙名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam台紙CD
        '
        Me.nam台紙CD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam台紙CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 7.0!)
        Me.nam台紙CD.Location = New System.Drawing.Point(353, 15)
        Me.nam台紙CD.Name = "nam台紙CD"
        Me.nam台紙CD.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.nam台紙CD.Size = New System.Drawing.Size(25, 24)
        Me.nam台紙CD.StringLength = 0
        Me.nam台紙CD.TabIndex = 105
        Me.nam台紙CD.Text = "台" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "紙"
        Me.nam台紙CD.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam台紙CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt台紙CD
        '
        Me.txt台紙CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt台紙CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt台紙CD.HelpKeys = ""
        Me.txt台紙CD.HelpLink = ""
        Me.txt台紙CD.HelpType = NodeUI.Help.Type.None
        Me.txt台紙CD.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt台紙CD.IsError = False
        Me.txt台紙CD.Location = New System.Drawing.Point(353, 41)
        Me.txt台紙CD.Name = "txt台紙CD"
        Me.txt台紙CD.NumberMinor = 2
        Me.txt台紙CD.Required = False
        Me.txt台紙CD.Size = New System.Drawing.Size(25, 23)
        Me.txt台紙CD.StringLength = 0
        Me.txt台紙CD.TabIndex = 4
        Me.txt台紙CD.Text = "XX"
        Me.txt台紙CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam糊名
        '
        Me.nam糊名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam糊名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam糊名.Location = New System.Drawing.Point(247, 15)
        Me.nam糊名.Name = "nam糊名"
        Me.nam糊名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam糊名.Size = New System.Drawing.Size(105, 24)
        Me.nam糊名.StringLength = 0
        Me.nam糊名.TabIndex = 103
        Me.nam糊名.Text = "糊   名"
        Me.nam糊名.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nam糊名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt糊名
        '
        Me.txt糊名.FieldLockType = BaseContents.Field.LockType.None
        Me.txt糊名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt糊名.HelpKeys = ""
        Me.txt糊名.HelpLink = ""
        Me.txt糊名.HelpType = NodeUI.Help.Type.None
        Me.txt糊名.IsError = False
        Me.txt糊名.Location = New System.Drawing.Point(247, 41)
        Me.txt糊名.Name = "txt糊名"
        Me.txt糊名.Required = False
        Me.txt糊名.Size = New System.Drawing.Size(105, 23)
        Me.txt糊名.StringLength = 0
        Me.txt糊名.TabIndex = 3
        Me.txt糊名.Text = "XXXXXXXXXXXX"
        Me.txt糊名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam糊CD
        '
        Me.nam糊CD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam糊CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 8.5!)
        Me.nam糊CD.Location = New System.Drawing.Point(216, 15)
        Me.nam糊CD.Name = "nam糊CD"
        Me.nam糊CD.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.nam糊CD.Size = New System.Drawing.Size(30, 24)
        Me.nam糊CD.StringLength = 0
        Me.nam糊CD.TabIndex = 101
        Me.nam糊CD.Text = "糊CD"
        Me.nam糊CD.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam糊CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt糊CD
        '
        Me.txt糊CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt糊CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt糊CD.HelpKeys = ""
        Me.txt糊CD.HelpLink = ""
        Me.txt糊CD.HelpType = NodeUI.Help.Type.None
        Me.txt糊CD.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt糊CD.IsError = False
        Me.txt糊CD.Location = New System.Drawing.Point(216, 41)
        Me.txt糊CD.Name = "txt糊CD"
        Me.txt糊CD.NumberMinor = 2
        Me.txt糊CD.Required = False
        Me.txt糊CD.Size = New System.Drawing.Size(30, 23)
        Me.txt糊CD.StringLength = 0
        Me.txt糊CD.TabIndex = 2
        Me.txt糊CD.Text = "XXX"
        Me.txt糊CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam紙名
        '
        Me.nam紙名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam紙名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam紙名.Location = New System.Drawing.Point(45, 15)
        Me.nam紙名.Name = "nam紙名"
        Me.nam紙名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam紙名.Size = New System.Drawing.Size(170, 24)
        Me.nam紙名.StringLength = 0
        Me.nam紙名.TabIndex = 82
        Me.nam紙名.Text = "紙   名"
        Me.nam紙名.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nam紙名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt紙名
        '
        Me.txt紙名.FieldLockType = BaseContents.Field.LockType.None
        Me.txt紙名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt紙名.HelpKeys = ""
        Me.txt紙名.HelpLink = ""
        Me.txt紙名.HelpType = NodeUI.Help.Type.None
        Me.txt紙名.IsError = False
        Me.txt紙名.Location = New System.Drawing.Point(45, 41)
        Me.txt紙名.Name = "txt紙名"
        Me.txt紙名.Required = False
        Me.txt紙名.Size = New System.Drawing.Size(170, 23)
        Me.txt紙名.StringLength = 0
        Me.txt紙名.TabIndex = 1
        Me.txt紙名.Text = "XXXXXXXXXXXXXXXXXXXX"
        Me.txt紙名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam紙CD
        '
        Me.nam紙CD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam紙CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.nam紙CD.Location = New System.Drawing.Point(4, 15)
        Me.nam紙CD.Name = "nam紙CD"
        Me.nam紙CD.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.nam紙CD.Size = New System.Drawing.Size(40, 24)
        Me.nam紙CD.StringLength = 0
        Me.nam紙CD.TabIndex = 73
        Me.nam紙CD.Text = "紙CD"
        Me.nam紙CD.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam紙CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt紙CD
        '
        Me.txt紙CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt紙CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt紙CD.HelpKeys = ""
        Me.txt紙CD.HelpLink = ""
        Me.txt紙CD.HelpType = NodeUI.Help.Type.None
        Me.txt紙CD.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt紙CD.IsError = False
        Me.txt紙CD.Location = New System.Drawing.Point(4, 41)
        Me.txt紙CD.Name = "txt紙CD"
        Me.txt紙CD.NumberMinor = 2
        Me.txt紙CD.Required = False
        Me.txt紙CD.Size = New System.Drawing.Size(40, 23)
        Me.txt紙CD.StringLength = 0
        Me.txt紙CD.TabIndex = 0
        Me.txt紙CD.Text = "XXXX"
        Me.txt紙CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'btn戻る
        '
        Me.btn戻る.FieldLockType = BaseContents.Field.LockType.Data
        Me.btn戻る.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.btn戻る.Location = New System.Drawing.Point(797, 526)
        Me.btn戻る.Name = "btn戻る"
        Me.btn戻る.Size = New System.Drawing.Size(208, 48)
        Me.btn戻る.TabIndex = 4
        Me.btn戻る.Text = "前画面へ戻る"
        Me.btn戻る.UseVisualStyleBackColor = True
        '
        'grp仕上方法
        '
        Me.grp仕上方法.Controls.Add(Me.txt送りピッチ)
        Me.grp仕上方法.Controls.Add(Me.nam送りピッチ)
        Me.grp仕上方法.Controls.Add(Me.txt梱包枚数)
        Me.grp仕上方法.Controls.Add(Me.nam梱包枚数)
        Me.grp仕上方法.Controls.Add(Me.namカット)
        Me.grp仕上方法.Controls.Add(Me.txtカット3)
        Me.grp仕上方法.Controls.Add(Me.txtカット2)
        Me.grp仕上方法.Controls.Add(Me.txtスリッター区分名)
        Me.grp仕上方法.Controls.Add(Me.ddlスリッター区分)
        Me.grp仕上方法.Controls.Add(Me.txtカット1)
        Me.grp仕上方法.Controls.Add(Me.namスリッター)
        Me.grp仕上方法.Controls.Add(Me.Label1)
        Me.grp仕上方法.Controls.Add(Me.txt枚数)
        Me.grp仕上方法.Controls.Add(Me.lbl刃型サイズ一面角単位)
        Me.grp仕上方法.Controls.Add(Me.nam枚数)
        Me.grp仕上方法.Controls.Add(Me.txt紙管)
        Me.grp仕上方法.Controls.Add(Me.nam紙管)
        Me.grp仕上方法.Controls.Add(Me.txt出し方向区分名)
        Me.grp仕上方法.Controls.Add(Me.ddl出し方向区分)
        Me.grp仕上方法.Controls.Add(Me.nam出し方向)
        Me.grp仕上方法.Controls.Add(Me.txt巻取区分名)
        Me.grp仕上方法.Controls.Add(Me.ddl巻取区分)
        Me.grp仕上方法.Controls.Add(Me.txtスリッター巾)
        Me.grp仕上方法.Controls.Add(Me.namスリッター巾)
        Me.grp仕上方法.Controls.Add(Me.nam巻取)
        Me.grp仕上方法.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp仕上方法.Location = New System.Drawing.Point(7, 10)
        Me.grp仕上方法.Name = "grp仕上方法"
        Me.grp仕上方法.Size = New System.Drawing.Size(800, 90)
        Me.grp仕上方法.TabIndex = 0
        Me.grp仕上方法.TabStop = False
        Me.grp仕上方法.Text = "【仕上方法の指示】"
        '
        'txt送りピッチ
        '
        Me.txt送りピッチ.FieldLockType = BaseContents.Field.LockType.None
        Me.txt送りピッチ.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt送りピッチ.HelpKeys = ""
        Me.txt送りピッチ.HelpLink = ""
        Me.txt送りピッチ.HelpType = NodeUI.Help.Type.None
        Me.txt送りピッチ.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt送りピッチ.IsError = False
        Me.txt送りピッチ.Location = New System.Drawing.Point(719, 51)
        Me.txt送りピッチ.Name = "txt送りピッチ"
        Me.txt送りピッチ.Required = False
        Me.txt送りピッチ.Size = New System.Drawing.Size(68, 23)
        Me.txt送りピッチ.StringLength = 0
        Me.txt送りピッチ.TabIndex = 118
        Me.txt送りピッチ.Text = "123.456"
        Me.txt送りピッチ.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt送りピッチ.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam送りピッチ
        '
        Me.nam送りピッチ.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam送りピッチ.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.nam送りピッチ.Location = New System.Drawing.Point(719, 25)
        Me.nam送りピッチ.Name = "nam送りピッチ"
        Me.nam送りピッチ.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam送りピッチ.Size = New System.Drawing.Size(68, 23)
        Me.nam送りピッチ.StringLength = 0
        Me.nam送りピッチ.TabIndex = 119
        Me.nam送りピッチ.Text = "送りﾋﾟｯﾁ"
        Me.nam送りピッチ.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nam送りピッチ.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt梱包枚数
        '
        Me.txt梱包枚数.FieldLockType = BaseContents.Field.LockType.None
        Me.txt梱包枚数.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt梱包枚数.HelpKeys = ""
        Me.txt梱包枚数.HelpLink = ""
        Me.txt梱包枚数.HelpType = NodeUI.Help.Type.None
        Me.txt梱包枚数.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt梱包枚数.IsError = False
        Me.txt梱包枚数.Location = New System.Drawing.Point(659, 51)
        Me.txt梱包枚数.Name = "txt梱包枚数"
        Me.txt梱包枚数.Required = False
        Me.txt梱包枚数.Size = New System.Drawing.Size(58, 23)
        Me.txt梱包枚数.StringLength = 0
        Me.txt梱包枚数.TabIndex = 116
        Me.txt梱包枚数.Text = "12,345"
        Me.txt梱包枚数.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt梱包枚数.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam梱包枚数
        '
        Me.nam梱包枚数.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam梱包枚数.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.nam梱包枚数.Location = New System.Drawing.Point(659, 25)
        Me.nam梱包枚数.Name = "nam梱包枚数"
        Me.nam梱包枚数.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam梱包枚数.Size = New System.Drawing.Size(58, 23)
        Me.nam梱包枚数.StringLength = 0
        Me.nam梱包枚数.TabIndex = 117
        Me.nam梱包枚数.Text = "梱包枚数"
        Me.nam梱包枚数.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nam梱包枚数.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'namカット
        '
        Me.namカット.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.namカット.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.namカット.Location = New System.Drawing.Point(495, 25)
        Me.namカット.Name = "namカット"
        Me.namカット.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.namカット.Size = New System.Drawing.Size(163, 23)
        Me.namカット.StringLength = 0
        Me.namカット.TabIndex = 115
        Me.namカット.Text = "カット"
        Me.namカット.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.namカット.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txtカット3
        '
        Me.txtカット3.FieldLockType = BaseContents.Field.LockType.None
        Me.txtカット3.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txtカット3.HelpKeys = ""
        Me.txtカット3.HelpLink = ""
        Me.txtカット3.HelpType = NodeUI.Help.Type.None
        Me.txtカット3.IsError = False
        Me.txtカット3.Location = New System.Drawing.Point(608, 51)
        Me.txtカット3.Name = "txtカット3"
        Me.txtカット3.Required = False
        Me.txtカット3.Size = New System.Drawing.Size(50, 23)
        Me.txtカット3.StringLength = 0
        Me.txtカット3.TabIndex = 107
        Me.txtカット3.Text = "1,234"
        Me.txtカット3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtカット3.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txtカット2
        '
        Me.txtカット2.FieldLockType = BaseContents.Field.LockType.None
        Me.txtカット2.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txtカット2.HelpKeys = ""
        Me.txtカット2.HelpLink = ""
        Me.txtカット2.HelpType = NodeUI.Help.Type.None
        Me.txtカット2.IsError = False
        Me.txtカット2.Location = New System.Drawing.Point(550, 51)
        Me.txtカット2.Name = "txtカット2"
        Me.txtカット2.Required = False
        Me.txtカット2.Size = New System.Drawing.Size(35, 23)
        Me.txtカット2.StringLength = 0
        Me.txtカット2.TabIndex = 103
        Me.txtカット2.Text = "123"
        Me.txtカット2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtカット2.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txtスリッター区分名
        '
        Me.txtスリッター区分名.FieldLockType = BaseContents.Field.LockType.None
        Me.txtスリッター区分名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txtスリッター区分名.HelpKeys = ""
        Me.txtスリッター区分名.HelpLink = ""
        Me.txtスリッター区分名.HelpType = NodeUI.Help.Type.None
        Me.txtスリッター区分名.IsError = False
        Me.txtスリッター区分名.Location = New System.Drawing.Point(380, 50)
        Me.txtスリッター区分名.Name = "txtスリッター区分名"
        Me.txtスリッター区分名.Required = False
        Me.txtスリッター区分名.Size = New System.Drawing.Size(40, 23)
        Me.txtスリッター区分名.StringLength = 0
        Me.txtスリッター区分名.TabIndex = 113
        Me.txtスリッター区分名.Text = "XXXX"
        Me.txtスリッター区分名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'ddlスリッター区分
        '
        Me.ddlスリッター区分.AutoDropDown = True
        Me.ddlスリッター区分.DisplayMember = "Display"
        Me.ddlスリッター区分.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlスリッター区分.FieldLockType = BaseContents.Field.LockType.None
        Me.ddlスリッター区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.ddlスリッター区分.FormattingEnabled = True
        Me.ddlスリッター区分.IsError = False
        Me.ddlスリッター区分.ListType = NodeUI.List.Type.None
        Me.ddlスリッター区分.Location = New System.Drawing.Point(308, 50)
        Me.ddlスリッター区分.Name = "ddlスリッター区分"
        Me.ddlスリッター区分.Required = False
        Me.ddlスリッター区分.Size = New System.Drawing.Size(73, 24)
        Me.ddlスリッター区分.TabIndex = 112
        Me.ddlスリッター区分.ValueMember = "Value"
        '
        'txtカット1
        '
        Me.txtカット1.FieldLockType = BaseContents.Field.LockType.None
        Me.txtカット1.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txtカット1.HelpKeys = ""
        Me.txtカット1.HelpLink = ""
        Me.txtカット1.HelpType = NodeUI.Help.Type.None
        Me.txtカット1.IsError = False
        Me.txtカット1.Location = New System.Drawing.Point(494, 51)
        Me.txtカット1.Name = "txtカット1"
        Me.txtカット1.Required = False
        Me.txtカット1.Size = New System.Drawing.Size(35, 23)
        Me.txtカット1.StringLength = 0
        Me.txtカット1.TabIndex = 102
        Me.txtカット1.Text = "123"
        Me.txtカット1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtカット1.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'namスリッター
        '
        Me.namスリッター.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.namスリッター.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.namスリッター.Location = New System.Drawing.Point(308, 25)
        Me.namスリッター.Name = "namスリッター"
        Me.namスリッター.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.namスリッター.Size = New System.Drawing.Size(112, 23)
        Me.namスリッター.StringLength = 0
        Me.namスリッター.TabIndex = 111
        Me.namスリッター.Text = "スリッター"
        Me.namスリッター.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.namスリッター.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(586, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 16)
        Me.Label1.TabIndex = 106
        Me.Label1.Text = "＝"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt枚数
        '
        Me.txt枚数.FieldLockType = BaseContents.Field.LockType.None
        Me.txt枚数.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt枚数.HelpKeys = ""
        Me.txt枚数.HelpLink = ""
        Me.txt枚数.HelpType = NodeUI.Help.Type.None
        Me.txt枚数.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt枚数.IsError = False
        Me.txt枚数.Location = New System.Drawing.Point(256, 51)
        Me.txt枚数.Name = "txt枚数"
        Me.txt枚数.Required = False
        Me.txt枚数.Size = New System.Drawing.Size(50, 23)
        Me.txt枚数.StringLength = 0
        Me.txt枚数.TabIndex = 109
        Me.txt枚数.Text = "1,234"
        Me.txt枚数.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt枚数.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'lbl刃型サイズ一面角単位
        '
        Me.lbl刃型サイズ一面角単位.AutoSize = True
        Me.lbl刃型サイズ一面角単位.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.lbl刃型サイズ一面角単位.Location = New System.Drawing.Point(528, 54)
        Me.lbl刃型サイズ一面角単位.Name = "lbl刃型サイズ一面角単位"
        Me.lbl刃型サイズ一面角単位.Size = New System.Drawing.Size(24, 16)
        Me.lbl刃型サイズ一面角単位.TabIndex = 104
        Me.lbl刃型サイズ一面角単位.Text = "×"
        Me.lbl刃型サイズ一面角単位.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'nam枚数
        '
        Me.nam枚数.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam枚数.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam枚数.Location = New System.Drawing.Point(256, 25)
        Me.nam枚数.Name = "nam枚数"
        Me.nam枚数.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam枚数.Size = New System.Drawing.Size(50, 23)
        Me.nam枚数.StringLength = 0
        Me.nam枚数.TabIndex = 110
        Me.nam枚数.Text = "枚数"
        Me.nam枚数.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nam枚数.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt紙管
        '
        Me.txt紙管.FieldLockType = BaseContents.Field.LockType.None
        Me.txt紙管.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt紙管.HelpKeys = ""
        Me.txt紙管.HelpLink = ""
        Me.txt紙管.HelpType = NodeUI.Help.Type.None
        Me.txt紙管.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt紙管.IsError = False
        Me.txt紙管.Location = New System.Drawing.Point(205, 51)
        Me.txt紙管.Name = "txt紙管"
        Me.txt紙管.Required = False
        Me.txt紙管.Size = New System.Drawing.Size(50, 23)
        Me.txt紙管.StringLength = 0
        Me.txt紙管.TabIndex = 107
        Me.txt紙管.Text = "1,234"
        Me.txt紙管.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt紙管.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam紙管
        '
        Me.nam紙管.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam紙管.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam紙管.Location = New System.Drawing.Point(205, 25)
        Me.nam紙管.Name = "nam紙管"
        Me.nam紙管.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam紙管.Size = New System.Drawing.Size(50, 23)
        Me.nam紙管.StringLength = 0
        Me.nam紙管.TabIndex = 108
        Me.nam紙管.Text = "紙管"
        Me.nam紙管.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nam紙管.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt出し方向区分名
        '
        Me.txt出し方向区分名.FieldLockType = BaseContents.Field.LockType.None
        Me.txt出し方向区分名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt出し方向区分名.HelpKeys = ""
        Me.txt出し方向区分名.HelpLink = ""
        Me.txt出し方向区分名.HelpType = NodeUI.Help.Type.None
        Me.txt出し方向区分名.IsError = False
        Me.txt出し方向区分名.Location = New System.Drawing.Point(164, 50)
        Me.txt出し方向区分名.Name = "txt出し方向区分名"
        Me.txt出し方向区分名.Required = False
        Me.txt出し方向区分名.Size = New System.Drawing.Size(40, 23)
        Me.txt出し方向区分名.StringLength = 0
        Me.txt出し方向区分名.TabIndex = 106
        Me.txt出し方向区分名.Text = "XXXX"
        Me.txt出し方向区分名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'ddl出し方向区分
        '
        Me.ddl出し方向区分.AutoDropDown = True
        Me.ddl出し方向区分.DisplayMember = "Display"
        Me.ddl出し方向区分.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddl出し方向区分.FieldLockType = BaseContents.Field.LockType.None
        Me.ddl出し方向区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.ddl出し方向区分.FormattingEnabled = True
        Me.ddl出し方向区分.IsError = False
        Me.ddl出し方向区分.ListType = NodeUI.List.Type.None
        Me.ddl出し方向区分.Location = New System.Drawing.Point(107, 50)
        Me.ddl出し方向区分.Name = "ddl出し方向区分"
        Me.ddl出し方向区分.Required = False
        Me.ddl出し方向区分.Size = New System.Drawing.Size(58, 24)
        Me.ddl出し方向区分.TabIndex = 105
        Me.ddl出し方向区分.ValueMember = "Value"
        '
        'nam出し方向
        '
        Me.nam出し方向.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam出し方向.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam出し方向.Location = New System.Drawing.Point(107, 25)
        Me.nam出し方向.Name = "nam出し方向"
        Me.nam出し方向.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam出し方向.Size = New System.Drawing.Size(97, 23)
        Me.nam出し方向.StringLength = 0
        Me.nam出し方向.TabIndex = 104
        Me.nam出し方向.Text = "出し方向"
        Me.nam出し方向.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nam出し方向.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt巻取区分名
        '
        Me.txt巻取区分名.FieldLockType = BaseContents.Field.LockType.None
        Me.txt巻取区分名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt巻取区分名.HelpKeys = ""
        Me.txt巻取区分名.HelpLink = ""
        Me.txt巻取区分名.HelpType = NodeUI.Help.Type.None
        Me.txt巻取区分名.IsError = False
        Me.txt巻取区分名.Location = New System.Drawing.Point(66, 50)
        Me.txt巻取区分名.Name = "txt巻取区分名"
        Me.txt巻取区分名.Required = False
        Me.txt巻取区分名.Size = New System.Drawing.Size(40, 23)
        Me.txt巻取区分名.StringLength = 0
        Me.txt巻取区分名.TabIndex = 103
        Me.txt巻取区分名.Text = "XXXX"
        Me.txt巻取区分名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'ddl巻取区分
        '
        Me.ddl巻取区分.AutoDropDown = True
        Me.ddl巻取区分.DisplayMember = "Display"
        Me.ddl巻取区分.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddl巻取区分.FieldLockType = BaseContents.Field.LockType.None
        Me.ddl巻取区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.ddl巻取区分.FormattingEnabled = True
        Me.ddl巻取区分.IsError = False
        Me.ddl巻取区分.ListType = NodeUI.List.Type.None
        Me.ddl巻取区分.Location = New System.Drawing.Point(9, 50)
        Me.ddl巻取区分.Name = "ddl巻取区分"
        Me.ddl巻取区分.Required = False
        Me.ddl巻取区分.Size = New System.Drawing.Size(58, 24)
        Me.ddl巻取区分.TabIndex = 102
        Me.ddl巻取区分.ValueMember = "Value"
        '
        'txtスリッター巾
        '
        Me.txtスリッター巾.FieldLockType = BaseContents.Field.LockType.None
        Me.txtスリッター巾.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txtスリッター巾.HelpKeys = ""
        Me.txtスリッター巾.HelpLink = ""
        Me.txtスリッター巾.HelpType = NodeUI.Help.Type.None
        Me.txtスリッター巾.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtスリッター巾.IsError = False
        Me.txtスリッター巾.Location = New System.Drawing.Point(421, 51)
        Me.txtスリッター巾.Name = "txtスリッター巾"
        Me.txtスリッター巾.Required = False
        Me.txtスリッター巾.Size = New System.Drawing.Size(72, 23)
        Me.txtスリッター巾.StringLength = 0
        Me.txtスリッター巾.TabIndex = 71
        Me.txtスリッター巾.Text = "12,345.6"
        Me.txtスリッター巾.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtスリッター巾.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'namスリッター巾
        '
        Me.namスリッター巾.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.namスリッター巾.Font = New System.Drawing.Font("ＭＳ ゴシック", 7.5!)
        Me.namスリッター巾.Location = New System.Drawing.Point(421, 25)
        Me.namスリッター巾.Name = "namスリッター巾"
        Me.namスリッター巾.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.namスリッター巾.Size = New System.Drawing.Size(72, 23)
        Me.namスリッター巾.StringLength = 0
        Me.namスリッター巾.TabIndex = 74
        Me.namスリッター巾.Text = "スリッター巾"
        Me.namスリッター巾.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.namスリッター巾.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam巻取
        '
        Me.nam巻取.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam巻取.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam巻取.Location = New System.Drawing.Point(9, 25)
        Me.nam巻取.Name = "nam巻取"
        Me.nam巻取.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam巻取.Size = New System.Drawing.Size(97, 23)
        Me.nam巻取.StringLength = 0
        Me.nam巻取.TabIndex = 72
        Me.nam巻取.Text = "巻取"
        Me.nam巻取.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nam巻取.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'ddl社内外区分
        '
        Me.ddl社内外区分.AutoDropDown = True
        Me.ddl社内外区分.DisplayMember = "Display"
        Me.ddl社内外区分.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddl社内外区分.FieldLockType = BaseContents.Field.LockType.None
        Me.ddl社内外区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.ddl社内外区分.FormattingEnabled = True
        Me.ddl社内外区分.IsError = False
        Me.ddl社内外区分.ListType = NodeUI.List.Type.None
        Me.ddl社内外区分.Location = New System.Drawing.Point(18, 22)
        Me.ddl社内外区分.Name = "ddl社内外区分"
        Me.ddl社内外区分.Required = False
        Me.ddl社内外区分.Size = New System.Drawing.Size(150, 24)
        Me.ddl社内外区分.TabIndex = 137
        Me.ddl社内外区分.ValueMember = "Value"
        '
        'grp社内外区分
        '
        Me.grp社内外区分.Controls.Add(Me.ddl社内外区分)
        Me.grp社内外区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp社内外区分.Location = New System.Drawing.Point(62, 514)
        Me.grp社内外区分.Name = "grp社内外区分"
        Me.grp社内外区分.Size = New System.Drawing.Size(185, 60)
        Me.grp社内外区分.TabIndex = 2
        Me.grp社内外区分.TabStop = False
        Me.grp社内外区分.Text = "社内･社外区分"
        '
        'btn外注
        '
        Me.btn外注.FieldLockType = BaseContents.Field.LockType.Data
        Me.btn外注.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.btn外注.Location = New System.Drawing.Point(551, 526)
        Me.btn外注.Name = "btn外注"
        Me.btn外注.Size = New System.Drawing.Size(208, 48)
        Me.btn外注.TabIndex = 3
        Me.btn外注.Text = "外注発注画面へ進む"
        Me.btn外注.UseVisualStyleBackColor = True
        '
        'frmOrderPaper
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1284, 741)
        Me.Controls.Add(Me.grp社内外区分)
        Me.Controls.Add(Me.grp仕上方法)
        Me.Controls.Add(Me.btn外注)
        Me.Controls.Add(Me.btn戻る)
        Me.Controls.Add(Me.grp商品内訳)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmOrderPaper"
        Me.Controls.SetChildIndex(Me.grp商品内訳, 0)
        Me.Controls.SetChildIndex(Me.btn戻る, 0)
        Me.Controls.SetChildIndex(Me.btn外注, 0)
        Me.Controls.SetChildIndex(Me.grp仕上方法, 0)
        Me.Controls.SetChildIndex(Me.grp社内外区分, 0)
        CType(Me.grdDetall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp商品内訳.ResumeLayout(False)
        Me.grp商品内訳入力.ResumeLayout(False)
        Me.grp商品内訳入力.PerformLayout()
        Me.grp発注用摘要.ResumeLayout(False)
        Me.grp発注用摘要.PerformLayout()
        Me.grp発注用詳細情報.ResumeLayout(False)
        Me.grp発注用詳細情報.PerformLayout()
        Me.grp長さ算出詳細情報.ResumeLayout(False)
        Me.grp長さ算出詳細情報.PerformLayout()
        Me.grp仕上方法.ResumeLayout(False)
        Me.grp仕上方法.PerformLayout()
        Me.grp社内外区分.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdDetall As BaseUI.Control.GridInput
    Friend WithEvents grp商品内訳 As BaseUI.Control.GroupBox
    Friend WithEvents nam紙CD As BaseUI.Control.NameBox
    Friend WithEvents txt紙CD As BaseUI.Control.TextBox
    Friend WithEvents nam紙名 As BaseUI.Control.NameBox
    Friend WithEvents txt紙名 As BaseUI.Control.TextBox
    Friend WithEvents grp商品内訳入力 As BaseUI.Control.GroupBox
    Friend WithEvents btn戻る As BaseUI.Control.Button
    Friend WithEvents grp仕上方法 As BaseUI.Control.GroupBox
    Friend WithEvents nam巻取 As BaseUI.Control.NameBox
    Friend WithEvents ddl巻取区分 As BaseUI.Control.ComboBox
    Friend WithEvents txt巻取区分名 As BaseUI.Control.TextBox
    Friend WithEvents txt出し方向区分名 As BaseUI.Control.TextBox
    Friend WithEvents ddl出し方向区分 As BaseUI.Control.ComboBox
    Friend WithEvents nam出し方向 As BaseUI.Control.NameBox
    Friend WithEvents txt紙管 As BaseUI.Control.TextBox
    Friend WithEvents nam紙管 As BaseUI.Control.NameBox
    Friend WithEvents txt枚数 As BaseUI.Control.TextBox
    Friend WithEvents nam枚数 As BaseUI.Control.NameBox
    Friend WithEvents txtスリッター区分名 As BaseUI.Control.TextBox
    Friend WithEvents ddlスリッター区分 As BaseUI.Control.ComboBox
    Friend WithEvents namスリッター As BaseUI.Control.NameBox
    Friend WithEvents txtスリッター巾 As BaseUI.Control.TextBox
    Friend WithEvents namスリッター巾 As BaseUI.Control.NameBox
    Friend WithEvents namカット As BaseUI.Control.NameBox
    Friend WithEvents txtカット3 As BaseUI.Control.TextBox
    Friend WithEvents txtカット2 As BaseUI.Control.TextBox
    Friend WithEvents txtカット1 As BaseUI.Control.TextBox
    Friend WithEvents Label1 As BaseUI.Control.Label
    Friend WithEvents lbl刃型サイズ一面角単位 As BaseUI.Control.Label
    Friend WithEvents txt梱包枚数 As BaseUI.Control.TextBox
    Friend WithEvents nam梱包枚数 As BaseUI.Control.NameBox
    Friend WithEvents txt送りピッチ As BaseUI.Control.TextBox
    Friend WithEvents nam送りピッチ As BaseUI.Control.NameBox
    Friend WithEvents nam糊名 As BaseUI.Control.NameBox
    Friend WithEvents txt糊名 As BaseUI.Control.TextBox
    Friend WithEvents nam糊CD As BaseUI.Control.NameBox
    Friend WithEvents txt糊CD As BaseUI.Control.TextBox
    Friend WithEvents nam台紙名 As BaseUI.Control.NameBox
    Friend WithEvents txt台紙名 As BaseUI.Control.TextBox
    Friend WithEvents nam台紙CD As BaseUI.Control.NameBox
    Friend WithEvents txt台紙CD As BaseUI.Control.TextBox
    Friend WithEvents txt長さm As BaseUI.Control.TextBox
    Friend WithEvents txt巾mm As BaseUI.Control.TextBox
    Friend WithEvents Label2 As BaseUI.Control.Label
    Friend WithEvents namサイズ As BaseUI.Control.NameBox
    Friend WithEvents ddl仕入先指定区分 As BaseUI.Control.ComboBox
    Friend WithEvents nam仕入先指定区分 As BaseUI.Control.NameBox
    Friend WithEvents txt発注単価 As BaseUI.Control.TextBox
    Friend WithEvents nam発注単価 As BaseUI.Control.NameBox
    Friend WithEvents ddl支給区分 As BaseUI.Control.ComboBox
    Friend WithEvents nam支給区分 As BaseUI.Control.NameBox
    Friend WithEvents txt有償支給単価 As BaseUI.Control.TextBox
    Friend WithEvents nam有償支給単価 As BaseUI.Control.NameBox
    Friend WithEvents nam発注日付 As BaseUI.Control.NameBox
    Friend WithEvents txt発注日付 As BaseUI.Control.TextBox
    Friend WithEvents txtつなぎロス As BaseUI.Control.TextBox
    Friend WithEvents namつなぎロス As BaseUI.Control.NameBox
    Friend WithEvents txt刷出m As BaseUI.Control.TextBox
    Friend WithEvents nam刷出m As BaseUI.Control.NameBox
    Friend WithEvents nam送りmm As BaseUI.Control.NameBox
    Friend WithEvents txt送りmm As BaseUI.Control.TextBox
    Friend WithEvents txt通数 As BaseUI.Control.TextBox
    Friend WithEvents nam通数 As BaseUI.Control.NameBox
    Friend WithEvents grp長さ算出詳細情報 As BaseUI.Control.GroupBox
    Friend WithEvents txtその他m As BaseUI.Control.TextBox
    Friend WithEvents namその他m As BaseUI.Control.NameBox
    Friend WithEvents grp発注用詳細情報 As BaseUI.Control.GroupBox
    Friend WithEvents nam希望納期日付 As BaseUI.Control.NameBox
    Friend WithEvents txt希望納期日付 As BaseUI.Control.TextBox
    Friend WithEvents ddl希望時間帯区分 As BaseUI.Control.ComboBox
    Friend WithEvents nam希望時間帯区分 As BaseUI.Control.NameBox
    Friend WithEvents txt基準長 As BaseUI.Control.TextBox
    Friend WithEvents nam基準長 As BaseUI.Control.NameBox
    Friend WithEvents grp発注用摘要 As BaseUI.Control.GroupBox
    Friend WithEvents txt発注用摘要1 As BaseUI.Control.TextBox
    Friend WithEvents txt発注用摘要2 As BaseUI.Control.TextBox
    Friend WithEvents txt発注用摘要3 As BaseUI.Control.TextBox
    Friend WithEvents ddl社内外区分 As BaseUI.Control.ComboBox
    Friend WithEvents grp社内外区分 As BaseUI.Control.GroupBox
    Friend WithEvents btn外注 As BaseUI.Control.Button
    Friend WithEvents nam仕入先名Title As BaseUI.Control.NameBox
    Friend WithEvents nam仕入先CD As BaseUI.Control.NameBox
    Friend WithEvents txt仕入先CD As BaseUI.Control.TextBox
    Friend WithEvents nam仕入先名 As BaseUI.Control.NameBox
    Friend WithEvents nam単価区分 As BaseUI.Control.NameBox
    Friend WithEvents ddl単価区分 As BaseUI.Control.ComboBox

End Class
