<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOffSet
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
        Me.grp作業NO = New BaseUI.Control.GroupBox()
        Me.txt作業NO = New BaseUI.Control.TextBox()
        Me.grp受注情報 = New BaseUI.Control.GroupBox()
        Me.nam商品名 = New BaseUI.Control.NameBox()
        Me.nam受注金額Title = New BaseUI.Control.NameBox()
        Me.nam受注単価Title = New BaseUI.Control.NameBox()
        Me.nam受注金額 = New BaseUI.Control.NameBox()
        Me.nam受注単価 = New BaseUI.Control.NameBox()
        Me.nam受注数 = New BaseUI.Control.NameBox()
        Me.nam得意先名 = New BaseUI.Control.NameBox()
        Me.nam受注数Title = New BaseUI.Control.NameBox()
        Me.nam商品名Title = New BaseUI.Control.NameBox()
        Me.nam得意先名Title = New BaseUI.Control.NameBox()
        Me.grdDetall = New BaseUI.Control.GridInput()
        Me.txt発注先CD = New BaseUI.Control.TextBox()
        Me.txt発注日 = New BaseUI.Control.TextBox()
        Me.nam発注先Title = New BaseUI.Control.NameBox()
        Me.nam仕入先名 = New BaseUI.Control.NameBox()
        Me.nam工程Title = New BaseUI.Control.NameBox()
        Me.ddl工程区分 = New BaseUI.Control.ComboBox()
        Me.nam発注日Title = New BaseUI.Control.NameBox()
        Me.nam発注納期Title = New BaseUI.Control.NameBox()
        Me.txt発注納期 = New BaseUI.Control.TextBox()
        Me.nam発注数Title = New BaseUI.Control.NameBox()
        Me.txt発注単価 = New BaseUI.Control.TextBox()
        Me.txt発注数 = New BaseUI.Control.TextBox()
        Me.ddl発注単位区分 = New BaseUI.Control.ComboBox()
        Me.nam単位Title = New BaseUI.Control.NameBox()
        Me.nam発注単価Title = New BaseUI.Control.NameBox()
        Me.nam発注金額Title = New BaseUI.Control.NameBox()
        Me.nam発注金額 = New BaseUI.Control.NameBox()
        Me.grp処理区分.SuspendLayout()
        Me.grp作業NO.SuspendLayout()
        Me.grp受注情報.SuspendLayout()
        CType(Me.grdDetall, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.grp処理区分.Location = New System.Drawing.Point(29, 22)
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
        'grp作業NO
        '
        Me.grp作業NO.Controls.Add(Me.txt作業NO)
        Me.grp作業NO.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp作業NO.Location = New System.Drawing.Point(337, 22)
        Me.grp作業NO.Name = "grp作業NO"
        Me.grp作業NO.Size = New System.Drawing.Size(96, 61)
        Me.grp作業NO.TabIndex = 1
        Me.grp作業NO.TabStop = False
        Me.grp作業NO.Text = "作業NO"
        '
        'txt作業NO
        '
        Me.txt作業NO.FieldLockType = BaseContents.Field.LockType.None
        Me.txt作業NO.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt作業NO.HelpKeys = ""
        Me.txt作業NO.HelpLink = ""
        Me.txt作業NO.HelpType = NodeUI.Help.Type.None
        Me.txt作業NO.IsError = False
        Me.txt作業NO.Location = New System.Drawing.Point(19, 25)
        Me.txt作業NO.Name = "txt作業NO"
        Me.txt作業NO.Required = False
        Me.txt作業NO.Size = New System.Drawing.Size(60, 23)
        Me.txt作業NO.StringLength = 65535
        Me.txt作業NO.TabIndex = 0
        Me.txt作業NO.Text = "XXXXXX"
        Me.txt作業NO.TextStyle = BaseContents.TextBox.TextStyle.Code
        '
        'grp受注情報
        '
        Me.grp受注情報.Controls.Add(Me.nam商品名)
        Me.grp受注情報.Controls.Add(Me.nam受注金額Title)
        Me.grp受注情報.Controls.Add(Me.nam受注単価Title)
        Me.grp受注情報.Controls.Add(Me.nam受注金額)
        Me.grp受注情報.Controls.Add(Me.nam受注単価)
        Me.grp受注情報.Controls.Add(Me.nam受注数)
        Me.grp受注情報.Controls.Add(Me.nam得意先名)
        Me.grp受注情報.Controls.Add(Me.nam受注数Title)
        Me.grp受注情報.Controls.Add(Me.nam商品名Title)
        Me.grp受注情報.Controls.Add(Me.nam得意先名Title)
        Me.grp受注情報.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp受注情報.Location = New System.Drawing.Point(29, 99)
        Me.grp受注情報.Name = "grp受注情報"
        Me.grp受注情報.Size = New System.Drawing.Size(902, 91)
        Me.grp受注情報.TabIndex = 2
        Me.grp受注情報.TabStop = False
        Me.grp受注情報.Text = "【受注情報】"
        '
        'nam商品名
        '
        Me.nam商品名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam商品名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam商品名.Location = New System.Drawing.Point(291, 52)
        Me.nam商品名.Name = "nam商品名"
        Me.nam商品名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam商品名.Size = New System.Drawing.Size(270, 23)
        Me.nam商品名.StringLength = 65535
        Me.nam商品名.TabIndex = 9
        Me.nam商品名.Text = "*XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX*"
        Me.nam商品名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam受注金額Title
        '
        Me.nam受注金額Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam受注金額Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam受注金額Title.Location = New System.Drawing.Point(776, 27)
        Me.nam受注金額Title.Name = "nam受注金額Title"
        Me.nam受注金額Title.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam受注金額Title.Size = New System.Drawing.Size(100, 23)
        Me.nam受注金額Title.StringLength = 65535
        Me.nam受注金額Title.TabIndex = 8
        Me.nam受注金額Title.Text = "受注金額"
        Me.nam受注金額Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam受注金額Title.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam受注単価Title
        '
        Me.nam受注単価Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam受注単価Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam受注単価Title.Location = New System.Drawing.Point(665, 27)
        Me.nam受注単価Title.Name = "nam受注単価Title"
        Me.nam受注単価Title.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam受注単価Title.Size = New System.Drawing.Size(110, 23)
        Me.nam受注単価Title.StringLength = 65535
        Me.nam受注単価Title.TabIndex = 7
        Me.nam受注単価Title.Text = "受注単価"
        Me.nam受注単価Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam受注単価Title.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam受注金額
        '
        Me.nam受注金額.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam受注金額.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam受注金額.Location = New System.Drawing.Point(776, 52)
        Me.nam受注金額.Name = "nam受注金額"
        Me.nam受注金額.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam受注金額.Size = New System.Drawing.Size(100, 23)
        Me.nam受注金額.StringLength = 65535
        Me.nam受注金額.TabIndex = 6
        Me.nam受注金額.Text = "999,999,999"
        Me.nam受注金額.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.nam受注金額.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam受注単価
        '
        Me.nam受注単価.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam受注単価.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam受注単価.Location = New System.Drawing.Point(665, 52)
        Me.nam受注単価.Name = "nam受注単価"
        Me.nam受注単価.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam受注単価.Size = New System.Drawing.Size(110, 23)
        Me.nam受注単価.StringLength = 65535
        Me.nam受注単価.TabIndex = 5
        Me.nam受注単価.Text = "9,999,999.00"
        Me.nam受注単価.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.nam受注単価.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam受注数
        '
        Me.nam受注数.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam受注数.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam受注数.Location = New System.Drawing.Point(563, 52)
        Me.nam受注数.Name = "nam受注数"
        Me.nam受注数.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam受注数.Size = New System.Drawing.Size(100, 23)
        Me.nam受注数.StringLength = 65535
        Me.nam受注数.TabIndex = 4
        Me.nam受注数.Text = "999,999,999"
        Me.nam受注数.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.nam受注数.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam得意先名
        '
        Me.nam得意先名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam得意先名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam得意先名.Location = New System.Drawing.Point(19, 52)
        Me.nam得意先名.Name = "nam得意先名"
        Me.nam得意先名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam得意先名.Size = New System.Drawing.Size(270, 23)
        Me.nam得意先名.StringLength = 65535
        Me.nam得意先名.TabIndex = 3
        Me.nam得意先名.Text = "*XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX*"
        Me.nam得意先名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam受注数Title
        '
        Me.nam受注数Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam受注数Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam受注数Title.Location = New System.Drawing.Point(563, 27)
        Me.nam受注数Title.Name = "nam受注数Title"
        Me.nam受注数Title.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam受注数Title.Size = New System.Drawing.Size(100, 23)
        Me.nam受注数Title.StringLength = 65535
        Me.nam受注数Title.TabIndex = 2
        Me.nam受注数Title.Text = "受注数"
        Me.nam受注数Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam受注数Title.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam商品名Title
        '
        Me.nam商品名Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam商品名Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam商品名Title.Location = New System.Drawing.Point(291, 27)
        Me.nam商品名Title.Name = "nam商品名Title"
        Me.nam商品名Title.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam商品名Title.Size = New System.Drawing.Size(270, 23)
        Me.nam商品名Title.StringLength = 65535
        Me.nam商品名Title.TabIndex = 1
        Me.nam商品名Title.Text = "商　　　品　　　名"
        Me.nam商品名Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam商品名Title.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam得意先名Title
        '
        Me.nam得意先名Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam得意先名Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam得意先名Title.Location = New System.Drawing.Point(19, 27)
        Me.nam得意先名Title.Name = "nam得意先名Title"
        Me.nam得意先名Title.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam得意先名Title.Size = New System.Drawing.Size(270, 23)
        Me.nam得意先名Title.StringLength = 65535
        Me.nam得意先名Title.TabIndex = 0
        Me.nam得意先名Title.Text = "得　　意　　先　　名"
        Me.nam得意先名Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam得意先名Title.TextStyle = BaseContents.TextBox.TextStyle.None
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
        Me.grdDetall.Location = New System.Drawing.Point(14, 209)
        Me.grdDetall.MultiSelect = False
        Me.grdDetall.Name = "grdDetall"
        Me.grdDetall.Required = False
        Me.grdDetall.RowHeadersVisible = False
        Me.grdDetall.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdDetall.Size = New System.Drawing.Size(990, 345)
        Me.grdDetall.TabIndex = 11
        Me.grdDetall.TabStop = False
        Me.grdDetall.TextBoxAddBtm = Nothing
        Me.grdDetall.TextBoxAddTop = Nothing
        '
        'txt発注先CD
        '
        Me.txt発注先CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt発注先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt発注先CD.HelpKeys = ""
        Me.txt発注先CD.HelpLink = ""
        Me.txt発注先CD.HelpType = NodeUI.Help.Type.None
        Me.txt発注先CD.IsError = False
        Me.txt発注先CD.Location = New System.Drawing.Point(14, 596)
        Me.txt発注先CD.Name = "txt発注先CD"
        Me.txt発注先CD.Required = False
        Me.txt発注先CD.Size = New System.Drawing.Size(60, 23)
        Me.txt発注先CD.StringLength = 65535
        Me.txt発注先CD.TabIndex = 3
        Me.txt発注先CD.Text = "XXXXXX"
        Me.txt発注先CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt発注日
        '
        Me.txt発注日.FieldLockType = BaseContents.Field.LockType.None
        Me.txt発注日.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt発注日.HelpKeys = ""
        Me.txt発注日.HelpLink = ""
        Me.txt発注日.HelpType = NodeUI.Help.Type.None
        Me.txt発注日.IsError = False
        Me.txt発注日.Location = New System.Drawing.Point(456, 596)
        Me.txt発注日.Name = "txt発注日"
        Me.txt発注日.Required = False
        Me.txt発注日.Size = New System.Drawing.Size(90, 23)
        Me.txt発注日.StringLength = 65535
        Me.txt発注日.TabIndex = 5
        Me.txt発注日.Text = "YYYY/MM/DD"
        Me.txt発注日.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam発注先Title
        '
        Me.nam発注先Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam発注先Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam発注先Title.Location = New System.Drawing.Point(14, 570)
        Me.nam発注先Title.Name = "nam発注先Title"
        Me.nam発注先Title.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam発注先Title.Size = New System.Drawing.Size(330, 23)
        Me.nam発注先Title.StringLength = 65535
        Me.nam発注先Title.TabIndex = 15
        Me.nam発注先Title.Text = "発　　注　　先　　名"
        Me.nam発注先Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam発注先Title.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam仕入先名
        '
        Me.nam仕入先名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam仕入先名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam仕入先名.Location = New System.Drawing.Point(74, 596)
        Me.nam仕入先名.Name = "nam仕入先名"
        Me.nam仕入先名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam仕入先名.Size = New System.Drawing.Size(270, 23)
        Me.nam仕入先名.StringLength = 65535
        Me.nam仕入先名.TabIndex = 16
        Me.nam仕入先名.Text = "*XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX*"
        Me.nam仕入先名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam工程Title
        '
        Me.nam工程Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam工程Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam工程Title.Location = New System.Drawing.Point(346, 570)
        Me.nam工程Title.Name = "nam工程Title"
        Me.nam工程Title.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam工程Title.Size = New System.Drawing.Size(110, 23)
        Me.nam工程Title.StringLength = 65535
        Me.nam工程Title.TabIndex = 17
        Me.nam工程Title.Text = "工　　程"
        Me.nam工程Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam工程Title.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'ddl工程区分
        '
        Me.ddl工程区分.AutoDropDown = True
        Me.ddl工程区分.DisplayMember = "Display"
        Me.ddl工程区分.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddl工程区分.FieldLockType = BaseContents.Field.LockType.None
        Me.ddl工程区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.ddl工程区分.FormattingEnabled = True
        Me.ddl工程区分.IsError = False
        Me.ddl工程区分.ListType = NodeUI.List.Type.None
        Me.ddl工程区分.Location = New System.Drawing.Point(346, 596)
        Me.ddl工程区分.Name = "ddl工程区分"
        Me.ddl工程区分.Required = False
        Me.ddl工程区分.Size = New System.Drawing.Size(110, 24)
        Me.ddl工程区分.TabIndex = 4
        Me.ddl工程区分.ValueMember = "Value"
        '
        'nam発注日Title
        '
        Me.nam発注日Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam発注日Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam発注日Title.Location = New System.Drawing.Point(456, 570)
        Me.nam発注日Title.Name = "nam発注日Title"
        Me.nam発注日Title.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam発注日Title.Size = New System.Drawing.Size(90, 23)
        Me.nam発注日Title.StringLength = 65535
        Me.nam発注日Title.TabIndex = 19
        Me.nam発注日Title.Text = "発注日"
        Me.nam発注日Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam発注日Title.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam発注納期Title
        '
        Me.nam発注納期Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam発注納期Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam発注納期Title.Location = New System.Drawing.Point(546, 570)
        Me.nam発注納期Title.Name = "nam発注納期Title"
        Me.nam発注納期Title.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam発注納期Title.Size = New System.Drawing.Size(90, 23)
        Me.nam発注納期Title.StringLength = 65535
        Me.nam発注納期Title.TabIndex = 21
        Me.nam発注納期Title.Text = "発注納期"
        Me.nam発注納期Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam発注納期Title.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt発注納期
        '
        Me.txt発注納期.FieldLockType = BaseContents.Field.LockType.None
        Me.txt発注納期.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt発注納期.HelpKeys = ""
        Me.txt発注納期.HelpLink = ""
        Me.txt発注納期.HelpType = NodeUI.Help.Type.None
        Me.txt発注納期.IsError = False
        Me.txt発注納期.Location = New System.Drawing.Point(546, 596)
        Me.txt発注納期.Name = "txt発注納期"
        Me.txt発注納期.Required = False
        Me.txt発注納期.Size = New System.Drawing.Size(90, 23)
        Me.txt発注納期.StringLength = 65535
        Me.txt発注納期.TabIndex = 6
        Me.txt発注納期.Text = "YYYY/MM/DD"
        Me.txt発注納期.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam発注数Title
        '
        Me.nam発注数Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam発注数Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam発注数Title.Location = New System.Drawing.Point(636, 570)
        Me.nam発注数Title.Name = "nam発注数Title"
        Me.nam発注数Title.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam発注数Title.Size = New System.Drawing.Size(95, 23)
        Me.nam発注数Title.StringLength = 65535
        Me.nam発注数Title.TabIndex = 22
        Me.nam発注数Title.Text = "発注数"
        Me.nam発注数Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam発注数Title.TextStyle = BaseContents.TextBox.TextStyle.None
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
        Me.txt発注単価.Location = New System.Drawing.Point(777, 596)
        Me.txt発注単価.Name = "txt発注単価"
        Me.txt発注単価.NumberMinor = 2
        Me.txt発注単価.Required = False
        Me.txt発注単価.Size = New System.Drawing.Size(111, 23)
        Me.txt発注単価.StringLength = 65535
        Me.txt発注単価.TabIndex = 9
        Me.txt発注単価.Text = "1,234,567.89"
        Me.txt発注単価.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt発注数
        '
        Me.txt発注数.FieldLockType = BaseContents.Field.LockType.None
        Me.txt発注数.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt発注数.HelpKeys = ""
        Me.txt発注数.HelpLink = ""
        Me.txt発注数.HelpType = NodeUI.Help.Type.None
        Me.txt発注数.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt発注数.IsError = False
        Me.txt発注数.Location = New System.Drawing.Point(636, 596)
        Me.txt発注数.Name = "txt発注数"
        Me.txt発注数.Required = False
        Me.txt発注数.Size = New System.Drawing.Size(95, 23)
        Me.txt発注数.StringLength = 65535
        Me.txt発注数.TabIndex = 7
        Me.txt発注数.Text = "123,456,789"
        Me.txt発注数.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'ddl発注単位区分
        '
        Me.ddl発注単位区分.AutoDropDown = True
        Me.ddl発注単位区分.DisplayMember = "Display"
        Me.ddl発注単位区分.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddl発注単位区分.FieldLockType = BaseContents.Field.LockType.None
        Me.ddl発注単位区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.ddl発注単位区分.FormattingEnabled = True
        Me.ddl発注単位区分.IsError = False
        Me.ddl発注単位区分.ListType = NodeUI.List.Type.None
        Me.ddl発注単位区分.Location = New System.Drawing.Point(732, 596)
        Me.ddl発注単位区分.Name = "ddl発注単位区分"
        Me.ddl発注単位区分.Required = False
        Me.ddl発注単位区分.Size = New System.Drawing.Size(45, 24)
        Me.ddl発注単位区分.TabIndex = 8
        Me.ddl発注単位区分.ValueMember = "Value"
        '
        'nam単位Title
        '
        Me.nam単位Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam単位Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam単位Title.Location = New System.Drawing.Point(732, 570)
        Me.nam単位Title.Name = "nam単位Title"
        Me.nam単位Title.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam単位Title.Size = New System.Drawing.Size(45, 23)
        Me.nam単位Title.StringLength = 65535
        Me.nam単位Title.TabIndex = 25
        Me.nam単位Title.Text = "単位"
        Me.nam単位Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam単位Title.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam発注単価Title
        '
        Me.nam発注単価Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam発注単価Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam発注単価Title.Location = New System.Drawing.Point(777, 570)
        Me.nam発注単価Title.Name = "nam発注単価Title"
        Me.nam発注単価Title.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam発注単価Title.Size = New System.Drawing.Size(111, 23)
        Me.nam発注単価Title.StringLength = 65535
        Me.nam発注単価Title.TabIndex = 26
        Me.nam発注単価Title.Text = "発注単価"
        Me.nam発注単価Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam発注単価Title.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam発注金額Title
        '
        Me.nam発注金額Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam発注金額Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam発注金額Title.Location = New System.Drawing.Point(888, 570)
        Me.nam発注金額Title.Name = "nam発注金額Title"
        Me.nam発注金額Title.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam発注金額Title.Size = New System.Drawing.Size(100, 23)
        Me.nam発注金額Title.StringLength = 65535
        Me.nam発注金額Title.TabIndex = 27
        Me.nam発注金額Title.Text = "発注金額"
        Me.nam発注金額Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam発注金額Title.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam発注金額
        '
        Me.nam発注金額.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam発注金額.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam発注金額.Location = New System.Drawing.Point(888, 596)
        Me.nam発注金額.Name = "nam発注金額"
        Me.nam発注金額.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam発注金額.Size = New System.Drawing.Size(100, 23)
        Me.nam発注金額.StringLength = 65535
        Me.nam発注金額.TabIndex = 28
        Me.nam発注金額.Text = "999,999,999"
        Me.nam発注金額.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'frmOffSet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.nam発注金額)
        Me.Controls.Add(Me.nam発注金額Title)
        Me.Controls.Add(Me.nam発注単価Title)
        Me.Controls.Add(Me.ddl発注単位区分)
        Me.Controls.Add(Me.nam単位Title)
        Me.Controls.Add(Me.txt発注単価)
        Me.Controls.Add(Me.txt発注数)
        Me.Controls.Add(Me.nam発注数Title)
        Me.Controls.Add(Me.nam発注納期Title)
        Me.Controls.Add(Me.txt発注納期)
        Me.Controls.Add(Me.nam発注日Title)
        Me.Controls.Add(Me.ddl工程区分)
        Me.Controls.Add(Me.nam工程Title)
        Me.Controls.Add(Me.nam仕入先名)
        Me.Controls.Add(Me.nam発注先Title)
        Me.Controls.Add(Me.txt発注日)
        Me.Controls.Add(Me.txt発注先CD)
        Me.Controls.Add(Me.grdDetall)
        Me.Controls.Add(Me.grp受注情報)
        Me.Controls.Add(Me.grp作業NO)
        Me.Controls.Add(Me.grp処理区分)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmOffSet"
        Me.Controls.SetChildIndex(Me.grp処理区分, 0)
        Me.Controls.SetChildIndex(Me.grp作業NO, 0)
        Me.Controls.SetChildIndex(Me.grp受注情報, 0)
        Me.Controls.SetChildIndex(Me.grdDetall, 0)
        Me.Controls.SetChildIndex(Me.txt発注先CD, 0)
        Me.Controls.SetChildIndex(Me.txt発注日, 0)
        Me.Controls.SetChildIndex(Me.nam発注先Title, 0)
        Me.Controls.SetChildIndex(Me.nam仕入先名, 0)
        Me.Controls.SetChildIndex(Me.nam工程Title, 0)
        Me.Controls.SetChildIndex(Me.ddl工程区分, 0)
        Me.Controls.SetChildIndex(Me.nam発注日Title, 0)
        Me.Controls.SetChildIndex(Me.txt発注納期, 0)
        Me.Controls.SetChildIndex(Me.nam発注納期Title, 0)
        Me.Controls.SetChildIndex(Me.nam発注数Title, 0)
        Me.Controls.SetChildIndex(Me.txt発注数, 0)
        Me.Controls.SetChildIndex(Me.txt発注単価, 0)
        Me.Controls.SetChildIndex(Me.nam単位Title, 0)
        Me.Controls.SetChildIndex(Me.ddl発注単位区分, 0)
        Me.Controls.SetChildIndex(Me.nam発注単価Title, 0)
        Me.Controls.SetChildIndex(Me.nam発注金額Title, 0)
        Me.Controls.SetChildIndex(Me.nam発注金額, 0)
        Me.grp処理区分.ResumeLayout(False)
        Me.grp処理区分.PerformLayout()
        Me.grp作業NO.ResumeLayout(False)
        Me.grp作業NO.PerformLayout()
        Me.grp受注情報.ResumeLayout(False)
        CType(Me.grdDetall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grp処理区分 As BaseUI.Control.GroupBox
    Friend WithEvents opt削除 As BaseUI.Control.RadioButton
    Friend WithEvents opt修正 As BaseUI.Control.RadioButton
    Friend WithEvents opt登録 As BaseUI.Control.RadioButton
    Friend WithEvents grp作業NO As BaseUI.Control.GroupBox
    Friend WithEvents txt作業NO As BaseUI.Control.TextBox
    Friend WithEvents grp受注情報 As BaseUI.Control.GroupBox
    Friend WithEvents nam得意先名Title As BaseUI.Control.NameBox
    Friend WithEvents nam商品名 As BaseUI.Control.NameBox
    Friend WithEvents nam受注金額Title As BaseUI.Control.NameBox
    Friend WithEvents nam受注単価Title As BaseUI.Control.NameBox
    Friend WithEvents nam受注金額 As BaseUI.Control.NameBox
    Friend WithEvents nam受注単価 As BaseUI.Control.NameBox
    Friend WithEvents nam受注数 As BaseUI.Control.NameBox
    Friend WithEvents nam得意先名 As BaseUI.Control.NameBox
    Friend WithEvents nam受注数Title As BaseUI.Control.NameBox
    Friend WithEvents nam商品名Title As BaseUI.Control.NameBox
    Friend WithEvents grdDetall As BaseUI.Control.GridInput
    Friend WithEvents txt発注先CD As BaseUI.Control.TextBox
    Friend WithEvents txt発注日 As BaseUI.Control.TextBox
    Friend WithEvents nam発注先Title As BaseUI.Control.NameBox
    Friend WithEvents nam仕入先名 As BaseUI.Control.NameBox
    Friend WithEvents nam工程Title As BaseUI.Control.NameBox
    Friend WithEvents ddl工程区分 As BaseUI.Control.ComboBox
    Friend WithEvents nam発注日Title As BaseUI.Control.NameBox
    Friend WithEvents nam発注納期Title As BaseUI.Control.NameBox
    Friend WithEvents txt発注納期 As BaseUI.Control.TextBox
    Friend WithEvents nam発注数Title As BaseUI.Control.NameBox
    Friend WithEvents txt発注単価 As BaseUI.Control.TextBox
    Friend WithEvents txt発注数 As BaseUI.Control.TextBox
    Friend WithEvents ddl発注単位区分 As BaseUI.Control.ComboBox
    Friend WithEvents nam単位Title As BaseUI.Control.NameBox
    Friend WithEvents nam発注単価Title As BaseUI.Control.NameBox
    Friend WithEvents nam発注金額Title As BaseUI.Control.NameBox
    Friend WithEvents nam発注金額 As BaseUI.Control.NameBox

End Class
