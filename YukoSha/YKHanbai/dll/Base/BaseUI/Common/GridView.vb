Imports System.Windows.Forms

Namespace Common
    Public Class GridView
        '''========================================================================================
        ''' <summary>ﾊﾞｳﾝﾄﾞﾃﾞｰﾀの追加</summary>
        ''' <param name="DBColumn">ﾃﾞｰﾀﾍﾞｰｽの項目</param>
        ''' <param name="MaxLength">項目桁数(数字項目の時)</param>
        ''' <param name="HeaderText">ﾍｯﾀﾞ文字列</param>
        ''' <param name="Visible">True:表示, False:非表示</param>
        ''' <param name="Alignment">明細の文字位置</param>
        ''' <param name="Format">ﾌｫｰﾏｯﾄ書式</param>
        ''' <returns>ﾃﾞｰﾀｺﾝﾄﾛｰﾙ(ﾊﾞｳﾝﾄﾞﾃﾞｰﾀ)</returns>
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
            ' 返却
            '--------------------------------------------------------------------------------------
            Return NewColumn(DBColumn.ColumnName, intLeng, HeaderText, Visible, Alignment, Format, Width)
        End Function

        '''========================================================================================
        ''' <summary>ﾊﾞｳﾝﾄﾞﾃﾞｰﾀの追加</summary>
        ''' <param name="ColumnName">ﾃﾞｰﾀﾍﾞｰｽの項目名</param>
        ''' <param name="MaxLength">項目桁数(数字項目の時)</param>
        ''' <param name="HeaderText">ﾍｯﾀﾞ文字列</param>
        ''' <param name="Visible">True:表示, False:非表示</param>
        ''' <param name="Alignment">明細の文字位置</param>
        ''' <param name="Format">ﾌｫｰﾏｯﾄ書式</param>
        ''' <param name="Width">列幅</param>
        ''' <param name="FontSize">ﾌｫﾝﾄｻｲｽﾞ(列幅計算)</param>
        ''' <returns>ﾃﾞｰﾀｺﾝﾄﾛｰﾙ(ﾊﾞｳﾝﾄﾞﾃﾞｰﾀ)</returns>
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

            ' DataGridViewの列定義
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
            ' 列幅
            '--------------------------------------------------------------------------------------
            If Width = -1 Then
                'フォントオブジェクトの作成
                Dim fnt As New System.Drawing.Font("ＭＳ ゴシック", FontSize)

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
            ' 返却
            '--------------------------------------------------------------------------------------
            Return grdColumn
        End Function
    End Class
End Namespace
