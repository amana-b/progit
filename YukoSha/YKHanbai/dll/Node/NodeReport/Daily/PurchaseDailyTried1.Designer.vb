<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class PurchaseDailyTried1
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(PurchaseDailyTried1))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt仕入日 = New DataDynamics.ActiveReports.TextBox()
        Me.txtその他1 = New DataDynamics.ActiveReports.TextBox()
        Me.txt版刃型版下代 = New DataDynamics.ActiveReports.TextBox()
        Me.txt原紙代 = New DataDynamics.ActiveReports.TextBox()
        Me.txtその他2 = New DataDynamics.ActiveReports.TextBox()
        Me.txt基材費 = New DataDynamics.ActiveReports.TextBox()
        Me.txt消費税 = New DataDynamics.ActiveReports.TextBox()
        Me.txtPP代 = New DataDynamics.ActiveReports.TextBox()
        Me.txt外注代 = New DataDynamics.ActiveReports.TextBox()
        Me.txtオーバーコート = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.txtNow = New DataDynamics.ActiveReports.TextBox()
        Me.txt頁 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr = New DataDynamics.ActiveReports.GroupHeader()
        Me.txtHdr仕入日 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入日計累計表 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl仕入日 = New DataDynamics.ActiveReports.Label()
        Me.lblその他1 = New DataDynamics.ActiveReports.Label()
        Me.lbl版刃型版下代 = New DataDynamics.ActiveReports.Label()
        Me.lbl原紙代 = New DataDynamics.ActiveReports.Label()
        Me.ｌｂｌその他2 = New DataDynamics.ActiveReports.Label()
        Me.lbl消費税 = New DataDynamics.ActiveReports.Label()
        Me.lbl基材費 = New DataDynamics.ActiveReports.Label()
        Me.lblPP代 = New DataDynamics.ActiveReports.Label()
        Me.lblHdr仕入日 = New DataDynamics.ActiveReports.Label()
        Me.lbl外注代 = New DataDynamics.ActiveReports.Label()
        Me.lblオーバーコート = New DataDynamics.ActiveReports.Label()
        Me.grpFtr = New DataDynamics.ActiveReports.GroupFooter()
        Me.txtPR代合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt基材費合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txtその他2合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt消費税合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt原紙代合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt版刃型版下代合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txtその他1合計 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl発送日計 = New DataDynamics.ActiveReports.Label()
        Me.txt外注代合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txtオーバーコート合計 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.txt仕入日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtその他1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt版刃型版下代, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt原紙代, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtその他2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt基材費, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt消費税, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPP代, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt外注代, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtオーバーコート, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr仕入日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入日計累計表, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl仕入日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblその他1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl版刃型版下代, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl原紙代, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ｌｂｌその他2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl消費税, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl基材費, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPP代, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr仕入日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl外注代, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblオーバーコート, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPR代合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt基材費合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtその他2合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt消費税合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt原紙代合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt版刃型版下代合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtその他1合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl発送日計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt外注代合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtオーバーコート合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt仕入日, Me.txtその他1, Me.txt版刃型版下代, Me.txt原紙代, Me.txtその他2, Me.txt基材費, Me.txt消費税, Me.txtPP代, Me.txt外注代, Me.txtオーバーコート})
        Me.Detail.Height = 0.1968504!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.RepeatToFill = True
        '
        'txt仕入日
        '
        Me.txt仕入日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入日.Height = 0.1968504!
        Me.txt仕入日.Left = 0.0!
        Me.txt仕入日.Name = "txt仕入日"
        Me.txt仕入日.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt仕入日.Text = "MM/DD(●)"
        Me.txt仕入日.Top = 0.0!
        Me.txt仕入日.Width = 1.003937!
        '
        'txtその他1
        '
        Me.txtその他1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtその他1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtその他1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtその他1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtその他1.Height = 0.1968504!
        Me.txtその他1.Left = 5.019685!
        Me.txtその他1.Name = "txtその他1"
        Me.txtその他1.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txtその他1.Text = "999,999,999"
        Me.txtその他1.Top = 0.0!
        Me.txtその他1.Width = 1.003937!
        '
        'txt版刃型版下代
        '
        Me.txt版刃型版下代.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt版刃型版下代.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt版刃型版下代.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt版刃型版下代.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt版刃型版下代.Height = 0.1968504!
        Me.txt版刃型版下代.Left = 3.011811!
        Me.txt版刃型版下代.Name = "txt版刃型版下代"
        Me.txt版刃型版下代.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt版刃型版下代.Text = "999,999,999"
        Me.txt版刃型版下代.Top = 0.0!
        Me.txt版刃型版下代.Width = 1.003937!
        '
        'txt原紙代
        '
        Me.txt原紙代.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt原紙代.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt原紙代.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt原紙代.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt原紙代.Height = 0.1968504!
        Me.txt原紙代.Left = 1.003937!
        Me.txt原紙代.Name = "txt原紙代"
        Me.txt原紙代.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt原紙代.Text = "999,999,999"
        Me.txt原紙代.Top = 0.0!
        Me.txt原紙代.Width = 1.003937!
        '
        'txtその他2
        '
        Me.txtその他2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtその他2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtその他2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtその他2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtその他2.Height = 0.1968504!
        Me.txtその他2.Left = 6.023622!
        Me.txtその他2.Name = "txtその他2"
        Me.txtその他2.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txtその他2.Text = "999,999,999"
        Me.txtその他2.Top = 0.0!
        Me.txtその他2.Width = 1.003937!
        '
        'txt基材費
        '
        Me.txt基材費.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt基材費.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt基材費.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt基材費.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt基材費.Height = 0.1968504!
        Me.txt基材費.Left = 8.031495!
        Me.txt基材費.Name = "txt基材費"
        Me.txt基材費.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt基材費.Text = "999,999,999"
        Me.txt基材費.Top = 0.0!
        Me.txt基材費.Width = 1.003937!
        '
        'txt消費税
        '
        Me.txt消費税.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税.Height = 0.1968504!
        Me.txt消費税.Left = 7.027558!
        Me.txt消費税.Name = "txt消費税"
        Me.txt消費税.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt消費税.Text = "999,999,999"
        Me.txt消費税.Top = 0.0!
        Me.txt消費税.Width = 1.003937!
        '
        'txtPP代
        '
        Me.txtPP代.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtPP代.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtPP代.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtPP代.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtPP代.Height = 0.1968504!
        Me.txtPP代.Left = 9.035432!
        Me.txtPP代.Name = "txtPP代"
        Me.txtPP代.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txtPP代.Text = "999,999,999"
        Me.txtPP代.Top = 0.0!
        Me.txtPP代.Width = 1.003937!
        '
        'txt外注代
        '
        Me.txt外注代.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt外注代.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt外注代.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt外注代.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt外注代.Height = 0.1968504!
        Me.txt外注代.Left = 4.015748!
        Me.txt外注代.Name = "txt外注代"
        Me.txt外注代.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt外注代.Text = "999,999,999"
        Me.txt外注代.Top = 0.0!
        Me.txt外注代.Width = 1.003937!
        '
        'txtオーバーコート
        '
        Me.txtオーバーコート.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtオーバーコート.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtオーバーコート.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtオーバーコート.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtオーバーコート.Height = 0.1968504!
        Me.txtオーバーコート.Left = 2.007874!
        Me.txtオーバーコート.Name = "txtオーバーコート"
        Me.txtオーバーコート.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txtオーバーコート.Text = "999,999,999"
        Me.txtオーバーコート.Top = 0.0!
        Me.txtオーバーコート.Width = 1.003937!
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtNow, Me.txt頁})
        Me.PageHeader.Height = 0.2755905!
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
        Me.txt頁.Left = 10.33269!
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
        'grpHdr
        '
        Me.grpHdr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtHdr仕入日, Me.txt仕入日計累計表, Me.lbl仕入日, Me.lblその他1, Me.lbl版刃型版下代, Me.lbl原紙代, Me.ｌｂｌその他2, Me.lbl消費税, Me.lbl基材費, Me.lblPP代, Me.lblHdr仕入日, Me.lbl外注代, Me.lblオーバーコート})
        Me.grpHdr.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr.Height = 0.5913386!
        Me.grpHdr.Name = "grpHdr"
        Me.grpHdr.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'txtHdr仕入日
        '
        Me.txtHdr仕入日.Height = 0.2362205!
        Me.txtHdr仕入日.Left = 0.7874014!
        Me.txtHdr仕入日.Name = "txtHdr仕入日"
        Me.txtHdr仕入日.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txtHdr仕入日.Text = "00/00/00～99/99/99　日迄"
        Me.txtHdr仕入日.Top = 0.0!
        Me.txtHdr仕入日.Width = 2.098425!
        '
        'txt仕入日計累計表
        '
        Me.txt仕入日計累計表.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt仕入日計累計表.Height = 0.2362205!
        Me.txt仕入日計累計表.Left = 4.065748!
        Me.txt仕入日計累計表.Name = "txt仕入日計累計表"
        Me.txt仕入日計累計表.Style = "font-family: ＭＳ 明朝; font-size: 14pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt仕入日計累計表.Text = "仕入日計累計表"
        Me.txt仕入日計累計表.Top = 0.08110237!
        Me.txt仕入日計累計表.Width = 2.681497!
        '
        'lbl仕入日
        '
        Me.lbl仕入日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入日.Height = 0.1771654!
        Me.lbl仕入日.HyperLink = Nothing
        Me.lbl仕入日.Left = 0.0!
        Me.lbl仕入日.Name = "lbl仕入日"
        Me.lbl仕入日.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: justify; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl仕入日.Text = "　　日付"
        Me.lbl仕入日.Top = 0.4141732!
        Me.lbl仕入日.Width = 1.003937!
        '
        'lblその他1
        '
        Me.lblその他1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblその他1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblその他1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblその他1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblその他1.Height = 0.1771654!
        Me.lblその他1.HyperLink = Nothing
        Me.lblその他1.Left = 5.019685!
        Me.lblその他1.Name = "lblその他1"
        Me.lblその他1.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lblその他1.Text = "その他１"
        Me.lblその他1.Top = 0.4141732!
        Me.lblその他1.Width = 1.003937!
        '
        'lbl版刃型版下代
        '
        Me.lbl版刃型版下代.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl版刃型版下代.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl版刃型版下代.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl版刃型版下代.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl版刃型版下代.Height = 0.1771654!
        Me.lbl版刃型版下代.HyperLink = Nothing
        Me.lbl版刃型版下代.Left = 3.011811!
        Me.lbl版刃型版下代.Name = "lbl版刃型版下代"
        Me.lbl版刃型版下代.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl版刃型版下代.Text = "版，刃型，版下代"
        Me.lbl版刃型版下代.Top = 0.4141732!
        Me.lbl版刃型版下代.Width = 1.003937!
        '
        'lbl原紙代
        '
        Me.lbl原紙代.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl原紙代.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl原紙代.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl原紙代.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl原紙代.Height = 0.1771654!
        Me.lbl原紙代.HyperLink = Nothing
        Me.lbl原紙代.Left = 1.003937!
        Me.lbl原紙代.Name = "lbl原紙代"
        Me.lbl原紙代.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl原紙代.Text = "原紙代"
        Me.lbl原紙代.Top = 0.4141732!
        Me.lbl原紙代.Width = 1.003937!
        '
        'ｌｂｌその他2
        '
        Me.ｌｂｌその他2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌその他2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌその他2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌその他2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌその他2.Height = 0.1771654!
        Me.ｌｂｌその他2.HyperLink = Nothing
        Me.ｌｂｌその他2.Left = 6.023622!
        Me.ｌｂｌその他2.Name = "ｌｂｌその他2"
        Me.ｌｂｌその他2.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.ｌｂｌその他2.Text = "その他２"
        Me.ｌｂｌその他2.Top = 0.4141732!
        Me.ｌｂｌその他2.Width = 1.003937!
        '
        'lbl消費税
        '
        Me.lbl消費税.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl消費税.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl消費税.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl消費税.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl消費税.Height = 0.1771654!
        Me.lbl消費税.HyperLink = Nothing
        Me.lbl消費税.Left = 7.027558!
        Me.lbl消費税.Name = "lbl消費税"
        Me.lbl消費税.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl消費税.Text = "消費税"
        Me.lbl消費税.Top = 0.4141735!
        Me.lbl消費税.Width = 1.003937!
        '
        'lbl基材費
        '
        Me.lbl基材費.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl基材費.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl基材費.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl基材費.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl基材費.Height = 0.1771654!
        Me.lbl基材費.HyperLink = Nothing
        Me.lbl基材費.Left = 8.031495!
        Me.lbl基材費.Name = "lbl基材費"
        Me.lbl基材費.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 7.5pt; text-align: center; vertical-" & _
    "align: middle; ddo-char-set: 1"
        Me.lbl基材費.Text = "基材費"
        Me.lbl基材費.Top = 0.4141732!
        Me.lbl基材費.Width = 1.003937!
        '
        'lblPP代
        '
        Me.lblPP代.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblPP代.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblPP代.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblPP代.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblPP代.Height = 0.1771654!
        Me.lblPP代.HyperLink = Nothing
        Me.lblPP代.Left = 9.035432!
        Me.lblPP代.Name = "lblPP代"
        Me.lblPP代.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lblPP代.Text = "ＰＰ代"
        Me.lblPP代.Top = 0.4141732!
        Me.lblPP代.Width = 1.003937!
        '
        'lblHdr仕入日
        '
        Me.lblHdr仕入日.Height = 0.2362205!
        Me.lblHdr仕入日.HyperLink = Nothing
        Me.lblHdr仕入日.Left = 0.0!
        Me.lblHdr仕入日.Name = "lblHdr仕入日"
        Me.lblHdr仕入日.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lblHdr仕入日.Text = "仕入日"
        Me.lblHdr仕入日.Top = 0.0!
        Me.lblHdr仕入日.Width = 0.7874014!
        '
        'lbl外注代
        '
        Me.lbl外注代.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl外注代.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl外注代.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl外注代.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl外注代.Height = 0.1771654!
        Me.lbl外注代.HyperLink = Nothing
        Me.lbl外注代.Left = 4.015748!
        Me.lbl外注代.Name = "lbl外注代"
        Me.lbl外注代.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl外注代.Text = "外注代"
        Me.lbl外注代.Top = 0.4141732!
        Me.lbl外注代.Width = 1.003937!
        '
        'lblオーバーコート
        '
        Me.lblオーバーコート.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblオーバーコート.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblオーバーコート.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblオーバーコート.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lblオーバーコート.Height = 0.1771654!
        Me.lblオーバーコート.HyperLink = Nothing
        Me.lblオーバーコート.Left = 2.007874!
        Me.lblオーバーコート.Name = "lblオーバーコート"
        Me.lblオーバーコート.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lblオーバーコート.Text = "オーバーコート"
        Me.lblオーバーコート.Top = 0.4141732!
        Me.lblオーバーコート.Width = 1.003937!
        '
        'grpFtr
        '
        Me.grpFtr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtPR代合計, Me.txt基材費合計, Me.txtその他2合計, Me.txt消費税合計, Me.txt原紙代合計, Me.txt版刃型版下代合計, Me.txtその他1合計, Me.TextBox9, Me.lbl発送日計, Me.txt外注代合計, Me.txtオーバーコート合計})
        Me.grpFtr.Height = 0.2755905!
        Me.grpFtr.Name = "grpFtr"
        '
        'txtPR代合計
        '
        Me.txtPR代合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtPR代合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtPR代合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtPR代合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtPR代合計.Height = 0.1968504!
        Me.txtPR代合計.Left = 9.035432!
        Me.txtPR代合計.Name = "txtPR代合計"
        Me.txtPR代合計.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txtPR代合計.Text = "999,999,999"
        Me.txtPR代合計.Top = 0.0!
        Me.txtPR代合計.Width = 1.003937!
        '
        'txt基材費合計
        '
        Me.txt基材費合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt基材費合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt基材費合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt基材費合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt基材費合計.Height = 0.1968504!
        Me.txt基材費合計.Left = 8.031495!
        Me.txt基材費合計.Name = "txt基材費合計"
        Me.txt基材費合計.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt基材費合計.Text = "999,999,999"
        Me.txt基材費合計.Top = 0.0!
        Me.txt基材費合計.Width = 1.003937!
        '
        'txtその他2合計
        '
        Me.txtその他2合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtその他2合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtその他2合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtその他2合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtその他2合計.Height = 0.1968504!
        Me.txtその他2合計.Left = 6.023622!
        Me.txtその他2合計.Name = "txtその他2合計"
        Me.txtその他2合計.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txtその他2合計.Text = "999,999,999" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txtその他2合計.Top = 0.0!
        Me.txtその他2合計.Width = 1.003937!
        '
        'txt消費税合計
        '
        Me.txt消費税合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税合計.Height = 0.1968504!
        Me.txt消費税合計.Left = 7.027558!
        Me.txt消費税合計.Name = "txt消費税合計"
        Me.txt消費税合計.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt消費税合計.Text = "999,999,999"
        Me.txt消費税合計.Top = 0.0!
        Me.txt消費税合計.Width = 1.003937!
        '
        'txt原紙代合計
        '
        Me.txt原紙代合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt原紙代合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt原紙代合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt原紙代合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt原紙代合計.Height = 0.1968504!
        Me.txt原紙代合計.Left = 1.003937!
        Me.txt原紙代合計.Name = "txt原紙代合計"
        Me.txt原紙代合計.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt原紙代合計.Text = "999,999,999"
        Me.txt原紙代合計.Top = 0.0!
        Me.txt原紙代合計.Width = 1.003937!
        '
        'txt版刃型版下代合計
        '
        Me.txt版刃型版下代合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt版刃型版下代合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt版刃型版下代合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt版刃型版下代合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt版刃型版下代合計.Height = 0.1968504!
        Me.txt版刃型版下代合計.Left = 3.011811!
        Me.txt版刃型版下代合計.Name = "txt版刃型版下代合計"
        Me.txt版刃型版下代合計.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt版刃型版下代合計.Text = "999,999,999"
        Me.txt版刃型版下代合計.Top = 0.0!
        Me.txt版刃型版下代合計.Width = 1.003937!
        '
        'txtその他1合計
        '
        Me.txtその他1合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtその他1合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtその他1合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtその他1合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtその他1合計.Height = 0.1968504!
        Me.txtその他1合計.Left = 5.019685!
        Me.txtその他1合計.Name = "txtその他1合計"
        Me.txtその他1合計.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txtその他1合計.Text = "999,999,999"
        Me.txtその他1合計.Top = 0.0!
        Me.txtその他1合計.Width = 1.003937!
        '
        'TextBox9
        '
        Me.TextBox9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Height = 0.1968504!
        Me.TextBox9.Left = 0.0!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.TextBox9.Text = Nothing
        Me.TextBox9.Top = 0.0!
        Me.TextBox9.Width = 1.003937!
        '
        'lbl発送日計
        '
        Me.lbl発送日計.Height = 0.1574803!
        Me.lbl発送日計.HyperLink = Nothing
        Me.lbl発送日計.Left = 0.2866142!
        Me.lbl発送日計.Name = "lbl発送日計"
        Me.lbl発送日計.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl発送日計.Text = "＊合計"
        Me.lbl発送日計.Top = 0.02047244!
        Me.lbl発送日計.Width = 0.5905512!
        '
        'txt外注代合計
        '
        Me.txt外注代合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt外注代合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt外注代合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt外注代合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt外注代合計.Height = 0.1968504!
        Me.txt外注代合計.Left = 4.015748!
        Me.txt外注代合計.Name = "txt外注代合計"
        Me.txt外注代合計.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt外注代合計.Text = "999,999,999"
        Me.txt外注代合計.Top = 0.0!
        Me.txt外注代合計.Width = 1.003937!
        '
        'txtオーバーコート合計
        '
        Me.txtオーバーコート合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtオーバーコート合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtオーバーコート合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtオーバーコート合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txtオーバーコート合計.Height = 0.1968504!
        Me.txtオーバーコート合計.Left = 2.007874!
        Me.txtオーバーコート合計.Name = "txtオーバーコート合計"
        Me.txtオーバーコート合計.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txtオーバーコート合計.Text = "999,999,999"
        Me.txtオーバーコート合計.Top = 0.0!
        Me.txtオーバーコート合計.Width = 1.003937!
        '
        'PurchaseDailyTried1
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 10.84646!
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
        CType(Me.txt仕入日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtその他1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt版刃型版下代, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt原紙代, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtその他2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt基材費, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt消費税, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPP代, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt外注代, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtオーバーコート, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr仕入日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入日計累計表, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl仕入日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblその他1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl版刃型版下代, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl原紙代, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ｌｂｌその他2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl消費税, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl基材費, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPP代, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr仕入日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl外注代, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblオーバーコート, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPR代合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt基材費合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtその他2合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt消費税合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt原紙代合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt版刃型版下代合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtその他1合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl発送日計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt外注代合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtオーバーコート合計, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txt仕入日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtその他1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt原紙代 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtその他2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpFtr As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txt基材費 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt消費税 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtPP代 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtNow As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt頁 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtPR代合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt基材費合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtその他2合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt消費税合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt原紙代合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt版刃型版下代合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtその他1合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtHdr仕入日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入日計累計表 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl仕入日 As DataDynamics.ActiveReports.Label
    Private WithEvents lblその他1 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl版刃型版下代 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl原紙代 As DataDynamics.ActiveReports.Label
    Private WithEvents ｌｂｌその他2 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl消費税 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl基材費 As DataDynamics.ActiveReports.Label
    Private WithEvents lblPP代 As DataDynamics.ActiveReports.Label
    Private WithEvents lblHdr仕入日 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl発送日計 As DataDynamics.ActiveReports.Label
    Private WithEvents txt外注代 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl外注代 As DataDynamics.ActiveReports.Label
    Private WithEvents txt外注代合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtオーバーコート As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtオーバーコート合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lblオーバーコート As DataDynamics.ActiveReports.Label
    Private WithEvents txt版刃型版下代 As DataDynamics.ActiveReports.TextBox
End Class
