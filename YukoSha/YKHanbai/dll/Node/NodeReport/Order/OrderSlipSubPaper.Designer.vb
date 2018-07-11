<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class OrderSlipSubPaper
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(OrderSlipSubPaper))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox12 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox13 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox14 = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.lbl紙の種類 = New DataDynamics.ActiveReports.Label()
        Me.lbl糊 = New DataDynamics.ActiveReports.Label()
        Me.lbl台紙 = New DataDynamics.ActiveReports.Label()
        Me.lbl寸法 = New DataDynamics.ActiveReports.Label()
        Me.lbl仕入先名 = New DataDynamics.ActiveReports.Label()
        Me.lbl備考 = New DataDynamics.ActiveReports.Label()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl紙の種類, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl糊, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl台紙, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl寸法, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl仕入先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl備考, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox1, Me.TextBox3, Me.TextBox4, Me.TextBox12, Me.TextBox13, Me.TextBox14})
        Me.Detail.Height = 0.1968504!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        '
        'TextBox1
        '
        Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Height = 0.1968504!
        Me.TextBox1.Left = 0.0!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox1.Text = "999"
        Me.TextBox1.Top = 0.0000007003546!
        Me.TextBox1.Width = 1.338583!
        '
        'TextBox3
        '
        Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Height = 0.1968504!
        Me.TextBox3.Left = 1.338583!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox3.Text = "9,999"
        Me.TextBox3.Top = 0.0000003427267!
        Me.TextBox3.Width = 0.8858268!
        '
        'TextBox4
        '
        Me.TextBox4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Height = 0.1968504!
        Me.TextBox4.Left = 2.22441!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox4.Text = "99,9999"
        Me.TextBox4.Top = 0.0000003427267!
        Me.TextBox4.Width = 0.8661417!
        '
        'TextBox12
        '
        Me.TextBox12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Height = 0.1968504!
        Me.TextBox12.Left = 3.090551!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox12.Text = "9,999"
        Me.TextBox12.Top = 0.0000003427267!
        Me.TextBox12.Width = 0.8858268!
        '
        'TextBox13
        '
        Me.TextBox13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Height = 0.1968504!
        Me.TextBox13.Left = 3.976378!
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox13.Text = "9999"
        Me.TextBox13.Top = 0.0000003427267!
        Me.TextBox13.Width = 1.496063!
        '
        'TextBox14
        '
        Me.TextBox14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox14.Height = 0.1968504!
        Me.TextBox14.Left = 5.472441!
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox14.Text = "999,999"
        Me.TextBox14.Top = 0.0!
        Me.TextBox14.Width = 1.811024!
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lbl紙の種類, Me.lbl仕入先名, Me.lbl寸法, Me.lbl台紙, Me.lbl糊, Me.lbl備考})
        Me.PageHeader.Height = 0.1968504!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.CanGrow = False
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
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
        'lbl寸法
        '
        Me.lbl寸法.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl寸法.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl寸法.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl寸法.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl寸法.Height = 0.1968504!
        Me.lbl寸法.HyperLink = Nothing
        Me.lbl寸法.Left = 3.090551!
        Me.lbl寸法.Name = "lbl寸法"
        Me.lbl寸法.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lbl寸法.Text = "寸法"
        Me.lbl寸法.Top = 0.0000007152557!
        Me.lbl寸法.Width = 0.8858268!
        '
        'lbl仕入先名
        '
        Me.lbl仕入先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先名.Height = 0.1968504!
        Me.lbl仕入先名.HyperLink = Nothing
        Me.lbl仕入先名.Left = 3.976378!
        Me.lbl仕入先名.Name = "lbl仕入先名"
        Me.lbl仕入先名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-ali" & _
    "gn: bottom; ddo-char-set: 1"
        Me.lbl仕入先名.Text = "　仕 入 先 名"
        Me.lbl仕入先名.Top = 0.0000007152557!
        Me.lbl仕入先名.Width = 1.496063!
        '
        'lbl備考
        '
        Me.lbl備考.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl備考.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl備考.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl備考.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl備考.Height = 0.1968504!
        Me.lbl備考.HyperLink = Nothing
        Me.lbl備考.Left = 5.472441!
        Me.lbl備考.Name = "lbl備考"
        Me.lbl備考.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; text-justi" & _
    "fy: distribute; vertical-align: bottom; ddo-char-set: 1"
        Me.lbl備考.Text = "備　　　考"
        Me.lbl備考.Top = 0.0000003427267!
        Me.lbl備考.Width = 1.811024!
        '
        'OrderSlipSubPaper
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
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl紙の種類, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl糊, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl台紙, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl寸法, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl仕入先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl備考, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox12 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox13 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox14 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl紙の種類 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl糊 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl台紙 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl寸法 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl仕入先名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl備考 As DataDynamics.ActiveReports.Label
End Class
