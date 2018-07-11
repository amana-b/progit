<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class VenderPrfMng
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(VenderPrfMng))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt売上 = New DataDynamics.ActiveReports.TextBox()
        Me.txt単価 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入 = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意CD = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt外注費 = New DataDynamics.ActiveReports.TextBox()
        Me.txt作業No = New DataDynamics.ActiveReports.TextBox()
        Me.txt商品名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt利益率 = New DataDynamics.ActiveReports.TextBox()
        Me.txt固定経費 = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.txtNow = New DataDynamics.ActiveReports.TextBox()
        Me.txt頁 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr = New DataDynamics.ActiveReports.GroupHeader()
        Me.txt対象年月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入先別利益管理表 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl売上 = New DataDynamics.ActiveReports.Label()
        Me.lbl粗利 = New DataDynamics.ActiveReports.Label()
        Me.lbl得意先名 = New DataDynamics.ActiveReports.Label()
        Me.lbl得意CD = New DataDynamics.ActiveReports.Label()
        Me.lbl仕入 = New DataDynamics.ActiveReports.Label()
        Me.lbl外注費 = New DataDynamics.ActiveReports.Label()
        Me.lbl作業No = New DataDynamics.ActiveReports.Label()
        Me.lbl商品名 = New DataDynamics.ActiveReports.Label()
        Me.lbl利益 = New DataDynamics.ActiveReports.Label()
        Me.lbl利益率 = New DataDynamics.ActiveReports.Label()
        Me.lbl仕入先 = New DataDynamics.ActiveReports.Label()
        Me.txt仕入先CD = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入先名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt受注区分 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl固定経費 = New DataDynamics.ActiveReports.Label()
        Me.grpFtr計 = New DataDynamics.ActiveReports.GroupFooter()
        Me.txt合計粗利 = New DataDynamics.ActiveReports.TextBox()
        Me.txt合計外注費 = New DataDynamics.ActiveReports.TextBox()
        Me.txt合計仕入 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox11 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox13 = New DataDynamics.ActiveReports.TextBox()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.TextBox19 = New DataDynamics.ActiveReports.TextBox()
        Me.txt手形合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt合計売上 = New DataDynamics.ActiveReports.TextBox()
        Me.txt合計利益 = New DataDynamics.ActiveReports.TextBox()
        Me.txt合計利益率 = New DataDynamics.ActiveReports.TextBox()
        Me.txt合計固定経費 = New DataDynamics.ActiveReports.TextBox()
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader()
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter()
        Me.txt仕入先利益率 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入先利益 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入先粗利計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入先外注費 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入先仕入計 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox8 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入先売上計 = New DataDynamics.ActiveReports.TextBox()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.txt仕入先固定経費 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.txt売上, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt外注費, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt作業No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt利益率, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt固定経費, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt対象年月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入先別利益管理表, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl売上, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl粗利, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl得意CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl仕入, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl外注費, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl作業No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl利益, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl利益率, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl仕入先, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt受注区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl固定経費, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt合計粗利, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt合計外注費, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt合計仕入, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt手形合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt合計売上, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt合計利益, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt合計利益率, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt合計固定経費, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入先利益率, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入先利益, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入先粗利計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入先外注費, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入先仕入計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入先売上計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入先固定経費, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt売上, Me.txt単価, Me.txt仕入, Me.txt得意CD, Me.txt得意先名, Me.txt外注費, Me.txt作業No, Me.txt商品名, Me.txt金額, Me.txt利益率, Me.txt固定経費})
        Me.Detail.Height = 0.2755905!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.RepeatToFill = True
        '
        'txt売上
        '
        Me.txt売上.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上.Height = 0.2755905!
        Me.txt売上.Left = 4.901575!
        Me.txt売上.Name = "txt売上"
        Me.txt売上.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt売上.Text = "999,999,999"
        Me.txt売上.Top = 0.0!
        Me.txt売上.Width = 0.8464568!
        '
        'txt単価
        '
        Me.txt単価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt単価.Height = 0.2755905!
        Me.txt単価.Left = 7.480315!
        Me.txt単価.Name = "txt単価"
        Me.txt単価.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt単価.Text = "999,999,999"
        Me.txt単価.Top = 0.000001132488!
        Me.txt単価.Width = 0.8661417!
        '
        'txt仕入
        '
        Me.txt仕入.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入.Height = 0.2755905!
        Me.txt仕入.Left = 5.748032!
        Me.txt仕入.Name = "txt仕入"
        Me.txt仕入.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt仕入.Text = "999,999,999"
        Me.txt仕入.Top = 0.0!
        Me.txt仕入.Width = 0.8661417!
        '
        'txt得意CD
        '
        Me.txt得意CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意CD.Height = 0.2755905!
        Me.txt得意CD.Left = 2.440945!
        Me.txt得意CD.Name = "txt得意CD"
        Me.txt得意CD.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.txt得意CD.Text = "123456"
        Me.txt得意CD.Top = 0.00000005960464!
        Me.txt得意CD.Width = 0.492126!
        '
        'txt得意先名
        '
        Me.txt得意先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Height = 0.2755905!
        Me.txt得意先名.Left = 2.933071!
        Me.txt得意先名.Name = "txt得意先名"
        Me.txt得意先名.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: justify; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt得意先名.Text = "あああああいいいいいうううううええええ"
        Me.txt得意先名.Top = 0.0000001192093!
        Me.txt得意先名.Width = 1.968504!
        '
        'txt外注費
        '
        Me.txt外注費.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt外注費.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt外注費.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt外注費.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt外注費.Height = 0.2755905!
        Me.txt外注費.Left = 6.614173!
        Me.txt外注費.Name = "txt外注費"
        Me.txt外注費.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt外注費.Text = "999,999,999"
        Me.txt外注費.Top = 0.0000002980233!
        Me.txt外注費.Width = 0.8661417!
        '
        'txt作業No
        '
        Me.txt作業No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Height = 0.2755905!
        Me.txt作業No.Left = 0.0!
        Me.txt作業No.Name = "txt作業No"
        Me.txt作業No.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.txt作業No.Text = "123456"
        Me.txt作業No.Top = 0.0000002980233!
        Me.txt作業No.Width = 0.472441!
        '
        'txt商品名
        '
        Me.txt商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Height = 0.2755905!
        Me.txt商品名.Left = 0.472441!
        Me.txt商品名.Name = "txt商品名"
        Me.txt商品名.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: left; vertical-align: bottom; ddo" & _
    "-char-set: 1"
        Me.txt商品名.Text = "あああああいいいいいうううううええええ"
        Me.txt商品名.Top = 0.0000005066395!
        Me.txt商品名.Width = 1.968504!
        '
        'txt金額
        '
        Me.txt金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt金額.Height = 0.2755905!
        Me.txt金額.Left = 9.212598!
        Me.txt金額.Name = "txt金額"
        Me.txt金額.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt金額.Text = "999,999,999"
        Me.txt金額.Top = 0.0!
        Me.txt金額.Width = 0.8661417!
        '
        'txt利益率
        '
        Me.txt利益率.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益率.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益率.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益率.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt利益率.Height = 0.2755905!
        Me.txt利益率.Left = 10.07874!
        Me.txt利益率.Name = "txt利益率"
        Me.txt利益率.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt利益率.Text = "99.99"
        Me.txt利益率.Top = 0.0!
        Me.txt利益率.Width = 0.6299213!
        '
        'txt固定経費
        '
        Me.txt固定経費.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt固定経費.Height = 0.2755906!
        Me.txt固定経費.Left = 8.346457!
        Me.txt固定経費.Name = "txt固定経費"
        Me.txt固定経費.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt固定経費.Text = "999,999,999"
        Me.txt固定経費.Top = 0.0!
        Me.txt固定経費.Width = 0.8661417!
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtNow, Me.txt頁})
        Me.PageHeader.Height = 0.2362205!
        Me.PageHeader.Name = "PageHeader"
        '
        'txtNow
        '
        Me.txtNow.Height = 0.2362205!
        Me.txtNow.Left = 7.574792!
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
        Me.txt頁.Left = 9.718505!
        Me.txt頁.Name = "txt頁"
        Me.txt頁.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt頁.Text = "頁"
        Me.txt頁.Top = 0.0!
        Me.txt頁.Width = 0.379528!
        '
        'PageFooter
        '
        Me.PageFooter.CanGrow = False
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'grpHdr
        '
        Me.grpHdr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt対象年月, Me.txt仕入先別利益管理表, Me.lbl売上, Me.lbl粗利, Me.lbl得意先名, Me.lbl得意CD, Me.lbl仕入, Me.lbl外注費, Me.lbl作業No, Me.lbl商品名, Me.lbl利益, Me.lbl利益率, Me.lbl仕入先, Me.txt仕入先CD, Me.txt仕入先名, Me.txt受注区分, Me.lbl固定経費})
        Me.grpHdr.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr.Height = 0.8385828!
        Me.grpHdr.Name = "grpHdr"
        Me.grpHdr.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'txt対象年月
        '
        Me.txt対象年月.Height = 0.2362205!
        Me.txt対象年月.Left = 0.0!
        Me.txt対象年月.Name = "txt対象年月"
        Me.txt対象年月.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt対象年月.Text = "YY/MM月分"
        Me.txt対象年月.Top = 0.0!
        Me.txt対象年月.Width = 1.181102!
        '
        'txt仕入先別利益管理表
        '
        Me.txt仕入先別利益管理表.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt仕入先別利益管理表.Height = 0.2362205!
        Me.txt仕入先別利益管理表.Left = 4.514174!
        Me.txt仕入先別利益管理表.Name = "txt仕入先別利益管理表"
        Me.txt仕入先別利益管理表.Style = "font-family: ＭＳ Ｐゴシック; font-size: 14pt; font-weight: bold; text-align: center; ve" & _
    "rtical-align: bottom; ddo-char-set: 1"
        Me.txt仕入先別利益管理表.Text = "仕入先別利益管理表"
        Me.txt仕入先別利益管理表.Top = 0.1968504!
        Me.txt仕入先別利益管理表.Width = 2.362205!
        '
        'lbl売上
        '
        Me.lbl売上.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl売上.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl売上.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl売上.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl売上.Height = 0.2559055!
        Me.lbl売上.HyperLink = Nothing
        Me.lbl売上.Left = 4.901575!
        Me.lbl売上.Name = "lbl売上"
        Me.lbl売上.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl売上.Text = "売上"
        Me.lbl売上.Top = 0.5826772!
        Me.lbl売上.Width = 0.8464568!
        '
        'lbl粗利
        '
        Me.lbl粗利.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl粗利.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl粗利.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl粗利.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl粗利.Height = 0.2559055!
        Me.lbl粗利.HyperLink = Nothing
        Me.lbl粗利.Left = 7.480315!
        Me.lbl粗利.Name = "lbl粗利"
        Me.lbl粗利.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl粗利.Text = "粗利"
        Me.lbl粗利.Top = 0.5826772!
        Me.lbl粗利.Width = 0.8661417!
        '
        'lbl得意先名
        '
        Me.lbl得意先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.CharacterSpacing = 10.0!
        Me.lbl得意先名.Height = 0.2559055!
        Me.lbl得意先名.HyperLink = Nothing
        Me.lbl得意先名.Left = 2.933071!
        Me.lbl得意先名.Name = "lbl得意先名"
        Me.lbl得意先名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-alig" & _
    "n: middle; ddo-char-set: 1"
        Me.lbl得意先名.Text = "得意先名"
        Me.lbl得意先名.Top = 0.5826772!
        Me.lbl得意先名.Width = 1.968504!
        '
        'lbl得意CD
        '
        Me.lbl得意CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意CD.Height = 0.2559055!
        Me.lbl得意CD.HyperLink = Nothing
        Me.lbl得意CD.Left = 2.440945!
        Me.lbl得意CD.Name = "lbl得意CD"
        Me.lbl得意CD.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl得意CD.Text = "得意CD"
        Me.lbl得意CD.Top = 0.5826772!
        Me.lbl得意CD.Width = 0.492126!
        '
        'lbl仕入
        '
        Me.lbl仕入.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入.Height = 0.2559055!
        Me.lbl仕入.HyperLink = Nothing
        Me.lbl仕入.Left = 5.748032!
        Me.lbl仕入.Name = "lbl仕入"
        Me.lbl仕入.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl仕入.Text = "仕入"
        Me.lbl仕入.Top = 0.5826772!
        Me.lbl仕入.Width = 0.8661417!
        '
        'lbl外注費
        '
        Me.lbl外注費.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl外注費.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl外注費.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl外注費.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl外注費.Height = 0.2559055!
        Me.lbl外注費.HyperLink = Nothing
        Me.lbl外注費.Left = 6.614173!
        Me.lbl外注費.Name = "lbl外注費"
        Me.lbl外注費.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl外注費.Text = "(うち外注費)"
        Me.lbl外注費.Top = 0.5826772!
        Me.lbl外注費.Width = 0.8661417!
        '
        'lbl作業No
        '
        Me.lbl作業No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl作業No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl作業No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl作業No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl作業No.Height = 0.2559055!
        Me.lbl作業No.HyperLink = Nothing
        Me.lbl作業No.Left = 0.0!
        Me.lbl作業No.Name = "lbl作業No"
        Me.lbl作業No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl作業No.Text = "作業No"
        Me.lbl作業No.Top = 0.5826772!
        Me.lbl作業No.Width = 0.472441!
        '
        'lbl商品名
        '
        Me.lbl商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.CharacterSpacing = 10.0!
        Me.lbl商品名.Height = 0.2559055!
        Me.lbl商品名.HyperLink = Nothing
        Me.lbl商品名.Left = 0.472441!
        Me.lbl商品名.Name = "lbl商品名"
        Me.lbl商品名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl商品名.Text = "品名"
        Me.lbl商品名.Top = 0.5826772!
        Me.lbl商品名.Width = 1.968504!
        '
        'lbl利益
        '
        Me.lbl利益.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl利益.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl利益.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl利益.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl利益.Height = 0.2559055!
        Me.lbl利益.HyperLink = Nothing
        Me.lbl利益.Left = 9.212598!
        Me.lbl利益.Name = "lbl利益"
        Me.lbl利益.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl利益.Text = "利益"
        Me.lbl利益.Top = 0.5826772!
        Me.lbl利益.Width = 0.8661417!
        '
        'lbl利益率
        '
        Me.lbl利益率.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl利益率.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl利益率.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl利益率.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl利益率.Height = 0.2559055!
        Me.lbl利益率.HyperLink = Nothing
        Me.lbl利益率.Left = 10.07874!
        Me.lbl利益率.Name = "lbl利益率"
        Me.lbl利益率.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl利益率.Text = "利益率"
        Me.lbl利益率.Top = 0.5826771!
        Me.lbl利益率.Width = 0.6299213!
        '
        'lbl仕入先
        '
        Me.lbl仕入先.Height = 0.2362205!
        Me.lbl仕入先.HyperLink = Nothing
        Me.lbl仕入先.Left = 0.0!
        Me.lbl仕入先.Name = "lbl仕入先"
        Me.lbl仕入先.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl仕入先.Text = "仕入先"
        Me.lbl仕入先.Top = 0.3055118!
        Me.lbl仕入先.Width = 0.7874014!
        '
        'txt仕入先CD
        '
        Me.txt仕入先CD.Height = 0.2362205!
        Me.txt仕入先CD.Left = 0.7874014!
        Me.txt仕入先CD.Name = "txt仕入先CD"
        Me.txt仕入先CD.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt仕入先CD.Text = "123456"
        Me.txt仕入先CD.Top = 0.3055118!
        Me.txt仕入先CD.Width = 0.6763784!
        '
        'txt仕入先名
        '
        Me.txt仕入先名.Height = 0.2362205!
        Me.txt仕入先名.Left = 1.46378!
        Me.txt仕入先名.Name = "txt仕入先名"
        Me.txt仕入先名.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt仕入先名.Text = "あああああいいいいいううううう"
        Me.txt仕入先名.Top = 0.3055118!
        Me.txt仕入先名.Width = 2.503937!
        '
        'txt受注区分
        '
        Me.txt受注区分.Height = 0.2362205!
        Me.txt受注区分.Left = 7.625197!
        Me.txt受注区分.Name = "txt受注区分"
        Me.txt受注区分.Style = "font-family: ＭＳ 明朝; font-size: 12pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt受注区分.Text = "(あああああ)"
        Me.txt受注区分.Top = 0.2149606!
        Me.txt受注区分.Width = 1.181102!
        '
        'lbl固定経費
        '
        Me.lbl固定経費.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl固定経費.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl固定経費.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl固定経費.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl固定経費.Height = 0.2559055!
        Me.lbl固定経費.HyperLink = Nothing
        Me.lbl固定経費.Left = 8.346457!
        Me.lbl固定経費.Name = "lbl固定経費"
        Me.lbl固定経費.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl固定経費.Text = "固定経費"
        Me.lbl固定経費.Top = 0.5826771!
        Me.lbl固定経費.Width = 0.8661417!
        '
        'grpFtr計
        '
        Me.grpFtr計.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt合計粗利, Me.txt合計外注費, Me.txt合計仕入, Me.TextBox11, Me.TextBox13, Me.Label2, Me.TextBox19, Me.txt手形合計, Me.txt合計売上, Me.txt合計利益, Me.txt合計利益率, Me.txt合計固定経費})
        Me.grpFtr計.Height = 0.2755905!
        Me.grpFtr計.Name = "grpFtr計"
        '
        'txt合計粗利
        '
        Me.txt合計粗利.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計粗利.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計粗利.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計粗利.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計粗利.Height = 0.2755905!
        Me.txt合計粗利.Left = 7.480315!
        Me.txt合計粗利.Name = "txt合計粗利"
        Me.txt合計粗利.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt合計粗利.Text = "999,999,999"
        Me.txt合計粗利.Top = 0.0!
        Me.txt合計粗利.Width = 0.8661417!
        '
        'txt合計外注費
        '
        Me.txt合計外注費.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計外注費.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計外注費.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計外注費.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計外注費.Height = 0.2755905!
        Me.txt合計外注費.Left = 6.614173!
        Me.txt合計外注費.Name = "txt合計外注費"
        Me.txt合計外注費.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt合計外注費.Text = "999,999,999"
        Me.txt合計外注費.Top = 0.0000002980233!
        Me.txt合計外注費.Width = 0.8661417!
        '
        'txt合計仕入
        '
        Me.txt合計仕入.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計仕入.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計仕入.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計仕入.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計仕入.Height = 0.2755905!
        Me.txt合計仕入.Left = 5.748032!
        Me.txt合計仕入.Name = "txt合計仕入"
        Me.txt合計仕入.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt合計仕入.Text = "999,999,999"
        Me.txt合計仕入.Top = 0.0000002980233!
        Me.txt合計仕入.Width = 0.8661417!
        '
        'TextBox11
        '
        Me.TextBox11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Height = 0.2755905!
        Me.TextBox11.Left = 2.933071!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox11.Text = Nothing
        Me.TextBox11.Top = 0.0000001192093!
        Me.TextBox11.Width = 1.968504!
        '
        'TextBox13
        '
        Me.TextBox13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Height = 0.2755905!
        Me.TextBox13.Left = 0.472441!
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: left; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox13.Text = Nothing
        Me.TextBox13.Top = 0.0000005066395!
        Me.TextBox13.Width = 1.968504!
        '
        'Label2
        '
        Me.Label2.Height = 0.1771654!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 4.059842!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; font-weight: bold; text-align: " & _
    "right; vertical-align: bottom; ddo-char-set: 1"
        Me.Label2.Text = "＊合計"
        Me.Label2.Top = 0.05118112!
        Me.Label2.Width = 0.7874016!
        '
        'TextBox19
        '
        Me.TextBox19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Height = 0.2755905!
        Me.TextBox19.Left = 2.440945!
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox19.Text = Nothing
        Me.TextBox19.Top = 0.00000005960464!
        Me.TextBox19.Width = 0.492126!
        '
        'txt手形合計
        '
        Me.txt手形合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt手形合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt手形合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt手形合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt手形合計.Height = 0.2755905!
        Me.txt手形合計.Left = 0.0!
        Me.txt手形合計.Name = "txt手形合計"
        Me.txt手形合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt手形合計.Text = Nothing
        Me.txt手形合計.Top = 0.0!
        Me.txt手形合計.Width = 0.472441!
        '
        'txt合計売上
        '
        Me.txt合計売上.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計売上.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計売上.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計売上.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計売上.Height = 0.2755905!
        Me.txt合計売上.Left = 4.901575!
        Me.txt合計売上.Name = "txt合計売上"
        Me.txt合計売上.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt合計売上.Text = "999,999,999"
        Me.txt合計売上.Top = 0.0!
        Me.txt合計売上.Width = 0.8464568!
        '
        'txt合計利益
        '
        Me.txt合計利益.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計利益.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計利益.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計利益.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計利益.Height = 0.2755905!
        Me.txt合計利益.Left = 9.212598!
        Me.txt合計利益.Name = "txt合計利益"
        Me.txt合計利益.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt合計利益.Text = "999,999,999"
        Me.txt合計利益.Top = 0.0!
        Me.txt合計利益.Width = 0.8661417!
        '
        'txt合計利益率
        '
        Me.txt合計利益率.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計利益率.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計利益率.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計利益率.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計利益率.Height = 0.2755905!
        Me.txt合計利益率.Left = 10.07874!
        Me.txt合計利益率.Name = "txt合計利益率"
        Me.txt合計利益率.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt合計利益率.Text = "99.99"
        Me.txt合計利益率.Top = 0.0!
        Me.txt合計利益率.Width = 0.6299213!
        '
        'txt合計固定経費
        '
        Me.txt合計固定経費.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計固定経費.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計固定経費.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計固定経費.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計固定経費.Height = 0.2755906!
        Me.txt合計固定経費.Left = 8.346457!
        Me.txt合計固定経費.Name = "txt合計固定経費"
        Me.txt合計固定経費.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt合計固定経費.Text = "999,999,999"
        Me.txt合計固定経費.Top = 0.0!
        Me.txt合計固定経費.Width = 0.8661417!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Height = 0.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt仕入先利益率, Me.txt仕入先利益, Me.txt仕入先粗利計, Me.txt仕入先外注費, Me.TextBox5, Me.txt仕入先仕入計, Me.TextBox7, Me.TextBox8, Me.TextBox9, Me.txt仕入先売上計, Me.Label1, Me.txt仕入先固定経費})
        Me.GroupFooter1.Height = 0.2755905!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'txt仕入先利益率
        '
        Me.txt仕入先利益率.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先利益率.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先利益率.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先利益率.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先利益率.Height = 0.2755905!
        Me.txt仕入先利益率.Left = 10.07874!
        Me.txt仕入先利益率.Name = "txt仕入先利益率"
        Me.txt仕入先利益率.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt仕入先利益率.Text = "99.99"
        Me.txt仕入先利益率.Top = 0.0!
        Me.txt仕入先利益率.Width = 0.6299213!
        '
        'txt仕入先利益
        '
        Me.txt仕入先利益.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先利益.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先利益.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先利益.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先利益.Height = 0.2755905!
        Me.txt仕入先利益.Left = 9.212598!
        Me.txt仕入先利益.Name = "txt仕入先利益"
        Me.txt仕入先利益.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt仕入先利益.Text = "999,999,999"
        Me.txt仕入先利益.Top = 0.0!
        Me.txt仕入先利益.Width = 0.8661417!
        '
        'txt仕入先粗利計
        '
        Me.txt仕入先粗利計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先粗利計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先粗利計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先粗利計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先粗利計.Height = 0.2755905!
        Me.txt仕入先粗利計.Left = 7.480315!
        Me.txt仕入先粗利計.Name = "txt仕入先粗利計"
        Me.txt仕入先粗利計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt仕入先粗利計.Text = "999,999,999"
        Me.txt仕入先粗利計.Top = 0.0!
        Me.txt仕入先粗利計.Width = 0.8661417!
        '
        'txt仕入先外注費
        '
        Me.txt仕入先外注費.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先外注費.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先外注費.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先外注費.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先外注費.Height = 0.2755905!
        Me.txt仕入先外注費.Left = 6.614173!
        Me.txt仕入先外注費.Name = "txt仕入先外注費"
        Me.txt仕入先外注費.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt仕入先外注費.Text = "999,999,999"
        Me.txt仕入先外注費.Top = 0.0000002980233!
        Me.txt仕入先外注費.Width = 0.8661417!
        '
        'TextBox5
        '
        Me.TextBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Height = 0.2755905!
        Me.TextBox5.Left = 0.472441!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: left; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox5.Text = Nothing
        Me.TextBox5.Top = 0.0000005066395!
        Me.TextBox5.Width = 1.968504!
        '
        'txt仕入先仕入計
        '
        Me.txt仕入先仕入計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先仕入計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先仕入計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先仕入計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先仕入計.Height = 0.2755905!
        Me.txt仕入先仕入計.Left = 5.748032!
        Me.txt仕入先仕入計.Name = "txt仕入先仕入計"
        Me.txt仕入先仕入計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt仕入先仕入計.Text = "999,999,999"
        Me.txt仕入先仕入計.Top = 0.0000002980233!
        Me.txt仕入先仕入計.Width = 0.8661417!
        '
        'TextBox7
        '
        Me.TextBox7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Height = 0.2755905!
        Me.TextBox7.Left = 0.0!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox7.Text = Nothing
        Me.TextBox7.Top = 0.0!
        Me.TextBox7.Width = 0.472441!
        '
        'TextBox8
        '
        Me.TextBox8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Height = 0.2755905!
        Me.TextBox8.Left = 2.933071!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox8.Text = Nothing
        Me.TextBox8.Top = 0.0000001192093!
        Me.TextBox8.Width = 1.968504!
        '
        'TextBox9
        '
        Me.TextBox9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Height = 0.2755905!
        Me.TextBox9.Left = 2.440945!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox9.Text = Nothing
        Me.TextBox9.Top = 0.00000005960464!
        Me.TextBox9.Width = 0.492126!
        '
        'txt仕入先売上計
        '
        Me.txt仕入先売上計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先売上計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先売上計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先売上計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先売上計.Height = 0.2755905!
        Me.txt仕入先売上計.Left = 4.901575!
        Me.txt仕入先売上計.Name = "txt仕入先売上計"
        Me.txt仕入先売上計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt仕入先売上計.Text = "999,999,999"
        Me.txt仕入先売上計.Top = 0.0!
        Me.txt仕入先売上計.Width = 0.8464568!
        '
        'Label1
        '
        Me.Label1.Height = 0.1771654!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 4.054331!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; font-weight: bold; text-align: " & _
    "right; vertical-align: bottom; ddo-char-set: 1"
        Me.Label1.Text = "＊仕入先計"
        Me.Label1.Top = 0.04094489!
        Me.Label1.Width = 0.7874014!
        '
        'txt仕入先固定経費
        '
        Me.txt仕入先固定経費.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先固定経費.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先固定経費.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先固定経費.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先固定経費.Height = 0.2755906!
        Me.txt仕入先固定経費.Left = 8.346457!
        Me.txt仕入先固定経費.Name = "txt仕入先固定経費"
        Me.txt仕入先固定経費.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt仕入先固定経費.Text = "999,999,999"
        Me.txt仕入先固定経費.Top = 0.0!
        Me.txt仕入先固定経費.Width = 0.8661417!
        '
        'VenderPrfMng
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 10.70866!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.grpHdr)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.grpFtr計)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.txt売上, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt外注費, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt作業No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt利益率, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt固定経費, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt対象年月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入先別利益管理表, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl売上, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl粗利, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl得意CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl仕入, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl外注費, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl作業No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl利益, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl利益率, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl仕入先, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt受注区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl固定経費, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt合計粗利, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt合計外注費, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt合計仕入, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt手形合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt合計売上, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt合計利益, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt合計利益率, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt合計固定経費, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入先利益率, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入先利益, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入先粗利計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入先外注費, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入先仕入計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入先売上計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入先固定経費, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txt売上 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt単価 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtNow As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt頁 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt外注費 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt作業No As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt商品名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpHdr As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents txt対象年月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入先別利益管理表 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl売上 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl得意先名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl得意CD As DataDynamics.ActiveReports.Label
    Private WithEvents lbl仕入 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl外注費 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl作業No As DataDynamics.ActiveReports.Label
    Private WithEvents lbl商品名 As DataDynamics.ActiveReports.Label
    Private WithEvents grpFtr計 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txt合計粗利 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt合計外注費 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt合計仕入 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox11 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox13 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox19 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt手形合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl利益 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl粗利 As DataDynamics.ActiveReports.Label
    Private WithEvents txt合計利益 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt利益率 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl利益率 As DataDynamics.ActiveReports.Label
    Private WithEvents txt合計利益率 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl仕入先 As DataDynamics.ActiveReports.Label
    Private WithEvents txt仕入先CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt合計売上 As DataDynamics.ActiveReports.TextBox
    Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txt仕入先利益率 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入先利益 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入先粗利計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入先外注費 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入先仕入計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox8 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入先売上計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents txt受注区分 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl固定経費 As DataDynamics.ActiveReports.Label
    Private WithEvents txt固定経費 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt合計固定経費 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入先固定経費 As DataDynamics.ActiveReports.TextBox
End Class
