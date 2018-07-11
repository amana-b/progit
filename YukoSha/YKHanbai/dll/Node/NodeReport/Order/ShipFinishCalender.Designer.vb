<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ShipFinishCalender
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ShipFinishCalender))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt印刷場所 = New DataDynamics.ActiveReports.TextBox()
        Me.txt作業No = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt商品名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt特記事項 = New DataDynamics.ActiveReports.TextBox()
        Me.txt完了区分 = New DataDynamics.ActiveReports.TextBox()
        Me.txtRC = New DataDynamics.ActiveReports.TextBox()
        Me.txt機械名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt発送仕上区分 = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.txtNow = New DataDynamics.ActiveReports.TextBox()
        Me.txt頁 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader()
        Me.txt場所区分 = New DataDynamics.ActiveReports.TextBox()
        Me.txt発送予定日 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl印刷場所 = New DataDynamics.ActiveReports.Label()
        Me.lbl機械名 = New DataDynamics.ActiveReports.Label()
        Me.lbl作業No = New DataDynamics.ActiveReports.Label()
        Me.lbl得意先名 = New DataDynamics.ActiveReports.Label()
        Me.ｌｂｌ商品名 = New DataDynamics.ActiveReports.Label()
        Me.txt作業準備リスト = New DataDynamics.ActiveReports.TextBox()
        Me.lbl発送仕上区分 = New DataDynamics.ActiveReports.Label()
        Me.lblRC = New DataDynamics.ActiveReports.Label()
        Me.lbl完了区分 = New DataDynamics.ActiveReports.Label()
        Me.txt分類区分 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl特記事項 = New DataDynamics.ActiveReports.Label()
        Me.grpFtr = New DataDynamics.ActiveReports.GroupFooter()
        CType(Me.txt印刷場所, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt作業No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt特記事項, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt完了区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt機械名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt発送仕上区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt場所区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt発送予定日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl印刷場所, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl機械名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl作業No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ｌｂｌ商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt作業準備リスト, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl発送仕上区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblRC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl完了区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt分類区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl特記事項, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt印刷場所, Me.txt作業No, Me.txt得意先名, Me.txt商品名, Me.txt特記事項, Me.txt完了区分, Me.txtRC, Me.txt機械名, Me.txt発送仕上区分})
        Me.Detail.Height = 0.2755905!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.RepeatToFill = True
        '
        'txt印刷場所
        '
        Me.txt印刷場所.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt印刷場所.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt印刷場所.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt印刷場所.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt印刷場所.Height = 0.2755905!
        Me.txt印刷場所.Left = 0.0!
        Me.txt印刷場所.Name = "txt印刷場所"
        Me.txt印刷場所.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt印刷場所.Text = "ああ"
        Me.txt印刷場所.Top = 0.0!
        Me.txt印刷場所.Width = 0.511811!
        '
        'txt作業No
        '
        Me.txt作業No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Height = 0.2755905!
        Me.txt作業No.Left = 1.161417!
        Me.txt作業No.Name = "txt作業No"
        Me.txt作業No.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt作業No.Text = "123456"
        Me.txt作業No.Top = 0.00000005960464!
        Me.txt作業No.Width = 0.5905512!
        '
        'txt得意先名
        '
        Me.txt得意先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Height = 0.2755905!
        Me.txt得意先名.Left = 1.751968!
        Me.txt得意先名.Name = "txt得意先名"
        Me.txt得意先名.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: middle; ddo" & _
    "-char-set: 1"
        Me.txt得意先名.Text = "あああああいいいいいううううう"
        Me.txt得意先名.Top = 0.0000001192093!
        Me.txt得意先名.Width = 1.968504!
        '
        'txt商品名
        '
        Me.txt商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Height = 0.2755905!
        Me.txt商品名.Left = 3.720472!
        Me.txt商品名.Name = "txt商品名"
        Me.txt商品名.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: middle; ddo" & _
    "-char-set: 1"
        Me.txt商品名.Text = "あああああいいいいいううううう"
        Me.txt商品名.Top = 0.00000005960464!
        Me.txt商品名.Width = 1.968504!
        '
        'txt特記事項
        '
        Me.txt特記事項.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt特記事項.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt特記事項.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt特記事項.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt特記事項.Height = 0.2755905!
        Me.txt特記事項.Left = 6.791339!
        Me.txt特記事項.Name = "txt特記事項"
        Me.txt特記事項.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: justify; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt特記事項.Text = "あああああいいいいいうううううえええええおおおおおかかかかか"
        Me.txt特記事項.Top = 0.00000005960464!
        Me.txt特記事項.Width = 4.133858!
        '
        'txt完了区分
        '
        Me.txt完了区分.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt完了区分.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt完了区分.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt完了区分.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt完了区分.Height = 0.2755905!
        Me.txt完了区分.Left = 6.318898!
        Me.txt完了区分.Name = "txt完了区分"
        Me.txt完了区分.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt完了区分.Text = "あああ"
        Me.txt完了区分.Top = 0.00000005960464!
        Me.txt完了区分.Width = 0.472441!
        '
        'txtRC
        '
        Me.txtRC.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtRC.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtRC.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtRC.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtRC.Height = 0.2755905!
        Me.txtRC.Left = 6.023622!
        Me.txtRC.Name = "txtRC"
        Me.txtRC.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txtRC.Text = "●"
        Me.txtRC.Top = 0.00000005960464!
        Me.txtRC.Width = 0.2952756!
        '
        'txt機械名
        '
        Me.txt機械名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt機械名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt機械名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt機械名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt機械名.Height = 0.2755905!
        Me.txt機械名.Left = 0.511811!
        Me.txt機械名.Name = "txt機械名"
        Me.txt機械名.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt機械名.Text = "あああああ"
        Me.txt機械名.Top = 0.00000005960464!
        Me.txt機械名.Width = 0.6496063!
        '
        'txt発送仕上区分
        '
        Me.txt発送仕上区分.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発送仕上区分.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発送仕上区分.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発送仕上区分.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発送仕上区分.Height = 0.2755905!
        Me.txt発送仕上区分.Left = 5.688976!
        Me.txt発送仕上区分.Name = "txt発送仕上区分"
        Me.txt発送仕上区分.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt発送仕上区分.Text = "ああ"
        Me.txt発送仕上区分.Top = 0.0!
        Me.txt発送仕上区分.Width = 0.3346457!
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtNow, Me.txt頁})
        Me.PageHeader.Height = 0.2887137!
        Me.PageHeader.Name = "PageHeader"
        '
        'txtNow
        '
        Me.txtNow.Height = 0.2362205!
        Me.txtNow.Left = 8.188977!
        Me.txtNow.Name = "txtNow"
        Me.txtNow.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txtNow.Text = "YY/MM/DD　123456 作成"
        Me.txtNow.Top = 0.0!
        Me.txtNow.Width = 1.890551!
        '
        'txt頁
        '
        Me.txt頁.Height = 0.2362205!
        Me.txt頁.Left = 10.45551!
        Me.txt頁.Name = "txt頁"
        Me.txt頁.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt頁.Text = "頁"
        Me.txt頁.Top = 0.0!
        Me.txt頁.Width = 0.3795285!
        '
        'PageFooter
        '
        Me.PageFooter.CanGrow = False
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt場所区分, Me.txt発送予定日, Me.lbl印刷場所, Me.lbl機械名, Me.lbl作業No, Me.lbl得意先名, Me.ｌｂｌ商品名, Me.txt作業準備リスト, Me.lbl発送仕上区分, Me.lblRC, Me.lbl完了区分, Me.txt分類区分, Me.lbl特記事項})
        Me.GroupHeader1.Height = 0.988189!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'txt場所区分
        '
        Me.txt場所区分.Height = 0.2362205!
        Me.txt場所区分.Left = 0.07165354!
        Me.txt場所区分.Name = "txt場所区分"
        Me.txt場所区分.Style = "font-family: ＭＳ 明朝; font-size: 12pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt場所区分.Text = "(●●分)"
        Me.txt場所区分.Top = 0.0!
        Me.txt場所区分.Width = 0.9728355!
        '
        'txt発送予定日
        '
        Me.txt発送予定日.Height = 0.2362205!
        Me.txt発送予定日.Left = 0.06141734!
        Me.txt発送予定日.Name = "txt発送予定日"
        Me.txt発送予定日.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt発送予定日.Text = "99年99月99日(●)"
        Me.txt発送予定日.Top = 0.3212598!
        Me.txt発送予定日.Width = 1.431496!
        '
        'lbl印刷場所
        '
        Me.lbl印刷場所.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl印刷場所.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl印刷場所.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl印刷場所.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl印刷場所.Height = 0.3346457!
        Me.lbl印刷場所.HyperLink = Nothing
        Me.lbl印刷場所.Left = 7.450581E-9!
        Me.lbl印刷場所.Name = "lbl印刷場所"
        Me.lbl印刷場所.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl印刷場所.Text = "印刷場所"
        Me.lbl印刷場所.Top = 0.6535431!
        Me.lbl印刷場所.Width = 0.511811!
        '
        'lbl機械名
        '
        Me.lbl機械名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl機械名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl機械名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl機械名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl機械名.Height = 0.3346457!
        Me.lbl機械名.HyperLink = Nothing
        Me.lbl機械名.Left = 0.511811!
        Me.lbl機械名.Name = "lbl機械名"
        Me.lbl機械名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl機械名.Text = "機械名"
        Me.lbl機械名.Top = 0.6535431!
        Me.lbl機械名.Width = 0.6496062!
        '
        'lbl作業No
        '
        Me.lbl作業No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl作業No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl作業No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl作業No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl作業No.Height = 0.3346457!
        Me.lbl作業No.HyperLink = Nothing
        Me.lbl作業No.Left = 1.161417!
        Me.lbl作業No.Name = "lbl作業No"
        Me.lbl作業No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl作業No.Text = "作業No"
        Me.lbl作業No.Top = 0.6535431!
        Me.lbl作業No.Width = 0.5905511!
        '
        'lbl得意先名
        '
        Me.lbl得意先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Height = 0.3346457!
        Me.lbl得意先名.HyperLink = Nothing
        Me.lbl得意先名.Left = 1.751968!
        Me.lbl得意先名.Name = "lbl得意先名"
        Me.lbl得意先名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl得意先名.Text = "得　意　先　名"
        Me.lbl得意先名.Top = 0.6535431!
        Me.lbl得意先名.Width = 1.968504!
        '
        'ｌｂｌ商品名
        '
        Me.ｌｂｌ商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ商品名.Height = 0.3346457!
        Me.ｌｂｌ商品名.HyperLink = Nothing
        Me.ｌｂｌ商品名.Left = 3.720472!
        Me.ｌｂｌ商品名.Name = "ｌｂｌ商品名"
        Me.ｌｂｌ商品名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.ｌｂｌ商品名.Text = "品　名"
        Me.ｌｂｌ商品名.Top = 0.6535431!
        Me.ｌｂｌ商品名.Width = 1.968504!
        '
        'txt作業準備リスト
        '
        Me.txt作業準備リスト.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt作業準備リスト.Height = 0.3149606!
        Me.txt作業準備リスト.Left = 4.070079!
        Me.txt作業準備リスト.Name = "txt作業準備リスト"
        Me.txt作業準備リスト.Style = "font-family: ＭＳ 明朝; font-size: 16pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt作業準備リスト.Text = "発送・仕上予定表(製造分)"
        Me.txt作業準備リスト.Top = 0.2669291!
        Me.txt作業準備リスト.Width = 2.952756!
        '
        'lbl発送仕上区分
        '
        Me.lbl発送仕上区分.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発送仕上区分.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発送仕上区分.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発送仕上区分.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発送仕上区分.Height = 0.3346457!
        Me.lbl発送仕上区分.HyperLink = Nothing
        Me.lbl発送仕上区分.Left = 5.688976!
        Me.lbl発送仕上区分.Name = "lbl発送仕上区分"
        Me.lbl発送仕上区分.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl発送仕上区分.Text = "区分"
        Me.lbl発送仕上区分.Top = 0.6535431!
        Me.lbl発送仕上区分.Width = 0.3346457!
        '
        'lblRC
        '
        Me.lblRC.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblRC.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblRC.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblRC.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblRC.Height = 0.3346457!
        Me.lblRC.HyperLink = Nothing
        Me.lblRC.Left = 6.023622!
        Me.lblRC.Name = "lblRC"
        Me.lblRC.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lblRC.Text = "R/C"
        Me.lblRC.Top = 0.6535431!
        Me.lblRC.Width = 0.2952756!
        '
        'lbl完了区分
        '
        Me.lbl完了区分.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl完了区分.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl完了区分.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl完了区分.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl完了区分.Height = 0.3346457!
        Me.lbl完了区分.HyperLink = Nothing
        Me.lbl完了区分.Left = 6.318899!
        Me.lbl完了区分.Name = "lbl完了区分"
        Me.lbl完了区分.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl完了区分.Text = "完了"
        Me.lbl完了区分.Top = 0.6535431!
        Me.lbl完了区分.Width = 0.472441!
        '
        'txt分類区分
        '
        Me.txt分類区分.Height = 0.2362205!
        Me.txt分類区分.Left = 8.004333!
        Me.txt分類区分.Name = "txt分類区分"
        Me.txt分類区分.Style = "font-family: ＭＳ 明朝; font-size: 12pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt分類区分.Text = "(●●のみ)"
        Me.txt分類区分.Top = 0.3425197!
        Me.txt分類区分.Width = 0.9728355!
        '
        'lbl特記事項
        '
        Me.lbl特記事項.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl特記事項.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl特記事項.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl特記事項.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl特記事項.Height = 0.3346457!
        Me.lbl特記事項.HyperLink = Nothing
        Me.lbl特記事項.Left = 6.791339!
        Me.lbl特記事項.Name = "lbl特記事項"
        Me.lbl特記事項.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: justify; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl特記事項.Text = "　　　　　　　特　　記　　事　　項"
        Me.lbl特記事項.Top = 0.6535431!
        Me.lbl特記事項.Width = 4.133858!
        '
        'grpFtr
        '
        Me.grpFtr.Height = 0.0!
        Me.grpFtr.Name = "grpFtr"
        '
        'ShipFinishCalender
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 10.90551!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.grpFtr)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.txt印刷場所, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt作業No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt特記事項, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt完了区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt機械名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt発送仕上区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt場所区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt発送予定日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl印刷場所, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl機械名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl作業No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ｌｂｌ商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt作業準備リスト, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl発送仕上区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblRC, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl完了区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt分類区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl特記事項, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txt印刷場所 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt作業No As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt商品名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt特記事項 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt完了区分 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtRC As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtNow As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt頁 As DataDynamics.ActiveReports.TextBox
    Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents grpFtr As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txt機械名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt発送仕上区分 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt場所区分 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt発送予定日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl印刷場所 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl機械名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl作業No As DataDynamics.ActiveReports.Label
    Private WithEvents lbl得意先名 As DataDynamics.ActiveReports.Label
    Private WithEvents ｌｂｌ商品名 As DataDynamics.ActiveReports.Label
    Private WithEvents txt作業準備リスト As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl発送仕上区分 As DataDynamics.ActiveReports.Label
    Private WithEvents lblRC As DataDynamics.ActiveReports.Label
    Private WithEvents lbl完了区分 As DataDynamics.ActiveReports.Label
    Private WithEvents txt分類区分 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl特記事項 As DataDynamics.ActiveReports.Label
End Class
