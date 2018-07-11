Imports System.Data
Imports System.Data.SqlClient

Public Class Adapter
#Region "ں��ނ̌���"
    '''========================================================================================
    ''' <SUMMARY>ں��ނ̌���</SUMMARY>   
    ''' <PARAM name="Conditions">������Ұ� �ڸ���(�i������)</PARAM>   
    ''' <PARAM name="startRowIndex">�\������Ő�(0�`)</PARAM>   
    ''' <PARAM name="maximumRows">1�łɕ\������s��</PARAM>   
    ''' <PARAM name="sortExpression">���בւ�����(�������ڂͶ�ςŋ�؂�)</PARAM>   
    ''' <PARAM name="TopCount">�����w��(-1�͑S��)</PARAM>
    ''' <PARAM name="Columns">���o������z��Ŏw��(Nothing�͑S��)</PARAM>
    ''' <RETURNS>�������ʂ�ں��޾��</RETURNS>
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
        ' ���
        '------------------------------------------------------------------
        Dim strSort As String = ""
        Dim strDelm As String = ""

        ' sortExpression�ŕ��ёւ�
        strSort = sortExpression

        ' sortExpression�w�肪������΁AsortDefault�ŕ��ёւ�
        If strSort = "" Then
            strSort = sortDefault
        End If

        ' ����ł��w�肪������΁A��ײ�ط���
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
        ' �ް�SQL��
        '------------------------------------------------------------------
        Dim strSQLBase As String = SQL
        If strSQLBase = "" Then
            strSQLBase = "SELECT * FROM " & datTable.TableName
        End If

        '------------------------------------------------------------------
        ' SQL�� ����
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
        ' SQL����� �ݒ�
        '------------------------------------------------------------------
        Dim sqlTmp As New SqlCommand
        Dim sqlMaker As New BaseDatabase.SQLMaker(strSQL, sqlTmp.Parameters, Conditions)

        sqlMaker.Execute()
        sqlTmp.Connection = sqlCon
        sqlTmp.CommandText = sqlMaker.SQL
        sqlTmp.CommandTimeout = 180

        '------------------------------------------------------------------
        ' �ǉ� ���Ұ�
        '------------------------------------------------------------------
        If startRowIndex <> -1 Then
            sqlTmp.Parameters.Add(New System.Data.SqlClient.SqlParameter("@startRowIndex", startRowIndex))
            sqlTmp.Parameters.Add(New System.Data.SqlClient.SqlParameter("@maximumRows", maximumRows))
        End If

        '------------------------------------------------------------------
        ' ��ײ�ط�����
        '------------------------------------------------------------------
        'datTable.PrimaryKey = Nothing

        '------------------------------------------------------------------
        ' �ް��擾
        '------------------------------------------------------------------
        Dim sqlda As SqlDataAdapter = New SqlDataAdapter(sqlTmp)

        datTable.Rows.Clear()
        sqlda.Fill(datTable)

        '------------------------------------------------------------------
        ' �ް��ԋp
        '------------------------------------------------------------------
        Return datTable
    End Function
#End Region

#Region "ں��ނ̍폜"
    '''========================================================================================
    ''' <SUMMARY>ں��ނ̍폜</SUMMARY>   
    ''' <PARAM name="Conditions">������Ұ� �ڸ���(�폜����)</PARAM>   
    ''' <RETURNS></RETURNS>
    '''========================================================================================
    Public Shared Sub RecordDelete _
                   (ByVal Conditions As Collection _
                  , ByVal sqlCon As SqlConnection _
                  , ByVal sqlCmd As SqlCommand _
                  , ByVal datTable As DataTable _
                   )
        '------------------------------------
        'SQL�� ��`
        '------------------------------------
        Dim strSQL As String

        strSQL = ""
        strSQL &= " DELETE"
        strSQL &= "   FROM  " & datTable.TableName
        strSQL &= " #WHERE#"

        '------------------------------------
        'SQL����� �ݒ�
        '------------------------------------
        Dim sqlMaker As New BaseDatabase.SQLMaker(strSQL, sqlCmd.Parameters, Conditions)

        sqlMaker.Execute()
        sqlCmd.CommandText = sqlMaker.SQL

        '------------------------------------
        '�ǉ� ���Ұ�
        '------------------------------------

        '------------------------------------
        '���s
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

#Region "ں��ނ̌���"
    '''========================================================================================
    ''' <SUMMARY>ں��ނ̌���</SUMMARY>   
    ''' <PARAM name="Conditions">������Ұ� �ڸ���(�i������)</PARAM>   
    ''' <PARAM name="startRowIndex">�\������Ő�(0�`)</PARAM>   
    ''' <PARAM name="maximumRows">1�łɕ\������s��</PARAM>   
    ''' <PARAM name="sortExpression">���בւ�����(�������ڂͶ�ςŋ�؂�)</PARAM>   
    ''' <RETURNS>�������ʂ�ں��ސ�</RETURNS>
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
        ' �ް�SQL��
        '------------------------------------------------------------------
        Dim strSQLBase As String = SQL
        If strSQLBase = "" Then
            strSQLBase = "SELECT * FROM " & datTable.TableName
        End If

        '------------------------------------------------------------------
        'SQL�� ��`
        '------------------------------------------------------------------
        Dim strSQL As String

        strSQL = ""
        strSQL &= " SELECT  COUNT(*)"
        strSQL &= "   FROM (" & strSQLBase & ") AS Counter"
        strSQL &= " #WHERE#"

        '------------------------------------------------------------------
        'SQL����� �ݒ�
        '------------------------------------------------------------------
        Dim sqlTmp As New SqlCommand
        Dim sqlMaker As New BaseDatabase.SQLMaker(strSQL, sqlTmp.Parameters, Conditions)

        sqlMaker.Execute()

        sqlTmp.Connection = sqlCon
        sqlTmp.CommandText = sqlMaker.SQL
        sqlTmp.CommandTimeout = 180

        '------------------------------------------------------------------
        '�ް������擾
        '------------------------------------------------------------------
        sqlCon.Open()
        Dim intRowsCount As Integer = CType(sqlTmp.ExecuteScalar(), Integer)
        sqlCon.Close()

        Return intRowsCount
    End Function

#End Region

#Region "��؂̓Ǎ�"
    '''========================================================================================
    ''' <SUMMARY>��؂̓Ǎ�</SUMMARY>   
    ''' <PARAM name="sqlCmd">�����</PARAM>   
    ''' <RETURNS>���s����(�ı�ނ�RETURN�l)</RETURNS>
    '''========================================================================================
    Public Shared Function SelectQuery(ByVal sqlCon As SqlConnection, ByVal SQL As String, Conditions As Collection) As System.Data.DataTable
        '------------------------------------------------------------------
        ' �ϐ���`
        '------------------------------------------------------------------
        Dim ada As System.Data.SqlClient.SqlDataAdapter
        Dim cmd As New System.Data.SqlClient.SqlCommand
        Dim tbl As New System.Data.DataTable
        Dim State As System.Data.ConnectionState

        '------------------------------------------------------------------
        ' ������
        '------------------------------------------------------------------
        State = sqlCon.State

        Try
            '------------------------------------------------------------------
            ' �ȸ��� �����
            '------------------------------------------------------------------
            If ((sqlCon.State And System.Data.ConnectionState.Open) <> System.Data.ConnectionState.Open) Then
                sqlCon.Open()
            End If

            '------------------------------------------------------------------
            ' SQL �ݒ�
            '------------------------------------------------------------------
            Dim sqlMaker As New BaseDatabase.SQLMaker(SQL, cmd.Parameters, Conditions)
            sqlMaker.Execute()

            cmd.Connection = sqlCon
            cmd.CommandType = CommandType.Text
            cmd.CommandTimeout = 60
            cmd.CommandText = sqlMaker.SQL

            '------------------------------------------------------------------
            ' �ް��擾
            '------------------------------------------------------------------
            ada = New System.Data.SqlClient.SqlDataAdapter(cmd)

            ada.Fill(tbl)

        Catch ex As Exception
            Throw ex
        End Try

        '------------------------------------------------------------------
        ' �ް��ԋp
        '------------------------------------------------------------------
        Return tbl
    End Function
#End Region

#Region "��؂̎��s"
    '''========================================================================================
    ''' <SUMMARY>�ı�ނ̎��s</SUMMARY>   
    ''' <PARAM name="sqlCmd">�����</PARAM>   
    ''' <RETURNS>���s����(�ı�ނ�RETURN�l)</RETURNS>
    '''========================================================================================
    Public Shared Sub ExecuteQuery(ByVal sqlCon As SqlConnection, ByVal SQL As String, ByVal Conditions As Collection)
        '------------------------------------------------------------------
        ' �ϐ���`
        '------------------------------------------------------------------
        Dim sqlCmd As New SqlClient.SqlCommand

        '------------------------------------------------------------------
        ' SQL������
        '------------------------------------------------------------------
        Dim sqlMaker As New BaseDatabase.SQLMaker(SQL, sqlCmd.Parameters, Conditions)

        sqlMaker.Execute()
        sqlCmd.CommandText = sqlMaker.SQL

        '------------------------------------------------------------------
        ' ���ݒ�
        '------------------------------------------------------------------
        sqlCmd.Connection = sqlCon
        sqlCmd.CommandType = CommandType.Text
        sqlCmd.CommandTimeout = 60

        '------------------------------------------------------------------
        ' ���s�O�̺ȸ��ݽð����ێ����Ă����āA�۰�ޏ�ԂȂ珈���I�����۰�ޏ�Ԃɖ߂�
        '------------------------------------------------------------------
        Dim PrevState As System.Data.ConnectionState = sqlCmd.Connection.State

        Try
            '------------------------------------------------------------------
            ' �ȸ��� �����
            '------------------------------------------------------------------
            If ((sqlCmd.Connection.State And System.Data.ConnectionState.Open) <> System.Data.ConnectionState.Open) Then
                sqlCmd.Connection.Open()
            End If

            '------------------------------------------------------------------
            ' �ı�ގ��s
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

#Region "�ı�ނ̎��s"
    '''========================================================================================
    ''' <SUMMARY>�ı�ނ̎��s</SUMMARY>   
    ''' <PARAM name="sqlCmd">�����</PARAM>   
    ''' <RETURNS>���s����(�ı�ނ�RETURN�l)</RETURNS>
    '''========================================================================================
    Public Shared Function StoredExecute(ByVal sqlCmd As SqlCommand, Optional TimeOut As Integer = 60) As Integer
        '------------------------------------------------------------------
        ' ���ݒ�
        '------------------------------------------------------------------
        sqlCmd.CommandType = CommandType.StoredProcedure
        sqlCmd.CommandTimeout = TimeOut

        '------------------------------------------------------------------
        ' ���s�������Ұ���ǉ�
        '------------------------------------------------------------------
        Dim ParamReturn As New SqlClient.SqlParameter("ReturnValue", SqlDbType.Int)
        ParamReturn.Direction = ParameterDirection.ReturnValue

        sqlCmd.Parameters.Add(ParamReturn)

        '------------------------------------------------------------------
        ' ���s�O�̺ȸ��ݽð����ێ����Ă����āA�۰�ޏ�ԂȂ珈���I�����۰�ޏ�Ԃɖ߂�
        '------------------------------------------------------------------
        Dim PrevState As System.Data.ConnectionState = sqlCmd.Connection.State

        Try
            '------------------------------------------------------------------
            ' �ȸ��� �����
            '------------------------------------------------------------------
            If ((sqlCmd.Connection.State And System.Data.ConnectionState.Open) <> System.Data.ConnectionState.Open) Then
                sqlCmd.Connection.Open()
            End If

            '------------------------------------------------------------------
            ' �ı�ގ��s
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
        ' �ް��ԋp
        '------------------------------------------------------------------
        Return CInt(ParamReturn.Value)
    End Function
#End Region

End Class
