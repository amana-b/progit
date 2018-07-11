Imports System.ComponentModel

Namespace Common
    Public MustInherit Class Frame

#Region "ﾌﾟﾛﾊﾟﾃｨ"
        Private _Security As NodeCore.Common.Security
        Public ReadOnly Property Security() As NodeCore.Common.Security
            Get
                Return _Security
            End Get
        End Property

        Private _Config As NodeCore.Common.Config
        Public ReadOnly Property Config() As NodeCore.Common.Config
            Get
                Return _Config
            End Get
        End Property

        Private _ControlError As Object = Nothing
        Public Property ControlError() As Object
            Get
                Return _ControlError
            End Get
            Set(ByVal value As Object)
                _ControlError = value
            End Set
        End Property

        Private _lastError As String = ""
        Public Property LastError() As String
            Get
                Return _lastError
            End Get
            Set(ByVal value As String)
                _lastError = value
            End Set
        End Property

        Private _RowCount As Integer
        Public Property RowCount() As Integer
            Get
                Return _RowCount
            End Get
            Set(ByVal value As Integer)
                _RowCount = value
            End Set
        End Property

        '----------------------------------------------------------------------
        ' ﾚﾎﾟｰﾄ定義
        '----------------------------------------------------------------------
        Private _Report1 As DataDynamics.ActiveReports.ActiveReport
        Public Property Report1() As DataDynamics.ActiveReports.ActiveReport
            Get
                Return _Report1
            End Get
            Set(ByVal value As DataDynamics.ActiveReports.ActiveReport)
                _Report1 = value
            End Set
        End Property

        Private _Report2 As DataDynamics.ActiveReports.ActiveReport
        Public Property Report2() As DataDynamics.ActiveReports.ActiveReport
            Get
                Return _Report2
            End Get
            Set(ByVal value As DataDynamics.ActiveReports.ActiveReport)
                _Report2 = value
            End Set
        End Property

        Private _Report3 As DataDynamics.ActiveReports.ActiveReport
        Public Property Report3() As DataDynamics.ActiveReports.ActiveReport
            Get
                Return _Report3
            End Get
            Set(ByVal value As DataDynamics.ActiveReports.ActiveReport)
                _Report3 = value
            End Set
        End Property

        Private _Report4 As DataDynamics.ActiveReports.ActiveReport
        Public Property Report4() As DataDynamics.ActiveReports.ActiveReport
            Get
                Return _Report4
            End Get
            Set(ByVal value As DataDynamics.ActiveReports.ActiveReport)
                _Report4 = value
            End Set
        End Property

        Private _Report5 As DataDynamics.ActiveReports.ActiveReport
        Public Property Report5() As DataDynamics.ActiveReports.ActiveReport
            Get
                Return _Report5
            End Get
            Set(ByVal value As DataDynamics.ActiveReports.ActiveReport)
                _Report5 = value
            End Set
        End Property

        '----------------------------------------------------------------------
        ' ﾊﾟｽ
        '----------------------------------------------------------------------
        Private _Path1 As String
        Public Property Path1() As String
            Get
                Return _Path1
            End Get
            Set(ByVal value As String)
                _Path1 = value
            End Set
        End Property

        Private _Path2 As String
        Public Property Path2() As String
            Get
                Return _Path2
            End Get
            Set(ByVal value As String)
                _Path2 = value
            End Set
        End Property

        Private _Path3 As String
        Public Property Path3() As String
            Get
                Return _Path3
            End Get
            Set(ByVal value As String)
                _Path3 = value
            End Set
        End Property

        Private _Path4 As String
        Public Property Path4() As String
            Get
                Return _Path4
            End Get
            Set(ByVal value As String)
                _Path4 = value
            End Set
        End Property

        Private _Path5 As String
        Public Property Path5() As String
            Get
                Return _Path5
            End Get
            Set(ByVal value As String)
                _Path5 = value
            End Set
        End Property

        '----------------------------------------------------------------------
        ' ﾁｪｯｸﾏｰｸ
        '----------------------------------------------------------------------
        Private _CheckMark1 As System.Collections.Generic.SortedList(Of String, Boolean)
        Public Property CheckMark1() As System.Collections.Generic.SortedList(Of String, Boolean)
            Get
                Return _CheckMark1
            End Get
            Set(ByVal value As System.Collections.Generic.SortedList(Of String, Boolean))
                _CheckMark1 = value
            End Set
        End Property

        Private _CheckMark2 As System.Collections.Generic.SortedList(Of String, Boolean)
        Public Property CheckMark2() As System.Collections.Generic.SortedList(Of String, Boolean)
            Get
                Return _CheckMark2
            End Get
            Set(ByVal value As System.Collections.Generic.SortedList(Of String, Boolean))
                _CheckMark2 = value
            End Set
        End Property

        Private _CheckMark3 As System.Collections.Generic.SortedList(Of String, Boolean)
        Public Property CheckMark3() As System.Collections.Generic.SortedList(Of String, Boolean)
            Get
                Return _CheckMark3
            End Get
            Set(ByVal value As System.Collections.Generic.SortedList(Of String, Boolean))
                _CheckMark3 = value
            End Set
        End Property

        Private _CheckMark4 As System.Collections.Generic.SortedList(Of String, Boolean)
        Public Property CheckMark4() As System.Collections.Generic.SortedList(Of String, Boolean)
            Get
                Return _CheckMark4
            End Get
            Set(ByVal value As System.Collections.Generic.SortedList(Of String, Boolean))
                _CheckMark4 = value
            End Set
        End Property

        Private _CheckMark5 As System.Collections.Generic.SortedList(Of String, Boolean)
        Public Property CheckMark5() As System.Collections.Generic.SortedList(Of String, Boolean)
            Get
                Return _CheckMark5
            End Get
            Set(ByVal value As System.Collections.Generic.SortedList(Of String, Boolean))
                _CheckMark5 = value
            End Set
        End Property
#End Region

#Region "ｺﾝｽﾄﾗｸﾀ"
        '''========================================================================================
        ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
        ''' <PARAM name="Security">ｾｷｭﾘﾃｨ ｸﾗｽ</PARAM>
        ''' <PARAM name="Config">ｺﾝﾌｨｸﾞ ｸﾗｽ</PARAM>
        '''========================================================================================
        Public Sub New(ByVal Security As NodeCore.Common.Security, ByVal Config As NodeCore.Common.Config)
            _Security = Security
            _Config = Config
        End Sub
#End Region

#Region "Clear"
        '''========================================================================================
        ''' <SUMMARY>ｸﾘｱ</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Public Function Clear(Optional ByVal KeyClear As Boolean = True) As Boolean
            '----------------------------------------------------------------------
            ' ﾍｯﾀﾞ部
            '----------------------------------------------------------------------
            If Not Me.Clear_Header(KeyClear) Then
                Return False
            End If

            '----------------------------------------------------------------------
            ' 明細部
            '----------------------------------------------------------------------
            If Not Me.Clear_Detail1() Then Return False
            If Not Me.Clear_Detail2() Then Return False
            If Not Me.Clear_Detail3() Then Return False
            If Not Me.Clear_Detail4() Then Return False
            If Not Me.Clear_Detail5() Then Return False

            '----------------------------------------------------------------------
            ' 明細部･･･Read
            '----------------------------------------------------------------------
            If Not Me.Read_Detail1() Then Return False
            If Not Me.Read_Detail2() Then Return False
            If Not Me.Read_Detail3() Then Return False
            If Not Me.Read_Detail4() Then Return False
            If Not Me.Read_Detail5() Then Return False

            '----------------------------------------------------------------------
            ' 後始末
            '----------------------------------------------------------------------
            If Not Me.Read_Terminate() Then Return False

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return True
        End Function

        '''========================================================================================
        ''' <SUMMARY>ﾍｯﾀﾞ</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overridable Function Clear_Header(Optional ByVal KeyClear As Boolean = True) As Boolean
            Return True
        End Function

        '''========================================================================================
        ''' <SUMMARY>明細(全1行)</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overridable Function Clear_Detail1() As Boolean
            Return True
        End Function

        Protected Overridable Function Clear_Detail2() As Boolean
            Return True
        End Function

        Protected Overridable Function Clear_Detail3() As Boolean
            Return True
        End Function

        Protected Overridable Function Clear_Detail4() As Boolean
            Return True
        End Function

        Protected Overridable Function Clear_Detail5() As Boolean
            Return True
        End Function

        '''========================================================================================
        ''' <SUMMARY>明細(1行のみ)</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Public Overridable Function Clear_Detail1(ByVal Index As Integer) As Boolean
            Return True
        End Function

        Public Overridable Function Clear_Detail2(ByVal Index As Integer) As Boolean
            Return True
        End Function

        Public Overridable Function Clear_Detail3(ByVal Index As Integer) As Boolean
            Return True
        End Function

        Public Overridable Function Clear_Detail4(ByVal Index As Integer) As Boolean
            Return True
        End Function

        Public Overridable Function Clear_Detail5(ByVal Index As Integer) As Boolean
            Return True
        End Function
#End Region

#Region "Exist"
        '''========================================================================================
        ''' <SUMMARY>存在確認</SUMMARY>
        ''' <RETURNS>True:あり, False:なし</RETURNS>
        '''========================================================================================
        Public Function Exist() As Boolean
            Return Me.Exist_Header()
        End Function

        '''========================================================================================
        ''' <SUMMARY>ﾍｯﾀﾞ</SUMMARY>
        ''' <RETURNS>True:あり, False:なし</RETURNS>
        '''========================================================================================
        Protected Overridable Function Exist_Header() As Boolean
            Return True
        End Function
#End Region

#Region "Read"
        '''========================================================================================
        ''' <SUMMARY>読込</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Public Function Read() As Boolean
            '----------------------------------------------------------------------
            ' ﾍｯﾀﾞ部
            '----------------------------------------------------------------------
            If Not Me.Read_Header() Then Return False

            '----------------------------------------------------------------------
            ' 明細部
            '----------------------------------------------------------------------
            If Not Me.Read_Detail1() Then Return False
            If Not Me.Read_Detail2() Then Return False
            If Not Me.Read_Detail3() Then Return False
            If Not Me.Read_Detail4() Then Return False
            If Not Me.Read_Detail5() Then Return False

            '----------------------------------------------------------------------
            ' 後始末
            '----------------------------------------------------------------------
            If Not Me.Read_Terminate() Then Return False

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return True
        End Function

        '''========================================================================================
        ''' <SUMMARY>ﾍｯﾀﾞ</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overridable Function Read_Header() As Boolean
            Return True
        End Function

        '''========================================================================================
        ''' <SUMMARY>明細</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overridable Function Read_Detail1() As Boolean
            Return True
        End Function

        Protected Overridable Function Read_Detail2() As Boolean
            Return True
        End Function

        Protected Overridable Function Read_Detail3() As Boolean
            Return True
        End Function

        Protected Overridable Function Read_Detail4() As Boolean
            Return True
        End Function

        Protected Overridable Function Read_Detail5() As Boolean
            Return True
        End Function

        '''========================================================================================
        ''' <SUMMARY>後始末(読込)</SUMMARY>
        ''' <RETURNS>True:正常, False:不正</RETURNS>
        '''========================================================================================
        Protected Overridable Function Read_Terminate() As Boolean
            Return True
        End Function
#End Region

#Region "Write"
#Region "Write"
        '''========================================================================================
        ''' <SUMMARY>書込</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Public Function Write() As Boolean
            '----------------------------------------------------------------------
            ' 明細行 ｶｳﾝﾄｸﾘｱ
            '----------------------------------------------------------------------
            _RowCount = 0

            '----------------------------------------------------------------------
            ' ﾍｯﾀﾞ部
            '----------------------------------------------------------------------
            If Not Me.Write_Header() Then Return False

            '----------------------------------------------------------------------
            ' 明細行 削除
            '----------------------------------------------------------------------
            If Not Me.Delete_Detail1() Then Return False
            If Not Me.Delete_Detail2() Then Return False
            If Not Me.Delete_Detail3() Then Return False
            If Not Me.Delete_Detail4() Then Return False
            If Not Me.Delete_Detail5() Then Return False

            '----------------------------------------------------------------------
            ' 明細部
            '----------------------------------------------------------------------
            If Not Me.Write_Detail1() Then Return False
            If Not Me.Write_Detail2() Then Return False
            If Not Me.Write_Detail3() Then Return False
            If Not Me.Write_Detail4() Then Return False
            If Not Me.Write_Detail5() Then Return False

            '----------------------------------------------------------------------
            ' 後始末
            '----------------------------------------------------------------------
            If Not Me.Write_Terminate() Then Return False

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return True
        End Function

        '''========================================================================================
        ''' <SUMMARY>ﾍｯﾀﾞ</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overridable Function Write_Header() As Boolean
            Return True
        End Function

        '''========================================================================================
        ''' <SUMMARY>明細</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overridable Function Write_Detail1() As Boolean
            Return True
        End Function

        Protected Overridable Function Write_Detail2() As Boolean
            Return True
        End Function

        Protected Overridable Function Write_Detail3() As Boolean
            Return True
        End Function

        Protected Overridable Function Write_Detail4() As Boolean
            Return True
        End Function

        Protected Overridable Function Write_Detail5() As Boolean
            Return True
        End Function

        '''========================================================================================
        ''' <SUMMARY>後始末(書込)</SUMMARY>
        ''' <RETURNS>True:正常, False:不正</RETURNS>
        '''========================================================================================
        Protected Overridable Function Write_Terminate() As Boolean
            Return True
        End Function
#End Region

#Region "Valid_Write"
        '''========================================================================================
        ''' <SUMMARY>検査(共通)</SUMMARY>
        ''' <RETURNS>True:正常, False:不正</RETURNS>
        '''========================================================================================
        Public Function Valid_Write() As NodeContents.ActionButton.ErrorLevel
            Dim ErrLevel As NodeContents.ActionButton.ErrorLevel = NodeContents.ActionButton.ErrorLevel.None
            Dim ErrMsg As String = ""

            '----------------------------------------------------------------------
            ' 事前準備
            '----------------------------------------------------------------------
            Select Case Me.Ready_Write()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select

            '----------------------------------------------------------------------
            ' ﾍｯﾀﾞ部
            '----------------------------------------------------------------------
            Select Case Me.Valid_Write_Header_Common()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select

            Select Case Me.Valid_Write_Header_Another()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select

            '----------------------------------------------------------------------
            ' 明細部
            '----------------------------------------------------------------------
            Select Case Me.Valid_Write_Detail1_Common()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select

            Select Case Me.Valid_Write_Detail1_Another()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select

            Select Case Me.Valid_Write_Detail2_Common()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select

            Select Case Me.Valid_Write_Detail2_Another()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select

            Select Case Me.Valid_Write_Detail3_Common()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select

            Select Case Me.Valid_Write_Detail3_Another()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select

            Select Case Me.Valid_Write_Detail4_Common()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select

            Select Case Me.Valid_Write_Detail4_Another()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select
            Select Case Me.Valid_Write_Detail5_Common()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select

            Select Case Me.Valid_Write_Detail5_Another()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            If ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning Then
                Me.LastError = ErrMsg
            End If
            Return ErrLevel
        End Function

        '''========================================================================================
        ''' <SUMMARY>ﾍｯﾀﾞ(共通)</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overridable Function Valid_Write_Header_Common() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function

        '''========================================================================================
        ''' <SUMMARY>ﾍｯﾀﾞ(個別)</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overridable Function Valid_Write_Header_Another() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function

        '''========================================================================================
        ''' <SUMMARY>明細(共通)</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overridable Function Valid_Write_Detail1_Common() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function

        Protected Overridable Function Valid_Write_Detail2_Common() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function

        Protected Overridable Function Valid_Write_Detail3_Common() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function

        Protected Overridable Function Valid_Write_Detail4_Common() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function

        Protected Overridable Function Valid_Write_Detail5_Common() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function

        '''========================================================================================
        ''' <SUMMARY>明細(個別)</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overridable Function Valid_Write_Detail1_Another() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function

        Protected Overridable Function Valid_Write_Detail2_Another() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function

        Protected Overridable Function Valid_Write_Detail3_Another() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function

        Protected Overridable Function Valid_Write_Detail4_Another() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function

        Protected Overridable Function Valid_Write_Detail5_Another() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function

        '''========================================================================================
        ''' <SUMMARY>前準備(書込)</SUMMARY>
        ''' <RETURNS>True:正常, False:不正</RETURNS>
        '''========================================================================================
        Protected Overridable Function Ready_Write() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function
#End Region
#End Region

#Region "Delete"
#Region "Delete"
        '''========================================================================================
        ''' <SUMMARY>削除</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Public Function Delete() As Boolean
            '----------------------------------------------------------------------
            ' ﾍｯﾀﾞ部
            '----------------------------------------------------------------------
            If Not Me.Delete_Header() Then
                Return False
            End If

            '----------------------------------------------------------------------
            ' 明細部
            '----------------------------------------------------------------------
            If Not Me.Delete_Detail1() Then Return False
            If Not Me.Delete_Detail2() Then Return False
            If Not Me.Delete_Detail3() Then Return False
            If Not Me.Delete_Detail4() Then Return False
            If Not Me.Delete_Detail5() Then Return False

            '----------------------------------------------------------------------
            ' 後始末
            '----------------------------------------------------------------------
            If Not Me.Delete_Terminate() Then Return False

            '----------------------------------------------------------------------
            ' ﾍｯﾀﾞ部(ｸﾘｱ)
            '----------------------------------------------------------------------
            If Not Me.Clear(True) Then Return False

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return True
        End Function

        '''========================================================================================
        ''' <SUMMARY>ﾍｯﾀﾞ</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overridable Function Delete_Header() As Boolean
            Return True
        End Function

        '''========================================================================================
        ''' <SUMMARY>明細</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overridable Function Delete_Detail1() As Boolean
            Return True
        End Function

        Protected Overridable Function Delete_Detail2() As Boolean
            Return True
        End Function

        Protected Overridable Function Delete_Detail3() As Boolean
            Return True
        End Function

        Protected Overridable Function Delete_Detail4() As Boolean
            Return True
        End Function

        Protected Overridable Function Delete_Detail5() As Boolean
            Return True
        End Function

        '''========================================================================================
        ''' <SUMMARY>後始末(削除)</SUMMARY>
        ''' <RETURNS>True:正常, False:不正</RETURNS>
        '''========================================================================================
        Protected Overridable Function Delete_Terminate() As Boolean
            Return True
        End Function
#End Region

#Region "Valid_Delete"
        '''========================================================================================
        ''' <SUMMARY>検査(共通)</SUMMARY>
        ''' <RETURNS>True:正常, False:不正</RETURNS>
        '''========================================================================================
        Public Function Valid_Delete() As NodeContents.ActionButton.ErrorLevel
            Dim ErrLevel As NodeContents.ActionButton.ErrorLevel = NodeContents.ActionButton.ErrorLevel.None
            Dim ErrMsg As String = ""

            '----------------------------------------------------------------------
            ' 事前準備
            '----------------------------------------------------------------------
            Select Case Me.Ready_Delete()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select

            '----------------------------------------------------------------------
            ' ﾍｯﾀﾞ部
            '----------------------------------------------------------------------
            Select Case Me.Valid_Delete_Header_Common()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select

            Select Case Me.Valid_Delete_Header_Another()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select

            '----------------------------------------------------------------------
            ' 明細部
            '----------------------------------------------------------------------
            Select Case Me.Valid_Delete_Detail1_Common()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select

            Select Case Me.Valid_Delete_Detail1_Another()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select

            Select Case Me.Valid_Delete_Detail2_Common()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select

            Select Case Me.Valid_Delete_Detail2_Another()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select

            Select Case Me.Valid_Delete_Detail3_Common()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select

            Select Case Me.Valid_Delete_Detail3_Another()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select

            Select Case Me.Valid_Delete_Detail4_Common()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select

            Select Case Me.Valid_Delete_Detail4_Another()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select

            Select Case Me.Valid_Delete_Detail5_Common()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select

            Select Case Me.Valid_Delete_Detail5_Another()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            If ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning Then
                Me.LastError = ErrMsg
            End If
            Return ErrLevel
        End Function

        '''========================================================================================
        ''' <SUMMARY>ﾍｯﾀﾞ(共通)</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overridable Function Valid_Delete_Header_Common() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function

        '''========================================================================================
        ''' <SUMMARY>ﾍｯﾀﾞ(個別)</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overridable Function Valid_Delete_Header_Another() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function

        '''========================================================================================
        ''' <SUMMARY>明細(共通)</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overridable Function Valid_Delete_Detail1_Common() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function

        Protected Overridable Function Valid_Delete_Detail2_Common() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function

        Protected Overridable Function Valid_Delete_Detail3_Common() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function

        Protected Overridable Function Valid_Delete_Detail4_Common() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function

        Protected Overridable Function Valid_Delete_Detail5_Common() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function

        '''========================================================================================
        ''' <SUMMARY>明細(個別)</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overridable Function Valid_Delete_Detail1_Another() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function

        Protected Overridable Function Valid_Delete_Detail2_Another() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function

        Protected Overridable Function Valid_Delete_Detail3_Another() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function

        Protected Overridable Function Valid_Delete_Detail4_Another() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function

        Protected Overridable Function Valid_Delete_Detail5_Another() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function

        '''========================================================================================
        ''' <SUMMARY>前準備(削除)</SUMMARY>
        ''' <RETURNS>True:正常, False:不正</RETURNS>
        '''========================================================================================
        Protected Overridable Function Ready_Delete() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function
#End Region
#End Region

#Region "Execute"
#Region "Execute"
        '''========================================================================================
        ''' <SUMMARY>実行</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Public Function Execute() As Boolean
            '----------------------------------------------------------------------
            ' ﾍｯﾀﾞ部
            '----------------------------------------------------------------------
            If Not Me.Execute_Header() Then Return False

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return True
        End Function

        '''========================================================================================
        ''' <SUMMARY>ﾍｯﾀﾞ</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overridable Function Execute_Header() As Boolean
            Return True
        End Function
#End Region

#Region "Valid_Execute"
        '''========================================================================================
        ''' <SUMMARY>検査(共通)</SUMMARY>
        ''' <RETURNS>True:正常, False:不正</RETURNS>
        '''========================================================================================
        Public Function Valid_Execute() As NodeContents.ActionButton.ErrorLevel
            Dim ErrLevel As NodeContents.ActionButton.ErrorLevel = NodeContents.ActionButton.ErrorLevel.None
            Dim ErrMsg As String = ""

            '----------------------------------------------------------------------
            ' ﾍｯﾀﾞ部
            '----------------------------------------------------------------------
            Select Case Me.Valid_Execute_Header_Common()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select

            Select Case Me.Valid_Execute_Header_Another()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            If ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning Then
                Me.LastError = ErrMsg
            End If
            Return ErrLevel
        End Function

        '''========================================================================================
        ''' <SUMMARY>ﾍｯﾀﾞ(共通)</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overridable Function Valid_Execute_Header_Common() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function

        '''========================================================================================
        ''' <SUMMARY>ﾍｯﾀﾞ(個別)</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overridable Function Valid_Execute_Header_Another() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function
#End Region
#End Region

#Region "Execute1"
#Region "Execute1"
        '''========================================================================================
        ''' <SUMMARY>実行</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Public Function Execute1() As Boolean
            '----------------------------------------------------------------------
            ' ﾍｯﾀﾞ部
            '----------------------------------------------------------------------
            If Not Me.Execute1_Header() Then Return False

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return True
        End Function

        '''========================================================================================
        ''' <SUMMARY>ﾍｯﾀﾞ</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overridable Function Execute1_Header() As Boolean
            Return True
        End Function
#End Region

#Region "Valid_Execute1"
        '''========================================================================================
        ''' <SUMMARY>検査(共通)</SUMMARY>
        ''' <RETURNS>True:正常, False:不正</RETURNS>
        '''========================================================================================
        Public Function Valid_Execute1() As NodeContents.ActionButton.ErrorLevel
            Dim ErrLevel As NodeContents.ActionButton.ErrorLevel = NodeContents.ActionButton.ErrorLevel.None
            Dim ErrMsg As String = ""

            '----------------------------------------------------------------------
            ' ﾍｯﾀﾞ部
            '----------------------------------------------------------------------
            Select Case Me.Valid_Execute1_Header_Common()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select

            Select Case Me.Valid_Execute1_Header_Another()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            If ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning Then
                Me.LastError = ErrMsg
            End If
            Return ErrLevel
        End Function

        '''========================================================================================
        ''' <SUMMARY>ﾍｯﾀﾞ(共通)</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overridable Function Valid_Execute1_Header_Common() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function

        '''========================================================================================
        ''' <SUMMARY>ﾍｯﾀﾞ(個別)</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overridable Function Valid_Execute1_Header_Another() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function
#End Region
#End Region

#Region "Execute2"
#Region "Execute2"
        '''========================================================================================
        ''' <SUMMARY>実行</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Public Function Execute2() As Boolean
            '----------------------------------------------------------------------
            ' ﾍｯﾀﾞ部
            '----------------------------------------------------------------------
            If Not Me.Execute2_Header() Then Return False

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return True
        End Function

        '''========================================================================================
        ''' <SUMMARY>ﾍｯﾀﾞ</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overridable Function Execute2_Header() As Boolean
            Return True
        End Function
#End Region

#Region "Valid_Execute2"
        '''========================================================================================
        ''' <SUMMARY>検査(共通)</SUMMARY>
        ''' <RETURNS>True:正常, False:不正</RETURNS>
        '''========================================================================================
        Public Function Valid_Execute2() As NodeContents.ActionButton.ErrorLevel
            Dim ErrLevel As NodeContents.ActionButton.ErrorLevel = NodeContents.ActionButton.ErrorLevel.None
            Dim ErrMsg As String = ""

            '----------------------------------------------------------------------
            ' ﾍｯﾀﾞ部
            '----------------------------------------------------------------------
            Select Case Me.Valid_Execute2_Header_Common()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select

            Select Case Me.Valid_Execute2_Header_Another()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            If ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning Then
                Me.LastError = ErrMsg
            End If
            Return ErrLevel
        End Function

        '''========================================================================================
        ''' <SUMMARY>ﾍｯﾀﾞ(共通)</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overridable Function Valid_Execute2_Header_Common() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function

        '''========================================================================================
        ''' <SUMMARY>ﾍｯﾀﾞ(個別)</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overridable Function Valid_Execute2_Header_Another() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function
#End Region
#End Region

#Region "Execute3"
#Region "Execute3"
        '''========================================================================================
        ''' <SUMMARY>実行</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Public Function Execute3() As Boolean
            '----------------------------------------------------------------------
            ' ﾍｯﾀﾞ部
            '----------------------------------------------------------------------
            If Not Me.Execute3_Header() Then Return False

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return True
        End Function

        '''========================================================================================
        ''' <SUMMARY>ﾍｯﾀﾞ</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overridable Function Execute3_Header() As Boolean
            Return True
        End Function
#End Region

#Region "Valid_Execute3"
        '''========================================================================================
        ''' <SUMMARY>検査(共通)</SUMMARY>
        ''' <RETURNS>True:正常, False:不正</RETURNS>
        '''========================================================================================
        Public Function Valid_Execute3() As NodeContents.ActionButton.ErrorLevel
            Dim ErrLevel As NodeContents.ActionButton.ErrorLevel = NodeContents.ActionButton.ErrorLevel.None
            Dim ErrMsg As String = ""

            '----------------------------------------------------------------------
            ' ﾍｯﾀﾞ部
            '----------------------------------------------------------------------
            Select Case Me.Valid_Execute3_Header_Common()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select

            Select Case Me.Valid_Execute3_Header_Another()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            If ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning Then
                Me.LastError = ErrMsg
            End If
            Return ErrLevel
        End Function

        '''========================================================================================
        ''' <SUMMARY>ﾍｯﾀﾞ(共通)</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overridable Function Valid_Execute3_Header_Common() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function

        '''========================================================================================
        ''' <SUMMARY>ﾍｯﾀﾞ(個別)</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overridable Function Valid_Execute3_Header_Another() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function
#End Region
#End Region

#Region "Execute4"
#Region "Execute4"
        '''========================================================================================
        ''' <SUMMARY>実行</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Public Function Execute4() As Boolean
            '----------------------------------------------------------------------
            ' ﾍｯﾀﾞ部
            '----------------------------------------------------------------------
            If Not Me.Execute4_Header() Then Return False

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return True
        End Function

        '''========================================================================================
        ''' <SUMMARY>ﾍｯﾀﾞ</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overridable Function Execute4_Header() As Boolean
            Return True
        End Function
#End Region

#Region "Valid_Execute4"
        '''========================================================================================
        ''' <SUMMARY>検査(共通)</SUMMARY>
        ''' <RETURNS>True:正常, False:不正</RETURNS>
        '''========================================================================================
        Public Function Valid_Execute4() As NodeContents.ActionButton.ErrorLevel
            Dim ErrLevel As NodeContents.ActionButton.ErrorLevel = NodeContents.ActionButton.ErrorLevel.None
            Dim ErrMsg As String = ""

            '----------------------------------------------------------------------
            ' ﾍｯﾀﾞ部
            '----------------------------------------------------------------------
            Select Case Me.Valid_Execute4_Header_Common()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select

            Select Case Me.Valid_Execute4_Header_Another()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            If ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning Then
                Me.LastError = ErrMsg
            End If
            Return ErrLevel
        End Function

        '''========================================================================================
        ''' <SUMMARY>ﾍｯﾀﾞ(共通)</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overridable Function Valid_Execute4_Header_Common() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function

        '''========================================================================================
        ''' <SUMMARY>ﾍｯﾀﾞ(個別)</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overridable Function Valid_Execute4_Header_Another() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function
#End Region
#End Region

#Region "Execute5"
#Region "Execute5"
        '''========================================================================================
        ''' <SUMMARY>実行</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Public Function Execute5() As Boolean
            '----------------------------------------------------------------------
            ' ﾍｯﾀﾞ部
            '----------------------------------------------------------------------
            If Not Me.Execute5_Header() Then Return False

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return True
        End Function

        '''========================================================================================
        ''' <SUMMARY>ﾍｯﾀﾞ</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overridable Function Execute5_Header() As Boolean
            Return True
        End Function
#End Region

#Region "Valid_Execute5"
        '''========================================================================================
        ''' <SUMMARY>検査(共通)</SUMMARY>
        ''' <RETURNS>True:正常, False:不正</RETURNS>
        '''========================================================================================
        Public Function Valid_Execute5() As NodeContents.ActionButton.ErrorLevel
            Dim ErrLevel As NodeContents.ActionButton.ErrorLevel = NodeContents.ActionButton.ErrorLevel.None
            Dim ErrMsg As String = ""

            '----------------------------------------------------------------------
            ' ﾍｯﾀﾞ部
            '----------------------------------------------------------------------
            Select Case Me.Valid_Execute5_Header_Common()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select

            Select Case Me.Valid_Execute5_Header_Another()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            If ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning Then
                Me.LastError = ErrMsg
            End If
            Return ErrLevel
        End Function

        '''========================================================================================
        ''' <SUMMARY>ﾍｯﾀﾞ(共通)</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overridable Function Valid_Execute5_Header_Common() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function

        '''========================================================================================
        ''' <SUMMARY>ﾍｯﾀﾞ(個別)</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overridable Function Valid_Execute5_Header_Another() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function
#End Region
#End Region

#Region "Empty_Detail"
        '''========================================================================================
        ''' <summary>無効行の判定</summary>
        ''' <param name="Detail">明細行</param>
        ''' <returns>True:無効行, False:有効行</returns>
        '''========================================================================================
        Protected Overridable Function Empty_Detail1(ByVal Detail As Object) As Boolean
            Return True
        End Function

        Protected Overridable Function Empty_Detail2(ByVal Detail As Object) As Boolean
            Return True
        End Function

        Protected Overridable Function Empty_Detail3(ByVal Detail As Object) As Boolean
            Return True
        End Function

        Protected Overridable Function Empty_Detail4(ByVal Detail As Object) As Boolean
            Return True
        End Function

        Protected Overridable Function Empty_Detail5(ByVal Detail As Object) As Boolean
            Return True
        End Function
#End Region

#Region "Insert_Detail"
        '''========================================================================================
        ''' <summary>単一行挿入</summary>
        ''' <param name="Position">挿入位置</param>
        '''========================================================================================
        Public Overridable Sub Insert_Detail1(ByVal Position As Integer)
        End Sub

        Public Overridable Sub Insert_Detail2(ByVal Position As Integer)
        End Sub

        Public Overridable Sub Insert_Detail3(ByVal Position As Integer)
        End Sub

        Public Overridable Sub Insert_Detail4(ByVal Position As Integer)
        End Sub

        Public Overridable Sub Insert_Detail5(ByVal Position As Integer)
        End Sub

        '''========================================================================================
        ''' <summary>一括行挿入</summary>
        ''' <param name="Position">挿入位置</param>
        ''' <param name="Count">挿入行数</param>
        '''========================================================================================
        Public Overridable Sub Insert_Detail1(ByVal Position As Integer, ByVal Count As Integer)
        End Sub

        Public Overridable Sub Insert_Detail2(ByVal Position As Integer, ByVal Count As Integer)
        End Sub

        Public Overridable Sub Insert_Detail3(ByVal Position As Integer, ByVal Count As Integer)
        End Sub

        Public Overridable Sub Insert_Detail4(ByVal Position As Integer, ByVal Count As Integer)
        End Sub

        Public Overridable Sub Insert_Detail5(ByVal Position As Integer, ByVal Count As Integer)
        End Sub
#End Region

#Region "Copy_Detail"
        '''========================================================================================
        ''' <summary>単一行複写</summary>
        ''' <param name="Position">挿入位置</param>
        '''========================================================================================
        Public Overridable Sub Copy_Detail1(ByVal Position As Integer)
        End Sub

        Public Overridable Sub Copy_Detail2(ByVal Position As Integer)
        End Sub

        Public Overridable Sub Copy_Detail3(ByVal Position As Integer)
        End Sub

        Public Overridable Sub Copy_Detail4(ByVal Position As Integer)
        End Sub

        Public Overridable Sub Copy_Detail5(ByVal Position As Integer)
        End Sub
#End Region

#Region "Add_Detail"
        '''========================================================================================
        ''' <summary>単一行追加</summary>
        '''========================================================================================
        Public Overridable Sub Add_Detail1()
        End Sub

        Public Overridable Sub Add_Detail2()
        End Sub

        Public Overridable Sub Add_Detail3()
        End Sub

        Public Overridable Sub Add_Detail4()
        End Sub

        Public Overridable Sub Add_Detail5()
        End Sub

        '''========================================================================================
        ''' <summary>一括行追加</summary>
        ''' <param name="AddCount">追加行数</param>
        '''========================================================================================
        Public Overridable Sub Add_Detail1(ByVal AddCount As Integer, Optional Clear As Boolean = True)
        End Sub

        Public Overridable Sub Add_Detail2(ByVal AddCount As Integer, Optional Clear As Boolean = True)
        End Sub

        Public Overridable Sub Add_Detail3(ByVal AddCount As Integer, Optional Clear As Boolean = True)
        End Sub

        Public Overridable Sub Add_Detail4(ByVal AddCount As Integer, Optional Clear As Boolean = True)
        End Sub

        Public Overridable Sub Add_Detail5(ByVal AddCount As Integer, Optional Clear As Boolean = True)
        End Sub
#End Region

#Region "Del_Detail"
        '''========================================================================================
        ''' <summary>一括行削除</summary>
        '''========================================================================================
        Public Overridable Sub Del_Detail1()
        End Sub

        Public Overridable Sub Del_Detail2()
        End Sub

        Public Overridable Sub Del_Detail3()
        End Sub

        Public Overridable Sub Del_Detail4()
        End Sub

        Public Overridable Sub Del_Detail5()
        End Sub

        '''========================================================================================
        ''' <summary>単一行削除</summary>
        ''' <param name="Position">削除行数</param>
        '''========================================================================================
        Public Overridable Sub Del_Detail1(ByVal Position As Integer)
        End Sub

        Public Overridable Sub Del_Detail2(ByVal Position As Integer)
        End Sub

        Public Overridable Sub Del_Detail3(ByVal Position As Integer)
        End Sub

        Public Overridable Sub Del_Detail4(ByVal Position As Integer)
        End Sub

        Public Overridable Sub Del_Detail5(ByVal Position As Integer)
        End Sub
#End Region

#Region "ReNum_Detail"
        '''========================================================================================
        ''' <summary>行番号の再付番</summary>
        '''========================================================================================
        Public Overridable Sub ReNum_Detail1()
        End Sub

        Public Overridable Sub ReNum_Detail2()
        End Sub

        Public Overridable Sub ReNum_Detail3()
        End Sub

        Public Overridable Sub ReNum_Detail4()
        End Sub

        Public Overridable Sub ReNum_Detail5()
        End Sub
#End Region

#Region "DatabaseToFrame"
        '''========================================================================================
        ''' <summary>ﾃﾞｰﾀﾃｰﾌﾞﾙからﾌｨｰﾙﾄﾞﾃﾞｰﾀに値を設定する</summary>
        '''========================================================================================
        Public Overridable Sub CopyDatabaseToFrame1()
        End Sub

        Public Overridable Sub CopyDatabaseToFrame2()
        End Sub

        Public Overridable Sub CopyDatabaseToFrame3()
        End Sub

        Public Overridable Sub CopyDatabaseToFrame4()
        End Sub

        Public Overridable Sub CopyDatabaseToFrame5()
        End Sub
#End Region

#Region "Valid_RowAdd"
        '''========================================================================================
        ''' <SUMMARY>検査(共通)</SUMMARY>
        ''' <RETURNS>True:正常, False:不正</RETURNS>
        '''========================================================================================
        Public Function Valid_RowAdd() As NodeContents.ActionButton.ErrorLevel
            Dim ErrLevel As NodeContents.ActionButton.ErrorLevel = NodeContents.ActionButton.ErrorLevel.None
            Dim ErrMsg As String = ""

            '----------------------------------------------------------------------
            ' ﾍｯﾀﾞ部
            '----------------------------------------------------------------------
            Select Case Me.Valid_RowAdd_Header_Common()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select

            Select Case Me.Valid_RowAdd_Header_Another()
                Case NodeContents.ActionButton.ErrorLevel.None
                Case NodeContents.ActionButton.ErrorLevel.Warning
                    ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning
                    ErrMsg = Me.LastError
                Case NodeContents.ActionButton.ErrorLevel.Fatal
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            If ErrLevel = NodeContents.ActionButton.ErrorLevel.Warning Then
                Me.LastError = ErrMsg
            End If
            Return ErrLevel
        End Function

        '''========================================================================================
        ''' <SUMMARY>ﾍｯﾀﾞ(共通)</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overridable Function Valid_RowAdd_Header_Common() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function

        '''========================================================================================
        ''' <SUMMARY>ﾍｯﾀﾞ(個別)</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overridable Function Valid_RowAdd_Header_Another() As NodeContents.ActionButton.ErrorLevel
            Return NodeContents.ActionButton.ErrorLevel.None
        End Function
#End Region

#Region "ReportAddRange"
        '''========================================================================================
        ''' <SUMMARY>ﾚﾎﾟｰﾄ結合</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Function ReportAddRange(ByRef LastError As String, ByRef ReportBase As DataDynamics.ActiveReports.ActiveReport, ByRef ReportCurrent As DataDynamics.ActiveReports.ActiveReport) As Boolean
            '----------------------------------------------------------------------
            ' ﾚﾎﾟｰﾄ結合
            '----------------------------------------------------------------------
            Try
                If Not ReportCurrent Is Nothing Then
                    If ReportBase Is Nothing Then
                        ReportBase = ReportCurrent
                    Else
                        ReportBase.Document.Pages.AddRange(ReportCurrent.Document.Pages)
                    End If
                End If

            Catch ex As Exception
                LastError = "以下のエラーのため、実行できませんでした。" & vbCrLf & ex.Message
                Return False
            End Try

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return True
        End Function
#End Region
    End Class
End Namespace
