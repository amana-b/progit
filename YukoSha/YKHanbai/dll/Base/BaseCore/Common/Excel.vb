Namespace Common
    Public Class Excel
        Public Element() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" _
                                     , "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ" _
                                     , "BA", "BB", "BC", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BK", "BL", "BM", "BN", "BO", "BP", "BQ", "BR", "BS", "BT", "BU", "BV", "BW", "BX", "BY", "BZ" _
                                     , "CA", "CB", "CC", "CD", "CE", "CF", "CG", "CH", "CI", "CJ", "CK", "CL", "CM", "CN", "CO", "CP", "CQ", "CR", "CS", "CT", "CU", "CV", "CW", "CX", "CY", "CZ" _
                                     , "DA", "DB", "DC", "DD", "DE", "DF", "DG", "DH", "DI", "DJ", "DK", "DL", "DM", "DN", "DO", "DP", "DQ", "DR", "DS", "DT", "DU", "DV", "DW", "DX", "DY", "DZ" _
                                     , "EA", "EB", "EC", "ED", "EE", "EF", "EG", "EH", "EI", "EJ", "EK", "EL", "EM", "EN", "EO", "EP", "EQ", "ER", "ES", "ET", "EU", "EV", "EW", "EX", "EY", "EZ" _
                                     , "FA", "FB", "FC", "FD", "FE", "FF", "FG", "FH", "FI", "FJ", "FK", "FL", "FM", "FN", "FO", "FP", "FQ", "FR", "FS", "FT", "FU", "FV", "FW", "FX", "FY", "FZ" _
                                     , "GA", "GB", "GC", "GD", "GE", "GF", "GG", "GH", "GI", "GJ", "GK", "GL", "GM", "GN", "GO", "GP", "GQ", "GR", "GS", "GT", "GU", "GV", "GW", "GX", "GY", "GZ" _
                                     , "HA", "HB", "HC", "HD", "HE", "HF", "HG", "HH", "HI", "HJ", "HK", "HL", "HM", "HN", "HO", "HP", "HQ", "HR", "HS", "HT", "HU", "HV", "HW", "HX", "HY", "HZ" _
                                     , "IA", "IB", "IC", "ID", "IE", "IF", "IG", "IH", "II", "IJ", "IK", "IL", "IM", "IN", "IO", "IP", "IQ", "IR", "IS", "IT", "IU", "IV" _
                                      }

#Region "ﾌﾟﾛﾊﾟﾃｨ"
        '''========================================================================================
        ''' <summary>ﾜｰｸﾌﾞｯｸ</summary>
        '''========================================================================================
        Private _Book As SpreadsheetGear.IWorkbook
        Public Property Book() As SpreadsheetGear.IWorkbook
            Get
                Return _Book
            End Get
            Set(ByVal value As SpreadsheetGear.IWorkbook)
                _Book = value
            End Set
        End Property

        '''========================================================================================
        ''' <summary>ﾜｰｸｼｰﾄ</summary>
        '''========================================================================================
        Private _Sheet As SpreadsheetGear.IWorksheet
        Public Property Sheet() As SpreadsheetGear.IWorksheet
            Get
                Return _Sheet
            End Get
            Set(ByVal value As SpreadsheetGear.IWorksheet)
                _Sheet = value
            End Set
        End Property

        '''========================================================================================
        ''' <summary>ｴﾗｰﾒｯｾｰｼﾞ</summary>
        '''========================================================================================
        Private _LastError As String
        Public ReadOnly Property LastError() As String
            Get
                Return _LastError
            End Get
        End Property

        '''========================================================================================
        ''' <summary>列数→列名 変換</summary>
        '''========================================================================================
        Public ReadOnly Property ElementNumToName(ByVal Number As Integer) As String
            Get
                Return Me.Element(Number - 1) + ":" + Me.Element(Number - 1)
            End Get
        End Property
#End Region

#Region "Book"
#Region "ﾌｧｲﾙ ｵｰﾌﾟﾝ"
        '''========================================================================================
        ''' <summary>ﾌｧｲﾙ ｵｰﾌﾟﾝ</summary>
        ''' <param name="FilePath">ﾊﾟｽ(指定なしは、空ﾌｧｲﾙをｵｰﾌﾟﾝ)</param>
        ''' <returns>True:成功、False:失敗</returns>
        '''========================================================================================
        Public Function Open(Optional ByVal FilePath As String = Nothing) As Boolean
            Try
                _Book = SpreadsheetGear.Factory.GetWorkbook(FilePath)
            Catch ex As Exception
                _LastError = ex.Message
                Return False
            End Try

            Return True
        End Function
#End Region

#Region "ﾌｧｲﾙ ｸﾛｰｽﾞ"
        '''========================================================================================
        ''' <summary>ﾌｧｲﾙ ｸﾛｰｽﾞ</summary>
        ''' <param name="SavePath">Excelﾌｧｲﾙ保存ﾊﾟｽ</param>
        ''' <returns>True:成功、False:失敗</returns>
        '''========================================================================================
        Public Function Close(Optional ByVal SavePath As String = "", Optional ByVal FileFormat As SpreadsheetGear.FileFormat = SpreadsheetGear.FileFormat.Excel8) As Boolean
            Try
                If SavePath = "" Then
                    _Book.Save()
                Else
                    _Book.SaveAs(SavePath, FileFormat)
                End If
            Catch ex As Exception
                _LastError = ex.Message
                Return False
            End Try

            Return True
        End Function
#End Region

#Region "ﾌｧｲﾙ 新規"
        '''========================================================================================
        ''' <summary>ﾌｧｲﾙ 新規</summary>
        ''' <returns>True:成功、False:失敗</returns>
        '''========================================================================================
        Public Function Create() As Boolean
            Try
                _Book = SpreadsheetGear.Factory.GetWorkbook(New System.Globalization.CultureInfo(1041))
            Catch ex As Exception
                _LastError = ex.Message
                Return False
            End Try

            Return True
        End Function
#End Region
#End Region

#Region "Sheet"
#Region "ｼｰﾄの選択"
        '''========================================================================================
        ''' <summary>ｼｰﾄの選択</summary>
        ''' <param name="SheetName">選択するｼｰﾄ名</param>
        ''' <returns>True:成功、False:失敗</returns>
        '''========================================================================================
        Public Function SheetSelect(ByVal SheetName As String) As Boolean
            Try
                _Sheet = _Book.Sheets(SheetName)
            Catch ex As Exception
                _LastError = ex.Message
                Return False
            End Try

            Return True
        End Function

        '''========================================================================================
        ''' <summary>ｼｰﾄの選択</summary>
        ''' <param name="SheetIndent">選択するｼｰﾄ番号</param>
        ''' <returns>True:成功、False:失敗</returns>
        '''========================================================================================
        Public Function SheetSelect(ByVal SheetIndent As Integer) As Boolean
            Try
                _Sheet = _Book.Sheets(SheetIndent - 1)
            Catch ex As Exception
                _LastError = ex.Message
                Return False
            End Try

            Return True
        End Function
#End Region

#Region "ｼｰﾄの削除"
        '''========================================================================================
        ''' <summary>ｼｰﾄの削除</summary>
        ''' <param name="SheetName">削除するｼｰﾄ名</param>
        ''' <returns>True:成功、False:失敗</returns>
        '''========================================================================================
        Public Function SheetDelete(ByVal SheetName As String) As Boolean
            Try
                Me.SheetSelect(SheetName)
                _Sheet.Delete()
                _Sheet = Nothing
            Catch ex As Exception
                _LastError = ex.Message
                Return False
            End Try

            Return True
        End Function

        '''========================================================================================
        ''' <summary>ｼｰﾄの削除</summary>
        ''' <param name="SheetIdent">削除するｼｰﾄ番号</param>
        ''' <returns>True:成功、False:失敗</returns>
        '''========================================================================================
        Public Function SheetDelete(ByVal SheetIdent As Integer) As Boolean
            Try
                Me.SheetSelect(SheetIdent)
                _Sheet.Delete()
                _Sheet = Nothing
            Catch ex As Exception
                _LastError = ex.Message
                Return False
            End Try

            Return True
        End Function
#End Region

#Region "シート保護"
        '''========================================================================================
        ''' <summary>シート保護</summary>
        '''========================================================================================
        Public Sub Protect()
            _Sheet.Protect("sign")
        End Sub
#End Region

#Region "シート解除"
        '''========================================================================================
        ''' <summary>シート解除</summary>
        '''========================================================================================
        Public Sub Unprotect()
            _Sheet.Unprotect("sign")
        End Sub
#End Region

#Region "ｼｰﾄのｺﾋﾟｰ"
        '''========================================================================================
        ''' <summary>ｼｰﾄのｺﾋﾟｰ</summary>
        ''' <param name="SheetNameF">ｺﾋﾟｰ元ｼｰﾄ名</param>
        ''' <param name="SheetNameT">ｺﾋﾟｰ先ｼｰﾄ名</param>
        '''========================================================================================
        Public Sub SheetCopy(ByVal SheetNameF As String, ByVal SheetNameT As String)
            Dim SheetF As SpreadsheetGear.IWorksheet = _Book.Sheets(SheetNameF)
            Dim SheetT As SpreadsheetGear.IWorksheet = SheetF.CopyAfter(SheetF)

            SheetT.Name = SheetNameT
        End Sub
#End Region

#Region "アクティブシートの最終行を返す"
        '''========================================================================================
        ''' <summary>アクティブシートの最終行位置を返す</summary>
        ''' <returns>最終行位置</returns>
        '''========================================================================================
        Public Function LastRowIndex() As Integer
            Return _Sheet.UsedRange.RowCount
        End Function
#End Region

#Region "アクティブシートの最終列を返す"
        '''========================================================================================
        ''' <summary>アクティブシートの最終列位置を返す</summary>
        ''' <returns>最終列位置</returns>
        '''========================================================================================
        Public Function LastColIndex() As Integer
            Return _Sheet.UsedRange.ColumnCount
        End Function
#End Region
#End Region

#Region "Cell"
#Region "指定したｾﾙに値を設定する"
        '''========================================================================================
        ''' <summary>指定したセルに値を設定する</summary>
        ''' <param name="IndexRow">行位置(1から始まる)</param>
        ''' <param name="IndexCol">列位置(1から始まる)</param>
        ''' <param name="RangeValue">設定する値</param>
        ''' <param name="FormatSting">ｾﾙ書式</param>
        '''========================================================================================
        Public Sub CellSetValue(ByVal IndexRow As Long, ByVal IndexCol As Long, ByVal RangeValue As Object, Optional FormatSting As String = "")
            If IndexRow < 1 Or IndexCol < 1 Then Return

            If FormatSting <> "" Then
                _Sheet.Cells(IndexRow - 1, IndexCol - 1).NumberFormat = FormatSting
            End If

            _Sheet.Cells(IndexRow - 1, IndexCol - 1).Value = RangeValue
        End Sub
#End Region

#Region "指定したｾﾙに数式を設定する"
        '''========================================================================================
        ''' <summary>指定したセルに数式を設定する</summary>
        ''' <param name="IndexRow">行位置(1から始まる)</param>
        ''' <param name="IndexCol">列位置(1から始まる)</param>
        ''' <param name="RangeValue">設定する値</param>
        '''========================================================================================
        Public Sub CellSetFormula(ByVal IndexRow As Long, ByVal IndexCol As Long, ByVal RangeValue As Object)
            If IndexRow < 1 Or IndexCol < 1 Then Return

            _Sheet.Cells(IndexRow - 1, IndexCol - 1).Formula = RangeValue
        End Sub
#End Region

#Region "指定したｾﾙに色を付ける"
        '''========================================================================================
        ''' <summary>指定したｾﾙ背景に色を付ける</summary>
        ''' <param name="ColorValue">設定する色</param>
        ''' <param name="IndexRow">行位置(1から始まる)</param>
        ''' <param name="IndexCol">列位置(1から始まる)</param>
        '''========================================================================================
        Public Sub CellSetColor(ByVal ColorValue As System.Drawing.Color _
                              , ByVal IndexRow As Long _
                              , ByVal IndexCol As Long _
                               )
            If IndexRow < 1 Or IndexCol < 1 Then Return

            _Sheet.Cells(IndexRow - 1, IndexCol - 1).Interior.Color = ColorValue
            Select Case True
                Case IndexRow = -1
                    _Sheet.Cells(-1, IndexCol - 1).Interior.Color = ColorValue
                Case IndexCol = -1
                    _Sheet.Cells(IndexRow - 1, -1).Interior.Color = ColorValue
                Case Else
            End Select
        End Sub

        '''========================================================================================
        ''' <summary>指定したｾﾙ範囲に色を付ける</summary>
        ''' <param name="ColorValue">設定する色</param>
        ''' <param name="IndexRowF">行位置:始(1から始まる)</param>
        ''' <param name="IndexColF">列位置:始(1から始まる)</param>
        ''' <param name="IndexRowT">行位置:終(1から始まる)</param>
        ''' <param name="IndexColT">列位置:終(1から始まる)</param>
        '''========================================================================================
        Public Sub CellSetColor(ByVal ColorValue As System.Drawing.Color _
                              , ByVal IndexRowF As Long _
                              , ByVal IndexColF As Long _
                              , ByVal IndexRowT As Long _
                              , ByVal IndexColT As Long _
                               )
            If IndexRowF < 1 Or IndexColF < 1 Or IndexColT < 1 Or IndexColT < 1 Then Return

            _Sheet.Cells(IndexRowF - 1, IndexColF - 1, IndexRowT - 1, IndexColT - 1).Interior.Color = ColorValue
        End Sub

        '''========================================================================================
        ''' <summary>指定した行に色を付ける</summary>
        ''' <param name="ColorValue">設定する色</param>
        ''' <param name="IndexRow">行位置(1から始まる)</param>
        '''========================================================================================
        Public Sub CellSetColorRow(ByVal ColorValue As System.Drawing.Color, ByVal IndexRow As Long)
            If IndexRow <= 1 Then Return

            Dim strRange As String = ""
            strRange = IndexRow.ToString & ":" & IndexRow.ToString
            _Sheet.Cells(strRange).Interior.Color = ColorValue
        End Sub

        '''========================================================================================
        ''' <summary>指定した列に色を付ける</summary>
        ''' <param name="ColorValue">設定する色</param>
        ''' <param name="IndexCol">列位置(1から始まる)</param>
        '''========================================================================================
        Public Sub CellSetColorCol(ByVal ColorValue As System.Drawing.Color, ByVal IndexCol As Long)
            If IndexCol < 1 Then Return

            Dim strRange As String = ""
            strRange = Element(IndexCol - 1) & ":" & Element(IndexCol - 1)
            _Sheet.Cells(strRange).Interior.Color = ColorValue
        End Sub
#End Region

#Region "指定したｾﾙにｺﾒﾝﾄを取得する"
        '''========================================================================================
        ''' <summary>指定したセルのｺﾒﾝﾄを取得する</summary>
        ''' <param name="IndexRow">行位置(1から始まる)</param>
        ''' <param name="IndexCol">列位置(1から始まる)</param>
        '''========================================================================================
        Public Function CellGetComment(ByVal IndexRow As Long, ByVal IndexCol As Long) As String
            If IndexRow < 1 Or IndexCol < 1 Then Return ""

            Return _Sheet.Cells(IndexRow - 1, IndexCol - 1).Comment.Shape.TextFrame.Characters.Text
        End Function
#End Region

#Region "指定したｾﾙにｺﾒﾝﾄを設定する"
        '''========================================================================================
        ''' <summary>指定したセルにｺﾒﾝﾄを設定する</summary>
        ''' <param name="IndexRow">行位置(1から始まる)</param>
        ''' <param name="IndexCol">列位置(1から始まる)</param>
        ''' <param name="Value">設定する値</param>
        '''========================================================================================
        Public Sub CellSetComment(ByVal IndexRow As Long, ByVal IndexCol As Long, ByVal Value As String)
            If IndexRow < 1 Or IndexCol < 1 Then Return

            _Sheet.Cells(IndexRow - 1, IndexCol - 1).AddComment(Value)
            _Sheet.Cells(IndexRow - 1, IndexCol - 1).Comment.Shape.Width = 250
            _Sheet.Cells(IndexRow - 1, IndexCol - 1).Comment.Shape.Height = 100
        End Sub
#End Region

#Region "指定したｾﾙにｺﾒﾝﾄをｸﾘｱする"
        '''========================================================================================
        ''' <summary>指定したセルにｺﾒﾝﾄをｸﾘｱする</summary>
        ''' <param name="IndexRow">行位置(1から始まる)</param>
        ''' <param name="IndexCol">列位置(1から始まる)</param>
        '''========================================================================================
        Public Sub CellClearComment(ByVal IndexRow As Long, ByVal IndexCol As Long)
            If IndexRow < 1 Or IndexCol < 1 Then Return

            _Sheet.Cells(IndexRow - 1, IndexCol - 1).ClearComments()
        End Sub
#End Region

#Region "指定したセルに線を引く"
        '''========================================================================================
        ''' <summary>指定したセルに線を引く</summary>
        ''' <param name="IndexRow">行位置(1から始まる)</param>
        ''' <param name="IndexCol">列位置(1から始まる)</param>
        '''========================================================================================
        Public Sub CellSetLine(ByVal IndexRow As Long, ByVal IndexCol As Long)
            If IndexRow < 1 Or IndexCol < 1 Then Return

            Dim range As SpreadsheetGear.IRange = _Sheet.Cells(IndexRow - 1, IndexCol - 1)
            Dim borders As SpreadsheetGear.IBorders = range.Borders

            borders.LineStyle = SpreadsheetGear.LineStyle.Continuous
            borders.Weight = SpreadsheetGear.BorderWeight.Thin
        End Sub

        '''========================================================================================
        ''' <summary>指定したセルに線を引く</summary>
        ''' <param name="IndexRowF">行位置:始(1から始まる)</param>
        ''' <param name="IndexColF">列位置:始(1から始まる)</param>
        ''' <param name="IndexRowT">行位置:終(1から始まる)</param>
        ''' <param name="IndexColT">列位置:終(1から始まる)</param>
        '''========================================================================================
        Public Sub CellSetLine(ByVal IndexRowF As Long _
                              , ByVal IndexColF As Long _
                              , ByVal IndexRowT As Long _
                              , ByVal IndexColT As Long _
                               )

            If IndexRowF < 1 Or IndexColF < 1 Or IndexColT < 1 Or IndexColT < 1 Then Return

            Dim range As SpreadsheetGear.IRange = _Sheet.Cells(IndexRowF - 1, IndexColF - 1, IndexRowT - 1, IndexColT - 1)
            Dim borders As SpreadsheetGear.IBorders = range.Borders

            borders.LineStyle = SpreadsheetGear.LineStyle.Continuous
            borders.Weight = SpreadsheetGear.BorderWeight.Thin
        End Sub
#End Region

#Region "指定したセルの値を返す(１つのセル)"
        '''========================================================================================
        ''' <summary>指定したセルの値を返す(１つのセル)</summary>
        ''' <param name="IndexRow">行位置</param>
        ''' <param name="IndexCol">列位置</param>
        ''' <returns>セルオブジェクト</returns>
        '''========================================================================================
        Public Function CellGet(ByVal IndexRow As Long, ByVal IndexCol As Long) As SpreadsheetGear.IRange
            If IndexRow < 1 Or IndexCol < 1 Then Return Nothing

            Return Sheet.Cells(IndexRow - 1, IndexCol - 1)
        End Function
#End Region

#Region "指定したセルの値を返す(複数のセル)"
        '''========================================================================================
        ''' <summary>指定したセルの値を返す(複数のセル)</summary>
        ''' <param name="StartIndexRow">行位置（開始）</param>
        ''' <param name="StartIndexCol">列位置（開始）</param>
        ''' <returns>セルオブジェクト</returns>
        '''========================================================================================
        Public Function CellGet(ByVal StartIndexRow As Integer, ByVal StartIndexCol As Integer, ByVal EndIndexRow As Integer, ByVal EndIndexCol As Integer) As SpreadsheetGear.IRange
            If StartIndexRow < 1 Or StartIndexCol < 1 Or EndIndexRow < 1 Or EndIndexCol < 1 Then Return Nothing

            Return _Sheet.Range(StartIndexRow - 1, StartIndexCol - 1, EndIndexRow - 1, EndIndexCol - 1)
        End Function
#End Region

#Region "指定したセルの色を返す(１つのセル)"
        '''========================================================================================
        ''' <summary>指定したセルの色を返す(１つのセル)</summary>
        ''' <param name="IndexRow">行位置</param>
        ''' <param name="IndexCol">列位置</param>
        ''' <returns>セルオブジェクト</returns>
        '''========================================================================================
        Public Function CellGetColor(ByVal IndexRow As Long, ByVal IndexCol As Long) As SpreadsheetGear.Drawing.Color
            If IndexRow < 1 Or IndexCol < 1 Then Return Nothing

            Return Sheet.Cells(IndexRow - 1, IndexCol - 1).Interior.Color
        End Function
#End Region

#Region "指定したセルの色を返す(複数のセル)"
        '''========================================================================================
        ''' <summary>指定したセルの値を返す(複数のセル)</summary>
        ''' <param name="StartIndexRow">行位置（開始）</param>
        ''' <param name="StartIndexCol">列位置（開始）</param>
        ''' <returns>セルオブジェクト</returns>
        '''========================================================================================
        Public Function CellGetColor(ByVal StartIndexRow As Integer, ByVal StartIndexCol As Integer, ByVal EndIndexRow As Integer, ByVal EndIndexCol As Integer) As SpreadsheetGear.Drawing.Color
            If StartIndexRow < 1 Or StartIndexCol < 1 Or EndIndexRow < 1 Or EndIndexCol < 1 Then Return Nothing

            Return _Sheet.Range(StartIndexRow - 1, StartIndexCol - 1, EndIndexRow - 1, EndIndexCol - 1).Interior.Color
        End Function
#End Region

#Region "ｾﾙ範囲をｺﾋﾟｰして他の場所に貼り付ける"
        '''========================================================================================
        ''' <summary>指定したセルに値を設定する</summary>
        '''========================================================================================
        Public Sub CopyAndPaste(ByVal CopySheetName As String _
                              , Optional ByVal CopyIndexRowF As Long = -1 _
                              , Optional ByVal CopyIndexColF As Long = -1 _
                              , Optional ByVal CopyIndexRowT As Long = -1 _
                              , Optional ByVal CopyIndexColT As Long = -1 _
                              , Optional ByVal PasteSheetName As String = "" _
                              , Optional ByVal PasteIndexRow As Long = -1 _
                              , Optional ByVal PasteIndexCol As Long = -1 _
                               )
            Dim CopySheet As SpreadsheetGear.IWorksheet = _Book.Sheets(CopySheetName)
            Dim PasteSheet As SpreadsheetGear.IWorksheet = _Book.Sheets(PasteSheetName)

            '------------------------------------------------------------------
            ' ﾊﾟﾗﾒｰﾀ 確認
            '------------------------------------------------------------------
            Select Case True
                Case CopySheet Is Nothing
                    Exit Sub                    '即終了

                Case PasteSheet Is Nothing
                    PasteSheet = CopySheet      '即終了
            End Select

            '------------------------------------------------------------------
            ' 範囲設定
            '------------------------------------------------------------------
            Dim CopyRange As String = ""
            Dim PasteRange As String = ""

            '------------------------------------
            ' ｺﾋﾟｰ元(xx:xx)
            '------------------------------------
            CopyRange = ""
            If CopyIndexColF <> -1 Then CopyRange &= Element(CopyIndexColF)
            If CopyIndexRowF <> -1 Then CopyRange &= CopyIndexRowF

            CopyRange &= ":"

            If CopyIndexColT = -1 Then
                If CopyIndexColF <> -1 Then CopyRange &= Element(CopyIndexColF)
            Else
                CopyRange &= Element(CopyIndexColT)
            End If

            If CopyIndexRowT = -1 Then
                If CopyIndexRowF <> -1 Then CopyRange &= CopyIndexRowF
            Else
                CopyRange &= CopyIndexRowT
            End If

            '------------------------------------
            ' ｺﾋﾟｰ先(yy)
            '------------------------------------
            PasteRange = ""
            If PasteIndexCol <> -1 Then PasteRange &= Element(PasteIndexCol)
            If PasteIndexRow <> -1 Then PasteRange &= PasteIndexRow
            PasteRange &= ":"
            If PasteIndexCol <> -1 Then PasteRange &= Element(PasteIndexCol)
            If PasteIndexRow <> -1 Then PasteRange &= PasteIndexRow

            '------------------------------------
            ' 貼り付け
            '------------------------------------
            CopySheet.Cells(CopyRange).Copy(PasteSheet.Cells(PasteRange))
        End Sub
#End Region

#Region "ｴﾗｰ情報"
        '''========================================================================================
        ''' <summary>ｴﾗｰ情報ｾｯﾄ</summary>
        ''' <param name="IndexRow">行位置(1から始まる)</param>
        ''' <param name="IndexCol">列位置(1から始まる)</param>
        ''' <param name="Comment">設定する値</param>
        '''========================================================================================
        Public Sub CellSetError(ByVal IndexRow As Long _
                              , ByVal IndexCol As Long _
                              , ByVal Comment As String _
                               )
            CellSetComment(IndexRow, IndexCol, Comment)
            CellSetColor(Drawing.Color.LightPink, IndexRow, IndexCol)
        End Sub

        '''========================================================================================
        ''' <summary>ｴﾗｰ情報ｾｯﾄ</summary>
        ''' <param name="IndexRow">行位置(1から始まる)</param>
        ''' <param name="IndexCol">列位置(1から始まる)</param>
        '''========================================================================================
        Public Sub CellClearError(ByVal IndexRow As Long _
                                , ByVal IndexCol As Long _
                                 )
            CellClearComment(IndexRow, IndexCol)
            CellSetColor(Drawing.Color.Transparent, IndexRow, IndexCol)
        End Sub
#End Region
#End Region

#Region "Utility"
        '''----------------------------------------------------------------------------------------
        ''' <summary>ﾃﾞｰﾀﾃｰﾌﾞﾙ中のﾃﾞｰﾀﾃｰﾌﾞﾙをすべてExcelに張り付ける</summary>
        ''' <param name="datTable">ﾃﾞｰﾀﾃｰﾌﾞﾙ</param>
        ''' <remarks>
        ''' 《Columns.Captionの内容》
        ''' 1ｶﾗﾑ目:ﾀｲﾄﾙの列名
        ''' 2ｶﾗﾑ目:ﾀｲﾄﾙの前面色
        ''' 3ｶﾗﾑ目:数値項目時の小数点以下の桁数
        ''' </remarks>
        ''' <returns>True:成功、False:失敗</returns>
        '''----------------------------------------------------------------------------------------
        Public Function ExcelExport(ByVal datTable As System.Data.DataTable, ByVal FilePath As String, Optional ByVal FileFormat As SpreadsheetGear.FileFormat = SpreadsheetGear.FileFormat.Excel8) As Boolean
            Try
                ' 新規ワークブックとワークシートを作成する
                Dim Book As SpreadsheetGear.IWorkbook = SpreadsheetGear.Factory.GetWorkbook(New System.Globalization.CultureInfo(1041))
                Dim Sheet As SpreadsheetGear.IWorksheet = Book.Worksheets("Sheet1")
                Sheet.Name = datTable.TableName

                ' 書式設定
                For i As Integer = 0 To datTable.Columns.Count - 1
                    ' ｵﾌﾟｼｮﾝ取得
                    Dim arrCaption As String() = datTable.Columns(i).Caption.Split(vbTab)

                    ' 書式設定
                    Select Case datTable.Columns(i).DataType.Name
                        Case GetType(String).Name
                            Sheet.Cells(Me.Element(i) & ":" & Me.Element(i)).NumberFormat = "@"     '文字列書式
                        Case Else
                            If arrCaption.Length = 1 Then
                                Sheet.Cells(Me.Element(i) & ":" & Me.Element(i)).NumberFormat = "#,###" '数字書式
                            Else
                                If BaseCore.Common.Text.CVal(arrCaption(2)) = 0 Then
                                    Sheet.Cells(Me.Element(i) & ":" & Me.Element(i)).NumberFormat = "#,###" '数字書式
                                Else
                                    Sheet.Cells(Me.Element(i) & ":" & Me.Element(i)).NumberFormat = "#,###." & StrDup(CInt(BaseCore.Common.Text.CVal(arrCaption(2))), "0") & ";" & "-#,###." & StrDup(CInt(BaseCore.Common.Text.CVal(arrCaption(2))), "0") & ";" & "#" '数字書式
                                End If
                            End If
                    End Select

                    ' ﾀｲﾄﾙ文字変更
                    If arrCaption(0) <> "" Then
                        datTable.Columns(i).ColumnName = arrCaption(0)
                    End If

                    ' ﾀｲﾄﾙ行を着色(背景色)
                    Sheet.Cells(Me.Element(i) & "1" & ":" & Me.Element(i) & "1").Interior.Color = Drawing.Color.LightGray

                    ' ﾀｲﾄﾙ行を着色(前面色)
                    If arrCaption.Length = 1 Then
                        Sheet.Cells(Me.Element(i) & "1" & ":" & Me.Element(i) & "1").Font.Color = Drawing.Color.Black
                    Else
                        Select Case arrCaption(1)
                            Case BaseCore.Common.DataTable.ColumnRefresh.enmTitleStyle.Required
                                Sheet.Cells(Me.Element(i) & "1" & ":" & Me.Element(i) & "1").Font.Color = Drawing.Color.Red
                            Case BaseCore.Common.DataTable.ColumnRefresh.enmTitleStyle.View
                                Sheet.Cells(Me.Element(i) & "1" & ":" & Me.Element(i) & "1").Font.Color = Drawing.Color.MediumBlue
                            Case Else
                                Sheet.Cells(Me.Element(i) & "1" & ":" & Me.Element(i) & "1").Font.Color = Drawing.Color.Black
                        End Select
                    End If
                Next

                ' DataTable の左先頭のセルを取得する
                Dim range As SpreadsheetGear.IRange = Sheet.Cells("A1")

                ' DataTable をワークシート範囲にコピーする
                range.CopyFromDataTable(datTable, SpreadsheetGear.Data.SetDataFlags.None)

                ' データを含んだすべてのワークシート内の列を自動調整
                Sheet.UsedRange.Columns.AutoFit()

                ' 先頭行でｳｨﾝﾄﾞｳ枠固定
                Sheet.WindowInfo.ScrollColumn = 0
                Sheet.WindowInfo.SplitColumns = 0

                Sheet.WindowInfo.ScrollRow = 0
                Sheet.WindowInfo.SplitRows = 1

                Sheet.WindowInfo.FreezePanes = True

                ' ｸﾛｰｽﾞ
                Book.SaveAs(FilePath, FileFormat)

            Catch ex As Exception
                _LastError = ex.Message
                Return False
            End Try

            Return True
        End Function

        '''----------------------------------------------------------------------------------------
        ''' <summary>ﾃﾞｰﾀｾｯﾄ中のﾃﾞｰﾀﾃｰﾌﾞﾙをすべてExcelに張り付ける</summary>
        ''' <param name="datSet">ﾃﾞｰﾀｾｯﾄ</param>
        ''' <remarks>
        ''' 《Columns.Captionの内容》
        ''' 1ｶﾗﾑ目:ﾀｲﾄﾙの列名
        ''' 2ｶﾗﾑ目:ﾀｲﾄﾙの前面色
        ''' 3ｶﾗﾑ目:数値項目時の小数点以下の桁数
        ''' </remarks>
        ''' <returns>True:成功、False:失敗</returns>
        '''----------------------------------------------------------------------------------------
        Public Function ExcelExport(ByVal datSet As System.Data.DataSet, ByVal FilePath As String, Optional ByVal FileFormat As SpreadsheetGear.FileFormat = SpreadsheetGear.FileFormat.Excel8) As Boolean
            Try
                ' 新規ﾌﾞｯｸを作成する
                Dim Book As SpreadsheetGear.IWorkbook = SpreadsheetGear.Factory.GetWorkbook(New System.Globalization.CultureInfo(1041))
                Dim Sheet As SpreadsheetGear.IWorksheet

                For Each datTable As System.Data.DataTable In datSet.Tables
                    ' ｼｰﾄを追加
                    Sheet = Book.Worksheets.Add
                    Sheet.Name = datTable.TableName

                    ' 書式設定
                    For i As Integer = 0 To datTable.Columns.Count - 1
                        ' ｵﾌﾟｼｮﾝ取得
                        Dim arrCaption As String() = datTable.Columns(i).Caption.Split(vbTab)

                        ' 書式設定
                        Select Case datTable.Columns(i).DataType.Name
                            Case GetType(String).Name
                                Sheet.Cells(Me.Element(i) & ":" & Me.Element(i)).NumberFormat = "@"     '文字列書式
                            Case Else
                                If BaseCore.Common.Text.CVal(arrCaption(2)) = 0 Then
                                    Sheet.Cells(Me.Element(i) & ":" & Me.Element(i)).NumberFormat = "#,###" '数字書式
                                Else
                                    Sheet.Cells(Me.Element(i) & ":" & Me.Element(i)).NumberFormat = "#,###." & StrDup(CInt(BaseCore.Common.Text.CVal(arrCaption(2))), "0") & ";" & "-#,###." & StrDup(CInt(BaseCore.Common.Text.CVal(arrCaption(2))), "0") & ";" & "#" '数字書式
                                End If
                        End Select

                        ' ﾀｲﾄﾙ文字変更
                        If arrCaption(0) <> "" Then
                            datTable.Columns(i).ColumnName = arrCaption(0)
                        End If

                        ' ﾀｲﾄﾙ行を着色(背景色)
                        Sheet.Cells(Me.Element(i) & "1" & ":" & Me.Element(i) & "1").Interior.Color = Drawing.Color.LightGray

                        ' ﾀｲﾄﾙ行を着色(前面色)
                        Select Case arrCaption(1)
                            Case BaseCore.Common.DataTable.ColumnRefresh.enmTitleStyle.Required
                                Sheet.Cells(Me.Element(i) & "1" & ":" & Me.Element(i) & "1").Font.Color = Drawing.Color.Red
                            Case BaseCore.Common.DataTable.ColumnRefresh.enmTitleStyle.View
                                Sheet.Cells(Me.Element(i) & "1" & ":" & Me.Element(i) & "1").Font.Color = Drawing.Color.MediumBlue
                            Case Else
                                Sheet.Cells(Me.Element(i) & "1" & ":" & Me.Element(i) & "1").Font.Color = Drawing.Color.Black
                        End Select
                    Next

                    ' DataTable の左先頭のセルを取得する
                    Dim range As SpreadsheetGear.IRange = Sheet.Cells("A1")

                    ' DataTable をワークシート範囲にコピーする
                    range.CopyFromDataTable(datTable, SpreadsheetGear.Data.SetDataFlags.None)

                    ' データを含んだすべてのワークシート内の列を自動調整
                    Sheet.UsedRange.Columns.AutoFit()

                    ' 先頭行でｳｨﾝﾄﾞｳ枠固定
                    Sheet.WindowInfo.ScrollColumn = 0
                    Sheet.WindowInfo.SplitColumns = 0

                    Sheet.WindowInfo.ScrollRow = 0
                    Sheet.WindowInfo.SplitRows = 1

                    Sheet.WindowInfo.FreezePanes = True
                Next

                ' Sheet1 削除
                Book.Sheets("Sheet1").Delete()

                ' ﾌﾞｯｸ保存
                Book.SaveAs(FilePath, FileFormat)

            Catch ex As Exception
                _LastError = ex.Message
                Return False
            End Try

            Return True
        End Function
#End Region
    End Class
End Namespace

