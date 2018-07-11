Imports Microsoft.VisualBasic

Public Class ActionButton
    '''========================================================================================
    '''  <summary>使用ﾎﾞﾀﾝ</summary>
    '''========================================================================================
    Public Enum UseContents
        None = 0
        Find = 1
        Clear = 2
        Calc = 4
        Save = 8
        Delete = 16
        Run = 32
        Undo = 64
        Print = 128
        Excel = 256
        CSV = 512
        DownLoad = 1024
        UpLoad = 2048
        Lock = 4096
        Refresh = 8192
    End Enum

    '''========================================================================================
    '''  <summary>使用ﾎﾞﾀﾝ名</summary>
    '''========================================================================================
    Public Class UseContentsName
        Public Const None As String = ""
        Public Const Find As String = "検索"
        Public Const Clear As String = "クリア"
        Public Const Calc As String = "計算"
        Public Const Save As String = "保存"
        Public Const Delete As String = "削除"
        Public Const Run As String = "実行"
        Public Const Undo As String = "戻す"
        Public Const Print As String = "印刷"
        Public Const Excel As String = "Excel"
        Public Const CSV As String = "CSV"
        Public Const DownLoad As String = "ダウンロード"
        Public Const UpLoad As String = "アップロード"
        Public Const Lock As String = "ロック"
        Public Const Refresh As String = "再表示"
    End Class

    '''========================================================================================
    '''  <summary>ｴﾗｰﾚﾍﾞﾙ</summary>
    '''========================================================================================
    Public Enum ErrorLevel
        None
        Warning
        Fatal
    End Enum
End Class
