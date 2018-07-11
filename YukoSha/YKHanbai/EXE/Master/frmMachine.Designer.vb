<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMachine
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
        Me.grp機械コード = New BaseUI.Control.GroupBox()
        Me.txt機械CD = New BaseUI.Control.TextBox()
        Me.grp機械区分 = New BaseUI.Control.GroupBox()
        Me.ddl機械区分 = New BaseUI.Control.ComboBox()
        Me.grp分類コード = New BaseUI.Control.GroupBox()
        Me.txt分類コード = New BaseUI.Control.TextBox()
        Me.grp機械種別 = New BaseUI.Control.GroupBox()
        Me.ddl機械種別 = New BaseUI.Control.ComboBox()
        Me.grpコーター日数 = New BaseUI.Control.GroupBox()
        Me.Label7 = New BaseUI.Control.Label()
        Me.txtコーター日数 = New BaseUI.Control.TextBox()
        Me.grpコーター回転数 = New BaseUI.Control.GroupBox()
        Me.Label8 = New BaseUI.Control.Label()
        Me.txtコーター回転数 = New BaseUI.Control.TextBox()
        Me.grp機械名 = New BaseUI.Control.GroupBox()
        Me.txt機械名 = New BaseUI.Control.TextBox()
        Me.grp担当者 = New BaseUI.Control.GroupBox()
        Me.nam担当者名 = New BaseUI.Control.NameBox()
        Me.txt担当者コード = New BaseUI.Control.TextBox()
        Me.grp固定経費算出条件平圧 = New BaseUI.Control.GroupBox()
        Me.Label3 = New BaseUI.Control.Label()
        Me.txt固定経費平圧条件外一通あたり金額 = New BaseUI.Control.TextBox()
        Me.Label2 = New BaseUI.Control.Label()
        Me.txt固定経費平圧金額 = New BaseUI.Control.TextBox()
        Me.txt固定経費平圧条件 = New BaseUI.Control.TextBox()
        Me.Label1 = New BaseUI.Control.Label()
        Me.grp固定経費算出条件輪転 = New BaseUI.Control.GroupBox()
        Me.Label4 = New BaseUI.Control.Label()
        Me.txt固定経費輪転条件外一通あたり金額 = New BaseUI.Control.TextBox()
        Me.Label5 = New BaseUI.Control.Label()
        Me.txt固定経費輪転金額 = New BaseUI.Control.TextBox()
        Me.txt固定経費輪転条件 = New BaseUI.Control.TextBox()
        Me.Label6 = New BaseUI.Control.Label()
        Me.grp処理区分.SuspendLayout()
        Me.grp機械コード.SuspendLayout()
        Me.grp機械区分.SuspendLayout()
        Me.grp分類コード.SuspendLayout()
        Me.grp機械種別.SuspendLayout()
        Me.grpコーター日数.SuspendLayout()
        Me.grpコーター回転数.SuspendLayout()
        Me.grp機械名.SuspendLayout()
        Me.grp担当者.SuspendLayout()
        Me.grp固定経費算出条件平圧.SuspendLayout()
        Me.grp固定経費算出条件輪転.SuspendLayout()
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
        'grp機械コード
        '
        Me.grp機械コード.Controls.Add(Me.txt機械CD)
        Me.grp機械コード.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp機械コード.Location = New System.Drawing.Point(29, 100)
        Me.grp機械コード.Name = "grp機械コード"
        Me.grp機械コード.Size = New System.Drawing.Size(90, 61)
        Me.grp機械コード.TabIndex = 1
        Me.grp機械コード.TabStop = False
        Me.grp機械コード.Text = "機械ｺｰﾄﾞ"
        '
        'txt機械CD
        '
        Me.txt機械CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt機械CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt機械CD.HelpKeys = ""
        Me.txt機械CD.HelpLink = ""
        Me.txt機械CD.HelpType = NodeUI.Help.Type.None
        Me.txt機械CD.IsError = False
        Me.txt機械CD.Location = New System.Drawing.Point(19, 24)
        Me.txt機械CD.Name = "txt機械CD"
        Me.txt機械CD.Required = False
        Me.txt機械CD.Size = New System.Drawing.Size(46, 23)
        Me.txt機械CD.StringLength = 65535
        Me.txt機械CD.TabIndex = 0
        Me.txt機械CD.Text = "99999"
        Me.txt機械CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp機械区分
        '
        Me.grp機械区分.Controls.Add(Me.ddl機械区分)
        Me.grp機械区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp機械区分.Location = New System.Drawing.Point(29, 178)
        Me.grp機械区分.Name = "grp機械区分"
        Me.grp機械区分.Size = New System.Drawing.Size(230, 61)
        Me.grp機械区分.TabIndex = 3
        Me.grp機械区分.TabStop = False
        Me.grp機械区分.Text = "機械区分"
        '
        'ddl機械区分
        '
        Me.ddl機械区分.AutoDropDown = True
        Me.ddl機械区分.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddl機械区分.FieldLockType = BaseContents.Field.LockType.None
        Me.ddl機械区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.ddl機械区分.FormattingEnabled = True
        Me.ddl機械区分.IsError = False
        Me.ddl機械区分.ListType = NodeUI.List.Type.None
        Me.ddl機械区分.Location = New System.Drawing.Point(19, 24)
        Me.ddl機械区分.Name = "ddl機械区分"
        Me.ddl機械区分.Required = True
        Me.ddl機械区分.Size = New System.Drawing.Size(191, 24)
        Me.ddl機械区分.TabIndex = 10
        '
        'grp分類コード
        '
        Me.grp分類コード.Controls.Add(Me.txt分類コード)
        Me.grp分類コード.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp分類コード.Location = New System.Drawing.Point(290, 178)
        Me.grp分類コード.Name = "grp分類コード"
        Me.grp分類コード.Size = New System.Drawing.Size(100, 61)
        Me.grp分類コード.TabIndex = 4
        Me.grp分類コード.TabStop = False
        Me.grp分類コード.Text = "分類ｺｰﾄﾞ"
        '
        'txt分類コード
        '
        Me.txt分類コード.FieldLockType = BaseContents.Field.LockType.None
        Me.txt分類コード.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt分類コード.HelpKeys = ""
        Me.txt分類コード.HelpLink = ""
        Me.txt分類コード.HelpType = NodeUI.Help.Type.None
        Me.txt分類コード.ImeMode = System.Windows.Forms.ImeMode.Alpha
        Me.txt分類コード.IsError = False
        Me.txt分類コード.Location = New System.Drawing.Point(19, 25)
        Me.txt分類コード.Name = "txt分類コード"
        Me.txt分類コード.Required = False
        Me.txt分類コード.Size = New System.Drawing.Size(22, 23)
        Me.txt分類コード.StringLength = 65535
        Me.txt分類コード.TabIndex = 0
        Me.txt分類コード.Text = "1"
        Me.txt分類コード.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp機械種別
        '
        Me.grp機械種別.Controls.Add(Me.ddl機械種別)
        Me.grp機械種別.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp機械種別.Location = New System.Drawing.Point(29, 334)
        Me.grp機械種別.Name = "grp機械種別"
        Me.grp機械種別.Size = New System.Drawing.Size(230, 65)
        Me.grp機械種別.TabIndex = 6
        Me.grp機械種別.TabStop = False
        Me.grp機械種別.Text = "機械種別"
        '
        'ddl機械種別
        '
        Me.ddl機械種別.AutoDropDown = True
        Me.ddl機械種別.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddl機械種別.FieldLockType = BaseContents.Field.LockType.None
        Me.ddl機械種別.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.ddl機械種別.FormattingEnabled = True
        Me.ddl機械種別.IsError = False
        Me.ddl機械種別.ListType = NodeUI.List.Type.None
        Me.ddl機械種別.Location = New System.Drawing.Point(19, 24)
        Me.ddl機械種別.Name = "ddl機械種別"
        Me.ddl機械種別.Required = True
        Me.ddl機械種別.Size = New System.Drawing.Size(191, 24)
        Me.ddl機械種別.TabIndex = 11
        '
        'grpコーター日数
        '
        Me.grpコーター日数.Controls.Add(Me.Label7)
        Me.grpコーター日数.Controls.Add(Me.txtコーター日数)
        Me.grpコーター日数.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grpコーター日数.Location = New System.Drawing.Point(29, 568)
        Me.grpコーター日数.Name = "grpコーター日数"
        Me.grpコーター日数.Size = New System.Drawing.Size(90, 61)
        Me.grpコーター日数.TabIndex = 9
        Me.grpコーター日数.TabStop = False
        Me.grpコーター日数.Text = "ｺｰﾀｰ日数"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.Label7.Location = New System.Drawing.Point(47, 28)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 16)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "日"
        '
        'txtコーター日数
        '
        Me.txtコーター日数.FieldLockType = BaseContents.Field.LockType.None
        Me.txtコーター日数.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txtコーター日数.HelpKeys = ""
        Me.txtコーター日数.HelpLink = ""
        Me.txtコーター日数.HelpType = NodeUI.Help.Type.None
        Me.txtコーター日数.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtコーター日数.IsError = False
        Me.txtコーター日数.Location = New System.Drawing.Point(19, 24)
        Me.txtコーター日数.Name = "txtコーター日数"
        Me.txtコーター日数.Required = False
        Me.txtコーター日数.Size = New System.Drawing.Size(24, 23)
        Me.txtコーター日数.StringLength = 65535
        Me.txtコーター日数.TabIndex = 0
        Me.txtコーター日数.Text = "12"
        Me.txtコーター日数.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtコーター日数.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grpコーター回転数
        '
        Me.grpコーター回転数.Controls.Add(Me.Label8)
        Me.grpコーター回転数.Controls.Add(Me.txtコーター回転数)
        Me.grpコーター回転数.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grpコーター回転数.Location = New System.Drawing.Point(159, 568)
        Me.grpコーター回転数.Name = "grpコーター回転数"
        Me.grpコーター回転数.Size = New System.Drawing.Size(172, 61)
        Me.grpコーター回転数.TabIndex = 10
        Me.grpコーター回転数.TabStop = False
        Me.grpコーター回転数.Text = "ｺｰﾀｰ回転数"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.Label8.Location = New System.Drawing.Point(101, 28)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 16)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "通／日"
        '
        'txtコーター回転数
        '
        Me.txtコーター回転数.FieldLockType = BaseContents.Field.LockType.None
        Me.txtコーター回転数.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txtコーター回転数.HelpKeys = ""
        Me.txtコーター回転数.HelpLink = ""
        Me.txtコーター回転数.HelpType = NodeUI.Help.Type.None
        Me.txtコーター回転数.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtコーター回転数.IsError = False
        Me.txtコーター回転数.Location = New System.Drawing.Point(19, 24)
        Me.txtコーター回転数.Name = "txtコーター回転数"
        Me.txtコーター回転数.Required = False
        Me.txtコーター回転数.Size = New System.Drawing.Size(81, 23)
        Me.txtコーター回転数.StringLength = 65535
        Me.txtコーター回転数.TabIndex = 0
        Me.txtコーター回転数.Text = "1,234,567"
        Me.txtコーター回転数.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtコーター回転数.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp機械名
        '
        Me.grp機械名.Controls.Add(Me.txt機械名)
        Me.grp機械名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp機械名.Location = New System.Drawing.Point(129, 100)
        Me.grp機械名.Name = "grp機械名"
        Me.grp機械名.Size = New System.Drawing.Size(130, 61)
        Me.grp機械名.TabIndex = 2
        Me.grp機械名.TabStop = False
        Me.grp機械名.Text = "機械名"
        '
        'txt機械名
        '
        Me.txt機械名.FieldLockType = BaseContents.Field.LockType.None
        Me.txt機械名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt機械名.HelpKeys = ""
        Me.txt機械名.HelpLink = ""
        Me.txt機械名.HelpType = NodeUI.Help.Type.None
        Me.txt機械名.IsError = False
        Me.txt機械名.Location = New System.Drawing.Point(19, 24)
        Me.txt機械名.Name = "txt機械名"
        Me.txt機械名.Required = False
        Me.txt機械名.Size = New System.Drawing.Size(91, 23)
        Me.txt機械名.StringLength = 65535
        Me.txt機械名.TabIndex = 0
        Me.txt機械名.Text = "AAAAAAAAAA"
        Me.txt機械名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp担当者
        '
        Me.grp担当者.Controls.Add(Me.nam担当者名)
        Me.grp担当者.Controls.Add(Me.txt担当者コード)
        Me.grp担当者.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp担当者.Location = New System.Drawing.Point(29, 256)
        Me.grp担当者.Name = "grp担当者"
        Me.grp担当者.Size = New System.Drawing.Size(230, 61)
        Me.grp担当者.TabIndex = 5
        Me.grp担当者.TabStop = False
        Me.grp担当者.Text = "担当者ｺｰﾄﾞ"
        '
        'nam担当者名
        '
        Me.nam担当者名.BackColor = System.Drawing.SystemColors.Control
        Me.nam担当者名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam担当者名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam担当者名.Location = New System.Drawing.Point(51, 24)
        Me.nam担当者名.Margin = New System.Windows.Forms.Padding(3)
        Me.nam担当者名.Name = "nam担当者名"
        Me.nam担当者名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.nam担当者名.Size = New System.Drawing.Size(160, 23)
        Me.nam担当者名.StringLength = 65535
        Me.nam担当者名.TabIndex = 10
        Me.nam担当者名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt担当者コード
        '
        Me.txt担当者コード.FieldLockType = BaseContents.Field.LockType.None
        Me.txt担当者コード.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt担当者コード.HelpKeys = ""
        Me.txt担当者コード.HelpLink = ""
        Me.txt担当者コード.HelpType = NodeUI.Help.Type.None
        Me.txt担当者コード.IsError = False
        Me.txt担当者コード.Location = New System.Drawing.Point(19, 24)
        Me.txt担当者コード.Name = "txt担当者コード"
        Me.txt担当者コード.Required = False
        Me.txt担当者コード.Size = New System.Drawing.Size(34, 23)
        Me.txt担当者コード.StringLength = 65535
        Me.txt担当者コード.TabIndex = 0
        Me.txt担当者コード.Text = "123"
        Me.txt担当者コード.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp固定経費算出条件平圧
        '
        Me.grp固定経費算出条件平圧.Controls.Add(Me.Label3)
        Me.grp固定経費算出条件平圧.Controls.Add(Me.txt固定経費平圧条件外一通あたり金額)
        Me.grp固定経費算出条件平圧.Controls.Add(Me.Label2)
        Me.grp固定経費算出条件平圧.Controls.Add(Me.txt固定経費平圧金額)
        Me.grp固定経費算出条件平圧.Controls.Add(Me.txt固定経費平圧条件)
        Me.grp固定経費算出条件平圧.Controls.Add(Me.Label1)
        Me.grp固定経費算出条件平圧.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp固定経費算出条件平圧.Location = New System.Drawing.Point(29, 412)
        Me.grp固定経費算出条件平圧.Name = "grp固定経費算出条件平圧"
        Me.grp固定経費算出条件平圧.Size = New System.Drawing.Size(902, 65)
        Me.grp固定経費算出条件平圧.TabIndex = 7
        Me.grp固定経費算出条件平圧.TabStop = False
        Me.grp固定経費算出条件平圧.Text = "固定経費算出条件（平圧）"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(800, 28)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 16)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "円/通とする"
        '
        'txt固定経費平圧条件外一通あたり金額
        '
        Me.txt固定経費平圧条件外一通あたり金額.FieldLockType = BaseContents.Field.LockType.None
        Me.txt固定経費平圧条件外一通あたり金額.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt固定経費平圧条件外一通あたり金額.HelpKeys = ""
        Me.txt固定経費平圧条件外一通あたり金額.HelpLink = ""
        Me.txt固定経費平圧条件外一通あたり金額.HelpType = NodeUI.Help.Type.None
        Me.txt固定経費平圧条件外一通あたり金額.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt固定経費平圧条件外一通あたり金額.IsError = False
        Me.txt固定経費平圧条件外一通あたり金額.Location = New System.Drawing.Point(687, 24)
        Me.txt固定経費平圧条件外一通あたり金額.Name = "txt固定経費平圧条件外一通あたり金額"
        Me.txt固定経費平圧条件外一通あたり金額.Required = False
        Me.txt固定経費平圧条件外一通あたり金額.Size = New System.Drawing.Size(111, 23)
        Me.txt固定経費平圧条件外一通あたり金額.StringLength = 65535
        Me.txt固定経費平圧条件外一通あたり金額.TabIndex = 10
        Me.txt固定経費平圧条件外一通あたり金額.Text = "1,234,567.89"
        Me.txt固定経費平圧条件外一通あたり金額.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt固定経費平圧条件外一通あたり金額.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(341, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(344, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "円とする。左記の条件を超える場合は１通当り"
        '
        'txt固定経費平圧金額
        '
        Me.txt固定経費平圧金額.FieldLockType = BaseContents.Field.LockType.None
        Me.txt固定経費平圧金額.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt固定経費平圧金額.HelpKeys = ""
        Me.txt固定経費平圧金額.HelpLink = ""
        Me.txt固定経費平圧金額.HelpType = NodeUI.Help.Type.None
        Me.txt固定経費平圧金額.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt固定経費平圧金額.IsError = False
        Me.txt固定経費平圧金額.Location = New System.Drawing.Point(228, 24)
        Me.txt固定経費平圧金額.MaxLength = 0
        Me.txt固定経費平圧金額.Name = "txt固定経費平圧金額"
        Me.txt固定経費平圧金額.Required = False
        Me.txt固定経費平圧金額.Size = New System.Drawing.Size(115, 23)
        Me.txt固定経費平圧金額.StringLength = 65535
        Me.txt固定経費平圧金額.TabIndex = 1
        Me.txt固定経費平圧金額.Text = "1,234,567"
        Me.txt固定経費平圧金額.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt固定経費平圧金額.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt固定経費平圧条件
        '
        Me.txt固定経費平圧条件.FieldLockType = BaseContents.Field.LockType.None
        Me.txt固定経費平圧条件.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt固定経費平圧条件.HelpKeys = ""
        Me.txt固定経費平圧条件.HelpLink = ""
        Me.txt固定経費平圧条件.HelpType = NodeUI.Help.Type.None
        Me.txt固定経費平圧条件.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt固定経費平圧条件.IsError = False
        Me.txt固定経費平圧条件.Location = New System.Drawing.Point(19, 24)
        Me.txt固定経費平圧条件.Name = "txt固定経費平圧条件"
        Me.txt固定経費平圧条件.Required = False
        Me.txt固定経費平圧条件.Size = New System.Drawing.Size(85, 23)
        Me.txt固定経費平圧条件.StringLength = 65535
        Me.txt固定経費平圧条件.TabIndex = 0
        Me.txt固定経費平圧条件.Text = "1,234,567"
        Me.txt固定経費平圧条件.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt固定経費平圧条件.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(110, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 16)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "通以下の場合は"
        '
        'grp固定経費算出条件輪転
        '
        Me.grp固定経費算出条件輪転.Controls.Add(Me.Label4)
        Me.grp固定経費算出条件輪転.Controls.Add(Me.txt固定経費輪転条件外一通あたり金額)
        Me.grp固定経費算出条件輪転.Controls.Add(Me.Label5)
        Me.grp固定経費算出条件輪転.Controls.Add(Me.txt固定経費輪転金額)
        Me.grp固定経費算出条件輪転.Controls.Add(Me.txt固定経費輪転条件)
        Me.grp固定経費算出条件輪転.Controls.Add(Me.Label6)
        Me.grp固定経費算出条件輪転.Enabled = False
        Me.grp固定経費算出条件輪転.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp固定経費算出条件輪転.Location = New System.Drawing.Point(29, 490)
        Me.grp固定経費算出条件輪転.Name = "grp固定経費算出条件輪転"
        Me.grp固定経費算出条件輪転.Size = New System.Drawing.Size(902, 65)
        Me.grp固定経費算出条件輪転.TabIndex = 8
        Me.grp固定経費算出条件輪転.TabStop = False
        Me.grp固定経費算出条件輪転.Text = "固定経費算出条件（輪転）"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(800, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(96, 16)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "円/通とする"
        '
        'txt固定経費輪転条件外一通あたり金額
        '
        Me.txt固定経費輪転条件外一通あたり金額.FieldLockType = BaseContents.Field.LockType.None
        Me.txt固定経費輪転条件外一通あたり金額.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt固定経費輪転条件外一通あたり金額.HelpKeys = ""
        Me.txt固定経費輪転条件外一通あたり金額.HelpLink = ""
        Me.txt固定経費輪転条件外一通あたり金額.HelpType = NodeUI.Help.Type.None
        Me.txt固定経費輪転条件外一通あたり金額.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt固定経費輪転条件外一通あたり金額.IsError = False
        Me.txt固定経費輪転条件外一通あたり金額.Location = New System.Drawing.Point(687, 24)
        Me.txt固定経費輪転条件外一通あたり金額.Name = "txt固定経費輪転条件外一通あたり金額"
        Me.txt固定経費輪転条件外一通あたり金額.Required = False
        Me.txt固定経費輪転条件外一通あたり金額.Size = New System.Drawing.Size(111, 23)
        Me.txt固定経費輪転条件外一通あたり金額.StringLength = 65535
        Me.txt固定経費輪転条件外一通あたり金額.TabIndex = 2
        Me.txt固定経費輪転条件外一通あたり金額.Text = "1,234,567.89"
        Me.txt固定経費輪転条件外一通あたり金額.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt固定経費輪転条件外一通あたり金額.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(341, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(344, 16)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "円とする。左記の条件を超える場合は１通当り"
        '
        'txt固定経費輪転金額
        '
        Me.txt固定経費輪転金額.FieldLockType = BaseContents.Field.LockType.None
        Me.txt固定経費輪転金額.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt固定経費輪転金額.HelpKeys = ""
        Me.txt固定経費輪転金額.HelpLink = ""
        Me.txt固定経費輪転金額.HelpType = NodeUI.Help.Type.None
        Me.txt固定経費輪転金額.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt固定経費輪転金額.IsError = False
        Me.txt固定経費輪転金額.Location = New System.Drawing.Point(228, 24)
        Me.txt固定経費輪転金額.Name = "txt固定経費輪転金額"
        Me.txt固定経費輪転金額.Required = False
        Me.txt固定経費輪転金額.Size = New System.Drawing.Size(115, 23)
        Me.txt固定経費輪転金額.StringLength = 65535
        Me.txt固定経費輪転金額.TabIndex = 1
        Me.txt固定経費輪転金額.Text = "1,234,567"
        Me.txt固定経費輪転金額.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt固定経費輪転金額.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt固定経費輪転条件
        '
        Me.txt固定経費輪転条件.FieldLockType = BaseContents.Field.LockType.None
        Me.txt固定経費輪転条件.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt固定経費輪転条件.HelpKeys = ""
        Me.txt固定経費輪転条件.HelpLink = ""
        Me.txt固定経費輪転条件.HelpType = NodeUI.Help.Type.None
        Me.txt固定経費輪転条件.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txt固定経費輪転条件.IsError = False
        Me.txt固定経費輪転条件.Location = New System.Drawing.Point(19, 24)
        Me.txt固定経費輪転条件.Name = "txt固定経費輪転条件"
        Me.txt固定経費輪転条件.Required = False
        Me.txt固定経費輪転条件.Size = New System.Drawing.Size(85, 23)
        Me.txt固定経費輪転条件.StringLength = 65535
        Me.txt固定経費輪転条件.TabIndex = 0
        Me.txt固定経費輪転条件.Text = "1,234,567"
        Me.txt固定経費輪転条件.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt固定経費輪転条件.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(110, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 16)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "通以下の場合は"
        '
        'frmMachine
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.grp固定経費算出条件輪転)
        Me.Controls.Add(Me.grp固定経費算出条件平圧)
        Me.Controls.Add(Me.grp担当者)
        Me.Controls.Add(Me.grp機械名)
        Me.Controls.Add(Me.grpコーター回転数)
        Me.Controls.Add(Me.grpコーター日数)
        Me.Controls.Add(Me.grp機械種別)
        Me.Controls.Add(Me.grp分類コード)
        Me.Controls.Add(Me.grp機械区分)
        Me.Controls.Add(Me.grp機械コード)
        Me.Controls.Add(Me.grp処理区分)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmMachine"
        Me.Text = ""
        Me.Controls.SetChildIndex(Me.grp処理区分, 0)
        Me.Controls.SetChildIndex(Me.grp機械コード, 0)
        Me.Controls.SetChildIndex(Me.grp機械区分, 0)
        Me.Controls.SetChildIndex(Me.grp分類コード, 0)
        Me.Controls.SetChildIndex(Me.grp機械種別, 0)
        Me.Controls.SetChildIndex(Me.grpコーター日数, 0)
        Me.Controls.SetChildIndex(Me.grpコーター回転数, 0)
        Me.Controls.SetChildIndex(Me.grp機械名, 0)
        Me.Controls.SetChildIndex(Me.grp担当者, 0)
        Me.Controls.SetChildIndex(Me.grp固定経費算出条件平圧, 0)
        Me.Controls.SetChildIndex(Me.grp固定経費算出条件輪転, 0)
        Me.grp処理区分.ResumeLayout(False)
        Me.grp処理区分.PerformLayout()
        Me.grp機械コード.ResumeLayout(False)
        Me.grp機械コード.PerformLayout()
        Me.grp機械区分.ResumeLayout(False)
        Me.grp分類コード.ResumeLayout(False)
        Me.grp分類コード.PerformLayout()
        Me.grp機械種別.ResumeLayout(False)
        Me.grpコーター日数.ResumeLayout(False)
        Me.grpコーター日数.PerformLayout()
        Me.grpコーター回転数.ResumeLayout(False)
        Me.grpコーター回転数.PerformLayout()
        Me.grp機械名.ResumeLayout(False)
        Me.grp機械名.PerformLayout()
        Me.grp担当者.ResumeLayout(False)
        Me.grp担当者.PerformLayout()
        Me.grp固定経費算出条件平圧.ResumeLayout(False)
        Me.grp固定経費算出条件平圧.PerformLayout()
        Me.grp固定経費算出条件輪転.ResumeLayout(False)
        Me.grp固定経費算出条件輪転.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp処理区分 As BaseUI.Control.GroupBox
    Friend WithEvents opt削除 As BaseUI.Control.RadioButton
    Friend WithEvents opt修正 As BaseUI.Control.RadioButton
    Friend WithEvents opt登録 As BaseUI.Control.RadioButton
    Friend WithEvents grp機械コード As BaseUI.Control.GroupBox
    Friend WithEvents grp機械区分 As BaseUI.Control.GroupBox
    Friend WithEvents txt機械CD As BaseUI.Control.TextBox
    Friend WithEvents grp分類コード As BaseUI.Control.GroupBox
    Friend WithEvents txt分類コード As BaseUI.Control.TextBox
    Friend WithEvents grp機械種別 As BaseUI.Control.GroupBox
    Friend WithEvents grpコーター日数 As BaseUI.Control.GroupBox
    Friend WithEvents txtコーター日数 As BaseUI.Control.TextBox
    Friend WithEvents grpコーター回転数 As BaseUI.Control.GroupBox
    Friend WithEvents txtコーター回転数 As BaseUI.Control.TextBox
    Friend WithEvents grp機械名 As BaseUI.Control.GroupBox
    Friend WithEvents txt機械名 As BaseUI.Control.TextBox
    Friend WithEvents grp担当者 As BaseUI.Control.GroupBox
    Friend WithEvents txt担当者コード As BaseUI.Control.TextBox
    Friend WithEvents grp固定経費算出条件平圧 As BaseUI.Control.GroupBox
    Friend WithEvents txt固定経費平圧金額 As BaseUI.Control.TextBox
    Friend WithEvents txt固定経費平圧条件 As BaseUI.Control.TextBox
    Friend WithEvents Label2 As BaseUI.Control.Label
    Friend WithEvents Label1 As BaseUI.Control.Label
    Friend WithEvents Label3 As BaseUI.Control.Label
    Friend WithEvents txt固定経費平圧条件外一通あたり金額 As BaseUI.Control.TextBox
    Friend WithEvents ddl機械区分 As BaseUI.Control.ComboBox
    Friend WithEvents ddl機械種別 As BaseUI.Control.ComboBox
    Friend WithEvents grp固定経費算出条件輪転 As BaseUI.Control.GroupBox
    Friend WithEvents Label4 As BaseUI.Control.Label
    Friend WithEvents txt固定経費輪転条件外一通あたり金額 As BaseUI.Control.TextBox
    Friend WithEvents Label5 As BaseUI.Control.Label
    Friend WithEvents Label6 As BaseUI.Control.Label
    Friend WithEvents txt固定経費輪転金額 As BaseUI.Control.TextBox
    Friend WithEvents txt固定経費輪転条件 As BaseUI.Control.TextBox
    Friend WithEvents Label7 As BaseUI.Control.Label
    Friend WithEvents Label8 As BaseUI.Control.Label
    Friend WithEvents nam担当者名 As BaseUI.Control.NameBox
End Class
