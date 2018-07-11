Imports Microsoft.VisualBasic

Namespace Common
    Public Class Numbering
#Region "列挙"
        '''========================================================================================
        ''' <summary>採番ｺｰﾄﾞ</summary>
        '''========================================================================================
        Public Enum ModeContents
            None
            作業NO
        End Enum
#End Region

#Region "変数"
        Private _LastError As String = ""
        Private _Value As String = ""
#End Region

#Region "ﾌﾟﾛﾊﾟﾃｨ"
        '''========================================================================================
        '''  <summary>採番した番号</summary>
        '''========================================================================================
        Public ReadOnly Property Value() As String
            Get
                Return Me._Value
            End Get
        End Property

        '''========================================================================================
        '''  <summary>ｴﾗｰﾒｯｾｰｼﾞ</summary>
        '''========================================================================================
        Public ReadOnly Property LastError() As String
            Get
                Return Me._LastError
            End Get
        End Property
#End Region

#Region "ﾒｿｯﾄﾞ"
#Region "DataExecute  [実行]"
        '''========================================================================================
        ''' <SUMMARY>読込</SUMMARY>   
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Public Function Execute(ByVal mode As ModeContents) As Boolean
            '----------------------------------------------------------------------
            ' ｴﾗｰｸﾘｱ
            '----------------------------------------------------------------------
            Me._LastError = ""

            '----------------------------------------------------------------------
            ' 採番ｺｰﾄﾞ 算出
            '----------------------------------------------------------------------
            Dim strCode As String = ""
            Select Case mode
                Case ModeContents.作業NO : strCode = "作業NO"
            End Select

            '----------------------------------------------------------------------
            ' S採番 更新
            '----------------------------------------------------------------------
            Dim ada As New NodeDatabase.DataSetSystemTableAdapters.S採番TableAdapter
            Dim tbl As New NodeDatabase.DataSetSystem.S採番DataTable
            Dim qry As New Collection

            ' ﾘﾄﾗｲ 10回
            For i As Integer = 1 To 10
                Try
                    qry.Clear()
                    qry.Add(New BaseDatabase.Condition(tbl.採番区分Column.ColumnName, strCode, BaseDatabase.Contents.Compare.Equal))
                    tbl = ada.SelectByCommon(qry)
                    If tbl.Count > 0 Then
                        Me._Value = Me.NumberFormat(tbl(0).最終NO, tbl(0).桁数)

                        tbl(0).最終NO = Me._Value
                        ada.Update(tbl)
                    Else
                        Me._Value = Me.NumberFormat("0", 10)

                        ada.Insert(strCode, 10, Me._Value)
                    End If

                    Exit For

                Catch ex As Exception
                    If i = 10 Then
                        Me._LastError = "以下のエラーのため、S採番が更新できませんでした。" & vbCrLf & ex.Message
                        Return False
                    End If
                End Try
            Next

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return True
        End Function
#End Region
#End Region

#Region "ﾌﾟﾛｼｰｼﾞｬ"
        '''========================================================================================
        ''' <SUMMARY>最終NO 取得</SUMMARY>   
        '''========================================================================================
        Private Function NumberFormat(ByVal Num As String, ByVal Length As Integer) As String
            Dim strReturn As String = ""

            '----------------------------------------------------------------------
            ' 最終NO 採番
            '----------------------------------------------------------------------
            strReturn = BaseCore.Common.Text.TextFormat(BaseCore.Common.Text.CVal(Num) + 1, Length, BaseContents.TextBox.TextStyle.Code, , True)

            '----------------------------------------------------------------------
            ' 返却
            '----------------------------------------------------------------------
            Return strReturn
        End Function
#End Region
    End Class
End Namespace
