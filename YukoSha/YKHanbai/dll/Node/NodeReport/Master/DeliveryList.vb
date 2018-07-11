Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class DeliveryList
    Inherits DataDynamics.ActiveReports.ActiveReport
    '''========================================================================================
    ''' <SUMMARY>変数定義</SUMMARY>   
    '''========================================================================================
    Private lngLine As Long = 0

    '''========================================================================================
    ''' <SUMMARY>ﾚﾎﾟｰﾄｽﾀｰﾄ</SUMMARY>   
    '''========================================================================================
    Private Sub DeliveryList_ReportStart(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart

        '------------------------------------------------------------------------------------------
        ' ﾍﾟｰｼﾞ 設定
        '------------------------------------------------------------------------------------------
        Dim arrControls As New ArrayList
        Dim tbl As New NodeDatabase.DataSetView.V0出荷先DataTable

        '------------------------------------------------------------------------------------------
        ' ﾀｲﾄﾙ 設定
        '------------------------------------------------------------------------------------------
        Me.lblTitle.Text = "出 荷 先 リ ス ト"

        '------------------------------------------------------------------------------------------
        ' ｸﾞﾙｰﾌﾟ ﾍｯﾀﾞ
        '------------------------------------------------------------------------------------------
        Me.grpHdr得意先CD.DataField = tbl.得意先CDColumn.ColumnName
        Me.grpHdr得意先CD.NewPage = NewPage.None
        Me.grpHdr得意先CD.RepeatStyle = RepeatStyle.OnPageIncludeNoDetail  ' OnPageIncludeNoDetail･･･改頁した新頁が合計行のみの印字でもﾍｯﾀﾞを印字
        Me.grpHdr得意先CD.KeepTogether = True                              ' ﾍｯﾀﾞの途中で改頁されない様に

        '------------------------------------------------------------------------------------------
        ' ｸﾞﾙｰﾌﾟ ﾌｯﾀ
        '------------------------------------------------------------------------------------------
        '数量
        Me.txt出荷先計.DataField = tbl.出荷先CDColumn.ColumnName
        Me.txt出荷先計.SummaryType = SummaryType.SubTotal
        Me.txt出荷先計.SummaryFunc = SummaryFunc.Count
        Me.txt出荷先計.SummaryRunning = SummaryRunning.None
        Me.txt出荷先計.SummaryGroup = Me.grpHdr得意先CD.Name

        '------------------------------------------------------------------------------------------
        ' Detail
        '------------------------------------------------------------------------------------------
        'Detailにﾃﾞｰﾀが入っていなくてもﾍﾟｰｼﾞいっぱいになるまで繰返し表示
        Me.Detail.RepeatToFill = True

        '------------------------------------------------------------------------------------------
        ' DataField
        '------------------------------------------------------------------------------------------
        'Header
        Me.txt得意先CD.DataField = tbl.得意先CDColumn.ColumnName
        Me.txt得意先名.DataField = tbl.得意先名Column.ColumnName

        'Detail
        Me.txtdtl出荷先CD.DataField = tbl.出荷先CDColumn.ColumnName
        Me.txtdtl出荷先名.DataField = tbl.出荷先名Column.ColumnName
        Me.txtdtl郵便番号.DataField = tbl.郵便番号Column.ColumnName
        Me.txtdtl住所.DataField = tbl.住所FULLColumn.ColumnName
        Me.txtdtlTEL.DataField = tbl.TELColumn.ColumnName
    End Sub

    '''========================================================================================
    ''' <SUMMARY>ﾍﾟｰｼﾞﾍｯﾀﾞ</SUMMARY>   
    '''========================================================================================
    Private Sub PageHeader_Format(sender As Object, e As System.EventArgs) Handles PageHeader.Format
        '----------------------------------------------------------------------
        ' 現在時刻を表示
        '----------------------------------------------------------------------
        Me.txtNow.Text = Format(Now, "yyyy/MM/dd HH:mm:ss")
    End Sub

    '''========================================================================================
    ''' <SUMMARY>明細行</SUMMARY>   
    '''========================================================================================
    Private Sub Detail_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail.Format
        lngLine += 1
    End Sub

    '''========================================================================================
    ''' <SUMMARY>ｸﾞﾙｰﾌﾟﾌｯﾀ</SUMMARY>   
    '''========================================================================================
    Private Sub grpFtr得意先CD_Format(sender As Object, e As System.EventArgs) Handles grpFtr得意先CD.Format
        Me.txt出荷先計.Text = "＊得意先計" & Me.txt出荷先計.Text.ToString & "件"
    End Sub
End Class
