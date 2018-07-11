Imports System.Windows.Forms

Namespace Common
    Public Class GridView
        '''========================================================================================
        ''' <summary>�޳����ް��̒ǉ�</summary>
        ''' <param name="DBColumn">�ް��ް��̍���</param>
        ''' <param name="MaxLength">���ڌ���(�������ڂ̎�)</param>
        ''' <param name="HeaderText">ͯ�ޕ�����</param>
        ''' <param name="Visible">True:�\��, False:��\��</param>
        ''' <param name="Alignment">���ׂ̕����ʒu</param>
        ''' <param name="Format">̫�ϯď���</param>
        ''' <returns>�ް����۰�(�޳����ް�)</returns>
        '''========================================================================================
        Public Shared Function NewColumn(ByVal DBColumn As System.Data.DataColumn _
                              , Optional ByVal MaxLength As Integer = -1 _
                              , Optional ByVal HeaderText As String = "" _
                              , Optional ByVal Visible As Boolean = True _
                              , Optional ByVal Alignment As DataGridViewContentAlignment = DataGridViewContentAlignment.MiddleLeft _
                              , Optional ByVal Format As String = "" _
                              , Optional ByVal Width As Integer = -1 _
                                        ) As DataGridViewBand
            Dim intLeng As Integer
            If MaxLength = -1 Then
                intLeng = DBColumn.MaxLength
            Else
                intLeng = MaxLength
            End If

            '--------------------------------------------------------------------------------------
            ' �ԋp
            '--------------------------------------------------------------------------------------
            Return NewColumn(DBColumn.ColumnName, intLeng, HeaderText, Visible, Alignment, Format, Width)
        End Function

        '''========================================================================================
        ''' <summary>�޳����ް��̒ǉ�</summary>
        ''' <param name="ColumnName">�ް��ް��̍��ږ�</param>
        ''' <param name="MaxLength">���ڌ���(�������ڂ̎�)</param>
        ''' <param name="HeaderText">ͯ�ޕ�����</param>
        ''' <param name="Visible">True:�\��, False:��\��</param>
        ''' <param name="Alignment">���ׂ̕����ʒu</param>
        ''' <param name="Format">̫�ϯď���</param>
        ''' <param name="Width">��</param>
        ''' <param name="FontSize">̫�Ļ���(�񕝌v�Z)</param>
        ''' <returns>�ް����۰�(�޳����ް�)</returns>
        '''========================================================================================
        Public Shared Function NewColumn(ByVal ColumnName As String _
                                       , ByVal MaxLength As Integer _
                              , Optional ByVal HeaderText As String = "" _
                              , Optional ByVal Visible As Boolean = True _
                              , Optional ByVal Alignment As DataGridViewContentAlignment = DataGridViewContentAlignment.MiddleLeft _
                              , Optional ByVal Format As String = "" _
                              , Optional ByVal Width As Integer = -1 _
                              , Optional ByVal FontSize As Integer = 9 _
                                        ) As DataGridViewBand

            ' DataGridView�̗��`
            Dim grdColumn As New DataGridViewColumn
            grdColumn.CellTemplate = New DataGridViewTextBoxCell
            grdColumn.DataPropertyName = ColumnName
            grdColumn.ReadOnly = True
            grdColumn.Visible = Visible
            grdColumn.DefaultCellStyle.Alignment = Alignment
            grdColumn.HeaderCell.Style.Alignment = Alignment
            grdColumn.DefaultCellStyle.Format = Format
            grdColumn.Name = ColumnName

            If HeaderText.Trim <> "" Then
                grdColumn.HeaderText = HeaderText
            Else
                grdColumn.HeaderText = ColumnName
            End If

            '--------------------------------------------------------------------------------------
            ' ��
            '--------------------------------------------------------------------------------------
            If Width = -1 Then
                '�t�H���g�I�u�W�F�N�g�̍쐬
                Dim fnt As New System.Drawing.Font("�l�r �S�V�b�N", FontSize)

                Dim MaxWord As String = ""

                If MaxLength = -1 Then
                    MaxLength = 0
                End If

                If BaseCore.Common.Text.LenB(grdColumn.HeaderText) > MaxWord.PadLeft(MaxLength).Length Then
                    MaxWord = grdColumn.HeaderText
                Else
                    MaxWord = MaxWord.PadLeft(MaxLength)
                End If

                Dim MaxSize As System.Drawing.Size = System.Windows.Forms.TextRenderer.MeasureText(MaxWord, fnt)

                grdColumn.Width = MaxSize.Width + 10
            Else
                grdColumn.Width = Width
            End If

            '--------------------------------------------------------------------------------------
            ' �ԋp
            '--------------------------------------------------------------------------------------
            Return grdColumn
        End Function
    End Class
End Namespace
