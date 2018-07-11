<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class ShipSchedule
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(ShipSchedule))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt得意先CD = New DataDynamics.ActiveReports.TextBox()
        Me.txt定番CD = New DataDynamics.ActiveReports.TextBox()
        Me.txt作業No = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt商品名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt発送日 = New DataDynamics.ActiveReports.TextBox()
        Me.txt運送会社名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt出荷数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt備考 = New DataDynamics.ActiveReports.TextBox()
        Me.txt出荷先名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt売上No = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.txtNow = New DataDynamics.ActiveReports.TextBox()
        Me.txt頁 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr得意先CD = New DataDynamics.ActiveReports.GroupHeader()
        Me.txtHdr発送日 = New DataDynamics.ActiveReports.TextBox()
        Me.txt出荷予定表 = New DataDynamics.ActiveReports.TextBox()
        Me.txt場所区分 = New DataDynamics.ActiveReports.TextBox()
        Me.txt定番品区分 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl得意先CD = New DataDynamics.ActiveReports.Label()
        Me.lbl定番CD = New DataDynamics.ActiveReports.Label()
        Me.lbl作業No = New DataDynamics.ActiveReports.Label()
        Me.lbl得意先名 = New DataDynamics.ActiveReports.Label()
        Me.ｌｂｌ商品名 = New DataDynamics.ActiveReports.Label()
        Me.lbl出荷数 = New DataDynamics.ActiveReports.Label()
        Me.lbl運送会社 = New DataDynamics.ActiveReports.Label()
        Me.lbl発送日 = New DataDynamics.ActiveReports.Label()
        Me.lbl備考 = New DataDynamics.ActiveReports.Label()
        Me.lblHdr発送日 = New DataDynamics.ActiveReports.Label()
        Me.lbl出荷先名 = New DataDynamics.ActiveReports.Label()
        Me.lbl売上No = New DataDynamics.ActiveReports.Label()
        Me.grpFtr総合計 = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox()
        Me.txt発送日計 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox8 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl発送日計 = New DataDynamics.ActiveReports.Label()
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox10 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.txt得意先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt定番CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt作業No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt発送日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt運送会社名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt出荷数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt備考, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt出荷先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt売上No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr発送日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt出荷予定表, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt場所区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt定番品区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl得意先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl定番CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl作業No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ｌｂｌ商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl出荷数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl運送会社, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl発送日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl備考, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr発送日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl出荷先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl売上No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt発送日計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl発送日計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt得意先CD, Me.txt定番CD, Me.txt作業No, Me.txt得意先名, Me.txt商品名, Me.txt発送日, Me.txt運送会社名, Me.txt出荷数, Me.txt備考, Me.txt出荷先名, Me.txt売上No})
        Me.Detail.Height = 0.2755905!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.RepeatToFill = True
        '
        'txt得意先CD
        '
        Me.txt得意先CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先CD.Height = 0.2755905!
        Me.txt得意先CD.Left = 0.0!
        Me.txt得意先CD.Name = "txt得意先CD"
        Me.txt得意先CD.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: left; vertical-align: bottom; ddo" & _
    "-char-set: 1"
        Me.txt得意先CD.Text = "123456"
        Me.txt得意先CD.Top = 0.0!
        Me.txt得意先CD.Width = 0.3937008!
        '
        'txt定番CD
        '
        Me.txt定番CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt定番CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt定番CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt定番CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt定番CD.Height = 0.2755905!
        Me.txt定番CD.Left = 5.846457!
        Me.txt定番CD.Name = "txt定番CD"
        Me.txt定番CD.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt定番CD.Text = "12345"
        Me.txt定番CD.Top = 0.000001132488!
        Me.txt定番CD.Width = 0.5905512!
        '
        'txt作業No
        '
        Me.txt作業No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt作業No.Height = 0.2755905!
        Me.txt作業No.Left = 5.433071!
        Me.txt作業No.Name = "txt作業No"
        Me.txt作業No.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt作業No.Text = "123456"
        Me.txt作業No.Top = 0.000001490116!
        Me.txt作業No.Width = 0.4133858!
        '
        'txt得意先名
        '
        Me.txt得意先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Height = 0.2755905!
        Me.txt得意先名.Left = 0.3937008!
        Me.txt得意先名.Name = "txt得意先名"
        Me.txt得意先名.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: middle; ddo" & _
    "-char-set: 1"
        Me.txt得意先名.Text = "あああああいいいいいううううう"
        Me.txt得意先名.Top = 0.0000001788139!
        Me.txt得意先名.Width = 2.106299!
        '
        'txt商品名
        '
        Me.txt商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Height = 0.2755905!
        Me.txt商品名.Left = 6.437008!
        Me.txt商品名.Name = "txt商品名"
        Me.txt商品名.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: bottom; ddo" & _
    "-char-set: 1"
        Me.txt商品名.Text = "あああああいいいいいううううう"
        Me.txt商品名.Top = 0.0000001788139!
        Me.txt商品名.Width = 2.007874!
        '
        'txt発送日
        '
        Me.txt発送日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発送日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発送日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発送日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発送日.Height = 0.2755905!
        Me.txt発送日.Left = 2.5!
        Me.txt発送日.Name = "txt発送日"
        Me.txt発送日.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt発送日.Text = "YY/MM/DD"
        Me.txt発送日.Top = 0.0!
        Me.txt発送日.Width = 0.5314961!
        '
        'txt運送会社名
        '
        Me.txt運送会社名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt運送会社名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt運送会社名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt運送会社名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt運送会社名.Height = 0.2755905!
        Me.txt運送会社名.Left = 9.153543!
        Me.txt運送会社名.Name = "txt運送会社名"
        Me.txt運送会社名.Style = "font-family: ＭＳ 明朝; font-size: 8.5pt; text-align: center; vertical-align: middle;" & _
    " ddo-char-set: 1"
        Me.txt運送会社名.Text = "ああ"
        Me.txt運送会社名.Top = 0.0!
        Me.txt運送会社名.Width = 0.3937008!
        '
        'txt出荷数
        '
        Me.txt出荷数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出荷数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出荷数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出荷数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出荷数.Height = 0.2755905!
        Me.txt出荷数.Left = 8.444882!
        Me.txt出荷数.Name = "txt出荷数"
        Me.txt出荷数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.txt出荷数.Text = "999,999"
        Me.txt出荷数.Top = 0.0!
        Me.txt出荷数.Width = 0.7086614!
        '
        'txt備考
        '
        Me.txt備考.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt備考.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt備考.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt備考.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt備考.Height = 0.2755905!
        Me.txt備考.Left = 9.547244!
        Me.txt備考.Name = "txt備考"
        Me.txt備考.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt備考.Text = Nothing
        Me.txt備考.Top = 0.0!
        Me.txt備考.Width = 1.299213!
        '
        'txt出荷先名
        '
        Me.txt出荷先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出荷先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出荷先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出荷先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出荷先名.Height = 0.2755905!
        Me.txt出荷先名.Left = 3.444882!
        Me.txt出荷先名.Name = "txt出荷先名"
        Me.txt出荷先名.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: middle; ddo" & _
    "-char-set: 1"
        Me.txt出荷先名.Text = "あああああいいいいいううううう"
        Me.txt出荷先名.Top = 0.0!
        Me.txt出荷先名.Width = 1.988189!
        '
        'txt売上No
        '
        Me.txt売上No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt売上No.Height = 0.2755905!
        Me.txt売上No.Left = 3.031496!
        Me.txt売上No.Name = "txt売上No"
        Me.txt売上No.Style = "font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt売上No.Text = "123456" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txt売上No.Top = 0.0!
        Me.txt売上No.Width = 0.4133858!
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtNow, Me.txt頁})
        Me.PageHeader.Height = 0.3269354!
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
        'grpHdr得意先CD
        '
        Me.grpHdr得意先CD.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtHdr発送日, Me.txt出荷予定表, Me.txt場所区分, Me.txt定番品区分, Me.lbl得意先CD, Me.lbl定番CD, Me.lbl作業No, Me.lbl得意先名, Me.ｌｂｌ商品名, Me.lbl出荷数, Me.lbl運送会社, Me.lbl発送日, Me.lbl備考, Me.lblHdr発送日, Me.lbl出荷先名, Me.lbl売上No})
        Me.grpHdr得意先CD.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr得意先CD.Height = 0.7488189!
        Me.grpHdr得意先CD.Name = "grpHdr得意先CD"
        Me.grpHdr得意先CD.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'txtHdr発送日
        '
        Me.txtHdr発送日.Height = 0.2362205!
        Me.txtHdr発送日.Left = 0.7874014!
        Me.txtHdr発送日.Name = "txtHdr発送日"
        Me.txtHdr発送日.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txtHdr発送日.Text = "99/99/99　日分"
        Me.txtHdr発送日.Top = 0.0!
        Me.txtHdr発送日.Width = 1.879529!
        '
        'txt出荷予定表
        '
        Me.txt出荷予定表.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt出荷予定表.Height = 0.2362205!
        Me.txt出荷予定表.Left = 3.359449!
        Me.txt出荷予定表.Name = "txt出荷予定表"
        Me.txt出荷予定表.Style = "font-family: ＭＳ 明朝; font-size: 14pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt出荷予定表.Text = "出　荷　予　定　表"
        Me.txt出荷予定表.Top = 0.08110237!
        Me.txt出荷予定表.Width = 2.681497!
        '
        'txt場所区分
        '
        Me.txt場所区分.Height = 0.2362205!
        Me.txt場所区分.Left = 6.264174!
        Me.txt場所区分.Name = "txt場所区分"
        Me.txt場所区分.Style = "font-family: ＭＳ 明朝; font-size: 12pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt場所区分.Text = "(●●分)"
        Me.txt場所区分.Top = 0.08267725!
        Me.txt場所区分.Width = 0.9728355!
        '
        'txt定番品区分
        '
        Me.txt定番品区分.Height = 0.2362205!
        Me.txt定番品区分.Left = 7.343701!
        Me.txt定番品区分.Name = "txt定番品区分"
        Me.txt定番品区分.Style = "font-family: ＭＳ 明朝; font-size: 12pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt定番品区分.Text = "(●●●のみ抽出)"
        Me.txt定番品区分.Top = 0.08267725!
        Me.txt定番品区分.Width = 1.483071!
        '
        'lbl得意先CD
        '
        Me.lbl得意先CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先CD.Height = 0.3346457!
        Me.lbl得意先CD.HyperLink = Nothing
        Me.lbl得意先CD.Left = 0.0!
        Me.lbl得意先CD.Name = "lbl得意先CD"
        Me.lbl得意先CD.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl得意先CD.Text = "ｺｰﾄﾞ"
        Me.lbl得意先CD.Top = 0.4141732!
        Me.lbl得意先CD.Width = 0.3937008!
        '
        'lbl定番CD
        '
        Me.lbl定番CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl定番CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl定番CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl定番CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl定番CD.Height = 0.3346457!
        Me.lbl定番CD.HyperLink = Nothing
        Me.lbl定番CD.Left = 5.846457!
        Me.lbl定番CD.Name = "lbl定番CD"
        Me.lbl定番CD.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl定番CD.Text = "定番ｺｰﾄﾞ"
        Me.lbl定番CD.Top = 0.4141734!
        Me.lbl定番CD.Width = 0.5905512!
        '
        'lbl作業No
        '
        Me.lbl作業No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl作業No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl作業No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl作業No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl作業No.Height = 0.3346457!
        Me.lbl作業No.HyperLink = Nothing
        Me.lbl作業No.Left = 5.433071!
        Me.lbl作業No.Name = "lbl作業No"
        Me.lbl作業No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl作業No.Text = "作業No"
        Me.lbl作業No.Top = 0.4141734!
        Me.lbl作業No.Width = 0.4133858!
        '
        'lbl得意先名
        '
        Me.lbl得意先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Height = 0.3346457!
        Me.lbl得意先名.HyperLink = Nothing
        Me.lbl得意先名.Left = 0.3937008!
        Me.lbl得意先名.Name = "lbl得意先名"
        Me.lbl得意先名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl得意先名.Text = "得意先名"
        Me.lbl得意先名.Top = 0.4141734!
        Me.lbl得意先名.Width = 2.106299!
        '
        'ｌｂｌ商品名
        '
        Me.ｌｂｌ商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ商品名.Height = 0.3346457!
        Me.ｌｂｌ商品名.HyperLink = Nothing
        Me.ｌｂｌ商品名.Left = 6.437008!
        Me.ｌｂｌ商品名.Name = "ｌｂｌ商品名"
        Me.ｌｂｌ商品名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.ｌｂｌ商品名.Text = "品　　　名"
        Me.ｌｂｌ商品名.Top = 0.4141734!
        Me.ｌｂｌ商品名.Width = 2.007874!
        '
        'lbl出荷数
        '
        Me.lbl出荷数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl出荷数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl出荷数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl出荷数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl出荷数.Height = 0.3346457!
        Me.lbl出荷数.HyperLink = Nothing
        Me.lbl出荷数.Left = 8.444881!
        Me.lbl出荷数.Name = "lbl出荷数"
        Me.lbl出荷数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl出荷数.Text = "出荷数"
        Me.lbl出荷数.Top = 0.4141736!
        Me.lbl出荷数.Width = 0.7086614!
        '
        'lbl運送会社
        '
        Me.lbl運送会社.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl運送会社.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl運送会社.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl運送会社.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl運送会社.Height = 0.3346457!
        Me.lbl運送会社.HyperLink = Nothing
        Me.lbl運送会社.Left = 9.153543!
        Me.lbl運送会社.Name = "lbl運送会社"
        Me.lbl運送会社.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8.5pt; text-align: center; vertical-" & _
    "align: middle; ddo-char-set: 1"
        Me.lbl運送会社.Text = "運送会社"
        Me.lbl運送会社.Top = 0.4141736!
        Me.lbl運送会社.Width = 0.3937008!
        '
        'lbl発送日
        '
        Me.lbl発送日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発送日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発送日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発送日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl発送日.Height = 0.3346457!
        Me.lbl発送日.HyperLink = Nothing
        Me.lbl発送日.Left = 2.5!
        Me.lbl発送日.Name = "lbl発送日"
        Me.lbl発送日.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl発送日.Text = "発送日"
        Me.lbl発送日.Top = 0.4141734!
        Me.lbl発送日.Width = 0.5314961!
        '
        'lbl備考
        '
        Me.lbl備考.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl備考.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl備考.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl備考.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl備考.Height = 0.3346457!
        Me.lbl備考.HyperLink = Nothing
        Me.lbl備考.Left = 9.547243!
        Me.lbl備考.Name = "lbl備考"
        Me.lbl備考.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl備考.Text = "備　考"
        Me.lbl備考.Top = 0.4141734!
        Me.lbl備考.Width = 1.299213!
        '
        'lblHdr発送日
        '
        Me.lblHdr発送日.Height = 0.2362205!
        Me.lblHdr発送日.HyperLink = Nothing
        Me.lblHdr発送日.Left = 0.0!
        Me.lblHdr発送日.Name = "lblHdr発送日"
        Me.lblHdr発送日.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lblHdr発送日.Text = "発送日"
        Me.lblHdr発送日.Top = 0.0!
        Me.lblHdr発送日.Width = 0.7874014!
        '
        'lbl出荷先名
        '
        Me.lbl出荷先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl出荷先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl出荷先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl出荷先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl出荷先名.Height = 0.3346457!
        Me.lbl出荷先名.HyperLink = Nothing
        Me.lbl出荷先名.Left = 3.444882!
        Me.lbl出荷先名.Name = "lbl出荷先名"
        Me.lbl出荷先名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl出荷先名.Text = "出　荷　先　名"
        Me.lbl出荷先名.Top = 0.4141734!
        Me.lbl出荷先名.Width = 1.988189!
        '
        'lbl売上No
        '
        Me.lbl売上No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl売上No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl売上No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl売上No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl売上No.Height = 0.3346457!
        Me.lbl売上No.HyperLink = Nothing
        Me.lbl売上No.Left = 3.031496!
        Me.lbl売上No.Name = "lbl売上No"
        Me.lbl売上No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 8pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl売上No.Text = "売上No"
        Me.lbl売上No.Top = 0.4141734!
        Me.lbl売上No.Width = 0.4133858!
        '
        'grpFtr総合計
        '
        Me.grpFtr総合計.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox1, Me.TextBox2, Me.TextBox6, Me.TextBox5, Me.TextBox3, Me.txt発送日計, Me.TextBox7, Me.TextBox8, Me.TextBox9, Me.lbl発送日計, Me.TextBox4, Me.TextBox10})
        Me.grpFtr総合計.Height = 0.2755905!
        Me.grpFtr総合計.Name = "grpFtr総合計"
        '
        'TextBox1
        '
        Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Height = 0.2755905!
        Me.TextBox1.Left = 9.547244!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.TextBox1.Text = Nothing
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 1.299213!
        '
        'TextBox2
        '
        Me.TextBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Height = 0.2755905!
        Me.TextBox2.Left = 2.5!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox2.Text = Nothing
        Me.TextBox2.Top = 0.0!
        Me.TextBox2.Width = 0.5314961!
        '
        'TextBox6
        '
        Me.TextBox6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Height = 0.2755905!
        Me.TextBox6.Left = 9.153543!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox6.Text = Nothing
        Me.TextBox6.Top = 0.0!
        Me.TextBox6.Width = 0.3937008!
        '
        'TextBox5
        '
        Me.TextBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Height = 0.2755905!
        Me.TextBox5.Left = 8.444882!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox5.Text = Nothing
        Me.TextBox5.Top = 0.0!
        Me.TextBox5.Width = 0.7086614!
        '
        'TextBox3
        '
        Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Height = 0.2755905!
        Me.TextBox3.Left = 6.437008!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: bottom; ddo" & _
    "-char-set: 1"
        Me.TextBox3.Text = Nothing
        Me.TextBox3.Top = 0.0!
        Me.TextBox3.Width = 2.007874!
        '
        'txt発送日計
        '
        Me.txt発送日計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発送日計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発送日計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発送日計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt発送日計.Height = 0.2755905!
        Me.txt発送日計.Left = 0.3937008!
        Me.txt発送日計.Name = "txt発送日計"
        Me.txt発送日計.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt発送日計.Text = "99件"
        Me.txt発送日計.Top = 0.0!
        Me.txt発送日計.Width = 2.106299!
        '
        'TextBox7
        '
        Me.TextBox7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Height = 0.2755905!
        Me.TextBox7.Left = 5.433071!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox7.Text = Nothing
        Me.TextBox7.Top = 0.0!
        Me.TextBox7.Width = 0.4133858!
        '
        'TextBox8
        '
        Me.TextBox8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Height = 0.2755905!
        Me.TextBox8.Left = 5.846457!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox8.Text = Nothing
        Me.TextBox8.Top = 0.0!
        Me.TextBox8.Width = 0.5905512!
        '
        'TextBox9
        '
        Me.TextBox9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox9.Height = 0.2755905!
        Me.TextBox9.Left = 0.0!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.TextBox9.Text = Nothing
        Me.TextBox9.Top = 0.0!
        Me.TextBox9.Width = 0.3937008!
        '
        'lbl発送日計
        '
        Me.lbl発送日計.Height = 0.1968504!
        Me.lbl発送日計.HyperLink = Nothing
        Me.lbl発送日計.Left = 0.6393701!
        Me.lbl発送日計.Name = "lbl発送日計"
        Me.lbl発送日計.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl発送日計.Text = "＊発送日計"
        Me.lbl発送日計.Top = 0.05826772!
        Me.lbl発送日計.Width = 0.7874014!
        '
        'TextBox4
        '
        Me.TextBox4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Height = 0.2755905!
        Me.TextBox4.Left = 3.444882!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: middle; ddo" & _
    "-char-set: 1"
        Me.TextBox4.Text = Nothing
        Me.TextBox4.Top = 0.0!
        Me.TextBox4.Width = 1.988189!
        '
        'TextBox10
        '
        Me.TextBox10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Height = 0.2755905!
        Me.TextBox10.Left = 3.031496!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox10.Text = Nothing
        Me.TextBox10.Top = 0.0!
        Me.TextBox10.Width = 0.4133858!
        '
        'ShipSchedule
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 10.86614!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.grpHdr得意先CD)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.grpFtr総合計)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.txt得意先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt定番CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt作業No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt発送日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt運送会社名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt出荷数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt備考, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt出荷先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt売上No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr発送日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt出荷予定表, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt場所区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt定番品区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl得意先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl定番CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl作業No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ｌｂｌ商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl出荷数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl運送会社, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl発送日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl備考, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr発送日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl出荷先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl売上No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt発送日計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl発送日計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents grpHdr得意先CD As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents txt得意先CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt定番CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt作業No As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt商品名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpFtr総合計 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txt発送日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt運送会社名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt出荷数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt備考 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtNow As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt頁 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt発送日計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox8 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtHdr発送日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt出荷予定表 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt場所区分 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt定番品区分 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl得意先CD As DataDynamics.ActiveReports.Label
    Private WithEvents lbl定番CD As DataDynamics.ActiveReports.Label
    Private WithEvents lbl作業No As DataDynamics.ActiveReports.Label
    Private WithEvents lbl得意先名 As DataDynamics.ActiveReports.Label
    Private WithEvents ｌｂｌ商品名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl出荷数 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl運送会社 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl発送日 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl備考 As DataDynamics.ActiveReports.Label
    Private WithEvents lblHdr発送日 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl発送日計 As DataDynamics.ActiveReports.Label
    Private WithEvents txt出荷先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl出荷先名 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl売上No As DataDynamics.ActiveReports.Label
    Private WithEvents txt売上No As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox10 As DataDynamics.ActiveReports.TextBox
End Class
