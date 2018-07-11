<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ShipRecord
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ShipRecord))
        Dim Line1 As DataDynamics.ActiveReports.Line
        Line1 = New DataDynamics.ActiveReports.Line()
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr = New DataDynamics.ActiveReports.GroupHeader()
        Me.txtHdr出荷先名 = New DataDynamics.ActiveReports.TextBox()
        Me.lblHdr出荷日 = New DataDynamics.ActiveReports.Label()
        Me.lblHdr総枚数 = New DataDynamics.ActiveReports.Label()
        Me.lblHdr巻取 = New DataDynamics.ActiveReports.Label()
        Me.lblHd紙管 = New DataDynamics.ActiveReports.Label()
        Me.lblHdr2検印 = New DataDynamics.ActiveReports.Label()
        Me.lblHdr枚数 = New DataDynamics.ActiveReports.Label()
        Me.lblHdr = New DataDynamics.ActiveReports.Label()
        Me.lblHdr巻数 = New DataDynamics.ActiveReports.Label()
        Me.lblHdr検印 = New DataDynamics.ActiveReports.Label()
        Me.lblHdr出方向 = New DataDynamics.ActiveReports.Label()
        Me.hid出荷先CD = New DataDynamics.ActiveReports.TextBox()
        Me.txtHdr出荷日 = New DataDynamics.ActiveReports.TextBox()
        Me.txtHdr検印 = New DataDynamics.ActiveReports.TextBox()
        Me.txtHdr2検印 = New DataDynamics.ActiveReports.TextBox()
        Me.txtHdr巻取 = New DataDynamics.ActiveReports.TextBox()
        Me.txtHdr出方向 = New DataDynamics.ActiveReports.TextBox()
        Me.txtHdr紙管 = New DataDynamics.ActiveReports.TextBox()
        Me.txtHdr枚数 = New DataDynamics.ActiveReports.TextBox()
        Me.txtHdr巻数 = New DataDynamics.ActiveReports.TextBox()
        Me.txtHdr総枚数 = New DataDynamics.ActiveReports.TextBox()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.txtHdr得意先名 = New DataDynamics.ActiveReports.TextBox()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.Label4 = New DataDynamics.ActiveReports.Label()
        Me.Barcode1 = New DataDynamics.ActiveReports.Barcode()
        Me.txt出荷先名 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl出荷日 = New DataDynamics.ActiveReports.Label()
        Me.lbl総枚数 = New DataDynamics.ActiveReports.Label()
        Me.lbl巻取 = New DataDynamics.ActiveReports.Label()
        Me.lbl紙管 = New DataDynamics.ActiveReports.Label()
        Me.lbl2検印 = New DataDynamics.ActiveReports.Label()
        Me.lbl枚数 = New DataDynamics.ActiveReports.Label()
        Me.Label14 = New DataDynamics.ActiveReports.Label()
        Me.lbl巻数 = New DataDynamics.ActiveReports.Label()
        Me.lbl検印 = New DataDynamics.ActiveReports.Label()
        Me.lbl出方向 = New DataDynamics.ActiveReports.Label()
        Me.txt出荷先CD = New DataDynamics.ActiveReports.TextBox()
        Me.txt出荷日 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox()
        Me.txt巻取 = New DataDynamics.ActiveReports.TextBox()
        Me.txt出方向 = New DataDynamics.ActiveReports.TextBox()
        Me.txt紙管 = New DataDynamics.ActiveReports.TextBox()
        Me.txt枚数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt巻数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総枚数 = New DataDynamics.ActiveReports.TextBox()
        Me.Label18 = New DataDynamics.ActiveReports.Label()
        Me.txt得意先名 = New DataDynamics.ActiveReports.TextBox()
        Me.Label19 = New DataDynamics.ActiveReports.Label()
        Me.Label20 = New DataDynamics.ActiveReports.Label()
        Me.lbl作業No = New DataDynamics.ActiveReports.Label()
        Me.lbl本台帳No = New DataDynamics.ActiveReports.Label()
        Me.txt作業No = New DataDynamics.ActiveReports.TextBox()
        Me.txt商品名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt商品CD = New DataDynamics.ActiveReports.TextBox()
        Me.Label7 = New DataDynamics.ActiveReports.Label()
        Me.Label8 = New DataDynamics.ActiveReports.Label()
        Me.txt納品日 = New DataDynamics.ActiveReports.TextBox()
        Me.grpFtr = New DataDynamics.ActiveReports.GroupFooter()
        CType(Me.txtHdr出荷先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr出荷日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr総枚数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr巻取, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHd紙管, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr2検印, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr枚数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr巻数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr検印, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr出方向, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.hid出荷先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr出荷日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr検印, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr2検印, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr巻取, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr出方向, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr紙管, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr枚数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr巻数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr総枚数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt出荷先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl出荷日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl総枚数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl巻取, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl紙管, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl2検印, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl枚数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl巻数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl検印, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl出方向, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt出荷先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt出荷日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt巻取, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt出方向, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt紙管, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt枚数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt巻数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総枚数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl作業No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl本台帳No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt作業No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt商品CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt納品日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Line1
        '
        Line1.Height = 0.0000333786!
        Line1.Left = 0.0!
        Line1.LineColor = System.Drawing.Color.DimGray
        Line1.LineWeight = 5.0!
        Line1.Name = "Line1"
        Line1.Top = 4.95666!
        Line1.Width = 7.677166!
        Line1.X1 = 0.0!
        Line1.X2 = 7.677166!
        Line1.Y1 = 4.956693!
        Line1.Y2 = 4.95666!
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Height = 0.0!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.RepeatToFill = True
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
        'grpHdr
        '
        Me.grpHdr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtHdr出荷先名, Me.lblHdr出荷日, Me.lblHdr総枚数, Me.lblHdr巻取, Me.lblHd紙管, Me.lblHdr2検印, Me.lblHdr枚数, Me.lblHdr, Me.lblHdr巻数, Me.lblHdr検印, Me.lblHdr出方向, Me.hid出荷先CD, Me.txtHdr出荷日, Me.txtHdr検印, Me.txtHdr2検印, Me.txtHdr巻取, Me.txtHdr出方向, Me.txtHdr紙管, Me.txtHdr枚数, Me.txtHdr巻数, Me.txtHdr総枚数, Me.Label1, Me.txtHdr得意先名, Me.Label2, Me.Label3, Me.Label4, Me.Barcode1, Line1, Me.txt出荷先名, Me.lbl出荷日, Me.lbl総枚数, Me.lbl巻取, Me.lbl紙管, Me.lbl2検印, Me.lbl枚数, Me.Label14, Me.lbl巻数, Me.lbl検印, Me.lbl出方向, Me.txt出荷先CD, Me.txt出荷日, Me.TextBox5, Me.TextBox6, Me.txt巻取, Me.txt出方向, Me.txt紙管, Me.txt枚数, Me.txt巻数, Me.txt総枚数, Me.Label18, Me.txt得意先名, Me.Label19, Me.Label20, Me.lbl作業No, Me.lbl本台帳No, Me.txt作業No, Me.txt商品名, Me.txt商品CD, Me.Label7, Me.Label8, Me.txt納品日})
        Me.grpHdr.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr.Height = 7.69685!
        Me.grpHdr.Name = "grpHdr"
        Me.grpHdr.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'txtHdr出荷先名
        '
        Me.txtHdr出荷先名.Height = 0.2362205!
        Me.txtHdr出荷先名.Left = 0.0!
        Me.txtHdr出荷先名.Name = "txtHdr出荷先名"
        Me.txtHdr出荷先名.Style = "font-family: ＭＳ 明朝; font-size: 12pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txtHdr出荷先名.Text = "あああああいいいいいううううう"
        Me.txtHdr出荷先名.Top = 0.0!
        Me.txtHdr出荷先名.Width = 2.608662!
        '
        'lblHdr出荷日
        '
        Me.lblHdr出荷日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr出荷日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr出荷日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr出荷日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr出荷日.Height = 0.2755905!
        Me.lblHdr出荷日.HyperLink = Nothing
        Me.lblHdr出荷日.Left = 1.023622!
        Me.lblHdr出荷日.Name = "lblHdr出荷日"
        Me.lblHdr出荷日.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 14pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lblHdr出荷日.Text = "出　荷　日"
        Me.lblHdr出荷日.Top = 0.864567!
        Me.lblHdr出荷日.Width = 1.732283!
        '
        'lblHdr総枚数
        '
        Me.lblHdr総枚数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr総枚数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr総枚数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr総枚数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr総枚数.Height = 0.2755905!
        Me.lblHdr総枚数.HyperLink = Nothing
        Me.lblHdr総枚数.Left = 6.680709!
        Me.lblHdr総枚数.Name = "lblHdr総枚数"
        Me.lblHdr総枚数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lblHdr総枚数.Text = "総枚数"
        Me.lblHdr総枚数.Top = 0.864567!
        Me.lblHdr総枚数.Width = 0.9645669!
        '
        'lblHdr巻取
        '
        Me.lblHdr巻取.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr巻取.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr巻取.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr巻取.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr巻取.Height = 0.2755905!
        Me.lblHdr巻取.HyperLink = Nothing
        Me.lblHdr巻取.Left = 3.078347!
        Me.lblHdr巻取.Name = "lblHdr巻取"
        Me.lblHdr巻取.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lblHdr巻取.Text = "巻取"
        Me.lblHdr巻取.Top = 0.864567!
        Me.lblHdr巻取.Width = 0.6102362!
        '
        'lblHd紙管
        '
        Me.lblHd紙管.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHd紙管.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHd紙管.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHd紙管.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHd紙管.Height = 0.2755905!
        Me.lblHd紙管.HyperLink = Nothing
        Me.lblHd紙管.Left = 4.279134!
        Me.lblHd紙管.Name = "lblHd紙管"
        Me.lblHd紙管.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lblHd紙管.Text = "紙管"
        Me.lblHd紙管.Top = 0.864567!
        Me.lblHd紙管.Width = 0.7086614!
        '
        'lblHdr2検印
        '
        Me.lblHdr2検印.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr2検印.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr2検印.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr2検印.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr2検印.Height = 0.2165354!
        Me.lblHdr2検印.HyperLink = Nothing
        Me.lblHdr2検印.Left = 6.947245!
        Me.lblHdr2検印.Name = "lblHdr2検印"
        Me.lblHdr2検印.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lblHdr2検印.Text = "検印"
        Me.lblHdr2検印.Top = 1.56063!
        Me.lblHdr2検印.Width = 0.6889764!
        '
        'lblHdr枚数
        '
        Me.lblHdr枚数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr枚数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr枚数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr枚数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr枚数.Height = 0.2755905!
        Me.lblHdr枚数.HyperLink = Nothing
        Me.lblHdr枚数.Left = 4.987796!
        Me.lblHdr枚数.Name = "lblHdr枚数"
        Me.lblHdr枚数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lblHdr枚数.Text = "枚数"
        Me.lblHdr枚数.Top = 0.8645658!
        Me.lblHdr枚数.Width = 0.9448819!
        '
        'lblHdr
        '
        Me.lblHdr.Height = 0.2362205!
        Me.lblHdr.HyperLink = Nothing
        Me.lblHdr.Left = 0.03070866!
        Me.lblHdr.Name = "lblHdr"
        Me.lblHdr.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 15pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lblHdr.Text = "出荷記録"
        Me.lblHdr.Top = 0.9622048!
        Me.lblHdr.Width = 0.8917323!
        '
        'lblHdr巻数
        '
        Me.lblHdr巻数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr巻数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr巻数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr巻数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr巻数.Height = 0.2755905!
        Me.lblHdr巻数.HyperLink = Nothing
        Me.lblHdr巻数.Left = 5.932678!
        Me.lblHdr巻数.Name = "lblHdr巻数"
        Me.lblHdr巻数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lblHdr巻数.Text = "巻数"
        Me.lblHdr巻数.Top = 0.864567!
        Me.lblHdr巻数.Width = 0.7480315!
        '
        'lblHdr検印
        '
        Me.lblHdr検印.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr検印.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr検印.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr検印.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr検印.Height = 0.2165354!
        Me.lblHdr検印.HyperLink = Nothing
        Me.lblHdr検印.Left = 6.258268!
        Me.lblHdr検印.Name = "lblHdr検印"
        Me.lblHdr検印.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lblHdr検印.Text = "検印"
        Me.lblHdr検印.Top = 1.56063!
        Me.lblHdr検印.Width = 0.6889764!
        '
        'lblHdr出方向
        '
        Me.lblHdr出方向.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr出方向.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr出方向.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr出方向.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblHdr出方向.Height = 0.2755905!
        Me.lblHdr出方向.HyperLink = Nothing
        Me.lblHdr出方向.Left = 3.688583!
        Me.lblHdr出方向.Name = "lblHdr出方向"
        Me.lblHdr出方向.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lblHdr出方向.Text = "出方向"
        Me.lblHdr出方向.Top = 0.864567!
        Me.lblHdr出方向.Width = 0.5905512!
        '
        'hid出荷先CD
        '
        Me.hid出荷先CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.hid出荷先CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.hid出荷先CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.hid出荷先CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.hid出荷先CD.Height = 0.1968504!
        Me.hid出荷先CD.Left = 2.625197!
        Me.hid出荷先CD.Name = "hid出荷先CD"
        Me.hid出荷先CD.Style = "background-color: Red; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; v" & _
    "ertical-align: middle; ddo-char-set: 1"
        Me.hid出荷先CD.Text = Nothing
        Me.hid出荷先CD.Top = 0.0!
        Me.hid出荷先CD.Width = 0.1968504!
        '
        'txtHdr出荷日
        '
        Me.txtHdr出荷日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr出荷日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr出荷日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr出荷日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr出荷日.Height = 0.2755905!
        Me.txtHdr出荷日.Left = 1.023622!
        Me.txtHdr出荷日.Name = "txtHdr出荷日"
        Me.txtHdr出荷日.Style = "font-family: ＭＳ 明朝; font-size: 14pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txtHdr出荷日.Text = "YY年MM月DD日"
        Me.txtHdr出荷日.Top = 1.140157!
        Me.txtHdr出荷日.Width = 1.732283!
        '
        'txtHdr検印
        '
        Me.txtHdr検印.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr検印.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr検印.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr検印.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr検印.Height = 0.7480315!
        Me.txtHdr検印.Left = 6.258268!
        Me.txtHdr検印.Name = "txtHdr検印"
        Me.txtHdr検印.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txtHdr検印.Text = Nothing
        Me.txtHdr検印.Top = 1.777164!
        Me.txtHdr検印.Width = 0.6889764!
        '
        'txtHdr2検印
        '
        Me.txtHdr2検印.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr2検印.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr2検印.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr2検印.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr2検印.Height = 0.7480315!
        Me.txtHdr2検印.Left = 6.947245!
        Me.txtHdr2検印.Name = "txtHdr2検印"
        Me.txtHdr2検印.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txtHdr2検印.Text = Nothing
        Me.txtHdr2検印.Top = 1.777164!
        Me.txtHdr2検印.Width = 0.6889764!
        '
        'txtHdr巻取
        '
        Me.txtHdr巻取.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr巻取.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr巻取.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr巻取.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr巻取.Height = 0.3149606!
        Me.txtHdr巻取.Left = 3.078347!
        Me.txtHdr巻取.Name = "txtHdr巻取"
        Me.txtHdr巻取.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txtHdr巻取.Text = "999"
        Me.txtHdr巻取.Top = 1.140157!
        Me.txtHdr巻取.Width = 0.6102362!
        '
        'txtHdr出方向
        '
        Me.txtHdr出方向.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr出方向.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr出方向.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr出方向.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr出方向.Height = 0.3149606!
        Me.txtHdr出方向.Left = 3.688583!
        Me.txtHdr出方向.Name = "txtHdr出方向"
        Me.txtHdr出方向.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txtHdr出方向.Text = "999"
        Me.txtHdr出方向.Top = 1.140157!
        Me.txtHdr出方向.Width = 0.5905512!
        '
        'txtHdr紙管
        '
        Me.txtHdr紙管.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr紙管.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr紙管.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr紙管.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr紙管.Height = 0.3149606!
        Me.txtHdr紙管.Left = 4.279134!
        Me.txtHdr紙管.Name = "txtHdr紙管"
        Me.txtHdr紙管.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txtHdr紙管.Text = "999m/m"
        Me.txtHdr紙管.Top = 1.140157!
        Me.txtHdr紙管.Width = 0.7086614!
        '
        'txtHdr枚数
        '
        Me.txtHdr枚数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr枚数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr枚数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr枚数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr枚数.Height = 0.3149606!
        Me.txtHdr枚数.Left = 4.987796!
        Me.txtHdr枚数.Name = "txtHdr枚数"
        Me.txtHdr枚数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txtHdr枚数.Text = "999枚/巻"
        Me.txtHdr枚数.Top = 1.140156!
        Me.txtHdr枚数.Width = 0.9448819!
        '
        'txtHdr巻数
        '
        Me.txtHdr巻数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr巻数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr巻数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr巻数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr巻数.Height = 0.3149606!
        Me.txtHdr巻数.Left = 5.932678!
        Me.txtHdr巻数.Name = "txtHdr巻数"
        Me.txtHdr巻数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txtHdr巻数.Text = "999巻"
        Me.txtHdr巻数.Top = 1.140157!
        Me.txtHdr巻数.Width = 0.7480315!
        '
        'txtHdr総枚数
        '
        Me.txtHdr総枚数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr総枚数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr総枚数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr総枚数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtHdr総枚数.Height = 0.3149606!
        Me.txtHdr総枚数.Left = 6.680709!
        Me.txtHdr総枚数.Name = "txtHdr総枚数"
        Me.txtHdr総枚数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txtHdr総枚数.Text = "999,999枚"
        Me.txtHdr総枚数.Top = 1.140157!
        Me.txtHdr総枚数.Width = 0.9645669!
        '
        'Label1
        '
        Me.Label1.Height = 0.2362205!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 3.19252!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.Label1.Text = "御中"
        Me.Label1.Top = 0.0!
        Me.Label1.Width = 0.3917322!
        '
        'txtHdr得意先名
        '
        Me.txtHdr得意先名.Height = 0.2362205!
        Me.txtHdr得意先名.Left = 3.840945!
        Me.txtHdr得意先名.Name = "txtHdr得意先名"
        Me.txtHdr得意先名.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txtHdr得意先名.Text = "あああああいいいいいうううううえええ"
        Me.txtHdr得意先名.Top = 0.0!
        Me.txtHdr得意先名.Width = 2.77874!
        '
        'Label2
        '
        Me.Label2.Height = 0.2362205!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 3.632677!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.Label2.Text = "("
        Me.Label2.Top = 0.0!
        Me.Label2.Width = 0.1968504!
        '
        'Label3
        '
        Me.Label3.Height = 0.2362205!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 6.680709!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.Label3.Text = "様御依頼分)"
        Me.Label3.Top = 0.0!
        Me.Label3.Width = 0.9645667!
        '
        'Label4
        '
        Me.Label4.Height = 0.2362205!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 0.03070866!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: justify; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.Label4.Text = "●お願い・・・出荷時には十分気を使って居りますが上記出荷サンプルを十分御確認の上御使用下さいます様お願い致します。"
        Me.Label4.Top = 4.646457!
        Me.Label4.Width = 7.605906!
        '
        'Barcode1
        '
        Me.Barcode1.Font = New System.Drawing.Font("Courier New", 8.0!)
        Me.Barcode1.Height = 0.4133858!
        Me.Barcode1.Left = 0.922441!
        Me.Barcode1.Name = "Barcode1"
        Me.Barcode1.Text = "Barcode1"
        Me.Barcode1.Top = 7.19882!
        Me.Barcode1.Width = 1.062992!
        '
        'txt出荷先名
        '
        Me.txt出荷先名.Height = 0.2362205!
        Me.txt出荷先名.Left = 0.2149603!
        Me.txt出荷先名.Name = "txt出荷先名"
        Me.txt出荷先名.Style = "font-family: ＭＳ 明朝; font-size: 12pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt出荷先名.Text = "あああああいいいいいううううう"
        Me.txt出荷先名.Top = 5.18189!
        Me.txt出荷先名.Width = 2.608662!
        '
        'lbl出荷日
        '
        Me.lbl出荷日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl出荷日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl出荷日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl出荷日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl出荷日.Height = 0.2755906!
        Me.lbl出荷日.HyperLink = Nothing
        Me.lbl出荷日.Left = 1.023622!
        Me.lbl出荷日.Name = "lbl出荷日"
        Me.lbl出荷日.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 14pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl出荷日.Text = "出　荷　日"
        Me.lbl出荷日.Top = 5.882678!
        Me.lbl出荷日.Width = 1.732283!
        '
        'lbl総枚数
        '
        Me.lbl総枚数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl総枚数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl総枚数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl総枚数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl総枚数.Height = 0.2755906!
        Me.lbl総枚数.HyperLink = Nothing
        Me.lbl総枚数.Left = 6.680709!
        Me.lbl総枚数.Name = "lbl総枚数"
        Me.lbl総枚数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl総枚数.Text = "総枚数"
        Me.lbl総枚数.Top = 5.882678!
        Me.lbl総枚数.Width = 0.9645666!
        '
        'lbl巻取
        '
        Me.lbl巻取.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl巻取.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl巻取.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl巻取.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl巻取.Height = 0.2755906!
        Me.lbl巻取.HyperLink = Nothing
        Me.lbl巻取.Left = 3.078347!
        Me.lbl巻取.Name = "lbl巻取"
        Me.lbl巻取.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl巻取.Text = "巻取"
        Me.lbl巻取.Top = 5.882678!
        Me.lbl巻取.Width = 0.6102362!
        '
        'lbl紙管
        '
        Me.lbl紙管.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙管.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙管.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙管.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙管.Height = 0.2755906!
        Me.lbl紙管.HyperLink = Nothing
        Me.lbl紙管.Left = 4.279134!
        Me.lbl紙管.Name = "lbl紙管"
        Me.lbl紙管.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl紙管.Text = "紙管"
        Me.lbl紙管.Top = 5.882678!
        Me.lbl紙管.Width = 0.7086611!
        '
        'lbl2検印
        '
        Me.lbl2検印.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl2検印.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl2検印.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl2検印.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl2検印.Height = 0.2165354!
        Me.lbl2検印.HyperLink = Nothing
        Me.lbl2検印.Left = 6.947245!
        Me.lbl2検印.Name = "lbl2検印"
        Me.lbl2検印.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl2検印.Text = "検印"
        Me.lbl2検印.Top = 6.609449!
        Me.lbl2検印.Width = 0.6889763!
        '
        'lbl枚数
        '
        Me.lbl枚数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl枚数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl枚数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl枚数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl枚数.Height = 0.2755906!
        Me.lbl枚数.HyperLink = Nothing
        Me.lbl枚数.Left = 4.987796!
        Me.lbl枚数.Name = "lbl枚数"
        Me.lbl枚数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl枚数.Text = "枚数"
        Me.lbl枚数.Top = 5.882677!
        Me.lbl枚数.Width = 0.944882!
        '
        'Label14
        '
        Me.Label14.Height = 0.2362205!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 0.03070866!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 15pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.Label14.Text = "出荷記録"
        Me.Label14.Top = 5.980316!
        Me.Label14.Width = 0.8917326!
        '
        'lbl巻数
        '
        Me.lbl巻数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl巻数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl巻数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl巻数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl巻数.Height = 0.2755906!
        Me.lbl巻数.HyperLink = Nothing
        Me.lbl巻数.Left = 5.932678!
        Me.lbl巻数.Name = "lbl巻数"
        Me.lbl巻数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl巻数.Text = "巻数"
        Me.lbl巻数.Top = 5.882678!
        Me.lbl巻数.Width = 0.7480313!
        '
        'lbl検印
        '
        Me.lbl検印.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl検印.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl検印.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl検印.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl検印.Height = 0.2165354!
        Me.lbl検印.HyperLink = Nothing
        Me.lbl検印.Left = 6.25827!
        Me.lbl検印.Name = "lbl検印"
        Me.lbl検印.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl検印.Text = "検印"
        Me.lbl検印.Top = 6.609449!
        Me.lbl検印.Width = 0.6889763!
        '
        'lbl出方向
        '
        Me.lbl出方向.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl出方向.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl出方向.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl出方向.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl出方向.Height = 0.2755906!
        Me.lbl出方向.HyperLink = Nothing
        Me.lbl出方向.Left = 3.688583!
        Me.lbl出方向.Name = "lbl出方向"
        Me.lbl出方向.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl出方向.Text = "出方向"
        Me.lbl出方向.Top = 5.882678!
        Me.lbl出方向.Width = 0.5905511!
        '
        'txt出荷先CD
        '
        Me.txt出荷先CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出荷先CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出荷先CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出荷先CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出荷先CD.Height = 0.1968504!
        Me.txt出荷先CD.Left = 2.840158!
        Me.txt出荷先CD.Name = "txt出荷先CD"
        Me.txt出荷先CD.Style = "background-color: Red; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; v" & _
    "ertical-align: middle; ddo-char-set: 1"
        Me.txt出荷先CD.Text = Nothing
        Me.txt出荷先CD.Top = 5.18189!
        Me.txt出荷先CD.Width = 0.1968504!
        '
        'txt出荷日
        '
        Me.txt出荷日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出荷日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出荷日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出荷日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出荷日.Height = 0.2755906!
        Me.txt出荷日.Left = 1.023622!
        Me.txt出荷日.Name = "txt出荷日"
        Me.txt出荷日.Style = "font-family: ＭＳ 明朝; font-size: 14pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt出荷日.Text = "YY年MM月DD日"
        Me.txt出荷日.Top = 6.158268!
        Me.txt出荷日.Width = 1.732283!
        '
        'TextBox5
        '
        Me.TextBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Height = 0.7480313!
        Me.TextBox5.Left = 6.25827!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox5.Text = Nothing
        Me.TextBox5.Top = 6.825984!
        Me.TextBox5.Width = 0.6889763!
        '
        'TextBox6
        '
        Me.TextBox6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Height = 0.7480313!
        Me.TextBox6.Left = 6.947245!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox6.Text = Nothing
        Me.TextBox6.Top = 6.825984!
        Me.TextBox6.Width = 0.6889763!
        '
        'txt巻取
        '
        Me.txt巻取.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt巻取.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt巻取.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt巻取.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt巻取.Height = 0.3149606!
        Me.txt巻取.Left = 3.078347!
        Me.txt巻取.Name = "txt巻取"
        Me.txt巻取.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt巻取.Text = "999"
        Me.txt巻取.Top = 6.158268!
        Me.txt巻取.Width = 0.6102362!
        '
        'txt出方向
        '
        Me.txt出方向.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出方向.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出方向.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出方向.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出方向.Height = 0.3149606!
        Me.txt出方向.Left = 3.688583!
        Me.txt出方向.Name = "txt出方向"
        Me.txt出方向.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt出方向.Text = "999"
        Me.txt出方向.Top = 6.158268!
        Me.txt出方向.Width = 0.5905511!
        '
        'txt紙管
        '
        Me.txt紙管.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙管.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙管.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙管.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙管.Height = 0.3149606!
        Me.txt紙管.Left = 4.279134!
        Me.txt紙管.Name = "txt紙管"
        Me.txt紙管.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt紙管.Text = "999m/m"
        Me.txt紙管.Top = 6.158268!
        Me.txt紙管.Width = 0.7086611!
        '
        'txt枚数
        '
        Me.txt枚数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt枚数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt枚数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt枚数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt枚数.Height = 0.3149606!
        Me.txt枚数.Left = 4.987796!
        Me.txt枚数.Name = "txt枚数"
        Me.txt枚数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt枚数.Text = "999枚/巻"
        Me.txt枚数.Top = 6.158267!
        Me.txt枚数.Width = 0.944882!
        '
        'txt巻数
        '
        Me.txt巻数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt巻数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt巻数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt巻数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt巻数.Height = 0.3149606!
        Me.txt巻数.Left = 5.932678!
        Me.txt巻数.Name = "txt巻数"
        Me.txt巻数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt巻数.Text = "999巻"
        Me.txt巻数.Top = 6.158268!
        Me.txt巻数.Width = 0.7480313!
        '
        'txt総枚数
        '
        Me.txt総枚数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総枚数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総枚数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総枚数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総枚数.Height = 0.3149606!
        Me.txt総枚数.Left = 6.680709!
        Me.txt総枚数.Name = "txt総枚数"
        Me.txt総枚数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt総枚数.Text = "999,999枚"
        Me.txt総枚数.Top = 6.158268!
        Me.txt総枚数.Width = 0.9645666!
        '
        'Label18
        '
        Me.Label18.Height = 0.2362205!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 3.40748!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.Label18.Text = "御中"
        Me.Label18.Top = 5.18189!
        Me.Label18.Width = 0.3917322!
        '
        'txt得意先名
        '
        Me.txt得意先名.Height = 0.2362205!
        Me.txt得意先名.Left = 0.2082677!
        Me.txt得意先名.Name = "txt得意先名"
        Me.txt得意先名.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt得意先名.Text = "あああああいいいいいうううううえええ"
        Me.txt得意先名.Top = 5.540158!
        Me.txt得意先名.Width = 2.77874!
        '
        'Label19
        '
        Me.Label19.Height = 0.2362205!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 0.0!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.Label19.Text = "("
        Me.Label19.Top = 5.540158!
        Me.Label19.Width = 0.1968504!
        '
        'Label20
        '
        Me.Label20.Height = 0.2362205!
        Me.Label20.HyperLink = Nothing
        Me.Label20.Left = 3.048023!
        Me.Label20.Name = "Label20"
        Me.Label20.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.Label20.Text = "様御依頼分)"
        Me.Label20.Top = 5.540158!
        Me.Label20.Width = 0.9645666!
        '
        'lbl作業No
        '
        Me.lbl作業No.Height = 0.2362205!
        Me.lbl作業No.HyperLink = Nothing
        Me.lbl作業No.Left = 0.2149606!
        Me.lbl作業No.Name = "lbl作業No"
        Me.lbl作業No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl作業No.Text = "作業No"
        Me.lbl作業No.Top = 6.559843!
        Me.lbl作業No.Width = 0.5480315!
        '
        'lbl本台帳No
        '
        Me.lbl本台帳No.Height = 0.2362205!
        Me.lbl本台帳No.HyperLink = Nothing
        Me.lbl本台帳No.Left = 0.08188977!
        Me.lbl本台帳No.Name = "lbl本台帳No"
        Me.lbl本台帳No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl本台帳No.Text = "本台帳No"
        Me.lbl本台帳No.Top = 7.300001!
        Me.lbl本台帳No.Width = 0.7086614!
        '
        'txt作業No
        '
        Me.txt作業No.Height = 0.2362205!
        Me.txt作業No.Left = 0.7629921!
        Me.txt作業No.Name = "txt作業No"
        Me.txt作業No.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt作業No.Text = "123456"
        Me.txt作業No.Top = 6.559843!
        Me.txt作業No.Width = 0.6952755!
        '
        'txt商品名
        '
        Me.txt商品名.Height = 0.2362205!
        Me.txt商品名.Left = 1.740157!
        Me.txt商品名.Name = "txt商品名"
        Me.txt商品名.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt商品名.Text = "あああああいいいいいうううううえええ"
        Me.txt商品名.Top = 6.559843!
        Me.txt商品名.Width = 2.77874!
        '
        'txt商品CD
        '
        Me.txt商品CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品CD.Height = 0.1968504!
        Me.txt商品CD.Left = 4.518898!
        Me.txt商品CD.Name = "txt商品CD"
        Me.txt商品CD.Style = "background-color: Red; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; v" & _
    "ertical-align: middle; ddo-char-set: 1"
        Me.txt商品CD.Text = Nothing
        Me.txt商品CD.Top = 6.559843!
        Me.txt商品CD.Width = 0.1968504!
        '
        'Label7
        '
        Me.Label7.Height = 0.2362205!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 3.173229!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.Label7.Text = "(出荷時注意事項)"
        Me.Label7.Top = 6.967717!
        Me.Label7.Width = 1.6!
        '
        'Label8
        '
        Me.Label8.Height = 0.3937008!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 4.144488!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 18pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.Label8.Text = "納品"
        Me.Label8.Top = 7.262992!
        Me.Label8.Width = 0.5905512!
        '
        'txt納品日
        '
        Me.txt納品日.Height = 0.3937008!
        Me.txt納品日.Left = 3.376772!
        Me.txt納品日.Name = "txt納品日"
        Me.txt納品日.Style = "font-family: ＭＳ 明朝; font-size: 18pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt納品日.Text = "99/99"
        Me.txt納品日.Top = 7.262993!
        Me.txt納品日.Width = 0.7086614!
        '
        'grpFtr
        '
        Me.grpFtr.Height = 0.0!
        Me.grpFtr.Name = "grpFtr"
        '
        'ShipRecord
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.677166!
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
        CType(Me.txtHdr出荷先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr出荷日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr総枚数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr巻取, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHd紙管, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr2検印, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr枚数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr巻数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr検印, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr出方向, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.hid出荷先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr出荷日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr検印, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr2検印, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr巻取, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr出方向, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr紙管, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr枚数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr巻数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr総枚数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt出荷先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl出荷日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl総枚数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl巻取, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl紙管, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl2検印, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl枚数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl巻数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl検印, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl出方向, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt出荷先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt出荷日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt巻取, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt出方向, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt紙管, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt枚数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt巻数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総枚数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl作業No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl本台帳No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt作業No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt商品CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt納品日, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txtHdr出荷先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblHdr出荷日 As DataDynamics.ActiveReports.Label
    Private WithEvents lblHdr総枚数 As DataDynamics.ActiveReports.Label
    Private WithEvents lblHdr巻取 As DataDynamics.ActiveReports.Label
    Private WithEvents lblHd紙管 As DataDynamics.ActiveReports.Label
    Private WithEvents lblHdr2検印 As DataDynamics.ActiveReports.Label
    Private WithEvents lblHdr枚数 As DataDynamics.ActiveReports.Label
    Private WithEvents lblHdr As DataDynamics.ActiveReports.Label
    Private WithEvents lblHdr巻数 As DataDynamics.ActiveReports.Label
    Private WithEvents lblHdr検印 As DataDynamics.ActiveReports.Label
    Private WithEvents lblHdr出方向 As DataDynamics.ActiveReports.Label
    Private WithEvents hid出荷先CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtHdr出荷日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtHdr検印 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtHdr2検印 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtHdr巻取 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtHdr出方向 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtHdr紙管 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtHdr枚数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtHdr巻数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtHdr総枚数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpFtr As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents txtHdr得意先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents Label4 As DataDynamics.ActiveReports.Label
    Private WithEvents Barcode1 As DataDynamics.ActiveReports.Barcode
    Private WithEvents txt出荷先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl出荷日 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl総枚数 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl巻取 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl紙管 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl2検印 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl枚数 As DataDynamics.ActiveReports.Label
    Private WithEvents Label14 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl巻数 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl検印 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl出方向 As DataDynamics.ActiveReports.Label
    Private WithEvents txt出荷先CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt出荷日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt巻取 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt出方向 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt紙管 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt枚数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt巻数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総枚数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label18 As DataDynamics.ActiveReports.Label
    Private WithEvents txt得意先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label19 As DataDynamics.ActiveReports.Label
    Private WithEvents Label20 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl作業No As DataDynamics.ActiveReports.Label
    Private WithEvents lbl本台帳No As DataDynamics.ActiveReports.Label
    Private WithEvents txt作業No As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt商品名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt商品CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label7 As DataDynamics.ActiveReports.Label
    Private WithEvents Label8 As DataDynamics.ActiveReports.Label
    Private WithEvents txt納品日 As DataDynamics.ActiveReports.TextBox
End Class
