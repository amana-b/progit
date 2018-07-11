Namespace Common
    Public Class Validator
        Private arrIllegalString() As String = {vbTab, ",", vbCrLf, vbCr, vbLf, "'", """"}
        Private arrIllegalTitle() As String = {"タブ", "カンマ", "改行文字", "改行文字", "改行文字", "シングルクォーテーション", "ダブルクォーテーション"}

        '''========================================================================================
        ''' <summary>ｴﾗｰﾒｯｾｰｼﾞ</summary>
        '''========================================================================================
        Private _lastError As String = ""
        Public ReadOnly Property LastError() As String
            Get
                Return _lastError
            End Get
        End Property

        '''========================================================================================
        ''' <summary>単独ｴﾗｰﾒｯｾｰｼﾞ</summary>
        ''' <param name="MsgStack">複合ｴﾗｰﾒｯｾｰｼﾞ</param>
        ''' <param name="MsgCurrent">単独ｴﾗｰﾒｯｾｰｼﾞ</param>
        '''========================================================================================
        Public Sub SetMessage(ByRef MsgStack As String, ByVal MsgCurrent As String)
            If MsgCurrent <> "" Then
                If MsgStack = "" Then
                    MsgStack = MsgCurrent
                Else
                    MsgStack &= vbCrLf & MsgCurrent
                End If
            End If
        End Sub

        Public Sub SetMessage(ByRef MsgStack As String, ByVal MsgCurrent As String, ByRef Control As System.Windows.Forms.Control, ByRef Item As Field.ItemData)
            Me.SetMessage(MsgStack, MsgCurrent)
            Item.IsError = True
            Control = Item.Control
        End Sub

        '''========================================================================================
        ''' <summary>共通検査</summary>
        ''' <param name="Item">ﾌｨｰﾙﾄﾞｸﾗｽ</param>
        ''' <returns>True:ｴﾗｰなし、False:ｴﾗｰあり</returns>
        '''========================================================================================
        Public Function BaseChecker(ByRef Item As Field.ItemData) As Boolean
            Dim strLastError As String = ""

            If Item.Control Is Nothing Then
                '必須
                If Item.Required Then
                    If BaseCore.Common.Text.IsEmptyOrZero(Item.Value) Then
                        Item.IsError = True
                        Me.SetMessage(strLastError, Item.Name & "を入力してください。")
                    End If
                End If

                ''長さ
                'If Item.MaxLength > 0 Then
                '    If Item.NumberMajor <> -1 Then
                '        If IsNumeric(Item.Value) Then
                '            If BaseCore.Common.Text.DecimalLenMajor(Item.Value) > Item.NumberMajor Then
                '                Item.IsError = True
                '                Me.SetMessage(strLastError, Item.Name & Item.NumberMajor.ToString & "桁以内で整数部を入力してください。")
                '            End If

                '            If BaseCore.Common.Text.DecimalLenMinor(Item.Value) > Item.NumberMinor Then
                '                Item.IsError = True
                '                Me.SetMessage(strLastError, Item.Name & Item.NumberMinor.ToString & "桁以内で小数部を入力してください。")
                '            End If
                '        End If

                '    Else
                '        If Not Me.IsLength(Item, Item.MaxLength) Then
                '            Item.IsError = True
                '            Me.SetMessage(strLastError, _lastError)
                '        End If
                '    End If
                'End If

                ' 禁則文字
                If Me.IsIllegal(Item) Then
                    Item.IsError = True
                    Me.SetMessage(strLastError, _lastError)
                End If
            Else
                Select Case Item.ControlType
                    Case BaseContents.Field.ControlType.TextBox
                        '必須
                        If Item.Required And Item.Visible Then
                            Select Case Item.Control.TextStyle
                                Case BaseContents.TextBox.TextStyle.Currency
                                    If BaseCore.Common.Text.IsEmptyOrZero(Item.Value, True) Then
                                        Item.IsError = True
                                        Me.SetMessage(strLastError, Item.Name & "を入力してください。")
                                    End If
                                Case Else
                                    If BaseCore.Common.Text.IsEmptyOrZero(Item.Value) Then
                                        Item.IsError = True
                                        Me.SetMessage(strLastError, Item.Name & "を入力してください。")
                                    End If
                            End Select
                        End If

                        ''長さ
                        'If Not Me.IsLength(Item, Item.MaxLength) Then
                        '    Item.IsError = True
                        '    Me.SetMessage(strLastError, _lastError)
                        'End If

                        '日付検査
                        Select Case Item.Control.TextStyle
                            Case BaseContents.TextBox.TextStyle.YYYYMMDD, BaseContents.TextBox.TextStyle.DateTimeF, BaseContents.TextBox.TextStyle.DateTimeT
                                If Not Me.IsDateTime(Item) Then
                                    Item.IsError = True
                                    Me.SetMessage(strLastError, _lastError)
                                End If

                            Case BaseContents.TextBox.TextStyle.YYYYMM
                                If Not Me.IsYYYYMM(Item) Then
                                    Item.IsError = True
                                    Me.SetMessage(strLastError, _lastError)
                                End If
                        End Select

                        ' 禁則文字
                        If Me.IsIllegal(Item) Then
                            Item.IsError = True
                            Me.SetMessage(strLastError, _lastError)
                        End If

                    Case BaseContents.Field.ControlType.ComboBox
                        '未入力
                        If Item.Required And Item.Visible Then
                            If BaseCore.Common.Text.IsEmptyOrZero(Item.Value) Then
                                Item.IsError = True
                                Me.SetMessage(strLastError, Item.Name & "を入力してください。")
                            End If
                        End If

                    Case BaseContents.Field.ControlType.ListBox
                        '未入力
                        If Item.Required And Item.Visible Then
                            If BaseCore.Common.Text.IsEmptyOrZero(Item.Value) Then
                                Item.IsError = True
                                Me.SetMessage(strLastError, Item.Name & "を入力してください。")
                            End If
                        End If
                End Select
            End If

            'ｴﾗｰ判定
            If strLastError = "" Then
                'ｴﾗｰなし
                Return True
            Else
                'ｴﾗｰあり
                _lastError = strLastError
                Return False
            End If
        End Function

        Public Function BaseChecker(ByRef Item As Field.ItemData, ByRef ErrorMsg As String, ByRef Control As System.Windows.Forms.Control) As Boolean
            ' 最初のｴﾗｰしか検査しない
            If ErrorMsg <> "" Then
                'ｴﾗｰなし
                Return True
            End If

            ' ｴﾗｰｺﾝﾄﾛｰﾙの初期化
            If ErrorMsg = "" Then
                Control = Nothing
            End If

            ' ｴﾗｰならﾒｯｾｰｼﾞとｺﾝﾄﾛｰﾙを設定
            If Not BaseChecker(Item) Then
                SetMessage(ErrorMsg, LastError)
                Control = Item.Control
                'ｴﾗｰあり
                Return False
            End If

            'ｴﾗｰなし
            Return True
        End Function


        '''========================================================================================
        ''' <summary>共通検査</summary>
        ''' <param name="ErrMsg">ｴﾗｰﾒｯｾｰｼﾞ</param>
        ''' <param name="Value">検査する値</param>
        ''' <param name="Field">ﾃﾞｰﾀﾍﾞｰｽﾌｨｰﾙﾄﾞ</param>
        ''' <param name="Required">必須</param>
        ''' <param name="LenMajor">整数部の桁数</param>
        ''' <param name="LenMinor">小数部の桁数</param>
        ''' <returns>True:ｴﾗｰなし、False:ｴﾗｰあり</returns>
        '''========================================================================================
        Public Function BaseChecker(ByRef ErrMsg As String, ByVal Value As Object _
                                  , ByVal Field As System.Data.DataColumn _
                                  , ByVal Required As Boolean _
                                  , Optional ByVal LenMajor As Integer = 0 _
                                  , Optional ByVal LenMinor As Integer = 0 _
                                   ) As Boolean
            Select Case Type.GetTypeCode(Field.DataType)
                Case TypeCode.Decimal, TypeCode.Double, TypeCode.Single, TypeCode.Int16, TypeCode.Int32, TypeCode.Int64
                    ' 未入力は即終了
                    If BaseCore.Common.Text.Nz(Value, 0) = 0 Then
                        If Required Then
                            ErrMsg = "必須項目です。"
                            Return False
                        End If

                        Return True
                    End If

                    If Not IsNumeric(Value) Then
                        ErrMsg = "数字として認識できません。"
                        Return False
                    End If

                    Dim arrNum() As String = BaseCore.Common.Text.CVal(Value).ToString.Split(".")
                    ' 整数部
                    If arrNum.Length > 0 Then
                        If arrNum(0).Length > LenMajor Then
                            ErrMsg = LenMajor.ToString & "桁以内で整数部を入力してください。"
                            Return False
                        End If
                    End If

                    ' 小数部
                    If arrNum.Length > 1 Then
                        If arrNum(1).Length > LenMinor Then
                            ErrMsg = LenMinor.ToString & "桁以内で小数部を入力してください。"
                            Return False
                        End If
                    End If

                Case TypeCode.String, TypeCode.Char
                    ' 未入力は即終了
                    If BaseCore.Common.Text.Nz(Value, "").ToString = "" Then
                        If Required Then
                            ErrMsg = "必須項目です。"
                            Return False
                        End If

                        Return True
                    End If

                    ' 桁数検査
                    If BaseCore.Common.Text.LenB(Value) > Field.MaxLength Then
                        ErrMsg = Field.MaxLength & "ﾊﾞｲﾄ以内で入力してください。"
                        Return False
                    End If

                    ' 禁則文字
                    If Me.IsIllegal(Value) Then
                        ErrMsg = _lastError
                        Return False
                    End If
            End Select

            Return True
        End Function

        ' '''========================================================================================
        ' ''' <summary>文字長(True:検査OK、False:検査NG)</summary>
        ' ''' <param name="Item">ﾌｨｰﾙﾄﾞｸﾗｽ</param>
        ' ''' <param name="MaxLength">長さ</param>
        ' ''' <returns>True:検査OK、False:検査NG</returns>
        ' '''========================================================================================
        'Public Function IsLength(ByVal Item As Field.ItemData, ByVal MaxLength As Integer) As Boolean
        '    Select Case Item.ImeMode
        '        Case BaseContents.TextBox.ImeMode.None
        '            If Not BaseCore.Common.Text.IsEmptyOrZero(Item.Value, IsNumeric(Item.Value)) Then
        '                If BaseCore.Common.Text.LenB(Item.Value) > MaxLength Then
        '                    _lastError = Item.Name & "は" & MaxLength & "ﾊﾞｲﾄ以内で入力してください。"
        '                    Return False
        '                End If
        '            End If

        '        Case BaseContents.TextBox.ImeMode.Narrow _
        '           , BaseContents.TextBox.ImeMode.NarrowWide
        '            If BaseCore.Common.Text.LenB(Item.Value) > MaxLength Then
        '                _lastError = Item.Name & "は" & MaxLength & "ﾊﾞｲﾄ以内で入力してください。"
        '                Return False
        '            End If

        '        Case BaseContents.TextBox.ImeMode.Wide
        '            If Text.Len(Item.Value) > MaxLength Then
        '                _lastError = Item.Name & "は" & MaxLength & "文字以内で入力してください。"
        '                Return False
        '            End If

        '        Case BaseContents.TextBox.ImeMode.NarrowKana
        '            If Text.Len(Item.Value) > MaxLength Then
        '                _lastError = Item.Name & "は" & MaxLength & "文字以内で入力してください。"
        '                Return False
        '            End If
        '    End Select

        '    Return True
        'End Function

        '''========================================================================================
        ''' <summary>未入力(True:入力なし、False:入力あり)</summary>
        ''' <param name="Item">ﾌｨｰﾙﾄﾞｸﾗｽ</param>
        ''' <returns>True:入力なし、False:入力あり</returns>
        '''========================================================================================
        Public Function IsEmpty(ByVal Item As Field.ItemData) As Boolean
            If Item.Value Is Nothing Then
                _lastError = Item.Name & "を入力してください。"
                Return True
            End If
            If Item.Value.ToString = "" Then
                _lastError = Item.Name & "を入力してください。"
                Return True
            End If
            Return False
        End Function

        '''========================================================================================
        ''' <summary>禁則文字(True:禁則文字あり、False:禁則文字なし)</summary>
        ''' <param name="Value">値</param>
        ''' <returns>True:禁則文字あり、False:禁則文字なし</returns>
        '''========================================================================================
        Public Function IsIllegal(ByVal Value As String) As Boolean
            Dim i As Integer

            If Value <> "" Then
                For i = 0 To arrIllegalString.Length - 1
                    If Value.ToString.ToUpper.Contains(arrIllegalString(i).ToUpper) Then
                        _lastError = "｢" & arrIllegalTitle(i) & "｣は禁則文字のため使用することはできません。"
                        Return True
                    End If
                Next
            End If

            Return False
        End Function

        '''========================================================================================
        ''' <summary>禁則文字(True:禁則文字あり、False:禁則文字なし)</summary>
        ''' <param name="Item">ﾌｨｰﾙﾄﾞｸﾗｽ</param>
        ''' <returns>True:禁則文字あり、False:禁則文字なし</returns>
        '''========================================================================================
        Public Function IsIllegal(ByVal Item As Field.ItemData) As Boolean
            Dim i As Integer

            If Not Item.Value Is Nothing Then
                For i = 0 To arrIllegalString.Length - 1
                    If Item.Value.ToString.ToUpper.Contains(arrIllegalString(i).ToUpper) Then
                        If Item.NumberMajor <> -1 And Item.Value.ToString.ToUpper.Contains(",") Then
                            ' 数字のｶﾝﾏはOK
                            Continue For
                        End If

                        _lastError = "｢" & arrIllegalTitle(i) & "｣は禁則文字のため使用することはできません。"
                        Return True
                    End If
                Next
            End If

            Return False
        End Function

        '''========================================================================================
        ''' <summary>半角みOK(True:検査OK、False:検査NG)</summary>
        ''' <param name="Item">ﾌｨｰﾙﾄﾞｸﾗｽ</param>
        ''' <returns>True:検査OK、False:検査NG</returns>
        '''========================================================================================
        Public Function IsNarrow(ByVal Item As Field.ItemData) As Boolean
            If Item.Value Is Nothing Then
                Return True
            End If
            If Item.Value.ToString = "" Then
                Return True
            Else
                If Text.IsUseWide(Item.Value) Then
                    _lastError = Item.Name & "には全角文字が含まれています。"
                    Return False
                End If
            End If
            Return True
        End Function

        '''========================================================================================
        ''' <summary>全角のみOK(True:検査OK、False:検査NG)</summary>
        ''' <param name="Item">ﾌｨｰﾙﾄﾞｸﾗｽ</param>
        ''' <returns>True:検査OK、False:検査NG</returns>
        '''========================================================================================
        Public Function IsWide(ByVal Item As Field.ItemData) As Boolean
            If Item.Value Is Nothing Then
                Return True
            End If
            If Item.Value.ToString = "" Then
                Return True
            Else
                If Text.IsUseNarrow(Item.Value) Then
                    _lastError = Item.Name & "には半角文字が含まれています。"
                    Return False
                End If
            End If
            Return True
        End Function

        '''========================================================================================
        ''' <summary>日付として正しいか検査する(True:検査OK、False:検査NG)</summary>
        ''' <param name="Item">ﾌｨｰﾙﾄﾞｸﾗｽ</param>
        ''' <returns>True:検査OK、False:検査NG</returns>
        '''========================================================================================
        Public Function IsDateTime(ByVal Item As Field.ItemData) As Boolean
            If Item.Value Is Nothing Then Return True
            If Item.Value.ToString = "" Then Return True

            If Not IsDate(Item.Value) Then
                _lastError = Item.Name & "は日付または時間として認識できません。"
                Return False
            End If

            Return True
        End Function

        Public Function IsYYYYMM(ByVal Item As Field.ItemData) As Boolean
            If Item.Value Is Nothing Then Return True
            If Item.Value.ToString = "" Then Return True

            If Not IsDate(Item.Value & "/01") Then
                _lastError = Item.Name & "は年月として認識できません。"
                Return False
            End If

            Return True
        End Function

        '''========================================================================================
        ''' <summary>数字として正しいか検査する(True:検査OK、False:検査NG)</summary>
        ''' <param name="Item">ﾌｨｰﾙﾄﾞｸﾗｽ</param>
        ''' <returns>True:検査OK、False:検査NG</returns>
        '''========================================================================================
        Public Function IsNum(ByVal Item As Field.ItemData) As Boolean
            If Not IsNumeric(Item.Value) Then
                _lastError = Item.Name & "は数字のみ入力可能です。"
                Return False
            End If
            Return True
        End Function

        '''========================================================================================
        ''' <summary>From≦Item≦Toとなっているか検査する。(True:検査OK、False:検査NG)</summary>
        ''' <param name="Item">ﾌｨｰﾙﾄﾞｸﾗｽ</param>
        ''' <param name="FromValue">ﾌｨｰﾙﾄﾞｸﾗｽ</param>
        ''' <param name="ToValue">ﾌｨｰﾙﾄﾞｸﾗｽ</param>
        ''' <returns>True:検査OK、False:検査NG</returns>
        '''========================================================================================
        Public Function IsBetween(ByVal Item As Field.ItemData, ByVal FromValue As Object, ByVal ToValue As Object) As Boolean
            Dim blnErr As Boolean = False

            If IsNumeric(Item.Value) And IsNumeric(FromValue) And IsNumeric(ToValue) Then
                If CDec(Item.Value) < CDec(FromValue) Or CDec(Item.Value) > CDec(ToValue) Then
                    blnErr = True
                End If
            Else
                If IsNumeric(FromValue) And IsNumeric(ToValue) Then
                    If BaseCore.Common.Text.CVal(Item.Value) < FromValue Or BaseCore.Common.Text.CVal(Item.Value) > ToValue Then
                        blnErr = True
                    End If
                Else
                    If Item.Value < FromValue Or Item.Value > ToValue Then
                        blnErr = True
                    End If
                End If
            End If

            If blnErr Then
                _lastError = Item.Name & "は" & FromValue & "～" & ToValue & " の範囲のみ入力可能です。"
                Return False
            Else
                Return True
            End If
        End Function

        '''========================================================================================
        ''' <summary>SmallがBigより小さいか検査する。等しい時はFalseを返す。(True:検査OK、False:検査NG)</summary>
        ''' <param name="ItemSmall">ﾌｨｰﾙﾄﾞｸﾗｽ</param>
        ''' <param name="ItemBig">ﾌｨｰﾙﾄﾞｸﾗｽ</param>
        ''' <returns>True:検査OK、False:検査NG</returns>
        '''========================================================================================
        Public Function IsSmallLessBig(ByVal ItemSmall As Field.ItemData, ByVal ItemBig As Field.ItemData) As Boolean
            Dim blnErr As Boolean = False

            If IsNumeric(ItemSmall.Value) And IsNumeric(ItemBig.Value) Then
                blnErr = (CDec(ItemSmall.Value) > CDec(ItemBig.Value))
            Else
                blnErr = (ItemSmall.Value > ItemBig.Value)
            End If

            If blnErr Then
                _lastError = ItemSmall.Name & "の範囲指定が正しくありません。"
                Return False
            Else
                Return True
            End If
        End Function

        '''========================================================================================
        ''' <summary>Item1とItem2が同じ値か検査する(True:検査OK、False:検査NG)</summary>
        ''' <param name="Item1">ﾌｨｰﾙﾄﾞｸﾗｽ</param>
        ''' <param name="Item2">ﾌｨｰﾙﾄﾞｸﾗｽ</param>
        ''' <returns>True:検査OK、False:検査NG</returns>
        '''========================================================================================
        Public Function IsEqual(ByVal Item1 As Field.ItemData, ByVal Item2 As Field.ItemData) As Boolean
            Dim blnErr As Boolean = False

            blnErr = (Item1.Value <> Item2.Value)

            If blnErr Then
                _lastError = Item2.Name & "の確認入力が一致しません。"
                Return False
            Else
                Return True
            End If
        End Function

        '''========================================================================================
        ''' <summary>ﾒｰﾙｱﾄﾞﾚｽとして正しいか検査する(True:検査OK、False:検査NG)</summary>
        ''' <param name="Item">ﾌｨｰﾙﾄﾞｸﾗｽ</param>
        ''' <returns>True:検査OK、False:検査NG</returns>
        '''========================================================================================
        Public Function IsEMail(ByVal Item As Field.ItemData) As Boolean
            If Not Item.Value Is Nothing Then
                If Item.Value.ToString <> "" Then
                    If InStr(Item.Value, "@") < 2 Or InStr(Item.Value, "@") = Microsoft.VisualBasic.Len(Item.Value) Or InStr(Item.Value, ".") = 0 Then
                        _lastError = Item.Name & "に正しいメールアドレスを指定してください。"
                        Return False
                    End If
                End If
            End If

            Return True
        End Function
    End Class
End Namespace
