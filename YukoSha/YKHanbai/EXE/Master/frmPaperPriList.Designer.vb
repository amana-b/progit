<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaperPriList
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
        Me.grp仕入先 = New BaseUI.Control.GroupBox()
        Me.lblまで = New BaseUI.Control.Label()
        Me.lblから = New BaseUI.Control.Label()
        Me.nam仕入先名T = New BaseUI.Control.NameBox()
        Me.txt仕入先CDT = New BaseUI.Control.TextBox()
        Me.nam仕入先名F = New BaseUI.Control.NameBox()
        Me.txt仕入先CDF = New BaseUI.Control.TextBox()
        Me.grp社内用 = New BaseUI.Control.GroupBox()
        Me.grp台紙 = New BaseUI.Control.GroupBox()
        Me.Label5 = New BaseUI.Control.Label()
        Me.Label6 = New BaseUI.Control.Label()
        Me.nam社内用台紙名T = New BaseUI.Control.NameBox()
        Me.txt社内用台紙CDT = New BaseUI.Control.TextBox()
        Me.nam社内用台紙名F = New BaseUI.Control.NameBox()
        Me.txt社内用台紙CDF = New BaseUI.Control.TextBox()
        Me.grp糊 = New BaseUI.Control.GroupBox()
        Me.Label1 = New BaseUI.Control.Label()
        Me.Label2 = New BaseUI.Control.Label()
        Me.nam社内用糊名T = New BaseUI.Control.NameBox()
        Me.txt社内用糊CDT = New BaseUI.Control.TextBox()
        Me.nam社内用糊名F = New BaseUI.Control.NameBox()
        Me.txt社内用糊CDF = New BaseUI.Control.TextBox()
        Me.grp紙 = New BaseUI.Control.GroupBox()
        Me.Label3 = New BaseUI.Control.Label()
        Me.Label4 = New BaseUI.Control.Label()
        Me.nam社内用紙名T = New BaseUI.Control.NameBox()
        Me.txt社内用紙CDT = New BaseUI.Control.TextBox()
        Me.nam社内用紙名F = New BaseUI.Control.NameBox()
        Me.txt社内用紙CDF = New BaseUI.Control.TextBox()
        Me.grp単価区分 = New BaseUI.Control.GroupBox()
        Me.opt両方 = New BaseUI.Control.RadioButton()
        Me.optm単価 = New BaseUI.Control.RadioButton()
        Me.opt平米単価 = New BaseUI.Control.RadioButton()
        Me.grp単価種別 = New BaseUI.Control.GroupBox()
        Me.opt社内単価 = New BaseUI.Control.RadioButton()
        Me.opt発注単価 = New BaseUI.Control.RadioButton()
        Me.grpソート区分 = New BaseUI.Control.GroupBox()
        Me.opt紙糊台紙CD順 = New BaseUI.Control.RadioButton()
        Me.opt仕入先CD順 = New BaseUI.Control.RadioButton()
        Me.grp仕入先.SuspendLayout()
        Me.grp社内用.SuspendLayout()
        Me.grp台紙.SuspendLayout()
        Me.grp糊.SuspendLayout()
        Me.grp紙.SuspendLayout()
        Me.grp単価区分.SuspendLayout()
        Me.grp単価種別.SuspendLayout()
        Me.grpソート区分.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnESC
        '
        Me.btnESC.Text = "閉じる"
        '
        'grp仕入先
        '
        Me.grp仕入先.Controls.Add(Me.lblまで)
        Me.grp仕入先.Controls.Add(Me.lblから)
        Me.grp仕入先.Controls.Add(Me.nam仕入先名T)
        Me.grp仕入先.Controls.Add(Me.txt仕入先CDT)
        Me.grp仕入先.Controls.Add(Me.nam仕入先名F)
        Me.grp仕入先.Controls.Add(Me.txt仕入先CDF)
        Me.grp仕入先.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp仕入先.Location = New System.Drawing.Point(36, 44)
        Me.grp仕入先.Name = "grp仕入先"
        Me.grp仕入先.Size = New System.Drawing.Size(445, 103)
        Me.grp仕入先.TabIndex = 0
        Me.grp仕入先.TabStop = False
        Me.grp仕入先.Text = "仕入先ｺｰﾄﾞ"
        '
        'lblまで
        '
        Me.lblまで.AutoSize = True
        Me.lblまで.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.lblまで.Location = New System.Drawing.Point(31, 67)
        Me.lblまで.Name = "lblまで"
        Me.lblまで.Size = New System.Drawing.Size(56, 16)
        Me.lblまで.TabIndex = 13
        Me.lblまで.Text = "[まで]"
        '
        'lblから
        '
        Me.lblから.AutoSize = True
        Me.lblから.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.lblから.Location = New System.Drawing.Point(31, 36)
        Me.lblから.Name = "lblから"
        Me.lblから.Size = New System.Drawing.Size(56, 16)
        Me.lblから.TabIndex = 12
        Me.lblから.Text = "[から]"
        '
        'nam仕入先名T
        '
        Me.nam仕入先名T.BackColor = System.Drawing.SystemColors.Control
        Me.nam仕入先名T.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam仕入先名T.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam仕入先名T.Location = New System.Drawing.Point(149, 64)
        Me.nam仕入先名T.Margin = New System.Windows.Forms.Padding(3)
        Me.nam仕入先名T.Name = "nam仕入先名T"
        Me.nam仕入先名T.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.nam仕入先名T.Size = New System.Drawing.Size(260, 23)
        Me.nam仕入先名T.TabIndex = 11
        Me.nam仕入先名T.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt仕入先CDT
        '
        Me.txt仕入先CDT.FieldLockType = BaseContents.Field.LockType.None
        Me.txt仕入先CDT.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt仕入先CDT.HelpKeys = ""
        Me.txt仕入先CDT.HelpLink = ""
        Me.txt仕入先CDT.HelpType = NodeUI.Help.Type.None
        Me.txt仕入先CDT.IsError = False
        Me.txt仕入先CDT.Location = New System.Drawing.Point(89, 64)
        Me.txt仕入先CDT.Name = "txt仕入先CDT"
        Me.txt仕入先CDT.Required = False
        Me.txt仕入先CDT.Size = New System.Drawing.Size(61, 23)
        Me.txt仕入先CDT.TabIndex = 10
        Me.txt仕入先CDT.Text = "999999"
        Me.txt仕入先CDT.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam仕入先名F
        '
        Me.nam仕入先名F.BackColor = System.Drawing.SystemColors.Control
        Me.nam仕入先名F.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam仕入先名F.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam仕入先名F.Location = New System.Drawing.Point(149, 33)
        Me.nam仕入先名F.Margin = New System.Windows.Forms.Padding(3)
        Me.nam仕入先名F.Name = "nam仕入先名F"
        Me.nam仕入先名F.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.nam仕入先名F.Size = New System.Drawing.Size(260, 23)
        Me.nam仕入先名F.TabIndex = 9
        Me.nam仕入先名F.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt仕入先CDF
        '
        Me.txt仕入先CDF.FieldLockType = BaseContents.Field.LockType.None
        Me.txt仕入先CDF.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt仕入先CDF.HelpKeys = ""
        Me.txt仕入先CDF.HelpLink = ""
        Me.txt仕入先CDF.HelpType = NodeUI.Help.Type.None
        Me.txt仕入先CDF.IsError = False
        Me.txt仕入先CDF.Location = New System.Drawing.Point(89, 33)
        Me.txt仕入先CDF.Name = "txt仕入先CDF"
        Me.txt仕入先CDF.Required = False
        Me.txt仕入先CDF.Size = New System.Drawing.Size(61, 23)
        Me.txt仕入先CDF.TabIndex = 0
        Me.txt仕入先CDF.Text = "999999"
        Me.txt仕入先CDF.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp社内用
        '
        Me.grp社内用.Controls.Add(Me.grp台紙)
        Me.grp社内用.Controls.Add(Me.grp糊)
        Me.grp社内用.Controls.Add(Me.grp紙)
        Me.grp社内用.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp社内用.Location = New System.Drawing.Point(36, 176)
        Me.grp社内用.Name = "grp社内用"
        Me.grp社内用.Size = New System.Drawing.Size(535, 421)
        Me.grp社内用.TabIndex = 1
        Me.grp社内用.TabStop = False
        Me.grp社内用.Text = "社内用"
        '
        'grp台紙
        '
        Me.grp台紙.Controls.Add(Me.Label5)
        Me.grp台紙.Controls.Add(Me.Label6)
        Me.grp台紙.Controls.Add(Me.nam社内用台紙名T)
        Me.grp台紙.Controls.Add(Me.txt社内用台紙CDT)
        Me.grp台紙.Controls.Add(Me.nam社内用台紙名F)
        Me.grp台紙.Controls.Add(Me.txt社内用台紙CDF)
        Me.grp台紙.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp台紙.Location = New System.Drawing.Point(34, 292)
        Me.grp台紙.Name = "grp台紙"
        Me.grp台紙.Size = New System.Drawing.Size(326, 110)
        Me.grp台紙.TabIndex = 2
        Me.grp台紙.TabStop = False
        Me.grp台紙.Text = "台紙ｺｰﾄﾞ"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.Label5.Location = New System.Drawing.Point(28, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 16)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "[まで]"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.Label6.Location = New System.Drawing.Point(28, 36)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 16)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "[から]"
        '
        'nam社内用台紙名T
        '
        Me.nam社内用台紙名T.BackColor = System.Drawing.SystemColors.Control
        Me.nam社内用台紙名T.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam社内用台紙名T.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam社内用台紙名T.Location = New System.Drawing.Point(112, 64)
        Me.nam社内用台紙名T.Margin = New System.Windows.Forms.Padding(3)
        Me.nam社内用台紙名T.Name = "nam社内用台紙名T"
        Me.nam社内用台紙名T.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.nam社内用台紙名T.Size = New System.Drawing.Size(174, 23)
        Me.nam社内用台紙名T.TabIndex = 11
        Me.nam社内用台紙名T.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt社内用台紙CDT
        '
        Me.txt社内用台紙CDT.FieldLockType = BaseContents.Field.LockType.None
        Me.txt社内用台紙CDT.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt社内用台紙CDT.HelpKeys = ""
        Me.txt社内用台紙CDT.HelpLink = ""
        Me.txt社内用台紙CDT.HelpType = NodeUI.Help.Type.None
        Me.txt社内用台紙CDT.IsError = False
        Me.txt社内用台紙CDT.Location = New System.Drawing.Point(86, 64)
        Me.txt社内用台紙CDT.Name = "txt社内用台紙CDT"
        Me.txt社内用台紙CDT.Required = False
        Me.txt社内用台紙CDT.Size = New System.Drawing.Size(25, 23)
        Me.txt社内用台紙CDT.TabIndex = 10
        Me.txt社内用台紙CDT.Text = "99"
        Me.txt社内用台紙CDT.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam社内用台紙名F
        '
        Me.nam社内用台紙名F.BackColor = System.Drawing.SystemColors.Control
        Me.nam社内用台紙名F.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam社内用台紙名F.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam社内用台紙名F.Location = New System.Drawing.Point(112, 33)
        Me.nam社内用台紙名F.Margin = New System.Windows.Forms.Padding(3)
        Me.nam社内用台紙名F.Name = "nam社内用台紙名F"
        Me.nam社内用台紙名F.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.nam社内用台紙名F.Size = New System.Drawing.Size(174, 23)
        Me.nam社内用台紙名F.TabIndex = 9
        Me.nam社内用台紙名F.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt社内用台紙CDF
        '
        Me.txt社内用台紙CDF.FieldLockType = BaseContents.Field.LockType.None
        Me.txt社内用台紙CDF.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt社内用台紙CDF.HelpKeys = ""
        Me.txt社内用台紙CDF.HelpLink = ""
        Me.txt社内用台紙CDF.HelpType = NodeUI.Help.Type.None
        Me.txt社内用台紙CDF.IsError = False
        Me.txt社内用台紙CDF.Location = New System.Drawing.Point(86, 33)
        Me.txt社内用台紙CDF.Name = "txt社内用台紙CDF"
        Me.txt社内用台紙CDF.Required = False
        Me.txt社内用台紙CDF.Size = New System.Drawing.Size(25, 23)
        Me.txt社内用台紙CDF.TabIndex = 0
        Me.txt社内用台紙CDF.Text = "99"
        Me.txt社内用台紙CDF.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp糊
        '
        Me.grp糊.Controls.Add(Me.Label1)
        Me.grp糊.Controls.Add(Me.Label2)
        Me.grp糊.Controls.Add(Me.nam社内用糊名T)
        Me.grp糊.Controls.Add(Me.txt社内用糊CDT)
        Me.grp糊.Controls.Add(Me.nam社内用糊名F)
        Me.grp糊.Controls.Add(Me.txt社内用糊CDF)
        Me.grp糊.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp糊.Location = New System.Drawing.Point(34, 165)
        Me.grp糊.Name = "grp糊"
        Me.grp糊.Size = New System.Drawing.Size(340, 110)
        Me.grp糊.TabIndex = 1
        Me.grp糊.TabStop = False
        Me.grp糊.Text = "糊ｺｰﾄﾞ"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(24, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "[まで]"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(24, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "[から]"
        '
        'nam社内用糊名T
        '
        Me.nam社内用糊名T.BackColor = System.Drawing.SystemColors.Control
        Me.nam社内用糊名T.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam社内用糊名T.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam社内用糊名T.Location = New System.Drawing.Point(116, 63)
        Me.nam社内用糊名T.Margin = New System.Windows.Forms.Padding(3)
        Me.nam社内用糊名T.Name = "nam社内用糊名T"
        Me.nam社内用糊名T.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.nam社内用糊名T.Size = New System.Drawing.Size(188, 23)
        Me.nam社内用糊名T.TabIndex = 11
        Me.nam社内用糊名T.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt社内用糊CDT
        '
        Me.txt社内用糊CDT.FieldLockType = BaseContents.Field.LockType.None
        Me.txt社内用糊CDT.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt社内用糊CDT.HelpKeys = ""
        Me.txt社内用糊CDT.HelpLink = ""
        Me.txt社内用糊CDT.HelpType = NodeUI.Help.Type.None
        Me.txt社内用糊CDT.IsError = False
        Me.txt社内用糊CDT.Location = New System.Drawing.Point(82, 63)
        Me.txt社内用糊CDT.Name = "txt社内用糊CDT"
        Me.txt社内用糊CDT.Required = False
        Me.txt社内用糊CDT.Size = New System.Drawing.Size(34, 23)
        Me.txt社内用糊CDT.TabIndex = 10
        Me.txt社内用糊CDT.Text = "999"
        Me.txt社内用糊CDT.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam社内用糊名F
        '
        Me.nam社内用糊名F.BackColor = System.Drawing.SystemColors.Control
        Me.nam社内用糊名F.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam社内用糊名F.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam社内用糊名F.Location = New System.Drawing.Point(116, 32)
        Me.nam社内用糊名F.Margin = New System.Windows.Forms.Padding(3)
        Me.nam社内用糊名F.Name = "nam社内用糊名F"
        Me.nam社内用糊名F.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.nam社内用糊名F.Size = New System.Drawing.Size(188, 23)
        Me.nam社内用糊名F.TabIndex = 9
        Me.nam社内用糊名F.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt社内用糊CDF
        '
        Me.txt社内用糊CDF.FieldLockType = BaseContents.Field.LockType.None
        Me.txt社内用糊CDF.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt社内用糊CDF.HelpKeys = ""
        Me.txt社内用糊CDF.HelpLink = ""
        Me.txt社内用糊CDF.HelpType = NodeUI.Help.Type.None
        Me.txt社内用糊CDF.IsError = False
        Me.txt社内用糊CDF.Location = New System.Drawing.Point(82, 32)
        Me.txt社内用糊CDF.Name = "txt社内用糊CDF"
        Me.txt社内用糊CDF.Required = False
        Me.txt社内用糊CDF.Size = New System.Drawing.Size(34, 23)
        Me.txt社内用糊CDF.TabIndex = 0
        Me.txt社内用糊CDF.Text = "999"
        Me.txt社内用糊CDF.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp紙
        '
        Me.grp紙.Controls.Add(Me.Label3)
        Me.grp紙.Controls.Add(Me.Label4)
        Me.grp紙.Controls.Add(Me.nam社内用紙名T)
        Me.grp紙.Controls.Add(Me.txt社内用紙CDT)
        Me.grp紙.Controls.Add(Me.nam社内用紙名F)
        Me.grp紙.Controls.Add(Me.txt社内用紙CDF)
        Me.grp紙.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp紙.Location = New System.Drawing.Point(34, 49)
        Me.grp紙.Name = "grp紙"
        Me.grp紙.Size = New System.Drawing.Size(399, 110)
        Me.grp紙.TabIndex = 0
        Me.grp紙.TabStop = False
        Me.grp紙.Text = "紙ｺｰﾄﾞ"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.Label3.Location = New System.Drawing.Point(24, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 16)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "[まで]"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.Label4.Location = New System.Drawing.Point(24, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 16)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "[から]"
        '
        'nam社内用紙名T
        '
        Me.nam社内用紙名T.BackColor = System.Drawing.SystemColors.Control
        Me.nam社内用紙名T.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam社内用紙名T.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam社内用紙名T.Location = New System.Drawing.Point(124, 64)
        Me.nam社内用紙名T.Margin = New System.Windows.Forms.Padding(3)
        Me.nam社内用紙名T.Name = "nam社内用紙名T"
        Me.nam社内用紙名T.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.nam社内用紙名T.Size = New System.Drawing.Size(220, 23)
        Me.nam社内用紙名T.TabIndex = 11
        Me.nam社内用紙名T.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt社内用紙CDT
        '
        Me.txt社内用紙CDT.FieldLockType = BaseContents.Field.LockType.None
        Me.txt社内用紙CDT.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt社内用紙CDT.HelpKeys = ""
        Me.txt社内用紙CDT.HelpLink = ""
        Me.txt社内用紙CDT.HelpType = NodeUI.Help.Type.None
        Me.txt社内用紙CDT.IsError = False
        Me.txt社内用紙CDT.Location = New System.Drawing.Point(82, 64)
        Me.txt社内用紙CDT.Name = "txt社内用紙CDT"
        Me.txt社内用紙CDT.Required = False
        Me.txt社内用紙CDT.Size = New System.Drawing.Size(42, 23)
        Me.txt社内用紙CDT.TabIndex = 10
        Me.txt社内用紙CDT.Text = "9999"
        Me.txt社内用紙CDT.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam社内用紙名F
        '
        Me.nam社内用紙名F.BackColor = System.Drawing.SystemColors.Control
        Me.nam社内用紙名F.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam社内用紙名F.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam社内用紙名F.Location = New System.Drawing.Point(124, 33)
        Me.nam社内用紙名F.Margin = New System.Windows.Forms.Padding(3)
        Me.nam社内用紙名F.Name = "nam社内用紙名F"
        Me.nam社内用紙名F.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.nam社内用紙名F.Size = New System.Drawing.Size(220, 23)
        Me.nam社内用紙名F.TabIndex = 9
        Me.nam社内用紙名F.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt社内用紙CDF
        '
        Me.txt社内用紙CDF.FieldLockType = BaseContents.Field.LockType.None
        Me.txt社内用紙CDF.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt社内用紙CDF.HelpKeys = ""
        Me.txt社内用紙CDF.HelpLink = ""
        Me.txt社内用紙CDF.HelpType = NodeUI.Help.Type.None
        Me.txt社内用紙CDF.IsError = False
        Me.txt社内用紙CDF.Location = New System.Drawing.Point(82, 33)
        Me.txt社内用紙CDF.Name = "txt社内用紙CDF"
        Me.txt社内用紙CDF.Required = False
        Me.txt社内用紙CDF.Size = New System.Drawing.Size(42, 23)
        Me.txt社内用紙CDF.TabIndex = 0
        Me.txt社内用紙CDF.Text = "9999"
        Me.txt社内用紙CDF.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp単価区分
        '
        Me.grp単価区分.Controls.Add(Me.opt両方)
        Me.grp単価区分.Controls.Add(Me.optm単価)
        Me.grp単価区分.Controls.Add(Me.opt平米単価)
        Me.grp単価区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp単価区分.Location = New System.Drawing.Point(597, 395)
        Me.grp単価区分.Name = "grp単価区分"
        Me.grp単価区分.Size = New System.Drawing.Size(316, 61)
        Me.grp単価区分.TabIndex = 2
        Me.grp単価区分.TabStop = False
        Me.grp単価区分.Text = "単価区分"
        '
        'opt両方
        '
        Me.opt両方.AutoSize = True
        Me.opt両方.FieldLockType = BaseContents.Field.LockType.None
        Me.opt両方.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.opt両方.IsError = False
        Me.opt両方.Location = New System.Drawing.Point(197, 27)
        Me.opt両方.Name = "opt両方"
        Me.opt両方.Required = False
        Me.opt両方.Size = New System.Drawing.Size(58, 20)
        Me.opt両方.TabIndex = 2
        Me.opt両方.Text = "両方"
        Me.opt両方.UseVisualStyleBackColor = True
        '
        'optm単価
        '
        Me.optm単価.AutoSize = True
        Me.optm単価.FieldLockType = BaseContents.Field.LockType.None
        Me.optm単価.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.optm単価.IsError = False
        Me.optm単価.Location = New System.Drawing.Point(108, 27)
        Me.optm単価.Name = "optm単価"
        Me.optm単価.Required = False
        Me.optm単価.Size = New System.Drawing.Size(66, 20)
        Me.optm単価.TabIndex = 1
        Me.optm単価.Text = "m単価"
        Me.optm単価.UseVisualStyleBackColor = True
        '
        'opt平米単価
        '
        Me.opt平米単価.AutoSize = True
        Me.opt平米単価.FieldLockType = BaseContents.Field.LockType.None
        Me.opt平米単価.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.opt平米単価.IsError = False
        Me.opt平米単価.Location = New System.Drawing.Point(19, 27)
        Me.opt平米単価.Name = "opt平米単価"
        Me.opt平米単価.Required = False
        Me.opt平米単価.Size = New System.Drawing.Size(74, 20)
        Me.opt平米単価.TabIndex = 0
        Me.opt平米単価.Text = "㎡単価"
        Me.opt平米単価.UseVisualStyleBackColor = True
        '
        'grp単価種別
        '
        Me.grp単価種別.Controls.Add(Me.opt社内単価)
        Me.grp単価種別.Controls.Add(Me.opt発注単価)
        Me.grp単価種別.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp単価種別.Location = New System.Drawing.Point(597, 462)
        Me.grp単価種別.Name = "grp単価種別"
        Me.grp単価種別.Size = New System.Drawing.Size(219, 61)
        Me.grp単価種別.TabIndex = 3
        Me.grp単価種別.TabStop = False
        Me.grp単価種別.Text = "単価種別"
        '
        'opt社内単価
        '
        Me.opt社内単価.AutoSize = True
        Me.opt社内単価.FieldLockType = BaseContents.Field.LockType.None
        Me.opt社内単価.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.opt社内単価.IsError = False
        Me.opt社内単価.Location = New System.Drawing.Point(108, 27)
        Me.opt社内単価.Name = "opt社内単価"
        Me.opt社内単価.Required = False
        Me.opt社内単価.Size = New System.Drawing.Size(90, 20)
        Me.opt社内単価.TabIndex = 1
        Me.opt社内単価.Text = "社内単価"
        Me.opt社内単価.UseVisualStyleBackColor = True
        '
        'opt発注単価
        '
        Me.opt発注単価.AutoSize = True
        Me.opt発注単価.FieldLockType = BaseContents.Field.LockType.None
        Me.opt発注単価.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.opt発注単価.IsError = False
        Me.opt発注単価.Location = New System.Drawing.Point(19, 27)
        Me.opt発注単価.Name = "opt発注単価"
        Me.opt発注単価.Required = False
        Me.opt発注単価.Size = New System.Drawing.Size(90, 20)
        Me.opt発注単価.TabIndex = 0
        Me.opt発注単価.Text = "発注単価"
        Me.opt発注単価.UseVisualStyleBackColor = True
        '
        'grpソート区分
        '
        Me.grpソート区分.Controls.Add(Me.opt紙糊台紙CD順)
        Me.grpソート区分.Controls.Add(Me.opt仕入先CD順)
        Me.grpソート区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grpソート区分.Location = New System.Drawing.Point(597, 536)
        Me.grpソート区分.Name = "grpソート区分"
        Me.grpソート区分.Size = New System.Drawing.Size(320, 61)
        Me.grpソート区分.TabIndex = 4
        Me.grpソート区分.TabStop = False
        Me.grpソート区分.Text = "ソート区分"
        '
        'opt紙糊台紙CD順
        '
        Me.opt紙糊台紙CD順.AutoSize = True
        Me.opt紙糊台紙CD順.FieldLockType = BaseContents.Field.LockType.None
        Me.opt紙糊台紙CD順.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.opt紙糊台紙CD順.IsError = False
        Me.opt紙糊台紙CD順.Location = New System.Drawing.Point(145, 27)
        Me.opt紙糊台紙CD順.Name = "opt紙糊台紙CD順"
        Me.opt紙糊台紙CD順.Required = False
        Me.opt紙糊台紙CD順.Size = New System.Drawing.Size(170, 20)
        Me.opt紙糊台紙CD順.TabIndex = 1
        Me.opt紙糊台紙CD順.Text = "紙・糊・台紙ｺｰﾄﾞ順"
        Me.opt紙糊台紙CD順.UseVisualStyleBackColor = True
        '
        'opt仕入先CD順
        '
        Me.opt仕入先CD順.AutoSize = True
        Me.opt仕入先CD順.FieldLockType = BaseContents.Field.LockType.None
        Me.opt仕入先CD順.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.opt仕入先CD順.IsError = False
        Me.opt仕入先CD順.Location = New System.Drawing.Point(19, 27)
        Me.opt仕入先CD順.Name = "opt仕入先CD順"
        Me.opt仕入先CD順.Required = False
        Me.opt仕入先CD順.Size = New System.Drawing.Size(122, 20)
        Me.opt仕入先CD順.TabIndex = 0
        Me.opt仕入先CD順.Text = "仕入先ｺｰﾄﾞ順"
        Me.opt仕入先CD順.UseVisualStyleBackColor = True
        '
        'frmPaperPriList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.grpソート区分)
        Me.Controls.Add(Me.grp単価種別)
        Me.Controls.Add(Me.grp単価区分)
        Me.Controls.Add(Me.grp社内用)
        Me.Controls.Add(Me.grp仕入先)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmPaperPriList"
        Me.Text = ""
        Me.Controls.SetChildIndex(Me.grp仕入先, 0)
        Me.Controls.SetChildIndex(Me.grp社内用, 0)
        Me.Controls.SetChildIndex(Me.grp単価区分, 0)
        Me.Controls.SetChildIndex(Me.grp単価種別, 0)
        Me.Controls.SetChildIndex(Me.grpソート区分, 0)
        Me.grp仕入先.ResumeLayout(False)
        Me.grp仕入先.PerformLayout()
        Me.grp社内用.ResumeLayout(False)
        Me.grp台紙.ResumeLayout(False)
        Me.grp台紙.PerformLayout()
        Me.grp糊.ResumeLayout(False)
        Me.grp糊.PerformLayout()
        Me.grp紙.ResumeLayout(False)
        Me.grp紙.PerformLayout()
        Me.grp単価区分.ResumeLayout(False)
        Me.grp単価区分.PerformLayout()
        Me.grp単価種別.ResumeLayout(False)
        Me.grp単価種別.PerformLayout()
        Me.grpソート区分.ResumeLayout(False)
        Me.grpソート区分.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp仕入先 As BaseUI.Control.GroupBox
    Friend WithEvents txt仕入先CDF As BaseUI.Control.TextBox
    Friend WithEvents nam仕入先名F As BaseUI.Control.NameBox
    Friend WithEvents nam仕入先名T As BaseUI.Control.NameBox
    Friend WithEvents txt仕入先CDT As BaseUI.Control.TextBox
    Friend WithEvents lblから As BaseUI.Control.Label
    Friend WithEvents lblまで As BaseUI.Control.Label
    Friend WithEvents grp社内用 As BaseUI.Control.GroupBox
    Friend WithEvents grp台紙 As BaseUI.Control.GroupBox
    Friend WithEvents Label5 As BaseUI.Control.Label
    Friend WithEvents Label6 As BaseUI.Control.Label
    Friend WithEvents nam社内用台紙名T As BaseUI.Control.NameBox
    Friend WithEvents txt社内用台紙CDT As BaseUI.Control.TextBox
    Friend WithEvents nam社内用台紙名F As BaseUI.Control.NameBox
    Friend WithEvents txt社内用台紙CDF As BaseUI.Control.TextBox
    Friend WithEvents grp糊 As BaseUI.Control.GroupBox
    Friend WithEvents Label1 As BaseUI.Control.Label
    Friend WithEvents Label2 As BaseUI.Control.Label
    Friend WithEvents nam社内用糊名T As BaseUI.Control.NameBox
    Friend WithEvents txt社内用糊CDT As BaseUI.Control.TextBox
    Friend WithEvents nam社内用糊名F As BaseUI.Control.NameBox
    Friend WithEvents txt社内用糊CDF As BaseUI.Control.TextBox
    Friend WithEvents grp紙 As BaseUI.Control.GroupBox
    Friend WithEvents Label3 As BaseUI.Control.Label
    Friend WithEvents Label4 As BaseUI.Control.Label
    Friend WithEvents nam社内用紙名T As BaseUI.Control.NameBox
    Friend WithEvents txt社内用紙CDT As BaseUI.Control.TextBox
    Friend WithEvents nam社内用紙名F As BaseUI.Control.NameBox
    Friend WithEvents txt社内用紙CDF As BaseUI.Control.TextBox
    Friend WithEvents grp単価区分 As BaseUI.Control.GroupBox
    Friend WithEvents opt両方 As BaseUI.Control.RadioButton
    Friend WithEvents optm単価 As BaseUI.Control.RadioButton
    Friend WithEvents opt平米単価 As BaseUI.Control.RadioButton
    Friend WithEvents grp単価種別 As BaseUI.Control.GroupBox
    Friend WithEvents opt社内単価 As BaseUI.Control.RadioButton
    Friend WithEvents opt発注単価 As BaseUI.Control.RadioButton
    Friend WithEvents grpソート区分 As BaseUI.Control.GroupBox
    Friend WithEvents opt紙糊台紙CD順 As BaseUI.Control.RadioButton
    Friend WithEvents opt仕入先CD順 As BaseUI.Control.RadioButton
End Class
