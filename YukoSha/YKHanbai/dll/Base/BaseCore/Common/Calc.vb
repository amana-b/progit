Namespace Common
    Public Class Calc
#Region "列挙"
        '''========================================================================================
        '''  <summary>端数計算</summary>
        '''========================================================================================
        Public Enum ContentsRoundMode
            四捨五入 = 1
            切り捨て = 2
            切り上げ = 3
        End Enum

        '''========================================================================================
        '''  <summary>消費税単位</summary>
        '''========================================================================================
        Public Enum ContentsTaxUnit
            非課税 = 0
            明細単位 = 1
            伝票単位 = 2
            締め単位 = 3
        End Enum

        '''========================================================================================
        '''  <summary>消費税区分</summary>
        '''========================================================================================
        Public Enum ContentsTaxMode
            非課税 = 0
            外税 = 1
            内税 = 2
        End Enum
#End Region

#Region "四捨五入"
        '''========================================================================================
        ''' <summary>四捨五入</summary>
        ''' <param name="Value">値</param>
        ''' <param name="Position">端数位置(-2:百の位, -1:十の位, 0:一の位, 1:小数点第一位, 2:小数点第二位)</param>
        ''' <returns>四捨五入した結果</returns>
        '''========================================================================================
        Public Shared Function Round(ByVal Value As Decimal, ByVal Position As Integer) As Decimal
            Return System.Math.Round(Value, Position, MidpointRounding.AwayFromZero)
        End Function
#End Region

#Region "切り捨て"
        '''========================================================================================
        ''' <summary>切り捨て</summary>
        ''' <param name="Value">値</param>
        ''' <param name="Position">端数位置(-2:百の位, -1:十の位, 0:一の位, 1:小数点第一位, 2:小数点第二位)</param>
        ''' <returns>切り捨てした結果</returns>
        '''========================================================================================
        Public Shared Function RoundDown(ByVal Value As Decimal, ByVal Position As Integer) As Decimal
            Dim dblMoving As Double = System.Math.Pow(10, Position)

            If Value > 0 Then
                Return System.Math.Floor(Value * dblMoving) / dblMoving
            Else
                Return System.Math.Ceiling(Value * dblMoving) / dblMoving
            End If
        End Function
#End Region

#Region "切り上げ"
        '''========================================================================================
        ''' <summary>切り上げ</summary>
        ''' <param name="Value">値</param>
        ''' <param name="Position">端数位置(-2:百の位, -1:十の位, 0:一の位, 1:小数点第一位, 2:小数点第二位)</param>
        ''' <returns>切り上げした結果</returns>
        '''========================================================================================
        Public Shared Function RoundUp(ByVal Value As Decimal, ByVal Position As Integer) As Decimal
            Dim dblMoving As Double = System.Math.Pow(10, Position)

            If Value > 0 Then
                Return System.Math.Ceiling(Value * dblMoving) / dblMoving
            Else
                Return System.Math.Floor(Value * dblMoving) / dblMoving
            End If
        End Function
#End Region

#Region "外税算出"
        '''========================================================================================
        ''' <summary>外税算出</summary>
        ''' <param name="Value">値</param>
        ''' <param name="Position">端数位置(-2:百の位, -1:十の位, 0:一の位, 1:小数点第一位, 2:小数点第二位)</param>
        ''' <param name="Mode">1:四捨五入, 2:切り捨て, 3:切り上げ</param>
        ''' <param name="Rate">税率(5%→0.05)</param>
        ''' <returns>外税額</returns>
        '''========================================================================================
        Public Shared Function TaxExc(ByVal Value As Decimal, ByVal Position As Integer, ByVal Mode As ContentsRoundMode, ByVal Rate As Decimal) As Decimal
            Dim decValue As Decimal = Value * Rate

            Select Case Mode
                Case ContentsRoundMode.四捨五入 : Return Common.Calc.Round(decValue, Position)     '四捨五入
                Case ContentsRoundMode.切り捨て : Return Common.Calc.RoundDown(decValue, Position) '切り捨て
                Case ContentsRoundMode.切り上げ : Return Common.Calc.RoundUp(decValue, Position)   '切り上げ
                Case Else : Return 0
            End Select
        End Function
#End Region

#Region "内税算出"
        '''========================================================================================
        ''' <summary>内税算出</summary>
        ''' <param name="Value">値</param>
        ''' <param name="Position">端数位置(-2:百の位, -1:十の位, 0:一の位, 1:小数点第一位, 2:小数点第二位)</param>
        ''' <param name="Mode">1:四捨五入, 2:切り捨て, 3:切り上げ</param>
        ''' <param name="Rate">税率(5%→5)</param>
        ''' <returns>外税額</returns>
        '''========================================================================================
        Public Shared Function TaxInc(ByVal Value As Decimal, ByVal Position As Integer, ByVal Mode As ContentsRoundMode, ByVal Rate As Decimal) As Decimal
            Dim decValue As Decimal = (Value / (1 + Rate)) * Rate

            Select Case Mode
                Case ContentsRoundMode.四捨五入 : Return Common.Calc.Round(decValue, Position)     '四捨五入
                Case ContentsRoundMode.切り捨て : Return Common.Calc.RoundDown(decValue, Position) '切り捨て
                Case ContentsRoundMode.切り上げ : Return Common.Calc.RoundUp(decValue, Position)   '切り上げ
                Case Else : Return 0
            End Select
        End Function
#End Region

#Region "消費税計算"
        '''========================================================================================
        '''  <summary>消費税計算</summary>
        ''' <example>
        ''' Dim clsTax As New BaseCore.Common.Calc.Tax(BaseCore.Common.Calc.ContentsTaxUnit.伝票単位, BaseCore.Common.Calc.ContentsRoundMode.切り捨て, 0.05)
        ''' 
        ''' For Each row As DataRow In tbl.Rows
        '''     clsTax.Add(New BaseCore.Common.Calc.Tax.Detail(row.税種類, row.金額))    '税種類(内税, 外税, 非課税)
        ''' Next
        ''' 
        ''' clsTax.Execute()
        ''' </example>
        '''========================================================================================
        Public Class Tax
#Region "明細定義"
            '''========================================================================================
            '''  <summary>明細定義</summary>
            '''========================================================================================
            Public Class Detail
#Region "変数定義"
                '''========================================================================================
                '''  <summary>変数定義</summary>
                '''========================================================================================
                Private _TaxMode As ContentsTaxMode
                Private _Money As Decimal           '金額
                Private _MoneyInc As Decimal        '税込額
                Private _MoneyExc As Decimal        '税抜額

                Private _Tax As Decimal             '消費税(内税額 + 外税額)
                Private _TaxInc As Decimal          '内税額
                Private _TaxExc As Decimal          '外税額
#End Region

#Region "ﾌﾟﾛﾊﾟﾃｨ"
                '''========================================================================================
                '''  <summary>消費税区分</summary>
                '''========================================================================================
                Public Property TaxMode() As ContentsTaxMode
                    Get
                        Return _TaxMode
                    End Get
                    Set(ByVal value As ContentsTaxMode)
                        _TaxMode = value
                    End Set
                End Property

                '''========================================================================================
                '''  <summary>金額</summary>
                '''========================================================================================
                Public Property Money() As Decimal
                    Get
                        Return _Money
                    End Get
                    Set(ByVal value As Decimal)
                        _Money = value
                    End Set
                End Property

                '''========================================================================================
                '''  <summary>税込額</summary>
                '''========================================================================================
                Public Property MoneyInc() As Decimal
                    Get
                        Return _MoneyInc
                    End Get
                    Set(ByVal value As Decimal)
                        _MoneyInc = value
                    End Set
                End Property

                '''========================================================================================
                '''  <summary>税抜額</summary>
                '''========================================================================================
                Public Property MoneyExc() As Decimal
                    Get
                        Return _MoneyExc
                    End Get
                    Set(ByVal value As Decimal)
                        _MoneyExc = value
                    End Set
                End Property

                '''========================================================================================
                '''  <summary>消費税</summary>
                '''========================================================================================
                Public Property Tax() As Decimal
                    Get
                        Return _Tax
                    End Get
                    Set(ByVal value As Decimal)
                        _Tax = value
                    End Set
                End Property

                '''========================================================================================
                '''  <summary>内税額</summary>
                '''========================================================================================
                Public Property TaxInc() As Decimal
                    Get
                        Return _TaxInc
                    End Get
                    Set(ByVal value As Decimal)
                        _TaxInc = value
                    End Set
                End Property

                '''========================================================================================
                '''  <summary>外税額</summary>
                '''========================================================================================
                Public Property TaxExc() As Decimal
                    Get
                        Return _TaxExc
                    End Get
                    Set(ByVal value As Decimal)
                        _TaxExc = value
                    End Set
                End Property
#End Region

#Region "ｺﾝｽﾄﾗｸﾀ"
                '''========================================================================================
                ''' <summary>ｺﾝｽﾄﾗｸﾀ</summary>
                '''========================================================================================
                Public Sub New()
                    _Money = 0

                    _MoneyInc = 0
                    _MoneyExc = 0

                    _Tax = 0
                    _TaxInc = 0
                    _TaxExc = 0
                End Sub

                '''========================================================================================
                ''' <summary>ｺﾝｽﾄﾗｸﾀ</summary>
                ''' <param name="TaxMode">消費税区分</param>
                ''' <param name="Money">金額</param>
                '''========================================================================================
                Public Sub New(ByVal TaxMode As ContentsTaxMode, ByVal Money As Decimal)
                    _TaxMode = TaxMode
                    _Money = Money

                    _MoneyInc = 0
                    _MoneyExc = 0

                    _Tax = 0
                    _TaxInc = 0
                    _TaxExc = 0
                End Sub
#End Region
            End Class
#End Region

#Region "ﾌﾟﾛﾊﾟﾃｨ"
            '''========================================================================================
            '''  <summary>消費税単位</summary>
            '''========================================================================================
            Private _TaxUnit As ContentsTaxUnit
            Public Property TaxUnit() As ContentsTaxUnit
                Get
                    Return _TaxUnit
                End Get
                Set(ByVal value As ContentsTaxUnit)
                    _TaxUnit = value
                End Set
            End Property

            '''========================================================================================
            '''  <summary>消費税端数</summary>
            '''========================================================================================
            Private _RoundMode As ContentsRoundMode
            Public Property RoundMode() As ContentsRoundMode
                Get
                    Return _RoundMode
                End Get
                Set(ByVal value As ContentsRoundMode)
                    _RoundMode = value
                End Set
            End Property

            '''========================================================================================
            '''  <summary>消費税率</summary>
            '''========================================================================================
            Private _Rate As Decimal
            Public Property Rate() As Decimal
                Get
                    Return _Rate
                End Get
                Set(ByVal value As Decimal)
                    _Rate = value
                End Set
            End Property

            '''========================================================================================
            '''  <summary>明細行</summary>
            '''========================================================================================
            Public ReadOnly Property Rows(ByVal Index As Integer) As Detail
                Get
                    Return _Rows(Index + 1)
                End Get
            End Property

            '''========================================================================================
            '''  <summary>明細行</summary>
            '''========================================================================================
            Private _Rows As New Collection
            Public ReadOnly Property Rows() As Collection
                Get
                    Return _Rows
                End Get
            End Property

            '''========================================================================================
            '''  <summary>明細数</summary>
            '''========================================================================================
            Public ReadOnly Property Count() As Integer
                Get
                    Return _Rows.Count
                End Get
            End Property

            '''========================================================================================
            '''  <summary>金額計</summary>
            '''========================================================================================
            Private _TotalMoney As Decimal
            Public ReadOnly Property TotalMoney() As Integer
                Get
                    Return _TotalMoney
                End Get
            End Property

            '''========================================================================================
            '''  <summary>税込額計</summary>
            '''========================================================================================
            Private _TotalMoneyInc As Decimal
            Public ReadOnly Property TotalMoneyInc() As Integer
                Get
                    Return _TotalMoneyInc
                End Get
            End Property

            '''========================================================================================
            '''  <summary>税抜額計</summary>
            '''========================================================================================
            Private _TotalMoneyExc As Decimal
            Public ReadOnly Property TotalMoneyExc() As Integer
                Get
                    Return _TotalMoneyExc
                End Get
            End Property

            '''========================================================================================
            '''  <summary>消費税計</summary>
            '''========================================================================================
            Private _TotalTax As Decimal
            Public ReadOnly Property TotalTax() As Integer
                Get
                    Return _TotalTax
                End Get
            End Property

            '''========================================================================================
            '''  <summary>内税計</summary>
            '''========================================================================================
            Private _TotalTaxInc As Decimal
            Public ReadOnly Property TotalTaxInc() As Integer
                Get
                    Return _TotalTaxInc
                End Get
            End Property

            '''========================================================================================
            '''  <summary>外税計</summary>
            '''========================================================================================
            Private _TotalTaxExc As Decimal
            Public ReadOnly Property TotalTaxExc() As Integer
                Get
                    Return _TotalTaxExc
                End Get
            End Property
#End Region

#Region "ｺﾝｽﾄﾗｸﾀ"
            '''========================================================================================
            ''' <summary>ｺﾝｽﾄﾗｸﾀ</summary>
            '''========================================================================================
            Public Sub New()
            End Sub

            '''========================================================================================
            ''' <summary>ｺﾝｽﾄﾗｸﾀ</summary>
            ''' <param name="TaxUnit">消費税単位</param>
            ''' <param name="RoundMode">消費税端数</param>
            '''========================================================================================
            Public Sub New(ByVal TaxUnit As ContentsTaxUnit, ByVal RoundMode As ContentsRoundMode, ByVal Rate As Decimal)
                _TaxUnit = TaxUnit
                _RoundMode = RoundMode
                _Rate = Rate
            End Sub
#End Region

#Region "ﾒｿｯﾄﾞ"
            '''========================================================================================
            ''' <summary>明細行 ｸﾘｱ</summary>
            '''========================================================================================
            Public Sub Clear()
                _Rows.Clear()
            End Sub

            '''========================================================================================
            ''' <summary>明細行 追加</summary>
            '''========================================================================================
            Public Sub Add(ByVal Detail As Detail)
                _Rows.Add(Detail)
            End Sub

            '''========================================================================================
            ''' <summary>計算</summary>
            '''========================================================================================
            Public Sub Execute()
                _TotalTax = 0
                _TotalTaxInc = 0
                _TotalTaxExc = 0

                _TotalMoney = 0
                _TotalMoneyInc = 0
                _TotalMoneyExc = 0

                '------------------------------------------------------------------
                ' 金額計 計算
                '------------------------------------------------------------------
                For Each Dtl As Detail In _Rows
                    _TotalMoney += Dtl.Money
                Next

                '------------------------------------------------------------------
                ' 明細単位 計算(ﾃﾞｨﾌｫﾙﾄ)
                '------------------------------------------------------------------
                For Each Dtl As Detail In _Rows
                    Select Case Dtl.TaxMode
                        Case ContentsTaxMode.内税
                            Dtl.Tax = BaseCore.Common.Calc.TaxInc(Dtl.Money, 0, _RoundMode, _Rate)
                            Dtl.TaxExc = 0
                            Dtl.TaxInc = Dtl.Tax

                            Dtl.MoneyInc = Dtl.Money
                            Dtl.MoneyExc = Dtl.Money - Dtl.Tax

                        Case ContentsTaxMode.外税
                            Dtl.Tax = BaseCore.Common.Calc.TaxExc(Dtl.Money, 0, _RoundMode, _Rate)
                            Dtl.TaxExc = Dtl.Tax
                            Dtl.TaxInc = 0

                            Dtl.MoneyInc = Dtl.Money + Dtl.Tax
                            Dtl.MoneyExc = Dtl.Money

                        Case ContentsTaxMode.非課税
                            Dtl.Tax = 0
                            Dtl.TaxExc = 0
                            Dtl.TaxInc = 0

                            Dtl.MoneyInc = Dtl.Money
                            Dtl.MoneyExc = Dtl.Money
                    End Select

                    _TotalTax += Dtl.Tax
                    _TotalTaxInc += Dtl.TaxInc
                    _TotalTaxExc += Dtl.TaxExc

                    _TotalMoneyInc += Dtl.MoneyInc
                    _TotalMoneyExc += Dtl.MoneyExc
                Next

                '------------------------------------------------------------------
                ' 伝票単位 計算
                '------------------------------------------------------------------
                If _TaxUnit = ContentsTaxUnit.伝票単位 Then
                    Dim decTotalMoneyInc As Decimal = 0
                    Dim decTotalMoneyExc As Decimal = 0
                    Dim decTotalMoneyEpy As Decimal = 0

                    '------------------------------------
                    ' 金額(外税)と金額(内税)をそれぞれ合計
                    '------------------------------------
                    For Each Dtl As Detail In _Rows
                        Select Case Dtl.TaxMode
                            Case ContentsTaxMode.外税
                                decTotalMoneyExc += Dtl.Money

                            Case ContentsTaxMode.内税
                                decTotalMoneyInc += Dtl.Money

                            Case ContentsTaxMode.非課税
                                decTotalMoneyEpy += Dtl.Money
                        End Select
                    Next

                    _TotalTax = BaseCore.Common.Calc.TaxInc(decTotalMoneyInc, 0, _RoundMode, _Rate) + BaseCore.Common.Calc.TaxExc(decTotalMoneyExc, 0, _RoundMode, _Rate)
                    _TotalTaxInc = BaseCore.Common.Calc.TaxInc(decTotalMoneyInc, 0, _RoundMode, _Rate)
                    _TotalTaxExc = BaseCore.Common.Calc.TaxExc(decTotalMoneyExc, 0, _RoundMode, _Rate)

                    _TotalMoneyInc = decTotalMoneyExc + BaseCore.Common.Calc.TaxExc(decTotalMoneyExc, 0, _RoundMode, _Rate) + decTotalMoneyInc + decTotalMoneyEpy
                    _TotalMoneyExc = decTotalMoneyExc + decTotalMoneyInc - BaseCore.Common.Calc.TaxInc(decTotalMoneyInc, 0, _RoundMode, _Rate) + decTotalMoneyEpy
                End If

                '------------------------------------------------------------------
                ' 非課税 計算
                '------------------------------------------------------------------
                If _TaxUnit = ContentsTaxUnit.非課税 Then
                    For Each Dtl As Detail In _Rows
                        Dtl.Tax = 0
                        Dtl.TaxExc = 0
                        Dtl.TaxInc = 0

                        Dtl.MoneyInc = Dtl.Money
                        Dtl.MoneyExc = Dtl.Money

                        _TotalMoneyInc += Dtl.MoneyInc
                        _TotalMoneyExc += Dtl.MoneyExc
                    Next

                    _TotalTax = 0
                    _TotalTaxInc = 0
                    _TotalTaxExc = 0
                End If
            End Sub
#End Region
        End Class
#End Region
    End Class
End Namespace
