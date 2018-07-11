<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class TaxStatement
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(TaxStatement))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr作業No = New DataDynamics.ActiveReports.GroupHeader()
        Me.txt締日 = New DataDynamics.ActiveReports.TextBox()
        Me.txt請求先 = New DataDynamics.ActiveReports.TextBox()
        Me.txt請求日 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl旧税率分税抜売上額 = New DataDynamics.ActiveReports.Label()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.lbl旧税率分税抜売上日 = New DataDynamics.ActiveReports.Label()
        Me.txt旧税率分税抜売上額 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl新税率分税抜売上額 = New DataDynamics.ActiveReports.Label()
        Me.lbl新税率分税抜売上日 = New DataDynamics.ActiveReports.Label()
        Me.txt新税率分税抜売上額 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl税抜売上合計額 = New DataDynamics.ActiveReports.Label()
        Me.txt税抜売上合計額 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl旧税率消費税額 = New DataDynamics.ActiveReports.Label()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.txt旧税率消費税額 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl新税率消費税額 = New DataDynamics.ActiveReports.Label()
        Me.Label5 = New DataDynamics.ActiveReports.Label()
        Me.txt新税率消費税額 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl消費税合計額 = New DataDynamics.ActiveReports.Label()
        Me.txt消費税合計額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt郵便番号 = New DataDynamics.ActiveReports.TextBox()
        Me.txt会社名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt住所 = New DataDynamics.ActiveReports.TextBox()
        Me.txtTEL = New DataDynamics.ActiveReports.TextBox()
        Me.txt法人 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl消費税計算書 = New DataDynamics.ActiveReports.Label()
        Me.ｌｂｌ管理No = New DataDynamics.ActiveReports.Label()
        Me.txt管理No = New DataDynamics.ActiveReports.TextBox()
        Me.txtFAX = New DataDynamics.ActiveReports.TextBox()
        Me.grpFtr = New DataDynamics.ActiveReports.GroupFooter()
        CType(Me.txt締日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt請求先, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt請求日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl旧税率分税抜売上額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl旧税率分税抜売上日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt旧税率分税抜売上額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl新税率分税抜売上額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl新税率分税抜売上日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt新税率分税抜売上額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl税抜売上合計額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt税抜売上合計額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl旧税率消費税額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt旧税率消費税額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl新税率消費税額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt新税率消費税額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl消費税合計額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt消費税合計額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt郵便番号, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt会社名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt住所, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTEL, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt法人, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl消費税計算書, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ｌｂｌ管理No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt管理No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtFAX, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Height = 0.0!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
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
        Me.grpHdr作業No.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt締日, Me.txt請求先, Me.txt請求日, Me.lbl旧税率分税抜売上額, Me.Label1, Me.lbl旧税率分税抜売上日, Me.txt旧税率分税抜売上額, Me.lbl新税率分税抜売上額, Me.lbl新税率分税抜売上日, Me.txt新税率分税抜売上額, Me.lbl税抜売上合計額, Me.txt税抜売上合計額, Me.lbl旧税率消費税額, Me.Label3, Me.txt旧税率消費税額, Me.lbl新税率消費税額, Me.Label5, Me.txt新税率消費税額, Me.lbl消費税合計額, Me.txt消費税合計額, Me.txt郵便番号, Me.txt会社名, Me.txt住所, Me.txtTEL, Me.txt法人, Me.lbl消費税計算書, Me.ｌｂｌ管理No, Me.txt管理No, Me.txtFAX})
        Me.grpHdr作業No.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr作業No.Height = 6.676099!
        Me.grpHdr作業No.Name = "grpHdr作業No"
        Me.grpHdr作業No.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'txt締日
        '
        Me.txt締日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt締日.Height = 0.3937008!
        Me.txt締日.Left = 5.330709!
        Me.txt締日.Name = "txt締日"
        Me.txt締日.Style = "font-family: ＭＳ 明朝; font-size: 14pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt締日.Text = "締日　99日"
        Me.txt締日.Top = 1.288189!
        Me.txt締日.Width = 1.102362!
        '
        'txt請求先
        '
        Me.txt請求先.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt請求先.Height = 0.3937008!
        Me.txt請求先.Left = 0.0!
        Me.txt請求先.Name = "txt請求先"
        Me.txt請求先.Style = "font-family: ＭＳ 明朝; font-size: 12pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt請求先.Text = "あああああいいいいいううううう　　　御中"
        Me.txt請求先.Top = 0.7472441!
        Me.txt請求先.Width = 3.543307!
        '
        'txt請求日
        '
        Me.txt請求日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.txt請求日.Height = 0.3937008!
        Me.txt請求日.Left = 1.823622!
        Me.txt請求日.Name = "txt請求日"
        Me.txt請求日.Style = "font-family: ＭＳ 明朝; font-size: 12pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt請求日.Text = "御請求日  9999年99月99日"
        Me.txt請求日.Top = 1.442127!
        Me.txt請求日.Width = 2.519685!
        '
        'lbl旧税率分税抜売上額
        '
        Me.lbl旧税率分税抜売上額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl旧税率分税抜売上額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl旧税率分税抜売上額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl旧税率分税抜売上額.Height = 0.2755905!
        Me.lbl旧税率分税抜売上額.HyperLink = Nothing
        Me.lbl旧税率分税抜売上額.Left = 0.0!
        Me.lbl旧税率分税抜売上額.Name = "lbl旧税率分税抜売上額"
        Me.lbl旧税率分税抜売上額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl旧税率分税抜売上額.Text = "①旧税率分税抜売上額"
        Me.lbl旧税率分税抜売上額.Top = 2.364964!
        Me.lbl旧税率分税抜売上額.Width = 2.401575!
        '
        'Label1
        '
        Me.Label1.Height = 0.2362205!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.0!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "color: Black; font-family: ＭＳ ゴシック; font-size: 9pt; font-weight: bold; text-align" & _
    ": justify; vertical-align: bottom; ddo-char-set: 1"
        Me.Label1.Text = "※消費税額は下記の通りに算出いたしましたので、ご査収下さいますようお願い申し上げます。"
        Me.Label1.Top = 1.976773!
        Me.Label1.Width = 5.905512!
        '
        'lbl旧税率分税抜売上日
        '
        Me.lbl旧税率分税抜売上日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl旧税率分税抜売上日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl旧税率分税抜売上日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl旧税率分税抜売上日.Height = 0.1968504!
        Me.lbl旧税率分税抜売上日.HyperLink = Nothing
        Me.lbl旧税率分税抜売上日.Left = 0.0!
        Me.lbl旧税率分税抜売上日.Name = "lbl旧税率分税抜売上日"
        Me.lbl旧税率分税抜売上日.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl旧税率分税抜売上日.Text = "(99/99～99/99)"
        Me.lbl旧税率分税抜売上日.Top = 2.640554!
        Me.lbl旧税率分税抜売上日.Width = 2.401575!
        '
        'txt旧税率分税抜売上額
        '
        Me.txt旧税率分税抜売上額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt旧税率分税抜売上額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt旧税率分税抜売上額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt旧税率分税抜売上額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt旧税率分税抜売上額.Height = 0.511811!
        Me.txt旧税率分税抜売上額.Left = 0.0!
        Me.txt旧税率分税抜売上額.Name = "txt旧税率分税抜売上額"
        Me.txt旧税率分税抜売上額.Style = "font-family: ＭＳ 明朝; font-size: 14pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt旧税率分税抜売上額.Text = "　　　999,999"
        Me.txt旧税率分税抜売上額.Top = 2.837405!
        Me.txt旧税率分税抜売上額.Width = 2.401575!
        '
        'lbl新税率分税抜売上額
        '
        Me.lbl新税率分税抜売上額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl新税率分税抜売上額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl新税率分税抜売上額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl新税率分税抜売上額.Height = 0.2755906!
        Me.lbl新税率分税抜売上額.HyperLink = Nothing
        Me.lbl新税率分税抜売上額.Left = 2.407087!
        Me.lbl新税率分税抜売上額.Name = "lbl新税率分税抜売上額"
        Me.lbl新税率分税抜売上額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl新税率分税抜売上額.Text = "②新税率分税抜売上額"
        Me.lbl新税率分税抜売上額.Top = 2.364964!
        Me.lbl新税率分税抜売上額.Width = 2.401575!
        '
        'lbl新税率分税抜売上日
        '
        Me.lbl新税率分税抜売上日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl新税率分税抜売上日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl新税率分税抜売上日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl新税率分税抜売上日.Height = 0.1968504!
        Me.lbl新税率分税抜売上日.HyperLink = Nothing
        Me.lbl新税率分税抜売上日.Left = 2.407087!
        Me.lbl新税率分税抜売上日.Name = "lbl新税率分税抜売上日"
        Me.lbl新税率分税抜売上日.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl新税率分税抜売上日.Text = "(99/99～99/99)"
        Me.lbl新税率分税抜売上日.Top = 2.640554!
        Me.lbl新税率分税抜売上日.Width = 2.401575!
        '
        'txt新税率分税抜売上額
        '
        Me.txt新税率分税抜売上額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt新税率分税抜売上額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt新税率分税抜売上額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt新税率分税抜売上額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt新税率分税抜売上額.Height = 0.511811!
        Me.txt新税率分税抜売上額.Left = 2.407087!
        Me.txt新税率分税抜売上額.Name = "txt新税率分税抜売上額"
        Me.txt新税率分税抜売上額.Style = "font-family: ＭＳ 明朝; font-size: 14pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt新税率分税抜売上額.Text = "　　　999,999"
        Me.txt新税率分税抜売上額.Top = 2.837405!
        Me.txt新税率分税抜売上額.Width = 2.401575!
        '
        'lbl税抜売上合計額
        '
        Me.lbl税抜売上合計額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl税抜売上合計額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl税抜売上合計額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl税抜売上合計額.Height = 0.472441!
        Me.lbl税抜売上合計額.HyperLink = Nothing
        Me.lbl税抜売上合計額.Left = 4.808661!
        Me.lbl税抜売上合計額.Name = "lbl税抜売上合計額"
        Me.lbl税抜売上合計額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl税抜売上合計額.Text = "③税抜売上合計額(①+②)"
        Me.lbl税抜売上合計額.Top = 2.364964!
        Me.lbl税抜売上合計額.Width = 2.480315!
        '
        'txt税抜売上合計額
        '
        Me.txt税抜売上合計額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税抜売上合計額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税抜売上合計額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税抜売上合計額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt税抜売上合計額.Height = 0.511811!
        Me.txt税抜売上合計額.Left = 4.808662!
        Me.txt税抜売上合計額.Name = "txt税抜売上合計額"
        Me.txt税抜売上合計額.Style = "font-family: ＭＳ 明朝; font-size: 14pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt税抜売上合計額.Text = "　　　999,999"
        Me.txt税抜売上合計額.Top = 2.837405!
        Me.txt税抜売上合計額.Width = 2.480315!
        '
        'lbl旧税率消費税額
        '
        Me.lbl旧税率消費税額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl旧税率消費税額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl旧税率消費税額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl旧税率消費税額.Height = 0.2755906!
        Me.lbl旧税率消費税額.HyperLink = Nothing
        Me.lbl旧税率消費税額.Left = 0.0!
        Me.lbl旧税率消費税額.Name = "lbl旧税率消費税額"
        Me.lbl旧税率消費税額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl旧税率消費税額.Text = "④旧税率消費税額"
        Me.lbl旧税率消費税額.Top = 3.653941!
        Me.lbl旧税率消費税額.Width = 2.401575!
        '
        'Label3
        '
        Me.Label3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Height = 0.1968504!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 0.0!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.Label3.Text = "(①×5%)"
        Me.Label3.Top = 3.929531!
        Me.Label3.Width = 2.401575!
        '
        'txt旧税率消費税額
        '
        Me.txt旧税率消費税額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt旧税率消費税額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt旧税率消費税額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt旧税率消費税額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt旧税率消費税額.Height = 0.511811!
        Me.txt旧税率消費税額.Left = 0.0!
        Me.txt旧税率消費税額.Name = "txt旧税率消費税額"
        Me.txt旧税率消費税額.Style = "font-family: ＭＳ 明朝; font-size: 14pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt旧税率消費税額.Text = "　　　999,999"
        Me.txt旧税率消費税額.Top = 4.126381!
        Me.txt旧税率消費税額.Width = 2.401575!
        '
        'lbl新税率消費税額
        '
        Me.lbl新税率消費税額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl新税率消費税額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl新税率消費税額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl新税率消費税額.Height = 0.2755906!
        Me.lbl新税率消費税額.HyperLink = Nothing
        Me.lbl新税率消費税額.Left = 2.407087!
        Me.lbl新税率消費税額.Name = "lbl新税率消費税額"
        Me.lbl新税率消費税額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl新税率消費税額.Text = "⑤新税率消費税額"
        Me.lbl新税率消費税額.Top = 3.653941!
        Me.lbl新税率消費税額.Width = 2.401575!
        '
        'Label5
        '
        Me.Label5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label5.Height = 0.1968504!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 2.407087!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.Label5.Text = "(②×8%)"
        Me.Label5.Top = 3.929531!
        Me.Label5.Width = 2.401575!
        '
        'txt新税率消費税額
        '
        Me.txt新税率消費税額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt新税率消費税額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt新税率消費税額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt新税率消費税額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt新税率消費税額.Height = 0.511811!
        Me.txt新税率消費税額.Left = 2.407087!
        Me.txt新税率消費税額.Name = "txt新税率消費税額"
        Me.txt新税率消費税額.Style = "font-family: ＭＳ 明朝; font-size: 14pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt新税率消費税額.Text = "　　　999,999"
        Me.txt新税率消費税額.Top = 4.126381!
        Me.txt新税率消費税額.Width = 2.401575!
        '
        'lbl消費税合計額
        '
        Me.lbl消費税合計額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl消費税合計額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl消費税合計額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl消費税合計額.Height = 0.472441!
        Me.lbl消費税合計額.HyperLink = Nothing
        Me.lbl消費税合計額.Left = 4.808662!
        Me.lbl消費税合計額.Name = "lbl消費税合計額"
        Me.lbl消費税合計額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl消費税合計額.Text = "⑥消費税合計額(④+⑤)"
        Me.lbl消費税合計額.Top = 3.653941!
        Me.lbl消費税合計額.Width = 2.480315!
        '
        'txt消費税合計額
        '
        Me.txt消費税合計額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税合計額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税合計額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税合計額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt消費税合計額.Height = 0.511811!
        Me.txt消費税合計額.Left = 4.808662!
        Me.txt消費税合計額.Name = "txt消費税合計額"
        Me.txt消費税合計額.Style = "font-family: ＭＳ 明朝; font-size: 14pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt消費税合計額.Text = "　　　999,999"
        Me.txt消費税合計額.Top = 4.126381!
        Me.txt消費税合計額.Width = 2.480315!
        '
        'txt郵便番号
        '
        Me.txt郵便番号.Height = 0.1968504!
        Me.txt郵便番号.Left = 3.888977!
        Me.txt郵便番号.Name = "txt郵便番号"
        Me.txt郵便番号.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt郵便番号.Text = "〒177-0032"
        Me.txt郵便番号.Top = 5.362602!
        Me.txt郵便番号.Width = 3.149606!
        '
        'txt会社名
        '
        Me.txt会社名.CharacterSpacing = 25.0!
        Me.txt会社名.Height = 0.4330709!
        Me.txt会社名.Left = 4.816536!
        Me.txt会社名.Name = "txt会社名"
        Me.txt会社名.Style = "font-family: ＭＳ 明朝; font-size: 20pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt会社名.Text = "友功社"
        Me.txt会社名.Top = 5.756302!
        Me.txt会社名.Width = 2.15748!
        '
        'txt住所
        '
        Me.txt住所.CharacterSpacing = 3.0!
        Me.txt住所.Height = 0.1968504!
        Me.txt住所.Left = 3.888977!
        Me.txt住所.Name = "txt住所"
        Me.txt住所.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt住所.Text = "東京都練馬区谷原３－２４－１"
        Me.txt住所.Top = 5.559449!
        Me.txt住所.Width = 3.149606!
        '
        'txtTEL
        '
        Me.txtTEL.Height = 0.3346457!
        Me.txtTEL.Left = 3.888977!
        Me.txtTEL.Name = "txtTEL"
        Me.txtTEL.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: justify; vertical-align: middle;" & _
    " ddo-char-set: 1"
        Me.txtTEL.Text = "TEL   (3996) 5333"
        Me.txtTEL.Top = 6.189371!
        Me.txtTEL.Width = 1.574803!
        '
        'txt法人
        '
        Me.txt法人.CharacterSpacing = 5.0!
        Me.txt法人.Height = 0.4330709!
        Me.txt法人.Left = 3.919685!
        Me.txt法人.Name = "txt法人"
        Me.txt法人.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt法人.Text = "株式会社"
        Me.txt法人.Top = 5.756302!
        Me.txt法人.Width = 0.8661417!
        '
        'lbl消費税計算書
        '
        Me.lbl消費税計算書.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.ThickSolid
        Me.lbl消費税計算書.CharacterSpacing = 5.0!
        Me.lbl消費税計算書.Height = 0.3937007!
        Me.lbl消費税計算書.HyperLink = Nothing
        Me.lbl消費税計算書.Left = 2.211024!
        Me.lbl消費税計算書.Name = "lbl消費税計算書"
        Me.lbl消費税計算書.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 18pt; font-weight: bold; text-align:" & _
    " center; vertical-align: middle; ddo-char-set: 1"
        Me.lbl消費税計算書.Text = "消費税計算書"
        Me.lbl消費税計算書.Top = 0.0!
        Me.lbl消費税計算書.Width = 2.834646!
        '
        'ｌｂｌ管理No
        '
        Me.ｌｂｌ管理No.Height = 0.2362205!
        Me.ｌｂｌ管理No.HyperLink = Nothing
        Me.ｌｂｌ管理No.Left = 5.038599!
        Me.ｌｂｌ管理No.Name = "ｌｂｌ管理No"
        Me.ｌｂｌ管理No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: bottom; ddo-char-set: 1"
        Me.ｌｂｌ管理No.Text = "管理No."
        Me.ｌｂｌ管理No.Top = 0.4874016!
        Me.ｌｂｌ管理No.Width = 1.202362!
        '
        'txt管理No
        '
        Me.txt管理No.Height = 0.2362205!
        Me.txt管理No.Left = 6.240961!
        Me.txt管理No.Name = "txt管理No"
        Me.txt管理No.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt管理No.Text = "123456"
        Me.txt管理No.Top = 0.4874016!
        Me.txt管理No.Width = 0.9842521!
        '
        'txtFAX
        '
        Me.txtFAX.Height = 0.3346457!
        Me.txtFAX.Left = 5.463779!
        Me.txtFAX.Name = "txtFAX"
        Me.txtFAX.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: justify; vertical-align: middle;" & _
    " ddo-char-set: 1"
        Me.txtFAX.Text = "Fax　　(3996)4333"
        Me.txtFAX.Top = 6.189371!
        Me.txtFAX.Width = 1.574803!
        '
        'grpFtr
        '
        Me.grpFtr.Height = 0.0!
        Me.grpFtr.Name = "grpFtr"
        '
        'TaxStatement
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
        CType(Me.txt締日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt請求先, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt請求日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl旧税率分税抜売上額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl旧税率分税抜売上日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt旧税率分税抜売上額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl新税率分税抜売上額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl新税率分税抜売上日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt新税率分税抜売上額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl税抜売上合計額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt税抜売上合計額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl旧税率消費税額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt旧税率消費税額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl新税率消費税額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt新税率消費税額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl消費税合計額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt消費税合計額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt郵便番号, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt会社名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt住所, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTEL, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt法人, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl消費税計算書, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ｌｂｌ管理No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt管理No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtFAX, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents grpFtr As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txt請求先 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt請求日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl旧税率分税抜売上額 As DataDynamics.ActiveReports.Label
    Private WithEvents txt締日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl旧税率分税抜売上日 As DataDynamics.ActiveReports.Label
    Private WithEvents txt旧税率分税抜売上額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl新税率分税抜売上額 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl新税率分税抜売上日 As DataDynamics.ActiveReports.Label
    Private WithEvents txt新税率分税抜売上額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl税抜売上合計額 As DataDynamics.ActiveReports.Label
    Private WithEvents txt税抜売上合計額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl旧税率消費税額 As DataDynamics.ActiveReports.Label
    Private WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents txt旧税率消費税額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl新税率消費税額 As DataDynamics.ActiveReports.Label
    Private WithEvents Label5 As DataDynamics.ActiveReports.Label
    Private WithEvents txt新税率消費税額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl消費税合計額 As DataDynamics.ActiveReports.Label
    Private WithEvents txt消費税合計額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt郵便番号 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt会社名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt住所 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtTEL As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt法人 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl消費税計算書 As DataDynamics.ActiveReports.Label
    Private WithEvents ｌｂｌ管理No As DataDynamics.ActiveReports.Label
    Private WithEvents txt管理No As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtFAX As DataDynamics.ActiveReports.TextBox
End Class
