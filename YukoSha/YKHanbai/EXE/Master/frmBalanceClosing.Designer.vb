<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBalanceClosing
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
        Me.grp内訳 = New BaseUI.Control.GroupBox()
        Me.grp締切残高 = New BaseUI.Control.GroupBox()
        Me.txt締切残高 = New BaseUI.Control.TextBox()
        Me.grp締切日付 = New BaseUI.Control.GroupBox()
        Me.txt締切日付 = New BaseUI.Control.TextBox()
        Me.grdDetall = New BaseUI.Control.GridInput()
        Me.grp得意先 = New BaseUI.Control.GroupBox()
        Me.lbl締日 = New BaseUI.Control.Label()
        Me.txt得意先CD = New BaseUI.Control.TextBox()
        Me.nam締日 = New BaseUI.Control.NameBox()
        Me.nam得意先名 = New BaseUI.Control.NameBox()
        Me.grp内訳.SuspendLayout()
        Me.grp締切残高.SuspendLayout()
        Me.grp締切日付.SuspendLayout()
        CType(Me.grdDetall, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp得意先.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnESC
        '
        Me.btnESC.Text = "閉じる"
        '
        'grp内訳
        '
        Me.grp内訳.Controls.Add(Me.grp締切残高)
        Me.grp内訳.Controls.Add(Me.grp締切日付)
        Me.grp内訳.Controls.Add(Me.grdDetall)
        Me.grp内訳.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp内訳.Location = New System.Drawing.Point(28, 91)
        Me.grp内訳.Name = "grp内訳"
        Me.grp内訳.Size = New System.Drawing.Size(506, 545)
        Me.grp内訳.TabIndex = 10
        Me.grp内訳.TabStop = False
        Me.grp内訳.Text = "内訳"
        '
        'grp締切残高
        '
        Me.grp締切残高.Controls.Add(Me.txt締切残高)
        Me.grp締切残高.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp締切残高.Location = New System.Drawing.Point(225, 472)
        Me.grp締切残高.Name = "grp締切残高"
        Me.grp締切残高.Size = New System.Drawing.Size(193, 61)
        Me.grp締切残高.TabIndex = 1
        Me.grp締切残高.TabStop = False
        Me.grp締切残高.Text = "確定済請求残高"
        '
        'txt締切残高
        '
        Me.txt締切残高.FieldLockType = BaseContents.Field.LockType.None
        Me.txt締切残高.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt締切残高.HelpKeys = ""
        Me.txt締切残高.HelpLink = ""
        Me.txt締切残高.HelpType = NodeUI.Help.Type.None
        Me.txt締切残高.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt締切残高.IsError = False
        Me.txt締切残高.Location = New System.Drawing.Point(27, 25)
        Me.txt締切残高.Name = "txt締切残高"
        Me.txt締切残高.Required = False
        Me.txt締切残高.Size = New System.Drawing.Size(127, 23)
        Me.txt締切残高.StringLength = 65535
        Me.txt締切残高.TabIndex = 0
        Me.txt締切残高.Text = "12,345,678,901"
        Me.txt締切残高.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grp締切日付
        '
        Me.grp締切日付.Controls.Add(Me.txt締切日付)
        Me.grp締切日付.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp締切日付.Location = New System.Drawing.Point(16, 472)
        Me.grp締切日付.Name = "grp締切日付"
        Me.grp締切日付.Size = New System.Drawing.Size(195, 61)
        Me.grp締切日付.TabIndex = 0
        Me.grp締切日付.TabStop = False
        Me.grp締切日付.Text = "確定済締切対象年月日"
        '
        'txt締切日付
        '
        Me.txt締切日付.FieldLockType = BaseContents.Field.LockType.None
        Me.txt締切日付.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt締切日付.HelpKeys = ""
        Me.txt締切日付.HelpLink = ""
        Me.txt締切日付.HelpType = NodeUI.Help.Type.None
        Me.txt締切日付.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt締切日付.IsError = False
        Me.txt締切日付.Location = New System.Drawing.Point(48, 25)
        Me.txt締切日付.Name = "txt締切日付"
        Me.txt締切日付.Required = False
        Me.txt締切日付.Size = New System.Drawing.Size(91, 23)
        Me.txt締切日付.StringLength = 65535
        Me.txt締切日付.TabIndex = 0
        Me.txt締切日付.Text = "YYYY/MM/DD"
        Me.txt締切日付.TextStyle = BaseContents.TextBox.TextStyle.None
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
        Me.grdDetall.Location = New System.Drawing.Point(16, 22)
        Me.grdDetall.MultiSelect = False
        Me.grdDetall.Name = "grdDetall"
        Me.grdDetall.Required = False
        Me.grdDetall.RowHeadersVisible = False
        Me.grdDetall.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdDetall.Size = New System.Drawing.Size(432, 444)
        Me.grdDetall.TabIndex = 2
        Me.grdDetall.TextBoxAddBtm = Nothing
        Me.grdDetall.TextBoxAddTop = Nothing
        '
        'grp得意先
        '
        Me.grp得意先.Controls.Add(Me.lbl締日)
        Me.grp得意先.Controls.Add(Me.txt得意先CD)
        Me.grp得意先.Controls.Add(Me.nam締日)
        Me.grp得意先.Controls.Add(Me.nam得意先名)
        Me.grp得意先.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp得意先.Location = New System.Drawing.Point(26, 5)
        Me.grp得意先.Name = "grp得意先"
        Me.grp得意先.Size = New System.Drawing.Size(508, 80)
        Me.grp得意先.TabIndex = 9
        Me.grp得意先.TabStop = False
        Me.grp得意先.Text = "得意先"
        '
        'lbl締日
        '
        Me.lbl締日.AutoSize = True
        Me.lbl締日.Enabled = False
        Me.lbl締日.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.0!)
        Me.lbl締日.Location = New System.Drawing.Point(363, 29)
        Me.lbl締日.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl締日.Name = "lbl締日"
        Me.lbl締日.Size = New System.Drawing.Size(39, 15)
        Me.lbl締日.TabIndex = 2
        Me.lbl締日.Text = "締日"
        '
        'txt得意先CD
        '
        Me.txt得意先CD.FieldLockType = BaseContents.Field.LockType.None
        Me.txt得意先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt得意先CD.HelpKeys = ""
        Me.txt得意先CD.HelpLink = ""
        Me.txt得意先CD.HelpType = NodeUI.Help.Type.None
        Me.txt得意先CD.IsError = False
        Me.txt得意先CD.Location = New System.Drawing.Point(23, 25)
        Me.txt得意先CD.Name = "txt得意先CD"
        Me.txt得意先CD.Required = False
        Me.txt得意先CD.Size = New System.Drawing.Size(61, 23)
        Me.txt得意先CD.StringLength = 65535
        Me.txt得意先CD.TabIndex = 0
        Me.txt得意先CD.Text = "123456"
        Me.txt得意先CD.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam締日
        '
        Me.nam締日.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam締日.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam締日.Location = New System.Drawing.Point(405, 25)
        Me.nam締日.Name = "nam締日"
        Me.nam締日.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam締日.Size = New System.Drawing.Size(61, 23)
        Me.nam締日.StringLength = 65535
        Me.nam締日.TabIndex = 3
        Me.nam締日.Text = "99日締"
        Me.nam締日.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam締日.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam得意先名
        '
        Me.nam得意先名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam得意先名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam得意先名.Location = New System.Drawing.Point(86, 25)
        Me.nam得意先名.Name = "nam得意先名"
        Me.nam得意先名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam得意先名.Size = New System.Drawing.Size(270, 23)
        Me.nam得意先名.StringLength = 65535
        Me.nam得意先名.TabIndex = 1
        Me.nam得意先名.Text = "*XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX*"
        Me.nam得意先名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'frmBalanceClosing
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.grp内訳)
        Me.Controls.Add(Me.grp得意先)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmBalanceClosing"
        Me.Controls.SetChildIndex(Me.grp得意先, 0)
        Me.Controls.SetChildIndex(Me.grp内訳, 0)
        Me.grp内訳.ResumeLayout(False)
        Me.grp締切残高.ResumeLayout(False)
        Me.grp締切残高.PerformLayout()
        Me.grp締切日付.ResumeLayout(False)
        Me.grp締切日付.PerformLayout()
        CType(Me.grdDetall, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp得意先.ResumeLayout(False)
        Me.grp得意先.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp内訳 As BaseUI.Control.GroupBox
    Friend WithEvents grp締切残高 As BaseUI.Control.GroupBox
    Friend WithEvents txt締切残高 As BaseUI.Control.TextBox
    Friend WithEvents grp締切日付 As BaseUI.Control.GroupBox
    Friend WithEvents txt締切日付 As BaseUI.Control.TextBox
    Friend WithEvents grdDetall As BaseUI.Control.GridInput
    Friend WithEvents grp得意先 As BaseUI.Control.GroupBox
    Friend WithEvents lbl締日 As BaseUI.Control.Label
    Friend WithEvents txt得意先CD As BaseUI.Control.TextBox
    Friend WithEvents nam締日 As BaseUI.Control.NameBox
    Friend WithEvents nam得意先名 As BaseUI.Control.NameBox

End Class
