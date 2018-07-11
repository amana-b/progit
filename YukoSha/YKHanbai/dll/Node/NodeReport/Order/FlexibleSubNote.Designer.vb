<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FlexibleSubNote
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
    Private WithEvents Detail As DataDynamics.ActiveReports.Detail
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FlexibleSubNote))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt注意事項 = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.lbl = New DataDynamics.ActiveReports.Label()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        CType(Me.txt注意事項, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt注意事項})
        Me.Detail.Height = 0.1968504!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        '
        'txt注意事項
        '
        Me.txt注意事項.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt注意事項.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt注意事項.Height = 0.1968504!
        Me.txt注意事項.Left = 0.0!
        Me.txt注意事項.Name = "txt注意事項"
        Me.txt注意事項.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: top; ddo-c" & _
    "har-set: 1"
        Me.txt注意事項.Text = "あああああいいいいいううううう"
        Me.txt注意事項.Top = 0.0!
        Me.txt注意事項.Width = 3.070866!
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lbl})
        Me.PageHeader.Height = 0.1968504!
        Me.PageHeader.Name = "PageHeader"
        '
        'lbl
        '
        Me.lbl.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl.Height = 0.1968504!
        Me.lbl.HyperLink = Nothing
        Me.lbl.Left = 0.0!
        Me.lbl.Name = "lbl"
        Me.lbl.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-ali" & _
    "gn: bottom; ddo-char-set: 1"
        Me.lbl.Text = "　【注　意　事　項】"
        Me.lbl.Top = 0.0!
        Me.lbl.Width = 3.070866!
        '
        'PageFooter
        '
        Me.PageFooter.CanGrow = False
        Me.PageFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label1})
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'Label1
        '
        Me.Label1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label1.Height = 0.5905512!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.0!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-ali" & _
    "gn: top; ddo-char-set: 1"
        Me.Label1.Text = ""
        Me.Label1.Top = 0.0!
        Me.Label1.Width = 3.031496!
        '
        'FlexibleSubNote
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 3.070866!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.txt注意事項, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter
    Private WithEvents Label6 As DataDynamics.ActiveReports.Label
    Private WithEvents Label9 As DataDynamics.ActiveReports.Label
    Private WithEvents Label12 As DataDynamics.ActiveReports.Label
    Private WithEvents txt自社担当者名 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents lbl本支店名 As DataDynamics.ActiveReports.Label
    Private WithEvents txt枝版 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl部署名 As DataDynamics.ActiveReports.Label
    Private WithEvents txt注意事項 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl As DataDynamics.ActiveReports.Label
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
End Class
