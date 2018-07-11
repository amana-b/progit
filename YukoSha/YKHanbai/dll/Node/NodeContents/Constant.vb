Namespace Constant
    '''----------------------------------------------------------------------------------------
    ''' <summary>System</summary>
    '''----------------------------------------------------------------------------------------
    Public Class System
        Public Const APP_COPYRIGHT = "Copyright &copy;2016-@Year Nichiryo-Logistics Co.,Ltd. All rights reserved."

        Public Const LOG_RECORD = True                            ' システムログを記録するかどうか
    End Class

    '''----------------------------------------------------------------------------------------
    ''' <summary>桁数</summary>
    '''----------------------------------------------------------------------------------------
    Public Class 桁数
        Public Class 数量
            Public Const 整数 = 9
            Public Const 小数 = 0
        End Class

        Public Class 単価
            Public Const 整数 = 7
            Public Const 小数 = 2
        End Class

        Public Class 金額
            Public Const 整数 = 9
            Public Const 小数 = 0
        End Class

        Public Class 取引額
            Public Const 整数 = 11
            Public Const 小数 = 0
        End Class
    End Class


    '''----------------------------------------------------------------------------------------
    ''' <summary>区分種別</summary>
    '''----------------------------------------------------------------------------------------
    Public Class CodeType
        Public Const フラグ As String = "フラグ"
        Public Const 紙種別 As String = "紙種別"
        Public Const 機械区分 As String = "機械区分"
        Public Const 機械種別区分 As String = "機械種別区分"
        Public Const 再利用区分 As String = "再利用区分"
        Public Const 場所区分 As String = "場所区分"
        Public Const 単価区分 As String = "単価区分"
        Public Const 重要度 As String = "重要度"
        Public Const 消費税区分 As String = "消費税区分"
        Public Const 請求書発行区分 As String = "請求書発行区分"
        Public Const 回収方法 As String = "回収方法"
        Public Const 定番品区分 As String = "定番品区分"
        Public Const 在庫区分 As String = "在庫区分"
        Public Const 買掛金未払金区分 As String = "買掛金未払金区分"
        Public Const 種別内訳区分 As String = "種別内訳区分"
        Public Const 帳票区分 As String = "帳票区分"
        Public Const 工程区分 As String = "工程区分"
        Public Const 発注単位区分 As String = "発注単位区分"
        Public Const 取引先区分 As String = "取引先区分"
        Public Const 社内外区分 As String = "社内外区分"
        Public Const 確約区分 As String = "確約区分"
        Public Const 刃型区分 As String = "刃型区分"
        Public Const 受注区分 As String = "受注区分"
        Public Const フレキ機械種別区分 As String = "フレキ機械種別区分"
        Public Const 刃型形状区分 As String = "刃型形状区分"
        Public Const 新再版区分 As String = "新再版区分"
        Public Const 単位区分 As String = "単位区分"
        Public Const 仕入先指定区分 As String = "仕入先指定区分"
        Public Const 納入区分 As String = "納入区分"
        Public Const 支給区分 As String = "支給区分"
        Public Const 希望時間帯区分 As String = "希望時間帯区分"
        Public Const 完納区分 As String = "完納区分"
        Public Const 売上指示区分 As String = "売上指示区分"
        Public Const 売上指示区分運賃 As String = "売上指示区分運賃"

        Public Const 巻取区分 As String = "巻取区分"
        Public Const 出し方向区分 As String = "出し方向区分"
        Public Const スリッター区分 As String = "スリッター区分"
    End Class

    '''----------------------------------------------------------------------------------------
    ''' <summary>区分ｺｰﾄﾞ</summary>
    '''----------------------------------------------------------------------------------------
    Public Class CodeValue
        '''----------------------------------------------------------------------------------------
        ''' <summary>フラグ</summary>
        '''----------------------------------------------------------------------------------------
        Public Class フラグ
            Public Const オフ As String = "0"
            Public Const オン As String = "1"
        End Class

        '''----------------------------------------------------------------------------------------
        ''' <summary>機械種別区分</summary>
        '''----------------------------------------------------------------------------------------
        Public Class 機械種別区分
            Public Const 平圧機 As String = "0"
            Public Const 輪転機 As String = "1"
        End Class

        '''----------------------------------------------------------------------------------------
        ''' <summary>取引先区分</summary>
        '''----------------------------------------------------------------------------------------
        Public Class 取引先区分
            Public Const 得意先 As String = "0"
            Public Const 仕入先 As String = "1"
        End Class

        '''----------------------------------------------------------------------------------------
        ''' <summary>種別内訳区分</summary>
        '''----------------------------------------------------------------------------------------
        Public Class 種別内訳区分
            Public Const 内訳有り As String = "1"
            Public Const 内訳無し As String = "0"
        End Class

        '''----------------------------------------------------------------------------------------
        ''' <summary>重要度</summary>
        '''----------------------------------------------------------------------------------------
        Public Class 重要度
            Public Const Aランク As String = "1"
            Public Const Bランク As String = "2"
            Public Const Cランク As String = "3"
            Public Const Dランク As String = "4"
            Public Const ランクなし As String = "9"
        End Class

        '''----------------------------------------------------------------------------------------
        ''' <summary>受注区分</summary>
        '''----------------------------------------------------------------------------------------
        Public Class 受注区分
            Public Const ラベル As String = "0"
            Public Const オフセット As String = "1"
            Public Const フレキシブル As String = "2"
        End Class

        '''----------------------------------------------------------------------------------------
        ''' <summary>紙種別</summary>
        '''----------------------------------------------------------------------------------------
        Public Class 紙種別
            Public Const 紙 As String = "0"
            Public Const オーバーコート As String = "1"
            Public Const 箔 As String = "2"
            Public Const 紙その他 As String = "3"
        End Class

        '''----------------------------------------------------------------------------------------
        ''' <summary>社内外区分</summary>
        '''----------------------------------------------------------------------------------------
        Public Class 社内外区分
            Public Const 社内 As String = "0"
            Public Const 社外 As String = "1"
        End Class

        '''----------------------------------------------------------------------------------------
        ''' <summary>確約区分</summary>
        '''----------------------------------------------------------------------------------------
        Public Class 確約区分
            Public Const 通常 As String = "0"
            Public Const 確約 As String = "1"
        End Class

        '''----------------------------------------------------------------------------------------
        ''' <summary>刃型区分</summary>
        '''----------------------------------------------------------------------------------------
        Public Class 刃型区分
            Public Const 彫刻刃 As String = "0"
            Public Const エッチング刃 As String = "1"
        End Class

        '''----------------------------------------------------------------------------------------
        ''' <summary>フレキ機械種別区分</summary>
        '''----------------------------------------------------------------------------------------
        Public Class フレキ機械種別区分
            Public Const 輪転機 As String = "0"
            Public Const 半輪転機 As String = "1"
            Public Const その他 As String = "2"
        End Class

        '''----------------------------------------------------------------------------------------
        ''' <summary>刃型形状区分</summary>
        '''----------------------------------------------------------------------------------------
        Public Class 刃型形状区分
            Public Const 長方形 As String = "0"
            Public Const 楕円形 As String = "1"
            Public Const その他 As String = "2"
        End Class

        '''----------------------------------------------------------------------------------------
        ''' <summary>新再版区分</summary>
        '''----------------------------------------------------------------------------------------
        Public Class 新再版区分
            Public Const 新版 As String = "0"
            Public Const 再版 As String = "1"
        End Class

        '''----------------------------------------------------------------------------------------
        ''' <summary>単位区分</summary>
        '''----------------------------------------------------------------------------------------
        Public Class 単位区分
            Public Const 枚 As String = "0"
            Public Const シート As String = "1"
            Public Const 巻 As String = "2"
            Public Const 束 As String = "3"
        End Class

        '''----------------------------------------------------------------------------------------
        ''' <summary>単位区分</summary>
        '''----------------------------------------------------------------------------------------
        Public Class 仕入先指定区分
            Public Const 指定無 As String = "0"
            Public Const 指定有 As String = "1"
        End Class

        '''----------------------------------------------------------------------------------------
        ''' <summary>納入区分</summary>
        '''----------------------------------------------------------------------------------------
        Public Class 納入区分
            Public Const 本社 As String = "1"
            Public Const 河北工場 As String = "2"
            Public Const 不明 As String = "9"
        End Class

        '''----------------------------------------------------------------------------------------
        ''' <summary>支給区分</summary>
        '''----------------------------------------------------------------------------------------
        Public Class 支給区分
            Public Const 仕入 As String = "0"
            Public Const 無償 As String = "1"
            Public Const 有償 As String = "2"
        End Class

        '''----------------------------------------------------------------------------------------
        ''' <summary>希望時間帯区分</summary>
        '''----------------------------------------------------------------------------------------
        Public Class 希望時間帯区分
            Public Const AM As String = "0"
            Public Const PM As String = "1"
            Public Const チャーター便 As String = "2"
            Public Const なし As String = "9"
        End Class

        '''----------------------------------------------------------------------------------------
        ''' <summary>完納区分</summary>
        '''----------------------------------------------------------------------------------------
        Public Class 完納区分
            Public Const 未完納 As String = "0"
            Public Const 完納 As String = "1"
            Public Const 金額不一致_完納 As String = "2"
            Public Const 仮伝_未完納 As String = "3"
            Public Const 仮伝_完納 As String = "4"
        End Class

        '''----------------------------------------------------------------------------------------
        ''' <summary>売上指示区分</summary>
        '''----------------------------------------------------------------------------------------
        Public Class 売上指示区分
            Public Const 無し As String = "00"
            Public Const サービス As String = "01"
            Public Const 仕入1･2倍 As String = "02"
        End Class

        '''----------------------------------------------------------------------------------------
        ''' <summary>売上指示区分運賃</summary>
        '''----------------------------------------------------------------------------------------
        Public Class 売上指示区分運賃
            Public Const 無し As String = "00"
            Public Const サービス As String = "01"
            Public Const 実費請求 As String = "02"
        End Class

        '''----------------------------------------------------------------------------------------
        ''' <summary>巻取区分</summary>
        '''----------------------------------------------------------------------------------------
        Public Class 巻取区分
            Public Const 外 As String = "1"
            Public Const 内 As String = "2"
            Public Const 他 As String = "9"
        End Class

        '''----------------------------------------------------------------------------------------
        ''' <summary>出し方向区分</summary>
        '''----------------------------------------------------------------------------------------
        Public Class 出し方向区分
            Public Const A As String = "1"
            Public Const B As String = "2"
            Public Const C As String = "3"
            Public Const D As String = "4"
            Public Const 他 As String = "9"
        End Class

        '''----------------------------------------------------------------------------------------
        ''' <summary>スリッター区分</summary>
        '''----------------------------------------------------------------------------------------
        Public Class スリッター区分
            Public Const 要 As String = "1"
            Public Const 不要 As String = "2"
        End Class
    End Class

    '''----------------------------------------------------------------------------------------
    ''' <summary>ﾛｼﾞｯｸ</summary>
    '''----------------------------------------------------------------------------------------
    Public Class Logic
        '''----------------------------------------------------------------------------------------
        ''' <summary>共通</summary>
        '''----------------------------------------------------------------------------------------
        Public Class Common
            Public Class メンテ方法
                Public Const 登録 As String = "1"
                Public Const 修正 As String = "2"
                Public Const 削除 As String = "3"
            End Class
        End Class

        ' '''----------------------------------------------------------------------------------------
        ' ''' <summary>請求品目検索</summary>
        ' '''----------------------------------------------------------------------------------------
        'Public Class FinderBillItem
        '    Public Class 請求合計区分
        '        Public Const その他以外 As String = "1"
        '    End Class
        'End Class
    End Class
End Namespace
