<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmItemName
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
        Me.grp品名CD = New BaseUI.Control.GroupBox()
        Me.txt品名CD = New BaseUI.Control.TextBox()
        Me.grp品名 = New BaseUI.Control.GroupBox()
        Me.txt品名 = New BaseUI.Control.TextBox()
        Me.grp得意先 = New BaseUI.Control.GroupBox()
        Me.nam得意先名 = New BaseUI.Control.NameBox()
        Me.txt得意先CD = New BaseUI.Control.TextBox()
        Me.grp御客様No = New BaseUI.Control.GroupBox()
        Me.txt御客様NO = New BaseUI.Control.TextBox()
        Me.grp定番品区分 = New BaseUI.Control.GroupBox()
        Me.ddl定番品区分 = New BaseUI.Control.ComboBox()
        Me.grp在庫区分 = New BaseUI.Control.GroupBox()
        Me.ddl在庫区分 = New BaseUI.Control.ComboBox()
        Me.grp本台帳No = New BaseUI.Control.GroupBox()
        Me.Label1 = New BaseUI.Control.Label()
        Me.txt本台帳NO連番 = New BaseUI.Control.TextBox()
        Me.txt本台帳No = New BaseUI.Control.TextBox()
        Me.grp表記用単価 = New BaseUI.Control.GroupBox()
        Me.txt表記用単価 = New BaseUI.Control.TextBox()
        Me.grp在庫単価 = New BaseUI.Control.GroupBox()
        Me.txt在庫単価 = New BaseUI.Control.TextBox()
        Me.grp売上単価 = New BaseUI.Control.GroupBox()
        Me.txt売上単価 = New BaseUI.Control.TextBox()
        Me.grp適正在庫数 = New BaseUI.Control.GroupBox()
        Me.txt適正在庫数 = New BaseUI.Control.TextBox()
        Me.grp摘要 = New BaseUI.Control.GroupBox()
        Me.txt摘要 = New BaseUI.Control.TextBox()
        Me.grpヤマト運輸専用情報 = New BaseUI.Control.GroupBox()
        Me.Label3 = New BaseUI.Control.Label()
        Me.Label2 = New BaseUI.Control.Label()
        Me.namヤマト種別名 = New BaseUI.Control.NameBox()
        Me.txtヤマト種別 = New BaseUI.Control.TextBox()
        Me.namヤマト区分名 = New BaseUI.Control.NameBox()
        Me.txtヤマト区分 = New BaseUI.Control.TextBox()
        Me.grp処理区分.SuspendLayout()
        Me.grp品名CD.SuspendLayout()
        Me.grp品名.SuspendLayout()
        Me.grp得意先.SuspendLayout()
        Me.grp御客様No.SuspendLayout()
        Me.grp定番品区分.SuspendLayout()
        Me.grp在庫区分.SuspendLayout()
        Me.grp本台帳No.SuspendLayout()
        Me.grp表記用単価.SuspendLayout()
        Me.grp在庫単価.SuspendLayout()
        Me.grp売上単価.SuspendLayout()
        Me.grp適正在庫数.SuspendLayout()
        Me.grp摘要.SuspendLayout()
        Me.grpヤマト運輸専用情報.SuspendLayout()
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
        'grp品名CD
        '
        Me.grp品名CD.Controls.Add(Me.txt品名CD)
        Me.grp品名CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp品名CD.Location = New System.Drawing.Point(29, 107)
        Me.grp品名CD.Name = "grp品名CD"
        Me.grp品名CD.Size = New System.Drawing.Size(153, 61)
        Me.grp品名CD.TabIndex = 1
        Me.grp品名CD.TabStop = False
        Me.grp品名CD.Text = "品名CD"
        '
        'txt品名CD
        '
        Me.txt品名CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt品名CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt品名CD.HelpKeys = ""
        Me.txt品名CD.HelpLink = ""
        Me.txt品名CD.HelpType = NodeUI.Help.Type.None
        Me.txt品名CD.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt品名CD.IsError = False
        Me.txt品名CD.Location = New System.Drawing.Point(19, 25)
        Me.txt品名CD.Name = "txt品名CD"
        Me.txt品名CD.Required = False
        Me.txt品名CD.Size = New System.Drawing.Size(112, 23)
        Me.txt品名CD.TabIndex = 0
        Me.txt品名CD.Text = "1234567890123"
        Me.txt品名CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp品名
        '
        Me.grp品名.Controls.Add(Me.txt品名)
        Me.grp品名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp品名.Location = New System.Drawing.Point(226, 107)
        Me.grp品名.Name = "grp品名"
        Me.grp品名.Size = New System.Drawing.Size(312, 61)
        Me.grp品名.TabIndex = 2
        Me.grp品名.TabStop = False
        Me.grp品名.Text = "品名"
        '
        'txt品名
        '
        Me.txt品名.FieldLockType = BaseContents.Field.LockType.None
        Me.txt品名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt品名.HelpKeys = ""
        Me.txt品名.HelpLink = ""
        Me.txt品名.HelpType = NodeUI.Help.Type.None
        Me.txt品名.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txt品名.IsError = False
        Me.txt品名.Location = New System.Drawing.Point(19, 25)
        Me.txt品名.Name = "txt品名"
        Me.txt品名.Required = False
        Me.txt品名.Size = New System.Drawing.Size(264, 23)
        Me.txt品名.TabIndex = 0
        Me.txt品名.Text = "ああああああああああいいいいいい"
        Me.txt品名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp得意先
        '
        Me.grp得意先.Controls.Add(Me.nam得意先名)
        Me.grp得意先.Controls.Add(Me.txt得意先CD)
        Me.grp得意先.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp得意先.Location = New System.Drawing.Point(29, 274)
        Me.grp得意先.Name = "grp得意先"
        Me.grp得意先.Size = New System.Drawing.Size(379, 61)
        Me.grp得意先.TabIndex = 5
        Me.grp得意先.TabStop = False
        Me.grp得意先.Text = "得意先CD"
        '
        'nam得意先名
        '
        Me.nam得意先名.BackColor = System.Drawing.SystemColors.Control
        Me.nam得意先名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam得意先名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam得意先名.Location = New System.Drawing.Point(79, 24)
        Me.nam得意先名.Margin = New System.Windows.Forms.Padding(3)
        Me.nam得意先名.Name = "nam得意先名"
        Me.nam得意先名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.nam得意先名.Size = New System.Drawing.Size(264, 23)
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
        Me.txt得意先CD.Location = New System.Drawing.Point(19, 24)
        Me.txt得意先CD.Name = "txt得意先CD"
        Me.txt得意先CD.Required = False
        Me.txt得意先CD.Size = New System.Drawing.Size(61, 23)
        Me.txt得意先CD.TabIndex = 0
        Me.txt得意先CD.Text = "999999"
        Me.txt得意先CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp御客様No
        '
        Me.grp御客様No.Controls.Add(Me.txt御客様NO)
        Me.grp御客様No.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp御客様No.Location = New System.Drawing.Point(490, 274)
        Me.grp御客様No.Name = "grp御客様No"
        Me.grp御客様No.Size = New System.Drawing.Size(110, 61)
        Me.grp御客様No.TabIndex = 6
        Me.grp御客様No.TabStop = False
        Me.grp御客様No.Text = "御客様No"
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
        Me.txt御客様NO.Size = New System.Drawing.Size(64, 23)
        Me.txt御客様NO.TabIndex = 0
        Me.txt御客様NO.Text = "1234567"
        Me.txt御客様NO.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp定番品区分
        '
        Me.grp定番品区分.Controls.Add(Me.ddl定番品区分)
        Me.grp定番品区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp定番品区分.Location = New System.Drawing.Point(29, 196)
        Me.grp定番品区分.Name = "grp定番品区分"
        Me.grp定番品区分.Size = New System.Drawing.Size(239, 61)
        Me.grp定番品区分.TabIndex = 3
        Me.grp定番品区分.TabStop = False
        Me.grp定番品区分.Text = "定番品区分"
        '
        'ddl定番品区分
        '
        Me.ddl定番品区分.AutoDropDown = True
        Me.ddl定番品区分.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddl定番品区分.FieldLockType = BaseContents.Field.LockType.None
        Me.ddl定番品区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.ddl定番品区分.FormattingEnabled = True
        Me.ddl定番品区分.IsError = False
        Me.ddl定番品区分.ListType = NodeUI.List.Type.None
        Me.ddl定番品区分.Location = New System.Drawing.Point(19, 23)
        Me.ddl定番品区分.Name = "ddl定番品区分"
        Me.ddl定番品区分.Required = False
        Me.ddl定番品区分.Size = New System.Drawing.Size(188, 24)
        Me.ddl定番品区分.TabIndex = 0
        '
        'grp在庫区分
        '
        Me.grp在庫区分.Controls.Add(Me.ddl在庫区分)
        Me.grp在庫区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp在庫区分.Location = New System.Drawing.Point(297, 196)
        Me.grp在庫区分.Name = "grp在庫区分"
        Me.grp在庫区分.Size = New System.Drawing.Size(191, 61)
        Me.grp在庫区分.TabIndex = 4
        Me.grp在庫区分.TabStop = False
        Me.grp在庫区分.Text = "在庫区分"
        '
        'ddl在庫区分
        '
        Me.ddl在庫区分.AutoDropDown = True
        Me.ddl在庫区分.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddl在庫区分.FieldLockType = BaseContents.Field.LockType.None
        Me.ddl在庫区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.ddl在庫区分.FormattingEnabled = True
        Me.ddl在庫区分.IsError = False
        Me.ddl在庫区分.ListType = NodeUI.List.Type.None
        Me.ddl在庫区分.Location = New System.Drawing.Point(19, 23)
        Me.ddl在庫区分.Name = "ddl在庫区分"
        Me.ddl在庫区分.Required = False
        Me.ddl在庫区分.Size = New System.Drawing.Size(146, 24)
        Me.ddl在庫区分.TabIndex = 0
        '
        'grp本台帳No
        '
        Me.grp本台帳No.Controls.Add(Me.Label1)
        Me.grp本台帳No.Controls.Add(Me.txt本台帳NO連番)
        Me.grp本台帳No.Controls.Add(Me.txt本台帳No)
        Me.grp本台帳No.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp本台帳No.Location = New System.Drawing.Point(630, 274)
        Me.grp本台帳No.Name = "grp本台帳No"
        Me.grp本台帳No.Size = New System.Drawing.Size(156, 61)
        Me.grp本台帳No.TabIndex = 7
        Me.grp本台帳No.TabStop = False
        Me.grp本台帳No.Text = "本台帳No"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Enabled = False
        Me.Label1.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.0!)
        Me.Label1.Location = New System.Drawing.Point(81, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(15, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "-"
        '
        'txt本台帳NO連番
        '
        Me.txt本台帳NO連番.FieldLockType = BaseContents.Field.LockType.None
        Me.txt本台帳NO連番.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt本台帳NO連番.HelpKeys = ""
        Me.txt本台帳NO連番.HelpLink = ""
        Me.txt本台帳NO連番.HelpType = NodeUI.Help.Type.None
        Me.txt本台帳NO連番.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt本台帳NO連番.IsError = False
        Me.txt本台帳NO連番.Location = New System.Drawing.Point(96, 25)
        Me.txt本台帳NO連番.Name = "txt本台帳NO連番"
        Me.txt本台帳NO連番.Required = False
        Me.txt本台帳NO連番.Size = New System.Drawing.Size(25, 23)
        Me.txt本台帳NO連番.TabIndex = 2
        Me.txt本台帳NO連番.Text = "12"
        Me.txt本台帳NO連番.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt本台帳No
        '
        Me.txt本台帳No.FieldLockType = BaseContents.Field.LockType.None
        Me.txt本台帳No.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt本台帳No.HelpKeys = ""
        Me.txt本台帳No.HelpLink = ""
        Me.txt本台帳No.HelpType = NodeUI.Help.Type.None
        Me.txt本台帳No.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt本台帳No.IsError = False
        Me.txt本台帳No.Location = New System.Drawing.Point(19, 25)
        Me.txt本台帳No.Name = "txt本台帳No"
        Me.txt本台帳No.Required = False
        Me.txt本台帳No.Size = New System.Drawing.Size(62, 23)
        Me.txt本台帳No.TabIndex = 0
        Me.txt本台帳No.Text = "123456"
        Me.txt本台帳No.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp表記用単価
        '
        Me.grp表記用単価.Controls.Add(Me.txt表記用単価)
        Me.grp表記用単価.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp表記用単価.Location = New System.Drawing.Point(646, 365)
        Me.grp表記用単価.Name = "grp表記用単価"
        Me.grp表記用単価.Size = New System.Drawing.Size(140, 61)
        Me.grp表記用単価.TabIndex = 11
        Me.grp表記用単価.TabStop = False
        Me.grp表記用単価.Text = "表記用単価"
        '
        'txt表記用単価
        '
        Me.txt表記用単価.FieldLockType = BaseContents.Field.LockType.None
        Me.txt表記用単価.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt表記用単価.HelpKeys = ""
        Me.txt表記用単価.HelpLink = ""
        Me.txt表記用単価.HelpType = NodeUI.Help.Type.None
        Me.txt表記用単価.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt表記用単価.IsError = False
        Me.txt表記用単価.Location = New System.Drawing.Point(19, 25)
        Me.txt表記用単価.Name = "txt表記用単価"
        Me.txt表記用単価.Required = False
        Me.txt表記用単価.Size = New System.Drawing.Size(114, 23)
        Me.txt表記用単価.TabIndex = 0
        Me.txt表記用単価.Text = "1,234,567.12"
        Me.txt表記用単価.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt表記用単価.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp在庫単価
        '
        Me.grp在庫単価.Controls.Add(Me.txt在庫単価)
        Me.grp在庫単価.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp在庫単価.Location = New System.Drawing.Point(460, 365)
        Me.grp在庫単価.Name = "grp在庫単価"
        Me.grp在庫単価.Size = New System.Drawing.Size(140, 61)
        Me.grp在庫単価.TabIndex = 10
        Me.grp在庫単価.TabStop = False
        Me.grp在庫単価.Text = "在庫単価"
        '
        'txt在庫単価
        '
        Me.txt在庫単価.FieldLockType = BaseContents.Field.LockType.None
        Me.txt在庫単価.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt在庫単価.HelpKeys = ""
        Me.txt在庫単価.HelpLink = ""
        Me.txt在庫単価.HelpType = NodeUI.Help.Type.None
        Me.txt在庫単価.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt在庫単価.IsError = False
        Me.txt在庫単価.Location = New System.Drawing.Point(19, 25)
        Me.txt在庫単価.Name = "txt在庫単価"
        Me.txt在庫単価.Required = False
        Me.txt在庫単価.Size = New System.Drawing.Size(114, 23)
        Me.txt在庫単価.TabIndex = 0
        Me.txt在庫単価.Text = "1,234,567.12"
        Me.txt在庫単価.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt在庫単価.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp売上単価
        '
        Me.grp売上単価.Controls.Add(Me.txt売上単価)
        Me.grp売上単価.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp売上単価.Location = New System.Drawing.Point(268, 365)
        Me.grp売上単価.Name = "grp売上単価"
        Me.grp売上単価.Size = New System.Drawing.Size(140, 61)
        Me.grp売上単価.TabIndex = 9
        Me.grp売上単価.TabStop = False
        Me.grp売上単価.Text = "売上単価"
        '
        'txt売上単価
        '
        Me.txt売上単価.FieldLockType = BaseContents.Field.LockType.None
        Me.txt売上単価.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt売上単価.HelpKeys = ""
        Me.txt売上単価.HelpLink = ""
        Me.txt売上単価.HelpType = NodeUI.Help.Type.None
        Me.txt売上単価.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt売上単価.IsError = False
        Me.txt売上単価.Location = New System.Drawing.Point(19, 25)
        Me.txt売上単価.Name = "txt売上単価"
        Me.txt売上単価.Required = False
        Me.txt売上単価.Size = New System.Drawing.Size(114, 23)
        Me.txt売上単価.TabIndex = 0
        Me.txt売上単価.Text = "1,234,567.12"
        Me.txt売上単価.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt売上単価.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp適正在庫数
        '
        Me.grp適正在庫数.Controls.Add(Me.txt適正在庫数)
        Me.grp適正在庫数.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp適正在庫数.Location = New System.Drawing.Point(29, 365)
        Me.grp適正在庫数.Name = "grp適正在庫数"
        Me.grp適正在庫数.Size = New System.Drawing.Size(153, 61)
        Me.grp適正在庫数.TabIndex = 8
        Me.grp適正在庫数.TabStop = False
        Me.grp適正在庫数.Text = "適正在庫数"
        '
        'txt適正在庫数
        '
        Me.txt適正在庫数.FieldLockType = BaseContents.Field.LockType.None
        Me.txt適正在庫数.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt適正在庫数.HelpKeys = ""
        Me.txt適正在庫数.HelpLink = ""
        Me.txt適正在庫数.HelpType = NodeUI.Help.Type.None
        Me.txt適正在庫数.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt適正在庫数.IsError = False
        Me.txt適正在庫数.Location = New System.Drawing.Point(19, 25)
        Me.txt適正在庫数.Name = "txt適正在庫数"
        Me.txt適正在庫数.Required = False
        Me.txt適正在庫数.Size = New System.Drawing.Size(128, 23)
        Me.txt適正在庫数.TabIndex = 0
        Me.txt適正在庫数.Text = "12,345,678,901"
        Me.txt適正在庫数.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt適正在庫数.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp摘要
        '
        Me.grp摘要.Controls.Add(Me.txt摘要)
        Me.grp摘要.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp摘要.Location = New System.Drawing.Point(29, 559)
        Me.grp摘要.Name = "grp摘要"
        Me.grp摘要.Size = New System.Drawing.Size(321, 61)
        Me.grp摘要.TabIndex = 13
        Me.grp摘要.TabStop = False
        Me.grp摘要.Text = "摘要"
        '
        'txt摘要
        '
        Me.txt摘要.FieldLockType = BaseContents.Field.LockType.None
        Me.txt摘要.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt摘要.HelpKeys = ""
        Me.txt摘要.HelpLink = ""
        Me.txt摘要.HelpType = NodeUI.Help.Type.None
        Me.txt摘要.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt摘要.IsError = False
        Me.txt摘要.Location = New System.Drawing.Point(19, 25)
        Me.txt摘要.Name = "txt摘要"
        Me.txt摘要.Required = False
        Me.txt摘要.Size = New System.Drawing.Size(264, 23)
        Me.txt摘要.TabIndex = 0
        Me.txt摘要.Text = "ああああああああああいいいいいい"
        Me.txt摘要.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grpヤマト運輸専用情報
        '
        Me.grpヤマト運輸専用情報.Controls.Add(Me.Label3)
        Me.grpヤマト運輸専用情報.Controls.Add(Me.Label2)
        Me.grpヤマト運輸専用情報.Controls.Add(Me.namヤマト種別名)
        Me.grpヤマト運輸専用情報.Controls.Add(Me.txtヤマト種別)
        Me.grpヤマト運輸専用情報.Controls.Add(Me.namヤマト区分名)
        Me.grpヤマト運輸専用情報.Controls.Add(Me.txtヤマト区分)
        Me.grpヤマト運輸専用情報.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grpヤマト運輸専用情報.Location = New System.Drawing.Point(29, 462)
        Me.grpヤマト運輸専用情報.Name = "grpヤマト運輸専用情報"
        Me.grpヤマト運輸専用情報.Size = New System.Drawing.Size(515, 61)
        Me.grpヤマト運輸専用情報.TabIndex = 12
        Me.grpヤマト運輸専用情報.TabStop = False
        Me.grpヤマト運輸専用情報.Text = "ヤマト運輸専用情報"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Enabled = False
        Me.Label3.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.0!)
        Me.Label3.Location = New System.Drawing.Point(16, 28)
        Me.Label3.Margin = New System.Windows.Forms.Padding(0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "ﾃﾞｰﾀ区分"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Enabled = False
        Me.Label2.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.0!)
        Me.Label2.Location = New System.Drawing.Point(340, 28)
        Me.Label2.Margin = New System.Windows.Forms.Padding(0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "種別"
        '
        'namヤマト種別名
        '
        Me.namヤマト種別名.BackColor = System.Drawing.SystemColors.Control
        Me.namヤマト種別名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.namヤマト種別名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.namヤマト種別名.Location = New System.Drawing.Point(400, 24)
        Me.namヤマト種別名.Margin = New System.Windows.Forms.Padding(3)
        Me.namヤマト種別名.Name = "namヤマト種別名"
        Me.namヤマト種別名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.namヤマト種別名.Size = New System.Drawing.Size(50, 23)
        Me.namヤマト種別名.TabIndex = 5
        Me.namヤマト種別名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txtヤマト種別
        '
        Me.txtヤマト種別.FieldLockType = BaseContents.Field.LockType.None
        Me.txtヤマト種別.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txtヤマト種別.HelpKeys = ""
        Me.txtヤマト種別.HelpLink = ""
        Me.txtヤマト種別.HelpType = NodeUI.Help.Type.None
        Me.txtヤマト種別.IsError = False
        Me.txtヤマト種別.Location = New System.Drawing.Point(382, 24)
        Me.txtヤマト種別.Name = "txtヤマト種別"
        Me.txtヤマト種別.Required = False
        Me.txtヤマト種別.ShortcutsEnabled = False
        Me.txtヤマト種別.Size = New System.Drawing.Size(17, 23)
        Me.txtヤマト種別.TabIndex = 4
        Me.txtヤマト種別.Text = "1"
        Me.txtヤマト種別.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'namヤマト区分名
        '
        Me.namヤマト区分名.BackColor = System.Drawing.SystemColors.Control
        Me.namヤマト区分名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.namヤマト区分名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.namヤマト区分名.Location = New System.Drawing.Point(110, 24)
        Me.namヤマト区分名.Margin = New System.Windows.Forms.Padding(3)
        Me.namヤマト区分名.Name = "namヤマト区分名"
        Me.namヤマト区分名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.namヤマト区分名.Size = New System.Drawing.Size(189, 23)
        Me.namヤマト区分名.TabIndex = 2
        Me.namヤマト区分名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txtヤマト区分
        '
        Me.txtヤマト区分.FieldLockType = BaseContents.Field.LockType.None
        Me.txtヤマト区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txtヤマト区分.HelpKeys = ""
        Me.txtヤマト区分.HelpLink = ""
        Me.txtヤマト区分.HelpType = NodeUI.Help.Type.None
        Me.txtヤマト区分.IsError = False
        Me.txtヤマト区分.Location = New System.Drawing.Point(87, 24)
        Me.txtヤマト区分.Name = "txtヤマト区分"
        Me.txtヤマト区分.Required = False
        Me.txtヤマト区分.Size = New System.Drawing.Size(22, 23)
        Me.txtヤマト区分.TabIndex = 1
        Me.txtヤマト区分.Text = "12"
        Me.txtヤマト区分.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'frmItemName
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.grpヤマト運輸専用情報)
        Me.Controls.Add(Me.grp摘要)
        Me.Controls.Add(Me.grp在庫単価)
        Me.Controls.Add(Me.grp売上単価)
        Me.Controls.Add(Me.grp適正在庫数)
        Me.Controls.Add(Me.grp表記用単価)
        Me.Controls.Add(Me.grp本台帳No)
        Me.Controls.Add(Me.grp在庫区分)
        Me.Controls.Add(Me.grp定番品区分)
        Me.Controls.Add(Me.grp御客様No)
        Me.Controls.Add(Me.grp得意先)
        Me.Controls.Add(Me.grp品名)
        Me.Controls.Add(Me.grp品名CD)
        Me.Controls.Add(Me.grp処理区分)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmItemName"
        Me.Text = ""
        Me.Controls.SetChildIndex(Me.grp処理区分, 0)
        Me.Controls.SetChildIndex(Me.grp品名CD, 0)
        Me.Controls.SetChildIndex(Me.grp品名, 0)
        Me.Controls.SetChildIndex(Me.grp得意先, 0)
        Me.Controls.SetChildIndex(Me.grp御客様No, 0)
        Me.Controls.SetChildIndex(Me.grp定番品区分, 0)
        Me.Controls.SetChildIndex(Me.grp在庫区分, 0)
        Me.Controls.SetChildIndex(Me.grp本台帳No, 0)
        Me.Controls.SetChildIndex(Me.grp表記用単価, 0)
        Me.Controls.SetChildIndex(Me.grp適正在庫数, 0)
        Me.Controls.SetChildIndex(Me.grp売上単価, 0)
        Me.Controls.SetChildIndex(Me.grp在庫単価, 0)
        Me.Controls.SetChildIndex(Me.grp摘要, 0)
        Me.Controls.SetChildIndex(Me.grpヤマト運輸専用情報, 0)
        Me.grp処理区分.ResumeLayout(False)
        Me.grp処理区分.PerformLayout()
        Me.grp品名CD.ResumeLayout(False)
        Me.grp品名CD.PerformLayout()
        Me.grp品名.ResumeLayout(False)
        Me.grp品名.PerformLayout()
        Me.grp得意先.ResumeLayout(False)
        Me.grp得意先.PerformLayout()
        Me.grp御客様No.ResumeLayout(False)
        Me.grp御客様No.PerformLayout()
        Me.grp定番品区分.ResumeLayout(False)
        Me.grp在庫区分.ResumeLayout(False)
        Me.grp本台帳No.ResumeLayout(False)
        Me.grp本台帳No.PerformLayout()
        Me.grp表記用単価.ResumeLayout(False)
        Me.grp表記用単価.PerformLayout()
        Me.grp在庫単価.ResumeLayout(False)
        Me.grp在庫単価.PerformLayout()
        Me.grp売上単価.ResumeLayout(False)
        Me.grp売上単価.PerformLayout()
        Me.grp適正在庫数.ResumeLayout(False)
        Me.grp適正在庫数.PerformLayout()
        Me.grp摘要.ResumeLayout(False)
        Me.grp摘要.PerformLayout()
        Me.grpヤマト運輸専用情報.ResumeLayout(False)
        Me.grpヤマト運輸専用情報.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp処理区分 As BaseUI.Control.GroupBox
    Friend WithEvents opt削除 As BaseUI.Control.RadioButton
    Friend WithEvents opt修正 As BaseUI.Control.RadioButton
    Friend WithEvents opt登録 As BaseUI.Control.RadioButton
    Friend WithEvents grp品名CD As BaseUI.Control.GroupBox
    Friend WithEvents txt品名CD As BaseUI.Control.TextBox
    Friend WithEvents grp品名 As BaseUI.Control.GroupBox
    Friend WithEvents txt品名 As BaseUI.Control.TextBox
    Friend WithEvents grp得意先 As BaseUI.Control.GroupBox
    Friend WithEvents nam得意先名 As BaseUI.Control.NameBox
    Friend WithEvents txt得意先CD As BaseUI.Control.TextBox
    Friend WithEvents grp御客様No As BaseUI.Control.GroupBox
    Friend WithEvents txt御客様NO As BaseUI.Control.TextBox
    Friend WithEvents grp定番品区分 As BaseUI.Control.GroupBox
    Friend WithEvents ddl定番品区分 As BaseUI.Control.ComboBox
    Friend WithEvents grp在庫区分 As BaseUI.Control.GroupBox
    Friend WithEvents ddl在庫区分 As BaseUI.Control.ComboBox
    Friend WithEvents grp本台帳No As BaseUI.Control.GroupBox
    Friend WithEvents txt本台帳NO連番 As BaseUI.Control.TextBox
    Friend WithEvents txt本台帳No As BaseUI.Control.TextBox
    Friend WithEvents Label1 As BaseUI.Control.Label
    Friend WithEvents grp表記用単価 As BaseUI.Control.GroupBox
    Friend WithEvents txt表記用単価 As BaseUI.Control.TextBox
    Friend WithEvents grp在庫単価 As BaseUI.Control.GroupBox
    Friend WithEvents txt在庫単価 As BaseUI.Control.TextBox
    Friend WithEvents grp売上単価 As BaseUI.Control.GroupBox
    Friend WithEvents txt売上単価 As BaseUI.Control.TextBox
    Friend WithEvents grp適正在庫数 As BaseUI.Control.GroupBox
    Friend WithEvents txt適正在庫数 As BaseUI.Control.TextBox
    Friend WithEvents grp摘要 As BaseUI.Control.GroupBox
    Friend WithEvents txt摘要 As BaseUI.Control.TextBox
    Friend WithEvents grpヤマト運輸専用情報 As BaseUI.Control.GroupBox
    Friend WithEvents Label3 As BaseUI.Control.Label
    Friend WithEvents Label2 As BaseUI.Control.Label
    Friend WithEvents namヤマト種別名 As BaseUI.Control.NameBox
    Friend WithEvents txtヤマト種別 As BaseUI.Control.TextBox
    Friend WithEvents namヤマト区分名 As BaseUI.Control.NameBox
    Friend WithEvents txtヤマト区分 As BaseUI.Control.TextBox
End Class
