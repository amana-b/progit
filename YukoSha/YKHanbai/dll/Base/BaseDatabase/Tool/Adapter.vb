Imports System.Data
Imports System.Data.SqlClient

Public Class Adapter
#Region "ﾚｺｰﾄﾞの検索"
    '''========================================================================================
    ''' <SUMMARY>ﾚｺｰﾄﾞの検索</SUMMARY>   
    ''' <PARAM name="Conditions">ｸｴﾘﾊﾟﾗﾒｰﾀ ｺﾚｸｼｮﾝ(絞込条件)</PARAM>   
    ''' <PARAM name="startRowIndex">表示する頁数(0～)</PARAM>   
    ''' <PARAM name="maximumRows">1頁に表示する行数</PARAM>   
    ''' <PARAM name="sortExpression">並べ替え項目(複数項目はｶﾝﾏで区切る)</PARAM>   
    ''' <PARAM name="TopCount">件数指定(-1は全件)</PARAM>
    ''' <PARAM name="Columns">抽出する列を配列で指定(Nothingは全列)</PARAM>
    ''' <RETURNS>検索結果のﾚｺｰﾄﾞｾｯﾄ</RETURNS>
    '''========================================================================================
    Public Shared Function RecordSelect _
                   (ByVal Conditions As Collection _
                  , ByVal startRowIndex As Integer _
                  , ByVal maximumRows As Integer _
                  , ByVal sortExpression As String _
                  , ByVal sqlCon As SqlConnection _
                  , ByVal sqlCmd As SqlCommand _
                  , ByVal datTable As DataTable _
                  , ByVal sortDefault As String _
                  , Optional ByVal TopCount As Integer = -1 _
                  , Optional ByVal Columns As String() = Nothing _
                  , Optional ByVal SQL As String = "" _
                   ) As DataTable
        '------------------------------------------------------------------
        ' ｿｰﾄ
        '------------------------------------------------------------------
        Dim strSort As String = ""
        Dim strDelm As String = ""

        ' sortExpressionで並び替え
        strSort = sortExpression

        ' sortExpression指定が無ければ、sortDefaultで並び替え
        If strSort = "" Then
            strSort = sortDefault
        End If

        ' それでも指定が無ければ、ﾌﾟﾗｲﾏﾘｷｰ順
        If strSort = "" Then
            If datTable.PrimaryKey.Length = 0 Then
                strSort &= datTable.Columns(0).ColumnName
            Else
                For Each datColmn As DataColumn In datTable.PrimaryKey
                    strSort &= strDelm & datColmn.ColumnName
                    strDelm = ","
                Next
            End If
        End If

        '------------------------------------------------------------------
        ' ﾍﾞｰｽSQL文
        '------------------------------------------------------------------
        Dim strSQLBase As String = SQL
        If strSQLBase = "" Then
            strSQLBase = "SELECT * FROM " & datTable.TableName
        End If

        '------------------------------------------------------------------
        ' SQL文 生成
        '------------------------------------------------------------------
        Dim strSQL As String

        strSQL = ""
        strSQL &= " SELECT  TOP 100 PERCENT AppendRowNum.*"
        strSQL &= "   FROM (SELECT  " & IIf(TopCount = -1, "", "TOP " & TopCount.ToString)
        If Columns Is Nothing Then
            strSQL &= "                 Original.*"
        Else
            strDelm = ""
            For Each Column As String In Columns
                strSQL &= strDelm & " Original." & Column
                strDelm = ","
            Next
        End If
        strSQL &= "              ,  ROW_NUMBER() OVER (ORDER BY " & strSort & ") AS RowNum"
        strSQL &= "           FROM  (" & strSQLBase & ") AS Original"
        strSQL &= "         #WHERE#"
        strSQL &= "        ) AS AppendRowNum"
        If startRowIndex <> -1 Then
            strSQL &= "  WHERE  AppendRowNum.RowNum   >=  CONVERT(BIGINT, @startRowIndex + 1)"
            strSQL &= "    AND  AppendRowNum.RowNum   <=  CONVERT(BIGINT, @startRowIndex + @maximumRows)"
        End If
        strSQL &= "  ORDER"
        strSQL &= "     BY  RowNum"

        '------------------------------------------------------------------
        ' SQLｺﾏﾝﾄﾞ 設定
        '------------------------------------------------------------------
        Dim sqlTmp As New SqlCommand
        Dim sqlMaker As New BaseDatabase.SQLMaker(strSQL, sqlTmp.Parameters, Conditions)

        sqlMaker.Execute()
        sqlTmp.Connection = sqlCon
        sqlTmp.CommandText = sqlMaker.SQL
        sqlTmp.CommandTimeout = 180

        '------------------------------------------------------------------
        ' 追加 ﾊﾟﾗﾒｰﾀ
        '------------------------------------------------------------------
        If startRowIndex <> -1 Then
            sqlTmp.Parameters.Add(New System.Data.SqlClient.SqlParameter("@startRowIndex", startRowIndex))
            sqlTmp.Parameters.Add(New System.Data.SqlClient.SqlParameter("@maximumRows", maximumRows))
        End If

        '------------------------------------------------------------------
        ' ﾌﾟﾗｲﾏﾘｷｰ消去
        '------------------------------------------------------------------
        'datTable.PrimaryKey = Nothing

        '------------------------------------------------------------------
        ' ﾃﾞｰﾀ取得
        '------------------------------------------------------------------
        Dim sqlda As SqlDataAdapter = New SqlDataAdapter(sqlTmp)

        datTable.Rows.Clear()
        sqlda.Fill(datTable)

        '------------------------------------------------------------------
        ' ﾃﾞｰﾀ返却
        '------------------------------------------------------------------
        Return datTable
    End Function
#End Region

#Region "ﾚｺｰﾄﾞの削除"
    '''========================================================================================
    ''' <SUMMARY>ﾚｺｰﾄﾞの削除</SUMMARY>   
    ''' <PARAM name="Conditions">ｸｴﾘﾊﾟﾗﾒｰﾀ ｺﾚｸｼｮﾝ(削除条件)</PARAM>   
    ''' <RETURNS></RETURNS>
    '''========================================================================================
    Public Shared Sub RecordDelete _
                   (ByVal Conditions As Collection _
                  , ByVal sqlCon As SqlConnection _
                  , ByVal sqlCmd As SqlCommand _
                  , ByVal datTable As DataTable _
                   )
        '------------------------------------
        'SQL文 定義
        '------------------------------------
        Dim strSQL As String

        strSQL = ""
        strSQL &= " DELETE"
        strSQL &= "   FROM  " & datTable.TableName
        strSQL &= " #WHERE#"

        '------------------------------------
        'SQLｺﾏﾝﾄﾞ 設定
        '------------------------------------
        Dim sqlMaker As New BaseDatabase.SQLMaker(strSQL, sqlCmd.Parameters, Conditions)

        sqlMaker.Execute()
        sqlCmd.CommandText = sqlMaker.SQL

        '------------------------------------
        '追加 ﾊﾟﾗﾒｰﾀ
        '------------------------------------

        '------------------------------------
        '実行
        '------------------------------------
        Try
            sqlCon.Open()
            sqlCmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            sqlCon.Close()
        End Try
    End Sub
#End Region

#Region "ﾚｺｰﾄﾞの件数"
    '''========================================================================================
    ''' <SUMMARY>ﾚｺｰﾄﾞの件数</SUMMARY>   
    ''' <PARAM name="Conditions">ｸｴﾘﾊﾟﾗﾒｰﾀ ｺﾚｸｼｮﾝ(絞込条件)</PARAM>   
    ''' <PARAM name="startRowIndex">表示する頁数(0～)</PARAM>   
    ''' <PARAM name="maximumRows">1頁に表示する行数</PARAM>   
    ''' <PARAM name="sortExpression">並べ替え項目(複数項目はｶﾝﾏで区切る)</PARAM>   
    ''' <RETURNS>検索結果のﾚｺｰﾄﾞ数</RETURNS>
    '''========================================================================================
    Public Shared Function RecordCount _
                   (ByVal Conditions As Collection _
                  , ByVal startRowIndex As Integer _
                  , ByVal maximumRows As Integer _
                  , ByVal sortExpression As String _
                  , ByVal sqlCon As SqlConnection _
                  , ByVal sqlCmd As SqlCommand _
                  , ByVal datTable As DataTable _
                  , Optional ByVal SQL As String = "" _
                   ) As Integer
        '------------------------------------------------------------------
        ' ﾍﾞｰｽSQL文
        '------------------------------------------------------------------
        Dim strSQLBase As String = SQL
        If strSQLBase = "" Then
            strSQLBase = "SELECT * FROM " & datTable.TableName
        End If

        '------------------------------------------------------------------
        'SQL文 定義
        '------------------------------------------------------------------
        Dim strSQL As String

        strSQL = ""
        strSQL &= " SELECT  COUNT(*)"
        strSQL &= "   FROM (" & strSQLBase & ") AS Counter"
        strSQL &= " #WHERE#"

        '------------------------------------------------------------------
        'SQLｺﾏﾝﾄﾞ 設定
        '------------------------------------------------------------------
        Dim sqlTmp As New SqlCommand
        Dim sqlMaker As New BaseDatabase.SQLMaker(strSQL, sqlTmp.Parameters, Conditions)

        sqlMaker.Execute()

        sqlTmp.Connection = sqlCon
        sqlTmp.CommandText = sqlMaker.SQL
        sqlTmp.CommandTimeout = 180

        '------------------------------------------------------------------
        'ﾃﾞｰﾀ件数取得
        '------------------------------------------------------------------
        sqlCon.Open()
        Dim intRowsCount As Integer = CType(sqlTmp.ExecuteScalar(), Integer)
        sqlCon.Close()

        Return intRowsCount
    End Function

#End Region

#Region "ｸｴﾘの読込"
    '''========================================================================================
    ''' <SUMMARY>ｸｴﾘの読込</SUMMARY>   
    ''' <PARAM name="sqlCmd">ｺﾏﾝﾄﾞ</PARAM>   
    ''' <RETURNS>実行結果(ｽﾄｱﾄﾞのRETURN値)</RETURNS>
    '''========================================================================================
    Public Shared Function SelectQuery(ByVal sqlCon As SqlConnection, ByVal SQL As String, Conditions As Collection) As System.Data.DataTable
        '------------------------------------------------------------------
        ' 変数定義
        '------------------------------------------------------------------
        Dim ada As System.Data.SqlClient.SqlDataAdapter
        Dim cmd As New System.Data.SqlClient.SqlCommand
        Dim tbl As New System.Data.DataTable
        Dim State As System.Data.ConnectionState

        '------------------------------------------------------------------
        ' 初期化
        '------------------------------------------------------------------
        State = sqlCon.State

        Try
            '------------------------------------------------------------------
            ' ｺﾈｸｼｮﾝ ｵｰﾌﾟﾝ
            '------------------------------------------------------------------
            If ((sqlCon.State And System.Data.ConnectionState.Open) <> System.Data.ConnectionState.Open) Then
                sqlCon.Open()
            End If

            '------------------------------------------------------------------
            ' SQL 設定
            '------------------------------------------------------------------
            Dim sqlMaker As New BaseDatabase.SQLMaker(SQL, cmd.Parameters, Conditions)
            sqlMaker.Execute()

            cmd.Connection = sqlCon
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 60
            cmd.CommandText = sqlMaker.SQL

            '------------------------------------------------------------------
            ' ﾃﾞｰﾀ取得
            '------------------------------------------------------------------
            ada = New System.Data.SqlClient.SqlDataAdapter(cmd)

            ada.Fill(tbl)

        Catch ex As Exception
            Throw ex
        End Try

        '------------------------------------------------------------------
        ' ﾃﾞｰﾀ返却
        '------------------------------------------------------------------
        Return tbl
    End Function
#End Region

#Region "ｸｴﾘの実行"
    '''========================================================================================
    ''' <SUMMARY>ｽﾄｱﾄﾞの実行</SUMMARY>   
    ''' <PARAM name="sqlCmd">ｺﾏﾝﾄﾞ</PARAM>   
    ''' <RETURNS>実行結果(ｽﾄｱﾄﾞのRETURN値)</RETURNS>
    '''========================================================================================
    Public Shared Sub ExecuteQuery(ByVal sqlCon As SqlConnection, ByVal SQL As String, ByVal Conditions As Collection)
        '------------------------------------------------------------------
        ' 変数定義
        '------------------------------------------------------------------
        Dim sqlCmd As New SqlClient.SqlCommand

        '------------------------------------------------------------------
        ' SQL文生成
        '------------------------------------------------------------------
        Dim sqlMaker As New BaseDatabase.SQLMaker(SQL, sqlCmd.Parameters, Conditions)

        sqlMaker.Execute()
        sqlCmd.CommandText = sqlMaker.SQL

        '------------------------------------------------------------------
        ' 環境設定
        '------------------------------------------------------------------
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandType = CommandType.Text
        sqlCmd.CommandTimeout = 60

        '------------------------------------------------------------------
        ' 実行前のｺﾈｸｼｮﾝｽﾃｰﾀｽを保持しておいて、ｸﾛｰｽﾞ状態なら処理終了時ｸﾛｰｽﾞ状態に戻す
        '------------------------------------------------------------------
        Dim PrevState As System.Data.ConnectionState = sqlCmd.Connection.State

        Try
            '------------------------------------------------------------------
            ' ｺﾈｸｼｮﾝ ｵｰﾌﾟﾝ
            '------------------------------------------------------------------
            If ((sqlCmd.Connection.State And System.Data.ConnectionState.Open) <> System.Data.ConnectionState.Open) Then
                sqlCmd.Connection.Open()
            End If

            '------------------------------------------------------------------
            ' ｽﾄｱﾄﾞ実行
            '------------------------------------------------------------------
            sqlCmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex

        Finally
            If (PrevState = System.Data.ConnectionState.Closed) Then
                sqlCmd.Connection.Close()
            End If
        End Try
    End Sub
#End Region

#Region "ｽﾄｱﾄﾞの実行"
    '''========================================================================================
    ''' <SUMMARY>ｽﾄｱﾄﾞの実行</SUMMARY>   
    ''' <PARAM name="sqlCmd">ｺﾏﾝﾄﾞ</PARAM>   
    ''' <RETURNS>実行結果(ｽﾄｱﾄﾞのRETURN値)</RETURNS>
    '''========================================================================================
    Public Shared Function StoredExecute(ByVal sqlCmd As SqlCommand, Optional TimeOut As Integer = 60) As Integer
        '------------------------------------------------------------------
        ' 環境設定
        '------------------------------------------------------------------
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandTimeout = TimeOut

        '------------------------------------------------------------------
        ' 実行結果ﾊﾟﾗﾒｰﾀを追加
        '------------------------------------------------------------------
        Dim ParamReturn As New SqlClient.SqlParameter("ReturnValue", SqlDbType.Int)
        ParamReturn.Direction = ParameterDirection.ReturnValue

        sqlCmd.Parameters.Add(ParamReturn)

        '------------------------------------------------------------------
        ' 実行前のｺﾈｸｼｮﾝｽﾃｰﾀｽを保持しておいて、ｸﾛｰｽﾞ状態なら処理終了時ｸﾛｰｽﾞ状態に戻す
        '------------------------------------------------------------------
        Dim PrevState As System.Data.ConnectionState = sqlCmd.Connection.State

        Try
            '------------------------------------------------------------------
            ' ｺﾈｸｼｮﾝ ｵｰﾌﾟﾝ
            '------------------------------------------------------------------
            If ((sqlCmd.Connection.State And System.Data.ConnectionState.Open) <> System.Data.ConnectionState.Open) Then
                sqlCmd.Connection.Open()
            End If

            '------------------------------------------------------------------
            ' ｽﾄｱﾄﾞ実行
            '------------------------------------------------------------------
            sqlCmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex

        Finally
            If (PrevState = System.Data.ConnectionState.Closed) Then
                sqlCmd.Connection.Close()
            End If
        End Try

        '------------------------------------------------------------------
        ' ﾃﾞｰﾀ返却
        '------------------------------------------------------------------
        Return CInt(ParamReturn.Value)
    End Function
#End Region

End Class
