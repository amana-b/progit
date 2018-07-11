<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class OrderSlipAheadSubPaper
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(OrderSlipAheadSubPaper))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt紙の種類 = New DataDynamics.ActiveReports.TextBox()
        Me.txt糊 = New DataDynamics.ActiveReports.TextBox()
        Me.txt台紙 = New DataDynamics.ActiveReports.TextBox()
        Me.txt寸法 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入先名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt発注日 = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.lbl紙の種類 = New DataDynamics.ActiveReports.Label()
        Me.lbl仕入先名 = New DataDynamics.ActiveReports.Label()
        Me.lbl寸法 = New DataDynamics.ActiveReports.Label()
        Me.lbl台紙 = New DataDynamics.ActiveReports.Label()
        Me.lbl糊 = New DataDynamics.ActiveReports.Label()
        Me.lbl発注日 = New DataDynamics.ActiveReports.Label()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.txt支給有償 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl支給有償 = New DataDynamics.ActiveReports.Label()
        CType(Me.txt紙の種類, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt糊, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt台紙, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt寸法, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt発注日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl紙の種類, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl仕入先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl寸法, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl台紙, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl糊, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl発注日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt支給有償, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl支給有償, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt紙の種類, Me.txt糊, Me.txt台紙, Me.txt寸法, Me.txt仕入先名, Me.txt発注日, Me.txt支給有償})
        Me.Detail.Height = 0.1968508!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        '
        'txt紙の種類
        '
        Me.txt紙の種類.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙の種類.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙の種類.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙の種類.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙の種類.Height = 0.1968504!
        Me.txt紙の種類.Left = 0.0!
        Me.txt紙の種類.Name = "txt紙の種類"
        Me.txt紙の種類.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt紙の種類.Top = 0.0000007003546!
        Me.txt紙の種類.Width = 1.338583!
        '
        'txt糊
        '
        Me.txt糊.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt糊.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt糊.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt糊.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt糊.Height = 0.1968504!
        Me.txt糊.Left = 1.338583!
        Me.txt糊.Name = "txt糊"
        Me.txt糊.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt糊.Top = 0.0000003427267!
        Me.txt糊.Width = 0.8858268!
        '
        'txt台紙
        '
        Me.txt台紙.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt台紙.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt台紙.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt台紙.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt台紙.Height = 0.1968504!
        Me.txt台紙.Left = 2.22441!
        Me.txt台紙.Name = "txt台紙"
        Me.txt台紙.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt台紙.Top = 0.0000003427267!
        Me.txt台紙.Width = 0.8661417!
        '
        'txt寸法
        '
        Me.txt寸法.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt寸法.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt寸法.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt寸法.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt寸法.Height = 0.1968504!
        Me.txt寸法.Left = 3.090551!
        Me.txt寸法.Name = "txt寸法"
        Me.txt寸法.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt寸法.Top = 0.0!
        Me.txt寸法.Width = 0.8858268!
        '
        'txt仕入先名
        '
        Me.txt仕入先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先名.Height = 0.1968504!
        Me.txt仕入先名.Left = 3.976378!
        Me.txt仕入先名.Name = "txt仕入先名"
        Me.txt仕入先名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt仕入先名.Text = "あああああ"
        Me.txt仕入先名.Top = 0.0000003427267!
        Me.txt仕入先名.Width = 1.496063!
        '
        'txt発注日
        '
        Me.txt発注日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注日.Height = 0.1968504!
        Me.txt発注日.Left = 5.472441!
        Me.txt発注日.Name = "txt発注日"
        Me.txt発注日.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt発注日.Text = "YY/MM/DD"
        Me.txt発注日.Top = 0.0!
        Me.txt発注日.Width = 0.6299213!
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lbl紙の種類, Me.lbl仕入先名, Me.lbl寸法, Me.lbl台紙, Me.lbl糊, Me.lbl発注日, Me.lbl支給有償})
        Me.PageHeader.Height = 0.1968504!
        Me.PageHeader.Name = "PageHeader"
        '
        'lbl紙の種類
        '
        Me.lbl紙の種類.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙の種類.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙の種類.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙の種類.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙の種類.Height = 0.1968504!
        Me.lbl紙の種類.HyperLink = Nothing
        Me.lbl紙の種類.Left = 0.0!
        Me.lbl紙の種類.Name = "lbl紙の種類"
        Me.lbl紙の種類.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lbl紙の種類.Text = "紙の種類"
        Me.lbl紙の種類.Top = 0.0000007152557!
        Me.lbl紙の種類.Width = 1.338583!
        '
        'lbl仕入先名
        '
        Me.lbl仕入先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先名.Height = 0.1968504!
        Me.lbl仕入先名.HyperLink = Nothing
        Me.lbl仕入先名.Left = 3.976379!
        Me.lbl仕入先名.Name = "lbl仕入先名"
        Me.lbl仕入先名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-ali" & _
    "gn: bottom; ddo-char-set: 1"
        Me.lbl仕入先名.Text = "　仕 入 先 名"
        Me.lbl仕入先名.Top = 0.0000007152557!
        Me.lbl仕入先名.Width = 1.496063!
        '
        'lbl寸法
        '
        Me.lbl寸法.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl寸法.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl寸法.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl寸法.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl寸法.Height = 0.1968504!
        Me.lbl寸法.HyperLink = Nothing
        Me.lbl寸法.Left = 3.090552!
        Me.lbl寸法.Name = "lbl寸法"
        Me.lbl寸法.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lbl寸法.Text = "寸法"
        Me.lbl寸法.Top = 0.0000007152557!
        Me.lbl寸法.Width = 0.8858268!
        '
        'lbl台紙
        '
        Me.lbl台紙.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl台紙.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl台紙.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl台紙.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl台紙.Height = 0.1968504!
        Me.lbl台紙.HyperLink = Nothing
        Me.lbl台紙.Left = 2.22441!
        Me.lbl台紙.Name = "lbl台紙"
        Me.lbl台紙.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lbl台紙.Text = "台　紙"
        Me.lbl台紙.Top = 0.0!
        Me.lbl台紙.Width = 0.8661417!
        '
        'lbl糊
        '
        Me.lbl糊.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl糊.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl糊.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl糊.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl糊.Height = 0.1968504!
        Me.lbl糊.HyperLink = Nothing
        Me.lbl糊.Left = 1.338583!
        Me.lbl糊.Name = "lbl糊"
        Me.lbl糊.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lbl糊.Text = "糊"
        Me.lbl糊.Top = 0.0!
        Me.lbl糊.Width = 0.8858268!
        '
        'lbl発注日
        '
        Me.lbl発注日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発注日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発注日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発注日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発注日.Height = 0.1968504!
        Me.lbl発注日.HyperLink = Nothing
        Me.lbl発注日.Left = 5.472442!
        Me.lbl発注日.Name = "lbl発注日"
        Me.lbl発注日.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; text-justi" & _
    "fy: distribute; vertical-align: bottom; ddo-char-set: 1"
        Me.lbl発注日.Text = "発注日"
        Me.lbl発注日.Top = 0.0000003427267!
        Me.lbl発注日.Width = 0.6299213!
        '
        'PageFooter
        '
        Me.PageFooter.CanGrow = False
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'txt支給有償
        '
        Me.txt支給有償.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt支給有償.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt支給有償.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt支給有償.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt支給有償.Height = 0.1968504!
        Me.txt支給有償.Left = 6.102362!
        Me.txt支給有償.Name = "txt支給有償"
        Me.txt支給有償.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt支給有償.Top = 0.0!
        Me.txt支給有償.Width = 1.161417!
        '
        'lbl支給有償
        '
        Me.lbl支給有償.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl支給有償.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl支給有償.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl支給有償.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl支給有償.Height = 0.1968504!
        Me.lbl支給有償.HyperLink = Nothing
        Me.lbl支給有償.Left = 6.102363!
        Me.lbl支給有償.Name = "lbl支給有償"
        Me.lbl支給有償.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; text-justi" & _
    "fy: distribute; vertical-align: bottom; ddo-char-set: 1"
        Me.lbl支給有償.Text = "支給　有償"
        Me.lbl支給有償.Top = 0.0!
        Me.lbl支給有償.Width = 1.161417!
        '
        'OrderSlipAheadSubPaper
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.283465!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.txt紙の種類, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt糊, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt台紙, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt寸法, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt発注日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl紙の種類, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl仕入先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl寸法, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl台紙, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl糊, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl発注日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt支給有償, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl支給有償, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txt紙の種類 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt糊 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt台紙 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt寸法 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt発注日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl紙の種類 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl糊 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl台紙 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl寸法 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl仕入先名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl発注日 As DataDynamics.ActiveReports.Label
    Private WithEvents txt支給有償 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl支給有償 As DataDynamics.ActiveReports.Label
End Class
