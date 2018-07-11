<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class OrderSlipSub
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(OrderSlipSub))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt枝番 = New DataDynamics.ActiveReports.TextBox()
        Me.txt定番 = New DataDynamics.ActiveReports.TextBox()
        Me.txt商品名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt発注数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt発注単価 = New DataDynamics.ActiveReports.TextBox()
        Me.txt顧客発注No = New DataDynamics.ActiveReports.TextBox()
        Me.txt備考 = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr得意先CD = New DataDynamics.ActiveReports.GroupHeader()
        Me.lbl発注伝票 = New DataDynamics.ActiveReports.Label()
        Me.lbl枝番 = New DataDynamics.ActiveReports.Label()
        Me.lbl定番 = New DataDynamics.ActiveReports.Label()
        Me.lbl発注数 = New DataDynamics.ActiveReports.Label()
        Me.lbl備考 = New DataDynamics.ActiveReports.Label()
        Me.lbl商品名 = New DataDynamics.ActiveReports.Label()
        Me.ｌｂｌ作業No = New DataDynamics.ActiveReports.Label()
        Me.txt作業No = New DataDynamics.ActiveReports.TextBox()
        Me.Barcode = New DataDynamics.ActiveReports.Barcode()
        Me.lblHdr顧客様No = New DataDynamics.ActiveReports.Label()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.lblHdrユーザーNo = New DataDynamics.ActiveReports.Label()
        Me.Label7 = New DataDynamics.ActiveReports.Label()
        Me.lblHdr本台帳番号 = New DataDynamics.ActiveReports.Label()
        Me.Label10 = New DataDynamics.ActiveReports.Label()
        Me.lblHdr枝番 = New DataDynamics.ActiveReports.Label()
        Me.txtHdr顧客様No = New DataDynamics.ActiveReports.TextBox()
        Me.txtHdrユーザーNp = New DataDynamics.ActiveReports.TextBox()
        Me.txtHdr本台帳番号 = New DataDynamics.ActiveReports.TextBox()
        Me.txtHdr枝番 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl発注先名 = New DataDynamics.ActiveReports.Label()
        Me.txt発注先名 = New DataDynamics.ActiveReports.TextBox()
        Me.txtHdr商品名 = New DataDynamics.ActiveReports.TextBox()
        Me.lblHdr商品名 = New DataDynamics.ActiveReports.Label()
        Me.lbl発注日 = New DataDynamics.ActiveReports.Label()
        Me.txt発注日 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl納期 = New DataDynamics.ActiveReports.Label()
        Me.txt納期 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl顧客商品No = New DataDynamics.ActiveReports.Label()
        Me.txt顧客商品No = New DataDynamics.ActiveReports.TextBox()
        Me.lblHdr発注数 = New DataDynamics.ActiveReports.Label()
        Me.txtHdr発注数 = New DataDynamics.ActiveReports.TextBox()
        Me.lblHdr通数 = New DataDynamics.ActiveReports.Label()
        Me.txtHdr通数 = New DataDynamics.ActiveReports.TextBox()
        Me.lblHdr発注単価 = New DataDynamics.ActiveReports.Label()
        Me.txtHdr発注単価 = New DataDynamics.ActiveReports.TextBox()
        Me.txtHdr発注金額 = New DataDynamics.ActiveReports.TextBox()
        Me.lblHdr発注金額 = New DataDynamics.ActiveReports.Label()
        Me.Label5 = New DataDynamics.ActiveReports.Label()
        Me.lbl発注単価 = New DataDynamics.ActiveReports.Label()
        Me.lbl顧客発注No = New DataDynamics.ActiveReports.Label()
        Me.grpFtr得意先CD = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox()
        Me.OrderSlipSubPaper = New DataDynamics.ActiveReports.SubReport()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.Label14 = New DataDynamics.ActiveReports.Label()
        Me.txt巻取 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl巻取 = New DataDynamics.ActiveReports.Label()
        Me.lbl出し方向 = New DataDynamics.ActiveReports.Label()
        Me.txt出し方向 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl紙管 = New DataDynamics.ActiveReports.Label()
        Me.txt紙管 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl枚数 = New DataDynamics.ActiveReports.Label()
        Me.txt枚数 = New DataDynamics.ActiveReports.TextBox()
        Me.txtスリッター = New DataDynamics.ActiveReports.TextBox()
        Me.lblｽﾘｯﾀｰ = New DataDynamics.ActiveReports.Label()
        Me.lblｽﾘｯﾀｰ巾 = New DataDynamics.ActiveReports.Label()
        Me.txtスリッター巾 = New DataDynamics.ActiveReports.TextBox()
        Me.lblカット = New DataDynamics.ActiveReports.Label()
        Me.txtｶｯﾄ = New DataDynamics.ActiveReports.TextBox()
        Me.txt1ｼｰﾄ枚数 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl1シート枚数 = New DataDynamics.ActiveReports.Label()
        Me.txt包装枚数 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl包装枚数 = New DataDynamics.ActiveReports.Label()
        Me.txt送りピッチ = New DataDynamics.ActiveReports.TextBox()
        Me.lbl送りピッチ = New DataDynamics.ActiveReports.Label()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.Label4 = New DataDynamics.ActiveReports.Label()
        Me.lbl刃型No = New DataDynamics.ActiveReports.Label()
        Me.txt刃型No = New DataDynamics.ActiveReports.TextBox()
        Me.txt版Np = New DataDynamics.ActiveReports.TextBox()
        Me.lbl版Np = New DataDynamics.ActiveReports.Label()
        Me.TextBox18 = New DataDynamics.ActiveReports.TextBox()
        Me.Label15 = New DataDynamics.ActiveReports.Label()
        Me.Label16 = New DataDynamics.ActiveReports.Label()
        Me.TextBox19 = New DataDynamics.ActiveReports.TextBox()
        Me.Label17 = New DataDynamics.ActiveReports.Label()
        Me.TextBox21 = New DataDynamics.ActiveReports.TextBox()
        Me.Label21 = New DataDynamics.ActiveReports.Label()
        Me.Label22 = New DataDynamics.ActiveReports.Label()
        Me.OrderSlipSubNote = New DataDynamics.ActiveReports.SubReport()
        Me.OrderSlipSubDelivery = New DataDynamics.ActiveReports.SubReport()
        Me.TextBox71 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox91 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox92 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox94 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox95 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox96 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox93 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox97 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox98 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.txt枝番, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt定番, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt発注数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt発注単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt顧客発注No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt備考, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl発注伝票, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl枝番, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl定番, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl発注数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl備考, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ｌｂｌ作業No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt作業No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr顧客様No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdrユーザーNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr本台帳番号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr枝番, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr顧客様No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdrユーザーNp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr本台帳番号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr枝番, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl発注先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt発注先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl発注日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt発注日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl納期, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt納期, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl顧客商品No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt顧客商品No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr発注数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr発注数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr発注単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr発注単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr発注金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr発注金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl発注単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl顧客発注No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt巻取, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl巻取, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl出し方向, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt出し方向, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl紙管, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt紙管, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl枚数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt枚数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtスリッター, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblｽﾘｯﾀｰ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblｽﾘｯﾀｰ巾, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtスリッター巾, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblカット, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtｶｯﾄ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt1ｼｰﾄ枚数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl1シート枚数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt包装枚数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl包装枚数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt送りピッチ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl送りピッチ, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl刃型No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt刃型No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt版Np, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl版Np, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox71, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox91, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox92, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox94, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox95, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox96, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox93, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox97, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox98, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt枝番, Me.txt定番, Me.txt商品名, Me.txt発注数, Me.txt発注単価, Me.txt顧客発注No, Me.txt備考})
        Me.Detail.Height = 0.3937008!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        '
        'txt枝番
        '
        Me.txt枝番.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt枝番.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt枝番.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt枝番.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt枝番.Height = 0.3937008!
        Me.txt枝番.Left = 0.0!
        Me.txt枝番.Name = "txt枝番"
        Me.txt枝番.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: top; ddo-" & _
    "char-set: 1"
        Me.txt枝番.Text = "12"
        Me.txt枝番.Top = 0.0000007152557!
        Me.txt枝番.Width = 0.1968504!
        '
        'txt定番
        '
        Me.txt定番.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt定番.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt定番.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt定番.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt定番.Height = 0.3937008!
        Me.txt定番.Left = 0.1968504!
        Me.txt定番.Name = "txt定番"
        Me.txt定番.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: top; ddo-" & _
    "char-set: 1"
        Me.txt定番.Text = "99,999"
        Me.txt定番.Top = 0.0!
        Me.txt定番.Width = 0.9251968!
        '
        'txt商品名
        '
        Me.txt商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Height = 0.3937008!
        Me.txt商品名.Left = 1.122047!
        Me.txt商品名.Name = "txt商品名"
        Me.txt商品名.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: justify; vertical-align: top; ddo" & _
    "-char-set: 1"
        Me.txt商品名.Text = "9,999"
        Me.txt商品名.Top = 0.0!
        Me.txt商品名.Width = 2.086614!
        '
        'txt発注数
        '
        Me.txt発注数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注数.Height = 0.3937008!
        Me.txt発注数.Left = 3.208661!
        Me.txt発注数.Name = "txt発注数"
        Me.txt発注数.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: right; vertical-align: top; ddo-c" & _
    "har-set: 1"
        Me.txt発注数.Text = "99,9999"
        Me.txt発注数.Top = 0.0!
        Me.txt発注数.Width = 0.8267716!
        '
        'txt発注単価
        '
        Me.txt発注単価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注単価.Height = 0.3937008!
        Me.txt発注単価.Left = 4.035433!
        Me.txt発注単価.Name = "txt発注単価"
        Me.txt発注単価.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: right; vertical-align: top; ddo-c" & _
    "har-set: 1"
        Me.txt発注単価.Text = "999,999,999"
        Me.txt発注単価.Top = 0.0!
        Me.txt発注単価.Width = 0.8661417!
        '
        'txt顧客発注No
        '
        Me.txt顧客発注No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt顧客発注No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt顧客発注No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt顧客発注No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt顧客発注No.Height = 0.3937008!
        Me.txt顧客発注No.Left = 4.901575!
        Me.txt顧客発注No.Name = "txt顧客発注No"
        Me.txt顧客発注No.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: top; ddo-" & _
    "char-set: 1"
        Me.txt顧客発注No.Text = "999,999,999"
        Me.txt顧客発注No.Top = 0.0!
        Me.txt顧客発注No.Width = 0.8464568!
        '
        'txt備考
        '
        Me.txt備考.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt備考.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt備考.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt備考.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt備考.Height = 0.3937008!
        Me.txt備考.Left = 5.748032!
        Me.txt備考.Name = "txt備考"
        Me.txt備考.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: justify; vertical-align: top; ddo" & _
    "-char-set: 1"
        Me.txt備考.Text = "999,999,999"
        Me.txt備考.Top = 0.0!
        Me.txt備考.Width = 1.476378!
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
        'grpHdr得意先CD
        '
        Me.grpHdr得意先CD.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lbl発注伝票, Me.lbl枝番, Me.lbl定番, Me.lbl発注数, Me.lbl備考, Me.lbl商品名, Me.ｌｂｌ作業No, Me.txt作業No, Me.Barcode, Me.lblHdr顧客様No, Me.Label1, Me.lblHdrユーザーNo, Me.Label7, Me.lblHdr本台帳番号, Me.Label10, Me.lblHdr枝番, Me.txtHdr顧客様No, Me.txtHdrユーザーNp, Me.txtHdr本台帳番号, Me.txtHdr枝番, Me.lbl発注先名, Me.txt発注先名, Me.txtHdr商品名, Me.lblHdr商品名, Me.lbl発注日, Me.txt発注日, Me.lbl納期, Me.txt納期, Me.lbl顧客商品No, Me.txt顧客商品No, Me.lblHdr発注数, Me.txtHdr発注数, Me.lblHdr通数, Me.txtHdr通数, Me.lblHdr発注単価, Me.txtHdr発注単価, Me.txtHdr発注金額, Me.lblHdr発注金額, Me.Label5, Me.lbl発注単価, Me.lbl顧客発注No})
        Me.grpHdr得意先CD.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr得意先CD.Height = 2.041339!
        Me.grpHdr得意先CD.Name = "grpHdr得意先CD"
        Me.grpHdr得意先CD.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'lbl発注伝票
        '
        Me.lbl発注伝票.Height = 0.3937008!
        Me.lbl発注伝票.HyperLink = Nothing
        Me.lbl発注伝票.Left = 3.981103!
        Me.lbl発注伝票.Name = "lbl発注伝票"
        Me.lbl発注伝票.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 12pt; font-weight: bold; text-align:" & _
    " center; vertical-align: middle; ddo-char-set: 1"
        Me.lbl発注伝票.Text = "発 注 伝 票"
        Me.lbl発注伝票.Top = 0.0!
        Me.lbl発注伝票.Width = 1.215748!
        '
        'lbl枝番
        '
        Me.lbl枝番.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl枝番.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl枝番.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl枝番.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl枝番.Height = 0.1968504!
        Me.lbl枝番.HyperLink = Nothing
        Me.lbl枝番.Left = 0.0!
        Me.lbl枝番.Name = "lbl枝番"
        Me.lbl枝番.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 7pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lbl枝番.Text = "枝"
        Me.lbl枝番.Top = 1.844488!
        Me.lbl枝番.Width = 0.1968504!
        '
        'lbl定番
        '
        Me.lbl定番.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl定番.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl定番.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl定番.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl定番.Height = 0.1968504!
        Me.lbl定番.HyperLink = Nothing
        Me.lbl定番.Left = 0.1968504!
        Me.lbl定番.Name = "lbl定番"
        Me.lbl定番.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 7pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lbl定番.Text = "定　番"
        Me.lbl定番.Top = 1.844488!
        Me.lbl定番.Width = 0.9251968!
        '
        'lbl発注数
        '
        Me.lbl発注数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発注数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発注数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発注数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発注数.Height = 0.1968504!
        Me.lbl発注数.HyperLink = Nothing
        Me.lbl発注数.Left = 3.208662!
        Me.lbl発注数.Name = "lbl発注数"
        Me.lbl発注数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 7pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lbl発注数.Text = "発 注 数"
        Me.lbl発注数.Top = 1.844488!
        Me.lbl発注数.Width = 0.8267716!
        '
        'lbl備考
        '
        Me.lbl備考.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl備考.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl備考.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl備考.Height = 0.1968504!
        Me.lbl備考.HyperLink = Nothing
        Me.lbl備考.Left = 5.748032!
        Me.lbl備考.Name = "lbl備考"
        Me.lbl備考.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 7pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lbl備考.Text = "備　　考"
        Me.lbl備考.Top = 1.844488!
        Me.lbl備考.Width = 1.476378!
        '
        'lbl商品名
        '
        Me.lbl商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.Height = 0.1968504!
        Me.lbl商品名.HyperLink = Nothing
        Me.lbl商品名.Left = 1.122047!
        Me.lbl商品名.Name = "lbl商品名"
        Me.lbl商品名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 7pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lbl商品名.Text = "商　　品　　名"
        Me.lbl商品名.Top = 1.844488!
        Me.lbl商品名.Width = 2.086614!
        '
        'ｌｂｌ作業No
        '
        Me.ｌｂｌ作業No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ作業No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ作業No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ作業No.Height = 0.2165354!
        Me.ｌｂｌ作業No.HyperLink = Nothing
        Me.ｌｂｌ作業No.Left = 6.102363!
        Me.ｌｂｌ作業No.Name = "ｌｂｌ作業No"
        Me.ｌｂｌ作業No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.ｌｂｌ作業No.Text = "作業No"
        Me.ｌｂｌ作業No.Top = 0.6165355!
        Me.ｌｂｌ作業No.Width = 1.122047!
        '
        'txt作業No
        '
        Me.txt作業No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Height = 0.2165354!
        Me.txt作業No.Left = 6.102363!
        Me.txt作業No.Name = "txt作業No"
        Me.txt作業No.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt作業No.Text = "123456"
        Me.txt作業No.Top = 0.8330709!
        Me.txt作業No.Width = 1.122047!
        '
        'Barcode
        '
        Me.Barcode.CheckSumEnabled = False
        Me.Barcode.DataField = "ReportNoJudge"
        Me.Barcode.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.Barcode.Height = 0.3937008!
        Me.Barcode.Left = 5.964567!
        Me.Barcode.Name = "Barcode"
        Me.Barcode.Style = DataDynamics.ActiveReports.BarCodeStyle.Code39
        Me.Barcode.Text = "Barcode"
        Me.Barcode.Top = 0.0!
        Me.Barcode.Width = 1.259843!
        '
        'lblHdr顧客様No
        '
        Me.lblHdr顧客様No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr顧客様No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr顧客様No.Height = 0.2362205!
        Me.lblHdr顧客様No.HyperLink = Nothing
        Me.lblHdr顧客様No.Left = 0.0!
        Me.lblHdr顧客様No.Name = "lblHdr顧客様No"
        Me.lblHdr顧客様No.Style = "color: Black; font-family: ＭＳ ゴシック; font-size: 9pt; font-weight: normal; text-ali" & _
    "gn: center; vertical-align: middle; ddo-char-set: 1"
        Me.lblHdr顧客様No.Text = "顧客様No"
        Me.lblHdr顧客様No.Top = 0.0!
        Me.lblHdr顧客様No.Width = 0.8661417!
        '
        'Label1
        '
        Me.Label1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label1.Height = 0.5511811!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.8661417!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "color: Black; font-family: ＭＳ ゴシック; font-size: 12pt; font-weight: normal; text-al" & _
    "ign: center; vertical-align: bottom; ddo-char-set: 1"
        Me.Label1.Text = "―"
        Me.Label1.Top = 0.0!
        Me.Label1.Width = 0.2362205!
        '
        'lblHdrユーザーNo
        '
        Me.lblHdrユーザーNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdrユーザーNo.Height = 0.2362205!
        Me.lblHdrユーザーNo.HyperLink = Nothing
        Me.lblHdrユーザーNo.Left = 1.102362!
        Me.lblHdrユーザーNo.Name = "lblHdrユーザーNo"
        Me.lblHdrユーザーNo.Style = "color: Black; font-family: ＭＳ ゴシック; font-size: 9pt; font-weight: normal; text-ali" & _
    "gn: center; vertical-align: middle; ddo-char-set: 1"
        Me.lblHdrユーザーNo.Text = "ユーザーNo"
        Me.lblHdrユーザーNo.Top = 0.0!
        Me.lblHdrユーザーNo.Width = 0.8661417!
        '
        'Label7
        '
        Me.Label7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label7.Height = 0.5511811!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 1.968504!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "color: Black; font-family: ＭＳ ゴシック; font-size: 12pt; font-weight: normal; text-al" & _
    "ign: center; vertical-align: bottom; ddo-char-set: 1"
        Me.Label7.Text = "―"
        Me.Label7.Top = 0.0!
        Me.Label7.Width = 0.2362205!
        '
        'lblHdr本台帳番号
        '
        Me.lblHdr本台帳番号.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr本台帳番号.Height = 0.2362205!
        Me.lblHdr本台帳番号.HyperLink = Nothing
        Me.lblHdr本台帳番号.Left = 2.204724!
        Me.lblHdr本台帳番号.Name = "lblHdr本台帳番号"
        Me.lblHdr本台帳番号.Style = "color: Black; font-family: ＭＳ ゴシック; font-size: 9pt; font-weight: normal; text-ali" & _
    "gn: center; vertical-align: middle; ddo-char-set: 1"
        Me.lblHdr本台帳番号.Text = "本台帳番号"
        Me.lblHdr本台帳番号.Top = 9.313226E-10!
        Me.lblHdr本台帳番号.Width = 0.8661417!
        '
        'Label10
        '
        Me.Label10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label10.Height = 0.5511811!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 3.070866!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "color: Black; font-family: ＭＳ ゴシック; font-size: 12pt; font-weight: normal; text-al" & _
    "ign: center; vertical-align: bottom; ddo-char-set: 1"
        Me.Label10.Text = "―"
        Me.Label10.Top = 0.0!
        Me.Label10.Width = 0.2362205!
        '
        'lblHdr枝番
        '
        Me.lblHdr枝番.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr枝番.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr枝番.Height = 0.2362205!
        Me.lblHdr枝番.HyperLink = Nothing
        Me.lblHdr枝番.Left = 3.307087!
        Me.lblHdr枝番.Name = "lblHdr枝番"
        Me.lblHdr枝番.Style = "color: Black; font-family: ＭＳ ゴシック; font-size: 9pt; font-weight: normal; text-ali" & _
    "gn: center; vertical-align: middle; ddo-char-set: 1"
        Me.lblHdr枝番.Text = "枝番"
        Me.lblHdr枝番.Top = 0.0!
        Me.lblHdr枝番.Width = 0.3937008!
        '
        'txtHdr顧客様No
        '
        Me.txtHdr顧客様No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr顧客様No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr顧客様No.Height = 0.3149606!
        Me.txtHdr顧客様No.Left = 0.0!
        Me.txtHdr顧客様No.Name = "txtHdr顧客様No"
        Me.txtHdr顧客様No.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.txtHdr顧客様No.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txtHdr顧客様No.Text = "1234"
        Me.txtHdr顧客様No.Top = 0.2362205!
        Me.txtHdr顧客様No.Width = 0.8661417!
        '
        'txtHdrユーザーNp
        '
        Me.txtHdrユーザーNp.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdrユーザーNp.Height = 0.3149606!
        Me.txtHdrユーザーNp.Left = 1.102362!
        Me.txtHdrユーザーNp.Name = "txtHdrユーザーNp"
        Me.txtHdrユーザーNp.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.txtHdrユーザーNp.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txtHdrユーザーNp.Text = "123456"
        Me.txtHdrユーザーNp.Top = 0.2362205!
        Me.txtHdrユーザーNp.Width = 0.8661417!
        '
        'txtHdr本台帳番号
        '
        Me.txtHdr本台帳番号.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr本台帳番号.Height = 0.3149606!
        Me.txtHdr本台帳番号.Left = 2.204724!
        Me.txtHdr本台帳番号.Name = "txtHdr本台帳番号"
        Me.txtHdr本台帳番号.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.txtHdr本台帳番号.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txtHdr本台帳番号.Text = "123456"
        Me.txtHdr本台帳番号.Top = 0.2362205!
        Me.txtHdr本台帳番号.Width = 0.8661417!
        '
        'txtHdr枝番
        '
        Me.txtHdr枝番.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr枝番.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr枝番.Height = 0.3149606!
        Me.txtHdr枝番.Left = 3.307087!
        Me.txtHdr枝番.Name = "txtHdr枝番"
        Me.txtHdr枝番.Padding = New DataDynamics.ActiveReports.PaddingEx(1, 0, 0, 0)
        Me.txtHdr枝番.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txtHdr枝番.Text = "12"
        Me.txtHdr枝番.Top = 0.2362205!
        Me.txtHdr枝番.Width = 0.3937008!
        '
        'lbl発注先名
        '
        Me.lbl発注先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発注先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発注先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発注先名.Height = 0.2165354!
        Me.lbl発注先名.HyperLink = Nothing
        Me.lbl発注先名.Left = 0.0!
        Me.lbl発注先名.Name = "lbl発注先名"
        Me.lbl発注先名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lbl発注先名.Text = "発 注 先 名"
        Me.lbl発注先名.Top = 0.6165355!
        Me.lbl発注先名.Width = 2.440945!
        '
        'txt発注先名
        '
        Me.txt発注先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注先名.Height = 0.2165354!
        Me.txt発注先名.Left = 0.0!
        Me.txt発注先名.Name = "txt発注先名"
        Me.txt発注先名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt発注先名.Text = "あああああいいいいいううううう"
        Me.txt発注先名.Top = 0.8330709!
        Me.txt発注先名.Width = 2.440945!
        '
        'txtHdr商品名
        '
        Me.txtHdr商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr商品名.Height = 0.2165354!
        Me.txtHdr商品名.Left = 0.0!
        Me.txtHdr商品名.Name = "txtHdr商品名"
        Me.txtHdr商品名.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtHdr商品名.Text = "あああああいいいいいううううう"
        Me.txtHdr商品名.Top = 1.329528!
        Me.txtHdr商品名.Width = 2.24252!
        '
        'lblHdr商品名
        '
        Me.lblHdr商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr商品名.Height = 0.2165354!
        Me.lblHdr商品名.HyperLink = Nothing
        Me.lblHdr商品名.Left = 0.0!
        Me.lblHdr商品名.Name = "lblHdr商品名"
        Me.lblHdr商品名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lblHdr商品名.Text = "商　　品　　名"
        Me.lblHdr商品名.Top = 1.112992!
        Me.lblHdr商品名.Width = 2.24252!
        '
        'lbl発注日
        '
        Me.lbl発注日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発注日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発注日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発注日.Height = 0.2165354!
        Me.lbl発注日.HyperLink = Nothing
        Me.lbl発注日.Left = 2.440945!
        Me.lbl発注日.Name = "lbl発注日"
        Me.lbl発注日.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lbl発注日.Text = "発 注 日"
        Me.lbl発注日.Top = 0.6165355!
        Me.lbl発注日.Width = 0.8267716!
        '
        'txt発注日
        '
        Me.txt発注日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注日.Height = 0.2165354!
        Me.txt発注日.Left = 2.440945!
        Me.txt発注日.Name = "txt発注日"
        Me.txt発注日.Style = "font-family: ＭＳ 明朝; font-size: 7pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt発注日.Text = "YYYY/MM/DD"
        Me.txt発注日.Top = 0.8330709!
        Me.txt発注日.Width = 0.8267716!
        '
        'lbl納期
        '
        Me.lbl納期.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl納期.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl納期.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl納期.Height = 0.2165354!
        Me.lbl納期.HyperLink = Nothing
        Me.lbl納期.Left = 3.267716!
        Me.lbl納期.Name = "lbl納期"
        Me.lbl納期.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lbl納期.Text = "納　　期"
        Me.lbl納期.Top = 0.6165356!
        Me.lbl納期.Width = 1.220472!
        '
        'txt納期
        '
        Me.txt納期.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt納期.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt納期.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt納期.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt納期.Height = 0.2165354!
        Me.txt納期.Left = 3.267716!
        Me.txt納期.Name = "txt納期"
        Me.txt納期.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt納期.Text = "YYYY/MM/DD"
        Me.txt納期.Top = 0.8330709!
        Me.txt納期.Width = 1.220472!
        '
        'lbl顧客商品No
        '
        Me.lbl顧客商品No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl顧客商品No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl顧客商品No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl顧客商品No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl顧客商品No.Height = 0.2165354!
        Me.lbl顧客商品No.HyperLink = Nothing
        Me.lbl顧客商品No.Left = 4.488189!
        Me.lbl顧客商品No.Name = "lbl顧客商品No"
        Me.lbl顧客商品No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lbl顧客商品No.Text = "顧客商品No"
        Me.lbl顧客商品No.Top = 0.6165355!
        Me.lbl顧客商品No.Width = 1.417323!
        '
        'txt顧客商品No
        '
        Me.txt顧客商品No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt顧客商品No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt顧客商品No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt顧客商品No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt顧客商品No.Height = 0.2165354!
        Me.txt顧客商品No.Left = 4.488189!
        Me.txt顧客商品No.Name = "txt顧客商品No"
        Me.txt顧客商品No.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt顧客商品No.Text = "12345678"
        Me.txt顧客商品No.Top = 0.8330709!
        Me.txt顧客商品No.Width = 1.417323!
        '
        'lblHdr発注数
        '
        Me.lblHdr発注数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr発注数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr発注数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr発注数.Height = 0.2165354!
        Me.lblHdr発注数.HyperLink = Nothing
        Me.lblHdr発注数.Left = 2.24252!
        Me.lblHdr発注数.Name = "lblHdr発注数"
        Me.lblHdr発注数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lblHdr発注数.Text = "発　注　数"
        Me.lblHdr発注数.Top = 1.112992!
        Me.lblHdr発注数.Width = 1.241339!
        '
        'txtHdr発注数
        '
        Me.txtHdr発注数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr発注数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr発注数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr発注数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr発注数.Height = 0.2165354!
        Me.txtHdr発注数.Left = 2.24252!
        Me.txtHdr発注数.Name = "txtHdr発注数"
        Me.txtHdr発注数.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtHdr発注数.Text = "99,999"
        Me.txtHdr発注数.Top = 1.329527!
        Me.txtHdr発注数.Width = 1.241339!
        '
        'lblHdr通数
        '
        Me.lblHdr通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr通数.Height = 0.2165354!
        Me.lblHdr通数.HyperLink = Nothing
        Me.lblHdr通数.Left = 3.483859!
        Me.lblHdr通数.Name = "lblHdr通数"
        Me.lblHdr通数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lblHdr通数.Text = "通　　数"
        Me.lblHdr通数.Top = 1.112993!
        Me.lblHdr通数.Width = 1.55!
        '
        'txtHdr通数
        '
        Me.txtHdr通数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr通数.Height = 0.2165354!
        Me.txtHdr通数.Left = 3.483859!
        Me.txtHdr通数.Name = "txtHdr通数"
        Me.txtHdr通数.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtHdr通数.Text = "9,999"
        Me.txtHdr通数.Top = 1.329528!
        Me.txtHdr通数.Width = 1.55!
        '
        'lblHdr発注単価
        '
        Me.lblHdr発注単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr発注単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr発注単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr発注単価.Height = 0.2165354!
        Me.lblHdr発注単価.HyperLink = Nothing
        Me.lblHdr発注単価.Left = 5.033859!
        Me.lblHdr発注単価.Name = "lblHdr発注単価"
        Me.lblHdr発注単価.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lblHdr発注単価.Text = "発 注 単 価"
        Me.lblHdr発注単価.Top = 1.112993!
        Me.lblHdr発注単価.Width = 1.005512!
        '
        'txtHdr発注単価
        '
        Me.txtHdr発注単価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr発注単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr発注単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr発注単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr発注単価.Height = 0.2165354!
        Me.txtHdr発注単価.Left = 5.033859!
        Me.txtHdr発注単価.Name = "txtHdr発注単価"
        Me.txtHdr発注単価.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtHdr発注単価.Text = "99,9999"
        Me.txtHdr発注単価.Top = 1.329528!
        Me.txtHdr発注単価.Width = 1.005512!
        '
        'txtHdr発注金額
        '
        Me.txtHdr発注金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr発注金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr発注金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr発注金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr発注金額.Height = 0.2165354!
        Me.txtHdr発注金額.Left = 6.039371!
        Me.txtHdr発注金額.Name = "txtHdr発注金額"
        Me.txtHdr発注金額.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtHdr発注金額.Text = "999,999,999"
        Me.txtHdr発注金額.Top = 1.329527!
        Me.txtHdr発注金額.Width = 1.18504!
        '
        'lblHdr発注金額
        '
        Me.lblHdr発注金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr発注金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr発注金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr発注金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr発注金額.Height = 0.2165354!
        Me.lblHdr発注金額.HyperLink = Nothing
        Me.lblHdr発注金額.Left = 6.039371!
        Me.lblHdr発注金額.Name = "lblHdr発注金額"
        Me.lblHdr発注金額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lblHdr発注金額.Text = "発 注 金 額"
        Me.lblHdr発注金額.Top = 1.112991!
        Me.lblHdr発注金額.Width = 1.18504!
        '
        'Label5
        '
        Me.Label5.Height = 0.1968504!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 0.0!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; font-weight: bold; text-align:" & _
    " center; vertical-align: middle; ddo-char-set: 1"
        Me.Label5.Text = "【商品内訳】"
        Me.Label5.Top = 1.624016!
        Me.Label5.Width = 0.9204725!
        '
        'lbl発注単価
        '
        Me.lbl発注単価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発注単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発注単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発注単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発注単価.Height = 0.1968504!
        Me.lbl発注単価.HyperLink = Nothing
        Me.lbl発注単価.Left = 4.035433!
        Me.lbl発注単価.Name = "lbl発注単価"
        Me.lbl発注単価.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 7pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lbl発注単価.Text = "発注単価"
        Me.lbl発注単価.Top = 1.844488!
        Me.lbl発注単価.Width = 0.8661417!
        '
        'lbl顧客発注No
        '
        Me.lbl顧客発注No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl顧客発注No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl顧客発注No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl顧客発注No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl顧客発注No.Height = 0.1968504!
        Me.lbl顧客発注No.HyperLink = Nothing
        Me.lbl顧客発注No.Left = 4.901575!
        Me.lbl顧客発注No.Name = "lbl顧客発注No"
        Me.lbl顧客発注No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 7pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lbl顧客発注No.Text = "顧客発注No"
        Me.lbl顧客発注No.Top = 1.844095!
        Me.lbl顧客発注No.Width = 0.8464568!
        '
        'grpFtr得意先CD
        '
        Me.grpFtr得意先CD.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox6, Me.OrderSlipSubPaper, Me.Label2, Me.Label14, Me.txt巻取, Me.lbl巻取, Me.lbl出し方向, Me.txt出し方向, Me.lbl紙管, Me.txt紙管, Me.lbl枚数, Me.txt枚数, Me.txtスリッター, Me.lblｽﾘｯﾀｰ, Me.lblｽﾘｯﾀｰ巾, Me.txtスリッター巾, Me.lblカット, Me.txtｶｯﾄ, Me.txt1ｼｰﾄ枚数, Me.lbl1シート枚数, Me.txt包装枚数, Me.lbl包装枚数, Me.txt送りピッチ, Me.lbl送りピッチ, Me.Label3, Me.Label4, Me.lbl刃型No, Me.txt刃型No, Me.txt版Np, Me.lbl版Np, Me.TextBox18, Me.Label15, Me.Label16, Me.TextBox19, Me.Label17, Me.TextBox21, Me.Label21, Me.Label22, Me.OrderSlipSubNote, Me.OrderSlipSubDelivery, Me.TextBox71, Me.TextBox91, Me.TextBox92, Me.TextBox94, Me.TextBox95, Me.TextBox96, Me.TextBox93, Me.TextBox97, Me.TextBox98})
        Me.grpFtr得意先CD.Height = 5.253839!
        Me.grpFtr得意先CD.Name = "grpFtr得意先CD"
        '
        'TextBox6
        '
        Me.TextBox6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Height = 0.9251968!
        Me.TextBox6.Left = 0.9236221!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.TextBox6.Text = Nothing
        Me.TextBox6.Top = 3.106693!
        Me.TextBox6.Width = 3.077953!
        '
        'OrderSlipSubPaper
        '
        Me.OrderSlipSubPaper.CloseBorder = False
        Me.OrderSlipSubPaper.Height = 1.181102!
        Me.OrderSlipSubPaper.Left = 0.0!
        Me.OrderSlipSubPaper.Name = "OrderSlipSubPaper"
        Me.OrderSlipSubPaper.Report = Nothing
        Me.OrderSlipSubPaper.Top = 0.3539371!
        Me.OrderSlipSubPaper.Width = 7.283465!
        '
        'Label2
        '
        Me.Label2.Height = 0.1968504!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.0!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; font-weight: bold; text-align:" & _
    " center; vertical-align: middle; ddo-char-set: 1"
        Me.Label2.Text = "【印　刷】"
        Me.Label2.Top = 0.07283465!
        Me.Label2.Width = 0.9204725!
        '
        'Label14
        '
        Me.Label14.Height = 0.1968504!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 0.0!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; font-weight: bold; text-align:" & _
    " center; vertical-align: middle; ddo-char-set: 1"
        Me.Label14.Text = "【仕上指示】"
        Me.Label14.Top = 1.651969!
        Me.Label14.Width = 0.9204725!
        '
        'txt巻取
        '
        Me.txt巻取.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt巻取.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt巻取.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt巻取.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt巻取.Height = 0.2362205!
        Me.txt巻取.Left = 0.9244101!
        Me.txt巻取.Name = "txt巻取"
        Me.txt巻取.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt巻取.Text = "999"
        Me.txt巻取.Top = 1.82126!
        Me.txt巻取.Width = 0.472441!
        '
        'lbl巻取
        '
        Me.lbl巻取.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl巻取.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl巻取.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl巻取.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl巻取.Height = 0.1968504!
        Me.lbl巻取.HyperLink = Nothing
        Me.lbl巻取.Left = 0.9244101!
        Me.lbl巻取.Name = "lbl巻取"
        Me.lbl巻取.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lbl巻取.Text = "巻取"
        Me.lbl巻取.Top = 1.62441!
        Me.lbl巻取.Width = 0.472441!
        '
        'lbl出し方向
        '
        Me.lbl出し方向.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl出し方向.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl出し方向.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl出し方向.Height = 0.1968504!
        Me.lbl出し方向.HyperLink = Nothing
        Me.lbl出し方向.Left = 1.396851!
        Me.lbl出し方向.Name = "lbl出し方向"
        Me.lbl出し方向.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lbl出し方向.Text = "出し方向"
        Me.lbl出し方向.Top = 1.624409!
        Me.lbl出し方向.Width = 0.6299213!
        '
        'txt出し方向
        '
        Me.txt出し方向.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出し方向.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出し方向.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出し方向.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出し方向.Height = 0.2362205!
        Me.txt出し方向.Left = 1.396851!
        Me.txt出し方向.Name = "txt出し方向"
        Me.txt出し方向.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt出し方向.Text = "99,999"
        Me.txt出し方向.Top = 1.82126!
        Me.txt出し方向.Width = 0.6299213!
        '
        'lbl紙管
        '
        Me.lbl紙管.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙管.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙管.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙管.Height = 0.1968504!
        Me.lbl紙管.HyperLink = Nothing
        Me.lbl紙管.Left = 2.026772!
        Me.lbl紙管.Name = "lbl紙管"
        Me.lbl紙管.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lbl紙管.Text = "紙管"
        Me.lbl紙管.Top = 1.624409!
        Me.lbl紙管.Width = 0.492126!
        '
        'txt紙管
        '
        Me.txt紙管.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙管.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙管.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙管.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙管.Height = 0.2362205!
        Me.txt紙管.Left = 2.026772!
        Me.txt紙管.Name = "txt紙管"
        Me.txt紙管.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt紙管.Text = "9,999"
        Me.txt紙管.Top = 1.82126!
        Me.txt紙管.Width = 0.492126!
        '
        'lbl枚数
        '
        Me.lbl枚数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl枚数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl枚数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl枚数.Height = 0.1968504!
        Me.lbl枚数.HyperLink = Nothing
        Me.lbl枚数.Left = 2.518898!
        Me.lbl枚数.Name = "lbl枚数"
        Me.lbl枚数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lbl枚数.Text = "枚数"
        Me.lbl枚数.Top = 1.624409!
        Me.lbl枚数.Width = 0.5511811!
        '
        'txt枚数
        '
        Me.txt枚数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt枚数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt枚数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt枚数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt枚数.Height = 0.2362205!
        Me.txt枚数.Left = 2.518898!
        Me.txt枚数.Name = "txt枚数"
        Me.txt枚数.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt枚数.Text = "99,9999"
        Me.txt枚数.Top = 1.82126!
        Me.txt枚数.Width = 0.5511811!
        '
        'txtスリッター
        '
        Me.txtスリッター.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtスリッター.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtスリッター.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtスリッター.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtスリッター.Height = 0.2362205!
        Me.txtスリッター.Left = 3.070079!
        Me.txtスリッター.Name = "txtスリッター"
        Me.txtスリッター.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txtスリッター.Text = "999"
        Me.txtスリッター.Top = 1.82126!
        Me.txtスリッター.Width = 0.472441!
        '
        'lblｽﾘｯﾀｰ
        '
        Me.lblｽﾘｯﾀｰ.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblｽﾘｯﾀｰ.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblｽﾘｯﾀｰ.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblｽﾘｯﾀｰ.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblｽﾘｯﾀｰ.Height = 0.1968504!
        Me.lblｽﾘｯﾀｰ.HyperLink = Nothing
        Me.lblｽﾘｯﾀｰ.Left = 3.070079!
        Me.lblｽﾘｯﾀｰ.Name = "lblｽﾘｯﾀｰ"
        Me.lblｽﾘｯﾀｰ.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; text-justif" & _
    "y: distribute; vertical-align: bottom; ddo-char-set: 1"
        Me.lblｽﾘｯﾀｰ.Text = "ｽﾘｯﾀｰ"
        Me.lblｽﾘｯﾀｰ.Top = 1.62441!
        Me.lblｽﾘｯﾀｰ.Width = 0.472441!
        '
        'lblｽﾘｯﾀｰ巾
        '
        Me.lblｽﾘｯﾀｰ巾.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblｽﾘｯﾀｰ巾.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblｽﾘｯﾀｰ巾.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblｽﾘｯﾀｰ巾.Height = 0.1968504!
        Me.lblｽﾘｯﾀｰ巾.HyperLink = Nothing
        Me.lblｽﾘｯﾀｰ巾.Left = 3.54252!
        Me.lblｽﾘｯﾀｰ巾.Name = "lblｽﾘｯﾀｰ巾"
        Me.lblｽﾘｯﾀｰ巾.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lblｽﾘｯﾀｰ巾.Text = "ｽﾘｯﾀｰ巾"
        Me.lblｽﾘｯﾀｰ巾.Top = 1.62441!
        Me.lblｽﾘｯﾀｰ巾.Width = 0.6299213!
        '
        'txtスリッター巾
        '
        Me.txtスリッター巾.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtスリッター巾.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtスリッター巾.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtスリッター巾.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtスリッター巾.Height = 0.2362205!
        Me.txtスリッター巾.Left = 3.54252!
        Me.txtスリッター巾.Name = "txtスリッター巾"
        Me.txtスリッター巾.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txtスリッター巾.Text = "9,999"
        Me.txtスリッター巾.Top = 1.82126!
        Me.txtスリッター巾.Width = 0.6299213!
        '
        'lblカット
        '
        Me.lblカット.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblカット.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblカット.Height = 0.1968504!
        Me.lblカット.HyperLink = Nothing
        Me.lblカット.Left = 4.172441!
        Me.lblカット.Name = "lblカット"
        Me.lblカット.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-ali" & _
    "gn: bottom; ddo-char-set: 1"
        Me.lblカット.Text = "ｶｯﾄ"
        Me.lblカット.Top = 1.62441!
        Me.lblカット.Width = 0.7874016!
        '
        'txtｶｯﾄ
        '
        Me.txtｶｯﾄ.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtｶｯﾄ.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtｶｯﾄ.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtｶｯﾄ.Height = 0.2362205!
        Me.txtｶｯﾄ.Left = 4.172441!
        Me.txtｶｯﾄ.Name = "txtｶｯﾄ"
        Me.txtｶｯﾄ.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txtｶｯﾄ.Text = "9999"
        Me.txtｶｯﾄ.Top = 1.82126!
        Me.txtｶｯﾄ.Width = 0.7874016!
        '
        'txt1ｼｰﾄ枚数
        '
        Me.txt1ｼｰﾄ枚数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt1ｼｰﾄ枚数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt1ｼｰﾄ枚数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt1ｼｰﾄ枚数.Height = 0.2362205!
        Me.txt1ｼｰﾄ枚数.Left = 4.959843!
        Me.txt1ｼｰﾄ枚数.Name = "txt1ｼｰﾄ枚数"
        Me.txt1ｼｰﾄ枚数.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt1ｼｰﾄ枚数.Text = "999,999"
        Me.txt1ｼｰﾄ枚数.Top = 1.82126!
        Me.txt1ｼｰﾄ枚数.Width = 0.7874017!
        '
        'lbl1シート枚数
        '
        Me.lbl1シート枚数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl1シート枚数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl1シート枚数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl1シート枚数.Height = 0.1968504!
        Me.lbl1シート枚数.HyperLink = Nothing
        Me.lbl1シート枚数.Left = 4.959843!
        Me.lbl1シート枚数.Name = "lbl1シート枚数"
        Me.lbl1シート枚数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; text-justify" & _
    ": distribute; vertical-align: bottom; ddo-char-set: 1"
        Me.lbl1シート枚数.Text = "1ｼｰﾄ枚数"
        Me.lbl1シート枚数.Top = 1.62441!
        Me.lbl1シート枚数.Width = 0.7874016!
        '
        'txt包装枚数
        '
        Me.txt包装枚数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt包装枚数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt包装枚数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt包装枚数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt包装枚数.Height = 0.2362205!
        Me.txt包装枚数.Left = 5.747245!
        Me.txt包装枚数.Name = "txt包装枚数"
        Me.txt包装枚数.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt包装枚数.Text = "999,999"
        Me.txt包装枚数.Top = 1.82126!
        Me.txt包装枚数.Width = 0.6496063!
        '
        'lbl包装枚数
        '
        Me.lbl包装枚数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl包装枚数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl包装枚数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl包装枚数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl包装枚数.Height = 0.1968504!
        Me.lbl包装枚数.HyperLink = Nothing
        Me.lbl包装枚数.Left = 5.747245!
        Me.lbl包装枚数.Name = "lbl包装枚数"
        Me.lbl包装枚数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; text-justif" & _
    "y: distribute; vertical-align: bottom; ddo-char-set: 1"
        Me.lbl包装枚数.Text = "包装枚数"
        Me.lbl包装枚数.Top = 1.62441!
        Me.lbl包装枚数.Width = 0.6496063!
        '
        'txt送りピッチ
        '
        Me.txt送りピッチ.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt送りピッチ.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt送りピッチ.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt送りピッチ.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt送りピッチ.Height = 0.2362205!
        Me.txt送りピッチ.Left = 6.396851!
        Me.txt送りピッチ.Name = "txt送りピッチ"
        Me.txt送りピッチ.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt送りピッチ.Text = "999,999"
        Me.txt送りピッチ.Top = 1.82126!
        Me.txt送りピッチ.Width = 0.8267716!
        '
        'lbl送りピッチ
        '
        Me.lbl送りピッチ.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl送りピッチ.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl送りピッチ.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl送りピッチ.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl送りピッチ.Height = 0.1968504!
        Me.lbl送りピッチ.HyperLink = Nothing
        Me.lbl送りピッチ.Left = 6.396851!
        Me.lbl送りピッチ.Name = "lbl送りピッチ"
        Me.lbl送りピッチ.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; text-justif" & _
    "y: distribute; vertical-align: bottom; ddo-char-set: 1"
        Me.lbl送りピッチ.Text = "送りピッチ"
        Me.lbl送りピッチ.Top = 1.624409!
        Me.lbl送りピッチ.Width = 0.8267716!
        '
        'Label3
        '
        Me.Label3.Height = 0.1968504!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 0.0!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; font-weight: bold; text-align:" & _
    " center; vertical-align: middle; ddo-char-set: 1"
        Me.Label3.Text = "【発送先】"
        Me.Label3.Top = 2.290945!
        Me.Label3.Width = 0.9204725!
        '
        'Label4
        '
        Me.Label4.Height = 0.1968504!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 0.0!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; font-weight: bold; text-align:" & _
    " center; vertical-align: middle; ddo-char-set: 1"
        Me.Label4.Text = "【発送元】"
        Me.Label4.Top = 3.161417!
        Me.Label4.Width = 0.9204725!
        '
        'lbl刃型No
        '
        Me.lbl刃型No.Height = 0.2362205!
        Me.lbl刃型No.HyperLink = Nothing
        Me.lbl刃型No.Left = 0.0!
        Me.lbl刃型No.Name = "lbl刃型No"
        Me.lbl刃型No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; font-weight: bold; text-align:" & _
    " center; vertical-align: middle; ddo-char-set: 1"
        Me.lbl刃型No.Text = "【刃型No】"
        Me.lbl刃型No.Top = 4.217323!
        Me.lbl刃型No.Width = 0.8661418!
        '
        'txt刃型No
        '
        Me.txt刃型No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型No.Height = 0.2362205!
        Me.txt刃型No.Left = 0.9204725!
        Me.txt刃型No.Name = "txt刃型No"
        Me.txt刃型No.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt刃型No.Text = "123"
        Me.txt刃型No.Top = 4.212599!
        Me.txt刃型No.Width = 0.8661417!
        '
        'txt版Np
        '
        Me.txt版Np.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt版Np.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt版Np.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt版Np.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt版Np.Height = 0.2362205!
        Me.txt版Np.Left = 2.967717!
        Me.txt版Np.Name = "txt版Np"
        Me.txt版Np.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt版Np.Text = "123"
        Me.txt版Np.Top = 4.212599!
        Me.txt版Np.Width = 1.023622!
        '
        'lbl版Np
        '
        Me.lbl版Np.Height = 0.1968504!
        Me.lbl版Np.HyperLink = Nothing
        Me.lbl版Np.Left = 2.088977!
        Me.lbl版Np.Name = "lbl版Np"
        Me.lbl版Np.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; font-weight: bold; text-align:" & _
    " right; vertical-align: middle; ddo-char-set: 1"
        Me.lbl版Np.Text = "【版No】"
        Me.lbl版Np.Top = 4.222835!
        Me.lbl版Np.Width = 0.7874016!
        '
        'TextBox18
        '
        Me.TextBox18.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox18.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox18.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox18.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox18.Height = 0.3937008!
        Me.TextBox18.Left = 0.9212599!
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox18.Text = Nothing
        Me.TextBox18.Top = 4.735039!
        Me.TextBox18.Width = 1.023622!
        '
        'Label15
        '
        Me.Label15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label15.Height = 0.1968504!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 0.9212599!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.Label15.Text = "月　　日"
        Me.Label15.Top = 4.538188!
        Me.Label15.Width = 1.023622!
        '
        'Label16
        '
        Me.Label16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label16.Height = 0.1968504!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 1.944882!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.Label16.Text = "月　　日"
        Me.Label16.Top = 4.538188!
        Me.Label16.Width = 1.023622!
        '
        'TextBox19
        '
        Me.TextBox19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Height = 0.3937008!
        Me.TextBox19.Left = 1.944882!
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox19.Text = Nothing
        Me.TextBox19.Top = 4.735039!
        Me.TextBox19.Width = 1.023622!
        '
        'Label17
        '
        Me.Label17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label17.Height = 0.1968504!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 2.968504!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.Label17.Text = "月　　日"
        Me.Label17.Top = 4.538188!
        Me.Label17.Width = 1.023622!
        '
        'TextBox21
        '
        Me.TextBox21.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox21.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox21.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox21.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox21.Height = 0.3937008!
        Me.TextBox21.Left = 2.968504!
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox21.Text = Nothing
        Me.TextBox21.Top = 4.735039!
        Me.TextBox21.Width = 1.023622!
        '
        'Label21
        '
        Me.Label21.Height = 0.1574803!
        Me.Label21.HyperLink = Nothing
        Me.Label21.Left = 2.987008!
        Me.Label21.Name = "Label21"
        Me.Label21.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 7pt; font-weight: normal; text-align" & _
    ": left; vertical-align: middle; ddo-char-set: 1"
        Me.Label21.Text = "担 当 者"
        Me.Label21.Top = 4.745275!
        Me.Label21.Width = 0.6216536!
        '
        'Label22
        '
        Me.Label22.Height = 0.1574803!
        Me.Label22.HyperLink = Nothing
        Me.Label22.Left = 1.988189!
        Me.Label22.Name = "Label22"
        Me.Label22.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 7pt; font-weight: normal; text-align" & _
    ": left; vertical-align: middle; ddo-char-set: 1"
        Me.Label22.Text = "責 任 者"
        Me.Label22.Top = 4.755512!
        Me.Label22.Width = 0.6216536!
        '
        'OrderSlipSubNote
        '
        Me.OrderSlipSubNote.CloseBorder = False
        Me.OrderSlipSubNote.Height = 2.972441!
        Me.OrderSlipSubNote.Left = 4.152756!
        Me.OrderSlipSubNote.Name = "OrderSlipSubNote"
        Me.OrderSlipSubNote.Report = Nothing
        Me.OrderSlipSubNote.Top = 2.175984!
        Me.OrderSlipSubNote.Width = 3.070866!
        '
        'OrderSlipSubDelivery
        '
        Me.OrderSlipSubDelivery.CloseBorder = False
        Me.OrderSlipSubDelivery.Height = 0.7874016!
        Me.OrderSlipSubDelivery.Left = 0.9204725!
        Me.OrderSlipSubDelivery.Name = "OrderSlipSubDelivery"
        Me.OrderSlipSubDelivery.Report = Nothing
        Me.OrderSlipSubDelivery.Top = 2.247638!
        Me.OrderSlipSubDelivery.Width = 3.070866!
        '
        'TextBox71
        '
        Me.TextBox71.Height = 0.1968504!
        Me.TextBox71.Left = 1.127559!
        Me.TextBox71.Name = "TextBox71"
        Me.TextBox71.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.TextBox71.Text = "　ラベル・シール・ステッカー特殊印刷"
        Me.TextBox71.Top = 3.13504!
        Me.TextBox71.Width = 2.864568!
        '
        'TextBox91
        '
        Me.TextBox91.Height = 0.2755905!
        Me.TextBox91.Left = 1.127559!
        Me.TextBox91.Name = "TextBox91"
        Me.TextBox91.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox91.Text = "株　式　会　社"
        Me.TextBox91.Top = 3.331891!
        Me.TextBox91.Width = 1.417323!
        '
        'TextBox92
        '
        Me.TextBox92.Height = 0.1968504!
        Me.TextBox92.Left = 1.127559!
        Me.TextBox92.Name = "TextBox92"
        Me.TextBox92.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.TextBox92.Text = "本社"
        Me.TextBox92.Top = 3.607481!
        Me.TextBox92.Width = 0.6299213!
        '
        'TextBox94
        '
        Me.TextBox94.Height = 0.2755905!
        Me.TextBox94.Left = 2.544882!
        Me.TextBox94.Name = "TextBox94"
        Me.TextBox94.Style = "font-family: ＭＳ 明朝; font-size: 14pt; text-align: left; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.TextBox94.Text = "友　功　社"
        Me.TextBox94.Top = 3.331891!
        Me.TextBox94.Width = 1.447245!
        '
        'TextBox95
        '
        Me.TextBox95.Height = 0.1968504!
        Me.TextBox95.Left = 1.757481!
        Me.TextBox95.Name = "TextBox95"
        Me.TextBox95.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: left; vertical-align: middle; ddo" & _
    "-char-set: 1"
        Me.TextBox95.Text = "〒177-0032"
        Me.TextBox95.Top = 3.607481!
        Me.TextBox95.Width = 0.7086611!
        '
        'TextBox96
        '
        Me.TextBox96.Height = 0.1968504!
        Me.TextBox96.Left = 2.466142!
        Me.TextBox96.Name = "TextBox96"
        Me.TextBox96.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: left; vertical-align: middle; ddo" & _
    "-char-set: 1"
        Me.TextBox96.Text = "東京都練馬区谷原 3-24-1"
        Me.TextBox96.Top = 3.607481!
        Me.TextBox96.Width = 1.525984!
        '
        'TextBox93
        '
        Me.TextBox93.Height = 0.1968504!
        Me.TextBox93.Left = 1.127559!
        Me.TextBox93.Name = "TextBox93"
        Me.TextBox93.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.TextBox93.Text = Nothing
        Me.TextBox93.Top = 3.804331!
        Me.TextBox93.Width = 0.6299213!
        '
        'TextBox97
        '
        Me.TextBox97.Height = 0.1968504!
        Me.TextBox97.Left = 1.75748!
        Me.TextBox97.Name = "TextBox97"
        Me.TextBox97.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: left; vertical-align: middle; ddo" & _
    "-char-set: 1"
        Me.TextBox97.Text = "TEL 03-3996-5333(代)"
        Me.TextBox97.Top = 3.804331!
        Me.TextBox97.Width = 1.181102!
        '
        'TextBox98
        '
        Me.TextBox98.Height = 0.1968504!
        Me.TextBox98.Left = 2.938583!
        Me.TextBox98.Name = "TextBox98"
        Me.TextBox98.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: left; vertical-align: middle; ddo" & _
    "-char-set: 1"
        Me.TextBox98.Text = "FAX 03-3996-4333"
        Me.TextBox98.Top = 3.804331!
        Me.TextBox98.Width = 1.053543!
        '
        'OrderSlipSub
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.446949!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.grpHdr得意先CD)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.grpFtr得意先CD)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.txt枝番, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt定番, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt発注数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt発注単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt顧客発注No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt備考, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl発注伝票, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl枝番, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl定番, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl発注数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl備考, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ｌｂｌ作業No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt作業No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr顧客様No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdrユーザーNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr本台帳番号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr枝番, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr顧客様No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdrユーザーNp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr本台帳番号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr枝番, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl発注先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt発注先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl発注日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt発注日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl納期, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt納期, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl顧客商品No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt顧客商品No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr発注数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr発注数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr発注単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr発注単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr発注金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr発注金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl発注単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl顧客発注No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt巻取, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl巻取, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl出し方向, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt出し方向, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl紙管, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt紙管, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl枚数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt枚数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtスリッター, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblｽﾘｯﾀｰ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblｽﾘｯﾀｰ巾, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtスリッター巾, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblカット, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtｶｯﾄ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt1ｼｰﾄ枚数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl1シート枚数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt包装枚数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl包装枚数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt送りピッチ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl送りピッチ, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl刃型No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt刃型No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt版Np, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl版Np, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox71, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox91, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox92, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox94, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox95, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox96, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox93, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox97, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox98, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter
    Private WithEvents grpHdr得意先CD As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents lbl発注伝票 As DataDynamics.ActiveReports.Label
    Friend WithEvents lbl枝番 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl定番 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl発注数 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl備考 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl商品名 As DataDynamics.ActiveReports.Label
    Private WithEvents ｌｂｌ作業No As DataDynamics.ActiveReports.Label
    Private WithEvents txt作業No As DataDynamics.ActiveReports.TextBox
    Private WithEvents Barcode As DataDynamics.ActiveReports.Barcode
    Private WithEvents grpFtr得意先CD As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents OrderSlipSubPaper As DataDynamics.ActiveReports.SubReport
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents lblHdr顧客様No As DataDynamics.ActiveReports.Label
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents lblHdrユーザーNo As DataDynamics.ActiveReports.Label
    Private WithEvents Label7 As DataDynamics.ActiveReports.Label
    Private WithEvents lblHdr本台帳番号 As DataDynamics.ActiveReports.Label
    Private WithEvents Label10 As DataDynamics.ActiveReports.Label
    Private WithEvents lblHdr枝番 As DataDynamics.ActiveReports.Label
    Private WithEvents Label6 As DataDynamics.ActiveReports.Label
    Private WithEvents Label9 As DataDynamics.ActiveReports.Label
    Private WithEvents txtHdr顧客様No As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtHdrユーザーNp As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtHdr本台帳番号 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtHdr枝番 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label12 As DataDynamics.ActiveReports.Label
    Private WithEvents txt自社担当者名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl発注先名 As DataDynamics.ActiveReports.Label
    Private WithEvents txt発注先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtHdr商品名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblHdr商品名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl発注日 As DataDynamics.ActiveReports.Label
    Private WithEvents txt発注日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl納期 As DataDynamics.ActiveReports.Label
    Private WithEvents txt納期 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl顧客商品No As DataDynamics.ActiveReports.Label
    Private WithEvents txt顧客商品No As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblHdr発注数 As DataDynamics.ActiveReports.Label
    Private WithEvents txtHdr発注数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblHdr通数 As DataDynamics.ActiveReports.Label
    Private WithEvents txtHdr通数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblHdr発注単価 As DataDynamics.ActiveReports.Label
    Private WithEvents txtHdr発注単価 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtHdr発注金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblHdr発注金額 As DataDynamics.ActiveReports.Label
    Private WithEvents Label5 As DataDynamics.ActiveReports.Label
    Friend WithEvents lbl本支店名 As DataDynamics.ActiveReports.Label
    Private WithEvents txt枝版 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl部署名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl発注単価 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl顧客発注No As DataDynamics.ActiveReports.Label
    Private WithEvents Label14 As DataDynamics.ActiveReports.Label
    Private WithEvents txt枝番 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt定番 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt商品名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt発注数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt発注単価 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt顧客発注No As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt備考 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt巻取 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl巻取 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl出し方向 As DataDynamics.ActiveReports.Label
    Private WithEvents txt出し方向 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl紙管 As DataDynamics.ActiveReports.Label
    Private WithEvents txt紙管 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl枚数 As DataDynamics.ActiveReports.Label
    Private WithEvents txt枚数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtスリッター As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblｽﾘｯﾀｰ As DataDynamics.ActiveReports.Label
    Private WithEvents lblｽﾘｯﾀｰ巾 As DataDynamics.ActiveReports.Label
    Private WithEvents txtスリッター巾 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblカット As DataDynamics.ActiveReports.Label
    Private WithEvents txtｶｯﾄ As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt1ｼｰﾄ枚数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl1シート枚数 As DataDynamics.ActiveReports.Label
    Private WithEvents txt包装枚数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl包装枚数 As DataDynamics.ActiveReports.Label
    Private WithEvents txt送りピッチ As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl送りピッチ As DataDynamics.ActiveReports.Label
    Private WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents Label4 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl刃型No As DataDynamics.ActiveReports.Label
    Private WithEvents txt刃型No As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt版Np As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl版Np As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox18 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label15 As DataDynamics.ActiveReports.Label
    Private WithEvents Label16 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox19 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label17 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox21 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label21 As DataDynamics.ActiveReports.Label
    Private WithEvents Label22 As DataDynamics.ActiveReports.Label
    Private WithEvents OrderSlipSubNote As DataDynamics.ActiveReports.SubReport
    Private WithEvents OrderSlipSubDelivery As DataDynamics.ActiveReports.SubReport
    Private WithEvents TextBox71 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox91 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox92 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox94 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox95 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox96 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox93 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox97 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox98 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
End Class
