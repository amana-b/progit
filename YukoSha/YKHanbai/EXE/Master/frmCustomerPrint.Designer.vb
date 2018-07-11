<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomerPrint
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
        Me.lblまで = New BaseUI.Control.Label()
        Me.lblから = New BaseUI.Control.Label()
        Me.nam得意先名T = New BaseUI.Control.NameBox()
        Me.txt得意先CDT = New BaseUI.Control.TextBox()
        Me.nam得意先名F = New BaseUI.Control.NameBox()
        Me.txt得意先CDF = New BaseUI.Control.TextBox()
        Me.grp担当者CD = New BaseUI.Control.GroupBox()
        Me.Label1 = New BaseUI.Control.Label()
        Me.Label2 = New BaseUI.Control.Label()
        Me.nam自社担当者名T = New BaseUI.Control.NameBox()
        Me.txt自社担当者CDT = New BaseUI.Control.TextBox()
        Me.nam自社担当者名F = New BaseUI.Control.NameBox()
        Me.txt自社担当者CDF = New BaseUI.Control.TextBox()
        Me.grp得意先CD.SuspendLayout()
        Me.grp担当者CD.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnESC
        '
        Me.btnESC.Text = "閉じる"
        '
        'grp得意先CD
        '
        Me.grp得意先CD.Controls.Add(Me.lblまで)
        Me.grp得意先CD.Controls.Add(Me.lblから)
        Me.grp得意先CD.Controls.Add(Me.nam得意先名T)
        Me.grp得意先CD.Controls.Add(Me.txt得意先CDT)
        Me.grp得意先CD.Controls.Add(Me.nam得意先名F)
        Me.grp得意先CD.Controls.Add(Me.txt得意先CDF)
        Me.grp得意先CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp得意先CD.Location = New System.Drawing.Point(29, 141)
        Me.grp得意先CD.Name = "grp得意先CD"
        Me.grp得意先CD.Size = New System.Drawing.Size(400, 110)
        Me.grp得意先CD.TabIndex = 1
        Me.grp得意先CD.TabStop = False
        Me.grp得意先CD.Text = "得意先CD"
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
        Me.nam得意先名T.StringLength = 65535
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
        Me.txt得意先CDT.TextStyle = BaseContents.TextBox.TextStyle.Code
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
        Me.nam得意先名F.StringLength = 65535
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
        Me.txt得意先CDF.TextStyle = BaseContents.TextBox.TextStyle.Code
        '
        'grp担当者CD
        '
        Me.grp担当者CD.Controls.Add(Me.Label1)
        Me.grp担当者CD.Controls.Add(Me.Label2)
        Me.grp担当者CD.Controls.Add(Me.nam自社担当者名T)
        Me.grp担当者CD.Controls.Add(Me.txt自社担当者CDT)
        Me.grp担当者CD.Controls.Add(Me.nam自社担当者名F)
        Me.grp担当者CD.Controls.Add(Me.txt自社担当者CDF)
        Me.grp担当者CD.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grp担当者CD.Location = New System.Drawing.Point(29, 12)
        Me.grp担当者CD.Name = "grp担当者CD"
        Me.grp担当者CD.Size = New System.Drawing.Size(400, 110)
        Me.grp担当者CD.TabIndex = 0
        Me.grp担当者CD.TabStop = False
        Me.grp担当者CD.Text = "担当者CD"
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
        'nam自社担当者名T
        '
        Me.nam自社担当者名T.BackColor = System.Drawing.SystemColors.Control
        Me.nam自社担当者名T.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam自社担当者名T.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam自社担当者名T.Location = New System.Drawing.Point(126, 64)
        Me.nam自社担当者名T.Margin = New System.Windows.Forms.Padding(3)
        Me.nam自社担当者名T.Name = "nam自社担当者名T"
        Me.nam自社担当者名T.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.nam自社担当者名T.Size = New System.Drawing.Size(260, 23)
        Me.nam自社担当者名T.StringLength = 65535
        Me.nam自社担当者名T.TabIndex = 11
        Me.nam自社担当者名T.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt自社担当者CDT
        '
        Me.txt自社担当者CDT.FieldLockType = BaseContents.Field.LockType.None
        Me.txt自社担当者CDT.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt自社担当者CDT.HelpKeys = ""
        Me.txt自社担当者CDT.HelpLink = ""
        Me.txt自社担当者CDT.HelpType = NodeUI.Help.Type.None
        Me.txt自社担当者CDT.IsError = False
        Me.txt自社担当者CDT.Location = New System.Drawing.Point(66, 64)
        Me.txt自社担当者CDT.Name = "txt自社担当者CDT"
        Me.txt自社担当者CDT.Required = False
        Me.txt自社担当者CDT.Size = New System.Drawing.Size(61, 23)
        Me.txt自社担当者CDT.TabIndex = 10
        Me.txt自社担当者CDT.Text = "999999"
        Me.txt自社担当者CDT.TextStyle = BaseContents.TextBox.TextStyle.Code
        '
        'nam自社担当者名F
        '
        Me.nam自社担当者名F.BackColor = System.Drawing.SystemColors.Control
        Me.nam自社担当者名F.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.nam自社担当者名F.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.nam自社担当者名F.Location = New System.Drawing.Point(126, 33)
        Me.nam自社担当者名F.Margin = New System.Windows.Forms.Padding(3)
        Me.nam自社担当者名F.Name = "nam自社担当者名F"
        Me.nam自社担当者名F.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.nam自社担当者名F.Size = New System.Drawing.Size(260, 23)
        Me.nam自社担当者名F.StringLength = 65535
        Me.nam自社担当者名F.TabIndex = 9
        Me.nam自社担当者名F.TextStyle = BaseContents.TextBox.TextStyle.None
        '
        'txt自社担当者CDF
        '
        Me.txt自社担当者CDF.FieldLockType = BaseContents.Field.LockType.None
        Me.txt自社担当者CDF.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.txt自社担当者CDF.HelpKeys = ""
        Me.txt自社担当者CDF.HelpLink = ""
        Me.txt自社担当者CDF.HelpType = NodeUI.Help.Type.None
        Me.txt自社担当者CDF.IsError = False
        Me.txt自社担当者CDF.Location = New System.Drawing.Point(66, 33)
        Me.txt自社担当者CDF.Name = "txt自社担当者CDF"
        Me.txt自社担当者CDF.Required = False
        Me.txt自社担当者CDF.Size = New System.Drawing.Size(61, 23)
        Me.txt自社担当者CDF.TabIndex = 0
        Me.txt自社担当者CDF.Text = "999999"
        Me.txt自社担当者CDF.TextStyle = BaseContents.TextBox.TextStyle.Code
        '
        'frmCustomerPrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1016, 473)
        Me.Controls.Add(Me.grp担当者CD)
        Me.Controls.Add(Me.grp得意先CD)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Name = "frmCustomerPrint"
        Me.Text = ""
        Me.Controls.SetChildIndex(Me.grp得意先CD, 0)
        Me.Controls.SetChildIndex(Me.grp担当者CD, 0)
        Me.grp得意先CD.ResumeLayout(False)
        Me.grp得意先CD.PerformLayout()
        Me.grp担当者CD.ResumeLayout(False)
        Me.grp担当者CD.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grp得意先CD As BaseUI.Control.GroupBox
    Friend WithEvents txt得意先CDF As BaseUI.Control.TextBox
    Friend WithEvents nam得意先名F As BaseUI.Control.NameBox
    Friend WithEvents nam得意先名T As BaseUI.Control.NameBox
    Friend WithEvents txt得意先CDT As BaseUI.Control.TextBox
    Friend WithEvents lblから As BaseUI.Control.Label
    Friend WithEvents lblまで As BaseUI.Control.Label
    Friend WithEvents grp担当者CD As BaseUI.Control.GroupBox
    Friend WithEvents Label1 As BaseUI.Control.Label
    Friend WithEvents Label2 As BaseUI.Control.Label
    Friend WithEvents nam自社担当者名T As BaseUI.Control.NameBox
    Friend WithEvents txt自社担当者CDT As BaseUI.Control.TextBox
    Friend WithEvents nam自社担当者名F As BaseUI.Control.NameBox
    Friend WithEvents txt自社担当者CDF As BaseUI.Control.TextBox
End Class
