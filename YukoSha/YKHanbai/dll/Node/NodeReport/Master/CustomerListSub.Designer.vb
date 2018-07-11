<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class CustomerListSub
    Inherits DataDynamics.ActiveReports.ActiveReport

    'ActiveReport がコンポーネントの一覧をクリーンアップするために dispose をオーバーライドします。
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
        End If
        MyBase.Dispose(disposing)
    End Sub

    'メモ: 以下のプロシージャは ActiveReport デザイナで必要です。
    'ActiveReport デザイナを使用して変更できます。  
    'コード エディタを使って変更しないでください。
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CustomerListSub))
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txtdtl特記事項 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr得意先CD = New DataDynamics.ActiveReports.GroupHeader()
        Me.grpFtr得意先CD = New DataDynamics.ActiveReports.GroupFooter()
        CType(Me.txtdtl特記事項, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader
        '
        Me.PageHeader.Height = 0.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtdtl特記事項})
        Me.Detail.Height = 0.1968504!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        '
        'txtdtl特記事項
        '
        Me.txtdtl特記事項.CanGrow = False
        Me.txtdtl特記事項.Height = 0.1968504!
        Me.txtdtl特記事項.Left = 0.0!
        Me.txtdtl特記事項.Name = "txtdtl特記事項"
        Me.txtdtl特記事項.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: left; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txtdtl特記事項.Text = "ああああああああああいいいいいいいいいいううううううううううええええええええええおおおおおおおおおおかかかかか"
        Me.txtdtl特記事項.Top = 0.0!
        Me.txtdtl特記事項.Width = 7.322835!
        '
        'PageFooter
        '
        Me.PageFooter.CanGrow = False
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'grpHdr得意先CD
        '
        Me.grpHdr得意先CD.DataField = "得意先CD"
        Me.grpHdr得意先CD.Height = 0.0!
        Me.grpHdr得意先CD.Name = "grpHdr得意先CD"
        '
        'grpFtr得意先CD
        '
        Me.grpFtr得意先CD.Height = 0.0!
        Me.grpFtr得意先CD.Name = "grpFtr得意先CD"
        '
        'CustomerListSub
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.401575!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.grpHdr得意先CD)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.grpFtr得意先CD)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.txtdtl特記事項, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Private WithEvents txtdtl特記事項 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpHdr得意先CD As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents grpFtr得意先CD As DataDynamics.ActiveReports.GroupFooter
End Class
