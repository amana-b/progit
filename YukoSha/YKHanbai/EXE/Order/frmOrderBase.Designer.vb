<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderBase
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
        Me.nam受注数合計Title = New BaseUI.Control.NameBox()
        Me.nam内在庫引当数合計Title = New BaseUI.Control.NameBox()
        Me.grp新再版区分 = New BaseUI.Control.GroupBox()
        Me.ddl新再版区分 = New BaseUI.Control.ComboBox()
        Me.grp本台帳NO = New BaseUI.Control.GroupBox()
        Me.txt本台帳NO = New BaseUI.Control.TextBox()
        Me.grp受注日付 = New BaseUI.Control.GroupBox()
        Me.txt受注日付 = New BaseUI.Control.TextBox()
        Me.grp御客様NO = New BaseUI.Control.GroupBox()
        Me.txt御客様NO = New BaseUI.Control.TextBox()
        Me.grp積算NO = New BaseUI.Control.GroupBox()
        Me.txt積算NO = New BaseUI.Control.TextBox()
        Me.grp納品日付B = New BaseUI.Control.GroupBox()
        Me.ddl確約区分 = New BaseUI.Control.ComboBox()
        Me.txt納品日付B = New BaseUI.Control.TextBox()
        Me.grp得意先CD = New BaseUI.Control.GroupBox()
        Me.nam得意先名 = New BaseUI.Control.NameBox()
        Me.txt得意先CD = New BaseUI.Control.TextBox()
        Me.grp請求先CD = New BaseUI.Control.GroupBox()
        Me.nam請求先名 = New BaseUI.Control.NameBox()
        Me.txt請求先CD = New BaseUI.Control.TextBox()
        Me.grp代表商品名 = New BaseUI.Control.GroupBox()
        Me.txt代表商品名 = New BaseUI.Control.TextBox()
        Me.grp受注区分 = New BaseUI.Control.GroupBox()
        Me.ddl受注区分 = New BaseUI.Control.ComboBox()
        Me.grp印刷場所 = New BaseUI.Control.GroupBox()
        Me.nam印刷場所名 = New BaseUI.Control.NameBox()
        Me.txt印刷場所CD = New BaseUI.Control.TextBox()
        Me.nam内製造数合計Title = New BaseUI.Control.NameBox()
        Me.grp作業注意 = New BaseUI.Control.GroupBox()
        Me.txt作業注意10 = New BaseUI.Control.TextBox()
        Me.txt作業注意09 = New BaseUI.Control.TextBox()
        Me.txt作業注意08 = New BaseUI.Control.TextBox()
        Me.txt作業注意07 = New BaseUI.Control.TextBox()
        Me.txt作業注意06 = New BaseUI.Control.TextBox()
        Me.txt作業注意05 = New BaseUI.Control.TextBox()
        Me.txt作業注意04 = New BaseUI.Control.TextBox()
        Me.txt作業注意03 = New BaseUI.Control.TextBox()
        Me.txt作業注意02 = New BaseUI.Control.TextBox()
        Me.txt作業注意01 = New BaseUI.Control.TextBox()
        Me.grp出荷先 = New BaseUI.Control.GroupBox()
        Me.txt出荷先CD04 = New BaseUI.Control.TextBox()
        Me.txt出荷先CD03 = New BaseUI.Control.TextBox()
        Me.txt出荷先CD02 = New BaseUI.Control.TextBox()
        Me.txt出荷先CD01 = New BaseUI.Control.TextBox()
        Me.txt出荷先名04 = New BaseUI.Control.TextBox()
        Me.txt出荷先名03 = New BaseUI.Control.TextBox()
        Me.txt出荷先名02 = New BaseUI.Control.TextBox()
        Me.txt出荷先名01 = New BaseUI.Control.TextBox()
        Me.grp納品日付A = New BaseUI.Control.GroupBox()
        Me.txt納品日付A = New BaseUI.Control.TextBox()
        Me.grp入力担当CD = New BaseUI.Control.GroupBox()
        Me.nam入力担当名 = New BaseUI.Control.NameBox()
        Me.txt入力担当CD = New BaseUI.Control.TextBox()
        Me.grp顧客商品CD = New BaseUI.Control.GroupBox()
        Me.txt顧客商品CD = New BaseUI.Control.TextBox()
        Me.btn商品内訳 = New BaseUI.Control.Button()
        Me.txt通数3 = New BaseUI.Control.TextBox()
        Me.nam通数3 = New BaseUI.Control.NameBox()
        Me.nam通数2 = New BaseUI.Control.NameBox()
        Me.txt通数2 = New BaseUI.Control.TextBox()
        Me.txt通数1 = New BaseUI.Control.TextBox()
        Me.nam通数1 = New BaseUI.Control.NameBox()
        Me.txt受注単価 = New BaseUI.Control.TextBox()
        Me.nam受注単位 = New BaseUI.Control.NameBox()
        Me.ddl単位区分 = New BaseUI.Control.ComboBox()
        Me.nam単位区分 = New BaseUI.Control.NameBox()
        Me.txt受注金額 = New BaseUI.Control.TextBox()
        Me.nam受注金額 = New BaseUI.Control.NameBox()
        Me.grp刃型NO = New BaseUI.Control.GroupBox()
        Me.txt刃型NO = New BaseUI.Control.TextBox()
        Me.grp版NO = New BaseUI.Control.GroupBox()
        Me.txt版NO = New BaseUI.Control.TextBox()
        Me.txtギヤ数 = New BaseUI.Control.TextBox()
        Me.grpｷﾞｱ数 = New BaseUI.Control.GroupBox()
        Me.lblファイ = New BaseUI.Control.Label()
        Me.grp発送仕上特記事項 = New BaseUI.Control.GroupBox()
        Me.txt発送仕上特記事項 = New BaseUI.Control.TextBox()
        Me.grp出荷注意 = New BaseUI.Control.GroupBox()
        Me.txt出荷注意10 = New BaseUI.Control.TextBox()
        Me.txt出荷注意09 = New BaseUI.Control.TextBox()
        Me.txt出荷注意08 = New BaseUI.Control.TextBox()
        Me.txt出荷注意07 = New BaseUI.Control.TextBox()
        Me.txt出荷注意06 = New BaseUI.Control.TextBox()
        Me.txt出荷注意05 = New BaseUI.Control.TextBox()
        Me.txt出荷注意04 = New BaseUI.Control.TextBox()
        Me.txt出荷注意03 = New BaseUI.Control.TextBox()
        Me.txt出荷注意02 = New BaseUI.Control.TextBox()
        Me.txt出荷注意01 = New BaseUI.Control.TextBox()
        Me.grp売上入力指示 = New BaseUI.Control.GroupBox()
        Me.txt売上金額 = New BaseUI.Control.TextBox()
        Me.ddl売上区分 = New BaseUI.Control.ComboBox()
        Me.txt売上名 = New BaseUI.Control.TextBox()
        Me.txt運賃金額 = New BaseUI.Control.TextBox()
        Me.ddl運賃売上区分 = New BaseUI.Control.ComboBox()
        Me.txt運賃単価 = New BaseUI.Control.TextBox()
        Me.txt運賃数量 = New BaseUI.Control.TextBox()
        Me.Label6 = New BaseUI.Control.Label()
        Me.Label7 = New BaseUI.Control.Label()
        Me.txt版下金額 = New BaseUI.Control.TextBox()
        Me.ddl版下売上区分 = New BaseUI.Control.ComboBox()
        Me.txt版下単価 = New BaseUI.Control.TextBox()
        Me.txt版下数量 = New BaseUI.Control.TextBox()
        Me.Label4 = New BaseUI.Control.Label()
        Me.Label5 = New BaseUI.Control.Label()
        Me.txt刃型金額 = New BaseUI.Control.TextBox()
        Me.ddl刃型売上区分 = New BaseUI.Control.ComboBox()
        Me.txt刃型単価 = New BaseUI.Control.TextBox()
        Me.txt刃型数量 = New BaseUI.Control.TextBox()
        Me.Label2 = New BaseUI.Control.Label()
        Me.Label3 = New BaseUI.Control.Label()
        Me.txt版代金額 = New BaseUI.Control.TextBox()
        Me.nam運賃 = New BaseUI.Control.NameBox()
        Me.nam版下代 = New BaseUI.Control.NameBox()
        Me.nam刃型代 = New BaseUI.Control.NameBox()
        Me.nam版代 = New BaseUI.Control.NameBox()
        Me.ddl版代売上区分 = New BaseUI.Control.ComboBox()
        Me.txt版代単価 = New BaseUI.Control.TextBox()
        Me.txt版代数量 = New BaseUI.Control.TextBox()
        Me.Label1 = New BaseUI.Control.Label()
        Me.lbl刃型サイズ一面角単位 = New BaseUI.Control.Label()
        Me.btn紙発注 = New BaseUI.Control.Button()
        Me.nam受注数合計 = New BaseUI.Control.NameBox()
        Me.nam内在庫引当数合計 = New BaseUI.Control.NameBox()
        Me.nam内製造数合計 = New BaseUI.Control.NameBox()
        Me.grp処理区分.SuspendLayout()
        Me.grp作業NO.SuspendLayout()
        Me.grp新再版区分.SuspendLayout()
        Me.grp本台帳NO.SuspendLayout()
        Me.grp受注日付.SuspendLayout()
        Me.grp御客様NO.SuspendLayout()
        Me.grp積算NO.SuspendLayout()
        Me.grp納品日付B.SuspendLayout()
        Me.grp得意先CD.SuspendLayout()
        Me.grp請求先CD.SuspendLayout()
        Me.grp代表商品名.SuspendLayout()
        Me.grp受注区分.SuspendLayout()
        Me.grp印刷場所.SuspendLayout()
        Me.grp作業注意.SuspendLayout()
        Me.grp出荷先.SuspendLayout()
        Me.grp納品日付A.SuspendLayout()
        Me.grp入力担当CD.SuspendLayout()
        Me.grp顧客商品CD.SuspendLayout()
        Me.grp刃型NO.SuspendLayout()
        Me.grp版NO.SuspendLayout()
        Me.grpｷﾞｱ数.SuspendLayout()
        Me.grp発送仕上特記事項.SuspendLayout()
        Me.grp出荷注意.SuspendLayout()
        Me.grp売上入力指示.SuspendLayout()
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
        Me.grp処理区分.Location = New System.Drawing.Point(7, 7)
        Me.grp処理区分.Name = "grp処理区分"
        Me.grp処理区分.Size = New System.Drawing.Size(267, 54)
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
        Me.opt削除.Location = New System.Drawing.Point(197, 21)
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
        Me.opt修正.Location = New System.Drawing.Point(108, 21)
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
        Me.opt登録.Location = New System.Drawing.Point(19, 21)
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
        Me.grp作業NO.Location = New System.Drawing.Point(426, 7)
        Me.grp作業NO.Name = "grp作業NO"
        Me.grp作業NO.Size = New System.Drawing.Size(90, 54)
        Me.grp作業NO.TabIndex = 2
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
        Me.txt作業NO.Location = New System.Drawing.Point(13, 21)
        Me.txt作業NO.Name = "txt作業NO"
        Me.txt作業NO.Required = False
        Me.txt作業NO.Size = New System.Drawing.Size(60, 23)
        Me.txt作業NO.TabIndex = 0
        Me.txt作業NO.Text = "XXXXXX"
        Me.txt作業NO.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam受注数合計Title
        '
        Me.nam受注数合計Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam受注数合計Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam受注数合計Title.Location = New System.Drawing.Point(7, 251)
        Me.nam受注数合計Title.Name = "nam受注数合計Title"
        Me.nam受注数合計Title.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam受注数合計Title.Size = New System.Drawing.Size(95, 23)
        Me.nam受注数合計Title.StringLength = 0
        Me.nam受注数合計Title.TabIndex = 15
        Me.nam受注数合計Title.Text = "受注数合計"
        Me.nam受注数合計Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam受注数合計Title.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam内在庫引当数合計Title
        '
        Me.nam内在庫引当数合計Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam内在庫引当数合計Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.nam内在庫引当数合計Title.Location = New System.Drawing.Point(104, 251)
        Me.nam内在庫引当数合計Title.Name = "nam内在庫引当数合計Title"
        Me.nam内在庫引当数合計Title.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam内在庫引当数合計Title.Size = New System.Drawing.Size(95, 23)
        Me.nam内在庫引当数合計Title.StringLength = 0
        Me.nam内在庫引当数合計Title.TabIndex = 16
        Me.nam内在庫引当数合計Title.Text = "内在庫使用合計"
        Me.nam内在庫引当数合計Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam内在庫引当数合計Title.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp新再版区分
        '
        Me.grp新再版区分.Controls.Add(Me.ddl新再版区分)
        Me.grp新再版区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp新再版区分.Location = New System.Drawing.Point(283, 7)
        Me.grp新再版区分.Name = "grp新再版区分"
        Me.grp新再版区分.Size = New System.Drawing.Size(134, 54)
        Me.grp新再版区分.TabIndex = 1
        Me.grp新再版区分.TabStop = False
        Me.grp新再版区分.Text = "新版･再版区分"
        '
        'ddl新再版区分
        '
        Me.ddl新再版区分.AutoDropDown = True
        Me.ddl新再版区分.DisplayMember = "Display"
        Me.ddl新再版区分.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddl新再版区分.FieldLockType = BaseContents.Field.LockType.None
        Me.ddl新再版区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.ddl新再版区分.FormattingEnabled = True
        Me.ddl新再版区分.IsError = False
        Me.ddl新再版区分.ListType = NodeUI.List.Type.None
        Me.ddl新再版区分.Location = New System.Drawing.Point(12, 21)
        Me.ddl新再版区分.Name = "ddl新再版区分"
        Me.ddl新再版区分.Required = False
        Me.ddl新再版区分.Size = New System.Drawing.Size(110, 24)
        Me.ddl新再版区分.TabIndex = 0
        Me.ddl新再版区分.ValueMember = "Value"
        '
        'grp本台帳NO
        '
        Me.grp本台帳NO.Controls.Add(Me.txt本台帳NO)
        Me.grp本台帳NO.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp本台帳NO.Location = New System.Drawing.Point(524, 7)
        Me.grp本台帳NO.Name = "grp本台帳NO"
        Me.grp本台帳NO.Size = New System.Drawing.Size(90, 54)
        Me.grp本台帳NO.TabIndex = 3
        Me.grp本台帳NO.TabStop = False
        Me.grp本台帳NO.Text = "本台帳NO"
        '
        'txt本台帳NO
        '
        Me.txt本台帳NO.FieldLockType = BaseContents.Field.LockType.None
        Me.txt本台帳NO.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt本台帳NO.HelpKeys = ""
        Me.txt本台帳NO.HelpLink = ""
        Me.txt本台帳NO.HelpType = NodeUI.Help.Type.None
        Me.txt本台帳NO.IsError = False
        Me.txt本台帳NO.Location = New System.Drawing.Point(13, 21)
        Me.txt本台帳NO.Name = "txt本台帳NO"
        Me.txt本台帳NO.Required = False
        Me.txt本台帳NO.Size = New System.Drawing.Size(60, 23)
        Me.txt本台帳NO.TabIndex = 0
        Me.txt本台帳NO.Text = "XXXXXX"
        Me.txt本台帳NO.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp受注日付
        '
        Me.grp受注日付.Controls.Add(Me.txt受注日付)
        Me.grp受注日付.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp受注日付.Location = New System.Drawing.Point(7, 69)
        Me.grp受注日付.Name = "grp受注日付"
        Me.grp受注日付.Size = New System.Drawing.Size(110, 54)
        Me.grp受注日付.TabIndex = 6
        Me.grp受注日付.TabStop = False
        Me.grp受注日付.Text = "受注年月日"
        '
        'txt受注日付
        '
        Me.txt受注日付.FieldLockType = BaseContents.Field.LockType.None
        Me.txt受注日付.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt受注日付.HelpKeys = ""
        Me.txt受注日付.HelpLink = ""
        Me.txt受注日付.HelpType = NodeUI.Help.Type.None
        Me.txt受注日付.IsError = False
        Me.txt受注日付.Location = New System.Drawing.Point(9, 21)
        Me.txt受注日付.Name = "txt受注日付"
        Me.txt受注日付.Required = False
        Me.txt受注日付.Size = New System.Drawing.Size(90, 23)
        Me.txt受注日付.TabIndex = 0
        Me.txt受注日付.Text = "YYYY/MM/DD"
        Me.txt受注日付.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp御客様NO
        '
        Me.grp御客様NO.Controls.Add(Me.txt御客様NO)
        Me.grp御客様NO.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp御客様NO.Location = New System.Drawing.Point(722, 7)
        Me.grp御客様NO.Name = "grp御客様NO"
        Me.grp御客様NO.Size = New System.Drawing.Size(90, 54)
        Me.grp御客様NO.TabIndex = 5
        Me.grp御客様NO.TabStop = False
        Me.grp御客様NO.Text = "御客様NO"
        '
        'txt御客様NO
        '
        Me.txt御客様NO.FieldLockType = BaseContents.Field.LockType.None
        Me.txt御客様NO.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt御客様NO.HelpKeys = ""
        Me.txt御客様NO.HelpLink = ""
        Me.txt御客様NO.HelpType = NodeUI.Help.Type.None
        Me.txt御客様NO.IsError = False
        Me.txt御客様NO.Location = New System.Drawing.Point(13, 21)
        Me.txt御客様NO.Name = "txt御客様NO"
        Me.txt御客様NO.Required = False
        Me.txt御客様NO.Size = New System.Drawing.Size(42, 23)
        Me.txt御客様NO.TabIndex = 0
        Me.txt御客様NO.Text = "XXXX"
        Me.txt御客様NO.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp積算NO
        '
        Me.grp積算NO.Controls.Add(Me.txt積算NO)
        Me.grp積算NO.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp積算NO.Location = New System.Drawing.Point(622, 7)
        Me.grp積算NO.Name = "grp積算NO"
        Me.grp積算NO.Size = New System.Drawing.Size(90, 54)
        Me.grp積算NO.TabIndex = 4
        Me.grp積算NO.TabStop = False
        Me.grp積算NO.Text = "積算NO"
        '
        'txt積算NO
        '
        Me.txt積算NO.FieldLockType = BaseContents.Field.LockType.None
        Me.txt積算NO.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt積算NO.HelpKeys = ""
        Me.txt積算NO.HelpLink = ""
        Me.txt積算NO.HelpType = NodeUI.Help.Type.None
        Me.txt積算NO.IsError = False
        Me.txt積算NO.Location = New System.Drawing.Point(13, 21)
        Me.txt積算NO.Name = "txt積算NO"
        Me.txt積算NO.Required = False
        Me.txt積算NO.Size = New System.Drawing.Size(60, 23)
        Me.txt積算NO.TabIndex = 0
        Me.txt積算NO.Text = "XXXXXX"
        Me.txt積算NO.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp納品日付B
        '
        Me.grp納品日付B.Controls.Add(Me.ddl確約区分)
        Me.grp納品日付B.Controls.Add(Me.txt納品日付B)
        Me.grp納品日付B.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp納品日付B.Location = New System.Drawing.Point(274, 69)
        Me.grp納品日付B.Name = "grp納品日付B"
        Me.grp納品日付B.Size = New System.Drawing.Size(181, 54)
        Me.grp納品日付B.TabIndex = 8
        Me.grp納品日付B.TabStop = False
        Me.grp納品日付B.Text = "納品年月日"
        '
        'ddl確約区分
        '
        Me.ddl確約区分.AutoDropDown = True
        Me.ddl確約区分.DisplayMember = "Display"
        Me.ddl確約区分.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddl確約区分.FieldLockType = BaseContents.Field.LockType.None
        Me.ddl確約区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.ddl確約区分.FormattingEnabled = True
        Me.ddl確約区分.IsError = False
        Me.ddl確約区分.ListType = NodeUI.List.Type.None
        Me.ddl確約区分.Location = New System.Drawing.Point(102, 20)
        Me.ddl確約区分.Name = "ddl確約区分"
        Me.ddl確約区分.Required = False
        Me.ddl確約区分.Size = New System.Drawing.Size(60, 24)
        Me.ddl確約区分.TabIndex = 1
        Me.ddl確約区分.ValueMember = "Value"
        '
        'txt納品日付B
        '
        Me.txt納品日付B.FieldLockType = BaseContents.Field.LockType.None
        Me.txt納品日付B.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt納品日付B.HelpKeys = ""
        Me.txt納品日付B.HelpLink = ""
        Me.txt納品日付B.HelpType = NodeUI.Help.Type.None
        Me.txt納品日付B.IsError = False
        Me.txt納品日付B.Location = New System.Drawing.Point(9, 21)
        Me.txt納品日付B.Name = "txt納品日付B"
        Me.txt納品日付B.Required = False
        Me.txt納品日付B.Size = New System.Drawing.Size(90, 23)
        Me.txt納品日付B.TabIndex = 0
        Me.txt納品日付B.Text = "YYYY/MM/DD"
        Me.txt納品日付B.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp得意先CD
        '
        Me.grp得意先CD.Controls.Add(Me.nam得意先名)
        Me.grp得意先CD.Controls.Add(Me.txt得意先CD)
        Me.grp得意先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp得意先CD.Location = New System.Drawing.Point(7, 128)
        Me.grp得意先CD.Name = "grp得意先CD"
        Me.grp得意先CD.Size = New System.Drawing.Size(347, 54)
        Me.grp得意先CD.TabIndex = 10
        Me.grp得意先CD.TabStop = False
        Me.grp得意先CD.Text = "ユーザー番号"
        '
        'nam得意先名
        '
        Me.nam得意先名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam得意先名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam得意先名.Location = New System.Drawing.Point(70, 21)
        Me.nam得意先名.Name = "nam得意先名"
        Me.nam得意先名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam得意先名.Size = New System.Drawing.Size(270, 23)
        Me.nam得意先名.StringLength = 0
        Me.nam得意先名.TabIndex = 1
        Me.nam得意先名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt得意先CD
        '
        Me.txt得意先CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt得意先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt得意先CD.HelpKeys = ""
        Me.txt得意先CD.HelpLink = ""
        Me.txt得意先CD.HelpType = NodeUI.Help.Type.None
        Me.txt得意先CD.IsError = False
        Me.txt得意先CD.Location = New System.Drawing.Point(9, 21)
        Me.txt得意先CD.Name = "txt得意先CD"
        Me.txt得意先CD.Required = False
        Me.txt得意先CD.Size = New System.Drawing.Size(60, 23)
        Me.txt得意先CD.TabIndex = 0
        Me.txt得意先CD.Text = "XXXXXX"
        Me.txt得意先CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp請求先CD
        '
        Me.grp請求先CD.Controls.Add(Me.nam請求先名)
        Me.grp請求先CD.Controls.Add(Me.txt請求先CD)
        Me.grp請求先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp請求先CD.Location = New System.Drawing.Point(374, 128)
        Me.grp請求先CD.Name = "grp請求先CD"
        Me.grp請求先CD.Size = New System.Drawing.Size(347, 54)
        Me.grp請求先CD.TabIndex = 11
        Me.grp請求先CD.TabStop = False
        Me.grp請求先CD.Text = "請求先ｺｰﾄﾞ　★得意先と異なる時のみ入力"
        '
        'nam請求先名
        '
        Me.nam請求先名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam請求先名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam請求先名.Location = New System.Drawing.Point(70, 21)
        Me.nam請求先名.Name = "nam請求先名"
        Me.nam請求先名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam請求先名.Size = New System.Drawing.Size(270, 23)
        Me.nam請求先名.StringLength = 0
        Me.nam請求先名.TabIndex = 1
        Me.nam請求先名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt請求先CD
        '
        Me.txt請求先CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt請求先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt請求先CD.HelpKeys = ""
        Me.txt請求先CD.HelpLink = ""
        Me.txt請求先CD.HelpType = NodeUI.Help.Type.None
        Me.txt請求先CD.IsError = False
        Me.txt請求先CD.Location = New System.Drawing.Point(9, 21)
        Me.txt請求先CD.Name = "txt請求先CD"
        Me.txt請求先CD.Required = False
        Me.txt請求先CD.Size = New System.Drawing.Size(60, 23)
        Me.txt請求先CD.TabIndex = 0
        Me.txt請求先CD.Text = "XXXXXX"
        Me.txt請求先CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp代表商品名
        '
        Me.grp代表商品名.Controls.Add(Me.txt代表商品名)
        Me.grp代表商品名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp代表商品名.Location = New System.Drawing.Point(7, 188)
        Me.grp代表商品名.Name = "grp代表商品名"
        Me.grp代表商品名.Size = New System.Drawing.Size(298, 54)
        Me.grp代表商品名.TabIndex = 12
        Me.grp代表商品名.TabStop = False
        Me.grp代表商品名.Text = "商品名(代表)"
        '
        'txt代表商品名
        '
        Me.txt代表商品名.FieldLockType = BaseContents.Field.LockType.None
        Me.txt代表商品名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt代表商品名.HelpKeys = ""
        Me.txt代表商品名.HelpLink = ""
        Me.txt代表商品名.HelpType = NodeUI.Help.Type.None
        Me.txt代表商品名.IsError = False
        Me.txt代表商品名.Location = New System.Drawing.Point(9, 21)
        Me.txt代表商品名.Name = "txt代表商品名"
        Me.txt代表商品名.Required = False
        Me.txt代表商品名.Size = New System.Drawing.Size(270, 23)
        Me.txt代表商品名.TabIndex = 0
        Me.txt代表商品名.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.txt代表商品名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp受注区分
        '
        Me.grp受注区分.Controls.Add(Me.ddl受注区分)
        Me.grp受注区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp受注区分.Location = New System.Drawing.Point(127, 306)
        Me.grp受注区分.Name = "grp受注区分"
        Me.grp受注区分.Size = New System.Drawing.Size(145, 54)
        Me.grp受注区分.TabIndex = 34
        Me.grp受注区分.TabStop = False
        Me.grp受注区分.Text = "受注区分"
        '
        'ddl受注区分
        '
        Me.ddl受注区分.AutoDropDown = True
        Me.ddl受注区分.DisplayMember = "Display"
        Me.ddl受注区分.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddl受注区分.FieldLockType = BaseContents.Field.LockType.None
        Me.ddl受注区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.ddl受注区分.FormattingEnabled = True
        Me.ddl受注区分.IsError = False
        Me.ddl受注区分.ListType = NodeUI.List.Type.None
        Me.ddl受注区分.Location = New System.Drawing.Point(8, 21)
        Me.ddl受注区分.Name = "ddl受注区分"
        Me.ddl受注区分.Required = False
        Me.ddl受注区分.Size = New System.Drawing.Size(130, 24)
        Me.ddl受注区分.TabIndex = 0
        Me.ddl受注区分.ValueMember = "Value"
        '
        'grp印刷場所
        '
        Me.grp印刷場所.Controls.Add(Me.nam印刷場所名)
        Me.grp印刷場所.Controls.Add(Me.txt印刷場所CD)
        Me.grp印刷場所.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp印刷場所.Location = New System.Drawing.Point(7, 306)
        Me.grp印刷場所.Name = "grp印刷場所"
        Me.grp印刷場所.Size = New System.Drawing.Size(115, 54)
        Me.grp印刷場所.TabIndex = 33
        Me.grp印刷場所.TabStop = False
        Me.grp印刷場所.Text = "印刷場所"
        '
        'nam印刷場所名
        '
        Me.nam印刷場所名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam印刷場所名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam印刷場所名.Location = New System.Drawing.Point(32, 21)
        Me.nam印刷場所名.Name = "nam印刷場所名"
        Me.nam印刷場所名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam印刷場所名.Size = New System.Drawing.Size(75, 23)
        Me.nam印刷場所名.StringLength = 0
        Me.nam印刷場所名.TabIndex = 1
        Me.nam印刷場所名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt印刷場所CD
        '
        Me.txt印刷場所CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt印刷場所CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt印刷場所CD.HelpKeys = ""
        Me.txt印刷場所CD.HelpLink = ""
        Me.txt印刷場所CD.HelpType = NodeUI.Help.Type.None
        Me.txt印刷場所CD.IsError = False
        Me.txt印刷場所CD.Location = New System.Drawing.Point(7, 21)
        Me.txt印刷場所CD.Name = "txt印刷場所CD"
        Me.txt印刷場所CD.Required = False
        Me.txt印刷場所CD.Size = New System.Drawing.Size(24, 23)
        Me.txt印刷場所CD.TabIndex = 0
        Me.txt印刷場所CD.Text = "XX"
        Me.txt印刷場所CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam内製造数合計Title
        '
        Me.nam内製造数合計Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam内製造数合計Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.nam内製造数合計Title.Location = New System.Drawing.Point(201, 251)
        Me.nam内製造数合計Title.Name = "nam内製造数合計Title"
        Me.nam内製造数合計Title.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam内製造数合計Title.Size = New System.Drawing.Size(95, 23)
        Me.nam内製造数合計Title.StringLength = 0
        Me.nam内製造数合計Title.TabIndex = 17
        Me.nam内製造数合計Title.Text = "内製造数合計"
        Me.nam内製造数合計Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam内製造数合計Title.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp作業注意
        '
        Me.grp作業注意.Controls.Add(Me.txt作業注意10)
        Me.grp作業注意.Controls.Add(Me.txt作業注意09)
        Me.grp作業注意.Controls.Add(Me.txt作業注意08)
        Me.grp作業注意.Controls.Add(Me.txt作業注意07)
        Me.grp作業注意.Controls.Add(Me.txt作業注意06)
        Me.grp作業注意.Controls.Add(Me.txt作業注意05)
        Me.grp作業注意.Controls.Add(Me.txt作業注意04)
        Me.grp作業注意.Controls.Add(Me.txt作業注意03)
        Me.grp作業注意.Controls.Add(Me.txt作業注意02)
        Me.grp作業注意.Controls.Add(Me.txt作業注意01)
        Me.grp作業注意.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp作業注意.Location = New System.Drawing.Point(8, 379)
        Me.grp作業注意.Name = "grp作業注意"
        Me.grp作業注意.Size = New System.Drawing.Size(355, 265)
        Me.grp作業注意.TabIndex = 39
        Me.grp作業注意.TabStop = False
        Me.grp作業注意.Text = "【作業時の注意事項】"
        '
        'txt作業注意10
        '
        Me.txt作業注意10.FieldLockType = BaseContents.Field.LockType.None
        Me.txt作業注意10.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt作業注意10.ForeColor = System.Drawing.Color.Red
        Me.txt作業注意10.HelpKeys = ""
        Me.txt作業注意10.HelpLink = ""
        Me.txt作業注意10.HelpType = NodeUI.Help.Type.None
        Me.txt作業注意10.IsError = False
        Me.txt作業注意10.Location = New System.Drawing.Point(10, 230)
        Me.txt作業注意10.Name = "txt作業注意10"
        Me.txt作業注意10.Required = False
        Me.txt作業注意10.Size = New System.Drawing.Size(335, 23)
        Me.txt作業注意10.TabIndex = 9
        Me.txt作業注意10.Text = "*XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX*"
        Me.txt作業注意10.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt作業注意09
        '
        Me.txt作業注意09.FieldLockType = BaseContents.Field.LockType.None
        Me.txt作業注意09.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt作業注意09.ForeColor = System.Drawing.Color.Red
        Me.txt作業注意09.HelpKeys = ""
        Me.txt作業注意09.HelpLink = ""
        Me.txt作業注意09.HelpType = NodeUI.Help.Type.None
        Me.txt作業注意09.IsError = False
        Me.txt作業注意09.Location = New System.Drawing.Point(10, 207)
        Me.txt作業注意09.Name = "txt作業注意09"
        Me.txt作業注意09.Required = False
        Me.txt作業注意09.Size = New System.Drawing.Size(335, 23)
        Me.txt作業注意09.TabIndex = 8
        Me.txt作業注意09.Text = "*XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX*"
        Me.txt作業注意09.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt作業注意08
        '
        Me.txt作業注意08.FieldLockType = BaseContents.Field.LockType.None
        Me.txt作業注意08.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt作業注意08.ForeColor = System.Drawing.Color.Red
        Me.txt作業注意08.HelpKeys = ""
        Me.txt作業注意08.HelpLink = ""
        Me.txt作業注意08.HelpType = NodeUI.Help.Type.None
        Me.txt作業注意08.IsError = False
        Me.txt作業注意08.Location = New System.Drawing.Point(10, 185)
        Me.txt作業注意08.Name = "txt作業注意08"
        Me.txt作業注意08.Required = False
        Me.txt作業注意08.Size = New System.Drawing.Size(335, 23)
        Me.txt作業注意08.TabIndex = 7
        Me.txt作業注意08.Text = "*XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX*"
        Me.txt作業注意08.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt作業注意07
        '
        Me.txt作業注意07.FieldLockType = BaseContents.Field.LockType.None
        Me.txt作業注意07.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt作業注意07.ForeColor = System.Drawing.Color.Red
        Me.txt作業注意07.HelpKeys = ""
        Me.txt作業注意07.HelpLink = ""
        Me.txt作業注意07.HelpType = NodeUI.Help.Type.None
        Me.txt作業注意07.IsError = False
        Me.txt作業注意07.Location = New System.Drawing.Point(10, 162)
        Me.txt作業注意07.Name = "txt作業注意07"
        Me.txt作業注意07.Required = False
        Me.txt作業注意07.Size = New System.Drawing.Size(335, 23)
        Me.txt作業注意07.TabIndex = 6
        Me.txt作業注意07.Text = "*XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX*"
        Me.txt作業注意07.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt作業注意06
        '
        Me.txt作業注意06.FieldLockType = BaseContents.Field.LockType.None
        Me.txt作業注意06.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt作業注意06.ForeColor = System.Drawing.Color.Red
        Me.txt作業注意06.HelpKeys = ""
        Me.txt作業注意06.HelpLink = ""
        Me.txt作業注意06.HelpType = NodeUI.Help.Type.None
        Me.txt作業注意06.IsError = False
        Me.txt作業注意06.Location = New System.Drawing.Point(10, 139)
        Me.txt作業注意06.Name = "txt作業注意06"
        Me.txt作業注意06.Required = False
        Me.txt作業注意06.Size = New System.Drawing.Size(335, 23)
        Me.txt作業注意06.TabIndex = 5
        Me.txt作業注意06.Text = "*XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX*"
        Me.txt作業注意06.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt作業注意05
        '
        Me.txt作業注意05.FieldLockType = BaseContents.Field.LockType.None
        Me.txt作業注意05.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt作業注意05.ForeColor = System.Drawing.Color.Red
        Me.txt作業注意05.HelpKeys = ""
        Me.txt作業注意05.HelpLink = ""
        Me.txt作業注意05.HelpType = NodeUI.Help.Type.None
        Me.txt作業注意05.IsError = False
        Me.txt作業注意05.Location = New System.Drawing.Point(10, 117)
        Me.txt作業注意05.Name = "txt作業注意05"
        Me.txt作業注意05.Required = False
        Me.txt作業注意05.Size = New System.Drawing.Size(335, 23)
        Me.txt作業注意05.TabIndex = 4
        Me.txt作業注意05.Text = "*XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX*"
        Me.txt作業注意05.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt作業注意04
        '
        Me.txt作業注意04.FieldLockType = BaseContents.Field.LockType.None
        Me.txt作業注意04.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt作業注意04.ForeColor = System.Drawing.Color.Red
        Me.txt作業注意04.HelpKeys = ""
        Me.txt作業注意04.HelpLink = ""
        Me.txt作業注意04.HelpType = NodeUI.Help.Type.None
        Me.txt作業注意04.IsError = False
        Me.txt作業注意04.Location = New System.Drawing.Point(10, 94)
        Me.txt作業注意04.Name = "txt作業注意04"
        Me.txt作業注意04.Required = False
        Me.txt作業注意04.Size = New System.Drawing.Size(335, 23)
        Me.txt作業注意04.TabIndex = 3
        Me.txt作業注意04.Text = "*XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX*"
        Me.txt作業注意04.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt作業注意03
        '
        Me.txt作業注意03.FieldLockType = BaseContents.Field.LockType.None
        Me.txt作業注意03.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt作業注意03.ForeColor = System.Drawing.Color.Red
        Me.txt作業注意03.HelpKeys = ""
        Me.txt作業注意03.HelpLink = ""
        Me.txt作業注意03.HelpType = NodeUI.Help.Type.None
        Me.txt作業注意03.IsError = False
        Me.txt作業注意03.Location = New System.Drawing.Point(10, 72)
        Me.txt作業注意03.Name = "txt作業注意03"
        Me.txt作業注意03.Required = False
        Me.txt作業注意03.Size = New System.Drawing.Size(335, 23)
        Me.txt作業注意03.TabIndex = 2
        Me.txt作業注意03.Text = "*XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX*"
        Me.txt作業注意03.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt作業注意02
        '
        Me.txt作業注意02.FieldLockType = BaseContents.Field.LockType.None
        Me.txt作業注意02.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt作業注意02.ForeColor = System.Drawing.Color.Red
        Me.txt作業注意02.HelpKeys = ""
        Me.txt作業注意02.HelpLink = ""
        Me.txt作業注意02.HelpType = NodeUI.Help.Type.None
        Me.txt作業注意02.IsError = False
        Me.txt作業注意02.Location = New System.Drawing.Point(10, 49)
        Me.txt作業注意02.Name = "txt作業注意02"
        Me.txt作業注意02.Required = False
        Me.txt作業注意02.Size = New System.Drawing.Size(335, 23)
        Me.txt作業注意02.TabIndex = 1
        Me.txt作業注意02.Text = "*XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX*"
        Me.txt作業注意02.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt作業注意01
        '
        Me.txt作業注意01.FieldLockType = BaseContents.Field.LockType.None
        Me.txt作業注意01.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt作業注意01.ForeColor = System.Drawing.Color.Red
        Me.txt作業注意01.HelpKeys = ""
        Me.txt作業注意01.HelpLink = ""
        Me.txt作業注意01.HelpType = NodeUI.Help.Type.None
        Me.txt作業注意01.IsError = False
        Me.txt作業注意01.Location = New System.Drawing.Point(10, 26)
        Me.txt作業注意01.Name = "txt作業注意01"
        Me.txt作業注意01.Required = False
        Me.txt作業注意01.Size = New System.Drawing.Size(335, 23)
        Me.txt作業注意01.TabIndex = 0
        Me.txt作業注意01.Text = "*XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX*"
        Me.txt作業注意01.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp出荷先
        '
        Me.grp出荷先.Controls.Add(Me.txt出荷先CD04)
        Me.grp出荷先.Controls.Add(Me.txt出荷先CD03)
        Me.grp出荷先.Controls.Add(Me.txt出荷先CD02)
        Me.grp出荷先.Controls.Add(Me.txt出荷先CD01)
        Me.grp出荷先.Controls.Add(Me.txt出荷先名04)
        Me.grp出荷先.Controls.Add(Me.txt出荷先名03)
        Me.grp出荷先.Controls.Add(Me.txt出荷先名02)
        Me.grp出荷先.Controls.Add(Me.txt出荷先名01)
        Me.grp出荷先.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp出荷先.Location = New System.Drawing.Point(569, 513)
        Me.grp出荷先.Name = "grp出荷先"
        Me.grp出荷先.Size = New System.Drawing.Size(325, 131)
        Me.grp出荷先.TabIndex = 42
        Me.grp出荷先.TabStop = False
        Me.grp出荷先.Text = "【出荷先】"
        '
        'txt出荷先CD04
        '
        Me.txt出荷先CD04.FieldLockType = BaseContents.Field.LockType.None
        Me.txt出荷先CD04.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt出荷先CD04.HelpKeys = ""
        Me.txt出荷先CD04.HelpLink = ""
        Me.txt出荷先CD04.HelpType = NodeUI.Help.Type.None
        Me.txt出荷先CD04.IsError = False
        Me.txt出荷先CD04.Location = New System.Drawing.Point(11, 94)
        Me.txt出荷先CD04.Name = "txt出荷先CD04"
        Me.txt出荷先CD04.Required = False
        Me.txt出荷先CD04.Size = New System.Drawing.Size(32, 23)
        Me.txt出荷先CD04.TabIndex = 6
        Me.txt出荷先CD04.Text = "XXX"
        Me.txt出荷先CD04.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt出荷先CD03
        '
        Me.txt出荷先CD03.FieldLockType = BaseContents.Field.LockType.None
        Me.txt出荷先CD03.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt出荷先CD03.HelpKeys = ""
        Me.txt出荷先CD03.HelpLink = ""
        Me.txt出荷先CD03.HelpType = NodeUI.Help.Type.None
        Me.txt出荷先CD03.IsError = False
        Me.txt出荷先CD03.Location = New System.Drawing.Point(11, 72)
        Me.txt出荷先CD03.Name = "txt出荷先CD03"
        Me.txt出荷先CD03.Required = False
        Me.txt出荷先CD03.Size = New System.Drawing.Size(32, 23)
        Me.txt出荷先CD03.TabIndex = 4
        Me.txt出荷先CD03.Text = "XXX"
        Me.txt出荷先CD03.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt出荷先CD02
        '
        Me.txt出荷先CD02.FieldLockType = BaseContents.Field.LockType.None
        Me.txt出荷先CD02.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt出荷先CD02.HelpKeys = ""
        Me.txt出荷先CD02.HelpLink = ""
        Me.txt出荷先CD02.HelpType = NodeUI.Help.Type.None
        Me.txt出荷先CD02.IsError = False
        Me.txt出荷先CD02.Location = New System.Drawing.Point(11, 49)
        Me.txt出荷先CD02.Name = "txt出荷先CD02"
        Me.txt出荷先CD02.Required = False
        Me.txt出荷先CD02.Size = New System.Drawing.Size(32, 23)
        Me.txt出荷先CD02.TabIndex = 2
        Me.txt出荷先CD02.Text = "XXX"
        Me.txt出荷先CD02.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt出荷先CD01
        '
        Me.txt出荷先CD01.FieldLockType = BaseContents.Field.LockType.None
        Me.txt出荷先CD01.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt出荷先CD01.HelpKeys = ""
        Me.txt出荷先CD01.HelpLink = ""
        Me.txt出荷先CD01.HelpType = NodeUI.Help.Type.None
        Me.txt出荷先CD01.IsError = False
        Me.txt出荷先CD01.Location = New System.Drawing.Point(11, 26)
        Me.txt出荷先CD01.Name = "txt出荷先CD01"
        Me.txt出荷先CD01.Required = False
        Me.txt出荷先CD01.Size = New System.Drawing.Size(32, 23)
        Me.txt出荷先CD01.TabIndex = 0
        Me.txt出荷先CD01.Text = "XXX"
        Me.txt出荷先CD01.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt出荷先名04
        '
        Me.txt出荷先名04.FieldLockType = BaseContents.Field.LockType.None
        Me.txt出荷先名04.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt出荷先名04.HelpKeys = ""
        Me.txt出荷先名04.HelpLink = ""
        Me.txt出荷先名04.HelpType = NodeUI.Help.Type.None
        Me.txt出荷先名04.IsError = False
        Me.txt出荷先名04.Location = New System.Drawing.Point(43, 94)
        Me.txt出荷先名04.Name = "txt出荷先名04"
        Me.txt出荷先名04.Required = False
        Me.txt出荷先名04.Size = New System.Drawing.Size(270, 23)
        Me.txt出荷先名04.TabIndex = 7
        Me.txt出荷先名04.Text = "*XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX*"
        Me.txt出荷先名04.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt出荷先名03
        '
        Me.txt出荷先名03.FieldLockType = BaseContents.Field.LockType.None
        Me.txt出荷先名03.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt出荷先名03.HelpKeys = ""
        Me.txt出荷先名03.HelpLink = ""
        Me.txt出荷先名03.HelpType = NodeUI.Help.Type.None
        Me.txt出荷先名03.IsError = False
        Me.txt出荷先名03.Location = New System.Drawing.Point(43, 72)
        Me.txt出荷先名03.Name = "txt出荷先名03"
        Me.txt出荷先名03.Required = False
        Me.txt出荷先名03.Size = New System.Drawing.Size(270, 23)
        Me.txt出荷先名03.TabIndex = 5
        Me.txt出荷先名03.Text = "*XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX*"
        Me.txt出荷先名03.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt出荷先名02
        '
        Me.txt出荷先名02.FieldLockType = BaseContents.Field.LockType.None
        Me.txt出荷先名02.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt出荷先名02.HelpKeys = ""
        Me.txt出荷先名02.HelpLink = ""
        Me.txt出荷先名02.HelpType = NodeUI.Help.Type.None
        Me.txt出荷先名02.IsError = False
        Me.txt出荷先名02.Location = New System.Drawing.Point(43, 49)
        Me.txt出荷先名02.Name = "txt出荷先名02"
        Me.txt出荷先名02.Required = False
        Me.txt出荷先名02.Size = New System.Drawing.Size(270, 23)
        Me.txt出荷先名02.TabIndex = 3
        Me.txt出荷先名02.Text = "*XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX*"
        Me.txt出荷先名02.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt出荷先名01
        '
        Me.txt出荷先名01.FieldLockType = BaseContents.Field.LockType.None
        Me.txt出荷先名01.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt出荷先名01.HelpKeys = ""
        Me.txt出荷先名01.HelpLink = ""
        Me.txt出荷先名01.HelpType = NodeUI.Help.Type.None
        Me.txt出荷先名01.IsError = False
        Me.txt出荷先名01.Location = New System.Drawing.Point(43, 26)
        Me.txt出荷先名01.Name = "txt出荷先名01"
        Me.txt出荷先名01.Required = False
        Me.txt出荷先名01.Size = New System.Drawing.Size(270, 23)
        Me.txt出荷先名01.TabIndex = 1
        Me.txt出荷先名01.Text = "*XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX*"
        Me.txt出荷先名01.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp納品日付A
        '
        Me.grp納品日付A.Controls.Add(Me.txt納品日付A)
        Me.grp納品日付A.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp納品日付A.Location = New System.Drawing.Point(135, 69)
        Me.grp納品日付A.Name = "grp納品日付A"
        Me.grp納品日付A.Size = New System.Drawing.Size(120, 54)
        Me.grp納品日付A.TabIndex = 7
        Me.grp納品日付A.TabStop = False
        Me.grp納品日付A.Text = "A納期年月日"
        '
        'txt納品日付A
        '
        Me.txt納品日付A.FieldLockType = BaseContents.Field.LockType.None
        Me.txt納品日付A.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt納品日付A.HelpKeys = ""
        Me.txt納品日付A.HelpLink = ""
        Me.txt納品日付A.HelpType = NodeUI.Help.Type.None
        Me.txt納品日付A.IsError = False
        Me.txt納品日付A.Location = New System.Drawing.Point(9, 21)
        Me.txt納品日付A.Name = "txt納品日付A"
        Me.txt納品日付A.Required = False
        Me.txt納品日付A.Size = New System.Drawing.Size(90, 23)
        Me.txt納品日付A.TabIndex = 0
        Me.txt納品日付A.Text = "YYYY/MM/DD"
        Me.txt納品日付A.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp入力担当CD
        '
        Me.grp入力担当CD.Controls.Add(Me.nam入力担当名)
        Me.grp入力担当CD.Controls.Add(Me.txt入力担当CD)
        Me.grp入力担当CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp入力担当CD.Location = New System.Drawing.Point(470, 69)
        Me.grp入力担当CD.Name = "grp入力担当CD"
        Me.grp入力担当CD.Size = New System.Drawing.Size(200, 54)
        Me.grp入力担当CD.TabIndex = 9
        Me.grp入力担当CD.TabStop = False
        Me.grp入力担当CD.Text = "入力担当ｺｰﾄﾞ"
        '
        'nam入力担当名
        '
        Me.nam入力担当名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam入力担当名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam入力担当名.Location = New System.Drawing.Point(44, 21)
        Me.nam入力担当名.Name = "nam入力担当名"
        Me.nam入力担当名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam入力担当名.Size = New System.Drawing.Size(140, 23)
        Me.nam入力担当名.StringLength = 0
        Me.nam入力担当名.TabIndex = 1
        Me.nam入力担当名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt入力担当CD
        '
        Me.txt入力担当CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt入力担当CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt入力担当CD.HelpKeys = ""
        Me.txt入力担当CD.HelpLink = ""
        Me.txt入力担当CD.HelpType = NodeUI.Help.Type.None
        Me.txt入力担当CD.IsError = False
        Me.txt入力担当CD.Location = New System.Drawing.Point(9, 21)
        Me.txt入力担当CD.Name = "txt入力担当CD"
        Me.txt入力担当CD.Required = False
        Me.txt入力担当CD.Size = New System.Drawing.Size(35, 23)
        Me.txt入力担当CD.TabIndex = 0
        Me.txt入力担当CD.Text = "XXX"
        Me.txt入力担当CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp顧客商品CD
        '
        Me.grp顧客商品CD.Controls.Add(Me.txt顧客商品CD)
        Me.grp顧客商品CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp顧客商品CD.Location = New System.Drawing.Point(314, 188)
        Me.grp顧客商品CD.Name = "grp顧客商品CD"
        Me.grp顧客商品CD.Size = New System.Drawing.Size(170, 54)
        Me.grp顧客商品CD.TabIndex = 13
        Me.grp顧客商品CD.TabStop = False
        Me.grp顧客商品CD.Text = "顧客商品ｺｰﾄﾞ"
        '
        'txt顧客商品CD
        '
        Me.txt顧客商品CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt顧客商品CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt顧客商品CD.HelpKeys = ""
        Me.txt顧客商品CD.HelpLink = ""
        Me.txt顧客商品CD.HelpType = NodeUI.Help.Type.None
        Me.txt顧客商品CD.IsError = False
        Me.txt顧客商品CD.Location = New System.Drawing.Point(9, 21)
        Me.txt顧客商品CD.Name = "txt顧客商品CD"
        Me.txt顧客商品CD.Required = False
        Me.txt顧客商品CD.Size = New System.Drawing.Size(150, 23)
        Me.txt顧客商品CD.TabIndex = 0
        Me.txt顧客商品CD.Text = "XXXXXXXXXXXXXXXXX"
        Me.txt顧客商品CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'btn商品内訳
        '
        Me.btn商品内訳.FieldLockType = BaseContents.Field.LockType.None
        Me.btn商品内訳.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.btn商品内訳.Location = New System.Drawing.Point(495, 194)
        Me.btn商品内訳.Name = "btn商品内訳"
        Me.btn商品内訳.Size = New System.Drawing.Size(208, 48)
        Me.btn商品内訳.TabIndex = 14
        Me.btn商品内訳.Text = "商品内訳画面へ進む"
        Me.btn商品内訳.UseVisualStyleBackColor = True
        '
        'txt通数3
        '
        Me.txt通数3.FieldLockType = BaseContents.Field.LockType.None
        Me.txt通数3.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt通数3.HelpKeys = ""
        Me.txt通数3.HelpLink = ""
        Me.txt通数3.HelpType = NodeUI.Help.Type.None
        Me.txt通数3.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt通数3.IsError = False
        Me.txt通数3.Location = New System.Drawing.Point(519, 277)
        Me.txt通数3.Name = "txt通数3"
        Me.txt通数3.Required = False
        Me.txt通数3.Size = New System.Drawing.Size(95, 23)
        Me.txt通数3.TabIndex = 29
        Me.txt通数3.Text = "123,456,789"
        Me.txt通数3.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam通数3
        '
        Me.nam通数3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam通数3.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam通数3.Location = New System.Drawing.Point(519, 251)
        Me.nam通数3.Name = "nam通数3"
        Me.nam通数3.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam通数3.Size = New System.Drawing.Size(95, 23)
        Me.nam通数3.StringLength = 0
        Me.nam通数3.TabIndex = 23
        Me.nam通数3.Text = "通  数 3"
        Me.nam通数3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam通数3.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam通数2
        '
        Me.nam通数2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam通数2.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam通数2.Location = New System.Drawing.Point(412, 251)
        Me.nam通数2.Name = "nam通数2"
        Me.nam通数2.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam通数2.Size = New System.Drawing.Size(106, 23)
        Me.nam通数2.StringLength = 0
        Me.nam通数2.TabIndex = 22
        Me.nam通数2.Text = "通  数 2"
        Me.nam通数2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam通数2.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt通数2
        '
        Me.txt通数2.FieldLockType = BaseContents.Field.LockType.None
        Me.txt通数2.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt通数2.HelpKeys = ""
        Me.txt通数2.HelpLink = ""
        Me.txt通数2.HelpType = NodeUI.Help.Type.None
        Me.txt通数2.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt通数2.IsError = False
        Me.txt通数2.Location = New System.Drawing.Point(412, 277)
        Me.txt通数2.Name = "txt通数2"
        Me.txt通数2.Required = False
        Me.txt通数2.Size = New System.Drawing.Size(106, 23)
        Me.txt通数2.TabIndex = 28
        Me.txt通数2.Text = "1,234,567.89"
        Me.txt通数2.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt通数1
        '
        Me.txt通数1.FieldLockType = BaseContents.Field.LockType.None
        Me.txt通数1.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt通数1.HelpKeys = ""
        Me.txt通数1.HelpLink = ""
        Me.txt通数1.HelpType = NodeUI.Help.Type.None
        Me.txt通数1.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt通数1.IsError = False
        Me.txt通数1.Location = New System.Drawing.Point(315, 277)
        Me.txt通数1.Name = "txt通数1"
        Me.txt通数1.Required = False
        Me.txt通数1.Size = New System.Drawing.Size(95, 23)
        Me.txt通数1.TabIndex = 27
        Me.txt通数1.Text = "123,456,789"
        Me.txt通数1.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam通数1
        '
        Me.nam通数1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam通数1.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam通数1.Location = New System.Drawing.Point(315, 251)
        Me.nam通数1.Name = "nam通数1"
        Me.nam通数1.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam通数1.Size = New System.Drawing.Size(95, 23)
        Me.nam通数1.StringLength = 0
        Me.nam通数1.TabIndex = 21
        Me.nam通数1.Text = "通  数 1"
        Me.nam通数1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam通数1.TextStyle = BaseContents.TextBox.TextStyle.None
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
        Me.txt受注単価.Location = New System.Drawing.Point(616, 277)
        Me.txt受注単価.Name = "txt受注単価"
        Me.txt受注単価.Required = False
        Me.txt受注単価.Size = New System.Drawing.Size(95, 23)
        Me.txt受注単価.TabIndex = 30
        Me.txt受注単価.Text = "123,456,789"
        Me.txt受注単価.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam受注単位
        '
        Me.nam受注単位.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam受注単位.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam受注単位.Location = New System.Drawing.Point(616, 251)
        Me.nam受注単位.Name = "nam受注単位"
        Me.nam受注単位.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam受注単位.Size = New System.Drawing.Size(95, 23)
        Me.nam受注単位.StringLength = 0
        Me.nam受注単位.TabIndex = 24
        Me.nam受注単位.Text = "受注単価"
        Me.nam受注単位.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam受注単位.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'ddl単位区分
        '
        Me.ddl単位区分.AutoDropDown = True
        Me.ddl単位区分.DisplayMember = "Display"
        Me.ddl単位区分.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddl単位区分.FieldLockType = BaseContents.Field.LockType.None
        Me.ddl単位区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.ddl単位区分.FormattingEnabled = True
        Me.ddl単位区分.IsError = False
        Me.ddl単位区分.ListType = NodeUI.List.Type.None
        Me.ddl単位区分.Location = New System.Drawing.Point(712, 276)
        Me.ddl単位区分.Name = "ddl単位区分"
        Me.ddl単位区分.Required = False
        Me.ddl単位区分.Size = New System.Drawing.Size(75, 24)
        Me.ddl単位区分.TabIndex = 31
        Me.ddl単位区分.ValueMember = "Value"
        '
        'nam単位区分
        '
        Me.nam単位区分.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam単位区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam単位区分.Location = New System.Drawing.Point(712, 251)
        Me.nam単位区分.Name = "nam単位区分"
        Me.nam単位区分.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam単位区分.Size = New System.Drawing.Size(75, 23)
        Me.nam単位区分.StringLength = 0
        Me.nam単位区分.TabIndex = 25
        Me.nam単位区分.Text = "単位"
        Me.nam単位区分.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam単位区分.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt受注金額
        '
        Me.txt受注金額.FieldLockType = BaseContents.Field.LockType.None
        Me.txt受注金額.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt受注金額.HelpKeys = ""
        Me.txt受注金額.HelpLink = ""
        Me.txt受注金額.HelpType = NodeUI.Help.Type.None
        Me.txt受注金額.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt受注金額.IsError = False
        Me.txt受注金額.Location = New System.Drawing.Point(789, 277)
        Me.txt受注金額.Name = "txt受注金額"
        Me.txt受注金額.Required = False
        Me.txt受注金額.Size = New System.Drawing.Size(95, 23)
        Me.txt受注金額.TabIndex = 32
        Me.txt受注金額.Text = "123,456,789"
        Me.txt受注金額.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam受注金額
        '
        Me.nam受注金額.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam受注金額.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam受注金額.Location = New System.Drawing.Point(789, 251)
        Me.nam受注金額.Name = "nam受注金額"
        Me.nam受注金額.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam受注金額.Size = New System.Drawing.Size(95, 23)
        Me.nam受注金額.StringLength = 0
        Me.nam受注金額.TabIndex = 26
        Me.nam受注金額.Text = "受注金額"
        Me.nam受注金額.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam受注金額.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp刃型NO
        '
        Me.grp刃型NO.Controls.Add(Me.txt刃型NO)
        Me.grp刃型NO.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp刃型NO.Location = New System.Drawing.Point(278, 306)
        Me.grp刃型NO.Name = "grp刃型NO"
        Me.grp刃型NO.Size = New System.Drawing.Size(85, 54)
        Me.grp刃型NO.TabIndex = 35
        Me.grp刃型NO.TabStop = False
        Me.grp刃型NO.Text = "刃型NO"
        '
        'txt刃型NO
        '
        Me.txt刃型NO.FieldLockType = BaseContents.Field.LockType.None
        Me.txt刃型NO.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt刃型NO.HelpKeys = ""
        Me.txt刃型NO.HelpLink = ""
        Me.txt刃型NO.HelpType = NodeUI.Help.Type.None
        Me.txt刃型NO.IsError = False
        Me.txt刃型NO.Location = New System.Drawing.Point(10, 21)
        Me.txt刃型NO.Name = "txt刃型NO"
        Me.txt刃型NO.Required = False
        Me.txt刃型NO.Size = New System.Drawing.Size(65, 23)
        Me.txt刃型NO.TabIndex = 0
        Me.txt刃型NO.Text = "XXXXXXX"
        Me.txt刃型NO.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp版NO
        '
        Me.grp版NO.Controls.Add(Me.txt版NO)
        Me.grp版NO.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp版NO.Location = New System.Drawing.Point(369, 306)
        Me.grp版NO.Name = "grp版NO"
        Me.grp版NO.Size = New System.Drawing.Size(80, 54)
        Me.grp版NO.TabIndex = 36
        Me.grp版NO.TabStop = False
        Me.grp版NO.Text = "版NO"
        '
        'txt版NO
        '
        Me.txt版NO.FieldLockType = BaseContents.Field.LockType.None
        Me.txt版NO.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt版NO.HelpKeys = ""
        Me.txt版NO.HelpLink = ""
        Me.txt版NO.HelpType = NodeUI.Help.Type.None
        Me.txt版NO.IsError = False
        Me.txt版NO.Location = New System.Drawing.Point(10, 21)
        Me.txt版NO.Name = "txt版NO"
        Me.txt版NO.Required = False
        Me.txt版NO.Size = New System.Drawing.Size(60, 23)
        Me.txt版NO.TabIndex = 0
        Me.txt版NO.Text = "XXXXXX"
        Me.txt版NO.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txtギヤ数
        '
        Me.txtギヤ数.FieldLockType = BaseContents.Field.LockType.None
        Me.txtギヤ数.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txtギヤ数.HelpKeys = ""
        Me.txtギヤ数.HelpLink = ""
        Me.txtギヤ数.HelpType = NodeUI.Help.Type.None
        Me.txtギヤ数.IsError = False
        Me.txtギヤ数.Location = New System.Drawing.Point(10, 21)
        Me.txtギヤ数.Name = "txtギヤ数"
        Me.txtギヤ数.Required = False
        Me.txtギヤ数.Size = New System.Drawing.Size(34, 23)
        Me.txtギヤ数.TabIndex = 0
        Me.txtギヤ数.Text = "123"
        Me.txtギヤ数.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtギヤ数.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grpｷﾞｱ数
        '
        Me.grpｷﾞｱ数.Controls.Add(Me.lblファイ)
        Me.grpｷﾞｱ数.Controls.Add(Me.txtギヤ数)
        Me.grpｷﾞｱ数.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grpｷﾞｱ数.Location = New System.Drawing.Point(456, 306)
        Me.grpｷﾞｱ数.Name = "grpｷﾞｱ数"
        Me.grpｷﾞｱ数.Size = New System.Drawing.Size(70, 54)
        Me.grpｷﾞｱ数.TabIndex = 37
        Me.grpｷﾞｱ数.TabStop = False
        Me.grpｷﾞｱ数.Text = "ｷﾞｱ数"
        '
        'lblファイ
        '
        Me.lblファイ.AutoSize = True
        Me.lblファイ.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.lblファイ.Location = New System.Drawing.Point(47, 25)
        Me.lblファイ.Name = "lblファイ"
        Me.lblファイ.Size = New System.Drawing.Size(21, 14)
        Me.lblファイ.TabIndex = 14
        Me.lblファイ.Text = "φ"
        '
        'grp発送仕上特記事項
        '
        Me.grp発送仕上特記事項.Controls.Add(Me.txt発送仕上特記事項)
        Me.grp発送仕上特記事項.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp発送仕上特記事項.Location = New System.Drawing.Point(532, 304)
        Me.grp発送仕上特記事項.Name = "grp発送仕上特記事項"
        Me.grp発送仕上特記事項.Size = New System.Drawing.Size(480, 56)
        Me.grp発送仕上特記事項.TabIndex = 38
        Me.grp発送仕上特記事項.TabStop = False
        Me.grp発送仕上特記事項.Text = "発送・仕上予定表｢特記事項｣"
        '
        'txt発送仕上特記事項
        '
        Me.txt発送仕上特記事項.FieldLockType = BaseContents.Field.LockType.None
        Me.txt発送仕上特記事項.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt発送仕上特記事項.HelpKeys = ""
        Me.txt発送仕上特記事項.HelpLink = ""
        Me.txt発送仕上特記事項.HelpType = NodeUI.Help.Type.None
        Me.txt発送仕上特記事項.IsError = False
        Me.txt発送仕上特記事項.Location = New System.Drawing.Point(9, 22)
        Me.txt発送仕上特記事項.Name = "txt発送仕上特記事項"
        Me.txt発送仕上特記事項.Required = False
        Me.txt発送仕上特記事項.Size = New System.Drawing.Size(460, 23)
        Me.txt発送仕上特記事項.TabIndex = 0
        Me.txt発送仕上特記事項.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.txt発送仕上特記事項.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp出荷注意
        '
        Me.grp出荷注意.Controls.Add(Me.txt出荷注意10)
        Me.grp出荷注意.Controls.Add(Me.txt出荷注意09)
        Me.grp出荷注意.Controls.Add(Me.txt出荷注意08)
        Me.grp出荷注意.Controls.Add(Me.txt出荷注意07)
        Me.grp出荷注意.Controls.Add(Me.txt出荷注意06)
        Me.grp出荷注意.Controls.Add(Me.txt出荷注意05)
        Me.grp出荷注意.Controls.Add(Me.txt出荷注意04)
        Me.grp出荷注意.Controls.Add(Me.txt出荷注意03)
        Me.grp出荷注意.Controls.Add(Me.txt出荷注意02)
        Me.grp出荷注意.Controls.Add(Me.txt出荷注意01)
        Me.grp出荷注意.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp出荷注意.Location = New System.Drawing.Point(369, 379)
        Me.grp出荷注意.Name = "grp出荷注意"
        Me.grp出荷注意.Size = New System.Drawing.Size(195, 265)
        Me.grp出荷注意.TabIndex = 40
        Me.grp出荷注意.TabStop = False
        Me.grp出荷注意.Text = "【出荷時の注意事項】"
        '
        'txt出荷注意10
        '
        Me.txt出荷注意10.FieldLockType = BaseContents.Field.LockType.None
        Me.txt出荷注意10.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt出荷注意10.ForeColor = System.Drawing.Color.Red
        Me.txt出荷注意10.HelpKeys = ""
        Me.txt出荷注意10.HelpLink = ""
        Me.txt出荷注意10.HelpType = NodeUI.Help.Type.None
        Me.txt出荷注意10.IsError = False
        Me.txt出荷注意10.Location = New System.Drawing.Point(10, 230)
        Me.txt出荷注意10.Name = "txt出荷注意10"
        Me.txt出荷注意10.Required = False
        Me.txt出荷注意10.Size = New System.Drawing.Size(175, 23)
        Me.txt出荷注意10.TabIndex = 9
        Me.txt出荷注意10.Text = "*XXXXXXXXXXXXXXXXXX*"
        Me.txt出荷注意10.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt出荷注意09
        '
        Me.txt出荷注意09.FieldLockType = BaseContents.Field.LockType.None
        Me.txt出荷注意09.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt出荷注意09.ForeColor = System.Drawing.Color.Red
        Me.txt出荷注意09.HelpKeys = ""
        Me.txt出荷注意09.HelpLink = ""
        Me.txt出荷注意09.HelpType = NodeUI.Help.Type.None
        Me.txt出荷注意09.IsError = False
        Me.txt出荷注意09.Location = New System.Drawing.Point(10, 207)
        Me.txt出荷注意09.Name = "txt出荷注意09"
        Me.txt出荷注意09.Required = False
        Me.txt出荷注意09.Size = New System.Drawing.Size(175, 23)
        Me.txt出荷注意09.TabIndex = 8
        Me.txt出荷注意09.Text = "*XXXXXXXXXXXXXXXXXX*"
        Me.txt出荷注意09.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt出荷注意08
        '
        Me.txt出荷注意08.FieldLockType = BaseContents.Field.LockType.None
        Me.txt出荷注意08.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt出荷注意08.ForeColor = System.Drawing.Color.Red
        Me.txt出荷注意08.HelpKeys = ""
        Me.txt出荷注意08.HelpLink = ""
        Me.txt出荷注意08.HelpType = NodeUI.Help.Type.None
        Me.txt出荷注意08.IsError = False
        Me.txt出荷注意08.Location = New System.Drawing.Point(10, 185)
        Me.txt出荷注意08.Name = "txt出荷注意08"
        Me.txt出荷注意08.Required = False
        Me.txt出荷注意08.Size = New System.Drawing.Size(175, 23)
        Me.txt出荷注意08.TabIndex = 7
        Me.txt出荷注意08.Text = "*XXXXXXXXXXXXXXXXXX*"
        Me.txt出荷注意08.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt出荷注意07
        '
        Me.txt出荷注意07.FieldLockType = BaseContents.Field.LockType.None
        Me.txt出荷注意07.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt出荷注意07.ForeColor = System.Drawing.Color.Red
        Me.txt出荷注意07.HelpKeys = ""
        Me.txt出荷注意07.HelpLink = ""
        Me.txt出荷注意07.HelpType = NodeUI.Help.Type.None
        Me.txt出荷注意07.IsError = False
        Me.txt出荷注意07.Location = New System.Drawing.Point(10, 162)
        Me.txt出荷注意07.Name = "txt出荷注意07"
        Me.txt出荷注意07.Required = False
        Me.txt出荷注意07.Size = New System.Drawing.Size(175, 23)
        Me.txt出荷注意07.TabIndex = 6
        Me.txt出荷注意07.Text = "*XXXXXXXXXXXXXXXXXX*"
        Me.txt出荷注意07.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt出荷注意06
        '
        Me.txt出荷注意06.FieldLockType = BaseContents.Field.LockType.None
        Me.txt出荷注意06.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt出荷注意06.ForeColor = System.Drawing.Color.Red
        Me.txt出荷注意06.HelpKeys = ""
        Me.txt出荷注意06.HelpLink = ""
        Me.txt出荷注意06.HelpType = NodeUI.Help.Type.None
        Me.txt出荷注意06.IsError = False
        Me.txt出荷注意06.Location = New System.Drawing.Point(10, 139)
        Me.txt出荷注意06.Name = "txt出荷注意06"
        Me.txt出荷注意06.Required = False
        Me.txt出荷注意06.Size = New System.Drawing.Size(175, 23)
        Me.txt出荷注意06.TabIndex = 5
        Me.txt出荷注意06.Text = "*XXXXXXXXXXXXXXXXXX*"
        Me.txt出荷注意06.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt出荷注意05
        '
        Me.txt出荷注意05.FieldLockType = BaseContents.Field.LockType.None
        Me.txt出荷注意05.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt出荷注意05.ForeColor = System.Drawing.Color.Red
        Me.txt出荷注意05.HelpKeys = ""
        Me.txt出荷注意05.HelpLink = ""
        Me.txt出荷注意05.HelpType = NodeUI.Help.Type.None
        Me.txt出荷注意05.IsError = False
        Me.txt出荷注意05.Location = New System.Drawing.Point(10, 117)
        Me.txt出荷注意05.Name = "txt出荷注意05"
        Me.txt出荷注意05.Required = False
        Me.txt出荷注意05.Size = New System.Drawing.Size(175, 23)
        Me.txt出荷注意05.TabIndex = 4
        Me.txt出荷注意05.Text = "*XXXXXXXXXXXXXXXXXX*"
        Me.txt出荷注意05.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt出荷注意04
        '
        Me.txt出荷注意04.FieldLockType = BaseContents.Field.LockType.None
        Me.txt出荷注意04.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt出荷注意04.ForeColor = System.Drawing.Color.Red
        Me.txt出荷注意04.HelpKeys = ""
        Me.txt出荷注意04.HelpLink = ""
        Me.txt出荷注意04.HelpType = NodeUI.Help.Type.None
        Me.txt出荷注意04.IsError = False
        Me.txt出荷注意04.Location = New System.Drawing.Point(10, 94)
        Me.txt出荷注意04.Name = "txt出荷注意04"
        Me.txt出荷注意04.Required = False
        Me.txt出荷注意04.Size = New System.Drawing.Size(175, 23)
        Me.txt出荷注意04.TabIndex = 3
        Me.txt出荷注意04.Text = "*XXXXXXXXXXXXXXXXXX*"
        Me.txt出荷注意04.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt出荷注意03
        '
        Me.txt出荷注意03.FieldLockType = BaseContents.Field.LockType.None
        Me.txt出荷注意03.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt出荷注意03.ForeColor = System.Drawing.Color.Red
        Me.txt出荷注意03.HelpKeys = ""
        Me.txt出荷注意03.HelpLink = ""
        Me.txt出荷注意03.HelpType = NodeUI.Help.Type.None
        Me.txt出荷注意03.IsError = False
        Me.txt出荷注意03.Location = New System.Drawing.Point(10, 72)
        Me.txt出荷注意03.Name = "txt出荷注意03"
        Me.txt出荷注意03.Required = False
        Me.txt出荷注意03.Size = New System.Drawing.Size(175, 23)
        Me.txt出荷注意03.TabIndex = 2
        Me.txt出荷注意03.Text = "*XXXXXXXXXXXXXXXXXX*"
        Me.txt出荷注意03.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt出荷注意02
        '
        Me.txt出荷注意02.FieldLockType = BaseContents.Field.LockType.None
        Me.txt出荷注意02.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt出荷注意02.ForeColor = System.Drawing.Color.Red
        Me.txt出荷注意02.HelpKeys = ""
        Me.txt出荷注意02.HelpLink = ""
        Me.txt出荷注意02.HelpType = NodeUI.Help.Type.None
        Me.txt出荷注意02.IsError = False
        Me.txt出荷注意02.Location = New System.Drawing.Point(10, 49)
        Me.txt出荷注意02.Name = "txt出荷注意02"
        Me.txt出荷注意02.Required = False
        Me.txt出荷注意02.Size = New System.Drawing.Size(175, 23)
        Me.txt出荷注意02.TabIndex = 1
        Me.txt出荷注意02.Text = "*XXXXXXXXXXXXXXXXXX*"
        Me.txt出荷注意02.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt出荷注意01
        '
        Me.txt出荷注意01.FieldLockType = BaseContents.Field.LockType.None
        Me.txt出荷注意01.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt出荷注意01.ForeColor = System.Drawing.Color.Red
        Me.txt出荷注意01.HelpKeys = ""
        Me.txt出荷注意01.HelpLink = ""
        Me.txt出荷注意01.HelpType = NodeUI.Help.Type.None
        Me.txt出荷注意01.IsError = False
        Me.txt出荷注意01.Location = New System.Drawing.Point(10, 26)
        Me.txt出荷注意01.Name = "txt出荷注意01"
        Me.txt出荷注意01.Required = False
        Me.txt出荷注意01.Size = New System.Drawing.Size(175, 23)
        Me.txt出荷注意01.TabIndex = 0
        Me.txt出荷注意01.Text = "*XXXXXXXXXXXXXXXXXX*"
        Me.txt出荷注意01.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp売上入力指示
        '
        Me.grp売上入力指示.Controls.Add(Me.txt売上金額)
        Me.grp売上入力指示.Controls.Add(Me.ddl売上区分)
        Me.grp売上入力指示.Controls.Add(Me.txt売上名)
        Me.grp売上入力指示.Controls.Add(Me.txt運賃金額)
        Me.grp売上入力指示.Controls.Add(Me.ddl運賃売上区分)
        Me.grp売上入力指示.Controls.Add(Me.txt運賃単価)
        Me.grp売上入力指示.Controls.Add(Me.txt運賃数量)
        Me.grp売上入力指示.Controls.Add(Me.Label6)
        Me.grp売上入力指示.Controls.Add(Me.Label7)
        Me.grp売上入力指示.Controls.Add(Me.txt版下金額)
        Me.grp売上入力指示.Controls.Add(Me.ddl版下売上区分)
        Me.grp売上入力指示.Controls.Add(Me.txt版下単価)
        Me.grp売上入力指示.Controls.Add(Me.txt版下数量)
        Me.grp売上入力指示.Controls.Add(Me.Label4)
        Me.grp売上入力指示.Controls.Add(Me.Label5)
        Me.grp売上入力指示.Controls.Add(Me.txt刃型金額)
        Me.grp売上入力指示.Controls.Add(Me.ddl刃型売上区分)
        Me.grp売上入力指示.Controls.Add(Me.txt刃型単価)
        Me.grp売上入力指示.Controls.Add(Me.txt刃型数量)
        Me.grp売上入力指示.Controls.Add(Me.Label2)
        Me.grp売上入力指示.Controls.Add(Me.Label3)
        Me.grp売上入力指示.Controls.Add(Me.txt版代金額)
        Me.grp売上入力指示.Controls.Add(Me.nam運賃)
        Me.grp売上入力指示.Controls.Add(Me.nam版下代)
        Me.grp売上入力指示.Controls.Add(Me.nam刃型代)
        Me.grp売上入力指示.Controls.Add(Me.nam版代)
        Me.grp売上入力指示.Controls.Add(Me.ddl版代売上区分)
        Me.grp売上入力指示.Controls.Add(Me.txt版代単価)
        Me.grp売上入力指示.Controls.Add(Me.txt版代数量)
        Me.grp売上入力指示.Controls.Add(Me.Label1)
        Me.grp売上入力指示.Controls.Add(Me.lbl刃型サイズ一面角単位)
        Me.grp売上入力指示.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp売上入力指示.Location = New System.Drawing.Point(569, 366)
        Me.grp売上入力指示.Name = "grp売上入力指示"
        Me.grp売上入力指示.Size = New System.Drawing.Size(442, 143)
        Me.grp売上入力指示.TabIndex = 41
        Me.grp売上入力指示.TabStop = False
        Me.grp売上入力指示.Text = "【売上入力時の指示】"
        '
        'txt売上金額
        '
        Me.txt売上金額.FieldLockType = BaseContents.Field.LockType.None
        Me.txt売上金額.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt売上金額.HelpKeys = ""
        Me.txt売上金額.HelpLink = ""
        Me.txt売上金額.HelpType = NodeUI.Help.Type.None
        Me.txt売上金額.IsError = False
        Me.txt売上金額.Location = New System.Drawing.Point(81, 115)
        Me.txt売上金額.Name = "txt売上金額"
        Me.txt売上金額.Required = False
        Me.txt売上金額.Size = New System.Drawing.Size(100, 23)
        Me.txt売上金額.TabIndex = 17
        Me.txt売上金額.Text = "123,456,789"
        Me.txt売上金額.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt売上金額.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'ddl売上区分
        '
        Me.ddl売上区分.AutoDropDown = True
        Me.ddl売上区分.DisplayMember = "Display"
        Me.ddl売上区分.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddl売上区分.FieldLockType = BaseContents.Field.LockType.None
        Me.ddl売上区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.ddl売上区分.FormattingEnabled = True
        Me.ddl売上区分.IsError = False
        Me.ddl売上区分.ListType = NodeUI.List.Type.None
        Me.ddl売上区分.Location = New System.Drawing.Point(182, 114)
        Me.ddl売上区分.Name = "ddl売上区分"
        Me.ddl売上区分.Required = False
        Me.ddl売上区分.Size = New System.Drawing.Size(95, 24)
        Me.ddl売上区分.TabIndex = 18
        Me.ddl売上区分.ValueMember = "Value"
        '
        'txt売上名
        '
        Me.txt売上名.FieldLockType = BaseContents.Field.LockType.None
        Me.txt売上名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt売上名.HelpKeys = ""
        Me.txt売上名.HelpLink = ""
        Me.txt売上名.HelpType = NodeUI.Help.Type.None
        Me.txt売上名.IsError = False
        Me.txt売上名.Location = New System.Drawing.Point(9, 114)
        Me.txt売上名.Name = "txt売上名"
        Me.txt売上名.Required = False
        Me.txt売上名.Size = New System.Drawing.Size(70, 23)
        Me.txt売上名.TabIndex = 16
        Me.txt売上名.Text = "XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX"
        Me.txt売上名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt運賃金額
        '
        Me.txt運賃金額.FieldLockType = BaseContents.Field.LockType.None
        Me.txt運賃金額.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt運賃金額.HelpKeys = ""
        Me.txt運賃金額.HelpLink = ""
        Me.txt運賃金額.HelpType = NodeUI.Help.Type.None
        Me.txt運賃金額.IsError = False
        Me.txt運賃金額.Location = New System.Drawing.Point(239, 90)
        Me.txt運賃金額.Name = "txt運賃金額"
        Me.txt運賃金額.Required = False
        Me.txt運賃金額.Size = New System.Drawing.Size(100, 23)
        Me.txt運賃金額.TabIndex = 14
        Me.txt運賃金額.Text = "123,456,789"
        Me.txt運賃金額.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt運賃金額.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'ddl運賃売上区分
        '
        Me.ddl運賃売上区分.AutoDropDown = True
        Me.ddl運賃売上区分.DisplayMember = "Display"
        Me.ddl運賃売上区分.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddl運賃売上区分.FieldLockType = BaseContents.Field.LockType.None
        Me.ddl運賃売上区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.ddl運賃売上区分.FormattingEnabled = True
        Me.ddl運賃売上区分.IsError = False
        Me.ddl運賃売上区分.ListType = NodeUI.List.Type.None
        Me.ddl運賃売上区分.Location = New System.Drawing.Point(340, 90)
        Me.ddl運賃売上区分.Name = "ddl運賃売上区分"
        Me.ddl運賃売上区分.Required = False
        Me.ddl運賃売上区分.Size = New System.Drawing.Size(95, 24)
        Me.ddl運賃売上区分.TabIndex = 15
        Me.ddl運賃売上区分.ValueMember = "Value"
        '
        'txt運賃単価
        '
        Me.txt運賃単価.FieldLockType = BaseContents.Field.LockType.None
        Me.txt運賃単価.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt運賃単価.HelpKeys = ""
        Me.txt運賃単価.HelpLink = ""
        Me.txt運賃単価.HelpType = NodeUI.Help.Type.None
        Me.txt運賃単価.IsError = False
        Me.txt運賃単価.Location = New System.Drawing.Point(157, 90)
        Me.txt運賃単価.Name = "txt運賃単価"
        Me.txt運賃単価.Required = False
        Me.txt運賃単価.Size = New System.Drawing.Size(60, 23)
        Me.txt運賃単価.TabIndex = 13
        Me.txt運賃単価.Text = "12,345"
        Me.txt運賃単価.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt運賃単価.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt運賃数量
        '
        Me.txt運賃数量.FieldLockType = BaseContents.Field.LockType.None
        Me.txt運賃数量.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt運賃数量.HelpKeys = ""
        Me.txt運賃数量.HelpLink = ""
        Me.txt運賃数量.HelpType = NodeUI.Help.Type.None
        Me.txt運賃数量.IsError = False
        Me.txt運賃数量.Location = New System.Drawing.Point(81, 90)
        Me.txt運賃数量.Name = "txt運賃数量"
        Me.txt運賃数量.Required = False
        Me.txt運賃数量.Size = New System.Drawing.Size(55, 23)
        Me.txt運賃数量.TabIndex = 12
        Me.txt運賃数量.Text = "1,234"
        Me.txt運賃数量.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt運賃数量.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(217, 93)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(24, 16)
        Me.Label6.TabIndex = 89
        Me.Label6.Text = "＝"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(135, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 16)
        Me.Label7.TabIndex = 88
        Me.Label7.Text = "×"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt版下金額
        '
        Me.txt版下金額.FieldLockType = BaseContents.Field.LockType.None
        Me.txt版下金額.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt版下金額.HelpKeys = ""
        Me.txt版下金額.HelpLink = ""
        Me.txt版下金額.HelpType = NodeUI.Help.Type.None
        Me.txt版下金額.IsError = False
        Me.txt版下金額.Location = New System.Drawing.Point(239, 67)
        Me.txt版下金額.Name = "txt版下金額"
        Me.txt版下金額.Required = False
        Me.txt版下金額.Size = New System.Drawing.Size(100, 23)
        Me.txt版下金額.TabIndex = 10
        Me.txt版下金額.Text = "123,456,789"
        Me.txt版下金額.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt版下金額.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'ddl版下売上区分
        '
        Me.ddl版下売上区分.AutoDropDown = True
        Me.ddl版下売上区分.DisplayMember = "Display"
        Me.ddl版下売上区分.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddl版下売上区分.FieldLockType = BaseContents.Field.LockType.None
        Me.ddl版下売上区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.ddl版下売上区分.FormattingEnabled = True
        Me.ddl版下売上区分.IsError = False
        Me.ddl版下売上区分.ListType = NodeUI.List.Type.None
        Me.ddl版下売上区分.Location = New System.Drawing.Point(340, 67)
        Me.ddl版下売上区分.Name = "ddl版下売上区分"
        Me.ddl版下売上区分.Required = False
        Me.ddl版下売上区分.Size = New System.Drawing.Size(95, 24)
        Me.ddl版下売上区分.TabIndex = 11
        Me.ddl版下売上区分.ValueMember = "Value"
        '
        'txt版下単価
        '
        Me.txt版下単価.FieldLockType = BaseContents.Field.LockType.None
        Me.txt版下単価.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt版下単価.HelpKeys = ""
        Me.txt版下単価.HelpLink = ""
        Me.txt版下単価.HelpType = NodeUI.Help.Type.None
        Me.txt版下単価.IsError = False
        Me.txt版下単価.Location = New System.Drawing.Point(157, 67)
        Me.txt版下単価.Name = "txt版下単価"
        Me.txt版下単価.Required = False
        Me.txt版下単価.Size = New System.Drawing.Size(60, 23)
        Me.txt版下単価.TabIndex = 9
        Me.txt版下単価.Text = "12,345"
        Me.txt版下単価.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt版下単価.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt版下数量
        '
        Me.txt版下数量.FieldLockType = BaseContents.Field.LockType.None
        Me.txt版下数量.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt版下数量.HelpKeys = ""
        Me.txt版下数量.HelpLink = ""
        Me.txt版下数量.HelpType = NodeUI.Help.Type.None
        Me.txt版下数量.IsError = False
        Me.txt版下数量.Location = New System.Drawing.Point(81, 67)
        Me.txt版下数量.Name = "txt版下数量"
        Me.txt版下数量.Required = False
        Me.txt版下数量.Size = New System.Drawing.Size(55, 23)
        Me.txt版下数量.TabIndex = 8
        Me.txt版下数量.Text = "1,234"
        Me.txt版下数量.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt版下数量.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(217, 70)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 16)
        Me.Label4.TabIndex = 83
        Me.Label4.Text = "＝"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(135, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 16)
        Me.Label5.TabIndex = 82
        Me.Label5.Text = "×"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt刃型金額
        '
        Me.txt刃型金額.FieldLockType = BaseContents.Field.LockType.None
        Me.txt刃型金額.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt刃型金額.HelpKeys = ""
        Me.txt刃型金額.HelpLink = ""
        Me.txt刃型金額.HelpType = NodeUI.Help.Type.None
        Me.txt刃型金額.IsError = False
        Me.txt刃型金額.Location = New System.Drawing.Point(239, 44)
        Me.txt刃型金額.Name = "txt刃型金額"
        Me.txt刃型金額.Required = False
        Me.txt刃型金額.Size = New System.Drawing.Size(100, 23)
        Me.txt刃型金額.TabIndex = 6
        Me.txt刃型金額.Text = "123,456,789"
        Me.txt刃型金額.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt刃型金額.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'ddl刃型売上区分
        '
        Me.ddl刃型売上区分.AutoDropDown = True
        Me.ddl刃型売上区分.DisplayMember = "Display"
        Me.ddl刃型売上区分.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddl刃型売上区分.FieldLockType = BaseContents.Field.LockType.None
        Me.ddl刃型売上区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.ddl刃型売上区分.FormattingEnabled = True
        Me.ddl刃型売上区分.IsError = False
        Me.ddl刃型売上区分.ListType = NodeUI.List.Type.None
        Me.ddl刃型売上区分.Location = New System.Drawing.Point(340, 44)
        Me.ddl刃型売上区分.Name = "ddl刃型売上区分"
        Me.ddl刃型売上区分.Required = False
        Me.ddl刃型売上区分.Size = New System.Drawing.Size(95, 24)
        Me.ddl刃型売上区分.TabIndex = 7
        Me.ddl刃型売上区分.ValueMember = "Value"
        '
        'txt刃型単価
        '
        Me.txt刃型単価.FieldLockType = BaseContents.Field.LockType.None
        Me.txt刃型単価.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt刃型単価.HelpKeys = ""
        Me.txt刃型単価.HelpLink = ""
        Me.txt刃型単価.HelpType = NodeUI.Help.Type.None
        Me.txt刃型単価.IsError = False
        Me.txt刃型単価.Location = New System.Drawing.Point(157, 44)
        Me.txt刃型単価.Name = "txt刃型単価"
        Me.txt刃型単価.Required = False
        Me.txt刃型単価.Size = New System.Drawing.Size(60, 23)
        Me.txt刃型単価.TabIndex = 5
        Me.txt刃型単価.Text = "12,345"
        Me.txt刃型単価.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt刃型単価.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt刃型数量
        '
        Me.txt刃型数量.FieldLockType = BaseContents.Field.LockType.None
        Me.txt刃型数量.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt刃型数量.HelpKeys = ""
        Me.txt刃型数量.HelpLink = ""
        Me.txt刃型数量.HelpType = NodeUI.Help.Type.None
        Me.txt刃型数量.IsError = False
        Me.txt刃型数量.Location = New System.Drawing.Point(81, 44)
        Me.txt刃型数量.Name = "txt刃型数量"
        Me.txt刃型数量.Required = False
        Me.txt刃型数量.Size = New System.Drawing.Size(55, 23)
        Me.txt刃型数量.TabIndex = 4
        Me.txt刃型数量.Text = "1,234"
        Me.txt刃型数量.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt刃型数量.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(217, 47)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 16)
        Me.Label2.TabIndex = 77
        Me.Label2.Text = "＝"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(135, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 16)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "×"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'txt版代金額
        '
        Me.txt版代金額.FieldLockType = BaseContents.Field.LockType.None
        Me.txt版代金額.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt版代金額.HelpKeys = ""
        Me.txt版代金額.HelpLink = ""
        Me.txt版代金額.HelpType = NodeUI.Help.Type.None
        Me.txt版代金額.IsError = False
        Me.txt版代金額.Location = New System.Drawing.Point(239, 20)
        Me.txt版代金額.Name = "txt版代金額"
        Me.txt版代金額.Required = False
        Me.txt版代金額.Size = New System.Drawing.Size(100, 23)
        Me.txt版代金額.TabIndex = 2
        Me.txt版代金額.Text = "123,456,789"
        Me.txt版代金額.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt版代金額.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam運賃
        '
        Me.nam運賃.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam運賃.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam運賃.Location = New System.Drawing.Point(9, 90)
        Me.nam運賃.Name = "nam運賃"
        Me.nam運賃.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam運賃.Size = New System.Drawing.Size(70, 23)
        Me.nam運賃.StringLength = 0
        Me.nam運賃.TabIndex = 70
        Me.nam運賃.Text = "運  賃"
        Me.nam運賃.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam運賃.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam版下代
        '
        Me.nam版下代.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam版下代.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam版下代.Location = New System.Drawing.Point(9, 67)
        Me.nam版下代.Name = "nam版下代"
        Me.nam版下代.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam版下代.Size = New System.Drawing.Size(70, 23)
        Me.nam版下代.StringLength = 0
        Me.nam版下代.TabIndex = 69
        Me.nam版下代.Text = "版下代"
        Me.nam版下代.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam版下代.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam刃型代
        '
        Me.nam刃型代.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam刃型代.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam刃型代.Location = New System.Drawing.Point(9, 44)
        Me.nam刃型代.Name = "nam刃型代"
        Me.nam刃型代.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam刃型代.Size = New System.Drawing.Size(70, 23)
        Me.nam刃型代.StringLength = 0
        Me.nam刃型代.TabIndex = 68
        Me.nam刃型代.Text = "刃型代"
        Me.nam刃型代.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam刃型代.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam版代
        '
        Me.nam版代.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam版代.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam版代.Location = New System.Drawing.Point(9, 20)
        Me.nam版代.Name = "nam版代"
        Me.nam版代.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam版代.Size = New System.Drawing.Size(70, 23)
        Me.nam版代.StringLength = 0
        Me.nam版代.TabIndex = 67
        Me.nam版代.Text = "版  代"
        Me.nam版代.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam版代.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'ddl版代売上区分
        '
        Me.ddl版代売上区分.AutoDropDown = True
        Me.ddl版代売上区分.DisplayMember = "Display"
        Me.ddl版代売上区分.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddl版代売上区分.FieldLockType = BaseContents.Field.LockType.None
        Me.ddl版代売上区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.ddl版代売上区分.FormattingEnabled = True
        Me.ddl版代売上区分.IsError = False
        Me.ddl版代売上区分.ListType = NodeUI.List.Type.None
        Me.ddl版代売上区分.Location = New System.Drawing.Point(340, 20)
        Me.ddl版代売上区分.Name = "ddl版代売上区分"
        Me.ddl版代売上区分.Required = False
        Me.ddl版代売上区分.Size = New System.Drawing.Size(95, 24)
        Me.ddl版代売上区分.TabIndex = 3
        Me.ddl版代売上区分.ValueMember = "Value"
        '
        'txt版代単価
        '
        Me.txt版代単価.FieldLockType = BaseContents.Field.LockType.None
        Me.txt版代単価.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt版代単価.HelpKeys = ""
        Me.txt版代単価.HelpLink = ""
        Me.txt版代単価.HelpType = NodeUI.Help.Type.None
        Me.txt版代単価.IsError = False
        Me.txt版代単価.Location = New System.Drawing.Point(157, 20)
        Me.txt版代単価.Name = "txt版代単価"
        Me.txt版代単価.Required = False
        Me.txt版代単価.Size = New System.Drawing.Size(60, 23)
        Me.txt版代単価.TabIndex = 1
        Me.txt版代単価.Text = "12,345"
        Me.txt版代単価.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt版代単価.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt版代数量
        '
        Me.txt版代数量.FieldLockType = BaseContents.Field.LockType.None
        Me.txt版代数量.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt版代数量.HelpKeys = ""
        Me.txt版代数量.HelpLink = ""
        Me.txt版代数量.HelpType = NodeUI.Help.Type.None
        Me.txt版代数量.IsError = False
        Me.txt版代数量.Location = New System.Drawing.Point(81, 20)
        Me.txt版代数量.Name = "txt版代数量"
        Me.txt版代数量.Required = False
        Me.txt版代数量.Size = New System.Drawing.Size(55, 23)
        Me.txt版代数量.TabIndex = 0
        Me.txt版代数量.Text = "1,234"
        Me.txt版代数量.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt版代数量.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(217, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 16)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "＝"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl刃型サイズ一面角単位
        '
        Me.lbl刃型サイズ一面角単位.AutoSize = True
        Me.lbl刃型サイズ一面角単位.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.lbl刃型サイズ一面角単位.Location = New System.Drawing.Point(135, 23)
        Me.lbl刃型サイズ一面角単位.Name = "lbl刃型サイズ一面角単位"
        Me.lbl刃型サイズ一面角単位.Size = New System.Drawing.Size(24, 16)
        Me.lbl刃型サイズ一面角単位.TabIndex = 21
        Me.lbl刃型サイズ一面角単位.Text = "×"
        Me.lbl刃型サイズ一面角単位.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btn紙発注
        '
        Me.btn紙発注.FieldLockType = BaseContents.Field.LockType.None
        Me.btn紙発注.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.btn紙発注.Location = New System.Drawing.Point(912, 564)
        Me.btn紙発注.Name = "btn紙発注"
        Me.btn紙発注.Size = New System.Drawing.Size(100, 48)
        Me.btn紙発注.TabIndex = 43
        Me.btn紙発注.Text = "紙発注情報画面へ進む"
        Me.btn紙発注.UseVisualStyleBackColor = True
        '
        'nam受注数合計
        '
        Me.nam受注数合計.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam受注数合計.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam受注数合計.Location = New System.Drawing.Point(7, 277)
        Me.nam受注数合計.Name = "nam受注数合計"
        Me.nam受注数合計.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam受注数合計.Size = New System.Drawing.Size(95, 23)
        Me.nam受注数合計.StringLength = 0
        Me.nam受注数合計.TabIndex = 18
        Me.nam受注数合計.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam内在庫引当数合計
        '
        Me.nam内在庫引当数合計.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam内在庫引当数合計.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam内在庫引当数合計.Location = New System.Drawing.Point(104, 277)
        Me.nam内在庫引当数合計.Name = "nam内在庫引当数合計"
        Me.nam内在庫引当数合計.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam内在庫引当数合計.Size = New System.Drawing.Size(95, 23)
        Me.nam内在庫引当数合計.StringLength = 0
        Me.nam内在庫引当数合計.TabIndex = 19
        Me.nam内在庫引当数合計.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam内製造数合計
        '
        Me.nam内製造数合計.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam内製造数合計.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam内製造数合計.Location = New System.Drawing.Point(201, 277)
        Me.nam内製造数合計.Name = "nam内製造数合計"
        Me.nam内製造数合計.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam内製造数合計.Size = New System.Drawing.Size(95, 23)
        Me.nam内製造数合計.StringLength = 0
        Me.nam内製造数合計.TabIndex = 20
        Me.nam内製造数合計.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'frmOrderBase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.nam受注数合計)
        Me.Controls.Add(Me.nam内在庫引当数合計)
        Me.Controls.Add(Me.nam内製造数合計)
        Me.Controls.Add(Me.btn紙発注)
        Me.Controls.Add(Me.grp売上入力指示)
        Me.Controls.Add(Me.grp出荷注意)
        Me.Controls.Add(Me.grp発送仕上特記事項)
        Me.Controls.Add(Me.grpｷﾞｱ数)
        Me.Controls.Add(Me.grp版NO)
        Me.Controls.Add(Me.grp刃型NO)
        Me.Controls.Add(Me.txt受注金額)
        Me.Controls.Add(Me.nam受注金額)
        Me.Controls.Add(Me.nam単位区分)
        Me.Controls.Add(Me.ddl単位区分)
        Me.Controls.Add(Me.txt受注単価)
        Me.Controls.Add(Me.nam受注単位)
        Me.Controls.Add(Me.txt通数3)
        Me.Controls.Add(Me.nam通数3)
        Me.Controls.Add(Me.nam通数2)
        Me.Controls.Add(Me.txt通数2)
        Me.Controls.Add(Me.txt通数1)
        Me.Controls.Add(Me.nam通数1)
        Me.Controls.Add(Me.btn商品内訳)
        Me.Controls.Add(Me.grp顧客商品CD)
        Me.Controls.Add(Me.grp入力担当CD)
        Me.Controls.Add(Me.grp納品日付A)
        Me.Controls.Add(Me.grp出荷先)
        Me.Controls.Add(Me.grp作業注意)
        Me.Controls.Add(Me.nam内製造数合計Title)
        Me.Controls.Add(Me.grp印刷場所)
        Me.Controls.Add(Me.grp受注区分)
        Me.Controls.Add(Me.grp代表商品名)
        Me.Controls.Add(Me.grp請求先CD)
        Me.Controls.Add(Me.grp得意先CD)
        Me.Controls.Add(Me.grp納品日付B)
        Me.Controls.Add(Me.grp積算NO)
        Me.Controls.Add(Me.grp御客様NO)
        Me.Controls.Add(Me.grp受注日付)
        Me.Controls.Add(Me.grp本台帳NO)
        Me.Controls.Add(Me.grp新再版区分)
        Me.Controls.Add(Me.nam内在庫引当数合計Title)
        Me.Controls.Add(Me.nam受注数合計Title)
        Me.Controls.Add(Me.grp作業NO)
        Me.Controls.Add(Me.grp処理区分)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmOrderBase"
        Me.Controls.SetChildIndex(Me.grp処理区分, 0)
        Me.Controls.SetChildIndex(Me.grp作業NO, 0)
        Me.Controls.SetChildIndex(Me.nam受注数合計Title, 0)
        Me.Controls.SetChildIndex(Me.nam内在庫引当数合計Title, 0)
        Me.Controls.SetChildIndex(Me.grp新再版区分, 0)
        Me.Controls.SetChildIndex(Me.grp本台帳NO, 0)
        Me.Controls.SetChildIndex(Me.grp受注日付, 0)
        Me.Controls.SetChildIndex(Me.grp御客様NO, 0)
        Me.Controls.SetChildIndex(Me.grp積算NO, 0)
        Me.Controls.SetChildIndex(Me.grp納品日付B, 0)
        Me.Controls.SetChildIndex(Me.grp得意先CD, 0)
        Me.Controls.SetChildIndex(Me.grp請求先CD, 0)
        Me.Controls.SetChildIndex(Me.grp代表商品名, 0)
        Me.Controls.SetChildIndex(Me.grp受注区分, 0)
        Me.Controls.SetChildIndex(Me.grp印刷場所, 0)
        Me.Controls.SetChildIndex(Me.nam内製造数合計Title, 0)
        Me.Controls.SetChildIndex(Me.grp作業注意, 0)
        Me.Controls.SetChildIndex(Me.grp出荷先, 0)
        Me.Controls.SetChildIndex(Me.grp納品日付A, 0)
        Me.Controls.SetChildIndex(Me.grp入力担当CD, 0)
        Me.Controls.SetChildIndex(Me.grp顧客商品CD, 0)
        Me.Controls.SetChildIndex(Me.btn商品内訳, 0)
        Me.Controls.SetChildIndex(Me.nam通数1, 0)
        Me.Controls.SetChildIndex(Me.txt通数1, 0)
        Me.Controls.SetChildIndex(Me.txt通数2, 0)
        Me.Controls.SetChildIndex(Me.nam通数2, 0)
        Me.Controls.SetChildIndex(Me.nam通数3, 0)
        Me.Controls.SetChildIndex(Me.txt通数3, 0)
        Me.Controls.SetChildIndex(Me.nam受注単位, 0)
        Me.Controls.SetChildIndex(Me.txt受注単価, 0)
        Me.Controls.SetChildIndex(Me.ddl単位区分, 0)
        Me.Controls.SetChildIndex(Me.nam単位区分, 0)
        Me.Controls.SetChildIndex(Me.nam受注金額, 0)
        Me.Controls.SetChildIndex(Me.txt受注金額, 0)
        Me.Controls.SetChildIndex(Me.grp刃型NO, 0)
        Me.Controls.SetChildIndex(Me.grp版NO, 0)
        Me.Controls.SetChildIndex(Me.grpｷﾞｱ数, 0)
        Me.Controls.SetChildIndex(Me.grp発送仕上特記事項, 0)
        Me.Controls.SetChildIndex(Me.grp出荷注意, 0)
        Me.Controls.SetChildIndex(Me.grp売上入力指示, 0)
        Me.Controls.SetChildIndex(Me.btn紙発注, 0)
        Me.Controls.SetChildIndex(Me.nam内製造数合計, 0)
        Me.Controls.SetChildIndex(Me.nam内在庫引当数合計, 0)
        Me.Controls.SetChildIndex(Me.nam受注数合計, 0)
        Me.grp処理区分.ResumeLayout(False)
        Me.grp処理区分.PerformLayout()
        Me.grp作業NO.ResumeLayout(False)
        Me.grp作業NO.PerformLayout()
        Me.grp新再版区分.ResumeLayout(False)
        Me.grp本台帳NO.ResumeLayout(False)
        Me.grp本台帳NO.PerformLayout()
        Me.grp受注日付.ResumeLayout(False)
        Me.grp受注日付.PerformLayout()
        Me.grp御客様NO.ResumeLayout(False)
        Me.grp御客様NO.PerformLayout()
        Me.grp積算NO.ResumeLayout(False)
        Me.grp積算NO.PerformLayout()
        Me.grp納品日付B.ResumeLayout(False)
        Me.grp納品日付B.PerformLayout()
        Me.grp得意先CD.ResumeLayout(False)
        Me.grp得意先CD.PerformLayout()
        Me.grp請求先CD.ResumeLayout(False)
        Me.grp請求先CD.PerformLayout()
        Me.grp代表商品名.ResumeLayout(False)
        Me.grp代表商品名.PerformLayout()
        Me.grp受注区分.ResumeLayout(False)
        Me.grp印刷場所.ResumeLayout(False)
        Me.grp印刷場所.PerformLayout()
        Me.grp作業注意.ResumeLayout(False)
        Me.grp作業注意.PerformLayout()
        Me.grp出荷先.ResumeLayout(False)
        Me.grp出荷先.PerformLayout()
        Me.grp納品日付A.ResumeLayout(False)
        Me.grp納品日付A.PerformLayout()
        Me.grp入力担当CD.ResumeLayout(False)
        Me.grp入力担当CD.PerformLayout()
        Me.grp顧客商品CD.ResumeLayout(False)
        Me.grp顧客商品CD.PerformLayout()
        Me.grp刃型NO.ResumeLayout(False)
        Me.grp刃型NO.PerformLayout()
        Me.grp版NO.ResumeLayout(False)
        Me.grp版NO.PerformLayout()
        Me.grpｷﾞｱ数.ResumeLayout(False)
        Me.grpｷﾞｱ数.PerformLayout()
        Me.grp発送仕上特記事項.ResumeLayout(False)
        Me.grp発送仕上特記事項.PerformLayout()
        Me.grp出荷注意.ResumeLayout(False)
        Me.grp出荷注意.PerformLayout()
        Me.grp売上入力指示.ResumeLayout(False)
        Me.grp売上入力指示.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grp処理区分 As BaseUI.Control.GroupBox
    Friend WithEvents opt削除 As BaseUI.Control.RadioButton
    Friend WithEvents opt修正 As BaseUI.Control.RadioButton
    Friend WithEvents opt登録 As BaseUI.Control.RadioButton
    Friend WithEvents grp作業NO As BaseUI.Control.GroupBox
    Friend WithEvents txt作業NO As BaseUI.Control.TextBox
    Friend WithEvents nam受注数合計Title As BaseUI.Control.NameBox
    Friend WithEvents nam内在庫引当数合計Title As BaseUI.Control.NameBox
    Friend WithEvents grp新再版区分 As BaseUI.Control.GroupBox
    Friend WithEvents ddl新再版区分 As BaseUI.Control.ComboBox
    Friend WithEvents grp本台帳NO As BaseUI.Control.GroupBox
    Friend WithEvents txt本台帳NO As BaseUI.Control.TextBox
    Friend WithEvents grp受注日付 As BaseUI.Control.GroupBox
    Friend WithEvents txt受注日付 As BaseUI.Control.TextBox
    Friend WithEvents grp御客様NO As BaseUI.Control.GroupBox
    Friend WithEvents txt御客様NO As BaseUI.Control.TextBox
    Friend WithEvents grp積算NO As BaseUI.Control.GroupBox
    Friend WithEvents txt積算NO As BaseUI.Control.TextBox
    Friend WithEvents grp納品日付B As BaseUI.Control.GroupBox
    Friend WithEvents ddl確約区分 As BaseUI.Control.ComboBox
    Friend WithEvents txt納品日付B As BaseUI.Control.TextBox
    Friend WithEvents grp得意先CD As BaseUI.Control.GroupBox
    Friend WithEvents nam得意先名 As BaseUI.Control.NameBox
    Friend WithEvents txt得意先CD As BaseUI.Control.TextBox
    Friend WithEvents grp請求先CD As BaseUI.Control.GroupBox
    Friend WithEvents nam請求先名 As BaseUI.Control.NameBox
    Friend WithEvents txt請求先CD As BaseUI.Control.TextBox
    Friend WithEvents grp代表商品名 As BaseUI.Control.GroupBox
    Friend WithEvents txt代表商品名 As BaseUI.Control.TextBox
    Friend WithEvents grp受注区分 As BaseUI.Control.GroupBox
    Friend WithEvents ddl受注区分 As BaseUI.Control.ComboBox
    Friend WithEvents grp印刷場所 As BaseUI.Control.GroupBox
    Friend WithEvents nam印刷場所名 As BaseUI.Control.NameBox
    Friend WithEvents txt印刷場所CD As BaseUI.Control.TextBox
    Friend WithEvents nam内製造数合計Title As BaseUI.Control.NameBox
    Friend WithEvents grp作業注意 As BaseUI.Control.GroupBox
    Friend WithEvents txt作業注意05 As BaseUI.Control.TextBox
    Friend WithEvents txt作業注意04 As BaseUI.Control.TextBox
    Friend WithEvents txt作業注意03 As BaseUI.Control.TextBox
    Friend WithEvents txt作業注意02 As BaseUI.Control.TextBox
    Friend WithEvents txt作業注意01 As BaseUI.Control.TextBox
    Friend WithEvents grp出荷先 As BaseUI.Control.GroupBox
    Friend WithEvents txt出荷先CD04 As BaseUI.Control.TextBox
    Friend WithEvents txt出荷先CD03 As BaseUI.Control.TextBox
    Friend WithEvents txt出荷先CD02 As BaseUI.Control.TextBox
    Friend WithEvents txt出荷先CD01 As BaseUI.Control.TextBox
    Friend WithEvents txt出荷先名04 As BaseUI.Control.TextBox
    Friend WithEvents txt出荷先名03 As BaseUI.Control.TextBox
    Friend WithEvents txt出荷先名02 As BaseUI.Control.TextBox
    Friend WithEvents txt出荷先名01 As BaseUI.Control.TextBox
    Friend WithEvents grp納品日付A As BaseUI.Control.GroupBox
    Friend WithEvents txt納品日付A As BaseUI.Control.TextBox
    Friend WithEvents grp入力担当CD As BaseUI.Control.GroupBox
    Friend WithEvents nam入力担当名 As BaseUI.Control.NameBox
    Friend WithEvents txt入力担当CD As BaseUI.Control.TextBox
    Friend WithEvents grp顧客商品CD As BaseUI.Control.GroupBox
    Friend WithEvents txt顧客商品CD As BaseUI.Control.TextBox
    Friend WithEvents btn商品内訳 As BaseUI.Control.Button
    Friend WithEvents txt通数3 As BaseUI.Control.TextBox
    Friend WithEvents nam通数3 As BaseUI.Control.NameBox
    Friend WithEvents nam通数2 As BaseUI.Control.NameBox
    Friend WithEvents txt通数2 As BaseUI.Control.TextBox
    Friend WithEvents txt通数1 As BaseUI.Control.TextBox
    Friend WithEvents nam通数1 As BaseUI.Control.NameBox
    Friend WithEvents txt受注単価 As BaseUI.Control.TextBox
    Friend WithEvents nam受注単位 As BaseUI.Control.NameBox
    Friend WithEvents ddl単位区分 As BaseUI.Control.ComboBox
    Friend WithEvents nam単位区分 As BaseUI.Control.NameBox
    Friend WithEvents txt受注金額 As BaseUI.Control.TextBox
    Friend WithEvents nam受注金額 As BaseUI.Control.NameBox
    Friend WithEvents grp刃型NO As BaseUI.Control.GroupBox
    Friend WithEvents txt刃型NO As BaseUI.Control.TextBox
    Friend WithEvents grp版NO As BaseUI.Control.GroupBox
    Friend WithEvents txt版NO As BaseUI.Control.TextBox
    Friend WithEvents txtギヤ数 As BaseUI.Control.TextBox
    Friend WithEvents grpｷﾞｱ数 As BaseUI.Control.GroupBox
    Friend WithEvents lblファイ As BaseUI.Control.Label
    Friend WithEvents grp発送仕上特記事項 As BaseUI.Control.GroupBox
    Friend WithEvents txt発送仕上特記事項 As BaseUI.Control.TextBox
    Friend WithEvents txt作業注意10 As BaseUI.Control.TextBox
    Friend WithEvents txt作業注意09 As BaseUI.Control.TextBox
    Friend WithEvents txt作業注意08 As BaseUI.Control.TextBox
    Friend WithEvents txt作業注意07 As BaseUI.Control.TextBox
    Friend WithEvents txt作業注意06 As BaseUI.Control.TextBox
    Friend WithEvents grp出荷注意 As BaseUI.Control.GroupBox
    Friend WithEvents txt出荷注意10 As BaseUI.Control.TextBox
    Friend WithEvents txt出荷注意09 As BaseUI.Control.TextBox
    Friend WithEvents txt出荷注意08 As BaseUI.Control.TextBox
    Friend WithEvents txt出荷注意07 As BaseUI.Control.TextBox
    Friend WithEvents txt出荷注意06 As BaseUI.Control.TextBox
    Friend WithEvents txt出荷注意05 As BaseUI.Control.TextBox
    Friend WithEvents txt出荷注意04 As BaseUI.Control.TextBox
    Friend WithEvents txt出荷注意03 As BaseUI.Control.TextBox
    Friend WithEvents txt出荷注意02 As BaseUI.Control.TextBox
    Friend WithEvents txt出荷注意01 As BaseUI.Control.TextBox
    Friend WithEvents grp売上入力指示 As BaseUI.Control.GroupBox
    Friend WithEvents ddl版代売上区分 As BaseUI.Control.ComboBox
    Friend WithEvents lbl刃型サイズ一面角単位 As BaseUI.Control.Label
    Friend WithEvents txt版代単価 As BaseUI.Control.TextBox
    Friend WithEvents txt版代数量 As BaseUI.Control.TextBox
    Friend WithEvents nam版代 As BaseUI.Control.NameBox
    Friend WithEvents nam刃型代 As BaseUI.Control.NameBox
    Friend WithEvents nam版下代 As BaseUI.Control.NameBox
    Friend WithEvents nam運賃 As BaseUI.Control.NameBox
    Friend WithEvents Label1 As BaseUI.Control.Label
    Friend WithEvents txt版代金額 As BaseUI.Control.TextBox
    Friend WithEvents txt刃型金額 As BaseUI.Control.TextBox
    Friend WithEvents ddl刃型売上区分 As BaseUI.Control.ComboBox
    Friend WithEvents txt刃型単価 As BaseUI.Control.TextBox
    Friend WithEvents txt刃型数量 As BaseUI.Control.TextBox
    Friend WithEvents Label2 As BaseUI.Control.Label
    Friend WithEvents Label3 As BaseUI.Control.Label
    Friend WithEvents txt版下金額 As BaseUI.Control.TextBox
    Friend WithEvents ddl版下売上区分 As BaseUI.Control.ComboBox
    Friend WithEvents txt版下単価 As BaseUI.Control.TextBox
    Friend WithEvents txt版下数量 As BaseUI.Control.TextBox
    Friend WithEvents Label4 As BaseUI.Control.Label
    Friend WithEvents Label5 As BaseUI.Control.Label
    Friend WithEvents txt運賃金額 As BaseUI.Control.TextBox
    Friend WithEvents ddl運賃売上区分 As BaseUI.Control.ComboBox
    Friend WithEvents txt運賃単価 As BaseUI.Control.TextBox
    Friend WithEvents txt運賃数量 As BaseUI.Control.TextBox
    Friend WithEvents Label6 As BaseUI.Control.Label
    Friend WithEvents Label7 As BaseUI.Control.Label
    Friend WithEvents txt売上名 As BaseUI.Control.TextBox
    Friend WithEvents txt売上金額 As BaseUI.Control.TextBox
    Friend WithEvents ddl売上区分 As BaseUI.Control.ComboBox
    Friend WithEvents btn紙発注 As BaseUI.Control.Button
    Friend WithEvents nam受注数合計 As BaseUI.Control.NameBox
    Friend WithEvents nam内在庫引当数合計 As BaseUI.Control.NameBox
    Friend WithEvents nam内製造数合計 As BaseUI.Control.NameBox

End Class
