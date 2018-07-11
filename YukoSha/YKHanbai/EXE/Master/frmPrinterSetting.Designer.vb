<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrinterSetting
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
        Me.grp帳票区分 = New BaseUI.Control.GroupBox()
        Me.ddl帳票区分 = New BaseUI.Control.ComboBox()
        Me.txtプリンタ名 = New BaseUI.Control.TextBox()
        Me.grpプリンタ名 = New BaseUI.Control.GroupBox()
        Me.txtコンピュータ名 = New BaseUI.Control.TextBox()
        Me.grpコンピュータ名 = New BaseUI.Control.GroupBox()
        Me.GridInput1 = New BaseUI.Control.GridInput()
        Me.grp帳票区分.SuspendLayout()
        Me.grpプリンタ名.SuspendLayout()
        Me.grpコンピュータ名.SuspendLayout()
        CType(Me.GridInput1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnESC
        '
        Me.btnESC.Text = "閉じる"
        '
        'grp帳票区分
        '
        Me.grp帳票区分.Controls.Add(Me.ddl帳票区分)
        Me.grp帳票区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp帳票区分.Location = New System.Drawing.Point(29, 25)
        Me.grp帳票区分.Name = "grp帳票区分"
        Me.grp帳票区分.Size = New System.Drawing.Size(250, 61)
        Me.grp帳票区分.TabIndex = 21
        Me.grp帳票区分.TabStop = False
        Me.grp帳票区分.Text = "帳票区分"
        '
        'ddl帳票区分
        '
        Me.ddl帳票区分.AutoDropDown = True
        Me.ddl帳票区分.DisplayMember = "Display"
        Me.ddl帳票区分.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ddl帳票区分.FieldLockType = BaseContents.Field.LockType.None
        Me.ddl帳票区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.ddl帳票区分.FormattingEnabled = True
        Me.ddl帳票区分.IsError = False
        Me.ddl帳票区分.ListType = NodeUI.List.Type.None
        Me.ddl帳票区分.Location = New System.Drawing.Point(19, 23)
        Me.ddl帳票区分.Name = "ddl帳票区分"
        Me.ddl帳票区分.Required = False
        Me.ddl帳票区分.Size = New System.Drawing.Size(220, 24)
        Me.ddl帳票区分.TabIndex = 0
        Me.ddl帳票区分.ValueMember = "Value"
        '
        'txtプリンタ名
        '
        Me.txtプリンタ名.FieldLockType = BaseContents.Field.LockType.None
        Me.txtプリンタ名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txtプリンタ名.HelpKeys = ""
        Me.txtプリンタ名.HelpLink = ""
        Me.txtプリンタ名.HelpType = NodeUI.Help.Type.None
        Me.txtプリンタ名.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtプリンタ名.IsError = False
        Me.txtプリンタ名.Location = New System.Drawing.Point(19, 25)
        Me.txtプリンタ名.Name = "txtプリンタ名"
        Me.txtプリンタ名.Required = False
        Me.txtプリンタ名.Size = New System.Drawing.Size(264, 23)
        Me.txtプリンタ名.TabIndex = 0
        Me.txtプリンタ名.Text = "ああああああああああいいいいいい"
        Me.txtプリンタ名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grpプリンタ名
        '
        Me.grpプリンタ名.Controls.Add(Me.txtプリンタ名)
        Me.grpプリンタ名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grpプリンタ名.Location = New System.Drawing.Point(347, 565)
        Me.grpプリンタ名.Name = "grpプリンタ名"
        Me.grpプリンタ名.Size = New System.Drawing.Size(312, 61)
        Me.grpプリンタ名.TabIndex = 11
        Me.grpプリンタ名.TabStop = False
        Me.grpプリンタ名.Text = "ﾌﾟﾘﾝﾀ名"
        '
        'txtコンピュータ名
        '
        Me.txtコンピュータ名.FieldLockType = BaseContents.Field.LockType.None
        Me.txtコンピュータ名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txtコンピュータ名.HelpKeys = ""
        Me.txtコンピュータ名.HelpLink = ""
        Me.txtコンピュータ名.HelpType = NodeUI.Help.Type.None
        Me.txtコンピュータ名.ImeMode = System.Windows.Forms.ImeMode.Hiragana
        Me.txtコンピュータ名.IsError = False
        Me.txtコンピュータ名.Location = New System.Drawing.Point(19, 25)
        Me.txtコンピュータ名.Name = "txtコンピュータ名"
        Me.txtコンピュータ名.Required = False
        Me.txtコンピュータ名.Size = New System.Drawing.Size(264, 23)
        Me.txtコンピュータ名.TabIndex = 0
        Me.txtコンピュータ名.Text = "ああああああああああいいいいいい"
        Me.txtコンピュータ名.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'grpコンピュータ名
        '
        Me.grpコンピュータ名.Controls.Add(Me.txtコンピュータ名)
        Me.grpコンピュータ名.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grpコンピュータ名.Location = New System.Drawing.Point(29, 565)
        Me.grpコンピュータ名.Name = "grpコンピュータ名"
        Me.grpコンピュータ名.Size = New System.Drawing.Size(312, 61)
        Me.grpコンピュータ名.TabIndex = 10
        Me.grpコンピュータ名.TabStop = False
        Me.grpコンピュータ名.Text = "ｺﾝﾋﾟｭｰﾀ名"
        '
        'GridInput1
        '
        Me.GridInput1.AllowUserToAddRows = False
        Me.GridInput1.AllowUserToResizeRows = False
        Me.GridInput1.ButtonDelete = Nothing
        Me.GridInput1.ButtonInsert = Nothing
        Me.GridInput1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridInput1.FieldLockType = BaseContents.Field.LockType.None
        Me.GridInput1.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.GridInput1.IsError = False
        Me.GridInput1.Location = New System.Drawing.Point(29, 105)
        Me.GridInput1.MultiSelect = False
        Me.GridInput1.Name = "GridInput1"
        Me.GridInput1.Required = False
        Me.GridInput1.RowHeadersWidth = 10
        Me.GridInput1.RowTemplate.Height = 21
        Me.GridInput1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GridInput1.Size = New System.Drawing.Size(630, 440)
        Me.GridInput1.TabIndex = 22
        Me.GridInput1.TextBoxAddBtm = Nothing
        Me.GridInput1.TextBoxAddTop = Nothing
        '
        'frmPrinterSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.GridInput1)
        Me.Controls.Add(Me.grp帳票区分)
        Me.Controls.Add(Me.grpプリンタ名)
        Me.Controls.Add(Me.grpコンピュータ名)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmPrinterSetting"
        Me.Text = ""
        Me.Controls.SetChildIndex(Me.grpコンピュータ名, 0)
        Me.Controls.SetChildIndex(Me.grpプリンタ名, 0)
        Me.Controls.SetChildIndex(Me.grp帳票区分, 0)
        Me.Controls.SetChildIndex(Me.GridInput1, 0)
        Me.grp帳票区分.ResumeLayout(False)
        Me.grpプリンタ名.ResumeLayout(False)
        Me.grpプリンタ名.PerformLayout()
        Me.grpコンピュータ名.ResumeLayout(False)
        Me.grpコンピュータ名.PerformLayout()
        CType(Me.GridInput1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp帳票区分 As BaseUI.Control.GroupBox
    Friend WithEvents ddl帳票区分 As BaseUI.Control.ComboBox
    Friend WithEvents txtプリンタ名 As BaseUI.Control.TextBox
    Friend WithEvents grpプリンタ名 As BaseUI.Control.GroupBox
    Friend WithEvents txtコンピュータ名 As BaseUI.Control.TextBox
    Friend WithEvents grpコンピュータ名 As BaseUI.Control.GroupBox
    Friend WithEvents GridInput1 As BaseUI.Control.GridInput
End Class
