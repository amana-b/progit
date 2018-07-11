<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BaseDialog
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BaseDialog))
        Me.grdBase = New BaseUI.Control.GridView()
        Me.grpFunc = New BaseUI.Control.GroupBox()
        Me.lblESC = New BaseUI.Control.Label()
        Me.btnESC = New BaseUI.Control.Button()
        Me.lblF12 = New BaseUI.Control.Label()
        Me.btnF12 = New BaseUI.Control.Button()
        Me.lbl件数 = New BaseUI.Control.Label()
        CType(Me.grdBase, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpFunc.SuspendLayout()
        Me.SuspendLayout()
        '
        'grdBase
        '
        Me.grdBase.AllowUserToAddRows = False
        Me.grdBase.AllowUserToDeleteRows = False
        Me.grdBase.AllowUserToResizeRows = False
        Me.grdBase.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised
        Me.grdBase.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdBase.DataKeyNames = ""
        Me.grdBase.FieldLockType = BaseContents.Field.LockType.None
        Me.grdBase.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.grdBase.IsError = False
        Me.grdBase.Location = New System.Drawing.Point(10, 23)
        Me.grdBase.Name = "grdBase"
        Me.grdBase.Required = False
        Me.grdBase.RowHeadersVisible = False
        Me.grdBase.RowTemplate.Height = 3
        Me.grdBase.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdBase.Size = New System.Drawing.Size(160, 692)
        Me.grdBase.TabIndex = 0
        '
        'grpFunc
        '
        Me.grpFunc.Controls.Add(Me.lblESC)
        Me.grpFunc.Controls.Add(Me.btnESC)
        Me.grpFunc.Controls.Add(Me.lblF12)
        Me.grpFunc.Controls.Add(Me.btnF12)
        Me.grpFunc.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!)
        Me.grpFunc.Location = New System.Drawing.Point(702, 666)
        Me.grpFunc.Name = "grpFunc"
        Me.grpFunc.Size = New System.Drawing.Size(158, 72)
        Me.grpFunc.TabIndex = 25
        Me.grpFunc.TabStop = False
        '
        'lblESC
        '
        Me.lblESC.AutoSize = True
        Me.lblESC.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblESC.Location = New System.Drawing.Point(21, 52)
        Me.lblESC.Name = "lblESC"
        Me.lblESC.Size = New System.Drawing.Size(41, 12)
        Me.lblESC.TabIndex = 24
        Me.lblESC.Text = "「ESC]"
        '
        'btnESC
        '
        Me.btnESC.FieldLockType = BaseContents.Field.LockType.None
        Me.btnESC.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnESC.Location = New System.Drawing.Point(13, 15)
        Me.btnESC.Name = "btnESC"
        Me.btnESC.Size = New System.Drawing.Size(60, 34)
        Me.btnESC.TabIndex = 23
        Me.btnESC.TabStop = False
        Me.btnESC.Text = "戻る"
        Me.btnESC.UseVisualStyleBackColor = True
        '
        'lblF12
        '
        Me.lblF12.AutoSize = True
        Me.lblF12.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.lblF12.Location = New System.Drawing.Point(97, 53)
        Me.lblF12.Name = "lblF12"
        Me.lblF12.Size = New System.Drawing.Size(35, 12)
        Me.lblF12.TabIndex = 22
        Me.lblF12.Text = "[F12]"
        '
        'btnF12
        '
        Me.btnF12.FieldLockType = BaseContents.Field.LockType.None
        Me.btnF12.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.btnF12.Location = New System.Drawing.Point(84, 15)
        Me.btnF12.Name = "btnF12"
        Me.btnF12.Size = New System.Drawing.Size(60, 34)
        Me.btnF12.TabIndex = 21
        Me.btnF12.TabStop = False
        Me.btnF12.Text = "決定"
        Me.btnF12.UseVisualStyleBackColor = True
        '
        'lbl件数
        '
        Me.lbl件数.AutoSize = True
        Me.lbl件数.Font = New System.Drawing.Font("ＭＳ ゴシック", 12.0!)
        Me.lbl件数.Location = New System.Drawing.Point(14, 5)
        Me.lbl件数.Name = "lbl件数"
        Me.lbl件数.Size = New System.Drawing.Size(56, 16)
        Me.lbl件数.TabIndex = 26
        Me.lbl件数.Text = "Label1"
        '
        'BaseDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(883, 758)
        Me.Controls.Add(Me.grdBase)
        Me.Controls.Add(Me.grpFunc)
        Me.Controls.Add(Me.lbl件数)
        Me.Font = New System.Drawing.Font("ＭＳ ゴシック", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(128, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BaseDialog"
        Me.Text = "BaseDialog"
        CType(Me.grdBase, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpFunc.ResumeLayout(False)
        Me.grpFunc.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblF12 As BaseUI.Control.Label
    Protected WithEvents btnF12 As BaseUI.Control.Button
    Friend WithEvents lblESC As BaseUI.Control.Label
    Protected WithEvents btnESC As BaseUI.Control.Button
    Friend WithEvents grpFunc As BaseUI.Control.GroupBox
    Public WithEvents grdBase As BaseUI.Control.GridView
    Friend WithEvents lbl件数 As BaseUI.Control.Label
End Class
