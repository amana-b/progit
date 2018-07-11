Imports System

Public Class SQLMaker
    Private _Collections As Collection
    Private _SqlParameter As System.Data.SqlClient.SqlParameterCollection
    Private _SqlOutput As String = ""

#Region "�����è"
    '''========================================================================================
    ''' <summary>��������SQL��</summary>
    '''========================================================================================
    Public ReadOnly Property SQL() As String
        Get
            Return _SqlOutput
        End Get
    End Property

    '''========================================================================================
    ''' <summary>�i���������Ұ�</summary>
    '''========================================================================================
    Public Property Collections() As Collection
        Get
            Return Me._Collections
        End Get
        Set(ByVal value As Collection)
            Me._Collections = value
        End Set
    End Property

    '''========================================================================================
    ''' <summary>��������Ұ�</summary>
    '''========================================================================================
    Public Property SqlParameter() As System.Data.SqlClient.SqlParameterCollection
        Get
            Return Me._SqlParameter
        End Get
        Set(ByVal value As System.Data.SqlClient.SqlParameterCollection)
            Me._SqlParameter = value
        End Set
    End Property
#End Region

#Region "�ݽ�׸�"
    '''========================================================================================
    ''' <summary>�ݽ�׸�</summary>
    ''' <param name="SQL">SQL��</param>
    ''' <param name="sqlParam">��������Ұ�</param>
    '''========================================================================================
    Public Sub New(ByVal SQL As String, ByRef sqlParam As System.Data.SqlClient.SqlParameterCollection)
        Me._SqlOutput = SQL
        Me._Collections = New Collection

        Me._SqlParameter = sqlParam
        Me._SqlParameter.Clear()
    End Sub

    '''========================================================================================
    ''' <summary>�ݽ�׸�</summary>
    ''' <param name="SQL">SQL��</param>
    ''' <param name="sqlParam">��������Ұ�</param>
    ''' <param name="Conditions">�����ڸ���</param>
    '''========================================================================================
    Public Sub New(ByVal SQL As String, ByRef sqlParam As System.Data.SqlClient.SqlParameterCollection, ByRef Conditions As Collection)
        Me._SqlOutput = SQL
        Me._Collections = Conditions

        Me._SqlParameter = sqlParam
        Me._SqlParameter.Clear()
    End Sub
#End Region

#Region "���s"
    '''========================================================================================
    ''' <summary>SQL�� ����</summary>
    '''========================================================================================
    Public Sub Execute(Optional ByVal WhereKeyword As String = "#WHERE#")
        Dim strQueryWord As String

        Dim strWhere As String = ""
        Dim strAndOr As String = " WHERE "

        '------------------------------------------------------------------
        ' �K�v�������ݒ肳��Ă��Ȃ�������A���I��
        '------------------------------------------------------------------
        If Not Me._Collections Is Nothing Then
            For i As Long = 1 To Me._Collections.Count
                Dim clsCond As Condition = Me._Collections(i)

                '----------------------------------------
                ' �ı�ޓ������Ұ�
                '----------------------------------------
                If clsCond.Compare = Contents.Compare.Parameter Then
                    Me._SqlParameter.Add(New System.Data.SqlClient.SqlParameter("@" & clsCond.Name, clsCond.Value))
                    Continue For
                End If

                '----------------------------------------
                ' ���ڋL�q
                '----------------------------------------
                If clsCond.Compare = Contents.Compare.Direct Then
                    strWhere &= strAndOr & "(" & clsCond.Name & ")"
                    strAndOr = " AND "

                    Continue For
                End If

                If clsCond.Value.ToString.Trim = "" And clsCond.EmptyHandle <> Contents.EmptyHandle.Where Then
                    Continue For
                End If

                strWhere &= strAndOr & clsCond.Name & " "
                strQueryWord = "@" & Me._SqlParameter.Count.ToString

                Select Case clsCond.Compare
                    Case Contents.Compare.Equal
                        strWhere &= " = " & strQueryWord
                        Me._SqlParameter.Add(New System.Data.SqlClient.SqlParameter(strQueryWord, clsCond.Value))

                    Case Contents.Compare.NotEqual
                        strWhere &= " <> " & strQueryWord
                        Me._SqlParameter.Add(New System.Data.SqlClient.SqlParameter(strQueryWord, clsCond.Value))

                    Case Contents.Compare.Greater
                        strWhere &= " > " & strQueryWord
                        Me._SqlParameter.Add(New System.Data.SqlClient.SqlParameter(strQueryWord, clsCond.Value))

                    Case Contents.Compare.GreaterEqual
                        strWhere &= " >= " & strQueryWord
                        Me._SqlParameter.Add(New System.Data.SqlClient.SqlParameter(strQueryWord, clsCond.Value))

                    Case Contents.Compare.Less
                        strWhere &= " < " & strQueryWord
                        Me._SqlParameter.Add(New System.Data.SqlClient.SqlParameter(strQueryWord, clsCond.Value))

                    Case Contents.Compare.LessEqual
                        strWhere &= " <= " & strQueryWord
                        Me._SqlParameter.Add(New System.Data.SqlClient.SqlParameter(strQueryWord, clsCond.Value))

                    Case Contents.Compare.LikeCenter
                        strWhere &= " LIKE " & strQueryWord
                        Me._SqlParameter.Add(New System.Data.SqlClient.SqlParameter(strQueryWord, "%" & clsCond.Value & "%"))

                    Case Contents.Compare.LikeFront
                        strWhere &= " LIKE " & strQueryWord
                        Me._SqlParameter.Add(New System.Data.SqlClient.SqlParameter(strQueryWord, clsCond.Value & "%"))

                    Case Contents.Compare.LikeRear
                        strWhere &= " LIKE " & strQueryWord
                        Me._SqlParameter.Add(New System.Data.SqlClient.SqlParameter(strQueryWord, "%" & clsCond.Value))

                    Case Contents.Compare.IsNull
                        strWhere &= " IS NULL "

                    Case Contents.Compare.IsNotNull
                        strWhere &= " IS NOT NULL "

                    Case Contents.Compare.WithIn
                        Dim strComma As String = ""

                        strWhere &= " IN ("
                        For Each Value As String In clsCond.Value.ToString.Split(",")
                            strQueryWord = "@" & Me._SqlParameter.Count.ToString

                            strWhere &= strComma & strQueryWord
                            strComma = ","

                            Me._SqlParameter.Add(New System.Data.SqlClient.SqlParameter(strQueryWord, Value))
                        Next
                        strWhere &= ")"
                End Select

                strAndOr = " AND "
            Next
        End If

        _SqlOutput = _SqlOutput.Replace(WhereKeyword, " " & strWhere & " ")
    End Sub
#End Region
End Class

