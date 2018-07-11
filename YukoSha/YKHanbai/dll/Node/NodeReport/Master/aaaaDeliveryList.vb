Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class aaaaDeliveryList
    Inherits DataDynamics.ActiveReports.ActiveReport
    '''========================================================================================
    ''' <SUMMARY>変数定義</SUMMARY>   
    '''========================================================================================
    Private lngLine As Long = 0

    '''========================================================================================
    ''' <SUMMARY>ﾚﾎﾟｰﾄｽﾀｰﾄ</SUMMARY>   
    '''========================================================================================
    Private Sub aaaaDeliveryList_ReportStart(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart
        Dim arrControls As New ArrayList

        ' Detailにﾃﾞｰﾀが入っていなくてもﾍﾟｰｼﾞいっぱいになるまで繰返し表示
        'Me.Detail.RepeatToFill = True

        '------------------------------------------------------------------------------------------
        ' ﾍﾟｰｼﾞ 設定
        '------------------------------------------------------------------------------------------
        Dim tbl As New NodeDatabase.DataSetView.V0出荷先DataTable

        '数量
        Me.txt出荷先計.DataField = tbl.出荷先CDColumn.ColumnName
        Me.txt出荷先計.SummaryType = SummaryType.SubTotal
        Me.txt出荷先計.SummaryFunc = SummaryFunc.Count
        Me.txt出荷先計.SummaryRunning = SummaryRunning.None
        Me.txt出荷先計.SummaryGroup = Me.grpHdr得意先CD.Name
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
        Me.txt出荷先計.Text = Me.txt出荷先計.Text.ToString & "件"
    End Sub
End Class
