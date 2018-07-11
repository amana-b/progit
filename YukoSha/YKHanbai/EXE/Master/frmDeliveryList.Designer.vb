<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDeliveryList
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
        Me.grp得意先 = New BaseUI.Control.GroupBox()
        Me.lblまで = New BaseUI.Control.Label()
        Me.lblから = New BaseUI.Control.Label()
        Me.nam得意先名T = New BaseUI.Control.NameBox()
        Me.txt得意先CDT = New BaseUI.Control.TextBox()
        Me.nam得意先名F = New BaseUI.Control.NameBox()
        Me.txt得意先CDF = New BaseUI.Control.TextBox()
        Me.grp得意先.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnESC
        '
        Me.btnESC.Text = "閉じる"
        '
        'grp得意先
        '
        Me.grp得意先.Controls.Add(Me.lblまで)
        Me.grp得意先.Controls.Add(Me.lblから)
        Me.grp得意先.Controls.Add(Me.nam得意先名T)
        Me.grp得意先.Controls.Add(Me.txt得意先CDT)
        Me.grp得意先.Controls.Add(Me.nam得意先名F)
        Me.grp得意先.Controls.Add(Me.txt得意先CDF)
        Me.grp得意先.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp得意先.Location = New System.Drawing.Point(29, 108)
        Me.grp得意先.Name = "grp得意先"
        Me.grp得意先.Size = New System.Drawing.Size(400, 110)
        Me.grp得意先.TabIndex = 1
        Me.grp得意先.TabStop = False
        Me.grp得意先.Text = "得意先CD"
        '
        'lblまで
        '
        Me.lblまで.AutoSize = True
        Me.lblまで.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.lblまで.Location = New System.Drawing.Point(8, 67)
        Me.lblまで.Name = "lblまで"
        Me.lblまで.Size = New System.Drawing.Size(56, 16)
        Me.lblまで.TabIndex = 13
        Me.lblまで.Text = "[まで]"
        '
        'lblから
        '
        Me.lblから.AutoSize = True
        Me.lblから.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.lblから.Location = New System.Drawing.Point(8, 36)
        Me.lblから.Name = "lblから"
        Me.lblから.Size = New System.Drawing.Size(56, 16)
        Me.lblから.TabIndex = 12
        Me.lblから.Text = "[から]"
        '
        'nam得意先名T
        '
        Me.nam得意先名T.BackColor = System.Drawing.SystemColors.Control
        Me.nam得意先名T.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam得意先名T.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam得意先名T.Location = New System.Drawing.Point(126, 64)
        Me.nam得意先名T.Margin = New System.Windows.Forms.Padding(3)
        Me.nam得意先名T.Name = "nam得意先名T"
        Me.nam得意先名T.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.nam得意先名T.Size = New System.Drawing.Size(260, 23)
        Me.nam得意先名T.TabIndex = 11
        Me.nam得意先名T.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt得意先CDT
        '
        Me.txt得意先CDT.FieldLockType = BaseContents.Field.LockType.None
        Me.txt得意先CDT.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt得意先CDT.HelpKeys = ""
        Me.txt得意先CDT.HelpLink = ""
        Me.txt得意先CDT.HelpType = NodeUI.Help.Type.None
        Me.txt得意先CDT.IsError = False
        Me.txt得意先CDT.Location = New System.Drawing.Point(66, 64)
        Me.txt得意先CDT.Name = "txt得意先CDT"
        Me.txt得意先CDT.Required = False
        Me.txt得意先CDT.Size = New System.Drawing.Size(61, 23)
        Me.txt得意先CDT.TabIndex = 10
        Me.txt得意先CDT.Text = "999999"
        Me.txt得意先CDT.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'nam得意先名F
        '
        Me.nam得意先名F.BackColor = System.Drawing.SystemColors.Control
        Me.nam得意先名F.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam得意先名F.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam得意先名F.Location = New System.Drawing.Point(126, 33)
        Me.nam得意先名F.Margin = New System.Windows.Forms.Padding(3)
        Me.nam得意先名F.Name = "nam得意先名F"
        Me.nam得意先名F.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.nam得意先名F.Size = New System.Drawing.Size(260, 23)
        Me.nam得意先名F.TabIndex = 9
        Me.nam得意先名F.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt得意先CDF
        '
        Me.txt得意先CDF.FieldLockType = BaseContents.Field.LockType.None
        Me.txt得意先CDF.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt得意先CDF.HelpKeys = ""
        Me.txt得意先CDF.HelpLink = ""
        Me.txt得意先CDF.HelpType = NodeUI.Help.Type.None
        Me.txt得意先CDF.IsError = False
        Me.txt得意先CDF.Location = New System.Drawing.Point(66, 33)
        Me.txt得意先CDF.Name = "txt得意先CDF"
        Me.txt得意先CDF.Required = False
        Me.txt得意先CDF.Size = New System.Drawing.Size(61, 23)
        Me.txt得意先CDF.TabIndex = 0
        Me.txt得意先CDF.Text = "999999"
        Me.txt得意先CDF.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'frmDeliveryList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 741)
        Me.Controls.Add(Me.grp得意先)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmDeliveryList"
        Me.Text = ""
        Me.Controls.SetChildIndex(Me.grp得意先, 0)
        Me.grp得意先.ResumeLayout(False)
        Me.grp得意先.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp得意先 As BaseUI.Control.GroupBox
    Friend WithEvents txt得意先CDF As BaseUI.Control.TextBox
    Friend WithEvents nam得意先名F As BaseUI.Control.NameBox
    Friend WithEvents nam得意先名T As BaseUI.Control.NameBox
    Friend WithEvents txt得意先CDT As BaseUI.Control.TextBox
    Friend WithEvents lblから As BaseUI.Control.Label
    Friend WithEvents lblまで As BaseUI.Control.Label
End Class
