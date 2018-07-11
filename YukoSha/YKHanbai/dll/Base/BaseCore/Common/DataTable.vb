Namespace Common.DataTable
    '''========================================================================================
    ''' <SUMMARY>DataTable���󂯎��K�v��ȊO���폜����B</SUMMARY>   
    ''' <RETURNS>True:����I��, False:���Ѵװ</RETURNS>
    '''========================================================================================
    Public Class ColumnRefresh
        '''========================================================================================
        ''' <summary>�ް�����</summary>
        '''========================================================================================
        Public Enum enmTitleStyle
            None
            Required
            View
        End Enum

        Private arrColumn As New Collection

        '<Serializable()> Public 
        Private Structure StructureRow
            Public Key As String
            Public Value As String
            Public TitleStyle As Integer
            Public MinorLength As Integer
        End Structure

        Public Sub Add(ByVal Key As String, Optional ByVal Value As String = "", Optional ByVal TitleStyle As enmTitleStyle = enmTitleStyle.None, Optional ByVal MinorLength As Integer = 0)
            Dim Row As New StructureRow
            Row.Key = Key
            Row.Value = Value
            Row.TitleStyle = TitleStyle
            Row.MinorLength = MinorLength

            arrColumn.Add(Row, Key)
        End Sub

        Public Function Value(ByVal Key As String) As String
            Dim Row As New StructureRow
            Row = arrColumn.Item(Key)

            Return Row.Value
        End Function

        Public Function Value(ByVal Index As Integer) As String
            Dim Row As New StructureRow
            Row = arrColumn.Item(Index)

            Return Row.Value
        End Function

        Public Function TitleStyle(ByVal Key As String) As String
            Dim Row As New StructureRow
            Row = arrColumn.Item(Key)

            Return Row.TitleStyle
        End Function

        Public Function TitleStyle(ByVal Index As Integer) As String
            Dim Row As New StructureRow
            Row = arrColumn.Item(Index)

            Return Row.TitleStyle
        End Function

        Public Function MinorLength(ByVal Key As String) As String
            Dim Row As New StructureRow
            Row = arrColumn.Item(Key)

            Return Row.MinorLength
        End Function

        Public Function MinorLength(ByVal Index As Integer) As String
            Dim Row As New StructureRow
            Row = arrColumn.Item(Index)

            Return Row.MinorLength
        End Function

        Public Function Key(ByVal Index As Integer) As String
            Dim Row As New StructureRow
            Row = arrColumn.Item(Index)

            Return Row.Key
        End Function

        '''========================================================================================
        ''' <SUMMARY>DataTable���󂯎��K�v��ȊO���폜����B</SUMMARY>   
        ''' <RETURNS>True:����I��, False:���Ѵװ</RETURNS>
        '''========================================================================================
        Public Function Execute(ByVal datTable As System.Data.DataTable) As Boolean
            Dim colDelete As New Collection

            '----------------------------------------------------------------------
            ' ��ײ�؃L�[�폜
            '----------------------------------------------------------------------
            datTable.PrimaryKey = Nothing

            '----------------------------------------------------------------------
            ' �s�v��� ����
            '----------------------------------------------------------------------
            For Each datColumn As DataColumn In datTable.Columns
                If arrColumn.Contains(datColumn.ColumnName) Then
                    '���߼�ݕύX
                    If Me.Value(datColumn.ColumnName) <> "" Then
                        datColumn.Caption = Me.Value(datColumn.ColumnName)
                    End If

                    datColumn.Caption &= vbTab & Me.TitleStyle(datColumn.ColumnName)
                    datColumn.Caption &= vbTab & Me.MinorLength(datColumn.ColumnName)
                Else
                    colDelete.Add(datColumn)
                End If
            Next

            '----------------------------------------------------------------------
            ' �s�v��� �폜
            '----------------------------------------------------------------------
            For Each datColumn As DataColumn In colDelete
                datTable.Columns.Remove(datColumn)
            Next

            '----------------------------------------------------------------------
            ' ��̕��בւ�
            '----------------------------------------------------------------------
            Dim intColIndex As Integer = 0
            For Each row As StructureRow In arrColumn
                If datTable.Columns.Contains(row.Key) Then
                    datTable.Columns(row.Key).SetOrdinal(intColIndex)
                    intColIndex += 1
                End If
            Next

            Return True
        End Function
    End Class
End Namespace
