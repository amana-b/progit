<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class dlgYamatoDate
    Inherits BaseUI.BaseDialog

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
        Me.grpCD = New BaseUI.Control.GroupBox()
        Me.txtデータ区分 = New BaseUI.Control.TextBox()
        Me.grpfind = New BaseUI.Control.GroupBox()
        Me.grpCD.SuspendLayout()
        Me.grpfind.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCD
        '
        Me.grpCD.Controls.Add(Me.txtデータ区分)
        Me.grpCD.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grpCD.Location = New System.Drawing.Point(10, 16)
        Me.grpCD.Name = "grpCD"
        Me.grpCD.Size = New System.Drawing.Size(58, 46)
        Me.grpCD.TabIndex = 12
        Me.grpCD.TabStop = False
        Me.grpCD.Text = "CD"
        '
        'txtデータ区分
        '
        Me.txtデータ区分.FieldKeyType = BaseContents.Field.KeyType.Key
        Me.txtデータ区分.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.txtデータ区分.HelpKeys = ""
        Me.txtデータ区分.HelpLink = ""
        Me.txtデータ区分.HelpType = NodeUI.Help.Type.None
        Me.txtデータ区分.IsError = False
        Me.txtデータ区分.Location = New System.Drawing.Point(9, 16)
        Me.txtデータ区分.Name = "txtデータ区分"
        Me.txtデータ区分.Required = False
        Me.txtデータ区分.Size = New System.Drawing.Size(30, 19)
        Me.txtデータ区分.StringLength = 2
        Me.txtデータ区分.TabIndex = 4
        Me.txtデータ区分.TextStyle = BaseContents.TextBox.TextStyle.Code
        '
        'grpfind
        '
        Me.grpfind.Controls.Add(Me.grpCD)
        Me.grpfind.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grpfind.Location = New System.Drawing.Point(435, 10)
        Me.grpfind.Name = "grpfind"
        Me.grpfind.Size = New System.Drawing.Size(87, 78)
        Me.grpfind.TabIndex = 27
        Me.grpfind.TabStop = False
        Me.grpfind.Text = "検索項目"
        '
        'dlgYamatoDate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(779, 475)
        Me.Controls.Add(Me.grpfind)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "dlgYamatoDate"
        Me.Text = "dlgYamatoDate"
        Me.Controls.SetChildIndex(Me.grpfind, 0)
        Me.grpCD.ResumeLayout(False)
        Me.grpCD.PerformLayout()
        Me.grpfind.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpCD As BaseUI.Control.GroupBox
    Friend WithEvents txtデータ区分 As BaseUI.Control.TextBox
    Friend WithEvents grpfind As BaseUI.Control.GroupBox
End Class
