Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document

Public Class PaperPriList
    Inherits DataDynamics.ActiveReports.ActiveReport

    Dim strBuff As String
    '''========================================================================================
    ''' <SUMMARY>変数定義</SUMMARY>   
    '''========================================================================================
    Private lngLine As Long = 0

    '''========================================================================================
    ''' <SUMMARY>ﾚﾎﾟｰﾄｽﾀｰﾄ</SUMMARY>   
    '''========================================================================================
    Private Sub PaperPriList_ReportStart(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart
        Dim arrControls As New ArrayList

        ' Detailにﾃﾞｰﾀが入っていなくてもﾍﾟｰｼﾞいっぱいになるまで繰返し表示
        Me.Detail.RepeatToFill = True

        '------------------------------------------------------------------------------------------
        ' ﾍﾟｰｼﾞ 設定
        '------------------------------------------------------------------------------------------
        Dim tbl As New NodeDatabase.DataSetFunc.F0紙価格DataTable

        Me.txtdtl仕入先CD.DataField = tbl.仕入先CDColumn.ColumnName
        Me.txtdtl仕入先名.DataField = tbl.略称Column.ColumnName

        Me.txtdtl社内用紙ｺｰﾄﾞ.DataField = tbl.社内用紙CDColumn.ColumnName
        Me.txtdtl社内用紙名.DataField = tbl.社内用紙名Column.ColumnName
        Me.txtdtl発注用紙ｺｰﾄﾞ.DataField = tbl.発注用紙CDColumn.ColumnName
        Me.txtdtl発注用紙名.DataField = tbl.発注用紙名Column.ColumnName

        Me.txtdtl社内用糊ｺｰﾄﾞ.DataField = tbl.社内用糊CDColumn.ColumnName
        Me.txtdtl社内用糊名.DataField = tbl.社内用糊名Column.ColumnName
        Me.txtdtl発注用糊ｺｰﾄﾞ.DataField = tbl.発注用糊CDColumn.ColumnName
        Me.txtdtl発注用糊名.DataField = tbl.発注用糊名Column.ColumnName

        Me.txtdtl社内用台紙ｺｰﾄﾞ.DataField = tbl.社内用台紙CDColumn.ColumnName
        Me.txtdtl社内用台紙名.DataField = tbl.社内用台紙名Column.ColumnName
        Me.txtdtl発注用台紙ｺｰﾄﾞ.DataField = tbl.発注用台紙CDColumn.ColumnName
        Me.txtdtl発注用台紙名.DataField = tbl.発注用台紙名Column.ColumnName

        Me.txtdtl単価区分.DataField = tbl.単価名Column.ColumnName
        Me.txtdtl単価金額.DataField = tbl.単価Column.ColumnName
        Me.lblhd単価種別.DataField = tbl.種別Column.ColumnName

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

        '社内用
        If Me.txtdtl社内用紙ｺｰﾄﾞ.Value = "0000" Then
            Me.txtdtl社内用紙ｺｰﾄﾞ.Text = ""
            Me.txtdtl社内用紙名.Text = ""
        End If

        If Me.txtdtl社内用糊ｺｰﾄﾞ.Value = "000" Then
            Me.txtdtl社内用糊ｺｰﾄﾞ.Text = ""
            Me.txtdtl社内用糊名.Text = ""
        End If

        If Me.txtdtl社内用台紙ｺｰﾄﾞ.Value = "00" Then
            Me.txtdtl社内用台紙ｺｰﾄﾞ.Text = ""
            Me.txtdtl社内用台紙名.Text = ""
        End If

        '発注用
        If Me.txtdtl仕入先CD.Text <> "" Then
            If Me.txtdtl発注用紙ｺｰﾄﾞ.Value = "0000" Then
                Me.txtdtl発注用紙ｺｰﾄﾞ.Text = ""
                Me.txtdtl発注用紙名.Text = ""
            Else
                If Me.txtdtl発注用紙ｺｰﾄﾞ.Value <> "" Then
                    Me.txtdtl発注用紙ｺｰﾄﾞ.Text = "(" & Me.txtdtl発注用紙ｺｰﾄﾞ.Text & ")"
                    Me.txtdtl発注用紙名.Text = "(" & Me.txtdtl発注用紙名.Text & ")"
                End If
            End If

            If Me.txtdtl発注用糊ｺｰﾄﾞ.Value = "000" Then
                Me.txtdtl発注用糊ｺｰﾄﾞ.Text = ""
                Me.txtdtl発注用糊名.Text = ""
            Else
                If Me.txtdtl発注用糊ｺｰﾄﾞ.Value <> "" Then
                    Me.txtdtl発注用糊ｺｰﾄﾞ.Text = "(" & Me.txtdtl発注用糊ｺｰﾄﾞ.Text & ")"
                    Me.txtdtl発注用糊名.Text = "(" & Me.txtdtl発注用糊名.Text & ")"
                End If
            End If

            If Me.txtdtl発注用台紙ｺｰﾄﾞ.Value = "00" Then
                Me.txtdtl発注用台紙ｺｰﾄﾞ.Text = ""
                Me.txtdtl発注用台紙名.Text = ""
            Else
                If Me.txtdtl発注用台紙ｺｰﾄﾞ.Value <> "" Then
                    Me.txtdtl発注用台紙ｺｰﾄﾞ.Text = "(" & Me.txtdtl発注用台紙ｺｰﾄﾞ.Text & ")"
                    Me.txtdtl発注用台紙名.Text = "(" & Me.txtdtl発注用台紙名.Text & ")"
                End If
            End If
        End If
    End Sub

    '''========================================================================================
    ''' <SUMMARY>仕入先名重複のとき</SUMMARY>   
    '''========================================================================================
    Private Sub Detail_BeforePrint() Handles Detail.BeforePrint
        If (Me.txtdtl仕入先名.Text = strBuff) Then
            ' 同じ名前の場合、空白を
            Me.txtdtl仕入先名.Text = ""
            Me.txtdtl仕入先CD.Text = ""
        End If

        If Me.txtdtl仕入先名.Text <> "" Then
            strBuff = Me.txtdtl仕入先名.Text
        End If
    End Sub

    Private Sub ActiveReport1_PageEnd() Handles MyBase.PageEnd
        ' 改ページ後、最初のデータは必ず出力。
        strBuff = ""
    End Sub

    ' '''========================================================================================
    ' ''' <SUMMARY>ｸﾞﾙｰﾌﾟﾍｯﾀﾞ</SUMMARY>   
    ' '''========================================================================================
    Private Sub GroupHeader_紙価格_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grpHdr紙価格.Format
        Dim tbl As New NodeDatabase.DataSetFunc.F0紙価格DataTable

        If Not Me.lblhd単価種別.Text Like "*）*" Then
            Me.lblhd単価種別.Text = "（" & Me.lblhd単価種別.Text & "）"
        End If
    End Sub

End Class
