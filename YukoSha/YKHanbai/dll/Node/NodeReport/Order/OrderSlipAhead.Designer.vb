<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class OrderSlipSubAhead
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(OrderSlipSubAhead))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt枝番 = New DataDynamics.ActiveReports.TextBox()
        Me.txt定番 = New DataDynamics.ActiveReports.TextBox()
        Me.txt商品名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt受注数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt発注単価 = New DataDynamics.ActiveReports.TextBox()
        Me.txt受注単価 = New DataDynamics.ActiveReports.TextBox()
        Me.txt先客納期 = New DataDynamics.ActiveReports.TextBox()
        Me.txt顧客発注No = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr得意先CD = New DataDynamics.ActiveReports.GroupHeader()
        Me.lblTitle = New DataDynamics.ActiveReports.Label()
        Me.lbl枝番 = New DataDynamics.ActiveReports.Label()
        Me.lbl定番 = New DataDynamics.ActiveReports.Label()
        Me.lbl受注数 = New DataDynamics.ActiveReports.Label()
        Me.lbl客先納期 = New DataDynamics.ActiveReports.Label()
        Me.lbl商品名 = New DataDynamics.ActiveReports.Label()
        Me.ｌｂｌHrd作業No = New DataDynamics.ActiveReports.Label()
        Me.txtHrd作業No = New DataDynamics.ActiveReports.TextBox()
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
        Me.lblHrd発注先名 = New DataDynamics.ActiveReports.Label()
        Me.txt発注先名 = New DataDynamics.ActiveReports.TextBox()
        Me.txtHdr商品名 = New DataDynamics.ActiveReports.TextBox()
        Me.lblHdr商品名 = New DataDynamics.ActiveReports.Label()
        Me.lblHrd発注日 = New DataDynamics.ActiveReports.Label()
        Me.txt発注日 = New DataDynamics.ActiveReports.TextBox()
        Me.lblHdr発注納期 = New DataDynamics.ActiveReports.Label()
        Me.txtHrd発注納期 = New DataDynamics.ActiveReports.TextBox()
        Me.lblHrd顧客商品No = New DataDynamics.ActiveReports.Label()
        Me.txtHrd顧客商品No = New DataDynamics.ActiveReports.TextBox()
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
        Me.lblHdr客先納期 = New DataDynamics.ActiveReports.Label()
        Me.txtHrd客先納期 = New DataDynamics.ActiveReports.TextBox()
        Me.lblHrd受注日 = New DataDynamics.ActiveReports.Label()
        Me.txtHrd受注日 = New DataDynamics.ActiveReports.TextBox()
        Me.lblHrdユーザー名 = New DataDynamics.ActiveReports.Label()
        Me.txtHrdユーザー名 = New DataDynamics.ActiveReports.TextBox()
        Me.lblHdr受注数 = New DataDynamics.ActiveReports.Label()
        Me.Label19 = New DataDynamics.ActiveReports.Label()
        Me.lblHdr受注単価 = New DataDynamics.ActiveReports.Label()
        Me.lblHdr受注金額 = New DataDynamics.ActiveReports.Label()
        Me.txtHdr受注数 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox24 = New DataDynamics.ActiveReports.TextBox()
        Me.txtHdr受注単価 = New DataDynamics.ActiveReports.TextBox()
        Me.txtHdr受注金額 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl受注単価 = New DataDynamics.ActiveReports.Label()
        Me.grpFtr得意先CD = New DataDynamics.ActiveReports.GroupFooter()
        Me.OrderSlipAheadSubPaper = New DataDynamics.ActiveReports.SubReport()
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
        Me.txt請求先 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl刃型No = New DataDynamics.ActiveReports.Label()
        Me.txt刃型No = New DataDynamics.ActiveReports.TextBox()
        Me.txt版No = New DataDynamics.ActiveReports.TextBox()
        Me.lbl版No = New DataDynamics.ActiveReports.Label()
        Me.Label13 = New DataDynamics.ActiveReports.Label()
        Me.lbl版代 = New DataDynamics.ActiveReports.Label()
        Me.txt版代1 = New DataDynamics.ActiveReports.TextBox()
        Me.OrderSlipAheadSubNote = New DataDynamics.ActiveReports.SubReport()
        Me.OrderSlipAheadSubDelivery = New DataDynamics.ActiveReports.SubReport()
        Me.txt請求先CD = New DataDynamics.ActiveReports.TextBox()
        Me.lbl刃型代 = New DataDynamics.ActiveReports.Label()
        Me.txt刃型代1 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl版下代 = New DataDynamics.ActiveReports.Label()
        Me.txt版下代1 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl運賃 = New DataDynamics.ActiveReports.Label()
        Me.txt運賃1 = New DataDynamics.ActiveReports.TextBox()
        Me.lblその他 = New DataDynamics.ActiveReports.Label()
        Me.txtその他1 = New DataDynamics.ActiveReports.TextBox()
        Me.txt版代合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt刃型代合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt版下代合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt運賃合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txtその他合計 = New DataDynamics.ActiveReports.TextBox()
        Me.Label15 = New DataDynamics.ActiveReports.Label()
        Me.txt版代2 = New DataDynamics.ActiveReports.TextBox()
        Me.Label16 = New DataDynamics.ActiveReports.Label()
        Me.txt刃型代2 = New DataDynamics.ActiveReports.TextBox()
        Me.Label17 = New DataDynamics.ActiveReports.Label()
        Me.txt版下代 = New DataDynamics.ActiveReports.TextBox()
        Me.Label18 = New DataDynamics.ActiveReports.Label()
        Me.txt運賃2 = New DataDynamics.ActiveReports.TextBox()
        Me.Label20 = New DataDynamics.ActiveReports.Label()
        Me.txtその他2 = New DataDynamics.ActiveReports.TextBox()
        Me.Label21 = New DataDynamics.ActiveReports.Label()
        Me.Label22 = New DataDynamics.ActiveReports.Label()
        Me.Label23 = New DataDynamics.ActiveReports.Label()
        Me.Label24 = New DataDynamics.ActiveReports.Label()
        Me.Label25 = New DataDynamics.ActiveReports.Label()
        Me.txt指示区分1 = New DataDynamics.ActiveReports.TextBox()
        Me.txt指示区分2 = New DataDynamics.ActiveReports.TextBox()
        Me.txt指示区分3 = New DataDynamics.ActiveReports.TextBox()
        Me.txt指示区分4 = New DataDynamics.ActiveReports.TextBox()
        Me.txt指示区分5 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.txt枝番, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt定番, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt受注数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt発注単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt受注単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt先客納期, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt顧客発注No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl枝番, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl定番, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl受注数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl客先納期, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ｌｂｌHrd作業No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHrd作業No, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.lblHrd発注先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt発注先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHrd発注日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt発注日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr発注納期, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHrd発注納期, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHrd顧客商品No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHrd顧客商品No, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.lblHdr客先納期, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHrd客先納期, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHrd受注日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHrd受注日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHrdユーザー名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHrdユーザー名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr受注数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr受注単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr受注金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr受注数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr受注単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr受注金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl受注単価, System.ComponentModel.ISupportInitialize).BeginInit()
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
        CType(Me.txt請求先, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl刃型No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt刃型No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt版No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl版No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl版代, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt版代1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt請求先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl刃型代, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt刃型代1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl版下代, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt版下代1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl運賃, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt運賃1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblその他, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtその他1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt版代合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt刃型代合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt版下代合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt運賃合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtその他合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt版代2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt刃型代2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt版下代, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt運賃2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtその他2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt指示区分1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt指示区分2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt指示区分3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt指示区分4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt指示区分5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt枝番, Me.txt定番, Me.txt商品名, Me.txt受注数, Me.txt発注単価, Me.txt受注単価, Me.txt先客納期, Me.txt顧客発注No})
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
        Me.txt枝番.Width = 0.2755905!
        '
        'txt定番
        '
        Me.txt定番.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt定番.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt定番.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt定番.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt定番.Height = 0.3937008!
        Me.txt定番.Left = 0.2755905!
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
        Me.txt商品名.Left = 1.200787!
        Me.txt商品名.Name = "txt商品名"
        Me.txt商品名.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: top; ddo-" & _
    "char-set: 1"
        Me.txt商品名.Text = "9,999"
        Me.txt商品名.Top = 0.0!
        Me.txt商品名.Width = 2.086614!
        '
        'txt受注数
        '
        Me.txt受注数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注数.Height = 3.051181!
        Me.txt受注数.Left = 3.287401!
        Me.txt受注数.Name = "txt受注数"
        Me.txt受注数.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: top; ddo-" & _
    "char-set: 1"
        Me.txt受注数.Text = "99,9999"
        Me.txt受注数.Top = 0.0!
        Me.txt受注数.Width = 0.8267716!
        '
        'txt発注単価
        '
        Me.txt発注単価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注単価.Height = 3.051181!
        Me.txt発注単価.Left = 4.114173!
        Me.txt発注単価.Name = "txt発注単価"
        Me.txt発注単価.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: top; ddo-" & _
    "char-set: 1"
        Me.txt発注単価.Text = "999,999,999"
        Me.txt発注単価.Top = 0.0!
        Me.txt発注単価.Width = 0.8661417!
        '
        'txt受注単価
        '
        Me.txt受注単価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注単価.Height = 3.051181!
        Me.txt受注単価.Left = 4.980315!
        Me.txt受注単価.Name = "txt受注単価"
        Me.txt受注単価.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: top; ddo-" & _
    "char-set: 1"
        Me.txt受注単価.Text = "999,999,999"
        Me.txt受注単価.Top = 0.0!
        Me.txt受注単価.Width = 0.8464568!
        '
        'txt先客納期
        '
        Me.txt先客納期.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt先客納期.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt先客納期.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt先客納期.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt先客納期.Height = 3.051181!
        Me.txt先客納期.Left = 5.826771!
        Me.txt先客納期.Name = "txt先客納期"
        Me.txt先客納期.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: top; ddo-" & _
    "char-set: 1"
        Me.txt先客納期.Text = "999,999,999"
        Me.txt先客納期.Top = 0.0!
        Me.txt先客納期.Width = 0.6889764!
        '
        'txt顧客発注No
        '
        Me.txt顧客発注No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt顧客発注No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt顧客発注No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt顧客発注No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt顧客発注No.Height = 3.051181!
        Me.txt顧客発注No.Left = 6.515748!
        Me.txt顧客発注No.Name = "txt顧客発注No"
        Me.txt顧客発注No.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: top; ddo-" & _
    "char-set: 1"
        Me.txt顧客発注No.Text = "999,999,999"
        Me.txt顧客発注No.Top = 0.0!
        Me.txt顧客発注No.Width = 0.7874016!
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
        Me.grpHdr得意先CD.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lblTitle, Me.lbl枝番, Me.lbl定番, Me.lbl受注数, Me.lbl客先納期, Me.lbl商品名, Me.ｌｂｌHrd作業No, Me.txtHrd作業No, Me.Barcode, Me.lblHdr顧客様No, Me.Label1, Me.lblHdrユーザーNo, Me.Label7, Me.lblHdr本台帳番号, Me.Label10, Me.lblHdr枝番, Me.txtHdr顧客様No, Me.txtHdrユーザーNp, Me.txtHdr本台帳番号, Me.txtHdr枝番, Me.lblHrd発注先名, Me.txt発注先名, Me.txtHdr商品名, Me.lblHdr商品名, Me.lblHrd発注日, Me.txt発注日, Me.lblHdr発注納期, Me.txtHrd発注納期, Me.lblHrd顧客商品No, Me.txtHrd顧客商品No, Me.lblHdr発注数, Me.txtHdr発注数, Me.lblHdr通数, Me.txtHdr通数, Me.lblHdr発注単価, Me.txtHdr発注単価, Me.txtHdr発注金額, Me.lblHdr発注金額, Me.Label5, Me.lbl発注単価, Me.lbl顧客発注No, Me.lblHdr客先納期, Me.txtHrd客先納期, Me.lblHrd受注日, Me.txtHrd受注日, Me.lblHrdユーザー名, Me.txtHrdユーザー名, Me.lblHdr受注数, Me.Label19, Me.lblHdr受注単価, Me.lblHdr受注金額, Me.txtHdr受注数, Me.TextBox24, Me.txtHdr受注単価, Me.txtHdr受注金額, Me.lbl受注単価})
        Me.grpHdr得意先CD.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr得意先CD.Height = 2.700788!
        Me.grpHdr得意先CD.Name = "grpHdr得意先CD"
        Me.grpHdr得意先CD.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'lblTitle
        '
        Me.lblTitle.Height = 0.3937008!
        Me.lblTitle.HyperLink = Nothing
        Me.lblTitle.Left = 4.022048!
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 12pt; font-weight: bold; text-align:" & _
    " center; vertical-align: middle; ddo-char-set: 1"
        Me.lblTitle.Text = "発 注 伝 票(控)"
        Me.lblTitle.Top = 0.0!
        Me.lblTitle.Width = 1.663779!
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
        Me.lbl枝番.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lbl枝番.Text = "枝"
        Me.lbl枝番.Top = 2.48937!
        Me.lbl枝番.Width = 0.2755905!
        '
        'lbl定番
        '
        Me.lbl定番.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl定番.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl定番.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl定番.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl定番.Height = 0.1968504!
        Me.lbl定番.HyperLink = Nothing
        Me.lbl定番.Left = 0.2755905!
        Me.lbl定番.Name = "lbl定番"
        Me.lbl定番.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lbl定番.Text = "定　番"
        Me.lbl定番.Top = 2.48937!
        Me.lbl定番.Width = 0.9251968!
        '
        'lbl受注数
        '
        Me.lbl受注数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注数.Height = 0.1968504!
        Me.lbl受注数.HyperLink = Nothing
        Me.lbl受注数.Left = 3.287401!
        Me.lbl受注数.Name = "lbl受注数"
        Me.lbl受注数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lbl受注数.Text = "受 注 数"
        Me.lbl受注数.Top = 2.48937!
        Me.lbl受注数.Width = 0.8267716!
        '
        'lbl客先納期
        '
        Me.lbl客先納期.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl客先納期.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl客先納期.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl客先納期.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl客先納期.Height = 0.1968504!
        Me.lbl客先納期.HyperLink = Nothing
        Me.lbl客先納期.Left = 5.826772!
        Me.lbl客先納期.Name = "lbl客先納期"
        Me.lbl客先納期.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lbl客先納期.Text = "客先納期"
        Me.lbl客先納期.Top = 2.48937!
        Me.lbl客先納期.Width = 0.6889764!
        '
        'lbl商品名
        '
        Me.lbl商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.Height = 0.1968504!
        Me.lbl商品名.HyperLink = Nothing
        Me.lbl商品名.Left = 1.200787!
        Me.lbl商品名.Name = "lbl商品名"
        Me.lbl商品名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lbl商品名.Text = "商　　品　　名"
        Me.lbl商品名.Top = 2.48937!
        Me.lbl商品名.Width = 2.086614!
        '
        'ｌｂｌHrd作業No
        '
        Me.ｌｂｌHrd作業No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌHrd作業No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌHrd作業No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌHrd作業No.Height = 0.2755905!
        Me.ｌｂｌHrd作業No.HyperLink = Nothing
        Me.ｌｂｌHrd作業No.Left = 6.184252!
        Me.ｌｂｌHrd作業No.Name = "ｌｂｌHrd作業No"
        Me.ｌｂｌHrd作業No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.ｌｂｌHrd作業No.Text = "作業No"
        Me.ｌｂｌHrd作業No.Top = 0.7622048!
        Me.ｌｂｌHrd作業No.Width = 1.122047!
        '
        'txtHrd作業No
        '
        Me.txtHrd作業No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHrd作業No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHrd作業No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHrd作業No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHrd作業No.Height = 0.2755905!
        Me.txtHrd作業No.Left = 6.184252!
        Me.txtHrd作業No.Name = "txtHrd作業No"
        Me.txtHrd作業No.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtHrd作業No.Text = "123456"
        Me.txtHrd作業No.Top = 1.037795!
        Me.txtHrd作業No.Width = 1.122047!
        '
        'Barcode
        '
        Me.Barcode.CheckSumEnabled = False
        Me.Barcode.DataField = "ReportNoJudge"
        Me.Barcode.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.Barcode.Height = 0.3937008!
        Me.Barcode.Left = 6.077166!
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
        'lblHrd発注先名
        '
        Me.lblHrd発注先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHrd発注先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHrd発注先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHrd発注先名.Height = 0.1968504!
        Me.lblHrd発注先名.HyperLink = Nothing
        Me.lblHrd発注先名.Left = 0.0!
        Me.lblHrd発注先名.Name = "lblHrd発注先名"
        Me.lblHrd発注先名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lblHrd発注先名.Text = "発 注 先 名"
        Me.lblHrd発注先名.Top = 0.596063!
        Me.lblHrd発注先名.Width = 2.440945!
        '
        'txt発注先名
        '
        Me.txt発注先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注先名.Height = 0.1968504!
        Me.txt発注先名.Left = 0.0!
        Me.txt発注先名.Name = "txt発注先名"
        Me.txt発注先名.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt発注先名.Text = "あああああいいいいいううううう"
        Me.txt発注先名.Top = 0.7929134!
        Me.txt発注先名.Width = 2.440945!
        '
        'txtHdr商品名
        '
        Me.txtHdr商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr商品名.Height = 0.1968504!
        Me.txtHdr商品名.Left = 0.0!
        Me.txtHdr商品名.Name = "txtHdr商品名"
        Me.txtHdr商品名.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtHdr商品名.Text = "あああああいいいいいううううう"
        Me.txtHdr商品名.Top = 1.626378!
        Me.txtHdr商品名.Width = 2.440945!
        '
        'lblHdr商品名
        '
        Me.lblHdr商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr商品名.Height = 0.1968504!
        Me.lblHdr商品名.HyperLink = Nothing
        Me.lblHdr商品名.Left = 0.0!
        Me.lblHdr商品名.Name = "lblHdr商品名"
        Me.lblHdr商品名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lblHdr商品名.Text = "商　　品　　名"
        Me.lblHdr商品名.Top = 1.429528!
        Me.lblHdr商品名.Width = 2.440945!
        '
        'lblHrd発注日
        '
        Me.lblHrd発注日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHrd発注日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHrd発注日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHrd発注日.Height = 0.1968504!
        Me.lblHrd発注日.HyperLink = Nothing
        Me.lblHrd発注日.Left = 2.440945!
        Me.lblHrd発注日.Name = "lblHrd発注日"
        Me.lblHrd発注日.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lblHrd発注日.Text = "発 注 日"
        Me.lblHrd発注日.Top = 0.596063!
        Me.lblHrd発注日.Width = 0.8267716!
        '
        'txt発注日
        '
        Me.txt発注日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発注日.Height = 0.1968504!
        Me.txt発注日.Left = 2.440945!
        Me.txt発注日.Name = "txt発注日"
        Me.txt発注日.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt発注日.Text = "YYYY/MM/DD"
        Me.txt発注日.Top = 0.7929134!
        Me.txt発注日.Width = 0.8267716!
        '
        'lblHdr発注納期
        '
        Me.lblHdr発注納期.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr発注納期.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr発注納期.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr発注納期.Height = 0.1968504!
        Me.lblHdr発注納期.HyperLink = Nothing
        Me.lblHdr発注納期.Left = 3.267716!
        Me.lblHdr発注納期.Name = "lblHdr発注納期"
        Me.lblHdr発注納期.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lblHdr発注納期.Text = "発注納期"
        Me.lblHdr発注納期.Top = 0.5960631!
        Me.lblHdr発注納期.Width = 1.220472!
        '
        'txtHrd発注納期
        '
        Me.txtHrd発注納期.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHrd発注納期.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHrd発注納期.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHrd発注納期.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHrd発注納期.Height = 0.1968504!
        Me.txtHrd発注納期.Left = 3.267716!
        Me.txtHrd発注納期.Name = "txtHrd発注納期"
        Me.txtHrd発注納期.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtHrd発注納期.Text = "YYYY/MM/DD"
        Me.txtHrd発注納期.Top = 0.7929135!
        Me.txtHrd発注納期.Width = 1.220472!
        '
        'lblHrd顧客商品No
        '
        Me.lblHrd顧客商品No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHrd顧客商品No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHrd顧客商品No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHrd顧客商品No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHrd顧客商品No.Height = 0.1968504!
        Me.lblHrd顧客商品No.HyperLink = Nothing
        Me.lblHrd顧客商品No.Left = 4.488189!
        Me.lblHrd顧客商品No.Name = "lblHrd顧客商品No"
        Me.lblHrd顧客商品No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lblHrd顧客商品No.Text = "顧客商品No"
        Me.lblHrd顧客商品No.Top = 0.596063!
        Me.lblHrd顧客商品No.Width = 1.417323!
        '
        'txtHrd顧客商品No
        '
        Me.txtHrd顧客商品No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHrd顧客商品No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHrd顧客商品No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHrd顧客商品No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHrd顧客商品No.Height = 0.1968504!
        Me.txtHrd顧客商品No.Left = 4.488189!
        Me.txtHrd顧客商品No.Name = "txtHrd顧客商品No"
        Me.txtHrd顧客商品No.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtHrd顧客商品No.Text = "12345678"
        Me.txtHrd顧客商品No.Top = 0.7929134!
        Me.txtHrd顧客商品No.Width = 1.417323!
        '
        'lblHdr発注数
        '
        Me.lblHdr発注数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr発注数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr発注数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr発注数.Height = 0.1968504!
        Me.lblHdr発注数.HyperLink = Nothing
        Me.lblHdr発注数.Left = 2.440945!
        Me.lblHdr発注数.Name = "lblHdr発注数"
        Me.lblHdr発注数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lblHdr発注数.Text = "発　注　数"
        Me.lblHdr発注数.Top = 1.429527!
        Me.lblHdr発注数.Width = 1.259843!
        '
        'txtHdr発注数
        '
        Me.txtHdr発注数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr発注数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr発注数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr発注数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr発注数.Height = 0.1968504!
        Me.txtHdr発注数.Left = 2.440945!
        Me.txtHdr発注数.Name = "txtHdr発注数"
        Me.txtHdr発注数.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtHdr発注数.Text = "99,999枚"
        Me.txtHdr発注数.Top = 1.626377!
        Me.txtHdr発注数.Width = 1.259843!
        '
        'lblHdr通数
        '
        Me.lblHdr通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr通数.Height = 0.1968504!
        Me.lblHdr通数.HyperLink = Nothing
        Me.lblHdr通数.Left = 3.700788!
        Me.lblHdr通数.Name = "lblHdr通数"
        Me.lblHdr通数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lblHdr通数.Text = "通　　数"
        Me.lblHdr通数.Top = 1.429528!
        Me.lblHdr通数.Width = 1.259843!
        '
        'txtHdr通数
        '
        Me.txtHdr通数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr通数.Height = 0.1968504!
        Me.txtHdr通数.Left = 3.700788!
        Me.txtHdr通数.Name = "txtHdr通数"
        Me.txtHdr通数.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtHdr通数.Text = "9,999通"
        Me.txtHdr通数.Top = 1.626378!
        Me.txtHdr通数.Width = 1.259843!
        '
        'lblHdr発注単価
        '
        Me.lblHdr発注単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr発注単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr発注単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr発注単価.Height = 0.1968504!
        Me.lblHdr発注単価.HyperLink = Nothing
        Me.lblHdr発注単価.Left = 4.96063!
        Me.lblHdr発注単価.Name = "lblHdr発注単価"
        Me.lblHdr発注単価.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lblHdr発注単価.Text = "発 注 単 価"
        Me.lblHdr発注単価.Top = 1.429528!
        Me.lblHdr発注単価.Width = 1.141732!
        '
        'txtHdr発注単価
        '
        Me.txtHdr発注単価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr発注単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr発注単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr発注単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr発注単価.Height = 0.1968504!
        Me.txtHdr発注単価.Left = 4.96063!
        Me.txtHdr発注単価.Name = "txtHdr発注単価"
        Me.txtHdr発注単価.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtHdr発注単価.Text = "99,9999"
        Me.txtHdr発注単価.Top = 1.626378!
        Me.txtHdr発注単価.Width = 1.141732!
        '
        'txtHdr発注金額
        '
        Me.txtHdr発注金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr発注金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr発注金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr発注金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr発注金額.Height = 0.1968504!
        Me.txtHdr発注金額.Left = 6.102362!
        Me.txtHdr発注金額.Name = "txtHdr発注金額"
        Me.txtHdr発注金額.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtHdr発注金額.Text = "999,999,999円"
        Me.txtHdr発注金額.Top = 1.626377!
        Me.txtHdr発注金額.Width = 1.220472!
        '
        'lblHdr発注金額
        '
        Me.lblHdr発注金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr発注金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr発注金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr発注金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr発注金額.Height = 0.1968504!
        Me.lblHdr発注金額.HyperLink = Nothing
        Me.lblHdr発注金額.Left = 6.102362!
        Me.lblHdr発注金額.Name = "lblHdr発注金額"
        Me.lblHdr発注金額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lblHdr発注金額.Text = "発 注 金 額"
        Me.lblHdr発注金額.Top = 1.429527!
        Me.lblHdr発注金額.Width = 1.220472!
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
        Me.Label5.Top = 2.268898!
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
        Me.lbl発注単価.Left = 4.114173!
        Me.lbl発注単価.Name = "lbl発注単価"
        Me.lbl発注単価.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lbl発注単価.Text = "発注単価"
        Me.lbl発注単価.Top = 2.48937!
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
        Me.lbl顧客発注No.Left = 6.515748!
        Me.lbl顧客発注No.Name = "lbl顧客発注No"
        Me.lbl顧客発注No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lbl顧客発注No.Text = "顧客発注No"
        Me.lbl顧客発注No.Top = 2.488976!
        Me.lbl顧客発注No.Width = 0.7874016!
        '
        'lblHdr客先納期
        '
        Me.lblHdr客先納期.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr客先納期.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr客先納期.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr客先納期.Height = 0.1968504!
        Me.lblHdr客先納期.HyperLink = Nothing
        Me.lblHdr客先納期.Left = 3.267716!
        Me.lblHdr客先納期.Name = "lblHdr客先納期"
        Me.lblHdr客先納期.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lblHdr客先納期.Text = "客先納期"
        Me.lblHdr客先納期.Top = 0.989764!
        Me.lblHdr客先納期.Width = 1.220472!
        '
        'txtHrd客先納期
        '
        Me.txtHrd客先納期.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHrd客先納期.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHrd客先納期.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHrd客先納期.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHrd客先納期.Height = 0.1968504!
        Me.txtHrd客先納期.Left = 3.267716!
        Me.txtHrd客先納期.Name = "txtHrd客先納期"
        Me.txtHrd客先納期.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtHrd客先納期.Text = "YYYY/MM/DD"
        Me.txtHrd客先納期.Top = 1.186614!
        Me.txtHrd客先納期.Width = 1.220472!
        '
        'lblHrd受注日
        '
        Me.lblHrd受注日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHrd受注日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHrd受注日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHrd受注日.Height = 0.1968504!
        Me.lblHrd受注日.HyperLink = Nothing
        Me.lblHrd受注日.Left = 2.440945!
        Me.lblHrd受注日.Name = "lblHrd受注日"
        Me.lblHrd受注日.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lblHrd受注日.Text = "受 注 日"
        Me.lblHrd受注日.Top = 0.9897637!
        Me.lblHrd受注日.Width = 0.8267716!
        '
        'txtHrd受注日
        '
        Me.txtHrd受注日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHrd受注日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHrd受注日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHrd受注日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHrd受注日.Height = 0.1968504!
        Me.txtHrd受注日.Left = 2.440945!
        Me.txtHrd受注日.Name = "txtHrd受注日"
        Me.txtHrd受注日.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtHrd受注日.Text = "YYYY/MM/DD"
        Me.txtHrd受注日.Top = 1.186614!
        Me.txtHrd受注日.Width = 0.8267716!
        '
        'lblHrdユーザー名
        '
        Me.lblHrdユーザー名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHrdユーザー名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHrdユーザー名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHrdユーザー名.Height = 0.1968504!
        Me.lblHrdユーザー名.HyperLink = Nothing
        Me.lblHrdユーザー名.Left = 0.0!
        Me.lblHrdユーザー名.Name = "lblHrdユーザー名"
        Me.lblHrdユーザー名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lblHrdユーザー名.Text = "ユ　ー　ザ　ー 名"
        Me.lblHrdユーザー名.Top = 0.9897637!
        Me.lblHrdユーザー名.Width = 2.440945!
        '
        'txtHrdユーザー名
        '
        Me.txtHrdユーザー名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHrdユーザー名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHrdユーザー名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHrdユーザー名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHrdユーザー名.Height = 0.1968504!
        Me.txtHrdユーザー名.Left = 0.0!
        Me.txtHrdユーザー名.Name = "txtHrdユーザー名"
        Me.txtHrdユーザー名.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtHrdユーザー名.Text = "あああああいいいいいううううう"
        Me.txtHrdユーザー名.Top = 1.186614!
        Me.txtHrdユーザー名.Width = 2.440945!
        '
        'lblHdr受注数
        '
        Me.lblHdr受注数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr受注数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr受注数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr受注数.Height = 0.1968504!
        Me.lblHdr受注数.HyperLink = Nothing
        Me.lblHdr受注数.Left = 2.440945!
        Me.lblHdr受注数.Name = "lblHdr受注数"
        Me.lblHdr受注数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lblHdr受注数.Text = "受　注　数"
        Me.lblHdr受注数.Top = 1.823228!
        Me.lblHdr受注数.Width = 1.259842!
        '
        'Label19
        '
        Me.Label19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label19.Height = 0.1968504!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 3.700787!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.Label19.Text = ""
        Me.Label19.Top = 1.823228!
        Me.Label19.Width = 1.259842!
        '
        'lblHdr受注単価
        '
        Me.lblHdr受注単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr受注単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr受注単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr受注単価.Height = 0.1968504!
        Me.lblHdr受注単価.HyperLink = Nothing
        Me.lblHdr受注単価.Left = 4.960629!
        Me.lblHdr受注単価.Name = "lblHdr受注単価"
        Me.lblHdr受注単価.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lblHdr受注単価.Text = "受 注 単 価"
        Me.lblHdr受注単価.Top = 1.823228!
        Me.lblHdr受注単価.Width = 1.141733!
        '
        'lblHdr受注金額
        '
        Me.lblHdr受注金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr受注金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr受注金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr受注金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr受注金額.Height = 0.1968504!
        Me.lblHdr受注金額.HyperLink = Nothing
        Me.lblHdr受注金額.Left = 6.102362!
        Me.lblHdr受注金額.Name = "lblHdr受注金額"
        Me.lblHdr受注金額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lblHdr受注金額.Text = "受 注 金 額"
        Me.lblHdr受注金額.Top = 1.823228!
        Me.lblHdr受注金額.Width = 1.220472!
        '
        'txtHdr受注数
        '
        Me.txtHdr受注数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr受注数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr受注数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr受注数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr受注数.Height = 0.1968504!
        Me.txtHdr受注数.Left = 2.440945!
        Me.txtHdr受注数.Name = "txtHdr受注数"
        Me.txtHdr受注数.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtHdr受注数.Text = "99,999枚"
        Me.txtHdr受注数.Top = 2.020078!
        Me.txtHdr受注数.Width = 1.259842!
        '
        'TextBox24
        '
        Me.TextBox24.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox24.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox24.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox24.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox24.Height = 0.1968504!
        Me.TextBox24.Left = 3.700787!
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox24.Text = Nothing
        Me.TextBox24.Top = 2.020079!
        Me.TextBox24.Width = 1.259842!
        '
        'txtHdr受注単価
        '
        Me.txtHdr受注単価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr受注単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr受注単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr受注単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr受注単価.Height = 0.1968504!
        Me.txtHdr受注単価.Left = 4.960629!
        Me.txtHdr受注単価.Name = "txtHdr受注単価"
        Me.txtHdr受注単価.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtHdr受注単価.Text = "99,9999/枚"
        Me.txtHdr受注単価.Top = 2.020079!
        Me.txtHdr受注単価.Width = 1.141733!
        '
        'txtHdr受注金額
        '
        Me.txtHdr受注金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr受注金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr受注金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr受注金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr受注金額.Height = 0.1968504!
        Me.txtHdr受注金額.Left = 6.102362!
        Me.txtHdr受注金額.Name = "txtHdr受注金額"
        Me.txtHdr受注金額.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtHdr受注金額.Text = "999,999,999円"
        Me.txtHdr受注金額.Top = 2.020078!
        Me.txtHdr受注金額.Width = 1.220472!
        '
        'lbl受注単価
        '
        Me.lbl受注単価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注単価.Height = 0.1968504!
        Me.lbl受注単価.HyperLink = Nothing
        Me.lbl受注単価.Left = 4.980315!
        Me.lbl受注単価.Name = "lbl受注単価"
        Me.lbl受注単価.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lbl受注単価.Text = "受注単価"
        Me.lbl受注単価.Top = 2.48937!
        Me.lbl受注単価.Width = 0.8464568!
        '
        'grpFtr得意先CD
        '
        Me.grpFtr得意先CD.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.OrderSlipAheadSubPaper, Me.Label2, Me.Label14, Me.txt巻取, Me.lbl巻取, Me.lbl出し方向, Me.txt出し方向, Me.lbl紙管, Me.txt紙管, Me.lbl枚数, Me.txt枚数, Me.txtスリッター, Me.lblｽﾘｯﾀｰ, Me.lblｽﾘｯﾀｰ巾, Me.txtスリッター巾, Me.lblカット, Me.txtｶｯﾄ, Me.txt1ｼｰﾄ枚数, Me.lbl1シート枚数, Me.txt包装枚数, Me.lbl包装枚数, Me.txt送りピッチ, Me.lbl送りピッチ, Me.Label3, Me.Label4, Me.txt請求先, Me.lbl刃型No, Me.txt刃型No, Me.txt版No, Me.lbl版No, Me.Label13, Me.lbl版代, Me.txt版代1, Me.OrderSlipAheadSubNote, Me.OrderSlipAheadSubDelivery, Me.txt請求先CD, Me.lbl刃型代, Me.txt刃型代1, Me.lbl版下代, Me.txt版下代1, Me.lbl運賃, Me.txt運賃1, Me.lblその他, Me.txtその他1, Me.txt版代合計, Me.txt刃型代合計, Me.txt版下代合計, Me.txt運賃合計, Me.txtその他合計, Me.Label15, Me.txt版代2, Me.Label16, Me.txt刃型代2, Me.Label17, Me.txt版下代, Me.Label18, Me.txt運賃2, Me.Label20, Me.txtその他2, Me.Label21, Me.Label22, Me.Label23, Me.Label24, Me.Label25, Me.txt指示区分1, Me.txt指示区分2, Me.txt指示区分3, Me.txt指示区分4, Me.txt指示区分5})
        Me.grpFtr得意先CD.Height = 5.253839!
        Me.grpFtr得意先CD.Name = "grpFtr得意先CD"
        '
        'OrderSlipAheadSubPaper
        '
        Me.OrderSlipAheadSubPaper.CloseBorder = False
        Me.OrderSlipAheadSubPaper.Height = 1.181102!
        Me.OrderSlipAheadSubPaper.Left = 0.0!
        Me.OrderSlipAheadSubPaper.Name = "OrderSlipAheadSubPaper"
        Me.OrderSlipAheadSubPaper.Report = Nothing
        Me.OrderSlipAheadSubPaper.Top = 0.2720473!
        Me.OrderSlipAheadSubPaper.Width = 7.322835!
        '
        'Label2
        '
        Me.Label2.Height = 0.2165354!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.0!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; font-weight: bold; text-align:" & _
    " center; vertical-align: middle; ddo-char-set: 1"
        Me.Label2.Text = "【印　刷】"
        Me.Label2.Top = 0.02165354!
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
        Me.Label14.Top = 1.549606!
        Me.Label14.Width = 0.9204725!
        '
        'txt巻取
        '
        Me.txt巻取.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt巻取.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt巻取.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt巻取.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt巻取.Height = 0.2362205!
        Me.txt巻取.Left = 0.9960631!
        Me.txt巻取.Name = "txt巻取"
        Me.txt巻取.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt巻取.Text = "999"
        Me.txt巻取.Top = 1.718897!
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
        Me.lbl巻取.Left = 0.9960631!
        Me.lbl巻取.Name = "lbl巻取"
        Me.lbl巻取.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lbl巻取.Text = "巻取"
        Me.lbl巻取.Top = 1.522048!
        Me.lbl巻取.Width = 0.472441!
        '
        'lbl出し方向
        '
        Me.lbl出し方向.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl出し方向.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl出し方向.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl出し方向.Height = 0.1968504!
        Me.lbl出し方向.HyperLink = Nothing
        Me.lbl出し方向.Left = 1.468504!
        Me.lbl出し方向.Name = "lbl出し方向"
        Me.lbl出し方向.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lbl出し方向.Text = "出し方向"
        Me.lbl出し方向.Top = 1.522046!
        Me.lbl出し方向.Width = 0.6299213!
        '
        'txt出し方向
        '
        Me.txt出し方向.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出し方向.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出し方向.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出し方向.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出し方向.Height = 0.2362205!
        Me.txt出し方向.Left = 1.468504!
        Me.txt出し方向.Name = "txt出し方向"
        Me.txt出し方向.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt出し方向.Text = "99,999"
        Me.txt出し方向.Top = 1.718897!
        Me.txt出し方向.Width = 0.6299213!
        '
        'lbl紙管
        '
        Me.lbl紙管.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙管.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙管.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙管.Height = 0.1968504!
        Me.lbl紙管.HyperLink = Nothing
        Me.lbl紙管.Left = 2.098425!
        Me.lbl紙管.Name = "lbl紙管"
        Me.lbl紙管.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lbl紙管.Text = "紙管"
        Me.lbl紙管.Top = 1.522046!
        Me.lbl紙管.Width = 0.492126!
        '
        'txt紙管
        '
        Me.txt紙管.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙管.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙管.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙管.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙管.Height = 0.2362205!
        Me.txt紙管.Left = 2.098425!
        Me.txt紙管.Name = "txt紙管"
        Me.txt紙管.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt紙管.Text = "9,999"
        Me.txt紙管.Top = 1.718897!
        Me.txt紙管.Width = 0.492126!
        '
        'lbl枚数
        '
        Me.lbl枚数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl枚数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl枚数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl枚数.Height = 0.1968504!
        Me.lbl枚数.HyperLink = Nothing
        Me.lbl枚数.Left = 2.590551!
        Me.lbl枚数.Name = "lbl枚数"
        Me.lbl枚数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lbl枚数.Text = "枚数"
        Me.lbl枚数.Top = 1.522046!
        Me.lbl枚数.Width = 0.5511811!
        '
        'txt枚数
        '
        Me.txt枚数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt枚数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt枚数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt枚数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt枚数.Height = 0.2362205!
        Me.txt枚数.Left = 2.590551!
        Me.txt枚数.Name = "txt枚数"
        Me.txt枚数.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt枚数.Text = "99,9999"
        Me.txt枚数.Top = 1.718897!
        Me.txt枚数.Width = 0.5511811!
        '
        'txtスリッター
        '
        Me.txtスリッター.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtスリッター.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtスリッター.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtスリッター.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtスリッター.Height = 0.2362205!
        Me.txtスリッター.Left = 3.141732!
        Me.txtスリッター.Name = "txtスリッター"
        Me.txtスリッター.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txtスリッター.Text = "999"
        Me.txtスリッター.Top = 1.718897!
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
        Me.lblｽﾘｯﾀｰ.Left = 3.141732!
        Me.lblｽﾘｯﾀｰ.Name = "lblｽﾘｯﾀｰ"
        Me.lblｽﾘｯﾀｰ.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; text-justi" & _
    "fy: distribute; vertical-align: bottom; ddo-char-set: 1"
        Me.lblｽﾘｯﾀｰ.Text = "ｽﾘｯﾀｰ"
        Me.lblｽﾘｯﾀｰ.Top = 1.522048!
        Me.lblｽﾘｯﾀｰ.Width = 0.472441!
        '
        'lblｽﾘｯﾀｰ巾
        '
        Me.lblｽﾘｯﾀｰ巾.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblｽﾘｯﾀｰ巾.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblｽﾘｯﾀｰ巾.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblｽﾘｯﾀｰ巾.Height = 0.1968504!
        Me.lblｽﾘｯﾀｰ巾.HyperLink = Nothing
        Me.lblｽﾘｯﾀｰ巾.Left = 3.614173!
        Me.lblｽﾘｯﾀｰ巾.Name = "lblｽﾘｯﾀｰ巾"
        Me.lblｽﾘｯﾀｰ巾.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: bottom; ddo-char-set: 1"
        Me.lblｽﾘｯﾀｰ巾.Text = "ｽﾘｯﾀｰ巾"
        Me.lblｽﾘｯﾀｰ巾.Top = 1.522048!
        Me.lblｽﾘｯﾀｰ巾.Width = 0.6299213!
        '
        'txtスリッター巾
        '
        Me.txtスリッター巾.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtスリッター巾.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtスリッター巾.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtスリッター巾.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtスリッター巾.Height = 0.2362205!
        Me.txtスリッター巾.Left = 3.614173!
        Me.txtスリッター巾.Name = "txtスリッター巾"
        Me.txtスリッター巾.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txtスリッター巾.Text = "9,999"
        Me.txtスリッター巾.Top = 1.718897!
        Me.txtスリッター巾.Width = 0.6299213!
        '
        'lblカット
        '
        Me.lblカット.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblカット.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblカット.Height = 0.1968504!
        Me.lblカット.HyperLink = Nothing
        Me.lblカット.Left = 4.244094!
        Me.lblカット.Name = "lblカット"
        Me.lblカット.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.lblカット.Text = "ｶｯﾄ"
        Me.lblカット.Top = 1.522048!
        Me.lblカット.Width = 0.7874016!
        '
        'txtｶｯﾄ
        '
        Me.txtｶｯﾄ.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtｶｯﾄ.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtｶｯﾄ.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtｶｯﾄ.Height = 0.2362205!
        Me.txtｶｯﾄ.Left = 4.244094!
        Me.txtｶｯﾄ.Name = "txtｶｯﾄ"
        Me.txtｶｯﾄ.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txtｶｯﾄ.Text = "9999"
        Me.txtｶｯﾄ.Top = 1.718897!
        Me.txtｶｯﾄ.Width = 0.7874016!
        '
        'txt1ｼｰﾄ枚数
        '
        Me.txt1ｼｰﾄ枚数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt1ｼｰﾄ枚数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt1ｼｰﾄ枚数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt1ｼｰﾄ枚数.Height = 0.2362205!
        Me.txt1ｼｰﾄ枚数.Left = 5.031497!
        Me.txt1ｼｰﾄ枚数.Name = "txt1ｼｰﾄ枚数"
        Me.txt1ｼｰﾄ枚数.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt1ｼｰﾄ枚数.Text = "999,999"
        Me.txt1ｼｰﾄ枚数.Top = 1.718897!
        Me.txt1ｼｰﾄ枚数.Width = 0.7874017!
        '
        'lbl1シート枚数
        '
        Me.lbl1シート枚数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl1シート枚数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl1シート枚数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl1シート枚数.Height = 0.1968504!
        Me.lbl1シート枚数.HyperLink = Nothing
        Me.lbl1シート枚数.Left = 5.031497!
        Me.lbl1シート枚数.Name = "lbl1シート枚数"
        Me.lbl1シート枚数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; text-justif" & _
    "y: distribute; vertical-align: bottom; ddo-char-set: 1"
        Me.lbl1シート枚数.Text = "1ｼｰﾄ枚数"
        Me.lbl1シート枚数.Top = 1.522048!
        Me.lbl1シート枚数.Width = 0.7874016!
        '
        'txt包装枚数
        '
        Me.txt包装枚数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt包装枚数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt包装枚数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt包装枚数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt包装枚数.Height = 0.2362205!
        Me.txt包装枚数.Left = 5.818898!
        Me.txt包装枚数.Name = "txt包装枚数"
        Me.txt包装枚数.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt包装枚数.Text = "999,999"
        Me.txt包装枚数.Top = 1.718897!
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
        Me.lbl包装枚数.Left = 5.818898!
        Me.lbl包装枚数.Name = "lbl包装枚数"
        Me.lbl包装枚数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; text-justi" & _
    "fy: distribute; vertical-align: bottom; ddo-char-set: 1"
        Me.lbl包装枚数.Text = "包装枚数"
        Me.lbl包装枚数.Top = 1.522048!
        Me.lbl包装枚数.Width = 0.6496063!
        '
        'txt送りピッチ
        '
        Me.txt送りピッチ.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt送りピッチ.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt送りピッチ.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt送りピッチ.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt送りピッチ.Height = 0.2362205!
        Me.txt送りピッチ.Left = 6.468504!
        Me.txt送りピッチ.Name = "txt送りピッチ"
        Me.txt送りピッチ.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt送りピッチ.Text = "999,999"
        Me.txt送りピッチ.Top = 1.718897!
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
        Me.lbl送りピッチ.Left = 6.468504!
        Me.lbl送りピッチ.Name = "lbl送りピッチ"
        Me.lbl送りピッチ.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; text-justi" & _
    "fy: distribute; vertical-align: bottom; ddo-char-set: 1"
        Me.lbl送りピッチ.Text = "送りピッチ"
        Me.lbl送りピッチ.Top = 1.522046!
        Me.lbl送りピッチ.Width = 0.827559!
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
        Me.Label3.Top = 2.086221!
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
        Me.Label4.Text = "【請求先】"
        Me.Label4.Top = 3.161417!
        Me.Label4.Width = 0.9204725!
        '
        'txt請求先
        '
        Me.txt請求先.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt請求先.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt請求先.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt請求先.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt請求先.Height = 0.3543307!
        Me.txt請求先.Left = 1.511024!
        Me.txt請求先.Name = "txt請求先"
        Me.txt請求先.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: top; ddo" & _
    "-char-set: 1"
        Me.txt請求先.Text = Nothing
        Me.txt請求先.Top = 3.087795!
        Me.txt請求先.Width = 2.440945!
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
        Me.lbl刃型No.Top = 4.68819!
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
        Me.txt刃型No.Top = 4.683465!
        Me.txt刃型No.Width = 0.8661417!
        '
        'txt版No
        '
        Me.txt版No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt版No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt版No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt版No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt版No.Height = 0.2362205!
        Me.txt版No.Left = 2.967717!
        Me.txt版No.Name = "txt版No"
        Me.txt版No.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt版No.Text = "123"
        Me.txt版No.Top = 4.683465!
        Me.txt版No.Width = 1.023622!
        '
        'lbl版No
        '
        Me.lbl版No.Height = 0.1968504!
        Me.lbl版No.HyperLink = Nothing
        Me.lbl版No.Left = 2.088977!
        Me.lbl版No.Name = "lbl版No"
        Me.lbl版No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; font-weight: bold; text-align:" & _
    " right; vertical-align: middle; ddo-char-set: 1"
        Me.lbl版No.Text = "【版No】"
        Me.lbl版No.Top = 4.693702!
        Me.lbl版No.Width = 0.7874016!
        '
        'Label13
        '
        Me.Label13.Height = 0.2362205!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 0.0!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; font-weight: bold; text-align:" & _
    " center; vertical-align: middle; ddo-char-set: 1"
        Me.Label13.Text = "【売上方法】"
        Me.Label13.Top = 3.654725!
        Me.Label13.Width = 0.8661417!
        '
        'lbl版代
        '
        Me.lbl版代.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl版代.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl版代.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl版代.Height = 0.2165354!
        Me.lbl版代.HyperLink = Nothing
        Me.lbl版代.Left = 0.9102362!
        Me.lbl版代.Name = "lbl版代"
        Me.lbl版代.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl版代.Text = "版　代"
        Me.lbl版代.Top = 3.526378!
        Me.lbl版代.Width = 0.5905512!
        '
        'txt版代1
        '
        Me.txt版代1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt版代1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt版代1.Height = 0.2165354!
        Me.txt版代1.Left = 1.500787!
        Me.txt版代1.Name = "txt版代1"
        Me.txt版代1.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt版代1.Text = "99.999"
        Me.txt版代1.Top = 3.526378!
        Me.txt版代1.Width = 0.511811!
        '
        'OrderSlipAheadSubNote
        '
        Me.OrderSlipAheadSubNote.CloseBorder = False
        Me.OrderSlipAheadSubNote.Height = 2.972441!
        Me.OrderSlipAheadSubNote.Left = 4.152756!
        Me.OrderSlipAheadSubNote.Name = "OrderSlipAheadSubNote"
        Me.OrderSlipAheadSubNote.Report = Nothing
        Me.OrderSlipAheadSubNote.Top = 2.042913!
        Me.OrderSlipAheadSubNote.Width = 3.070866!
        '
        'OrderSlipAheadSubDelivery
        '
        Me.OrderSlipAheadSubDelivery.CloseBorder = False
        Me.OrderSlipAheadSubDelivery.Height = 0.9448819!
        Me.OrderSlipAheadSubDelivery.Left = 0.9204725!
        Me.OrderSlipAheadSubDelivery.Name = "OrderSlipAheadSubDelivery"
        Me.OrderSlipAheadSubDelivery.Report = Nothing
        Me.OrderSlipAheadSubDelivery.Top = 2.042913!
        Me.OrderSlipAheadSubDelivery.Width = 3.031496!
        '
        'txt請求先CD
        '
        Me.txt請求先CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt請求先CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt請求先CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt請求先CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt請求先CD.Height = 0.3543307!
        Me.txt請求先CD.Left = 0.9204725!
        Me.txt請求先CD.Name = "txt請求先CD"
        Me.txt請求先CD.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: top; ddo" & _
    "-char-set: 1"
        Me.txt請求先CD.Top = 3.087795!
        Me.txt請求先CD.Width = 0.5905512!
        '
        'lbl刃型代
        '
        Me.lbl刃型代.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl刃型代.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl刃型代.Height = 0.2165354!
        Me.lbl刃型代.HyperLink = Nothing
        Me.lbl刃型代.Left = 0.9102362!
        Me.lbl刃型代.Name = "lbl刃型代"
        Me.lbl刃型代.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl刃型代.Text = "刃型代"
        Me.lbl刃型代.Top = 3.742913!
        Me.lbl刃型代.Width = 0.5905511!
        '
        'txt刃型代1
        '
        Me.txt刃型代1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt刃型代1.Height = 0.2165354!
        Me.txt刃型代1.Left = 1.500788!
        Me.txt刃型代1.Name = "txt刃型代1"
        Me.txt刃型代1.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt刃型代1.Text = "99.999"
        Me.txt刃型代1.Top = 3.742913!
        Me.txt刃型代1.Width = 0.511811!
        '
        'lbl版下代
        '
        Me.lbl版下代.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl版下代.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl版下代.Height = 0.2165354!
        Me.lbl版下代.HyperLink = Nothing
        Me.lbl版下代.Left = 0.9102362!
        Me.lbl版下代.Name = "lbl版下代"
        Me.lbl版下代.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl版下代.Text = "版下代"
        Me.lbl版下代.Top = 3.959449!
        Me.lbl版下代.Width = 0.5905511!
        '
        'txt版下代1
        '
        Me.txt版下代1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt版下代1.Height = 0.2165354!
        Me.txt版下代1.Left = 1.500787!
        Me.txt版下代1.Name = "txt版下代1"
        Me.txt版下代1.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt版下代1.Text = "99.999"
        Me.txt版下代1.Top = 3.959449!
        Me.txt版下代1.Width = 0.511811!
        '
        'lbl運賃
        '
        Me.lbl運賃.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl運賃.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl運賃.Height = 0.2165354!
        Me.lbl運賃.HyperLink = Nothing
        Me.lbl運賃.Left = 0.9102362!
        Me.lbl運賃.Name = "lbl運賃"
        Me.lbl運賃.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl運賃.Text = "運　賃"
        Me.lbl運賃.Top = 4.175984!
        Me.lbl運賃.Width = 0.5905511!
        '
        'txt運賃1
        '
        Me.txt運賃1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt運賃1.Height = 0.2165354!
        Me.txt運賃1.Left = 1.500788!
        Me.txt運賃1.Name = "txt運賃1"
        Me.txt運賃1.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt運賃1.Text = "99.999"
        Me.txt運賃1.Top = 4.175984!
        Me.txt運賃1.Width = 0.511811!
        '
        'lblその他
        '
        Me.lblその他.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblその他.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblその他.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblその他.Height = 0.2165354!
        Me.lblその他.HyperLink = Nothing
        Me.lblその他.Left = 0.9102362!
        Me.lblその他.Name = "lblその他"
        Me.lblその他.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lblその他.Text = ""
        Me.lblその他.Top = 4.392519!
        Me.lblその他.Width = 0.5905511!
        '
        'txtその他1
        '
        Me.txtその他1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtその他1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtその他1.Height = 0.2165354!
        Me.txtその他1.Left = 1.500788!
        Me.txtその他1.Name = "txtその他1"
        Me.txtその他1.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txtその他1.Text = "99.999"
        Me.txtその他1.Top = 4.392519!
        Me.txtその他1.Width = 0.511811!
        '
        'txt版代合計
        '
        Me.txt版代合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt版代合計.Height = 0.2165354!
        Me.txt版代合計.Left = 2.91811!
        Me.txt版代合計.Name = "txt版代合計"
        Me.txt版代合計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt版代合計.Text = "99.999"
        Me.txt版代合計.Top = 3.526378!
        Me.txt版代合計.Width = 0.511811!
        '
        'txt刃型代合計
        '
        Me.txt刃型代合計.Height = 0.2165354!
        Me.txt刃型代合計.Left = 2.91811!
        Me.txt刃型代合計.Name = "txt刃型代合計"
        Me.txt刃型代合計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt刃型代合計.Text = "99.999"
        Me.txt刃型代合計.Top = 3.742913!
        Me.txt刃型代合計.Width = 0.511811!
        '
        'txt版下代合計
        '
        Me.txt版下代合計.Height = 0.2165354!
        Me.txt版下代合計.Left = 2.91811!
        Me.txt版下代合計.Name = "txt版下代合計"
        Me.txt版下代合計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt版下代合計.Text = "99.999"
        Me.txt版下代合計.Top = 3.959449!
        Me.txt版下代合計.Width = 0.511811!
        '
        'txt運賃合計
        '
        Me.txt運賃合計.Height = 0.2165354!
        Me.txt運賃合計.Left = 2.91811!
        Me.txt運賃合計.Name = "txt運賃合計"
        Me.txt運賃合計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt運賃合計.Text = "99.999"
        Me.txt運賃合計.Top = 4.175984!
        Me.txt運賃合計.Width = 0.511811!
        '
        'txtその他合計
        '
        Me.txtその他合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtその他合計.Height = 0.2165354!
        Me.txtその他合計.Left = 2.91811!
        Me.txtその他合計.Name = "txtその他合計"
        Me.txtその他合計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txtその他合計.Text = "99.999"
        Me.txtその他合計.Top = 4.39252!
        Me.txtその他合計.Width = 0.511811!
        '
        'Label15
        '
        Me.Label15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label15.Height = 0.2165354!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 2.012599!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.Label15.Text = "×"
        Me.Label15.Top = 3.526378!
        Me.Label15.Width = 0.1968504!
        '
        'txt版代2
        '
        Me.txt版代2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt版代2.Height = 0.2165354!
        Me.txt版代2.Left = 2.209449!
        Me.txt版代2.Name = "txt版代2"
        Me.txt版代2.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt版代2.Text = "99.999"
        Me.txt版代2.Top = 3.526378!
        Me.txt版代2.Width = 0.511811!
        '
        'Label16
        '
        Me.Label16.Height = 0.2165354!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 2.012599!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.Label16.Text = "×"
        Me.Label16.Top = 3.742913!
        Me.Label16.Width = 0.1968504!
        '
        'txt刃型代2
        '
        Me.txt刃型代2.Height = 0.2165354!
        Me.txt刃型代2.Left = 2.209449!
        Me.txt刃型代2.Name = "txt刃型代2"
        Me.txt刃型代2.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt刃型代2.Text = "99.999"
        Me.txt刃型代2.Top = 3.742913!
        Me.txt刃型代2.Width = 0.511811!
        '
        'Label17
        '
        Me.Label17.Height = 0.2165354!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 2.012599!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.Label17.Text = "×"
        Me.Label17.Top = 3.959449!
        Me.Label17.Width = 0.1968504!
        '
        'txt版下代
        '
        Me.txt版下代.Height = 0.2165354!
        Me.txt版下代.Left = 2.209449!
        Me.txt版下代.Name = "txt版下代"
        Me.txt版下代.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt版下代.Text = "99.999"
        Me.txt版下代.Top = 3.959449!
        Me.txt版下代.Width = 0.511811!
        '
        'Label18
        '
        Me.Label18.Height = 0.2165354!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 2.012599!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.Label18.Text = "×"
        Me.Label18.Top = 4.175984!
        Me.Label18.Width = 0.1968504!
        '
        'txt運賃2
        '
        Me.txt運賃2.Height = 0.2165354!
        Me.txt運賃2.Left = 2.209449!
        Me.txt運賃2.Name = "txt運賃2"
        Me.txt運賃2.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt運賃2.Text = "99.999"
        Me.txt運賃2.Top = 4.175984!
        Me.txt運賃2.Width = 0.511811!
        '
        'Label20
        '
        Me.Label20.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label20.Height = 0.2165354!
        Me.Label20.HyperLink = Nothing
        Me.Label20.Left = 2.012599!
        Me.Label20.Name = "Label20"
        Me.Label20.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.Label20.Text = "×"
        Me.Label20.Top = 4.39252!
        Me.Label20.Width = 0.1968504!
        '
        'txtその他2
        '
        Me.txtその他2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtその他2.Height = 0.2165354!
        Me.txtその他2.Left = 2.209449!
        Me.txtその他2.Name = "txtその他2"
        Me.txtその他2.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txtその他2.Text = "99.999"
        Me.txtその他2.Top = 4.39252!
        Me.txtその他2.Width = 0.511811!
        '
        'Label21
        '
        Me.Label21.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label21.Height = 0.2165354!
        Me.Label21.HyperLink = Nothing
        Me.Label21.Left = 2.72126!
        Me.Label21.Name = "Label21"
        Me.Label21.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.Label21.Text = "="
        Me.Label21.Top = 3.526378!
        Me.Label21.Width = 0.1968504!
        '
        'Label22
        '
        Me.Label22.Height = 0.2165354!
        Me.Label22.HyperLink = Nothing
        Me.Label22.Left = 2.72126!
        Me.Label22.Name = "Label22"
        Me.Label22.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.Label22.Text = "="
        Me.Label22.Top = 3.742913!
        Me.Label22.Width = 0.1968504!
        '
        'Label23
        '
        Me.Label23.Height = 0.2165354!
        Me.Label23.HyperLink = Nothing
        Me.Label23.Left = 2.72126!
        Me.Label23.Name = "Label23"
        Me.Label23.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.Label23.Text = "="
        Me.Label23.Top = 3.959449!
        Me.Label23.Width = 0.1968504!
        '
        'Label24
        '
        Me.Label24.Height = 0.2165354!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 2.72126!
        Me.Label24.Name = "Label24"
        Me.Label24.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.Label24.Text = "="
        Me.Label24.Top = 4.175984!
        Me.Label24.Width = 0.1968504!
        '
        'Label25
        '
        Me.Label25.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label25.Height = 0.2165354!
        Me.Label25.HyperLink = Nothing
        Me.Label25.Left = 2.72126!
        Me.Label25.Name = "Label25"
        Me.Label25.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.Label25.Text = "="
        Me.Label25.Top = 4.392519!
        Me.Label25.Width = 0.1968504!
        '
        'txt指示区分1
        '
        Me.txt指示区分1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt指示区分1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt指示区分1.Height = 0.2165354!
        Me.txt指示区分1.Left = 3.429921!
        Me.txt指示区分1.Name = "txt指示区分1"
        Me.txt指示区分1.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt指示区分1.Text = Nothing
        Me.txt指示区分1.Top = 3.526378!
        Me.txt指示区分1.Width = 0.511811!
        '
        'txt指示区分2
        '
        Me.txt指示区分2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt指示区分2.Height = 0.2165354!
        Me.txt指示区分2.Left = 3.429921!
        Me.txt指示区分2.Name = "txt指示区分2"
        Me.txt指示区分2.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt指示区分2.Text = Nothing
        Me.txt指示区分2.Top = 3.742913!
        Me.txt指示区分2.Width = 0.511811!
        '
        'txt指示区分3
        '
        Me.txt指示区分3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt指示区分3.Height = 0.2165354!
        Me.txt指示区分3.Left = 3.429921!
        Me.txt指示区分3.Name = "txt指示区分3"
        Me.txt指示区分3.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt指示区分3.Text = Nothing
        Me.txt指示区分3.Top = 3.959449!
        Me.txt指示区分3.Width = 0.511811!
        '
        'txt指示区分4
        '
        Me.txt指示区分4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt指示区分4.Height = 0.2165354!
        Me.txt指示区分4.Left = 3.429921!
        Me.txt指示区分4.Name = "txt指示区分4"
        Me.txt指示区分4.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt指示区分4.Text = Nothing
        Me.txt指示区分4.Top = 4.175984!
        Me.txt指示区分4.Width = 0.511811!
        '
        'txt指示区分5
        '
        Me.txt指示区分5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt指示区分5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt指示区分5.Height = 0.2165354!
        Me.txt指示区分5.Left = 3.429921!
        Me.txt指示区分5.Name = "txt指示区分5"
        Me.txt指示区分5.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt指示区分5.Text = Nothing
        Me.txt指示区分5.Top = 4.392519!
        Me.txt指示区分5.Width = 0.511811!
        '
        'OrderSlipSubAhead
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.322835!
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
        CType(Me.txt受注数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt発注単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt受注単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt先客納期, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt顧客発注No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl枝番, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl定番, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl受注数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl客先納期, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ｌｂｌHrd作業No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHrd作業No, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.lblHrd発注先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt発注先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHrd発注日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt発注日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr発注納期, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHrd発注納期, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHrd顧客商品No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHrd顧客商品No, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.lblHdr客先納期, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHrd客先納期, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHrd受注日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHrd受注日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHrdユーザー名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHrdユーザー名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr受注数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr受注単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr受注金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr受注数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr受注単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr受注金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl受注単価, System.ComponentModel.ISupportInitialize).EndInit()
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
        CType(Me.txt請求先, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl刃型No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt刃型No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt版No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl版No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl版代, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt版代1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt請求先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl刃型代, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt刃型代1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl版下代, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt版下代1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl運賃, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt運賃1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblその他, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtその他1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt版代合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt刃型代合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt版下代合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt運賃合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtその他合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt版代2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt刃型代2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt版下代, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt運賃2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtその他2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt指示区分1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt指示区分2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt指示区分3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt指示区分4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt指示区分5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Private WithEvents PageHeader As DataDynamics.ActiveReports.PageHeader
    Private WithEvents PageFooter As DataDynamics.ActiveReports.PageFooter
    Private WithEvents grpHdr得意先CD As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents lblTitle As DataDynamics.ActiveReports.Label
    Friend WithEvents lbl枝番 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl定番 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl受注数 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl客先納期 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl商品名 As DataDynamics.ActiveReports.Label
    Private WithEvents ｌｂｌHrd作業No As DataDynamics.ActiveReports.Label
    Private WithEvents txtHrd作業No As DataDynamics.ActiveReports.TextBox
    Private WithEvents Barcode As DataDynamics.ActiveReports.Barcode
    Private WithEvents grpFtr得意先CD As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents OrderSlipAheadSubPaper As DataDynamics.ActiveReports.SubReport
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
    Private WithEvents lblHrd発注先名 As DataDynamics.ActiveReports.Label
    Private WithEvents txt発注先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtHdr商品名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblHdr商品名 As DataDynamics.ActiveReports.Label
    Private WithEvents lblHrd発注日 As DataDynamics.ActiveReports.Label
    Private WithEvents txt発注日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblHdr発注納期 As DataDynamics.ActiveReports.Label
    Private WithEvents txtHrd発注納期 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblHrd顧客商品No As DataDynamics.ActiveReports.Label
    Private WithEvents txtHrd顧客商品No As DataDynamics.ActiveReports.TextBox
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
    Private WithEvents txt受注数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt発注単価 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt受注単価 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt先客納期 As DataDynamics.ActiveReports.TextBox
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
    Private WithEvents txt請求先 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl刃型No As DataDynamics.ActiveReports.Label
    Private WithEvents txt刃型No As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt版No As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl版No As DataDynamics.ActiveReports.Label
    Private WithEvents Label13 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl版代 As DataDynamics.ActiveReports.Label
    Private WithEvents txt版代1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents OrderSlipAheadSubNote As DataDynamics.ActiveReports.SubReport
    Private WithEvents OrderSlipAheadSubDelivery As DataDynamics.ActiveReports.SubReport
    Private WithEvents lblHdr客先納期 As DataDynamics.ActiveReports.Label
    Private WithEvents txtHrd客先納期 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblHrd受注日 As DataDynamics.ActiveReports.Label
    Private WithEvents txtHrd受注日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblHrdユーザー名 As DataDynamics.ActiveReports.Label
    Private WithEvents txtHrdユーザー名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblHdr受注数 As DataDynamics.ActiveReports.Label
    Private WithEvents Label19 As DataDynamics.ActiveReports.Label
    Private WithEvents lblHdr受注単価 As DataDynamics.ActiveReports.Label
    Private WithEvents lblHdr受注金額 As DataDynamics.ActiveReports.Label
    Private WithEvents txtHdr受注数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox24 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtHdr受注単価 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtHdr受注金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt顧客発注No As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl受注単価 As DataDynamics.ActiveReports.Label
    Private WithEvents txt請求先CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl刃型代 As DataDynamics.ActiveReports.Label
    Private WithEvents txt刃型代1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl版下代 As DataDynamics.ActiveReports.Label
    Private WithEvents txt版下代1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl運賃 As DataDynamics.ActiveReports.Label
    Private WithEvents txt運賃1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblその他 As DataDynamics.ActiveReports.Label
    Private WithEvents txtその他1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt版代合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt刃型代合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt版下代合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt運賃合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtその他合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label15 As DataDynamics.ActiveReports.Label
    Private WithEvents txt版代2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label16 As DataDynamics.ActiveReports.Label
    Private WithEvents txt刃型代2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label17 As DataDynamics.ActiveReports.Label
    Private WithEvents txt版下代 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label18 As DataDynamics.ActiveReports.Label
    Private WithEvents txt運賃2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label20 As DataDynamics.ActiveReports.Label
    Private WithEvents txtその他2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label21 As DataDynamics.ActiveReports.Label
    Private WithEvents Label22 As DataDynamics.ActiveReports.Label
    Private WithEvents Label23 As DataDynamics.ActiveReports.Label
    Private WithEvents Label24 As DataDynamics.ActiveReports.Label
    Private WithEvents Label25 As DataDynamics.ActiveReports.Label
    Private WithEvents txt指示区分1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt指示区分2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt指示区分3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt指示区分4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt指示区分5 As DataDynamics.ActiveReports.TextBox
End Class
