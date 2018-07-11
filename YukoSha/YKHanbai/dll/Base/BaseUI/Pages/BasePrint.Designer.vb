<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BasePrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BasePrint))
        Me.BaseViewer = New DataDynamics.ActiveReports.Viewer.Viewer()
        Me.SuspendLayout()
        '
        'BaseViewer
        '
        Me.BaseViewer.BackColor = System.Drawing.SystemColors.Control
        Me.BaseViewer.Document = New DataDynamics.ActiveReports.Document.Document("ARNet Document")
        Me.BaseViewer.Location = New System.Drawing.Point(0, 0)
        Me.BaseViewer.Name = "BaseViewer"
        Me.BaseViewer.ReportViewer.MultiplePageCols = 3
        Me.BaseViewer.ReportViewer.MultiplePageRows = 2
        Me.BaseViewer.ReportViewer.RulerVisible = False
        Me.BaseViewer.ReportViewer.ViewType = DataDynamics.ActiveReports.Viewer.ViewType.Normal
        Me.BaseViewer.Size = New System.Drawing.Size(795, 770)
        Me.BaseViewer.TabIndex = 0
        Me.BaseViewer.TableOfContents.Text = "見出し一覧"
        Me.BaseViewer.TableOfContents.Width = 200
        Me.BaseViewer.TabTitleLength = 35
        Me.BaseViewer.Toolbar.Font = New System.Drawing.Font("MS UI Gothic", 9.0!)
        '
        'BasePrint
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(792, 773)
        Me.Controls.Add(Me.BaseViewer)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BasePrint"
        Me.Text = "BasePrint"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BaseViewer As DataDynamics.ActiveReports.Viewer.Viewer
End Class
