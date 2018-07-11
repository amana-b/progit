Namespace Common
    Public Class FileIO
#Region "列挙"
        '''========================================================================================
        '''  <summary>変換ﾓｰﾄﾞ</summary>
        '''========================================================================================
        Public Enum enumExchangeMode
            ToAbsolute = 1      '相対→絶対
            ToRelative = 2      '絶対→相対
        End Enum
#End Region

#Region "相対ﾊﾟｽ⇔絶対ﾊﾟｽ"
        '''========================================================================================
        ''' <summary>相対ﾊﾟｽ⇔絶対ﾊﾟｽ</summary>
        ''' <param name="BaseDir">基準となるﾃﾞｨﾚｸﾄﾘ(絶対指定)</param>
        ''' <param name="TargetPath">変換したいﾀｰｹﾞｯﾄﾊﾟｽ</param>
        ''' <returns>変換した結果</returns>
        '''========================================================================================
        Public Shared Function ExchangePathStyle(ByVal Mode As enumExchangeMode, ByVal BaseDir As String, ByVal TargetPath As String) As String
            Dim ret As String = ""

            Try
                Dim u1 As New Uri(BaseDir)
                Dim u2 As New Uri(u1, TargetPath.Replace("~", "."))

                Select Case Mode
                    Case enumExchangeMode.ToAbsolute : ret = u2.LocalPath
                    Case enumExchangeMode.ToRelative : ret = "~/" & u1.MakeRelativeUri(u2).ToString
                End Select

            Catch ex As Exception
            End Try

            Return ret
        End Function
#End Region
    End Class
End Namespace
