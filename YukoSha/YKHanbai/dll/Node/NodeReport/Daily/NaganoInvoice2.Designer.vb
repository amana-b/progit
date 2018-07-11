<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class NaganoInvoice2
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(NaganoInvoice2))
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
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr = New DataDynamics.ActiveReports.GroupHeader()
        Me.Label5 = New DataDynamics.ActiveReports.Label()
        Me.lbl月 = New DataDynamics.ActiveReports.Label()
        Me.lbl数量 = New DataDynamics.ActiveReports.Label()
        Me.lbl金額 = New DataDynamics.ActiveReports.Label()
        Me.lbl注文番号 = New DataDynamics.ActiveReports.Label()
        Me.lbl単価 = New DataDynamics.ActiveReports.Label()
        Me.txt請求年月 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl合計金額 = New DataDynamics.ActiveReports.Label()
        Me.txt合計金額 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl消費税額 = New DataDynamics.ActiveReports.Label()
        Me.txt消費税額 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl請求金額 = New DataDynamics.ActiveReports.Label()
        Me.txt請求額 = New DataDynamics.ActiveReports.TextBox()
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
        Me.lbl請求明細書 = New DataDynamics.ActiveReports.Label()
        Me.txtNo = New DataDynamics.ActiveReports.TextBox()
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
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl数量, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl注文番号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt請求年月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl合計金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt合計金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl消費税額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt消費税額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl請求金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt請求額, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.lbl請求明細書, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNo, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.txt商品名.Height = 0.3070866!
        Me.txt商品名.Left = 0.480315!
        Me.txt商品名.Name = "txt商品名"
        Me.txt商品名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt商品名.Text = "あああああいいいいいううううう"
        Me.txt商品名.Top = 0.0!
        Me.txt商品名.Width = 2.086615!
        '
        'txt注文番号
        '
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
        Me.txt数量.Height = 0.3070866!
        Me.txt数量.Left = 2.566929!
        Me.txt数量.Name = "txt数量"
        Me.txt数量.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt数量.Text = "999,999"
        Me.txt数量.Top = 0.0!
        Me.txt数量.Width = 0.9251965!
        '
        'txt単価
        '
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
        'PageFooter
        '
        Me.PageFooter.CanGrow = False
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'grpHdr
        '
        Me.grpHdr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label5, Me.lbl月, Me.lbl数量, Me.lbl金額, Me.lbl注文番号, Me.lbl単価, Me.txt請求年月, Me.lbl合計金額, Me.txt合計金額, Me.lbl消費税額, Me.txt消費税額, Me.lbl請求金額, Me.txt請求額, Me.lbl日, Me.lbl単位, Me.txt会社名, Me.txt住所, Me.txtTEL, Me.lbl納品者, Me.txt法人, Me.lbl社名, Me.lbl住所, Me.lbl電話, Me.lbl請求明細書, Me.txtNo, Me.lbl商品名})
        Me.grpHdr.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr.Height = 2.274803!
        Me.grpHdr.Name = "grpHdr"
        Me.grpHdr.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'Label5
        '
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
        Me.lbl月.Height = 0.2204724!
        Me.lbl月.HyperLink = Nothing
        Me.lbl月.Left = 0.0!
        Me.lbl月.Name = "lbl月"
        Me.lbl月.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl月.Text = ""
        Me.lbl月.Top = 2.054331!
        Me.lbl月.Width = 0.2401575!
        '
        'lbl数量
        '
        Me.lbl数量.Height = 0.2204724!
        Me.lbl数量.HyperLink = Nothing
        Me.lbl数量.Left = 2.566929!
        Me.lbl数量.Name = "lbl数量"
        Me.lbl数量.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl数量.Text = ""
        Me.lbl数量.Top = 2.054331!
        Me.lbl数量.Width = 0.9251965!
        '
        'lbl金額
        '
        Me.lbl金額.CharacterSpacing = 30.0!
        Me.lbl金額.Height = 0.2204724!
        Me.lbl金額.HyperLink = Nothing
        Me.lbl金額.Left = 4.417323!
        Me.lbl金額.Name = "lbl金額"
        Me.lbl金額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl金額.Text = ""
        Me.lbl金額.Top = 2.054331!
        Me.lbl金額.Width = 1.338583!
        '
        'lbl注文番号
        '
        Me.lbl注文番号.Height = 0.2204724!
        Me.lbl注文番号.HyperLink = Nothing
        Me.lbl注文番号.Left = 5.755906!
        Me.lbl注文番号.Name = "lbl注文番号"
        Me.lbl注文番号.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl注文番号.Text = ""
        Me.lbl注文番号.Top = 2.054331!
        Me.lbl注文番号.Width = 0.7165354!
        '
        'lbl単価
        '
        Me.lbl単価.Height = 0.2204724!
        Me.lbl単価.HyperLink = Nothing
        Me.lbl単価.Left = 3.799213!
        Me.lbl単価.Name = "lbl単価"
        Me.lbl単価.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl単価.Text = ""
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
        Me.txt請求年月.Text = "YY  MM  DD"
        Me.txt請求年月.Top = 0.8996062!
        Me.txt請求年月.Width = 1.574803!
        '
        'lbl合計金額
        '
        Me.lbl合計金額.Height = 0.2716535!
        Me.lbl合計金額.HyperLink = Nothing
        Me.lbl合計金額.Left = 0.0!
        Me.lbl合計金額.Name = "lbl合計金額"
        Me.lbl合計金額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl合計金額.Text = ""
        Me.lbl合計金額.Top = 1.735433!
        Me.lbl合計金額.Width = 0.9251965!
        '
        'txt合計金額
        '
        Me.txt合計金額.Height = 0.2716535!
        Me.txt合計金額.Left = 0.9251965!
        Me.txt合計金額.Name = "txt合計金額"
        Me.txt合計金額.Style = "font-family: ＭＳ 明朝; font-size: 12pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt合計金額.Text = " 　　　　　　　999,999,999"
        Me.txt合計金額.Top = 1.735433!
        Me.txt合計金額.Width = 2.566929!
        '
        'lbl消費税額
        '
        Me.lbl消費税額.Height = 0.2716535!
        Me.lbl消費税額.HyperLink = Nothing
        Me.lbl消費税額.Left = 0.0!
        Me.lbl消費税額.Name = "lbl消費税額"
        Me.lbl消費税額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl消費税額.Text = ""
        Me.lbl消費税額.Top = 1.46378!
        Me.lbl消費税額.Width = 0.9251965!
        '
        'txt消費税額
        '
        Me.txt消費税額.Height = 0.2716535!
        Me.txt消費税額.Left = 0.9251965!
        Me.txt消費税額.Name = "txt消費税額"
        Me.txt消費税額.Style = "font-family: ＭＳ 明朝; font-size: 12pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt消費税額.Text = " 　　　　　　　999,999,999"
        Me.txt消費税額.Top = 1.46378!
        Me.txt消費税額.Width = 2.566929!
        '
        'lbl請求金額
        '
        Me.lbl請求金額.Height = 0.2716535!
        Me.lbl請求金額.HyperLink = Nothing
        Me.lbl請求金額.Left = 0.0!
        Me.lbl請求金額.Name = "lbl請求金額"
        Me.lbl請求金額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl請求金額.Text = ""
        Me.lbl請求金額.Top = 1.192126!
        Me.lbl請求金額.Width = 0.9251965!
        '
        'txt請求額
        '
        Me.txt請求額.Height = 0.2716535!
        Me.txt請求額.Left = 0.9251965!
        Me.txt請求額.Name = "txt請求額"
        Me.txt請求額.Style = "font-family: ＭＳ 明朝; font-size: 12pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt請求額.Text = " 　　　　　　　999,999,999"
        Me.txt請求額.Top = 1.192126!
        Me.txt請求額.Width = 2.566929!
        '
        'lbl日
        '
        Me.lbl日.Height = 0.2204724!
        Me.lbl日.HyperLink = Nothing
        Me.lbl日.Left = 0.2401575!
        Me.lbl日.Name = "lbl日"
        Me.lbl日.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl日.Text = ""
        Me.lbl日.Top = 2.054331!
        Me.lbl日.Width = 0.2401575!
        '
        'lbl単位
        '
        Me.lbl単位.Height = 0.2204724!
        Me.lbl単位.HyperLink = Nothing
        Me.lbl単位.Left = 3.492126!
        Me.lbl単位.Name = "lbl単位"
        Me.lbl単位.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl単位.Text = ""
        Me.lbl単位.Top = 2.054331!
        Me.lbl単位.Width = 0.3070866!
        '
        'txt会社名
        '
        Me.txt会社名.Height = 0.2874016!
        Me.txt会社名.Left = 5.194488!
        Me.txt会社名.Name = "txt会社名"
        Me.txt会社名.Style = "font-family: ＭＳ 明朝; font-size: 14pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt会社名.Text = "友　功　社"
        Me.txt会社名.Top = 1.192126!
        Me.txt会社名.Width = 1.279528!
        '
        'txt住所
        '
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
        Me.lbl納品者.Height = 0.8622048!
        Me.lbl納品者.HyperLink = Nothing
        Me.lbl納品者.Left = 3.493701!
        Me.lbl納品者.Name = "lbl納品者"
        Me.lbl納品者.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl納品者.Text = ""
        Me.lbl納品者.Top = 1.192126!
        Me.lbl納品者.Width = 0.2401575!
        '
        'txt法人
        '
        Me.txt法人.Height = 0.2874016!
        Me.txt法人.Left = 4.485827!
        Me.txt法人.Name = "txt法人"
        Me.txt法人.Style = "font-family: ＭＳ 明朝; font-size: 11.5pt; text-align: center; vertical-align: bottom" & _
    "; ddo-char-set: 1"
        Me.txt法人.Text = "株式会社"
        Me.txt法人.Top = 1.192126!
        Me.txt法人.Width = 0.7086611!
        '
        'lbl社名
        '
        Me.lbl社名.Height = 0.2874016!
        Me.lbl社名.HyperLink = Nothing
        Me.lbl社名.Left = 3.733858!
        Me.lbl社名.Name = "lbl社名"
        Me.lbl社名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl社名.Text = ""
        Me.lbl社名.Top = 1.192126!
        Me.lbl社名.Width = 0.7519687!
        '
        'lbl住所
        '
        Me.lbl住所.Height = 0.2874016!
        Me.lbl住所.HyperLink = Nothing
        Me.lbl住所.Left = 3.733858!
        Me.lbl住所.Name = "lbl住所"
        Me.lbl住所.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl住所.Text = ""
        Me.lbl住所.Top = 1.479528!
        Me.lbl住所.Width = 0.7519687!
        '
        'lbl電話
        '
        Me.lbl電話.Height = 0.2874016!
        Me.lbl電話.HyperLink = Nothing
        Me.lbl電話.Left = 3.733858!
        Me.lbl電話.Name = "lbl電話"
        Me.lbl電話.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl電話.Text = ""
        Me.lbl電話.Top = 1.766929!
        Me.lbl電話.Width = 0.7519687!
        '
        'lbl請求明細書
        '
        Me.lbl請求明細書.Height = 0.3937007!
        Me.lbl請求明細書.HyperLink = Nothing
        Me.lbl請求明細書.Left = 2.507874!
        Me.lbl請求明細書.Name = "lbl請求明細書"
        Me.lbl請求明細書.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 14pt; font-weight: bold; text-align:" & _
    " center; vertical-align: middle; ddo-char-set: 1"
        Me.lbl請求明細書.Text = ""
        Me.lbl請求明細書.Top = 0.0!
        Me.lbl請求明細書.Width = 1.81496!
        '
        'txtNo
        '
        Me.txtNo.Height = 0.2362205!
        Me.txtNo.Left = 5.702756!
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txtNo.Text = Nothing
        Me.txtNo.Top = 0.1574803!
        Me.txtNo.Width = 0.5905511!
        '
        'lbl商品名
        '
        Me.lbl商品名.CharacterSpacing = 5.0!
        Me.lbl商品名.Height = 0.2204724!
        Me.lbl商品名.HyperLink = Nothing
        Me.lbl商品名.Left = 0.480315!
        Me.lbl商品名.Name = "lbl商品名"
        Me.lbl商品名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl商品名.Text = ""
        Me.lbl商品名.Top = 2.054331!
        Me.lbl商品名.Width = 2.086615!
        '
        'grpFtr
        '
        Me.grpFtr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt小計, Me.TextBox2, Me.TextBox3, Me.TextBox4, Me.TextBox1})
        Me.grpFtr.Height = 0.3070866!
        Me.grpFtr.Name = "grpFtr"
        '
        'txt小計
        '
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
        Me.TextBox2.CharacterSpacing = 20.0!
        Me.TextBox2.Height = 0.3070866!
        Me.TextBox2.Left = 0.480315!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox2.Text = Nothing
        Me.TextBox2.Top = 0.0!
        Me.TextBox2.Width = 3.937008!
        '
        'TextBox3
        '
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
        Me.TextBox1.Height = 0.3070866!
        Me.TextBox1.Left = 5.755906!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox1.Text = Nothing
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 0.7165354!
        '
        'NaganoInvoice2
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
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl数量, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl注文番号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt請求年月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl合計金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt合計金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl消費税額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt消費税額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl請求金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt請求額, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.lbl請求明細書, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNo, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents grpHdr As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents grpFtr As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents Label5 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl月 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl数量 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl金額 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl注文番号 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl単価 As DataDynamics.ActiveReports.Label
    Private WithEvents txt請求年月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl合計金額 As DataDynamics.ActiveReports.Label
    Private WithEvents txt合計金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl消費税額 As DataDynamics.ActiveReports.Label
    Private WithEvents txt消費税額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl請求金額 As DataDynamics.ActiveReports.Label
    Private WithEvents txt請求額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl日 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl単位 As DataDynamics.ActiveReports.Label
    Private WithEvents txt会社名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt住所 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtTEL As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl納品者 As DataDynamics.ActiveReports.Label
    Private WithEvents txt法人 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl社名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl住所 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl電話 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl請求明細書 As DataDynamics.ActiveReports.Label
    Private WithEvents txtNo As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl商品名 As DataDynamics.ActiveReports.Label
    Private WithEvents txt月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt商品名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt注文番号 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt数量 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt単価 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt単位 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt小計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
End Class
