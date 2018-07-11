<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class OutBill
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(OutBill))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt支払日 = New DataDynamics.ActiveReports.TextBox()
        Me.txt摘要 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入先名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt科目CD = New DataDynamics.ActiveReports.TextBox()
        Me.txt支払先CD = New DataDynamics.ActiveReports.TextBox()
        Me.txt支払金額 = New DataDynamics.ActiveReports.TextBox()
        Me.txt貸方科目名名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt支払No = New DataDynamics.ActiveReports.TextBox()
        Me.txt支払区分名 = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.txtNow = New DataDynamics.ActiveReports.TextBox()
        Me.txt頁 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.GroupHeader2 = New DataDynamics.ActiveReports.GroupHeader()
        Me.grpFtr総合計 = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox8 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox()
        Me.txt入金日計総合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計支払区分 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕上日計件数 = New DataDynamics.ActiveReports.TextBox()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox10 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox()
        Me.grpHdr = New DataDynamics.ActiveReports.GroupHeader()
        Me.txtHdr支払日 = New DataDynamics.ActiveReports.TextBox()
        Me.txt出金明細表 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl支払日 = New DataDynamics.ActiveReports.Label()
        Me.lbl摘要 = New DataDynamics.ActiveReports.Label()
        Me.lbl仕入先名 = New DataDynamics.ActiveReports.Label()
        Me.lbl支払金額 = New DataDynamics.ActiveReports.Label()
        Me.lbl支払先CD = New DataDynamics.ActiveReports.Label()
        Me.lbl科目CD = New DataDynamics.ActiveReports.Label()
        Me.lblHdr支払日 = New DataDynamics.ActiveReports.Label()
        Me.lbl貸方科目名 = New DataDynamics.ActiveReports.Label()
        Me.lbl支払No = New DataDynamics.ActiveReports.Label()
        Me.txt支払区分 = New DataDynamics.ActiveReports.Label()
        Me.grpFtr計 = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox()
        Me.txt入金総合計 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox15 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox17 = New DataDynamics.ActiveReports.TextBox()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.TextBox19 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox20 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox23 = New DataDynamics.ActiveReports.TextBox()
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader()
        Me.grpFtr入金日計 = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox18 = New DataDynamics.ActiveReports.TextBox()
        Me.txt出荷先名 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox12 = New DataDynamics.ActiveReports.TextBox()
        Me.txt入金日計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt支払日計支払区分名 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox16 = New DataDynamics.ActiveReports.TextBox()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.TextBox13 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox21 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.txt支払日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt摘要, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt科目CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt支払先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt支払金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt貸方科目名名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt支払No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt支払区分名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt入金日計総合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計支払区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕上日計件数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtHdr支払日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt出金明細表, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl支払日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl摘要, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl仕入先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl支払金額, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl支払先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl科目CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblHdr支払日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl貸方科目名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl支払No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt支払区分, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt入金総合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt出荷先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt入金日計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt支払日計支払区分名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt支払日, Me.txt摘要, Me.txt仕入先名, Me.txt科目CD, Me.txt支払先CD, Me.txt支払金額, Me.txt貸方科目名名, Me.txt支払No, Me.txt支払区分名})
        Me.Detail.Height = 0.2755905!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.RepeatToFill = True
        '
        'txt支払日
        '
        Me.txt支払日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt支払日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt支払日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt支払日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt支払日.Height = 0.2755905!
        Me.txt支払日.Left = 0.0!
        Me.txt支払日.Name = "txt支払日"
        Me.txt支払日.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt支払日.Text = "YY/MM/DD"
        Me.txt支払日.Top = 0.0!
        Me.txt支払日.Width = 0.6692914!
        '
        'txt摘要
        '
        Me.txt摘要.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt摘要.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt摘要.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt摘要.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt摘要.Height = 0.2755905!
        Me.txt摘要.Left = 7.677166!
        Me.txt摘要.Name = "txt摘要"
        Me.txt摘要.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: justify; vertical-align: middle;" & _
    " ddo-char-set: 1"
        Me.txt摘要.Text = "あああああいいいいいうううううえええええ"
        Me.txt摘要.Top = 0.000001132488!
        Me.txt摘要.Width = 3.149606!
        '
        'txt仕入先名
        '
        Me.txt仕入先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入先名.Height = 0.2755905!
        Me.txt仕入先名.Left = 1.751969!
        Me.txt仕入先名.Name = "txt仕入先名"
        Me.txt仕入先名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt仕入先名.Text = "あああああいいいいいううううう"
        Me.txt仕入先名.Top = 0.0000001788139!
        Me.txt仕入先名.Width = 2.401575!
        '
        'txt科目CD
        '
        Me.txt科目CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt科目CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt科目CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt科目CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt科目CD.Height = 0.2755905!
        Me.txt科目CD.Left = 6.318898!
        Me.txt科目CD.Name = "txt科目CD"
        Me.txt科目CD.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt科目CD.Text = "123"
        Me.txt科目CD.Top = 0.0000002384186!
        Me.txt科目CD.Width = 0.472441!
        '
        'txt支払先CD
        '
        Me.txt支払先CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt支払先CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt支払先CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt支払先CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt支払先CD.Height = 0.2755905!
        Me.txt支払先CD.Left = 1.240158!
        Me.txt支払先CD.Name = "txt支払先CD"
        Me.txt支払先CD.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt支払先CD.Text = "123456"
        Me.txt支払先CD.Top = 0.0!
        Me.txt支払先CD.Width = 0.511811!
        '
        'txt支払金額
        '
        Me.txt支払金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt支払金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt支払金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt支払金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt支払金額.Height = 0.2755905!
        Me.txt支払金額.Left = 5.098425!
        Me.txt支払金額.Name = "txt支払金額"
        Me.txt支払金額.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt支払金額.Text = "999,999"
        Me.txt支払金額.Top = 0.00000005960464!
        Me.txt支払金額.Width = 1.220472!
        '
        'txt貸方科目名名
        '
        Me.txt貸方科目名名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt貸方科目名名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt貸方科目名名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt貸方科目名名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt貸方科目名名.Height = 0.2755905!
        Me.txt貸方科目名名.Left = 6.791339!
        Me.txt貸方科目名名.Name = "txt貸方科目名名"
        Me.txt貸方科目名名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt貸方科目名名.Text = "あああああ"
        Me.txt貸方科目名名.Top = 0.0000002384186!
        Me.txt貸方科目名名.Width = 0.8858268!
        '
        'txt支払No
        '
        Me.txt支払No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt支払No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt支払No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt支払No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt支払No.Height = 0.2755905!
        Me.txt支払No.Left = 0.6692914!
        Me.txt支払No.Name = "txt支払No"
        Me.txt支払No.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt支払No.Text = "1234567"
        Me.txt支払No.Top = 0.0000002384186!
        Me.txt支払No.Width = 0.5708662!
        '
        'txt支払区分名
        '
        Me.txt支払区分名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt支払区分名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt支払区分名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt支払区分名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt支払区分名.Height = 0.2755905!
        Me.txt支払区分名.Left = 4.153543!
        Me.txt支払区分名.Name = "txt支払区分名"
        Me.txt支払区分名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt支払区分名.Text = "ああああ"
        Me.txt支払区分名.Top = 0.0000004470348!
        Me.txt支払区分名.Width = 0.9448819!
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
        'GroupHeader2
        '
        Me.GroupHeader2.Height = 0.0!
        Me.GroupHeader2.Name = "GroupHeader2"
        '
        'grpFtr総合計
        '
        Me.grpFtr総合計.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox8, Me.TextBox4, Me.TextBox2, Me.txt入金日計総合計, Me.txt総合計支払区分, Me.txt仕上日計件数, Me.Label3, Me.TextBox6, Me.TextBox10, Me.TextBox9})
        Me.grpFtr総合計.Height = 0.275591!
        Me.grpFtr総合計.Name = "grpFtr総合計"
        '
        'TextBox8
        '
        Me.TextBox8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Height = 0.2755906!
        Me.TextBox8.Left = 7.677166!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox8.Text = Nothing
        Me.TextBox8.Top = 0.0!
        Me.TextBox8.Width = 3.149606!
        '
        'TextBox4
        '
        Me.TextBox4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Height = 0.2755906!
        Me.TextBox4.Left = 6.791339!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: middle; ddo" & _
    "-char-set: 1"
        Me.TextBox4.Text = Nothing
        Me.TextBox4.Top = 0.0000002384186!
        Me.TextBox4.Width = 0.8858271!
        '
        'TextBox2
        '
        Me.TextBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Height = 0.2755906!
        Me.TextBox2.Left = 6.318898!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox2.Text = Nothing
        Me.TextBox2.Top = 0.0000002384186!
        Me.TextBox2.Width = 0.472441!
        '
        'txt入金日計総合計
        '
        Me.txt入金日計総合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入金日計総合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入金日計総合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入金日計総合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入金日計総合計.Height = 0.2755906!
        Me.txt入金日計総合計.Left = 5.098425!
        Me.txt入金日計総合計.Name = "txt入金日計総合計"
        Me.txt入金日計総合計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt入金日計総合計.Text = "999,999,999" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txt入金日計総合計.Top = 0.00000005960464!
        Me.txt入金日計総合計.Width = 1.220472!
        '
        'txt総合計支払区分
        '
        Me.txt総合計支払区分.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計支払区分.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計支払区分.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計支払区分.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計支払区分.Height = 0.2755906!
        Me.txt総合計支払区分.Left = 4.153543!
        Me.txt総合計支払区分.Name = "txt総合計支払区分"
        Me.txt総合計支払区分.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt総合計支払区分.Text = "ああああ"
        Me.txt総合計支払区分.Top = 0.0000004470349!
        Me.txt総合計支払区分.Width = 0.944882!
        '
        'txt仕上日計件数
        '
        Me.txt仕上日計件数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕上日計件数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕上日計件数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕上日計件数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕上日計件数.Height = 0.2755905!
        Me.txt仕上日計件数.Left = 1.751969!
        Me.txt仕上日計件数.Name = "txt仕上日計件数"
        Me.txt仕上日計件数.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.txt仕上日計件数.Text = Nothing
        Me.txt仕上日計件数.Top = 0.0!
        Me.txt仕上日計件数.Width = 2.401575!
        '
        'Label3
        '
        Me.Label3.Height = 0.1968504!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 3.471654!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.Label3.Text = "＊総合計"
        Me.Label3.Top = 0.03779528!
        Me.Label3.Width = 0.5905512!
        '
        'TextBox6
        '
        Me.TextBox6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Height = 0.2755905!
        Me.TextBox6.Left = 1.240158!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox6.Text = Nothing
        Me.TextBox6.Top = 0.0!
        Me.TextBox6.Width = 0.511811!
        '
        'TextBox10
        '
        Me.TextBox10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Height = 0.2755905!
        Me.TextBox10.Left = 0.6692914!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox10.Text = Nothing
        Me.TextBox10.Top = 0.0000002384186!
        Me.TextBox10.Width = 0.5708662!
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
        Me.TextBox9.Width = 0.6692914!
        '
        'grpHdr
        '
        Me.grpHdr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtHdr支払日, Me.txt出金明細表, Me.lbl支払日, Me.lbl摘要, Me.lbl仕入先名, Me.lbl支払金額, Me.lbl支払先CD, Me.lbl科目CD, Me.lblHdr支払日, Me.lbl貸方科目名, Me.lbl支払No, Me.txt支払区分})
        Me.grpHdr.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr.Height = 0.7488193!
        Me.grpHdr.Name = "grpHdr"
        Me.grpHdr.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'txtHdr支払日
        '
        Me.txtHdr支払日.Height = 0.2362205!
        Me.txtHdr支払日.Left = 0.7874016!
        Me.txtHdr支払日.Name = "txtHdr支払日"
        Me.txtHdr支払日.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txtHdr支払日.Text = "00/00/00～99/99/99　日迄"
        Me.txtHdr支払日.Top = 0.0!
        Me.txtHdr支払日.Width = 2.150394!
        '
        'txt出金明細表
        '
        Me.txt出金明細表.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt出金明細表.Height = 0.2362205!
        Me.txt出金明細表.Left = 4.065748!
        Me.txt出金明細表.Name = "txt出金明細表"
        Me.txt出金明細表.Style = "font-family: ＭＳ 明朝; font-size: 14pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt出金明細表.Text = "出 金 明 細 表"
        Me.txt出金明細表.Top = 0.08110237!
        Me.txt出金明細表.Width = 2.681497!
        '
        'lbl支払日
        '
        Me.lbl支払日.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl支払日.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl支払日.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl支払日.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl支払日.Height = 0.3346457!
        Me.lbl支払日.HyperLink = Nothing
        Me.lbl支払日.Left = 0.0!
        Me.lbl支払日.Name = "lbl支払日"
        Me.lbl支払日.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl支払日.Text = "支払日"
        Me.lbl支払日.Top = 0.4141732!
        Me.lbl支払日.Width = 0.6692914!
        '
        'lbl摘要
        '
        Me.lbl摘要.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl摘要.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl摘要.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl摘要.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl摘要.Height = 0.3346457!
        Me.lbl摘要.HyperLink = Nothing
        Me.lbl摘要.Left = 7.677166!
        Me.lbl摘要.Name = "lbl摘要"
        Me.lbl摘要.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: left; vertical-ali" & _
    "gn: middle; ddo-char-set: 1"
        Me.lbl摘要.Text = "　　　摘　要"
        Me.lbl摘要.Top = 0.414173!
        Me.lbl摘要.Width = 3.149606!
        '
        'lbl仕入先名
        '
        Me.lbl仕入先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl仕入先名.Height = 0.3346457!
        Me.lbl仕入先名.HyperLink = Nothing
        Me.lbl仕入先名.Left = 1.751969!
        Me.lbl仕入先名.Name = "lbl仕入先名"
        Me.lbl仕入先名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl仕入先名.Text = "仕　入　先　名"
        Me.lbl仕入先名.Top = 0.4141732!
        Me.lbl仕入先名.Width = 2.401575!
        '
        'lbl支払金額
        '
        Me.lbl支払金額.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl支払金額.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl支払金額.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl支払金額.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl支払金額.Height = 0.3346457!
        Me.lbl支払金額.HyperLink = Nothing
        Me.lbl支払金額.Left = 5.098425!
        Me.lbl支払金額.Name = "lbl支払金額"
        Me.lbl支払金額.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl支払金額.Text = "支払金額"
        Me.lbl支払金額.Top = 0.4141732!
        Me.lbl支払金額.Width = 1.220472!
        '
        'lbl支払先CD
        '
        Me.lbl支払先CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl支払先CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl支払先CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl支払先CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl支払先CD.Height = 0.3346457!
        Me.lbl支払先CD.HyperLink = Nothing
        Me.lbl支払先CD.Left = 1.240158!
        Me.lbl支払先CD.Name = "lbl支払先CD"
        Me.lbl支払先CD.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl支払先CD.Text = "支払先" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ｺｰﾄﾞ"
        Me.lbl支払先CD.Top = 0.4141732!
        Me.lbl支払先CD.Width = 0.511811!
        '
        'lbl科目CD
        '
        Me.lbl科目CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl科目CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl科目CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl科目CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl科目CD.Height = 0.3346457!
        Me.lbl科目CD.HyperLink = Nothing
        Me.lbl科目CD.Left = 6.318898!
        Me.lbl科目CD.Name = "lbl科目CD"
        Me.lbl科目CD.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl科目CD.Text = "科目" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ｺｰﾄﾞ"
        Me.lbl科目CD.Top = 0.4141732!
        Me.lbl科目CD.Width = 0.472441!
        '
        'lblHdr支払日
        '
        Me.lblHdr支払日.Height = 0.2362205!
        Me.lblHdr支払日.HyperLink = Nothing
        Me.lblHdr支払日.Left = 0.0!
        Me.lblHdr支払日.Name = "lblHdr支払日"
        Me.lblHdr支払日.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lblHdr支払日.Text = "支払日"
        Me.lblHdr支払日.Top = 0.0!
        Me.lblHdr支払日.Width = 0.7874014!
        '
        'lbl貸方科目名
        '
        Me.lbl貸方科目名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl貸方科目名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl貸方科目名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl貸方科目名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl貸方科目名.Height = 0.3346457!
        Me.lbl貸方科目名.HyperLink = Nothing
        Me.lbl貸方科目名.Left = 6.791339!
        Me.lbl貸方科目名.Name = "lbl貸方科目名"
        Me.lbl貸方科目名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl貸方科目名.Text = "貸方科目名"
        Me.lbl貸方科目名.Top = 0.4141732!
        Me.lbl貸方科目名.Width = 0.8858268!
        '
        'lbl支払No
        '
        Me.lbl支払No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl支払No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl支払No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl支払No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl支払No.Height = 0.3346457!
        Me.lbl支払No.HyperLink = Nothing
        Me.lbl支払No.Left = 0.6692914!
        Me.lbl支払No.Name = "lbl支払No"
        Me.lbl支払No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl支払No.Text = "支払No"
        Me.lbl支払No.Top = 0.4141732!
        Me.lbl支払No.Width = 0.5708662!
        '
        'txt支払区分
        '
        Me.txt支払区分.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt支払区分.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt支払区分.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt支払区分.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt支払区分.Height = 0.3346457!
        Me.txt支払区分.HyperLink = Nothing
        Me.txt支払区分.Left = 4.153543!
        Me.txt支払区分.Name = "txt支払区分"
        Me.txt支払区分.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.txt支払区分.Text = "支払区分"
        Me.txt支払区分.Top = 0.4141732!
        Me.txt支払区分.Width = 0.9448819!
        '
        'grpFtr計
        '
        Me.grpFtr計.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox1, Me.TextBox3, Me.TextBox7, Me.txt入金総合計, Me.TextBox15, Me.TextBox17, Me.Label2, Me.TextBox19, Me.TextBox20, Me.TextBox23})
        Me.grpFtr計.Height = 0.2755905!
        Me.grpFtr計.Name = "grpFtr計"
        '
        'TextBox1
        '
        Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Height = 0.2755906!
        Me.TextBox1.Left = 7.677166!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox1.Text = Nothing
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 3.149606!
        '
        'TextBox3
        '
        Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Height = 0.2755906!
        Me.TextBox3.Left = 6.791339!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: middle; ddo" & _
    "-char-set: 1"
        Me.TextBox3.Text = Nothing
        Me.TextBox3.Top = 0.0000002384186!
        Me.TextBox3.Width = 0.8858271!
        '
        'TextBox7
        '
        Me.TextBox7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Height = 0.2755906!
        Me.TextBox7.Left = 6.318898!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox7.Text = Nothing
        Me.TextBox7.Top = 0.0000002384186!
        Me.TextBox7.Width = 0.472441!
        '
        'txt入金総合計
        '
        Me.txt入金総合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入金総合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入金総合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入金総合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入金総合計.Height = 0.2755906!
        Me.txt入金総合計.Left = 5.098425!
        Me.txt入金総合計.Name = "txt入金総合計"
        Me.txt入金総合計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt入金総合計.Text = "999,999,999" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txt入金総合計.Top = 0.00000005960464!
        Me.txt入金総合計.Width = 1.220472!
        '
        'TextBox15
        '
        Me.TextBox15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.Height = 0.2755906!
        Me.TextBox15.Left = 4.153543!
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox15.Text = Nothing
        Me.TextBox15.Top = 0.0000004470349!
        Me.TextBox15.Width = 0.944882!
        '
        'TextBox17
        '
        Me.TextBox17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox17.Height = 0.2755905!
        Me.TextBox17.Left = 1.751969!
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: right; vertical-align: middle; dd" & _
    "o-char-set: 1"
        Me.TextBox17.Text = Nothing
        Me.TextBox17.Top = 0.0!
        Me.TextBox17.Width = 2.401575!
        '
        'Label2
        '
        Me.Label2.Height = 0.1968504!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 4.467323!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.Label2.Text = "計"
        Me.Label2.Top = 0.04094489!
        Me.Label2.Width = 0.3082674!
        '
        'TextBox19
        '
        Me.TextBox19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Height = 0.2755905!
        Me.TextBox19.Left = 1.240158!
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox19.Text = Nothing
        Me.TextBox19.Top = 0.0!
        Me.TextBox19.Width = 0.511811!
        '
        'TextBox20
        '
        Me.TextBox20.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox20.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox20.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox20.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox20.Height = 0.2755905!
        Me.TextBox20.Left = 0.6692914!
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox20.Text = Nothing
        Me.TextBox20.Top = 0.0000002384186!
        Me.TextBox20.Width = 0.5708662!
        '
        'TextBox23
        '
        Me.TextBox23.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox23.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox23.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox23.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox23.Height = 0.2755905!
        Me.TextBox23.Left = 0.0!
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.TextBox23.Text = Nothing
        Me.TextBox23.Top = 0.0!
        Me.TextBox23.Width = 0.6692914!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Height = 0.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'grpFtr入金日計
        '
        Me.grpFtr入金日計.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox18, Me.txt出荷先名, Me.TextBox12, Me.txt入金日計, Me.txt支払日計支払区分名, Me.TextBox16, Me.Label1, Me.TextBox13, Me.TextBox21, Me.TextBox5})
        Me.grpFtr入金日計.Height = 0.275591!
        Me.grpFtr入金日計.Name = "grpFtr入金日計"
        '
        'TextBox18
        '
        Me.TextBox18.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox18.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox18.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox18.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox18.Height = 0.2755906!
        Me.TextBox18.Left = 7.677166!
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox18.Text = Nothing
        Me.TextBox18.Top = 0.0!
        Me.TextBox18.Width = 3.149606!
        '
        'txt出荷先名
        '
        Me.txt出荷先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出荷先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出荷先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出荷先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt出荷先名.Height = 0.2755906!
        Me.txt出荷先名.Left = 6.791339!
        Me.txt出荷先名.Name = "txt出荷先名"
        Me.txt出荷先名.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: middle; ddo" & _
    "-char-set: 1"
        Me.txt出荷先名.Text = Nothing
        Me.txt出荷先名.Top = 0.0000002384186!
        Me.txt出荷先名.Width = 0.8858271!
        '
        'TextBox12
        '
        Me.TextBox12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox12.Height = 0.2755906!
        Me.TextBox12.Left = 6.318898!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox12.Text = Nothing
        Me.TextBox12.Top = 0.0000002384186!
        Me.TextBox12.Width = 0.472441!
        '
        'txt入金日計
        '
        Me.txt入金日計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入金日計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入金日計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入金日計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt入金日計.Height = 0.2755906!
        Me.txt入金日計.Left = 5.098425!
        Me.txt入金日計.Name = "txt入金日計"
        Me.txt入金日計.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt入金日計.Text = "999,999,999" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txt入金日計.Top = 0.00000005960464!
        Me.txt入金日計.Width = 1.220472!
        '
        'txt支払日計支払区分名
        '
        Me.txt支払日計支払区分名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt支払日計支払区分名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt支払日計支払区分名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt支払日計支払区分名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt支払日計支払区分名.Height = 0.2755906!
        Me.txt支払日計支払区分名.Left = 4.153543!
        Me.txt支払日計支払区分名.Name = "txt支払日計支払区分名"
        Me.txt支払日計支払区分名.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt支払日計支払区分名.Text = "ああああ"
        Me.txt支払日計支払区分名.Top = 0.0000004470349!
        Me.txt支払日計支払区分名.Width = 0.944882!
        '
        'TextBox16
        '
        Me.TextBox16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox16.Height = 0.2755905!
        Me.TextBox16.Left = 1.751969!
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: middle; ddo" & _
    "-char-set: 1"
        Me.TextBox16.Text = Nothing
        Me.TextBox16.Top = 0.0!
        Me.TextBox16.Width = 2.401575!
        '
        'Label1
        '
        Me.Label1.Height = 0.1968504!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 3.317323!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.Label1.Text = "＊支払日計"
        Me.Label1.Top = 0.04094489!
        Me.Label1.Width = 0.7874014!
        '
        'TextBox13
        '
        Me.TextBox13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Height = 0.2755905!
        Me.TextBox13.Left = 1.240158!
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: bottom; d" & _
    "do-char-set: 1"
        Me.TextBox13.Text = Nothing
        Me.TextBox13.Top = 0.0!
        Me.TextBox13.Width = 0.511811!
        '
        'TextBox21
        '
        Me.TextBox21.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox21.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox21.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox21.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox21.Height = 0.2755905!
        Me.TextBox21.Left = 0.6692914!
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox21.Text = Nothing
        Me.TextBox21.Top = 0.0000002384186!
        Me.TextBox21.Width = 0.5708662!
        '
        'TextBox5
        '
        Me.TextBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Height = 0.2755905!
        Me.TextBox5.Left = 0.0!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.TextBox5.Text = Nothing
        Me.TextBox5.Top = 0.0!
        Me.TextBox5.Width = 0.6692914!
        '
        'OutBill
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
        Me.Sections.Add(Me.GroupHeader2)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.grpFtr入金日計)
        Me.Sections.Add(Me.grpFtr総合計)
        Me.Sections.Add(Me.grpFtr計)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.txt支払日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt摘要, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt科目CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt支払先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt支払金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt貸方科目名名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt支払No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt支払区分名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt入金日計総合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計支払区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕上日計件数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtHdr支払日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt出金明細表, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl支払日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl摘要, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl仕入先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl支払金額, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl支払先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl科目CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblHdr支払日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl貸方科目名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl支払No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt支払区分, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt入金総合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt出荷先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt入金日計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt支払日計支払区分名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txt支払日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt摘要 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt科目CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt支払先CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt支払金額 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtNow As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt頁 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt貸方科目名名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt支払No As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt支払区分名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents GroupHeader2 As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents grpFtr総合計 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents grpHdr As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents txtHdr支払日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt出金明細表 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl支払日 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl摘要 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl仕入先名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl支払金額 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl支払先CD As DataDynamics.ActiveReports.Label
    Private WithEvents lbl科目CD As DataDynamics.ActiveReports.Label
    Private WithEvents lblHdr支払日 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl貸方科目名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl支払No As DataDynamics.ActiveReports.Label
    Private WithEvents txt支払区分 As DataDynamics.ActiveReports.Label
    Private WithEvents grpFtr計 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents grpFtr入金日計 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents TextBox18 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt出荷先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox12 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt入金日計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt支払日計支払区分名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox16 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox13 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox21 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox8 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt入金日計総合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計支払区分 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕上日計件数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox10 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt入金総合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox15 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox17 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox19 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox20 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox23 As DataDynamics.ActiveReports.TextBox
End Class
