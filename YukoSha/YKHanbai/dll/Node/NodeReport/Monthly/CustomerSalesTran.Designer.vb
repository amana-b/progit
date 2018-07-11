<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class CustomerSalesTran
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(CustomerSalesTran))
        Me.Detail = New DataDynamics.ActiveReports.Detail()
        Me.txt得意先CD = New DataDynamics.ActiveReports.TextBox()
        Me.txt得意先名 = New DataDynamics.ActiveReports.TextBox()
        Me.txt当年4月 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl当年 = New DataDynamics.ActiveReports.Label()
        Me.lbl前年 = New DataDynamics.ActiveReports.Label()
        Me.lbl対比 = New DataDynamics.ActiveReports.Label()
        Me.txt前年4月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt対比4月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt前年5月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt当年5月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt対比5月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt前年6月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt当年6月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt対比6月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt前年7月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt当年7月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt対比7月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt前年8月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt当年8月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt対比8月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt前年9月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt当年9月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt対比9月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt前年10月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt当年10月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt対比10月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt前年11月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt当年11月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt対比11月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt前年12月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt当年12月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt対比12月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt前年1月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt当年1月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt対比1月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt前年2月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt当年2月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt対比2月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt前年3月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt当年3月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt対比3月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt前年累計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt当年累計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt対比累計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt対比月平均 = New DataDynamics.ActiveReports.TextBox()
        Me.txt当年月平均 = New DataDynamics.ActiveReports.TextBox()
        Me.txt前年月平均 = New DataDynamics.ActiveReports.TextBox()
        Me.PageHeader = New DataDynamics.ActiveReports.PageHeader()
        Me.txtNow = New DataDynamics.ActiveReports.TextBox()
        Me.txt頁 = New DataDynamics.ActiveReports.TextBox()
        Me.PageFooter = New DataDynamics.ActiveReports.PageFooter()
        Me.grpHdr = New DataDynamics.ActiveReports.GroupHeader()
        Me.txt対象年月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者別未引当一覧表 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl8月 = New DataDynamics.ActiveReports.Label()
        Me.lbl10月 = New DataDynamics.ActiveReports.Label()
        Me.lbl得意先名 = New DataDynamics.ActiveReports.Label()
        Me.lbl得意先CD = New DataDynamics.ActiveReports.Label()
        Me.lbl6月 = New DataDynamics.ActiveReports.Label()
        Me.lbl9月 = New DataDynamics.ActiveReports.Label()
        Me.lbl7月 = New DataDynamics.ActiveReports.Label()
        Me.lbl11月 = New DataDynamics.ActiveReports.Label()
        Me.lbl12月 = New DataDynamics.ActiveReports.Label()
        Me.lbl担当者 = New DataDynamics.ActiveReports.Label()
        Me.txt担当者CD = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者名 = New DataDynamics.ActiveReports.TextBox()
        Me.lbl累計 = New DataDynamics.ActiveReports.Label()
        Me.lbl対象年月 = New DataDynamics.ActiveReports.Label()
        Me.Label1 = New DataDynamics.ActiveReports.Label()
        Me.lbl5月 = New DataDynamics.ActiveReports.Label()
        Me.Label5 = New DataDynamics.ActiveReports.Label()
        Me.lbl4月 = New DataDynamics.ActiveReports.Label()
        Me.lbl1月 = New DataDynamics.ActiveReports.Label()
        Me.lbl2月 = New DataDynamics.ActiveReports.Label()
        Me.lbl3月 = New DataDynamics.ActiveReports.Label()
        Me.lbl月平均 = New DataDynamics.ActiveReports.Label()
        Me.grpFtr計 = New DataDynamics.ActiveReports.GroupFooter()
        Me.TextBox87 = New DataDynamics.ActiveReports.TextBox()
        Me.Label2 = New DataDynamics.ActiveReports.Label()
        Me.TextBox86 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計当年4月 = New DataDynamics.ActiveReports.TextBox()
        Me.Label17 = New DataDynamics.ActiveReports.Label()
        Me.Label18 = New DataDynamics.ActiveReports.Label()
        Me.Label19 = New DataDynamics.ActiveReports.Label()
        Me.txt総合計前年4月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計対比4月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計前年5月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計当年5月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計対比5月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計前年6月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計当年6月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計対比6月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計前年7月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計当年7月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計対比7月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計前年8月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計当年8月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計対比8月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計前年9月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計当年9月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計対比9月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計前年10月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計当年10月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計対比10月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計前年11月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計当年11月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計対比11月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計前年12月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計当年12月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計対比12月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計前年1月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計当年1月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計対比1月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計前年2月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計当年2月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計対比2月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計前年3月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計当年3月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計対比3月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計前年累計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計当年累計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計対比累計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計対比月平均 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計当年月平均 = New DataDynamics.ActiveReports.TextBox()
        Me.txt総合計前年月平均 = New DataDynamics.ActiveReports.TextBox()
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader()
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter()
        Me.Label3 = New DataDynamics.ActiveReports.Label()
        Me.TextBox11 = New DataDynamics.ActiveReports.TextBox()
        Me.TextBox19 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者当年4月 = New DataDynamics.ActiveReports.TextBox()
        Me.Label14 = New DataDynamics.ActiveReports.Label()
        Me.Label15 = New DataDynamics.ActiveReports.Label()
        Me.Label16 = New DataDynamics.ActiveReports.Label()
        Me.txt担当者前年4月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者対比4月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者前年5月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者当年5月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者対比5月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者前年6月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者当年6月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者対比6月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者前年7月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者当年7月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者対比7月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者前年8月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者当年8月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者対比8月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者前年9月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者当年9月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者対比9月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者前年10月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者当年10月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者対比10月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者前年11月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者当年11月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者対比11月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者前年12月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者当年12月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者対比12月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者前年1月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者当年1月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者対比1月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者前年2月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者当年2月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者対比2月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者前年3月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者当年3月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者対比3月 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者前年累計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者当年月累計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者対比累計 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者対比月平均 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者当年月平均 = New DataDynamics.ActiveReports.TextBox()
        Me.txt担当者前年月平均 = New DataDynamics.ActiveReports.TextBox()
        CType(Me.txt得意先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt当年4月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl当年, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl前年, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl対比, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt前年4月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt対比4月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt前年5月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt当年5月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt対比5月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt前年6月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt当年6月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt対比6月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt前年7月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt当年7月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt対比7月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt前年8月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt当年8月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt対比8月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt前年9月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt当年9月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt対比9月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt前年10月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt当年10月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt対比10月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt前年11月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt当年11月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt対比11月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt前年12月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt当年12月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt対比12月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt前年1月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt当年1月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt対比1月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt前年2月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt当年2月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt対比2月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt前年3月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt当年3月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt対比3月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt前年累計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt当年累計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt対比累計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt対比月平均, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt当年月平均, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt前年月平均, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt対象年月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者別未引当一覧表, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl8月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl10月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl得意先名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl得意先CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl6月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl9月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl7月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl11月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl12月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl担当者, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者CD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者名, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl累計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl対象年月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl5月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl4月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl1月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl2月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl3月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lbl月平均, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox87, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox86, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計当年4月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計前年4月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計対比4月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計前年5月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計当年5月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計対比5月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計前年6月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計当年6月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計対比6月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計前年7月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計当年7月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計対比7月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計前年8月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計当年8月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計対比8月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計前年9月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計当年9月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計対比9月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計前年10月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計当年10月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計対比10月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計前年11月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計当年11月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計対比11月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計前年12月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計当年12月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計対比12月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計前年1月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計当年1月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計対比1月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計前年2月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計当年2月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計対比2月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計前年3月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計当年3月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計対比3月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計前年累計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計当年累計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計対比累計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計対比月平均, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計当年月平均, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt総合計前年月平均, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者当年4月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者前年4月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者対比4月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者前年5月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者当年5月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者対比5月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者前年6月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者当年6月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者対比6月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者前年7月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者当年7月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者対比7月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者前年8月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者当年8月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者対比8月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者前年9月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者当年9月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者対比9月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者前年10月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者当年10月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者対比10月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者前年11月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者当年11月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者対比11月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者前年12月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者当年12月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者対比12月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者前年1月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者当年1月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者対比1月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者前年2月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者当年2月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者対比2月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者前年3月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者当年3月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者対比3月, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者前年累計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者当年月累計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者対比累計, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者対比月平均, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者当年月平均, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt担当者前年月平均, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail
        '
        Me.Detail.ColumnSpacing = 0.0!
        Me.Detail.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt得意先CD, Me.txt得意先名, Me.txt当年4月, Me.lbl当年, Me.lbl前年, Me.lbl対比, Me.txt前年4月, Me.txt対比4月, Me.txt前年5月, Me.txt当年5月, Me.txt対比5月, Me.txt前年6月, Me.txt当年6月, Me.txt対比6月, Me.txt前年7月, Me.txt当年7月, Me.txt対比7月, Me.txt前年8月, Me.txt当年8月, Me.txt対比8月, Me.txt前年9月, Me.txt当年9月, Me.txt対比9月, Me.txt前年10月, Me.txt当年10月, Me.txt対比10月, Me.txt前年11月, Me.txt当年11月, Me.txt対比11月, Me.txt前年12月, Me.txt当年12月, Me.txt対比12月, Me.txt前年1月, Me.txt当年1月, Me.txt対比1月, Me.txt前年2月, Me.txt当年2月, Me.txt対比2月, Me.txt前年3月, Me.txt当年3月, Me.txt対比3月, Me.txt前年累計, Me.txt当年累計, Me.txt対比累計, Me.txt対比月平均, Me.txt当年月平均, Me.txt前年月平均})
        Me.Detail.Height = 0.6299213!
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
        Me.txt得意先CD.Height = 0.6299213!
        Me.txt得意先CD.Left = 0.0!
        Me.txt得意先CD.Name = "txt得意先CD"
        Me.txt得意先CD.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: middle;" & _
    " ddo-char-set: 1"
        Me.txt得意先CD.Text = "123456"
        Me.txt得意先CD.Top = 0.00000005960464!
        Me.txt得意先CD.Width = 0.6496063!
        '
        'txt得意先名
        '
        Me.txt得意先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt得意先名.Height = 0.6299213!
        Me.txt得意先名.Left = 0.6496063!
        Me.txt得意先名.Name = "txt得意先名"
        Me.txt得意先名.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: justify; vertical-align: middle" & _
    "; ddo-char-set: 1"
        Me.txt得意先名.Text = "あああああいいい"
        Me.txt得意先名.Top = 0.0000001192093!
        Me.txt得意先名.Width = 2.125984!
        '
        'txt当年4月
        '
        Me.txt当年4月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt当年4月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年4月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年4月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年4月.Height = 0.2125984!
        Me.txt当年4月.Left = 3.228347!
        Me.txt当年4月.Name = "txt当年4月"
        Me.txt当年4月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt当年4月.Text = "999,999"
        Me.txt当年4月.Top = 0.0!
        Me.txt当年4月.Width = 0.5314961!
        '
        'lbl当年
        '
        Me.lbl当年.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.lbl当年.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当年.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当年.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl当年.Height = 0.2125984!
        Me.lbl当年.HyperLink = Nothing
        Me.lbl当年.Left = 2.775591!
        Me.lbl当年.Name = "lbl当年"
        Me.lbl当年.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl当年.Text = "(当年)"
        Me.lbl当年.Top = 0.0!
        Me.lbl当年.Width = 0.4527559!
        '
        'lbl前年
        '
        Me.lbl前年.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.lbl前年.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl前年.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl前年.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.lbl前年.Height = 0.2086614!
        Me.lbl前年.HyperLink = Nothing
        Me.lbl前年.Left = 2.775591!
        Me.lbl前年.Name = "lbl前年"
        Me.lbl前年.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl前年.Text = "(前年)"
        Me.lbl前年.Top = 0.2125984!
        Me.lbl前年.Width = 0.4527559!
        '
        'lbl対比
        '
        Me.lbl対比.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl対比.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl対比.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl対比.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.lbl対比.Height = 0.2086614!
        Me.lbl対比.HyperLink = Nothing
        Me.lbl対比.Left = 2.775591!
        Me.lbl対比.Name = "lbl対比"
        Me.lbl対比.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl対比.Text = "(対比)"
        Me.lbl対比.Top = 0.4212598!
        Me.lbl対比.Width = 0.4527559!
        '
        'txt前年4月
        '
        Me.txt前年4月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt前年4月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前年4月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前年4月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt前年4月.Height = 0.2086614!
        Me.txt前年4月.Left = 3.228347!
        Me.txt前年4月.Name = "txt前年4月"
        Me.txt前年4月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt前年4月.Text = "999,999"
        Me.txt前年4月.Top = 0.2125984!
        Me.txt前年4月.Width = 0.5314961!
        '
        'txt対比4月
        '
        Me.txt対比4月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比4月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比4月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比4月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt対比4月.Height = 0.2086614!
        Me.txt対比4月.Left = 3.228347!
        Me.txt対比4月.Name = "txt対比4月"
        Me.txt対比4月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt対比4月.Text = "999.99%"
        Me.txt対比4月.Top = 0.4212599!
        Me.txt対比4月.Width = 0.5314961!
        '
        'txt前年5月
        '
        Me.txt前年5月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt前年5月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前年5月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前年5月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt前年5月.Height = 0.2086614!
        Me.txt前年5月.Left = 3.759843!
        Me.txt前年5月.Name = "txt前年5月"
        Me.txt前年5月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt前年5月.Text = "999,999"
        Me.txt前年5月.Top = 0.2125986!
        Me.txt前年5月.Width = 0.5314961!
        '
        'txt当年5月
        '
        Me.txt当年5月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt当年5月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年5月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年5月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年5月.Height = 0.2125985!
        Me.txt当年5月.Left = 3.759843!
        Me.txt当年5月.Name = "txt当年5月"
        Me.txt当年5月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt当年5月.Text = "999,999"
        Me.txt当年5月.Top = 0.00000005960464!
        Me.txt当年5月.Width = 0.5314961!
        '
        'txt対比5月
        '
        Me.txt対比5月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比5月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比5月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比5月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt対比5月.Height = 0.2086614!
        Me.txt対比5月.Left = 3.759843!
        Me.txt対比5月.Name = "txt対比5月"
        Me.txt対比5月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt対比5月.Text = "999.99%"
        Me.txt対比5月.Top = 0.42126!
        Me.txt対比5月.Width = 0.5314961!
        '
        'txt前年6月
        '
        Me.txt前年6月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt前年6月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前年6月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前年6月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt前年6月.Height = 0.2086614!
        Me.txt前年6月.Left = 4.291339!
        Me.txt前年6月.Name = "txt前年6月"
        Me.txt前年6月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt前年6月.Text = "999,999"
        Me.txt前年6月.Top = 0.2125986!
        Me.txt前年6月.Width = 0.5314961!
        '
        'txt当年6月
        '
        Me.txt当年6月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt当年6月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年6月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年6月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年6月.Height = 0.2125985!
        Me.txt当年6月.Left = 4.291339!
        Me.txt当年6月.Name = "txt当年6月"
        Me.txt当年6月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt当年6月.Text = "999,999"
        Me.txt当年6月.Top = 0.00000005960464!
        Me.txt当年6月.Width = 0.5314961!
        '
        'txt対比6月
        '
        Me.txt対比6月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比6月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比6月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比6月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt対比6月.Height = 0.2086614!
        Me.txt対比6月.Left = 4.291339!
        Me.txt対比6月.Name = "txt対比6月"
        Me.txt対比6月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt対比6月.Text = "999.99%"
        Me.txt対比6月.Top = 0.4212601!
        Me.txt対比6月.Width = 0.5314961!
        '
        'txt前年7月
        '
        Me.txt前年7月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt前年7月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前年7月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前年7月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt前年7月.Height = 0.2086614!
        Me.txt前年7月.Left = 4.822835!
        Me.txt前年7月.Name = "txt前年7月"
        Me.txt前年7月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt前年7月.Text = "999,999"
        Me.txt前年7月.Top = 0.2125986!
        Me.txt前年7月.Width = 0.5314961!
        '
        'txt当年7月
        '
        Me.txt当年7月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt当年7月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年7月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年7月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年7月.Height = 0.2125985!
        Me.txt当年7月.Left = 4.822835!
        Me.txt当年7月.Name = "txt当年7月"
        Me.txt当年7月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt当年7月.Text = "999,999"
        Me.txt当年7月.Top = 0.00000005960464!
        Me.txt当年7月.Width = 0.5314961!
        '
        'txt対比7月
        '
        Me.txt対比7月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比7月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比7月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比7月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt対比7月.Height = 0.2086614!
        Me.txt対比7月.Left = 4.822835!
        Me.txt対比7月.Name = "txt対比7月"
        Me.txt対比7月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt対比7月.Text = "999.99%"
        Me.txt対比7月.Top = 0.4212601!
        Me.txt対比7月.Width = 0.5314961!
        '
        'txt前年8月
        '
        Me.txt前年8月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt前年8月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前年8月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前年8月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt前年8月.Height = 0.2086614!
        Me.txt前年8月.Left = 5.354331!
        Me.txt前年8月.Name = "txt前年8月"
        Me.txt前年8月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt前年8月.Text = "999,999"
        Me.txt前年8月.Top = 0.2125986!
        Me.txt前年8月.Width = 0.5314961!
        '
        'txt当年8月
        '
        Me.txt当年8月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt当年8月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年8月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年8月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年8月.Height = 0.2125985!
        Me.txt当年8月.Left = 5.354331!
        Me.txt当年8月.Name = "txt当年8月"
        Me.txt当年8月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt当年8月.Text = "999,999"
        Me.txt当年8月.Top = 0.00000005960464!
        Me.txt当年8月.Width = 0.5314961!
        '
        'txt対比8月
        '
        Me.txt対比8月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比8月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比8月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比8月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt対比8月.Height = 0.2086614!
        Me.txt対比8月.Left = 5.354331!
        Me.txt対比8月.Name = "txt対比8月"
        Me.txt対比8月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt対比8月.Text = "999.99%"
        Me.txt対比8月.Top = 0.42126!
        Me.txt対比8月.Width = 0.5314961!
        '
        'txt前年9月
        '
        Me.txt前年9月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt前年9月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前年9月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前年9月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt前年9月.Height = 0.2086614!
        Me.txt前年9月.Left = 5.885827!
        Me.txt前年9月.Name = "txt前年9月"
        Me.txt前年9月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt前年9月.Text = "999,999"
        Me.txt前年9月.Top = 0.2125986!
        Me.txt前年9月.Width = 0.5314961!
        '
        'txt当年9月
        '
        Me.txt当年9月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt当年9月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年9月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年9月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年9月.Height = 0.2125985!
        Me.txt当年9月.Left = 5.885827!
        Me.txt当年9月.Name = "txt当年9月"
        Me.txt当年9月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt当年9月.Text = "999,999"
        Me.txt当年9月.Top = 0.00000005960464!
        Me.txt当年9月.Width = 0.5314961!
        '
        'txt対比9月
        '
        Me.txt対比9月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比9月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比9月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比9月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt対比9月.Height = 0.2086614!
        Me.txt対比9月.Left = 5.885827!
        Me.txt対比9月.Name = "txt対比9月"
        Me.txt対比9月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt対比9月.Text = "999.99%"
        Me.txt対比9月.Top = 0.42126!
        Me.txt対比9月.Width = 0.5314961!
        '
        'txt前年10月
        '
        Me.txt前年10月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt前年10月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前年10月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前年10月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt前年10月.Height = 0.2086614!
        Me.txt前年10月.Left = 6.417323!
        Me.txt前年10月.Name = "txt前年10月"
        Me.txt前年10月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt前年10月.Text = "999,999"
        Me.txt前年10月.Top = 0.2125986!
        Me.txt前年10月.Width = 0.5314961!
        '
        'txt当年10月
        '
        Me.txt当年10月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt当年10月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年10月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年10月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年10月.Height = 0.2125985!
        Me.txt当年10月.Left = 6.417323!
        Me.txt当年10月.Name = "txt当年10月"
        Me.txt当年10月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt当年10月.Text = "999,999"
        Me.txt当年10月.Top = 0.00000005960464!
        Me.txt当年10月.Width = 0.5314961!
        '
        'txt対比10月
        '
        Me.txt対比10月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比10月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比10月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比10月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt対比10月.Height = 0.2086614!
        Me.txt対比10月.Left = 6.417323!
        Me.txt対比10月.Name = "txt対比10月"
        Me.txt対比10月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt対比10月.Text = "999.99%"
        Me.txt対比10月.Top = 0.42126!
        Me.txt対比10月.Width = 0.5314961!
        '
        'txt前年11月
        '
        Me.txt前年11月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt前年11月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前年11月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前年11月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt前年11月.Height = 0.2086614!
        Me.txt前年11月.Left = 6.948819!
        Me.txt前年11月.Name = "txt前年11月"
        Me.txt前年11月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt前年11月.Text = "999,999"
        Me.txt前年11月.Top = 0.2125986!
        Me.txt前年11月.Width = 0.5314961!
        '
        'txt当年11月
        '
        Me.txt当年11月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt当年11月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年11月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年11月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年11月.Height = 0.2125985!
        Me.txt当年11月.Left = 6.948819!
        Me.txt当年11月.Name = "txt当年11月"
        Me.txt当年11月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt当年11月.Text = "999,999"
        Me.txt当年11月.Top = 0.0!
        Me.txt当年11月.Width = 0.5314961!
        '
        'txt対比11月
        '
        Me.txt対比11月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比11月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比11月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比11月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt対比11月.Height = 0.2086614!
        Me.txt対比11月.Left = 6.948819!
        Me.txt対比11月.Name = "txt対比11月"
        Me.txt対比11月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt対比11月.Text = "999.99%"
        Me.txt対比11月.Top = 0.4212596!
        Me.txt対比11月.Width = 0.5314961!
        '
        'txt前年12月
        '
        Me.txt前年12月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt前年12月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前年12月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前年12月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt前年12月.Height = 0.2086614!
        Me.txt前年12月.Left = 7.480315!
        Me.txt前年12月.Name = "txt前年12月"
        Me.txt前年12月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt前年12月.Text = "999,999"
        Me.txt前年12月.Top = 0.2125986!
        Me.txt前年12月.Width = 0.5314961!
        '
        'txt当年12月
        '
        Me.txt当年12月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt当年12月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年12月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年12月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年12月.Height = 0.2125985!
        Me.txt当年12月.Left = 7.480315!
        Me.txt当年12月.Name = "txt当年12月"
        Me.txt当年12月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt当年12月.Text = "999,999"
        Me.txt当年12月.Top = 0.0!
        Me.txt当年12月.Width = 0.5314961!
        '
        'txt対比12月
        '
        Me.txt対比12月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比12月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比12月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比12月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt対比12月.Height = 0.2086614!
        Me.txt対比12月.Left = 7.480315!
        Me.txt対比12月.Name = "txt対比12月"
        Me.txt対比12月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt対比12月.Text = "999.99%"
        Me.txt対比12月.Top = 0.4212604!
        Me.txt対比12月.Width = 0.5314961!
        '
        'txt前年1月
        '
        Me.txt前年1月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt前年1月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前年1月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前年1月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt前年1月.Height = 0.2086614!
        Me.txt前年1月.Left = 8.011811!
        Me.txt前年1月.Name = "txt前年1月"
        Me.txt前年1月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt前年1月.Text = "999,999"
        Me.txt前年1月.Top = 0.2125986!
        Me.txt前年1月.Width = 0.5314961!
        '
        'txt当年1月
        '
        Me.txt当年1月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt当年1月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年1月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年1月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年1月.Height = 0.2125985!
        Me.txt当年1月.Left = 8.011811!
        Me.txt当年1月.Name = "txt当年1月"
        Me.txt当年1月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt当年1月.Text = "999,999"
        Me.txt当年1月.Top = 0.0!
        Me.txt当年1月.Width = 0.5314961!
        '
        'txt対比1月
        '
        Me.txt対比1月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比1月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比1月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比1月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt対比1月.Height = 0.2086614!
        Me.txt対比1月.Left = 8.011811!
        Me.txt対比1月.Name = "txt対比1月"
        Me.txt対比1月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt対比1月.Text = "999.99%"
        Me.txt対比1月.Top = 0.4212604!
        Me.txt対比1月.Width = 0.5314961!
        '
        'txt前年2月
        '
        Me.txt前年2月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt前年2月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前年2月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前年2月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt前年2月.Height = 0.2086614!
        Me.txt前年2月.Left = 8.543307!
        Me.txt前年2月.Name = "txt前年2月"
        Me.txt前年2月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt前年2月.Text = "999,999"
        Me.txt前年2月.Top = 0.2125986!
        Me.txt前年2月.Width = 0.5314961!
        '
        'txt当年2月
        '
        Me.txt当年2月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt当年2月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年2月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年2月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年2月.Height = 0.2125985!
        Me.txt当年2月.Left = 8.543307!
        Me.txt当年2月.Name = "txt当年2月"
        Me.txt当年2月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt当年2月.Text = "999,999"
        Me.txt当年2月.Top = 0.0!
        Me.txt当年2月.Width = 0.5314961!
        '
        'txt対比2月
        '
        Me.txt対比2月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比2月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比2月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比2月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt対比2月.Height = 0.2086614!
        Me.txt対比2月.Left = 8.543307!
        Me.txt対比2月.Name = "txt対比2月"
        Me.txt対比2月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt対比2月.Text = "999.99%"
        Me.txt対比2月.Top = 0.4212596!
        Me.txt対比2月.Width = 0.5314961!
        '
        'txt前年3月
        '
        Me.txt前年3月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt前年3月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前年3月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前年3月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt前年3月.Height = 0.2086614!
        Me.txt前年3月.Left = 9.074803!
        Me.txt前年3月.Name = "txt前年3月"
        Me.txt前年3月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt前年3月.Text = "999,999"
        Me.txt前年3月.Top = 0.2125986!
        Me.txt前年3月.Width = 0.5314961!
        '
        'txt当年3月
        '
        Me.txt当年3月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt当年3月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年3月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年3月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年3月.Height = 0.2125985!
        Me.txt当年3月.Left = 9.074803!
        Me.txt当年3月.Name = "txt当年3月"
        Me.txt当年3月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt当年3月.Text = "999,999"
        Me.txt当年3月.Top = 0.0!
        Me.txt当年3月.Width = 0.5314961!
        '
        'txt対比3月
        '
        Me.txt対比3月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比3月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比3月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比3月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt対比3月.Height = 0.2086614!
        Me.txt対比3月.Left = 9.074803!
        Me.txt対比3月.Name = "txt対比3月"
        Me.txt対比3月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt対比3月.Text = "999.99%"
        Me.txt対比3月.Top = 0.4212596!
        Me.txt対比3月.Width = 0.5314961!
        '
        'txt前年累計
        '
        Me.txt前年累計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt前年累計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前年累計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前年累計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt前年累計.Height = 0.2086614!
        Me.txt前年累計.Left = 9.606299!
        Me.txt前年累計.Name = "txt前年累計"
        Me.txt前年累計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt前年累計.Text = "999,999"
        Me.txt前年累計.Top = 0.2125986!
        Me.txt前年累計.Width = 0.6299213!
        '
        'txt当年累計
        '
        Me.txt当年累計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt当年累計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年累計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年累計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年累計.Height = 0.2125984!
        Me.txt当年累計.Left = 9.606299!
        Me.txt当年累計.Name = "txt当年累計"
        Me.txt当年累計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt当年累計.Text = "999,999"
        Me.txt当年累計.Top = 0.0!
        Me.txt当年累計.Width = 0.6299213!
        '
        'txt対比累計
        '
        Me.txt対比累計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比累計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比累計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比累計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt対比累計.Height = 0.2086614!
        Me.txt対比累計.Left = 9.606299!
        Me.txt対比累計.Name = "txt対比累計"
        Me.txt対比累計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt対比累計.Text = "999.99%"
        Me.txt対比累計.Top = 0.4212596!
        Me.txt対比累計.Width = 0.6299213!
        '
        'txt対比月平均
        '
        Me.txt対比月平均.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比月平均.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比月平均.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt対比月平均.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt対比月平均.Height = 0.2086614!
        Me.txt対比月平均.Left = 10.23622!
        Me.txt対比月平均.Name = "txt対比月平均"
        Me.txt対比月平均.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt対比月平均.Text = "999.99%"
        Me.txt対比月平均.Top = 0.4212599!
        Me.txt対比月平均.Width = 0.6299213!
        '
        'txt当年月平均
        '
        Me.txt当年月平均.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt当年月平均.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年月平均.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年月平均.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt当年月平均.Height = 0.2125985!
        Me.txt当年月平均.Left = 10.23622!
        Me.txt当年月平均.Name = "txt当年月平均"
        Me.txt当年月平均.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt当年月平均.Text = "999,999"
        Me.txt当年月平均.Top = 0.0000002086163!
        Me.txt当年月平均.Width = 0.6299213!
        '
        'txt前年月平均
        '
        Me.txt前年月平均.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt前年月平均.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前年月平均.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt前年月平均.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt前年月平均.Height = 0.2086614!
        Me.txt前年月平均.Left = 10.23622!
        Me.txt前年月平均.Name = "txt前年月平均"
        Me.txt前年月平均.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt前年月平均.Text = "999,999"
        Me.txt前年月平均.Top = 0.2125987!
        Me.txt前年月平均.Width = 0.6299213!
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
        Me.grpHdr.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.txt対象年月, Me.txt担当者別未引当一覧表, Me.lbl8月, Me.lbl10月, Me.lbl得意先名, Me.lbl得意先CD, Me.lbl6月, Me.lbl9月, Me.lbl7月, Me.lbl11月, Me.lbl12月, Me.lbl担当者, Me.txt担当者CD, Me.txt担当者名, Me.lbl累計, Me.lbl対象年月, Me.Label1, Me.lbl5月, Me.Label5, Me.lbl4月, Me.lbl1月, Me.lbl2月, Me.lbl3月, Me.lbl月平均})
        Me.grpHdr.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.grpHdr.Height = 0.876378!
        Me.grpHdr.Name = "grpHdr"
        Me.grpHdr.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
        '
        'txt対象年月
        '
        Me.txt対象年月.Height = 0.2362205!
        Me.txt対象年月.Left = 0.7881891!
        Me.txt対象年月.Name = "txt対象年月"
        Me.txt対象年月.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt対象年月.Text = "YY/MM～YY/MM月分"
        Me.txt対象年月.Top = 0.0!
        Me.txt対象年月.Width = 2.070079!
        '
        'txt担当者別未引当一覧表
        '
        Me.txt担当者別未引当一覧表.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txt担当者別未引当一覧表.Height = 0.3149606!
        Me.txt担当者別未引当一覧表.Left = 3.357481!
        Me.txt担当者別未引当一覧表.Name = "txt担当者別未引当一覧表"
        Me.txt担当者別未引当一覧表.Style = "font-family: ＭＳ Ｐゴシック; font-size: 16pt; font-weight: bold; text-align: center; ve" & _
    "rtical-align: bottom; ddo-char-set: 1"
        Me.txt担当者別未引当一覧表.Text = "得意先別売上推移表"
        Me.txt担当者別未引当一覧表.Top = 0.0!
        Me.txt担当者別未引当一覧表.Width = 3.464567!
        '
        'lbl8月
        '
        Me.lbl8月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl8月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl8月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl8月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl8月.Height = 0.3346457!
        Me.lbl8月.HyperLink = Nothing
        Me.lbl8月.Left = 5.354331!
        Me.lbl8月.Name = "lbl8月"
        Me.lbl8月.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl8月.Text = "８月"
        Me.lbl8月.Top = 0.5417323!
        Me.lbl8月.Width = 0.5314961!
        '
        'lbl10月
        '
        Me.lbl10月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl10月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl10月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl10月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl10月.Height = 0.3346457!
        Me.lbl10月.HyperLink = Nothing
        Me.lbl10月.Left = 6.417324!
        Me.lbl10月.Name = "lbl10月"
        Me.lbl10月.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl10月.Text = "１０月"
        Me.lbl10月.Top = 0.5417323!
        Me.lbl10月.Width = 0.5314961!
        '
        'lbl得意先名
        '
        Me.lbl得意先名.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先名.CharacterSpacing = 5.0!
        Me.lbl得意先名.Height = 0.3346457!
        Me.lbl得意先名.HyperLink = Nothing
        Me.lbl得意先名.Left = 0.6496068!
        Me.lbl得意先名.Name = "lbl得意先名"
        Me.lbl得意先名.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: left; vertical-alig" & _
    "n: middle; ddo-char-set: 1"
        Me.lbl得意先名.Text = " 得意先名"
        Me.lbl得意先名.Top = 0.5417323!
        Me.lbl得意先名.Width = 2.125984!
        '
        'lbl得意先CD
        '
        Me.lbl得意先CD.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先CD.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先CD.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先CD.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl得意先CD.Height = 0.3346457!
        Me.lbl得意先CD.HyperLink = Nothing
        Me.lbl得意先CD.Left = 0.0000004768372!
        Me.lbl得意先CD.Name = "lbl得意先CD"
        Me.lbl得意先CD.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 7.5pt; text-align: center; vertical-" & _
    "align: middle; ddo-char-set: 1"
        Me.lbl得意先CD.Text = "コード"
        Me.lbl得意先CD.Top = 0.5417323!
        Me.lbl得意先CD.Width = 0.6496063!
        '
        'lbl6月
        '
        Me.lbl6月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl6月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl6月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl6月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl6月.Height = 0.3346457!
        Me.lbl6月.HyperLink = Nothing
        Me.lbl6月.Left = 4.291339!
        Me.lbl6月.Name = "lbl6月"
        Me.lbl6月.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl6月.Text = "６月"
        Me.lbl6月.Top = 0.5417323!
        Me.lbl6月.Width = 0.5314961!
        '
        'lbl9月
        '
        Me.lbl9月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl9月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl9月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl9月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl9月.Height = 0.3346457!
        Me.lbl9月.HyperLink = Nothing
        Me.lbl9月.Left = 5.885828!
        Me.lbl9月.Name = "lbl9月"
        Me.lbl9月.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl9月.Text = "９月"
        Me.lbl9月.Top = 0.5417323!
        Me.lbl9月.Width = 0.5314961!
        '
        'lbl7月
        '
        Me.lbl7月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl7月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl7月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl7月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl7月.CharacterSpacing = 5.0!
        Me.lbl7月.Height = 0.3346457!
        Me.lbl7月.HyperLink = Nothing
        Me.lbl7月.Left = 4.822835!
        Me.lbl7月.Name = "lbl7月"
        Me.lbl7月.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl7月.Text = "７月"
        Me.lbl7月.Top = 0.5417323!
        Me.lbl7月.Width = 0.5314961!
        '
        'lbl11月
        '
        Me.lbl11月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl11月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl11月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl11月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl11月.Height = 0.3346457!
        Me.lbl11月.HyperLink = Nothing
        Me.lbl11月.Left = 6.94882!
        Me.lbl11月.Name = "lbl11月"
        Me.lbl11月.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl11月.Text = "１１月"
        Me.lbl11月.Top = 0.5417323!
        Me.lbl11月.Width = 0.5314961!
        '
        'lbl12月
        '
        Me.lbl12月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl12月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl12月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl12月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl12月.Height = 0.3346457!
        Me.lbl12月.HyperLink = Nothing
        Me.lbl12月.Left = 7.480316!
        Me.lbl12月.Name = "lbl12月"
        Me.lbl12月.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl12月.Text = "１２月"
        Me.lbl12月.Top = 0.5417323!
        Me.lbl12月.Width = 0.5314961!
        '
        'lbl担当者
        '
        Me.lbl担当者.Height = 0.2362205!
        Me.lbl担当者.HyperLink = Nothing
        Me.lbl担当者.Left = 0.0!
        Me.lbl担当者.Name = "lbl担当者"
        Me.lbl担当者.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl担当者.Text = "担当者"
        Me.lbl担当者.Top = 0.2362205!
        Me.lbl担当者.Width = 0.7874014!
        '
        'txt担当者CD
        '
        Me.txt担当者CD.Height = 0.2362205!
        Me.txt担当者CD.Left = 0.7874014!
        Me.txt担当者CD.Name = "txt担当者CD"
        Me.txt担当者CD.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt担当者CD.Text = "123"
        Me.txt担当者CD.Top = 0.2362205!
        Me.txt担当者CD.Width = 0.3937008!
        '
        'txt担当者名
        '
        Me.txt担当者名.Height = 0.2362205!
        Me.txt担当者名.Left = 1.228347!
        Me.txt担当者名.Name = "txt担当者名"
        Me.txt担当者名.Style = "font-family: ＭＳ 明朝; font-size: 11pt; text-align: left; vertical-align: bottom; dd" & _
    "o-char-set: 1"
        Me.txt担当者名.Text = "あああああいいいいい"
        Me.txt担当者名.Top = 0.2362205!
        Me.txt担当者名.Width = 1.670866!
        '
        'lbl累計
        '
        Me.lbl累計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl累計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl累計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl累計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl累計.Height = 0.3346457!
        Me.lbl累計.HyperLink = Nothing
        Me.lbl累計.Left = 9.6063!
        Me.lbl累計.Name = "lbl累計"
        Me.lbl累計.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl累計.Text = "累計"
        Me.lbl累計.Top = 0.5417323!
        Me.lbl累計.Width = 0.6299213!
        '
        'lbl対象年月
        '
        Me.lbl対象年月.Height = 0.2362205!
        Me.lbl対象年月.HyperLink = Nothing
        Me.lbl対象年月.Left = 0.0!
        Me.lbl対象年月.Name = "lbl対象年月"
        Me.lbl対象年月.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 11pt; text-align: center; vertical-a" & _
    "lign: middle; ddo-char-set: 1"
        Me.lbl対象年月.Text = "対象年月"
        Me.lbl対象年月.Top = 0.0!
        Me.lbl対象年月.Width = 0.7874014!
        '
        'Label1
        '
        Me.Label1.Height = 0.2362205!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 7.247245!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.Label1.Text = "(単位:千円)"
        Me.Label1.Top = 0.1385827!
        Me.Label1.Width = 1.162205!
        '
        'lbl5月
        '
        Me.lbl5月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl5月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl5月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl5月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl5月.Height = 0.3346457!
        Me.lbl5月.HyperLink = Nothing
        Me.lbl5月.Left = 3.759843!
        Me.lbl5月.Name = "lbl5月"
        Me.lbl5月.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl5月.Text = "５月"
        Me.lbl5月.Top = 0.5417323!
        Me.lbl5月.Width = 0.5314961!
        '
        'Label5
        '
        Me.Label5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label5.Height = 0.3346457!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 2.775591!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.Label5.Text = ""
        Me.Label5.Top = 0.5417323!
        Me.Label5.Width = 0.4527559!
        '
        'lbl4月
        '
        Me.lbl4月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl4月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl4月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl4月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl4月.CharacterSpacing = 5.0!
        Me.lbl4月.Height = 0.3346457!
        Me.lbl4月.HyperLink = Nothing
        Me.lbl4月.Left = 3.228347!
        Me.lbl4月.Name = "lbl4月"
        Me.lbl4月.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl4月.Text = "４月"
        Me.lbl4月.Top = 0.5417323!
        Me.lbl4月.Width = 0.5314961!
        '
        'lbl1月
        '
        Me.lbl1月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl1月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl1月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl1月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl1月.Height = 0.3346457!
        Me.lbl1月.HyperLink = Nothing
        Me.lbl1月.Left = 8.011812!
        Me.lbl1月.Name = "lbl1月"
        Me.lbl1月.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl1月.Text = "１月"
        Me.lbl1月.Top = 0.5417323!
        Me.lbl1月.Width = 0.5314961!
        '
        'lbl2月
        '
        Me.lbl2月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl2月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl2月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl2月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl2月.Height = 0.3346457!
        Me.lbl2月.HyperLink = Nothing
        Me.lbl2月.Left = 8.543308!
        Me.lbl2月.Name = "lbl2月"
        Me.lbl2月.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl2月.Text = "２月"
        Me.lbl2月.Top = 0.5417323!
        Me.lbl2月.Width = 0.5314961!
        '
        'lbl3月
        '
        Me.lbl3月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl3月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl3月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl3月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl3月.Height = 0.3346457!
        Me.lbl3月.HyperLink = Nothing
        Me.lbl3月.Left = 9.074804!
        Me.lbl3月.Name = "lbl3月"
        Me.lbl3月.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl3月.Text = "３月"
        Me.lbl3月.Top = 0.5417323!
        Me.lbl3月.Width = 0.5314961!
        '
        'lbl月平均
        '
        Me.lbl月平均.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl月平均.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl月平均.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl月平均.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.lbl月平均.Height = 0.3346457!
        Me.lbl月平均.HyperLink = Nothing
        Me.lbl月平均.Left = 10.23622!
        Me.lbl月平均.Name = "lbl月平均"
        Me.lbl月平均.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.lbl月平均.Text = "月平均"
        Me.lbl月平均.Top = 0.5417323!
        Me.lbl月平均.Width = 0.6299213!
        '
        'grpFtr計
        '
        Me.grpFtr計.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox87, Me.Label2, Me.TextBox86, Me.txt総合計当年4月, Me.Label17, Me.Label18, Me.Label19, Me.txt総合計前年4月, Me.txt総合計対比4月, Me.txt総合計前年5月, Me.txt総合計当年5月, Me.txt総合計対比5月, Me.txt総合計前年6月, Me.txt総合計当年6月, Me.txt総合計対比6月, Me.txt総合計前年7月, Me.txt総合計当年7月, Me.txt総合計対比7月, Me.txt総合計前年8月, Me.txt総合計当年8月, Me.txt総合計対比8月, Me.txt総合計前年9月, Me.txt総合計当年9月, Me.txt総合計対比9月, Me.txt総合計前年10月, Me.txt総合計当年10月, Me.txt総合計対比10月, Me.txt総合計前年11月, Me.txt総合計当年11月, Me.txt総合計対比11月, Me.txt総合計前年12月, Me.txt総合計当年12月, Me.txt総合計対比12月, Me.txt総合計前年1月, Me.txt総合計当年1月, Me.txt総合計対比1月, Me.txt総合計前年2月, Me.txt総合計当年2月, Me.txt総合計対比2月, Me.txt総合計前年3月, Me.txt総合計当年3月, Me.txt総合計対比3月, Me.txt総合計前年累計, Me.txt総合計当年累計, Me.txt総合計対比累計, Me.txt総合計対比月平均, Me.txt総合計当年月平均, Me.txt総合計前年月平均})
        Me.grpFtr計.Height = 0.6299213!
        Me.grpFtr計.Name = "grpFtr計"
        '
        'TextBox87
        '
        Me.TextBox87.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox87.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox87.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox87.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox87.Height = 0.6299213!
        Me.TextBox87.Left = 0.6496062!
        Me.TextBox87.Name = "TextBox87"
        Me.TextBox87.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: justify; vertical-align: middle" & _
    "; ddo-char-set: 1"
        Me.TextBox87.Text = Nothing
        Me.TextBox87.Top = 0.0000001192093!
        Me.TextBox87.Width = 2.125984!
        '
        'Label2
        '
        Me.Label2.Height = 0.1771654!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 1.832677!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; font-weight: bold; text-align: " & _
    "right; vertical-align: bottom; ddo-char-set: 1"
        Me.Label2.Text = "＊総合計"
        Me.Label2.Top = 0.25!
        Me.Label2.Width = 0.7874016!
        '
        'TextBox86
        '
        Me.TextBox86.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox86.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox86.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox86.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox86.Height = 0.6299213!
        Me.TextBox86.Left = 0.0!
        Me.TextBox86.Name = "TextBox86"
        Me.TextBox86.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: middle;" & _
    " ddo-char-set: 1"
        Me.TextBox86.Text = Nothing
        Me.TextBox86.Top = 0.00000005960464!
        Me.TextBox86.Width = 0.6496062!
        '
        'txt総合計当年4月
        '
        Me.txt総合計当年4月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計当年4月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年4月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年4月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年4月.Height = 0.2125985!
        Me.txt総合計当年4月.Left = 3.228346!
        Me.txt総合計当年4月.Name = "txt総合計当年4月"
        Me.txt総合計当年4月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計当年4月.Text = "999,999"
        Me.txt総合計当年4月.Top = 0.0!
        Me.txt総合計当年4月.Width = 0.5314961!
        '
        'Label17
        '
        Me.Label17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.Label17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label17.Height = 0.2125985!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 2.775591!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.Label17.Text = "(当年)"
        Me.Label17.Top = 0.0!
        Me.Label17.Width = 0.4527559!
        '
        'Label18
        '
        Me.Label18.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.Label18.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label18.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label18.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.Label18.Height = 0.2086614!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 2.775591!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.Label18.Text = "(前年)"
        Me.Label18.Top = 0.2125985!
        Me.Label18.Width = 0.4527559!
        '
        'Label19
        '
        Me.Label19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.Label19.Height = 0.2086614!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 2.775591!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.Label19.Text = "(対比)"
        Me.Label19.Top = 0.4212598!
        Me.Label19.Width = 0.4527559!
        '
        'txt総合計前年4月
        '
        Me.txt総合計前年4月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計前年4月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計前年4月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計前年4月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計前年4月.Height = 0.2086614!
        Me.txt総合計前年4月.Left = 3.228346!
        Me.txt総合計前年4月.Name = "txt総合計前年4月"
        Me.txt総合計前年4月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計前年4月.Text = "999,999"
        Me.txt総合計前年4月.Top = 0.2125985!
        Me.txt総合計前年4月.Width = 0.5314961!
        '
        'txt総合計対比4月
        '
        Me.txt総合計対比4月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比4月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比4月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比4月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計対比4月.Height = 0.2086614!
        Me.txt総合計対比4月.Left = 3.228346!
        Me.txt総合計対比4月.Name = "txt総合計対比4月"
        Me.txt総合計対比4月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計対比4月.Text = "999.99%"
        Me.txt総合計対比4月.Top = 0.4212599!
        Me.txt総合計対比4月.Width = 0.5314961!
        '
        'txt総合計前年5月
        '
        Me.txt総合計前年5月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計前年5月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計前年5月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計前年5月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計前年5月.Height = 0.2086614!
        Me.txt総合計前年5月.Left = 3.759842!
        Me.txt総合計前年5月.Name = "txt総合計前年5月"
        Me.txt総合計前年5月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計前年5月.Text = "999,999"
        Me.txt総合計前年5月.Top = 0.2125985!
        Me.txt総合計前年5月.Width = 0.5314961!
        '
        'txt総合計当年5月
        '
        Me.txt総合計当年5月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計当年5月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年5月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年5月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年5月.Height = 0.2125985!
        Me.txt総合計当年5月.Left = 3.759842!
        Me.txt総合計当年5月.Name = "txt総合計当年5月"
        Me.txt総合計当年5月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計当年5月.Text = "999,999"
        Me.txt総合計当年5月.Top = 0.00000005960464!
        Me.txt総合計当年5月.Width = 0.5314961!
        '
        'txt総合計対比5月
        '
        Me.txt総合計対比5月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比5月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比5月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比5月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計対比5月.Height = 0.2086614!
        Me.txt総合計対比5月.Left = 3.759842!
        Me.txt総合計対比5月.Name = "txt総合計対比5月"
        Me.txt総合計対比5月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計対比5月.Text = "999.99%"
        Me.txt総合計対比5月.Top = 0.42126!
        Me.txt総合計対比5月.Width = 0.5314961!
        '
        'txt総合計前年6月
        '
        Me.txt総合計前年6月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計前年6月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計前年6月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計前年6月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計前年6月.Height = 0.2086614!
        Me.txt総合計前年6月.Left = 4.291339!
        Me.txt総合計前年6月.Name = "txt総合計前年6月"
        Me.txt総合計前年6月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計前年6月.Text = "999,999"
        Me.txt総合計前年6月.Top = 0.2125985!
        Me.txt総合計前年6月.Width = 0.5314961!
        '
        'txt総合計当年6月
        '
        Me.txt総合計当年6月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計当年6月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年6月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年6月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年6月.Height = 0.2125985!
        Me.txt総合計当年6月.Left = 4.291339!
        Me.txt総合計当年6月.Name = "txt総合計当年6月"
        Me.txt総合計当年6月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計当年6月.Text = "999,999"
        Me.txt総合計当年6月.Top = 0.00000005960464!
        Me.txt総合計当年6月.Width = 0.5314961!
        '
        'txt総合計対比6月
        '
        Me.txt総合計対比6月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比6月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比6月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比6月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計対比6月.Height = 0.2086614!
        Me.txt総合計対比6月.Left = 4.291339!
        Me.txt総合計対比6月.Name = "txt総合計対比6月"
        Me.txt総合計対比6月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計対比6月.Text = "999.99%"
        Me.txt総合計対比6月.Top = 0.4212601!
        Me.txt総合計対比6月.Width = 0.5314961!
        '
        'txt総合計前年7月
        '
        Me.txt総合計前年7月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計前年7月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計前年7月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計前年7月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計前年7月.Height = 0.2086614!
        Me.txt総合計前年7月.Left = 4.822834!
        Me.txt総合計前年7月.Name = "txt総合計前年7月"
        Me.txt総合計前年7月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計前年7月.Text = "999,999"
        Me.txt総合計前年7月.Top = 0.2125985!
        Me.txt総合計前年7月.Width = 0.5314961!
        '
        'txt総合計当年7月
        '
        Me.txt総合計当年7月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計当年7月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年7月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年7月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年7月.Height = 0.2125985!
        Me.txt総合計当年7月.Left = 4.822834!
        Me.txt総合計当年7月.Name = "txt総合計当年7月"
        Me.txt総合計当年7月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計当年7月.Text = "999,999"
        Me.txt総合計当年7月.Top = 0.00000005960464!
        Me.txt総合計当年7月.Width = 0.5314961!
        '
        'txt総合計対比7月
        '
        Me.txt総合計対比7月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比7月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比7月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比7月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計対比7月.Height = 0.2086614!
        Me.txt総合計対比7月.Left = 4.822834!
        Me.txt総合計対比7月.Name = "txt総合計対比7月"
        Me.txt総合計対比7月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計対比7月.Text = "999.99%"
        Me.txt総合計対比7月.Top = 0.4212601!
        Me.txt総合計対比7月.Width = 0.5314961!
        '
        'txt総合計前年8月
        '
        Me.txt総合計前年8月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計前年8月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計前年8月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計前年8月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計前年8月.Height = 0.2086614!
        Me.txt総合計前年8月.Left = 5.354331!
        Me.txt総合計前年8月.Name = "txt総合計前年8月"
        Me.txt総合計前年8月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計前年8月.Text = "999,999"
        Me.txt総合計前年8月.Top = 0.2125985!
        Me.txt総合計前年8月.Width = 0.5314961!
        '
        'txt総合計当年8月
        '
        Me.txt総合計当年8月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計当年8月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年8月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年8月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年8月.Height = 0.2125985!
        Me.txt総合計当年8月.Left = 5.354331!
        Me.txt総合計当年8月.Name = "txt総合計当年8月"
        Me.txt総合計当年8月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計当年8月.Text = "999,999"
        Me.txt総合計当年8月.Top = 0.00000005960464!
        Me.txt総合計当年8月.Width = 0.5314961!
        '
        'txt総合計対比8月
        '
        Me.txt総合計対比8月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比8月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比8月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比8月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計対比8月.Height = 0.2086614!
        Me.txt総合計対比8月.Left = 5.354331!
        Me.txt総合計対比8月.Name = "txt総合計対比8月"
        Me.txt総合計対比8月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計対比8月.Text = "999.99%"
        Me.txt総合計対比8月.Top = 0.42126!
        Me.txt総合計対比8月.Width = 0.5314961!
        '
        'txt総合計前年9月
        '
        Me.txt総合計前年9月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計前年9月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計前年9月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計前年9月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計前年9月.Height = 0.2086614!
        Me.txt総合計前年9月.Left = 5.885827!
        Me.txt総合計前年9月.Name = "txt総合計前年9月"
        Me.txt総合計前年9月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計前年9月.Text = "999,999"
        Me.txt総合計前年9月.Top = 0.2125985!
        Me.txt総合計前年9月.Width = 0.5314961!
        '
        'txt総合計当年9月
        '
        Me.txt総合計当年9月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計当年9月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年9月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年9月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年9月.Height = 0.2125985!
        Me.txt総合計当年9月.Left = 5.885827!
        Me.txt総合計当年9月.Name = "txt総合計当年9月"
        Me.txt総合計当年9月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計当年9月.Text = "999,999"
        Me.txt総合計当年9月.Top = 0.00000005960464!
        Me.txt総合計当年9月.Width = 0.5314961!
        '
        'txt総合計対比9月
        '
        Me.txt総合計対比9月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比9月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比9月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比9月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計対比9月.Height = 0.2086614!
        Me.txt総合計対比9月.Left = 5.885827!
        Me.txt総合計対比9月.Name = "txt総合計対比9月"
        Me.txt総合計対比9月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計対比9月.Text = "999.99%"
        Me.txt総合計対比9月.Top = 0.42126!
        Me.txt総合計対比9月.Width = 0.5314961!
        '
        'txt総合計前年10月
        '
        Me.txt総合計前年10月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計前年10月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計前年10月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計前年10月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計前年10月.Height = 0.2086614!
        Me.txt総合計前年10月.Left = 6.417323!
        Me.txt総合計前年10月.Name = "txt総合計前年10月"
        Me.txt総合計前年10月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計前年10月.Text = "999,999"
        Me.txt総合計前年10月.Top = 0.2125985!
        Me.txt総合計前年10月.Width = 0.5314961!
        '
        'txt総合計当年10月
        '
        Me.txt総合計当年10月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計当年10月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年10月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年10月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年10月.Height = 0.2125985!
        Me.txt総合計当年10月.Left = 6.417323!
        Me.txt総合計当年10月.Name = "txt総合計当年10月"
        Me.txt総合計当年10月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計当年10月.Text = "999,999"
        Me.txt総合計当年10月.Top = 0.00000005960464!
        Me.txt総合計当年10月.Width = 0.5314961!
        '
        'txt総合計対比10月
        '
        Me.txt総合計対比10月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比10月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比10月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比10月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計対比10月.Height = 0.2086614!
        Me.txt総合計対比10月.Left = 6.417323!
        Me.txt総合計対比10月.Name = "txt総合計対比10月"
        Me.txt総合計対比10月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計対比10月.Text = "999.99%"
        Me.txt総合計対比10月.Top = 0.42126!
        Me.txt総合計対比10月.Width = 0.5314961!
        '
        'txt総合計前年11月
        '
        Me.txt総合計前年11月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計前年11月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計前年11月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計前年11月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計前年11月.Height = 0.2086614!
        Me.txt総合計前年11月.Left = 6.948819!
        Me.txt総合計前年11月.Name = "txt総合計前年11月"
        Me.txt総合計前年11月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計前年11月.Text = "999,999"
        Me.txt総合計前年11月.Top = 0.2125985!
        Me.txt総合計前年11月.Width = 0.5314961!
        '
        'txt総合計当年11月
        '
        Me.txt総合計当年11月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計当年11月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年11月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年11月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年11月.Height = 0.2125985!
        Me.txt総合計当年11月.Left = 6.948819!
        Me.txt総合計当年11月.Name = "txt総合計当年11月"
        Me.txt総合計当年11月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計当年11月.Text = "999,999"
        Me.txt総合計当年11月.Top = 0.0!
        Me.txt総合計当年11月.Width = 0.5314961!
        '
        'txt総合計対比11月
        '
        Me.txt総合計対比11月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比11月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比11月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比11月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計対比11月.Height = 0.2086614!
        Me.txt総合計対比11月.Left = 6.948819!
        Me.txt総合計対比11月.Name = "txt総合計対比11月"
        Me.txt総合計対比11月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計対比11月.Text = "999.99%"
        Me.txt総合計対比11月.Top = 0.4212596!
        Me.txt総合計対比11月.Width = 0.5314961!
        '
        'txt総合計前年12月
        '
        Me.txt総合計前年12月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計前年12月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計前年12月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計前年12月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計前年12月.Height = 0.2086614!
        Me.txt総合計前年12月.Left = 7.480313!
        Me.txt総合計前年12月.Name = "txt総合計前年12月"
        Me.txt総合計前年12月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計前年12月.Text = "999,999"
        Me.txt総合計前年12月.Top = 0.2125985!
        Me.txt総合計前年12月.Width = 0.5314961!
        '
        'txt総合計当年12月
        '
        Me.txt総合計当年12月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計当年12月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年12月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年12月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年12月.Height = 0.2125985!
        Me.txt総合計当年12月.Left = 7.480313!
        Me.txt総合計当年12月.Name = "txt総合計当年12月"
        Me.txt総合計当年12月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計当年12月.Text = "999,999"
        Me.txt総合計当年12月.Top = 0.0!
        Me.txt総合計当年12月.Width = 0.5314961!
        '
        'txt総合計対比12月
        '
        Me.txt総合計対比12月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比12月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比12月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比12月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計対比12月.Height = 0.2086614!
        Me.txt総合計対比12月.Left = 7.480313!
        Me.txt総合計対比12月.Name = "txt総合計対比12月"
        Me.txt総合計対比12月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計対比12月.Text = "999.99%"
        Me.txt総合計対比12月.Top = 0.4212604!
        Me.txt総合計対比12月.Width = 0.5314961!
        '
        'txt総合計前年1月
        '
        Me.txt総合計前年1月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計前年1月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計前年1月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計前年1月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計前年1月.Height = 0.2086614!
        Me.txt総合計前年1月.Left = 8.011812!
        Me.txt総合計前年1月.Name = "txt総合計前年1月"
        Me.txt総合計前年1月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計前年1月.Text = "999,999"
        Me.txt総合計前年1月.Top = 0.2125985!
        Me.txt総合計前年1月.Width = 0.5314961!
        '
        'txt総合計当年1月
        '
        Me.txt総合計当年1月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計当年1月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年1月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年1月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年1月.Height = 0.2125985!
        Me.txt総合計当年1月.Left = 8.011812!
        Me.txt総合計当年1月.Name = "txt総合計当年1月"
        Me.txt総合計当年1月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計当年1月.Text = "999,999"
        Me.txt総合計当年1月.Top = 0.0!
        Me.txt総合計当年1月.Width = 0.5314961!
        '
        'txt総合計対比1月
        '
        Me.txt総合計対比1月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比1月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比1月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比1月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計対比1月.Height = 0.2086614!
        Me.txt総合計対比1月.Left = 8.011812!
        Me.txt総合計対比1月.Name = "txt総合計対比1月"
        Me.txt総合計対比1月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計対比1月.Text = "999.99%"
        Me.txt総合計対比1月.Top = 0.4212604!
        Me.txt総合計対比1月.Width = 0.5314961!
        '
        'txt総合計前年2月
        '
        Me.txt総合計前年2月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計前年2月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計前年2月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計前年2月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計前年2月.Height = 0.2086614!
        Me.txt総合計前年2月.Left = 8.543305!
        Me.txt総合計前年2月.Name = "txt総合計前年2月"
        Me.txt総合計前年2月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計前年2月.Text = "999,999"
        Me.txt総合計前年2月.Top = 0.2125985!
        Me.txt総合計前年2月.Width = 0.5314961!
        '
        'txt総合計当年2月
        '
        Me.txt総合計当年2月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計当年2月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年2月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年2月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年2月.Height = 0.2125985!
        Me.txt総合計当年2月.Left = 8.543305!
        Me.txt総合計当年2月.Name = "txt総合計当年2月"
        Me.txt総合計当年2月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計当年2月.Text = "999,999"
        Me.txt総合計当年2月.Top = 0.0!
        Me.txt総合計当年2月.Width = 0.5314961!
        '
        'txt総合計対比2月
        '
        Me.txt総合計対比2月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比2月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比2月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比2月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計対比2月.Height = 0.2086614!
        Me.txt総合計対比2月.Left = 8.543305!
        Me.txt総合計対比2月.Name = "txt総合計対比2月"
        Me.txt総合計対比2月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計対比2月.Text = "999.99%"
        Me.txt総合計対比2月.Top = 0.4212596!
        Me.txt総合計対比2月.Width = 0.5314961!
        '
        'txt総合計前年3月
        '
        Me.txt総合計前年3月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計前年3月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計前年3月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計前年3月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計前年3月.Height = 0.2086614!
        Me.txt総合計前年3月.Left = 9.074805!
        Me.txt総合計前年3月.Name = "txt総合計前年3月"
        Me.txt総合計前年3月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計前年3月.Text = "999,999"
        Me.txt総合計前年3月.Top = 0.2125985!
        Me.txt総合計前年3月.Width = 0.5314961!
        '
        'txt総合計当年3月
        '
        Me.txt総合計当年3月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計当年3月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年3月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年3月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年3月.Height = 0.2125985!
        Me.txt総合計当年3月.Left = 9.074805!
        Me.txt総合計当年3月.Name = "txt総合計当年3月"
        Me.txt総合計当年3月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計当年3月.Text = "999,999"
        Me.txt総合計当年3月.Top = 0.0!
        Me.txt総合計当年3月.Width = 0.5314961!
        '
        'txt総合計対比3月
        '
        Me.txt総合計対比3月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比3月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比3月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比3月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計対比3月.Height = 0.2086614!
        Me.txt総合計対比3月.Left = 9.074805!
        Me.txt総合計対比3月.Name = "txt総合計対比3月"
        Me.txt総合計対比3月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計対比3月.Text = "999.99%"
        Me.txt総合計対比3月.Top = 0.4212596!
        Me.txt総合計対比3月.Width = 0.5314961!
        '
        'txt総合計前年累計
        '
        Me.txt総合計前年累計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計前年累計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計前年累計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計前年累計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計前年累計.Height = 0.2086614!
        Me.txt総合計前年累計.Left = 9.606298!
        Me.txt総合計前年累計.Name = "txt総合計前年累計"
        Me.txt総合計前年累計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計前年累計.Text = "999,999"
        Me.txt総合計前年累計.Top = 0.2125985!
        Me.txt総合計前年累計.Width = 0.6299213!
        '
        'txt総合計当年累計
        '
        Me.txt総合計当年累計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計当年累計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年累計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年累計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年累計.Height = 0.2125985!
        Me.txt総合計当年累計.Left = 9.606298!
        Me.txt総合計当年累計.Name = "txt総合計当年累計"
        Me.txt総合計当年累計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計当年累計.Text = "999,999"
        Me.txt総合計当年累計.Top = 0.0!
        Me.txt総合計当年累計.Width = 0.6299213!
        '
        'txt総合計対比累計
        '
        Me.txt総合計対比累計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比累計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比累計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比累計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計対比累計.Height = 0.2086614!
        Me.txt総合計対比累計.Left = 9.6063!
        Me.txt総合計対比累計.Name = "txt総合計対比累計"
        Me.txt総合計対比累計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計対比累計.Text = "999.99%"
        Me.txt総合計対比累計.Top = 0.4212599!
        Me.txt総合計対比累計.Width = 0.6299213!
        '
        'txt総合計対比月平均
        '
        Me.txt総合計対比月平均.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比月平均.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比月平均.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計対比月平均.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計対比月平均.Height = 0.2086614!
        Me.txt総合計対比月平均.Left = 10.23622!
        Me.txt総合計対比月平均.Name = "txt総合計対比月平均"
        Me.txt総合計対比月平均.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計対比月平均.Text = "999.99%"
        Me.txt総合計対比月平均.Top = 0.4212599!
        Me.txt総合計対比月平均.Width = 0.6299213!
        '
        'txt総合計当年月平均
        '
        Me.txt総合計当年月平均.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計当年月平均.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年月平均.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年月平均.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計当年月平均.Height = 0.2125985!
        Me.txt総合計当年月平均.Left = 10.23622!
        Me.txt総合計当年月平均.Name = "txt総合計当年月平均"
        Me.txt総合計当年月平均.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計当年月平均.Text = "999,999"
        Me.txt総合計当年月平均.Top = 0.0000002086163!
        Me.txt総合計当年月平均.Width = 0.6299213!
        '
        'txt総合計前年月平均
        '
        Me.txt総合計前年月平均.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計前年月平均.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計前年月平均.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt総合計前年月平均.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt総合計前年月平均.Height = 0.2086614!
        Me.txt総合計前年月平均.Left = 10.23622!
        Me.txt総合計前年月平均.Name = "txt総合計前年月平均"
        Me.txt総合計前年月平均.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt総合計前年月平均.Text = "999,999"
        Me.txt総合計前年月平均.Top = 0.2125988!
        Me.txt総合計前年月平均.Width = 0.6299213!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Height = 0.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label3, Me.TextBox11, Me.TextBox19, Me.txt担当者当年4月, Me.Label14, Me.Label15, Me.Label16, Me.txt担当者前年4月, Me.txt担当者対比4月, Me.txt担当者前年5月, Me.txt担当者当年5月, Me.txt担当者対比5月, Me.txt担当者前年6月, Me.txt担当者当年6月, Me.txt担当者対比6月, Me.txt担当者前年7月, Me.txt担当者当年7月, Me.txt担当者対比7月, Me.txt担当者前年8月, Me.txt担当者当年8月, Me.txt担当者対比8月, Me.txt担当者前年9月, Me.txt担当者当年9月, Me.txt担当者対比9月, Me.txt担当者前年10月, Me.txt担当者当年10月, Me.txt担当者対比10月, Me.txt担当者前年11月, Me.txt担当者当年11月, Me.txt担当者対比11月, Me.txt担当者前年12月, Me.txt担当者当年12月, Me.txt担当者対比12月, Me.txt担当者前年1月, Me.txt担当者当年1月, Me.txt担当者対比1月, Me.txt担当者前年2月, Me.txt担当者当年2月, Me.txt担当者対比2月, Me.txt担当者前年3月, Me.txt担当者当年3月, Me.txt担当者対比3月, Me.txt担当者前年累計, Me.txt担当者当年月累計, Me.txt担当者対比累計, Me.txt担当者対比月平均, Me.txt担当者当年月平均, Me.txt担当者前年月平均})
        Me.GroupFooter1.Height = 0.6299213!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'Label3
        '
        Me.Label3.Height = 0.1771654!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 1.832677!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; font-weight: bold; text-align: " & _
    "right; vertical-align: bottom; ddo-char-set: 1"
        Me.Label3.Text = "＊担当者計"
        Me.Label3.Top = 0.2484252!
        Me.Label3.Width = 0.7874014!
        '
        'TextBox11
        '
        Me.TextBox11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox11.Height = 0.6299213!
        Me.TextBox11.Left = 0.0!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: center; vertical-align: middle;" & _
    " ddo-char-set: 1"
        Me.TextBox11.Text = Nothing
        Me.TextBox11.Top = 0.00000005960464!
        Me.TextBox11.Width = 0.6496062!
        '
        'TextBox19
        '
        Me.TextBox19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox19.Height = 0.6299213!
        Me.TextBox19.Left = 0.6496062!
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: justify; vertical-align: middle" & _
    "; ddo-char-set: 1"
        Me.TextBox19.Text = Nothing
        Me.TextBox19.Top = 0.0000001192093!
        Me.TextBox19.Width = 2.125984!
        '
        'txt担当者当年4月
        '
        Me.txt担当者当年4月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者当年4月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年4月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年4月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年4月.Height = 0.2125985!
        Me.txt担当者当年4月.Left = 3.228346!
        Me.txt担当者当年4月.Name = "txt担当者当年4月"
        Me.txt担当者当年4月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者当年4月.Text = "999,999"
        Me.txt担当者当年4月.Top = 0.0!
        Me.txt担当者当年4月.Width = 0.5314961!
        '
        'Label14
        '
        Me.Label14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.Label14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label14.Height = 0.2125985!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 2.775591!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.Label14.Text = "(当年)"
        Me.Label14.Top = 0.0!
        Me.Label14.Width = 0.4527559!
        '
        'Label15
        '
        Me.Label15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.Label15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.Label15.Height = 0.2086614!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 2.775591!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.Label15.Text = "(前年)"
        Me.Label15.Top = 0.2125985!
        Me.Label15.Width = 0.4527559!
        '
        'Label16
        '
        Me.Label16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.Label16.Height = 0.2086614!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 2.775591!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "color: Black; font-family: ＭＳ 明朝; font-size: 9pt; text-align: center; vertical-al" & _
    "ign: middle; ddo-char-set: 1"
        Me.Label16.Text = "(対比)"
        Me.Label16.Top = 0.4212598!
        Me.Label16.Width = 0.4527559!
        '
        'txt担当者前年4月
        '
        Me.txt担当者前年4月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者前年4月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者前年4月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者前年4月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者前年4月.Height = 0.2086614!
        Me.txt担当者前年4月.Left = 3.228346!
        Me.txt担当者前年4月.Name = "txt担当者前年4月"
        Me.txt担当者前年4月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者前年4月.Text = "999,999"
        Me.txt担当者前年4月.Top = 0.2125985!
        Me.txt担当者前年4月.Width = 0.5314961!
        '
        'txt担当者対比4月
        '
        Me.txt担当者対比4月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比4月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比4月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比4月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者対比4月.Height = 0.2086614!
        Me.txt担当者対比4月.Left = 3.228346!
        Me.txt担当者対比4月.Name = "txt担当者対比4月"
        Me.txt担当者対比4月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者対比4月.Text = "999.99%"
        Me.txt担当者対比4月.Top = 0.4212599!
        Me.txt担当者対比4月.Width = 0.5314961!
        '
        'txt担当者前年5月
        '
        Me.txt担当者前年5月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者前年5月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者前年5月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者前年5月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者前年5月.Height = 0.2086614!
        Me.txt担当者前年5月.Left = 3.759842!
        Me.txt担当者前年5月.Name = "txt担当者前年5月"
        Me.txt担当者前年5月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者前年5月.Text = "999,999"
        Me.txt担当者前年5月.Top = 0.2125985!
        Me.txt担当者前年5月.Width = 0.5314961!
        '
        'txt担当者当年5月
        '
        Me.txt担当者当年5月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者当年5月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年5月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年5月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年5月.Height = 0.2125985!
        Me.txt担当者当年5月.Left = 3.759842!
        Me.txt担当者当年5月.Name = "txt担当者当年5月"
        Me.txt担当者当年5月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者当年5月.Text = "999,999"
        Me.txt担当者当年5月.Top = 0.00000005960464!
        Me.txt担当者当年5月.Width = 0.5314961!
        '
        'txt担当者対比5月
        '
        Me.txt担当者対比5月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比5月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比5月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比5月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者対比5月.Height = 0.2086614!
        Me.txt担当者対比5月.Left = 3.759842!
        Me.txt担当者対比5月.Name = "txt担当者対比5月"
        Me.txt担当者対比5月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者対比5月.Text = "999.99%"
        Me.txt担当者対比5月.Top = 0.42126!
        Me.txt担当者対比5月.Width = 0.5314961!
        '
        'txt担当者前年6月
        '
        Me.txt担当者前年6月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者前年6月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者前年6月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者前年6月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者前年6月.Height = 0.2086614!
        Me.txt担当者前年6月.Left = 4.291339!
        Me.txt担当者前年6月.Name = "txt担当者前年6月"
        Me.txt担当者前年6月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者前年6月.Text = "999,999"
        Me.txt担当者前年6月.Top = 0.2125985!
        Me.txt担当者前年6月.Width = 0.5314961!
        '
        'txt担当者当年6月
        '
        Me.txt担当者当年6月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者当年6月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年6月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年6月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年6月.Height = 0.2125985!
        Me.txt担当者当年6月.Left = 4.291339!
        Me.txt担当者当年6月.Name = "txt担当者当年6月"
        Me.txt担当者当年6月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者当年6月.Text = "999,999"
        Me.txt担当者当年6月.Top = 0.00000005960464!
        Me.txt担当者当年6月.Width = 0.5314961!
        '
        'txt担当者対比6月
        '
        Me.txt担当者対比6月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比6月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比6月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比6月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者対比6月.Height = 0.2086614!
        Me.txt担当者対比6月.Left = 4.291339!
        Me.txt担当者対比6月.Name = "txt担当者対比6月"
        Me.txt担当者対比6月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者対比6月.Text = "999.99%"
        Me.txt担当者対比6月.Top = 0.4212601!
        Me.txt担当者対比6月.Width = 0.5314961!
        '
        'txt担当者前年7月
        '
        Me.txt担当者前年7月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者前年7月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者前年7月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者前年7月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者前年7月.Height = 0.2086614!
        Me.txt担当者前年7月.Left = 4.822834!
        Me.txt担当者前年7月.Name = "txt担当者前年7月"
        Me.txt担当者前年7月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者前年7月.Text = "999,999"
        Me.txt担当者前年7月.Top = 0.2125985!
        Me.txt担当者前年7月.Width = 0.5314961!
        '
        'txt担当者当年7月
        '
        Me.txt担当者当年7月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者当年7月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年7月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年7月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年7月.Height = 0.2125985!
        Me.txt担当者当年7月.Left = 4.822834!
        Me.txt担当者当年7月.Name = "txt担当者当年7月"
        Me.txt担当者当年7月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者当年7月.Text = "999,999"
        Me.txt担当者当年7月.Top = 0.00000005960464!
        Me.txt担当者当年7月.Width = 0.5314961!
        '
        'txt担当者対比7月
        '
        Me.txt担当者対比7月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比7月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比7月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比7月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者対比7月.Height = 0.2086614!
        Me.txt担当者対比7月.Left = 4.822834!
        Me.txt担当者対比7月.Name = "txt担当者対比7月"
        Me.txt担当者対比7月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者対比7月.Text = "999.99%"
        Me.txt担当者対比7月.Top = 0.4212601!
        Me.txt担当者対比7月.Width = 0.5314961!
        '
        'txt担当者前年8月
        '
        Me.txt担当者前年8月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者前年8月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者前年8月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者前年8月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者前年8月.Height = 0.2086614!
        Me.txt担当者前年8月.Left = 5.354331!
        Me.txt担当者前年8月.Name = "txt担当者前年8月"
        Me.txt担当者前年8月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者前年8月.Text = "999,999"
        Me.txt担当者前年8月.Top = 0.2125985!
        Me.txt担当者前年8月.Width = 0.5314961!
        '
        'txt担当者当年8月
        '
        Me.txt担当者当年8月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者当年8月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年8月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年8月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年8月.Height = 0.2125985!
        Me.txt担当者当年8月.Left = 5.354331!
        Me.txt担当者当年8月.Name = "txt担当者当年8月"
        Me.txt担当者当年8月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者当年8月.Text = "999,999"
        Me.txt担当者当年8月.Top = 0.00000005960464!
        Me.txt担当者当年8月.Width = 0.5314961!
        '
        'txt担当者対比8月
        '
        Me.txt担当者対比8月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比8月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比8月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比8月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者対比8月.Height = 0.2086614!
        Me.txt担当者対比8月.Left = 5.354331!
        Me.txt担当者対比8月.Name = "txt担当者対比8月"
        Me.txt担当者対比8月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者対比8月.Text = "999.99%"
        Me.txt担当者対比8月.Top = 0.42126!
        Me.txt担当者対比8月.Width = 0.5314961!
        '
        'txt担当者前年9月
        '
        Me.txt担当者前年9月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者前年9月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者前年9月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者前年9月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者前年9月.Height = 0.2086614!
        Me.txt担当者前年9月.Left = 5.885827!
        Me.txt担当者前年9月.Name = "txt担当者前年9月"
        Me.txt担当者前年9月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者前年9月.Text = "999,999"
        Me.txt担当者前年9月.Top = 0.2125985!
        Me.txt担当者前年9月.Width = 0.5314961!
        '
        'txt担当者当年9月
        '
        Me.txt担当者当年9月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者当年9月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年9月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年9月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年9月.Height = 0.2125985!
        Me.txt担当者当年9月.Left = 5.885827!
        Me.txt担当者当年9月.Name = "txt担当者当年9月"
        Me.txt担当者当年9月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者当年9月.Text = "999,999"
        Me.txt担当者当年9月.Top = 0.00000005960464!
        Me.txt担当者当年9月.Width = 0.5314961!
        '
        'txt担当者対比9月
        '
        Me.txt担当者対比9月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比9月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比9月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比9月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者対比9月.Height = 0.2086614!
        Me.txt担当者対比9月.Left = 5.885827!
        Me.txt担当者対比9月.Name = "txt担当者対比9月"
        Me.txt担当者対比9月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者対比9月.Text = "999.99%"
        Me.txt担当者対比9月.Top = 0.42126!
        Me.txt担当者対比9月.Width = 0.5314961!
        '
        'txt担当者前年10月
        '
        Me.txt担当者前年10月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者前年10月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者前年10月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者前年10月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者前年10月.Height = 0.2086614!
        Me.txt担当者前年10月.Left = 6.417323!
        Me.txt担当者前年10月.Name = "txt担当者前年10月"
        Me.txt担当者前年10月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者前年10月.Text = "999,999"
        Me.txt担当者前年10月.Top = 0.2125985!
        Me.txt担当者前年10月.Width = 0.5314961!
        '
        'txt担当者当年10月
        '
        Me.txt担当者当年10月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者当年10月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年10月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年10月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年10月.Height = 0.2125985!
        Me.txt担当者当年10月.Left = 6.417323!
        Me.txt担当者当年10月.Name = "txt担当者当年10月"
        Me.txt担当者当年10月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者当年10月.Text = "999,999"
        Me.txt担当者当年10月.Top = 0.00000005960464!
        Me.txt担当者当年10月.Width = 0.5314961!
        '
        'txt担当者対比10月
        '
        Me.txt担当者対比10月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比10月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比10月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比10月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者対比10月.Height = 0.2086614!
        Me.txt担当者対比10月.Left = 6.417323!
        Me.txt担当者対比10月.Name = "txt担当者対比10月"
        Me.txt担当者対比10月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者対比10月.Text = "999.99%"
        Me.txt担当者対比10月.Top = 0.42126!
        Me.txt担当者対比10月.Width = 0.5314961!
        '
        'txt担当者前年11月
        '
        Me.txt担当者前年11月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者前年11月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者前年11月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者前年11月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者前年11月.Height = 0.2086614!
        Me.txt担当者前年11月.Left = 6.948819!
        Me.txt担当者前年11月.Name = "txt担当者前年11月"
        Me.txt担当者前年11月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者前年11月.Text = "999,999"
        Me.txt担当者前年11月.Top = 0.2125985!
        Me.txt担当者前年11月.Width = 0.5314961!
        '
        'txt担当者当年11月
        '
        Me.txt担当者当年11月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者当年11月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年11月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年11月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年11月.Height = 0.2125985!
        Me.txt担当者当年11月.Left = 6.948819!
        Me.txt担当者当年11月.Name = "txt担当者当年11月"
        Me.txt担当者当年11月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者当年11月.Text = "999,999"
        Me.txt担当者当年11月.Top = 0.0!
        Me.txt担当者当年11月.Width = 0.5314961!
        '
        'txt担当者対比11月
        '
        Me.txt担当者対比11月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比11月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比11月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比11月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者対比11月.Height = 0.2086614!
        Me.txt担当者対比11月.Left = 6.948819!
        Me.txt担当者対比11月.Name = "txt担当者対比11月"
        Me.txt担当者対比11月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者対比11月.Text = "999.99%"
        Me.txt担当者対比11月.Top = 0.4212596!
        Me.txt担当者対比11月.Width = 0.5314961!
        '
        'txt担当者前年12月
        '
        Me.txt担当者前年12月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者前年12月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者前年12月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者前年12月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者前年12月.Height = 0.2086614!
        Me.txt担当者前年12月.Left = 7.480313!
        Me.txt担当者前年12月.Name = "txt担当者前年12月"
        Me.txt担当者前年12月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者前年12月.Text = "999,999"
        Me.txt担当者前年12月.Top = 0.2125985!
        Me.txt担当者前年12月.Width = 0.5314961!
        '
        'txt担当者当年12月
        '
        Me.txt担当者当年12月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者当年12月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年12月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年12月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年12月.Height = 0.2125985!
        Me.txt担当者当年12月.Left = 7.480313!
        Me.txt担当者当年12月.Name = "txt担当者当年12月"
        Me.txt担当者当年12月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者当年12月.Text = "999,999"
        Me.txt担当者当年12月.Top = 0.0!
        Me.txt担当者当年12月.Width = 0.5314961!
        '
        'txt担当者対比12月
        '
        Me.txt担当者対比12月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比12月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比12月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比12月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者対比12月.Height = 0.2086614!
        Me.txt担当者対比12月.Left = 7.480313!
        Me.txt担当者対比12月.Name = "txt担当者対比12月"
        Me.txt担当者対比12月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者対比12月.Text = "999.99%"
        Me.txt担当者対比12月.Top = 0.4212604!
        Me.txt担当者対比12月.Width = 0.5314961!
        '
        'txt担当者前年1月
        '
        Me.txt担当者前年1月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者前年1月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者前年1月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者前年1月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者前年1月.Height = 0.2086614!
        Me.txt担当者前年1月.Left = 8.011812!
        Me.txt担当者前年1月.Name = "txt担当者前年1月"
        Me.txt担当者前年1月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者前年1月.Text = "999,999"
        Me.txt担当者前年1月.Top = 0.2125985!
        Me.txt担当者前年1月.Width = 0.5314961!
        '
        'txt担当者当年1月
        '
        Me.txt担当者当年1月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者当年1月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年1月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年1月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年1月.Height = 0.2125985!
        Me.txt担当者当年1月.Left = 8.011812!
        Me.txt担当者当年1月.Name = "txt担当者当年1月"
        Me.txt担当者当年1月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者当年1月.Text = "999,999"
        Me.txt担当者当年1月.Top = 0.0!
        Me.txt担当者当年1月.Width = 0.5314961!
        '
        'txt担当者対比1月
        '
        Me.txt担当者対比1月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比1月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比1月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比1月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者対比1月.Height = 0.2086614!
        Me.txt担当者対比1月.Left = 8.011812!
        Me.txt担当者対比1月.Name = "txt担当者対比1月"
        Me.txt担当者対比1月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者対比1月.Text = "999.99%"
        Me.txt担当者対比1月.Top = 0.4212604!
        Me.txt担当者対比1月.Width = 0.5314961!
        '
        'txt担当者前年2月
        '
        Me.txt担当者前年2月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者前年2月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者前年2月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者前年2月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者前年2月.Height = 0.2086614!
        Me.txt担当者前年2月.Left = 8.543305!
        Me.txt担当者前年2月.Name = "txt担当者前年2月"
        Me.txt担当者前年2月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者前年2月.Text = "999,999"
        Me.txt担当者前年2月.Top = 0.2125985!
        Me.txt担当者前年2月.Width = 0.5314961!
        '
        'txt担当者当年2月
        '
        Me.txt担当者当年2月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者当年2月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年2月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年2月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年2月.Height = 0.2125985!
        Me.txt担当者当年2月.Left = 8.543305!
        Me.txt担当者当年2月.Name = "txt担当者当年2月"
        Me.txt担当者当年2月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者当年2月.Text = "999,999"
        Me.txt担当者当年2月.Top = 0.0!
        Me.txt担当者当年2月.Width = 0.5314961!
        '
        'txt担当者対比2月
        '
        Me.txt担当者対比2月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比2月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比2月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比2月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者対比2月.Height = 0.2086614!
        Me.txt担当者対比2月.Left = 8.543305!
        Me.txt担当者対比2月.Name = "txt担当者対比2月"
        Me.txt担当者対比2月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者対比2月.Text = "999.99%"
        Me.txt担当者対比2月.Top = 0.4212596!
        Me.txt担当者対比2月.Width = 0.5314961!
        '
        'txt担当者前年3月
        '
        Me.txt担当者前年3月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者前年3月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者前年3月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者前年3月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者前年3月.Height = 0.2086614!
        Me.txt担当者前年3月.Left = 9.074805!
        Me.txt担当者前年3月.Name = "txt担当者前年3月"
        Me.txt担当者前年3月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者前年3月.Text = "999,999"
        Me.txt担当者前年3月.Top = 0.2125985!
        Me.txt担当者前年3月.Width = 0.5314961!
        '
        'txt担当者当年3月
        '
        Me.txt担当者当年3月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者当年3月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年3月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年3月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年3月.Height = 0.2125985!
        Me.txt担当者当年3月.Left = 9.074805!
        Me.txt担当者当年3月.Name = "txt担当者当年3月"
        Me.txt担当者当年3月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者当年3月.Text = "999,999"
        Me.txt担当者当年3月.Top = 0.0!
        Me.txt担当者当年3月.Width = 0.5314961!
        '
        'txt担当者対比3月
        '
        Me.txt担当者対比3月.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比3月.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比3月.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比3月.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者対比3月.Height = 0.2086614!
        Me.txt担当者対比3月.Left = 9.074805!
        Me.txt担当者対比3月.Name = "txt担当者対比3月"
        Me.txt担当者対比3月.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者対比3月.Text = "999.99%"
        Me.txt担当者対比3月.Top = 0.4212596!
        Me.txt担当者対比3月.Width = 0.5314961!
        '
        'txt担当者前年累計
        '
        Me.txt担当者前年累計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者前年累計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者前年累計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者前年累計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者前年累計.Height = 0.2086614!
        Me.txt担当者前年累計.Left = 9.606298!
        Me.txt担当者前年累計.Name = "txt担当者前年累計"
        Me.txt担当者前年累計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者前年累計.Text = "999,999"
        Me.txt担当者前年累計.Top = 0.2125985!
        Me.txt担当者前年累計.Width = 0.6299213!
        '
        'txt担当者当年月累計
        '
        Me.txt担当者当年月累計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者当年月累計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年月累計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年月累計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年月累計.Height = 0.2125985!
        Me.txt担当者当年月累計.Left = 9.606298!
        Me.txt担当者当年月累計.Name = "txt担当者当年月累計"
        Me.txt担当者当年月累計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者当年月累計.Text = "999,999"
        Me.txt担当者当年月累計.Top = 0.0!
        Me.txt担当者当年月累計.Width = 0.6299213!
        '
        'txt担当者対比累計
        '
        Me.txt担当者対比累計.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比累計.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比累計.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比累計.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者対比累計.Height = 0.2086614!
        Me.txt担当者対比累計.Left = 9.606298!
        Me.txt担当者対比累計.Name = "txt担当者対比累計"
        Me.txt担当者対比累計.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者対比累計.Text = "999.99%"
        Me.txt担当者対比累計.Top = 0.4212596!
        Me.txt担当者対比累計.Width = 0.6299213!
        '
        'txt担当者対比月平均
        '
        Me.txt担当者対比月平均.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比月平均.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比月平均.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者対比月平均.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者対比月平均.Height = 0.2086614!
        Me.txt担当者対比月平均.Left = 10.23622!
        Me.txt担当者対比月平均.Name = "txt担当者対比月平均"
        Me.txt担当者対比月平均.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者対比月平均.Text = "999.99%"
        Me.txt担当者対比月平均.Top = 0.4212599!
        Me.txt担当者対比月平均.Width = 0.6299213!
        '
        'txt担当者当年月平均
        '
        Me.txt担当者当年月平均.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者当年月平均.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年月平均.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年月平均.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者当年月平均.Height = 0.2125985!
        Me.txt担当者当年月平均.Left = 10.23622!
        Me.txt担当者当年月平均.Name = "txt担当者当年月平均"
        Me.txt担当者当年月平均.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者当年月平均.Text = "999,999"
        Me.txt担当者当年月平均.Top = 0.0000002086163!
        Me.txt担当者当年月平均.Width = 0.6299213!
        '
        'txt担当者前年月平均
        '
        Me.txt担当者前年月平均.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者前年月平均.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者前年月平均.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.txt担当者前年月平均.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Dot
        Me.txt担当者前年月平均.Height = 0.2086614!
        Me.txt担当者前年月平均.Left = 10.23622!
        Me.txt担当者前年月平均.Name = "txt担当者前年月平均"
        Me.txt担当者前年月平均.Style = "font-family: ＭＳ 明朝; font-size: 9.5pt; text-align: right; vertical-align: bottom; " & _
    "ddo-char-set: 1"
        Me.txt担当者前年月平均.Text = "999,999"
        Me.txt担当者前年月平均.Top = 0.2125988!
        Me.txt担当者前年月平均.Width = 0.6299213!
        '
        'CustomerSalesTran
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
        Me.Sections.Add(Me.grpHdr)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.grpFtr計)
        Me.Sections.Add(Me.PageFooter)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-style: normal; text-decoration: none; font-weight: normal; font-size: 10pt; " & _
            "color: Black; font-family: MS UI Gothic; ddo-char-set: 128", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 14pt; font-weight: bold", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.txt得意先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt当年4月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl当年, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl前年, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl対比, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt前年4月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt対比4月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt前年5月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt当年5月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt対比5月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt前年6月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt当年6月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt対比6月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt前年7月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt当年7月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt対比7月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt前年8月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt当年8月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt対比8月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt前年9月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt当年9月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt対比9月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt前年10月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt当年10月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt対比10月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt前年11月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt当年11月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt対比11月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt前年12月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt当年12月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt対比12月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt前年1月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt当年1月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt対比1月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt前年2月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt当年2月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt対比2月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt前年3月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt当年3月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt対比3月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt前年累計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt当年累計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt対比累計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt対比月平均, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt当年月平均, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt前年月平均, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt頁, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt対象年月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者別未引当一覧表, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl8月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl10月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl得意先名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl得意先CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl6月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl9月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl7月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl11月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl12月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl担当者, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者CD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者名, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl累計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl対象年月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl5月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl4月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl1月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl2月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl3月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lbl月平均, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox87, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox86, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計当年4月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計前年4月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計対比4月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計前年5月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計当年5月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計対比5月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計前年6月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計当年6月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計対比6月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計前年7月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計当年7月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計対比7月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計前年8月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計当年8月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計対比8月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計前年9月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計当年9月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計対比9月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計前年10月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計当年10月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計対比10月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計前年11月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計当年11月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計対比11月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計前年12月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計当年12月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計対比12月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計前年1月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計当年1月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計対比1月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計前年2月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計当年2月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計対比2月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計前年3月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計当年3月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計対比3月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計前年累計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計当年累計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計対比累計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計対比月平均, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計当年月平均, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt総合計前年月平均, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者当年4月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者前年4月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者対比4月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者前年5月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者当年5月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者対比5月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者前年6月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者当年6月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者対比6月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者前年7月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者当年7月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者対比7月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者前年8月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者当年8月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者対比8月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者前年9月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者当年9月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者対比9月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者前年10月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者当年10月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者対比10月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者前年11月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者当年11月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者対比11月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者前年12月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者当年12月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者対比12月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者前年1月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者当年1月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者対比1月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者前年2月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者当年2月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者対比2月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者前年3月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者当年3月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者対比3月, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者前年累計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者当年月累計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者対比累計, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者対比月平均, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者当年月平均, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt担当者前年月平均, System.ComponentModel.ISupportInitialize).EndInit()
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
    Private WithEvents txt得意先CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt得意先名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txtNow As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt頁 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt当年4月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents grpHdr As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents txt対象年月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者別未引当一覧表 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl8月 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl得意先名 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl得意先CD As DataDynamics.ActiveReports.Label
    Private WithEvents lbl6月 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl9月 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl7月 As DataDynamics.ActiveReports.Label
    Private WithEvents grpFtr計 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents lbl11月 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl10月 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl12月 As DataDynamics.ActiveReports.Label
    Private WithEvents txt担当者CD As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者名 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl累計 As DataDynamics.ActiveReports.Label
    Private WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Private WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Private WithEvents Label3 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl担当者 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl対象年月 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl当年 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl前年 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl対比 As DataDynamics.ActiveReports.Label
    Private WithEvents txt前年4月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt対比4月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt前年5月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt当年5月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt対比5月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt前年6月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt当年6月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt対比6月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt前年7月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt当年7月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt対比7月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt前年8月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt当年8月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt対比8月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt前年9月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt当年9月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt対比9月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt前年10月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt当年10月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt対比10月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label1 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl5月 As DataDynamics.ActiveReports.Label
    Private WithEvents Label5 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl4月 As DataDynamics.ActiveReports.Label
    Private WithEvents txt前年11月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt当年11月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt対比11月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt前年12月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt当年12月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt対比12月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt前年1月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt当年1月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt対比1月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt前年2月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt当年2月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt対比2月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt前年3月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt当年3月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt対比3月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt前年累計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt当年累計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt対比累計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents lbl1月 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl2月 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl3月 As DataDynamics.ActiveReports.Label
    Private WithEvents lbl月平均 As DataDynamics.ActiveReports.Label
    Private WithEvents txt対比月平均 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt当年月平均 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt前年月平均 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label2 As DataDynamics.ActiveReports.Label
    Private WithEvents TextBox86 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox87 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計当年4月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label17 As DataDynamics.ActiveReports.Label
    Private WithEvents Label18 As DataDynamics.ActiveReports.Label
    Private WithEvents Label19 As DataDynamics.ActiveReports.Label
    Private WithEvents txt総合計前年4月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計対比4月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計前年5月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計当年5月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計対比5月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計前年6月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計当年6月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計対比6月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計前年7月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計当年7月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計対比7月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計前年8月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計当年8月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計対比8月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計前年9月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計当年9月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計対比9月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計前年10月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計当年10月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計対比10月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計前年11月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計当年11月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計対比11月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計前年12月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計当年12月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計対比12月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計前年1月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計当年1月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計対比1月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計前年2月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計当年2月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計対比2月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計前年3月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計当年3月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計対比3月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計前年累計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計当年累計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計対比累計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計対比月平均 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計当年月平均 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt総合計前年月平均 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox11 As DataDynamics.ActiveReports.TextBox
    Private WithEvents TextBox19 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者当年4月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents Label14 As DataDynamics.ActiveReports.Label
    Private WithEvents Label15 As DataDynamics.ActiveReports.Label
    Private WithEvents Label16 As DataDynamics.ActiveReports.Label
    Private WithEvents txt担当者前年4月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者対比4月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者前年5月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者当年5月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者対比5月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者前年6月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者当年6月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者対比6月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者前年7月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者当年7月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者対比7月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者前年8月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者当年8月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者対比8月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者前年9月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者当年9月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者対比9月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者前年10月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者当年10月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者対比10月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者前年11月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者当年11月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者対比11月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者前年12月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者当年12月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者対比12月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者前年1月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者当年1月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者対比1月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者前年2月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者当年2月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者対比2月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者前年3月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者当年3月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者対比3月 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者前年累計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者当年月累計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者対比累計 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者対比月平均 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者当年月平均 As DataDynamics.ActiveReports.TextBox
    Private WithEvents txt担当者前年月平均 As DataDynamics.ActiveReports.TextBox
End Class
