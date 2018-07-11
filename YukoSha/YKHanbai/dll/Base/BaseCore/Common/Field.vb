Namespace Common
    Public Class Field
        Public Class ItemData

#Region "ﾌﾟﾛﾊﾟﾃｨ"
            '''========================================================================================
            ''' <SUMMARY>Name</SUMMARY>   
            '''========================================================================================
            Private _name As String = ""
            Public Property Name() As String
                Get
                    Return _name
                End Get
                Set(ByVal value As String)
                    _name = value
                End Set
            End Property

            '''========================================================================================
            ''' <SUMMARY>Column</SUMMARY>   
            '''========================================================================================
            Private _column As New System.Data.DataColumn
            Public Property Column() As System.Data.DataColumn
                Get
                    Return _column
                End Get
                Set(ByVal value As System.Data.DataColumn)
                    _column = value
                End Set
            End Property

            '''========================================================================================
            ''' <SUMMARY>StringLength</SUMMARY>   
            '''========================================================================================
            Private _StringLength As Integer
            Public Property StringLength() As Integer
                Get
                    If _StringLength <> -1 Then
                        Return _StringLength
                    Else
                        Select Case True
                            Case _controlType = BaseContents.Field.ControlType.TextBox _
                               , _controlType = BaseContents.Field.ControlType.NameBox
                                Select Case CType(_control.TextStyle, BaseContents.TextBox.TextStyle)
                                    Case BaseContents.TextBox.TextStyle.Currency
                                        Dim intDiv As Integer
                                        Dim intRem As Integer
                                        intDiv = Math.DivRem(CInt(Me.NumberMajor) - 1, 3, intRem)

                                        If CInt(Me.NumberMinor) = 0 Then
                                            Return CInt(Me.NumberMajor) + intDiv                               '+intDivはｶﾝﾏ数
                                        Else
                                            Return CInt(Me.NumberMajor) + intDiv + CInt(Me.NumberMinor) + 1    '+intDivはｶﾝﾏ数、+1は小数点
                                        End If

                                    Case BaseContents.TextBox.TextStyle.Number
                                        Return CInt(Me.NumberMajor) + CInt(Me.NumberMajor) + 1      '+ 1は小数点

                                    Case Else
                                        Return Me.NumberMajor + Me.NumberMinor
                                End Select

                            Case Else
                                Return Me.NumberMajor + Me.NumberMinor
                        End Select
                    End If
                End Get

                Set(ByVal value As Integer)
                    _StringLength = value
                End Set
            End Property

            '''========================================================================================
            ''' <SUMMARY>整数長</SUMMARY>   
            '''========================================================================================
            Private _NumberMajor As Integer
            Public Property NumberMajor() As Integer
                Get
                    Return _NumberMajor
                End Get
                Set(ByVal value As Integer)
                    _NumberMajor = value
                End Set
            End Property

            '''========================================================================================
            ''' <SUMMARY>小数長</SUMMARY>   
            '''========================================================================================
            Private _NumberMinor As Integer
            Public Property NumberMinor() As Integer
                Get
                    Return _NumberMinor
                End Get
                Set(ByVal value As Integer)
                    _NumberMinor = value
                End Set
            End Property


            '''========================================================================================
            ''' <SUMMARY>ｺﾝﾄﾛｰﾙ</SUMMARY>   
            '''========================================================================================
            Private _control As Object = Nothing

            Public Property Control() As Object
                Get
                    Return _control
                End Get
                Set(ByVal value As Object)
                    Dim _controlType As BaseContents.Field.ControlType = BaseContents.Field.ControlType.None

                    If Not value Is Nothing Then
                        Select Case value.GetType.Name
                            Case "Button" : _controlType = BaseContents.Field.ControlType.Button
                            Case "CheckBox" : _controlType = BaseContents.Field.ControlType.CheckBox
                            Case "ComboBox" : _controlType = BaseContents.Field.ControlType.ComboBox
                            Case "GroupBox" : _controlType = BaseContents.Field.ControlType.GroupBox
                            Case "GridView" : _controlType = BaseContents.Field.ControlType.GridView
                            Case "Label" : _controlType = BaseContents.Field.ControlType.Label
                            Case "ListBox" : _controlType = BaseContents.Field.ControlType.ListBox
                            Case "PictureBox" : _controlType = BaseContents.Field.ControlType.PictureBox
                            Case "ProgressBar" : _controlType = BaseContents.Field.ControlType.ProgressBar
                            Case "RadioButton" : _controlType = BaseContents.Field.ControlType.RadioButton
                            Case "TextBox" : _controlType = BaseContents.Field.ControlType.TextBox
                            Case "NameBox" : _controlType = BaseContents.Field.ControlType.NameBox
                            Case Else
                                If value.GetType.BaseType.Namespace = "System" Then
                                    _controlType = BaseContents.Field.ControlType.Field
                                    Me.Control(_controlType) = value
                                    Exit Property
                                End If
                        End Select
                    End If

                    Dim objValue As Object = Me.Value
                    Dim objIsError As Object = Me.IsError

                    Me.Control(_controlType) = value

                    Me.Value = objValue
                    Me.IsError = objIsError
                End Set
            End Property

            Public Property Control(ByVal ctrlType As BaseContents.Field.ControlType) As Object
                Get
                    Return _control
                End Get
                Set(ByVal value As Object)
                    ' 値の退避
                    Dim swapValue As Object = Me.Value

                    ' ｺﾝﾄﾛｰﾙ保持
                    _controlType = ctrlType
                    _control = value

                    ' 退避した値を戻す
                    Select Case _controlType
                        Case BaseContents.Field.ControlType.CheckBox                            ' ﾁｪｯｸﾎﾞｯｸｽ
                            If swapValue.ToString = "" Then
                                _control.Checked = False
                            Else
                                If swapValue.ToString = "1" Then
                                    _control.Checked = True
                                Else
                                    _control.Checked = False
                                End If
                            End If

                        Case BaseContents.Field.ControlType.ComboBox                            ' ﾄﾞﾛｯﾌﾟﾀﾞｳﾝﾘｽﾄ
                            _control.SelectedValue = swapValue

                        Case BaseContents.Field.ControlType.RadioButton                         ' ﾗｼﾞｵﾎﾞﾀﾝ
                            If swapValue.ToString = "" Then
                                _control.Checked = False
                            Else
                                If swapValue.ToString = "1" Then
                                    _control.Checked = True
                                Else
                                    _control.Checked = False
                                End If
                            End If
                        Case BaseContents.Field.ControlType.Label                               ' ﾗﾍﾞﾙ
                            _control.Text = BaseCore.Common.Text.Nz(swapValue, "")

                        Case BaseContents.Field.ControlType.ListBox                             ' ﾘｽﾄﾎﾞｯｸｽ
                            _control.SelectedValue = BaseCore.Common.Text.Nz(swapValue, "")

                        Case BaseContents.Field.ControlType.PictureBox                          ' ｲﾒｰｼﾞ
                            _control.ImageURL = BaseCore.Common.Text.Nz(swapValue, "")

                        Case BaseContents.Field.ControlType.RadioButton                         ' ﾗｼﾞｵﾎﾞﾀﾝ
                            _control.Checked = BaseCore.Common.Text.Nz(swapValue, "")

                        Case BaseContents.Field.ControlType.TextBox _
                           , BaseContents.Field.ControlType.NameBox                             ' ﾃｷｽﾄﾎﾞｯｸｽ, ﾈｰﾑﾎﾞｯｸｽ
                            Select Case CType(_control.TextStyle, BaseContents.TextBox.TextStyle)
                                Case BaseContents.TextBox.TextStyle.Currency _
                                   , BaseContents.TextBox.TextStyle.Number
                                    _control.StringLength = -1
                                    _control.NumberMajor = Me.NumberMajor
                                    _control.NumberMinor = Me.NumberMinor

                                Case Else
                                    _control.StringLength = Me.StringLength
                                    _control.NumberMajor = -1
                                    _control.NumberMinor = -1
                            End Select

                            _control.Text = BaseCore.Common.Text.Nz(swapValue, "")

                        Case BaseContents.Field.ControlType.Field                               ' ﾌｨｰﾙﾄﾞ
                            _control = value

                    End Select
                End Set
            End Property

            '''========================================================================================
            ''' <SUMMARY>ｺﾝﾄﾛｰﾙﾀｲﾌﾟ</SUMMARY>   
            '''========================================================================================
            Private _controlType As BaseContents.Field.ControlType
            Public ReadOnly Property ControlType() As BaseContents.Field.ControlType
                Get
                    Return _controlType
                End Get
            End Property

            '''========================================================================================
            ''' <SUMMARY>Value</SUMMARY>   
            '''========================================================================================
            Private _value As Object = ""
            Public Property Value() As Object
                Get
                    Dim ret As Object = Nothing
                    If _control Is Nothing Then
                        ret = _value
                    Else
                        Select Case _controlType
                            Case BaseContents.Field.ControlType.CheckBox
                                ret = CObj(IIf(_control.Checked, "1", "0"))
                            Case BaseContents.Field.ControlType.ComboBox
                                ret = CObj(_control.SelectedValue)
                            Case BaseContents.Field.ControlType.ListBox
                                ret = CObj(_control.SelectedValue)
                            Case BaseContents.Field.ControlType.PictureBox
                                ret = _control.ImageURL
                            Case BaseContents.Field.ControlType.RadioButton
                                ret = CObj(IIf(_control.Checked, "1", "0"))
                            Case BaseContents.Field.ControlType.TextBox
                                Select Case CType(_control.TextStyle, BaseContents.TextBox.TextStyle)
                                    Case BaseContents.TextBox.TextStyle.Currency, BaseContents.TextBox.TextStyle.Number
                                        ret = BaseCore.Common.Text.CVal(_control.Text)

                                    Case Else
                                        ret = _control.Text
                                End Select

                            Case BaseContents.Field.ControlType.Field
                                ret = _control.ToString

                            Case Else
                                ret = CObj(_control.Text)
                        End Select
                    End If

                    Return BaseCore.Common.Text.Nz(ret, "")
                End Get
                Set(ByVal value As Object)
                    If _control Is Nothing Then
                        _value = BaseCore.Common.Text.Nz(value, "")
                    Else
                        Select Case _controlType
                            Case BaseContents.Field.ControlType.CheckBox
                                _control.Checked = CBool((BaseCore.Common.Text.CVal(value) = 1))
                            Case BaseContents.Field.ControlType.ComboBox
                                _control.SelectedValue = BaseCore.Common.Text.Nz(value, "")
                            Case BaseContents.Field.ControlType.ListBox
                                _control.SelectedValue = BaseCore.Common.Text.Nz(value, "")
                            Case BaseContents.Field.ControlType.PictureBox
                                _control.ImageURL = BaseCore.Common.Text.Nz(value, "")
                            Case BaseContents.Field.ControlType.RadioButton
                                _control.Checked = CBool((BaseCore.Common.Text.CVal(value) = 1))
                            Case BaseContents.Field.ControlType.Field
                                _control = value
                            Case Else
                                _control.Text = BaseCore.Common.Text.Nz(value, "")
                        End Select
                    End If
                End Set
            End Property

            '''========================================================================================
            ''' <SUMMARY>IME-Mode</SUMMARY>   
            '''========================================================================================
            Private _ImeMode As System.Windows.Forms.ImeMode = Windows.Forms.ImeMode.NoControl
            Public ReadOnly Property ImeMode() As System.Windows.Forms.ImeMode
                Get
                    If _control Is Nothing Then
                        Return _ImeMode
                    Else

                        Select Case _controlType
                            Case BaseContents.Field.ControlType.TextBox
                                Return _control.ImeMode

                                '@@@
                                'Return CType(_control, BaseCore.Control.TextBox).ImeMode

                            Case Else
                                Return Windows.Forms.ImeMode.NoControl
                        End Select
                    End If
                End Get
            End Property

            '''========================================================================================
            ''' <SUMMARY>必須</SUMMARY>   
            '''========================================================================================
            Private _Required As Boolean = False
            Public Property Required() As Boolean
                Get
                    If _control Is Nothing Then
                        Return _Required
                    Else
                        Select Case _controlType
                            Case BaseContents.Field.ControlType.TextBox, BaseContents.Field.ControlType.ComboBox
                                Return _control.Required

                            Case Else
                                Return False
                        End Select
                    End If
                End Get
                Set(ByVal value As Boolean)
                    _Required = value
                End Set
            End Property

            '''========================================================================================
            ''' <SUMMARY>表示/非表示</SUMMARY>   
            '''========================================================================================
            Public ReadOnly Property Visible() As Boolean
                Get
                    If _control Is Nothing Then
                        Return True
                    Else
                        Select Case _controlType
                            Case BaseContents.Field.ControlType.CheckBox _
                               , BaseContents.Field.ControlType.ComboBox _
                               , BaseContents.Field.ControlType.RadioButton _
                               , BaseContents.Field.ControlType.PictureBox _
                               , BaseContents.Field.ControlType.Field _
                               , BaseContents.Field.ControlType.TextBox
                                Return _control.Visible

                            Case Else
                                Return True
                        End Select
                    End If
                End Get
            End Property

            '''========================================================================================
            ''' <SUMMARY>Enabled</SUMMARY>   
            '''========================================================================================
            Public Property Enabled() As Boolean
                Get
                    If Not _control Is Nothing Then
                        Dim rc As Boolean
                        Try
                            rc = _control.Enabled
                        Catch ex As Exception
                        End Try
                        Return rc
                    End If
                End Get
                Set(ByVal value As Boolean)
                    If Not _control Is Nothing Then
                        Try
                            _control.Enabled = value
                        Catch ex As Exception
                        End Try
                    End If
                End Set
            End Property

            '''========================================================================================
            ''' <SUMMARY>IsError</SUMMARY>   
            '''========================================================================================
            Private _iserror As Boolean = False
            Public Property IsError() As Boolean
                Get
                    If _control Is Nothing Then
                        Return _iserror
                    Else
                        Select Case _controlType
                            Case BaseContents.Field.ControlType.TextBox
                                Return _control.IsError
                            Case BaseContents.Field.ControlType.ComboBox
                                Return _control.IsError
                            Case BaseContents.Field.ControlType.RadioButton
                                Return _control.IsError
                            Case Else
                                Return _iserror
                        End Select
                    End If
                End Get
                Set(ByVal value As Boolean)
                    If _control Is Nothing Then
                        _iserror = value
                    Else
                        Select Case _controlType
                            Case BaseContents.Field.ControlType.TextBox
                                _control.IsError = value
                            Case BaseContents.Field.ControlType.ComboBox
                                _control.IsError = value
                            Case Else
                                _iserror = value
                        End Select
                    End If
                End Set
            End Property
#End Region

#Region "ｺﾝｽﾄﾗｸﾀ"
            '''========================================================================================
            ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
            ''' <PARAM name="FieldColumn">ﾃﾞｰﾀﾍﾞｰｽ列</PARAM>
            '''========================================================================================
            Public Sub New(ByVal FieldColumn As System.Data.DataColumn)
                Me.Column = FieldColumn
                Me.Name = FieldColumn.ColumnName
                Me.StringLength = FieldColumn.MaxLength
                Me.NumberMajor = -1
                Me.NumberMinor = -1
            End Sub

            '''========================================================================================
            ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
            ''' <PARAM name="FieldColumn">ﾃﾞｰﾀﾍﾞｰｽ列</PARAM>
            ''' <PARAM name="StringLength">ﾌｨｰﾙﾄﾞ長</PARAM>
            '''========================================================================================
            Public Sub New(ByVal FieldColumn As System.Data.DataColumn, ByVal StringLength As Decimal)
                Me.Column = FieldColumn
                Me.Name = FieldColumn.ColumnName
                Me.StringLength = StringLength
                Me.NumberMajor = -1
                Me.NumberMinor = -1
            End Sub

            '''========================================================================================
            ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
            ''' <PARAM name="FieldColumn">ﾃﾞｰﾀﾍﾞｰｽ列</PARAM>
            ''' <PARAM name="NumberMajor">整数長</PARAM>
            ''' <PARAM name="NumberMinor">小数長</PARAM>
            '''========================================================================================
            Public Sub New(ByVal FieldColumn As System.Data.DataColumn, ByVal NumberMajor As Decimal, ByVal NumberMinor As Decimal)
                Me.Column = FieldColumn
                Me.Name = FieldColumn.ColumnName
                Me.StringLength = -1
                Me.NumberMajor = NumberMajor
                Me.NumberMinor = NumberMinor
            End Sub

            '''========================================================================================
            ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
            ''' <PARAM name="FieldColumn">ﾃﾞｰﾀﾍﾞｰｽ列</PARAM>
            ''' <PARAM name="ColumnName">項目名</PARAM>
            '''========================================================================================
            Public Sub New(ByVal FieldColumn As System.Data.DataColumn, ByVal ColumnName As String)
                Me.Column = FieldColumn
                Me.Name = ColumnName
                Me.StringLength = FieldColumn.MaxLength
                Me.NumberMajor = -1
                Me.NumberMinor = -1
            End Sub

            '''========================================================================================
            ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
            ''' <PARAM name="FieldColumn">ﾃﾞｰﾀﾍﾞｰｽ列</PARAM>
            ''' <PARAM name="ColumnName">項目名</PARAM>
            ''' <PARAM name="StringLength">ﾌｨｰﾙﾄﾞ長</PARAM>
            '''========================================================================================
            Public Sub New(ByVal FieldColumn As System.Data.DataColumn, ByVal ColumnName As String, ByVal StringLength As Decimal)
                Me.Column = FieldColumn
                Me.Name = ColumnName
                Me.StringLength = StringLength
                Me.NumberMajor = -1
                Me.NumberMinor = -1
            End Sub

            '''========================================================================================
            ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
            ''' <PARAM name="FieldColumn">ﾃﾞｰﾀﾍﾞｰｽ列</PARAM>
            ''' <PARAM name="ColumnName">項目名</PARAM>
            ''' <PARAM name="NumberMajor">整数長</PARAM>
            ''' <PARAM name="NumberMinor">小数長</PARAM>
            '''========================================================================================
            Public Sub New(ByVal FieldColumn As System.Data.DataColumn, ByVal ColumnName As String, ByVal NumberMajor As Decimal, ByVal NumberMinor As Decimal)
                Me.Column = FieldColumn
                Me.Name = ColumnName
                Me.StringLength = -1
                Me.NumberMajor = NumberMajor
                Me.NumberMinor = NumberMinor
            End Sub

            '''========================================================================================
            ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
            ''' <PARAM name="FieldName">ﾌｨｰﾙﾄﾞ名</PARAM>
            ''' <PARAM name="SystemType">ﾌｨｰﾙﾄﾞ型</PARAM>
            ''' <PARAM name="StringLength">ﾌｨｰﾙﾄﾞ長</PARAM>
            '''========================================================================================
            Public Sub New(ByVal FieldName As String, ByVal SystemType As System.TypeCode, ByVal StringLength As Decimal)
                Me.Name = FieldName
                Me.StringLength = StringLength
                Me.NumberMajor = -1
                Me.NumberMinor = -1
            End Sub

            '''========================================================================================
            ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
            ''' <PARAM name="FieldName">ﾌｨｰﾙﾄﾞ名</PARAM>
            ''' <PARAM name="SystemType">ﾌｨｰﾙﾄﾞ型</PARAM>
            ''' <PARAM name="NumberMajor">整数長</PARAM>
            ''' <PARAM name="NumberMinor">小数長</PARAM>
            '''========================================================================================
            Public Sub New(ByVal FieldName As String, ByVal SystemType As System.TypeCode, ByVal NumberMajor As Decimal, ByVal NumberMinor As Decimal)
                Me.Name = FieldName
                Me.StringLength = -1
                Me.NumberMajor = NumberMajor
                Me.NumberMinor = NumberMinor
            End Sub
#End Region
        End Class
    End Class
End Namespace
