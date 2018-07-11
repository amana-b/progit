<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmYamatoDate
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
        Me.grpﾃﾞｰﾀ区分 = New BaseUI.Control.GroupBox()
        Me.txtﾃﾞｰﾀ区分 = New BaseUI.Control.TextBox()
        Me.grpﾃﾞｰﾀ区分名 = New BaseUI.Control.GroupBox()
        Me.txtﾃﾞｰﾀ区分名 = New BaseUI.Control.TextBox()
        Me.grp品名CD = New BaseUI.Control.GroupBox()
        Me.lbl品名 = New BaseUI.Control.NameBox()
        Me.txt品名CD = New BaseUI.Control.TextBox()
        Me.grp種別内訳区分 = New BaseUI.Control.GroupBox()
        Me.ddl種別内訳区分 = New BaseUI.Control.ComboBox()
        Me.grb黒猫メール便バーコード情報 = New BaseUI.Control.GroupBox()
        Me.Label7 = New BaseUI.Control.Label()
        Me.Label8 = New BaseUI.Control.Label()
        Me.txtバーコード次回No3 = New BaseUI.Control.TextBox()
        Me.Label9 = New BaseUI.Control.Label()
        Me.txtバーコード次回No2 = New BaseUI.Control.TextBox()
        Me.txtバーコード次回No1 = New BaseUI.Control.TextBox()
        Me.Label4 = New BaseUI.Control.Label()
        Me.Label5 = New BaseUI.Control.Label()
        Me.txtバーコード終了No3 = New BaseUI.Control.TextBox()
        Me.Label6 = New BaseUI.Control.Label()
        Me.txtバーコード終了No2 = New BaseUI.Control.TextBox()
        Me.txtバーコード終了No1 = New BaseUI.Control.TextBox()
        Me.Label3 = New BaseUI.Control.Label()
        Me.Label2 = New BaseUI.Control.Label()
        Me.txtバーコード開始No3 = New BaseUI.Control.TextBox()
        Me.Label1 = New BaseUI.Control.Label()
        Me.txtバーコード開始No2 = New BaseUI.Control.TextBox()
        Me.txtバーコード開始No1 = New BaseUI.Control.TextBox()
        Me.grp材料請求時単価 = New BaseUI.Control.GroupBox()
        Me.Label10 = New BaseUI.Control.Label()
        Me.txt材料請求時単価 = New BaseUI.Control.TextBox()
        Me.grb受注単価 = New BaseUI.Control.GroupBox()
        Me.Label11 = New BaseUI.Control.Label()
        Me.txt受注単価 = New BaseUI.Control.TextBox()
        Me.ｇｒｂ最大ｹｰｽ数 = New BaseUI.Control.GroupBox()
        Me.Label13 = New BaseUI.Control.Label()
        Me.txt最大ｹｰｽ数 = New BaseUI.Control.TextBox()
        Me.txt入数 = New BaseUI.Control.TextBox()
        Me.grb入数 = New BaseUI.Control.GroupBox()
        Me.Label12 = New BaseUI.Control.Label()
        Me.grp略称 = New BaseUI.Control.GroupBox()
        Me.txt略称 = New BaseUI.Control.TextBox()
        Me.grp光村印刷得意先CD = New BaseUI.Control.GroupBox()
        Me.lbl光村印刷得意先名 = New BaseUI.Control.NameBox()
        Me.txt光村印刷得意先CD = New BaseUI.Control.TextBox()
        Me.grp光村印刷出荷先CD = New BaseUI.Control.GroupBox()
        Me.lbl光村印刷出荷先名 = New BaseUI.Control.NameBox()
        Me.txt光村印刷出荷先CD = New BaseUI.Control.TextBox()
        Me.grp材料請求時品名 = New BaseUI.Control.GroupBox()
        Me.txt材料請求時品名 = New BaseUI.Control.TextBox()
        Me.grp処理区分.SuspendLayout()
        Me.grpﾃﾞｰﾀ区分.SuspendLayout()
        Me.grpﾃﾞｰﾀ区分名.SuspendLayout()
        Me.grp品名CD.SuspendLayout()
        Me.grp種別内訳区分.SuspendLayout()
        Me.grb黒猫メール便バーコード情報.SuspendLayout()
        Me.grp材料請求時単価.SuspendLayout()
        Me.grb受注単価.SuspendLayout()
        Me.ｇｒｂ最大ｹｰｽ数.SuspendLayout()
        Me.grb入数.SuspendLayout()
        Me.grp略称.SuspendLayout()
        Me.grp光村印刷得意先CD.SuspendLayout()
        Me.grp光村印刷出荷先CD.SuspendLayout()
        Me.grp材料請求時品名.SuspendLayout()
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
        Me.opt削除.FieldKeyType = BaseContents.Field.KeyType.None
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
        Me.opt修正.FieldKeyType = BaseContents.Field.KeyType.None
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
        Me.opt登録.FieldKeyType = BaseContents.Field.KeyType.None
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
        'grpﾃﾞｰﾀ区分
        '
        Me.grpﾃﾞｰﾀ区分.Controls.Add(Me.txtﾃﾞｰﾀ区分)
        Me.grpﾃﾞｰﾀ区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grpﾃﾞｰﾀ区分.Location = New System.Drawing.Point(29, 107)
        Me.grpﾃﾞｰﾀ区分.Name = "grpﾃﾞｰﾀ区分"
        Me.grpﾃﾞｰﾀ区分.Size = New System.Drawing.Size(90, 61)
        Me.grpﾃﾞｰﾀ区分.TabIndex = 1
        Me.grpﾃﾞｰﾀ区分.TabStop = False
        Me.grpﾃﾞｰﾀ区分.Text = "ﾃﾞｰﾀ区分"
        '
        'txtﾃﾞｰﾀ区分
        '
        Me.txtﾃﾞｰﾀ区分.FieldKeyType = BaseContents.Field.KeyType.Key
        Me.txtﾃﾞｰﾀ区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txtﾃﾞｰﾀ区分.HelpKeys = ""
        Me.txtﾃﾞｰﾀ区分.HelpLink = ""
        Me.txtﾃﾞｰﾀ区分.HelpType = NodeUI.Help.Type.None
        Me.txtﾃﾞｰﾀ区分.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtﾃﾞｰﾀ区分.IsError = False
        Me.txtﾃﾞｰﾀ区分.Location = New System.Drawing.Point(19, 25)
        Me.txtﾃﾞｰﾀ区分.Name = "txtﾃﾞｰﾀ区分"
        Me.txtﾃﾞｰﾀ区分.Required = True
        Me.txtﾃﾞｰﾀ区分.Size = New System.Drawing.Size(32, 23)
        Me.txtﾃﾞｰﾀ区分.StringLength = 2
        Me.txtﾃﾞｰﾀ区分.TabIndex = 0
        Me.txtﾃﾞｰﾀ区分.Text = "12"
        Me.txtﾃﾞｰﾀ区分.TextStyle = BaseContents.TextBox.TextStyle.Code
        '
        'grpﾃﾞｰﾀ区分名
        '
        Me.grpﾃﾞｰﾀ区分名.Controls.Add(Me.txtﾃﾞｰﾀ区分名)
        Me.grpﾃﾞｰﾀ区分名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grpﾃﾞｰﾀ区分名.Location = New System.Drawing.Point(161, 107)
        Me.grpﾃﾞｰﾀ区分名.Name = "grpﾃﾞｰﾀ区分名"
        Me.grpﾃﾞｰﾀ区分名.Size = New System.Drawing.Size(253, 61)
        Me.grpﾃﾞｰﾀ区分名.TabIndex = 2
        Me.grpﾃﾞｰﾀ区分名.TabStop = False
        Me.grpﾃﾞｰﾀ区分名.Text = "ﾃﾞｰﾀ区分名"
        '
        'txtﾃﾞｰﾀ区分名
        '
        Me.txtﾃﾞｰﾀ区分名.FieldKeyType = BaseContents.Field.KeyType.Data
        Me.txtﾃﾞｰﾀ区分名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txtﾃﾞｰﾀ区分名.HelpKeys = ""
        Me.txtﾃﾞｰﾀ区分名.HelpLink = ""
        Me.txtﾃﾞｰﾀ区分名.HelpType = NodeUI.Help.Type.None
        Me.txtﾃﾞｰﾀ区分名.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtﾃﾞｰﾀ区分名.IsError = False
        Me.txtﾃﾞｰﾀ区分名.Location = New System.Drawing.Point(19, 25)
        Me.txtﾃﾞｰﾀ区分名.Name = "txtﾃﾞｰﾀ区分名"
        Me.txtﾃﾞｰﾀ区分名.Required = False
        Me.txtﾃﾞｰﾀ区分名.Size = New System.Drawing.Size(205, 23)
        Me.txtﾃﾞｰﾀ区分名.StringLength = 12
        Me.txtﾃﾞｰﾀ区分名.TabIndex = 0
        Me.txtﾃﾞｰﾀ区分名.Text = "ああああああああああいい"
        Me.txtﾃﾞｰﾀ区分名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp品名CD
        '
        Me.grp品名CD.Controls.Add(Me.lbl品名)
        Me.grp品名CD.Controls.Add(Me.txt品名CD)
        Me.grp品名CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp品名CD.Location = New System.Drawing.Point(29, 274)
        Me.grp品名CD.Name = "grp品名CD"
        Me.grp品名CD.Size = New System.Drawing.Size(421, 61)
        Me.grp品名CD.TabIndex = 8
        Me.grp品名CD.TabStop = False
        Me.grp品名CD.Text = "品名CD"
        '
        'lbl品名
        '
        Me.lbl品名.BackColor = System.Drawing.SystemColors.Control
        Me.lbl品名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl品名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.lbl品名.Location = New System.Drawing.Point(132, 24)
        Me.lbl品名.Margin = New System.Windows.Forms.Padding(3)
        Me.lbl品名.Name = "lbl品名"
        Me.lbl品名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.lbl品名.Size = New System.Drawing.Size(264, 23)
        Me.lbl品名.TabIndex = 1
        '
        'txt品名CD
        '
        Me.txt品名CD.FieldKeyType = BaseContents.Field.KeyType.Data
        Me.txt品名CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt品名CD.HelpKeys = ""
        Me.txt品名CD.HelpLink = ""
        Me.txt品名CD.HelpType = NodeUI.Help.Type.None
        Me.txt品名CD.IsError = False
        Me.txt品名CD.Location = New System.Drawing.Point(19, 24)
        Me.txt品名CD.Name = "txt品名CD"
        Me.txt品名CD.Required = False
        Me.txt品名CD.Size = New System.Drawing.Size(113, 23)
        Me.txt品名CD.StringLength = 13
        Me.txt品名CD.TabIndex = 0
        Me.txt品名CD.Text = "1234567890123"
        Me.txt品名CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp種別内訳区分
        '
        Me.grp種別内訳区分.Controls.Add(Me.ddl種別内訳区分)
        Me.grp種別内訳区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp種別内訳区分.Location = New System.Drawing.Point(614, 107)
        Me.grp種別内訳区分.Name = "grp種別内訳区分"
        Me.grp種別内訳区分.Size = New System.Drawing.Size(239, 61)
        Me.grp種別内訳区分.TabIndex = 4
        Me.grp種別内訳区分.TabStop = False
        Me.grp種別内訳区分.Text = "種別内訳区分"
        '
        'ddl種別内訳区分
        '
        Me.ddl種別内訳区分.AutoDropDown = True
        Me.ddl種別内訳区分.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddl種別内訳区分.FieldKeyType = BaseContents.Field.KeyType.Data
        Me.ddl種別内訳区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.ddl種別内訳区分.FormattingEnabled = True
        Me.ddl種別内訳区分.IsError = False
        Me.ddl種別内訳区分.ListType = NodeUI.List.Type.None
        Me.ddl種別内訳区分.Location = New System.Drawing.Point(19, 23)
        Me.ddl種別内訳区分.Name = "ddl種別内訳区分"
        Me.ddl種別内訳区分.Required = False
        Me.ddl種別内訳区分.Size = New System.Drawing.Size(188, 24)
        Me.ddl種別内訳区分.TabIndex = 0
        '
        'grb黒猫メール便バーコード情報
        '
        Me.grb黒猫メール便バーコード情報.Controls.Add(Me.Label7)
        Me.grb黒猫メール便バーコード情報.Controls.Add(Me.Label8)
        Me.grb黒猫メール便バーコード情報.Controls.Add(Me.txtバーコード次回No3)
        Me.grb黒猫メール便バーコード情報.Controls.Add(Me.Label9)
        Me.grb黒猫メール便バーコード情報.Controls.Add(Me.txtバーコード次回No2)
        Me.grb黒猫メール便バーコード情報.Controls.Add(Me.txtバーコード次回No1)
        Me.grb黒猫メール便バーコード情報.Controls.Add(Me.Label4)
        Me.grb黒猫メール便バーコード情報.Controls.Add(Me.Label5)
        Me.grb黒猫メール便バーコード情報.Controls.Add(Me.txtバーコード終了No3)
        Me.grb黒猫メール便バーコード情報.Controls.Add(Me.Label6)
        Me.grb黒猫メール便バーコード情報.Controls.Add(Me.txtバーコード終了No2)
        Me.grb黒猫メール便バーコード情報.Controls.Add(Me.txtバーコード終了No1)
        Me.grb黒猫メール便バーコード情報.Controls.Add(Me.Label3)
        Me.grb黒猫メール便バーコード情報.Controls.Add(Me.Label2)
        Me.grb黒猫メール便バーコード情報.Controls.Add(Me.txtバーコード開始No3)
        Me.grb黒猫メール便バーコード情報.Controls.Add(Me.Label1)
        Me.grb黒猫メール便バーコード情報.Controls.Add(Me.txtバーコード開始No2)
        Me.grb黒猫メール便バーコード情報.Controls.Add(Me.txtバーコード開始No1)
        Me.grb黒猫メール便バーコード情報.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grb黒猫メール便バーコード情報.Location = New System.Drawing.Point(29, 539)
        Me.grb黒猫メール便バーコード情報.Name = "grb黒猫メール便バーコード情報"
        Me.grb黒猫メール便バーコード情報.Size = New System.Drawing.Size(720, 61)
        Me.grb黒猫メール便バーコード情報.TabIndex = 13
        Me.grb黒猫メール便バーコード情報.TabStop = False
        Me.grb黒猫メール便バーコード情報.Text = "黒猫メール便バーコード情報"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Enabled = False
        Me.Label7.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.0!)
        Me.Label7.Location = New System.Drawing.Point(456, 28)
        Me.Label7.Margin = New System.Windows.Forms.Padding(0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 15)
        Me.Label7.TabIndex = 12
        Me.Label7.Text = "次回発番No"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Enabled = False
        Me.Label8.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.0!)
        Me.Label8.Location = New System.Drawing.Point(641, 28)
        Me.Label8.Margin = New System.Windows.Forms.Padding(0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 15)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "-"
        '
        'txtバーコード次回No3
        '
        Me.txtバーコード次回No3.FieldKeyType = BaseContents.Field.KeyType.Data
        Me.txtバーコード次回No3.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txtバーコード次回No3.HelpKeys = ""
        Me.txtバーコード次回No3.HelpLink = ""
        Me.txtバーコード次回No3.HelpType = NodeUI.Help.Type.None
        Me.txtバーコード次回No3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtバーコード次回No3.IsError = False
        Me.txtバーコード次回No3.Location = New System.Drawing.Point(656, 25)
        Me.txtバーコード次回No3.Name = "txtバーコード次回No3"
        Me.txtバーコード次回No3.Required = False
        Me.txtバーコード次回No3.Size = New System.Drawing.Size(33, 23)
        Me.txtバーコード次回No3.StringLength = 3
        Me.txtバーコード次回No3.TabIndex = 17
        Me.txtバーコード次回No3.Text = "123"
        Me.txtバーコード次回No3.TextStyle = BaseContents.TextBox.TextStyle.Code
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Enabled = False
        Me.Label9.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.0!)
        Me.Label9.Location = New System.Drawing.Point(586, 28)
        Me.Label9.Margin = New System.Windows.Forms.Padding(0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 15)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "-"
        '
        'txtバーコード次回No2
        '
        Me.txtバーコード次回No2.FieldKeyType = BaseContents.Field.KeyType.Data
        Me.txtバーコード次回No2.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txtバーコード次回No2.HelpKeys = ""
        Me.txtバーコード次回No2.HelpLink = ""
        Me.txtバーコード次回No2.HelpType = NodeUI.Help.Type.None
        Me.txtバーコード次回No2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtバーコード次回No2.IsError = False
        Me.txtバーコード次回No2.Location = New System.Drawing.Point(601, 25)
        Me.txtバーコード次回No2.Name = "txtバーコード次回No2"
        Me.txtバーコード次回No2.Required = False
        Me.txtバーコード次回No2.Size = New System.Drawing.Size(41, 23)
        Me.txtバーコード次回No2.StringLength = 4
        Me.txtバーコード次回No2.TabIndex = 15
        Me.txtバーコード次回No2.Text = "1234"
        Me.txtバーコード次回No2.TextStyle = BaseContents.TextBox.TextStyle.Code
        '
        'txtバーコード次回No1
        '
        Me.txtバーコード次回No1.FieldKeyType = BaseContents.Field.KeyType.Data
        Me.txtバーコード次回No1.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txtバーコード次回No1.HelpKeys = ""
        Me.txtバーコード次回No1.HelpLink = ""
        Me.txtバーコード次回No1.HelpType = NodeUI.Help.Type.None
        Me.txtバーコード次回No1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtバーコード次回No1.IsError = False
        Me.txtバーコード次回No1.Location = New System.Drawing.Point(545, 25)
        Me.txtバーコード次回No1.Name = "txtバーコード次回No1"
        Me.txtバーコード次回No1.Required = False
        Me.txtバーコード次回No1.Size = New System.Drawing.Size(41, 23)
        Me.txtバーコード次回No1.StringLength = 4
        Me.txtバーコード次回No1.TabIndex = 13
        Me.txtバーコード次回No1.Text = "1234"
        Me.txtバーコード次回No1.TextStyle = BaseContents.TextBox.TextStyle.Code
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Enabled = False
        Me.Label4.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.0!)
        Me.Label4.Location = New System.Drawing.Point(214, 28)
        Me.Label4.Margin = New System.Windows.Forms.Padding(0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "～終了No"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.0!)
        Me.Label5.Location = New System.Drawing.Point(382, 28)
        Me.Label5.Margin = New System.Windows.Forms.Padding(0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "-"
        '
        'txtバーコード終了No3
        '
        Me.txtバーコード終了No3.FieldKeyType = BaseContents.Field.KeyType.Data
        Me.txtバーコード終了No3.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txtバーコード終了No3.HelpKeys = ""
        Me.txtバーコード終了No3.HelpLink = ""
        Me.txtバーコード終了No3.HelpType = NodeUI.Help.Type.None
        Me.txtバーコード終了No3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtバーコード終了No3.IsError = False
        Me.txtバーコード終了No3.Location = New System.Drawing.Point(397, 25)
        Me.txtバーコード終了No3.Name = "txtバーコード終了No3"
        Me.txtバーコード終了No3.Required = False
        Me.txtバーコード終了No3.Size = New System.Drawing.Size(33, 23)
        Me.txtバーコード終了No3.StringLength = 3
        Me.txtバーコード終了No3.TabIndex = 11
        Me.txtバーコード終了No3.Text = "123"
        Me.txtバーコード終了No3.TextStyle = BaseContents.TextBox.TextStyle.Code
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.0!)
        Me.Label6.Location = New System.Drawing.Point(327, 28)
        Me.Label6.Margin = New System.Windows.Forms.Padding(0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "-"
        '
        'txtバーコード終了No2
        '
        Me.txtバーコード終了No2.FieldKeyType = BaseContents.Field.KeyType.Data
        Me.txtバーコード終了No2.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txtバーコード終了No2.HelpKeys = ""
        Me.txtバーコード終了No2.HelpLink = ""
        Me.txtバーコード終了No2.HelpType = NodeUI.Help.Type.None
        Me.txtバーコード終了No2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtバーコード終了No2.IsError = False
        Me.txtバーコード終了No2.Location = New System.Drawing.Point(342, 25)
        Me.txtバーコード終了No2.Name = "txtバーコード終了No2"
        Me.txtバーコード終了No2.Required = False
        Me.txtバーコード終了No2.Size = New System.Drawing.Size(41, 23)
        Me.txtバーコード終了No2.StringLength = 4
        Me.txtバーコード終了No2.TabIndex = 9
        Me.txtバーコード終了No2.Text = "1234"
        Me.txtバーコード終了No2.TextStyle = BaseContents.TextBox.TextStyle.Code
        '
        'txtバーコード終了No1
        '
        Me.txtバーコード終了No1.FieldKeyType = BaseContents.Field.KeyType.Data
        Me.txtバーコード終了No1.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txtバーコード終了No1.HelpKeys = ""
        Me.txtバーコード終了No1.HelpLink = ""
        Me.txtバーコード終了No1.HelpType = NodeUI.Help.Type.None
        Me.txtバーコード終了No1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtバーコード終了No1.IsError = False
        Me.txtバーコード終了No1.Location = New System.Drawing.Point(286, 25)
        Me.txtバーコード終了No1.Name = "txtバーコード終了No1"
        Me.txtバーコード終了No1.Required = False
        Me.txtバーコード終了No1.Size = New System.Drawing.Size(41, 23)
        Me.txtバーコード終了No1.StringLength = 4
        Me.txtバーコード終了No1.TabIndex = 7
        Me.txtバーコード終了No1.Text = "1234"
        Me.txtバーコード終了No1.TextStyle = BaseContents.TextBox.TextStyle.Code
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(8, 28)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "開始No"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(162, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(15, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "-"
        '
        'txtバーコード開始No3
        '
        Me.txtバーコード開始No3.FieldKeyType = BaseContents.Field.KeyType.Data
        Me.txtバーコード開始No3.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txtバーコード開始No3.HelpKeys = ""
        Me.txtバーコード開始No3.HelpLink = ""
        Me.txtバーコード開始No3.HelpType = NodeUI.Help.Type.None
        Me.txtバーコード開始No3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtバーコード開始No3.IsError = False
        Me.txtバーコード開始No3.Location = New System.Drawing.Point(177, 25)
        Me.txtバーコード開始No3.Name = "txtバーコード開始No3"
        Me.txtバーコード開始No3.Required = False
        Me.txtバーコード開始No3.Size = New System.Drawing.Size(33, 23)
        Me.txtバーコード開始No3.StringLength = 3
        Me.txtバーコード開始No3.TabIndex = 5
        Me.txtバーコード開始No3.Text = "123"
        Me.txtバーコード開始No3.TextStyle = BaseContents.TextBox.TextStyle.Code
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(107, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "-"
        '
        'txtバーコード開始No2
        '
        Me.txtバーコード開始No2.FieldKeyType = BaseContents.Field.KeyType.Data
        Me.txtバーコード開始No2.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txtバーコード開始No2.HelpKeys = ""
        Me.txtバーコード開始No2.HelpLink = ""
        Me.txtバーコード開始No2.HelpType = NodeUI.Help.Type.None
        Me.txtバーコード開始No2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtバーコード開始No2.IsError = False
        Me.txtバーコード開始No2.Location = New System.Drawing.Point(122, 25)
        Me.txtバーコード開始No2.Name = "txtバーコード開始No2"
        Me.txtバーコード開始No2.Required = False
        Me.txtバーコード開始No2.Size = New System.Drawing.Size(41, 23)
        Me.txtバーコード開始No2.StringLength = 4
        Me.txtバーコード開始No2.TabIndex = 3
        Me.txtバーコード開始No2.Text = "1234"
        Me.txtバーコード開始No2.TextStyle = BaseContents.TextBox.TextStyle.Code
        '
        'txtバーコード開始No1
        '
        Me.txtバーコード開始No1.FieldKeyType = BaseContents.Field.KeyType.Data
        Me.txtバーコード開始No1.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txtバーコード開始No1.HelpKeys = ""
        Me.txtバーコード開始No1.HelpLink = ""
        Me.txtバーコード開始No1.HelpType = NodeUI.Help.Type.None
        Me.txtバーコード開始No1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtバーコード開始No1.IsError = False
        Me.txtバーコード開始No1.Location = New System.Drawing.Point(66, 25)
        Me.txtバーコード開始No1.Name = "txtバーコード開始No1"
        Me.txtバーコード開始No1.Required = False
        Me.txtバーコード開始No1.Size = New System.Drawing.Size(41, 23)
        Me.txtバーコード開始No1.StringLength = 4
        Me.txtバーコード開始No1.TabIndex = 1
        Me.txtバーコード開始No1.Text = "1234"
        Me.txtバーコード開始No1.TextStyle = BaseContents.TextBox.TextStyle.Code
        '
        'grp材料請求時単価
        '
        Me.grp材料請求時単価.Controls.Add(Me.Label10)
        Me.grp材料請求時単価.Controls.Add(Me.txt材料請求時単価)
        Me.grp材料請求時単価.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp材料請求時単価.Location = New System.Drawing.Point(29, 448)
        Me.grp材料請求時単価.Name = "grp材料請求時単価"
        Me.grp材料請求時単価.Size = New System.Drawing.Size(140, 61)
        Me.grp材料請求時単価.TabIndex = 11
        Me.grp材料請求時単価.TabStop = False
        Me.grp材料請求時単価.Text = "材料請求時単価"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Enabled = False
        Me.Label10.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.0!)
        Me.Label10.Location = New System.Drawing.Point(101, 30)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(23, 15)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "円"
        '
        'txt材料請求時単価
        '
        Me.txt材料請求時単価.FieldKeyType = BaseContents.Field.KeyType.Data
        Me.txt材料請求時単価.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt材料請求時単価.HelpKeys = ""
        Me.txt材料請求時単価.HelpLink = ""
        Me.txt材料請求時単価.HelpType = NodeUI.Help.Type.None
        Me.txt材料請求時単価.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt材料請求時単価.IsError = False
        Me.txt材料請求時単価.Location = New System.Drawing.Point(19, 25)
        Me.txt材料請求時単価.Name = "txt材料請求時単価"
        Me.txt材料請求時単価.Required = False
        Me.txt材料請求時単価.Size = New System.Drawing.Size(79, 23)
        Me.txt材料請求時単価.StringLength = 0
        Me.txt材料請求時単価.TabIndex = 0
        Me.txt材料請求時単価.Text = "12,345.12"
        Me.txt材料請求時単価.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt材料請求時単価.TextStyle = BaseContents.TextBox.TextStyle.Currency
        '
        'grb受注単価
        '
        Me.grb受注単価.Controls.Add(Me.Label11)
        Me.grb受注単価.Controls.Add(Me.txt受注単価)
        Me.grb受注単価.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grb受注単価.Location = New System.Drawing.Point(381, 192)
        Me.grb受注単価.Name = "grb受注単価"
        Me.grb受注単価.Size = New System.Drawing.Size(134, 61)
        Me.grb受注単価.TabIndex = 7
        Me.grb受注単価.TabStop = False
        Me.grb受注単価.Text = "受注単価"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Enabled = False
        Me.Label11.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.0!)
        Me.Label11.Location = New System.Drawing.Point(101, 29)
        Me.Label11.Margin = New System.Windows.Forms.Padding(0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(23, 15)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "円"
        '
        'txt受注単価
        '
        Me.txt受注単価.FieldKeyType = BaseContents.Field.KeyType.Data
        Me.txt受注単価.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt受注単価.HelpKeys = ""
        Me.txt受注単価.HelpLink = ""
        Me.txt受注単価.HelpType = NodeUI.Help.Type.None
        Me.txt受注単価.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt受注単価.IsError = False
        Me.txt受注単価.Location = New System.Drawing.Point(18, 25)
        Me.txt受注単価.Name = "txt受注単価"
        Me.txt受注単価.Required = False
        Me.txt受注単価.Size = New System.Drawing.Size(79, 23)
        Me.txt受注単価.StringLength = 0
        Me.txt受注単価.TabIndex = 0
        Me.txt受注単価.Text = "12,345.12"
        Me.txt受注単価.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt受注単価.TextStyle = BaseContents.TextBox.TextStyle.Currency
        '
        'ｇｒｂ最大ｹｰｽ数
        '
        Me.ｇｒｂ最大ｹｰｽ数.Controls.Add(Me.Label13)
        Me.ｇｒｂ最大ｹｰｽ数.Controls.Add(Me.txt最大ｹｰｽ数)
        Me.ｇｒｂ最大ｹｰｽ数.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.ｇｒｂ最大ｹｰｽ数.Location = New System.Drawing.Point(216, 192)
        Me.ｇｒｂ最大ｹｰｽ数.Name = "ｇｒｂ最大ｹｰｽ数"
        Me.ｇｒｂ最大ｹｰｽ数.Size = New System.Drawing.Size(108, 61)
        Me.ｇｒｂ最大ｹｰｽ数.TabIndex = 6
        Me.ｇｒｂ最大ｹｰｽ数.TabStop = False
        Me.ｇｒｂ最大ｹｰｽ数.Text = "最大ｹｰｽ数"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Enabled = False
        Me.Label13.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.0!)
        Me.Label13.Location = New System.Drawing.Point(57, 30)
        Me.Label13.Margin = New System.Windows.Forms.Padding(0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 15)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "ｹｰｽ"
        '
        'txt最大ｹｰｽ数
        '
        Me.txt最大ｹｰｽ数.FieldKeyType = BaseContents.Field.KeyType.Data
        Me.txt最大ｹｰｽ数.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt最大ｹｰｽ数.HelpKeys = ""
        Me.txt最大ｹｰｽ数.HelpLink = ""
        Me.txt最大ｹｰｽ数.HelpType = NodeUI.Help.Type.None
        Me.txt最大ｹｰｽ数.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt最大ｹｰｽ数.IsError = False
        Me.txt最大ｹｰｽ数.Location = New System.Drawing.Point(19, 25)
        Me.txt最大ｹｰｽ数.Name = "txt最大ｹｰｽ数"
        Me.txt最大ｹｰｽ数.Required = False
        Me.txt最大ｹｰｽ数.Size = New System.Drawing.Size(35, 23)
        Me.txt最大ｹｰｽ数.StringLength = 0
        Me.txt最大ｹｰｽ数.TabIndex = 0
        Me.txt最大ｹｰｽ数.Text = "123"
        Me.txt最大ｹｰｽ数.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt最大ｹｰｽ数.TextStyle = BaseContents.TextBox.TextStyle.Currency
        '
        'txt入数
        '
        Me.txt入数.FieldKeyType = BaseContents.Field.KeyType.Data
        Me.txt入数.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt入数.HelpKeys = ""
        Me.txt入数.HelpLink = ""
        Me.txt入数.HelpType = NodeUI.Help.Type.None
        Me.txt入数.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt入数.IsError = False
        Me.txt入数.Location = New System.Drawing.Point(19, 25)
        Me.txt入数.Name = "txt入数"
        Me.txt入数.Required = False
        Me.txt入数.Size = New System.Drawing.Size(80, 23)
        Me.txt入数.StringLength = 0
        Me.txt入数.TabIndex = 0
        Me.txt入数.Text = "1,234,567"
        Me.txt入数.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt入数.TextStyle = BaseContents.TextBox.TextStyle.Currency
        '
        'grb入数
        '
        Me.grb入数.Controls.Add(Me.Label12)
        Me.grb入数.Controls.Add(Me.txt入数)
        Me.grb入数.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grb入数.Location = New System.Drawing.Point(29, 192)
        Me.grb入数.Name = "grb入数"
        Me.grb入数.Size = New System.Drawing.Size(143, 61)
        Me.grb入数.TabIndex = 5
        Me.grb入数.TabStop = False
        Me.grb入数.Text = "入数"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Enabled = False
        Me.Label12.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.0!)
        Me.Label12.Location = New System.Drawing.Point(103, 30)
        Me.Label12.Margin = New System.Windows.Forms.Padding(0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(23, 15)
        Me.Label12.TabIndex = 1
        Me.Label12.Text = "枚"
        '
        'grp略称
        '
        Me.grp略称.Controls.Add(Me.txt略称)
        Me.grp略称.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp略称.Location = New System.Drawing.Point(455, 107)
        Me.grp略称.Name = "grp略称"
        Me.grp略称.Size = New System.Drawing.Size(110, 61)
        Me.grp略称.TabIndex = 3
        Me.grp略称.TabStop = False
        Me.grp略称.Text = "略称"
        '
        'txt略称
        '
        Me.txt略称.FieldKeyType = BaseContents.Field.KeyType.Data
        Me.txt略称.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt略称.HelpKeys = ""
        Me.txt略称.HelpLink = ""
        Me.txt略称.HelpType = NodeUI.Help.Type.None
        Me.txt略称.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt略称.IsError = False
        Me.txt略称.Location = New System.Drawing.Point(19, 25)
        Me.txt略称.Name = "txt略称"
        Me.txt略称.Required = False
        Me.txt略称.Size = New System.Drawing.Size(70, 23)
        Me.txt略称.StringLength = 4
        Me.txt略称.TabIndex = 0
        Me.txt略称.Text = "ああああ"
        Me.txt略称.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp光村印刷得意先CD
        '
        Me.grp光村印刷得意先CD.Controls.Add(Me.lbl光村印刷得意先名)
        Me.grp光村印刷得意先CD.Controls.Add(Me.txt光村印刷得意先CD)
        Me.grp光村印刷得意先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp光村印刷得意先CD.Location = New System.Drawing.Point(29, 365)
        Me.grp光村印刷得意先CD.Name = "grp光村印刷得意先CD"
        Me.grp光村印刷得意先CD.Size = New System.Drawing.Size(379, 61)
        Me.grp光村印刷得意先CD.TabIndex = 9
        Me.grp光村印刷得意先CD.TabStop = False
        Me.grp光村印刷得意先CD.Text = "光村印刷得意先CD"
        '
        'lbl光村印刷得意先名
        '
        Me.lbl光村印刷得意先名.BackColor = System.Drawing.SystemColors.Control
        Me.lbl光村印刷得意先名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl光村印刷得意先名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.lbl光村印刷得意先名.Location = New System.Drawing.Point(79, 24)
        Me.lbl光村印刷得意先名.Margin = New System.Windows.Forms.Padding(3)
        Me.lbl光村印刷得意先名.Name = "lbl光村印刷得意先名"
        Me.lbl光村印刷得意先名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.lbl光村印刷得意先名.Size = New System.Drawing.Size(264, 23)
        Me.lbl光村印刷得意先名.TabIndex = 1
        '
        'txt光村印刷得意先CD
        '
        Me.txt光村印刷得意先CD.FieldKeyType = BaseContents.Field.KeyType.Data
        Me.txt光村印刷得意先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt光村印刷得意先CD.HelpKeys = ""
        Me.txt光村印刷得意先CD.HelpLink = ""
        Me.txt光村印刷得意先CD.HelpType = NodeUI.Help.Type.None
        Me.txt光村印刷得意先CD.IsError = False
        Me.txt光村印刷得意先CD.Location = New System.Drawing.Point(19, 24)
        Me.txt光村印刷得意先CD.Name = "txt光村印刷得意先CD"
        Me.txt光村印刷得意先CD.Required = False
        Me.txt光村印刷得意先CD.Size = New System.Drawing.Size(61, 23)
        Me.txt光村印刷得意先CD.StringLength = 6
        Me.txt光村印刷得意先CD.TabIndex = 0
        Me.txt光村印刷得意先CD.Text = "123456"
        Me.txt光村印刷得意先CD.TextStyle = BaseContents.TextBox.TextStyle.Code
        '
        'grp光村印刷出荷先CD
        '
        Me.grp光村印刷出荷先CD.Controls.Add(Me.lbl光村印刷出荷先名)
        Me.grp光村印刷出荷先CD.Controls.Add(Me.txt光村印刷出荷先CD)
        Me.grp光村印刷出荷先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp光村印刷出荷先CD.Location = New System.Drawing.Point(455, 365)
        Me.grp光村印刷出荷先CD.Name = "grp光村印刷出荷先CD"
        Me.grp光村印刷出荷先CD.Size = New System.Drawing.Size(348, 61)
        Me.grp光村印刷出荷先CD.TabIndex = 10
        Me.grp光村印刷出荷先CD.TabStop = False
        Me.grp光村印刷出荷先CD.Text = "光村印刷出荷先CD"
        '
        'lbl光村印刷出荷先名
        '
        Me.lbl光村印刷出荷先名.BackColor = System.Drawing.SystemColors.Control
        Me.lbl光村印刷出荷先名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl光村印刷出荷先名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.lbl光村印刷出荷先名.Location = New System.Drawing.Point(51, 24)
        Me.lbl光村印刷出荷先名.Margin = New System.Windows.Forms.Padding(3)
        Me.lbl光村印刷出荷先名.Name = "lbl光村印刷出荷先名"
        Me.lbl光村印刷出荷先名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.lbl光村印刷出荷先名.Size = New System.Drawing.Size(264, 23)
        Me.lbl光村印刷出荷先名.TabIndex = 1
        '
        'txt光村印刷出荷先CD
        '
        Me.txt光村印刷出荷先CD.Enabled = False
        Me.txt光村印刷出荷先CD.FieldKeyType = BaseContents.Field.KeyType.Data
        Me.txt光村印刷出荷先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt光村印刷出荷先CD.HelpKeys = ""
        Me.txt光村印刷出荷先CD.HelpLink = ""
        Me.txt光村印刷出荷先CD.HelpType = NodeUI.Help.Type.None
        Me.txt光村印刷出荷先CD.IsError = False
        Me.txt光村印刷出荷先CD.Location = New System.Drawing.Point(19, 24)
        Me.txt光村印刷出荷先CD.Name = "txt光村印刷出荷先CD"
        Me.txt光村印刷出荷先CD.Required = False
        Me.txt光村印刷出荷先CD.Size = New System.Drawing.Size(32, 23)
        Me.txt光村印刷出荷先CD.StringLength = 3
        Me.txt光村印刷出荷先CD.TabIndex = 0
        Me.txt光村印刷出荷先CD.Text = "123"
        Me.txt光村印刷出荷先CD.TextStyle = BaseContents.TextBox.TextStyle.Code
        '
        'grp材料請求時品名
        '
        Me.grp材料請求時品名.Controls.Add(Me.txt材料請求時品名)
        Me.grp材料請求時品名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp材料請求時品名.Location = New System.Drawing.Point(216, 448)
        Me.grp材料請求時品名.Name = "grp材料請求時品名"
        Me.grp材料請求時品名.Size = New System.Drawing.Size(312, 61)
        Me.grp材料請求時品名.TabIndex = 12
        Me.grp材料請求時品名.TabStop = False
        Me.grp材料請求時品名.Text = "材料請求時品名"
        '
        'txt材料請求時品名
        '
        Me.txt材料請求時品名.FieldKeyType = BaseContents.Field.KeyType.Data
        Me.txt材料請求時品名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt材料請求時品名.HelpKeys = ""
        Me.txt材料請求時品名.HelpLink = ""
        Me.txt材料請求時品名.HelpType = NodeUI.Help.Type.None
        Me.txt材料請求時品名.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt材料請求時品名.IsError = False
        Me.txt材料請求時品名.Location = New System.Drawing.Point(19, 25)
        Me.txt材料請求時品名.Name = "txt材料請求時品名"
        Me.txt材料請求時品名.Required = False
        Me.txt材料請求時品名.Size = New System.Drawing.Size(264, 23)
        Me.txt材料請求時品名.StringLength = 16
        Me.txt材料請求時品名.TabIndex = 0
        Me.txt材料請求時品名.Text = "ああああああああああいいいいいい"
        Me.txt材料請求時品名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'frmYamatoDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.grp材料請求時品名)
        Me.Controls.Add(Me.grp光村印刷出荷先CD)
        Me.Controls.Add(Me.grp光村印刷得意先CD)
        Me.Controls.Add(Me.grp略称)
        Me.Controls.Add(Me.grb受注単価)
        Me.Controls.Add(Me.ｇｒｂ最大ｹｰｽ数)
        Me.Controls.Add(Me.grb入数)
        Me.Controls.Add(Me.grp材料請求時単価)
        Me.Controls.Add(Me.grb黒猫メール便バーコード情報)
        Me.Controls.Add(Me.grp種別内訳区分)
        Me.Controls.Add(Me.grp品名CD)
        Me.Controls.Add(Me.grpﾃﾞｰﾀ区分名)
        Me.Controls.Add(Me.grpﾃﾞｰﾀ区分)
        Me.Controls.Add(Me.grp処理区分)
        Me.KeyPreview = True
        Me.Name = "frmYamatoDate"
        Me.Text = ""
        Me.Controls.SetChildIndex(Me.grp処理区分, 0)
        Me.Controls.SetChildIndex(Me.grpﾃﾞｰﾀ区分, 0)
        Me.Controls.SetChildIndex(Me.grpﾃﾞｰﾀ区分名, 0)
        Me.Controls.SetChildIndex(Me.grp品名CD, 0)
        Me.Controls.SetChildIndex(Me.grp種別内訳区分, 0)
        Me.Controls.SetChildIndex(Me.grb黒猫メール便バーコード情報, 0)
        Me.Controls.SetChildIndex(Me.grp材料請求時単価, 0)
        Me.Controls.SetChildIndex(Me.grb入数, 0)
        Me.Controls.SetChildIndex(Me.ｇｒｂ最大ｹｰｽ数, 0)
        Me.Controls.SetChildIndex(Me.grb受注単価, 0)
        Me.Controls.SetChildIndex(Me.grp略称, 0)
        Me.Controls.SetChildIndex(Me.grp光村印刷得意先CD, 0)
        Me.Controls.SetChildIndex(Me.grp光村印刷出荷先CD, 0)
        Me.Controls.SetChildIndex(Me.grp材料請求時品名, 0)
        Me.grp処理区分.ResumeLayout(False)
        Me.grp処理区分.PerformLayout()
        Me.grpﾃﾞｰﾀ区分.ResumeLayout(False)
        Me.grpﾃﾞｰﾀ区分.PerformLayout()
        Me.grpﾃﾞｰﾀ区分名.ResumeLayout(False)
        Me.grpﾃﾞｰﾀ区分名.PerformLayout()
        Me.grp品名CD.ResumeLayout(False)
        Me.grp品名CD.PerformLayout()
        Me.grp種別内訳区分.ResumeLayout(False)
        Me.grb黒猫メール便バーコード情報.ResumeLayout(False)
        Me.grb黒猫メール便バーコード情報.PerformLayout()
        Me.grp材料請求時単価.ResumeLayout(False)
        Me.grp材料請求時単価.PerformLayout()
        Me.grb受注単価.ResumeLayout(False)
        Me.grb受注単価.PerformLayout()
        Me.ｇｒｂ最大ｹｰｽ数.ResumeLayout(False)
        Me.ｇｒｂ最大ｹｰｽ数.PerformLayout()
        Me.grb入数.ResumeLayout(False)
        Me.grb入数.PerformLayout()
        Me.grp略称.ResumeLayout(False)
        Me.grp略称.PerformLayout()
        Me.grp光村印刷得意先CD.ResumeLayout(False)
        Me.grp光村印刷得意先CD.PerformLayout()
        Me.grp光村印刷出荷先CD.ResumeLayout(False)
        Me.grp光村印刷出荷先CD.PerformLayout()
        Me.grp材料請求時品名.ResumeLayout(False)
        Me.grp材料請求時品名.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp処理区分 As BaseUI.Control.GroupBox
    Friend WithEvents opt削除 As BaseUI.Control.RadioButton
    Friend WithEvents opt修正 As BaseUI.Control.RadioButton
    Friend WithEvents opt登録 As BaseUI.Control.RadioButton
    Friend WithEvents grpﾃﾞｰﾀ区分 As BaseUI.Control.GroupBox
    Friend WithEvents txtﾃﾞｰﾀ区分 As BaseUI.Control.TextBox
    Friend WithEvents grpﾃﾞｰﾀ区分名 As BaseUI.Control.GroupBox
    Friend WithEvents txtﾃﾞｰﾀ区分名 As BaseUI.Control.TextBox
    Friend WithEvents grp品名CD As BaseUI.Control.GroupBox
    Friend WithEvents lbl品名 As BaseUI.Control.NameBox
    Friend WithEvents txt品名CD As BaseUI.Control.TextBox
    Friend WithEvents grp種別内訳区分 As BaseUI.Control.GroupBox
    Friend WithEvents ddl種別内訳区分 As BaseUI.Control.ComboBox
    Friend WithEvents grb黒猫メール便バーコード情報 As BaseUI.Control.GroupBox
    Friend WithEvents txtバーコード開始No2 As BaseUI.Control.TextBox
    Friend WithEvents txtバーコード開始No1 As BaseUI.Control.TextBox
    Friend WithEvents Label1 As BaseUI.Control.Label
    Friend WithEvents grp材料請求時単価 As BaseUI.Control.GroupBox
    Friend WithEvents txt材料請求時単価 As BaseUI.Control.TextBox
    Friend WithEvents grb受注単価 As BaseUI.Control.GroupBox
    Friend WithEvents txt受注単価 As BaseUI.Control.TextBox
    Friend WithEvents ｇｒｂ最大ｹｰｽ数 As BaseUI.Control.GroupBox
    Friend WithEvents txt最大ｹｰｽ数 As BaseUI.Control.TextBox
    Friend WithEvents Label7 As BaseUI.Control.Label
    Friend WithEvents Label8 As BaseUI.Control.Label
    Friend WithEvents txtバーコード次回No3 As BaseUI.Control.TextBox
    Friend WithEvents Label9 As BaseUI.Control.Label
    Friend WithEvents txtバーコード次回No2 As BaseUI.Control.TextBox
    Friend WithEvents txtバーコード次回No1 As BaseUI.Control.TextBox
    Friend WithEvents Label4 As BaseUI.Control.Label
    Friend WithEvents Label5 As BaseUI.Control.Label
    Friend WithEvents txtバーコード終了No3 As BaseUI.Control.TextBox
    Friend WithEvents Label6 As BaseUI.Control.Label
    Friend WithEvents txtバーコード終了No2 As BaseUI.Control.TextBox
    Friend WithEvents txtバーコード終了No1 As BaseUI.Control.TextBox
    Friend WithEvents Label3 As BaseUI.Control.Label
    Friend WithEvents Label2 As BaseUI.Control.Label
    Friend WithEvents txtバーコード開始No3 As BaseUI.Control.TextBox
    Friend WithEvents txt入数 As BaseUI.Control.TextBox
    Friend WithEvents grb入数 As BaseUI.Control.GroupBox
    Friend WithEvents grp略称 As BaseUI.Control.GroupBox
    Friend WithEvents txt略称 As BaseUI.Control.TextBox
    Friend WithEvents grp光村印刷得意先CD As BaseUI.Control.GroupBox
    Friend WithEvents lbl光村印刷得意先名 As BaseUI.Control.NameBox
    Friend WithEvents txt光村印刷得意先CD As BaseUI.Control.TextBox
    Friend WithEvents grp光村印刷出荷先CD As BaseUI.Control.GroupBox
    Friend WithEvents lbl光村印刷出荷先名 As BaseUI.Control.NameBox
    Friend WithEvents txt光村印刷出荷先CD As BaseUI.Control.TextBox
    Friend WithEvents grp材料請求時品名 As BaseUI.Control.GroupBox
    Friend WithEvents txt材料請求時品名 As BaseUI.Control.TextBox
    Friend WithEvents Label10 As BaseUI.Control.Label
    Friend WithEvents Label11 As BaseUI.Control.Label
    Friend WithEvents Label13 As BaseUI.Control.Label
    Friend WithEvents Label12 As BaseUI.Control.Label
End Class
