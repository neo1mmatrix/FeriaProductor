Public Class Fr_PagoFactura
    Dim _MontoFactura As String
    Dim _RealizarPago As Boolean
    Public Sub New(ByVal p_monto_factura As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        If Not (String.IsNullOrEmpty(p_monto_factura)) Then
            txtTotalFacturado.Text = p_monto_factura
            txtPagaCon.Text = txtTotalFacturado.Text
            txtCambio.Text = "0,00"
            txtPagaCon.SelectAll()
        End If

    End Sub

    Private Sub Fr_PagoFactura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCambio.Parent = PictureBox1
        lblPagaCon.Parent = PictureBox1
        lblTotalFacturado.Parent = PictureBox1
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Fr_Crear_Facturas.RealizaPago(False, txtPagaCon.Text, txtCambio.Text)
        Me.Close()
    End Sub

    Private Sub btnPagar_Click(sender As Object, e As EventArgs) Handles btnPagar.Click

        Dim _Monto As Double = 0
        Try
            _Monto = CDbl(txtCambio.Text)
            If _Monto >= 0 Then
                Fr_Crear_Facturas.RealizaPago(True, txtPagaCon.Text, txtCambio.Text)
                Me.Close()
            Else
                MsgBox("El Pago no puede ser inferior al Monto de la Factura")
                txtPagaCon.Focus()
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub txtTotalFacturado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTotalFacturado.KeyPress

        e.Handled = True

    End Sub

    Private Sub txtCambio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtCambio.KeyPress

        e.Handled = True

    End Sub

    Private Sub txtPagaCon_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPagaCon.KeyUp

        Dim _TotalFactura As Double = 0
        Dim _PagaCon As Double = 0
        Dim _Vuelto As Double = 0

        Try
            If txtPagaCon.Text.Length > 0 Then
                _TotalFactura = CDbl(txtTotalFacturado.Text)
                _PagaCon = CDbl(txtPagaCon.Text)
                CalcularPago(_TotalFactura, _PagaCon, _Vuelto)
                txtCambio.Text = convertir_formato_miles_decimales(_Vuelto)
            Else
                txtCambio.Text = convertir_formato_miles_decimales(0)
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub CalcularPago(ByVal p_total As Double, ByVal p_paga As Double, ByRef p_vuelto As Double)
        Try
            p_vuelto = p_paga - p_total
            If p_vuelto > 0 Then
                txtCambio.ForeColor = Color.Blue
            ElseIf p_vuelto < 0 Then
                txtCambio.ForeColor = Color.Red
            Else
                txtCambio.ForeColor = Color.Black
            End If
        Catch ex As Exception

        End Try


    End Sub

    Private Sub Fr_PagoFactura_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        txtPagaCon.Focus()
        txtPagaCon.Select(0, txtPagaCon.Text.Length)
    End Sub

    Private Sub txtPagaCon_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPagaCon.KeyDown

        If e.KeyData = Keys.Enter Then

            If txtPagaCon.Text.Length > 0 Then
                btnPagar.Focus()
                txtPagaCon.Text = convertir_formato_miles_decimales(CDbl(txtPagaCon.Text))
            ElseIf txtPagaCon.Text = "" Then
                txtPagaCon.Text = convertir_formato_miles_decimales(CDbl(txtTotalFacturado.Text))
                btnPagar.Focus()
            End If

        End If
    End Sub

    Private Sub txtPagaCon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtPagaCon.KeyPress
        If e.KeyChar = "." And Not txtPagaCon.Text.Contains(",") Then
            e.Handled = True
            txtPagaCon.Text = txtPagaCon.Text & ","
            txtPagaCon.SelectionStart() = txtPagaCon.Text.Length
        End If
        NumerosyDecimal(txtPagaCon, e)
    End Sub

    Private Sub txtPagaCon_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles txtPagaCon.PreviewKeyDown
        If txtPagaCon.SelectionLength = txtPagaCon.Text.Length Then
            txtPagaCon.Clear()
        End If
    End Sub

    Private Sub txtPagaCon_Leave(sender As Object, e As EventArgs) Handles txtPagaCon.Leave

        If txtPagaCon.Text = "" Then
            txtPagaCon.Text = txtTotalFacturado.Text
        ElseIf (txtPagaCon.Text = "," Or txtPagaCon.Text = ".") Then
            txtPagaCon.Text = txtTotalFacturado.Text
        End If
        Dim _TotalFactura As Double = 0
        Dim _PagaCon As Double = 0
        Dim _Vuelto As Double = 0

        Try
            _TotalFactura = CDbl(txtTotalFacturado.Text)
            _PagaCon = CDbl(txtPagaCon.Text)
            CalcularPago(_TotalFactura, _PagaCon, _Vuelto)
            txtCambio.Text = convertir_formato_miles_decimales(_Vuelto)
            txtPagaCon.Text = convertir_formato_miles_decimales(CDbl(txtPagaCon.Text))
        Catch ex As Exception

        End Try
    End Sub
End Class