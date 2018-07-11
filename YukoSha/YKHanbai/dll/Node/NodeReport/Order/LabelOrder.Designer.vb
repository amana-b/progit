<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class LabelOrder
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(LabelOrder))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt再新区分 = New DataDynamics.ActiveReports.TextBox()
        Me.Barcode = New DataDynamics.ActiveReports.Barcode()
        Me.txt作業No = New DataDynamics.ActiveReports.TextBox()
        Me.txtユーザー名1 = New DataDynamics.ActiveReports.TextBox()
        Me.txtユーザー名2 = New DataDynamics.ActiveReports.TextBox()
        Me.txt商品名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt作業注意事項2 = New DataDynamics.ActiveReports.TextBox()
        Me.txt作業注意事項1 = New DataDynamics.ActiveReports.TextBox()
        Me.txt通数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt刃型No = New DataDynamics.ActiveReports.TextBox()
        Me.txt受注日 = New DataDynamics.ActiveReports.TextBox()
        Me.txt長さ = New DataDynamics.ActiveReports.TextBox()
        Me.txt版No = New DataDynamics.ActiveReports.TextBox()
        Me.txt発送仕上区分名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt発送仕上区分 = New DataDynamics.ActiveReports.TextBox()
        Me.txt納品日 = New DataDynamics.ActiveReports.TextBox()
        Me.txt社内外区分 = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        CType(Me.txt再新区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt作業No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtユーザー名1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtユーザー名2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt作業注意事項2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt作業注意事項1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt刃型No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt受注日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt長さ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt版No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt発送仕上区分名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt発送仕上区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt納品日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt社内外区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnCount = 4
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt再新区分, Me.Barcode, Me.txt作業No, Me.txtユーザー名1, Me.txtユーザー名2, Me.txt商品名, Me.txt作業注意事項2, Me.txt作業注意事項1, Me.txt通数, Me.txt刃型No, Me.txt受注日, Me.txt長さ, Me.txt版No, Me.txt発送仕上区分名, Me.txt発送仕上区分, Me.txt納品日, Me.txt社内外区分})
        Me.Detail.Height = 1.334646!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.RepeatToFill = True
        '
        'txt再新区分
        '
        Me.txt再新区分.Height = 0.1968504!
        Me.txt再新区分.Left = 0.0!
        Me.txt再新区分.Name = "txt再新区分"
        Me.txt再新区分.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt再新区分.Text = "●"
        Me.txt再新区分.Top = 0.0000009536743!
        Me.txt再新区分.Width = 0.1968504!
        '
        'Barcode
        '
        Me.Barcode.CheckSumEnabled = False
        Me.Barcode.DataField = "ReportNoJudge"
        Me.Barcode.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.Barcode.Height = 0.2165354!
        Me.Barcode.Left = 1.873228!
        Me.Barcode.Name = "Barcode"
        Me.Barcode.Style = DataDynamics.ActiveReports.BarCodeStyle.Code39
        Me.Barcode.Text = "Barcode"
        Me.Barcode.Top = 0.0!
        Me.Barcode.Width = 0.8661417!
        '
        'txt作業No
        '
        Me.txt作業No.Height = 0.1968504!
        Me.txt作業No.Left = 0.1968504!
        Me.txt作業No.Name = "txt作業No"
        Me.txt作業No.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt作業No.Text = "123456"
        Me.txt作業No.Top = 0.0!
        Me.txt作業No.Width = 0.5791339!
        '
        'txtユーザー名1
        '
        Me.txtユーザー名1.Height = 0.1377953!
        Me.txtユーザー名1.Left = 0.7759843!
        Me.txtユーザー名1.Name = "txtユーザー名1"
        Me.txtユーザー名1.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: justify; vertical-align: top; ddo" & _
    "-char-set: 1"
        Me.txtユーザー名1.Text = "あああああいいい"
        Me.txtユーザー名1.Top = 0.0!
        Me.txtユーザー名1.Width = 1.023622!
        '
        'txtユーザー名2
        '
        Me.txtユーザー名2.Height = 0.1377953!
        Me.txtユーザー名2.Left = 0.7759843!
        Me.txtユーザー名2.Name = "txtユーザー名2"
        Me.txtユーザー名2.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: justify; vertical-align: top; ddo" & _
    "-char-set: 1"
        Me.txtユーザー名2.Text = "あああああいいい"
        Me.txtユーザー名2.Top = 0.1377953!
        Me.txtユーザー名2.Width = 1.023622!
        '
        'txt商品名
        '
        Me.txt商品名.Height = 0.1968504!
        Me.txt商品名.Left = 0.0!
        Me.txt商品名.Name = "txt商品名"
        Me.txt商品名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: justify; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.txt商品名.Text = "あああああいいいいいううう"
        Me.txt商品名.Top = 0.2755906!
        Me.txt商品名.Width = 1.920473!
        '
        'txt作業注意事項2
        '
        Me.txt作業注意事項2.Height = 0.1377953!
        Me.txt作業注意事項2.Left = 0.0!
        Me.txt作業注意事項2.Name = "txt作業注意事項2"
        Me.txt作業注意事項2.Style = "font-family: ＭＳ 明朝; font-size: 7.5pt; text-align: justify; vertical-align: bottom" & _
    "; ddo-char-set: 1"
        Me.txt作業注意事項2.Text = "あああああいいいいいうううううえええええおおおおお"
        Me.txt作業注意事項2.Top = 0.7716536!
        Me.txt作業注意事項2.Width = 2.701969!
        '
        'txt作業注意事項1
        '
        Me.txt作業注意事項1.Height = 0.1377953!
        Me.txt作業注意事項1.Left = 0.0!
        Me.txt作業注意事項1.Name = "txt作業注意事項1"
        Me.txt作業注意事項1.Style = "font-family: ＭＳ 明朝; font-size: 7.5pt; text-align: justify; vertical-align: bottom" & _
    "; ddo-char-set: 1"
        Me.txt作業注意事項1.Text = "あああああいいいいいうううううえええええおおおおお"
        Me.txt作業注意事項1.Top = 0.6141733!
        Me.txt作業注意事項1.Width = 2.701969!
        '
        'txt通数
        '
        Me.txt通数.Height = 0.1181102!
        Me.txt通数.Left = 0.4248032!
        Me.txt通数.Name = "txt通数"
        Me.txt通数.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: center; vertical-align: top; ddo-" & _
    "char-set: 1"
        Me.txt通数.Text = "999,999通　 999,999通　　 999,999通"
        Me.txt通数.Top = 0.472441!
        Me.txt通数.Width = 1.771654!
        '
        'txt刃型No
        '
        Me.txt刃型No.Height = 0.1574803!
        Me.txt刃型No.Left = 0.0!
        Me.txt刃型No.Name = "txt刃型No"
        Me.txt刃型No.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: justify; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt刃型No.Text = "刃型1234"
        Me.txt刃型No.Top = 0.9188977!
        Me.txt刃型No.Width = 0.5976378!
        '
        'txt受注日
        '
        Me.txt受注日.Height = 0.1968504!
        Me.txt受注日.Left = 0.0!
        Me.txt受注日.Name = "txt受注日"
        Me.txt受注日.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: justify; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt受注日.Text = "受 MM/DD"
        Me.txt受注日.Top = 1.090551!
        Me.txt受注日.Width = 0.5905512!
        '
        'txt長さ
        '
        Me.txt長さ.Height = 0.1181102!
        Me.txt長さ.Left = 2.211024!
        Me.txt長さ.Name = "txt長さ"
        Me.txt長さ.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: right; vertical-align: top; ddo-c" & _
    "har-set: 1"
        Me.txt長さ.Text = "999,999m"
        Me.txt長さ.Top = 0.4700788!
        Me.txt長さ.Width = 0.511811!
        '
        'txt版No
        '
        Me.txt版No.Height = 0.1574803!
        Me.txt版No.Left = 0.8086614!
        Me.txt版No.Name = "txt版No"
        Me.txt版No.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: justify; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt版No.Text = "版No123456"
        Me.txt版No.Top = 0.9188977!
        Me.txt版No.Width = 0.5976378!
        '
        'txt発送仕上区分名
        '
        Me.txt発送仕上区分名.Height = 0.1968504!
        Me.txt発送仕上区分名.Left = 0.5905512!
        Me.txt発送仕上区分名.Name = "txt発送仕上区分名"
        Me.txt発送仕上区分名.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: justify; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt発送仕上区分名.Text = "発送"
        Me.txt発送仕上区分名.Top = 1.090551!
        Me.txt発送仕上区分名.Width = 0.3149606!
        '
        'txt発送仕上区分
        '
        Me.txt発送仕上区分.Height = 0.1968504!
        Me.txt発送仕上区分.Left = 0.9055119!
        Me.txt発送仕上区分.Name = "txt発送仕上区分"
        Me.txt発送仕上区分.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt発送仕上区分.Text = "●"
        Me.txt発送仕上区分.Top = 1.090551!
        Me.txt発送仕上区分.Width = 0.1968504!
        '
        'txt納品日
        '
        Me.txt納品日.Height = 0.1968504!
        Me.txt納品日.Left = 1.417323!
        Me.txt納品日.Name = "txt納品日"
        Me.txt納品日.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: justify; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt納品日.Text = "納 MM/DD"
        Me.txt納品日.Top = 1.090551!
        Me.txt納品日.Width = 1.215748!
        '
        'txt社内外区分
        '
        Me.txt社内外区分.Height = 0.1968504!
        Me.txt社内外区分.Left = 1.102362!
        Me.txt社内外区分.Name = "txt社内外区分"
        Me.txt社内外区分.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: justify; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt社内外区分.Text = "ああ"
        Me.txt社内外区分.Top = 1.090551!
        Me.txt社内外区分.Width = 0.3149606!
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
        'LabelOrder
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 11.10105!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.txt再新区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt作業No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtユーザー名1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtユーザー名2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt作業注意事項2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt作業注意事項1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt刃型No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt受注日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt長さ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt版No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt発送仕上区分名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt発送仕上区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt納品日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt社内外区分, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txt再新区分 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Barcode As DataDynamics.ActiveReports.Barcode
    Private WithEvents txt作業No As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtユーザー名1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtユーザー名2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt商品名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt作業注意事項2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt作業注意事項1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt通数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt刃型No As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt受注日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt長さ As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt版No As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt発送仕上区分名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt発送仕上区分 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt納品日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt社内外区分 As DataDynamics.ActiveReports.TextBox
End Class
