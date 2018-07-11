<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class TaxTotalList
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(TaxTotalList))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt新税率消費税額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt新税率税抜売上額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先CD = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt旧税率消費税額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt旧税率税抜売上額総 = New DataDynamics.ActiveReports.TextBox()
        Me.txt税抜売上合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt消費税額合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt税込売上合計 = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.txtNow = New DataDynamics.ActiveReports.TextBox()
        Me.txt頁 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr = New DataDynamics.ActiveReports.GroupHeader()
        Me.txtHdr対象年月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt消費税計算一覧 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl新税率消費税額 = New DataDynamics.ActiveReports.Label()
        Me.lbl得意先名 = New DataDynamics.ActiveReports.Label()
        Me.lbl得意先CD = New DataDynamics.ActiveReports.Label()
        Me.lbl新税率税抜売上額 = New DataDynamics.ActiveReports.Label()
        Me.lblHdr対象年月 = New DataDynamics.ActiveReports.Label()
        Me.lbl旧税率消費税額 = New DataDynamics.ActiveReports.Label()
        Me.lbl旧税率税抜売上額 = New DataDynamics.ActiveReports.Label()
        Me.lbl税抜売上合計 = New DataDynamics.ActiveReports.Label()
        Me.lbl消費税額合計 = New DataDynamics.ActiveReports.Label()
        Me.lbl税込売上合計 = New DataDynamics.ActiveReports.Label()
        Me.grpFtr計 = New DataDynamics.ActiveReports.GroupFooter()
        Me.txt新税率消費税額総合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt旧税率消費税額総合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt新税率税抜売上額総合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入件数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt税抜売上総合計 = New DataDynamics.ActiveReports.TextBox()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.TextBox19 = New DataDynamics.ActiveReports.TextBox()
        Me.txt旧税率税抜売上額総合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt消費税額総合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt税込売上総合計 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.txt新税率消費税額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt新税率税抜売上額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt旧税率消費税額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt旧税率税抜売上額総, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt税抜売上合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt消費税額合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt税込売上合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr対象年月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt消費税計算一覧, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl新税率消費税額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl得意先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl新税率税抜売上額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr対象年月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl旧税率消費税額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl旧税率税抜売上額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl税抜売上合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl消費税額合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl税込売上合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt新税率消費税額総合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt旧税率消費税額総合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt新税率税抜売上額総合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入件数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt税抜売上総合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt旧税率税抜売上額総合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt消費税額総合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt税込売上総合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt新税率消費税額, Me.txt新税率税抜売上額, Me.txt得意先CD, Me.txt得意先名, Me.txt旧税率消費税額, Me.txt旧税率税抜売上額総, Me.txt税抜売上合計, Me.txt消費税額合計, Me.txt税込売上合計})
        Me.Detail.Height = 0.2755905!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.RepeatToFill = True
        '
        'txt新税率消費税額
        '
        Me.txt新税率消費税額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt新税率消費税額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt新税率消費税額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt新税率消費税額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt新税率消費税額.Height = 0.2755905!
        Me.txt新税率消費税額.Left = 8.326772!
        Me.txt新税率消費税額.Name = "txt新税率消費税額"
        Me.txt新税率消費税額.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt新税率消費税額.Text = "999,999,999"
        Me.txt新税率消費税額.Top = 0.000001132488!
        Me.txt新税率消費税額.Width = 0.7874016!
        '
        'txt新税率税抜売上額
        '
        Me.txt新税率税抜売上額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt新税率税抜売上額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt新税率税抜売上額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt新税率税抜売上額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt新税率税抜売上額.Height = 0.2755905!
        Me.txt新税率税抜売上額.Left = 5.846457!
        Me.txt新税率税抜売上額.Name = "txt新税率税抜売上額"
        Me.txt新税率税抜売上額.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt新税率税抜売上額.Text = "999,999,999"
        Me.txt新税率税抜売上額.Top = 0.0000002980233!
        Me.txt新税率税抜売上額.Width = 0.8267716!
        '
        'txt得意先CD
        '
        Me.txt得意先CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先CD.Height = 0.2755905!
        Me.txt得意先CD.Left = 0.0!
        Me.txt得意先CD.Name = "txt得意先CD"
        Me.txt得意先CD.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.txt得意先CD.Text = "123456"
        Me.txt得意先CD.Top = 0.00000005960464!
        Me.txt得意先CD.Width = 0.511811!
        '
        'txt得意先名
        '
        Me.txt得意先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Height = 0.2755905!
        Me.txt得意先名.Left = 0.511811!
        Me.txt得意先名.Name = "txt得意先名"
        Me.txt得意先名.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: justify; vertical-align: bottom" & _
    "; ddo-char-set: 1"
        Me.txt得意先名.Text = "あああああいいいいい"
        Me.txt得意先名.Top = 0.0000001192093!
        Me.txt得意先名.Width = 4.507874!
        '
        'txt旧税率消費税額
        '
        Me.txt旧税率消費税額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt旧税率消費税額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt旧税率消費税額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt旧税率消費税額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt旧税率消費税額.Height = 0.2755905!
        Me.txt旧税率消費税額.Left = 7.5!
        Me.txt旧税率消費税額.Name = "txt旧税率消費税額"
        Me.txt旧税率消費税額.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt旧税率消費税額.Text = "999,999,999"
        Me.txt旧税率消費税額.Top = 0.0!
        Me.txt旧税率消費税額.Width = 0.8267716!
        '
        'txt旧税率税抜売上額総
        '
        Me.txt旧税率税抜売上額総.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt旧税率税抜売上額総.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt旧税率税抜売上額総.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt旧税率税抜売上額総.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt旧税率税抜売上額総.Height = 0.2755905!
        Me.txt旧税率税抜売上額総.Left = 5.019685!
        Me.txt旧税率税抜売上額総.Name = "txt旧税率税抜売上額総"
        Me.txt旧税率税抜売上額総.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt旧税率税抜売上額総.Text = "999,999,999"
        Me.txt旧税率税抜売上額総.Top = 0.0000002980233!
        Me.txt旧税率税抜売上額総.Width = 0.8267716!
        '
        'txt税抜売上合計
        '
        Me.txt税抜売上合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税抜売上合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税抜売上合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税抜売上合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税抜売上合計.Height = 0.2755905!
        Me.txt税抜売上合計.Left = 6.673228!
        Me.txt税抜売上合計.Name = "txt税抜売上合計"
        Me.txt税抜売上合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt税抜売上合計.Text = "999,999,999"
        Me.txt税抜売上合計.Top = 0.0000005066395!
        Me.txt税抜売上合計.Width = 0.8267716!
        '
        'txt消費税額合計
        '
        Me.txt消費税額合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税額合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税額合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税額合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税額合計.Height = 0.2755905!
        Me.txt消費税額合計.Left = 9.114173!
        Me.txt消費税額合計.Name = "txt消費税額合計"
        Me.txt消費税額合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt消費税額合計.Text = "999,999,999"
        Me.txt消費税額合計.Top = 0.0!
        Me.txt消費税額合計.Width = 0.7874016!
        '
        'txt税込売上合計
        '
        Me.txt税込売上合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税込売上合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税込売上合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税込売上合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税込売上合計.Height = 0.2755905!
        Me.txt税込売上合計.Left = 9.901574!
        Me.txt税込売上合計.Name = "txt税込売上合計"
        Me.txt税込売上合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt税込売上合計.Text = "999,999,999"
        Me.txt税込売上合計.Top = 0.0!
        Me.txt税込売上合計.Width = 0.7874016!
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
        Me.grpHdr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtHdr対象年月, Me.txt消費税計算一覧, Me.lbl新税率消費税額, Me.lbl得意先名, Me.lbl得意先CD, Me.lbl新税率税抜売上額, Me.lblHdr対象年月, Me.lbl旧税率消費税額, Me.lbl旧税率税抜売上額, Me.lbl税抜売上合計, Me.lbl消費税額合計, Me.lbl税込売上合計})
        Me.grpHdr.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr.Height = 0.9992127!
        Me.grpHdr.Name = "grpHdr"
        Me.grpHdr.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'txtHdr対象年月
        '
        Me.txtHdr対象年月.Height = 0.2362205!
        Me.txtHdr対象年月.Left = 0.7874014!
        Me.txtHdr対象年月.Name = "txtHdr対象年月"
        Me.txtHdr対象年月.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txtHdr対象年月.Text = "YY/MM月分"
        Me.txtHdr対象年月.Top = 0.0!
        Me.txtHdr対象年月.Width = 1.181102!
        '
        'txt消費税計算一覧
        '
        Me.txt消費税計算一覧.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt消費税計算一覧.CharacterSpacing = 10.0!
        Me.txt消費税計算一覧.Height = 0.3149606!
        Me.txt消費税計算一覧.Left = 4.514174!
        Me.txt消費税計算一覧.Name = "txt消費税計算一覧"
        Me.txt消費税計算一覧.Style = "font-family: ＭＳ Ｐゴシック; font-size: 14pt; font-weight: bold; text-align: center; ve" & _
    "rtical-align: bottom; ddo-char-set: 1"
        Me.txt消費税計算一覧.Text = "消費税計算一覧"
        Me.txt消費税計算一覧.Top = 0.0!
        Me.txt消費税計算一覧.Width = 2.440945!
        '
        'lbl新税率消費税額
        '
        Me.lbl新税率消費税額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl新税率消費税額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl新税率消費税額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl新税率消費税額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl新税率消費税額.Height = 0.3346457!
        Me.lbl新税率消費税額.HyperLink = Nothing
        Me.lbl新税率消費税額.Left = 8.326773!
        Me.lbl新税率消費税額.Name = "lbl新税率消費税額"
        Me.lbl新税率消費税額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-alig" & _
    "n: middle; ddo-char-set: 1"
        Me.lbl新税率消費税額.Text = " 新税率" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   消費税額"
        Me.lbl新税率消費税額.Top = 0.664567!
        Me.lbl新税率消費税額.Width = 0.7874016!
        '
        'lbl得意先名
        '
        Me.lbl得意先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.CharacterSpacing = 10.0!
        Me.lbl得意先名.Height = 0.3346457!
        Me.lbl得意先名.HyperLink = Nothing
        Me.lbl得意先名.Left = 0.5118115!
        Me.lbl得意先名.Name = "lbl得意先名"
        Me.lbl得意先名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-alig" & _
    "n: middle; ddo-char-set: 1"
        Me.lbl得意先名.Text = "得意先名"
        Me.lbl得意先名.Top = 0.664567!
        Me.lbl得意先名.Width = 4.507874!
        '
        'lbl得意先CD
        '
        Me.lbl得意先CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先CD.Height = 0.3346457!
        Me.lbl得意先CD.HyperLink = Nothing
        Me.lbl得意先CD.Left = 0.0000004768372!
        Me.lbl得意先CD.Name = "lbl得意先CD"
        Me.lbl得意先CD.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl得意先CD.Text = "得意先ｺｰﾄﾞ"
        Me.lbl得意先CD.Top = 0.664567!
        Me.lbl得意先CD.Width = 0.511811!
        '
        'lbl新税率税抜売上額
        '
        Me.lbl新税率税抜売上額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl新税率税抜売上額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl新税率税抜売上額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl新税率税抜売上額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl新税率税抜売上額.Height = 0.3346457!
        Me.lbl新税率税抜売上額.HyperLink = Nothing
        Me.lbl新税率税抜売上額.Left = 5.846457!
        Me.lbl新税率税抜売上額.Name = "lbl新税率税抜売上額"
        Me.lbl新税率税抜売上額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-alig" & _
    "n: middle; ddo-char-set: 1"
        Me.lbl新税率税抜売上額.Text = " 新税率" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " 税抜売上額"
        Me.lbl新税率税抜売上額.Top = 0.664567!
        Me.lbl新税率税抜売上額.Width = 0.8267716!
        '
        'lblHdr対象年月
        '
        Me.lblHdr対象年月.Height = 0.2362205!
        Me.lblHdr対象年月.HyperLink = Nothing
        Me.lblHdr対象年月.Left = 0.0!
        Me.lblHdr対象年月.Name = "lblHdr対象年月"
        Me.lblHdr対象年月.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lblHdr対象年月.Text = "対象年月"
        Me.lblHdr対象年月.Top = 0.0!
        Me.lblHdr対象年月.Width = 0.7874014!
        '
        'lbl旧税率消費税額
        '
        Me.lbl旧税率消費税額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl旧税率消費税額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl旧税率消費税額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl旧税率消費税額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl旧税率消費税額.Height = 0.3346457!
        Me.lbl旧税率消費税額.HyperLink = Nothing
        Me.lbl旧税率消費税額.Left = 7.500001!
        Me.lbl旧税率消費税額.Name = "lbl旧税率消費税額"
        Me.lbl旧税率消費税額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-alig" & _
    "n: middle; ddo-char-set: 1"
        Me.lbl旧税率消費税額.Text = " 旧税率" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   消費税額"
        Me.lbl旧税率消費税額.Top = 0.664567!
        Me.lbl旧税率消費税額.Width = 0.8267716!
        '
        'lbl旧税率税抜売上額
        '
        Me.lbl旧税率税抜売上額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl旧税率税抜売上額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl旧税率税抜売上額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl旧税率税抜売上額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl旧税率税抜売上額.Height = 0.3346457!
        Me.lbl旧税率税抜売上額.HyperLink = Nothing
        Me.lbl旧税率税抜売上額.Left = 5.019686!
        Me.lbl旧税率税抜売上額.Name = "lbl旧税率税抜売上額"
        Me.lbl旧税率税抜売上額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-alig" & _
    "n: middle; ddo-char-set: 1"
        Me.lbl旧税率税抜売上額.Text = " 旧税率" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & " 税抜売上額"
        Me.lbl旧税率税抜売上額.Top = 0.664567!
        Me.lbl旧税率税抜売上額.Width = 0.8267716!
        '
        'lbl税抜売上合計
        '
        Me.lbl税抜売上合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl税抜売上合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl税抜売上合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl税抜売上合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl税抜売上合計.Height = 0.3346457!
        Me.lbl税抜売上合計.HyperLink = Nothing
        Me.lbl税抜売上合計.Left = 6.673229!
        Me.lbl税抜売上合計.Name = "lbl税抜売上合計"
        Me.lbl税抜売上合計.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-alig" & _
    "n: middle; ddo-char-set: 1"
        Me.lbl税抜売上合計.Text = " 税抜" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  売上合計"
        Me.lbl税抜売上合計.Top = 0.664567!
        Me.lbl税抜売上合計.Width = 0.8267716!
        '
        'lbl消費税額合計
        '
        Me.lbl消費税額合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl消費税額合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl消費税額合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl消費税額合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl消費税額合計.Height = 0.3346457!
        Me.lbl消費税額合計.HyperLink = Nothing
        Me.lbl消費税額合計.Left = 9.114174!
        Me.lbl消費税額合計.Name = "lbl消費税額合計"
        Me.lbl消費税額合計.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-alig" & _
    "n: middle; ddo-char-set: 1"
        Me.lbl消費税額合計.Text = " 消費税額" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     合計"
        Me.lbl消費税額合計.Top = 0.664567!
        Me.lbl消費税額合計.Width = 0.7874016!
        '
        'lbl税込売上合計
        '
        Me.lbl税込売上合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl税込売上合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl税込売上合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl税込売上合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl税込売上合計.Height = 0.3346457!
        Me.lbl税込売上合計.HyperLink = Nothing
        Me.lbl税込売上合計.Left = 9.901575!
        Me.lbl税込売上合計.Name = "lbl税込売上合計"
        Me.lbl税込売上合計.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-alig" & _
    "n: middle; ddo-char-set: 1"
        Me.lbl税込売上合計.Text = " 税込" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "  売上合計"
        Me.lbl税込売上合計.Top = 0.6661418!
        Me.lbl税込売上合計.Width = 0.7874016!
        '
        'grpFtr計
        '
        Me.grpFtr計.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt新税率消費税額総合計, Me.txt旧税率消費税額総合計, Me.txt新税率税抜売上額総合計, Me.txt仕入件数, Me.txt税抜売上総合計, Me.Label2, Me.TextBox19, Me.txt旧税率税抜売上額総合計, Me.txt消費税額総合計, Me.txt税込売上総合計})
        Me.grpFtr計.Height = 0.2755905!
        Me.grpFtr計.Name = "grpFtr計"
        '
        'txt新税率消費税額総合計
        '
        Me.txt新税率消費税額総合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt新税率消費税額総合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt新税率消費税額総合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt新税率消費税額総合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt新税率消費税額総合計.Height = 0.2755905!
        Me.txt新税率消費税額総合計.Left = 8.326772!
        Me.txt新税率消費税額総合計.Name = "txt新税率消費税額総合計"
        Me.txt新税率消費税額総合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt新税率消費税額総合計.Text = "999,999,999"
        Me.txt新税率消費税額総合計.Top = 0.0!
        Me.txt新税率消費税額総合計.Width = 0.7874016!
        '
        'txt旧税率消費税額総合計
        '
        Me.txt旧税率消費税額総合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt旧税率消費税額総合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt旧税率消費税額総合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt旧税率消費税額総合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt旧税率消費税額総合計.Height = 0.2755905!
        Me.txt旧税率消費税額総合計.Left = 7.5!
        Me.txt旧税率消費税額総合計.Name = "txt旧税率消費税額総合計"
        Me.txt旧税率消費税額総合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt旧税率消費税額総合計.Text = "999,999,999"
        Me.txt旧税率消費税額総合計.Top = 0.0!
        Me.txt旧税率消費税額総合計.Width = 0.8267716!
        '
        'txt新税率税抜売上額総合計
        '
        Me.txt新税率税抜売上額総合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt新税率税抜売上額総合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt新税率税抜売上額総合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt新税率税抜売上額総合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt新税率税抜売上額総合計.Height = 0.2755905!
        Me.txt新税率税抜売上額総合計.Left = 5.846457!
        Me.txt新税率税抜売上額総合計.Name = "txt新税率税抜売上額総合計"
        Me.txt新税率税抜売上額総合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt新税率税抜売上額総合計.Text = "999,999,999"
        Me.txt新税率税抜売上額総合計.Top = 0.0000002980233!
        Me.txt新税率税抜売上額総合計.Width = 0.8267716!
        '
        'txt仕入件数
        '
        Me.txt仕入件数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入件数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入件数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入件数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入件数.Height = 0.2755905!
        Me.txt仕入件数.Left = 0.511811!
        Me.txt仕入件数.Name = "txt仕入件数"
        Me.txt仕入件数.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt仕入件数.Text = "件"
        Me.txt仕入件数.Top = 0.0000001192093!
        Me.txt仕入件数.Width = 4.507874!
        '
        'txt税抜売上総合計
        '
        Me.txt税抜売上総合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税抜売上総合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税抜売上総合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税抜売上総合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税抜売上総合計.Height = 0.2755905!
        Me.txt税抜売上総合計.Left = 6.673228!
        Me.txt税抜売上総合計.Name = "txt税抜売上総合計"
        Me.txt税抜売上総合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt税抜売上総合計.Text = "999,999,999"
        Me.txt税抜売上総合計.Top = 0.0000005066395!
        Me.txt税抜売上総合計.Width = 0.8267716!
        '
        'Label2
        '
        Me.Label2.Height = 0.1771654!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 2.964567!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; font-weight: bold; text-align: " & _
    "right; vertical-align: bottom; ddo-char-set: 1"
        Me.Label2.Text = "＊総合計"
        Me.Label2.Top = 0.05118111!
        Me.Label2.Width = 0.7874016!
        '
        'TextBox19
        '
        Me.TextBox19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Height = 0.2755905!
        Me.TextBox19.Left = 0.0!
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox19.Text = Nothing
        Me.TextBox19.Top = 0.00000005960464!
        Me.TextBox19.Width = 0.511811!
        '
        'txt旧税率税抜売上額総合計
        '
        Me.txt旧税率税抜売上額総合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt旧税率税抜売上額総合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt旧税率税抜売上額総合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt旧税率税抜売上額総合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt旧税率税抜売上額総合計.Height = 0.2755905!
        Me.txt旧税率税抜売上額総合計.Left = 5.019685!
        Me.txt旧税率税抜売上額総合計.Name = "txt旧税率税抜売上額総合計"
        Me.txt旧税率税抜売上額総合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt旧税率税抜売上額総合計.Text = "999,999,999"
        Me.txt旧税率税抜売上額総合計.Top = 0.0!
        Me.txt旧税率税抜売上額総合計.Width = 0.8267716!
        '
        'txt消費税額総合計
        '
        Me.txt消費税額総合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税額総合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税額総合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税額総合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税額総合計.Height = 0.2755905!
        Me.txt消費税額総合計.Left = 9.114173!
        Me.txt消費税額総合計.Name = "txt消費税額総合計"
        Me.txt消費税額総合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt消費税額総合計.Text = "999,999,999"
        Me.txt消費税額総合計.Top = 0.0!
        Me.txt消費税額総合計.Width = 0.7874016!
        '
        'txt税込売上総合計
        '
        Me.txt税込売上総合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税込売上総合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税込売上総合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税込売上総合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税込売上総合計.Height = 0.2755905!
        Me.txt税込売上総合計.Left = 9.901574!
        Me.txt税込売上総合計.Name = "txt税込売上総合計"
        Me.txt税込売上総合計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt税込売上総合計.Text = "999,999,999"
        Me.txt税込売上総合計.Top = 0.0!
        Me.txt税込売上総合計.Width = 0.7874016!
        '
        'TaxTotalList
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 10.68898!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.grpHdr)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.grpFtr計)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.txt新税率消費税額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt新税率税抜売上額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt旧税率消費税額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt旧税率税抜売上額総, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt税抜売上合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt消費税額合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt税込売上合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr対象年月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt消費税計算一覧, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl新税率消費税額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl得意先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl新税率税抜売上額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr対象年月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl旧税率消費税額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl旧税率税抜売上額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl税抜売上合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl消費税額合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl税込売上合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt新税率消費税額総合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt旧税率消費税額総合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt新税率税抜売上額総合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入件数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt税抜売上総合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt旧税率税抜売上額総合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt消費税額総合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt税込売上総合計, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txt新税率消費税額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt新税率税抜売上額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意先CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtNow As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt頁 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt旧税率消費税額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt旧税率税抜売上額総 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt税抜売上合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpHdr As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents txtHdr対象年月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt消費税計算一覧 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl得意先名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl得意先CD As DataDynamics.ActiveReports.Label
    Private WithEvents lbl新税率税抜売上額 As DataDynamics.ActiveReports.Label
    Private WithEvents lblHdr対象年月 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl旧税率消費税額 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl旧税率税抜売上額 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl税抜売上合計 As DataDynamics.ActiveReports.Label
    Private WithEvents grpFtr計 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txt新税率消費税額総合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt旧税率消費税額総合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt新税率税抜売上額総合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入件数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt税抜売上総合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox19 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt旧税率税抜売上額総合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt消費税額合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl消費税額合計 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl新税率消費税額 As DataDynamics.ActiveReports.Label
    Private WithEvents txt消費税額総合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt税込売上合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl税込売上合計 As DataDynamics.ActiveReports.Label
    Private WithEvents txt税込売上総合計 As DataDynamics.ActiveReports.TextBox
End Class
