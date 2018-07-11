﻿Namespace Frame.Master
    Partial Public Class Supplier
        Inherits NodeCore.Common.Frame

#Region "ﾌｨｰﾙﾄﾞ定義"
#Region "Header"
        Public Class Header
            ''' ----------------------------------------------------------------------------------------
            ''' <SUMMARY>列項目(基本)</SUMMARY>
            ''' ----------------------------------------------------------------------------------------
            Public 仕入先CD As BaseCore.Common.Field.ItemData
            Public 仕入先名 As BaseCore.Common.Field.ItemData
            Public 略称 As BaseCore.Common.Field.ItemData
            Public カナ名 As BaseCore.Common.Field.ItemData
            Public 郵便番号 As BaseCore.Common.Field.ItemData
            Public 住所1 As BaseCore.Common.Field.ItemData
            Public 住所2 As BaseCore.Common.Field.ItemData
            Public 役職_担当者名 As BaseCore.Common.Field.ItemData
            Public TEL As BaseCore.Common.Field.ItemData
            Public 買掛金_未払金区分 As BaseCore.Common.Field.ItemData
            Public 代表者役職_代表者名1 As BaseCore.Common.Field.ItemData
            Public FAX As BaseCore.Common.Field.ItemData
            Public 代表者役職_代表者名2 As BaseCore.Common.Field.ItemData

            Public 処理登録 As BaseCore.Common.Field.ItemData
            Public 処理修正 As BaseCore.Common.Field.ItemData
            Public 処理削除 As BaseCore.Common.Field.ItemData

            '''========================================================================================
            ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
            '''========================================================================================
            Public Sub New(ByVal Config As NodeCore.Common.Config)
                Dim tbl As New NodeDatabase.DataSetView.V0仕入先DataTable

                '----------------------------------------------------------------------
                ' ｲﾝｽﾀﾝｽ(基本)
                '----------------------------------------------------------------------
                Me.仕入先CD = New BaseCore.Common.Field.ItemData(tbl.仕入先CDColumn)
                Me.仕入先名 = New BaseCore.Common.Field.ItemData(tbl.仕入先名Column)
                Me.略称 = New BaseCore.Common.Field.ItemData(tbl.略称Column)
                Me.カナ名 = New BaseCore.Common.Field.ItemData(tbl.カナ名Column)
                Me.郵便番号 = New BaseCore.Common.Field.ItemData(tbl.郵便番号Column)
                Me.住所1 = New BaseCore.Common.Field.ItemData(tbl.住所1Column)
                Me.住所2 = New BaseCore.Common.Field.ItemData(tbl.住所2Column)
                Me.役職_担当者名 = New BaseCore.Common.Field.ItemData(tbl.役職_担当者名Column)
                Me.TEL = New BaseCore.Common.Field.ItemData(tbl.TELColumn)
                Me.買掛金_未払金区分 = New BaseCore.Common.Field.ItemData(tbl.買掛金_未払金区分Column)
                Me.代表者役職_代表者名1 = New BaseCore.Common.Field.ItemData(tbl.代表者役職_代表者名1Column)
                Me.FAX = New BaseCore.Common.Field.ItemData(tbl.FAXColumn)
                Me.代表者役職_代表者名2 = New BaseCore.Common.Field.ItemData(tbl.代表者役職_代表者名2Column)

                Me.処理登録 = New BaseCore.Common.Field.ItemData("処理登録", TypeCode.String, 1)
                Me.処理修正 = New BaseCore.Common.Field.ItemData("処理修正", TypeCode.String, 1)
                Me.処理削除 = New BaseCore.Common.Field.ItemData("処理削除", TypeCode.String, 1)
            End Sub
        End Class
#End Region

#Region "Detail"
        Public Class Detail
            ''' ----------------------------------------------------------------------------------------
            ''' <SUMMARY>列項目(基本)</SUMMARY>
            ''' ----------------------------------------------------------------------------------------
            Public 行NO As BaseCore.Common.Field.ItemData
            Public 部署名_01 As BaseCore.Common.Field.ItemData
            Public 部署名_02 As BaseCore.Common.Field.ItemData
            Public 部署名_03 As BaseCore.Common.Field.ItemData
            Public 部署名_04 As BaseCore.Common.Field.ItemData
            Public 部署名_05 As BaseCore.Common.Field.ItemData
            Public 部署名_06 As BaseCore.Common.Field.ItemData
            Public 部署名_07 As BaseCore.Common.Field.ItemData
            Public 部署名_08 As BaseCore.Common.Field.ItemData
            Public 部署名_09 As BaseCore.Common.Field.ItemData
            Public 部署名_10 As BaseCore.Common.Field.ItemData
            Public 部署名_11 As BaseCore.Common.Field.ItemData
            Public 担当者名_01 As BaseCore.Common.Field.ItemData
            Public 担当者名_02 As BaseCore.Common.Field.ItemData
            Public 担当者名_03 As BaseCore.Common.Field.ItemData
            Public 担当者名_04 As BaseCore.Common.Field.ItemData
            Public 担当者名_05 As BaseCore.Common.Field.ItemData
            Public 担当者名_06 As BaseCore.Common.Field.ItemData
            Public 担当者名_07 As BaseCore.Common.Field.ItemData
            Public 担当者名_08 As BaseCore.Common.Field.ItemData
            Public 担当者名_09 As BaseCore.Common.Field.ItemData
            Public 担当者名_10 As BaseCore.Common.Field.ItemData
            Public 担当者名_11 As BaseCore.Common.Field.ItemData
            Public 郵便番号_01 As BaseCore.Common.Field.ItemData
            Public 郵便番号_02 As BaseCore.Common.Field.ItemData
            Public 郵便番号_03 As BaseCore.Common.Field.ItemData
            Public 郵便番号_04 As BaseCore.Common.Field.ItemData
            Public 郵便番号_05 As BaseCore.Common.Field.ItemData
            Public 郵便番号_06 As BaseCore.Common.Field.ItemData
            Public 郵便番号_07 As BaseCore.Common.Field.ItemData
            Public 郵便番号_08 As BaseCore.Common.Field.ItemData
            Public 郵便番号_09 As BaseCore.Common.Field.ItemData
            Public 郵便番号_10 As BaseCore.Common.Field.ItemData
            Public 郵便番号_11 As BaseCore.Common.Field.ItemData
            Public 住所1_01 As BaseCore.Common.Field.ItemData
            Public 住所1_02 As BaseCore.Common.Field.ItemData
            Public 住所1_03 As BaseCore.Common.Field.ItemData
            Public 住所1_04 As BaseCore.Common.Field.ItemData
            Public 住所1_05 As BaseCore.Common.Field.ItemData
            Public 住所1_06 As BaseCore.Common.Field.ItemData
            Public 住所1_07 As BaseCore.Common.Field.ItemData
            Public 住所1_08 As BaseCore.Common.Field.ItemData
            Public 住所1_09 As BaseCore.Common.Field.ItemData
            Public 住所1_10 As BaseCore.Common.Field.ItemData
            Public 住所1_11 As BaseCore.Common.Field.ItemData
            Public 住所2_01 As BaseCore.Common.Field.ItemData
            Public 住所2_02 As BaseCore.Common.Field.ItemData
            Public 住所2_03 As BaseCore.Common.Field.ItemData
            Public 住所2_04 As BaseCore.Common.Field.ItemData
            Public 住所2_05 As BaseCore.Common.Field.ItemData
            Public 住所2_06 As BaseCore.Common.Field.ItemData
            Public 住所2_07 As BaseCore.Common.Field.ItemData
            Public 住所2_08 As BaseCore.Common.Field.ItemData
            Public 住所2_09 As BaseCore.Common.Field.ItemData
            Public 住所2_10 As BaseCore.Common.Field.ItemData
            Public 住所2_11 As BaseCore.Common.Field.ItemData
            Public TEL_01 As BaseCore.Common.Field.ItemData
            Public TEL_02 As BaseCore.Common.Field.ItemData
            Public TEL_03 As BaseCore.Common.Field.ItemData
            Public TEL_04 As BaseCore.Common.Field.ItemData
            Public TEL_05 As BaseCore.Common.Field.ItemData
            Public TEL_06 As BaseCore.Common.Field.ItemData
            Public TEL_07 As BaseCore.Common.Field.ItemData
            Public TEL_08 As BaseCore.Common.Field.ItemData
            Public TEL_09 As BaseCore.Common.Field.ItemData
            Public TEL_10 As BaseCore.Common.Field.ItemData
            Public TEL_11 As BaseCore.Common.Field.ItemData
            Public FAX_01 As BaseCore.Common.Field.ItemData
            Public FAX_02 As BaseCore.Common.Field.ItemData
            Public FAX_03 As BaseCore.Common.Field.ItemData
            Public FAX_04 As BaseCore.Common.Field.ItemData
            Public FAX_05 As BaseCore.Common.Field.ItemData
            Public FAX_06 As BaseCore.Common.Field.ItemData
            Public FAX_07 As BaseCore.Common.Field.ItemData
            Public FAX_08 As BaseCore.Common.Field.ItemData
            Public FAX_09 As BaseCore.Common.Field.ItemData
            Public FAX_10 As BaseCore.Common.Field.ItemData
            Public FAX_11 As BaseCore.Common.Field.ItemData
            Public 携帯_01 As BaseCore.Common.Field.ItemData
            Public 携帯_02 As BaseCore.Common.Field.ItemData
            Public 携帯_03 As BaseCore.Common.Field.ItemData
            Public 携帯_04 As BaseCore.Common.Field.ItemData
            Public 携帯_05 As BaseCore.Common.Field.ItemData
            Public 携帯_06 As BaseCore.Common.Field.ItemData
            Public 携帯_07 As BaseCore.Common.Field.ItemData
            Public 携帯_08 As BaseCore.Common.Field.ItemData
            Public 携帯_09 As BaseCore.Common.Field.ItemData
            Public 携帯_10 As BaseCore.Common.Field.ItemData
            Public 携帯_11 As BaseCore.Common.Field.ItemData
            Public メール_01 As BaseCore.Common.Field.ItemData
            Public メール_02 As BaseCore.Common.Field.ItemData
            Public メール_03 As BaseCore.Common.Field.ItemData
            Public メール_04 As BaseCore.Common.Field.ItemData
            Public メール_05 As BaseCore.Common.Field.ItemData
            Public メール_06 As BaseCore.Common.Field.ItemData
            Public メール_07 As BaseCore.Common.Field.ItemData
            Public メール_08 As BaseCore.Common.Field.ItemData
            Public メール_09 As BaseCore.Common.Field.ItemData
            Public メール_10 As BaseCore.Common.Field.ItemData
            Public メール_11 As BaseCore.Common.Field.ItemData
            Public 本支店名_01 As BaseCore.Common.Field.ItemData
            Public 本支店名_02 As BaseCore.Common.Field.ItemData
            Public 本支店名_03 As BaseCore.Common.Field.ItemData
            Public 本支店名_04 As BaseCore.Common.Field.ItemData
            Public 本支店名_05 As BaseCore.Common.Field.ItemData
            Public 本支店名_06 As BaseCore.Common.Field.ItemData
            Public 本支店名_07 As BaseCore.Common.Field.ItemData
            Public 本支店名_08 As BaseCore.Common.Field.ItemData
            Public 本支店名_09 As BaseCore.Common.Field.ItemData
            Public 本支店名_10 As BaseCore.Common.Field.ItemData
            Public 本支店名_11 As BaseCore.Common.Field.ItemData

            Public 仕入先名 As BaseCore.Common.Field.ItemData
            Public 役職_担当者名 As BaseCore.Common.Field.ItemData
            Public 代表者役職_代表者名1 As BaseCore.Common.Field.ItemData
            Public 代表者役職_代表者名2 As BaseCore.Common.Field.ItemData

            '''========================================================================================
            ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
            '''========================================================================================
            Public Sub New(ByVal Config As NodeCore.Common.Config)
                Dim tbl As New NodeDatabase.DataSetView.V0仕入先詳細DataTable

                '----------------------------------------------------------------------
                ' ｲﾝｽﾀﾝｽ(基本)
                '----------------------------------------------------------------------
                Me.行NO = New BaseCore.Common.Field.ItemData(tbl.行NOColumn)
                Me.部署名_01 = New BaseCore.Common.Field.ItemData(tbl.部署名Column)
                Me.部署名_02 = New BaseCore.Common.Field.ItemData(tbl.部署名Column)
                Me.部署名_03 = New BaseCore.Common.Field.ItemData(tbl.部署名Column)
                Me.部署名_04 = New BaseCore.Common.Field.ItemData(tbl.部署名Column)
                Me.部署名_05 = New BaseCore.Common.Field.ItemData(tbl.部署名Column)
                Me.部署名_06 = New BaseCore.Common.Field.ItemData(tbl.部署名Column)
                Me.部署名_07 = New BaseCore.Common.Field.ItemData(tbl.部署名Column)
                Me.部署名_08 = New BaseCore.Common.Field.ItemData(tbl.部署名Column)
                Me.部署名_09 = New BaseCore.Common.Field.ItemData(tbl.部署名Column)
                Me.部署名_10 = New BaseCore.Common.Field.ItemData(tbl.部署名Column)
                Me.部署名_11 = New BaseCore.Common.Field.ItemData(tbl.部署名Column)
                Me.担当者名_01 = New BaseCore.Common.Field.ItemData(tbl.担当者名Column)
                Me.担当者名_02 = New BaseCore.Common.Field.ItemData(tbl.担当者名Column)
                Me.担当者名_03 = New BaseCore.Common.Field.ItemData(tbl.担当者名Column)
                Me.担当者名_04 = New BaseCore.Common.Field.ItemData(tbl.担当者名Column)
                Me.担当者名_05 = New BaseCore.Common.Field.ItemData(tbl.担当者名Column)
                Me.担当者名_06 = New BaseCore.Common.Field.ItemData(tbl.担当者名Column)
                Me.担当者名_07 = New BaseCore.Common.Field.ItemData(tbl.担当者名Column)
                Me.担当者名_08 = New BaseCore.Common.Field.ItemData(tbl.担当者名Column)
                Me.担当者名_09 = New BaseCore.Common.Field.ItemData(tbl.担当者名Column)
                Me.担当者名_10 = New BaseCore.Common.Field.ItemData(tbl.担当者名Column)
                Me.担当者名_11 = New BaseCore.Common.Field.ItemData(tbl.担当者名Column)
                Me.郵便番号_01 = New BaseCore.Common.Field.ItemData(tbl.郵便番号Column)
                Me.郵便番号_02 = New BaseCore.Common.Field.ItemData(tbl.郵便番号Column)
                Me.郵便番号_03 = New BaseCore.Common.Field.ItemData(tbl.郵便番号Column)
                Me.郵便番号_04 = New BaseCore.Common.Field.ItemData(tbl.郵便番号Column)
                Me.郵便番号_05 = New BaseCore.Common.Field.ItemData(tbl.郵便番号Column)
                Me.郵便番号_06 = New BaseCore.Common.Field.ItemData(tbl.郵便番号Column)
                Me.郵便番号_07 = New BaseCore.Common.Field.ItemData(tbl.郵便番号Column)
                Me.郵便番号_08 = New BaseCore.Common.Field.ItemData(tbl.郵便番号Column)
                Me.郵便番号_09 = New BaseCore.Common.Field.ItemData(tbl.郵便番号Column)
                Me.郵便番号_10 = New BaseCore.Common.Field.ItemData(tbl.郵便番号Column)
                Me.郵便番号_11 = New BaseCore.Common.Field.ItemData(tbl.郵便番号Column)
                Me.住所1_01 = New BaseCore.Common.Field.ItemData(tbl.住所1Column)
                Me.住所1_02 = New BaseCore.Common.Field.ItemData(tbl.住所1Column)
                Me.住所1_03 = New BaseCore.Common.Field.ItemData(tbl.住所1Column)
                Me.住所1_04 = New BaseCore.Common.Field.ItemData(tbl.住所1Column)
                Me.住所1_05 = New BaseCore.Common.Field.ItemData(tbl.住所1Column)
                Me.住所1_06 = New BaseCore.Common.Field.ItemData(tbl.住所1Column)
                Me.住所1_07 = New BaseCore.Common.Field.ItemData(tbl.住所1Column)
                Me.住所1_08 = New BaseCore.Common.Field.ItemData(tbl.住所1Column)
                Me.住所1_09 = New BaseCore.Common.Field.ItemData(tbl.住所1Column)
                Me.住所1_10 = New BaseCore.Common.Field.ItemData(tbl.住所1Column)
                Me.住所1_11 = New BaseCore.Common.Field.ItemData(tbl.住所1Column)
                Me.住所2_01 = New BaseCore.Common.Field.ItemData(tbl.住所2Column)
                Me.住所2_02 = New BaseCore.Common.Field.ItemData(tbl.住所2Column)
                Me.住所2_03 = New BaseCore.Common.Field.ItemData(tbl.住所2Column)
                Me.住所2_04 = New BaseCore.Common.Field.ItemData(tbl.住所2Column)
                Me.住所2_05 = New BaseCore.Common.Field.ItemData(tbl.住所2Column)
                Me.住所2_06 = New BaseCore.Common.Field.ItemData(tbl.住所2Column)
                Me.住所2_07 = New BaseCore.Common.Field.ItemData(tbl.住所2Column)
                Me.住所2_08 = New BaseCore.Common.Field.ItemData(tbl.住所2Column)
                Me.住所2_09 = New BaseCore.Common.Field.ItemData(tbl.住所2Column)
                Me.住所2_10 = New BaseCore.Common.Field.ItemData(tbl.住所2Column)
                Me.住所2_11 = New BaseCore.Common.Field.ItemData(tbl.住所2Column)
                Me.TEL_01 = New BaseCore.Common.Field.ItemData(tbl.TELColumn)
                Me.TEL_02 = New BaseCore.Common.Field.ItemData(tbl.TELColumn)
                Me.TEL_03 = New BaseCore.Common.Field.ItemData(tbl.TELColumn)
                Me.TEL_04 = New BaseCore.Common.Field.ItemData(tbl.TELColumn)
                Me.TEL_05 = New BaseCore.Common.Field.ItemData(tbl.TELColumn)
                Me.TEL_06 = New BaseCore.Common.Field.ItemData(tbl.TELColumn)
                Me.TEL_07 = New BaseCore.Common.Field.ItemData(tbl.TELColumn)
                Me.TEL_08 = New BaseCore.Common.Field.ItemData(tbl.TELColumn)
                Me.TEL_09 = New BaseCore.Common.Field.ItemData(tbl.TELColumn)
                Me.TEL_10 = New BaseCore.Common.Field.ItemData(tbl.TELColumn)
                Me.TEL_11 = New BaseCore.Common.Field.ItemData(tbl.TELColumn)
                Me.FAX_01 = New BaseCore.Common.Field.ItemData(tbl.FAXColumn)
                Me.FAX_02 = New BaseCore.Common.Field.ItemData(tbl.FAXColumn)
                Me.FAX_03 = New BaseCore.Common.Field.ItemData(tbl.FAXColumn)
                Me.FAX_04 = New BaseCore.Common.Field.ItemData(tbl.FAXColumn)
                Me.FAX_05 = New BaseCore.Common.Field.ItemData(tbl.FAXColumn)
                Me.FAX_06 = New BaseCore.Common.Field.ItemData(tbl.FAXColumn)
                Me.FAX_07 = New BaseCore.Common.Field.ItemData(tbl.FAXColumn)
                Me.FAX_08 = New BaseCore.Common.Field.ItemData(tbl.FAXColumn)
                Me.FAX_09 = New BaseCore.Common.Field.ItemData(tbl.FAXColumn)
                Me.FAX_10 = New BaseCore.Common.Field.ItemData(tbl.FAXColumn)
                Me.FAX_11 = New BaseCore.Common.Field.ItemData(tbl.FAXColumn)
                Me.携帯_01 = New BaseCore.Common.Field.ItemData(tbl.携帯Column)
                Me.携帯_02 = New BaseCore.Common.Field.ItemData(tbl.携帯Column)
                Me.携帯_03 = New BaseCore.Common.Field.ItemData(tbl.携帯Column)
                Me.携帯_04 = New BaseCore.Common.Field.ItemData(tbl.携帯Column)
                Me.携帯_05 = New BaseCore.Common.Field.ItemData(tbl.携帯Column)
                Me.携帯_06 = New BaseCore.Common.Field.ItemData(tbl.携帯Column)
                Me.携帯_07 = New BaseCore.Common.Field.ItemData(tbl.携帯Column)
                Me.携帯_08 = New BaseCore.Common.Field.ItemData(tbl.携帯Column)
                Me.携帯_09 = New BaseCore.Common.Field.ItemData(tbl.携帯Column)
                Me.携帯_10 = New BaseCore.Common.Field.ItemData(tbl.携帯Column)
                Me.携帯_11 = New BaseCore.Common.Field.ItemData(tbl.携帯Column)
                Me.メール_01 = New BaseCore.Common.Field.ItemData(tbl.メールColumn)
                Me.メール_02 = New BaseCore.Common.Field.ItemData(tbl.メールColumn)
                Me.メール_03 = New BaseCore.Common.Field.ItemData(tbl.メールColumn)
                Me.メール_04 = New BaseCore.Common.Field.ItemData(tbl.メールColumn)
                Me.メール_05 = New BaseCore.Common.Field.ItemData(tbl.メールColumn)
                Me.メール_06 = New BaseCore.Common.Field.ItemData(tbl.メールColumn)
                Me.メール_07 = New BaseCore.Common.Field.ItemData(tbl.メールColumn)
                Me.メール_08 = New BaseCore.Common.Field.ItemData(tbl.メールColumn)
                Me.メール_09 = New BaseCore.Common.Field.ItemData(tbl.メールColumn)
                Me.メール_10 = New BaseCore.Common.Field.ItemData(tbl.メールColumn)
                Me.メール_11 = New BaseCore.Common.Field.ItemData(tbl.メールColumn)
                Me.本支店名_01 = New BaseCore.Common.Field.ItemData(tbl.本支店名Column)
                Me.本支店名_02 = New BaseCore.Common.Field.ItemData(tbl.本支店名Column)
                Me.本支店名_03 = New BaseCore.Common.Field.ItemData(tbl.本支店名Column)
                Me.本支店名_04 = New BaseCore.Common.Field.ItemData(tbl.本支店名Column)
                Me.本支店名_05 = New BaseCore.Common.Field.ItemData(tbl.本支店名Column)
                Me.本支店名_06 = New BaseCore.Common.Field.ItemData(tbl.本支店名Column)
                Me.本支店名_07 = New BaseCore.Common.Field.ItemData(tbl.本支店名Column)
                Me.本支店名_08 = New BaseCore.Common.Field.ItemData(tbl.本支店名Column)
                Me.本支店名_09 = New BaseCore.Common.Field.ItemData(tbl.本支店名Column)
                Me.本支店名_10 = New BaseCore.Common.Field.ItemData(tbl.本支店名Column)
                Me.本支店名_11 = New BaseCore.Common.Field.ItemData(tbl.本支店名Column)

                Me.仕入先名 = New BaseCore.Common.Field.ItemData(tbl.仕入先名Column)
                Me.役職_担当者名 = New BaseCore.Common.Field.ItemData(tbl.役職_担当者名Column)
                Me.代表者役職_代表者名1 = New BaseCore.Common.Field.ItemData(tbl.代表者役職_代表者名1Column)
                Me.代表者役職_代表者名2 = New BaseCore.Common.Field.ItemData(tbl.代表者役職_代表者名2Column)
            End Sub
        End Class
#End Region

#Region "Note"
        Public Class Note
            ''' ----------------------------------------------------------------------------------------
            ''' <SUMMARY>列項目(基本)</SUMMARY>
            ''' ----------------------------------------------------------------------------------------
            Public 行NO As BaseCore.Common.Field.ItemData
            Public 特記事項_01 As BaseCore.Common.Field.ItemData
            Public 特記事項_02 As BaseCore.Common.Field.ItemData
            Public 特記事項_03 As BaseCore.Common.Field.ItemData
            Public 特記事項_04 As BaseCore.Common.Field.ItemData
            Public 特記事項_05 As BaseCore.Common.Field.ItemData
            Public 特記事項_06 As BaseCore.Common.Field.ItemData
            Public 特記事項_07 As BaseCore.Common.Field.ItemData
            Public 特記事項_08 As BaseCore.Common.Field.ItemData
            Public 特記事項_09 As BaseCore.Common.Field.ItemData
            Public 特記事項_10 As BaseCore.Common.Field.ItemData
            Public 特記事項_11 As BaseCore.Common.Field.ItemData
            Public 特記事項_12 As BaseCore.Common.Field.ItemData
            Public 特記事項_13 As BaseCore.Common.Field.ItemData

            '''========================================================================================
            ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
            '''========================================================================================
            Public Sub New(ByVal Config As NodeCore.Common.Config)
                Dim tbl As New NodeDatabase.DataSetView.V0仕入先特記DataTable

                '----------------------------------------------------------------------
                ' ｲﾝｽﾀﾝｽ(基本)
                '----------------------------------------------------------------------
                Me.行NO = New BaseCore.Common.Field.ItemData(tbl.行NOColumn)
                Me.特記事項_01 = New BaseCore.Common.Field.ItemData(tbl.特記事項Column)
                Me.特記事項_02 = New BaseCore.Common.Field.ItemData(tbl.特記事項Column)
                Me.特記事項_03 = New BaseCore.Common.Field.ItemData(tbl.特記事項Column)
                Me.特記事項_04 = New BaseCore.Common.Field.ItemData(tbl.特記事項Column)
                Me.特記事項_05 = New BaseCore.Common.Field.ItemData(tbl.特記事項Column)
                Me.特記事項_06 = New BaseCore.Common.Field.ItemData(tbl.特記事項Column)
                Me.特記事項_07 = New BaseCore.Common.Field.ItemData(tbl.特記事項Column)
                Me.特記事項_08 = New BaseCore.Common.Field.ItemData(tbl.特記事項Column)
                Me.特記事項_09 = New BaseCore.Common.Field.ItemData(tbl.特記事項Column)
                Me.特記事項_10 = New BaseCore.Common.Field.ItemData(tbl.特記事項Column)
                Me.特記事項_11 = New BaseCore.Common.Field.ItemData(tbl.特記事項Column)
                Me.特記事項_12 = New BaseCore.Common.Field.ItemData(tbl.特記事項Column)
                Me.特記事項_13 = New BaseCore.Common.Field.ItemData(tbl.特記事項Column)
            End Sub
        End Class
#End Region

#Region "Print"
        Public Class Print
            ''' ----------------------------------------------------------------------------------------
            ''' <SUMMARY>列項目(基本)</SUMMARY>
            ''' ----------------------------------------------------------------------------------------
            Public 仕入先CDF As BaseCore.Common.Field.ItemData
            Public 仕入先CDT As BaseCore.Common.Field.ItemData

            '''========================================================================================
            ''' <SUMMARY>ｺﾝｽﾄﾗｸﾀ</SUMMARY>
            '''========================================================================================
            Public Sub New(ByVal Config As NodeCore.Common.Config)
                Dim tbl As New NodeDatabase.DataSetView.V0仕入先DataTable

                '----------------------------------------------------------------------
                ' ｲﾝｽﾀﾝｽ(基本)
                '----------------------------------------------------------------------
                Me.仕入先CDF = New BaseCore.Common.Field.ItemData(tbl.仕入先CDColumn)
                Me.仕入先CDT = New BaseCore.Common.Field.ItemData(tbl.仕入先CDColumn)
            End Sub
        End Class
#End Region

        Public Class Paramater
            Public Header As Header
            Public Detail As Detail
            Public Note As Note
            Public Print As Print
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

        '----------------------------------------------------------------------
        ' ﾚﾎﾟｰﾄ変数 設定
        '----------------------------------------------------------------------
        Private COLNAME_REPORT_PAGE As String = "頁数"
        Private COLNAME_REPORT_LINE As String = "行数"

        Private lngMaxLine As Long = 11
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
            Me.Fields.Detail = New Detail(Config)
            Me.Fields.Note = New Note(Config)
            Me.Fields.Print = New Print(Config)
        End Sub
#End Region

#Region "変数定義"
        Private maxline As Integer = 11
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
                Me.Fields.Header.仕入先CD.Value = Nothing
                Me.Fields.Header.処理登録.Value = NodeContents.Constant.CodeValue.フラグ.オン
                Me.Fields.Header.処理修正.Value = NodeContents.Constant.CodeValue.フラグ.オフ
                Me.Fields.Header.処理削除.Value = NodeContents.Constant.CodeValue.フラグ.オフ
            End If

            '----------------------------------------------------------------------
            ' ﾃﾞｰﾀ部ｸﾘｱ
            '----------------------------------------------------------------------
            Me.Fields.Header.仕入先名.Value = Nothing
            Me.Fields.Header.略称.Value = Nothing
            Me.Fields.Header.カナ名.Value = Nothing
            Me.Fields.Header.郵便番号.Value = Nothing
            Me.Fields.Header.住所1.Value = Nothing
            Me.Fields.Header.住所2.Value = Nothing
            Me.Fields.Header.役職_担当者名.Value = Nothing
            Me.Fields.Header.TEL.Value = Nothing
            Me.Fields.Header.買掛金_未払金区分.Value = Nothing
            Me.Fields.Header.代表者役職_代表者名1.Value = Nothing
            Me.Fields.Header.FAX.Value = Nothing
            Me.Fields.Header.代表者役職_代表者名2.Value = Nothing

            '詳細情報
            Me.Fields.Detail.行NO.Value = Nothing
            Me.Fields.Detail.部署名_01.Value = Nothing
            Me.Fields.Detail.部署名_02.Value = Nothing
            Me.Fields.Detail.部署名_03.Value = Nothing
            Me.Fields.Detail.部署名_04.Value = Nothing
            Me.Fields.Detail.部署名_05.Value = Nothing
            Me.Fields.Detail.部署名_06.Value = Nothing
            Me.Fields.Detail.部署名_07.Value = Nothing
            Me.Fields.Detail.部署名_08.Value = Nothing
            Me.Fields.Detail.部署名_09.Value = Nothing
            Me.Fields.Detail.部署名_10.Value = Nothing
            Me.Fields.Detail.部署名_11.Value = Nothing
            Me.Fields.Detail.担当者名_01.Value = Nothing
            Me.Fields.Detail.担当者名_02.Value = Nothing
            Me.Fields.Detail.担当者名_03.Value = Nothing
            Me.Fields.Detail.担当者名_04.Value = Nothing
            Me.Fields.Detail.担当者名_05.Value = Nothing
            Me.Fields.Detail.担当者名_06.Value = Nothing
            Me.Fields.Detail.担当者名_07.Value = Nothing
            Me.Fields.Detail.担当者名_08.Value = Nothing
            Me.Fields.Detail.担当者名_09.Value = Nothing
            Me.Fields.Detail.担当者名_10.Value = Nothing
            Me.Fields.Detail.担当者名_11.Value = Nothing
            Me.Fields.Detail.郵便番号_01.Value = Nothing
            Me.Fields.Detail.郵便番号_02.Value = Nothing
            Me.Fields.Detail.郵便番号_03.Value = Nothing
            Me.Fields.Detail.郵便番号_04.Value = Nothing
            Me.Fields.Detail.郵便番号_05.Value = Nothing
            Me.Fields.Detail.郵便番号_06.Value = Nothing
            Me.Fields.Detail.郵便番号_07.Value = Nothing
            Me.Fields.Detail.郵便番号_08.Value = Nothing
            Me.Fields.Detail.郵便番号_09.Value = Nothing
            Me.Fields.Detail.郵便番号_10.Value = Nothing
            Me.Fields.Detail.郵便番号_11.Value = Nothing
            Me.Fields.Detail.住所1_01.Value = Nothing
            Me.Fields.Detail.住所1_02.Value = Nothing
            Me.Fields.Detail.住所1_03.Value = Nothing
            Me.Fields.Detail.住所1_04.Value = Nothing
            Me.Fields.Detail.住所1_05.Value = Nothing
            Me.Fields.Detail.住所1_06.Value = Nothing
            Me.Fields.Detail.住所1_07.Value = Nothing
            Me.Fields.Detail.住所1_08.Value = Nothing
            Me.Fields.Detail.住所1_09.Value = Nothing
            Me.Fields.Detail.住所1_10.Value = Nothing
            Me.Fields.Detail.住所1_11.Value = Nothing
            Me.Fields.Detail.住所2_01.Value = Nothing
            Me.Fields.Detail.住所2_02.Value = Nothing
            Me.Fields.Detail.住所2_03.Value = Nothing
            Me.Fields.Detail.住所2_04.Value = Nothing
            Me.Fields.Detail.住所2_05.Value = Nothing
            Me.Fields.Detail.住所2_06.Value = Nothing
            Me.Fields.Detail.住所2_07.Value = Nothing
            Me.Fields.Detail.住所2_08.Value = Nothing
            Me.Fields.Detail.住所2_09.Value = Nothing
            Me.Fields.Detail.住所2_10.Value = Nothing
            Me.Fields.Detail.住所2_11.Value = Nothing
            Me.Fields.Detail.TEL_01.Value = Nothing
            Me.Fields.Detail.TEL_02.Value = Nothing
            Me.Fields.Detail.TEL_03.Value = Nothing
            Me.Fields.Detail.TEL_04.Value = Nothing
            Me.Fields.Detail.TEL_05.Value = Nothing
            Me.Fields.Detail.TEL_06.Value = Nothing
            Me.Fields.Detail.TEL_07.Value = Nothing
            Me.Fields.Detail.TEL_08.Value = Nothing
            Me.Fields.Detail.TEL_09.Value = Nothing
            Me.Fields.Detail.TEL_10.Value = Nothing
            Me.Fields.Detail.TEL_11.Value = Nothing
            Me.Fields.Detail.FAX_01.Value = Nothing
            Me.Fields.Detail.FAX_02.Value = Nothing
            Me.Fields.Detail.FAX_03.Value = Nothing
            Me.Fields.Detail.FAX_04.Value = Nothing
            Me.Fields.Detail.FAX_05.Value = Nothing
            Me.Fields.Detail.FAX_06.Value = Nothing
            Me.Fields.Detail.FAX_07.Value = Nothing
            Me.Fields.Detail.FAX_08.Value = Nothing
            Me.Fields.Detail.FAX_09.Value = Nothing
            Me.Fields.Detail.FAX_10.Value = Nothing
            Me.Fields.Detail.FAX_11.Value = Nothing
            Me.Fields.Detail.携帯_01.Value = Nothing
            Me.Fields.Detail.携帯_02.Value = Nothing
            Me.Fields.Detail.携帯_03.Value = Nothing
            Me.Fields.Detail.携帯_04.Value = Nothing
            Me.Fields.Detail.携帯_05.Value = Nothing
            Me.Fields.Detail.携帯_06.Value = Nothing
            Me.Fields.Detail.携帯_07.Value = Nothing
            Me.Fields.Detail.携帯_08.Value = Nothing
            Me.Fields.Detail.携帯_09.Value = Nothing
            Me.Fields.Detail.携帯_10.Value = Nothing
            Me.Fields.Detail.携帯_11.Value = Nothing
            Me.Fields.Detail.メール_01.Value = Nothing
            Me.Fields.Detail.メール_02.Value = Nothing
            Me.Fields.Detail.メール_03.Value = Nothing
            Me.Fields.Detail.メール_04.Value = Nothing
            Me.Fields.Detail.メール_05.Value = Nothing
            Me.Fields.Detail.メール_06.Value = Nothing
            Me.Fields.Detail.メール_07.Value = Nothing
            Me.Fields.Detail.メール_08.Value = Nothing
            Me.Fields.Detail.メール_09.Value = Nothing
            Me.Fields.Detail.メール_10.Value = Nothing
            Me.Fields.Detail.メール_11.Value = Nothing
            Me.Fields.Detail.本支店名_01.Value = Nothing
            Me.Fields.Detail.本支店名_02.Value = Nothing
            Me.Fields.Detail.本支店名_03.Value = Nothing
            Me.Fields.Detail.本支店名_04.Value = Nothing
            Me.Fields.Detail.本支店名_05.Value = Nothing
            Me.Fields.Detail.本支店名_06.Value = Nothing
            Me.Fields.Detail.本支店名_07.Value = Nothing
            Me.Fields.Detail.本支店名_08.Value = Nothing
            Me.Fields.Detail.本支店名_09.Value = Nothing
            Me.Fields.Detail.本支店名_10.Value = Nothing
            Me.Fields.Detail.本支店名_11.Value = Nothing
            Me.Fields.Detail.仕入先名.Value = Nothing
            Me.Fields.Detail.役職_担当者名.Value = Nothing
            Me.Fields.Detail.代表者役職_代表者名1.Value = Nothing
            Me.Fields.Detail.代表者役職_代表者名2.Value = Nothing

            '特記事項
            Me.Fields.Note.行NO.Value = Nothing
            Me.Fields.Note.特記事項_01.Value = Nothing
            Me.Fields.Note.特記事項_02.Value = Nothing
            Me.Fields.Note.特記事項_03.Value = Nothing
            Me.Fields.Note.特記事項_04.Value = Nothing
            Me.Fields.Note.特記事項_05.Value = Nothing
            Me.Fields.Note.特記事項_06.Value = Nothing
            Me.Fields.Note.特記事項_07.Value = Nothing
            Me.Fields.Note.特記事項_08.Value = Nothing
            Me.Fields.Note.特記事項_09.Value = Nothing
            Me.Fields.Note.特記事項_10.Value = Nothing
            Me.Fields.Note.特記事項_11.Value = Nothing
            Me.Fields.Note.特記事項_12.Value = Nothing
            Me.Fields.Note.特記事項_13.Value = Nothing

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return True
        End Function
#End Region

#Region "Exist"
        '''========================================================================================
        ''' <SUMMARY>ﾍｯﾀﾞ</SUMMARY>
        ''' <RETURNS>True:あり, False:なし</RETURNS>
        '''========================================================================================
        Protected Overrides Function Exist_Header() As Boolean
            Dim ada As New NodeDatabase.DataSetMasterTableAdapters.M仕入先TableAdapter
            Dim tbl As New NodeDatabase.DataSetMaster.M仕入先DataTable
            Dim qry As New Collection

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.仕入先CDColumn.ColumnName, Me.Fields.Header.仕入先CD.Value, BaseDatabase.Contents.Compare.Equal))

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
            ' 変数定義
            '----------------------------------------------------------------------
            Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0仕入先TableAdapter
            Dim tbl As New NodeDatabase.DataSetView.V0仕入先DataTable
            Dim qry As New Collection

            Dim ada詳細 As New NodeDatabase.DataSetViewTableAdapters.V0仕入先詳細TableAdapter
            Dim tbl詳細 As New NodeDatabase.DataSetView.V0仕入先詳細DataTable
            Dim qry詳細 As New Collection

            Dim ada特記 As New NodeDatabase.DataSetViewTableAdapters.V0仕入先特記TableAdapter
            Dim tbl特記 As New NodeDatabase.DataSetView.V0仕入先特記DataTable
            Dim qry特記 As New Collection

            Dim strSort As String = ""

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.仕入先CDColumn.ColumnName, Me.Fields.Header.仕入先CD.Value, BaseDatabase.Contents.Compare.Equal))

            qry詳細.Clear()
            qry詳細.Add(New BaseDatabase.Condition(tbl詳細.仕入先CDColumn.ColumnName, Me.Fields.Header.仕入先CD.Value, BaseDatabase.Contents.Compare.Equal))

            qry特記.Clear()
            qry特記.Add(New BaseDatabase.Condition(tbl特記.仕入先CDColumn.ColumnName, Me.Fields.Header.仕入先CD.Value, BaseDatabase.Contents.Compare.Equal))

            '----------------------------------------------------------------------
            ' 読込
            '----------------------------------------------------------------------
            tbl = ada.SelectByCommon(qry)
            If tbl.Count = 0 Then
                Return False
            End If

            Me.Fields.Header.仕入先CD.Value = tbl(0).Item(tbl.仕入先CDColumn.ColumnName)
            Me.Fields.Header.仕入先名.Value = tbl(0).Item(tbl.仕入先名Column.ColumnName)
            Me.Fields.Header.略称.Value = tbl(0).Item(tbl.略称Column.ColumnName)
            Me.Fields.Header.カナ名.Value = tbl(0).Item(tbl.カナ名Column.ColumnName)
            Me.Fields.Header.郵便番号.Value = tbl(0).Item(tbl.郵便番号Column.ColumnName)
            Me.Fields.Header.住所1.Value = tbl(0).Item(tbl.住所1Column.ColumnName)
            Me.Fields.Header.住所2.Value = tbl(0).Item(tbl.住所2Column.ColumnName)
            Me.Fields.Header.役職_担当者名.Value = tbl(0).Item(tbl.役職_担当者名Column.ColumnName)
            Me.Fields.Header.TEL.Value = tbl(0).Item(tbl.TELColumn.ColumnName)
            Me.Fields.Header.買掛金_未払金区分.Value = tbl(0).Item(tbl.買掛金_未払金区分Column.ColumnName)
            Me.Fields.Header.代表者役職_代表者名1.Value = tbl(0).Item(tbl.代表者役職_代表者名1Column.ColumnName)
            Me.Fields.Header.FAX.Value = tbl(0).Item(tbl.FAXColumn.ColumnName)
            Me.Fields.Header.代表者役職_代表者名2.Value = tbl(0).Item(tbl.代表者役職_代表者名2Column.ColumnName)

            '詳細情報
            strSort = tbl詳細.行NOColumn.ColumnName
            tbl詳細 = ada詳細.SelectByCommon(qry詳細, strSort)
            If tbl詳細.Rows.Count > 0 Then
                Me.Fields.Detail.行NO.Value = tbl詳細(0).Item(tbl詳細.行NOColumn.ColumnName)
                Me.Fields.Detail.仕入先名.Value = tbl詳細(0).Item(tbl詳細.仕入先名Column.ColumnName)
                Me.Fields.Detail.役職_担当者名.Value = tbl詳細(0).Item(tbl詳細.役職_担当者名Column.ColumnName)
                Me.Fields.Detail.代表者役職_代表者名1.Value = tbl詳細(0).Item(tbl詳細.代表者役職_代表者名1Column.ColumnName)
                Me.Fields.Detail.代表者役職_代表者名2.Value = tbl詳細(0).Item(tbl詳細.代表者役職_代表者名2Column.ColumnName)

                For Each row詳細 As NodeDatabase.DataSetView.V0仕入先詳細Row In tbl詳細.Rows
                    Select Case row詳細.Item(tbl詳細.行NOColumn.ColumnName)
                        Case 1
                            Me.Fields.Detail.部署名_01.Value = row詳細.Item(tbl詳細.部署名Column.ColumnName)
                            Me.Fields.Detail.担当者名_01.Value = row詳細.Item(tbl詳細.担当者名Column.ColumnName)
                            Me.Fields.Detail.郵便番号_01.Value = row詳細.Item(tbl詳細.郵便番号Column.ColumnName)
                            Me.Fields.Detail.住所1_01.Value = row詳細.Item(tbl詳細.住所1Column.ColumnName)
                            Me.Fields.Detail.住所2_01.Value = row詳細.Item(tbl詳細.住所2Column.ColumnName)
                            Me.Fields.Detail.TEL_01.Value = row詳細.Item(tbl詳細.TELColumn.ColumnName)
                            Me.Fields.Detail.FAX_01.Value = row詳細.Item(tbl詳細.FAXColumn.ColumnName)
                            Me.Fields.Detail.携帯_01.Value = row詳細.Item(tbl詳細.携帯Column.ColumnName)
                            Me.Fields.Detail.メール_01.Value = row詳細.Item(tbl詳細.メールColumn.ColumnName)
                            Me.Fields.Detail.本支店名_01.Value = row詳細.Item(tbl詳細.本支店名Column.ColumnName)
                        Case 2
                            Me.Fields.Detail.部署名_02.Value = row詳細.Item(tbl詳細.部署名Column.ColumnName)
                            Me.Fields.Detail.担当者名_02.Value = row詳細.Item(tbl詳細.担当者名Column.ColumnName)
                            Me.Fields.Detail.郵便番号_02.Value = row詳細.Item(tbl詳細.郵便番号Column.ColumnName)
                            Me.Fields.Detail.住所1_02.Value = row詳細.Item(tbl詳細.住所1Column.ColumnName)
                            Me.Fields.Detail.住所2_02.Value = row詳細.Item(tbl詳細.住所2Column.ColumnName)
                            Me.Fields.Detail.TEL_02.Value = row詳細.Item(tbl詳細.TELColumn.ColumnName)
                            Me.Fields.Detail.FAX_02.Value = row詳細.Item(tbl詳細.FAXColumn.ColumnName)
                            Me.Fields.Detail.携帯_02.Value = row詳細.Item(tbl詳細.携帯Column.ColumnName)
                            Me.Fields.Detail.メール_02.Value = row詳細.Item(tbl詳細.メールColumn.ColumnName)
                            Me.Fields.Detail.本支店名_02.Value = row詳細.Item(tbl詳細.本支店名Column.ColumnName)
                        Case 3
                            Me.Fields.Detail.部署名_03.Value = row詳細.Item(tbl詳細.部署名Column.ColumnName)
                            Me.Fields.Detail.担当者名_03.Value = row詳細.Item(tbl詳細.担当者名Column.ColumnName)
                            Me.Fields.Detail.郵便番号_03.Value = row詳細.Item(tbl詳細.郵便番号Column.ColumnName)
                            Me.Fields.Detail.住所1_03.Value = row詳細.Item(tbl詳細.住所1Column.ColumnName)
                            Me.Fields.Detail.住所2_03.Value = row詳細.Item(tbl詳細.住所2Column.ColumnName)
                            Me.Fields.Detail.TEL_03.Value = row詳細.Item(tbl詳細.TELColumn.ColumnName)
                            Me.Fields.Detail.FAX_03.Value = row詳細.Item(tbl詳細.FAXColumn.ColumnName)
                            Me.Fields.Detail.携帯_03.Value = row詳細.Item(tbl詳細.携帯Column.ColumnName)
                            Me.Fields.Detail.メール_03.Value = row詳細.Item(tbl詳細.メールColumn.ColumnName)
                            Me.Fields.Detail.本支店名_03.Value = row詳細.Item(tbl詳細.本支店名Column.ColumnName)
                        Case 4
                            Me.Fields.Detail.部署名_04.Value = row詳細.Item(tbl詳細.部署名Column.ColumnName)
                            Me.Fields.Detail.担当者名_04.Value = row詳細.Item(tbl詳細.担当者名Column.ColumnName)
                            Me.Fields.Detail.郵便番号_04.Value = row詳細.Item(tbl詳細.郵便番号Column.ColumnName)
                            Me.Fields.Detail.住所1_04.Value = row詳細.Item(tbl詳細.住所1Column.ColumnName)
                            Me.Fields.Detail.住所2_04.Value = row詳細.Item(tbl詳細.住所2Column.ColumnName)
                            Me.Fields.Detail.TEL_04.Value = row詳細.Item(tbl詳細.TELColumn.ColumnName)
                            Me.Fields.Detail.FAX_04.Value = row詳細.Item(tbl詳細.FAXColumn.ColumnName)
                            Me.Fields.Detail.携帯_04.Value = row詳細.Item(tbl詳細.携帯Column.ColumnName)
                            Me.Fields.Detail.メール_04.Value = row詳細.Item(tbl詳細.メールColumn.ColumnName)
                            Me.Fields.Detail.本支店名_04.Value = row詳細.Item(tbl詳細.本支店名Column.ColumnName)
                        Case 5
                            Me.Fields.Detail.部署名_05.Value = row詳細.Item(tbl詳細.部署名Column.ColumnName)
                            Me.Fields.Detail.担当者名_05.Value = row詳細.Item(tbl詳細.担当者名Column.ColumnName)
                            Me.Fields.Detail.郵便番号_05.Value = row詳細.Item(tbl詳細.郵便番号Column.ColumnName)
                            Me.Fields.Detail.住所1_05.Value = row詳細.Item(tbl詳細.住所1Column.ColumnName)
                            Me.Fields.Detail.住所2_05.Value = row詳細.Item(tbl詳細.住所2Column.ColumnName)
                            Me.Fields.Detail.TEL_05.Value = row詳細.Item(tbl詳細.TELColumn.ColumnName)
                            Me.Fields.Detail.FAX_05.Value = row詳細.Item(tbl詳細.FAXColumn.ColumnName)
                            Me.Fields.Detail.携帯_05.Value = row詳細.Item(tbl詳細.携帯Column.ColumnName)
                            Me.Fields.Detail.メール_05.Value = row詳細.Item(tbl詳細.メールColumn.ColumnName)
                            Me.Fields.Detail.本支店名_05.Value = row詳細.Item(tbl詳細.本支店名Column.ColumnName)
                        Case 6
                            Me.Fields.Detail.部署名_06.Value = row詳細.Item(tbl詳細.部署名Column.ColumnName)
                            Me.Fields.Detail.担当者名_06.Value = row詳細.Item(tbl詳細.担当者名Column.ColumnName)
                            Me.Fields.Detail.郵便番号_06.Value = row詳細.Item(tbl詳細.郵便番号Column.ColumnName)
                            Me.Fields.Detail.住所1_06.Value = row詳細.Item(tbl詳細.住所1Column.ColumnName)
                            Me.Fields.Detail.住所2_06.Value = row詳細.Item(tbl詳細.住所2Column.ColumnName)
                            Me.Fields.Detail.TEL_06.Value = row詳細.Item(tbl詳細.TELColumn.ColumnName)
                            Me.Fields.Detail.FAX_06.Value = row詳細.Item(tbl詳細.FAXColumn.ColumnName)
                            Me.Fields.Detail.携帯_06.Value = row詳細.Item(tbl詳細.携帯Column.ColumnName)
                            Me.Fields.Detail.メール_06.Value = row詳細.Item(tbl詳細.メールColumn.ColumnName)
                            Me.Fields.Detail.本支店名_06.Value = row詳細.Item(tbl詳細.本支店名Column.ColumnName)
                        Case 7
                            Me.Fields.Detail.部署名_07.Value = row詳細.Item(tbl詳細.部署名Column.ColumnName)
                            Me.Fields.Detail.担当者名_07.Value = row詳細.Item(tbl詳細.担当者名Column.ColumnName)
                            Me.Fields.Detail.郵便番号_07.Value = row詳細.Item(tbl詳細.郵便番号Column.ColumnName)
                            Me.Fields.Detail.住所1_07.Value = row詳細.Item(tbl詳細.住所1Column.ColumnName)
                            Me.Fields.Detail.住所2_07.Value = row詳細.Item(tbl詳細.住所2Column.ColumnName)
                            Me.Fields.Detail.TEL_07.Value = row詳細.Item(tbl詳細.TELColumn.ColumnName)
                            Me.Fields.Detail.FAX_07.Value = row詳細.Item(tbl詳細.FAXColumn.ColumnName)
                            Me.Fields.Detail.携帯_07.Value = row詳細.Item(tbl詳細.携帯Column.ColumnName)
                            Me.Fields.Detail.メール_07.Value = row詳細.Item(tbl詳細.メールColumn.ColumnName)
                            Me.Fields.Detail.本支店名_07.Value = row詳細.Item(tbl詳細.本支店名Column.ColumnName)
                        Case 8
                            Me.Fields.Detail.部署名_08.Value = row詳細.Item(tbl詳細.部署名Column.ColumnName)
                            Me.Fields.Detail.担当者名_08.Value = row詳細.Item(tbl詳細.担当者名Column.ColumnName)
                            Me.Fields.Detail.郵便番号_08.Value = row詳細.Item(tbl詳細.郵便番号Column.ColumnName)
                            Me.Fields.Detail.住所1_08.Value = row詳細.Item(tbl詳細.住所1Column.ColumnName)
                            Me.Fields.Detail.住所2_08.Value = row詳細.Item(tbl詳細.住所2Column.ColumnName)
                            Me.Fields.Detail.TEL_08.Value = row詳細.Item(tbl詳細.TELColumn.ColumnName)
                            Me.Fields.Detail.FAX_08.Value = row詳細.Item(tbl詳細.FAXColumn.ColumnName)
                            Me.Fields.Detail.携帯_08.Value = row詳細.Item(tbl詳細.携帯Column.ColumnName)
                            Me.Fields.Detail.メール_08.Value = row詳細.Item(tbl詳細.メールColumn.ColumnName)
                            Me.Fields.Detail.本支店名_08.Value = row詳細.Item(tbl詳細.本支店名Column.ColumnName)
                        Case 9
                            Me.Fields.Detail.部署名_09.Value = row詳細.Item(tbl詳細.部署名Column.ColumnName)
                            Me.Fields.Detail.担当者名_09.Value = row詳細.Item(tbl詳細.担当者名Column.ColumnName)
                            Me.Fields.Detail.郵便番号_09.Value = row詳細.Item(tbl詳細.郵便番号Column.ColumnName)
                            Me.Fields.Detail.住所1_09.Value = row詳細.Item(tbl詳細.住所1Column.ColumnName)
                            Me.Fields.Detail.住所2_09.Value = row詳細.Item(tbl詳細.住所2Column.ColumnName)
                            Me.Fields.Detail.TEL_09.Value = row詳細.Item(tbl詳細.TELColumn.ColumnName)
                            Me.Fields.Detail.FAX_09.Value = row詳細.Item(tbl詳細.FAXColumn.ColumnName)
                            Me.Fields.Detail.携帯_09.Value = row詳細.Item(tbl詳細.携帯Column.ColumnName)
                            Me.Fields.Detail.メール_09.Value = row詳細.Item(tbl詳細.メールColumn.ColumnName)
                            Me.Fields.Detail.本支店名_09.Value = row詳細.Item(tbl詳細.本支店名Column.ColumnName)
                        Case 10
                            Me.Fields.Detail.部署名_10.Value = row詳細.Item(tbl詳細.部署名Column.ColumnName)
                            Me.Fields.Detail.担当者名_10.Value = row詳細.Item(tbl詳細.担当者名Column.ColumnName)
                            Me.Fields.Detail.郵便番号_10.Value = row詳細.Item(tbl詳細.郵便番号Column.ColumnName)
                            Me.Fields.Detail.住所1_10.Value = row詳細.Item(tbl詳細.住所1Column.ColumnName)
                            Me.Fields.Detail.住所2_10.Value = row詳細.Item(tbl詳細.住所2Column.ColumnName)
                            Me.Fields.Detail.TEL_10.Value = row詳細.Item(tbl詳細.TELColumn.ColumnName)
                            Me.Fields.Detail.FAX_10.Value = row詳細.Item(tbl詳細.FAXColumn.ColumnName)
                            Me.Fields.Detail.携帯_10.Value = row詳細.Item(tbl詳細.携帯Column.ColumnName)
                            Me.Fields.Detail.メール_10.Value = row詳細.Item(tbl詳細.メールColumn.ColumnName)
                            Me.Fields.Detail.本支店名_10.Value = row詳細.Item(tbl詳細.本支店名Column.ColumnName)
                        Case 11
                            Me.Fields.Detail.部署名_11.Value = row詳細.Item(tbl詳細.部署名Column.ColumnName)
                            Me.Fields.Detail.担当者名_11.Value = row詳細.Item(tbl詳細.担当者名Column.ColumnName)
                            Me.Fields.Detail.郵便番号_11.Value = row詳細.Item(tbl詳細.郵便番号Column.ColumnName)
                            Me.Fields.Detail.住所1_11.Value = row詳細.Item(tbl詳細.住所1Column.ColumnName)
                            Me.Fields.Detail.住所2_11.Value = row詳細.Item(tbl詳細.住所2Column.ColumnName)
                            Me.Fields.Detail.TEL_11.Value = row詳細.Item(tbl詳細.TELColumn.ColumnName)
                            Me.Fields.Detail.FAX_11.Value = row詳細.Item(tbl詳細.FAXColumn.ColumnName)
                            Me.Fields.Detail.携帯_11.Value = row詳細.Item(tbl詳細.携帯Column.ColumnName)
                            Me.Fields.Detail.メール_11.Value = row詳細.Item(tbl詳細.メールColumn.ColumnName)
                            Me.Fields.Detail.本支店名_11.Value = row詳細.Item(tbl詳細.本支店名Column.ColumnName)
                    End Select
                Next
            End If

            '特記事項
            strSort = tbl詳細.行NOColumn.ColumnName
            tbl特記 = ada特記.SelectByCommon(qry特記, strSort)
            If tbl特記.Rows.Count > 0 Then
                Me.Fields.Note.行NO.Value = tbl特記(0).Item(tbl詳細.行NOColumn.ColumnName)

                For Each row特記 As NodeDatabase.DataSetView.V0仕入先特記Row In tbl特記.Rows
                    Select Case row特記.Item(tbl特記.行NOColumn.ColumnName)
                        Case 1
                            Me.Fields.Note.特記事項_01.Value = row特記.Item(tbl特記.特記事項Column.ColumnName)
                        Case 2
                            Me.Fields.Note.特記事項_02.Value = row特記.Item(tbl特記.特記事項Column.ColumnName)
                        Case 3
                            Me.Fields.Note.特記事項_03.Value = row特記.Item(tbl特記.特記事項Column.ColumnName)
                        Case 4
                            Me.Fields.Note.特記事項_04.Value = row特記.Item(tbl特記.特記事項Column.ColumnName)
                        Case 5
                            Me.Fields.Note.特記事項_05.Value = row特記.Item(tbl特記.特記事項Column.ColumnName)
                        Case 6
                            Me.Fields.Note.特記事項_06.Value = row特記.Item(tbl特記.特記事項Column.ColumnName)
                        Case 7
                            Me.Fields.Note.特記事項_07.Value = row特記.Item(tbl特記.特記事項Column.ColumnName)
                        Case 8
                            Me.Fields.Note.特記事項_08.Value = row特記.Item(tbl特記.特記事項Column.ColumnName)
                        Case 9
                            Me.Fields.Note.特記事項_09.Value = row特記.Item(tbl特記.特記事項Column.ColumnName)
                        Case 10
                            Me.Fields.Note.特記事項_10.Value = row特記.Item(tbl特記.特記事項Column.ColumnName)
                        Case 11
                            Me.Fields.Note.特記事項_11.Value = row特記.Item(tbl特記.特記事項Column.ColumnName)
                        Case 12
                            Me.Fields.Note.特記事項_12.Value = row特記.Item(tbl特記.特記事項Column.ColumnName)
                        Case 13
                            Me.Fields.Note.特記事項_13.Value = row特記.Item(tbl特記.特記事項Column.ColumnName)
                    End Select
                Next
            End If

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
            Dim strNow As String = Format(Now, "yyyy/MM/dd HH:mm:ss")

            Dim ada As New NodeDatabase.DataSetMasterTableAdapters.M仕入先TableAdapter
            Dim tbl As New NodeDatabase.DataSetMaster.M仕入先DataTable
            Dim qry As New Collection

            Dim ada詳細 As New NodeDatabase.DataSetMasterTableAdapters.M仕入先詳細TableAdapter
            Dim tbl詳細 As New NodeDatabase.DataSetMaster.M仕入先詳細DataTable
            Dim qry詳細 As New Collection

            Dim ada特記 As New NodeDatabase.DataSetMasterTableAdapters.M仕入先特記TableAdapter
            Dim tbl特記 As New NodeDatabase.DataSetMaster.M仕入先特記DataTable
            Dim qry特記 As New Collection

            Dim strSort As String = ""

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.仕入先CDColumn.ColumnName, Me.Fields.Header.仕入先CD.Value, BaseDatabase.Contents.Compare.Equal))

            qry詳細.Clear()
            qry詳細.Add(New BaseDatabase.Condition(tbl詳細.仕入先CDColumn.ColumnName, Me.Fields.Header.仕入先CD.Value, BaseDatabase.Contents.Compare.Equal))

            qry特記.Clear()
            qry特記.Add(New BaseDatabase.Condition(tbl特記.仕入先CDColumn.ColumnName, Me.Fields.Header.仕入先CD.Value, BaseDatabase.Contents.Compare.Equal))

            '----------------------------------------------------------------------
            ' 読込
            '----------------------------------------------------------------------
            tbl = ada.SelectByCommon(qry)

            '----------------------------------------------------------------------
            ' 保存
            '----------------------------------------------------------------------
            Using scope As New System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required, TimeSpan.Zero)
                '----------------------------------------------------------------------
                ' 事前削除
                '----------------------------------------------------------------------
                ada詳細.DeleteByCommon(qry詳細)
                ada特記.DeleteByCommon(qry特記)

                If tbl.Count = 0 Then
                    '-------------------------------------
                    ' 新規
                    '-------------------------------------
                    ada.Insert( _
                               Me.Fields.Header.仕入先CD.Value _
                             , Me.Fields.Header.仕入先名.Value _
                             , Me.Fields.Header.略称.Value _
                             , Me.Fields.Header.カナ名.Value _
                             , Me.Fields.Header.郵便番号.Value _
                             , Me.Fields.Header.住所1.Value _
                             , Me.Fields.Header.住所2.Value _
                             , Me.Fields.Header.役職_担当者名.Value _
                             , Me.Fields.Header.TEL.Value _
                             , Me.Fields.Header.買掛金_未払金区分.Value _
                             , Me.Fields.Header.代表者役職_代表者名1.Value _
                             , Me.Fields.Header.FAX.Value _
                             , Me.Fields.Header.代表者役職_代表者名2.Value _
                              )
                Else
                    '-------------------------------------
                    ' 訂正
                    '-------------------------------------
                    tbl(0).Item(tbl.仕入先CDColumn.ColumnName) = Me.Fields.Header.仕入先CD.Value
                    tbl(0).Item(tbl.仕入先名Column.ColumnName) = Me.Fields.Header.仕入先名.Value
                    tbl(0).Item(tbl.略称Column.ColumnName) = Me.Fields.Header.略称.Value
                    tbl(0).Item(tbl.カナ名Column.ColumnName) = Me.Fields.Header.カナ名.Value
                    tbl(0).Item(tbl.郵便番号Column.ColumnName) = Me.Fields.Header.郵便番号.Value
                    tbl(0).Item(tbl.住所1Column.ColumnName) = Me.Fields.Header.住所1.Value
                    tbl(0).Item(tbl.住所2Column.ColumnName) = Me.Fields.Header.住所2.Value
                    tbl(0).Item(tbl.役職_担当者名Column.ColumnName) = Me.Fields.Header.役職_担当者名.Value
                    tbl(0).Item(tbl.TELColumn.ColumnName) = Me.Fields.Header.TEL.Value
                    tbl(0).Item(tbl.買掛金_未払金区分Column.ColumnName) = Me.Fields.Header.買掛金_未払金区分.Value
                    tbl(0).Item(tbl.代表者役職_代表者名1Column.ColumnName) = Me.Fields.Header.代表者役職_代表者名1.Value
                    tbl(0).Item(tbl.FAXColumn.ColumnName) = Me.Fields.Header.FAX.Value
                    tbl(0).Item(tbl.代表者役職_代表者名2Column.ColumnName) = Me.Fields.Header.代表者役職_代表者名2.Value
                    ada.Update(tbl)
                End If

                '----------------------------------------------------------------------
                ' 詳細情報
                '----------------------------------------------------------------------
                For i As Integer = 1 To 11
                    Select Case i
                        Case 1
                            Me.Wirte_Detail(i, Me.Fields.Detail.部署名_01.Value, Me.Fields.Detail.担当者名_01.Value, Me.Fields.Detail.郵便番号_01.Value, Me.Fields.Detail.住所1_01.Value, Me.Fields.Detail.住所2_01.Value _
                                             , Me.Fields.Detail.TEL_01.Value, Me.Fields.Detail.FAX_01.Value, Me.Fields.Detail.携帯_01.Value, Me.Fields.Detail.メール_01.Value, Me.Fields.Detail.本支店名_01.Value)
                        Case 2
                            Me.Wirte_Detail(i, Me.Fields.Detail.部署名_02.Value, Me.Fields.Detail.担当者名_02.Value, Me.Fields.Detail.郵便番号_02.Value, Me.Fields.Detail.住所1_02.Value, Me.Fields.Detail.住所2_02.Value _
                                             , Me.Fields.Detail.TEL_02.Value, Me.Fields.Detail.FAX_02.Value, Me.Fields.Detail.携帯_02.Value, Me.Fields.Detail.メール_02.Value, Me.Fields.Detail.本支店名_02.Value)
                        Case 3
                            Me.Wirte_Detail(i, Me.Fields.Detail.部署名_03.Value, Me.Fields.Detail.担当者名_03.Value, Me.Fields.Detail.郵便番号_03.Value, Me.Fields.Detail.住所1_03.Value, Me.Fields.Detail.住所2_03.Value _
                                             , Me.Fields.Detail.TEL_03.Value, Me.Fields.Detail.FAX_03.Value, Me.Fields.Detail.携帯_03.Value, Me.Fields.Detail.メール_03.Value, Me.Fields.Detail.本支店名_03.Value)
                        Case 4
                            Me.Wirte_Detail(i, Me.Fields.Detail.部署名_04.Value, Me.Fields.Detail.担当者名_04.Value, Me.Fields.Detail.郵便番号_04.Value, Me.Fields.Detail.住所1_04.Value, Me.Fields.Detail.住所2_04.Value _
                                             , Me.Fields.Detail.TEL_04.Value, Me.Fields.Detail.FAX_04.Value, Me.Fields.Detail.携帯_04.Value, Me.Fields.Detail.メール_04.Value, Me.Fields.Detail.本支店名_04.Value)
                        Case 5
                            Me.Wirte_Detail(i, Me.Fields.Detail.部署名_05.Value, Me.Fields.Detail.担当者名_05.Value, Me.Fields.Detail.郵便番号_05.Value, Me.Fields.Detail.住所1_05.Value, Me.Fields.Detail.住所2_05.Value _
                                             , Me.Fields.Detail.TEL_05.Value, Me.Fields.Detail.FAX_05.Value, Me.Fields.Detail.携帯_05.Value, Me.Fields.Detail.メール_05.Value, Me.Fields.Detail.本支店名_05.Value)
                        Case 6
                            Me.Wirte_Detail(i, Me.Fields.Detail.部署名_06.Value, Me.Fields.Detail.担当者名_06.Value, Me.Fields.Detail.郵便番号_06.Value, Me.Fields.Detail.住所1_06.Value, Me.Fields.Detail.住所2_06.Value _
                                             , Me.Fields.Detail.TEL_06.Value, Me.Fields.Detail.FAX_06.Value, Me.Fields.Detail.携帯_06.Value, Me.Fields.Detail.メール_06.Value, Me.Fields.Detail.本支店名_06.Value)
                        Case 7
                            Me.Wirte_Detail(i, Me.Fields.Detail.部署名_07.Value, Me.Fields.Detail.担当者名_07.Value, Me.Fields.Detail.郵便番号_07.Value, Me.Fields.Detail.住所1_07.Value, Me.Fields.Detail.住所2_07.Value _
                                             , Me.Fields.Detail.TEL_07.Value, Me.Fields.Detail.FAX_07.Value, Me.Fields.Detail.携帯_07.Value, Me.Fields.Detail.メール_07.Value, Me.Fields.Detail.本支店名_07.Value)
                        Case 8
                            Me.Wirte_Detail(i, Me.Fields.Detail.部署名_08.Value, Me.Fields.Detail.担当者名_08.Value, Me.Fields.Detail.郵便番号_08.Value, Me.Fields.Detail.住所1_08.Value, Me.Fields.Detail.住所2_08.Value _
                                             , Me.Fields.Detail.TEL_08.Value, Me.Fields.Detail.FAX_08.Value, Me.Fields.Detail.携帯_08.Value, Me.Fields.Detail.メール_08.Value, Me.Fields.Detail.本支店名_08.Value)
                        Case 9
                            Me.Wirte_Detail(i, Me.Fields.Detail.部署名_09.Value, Me.Fields.Detail.担当者名_09.Value, Me.Fields.Detail.郵便番号_09.Value, Me.Fields.Detail.住所1_09.Value, Me.Fields.Detail.住所2_09.Value _
                                             , Me.Fields.Detail.TEL_09.Value, Me.Fields.Detail.FAX_09.Value, Me.Fields.Detail.携帯_09.Value, Me.Fields.Detail.メール_09.Value, Me.Fields.Detail.本支店名_09.Value)
                        Case 10
                            Me.Wirte_Detail(i, Me.Fields.Detail.部署名_10.Value, Me.Fields.Detail.担当者名_10.Value, Me.Fields.Detail.郵便番号_10.Value, Me.Fields.Detail.住所1_10.Value, Me.Fields.Detail.住所2_10.Value _
                                             , Me.Fields.Detail.TEL_10.Value, Me.Fields.Detail.FAX_10.Value, Me.Fields.Detail.携帯_10.Value, Me.Fields.Detail.メール_10.Value, Me.Fields.Detail.本支店名_10.Value)
                        Case 11
                            Me.Wirte_Detail(i, Me.Fields.Detail.部署名_11.Value, Me.Fields.Detail.担当者名_11.Value, Me.Fields.Detail.郵便番号_11.Value, Me.Fields.Detail.住所1_11.Value, Me.Fields.Detail.住所2_11.Value _
                                             , Me.Fields.Detail.TEL_11.Value, Me.Fields.Detail.FAX_11.Value, Me.Fields.Detail.携帯_11.Value, Me.Fields.Detail.メール_11.Value, Me.Fields.Detail.本支店名_11.Value)
                    End Select
                Next

                '----------------------------------------------------------------------
                ' 特記事項
                '----------------------------------------------------------------------
                For i As Integer = 1 To 13
                    Select Case i
                        Case 1
                            Me.Wirte_Note(i, Me.Fields.Note.特記事項_01.Value)
                        Case 2
                            Me.Wirte_Note(i, Me.Fields.Note.特記事項_02.Value)
                        Case 3
                            Me.Wirte_Note(i, Me.Fields.Note.特記事項_03.Value)
                        Case 4
                            Me.Wirte_Note(i, Me.Fields.Note.特記事項_04.Value)
                        Case 5
                            Me.Wirte_Note(i, Me.Fields.Note.特記事項_05.Value)
                        Case 6
                            Me.Wirte_Note(i, Me.Fields.Note.特記事項_06.Value)
                        Case 7
                            Me.Wirte_Note(i, Me.Fields.Note.特記事項_07.Value)
                        Case 8
                            Me.Wirte_Note(i, Me.Fields.Note.特記事項_08.Value)
                        Case 9
                            Me.Wirte_Note(i, Me.Fields.Note.特記事項_09.Value)
                        Case 10
                            Me.Wirte_Note(i, Me.Fields.Note.特記事項_10.Value)
                        Case 11
                            Me.Wirte_Note(i, Me.Fields.Note.特記事項_11.Value)
                        Case 12
                            Me.Wirte_Note(i, Me.Fields.Note.特記事項_12.Value)
                        Case 13
                            Me.Wirte_Note(i, Me.Fields.Note.特記事項_13.Value)
                    End Select
                Next

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

        '''========================================================================================
        ''' <SUMMARY>詳細情報書込</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Private Sub Wirte_Detail(ByVal 行NO As Integer _
                               , ByVal 部署名 As String _
                               , ByVal 担当者名 As String _
                               , ByVal 郵便番号 As String _
                               , ByVal 住所1 As String _
                               , ByVal 住所2 As String _
                               , ByVal TEL As String _
                               , ByVal FAX As String _
                               , ByVal 携帯 As String _
                               , ByVal メール As String _
                               , ByVal 本支店名 As String _
                                 )
            Dim ada詳細 As New NodeDatabase.DataSetMasterTableAdapters.M仕入先詳細TableAdapter

            '全て未入力ならｽｷｯﾌﾟ
            If 部署名 = "" _
           And 担当者名 = "" _
           And 郵便番号 = "" _
           And 住所1 = "" _
           And 住所2 = "" _
           And TEL = "" _
           And FAX = "" _
           And 携帯 = "" _
           And メール = "" _
           And 本支店名 = "" Then
                Exit Sub
            End If

            ada詳細.Insert( _
                            Me.Fields.Header.仕入先CD.Value _
                          , 行NO _
                          , 部署名 _
                          , 担当者名 _
                          , 郵便番号 _
                          , 住所1 _
                          , 住所2 _
                          , TEL _
                          , FAX _
                          , 携帯 _
                          , メール _
                          , 本支店名 _
                          )
        End Sub

        '''========================================================================================
        ''' <SUMMARY>特記事項書込</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Private Sub Wirte_Note(ByVal 行NO As Integer _
                             , ByVal 特記事項 As String _
                               )
            Dim ada特記 As New NodeDatabase.DataSetMasterTableAdapters.M仕入先特記TableAdapter

            '全て未入力ならｽｷｯﾌﾟ
            If 特記事項 = "" Then
                Exit Sub
            End If

            ada特記.Insert( _
                            Me.Fields.Header.仕入先CD.Value _
                          , 行NO _
                          , 特記事項 _
                          )
        End Sub
#End Region

#Region "Delete"
        '''========================================================================================
        ''' <SUMMARY>削除</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overrides Function Delete_Header() As Boolean
            '----------------------------------------------------------------------
            ' ﾍｯﾀﾞ
            '----------------------------------------------------------------------
            '------------------------------------
            ' 変数定義
            '------------------------------------
            Dim ada As New NodeDatabase.DataSetMasterTableAdapters.M仕入先TableAdapter
            Dim tbl As New NodeDatabase.DataSetMaster.M仕入先DataTable
            Dim qry As New Collection

            Dim ada詳細 As New NodeDatabase.DataSetMasterTableAdapters.M仕入先詳細TableAdapter
            Dim tbl詳細 As New NodeDatabase.DataSetMaster.M仕入先詳細DataTable
            Dim qry詳細 As New Collection

            Dim ada特記 As New NodeDatabase.DataSetMasterTableAdapters.M仕入先詳細TableAdapter
            Dim tbl特記 As New NodeDatabase.DataSetMaster.M仕入先詳細DataTable
            Dim qry特記 As New Collection

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.仕入先CDColumn.ColumnName, Me.Fields.Header.仕入先CD.Value, BaseDatabase.Contents.Compare.Equal))

            qry詳細.Clear()
            qry詳細.Add(New BaseDatabase.Condition(tbl詳細.仕入先CDColumn.ColumnName, Me.Fields.Header.仕入先CD.Value, BaseDatabase.Contents.Compare.Equal))

            qry特記.Clear()
            qry特記.Add(New BaseDatabase.Condition(tbl特記.仕入先CDColumn.ColumnName, Me.Fields.Header.仕入先CD.Value, BaseDatabase.Contents.Compare.Equal))

            '------------------------------------
            ' 削除
            '------------------------------------
            Try
                Using scope As New System.Transactions.TransactionScope(System.Transactions.TransactionScopeOption.Required, TimeSpan.Zero)
                    ada.DeleteByCommon(qry)
                    ada詳細.DeleteByCommon(qry詳細)
                    ada特記.DeleteByCommon(qry特記)

                    '-------------------------------------
                    ' COMMIT
                    '-------------------------------------
                    scope.Complete()
                End Using

            Catch ex As Exception
                MyBase.LastError = "以下のエラーのため、削除できませんでした。" & vbCrLf & ex.Message
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
            Me.Fields.Header.仕入先CD.IsError = False
            Me.Fields.Header.仕入先名.IsError = False
            Me.Fields.Header.略称.IsError = False
            Me.Fields.Header.カナ名.IsError = False
            Me.Fields.Header.郵便番号.IsError = False
            Me.Fields.Header.住所1.IsError = False
            Me.Fields.Header.住所2.IsError = False
            Me.Fields.Header.役職_担当者名.IsError = False
            Me.Fields.Header.TEL.IsError = False
            Me.Fields.Header.買掛金_未払金区分.IsError = False
            Me.Fields.Header.代表者役職_代表者名1.IsError = False
            Me.Fields.Header.FAX.IsError = False
            Me.Fields.Header.代表者役職_代表者名2.IsError = False

            Me.Fields.Detail.行NO.IsError = False
            Me.Fields.Detail.部署名_01.IsError = False
            Me.Fields.Detail.部署名_02.IsError = False
            Me.Fields.Detail.部署名_03.IsError = False
            Me.Fields.Detail.部署名_04.IsError = False
            Me.Fields.Detail.部署名_05.IsError = False
            Me.Fields.Detail.部署名_06.IsError = False
            Me.Fields.Detail.部署名_07.IsError = False
            Me.Fields.Detail.部署名_08.IsError = False
            Me.Fields.Detail.部署名_09.IsError = False
            Me.Fields.Detail.部署名_10.IsError = False
            Me.Fields.Detail.部署名_11.IsError = False
            Me.Fields.Detail.担当者名_01.IsError = False
            Me.Fields.Detail.担当者名_02.IsError = False
            Me.Fields.Detail.担当者名_03.IsError = False
            Me.Fields.Detail.担当者名_04.IsError = False
            Me.Fields.Detail.担当者名_05.IsError = False
            Me.Fields.Detail.担当者名_06.IsError = False
            Me.Fields.Detail.担当者名_07.IsError = False
            Me.Fields.Detail.担当者名_08.IsError = False
            Me.Fields.Detail.担当者名_09.IsError = False
            Me.Fields.Detail.担当者名_10.IsError = False
            Me.Fields.Detail.担当者名_11.IsError = False
            Me.Fields.Detail.郵便番号_01.IsError = False
            Me.Fields.Detail.郵便番号_02.IsError = False
            Me.Fields.Detail.郵便番号_03.IsError = False
            Me.Fields.Detail.郵便番号_04.IsError = False
            Me.Fields.Detail.郵便番号_05.IsError = False
            Me.Fields.Detail.郵便番号_06.IsError = False
            Me.Fields.Detail.郵便番号_07.IsError = False
            Me.Fields.Detail.郵便番号_08.IsError = False
            Me.Fields.Detail.郵便番号_09.IsError = False
            Me.Fields.Detail.郵便番号_10.IsError = False
            Me.Fields.Detail.郵便番号_11.IsError = False
            Me.Fields.Detail.住所1_01.IsError = False
            Me.Fields.Detail.住所1_02.IsError = False
            Me.Fields.Detail.住所1_03.IsError = False
            Me.Fields.Detail.住所1_04.IsError = False
            Me.Fields.Detail.住所1_05.IsError = False
            Me.Fields.Detail.住所1_06.IsError = False
            Me.Fields.Detail.住所1_07.IsError = False
            Me.Fields.Detail.住所1_08.IsError = False
            Me.Fields.Detail.住所1_09.IsError = False
            Me.Fields.Detail.住所1_10.IsError = False
            Me.Fields.Detail.住所1_11.IsError = False
            Me.Fields.Detail.住所2_01.IsError = False
            Me.Fields.Detail.住所2_02.IsError = False
            Me.Fields.Detail.住所2_03.IsError = False
            Me.Fields.Detail.住所2_04.IsError = False
            Me.Fields.Detail.住所2_05.IsError = False
            Me.Fields.Detail.住所2_06.IsError = False
            Me.Fields.Detail.住所2_07.IsError = False
            Me.Fields.Detail.住所2_08.IsError = False
            Me.Fields.Detail.住所2_09.IsError = False
            Me.Fields.Detail.住所2_10.IsError = False
            Me.Fields.Detail.住所2_11.IsError = False
            Me.Fields.Detail.TEL_01.IsError = False
            Me.Fields.Detail.TEL_02.IsError = False
            Me.Fields.Detail.TEL_03.IsError = False
            Me.Fields.Detail.TEL_04.IsError = False
            Me.Fields.Detail.TEL_05.IsError = False
            Me.Fields.Detail.TEL_06.IsError = False
            Me.Fields.Detail.TEL_07.IsError = False
            Me.Fields.Detail.TEL_08.IsError = False
            Me.Fields.Detail.TEL_09.IsError = False
            Me.Fields.Detail.TEL_10.IsError = False
            Me.Fields.Detail.TEL_11.IsError = False
            Me.Fields.Detail.FAX_01.IsError = False
            Me.Fields.Detail.FAX_02.IsError = False
            Me.Fields.Detail.FAX_03.IsError = False
            Me.Fields.Detail.FAX_04.IsError = False
            Me.Fields.Detail.FAX_05.IsError = False
            Me.Fields.Detail.FAX_06.IsError = False
            Me.Fields.Detail.FAX_07.IsError = False
            Me.Fields.Detail.FAX_08.IsError = False
            Me.Fields.Detail.FAX_09.IsError = False
            Me.Fields.Detail.FAX_10.IsError = False
            Me.Fields.Detail.FAX_11.IsError = False
            Me.Fields.Detail.携帯_01.IsError = False
            Me.Fields.Detail.携帯_02.IsError = False
            Me.Fields.Detail.携帯_03.IsError = False
            Me.Fields.Detail.携帯_04.IsError = False
            Me.Fields.Detail.携帯_05.IsError = False
            Me.Fields.Detail.携帯_06.IsError = False
            Me.Fields.Detail.携帯_07.IsError = False
            Me.Fields.Detail.携帯_08.IsError = False
            Me.Fields.Detail.携帯_09.IsError = False
            Me.Fields.Detail.携帯_10.IsError = False
            Me.Fields.Detail.携帯_11.IsError = False
            Me.Fields.Detail.メール_01.IsError = False
            Me.Fields.Detail.メール_02.IsError = False
            Me.Fields.Detail.メール_03.IsError = False
            Me.Fields.Detail.メール_04.IsError = False
            Me.Fields.Detail.メール_05.IsError = False
            Me.Fields.Detail.メール_06.IsError = False
            Me.Fields.Detail.メール_07.IsError = False
            Me.Fields.Detail.メール_08.IsError = False
            Me.Fields.Detail.メール_09.IsError = False
            Me.Fields.Detail.メール_10.IsError = False
            Me.Fields.Detail.メール_11.IsError = False
            Me.Fields.Detail.本支店名_01.IsError = False
            Me.Fields.Detail.本支店名_02.IsError = False
            Me.Fields.Detail.本支店名_03.IsError = False
            Me.Fields.Detail.本支店名_04.IsError = False
            Me.Fields.Detail.本支店名_05.IsError = False
            Me.Fields.Detail.本支店名_06.IsError = False
            Me.Fields.Detail.本支店名_07.IsError = False
            Me.Fields.Detail.本支店名_08.IsError = False
            Me.Fields.Detail.本支店名_09.IsError = False
            Me.Fields.Detail.本支店名_10.IsError = False
            Me.Fields.Detail.本支店名_11.IsError = False
            Me.Fields.Detail.仕入先名.IsError = False
            Me.Fields.Detail.役職_担当者名.IsError = False
            Me.Fields.Detail.代表者役職_代表者名1.IsError = False
            Me.Fields.Detail.代表者役職_代表者名2.IsError = False

            Me.Fields.Note.行NO.IsError = False
            Me.Fields.Note.特記事項_01.IsError = False
            Me.Fields.Note.特記事項_02.IsError = False
            Me.Fields.Note.特記事項_03.IsError = False
            Me.Fields.Note.特記事項_04.IsError = False
            Me.Fields.Note.特記事項_05.IsError = False
            Me.Fields.Note.特記事項_06.IsError = False
            Me.Fields.Note.特記事項_07.IsError = False
            Me.Fields.Note.特記事項_08.IsError = False
            Me.Fields.Note.特記事項_09.IsError = False
            Me.Fields.Note.特記事項_10.IsError = False
            Me.Fields.Note.特記事項_11.IsError = False
            Me.Fields.Note.特記事項_12.IsError = False
            Me.Fields.Note.特記事項_13.IsError = False

            '------------------------------------------------------------------
            ' 共通検査
            '------------------------------------------------------------------
            Validator.BaseChecker(Me.Fields.Header.仕入先CD, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.仕入先名, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.略称, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.カナ名, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.郵便番号, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.住所1, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.住所2, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.役職_担当者名, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.TEL, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.買掛金_未払金区分, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.代表者役職_代表者名1, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.FAX, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Header.代表者役職_代表者名2, strMsg, Me.ControlError)

            Validator.BaseChecker(Me.Fields.Detail.行NO, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.部署名_01, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.部署名_02, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.部署名_03, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.部署名_04, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.部署名_05, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.部署名_06, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.部署名_07, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.部署名_08, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.部署名_09, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.部署名_10, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.部署名_11, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.担当者名_01, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.担当者名_02, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.担当者名_03, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.担当者名_04, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.担当者名_05, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.担当者名_06, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.担当者名_07, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.担当者名_08, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.担当者名_09, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.担当者名_10, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.担当者名_11, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.郵便番号_01, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.郵便番号_02, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.郵便番号_03, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.郵便番号_04, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.郵便番号_05, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.郵便番号_06, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.郵便番号_07, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.郵便番号_08, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.郵便番号_09, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.郵便番号_10, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.郵便番号_11, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.住所1_01, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.住所1_02, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.住所1_03, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.住所1_04, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.住所1_05, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.住所1_06, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.住所1_07, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.住所1_08, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.住所1_09, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.住所1_10, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.住所1_11, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.住所2_01, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.住所2_02, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.住所2_03, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.住所2_04, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.住所2_05, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.住所2_06, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.住所2_07, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.住所2_08, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.住所2_09, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.住所2_10, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.住所2_11, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.TEL_01, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.TEL_02, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.TEL_03, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.TEL_04, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.TEL_05, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.TEL_06, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.TEL_07, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.TEL_08, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.TEL_09, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.TEL_10, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.TEL_11, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.FAX_01, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.FAX_02, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.FAX_03, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.FAX_04, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.FAX_05, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.FAX_06, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.FAX_07, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.FAX_08, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.FAX_09, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.FAX_10, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.FAX_11, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.携帯_01, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.携帯_02, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.携帯_03, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.携帯_04, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.携帯_05, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.携帯_06, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.携帯_07, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.携帯_08, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.携帯_09, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.携帯_10, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.携帯_11, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.メール_01, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.メール_02, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.メール_03, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.メール_04, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.メール_05, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.メール_06, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.メール_07, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.メール_08, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.メール_09, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.メール_10, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.メール_11, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.本支店名_01, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.本支店名_02, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.本支店名_03, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.本支店名_04, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.本支店名_05, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.本支店名_06, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.本支店名_07, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.本支店名_08, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.本支店名_09, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.本支店名_10, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.本支店名_11, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.仕入先名, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.役職_担当者名, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.代表者役職_代表者名1, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Detail.代表者役職_代表者名2, strMsg, Me.ControlError)

            Validator.BaseChecker(Me.Fields.Note.行NO, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Note.特記事項_01, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Note.特記事項_02, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Note.特記事項_03, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Note.特記事項_04, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Note.特記事項_05, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Note.特記事項_06, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Note.特記事項_07, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Note.特記事項_08, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Note.特記事項_09, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Note.特記事項_10, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Note.特記事項_11, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Note.特記事項_12, strMsg, Me.ControlError)
            Validator.BaseChecker(Me.Fields.Note.特記事項_13, strMsg, Me.ControlError)

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

        '''========================================================================================
        ''' <SUMMARY>検査(個別)</SUMMARY>
        ''' <RETURNS>True:正常, False:不正</RETURNS>
        '''========================================================================================
        Protected Overrides Function Valid_Write_Header_Another() As NodeContents.ActionButton.ErrorLevel
            '----------------------------------------------------------------------
            ' 変数定義
            '----------------------------------------------------------------------
            Dim strMsg As String = ""
            Dim Validator As New BaseCore.Common.Validator

            '------------------------------------------------------------------
            ' 個別検査
            '------------------------------------------------------------------
            Select Case True
                Case Me.Fields.Header.仕入先CD.Value = ""
                    Me.Fields.Header.仕入先CD.IsError = True : Me.ControlError = Me.Fields.Header.仕入先CD.Control : Validator.SetMessage(strMsg, "仕入先CDを入力してください。")

                Case Me.Fields.Header.仕入先名.Value = ""
                    Me.Fields.Header.仕入先名.IsError = True : Me.ControlError = Me.Fields.Header.仕入先名.Control : Validator.SetMessage(strMsg, "仕入先名を入力してください。")

                Case Me.Fields.Header.略称.Value = ""
                    Me.Fields.Header.略称.IsError = True : Me.ControlError = Me.Fields.Header.略称.Control : Validator.SetMessage(strMsg, "略称を入力してください。")

                Case Me.Fields.Header.買掛金_未払金区分.Value = ""
                    Me.Fields.Header.買掛金_未払金区分.IsError = True : Me.ControlError = Me.Fields.Header.買掛金_未払金区分.Control : Validator.SetMessage(strMsg, "買掛金・未払金区分を選択して下さい")
            End Select

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

#Region "Execute(ﾌﾟﾚﾋﾞｭｰ)"
        '''========================================================================================
        ''' <SUMMARY>印刷</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overrides Function Execute_Header() As Boolean
            '----------------------------------------------------------------------
            ' 変数定義
            '----------------------------------------------------------------------
            Dim tbl詳細 As New NodeDatabase.DataSetFunc.F0仕入先詳細DataTable
            Dim tbl特記 As New NodeDatabase.DataSetView.V0仕入先特記DataTable

            '----------------------------------------------------------------------
            ' 印刷ﾃﾞｰﾀ
            '----------------------------------------------------------------------
            tbl詳細 = Me.SelectTableDatail()
            tbl特記 = Me.SelectTableNote()

            If tbl詳細.Count = 0 Then
                Me.LastError = "指定された条件に合致するデータはありません。"
                Return False
            End If

            '----------------------------------------------------------------------
            ' ﾚﾎﾟｰﾄ生成
            '----------------------------------------------------------------------
            Dim Report As New NodeReport.SupplierList

            Report.tbl特記 = tbl特記
            Report.Document.Name = "顧客台帳"
            Report.Document.Printer.PrinterName = ""
            Report.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
            Report.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
            Report.DataSource = tbl詳細
            Report.Run()

            Me.Report1 = Report    ' 画面側へ渡す

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return True
        End Function
#End Region

#Region "Execute1(直接印刷)"
        '''========================================================================================
        ''' <SUMMARY>印刷</SUMMARY>
        ''' <RETURNS>True:正常終了, False:ｼｽﾃﾑｴﾗｰ</RETURNS>
        '''========================================================================================
        Protected Overrides Function Execute1_Header() As Boolean
            '----------------------------------------------------------------------
            ' 変数定義
            '----------------------------------------------------------------------
            Dim tbl詳細 As New NodeDatabase.DataSetFunc.F0仕入先詳細DataTable
            Dim tbl特記 As New NodeDatabase.DataSetView.V0仕入先特記DataTable

            '----------------------------------------------------------------------
            ' 印刷ﾃﾞｰﾀ
            '----------------------------------------------------------------------
            tbl詳細 = Me.SelectTableDatail()
            tbl特記 = Me.SelectTableNote()

            If tbl詳細.Count = 0 Then
                Me.LastError = "指定された条件に合致するデータはありません。"
                Return False
            End If

            '----------------------------------------------------------------------
            ' ﾚﾎﾟｰﾄ生成
            '----------------------------------------------------------------------
            Dim Report As New NodeReport.SupplierList

            Report.tbl特記 = tbl特記
            Report.Document.Name = "顧客台帳"
            Report.Document.Printer.PrinterName = ""
            Report.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
            Report.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
            Report.DataSource = tbl詳細
            Report.Run()
            Report.Document.Print(False, False, False)   ' 直接印刷

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return True
        End Function
#End Region

#Region "其他"
#Region "印刷ﾃﾞｰﾀ作成(詳細情報)"
        '''========================================================================================
        ''' <SUMMARY>印刷ﾃﾞｰﾀ(詳細情報)</SUMMARY>
        ''' <RETURNS>ﾃﾞｰﾀﾃｰﾌﾞﾙ</RETURNS>
        '''========================================================================================
        Private Function SelectTableDatail() As NodeDatabase.DataSetFunc.F0仕入先詳細DataTable
            '----------------------------------------------------------------------
            ' 変数定義
            '----------------------------------------------------------------------
            Dim ada As New NodeDatabase.DataSetFuncTableAdapters.F0仕入先詳細TableAdapter
            Dim tbl As New NodeDatabase.DataSetFunc.F0仕入先詳細DataTable
            Dim qry As New Collection

            Dim strSort As String = ""
            Dim strDelim As String = ""

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()
            qry.Add(New BaseDatabase.Condition(tbl.仕入先CDColumn.ColumnName, Me.Fields.Print.仕入先CDF.Value, BaseDatabase.Contents.Compare.GreaterEqual, BaseDatabase.Contents.EmptyHandle.Skip))
            qry.Add(New BaseDatabase.Condition(tbl.仕入先CDColumn.ColumnName, Me.Fields.Print.仕入先CDT.Value, BaseDatabase.Contents.Compare.LessEqual, BaseDatabase.Contents.EmptyHandle.Skip))

            '----------------------------------------------------------------------
            ' 読込
            '----------------------------------------------------------------------
            strSort &= strDelim & tbl.仕入先CDColumn.ColumnName & "  ASC" : strDelim = ","
            tbl = ada.SelectByCommon(qry, strSort)

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return tbl
        End Function
#End Region

#Region "印刷ﾃﾞｰﾀ作成(特記事項)"
        '''========================================================================================
        ''' <SUMMARY>印刷ﾃﾞｰﾀ(詳細情報)</SUMMARY>
        ''' <RETURNS>ﾃﾞｰﾀﾃｰﾌﾞﾙ</RETURNS>
        '''========================================================================================
        Private Function SelectTableNote() As NodeDatabase.DataSetView.V0仕入先特記DataTable
            '----------------------------------------------------------------------
            ' 変数定義
            '----------------------------------------------------------------------
            Dim ada As New NodeDatabase.DataSetViewTableAdapters.V0仕入先特記TableAdapter
            Dim tbl As New NodeDatabase.DataSetView.V0仕入先特記DataTable
            Dim qry As New Collection

            Dim strSort As String = ""
            Dim strDelim As String = ""

            '----------------------------------------------------------------------
            ' 条件設定
            '----------------------------------------------------------------------
            qry.Clear()

            '----------------------------------------------------------------------
            ' 読込
            '----------------------------------------------------------------------
            strSort &= strDelim & tbl.仕入先CDColumn.ColumnName & "  ASC" : strDelim = ","
            strSort &= strDelim & tbl.行NOColumn.ColumnName & "  ASC" : strDelim = ","
            tbl = ada.SelectByCommon(qry, strSort)

            '----------------------------------------------------------------------
            ' 正常終了
            '----------------------------------------------------------------------
            Return tbl
        End Function
#End Region

#Region "行挿入"
        '''========================================================================================
        ''' <SUMMARY>ﾍｯﾀﾞ</SUMMARY>
        ''' <RETURNS>True:あり, False:なし</RETURNS>
        '''========================================================================================
        Public Function InsertLine(ByVal position As Integer) As Boolean
            If Me.Fields.Detail.部署名_11.Value <> "" _
            Or Me.Fields.Detail.担当者名_11.Value <> "" _
            Or Me.Fields.Detail.郵便番号_11.Value <> "" _
            Or Me.Fields.Detail.住所1_11.Value <> "" _
            Or Me.Fields.Detail.住所2_11.Value <> "" _
            Or Me.Fields.Detail.TEL_11.Value <> "" _
            Or Me.Fields.Detail.FAX_11.Value <> "" _
            Or Me.Fields.Detail.携帯_11.Value <> "" _
            Or Me.Fields.Detail.メール_11.Value <> "" _
            Or Me.Fields.Detail.本支店名_11.Value <> "" Then
                MyBase.LastError = "最大行数を超えた為に行挿入できません"
                Return False
            End If

            Dim i As Integer = maxline
            Do While Not position = i
                i -= 1
                Select Case i
                    Case 11
                    Case 10
                        Me.Fields.Detail.部署名_11.Value = Me.Fields.Detail.部署名_10.Value
                        Me.Fields.Detail.担当者名_11.Value = Me.Fields.Detail.担当者名_10.Value
                        Me.Fields.Detail.郵便番号_11.Value = Me.Fields.Detail.郵便番号_10.Value
                        Me.Fields.Detail.住所1_11.Value = Me.Fields.Detail.住所1_10.Value
                        Me.Fields.Detail.住所2_11.Value = Me.Fields.Detail.住所2_10.Value
                        Me.Fields.Detail.TEL_11.Value = Me.Fields.Detail.TEL_10.Value
                        Me.Fields.Detail.FAX_11.Value = Me.Fields.Detail.FAX_10.Value
                        Me.Fields.Detail.携帯_11.Value = Me.Fields.Detail.携帯_10.Value
                        Me.Fields.Detail.メール_11.Value = Me.Fields.Detail.メール_10.Value
                        Me.Fields.Detail.本支店名_11.Value = Me.Fields.Detail.本支店名_10.Value
                        Me.Fields.Detail.部署名_10.Value = ""
                        Me.Fields.Detail.担当者名_10.Value = ""
                        Me.Fields.Detail.郵便番号_10.Value = ""
                        Me.Fields.Detail.住所1_10.Value = ""
                        Me.Fields.Detail.住所2_10.Value = ""
                        Me.Fields.Detail.TEL_10.Value = ""
                        Me.Fields.Detail.FAX_10.Value = ""
                        Me.Fields.Detail.携帯_10.Value = ""
                        Me.Fields.Detail.メール_10.Value = ""
                        Me.Fields.Detail.本支店名_10.Value = ""
                    Case 9
                        Me.Fields.Detail.部署名_10.Value = Me.Fields.Detail.部署名_09.Value
                        Me.Fields.Detail.担当者名_10.Value = Me.Fields.Detail.担当者名_09.Value
                        Me.Fields.Detail.郵便番号_10.Value = Me.Fields.Detail.郵便番号_09.Value
                        Me.Fields.Detail.住所1_10.Value = Me.Fields.Detail.住所1_09.Value
                        Me.Fields.Detail.住所2_10.Value = Me.Fields.Detail.住所2_09.Value
                        Me.Fields.Detail.TEL_10.Value = Me.Fields.Detail.TEL_09.Value
                        Me.Fields.Detail.FAX_10.Value = Me.Fields.Detail.FAX_09.Value
                        Me.Fields.Detail.携帯_10.Value = Me.Fields.Detail.携帯_09.Value
                        Me.Fields.Detail.メール_10.Value = Me.Fields.Detail.メール_09.Value
                        Me.Fields.Detail.本支店名_10.Value = Me.Fields.Detail.本支店名_09.Value
                        Me.Fields.Detail.部署名_09.Value = ""
                        Me.Fields.Detail.担当者名_09.Value = ""
                        Me.Fields.Detail.郵便番号_09.Value = ""
                        Me.Fields.Detail.住所1_09.Value = ""
                        Me.Fields.Detail.住所2_09.Value = ""
                        Me.Fields.Detail.TEL_09.Value = ""
                        Me.Fields.Detail.FAX_09.Value = ""
                        Me.Fields.Detail.携帯_09.Value = ""
                        Me.Fields.Detail.メール_09.Value = ""
                        Me.Fields.Detail.本支店名_09.Value = ""
                    Case 8
                        Me.Fields.Detail.部署名_09.Value = Me.Fields.Detail.部署名_08.Value
                        Me.Fields.Detail.担当者名_09.Value = Me.Fields.Detail.担当者名_08.Value
                        Me.Fields.Detail.郵便番号_09.Value = Me.Fields.Detail.郵便番号_08.Value
                        Me.Fields.Detail.住所1_09.Value = Me.Fields.Detail.住所1_08.Value
                        Me.Fields.Detail.住所2_09.Value = Me.Fields.Detail.住所2_08.Value
                        Me.Fields.Detail.TEL_09.Value = Me.Fields.Detail.TEL_08.Value
                        Me.Fields.Detail.FAX_09.Value = Me.Fields.Detail.FAX_08.Value
                        Me.Fields.Detail.携帯_09.Value = Me.Fields.Detail.携帯_08.Value
                        Me.Fields.Detail.メール_09.Value = Me.Fields.Detail.メール_08.Value
                        Me.Fields.Detail.本支店名_09.Value = Me.Fields.Detail.本支店名_08.Value
                        Me.Fields.Detail.部署名_08.Value = ""
                        Me.Fields.Detail.担当者名_08.Value = ""
                        Me.Fields.Detail.郵便番号_08.Value = ""
                        Me.Fields.Detail.住所1_08.Value = ""
                        Me.Fields.Detail.住所2_08.Value = ""
                        Me.Fields.Detail.TEL_08.Value = ""
                        Me.Fields.Detail.FAX_08.Value = ""
                        Me.Fields.Detail.携帯_08.Value = ""
                        Me.Fields.Detail.メール_08.Value = ""
                        Me.Fields.Detail.本支店名_08.Value = ""
                    Case 7
                        Me.Fields.Detail.部署名_08.Value = Me.Fields.Detail.部署名_07.Value
                        Me.Fields.Detail.担当者名_08.Value = Me.Fields.Detail.担当者名_07.Value
                        Me.Fields.Detail.郵便番号_08.Value = Me.Fields.Detail.郵便番号_07.Value
                        Me.Fields.Detail.住所1_08.Value = Me.Fields.Detail.住所1_07.Value
                        Me.Fields.Detail.住所2_08.Value = Me.Fields.Detail.住所2_07.Value
                        Me.Fields.Detail.TEL_08.Value = Me.Fields.Detail.TEL_07.Value
                        Me.Fields.Detail.FAX_08.Value = Me.Fields.Detail.FAX_07.Value
                        Me.Fields.Detail.携帯_08.Value = Me.Fields.Detail.携帯_07.Value
                        Me.Fields.Detail.メール_08.Value = Me.Fields.Detail.メール_07.Value
                        Me.Fields.Detail.本支店名_08.Value = Me.Fields.Detail.本支店名_07.Value
                        Me.Fields.Detail.部署名_07.Value = ""
                        Me.Fields.Detail.担当者名_07.Value = ""
                        Me.Fields.Detail.郵便番号_07.Value = ""
                        Me.Fields.Detail.住所1_07.Value = ""
                        Me.Fields.Detail.住所2_07.Value = ""
                        Me.Fields.Detail.TEL_07.Value = ""
                        Me.Fields.Detail.FAX_07.Value = ""
                        Me.Fields.Detail.携帯_07.Value = ""
                        Me.Fields.Detail.メール_07.Value = ""
                        Me.Fields.Detail.本支店名_07.Value = ""
                    Case 6
                        Me.Fields.Detail.部署名_07.Value = Me.Fields.Detail.部署名_06.Value
                        Me.Fields.Detail.担当者名_07.Value = Me.Fields.Detail.担当者名_06.Value
                        Me.Fields.Detail.郵便番号_07.Value = Me.Fields.Detail.郵便番号_06.Value
                        Me.Fields.Detail.住所1_07.Value = Me.Fields.Detail.住所1_06.Value
                        Me.Fields.Detail.住所2_07.Value = Me.Fields.Detail.住所2_06.Value
                        Me.Fields.Detail.TEL_07.Value = Me.Fields.Detail.TEL_06.Value
                        Me.Fields.Detail.FAX_07.Value = Me.Fields.Detail.FAX_06.Value
                        Me.Fields.Detail.携帯_07.Value = Me.Fields.Detail.携帯_06.Value
                        Me.Fields.Detail.メール_07.Value = Me.Fields.Detail.メール_06.Value
                        Me.Fields.Detail.本支店名_07.Value = Me.Fields.Detail.本支店名_06.Value
                        Me.Fields.Detail.部署名_06.Value = ""
                        Me.Fields.Detail.担当者名_06.Value = ""
                        Me.Fields.Detail.郵便番号_06.Value = ""
                        Me.Fields.Detail.住所1_06.Value = ""
                        Me.Fields.Detail.住所2_06.Value = ""
                        Me.Fields.Detail.TEL_06.Value = ""
                        Me.Fields.Detail.FAX_06.Value = ""
                        Me.Fields.Detail.携帯_06.Value = ""
                        Me.Fields.Detail.メール_06.Value = ""
                        Me.Fields.Detail.本支店名_06.Value = ""
                    Case 5
                        Me.Fields.Detail.部署名_06.Value = Me.Fields.Detail.部署名_05.Value
                        Me.Fields.Detail.担当者名_06.Value = Me.Fields.Detail.担当者名_05.Value
                        Me.Fields.Detail.郵便番号_06.Value = Me.Fields.Detail.郵便番号_05.Value
                        Me.Fields.Detail.住所1_06.Value = Me.Fields.Detail.住所1_05.Value
                        Me.Fields.Detail.住所2_06.Value = Me.Fields.Detail.住所2_05.Value
                        Me.Fields.Detail.TEL_06.Value = Me.Fields.Detail.TEL_05.Value
                        Me.Fields.Detail.FAX_06.Value = Me.Fields.Detail.FAX_05.Value
                        Me.Fields.Detail.携帯_06.Value = Me.Fields.Detail.携帯_05.Value
                        Me.Fields.Detail.メール_06.Value = Me.Fields.Detail.メール_05.Value
                        Me.Fields.Detail.本支店名_06.Value = Me.Fields.Detail.本支店名_05.Value
                        Me.Fields.Detail.部署名_05.Value = ""
                        Me.Fields.Detail.担当者名_05.Value = ""
                        Me.Fields.Detail.郵便番号_05.Value = ""
                        Me.Fields.Detail.住所1_05.Value = ""
                        Me.Fields.Detail.住所2_05.Value = ""
                        Me.Fields.Detail.TEL_05.Value = ""
                        Me.Fields.Detail.FAX_05.Value = ""
                        Me.Fields.Detail.携帯_05.Value = ""
                        Me.Fields.Detail.メール_05.Value = ""
                        Me.Fields.Detail.本支店名_05.Value = ""
                    Case 4
                        Me.Fields.Detail.部署名_05.Value = Me.Fields.Detail.部署名_04.Value
                        Me.Fields.Detail.担当者名_05.Value = Me.Fields.Detail.担当者名_04.Value
                        Me.Fields.Detail.郵便番号_05.Value = Me.Fields.Detail.郵便番号_04.Value
                        Me.Fields.Detail.住所1_05.Value = Me.Fields.Detail.住所1_04.Value
                        Me.Fields.Detail.住所2_05.Value = Me.Fields.Detail.住所2_04.Value
                        Me.Fields.Detail.TEL_05.Value = Me.Fields.Detail.TEL_04.Value
                        Me.Fields.Detail.FAX_05.Value = Me.Fields.Detail.FAX_04.Value
                        Me.Fields.Detail.携帯_05.Value = Me.Fields.Detail.携帯_04.Value
                        Me.Fields.Detail.メール_05.Value = Me.Fields.Detail.メール_04.Value
                        Me.Fields.Detail.本支店名_05.Value = Me.Fields.Detail.本支店名_04.Value
                        Me.Fields.Detail.部署名_04.Value = ""
                        Me.Fields.Detail.担当者名_04.Value = ""
                        Me.Fields.Detail.郵便番号_04.Value = ""
                        Me.Fields.Detail.住所1_04.Value = ""
                        Me.Fields.Detail.住所2_04.Value = ""
                        Me.Fields.Detail.TEL_04.Value = ""
                        Me.Fields.Detail.FAX_04.Value = ""
                        Me.Fields.Detail.携帯_04.Value = ""
                        Me.Fields.Detail.メール_04.Value = ""
                        Me.Fields.Detail.本支店名_04.Value = ""
                    Case 3
                        Me.Fields.Detail.部署名_04.Value = Me.Fields.Detail.部署名_03.Value
                        Me.Fields.Detail.担当者名_04.Value = Me.Fields.Detail.担当者名_03.Value
                        Me.Fields.Detail.郵便番号_04.Value = Me.Fields.Detail.郵便番号_03.Value
                        Me.Fields.Detail.住所1_04.Value = Me.Fields.Detail.住所1_03.Value
                        Me.Fields.Detail.住所2_04.Value = Me.Fields.Detail.住所2_03.Value
                        Me.Fields.Detail.TEL_04.Value = Me.Fields.Detail.TEL_03.Value
                        Me.Fields.Detail.FAX_04.Value = Me.Fields.Detail.FAX_03.Value
                        Me.Fields.Detail.携帯_04.Value = Me.Fields.Detail.携帯_03.Value
                        Me.Fields.Detail.メール_04.Value = Me.Fields.Detail.メール_03.Value
                        Me.Fields.Detail.本支店名_04.Value = Me.Fields.Detail.本支店名_03.Value
                        Me.Fields.Detail.部署名_03.Value = ""
                        Me.Fields.Detail.担当者名_03.Value = ""
                        Me.Fields.Detail.郵便番号_03.Value = ""
                        Me.Fields.Detail.住所1_03.Value = ""
                        Me.Fields.Detail.住所2_03.Value = ""
                        Me.Fields.Detail.TEL_03.Value = ""
                        Me.Fields.Detail.FAX_03.Value = ""
                        Me.Fields.Detail.携帯_03.Value = ""
                        Me.Fields.Detail.メール_03.Value = ""
                        Me.Fields.Detail.本支店名_03.Value = ""
                    Case 2
                        Me.Fields.Detail.部署名_03.Value = Me.Fields.Detail.部署名_02.Value
                        Me.Fields.Detail.担当者名_03.Value = Me.Fields.Detail.担当者名_02.Value
                        Me.Fields.Detail.郵便番号_03.Value = Me.Fields.Detail.郵便番号_02.Value
                        Me.Fields.Detail.住所1_03.Value = Me.Fields.Detail.住所1_02.Value
                        Me.Fields.Detail.住所2_03.Value = Me.Fields.Detail.住所2_02.Value
                        Me.Fields.Detail.TEL_03.Value = Me.Fields.Detail.TEL_02.Value
                        Me.Fields.Detail.FAX_03.Value = Me.Fields.Detail.FAX_02.Value
                        Me.Fields.Detail.携帯_03.Value = Me.Fields.Detail.携帯_02.Value
                        Me.Fields.Detail.メール_03.Value = Me.Fields.Detail.メール_02.Value
                        Me.Fields.Detail.本支店名_03.Value = Me.Fields.Detail.本支店名_02.Value
                        Me.Fields.Detail.部署名_02.Value = ""
                        Me.Fields.Detail.担当者名_02.Value = ""
                        Me.Fields.Detail.郵便番号_02.Value = ""
                        Me.Fields.Detail.住所1_02.Value = ""
                        Me.Fields.Detail.住所2_02.Value = ""
                        Me.Fields.Detail.TEL_02.Value = ""
                        Me.Fields.Detail.FAX_02.Value = ""
                        Me.Fields.Detail.携帯_02.Value = ""
                        Me.Fields.Detail.メール_02.Value = ""
                        Me.Fields.Detail.本支店名_02.Value = ""
                    Case 1
                        Me.Fields.Detail.部署名_02.Value = Me.Fields.Detail.部署名_01.Value
                        Me.Fields.Detail.担当者名_02.Value = Me.Fields.Detail.担当者名_01.Value
                        Me.Fields.Detail.郵便番号_02.Value = Me.Fields.Detail.郵便番号_01.Value
                        Me.Fields.Detail.住所1_02.Value = Me.Fields.Detail.住所1_01.Value
                        Me.Fields.Detail.住所2_02.Value = Me.Fields.Detail.住所2_01.Value
                        Me.Fields.Detail.TEL_02.Value = Me.Fields.Detail.TEL_01.Value
                        Me.Fields.Detail.FAX_02.Value = Me.Fields.Detail.FAX_01.Value
                        Me.Fields.Detail.携帯_02.Value = Me.Fields.Detail.携帯_01.Value
                        Me.Fields.Detail.メール_02.Value = Me.Fields.Detail.メール_01.Value
                        Me.Fields.Detail.本支店名_02.Value = Me.Fields.Detail.本支店名_01.Value
                        Me.Fields.Detail.部署名_01.Value = ""
                        Me.Fields.Detail.担当者名_01.Value = ""
                        Me.Fields.Detail.郵便番号_01.Value = ""
                        Me.Fields.Detail.住所1_01.Value = ""
                        Me.Fields.Detail.住所2_01.Value = ""
                        Me.Fields.Detail.TEL_01.Value = ""
                        Me.Fields.Detail.FAX_01.Value = ""
                        Me.Fields.Detail.携帯_01.Value = ""
                        Me.Fields.Detail.メール_01.Value = ""
                        Me.Fields.Detail.本支店名_01.Value = ""
                End Select
            Loop

            '----------------------------------------------------------------------
            ' 返却
            '----------------------------------------------------------------------
            Return True
        End Function
#End Region

#Region "行削除"
        '''========================================================================================
        ''' <SUMMARY>ﾍｯﾀﾞ</SUMMARY>
        ''' <RETURNS>True:あり, False:なし</RETURNS>
        '''========================================================================================
        Public Function DeleteLine(ByVal position As Integer) As Boolean
            Dim i As Integer = position - 1
            Do While Not i = maxline
                i += 1
                Select Case i
                    Case 1
                        Me.Fields.Detail.部署名_01.Value = Me.Fields.Detail.部署名_02.Value
                        Me.Fields.Detail.担当者名_01.Value = Me.Fields.Detail.担当者名_02.Value
                        Me.Fields.Detail.郵便番号_01.Value = Me.Fields.Detail.郵便番号_02.Value
                        Me.Fields.Detail.住所1_01.Value = Me.Fields.Detail.住所1_02.Value
                        Me.Fields.Detail.住所2_01.Value = Me.Fields.Detail.住所2_02.Value
                        Me.Fields.Detail.TEL_01.Value = Me.Fields.Detail.TEL_02.Value
                        Me.Fields.Detail.FAX_01.Value = Me.Fields.Detail.FAX_02.Value
                        Me.Fields.Detail.携帯_01.Value = Me.Fields.Detail.携帯_02.Value
                        Me.Fields.Detail.メール_01.Value = Me.Fields.Detail.メール_02.Value
                        Me.Fields.Detail.本支店名_01.Value = Me.Fields.Detail.本支店名_02.Value
                    Case 2
                        Me.Fields.Detail.部署名_02.Value = Me.Fields.Detail.部署名_03.Value
                        Me.Fields.Detail.担当者名_02.Value = Me.Fields.Detail.担当者名_03.Value
                        Me.Fields.Detail.郵便番号_02.Value = Me.Fields.Detail.郵便番号_03.Value
                        Me.Fields.Detail.住所1_02.Value = Me.Fields.Detail.住所1_03.Value
                        Me.Fields.Detail.住所2_02.Value = Me.Fields.Detail.住所2_03.Value
                        Me.Fields.Detail.TEL_02.Value = Me.Fields.Detail.TEL_03.Value
                        Me.Fields.Detail.FAX_02.Value = Me.Fields.Detail.FAX_03.Value
                        Me.Fields.Detail.携帯_02.Value = Me.Fields.Detail.携帯_03.Value
                        Me.Fields.Detail.メール_02.Value = Me.Fields.Detail.メール_03.Value
                        Me.Fields.Detail.本支店名_02.Value = Me.Fields.Detail.本支店名_03.Value
                    Case 3
                        Me.Fields.Detail.部署名_03.Value = Me.Fields.Detail.部署名_04.Value
                        Me.Fields.Detail.担当者名_03.Value = Me.Fields.Detail.担当者名_04.Value
                        Me.Fields.Detail.郵便番号_03.Value = Me.Fields.Detail.郵便番号_04.Value
                        Me.Fields.Detail.住所1_03.Value = Me.Fields.Detail.住所1_04.Value
                        Me.Fields.Detail.住所2_03.Value = Me.Fields.Detail.住所2_04.Value
                        Me.Fields.Detail.TEL_03.Value = Me.Fields.Detail.TEL_04.Value
                        Me.Fields.Detail.FAX_03.Value = Me.Fields.Detail.FAX_04.Value
                        Me.Fields.Detail.携帯_03.Value = Me.Fields.Detail.携帯_04.Value
                        Me.Fields.Detail.メール_03.Value = Me.Fields.Detail.メール_04.Value
                        Me.Fields.Detail.本支店名_03.Value = Me.Fields.Detail.本支店名_04.Value
                    Case 4
                        Me.Fields.Detail.部署名_04.Value = Me.Fields.Detail.部署名_05.Value
                        Me.Fields.Detail.担当者名_04.Value = Me.Fields.Detail.担当者名_05.Value
                        Me.Fields.Detail.郵便番号_04.Value = Me.Fields.Detail.郵便番号_05.Value
                        Me.Fields.Detail.住所1_04.Value = Me.Fields.Detail.住所1_05.Value
                        Me.Fields.Detail.住所2_04.Value = Me.Fields.Detail.住所2_05.Value
                        Me.Fields.Detail.TEL_04.Value = Me.Fields.Detail.TEL_05.Value
                        Me.Fields.Detail.FAX_04.Value = Me.Fields.Detail.FAX_05.Value
                        Me.Fields.Detail.携帯_04.Value = Me.Fields.Detail.携帯_05.Value
                        Me.Fields.Detail.メール_04.Value = Me.Fields.Detail.メール_05.Value
                        Me.Fields.Detail.本支店名_04.Value = Me.Fields.Detail.本支店名_05.Value
                    Case 5
                        Me.Fields.Detail.部署名_05.Value = Me.Fields.Detail.部署名_06.Value
                        Me.Fields.Detail.担当者名_05.Value = Me.Fields.Detail.担当者名_06.Value
                        Me.Fields.Detail.郵便番号_05.Value = Me.Fields.Detail.郵便番号_06.Value
                        Me.Fields.Detail.住所1_05.Value = Me.Fields.Detail.住所1_06.Value
                        Me.Fields.Detail.住所2_05.Value = Me.Fields.Detail.住所2_06.Value
                        Me.Fields.Detail.TEL_05.Value = Me.Fields.Detail.TEL_06.Value
                        Me.Fields.Detail.FAX_05.Value = Me.Fields.Detail.FAX_06.Value
                        Me.Fields.Detail.携帯_05.Value = Me.Fields.Detail.携帯_06.Value
                        Me.Fields.Detail.メール_05.Value = Me.Fields.Detail.メール_06.Value
                        Me.Fields.Detail.本支店名_05.Value = Me.Fields.Detail.本支店名_06.Value
                    Case 6
                        Me.Fields.Detail.部署名_06.Value = Me.Fields.Detail.部署名_07.Value
                        Me.Fields.Detail.担当者名_06.Value = Me.Fields.Detail.担当者名_07.Value
                        Me.Fields.Detail.郵便番号_06.Value = Me.Fields.Detail.郵便番号_07.Value
                        Me.Fields.Detail.住所1_06.Value = Me.Fields.Detail.住所1_07.Value
                        Me.Fields.Detail.住所2_06.Value = Me.Fields.Detail.住所2_07.Value
                        Me.Fields.Detail.TEL_06.Value = Me.Fields.Detail.TEL_07.Value
                        Me.Fields.Detail.FAX_06.Value = Me.Fields.Detail.FAX_07.Value
                        Me.Fields.Detail.携帯_06.Value = Me.Fields.Detail.携帯_07.Value
                        Me.Fields.Detail.メール_06.Value = Me.Fields.Detail.メール_07.Value
                        Me.Fields.Detail.本支店名_06.Value = Me.Fields.Detail.本支店名_07.Value
                    Case 7
                        Me.Fields.Detail.部署名_07.Value = Me.Fields.Detail.部署名_08.Value
                        Me.Fields.Detail.担当者名_07.Value = Me.Fields.Detail.担当者名_08.Value
                        Me.Fields.Detail.郵便番号_07.Value = Me.Fields.Detail.郵便番号_08.Value
                        Me.Fields.Detail.住所1_07.Value = Me.Fields.Detail.住所1_08.Value
                        Me.Fields.Detail.住所2_07.Value = Me.Fields.Detail.住所2_08.Value
                        Me.Fields.Detail.TEL_07.Value = Me.Fields.Detail.TEL_08.Value
                        Me.Fields.Detail.FAX_07.Value = Me.Fields.Detail.FAX_08.Value
                        Me.Fields.Detail.携帯_07.Value = Me.Fields.Detail.携帯_08.Value
                        Me.Fields.Detail.メール_07.Value = Me.Fields.Detail.メール_08.Value
                        Me.Fields.Detail.本支店名_07.Value = Me.Fields.Detail.本支店名_08.Value
                    Case 8
                        Me.Fields.Detail.部署名_08.Value = Me.Fields.Detail.部署名_09.Value
                        Me.Fields.Detail.担当者名_08.Value = Me.Fields.Detail.担当者名_09.Value
                        Me.Fields.Detail.郵便番号_08.Value = Me.Fields.Detail.郵便番号_09.Value
                        Me.Fields.Detail.住所1_08.Value = Me.Fields.Detail.住所1_09.Value
                        Me.Fields.Detail.住所2_08.Value = Me.Fields.Detail.住所2_09.Value
                        Me.Fields.Detail.TEL_08.Value = Me.Fields.Detail.TEL_09.Value
                        Me.Fields.Detail.FAX_08.Value = Me.Fields.Detail.FAX_09.Value
                        Me.Fields.Detail.携帯_08.Value = Me.Fields.Detail.携帯_09.Value
                        Me.Fields.Detail.メール_08.Value = Me.Fields.Detail.メール_09.Value
                        Me.Fields.Detail.本支店名_08.Value = Me.Fields.Detail.本支店名_09.Value
                    Case 9
                        Me.Fields.Detail.部署名_09.Value = Me.Fields.Detail.部署名_10.Value
                        Me.Fields.Detail.担当者名_09.Value = Me.Fields.Detail.担当者名_10.Value
                        Me.Fields.Detail.郵便番号_09.Value = Me.Fields.Detail.郵便番号_10.Value
                        Me.Fields.Detail.住所1_09.Value = Me.Fields.Detail.住所1_10.Value
                        Me.Fields.Detail.住所2_09.Value = Me.Fields.Detail.住所2_10.Value
                        Me.Fields.Detail.TEL_09.Value = Me.Fields.Detail.TEL_10.Value
                        Me.Fields.Detail.FAX_09.Value = Me.Fields.Detail.FAX_10.Value
                        Me.Fields.Detail.携帯_09.Value = Me.Fields.Detail.携帯_10.Value
                        Me.Fields.Detail.メール_09.Value = Me.Fields.Detail.メール_10.Value
                        Me.Fields.Detail.本支店名_09.Value = Me.Fields.Detail.本支店名_10.Value
                    Case 10
                        Me.Fields.Detail.部署名_10.Value = Me.Fields.Detail.部署名_11.Value
                        Me.Fields.Detail.担当者名_10.Value = Me.Fields.Detail.担当者名_11.Value
                        Me.Fields.Detail.郵便番号_10.Value = Me.Fields.Detail.郵便番号_11.Value
                        Me.Fields.Detail.住所1_10.Value = Me.Fields.Detail.住所1_11.Value
                        Me.Fields.Detail.住所2_10.Value = Me.Fields.Detail.住所2_11.Value
                        Me.Fields.Detail.TEL_10.Value = Me.Fields.Detail.TEL_11.Value
                        Me.Fields.Detail.FAX_10.Value = Me.Fields.Detail.FAX_11.Value
                        Me.Fields.Detail.携帯_10.Value = Me.Fields.Detail.携帯_11.Value
                        Me.Fields.Detail.メール_10.Value = Me.Fields.Detail.メール_11.Value
                        Me.Fields.Detail.本支店名_10.Value = Me.Fields.Detail.本支店名_11.Value
                    Case 11
                        Me.Fields.Detail.部署名_11.Value = ""
                        Me.Fields.Detail.担当者名_11.Value = ""
                        Me.Fields.Detail.郵便番号_11.Value = ""
                        Me.Fields.Detail.住所1_11.Value = ""
                        Me.Fields.Detail.住所2_11.Value = ""
                        Me.Fields.Detail.TEL_11.Value = ""
                        Me.Fields.Detail.FAX_11.Value = ""
                        Me.Fields.Detail.携帯_11.Value = ""
                        Me.Fields.Detail.メール_11.Value = ""
                        Me.Fields.Detail.本支店名_11.Value = ""
                End Select
            Loop

            '----------------------------------------------------------------------
            ' 返却
            '----------------------------------------------------------------------
            Return True
        End Function
#End Region
#End Region
    End Class
End Namespace