<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderItem
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
        Me.nam商品名代表 = New BaseUI.Control.NameBox()
        Me.nam本台帳NO = New BaseUI.Control.NameBox()
        Me.nam商品名代表Title = New BaseUI.Control.NameBox()
        Me.nam本台帳NOTitle = New BaseUI.Control.NameBox()
        Me.grp商品内訳 = New BaseUI.Control.GroupBox()
        Me.lbl刃型サイズ一面角単位 = New BaseUI.Control.Label()
        Me.nam受注数合計 = New BaseUI.Control.NameBox()
        Me.nam内在庫引当数合計 = New BaseUI.Control.NameBox()
        Me.nam内製造数合計 = New BaseUI.Control.NameBox()
        Me.grp商品内訳入力 = New BaseUI.Control.GroupBox()
        Me.nam備考 = New BaseUI.Control.NameBox()
        Me.txt備考 = New BaseUI.Control.TextBox()
        Me.txt倉庫NO = New BaseUI.Control.TextBox()
        Me.nam倉庫NO = New BaseUI.Control.NameBox()
        Me.nam顧客発注NO = New BaseUI.Control.NameBox()
        Me.txt顧客発注NO = New BaseUI.Control.TextBox()
        Me.nam顧客商品CD = New BaseUI.Control.NameBox()
        Me.txt顧客商品CD = New BaseUI.Control.TextBox()
        Me.nam納期日付B = New BaseUI.Control.NameBox()
        Me.txt納期日付B = New BaseUI.Control.TextBox()
        Me.nam納期日付A = New BaseUI.Control.NameBox()
        Me.txt納期日付A = New BaseUI.Control.TextBox()
        Me.nam内製造数 = New BaseUI.Control.NameBox()
        Me.nam内製造数Title = New BaseUI.Control.NameBox()
        Me.nam内在庫引当数 = New BaseUI.Control.NameBox()
        Me.nam内在庫引当数Title = New BaseUI.Control.NameBox()
        Me.nam商品名 = New BaseUI.Control.NameBox()
        Me.txt商品名 = New BaseUI.Control.TextBox()
        Me.txt受注単価 = New BaseUI.Control.TextBox()
        Me.nam受注単価 = New BaseUI.Control.NameBox()
        Me.txt受注数 = New BaseUI.Control.TextBox()
        Me.nam受注数 = New BaseUI.Control.NameBox()
        Me.nam定番CD = New BaseUI.Control.NameBox()
        Me.txt定番CD = New BaseUI.Control.TextBox()
        Me.txt枝番 = New BaseUI.Control.TextBox()
        Me.nam枝番 = New BaseUI.Control.NameBox()
        Me.btn戻る = New BaseUI.Control.Button()
        CType(Me.grdDetall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp商品内訳.SuspendLayout()
        Me.grp商品内訳入力.SuspendLayout()
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
        Me.grdDetall.Size = New System.Drawing.Size(1005, 320)
        Me.grdDetall.TabIndex = 0
        Me.grdDetall.TabStop = False
        Me.grdDetall.TextBoxAddBtm = Nothing
        Me.grdDetall.TextBoxAddTop = Nothing
        '
        'nam商品名代表
        '
        Me.nam商品名代表.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam商品名代表.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam商品名代表.Location = New System.Drawing.Point(96, 38)
        Me.nam商品名代表.Name = "nam商品名代表"
        Me.nam商品名代表.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam商品名代表.Size = New System.Drawing.Size(270, 23)
        Me.nam商品名代表.StringLength = 0
        Me.nam商品名代表.TabIndex = 3
        Me.nam商品名代表.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam本台帳NO
        '
        Me.nam本台帳NO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam本台帳NO.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam本台帳NO.Location = New System.Drawing.Point(34, 38)
        Me.nam本台帳NO.Name = "nam本台帳NO"
        Me.nam本台帳NO.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam本台帳NO.Size = New System.Drawing.Size(60, 23)
        Me.nam本台帳NO.StringLength = 0
        Me.nam本台帳NO.TabIndex = 2
        Me.nam本台帳NO.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam商品名代表Title
        '
        Me.nam商品名代表Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam商品名代表Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam商品名代表Title.Location = New System.Drawing.Point(96, 13)
        Me.nam商品名代表Title.Name = "nam商品名代表Title"
        Me.nam商品名代表Title.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam商品名代表Title.Size = New System.Drawing.Size(270, 23)
        Me.nam商品名代表Title.StringLength = 0
        Me.nam商品名代表Title.TabIndex = 1
        Me.nam商品名代表Title.Text = "商品名(代表)"
        Me.nam商品名代表Title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.nam商品名代表Title.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam本台帳NOTitle
        '
        Me.nam本台帳NOTitle.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam本台帳NOTitle.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.nam本台帳NOTitle.Location = New System.Drawing.Point(34, 13)
        Me.nam本台帳NOTitle.Name = "nam本台帳NOTitle"
        Me.nam本台帳NOTitle.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam本台帳NOTitle.Size = New System.Drawing.Size(60, 23)
        Me.nam本台帳NOTitle.StringLength = 0
        Me.nam本台帳NOTitle.TabIndex = 0
        Me.nam本台帳NOTitle.Text = "本台帳NO"
        Me.nam本台帳NOTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam本台帳NOTitle.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp商品内訳
        '
        Me.grp商品内訳.Controls.Add(Me.lbl刃型サイズ一面角単位)
        Me.grp商品内訳.Controls.Add(Me.nam受注数合計)
        Me.grp商品内訳.Controls.Add(Me.nam内在庫引当数合計)
        Me.grp商品内訳.Controls.Add(Me.nam内製造数合計)
        Me.grp商品内訳.Controls.Add(Me.grp商品内訳入力)
        Me.grp商品内訳.Controls.Add(Me.grdDetall)
        Me.grp商品内訳.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp商品内訳.Location = New System.Drawing.Point(1, 72)
        Me.grp商品内訳.Name = "grp商品内訳"
        Me.grp商品内訳.Size = New System.Drawing.Size(1015, 505)
        Me.grp商品内訳.TabIndex = 4
        Me.grp商品内訳.TabStop = False
        Me.grp商品内訳.Text = "【商品内訳】"
        '
        'lbl刃型サイズ一面角単位
        '
        Me.lbl刃型サイズ一面角単位.AutoSize = True
        Me.lbl刃型サイズ一面角単位.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.lbl刃型サイズ一面角単位.Location = New System.Drawing.Point(299, 349)
        Me.lbl刃型サイズ一面角単位.Name = "lbl刃型サイズ一面角単位"
        Me.lbl刃型サイズ一面角単位.Size = New System.Drawing.Size(136, 16)
        Me.lbl刃型サイズ一面角単位.TabIndex = 103
        Me.lbl刃型サイズ一面角単位.Text = "[受注数内訳合計]"
        Me.lbl刃型サイズ一面角単位.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'nam受注数合計
        '
        Me.nam受注数合計.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam受注数合計.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam受注数合計.Location = New System.Drawing.Point(440, 345)
        Me.nam受注数合計.Name = "nam受注数合計"
        Me.nam受注数合計.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam受注数合計.Size = New System.Drawing.Size(95, 23)
        Me.nam受注数合計.StringLength = 0
        Me.nam受注数合計.TabIndex = 102
        Me.nam受注数合計.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam内在庫引当数合計
        '
        Me.nam内在庫引当数合計.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam内在庫引当数合計.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam内在庫引当数合計.Location = New System.Drawing.Point(536, 345)
        Me.nam内在庫引当数合計.Name = "nam内在庫引当数合計"
        Me.nam内在庫引当数合計.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam内在庫引当数合計.Size = New System.Drawing.Size(95, 23)
        Me.nam内在庫引当数合計.StringLength = 0
        Me.nam内在庫引当数合計.TabIndex = 100
        Me.nam内在庫引当数合計.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam内製造数合計
        '
        Me.nam内製造数合計.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam内製造数合計.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam内製造数合計.Location = New System.Drawing.Point(632, 345)
        Me.nam内製造数合計.Name = "nam内製造数合計"
        Me.nam内製造数合計.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam内製造数合計.Size = New System.Drawing.Size(95, 23)
        Me.nam内製造数合計.StringLength = 0
        Me.nam内製造数合計.TabIndex = 101
        Me.nam内製造数合計.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp商品内訳入力
        '
        Me.grp商品内訳入力.Controls.Add(Me.nam備考)
        Me.grp商品内訳入力.Controls.Add(Me.txt備考)
        Me.grp商品内訳入力.Controls.Add(Me.txt倉庫NO)
        Me.grp商品内訳入力.Controls.Add(Me.nam倉庫NO)
        Me.grp商品内訳入力.Controls.Add(Me.nam顧客発注NO)
        Me.grp商品内訳入力.Controls.Add(Me.txt顧客発注NO)
        Me.grp商品内訳入力.Controls.Add(Me.nam顧客商品CD)
        Me.grp商品内訳入力.Controls.Add(Me.txt顧客商品CD)
        Me.grp商品内訳入力.Controls.Add(Me.nam納期日付B)
        Me.grp商品内訳入力.Controls.Add(Me.txt納期日付B)
        Me.grp商品内訳入力.Controls.Add(Me.nam納期日付A)
        Me.grp商品内訳入力.Controls.Add(Me.txt納期日付A)
        Me.grp商品内訳入力.Controls.Add(Me.nam内製造数)
        Me.grp商品内訳入力.Controls.Add(Me.nam内製造数Title)
        Me.grp商品内訳入力.Controls.Add(Me.nam内在庫引当数)
        Me.grp商品内訳入力.Controls.Add(Me.nam内在庫引当数Title)
        Me.grp商品内訳入力.Controls.Add(Me.nam商品名)
        Me.grp商品内訳入力.Controls.Add(Me.txt商品名)
        Me.grp商品内訳入力.Controls.Add(Me.txt受注単価)
        Me.grp商品内訳入力.Controls.Add(Me.nam受注単価)
        Me.grp商品内訳入力.Controls.Add(Me.txt受注数)
        Me.grp商品内訳入力.Controls.Add(Me.nam受注数)
        Me.grp商品内訳入力.Controls.Add(Me.nam定番CD)
        Me.grp商品内訳入力.Controls.Add(Me.txt定番CD)
        Me.grp商品内訳入力.Controls.Add(Me.txt枝番)
        Me.grp商品内訳入力.Controls.Add(Me.nam枝番)
        Me.grp商品内訳入力.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp商品内訳入力.Location = New System.Drawing.Point(32, 371)
        Me.grp商品内訳入力.Name = "grp商品内訳入力"
        Me.grp商品内訳入力.Size = New System.Drawing.Size(980, 124)
        Me.grp商品内訳入力.TabIndex = 1
        Me.grp商品内訳入力.TabStop = False
        '
        'nam備考
        '
        Me.nam備考.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam備考.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam備考.Location = New System.Drawing.Point(824, 67)
        Me.nam備考.Name = "nam備考"
        Me.nam備考.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam備考.Size = New System.Drawing.Size(150, 23)
        Me.nam備考.StringLength = 0
        Me.nam備考.TabIndex = 99
        Me.nam備考.Text = "備　　考"
        Me.nam備考.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam備考.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt備考
        '
        Me.txt備考.FieldLockType = BaseContents.Field.LockType.None
        Me.txt備考.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt備考.HelpKeys = ""
        Me.txt備考.HelpLink = ""
        Me.txt備考.HelpType = NodeUI.Help.Type.None
        Me.txt備考.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt備考.IsError = False
        Me.txt備考.Location = New System.Drawing.Point(824, 93)
        Me.txt備考.Name = "txt備考"
        Me.txt備考.NumberMinor = 2
        Me.txt備考.Required = False
        Me.txt備考.Size = New System.Drawing.Size(150, 23)
        Me.txt備考.StringLength = 0
        Me.txt備考.TabIndex = 10
        Me.txt備考.Text = "XXXXXXXXXXXXXXXXX"
        Me.txt備考.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt倉庫NO
        '
        Me.txt倉庫NO.FieldLockType = BaseContents.Field.LockType.None
        Me.txt倉庫NO.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt倉庫NO.HelpKeys = ""
        Me.txt倉庫NO.HelpLink = ""
        Me.txt倉庫NO.HelpType = NodeUI.Help.Type.None
        Me.txt倉庫NO.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt倉庫NO.IsError = False
        Me.txt倉庫NO.Location = New System.Drawing.Point(807, 93)
        Me.txt倉庫NO.Name = "txt倉庫NO"
        Me.txt倉庫NO.Required = False
        Me.txt倉庫NO.Size = New System.Drawing.Size(15, 23)
        Me.txt倉庫NO.StringLength = 0
        Me.txt倉庫NO.TabIndex = 9
        Me.txt倉庫NO.Text = "X"
        Me.txt倉庫NO.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam倉庫NO
        '
        Me.nam倉庫NO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam倉庫NO.Font = New System.Drawing.Font("ＭＳ ゴシック", 6.5!)
        Me.nam倉庫NO.Location = New System.Drawing.Point(807, 67)
        Me.nam倉庫NO.Name = "nam倉庫NO"
        Me.nam倉庫NO.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.nam倉庫NO.Size = New System.Drawing.Size(15, 23)
        Me.nam倉庫NO.StringLength = 0
        Me.nam倉庫NO.TabIndex = 97
        Me.nam倉庫NO.Text = "倉庫"
        Me.nam倉庫NO.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam顧客発注NO
        '
        Me.nam顧客発注NO.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam顧客発注NO.Font = New System.Drawing.Font("ＭＳ ゴシック", 7.5!)
        Me.nam顧客発注NO.Location = New System.Drawing.Point(746, 67)
        Me.nam顧客発注NO.Name = "nam顧客発注NO"
        Me.nam顧客発注NO.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.nam顧客発注NO.Size = New System.Drawing.Size(60, 23)
        Me.nam顧客発注NO.StringLength = 0
        Me.nam顧客発注NO.TabIndex = 95
        Me.nam顧客発注NO.Text = "顧客発注" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "NO"
        Me.nam顧客発注NO.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam顧客発注NO.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt顧客発注NO
        '
        Me.txt顧客発注NO.FieldLockType = BaseContents.Field.LockType.None
        Me.txt顧客発注NO.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt顧客発注NO.HelpKeys = ""
        Me.txt顧客発注NO.HelpLink = ""
        Me.txt顧客発注NO.HelpType = NodeUI.Help.Type.None
        Me.txt顧客発注NO.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt顧客発注NO.IsError = False
        Me.txt顧客発注NO.Location = New System.Drawing.Point(746, 93)
        Me.txt顧客発注NO.Name = "txt顧客発注NO"
        Me.txt顧客発注NO.NumberMinor = 2
        Me.txt顧客発注NO.Required = False
        Me.txt顧客発注NO.Size = New System.Drawing.Size(60, 23)
        Me.txt顧客発注NO.StringLength = 0
        Me.txt顧客発注NO.TabIndex = 8
        Me.txt顧客発注NO.Text = "XXXXXX"
        Me.txt顧客発注NO.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam顧客商品CD
        '
        Me.nam顧客商品CD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam顧客商品CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam顧客商品CD.Location = New System.Drawing.Point(601, 67)
        Me.nam顧客商品CD.Name = "nam顧客商品CD"
        Me.nam顧客商品CD.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam顧客商品CD.Size = New System.Drawing.Size(145, 23)
        Me.nam顧客商品CD.StringLength = 0
        Me.nam顧客商品CD.TabIndex = 93
        Me.nam顧客商品CD.Text = "顧客商品ｺｰﾄﾞ"
        Me.nam顧客商品CD.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam顧客商品CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt顧客商品CD
        '
        Me.txt顧客商品CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt顧客商品CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt顧客商品CD.HelpKeys = ""
        Me.txt顧客商品CD.HelpLink = ""
        Me.txt顧客商品CD.HelpType = NodeUI.Help.Type.None
        Me.txt顧客商品CD.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt顧客商品CD.IsError = False
        Me.txt顧客商品CD.Location = New System.Drawing.Point(601, 93)
        Me.txt顧客商品CD.Name = "txt顧客商品CD"
        Me.txt顧客商品CD.NumberMinor = 2
        Me.txt顧客商品CD.Required = False
        Me.txt顧客商品CD.Size = New System.Drawing.Size(145, 23)
        Me.txt顧客商品CD.StringLength = 0
        Me.txt顧客商品CD.TabIndex = 7
        Me.txt顧客商品CD.Text = "XXXXXXXXXXXXXXXXX"
        Me.txt顧客商品CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam納期日付B
        '
        Me.nam納期日付B.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam納期日付B.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam納期日付B.Location = New System.Drawing.Point(884, 15)
        Me.nam納期日付B.Name = "nam納期日付B"
        Me.nam納期日付B.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam納期日付B.Size = New System.Drawing.Size(90, 23)
        Me.nam納期日付B.StringLength = 0
        Me.nam納期日付B.TabIndex = 91
        Me.nam納期日付B.Text = "B納期"
        Me.nam納期日付B.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam納期日付B.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt納期日付B
        '
        Me.txt納期日付B.FieldLockType = BaseContents.Field.LockType.None
        Me.txt納期日付B.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt納期日付B.HelpKeys = ""
        Me.txt納期日付B.HelpLink = ""
        Me.txt納期日付B.HelpType = NodeUI.Help.Type.None
        Me.txt納期日付B.IsError = False
        Me.txt納期日付B.Location = New System.Drawing.Point(884, 41)
        Me.txt納期日付B.Name = "txt納期日付B"
        Me.txt納期日付B.Required = False
        Me.txt納期日付B.Size = New System.Drawing.Size(90, 23)
        Me.txt納期日付B.StringLength = 0
        Me.txt納期日付B.TabIndex = 6
        Me.txt納期日付B.Text = "YYYY/MM/DD"
        Me.txt納期日付B.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam納期日付A
        '
        Me.nam納期日付A.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam納期日付A.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam納期日付A.Location = New System.Drawing.Point(793, 15)
        Me.nam納期日付A.Name = "nam納期日付A"
        Me.nam納期日付A.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam納期日付A.Size = New System.Drawing.Size(90, 23)
        Me.nam納期日付A.StringLength = 0
        Me.nam納期日付A.TabIndex = 89
        Me.nam納期日付A.Text = "A納期"
        Me.nam納期日付A.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam納期日付A.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt納期日付A
        '
        Me.txt納期日付A.FieldLockType = BaseContents.Field.LockType.None
        Me.txt納期日付A.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt納期日付A.HelpKeys = ""
        Me.txt納期日付A.HelpLink = ""
        Me.txt納期日付A.HelpType = NodeUI.Help.Type.None
        Me.txt納期日付A.IsError = False
        Me.txt納期日付A.Location = New System.Drawing.Point(793, 41)
        Me.txt納期日付A.Name = "txt納期日付A"
        Me.txt納期日付A.Required = False
        Me.txt納期日付A.Size = New System.Drawing.Size(90, 23)
        Me.txt納期日付A.StringLength = 0
        Me.txt納期日付A.TabIndex = 5
        Me.txt納期日付A.Text = "YYYY/MM/DD"
        Me.txt納期日付A.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam内製造数
        '
        Me.nam内製造数.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam内製造数.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam内製造数.Location = New System.Drawing.Point(601, 41)
        Me.nam内製造数.Name = "nam内製造数"
        Me.nam内製造数.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam内製造数.Size = New System.Drawing.Size(95, 23)
        Me.nam内製造数.StringLength = 0
        Me.nam内製造数.TabIndex = 87
        Me.nam内製造数.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam内製造数Title
        '
        Me.nam内製造数Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam内製造数Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.nam内製造数Title.Location = New System.Drawing.Point(601, 15)
        Me.nam内製造数Title.Name = "nam内製造数Title"
        Me.nam内製造数Title.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam内製造数Title.Size = New System.Drawing.Size(95, 23)
        Me.nam内製造数Title.StringLength = 0
        Me.nam内製造数Title.TabIndex = 86
        Me.nam内製造数Title.Text = "内製造数"
        Me.nam内製造数Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nam内製造数Title.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam内在庫引当数
        '
        Me.nam内在庫引当数.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam内在庫引当数.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam内在庫引当数.Location = New System.Drawing.Point(505, 41)
        Me.nam内在庫引当数.Name = "nam内在庫引当数"
        Me.nam内在庫引当数.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam内在庫引当数.Size = New System.Drawing.Size(95, 23)
        Me.nam内在庫引当数.StringLength = 0
        Me.nam内在庫引当数.TabIndex = 85
        Me.nam内在庫引当数.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam内在庫引当数Title
        '
        Me.nam内在庫引当数Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam内在庫引当数Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.nam内在庫引当数Title.Location = New System.Drawing.Point(505, 15)
        Me.nam内在庫引当数Title.Name = "nam内在庫引当数Title"
        Me.nam内在庫引当数Title.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam内在庫引当数Title.Size = New System.Drawing.Size(95, 23)
        Me.nam内在庫引当数Title.StringLength = 0
        Me.nam内在庫引当数Title.TabIndex = 84
        Me.nam内在庫引当数Title.Text = "内在庫引当数"
        Me.nam内在庫引当数Title.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.nam内在庫引当数Title.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam商品名
        '
        Me.nam商品名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam商品名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam商品名.Location = New System.Drawing.Point(138, 15)
        Me.nam商品名.Name = "nam商品名"
        Me.nam商品名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam商品名.Size = New System.Drawing.Size(270, 23)
        Me.nam商品名.StringLength = 0
        Me.nam商品名.TabIndex = 82
        Me.nam商品名.Text = "商   品   名"
        Me.nam商品名.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nam商品名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt商品名
        '
        Me.txt商品名.FieldLockType = BaseContents.Field.LockType.None
        Me.txt商品名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt商品名.HelpKeys = ""
        Me.txt商品名.HelpLink = ""
        Me.txt商品名.HelpType = NodeUI.Help.Type.None
        Me.txt商品名.IsError = False
        Me.txt商品名.Location = New System.Drawing.Point(138, 41)
        Me.txt商品名.Name = "txt商品名"
        Me.txt商品名.Required = False
        Me.txt商品名.Size = New System.Drawing.Size(270, 23)
        Me.txt商品名.StringLength = 0
        Me.txt商品名.TabIndex = 2
        Me.txt商品名.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.txt商品名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt受注単価
        '
        Me.txt受注単価.FieldLockType = BaseContents.Field.LockType.None
        Me.txt受注単価.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt受注単価.HelpKeys = ""
        Me.txt受注単価.HelpLink = ""
        Me.txt受注単価.HelpType = NodeUI.Help.Type.None
        Me.txt受注単価.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt受注単価.IsError = False
        Me.txt受注単価.Location = New System.Drawing.Point(697, 41)
        Me.txt受注単価.Name = "txt受注単価"
        Me.txt受注単価.Required = False
        Me.txt受注単価.Size = New System.Drawing.Size(95, 23)
        Me.txt受注単価.StringLength = 0
        Me.txt受注単価.TabIndex = 4
        Me.txt受注単価.Text = "123,456,789"
        Me.txt受注単価.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam受注単価
        '
        Me.nam受注単価.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam受注単価.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam受注単価.Location = New System.Drawing.Point(697, 15)
        Me.nam受注単価.Name = "nam受注単価"
        Me.nam受注単価.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam受注単価.Size = New System.Drawing.Size(95, 23)
        Me.nam受注単価.StringLength = 0
        Me.nam受注単価.TabIndex = 76
        Me.nam受注単価.Text = "受注単価"
        Me.nam受注単価.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam受注単価.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt受注数
        '
        Me.txt受注数.FieldLockType = BaseContents.Field.LockType.None
        Me.txt受注数.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt受注数.HelpKeys = ""
        Me.txt受注数.HelpLink = ""
        Me.txt受注数.HelpType = NodeUI.Help.Type.None
        Me.txt受注数.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt受注数.IsError = False
        Me.txt受注数.Location = New System.Drawing.Point(409, 41)
        Me.txt受注数.Name = "txt受注数"
        Me.txt受注数.Required = False
        Me.txt受注数.Size = New System.Drawing.Size(95, 23)
        Me.txt受注数.StringLength = 0
        Me.txt受注数.TabIndex = 3
        Me.txt受注数.Text = "123,456,789"
        Me.txt受注数.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam受注数
        '
        Me.nam受注数.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam受注数.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam受注数.Location = New System.Drawing.Point(409, 15)
        Me.nam受注数.Name = "nam受注数"
        Me.nam受注数.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam受注数.Size = New System.Drawing.Size(95, 23)
        Me.nam受注数.StringLength = 0
        Me.nam受注数.TabIndex = 74
        Me.nam受注数.Text = "受注数"
        Me.nam受注数.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.nam受注数.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam定番CD
        '
        Me.nam定番CD.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam定番CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam定番CD.Location = New System.Drawing.Point(30, 15)
        Me.nam定番CD.Name = "nam定番CD"
        Me.nam定番CD.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam定番CD.Size = New System.Drawing.Size(106, 23)
        Me.nam定番CD.StringLength = 0
        Me.nam定番CD.TabIndex = 73
        Me.nam定番CD.Text = "定番ｺｰﾄﾞ"
        Me.nam定番CD.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam定番CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt定番CD
        '
        Me.txt定番CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt定番CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt定番CD.HelpKeys = ""
        Me.txt定番CD.HelpLink = ""
        Me.txt定番CD.HelpType = NodeUI.Help.Type.None
        Me.txt定番CD.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt定番CD.IsError = False
        Me.txt定番CD.Location = New System.Drawing.Point(30, 41)
        Me.txt定番CD.Name = "txt定番CD"
        Me.txt定番CD.NumberMinor = 2
        Me.txt定番CD.Required = False
        Me.txt定番CD.Size = New System.Drawing.Size(106, 23)
        Me.txt定番CD.StringLength = 0
        Me.txt定番CD.TabIndex = 1
        Me.txt定番CD.Text = "XXXXXXXXXXXX"
        Me.txt定番CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt枝番
        '
        Me.txt枝番.FieldLockType = BaseContents.Field.LockType.None
        Me.txt枝番.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt枝番.HelpKeys = ""
        Me.txt枝番.HelpLink = ""
        Me.txt枝番.HelpType = NodeUI.Help.Type.None
        Me.txt枝番.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt枝番.IsError = False
        Me.txt枝番.Location = New System.Drawing.Point(6, 41)
        Me.txt枝番.Name = "txt枝番"
        Me.txt枝番.Required = False
        Me.txt枝番.Size = New System.Drawing.Size(23, 23)
        Me.txt枝番.StringLength = 0
        Me.txt枝番.TabIndex = 0
        Me.txt枝番.Text = "XX"
        Me.txt枝番.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam枝番
        '
        Me.nam枝番.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam枝番.Font = New System.Drawing.Font("ＭＳ ゴシック", 7.0!)
        Me.nam枝番.Location = New System.Drawing.Point(6, 15)
        Me.nam枝番.Name = "nam枝番"
        Me.nam枝番.Padding = New System.Windows.Forms.Padding(0, 0, 0, 2)
        Me.nam枝番.Size = New System.Drawing.Size(23, 23)
        Me.nam枝番.StringLength = 0
        Me.nam枝番.TabIndex = 72
        Me.nam枝番.Text = "枝" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "番"
        Me.nam枝番.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam枝番.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'btn戻る
        '
        Me.btn戻る.FieldLockType = BaseContents.Field.LockType.Data
        Me.btn戻る.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.btn戻る.Location = New System.Drawing.Point(782, 588)
        Me.btn戻る.Name = "btn戻る"
        Me.btn戻る.Size = New System.Drawing.Size(208, 48)
        Me.btn戻る.TabIndex = 5
        Me.btn戻る.Text = "前画面へ戻る"
        Me.btn戻る.UseVisualStyleBackColor = True
        '
        'frmOrderItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.btn戻る)
        Me.Controls.Add(Me.grp商品内訳)
        Me.Controls.Add(Me.nam商品名代表)
        Me.Controls.Add(Me.nam本台帳NO)
        Me.Controls.Add(Me.nam商品名代表Title)
        Me.Controls.Add(Me.nam本台帳NOTitle)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmOrderItem"
        Me.Controls.SetChildIndex(Me.nam本台帳NOTitle, 0)
        Me.Controls.SetChildIndex(Me.nam商品名代表Title, 0)
        Me.Controls.SetChildIndex(Me.nam本台帳NO, 0)
        Me.Controls.SetChildIndex(Me.nam商品名代表, 0)
        Me.Controls.SetChildIndex(Me.grp商品内訳, 0)
        Me.Controls.SetChildIndex(Me.btn戻る, 0)
        CType(Me.grdDetall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp商品内訳.ResumeLayout(False)
        Me.grp商品内訳.PerformLayout()
        Me.grp商品内訳入力.ResumeLayout(False)
        Me.grp商品内訳入力.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grdDetall As BaseUI.Control.GridInput
    Friend WithEvents nam商品名代表 As BaseUI.Control.NameBox
    Friend WithEvents nam本台帳NO As BaseUI.Control.NameBox
    Friend WithEvents nam商品名代表Title As BaseUI.Control.NameBox
    Friend WithEvents nam本台帳NOTitle As BaseUI.Control.NameBox
    Friend WithEvents grp商品内訳 As BaseUI.Control.GroupBox
    Friend WithEvents txt受注単価 As BaseUI.Control.TextBox
    Friend WithEvents nam受注単価 As BaseUI.Control.NameBox
    Friend WithEvents txt受注数 As BaseUI.Control.TextBox
    Friend WithEvents nam受注数 As BaseUI.Control.NameBox
    Friend WithEvents nam定番CD As BaseUI.Control.NameBox
    Friend WithEvents txt定番CD As BaseUI.Control.TextBox
    Friend WithEvents txt枝番 As BaseUI.Control.TextBox
    Friend WithEvents nam枝番 As BaseUI.Control.NameBox
    Friend WithEvents nam商品名 As BaseUI.Control.NameBox
    Friend WithEvents txt商品名 As BaseUI.Control.TextBox
    Friend WithEvents nam内在庫引当数Title As BaseUI.Control.NameBox
    Friend WithEvents nam内在庫引当数 As BaseUI.Control.NameBox
    Friend WithEvents nam内製造数 As BaseUI.Control.NameBox
    Friend WithEvents nam内製造数Title As BaseUI.Control.NameBox
    Friend WithEvents nam納期日付A As BaseUI.Control.NameBox
    Friend WithEvents txt納期日付A As BaseUI.Control.TextBox
    Friend WithEvents nam納期日付B As BaseUI.Control.NameBox
    Friend WithEvents txt納期日付B As BaseUI.Control.TextBox
    Friend WithEvents nam顧客商品CD As BaseUI.Control.NameBox
    Friend WithEvents txt顧客商品CD As BaseUI.Control.TextBox
    Friend WithEvents nam顧客発注NO As BaseUI.Control.NameBox
    Friend WithEvents txt顧客発注NO As BaseUI.Control.TextBox
    Friend WithEvents txt倉庫NO As BaseUI.Control.TextBox
    Friend WithEvents nam倉庫NO As BaseUI.Control.NameBox
    Friend WithEvents nam備考 As BaseUI.Control.NameBox
    Friend WithEvents txt備考 As BaseUI.Control.TextBox
    Friend WithEvents grp商品内訳入力 As BaseUI.Control.GroupBox
    Friend WithEvents btn戻る As BaseUI.Control.Button
    Friend WithEvents nam受注数合計 As BaseUI.Control.NameBox
    Friend WithEvents nam内在庫引当数合計 As BaseUI.Control.NameBox
    Friend WithEvents nam内製造数合計 As BaseUI.Control.NameBox
    Friend WithEvents lbl刃型サイズ一面角単位 As BaseUI.Control.Label

End Class
