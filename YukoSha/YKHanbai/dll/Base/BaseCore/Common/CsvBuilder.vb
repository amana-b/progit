Namespace Common
    Public Class CsvBuilder
        Private _LastError As String

#Region "ﾌﾟﾛﾊﾟﾃｨ"
        '''========================================================================================
        ''' <summary>ｴﾗｰ</summary>
        ''' <returns>ｴﾗｰﾒｯｾｰｼﾞ</returns>
        '''========================================================================================
        Public ReadOnly Property LastError() As String
            Get
                Return _LastError
            End Get
        End Property
#End Region

#Region "Export"
        '''----------------------------------------------------------------------------------------
        ''' <summary>ﾃﾞｰﾀﾃｰﾌﾞﾙをﾃｷｽﾄ出力する</summary>
        '''----------------------------------------------------------------------------------------
        Public Function ExportFile(ByVal datTable As System.Data.DataTable, ByVal Path As String, Optional ByVal TitleWrite As Boolean = True) As Boolean
            '----------------------------------------------------------------------
            ' ﾌｧｲﾙ 出力
            '----------------------------------------------------------------------
            Dim wriStream As New System.IO.StreamWriter(Path, False, System.Text.Encoding.GetEncoding("Shift_JIS"))
            Try
                Dim strDelim As String = ""

                '----------------------------------------------------------------------------------------
                ' ﾀｲﾄﾙ 出力
                '----------------------------------------------------------------------------------------
                If TitleWrite Then
                    For Each col As DataColumn In datTable.Columns
                        Dim arrCaption As String() = col.Caption.Split(vbTab)

                        wriStream.Write(strDelim & illegalValue(arrCaption(0)))
                        strDelim = ","
                    Next
                    wriStream.Write(vbCrLf)
                End If

                '----------------------------------------------------------------------------------------
                ' 値 出力
                '----------------------------------------------------------------------------------------
                For Each row As DataRow In datTable.Rows
                    strDelim = ""
                    For Each col As DataColumn In row.Table.Columns

                        ' ｵﾌﾟｼｮﾝ取得
                        Dim arrCaption As String() = col.Caption.Split(vbTab)

                        Select Case col.DataType.Name
                            Case GetType(String).Name
                                wriStream.Write(strDelim & illegalValue(row.Item(col.ColumnName)))
                                strDelim = ","
                            Case Else
                                If arrCaption.Length > 2 Then
                                    If BaseCore.Common.Text.CVal(arrCaption(2)) = 0 Then
                                        wriStream.Write(strDelim & illegalValue(Format(row.Item(col.ColumnName), "##0")))
                                        strDelim = ","
                                    Else
                                        wriStream.Write(strDelim & illegalValue(Format(row.Item(col.ColumnName), "##0." & StrDup(CInt(BaseCore.Common.Text.CVal(arrCaption(2))), "0") & ";" & "-##0." & StrDup(CInt(BaseCore.Common.Text.CVal(arrCaption(2))), "0") & ";" & "#")))
                                        strDelim = ","
                                    End If
                                Else
                                    wriStream.Write(strDelim & illegalValue(Format(row.Item(col.ColumnName), "##0")))
                                    strDelim = ","
                                End If
                        End Select
                    Next
                    wriStream.Write(vbCrLf)
                Next

            Catch ex As Exception
                _LastError = ex.Message
                Return False

            Finally
                wriStream.Close()
            End Try

            '----------------------------------------------------------------------
            ' 返却
            '----------------------------------------------------------------------
            Return True
        End Function

        '''----------------------------------------------------------------------------------------
        ''' <summary>ﾃﾞｰﾀ配列をﾃｷｽﾄ出力する</summary>
        '''----------------------------------------------------------------------------------------
        Public Function ExportFile(ByVal datRows() As DataRow, ByVal Path As String) As Boolean
            '----------------------------------------------------------------------
            ' ﾌｧｲﾙ 出力
            '----------------------------------------------------------------------
            Dim wriStream As New System.IO.StreamWriter(Path, False, System.Text.Encoding.GetEncoding("Shift_JIS"))
            Try
                Dim strDelim As String = ""

                '----------------------------------------------------------------------------------------
                ' 値 出力
                '----------------------------------------------------------------------------------------
                For Each row As DataRow In datRows
                    strDelim = ""
                    For Each col As DataColumn In row.Table.Columns
                        wriStream.Write(strDelim & illegalValue(row.Item(col.ColumnName)))
                        strDelim = ","
                    Next
                    wriStream.Write(vbCrLf)
                Next

            Catch ex As Exception
                _LastError = ex.Message
                Return False

            Finally
                wriStream.Close()
            End Try

            '----------------------------------------------------------------------
            ' 返却
            '----------------------------------------------------------------------
            Return True
        End Function
#End Region

#Region "禁則文字の対処"
        '''----------------------------------------------------------------------------------------
        ''' <summary>改行→空文字, ｶﾝﾏ→空白</summary>
        '''----------------------------------------------------------------------------------------
        Private Function illegalValue(ByVal value As Object) As String
            Select Case value.GetType.Name
                Case "Decimal", "Single", "Byte", "Double", "Int16", "Int32", "Int64", "Intger", "SByte"
                Case Else
                    value = BaseCore.Common.Text.Nz(value, "")

                    If value <> "" Then
                        value = Replace(value, vbCrLf, "")
                        'value = Replace(value, ",", " ")
                    End If
            End Select


            Return value
        End Function
#End Region
    End Class
End Namespace
