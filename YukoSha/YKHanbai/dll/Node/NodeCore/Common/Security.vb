Namespace Common
    Public Class Security

#Region "ﾌﾟﾛﾊﾟﾃｨ"
        Public IPAddr As String = ""
#End Region

#Region "ｺﾝｽﾄﾗｸﾀ"
        '''========================================================================================
        ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
        '''========================================================================================
        Public Sub New()
        End Sub
#End Region

#Region "ﾛｸﾞ出力"
        '''========================================================================================
        ''' <summary>ﾛｸﾞを出力する(※)</summary>
        ''' <param name="Subject">ﾀｲﾄﾙ</param>
        ''' <param name="Body">本文</param>
        ''' <param name="ModuleID">ﾓｼﾞｭｰﾙID</param>
        ''' <param name="ModuleName">ﾓｼﾞｭｰﾙ名</param>
        '''========================================================================================
        Public Sub WriteLog(ByVal Subject As String _
                          , ByVal Body As String _
                          , Optional ByVal ModuleID As String = "" _
                          , Optional ByVal ModuleName As String = "" _
                           )
            Dim ada As New NodeDatabase.DataSetTranTableAdapters.TログTableAdapter
            Dim tbl As New NodeDatabase.DataSetTran.TログDataTable
            Dim qry As New Collection

            '------------------------------------------------------------------
            ' ﾛｸﾞを記録(Definesで「ﾛｸﾞ出力する」の指定の時のみ)
            '------------------------------------------------------------------
            If NodeContents.Constant.System.LOG_RECORD Then
                Try
                    ada.Insert(Format(Now, "yyyy/MM/dd") _
                             , Format(Now, "HH:mm:ss") _
                             , "" _
                             , IPAddr _
                             , ModuleID _
                             , ModuleName _
                             , Subject _
                             , Body _
                             , "" _
                              )
                Catch ex As Exception
                End Try
            End If
        End Sub
#End Region
    End Class
End Namespace
