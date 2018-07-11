Namespace Dialog
    Public Class Common
        '''========================================================================================
        ''' <summary>値がNullの時、第2ﾊﾟﾗﾒｰﾀを返します。</summary>
        ''' <param name="Page">ﾍﾟｰｼﾞｵﾌﾞｼﾞｪｸﾄ</param>
        '''========================================================================================
        Public Shared Sub Open(ByVal Page As System.Windows.Forms.Form, Optional ActiveControl As BaseUI.Control.TextBox = Nothing)
            '----------------------------------------------------------------------
            ' 変数定義
            '----------------------------------------------------------------------
            Dim strReturnValue As String = ""

            '----------------------------------------------------------------------
            ' ﾀｰｹﾞｯﾄのﾃｷｽﾄﾎﾞｯｸｽ 取得
            '----------------------------------------------------------------------
            If ActiveControl Is Nothing Then
                ActiveControl = Page.ActiveControl
            End If

            '----------------------------------------------------------------------
            ' ﾍﾙﾌﾟﾀｲﾌﾟが無ければｽｷｯﾌﾟ
            '----------------------------------------------------------------------
            If ActiveControl.HelpType = NodeUI.Help.Type.None Then
                Exit Sub
            End If

            '----------------------------------------------------------------------
            ' ｷｰ収集
            '----------------------------------------------------------------------
            Dim strKeyValue As String = ActiveControl.HelpGetValue(ActiveControl.HelpKeys)

            '----------------------------------------------------------------------
            ' ﾀﾞｲｱﾛｸﾞ 表示
            '----------------------------------------------------------------------
            Select Case ActiveControl.HelpType
                Case NodeUI.Help.Type.M糊 : strReturnValue = dlgPaste.ShowFrom(strKeyValue)
                Case NodeUI.Help.Type.M紙 : strReturnValue = dlgPaper.ShowFrom(strKeyValue)
                Case NodeUI.Help.Type.M得意先 : strReturnValue = dlgCustomer.ShowFrom(strKeyValue)
                Case NodeUI.Help.Type.M得意先個人 : strReturnValue = dlgCustomerOne.ShowFrom(strKeyValue)
                Case NodeUI.Help.Type.M出荷先 : strReturnValue = dlgDelivery.ShowFrom(strKeyValue)
                Case NodeUI.Help.Type.M機械 : strReturnValue = dlgMachine.ShowFrom(strKeyValue)
                Case NodeUI.Help.Type.M大分類 : strReturnValue = dlgType1.ShowFrom(strKeyValue)
                Case NodeUI.Help.Type.M小分類 : strReturnValue = dlgType2.ShowFrom(strKeyValue)
                Case NodeUI.Help.Type.M台紙 : strReturnValue = dlgMount.ShowFrom(strKeyValue)
                Case NodeUI.Help.Type.M担当者 : strReturnValue = dlgStaff.ShowFrom(strKeyValue)
                Case NodeUI.Help.Type.M印刷場所 : strReturnValue = dlgPrintLoc.ShowFrom(strKeyValue)
                Case NodeUI.Help.Type.M印刷機械種別 : strReturnValue = dlgPrintType.ShowFrom(strKeyValue)
                Case NodeUI.Help.Type.M締日情報 : strReturnValue = dlgBillDDInfo.ShowFrom(strKeyValue)
                Case NodeUI.Help.Type.M仕入先 : strReturnValue = dlgSupplier.ShowFrom(strKeyValue)
                Case NodeUI.Help.Type.M品名 : strReturnValue = dlgItemName.ShowFrom(strKeyValue)
                Case NodeUI.Help.Type.Mヤマト店所 : strReturnValue = dlgYamatoShop.ShowFrom(strKeyValue)
                Case NodeUI.Help.Type.Mヤマト区分 : strReturnValue = dlgYamatoType.ShowFrom(strKeyValue)
                Case NodeUI.Help.Type.Mヤマト種別 : strReturnValue = dlgYamatoKind.ShowFrom(strKeyValue)

                Case NodeUI.Help.Type.T受注基本 : strReturnValue = dlgJobNo.ShowFrom(strKeyValue)

                Case NodeUI.Help.Type.M取引先
                    If strKeyValue.Split(vbTab)(0) = NodeContents.Constant.CodeValue.取引先区分.得意先 Then
                        strReturnValue = dlgCustomer.ShowFrom(strKeyValue)
                    Else
                        strReturnValue = dlgSupplier.ShowFrom(strKeyValue)
                    End If
            End Select

            '----------------------------------------------------------------------
            ' 選択行の値を貼り付け
            '----------------------------------------------------------------------
            If strReturnValue = "" Then
                Exit Sub
            End If

            ActiveControl.HelpSetValue(ActiveControl.HelpKeys, strReturnValue)
            ActiveControl.Modified = True

            '----------------------------------------------------------------------
            ' 次項目へｶｰｿﾙ移動
            '----------------------------------------------------------------------
            ActiveControl.Focus()
            Page.SelectNextControl(ActiveControl, True, True, True, True)
        End Sub
    End Class
End Namespace
