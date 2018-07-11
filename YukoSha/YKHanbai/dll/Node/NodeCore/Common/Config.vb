Namespace Common
    Public Class Config

#Region "ﾌﾟﾛﾊﾟﾃｨ"
        '''========================================================================================
        ''' <summary>消費税率変更前</summary>
        '''========================================================================================
        Private _消費税率変更前 As Decimal
        Public ReadOnly Property 消費税率変更前() As Decimal
            Get
                Return _消費税率変更前
            End Get
        End Property

        '''========================================================================================
        ''' <summary>消費税率変更後</summary>
        '''========================================================================================
        Private _消費税率変更後 As Decimal
        Public ReadOnly Property 消費税率変更後() As Decimal
            Get
                Return _消費税率変更後
            End Get
        End Property

        '''========================================================================================
        ''' <summary>消費税率変更日</summary>
        '''========================================================================================
        Private _消費税率変更日 As String
        Public ReadOnly Property 消費税率変更日() As String
            Get
                Return _消費税率変更日
            End Get
        End Property
#End Region

#Region "ｺﾝｽﾄﾗｸﾀ"
        '''========================================================================================
        ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
        '''========================================================================================
        Public Sub New()
            '----------------------------------------------------------------------
            ' S設定
            '----------------------------------------------------------------------
            Dim ada As New NodeDatabase.DataSetSystemTableAdapters.SシステムTableAdapter
            Dim tbl As New NodeDatabase.DataSetSystem.SシステムDataTable
            Dim qry As New Collection

            ' 読込
            tbl = ada.SelectByCommon(qry)
            If tbl.Count > 0 Then
                _消費税率変更前 = BaseCore.Common.Text.Nz(tbl(0).Item(tbl.消費税率変更前Column.ColumnName), 0)
                _消費税率変更後 = BaseCore.Common.Text.Nz(tbl(0).Item(tbl.消費税率変更後Column.ColumnName), 0)
                _消費税率変更日 = BaseCore.Common.Text.Nz(tbl(0).Item(tbl.消費税率変更日Column.ColumnName), "")
            End If
        End Sub
#End Region
    End Class
End Namespace
