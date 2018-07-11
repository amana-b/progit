Namespace Frame.Order
    Partial Public Class FlexBlade
        Inherits NodeCore.Common.Frame

#Region "ﾌｨｰﾙﾄﾞ定義"
        Public Class Header
            ''' ----------------------------------------------------------------------------------------
            ''' <SUMMARY>列項目(基本)</SUMMARY>
            ''' ----------------------------------------------------------------------------------------
            Public 作業NO As BaseCore.Common.Field.ItemData
            Public 本台帳NO As BaseCore.Common.Field.ItemData
            Public 機番 As BaseCore.Common.Field.ItemData
            Public 刃型区分 As BaseCore.Common.Field.ItemData
            Public 顧客刃型番号 As BaseCore.Common.Field.ItemData
            Public 担当者CD As BaseCore.Common.Field.ItemData
            Public 担当者名 As BaseCore.Common.Field.ItemData
            Public 原価 As BaseCore.Common.Field.ItemData
            Public 刃型サイズ一面紙幅方向 As BaseCore.Common.Field.ItemData
            Public 刃型サイズ一面流れ方向 As BaseCore.Common.Field.ItemData
            Public 刃型サイズ一面角 As BaseCore.Common.Field.ItemData
            Public 刃型サイズ一面形状区分 As BaseCore.Common.Field.ItemData
            Public 刃型情報ギヤ数 As BaseCore.Common.Field.ItemData
            Public 刃型情報板厚 As BaseCore.Common.Field.ItemData
            Public 刃型情報総円周 As BaseCore.Common.Field.ItemData
            Public 刃型情報バリヤ As BaseCore.Common.Field.ItemData
            Public 面付紙幅方向面数 As BaseCore.Common.Field.ItemData
            Public 面付紙幅方向ドブ寸法 As BaseCore.Common.Field.ItemData
            Public 面付流れ方向面数 As BaseCore.Common.Field.ItemData
            Public 面付流れ方向ドブ寸法 As BaseCore.Common.Field.ItemData
            Public 刃型サイズ全体紙幅方向 As BaseCore.Common.Field.ItemData
            Public 刃型サイズ全体流れ方向 As BaseCore.Common.Field.ItemData
            Public 線幅刃型線 As BaseCore.Common.Field.ItemData
            Public 線幅原点 As BaseCore.Common.Field.ItemData
            Public 線幅トンボ As BaseCore.Common.Field.ItemData
            Public バリヤ表区分 As BaseCore.Common.Field.ItemData
            Public バリヤ表区分名 As BaseCore.Common.Field.ItemData
            Public 台紙CD As BaseCore.Common.Field.ItemData
            Public 台紙名 As BaseCore.Common.Field.ItemData
            Public フレキ機械種別区分 As BaseCore.Common.Field.ItemData
            Public 計上先作業NO As BaseCore.Common.Field.ItemData
            Public 仕入先CD As BaseCore.Common.Field.ItemData
            Public 仕入先名 As BaseCore.Common.Field.ItemData

            Public 社内外区分 As BaseCore.Common.Field.ItemData
            Public 御客様NO As BaseCore.Common.Field.ItemData
            Public 受注日付 As BaseCore.Common.Field.ItemData
            Public 納品日付B As BaseCore.Common.Field.ItemData
            Public 確約区分 As BaseCore.Common.Field.ItemData
            Public 得意先CD As BaseCore.Common.Field.ItemData
            Public 得意先名 As BaseCore.Common.Field.ItemData
            Public 請求先CD As BaseCore.Common.Field.ItemData
            Public 請求先名 As BaseCore.Common.Field.ItemData
            Public 代表商品名 As BaseCore.Common.Field.ItemData
            Public 受注数合計 As BaseCore.Common.Field.ItemData
            Public 受注単価 As BaseCore.Common.Field.ItemData
            Public 受注金額 As BaseCore.Common.Field.ItemData

            Public 注意事項01 As BaseCore.Common.Field.ItemData
            Public 注意事項02 As BaseCore.Common.Field.ItemData
            Public 注意事項03 As BaseCore.Common.Field.ItemData
            Public 注意事項04 As BaseCore.Common.Field.ItemData
            Public 注意事項05 As BaseCore.Common.Field.ItemData

            Public 出荷先CD01 As BaseCore.Common.Field.ItemData
            Public 出荷先名01 As BaseCore.Common.Field.ItemData
            Public 出荷先CD02 As BaseCore.Common.Field.ItemData
            Public 出荷先名02 As BaseCore.Common.Field.ItemData
            Public 出荷先CD03 As BaseCore.Common.Field.ItemData
            Public 出荷先名03 As BaseCore.Common.Field.ItemData
            Public 出荷先CD04 As BaseCore.Common.Field.ItemData
            Public 出荷先名04 As BaseCore.Common.Field.ItemData

            Public 処理登録 As BaseCore.Common.Field.ItemData
            Public 処理修正 As BaseCore.Common.Field.ItemData
            Public 処理削除 As BaseCore.Common.Field.ItemData

            '''========================================================================================
            ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
            '''========================================================================================
            Public Sub New(ByVal Config As NodeCore.Common.Config)
                Dim tblフレ As New NodeDatabase.DataSetView.V0フレキDataTable
                Dim tbl基本 As New NodeDatabase.DataSetView.V0受注基本DataTable
                Dim tbl注意 As New NodeDatabase.DataSetView.V0受注作業注意DataTable
                Dim tbl出荷 As New NodeDatabase.DataSetView.V0受注出荷先DataTable

                '----------------------------------------------------------------------
                ' ｲﾝｽﾀﾝｽ(基本)
                '----------------------------------------------------------------------
                Me.作業NO = New BaseCore.Common.Field.ItemData(tblフレ.作業NOColumn)
                Me.本台帳NO = New BaseCore.Common.Field.ItemData(tblフレ.本台帳NOColumn)
                Me.機番 = New BaseCore.Common.Field.ItemData(tblフレ.機番Column)
                Me.刃型区分 = New BaseCore.Common.Field.ItemData(tblフレ.刃型区分Column)
                Me.顧客刃型番号 = New BaseCore.Common.Field.ItemData(tblフレ.顧客刃型番号Column)
                Me.担当者CD = New BaseCore.Common.Field.ItemData(tblフレ.担当者CDColumn)
                Me.担当者名 = New BaseCore.Common.Field.ItemData(tblフレ.担当者名Column)
                Me.原価 = New BaseCore.Common.Field.ItemData(tblフレ.原価Column, 9, 0)
                Me.刃型サイズ一面紙幅方向 = New BaseCore.Common.Field.ItemData(tblフレ.刃型サイズ一面紙幅方向Column, 3, 2)
                Me.刃型サイズ一面流れ方向 = New BaseCore.Common.Field.ItemData(tblフレ.刃型サイズ一面流れ方向Column, 3, 2)
                Me.刃型サイズ一面角 = New BaseCore.Common.Field.ItemData(tblフレ.刃型サイズ一面角Column, 2, 1)
                Me.刃型サイズ一面形状区分 = New BaseCore.Common.Field.ItemData(tblフレ.刃型サイズ一面形状区分Column)
                Me.刃型情報ギヤ数 = New BaseCore.Common.Field.ItemData(tblフレ.刃型情報ギヤ数Column, 3, 0)
                Me.刃型情報板厚 = New BaseCore.Common.Field.ItemData(tblフレ.刃型情報板厚Column, 2, 3)
                Me.刃型情報総円周 = New BaseCore.Common.Field.ItemData(tblフレ.刃型情報総円周Column, 5, 3)
                Me.刃型情報バリヤ = New BaseCore.Common.Field.ItemData(tblフレ.刃型情報バリヤColumn, 3, 2)
                Me.面付紙幅方向面数 = New BaseCore.Common.Field.ItemData(tblフレ.面付紙幅方向面数Column, 2, 0)
                Me.面付紙幅方向ドブ寸法 = New BaseCore.Common.Field.ItemData(tblフレ.面付紙幅方向ドブ寸法Column, 3, 3)
                Me.面付流れ方向面数 = New BaseCore.Common.Field.ItemData(tblフレ.面付流れ方向面数Column, 2, 0)
                Me.面付流れ方向ドブ寸法 = New BaseCore.Common.Field.ItemData(tblフレ.面付流れ方向ドブ寸法Column, 3, 3)
                Me.刃型サイズ全体紙幅方向 = New BaseCore.Common.Field.ItemData(tblフレ.刃型サイズ全体紙幅方向Column, 4, 3)
                Me.刃型サイズ全体流れ方向 = New BaseCore.Common.Field.ItemData(tblフレ.刃型サイズ全体流れ方向Column, 4, 3)
                Me.線幅刃型線 = New BaseCore.Common.Field.ItemData(tblフレ.線幅刃型線Column, 2, 2)
                Me.線幅原点 = New BaseCore.Common.Field.ItemData(tblフレ.線幅原点Column, 2, 2)
                Me.線幅トンボ = New BaseCore.Common.Field.ItemData(tblフレ.線幅トンボColumn, 2, 2)
                Me.バリヤ表区分 = New BaseCore.Common.Field.ItemData(tblフレ.バリヤ表区分Column)
                Me.バリヤ表区分名 = New BaseCore.Common.Field.ItemData(tblフレ.バリヤ表区分名Column)
                Me.台紙CD = New BaseCore.Common.Field.ItemData(tblフレ.台紙CDColumn)
                Me.台紙名 = New BaseCore.Common.Field.ItemData(tblフレ.台紙名Column)
                Me.フレキ機械種別区分 = New BaseCore.Common.Field.ItemData(tblフレ.フレキ機械種別区分Column)
                Me.計上先作業NO = New BaseCore.Common.Field.ItemData(tblフレ.計上先作業NOColumn)
                Me.仕入先CD = New BaseCore.Common.Field.ItemData(tblフレ.仕入先CDColumn)
                Me.仕入先名 = New BaseCore.Common.Field.ItemData(tblフレ.仕入先名Column)

                Me.社内外区分 = New BaseCore.Common.Field.ItemData(tbl基本.社内外区分Column)
                Me.御客様NO = New BaseCore.Common.Field.ItemData(tbl基本.御客様NOColumn)
                Me.受注日付 = New BaseCore.Common.Field.ItemData(tbl基本.受注日付Column)
                Me.納品日付B = New BaseCore.Common.Field.ItemData(tbl基本.納品日付BColumn)
                Me.確約区分 = New BaseCore.Common.Field.ItemData(tbl基本.確約区分Column)
                Me.得意先CD = New BaseCore.Common.Field.ItemData(tbl基本.得意先CDColumn)
                Me.得意先名 = New BaseCore.Common.Field.ItemData(tbl基本.得意先名Column)
                Me.請求先CD = New BaseCore.Common.Field.ItemData(tbl基本.請求先CDColumn)
                Me.請求先名 = New BaseCore.Common.Field.ItemData(tbl基本.請求先名Column)
                Me.代表商品名 = New BaseCore.Common.Field.ItemData(tbl基本.代表商品名Column)
                Me.受注数合計 = New BaseCore.Common.Field.ItemData(tbl基本.受注数合計Column, 9, 0)
                Me.受注単価 = New BaseCore.Common.Field.ItemData(tbl基本.受注単価Column, 7, 2)
                Me.受注金額 = New BaseCore.Common.Field.ItemData(tbl基本.受注金額Column, 9, 0)

                Me.注意事項01 = New BaseCore.Common.Field.ItemData(tbl注意.注意事項Column)
                Me.注意事項02 = New BaseCore.Common.Field.ItemData(tbl注意.注意事項Column)
                Me.注意事項03 = New BaseCore.Common.Field.ItemData(tbl注意.注意事項Column)
                Me.注意事項04 = New BaseCore.Common.Field.ItemData(tbl注意.注意事項Column)
                Me.注意事項05 = New BaseCore.Common.Field.ItemData(tbl注意.注意事項Column)

                Me.出荷先CD01 = New BaseCore.Common.Field.ItemData(tbl出荷.出荷先CDColumn)
                Me.出荷先名01 = New BaseCore.Common.Field.ItemData(tbl出荷.出荷先名Column)
                Me.出荷先CD02 = New BaseCore.Common.Field.ItemData(tbl出荷.出荷先CDColumn)
                Me.出荷先名02 = New BaseCore.Common.Field.ItemData(tbl出荷.出荷先名Column)
                Me.出荷先CD03 = New BaseCore.Common.Field.ItemData(tbl出荷.出荷先CDColumn)
                Me.出荷先名03 = New BaseCore.Common.Field.ItemData(tbl出荷.出荷先名Column)
                Me.出荷先CD04 = New BaseCore.Common.Field.ItemData(tbl出荷.出荷先CDColumn)
                Me.出荷先名04 = New BaseCore.Common.Field.ItemData(tbl出荷.出荷先名Column)

                Me.処理登録 = New BaseCore.Common.Field.ItemData("処理登録", TypeCode.String, 1)
                Me.処理修正 = New BaseCore.Common.Field.ItemData("処理修正", TypeCode.String, 1)
                Me.処理削除 = New BaseCore.Common.Field.ItemData("処理削除", TypeCode.String, 1)
            End Sub
        End Class

        Public Class Paramater
            Public Header As Header
        End Class

        '''========================================================================================
        ''' <summary>ﾍｯﾀﾞ</summary>
        '''========================================================================================
        Private _Fields As New Paramater
        Public Property Fields() As Paramater
            Get
                Return _Fields
            End Get

            Set(ByVal value As Paramater)
                _Fields = value
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
            '----------------------------------------------------------------------
            ' ｾｷｭﾘﾃｨ 設定
            '----------------------------------------------------------------------
            MyBase.New(Security, Config)

            Me.Fields.Header = New Header(Config)
        End Sub
#End Region

#Region "Clear"
        '''========================================================================================
        ''' <SUMMARY>ｸﾘｱ</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overrides Function Clear_Header(Optional ByVal KeyClear As Boolean = True) As Boolean
            '----------------------------------------------------------------------
            ' ｷｰ部ｸﾘｱ
            '----------------------------------------------------------------------
            If KeyClear Then
                Me.Fields.Header.処理登録.Value = NodeContents.Constant.CodeValue.フラグ.オン
                Me.Fields.Header.処理修正.Value = NodeContents.Constant.CodeValue.フラグ.オフ
                Me.Fields.Header.処理削除.Value = NodeContents.Constant.CodeValue.フラグ.オフ

                Me.Fields.Header.社内外区分.Value = NodeContents.Constant.CodeValue.社内外区分.社内
                Me.Fields.Header.作業NO.Value = Nothing
            End If

            '----------------------------------------------------------------------
            ' ﾃﾞｰﾀ部ｸﾘｱ
            '----------------------------------------------------------------------
            Me.Fields.Header.本台帳NO.Value = Nothing
            Me.Fields.Header.機番.Value = Nothing
            Me.Fields.Header.刃型区分.Value = NodeContents.Constant.CodeValue.刃型区分.彫刻刃
            Me.Fields.Header.顧客刃型番号.Value = Nothing
            Me.Fields.Header.担当者CD.Value = Nothing
            Me.Fields.Header.担当者名.Value = Nothing
            Me.Fields.Header.原価.Value = Nothing
            Me.Fields.Header.刃型サイズ一面紙幅方向.Value = Nothing
            Me.Fields.Header.刃型サイズ一面流れ方向.Value = Nothing
            Me.Fields.Header.刃型サイズ一面角.Value = Nothing
            Me.Fields.Header.刃型サイズ一面形状区分.Value = NodeContents.Constant.CodeValue.刃型形状区分.長方形
            Me.Fields.Header.刃型情報ギヤ数.Value = Nothing
            Me.Fields.Header.刃型情報板厚.Value = Nothing
            Me.Fields.Header.刃型情報総円周.Value = Nothing
            Me.Fields.Header.刃型情報バリヤ.Value = Nothing
            Me.Fields.Header.面付紙幅方向面数.Value = Nothing
            Me.Fields.Header.面付紙幅方向ドブ寸法.Value = Nothing
            Me.Fields.Header.面付流れ方向面数.Value = Nothing
            Me.Fields.Header.面付流れ方向ドブ寸法.Value = Nothing
            Me.Fields.Header.刃型サイズ全体紙幅方向.Value = Nothing
            Me.Fields.Header.刃型サイズ全体流れ方向.Value = Nothing
            Me.Fields.Header.線幅刃型線.Value = Nothing
            Me.Fields.Header.線幅原点.Value = Nothing
            Me.Fields.Header.線幅トンボ.Value = Nothing
            Me.Fields.Header.バリヤ表区分.Value = Nothing
            Me.Fields.Header.バリヤ表区分名.Value = Nothing
            Me.Fields.Header.台紙CD.Value = Nothing
            Me.Fields.Header.台紙名.Value = Nothing
            Me.Fields.Header.フレキ機械種別区分.Value = NodeContents.Constant.CodeValue.フレキ機械種別区分.輪転機
            Me.Fields.Header.計上先作業NO.Value = Nothing
            Me.Fields.Header.仕入先CD.Value = Nothing
            Me.Fields.Header.仕入先名.Value = Nothing

            Me.Fields.Header.御客様NO.Value = Nothing
            Me.Fields.Header.受注日付.Value = Nothing
            Me.Fields.Header.納品日付B.Value = Nothing
            Me.Fields.Header.確約区分.Value = NodeContents.Constant.CodeValue.確約区分.通常
            Me.Fields.Header.得意先CD.Value = Nothing
            Me.Fields.Header.得意先名.Value = Nothing
            Me.Fields.Header.請求先CD.Value = Nothing
            Me.Fields.Header.請求先名.Value = Nothing
            Me.Fields.Header.代表商品名.Value = Nothing
            Me.Fields.Header.受注数合計.Value = Nothing
            Me.Fields.Header.受注単価.Value = Nothing
            Me.Fields.Header.受注金額.Value = Nothing

            Me.Fields.Header.注意事項01.Value = Nothing
            Me.Fields.Header.注意事項02.Value = Nothing
            Me.Fields.Header.注意事項03.Value = Nothing
            Me.Fields.Header.注意事項04.Value = Nothing
            Me.Fields.Header.注意事項05.Value = Nothing

            Me.Fields.Header.出荷先CD01.Value = Nothing
            Me.Fields.Header.出荷先名01.Value = Nothing
            Me.Fields.Header.出荷先CD02.Value = Nothing
            Me.Fields.Header.出荷先名02.Value = Nothing
            Me.Fields.Header.出荷先CD03.Value = Nothing
            Me.Fields.Header.出荷先名03.Value = Nothing
            Me.Fields.Header.出荷先CD04.Value = Nothing
            Me.Fields.Header.出荷先名04.Value = Nothing

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return True
        End Function
#End Region

#Region "Read"
        '''========================================================================================
        ''' <SUMMARY>読込</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overrides Function Read_Header() As Boolean
            '----------------------------------------------------------------------
            ' ｸﾘｱ
            '----------------------------------------------------------------------
            Me.Clear(False)

            '----------------------------------------------------------------------
            ' Tフレキ
            '----------------------------------------------------------------------
            Dim adaフレ As New NodeDatabase.DataSetViewTableAdapters.V0フレキTableAdapter
            Dim tblフレ As New NodeDatabase.DataSetView.V0フレキDataTable
            Dim qryフレ As New Collection

            qryフレ.Clear()
            qryフレ.Add(New BaseDatabase.Condition(tblフレ.作業NOColumn.ColumnName, Me.Fields.Header.作業NO.Value, BaseDatabase.Contents.Compare.Equal))
            tblフレ = adaフレ.SelectByCommon(qryフレ)
            If tblフレ.Count > 0 Then
                Me.Fields.Header.作業NO.Value = tblフレ(0).Item(tblフレ.作業NOColumn.ColumnName)
                Me.Fields.Header.本台帳NO.Value = tblフレ(0).Item(tblフレ.本台帳NOColumn.ColumnName)
                Me.Fields.Header.機番.Value = tblフレ(0).Item(tblフレ.機番Column.ColumnName)
                Me.Fields.Header.刃型区分.Value = tblフレ(0).Item(tblフレ.刃型区分Column.ColumnName)
                Me.Fields.Header.顧客刃型番号.Value = tblフレ(0).Item(tblフレ.顧客刃型番号Column.ColumnName)
                Me.Fields.Header.担当者CD.Value = tblフレ(0).Item(tblフレ.担当者CDColumn.ColumnName)
                Me.Fields.Header.担当者名.Value = tblフレ(0).Item(tblフレ.担当者名Column.ColumnName)
                Me.Fields.Header.原価.Value = tblフレ(0).Item(tblフレ.原価Column.ColumnName)
                Me.Fields.Header.刃型サイズ一面紙幅方向.Value = tblフレ(0).Item(tblフレ.刃型サイズ一面紙幅方向Column.ColumnName)
                Me.Fields.Header.刃型サイズ一面流れ方向.Value = tblフレ(0).Item(tblフレ.刃型サイズ一面流れ方向Column.ColumnName)
                Me.Fields.Header.刃型サイズ一面角.Value = tblフレ(0).Item(tblフレ.刃型サイズ一面角Column.ColumnName)
                Me.Fields.Header.刃型サイズ一面形状区分.Value = tblフレ(0).Item(tblフレ.刃型サイズ一面形状区分Column.ColumnName)
                Me.Fields.Header.刃型情報ギヤ数.Value = tblフレ(0).Item(tblフレ.刃型情報ギヤ数Column.ColumnName)
                Me.Fields.Header.刃型情報板厚.Value = tblフレ(0).Item(tblフレ.刃型情報板厚Column.ColumnName)
                Me.Fields.Header.刃型情報総円周.Value = tblフレ(0).Item(tblフレ.刃型情報総円周Column.ColumnName)
                Me.Fields.Header.刃型情報バリヤ.Value = tblフレ(0).Item(tblフレ.刃型情報バリヤColumn.ColumnName)
                Me.Fields.Header.面付紙幅方向面数.Value = tblフレ(0).Item(tblフレ.面付紙幅方向面数Column.ColumnName)
                Me.Fields.Header.面付紙幅方向ドブ寸法.Value = tblフレ(0).Item(tblフレ.面付紙幅方向ドブ寸法Column.ColumnName)
                Me.Fields.Header.面付流れ方向面数.Value = tblフレ(0).Item(tblフレ.面付流れ方向面数Column.ColumnName)
                Me.Fields.Header.面付流れ方向ドブ寸法.Value = tblフレ(0).Item(tblフレ.面付流れ方向ドブ寸法Column.ColumnName)
                Me.Fields.Header.刃型サイズ全体紙幅方向.Value = tblフレ(0).Item(tblフレ.刃型サイズ全体紙幅方向Column.ColumnName)
                Me.Fields.Header.刃型サイズ全体流れ方向.Value = tblフレ(0).Item(tblフレ.刃型サイズ全体流れ方向Column.ColumnName)
                Me.Fields.Header.線幅刃型線.Value = tblフレ(0).Item(tblフレ.線幅刃型線Column.ColumnName)
                Me.Fields.Header.線幅原点.Value = tblフレ(0).Item(tblフレ.線幅原点Column.ColumnName)
                Me.Fields.Header.線幅トンボ.Value = tblフレ(0).Item(tblフレ.線幅トンボColumn.ColumnName)
                Me.Fields.Header.バリヤ表区分.Value = tblフレ(0).Item(tblフレ.バリヤ表区分Column.ColumnName)
                Me.Fields.Header.バリヤ表区分名.Value = tblフレ(0).Item(tblフレ.バリヤ表区分名Column.ColumnName)
                Me.Fields.Header.台紙CD.Value = tblフレ(0).Item(tblフレ.台紙CDColumn.ColumnName)
                Me.Fields.Header.台紙名.Value = tblフレ(0).Item(tblフレ.台紙名Column.ColumnName)
                Me.Fields.Header.フレキ機械種別区分.Value = tblフレ(0).Item(tblフレ.フレキ機械種別区分Column.ColumnName)
                Me.Fields.Header.計上先作業NO.Value = tblフレ(0).Item(tblフレ.計上先作業NOColumn.ColumnName)
                Me.Fields.Header.仕入先CD.Value = tblフレ(0).Item(tblフレ.仕入先CDColumn.ColumnName)
                Me.Fields.Header.仕入先名.Value = tblフレ(0).Item(tblフレ.仕入先名Column.ColumnName)
            End If

            '----------------------------------------------------------------------
            ' T受注基本
            '----------------------------------------------------------------------
            Dim ada基本 As New NodeDatabase.DataSetViewTableAdapters.V0受注基本TableAdapter
            Dim tbl基本 As New NodeDatabase.DataSetView.V0受注基本DataTable
            Dim qry基本 As New Collection

            qry基本.Clear()
            qry基本.Add(New BaseDatabase.Condition(tbl基本.作業NOColumn.ColumnName, Me.Fields.Header.作業NO.Value, BaseDatabase.Contents.Compare.Equal))
            tbl基本 = ada基本.SelectByCommon(qry基本)
            If tbl基本.Count > 0 Then
                Me.Fields.Header.社内外区分.Value = tbl基本(0).Item(tbl基本.社内外区分Column.ColumnName)
                Me.Fields.Header.御客様NO.Value = tbl基本(0).Item(tbl基本.御客様NOColumn.ColumnName)
                Me.Fields.Header.受注日付.Value = tbl基本(0).Item(tbl基本.受注日付Column.ColumnName)
                Me.Fields.Header.納品日付B.Value = tbl基本(0).Item(tbl基本.納品日付BColumn.ColumnName)
                Me.Fields.Header.確約区分.Value = tbl基本(0).Item(tbl基本.確約区分Column.ColumnName)
                Me.Fields.Header.得意先CD.Value = tbl基本(0).Item(tbl基本.得意先CDColumn.ColumnName)
                Me.Fields.Header.得意先名.Value = tbl基本(0).Item(tbl基本.得意先名Column.ColumnName)
                Me.Fields.Header.請求先CD.Value = tbl基本(0).Item(tbl基本.請求先CDColumn.ColumnName)
                Me.Fields.Header.請求先名.Value = tbl基本(0).Item(tbl基本.請求先名Column.ColumnName)
                Me.Fields.Header.代表商品名.Value = tbl基本(0).Item(tbl基本.代表商品名Column.ColumnName)
                Me.Fields.Header.受注数合計.Value = tbl基本(0).Item(tbl基本.受注数合計Column.ColumnName)
                Me.Fields.Header.受注単価.Value = tbl基本(0).Item(tbl基本.受注単価Column.ColumnName)
                Me.Fields.Header.受注金額.Value = tbl基本(0).Item(tbl基本.受注金額Column.ColumnName)
            End If

            '----------------------------------------------------------------------
            ' T受注作業注意
            '----------------------------------------------------------------------
            Dim ada注意 As New NodeDatabase.DataSetViewTableAdapters.V0受注作業注意TableAdapter
            Dim tbl注意 As New NodeDatabase.DataSetView.V0受注作業注意DataTable
            Dim qry注意 As New Collection

            qry注意.Clear()
            qry注意.Add(New BaseDatabase.Condition(tbl注意.作業NOColumn.ColumnName, Me.Fields.Header.作業NO.Value, BaseDatabase.Contents.Compare.Equal))
            tbl注意 = ada注意.SelectByCommon(qry注意)
            For Each row As DataRow In tbl注意.Rows
                Select Case row.Item(tbl注意.行NOColumn)
                    Case 1 : Me.Fields.Header.注意事項01.Value = row.Item(tbl注意.注意事項Column.ColumnName)
                    Case 2 : Me.Fields.Header.注意事項02.Value = row.Item(tbl注意.注意事項Column.ColumnName)
                    Case 3 : Me.Fields.Header.注意事項03.Value = row.Item(tbl注意.注意事項Column.ColumnName)
                    Case 4 : Me.Fields.Header.注意事項04.Value = row.Item(tbl注意.注意事項Column.ColumnName)
                    Case 5 : Me.Fields.Header.注意事項05.Value = row.Item(tbl注意.注意事項Column.ColumnName)
                End Select
            Next

            '----------------------------------------------------------------------
            ' T受注出荷先
            '----------------------------------------------------------------------
            Dim ada出荷 As New NodeDatabase.DataSetViewTableAdapters.V0受注出荷先TableAdapter
            Dim tbl出荷 As New NodeDatabase.DataSetView.V0受注出荷先DataTable
            Dim qry出荷 As New Collection

            qry出荷.Clear()
            qry出荷.Add(New BaseDatabase.Condition(tbl出荷.作業NOColumn.ColumnName, Me.Fields.Header.作業NO.Value, BaseDatabase.Contents.Compare.Equal))
            tbl出荷 = ada出荷.SelectByCommon(qry出荷, tbl出荷.行NOColumn.ColumnName)
            For Each row As DataRow In tbl出荷.Rows
                Select Case row.Item(tbl出荷.行NOColumn)
                    Case 1
                        Me.Fields.Header.出荷先CD01.Value = row.Item(tbl出荷.出荷先CDColumn.ColumnName)
                        Me.Fields.Header.出荷先名01.Value = row.Item(tbl出荷.出荷先名Column.ColumnName)
                    Case 2
                        Me.Fields.Header.出荷先CD02.Value = row.Item(tbl出荷.出荷先CDColumn.ColumnName)
                        Me.Fields.Header.出荷先名02.Value = row.Item(tbl出荷.出荷先名Column.ColumnName)
                    Case 3
                        Me.Fields.Header.出荷先CD03.Value = row.Item(tbl出荷.出荷先CDColumn.ColumnName)
                        Me.Fields.Header.出荷先名03.Value = row.Item(tbl出荷.出荷先名Column.ColumnName)
                    Case 4
                        Me.Fields.Header.出荷先CD04.Value = row.Item(tbl出荷.出荷先CDColumn.ColumnName)
                        Me.Fields.Header.出荷先名04.Value = row.Item(tbl出荷.出荷先名Column.ColumnName)
                End Select
            Next

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return True
        End Function
#End Region

#Region "Write"
        '''========================================================================================
        ''' <SUMMARY>書込</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overrides Function Write_Header() As Boolean
            '----------------------------------------------------------------------
            ' 変数定義
            '----------------------------------------------------------------------
            Dim adaフレ As New NodeDatabase.DataSetTranTableAdapters.TフレキTableAdapter
            Dim tblフレ As New NodeDatabase.DataSetTran.TフレキDataTable
            Dim qryフレ As New Collection

            Dim ada基本 As New NodeDatabase.DataSetTranTableAdapters.T受注基本TableAdapter
            Dim tbl基本 As New NodeDatabase.DataSetTran.T受注基本DataTable
            Dim qry基本 As New Collection

            Dim ada注意 As New NodeDatabase.DataSetTranTableAdapters.T受注作業注意TableAdapter
            Dim tbl注意 As New NodeDatabase.DataSetTran.T受注作業注意DataTable
            Dim qry注意 As New Collection

            Dim ada出荷 As New NodeDatabase.DataSetTranTableAdapters.T受注出荷先TableAdapter
            Dim tbl出荷 As New NodeDatabase.DataSetTran.T受注出荷先DataTable
            Dim qry出荷 As New Collection

            '----------------------------------------------------------------------
            ' 保存
            '----------------------------------------------------------------------
            Using scope As New System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required, TimeSpan.Zero)
                '-------------------------------------
                ' 事前削除
                '-------------------------------------
                qryフレ.Clear()
                qryフレ.Add(New BaseDatabase.Condition(tblフレ.作業NOColumn.ColumnName, Me.Fields.Header.作業NO.Value, BaseDatabase.Contents.Compare.Equal))
                adaフレ.DeleteByCommon(qryフレ)

                qry基本.Clear()
                qry基本.Add(New BaseDatabase.Condition(tbl基本.作業NOColumn.ColumnName, Me.Fields.Header.作業NO.Value, BaseDatabase.Contents.Compare.Equal))
                ada基本.DeleteByCommon(qry基本)

                qry注意.Clear()
                qry注意.Add(New BaseDatabase.Condition(tbl注意.作業NOColumn.ColumnName, Me.Fields.Header.作業NO.Value, BaseDatabase.Contents.Compare.Equal))
                ada注意.DeleteByCommon(qry注意)

                qry出荷.Clear()
                qry出荷.Add(New BaseDatabase.Condition(tbl出荷.作業NOColumn.ColumnName, Me.Fields.Header.作業NO.Value, BaseDatabase.Contents.Compare.Equal))
                ada出荷.DeleteByCommon(qry出荷)

                '-------------------------------------
                ' 保存
                '-------------------------------------
                adaフレ.Insert(Me.Fields.Header.作業NO.Value _
                             , Me.Fields.Header.本台帳NO.Value _
                             , Me.Fields.Header.機番.Value _
                             , Me.Fields.Header.刃型区分.Value _
                             , Me.Fields.Header.顧客刃型番号.Value _
                             , Me.Fields.Header.担当者CD.Value _
                             , Me.Fields.Header.原価.Value _
                             , Me.Fields.Header.刃型サイズ一面紙幅方向.Value _
                             , Me.Fields.Header.刃型サイズ一面流れ方向.Value _
                             , Me.Fields.Header.刃型サイズ一面角.Value _
                             , Me.Fields.Header.刃型サイズ一面形状区分.Value _
                             , Me.Fields.Header.刃型情報ギヤ数.Value _
                             , Me.Fields.Header.刃型情報板厚.Value _
                             , Me.Fields.Header.刃型情報総円周.Value _
                             , Me.Fields.Header.刃型情報バリヤ.Value _
                             , Me.Fields.Header.面付紙幅方向面数.Value _
                             , Me.Fields.Header.面付紙幅方向ドブ寸法.Value _
                             , Me.Fields.Header.面付流れ方向面数.Value _
                             , Me.Fields.Header.面付流れ方向ドブ寸法.Value _
                             , Me.Fields.Header.刃型サイズ全体紙幅方向.Value _
                             , Me.Fields.Header.刃型サイズ全体流れ方向.Value _
                             , Me.Fields.Header.線幅刃型線.Value _
                             , Me.Fields.Header.線幅原点.Value _
                             , Me.Fields.Header.線幅トンボ.Value _
                             , Me.Fields.Header.バリヤ表区分.Value _
                             , Me.Fields.Header.台紙CD.Value _
                             , Me.Fields.Header.フレキ機械種別区分.Value _
                             , Me.Fields.Header.計上先作業NO.Value _
                             , Me.Fields.Header.仕入先CD.Value _
                              )

                ada基本.Insert(Me.Fields.Header.作業NO.Value _
                             , "000000" _
                             , Me.Fields.Header.御客様NO.Value _
                             , "00" _
                             , Me.Fields.Header.受注日付.Value _
                             , Me.Fields.Header.納品日付B.Value _
                             , Me.Fields.Header.納品日付B.Value _
                             , Me.Fields.Header.確約区分.Value _
                             , "" _
                             , Me.Fields.Header.得意先CD.Value _
                             , Me.Fields.Header.請求先CD.Value _
                             , "0" _
                             , Me.Fields.Header.代表商品名.Value _
                             , "", "" _
                             , Me.Fields.Header.受注数合計.Value _
                             , 0, 0, 0, 0 _
                             , Me.Fields.Header.受注単価.Value _
                             , "" _
                             , Me.Fields.Header.受注金額.Value _
                             , "" _
                             , 0, 0, 0, 0, 0, 0, 0 _
                             , "1", "00" _
                             , NodeContents.Constant.CodeValue.受注区分.フレキシブル _
                             , "", "000000", 0, "", "", "", "", "", 0, 0, "", "", 0, 0, 0, 0, 0, 0 _
                             , Me.Fields.Header.社内外区分.Value _
                             , "", 0, 0, "", "", "", "", "", "" _
                              )

                If Me.Fields.Header.注意事項01.Value <> "" Then
                    ada注意.Insert(Me.Fields.Header.作業NO.Value, 1, Me.Fields.Header.注意事項01.Value)
                End If

                If Me.Fields.Header.注意事項02.Value <> "" Then
                    ada注意.Insert(Me.Fields.Header.作業NO.Value, 2, Me.Fields.Header.注意事項02.Value)
                End If

                If Me.Fields.Header.注意事項03.Value <> "" Then
                    ada注意.Insert(Me.Fields.Header.作業NO.Value, 3, Me.Fields.Header.注意事項03.Value)
                End If

                If Me.Fields.Header.注意事項04.Value <> "" Then
                    ada注意.Insert(Me.Fields.Header.作業NO.Value, 4, Me.Fields.Header.注意事項04.Value)
                End If

                If Me.Fields.Header.注意事項05.Value <> "" Then
                    ada注意.Insert(Me.Fields.Header.作業NO.Value, 5, Me.Fields.Header.注意事項05.Value)
                End If

                If Me.Fields.Header.出荷先CD01.Value <> "" Or Me.Fields.Header.出荷先名01.Value <> "" Then
                    ada出荷.Insert(Me.Fields.Header.作業NO.Value, 1, Me.Fields.Header.出荷先CD01.Value, Me.Fields.Header.出荷先名01.Value)
                End If

                If Me.Fields.Header.出荷先CD02.Value <> "" Or Me.Fields.Header.出荷先名02.Value <> "" Then
                    ada出荷.Insert(Me.Fields.Header.作業NO.Value, 2, Me.Fields.Header.出荷先CD02.Value, Me.Fields.Header.出荷先名02.Value)
                End If

                If Me.Fields.Header.出荷先CD03.Value <> "" Or Me.Fields.Header.出荷先名03.Value <> "" Then
                    ada出荷.Insert(Me.Fields.Header.作業NO.Value, 3, Me.Fields.Header.出荷先CD03.Value, Me.Fields.Header.出荷先名03.Value)
                End If

                If Me.Fields.Header.出荷先CD04.Value <> "" Or Me.Fields.Header.出荷先名04.Value <> "" Then
                    ada出荷.Insert(Me.Fields.Header.作業NO.Value, 4, Me.Fields.Header.出荷先CD04.Value, Me.Fields.Header.出荷先名04.Value)
                End If

                '-------------------------------------
                ' COMMIT
                '-------------------------------------
                scope.Complete()
            End Using

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return True
        End Function
#End Region

#Region "Delete"
        '''========================================================================================
        ''' <SUMMARY>削除</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overrides Function Delete_Header() As Boolean
            '----------------------------------------------------------------------
            ' 変数定義
            '----------------------------------------------------------------------
            Dim adaフレ As New NodeDatabase.DataSetTranTableAdapters.TフレキTableAdapter
            Dim tblフレ As New NodeDatabase.DataSetTran.TフレキDataTable
            Dim qryフレ As New Collection

            Dim ada基本 As New NodeDatabase.DataSetTranTableAdapters.T受注基本TableAdapter
            Dim tbl基本 As New NodeDatabase.DataSetTran.T受注基本DataTable
            Dim qry基本 As New Collection

            Dim ada注意 As New NodeDatabase.DataSetTranTableAdapters.T受注作業注意TableAdapter
            Dim tbl注意 As New NodeDatabase.DataSetTran.T受注作業注意DataTable
            Dim qry注意 As New Collection

            Dim ada出荷 As New NodeDatabase.DataSetTranTableAdapters.T受注出荷先TableAdapter
            Dim tbl出荷 As New NodeDatabase.DataSetTran.T受注出荷先DataTable
            Dim qry出荷 As New Collection

            '----------------------------------------------------------------------
            ' 保存
            '----------------------------------------------------------------------
            Using scope As New System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required, TimeSpan.Zero)
                '-------------------------------------
                ' 事前削除
                '-------------------------------------
                qryフレ.Clear()
                qryフレ.Add(New BaseDatabase.Condition(tblフレ.作業NOColumn.ColumnName, Me.Fields.Header.作業NO.Value, BaseDatabase.Contents.Compare.Equal))
                adaフレ.DeleteByCommon(qryフレ)

                qry基本.Clear()
                qry基本.Add(New BaseDatabase.Condition(tbl基本.作業NOColumn.ColumnName, Me.Fields.Header.作業NO.Value, BaseDatabase.Contents.Compare.Equal))
                ada基本.DeleteByCommon(qry基本)

                qry注意.Clear()
                qry注意.Add(New BaseDatabase.Condition(tbl注意.作業NOColumn.ColumnName, Me.Fields.Header.作業NO.Value, BaseDatabase.Contents.Compare.Equal))
                ada注意.DeleteByCommon(qry注意)

                qry出荷.Clear()
                qry出荷.Add(New BaseDatabase.Condition(tbl出荷.作業NOColumn.ColumnName, Me.Fields.Header.作業NO.Value, BaseDatabase.Contents.Compare.Equal))
                ada出荷.DeleteByCommon(qry出荷)

                '-------------------------------------
                ' COMMIT
                '-------------------------------------
                scope.Complete()
            End Using

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return True
        End Function
#End Region

#Region "Valid_Write"
        '''========================================================================================
        ''' <SUMMARY>検査(共通)</SUMMARY>
        ''' <RETURNS>True:正常, False:不正</RETURNS>
        '''========================================================================================
        Protected Overrides Function Valid_Write_Header_Common() As NodeContents.ActionButton.ErrorLevel
            '----------------------------------------------------------------------
            ' 変数定義
            '----------------------------------------------------------------------
            Dim strMsg As String = ""
            Dim Validator As New BaseCore.Common.Validator

            '------------------------------------------------------------------
            ' ｴﾗｰｸﾘｱ
            '------------------------------------------------------------------
            Me.Fields.Header.作業NO.IsError = False
            Me.Fields.Header.本台帳NO.IsError = False
            Me.Fields.Header.機番.IsError = False
            Me.Fields.Header.刃型区分.IsError = False
            Me.Fields.Header.顧客刃型番号.IsError = False
            Me.Fields.Header.担当者CD.IsError = False
            Me.Fields.Header.担当者名.IsError = False
            Me.Fields.Header.原価.IsError = False
            Me.Fields.Header.刃型サイズ一面紙幅方向.IsError = False
            Me.Fields.Header.刃型サイズ一面流れ方向.IsError = False
            Me.Fields.Header.刃型サイズ一面角.IsError = False
            Me.Fields.Header.刃型サイズ一面形状区分.IsError = False
            Me.Fields.Header.刃型情報ギヤ数.IsError = False
            Me.Fields.Header.刃型情報板厚.IsError = False
            Me.Fields.Header.刃型情報総円周.IsError = False
            Me.Fields.Header.刃型情報バリヤ.IsError = False
            Me.Fields.Header.面付紙幅方向面数.IsError = False
            Me.Fields.Header.面付紙幅方向ドブ寸法.IsError = False
            Me.Fields.Header.面付流れ方向面数.IsError = False
            Me.Fields.Header.面付流れ方向ドブ寸法.IsError = False
            Me.Fields.Header.刃型サイズ全体紙幅方向.IsError = False
            Me.Fields.Header.刃型サイズ全体流れ方向.IsError = False
            Me.Fields.Header.線幅刃型線.IsError = False
            Me.Fields.Header.線幅原点.IsError = False
            Me.Fields.Header.線幅トンボ.IsError = False
            Me.Fields.Header.バリヤ表区分.IsError = False
            Me.Fields.Header.バリヤ表区分名.IsError = False
            Me.Fields.Header.台紙CD.IsError = False
            Me.Fields.Header.台紙名.IsError = False
            Me.Fields.Header.フレキ機械種別区分.IsError = False
            Me.Fields.Header.計上先作業NO.IsError = False
            Me.Fields.Header.仕入先CD.IsError = False
            Me.Fields.Header.仕入先名.IsError = False

            Me.Fields.Header.社内外区分.IsError = False
            Me.Fields.Header.御客様NO.IsError = False
            Me.Fields.Header.受注日付.IsError = False
            Me.Fields.Header.納品日付B.IsError = False
            Me.Fields.Header.確約区分.IsError = False
            Me.Fields.Header.得意先CD.IsError = False
            Me.Fields.Header.得意先名.IsError = False
            Me.Fields.Header.請求先CD.IsError = False
            Me.Fields.Header.請求先名.IsError = False
            Me.Fields.Header.代表商品名.IsError = False
            Me.Fields.Header.受注数合計.IsError = False
            Me.Fields.Header.受注単価.IsError = False
            Me.Fields.Header.受注金額.IsError = False

            Me.Fields.Header.注意事項01.IsError = False
            Me.Fields.Header.注意事項02.IsError = False
            Me.Fields.Header.注意事項03.IsError = False
            Me.Fields.Header.注意事項04.IsError = False
            Me.Fields.Header.注意事項05.IsError = False

            Me.Fields.Header.出荷先CD01.IsError = False
            Me.Fields.Header.出荷先名01.IsError = False
            Me.Fields.Header.出荷先CD02.IsError = False
            Me.Fields.Header.出荷先名02.IsError = False
            Me.Fields.Header.出荷先CD03.IsError = False
            Me.Fields.Header.出荷先名03.IsError = False
            Me.Fields.Header.出荷先CD04.IsError = False
            Me.Fields.Header.出荷先名04.IsError = False

            Me.Fields.Header.処理登録.IsError = False
            Me.Fields.Header.処理修正.IsError = False
            Me.Fields.Header.処理削除.IsError = False

            '------------------------------------------------------------------
            ' 共通検査
            '------------------------------------------------------------------
            Validator.BaseChecker(Me.Fields.Header.作業NO, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.本台帳NO, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.機番, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.刃型区分, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.顧客刃型番号, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.担当者CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.担当者名, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.原価, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.刃型サイズ一面紙幅方向, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.刃型サイズ一面流れ方向, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.刃型サイズ一面角, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.刃型サイズ一面形状区分, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.刃型情報ギヤ数, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.刃型情報板厚, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.刃型情報総円周, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.刃型情報バリヤ, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.面付紙幅方向面数, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.面付紙幅方向ドブ寸法, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.面付流れ方向面数, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.面付流れ方向ドブ寸法, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.刃型サイズ全体紙幅方向, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.刃型サイズ全体流れ方向, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.線幅刃型線, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.線幅原点, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.線幅トンボ, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.バリヤ表区分, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.バリヤ表区分名, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.台紙CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.台紙名, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.フレキ機械種別区分, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.計上先作業NO, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.仕入先CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.仕入先名, strMsg, Me.ControlError)

            Validator.BaseChecker(Me.Fields.Header.社内外区分, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.御客様NO, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.受注日付, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.納品日付B, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.確約区分, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.得意先CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.得意先名, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.請求先CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.請求先名, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.代表商品名, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.受注数合計, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.受注単価, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.受注金額, strMsg, Me.ControlError)

            Validator.BaseChecker(Me.Fields.Header.注意事項01, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.注意事項02, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.注意事項03, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.注意事項04, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.注意事項05, strMsg, Me.ControlError)

            Validator.BaseChecker(Me.Fields.Header.出荷先CD01, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.出荷先名01, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.出荷先CD02, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.出荷先名02, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.出荷先CD03, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.出荷先名03, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.出荷先CD04, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.出荷先名04, strMsg, Me.ControlError)

            Validator.BaseChecker(Me.Fields.Header.処理登録, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.処理修正, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.処理削除, strMsg, Me.ControlError)

            '------------------------------------------------------------------
            ' 返却
            '------------------------------------------------------------------
            MyBase.LastError = strMsg
            Select Case True
                Case strMsg = ""
                    Return NodeContents.ActionButton.ErrorLevel.None
                Case Else
                    Return NodeContents.ActionButton.ErrorLevel.Fatal
            End Select
        End Function
#End Region
    End Class
End Namespace
