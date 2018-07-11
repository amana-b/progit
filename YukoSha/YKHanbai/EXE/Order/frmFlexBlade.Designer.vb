<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmFlexBlade
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
        Me.nam受注数合計 = New BaseUI.Control.NameBox()
        Me.txt受注単価 = New BaseUI.Control.TextBox()
        Me.txt受注数合計 = New BaseUI.Control.TextBox()
        Me.nam受注単価 = New BaseUI.Control.NameBox()
        Me.grp社内外区分 = New BaseUI.Control.GroupBox()
        Me.ddl社内外区分 = New BaseUI.Control.ComboBox()
        Me.grp本台帳NO = New BaseUI.Control.GroupBox()
        Me.txt本台帳NO = New BaseUI.Control.TextBox()
        Me.grp受注日付 = New BaseUI.Control.GroupBox()
        Me.txt受注日付 = New BaseUI.Control.TextBox()
        Me.grp御客様NO = New BaseUI.Control.GroupBox()
        Me.txt御客様NO = New BaseUI.Control.TextBox()
        Me.grp機番 = New BaseUI.Control.GroupBox()
        Me.txt機番 = New BaseUI.Control.TextBox()
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
        Me.grp刃型区分 = New BaseUI.Control.GroupBox()
        Me.ddl刃型区分 = New BaseUI.Control.ComboBox()
        Me.grp顧客刃型番号 = New BaseUI.Control.GroupBox()
        Me.txt顧客刃型番号 = New BaseUI.Control.TextBox()
        Me.grp台紙 = New BaseUI.Control.GroupBox()
        Me.nam台紙名 = New BaseUI.Control.NameBox()
        Me.txt台紙CD = New BaseUI.Control.TextBox()
        Me.grp担当者 = New BaseUI.Control.GroupBox()
        Me.nam担当者名 = New BaseUI.Control.NameBox()
        Me.txt担当者CD = New BaseUI.Control.TextBox()
        Me.txt受注金額 = New BaseUI.Control.TextBox()
        Me.nam受注金額 = New BaseUI.Control.NameBox()
        Me.grp仕入情報 = New BaseUI.Control.GroupBox()
        Me.lbl仕入先CD = New BaseUI.Control.Label()
        Me.nam仕入先名 = New BaseUI.Control.NameBox()
        Me.txt仕入先CD = New BaseUI.Control.TextBox()
        Me.txt計上先作業NO = New BaseUI.Control.TextBox()
        Me.lbl作業NO = New BaseUI.Control.Label()
        Me.lbl計上先 = New BaseUI.Control.Label()
        Me.lbl原価 = New BaseUI.Control.Label()
        Me.txt原価 = New BaseUI.Control.TextBox()
        Me.grp刃型情報大枠 = New BaseUI.Control.GroupBox()
        Me.grp刃型サイズ一面 = New BaseUI.Control.GroupBox()
        Me.ddl刃型サイズ一面形状区分 = New BaseUI.Control.ComboBox()
        Me.lbl刃型サイズ一面形状区分 = New BaseUI.Control.Label()
        Me.lbl刃型サイズ一面角単位 = New BaseUI.Control.Label()
        Me.lbl刃型サイズ一面流れ方向単位 = New BaseUI.Control.Label()
        Me.lbl刃型サイズ一面角 = New BaseUI.Control.Label()
        Me.lbl刃型サイズ一面流れ方向 = New BaseUI.Control.Label()
        Me.txt刃型サイズ一面角 = New BaseUI.Control.TextBox()
        Me.txt刃型サイズ一面流れ方向 = New BaseUI.Control.TextBox()
        Me.lbl刃型サイズ一面紙幅方向 = New BaseUI.Control.Label()
        Me.lbl刃型サイズ一面紙幅方向単位 = New BaseUI.Control.Label()
        Me.txt刃型サイズ一面紙幅方向 = New BaseUI.Control.TextBox()
        Me.grp刃型情報 = New BaseUI.Control.GroupBox()
        Me.lbl刃型情報バリヤ単位 = New BaseUI.Control.Label()
        Me.lbl刃型情報バリヤ = New BaseUI.Control.Label()
        Me.txt刃型情報バリヤ = New BaseUI.Control.TextBox()
        Me.lbl刃型情報総円周単位 = New BaseUI.Control.Label()
        Me.lbl刃型情報板厚単位 = New BaseUI.Control.Label()
        Me.lbl刃型情報総円周 = New BaseUI.Control.Label()
        Me.lbl刃型情報板厚 = New BaseUI.Control.Label()
        Me.txt刃型情報総円周 = New BaseUI.Control.TextBox()
        Me.txt刃型情報板厚 = New BaseUI.Control.TextBox()
        Me.lbl刃型情報ギヤ数 = New BaseUI.Control.Label()
        Me.lbl刃型情報ギヤ数単位 = New BaseUI.Control.Label()
        Me.txt刃型情報ギヤ数 = New BaseUI.Control.TextBox()
        Me.grp線幅 = New BaseUI.Control.GroupBox()
        Me.lbl線幅トンボ単位 = New BaseUI.Control.Label()
        Me.lbl線幅原点単位 = New BaseUI.Control.Label()
        Me.lbl線幅トンボ = New BaseUI.Control.Label()
        Me.lbl線幅原点 = New BaseUI.Control.Label()
        Me.txt線幅トンボ = New BaseUI.Control.TextBox()
        Me.txt線幅原点 = New BaseUI.Control.TextBox()
        Me.lbl線幅刃型線 = New BaseUI.Control.Label()
        Me.lbl線幅刃型線単位 = New BaseUI.Control.Label()
        Me.txt線幅刃型線 = New BaseUI.Control.TextBox()
        Me.grp刃型サイズ全体 = New BaseUI.Control.GroupBox()
        Me.lbl刃型サイズ全体流れ方向単位 = New BaseUI.Control.Label()
        Me.lbl刃型サイズ全体流れ方向下 = New BaseUI.Control.Label()
        Me.txt刃型サイズ全体流れ方向 = New BaseUI.Control.TextBox()
        Me.lbl刃型サイズ全体流れ方向上 = New BaseUI.Control.Label()
        Me.lbl刃型サイズ全体紙幅方向 = New BaseUI.Control.Label()
        Me.lbl刃型サイズ全体紙幅方向単位 = New BaseUI.Control.Label()
        Me.txt刃型サイズ全体紙幅方向 = New BaseUI.Control.TextBox()
        Me.grp面付 = New BaseUI.Control.GroupBox()
        Me.grp面付流れ方向 = New BaseUI.Control.GroupBox()
        Me.lbl面付流れ方向ドブ寸法 = New BaseUI.Control.Label()
        Me.lbl面付流れ方向ドブ寸法単位 = New BaseUI.Control.Label()
        Me.txt面付流れ方向ドブ寸法 = New BaseUI.Control.TextBox()
        Me.lbl面付流れ方向面数単位 = New BaseUI.Control.Label()
        Me.txt面付流れ方向面数 = New BaseUI.Control.TextBox()
        Me.lbl面付流れ方向面数 = New BaseUI.Control.Label()
        Me.grp面付紙幅方向 = New BaseUI.Control.GroupBox()
        Me.lbl面付紙幅方向ドブ寸法 = New BaseUI.Control.Label()
        Me.lbl面付紙幅方向ドブ寸法単位 = New BaseUI.Control.Label()
        Me.txt面付紙幅方向ドブ寸法 = New BaseUI.Control.TextBox()
        Me.lbl面付紙幅方向面数単位 = New BaseUI.Control.Label()
        Me.txt面付紙幅方向面数 = New BaseUI.Control.TextBox()
        Me.lbl面付紙幅方向面数 = New BaseUI.Control.Label()
        Me.grpバリヤ表 = New BaseUI.Control.GroupBox()
        Me.namバリヤ表区分名 = New BaseUI.Control.NameBox()
        Me.txtバリヤ表区分 = New BaseUI.Control.TextBox()
        Me.grpフレキ機械種別 = New BaseUI.Control.GroupBox()
        Me.ddlフレキ機械種別区分 = New BaseUI.Control.ComboBox()
        Me.grp注意事項 = New BaseUI.Control.GroupBox()
        Me.txt注意事項05 = New BaseUI.Control.TextBox()
        Me.txt注意事項04 = New BaseUI.Control.TextBox()
        Me.txt注意事項03 = New BaseUI.Control.TextBox()
        Me.txt注意事項02 = New BaseUI.Control.TextBox()
        Me.txt注意事項01 = New BaseUI.Control.TextBox()
        Me.grp出荷先 = New BaseUI.Control.GroupBox()
        Me.txt出荷先CD04 = New BaseUI.Control.TextBox()
        Me.txt出荷先CD03 = New BaseUI.Control.TextBox()
        Me.txt出荷先CD02 = New BaseUI.Control.TextBox()
        Me.txt出荷先CD01 = New BaseUI.Control.TextBox()
        Me.txt出荷先名04 = New BaseUI.Control.TextBox()
        Me.txt出荷先名03 = New BaseUI.Control.TextBox()
        Me.txt出荷先名02 = New BaseUI.Control.TextBox()
        Me.txt出荷先名01 = New BaseUI.Control.TextBox()
        Me.grp処理区分.SuspendLayout()
        Me.grp作業NO.SuspendLayout()
        Me.grp社内外区分.SuspendLayout()
        Me.grp本台帳NO.SuspendLayout()
        Me.grp受注日付.SuspendLayout()
        Me.grp御客様NO.SuspendLayout()
        Me.grp機番.SuspendLayout()
        Me.grp納品日付B.SuspendLayout()
        Me.grp得意先CD.SuspendLayout()
        Me.grp請求先CD.SuspendLayout()
        Me.grp代表商品名.SuspendLayout()
        Me.grp刃型区分.SuspendLayout()
        Me.grp顧客刃型番号.SuspendLayout()
        Me.grp台紙.SuspendLayout()
        Me.grp担当者.SuspendLayout()
        Me.grp仕入情報.SuspendLayout()
        Me.grp刃型情報大枠.SuspendLayout()
        Me.grp刃型サイズ一面.SuspendLayout()
        Me.grp刃型情報.SuspendLayout()
        Me.grp線幅.SuspendLayout()
        Me.grp刃型サイズ全体.SuspendLayout()
        Me.grp面付.SuspendLayout()
        Me.grp面付流れ方向.SuspendLayout()
        Me.grp面付紙幅方向.SuspendLayout()
        Me.grpバリヤ表.SuspendLayout()
        Me.grpフレキ機械種別.SuspendLayout()
        Me.grp注意事項.SuspendLayout()
        Me.grp出荷先.SuspendLayout()
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
        'nam受注数合計
        '
        Me.nam受注数合計.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam受注数合計.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam受注数合計.Location = New System.Drawing.Point(7, 195)
        Me.nam受注数合計.Name = "nam受注数合計"
        Me.nam受注数合計.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam受注数合計.Size = New System.Drawing.Size(95, 23)
        Me.nam受注数合計.StringLength = 0
        Me.nam受注数合計.TabIndex = 22
        Me.nam受注数合計.Text = "受注数合計"
        Me.nam受注数合計.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam受注数合計.TextStyle = BaseContents.TextBox.TextStyle.None
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
        Me.txt受注単価.Location = New System.Drawing.Point(104, 221)
        Me.txt受注単価.Name = "txt受注単価"
        Me.txt受注単価.NumberMinor = 2
        Me.txt受注単価.Required = False
        Me.txt受注単価.Size = New System.Drawing.Size(106, 23)
        Me.txt受注単価.TabIndex = 16
        Me.txt受注単価.Text = "1,234,567.89"
        Me.txt受注単価.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt受注数合計
        '
        Me.txt受注数合計.FieldLockType = BaseContents.Field.LockType.None
        Me.txt受注数合計.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt受注数合計.HelpKeys = ""
        Me.txt受注数合計.HelpLink = ""
        Me.txt受注数合計.HelpType = NodeUI.Help.Type.None
        Me.txt受注数合計.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt受注数合計.IsError = False
        Me.txt受注数合計.Location = New System.Drawing.Point(7, 221)
        Me.txt受注数合計.Name = "txt受注数合計"
        Me.txt受注数合計.Required = False
        Me.txt受注数合計.Size = New System.Drawing.Size(95, 23)
        Me.txt受注数合計.TabIndex = 15
        Me.txt受注数合計.Text = "123,456,789"
        Me.txt受注数合計.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam受注単価
        '
        Me.nam受注単価.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam受注単価.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam受注単価.Location = New System.Drawing.Point(104, 195)
        Me.nam受注単価.Name = "nam受注単価"
        Me.nam受注単価.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam受注単価.Size = New System.Drawing.Size(106, 23)
        Me.nam受注単価.StringLength = 0
        Me.nam受注単価.TabIndex = 26
        Me.nam受注単価.Text = "受注単価"
        Me.nam受注単価.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam受注単価.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp社内外区分
        '
        Me.grp社内外区分.Controls.Add(Me.ddl社内外区分)
        Me.grp社内外区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp社内外区分.Location = New System.Drawing.Point(283, 7)
        Me.grp社内外区分.Name = "grp社内外区分"
        Me.grp社内外区分.Size = New System.Drawing.Size(134, 54)
        Me.grp社内外区分.TabIndex = 1
        Me.grp社内外区分.TabStop = False
        Me.grp社内外区分.Text = "社内･社外区分"
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
        Me.ddl社内外区分.Location = New System.Drawing.Point(12, 21)
        Me.ddl社内外区分.Name = "ddl社内外区分"
        Me.ddl社内外区分.Required = False
        Me.ddl社内外区分.Size = New System.Drawing.Size(110, 24)
        Me.ddl社内外区分.TabIndex = 0
        Me.ddl社内外区分.ValueMember = "Value"
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
        Me.grp受注日付.Size = New System.Drawing.Size(104, 54)
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
        Me.grp御客様NO.Location = New System.Drawing.Point(686, 7)
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
        'grp機番
        '
        Me.grp機番.Controls.Add(Me.txt機番)
        Me.grp機番.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp機番.Location = New System.Drawing.Point(622, 7)
        Me.grp機番.Name = "grp機番"
        Me.grp機番.Size = New System.Drawing.Size(56, 54)
        Me.grp機番.TabIndex = 4
        Me.grp機番.TabStop = False
        Me.grp機番.Text = "機番"
        '
        'txt機番
        '
        Me.txt機番.FieldLockType = BaseContents.Field.LockType.None
        Me.txt機番.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt機番.HelpKeys = ""
        Me.txt機番.HelpLink = ""
        Me.txt機番.HelpType = NodeUI.Help.Type.None
        Me.txt機番.IsError = False
        Me.txt機番.Location = New System.Drawing.Point(13, 21)
        Me.txt機番.Name = "txt機番"
        Me.txt機番.Required = False
        Me.txt機番.Size = New System.Drawing.Size(24, 23)
        Me.txt機番.TabIndex = 0
        Me.txt機番.Text = "XX"
        Me.txt機番.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp納品日付B
        '
        Me.grp納品日付B.Controls.Add(Me.ddl確約区分)
        Me.grp納品日付B.Controls.Add(Me.txt納品日付B)
        Me.grp納品日付B.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp納品日付B.Location = New System.Drawing.Point(117, 69)
        Me.grp納品日付B.Name = "grp納品日付B"
        Me.grp納品日付B.Size = New System.Drawing.Size(187, 54)
        Me.grp納品日付B.TabIndex = 7
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
        Me.ddl確約区分.Size = New System.Drawing.Size(80, 24)
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
        Me.grp得意先CD.Location = New System.Drawing.Point(313, 69)
        Me.grp得意先CD.Name = "grp得意先CD"
        Me.grp得意先CD.Size = New System.Drawing.Size(347, 54)
        Me.grp得意先CD.TabIndex = 8
        Me.grp得意先CD.TabStop = False
        Me.grp得意先CD.Text = "得意先ｺｰﾄﾞ"
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
        Me.nam得意先名.Text = "*XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX*"
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
        Me.grp請求先CD.Location = New System.Drawing.Point(666, 69)
        Me.grp請求先CD.Name = "grp請求先CD"
        Me.grp請求先CD.Size = New System.Drawing.Size(347, 54)
        Me.grp請求先CD.TabIndex = 9
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
        Me.nam請求先名.Text = "*XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX*"
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
        Me.grp代表商品名.Location = New System.Drawing.Point(7, 131)
        Me.grp代表商品名.Name = "grp代表商品名"
        Me.grp代表商品名.Size = New System.Drawing.Size(298, 54)
        Me.grp代表商品名.TabIndex = 10
        Me.grp代表商品名.TabStop = False
        Me.grp代表商品名.Text = "商品名"
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
        'grp刃型区分
        '
        Me.grp刃型区分.Controls.Add(Me.ddl刃型区分)
        Me.grp刃型区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp刃型区分.Location = New System.Drawing.Point(313, 131)
        Me.grp刃型区分.Name = "grp刃型区分"
        Me.grp刃型区分.Size = New System.Drawing.Size(134, 54)
        Me.grp刃型区分.TabIndex = 11
        Me.grp刃型区分.TabStop = False
        Me.grp刃型区分.Text = "刃型区分"
        '
        'ddl刃型区分
        '
        Me.ddl刃型区分.AutoDropDown = True
        Me.ddl刃型区分.DisplayMember = "Display"
        Me.ddl刃型区分.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddl刃型区分.FieldLockType = BaseContents.Field.LockType.None
        Me.ddl刃型区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.ddl刃型区分.FormattingEnabled = True
        Me.ddl刃型区分.IsError = False
        Me.ddl刃型区分.ListType = NodeUI.List.Type.None
        Me.ddl刃型区分.Location = New System.Drawing.Point(12, 21)
        Me.ddl刃型区分.Name = "ddl刃型区分"
        Me.ddl刃型区分.Required = False
        Me.ddl刃型区分.Size = New System.Drawing.Size(110, 24)
        Me.ddl刃型区分.TabIndex = 0
        Me.ddl刃型区分.ValueMember = "Value"
        '
        'grp顧客刃型番号
        '
        Me.grp顧客刃型番号.Controls.Add(Me.txt顧客刃型番号)
        Me.grp顧客刃型番号.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp顧客刃型番号.Location = New System.Drawing.Point(457, 131)
        Me.grp顧客刃型番号.Name = "grp顧客刃型番号"
        Me.grp顧客刃型番号.Size = New System.Drawing.Size(120, 54)
        Me.grp顧客刃型番号.TabIndex = 12
        Me.grp顧客刃型番号.TabStop = False
        Me.grp顧客刃型番号.Text = "顧客刃型番号"
        '
        'txt顧客刃型番号
        '
        Me.txt顧客刃型番号.FieldLockType = BaseContents.Field.LockType.None
        Me.txt顧客刃型番号.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt顧客刃型番号.HelpKeys = ""
        Me.txt顧客刃型番号.HelpLink = ""
        Me.txt顧客刃型番号.HelpType = NodeUI.Help.Type.None
        Me.txt顧客刃型番号.IsError = False
        Me.txt顧客刃型番号.Location = New System.Drawing.Point(38, 21)
        Me.txt顧客刃型番号.Name = "txt顧客刃型番号"
        Me.txt顧客刃型番号.Required = False
        Me.txt顧客刃型番号.Size = New System.Drawing.Size(42, 23)
        Me.txt顧客刃型番号.TabIndex = 0
        Me.txt顧客刃型番号.Text = "XXXX"
        Me.txt顧客刃型番号.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp台紙
        '
        Me.grp台紙.Controls.Add(Me.nam台紙名)
        Me.grp台紙.Controls.Add(Me.txt台紙CD)
        Me.grp台紙.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp台紙.Location = New System.Drawing.Point(583, 131)
        Me.grp台紙.Name = "grp台紙"
        Me.grp台紙.Size = New System.Drawing.Size(150, 54)
        Me.grp台紙.TabIndex = 13
        Me.grp台紙.TabStop = False
        Me.grp台紙.Text = "ｾﾊﾟﾚｰﾀ"
        '
        'nam台紙名
        '
        Me.nam台紙名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam台紙名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam台紙名.Location = New System.Drawing.Point(34, 21)
        Me.nam台紙名.Name = "nam台紙名"
        Me.nam台紙名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam台紙名.Size = New System.Drawing.Size(106, 23)
        Me.nam台紙名.StringLength = 0
        Me.nam台紙名.TabIndex = 1
        Me.nam台紙名.Text = "*XXXXXXXXXX*"
        Me.nam台紙名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt台紙CD
        '
        Me.txt台紙CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt台紙CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt台紙CD.HelpKeys = ""
        Me.txt台紙CD.HelpLink = ""
        Me.txt台紙CD.HelpType = NodeUI.Help.Type.None
        Me.txt台紙CD.IsError = False
        Me.txt台紙CD.Location = New System.Drawing.Point(9, 21)
        Me.txt台紙CD.Name = "txt台紙CD"
        Me.txt台紙CD.Required = False
        Me.txt台紙CD.Size = New System.Drawing.Size(24, 23)
        Me.txt台紙CD.TabIndex = 0
        Me.txt台紙CD.Text = "XX"
        Me.txt台紙CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp担当者
        '
        Me.grp担当者.Controls.Add(Me.nam担当者名)
        Me.grp担当者.Controls.Add(Me.txt担当者CD)
        Me.grp担当者.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp担当者.Location = New System.Drawing.Point(740, 131)
        Me.grp担当者.Name = "grp担当者"
        Me.grp担当者.Size = New System.Drawing.Size(192, 54)
        Me.grp担当者.TabIndex = 14
        Me.grp担当者.TabStop = False
        Me.grp担当者.Text = "製造者"
        '
        'nam担当者名
        '
        Me.nam担当者名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam担当者名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam担当者名.Location = New System.Drawing.Point(42, 21)
        Me.nam担当者名.Name = "nam担当者名"
        Me.nam担当者名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam担当者名.Size = New System.Drawing.Size(140, 23)
        Me.nam担当者名.StringLength = 0
        Me.nam担当者名.TabIndex = 1
        Me.nam担当者名.Text = "*XXXXXXXXXXXXXX*"
        Me.nam担当者名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt担当者CD
        '
        Me.txt担当者CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt担当者CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt担当者CD.HelpKeys = ""
        Me.txt担当者CD.HelpLink = ""
        Me.txt担当者CD.HelpType = NodeUI.Help.Type.None
        Me.txt担当者CD.IsError = False
        Me.txt担当者CD.Location = New System.Drawing.Point(9, 21)
        Me.txt担当者CD.Name = "txt担当者CD"
        Me.txt担当者CD.Required = False
        Me.txt担当者CD.Size = New System.Drawing.Size(32, 23)
        Me.txt担当者CD.TabIndex = 0
        Me.txt担当者CD.Text = "XXX"
        Me.txt担当者CD.TextStyle = BaseContents.TextBox.TextStyle.None
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
        Me.txt受注金額.Location = New System.Drawing.Point(211, 221)
        Me.txt受注金額.Name = "txt受注金額"
        Me.txt受注金額.Required = False
        Me.txt受注金額.Size = New System.Drawing.Size(95, 23)
        Me.txt受注金額.TabIndex = 17
        Me.txt受注金額.Text = "123,456,789"
        Me.txt受注金額.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam受注金額
        '
        Me.nam受注金額.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam受注金額.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam受注金額.Location = New System.Drawing.Point(211, 195)
        Me.nam受注金額.Name = "nam受注金額"
        Me.nam受注金額.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam受注金額.Size = New System.Drawing.Size(95, 23)
        Me.nam受注金額.StringLength = 0
        Me.nam受注金額.TabIndex = 54
        Me.nam受注金額.Text = "受注金額"
        Me.nam受注金額.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam受注金額.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp仕入情報
        '
        Me.grp仕入情報.Controls.Add(Me.lbl仕入先CD)
        Me.grp仕入情報.Controls.Add(Me.nam仕入先名)
        Me.grp仕入情報.Controls.Add(Me.txt仕入先CD)
        Me.grp仕入情報.Controls.Add(Me.txt計上先作業NO)
        Me.grp仕入情報.Controls.Add(Me.lbl作業NO)
        Me.grp仕入情報.Controls.Add(Me.lbl計上先)
        Me.grp仕入情報.Controls.Add(Me.lbl原価)
        Me.grp仕入情報.Controls.Add(Me.txt原価)
        Me.grp仕入情報.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp仕入情報.Location = New System.Drawing.Point(313, 191)
        Me.grp仕入情報.Name = "grp仕入情報"
        Me.grp仕入情報.Size = New System.Drawing.Size(700, 54)
        Me.grp仕入情報.TabIndex = 18
        Me.grp仕入情報.TabStop = False
        Me.grp仕入情報.Text = "社内用仕入計上情報"
        '
        'lbl仕入先CD
        '
        Me.lbl仕入先CD.AutoSize = True
        Me.lbl仕入先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.lbl仕入先CD.Location = New System.Drawing.Point(301, 25)
        Me.lbl仕入先CD.Name = "lbl仕入先CD"
        Me.lbl仕入先CD.Size = New System.Drawing.Size(56, 16)
        Me.lbl仕入先CD.TabIndex = 15
        Me.lbl仕入先CD.Text = "仕入先"
        '
        'nam仕入先名
        '
        Me.nam仕入先名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam仕入先名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam仕入先名.Location = New System.Drawing.Point(418, 21)
        Me.nam仕入先名.Name = "nam仕入先名"
        Me.nam仕入先名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam仕入先名.Size = New System.Drawing.Size(270, 23)
        Me.nam仕入先名.StringLength = 0
        Me.nam仕入先名.TabIndex = 14
        Me.nam仕入先名.Text = "*XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX*"
        Me.nam仕入先名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt仕入先CD
        '
        Me.txt仕入先CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt仕入先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt仕入先CD.HelpKeys = ""
        Me.txt仕入先CD.HelpLink = ""
        Me.txt仕入先CD.HelpType = NodeUI.Help.Type.None
        Me.txt仕入先CD.IsError = False
        Me.txt仕入先CD.Location = New System.Drawing.Point(357, 21)
        Me.txt仕入先CD.Name = "txt仕入先CD"
        Me.txt仕入先CD.Required = False
        Me.txt仕入先CD.Size = New System.Drawing.Size(60, 23)
        Me.txt仕入先CD.TabIndex = 2
        Me.txt仕入先CD.Text = "XXXXXX"
        Me.txt仕入先CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt計上先作業NO
        '
        Me.txt計上先作業NO.FieldLockType = BaseContents.Field.LockType.None
        Me.txt計上先作業NO.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt計上先作業NO.HelpKeys = ""
        Me.txt計上先作業NO.HelpLink = ""
        Me.txt計上先作業NO.HelpType = NodeUI.Help.Type.None
        Me.txt計上先作業NO.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt計上先作業NO.IsError = False
        Me.txt計上先作業NO.Location = New System.Drawing.Point(220, 21)
        Me.txt計上先作業NO.Name = "txt計上先作業NO"
        Me.txt計上先作業NO.Required = False
        Me.txt計上先作業NO.Size = New System.Drawing.Size(60, 23)
        Me.txt計上先作業NO.TabIndex = 1
        Me.txt計上先作業NO.Text = "XXXXXX"
        Me.txt計上先作業NO.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'lbl作業NO
        '
        Me.lbl作業NO.AutoSize = True
        Me.lbl作業NO.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.lbl作業NO.Location = New System.Drawing.Point(163, 31)
        Me.lbl作業NO.Name = "lbl作業NO"
        Me.lbl作業NO.Size = New System.Drawing.Size(56, 16)
        Me.lbl作業NO.TabIndex = 11
        Me.lbl作業NO.Text = "作業NO"
        '
        'lbl計上先
        '
        Me.lbl計上先.AutoSize = True
        Me.lbl計上先.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.lbl計上先.Location = New System.Drawing.Point(163, 13)
        Me.lbl計上先.Name = "lbl計上先"
        Me.lbl計上先.Size = New System.Drawing.Size(56, 16)
        Me.lbl計上先.TabIndex = 10
        Me.lbl計上先.Text = "計上先"
        '
        'lbl原価
        '
        Me.lbl原価.AutoSize = True
        Me.lbl原価.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.lbl原価.Location = New System.Drawing.Point(12, 25)
        Me.lbl原価.Name = "lbl原価"
        Me.lbl原価.Size = New System.Drawing.Size(40, 16)
        Me.lbl原価.TabIndex = 9
        Me.lbl原価.Text = "原価"
        '
        'txt原価
        '
        Me.txt原価.FieldLockType = BaseContents.Field.LockType.None
        Me.txt原価.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt原価.HelpKeys = ""
        Me.txt原価.HelpLink = ""
        Me.txt原価.HelpType = NodeUI.Help.Type.None
        Me.txt原価.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt原価.IsError = False
        Me.txt原価.Location = New System.Drawing.Point(51, 21)
        Me.txt原価.Name = "txt原価"
        Me.txt原価.Required = False
        Me.txt原価.Size = New System.Drawing.Size(95, 23)
        Me.txt原価.TabIndex = 0
        Me.txt原価.Text = "123,456,789"
        Me.txt原価.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp刃型情報大枠
        '
        Me.grp刃型情報大枠.Controls.Add(Me.grp刃型サイズ一面)
        Me.grp刃型情報大枠.Controls.Add(Me.grp刃型情報)
        Me.grp刃型情報大枠.Controls.Add(Me.grp線幅)
        Me.grp刃型情報大枠.Controls.Add(Me.grp刃型サイズ全体)
        Me.grp刃型情報大枠.Controls.Add(Me.grp面付)
        Me.grp刃型情報大枠.Controls.Add(Me.grpバリヤ表)
        Me.grp刃型情報大枠.Controls.Add(Me.grpフレキ機械種別)
        Me.grp刃型情報大枠.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp刃型情報大枠.Location = New System.Drawing.Point(8, 250)
        Me.grp刃型情報大枠.Name = "grp刃型情報大枠"
        Me.grp刃型情報大枠.Size = New System.Drawing.Size(980, 213)
        Me.grp刃型情報大枠.TabIndex = 19
        Me.grp刃型情報大枠.TabStop = False
        Me.grp刃型情報大枠.Text = "【刃型情報】"
        '
        'grp刃型サイズ一面
        '
        Me.grp刃型サイズ一面.Controls.Add(Me.ddl刃型サイズ一面形状区分)
        Me.grp刃型サイズ一面.Controls.Add(Me.lbl刃型サイズ一面形状区分)
        Me.grp刃型サイズ一面.Controls.Add(Me.lbl刃型サイズ一面角単位)
        Me.grp刃型サイズ一面.Controls.Add(Me.lbl刃型サイズ一面流れ方向単位)
        Me.grp刃型サイズ一面.Controls.Add(Me.lbl刃型サイズ一面角)
        Me.grp刃型サイズ一面.Controls.Add(Me.lbl刃型サイズ一面流れ方向)
        Me.grp刃型サイズ一面.Controls.Add(Me.txt刃型サイズ一面角)
        Me.grp刃型サイズ一面.Controls.Add(Me.txt刃型サイズ一面流れ方向)
        Me.grp刃型サイズ一面.Controls.Add(Me.lbl刃型サイズ一面紙幅方向)
        Me.grp刃型サイズ一面.Controls.Add(Me.lbl刃型サイズ一面紙幅方向単位)
        Me.grp刃型サイズ一面.Controls.Add(Me.txt刃型サイズ一面紙幅方向)
        Me.grp刃型サイズ一面.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.grp刃型サイズ一面.Location = New System.Drawing.Point(246, 78)
        Me.grp刃型サイズ一面.Name = "grp刃型サイズ一面"
        Me.grp刃型サイズ一面.Size = New System.Drawing.Size(218, 117)
        Me.grp刃型サイズ一面.TabIndex = 3
        Me.grp刃型サイズ一面.TabStop = False
        Me.grp刃型サイズ一面.Text = "刃型ｻｲｽﾞ(一面)"
        '
        'ddl刃型サイズ一面形状区分
        '
        Me.ddl刃型サイズ一面形状区分.AutoDropDown = True
        Me.ddl刃型サイズ一面形状区分.DisplayMember = "Display"
        Me.ddl刃型サイズ一面形状区分.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddl刃型サイズ一面形状区分.FieldLockType = BaseContents.Field.LockType.None
        Me.ddl刃型サイズ一面形状区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.ddl刃型サイズ一面形状区分.FormattingEnabled = True
        Me.ddl刃型サイズ一面形状区分.IsError = False
        Me.ddl刃型サイズ一面形状区分.ListType = NodeUI.List.Type.None
        Me.ddl刃型サイズ一面形状区分.Location = New System.Drawing.Point(108, 85)
        Me.ddl刃型サイズ一面形状区分.Name = "ddl刃型サイズ一面形状区分"
        Me.ddl刃型サイズ一面形状区分.Required = False
        Me.ddl刃型サイズ一面形状区分.Size = New System.Drawing.Size(90, 24)
        Me.ddl刃型サイズ一面形状区分.TabIndex = 3
        Me.ddl刃型サイズ一面形状区分.ValueMember = "Value"
        '
        'lbl刃型サイズ一面形状区分
        '
        Me.lbl刃型サイズ一面形状区分.AutoSize = True
        Me.lbl刃型サイズ一面形状区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.lbl刃型サイズ一面形状区分.Location = New System.Drawing.Point(14, 87)
        Me.lbl刃型サイズ一面形状区分.Name = "lbl刃型サイズ一面形状区分"
        Me.lbl刃型サイズ一面形状区分.Size = New System.Drawing.Size(35, 14)
        Me.lbl刃型サイズ一面形状区分.TabIndex = 23
        Me.lbl刃型サイズ一面形状区分.Text = "形状"
        '
        'lbl刃型サイズ一面角単位
        '
        Me.lbl刃型サイズ一面角単位.AutoSize = True
        Me.lbl刃型サイズ一面角単位.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.lbl刃型サイズ一面角単位.Location = New System.Drawing.Point(156, 66)
        Me.lbl刃型サイズ一面角単位.Name = "lbl刃型サイズ一面角単位"
        Me.lbl刃型サイズ一面角単位.Size = New System.Drawing.Size(14, 14)
        Me.lbl刃型サイズ一面角単位.TabIndex = 21
        Me.lbl刃型サイズ一面角単位.Text = "R"
        '
        'lbl刃型サイズ一面流れ方向単位
        '
        Me.lbl刃型サイズ一面流れ方向単位.AutoSize = True
        Me.lbl刃型サイズ一面流れ方向単位.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.lbl刃型サイズ一面流れ方向単位.Location = New System.Drawing.Point(171, 44)
        Me.lbl刃型サイズ一面流れ方向単位.Name = "lbl刃型サイズ一面流れ方向単位"
        Me.lbl刃型サイズ一面流れ方向単位.Size = New System.Drawing.Size(21, 14)
        Me.lbl刃型サイズ一面流れ方向単位.TabIndex = 20
        Me.lbl刃型サイズ一面流れ方向単位.Text = "mm"
        '
        'lbl刃型サイズ一面角
        '
        Me.lbl刃型サイズ一面角.AutoSize = True
        Me.lbl刃型サイズ一面角.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.lbl刃型サイズ一面角.Location = New System.Drawing.Point(14, 66)
        Me.lbl刃型サイズ一面角.Name = "lbl刃型サイズ一面角"
        Me.lbl刃型サイズ一面角.Size = New System.Drawing.Size(21, 14)
        Me.lbl刃型サイズ一面角.TabIndex = 19
        Me.lbl刃型サイズ一面角.Text = "角"
        '
        'lbl刃型サイズ一面流れ方向
        '
        Me.lbl刃型サイズ一面流れ方向.AutoSize = True
        Me.lbl刃型サイズ一面流れ方向.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.lbl刃型サイズ一面流れ方向.Location = New System.Drawing.Point(14, 44)
        Me.lbl刃型サイズ一面流れ方向.Name = "lbl刃型サイズ一面流れ方向"
        Me.lbl刃型サイズ一面流れ方向.Size = New System.Drawing.Size(63, 14)
        Me.lbl刃型サイズ一面流れ方向.TabIndex = 18
        Me.lbl刃型サイズ一面流れ方向.Text = "流れ方向"
        '
        'txt刃型サイズ一面角
        '
        Me.txt刃型サイズ一面角.FieldLockType = BaseContents.Field.LockType.None
        Me.txt刃型サイズ一面角.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt刃型サイズ一面角.HelpKeys = ""
        Me.txt刃型サイズ一面角.HelpLink = ""
        Me.txt刃型サイズ一面角.HelpType = NodeUI.Help.Type.None
        Me.txt刃型サイズ一面角.IsError = False
        Me.txt刃型サイズ一面角.Location = New System.Drawing.Point(108, 62)
        Me.txt刃型サイズ一面角.Name = "txt刃型サイズ一面角"
        Me.txt刃型サイズ一面角.Required = False
        Me.txt刃型サイズ一面角.Size = New System.Drawing.Size(42, 23)
        Me.txt刃型サイズ一面角.TabIndex = 2
        Me.txt刃型サイズ一面角.Text = "12.0"
        Me.txt刃型サイズ一面角.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt刃型サイズ一面流れ方向
        '
        Me.txt刃型サイズ一面流れ方向.FieldLockType = BaseContents.Field.LockType.None
        Me.txt刃型サイズ一面流れ方向.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt刃型サイズ一面流れ方向.HelpKeys = ""
        Me.txt刃型サイズ一面流れ方向.HelpLink = ""
        Me.txt刃型サイズ一面流れ方向.HelpType = NodeUI.Help.Type.None
        Me.txt刃型サイズ一面流れ方向.IsError = False
        Me.txt刃型サイズ一面流れ方向.Location = New System.Drawing.Point(108, 40)
        Me.txt刃型サイズ一面流れ方向.Name = "txt刃型サイズ一面流れ方向"
        Me.txt刃型サイズ一面流れ方向.Required = False
        Me.txt刃型サイズ一面流れ方向.Size = New System.Drawing.Size(56, 23)
        Me.txt刃型サイズ一面流れ方向.TabIndex = 1
        Me.txt刃型サイズ一面流れ方向.Text = "123.00"
        Me.txt刃型サイズ一面流れ方向.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'lbl刃型サイズ一面紙幅方向
        '
        Me.lbl刃型サイズ一面紙幅方向.AutoSize = True
        Me.lbl刃型サイズ一面紙幅方向.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.lbl刃型サイズ一面紙幅方向.Location = New System.Drawing.Point(14, 22)
        Me.lbl刃型サイズ一面紙幅方向.Name = "lbl刃型サイズ一面紙幅方向"
        Me.lbl刃型サイズ一面紙幅方向.Size = New System.Drawing.Size(63, 14)
        Me.lbl刃型サイズ一面紙幅方向.TabIndex = 15
        Me.lbl刃型サイズ一面紙幅方向.Text = "紙幅方向"
        '
        'lbl刃型サイズ一面紙幅方向単位
        '
        Me.lbl刃型サイズ一面紙幅方向単位.AutoSize = True
        Me.lbl刃型サイズ一面紙幅方向単位.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.lbl刃型サイズ一面紙幅方向単位.Location = New System.Drawing.Point(171, 22)
        Me.lbl刃型サイズ一面紙幅方向単位.Name = "lbl刃型サイズ一面紙幅方向単位"
        Me.lbl刃型サイズ一面紙幅方向単位.Size = New System.Drawing.Size(21, 14)
        Me.lbl刃型サイズ一面紙幅方向単位.TabIndex = 14
        Me.lbl刃型サイズ一面紙幅方向単位.Text = "mm"
        '
        'txt刃型サイズ一面紙幅方向
        '
        Me.txt刃型サイズ一面紙幅方向.FieldLockType = BaseContents.Field.LockType.None
        Me.txt刃型サイズ一面紙幅方向.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt刃型サイズ一面紙幅方向.HelpKeys = ""
        Me.txt刃型サイズ一面紙幅方向.HelpLink = ""
        Me.txt刃型サイズ一面紙幅方向.HelpType = NodeUI.Help.Type.None
        Me.txt刃型サイズ一面紙幅方向.IsError = False
        Me.txt刃型サイズ一面紙幅方向.Location = New System.Drawing.Point(108, 18)
        Me.txt刃型サイズ一面紙幅方向.Name = "txt刃型サイズ一面紙幅方向"
        Me.txt刃型サイズ一面紙幅方向.Required = False
        Me.txt刃型サイズ一面紙幅方向.Size = New System.Drawing.Size(56, 23)
        Me.txt刃型サイズ一面紙幅方向.TabIndex = 0
        Me.txt刃型サイズ一面紙幅方向.Text = "123.00"
        Me.txt刃型サイズ一面紙幅方向.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp刃型情報
        '
        Me.grp刃型情報.Controls.Add(Me.lbl刃型情報バリヤ単位)
        Me.grp刃型情報.Controls.Add(Me.lbl刃型情報バリヤ)
        Me.grp刃型情報.Controls.Add(Me.txt刃型情報バリヤ)
        Me.grp刃型情報.Controls.Add(Me.lbl刃型情報総円周単位)
        Me.grp刃型情報.Controls.Add(Me.lbl刃型情報板厚単位)
        Me.grp刃型情報.Controls.Add(Me.lbl刃型情報総円周)
        Me.grp刃型情報.Controls.Add(Me.lbl刃型情報板厚)
        Me.grp刃型情報.Controls.Add(Me.txt刃型情報総円周)
        Me.grp刃型情報.Controls.Add(Me.txt刃型情報板厚)
        Me.grp刃型情報.Controls.Add(Me.lbl刃型情報ギヤ数)
        Me.grp刃型情報.Controls.Add(Me.lbl刃型情報ギヤ数単位)
        Me.grp刃型情報.Controls.Add(Me.txt刃型情報ギヤ数)
        Me.grp刃型情報.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.grp刃型情報.Location = New System.Drawing.Point(16, 78)
        Me.grp刃型情報.Name = "grp刃型情報"
        Me.grp刃型情報.Size = New System.Drawing.Size(215, 117)
        Me.grp刃型情報.TabIndex = 1
        Me.grp刃型情報.TabStop = False
        Me.grp刃型情報.Text = "刃型情報"
        '
        'lbl刃型情報バリヤ単位
        '
        Me.lbl刃型情報バリヤ単位.AutoSize = True
        Me.lbl刃型情報バリヤ単位.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.lbl刃型情報バリヤ単位.Location = New System.Drawing.Point(135, 87)
        Me.lbl刃型情報バリヤ単位.Name = "lbl刃型情報バリヤ単位"
        Me.lbl刃型情報バリヤ単位.Size = New System.Drawing.Size(21, 14)
        Me.lbl刃型情報バリヤ単位.TabIndex = 24
        Me.lbl刃型情報バリヤ単位.Text = "％"
        '
        'lbl刃型情報バリヤ
        '
        Me.lbl刃型情報バリヤ.AutoSize = True
        Me.lbl刃型情報バリヤ.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.lbl刃型情報バリヤ.Location = New System.Drawing.Point(14, 87)
        Me.lbl刃型情報バリヤ.Name = "lbl刃型情報バリヤ"
        Me.lbl刃型情報バリヤ.Size = New System.Drawing.Size(42, 14)
        Me.lbl刃型情報バリヤ.TabIndex = 23
        Me.lbl刃型情報バリヤ.Text = "ﾊﾞﾘﾔｰ"
        '
        'txt刃型情報バリヤ
        '
        Me.txt刃型情報バリヤ.FieldLockType = BaseContents.Field.LockType.None
        Me.txt刃型情報バリヤ.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt刃型情報バリヤ.HelpKeys = ""
        Me.txt刃型情報バリヤ.HelpLink = ""
        Me.txt刃型情報バリヤ.HelpType = NodeUI.Help.Type.None
        Me.txt刃型情報バリヤ.IsError = False
        Me.txt刃型情報バリヤ.Location = New System.Drawing.Point(77, 83)
        Me.txt刃型情報バリヤ.Name = "txt刃型情報バリヤ"
        Me.txt刃型情報バリヤ.Required = False
        Me.txt刃型情報バリヤ.Size = New System.Drawing.Size(56, 23)
        Me.txt刃型情報バリヤ.TabIndex = 3
        Me.txt刃型情報バリヤ.Text = "123.00"
        Me.txt刃型情報バリヤ.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'lbl刃型情報総円周単位
        '
        Me.lbl刃型情報総円周単位.AutoSize = True
        Me.lbl刃型情報総円周単位.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.lbl刃型情報総円周単位.Location = New System.Drawing.Point(169, 66)
        Me.lbl刃型情報総円周単位.Name = "lbl刃型情報総円周単位"
        Me.lbl刃型情報総円周単位.Size = New System.Drawing.Size(21, 14)
        Me.lbl刃型情報総円周単位.TabIndex = 21
        Me.lbl刃型情報総円周単位.Text = "mm"
        '
        'lbl刃型情報板厚単位
        '
        Me.lbl刃型情報板厚単位.AutoSize = True
        Me.lbl刃型情報板厚単位.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.lbl刃型情報板厚単位.Location = New System.Drawing.Point(140, 44)
        Me.lbl刃型情報板厚単位.Name = "lbl刃型情報板厚単位"
        Me.lbl刃型情報板厚単位.Size = New System.Drawing.Size(21, 14)
        Me.lbl刃型情報板厚単位.TabIndex = 20
        Me.lbl刃型情報板厚単位.Text = "mm"
        '
        'lbl刃型情報総円周
        '
        Me.lbl刃型情報総円周.AutoSize = True
        Me.lbl刃型情報総円周.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.lbl刃型情報総円周.Location = New System.Drawing.Point(14, 66)
        Me.lbl刃型情報総円周.Name = "lbl刃型情報総円周"
        Me.lbl刃型情報総円周.Size = New System.Drawing.Size(49, 14)
        Me.lbl刃型情報総円周.TabIndex = 19
        Me.lbl刃型情報総円周.Text = "総円周"
        '
        'lbl刃型情報板厚
        '
        Me.lbl刃型情報板厚.AutoSize = True
        Me.lbl刃型情報板厚.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.lbl刃型情報板厚.Location = New System.Drawing.Point(14, 44)
        Me.lbl刃型情報板厚.Name = "lbl刃型情報板厚"
        Me.lbl刃型情報板厚.Size = New System.Drawing.Size(35, 14)
        Me.lbl刃型情報板厚.TabIndex = 18
        Me.lbl刃型情報板厚.Text = "板厚"
        '
        'txt刃型情報総円周
        '
        Me.txt刃型情報総円周.FieldLockType = BaseContents.Field.LockType.None
        Me.txt刃型情報総円周.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt刃型情報総円周.HelpKeys = ""
        Me.txt刃型情報総円周.HelpLink = ""
        Me.txt刃型情報総円周.HelpType = NodeUI.Help.Type.None
        Me.txt刃型情報総円周.IsError = False
        Me.txt刃型情報総円周.Location = New System.Drawing.Point(77, 62)
        Me.txt刃型情報総円周.Name = "txt刃型情報総円周"
        Me.txt刃型情報総円周.Required = False
        Me.txt刃型情報総円周.Size = New System.Drawing.Size(86, 23)
        Me.txt刃型情報総円周.TabIndex = 2
        Me.txt刃型情報総円周.Text = "12,345.000"
        Me.txt刃型情報総円周.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt刃型情報板厚
        '
        Me.txt刃型情報板厚.FieldLockType = BaseContents.Field.LockType.None
        Me.txt刃型情報板厚.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt刃型情報板厚.HelpKeys = ""
        Me.txt刃型情報板厚.HelpLink = ""
        Me.txt刃型情報板厚.HelpType = NodeUI.Help.Type.None
        Me.txt刃型情報板厚.IsError = False
        Me.txt刃型情報板厚.Location = New System.Drawing.Point(77, 40)
        Me.txt刃型情報板厚.Name = "txt刃型情報板厚"
        Me.txt刃型情報板厚.Required = False
        Me.txt刃型情報板厚.Size = New System.Drawing.Size(56, 23)
        Me.txt刃型情報板厚.TabIndex = 1
        Me.txt刃型情報板厚.Text = "12.000"
        Me.txt刃型情報板厚.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'lbl刃型情報ギヤ数
        '
        Me.lbl刃型情報ギヤ数.AutoSize = True
        Me.lbl刃型情報ギヤ数.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.lbl刃型情報ギヤ数.Location = New System.Drawing.Point(14, 22)
        Me.lbl刃型情報ギヤ数.Name = "lbl刃型情報ギヤ数"
        Me.lbl刃型情報ギヤ数.Size = New System.Drawing.Size(42, 14)
        Me.lbl刃型情報ギヤ数.TabIndex = 15
        Me.lbl刃型情報ギヤ数.Text = "ｷﾞﾔ数"
        '
        'lbl刃型情報ギヤ数単位
        '
        Me.lbl刃型情報ギヤ数単位.AutoSize = True
        Me.lbl刃型情報ギヤ数単位.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.lbl刃型情報ギヤ数単位.Location = New System.Drawing.Point(119, 22)
        Me.lbl刃型情報ギヤ数単位.Name = "lbl刃型情報ギヤ数単位"
        Me.lbl刃型情報ギヤ数単位.Size = New System.Drawing.Size(28, 14)
        Me.lbl刃型情報ギヤ数単位.TabIndex = 14
        Me.lbl刃型情報ギヤ数単位.Text = "ｷﾞﾔ"
        '
        'txt刃型情報ギヤ数
        '
        Me.txt刃型情報ギヤ数.FieldLockType = BaseContents.Field.LockType.None
        Me.txt刃型情報ギヤ数.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt刃型情報ギヤ数.HelpKeys = ""
        Me.txt刃型情報ギヤ数.HelpLink = ""
        Me.txt刃型情報ギヤ数.HelpType = NodeUI.Help.Type.None
        Me.txt刃型情報ギヤ数.IsError = False
        Me.txt刃型情報ギヤ数.Location = New System.Drawing.Point(77, 18)
        Me.txt刃型情報ギヤ数.Name = "txt刃型情報ギヤ数"
        Me.txt刃型情報ギヤ数.Required = False
        Me.txt刃型情報ギヤ数.Size = New System.Drawing.Size(34, 23)
        Me.txt刃型情報ギヤ数.TabIndex = 0
        Me.txt刃型情報ギヤ数.Text = "123"
        Me.txt刃型情報ギヤ数.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp線幅
        '
        Me.grp線幅.Controls.Add(Me.lbl線幅トンボ単位)
        Me.grp線幅.Controls.Add(Me.lbl線幅原点単位)
        Me.grp線幅.Controls.Add(Me.lbl線幅トンボ)
        Me.grp線幅.Controls.Add(Me.lbl線幅原点)
        Me.grp線幅.Controls.Add(Me.txt線幅トンボ)
        Me.grp線幅.Controls.Add(Me.txt線幅原点)
        Me.grp線幅.Controls.Add(Me.lbl線幅刃型線)
        Me.grp線幅.Controls.Add(Me.lbl線幅刃型線単位)
        Me.grp線幅.Controls.Add(Me.txt線幅刃型線)
        Me.grp線幅.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.grp線幅.Location = New System.Drawing.Point(750, 108)
        Me.grp線幅.Name = "grp線幅"
        Me.grp線幅.Size = New System.Drawing.Size(215, 96)
        Me.grp線幅.TabIndex = 6
        Me.grp線幅.TabStop = False
        Me.grp線幅.Text = "線幅"
        '
        'lbl線幅トンボ単位
        '
        Me.lbl線幅トンボ単位.AutoSize = True
        Me.lbl線幅トンボ単位.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.lbl線幅トンボ単位.Location = New System.Drawing.Point(173, 66)
        Me.lbl線幅トンボ単位.Name = "lbl線幅トンボ単位"
        Me.lbl線幅トンボ単位.Size = New System.Drawing.Size(21, 14)
        Me.lbl線幅トンボ単位.TabIndex = 21
        Me.lbl線幅トンボ単位.Text = "mm"
        '
        'lbl線幅原点単位
        '
        Me.lbl線幅原点単位.AutoSize = True
        Me.lbl線幅原点単位.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.lbl線幅原点単位.Location = New System.Drawing.Point(173, 44)
        Me.lbl線幅原点単位.Name = "lbl線幅原点単位"
        Me.lbl線幅原点単位.Size = New System.Drawing.Size(21, 14)
        Me.lbl線幅原点単位.TabIndex = 20
        Me.lbl線幅原点単位.Text = "mm"
        '
        'lbl線幅トンボ
        '
        Me.lbl線幅トンボ.AutoSize = True
        Me.lbl線幅トンボ.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.lbl線幅トンボ.Location = New System.Drawing.Point(14, 66)
        Me.lbl線幅トンボ.Name = "lbl線幅トンボ"
        Me.lbl線幅トンボ.Size = New System.Drawing.Size(49, 14)
        Me.lbl線幅トンボ.TabIndex = 19
        Me.lbl線幅トンボ.Text = "トンボ"
        '
        'lbl線幅原点
        '
        Me.lbl線幅原点.AutoSize = True
        Me.lbl線幅原点.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.lbl線幅原点.Location = New System.Drawing.Point(14, 44)
        Me.lbl線幅原点.Name = "lbl線幅原点"
        Me.lbl線幅原点.Size = New System.Drawing.Size(35, 14)
        Me.lbl線幅原点.TabIndex = 18
        Me.lbl線幅原点.Text = "原点"
        '
        'txt線幅トンボ
        '
        Me.txt線幅トンボ.FieldLockType = BaseContents.Field.LockType.None
        Me.txt線幅トンボ.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt線幅トンボ.HelpKeys = ""
        Me.txt線幅トンボ.HelpLink = ""
        Me.txt線幅トンボ.HelpType = NodeUI.Help.Type.None
        Me.txt線幅トンボ.IsError = False
        Me.txt線幅トンボ.Location = New System.Drawing.Point(116, 62)
        Me.txt線幅トンボ.Name = "txt線幅トンボ"
        Me.txt線幅トンボ.Required = False
        Me.txt線幅トンボ.Size = New System.Drawing.Size(46, 23)
        Me.txt線幅トンボ.TabIndex = 2
        Me.txt線幅トンボ.Text = "12.00"
        Me.txt線幅トンボ.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt線幅原点
        '
        Me.txt線幅原点.FieldLockType = BaseContents.Field.LockType.None
        Me.txt線幅原点.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt線幅原点.HelpKeys = ""
        Me.txt線幅原点.HelpLink = ""
        Me.txt線幅原点.HelpType = NodeUI.Help.Type.None
        Me.txt線幅原点.IsError = False
        Me.txt線幅原点.Location = New System.Drawing.Point(116, 40)
        Me.txt線幅原点.Name = "txt線幅原点"
        Me.txt線幅原点.Required = False
        Me.txt線幅原点.Size = New System.Drawing.Size(46, 23)
        Me.txt線幅原点.TabIndex = 1
        Me.txt線幅原点.Text = "12.00"
        Me.txt線幅原点.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'lbl線幅刃型線
        '
        Me.lbl線幅刃型線.AutoSize = True
        Me.lbl線幅刃型線.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.lbl線幅刃型線.Location = New System.Drawing.Point(14, 22)
        Me.lbl線幅刃型線.Name = "lbl線幅刃型線"
        Me.lbl線幅刃型線.Size = New System.Drawing.Size(49, 14)
        Me.lbl線幅刃型線.TabIndex = 15
        Me.lbl線幅刃型線.Text = "刃型線"
        '
        'lbl線幅刃型線単位
        '
        Me.lbl線幅刃型線単位.AutoSize = True
        Me.lbl線幅刃型線単位.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.lbl線幅刃型線単位.Location = New System.Drawing.Point(173, 22)
        Me.lbl線幅刃型線単位.Name = "lbl線幅刃型線単位"
        Me.lbl線幅刃型線単位.Size = New System.Drawing.Size(21, 14)
        Me.lbl線幅刃型線単位.TabIndex = 14
        Me.lbl線幅刃型線単位.Text = "mm"
        '
        'txt線幅刃型線
        '
        Me.txt線幅刃型線.FieldLockType = BaseContents.Field.LockType.None
        Me.txt線幅刃型線.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt線幅刃型線.HelpKeys = ""
        Me.txt線幅刃型線.HelpLink = ""
        Me.txt線幅刃型線.HelpType = NodeUI.Help.Type.None
        Me.txt線幅刃型線.IsError = False
        Me.txt線幅刃型線.Location = New System.Drawing.Point(116, 18)
        Me.txt線幅刃型線.Name = "txt線幅刃型線"
        Me.txt線幅刃型線.Required = False
        Me.txt線幅刃型線.Size = New System.Drawing.Size(46, 23)
        Me.txt線幅刃型線.TabIndex = 0
        Me.txt線幅刃型線.Text = "12.00"
        Me.txt線幅刃型線.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp刃型サイズ全体
        '
        Me.grp刃型サイズ全体.Controls.Add(Me.lbl刃型サイズ全体流れ方向単位)
        Me.grp刃型サイズ全体.Controls.Add(Me.lbl刃型サイズ全体流れ方向下)
        Me.grp刃型サイズ全体.Controls.Add(Me.txt刃型サイズ全体流れ方向)
        Me.grp刃型サイズ全体.Controls.Add(Me.lbl刃型サイズ全体流れ方向上)
        Me.grp刃型サイズ全体.Controls.Add(Me.lbl刃型サイズ全体紙幅方向)
        Me.grp刃型サイズ全体.Controls.Add(Me.lbl刃型サイズ全体紙幅方向単位)
        Me.grp刃型サイズ全体.Controls.Add(Me.txt刃型サイズ全体紙幅方向)
        Me.grp刃型サイズ全体.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.grp刃型サイズ全体.Location = New System.Drawing.Point(750, 22)
        Me.grp刃型サイズ全体.Name = "grp刃型サイズ全体"
        Me.grp刃型サイズ全体.Size = New System.Drawing.Size(215, 72)
        Me.grp刃型サイズ全体.TabIndex = 5
        Me.grp刃型サイズ全体.TabStop = False
        Me.grp刃型サイズ全体.Text = "刃型ｻｲｽﾞ(全体)"
        '
        'lbl刃型サイズ全体流れ方向単位
        '
        Me.lbl刃型サイズ全体流れ方向単位.AutoSize = True
        Me.lbl刃型サイズ全体流れ方向単位.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.lbl刃型サイズ全体流れ方向単位.Location = New System.Drawing.Point(173, 45)
        Me.lbl刃型サイズ全体流れ方向単位.Name = "lbl刃型サイズ全体流れ方向単位"
        Me.lbl刃型サイズ全体流れ方向単位.Size = New System.Drawing.Size(21, 14)
        Me.lbl刃型サイズ全体流れ方向単位.TabIndex = 19
        Me.lbl刃型サイズ全体流れ方向単位.Text = "mm"
        '
        'lbl刃型サイズ全体流れ方向下
        '
        Me.lbl刃型サイズ全体流れ方向下.AutoSize = True
        Me.lbl刃型サイズ全体流れ方向下.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.lbl刃型サイズ全体流れ方向下.Location = New System.Drawing.Point(16, 55)
        Me.lbl刃型サイズ全体流れ方向下.Name = "lbl刃型サイズ全体流れ方向下"
        Me.lbl刃型サイズ全体流れ方向下.Size = New System.Drawing.Size(59, 12)
        Me.lbl刃型サイズ全体流れ方向下.TabIndex = 18
        Me.lbl刃型サイズ全体流れ方向下.Text = "(ﾊﾞﾘﾔｰ後)"
        '
        'txt刃型サイズ全体流れ方向
        '
        Me.txt刃型サイズ全体流れ方向.FieldLockType = BaseContents.Field.LockType.None
        Me.txt刃型サイズ全体流れ方向.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt刃型サイズ全体流れ方向.HelpKeys = ""
        Me.txt刃型サイズ全体流れ方向.HelpLink = ""
        Me.txt刃型サイズ全体流れ方向.HelpType = NodeUI.Help.Type.None
        Me.txt刃型サイズ全体流れ方向.IsError = False
        Me.txt刃型サイズ全体流れ方向.Location = New System.Drawing.Point(91, 41)
        Me.txt刃型サイズ全体流れ方向.Name = "txt刃型サイズ全体流れ方向"
        Me.txt刃型サイズ全体流れ方向.Required = False
        Me.txt刃型サイズ全体流れ方向.Size = New System.Drawing.Size(78, 23)
        Me.txt刃型サイズ全体流れ方向.TabIndex = 1
        Me.txt刃型サイズ全体流れ方向.Text = "1,234.000"
        Me.txt刃型サイズ全体流れ方向.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'lbl刃型サイズ全体流れ方向上
        '
        Me.lbl刃型サイズ全体流れ方向上.AutoSize = True
        Me.lbl刃型サイズ全体流れ方向上.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.lbl刃型サイズ全体流れ方向上.Location = New System.Drawing.Point(15, 40)
        Me.lbl刃型サイズ全体流れ方向上.Name = "lbl刃型サイズ全体流れ方向上"
        Me.lbl刃型サイズ全体流れ方向上.Size = New System.Drawing.Size(53, 12)
        Me.lbl刃型サイズ全体流れ方向上.TabIndex = 16
        Me.lbl刃型サイズ全体流れ方向上.Text = "流れ方向"
        '
        'lbl刃型サイズ全体紙幅方向
        '
        Me.lbl刃型サイズ全体紙幅方向.AutoSize = True
        Me.lbl刃型サイズ全体紙幅方向.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.lbl刃型サイズ全体紙幅方向.Location = New System.Drawing.Point(14, 22)
        Me.lbl刃型サイズ全体紙幅方向.Name = "lbl刃型サイズ全体紙幅方向"
        Me.lbl刃型サイズ全体紙幅方向.Size = New System.Drawing.Size(63, 14)
        Me.lbl刃型サイズ全体紙幅方向.TabIndex = 15
        Me.lbl刃型サイズ全体紙幅方向.Text = "紙幅方向"
        '
        'lbl刃型サイズ全体紙幅方向単位
        '
        Me.lbl刃型サイズ全体紙幅方向単位.AutoSize = True
        Me.lbl刃型サイズ全体紙幅方向単位.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.lbl刃型サイズ全体紙幅方向単位.Location = New System.Drawing.Point(173, 22)
        Me.lbl刃型サイズ全体紙幅方向単位.Name = "lbl刃型サイズ全体紙幅方向単位"
        Me.lbl刃型サイズ全体紙幅方向単位.Size = New System.Drawing.Size(21, 14)
        Me.lbl刃型サイズ全体紙幅方向単位.TabIndex = 14
        Me.lbl刃型サイズ全体紙幅方向単位.Text = "mm"
        '
        'txt刃型サイズ全体紙幅方向
        '
        Me.txt刃型サイズ全体紙幅方向.FieldLockType = BaseContents.Field.LockType.None
        Me.txt刃型サイズ全体紙幅方向.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt刃型サイズ全体紙幅方向.HelpKeys = ""
        Me.txt刃型サイズ全体紙幅方向.HelpLink = ""
        Me.txt刃型サイズ全体紙幅方向.HelpType = NodeUI.Help.Type.None
        Me.txt刃型サイズ全体紙幅方向.IsError = False
        Me.txt刃型サイズ全体紙幅方向.Location = New System.Drawing.Point(91, 18)
        Me.txt刃型サイズ全体紙幅方向.Name = "txt刃型サイズ全体紙幅方向"
        Me.txt刃型サイズ全体紙幅方向.Required = False
        Me.txt刃型サイズ全体紙幅方向.Size = New System.Drawing.Size(78, 23)
        Me.txt刃型サイズ全体紙幅方向.TabIndex = 0
        Me.txt刃型サイズ全体紙幅方向.Text = "1,234.000"
        Me.txt刃型サイズ全体紙幅方向.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp面付
        '
        Me.grp面付.Controls.Add(Me.grp面付流れ方向)
        Me.grp面付.Controls.Add(Me.grp面付紙幅方向)
        Me.grp面付.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.grp面付.Location = New System.Drawing.Point(483, 22)
        Me.grp面付.Name = "grp面付"
        Me.grp面付.Size = New System.Drawing.Size(246, 182)
        Me.grp面付.TabIndex = 4
        Me.grp面付.TabStop = False
        Me.grp面付.Text = "面付"
        '
        'grp面付流れ方向
        '
        Me.grp面付流れ方向.Controls.Add(Me.lbl面付流れ方向ドブ寸法)
        Me.grp面付流れ方向.Controls.Add(Me.lbl面付流れ方向ドブ寸法単位)
        Me.grp面付流れ方向.Controls.Add(Me.txt面付流れ方向ドブ寸法)
        Me.grp面付流れ方向.Controls.Add(Me.lbl面付流れ方向面数単位)
        Me.grp面付流れ方向.Controls.Add(Me.txt面付流れ方向面数)
        Me.grp面付流れ方向.Controls.Add(Me.lbl面付流れ方向面数)
        Me.grp面付流れ方向.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.grp面付流れ方向.Location = New System.Drawing.Point(13, 101)
        Me.grp面付流れ方向.Name = "grp面付流れ方向"
        Me.grp面付流れ方向.Size = New System.Drawing.Size(220, 72)
        Me.grp面付流れ方向.TabIndex = 1
        Me.grp面付流れ方向.TabStop = False
        Me.grp面付流れ方向.Text = "流れ方向"
        '
        'lbl面付流れ方向ドブ寸法
        '
        Me.lbl面付流れ方向ドブ寸法.AutoSize = True
        Me.lbl面付流れ方向ドブ寸法.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.lbl面付流れ方向ドブ寸法.Location = New System.Drawing.Point(17, 46)
        Me.lbl面付流れ方向ドブ寸法.Name = "lbl面付流れ方向ドブ寸法"
        Me.lbl面付流れ方向ドブ寸法.Size = New System.Drawing.Size(63, 14)
        Me.lbl面付流れ方向ドブ寸法.TabIndex = 15
        Me.lbl面付流れ方向ドブ寸法.Text = "ﾄﾞﾌﾞ寸法"
        '
        'lbl面付流れ方向ドブ寸法単位
        '
        Me.lbl面付流れ方向ドブ寸法単位.AutoSize = True
        Me.lbl面付流れ方向ドブ寸法単位.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.lbl面付流れ方向ドブ寸法単位.Location = New System.Drawing.Point(169, 46)
        Me.lbl面付流れ方向ドブ寸法単位.Name = "lbl面付流れ方向ドブ寸法単位"
        Me.lbl面付流れ方向ドブ寸法単位.Size = New System.Drawing.Size(21, 14)
        Me.lbl面付流れ方向ドブ寸法単位.TabIndex = 14
        Me.lbl面付流れ方向ドブ寸法単位.Text = "mm"
        '
        'txt面付流れ方向ドブ寸法
        '
        Me.txt面付流れ方向ドブ寸法.FieldLockType = BaseContents.Field.LockType.None
        Me.txt面付流れ方向ドブ寸法.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt面付流れ方向ドブ寸法.HelpKeys = ""
        Me.txt面付流れ方向ドブ寸法.HelpLink = ""
        Me.txt面付流れ方向ドブ寸法.HelpType = NodeUI.Help.Type.None
        Me.txt面付流れ方向ドブ寸法.IsError = False
        Me.txt面付流れ方向ドブ寸法.Location = New System.Drawing.Point(101, 42)
        Me.txt面付流れ方向ドブ寸法.Name = "txt面付流れ方向ドブ寸法"
        Me.txt面付流れ方向ドブ寸法.Required = False
        Me.txt面付流れ方向ドブ寸法.Size = New System.Drawing.Size(64, 23)
        Me.txt面付流れ方向ドブ寸法.TabIndex = 1
        Me.txt面付流れ方向ドブ寸法.Text = "123.000"
        Me.txt面付流れ方向ドブ寸法.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'lbl面付流れ方向面数単位
        '
        Me.lbl面付流れ方向面数単位.AutoSize = True
        Me.lbl面付流れ方向面数単位.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.lbl面付流れ方向面数単位.Location = New System.Drawing.Point(129, 22)
        Me.lbl面付流れ方向面数単位.Name = "lbl面付流れ方向面数単位"
        Me.lbl面付流れ方向面数単位.Size = New System.Drawing.Size(21, 14)
        Me.lbl面付流れ方向面数単位.TabIndex = 12
        Me.lbl面付流れ方向面数単位.Text = "面"
        '
        'txt面付流れ方向面数
        '
        Me.txt面付流れ方向面数.FieldLockType = BaseContents.Field.LockType.None
        Me.txt面付流れ方向面数.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt面付流れ方向面数.HelpKeys = ""
        Me.txt面付流れ方向面数.HelpLink = ""
        Me.txt面付流れ方向面数.HelpType = NodeUI.Help.Type.None
        Me.txt面付流れ方向面数.IsError = False
        Me.txt面付流れ方向面数.Location = New System.Drawing.Point(100, 18)
        Me.txt面付流れ方向面数.Name = "txt面付流れ方向面数"
        Me.txt面付流れ方向面数.Required = False
        Me.txt面付流れ方向面数.Size = New System.Drawing.Size(24, 23)
        Me.txt面付流れ方向面数.TabIndex = 0
        Me.txt面付流れ方向面数.Text = "XX"
        Me.txt面付流れ方向面数.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'lbl面付流れ方向面数
        '
        Me.lbl面付流れ方向面数.AutoSize = True
        Me.lbl面付流れ方向面数.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.lbl面付流れ方向面数.Location = New System.Drawing.Point(17, 22)
        Me.lbl面付流れ方向面数.Name = "lbl面付流れ方向面数"
        Me.lbl面付流れ方向面数.Size = New System.Drawing.Size(35, 14)
        Me.lbl面付流れ方向面数.TabIndex = 10
        Me.lbl面付流れ方向面数.Text = "面数"
        '
        'grp面付紙幅方向
        '
        Me.grp面付紙幅方向.Controls.Add(Me.lbl面付紙幅方向ドブ寸法)
        Me.grp面付紙幅方向.Controls.Add(Me.lbl面付紙幅方向ドブ寸法単位)
        Me.grp面付紙幅方向.Controls.Add(Me.txt面付紙幅方向ドブ寸法)
        Me.grp面付紙幅方向.Controls.Add(Me.lbl面付紙幅方向面数単位)
        Me.grp面付紙幅方向.Controls.Add(Me.txt面付紙幅方向面数)
        Me.grp面付紙幅方向.Controls.Add(Me.lbl面付紙幅方向面数)
        Me.grp面付紙幅方向.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.grp面付紙幅方向.Location = New System.Drawing.Point(13, 18)
        Me.grp面付紙幅方向.Name = "grp面付紙幅方向"
        Me.grp面付紙幅方向.Size = New System.Drawing.Size(220, 72)
        Me.grp面付紙幅方向.TabIndex = 0
        Me.grp面付紙幅方向.TabStop = False
        Me.grp面付紙幅方向.Text = "紙幅方向"
        '
        'lbl面付紙幅方向ドブ寸法
        '
        Me.lbl面付紙幅方向ドブ寸法.AutoSize = True
        Me.lbl面付紙幅方向ドブ寸法.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.lbl面付紙幅方向ドブ寸法.Location = New System.Drawing.Point(17, 46)
        Me.lbl面付紙幅方向ドブ寸法.Name = "lbl面付紙幅方向ドブ寸法"
        Me.lbl面付紙幅方向ドブ寸法.Size = New System.Drawing.Size(63, 14)
        Me.lbl面付紙幅方向ドブ寸法.TabIndex = 15
        Me.lbl面付紙幅方向ドブ寸法.Text = "ﾄﾞﾌﾞ寸法"
        '
        'lbl面付紙幅方向ドブ寸法単位
        '
        Me.lbl面付紙幅方向ドブ寸法単位.AutoSize = True
        Me.lbl面付紙幅方向ドブ寸法単位.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.lbl面付紙幅方向ドブ寸法単位.Location = New System.Drawing.Point(169, 46)
        Me.lbl面付紙幅方向ドブ寸法単位.Name = "lbl面付紙幅方向ドブ寸法単位"
        Me.lbl面付紙幅方向ドブ寸法単位.Size = New System.Drawing.Size(21, 14)
        Me.lbl面付紙幅方向ドブ寸法単位.TabIndex = 14
        Me.lbl面付紙幅方向ドブ寸法単位.Text = "mm"
        '
        'txt面付紙幅方向ドブ寸法
        '
        Me.txt面付紙幅方向ドブ寸法.FieldLockType = BaseContents.Field.LockType.None
        Me.txt面付紙幅方向ドブ寸法.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt面付紙幅方向ドブ寸法.HelpKeys = ""
        Me.txt面付紙幅方向ドブ寸法.HelpLink = ""
        Me.txt面付紙幅方向ドブ寸法.HelpType = NodeUI.Help.Type.None
        Me.txt面付紙幅方向ドブ寸法.IsError = False
        Me.txt面付紙幅方向ドブ寸法.Location = New System.Drawing.Point(101, 42)
        Me.txt面付紙幅方向ドブ寸法.Name = "txt面付紙幅方向ドブ寸法"
        Me.txt面付紙幅方向ドブ寸法.Required = False
        Me.txt面付紙幅方向ドブ寸法.Size = New System.Drawing.Size(64, 23)
        Me.txt面付紙幅方向ドブ寸法.TabIndex = 1
        Me.txt面付紙幅方向ドブ寸法.Text = "123.000"
        Me.txt面付紙幅方向ドブ寸法.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'lbl面付紙幅方向面数単位
        '
        Me.lbl面付紙幅方向面数単位.AutoSize = True
        Me.lbl面付紙幅方向面数単位.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.lbl面付紙幅方向面数単位.Location = New System.Drawing.Point(129, 22)
        Me.lbl面付紙幅方向面数単位.Name = "lbl面付紙幅方向面数単位"
        Me.lbl面付紙幅方向面数単位.Size = New System.Drawing.Size(21, 14)
        Me.lbl面付紙幅方向面数単位.TabIndex = 12
        Me.lbl面付紙幅方向面数単位.Text = "面"
        '
        'txt面付紙幅方向面数
        '
        Me.txt面付紙幅方向面数.FieldLockType = BaseContents.Field.LockType.None
        Me.txt面付紙幅方向面数.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt面付紙幅方向面数.HelpKeys = ""
        Me.txt面付紙幅方向面数.HelpLink = ""
        Me.txt面付紙幅方向面数.HelpType = NodeUI.Help.Type.None
        Me.txt面付紙幅方向面数.IsError = False
        Me.txt面付紙幅方向面数.Location = New System.Drawing.Point(100, 18)
        Me.txt面付紙幅方向面数.Name = "txt面付紙幅方向面数"
        Me.txt面付紙幅方向面数.Required = False
        Me.txt面付紙幅方向面数.Size = New System.Drawing.Size(24, 23)
        Me.txt面付紙幅方向面数.TabIndex = 0
        Me.txt面付紙幅方向面数.Text = "XX"
        Me.txt面付紙幅方向面数.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'lbl面付紙幅方向面数
        '
        Me.lbl面付紙幅方向面数.AutoSize = True
        Me.lbl面付紙幅方向面数.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.lbl面付紙幅方向面数.Location = New System.Drawing.Point(17, 22)
        Me.lbl面付紙幅方向面数.Name = "lbl面付紙幅方向面数"
        Me.lbl面付紙幅方向面数.Size = New System.Drawing.Size(35, 14)
        Me.lbl面付紙幅方向面数.TabIndex = 10
        Me.lbl面付紙幅方向面数.Text = "面数"
        '
        'grpバリヤ表
        '
        Me.grpバリヤ表.Controls.Add(Me.namバリヤ表区分名)
        Me.grpバリヤ表.Controls.Add(Me.txtバリヤ表区分)
        Me.grpバリヤ表.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.grpバリヤ表.Location = New System.Drawing.Point(246, 22)
        Me.grpバリヤ表.Name = "grpバリヤ表"
        Me.grpバリヤ表.Size = New System.Drawing.Size(218, 50)
        Me.grpバリヤ表.TabIndex = 2
        Me.grpバリヤ表.TabStop = False
        Me.grpバリヤ表.Text = "ﾊﾞﾘﾔｰ表"
        '
        'namバリヤ表区分名
        '
        Me.namバリヤ表区分名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.namバリヤ表区分名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.namバリヤ表区分名.Location = New System.Drawing.Point(35, 18)
        Me.namバリヤ表区分名.Name = "namバリヤ表区分名"
        Me.namバリヤ表区分名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.namバリヤ表区分名.Size = New System.Drawing.Size(170, 23)
        Me.namバリヤ表区分名.StringLength = 0
        Me.namバリヤ表区分名.TabIndex = 9
        Me.namバリヤ表区分名.Text = "*XXXXXXXXXXXXXXXXXX*"
        Me.namバリヤ表区分名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txtバリヤ表区分
        '
        Me.txtバリヤ表区分.FieldLockType = BaseContents.Field.LockType.None
        Me.txtバリヤ表区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txtバリヤ表区分.HelpKeys = ""
        Me.txtバリヤ表区分.HelpLink = ""
        Me.txtバリヤ表区分.HelpType = NodeUI.Help.Type.None
        Me.txtバリヤ表区分.IsError = False
        Me.txtバリヤ表区分.Location = New System.Drawing.Point(10, 18)
        Me.txtバリヤ表区分.Name = "txtバリヤ表区分"
        Me.txtバリヤ表区分.Required = False
        Me.txtバリヤ表区分.Size = New System.Drawing.Size(24, 23)
        Me.txtバリヤ表区分.TabIndex = 0
        Me.txtバリヤ表区分.Text = "XX"
        Me.txtバリヤ表区分.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grpフレキ機械種別
        '
        Me.grpフレキ機械種別.Controls.Add(Me.ddlフレキ機械種別区分)
        Me.grpフレキ機械種別.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.grpフレキ機械種別.Location = New System.Drawing.Point(15, 22)
        Me.grpフレキ機械種別.Name = "grpフレキ機械種別"
        Me.grpフレキ機械種別.Size = New System.Drawing.Size(215, 50)
        Me.grpフレキ機械種別.TabIndex = 0
        Me.grpフレキ機械種別.TabStop = False
        Me.grpフレキ機械種別.Text = "機械種"
        '
        'ddlフレキ機械種別区分
        '
        Me.ddlフレキ機械種別区分.AutoDropDown = True
        Me.ddlフレキ機械種別区分.DisplayMember = "Display"
        Me.ddlフレキ機械種別区分.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddlフレキ機械種別区分.FieldLockType = BaseContents.Field.LockType.None
        Me.ddlフレキ機械種別区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.ddlフレキ機械種別区分.FormattingEnabled = True
        Me.ddlフレキ機械種別区分.IsError = False
        Me.ddlフレキ機械種別区分.ListType = NodeUI.List.Type.None
        Me.ddlフレキ機械種別区分.Location = New System.Drawing.Point(8, 18)
        Me.ddlフレキ機械種別区分.Name = "ddlフレキ機械種別区分"
        Me.ddlフレキ機械種別区分.Required = False
        Me.ddlフレキ機械種別区分.Size = New System.Drawing.Size(190, 24)
        Me.ddlフレキ機械種別区分.TabIndex = 0
        Me.ddlフレキ機械種別区分.ValueMember = "Value"
        '
        'grp注意事項
        '
        Me.grp注意事項.Controls.Add(Me.txt注意事項05)
        Me.grp注意事項.Controls.Add(Me.txt注意事項04)
        Me.grp注意事項.Controls.Add(Me.txt注意事項03)
        Me.grp注意事項.Controls.Add(Me.txt注意事項02)
        Me.grp注意事項.Controls.Add(Me.txt注意事項01)
        Me.grp注意事項.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp注意事項.Location = New System.Drawing.Point(8, 469)
        Me.grp注意事項.Name = "grp注意事項"
        Me.grp注意事項.Size = New System.Drawing.Size(380, 154)
        Me.grp注意事項.TabIndex = 20
        Me.grp注意事項.TabStop = False
        Me.grp注意事項.Text = "【注意事項】"
        '
        'txt注意事項05
        '
        Me.txt注意事項05.FieldLockType = BaseContents.Field.LockType.None
        Me.txt注意事項05.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt注意事項05.HelpKeys = ""
        Me.txt注意事項05.HelpLink = ""
        Me.txt注意事項05.HelpType = NodeUI.Help.Type.None
        Me.txt注意事項05.IsError = False
        Me.txt注意事項05.Location = New System.Drawing.Point(10, 117)
        Me.txt注意事項05.Name = "txt注意事項05"
        Me.txt注意事項05.Required = False
        Me.txt注意事項05.Size = New System.Drawing.Size(335, 23)
        Me.txt注意事項05.TabIndex = 4
        Me.txt注意事項05.Text = "*XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX*"
        Me.txt注意事項05.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt注意事項04
        '
        Me.txt注意事項04.FieldLockType = BaseContents.Field.LockType.None
        Me.txt注意事項04.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt注意事項04.HelpKeys = ""
        Me.txt注意事項04.HelpLink = ""
        Me.txt注意事項04.HelpType = NodeUI.Help.Type.None
        Me.txt注意事項04.IsError = False
        Me.txt注意事項04.Location = New System.Drawing.Point(10, 94)
        Me.txt注意事項04.Name = "txt注意事項04"
        Me.txt注意事項04.Required = False
        Me.txt注意事項04.Size = New System.Drawing.Size(335, 23)
        Me.txt注意事項04.TabIndex = 3
        Me.txt注意事項04.Text = "*XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX*"
        Me.txt注意事項04.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt注意事項03
        '
        Me.txt注意事項03.FieldLockType = BaseContents.Field.LockType.None
        Me.txt注意事項03.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt注意事項03.HelpKeys = ""
        Me.txt注意事項03.HelpLink = ""
        Me.txt注意事項03.HelpType = NodeUI.Help.Type.None
        Me.txt注意事項03.IsError = False
        Me.txt注意事項03.Location = New System.Drawing.Point(10, 72)
        Me.txt注意事項03.Name = "txt注意事項03"
        Me.txt注意事項03.Required = False
        Me.txt注意事項03.Size = New System.Drawing.Size(335, 23)
        Me.txt注意事項03.TabIndex = 2
        Me.txt注意事項03.Text = "*XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX*"
        Me.txt注意事項03.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt注意事項02
        '
        Me.txt注意事項02.FieldLockType = BaseContents.Field.LockType.None
        Me.txt注意事項02.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt注意事項02.HelpKeys = ""
        Me.txt注意事項02.HelpLink = ""
        Me.txt注意事項02.HelpType = NodeUI.Help.Type.None
        Me.txt注意事項02.IsError = False
        Me.txt注意事項02.Location = New System.Drawing.Point(10, 49)
        Me.txt注意事項02.Name = "txt注意事項02"
        Me.txt注意事項02.Required = False
        Me.txt注意事項02.Size = New System.Drawing.Size(335, 23)
        Me.txt注意事項02.TabIndex = 1
        Me.txt注意事項02.Text = "*XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX*"
        Me.txt注意事項02.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt注意事項01
        '
        Me.txt注意事項01.FieldLockType = BaseContents.Field.LockType.None
        Me.txt注意事項01.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt注意事項01.HelpKeys = ""
        Me.txt注意事項01.HelpLink = ""
        Me.txt注意事項01.HelpType = NodeUI.Help.Type.None
        Me.txt注意事項01.IsError = False
        Me.txt注意事項01.Location = New System.Drawing.Point(10, 26)
        Me.txt注意事項01.Name = "txt注意事項01"
        Me.txt注意事項01.Required = False
        Me.txt注意事項01.Size = New System.Drawing.Size(335, 23)
        Me.txt注意事項01.TabIndex = 0
        Me.txt注意事項01.Text = "*XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX*"
        Me.txt注意事項01.TextStyle = BaseContents.TextBox.TextStyle.None
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
        Me.grp出荷先.Location = New System.Drawing.Point(413, 469)
        Me.grp出荷先.Name = "grp出荷先"
        Me.grp出荷先.Size = New System.Drawing.Size(346, 131)
        Me.grp出荷先.TabIndex = 21
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
        'frmFlexBlade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.grp出荷先)
        Me.Controls.Add(Me.grp注意事項)
        Me.Controls.Add(Me.grp刃型情報大枠)
        Me.Controls.Add(Me.grp仕入情報)
        Me.Controls.Add(Me.txt受注金額)
        Me.Controls.Add(Me.nam受注金額)
        Me.Controls.Add(Me.grp担当者)
        Me.Controls.Add(Me.grp台紙)
        Me.Controls.Add(Me.grp顧客刃型番号)
        Me.Controls.Add(Me.grp刃型区分)
        Me.Controls.Add(Me.grp代表商品名)
        Me.Controls.Add(Me.grp請求先CD)
        Me.Controls.Add(Me.grp得意先CD)
        Me.Controls.Add(Me.grp納品日付B)
        Me.Controls.Add(Me.grp機番)
        Me.Controls.Add(Me.grp御客様NO)
        Me.Controls.Add(Me.grp受注日付)
        Me.Controls.Add(Me.grp本台帳NO)
        Me.Controls.Add(Me.grp社内外区分)
        Me.Controls.Add(Me.nam受注単価)
        Me.Controls.Add(Me.txt受注単価)
        Me.Controls.Add(Me.txt受注数合計)
        Me.Controls.Add(Me.nam受注数合計)
        Me.Controls.Add(Me.grp作業NO)
        Me.Controls.Add(Me.grp処理区分)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmFlexBlade"
        Me.Controls.SetChildIndex(Me.grp処理区分, 0)
        Me.Controls.SetChildIndex(Me.grp作業NO, 0)
        Me.Controls.SetChildIndex(Me.nam受注数合計, 0)
        Me.Controls.SetChildIndex(Me.txt受注数合計, 0)
        Me.Controls.SetChildIndex(Me.txt受注単価, 0)
        Me.Controls.SetChildIndex(Me.nam受注単価, 0)
        Me.Controls.SetChildIndex(Me.grp社内外区分, 0)
        Me.Controls.SetChildIndex(Me.grp本台帳NO, 0)
        Me.Controls.SetChildIndex(Me.grp受注日付, 0)
        Me.Controls.SetChildIndex(Me.grp御客様NO, 0)
        Me.Controls.SetChildIndex(Me.grp機番, 0)
        Me.Controls.SetChildIndex(Me.grp納品日付B, 0)
        Me.Controls.SetChildIndex(Me.grp得意先CD, 0)
        Me.Controls.SetChildIndex(Me.grp請求先CD, 0)
        Me.Controls.SetChildIndex(Me.grp代表商品名, 0)
        Me.Controls.SetChildIndex(Me.grp刃型区分, 0)
        Me.Controls.SetChildIndex(Me.grp顧客刃型番号, 0)
        Me.Controls.SetChildIndex(Me.grp台紙, 0)
        Me.Controls.SetChildIndex(Me.grp担当者, 0)
        Me.Controls.SetChildIndex(Me.nam受注金額, 0)
        Me.Controls.SetChildIndex(Me.txt受注金額, 0)
        Me.Controls.SetChildIndex(Me.grp仕入情報, 0)
        Me.Controls.SetChildIndex(Me.grp刃型情報大枠, 0)
        Me.Controls.SetChildIndex(Me.grp注意事項, 0)
        Me.Controls.SetChildIndex(Me.grp出荷先, 0)
        Me.grp処理区分.ResumeLayout(False)
        Me.grp処理区分.PerformLayout()
        Me.grp作業NO.ResumeLayout(False)
        Me.grp作業NO.PerformLayout()
        Me.grp社内外区分.ResumeLayout(False)
        Me.grp本台帳NO.ResumeLayout(False)
        Me.grp本台帳NO.PerformLayout()
        Me.grp受注日付.ResumeLayout(False)
        Me.grp受注日付.PerformLayout()
        Me.grp御客様NO.ResumeLayout(False)
        Me.grp御客様NO.PerformLayout()
        Me.grp機番.ResumeLayout(False)
        Me.grp機番.PerformLayout()
        Me.grp納品日付B.ResumeLayout(False)
        Me.grp納品日付B.PerformLayout()
        Me.grp得意先CD.ResumeLayout(False)
        Me.grp得意先CD.PerformLayout()
        Me.grp請求先CD.ResumeLayout(False)
        Me.grp請求先CD.PerformLayout()
        Me.grp代表商品名.ResumeLayout(False)
        Me.grp代表商品名.PerformLayout()
        Me.grp刃型区分.ResumeLayout(False)
        Me.grp顧客刃型番号.ResumeLayout(False)
        Me.grp顧客刃型番号.PerformLayout()
        Me.grp台紙.ResumeLayout(False)
        Me.grp台紙.PerformLayout()
        Me.grp担当者.ResumeLayout(False)
        Me.grp担当者.PerformLayout()
        Me.grp仕入情報.ResumeLayout(False)
        Me.grp仕入情報.PerformLayout()
        Me.grp刃型情報大枠.ResumeLayout(False)
        Me.grp刃型サイズ一面.ResumeLayout(False)
        Me.grp刃型サイズ一面.PerformLayout()
        Me.grp刃型情報.ResumeLayout(False)
        Me.grp刃型情報.PerformLayout()
        Me.grp線幅.ResumeLayout(False)
        Me.grp線幅.PerformLayout()
        Me.grp刃型サイズ全体.ResumeLayout(False)
        Me.grp刃型サイズ全体.PerformLayout()
        Me.grp面付.ResumeLayout(False)
        Me.grp面付流れ方向.ResumeLayout(False)
        Me.grp面付流れ方向.PerformLayout()
        Me.grp面付紙幅方向.ResumeLayout(False)
        Me.grp面付紙幅方向.PerformLayout()
        Me.grpバリヤ表.ResumeLayout(False)
        Me.grpバリヤ表.PerformLayout()
        Me.grpフレキ機械種別.ResumeLayout(False)
        Me.grp注意事項.ResumeLayout(False)
        Me.grp注意事項.PerformLayout()
        Me.grp出荷先.ResumeLayout(False)
        Me.grp出荷先.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grp処理区分 As BaseUI.Control.GroupBox
    Friend WithEvents opt削除 As BaseUI.Control.RadioButton
    Friend WithEvents opt修正 As BaseUI.Control.RadioButton
    Friend WithEvents opt登録 As BaseUI.Control.RadioButton
    Friend WithEvents grp作業NO As BaseUI.Control.GroupBox
    Friend WithEvents txt作業NO As BaseUI.Control.TextBox
    Friend WithEvents nam受注数合計 As BaseUI.Control.NameBox
    Friend WithEvents txt受注単価 As BaseUI.Control.TextBox
    Friend WithEvents txt受注数合計 As BaseUI.Control.TextBox
    Friend WithEvents nam受注単価 As BaseUI.Control.NameBox
    Friend WithEvents grp社内外区分 As BaseUI.Control.GroupBox
    Friend WithEvents ddl社内外区分 As BaseUI.Control.ComboBox
    Friend WithEvents grp本台帳NO As BaseUI.Control.GroupBox
    Friend WithEvents txt本台帳NO As BaseUI.Control.TextBox
    Friend WithEvents grp受注日付 As BaseUI.Control.GroupBox
    Friend WithEvents txt受注日付 As BaseUI.Control.TextBox
    Friend WithEvents grp御客様NO As BaseUI.Control.GroupBox
    Friend WithEvents txt御客様NO As BaseUI.Control.TextBox
    Friend WithEvents grp機番 As BaseUI.Control.GroupBox
    Friend WithEvents txt機番 As BaseUI.Control.TextBox
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
    Friend WithEvents grp刃型区分 As BaseUI.Control.GroupBox
    Friend WithEvents ddl刃型区分 As BaseUI.Control.ComboBox
    Friend WithEvents grp顧客刃型番号 As BaseUI.Control.GroupBox
    Friend WithEvents txt顧客刃型番号 As BaseUI.Control.TextBox
    Friend WithEvents grp台紙 As BaseUI.Control.GroupBox
    Friend WithEvents nam台紙名 As BaseUI.Control.NameBox
    Friend WithEvents txt台紙CD As BaseUI.Control.TextBox
    Friend WithEvents grp担当者 As BaseUI.Control.GroupBox
    Friend WithEvents nam担当者名 As BaseUI.Control.NameBox
    Friend WithEvents txt担当者CD As BaseUI.Control.TextBox
    Friend WithEvents txt受注金額 As BaseUI.Control.TextBox
    Friend WithEvents nam受注金額 As BaseUI.Control.NameBox
    Friend WithEvents grp仕入情報 As BaseUI.Control.GroupBox
    Friend WithEvents lbl原価 As BaseUI.Control.Label
    Friend WithEvents txt原価 As BaseUI.Control.TextBox
    Friend WithEvents lbl仕入先CD As BaseUI.Control.Label
    Friend WithEvents nam仕入先名 As BaseUI.Control.NameBox
    Friend WithEvents txt仕入先CD As BaseUI.Control.TextBox
    Friend WithEvents txt計上先作業NO As BaseUI.Control.TextBox
    Friend WithEvents lbl作業NO As BaseUI.Control.Label
    Friend WithEvents lbl計上先 As BaseUI.Control.Label
    Friend WithEvents grp刃型情報大枠 As BaseUI.Control.GroupBox
    Friend WithEvents grp刃型情報 As BaseUI.Control.GroupBox
    Friend WithEvents lbl刃型情報バリヤ単位 As BaseUI.Control.Label
    Friend WithEvents lbl刃型情報バリヤ As BaseUI.Control.Label
    Friend WithEvents txt刃型情報バリヤ As BaseUI.Control.TextBox
    Friend WithEvents lbl刃型情報総円周単位 As BaseUI.Control.Label
    Friend WithEvents lbl刃型情報板厚単位 As BaseUI.Control.Label
    Friend WithEvents lbl刃型情報総円周 As BaseUI.Control.Label
    Friend WithEvents lbl刃型情報板厚 As BaseUI.Control.Label
    Friend WithEvents txt刃型情報総円周 As BaseUI.Control.TextBox
    Friend WithEvents txt刃型情報板厚 As BaseUI.Control.TextBox
    Friend WithEvents lbl刃型情報ギヤ数 As BaseUI.Control.Label
    Friend WithEvents lbl刃型情報ギヤ数単位 As BaseUI.Control.Label
    Friend WithEvents txt刃型情報ギヤ数 As BaseUI.Control.TextBox
    Friend WithEvents grp線幅 As BaseUI.Control.GroupBox
    Friend WithEvents lbl線幅トンボ単位 As BaseUI.Control.Label
    Friend WithEvents lbl線幅原点単位 As BaseUI.Control.Label
    Friend WithEvents lbl線幅トンボ As BaseUI.Control.Label
    Friend WithEvents lbl線幅原点 As BaseUI.Control.Label
    Friend WithEvents txt線幅トンボ As BaseUI.Control.TextBox
    Friend WithEvents txt線幅原点 As BaseUI.Control.TextBox
    Friend WithEvents lbl線幅刃型線 As BaseUI.Control.Label
    Friend WithEvents lbl線幅刃型線単位 As BaseUI.Control.Label
    Friend WithEvents txt線幅刃型線 As BaseUI.Control.TextBox
    Friend WithEvents grp刃型サイズ全体 As BaseUI.Control.GroupBox
    Friend WithEvents lbl刃型サイズ全体流れ方向単位 As BaseUI.Control.Label
    Friend WithEvents lbl刃型サイズ全体流れ方向下 As BaseUI.Control.Label
    Friend WithEvents txt刃型サイズ全体流れ方向 As BaseUI.Control.TextBox
    Friend WithEvents lbl刃型サイズ全体流れ方向上 As BaseUI.Control.Label
    Friend WithEvents lbl刃型サイズ全体紙幅方向 As BaseUI.Control.Label
    Friend WithEvents lbl刃型サイズ全体紙幅方向単位 As BaseUI.Control.Label
    Friend WithEvents txt刃型サイズ全体紙幅方向 As BaseUI.Control.TextBox
    Friend WithEvents grp面付 As BaseUI.Control.GroupBox
    Friend WithEvents grp面付流れ方向 As BaseUI.Control.GroupBox
    Friend WithEvents lbl面付流れ方向ドブ寸法 As BaseUI.Control.Label
    Friend WithEvents lbl面付流れ方向ドブ寸法単位 As BaseUI.Control.Label
    Friend WithEvents txt面付流れ方向ドブ寸法 As BaseUI.Control.TextBox
    Friend WithEvents lbl面付流れ方向面数単位 As BaseUI.Control.Label
    Friend WithEvents txt面付流れ方向面数 As BaseUI.Control.TextBox
    Friend WithEvents lbl面付流れ方向面数 As BaseUI.Control.Label
    Friend WithEvents grp面付紙幅方向 As BaseUI.Control.GroupBox
    Friend WithEvents lbl面付紙幅方向ドブ寸法 As BaseUI.Control.Label
    Friend WithEvents lbl面付紙幅方向ドブ寸法単位 As BaseUI.Control.Label
    Friend WithEvents txt面付紙幅方向ドブ寸法 As BaseUI.Control.TextBox
    Friend WithEvents lbl面付紙幅方向面数単位 As BaseUI.Control.Label
    Friend WithEvents txt面付紙幅方向面数 As BaseUI.Control.TextBox
    Friend WithEvents lbl面付紙幅方向面数 As BaseUI.Control.Label
    Friend WithEvents grpバリヤ表 As BaseUI.Control.GroupBox
    Friend WithEvents namバリヤ表区分名 As BaseUI.Control.NameBox
    Friend WithEvents txtバリヤ表区分 As BaseUI.Control.TextBox
    Friend WithEvents grpフレキ機械種別 As BaseUI.Control.GroupBox
    Friend WithEvents ddlフレキ機械種別区分 As BaseUI.Control.ComboBox
    Friend WithEvents grp刃型サイズ一面 As BaseUI.Control.GroupBox
    Friend WithEvents ddl刃型サイズ一面形状区分 As BaseUI.Control.ComboBox
    Friend WithEvents lbl刃型サイズ一面形状区分 As BaseUI.Control.Label
    Friend WithEvents lbl刃型サイズ一面角単位 As BaseUI.Control.Label
    Friend WithEvents lbl刃型サイズ一面流れ方向単位 As BaseUI.Control.Label
    Friend WithEvents lbl刃型サイズ一面角 As BaseUI.Control.Label
    Friend WithEvents lbl刃型サイズ一面流れ方向 As BaseUI.Control.Label
    Friend WithEvents txt刃型サイズ一面角 As BaseUI.Control.TextBox
    Friend WithEvents txt刃型サイズ一面流れ方向 As BaseUI.Control.TextBox
    Friend WithEvents lbl刃型サイズ一面紙幅方向 As BaseUI.Control.Label
    Friend WithEvents lbl刃型サイズ一面紙幅方向単位 As BaseUI.Control.Label
    Friend WithEvents txt刃型サイズ一面紙幅方向 As BaseUI.Control.TextBox
    Friend WithEvents grp注意事項 As BaseUI.Control.GroupBox
    Friend WithEvents txt注意事項05 As BaseUI.Control.TextBox
    Friend WithEvents txt注意事項04 As BaseUI.Control.TextBox
    Friend WithEvents txt注意事項03 As BaseUI.Control.TextBox
    Friend WithEvents txt注意事項02 As BaseUI.Control.TextBox
    Friend WithEvents txt注意事項01 As BaseUI.Control.TextBox
    Friend WithEvents grp出荷先 As BaseUI.Control.GroupBox
    Friend WithEvents txt出荷先CD04 As BaseUI.Control.TextBox
    Friend WithEvents txt出荷先CD03 As BaseUI.Control.TextBox
    Friend WithEvents txt出荷先CD02 As BaseUI.Control.TextBox
    Friend WithEvents txt出荷先CD01 As BaseUI.Control.TextBox
    Friend WithEvents txt出荷先名04 As BaseUI.Control.TextBox
    Friend WithEvents txt出荷先名03 As BaseUI.Control.TextBox
    Friend WithEvents txt出荷先名02 As BaseUI.Control.TextBox
    Friend WithEvents txt出荷先名01 As BaseUI.Control.TextBox

End Class
