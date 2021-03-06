Namespace Control
    Public Class Tool
        '''========================================================================================
        ''' <summary>ｺﾝﾄﾛｰﾙの型を求める</summary>
        ''' <param name="Control">ｺﾝﾄﾛｰﾙｵﾌﾞｼﾞｪｸﾄ</param>
        ''' <returns>ｺﾝﾄﾛｰﾙﾀｲﾌﾟ</returns>
        '''========================================================================================
        Public Shared Function ControlType(ByVal Control As System.Windows.Forms.Control) As BaseContents.Field.ControlType
            Select Case Control.GetType.Name
                Case "Button" : Return BaseContents.Field.ControlType.Button
                Case "CheckBox" : Return BaseContents.Field.ControlType.CheckBox
                Case "ComboBox" : Return BaseContents.Field.ControlType.ComboBox
                Case "GridInput" : Return BaseContents.Field.ControlType.GridInput
                Case "GridView" : Return BaseContents.Field.ControlType.GridView
                Case "GroupBox" : Return BaseContents.Field.ControlType.GroupBox
                Case "Label" : Return BaseContents.Field.ControlType.Label
                Case "ListBox" : Return BaseContents.Field.ControlType.ListBox
                Case "NameBox" : Return BaseContents.Field.ControlType.NameBox
                Case "PictureBox" : Return BaseContents.Field.ControlType.PictureBox
                Case "ProgressBar" : Return BaseContents.Field.ControlType.ProgressBar
                Case "RadioButton" : Return BaseContents.Field.ControlType.RadioButton
                Case "TextBox" : Return BaseContents.Field.ControlType.TextBox
                Case Else
                    If Control.GetType.BaseType.Namespace = "System" Then
                        Return BaseContents.Field.ControlType.Field
                    End If
            End Select

            Return BaseContents.Field.ControlType.None
        End Function

        '''========================================================================================
        ''' <summary>ｺﾝﾄﾛｰﾙの値を取得</summary>
        ''' <param name="Control">ｺﾝﾄﾛｰﾙｵﾌﾞｼﾞｪｸﾄ</param>
        ''' <returns>値</returns>
        '''========================================================================================
        Public Shared Function GetValue(ByVal Control As System.Windows.Forms.Control) As String
            Dim strValue As String = ""

            Select Case BaseUI.Control.Tool.ControlType(Control)
                Case BaseContents.Field.ControlType.CheckBox
                    If CType(Control, BaseUI.Control.CheckBox).Checked Then
                        strValue = "1"
                    Else
                        strValue = "0"
                    End If

                Case BaseContents.Field.ControlType.ComboBox
                    strValue = CType(Control, BaseUI.Control.ComboBox).SelectedValue

                Case BaseContents.Field.ControlType.Label
                    strValue = CType(Control, BaseUI.Control.Label).Text

                Case BaseContents.Field.ControlType.ListBox
                    strValue = CType(Control, BaseUI.Control.ListBox).SelectedValue

                Case BaseContents.Field.ControlType.NameBox
                    strValue = CType(Control, BaseUI.Control.NameBox).Text

                Case BaseContents.Field.ControlType.RadioButton
                    If CType(Control, BaseUI.Control.RadioButton).Checked Then
                        strValue = "1"
                    Else
                        strValue = "0"
                    End If

                Case BaseContents.Field.ControlType.TextBox
                    strValue = CType(Control, BaseUI.Control.TextBox).Text

            End Select

            Return strValue
        End Function

        '''========================================================================================
        ''' <summary>ｺﾝﾄﾛｰﾙに値を設定</summary>
        ''' <param name="Control">ｺﾝﾄﾛｰﾙｵﾌﾞｼﾞｪｸﾄ</param>
        ''' <param name="Value">設定する値</param>
        '''========================================================================================
        Public Shared Sub SetValue(ByVal Control As System.Windows.Forms.Control, Value As String)
            Select Case BaseUI.Control.Tool.ControlType(Control)
                Case BaseContents.Field.ControlType.CheckBox
                    If Value = "1" Then
                        CType(Control, BaseUI.Control.CheckBox).Checked = True
                    Else
                        CType(Control, BaseUI.Control.CheckBox).Checked = False
                    End If

                Case BaseContents.Field.ControlType.ComboBox
                    CType(Control, BaseUI.Control.ComboBox).SelectedValue = Value

                Case BaseContents.Field.ControlType.Label
                    CType(Control, BaseUI.Control.Label).Text = Value

                Case BaseContents.Field.ControlType.ListBox
                    CType(Control, BaseUI.Control.ListBox).SelectedValue = Value

                Case BaseContents.Field.ControlType.NameBox
                    CType(Control, BaseUI.Control.NameBox).Text = Value

                Case BaseContents.Field.ControlType.RadioButton
                    If Value = "1" Then
                        CType(Control, BaseUI.Control.RadioButton).Checked = True
                    Else
                        CType(Control, BaseUI.Control.RadioButton).Checked = False
                    End If

                Case BaseContents.Field.ControlType.TextBox
                    CType(Control, BaseUI.Control.TextBox).Text = Value

            End Select
        End Sub
    End Class
End Namespace
