Imports System
Imports System.Text

Namespace Common
    Public Class Text
        '''========================================================================================
        ''' <summary>ﾃﾞｰﾀﾀｲﾌﾟ</summary>
        '''========================================================================================
        Public Enum DataType
            Wide = 1
            Narrow = 2
            Text = 3
            Number = 4
        End Enum

        '''========================================================================================
        ''' <summary>値がNullの時、第2ﾊﾟﾗﾒｰﾀを返します。</summary>
        ''' <param name="Value">対象文字列</param>
        ''' <param name="NullValue">NULLの場合に返す値</param>
        ''' <returns>NULLの場合はvalueを、そうでない場合はnullvarをそのまま返します。</returns>
        '''========================================================================================
        Public Shared Function Nz(ByVal Value As Object, ByVal NullValue As Object, Optional ByVal IsDate As Boolean = False) As Object
            If IsDBNull(Value) Or Value Is Nothing Then
                Return NullValue
            Else
                If Value.ToString = "(Empty)" Or Value.ToString.Trim = "" Then
                    Return NullValue
                Else
                    If IsDate Then
                        Select Case True
                            Case Microsoft.VisualBasic.IsDate(Value)
                                Return Format(CDate(Value), "yyyy/MM/dd")

                            Case Value.ToString.Length = 8
                                Return BaseCore.Common.Text.TextFormat(Value, 10, BaseContents.TextBox.TextStyle.YYYYMMDD)

                            Case IsNumeric(Value)
                                Dim strDate As String

                                strDate = Format(DateTime.FromOADate(Value), "yyyy/MM/dd")

                                If Microsoft.VisualBasic.IsDate(strDate) Then
                                    Return strDate
                                Else
                                    Return Value
                                End If
                            Case Else
                                Return Value
                        End Select
                    Else
                        Return Value
                    End If
                End If
            End If
        End Function

        '''========================================================================================
        ''' <summary>文字列中に全角文字が含まれるかどうかをチェックします。</summary>
        ''' <param name="Value">対象文字列</param>
        ''' <returns>全角文字が含まれる場合はTrueを、含まれない場合はFalseを返します。</returns>
        '''========================================================================================
        Public Shared Function IsUseWide(ByVal Value As String) As Boolean
            Dim i As Integer
            For i = 1 To Value.Length
                If LenB(Mid(Value, i, 1)) = 2 Then
                    Return True
                End If
            Next
            Return False
        End Function

        '''========================================================================================
        ''' <summary>文字列中に半角文字が含まれるかどうかをチェックします。</summary>
        ''' <param name="Value">対象文字列</param>
        ''' <returns>半角文字が含まれる場合はTrueを、含まれない場合はFalseを返します。</returns>
        '''========================================================================================
        Public Shared Function IsUseNarrow(ByVal Value As String) As Boolean
            Dim i As Integer
            For i = 1 To Value.Length
                If LenB(Mid(Value, i, 1)) = 1 Then
                    Return True
                End If
            Next
            Return False
        End Function

        '''========================================================================================
        ''' <summary>開始位置より文字列を取り出す。全角が半部で切れない様考慮する。</summary>
        ''' <param name="Value">取り出す文字列</param>
        ''' <param name="Start">切り出す位置(1から始まる)</param>
        ''' <returns>開始位置より指定ﾊﾞｲﾄ数分の文字列</returns>
        ''' <remarks></remarks>
        '''========================================================================================
        Public Shared Function MidB(ByVal Value As String, ByVal Start As Integer) As String
            Return MidB(Value, Start, System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(Value))
        End Function

        '''========================================================================================
        ''' <summary>開始位置より指定ﾊﾞｲﾄ数分の文字列を取り出す。全角が半部で切れない様考慮する。</summary>
        ''' <param name="Value">取り出す文字列</param>
        ''' <param name="Start">切り出す位置(1から始まる)</param>
        ''' <param name="Size">切り出すﾊﾞｲﾄ数</param>
        ''' <returns>開始位置より指定ﾊﾞｲﾄ数分の文字列</returns>
        ''' <remarks></remarks>
        '''========================================================================================
        Public Shared Function MidB(ByVal Value As String, ByVal Start As Integer, ByVal Size As Integer) As String
            Dim strBuilder As New System.Text.StringBuilder
            Dim intLenSum As Integer = 0
            Dim intLenCur As Integer = 0

            For i As Integer = 0 To Value.Length - 1
                intLenCur = System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(Value(i))
                intLenSum += intLenCur

                If intLenSum < Start Then
                    Continue For
                End If

                If intLenSum = Start And intLenCur = 2 Then
                    Continue For
                End If

                If intLenSum <= Start + Size - 1 Then
                    strBuilder.Append(Value(i))
                Else
                    Exit For
                End If
            Next

            Return strBuilder.ToString
        End Function

        '''========================================================================================
        ''' <summary>文字列の文字数を取得します。</summary>
        ''' <param name="Value">文字列</param>
        ''' <returns>文字数</returns>
        '''========================================================================================
        Public Shared Function Len(ByVal Value As String) As Integer
            Return Value.Length
        End Function

        '''========================================================================================
        ''' <summary>文字列のバイト数を取得します。</summary>
        ''' <param name="Value">文字列</param>
        ''' <returns>バイト数</returns>
        '''========================================================================================
        Public Shared Function LenB(ByVal Value As String) As Integer
            Dim hEncoding As Encoding = Encoding.GetEncoding("Shift_JIS")
            Dim bBytes As Byte() = hEncoding.GetBytes(Value)
            Return bBytes.Length
        End Function

        '''========================================================================================
        ''' <summary>日付型として正しいかどうかをチェックします。</summary>
        ''' <param name="Value">チェックする値</param>
        ''' <returns>日付として正しい場合はExpを返し、正しくない場合はDBNullを返します。</returns>
        '''========================================================================================
        Public Shared Function IsDateNull(ByVal Value As Object) As Object
            If IsDate(Value) Then
                Return CDate(Value)
            Else
                Return DBNull.Value
            End If
        End Function

        '''========================================================================================
        ''' <summary>文字列式を数値型に変換します。</summary>
        ''' <param name="Value">変換する文字列式</param>
        ''' <returns>数値型に変換した値を返します。例）"123a456" → 123456</returns>
        '''========================================================================================
        Public Shared Function CVal(ByVal Value As Object) As Decimal
            Dim tmpValue As Object
            Dim i As Integer

            If IsNothing(Value) Or IsDBNull(Value) Then Value = ""

            ' 先頭のゼロを削除
            For i = 1 To Microsoft.VisualBasic.Len(Value)
                If Mid(Value, i, 1) <> "0" Then
                    Value = Mid(Value, i)
                    Exit For
                End If
            Next i

            If Not IsNumeric(Value) Then
                tmpValue = ""
                Value = Trim(Value)
                For i = 1 To Microsoft.VisualBasic.Len(Value)
                    Select Case Mid(Value, i, 1)
                        Case "-", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "."
                            tmpValue = tmpValue & Mid(Value, i, 1)
                    End Select
                Next

                If Not IsNumeric(tmpValue) Then
                    Value = 0
                Else
                    Value = tmpValue
                End If
            End If

            Return CDec(Value)
        End Function

        '''========================================================================================
        ''' <summary>数値を3桁ごとのカンマ区切りした文字列を作成します。</summary>
        ''' <param name="Value">変換する数値</param>
        ''' <param name="MaxLength">書式化するバイト数</param>
        ''' <param name="NumberMinor">小数桁数</param>
        ''' <returns>3桁ごとのカンマ区切りを行った文字列を返します。</returns>
        '''========================================================================================
        Public Shared Function EditComma(ByVal Value As Object, ByVal MaxLength As Integer, ByVal NumberMinor As Integer) As String
            Dim i As Integer
            Dim sign As String
            Dim wrk As Object
            Dim maj As String
            Dim min As String
            Dim ret As String
            Dim cnt As Long

            If Value < 0 Then sign = "-" Else sign = ""
            wrk = CStr(Math.Abs(Value))
            If InStr(wrk, ".") > 0 Then
                maj = Trim$(Left$(wrk, InStr(wrk, ".") - 1))
                min = Trim$(Right(wrk, Microsoft.VisualBasic.Len(wrk) - InStr(wrk, ".")))
            Else
                maj = Trim$(wrk)
                min = ""
            End If

            If Microsoft.VisualBasic.Len(min) < NumberMinor Then
                min = min & StrDup(NumberMinor - Microsoft.VisualBasic.Len(min), "0")
            Else
                min = Left$(min, NumberMinor)
            End If

            ret = ""
            cnt = 1
            For i = Microsoft.VisualBasic.Len(maj) To 1 Step -1
                ret = Mid$(maj, i, 1) & ret
                If (cnt Mod 3) = 0 And i <> 1 Then
                    ret = "," & ret
                End If
                cnt = cnt + 1
            Next i
            ret = Trim$(ret)

            If min <> "" Then
                ret = ret & "." & min
            End If
            ret = sign & ret

            If Microsoft.VisualBasic.Len(ret) < MaxLength Then
                ret = StrDup(MaxLength - Microsoft.VisualBasic.Len(ret), " ") & ret
            End If

            EditComma = ret
        End Function

        '''========================================================================================
        ''' <summary>各種形式にフォーマットします。</summary>
        ''' <param name="Value">変換する値</param>
        ''' <param name="MaxLength">書式化するﾊﾞｲﾄ数</param>
        ''' <param name="TextStyle">書式ﾀｲﾌﾟ(Code:)</param>
        ''' <param name="NumberMinor">小数桁数</param>
        ''' <param name="ZeroReturn">書式タイプが数値・通貨・コードの時に、値がゼロの場合ゼロを返すか空白を返すか指定する(True:ゼロを返す、False:空白を返す)</param>
        ''' <returns>フォーマットを行った文字列を返します。</returns>
        '''========================================================================================
        Public Shared Function TextFormat(ByVal Value As String, ByVal MaxLength As Integer, ByVal TextStyle As BaseContents.TextBox.TextStyle, Optional ByVal NumberMinor As Integer = 0, Optional ByVal ZeroReturn As Boolean = True) As String
            Dim ReturnStrings As String
            Dim Cul_JP As Globalization.CultureInfo = New Globalization.CultureInfo("ja-JP")

            Cul_JP.DateTimeFormat.Calendar = New Globalization.JapaneseCalendar()

            If Len(BaseCore.Common.Text.Nz(Value, "")) > MaxLength Then
                MaxLength = Len(BaseCore.Common.Text.Nz(Value, ""))
            End If

            Select Case TextStyle
                Case BaseContents.TextBox.TextStyle.Code
                    'ｺｰﾄﾞ値(ｾﾞﾛﾊﾟﾃﾞｨﾝｸﾞする)
                    ReturnStrings = Right$(StrDup(MaxLength, "0") & BaseCore.Common.Text.CVal(Value), MaxLength)

                    If BaseCore.Common.Text.IsEmptyOrZero(Value) Then
                        ReturnStrings = ""
                        'ReturnStrings = "" & StrDup(MaxLength, " ")
                    End If

                Case BaseContents.TextBox.TextStyle.Currency
                    '数字(ｶﾝﾏ編集)
                    If NumberMinor > 0 Then
                        ReturnStrings = Trim(Right(BaseCore.Common.Text.EditComma(BaseCore.Common.Text.CVal(Value), MaxLength, NumberMinor), MaxLength))
                    Else
                        ReturnStrings = Trim(Right(BaseCore.Common.Text.EditComma(BaseCore.Common.Text.CVal(Value), MaxLength, 0), MaxLength))
                    End If

                    If Not ZeroReturn Then
                        If BaseCore.Common.Text.CVal(ReturnStrings) = 0 Then
                            ReturnStrings = ""
                        End If
                    End If

                Case BaseContents.TextBox.TextStyle.YYYYMMDD
                    '数字8桁入力の時、ｽﾗｯｼｭを加える
                    If Value.Length = 8 And IsNumeric(Value) Then
                        Value = Value.Substring(0, 4) & "/" & Value.Substring(4, 2) & "/" & Value.Substring(6, 2)
                    End If

                    '数字4桁入力の時、ｽﾗｯｼｭを加える
                    If Value.Length = 4 And IsNumeric(Value) Then
                        Value = Value.Substring(0, 2) & "/" & Value.Substring(2, 2)
                    End If

                    '日付
                    If IsDate(Value) Then
                        If BaseCore.Common.Constant.DATE_YEAR = 1 Then
                            ReturnStrings = Format(CDate(Value), "yyyy/MM/dd")
                        Else
                            ReturnStrings = Wareki_Convert(String.Format(Cul_JP, "{0:gyy/MM/dd}", CDate(Value)))
                        End If
                    Else
                        Dim arrDate As String() = Value.Split("/")
                        Dim strDate As String = ""
                        Dim strDD As String = ""

                        Select Case arrDate.Length
                            Case 2
                                strDate = arrDate(0) & "/" & "01"
                                strDD = Format(BaseCore.Common.Text.CVal(arrDate(1)), "00")

                            Case 3
                                strDate = arrDate(0) & "/" & arrDate(1) & "/" & "01"
                                strDD = Format(BaseCore.Common.Text.CVal(arrDate(2)), "00")
                        End Select

                        If IsDate(strDate) Then
                            If BaseCore.Common.Constant.DATE_YEAR = 1 Then
                                ReturnStrings = Format(CDate(strDate), "yyyy/MM/") & strDD
                            Else
                                ReturnStrings = Wareki_Convert(String.Format(Cul_JP, "{0:gyy/MM/}", CDate(strDate))) & strDD
                            End If
                        Else
                            ReturnStrings = Value
                        End If
                    End If

                Case BaseContents.TextBox.TextStyle.Time
                    '時刻
                    If IsDate(Value) Then
                        ReturnStrings = Format(CDate(Value), "HH:mm:ss")
                    Else
                        ReturnStrings = Value
                    End If

                Case BaseContents.TextBox.TextStyle.DateTimeF, BaseContents.TextBox.TextStyle.DateTimeT
                    '日付+時刻
                    Dim strDate As String = ""
                    Dim strTime As String = ""
                    Select Case Value.Split(" ").Length
                        Case Is = 1
                            strDate = Value.Split(" ")(0)

                        Case Is >= 2
                            strDate = Value.Split(" ")(0)
                            strTime = Value.Split(" ")(1)
                    End Select

                    '数字8桁入力の時、ｽﾗｯｼｭを加える
                    If strDate.Length = 8 And IsNumeric(strDate) Then
                        strDate = strDate.Substring(0, 4) & "/" & strDate.Substring(4, 2) & "/" & strDate.Substring(6, 2)
                    End If

                    '数字4桁入力の時、ｽﾗｯｼｭを加える
                    If strDate.Length = 4 And IsNumeric(strDate) Then
                        strDate = strDate.Substring(0, 2) & "/" & strDate.Substring(2, 2)
                    End If

                    If IsDate(strDate) Then
                        strDate = Format(CDate(strDate), "yyyy/MM/dd")
                    End If

                    If BaseCore.Common.Text.IsEmptyOrZero(strTime) Then
                        If TextStyle = BaseContents.TextBox.TextStyle.DateTimeF Then
                            strTime = "00:00:00"
                        Else
                            strTime = "23:59:59"
                        End If
                    Else
                        Select Case strTime.Split(":").Length
                            Case Is = 1
                                strTime &= ":00:00"
                            Case Is = 2
                                If strTime.Split(":")(1) = "" Then
                                    strTime &= "00:00"
                                End If
                        End Select
                    End If

                    If IsDate(strDate) Then
                        If IsDate(strDate & " " & strTime) Then
                            ReturnStrings = Format(CDate(strDate & " " & strTime), "yyyy/MM/dd HH:mm:ss")
                        Else
                            ReturnStrings = Value
                        End If
                    Else
                        ReturnStrings = Value
                    End If

                Case BaseContents.TextBox.TextStyle.DateTimeMinute
                    '日付+時刻
                    Dim strDate As String = ""
                    Dim strTime As String = ""
                    Select Case Value.Split(" ").Length
                        Case Is = 1
                            strDate = Value.Split(" ")(0)

                        Case Is >= 2
                            strDate = Value.Split(" ")(0)
                            strTime = Value.Split(" ")(1)
                    End Select

                    If IsDate(strDate) Then
                        strDate = Format(CDate(strDate), "yyyy/MM/dd")
                    End If

                    If BaseCore.Common.Text.IsEmptyOrZero(strTime) Then
                        strTime = "23:59:59"
                    Else
                        Select Case strTime.Split(":").Length
                            Case Is = 1
                                strTime &= ":00:00"
                            Case Is = 2
                                If strTime.Split(":")(1) = "" Then
                                    strTime &= "00:00"
                                End If
                        End Select
                    End If

                    If IsDate(strDate) Then
                        If IsDate(strDate & " " & strTime) Then
                            ReturnStrings = Format(CDate(strDate & " " & strTime), "yyyy/MM/dd HH:mm")
                        Else
                            ReturnStrings = Value
                        End If
                    Else
                        ReturnStrings = Value
                    End If

                Case BaseContents.TextBox.TextStyle.YYYYMM
                    '数字8桁入力の時、ｽﾗｯｼｭを加える
                    If Value.Length = 6 And IsNumeric(Value) Then
                        Value = Value.Substring(0, 4) & "/" & Value.Substring(4, 2)
                    End If

                    '年月
                    If IsDate(Value & "/01") And Value.IndexOf("/") <> -1 Then
                        If BaseCore.Common.Constant.DATE_YEAR = 1 Then
                            '西暦
                            ReturnStrings = Format(CDate(Value & "/01"), "yyyy/MM")
                        Else
                            '和暦
                            ReturnStrings = Wareki_Convert(String.Format(Cul_JP, "{0:gyy/MM}", CDate(Value & "/01")))
                        End If
                    Else
                        Select Case True
                            Case Value = "" : ReturnStrings = ""
                            Case Value.Replace("/", "").Replace("0", "") = "" : ReturnStrings = "0000/00"
                            Case Value.Replace("/", "").Replace("9", "") = "" : ReturnStrings = "9999/99"
                            Case Else : ReturnStrings = Value
                        End Select
                    End If

                Case BaseContents.TextBox.TextStyle.Post
                    '郵便番号
                    If BaseCore.Common.Text.IsEmptyOrZero(Value) Then
                        ReturnStrings = ""
                    Else
                        ReturnStrings = Mid(Replace(Value, "-", ""), 1, 3) & "-" & Mid(Replace(Value, "-", ""), 4)
                    End If

                Case Else
                    ReturnStrings = Value
            End Select

            Return ReturnStrings
        End Function

        '''========================================================================================
        ''' <summary>固定長文字列を整形して返す</summary>
        ''' <param name="Type">編集型</param>
        ''' <param name="Value">値</param>
        ''' <param name="LenMajor">文字列の長さ or 整数部の長さ</param>
        ''' <param name="LenMinor">小数部の長さ</param>
        ''' <returns>固定長文字列</returns>
        '''========================================================================================
        Public Shared Function Fixed(ByVal Type As DataType, ByVal Value As Object, ByVal LenMajor As Integer, Optional ByVal LenMinor As Integer = 0) As String
            Select Case Type
                Case DataType.Narrow
                    Return StrConv(Value.ToString, VbStrConv.Narrow).PadRight(LenMajor, " ").Substring(0, LenMajor)

                Case DataType.Wide
                    Return StrConv(Value.ToString, VbStrConv.Wide).PadRight(LenMajor, "　").Substring(0, LenMajor)

                Case DataType.Text
                    Return Value.ToString.PadRight(LenMajor - (System.Text.Encoding.GetEncoding("Shift_JIS").GetByteCount(Value) - Value.Length))

                Case DataType.Number
                    Dim strFormat As String = StrDup(LenMajor, "0")
                    If LenMinor > 0 Then
                        strFormat &= "." & StrDup(LenMinor, "0")
                    End If

                    Return Format(CDec(Value), strFormat)
                Case Else
                    Return Value
            End Select
        End Function

        '''========================================================================================
        ''' <summary>CSVレコードから配列に展開します。</summary>
        ''' <param name="Record">CSVレコード(行区切りは含まない)</param>
        ''' <param name="Separator">列区切文字</param>
        ''' <param name="StringsBoxChar">文字列囲み文字</param>
        ''' <returns>展開した配列を返します。</returns>
        '''========================================================================================
        Public Shared Function CsvToArray(ByVal Record As String, Optional ByVal Separator As Char = ",", Optional ByVal StringsBoxChar As Char = "") As String()
            Dim sbflg As Boolean = False
            Dim strColumn As String = ""
            Dim arrReturn As String() = {""}
            Dim j As Integer = 0

            For i As Integer = 0 To Record.Length - 1
                Dim oneChar As String = Record.Substring(i, 1)
                If oneChar = StringsBoxChar Then
                    If sbflg Then
                        If i = Record.Length - 1 Then
                            System.Array.Resize(arrReturn, j + 1)
                            arrReturn(j) = strColumn
                            sbflg = Not sbflg
                            Continue For
                        ElseIf Record.Substring(i + 1, 1) = Separator Then
                            sbflg = Not sbflg
                            Continue For
                        End If
                    Else
                        If i = 0 Then
                            sbflg = Not sbflg
                            Continue For
                        ElseIf Record.Substring(i - 1, 1) = Separator Then
                            sbflg = Not sbflg
                            Continue For
                        End If
                    End If
                End If

                If oneChar = Separator Or i = Record.Length - 1 Then
                    If Not sbflg Then
                        If oneChar <> Separator And i = Record.Length - 1 Then
                            strColumn &= Record.Substring(i, 1)
                        End If
                        System.Array.Resize(arrReturn, j + 1)
                        arrReturn(j) = strColumn.Trim
                        strColumn = ""
                        j += 1

                        If oneChar = Separator And i = Record.Length - 1 Then
                            System.Array.Resize(arrReturn, j + 1)
                            arrReturn(j) = strColumn.Trim
                            j += 1
                        End If

                        Continue For
                    End If
                End If

                strColumn &= Record.Substring(i, 1)
            Next

            Return arrReturn
        End Function

        '''========================================================================================
        ''' <summary>漢字の元号を省略形(M,T,S,Hなど)に変換します。</summary>
        ''' <param name="DateWareki">和暦の年月日(例:平成20/1/20)</param>
        ''' <returns>元号を省略形に変換した結果を返します。(例:H20/1/20)</returns>
        '''========================================================================================
        Private Shared Function Wareki_Convert(ByVal DateWareki As String) As String
            Dim arrGengo() As String = BaseCore.Common.Constant.WAREKI_CONV.Split(",")
            Dim i As Integer
            Dim ReturnValue As String = DateWareki

            For i = 0 To arrGengo.Length - 1 Step 2
                ReturnValue = ReturnValue.Replace(arrGengo(i), arrGengo(i + 1))
            Next

            Return ReturnValue
        End Function

        '''========================================================================================
        ''' <summary>文字列中"0"の形式を統一します。</summary>
        ''' <param name="value">対象文字列</param>
        ''' <param name="Numeric">数値項目の時</param>
        ''' <returns>文字列が空文字もしくはｾﾞﾛ場合はTrueを、他の場合はFalseを返します。</returns>
        '''========================================================================================
        Public Shared Function IsEmptyOrZero(ByVal value As Object, Optional ByVal Numeric As Boolean = False) As Boolean
            If BaseCore.Common.Text.Nz(value, "").ToString = "" Then
                Return True
            Else
                If Numeric Then
                    If IsNumeric(value) Then
                        If CVal(value) = 0 Then
                            Return True
                        Else
                            Return False
                        End If
                    Else
                        Return False
                    End If
                Else
                    Return False
                End If
            End If
        End Function

        '''========================================================================================
        ''' <summary>整数部の桁数算出</summary>
        ''' <param name="Value">数値</param>
        '''========================================================================================
        Public Shared Function DecimalLenMajor(ByRef Value As Decimal) As Integer
            Dim decValue As Decimal = Decimal.Truncate(Value)

            If decValue = 0 Then
                Return 0
            Else
                Return decValue.ToString.Length
            End If
        End Function

        '''========================================================================================
        ''' <summary>小数部の桁数算出</summary>
        ''' <param name="Value">数値</param>
        '''========================================================================================
        Public Shared Function DecimalLenMinor(ByRef Value As Decimal) As Integer
            Dim strTmp As String

            strTmp = Value.ToString()
            If strTmp.IndexOf(".") = -1 Then
                strTmp = "0"
            Else
                strTmp = CLng(strTmp.Substring(strTmp.IndexOf(".") + 1)).ToString
            End If

            If strTmp = "0" Then
                Return 0
            Else
                Return strTmp.Length
            End If
        End Function
    End Class


    '[PadRight]を使用する事!!
    '''' <summary>指定された長さになるように、右に半角ｽﾍﾟｰｽを埋め込みます。</summary>
    '''' <param name="value">対象文字列</param>
    '''' <param name="length">長さ</param>
    '''' <returns>空白が埋め込まれた文字列。</returns>
    'Public Shared Function FixLength(ByVal value As Object, ByVal length As Integer) As String
    '    Return Left(IsNull(value, "") & Microsoft.VisualBasic.Strings.StrDup(length, " "), length)
    'End Function


    '[System.IO.Path.GetFileName]を使用する事!!
    '''' <summary>フルパスのファイル名から、ファイル名の部分のみを抽出します。</summary>
    '''' <param name="FullPathFileName">フルパス付きのファイル名</param>
    '''' <returns>抽出したファイル名を返します。</returns>
    'Public Shared Function GetFileNameOnly(ByVal FullPathFileName As String) As String
    '    Dim i As Integer
    '    Dim ReturnValue As String = FullPathFileName

    '    For i = FullPathFileName.Length To 1 Step -1
    '        If Mid(FullPathFileName, i, 1) = "\" Then
    '            ReturnValue = Mid(FullPathFileName, i + 1)
    '            Exit For
    '        End If
    '    Next

    '    Return ReturnValue
    'End Function


    '既に定義済み
    '''' <summary>SQL ServerのIsNULLと同様の動作をします。</summary>
    '''' <param name="Exp">NULLチェックする値</param>
    '''' <param name="TrueValue">NULLの場合に返す値</param>
    '''' <returns>NULLの場合はTrueValueを、そうでない場合はExpをそのまま返します。</returns>
    'Public Shared Function IsNull(ByVal Exp As Object, ByVal TrueValue As Object) As Object
    '    Try
    '        If IsNothing(Exp) Or IsDBNull(Exp) Then
    '            Return TrueValue
    '            'ElseIf IsNumeric(Exp) Then
    '            '  If Text.BaseCore.Common.Text.CVal(Exp) = 0 Then
    '            '    Return TrueValue
    '            '  End If
    '        ElseIf Exp.ToString = "(Empty)" Then
    '            Return TrueValue
    '        End If
    '    Catch ex As Exception
    '        Return TrueValue
    '    End Try
    '    Return Exp
    'End Function
End Namespace
