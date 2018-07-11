<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class BancdorInvoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BancdorInvoice))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt税込請求額 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox22 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox41 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox60 = New DataDynamics.ActiveReports.TextBox()
        Me.txt請求宛名 = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.txt郵便番号 = New DataDynamics.ActiveReports.TextBox()
        Me.txt会社名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt住所 = New DataDynamics.ActiveReports.TextBox()
        Me.txt電話番号他 = New DataDynamics.ActiveReports.TextBox()
        Me.txt銀行名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt口座名義 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl銀行振込 = New DataDynamics.ActiveReports.Label()
        Me.lbl預金口座 = New DataDynamics.ActiveReports.Label()
        Me.txt支店名 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl口座名義 = New DataDynamics.ActiveReports.Label()
        Me.txt預金口座名 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl会社名 = New DataDynamics.ActiveReports.Label()
        Me.txt法人名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt預金口座No = New DataDynamics.ActiveReports.TextBox()
        Me.Label24 = New DataDynamics.ActiveReports.Label()
        Me.Label25 = New DataDynamics.ActiveReports.Label()
        Me.Label26 = New DataDynamics.ActiveReports.Label()
        Me.grpHdr作業No = New DataDynamics.ActiveReports.GroupHeader()
        Me.ｌｂｌ取引先コードNo = New DataDynamics.ActiveReports.Label()
        Me.txt取引先コードNo = New DataDynamics.ActiveReports.TextBox()
        Me.txtHdr会社名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt請求年月 = New DataDynamics.ActiveReports.TextBox()
        Me.Line25 = New DataDynamics.ActiveReports.Line()
        Me.txtHdr法人名 = New DataDynamics.ActiveReports.TextBox()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.lbl請求明細書 = New DataDynamics.ActiveReports.Label()
        Me.txt請求年月度 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl請求書宛名 = New DataDynamics.ActiveReports.Label()
        Me.lbl税込請求額 = New DataDynamics.ActiveReports.Label()
        Me.lbl2 = New DataDynamics.ActiveReports.Label()
        Me.lbl1 = New DataDynamics.ActiveReports.Label()
        Me.lbl3 = New DataDynamics.ActiveReports.Label()
        Me.grpFtr = New DataDynamics.ActiveReports.GroupFooter()
        Me.lbl合計 = New DataDynamics.ActiveReports.Label()
        Me.txt合計 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox40 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox59 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox78 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.txt税込請求額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox60, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt請求宛名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt郵便番号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt会社名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt住所, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt電話番号他, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt銀行名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt口座名義, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl銀行振込, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl預金口座, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt支店名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl口座名義, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt預金口座名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl会社名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt法人名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt預金口座No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ｌｂｌ取引先コードNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt取引先コードNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr会社名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt請求年月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr法人名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl請求明細書, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt請求年月度, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl請求書宛名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl税込請求額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox59, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox78, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt税込請求額, Me.TextBox22, Me.TextBox41, Me.TextBox60, Me.txt請求宛名})
        Me.Detail.Height = 0.3346457!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        '
        'txt税込請求額
        '
        Me.txt税込請求額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税込請求額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税込請求額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税込請求額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税込請求額.Height = 0.3346457!
        Me.txt税込請求額.Left = 1.318898!
        Me.txt税込請求額.Name = "txt税込請求額"
        Me.txt税込請求額.Style = "font-family: ＭＳ 明朝; font-size: 12pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt税込請求額.Text = "999,999"
        Me.txt税込請求額.Top = 0.0!
        Me.txt税込請求額.Width = 1.555118!
        '
        'TextBox22
        '
        Me.TextBox22.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox22.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox22.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox22.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox22.Height = 0.3346457!
        Me.TextBox22.Left = 2.874011!
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.TextBox22.Text = Nothing
        Me.TextBox22.Top = 0.000002861023!
        Me.TextBox22.Width = 1.338583!
        '
        'TextBox41
        '
        Me.TextBox41.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox41.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox41.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox41.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox41.Height = 0.3346457!
        Me.TextBox41.Left = 4.212599!
        Me.TextBox41.Name = "TextBox41"
        Me.TextBox41.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.TextBox41.Text = Nothing
        Me.TextBox41.Top = 0.000002861023!
        Me.TextBox41.Width = 1.338583!
        '
        'TextBox60
        '
        Me.TextBox60.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox60.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox60.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox60.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox60.Height = 0.3346457!
        Me.TextBox60.Left = 5.551176!
        Me.TextBox60.Name = "TextBox60"
        Me.TextBox60.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.TextBox60.Text = Nothing
        Me.TextBox60.Top = 0.000002861023!
        Me.TextBox60.Width = 1.377953!
        '
        'txt請求宛名
        '
        Me.txt請求宛名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt請求宛名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt請求宛名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt請求宛名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt請求宛名.Height = 0.3346457!
        Me.txt請求宛名.Left = 0.0!
        Me.txt請求宛名.Name = "txt請求宛名"
        Me.txt請求宛名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt請求宛名.Text = "あああああいいいい"
        Me.txt請求宛名.Top = 0.0!
        Me.txt請求宛名.Width = 1.318898!
        '
        'PageHeader
        '
        Me.PageHeader.Height = 0.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'PageFooter
        '
        Me.PageFooter.CanGrow = False
        Me.PageFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt郵便番号, Me.txt会社名, Me.txt住所, Me.txt電話番号他, Me.txt銀行名, Me.txt口座名義, Me.lbl銀行振込, Me.lbl預金口座, Me.txt支店名, Me.lbl口座名義, Me.txt預金口座名, Me.lbl会社名, Me.txt法人名, Me.txt預金口座No, Me.Label24, Me.Label25, Me.Label26, Me.TextBox1})
        Me.PageFooter.Height = 2.992126!
        Me.PageFooter.Name = "PageFooter"
        '
        'txt郵便番号
        '
        Me.txt郵便番号.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt郵便番号.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt郵便番号.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt郵便番号.Height = 0.1968504!
        Me.txt郵便番号.Left = 0.3149606!
        Me.txt郵便番号.Name = "txt郵便番号"
        Me.txt郵便番号.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt郵便番号.Text = "〒177-0032"
        Me.txt郵便番号.Top = 0.1129932!
        Me.txt郵便番号.Width = 3.267717!
        '
        'txt会社名
        '
        Me.txt会社名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt会社名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt会社名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt会社名.Height = 0.4330709!
        Me.txt会社名.Left = 1.220472!
        Me.txt会社名.Name = "txt会社名"
        Me.txt会社名.Style = "font-family: ＭＳ 明朝; font-size: 18pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt会社名.Text = "　 友　功　社"
        Me.txt会社名.Top = 0.5066938!
        Me.txt会社名.Width = 2.362205!
        '
        'txt住所
        '
        Me.txt住所.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt住所.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt住所.CharacterSpacing = 3.0!
        Me.txt住所.Height = 0.1968504!
        Me.txt住所.Left = 0.3149606!
        Me.txt住所.Name = "txt住所"
        Me.txt住所.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt住所.Text = " 東京都練馬区谷原３－２４－１"
        Me.txt住所.Top = 0.3098402!
        Me.txt住所.Width = 3.267717!
        '
        'txt電話番号他
        '
        Me.txt電話番号他.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt電話番号他.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt電話番号他.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt電話番号他.Height = 0.3346457!
        Me.txt電話番号他.Left = 0.0!
        Me.txt電話番号他.Name = "txt電話番号他"
        Me.txt電話番号他.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt電話番号他.Text = "TEL 　  (3996) 5333"
        Me.txt電話番号他.Top = 0.939764!
        Me.txt電話番号他.Width = 1.791339!
        '
        'txt銀行名
        '
        Me.txt銀行名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt銀行名.Height = 0.3149606!
        Me.txt銀行名.Left = 4.343307!
        Me.txt銀行名.Name = "txt銀行名"
        Me.txt銀行名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt銀行名.Text = "あああああ銀行"
        Me.txt銀行名.Top = 0.3240137!
        Me.txt銀行名.Width = 1.377953!
        '
        'txt口座名義
        '
        Me.txt口座名義.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt口座名義.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt口座名義.Height = 0.3149606!
        Me.txt口座名義.Left = 4.894489!
        Me.txt口座名義.Name = "txt口座名義"
        Me.txt口座名義.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt口座名義.Text = "あああああ"
        Me.txt口座名義.Top = 0.9539375!
        Me.txt口座名義.Width = 2.007874!
        '
        'lbl銀行振込
        '
        Me.lbl銀行振込.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl銀行振込.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl銀行振込.Height = 0.3149606!
        Me.lbl銀行振込.HyperLink = Nothing
        Me.lbl銀行振込.Left = 3.910237!
        Me.lbl銀行振込.Name = "lbl銀行振込"
        Me.lbl銀行振込.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lbl銀行振込.Text = ""
        Me.lbl銀行振込.Top = 0.3240137!
        Me.lbl銀行振込.Width = 0.4330709!
        '
        'lbl預金口座
        '
        Me.lbl預金口座.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl預金口座.Height = 0.3149606!
        Me.lbl預金口座.HyperLink = Nothing
        Me.lbl預金口座.Left = 3.910238!
        Me.lbl預金口座.Name = "lbl預金口座"
        Me.lbl預金口座.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lbl預金口座.Text = ""
        Me.lbl預金口座.Top = 0.638979!
        Me.lbl預金口座.Width = 0.4330709!
        '
        'txt支店名
        '
        Me.txt支店名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt支店名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt支店名.Height = 0.3149606!
        Me.txt支店名.Left = 5.72126!
        Me.txt支店名.Name = "txt支店名"
        Me.txt支店名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt支店名.Text = "あああああ支店"
        Me.txt支店名.Top = 0.3240137!
        Me.txt支店名.Width = 1.181102!
        '
        'lbl口座名義
        '
        Me.lbl口座名義.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl口座名義.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl口座名義.Height = 0.3149606!
        Me.lbl口座名義.HyperLink = Nothing
        Me.lbl口座名義.Left = 3.910238!
        Me.lbl口座名義.Name = "lbl口座名義"
        Me.lbl口座名義.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lbl口座名義.Text = "口座名義"
        Me.lbl口座名義.Top = 0.9539375!
        Me.lbl口座名義.Width = 0.9842521!
        '
        'txt預金口座名
        '
        Me.txt預金口座名.Height = 0.3149606!
        Me.txt預金口座名.Left = 4.343309!
        Me.txt預金口座名.Name = "txt預金口座名"
        Me.txt預金口座名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt預金口座名.Text = "あああ"
        Me.txt預金口座名.Top = 0.638979!
        Me.txt預金口座名.Width = 0.7874014!
        '
        'lbl会社名
        '
        Me.lbl会社名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl会社名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl会社名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl会社名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl会社名.Height = 0.8267716!
        Me.lbl会社名.HyperLink = Nothing
        Me.lbl会社名.Left = 0.0!
        Me.lbl会社名.Name = "lbl会社名"
        Me.lbl会社名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl会社名.Text = "社" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "名"
        Me.lbl会社名.Top = 0.1129932!
        Me.lbl会社名.Width = 0.3149606!
        '
        'txt法人名
        '
        Me.txt法人名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt法人名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt法人名.Height = 0.4330709!
        Me.txt法人名.Left = 0.3149607!
        Me.txt法人名.Name = "txt法人名"
        Me.txt法人名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt法人名.Text = "株 式 会 社"
        Me.txt法人名.Top = 0.5066938!
        Me.txt法人名.Width = 0.9055118!
        '
        'txt預金口座No
        '
        Me.txt預金口座No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt預金口座No.Height = 0.3149606!
        Me.txt預金口座No.Left = 5.130711!
        Me.txt預金口座No.Name = "txt預金口座No"
        Me.txt預金口座No.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt預金口座No.Text = "No.123456"
        Me.txt預金口座No.Top = 0.638979!
        Me.txt預金口座No.Width = 1.771654!
        '
        'Label24
        '
        Me.Label24.Height = 0.2362205!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 3.731496!
        Me.Label24.Name = "Label24"
        Me.Label24.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-ali" & _
    "gn: bottom; ddo-char-set: 1"
        Me.Label24.Text = "☆振込先"
        Me.Label24.Top = 0.0!
        Me.Label24.Width = 0.9055118!
        '
        'Label25
        '
        Me.Label25.Height = 0.2362205!
        Me.Label25.HyperLink = Nothing
        Me.Label25.Left = 3.326772!
        Me.Label25.Name = "Label25"
        Me.Label25.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 12pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.Label25.Text = "印"
        Me.Label25.Top = 0.6830692!
        Me.Label25.Width = 0.2362205!
        '
        'Label26
        '
        Me.Label26.Height = 1.574803!
        Me.Label26.HyperLink = Nothing
        Me.Label26.Left = 0.0!
        Me.Label26.LineSpacing = 3.0!
        Me.Label26.Name = "Label26"
        Me.Label26.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10.5pt; text-align: left; vertical-a" & _
    "lign: top; ddo-char-set: 1"
        Me.Label26.Text = resources.GetString("Label26.Text")
        Me.Label26.Top = 1.37441!
        Me.Label26.Width = 6.629921!
        '
        'grpHdr作業No
        '
        Me.grpHdr作業No.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.ｌｂｌ取引先コードNo, Me.txt取引先コードNo, Me.txtHdr会社名, Me.txt請求年月, Me.Line25, Me.txtHdr法人名, Me.Label1, Me.lbl請求明細書, Me.txt請求年月度, Me.lbl請求書宛名, Me.lbl税込請求額, Me.lbl2, Me.lbl1, Me.lbl3})
        Me.grpHdr作業No.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr作業No.Height = 1.897244!
        Me.grpHdr作業No.Name = "grpHdr作業No"
        Me.grpHdr作業No.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'ｌｂｌ取引先コードNo
        '
        Me.ｌｂｌ取引先コードNo.Height = 0.2362205!
        Me.ｌｂｌ取引先コードNo.HyperLink = Nothing
        Me.ｌｂｌ取引先コードNo.Left = 4.666142!
        Me.ｌｂｌ取引先コードNo.Name = "ｌｂｌ取引先コードNo"
        Me.ｌｂｌ取引先コードNo.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.ｌｂｌ取引先コードNo.Text = "取引先コードNo."
        Me.ｌｂｌ取引先コードNo.Top = 0.4874016!
        Me.ｌｂｌ取引先コードNo.Width = 1.202362!
        '
        'txt取引先コードNo
        '
        Me.txt取引先コードNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt取引先コードNo.Height = 0.2362205!
        Me.txt取引先コードNo.Left = 5.868505!
        Me.txt取引先コードNo.Name = "txt取引先コードNo"
        Me.txt取引先コードNo.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt取引先コードNo.Text = "123456"
        Me.txt取引先コードNo.Top = 0.4874016!
        Me.txt取引先コードNo.Width = 0.984252!
        '
        'txtHdr会社名
        '
        Me.txtHdr会社名.Height = 0.3937008!
        Me.txtHdr会社名.Left = 5.529922!
        Me.txtHdr会社名.Name = "txtHdr会社名"
        Me.txtHdr会社名.Style = "font-family: ＭＳ 明朝; font-size: 14pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txtHdr会社名.Text = "友　功　社"
        Me.txtHdr会社名.Top = 0.9346457!
        Me.txtHdr会社名.Width = 1.299213!
        '
        'txt請求年月
        '
        Me.txt請求年月.Height = 0.1968504!
        Me.txt請求年月.Left = 5.284252!
        Me.txt請求年月.Name = "txt請求年月"
        Me.txt請求年月.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt請求年月.Text = "平成99年99月99日"
        Me.txt請求年月.Top = 0.0!
        Me.txt請求年月.Width = 1.574803!
        '
        'Line25
        '
        Me.Line25.Height = 0.0!
        Me.Line25.Left = 4.885826!
        Me.Line25.LineWeight = 3.0!
        Me.Line25.Name = "Line25"
        Me.Line25.Top = 1.362205!
        Me.Line25.Width = 1.963781!
        Me.Line25.X1 = 6.849607!
        Me.Line25.X2 = 4.885826!
        Me.Line25.Y1 = 1.362205!
        Me.Line25.Y2 = 1.362205!
        '
        'txtHdr法人名
        '
        Me.txtHdr法人名.Height = 0.1968504!
        Me.txtHdr法人名.Left = 4.901575!
        Me.txtHdr法人名.Name = "txtHdr法人名"
        Me.txtHdr法人名.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtHdr法人名.Text = "株式会社"
        Me.txtHdr法人名.Top = 1.130709!
        Me.txtHdr法人名.Width = 0.6299213!
        '
        'Label1
        '
        Me.Label1.Height = 0.1968504!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 4.4!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.Label1.Text = "社　名"
        Me.Label1.Top = 1.130709!
        Me.Label1.Width = 0.511811!
        '
        'lbl請求明細書
        '
        Me.lbl請求明細書.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl請求明細書.Height = 0.3937007!
        Me.lbl請求明細書.HyperLink = Nothing
        Me.lbl請求明細書.Left = 1.377953!
        Me.lbl請求明細書.Name = "lbl請求明細書"
        Me.lbl請求明細書.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 20pt; font-weight: bold; text-align:" & _
    " center; vertical-align: middle; ddo-char-set: 1"
        Me.lbl請求明細書.Text = "請　求　書"
        Me.lbl請求明細書.Top = 0.0!
        Me.lbl請求明細書.Width = 2.834646!
        '
        'txt請求年月度
        '
        Me.txt請求年月度.Height = 0.1968504!
        Me.txt請求年月度.Left = 0.2047244!
        Me.txt請求年月度.Name = "txt請求年月度"
        Me.txt請求年月度.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.txt請求年月度.Text = "平成99年99月度"
        Me.txt請求年月度.Top = 1.210236!
        Me.txt請求年月度.Width = 1.377953!
        '
        'lbl請求書宛名
        '
        Me.lbl請求書宛名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl請求書宛名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl請求書宛名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl請求書宛名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl請求書宛名.Height = 0.3149606!
        Me.lbl請求書宛名.HyperLink = Nothing
        Me.lbl請求書宛名.Left = 0.0!
        Me.lbl請求書宛名.Name = "lbl請求書宛名"
        Me.lbl請求書宛名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl請求書宛名.Text = "請求書宛名"
        Me.lbl請求書宛名.Top = 1.617719!
        Me.lbl請求書宛名.Width = 1.318898!
        '
        'lbl税込請求額
        '
        Me.lbl税込請求額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl税込請求額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl税込請求額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl税込請求額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl税込請求額.Height = 0.3149606!
        Me.lbl税込請求額.HyperLink = Nothing
        Me.lbl税込請求額.Left = 1.318892!
        Me.lbl税込請求額.Name = "lbl税込請求額"
        Me.lbl税込請求額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl税込請求額.Text = "税込請求額"
        Me.lbl税込請求額.Top = 1.617719!
        Me.lbl税込請求額.Width = 1.555118!
        '
        'lbl2
        '
        Me.lbl2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl2.Height = 0.3149606!
        Me.lbl2.HyperLink = Nothing
        Me.lbl2.Left = 4.212593!
        Me.lbl2.Name = "lbl2"
        Me.lbl2.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl2.Text = ""
        Me.lbl2.Top = 1.617719!
        Me.lbl2.Width = 1.338583!
        '
        'lbl1
        '
        Me.lbl1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl1.Height = 0.3149606!
        Me.lbl1.HyperLink = Nothing
        Me.lbl1.Left = 2.87401!
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl1.Text = ""
        Me.lbl1.Top = 1.617719!
        Me.lbl1.Width = 1.338583!
        '
        'lbl3
        '
        Me.lbl3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl3.Height = 0.3149606!
        Me.lbl3.HyperLink = Nothing
        Me.lbl3.Left = 5.551176!
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl3.Text = ""
        Me.lbl3.Top = 1.617719!
        Me.lbl3.Width = 1.377953!
        '
        'grpFtr
        '
        Me.grpFtr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lbl合計, Me.txt合計, Me.TextBox40, Me.TextBox59, Me.TextBox78})
        Me.grpFtr.Height = 0.3346457!
        Me.grpFtr.Name = "grpFtr"
        '
        'lbl合計
        '
        Me.lbl合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl合計.CharacterSpacing = 30.0!
        Me.lbl合計.Height = 0.3346457!
        Me.lbl合計.HyperLink = Nothing
        Me.lbl合計.Left = 0.0!
        Me.lbl合計.Name = "lbl合計"
        Me.lbl合計.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl合計.Text = "合計"
        Me.lbl合計.Top = 0.00000667572!
        Me.lbl合計.Width = 1.318898!
        '
        'txt合計
        '
        Me.txt合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計.Height = 0.3346457!
        Me.txt合計.Left = 1.318898!
        Me.txt合計.Name = "txt合計"
        Me.txt合計.Style = "font-family: ＭＳ 明朝; font-size: 12pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt合計.Text = "999,999"
        Me.txt合計.Top = 0.0!
        Me.txt合計.Width = 1.555118!
        '
        'TextBox40
        '
        Me.TextBox40.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox40.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox40.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox40.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox40.Height = 0.3346457!
        Me.TextBox40.Left = 2.874011!
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.TextBox40.Text = Nothing
        Me.TextBox40.Top = 0.00000667572!
        Me.TextBox40.Width = 1.338583!
        '
        'TextBox59
        '
        Me.TextBox59.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox59.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox59.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox59.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox59.Height = 0.3346457!
        Me.TextBox59.Left = 4.212599!
        Me.TextBox59.Name = "TextBox59"
        Me.TextBox59.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.TextBox59.Text = Nothing
        Me.TextBox59.Top = 0.00000667572!
        Me.TextBox59.Width = 1.338583!
        '
        'TextBox78
        '
        Me.TextBox78.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox78.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox78.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox78.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox78.Height = 0.3346457!
        Me.TextBox78.Left = 5.551176!
        Me.TextBox78.Name = "TextBox78"
        Me.TextBox78.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.TextBox78.Text = Nothing
        Me.TextBox78.Top = 0.00000667572!
        Me.TextBox78.Width = 1.377953!
        '
        'TextBox1
        '
        Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Height = 0.3346457!
        Me.TextBox1.Left = 1.791339!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox1.Text = "Fax　　(3996)4333"
        Me.TextBox1.Top = 0.9397638!
        Me.TextBox1.Width = 1.791339!
        '
        'BancdorInvoice
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 6.929134!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.grpHdr作業No)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.grpFtr)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.txt税込請求額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox60, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt請求宛名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt郵便番号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt会社名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt住所, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt電話番号他, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt銀行名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt口座名義, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl銀行振込, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl預金口座, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt支店名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl口座名義, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt預金口座名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl会社名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt法人名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt預金口座No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ｌｂｌ取引先コードNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt取引先コードNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr会社名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt請求年月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr法人名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl請求明細書, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt請求年月度, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl請求書宛名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl税込請求額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox59, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox78, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents grpHdr作業No As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents ｌｂｌ取引先コードNo As DataDynamics.ActiveReports.Label
    Private WithEvents txt取引先コードNo As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpFtr As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txt請求年月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line25 As DataDynamics.ActiveReports.Line
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl請求明細書 As DataDynamics.ActiveReports.Label
    Private WithEvents txt請求年月度 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl請求書宛名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl税込請求額 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl2 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl1 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl3 As DataDynamics.ActiveReports.Label
    Private WithEvents txtHdr会社名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtHdr法人名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt税込請求額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox22 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox41 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox60 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt郵便番号 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt会社名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt住所 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt電話番号他 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt銀行名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt口座名義 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl銀行振込 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl預金口座 As DataDynamics.ActiveReports.Label
    Private WithEvents txt支店名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl口座名義 As DataDynamics.ActiveReports.Label
    Private WithEvents txt預金口座名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl会社名 As DataDynamics.ActiveReports.Label
    Private WithEvents txt法人名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt預金口座No As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label24 As DataDynamics.ActiveReports.Label
    Private WithEvents Label25 As DataDynamics.ActiveReports.Label
    Private WithEvents Label26 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl合計 As DataDynamics.ActiveReports.Label
    Private WithEvents txt合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox40 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox59 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox78 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt請求宛名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
End Class
