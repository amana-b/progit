<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class PaperPasteMountOrderList
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(PaperPasteMountOrderList))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt台紙名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総m数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt糊名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt紙CD = New DataDynamics.ActiveReports.TextBox()
        Me.txt紙名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt受注件数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt糊CD = New DataDynamics.ActiveReports.TextBox()
        Me.txt台紙CD = New DataDynamics.ActiveReports.TextBox()
        Me.txt受注数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt巾 = New DataDynamics.ActiveReports.TextBox()
        Me.txt受注通数 = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.txtNow = New DataDynamics.ActiveReports.TextBox()
        Me.txt頁 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr = New DataDynamics.ActiveReports.GroupHeader()
        Me.txt紙糊台紙巾別受注集計表 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl台紙 = New DataDynamics.ActiveReports.Label()
        Me.lbl総m数 = New DataDynamics.ActiveReports.Label()
        Me.lbl紙 = New DataDynamics.ActiveReports.Label()
        Me.lbl糊 = New DataDynamics.ActiveReports.Label()
        Me.lbl受注件数 = New DataDynamics.ActiveReports.Label()
        Me.lbl受注数 = New DataDynamics.ActiveReports.Label()
        Me.lbl受注通数 = New DataDynamics.ActiveReports.Label()
        Me.lbl巾 = New DataDynamics.ActiveReports.Label()
        Me.lbl受注日 = New DataDynamics.ActiveReports.Label()
        Me.txt受注日 = New DataDynamics.ActiveReports.TextBox()
        Me.grpFtr計 = New DataDynamics.ActiveReports.GroupFooter()
        Me.txt総m数総合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt受注件数総合計 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox11 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入合計 = New DataDynamics.ActiveReports.TextBox()
        Me.ttxt受注数総合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt通数m合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入運賃他合計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt受注通数総合計 = New DataDynamics.ActiveReports.TextBox()
        Me.Label4 = New DataDynamics.ActiveReports.Label()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader()
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter()
        Me.txt紙受注数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt紙総m数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt紙受注件数 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox30 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入担当者計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt通数担当者計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入運賃他担当者計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt紙受注通数 = New DataDynamics.ActiveReports.TextBox()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.GroupHeader2 = New DataDynamics.ActiveReports.GroupHeader()
        Me.GroupFooter2 = New DataDynamics.ActiveReports.GroupFooter()
        Me.txt糊受注数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt糊総m数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt糊受注件数 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox8 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入得意先計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt通数得意先計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt仕入運賃他得意先計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt糊受注通数 = New DataDynamics.ActiveReports.TextBox()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.GroupHeader3 = New DataDynamics.ActiveReports.GroupHeader()
        Me.GroupFooter3 = New DataDynamics.ActiveReports.GroupFooter()
        Me.txt台紙受注通数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt台紙受注数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt台紙総m数 = New DataDynamics.ActiveReports.TextBox()
        Me.txt台紙受注件数 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox10 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox13 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox15 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.txt台紙名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総m数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt糊名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt紙CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt紙名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt受注件数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt糊CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt台紙CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt受注数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt巾, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt受注通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt紙糊台紙巾別受注集計表, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl台紙, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl総m数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl紙, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl糊, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl受注件数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl受注数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl受注通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl巾, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl受注日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt受注日, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総m数総合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt受注件数総合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ttxt受注数総合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt通数m合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入運賃他合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt受注通数総合計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt紙受注数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt紙総m数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt紙受注件数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入担当者計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt通数担当者計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入運賃他担当者計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt紙受注通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt糊受注数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt糊総m数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt糊受注件数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入得意先計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt通数得意先計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt仕入運賃他得意先計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt糊受注通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt台紙受注通数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt台紙受注数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt台紙総m数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt台紙受注件数, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt台紙名, Me.txt総m数, Me.txt糊名, Me.txt紙CD, Me.txt紙名, Me.txt受注件数, Me.txt糊CD, Me.txt台紙CD, Me.txt受注数, Me.txt巾, Me.txt受注通数})
        Me.Detail.Height = 0.2755905!
        Me.Detail.KeepTogether = True
        Me.Detail.Name = "Detail"
        Me.Detail.RepeatToFill = True
        '
        'txt台紙名
        '
        Me.txt台紙名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt台紙名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt台紙名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt台紙名.Height = 0.2755905!
        Me.txt台紙名.Left = 3.917323!
        Me.txt台紙名.Name = "txt台紙名"
        Me.txt台紙名.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: justify; vertical-align: middle;" & _
    " ddo-char-set: 1"
        Me.txt台紙名.Text = "あああああ"
        Me.txt台紙名.Top = 0.0!
        Me.txt台紙名.Width = 1.200787!
        '
        'txt総m数
        '
        Me.txt総m数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総m数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総m数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総m数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総m数.Height = 0.2755905!
        Me.txt総m数.Left = 6.811024!
        Me.txt総m数.Name = "txt総m数"
        Me.txt総m数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt総m数.Text = "999,999,999"
        Me.txt総m数.Top = 0.000001132488!
        Me.txt総m数.Width = 1.377953!
        '
        'txt糊名
        '
        Me.txt糊名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt糊名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt糊名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt糊名.Height = 0.2755905!
        Me.txt糊名.Left = 2.480315!
        Me.txt糊名.Name = "txt糊名"
        Me.txt糊名.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: justify; vertical-align: middle;" & _
    " ddo-char-set: 1"
        Me.txt糊名.Text = "あああああ"
        Me.txt糊名.Top = 0.0!
        Me.txt糊名.Width = 1.043307!
        '
        'txt紙CD
        '
        Me.txt紙CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙CD.Height = 0.2755905!
        Me.txt紙CD.Left = 0.0!
        Me.txt紙CD.Name = "txt紙CD"
        Me.txt紙CD.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt紙CD.Text = "1234"
        Me.txt紙CD.Top = 0.00000005960464!
        Me.txt紙CD.Width = 0.4330709!
        '
        'txt紙名
        '
        Me.txt紙名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙名.Height = 0.2755905!
        Me.txt紙名.Left = 0.4330709!
        Me.txt紙名.Name = "txt紙名"
        Me.txt紙名.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: justify; vertical-align: middle;" & _
    " ddo-char-set: 1"
        Me.txt紙名.Text = "あああああいいい"
        Me.txt紙名.Top = 0.0!
        Me.txt紙名.Width = 1.614173!
        '
        'txt受注件数
        '
        Me.txt受注件数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注件数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注件数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注件数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注件数.Height = 0.2755905!
        Me.txt受注件数.Left = 5.787402!
        Me.txt受注件数.Name = "txt受注件数"
        Me.txt受注件数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt受注件数.Text = "999"
        Me.txt受注件数.Top = 0.0000002980233!
        Me.txt受注件数.Width = 1.023622!
        '
        'txt糊CD
        '
        Me.txt糊CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt糊CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt糊CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt糊CD.Height = 0.2755905!
        Me.txt糊CD.Left = 2.047244!
        Me.txt糊CD.Name = "txt糊CD"
        Me.txt糊CD.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt糊CD.Text = "123"
        Me.txt糊CD.Top = 0.0000002980233!
        Me.txt糊CD.Width = 0.4330709!
        '
        'txt台紙CD
        '
        Me.txt台紙CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt台紙CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt台紙CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt台紙CD.Height = 0.2755905!
        Me.txt台紙CD.Left = 3.523622!
        Me.txt台紙CD.Name = "txt台紙CD"
        Me.txt台紙CD.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt台紙CD.Text = "12"
        Me.txt台紙CD.Top = 0.0!
        Me.txt台紙CD.Width = 0.3937008!
        '
        'txt受注数
        '
        Me.txt受注数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注数.Height = 0.2755905!
        Me.txt受注数.Left = 8.188976!
        Me.txt受注数.Name = "txt受注数"
        Me.txt受注数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt受注数.Text = "999,999,999"
        Me.txt受注数.Top = 0.0!
        Me.txt受注数.Width = 1.377953!
        '
        'txt巾
        '
        Me.txt巾.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt巾.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt巾.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt巾.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt巾.Height = 0.2755905!
        Me.txt巾.Left = 5.11811!
        Me.txt巾.Name = "txt巾"
        Me.txt巾.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt巾.Text = "999"
        Me.txt巾.Top = 0.0!
        Me.txt巾.Width = 0.6692914!
        '
        'txt受注通数
        '
        Me.txt受注通数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注通数.Height = 0.2755905!
        Me.txt受注通数.Left = 9.566929!
        Me.txt受注通数.Name = "txt受注通数"
        Me.txt受注通数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt受注通数.Text = "999,999"
        Me.txt受注通数.Top = 0.0!
        Me.txt受注通数.Width = 1.377953!
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txtNow, Me.txt頁})
        Me.PageHeader.Height = 0.2362205!
        Me.PageHeader.Name = "PageHeader"
        '
        'txtNow
        '
        Me.txtNow.Height = 0.2362205!
        Me.txtNow.Left = 7.574792!
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
        Me.txt頁.Left = 9.718505!
        Me.txt頁.Name = "txt頁"
        Me.txt頁.Style = "font-family: ＭＳ 明朝; font-size: 10pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt頁.Text = "頁"
        Me.txt頁.Top = 0.0!
        Me.txt頁.Width = 0.379528!
        '
        'PageFooter
        '
        Me.PageFooter.CanGrow = False
        Me.PageFooter.Height = 0.0!
        Me.PageFooter.Name = "PageFooter"
        '
        'grpHdr
        '
        Me.grpHdr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt紙糊台紙巾別受注集計表, Me.lbl台紙, Me.lbl総m数, Me.lbl紙, Me.lbl糊, Me.lbl受注件数, Me.lbl受注数, Me.lbl受注通数, Me.lbl巾, Me.lbl受注日, Me.txt受注日})
        Me.grpHdr.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr.Height = 0.9992127!
        Me.grpHdr.Name = "grpHdr"
        Me.grpHdr.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'txt紙糊台紙巾別受注集計表
        '
        Me.txt紙糊台紙巾別受注集計表.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt紙糊台紙巾別受注集計表.CharacterSpacing = 10.0!
        Me.txt紙糊台紙巾別受注集計表.Height = 0.2362205!
        Me.txt紙糊台紙巾別受注集計表.Left = 4.514174!
        Me.txt紙糊台紙巾別受注集計表.Name = "txt紙糊台紙巾別受注集計表"
        Me.txt紙糊台紙巾別受注集計表.Style = "font-family: ＭＳ Ｐゴシック; font-size: 14pt; font-weight: bold; text-align: center; ve" & _
    "rtical-align: bottom; ddo-char-set: 1"
        Me.txt紙糊台紙巾別受注集計表.Text = "紙・糊・台紙巾別受注集計表"
        Me.txt紙糊台紙巾別受注集計表.Top = 0.1968504!
        Me.txt紙糊台紙巾別受注集計表.Width = 4.370079!
        '
        'lbl台紙
        '
        Me.lbl台紙.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl台紙.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl台紙.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl台紙.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl台紙.Height = 0.3346457!
        Me.lbl台紙.HyperLink = Nothing
        Me.lbl台紙.Left = 3.523622!
        Me.lbl台紙.Name = "lbl台紙"
        Me.lbl台紙.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl台紙.Text = "台紙"
        Me.lbl台紙.Top = 0.664567!
        Me.lbl台紙.Width = 1.594488!
        '
        'lbl総m数
        '
        Me.lbl総m数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl総m数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl総m数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl総m数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl総m数.Height = 0.3346457!
        Me.lbl総m数.HyperLink = Nothing
        Me.lbl総m数.Left = 6.811024!
        Me.lbl総m数.Name = "lbl総m数"
        Me.lbl総m数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl総m数.Text = "総m数"
        Me.lbl総m数.Top = 0.664567!
        Me.lbl総m数.Width = 1.377953!
        '
        'lbl紙
        '
        Me.lbl紙.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl紙.CharacterSpacing = 5.0!
        Me.lbl紙.Height = 0.3346457!
        Me.lbl紙.HyperLink = Nothing
        Me.lbl紙.Left = 0.0!
        Me.lbl紙.Name = "lbl紙"
        Me.lbl紙.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl紙.Text = "紙"
        Me.lbl紙.Top = 0.664567!
        Me.lbl紙.Width = 2.047244!
        '
        'lbl糊
        '
        Me.lbl糊.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl糊.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl糊.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl糊.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl糊.Height = 0.3346457!
        Me.lbl糊.HyperLink = Nothing
        Me.lbl糊.Left = 2.047244!
        Me.lbl糊.Name = "lbl糊"
        Me.lbl糊.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl糊.Text = "糊"
        Me.lbl糊.Top = 0.664567!
        Me.lbl糊.Width = 1.476378!
        '
        'lbl受注件数
        '
        Me.lbl受注件数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注件数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注件数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注件数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注件数.Height = 0.3346457!
        Me.lbl受注件数.HyperLink = Nothing
        Me.lbl受注件数.Left = 5.787402!
        Me.lbl受注件数.Name = "lbl受注件数"
        Me.lbl受注件数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl受注件数.Text = "受注件数"
        Me.lbl受注件数.Top = 0.664567!
        Me.lbl受注件数.Width = 1.023622!
        '
        'lbl受注数
        '
        Me.lbl受注数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注数.Height = 0.3346457!
        Me.lbl受注数.HyperLink = Nothing
        Me.lbl受注数.Left = 8.188976!
        Me.lbl受注数.Name = "lbl受注数"
        Me.lbl受注数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl受注数.Text = "受注数"
        Me.lbl受注数.Top = 0.664567!
        Me.lbl受注数.Width = 1.377953!
        '
        'lbl受注通数
        '
        Me.lbl受注通数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl受注通数.Height = 0.3346457!
        Me.lbl受注通数.HyperLink = Nothing
        Me.lbl受注通数.Left = 9.566929!
        Me.lbl受注通数.Name = "lbl受注通数"
        Me.lbl受注通数.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl受注通数.Text = "受注通数"
        Me.lbl受注通数.Top = 0.664567!
        Me.lbl受注通数.Width = 1.377953!
        '
        'lbl巾
        '
        Me.lbl巾.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl巾.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl巾.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl巾.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl巾.Height = 0.3346457!
        Me.lbl巾.HyperLink = Nothing
        Me.lbl巾.Left = 5.11811!
        Me.lbl巾.Name = "lbl巾"
        Me.lbl巾.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl巾.Text = "巾"
        Me.lbl巾.Top = 0.664567!
        Me.lbl巾.Width = 0.6692914!
        '
        'lbl受注日
        '
        Me.lbl受注日.Height = 0.2362205!
        Me.lbl受注日.HyperLink = Nothing
        Me.lbl受注日.Left = 0.0!
        Me.lbl受注日.Name = "lbl受注日"
        Me.lbl受注日.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl受注日.Text = "受注日"
        Me.lbl受注日.Top = 0.0!
        Me.lbl受注日.Width = 0.7874014!
        '
        'txt受注日
        '
        Me.txt受注日.Height = 0.2362205!
        Me.txt受注日.Left = 0.7874014!
        Me.txt受注日.Name = "txt受注日"
        Me.txt受注日.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt受注日.Text = "00/00/00～99/99/99　日迄"
        Me.txt受注日.Top = 0.0!
        Me.txt受注日.Width = 2.150394!
        '
        'grpFtr計
        '
        Me.grpFtr計.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt総m数総合計, Me.txt受注件数総合計, Me.TextBox11, Me.txt仕入合計, Me.ttxt受注数総合計, Me.txt通数m合計, Me.txt仕入運賃他合計, Me.txt受注通数総合計, Me.Label4})
        Me.grpFtr計.Height = 0.2755905!
        Me.grpFtr計.Name = "grpFtr計"
        '
        'txt総m数総合計
        '
        Me.txt総m数総合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総m数総合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総m数総合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総m数総合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総m数総合計.Height = 0.2755905!
        Me.txt総m数総合計.Left = 6.811024!
        Me.txt総m数総合計.Name = "txt総m数総合計"
        Me.txt総m数総合計.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt総m数総合計.Text = "999,999,999"
        Me.txt総m数総合計.Top = 0.0!
        Me.txt総m数総合計.Width = 1.377953!
        '
        'txt受注件数総合計
        '
        Me.txt受注件数総合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注件数総合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注件数総合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注件数総合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注件数総合計.Height = 0.2755905!
        Me.txt受注件数総合計.Left = 5.787402!
        Me.txt受注件数総合計.Name = "txt受注件数総合計"
        Me.txt受注件数総合計.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt受注件数総合計.Text = "999"
        Me.txt受注件数総合計.Top = 0.0!
        Me.txt受注件数総合計.Width = 1.023622!
        '
        'TextBox11
        '
        Me.TextBox11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Height = 0.2755905!
        Me.TextBox11.Left = 0.0!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.TextBox11.Text = Nothing
        Me.TextBox11.Top = 0.0!
        Me.TextBox11.Width = 2.047244!
        '
        'txt仕入合計
        '
        Me.txt仕入合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入合計.Height = 0.2755905!
        Me.txt仕入合計.Left = 3.523622!
        Me.txt仕入合計.Name = "txt仕入合計"
        Me.txt仕入合計.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt仕入合計.Text = "件"
        Me.txt仕入合計.Top = 0.0!
        Me.txt仕入合計.Width = 1.594488!
        '
        'ttxt受注数総合計
        '
        Me.ttxt受注数総合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ttxt受注数総合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ttxt受注数総合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ttxt受注数総合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.ttxt受注数総合計.Height = 0.2755905!
        Me.ttxt受注数総合計.Left = 8.188976!
        Me.ttxt受注数総合計.Name = "ttxt受注数総合計"
        Me.ttxt受注数総合計.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.ttxt受注数総合計.Text = "999,999,999"
        Me.ttxt受注数総合計.Top = 0.0!
        Me.ttxt受注数総合計.Width = 1.377953!
        '
        'txt通数m合計
        '
        Me.txt通数m合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数m合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数m合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数m合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数m合計.Height = 0.2755905!
        Me.txt通数m合計.Left = 2.047244!
        Me.txt通数m合計.Name = "txt通数m合計"
        Me.txt通数m合計.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt通数m合計.Text = Nothing
        Me.txt通数m合計.Top = 0.0!
        Me.txt通数m合計.Width = 1.476378!
        '
        'txt仕入運賃他合計
        '
        Me.txt仕入運賃他合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入運賃他合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入運賃他合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入運賃他合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入運賃他合計.Height = 0.2755905!
        Me.txt仕入運賃他合計.Left = 5.11811!
        Me.txt仕入運賃他合計.Name = "txt仕入運賃他合計"
        Me.txt仕入運賃他合計.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt仕入運賃他合計.Text = Nothing
        Me.txt仕入運賃他合計.Top = 0.0!
        Me.txt仕入運賃他合計.Width = 0.6692914!
        '
        'txt受注通数総合計
        '
        Me.txt受注通数総合計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注通数総合計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注通数総合計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注通数総合計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt受注通数総合計.Height = 0.2755905!
        Me.txt受注通数総合計.Left = 9.566929!
        Me.txt受注通数総合計.Name = "txt受注通数総合計"
        Me.txt受注通数総合計.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt受注通数総合計.Text = "999,999"
        Me.txt受注通数総合計.Top = 0.0!
        Me.txt受注通数総合計.Width = 1.377953!
        '
        'Label4
        '
        Me.Label4.Height = 0.1771654!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 3.900787!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; font-weight: bold; text-align: " & _
    "right; vertical-align: bottom; ddo-char-set: 1"
        Me.Label4.Text = "＊総合計"
        Me.Label4.Top = 0.05118111!
        Me.Label4.Width = 0.5314961!
        '
        'Label2
        '
        Me.Label2.Height = 0.1771654!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 3.900788!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; font-weight: bold; text-align: " & _
    "right; vertical-align: bottom; ddo-char-set: 1"
        Me.Label2.Text = "＊紙計"
        Me.Label2.Top = 0.05118111!
        Me.Label2.Width = 0.5314961!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Height = 0.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt紙受注数, Me.txt紙総m数, Me.txt紙受注件数, Me.TextBox30, Me.txt仕入担当者計, Me.txt通数担当者計, Me.txt仕入運賃他担当者計, Me.txt紙受注通数, Me.Label2})
        Me.GroupFooter1.Height = 0.2755905!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'txt紙受注数
        '
        Me.txt紙受注数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙受注数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙受注数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙受注数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙受注数.Height = 0.2755905!
        Me.txt紙受注数.Left = 8.188976!
        Me.txt紙受注数.Name = "txt紙受注数"
        Me.txt紙受注数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt紙受注数.Text = "999,999,999"
        Me.txt紙受注数.Top = 0.0!
        Me.txt紙受注数.Width = 1.377953!
        '
        'txt紙総m数
        '
        Me.txt紙総m数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙総m数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙総m数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙総m数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙総m数.Height = 0.2755905!
        Me.txt紙総m数.Left = 6.811024!
        Me.txt紙総m数.Name = "txt紙総m数"
        Me.txt紙総m数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt紙総m数.Text = "999,999,999"
        Me.txt紙総m数.Top = 0.0!
        Me.txt紙総m数.Width = 1.377953!
        '
        'txt紙受注件数
        '
        Me.txt紙受注件数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙受注件数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙受注件数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙受注件数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙受注件数.Height = 0.2755905!
        Me.txt紙受注件数.Left = 5.787402!
        Me.txt紙受注件数.Name = "txt紙受注件数"
        Me.txt紙受注件数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt紙受注件数.Text = "999"
        Me.txt紙受注件数.Top = 0.0!
        Me.txt紙受注件数.Width = 1.023622!
        '
        'TextBox30
        '
        Me.TextBox30.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox30.Height = 0.2755905!
        Me.TextBox30.Left = 0.0!
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.TextBox30.Text = Nothing
        Me.TextBox30.Top = 0.0!
        Me.TextBox30.Width = 2.047244!
        '
        'txt仕入担当者計
        '
        Me.txt仕入担当者計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入担当者計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入担当者計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入担当者計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入担当者計.Height = 0.2755905!
        Me.txt仕入担当者計.Left = 3.523622!
        Me.txt仕入担当者計.Name = "txt仕入担当者計"
        Me.txt仕入担当者計.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt仕入担当者計.Text = "件"
        Me.txt仕入担当者計.Top = 0.0!
        Me.txt仕入担当者計.Width = 1.594488!
        '
        'txt通数担当者計
        '
        Me.txt通数担当者計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数担当者計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数担当者計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数担当者計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数担当者計.Height = 0.2755905!
        Me.txt通数担当者計.Left = 2.047244!
        Me.txt通数担当者計.Name = "txt通数担当者計"
        Me.txt通数担当者計.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt通数担当者計.Text = Nothing
        Me.txt通数担当者計.Top = 0.0!
        Me.txt通数担当者計.Width = 1.476378!
        '
        'txt仕入運賃他担当者計
        '
        Me.txt仕入運賃他担当者計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入運賃他担当者計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入運賃他担当者計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入運賃他担当者計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入運賃他担当者計.Height = 0.2755905!
        Me.txt仕入運賃他担当者計.Left = 5.11811!
        Me.txt仕入運賃他担当者計.Name = "txt仕入運賃他担当者計"
        Me.txt仕入運賃他担当者計.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt仕入運賃他担当者計.Text = Nothing
        Me.txt仕入運賃他担当者計.Top = 0.0!
        Me.txt仕入運賃他担当者計.Width = 0.6692914!
        '
        'txt紙受注通数
        '
        Me.txt紙受注通数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙受注通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙受注通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙受注通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt紙受注通数.Height = 0.2755905!
        Me.txt紙受注通数.Left = 9.566929!
        Me.txt紙受注通数.Name = "txt紙受注通数"
        Me.txt紙受注通数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt紙受注通数.Text = "999,999"
        Me.txt紙受注通数.Top = 0.0!
        Me.txt紙受注通数.Width = 1.377953!
        '
        'Label3
        '
        Me.Label3.Height = 0.1771654!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 3.900787!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; font-weight: bold; text-align: " & _
    "right; vertical-align: bottom; ddo-char-set: 1"
        Me.Label3.Text = "＊糊計"
        Me.Label3.Top = 0.05118111!
        Me.Label3.Width = 0.5314961!
        '
        'GroupHeader2
        '
        Me.GroupHeader2.Height = 0.0!
        Me.GroupHeader2.Name = "GroupHeader2"
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt糊受注数, Me.txt糊総m数, Me.txt糊受注件数, Me.TextBox8, Me.txt仕入得意先計, Me.txt通数得意先計, Me.txt仕入運賃他得意先計, Me.txt糊受注通数, Me.Label3})
        Me.GroupFooter2.Height = 0.2755905!
        Me.GroupFooter2.Name = "GroupFooter2"
        '
        'txt糊受注数
        '
        Me.txt糊受注数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt糊受注数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt糊受注数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt糊受注数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt糊受注数.Height = 0.2755905!
        Me.txt糊受注数.Left = 8.188976!
        Me.txt糊受注数.Name = "txt糊受注数"
        Me.txt糊受注数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt糊受注数.Text = "999,999,999"
        Me.txt糊受注数.Top = 0.0!
        Me.txt糊受注数.Width = 1.377953!
        '
        'txt糊総m数
        '
        Me.txt糊総m数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt糊総m数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt糊総m数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt糊総m数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt糊総m数.Height = 0.2755905!
        Me.txt糊総m数.Left = 6.811024!
        Me.txt糊総m数.Name = "txt糊総m数"
        Me.txt糊総m数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt糊総m数.Text = "999,999,999"
        Me.txt糊総m数.Top = 0.0!
        Me.txt糊総m数.Width = 1.377953!
        '
        'txt糊受注件数
        '
        Me.txt糊受注件数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt糊受注件数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt糊受注件数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt糊受注件数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt糊受注件数.Height = 0.2755905!
        Me.txt糊受注件数.Left = 5.787402!
        Me.txt糊受注件数.Name = "txt糊受注件数"
        Me.txt糊受注件数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt糊受注件数.Text = "999"
        Me.txt糊受注件数.Top = 0.0000002980233!
        Me.txt糊受注件数.Width = 1.023622!
        '
        'TextBox8
        '
        Me.TextBox8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox8.Height = 0.2755905!
        Me.TextBox8.Left = 0.0!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.TextBox8.Text = Nothing
        Me.TextBox8.Top = 0.0!
        Me.TextBox8.Width = 2.047244!
        '
        'txt仕入得意先計
        '
        Me.txt仕入得意先計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入得意先計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入得意先計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入得意先計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入得意先計.Height = 0.2755905!
        Me.txt仕入得意先計.Left = 3.523622!
        Me.txt仕入得意先計.Name = "txt仕入得意先計"
        Me.txt仕入得意先計.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt仕入得意先計.Text = "件"
        Me.txt仕入得意先計.Top = 0.0!
        Me.txt仕入得意先計.Width = 1.594488!
        '
        'txt通数得意先計
        '
        Me.txt通数得意先計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数得意先計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数得意先計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数得意先計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt通数得意先計.Height = 0.2755905!
        Me.txt通数得意先計.Left = 2.047244!
        Me.txt通数得意先計.Name = "txt通数得意先計"
        Me.txt通数得意先計.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: middle; " & _
    "ddo-char-set: 1"
        Me.txt通数得意先計.Text = Nothing
        Me.txt通数得意先計.Top = 0.0!
        Me.txt通数得意先計.Width = 1.476378!
        '
        'txt仕入運賃他得意先計
        '
        Me.txt仕入運賃他得意先計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入運賃他得意先計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入運賃他得意先計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入運賃他得意先計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt仕入運賃他得意先計.Height = 0.2755905!
        Me.txt仕入運賃他得意先計.Left = 5.11811!
        Me.txt仕入運賃他得意先計.Name = "txt仕入運賃他得意先計"
        Me.txt仕入運賃他得意先計.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt仕入運賃他得意先計.Text = Nothing
        Me.txt仕入運賃他得意先計.Top = 0.0!
        Me.txt仕入運賃他得意先計.Width = 0.6692914!
        '
        'txt糊受注通数
        '
        Me.txt糊受注通数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt糊受注通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt糊受注通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt糊受注通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt糊受注通数.Height = 0.2755905!
        Me.txt糊受注通数.Left = 9.566929!
        Me.txt糊受注通数.Name = "txt糊受注通数"
        Me.txt糊受注通数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt糊受注通数.Text = "999,999"
        Me.txt糊受注通数.Top = 0.00000002980232!
        Me.txt糊受注通数.Width = 1.377953!
        '
        'Label1
        '
        Me.Label1.Height = 0.1771654!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 3.900788!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; font-weight: bold; text-align: " & _
    "right; vertical-align: bottom; ddo-char-set: 1"
        Me.Label1.Text = "＊台紙計"
        Me.Label1.Top = 0.05118111!
        Me.Label1.Width = 0.5314961!
        '
        'GroupHeader3
        '
        Me.GroupHeader3.Height = 0.0!
        Me.GroupHeader3.Name = "GroupHeader3"
        '
        'GroupFooter3
        '
        Me.GroupFooter3.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt台紙受注通数, Me.txt台紙受注数, Me.txt台紙総m数, Me.txt台紙受注件数, Me.TextBox6, Me.TextBox10, Me.TextBox13, Me.TextBox15, Me.Label1})
        Me.GroupFooter3.Height = 0.2755906!
        Me.GroupFooter3.Name = "GroupFooter3"
        '
        'txt台紙受注通数
        '
        Me.txt台紙受注通数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt台紙受注通数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt台紙受注通数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt台紙受注通数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt台紙受注通数.Height = 0.2755906!
        Me.txt台紙受注通数.Left = 9.566929!
        Me.txt台紙受注通数.Name = "txt台紙受注通数"
        Me.txt台紙受注通数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt台紙受注通数.Text = "999,999"
        Me.txt台紙受注通数.Top = 0.0!
        Me.txt台紙受注通数.Width = 1.377953!
        '
        'txt台紙受注数
        '
        Me.txt台紙受注数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt台紙受注数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt台紙受注数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt台紙受注数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt台紙受注数.Height = 0.2755906!
        Me.txt台紙受注数.Left = 8.188976!
        Me.txt台紙受注数.Name = "txt台紙受注数"
        Me.txt台紙受注数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt台紙受注数.Text = "999,999,999"
        Me.txt台紙受注数.Top = 0.0!
        Me.txt台紙受注数.Width = 1.377953!
        '
        'txt台紙総m数
        '
        Me.txt台紙総m数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt台紙総m数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt台紙総m数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt台紙総m数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt台紙総m数.Height = 0.2755906!
        Me.txt台紙総m数.Left = 6.811024!
        Me.txt台紙総m数.Name = "txt台紙総m数"
        Me.txt台紙総m数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt台紙総m数.Text = "999,999,999"
        Me.txt台紙総m数.Top = 0.0!
        Me.txt台紙総m数.Width = 1.377953!
        '
        'txt台紙受注件数
        '
        Me.txt台紙受注件数.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt台紙受注件数.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt台紙受注件数.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt台紙受注件数.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt台紙受注件数.Height = 0.2755906!
        Me.txt台紙受注件数.Left = 5.787402!
        Me.txt台紙受注件数.Name = "txt台紙受注件数"
        Me.txt台紙受注件数.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.txt台紙受注件数.Text = "999"
        Me.txt台紙受注件数.Top = 0.0!
        Me.txt台紙受注件数.Width = 1.023622!
        '
        'TextBox6
        '
        Me.TextBox6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Height = 0.2755906!
        Me.TextBox6.Left = 5.11811!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.TextBox6.Text = Nothing
        Me.TextBox6.Top = 0.0!
        Me.TextBox6.Width = 0.6692914!
        '
        'TextBox10
        '
        Me.TextBox10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Height = 0.2755905!
        Me.TextBox10.Left = 3.523622!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.TextBox10.Text = "件"
        Me.TextBox10.Top = 0.0!
        Me.TextBox10.Width = 1.594488!
        '
        'TextBox13
        '
        Me.TextBox13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox13.Height = 0.2755905!
        Me.TextBox13.Left = 2.047244!
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.TextBox13.Text = Nothing
        Me.TextBox13.Top = 0.0!
        Me.TextBox13.Width = 1.476378!
        '
        'TextBox15
        '
        Me.TextBox15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox15.Height = 0.2755905!
        Me.TextBox15.Left = 0.0!
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: right; vertical-align: middle; d" & _
    "do-char-set: 1"
        Me.TextBox15.Text = Nothing
        Me.TextBox15.Top = 0.0!
        Me.TextBox15.Width = 2.047244!
        '
        'PaperPasteMountOrderList
        '
        Me.MasterReport = False
        Me.PageSettings.Margins.Bottom = 0.2755905!
        Me.PageSettings.Margins.Left = 0.2755905!
        Me.PageSettings.Margins.Right = 0.2755905!
        Me.PageSettings.Margins.Top = 0.5905512!
        Me.PageSettings.PaperHeight = 11.0!
        Me.PageSettings.PaperWidth = 8.5!
        Me.PrintWidth = 10.92913!
        Me.Sections.Add(Me.PageHeader)
        Me.Sections.Add(Me.grpHdr)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.GroupHeader2)
        Me.Sections.Add(Me.GroupHeader3)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.GroupFooter3)
        Me.Sections.Add(Me.GroupFooter2)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.grpFtr計)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.txt台紙名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総m数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt糊名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt紙CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt紙名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt受注件数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt糊CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt台紙CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt受注数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt巾, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt受注通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt紙糊台紙巾別受注集計表, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl台紙, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl総m数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl紙, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl糊, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl受注件数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl受注数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl受注通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl巾, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl受注日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt受注日, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総m数総合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt受注件数総合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ttxt受注数総合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt通数m合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入運賃他合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt受注通数総合計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt紙受注数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt紙総m数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt紙受注件数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入担当者計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt通数担当者計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入運賃他担当者計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt紙受注通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt糊受注数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt糊総m数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt糊受注件数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入得意先計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt通数得意先計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt仕入運賃他得意先計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt糊受注通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt台紙受注通数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt台紙受注数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt台紙総m数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt台紙受注件数, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txt台紙名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総m数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt糊名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt紙CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt紙名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtNow As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt頁 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt受注件数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt糊CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt台紙CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpHdr As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents txt紙糊台紙巾別受注集計表 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl台紙 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl紙 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl糊 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl受注件数 As DataDynamics.ActiveReports.Label
    Private WithEvents grpFtr計 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txt総m数総合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt受注件数総合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox11 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents txt受注数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl受注数 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl総m数 As DataDynamics.ActiveReports.Label
    Private WithEvents ttxt受注数総合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl受注通数 As DataDynamics.ActiveReports.Label
    Private WithEvents txt仕入合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txt巾 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl巾 As DataDynamics.ActiveReports.Label
    Private WithEvents txt通数m合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入運賃他合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt紙受注数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt紙総m数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt紙受注件数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox30 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入担当者計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents txt通数担当者計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入運賃他担当者計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents GroupHeader2 As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents GroupFooter2 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txt糊受注数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt糊総m数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt糊受注件数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox8 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入得意先計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents txt通数得意先計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt仕入運賃他得意先計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt受注通数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt受注通数総合計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt紙受注通数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt糊受注通数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl受注日 As DataDynamics.ActiveReports.Label
    Private WithEvents txt受注日 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label4 As DataDynamics.ActiveReports.Label
    Private WithEvents GroupHeader3 As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents GroupFooter3 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents txt台紙受注通数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt台紙受注数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt台紙総m数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt台紙受注件数 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox10 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox13 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox15 As DataDynamics.ActiveReports.TextBox
End Class
