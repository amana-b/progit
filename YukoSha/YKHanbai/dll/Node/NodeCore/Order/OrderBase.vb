Namespace Frame.Order
    Partial Public Class OrderBase
        Inherits NodeCore.Common.Frame

#Region "ﾌｨｰﾙﾄﾞ定義"
#Region "受注基本"
        Public Class HeaderBase
            ''' ----------------------------------------------------------------------------------------
            ''' <SUMMARY>列項目(基本)</SUMMARY>
            ''' ----------------------------------------------------------------------------------------
            Public 作業NO As BaseCore.Common.Field.ItemData
            Public 本台帳NO As BaseCore.Common.Field.ItemData
            Public 御客様NO As BaseCore.Common.Field.ItemData
            Public 枝番 As BaseCore.Common.Field.ItemData
            Public 受注日付 As BaseCore.Common.Field.ItemData
            Public 納品日付A As BaseCore.Common.Field.ItemData
            Public 納品日付B As BaseCore.Common.Field.ItemData
            Public 確約区分 As BaseCore.Common.Field.ItemData
            Public 入力担当者CD As BaseCore.Common.Field.ItemData
            Public 得意先CD As BaseCore.Common.Field.ItemData
            Public 請求先CD As BaseCore.Common.Field.ItemData
            Public 定番フラグ As BaseCore.Common.Field.ItemData
            Public 代表商品名 As BaseCore.Common.Field.ItemData
            Public 顧客商品CD As BaseCore.Common.Field.ItemData
            Public 顧客商品CDALL As BaseCore.Common.Field.ItemData
            Public 受注数合計 As BaseCore.Common.Field.ItemData
            Public 内在庫引当数合計 As BaseCore.Common.Field.ItemData
            Public 通数合計 As BaseCore.Common.Field.ItemData
            Public 通数1 As BaseCore.Common.Field.ItemData
            Public 通数2 As BaseCore.Common.Field.ItemData
            Public 通数3 As BaseCore.Common.Field.ItemData
            Public 受注単価 As BaseCore.Common.Field.ItemData
            Public 単位区分 As BaseCore.Common.Field.ItemData
            Public 受注金額 As BaseCore.Common.Field.ItemData
            Public 原価決定日付 As BaseCore.Common.Field.ItemData
            Public 通数累計 As BaseCore.Common.Field.ItemData
            Public 売上数累計 As BaseCore.Common.Field.ItemData
            Public 入庫数累計 As BaseCore.Common.Field.ItemData
            Public 売上金額 As BaseCore.Common.Field.ItemData
            Public 仕入金額 As BaseCore.Common.Field.ItemData
            Public 固定経費 As BaseCore.Common.Field.ItemData
            Public 入金区分 As BaseCore.Common.Field.ItemData
            Public 印刷場所CD As BaseCore.Common.Field.ItemData
            Public 受注区分 As BaseCore.Common.Field.ItemData
            Public 刃型NO As BaseCore.Common.Field.ItemData
            Public 版NO As BaseCore.Common.Field.ItemData
            Public ギヤ数 As BaseCore.Common.Field.ItemData
            Public 発送仕上特記事項 As BaseCore.Common.Field.ItemData
            Public 作業伝票一括発行日付本社 As BaseCore.Common.Field.ItemData
            Public 作業伝票一括発行日付河北 As BaseCore.Common.Field.ItemData
            Public 受注ラベル印字フラグ本社 As BaseCore.Common.Field.ItemData
            Public 受注ラベル印字フラグ河北 As BaseCore.Common.Field.ItemData
            Public 廃棄年月 As BaseCore.Common.Field.ItemData

            Public 新再版区分 As BaseCore.Common.Field.ItemData
            Public 得意先名 As BaseCore.Common.Field.ItemData
            Public 請求先名 As BaseCore.Common.Field.ItemData
            Public 担当者名 As BaseCore.Common.Field.ItemData
            Public 印刷場所名 As BaseCore.Common.Field.ItemData
            Public 確約区分名 As BaseCore.Common.Field.ItemData
            Public 単位区分名 As BaseCore.Common.Field.ItemData
            Public 入金区分名 As BaseCore.Common.Field.ItemData
            Public 受注区分名 As BaseCore.Common.Field.ItemData
            Public 社内外区分名 As BaseCore.Common.Field.ItemData
            Public 内製造数合計 As BaseCore.Common.Field.ItemData

            Public 売上金額01 As BaseCore.Common.Field.ItemData
            Public 売上区分01 As BaseCore.Common.Field.ItemData
            Public 売上名01 As BaseCore.Common.Field.ItemData
            Public 売上数量01 As BaseCore.Common.Field.ItemData
            Public 売上単価01 As BaseCore.Common.Field.ItemData
            Public 売上金額02 As BaseCore.Common.Field.ItemData
            Public 売上区分02 As BaseCore.Common.Field.ItemData
            Public 売上名02 As BaseCore.Common.Field.ItemData
            Public 売上数量02 As BaseCore.Common.Field.ItemData
            Public 売上単価02 As BaseCore.Common.Field.ItemData
            Public 売上金額03 As BaseCore.Common.Field.ItemData
            Public 売上区分03 As BaseCore.Common.Field.ItemData
            Public 売上名03 As BaseCore.Common.Field.ItemData
            Public 売上数量03 As BaseCore.Common.Field.ItemData
            Public 売上単価03 As BaseCore.Common.Field.ItemData
            Public 売上金額04 As BaseCore.Common.Field.ItemData
            Public 売上区分04 As BaseCore.Common.Field.ItemData
            Public 売上名04 As BaseCore.Common.Field.ItemData
            Public 売上数量04 As BaseCore.Common.Field.ItemData
            Public 売上単価04 As BaseCore.Common.Field.ItemData
            Public 売上金額05 As BaseCore.Common.Field.ItemData
            Public 売上区分05 As BaseCore.Common.Field.ItemData
            Public 売上名05 As BaseCore.Common.Field.ItemData
            Public 売上数量05 As BaseCore.Common.Field.ItemData
            Public 売上単価05 As BaseCore.Common.Field.ItemData

            Public 作業注意01 As BaseCore.Common.Field.ItemData
            Public 作業注意02 As BaseCore.Common.Field.ItemData
            Public 作業注意03 As BaseCore.Common.Field.ItemData
            Public 作業注意04 As BaseCore.Common.Field.ItemData
            Public 作業注意05 As BaseCore.Common.Field.ItemData
            Public 作業注意06 As BaseCore.Common.Field.ItemData
            Public 作業注意07 As BaseCore.Common.Field.ItemData
            Public 作業注意08 As BaseCore.Common.Field.ItemData
            Public 作業注意09 As BaseCore.Common.Field.ItemData
            Public 作業注意10 As BaseCore.Common.Field.ItemData

            Public 出荷注意01 As BaseCore.Common.Field.ItemData
            Public 出荷注意02 As BaseCore.Common.Field.ItemData
            Public 出荷注意03 As BaseCore.Common.Field.ItemData
            Public 出荷注意04 As BaseCore.Common.Field.ItemData
            Public 出荷注意05 As BaseCore.Common.Field.ItemData
            Public 出荷注意06 As BaseCore.Common.Field.ItemData
            Public 出荷注意07 As BaseCore.Common.Field.ItemData
            Public 出荷注意08 As BaseCore.Common.Field.ItemData
            Public 出荷注意09 As BaseCore.Common.Field.ItemData
            Public 出荷注意10 As BaseCore.Common.Field.ItemData

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
                Dim tbl基本 As New NodeDatabase.DataSetView.V0受注基本DataTable
                Dim tbl売上 As New NodeDatabase.DataSetView.V0受注売上DataTable
                Dim tbl作注 As New NodeDatabase.DataSetView.V0受注作業注意DataTable
                Dim tbl出注 As New NodeDatabase.DataSetView.V0受注出荷注意DataTable
                Dim tbl出荷 As New NodeDatabase.DataSetView.V0受注出荷先DataTable

                '----------------------------------------------------------------------
                ' ｲﾝｽﾀﾝｽ(基本)
                '----------------------------------------------------------------------
                Me.作業NO = New BaseCore.Common.Field.ItemData(tbl基本.作業NOColumn)
                Me.本台帳NO = New BaseCore.Common.Field.ItemData(tbl基本.本台帳NOColumn)
                Me.御客様NO = New BaseCore.Common.Field.ItemData(tbl基本.御客様NOColumn)
                Me.枝番 = New BaseCore.Common.Field.ItemData(tbl基本.枝番Column)
                Me.受注日付 = New BaseCore.Common.Field.ItemData(tbl基本.受注日付Column)
                Me.納品日付A = New BaseCore.Common.Field.ItemData(tbl基本.納品日付AColumn)
                Me.納品日付B = New BaseCore.Common.Field.ItemData(tbl基本.納品日付BColumn)
                Me.確約区分 = New BaseCore.Common.Field.ItemData(tbl基本.確約区分Column)
                Me.入力担当者CD = New BaseCore.Common.Field.ItemData(tbl基本.入力担当者CDColumn)
                Me.得意先CD = New BaseCore.Common.Field.ItemData(tbl基本.得意先CDColumn)
                Me.請求先CD = New BaseCore.Common.Field.ItemData(tbl基本.請求先CDColumn)
                Me.定番フラグ = New BaseCore.Common.Field.ItemData(tbl基本.定番フラグColumn)
                Me.代表商品名 = New BaseCore.Common.Field.ItemData(tbl基本.代表商品名Column)
                Me.顧客商品CD = New BaseCore.Common.Field.ItemData(tbl基本.顧客商品CDColumn)
                Me.顧客商品CDALL = New BaseCore.Common.Field.ItemData(tbl基本.顧客商品CDALLColumn)
                Me.受注数合計 = New BaseCore.Common.Field.ItemData(tbl基本.受注数合計Column, 9, 0)
                Me.内在庫引当数合計 = New BaseCore.Common.Field.ItemData(tbl基本.内在庫引当数合計Column, 9, 0)
                Me.通数合計 = New BaseCore.Common.Field.ItemData(tbl基本.通数合計Column, 9, 0)
                Me.通数1 = New BaseCore.Common.Field.ItemData(tbl基本.通数1Column, 9, 0)
                Me.通数2 = New BaseCore.Common.Field.ItemData(tbl基本.通数2Column, 9, 0)
                Me.通数3 = New BaseCore.Common.Field.ItemData(tbl基本.通数3Column, 9, 0)
                Me.受注単価 = New BaseCore.Common.Field.ItemData(tbl基本.受注単価Column, 9, 2)
                Me.単位区分 = New BaseCore.Common.Field.ItemData(tbl基本.単位区分Column)
                Me.受注金額 = New BaseCore.Common.Field.ItemData(tbl基本.受注金額Column, 9, 0)
                Me.原価決定日付 = New BaseCore.Common.Field.ItemData(tbl基本.原価決定日付Column)
                Me.通数累計 = New BaseCore.Common.Field.ItemData(tbl基本.通数累計Column, 9, 0)
                Me.売上数累計 = New BaseCore.Common.Field.ItemData(tbl基本.売上数累計Column, 9, 0)
                Me.入庫数累計 = New BaseCore.Common.Field.ItemData(tbl基本.入庫数累計Column, 9, 0)
                Me.売上金額 = New BaseCore.Common.Field.ItemData(tbl基本.売上金額Column, 9, 0)
                Me.仕入金額 = New BaseCore.Common.Field.ItemData(tbl基本.仕入金額Column, 9, 0)
                Me.固定経費 = New BaseCore.Common.Field.ItemData(tbl基本.固定経費Column, 9, 0)
                Me.入金区分 = New BaseCore.Common.Field.ItemData(tbl基本.入金区分Column)
                Me.印刷場所CD = New BaseCore.Common.Field.ItemData(tbl基本.印刷場所CDColumn)
                Me.受注区分 = New BaseCore.Common.Field.ItemData(tbl基本.受注区分Column)
                Me.刃型NO = New BaseCore.Common.Field.ItemData(tbl基本.刃型NOColumn)
                Me.版NO = New BaseCore.Common.Field.ItemData(tbl基本.版NOColumn)
                Me.ギヤ数 = New BaseCore.Common.Field.ItemData(tbl基本.ギヤ数Column, 3, 0)
                Me.発送仕上特記事項 = New BaseCore.Common.Field.ItemData(tbl基本.発送仕上特記事項Column)
                Me.作業伝票一括発行日付本社 = New BaseCore.Common.Field.ItemData(tbl基本.作業伝票一括発行日付本社Column)
                Me.作業伝票一括発行日付河北 = New BaseCore.Common.Field.ItemData(tbl基本.作業伝票一括発行日付河北Column)
                Me.受注ラベル印字フラグ本社 = New BaseCore.Common.Field.ItemData(tbl基本.受注ラベル印字フラグ本社Column)
                Me.受注ラベル印字フラグ河北 = New BaseCore.Common.Field.ItemData(tbl基本.受注ラベル印字フラグ河北Column)
                Me.廃棄年月 = New BaseCore.Common.Field.ItemData(tbl基本.廃棄年月Column)

                Me.新再版区分 = New BaseCore.Common.Field.ItemData("新再版区分", TypeCode.String, 1)
                Me.得意先名 = New BaseCore.Common.Field.ItemData(tbl基本.得意先名Column)
                Me.請求先名 = New BaseCore.Common.Field.ItemData(tbl基本.請求先名Column)
                Me.担当者名 = New BaseCore.Common.Field.ItemData(tbl基本.担当者名Column)
                Me.印刷場所名 = New BaseCore.Common.Field.ItemData(tbl基本.印刷場所名Column)
                Me.確約区分名 = New BaseCore.Common.Field.ItemData(tbl基本.確約区分名Column)
                Me.単位区分名 = New BaseCore.Common.Field.ItemData(tbl基本.単位区分名Column)
                Me.入金区分名 = New BaseCore.Common.Field.ItemData(tbl基本.入金区分名Column)
                Me.受注区分名 = New BaseCore.Common.Field.ItemData(tbl基本.受注区分名Column)
                Me.社内外区分名 = New BaseCore.Common.Field.ItemData(tbl基本.社内外区分名Column)
                Me.内製造数合計 = New BaseCore.Common.Field.ItemData(tbl基本.内製造数合計Column, 9, 0)

                Me.売上金額01 = New BaseCore.Common.Field.ItemData(tbl売上.売上金額Column, 9, 0)
                Me.売上区分01 = New BaseCore.Common.Field.ItemData(tbl売上.売上指示区分Column)
                Me.売上名01 = New BaseCore.Common.Field.ItemData(tbl売上.売上名Column)
                Me.売上数量01 = New BaseCore.Common.Field.ItemData(tbl売上.数量Column, 4, 0)
                Me.売上単価01 = New BaseCore.Common.Field.ItemData(tbl売上.単価Column, 5, 0)
                Me.売上金額02 = New BaseCore.Common.Field.ItemData(tbl売上.売上金額Column, 9, 0)
                Me.売上区分02 = New BaseCore.Common.Field.ItemData(tbl売上.売上指示区分Column)
                Me.売上名02 = New BaseCore.Common.Field.ItemData(tbl売上.売上名Column)
                Me.売上数量02 = New BaseCore.Common.Field.ItemData(tbl売上.数量Column, 4, 0)
                Me.売上単価02 = New BaseCore.Common.Field.ItemData(tbl売上.単価Column, 5, 0)
                Me.売上金額03 = New BaseCore.Common.Field.ItemData(tbl売上.売上金額Column, 9, 0)
                Me.売上区分03 = New BaseCore.Common.Field.ItemData(tbl売上.売上指示区分Column)
                Me.売上名03 = New BaseCore.Common.Field.ItemData(tbl売上.売上名Column)
                Me.売上数量03 = New BaseCore.Common.Field.ItemData(tbl売上.数量Column, 4, 0)
                Me.売上単価03 = New BaseCore.Common.Field.ItemData(tbl売上.単価Column, 5, 0)
                Me.売上金額04 = New BaseCore.Common.Field.ItemData(tbl売上.売上金額Column, 9, 0)
                Me.売上区分04 = New BaseCore.Common.Field.ItemData(tbl売上.売上指示区分Column)
                Me.売上名04 = New BaseCore.Common.Field.ItemData(tbl売上.売上名Column)
                Me.売上数量04 = New BaseCore.Common.Field.ItemData(tbl売上.数量Column, 4, 0)
                Me.売上単価04 = New BaseCore.Common.Field.ItemData(tbl売上.単価Column, 5, 0)
                Me.売上金額05 = New BaseCore.Common.Field.ItemData(tbl売上.売上金額Column, 9, 0)
                Me.売上区分05 = New BaseCore.Common.Field.ItemData(tbl売上.売上指示区分Column)
                Me.売上名05 = New BaseCore.Common.Field.ItemData(tbl売上.売上名Column)
                Me.売上数量05 = New BaseCore.Common.Field.ItemData(tbl売上.数量Column, 4, 0)
                Me.売上単価05 = New BaseCore.Common.Field.ItemData(tbl売上.単価Column, 5, 0)

                Me.作業注意01 = New BaseCore.Common.Field.ItemData(tbl作注.注意事項Column)
                Me.作業注意02 = New BaseCore.Common.Field.ItemData(tbl作注.注意事項Column)
                Me.作業注意03 = New BaseCore.Common.Field.ItemData(tbl作注.注意事項Column)
                Me.作業注意04 = New BaseCore.Common.Field.ItemData(tbl作注.注意事項Column)
                Me.作業注意05 = New BaseCore.Common.Field.ItemData(tbl作注.注意事項Column)
                Me.作業注意06 = New BaseCore.Common.Field.ItemData(tbl作注.注意事項Column)
                Me.作業注意07 = New BaseCore.Common.Field.ItemData(tbl作注.注意事項Column)
                Me.作業注意08 = New BaseCore.Common.Field.ItemData(tbl作注.注意事項Column)
                Me.作業注意09 = New BaseCore.Common.Field.ItemData(tbl作注.注意事項Column)
                Me.作業注意10 = New BaseCore.Common.Field.ItemData(tbl作注.注意事項Column)

                Me.出荷注意01 = New BaseCore.Common.Field.ItemData(tbl出注.注意事項Column)
                Me.出荷注意02 = New BaseCore.Common.Field.ItemData(tbl出注.注意事項Column)
                Me.出荷注意03 = New BaseCore.Common.Field.ItemData(tbl出注.注意事項Column)
                Me.出荷注意04 = New BaseCore.Common.Field.ItemData(tbl出注.注意事項Column)
                Me.出荷注意05 = New BaseCore.Common.Field.ItemData(tbl出注.注意事項Column)
                Me.出荷注意06 = New BaseCore.Common.Field.ItemData(tbl出注.注意事項Column)
                Me.出荷注意07 = New BaseCore.Common.Field.ItemData(tbl出注.注意事項Column)
                Me.出荷注意08 = New BaseCore.Common.Field.ItemData(tbl出注.注意事項Column)
                Me.出荷注意09 = New BaseCore.Common.Field.ItemData(tbl出注.注意事項Column)
                Me.出荷注意10 = New BaseCore.Common.Field.ItemData(tbl出注.注意事項Column)

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
#End Region

#Region "商品内訳"
        Public Class HeaderItem
            ''' ----------------------------------------------------------------------------------------
            ''' <SUMMARY>列項目(基本)</SUMMARY>
            ''' ----------------------------------------------------------------------------------------
            Public 枝番 As BaseCore.Common.Field.ItemData
            Public 定番CD As BaseCore.Common.Field.ItemData
            Public 商品名 As BaseCore.Common.Field.ItemData
            Public 受注数 As BaseCore.Common.Field.ItemData
            Public 内在庫引当数 As BaseCore.Common.Field.ItemData
            Public 受注単価 As BaseCore.Common.Field.ItemData
            Public 納品日付A As BaseCore.Common.Field.ItemData
            Public 納品日付B As BaseCore.Common.Field.ItemData
            Public 顧客商品CD As BaseCore.Common.Field.ItemData
            Public 顧客発注NO As BaseCore.Common.Field.ItemData
            Public 倉庫NO As BaseCore.Common.Field.ItemData
            Public 備考 As BaseCore.Common.Field.ItemData

            Public 内製造数 As BaseCore.Common.Field.ItemData

            '''========================================================================================
            ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
            '''========================================================================================
            Public Sub New(ByVal Config As NodeCore.Common.Config)
                Dim tbl As New NodeDatabase.DataSetView.V0受注商品内訳DataTable

                '----------------------------------------------------------------------
                ' ｲﾝｽﾀﾝｽ(基本)
                '----------------------------------------------------------------------
                Me.枝番 = New BaseCore.Common.Field.ItemData(tbl.枝番Column)
                Me.定番CD = New BaseCore.Common.Field.ItemData(tbl.定番CDColumn)
                Me.商品名 = New BaseCore.Common.Field.ItemData(tbl.商品名Column)
                Me.受注数 = New BaseCore.Common.Field.ItemData(tbl.受注数Column, 9, 0)
                Me.内在庫引当数 = New BaseCore.Common.Field.ItemData(tbl.内在庫引当数Column, 9, 0)
                Me.受注単価 = New BaseCore.Common.Field.ItemData(tbl.受注単価Column, 9, 2)
                Me.納品日付A = New BaseCore.Common.Field.ItemData(tbl.納品日付AColumn)
                Me.納品日付B = New BaseCore.Common.Field.ItemData(tbl.納品日付BColumn)
                Me.顧客商品CD = New BaseCore.Common.Field.ItemData(tbl.顧客商品CDColumn)
                Me.顧客発注NO = New BaseCore.Common.Field.ItemData(tbl.顧客発注NOColumn)
                Me.倉庫NO = New BaseCore.Common.Field.ItemData(tbl.倉庫NOColumn)
                Me.備考 = New BaseCore.Common.Field.ItemData(tbl.備考Column)

                Me.内製造数 = New BaseCore.Common.Field.ItemData(tbl.内製造数Column, 9, 0)
            End Sub
        End Class

        Public Class Detail1
            ''' ----------------------------------------------------------------------------------------
            ''' <SUMMARY>列項目(基本)</SUMMARY>
            ''' ----------------------------------------------------------------------------------------
            Public 作業NO As BaseCore.Common.Field.ItemData
            Public 枝番 As BaseCore.Common.Field.ItemData
            Public 定番CD As BaseCore.Common.Field.ItemData
            Public 商品名 As BaseCore.Common.Field.ItemData
            Public 受注数 As BaseCore.Common.Field.ItemData
            Public 内在庫引当数 As BaseCore.Common.Field.ItemData
            Public 受注単価 As BaseCore.Common.Field.ItemData
            Public 発注単価 As BaseCore.Common.Field.ItemData
            Public 納品日付A As BaseCore.Common.Field.ItemData
            Public 納品日付B As BaseCore.Common.Field.ItemData
            Public 顧客商品CD As BaseCore.Common.Field.ItemData
            Public 顧客発注NO As BaseCore.Common.Field.ItemData
            Public 倉庫NO As BaseCore.Common.Field.ItemData
            Public 備考 As BaseCore.Common.Field.ItemData

            Public 内製造数 As BaseCore.Common.Field.ItemData

            '''========================================================================================
            ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
            '''========================================================================================
            Public Sub New(ByVal Config As NodeCore.Common.Config)
                Dim tbl As New NodeDatabase.DataSetView.V0受注商品内訳DataTable

                '----------------------------------------------------------------------
                ' ｲﾝｽﾀﾝｽ(基本)
                '----------------------------------------------------------------------
                Me.作業NO = New BaseCore.Common.Field.ItemData(tbl.作業NOColumn)
                Me.枝番 = New BaseCore.Common.Field.ItemData(tbl.枝番Column)
                Me.定番CD = New BaseCore.Common.Field.ItemData(tbl.定番CDColumn)
                Me.商品名 = New BaseCore.Common.Field.ItemData(tbl.商品名Column)
                Me.受注数 = New BaseCore.Common.Field.ItemData(tbl.受注数Column, 9, 0)
                Me.内在庫引当数 = New BaseCore.Common.Field.ItemData(tbl.内在庫引当数Column, 9, 0)
                Me.受注単価 = New BaseCore.Common.Field.ItemData(tbl.受注単価Column, 9, 2)
                Me.発注単価 = New BaseCore.Common.Field.ItemData(tbl.発注単価Column, 9, 2)
                Me.納品日付A = New BaseCore.Common.Field.ItemData(tbl.納品日付AColumn)
                Me.納品日付B = New BaseCore.Common.Field.ItemData(tbl.納品日付BColumn)
                Me.顧客商品CD = New BaseCore.Common.Field.ItemData(tbl.顧客商品CDColumn)
                Me.顧客発注NO = New BaseCore.Common.Field.ItemData(tbl.顧客発注NOColumn)
                Me.倉庫NO = New BaseCore.Common.Field.ItemData(tbl.倉庫NOColumn)
                Me.備考 = New BaseCore.Common.Field.ItemData(tbl.備考Column)

                Me.内製造数 = New BaseCore.Common.Field.ItemData(tbl.内製造数Column, 9, 0)
            End Sub
        End Class
#End Region

#Region "紙発注"
        Public Class HeaderPaper
            ''' ----------------------------------------------------------------------------------------
            ''' <SUMMARY>列項目(基本)</SUMMARY>
            ''' ----------------------------------------------------------------------------------------
            Public 巻取区分 As BaseCore.Common.Field.ItemData
            Public 巻取区分名 As BaseCore.Common.Field.ItemData
            Public 出し方向区分 As BaseCore.Common.Field.ItemData
            Public 出し方向区分名 As BaseCore.Common.Field.ItemData
            Public 紙管 As BaseCore.Common.Field.ItemData
            Public 発行枚数 As BaseCore.Common.Field.ItemData
            Public スリッター区分 As BaseCore.Common.Field.ItemData
            Public スリッター区分名 As BaseCore.Common.Field.ItemData
            Public スリッター巾 As BaseCore.Common.Field.ItemData
            Public カット1 As BaseCore.Common.Field.ItemData
            Public カット2 As BaseCore.Common.Field.ItemData
            Public カット3 As BaseCore.Common.Field.ItemData
            Public 包装枚数 As BaseCore.Common.Field.ItemData
            Public 送りピッチ As BaseCore.Common.Field.ItemData
            Public 社内外区分 As BaseCore.Common.Field.ItemData

            Public 紙CD As BaseCore.Common.Field.ItemData
            Public 紙名 As BaseCore.Common.Field.ItemData
            Public 糊CD As BaseCore.Common.Field.ItemData
            Public 糊名 As BaseCore.Common.Field.ItemData
            Public 台紙CD As BaseCore.Common.Field.ItemData
            Public 台紙名 As BaseCore.Common.Field.ItemData
            Public 寸法巾 As BaseCore.Common.Field.ItemData
            Public 寸法長 As BaseCore.Common.Field.ItemData
            Public 仕入先指定区分 As BaseCore.Common.Field.ItemData
            Public 仕入先CD As BaseCore.Common.Field.ItemData
            Public 支社CD As BaseCore.Common.Field.ItemData
            Public 単価区分 As BaseCore.Common.Field.ItemData
            Public 発注単価 As BaseCore.Common.Field.ItemData
            Public 社内単価 As BaseCore.Common.Field.ItemData
            Public 納入区分 As BaseCore.Common.Field.ItemData
            Public 支給区分 As BaseCore.Common.Field.ItemData
            Public 有償支給単価 As BaseCore.Common.Field.ItemData
            Public 発注日付 As BaseCore.Common.Field.ItemData
            Public 通数 As BaseCore.Common.Field.ItemData
            Public 送りMM As BaseCore.Common.Field.ItemData
            Public 刷出M As BaseCore.Common.Field.ItemData
            Public つなぎロス As BaseCore.Common.Field.ItemData
            Public その他M As BaseCore.Common.Field.ItemData
            Public 希望納期日付 As BaseCore.Common.Field.ItemData
            Public 希望時間帯区分 As BaseCore.Common.Field.ItemData
            Public 基準長 As BaseCore.Common.Field.ItemData
            Public 完納区分 As BaseCore.Common.Field.ItemData
            Public 発注用摘要1 As BaseCore.Common.Field.ItemData
            Public 発注用摘要2 As BaseCore.Common.Field.ItemData
            Public 発注用摘要3 As BaseCore.Common.Field.ItemData

            Public 仕入先名 As BaseCore.Common.Field.ItemData
            Public 仕入先指定区分名 As BaseCore.Common.Field.ItemData
            Public 単価区分名 As BaseCore.Common.Field.ItemData
            Public 納入区分名 As BaseCore.Common.Field.ItemData
            Public 支給区分名 As BaseCore.Common.Field.ItemData
            Public 希望時間帯区分名 As BaseCore.Common.Field.ItemData
            Public 完納区分名 As BaseCore.Common.Field.ItemData

            '''========================================================================================
            ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
            '''========================================================================================
            Public Sub New(ByVal Config As NodeCore.Common.Config)
                Dim tbl基本 As New NodeDatabase.DataSetView.V0受注基本DataTable
                Dim tbl発注 As New NodeDatabase.DataSetView.V0受注紙発注DataTable

                '----------------------------------------------------------------------
                ' ｲﾝｽﾀﾝｽ(基本)
                '----------------------------------------------------------------------
                Me.巻取区分 = New BaseCore.Common.Field.ItemData(tbl基本.巻取区分Column)
                Me.巻取区分名 = New BaseCore.Common.Field.ItemData(tbl基本.巻取区分名Column)
                Me.出し方向区分 = New BaseCore.Common.Field.ItemData(tbl基本.出し方向区分Column)
                Me.出し方向区分名 = New BaseCore.Common.Field.ItemData(tbl基本.出し方向区分名Column)
                Me.紙管 = New BaseCore.Common.Field.ItemData(tbl基本.紙管Column, 5, 0)
                Me.発行枚数 = New BaseCore.Common.Field.ItemData(tbl基本.発行枚数Column, 5, 0)
                Me.スリッター区分 = New BaseCore.Common.Field.ItemData(tbl基本.スリッター区分Column)
                Me.スリッター区分名 = New BaseCore.Common.Field.ItemData(tbl基本.スリッター区分名Column)
                Me.スリッター巾 = New BaseCore.Common.Field.ItemData(tbl基本.スリッター巾Column, 6, 1)
                Me.カット1 = New BaseCore.Common.Field.ItemData(tbl基本.カット1Column, 5, 0)
                Me.カット2 = New BaseCore.Common.Field.ItemData(tbl基本.カット2Column, 5, 0)
                Me.カット3 = New BaseCore.Common.Field.ItemData(tbl基本.カット3Column, 5, 0)
                Me.包装枚数 = New BaseCore.Common.Field.ItemData(tbl基本.包装枚数Column, 5, 0)
                Me.送りピッチ = New BaseCore.Common.Field.ItemData(tbl基本.送りピッチColumn, 6, 3)
                Me.社内外区分 = New BaseCore.Common.Field.ItemData(tbl基本.社内外区分Column)

                Me.紙CD = New BaseCore.Common.Field.ItemData(tbl発注.紙CDColumn)
                Me.紙名 = New BaseCore.Common.Field.ItemData(tbl発注.紙名Column)
                Me.糊CD = New BaseCore.Common.Field.ItemData(tbl発注.糊CDColumn)
                Me.糊名 = New BaseCore.Common.Field.ItemData(tbl発注.糊名Column)
                Me.台紙CD = New BaseCore.Common.Field.ItemData(tbl発注.台紙CDColumn)
                Me.台紙名 = New BaseCore.Common.Field.ItemData(tbl発注.台紙名Column)
                Me.寸法巾 = New BaseCore.Common.Field.ItemData(tbl発注.寸法巾Column, 3, 0)
                Me.寸法長 = New BaseCore.Common.Field.ItemData(tbl発注.寸法長Column, 6, 0)
                Me.仕入先指定区分 = New BaseCore.Common.Field.ItemData(tbl発注.仕入先指定区分Column)
                Me.仕入先CD = New BaseCore.Common.Field.ItemData(tbl発注.仕入先CDColumn)
                Me.支社CD = New BaseCore.Common.Field.ItemData(tbl発注.支社CDColumn)
                Me.単価区分 = New BaseCore.Common.Field.ItemData(tbl発注.単価区分Column)
                Me.発注単価 = New BaseCore.Common.Field.ItemData(tbl発注.発注単価Column, 7, 2)
                Me.社内単価 = New BaseCore.Common.Field.ItemData(tbl発注.社内単価Column, 7, 2)
                Me.納入区分 = New BaseCore.Common.Field.ItemData(tbl発注.納入区分Column)
                Me.支給区分 = New BaseCore.Common.Field.ItemData(tbl発注.支給区分Column)
                Me.有償支給単価 = New BaseCore.Common.Field.ItemData(tbl発注.有償支給単価Column, 5, 2)
                Me.発注日付 = New BaseCore.Common.Field.ItemData(tbl発注.発注日付Column)
                Me.通数 = New BaseCore.Common.Field.ItemData(tbl発注.通数Column, 9, 0)
                Me.送りMM = New BaseCore.Common.Field.ItemData(tbl発注.送りMMColumn, 8, 3)
                Me.刷出M = New BaseCore.Common.Field.ItemData(tbl発注.刷出MColumn, 5, 0)
                Me.つなぎロス = New BaseCore.Common.Field.ItemData(tbl発注.つなぎロスColumn, 5, 2)
                Me.その他M = New BaseCore.Common.Field.ItemData(tbl発注.その他MColumn, 5, 0)
                Me.希望納期日付 = New BaseCore.Common.Field.ItemData(tbl発注.希望納期日付Column)
                Me.希望時間帯区分 = New BaseCore.Common.Field.ItemData(tbl発注.希望時間帯区分Column)
                Me.基準長 = New BaseCore.Common.Field.ItemData(tbl発注.基準長Column, 4, 0)
                Me.完納区分 = New BaseCore.Common.Field.ItemData(tbl発注.完納区分Column)
                Me.発注用摘要1 = New BaseCore.Common.Field.ItemData(tbl発注.発注用摘要1Column)
                Me.発注用摘要2 = New BaseCore.Common.Field.ItemData(tbl発注.発注用摘要2Column)
                Me.発注用摘要3 = New BaseCore.Common.Field.ItemData(tbl発注.発注用摘要3Column)

                Me.仕入先名 = New BaseCore.Common.Field.ItemData(tbl発注.仕入先名Column)
                Me.仕入先指定区分名 = New BaseCore.Common.Field.ItemData(tbl発注.仕入先指定区分名Column)
                Me.単価区分名 = New BaseCore.Common.Field.ItemData(tbl発注.単価区分名Column)
                Me.納入区分名 = New BaseCore.Common.Field.ItemData(tbl発注.納入区分名Column)
                Me.支給区分名 = New BaseCore.Common.Field.ItemData(tbl発注.支給区分名Column)
                Me.希望時間帯区分名 = New BaseCore.Common.Field.ItemData(tbl発注.希望時間帯区分名Column)
                Me.完納区分名 = New BaseCore.Common.Field.ItemData(tbl発注.完納区分名Column)
            End Sub
        End Class

        Public Class Detail2
            ''' ----------------------------------------------------------------------------------------
            ''' <SUMMARY>列項目(基本)</SUMMARY>
            ''' ----------------------------------------------------------------------------------------
            Public 作業NO As BaseCore.Common.Field.ItemData
            Public 紙CD As BaseCore.Common.Field.ItemData
            Public 紙名 As BaseCore.Common.Field.ItemData
            Public 糊CD As BaseCore.Common.Field.ItemData
            Public 糊名 As BaseCore.Common.Field.ItemData
            Public 台紙CD As BaseCore.Common.Field.ItemData
            Public 台紙名 As BaseCore.Common.Field.ItemData
            Public 寸法巾 As BaseCore.Common.Field.ItemData
            Public 寸法長 As BaseCore.Common.Field.ItemData
            Public 仕入先指定区分 As BaseCore.Common.Field.ItemData
            Public 仕入先CD As BaseCore.Common.Field.ItemData
            Public 支社CD As BaseCore.Common.Field.ItemData
            Public 単価区分 As BaseCore.Common.Field.ItemData
            Public 発注単価 As BaseCore.Common.Field.ItemData
            Public 社内単価 As BaseCore.Common.Field.ItemData
            Public 納入区分 As BaseCore.Common.Field.ItemData
            Public 支給区分 As BaseCore.Common.Field.ItemData
            Public 有償支給単価 As BaseCore.Common.Field.ItemData
            Public 発注日付 As BaseCore.Common.Field.ItemData
            Public 通数 As BaseCore.Common.Field.ItemData
            Public 送りMM As BaseCore.Common.Field.ItemData
            Public 刷出M As BaseCore.Common.Field.ItemData
            Public つなぎロス As BaseCore.Common.Field.ItemData
            Public その他M As BaseCore.Common.Field.ItemData
            Public 希望納期日付 As BaseCore.Common.Field.ItemData
            Public 希望時間帯区分 As BaseCore.Common.Field.ItemData
            Public 基準長 As BaseCore.Common.Field.ItemData
            Public 完納区分 As BaseCore.Common.Field.ItemData
            Public 発注用摘要1 As BaseCore.Common.Field.ItemData
            Public 発注用摘要2 As BaseCore.Common.Field.ItemData
            Public 発注用摘要3 As BaseCore.Common.Field.ItemData

            Public 仕入先名 As BaseCore.Common.Field.ItemData
            Public 仕入先指定区分名 As BaseCore.Common.Field.ItemData
            Public 単価区分名 As BaseCore.Common.Field.ItemData
            Public 納入区分名 As BaseCore.Common.Field.ItemData
            Public 支給区分名 As BaseCore.Common.Field.ItemData
            Public 希望時間帯区分名 As BaseCore.Common.Field.ItemData
            Public 完納区分名 As BaseCore.Common.Field.ItemData

            '''========================================================================================
            ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
            '''========================================================================================
            Public Sub New(ByVal Config As NodeCore.Common.Config)
                Dim tbl As New NodeDatabase.DataSetView.V0受注紙発注DataTable

                '----------------------------------------------------------------------
                ' ｲﾝｽﾀﾝｽ(基本)
                '----------------------------------------------------------------------
                Me.作業NO = New BaseCore.Common.Field.ItemData(tbl.作業NOColumn)
                Me.紙CD = New BaseCore.Common.Field.ItemData(tbl.紙CDColumn)
                Me.紙名 = New BaseCore.Common.Field.ItemData(tbl.紙名Column)
                Me.糊CD = New BaseCore.Common.Field.ItemData(tbl.糊CDColumn)
                Me.糊名 = New BaseCore.Common.Field.ItemData(tbl.糊名Column)
                Me.台紙CD = New BaseCore.Common.Field.ItemData(tbl.台紙CDColumn)
                Me.台紙名 = New BaseCore.Common.Field.ItemData(tbl.台紙名Column)
                Me.寸法巾 = New BaseCore.Common.Field.ItemData(tbl.寸法巾Column, 3, 0)
                Me.寸法長 = New BaseCore.Common.Field.ItemData(tbl.寸法長Column, 6, 0)
                Me.仕入先指定区分 = New BaseCore.Common.Field.ItemData(tbl.仕入先指定区分Column)
                Me.仕入先CD = New BaseCore.Common.Field.ItemData(tbl.仕入先CDColumn)
                Me.支社CD = New BaseCore.Common.Field.ItemData(tbl.支社CDColumn)
                Me.単価区分 = New BaseCore.Common.Field.ItemData(tbl.単価区分Column)
                Me.発注単価 = New BaseCore.Common.Field.ItemData(tbl.発注単価Column, 7, 2)
                Me.社内単価 = New BaseCore.Common.Field.ItemData(tbl.社内単価Column, 7, 2)
                Me.納入区分 = New BaseCore.Common.Field.ItemData(tbl.納入区分Column)
                Me.支給区分 = New BaseCore.Common.Field.ItemData(tbl.支給区分Column)
                Me.有償支給単価 = New BaseCore.Common.Field.ItemData(tbl.有償支給単価Column, 5, 2)
                Me.発注日付 = New BaseCore.Common.Field.ItemData(tbl.発注日付Column)
                Me.通数 = New BaseCore.Common.Field.ItemData(tbl.通数Column, 9, 0)
                Me.送りMM = New BaseCore.Common.Field.ItemData(tbl.送りMMColumn, 8, 3)
                Me.刷出M = New BaseCore.Common.Field.ItemData(tbl.刷出MColumn, 5, 0)
                Me.つなぎロス = New BaseCore.Common.Field.ItemData(tbl.つなぎロスColumn, 5, 2)
                Me.その他M = New BaseCore.Common.Field.ItemData(tbl.その他MColumn, 5, 0)
                Me.希望納期日付 = New BaseCore.Common.Field.ItemData(tbl.希望納期日付Column)
                Me.希望時間帯区分 = New BaseCore.Common.Field.ItemData(tbl.希望時間帯区分Column)
                Me.基準長 = New BaseCore.Common.Field.ItemData(tbl.基準長Column, 4, 0)
                Me.完納区分 = New BaseCore.Common.Field.ItemData(tbl.完納区分Column)
                Me.発注用摘要1 = New BaseCore.Common.Field.ItemData(tbl.発注用摘要1Column)
                Me.発注用摘要2 = New BaseCore.Common.Field.ItemData(tbl.発注用摘要2Column)
                Me.発注用摘要3 = New BaseCore.Common.Field.ItemData(tbl.発注用摘要3Column)

                Me.仕入先名 = New BaseCore.Common.Field.ItemData(tbl.仕入先名Column)
                Me.仕入先指定区分名 = New BaseCore.Common.Field.ItemData(tbl.仕入先指定区分名Column)
                Me.単価区分名 = New BaseCore.Common.Field.ItemData(tbl.単価区分名Column)
                Me.納入区分名 = New BaseCore.Common.Field.ItemData(tbl.納入区分名Column)
                Me.支給区分名 = New BaseCore.Common.Field.ItemData(tbl.支給区分名Column)
                Me.希望時間帯区分名 = New BaseCore.Common.Field.ItemData(tbl.希望時間帯区分名Column)
                Me.完納区分名 = New BaseCore.Common.Field.ItemData(tbl.完納区分名Column)
            End Sub
        End Class
#End Region

#Region "外注発注"
        Public Class HeaderOut
            ''' ----------------------------------------------------------------------------------------
            ''' <SUMMARY>列項目(基本)</SUMMARY>
            ''' ----------------------------------------------------------------------------------------
            Public 外注先CD As BaseCore.Common.Field.ItemData
            Public 発注単価 As BaseCore.Common.Field.ItemData
            Public 発注金額 As BaseCore.Common.Field.ItemData
            Public 発注納期 As BaseCore.Common.Field.ItemData

            Public 発注単価商品 As BaseCore.Common.Field.ItemData

            Public 外注先名 As BaseCore.Common.Field.ItemData

            '''========================================================================================
            ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
            '''========================================================================================
            Public Sub New(ByVal Config As NodeCore.Common.Config)
                Dim tbl基本 As New NodeDatabase.DataSetView.V0受注基本DataTable
                Dim tbl商品 As New NodeDatabase.DataSetView.V0受注商品内訳DataTable

                Me.外注先CD = New BaseCore.Common.Field.ItemData(tbl基本.外注先CDColumn)
                Me.発注単価 = New BaseCore.Common.Field.ItemData(tbl基本.発注単価Column, 9, 2)
                Me.発注金額 = New BaseCore.Common.Field.ItemData(tbl基本.発注金額Column, 9, 0)
                Me.発注納期 = New BaseCore.Common.Field.ItemData(tbl基本.発注納期Column)

                Me.発注単価商品 = New BaseCore.Common.Field.ItemData(tbl商品.発注単価Column)

                Me.外注先名 = New BaseCore.Common.Field.ItemData(tbl基本.外注先名Column)
            End Sub
        End Class
#End Region

        Public Class Paramater
            Public HeaderBase As HeaderBase
            Public HeaderItem As HeaderItem
            Public HeaderPaper As HeaderPaper
            Public HeaderOut As HeaderOut
            Public Detail1 As New List(Of Detail1)
            Public Detail2 As New List(Of Detail2)
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

            Me.Fields.HeaderBase = New HeaderBase(Config)
            Me.Fields.HeaderItem = New HeaderItem(Config)
            Me.Fields.HeaderPaper = New HeaderPaper(Config)
            Me.Fields.HeaderOut = New HeaderOut(Config)
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
                Me.Fields.HeaderBase.処理登録.Value = NodeContents.Constant.CodeValue.フラグ.オン
                Me.Fields.HeaderBase.処理修正.Value = NodeContents.Constant.CodeValue.フラグ.オフ
                Me.Fields.HeaderBase.処理削除.Value = NodeContents.Constant.CodeValue.フラグ.オフ

                Me.Fields.HeaderBase.作業NO.Value = Nothing
                Me.Fields.HeaderBase.本台帳NO.Value = Nothing
            End If

            '----------------------------------------------------------------------
            ' ﾃﾞｰﾀ部ｸﾘｱ
            '----------------------------------------------------------------------
            ' 受注基本
            Me.Fields.HeaderBase.御客様NO.Value = Nothing
            Me.Fields.HeaderBase.枝番.Value = Nothing
            Me.Fields.HeaderBase.受注日付.Value = Nothing
            Me.Fields.HeaderBase.納品日付A.Value = Nothing
            Me.Fields.HeaderBase.納品日付B.Value = Nothing
            Me.Fields.HeaderBase.確約区分.Value = Nothing
            Me.Fields.HeaderBase.入力担当者CD.Value = Nothing
            Me.Fields.HeaderBase.得意先CD.Value = Nothing
            Me.Fields.HeaderBase.請求先CD.Value = Nothing
            Me.Fields.HeaderBase.定番フラグ.Value = Nothing
            Me.Fields.HeaderBase.代表商品名.Value = Nothing
            Me.Fields.HeaderBase.顧客商品CD.Value = Nothing
            Me.Fields.HeaderBase.顧客商品CDALL.Value = Nothing
            Me.Fields.HeaderBase.受注数合計.Value = Nothing
            Me.Fields.HeaderBase.内在庫引当数合計.Value = Nothing
            Me.Fields.HeaderBase.通数合計.Value = Nothing
            Me.Fields.HeaderBase.通数1.Value = Nothing
            Me.Fields.HeaderBase.通数2.Value = Nothing
            Me.Fields.HeaderBase.通数3.Value = Nothing
            Me.Fields.HeaderBase.受注単価.Value = Nothing
            Me.Fields.HeaderBase.単位区分.Value = Nothing
            Me.Fields.HeaderBase.受注金額.Value = Nothing
            Me.Fields.HeaderBase.原価決定日付.Value = Nothing
            Me.Fields.HeaderBase.通数累計.Value = Nothing
            Me.Fields.HeaderBase.売上数累計.Value = Nothing
            Me.Fields.HeaderBase.入庫数累計.Value = Nothing
            Me.Fields.HeaderBase.売上金額.Value = Nothing
            Me.Fields.HeaderBase.仕入金額.Value = Nothing
            Me.Fields.HeaderBase.固定経費.Value = Nothing
            Me.Fields.HeaderBase.入金区分.Value = Nothing
            Me.Fields.HeaderBase.印刷場所CD.Value = Nothing
            Me.Fields.HeaderBase.受注区分.Value = Nothing
            Me.Fields.HeaderBase.刃型NO.Value = Nothing
            Me.Fields.HeaderBase.版NO.Value = Nothing
            Me.Fields.HeaderBase.ギヤ数.Value = Nothing
            Me.Fields.HeaderBase.発送仕上特記事項.Value = Nothing
            Me.Fields.HeaderOut.外注先CD.Value = Nothing
            Me.Fields.HeaderOut.発注単価.Value = Nothing
            Me.Fields.HeaderOut.発注金額.Value = Nothing
            Me.Fields.HeaderOut.発注納期.Value = Nothing
            Me.Fields.HeaderBase.作業伝票一括発行日付本社.Value = Nothing
            Me.Fields.HeaderBase.作業伝票一括発行日付河北.Value = Nothing
            Me.Fields.HeaderBase.受注ラベル印字フラグ本社.Value = Nothing
            Me.Fields.HeaderBase.受注ラベル印字フラグ河北.Value = Nothing
            Me.Fields.HeaderBase.廃棄年月.Value = Nothing

            Me.Fields.HeaderBase.得意先名.Value = Nothing
            Me.Fields.HeaderBase.請求先名.Value = Nothing
            Me.Fields.HeaderBase.担当者名.Value = Nothing
            Me.Fields.HeaderBase.印刷場所名.Value = Nothing
            Me.Fields.HeaderBase.確約区分名.Value = Nothing
            Me.Fields.HeaderBase.単位区分名.Value = Nothing
            Me.Fields.HeaderBase.入金区分名.Value = Nothing
            Me.Fields.HeaderBase.受注区分名.Value = Nothing
            Me.Fields.HeaderBase.社内外区分名.Value = Nothing
            Me.Fields.HeaderBase.内製造数合計.Value = Nothing

            Me.Fields.HeaderBase.売上金額01.Value = Nothing
            Me.Fields.HeaderBase.売上区分01.Value = Nothing
            Me.Fields.HeaderBase.売上名01.Value = Nothing
            Me.Fields.HeaderBase.売上数量01.Value = Nothing
            Me.Fields.HeaderBase.売上単価01.Value = Nothing
            Me.Fields.HeaderBase.売上金額02.Value = Nothing
            Me.Fields.HeaderBase.売上区分02.Value = Nothing
            Me.Fields.HeaderBase.売上名02.Value = Nothing
            Me.Fields.HeaderBase.売上数量02.Value = Nothing
            Me.Fields.HeaderBase.売上単価02.Value = Nothing
            Me.Fields.HeaderBase.売上金額03.Value = Nothing
            Me.Fields.HeaderBase.売上区分03.Value = Nothing
            Me.Fields.HeaderBase.売上名03.Value = Nothing
            Me.Fields.HeaderBase.売上数量03.Value = Nothing
            Me.Fields.HeaderBase.売上単価03.Value = Nothing
            Me.Fields.HeaderBase.売上金額04.Value = Nothing
            Me.Fields.HeaderBase.売上区分04.Value = Nothing
            Me.Fields.HeaderBase.売上名04.Value = Nothing
            Me.Fields.HeaderBase.売上数量04.Value = Nothing
            Me.Fields.HeaderBase.売上単価04.Value = Nothing
            Me.Fields.HeaderBase.売上金額05.Value = Nothing
            Me.Fields.HeaderBase.売上区分05.Value = Nothing
            Me.Fields.HeaderBase.売上名05.Value = Nothing
            Me.Fields.HeaderBase.売上数量05.Value = Nothing
            Me.Fields.HeaderBase.売上単価05.Value = Nothing

            Me.Fields.HeaderBase.作業注意01.Value = Nothing
            Me.Fields.HeaderBase.作業注意02.Value = Nothing
            Me.Fields.HeaderBase.作業注意03.Value = Nothing
            Me.Fields.HeaderBase.作業注意04.Value = Nothing
            Me.Fields.HeaderBase.作業注意05.Value = Nothing
            Me.Fields.HeaderBase.作業注意06.Value = Nothing
            Me.Fields.HeaderBase.作業注意07.Value = Nothing
            Me.Fields.HeaderBase.作業注意08.Value = Nothing
            Me.Fields.HeaderBase.作業注意09.Value = Nothing
            Me.Fields.HeaderBase.作業注意10.Value = Nothing

            Me.Fields.HeaderBase.出荷注意01.Value = Nothing
            Me.Fields.HeaderBase.出荷注意02.Value = Nothing
            Me.Fields.HeaderBase.出荷注意03.Value = Nothing
            Me.Fields.HeaderBase.出荷注意04.Value = Nothing
            Me.Fields.HeaderBase.出荷注意05.Value = Nothing
            Me.Fields.HeaderBase.出荷注意06.Value = Nothing
            Me.Fields.HeaderBase.出荷注意07.Value = Nothing
            Me.Fields.HeaderBase.出荷注意08.Value = Nothing
            Me.Fields.HeaderBase.出荷注意09.Value = Nothing
            Me.Fields.HeaderBase.出荷注意10.Value = Nothing

            Me.Fields.HeaderBase.出荷先CD01.Value = Nothing
            Me.Fields.HeaderBase.出荷先名01.Value = Nothing
            Me.Fields.HeaderBase.出荷先CD02.Value = Nothing
            Me.Fields.HeaderBase.出荷先名02.Value = Nothing
            Me.Fields.HeaderBase.出荷先CD03.Value = Nothing
            Me.Fields.HeaderBase.出荷先名03.Value = Nothing
            Me.Fields.HeaderBase.出荷先CD04.Value = Nothing
            Me.Fields.HeaderBase.出荷先名04.Value = Nothing

            ' 商品内訳
            Me.Fields.HeaderItem.枝番.Value = Nothing
            Me.Fields.HeaderItem.定番CD.Value = Nothing
            Me.Fields.HeaderItem.商品名.Value = Nothing
            Me.Fields.HeaderItem.受注数.Value = Nothing
            Me.Fields.HeaderItem.内在庫引当数.Value = Nothing
            Me.Fields.HeaderItem.受注単価.Value = Nothing
            Me.Fields.HeaderItem.納品日付A.Value = Nothing
            Me.Fields.HeaderItem.納品日付B.Value = Nothing
            Me.Fields.HeaderItem.顧客商品CD.Value = Nothing
            Me.Fields.HeaderItem.顧客発注NO.Value = Nothing
            Me.Fields.HeaderItem.倉庫NO.Value = Nothing
            Me.Fields.HeaderItem.備考.Value = Nothing
            Me.Fields.HeaderItem.内製造数.Value = Nothing

            ' 紙発注
            Me.Fields.HeaderPaper.巻取区分.Value = Nothing
            Me.Fields.HeaderPaper.巻取区分名.Value = Nothing
            Me.Fields.HeaderPaper.出し方向区分.Value = Nothing
            Me.Fields.HeaderPaper.出し方向区分名.Value = Nothing
            Me.Fields.HeaderPaper.紙管.Value = Nothing
            Me.Fields.HeaderPaper.発行枚数.Value = Nothing
            Me.Fields.HeaderPaper.スリッター区分.Value = Nothing
            Me.Fields.HeaderPaper.スリッター区分名.Value = Nothing
            Me.Fields.HeaderPaper.スリッター巾.Value = Nothing
            Me.Fields.HeaderPaper.カット1.Value = Nothing
            Me.Fields.HeaderPaper.カット2.Value = Nothing
            Me.Fields.HeaderPaper.カット3.Value = Nothing
            Me.Fields.HeaderPaper.包装枚数.Value = Nothing
            Me.Fields.HeaderPaper.送りピッチ.Value = Nothing
            Me.Fields.HeaderPaper.社内外区分.Value = Nothing

            ' 外注発注
            Me.Fields.HeaderOut.外注先名.Value = Nothing

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return True
        End Function
#End Region

#Region "Exist(廃棄)"
        '''========================================================================================
        ''' <SUMMARY>廃棄存在</SUMMARY>
        ''' <RETURNS>True:あり(廃棄ﾃﾞｰﾀ), False:なし(廃棄でない)</RETURNS>
        '''========================================================================================
        Public Function Exist_Scrap() As Boolean
            Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0受注基本TableAdapter
            Dim tbl As New NodeDatabase.DataSetView.V0受注基本DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            Dim str作業NO As String = Me.KeyNO_Value    ' 本台帳NO/作業NO算出
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.作業NOColumn.ColumnName, str作業NO, BaseDatabase.Contents.Compare.Equal))
            qry.Add(New BaseDatabase.Condition(tbl.廃棄年月Column.ColumnName, "0000/00", BaseDatabase.Contents.Compare.NotEqual))

            '----------------------------------------------------------------------
            ' 読込
            '----------------------------------------------------------------------
            tbl = ada.SelectByCommon(qry)

            '----------------------------------------------------------------------
            ' 返却
            '----------------------------------------------------------------------
            Return (tbl.Rows.Count > 0)
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
            ' T受注基本
            '----------------------------------------------------------------------
            Dim ada基本 As New NodeDatabase.DataSetViewTableAdapters.V0受注基本TableAdapter
            Dim tbl基本 As New NodeDatabase.DataSetView.V0受注基本DataTable
            Dim qry基本 As New Collection

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            Dim str作業NO As String = Me.KeyNO_Value    ' 本台帳NO/作業NO算出
            qry基本.Clear()
            qry基本.Add(New BaseDatabase.Condition(tbl基本.作業NOColumn.ColumnName, str作業NO, BaseDatabase.Contents.Compare.Equal))
            tbl基本 = ada基本.SelectByCommon(qry基本)
            If tbl基本.Count = 0 Then
                Return False
            End If

            Me.Fields.HeaderBase.作業NO.Value = tbl基本(0).Item(tbl基本.作業NOColumn.ColumnName)
            Me.Fields.HeaderBase.本台帳NO.Value = tbl基本(0).Item(tbl基本.本台帳NOColumn.ColumnName)
            Me.Fields.HeaderBase.御客様NO.Value = tbl基本(0).Item(tbl基本.御客様NOColumn.ColumnName)
            Me.Fields.HeaderBase.枝番.Value = tbl基本(0).Item(tbl基本.枝番Column.ColumnName)
            Me.Fields.HeaderBase.受注日付.Value = tbl基本(0).Item(tbl基本.受注日付Column.ColumnName)
            Me.Fields.HeaderBase.納品日付A.Value = tbl基本(0).Item(tbl基本.納品日付AColumn.ColumnName)
            Me.Fields.HeaderBase.納品日付B.Value = tbl基本(0).Item(tbl基本.納品日付BColumn.ColumnName)
            Me.Fields.HeaderBase.確約区分.Value = tbl基本(0).Item(tbl基本.確約区分Column.ColumnName)
            Me.Fields.HeaderBase.入力担当者CD.Value = tbl基本(0).Item(tbl基本.入力担当者CDColumn.ColumnName)
            Me.Fields.HeaderBase.得意先CD.Value = tbl基本(0).Item(tbl基本.得意先CDColumn.ColumnName)
            Me.Fields.HeaderBase.請求先CD.Value = tbl基本(0).Item(tbl基本.請求先CDColumn.ColumnName)
            Me.Fields.HeaderBase.定番フラグ.Value = tbl基本(0).Item(tbl基本.定番フラグColumn.ColumnName)
            Me.Fields.HeaderBase.代表商品名.Value = tbl基本(0).Item(tbl基本.代表商品名Column.ColumnName)
            Me.Fields.HeaderBase.顧客商品CD.Value = tbl基本(0).Item(tbl基本.顧客商品CDColumn.ColumnName)
            Me.Fields.HeaderBase.顧客商品CDALL.Value = tbl基本(0).Item(tbl基本.顧客商品CDALLColumn.ColumnName)
            Me.Fields.HeaderBase.受注数合計.Value = tbl基本(0).Item(tbl基本.受注数合計Column.ColumnName)
            Me.Fields.HeaderBase.内在庫引当数合計.Value = tbl基本(0).Item(tbl基本.内在庫引当数合計Column.ColumnName)
            Me.Fields.HeaderBase.通数合計.Value = tbl基本(0).Item(tbl基本.通数合計Column.ColumnName)
            Me.Fields.HeaderBase.通数1.Value = tbl基本(0).Item(tbl基本.通数1Column.ColumnName)
            Me.Fields.HeaderBase.通数2.Value = tbl基本(0).Item(tbl基本.通数2Column.ColumnName)
            Me.Fields.HeaderBase.通数3.Value = tbl基本(0).Item(tbl基本.通数3Column.ColumnName)
            Me.Fields.HeaderBase.受注単価.Value = tbl基本(0).Item(tbl基本.受注単価Column.ColumnName)
            Me.Fields.HeaderBase.単位区分.Value = tbl基本(0).Item(tbl基本.単位区分Column.ColumnName)
            Me.Fields.HeaderBase.受注金額.Value = tbl基本(0).Item(tbl基本.受注金額Column.ColumnName)
            Me.Fields.HeaderBase.原価決定日付.Value = tbl基本(0).Item(tbl基本.原価決定日付Column.ColumnName)
            Me.Fields.HeaderBase.通数累計.Value = tbl基本(0).Item(tbl基本.通数累計Column.ColumnName)
            Me.Fields.HeaderBase.売上数累計.Value = tbl基本(0).Item(tbl基本.売上数累計Column.ColumnName)
            Me.Fields.HeaderBase.入庫数累計.Value = tbl基本(0).Item(tbl基本.入庫数累計Column.ColumnName)
            Me.Fields.HeaderBase.売上金額.Value = tbl基本(0).Item(tbl基本.売上金額Column.ColumnName)
            Me.Fields.HeaderBase.仕入金額.Value = tbl基本(0).Item(tbl基本.仕入金額Column.ColumnName)
            Me.Fields.HeaderBase.固定経費.Value = tbl基本(0).Item(tbl基本.固定経費Column.ColumnName)
            Me.Fields.HeaderBase.入金区分.Value = tbl基本(0).Item(tbl基本.入金区分Column.ColumnName)
            Me.Fields.HeaderBase.印刷場所CD.Value = tbl基本(0).Item(tbl基本.印刷場所CDColumn.ColumnName)
            Me.Fields.HeaderBase.受注区分.Value = tbl基本(0).Item(tbl基本.受注区分Column.ColumnName)
            Me.Fields.HeaderBase.刃型NO.Value = tbl基本(0).Item(tbl基本.刃型NOColumn.ColumnName)
            Me.Fields.HeaderBase.版NO.Value = tbl基本(0).Item(tbl基本.版NOColumn.ColumnName)
            Me.Fields.HeaderBase.ギヤ数.Value = tbl基本(0).Item(tbl基本.ギヤ数Column.ColumnName)
            Me.Fields.HeaderBase.発送仕上特記事項.Value = tbl基本(0).Item(tbl基本.発送仕上特記事項Column.ColumnName)
            Me.Fields.HeaderPaper.巻取区分.Value = tbl基本(0).Item(tbl基本.巻取区分Column.ColumnName)
            Me.Fields.HeaderPaper.巻取区分名.Value = tbl基本(0).Item(tbl基本.巻取区分名Column.ColumnName)
            Me.Fields.HeaderPaper.出し方向区分.Value = tbl基本(0).Item(tbl基本.出し方向区分Column.ColumnName)
            Me.Fields.HeaderPaper.出し方向区分名.Value = tbl基本(0).Item(tbl基本.出し方向区分名Column.ColumnName)
            Me.Fields.HeaderPaper.紙管.Value = tbl基本(0).Item(tbl基本.紙管Column.ColumnName)
            Me.Fields.HeaderPaper.発行枚数.Value = tbl基本(0).Item(tbl基本.発行枚数Column.ColumnName)
            Me.Fields.HeaderPaper.スリッター区分.Value = tbl基本(0).Item(tbl基本.スリッター区分Column.ColumnName)
            Me.Fields.HeaderPaper.スリッター区分名.Value = tbl基本(0).Item(tbl基本.スリッター区分名Column.ColumnName)
            Me.Fields.HeaderPaper.スリッター巾.Value = tbl基本(0).Item(tbl基本.スリッター巾Column.ColumnName)
            Me.Fields.HeaderPaper.カット1.Value = tbl基本(0).Item(tbl基本.カット1Column.ColumnName)
            Me.Fields.HeaderPaper.カット2.Value = tbl基本(0).Item(tbl基本.カット2Column.ColumnName)
            Me.Fields.HeaderPaper.カット3.Value = tbl基本(0).Item(tbl基本.カット3Column.ColumnName)
            Me.Fields.HeaderPaper.包装枚数.Value = tbl基本(0).Item(tbl基本.包装枚数Column.ColumnName)
            Me.Fields.HeaderPaper.送りピッチ.Value = tbl基本(0).Item(tbl基本.送りピッチColumn.ColumnName)
            Me.Fields.HeaderPaper.社内外区分.Value = tbl基本(0).Item(tbl基本.社内外区分Column.ColumnName)
            Me.Fields.HeaderOut.外注先CD.Value = tbl基本(0).Item(tbl基本.外注先CDColumn.ColumnName)
            Me.Fields.HeaderOut.発注単価.Value = tbl基本(0).Item(tbl基本.発注単価Column.ColumnName)
            Me.Fields.HeaderOut.発注金額.Value = tbl基本(0).Item(tbl基本.発注金額Column.ColumnName)
            Me.Fields.HeaderOut.発注納期.Value = tbl基本(0).Item(tbl基本.発注納期Column.ColumnName)
            Me.Fields.HeaderBase.作業伝票一括発行日付本社.Value = tbl基本(0).Item(tbl基本.作業伝票一括発行日付本社Column.ColumnName)
            Me.Fields.HeaderBase.作業伝票一括発行日付河北.Value = tbl基本(0).Item(tbl基本.作業伝票一括発行日付河北Column.ColumnName)
            Me.Fields.HeaderBase.受注ラベル印字フラグ本社.Value = tbl基本(0).Item(tbl基本.受注ラベル印字フラグ本社Column.ColumnName)
            Me.Fields.HeaderBase.受注ラベル印字フラグ河北.Value = tbl基本(0).Item(tbl基本.受注ラベル印字フラグ河北Column.ColumnName)
            Me.Fields.HeaderBase.廃棄年月.Value = tbl基本(0).Item(tbl基本.廃棄年月Column.ColumnName)

            Me.Fields.HeaderBase.得意先名.Value = tbl基本(0).Item(tbl基本.得意先名Column.ColumnName)
            Me.Fields.HeaderBase.請求先名.Value = tbl基本(0).Item(tbl基本.請求先名Column.ColumnName)
            Me.Fields.HeaderBase.担当者名.Value = tbl基本(0).Item(tbl基本.担当者名Column.ColumnName)
            Me.Fields.HeaderBase.印刷場所名.Value = tbl基本(0).Item(tbl基本.印刷場所名Column.ColumnName)
            Me.Fields.HeaderBase.確約区分名.Value = tbl基本(0).Item(tbl基本.確約区分名Column.ColumnName)
            Me.Fields.HeaderBase.単位区分名.Value = tbl基本(0).Item(tbl基本.単位区分名Column.ColumnName)
            Me.Fields.HeaderBase.入金区分名.Value = tbl基本(0).Item(tbl基本.入金区分名Column.ColumnName)
            Me.Fields.HeaderBase.受注区分名.Value = tbl基本(0).Item(tbl基本.受注区分名Column.ColumnName)
            Me.Fields.HeaderBase.社内外区分名.Value = tbl基本(0).Item(tbl基本.社内外区分名Column.ColumnName)
            Me.Fields.HeaderBase.内製造数合計.Value = tbl基本(0).Item(tbl基本.内製造数合計Column.ColumnName)

            Me.Fields.HeaderOut.外注先名.Value = tbl基本(0).Item(tbl基本.外注先名Column.ColumnName)

            '----------------------------------------------------------------------
            ' T受注売上
            '----------------------------------------------------------------------
            Dim ada売上 As New NodeDatabase.DataSetViewTableAdapters.V0受注売上TableAdapter
            Dim tbl売上 As New NodeDatabase.DataSetView.V0受注売上DataTable
            Dim qry売上 As New Collection

            qry売上.Clear()
            qry売上.Add(New BaseDatabase.Condition(tbl売上.作業NOColumn.ColumnName, str作業NO, BaseDatabase.Contents.Compare.Equal))
            tbl売上 = ada売上.SelectByCommon(qry売上)
            For Each row As DataRow In tbl売上.Rows
                Select Case row.Item(tbl売上.行NOColumn)
                    Case 1
                        Me.Fields.HeaderBase.売上金額01.Value = row.Item(tbl売上.売上金額Column.ColumnName)
                        Me.Fields.HeaderBase.売上区分01.Value = row.Item(tbl売上.売上指示区分Column.ColumnName)
                        Me.Fields.HeaderBase.売上名01.Value = row.Item(tbl売上.売上名Column.ColumnName)
                        Me.Fields.HeaderBase.売上数量01.Value = row.Item(tbl売上.数量Column.ColumnName)
                        Me.Fields.HeaderBase.売上単価01.Value = row.Item(tbl売上.単価Column.ColumnName)
                    Case 2
                        Me.Fields.HeaderBase.売上金額02.Value = row.Item(tbl売上.売上金額Column.ColumnName)
                        Me.Fields.HeaderBase.売上区分02.Value = row.Item(tbl売上.売上指示区分Column.ColumnName)
                        Me.Fields.HeaderBase.売上名02.Value = row.Item(tbl売上.売上名Column.ColumnName)
                        Me.Fields.HeaderBase.売上数量02.Value = row.Item(tbl売上.数量Column.ColumnName)
                        Me.Fields.HeaderBase.売上単価02.Value = row.Item(tbl売上.単価Column.ColumnName)
                    Case 3
                        Me.Fields.HeaderBase.売上金額03.Value = row.Item(tbl売上.売上金額Column.ColumnName)
                        Me.Fields.HeaderBase.売上区分03.Value = row.Item(tbl売上.売上指示区分Column.ColumnName)
                        Me.Fields.HeaderBase.売上名03.Value = row.Item(tbl売上.売上名Column.ColumnName)
                        Me.Fields.HeaderBase.売上数量03.Value = row.Item(tbl売上.数量Column.ColumnName)
                        Me.Fields.HeaderBase.売上単価03.Value = row.Item(tbl売上.単価Column.ColumnName)
                    Case 4
                        Me.Fields.HeaderBase.売上金額04.Value = row.Item(tbl売上.売上金額Column.ColumnName)
                        Me.Fields.HeaderBase.売上区分04.Value = row.Item(tbl売上.売上指示区分Column.ColumnName)
                        Me.Fields.HeaderBase.売上名04.Value = row.Item(tbl売上.売上名Column.ColumnName)
                        Me.Fields.HeaderBase.売上数量04.Value = row.Item(tbl売上.数量Column.ColumnName)
                        Me.Fields.HeaderBase.売上単価04.Value = row.Item(tbl売上.単価Column.ColumnName)
                    Case 5
                        Me.Fields.HeaderBase.売上金額05.Value = row.Item(tbl売上.売上金額Column.ColumnName)
                        Me.Fields.HeaderBase.売上区分05.Value = row.Item(tbl売上.売上指示区分Column.ColumnName)
                        Me.Fields.HeaderBase.売上名05.Value = row.Item(tbl売上.売上名Column.ColumnName)
                        Me.Fields.HeaderBase.売上数量05.Value = row.Item(tbl売上.数量Column.ColumnName)
                        Me.Fields.HeaderBase.売上単価05.Value = row.Item(tbl売上.単価Column.ColumnName)
                End Select
            Next

            '----------------------------------------------------------------------
            ' T受注作業注意
            '----------------------------------------------------------------------
            Dim ada作注 As New NodeDatabase.DataSetViewTableAdapters.V0受注作業注意TableAdapter
            Dim tbl作注 As New NodeDatabase.DataSetView.V0受注作業注意DataTable
            Dim qry作注 As New Collection

            qry作注.Clear()
            qry作注.Add(New BaseDatabase.Condition(tbl作注.作業NOColumn.ColumnName, str作業NO, BaseDatabase.Contents.Compare.Equal))
            tbl作注 = ada作注.SelectByCommon(qry作注)
            For Each row As DataRow In tbl作注.Rows
                Select Case row.Item(tbl作注.行NOColumn)
                    Case 1 : Me.Fields.HeaderBase.作業注意01.Value = row.Item(tbl作注.注意事項Column.ColumnName)
                    Case 2 : Me.Fields.HeaderBase.作業注意02.Value = row.Item(tbl作注.注意事項Column.ColumnName)
                    Case 3 : Me.Fields.HeaderBase.作業注意03.Value = row.Item(tbl作注.注意事項Column.ColumnName)
                    Case 4 : Me.Fields.HeaderBase.作業注意04.Value = row.Item(tbl作注.注意事項Column.ColumnName)
                    Case 5 : Me.Fields.HeaderBase.作業注意05.Value = row.Item(tbl作注.注意事項Column.ColumnName)
                    Case 6 : Me.Fields.HeaderBase.作業注意06.Value = row.Item(tbl作注.注意事項Column.ColumnName)
                    Case 7 : Me.Fields.HeaderBase.作業注意07.Value = row.Item(tbl作注.注意事項Column.ColumnName)
                    Case 8 : Me.Fields.HeaderBase.作業注意08.Value = row.Item(tbl作注.注意事項Column.ColumnName)
                    Case 9 : Me.Fields.HeaderBase.作業注意09.Value = row.Item(tbl作注.注意事項Column.ColumnName)
                    Case 10 : Me.Fields.HeaderBase.作業注意10.Value = row.Item(tbl作注.注意事項Column.ColumnName)
                End Select
            Next

            '----------------------------------------------------------------------
            ' T受注出荷注意
            '----------------------------------------------------------------------
            Dim ada出注 As New NodeDatabase.DataSetViewTableAdapters.V0受注出荷注意TableAdapter
            Dim tbl出注 As New NodeDatabase.DataSetView.V0受注出荷注意DataTable
            Dim qry出注 As New Collection

            qry出注.Clear()
            qry出注.Add(New BaseDatabase.Condition(tbl出注.作業NOColumn.ColumnName, str作業NO, BaseDatabase.Contents.Compare.Equal))
            tbl出注 = ada出注.SelectByCommon(qry出注)
            For Each row As DataRow In tbl出注.Rows
                Select Case row.Item(tbl出注.行NOColumn)
                    Case 1 : Me.Fields.HeaderBase.出荷注意01.Value = row.Item(tbl出注.注意事項Column.ColumnName)
                    Case 2 : Me.Fields.HeaderBase.出荷注意02.Value = row.Item(tbl出注.注意事項Column.ColumnName)
                    Case 3 : Me.Fields.HeaderBase.出荷注意03.Value = row.Item(tbl出注.注意事項Column.ColumnName)
                    Case 4 : Me.Fields.HeaderBase.出荷注意04.Value = row.Item(tbl出注.注意事項Column.ColumnName)
                    Case 5 : Me.Fields.HeaderBase.出荷注意05.Value = row.Item(tbl出注.注意事項Column.ColumnName)
                    Case 6 : Me.Fields.HeaderBase.出荷注意06.Value = row.Item(tbl出注.注意事項Column.ColumnName)
                    Case 7 : Me.Fields.HeaderBase.出荷注意07.Value = row.Item(tbl出注.注意事項Column.ColumnName)
                    Case 8 : Me.Fields.HeaderBase.出荷注意08.Value = row.Item(tbl出注.注意事項Column.ColumnName)
                    Case 9 : Me.Fields.HeaderBase.出荷注意09.Value = row.Item(tbl出注.注意事項Column.ColumnName)
                    Case 10 : Me.Fields.HeaderBase.出荷注意10.Value = row.Item(tbl出注.注意事項Column.ColumnName)
                End Select
            Next

            '----------------------------------------------------------------------
            ' T受注出荷先
            '----------------------------------------------------------------------
            Dim ada出荷 As New NodeDatabase.DataSetViewTableAdapters.V0受注出荷先TableAdapter
            Dim tbl出荷 As New NodeDatabase.DataSetView.V0受注出荷先DataTable
            Dim qry出荷 As New Collection

            qry出荷.Clear()
            qry出荷.Add(New BaseDatabase.Condition(tbl出荷.作業NOColumn.ColumnName, str作業NO, BaseDatabase.Contents.Compare.Equal))
            tbl出荷 = ada出荷.SelectByCommon(qry出荷, tbl出荷.行NOColumn.ColumnName)
            For Each row As DataRow In tbl出荷.Rows
                Select Case row.Item(tbl出荷.行NOColumn)
                    Case 1
                        Me.Fields.HeaderBase.出荷先CD01.Value = row.Item(tbl出荷.出荷先CDColumn.ColumnName)
                        Me.Fields.HeaderBase.出荷先名01.Value = row.Item(tbl出荷.出荷先名Column.ColumnName)
                    Case 2
                        Me.Fields.HeaderBase.出荷先CD02.Value = row.Item(tbl出荷.出荷先CDColumn.ColumnName)
                        Me.Fields.HeaderBase.出荷先名02.Value = row.Item(tbl出荷.出荷先名Column.ColumnName)
                    Case 3
                        Me.Fields.HeaderBase.出荷先CD03.Value = row.Item(tbl出荷.出荷先CDColumn.ColumnName)
                        Me.Fields.HeaderBase.出荷先名03.Value = row.Item(tbl出荷.出荷先名Column.ColumnName)
                    Case 4
                        Me.Fields.HeaderBase.出荷先CD04.Value = row.Item(tbl出荷.出荷先CDColumn.ColumnName)
                        Me.Fields.HeaderBase.出荷先名04.Value = row.Item(tbl出荷.出荷先名Column.ColumnName)
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
            Dim ada基本 As New NodeDatabase.DataSetTranTableAdapters.T受注基本TableAdapter
            Dim tbl基本 As New NodeDatabase.DataSetTran.T受注基本DataTable
            Dim qry基本 As New Collection

            Dim ada売上 As New NodeDatabase.DataSetTranTableAdapters.T受注売上TableAdapter
            Dim tbl売上 As New NodeDatabase.DataSetTran.T受注売上DataTable
            Dim qry売上 As New Collection

            Dim ada作注 As New NodeDatabase.DataSetTranTableAdapters.T受注作業注意TableAdapter
            Dim tbl作注 As New NodeDatabase.DataSetTran.T受注作業注意DataTable
            Dim qry作注 As New Collection

            Dim ada出注 As New NodeDatabase.DataSetTranTableAdapters.T受注出荷注意TableAdapter
            Dim tbl出注 As New NodeDatabase.DataSetTran.T受注出荷注意DataTable
            Dim qry出注 As New Collection

            Dim ada出荷 As New NodeDatabase.DataSetTranTableAdapters.T受注出荷先TableAdapter
            Dim tbl出荷 As New NodeDatabase.DataSetTran.T受注出荷先DataTable
            Dim qry出荷 As New Collection

            Dim ada商品 As New NodeDatabase.DataSetTranTableAdapters.T受注商品内訳TableAdapter
            Dim tbl商品 As New NodeDatabase.DataSetTran.T受注商品内訳DataTable
            Dim qry商品 As New Collection

            Dim ada発注 As New NodeDatabase.DataSetTranTableAdapters.T受注紙発注TableAdapter
            Dim tbl発注 As New NodeDatabase.DataSetTran.T受注紙発注DataTable
            Dim qry発注 As New Collection

            '----------------------------------------------------------------------
            ' 保存
            '----------------------------------------------------------------------
            Try
                '-------------------------------------
                ' 伝票計算
                '-------------------------------------
                ' 商品内訳明細
                If Not Me.Clac_ItemDetail() Then
                    Throw New Exception()
                End If

                ' 通し数
                If Not Me.Clac_PrintQty() Then
                    Throw New Exception()
                End If

                'Using scope As New System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required, TimeSpan.Zero)
                '-------------------------------------
                ' 事前削除
                '-------------------------------------
                If Not Me.Delete_Header() Then
                    Return False
                End If

                '-------------------------------------
                ' 採番
                '-------------------------------------
                If Me.Fields.HeaderBase.作業NO.Value = "" Then
                    Dim Numbering As New NodeCore.Common.Numbering
                    If Not Numbering.Execute(NodeCore.Common.Numbering.ModeContents.作業NO) Then
                        Me.LastError = Numbering.LastError
                        Return False
                    End If
                End If

                '-------------------------------------
                ' 保存
                '-------------------------------------
                ' 受注基本
                ada基本.Insert(Me.Fields.HeaderBase.作業NO.Value _
                             , Me.Fields.HeaderBase.本台帳NO.Value _
                             , Me.Fields.HeaderBase.御客様NO.Value _
                             , Me.Fields.HeaderBase.枝番.Value _
                             , Me.Fields.HeaderBase.受注日付.Value _
                             , Me.Fields.HeaderBase.納品日付A.Value _
                             , Me.Fields.HeaderBase.納品日付B.Value _
                             , Me.Fields.HeaderBase.確約区分.Value _
                             , Me.Fields.HeaderBase.入力担当者CD.Value _
                             , Me.Fields.HeaderBase.得意先CD.Value _
                             , Me.Fields.HeaderBase.請求先CD.Value _
                             , Me.Fields.HeaderBase.定番フラグ.Value _
                             , Me.Fields.HeaderBase.代表商品名.Value _
                             , Me.Fields.HeaderBase.顧客商品CD.Value _
                             , Me.Fields.HeaderBase.顧客商品CDALL.Value _
                             , BaseCore.Common.Text.CVal(Me.Fields.HeaderBase.受注数合計.Value) _
                             , BaseCore.Common.Text.CVal(Me.Fields.HeaderBase.内在庫引当数合計.Value) _
                             , BaseCore.Common.Text.CVal(Me.Fields.HeaderBase.通数合計.Value) _
                             , BaseCore.Common.Text.CVal(Me.Fields.HeaderBase.通数1.Value) _
                             , BaseCore.Common.Text.CVal(Me.Fields.HeaderBase.通数2.Value) _
                             , BaseCore.Common.Text.CVal(Me.Fields.HeaderBase.通数3.Value) _
                             , BaseCore.Common.Text.CVal(Me.Fields.HeaderBase.受注単価.Value) _
                             , Me.Fields.HeaderBase.単位区分.Value _
                             , BaseCore.Common.Text.CVal(Me.Fields.HeaderBase.受注金額.Value) _
                             , Me.Fields.HeaderBase.原価決定日付.Value _
                             , BaseCore.Common.Text.CVal(Me.Fields.HeaderBase.通数累計.Value) _
                             , BaseCore.Common.Text.CVal(Me.Fields.HeaderBase.売上数累計.Value) _
                             , BaseCore.Common.Text.CVal(Me.Fields.HeaderBase.入庫数累計.Value) _
                             , BaseCore.Common.Text.CVal(Me.Fields.HeaderBase.売上金額.Value) _
                             , BaseCore.Common.Text.CVal(Me.Fields.HeaderBase.仕入金額.Value) _
                             , BaseCore.Common.Text.CVal(Me.Fields.HeaderBase.固定経費.Value) _
                             , Me.Fields.HeaderBase.入金区分.Value _
                             , Me.Fields.HeaderBase.印刷場所CD.Value _
                             , Me.Fields.HeaderBase.受注区分.Value _
                             , Me.Fields.HeaderBase.刃型NO.Value _
                             , Me.Fields.HeaderBase.版NO.Value _
                             , BaseCore.Common.Text.CVal(Me.Fields.HeaderBase.ギヤ数.Value) _
                             , Me.Fields.HeaderBase.発送仕上特記事項.Value _
                             , Me.Fields.HeaderPaper.巻取区分.Value _
                             , Me.Fields.HeaderPaper.巻取区分名.Value _
                             , Me.Fields.HeaderPaper.出し方向区分.Value _
                             , Me.Fields.HeaderPaper.出し方向区分名.Value _
                             , BaseCore.Common.Text.CVal(Me.Fields.HeaderPaper.紙管.Value) _
                             , BaseCore.Common.Text.CVal(Me.Fields.HeaderPaper.発行枚数.Value) _
                             , Me.Fields.HeaderPaper.スリッター区分.Value _
                             , Me.Fields.HeaderPaper.スリッター区分名.Value _
                             , BaseCore.Common.Text.CVal(Me.Fields.HeaderPaper.スリッター巾.Value) _
                             , BaseCore.Common.Text.CVal(Me.Fields.HeaderPaper.カット1.Value) _
                             , BaseCore.Common.Text.CVal(Me.Fields.HeaderPaper.カット2.Value) _
                             , BaseCore.Common.Text.CVal(Me.Fields.HeaderPaper.カット3.Value) _
                             , BaseCore.Common.Text.CVal(Me.Fields.HeaderPaper.包装枚数.Value) _
                             , BaseCore.Common.Text.CVal(Me.Fields.HeaderPaper.送りピッチ.Value) _
                             , Me.Fields.HeaderPaper.社内外区分.Value _
                             , Me.Fields.HeaderOut.外注先CD.Value _
                             , BaseCore.Common.Text.CVal(Me.Fields.HeaderOut.発注単価.Value) _
                             , BaseCore.Common.Text.CVal(Me.Fields.HeaderOut.発注金額.Value) _
                             , Me.Fields.HeaderOut.発注納期.Value _
                             , Me.Fields.HeaderBase.作業伝票一括発行日付本社.Value _
                             , Me.Fields.HeaderBase.作業伝票一括発行日付河北.Value _
                             , Me.Fields.HeaderBase.受注ラベル印字フラグ本社.Value _
                             , Me.Fields.HeaderBase.受注ラベル印字フラグ河北.Value _
                             , Me.Fields.HeaderBase.廃棄年月.Value _
                              )

                ' 受注売上
                Dim Text As New BaseCore.Common.Text
                If Text.CVal(Me.Fields.HeaderBase.売上数量01.Value) <> 0 Or Text.CVal(Me.Fields.HeaderBase.売上単価01.Value) <> 0 Then
                    ada売上.Insert(Me.Fields.HeaderBase.作業NO.Value, 1, Text.CVal(Me.Fields.HeaderBase.売上金額01.Value), Me.Fields.HeaderBase.売上区分01.Value, Me.Fields.HeaderBase.売上名01.Value, Text.CVal(Me.Fields.HeaderBase.売上数量01.Value), Text.CVal(Me.Fields.HeaderBase.売上単価01.Value))
                End If

                If Text.CVal(Me.Fields.HeaderBase.売上数量02.Value) <> 0 Or Text.CVal(Me.Fields.HeaderBase.売上単価02.Value) <> 0 Then
                    ada売上.Insert(Me.Fields.HeaderBase.作業NO.Value, 1, Text.CVal(Me.Fields.HeaderBase.売上金額02.Value), Me.Fields.HeaderBase.売上区分02.Value, Me.Fields.HeaderBase.売上名02.Value, Text.CVal(Me.Fields.HeaderBase.売上数量02.Value), Text.CVal(Me.Fields.HeaderBase.売上単価02.Value))
                End If

                If Text.CVal(Me.Fields.HeaderBase.売上数量03.Value) <> 0 Or Text.CVal(Me.Fields.HeaderBase.売上単価03.Value) <> 0 Then
                    ada売上.Insert(Me.Fields.HeaderBase.作業NO.Value, 1, Text.CVal(Me.Fields.HeaderBase.売上金額03.Value), Me.Fields.HeaderBase.売上区分03.Value, Me.Fields.HeaderBase.売上名03.Value, Text.CVal(Me.Fields.HeaderBase.売上数量03.Value), Text.CVal(Me.Fields.HeaderBase.売上単価03.Value))
                End If

                If Text.CVal(Me.Fields.HeaderBase.売上数量04.Value) <> 0 Or Text.CVal(Me.Fields.HeaderBase.売上単価04.Value) <> 0 Then
                    ada売上.Insert(Me.Fields.HeaderBase.作業NO.Value, 1, Text.CVal(Me.Fields.HeaderBase.売上金額04.Value), Me.Fields.HeaderBase.売上区分04.Value, Me.Fields.HeaderBase.売上名04.Value, Text.CVal(Me.Fields.HeaderBase.売上数量04.Value), Text.CVal(Me.Fields.HeaderBase.売上単価04.Value))
                End If

                If Text.CVal(Me.Fields.HeaderBase.売上数量05.Value) <> 0 Or Text.CVal(Me.Fields.HeaderBase.売上単価05.Value) <> 0 Then
                    ada売上.Insert(Me.Fields.HeaderBase.作業NO.Value, 1, Text.CVal(Me.Fields.HeaderBase.売上金額05.Value), Me.Fields.HeaderBase.売上区分05.Value, Me.Fields.HeaderBase.売上名05.Value, Text.CVal(Me.Fields.HeaderBase.売上数量05.Value), Text.CVal(Me.Fields.HeaderBase.売上単価05.Value))
                End If

                ' 受注作業注意
                If Me.Fields.HeaderBase.作業注意01.Value <> "" Then
                    ada作注.Insert(Me.Fields.HeaderBase.作業NO.Value, 1, Me.Fields.HeaderBase.作業注意01.Value)
                End If

                If Me.Fields.HeaderBase.作業注意02.Value <> "" Then
                    ada作注.Insert(Me.Fields.HeaderBase.作業NO.Value, 2, Me.Fields.HeaderBase.作業注意02.Value)
                End If

                If Me.Fields.HeaderBase.作業注意03.Value <> "" Then
                    ada作注.Insert(Me.Fields.HeaderBase.作業NO.Value, 3, Me.Fields.HeaderBase.作業注意03.Value)
                End If

                If Me.Fields.HeaderBase.作業注意04.Value <> "" Then
                    ada作注.Insert(Me.Fields.HeaderBase.作業NO.Value, 4, Me.Fields.HeaderBase.作業注意04.Value)
                End If

                If Me.Fields.HeaderBase.作業注意05.Value <> "" Then
                    ada作注.Insert(Me.Fields.HeaderBase.作業NO.Value, 5, Me.Fields.HeaderBase.作業注意05.Value)
                End If

                If Me.Fields.HeaderBase.作業注意06.Value <> "" Then
                    ada作注.Insert(Me.Fields.HeaderBase.作業NO.Value, 6, Me.Fields.HeaderBase.作業注意06.Value)
                End If

                If Me.Fields.HeaderBase.作業注意07.Value <> "" Then
                    ada作注.Insert(Me.Fields.HeaderBase.作業NO.Value, 7, Me.Fields.HeaderBase.作業注意07.Value)
                End If

                If Me.Fields.HeaderBase.作業注意08.Value <> "" Then
                    ada作注.Insert(Me.Fields.HeaderBase.作業NO.Value, 8, Me.Fields.HeaderBase.作業注意08.Value)
                End If

                If Me.Fields.HeaderBase.作業注意09.Value <> "" Then
                    ada作注.Insert(Me.Fields.HeaderBase.作業NO.Value, 9, Me.Fields.HeaderBase.作業注意09.Value)
                End If

                If Me.Fields.HeaderBase.作業注意10.Value <> "" Then
                    ada作注.Insert(Me.Fields.HeaderBase.作業NO.Value, 10, Me.Fields.HeaderBase.作業注意10.Value)
                End If

                ' 受注出荷注意
                If Me.Fields.HeaderBase.出荷注意01.Value <> "" Then
                    ada出注.Insert(Me.Fields.HeaderBase.作業NO.Value, 1, Me.Fields.HeaderBase.出荷注意01.Value)
                End If

                If Me.Fields.HeaderBase.出荷注意02.Value <> "" Then
                    ada出注.Insert(Me.Fields.HeaderBase.作業NO.Value, 1, Me.Fields.HeaderBase.出荷注意02.Value)
                End If

                If Me.Fields.HeaderBase.出荷注意03.Value <> "" Then
                    ada出注.Insert(Me.Fields.HeaderBase.作業NO.Value, 1, Me.Fields.HeaderBase.出荷注意03.Value)
                End If

                If Me.Fields.HeaderBase.出荷注意04.Value <> "" Then
                    ada出注.Insert(Me.Fields.HeaderBase.作業NO.Value, 1, Me.Fields.HeaderBase.出荷注意04.Value)
                End If

                If Me.Fields.HeaderBase.出荷注意05.Value <> "" Then
                    ada出注.Insert(Me.Fields.HeaderBase.作業NO.Value, 1, Me.Fields.HeaderBase.出荷注意05.Value)
                End If

                If Me.Fields.HeaderBase.出荷注意06.Value <> "" Then
                    ada出注.Insert(Me.Fields.HeaderBase.作業NO.Value, 1, Me.Fields.HeaderBase.出荷注意06.Value)
                End If

                If Me.Fields.HeaderBase.出荷注意07.Value <> "" Then
                    ada出注.Insert(Me.Fields.HeaderBase.作業NO.Value, 1, Me.Fields.HeaderBase.出荷注意07.Value)
                End If

                If Me.Fields.HeaderBase.出荷注意08.Value <> "" Then
                    ada出注.Insert(Me.Fields.HeaderBase.作業NO.Value, 1, Me.Fields.HeaderBase.出荷注意08.Value)
                End If

                If Me.Fields.HeaderBase.出荷注意09.Value <> "" Then
                    ada出注.Insert(Me.Fields.HeaderBase.作業NO.Value, 1, Me.Fields.HeaderBase.出荷注意09.Value)
                End If

                If Me.Fields.HeaderBase.出荷注意10.Value <> "" Then
                    ada出注.Insert(Me.Fields.HeaderBase.作業NO.Value, 1, Me.Fields.HeaderBase.出荷注意10.Value)
                End If

                ' 受注出荷先
                If Me.Fields.HeaderBase.出荷先CD01.Value <> "" Or Me.Fields.HeaderBase.出荷先名01.Value <> "" Then
                    ada出荷.Insert(Me.Fields.HeaderBase.作業NO.Value, 1, Me.Fields.HeaderBase.出荷先CD01.Value, Me.Fields.HeaderBase.出荷先名01.Value)
                End If

                If Me.Fields.HeaderBase.出荷先CD02.Value <> "" Or Me.Fields.HeaderBase.出荷先名02.Value <> "" Then
                    ada出荷.Insert(Me.Fields.HeaderBase.作業NO.Value, 2, Me.Fields.HeaderBase.出荷先CD02.Value, Me.Fields.HeaderBase.出荷先名02.Value)
                End If

                If Me.Fields.HeaderBase.出荷先CD03.Value <> "" Or Me.Fields.HeaderBase.出荷先名03.Value <> "" Then
                    ada出荷.Insert(Me.Fields.HeaderBase.作業NO.Value, 3, Me.Fields.HeaderBase.出荷先CD03.Value, Me.Fields.HeaderBase.出荷先名03.Value)
                End If

                If Me.Fields.HeaderBase.出荷先CD04.Value <> "" Or Me.Fields.HeaderBase.出荷先名04.Value <> "" Then
                    ada出荷.Insert(Me.Fields.HeaderBase.作業NO.Value, 4, Me.Fields.HeaderBase.出荷先CD04.Value, Me.Fields.HeaderBase.出荷先名04.Value)
                End If

                ' 商品内訳
                Me.RowCount = 0
                For i As Integer = 0 To Me.Fields.Detail1.Count - 1
                    If Me.Empty_Detail1(Me.Fields.Detail1(i)) Then
                        Continue For
                    End If

                    Me.RowCount = Me.RowCount + 1

                    ada商品.Insert(Me.Fields.HeaderBase.作業NO.Value _
                                 , Me.RowCount _
                                 , Me.Fields.Detail1(i).枝番.Value _
                                 , Me.Fields.Detail1(i).定番CD.Value _
                                 , Me.Fields.Detail1(i).商品名.Value _
                                 , BaseCore.Common.Text.CVal(Me.Fields.Detail1(i).受注数.Value) _
                                 , BaseCore.Common.Text.CVal(Me.Fields.Detail1(i).内在庫引当数.Value) _
                                 , BaseCore.Common.Text.CVal(Me.Fields.Detail1(i).受注単価.Value) _
                                 , BaseCore.Common.Text.CVal(Me.Fields.Detail1(i).発注単価.Value) _
                                 , Me.Fields.Detail1(i).納品日付A.Value _
                                 , Me.Fields.Detail1(i).納品日付B.Value _
                                 , Me.Fields.Detail1(i).顧客商品CD.Value _
                                 , Me.Fields.Detail1(i).顧客発注NO.Value _
                                 , Me.Fields.Detail1(i).倉庫NO.Value _
                                 , Me.Fields.Detail1(i).備考.Value _
                                  )
                Next

                ' 紙発注
                Me.RowCount = 0
                For i As Integer = 0 To Me.Fields.Detail2.Count - 1
                    If Me.Empty_Detail2(Me.Fields.Detail2(i)) Then
                        Continue For
                    End If

                    Me.RowCount = Me.RowCount + 1

                    ada発注.Insert(Me.Fields.Detail2(i).作業NO.Value _
                                 , Me.RowCount _
                                 , Me.Fields.Detail2(i).紙CD.Value _
                                 , Me.Fields.Detail2(i).紙名.Value _
                                 , Me.Fields.Detail2(i).糊CD.Value _
                                 , Me.Fields.Detail2(i).糊名.Value _
                                 , Me.Fields.Detail2(i).台紙CD.Value _
                                 , Me.Fields.Detail2(i).台紙名.Value _
                                 , BaseCore.Common.Text.CVal(Me.Fields.Detail2(i).寸法巾.Value) _
                                 , BaseCore.Common.Text.CVal(Me.Fields.Detail2(i).寸法長.Value) _
                                 , Me.Fields.Detail2(i).仕入先指定区分.Value _
                                 , Me.Fields.Detail2(i).仕入先CD.Value _
                                 , Me.Fields.Detail2(i).支社CD.Value _
                                 , Me.Fields.Detail2(i).単価区分.Value _
                                 , BaseCore.Common.Text.CVal(Me.Fields.Detail2(i).発注単価.Value) _
                                 , BaseCore.Common.Text.CVal(Me.Fields.Detail2(i).社内単価.Value) _
                                 , Me.Fields.Detail2(i).納入区分.Value _
                                 , Me.Fields.Detail2(i).支給区分.Value _
                                 , BaseCore.Common.Text.CVal(Me.Fields.Detail2(i).有償支給単価.Value) _
                                 , Me.Fields.Detail2(i).発注日付.Value _
                                 , BaseCore.Common.Text.CVal(Me.Fields.Detail2(i).通数.Value) _
                                 , BaseCore.Common.Text.CVal(Me.Fields.Detail2(i).送りMM.Value) _
                                 , BaseCore.Common.Text.CVal(Me.Fields.Detail2(i).刷出M.Value) _
                                 , BaseCore.Common.Text.CVal(Me.Fields.Detail2(i).つなぎロス.Value) _
                                 , BaseCore.Common.Text.CVal(Me.Fields.Detail2(i).その他M.Value) _
                                 , Me.Fields.Detail2(i).希望納期日付.Value _
                                 , Me.Fields.Detail2(i).希望時間帯区分.Value _
                                 , BaseCore.Common.Text.CVal(Me.Fields.Detail2(i).基準長.Value) _
                                 , Me.Fields.Detail2(i).完納区分.Value _
                                 , Me.Fields.Detail2(i).発注用摘要1.Value _
                                 , Me.Fields.Detail2(i).発注用摘要2.Value _
                                 , Me.Fields.Detail2(i).発注用摘要3.Value _
                                  )
                Next

                ''-------------------------------------
                '' COMMIT
                ''-------------------------------------
                'scope.Complete()
                'End Using

            Catch ex As Exception
                MyBase.LastError = "以下のエラーのため、追加できませんでした。" & vbCrLf & ex.Message
                Return False
            End Try

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
            Dim ada基本 As New NodeDatabase.DataSetTranTableAdapters.T受注基本TableAdapter
            Dim tbl基本 As New NodeDatabase.DataSetTran.T受注基本DataTable
            Dim qry基本 As New Collection

            Dim ada売上 As New NodeDatabase.DataSetTranTableAdapters.T受注売上TableAdapter
            Dim tbl売上 As New NodeDatabase.DataSetTran.T受注売上DataTable
            Dim qry売上 As New Collection

            Dim ada作注 As New NodeDatabase.DataSetTranTableAdapters.T受注作業注意TableAdapter
            Dim tbl作注 As New NodeDatabase.DataSetTran.T受注作業注意DataTable
            Dim qry作注 As New Collection

            Dim ada出注 As New NodeDatabase.DataSetTranTableAdapters.T受注出荷注意TableAdapter
            Dim tbl出注 As New NodeDatabase.DataSetTran.T受注出荷注意DataTable
            Dim qry出注 As New Collection

            Dim ada出荷 As New NodeDatabase.DataSetTranTableAdapters.T受注出荷先TableAdapter
            Dim tbl出荷 As New NodeDatabase.DataSetTran.T受注出荷先DataTable
            Dim qry出荷 As New Collection

            Dim ada商品 As New NodeDatabase.DataSetTranTableAdapters.T受注商品内訳TableAdapter
            Dim tbl商品 As New NodeDatabase.DataSetTran.T受注商品内訳DataTable
            Dim qry商品 As New Collection

            Dim ada発注 As New NodeDatabase.DataSetTranTableAdapters.T受注紙発注TableAdapter
            Dim tbl発注 As New NodeDatabase.DataSetTran.T受注紙発注DataTable
            Dim qry発注 As New Collection

            '----------------------------------------------------------------------
            ' 保存
            '----------------------------------------------------------------------
            Try
                Using scope As New System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required, TimeSpan.Zero)
                    '-------------------------------------
                    ' 事前削除
                    '-------------------------------------
                    qry基本.Clear()
                    qry基本.Add(New BaseDatabase.Condition(tbl基本.作業NOColumn.ColumnName, Me.Fields.HeaderBase.作業NO.Value, BaseDatabase.Contents.Compare.Equal))
                    ada基本.DeleteByCommon(qry基本)

                    qry売上.Clear()
                    qry売上.Add(New BaseDatabase.Condition(tbl売上.作業NOColumn.ColumnName, Me.Fields.HeaderBase.作業NO.Value, BaseDatabase.Contents.Compare.Equal))
                    ada売上.DeleteByCommon(qry売上)

                    qry作注.Clear()
                    qry作注.Add(New BaseDatabase.Condition(tbl作注.作業NOColumn.ColumnName, Me.Fields.HeaderBase.作業NO.Value, BaseDatabase.Contents.Compare.Equal))
                    ada作注.DeleteByCommon(qry作注)

                    qry出注.Clear()
                    qry出注.Add(New BaseDatabase.Condition(tbl出注.作業NOColumn.ColumnName, Me.Fields.HeaderBase.作業NO.Value, BaseDatabase.Contents.Compare.Equal))
                    ada出注.DeleteByCommon(qry出注)

                    qry出荷.Clear()
                    qry出荷.Add(New BaseDatabase.Condition(tbl出荷.作業NOColumn.ColumnName, Me.Fields.HeaderBase.作業NO.Value, BaseDatabase.Contents.Compare.Equal))
                    ada出荷.DeleteByCommon(qry出荷)

                    qry商品.Clear()
                    qry商品.Add(New BaseDatabase.Condition(tbl商品.作業NOColumn.ColumnName, Me.Fields.HeaderBase.作業NO.Value, BaseDatabase.Contents.Compare.Equal))
                    ada商品.DeleteByCommon(qry商品)

                    qry発注.Clear()
                    qry発注.Add(New BaseDatabase.Condition(tbl発注.作業NOColumn.ColumnName, Me.Fields.HeaderBase.作業NO.Value, BaseDatabase.Contents.Compare.Equal))
                    ada発注.DeleteByCommon(qry発注)

                    '-------------------------------------
                    ' COMMIT
                    '-------------------------------------
                    scope.Complete()
                End Using

            Catch ex As Exception
                MyBase.LastError = "以下のエラーのため、追加できませんでした。" & vbCrLf & ex.Message
                Return False
            End Try

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
            Me.Fields.HeaderBase.作業NO.IsError = False
            Me.Fields.HeaderBase.本台帳NO.IsError = False
            Me.Fields.HeaderBase.御客様NO.IsError = False
            Me.Fields.HeaderBase.枝番.IsError = False
            Me.Fields.HeaderBase.受注日付.IsError = False
            Me.Fields.HeaderBase.納品日付A.IsError = False
            Me.Fields.HeaderBase.納品日付B.IsError = False
            Me.Fields.HeaderBase.確約区分.IsError = False
            Me.Fields.HeaderBase.入力担当者CD.IsError = False
            Me.Fields.HeaderBase.得意先CD.IsError = False
            Me.Fields.HeaderBase.請求先CD.IsError = False
            Me.Fields.HeaderBase.定番フラグ.IsError = False
            Me.Fields.HeaderBase.代表商品名.IsError = False
            Me.Fields.HeaderBase.顧客商品CD.IsError = False
            Me.Fields.HeaderBase.顧客商品CDALL.IsError = False
            Me.Fields.HeaderBase.受注数合計.IsError = False
            Me.Fields.HeaderBase.内在庫引当数合計.IsError = False
            Me.Fields.HeaderBase.通数合計.IsError = False
            Me.Fields.HeaderBase.通数1.IsError = False
            Me.Fields.HeaderBase.通数2.IsError = False
            Me.Fields.HeaderBase.通数3.IsError = False
            Me.Fields.HeaderBase.受注単価.IsError = False
            Me.Fields.HeaderBase.単位区分.IsError = False
            Me.Fields.HeaderBase.受注金額.IsError = False
            Me.Fields.HeaderBase.原価決定日付.IsError = False
            Me.Fields.HeaderBase.通数累計.IsError = False
            Me.Fields.HeaderBase.売上数累計.IsError = False
            Me.Fields.HeaderBase.入庫数累計.IsError = False
            Me.Fields.HeaderBase.売上金額.IsError = False
            Me.Fields.HeaderBase.仕入金額.IsError = False
            Me.Fields.HeaderBase.固定経費.IsError = False
            Me.Fields.HeaderBase.入金区分.IsError = False
            Me.Fields.HeaderBase.印刷場所CD.IsError = False
            Me.Fields.HeaderBase.受注区分.IsError = False
            Me.Fields.HeaderBase.刃型NO.IsError = False
            Me.Fields.HeaderBase.版NO.IsError = False
            Me.Fields.HeaderBase.ギヤ数.IsError = False
            Me.Fields.HeaderBase.発送仕上特記事項.IsError = False
            Me.Fields.HeaderPaper.巻取区分.IsError = False
            Me.Fields.HeaderPaper.巻取区分名.IsError = False
            Me.Fields.HeaderPaper.出し方向区分.IsError = False
            Me.Fields.HeaderPaper.出し方向区分名.IsError = False
            Me.Fields.HeaderPaper.紙管.IsError = False
            Me.Fields.HeaderPaper.発行枚数.IsError = False
            Me.Fields.HeaderPaper.スリッター区分.IsError = False
            Me.Fields.HeaderPaper.スリッター区分名.IsError = False
            Me.Fields.HeaderPaper.スリッター巾.IsError = False
            Me.Fields.HeaderPaper.カット1.IsError = False
            Me.Fields.HeaderPaper.カット2.IsError = False
            Me.Fields.HeaderPaper.カット3.IsError = False
            Me.Fields.HeaderPaper.包装枚数.IsError = False
            Me.Fields.HeaderPaper.送りピッチ.IsError = False
            Me.Fields.HeaderPaper.社内外区分.IsError = False
            Me.Fields.HeaderOut.外注先CD.IsError = False
            Me.Fields.HeaderOut.発注単価.IsError = False
            Me.Fields.HeaderOut.発注金額.IsError = False
            Me.Fields.HeaderOut.発注納期.IsError = False
            Me.Fields.HeaderBase.作業伝票一括発行日付本社.IsError = False
            Me.Fields.HeaderBase.作業伝票一括発行日付河北.IsError = False
            Me.Fields.HeaderBase.受注ラベル印字フラグ本社.IsError = False
            Me.Fields.HeaderBase.受注ラベル印字フラグ河北.IsError = False
            Me.Fields.HeaderBase.廃棄年月.IsError = False

            Me.Fields.HeaderBase.売上金額01.IsError = False
            Me.Fields.HeaderBase.売上単価01.IsError = False
            Me.Fields.HeaderBase.売上数量01.IsError = False
            Me.Fields.HeaderBase.売上区分01.IsError = False
            Me.Fields.HeaderBase.売上名01.IsError = False
            Me.Fields.HeaderBase.売上金額02.IsError = False
            Me.Fields.HeaderBase.売上単価02.IsError = False
            Me.Fields.HeaderBase.売上数量02.IsError = False
            Me.Fields.HeaderBase.売上区分02.IsError = False
            Me.Fields.HeaderBase.売上名02.IsError = False
            Me.Fields.HeaderBase.売上金額03.IsError = False
            Me.Fields.HeaderBase.売上単価03.IsError = False
            Me.Fields.HeaderBase.売上数量03.IsError = False
            Me.Fields.HeaderBase.売上区分03.IsError = False
            Me.Fields.HeaderBase.売上名03.IsError = False
            Me.Fields.HeaderBase.売上金額04.IsError = False
            Me.Fields.HeaderBase.売上単価04.IsError = False
            Me.Fields.HeaderBase.売上数量04.IsError = False
            Me.Fields.HeaderBase.売上区分04.IsError = False
            Me.Fields.HeaderBase.売上名04.IsError = False
            Me.Fields.HeaderBase.売上金額05.IsError = False
            Me.Fields.HeaderBase.売上単価05.IsError = False
            Me.Fields.HeaderBase.売上数量05.IsError = False
            Me.Fields.HeaderBase.売上区分05.IsError = False
            Me.Fields.HeaderBase.売上名05.IsError = False

            Me.Fields.HeaderBase.作業注意01.IsError = False
            Me.Fields.HeaderBase.作業注意02.IsError = False
            Me.Fields.HeaderBase.作業注意03.IsError = False
            Me.Fields.HeaderBase.作業注意04.IsError = False
            Me.Fields.HeaderBase.作業注意05.IsError = False
            Me.Fields.HeaderBase.作業注意06.IsError = False
            Me.Fields.HeaderBase.作業注意07.IsError = False
            Me.Fields.HeaderBase.作業注意08.IsError = False
            Me.Fields.HeaderBase.作業注意09.IsError = False
            Me.Fields.HeaderBase.作業注意10.IsError = False

            Me.Fields.HeaderBase.出荷注意01.IsError = False
            Me.Fields.HeaderBase.出荷注意02.IsError = False
            Me.Fields.HeaderBase.出荷注意03.IsError = False
            Me.Fields.HeaderBase.出荷注意04.IsError = False
            Me.Fields.HeaderBase.出荷注意05.IsError = False
            Me.Fields.HeaderBase.出荷注意06.IsError = False
            Me.Fields.HeaderBase.出荷注意07.IsError = False
            Me.Fields.HeaderBase.出荷注意08.IsError = False
            Me.Fields.HeaderBase.出荷注意09.IsError = False
            Me.Fields.HeaderBase.出荷注意10.IsError = False

            Me.Fields.HeaderBase.出荷先CD01.IsError = False
            Me.Fields.HeaderBase.出荷先名01.IsError = False
            Me.Fields.HeaderBase.出荷先CD02.IsError = False
            Me.Fields.HeaderBase.出荷先名02.IsError = False
            Me.Fields.HeaderBase.出荷先CD03.IsError = False
            Me.Fields.HeaderBase.出荷先名03.IsError = False
            Me.Fields.HeaderBase.出荷先CD04.IsError = False
            Me.Fields.HeaderBase.出荷先名04.IsError = False

            Me.Fields.HeaderBase.処理登録.IsError = False
            Me.Fields.HeaderBase.処理修正.IsError = False
            Me.Fields.HeaderBase.処理削除.IsError = False

            '------------------------------------------------------------------
            ' 共通検査
            '------------------------------------------------------------------
            Validator.BaseChecker(Me.Fields.HeaderBase.作業NO, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.本台帳NO, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.御客様NO, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.枝番, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.受注日付, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.納品日付A, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.納品日付B, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.確約区分, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.入力担当者CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.得意先CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.請求先CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.定番フラグ, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.代表商品名, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.顧客商品CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.顧客商品CDALL, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.受注数合計, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.内在庫引当数合計, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.通数合計, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.通数1, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.通数2, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.通数3, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.受注単価, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.単位区分, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.受注金額, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.原価決定日付, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.通数累計, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.売上数累計, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.入庫数累計, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.売上金額, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.仕入金額, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.固定経費, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.入金区分, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.印刷場所CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.受注区分, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.刃型NO, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.版NO, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.ギヤ数, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.発送仕上特記事項, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderPaper.巻取区分, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderPaper.巻取区分名, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderPaper.出し方向区分, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderPaper.出し方向区分名, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderPaper.紙管, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderPaper.発行枚数, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderPaper.スリッター区分, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderPaper.スリッター区分名, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderPaper.スリッター巾, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderPaper.カット1, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderPaper.カット2, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderPaper.カット3, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderPaper.包装枚数, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderPaper.送りピッチ, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderPaper.社内外区分, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderOut.外注先CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderOut.発注単価, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderOut.発注金額, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderOut.発注納期, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.作業伝票一括発行日付本社, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.作業伝票一括発行日付河北, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.受注ラベル印字フラグ本社, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.受注ラベル印字フラグ河北, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.廃棄年月, strMsg, Me.ControlError)

            Validator.BaseChecker(Me.Fields.HeaderBase.売上金額01, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.売上単価01, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.売上数量01, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.売上区分01, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.売上名01, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.売上金額02, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.売上単価02, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.売上数量02, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.売上区分02, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.売上名02, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.売上金額03, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.売上単価03, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.売上数量03, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.売上区分03, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.売上名03, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.売上金額04, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.売上単価04, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.売上数量04, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.売上区分04, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.売上名04, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.売上金額05, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.売上単価05, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.売上数量05, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.売上区分05, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.売上名05, strMsg, Me.ControlError)

            Validator.BaseChecker(Me.Fields.HeaderBase.作業注意01, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.作業注意02, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.作業注意03, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.作業注意04, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.作業注意05, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.作業注意06, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.作業注意07, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.作業注意08, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.作業注意09, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.作業注意10, strMsg, Me.ControlError)

            Validator.BaseChecker(Me.Fields.HeaderBase.出荷注意01, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.出荷注意02, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.出荷注意03, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.出荷注意04, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.出荷注意05, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.出荷注意06, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.出荷注意07, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.出荷注意08, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.出荷注意09, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.出荷注意10, strMsg, Me.ControlError)

            Validator.BaseChecker(Me.Fields.HeaderBase.出荷先CD01, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.出荷先名01, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.出荷先CD02, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.出荷先名02, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.出荷先CD03, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.出荷先名03, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.出荷先CD04, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.出荷先名04, strMsg, Me.ControlError)

            Validator.BaseChecker(Me.Fields.HeaderBase.処理登録, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.処理修正, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.HeaderBase.処理削除, strMsg, Me.ControlError)

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

#Region "明細(商品内訳)"
#Region "Clear"
        '''========================================================================================
        ''' <SUMMARY>ｸﾘｱ</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overrides Function Clear_Detail1() As Boolean
            '----------------------------------------------------------------------
            ' 行削除
            '----------------------------------------------------------------------
            Me.Fields.Detail1.Clear()

            '----------------------------------------------------------------------
            ' ｸﾘｱ
            '----------------------------------------------------------------------
            For i As Integer = 0 To Me.Fields.Detail1.Count - 1
                Me.Clear_Detail1(i)
            Next

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return True
        End Function

        Public Overrides Function Clear_Detail1(ByVal Index As Integer) As Boolean
            Me.Fields.Detail1(Index).作業NO.Value = Nothing
            Me.Fields.Detail1(Index).枝番.Value = Nothing
            Me.Fields.Detail1(Index).定番CD.Value = Nothing
            Me.Fields.Detail1(Index).商品名.Value = Nothing
            Me.Fields.Detail1(Index).受注数.Value = Nothing
            Me.Fields.Detail1(Index).内在庫引当数.Value = Nothing
            Me.Fields.Detail1(Index).受注単価.Value = Nothing
            Me.Fields.Detail1(Index).発注単価.Value = Nothing
            Me.Fields.Detail1(Index).納品日付A.Value = Nothing
            Me.Fields.Detail1(Index).納品日付B.Value = Nothing
            Me.Fields.Detail1(Index).顧客商品CD.Value = Nothing
            Me.Fields.Detail1(Index).顧客発注NO.Value = Nothing
            Me.Fields.Detail1(Index).倉庫NO.Value = Nothing
            Me.Fields.Detail1(Index).備考.Value = Nothing

            Me.Fields.Detail1(Index).内製造数.Value = Nothing
        End Function
#End Region

#Region "Read"
        '''========================================================================================
        ''' <SUMMARY>読込</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overrides Function Read_Detail1() As Boolean
            '----------------------------------------------------------------------
            ' 読み込み
            '----------------------------------------------------------------------
            Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0受注商品内訳TableAdapter
            Dim tbl As New NodeDatabase.DataSetView.V0受注商品内訳DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            'Dim str作業NO As String = Me.KeyNO_Value    ' 本台帳NO/作業NO算出
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.作業NOColumn.ColumnName, Me.Fields.HeaderBase.作業NO.Value, BaseDatabase.Contents.Compare.Equal))

            Dim strSort As String = ""
            Dim strDelim As String = ""

            strSort &= strDelim & tbl.行NOColumn.ColumnName : strDelim = ","

            tbl = ada.SelectByCommon(qry, strSort)

            '----------------------------------------------------------------------
            ' ﾌﾚｰﾑ作成
            '----------------------------------------------------------------------
            Me.Add_Detail1(tbl.Count)

            '----------------------------------------------------------------------
            ' 値設定
            '----------------------------------------------------------------------
            For i As Integer = 0 To tbl.Rows.Count - 1
                Me.Fields.Detail1(i).作業NO.Value = tbl(i).Item(tbl.作業NOColumn.ColumnName)
                Me.Fields.Detail1(i).枝番.Value = tbl(i).Item(tbl.枝番Column.ColumnName)
                Me.Fields.Detail1(i).定番CD.Value = tbl(i).Item(tbl.定番CDColumn.ColumnName)
                Me.Fields.Detail1(i).商品名.Value = tbl(i).Item(tbl.商品名Column.ColumnName)
                Me.Fields.Detail1(i).受注数.Value = tbl(i).Item(tbl.受注数Column.ColumnName)
                Me.Fields.Detail1(i).内在庫引当数.Value = tbl(i).Item(tbl.内在庫引当数Column.ColumnName)
                Me.Fields.Detail1(i).受注単価.Value = tbl(i).Item(tbl.受注単価Column.ColumnName)
                Me.Fields.Detail1(i).発注単価.Value = tbl(i).Item(tbl.発注単価Column.ColumnName)
                Me.Fields.Detail1(i).納品日付A.Value = tbl(i).Item(tbl.納品日付AColumn.ColumnName)
                Me.Fields.Detail1(i).納品日付B.Value = tbl(i).Item(tbl.納品日付BColumn.ColumnName)
                Me.Fields.Detail1(i).顧客商品CD.Value = tbl(i).Item(tbl.顧客商品CDColumn.ColumnName)
                Me.Fields.Detail1(i).顧客発注NO.Value = tbl(i).Item(tbl.顧客発注NOColumn.ColumnName)
                Me.Fields.Detail1(i).倉庫NO.Value = tbl(i).Item(tbl.倉庫NOColumn.ColumnName)
                Me.Fields.Detail1(i).備考.Value = tbl(i).Item(tbl.備考Column.ColumnName)

                Me.Fields.Detail1(i).内製造数.Value = tbl(i).Item(tbl.内製造数Column.ColumnName)
            Next

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return True
        End Function
#End Region

#Region "Valid(Write)"
        '''========================================================================================
        ''' <summary>検査</summary>
        ''' <RETURNS>True:正常, False:不正</RETURNS>
        '''========================================================================================
        Protected Overrides Function Valid_Write_Detail1_Common() As NodeContents.ActionButton.ErrorLevel
            '----------------------------------------------------------------------
            ' 変数定義
            '----------------------------------------------------------------------
            Dim strMsg As String = ""
            Dim Validator As New BaseCore.Common.Validator

            '------------------------------------------------------------------
            ' ｴﾗｰｸﾘｱ
            '------------------------------------------------------------------
            For i As Integer = 0 To Me.Fields.Detail1.Count - 1
                Me.Fields.Detail1(i).作業NO.IsError = False
                Me.Fields.Detail1(i).枝番.IsError = False
                Me.Fields.Detail1(i).定番CD.IsError = False
                Me.Fields.Detail1(i).商品名.IsError = False
                Me.Fields.Detail1(i).受注数.IsError = False
                Me.Fields.Detail1(i).内在庫引当数.IsError = False
                Me.Fields.Detail1(i).受注単価.IsError = False
                Me.Fields.Detail1(i).発注単価.IsError = False
                Me.Fields.Detail1(i).納品日付A.IsError = False
                Me.Fields.Detail1(i).納品日付B.IsError = False
                Me.Fields.Detail1(i).顧客商品CD.IsError = False
                Me.Fields.Detail1(i).顧客発注NO.IsError = False
                Me.Fields.Detail1(i).倉庫NO.IsError = False
                Me.Fields.Detail1(i).備考.IsError = False
            Next

            '------------------------------------------------------------------
            ' 共通検査
            '------------------------------------------------------------------
            For i As Integer = 0 To Me.Fields.Detail1.Count - 1
                If Me.Empty_Detail1(Me.Fields.Detail1(i)) Then
                    Continue For
                End If

                Validator.BaseChecker(Me.Fields.Detail1(i).作業NO, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail1(i).枝番, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail1(i).定番CD, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail1(i).商品名, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail1(i).受注数, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail1(i).内在庫引当数, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail1(i).受注単価, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail1(i).発注単価, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail1(i).納品日付A, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail1(i).納品日付B, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail1(i).顧客商品CD, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail1(i).顧客発注NO, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail1(i).倉庫NO, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail1(i).備考, strMsg, Me.ControlError)
            Next

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

#Region "無効行判定"
        '''========================================================================================
        ''' <summary>無効行の判定</summary>
        ''' <param name="Detail">明細行</param>
        ''' <returns>True:無効行, False:有効行</returns>
        '''========================================================================================
        Protected Overrides Function Empty_Detail1(ByVal Detail As Object) As Boolean
            '------------------------------------------------------------------
            ' 変数定義
            '------------------------------------------------------------------
            Dim row As Detail1 = CType(Detail, Detail1)

            '------------------------------------------------------------------
            ' 入力有は有効行
            '------------------------------------------------------------------
            Select Case True
                Case Not BaseCore.Common.Text.IsEmptyOrZero(row.商品名.Value) : Return False
            End Select

            '------------------------------------------------------------------
            ' 無効行
            '------------------------------------------------------------------
            Return True
        End Function
#End Region

#Region "行挿入"
        '''========================================================================================
        ''' <summary>単一行挿入</summary>
        '''========================================================================================
        Public Overrides Sub Insert_Detail1(ByVal Position As Integer)
            '----------------------------------------------------------------------
            ' 行挿入
            '----------------------------------------------------------------------
            Me.Fields.Detail1.Insert(Position, New Detail1(Me.Config))

            '----------------------------------------------------------------------
            ' 行ｸﾘｱ
            '----------------------------------------------------------------------
            Me.Clear_Detail1(Position)

            '----------------------------------------------------------------------
            ' 行番号の再付番
            '----------------------------------------------------------------------
            Me.ReNum_Detail1()
        End Sub

        '''========================================================================================
        ''' <summary>複数行挿入</summary>
        '''========================================================================================
        Public Overrides Sub Insert_Detail1(ByVal Position As Integer, ByVal Count As Integer)
            '----------------------------------------------------------------------
            ' 行挿入 & 行ｸﾘｱ
            '----------------------------------------------------------------------
            For i As Integer = Position To Position + Count - 1
                Me.Fields.Detail1.Insert(Position, New Detail1(Me.Config))
                Me.Clear_Detail1(Position)
            Next

            '----------------------------------------------------------------------
            ' 行番号の再付番
            '----------------------------------------------------------------------
            Me.ReNum_Detail1()
        End Sub
#End Region

#Region "行複写"
        '''========================================================================================
        ''' <summary>単一行複写</summary>
        '''========================================================================================
        Public Overrides Sub Copy_Detail1(ByVal Position As Integer)
            '----------------------------------------------------------------------
            ' 行挿入
            '----------------------------------------------------------------------
            Me.Fields.Detail1.Insert(Position, New Detail1(Me.Config))

            '----------------------------------------------------------------------
            ' 行ｺﾋﾟｰ
            '----------------------------------------------------------------------
            Me.CopyValue_Detail1(Position + 1, Position)

            '----------------------------------------------------------------------
            ' 行番号の再付番
            '----------------------------------------------------------------------
            Me.ReNum_Detail1()
        End Sub

        '''========================================================================================
        ''' <summary>値ｺﾋﾟｰ</summary>
        '''========================================================================================
        Protected Function CopyValue_Detail1(ByVal IndexF As Integer, ByVal IndexT As Integer) As Boolean
            Me.Fields.Detail1(IndexT).作業NO.Value = Me.Fields.Detail1(IndexF).作業NO.Value
            Me.Fields.Detail1(IndexT).枝番.Value = Me.Fields.Detail1(IndexF).枝番.Value
            Me.Fields.Detail1(IndexT).定番CD.Value = Me.Fields.Detail1(IndexF).定番CD.Value
            Me.Fields.Detail1(IndexT).商品名.Value = Me.Fields.Detail1(IndexF).商品名.Value
            Me.Fields.Detail1(IndexT).受注数.Value = Me.Fields.Detail1(IndexF).受注数.Value
            Me.Fields.Detail1(IndexT).内在庫引当数.Value = Me.Fields.Detail1(IndexF).内在庫引当数.Value
            Me.Fields.Detail1(IndexT).受注単価.Value = Me.Fields.Detail1(IndexF).受注単価.Value
            Me.Fields.Detail1(IndexT).発注単価.Value = Me.Fields.Detail1(IndexF).発注単価.Value
            Me.Fields.Detail1(IndexT).納品日付A.Value = Me.Fields.Detail1(IndexF).納品日付A.Value
            Me.Fields.Detail1(IndexT).納品日付B.Value = Me.Fields.Detail1(IndexF).納品日付B.Value
            Me.Fields.Detail1(IndexT).顧客商品CD.Value = Me.Fields.Detail1(IndexF).顧客商品CD.Value
            Me.Fields.Detail1(IndexT).顧客発注NO.Value = Me.Fields.Detail1(IndexF).顧客発注NO.Value
            Me.Fields.Detail1(IndexT).倉庫NO.Value = Me.Fields.Detail1(IndexF).倉庫NO.Value
            Me.Fields.Detail1(IndexT).備考.Value = Me.Fields.Detail1(IndexF).備考.Value

            Me.Fields.Detail1(IndexT).内製造数.Value = Me.Fields.Detail1(IndexF).内製造数.Value
        End Function
#End Region

#Region "行追加"
        '''========================================================================================
        ''' <summary>単一行追加</summary>
        '''========================================================================================
        Public Overrides Sub Add_Detail1()
            Me.Fields.Detail1.Add(New Detail1(Me.Config))
            Me.Clear_Detail1(Me.Fields.Detail1.Count - 1)
        End Sub

        '''========================================================================================
        ''' <summary>一括行追加</summary>
        ''' <param name="AddCount">追加行数</param>
        '''========================================================================================
        Public Overrides Sub Add_Detail1(ByVal AddCount As Integer, Optional Clear As Boolean = True)
            If Clear Then
                Me.Fields.Detail1.Clear()
            End If

            For i As Integer = 0 To AddCount - 1
                Me.Add_Detail1()
            Next
        End Sub
#End Region

#Region "行削除"
        '''========================================================================================
        ''' <summary>一括行削除</summary>
        '''========================================================================================
        Public Overrides Sub Del_Detail1()
            Me.Fields.Detail1.Clear()
        End Sub

        '''========================================================================================
        ''' <summary>一括行削除</summary>
        '''========================================================================================
        Public Overrides Sub Del_Detail1(ByVal Position As Integer)
            Me.Fields.Detail1.RemoveAt(Position)
        End Sub
#End Region
#End Region

#Region "明細(紙発注)"
#Region "Clear"
        '''========================================================================================
        ''' <SUMMARY>ｸﾘｱ</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overrides Function Clear_Detail2() As Boolean
            '----------------------------------------------------------------------
            ' 行削除
            '----------------------------------------------------------------------
            Me.Fields.Detail2.Clear()

            '----------------------------------------------------------------------
            ' ｸﾘｱ
            '----------------------------------------------------------------------
            For i As Integer = 0 To Me.Fields.Detail2.Count - 1
                Me.Clear_Detail2(i)
            Next

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return True
        End Function

        Public Overrides Function Clear_Detail2(ByVal Index As Integer) As Boolean
            Me.Fields.Detail2(Index).作業NO.Value = Nothing
            Me.Fields.Detail2(Index).紙CD.Value = Nothing
            Me.Fields.Detail2(Index).紙名.Value = Nothing
            Me.Fields.Detail2(Index).糊CD.Value = Nothing
            Me.Fields.Detail2(Index).糊名.Value = Nothing
            Me.Fields.Detail2(Index).台紙CD.Value = Nothing
            Me.Fields.Detail2(Index).台紙名.Value = Nothing
            Me.Fields.Detail2(Index).寸法巾.Value = Nothing
            Me.Fields.Detail2(Index).寸法長.Value = Nothing
            Me.Fields.Detail2(Index).仕入先指定区分.Value = Nothing
            Me.Fields.Detail2(Index).仕入先CD.Value = Nothing
            Me.Fields.Detail2(Index).支社CD.Value = Nothing
            Me.Fields.Detail2(Index).単価区分.Value = Nothing
            Me.Fields.Detail2(Index).発注単価.Value = Nothing
            Me.Fields.Detail2(Index).社内単価.Value = Nothing
            Me.Fields.Detail2(Index).納入区分.Value = Nothing
            Me.Fields.Detail2(Index).支給区分.Value = Nothing
            Me.Fields.Detail2(Index).有償支給単価.Value = Nothing
            Me.Fields.Detail2(Index).発注日付.Value = Nothing
            Me.Fields.Detail2(Index).通数.Value = Nothing
            Me.Fields.Detail2(Index).送りMM.Value = Nothing
            Me.Fields.Detail2(Index).刷出M.Value = Nothing
            Me.Fields.Detail2(Index).つなぎロス.Value = Nothing
            Me.Fields.Detail2(Index).その他M.Value = Nothing
            Me.Fields.Detail2(Index).希望納期日付.Value = Nothing
            Me.Fields.Detail2(Index).希望時間帯区分.Value = Nothing
            Me.Fields.Detail2(Index).基準長.Value = Nothing
            Me.Fields.Detail2(Index).完納区分.Value = Nothing
            Me.Fields.Detail2(Index).発注用摘要1.Value = Nothing
            Me.Fields.Detail2(Index).発注用摘要2.Value = Nothing
            Me.Fields.Detail2(Index).発注用摘要3.Value = Nothing

            Me.Fields.Detail2(Index).仕入先名.Value = Nothing
            Me.Fields.Detail2(Index).仕入先指定区分名.Value = Nothing
            Me.Fields.Detail2(Index).単価区分名.Value = Nothing
            Me.Fields.Detail2(Index).納入区分名.Value = Nothing
            Me.Fields.Detail2(Index).支給区分名.Value = Nothing
            Me.Fields.Detail2(Index).希望時間帯区分名.Value = Nothing
            Me.Fields.Detail2(Index).完納区分名.Value = Nothing
        End Function
#End Region

#Region "Read"
        '''========================================================================================
        ''' <SUMMARY>読込</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overrides Function Read_Detail2() As Boolean
            '----------------------------------------------------------------------
            ' 読み込み
            '----------------------------------------------------------------------
            Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0受注紙発注TableAdapter
            Dim tbl As New NodeDatabase.DataSetView.V0受注紙発注DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            'Dim str作業NO As String = Me.KeyNO_Value    ' 本台帳NO/作業NO算出
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.作業NOColumn.ColumnName, Me.Fields.HeaderBase.作業NO.Value, BaseDatabase.Contents.Compare.Equal))

            Dim strSort As String = ""
            Dim strDelim As String = ""

            strSort &= strDelim & tbl.行NOColumn.ColumnName : strDelim = ","

            tbl = ada.SelectByCommon(qry, strSort)

            '----------------------------------------------------------------------
            ' ﾌﾚｰﾑ作成
            '----------------------------------------------------------------------
            Me.Add_Detail2(tbl.Count)

            '----------------------------------------------------------------------
            ' 値設定
            '----------------------------------------------------------------------
            For i As Integer = 0 To tbl.Rows.Count - 1
                Me.Fields.Detail2(i).作業NO.Value = tbl(i).Item(tbl.作業NOColumn.ColumnName)
                Me.Fields.Detail2(i).紙CD.Value = tbl(i).Item(tbl.紙CDColumn.ColumnName)
                Me.Fields.Detail2(i).紙名.Value = tbl(i).Item(tbl.紙名Column.ColumnName)
                Me.Fields.Detail2(i).糊CD.Value = tbl(i).Item(tbl.糊CDColumn.ColumnName)
                Me.Fields.Detail2(i).糊名.Value = tbl(i).Item(tbl.糊名Column.ColumnName)
                Me.Fields.Detail2(i).台紙CD.Value = tbl(i).Item(tbl.台紙CDColumn.ColumnName)
                Me.Fields.Detail2(i).台紙名.Value = tbl(i).Item(tbl.台紙名Column.ColumnName)
                Me.Fields.Detail2(i).寸法巾.Value = tbl(i).Item(tbl.寸法巾Column.ColumnName)
                Me.Fields.Detail2(i).寸法長.Value = tbl(i).Item(tbl.寸法長Column.ColumnName)
                Me.Fields.Detail2(i).仕入先指定区分.Value = tbl(i).Item(tbl.仕入先指定区分Column.ColumnName)
                Me.Fields.Detail2(i).仕入先CD.Value = tbl(i).Item(tbl.仕入先CDColumn.ColumnName)
                Me.Fields.Detail2(i).支社CD.Value = tbl(i).Item(tbl.支社CDColumn.ColumnName)
                Me.Fields.Detail2(i).単価区分.Value = tbl(i).Item(tbl.単価区分Column.ColumnName)
                Me.Fields.Detail2(i).発注単価.Value = tbl(i).Item(tbl.発注単価Column.ColumnName)
                Me.Fields.Detail2(i).社内単価.Value = tbl(i).Item(tbl.社内単価Column.ColumnName)
                Me.Fields.Detail2(i).納入区分.Value = tbl(i).Item(tbl.納入区分Column.ColumnName)
                Me.Fields.Detail2(i).支給区分.Value = tbl(i).Item(tbl.支給区分Column.ColumnName)
                Me.Fields.Detail2(i).有償支給単価.Value = tbl(i).Item(tbl.有償支給単価Column.ColumnName)
                Me.Fields.Detail2(i).発注日付.Value = tbl(i).Item(tbl.発注日付Column.ColumnName)
                Me.Fields.Detail2(i).通数.Value = tbl(i).Item(tbl.通数Column.ColumnName)
                Me.Fields.Detail2(i).送りMM.Value = tbl(i).Item(tbl.送りMMColumn.ColumnName)
                Me.Fields.Detail2(i).刷出M.Value = tbl(i).Item(tbl.刷出MColumn.ColumnName)
                Me.Fields.Detail2(i).つなぎロス.Value = tbl(i).Item(tbl.つなぎロスColumn.ColumnName)
                Me.Fields.Detail2(i).その他M.Value = tbl(i).Item(tbl.その他MColumn.ColumnName)
                Me.Fields.Detail2(i).希望納期日付.Value = tbl(i).Item(tbl.希望納期日付Column.ColumnName)
                Me.Fields.Detail2(i).希望時間帯区分.Value = tbl(i).Item(tbl.希望時間帯区分Column.ColumnName)
                Me.Fields.Detail2(i).基準長.Value = tbl(i).Item(tbl.基準長Column.ColumnName)
                Me.Fields.Detail2(i).完納区分.Value = tbl(i).Item(tbl.完納区分Column.ColumnName)
                Me.Fields.Detail2(i).発注用摘要1.Value = tbl(i).Item(tbl.発注用摘要1Column.ColumnName)
                Me.Fields.Detail2(i).発注用摘要2.Value = tbl(i).Item(tbl.発注用摘要2Column.ColumnName)
                Me.Fields.Detail2(i).発注用摘要3.Value = tbl(i).Item(tbl.発注用摘要3Column.ColumnName)

                Me.Fields.Detail2(i).仕入先名.Value = tbl(i).Item(tbl.仕入先名Column.ColumnName)
                Me.Fields.Detail2(i).仕入先指定区分名.Value = tbl(i).Item(tbl.仕入先指定区分名Column.ColumnName)
                Me.Fields.Detail2(i).単価区分名.Value = tbl(i).Item(tbl.単価区分名Column.ColumnName)
                Me.Fields.Detail2(i).納入区分名.Value = tbl(i).Item(tbl.納入区分名Column.ColumnName)
                Me.Fields.Detail2(i).支給区分名.Value = tbl(i).Item(tbl.支給区分名Column.ColumnName)
                Me.Fields.Detail2(i).希望時間帯区分名.Value = tbl(i).Item(tbl.希望時間帯区分名Column.ColumnName)
                Me.Fields.Detail2(i).完納区分名.Value = tbl(i).Item(tbl.完納区分名Column.ColumnName)
            Next

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return True
        End Function
#End Region

#Region "Valid(Write)"
        '''========================================================================================
        ''' <summary>検査</summary>
        ''' <RETURNS>True:正常, False:不正</RETURNS>
        '''========================================================================================
        Protected Overrides Function Valid_Write_Detail2_Common() As NodeContents.ActionButton.ErrorLevel
            '----------------------------------------------------------------------
            ' 変数定義
            '----------------------------------------------------------------------
            Dim strMsg As String = ""
            Dim Validator As New BaseCore.Common.Validator

            '------------------------------------------------------------------
            ' ｴﾗｰｸﾘｱ
            '------------------------------------------------------------------
            For i As Integer = 0 To Me.Fields.Detail2.Count - 1
                Me.Fields.Detail2(i).作業NO.IsError = False
                Me.Fields.Detail2(i).紙CD.IsError = False
                Me.Fields.Detail2(i).紙名.IsError = False
                Me.Fields.Detail2(i).糊CD.IsError = False
                Me.Fields.Detail2(i).糊名.IsError = False
                Me.Fields.Detail2(i).台紙CD.IsError = False
                Me.Fields.Detail2(i).台紙名.IsError = False
                Me.Fields.Detail2(i).寸法巾.IsError = False
                Me.Fields.Detail2(i).寸法長.IsError = False
                Me.Fields.Detail2(i).仕入先指定区分.IsError = False
                Me.Fields.Detail2(i).仕入先CD.IsError = False
                Me.Fields.Detail2(i).支社CD.IsError = False
                Me.Fields.Detail2(i).単価区分.IsError = False
                Me.Fields.Detail2(i).発注単価.IsError = False
                Me.Fields.Detail2(i).社内単価.IsError = False
                Me.Fields.Detail2(i).納入区分.IsError = False
                Me.Fields.Detail2(i).支給区分.IsError = False
                Me.Fields.Detail2(i).有償支給単価.IsError = False
                Me.Fields.Detail2(i).発注日付.IsError = False
                Me.Fields.Detail2(i).通数.IsError = False
                Me.Fields.Detail2(i).送りMM.IsError = False
                Me.Fields.Detail2(i).刷出M.IsError = False
                Me.Fields.Detail2(i).つなぎロス.IsError = False
                Me.Fields.Detail2(i).その他M.IsError = False
                Me.Fields.Detail2(i).希望納期日付.IsError = False
                Me.Fields.Detail2(i).希望時間帯区分.IsError = False
                Me.Fields.Detail2(i).基準長.IsError = False
                Me.Fields.Detail2(i).完納区分.IsError = False
                Me.Fields.Detail2(i).発注用摘要1.IsError = False
                Me.Fields.Detail2(i).発注用摘要2.IsError = False
                Me.Fields.Detail2(i).発注用摘要3.IsError = False
            Next

            '------------------------------------------------------------------
            ' 共通検査
            '------------------------------------------------------------------
            For i As Integer = 0 To Me.Fields.Detail2.Count - 1
                If Me.Empty_Detail2(Me.Fields.Detail1(i)) Then
                    Continue For
                End If

                Validator.BaseChecker(Me.Fields.Detail2(i).作業NO, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail2(i).紙CD, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail2(i).紙名, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail2(i).糊CD, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail2(i).糊名, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail2(i).台紙CD, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail2(i).台紙名, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail2(i).寸法巾, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail2(i).寸法長, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail2(i).仕入先指定区分, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail2(i).仕入先CD, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail2(i).支社CD, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail2(i).単価区分, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail2(i).発注単価, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail2(i).社内単価, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail2(i).納入区分, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail2(i).支給区分, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail2(i).有償支給単価, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail2(i).発注日付, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail2(i).通数, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail2(i).送りMM, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail2(i).刷出M, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail2(i).つなぎロス, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail2(i).その他M, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail2(i).希望納期日付, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail2(i).希望時間帯区分, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail2(i).基準長, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail2(i).完納区分, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail2(i).発注用摘要1, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail2(i).発注用摘要2, strMsg, Me.ControlError)
                Validator.BaseChecker(Me.Fields.Detail2(i).発注用摘要3, strMsg, Me.ControlError)
            Next

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

#Region "無効行判定"
        '''========================================================================================
        ''' <summary>無効行の判定</summary>
        ''' <param name="Detail">明細行</param>
        ''' <returns>True:無効行, False:有効行</returns>
        '''========================================================================================
        Protected Overrides Function Empty_Detail2(ByVal Detail As Object) As Boolean
            '------------------------------------------------------------------
            ' 変数定義
            '------------------------------------------------------------------
            Dim row As Detail2 = CType(Detail, Detail2)

            '------------------------------------------------------------------
            ' 入力有は有効行
            '------------------------------------------------------------------
            Select Case True
                Case Not BaseCore.Common.Text.IsEmptyOrZero(row.紙CD.Value) : Return False
            End Select

            '------------------------------------------------------------------
            ' 無効行
            '------------------------------------------------------------------
            Return True
        End Function
#End Region

#Region "行挿入"
        '''========================================================================================
        ''' <summary>単一行挿入</summary>
        '''========================================================================================
        Public Overrides Sub Insert_Detail2(ByVal Position As Integer)
            '----------------------------------------------------------------------
            ' 行挿入
            '----------------------------------------------------------------------
            Me.Fields.Detail2.Insert(Position, New Detail2(Me.Config))

            '----------------------------------------------------------------------
            ' 行ｸﾘｱ
            '----------------------------------------------------------------------
            Me.Clear_Detail2(Position)

            '----------------------------------------------------------------------
            ' 行番号の再付番
            '----------------------------------------------------------------------
            Me.ReNum_Detail2()
        End Sub

        '''========================================================================================
        ''' <summary>複数行挿入</summary>
        '''========================================================================================
        Public Overrides Sub Insert_Detail2(ByVal Position As Integer, ByVal Count As Integer)
            '----------------------------------------------------------------------
            ' 行挿入 & 行ｸﾘｱ
            '----------------------------------------------------------------------
            For i As Integer = Position To Position + Count - 1
                Me.Fields.Detail2.Insert(Position, New Detail2(Me.Config))
                Me.Clear_Detail2(Position)
            Next

            '----------------------------------------------------------------------
            ' 行番号の再付番
            '----------------------------------------------------------------------
            Me.ReNum_Detail2()
        End Sub
#End Region

#Region "行複写"
        '''========================================================================================
        ''' <summary>単一行複写</summary>
        '''========================================================================================
        Public Overrides Sub Copy_Detail2(ByVal Position As Integer)
            '----------------------------------------------------------------------
            ' 行挿入
            '----------------------------------------------------------------------
            Me.Fields.Detail2.Insert(Position, New Detail2(Me.Config))

            '----------------------------------------------------------------------
            ' 行ｺﾋﾟｰ
            '----------------------------------------------------------------------
            Me.CopyValue_Detail2(Position + 1, Position)

            '----------------------------------------------------------------------
            ' 行番号の再付番
            '----------------------------------------------------------------------
            Me.ReNum_Detail2()
        End Sub

        '''========================================================================================
        ''' <summary>値ｺﾋﾟｰ</summary>
        '''========================================================================================
        Protected Function CopyValue_Detail2(ByVal IndexF As Integer, ByVal IndexT As Integer) As Boolean
            Me.Fields.Detail2(IndexT).作業NO.Value = Me.Fields.Detail2(IndexF).作業NO.Value
            Me.Fields.Detail2(IndexT).紙CD.Value = Me.Fields.Detail2(IndexF).紙CD.Value
            Me.Fields.Detail2(IndexT).紙名.Value = Me.Fields.Detail2(IndexF).紙名.Value
            Me.Fields.Detail2(IndexT).糊CD.Value = Me.Fields.Detail2(IndexF).糊CD.Value
            Me.Fields.Detail2(IndexT).糊名.Value = Me.Fields.Detail2(IndexF).糊名.Value
            Me.Fields.Detail2(IndexT).台紙CD.Value = Me.Fields.Detail2(IndexF).台紙CD.Value
            Me.Fields.Detail2(IndexT).台紙名.Value = Me.Fields.Detail2(IndexF).台紙名.Value
            Me.Fields.Detail2(IndexT).寸法巾.Value = Me.Fields.Detail2(IndexF).寸法巾.Value
            Me.Fields.Detail2(IndexT).寸法長.Value = Me.Fields.Detail2(IndexF).寸法長.Value
            Me.Fields.Detail2(IndexT).仕入先指定区分.Value = Me.Fields.Detail2(IndexF).仕入先指定区分.Value
            Me.Fields.Detail2(IndexT).仕入先CD.Value = Me.Fields.Detail2(IndexF).仕入先CD.Value
            Me.Fields.Detail2(IndexT).支社CD.Value = Me.Fields.Detail2(IndexF).支社CD.Value
            Me.Fields.Detail2(IndexT).単価区分.Value = Me.Fields.Detail2(IndexF).単価区分.Value
            Me.Fields.Detail2(IndexT).発注単価.Value = Me.Fields.Detail2(IndexF).発注単価.Value
            Me.Fields.Detail2(IndexT).社内単価.Value = Me.Fields.Detail2(IndexF).社内単価.Value
            Me.Fields.Detail2(IndexT).納入区分.Value = Me.Fields.Detail2(IndexF).納入区分.Value
            Me.Fields.Detail2(IndexT).支給区分.Value = Me.Fields.Detail2(IndexF).支給区分.Value
            Me.Fields.Detail2(IndexT).有償支給単価.Value = Me.Fields.Detail2(IndexF).有償支給単価.Value
            Me.Fields.Detail2(IndexT).発注日付.Value = Me.Fields.Detail2(IndexF).発注日付.Value
            Me.Fields.Detail2(IndexT).通数.Value = Me.Fields.Detail2(IndexF).通数.Value
            Me.Fields.Detail2(IndexT).送りMM.Value = Me.Fields.Detail2(IndexF).送りMM.Value
            Me.Fields.Detail2(IndexT).刷出M.Value = Me.Fields.Detail2(IndexF).刷出M.Value
            Me.Fields.Detail2(IndexT).つなぎロス.Value = Me.Fields.Detail2(IndexF).つなぎロス.Value
            Me.Fields.Detail2(IndexT).その他M.Value = Me.Fields.Detail2(IndexF).その他M.Value
            Me.Fields.Detail2(IndexT).希望納期日付.Value = Me.Fields.Detail2(IndexF).希望納期日付.Value
            Me.Fields.Detail2(IndexT).希望時間帯区分.Value = Me.Fields.Detail2(IndexF).希望時間帯区分.Value
            Me.Fields.Detail2(IndexT).基準長.Value = Me.Fields.Detail2(IndexF).基準長.Value
            Me.Fields.Detail2(IndexT).完納区分.Value = Me.Fields.Detail2(IndexF).完納区分.Value
            Me.Fields.Detail2(IndexT).発注用摘要1.Value = Me.Fields.Detail2(IndexF).発注用摘要1.Value
            Me.Fields.Detail2(IndexT).発注用摘要2.Value = Me.Fields.Detail2(IndexF).発注用摘要2.Value
            Me.Fields.Detail2(IndexT).発注用摘要3.Value = Me.Fields.Detail2(IndexF).発注用摘要3.Value

            Me.Fields.Detail2(IndexT).仕入先名.Value = Me.Fields.Detail2(IndexF).仕入先名.Value
            Me.Fields.Detail2(IndexT).仕入先指定区分名.Value = Me.Fields.Detail2(IndexF).仕入先指定区分名.Value
            Me.Fields.Detail2(IndexT).単価区分名.Value = Me.Fields.Detail2(IndexF).単価区分名.Value
            Me.Fields.Detail2(IndexT).納入区分名.Value = Me.Fields.Detail2(IndexF).納入区分名.Value
            Me.Fields.Detail2(IndexT).支給区分名.Value = Me.Fields.Detail2(IndexF).支給区分名.Value
            Me.Fields.Detail2(IndexT).希望時間帯区分名.Value = Me.Fields.Detail2(IndexF).希望時間帯区分名.Value
            Me.Fields.Detail2(IndexT).完納区分名.Value = Me.Fields.Detail2(IndexF).完納区分名.Value
        End Function
#End Region

#Region "行追加"
        '''========================================================================================
        ''' <summary>単一行追加</summary>
        '''========================================================================================
        Public Overrides Sub Add_Detail2()
            Me.Fields.Detail2.Add(New Detail2(Me.Config))
            Me.Clear_Detail2(Me.Fields.Detail2.Count - 1)
        End Sub

        '''========================================================================================
        ''' <summary>一括行追加</summary>
        ''' <param name="AddCount">追加行数</param>
        '''========================================================================================
        Public Overrides Sub Add_Detail2(ByVal AddCount As Integer, Optional Clear As Boolean = True)
            If Clear Then
                Me.Fields.Detail2.Clear()
            End If

            For i As Integer = 0 To AddCount - 1
                Me.Add_Detail2()
            Next
        End Sub
#End Region

#Region "行削除"
        '''========================================================================================
        ''' <summary>一括行削除</summary>
        '''========================================================================================
        Public Overrides Sub Del_Detail2()
            Me.Fields.Detail2.Clear()
        End Sub

        '''========================================================================================
        ''' <summary>一括行削除</summary>
        '''========================================================================================
        Public Overrides Sub Del_Detail2(ByVal Position As Integer)
            Me.Fields.Detail2.RemoveAt(Position)
        End Sub
#End Region
#End Region

#Region "その他"
#Region "本台帳NO/作業NO算出"
        '''========================================================================================
        ''' <SUMMARY>本台帳NO/作業NO算出</SUMMARY>
        ''' <RETURNS>ｷｰNO</RETURNS>
        '''========================================================================================
        Private Function KeyNO_Value() As String
            ' 再版で登録の場合は本台帳NOより検索
            Dim strReturn As String = ""
            Select Case True
                Case Me.Fields.HeaderBase.新再版区分.Value = NodeContents.Constant.CodeValue.新再版区分.新版
                    Select Case True
                        Case Me.Fields.HeaderBase.処理登録.Value = NodeContents.Constant.CodeValue.フラグ.オン : strReturn = Me.Fields.HeaderBase.作業NO.Value
                        Case Me.Fields.HeaderBase.処理修正.Value = NodeContents.Constant.CodeValue.フラグ.オン : strReturn = Me.Fields.HeaderBase.作業NO.Value
                        Case Me.Fields.HeaderBase.処理削除.Value = NodeContents.Constant.CodeValue.フラグ.オン : strReturn = Me.Fields.HeaderBase.作業NO.Value
                    End Select
                Case Me.Fields.HeaderBase.新再版区分.Value = NodeContents.Constant.CodeValue.新再版区分.再版
                    Select Case True
                        Case Me.Fields.HeaderBase.処理登録.Value = NodeContents.Constant.CodeValue.フラグ.オン : strReturn = Me.Fields.HeaderBase.本台帳NO.Value
                        Case Me.Fields.HeaderBase.処理修正.Value = NodeContents.Constant.CodeValue.フラグ.オン : strReturn = Me.Fields.HeaderBase.作業NO.Value
                        Case Me.Fields.HeaderBase.処理削除.Value = NodeContents.Constant.CodeValue.フラグ.オン : strReturn = Me.Fields.HeaderBase.作業NO.Value
                    End Select
            End Select

            Return strReturn
        End Function
#End Region

#Region "本台帳NO/作業NO検査"
        '''========================================================================================
        ''' <SUMMARY>本台帳NO/作業NO入力検査</SUMMARY>
        ''' <RETURNS>True:正常, False:不正</RETURNS>
        '''========================================================================================
        Public Function KeyNO_Check() As Boolean
            Dim strMsg As String = ""

            ' 再版で登録の場合は本台帳NOより検索
            Dim strキーNO As String = Left(Me.KeyNO_Value, 1)

            Select Case True
                Case Me.Fields.HeaderBase.新再版区分.Value = NodeContents.Constant.CodeValue.新再版区分.新版
                    If strキーNO <> "0" Then
                        strMsg = "本台帳NO頭1桁が0以外です"
                    End If

                Case Me.Fields.HeaderBase.新再版区分.Value = NodeContents.Constant.CodeValue.新再版区分.再版
                    Select Case True
                        Case Me.Fields.HeaderBase.処理登録.Value = NodeContents.Constant.CodeValue.フラグ.オン
                            If strキーNO <> "0" Then
                                strMsg = "本台帳NO頭1桁が0以外です"
                            End If
                        Case Me.Fields.HeaderBase.処理修正.Value = NodeContents.Constant.CodeValue.フラグ.オン, Me.Fields.HeaderBase.処理削除.Value = NodeContents.Constant.CodeValue.フラグ.オン
                            ' 再版の修正時は作業NOのため先頭が1～6の場合NG
                            If strキーNO = "0" Then
                                strMsg = "作業NO頭1桁が1～6以外です"
                            End If
                    End Select

            End Select

            '----------------------------------------------------------------------
            ' 返却
            '----------------------------------------------------------------------
            MyBase.LastError = strMsg
            Return (strMsg = "")
        End Function
#End Region

#Region "再版新規登録時のﾃﾞｰﾀ表示"
        '''========================================================================================
        ''' <SUMMARY>再版新規登録時のﾃﾞｰﾀ表示</SUMMARY>
        ''' <RETURNS>True:正常, False:不正</RETURNS>
        '''========================================================================================
        Public Function RePrintShow() As Boolean

            '----------------------------------------------------------------------
            ' 変更が必要な項目はｸﾘｱ
            '----------------------------------------------------------------------
            ' ﾒｲﾝ
            Me.Fields.HeaderBase.本台帳NO.Value = Me.Fields.HeaderBase.作業NO.Value
            Me.Fields.HeaderBase.作業NO.Value = Nothing
            Me.Fields.HeaderBase.受注日付.Value = Nothing
            Me.Fields.HeaderBase.納品日付A.Value = Nothing
            Me.Fields.HeaderBase.納品日付B.Value = Nothing
            Me.Fields.HeaderBase.確約区分.Value = NodeContents.Constant.CodeValue.確約区分.通常
            Me.Fields.HeaderBase.入力担当者CD.Value = Nothing
            Me.Fields.HeaderBase.担当者名.Value = Nothing
            Me.Fields.HeaderBase.通数1.Value = Nothing
            Me.Fields.HeaderBase.通数2.Value = Nothing
            Me.Fields.HeaderBase.通数3.Value = Nothing

            Me.Fields.HeaderBase.売上金額01.Value = Nothing
            Me.Fields.HeaderBase.売上区分01.Value = Nothing
            Me.Fields.HeaderBase.売上名01.Value = Nothing
            Me.Fields.HeaderBase.売上数量01.Value = Nothing
            Me.Fields.HeaderBase.売上単価01.Value = Nothing
            Me.Fields.HeaderBase.売上金額02.Value = Nothing
            Me.Fields.HeaderBase.売上区分02.Value = Nothing
            Me.Fields.HeaderBase.売上名02.Value = Nothing
            Me.Fields.HeaderBase.売上数量02.Value = Nothing
            Me.Fields.HeaderBase.売上単価02.Value = Nothing
            Me.Fields.HeaderBase.売上金額03.Value = Nothing
            Me.Fields.HeaderBase.売上区分03.Value = Nothing
            Me.Fields.HeaderBase.売上名03.Value = Nothing
            Me.Fields.HeaderBase.売上数量03.Value = Nothing
            Me.Fields.HeaderBase.売上単価03.Value = Nothing
            Me.Fields.HeaderBase.売上金額04.Value = Nothing
            Me.Fields.HeaderBase.売上区分04.Value = Nothing
            Me.Fields.HeaderBase.売上名04.Value = Nothing
            Me.Fields.HeaderBase.売上数量04.Value = Nothing
            Me.Fields.HeaderBase.売上単価04.Value = Nothing
            Me.Fields.HeaderBase.売上金額05.Value = Nothing
            Me.Fields.HeaderBase.売上区分05.Value = Nothing
            Me.Fields.HeaderBase.売上名05.Value = Nothing
            Me.Fields.HeaderBase.売上数量05.Value = Nothing
            Me.Fields.HeaderBase.売上単価05.Value = Nothing

            Me.Fields.HeaderBase.出荷先CD01.Value = Nothing
            Me.Fields.HeaderBase.出荷先名01.Value = Nothing
            Me.Fields.HeaderBase.出荷先CD02.Value = Nothing
            Me.Fields.HeaderBase.出荷先名02.Value = Nothing
            Me.Fields.HeaderBase.出荷先CD03.Value = Nothing
            Me.Fields.HeaderBase.出荷先名03.Value = Nothing
            Me.Fields.HeaderBase.出荷先CD04.Value = Nothing
            Me.Fields.HeaderBase.出荷先名04.Value = Nothing

            ' 商品内訳
            For i As Integer = 0 To Me.Fields.Detail1.Count - 1
                Me.Fields.Detail1(i).作業NO.Value = Nothing
                Me.Fields.Detail1(i).枝番.Value = Nothing
                Me.Fields.Detail1(i).定番CD.Value = Nothing
                Me.Fields.Detail1(i).商品名.Value = Nothing
                Me.Fields.Detail1(i).受注数.Value = Nothing
                Me.Fields.Detail1(i).内在庫引当数.Value = Nothing
                Me.Fields.Detail1(i).受注単価.Value = Nothing
                Me.Fields.Detail1(i).発注単価.Value = Nothing
                Me.Fields.Detail1(i).納品日付A.Value = Nothing
                Me.Fields.Detail1(i).納品日付B.Value = Nothing
                Me.Fields.Detail1(i).顧客商品CD.Value = Nothing
                Me.Fields.Detail1(i).顧客発注NO.Value = Nothing
                Me.Fields.Detail1(i).倉庫NO.Value = Nothing
                Me.Fields.Detail1(i).備考.Value = Nothing

                Me.Fields.Detail1(i).内製造数.Value = Nothing
            Next

            ' 紙発注
            For i As Integer = 0 To Me.Fields.Detail2.Count - 1
                Me.Fields.Detail2(i).寸法長.Value = Nothing
                Me.Fields.Detail2(i).発注日付.Value = Nothing
                Me.Fields.Detail2(i).通数.Value = Nothing
                Me.Fields.Detail2(i).希望納期日付.Value = Nothing
                Me.Fields.Detail2(i).希望時間帯区分.Value = Nothing
            Next

            ' 外注発注
            Me.Fields.HeaderOut.発注納期.Value = Nothing
            Me.Fields.HeaderOut.発注金額.Value = Nothing

            '----------------------------------------------------------------------
            ' 返却
            '----------------------------------------------------------------------
            Return True
        End Function
#End Region

#Region "商品内訳明細計算"
        '''========================================================================================
        ''' <SUMMARY>商品内訳明細計算</SUMMARY>
        ''' <RETURNS>True:正常, False:不正</RETURNS>
        '''========================================================================================
        Public Function Clac_ItemDetail() As Boolean
            '----------------------------------------------------------------------
            ' 変数定義
            '----------------------------------------------------------------------
            Dim dec受注数合計 As Decimal = 0
            Dim dec在庫数合計 As Decimal = 0
            Dim dec製造数合計 As Decimal = 0

            ' 受注数合計       = 商品内訳の受注数のSUM
            ' 内在庫引当数合計 = 商品内訳の内在庫引当数のSUM
            For i As Integer = 0 To Me.Fields.Detail1.Count - 1
                If Me.Empty_Detail1(Me.Fields.Detail1(i)) Then
                    Continue For
                End If

                dec受注数合計 += BaseCore.Common.Text.CVal(Me.Fields.Detail1(i).受注数.Value)
                dec在庫数合計 += BaseCore.Common.Text.CVal(Me.Fields.Detail1(i).内在庫引当数.Value)
            Next

            Me.Fields.HeaderBase.受注数合計.Value = Format(dec受注数合計, "#,##0")
            Me.Fields.HeaderBase.内在庫引当数合計.Value = Format(dec在庫数合計, "#,##0")

            ' 内製造数合計 = 受注数合計 - 内在庫引当数合計
            dec製造数合計 = dec受注数合計 - dec在庫数合計
            Me.Fields.HeaderBase.内製造数合計.Value = Format(dec製造数合計, "#,##0")

            ' 受注金額
            Me.Clac_OrderMoney()

            '----------------------------------------------------------------------
            ' 返却
            '----------------------------------------------------------------------
            Return True
        End Function
#End Region

#Region "受注金額計算"
        '''========================================================================================
        ''' <SUMMARY>受注金額計算</SUMMARY>
        ''' <RETURNS>True:正常, False:不正</RETURNS>
        '''========================================================================================
        Public Function Clac_OrderMoney() As Boolean
            '----------------------------------------------------------------------
            ' 変数定義
            '----------------------------------------------------------------------
            Dim dec受注金額 As Decimal = 0

            ' 受注金額 = 受注数合計 * 受注単価
            dec受注金額 = BaseCore.Common.Text.CVal(Me.Fields.HeaderBase.受注数合計.Value) * BaseCore.Common.Text.CVal(Me.Fields.HeaderBase.受注単価.Value)
            Me.Fields.HeaderBase.受注金額.Value = Format(dec受注金額, "#,##0")

            '----------------------------------------------------------------------
            ' 返却
            '----------------------------------------------------------------------
            Return True
        End Function
#End Region

#Region "通数計算"
        '''========================================================================================
        ''' <SUMMARY>通数計算</SUMMARY>
        ''' <RETURNS>True:正常, False:不正</RETURNS>
        '''========================================================================================
        Public Function Clac_PrintQty() As Boolean
            '----------------------------------------------------------------------
            ' 変数定義
            '----------------------------------------------------------------------
            Dim dec通数合計 As Decimal = 0

            ' 通数合計 = 通数1 + 通数2 + 通数3
            dec通数合計 = BaseCore.Common.Text.CVal(Me.Fields.HeaderBase.通数1.Value) + BaseCore.Common.Text.CVal(Me.Fields.HeaderBase.通数2.Value) + BaseCore.Common.Text.CVal(Me.Fields.HeaderBase.通数3.Value)
            Me.Fields.HeaderBase.通数合計.Value = dec通数合計

            '----------------------------------------------------------------------
            ' 返却
            '----------------------------------------------------------------------
            Return True
        End Function
#End Region
#End Region
    End Class
End Namespace
