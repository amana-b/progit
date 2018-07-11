<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class FlexibleSubDelivery
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FlexibleSubDelivery))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt発送先名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt発送先CD = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        CType(Me.txt発送先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt発送先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt発送先名, Me.txt発送先CD})
        Me.Detail.Height = 0.1968504!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        '
        'txt発送先名
        '
        Me.txt発送先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発送先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発送先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発送先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発送先名.Height = 0.1968504!
        Me.txt発送先名.Left = 0.5905512!
        Me.txt発送先名.Name = "txt発送先名"
        Me.txt発送先名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: top; ddo-c" & _
    "har-set: 1"
        Me.txt発送先名.Text = "あああああいいいいいううううう"
        Me.txt発送先名.Top = 0.0!
        Me.txt発送先名.Width = 2.440945!
        '
        'txt発送先CD
        '
        Me.txt発送先CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発送先CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発送先CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発送先CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発送先CD.Height = 0.1968504!
        Me.txt発送先CD.Left = 0.0!
        Me.txt発送先CD.Name = "txt発送先CD"
        Me.txt発送先CD.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: top; ddo-c" & _
    "har-set: 1"
        Me.txt発送先CD.Text = "002"
        Me.txt発送先CD.Top = 0.0000002980232!
        Me.txt発送先CD.Width = 0.5905512!
        '
        'PageHeader
        '
        Me.PageHeader.Height = 0.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.CanGrow = False
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'FlexibleSubDelivery
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 2.165354!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.txt発送先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt発送先CD, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txt発送先CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt発送先名 As DataDynamics.ActiveReports.TextBox
End Class
