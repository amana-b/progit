<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClosingDateBalance
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
        Me.grp得意先CD = New BaseUI.Control.GroupBox()
        Me.Label12 = New BaseUI.Control.Label()
        Me.txt得意先CD = New BaseUI.Control.TextBox()
        Me.nam表示用締日 = New BaseUI.Control.NameBox()
        Me.nam得意先名 = New BaseUI.Control.NameBox()
        Me.GridInput1 = New BaseUI.Control.GridInput()
        Me.grp内訳 = New BaseUI.Control.GroupBox()
        Me.grp確定済請求残高 = New BaseUI.Control.GroupBox()
        Me.txt確定済請求残高 = New BaseUI.Control.TextBox()
        Me.grp確定済締切対象年月日 = New BaseUI.Control.GroupBox()
        Me.txt確定済締切対象年月日 = New BaseUI.Control.TextBox()
        Me.grp得意先CD.SuspendLayout()
        CType(Me.GridInput1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp内訳.SuspendLayout()
        Me.grp確定済請求残高.SuspendLayout()
        Me.grp確定済締切対象年月日.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnESC
        '
        Me.btnESC.Text = "閉じる"
        '
        'grp得意先CD
        '
        Me.grp得意先CD.Controls.Add(Me.Label12)
        Me.grp得意先CD.Controls.Add(Me.txt得意先CD)
        Me.grp得意先CD.Controls.Add(Me.nam表示用締日)
        Me.grp得意先CD.Controls.Add(Me.nam得意先名)
        Me.grp得意先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp得意先CD.Location = New System.Drawing.Point(18, 21)
        Me.grp得意先CD.Name = "grp得意先CD"
        Me.grp得意先CD.Size = New System.Drawing.Size(508, 73)
        Me.grp得意先CD.TabIndex = 0
        Me.grp得意先CD.TabStop = False
        Me.grp得意先CD.Text = "得意先CD"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Enabled = False
        Me.Label12.Font = New System.Drawing.Font("ＭＳ ゴシック", 11.0!)
        Me.Label12.Location = New System.Drawing.Point(363, 29)
        Me.Label12.Margin = New System.Windows.Forms.Padding(0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(39, 15)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "締日"
        '
        'txt得意先CD
        '
        Me.txt得意先CD.FieldKeyType = BaseContents.Field.KeyType.Key
        Me.txt得意先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt得意先CD.HelpKeys = ""
        Me.txt得意先CD.HelpLink = ""
        Me.txt得意先CD.HelpType = NodeUI.Help.Type.None
        Me.txt得意先CD.IsError = False
        Me.txt得意先CD.Location = New System.Drawing.Point(23, 25)
        Me.txt得意先CD.Name = "txt得意先CD"
        Me.txt得意先CD.Required = False
        Me.txt得意先CD.Size = New System.Drawing.Size(61, 23)
        Me.txt得意先CD.StringLength = 6
        Me.txt得意先CD.TabIndex = 0
        Me.txt得意先CD.Text = "123456"
        Me.txt得意先CD.TextStyle = BaseContents.TextBox.TextStyle.Code
        '
        'nam表示用締日
        '
        Me.nam表示用締日.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam表示用締日.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam表示用締日.Location = New System.Drawing.Point(405, 25)
        Me.nam表示用締日.Name = "nam表示用締日"
        Me.nam表示用締日.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam表示用締日.Size = New System.Drawing.Size(61, 23)
        Me.nam表示用締日.TabIndex = 3
        Me.nam表示用締日.Text = "99日締"
        Me.nam表示用締日.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'nam得意先名
        '
        Me.nam得意先名.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam得意先名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam得意先名.Location = New System.Drawing.Point(86, 25)
        Me.nam得意先名.Name = "nam得意先名"
        Me.nam得意先名.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam得意先名.Size = New System.Drawing.Size(270, 23)
        Me.nam得意先名.TabIndex = 1
        Me.nam得意先名.Text = "*XXXXXXXXXXXXXXXXXXXXXXXXXXXXXX*"
        '
        'GridInput1
        '
        Me.GridInput1.AllowUserToAddRows = False
        Me.GridInput1.ButtonDelete = Nothing
        Me.GridInput1.ButtonInsert = Nothing
        Me.GridInput1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridInput1.FieldKeyType = BaseContents.Field.KeyType.None
        Me.GridInput1.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.GridInput1.IsError = False
        Me.GridInput1.Location = New System.Drawing.Point(16, 22)
        Me.GridInput1.MultiSelect = False
        Me.GridInput1.Name = "GridInput1"
        Me.GridInput1.Required = False
        Me.GridInput1.RowHeadersWidth = 10
        Me.GridInput1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridInput1.Size = New System.Drawing.Size(432, 351)
        Me.GridInput1.TabIndex = 2
        Me.GridInput1.TabStop = False
        Me.GridInput1.TextBoxAddBtm = Nothing
        Me.GridInput1.TextBoxAddTop = Nothing
        '
        'grp内訳
        '
        Me.grp内訳.Controls.Add(Me.grp確定済請求残高)
        Me.grp内訳.Controls.Add(Me.grp確定済締切対象年月日)
        Me.grp内訳.Controls.Add(Me.GridInput1)
        Me.grp内訳.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp内訳.Location = New System.Drawing.Point(20, 117)
        Me.grp内訳.Name = "grp内訳"
        Me.grp内訳.Size = New System.Drawing.Size(506, 519)
        Me.grp内訳.TabIndex = 1
        Me.grp内訳.TabStop = False
        Me.grp内訳.Text = "内訳"
        '
        'grp確定済請求残高
        '
        Me.grp確定済請求残高.Controls.Add(Me.txt確定済請求残高)
        Me.grp確定済請求残高.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp確定済請求残高.Location = New System.Drawing.Point(225, 422)
        Me.grp確定済請求残高.Name = "grp確定済請求残高"
        Me.grp確定済請求残高.Size = New System.Drawing.Size(193, 61)
        Me.grp確定済請求残高.TabIndex = 1
        Me.grp確定済請求残高.TabStop = False
        Me.grp確定済請求残高.Text = "確定済請求残高"
        '
        'txt確定済請求残高
        '
        Me.txt確定済請求残高.FieldKeyType = BaseContents.Field.KeyType.Data
        Me.txt確定済請求残高.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt確定済請求残高.HelpKeys = ""
        Me.txt確定済請求残高.HelpLink = ""
        Me.txt確定済請求残高.HelpType = NodeUI.Help.Type.None
        Me.txt確定済請求残高.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt確定済請求残高.IsError = False
        Me.txt確定済請求残高.Location = New System.Drawing.Point(27, 25)
        Me.txt確定済請求残高.Name = "txt確定済請求残高"
        Me.txt確定済請求残高.Required = False
        Me.txt確定済請求残高.Size = New System.Drawing.Size(127, 23)
        Me.txt確定済請求残高.StringLength = 0
        Me.txt確定済請求残高.TabIndex = 0
        Me.txt確定済請求残高.Text = "12,345,678,901"
        Me.txt確定済請求残高.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt確定済請求残高.TextStyle = BaseContents.TextBox.TextStyle.Currency
        '
        'grp確定済締切対象年月日
        '
        Me.grp確定済締切対象年月日.Controls.Add(Me.txt確定済締切対象年月日)
        Me.grp確定済締切対象年月日.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp確定済締切対象年月日.Location = New System.Drawing.Point(16, 422)
        Me.grp確定済締切対象年月日.Name = "grp確定済締切対象年月日"
        Me.grp確定済締切対象年月日.Size = New System.Drawing.Size(195, 61)
        Me.grp確定済締切対象年月日.TabIndex = 0
        Me.grp確定済締切対象年月日.TabStop = False
        Me.grp確定済締切対象年月日.Text = "確定済締切対象年月日"
        '
        'txt確定済締切対象年月日
        '
        Me.txt確定済締切対象年月日.FieldKeyType = BaseContents.Field.KeyType.Data
        Me.txt確定済締切対象年月日.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt確定済締切対象年月日.HelpKeys = ""
        Me.txt確定済締切対象年月日.HelpLink = ""
        Me.txt確定済締切対象年月日.HelpType = NodeUI.Help.Type.None
        Me.txt確定済締切対象年月日.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt確定済締切対象年月日.IsError = False
        Me.txt確定済締切対象年月日.Location = New System.Drawing.Point(48, 25)
        Me.txt確定済締切対象年月日.Name = "txt確定済締切対象年月日"
        Me.txt確定済締切対象年月日.Required = False
        Me.txt確定済締切対象年月日.Size = New System.Drawing.Size(91, 23)
        Me.txt確定済締切対象年月日.StringLength = 0
        Me.txt確定済締切対象年月日.TabIndex = 0
        Me.txt確定済締切対象年月日.Text = "YYYY/MM/DD"
        Me.txt確定済締切対象年月日.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txt確定済締切対象年月日.TextStyle = BaseContents.TextBox.TextStyle.YYYYMMDD
        '
        'frmClosingDateBalance
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.grp内訳)
        Me.Controls.Add(Me.grp得意先CD)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmClosingDateBalance"
        Me.Controls.SetChildIndex(Me.grp得意先CD, 0)
        Me.Controls.SetChildIndex(Me.grp内訳, 0)
        Me.grp得意先CD.ResumeLayout(False)
        Me.grp得意先CD.PerformLayout()
        CType(Me.GridInput1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp内訳.ResumeLayout(False)
        Me.grp確定済請求残高.ResumeLayout(False)
        Me.grp確定済請求残高.PerformLayout()
        Me.grp確定済締切対象年月日.ResumeLayout(False)
        Me.grp確定済締切対象年月日.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp得意先CD As BaseUI.Control.GroupBox
    Friend WithEvents nam得意先名 As BaseUI.Control.NameBox
    Friend WithEvents GridInput1 As BaseUI.Control.GridInput
    Friend WithEvents nam表示用締日 As BaseUI.Control.NameBox
    Friend WithEvents txt得意先CD As BaseUI.Control.TextBox
    Friend WithEvents Label12 As BaseUI.Control.Label
    Friend WithEvents grp内訳 As BaseUI.Control.GroupBox
    Friend WithEvents grp確定済締切対象年月日 As BaseUI.Control.GroupBox
    Friend WithEvents txt確定済締切対象年月日 As BaseUI.Control.TextBox
    Friend WithEvents grp確定済請求残高 As BaseUI.Control.GroupBox
    Friend WithEvents txt確定済請求残高 As BaseUI.Control.TextBox

End Class
