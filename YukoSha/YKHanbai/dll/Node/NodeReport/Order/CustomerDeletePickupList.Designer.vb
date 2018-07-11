<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class CustomerDeletePickupList
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CustomerDeletePickupList))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt得意先CD = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt商品名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt備考 = New DataDynamics.ActiveReports.TextBox()
        Me.txt本台帳No = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.txtNow = New DataDynamics.ActiveReports.TextBox()
        Me.txt頁 = New DataDynamics.ActiveReports.TextBox()
        Me.txtタイトル = New DataDynamics.ActiveReports.TextBox()
        Me.lbl得意先コード = New DataDynamics.ActiveReports.Label()
        Me.lbl得意先名 = New DataDynamics.ActiveReports.Label()
        Me.ｌｂｌ商品名 = New DataDynamics.ActiveReports.Label()
        Me.lbl本台帳No = New DataDynamics.ActiveReports.Label()
        Me.lbl備考 = New DataDynamics.ActiveReports.Label()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader()
        Me.grpFtr = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox()
        Me.txt合計 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        CType(Me.txt得意先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt備考, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt本台帳No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtタイトル, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl得意先コード, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ｌｂｌ商品名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl本台帳No, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl備考, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt得意先CD, Me.txt得意先名, Me.txt商品名, Me.txt備考, Me.txt本台帳No})
        Me.Detail.Height = 0.2952756!
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
        Me.txt得意先CD.Height = 0.2952756!
        Me.txt得意先CD.Left = 0.0!
        Me.txt得意先CD.Name = "txt得意先CD"
        Me.txt得意先CD.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt得意先CD.Text = "123456"
        Me.txt得意先CD.Top = 0.0!
        Me.txt得意先CD.Width = 0.7480315!
        '
        'txt得意先名
        '
        Me.txt得意先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Height = 0.2952756!
        Me.txt得意先名.Left = 0.7480315!
        Me.txt得意先名.Name = "txt得意先名"
        Me.txt得意先名.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: middle; ddo" & _
    "-char-set: 1"
        Me.txt得意先名.Text = "あああああいいいいいううううう"
        Me.txt得意先名.Top = 0.0!
        Me.txt得意先名.Width = 2.322835!
        '
        'txt商品名
        '
        Me.txt商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt商品名.Height = 0.2952756!
        Me.txt商品名.Left = 3.799213!
        Me.txt商品名.Name = "txt商品名"
        Me.txt商品名.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: middle; ddo" & _
    "-char-set: 1"
        Me.txt商品名.Text = "あああああいいいいいううううう"
        Me.txt商品名.Top = 0.00000005960464!
        Me.txt商品名.Width = 2.322835!
        '
        'txt備考
        '
        Me.txt備考.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt備考.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt備考.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt備考.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt備考.Height = 0.2952756!
        Me.txt備考.Left = 6.122047!
        Me.txt備考.Name = "txt備考"
        Me.txt備考.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: justify; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt備考.Text = "あああああいいいいい"
        Me.txt備考.Top = 0.00000005960464!
        Me.txt備考.Width = 1.456693!
        '
        'txt本台帳No
        '
        Me.txt本台帳No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt本台帳No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt本台帳No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt本台帳No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt本台帳No.Height = 0.2952756!
        Me.txt本台帳No.Left = 3.070867!
        Me.txt本台帳No.Name = "txt本台帳No"
        Me.txt本台帳No.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt本台帳No.Text = "123456" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.txt本台帳No.Top = 0.00000005960464!
        Me.txt本台帳No.Width = 0.7283465!
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtNow, Me.txt頁})
        Me.PageHeader.Height = 0.3668387!
        Me.PageHeader.Name = "PageHeader"
        '
        'txtNow
        '
        Me.txtNow.Height = 0.2362205!
        Me.txtNow.Left = 4.872444!
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
        Me.txt頁.Left = 7.138977!
        Me.txt頁.Name = "txt頁"
        Me.txt頁.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt頁.Text = "頁"
        Me.txt頁.Top = 0.0!
        Me.txt頁.Width = 0.3795285!
        '
        'txtタイトル
        '
        Me.txtタイトル.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txtタイトル.Height = 0.3149606!
        Me.txtタイトル.Left = 1.987402!
        Me.txtタイトル.Name = "txtタイトル"
        Me.txtタイトル.Style = "font-family: ＭＳ 明朝; font-size: 16pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txtタイトル.Text = "得意先別廃棄本台帳ﾋﾟｯｸｱｯﾌﾟﾘｽﾄ"
        Me.txtタイトル.Top = 0.0!
        Me.txtタイトル.Width = 3.515355!
        '
        'lbl得意先コード
        '
        Me.lbl得意先コード.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先コード.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先コード.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先コード.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先コード.Height = 0.3346457!
        Me.lbl得意先コード.HyperLink = Nothing
        Me.lbl得意先コード.Left = 0.0!
        Me.lbl得意先コード.Name = "lbl得意先コード"
        Me.lbl得意先コード.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl得意先コード.Text = "得意先" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "コード"
        Me.lbl得意先コード.Top = 0.3866142!
        Me.lbl得意先コード.Width = 0.7480315!
        '
        'lbl得意先名
        '
        Me.lbl得意先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Height = 0.3346457!
        Me.lbl得意先名.HyperLink = Nothing
        Me.lbl得意先名.Left = 0.7480315!
        Me.lbl得意先名.Name = "lbl得意先名"
        Me.lbl得意先名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl得意先名.Text = "得　意　先　名"
        Me.lbl得意先名.Top = 0.3866142!
        Me.lbl得意先名.Width = 2.322835!
        '
        'ｌｂｌ商品名
        '
        Me.ｌｂｌ商品名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ商品名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ商品名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ商品名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ｌｂｌ商品名.Height = 0.3346457!
        Me.ｌｂｌ商品名.HyperLink = Nothing
        Me.ｌｂｌ商品名.Left = 3.799213!
        Me.ｌｂｌ商品名.Name = "ｌｂｌ商品名"
        Me.ｌｂｌ商品名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.ｌｂｌ商品名.Text = "品　名"
        Me.ｌｂｌ商品名.Top = 0.3866142!
        Me.ｌｂｌ商品名.Width = 2.322835!
        '
        'lbl本台帳No
        '
        Me.lbl本台帳No.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl本台帳No.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl本台帳No.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl本台帳No.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl本台帳No.Height = 0.3346457!
        Me.lbl本台帳No.HyperLink = Nothing
        Me.lbl本台帳No.Left = 3.070867!
        Me.lbl本台帳No.Name = "lbl本台帳No"
        Me.lbl本台帳No.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl本台帳No.Text = "本台帳No"
        Me.lbl本台帳No.Top = 0.3866142!
        Me.lbl本台帳No.Width = 0.7283465!
        '
        'lbl備考
        '
        Me.lbl備考.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl備考.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl備考.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl備考.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl備考.Height = 0.3346457!
        Me.lbl備考.HyperLink = Nothing
        Me.lbl備考.Left = 6.122048!
        Me.lbl備考.Name = "lbl備考"
        Me.lbl備考.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl備考.Text = "備考"
        Me.lbl備考.Top = 0.3866142!
        Me.lbl備考.Width = 1.456693!
        '
        'PageFooter
        '
        Me.PageFooter.CanGrow = False
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.lbl得意先名, Me.lbl得意先コード, Me.txtタイトル, Me.ｌｂｌ商品名, Me.lbl本台帳No, Me.lbl備考})
        Me.GroupHeader1.Height = 0.7212598!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'grpFtr
        '
        Me.grpFtr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.txt合計, Me.TextBox5, Me.Label1})
        Me.grpFtr.Height = 0.2952756!
        Me.grpFtr.Name = "grpFtr"
        '
        'TextBox1
        '
        Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Height = 0.2952756!
        Me.TextBox1.Left = 0.0!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 0.7480313!
        '
        'TextBox2
        '
        Me.TextBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Height = 0.2952756!
        Me.TextBox2.Left = 0.7480313!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-align: middle; ddo" & _
    "-char-set: 1"
        Me.TextBox2.Top = 0.0!
        Me.TextBox2.Width = 2.322835!
        '
        'TextBox3
        '
        Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Height = 0.2952756!
        Me.TextBox3.Left = 3.070867!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.TextBox3.Top = 0.00000005960464!
        Me.TextBox3.Width = 0.7283465!
        '
        'txt合計
        '
        Me.txt合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt合計.Height = 0.2952756!
        Me.txt合計.Left = 3.799213!
        Me.txt合計.Name = "txt合計"
        Me.txt合計.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt合計.Text = "99件"
        Me.txt合計.Top = 0.00000005960464!
        Me.txt合計.Width = 2.322835!
        '
        'TextBox5
        '
        Me.TextBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Height = 0.2952756!
        Me.TextBox5.Left = 6.122047!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "font-family: ＭＳ 明朝; font-size: 9pt; text-align: justify; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.TextBox5.Top = 0.00000005960464!
        Me.TextBox5.Width = 1.456693!
        '
        'Label1
        '
        Me.Label1.Height = 0.1771654!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 3.859843!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.Label1.Text = "*合計"
        Me.Label1.Top = 0.05118111!
        Me.Label1.Width = 0.3937008!
        '
        'CustomerDeletePickupList
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 7.57874!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.grpFtr)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.txt得意先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt備考, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt本台帳No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtタイトル, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl得意先コード, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ｌｂｌ商品名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl本台帳No, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl備考, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents ｌｂｌ商品名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl得意先コード As DataDynamics.ActiveReports.Label
    Private WithEvents lbl得意先名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl本台帳No As DataDynamics.ActiveReports.Label
    Private WithEvents txt得意先CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl備考 As DataDynamics.ActiveReports.Label
    Private WithEvents txt得意先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt商品名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt備考 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt本台帳No As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtNow As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt頁 As DataDynamics.ActiveReports.TextBox
    Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents grpFtr As DataDynamics.ActiveReports.GroupFooter
    Public WithEvents txtタイトル As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
End Class
