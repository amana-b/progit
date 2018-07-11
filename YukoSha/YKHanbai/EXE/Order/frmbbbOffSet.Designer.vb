<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmbbbOffSet
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
        Me.grp受注情報 = New BaseUI.Control.GroupBox()
        Me.nam受注金額Title = New BaseUI.Control.NameBox()
        Me.nam受注単価Title = New BaseUI.Control.NameBox()
        Me.nam受注金額 = New BaseUI.Control.NameBox()
        Me.nam受注単価 = New BaseUI.Control.NameBox()
        Me.nam受注数 = New BaseUI.Control.NameBox()
        Me.nam受注数Title = New BaseUI.Control.NameBox()
        Me.grp受注情報.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnESC
        '
        Me.btnESC.Text = "閉じる"
        '
        'grp受注情報
        '
        Me.grp受注情報.Controls.Add(Me.nam受注金額Title)
        Me.grp受注情報.Controls.Add(Me.nam受注単価Title)
        Me.grp受注情報.Controls.Add(Me.nam受注金額)
        Me.grp受注情報.Controls.Add(Me.nam受注単価)
        Me.grp受注情報.Controls.Add(Me.nam受注数)
        Me.grp受注情報.Controls.Add(Me.nam受注数Title)
        Me.grp受注情報.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp受注情報.Location = New System.Drawing.Point(29, 99)
        Me.grp受注情報.Name = "grp受注情報"
        Me.grp受注情報.Size = New System.Drawing.Size(902, 91)
        Me.grp受注情報.TabIndex = 2
        Me.grp受注情報.TabStop = False
        Me.grp受注情報.Text = "【受注情報】"
        '
        'nam受注金額Title
        '
        Me.nam受注金額Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam受注金額Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam受注金額Title.Location = New System.Drawing.Point(776, 27)
        Me.nam受注金額Title.Name = "nam受注金額Title"
        Me.nam受注金額Title.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam受注金額Title.Size = New System.Drawing.Size(100, 23)
        Me.nam受注金額Title.StringLength = 0
        Me.nam受注金額Title.TabIndex = 8
        Me.nam受注金額Title.Text = "受注金額"
        Me.nam受注金額Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam受注金額Title.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam受注単価Title
        '
        Me.nam受注単価Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam受注単価Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam受注単価Title.Location = New System.Drawing.Point(665, 27)
        Me.nam受注単価Title.Name = "nam受注単価Title"
        Me.nam受注単価Title.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam受注単価Title.Size = New System.Drawing.Size(110, 23)
        Me.nam受注単価Title.StringLength = 0
        Me.nam受注単価Title.TabIndex = 7
        Me.nam受注単価Title.Text = "受注単価"
        Me.nam受注単価Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam受注単価Title.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam受注金額
        '
        Me.nam受注金額.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam受注金額.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam受注金額.Location = New System.Drawing.Point(776, 52)
        Me.nam受注金額.Name = "nam受注金額"
        Me.nam受注金額.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam受注金額.Size = New System.Drawing.Size(100, 23)
        Me.nam受注金額.StringLength = 0
        Me.nam受注金額.TabIndex = 6
        Me.nam受注金額.Text = "999,999,999"
        Me.nam受注金額.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.nam受注金額.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam受注単価
        '
        Me.nam受注単価.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam受注単価.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam受注単価.Location = New System.Drawing.Point(665, 52)
        Me.nam受注単価.Name = "nam受注単価"
        Me.nam受注単価.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam受注単価.Size = New System.Drawing.Size(110, 23)
        Me.nam受注単価.StringLength = 0
        Me.nam受注単価.TabIndex = 5
        Me.nam受注単価.Text = "9,999,999.00"
        Me.nam受注単価.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.nam受注単価.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam受注数
        '
        Me.nam受注数.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam受注数.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam受注数.Location = New System.Drawing.Point(563, 52)
        Me.nam受注数.Name = "nam受注数"
        Me.nam受注数.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam受注数.Size = New System.Drawing.Size(100, 23)
        Me.nam受注数.StringLength = 0
        Me.nam受注数.TabIndex = 4
        Me.nam受注数.Text = "999,999,999"
        Me.nam受注数.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.nam受注数.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam受注数Title
        '
        Me.nam受注数Title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam受注数Title.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam受注数Title.Location = New System.Drawing.Point(563, 27)
        Me.nam受注数Title.Name = "nam受注数Title"
        Me.nam受注数Title.Padding = New System.Windows.Forms.Padding(0, 3, 0, 2)
        Me.nam受注数Title.Size = New System.Drawing.Size(100, 23)
        Me.nam受注数Title.StringLength = 0
        Me.nam受注数Title.TabIndex = 2
        Me.nam受注数Title.Text = "受注数"
        Me.nam受注数Title.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.nam受注数Title.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'frmbbbOffSet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.grp受注情報)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmbbbOffSet"
        Me.Controls.SetChildIndex(Me.grp受注情報, 0)
        Me.grp受注情報.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp受注情報 As BaseUI.Control.GroupBox
    Friend WithEvents nam受注金額Title As BaseUI.Control.NameBox
    Friend WithEvents nam受注単価Title As BaseUI.Control.NameBox
    Friend WithEvents nam受注金額 As BaseUI.Control.NameBox
    Friend WithEvents nam受注単価 As BaseUI.Control.NameBox
    Friend WithEvents nam受注数 As BaseUI.Control.NameBox
    Friend WithEvents nam受注数Title As BaseUI.Control.NameBox

End Class
