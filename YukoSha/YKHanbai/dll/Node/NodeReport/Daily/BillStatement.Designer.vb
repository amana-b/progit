﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class BillStatement
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(BillStatement))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt区分 = New DataDynamics.ActiveReports.TextBox()
        Me.txt伝票No = New DataDynamics.ActiveReports.TextBox()
        Me.txt数量 = New DataDynamics.ActiveReports.TextBox()
        Me.txt単価 = New DataDynamics.ActiveReports.TextBox()
        Me.txt金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt日付 = New DataDynamics.ActiveReports.TextBox()
        Me.txt商品名 = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr作業No = New DataDynamics.ActiveReports.GroupHeader()
        Me.lbl区分 = New DataDynamics.ActiveReports.Label()
        Me.lbl商品名 = New DataDynamics.ActiveReports.Label()
        Me.lbl数量 = New DataDynamics.ActiveReports.Label()
        Me.lbl金額 = New DataDynamics.ActiveReports.Label()
        Me.lbl伝票No = New DataDynamics.ActiveReports.Label()
        Me.lbl単価 = New DataDynamics.ActiveReports.Label()
        Me.lbl前回残高 = New DataDynamics.ActiveReports.Label()
        Me.txt前回残高 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl相殺その他 = New DataDynamics.ActiveReports.Label()
        Me.txt操作その他 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl今回売上 = New DataDynamics.ActiveReports.Label()
        Me.txt今回御請求額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先郵便番号 = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先住所 = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先名 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl請求明細書 = New DataDynamics.ActiveReports.Label()
        Me.lbl日付 = New DataDynamics.ActiveReports.Label()
        Me.txt住所 = New DataDynamics.ActiveReports.TextBox()
        Me.txt法人 = New DataDynamics.ActiveReports.TextBox()
        Me.txt友好者 = New DataDynamics.ActiveReports.TextBox()
        Me.txtTEL = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox()
        Me.txt今回入金 = New DataDynamics.ActiveReports.TextBox()
        Me.txt今回売上 = New DataDynamics.ActiveReports.TextBox()
        Me.txt前回繰越額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt消費税額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt税込額 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl今回入金 = New DataDynamics.ActiveReports.Label()
        Me.lbl前回繰越額 = New DataDynamics.ActiveReports.Label()
        Me.lbl今回御請求額 = New DataDynamics.ActiveReports.Label()
        Me.lbl消費税額 = New DataDynamics.ActiveReports.Label()
        Me.lbl税込額 = New DataDynamics.ActiveReports.Label()
        Me.txtFAX = New DataDynamics.ActiveReports.TextBox()
        Me.Label7 = New DataDynamics.ActiveReports.Label()
        Me.txt請求年月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt開始請求No = New DataDynamics.ActiveReports.TextBox()
        Me.txt締日 = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先CD = New DataDynamics.ActiveReports.TextBox()
        Me.grpFtr = New DataDynamics.ActiveReports.GroupFooter()
        CType(Me.txt区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt伝票No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt数量, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt日付, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl数量, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl伝票No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl単価, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl前回残高, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt前回残高, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl相殺その他, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt操作その他, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl今回売上, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt今回御請求額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先郵便番号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先住所, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl請求明細書, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl日付, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt住所, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt法人, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt友好者, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt今回入金, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt今回売上, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt前回繰越額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt消費税額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt税込額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl今回入金, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl前回繰越額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl今回御請求額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl消費税額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl税込額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFAX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt請求年月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt開始請求No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt締日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt区分, Me.txt伝票No, Me.txt数量, Me.txt単価, Me.txt金額, Me.txt日付, Me.txt商品名})
        Me.Detail.Height = 0.3346457!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        '
        'txt区分
        '
        Me.txt区分.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt区分.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt区分.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt区分.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt区分.Height = 0.3346457!
        Me.txt区分.Left = 1.141732!
        Me.txt区分.Name = "txt区分"
        Me.txt区分.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt区分.Text = "ああ"
        Me.txt区分.Top = 0.0000007152557!
        Me.txt区分.Width = 0.4133858!
        '
        'txt伝票No
        '
        Me.txt伝票No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt伝票No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt伝票No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt伝票No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt伝票No.Height = 0.3346457!
        Me.txt伝票No.Left = 0.5708662!
        Me.txt伝票No.Name = "txt伝票No"
        Me.txt伝票No.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt伝票No.Text = "123456"
        Me.txt伝票No.Top = 0.0!
        Me.txt伝票No.Width = 0.5708662!
        '
        'txt数量
        '
        Me.txt数量.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt数量.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt数量.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt数量.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt数量.Height = 0.3346457!
        Me.txt数量.Left = 4.311024!
        Me.txt数量.Name = "txt数量"
        Me.txt数量.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt数量.Text = "999,999"
        Me.txt数量.Top = 0.000001221895!
        Me.txt数量.Width = 0.9251968!
        '
        'txt単価
        '
        Me.txt単価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt単価.Height = 0.3346457!
        Me.txt単価.Left = 5.236218!
        Me.txt単価.Name = "txt単価"
        Me.txt単価.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt単価.Text = "999.00"
        Me.txt単価.Top = 0.000001221895!
        Me.txt単価.Width = 0.984252!
        '
        'txt金額
        '
        Me.txt金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt金額.Height = 0.3346457!
        Me.txt金額.Left = 6.22047!
        Me.txt金額.Name = "txt金額"
        Me.txt金額.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt金額.Text = "999,999,999"
        Me.txt金額.Top = 0.0!
        Me.txt金額.Width = 1.062992!
        '
        'txt日付
        '
        Me.txt日付.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt日付.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt日付.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt日付.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt日付.Height = 0.3346457!
        Me.txt日付.Left = 0.0!
        Me.txt日付.Name = "txt日付"
        Me.txt日付.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt日付.Text = "MM/DD"
        Me.txt日付.Top = 0.0!
        Me.txt日付.Width = 0.5708662!
        '
        'txt商品名
        '
        Me.txt商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Height = 0.3346457!
        Me.txt商品名.Left = 1.555117!
        Me.txt商品名.Name = "txt商品名"
        Me.txt商品名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: justify; vertical-align: middle;" & _
    " ddo-char-set: 1"
        Me.txt商品名.Text = "あああああいいいいいううううう"
        Me.txt商品名.Top = 0.0!
        Me.txt商品名.Width = 2.755906!
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
        'grpHdr作業No
        '
        Me.grpHdr作業No.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lbl区分, Me.lbl商品名, Me.lbl数量, Me.lbl金額, Me.lbl伝票No, Me.lbl単価, Me.lbl前回残高, Me.txt前回残高, Me.lbl相殺その他, Me.txt操作その他, Me.lbl今回売上, Me.txt今回御請求額, Me.txt得意先郵便番号, Me.txt得意先住所, Me.txt得意先名, Me.lbl請求明細書, Me.lbl日付, Me.txt住所, Me.txt法人, Me.txt友好者, Me.txtTEL, Me.TextBox2, Me.txt今回入金, Me.txt今回売上, Me.txt前回繰越額, Me.txt消費税額, Me.txt税込額, Me.lbl今回入金, Me.lbl前回繰越額, Me.lbl今回御請求額, Me.lbl消費税額, Me.lbl税込額, Me.txtFAX, Me.Label7, Me.txt請求年月, Me.txt開始請求No, Me.txt締日, Me.txt得意先CD})
        Me.grpHdr作業No.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr作業No.Height = 3.182284!
        Me.grpHdr作業No.Name = "grpHdr作業No"
        Me.grpHdr作業No.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'lbl区分
        '
        Me.lbl区分.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl区分.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl区分.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl区分.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl区分.Height = 0.3346457!
        Me.lbl区分.HyperLink = Nothing
        Me.lbl区分.Left = 1.141732!
        Me.lbl区分.Name = "lbl区分"
        Me.lbl区分.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl区分.Text = "区分"
        Me.lbl区分.Top = 2.847638!
        Me.lbl区分.Width = 0.4133858!
        '
        'lbl商品名
        '
        Me.lbl商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl商品名.Height = 0.3346457!
        Me.lbl商品名.HyperLink = Nothing
        Me.lbl商品名.Left = 1.555118!
        Me.lbl商品名.Name = "lbl商品名"
        Me.lbl商品名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl商品名.Text = "商　　品　　名"
        Me.lbl商品名.Top = 2.847638!
        Me.lbl商品名.Width = 2.755906!
        '
        'lbl数量
        '
        Me.lbl数量.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl数量.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl数量.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl数量.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl数量.Height = 0.3346457!
        Me.lbl数量.HyperLink = Nothing
        Me.lbl数量.Left = 4.311024!
        Me.lbl数量.Name = "lbl数量"
        Me.lbl数量.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl数量.Text = "数　量"
        Me.lbl数量.Top = 2.847638!
        Me.lbl数量.Width = 0.9251968!
        '
        'lbl金額
        '
        Me.lbl金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl金額.Height = 0.3346457!
        Me.lbl金額.HyperLink = Nothing
        Me.lbl金額.Left = 6.220472!
        Me.lbl金額.Name = "lbl金額"
        Me.lbl金額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl金額.Text = "金　額"
        Me.lbl金額.Top = 2.847636!
        Me.lbl金額.Width = 1.062992!
        '
        'lbl伝票No
        '
        Me.lbl伝票No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl伝票No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl伝票No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl伝票No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl伝票No.Height = 0.3346457!
        Me.lbl伝票No.HyperLink = Nothing
        Me.lbl伝票No.Left = 0.5708662!
        Me.lbl伝票No.Name = "lbl伝票No"
        Me.lbl伝票No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl伝票No.Text = "伝票No"
        Me.lbl伝票No.Top = 2.847638!
        Me.lbl伝票No.Width = 0.5708662!
        '
        'lbl単価
        '
        Me.lbl単価.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単価.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単価.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単価.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl単価.Height = 0.3346457!
        Me.lbl単価.HyperLink = Nothing
        Me.lbl単価.Left = 5.23622!
        Me.lbl単価.Name = "lbl単価"
        Me.lbl単価.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl単価.Text = "単　価"
        Me.lbl単価.Top = 2.847638!
        Me.lbl単価.Width = 0.984252!
        '
        'lbl前回残高
        '
        Me.lbl前回残高.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl前回残高.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl前回残高.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl前回残高.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl前回残高.Height = 0.3149606!
        Me.lbl前回残高.HyperLink = Nothing
        Me.lbl前回残高.Left = 0.0!
        Me.lbl前回残高.Name = "lbl前回残高"
        Me.lbl前回残高.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl前回残高.Text = "前回残高"
        Me.lbl前回残高.Top = 1.945669!
        Me.lbl前回残高.Width = 0.9251968!
        '
        'txt前回残高
        '
        Me.txt前回残高.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前回残高.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前回残高.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前回残高.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前回残高.Height = 0.511811!
        Me.txt前回残高.Left = 0.0!
        Me.txt前回残高.Name = "txt前回残高"
        Me.txt前回残高.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt前回残高.Text = "999,999,999"
        Me.txt前回残高.Top = 2.26063!
        Me.txt前回残高.Width = 0.9251968!
        '
        'lbl相殺その他
        '
        Me.lbl相殺その他.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl相殺その他.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl相殺その他.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl相殺その他.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl相殺その他.Height = 0.3149606!
        Me.lbl相殺その他.HyperLink = Nothing
        Me.lbl相殺その他.Left = 1.850393!
        Me.lbl相殺その他.Name = "lbl相殺その他"
        Me.lbl相殺その他.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl相殺その他.Text = "相殺・その他"
        Me.lbl相殺その他.Top = 1.945669!
        Me.lbl相殺その他.Width = 0.8858268!
        '
        'txt操作その他
        '
        Me.txt操作その他.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt操作その他.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt操作その他.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt操作その他.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt操作その他.Height = 0.511811!
        Me.txt操作その他.Left = 1.850393!
        Me.txt操作その他.Name = "txt操作その他"
        Me.txt操作その他.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt操作その他.Text = "999,999,999"
        Me.txt操作その他.Top = 2.260629!
        Me.txt操作その他.Width = 0.8858268!
        '
        'lbl今回売上
        '
        Me.lbl今回売上.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl今回売上.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl今回売上.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl今回売上.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl今回売上.Height = 0.3149606!
        Me.lbl今回売上.HyperLink = Nothing
        Me.lbl今回売上.Left = 3.661417!
        Me.lbl今回売上.Name = "lbl今回売上"
        Me.lbl今回売上.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl今回売上.Text = "今回売上"
        Me.lbl今回売上.Top = 1.945669!
        Me.lbl今回売上.Width = 0.9251968!
        '
        'txt今回御請求額
        '
        Me.txt今回御請求額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt今回御請求額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt今回御請求額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt今回御請求額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt今回御請求額.Height = 0.511811!
        Me.txt今回御請求額.Left = 6.358267!
        Me.txt今回御請求額.Name = "txt今回御請求額"
        Me.txt今回御請求額.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: top; ddo-" & _
    "char-set: 1"
        Me.txt今回御請求額.Text = "　　　999,999,999"
        Me.txt今回御請求額.Top = 2.260629!
        Me.txt今回御請求額.Width = 0.9251968!
        '
        'txt得意先郵便番号
        '
        Me.txt得意先郵便番号.Height = 0.2362205!
        Me.txt得意先郵便番号.Left = 0.0!
        Me.txt得意先郵便番号.Name = "txt得意先郵便番号"
        Me.txt得意先郵便番号.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: bottom; ddo" & _
    "-char-set: 1"
        Me.txt得意先郵便番号.Text = "〒141-8510"
        Me.txt得意先郵便番号.Top = 0.4401575!
        Me.txt得意先郵便番号.Width = 2.559055!
        '
        'txt得意先住所
        '
        Me.txt得意先住所.Height = 0.2362205!
        Me.txt得意先住所.Left = 0.0!
        Me.txt得意先住所.Name = "txt得意先住所"
        Me.txt得意先住所.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: bottom; ddo" & _
    "-char-set: 1"
        Me.txt得意先住所.Text = "東京都品川区西五反田2-11-8"
        Me.txt得意先住所.Top = 0.676378!
        Me.txt得意先住所.Width = 2.559055!
        '
        'txt得意先名
        '
        Me.txt得意先名.Height = 0.2362205!
        Me.txt得意先名.Left = 0.0!
        Me.txt得意先名.Name = "txt得意先名"
        Me.txt得意先名.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: bottom; ddo" & _
    "-char-set: 1"
        Me.txt得意先名.Text = "あああああいいいいいううううう　　　様"
        Me.txt得意先名.Top = 1.233858!
        Me.txt得意先名.Width = 2.559055!
        '
        'lbl請求明細書
        '
        Me.lbl請求明細書.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.lbl請求明細書.CharacterSpacing = 8.0!
        Me.lbl請求明細書.Height = 0.3937007!
        Me.lbl請求明細書.HyperLink = Nothing
        Me.lbl請求明細書.Left = 2.610236!
        Me.lbl請求明細書.Name = "lbl請求明細書"
        Me.lbl請求明細書.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 16pt; font-weight: bold; text-align:" & _
    " center; vertical-align: middle; ddo-char-set: 1"
        Me.lbl請求明細書.Text = "請求明細書"
        Me.lbl請求明細書.Top = 0.0!
        Me.lbl請求明細書.Width = 2.012599!
        '
        'lbl日付
        '
        Me.lbl日付.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl日付.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl日付.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl日付.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl日付.Height = 0.3346457!
        Me.lbl日付.HyperLink = Nothing
        Me.lbl日付.Left = 0.0!
        Me.lbl日付.Name = "lbl日付"
        Me.lbl日付.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl日付.Text = "日付"
        Me.lbl日付.Top = 2.847638!
        Me.lbl日付.Width = 0.5708662!
        '
        'txt住所
        '
        Me.txt住所.Height = 0.1968504!
        Me.txt住所.Left = 4.846063!
        Me.txt住所.Name = "txt住所"
        Me.txt住所.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: bottom; ddo" & _
    "-char-set: 1"
        Me.txt住所.Text = " 〒117-0032　東京都練馬区谷原3-24-1"
        Me.txt住所.Top = 0.8165355!
        Me.txt住所.Width = 2.401575!
        '
        'txt法人
        '
        Me.txt法人.CharacterSpacing = 1.0!
        Me.txt法人.Height = 0.4330709!
        Me.txt法人.Left = 4.846063!
        Me.txt法人.Name = "txt法人"
        Me.txt法人.Style = "font-family: ＭＳ 明朝; font-size: 12pt; text-align: justify; vertical-align: middle;" & _
    " ddo-char-set: 1"
        Me.txt法人.Text = "株式会社"
        Me.txt法人.Top = 0.3834646!
        Me.txt法人.Width = 0.9055118!
        '
        'txt友好者
        '
        Me.txt友好者.CharacterSpacing = 15.0!
        Me.txt友好者.Height = 0.4330709!
        Me.txt友好者.Left = 5.751182!
        Me.txt友好者.Name = "txt友好者"
        Me.txt友好者.Style = "font-family: ＭＳ 明朝; font-size: 18pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt友好者.Text = "友功社"
        Me.txt友好者.Top = 0.3834646!
        Me.txt友好者.Width = 1.342914!
        '
        'txtTEL
        '
        Me.txtTEL.Height = 0.1968504!
        Me.txtTEL.Left = 4.846063!
        Me.txtTEL.Name = "txtTEL"
        Me.txtTEL.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: justify; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txtTEL.Text = "    TEL　０３-３９９６-５３３３ (代)"
        Me.txtTEL.Top = 1.013386!
        Me.txtTEL.Width = 2.401575!
        '
        'TextBox2
        '
        Me.TextBox2.Height = 0.1968504!
        Me.TextBox2.Left = 4.846063!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: bottom; ddo" & _
    "-char-set: 1"
        Me.TextBox2.Text = "ラベル・シール・ステッカー特殊印刷"
        Me.TextBox2.Top = 0.1866142!
        Me.TextBox2.Width = 2.424016!
        '
        'txt今回入金
        '
        Me.txt今回入金.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt今回入金.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt今回入金.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt今回入金.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt今回入金.Height = 0.511811!
        Me.txt今回入金.Left = 0.9251968!
        Me.txt今回入金.Name = "txt今回入金"
        Me.txt今回入金.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt今回入金.Text = "999,999,999"
        Me.txt今回入金.Top = 2.260629!
        Me.txt今回入金.Width = 0.9251965!
        '
        'txt今回売上
        '
        Me.txt今回売上.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt今回売上.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt今回売上.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt今回売上.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt今回売上.Height = 0.511811!
        Me.txt今回売上.Left = 3.661417!
        Me.txt今回売上.Name = "txt今回売上"
        Me.txt今回売上.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: justify; vertical-align: top; dd" & _
    "o-char-set: 1"
        Me.txt今回売上.Text = "　　　999,999,999"
        Me.txt今回売上.Top = 2.260629!
        Me.txt今回売上.Width = 0.9251965!
        '
        'txt前回繰越額
        '
        Me.txt前回繰越額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前回繰越額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前回繰越額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前回繰越額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前回繰越額.Height = 0.511811!
        Me.txt前回繰越額.Left = 2.73622!
        Me.txt前回繰越額.Name = "txt前回繰越額"
        Me.txt前回繰越額.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt前回繰越額.Text = "999,999,999"
        Me.txt前回繰越額.Top = 2.260629!
        Me.txt前回繰越額.Width = 0.9251965!
        '
        'txt消費税額
        '
        Me.txt消費税額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税額.Height = 0.511811!
        Me.txt消費税額.Left = 4.586613!
        Me.txt消費税額.Name = "txt消費税額"
        Me.txt消費税額.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt消費税額.Text = "999,999,999"
        Me.txt消費税額.Top = 2.260629!
        Me.txt消費税額.Width = 0.8858271!
        '
        'txt税込額
        '
        Me.txt税込額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税込額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税込額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税込額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税込額.Height = 0.511811!
        Me.txt税込額.Left = 5.47244!
        Me.txt税込額.Name = "txt税込額"
        Me.txt税込額.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: top; ddo-" & _
    "char-set: 1"
        Me.txt税込額.Text = "　　　999,999,999"
        Me.txt税込額.Top = 2.260629!
        Me.txt税込額.Width = 0.8858271!
        '
        'lbl今回入金
        '
        Me.lbl今回入金.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl今回入金.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl今回入金.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl今回入金.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl今回入金.Height = 0.3149606!
        Me.lbl今回入金.HyperLink = Nothing
        Me.lbl今回入金.Left = 0.9251968!
        Me.lbl今回入金.Name = "lbl今回入金"
        Me.lbl今回入金.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl今回入金.Text = "今回入金"
        Me.lbl今回入金.Top = 1.945669!
        Me.lbl今回入金.Width = 0.9251965!
        '
        'lbl前回繰越額
        '
        Me.lbl前回繰越額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl前回繰越額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl前回繰越額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl前回繰越額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl前回繰越額.Height = 0.3149606!
        Me.lbl前回繰越額.HyperLink = Nothing
        Me.lbl前回繰越額.Left = 2.73622!
        Me.lbl前回繰越額.Name = "lbl前回繰越額"
        Me.lbl前回繰越額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl前回繰越額.Text = "前回繰越額"
        Me.lbl前回繰越額.Top = 1.945669!
        Me.lbl前回繰越額.Width = 0.9251965!
        '
        'lbl今回御請求額
        '
        Me.lbl今回御請求額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl今回御請求額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl今回御請求額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl今回御請求額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl今回御請求額.Height = 0.3149606!
        Me.lbl今回御請求額.HyperLink = Nothing
        Me.lbl今回御請求額.Left = 6.358267!
        Me.lbl今回御請求額.Name = "lbl今回御請求額"
        Me.lbl今回御請求額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl今回御請求額.Text = "今回御請求額"
        Me.lbl今回御請求額.Top = 1.945669!
        Me.lbl今回御請求額.Width = 0.9251965!
        '
        'lbl消費税額
        '
        Me.lbl消費税額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl消費税額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl消費税額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl消費税額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl消費税額.Height = 0.3149606!
        Me.lbl消費税額.HyperLink = Nothing
        Me.lbl消費税額.Left = 4.586613!
        Me.lbl消費税額.Name = "lbl消費税額"
        Me.lbl消費税額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl消費税額.Text = "消費税額"
        Me.lbl消費税額.Top = 1.945669!
        Me.lbl消費税額.Width = 0.8858271!
        '
        'lbl税込額
        '
        Me.lbl税込額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl税込額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl税込額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl税込額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl税込額.Height = 0.3149606!
        Me.lbl税込額.HyperLink = Nothing
        Me.lbl税込額.Left = 5.47244!
        Me.lbl税込額.Name = "lbl税込額"
        Me.lbl税込額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl税込額.Text = "税込額"
        Me.lbl税込額.Top = 1.945669!
        Me.lbl税込額.Width = 0.8858271!
        '
        'txtFAX
        '
        Me.txtFAX.Height = 0.1968504!
        Me.txtFAX.Left = 4.846063!
        Me.txtFAX.Name = "txtFAX"
        Me.txtFAX.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: middle; ddo" & _
    "-char-set: 1"
        Me.txtFAX.Text = "    Fax　０３-３９９６-４３３３"
        Me.txtFAX.Top = 1.210236!
        Me.txtFAX.Width = 2.401575!
        '
        'Label7
        '
        Me.Label7.Height = 0.472441!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 4.856299!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 7.5pt; text-align: left; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.Label7.Text = "＊銀行お振込みの節は下記へお願い申しあげます。" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "UFJ銀行　練馬光が丘支店　当座No.211902"
        Me.Label7.Top = 1.425197!
        Me.Label7.Width = 2.438977!
        '
        'txt請求年月
        '
        Me.txt請求年月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt請求年月.Height = 0.3149606!
        Me.txt請求年月.Left = 2.743307!
        Me.txt請求年月.Name = "txt請求年月"
        Me.txt請求年月.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt請求年月.Text = "YY年MM月DD日"
        Me.txt請求年月.Top = 0.6472442!
        Me.txt請求年月.Width = 1.771654!
        '
        'txt開始請求No
        '
        Me.txt開始請求No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt開始請求No.Height = 0.3149606!
        Me.txt開始請求No.Left = 2.743307!
        Me.txt開始請求No.Name = "txt開始請求No"
        Me.txt開始請求No.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt開始請求No.Text = "No. 123456-00"
        Me.txt開始請求No.Top = 0.9929135!
        Me.txt開始請求No.Width = 1.771654!
        '
        'txt締日
        '
        Me.txt締日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt締日.Height = 0.3149606!
        Me.txt締日.Left = 2.743307!
        Me.txt締日.Name = "txt締日"
        Me.txt締日.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt締日.Text = "締日　　99日"
        Me.txt締日.Top = 1.31811!
        Me.txt締日.Width = 1.771654!
        '
        'txt得意先CD
        '
        Me.txt得意先CD.Height = 0.2362205!
        Me.txt得意先CD.Left = 2.743307!
        Me.txt得意先CD.Name = "txt得意先CD"
        Me.txt得意先CD.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt得意先CD.Text = "(123456)"
        Me.txt得意先CD.Top = 1.666142!
        Me.txt得意先CD.Width = 1.771653!
        '
        'grpFtr
        '
        Me.grpFtr.Height = 0.0!
        Me.grpFtr.Name = "grpFtr"
        '
        'BillStatement
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.30315!
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
        CType(Me.txt区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt伝票No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt数量, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt日付, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl数量, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl伝票No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl単価, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl前回残高, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt前回残高, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl相殺その他, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt操作その他, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl今回売上, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt今回御請求額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先郵便番号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先住所, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl請求明細書, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl日付, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt住所, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt法人, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt友好者, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt今回入金, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt今回売上, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt前回繰越額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt消費税額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt税込額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl今回入金, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl前回繰越額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl今回御請求額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl消費税額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl税込額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFAX, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt請求年月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt開始請求No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt締日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先CD, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txt区分 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt伝票No As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt数量 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt単価 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt日付 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpHdr作業No As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents lbl区分 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl商品名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl数量 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl金額 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl伝票No As DataDynamics.ActiveReports.Label
    Private WithEvents lbl単価 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl前回残高 As DataDynamics.ActiveReports.Label
    Private WithEvents txt前回残高 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl相殺その他 As DataDynamics.ActiveReports.Label
    Private WithEvents txt操作その他 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl今回売上 As DataDynamics.ActiveReports.Label
    Private WithEvents txt今回御請求額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意先郵便番号 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意先住所 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl請求明細書 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl日付 As DataDynamics.ActiveReports.Label
    Private WithEvents grpFtr As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txt住所 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt法人 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt友好者 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtTEL As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt今回入金 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt今回売上 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt前回繰越額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt消費税額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt税込額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl今回入金 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl前回繰越額 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl今回御請求額 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl消費税額 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl税込額 As DataDynamics.ActiveReports.Label
    Private WithEvents txtFAX As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label7 As DataDynamics.ActiveReports.Label
    Private WithEvents txt請求年月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt開始請求No As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt締日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意先CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt商品名 As DataDynamics.ActiveReports.TextBox
End Class
