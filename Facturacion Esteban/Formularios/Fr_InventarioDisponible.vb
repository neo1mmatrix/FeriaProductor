Imports System.Data.OleDb
Imports System.Text.RegularExpressions

Public Class Fr_InventarioDisponible
    Private Sub Fr_InventarioDisponible_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SEL_INVENTARIO(dgvDetalles)
    End Sub

    Private Sub Fr_InventarioDisponible_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        defineTamañoCeldaDataGrid(6, 2, dgvDetalles, 0)
    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click

        btnActualizar.Enabled = False
        Dim _ProductoId As Integer = 0
        Dim _ProductoNombre As String = Nothing
        Dim _CantidadDisponible As Double = 0
        Dim _CantidadIngresa As Double = 0
        Dim _CantidadDisminuye As Double = 0
        Dim _CantidadFinal As Double = 0

        For i As Integer = 0 To dgvDetalles.Rows.Count - 1
            _ProductoNombre = dgvDetalles.Rows(i).Cells(2).Value
            If _ProductoNombre <> "" Then
                _ProductoId = dgvDetalles.Rows(i).Cells(6).Value
                _CantidadDisponible = CDbl(dgvDetalles.Rows(i).Cells(3).Value)
                _CantidadIngresa = CDbl(dgvDetalles.Rows(i).Cells(4).Value)
                _CantidadDisminuye = CDbl(dgvDetalles.Rows(i).Cells(5).Value)
                If _CantidadIngresa > 0 Or _CantidadDisminuye > 0 Then
                    _CantidadFinal = _CantidadDisponible + _CantidadIngresa - _CantidadDisminuye
                    UPD_INVENTARIO(_ProductoId, _CantidadFinal)
                End If

            End If

        Next
        MsgBox("Registros Actualizados Correctamente")
        SEL_INVENTARIO(dgvDetalles)
        btnActualizar.Enabled = True


    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalles.CellEndEdit

        Try
            If dgvDetalles.CurrentCell.Value = "" Then
                dgvDetalles.CurrentCell.Value = convertir_formato_miles_decimales(0)
            Else
                dgvDetalles.CurrentCell.Value = convertir_formato_miles_decimales(dgvDetalles.CurrentCell.Value)
            End If
        Catch ex As Exception
            dgvDetalles.CurrentCell.Value = convertir_formato_miles_decimales(0)
        End Try

    End Sub

    Private Sub dgvDetalles_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dgvDetalles.EditingControlShowing
        ' Este evento se producirá cuando la celda pasa a modo de edición.

        ' Referenciamos el control DataGridViewTextBoxEditingControl actual.
        '
        cellTextBox = TryCast(e.Control, DataGridViewTextBoxEditingControl)

        ' Obtenemos el estilo de la celda actual
        '
        Dim style As DataGridViewCellStyle = e.CellStyle

        ' Mientras se edita la celda, aumentaremos la fuente
        ' y rellenaremos el color de fondo de la celda actual.
        '
        With style
            .Font = New Font(style.Font.FontFamily, 10, FontStyle.Bold)
            .ForeColor = Color.Blue
            .BackColor = Color.Beige
        End With
    End Sub

    Private Sub cellTextBox_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles cellTextBox.KeyPress

        ' Referenciamos el control TextBox subyacente.
        '
        Dim tb As TextBox = TryCast(sender, TextBox)

        ' Si la conversión ha fallado, abandonamos el procedimiento.
        '
        If (tb Is Nothing) Then
            e.Handled = True
            Return
        End If
        If dgvDetalles.IsCurrentCellInEditMode And (dgvDetalles.CurrentCell.ColumnIndex = C_cantidadIngresa.Index Or
                dgvDetalles.CurrentCell.ColumnIndex = C_disminuyeInventario.Index) Then

            Dim isDecimal, isSign, isValidChar As Boolean
            Dim decimalSeparator As String = Nothing

            Select Case e.KeyChar
                Case "."c, ","c
                    ' Obtenemos el carácter separador decimal existente
                    ' actualmente en la configuración regional de Windows. 
                    ' 
                    decimalSeparator = Threading.Thread.CurrentThread.CurrentCulture.NumberFormat.NumberDecimalSeparator

                    ' Hacemos que el carácter tecleado coincida con el
                    ' carácter separador existentente en la configuración
                    ' regional.
                    '
                    e.KeyChar = decimalSeparator.Chars(0)

                    ' Si el primer carácter que se teclea es el separador decimal,
                    ' o si bien, existe un signo en el primer carácter, envío la
                    ' combinación '0,'.
                    '
                    If (((tb.TextLength = 0) OrElse (tb.SelectionLength = tb.TextLength)) OrElse
                        ((tb.TextLength = 1) AndAlso ((tb.Text.Contains("-")) OrElse
                        (Text.Contains("+"))))) Then

                        ' NOTA: Envío la combinación "0," mediante el método Send,
                        ' para que en el código cliente se desencadenen los
                        ' eventos de teclado.
                        '
                        SendKeys.Send("{0}")
                        SendKeys.Send("{" & decimalSeparator & "}")
                        e.Handled = True
                        Return
                    End If

                    ' Es un carácter válido.
                    '
                    isDecimal = True
                    isValidChar = True

                Case "-"c, "+"c    ' Signos negativo y positivo
                    ' Es un carácter válido.
                    '
                    isSign = True
                    isValidChar = True

                Case Else
                    ' Sólo se admitirán números y la tecla de retroceso.
                    '
                    Dim isDigit As Boolean = Char.IsDigit(e.KeyChar)
                    Dim isControl As Boolean = Char.IsControl(e.KeyChar)

                    If ((isDigit) OrElse (isControl)) Then
                        isValidChar = True

                    Else
                        e.Handled = True
                        Return

                    End If

            End Select

            ' Si es un carácter válido, y el texto del control
            ' se encuentra totalmente seleccionado, elimino
            ' el valor actual del control.
            '
            If ((isValidChar) And (tb.SelectionLength = tb.TextLength)) Then
                tb.Text = String.Empty
            End If

            If (isSign) Then
                ' Admitimos los caracteres positivo y negativo, siempre y cuando
                ' sea el primer carácter del texto, y no exista ya ningún otro
                ' signo escrito en el control.
                '
                If ((tb.SelectionStart <> 0) OrElse
                    (tb.Text.IndexOf("-") >= 0) OrElse
                    (tb.Text.IndexOf("+") >= 0)) Then
                    e.Handled = True
                    Return
                End If
            End If

            If (isDecimal) Then
                ' Si en el control hay ya escrito un separador decimal, 
                ' deshechamos insertar otro separador más. 
                ' 
                If (tb.Text.IndexOf(decimalSeparator) >= 0) Then
                    e.Handled = True
                End If
            End If
            'NumerosyDecimal(tb, e)
        Else

        End If

    End Sub

    Private WithEvents cellTextBox As DataGridViewTextBoxEditingControl

    Private Sub cellTextBox_KeyDown(
        ByVal sender As Object,
        ByVal e As System.Windows.Forms.KeyEventArgs) Handles cellTextBox.KeyDown

    End Sub

    Private Sub cellTextBox_KeyUp(
        ByVal sender As Object,
        ByVal e As System.Windows.Forms.KeyEventArgs) Handles cellTextBox.KeyUp
    End Sub

    Private Sub DataGridView1_KeyDown(sender As Object, e As KeyEventArgs)
        If e.Control AndAlso e.KeyCode = Keys.V Then

            Try
                For Each line As String In Clipboard.GetText.Split(vbNewLine)
                    Dim item() As String = line.Trim.Split(vbTab)
                    If item.Length = Me.dgvDetalles.ColumnCount Then
                        Me.dgvDetalles.Rows.Add(item)
                    End If
                Next

            Catch ex As Exception
                MessageBox.Show(ex.Message, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    Private Sub txtBusqueda_KeyUp(sender As Object, e As KeyEventArgs) Handles txtBusqueda.KeyUp

        Dim busqueda As String = Nothing
        Try
            If txtBusqueda.Text.Length > 0 Then
                busqueda = Regex.Replace(txtBusqueda.Text.Trim, "\s{2,}", " ")
                busqueda = busqueda.Replace(" ", "%")
                SEL_INVENTARIO_FILTRO(busqueda, dgvDetalles)
            Else
                SEL_INVENTARIO(dgvDetalles)
            End If


        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class