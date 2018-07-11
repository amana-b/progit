<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
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
        Me.grp得意先CD = New BaseUI.Control.GroupBox()
        Me.txt得意先CD = New BaseUI.Control.TextBox()
        Me.grp得意先名 = New BaseUI.Control.GroupBox()
        Me.txt得意先名 = New BaseUI.Control.TextBox()
        Me.grp住所 = New BaseUI.Control.GroupBox()
        Me.txt住所2 = New BaseUI.Control.TextBox()
        Me.txt住所1 = New BaseUI.Control.TextBox()
        Me.grpTEL = New BaseUI.Control.GroupBox()
        Me.txtTEL = New BaseUI.Control.TextBox()
        Me.txt郵便番号 = New BaseUI.Control.TextBox()
        Me.grp郵便番号 = New BaseUI.Control.GroupBox()
        Me.grpカナ名 = New BaseUI.Control.GroupBox()
        Me.txtカナ名 = New BaseUI.Control.TextBox()
        Me.grp役職_担当者名 = New BaseUI.Control.GroupBox()
        Me.txt役職_担当者名 = New BaseUI.Control.TextBox()
        Me.grp代表者役職_代表者名 = New BaseUI.Control.GroupBox()
        Me.txt代表者役職_代表者名1 = New BaseUI.Control.TextBox()
        Me.grpFAX = New BaseUI.Control.GroupBox()
        Me.txtFAX = New BaseUI.Control.TextBox()
        Me.GroupBox1 = New BaseUI.Control.GroupBox()
        Me.txt代表者役職_代表者名2 = New BaseUI.Control.TextBox()
        Me.grp担当者 = New BaseUI.Control.GroupBox()
        Me.nam自社担当者名 = New BaseUI.Control.NameBox()
        Me.txt自社担当者CD = New BaseUI.Control.TextBox()
        Me.GroupBox2 = New BaseUI.Control.GroupBox()
        Me.lbl締日 = New BaseUI.Control.Label()
        Me.txt締日 = New BaseUI.Control.TextBox()
        Me.grp紙種別区分 = New BaseUI.Control.GroupBox()
        Me.ddl請求書発行区分 = New BaseUI.Control.ComboBox()
        Me.grp重要度 = New BaseUI.Control.GroupBox()
        Me.Label3 = New BaseUI.Control.Label()
        Me.Label2 = New BaseUI.Control.Label()
        Me.Label1 = New BaseUI.Control.Label()
        Me.nam重要度名 = New BaseUI.Control.NameBox()
        Me.txt重要度 = New BaseUI.Control.TextBox()
        Me.GroupBox3 = New BaseUI.Control.GroupBox()
        Me.txt御客様NO = New BaseUI.Control.TextBox()
        Me.grp集計用得意先 = New BaseUI.Control.GroupBox()
        Me.nam集計用得意先名 = New BaseUI.Control.NameBox()
        Me.txt集計用得意先CD = New BaseUI.Control.TextBox()
        Me.GroupBox4 = New BaseUI.Control.GroupBox()
        Me.nam表示振替用得意先名 = New BaseUI.Control.NameBox()
        Me.txt表示振替用得意先CD = New BaseUI.Control.TextBox()
        Me.grp仮伝パターンCD = New BaseUI.Control.GroupBox()
        Me.nam仮伝パターン名 = New BaseUI.Control.NameBox()
        Me.txt仮伝パターンCD = New BaseUI.Control.TextBox()
        Me.grp売伝パターンCD = New BaseUI.Control.GroupBox()
        Me.nam売伝パターン名 = New BaseUI.Control.NameBox()
        Me.txt売伝パターンCD = New BaseUI.Control.TextBox()
        Me.grp消費税区分 = New BaseUI.Control.GroupBox()
        Me.ddl消費税区分 = New BaseUI.Control.ComboBox()
        Me.GroupBox6 = New BaseUI.Control.GroupBox()
        Me.ddl回収条件未満回収方法 = New BaseUI.Control.ComboBox()
        Me.Label9 = New BaseUI.Control.Label()
        Me.txt回収条件未満回収日 = New BaseUI.Control.TextBox()
        Me.Label10 = New BaseUI.Control.Label()
        Me.txt回収条件未満回収月 = New BaseUI.Control.TextBox()
        Me.Label8 = New BaseUI.Control.Label()
        Me.Label7 = New BaseUI.Control.Label()
        Me.ddl回収条件以上回収方法 = New BaseUI.Control.ComboBox()
        Me.Label6 = New BaseUI.Control.Label()
        Me.txt回収条件以上回収日 = New BaseUI.Control.TextBox()
        Me.Label5 = New BaseUI.Control.Label()
        Me.txt回収条件以上回収月 = New BaseUI.Control.TextBox()
        Me.Label4 = New BaseUI.Control.Label()
        Me.txt回収条件設定金額 = New BaseUI.Control.TextBox()
        Me.btn詳細情報 = New BaseUI.Control.Button()
        Me.grp請求書用得意先名 = New BaseUI.Control.GroupBox()
        Me.txt請求書用得意先名2 = New BaseUI.Control.TextBox()
        Me.txt請求書用得意先名1 = New BaseUI.Control.TextBox()
        Me.grp詳細情報 = New BaseUI.Control.GroupBox()
        Me.grp処理区分.SuspendLayout()
        Me.grp得意先CD.SuspendLayout()
        Me.grp得意先名.SuspendLayout()
        Me.grp住所.SuspendLayout()
        Me.grpTEL.SuspendLayout()
        Me.grp郵便番号.SuspendLayout()
        Me.grpカナ名.SuspendLayout()
        Me.grp役職_担当者名.SuspendLayout()
        Me.grp代表者役職_代表者名.SuspendLayout()
        Me.grpFAX.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grp担当者.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.grp紙種別区分.SuspendLayout()
        Me.grp重要度.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.grp集計用得意先.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.grp仮伝パターンCD.SuspendLayout()
        Me.grp売伝パターンCD.SuspendLayout()
        Me.grp消費税区分.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.grp請求書用得意先名.SuspendLayout()
        Me.grp詳細情報.SuspendLayout()
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
        'grp得意先CD
        '
        Me.grp得意先CD.Controls.Add(Me.txt得意先CD)
        Me.grp得意先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp得意先CD.Location = New System.Drawing.Point(314, 22)
        Me.grp得意先CD.Name = "grp得意先CD"
        Me.grp得意先CD.Size = New System.Drawing.Size(104, 61)
        Me.grp得意先CD.TabIndex = 1
        Me.grp得意先CD.TabStop = False
        Me.grp得意先CD.Text = "得意先CD"
        '
        'txt得意先CD
        '
        Me.txt得意先CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt得意先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt得意先CD.HelpKeys = ""
        Me.txt得意先CD.HelpLink = ""
        Me.txt得意先CD.HelpType = NodeUI.Help.Type.None
        Me.txt得意先CD.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt得意先CD.IsError = False
        Me.txt得意先CD.Location = New System.Drawing.Point(19, 25)
        Me.txt得意先CD.Name = "txt得意先CD"
        Me.txt得意先CD.Required = False
        Me.txt得意先CD.Size = New System.Drawing.Size(61, 23)
        Me.txt得意先CD.StringLength = 65535
        Me.txt得意先CD.TabIndex = 0
        Me.txt得意先CD.Text = "999999"
        Me.txt得意先CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp得意先名
        '
        Me.grp得意先名.Controls.Add(Me.txt得意先名)
        Me.grp得意先名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp得意先名.Location = New System.Drawing.Point(424, 22)
        Me.grp得意先名.Name = "grp得意先名"
        Me.grp得意先名.Size = New System.Drawing.Size(312, 61)
        Me.grp得意先名.TabIndex = 2
        Me.grp得意先名.TabStop = False
        Me.grp得意先名.Text = "得意先名"
        '
        'txt得意先名
        '
        Me.txt得意先名.FieldLockType = BaseContents.Field.LockType.None
        Me.txt得意先名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt得意先名.HelpKeys = ""
        Me.txt得意先名.HelpLink = ""
        Me.txt得意先名.HelpType = NodeUI.Help.Type.None
        Me.txt得意先名.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt得意先名.IsError = False
        Me.txt得意先名.Location = New System.Drawing.Point(19, 25)
        Me.txt得意先名.Name = "txt得意先名"
        Me.txt得意先名.Required = True
        Me.txt得意先名.Size = New System.Drawing.Size(264, 23)
        Me.txt得意先名.StringLength = 65535
        Me.txt得意先名.TabIndex = 0
        Me.txt得意先名.Text = "ああああああああああいいいいいい"
        Me.txt得意先名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp住所
        '
        Me.grp住所.Controls.Add(Me.txt住所2)
        Me.grp住所.Controls.Add(Me.txt住所1)
        Me.grp住所.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp住所.Location = New System.Drawing.Point(140, 100)
        Me.grp住所.Name = "grp住所"
        Me.grp住所.Size = New System.Drawing.Size(290, 85)
        Me.grp住所.TabIndex = 5
        Me.grp住所.TabStop = False
        Me.grp住所.Text = "住所"
        '
        'txt住所2
        '
        Me.txt住所2.FieldLockType = BaseContents.Field.LockType.None
        Me.txt住所2.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt住所2.HelpKeys = ""
        Me.txt住所2.HelpLink = ""
        Me.txt住所2.HelpType = NodeUI.Help.Type.None
        Me.txt住所2.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt住所2.IsError = False
        Me.txt住所2.Location = New System.Drawing.Point(19, 45)
        Me.txt住所2.Name = "txt住所2"
        Me.txt住所2.Required = False
        Me.txt住所2.Size = New System.Drawing.Size(264, 23)
        Me.txt住所2.StringLength = 65535
        Me.txt住所2.TabIndex = 1
        Me.txt住所2.Text = "ああああああああああいいいいいい"
        Me.txt住所2.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt住所1
        '
        Me.txt住所1.FieldLockType = BaseContents.Field.LockType.None
        Me.txt住所1.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt住所1.HelpKeys = ""
        Me.txt住所1.HelpLink = ""
        Me.txt住所1.HelpType = NodeUI.Help.Type.None
        Me.txt住所1.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt住所1.IsError = False
        Me.txt住所1.Location = New System.Drawing.Point(19, 25)
        Me.txt住所1.Name = "txt住所1"
        Me.txt住所1.Required = False
        Me.txt住所1.Size = New System.Drawing.Size(264, 23)
        Me.txt住所1.StringLength = 65535
        Me.txt住所1.TabIndex = 0
        Me.txt住所1.Text = "ああああああああああいいいいいい"
        Me.txt住所1.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grpTEL
        '
        Me.grpTEL.Controls.Add(Me.txtTEL)
        Me.grpTEL.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grpTEL.Location = New System.Drawing.Point(436, 100)
        Me.grpTEL.Name = "grpTEL"
        Me.grpTEL.Size = New System.Drawing.Size(140, 61)
        Me.grpTEL.TabIndex = 6
        Me.grpTEL.TabStop = False
        Me.grpTEL.Text = "ＴＥＬ"
        '
        'txtTEL
        '
        Me.txtTEL.FieldLockType = BaseContents.Field.LockType.None
        Me.txtTEL.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txtTEL.HelpKeys = ""
        Me.txtTEL.HelpLink = ""
        Me.txtTEL.HelpType = NodeUI.Help.Type.None
        Me.txtTEL.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtTEL.IsError = False
        Me.txtTEL.Location = New System.Drawing.Point(19, 25)
        Me.txtTEL.Name = "txtTEL"
        Me.txtTEL.Required = False
        Me.txtTEL.Size = New System.Drawing.Size(114, 23)
        Me.txtTEL.StringLength = 65535
        Me.txtTEL.TabIndex = 0
        Me.txtTEL.Text = "999-9999-9999"
        Me.txtTEL.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt郵便番号
        '
        Me.txt郵便番号.FieldLockType = BaseContents.Field.LockType.None
        Me.txt郵便番号.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt郵便番号.HelpKeys = ""
        Me.txt郵便番号.HelpLink = ""
        Me.txt郵便番号.HelpType = NodeUI.Help.Type.None
        Me.txt郵便番号.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt郵便番号.IsError = False
        Me.txt郵便番号.Location = New System.Drawing.Point(19, 25)
        Me.txt郵便番号.Name = "txt郵便番号"
        Me.txt郵便番号.Required = False
        Me.txt郵便番号.Size = New System.Drawing.Size(79, 23)
        Me.txt郵便番号.StringLength = 65535
        Me.txt郵便番号.TabIndex = 0
        Me.txt郵便番号.Text = "999-9999"
        Me.txt郵便番号.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp郵便番号
        '
        Me.grp郵便番号.Controls.Add(Me.txt郵便番号)
        Me.grp郵便番号.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp郵便番号.Location = New System.Drawing.Point(29, 100)
        Me.grp郵便番号.Name = "grp郵便番号"
        Me.grp郵便番号.Size = New System.Drawing.Size(105, 61)
        Me.grp郵便番号.TabIndex = 4
        Me.grp郵便番号.TabStop = False
        Me.grp郵便番号.Text = "郵便番号"
        '
        'grpカナ名
        '
        Me.grpカナ名.Controls.Add(Me.txtカナ名)
        Me.grpカナ名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grpカナ名.Location = New System.Drawing.Point(742, 22)
        Me.grpカナ名.Name = "grpカナ名"
        Me.grpカナ名.Size = New System.Drawing.Size(152, 61)
        Me.grpカナ名.TabIndex = 3
        Me.grpカナ名.TabStop = False
        Me.grpカナ名.Text = "カナ名"
        '
        'txtカナ名
        '
        Me.txtカナ名.FieldLockType = BaseContents.Field.LockType.None
        Me.txtカナ名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txtカナ名.HelpKeys = ""
        Me.txtカナ名.HelpLink = ""
        Me.txtカナ名.HelpType = NodeUI.Help.Type.None
        Me.txtカナ名.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf
        Me.txtカナ名.IsError = False
        Me.txtカナ名.Location = New System.Drawing.Point(19, 25)
        Me.txtカナ名.Name = "txtカナ名"
        Me.txtカナ名.Required = False
        Me.txtカナ名.Size = New System.Drawing.Size(90, 23)
        Me.txtカナ名.StringLength = 65535
        Me.txtカナ名.TabIndex = 0
        Me.txtカナ名.Text = "あああああ"
        Me.txtカナ名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp役職_担当者名
        '
        Me.grp役職_担当者名.Controls.Add(Me.txt役職_担当者名)
        Me.grp役職_担当者名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp役職_担当者名.Location = New System.Drawing.Point(29, 199)
        Me.grp役職_担当者名.Name = "grp役職_担当者名"
        Me.grp役職_担当者名.Size = New System.Drawing.Size(220, 61)
        Me.grp役職_担当者名.TabIndex = 9
        Me.grp役職_担当者名.TabStop = False
        Me.grp役職_担当者名.Text = "役職/担当者名"
        '
        'txt役職_担当者名
        '
        Me.txt役職_担当者名.FieldLockType = BaseContents.Field.LockType.None
        Me.txt役職_担当者名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt役職_担当者名.HelpKeys = ""
        Me.txt役職_担当者名.HelpLink = ""
        Me.txt役職_担当者名.HelpType = NodeUI.Help.Type.None
        Me.txt役職_担当者名.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt役職_担当者名.IsError = False
        Me.txt役職_担当者名.Location = New System.Drawing.Point(19, 25)
        Me.txt役職_担当者名.Name = "txt役職_担当者名"
        Me.txt役職_担当者名.Required = False
        Me.txt役職_担当者名.Size = New System.Drawing.Size(190, 23)
        Me.txt役職_担当者名.StringLength = 65535
        Me.txt役職_担当者名.TabIndex = 0
        Me.txt役職_担当者名.Text = "ああああああああああい"
        Me.txt役職_担当者名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp代表者役職_代表者名
        '
        Me.grp代表者役職_代表者名.Controls.Add(Me.txt代表者役職_代表者名1)
        Me.grp代表者役職_代表者名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp代表者役職_代表者名.Location = New System.Drawing.Point(255, 199)
        Me.grp代表者役職_代表者名.Name = "grp代表者役職_代表者名"
        Me.grp代表者役職_代表者名.Size = New System.Drawing.Size(312, 61)
        Me.grp代表者役職_代表者名.TabIndex = 10
        Me.grp代表者役職_代表者名.TabStop = False
        Me.grp代表者役職_代表者名.Text = "代表者役職/代表者名"
        '
        'txt代表者役職_代表者名1
        '
        Me.txt代表者役職_代表者名1.FieldLockType = BaseContents.Field.LockType.None
        Me.txt代表者役職_代表者名1.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt代表者役職_代表者名1.HelpKeys = ""
        Me.txt代表者役職_代表者名1.HelpLink = ""
        Me.txt代表者役職_代表者名1.HelpType = NodeUI.Help.Type.None
        Me.txt代表者役職_代表者名1.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt代表者役職_代表者名1.IsError = False
        Me.txt代表者役職_代表者名1.Location = New System.Drawing.Point(19, 25)
        Me.txt代表者役職_代表者名1.Name = "txt代表者役職_代表者名1"
        Me.txt代表者役職_代表者名1.Required = False
        Me.txt代表者役職_代表者名1.Size = New System.Drawing.Size(264, 23)
        Me.txt代表者役職_代表者名1.StringLength = 65535
        Me.txt代表者役職_代表者名1.TabIndex = 0
        Me.txt代表者役職_代表者名1.Text = "ああああああああああいいいいいい"
        Me.txt代表者役職_代表者名1.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grpFAX
        '
        Me.grpFAX.Controls.Add(Me.txtFAX)
        Me.grpFAX.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grpFAX.Location = New System.Drawing.Point(582, 100)
        Me.grpFAX.Name = "grpFAX"
        Me.grpFAX.Size = New System.Drawing.Size(140, 61)
        Me.grpFAX.TabIndex = 7
        Me.grpFAX.TabStop = False
        Me.grpFAX.Text = "ＦＡＸ"
        '
        'txtFAX
        '
        Me.txtFAX.FieldLockType = BaseContents.Field.LockType.None
        Me.txtFAX.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txtFAX.HelpKeys = ""
        Me.txtFAX.HelpLink = ""
        Me.txtFAX.HelpType = NodeUI.Help.Type.None
        Me.txtFAX.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtFAX.IsError = False
        Me.txtFAX.Location = New System.Drawing.Point(19, 25)
        Me.txtFAX.Name = "txtFAX"
        Me.txtFAX.Required = False
        Me.txtFAX.Size = New System.Drawing.Size(114, 23)
        Me.txtFAX.StringLength = 65535
        Me.txtFAX.TabIndex = 0
        Me.txtFAX.Text = "999-9999-9999"
        Me.txtFAX.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt代表者役職_代表者名2)
        Me.GroupBox1.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(573, 199)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 61)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "代表者役職/代表者名2"
        '
        'txt代表者役職_代表者名2
        '
        Me.txt代表者役職_代表者名2.FieldLockType = BaseContents.Field.LockType.None
        Me.txt代表者役職_代表者名2.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt代表者役職_代表者名2.HelpKeys = ""
        Me.txt代表者役職_代表者名2.HelpLink = ""
        Me.txt代表者役職_代表者名2.HelpType = NodeUI.Help.Type.None
        Me.txt代表者役職_代表者名2.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt代表者役職_代表者名2.IsError = False
        Me.txt代表者役職_代表者名2.Location = New System.Drawing.Point(19, 25)
        Me.txt代表者役職_代表者名2.Name = "txt代表者役職_代表者名2"
        Me.txt代表者役職_代表者名2.Required = False
        Me.txt代表者役職_代表者名2.Size = New System.Drawing.Size(264, 23)
        Me.txt代表者役職_代表者名2.StringLength = 65535
        Me.txt代表者役職_代表者名2.TabIndex = 0
        Me.txt代表者役職_代表者名2.Text = "ああああああああああいいいいいい"
        Me.txt代表者役職_代表者名2.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp担当者
        '
        Me.grp担当者.Controls.Add(Me.nam自社担当者名)
        Me.grp担当者.Controls.Add(Me.txt自社担当者CD)
        Me.grp担当者.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp担当者.Location = New System.Drawing.Point(29, 274)
        Me.grp担当者.Name = "grp担当者"
        Me.grp担当者.Size = New System.Drawing.Size(285, 61)
        Me.grp担当者.TabIndex = 12
        Me.grp担当者.TabStop = False
        Me.grp担当者.Text = "自社担当者CD"
        '
        'nam自社担当者名
        '
        Me.nam自社担当者名.BackColor = System.Drawing.SystemColors.Control
        Me.nam自社担当者名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam自社担当者名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam自社担当者名.Location = New System.Drawing.Point(79, 24)
        Me.nam自社担当者名.Margin = New System.Windows.Forms.Padding(3)
        Me.nam自社担当者名.Name = "nam自社担当者名"
        Me.nam自社担当者名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.nam自社担当者名.Size = New System.Drawing.Size(200, 23)
        Me.nam自社担当者名.StringLength = 65535
        Me.nam自社担当者名.TabIndex = 9
        Me.nam自社担当者名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt自社担当者CD
        '
        Me.txt自社担当者CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt自社担当者CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt自社担当者CD.HelpKeys = ""
        Me.txt自社担当者CD.HelpLink = ""
        Me.txt自社担当者CD.HelpType = NodeUI.Help.Type.None
        Me.txt自社担当者CD.IsError = False
        Me.txt自社担当者CD.Location = New System.Drawing.Point(19, 24)
        Me.txt自社担当者CD.Name = "txt自社担当者CD"
        Me.txt自社担当者CD.Required = True
        Me.txt自社担当者CD.Size = New System.Drawing.Size(61, 23)
        Me.txt自社担当者CD.TabIndex = 0
        Me.txt自社担当者CD.Text = "999999"
        Me.txt自社担当者CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lbl締日)
        Me.GroupBox2.Controls.Add(Me.txt締日)
        Me.GroupBox2.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.GroupBox2.Location = New System.Drawing.Point(320, 274)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(179, 61)
        Me.GroupBox2.TabIndex = 13
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "締日"
        '
        'lbl締日
        '
        Me.lbl締日.AutoSize = True
        Me.lbl締日.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.lbl締日.Location = New System.Drawing.Point(55, 27)
        Me.lbl締日.Name = "lbl締日"
        Me.lbl締日.Size = New System.Drawing.Size(120, 16)
        Me.lbl締日.TabIndex = 12
        Me.lbl締日.Text = "日締(99：末締)"
        '
        'txt締日
        '
        Me.txt締日.FieldLockType = BaseContents.Field.LockType.None
        Me.txt締日.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt締日.HelpKeys = ""
        Me.txt締日.HelpLink = ""
        Me.txt締日.HelpType = NodeUI.Help.Type.None
        Me.txt締日.IsError = False
        Me.txt締日.Location = New System.Drawing.Point(19, 24)
        Me.txt締日.Name = "txt締日"
        Me.txt締日.Required = True
        Me.txt締日.Size = New System.Drawing.Size(25, 23)
        Me.txt締日.TabIndex = 0
        Me.txt締日.Text = "99"
        Me.txt締日.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp紙種別区分
        '
        Me.grp紙種別区分.Controls.Add(Me.ddl請求書発行区分)
        Me.grp紙種別区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp紙種別区分.Location = New System.Drawing.Point(505, 274)
        Me.grp紙種別区分.Name = "grp紙種別区分"
        Me.grp紙種別区分.Size = New System.Drawing.Size(143, 61)
        Me.grp紙種別区分.TabIndex = 14
        Me.grp紙種別区分.TabStop = False
        Me.grp紙種別区分.Text = "請求書発行区分"
        '
        'ddl請求書発行区分
        '
        Me.ddl請求書発行区分.AutoDropDown = True
        Me.ddl請求書発行区分.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddl請求書発行区分.FieldLockType = BaseContents.Field.LockType.None
        Me.ddl請求書発行区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.ddl請求書発行区分.FormattingEnabled = True
        Me.ddl請求書発行区分.IsError = False
        Me.ddl請求書発行区分.ListType = NodeUI.List.Type.None
        Me.ddl請求書発行区分.Location = New System.Drawing.Point(19, 23)
        Me.ddl請求書発行区分.Name = "ddl請求書発行区分"
        Me.ddl請求書発行区分.Required = True
        Me.ddl請求書発行区分.Size = New System.Drawing.Size(121, 24)
        Me.ddl請求書発行区分.TabIndex = 0
        '
        'grp重要度
        '
        Me.grp重要度.Controls.Add(Me.Label3)
        Me.grp重要度.Controls.Add(Me.Label2)
        Me.grp重要度.Controls.Add(Me.Label1)
        Me.grp重要度.Controls.Add(Me.nam重要度名)
        Me.grp重要度.Controls.Add(Me.txt重要度)
        Me.grp重要度.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp重要度.Location = New System.Drawing.Point(654, 274)
        Me.grp重要度.Name = "grp重要度"
        Me.grp重要度.Size = New System.Drawing.Size(257, 61)
        Me.grp重要度.TabIndex = 15
        Me.grp重要度.TabStop = False
        Me.grp重要度.Text = "重要度"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(107, 39)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 15)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "3:Cﾗﾝｸ　9:ﾗﾝｸなし"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(107, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "2:Bﾗﾝｸ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(107, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 15)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "1:Aﾗﾝｸ　4:Dﾗﾝｸ"
        '
        'nam重要度名
        '
        Me.nam重要度名.BackColor = System.Drawing.SystemColors.Control
        Me.nam重要度名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam重要度名.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.nam重要度名.Location = New System.Drawing.Point(39, 24)
        Me.nam重要度名.Margin = New System.Windows.Forms.Padding(3)
        Me.nam重要度名.Name = "nam重要度名"
        Me.nam重要度名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.nam重要度名.Size = New System.Drawing.Size(60, 23)
        Me.nam重要度名.StringLength = 65535
        Me.nam重要度名.TabIndex = 9
        Me.nam重要度名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt重要度
        '
        Me.txt重要度.FieldLockType = BaseContents.Field.LockType.None
        Me.txt重要度.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt重要度.HelpKeys = ""
        Me.txt重要度.HelpLink = ""
        Me.txt重要度.HelpType = NodeUI.Help.Type.None
        Me.txt重要度.IsError = False
        Me.txt重要度.Location = New System.Drawing.Point(19, 24)
        Me.txt重要度.Name = "txt重要度"
        Me.txt重要度.Required = False
        Me.txt重要度.Size = New System.Drawing.Size(20, 23)
        Me.txt重要度.TabIndex = 0
        Me.txt重要度.Text = "9"
        Me.txt重要度.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt御客様NO)
        Me.GroupBox3.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.GroupBox3.Location = New System.Drawing.Point(917, 274)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(90, 61)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "御客様No"
        '
        'txt御客様NO
        '
        Me.txt御客様NO.FieldLockType = BaseContents.Field.LockType.None
        Me.txt御客様NO.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt御客様NO.HelpKeys = ""
        Me.txt御客様NO.HelpLink = ""
        Me.txt御客様NO.HelpType = NodeUI.Help.Type.None
        Me.txt御客様NO.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt御客様NO.IsError = False
        Me.txt御客様NO.Location = New System.Drawing.Point(19, 25)
        Me.txt御客様NO.Name = "txt御客様NO"
        Me.txt御客様NO.Required = False
        Me.txt御客様NO.Size = New System.Drawing.Size(40, 23)
        Me.txt御客様NO.StringLength = 65535
        Me.txt御客様NO.TabIndex = 0
        Me.txt御客様NO.Text = "9999"
        Me.txt御客様NO.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp集計用得意先
        '
        Me.grp集計用得意先.Controls.Add(Me.nam集計用得意先名)
        Me.grp集計用得意先.Controls.Add(Me.txt集計用得意先CD)
        Me.grp集計用得意先.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp集計用得意先.Location = New System.Drawing.Point(29, 350)
        Me.grp集計用得意先.Name = "grp集計用得意先"
        Me.grp集計用得意先.Size = New System.Drawing.Size(361, 61)
        Me.grp集計用得意先.TabIndex = 17
        Me.grp集計用得意先.TabStop = False
        Me.grp集計用得意先.Text = "集計用得意先CD"
        '
        'nam集計用得意先名
        '
        Me.nam集計用得意先名.BackColor = System.Drawing.SystemColors.Control
        Me.nam集計用得意先名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam集計用得意先名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam集計用得意先名.Location = New System.Drawing.Point(79, 24)
        Me.nam集計用得意先名.Margin = New System.Windows.Forms.Padding(3)
        Me.nam集計用得意先名.Name = "nam集計用得意先名"
        Me.nam集計用得意先名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.nam集計用得意先名.Size = New System.Drawing.Size(260, 23)
        Me.nam集計用得意先名.StringLength = 65535
        Me.nam集計用得意先名.TabIndex = 9
        Me.nam集計用得意先名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt集計用得意先CD
        '
        Me.txt集計用得意先CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt集計用得意先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt集計用得意先CD.HelpKeys = ""
        Me.txt集計用得意先CD.HelpLink = ""
        Me.txt集計用得意先CD.HelpType = NodeUI.Help.Type.None
        Me.txt集計用得意先CD.IsError = False
        Me.txt集計用得意先CD.Location = New System.Drawing.Point(19, 24)
        Me.txt集計用得意先CD.Name = "txt集計用得意先CD"
        Me.txt集計用得意先CD.Required = False
        Me.txt集計用得意先CD.Size = New System.Drawing.Size(61, 23)
        Me.txt集計用得意先CD.TabIndex = 0
        Me.txt集計用得意先CD.Text = "999999"
        Me.txt集計用得意先CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.nam表示振替用得意先名)
        Me.GroupBox4.Controls.Add(Me.txt表示振替用得意先CD)
        Me.GroupBox4.Font = New System.Drawing.Font("ＭＳ ゴシック", 10.0!)
        Me.GroupBox4.Location = New System.Drawing.Point(396, 350)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(361, 61)
        Me.GroupBox4.TabIndex = 18
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "表示振替用得意先CD(請求書の表示振替時に設定)"
        '
        'nam表示振替用得意先名
        '
        Me.nam表示振替用得意先名.BackColor = System.Drawing.SystemColors.Control
        Me.nam表示振替用得意先名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam表示振替用得意先名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam表示振替用得意先名.Location = New System.Drawing.Point(79, 24)
        Me.nam表示振替用得意先名.Margin = New System.Windows.Forms.Padding(3)
        Me.nam表示振替用得意先名.Name = "nam表示振替用得意先名"
        Me.nam表示振替用得意先名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.nam表示振替用得意先名.Size = New System.Drawing.Size(260, 23)
        Me.nam表示振替用得意先名.StringLength = 65535
        Me.nam表示振替用得意先名.TabIndex = 9
        Me.nam表示振替用得意先名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt表示振替用得意先CD
        '
        Me.txt表示振替用得意先CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt表示振替用得意先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt表示振替用得意先CD.HelpKeys = ""
        Me.txt表示振替用得意先CD.HelpLink = ""
        Me.txt表示振替用得意先CD.HelpType = NodeUI.Help.Type.None
        Me.txt表示振替用得意先CD.IsError = False
        Me.txt表示振替用得意先CD.Location = New System.Drawing.Point(19, 24)
        Me.txt表示振替用得意先CD.Name = "txt表示振替用得意先CD"
        Me.txt表示振替用得意先CD.Required = False
        Me.txt表示振替用得意先CD.Size = New System.Drawing.Size(61, 23)
        Me.txt表示振替用得意先CD.TabIndex = 0
        Me.txt表示振替用得意先CD.Text = "999999"
        Me.txt表示振替用得意先CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp仮伝パターンCD
        '
        Me.grp仮伝パターンCD.Controls.Add(Me.nam仮伝パターン名)
        Me.grp仮伝パターンCD.Controls.Add(Me.txt仮伝パターンCD)
        Me.grp仮伝パターンCD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp仮伝パターンCD.Location = New System.Drawing.Point(29, 425)
        Me.grp仮伝パターンCD.Name = "grp仮伝パターンCD"
        Me.grp仮伝パターンCD.Size = New System.Drawing.Size(330, 61)
        Me.grp仮伝パターンCD.TabIndex = 19
        Me.grp仮伝パターンCD.TabStop = False
        Me.grp仮伝パターンCD.Text = "仮伝ﾊﾟﾀｰﾝCD"
        '
        'nam仮伝パターン名
        '
        Me.nam仮伝パターン名.BackColor = System.Drawing.SystemColors.Control
        Me.nam仮伝パターン名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam仮伝パターン名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam仮伝パターン名.Location = New System.Drawing.Point(44, 24)
        Me.nam仮伝パターン名.Margin = New System.Windows.Forms.Padding(3)
        Me.nam仮伝パターン名.Name = "nam仮伝パターン名"
        Me.nam仮伝パターン名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.nam仮伝パターン名.Size = New System.Drawing.Size(260, 23)
        Me.nam仮伝パターン名.StringLength = 65535
        Me.nam仮伝パターン名.TabIndex = 9
        Me.nam仮伝パターン名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt仮伝パターンCD
        '
        Me.txt仮伝パターンCD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt仮伝パターンCD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt仮伝パターンCD.HelpKeys = ""
        Me.txt仮伝パターンCD.HelpLink = ""
        Me.txt仮伝パターンCD.HelpType = NodeUI.Help.Type.None
        Me.txt仮伝パターンCD.IsError = False
        Me.txt仮伝パターンCD.Location = New System.Drawing.Point(19, 24)
        Me.txt仮伝パターンCD.Name = "txt仮伝パターンCD"
        Me.txt仮伝パターンCD.Required = True
        Me.txt仮伝パターンCD.Size = New System.Drawing.Size(25, 23)
        Me.txt仮伝パターンCD.TabIndex = 0
        Me.txt仮伝パターンCD.Text = "99"
        Me.txt仮伝パターンCD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp売伝パターンCD
        '
        Me.grp売伝パターンCD.Controls.Add(Me.nam売伝パターン名)
        Me.grp売伝パターンCD.Controls.Add(Me.txt売伝パターンCD)
        Me.grp売伝パターンCD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp売伝パターンCD.Location = New System.Drawing.Point(365, 425)
        Me.grp売伝パターンCD.Name = "grp売伝パターンCD"
        Me.grp売伝パターンCD.Size = New System.Drawing.Size(330, 61)
        Me.grp売伝パターンCD.TabIndex = 20
        Me.grp売伝パターンCD.TabStop = False
        Me.grp売伝パターンCD.Text = "売伝ﾊﾟﾀｰﾝCD"
        '
        'nam売伝パターン名
        '
        Me.nam売伝パターン名.BackColor = System.Drawing.SystemColors.Control
        Me.nam売伝パターン名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam売伝パターン名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam売伝パターン名.Location = New System.Drawing.Point(44, 24)
        Me.nam売伝パターン名.Margin = New System.Windows.Forms.Padding(3)
        Me.nam売伝パターン名.Name = "nam売伝パターン名"
        Me.nam売伝パターン名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.nam売伝パターン名.Size = New System.Drawing.Size(260, 23)
        Me.nam売伝パターン名.StringLength = 65535
        Me.nam売伝パターン名.TabIndex = 9
        Me.nam売伝パターン名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt売伝パターンCD
        '
        Me.txt売伝パターンCD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt売伝パターンCD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt売伝パターンCD.HelpKeys = ""
        Me.txt売伝パターンCD.HelpLink = ""
        Me.txt売伝パターンCD.HelpType = NodeUI.Help.Type.None
        Me.txt売伝パターンCD.IsError = False
        Me.txt売伝パターンCD.Location = New System.Drawing.Point(19, 24)
        Me.txt売伝パターンCD.Name = "txt売伝パターンCD"
        Me.txt売伝パターンCD.Required = True
        Me.txt売伝パターンCD.Size = New System.Drawing.Size(25, 23)
        Me.txt売伝パターンCD.TabIndex = 0
        Me.txt売伝パターンCD.Text = "99"
        Me.txt売伝パターンCD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp消費税区分
        '
        Me.grp消費税区分.Controls.Add(Me.ddl消費税区分)
        Me.grp消費税区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp消費税区分.Location = New System.Drawing.Point(701, 425)
        Me.grp消費税区分.Name = "grp消費税区分"
        Me.grp消費税区分.Size = New System.Drawing.Size(250, 61)
        Me.grp消費税区分.TabIndex = 21
        Me.grp消費税区分.TabStop = False
        Me.grp消費税区分.Text = "消費税区分"
        '
        'ddl消費税区分
        '
        Me.ddl消費税区分.AutoDropDown = True
        Me.ddl消費税区分.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddl消費税区分.FieldLockType = BaseContents.Field.LockType.None
        Me.ddl消費税区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.ddl消費税区分.FormattingEnabled = True
        Me.ddl消費税区分.IsError = False
        Me.ddl消費税区分.ListType = NodeUI.List.Type.None
        Me.ddl消費税区分.Location = New System.Drawing.Point(19, 23)
        Me.ddl消費税区分.Name = "ddl消費税区分"
        Me.ddl消費税区分.Required = True
        Me.ddl消費税区分.Size = New System.Drawing.Size(220, 24)
        Me.ddl消費税区分.TabIndex = 0
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.ddl回収条件未満回収方法)
        Me.GroupBox6.Controls.Add(Me.Label9)
        Me.GroupBox6.Controls.Add(Me.txt回収条件未満回収日)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.txt回収条件未満回収月)
        Me.GroupBox6.Controls.Add(Me.Label8)
        Me.GroupBox6.Controls.Add(Me.Label7)
        Me.GroupBox6.Controls.Add(Me.ddl回収条件以上回収方法)
        Me.GroupBox6.Controls.Add(Me.Label6)
        Me.GroupBox6.Controls.Add(Me.txt回収条件以上回収日)
        Me.GroupBox6.Controls.Add(Me.Label5)
        Me.GroupBox6.Controls.Add(Me.txt回収条件以上回収月)
        Me.GroupBox6.Controls.Add(Me.Label4)
        Me.GroupBox6.Controls.Add(Me.txt回収条件設定金額)
        Me.GroupBox6.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.GroupBox6.Location = New System.Drawing.Point(29, 501)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(664, 118)
        Me.GroupBox6.TabIndex = 22
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "回収情報"
        '
        'ddl回収条件未満回収方法
        '
        Me.ddl回収条件未満回収方法.AutoDropDown = True
        Me.ddl回収条件未満回収方法.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddl回収条件未満回収方法.FieldLockType = BaseContents.Field.LockType.None
        Me.ddl回収条件未満回収方法.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.ddl回収条件未満回収方法.FormattingEnabled = True
        Me.ddl回収条件未満回収方法.IsError = False
        Me.ddl回収条件未満回収方法.ListType = NodeUI.List.Type.None
        Me.ddl回収条件未満回収方法.Location = New System.Drawing.Point(530, 67)
        Me.ddl回収条件未満回収方法.Name = "ddl回収条件未満回収方法"
        Me.ddl回収条件未満回収方法.Required = True
        Me.ddl回収条件未満回収方法.Size = New System.Drawing.Size(121, 24)
        Me.ddl回収条件未満回収方法.TabIndex = 8
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.0!)
        Me.Label9.Location = New System.Drawing.Point(349, 71)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(175, 15)
        Me.Label9.TabIndex = 26
        Me.Label9.Text = "日に回収する(99:末日)"
        '
        'txt回収条件未満回収日
        '
        Me.txt回収条件未満回収日.FieldLockType = BaseContents.Field.LockType.None
        Me.txt回収条件未満回収日.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt回収条件未満回収日.HelpKeys = ""
        Me.txt回収条件未満回収日.HelpLink = ""
        Me.txt回収条件未満回収日.HelpType = NodeUI.Help.Type.None
        Me.txt回収条件未満回収日.IsError = False
        Me.txt回収条件未満回収日.Location = New System.Drawing.Point(318, 67)
        Me.txt回収条件未満回収日.Name = "txt回収条件未満回収日"
        Me.txt回収条件未満回収日.Required = True
        Me.txt回収条件未満回収日.Size = New System.Drawing.Size(25, 23)
        Me.txt回収条件未満回収日.TabIndex = 7
        Me.txt回収条件未満回収日.Text = "99"
        Me.txt回収条件未満回収日.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.0!)
        Me.Label10.Location = New System.Drawing.Point(261, 71)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(55, 15)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "ヵ月後"
        '
        'txt回収条件未満回収月
        '
        Me.txt回収条件未満回収月.FieldLockType = BaseContents.Field.LockType.None
        Me.txt回収条件未満回収月.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt回収条件未満回収月.HelpKeys = ""
        Me.txt回収条件未満回収月.HelpLink = ""
        Me.txt回収条件未満回収月.HelpType = NodeUI.Help.Type.None
        Me.txt回収条件未満回収月.IsError = False
        Me.txt回収条件未満回収月.Location = New System.Drawing.Point(230, 67)
        Me.txt回収条件未満回収月.Name = "txt回収条件未満回収月"
        Me.txt回収条件未満回収月.Required = True
        Me.txt回収条件未満回収月.Size = New System.Drawing.Size(25, 23)
        Me.txt回収条件未満回収月.TabIndex = 6
        Me.txt回収条件未満回収月.Text = "99"
        Me.txt回収条件未満回収月.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.0!)
        Me.Label8.Location = New System.Drawing.Point(123, 71)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(103, 15)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "円未満の場合"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.0!)
        Me.Label7.Location = New System.Drawing.Point(60, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(23, 15)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "〃"
        '
        'ddl回収条件以上回収方法
        '
        Me.ddl回収条件以上回収方法.AutoDropDown = True
        Me.ddl回収条件以上回収方法.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddl回収条件以上回収方法.FieldLockType = BaseContents.Field.LockType.None
        Me.ddl回収条件以上回収方法.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.ddl回収条件以上回収方法.FormattingEnabled = True
        Me.ddl回収条件以上回収方法.IsError = False
        Me.ddl回収条件以上回収方法.ListType = NodeUI.List.Type.None
        Me.ddl回収条件以上回収方法.Location = New System.Drawing.Point(530, 24)
        Me.ddl回収条件以上回収方法.Name = "ddl回収条件以上回収方法"
        Me.ddl回収条件以上回収方法.Required = True
        Me.ddl回収条件以上回収方法.Size = New System.Drawing.Size(121, 24)
        Me.ddl回収条件以上回収方法.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.0!)
        Me.Label6.Location = New System.Drawing.Point(349, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(175, 15)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "日に回収する(99:末日)"
        '
        'txt回収条件以上回収日
        '
        Me.txt回収条件以上回収日.FieldLockType = BaseContents.Field.LockType.None
        Me.txt回収条件以上回収日.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt回収条件以上回収日.HelpKeys = ""
        Me.txt回収条件以上回収日.HelpLink = ""
        Me.txt回収条件以上回収日.HelpType = NodeUI.Help.Type.None
        Me.txt回収条件以上回収日.IsError = False
        Me.txt回収条件以上回収日.Location = New System.Drawing.Point(318, 24)
        Me.txt回収条件以上回収日.Name = "txt回収条件以上回収日"
        Me.txt回収条件以上回収日.Required = True
        Me.txt回収条件以上回収日.Size = New System.Drawing.Size(25, 23)
        Me.txt回収条件以上回収日.TabIndex = 3
        Me.txt回収条件以上回収日.Text = "99"
        Me.txt回収条件以上回収日.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.0!)
        Me.Label5.Location = New System.Drawing.Point(261, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 15)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "ヵ月後"
        '
        'txt回収条件以上回収月
        '
        Me.txt回収条件以上回収月.FieldLockType = BaseContents.Field.LockType.None
        Me.txt回収条件以上回収月.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt回収条件以上回収月.HelpKeys = ""
        Me.txt回収条件以上回収月.HelpLink = ""
        Me.txt回収条件以上回収月.HelpType = NodeUI.Help.Type.None
        Me.txt回収条件以上回収月.IsError = False
        Me.txt回収条件以上回収月.Location = New System.Drawing.Point(230, 24)
        Me.txt回収条件以上回収月.Name = "txt回収条件以上回収月"
        Me.txt回収条件以上回収月.Required = True
        Me.txt回収条件以上回収月.Size = New System.Drawing.Size(25, 23)
        Me.txt回収条件以上回収月.TabIndex = 2
        Me.txt回収条件以上回収月.Text = "99"
        Me.txt回収条件以上回収月.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(123, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "円以上の場合"
        '
        'txt回収条件設定金額
        '
        Me.txt回収条件設定金額.FieldLockType = BaseContents.Field.LockType.None
        Me.txt回収条件設定金額.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt回収条件設定金額.HelpKeys = ""
        Me.txt回収条件設定金額.HelpLink = ""
        Me.txt回収条件設定金額.HelpType = NodeUI.Help.Type.None
        Me.txt回収条件設定金額.IsError = False
        Me.txt回収条件設定金額.Location = New System.Drawing.Point(19, 24)
        Me.txt回収条件設定金額.Name = "txt回収条件設定金額"
        Me.txt回収条件設定金額.Required = False
        Me.txt回収条件設定金額.Size = New System.Drawing.Size(100, 23)
        Me.txt回収条件設定金額.TabIndex = 0
        Me.txt回収条件設定金額.Text = "999,999,999"
        Me.txt回収条件設定金額.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt回収条件設定金額.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'btn詳細情報
        '
        Me.btn詳細情報.FieldLockType = BaseContents.Field.LockType.None
        Me.btn詳細情報.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.btn詳細情報.Location = New System.Drawing.Point(1, 8)
        Me.btn詳細情報.Name = "btn詳細情報"
        Me.btn詳細情報.Size = New System.Drawing.Size(208, 51)
        Me.btn詳細情報.TabIndex = 23
        Me.btn詳細情報.Text = "詳細情報画面へ進む"
        Me.btn詳細情報.UseVisualStyleBackColor = True
        '
        'grp請求書用得意先名
        '
        Me.grp請求書用得意先名.Controls.Add(Me.txt請求書用得意先名2)
        Me.grp請求書用得意先名.Controls.Add(Me.txt請求書用得意先名1)
        Me.grp請求書用得意先名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp請求書用得意先名.Location = New System.Drawing.Point(728, 100)
        Me.grp請求書用得意先名.Name = "grp請求書用得意先名"
        Me.grp請求書用得意先名.Size = New System.Drawing.Size(290, 85)
        Me.grp請求書用得意先名.TabIndex = 8
        Me.grp請求書用得意先名.TabStop = False
        Me.grp請求書用得意先名.Text = "請求書用得意先名"
        '
        'txt請求書用得意先名2
        '
        Me.txt請求書用得意先名2.FieldLockType = BaseContents.Field.LockType.None
        Me.txt請求書用得意先名2.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt請求書用得意先名2.HelpKeys = ""
        Me.txt請求書用得意先名2.HelpLink = ""
        Me.txt請求書用得意先名2.HelpType = NodeUI.Help.Type.None
        Me.txt請求書用得意先名2.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt請求書用得意先名2.IsError = False
        Me.txt請求書用得意先名2.Location = New System.Drawing.Point(19, 45)
        Me.txt請求書用得意先名2.Name = "txt請求書用得意先名2"
        Me.txt請求書用得意先名2.Required = False
        Me.txt請求書用得意先名2.Size = New System.Drawing.Size(264, 23)
        Me.txt請求書用得意先名2.StringLength = 65535
        Me.txt請求書用得意先名2.TabIndex = 1
        Me.txt請求書用得意先名2.Text = "ああああああああああいいいいいい"
        Me.txt請求書用得意先名2.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt請求書用得意先名1
        '
        Me.txt請求書用得意先名1.FieldLockType = BaseContents.Field.LockType.None
        Me.txt請求書用得意先名1.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt請求書用得意先名1.HelpKeys = ""
        Me.txt請求書用得意先名1.HelpLink = ""
        Me.txt請求書用得意先名1.HelpType = NodeUI.Help.Type.None
        Me.txt請求書用得意先名1.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt請求書用得意先名1.IsError = False
        Me.txt請求書用得意先名1.Location = New System.Drawing.Point(19, 25)
        Me.txt請求書用得意先名1.Name = "txt請求書用得意先名1"
        Me.txt請求書用得意先名1.Required = False
        Me.txt請求書用得意先名1.Size = New System.Drawing.Size(264, 23)
        Me.txt請求書用得意先名1.StringLength = 65535
        Me.txt請求書用得意先名1.TabIndex = 0
        Me.txt請求書用得意先名1.Text = "ああああああああああいいいいいい"
        Me.txt請求書用得意先名1.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp詳細情報
        '
        Me.grp詳細情報.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.grp詳細情報.Controls.Add(Me.btn詳細情報)
        Me.grp詳細情報.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp詳細情報.Location = New System.Drawing.Point(729, 523)
        Me.grp詳細情報.Name = "grp詳細情報"
        Me.grp詳細情報.Size = New System.Drawing.Size(210, 61)
        Me.grp詳細情報.TabIndex = 23
        Me.grp詳細情報.TabStop = False
        '
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.grp詳細情報)
        Me.Controls.Add(Me.grp請求書用得意先名)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.grp消費税区分)
        Me.Controls.Add(Me.grp売伝パターンCD)
        Me.Controls.Add(Me.grp仮伝パターンCD)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.grp集計用得意先)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.grp重要度)
        Me.Controls.Add(Me.grp紙種別区分)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.grp担当者)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpFAX)
        Me.Controls.Add(Me.grp代表者役職_代表者名)
        Me.Controls.Add(Me.grp役職_担当者名)
        Me.Controls.Add(Me.grpカナ名)
        Me.Controls.Add(Me.grpTEL)
        Me.Controls.Add(Me.grp住所)
        Me.Controls.Add(Me.grp郵便番号)
        Me.Controls.Add(Me.grp得意先名)
        Me.Controls.Add(Me.grp得意先CD)
        Me.Controls.Add(Me.grp処理区分)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmCustomer"
        Me.Text = ""
        Me.Controls.SetChildIndex(Me.grp処理区分, 0)
        Me.Controls.SetChildIndex(Me.grp得意先CD, 0)
        Me.Controls.SetChildIndex(Me.grp得意先名, 0)
        Me.Controls.SetChildIndex(Me.grp郵便番号, 0)
        Me.Controls.SetChildIndex(Me.grp住所, 0)
        Me.Controls.SetChildIndex(Me.grpTEL, 0)
        Me.Controls.SetChildIndex(Me.grpカナ名, 0)
        Me.Controls.SetChildIndex(Me.grp役職_担当者名, 0)
        Me.Controls.SetChildIndex(Me.grp代表者役職_代表者名, 0)
        Me.Controls.SetChildIndex(Me.grpFAX, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.grp担当者, 0)
        Me.Controls.SetChildIndex(Me.GroupBox2, 0)
        Me.Controls.SetChildIndex(Me.grp紙種別区分, 0)
        Me.Controls.SetChildIndex(Me.grp重要度, 0)
        Me.Controls.SetChildIndex(Me.GroupBox3, 0)
        Me.Controls.SetChildIndex(Me.grp集計用得意先, 0)
        Me.Controls.SetChildIndex(Me.GroupBox4, 0)
        Me.Controls.SetChildIndex(Me.grp仮伝パターンCD, 0)
        Me.Controls.SetChildIndex(Me.grp売伝パターンCD, 0)
        Me.Controls.SetChildIndex(Me.grp消費税区分, 0)
        Me.Controls.SetChildIndex(Me.GroupBox6, 0)
        Me.Controls.SetChildIndex(Me.grp請求書用得意先名, 0)
        Me.Controls.SetChildIndex(Me.grp詳細情報, 0)
        Me.grp処理区分.ResumeLayout(False)
        Me.grp処理区分.PerformLayout()
        Me.grp得意先CD.ResumeLayout(False)
        Me.grp得意先CD.PerformLayout()
        Me.grp得意先名.ResumeLayout(False)
        Me.grp得意先名.PerformLayout()
        Me.grp住所.ResumeLayout(False)
        Me.grp住所.PerformLayout()
        Me.grpTEL.ResumeLayout(False)
        Me.grpTEL.PerformLayout()
        Me.grp郵便番号.ResumeLayout(False)
        Me.grp郵便番号.PerformLayout()
        Me.grpカナ名.ResumeLayout(False)
        Me.grpカナ名.PerformLayout()
        Me.grp役職_担当者名.ResumeLayout(False)
        Me.grp役職_担当者名.PerformLayout()
        Me.grp代表者役職_代表者名.ResumeLayout(False)
        Me.grp代表者役職_代表者名.PerformLayout()
        Me.grpFAX.ResumeLayout(False)
        Me.grpFAX.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grp担当者.ResumeLayout(False)
        Me.grp担当者.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.grp紙種別区分.ResumeLayout(False)
        Me.grp重要度.ResumeLayout(False)
        Me.grp重要度.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.grp集計用得意先.ResumeLayout(False)
        Me.grp集計用得意先.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.grp仮伝パターンCD.ResumeLayout(False)
        Me.grp仮伝パターンCD.PerformLayout()
        Me.grp売伝パターンCD.ResumeLayout(False)
        Me.grp売伝パターンCD.PerformLayout()
        Me.grp消費税区分.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.grp請求書用得意先名.ResumeLayout(False)
        Me.grp請求書用得意先名.PerformLayout()
        Me.grp詳細情報.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp処理区分 As BaseUI.Control.GroupBox
    Friend WithEvents opt削除 As BaseUI.Control.RadioButton
    Friend WithEvents opt修正 As BaseUI.Control.RadioButton
    Friend WithEvents opt登録 As BaseUI.Control.RadioButton
    Friend WithEvents grp得意先CD As BaseUI.Control.GroupBox
    Friend WithEvents txt得意先CD As BaseUI.Control.TextBox
    Friend WithEvents grp得意先名 As BaseUI.Control.GroupBox
    Friend WithEvents txt得意先名 As BaseUI.Control.TextBox
    Friend WithEvents grp住所 As BaseUI.Control.GroupBox
    Friend WithEvents txt住所2 As BaseUI.Control.TextBox
    Friend WithEvents txt住所1 As BaseUI.Control.TextBox
    Friend WithEvents grpTEL As BaseUI.Control.GroupBox
    Friend WithEvents txtTEL As BaseUI.Control.TextBox
    Friend WithEvents txt郵便番号 As BaseUI.Control.TextBox
    Friend WithEvents grp郵便番号 As BaseUI.Control.GroupBox
    Friend WithEvents grpカナ名 As BaseUI.Control.GroupBox
    Friend WithEvents txtカナ名 As BaseUI.Control.TextBox
    Friend WithEvents grp役職_担当者名 As BaseUI.Control.GroupBox
    Friend WithEvents txt役職_担当者名 As BaseUI.Control.TextBox
    Friend WithEvents grp代表者役職_代表者名 As BaseUI.Control.GroupBox
    Friend WithEvents txt代表者役職_代表者名1 As BaseUI.Control.TextBox
    Friend WithEvents grpFAX As BaseUI.Control.GroupBox
    Friend WithEvents txtFAX As BaseUI.Control.TextBox
    Friend WithEvents GroupBox1 As BaseUI.Control.GroupBox
    Friend WithEvents txt代表者役職_代表者名2 As BaseUI.Control.TextBox
    Friend WithEvents grp担当者 As BaseUI.Control.GroupBox
    Friend WithEvents nam自社担当者名 As BaseUI.Control.NameBox
    Friend WithEvents txt自社担当者CD As BaseUI.Control.TextBox
    Friend WithEvents GroupBox2 As BaseUI.Control.GroupBox
    Friend WithEvents lbl締日 As BaseUI.Control.Label
    Friend WithEvents txt締日 As BaseUI.Control.TextBox
    Friend WithEvents grp紙種別区分 As BaseUI.Control.GroupBox
    Friend WithEvents ddl請求書発行区分 As BaseUI.Control.ComboBox
    Friend WithEvents grp重要度 As BaseUI.Control.GroupBox
    Friend WithEvents nam重要度名 As BaseUI.Control.NameBox
    Friend WithEvents txt重要度 As BaseUI.Control.TextBox
    Friend WithEvents Label1 As BaseUI.Control.Label
    Friend WithEvents Label3 As BaseUI.Control.Label
    Friend WithEvents Label2 As BaseUI.Control.Label
    Friend WithEvents GroupBox3 As BaseUI.Control.GroupBox
    Friend WithEvents txt御客様NO As BaseUI.Control.TextBox
    Friend WithEvents grp集計用得意先 As BaseUI.Control.GroupBox
    Friend WithEvents nam集計用得意先名 As BaseUI.Control.NameBox
    Friend WithEvents txt集計用得意先CD As BaseUI.Control.TextBox
    Friend WithEvents GroupBox4 As BaseUI.Control.GroupBox
    Friend WithEvents nam表示振替用得意先名 As BaseUI.Control.NameBox
    Friend WithEvents txt表示振替用得意先CD As BaseUI.Control.TextBox
    Friend WithEvents grp仮伝パターンCD As BaseUI.Control.GroupBox
    Friend WithEvents nam仮伝パターン名 As BaseUI.Control.NameBox
    Friend WithEvents txt仮伝パターンCD As BaseUI.Control.TextBox
    Friend WithEvents grp売伝パターンCD As BaseUI.Control.GroupBox
    Friend WithEvents nam売伝パターン名 As BaseUI.Control.NameBox
    Friend WithEvents txt売伝パターンCD As BaseUI.Control.TextBox
    Friend WithEvents grp消費税区分 As BaseUI.Control.GroupBox
    Friend WithEvents ddl消費税区分 As BaseUI.Control.ComboBox
    Friend WithEvents GroupBox6 As BaseUI.Control.GroupBox
    Friend WithEvents Label4 As BaseUI.Control.Label
    Friend WithEvents txt回収条件設定金額 As BaseUI.Control.TextBox
    Friend WithEvents ddl回収条件未満回収方法 As BaseUI.Control.ComboBox
    Friend WithEvents Label9 As BaseUI.Control.Label
    Friend WithEvents txt回収条件未満回収日 As BaseUI.Control.TextBox
    Friend WithEvents Label10 As BaseUI.Control.Label
    Friend WithEvents txt回収条件未満回収月 As BaseUI.Control.TextBox
    Friend WithEvents Label8 As BaseUI.Control.Label
    Friend WithEvents Label7 As BaseUI.Control.Label
    Friend WithEvents ddl回収条件以上回収方法 As BaseUI.Control.ComboBox
    Friend WithEvents Label6 As BaseUI.Control.Label
    Friend WithEvents txt回収条件以上回収日 As BaseUI.Control.TextBox
    Friend WithEvents Label5 As BaseUI.Control.Label
    Friend WithEvents txt回収条件以上回収月 As BaseUI.Control.TextBox
    Friend WithEvents btn詳細情報 As BaseUI.Control.Button
    Friend WithEvents grp請求書用得意先名 As BaseUI.Control.GroupBox
    Friend WithEvents txt請求書用得意先名2 As BaseUI.Control.TextBox
    Friend WithEvents txt請求書用得意先名1 As BaseUI.Control.TextBox
    Friend WithEvents grp詳細情報 As BaseUI.Control.GroupBox
End Class
