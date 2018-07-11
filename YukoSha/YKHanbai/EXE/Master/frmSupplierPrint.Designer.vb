<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupplierPrint
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
        Me.grp仕入先CD = New BaseUI.Control.GroupBox()
        Me.Label1 = New BaseUI.Control.Label()
        Me.Label2 = New BaseUI.Control.Label()
        Me.nam仕入先名T = New BaseUI.Control.NameBox()
        Me.txt仕入先CDT = New BaseUI.Control.TextBox()
        Me.nam仕入先名F = New BaseUI.Control.NameBox()
        Me.txt仕入先CDF = New BaseUI.Control.TextBox()
        Me.grp仕入先CD.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnESC
        '
        Me.btnESC.Text = "閉じる"
        '
        'grp仕入先CD
        '
        Me.grp仕入先CD.Controls.Add(Me.Label1)
        Me.grp仕入先CD.Controls.Add(Me.Label2)
        Me.grp仕入先CD.Controls.Add(Me.nam仕入先名T)
        Me.grp仕入先CD.Controls.Add(Me.txt仕入先CDT)
        Me.grp仕入先CD.Controls.Add(Me.nam仕入先名F)
        Me.grp仕入先CD.Controls.Add(Me.txt仕入先CDF)
        Me.grp仕入先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp仕入先CD.Location = New System.Drawing.Point(29, 12)
        Me.grp仕入先CD.Name = "grp仕入先CD"
        Me.grp仕入先CD.Size = New System.Drawing.Size(400, 110)
        Me.grp仕入先CD.TabIndex = 0
        Me.grp仕入先CD.TabStop = False
        Me.grp仕入先CD.Text = "仕入先CD"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(8, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 16)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "[まで]"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.Label2.Location = New System.Drawing.Point(8, 36)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "[から]"
        '
        'nam仕入先名T
        '
        Me.nam仕入先名T.BackColor = System.Drawing.SystemColors.Control
        Me.nam仕入先名T.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam仕入先名T.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam仕入先名T.Location = New System.Drawing.Point(126, 64)
        Me.nam仕入先名T.Margin = New System.Windows.Forms.Padding(3)
        Me.nam仕入先名T.Name = "nam仕入先名T"
        Me.nam仕入先名T.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.nam仕入先名T.Size = New System.Drawing.Size(260, 23)
        Me.nam仕入先名T.StringLength = 65535
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
        Me.txt仕入先CDT.Location = New System.Drawing.Point(66, 64)
        Me.txt仕入先CDT.Name = "txt仕入先CDT"
        Me.txt仕入先CDT.Required = False
        Me.txt仕入先CDT.Size = New System.Drawing.Size(61, 23)
        Me.txt仕入先CDT.TabIndex = 10
        Me.txt仕入先CDT.Text = "999999"
        Me.txt仕入先CDT.TextStyle = BaseContents.TextBox.TextStyle.Code
        '
        'nam仕入先名F
        '
        Me.nam仕入先名F.BackColor = System.Drawing.SystemColors.Control
        Me.nam仕入先名F.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam仕入先名F.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam仕入先名F.Location = New System.Drawing.Point(126, 33)
        Me.nam仕入先名F.Margin = New System.Windows.Forms.Padding(3)
        Me.nam仕入先名F.Name = "nam仕入先名F"
        Me.nam仕入先名F.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.nam仕入先名F.Size = New System.Drawing.Size(260, 23)
        Me.nam仕入先名F.StringLength = 65535
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
        Me.txt仕入先CDF.Location = New System.Drawing.Point(66, 33)
        Me.txt仕入先CDF.Name = "txt仕入先CDF"
        Me.txt仕入先CDF.Required = False
        Me.txt仕入先CDF.Size = New System.Drawing.Size(61, 23)
        Me.txt仕入先CDF.TabIndex = 0
        Me.txt仕入先CDF.Text = "999999"
        Me.txt仕入先CDF.TextStyle = BaseContents.TextBox.TextStyle.Code
        '
        'frmSupplierPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 473)
        Me.Controls.Add(Me.grp仕入先CD)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmSupplierPrint"
        Me.Text = ""
        Me.Controls.SetChildIndex(Me.grp仕入先CD, 0)
        Me.grp仕入先CD.ResumeLayout(False)
        Me.grp仕入先CD.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp仕入先CD As BaseUI.Control.GroupBox
    Friend WithEvents Label1 As BaseUI.Control.Label
    Friend WithEvents Label2 As BaseUI.Control.Label
    Friend WithEvents nam仕入先名T As BaseUI.Control.NameBox
    Friend WithEvents txt仕入先CDT As BaseUI.Control.TextBox
    Friend WithEvents nam仕入先名F As BaseUI.Control.NameBox
    Friend WithEvents txt仕入先CDF As BaseUI.Control.TextBox
End Class
