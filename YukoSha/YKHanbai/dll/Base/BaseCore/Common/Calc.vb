Namespace Common
    Public Class Calc
#Region "��"
        '''========================================================================================
        '''  <summary>�[���v�Z</summary>
        '''========================================================================================
        Public Enum ContentsRoundMode
            �l�̌ܓ� = 1
            �؂�̂� = 2
            �؂�グ = 3
        End Enum

        '''========================================================================================
        '''  <summary>����ŒP��</summary>
        '''========================================================================================
        Public Enum ContentsTaxUnit
            ��ې� = 0
            ���גP�� = 1
            �`�[�P�� = 2
            ���ߒP�� = 3
        End Enum

        '''========================================================================================
        '''  <summary>����ŋ敪</summary>
        '''========================================================================================
        Public Enum ContentsTaxMode
            ��ې� = 0
            �O�� = 1
            ���� = 2
        End Enum
#End Region

#Region "�l�̌ܓ�"
        '''========================================================================================
        ''' <summary>�l�̌ܓ�</summary>
        ''' <param name="Value">�l</param>
        ''' <param name="Position">�[���ʒu(-2:�S�̈�, -1:�\�̈�, 0:��̈�, 1:�����_����, 2:�����_����)</param>
        ''' <returns>�l�̌ܓ���������</returns>
        '''========================================================================================
        Public Shared Function Round(ByVal Value As Decimal, ByVal Position As Integer) As Decimal
            Return System.Math.Round(Value, Position, MidpointRounding.AwayFromZero)
        End Function
#End Region

#Region "�؂�̂�"
        '''========================================================================================
        ''' <summary>�؂�̂�</summary>
        ''' <param name="Value">�l</param>
        ''' <param name="Position">�[���ʒu(-2:�S�̈�, -1:�\�̈�, 0:��̈�, 1:�����_����, 2:�����_����)</param>
        ''' <returns>�؂�̂Ă�������</returns>
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

#Region "�؂�グ"
        '''========================================================================================
        ''' <summary>�؂�グ</summary>
        ''' <param name="Value">�l</param>
        ''' <param name="Position">�[���ʒu(-2:�S�̈�, -1:�\�̈�, 0:��̈�, 1:�����_����, 2:�����_����)</param>
        ''' <returns>�؂�グ��������</returns>
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

#Region "�O�ŎZ�o"
        '''========================================================================================
        ''' <summary>�O�ŎZ�o</summary>
        ''' <param name="Value">�l</param>
        ''' <param name="Position">�[���ʒu(-2:�S�̈�, -1:�\�̈�, 0:��̈�, 1:�����_����, 2:�����_����)</param>
        ''' <param name="Mode">1:�l�̌ܓ�, 2:�؂�̂�, 3:�؂�グ</param>
        ''' <param name="Rate">�ŗ�(5%��0.05)</param>
        ''' <returns>�O�Ŋz</returns>
        '''========================================================================================
        Public Shared Function TaxExc(ByVal Value As Decimal, ByVal Position As Integer, ByVal Mode As ContentsRoundMode, ByVal Rate As Decimal) As Decimal
            Dim decValue As Decimal = Value * Rate

            Select Case Mode
                Case ContentsRoundMode.�l�̌ܓ� : Return Common.Calc.Round(decValue, Position)     '�l�̌ܓ�
                Case ContentsRoundMode.�؂�̂� : Return Common.Calc.RoundDown(decValue, Position) '�؂�̂�
                Case ContentsRoundMode.�؂�グ : Return Common.Calc.RoundUp(decValue, Position)   '�؂�グ
                Case Else : Return 0
            End Select
        End Function
#End Region

#Region "���ŎZ�o"
        '''========================================================================================
        ''' <summary>���ŎZ�o</summary>
        ''' <param name="Value">�l</param>
        ''' <param name="Position">�[���ʒu(-2:�S�̈�, -1:�\�̈�, 0:��̈�, 1:�����_����, 2:�����_����)</param>
        ''' <param name="Mode">1:�l�̌ܓ�, 2:�؂�̂�, 3:�؂�グ</param>
        ''' <param name="Rate">�ŗ�(5%��5)</param>
        ''' <returns>�O�Ŋz</returns>
        '''========================================================================================
        Public Shared Function TaxInc(ByVal Value As Decimal, ByVal Position As Integer, ByVal Mode As ContentsRoundMode, ByVal Rate As Decimal) As Decimal
            Dim decValue As Decimal = (Value / (1 + Rate)) * Rate

            Select Case Mode
                Case ContentsRoundMode.�l�̌ܓ� : Return Common.Calc.Round(decValue, Position)     '�l�̌ܓ�
                Case ContentsRoundMode.�؂�̂� : Return Common.Calc.RoundDown(decValue, Position) '�؂�̂�
                Case ContentsRoundMode.�؂�グ : Return Common.Calc.RoundUp(decValue, Position)   '�؂�グ
                Case Else : Return 0
            End Select
        End Function
#End Region

#Region "����Ōv�Z"
        '''========================================================================================
        '''  <summary>����Ōv�Z</summary>
        ''' <example>
        ''' Dim clsTax As New BaseCore.Common.Calc.Tax(BaseCore.Common.Calc.ContentsTaxUnit.�`�[�P��, BaseCore.Common.Calc.ContentsRoundMode.�؂�̂�, 0.05)
        ''' 
        ''' For Each row As DataRow In tbl.Rows
        '''     clsTax.Add(New BaseCore.Common.Calc.Tax.Detail(row.�Ŏ��, row.���z))    '�Ŏ��(����, �O��, ��ې�)
        ''' Next
        ''' 
        ''' clsTax.Execute()
        ''' </example>
        '''========================================================================================
        Public Class Tax
#Region "���ג�`"
            '''========================================================================================
            '''  <summary>���ג�`</summary>
            '''========================================================================================
            Public Class Detail
#Region "�ϐ���`"
                '''========================================================================================
                '''  <summary>�ϐ���`</summary>
                '''========================================================================================
                Private _TaxMode As ContentsTaxMode
                Private _Money As Decimal           '���z
                Private _MoneyInc As Decimal        '�ō��z
                Private _MoneyExc As Decimal        '�Ŕ��z

                Private _Tax As Decimal             '�����(���Ŋz + �O�Ŋz)
                Private _TaxInc As Decimal          '���Ŋz
                Private _TaxExc As Decimal          '�O�Ŋz
#End Region

#Region "�����è"
                '''========================================================================================
                '''  <summary>����ŋ敪</summary>
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
                '''  <summary>���z</summary>
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
                '''  <summary>�ō��z</summary>
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
                '''  <summary>�Ŕ��z</summary>
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
                '''  <summary>�����</summary>
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
                '''  <summary>���Ŋz</summary>
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
                '''  <summary>�O�Ŋz</summary>
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

#Region "�ݽ�׸�"
                '''========================================================================================
                ''' <summary>�ݽ�׸�</summary>
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
                ''' <summary>�ݽ�׸�</summary>
                ''' <param name="TaxMode">����ŋ敪</param>
                ''' <param name="Money">���z</param>
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

#Region "�����è"
            '''========================================================================================
            '''  <summary>����ŒP��</summary>
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
            '''  <summary>����Œ[��</summary>
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
            '''  <summary>����ŗ�</summary>
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
            '''  <summary>���׍s</summary>
            '''========================================================================================
            Public ReadOnly Property Rows(ByVal Index As Integer) As Detail
                Get
                    Return _Rows(Index + 1)
                End Get
            End Property

            '''========================================================================================
            '''  <summary>���׍s</summary>
            '''========================================================================================
            Private _Rows As New Collection
            Public ReadOnly Property Rows() As Collection
                Get
                    Return _Rows
                End Get
            End Property

            '''========================================================================================
            '''  <summary>���א�</summary>
            '''========================================================================================
            Public ReadOnly Property Count() As Integer
                Get
                    Return _Rows.Count
                End Get
            End Property

            '''========================================================================================
            '''  <summary>���z�v</summary>
            '''========================================================================================
            Private _TotalMoney As Decimal
            Public ReadOnly Property TotalMoney() As Integer
                Get
                    Return _TotalMoney
                End Get
            End Property

            '''========================================================================================
            '''  <summary>�ō��z�v</summary>
            '''========================================================================================
            Private _TotalMoneyInc As Decimal
            Public ReadOnly Property TotalMoneyInc() As Integer
                Get
                    Return _TotalMoneyInc
                End Get
            End Property

            '''========================================================================================
            '''  <summary>�Ŕ��z�v</summary>
            '''========================================================================================
            Private _TotalMoneyExc As Decimal
            Public ReadOnly Property TotalMoneyExc() As Integer
                Get
                    Return _TotalMoneyExc
                End Get
            End Property

            '''========================================================================================
            '''  <summary>����Ōv</summary>
            '''========================================================================================
            Private _TotalTax As Decimal
            Public ReadOnly Property TotalTax() As Integer
                Get
                    Return _TotalTax
                End Get
            End Property

            '''========================================================================================
            '''  <summary>���Ōv</summary>
            '''========================================================================================
            Private _TotalTaxInc As Decimal
            Public ReadOnly Property TotalTaxInc() As Integer
                Get
                    Return _TotalTaxInc
                End Get
            End Property

            '''========================================================================================
            '''  <summary>�O�Ōv</summary>
            '''========================================================================================
            Private _TotalTaxExc As Decimal
            Public ReadOnly Property TotalTaxExc() As Integer
                Get
                    Return _TotalTaxExc
                End Get
            End Property
#End Region

#Region "�ݽ�׸�"
            '''========================================================================================
            ''' <summary>�ݽ�׸�</summary>
            '''========================================================================================
            Public Sub New()
            End Sub

            '''========================================================================================
            ''' <summary>�ݽ�׸�</summary>
            ''' <param name="TaxUnit">����ŒP��</param>
            ''' <param name="RoundMode">����Œ[��</param>
            '''========================================================================================
            Public Sub New(ByVal TaxUnit As ContentsTaxUnit, ByVal RoundMode As ContentsRoundMode, ByVal Rate As Decimal)
                _TaxUnit = TaxUnit
                _RoundMode = RoundMode
                _Rate = Rate
            End Sub
#End Region

#Region "ҿ���"
            '''========================================================================================
            ''' <summary>���׍s �ر</summary>
            '''========================================================================================
            Public Sub Clear()
                _Rows.Clear()
            End Sub

            '''========================================================================================
            ''' <summary>���׍s �ǉ�</summary>
            '''========================================================================================
            Public Sub Add(ByVal Detail As Detail)
                _Rows.Add(Detail)
            End Sub

            '''========================================================================================
            ''' <summary>�v�Z</summary>
            '''========================================================================================
            Public Sub Execute()
                _TotalTax = 0
                _TotalTaxInc = 0
                _TotalTaxExc = 0

                _TotalMoney = 0
                _TotalMoneyInc = 0
                _TotalMoneyExc = 0

                '------------------------------------------------------------------
                ' ���z�v �v�Z
                '------------------------------------------------------------------
                For Each Dtl As Detail In _Rows
                    _TotalMoney += Dtl.Money
                Next

                '------------------------------------------------------------------
                ' ���גP�� �v�Z(�ި̫��)
                '------------------------------------------------------------------
                For Each Dtl As Detail In _Rows
                    Select Case Dtl.TaxMode
                        Case ContentsTaxMode.����
                            Dtl.Tax = BaseCore.Common.Calc.TaxInc(Dtl.Money, 0, _RoundMode, _Rate)
                            Dtl.TaxExc = 0
                            Dtl.TaxInc = Dtl.Tax

                            Dtl.MoneyInc = Dtl.Money
                            Dtl.MoneyExc = Dtl.Money - Dtl.Tax

                        Case ContentsTaxMode.�O��
                            Dtl.Tax = BaseCore.Common.Calc.TaxExc(Dtl.Money, 0, _RoundMode, _Rate)
                            Dtl.TaxExc = Dtl.Tax
                            Dtl.TaxInc = 0

                            Dtl.MoneyInc = Dtl.Money + Dtl.Tax
                            Dtl.MoneyExc = Dtl.Money

                        Case ContentsTaxMode.��ې�
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
                ' �`�[�P�� �v�Z
                '------------------------------------------------------------------
                If _TaxUnit = ContentsTaxUnit.�`�[�P�� Then
                    Dim decTotalMoneyInc As Decimal = 0
                    Dim decTotalMoneyExc As Decimal = 0
                    Dim decTotalMoneyEpy As Decimal = 0

                    '------------------------------------
                    ' ���z(�O��)�Ƌ��z(����)�����ꂼ�ꍇ�v
                    '------------------------------------
                    For Each Dtl As Detail In _Rows
                        Select Case Dtl.TaxMode
                            Case ContentsTaxMode.�O��
                                decTotalMoneyExc += Dtl.Money

                            Case ContentsTaxMode.����
                                decTotalMoneyInc += Dtl.Money

                            Case ContentsTaxMode.��ې�
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
                ' ��ې� �v�Z
                '------------------------------------------------------------------
                If _TaxUnit = ContentsTaxUnit.��ې� Then
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
