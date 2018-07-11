<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class BancdorInvoiceStatement
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(BancdorInvoiceStatement))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txtNo = New DataDynamics.ActiveReports.TextBox()
        Me.txt商品名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt規格 = New DataDynamics.ActiveReports.TextBox()
        Me.txt数量 = New DataDynamics.ActiveReports.TextBox()
        Me.txt単価 = New DataDynamics.ActiveReports.TextBox()
        Me.txt金額 = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.txtHdrNo = New DataDynamics.ActiveReports.TextBox()
        Me.lbl請求明細書 = New DataDynamics.ActiveReports.Label()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr作業No = New DataDynamics.ActiveReports.GroupHeader()
        Me.lblNo = New DataDynamics.ActiveReports.Label()
        Me.lbl商品名 = New DataDynamics.ActiveReports.Label()
        Me.lbl数量 = New DataDynamics.ActiveReports.Label()
        Me.lbl金額 = New DataDynamics.ActiveReports.Label()
        Me.lbl規格 = New DataDynamics.ActiveReports.Label()
        Me.ｌｂｌ取引先コードNo = New DataDynamics.ActiveReports.Label()
        Me.txt取引先コード = New DataDynamics.ActiveReports.TextBox()
        Me.txt会社名 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl単価 = New DataDynamics.ActiveReports.Label()
        Me.lbl社印 = New DataDynamics.ActiveReports.Label()
        Me.txt請求年月 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl税抜御買上額 = New DataDynamics.ActiveReports.Label()
        Me.txt税抜御買上額 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl消費税額 = New DataDynamics.ActiveReports.Label()
        Me.txt消費税額 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl御請求額 = New DataDynamics.ActiveReports.Label()
        Me.txt御請求額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt郵便番号 = New DataDynamics.ActiveReports.TextBox()
        Me.txt住所1 = New DataDynamics.ActiveReports.TextBox()
        Me.txt住所2 = New DataDynamics.ActiveReports.TextBox()
        Me.txt請求先会社名 = New DataDynamics.ActiveReports.TextBox()
        Me.Line25 = New DataDynamics.ActiveReports.Line()
        Me.txt法人名 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl会社名 = New DataDynamics.ActiveReports.Label()
        Me.txt締日 = New DataDynamics.ActiveReports.TextBox()
        Me.txt振込銀行名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt口座番号 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl振込銀行 = New DataDynamics.ActiveReports.Label()
        Me.lbl預金口座 = New DataDynamics.ActiveReports.Label()
        Me.txt支店名 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl口座番号 = New DataDynamics.ActiveReports.Label()
        Me.txt預金口座名 = New DataDynamics.ActiveReports.TextBox()
        Me.grpFtr = New DataDynamics.ActiveReports.GroupFooter()
        Me.txt税抜合計額 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.txtNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt規格, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt数量, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdrNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl請求明細書, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl数量, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl規格, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ｌｂｌ取引先コードNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt取引先コード, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt会社名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl社印, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt請求年月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl税抜御買上額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt税抜御買上額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl消費税額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt消費税額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl御請求額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt御請求額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt郵便番号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt住所1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt住所2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt請求先会社名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt法人名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl会社名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt締日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt振込銀行名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt口座番号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl振込銀行, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl預金口座, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt支店名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl口座番号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt預金口座名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt税抜合計額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtNo, Me.txt商品名, Me.txt規格, Me.txt数量, Me.txt単価, Me.txt金額})
        Me.Detail.Height = 0.3346457!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        '
        'txtNo
        '
        Me.txtNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtNo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtNo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtNo.Height = 0.3346457!
        Me.txtNo.Left = 0.0!
        Me.txtNo.Name = "txtNo"
        Me.txtNo.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txtNo.Text = "99"
        Me.txtNo.Top = 0.0000007152557!
        Me.txtNo.Width = 0.3346457!
        '
        'txt商品名
        '
        Me.txt商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Height = 0.3346457!
        Me.txt商品名.Left = 0.3346457!
        Me.txt商品名.Name = "txt商品名"
        Me.txt商品名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt商品名.Text = "あああああいいいいいううううう"
        Me.txt商品名.Top = 0.0!
        Me.txt商品名.Width = 2.46063!
        '
        'txt規格
        '
        Me.txt規格.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt規格.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt規格.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt規格.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt規格.Height = 0.3346457!
        Me.txt規格.Left = 2.795276!
        Me.txt規格.Name = "txt規格"
        Me.txt規格.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt規格.Text = Nothing
        Me.txt規格.Top = 0.0!
        Me.txt規格.Width = 1.141732!
        '
        'txt数量
        '
        Me.txt数量.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt数量.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt数量.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt数量.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt数量.Height = 0.3346457!
        Me.txt数量.Left = 4.822834!
        Me.txt数量.Name = "txt数量"
        Me.txt数量.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt数量.Text = "999,999"
        Me.txt数量.Top = 0.0!
        Me.txt数量.Width = 0.7086614!
        '
        'txt単価
        '
        Me.txt単価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt単価.Height = 0.3346457!
        Me.txt単価.Left = 3.937008!
        Me.txt単価.Name = "txt単価"
        Me.txt単価.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt単価.Text = "999.00"
        Me.txt単価.Top = 0.0!
        Me.txt単価.Width = 0.8858268!
        '
        'txt金額
        '
        Me.txt金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt金額.Height = 0.3346457!
        Me.txt金額.Left = 5.531496!
        Me.txt金額.Name = "txt金額"
        Me.txt金額.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt金額.Text = "999,999,999"
        Me.txt金額.Top = 0.0!
        Me.txt金額.Width = 1.732283!
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtHdrNo, Me.lbl請求明細書})
        Me.PageHeader.Height = 0.4340277!
        Me.PageHeader.Name = "PageHeader"
        '
        'txtHdrNo
        '
        Me.txtHdrNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txtHdrNo.Height = 0.2362205!
        Me.txtHdrNo.Left = 6.164567!
        Me.txtHdrNo.Name = "txtHdrNo"
        Me.txtHdrNo.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txtHdrNo.Text = "No."
        Me.txtHdrNo.Top = 0.07283465!
        Me.txtHdrNo.Width = 1.077952!
        '
        'lbl請求明細書
        '
        Me.lbl請求明細書.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl請求明細書.Height = 0.3937008!
        Me.lbl請求明細書.HyperLink = Nothing
        Me.lbl請求明細書.Left = 2.067717!
        Me.lbl請求明細書.Name = "lbl請求明細書"
        Me.lbl請求明細書.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 14pt; font-weight: bold; text-align:" & _
    " center; vertical-align: middle; ddo-char-set: 1"
        Me.lbl請求明細書.Text = "請　求　明　細　書"
        Me.lbl請求明細書.Top = 0.0!
        Me.lbl請求明細書.Width = 2.834646!
        '
        'PageFooter
        '
        Me.PageFooter.CanGrow = False
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'grpHdr作業No
        '
        Me.grpHdr作業No.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblNo, Me.lbl商品名, Me.lbl数量, Me.lbl金額, Me.lbl規格, Me.ｌｂｌ取引先コードNo, Me.txt取引先コード, Me.txt会社名, Me.lbl単価, Me.lbl社印, Me.txt請求年月, Me.lbl税抜御買上額, Me.txt税抜御買上額, Me.lbl消費税額, Me.txt消費税額, Me.lbl御請求額, Me.txt御請求額, Me.txt郵便番号, Me.txt住所1, Me.txt住所2, Me.txt請求先会社名, Me.Line25, Me.txt法人名, Me.lbl会社名, Me.txt締日, Me.txt振込銀行名, Me.txt口座番号, Me.lbl振込銀行, Me.lbl預金口座, Me.txt支店名, Me.lbl口座番号, Me.txt預金口座名})
        Me.grpHdr作業No.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr作業No.Height = 3.141339!
        Me.grpHdr作業No.Name = "grpHdr作業No"
        Me.grpHdr作業No.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'lblNo
        '
        Me.lblNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblNo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblNo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblNo.Height = 0.3346457!
        Me.lblNo.HyperLink = Nothing
        Me.lblNo.Left = 0.0!
        Me.lblNo.Name = "lblNo"
        Me.lblNo.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lblNo.Text = "No"
        Me.lblNo.Top = 2.806693!
        Me.lblNo.Width = 0.3346457!
        '
        'lbl商品名
        '
        Me.lbl商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.Height = 0.3346457!
        Me.lbl商品名.HyperLink = Nothing
        Me.lbl商品名.Left = 0.3346457!
        Me.lbl商品名.Name = "lbl商品名"
        Me.lbl商品名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl商品名.Text = "商　　品　　名"
        Me.lbl商品名.Top = 2.806693!
        Me.lbl商品名.Width = 2.46063!
        '
        'lbl数量
        '
        Me.lbl数量.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl数量.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl数量.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl数量.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl数量.Height = 0.3346457!
        Me.lbl数量.HyperLink = Nothing
        Me.lbl数量.Left = 4.822834!
        Me.lbl数量.Name = "lbl数量"
        Me.lbl数量.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl数量.Text = "数　量"
        Me.lbl数量.Top = 2.806692!
        Me.lbl数量.Width = 0.7086614!
        '
        'lbl金額
        '
        Me.lbl金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl金額.Height = 0.3346457!
        Me.lbl金額.HyperLink = Nothing
        Me.lbl金額.Left = 5.531497!
        Me.lbl金額.Name = "lbl金額"
        Me.lbl金額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl金額.Text = "金　額"
        Me.lbl金額.Top = 2.806692!
        Me.lbl金額.Width = 1.732283!
        '
        'lbl規格
        '
        Me.lbl規格.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl規格.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl規格.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl規格.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl規格.Height = 0.3346457!
        Me.lbl規格.HyperLink = Nothing
        Me.lbl規格.Left = 2.795275!
        Me.lbl規格.Name = "lbl規格"
        Me.lbl規格.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl規格.Text = "規　格"
        Me.lbl規格.Top = 2.806692!
        Me.lbl規格.Width = 1.141732!
        '
        'ｌｂｌ取引先コードNo
        '
        Me.ｌｂｌ取引先コードNo.Height = 0.2362205!
        Me.ｌｂｌ取引先コードNo.HyperLink = Nothing
        Me.ｌｂｌ取引先コードNo.Left = 4.77874!
        Me.ｌｂｌ取引先コードNo.Name = "ｌｂｌ取引先コードNo"
        Me.ｌｂｌ取引先コードNo.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.ｌｂｌ取引先コードNo.Text = "取引先コードNo."
        Me.ｌｂｌ取引先コードNo.Top = 0.2826772!
        Me.ｌｂｌ取引先コードNo.Width = 1.202362!
        '
        'txt取引先コード
        '
        Me.txt取引先コード.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt取引先コード.Height = 0.2362205!
        Me.txt取引先コード.Left = 5.981102!
        Me.txt取引先コード.Name = "txt取引先コード"
        Me.txt取引先コード.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt取引先コード.Text = "123456"
        Me.txt取引先コード.Top = 0.2826772!
        Me.txt取引先コード.Width = 1.240157!
        '
        'txt会社名
        '
        Me.txt会社名.Height = 0.3937008!
        Me.txt会社名.Left = 4.915749!
        Me.txt会社名.Name = "txt会社名"
        Me.txt会社名.Style = "font-family: ＭＳ 明朝; font-size: 14pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt会社名.Text = "友　功　社"
        Me.txt会社名.Top = 0.6582682!
        Me.txt会社名.Width = 1.299213!
        '
        'lbl単価
        '
        Me.lbl単価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単価.Height = 0.3346457!
        Me.lbl単価.HyperLink = Nothing
        Me.lbl単価.Left = 3.937007!
        Me.lbl単価.Name = "lbl単価"
        Me.lbl単価.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl単価.Text = "単　価"
        Me.lbl単価.Top = 2.806692!
        Me.lbl単価.Width = 0.8858268!
        '
        'lbl社印
        '
        Me.lbl社印.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ExtraThickSolid
        Me.lbl社印.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.ExtraThickSolid
        Me.lbl社印.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.ExtraThickSolid
        Me.lbl社印.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.ExtraThickSolid
        Me.lbl社印.Height = 0.3543307!
        Me.lbl社印.HyperLink = Nothing
        Me.lbl社印.Left = 6.533072!
        Me.lbl社印.Name = "lbl社印"
        Me.lbl社印.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl社印.Text = "社印(朱肉)"
        Me.lbl社印.Top = 0.7582682!
        Me.lbl社印.Width = 0.7086614!
        '
        'txt請求年月
        '
        Me.txt請求年月.Height = 0.1968504!
        Me.txt請求年月.Left = 5.8063!
        Me.txt請求年月.Name = "txt請求年月"
        Me.txt請求年月.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt請求年月.Text = "平成99年99月99日"
        Me.txt請求年月.Top = 0.0!
        Me.txt請求年月.Width = 1.43189!
        '
        'lbl税抜御買上額
        '
        Me.lbl税抜御買上額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl税抜御買上額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl税抜御買上額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl税抜御買上額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl税抜御買上額.Height = 0.3149606!
        Me.lbl税抜御買上額.HyperLink = Nothing
        Me.lbl税抜御買上額.Left = 0.0!
        Me.lbl税抜御買上額.Name = "lbl税抜御買上額"
        Me.lbl税抜御買上額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lbl税抜御買上額.Text = "税　抜　御　買　上　額"
        Me.lbl税抜御買上額.Top = 1.904725!
        Me.lbl税抜御買上額.Width = 2.519685!
        '
        'txt税抜御買上額
        '
        Me.txt税抜御買上額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税抜御買上額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税抜御買上額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税抜御買上額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税抜御買上額.Height = 0.511811!
        Me.txt税抜御買上額.Left = 0.0!
        Me.txt税抜御買上額.Name = "txt税抜御買上額"
        Me.txt税抜御買上額.Style = "font-family: ＭＳ 明朝; font-size: 12pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt税抜御買上額.Text = "　　　999,999"
        Me.txt税抜御買上額.Top = 2.219685!
        Me.txt税抜御買上額.Width = 2.519685!
        '
        'lbl消費税額
        '
        Me.lbl消費税額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl消費税額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl消費税額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl消費税額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl消費税額.Height = 0.3149606!
        Me.lbl消費税額.HyperLink = Nothing
        Me.lbl消費税額.Left = 2.519685!
        Me.lbl消費税額.Name = "lbl消費税額"
        Me.lbl消費税額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lbl消費税額.Text = "消　費　税　額"
        Me.lbl消費税額.Top = 1.904725!
        Me.lbl消費税額.Width = 1.811024!
        '
        'txt消費税額
        '
        Me.txt消費税額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税額.Height = 0.511811!
        Me.txt消費税額.Left = 2.519685!
        Me.txt消費税額.Name = "txt消費税額"
        Me.txt消費税額.Style = "font-family: ＭＳ 明朝; font-size: 12pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt消費税額.Text = "　　　999,999"
        Me.txt消費税額.Top = 2.219685!
        Me.txt消費税額.Width = 1.811024!
        '
        'lbl御請求額
        '
        Me.lbl御請求額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl御請求額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl御請求額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl御請求額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl御請求額.Height = 0.3149606!
        Me.lbl御請求額.HyperLink = Nothing
        Me.lbl御請求額.Left = 4.330709!
        Me.lbl御請求額.Name = "lbl御請求額"
        Me.lbl御請求額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lbl御請求額.Text = "御　請　求　額"
        Me.lbl御請求額.Top = 1.904725!
        Me.lbl御請求額.Width = 2.933071!
        '
        'txt御請求額
        '
        Me.txt御請求額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt御請求額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt御請求額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt御請求額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt御請求額.Height = 0.511811!
        Me.txt御請求額.Left = 4.330709!
        Me.txt御請求額.Name = "txt御請求額"
        Me.txt御請求額.Style = "font-family: ＭＳ 明朝; font-size: 12pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt御請求額.Text = "　　　999,999"
        Me.txt御請求額.Top = 2.219685!
        Me.txt御請求額.Width = 2.933071!
        '
        'txt郵便番号
        '
        Me.txt郵便番号.Height = 0.2362205!
        Me.txt郵便番号.Left = 0.0!
        Me.txt郵便番号.Name = "txt郵便番号"
        Me.txt郵便番号.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt郵便番号.Text = "〒330-0061"
        Me.txt郵便番号.Top = 0.0!
        Me.txt郵便番号.Width = 3.182678!
        '
        'txt住所1
        '
        Me.txt住所1.Height = 0.2362205!
        Me.txt住所1.Left = 0.0!
        Me.txt住所1.Name = "txt住所1"
        Me.txt住所1.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt住所1.Text = "埼玉県さいたま市浦和区常盤"
        Me.txt住所1.Top = 0.307874!
        Me.txt住所1.Width = 3.182678!
        '
        'txt住所2
        '
        Me.txt住所2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt住所2.Height = 0.2362205!
        Me.txt住所2.Left = 0.0!
        Me.txt住所2.Name = "txt住所2"
        Me.txt住所2.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt住所2.Text = "１０－３－１５"
        Me.txt住所2.Top = 0.5440945!
        Me.txt住所2.Width = 3.182678!
        '
        'txt請求先会社名
        '
        Me.txt請求先会社名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt請求先会社名.Height = 0.2362205!
        Me.txt請求先会社名.Left = 0.0!
        Me.txt請求先会社名.Name = "txt請求先会社名"
        Me.txt請求先会社名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt請求先会社名.Text = "株式会社　　ボンドール本部　　　　　　　御中"
        Me.txt請求先会社名.Top = 0.9062993!
        Me.txt請求先会社名.Width = 3.182678!
        '
        'Line25
        '
        Me.Line25.Height = 0.0!
        Me.Line25.Left = 3.635432!
        Me.Line25.LineWeight = 3.0!
        Me.Line25.Name = "Line25"
        Me.Line25.Top = 1.082677!
        Me.Line25.Width = 2.607876!
        Me.Line25.X1 = 6.243308!
        Me.Line25.X2 = 3.635432!
        Me.Line25.Y1 = 1.082677!
        Me.Line25.Y2 = 1.082677!
        '
        'txt法人名
        '
        Me.txt法人名.Height = 0.1968504!
        Me.txt法人名.Left = 4.31811!
        Me.txt法人名.Name = "txt法人名"
        Me.txt法人名.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt法人名.Text = "株式会社"
        Me.txt法人名.Top = 0.8543312!
        Me.txt法人名.Width = 0.5905512!
        '
        'lbl会社名
        '
        Me.lbl会社名.Height = 0.1968504!
        Me.lbl会社名.HyperLink = Nothing
        Me.lbl会社名.Left = 3.816535!
        Me.lbl会社名.Name = "lbl会社名"
        Me.lbl会社名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lbl会社名.Text = "会社名"
        Me.lbl会社名.Top = 0.8543312!
        Me.lbl会社名.Width = 0.511811!
        '
        'txt締日
        '
        Me.txt締日.Height = 0.1968504!
        Me.txt締日.Left = 0.5937008!
        Me.txt締日.Name = "txt締日"
        Me.txt締日.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: bottom;" & _
    " ddo-char-set: 1"
        Me.txt締日.Text = "(99月99日締切分)"
        Me.txt締日.Top = 1.590551!
        Me.txt締日.Width = 1.377953!
        '
        'txt振込銀行名
        '
        Me.txt振込銀行名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt振込銀行名.Height = 0.2559055!
        Me.txt振込銀行名.Left = 4.496063!
        Me.txt振込銀行名.Name = "txt振込銀行名"
        Me.txt振込銀行名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt振込銀行名.Text = "あああああ銀行"
        Me.txt振込銀行名.Top = 1.314173!
        Me.txt振込銀行名.Width = 1.377953!
        '
        'txt口座番号
        '
        Me.txt口座番号.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt口座番号.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt口座番号.Height = 0.2559055!
        Me.txt口座番号.Left = 6.070868!
        Me.txt口座番号.Name = "txt口座番号"
        Me.txt口座番号.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt口座番号.Text = "123456"
        Me.txt口座番号.Top = 1.570079!
        Me.txt口座番号.Width = 1.181102!
        '
        'lbl振込銀行
        '
        Me.lbl振込銀行.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl振込銀行.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl振込銀行.Height = 0.2559055!
        Me.lbl振込銀行.HyperLink = Nothing
        Me.lbl振込銀行.Left = 3.787402!
        Me.lbl振込銀行.Name = "lbl振込銀行"
        Me.lbl振込銀行.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lbl振込銀行.Text = "銀行振込"
        Me.lbl振込銀行.Top = 1.314173!
        Me.lbl振込銀行.Width = 0.7086614!
        '
        'lbl預金口座
        '
        Me.lbl預金口座.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl預金口座.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl預金口座.Height = 0.2559055!
        Me.lbl預金口座.HyperLink = Nothing
        Me.lbl預金口座.Left = 3.787402!
        Me.lbl預金口座.Name = "lbl預金口座"
        Me.lbl預金口座.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lbl預金口座.Text = "預金口座"
        Me.lbl預金口座.Top = 1.570079!
        Me.lbl預金口座.Width = 0.7086614!
        '
        'txt支店名
        '
        Me.txt支店名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt支店名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt支店名.Height = 0.2559055!
        Me.txt支店名.Left = 5.874017!
        Me.txt支店名.Name = "txt支店名"
        Me.txt支店名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt支店名.Text = "あああああ支店"
        Me.txt支店名.Top = 1.314173!
        Me.txt支店名.Width = 1.377953!
        '
        'lbl口座番号
        '
        Me.lbl口座番号.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl口座番号.Height = 0.2559055!
        Me.lbl口座番号.HyperLink = Nothing
        Me.lbl口座番号.Left = 5.362206!
        Me.lbl口座番号.Name = "lbl口座番号"
        Me.lbl口座番号.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lbl口座番号.Text = "口座番号"
        Me.lbl口座番号.Top = 1.570079!
        Me.lbl口座番号.Width = 0.7086611!
        '
        'txt預金口座名
        '
        Me.txt預金口座名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt預金口座名.Height = 0.2559055!
        Me.txt預金口座名.Left = 4.496063!
        Me.txt預金口座名.Name = "txt預金口座名"
        Me.txt預金口座名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt預金口座名.Text = "あああ"
        Me.txt預金口座名.Top = 1.570079!
        Me.txt預金口座名.Width = 0.8661417!
        '
        'grpFtr
        '
        Me.grpFtr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt税抜合計額, Me.TextBox2})
        Me.grpFtr.Height = 0.3346457!
        Me.grpFtr.Name = "grpFtr"
        '
        'txt税抜合計額
        '
        Me.txt税抜合計額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税抜合計額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税抜合計額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税抜合計額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税抜合計額.Height = 0.3346457!
        Me.txt税抜合計額.Left = 5.531496!
        Me.txt税抜合計額.Name = "txt税抜合計額"
        Me.txt税抜合計額.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt税抜合計額.Text = "\999,999,999"
        Me.txt税抜合計額.Top = 0.0!
        Me.txt税抜合計額.Width = 1.732283!
        '
        'TextBox2
        '
        Me.TextBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Height = 0.3346457!
        Me.TextBox2.Left = 0.0!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.TextBox2.Text = "　　　　税 抜 合 計 額　　　　　　　　　　　　　　　　　　　　　　　→"
        Me.TextBox2.Top = 0.0!
        Me.TextBox2.Width = 5.531496!
        '
        'BancdorInvoiceStatement
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
        Me.Sections.Add(Me.grpHdr作業No)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.grpFtr)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.txtNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt規格, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt数量, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdrNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl請求明細書, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl数量, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl規格, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ｌｂｌ取引先コードNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt取引先コード, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt会社名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl社印, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt請求年月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl税抜御買上額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt税抜御買上額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl消費税額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt消費税額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl御請求額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt御請求額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt郵便番号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt住所1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt住所2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt請求先会社名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt法人名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl会社名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt締日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt振込銀行名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt口座番号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl振込銀行, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl預金口座, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt支店名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl口座番号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt預金口座名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt税抜合計額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txtNo As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt商品名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt規格 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt数量 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt単価 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpHdr作業No As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents lblNo As DataDynamics.ActiveReports.Label
    Private WithEvents lbl商品名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl数量 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl金額 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl規格 As DataDynamics.ActiveReports.Label
    Private WithEvents ｌｂｌ取引先コードNo As DataDynamics.ActiveReports.Label
    Private WithEvents txt取引先コード As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt会社名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl単価 As DataDynamics.ActiveReports.Label
    Private WithEvents grpFtr As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents lbl社印 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl税抜御買上額 As DataDynamics.ActiveReports.Label
    Private WithEvents txt税抜御買上額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl消費税額 As DataDynamics.ActiveReports.Label
    Private WithEvents txt消費税額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl御請求額 As DataDynamics.ActiveReports.Label
    Private WithEvents txt御請求額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtHdrNo As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl請求明細書 As DataDynamics.ActiveReports.Label
    Private WithEvents txt郵便番号 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt住所1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt住所2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt請求先会社名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt請求年月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Line25 As DataDynamics.ActiveReports.Line
    Private WithEvents txt法人名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl会社名 As DataDynamics.ActiveReports.Label
    Private WithEvents txt締日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt税抜合計額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt振込銀行名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt口座番号 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl振込銀行 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl預金口座 As DataDynamics.ActiveReports.Label
    Private WithEvents txt支店名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl口座番号 As DataDynamics.ActiveReports.Label
    Private WithEvents txt預金口座名 As DataDynamics.ActiveReports.TextBox
End Class
