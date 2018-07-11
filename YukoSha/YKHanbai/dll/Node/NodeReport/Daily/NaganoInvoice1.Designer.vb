<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class NaganoInvoice1
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(NaganoInvoice1))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt商品名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt注文番号 = New DataDynamics.ActiveReports.TextBox()
        Me.txt数量 = New DataDynamics.ActiveReports.TextBox()
        Me.txt単価 = New DataDynamics.ActiveReports.TextBox()
        Me.txt金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt日 = New DataDynamics.ActiveReports.TextBox()
        Me.txt単位 = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.txtNo = New DataDynamics.ActiveReports.TextBox()
        Me.lbl請求明細書 = New DataDynamics.ActiveReports.Label()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.Label7 = New DataDynamics.ActiveReports.Label()
        Me.Label8 = New DataDynamics.ActiveReports.Label()
        Me.Label10 = New DataDynamics.ActiveReports.Label()
        Me.lbl税込請求額 = New DataDynamics.ActiveReports.Label()
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox()
        Me.Label11 = New DataDynamics.ActiveReports.Label()
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox()
        Me.Label13 = New DataDynamics.ActiveReports.Label()
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox()
        Me.Label14 = New DataDynamics.ActiveReports.Label()
        Me.TextBox8 = New DataDynamics.ActiveReports.TextBox()
        Me.Label15 = New DataDynamics.ActiveReports.Label()
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox()
        Me.Label16 = New DataDynamics.ActiveReports.Label()
        Me.TextBox10 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox11 = New DataDynamics.ActiveReports.TextBox()
        Me.Label17 = New DataDynamics.ActiveReports.Label()
        Me.grpHdr = New DataDynamics.ActiveReports.GroupHeader()
        Me.Label5 = New DataDynamics.ActiveReports.Label()
        Me.lbl月 = New DataDynamics.ActiveReports.Label()
        Me.lbl数量 = New DataDynamics.ActiveReports.Label()
        Me.lbl金額 = New DataDynamics.ActiveReports.Label()
        Me.lbl注文番号 = New DataDynamics.ActiveReports.Label()
        Me.txt請求会社 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl単価 = New DataDynamics.ActiveReports.Label()
        Me.txt請求年月 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl合計金額 = New DataDynamics.ActiveReports.Label()
        Me.txt合計金額 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl消費税額 = New DataDynamics.ActiveReports.Label()
        Me.txt消費税額 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl請求金額 = New DataDynamics.ActiveReports.Label()
        Me.txt請求額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt請求法人名 = New DataDynamics.ActiveReports.TextBox()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.lbl日 = New DataDynamics.ActiveReports.Label()
        Me.lbl単位 = New DataDynamics.ActiveReports.Label()
        Me.txt会社名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt住所 = New DataDynamics.ActiveReports.TextBox()
        Me.txtTEL = New DataDynamics.ActiveReports.TextBox()
        Me.lbl納品者 = New DataDynamics.ActiveReports.Label()
        Me.txt法人 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl社名 = New DataDynamics.ActiveReports.Label()
        Me.lbl住所 = New DataDynamics.ActiveReports.Label()
        Me.lbl電話 = New DataDynamics.ActiveReports.Label()
        Me.lbl商品名 = New DataDynamics.ActiveReports.Label()
        Me.grpFtr = New DataDynamics.ActiveReports.GroupFooter()
        Me.txt小計 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.txt月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt注文番号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt数量, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt単位, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl請求明細書, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl税込請求額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl数量, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl注文番号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt請求会社, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt請求年月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl合計金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt合計金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl消費税額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt消費税額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl請求金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt請求額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt請求法人名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl単位, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt会社名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt住所, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl納品者, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt法人, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl社名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl住所, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl電話, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt小計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt月, Me.txt商品名, Me.txt注文番号, Me.txt数量, Me.txt単価, Me.txt金額, Me.txt日, Me.txt単位})
        Me.Detail.Height = 0.3070866!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        '
        'txt月
        '
        Me.txt月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt月.Height = 0.3070866!
        Me.txt月.Left = 0.0!
        Me.txt月.Name = "txt月"
        Me.txt月.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt月.Text = "99"
        Me.txt月.Top = 0.0!
        Me.txt月.Width = 0.2401575!
        '
        'txt商品名
        '
        Me.txt商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Height = 0.3070866!
        Me.txt商品名.Left = 0.480315!
        Me.txt商品名.Name = "txt商品名"
        Me.txt商品名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt商品名.Text = "あああああいいいいいううううう"
        Me.txt商品名.Top = 0.0!
        Me.txt商品名.Width = 2.086614!
        '
        'txt注文番号
        '
        Me.txt注文番号.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt注文番号.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt注文番号.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt注文番号.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt注文番号.Height = 0.3070866!
        Me.txt注文番号.Left = 5.755906!
        Me.txt注文番号.Name = "txt注文番号"
        Me.txt注文番号.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt注文番号.Text = "123456"
        Me.txt注文番号.Top = 0.0!
        Me.txt注文番号.Width = 0.7165354!
        '
        'txt数量
        '
        Me.txt数量.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt数量.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt数量.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt数量.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt数量.Height = 0.3070866!
        Me.txt数量.Left = 2.566929!
        Me.txt数量.Name = "txt数量"
        Me.txt数量.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt数量.Text = "999,999"
        Me.txt数量.Top = 0.0!
        Me.txt数量.Width = 0.9251968!
        '
        'txt単価
        '
        Me.txt単価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt単価.Height = 0.3070866!
        Me.txt単価.Left = 3.799213!
        Me.txt単価.Name = "txt単価"
        Me.txt単価.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt単価.Text = "999.00"
        Me.txt単価.Top = 0.0!
        Me.txt単価.Width = 0.6181102!
        '
        'txt金額
        '
        Me.txt金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt金額.CharacterSpacing = 3.0!
        Me.txt金額.Height = 0.3070866!
        Me.txt金額.Left = 4.417323!
        Me.txt金額.Name = "txt金額"
        Me.txt金額.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt金額.Text = "999999999"
        Me.txt金額.Top = 0.0!
        Me.txt金額.Width = 1.338583!
        '
        'txt日
        '
        Me.txt日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt日.Height = 0.3070866!
        Me.txt日.Left = 0.2401575!
        Me.txt日.Name = "txt日"
        Me.txt日.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt日.Text = "99"
        Me.txt日.Top = 0.0!
        Me.txt日.Width = 0.2401575!
        '
        'txt単位
        '
        Me.txt単位.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt単位.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt単位.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt単位.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt単位.Height = 0.3070866!
        Me.txt単位.Left = 3.492126!
        Me.txt単位.Name = "txt単位"
        Me.txt単位.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt単位.Text = "99"
        Me.txt単位.Top = 0.0!
        Me.txt単位.Width = 0.3070866!
        '
        'PageHeader
        '
        Me.PageHeader.Height = 0.4340277!
        Me.PageHeader.Name = "PageHeader"
        '
        'txtNo
        '
        Me.txtNo.Height = 0.2362205!
        Me.txtNo.Left = 5.181889!
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txtNo.Text = "No"
        Me.txtNo.Top = 0.1125982!
        Me.txtNo.Width = 0.5905512!
        '
        'lbl請求明細書
        '
        Me.lbl請求明細書.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.lbl請求明細書.Height = 0.3937008!
        Me.lbl請求明細書.HyperLink = Nothing
        Me.lbl請求明細書.Left = 2.507874!
        Me.lbl請求明細書.Name = "lbl請求明細書"
        Me.lbl請求明細書.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 14pt; font-weight: bold; text-align:" & _
    " center; vertical-align: middle; ddo-char-set: 1"
        Me.lbl請求明細書.Text = "請　求　書"
        Me.lbl請求明細書.Top = 0.0!
        Me.lbl請求明細書.Width = 1.814961!
        '
        'PageFooter
        '
        Me.PageFooter.CanGrow = False
        Me.PageFooter.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label7, Me.Label8, Me.Label10, Me.lbl税込請求額, Me.TextBox5, Me.Label11, Me.TextBox6, Me.Label13, Me.TextBox7, Me.Label14, Me.TextBox8, Me.Label15, Me.TextBox9, Me.Label16, Me.TextBox10, Me.TextBox11, Me.Label17})
        Me.PageFooter.Height = 0.7874016!
        Me.PageFooter.Name = "PageFooter"
        '
        'Label7
        '
        Me.Label7.Height = 0.3937008!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 0.2968504!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.Label7.Text = "ご注意"
        Me.Label7.Top = 0.08188977!
        Me.Label7.Width = 0.5905512!
        '
        'Label8
        '
        Me.Label8.Height = 0.472441!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 1.084252!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.Label8.Text = "納品〆切は毎月20日" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "請求書提出は毎月末日迄"
        Me.Label8.Top = 0.06141733!
        Me.Label8.Width = 1.968504!
        '
        'Label10
        '
        Me.Label10.Height = 0.3937008!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 0.8874016!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 20pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.Label10.Text = "｛"
        Me.Label10.Top = 0.08188977!
        Me.Label10.Width = 0.1968504!
        '
        'lbl税込請求額
        '
        Me.lbl税込請求額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl税込請求額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl税込請求額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl税込請求額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl税込請求額.CharacterSpacing = 5.0!
        Me.lbl税込請求額.Height = 0.1377953!
        Me.lbl税込請求額.HyperLink = Nothing
        Me.lbl税込請求額.Left = 3.346457!
        Me.lbl税込請求額.Name = "lbl税込請求額"
        Me.lbl税込請求額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 7pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lbl税込請求額.Text = "社長"
        Me.lbl税込請求額.Top = 0.08188977!
        Me.lbl税込請求額.Width = 0.4448819!
        '
        'TextBox5
        '
        Me.TextBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Height = 0.3740157!
        Me.TextBox5.Left = 3.346463!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: left; vertical-align: bottom; ddo" & _
    "-char-set: 1"
        Me.TextBox5.Text = Nothing
        Me.TextBox5.Top = 0.219685!
        Me.TextBox5.Width = 0.4448819!
        '
        'Label11
        '
        Me.Label11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label11.CharacterSpacing = 5.0!
        Me.Label11.Height = 0.1377953!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 3.791338!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 7pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.Label11.Text = "専務"
        Me.Label11.Top = 0.08188977!
        Me.Label11.Width = 0.4448819!
        '
        'TextBox6
        '
        Me.TextBox6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Height = 0.3740157!
        Me.TextBox6.Left = 3.791344!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: left; vertical-align: bottom; ddo" & _
    "-char-set: 1"
        Me.TextBox6.Text = Nothing
        Me.TextBox6.Top = 0.219685!
        Me.TextBox6.Width = 0.4448819!
        '
        'Label13
        '
        Me.Label13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label13.CharacterSpacing = 5.0!
        Me.Label13.Height = 0.1377953!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 4.23622!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 7pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.Label13.Text = "常務"
        Me.Label13.Top = 0.08188977!
        Me.Label13.Width = 0.4448819!
        '
        'TextBox7
        '
        Me.TextBox7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Height = 0.3740157!
        Me.TextBox7.Left = 4.236227!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: left; vertical-align: bottom; ddo" & _
    "-char-set: 1"
        Me.TextBox7.Text = Nothing
        Me.TextBox7.Top = 0.219685!
        Me.TextBox7.Width = 0.4448819!
        '
        'Label14
        '
        Me.Label14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label14.CharacterSpacing = 5.0!
        Me.Label14.Height = 0.1377953!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 4.681102!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 7pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.Label14.Text = "総務"
        Me.Label14.Top = 0.08188977!
        Me.Label14.Width = 0.4448819!
        '
        'TextBox8
        '
        Me.TextBox8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Height = 0.3740157!
        Me.TextBox8.Left = 4.681108!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: left; vertical-align: bottom; ddo" & _
    "-char-set: 1"
        Me.TextBox8.Text = Nothing
        Me.TextBox8.Top = 0.219685!
        Me.TextBox8.Width = 0.4448819!
        '
        'Label15
        '
        Me.Label15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label15.CharacterSpacing = 5.0!
        Me.Label15.Height = 0.1377953!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 5.125984!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 7pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.Label15.Text = "経理"
        Me.Label15.Top = 0.08188977!
        Me.Label15.Width = 0.4448819!
        '
        'TextBox9
        '
        Me.TextBox9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Height = 0.3740157!
        Me.TextBox9.Left = 5.12599!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: left; vertical-align: bottom; ddo" & _
    "-char-set: 1"
        Me.TextBox9.Text = Nothing
        Me.TextBox9.Top = 0.219685!
        Me.TextBox9.Width = 0.4448819!
        '
        'Label16
        '
        Me.Label16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label16.CharacterSpacing = 5.0!
        Me.Label16.Height = 0.1377953!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 5.570866!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 7pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.Label16.Text = "営業"
        Me.Label16.Top = 0.08188977!
        Me.Label16.Width = 0.4448819!
        '
        'TextBox10
        '
        Me.TextBox10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Height = 0.3740157!
        Me.TextBox10.Left = 5.570872!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: left; vertical-align: bottom; ddo" & _
    "-char-set: 1"
        Me.TextBox10.Text = Nothing
        Me.TextBox10.Top = 0.219685!
        Me.TextBox10.Width = 0.4448819!
        '
        'TextBox11
        '
        Me.TextBox11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Height = 0.3740157!
        Me.TextBox11.Left = 6.015754!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: left; vertical-align: bottom; ddo" & _
    "-char-set: 1"
        Me.TextBox11.Text = Nothing
        Me.TextBox11.Top = 0.219685!
        Me.TextBox11.Width = 0.4448819!
        '
        'Label17
        '
        Me.Label17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label17.CharacterSpacing = 5.0!
        Me.Label17.Height = 0.1377953!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 6.015748!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 7pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.Label17.Text = "担当"
        Me.Label17.Top = 0.08188977!
        Me.Label17.Width = 0.4448819!
        '
        'grpHdr
        '
        Me.grpHdr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label5, Me.lbl月, Me.lbl数量, Me.lbl金額, Me.lbl注文番号, Me.txt請求会社, Me.lbl単価, Me.txt請求年月, Me.lbl合計金額, Me.txt合計金額, Me.lbl消費税額, Me.txt消費税額, Me.lbl請求金額, Me.txt請求額, Me.txt請求法人名, Me.Label2, Me.Label1, Me.lbl日, Me.lbl単位, Me.txt会社名, Me.txt住所, Me.txtTEL, Me.lbl納品者, Me.txt法人, Me.lbl社名, Me.lbl住所, Me.lbl電話, Me.lbl請求明細書, Me.txtNo, Me.lbl商品名})
        Me.grpHdr.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr.Height = 2.274803!
        Me.grpHdr.Name = "grpHdr"
        Me.grpHdr.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'Label5
        '
        Me.Label5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label5.Height = 0.04724409!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 0.0!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.Label5.Text = ""
        Me.Label5.Top = 2.007087!
        Me.Label5.Width = 3.492126!
        '
        'lbl月
        '
        Me.lbl月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl月.Height = 0.2204724!
        Me.lbl月.HyperLink = Nothing
        Me.lbl月.Left = 0.0!
        Me.lbl月.Name = "lbl月"
        Me.lbl月.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl月.Text = "月"
        Me.lbl月.Top = 2.054331!
        Me.lbl月.Width = 0.2401575!
        '
        'lbl数量
        '
        Me.lbl数量.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl数量.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl数量.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl数量.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl数量.Height = 0.2204724!
        Me.lbl数量.HyperLink = Nothing
        Me.lbl数量.Left = 2.566929!
        Me.lbl数量.Name = "lbl数量"
        Me.lbl数量.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl数量.Text = "数　量"
        Me.lbl数量.Top = 2.054331!
        Me.lbl数量.Width = 0.9251968!
        '
        'lbl金額
        '
        Me.lbl金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl金額.CharacterSpacing = 30.0!
        Me.lbl金額.Height = 0.2204724!
        Me.lbl金額.HyperLink = Nothing
        Me.lbl金額.Left = 4.417323!
        Me.lbl金額.Name = "lbl金額"
        Me.lbl金額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl金額.Text = "金額"
        Me.lbl金額.Top = 2.054331!
        Me.lbl金額.Width = 1.338583!
        '
        'lbl注文番号
        '
        Me.lbl注文番号.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl注文番号.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl注文番号.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl注文番号.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl注文番号.Height = 0.2204724!
        Me.lbl注文番号.HyperLink = Nothing
        Me.lbl注文番号.Left = 5.755906!
        Me.lbl注文番号.Name = "lbl注文番号"
        Me.lbl注文番号.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl注文番号.Text = "注文番号"
        Me.lbl注文番号.Top = 2.054331!
        Me.lbl注文番号.Width = 0.7165354!
        '
        'txt請求会社
        '
        Me.txt請求会社.Height = 0.3937008!
        Me.txt請求会社.Left = 0.5976391!
        Me.txt請求会社.Name = "txt請求会社"
        Me.txt請求会社.Style = "font-family: ＭＳ 明朝; font-size: 14pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt請求会社.Text = "ナガノ"
        Me.txt請求会社.Top = 0.4606299!
        Me.txt請求会社.Width = 0.984252!
        '
        'lbl単価
        '
        Me.lbl単価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単価.Height = 0.2204724!
        Me.lbl単価.HyperLink = Nothing
        Me.lbl単価.Left = 3.799213!
        Me.lbl単価.Name = "lbl単価"
        Me.lbl単価.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl単価.Text = "単　価"
        Me.lbl単価.Top = 2.054331!
        Me.lbl単価.Width = 0.6181102!
        '
        'txt請求年月
        '
        Me.txt請求年月.Height = 0.1968504!
        Me.txt請求年月.Left = 4.864567!
        Me.txt請求年月.Name = "txt請求年月"
        Me.txt請求年月.Style = "font-family: ＭＳ 明朝; font-size: 12pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt請求年月.Text = "平成99年99月99日"
        Me.txt請求年月.Top = 0.8996063!
        Me.txt請求年月.Width = 1.574803!
        '
        'lbl合計金額
        '
        Me.lbl合計金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl合計金額.Height = 0.2716535!
        Me.lbl合計金額.HyperLink = Nothing
        Me.lbl合計金額.Left = 0.0!
        Me.lbl合計金額.Name = "lbl合計金額"
        Me.lbl合計金額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl合計金額.Text = "合計金額"
        Me.lbl合計金額.Top = 1.735433!
        Me.lbl合計金額.Width = 0.9251968!
        '
        'txt合計金額
        '
        Me.txt合計金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt合計金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計金額.Height = 0.2716535!
        Me.txt合計金額.Left = 0.9251968!
        Me.txt合計金額.Name = "txt合計金額"
        Me.txt合計金額.Style = "font-family: ＭＳ 明朝; font-size: 12pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt合計金額.Text = "\　　　　　　　999,999,999"
        Me.txt合計金額.Top = 1.735433!
        Me.txt合計金額.Width = 2.566929!
        '
        'lbl消費税額
        '
        Me.lbl消費税額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl消費税額.Height = 0.2716535!
        Me.lbl消費税額.HyperLink = Nothing
        Me.lbl消費税額.Left = 0.0!
        Me.lbl消費税額.Name = "lbl消費税額"
        Me.lbl消費税額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl消費税額.Text = "消費税"
        Me.lbl消費税額.Top = 1.46378!
        Me.lbl消費税額.Width = 0.9251968!
        '
        'txt消費税額
        '
        Me.txt消費税額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt消費税額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税額.Height = 0.2716535!
        Me.txt消費税額.Left = 0.9251968!
        Me.txt消費税額.Name = "txt消費税額"
        Me.txt消費税額.Style = "font-family: ＭＳ 明朝; font-size: 12pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt消費税額.Text = "\　　　　　　　999,999,999"
        Me.txt消費税額.Top = 1.46378!
        Me.txt消費税額.Width = 2.566929!
        '
        'lbl請求金額
        '
        Me.lbl請求金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl請求金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl請求金額.Height = 0.2716535!
        Me.lbl請求金額.HyperLink = Nothing
        Me.lbl請求金額.Left = 0.0!
        Me.lbl請求金額.Name = "lbl請求金額"
        Me.lbl請求金額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl請求金額.Text = "請求金額"
        Me.lbl請求金額.Top = 1.192126!
        Me.lbl請求金額.Width = 0.9251968!
        '
        'txt請求額
        '
        Me.txt請求額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt請求額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt請求額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt請求額.Height = 0.2716535!
        Me.txt請求額.Left = 0.9251968!
        Me.txt請求額.Name = "txt請求額"
        Me.txt請求額.Style = "font-family: ＭＳ 明朝; font-size: 12pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt請求額.Text = "\　　　　　　　999,999,999"
        Me.txt請求額.Top = 1.192126!
        Me.txt請求額.Width = 2.566929!
        '
        'txt請求法人名
        '
        Me.txt請求法人名.Height = 0.1968504!
        Me.txt請求法人名.Left = 0.0!
        Me.txt請求法人名.Name = "txt請求法人名"
        Me.txt請求法人名.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt請求法人名.Text = "株式会社"
        Me.txt請求法人名.Top = 0.6566928!
        Me.txt請求法人名.Width = 0.5905512!
        '
        'Label2
        '
        Me.Label2.Height = 0.1968504!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.0!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.Label2.Text = "下記の通りご請求願います"
        Me.Label2.Top = 0.8818898!
        Me.Label2.Width = 1.968504!
        '
        'Label1
        '
        Me.Label1.Height = 0.1968504!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 1.581891!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.Label1.Text = "御中"
        Me.Label1.Top = 0.6055118!
        Me.Label1.Width = 0.511811!
        '
        'lbl日
        '
        Me.lbl日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl日.Height = 0.2204724!
        Me.lbl日.HyperLink = Nothing
        Me.lbl日.Left = 0.2401575!
        Me.lbl日.Name = "lbl日"
        Me.lbl日.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl日.Text = "日"
        Me.lbl日.Top = 2.054331!
        Me.lbl日.Width = 0.2401575!
        '
        'lbl単位
        '
        Me.lbl単位.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単位.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単位.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単位.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単位.Height = 0.2204724!
        Me.lbl単位.HyperLink = Nothing
        Me.lbl単位.Left = 3.492126!
        Me.lbl単位.Name = "lbl単位"
        Me.lbl単位.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl単位.Text = "単位"
        Me.lbl単位.Top = 2.054331!
        Me.lbl単位.Width = 0.3070866!
        '
        'txt会社名
        '
        Me.txt会社名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt会社名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt会社名.Height = 0.2874016!
        Me.txt会社名.Left = 5.194489!
        Me.txt会社名.Name = "txt会社名"
        Me.txt会社名.Style = "font-family: ＭＳ 明朝; font-size: 14pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt会社名.Text = "友　功　社"
        Me.txt会社名.Top = 1.192126!
        Me.txt会社名.Width = 1.279528!
        '
        'txt住所
        '
        Me.txt住所.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt住所.Height = 0.2874016!
        Me.txt住所.Left = 4.485827!
        Me.txt住所.Name = "txt住所"
        Me.txt住所.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.txt住所.Text = " 東京都練馬区谷原３－２４－１"
        Me.txt住所.Top = 1.479528!
        Me.txt住所.Width = 1.988189!
        '
        'txtTEL
        '
        Me.txtTEL.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtTEL.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtTEL.Height = 0.2874016!
        Me.txtTEL.Left = 4.485827!
        Me.txtTEL.Name = "txtTEL"
        Me.txtTEL.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: justify; vertical-align: middle;" & _
    " ddo-char-set: 1"
        Me.txtTEL.Text = " ０３(３９９６)５３３３"
        Me.txtTEL.Top = 1.766929!
        Me.txtTEL.Width = 1.988189!
        '
        'lbl納品者
        '
        Me.lbl納品者.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl納品者.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl納品者.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl納品者.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl納品者.Height = 0.8622047!
        Me.lbl納品者.HyperLink = Nothing
        Me.lbl納品者.Left = 3.493701!
        Me.lbl納品者.Name = "lbl納品者"
        Me.lbl納品者.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl納品者.Text = "納" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "入" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "者"
        Me.lbl納品者.Top = 1.192127!
        Me.lbl納品者.Width = 0.2401575!
        '
        'txt法人
        '
        Me.txt法人.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt法人.Height = 0.2874016!
        Me.txt法人.Left = 4.485827!
        Me.txt法人.Name = "txt法人"
        Me.txt法人.Style = "font-family: ＭＳ 明朝; font-size: 11.5pt; text-align: center; vertical-align: bottom" & _
    "; ddo-char-set: 1"
        Me.txt法人.Text = "株式会社"
        Me.txt法人.Top = 1.192126!
        Me.txt法人.Width = 0.7086614!
        '
        'lbl社名
        '
        Me.lbl社名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl社名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl社名.Height = 0.2874016!
        Me.lbl社名.HyperLink = Nothing
        Me.lbl社名.Left = 3.733859!
        Me.lbl社名.Name = "lbl社名"
        Me.lbl社名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl社名.Text = "社　名"
        Me.lbl社名.Top = 1.192126!
        Me.lbl社名.Width = 0.7519685!
        '
        'lbl住所
        '
        Me.lbl住所.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl住所.Height = 0.2874016!
        Me.lbl住所.HyperLink = Nothing
        Me.lbl住所.Left = 3.733859!
        Me.lbl住所.Name = "lbl住所"
        Me.lbl住所.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl住所.Text = "住　所"
        Me.lbl住所.Top = 1.479528!
        Me.lbl住所.Width = 0.7519685!
        '
        'lbl電話
        '
        Me.lbl電話.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl電話.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl電話.Height = 0.2874016!
        Me.lbl電話.HyperLink = Nothing
        Me.lbl電話.Left = 3.733859!
        Me.lbl電話.Name = "lbl電話"
        Me.lbl電話.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl電話.Text = "電　話"
        Me.lbl電話.Top = 1.766929!
        Me.lbl電話.Width = 0.7519685!
        '
        'lbl商品名
        '
        Me.lbl商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.CharacterSpacing = 5.0!
        Me.lbl商品名.Height = 0.2204724!
        Me.lbl商品名.HyperLink = Nothing
        Me.lbl商品名.Left = 0.480315!
        Me.lbl商品名.Name = "lbl商品名"
        Me.lbl商品名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl商品名.Text = "品名又は摘要"
        Me.lbl商品名.Top = 2.054331!
        Me.lbl商品名.Width = 2.086614!
        '
        'grpFtr
        '
        Me.grpFtr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt小計, Me.TextBox2, Me.TextBox3, Me.TextBox4, Me.TextBox1})
        Me.grpFtr.Height = 0.3070866!
        Me.grpFtr.Name = "grpFtr"
        '
        'txt小計
        '
        Me.txt小計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt小計.CharacterSpacing = 3.0!
        Me.txt小計.Height = 0.3070866!
        Me.txt小計.Left = 4.417323!
        Me.txt小計.Name = "txt小計"
        Me.txt小計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt小計.Text = "999999999"
        Me.txt小計.Top = 0.0!
        Me.txt小計.Width = 1.338583!
        '
        'TextBox2
        '
        Me.TextBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.CharacterSpacing = 20.0!
        Me.TextBox2.Height = 0.3070866!
        Me.TextBox2.Left = 0.480315!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox2.Text = "この頁小計"
        Me.TextBox2.Top = 0.0!
        Me.TextBox2.Width = 3.937008!
        '
        'TextBox3
        '
        Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Height = 0.3070866!
        Me.TextBox3.Left = 0.0!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox3.Text = Nothing
        Me.TextBox3.Top = 0.0!
        Me.TextBox3.Width = 0.2401575!
        '
        'TextBox4
        '
        Me.TextBox4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Height = 0.3070866!
        Me.TextBox4.Left = 0.2401575!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox4.Text = Nothing
        Me.TextBox4.Top = 0.0!
        Me.TextBox4.Width = 0.2401575!
        '
        'TextBox1
        '
        Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Height = 0.3070866!
        Me.TextBox1.Left = 5.755906!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox1.Text = Nothing
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 0.7165354!
        '
        'NaganoInvoice1
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 6.496063!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.grpHdr)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.grpFtr)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.txt月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt注文番号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt数量, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt単位, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl請求明細書, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl税込請求額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl数量, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl注文番号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt請求会社, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt請求年月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl合計金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt合計金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl消費税額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt消費税額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl請求金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt請求額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt請求法人名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl単位, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt会社名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt住所, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl納品者, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt法人, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl社名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl住所, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl電話, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt小計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txt月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt商品名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt注文番号 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt数量 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt単価 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtNo As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl請求明細書 As DataDynamics.ActiveReports.Label
    Private WithEvents txt日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt単位 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpHdr As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents lbl月 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl商品名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl数量 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl金額 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl注文番号 As DataDynamics.ActiveReports.Label
    Private WithEvents txt請求会社 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl単価 As DataDynamics.ActiveReports.Label
    Private WithEvents txt請求年月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl合計金額 As DataDynamics.ActiveReports.Label
    Private WithEvents txt合計金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt消費税額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl請求金額 As DataDynamics.ActiveReports.Label
    Private WithEvents txt請求額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt請求法人名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl日 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl単位 As DataDynamics.ActiveReports.Label
    Private WithEvents grpFtr As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txt会社名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt住所 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtTEL As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl納品者 As DataDynamics.ActiveReports.Label
    Private WithEvents txt法人 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl社名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl住所 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl電話 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl消費税額 As DataDynamics.ActiveReports.Label
    Private WithEvents Label5 As DataDynamics.ActiveReports.Label
    Private WithEvents Label7 As DataDynamics.ActiveReports.Label
    Private WithEvents Label8 As DataDynamics.ActiveReports.Label
    Private WithEvents Label10 As DataDynamics.ActiveReports.Label
    Private WithEvents txt小計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl税込請求額 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label11 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label13 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label14 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox8 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label15 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label16 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox10 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox11 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label17 As DataDynamics.ActiveReports.Label
End Class
