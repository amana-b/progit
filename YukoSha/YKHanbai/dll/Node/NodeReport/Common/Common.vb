Namespace Report
    Public Class Common
        '''========================================================================================
        ''' <summary>配列のDataFieldの設定</summary>
        ''' <param name="ColumnNames">ﾃﾞｰﾀﾍﾞｰｽ名をﾀﾌﾞで区切った文字列</param>
        ''' <returns>DataField文字列</returns>
        '''========================================================================================
        Public Shared Function DataFieldsArray(ByVal ColumnNames As String) As String
            Dim arrDataField() As String = ColumnNames.Split(vbTab)

            If arrDataField.Length = 1 Then Return arrDataField(0)

            Dim strReturn As String = ""
            Dim strDelim As String = "="
            For i As Integer = 0 To arrDataField.Length - 1
                strReturn &= strDelim & arrDataField(i)
                strDelim = " + "
            Next

            '----------------------------------------------------------------------
            ' 返却
            '----------------------------------------------------------------------
            Return strReturn
        End Function
    End Class
End Namespace
