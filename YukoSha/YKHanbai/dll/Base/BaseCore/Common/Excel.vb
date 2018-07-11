Namespace Common
    Public Class Excel
        Public Element() As String = {"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" _
                                     , "AA", "AB", "AC", "AD", "AE", "AF", "AG", "AH", "AI", "AJ", "AK", "AL", "AM", "AN", "AO", "AP", "AQ", "AR", "AS", "AT", "AU", "AV", "AW", "AX", "AY", "AZ" _
                                     , "BA", "BB", "BC", "BD", "BE", "BF", "BG", "BH", "BI", "BJ", "BK", "BL", "BM", "BN", "BO", "BP", "BQ", "BR", "BS", "BT", "BU", "BV", "BW", "BX", "BY", "BZ" _
                                     , "CA", "CB", "CC", "CD", "CE", "CF", "CG", "CH", "CI", "CJ", "CK", "CL", "CM", "CN", "CO", "CP", "CQ", "CR", "CS", "CT", "CU", "CV", "CW", "CX", "CY", "CZ" _
                                     , "DA", "DB", "DC", "DD", "DE", "DF", "DG", "DH", "DI", "DJ", "DK", "DL", "DM", "DN", "DO", "DP", "DQ", "DR", "DS", "DT", "DU", "DV", "DW", "DX", "DY", "DZ" _
                                     , "EA", "EB", "EC", "ED", "EE", "EF", "EG", "EH", "EI", "EJ", "EK", "EL", "EM", "EN", "EO", "EP", "EQ", "ER", "ES", "ET", "EU", "EV", "EW", "EX", "EY", "EZ" _
                                     , "FA", "FB", "FC", "FD", "FE", "FF", "FG", "FH", "FI", "FJ", "FK", "FL", "FM", "FN", "FO", "FP", "FQ", "FR", "FS", "FT", "FU", "FV", "FW", "FX", "FY", "FZ" _
                                     , "GA", "GB", "GC", "GD", "GE", "GF", "GG", "GH", "GI", "GJ", "GK", "GL", "GM", "GN", "GO", "GP", "GQ", "GR", "GS", "GT", "GU", "GV", "GW", "GX", "GY", "GZ" _
                                     , "HA", "HB", "HC", "HD", "HE", "HF", "HG", "HH", "HI", "HJ", "HK", "HL", "HM", "HN", "HO", "HP", "HQ", "HR", "HS", "HT", "HU", "HV", "HW", "HX", "HY", "HZ" _
                                     , "IA", "IB", "IC", "ID", "IE", "IF", "IG", "IH", "II", "IJ", "IK", "IL", "IM", "IN", "IO", "IP", "IQ", "IR", "IS", "IT", "IU", "IV" _
                                      }

#Region "�����è"
        '''========================================================================================
        ''' <summary>ܰ��ޯ�</summary>
        '''========================================================================================
        Private _Book As SpreadsheetGear.IWorkbook
        Public Property Book() As SpreadsheetGear.IWorkbook
            Get
                Return _Book
            End Get
            Set(ByVal value As SpreadsheetGear.IWorkbook)
                _Book = value
            End Set
        End Property

        '''========================================================================================
        ''' <summary>ܰ����</summary>
        '''========================================================================================
        Private _Sheet As SpreadsheetGear.IWorksheet
        Public Property Sheet() As SpreadsheetGear.IWorksheet
            Get
                Return _Sheet
            End Get
            Set(ByVal value As SpreadsheetGear.IWorksheet)
                _Sheet = value
            End Set
        End Property

        '''========================================================================================
        ''' <summary>�װү����</summary>
        '''========================================================================================
        Private _LastError As String
        Public ReadOnly Property LastError() As String
            Get
                Return _LastError
            End Get
        End Property

        '''========================================================================================
        ''' <summary>�񐔁��� �ϊ�</summary>
        '''========================================================================================
        Public ReadOnly Property ElementNumToName(ByVal Number As Integer) As String
            Get
                Return Me.Element(Number - 1) + ":" + Me.Element(Number - 1)
            End Get
        End Property
#End Region

#Region "Book"
#Region "̧�� �����"
        '''========================================================================================
        ''' <summary>̧�� �����</summary>
        ''' <param name="FilePath">�߽(�w��Ȃ��́A��̧�ق����)</param>
        ''' <returns>True:�����AFalse:���s</returns>
        '''========================================================================================
        Public Function Open(Optional ByVal FilePath As String = Nothing) As Boolean
            Try
                _Book = SpreadsheetGear.Factory.GetWorkbook(FilePath)
            Catch ex As Exception
                _LastError = ex.Message
                Return False
            End Try

            Return True
        End Function
#End Region

#Region "̧�� �۰��"
        '''========================================================================================
        ''' <summary>̧�� �۰��</summary>
        ''' <param name="SavePath">Exceļ�ٕۑ��߽</param>
        ''' <returns>True:�����AFalse:���s</returns>
        '''========================================================================================
        Public Function Close(Optional ByVal SavePath As String = "", Optional ByVal FileFormat As SpreadsheetGear.FileFormat = SpreadsheetGear.FileFormat.Excel8) As Boolean
            Try
                If SavePath = "" Then
                    _Book.Save()
                Else
                    _Book.SaveAs(SavePath, FileFormat)
                End If
            Catch ex As Exception
                _LastError = ex.Message
                Return False
            End Try

            Return True
        End Function
#End Region

#Region "̧�� �V�K"
        '''========================================================================================
        ''' <summary>̧�� �V�K</summary>
        ''' <returns>True:�����AFalse:���s</returns>
        '''========================================================================================
        Public Function Create() As Boolean
            Try
                _Book = SpreadsheetGear.Factory.GetWorkbook(New System.Globalization.CultureInfo(1041))
            Catch ex As Exception
                _LastError = ex.Message
                Return False
            End Try

            Return True
        End Function
#End Region
#End Region

#Region "Sheet"
#Region "��Ă̑I��"
        '''========================================================================================
        ''' <summary>��Ă̑I��</summary>
        ''' <param name="SheetName">�I�����鼰Ė�</param>
        ''' <returns>True:�����AFalse:���s</returns>
        '''========================================================================================
        Public Function SheetSelect(ByVal SheetName As String) As Boolean
            Try
                _Sheet = _Book.Sheets(SheetName)
            Catch ex As Exception
                _LastError = ex.Message
                Return False
            End Try

            Return True
        End Function

        '''========================================================================================
        ''' <summary>��Ă̑I��</summary>
        ''' <param name="SheetIndent">�I�����鼰Ĕԍ�</param>
        ''' <returns>True:�����AFalse:���s</returns>
        '''========================================================================================
        Public Function SheetSelect(ByVal SheetIndent As Integer) As Boolean
            Try
                _Sheet = _Book.Sheets(SheetIndent - 1)
            Catch ex As Exception
                _LastError = ex.Message
                Return False
            End Try

            Return True
        End Function
#End Region

#Region "��Ă̍폜"
        '''========================================================================================
        ''' <summary>��Ă̍폜</summary>
        ''' <param name="SheetName">�폜���鼰Ė�</param>
        ''' <returns>True:�����AFalse:���s</returns>
        '''========================================================================================
        Public Function SheetDelete(ByVal SheetName As String) As Boolean
            Try
                Me.SheetSelect(SheetName)
                _Sheet.Delete()
                _Sheet = Nothing
            Catch ex As Exception
                _LastError = ex.Message
                Return False
            End Try

            Return True
        End Function

        '''========================================================================================
        ''' <summary>��Ă̍폜</summary>
        ''' <param name="SheetIdent">�폜���鼰Ĕԍ�</param>
        ''' <returns>True:�����AFalse:���s</returns>
        '''========================================================================================
        Public Function SheetDelete(ByVal SheetIdent As Integer) As Boolean
            Try
                Me.SheetSelect(SheetIdent)
                _Sheet.Delete()
                _Sheet = Nothing
            Catch ex As Exception
                _LastError = ex.Message
                Return False
            End Try

            Return True
        End Function
#End Region

#Region "�V�[�g�ی�"
        '''========================================================================================
        ''' <summary>�V�[�g�ی�</summary>
        '''========================================================================================
        Public Sub Protect()
            _Sheet.Protect("sign")
        End Sub
#End Region

#Region "�V�[�g����"
        '''========================================================================================
        ''' <summary>�V�[�g����</summary>
        '''========================================================================================
        Public Sub Unprotect()
            _Sheet.Unprotect("sign")
        End Sub
#End Region

#Region "��Ă̺�߰"
        '''========================================================================================
        ''' <summary>��Ă̺�߰</summary>
        ''' <param name="SheetNameF">��߰����Ė�</param>
        ''' <param name="SheetNameT">��߰�漰Ė�</param>
        '''========================================================================================
        Public Sub SheetCopy(ByVal SheetNameF As String, ByVal SheetNameT As String)
            Dim SheetF As SpreadsheetGear.IWorksheet = _Book.Sheets(SheetNameF)
            Dim SheetT As SpreadsheetGear.IWorksheet = SheetF.CopyAfter(SheetF)

            SheetT.Name = SheetNameT
        End Sub
#End Region

#Region "�A�N�e�B�u�V�[�g�̍ŏI�s��Ԃ�"
        '''========================================================================================
        ''' <summary>�A�N�e�B�u�V�[�g�̍ŏI�s�ʒu��Ԃ�</summary>
        ''' <returns>�ŏI�s�ʒu</returns>
        '''========================================================================================
        Public Function LastRowIndex() As Integer
            Return _Sheet.UsedRange.RowCount
        End Function
#End Region

#Region "�A�N�e�B�u�V�[�g�̍ŏI���Ԃ�"
        '''========================================================================================
        ''' <summary>�A�N�e�B�u�V�[�g�̍ŏI��ʒu��Ԃ�</summary>
        ''' <returns>�ŏI��ʒu</returns>
        '''========================================================================================
        Public Function LastColIndex() As Integer
            Return _Sheet.UsedRange.ColumnCount
        End Function
#End Region
#End Region

#Region "Cell"
#Region "�w�肵���قɒl��ݒ肷��"
        '''========================================================================================
        ''' <summary>�w�肵���Z���ɒl��ݒ肷��</summary>
        ''' <param name="IndexRow">�s�ʒu(1����n�܂�)</param>
        ''' <param name="IndexCol">��ʒu(1����n�܂�)</param>
        ''' <param name="RangeValue">�ݒ肷��l</param>
        ''' <param name="FormatSting">�ُ���</param>
        '''========================================================================================
        Public Sub CellSetValue(ByVal IndexRow As Long, ByVal IndexCol As Long, ByVal RangeValue As Object, Optional FormatSting As String = "")
            If IndexRow < 1 Or IndexCol < 1 Then Return

            If FormatSting <> "" Then
                _Sheet.Cells(IndexRow - 1, IndexCol - 1).NumberFormat = FormatSting
            End If

            _Sheet.Cells(IndexRow - 1, IndexCol - 1).Value = RangeValue
        End Sub
#End Region

#Region "�w�肵���قɐ�����ݒ肷��"
        '''========================================================================================
        ''' <summary>�w�肵���Z���ɐ�����ݒ肷��</summary>
        ''' <param name="IndexRow">�s�ʒu(1����n�܂�)</param>
        ''' <param name="IndexCol">��ʒu(1����n�܂�)</param>
        ''' <param name="RangeValue">�ݒ肷��l</param>
        '''========================================================================================
        Public Sub CellSetFormula(ByVal IndexRow As Long, ByVal IndexCol As Long, ByVal RangeValue As Object)
            If IndexRow < 1 Or IndexCol < 1 Then Return

            _Sheet.Cells(IndexRow - 1, IndexCol - 1).Formula = RangeValue
        End Sub
#End Region

#Region "�w�肵���قɐF��t����"
        '''========================================================================================
        ''' <summary>�w�肵���ٔw�i�ɐF��t����</summary>
        ''' <param name="ColorValue">�ݒ肷��F</param>
        ''' <param name="IndexRow">�s�ʒu(1����n�܂�)</param>
        ''' <param name="IndexCol">��ʒu(1����n�܂�)</param>
        '''========================================================================================
        Public Sub CellSetColor(ByVal ColorValue As System.Drawing.Color _
                              , ByVal IndexRow As Long _
                              , ByVal IndexCol As Long _
                               )
            If IndexRow < 1 Or IndexCol < 1 Then Return

            _Sheet.Cells(IndexRow - 1, IndexCol - 1).Interior.Color = ColorValue
            Select Case True
                Case IndexRow = -1
                    _Sheet.Cells(-1, IndexCol - 1).Interior.Color = ColorValue
                Case IndexCol = -1
                    _Sheet.Cells(IndexRow - 1, -1).Interior.Color = ColorValue
                Case Else
            End Select
        End Sub

        '''========================================================================================
        ''' <summary>�w�肵���͈ٔ͂ɐF��t����</summary>
        ''' <param name="ColorValue">�ݒ肷��F</param>
        ''' <param name="IndexRowF">�s�ʒu:�n(1����n�܂�)</param>
        ''' <param name="IndexColF">��ʒu:�n(1����n�܂�)</param>
        ''' <param name="IndexRowT">�s�ʒu:�I(1����n�܂�)</param>
        ''' <param name="IndexColT">��ʒu:�I(1����n�܂�)</param>
        '''========================================================================================
        Public Sub CellSetColor(ByVal ColorValue As System.Drawing.Color _
                              , ByVal IndexRowF As Long _
                              , ByVal IndexColF As Long _
                              , ByVal IndexRowT As Long _
                              , ByVal IndexColT As Long _
                               )
            If IndexRowF < 1 Or IndexColF < 1 Or IndexColT < 1 Or IndexColT < 1 Then Return

            _Sheet.Cells(IndexRowF - 1, IndexColF - 1, IndexRowT - 1, IndexColT - 1).Interior.Color = ColorValue
        End Sub

        '''========================================================================================
        ''' <summary>�w�肵���s�ɐF��t����</summary>
        ''' <param name="ColorValue">�ݒ肷��F</param>
        ''' <param name="IndexRow">�s�ʒu(1����n�܂�)</param>
        '''========================================================================================
        Public Sub CellSetColorRow(ByVal ColorValue As System.Drawing.Color, ByVal IndexRow As Long)
            If IndexRow <= 1 Then Return

            Dim strRange As String = ""
            strRange = IndexRow.ToString & ":" & IndexRow.ToString
            _Sheet.Cells(strRange).Interior.Color = ColorValue
        End Sub

        '''========================================================================================
        ''' <summary>�w�肵����ɐF��t����</summary>
        ''' <param name="ColorValue">�ݒ肷��F</param>
        ''' <param name="IndexCol">��ʒu(1����n�܂�)</param>
        '''========================================================================================
        Public Sub CellSetColorCol(ByVal ColorValue As System.Drawing.Color, ByVal IndexCol As Long)
            If IndexCol < 1 Then Return

            Dim strRange As String = ""
            strRange = Element(IndexCol - 1) & ":" & Element(IndexCol - 1)
            _Sheet.Cells(strRange).Interior.Color = ColorValue
        End Sub
#End Region

#Region "�w�肵���قɺ��Ă��擾����"
        '''========================================================================================
        ''' <summary>�w�肵���Z���̺��Ă��擾����</summary>
        ''' <param name="IndexRow">�s�ʒu(1����n�܂�)</param>
        ''' <param name="IndexCol">��ʒu(1����n�܂�)</param>
        '''========================================================================================
        Public Function CellGetComment(ByVal IndexRow As Long, ByVal IndexCol As Long) As String
            If IndexRow < 1 Or IndexCol < 1 Then Return ""

            Return _Sheet.Cells(IndexRow - 1, IndexCol - 1).Comment.Shape.TextFrame.Characters.Text
        End Function
#End Region

#Region "�w�肵���قɺ��Ă�ݒ肷��"
        '''========================================================================================
        ''' <summary>�w�肵���Z���ɺ��Ă�ݒ肷��</summary>
        ''' <param name="IndexRow">�s�ʒu(1����n�܂�)</param>
        ''' <param name="IndexCol">��ʒu(1����n�܂�)</param>
        ''' <param name="Value">�ݒ肷��l</param>
        '''========================================================================================
        Public Sub CellSetComment(ByVal IndexRow As Long, ByVal IndexCol As Long, ByVal Value As String)
            If IndexRow < 1 Or IndexCol < 1 Then Return

            _Sheet.Cells(IndexRow - 1, IndexCol - 1).AddComment(Value)
            _Sheet.Cells(IndexRow - 1, IndexCol - 1).Comment.Shape.Width = 250
            _Sheet.Cells(IndexRow - 1, IndexCol - 1).Comment.Shape.Height = 100
        End Sub
#End Region

#Region "�w�肵���قɺ��Ă�ر����"
        '''========================================================================================
        ''' <summary>�w�肵���Z���ɺ��Ă�ر����</summary>
        ''' <param name="IndexRow">�s�ʒu(1����n�܂�)</param>
        ''' <param name="IndexCol">��ʒu(1����n�܂�)</param>
        '''========================================================================================
        Public Sub CellClearComment(ByVal IndexRow As Long, ByVal IndexCol As Long)
            If IndexRow < 1 Or IndexCol < 1 Then Return

            _Sheet.Cells(IndexRow - 1, IndexCol - 1).ClearComments()
        End Sub
#End Region

#Region "�w�肵���Z���ɐ�������"
        '''========================================================================================
        ''' <summary>�w�肵���Z���ɐ�������</summary>
        ''' <param name="IndexRow">�s�ʒu(1����n�܂�)</param>
        ''' <param name="IndexCol">��ʒu(1����n�܂�)</param>
        '''========================================================================================
        Public Sub CellSetLine(ByVal IndexRow As Long, ByVal IndexCol As Long)
            If IndexRow < 1 Or IndexCol < 1 Then Return

            Dim range As SpreadsheetGear.IRange = _Sheet.Cells(IndexRow - 1, IndexCol - 1)
            Dim borders As SpreadsheetGear.IBorders = range.Borders

            borders.LineStyle = SpreadsheetGear.LineStyle.Continuous
            borders.Weight = SpreadsheetGear.BorderWeight.Thin
        End Sub

        '''========================================================================================
        ''' <summary>�w�肵���Z���ɐ�������</summary>
        ''' <param name="IndexRowF">�s�ʒu:�n(1����n�܂�)</param>
        ''' <param name="IndexColF">��ʒu:�n(1����n�܂�)</param>
        ''' <param name="IndexRowT">�s�ʒu:�I(1����n�܂�)</param>
        ''' <param name="IndexColT">��ʒu:�I(1����n�܂�)</param>
        '''========================================================================================
        Public Sub CellSetLine(ByVal IndexRowF As Long _
                              , ByVal IndexColF As Long _
                              , ByVal IndexRowT As Long _
                              , ByVal IndexColT As Long _
                               )

            If IndexRowF < 1 Or IndexColF < 1 Or IndexColT < 1 Or IndexColT < 1 Then Return

            Dim range As SpreadsheetGear.IRange = _Sheet.Cells(IndexRowF - 1, IndexColF - 1, IndexRowT - 1, IndexColT - 1)
            Dim borders As SpreadsheetGear.IBorders = range.Borders

            borders.LineStyle = SpreadsheetGear.LineStyle.Continuous
            borders.Weight = SpreadsheetGear.BorderWeight.Thin
        End Sub
#End Region

#Region "�w�肵���Z���̒l��Ԃ�(�P�̃Z��)"
        '''========================================================================================
        ''' <summary>�w�肵���Z���̒l��Ԃ�(�P�̃Z��)</summary>
        ''' <param name="IndexRow">�s�ʒu</param>
        ''' <param name="IndexCol">��ʒu</param>
        ''' <returns>�Z���I�u�W�F�N�g</returns>
        '''========================================================================================
        Public Function CellGet(ByVal IndexRow As Long, ByVal IndexCol As Long) As SpreadsheetGear.IRange
            If IndexRow < 1 Or IndexCol < 1 Then Return Nothing

            Return Sheet.Cells(IndexRow - 1, IndexCol - 1)
        End Function
#End Region

#Region "�w�肵���Z���̒l��Ԃ�(�����̃Z��)"
        '''========================================================================================
        ''' <summary>�w�肵���Z���̒l��Ԃ�(�����̃Z��)</summary>
        ''' <param name="StartIndexRow">�s�ʒu�i�J�n�j</param>
        ''' <param name="StartIndexCol">��ʒu�i�J�n�j</param>
        ''' <returns>�Z���I�u�W�F�N�g</returns>
        '''========================================================================================
        Public Function CellGet(ByVal StartIndexRow As Integer, ByVal StartIndexCol As Integer, ByVal EndIndexRow As Integer, ByVal EndIndexCol As Integer) As SpreadsheetGear.IRange
            If StartIndexRow < 1 Or StartIndexCol < 1 Or EndIndexRow < 1 Or EndIndexCol < 1 Then Return Nothing

            Return _Sheet.Range(StartIndexRow - 1, StartIndexCol - 1, EndIndexRow - 1, EndIndexCol - 1)
        End Function
#End Region

#Region "�w�肵���Z���̐F��Ԃ�(�P�̃Z��)"
        '''========================================================================================
        ''' <summary>�w�肵���Z���̐F��Ԃ�(�P�̃Z��)</summary>
        ''' <param name="IndexRow">�s�ʒu</param>
        ''' <param name="IndexCol">��ʒu</param>
        ''' <returns>�Z���I�u�W�F�N�g</returns>
        '''========================================================================================
        Public Function CellGetColor(ByVal IndexRow As Long, ByVal IndexCol As Long) As SpreadsheetGear.Drawing.Color
            If IndexRow < 1 Or IndexCol < 1 Then Return Nothing

            Return Sheet.Cells(IndexRow - 1, IndexCol - 1).Interior.Color
        End Function
#End Region

#Region "�w�肵���Z���̐F��Ԃ�(�����̃Z��)"
        '''========================================================================================
        ''' <summary>�w�肵���Z���̒l��Ԃ�(�����̃Z��)</summary>
        ''' <param name="StartIndexRow">�s�ʒu�i�J�n�j</param>
        ''' <param name="StartIndexCol">��ʒu�i�J�n�j</param>
        ''' <returns>�Z���I�u�W�F�N�g</returns>
        '''========================================================================================
        Public Function CellGetColor(ByVal StartIndexRow As Integer, ByVal StartIndexCol As Integer, ByVal EndIndexRow As Integer, ByVal EndIndexCol As Integer) As SpreadsheetGear.Drawing.Color
            If StartIndexRow < 1 Or StartIndexCol < 1 Or EndIndexRow < 1 Or EndIndexCol < 1 Then Return Nothing

            Return _Sheet.Range(StartIndexRow - 1, StartIndexCol - 1, EndIndexRow - 1, EndIndexCol - 1).Interior.Color
        End Function
#End Region

#Region "�͈ٔ͂��߰���đ��̏ꏊ�ɓ\��t����"
        '''========================================================================================
        ''' <summary>�w�肵���Z���ɒl��ݒ肷��</summary>
        '''========================================================================================
        Public Sub CopyAndPaste(ByVal CopySheetName As String _
                              , Optional ByVal CopyIndexRowF As Long = -1 _
                              , Optional ByVal CopyIndexColF As Long = -1 _
                              , Optional ByVal CopyIndexRowT As Long = -1 _
                              , Optional ByVal CopyIndexColT As Long = -1 _
                              , Optional ByVal PasteSheetName As String = "" _
                              , Optional ByVal PasteIndexRow As Long = -1 _
                              , Optional ByVal PasteIndexCol As Long = -1 _
                               )
            Dim CopySheet As SpreadsheetGear.IWorksheet = _Book.Sheets(CopySheetName)
            Dim PasteSheet As SpreadsheetGear.IWorksheet = _Book.Sheets(PasteSheetName)

            '------------------------------------------------------------------
            ' ���Ұ� �m�F
            '------------------------------------------------------------------
            Select Case True
                Case CopySheet Is Nothing
                    Exit Sub                    '���I��

                Case PasteSheet Is Nothing
                    PasteSheet = CopySheet      '���I��
            End Select

            '------------------------------------------------------------------
            ' �͈͐ݒ�
            '------------------------------------------------------------------
            Dim CopyRange As String = ""
            Dim PasteRange As String = ""

            '------------------------------------
            ' ��߰��(xx:xx)
            '------------------------------------
            CopyRange = ""
            If CopyIndexColF <> -1 Then CopyRange &= Element(CopyIndexColF)
            If CopyIndexRowF <> -1 Then CopyRange &= CopyIndexRowF

            CopyRange &= ":"

            If CopyIndexColT = -1 Then
                If CopyIndexColF <> -1 Then CopyRange &= Element(CopyIndexColF)
            Else
                CopyRange &= Element(CopyIndexColT)
            End If

            If CopyIndexRowT = -1 Then
                If CopyIndexRowF <> -1 Then CopyRange &= CopyIndexRowF
            Else
                CopyRange &= CopyIndexRowT
            End If

            '------------------------------------
            ' ��߰��(yy)
            '------------------------------------
            PasteRange = ""
            If PasteIndexCol <> -1 Then PasteRange &= Element(PasteIndexCol)
            If PasteIndexRow <> -1 Then PasteRange &= PasteIndexRow
            PasteRange &= ":"
            If PasteIndexCol <> -1 Then PasteRange &= Element(PasteIndexCol)
            If PasteIndexRow <> -1 Then PasteRange &= PasteIndexRow

            '------------------------------------
            ' �\��t��
            '------------------------------------
            CopySheet.Cells(CopyRange).Copy(PasteSheet.Cells(PasteRange))
        End Sub
#End Region

#Region "�װ���"
        '''========================================================================================
        ''' <summary>�װ����</summary>
        ''' <param name="IndexRow">�s�ʒu(1����n�܂�)</param>
        ''' <param name="IndexCol">��ʒu(1����n�܂�)</param>
        ''' <param name="Comment">�ݒ肷��l</param>
        '''========================================================================================
        Public Sub CellSetError(ByVal IndexRow As Long _
                              , ByVal IndexCol As Long _
                              , ByVal Comment As String _
                               )
            CellSetComment(IndexRow, IndexCol, Comment)
            CellSetColor(Drawing.Color.LightPink, IndexRow, IndexCol)
        End Sub

        '''========================================================================================
        ''' <summary>�װ����</summary>
        ''' <param name="IndexRow">�s�ʒu(1����n�܂�)</param>
        ''' <param name="IndexCol">��ʒu(1����n�܂�)</param>
        '''========================================================================================
        Public Sub CellClearError(ByVal IndexRow As Long _
                                , ByVal IndexCol As Long _
                                 )
            CellClearComment(IndexRow, IndexCol)
            CellSetColor(Drawing.Color.Transparent, IndexRow, IndexCol)
        End Sub
#End Region
#End Region

#Region "Utility"
        '''----------------------------------------------------------------------------------------
        ''' <summary>�ް�ð��ْ����ް�ð��ق����ׂ�Excel�ɒ���t����</summary>
        ''' <param name="datTable">�ް�ð���</param>
        ''' <remarks>
        ''' �sColumns.Caption�̓��e�t
        ''' 1��і�:���ق̗�
        ''' 2��і�:���ق̑O�ʐF
        ''' 3��і�:���l���ڎ��̏����_�ȉ��̌���
        ''' </remarks>
        ''' <returns>True:�����AFalse:���s</returns>
        '''----------------------------------------------------------------------------------------
        Public Function ExcelExport(ByVal datTable As System.Data.DataTable, ByVal FilePath As String, Optional ByVal FileFormat As SpreadsheetGear.FileFormat = SpreadsheetGear.FileFormat.Excel8) As Boolean
            Try
                ' �V�K���[�N�u�b�N�ƃ��[�N�V�[�g���쐬����
                Dim Book As SpreadsheetGear.IWorkbook = SpreadsheetGear.Factory.GetWorkbook(New System.Globalization.CultureInfo(1041))
                Dim Sheet As SpreadsheetGear.IWorksheet = Book.Worksheets("Sheet1")
                Sheet.Name = datTable.TableName

                ' �����ݒ�
                For i As Integer = 0 To datTable.Columns.Count - 1
                    ' ��߼�ݎ擾
                    Dim arrCaption As String() = datTable.Columns(i).Caption.Split(vbTab)

                    ' �����ݒ�
                    Select Case datTable.Columns(i).DataType.Name
                        Case GetType(String).Name
                            Sheet.Cells(Me.Element(i) & ":" & Me.Element(i)).NumberFormat = "@"     '�����񏑎�
                        Case Else
                            If arrCaption.Length = 1 Then
                                Sheet.Cells(Me.Element(i) & ":" & Me.Element(i)).NumberFormat = "#,###" '��������
                            Else
                                If BaseCore.Common.Text.CVal(arrCaption(2)) = 0 Then
                                    Sheet.Cells(Me.Element(i) & ":" & Me.Element(i)).NumberFormat = "#,###" '��������
                                Else
                                    Sheet.Cells(Me.Element(i) & ":" & Me.Element(i)).NumberFormat = "#,###." & StrDup(CInt(BaseCore.Common.Text.CVal(arrCaption(2))), "0") & ";" & "-#,###." & StrDup(CInt(BaseCore.Common.Text.CVal(arrCaption(2))), "0") & ";" & "#" '��������
                                End If
                            End If
                    End Select

                    ' ���ٕ����ύX
                    If arrCaption(0) <> "" Then
                        datTable.Columns(i).ColumnName = arrCaption(0)
                    End If

                    ' ���ٍs�𒅐F(�w�i�F)
                    Sheet.Cells(Me.Element(i) & "1" & ":" & Me.Element(i) & "1").Interior.Color = Drawing.Color.LightGray

                    ' ���ٍs�𒅐F(�O�ʐF)
                    If arrCaption.Length = 1 Then
                        Sheet.Cells(Me.Element(i) & "1" & ":" & Me.Element(i) & "1").Font.Color = Drawing.Color.Black
                    Else
                        Select Case arrCaption(1)
                            Case BaseCore.Common.DataTable.ColumnRefresh.enmTitleStyle.Required
                                Sheet.Cells(Me.Element(i) & "1" & ":" & Me.Element(i) & "1").Font.Color = Drawing.Color.Red
                            Case BaseCore.Common.DataTable.ColumnRefresh.enmTitleStyle.View
                                Sheet.Cells(Me.Element(i) & "1" & ":" & Me.Element(i) & "1").Font.Color = Drawing.Color.MediumBlue
                            Case Else
                                Sheet.Cells(Me.Element(i) & "1" & ":" & Me.Element(i) & "1").Font.Color = Drawing.Color.Black
                        End Select
                    End If
                Next

                ' DataTable �̍��擪�̃Z�����擾����
                Dim range As SpreadsheetGear.IRange = Sheet.Cells("A1")

                ' DataTable �����[�N�V�[�g�͈͂ɃR�s�[����
                range.CopyFromDataTable(datTable, SpreadsheetGear.Data.SetDataFlags.None)

                ' �f�[�^���܂񂾂��ׂẴ��[�N�V�[�g���̗����������
                Sheet.UsedRange.Columns.AutoFit()

                ' �擪�s�ų���޳�g�Œ�
                Sheet.WindowInfo.ScrollColumn = 0
                Sheet.WindowInfo.SplitColumns = 0

                Sheet.WindowInfo.ScrollRow = 0
                Sheet.WindowInfo.SplitRows = 1

                Sheet.WindowInfo.FreezePanes = True

                ' �۰��
                Book.SaveAs(FilePath, FileFormat)

            Catch ex As Exception
                _LastError = ex.Message
                Return False
            End Try

            Return True
        End Function

        '''----------------------------------------------------------------------------------------
        ''' <summary>�ް���Ē����ް�ð��ق����ׂ�Excel�ɒ���t����</summary>
        ''' <param name="datSet">�ް����</param>
        ''' <remarks>
        ''' �sColumns.Caption�̓��e�t
        ''' 1��і�:���ق̗�
        ''' 2��і�:���ق̑O�ʐF
        ''' 3��і�:���l���ڎ��̏����_�ȉ��̌���
        ''' </remarks>
        ''' <returns>True:�����AFalse:���s</returns>
        '''----------------------------------------------------------------------------------------
        Public Function ExcelExport(ByVal datSet As System.Data.DataSet, ByVal FilePath As String, Optional ByVal FileFormat As SpreadsheetGear.FileFormat = SpreadsheetGear.FileFormat.Excel8) As Boolean
            Try
                ' �V�K�ޯ����쐬����
                Dim Book As SpreadsheetGear.IWorkbook = SpreadsheetGear.Factory.GetWorkbook(New System.Globalization.CultureInfo(1041))
                Dim Sheet As SpreadsheetGear.IWorksheet

                For Each datTable As System.Data.DataTable In datSet.Tables
                    ' ��Ă�ǉ�
                    Sheet = Book.Worksheets.Add
                    Sheet.Name = datTable.TableName

                    ' �����ݒ�
                    For i As Integer = 0 To datTable.Columns.Count - 1
                        ' ��߼�ݎ擾
                        Dim arrCaption As String() = datTable.Columns(i).Caption.Split(vbTab)

                        ' �����ݒ�
                        Select Case datTable.Columns(i).DataType.Name
                            Case GetType(String).Name
                                Sheet.Cells(Me.Element(i) & ":" & Me.Element(i)).NumberFormat = "@"     '�����񏑎�
                            Case Else
                                If BaseCore.Common.Text.CVal(arrCaption(2)) = 0 Then
                                    Sheet.Cells(Me.Element(i) & ":" & Me.Element(i)).NumberFormat = "#,###" '��������
                                Else
                                    Sheet.Cells(Me.Element(i) & ":" & Me.Element(i)).NumberFormat = "#,###." & StrDup(CInt(BaseCore.Common.Text.CVal(arrCaption(2))), "0") & ";" & "-#,###." & StrDup(CInt(BaseCore.Common.Text.CVal(arrCaption(2))), "0") & ";" & "#" '��������
                                End If
                        End Select

                        ' ���ٕ����ύX
                        If arrCaption(0) <> "" Then
                            datTable.Columns(i).ColumnName = arrCaption(0)
                        End If

                        ' ���ٍs�𒅐F(�w�i�F)
                        Sheet.Cells(Me.Element(i) & "1" & ":" & Me.Element(i) & "1").Interior.Color = Drawing.Color.LightGray

                        ' ���ٍs�𒅐F(�O�ʐF)
                        Select Case arrCaption(1)
                            Case BaseCore.Common.DataTable.ColumnRefresh.enmTitleStyle.Required
                                Sheet.Cells(Me.Element(i) & "1" & ":" & Me.Element(i) & "1").Font.Color = Drawing.Color.Red
                            Case BaseCore.Common.DataTable.ColumnRefresh.enmTitleStyle.View
                                Sheet.Cells(Me.Element(i) & "1" & ":" & Me.Element(i) & "1").Font.Color = Drawing.Color.MediumBlue
                            Case Else
                                Sheet.Cells(Me.Element(i) & "1" & ":" & Me.Element(i) & "1").Font.Color = Drawing.Color.Black
                        End Select
                    Next

                    ' DataTable �̍��擪�̃Z�����擾����
                    Dim range As SpreadsheetGear.IRange = Sheet.Cells("A1")

                    ' DataTable �����[�N�V�[�g�͈͂ɃR�s�[����
                    range.CopyFromDataTable(datTable, SpreadsheetGear.Data.SetDataFlags.None)

                    ' �f�[�^���܂񂾂��ׂẴ��[�N�V�[�g���̗����������
                    Sheet.UsedRange.Columns.AutoFit()

                    ' �擪�s�ų���޳�g�Œ�
                    Sheet.WindowInfo.ScrollColumn = 0
                    Sheet.WindowInfo.SplitColumns = 0

                    Sheet.WindowInfo.ScrollRow = 0
                    Sheet.WindowInfo.SplitRows = 1

                    Sheet.WindowInfo.FreezePanes = True
                Next

                ' Sheet1 �폜
                Book.Sheets("Sheet1").Delete()

                ' �ޯ��ۑ�
                Book.SaveAs(FilePath, FileFormat)

            Catch ex As Exception
                _LastError = ex.Message
                Return False
            End Try

            Return True
        End Function
#End Region
    End Class
End Namespace

