<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupplier
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
        Me.txt仕入先CD = New BaseUI.Control.TextBox()
        Me.grp仕入先名 = New BaseUI.Control.GroupBox()
        Me.txt仕入先名 = New BaseUI.Control.TextBox()
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
        Me.grp買掛金_未払金区分 = New BaseUI.Control.GroupBox()
        Me.ddl買掛金_未払金区分 = New BaseUI.Control.ComboBox()
        Me.btn詳細情報 = New BaseUI.Control.Button()
        Me.grp略称 = New BaseUI.Control.GroupBox()
        Me.txt略称 = New BaseUI.Control.TextBox()
        Me.grp処理区分.SuspendLayout()
        Me.grp仕入先CD.SuspendLayout()
        Me.grp仕入先名.SuspendLayout()
        Me.grp住所.SuspendLayout()
        Me.grpTEL.SuspendLayout()
        Me.grp郵便番号.SuspendLayout()
        Me.grpカナ名.SuspendLayout()
        Me.grp役職_担当者名.SuspendLayout()
        Me.grp代表者役職_代表者名.SuspendLayout()
        Me.grpFAX.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grp買掛金_未払金区分.SuspendLayout()
        Me.grp略称.SuspendLayout()
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
        'grp仕入先CD
        '
        Me.grp仕入先CD.Controls.Add(Me.txt仕入先CD)
        Me.grp仕入先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp仕入先CD.Location = New System.Drawing.Point(29, 100)
        Me.grp仕入先CD.Name = "grp仕入先CD"
        Me.grp仕入先CD.Size = New System.Drawing.Size(104, 61)
        Me.grp仕入先CD.TabIndex = 1
        Me.grp仕入先CD.TabStop = False
        Me.grp仕入先CD.Text = "仕入先CD"
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
        Me.txt仕入先CD.Location = New System.Drawing.Point(19, 25)
        Me.txt仕入先CD.Name = "txt仕入先CD"
        Me.txt仕入先CD.Required = False
        Me.txt仕入先CD.Size = New System.Drawing.Size(61, 23)
        Me.txt仕入先CD.TabIndex = 0
        Me.txt仕入先CD.Text = "999999"
        Me.txt仕入先CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp仕入先名
        '
        Me.grp仕入先名.Controls.Add(Me.txt仕入先名)
        Me.grp仕入先名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp仕入先名.Location = New System.Drawing.Point(140, 100)
        Me.grp仕入先名.Name = "grp仕入先名"
        Me.grp仕入先名.Size = New System.Drawing.Size(312, 61)
        Me.grp仕入先名.TabIndex = 2
        Me.grp仕入先名.TabStop = False
        Me.grp仕入先名.Text = "仕入先名"
        '
        'txt仕入先名
        '
        Me.txt仕入先名.FieldLockType = BaseContents.Field.LockType.None
        Me.txt仕入先名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt仕入先名.HelpKeys = ""
        Me.txt仕入先名.HelpLink = ""
        Me.txt仕入先名.HelpType = NodeUI.Help.Type.None
        Me.txt仕入先名.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt仕入先名.IsError = False
        Me.txt仕入先名.Location = New System.Drawing.Point(19, 25)
        Me.txt仕入先名.Name = "txt仕入先名"
        Me.txt仕入先名.Required = False
        Me.txt仕入先名.Size = New System.Drawing.Size(264, 23)
        Me.txt仕入先名.TabIndex = 0
        Me.txt仕入先名.Text = "ああああああああああいいいいいい"
        Me.txt仕入先名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp住所
        '
        Me.grp住所.Controls.Add(Me.txt住所2)
        Me.grp住所.Controls.Add(Me.txt住所1)
        Me.grp住所.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp住所.Location = New System.Drawing.Point(140, 199)
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
        Me.txt住所1.TabIndex = 0
        Me.txt住所1.Text = "ああああああああああいいいいいい"
        Me.txt住所1.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grpTEL
        '
        Me.grpTEL.Controls.Add(Me.txtTEL)
        Me.grpTEL.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grpTEL.Location = New System.Drawing.Point(436, 199)
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
        Me.txt郵便番号.TabIndex = 0
        Me.txt郵便番号.Text = "999-9999"
        Me.txt郵便番号.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp郵便番号
        '
        Me.grp郵便番号.Controls.Add(Me.txt郵便番号)
        Me.grp郵便番号.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp郵便番号.Location = New System.Drawing.Point(29, 199)
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
        Me.grpカナ名.Location = New System.Drawing.Point(29, 397)
        Me.grpカナ名.Name = "grpカナ名"
        Me.grpカナ名.Size = New System.Drawing.Size(152, 61)
        Me.grpカナ名.TabIndex = 11
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
        Me.txtカナ名.TabIndex = 0
        Me.txtカナ名.Text = "あああああ"
        Me.txtカナ名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp役職_担当者名
        '
        Me.grp役職_担当者名.Controls.Add(Me.txt役職_担当者名)
        Me.grp役職_担当者名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp役職_担当者名.Location = New System.Drawing.Point(29, 298)
        Me.grp役職_担当者名.Name = "grp役職_担当者名"
        Me.grp役職_担当者名.Size = New System.Drawing.Size(220, 61)
        Me.grp役職_担当者名.TabIndex = 8
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
        Me.txt役職_担当者名.TabIndex = 0
        Me.txt役職_担当者名.Text = "ああああああああああい"
        Me.txt役職_担当者名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp代表者役職_代表者名
        '
        Me.grp代表者役職_代表者名.Controls.Add(Me.txt代表者役職_代表者名1)
        Me.grp代表者役職_代表者名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp代表者役職_代表者名.Location = New System.Drawing.Point(255, 298)
        Me.grp代表者役職_代表者名.Name = "grp代表者役職_代表者名"
        Me.grp代表者役職_代表者名.Size = New System.Drawing.Size(312, 61)
        Me.grp代表者役職_代表者名.TabIndex = 9
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
        Me.txt代表者役職_代表者名1.TabIndex = 0
        Me.txt代表者役職_代表者名1.Text = "ああああああああああいいいいいい"
        Me.txt代表者役職_代表者名1.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grpFAX
        '
        Me.grpFAX.Controls.Add(Me.txtFAX)
        Me.grpFAX.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grpFAX.Location = New System.Drawing.Point(582, 199)
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
        Me.txtFAX.TabIndex = 0
        Me.txtFAX.Text = "999-9999-9999"
        Me.txtFAX.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt代表者役職_代表者名2)
        Me.GroupBox1.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.GroupBox1.Location = New System.Drawing.Point(573, 298)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(312, 61)
        Me.GroupBox1.TabIndex = 10
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
        Me.txt代表者役職_代表者名2.TabIndex = 0
        Me.txt代表者役職_代表者名2.Text = "ああああああああああいいいいいい"
        Me.txt代表者役職_代表者名2.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp買掛金_未払金区分
        '
        Me.grp買掛金_未払金区分.Controls.Add(Me.ddl買掛金_未払金区分)
        Me.grp買掛金_未払金区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp買掛金_未払金区分.Location = New System.Drawing.Point(29, 496)
        Me.grp買掛金_未払金区分.Name = "grp買掛金_未払金区分"
        Me.grp買掛金_未払金区分.Size = New System.Drawing.Size(170, 61)
        Me.grp買掛金_未払金区分.TabIndex = 12
        Me.grp買掛金_未払金区分.TabStop = False
        Me.grp買掛金_未払金区分.Text = "買掛金・未払金区分"
        '
        'ddl買掛金_未払金区分
        '
        Me.ddl買掛金_未払金区分.AutoDropDown = True
        Me.ddl買掛金_未払金区分.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddl買掛金_未払金区分.FieldLockType = BaseContents.Field.LockType.None
        Me.ddl買掛金_未払金区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.ddl買掛金_未払金区分.FormattingEnabled = True
        Me.ddl買掛金_未払金区分.IsError = False
        Me.ddl買掛金_未払金区分.ListType = NodeUI.List.Type.None
        Me.ddl買掛金_未払金区分.Location = New System.Drawing.Point(19, 23)
        Me.ddl買掛金_未払金区分.Name = "ddl買掛金_未払金区分"
        Me.ddl買掛金_未払金区分.Required = False
        Me.ddl買掛金_未払金区分.Size = New System.Drawing.Size(133, 24)
        Me.ddl買掛金_未払金区分.TabIndex = 0
        '
        'btn詳細情報
        '
        Me.btn詳細情報.FieldLockType = BaseContents.Field.LockType.None
        Me.btn詳細情報.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.btn詳細情報.Location = New System.Drawing.Point(720, 541)
        Me.btn詳細情報.Name = "btn詳細情報"
        Me.btn詳細情報.Size = New System.Drawing.Size(208, 51)
        Me.btn詳細情報.TabIndex = 23
        Me.btn詳細情報.Text = "詳細情報画面へ進む"
        Me.btn詳細情報.UseVisualStyleBackColor = True
        '
        'grp略称
        '
        Me.grp略称.Controls.Add(Me.txt略称)
        Me.grp略称.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp略称.Location = New System.Drawing.Point(465, 100)
        Me.grp略称.Name = "grp略称"
        Me.grp略称.Size = New System.Drawing.Size(175, 61)
        Me.grp略称.TabIndex = 3
        Me.grp略称.TabStop = False
        Me.grp略称.Text = "略称"
        '
        'txt略称
        '
        Me.txt略称.FieldLockType = BaseContents.Field.LockType.None
        Me.txt略称.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt略称.HelpKeys = ""
        Me.txt略称.HelpLink = ""
        Me.txt略称.HelpType = NodeUI.Help.Type.None
        Me.txt略称.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt略称.IsError = False
        Me.txt略称.Location = New System.Drawing.Point(19, 25)
        Me.txt略称.Name = "txt略称"
        Me.txt略称.Required = False
        Me.txt略称.Size = New System.Drawing.Size(135, 23)
        Me.txt略称.TabIndex = 0
        Me.txt略称.Text = "ああああああああ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txt略称.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'frmSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.grp略称)
        Me.Controls.Add(Me.btn詳細情報)
        Me.Controls.Add(Me.grp買掛金_未払金区分)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.grpFAX)
        Me.Controls.Add(Me.grp代表者役職_代表者名)
        Me.Controls.Add(Me.grp役職_担当者名)
        Me.Controls.Add(Me.grpカナ名)
        Me.Controls.Add(Me.grpTEL)
        Me.Controls.Add(Me.grp住所)
        Me.Controls.Add(Me.grp郵便番号)
        Me.Controls.Add(Me.grp仕入先名)
        Me.Controls.Add(Me.grp仕入先CD)
        Me.Controls.Add(Me.grp処理区分)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmSupplier"
        Me.Text = ""
        Me.Controls.SetChildIndex(Me.grp処理区分, 0)
        Me.Controls.SetChildIndex(Me.grp仕入先CD, 0)
        Me.Controls.SetChildIndex(Me.grp仕入先名, 0)
        Me.Controls.SetChildIndex(Me.grp郵便番号, 0)
        Me.Controls.SetChildIndex(Me.grp住所, 0)
        Me.Controls.SetChildIndex(Me.grpTEL, 0)
        Me.Controls.SetChildIndex(Me.grpカナ名, 0)
        Me.Controls.SetChildIndex(Me.grp役職_担当者名, 0)
        Me.Controls.SetChildIndex(Me.grp代表者役職_代表者名, 0)
        Me.Controls.SetChildIndex(Me.grpFAX, 0)
        Me.Controls.SetChildIndex(Me.GroupBox1, 0)
        Me.Controls.SetChildIndex(Me.grp買掛金_未払金区分, 0)
        Me.Controls.SetChildIndex(Me.btn詳細情報, 0)
        Me.Controls.SetChildIndex(Me.grp略称, 0)
        Me.grp処理区分.ResumeLayout(False)
        Me.grp処理区分.PerformLayout()
        Me.grp仕入先CD.ResumeLayout(False)
        Me.grp仕入先CD.PerformLayout()
        Me.grp仕入先名.ResumeLayout(False)
        Me.grp仕入先名.PerformLayout()
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
        Me.grp買掛金_未払金区分.ResumeLayout(False)
        Me.grp略称.ResumeLayout(False)
        Me.grp略称.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp処理区分 As BaseUI.Control.GroupBox
    Friend WithEvents opt削除 As BaseUI.Control.RadioButton
    Friend WithEvents opt修正 As BaseUI.Control.RadioButton
    Friend WithEvents opt登録 As BaseUI.Control.RadioButton
    Friend WithEvents grp仕入先CD As BaseUI.Control.GroupBox
    Friend WithEvents txt仕入先CD As BaseUI.Control.TextBox
    Friend WithEvents grp仕入先名 As BaseUI.Control.GroupBox
    Friend WithEvents txt仕入先名 As BaseUI.Control.TextBox
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
    Friend WithEvents grp買掛金_未払金区分 As BaseUI.Control.GroupBox
    Friend WithEvents ddl買掛金_未払金区分 As BaseUI.Control.ComboBox
    Friend WithEvents btn詳細情報 As BaseUI.Control.Button
    Friend WithEvents grp略称 As BaseUI.Control.GroupBox
    Friend WithEvents txt略称 As BaseUI.Control.TextBox
End Class
