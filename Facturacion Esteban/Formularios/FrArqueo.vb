Public Class FrArqueo

    Dim _MontoTotal As Double = 0
    Dim _MonedasCinco As Integer = 0
    Dim _MonedasDiez As Integer = 0
    Dim _MonedasVeinticinco As Integer = 0
    Dim _MonedasCincuenta As Integer = 0
    Dim _MonedasCien As Integer = 0
    Dim _MonedasQuinientos As Integer = 0
    Dim _BilletesMil As Integer = 0
    Dim _BilletesDosMil As Integer = 0
    Dim _BilletesCincoMil As Integer = 0
    Dim _BilletesDiezMil As Integer = 0
    Dim _BilletesVeinteMil As Integer = 0
    Dim _BilletesCincuentaMil As Integer = 0
    Dim _MontoTarjeta As Double = 0
    Dim _TipoImpresaTermica As Boolean = False
    Dim _Venta As String = "0"
    Dim _MontosDinero(12) As Integer
    Dim _FechaInicio As String = ""


    Private Sub Fr_Arqueo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        _TipoImpresaTermica = False
        SEL_IMPRESORAS(PrinterNameTermica, PrinterNameMatriz, _TipoImpresaTermica)

    End Sub



    Private Sub CalculaMontoFinal(ByVal _CampoNumerico As NumericUpDown)

        Try
            _MonedasCinco = num5.Value * 5
            _MonedasDiez = num10.Value * 10
            _MonedasVeinticinco = num25.Value * 25
            _MonedasCincuenta = num50.Value * 50
            _MonedasCien = num100.Value * 100
            _MonedasQuinientos = num500.Value * 500
            _BilletesMil = num1Mil.Value * 1 * 1000
            _BilletesDosMil = num2Mil.Value * 2 * 1000
            _BilletesCincoMil = num5Mil.Value * 5 * 1000
            _BilletesDiezMil = num10Mil.Value * 10 * 1000
            _BilletesVeinteMil = num20Mil.Value * 20 * 1000
            _BilletesCincuentaMil = num50Mil.Value * 50 * 1000
            _MontoTarjeta = nudMontoTarjeta.Value

            _MontosDinero(0) = num5.Value
            _MontosDinero(1) = num10.Value
            _MontosDinero(2) = num25.Value
            _MontosDinero(3) = num50.Value
            _MontosDinero(4) = num100.Value
            _MontosDinero(5) = num500.Value
            _MontosDinero(6) = num1Mil.Value
            _MontosDinero(7) = num2Mil.Value
            _MontosDinero(8) = num5Mil.Value
            _MontosDinero(9) = num10Mil.Value
            _MontosDinero(10) = num20Mil.Value
            _MontosDinero(11) = num50Mil.Value

            Dim _TotalMonedas As Integer = (_MonedasCinco + _MonedasDiez + _MonedasVeinticinco + _MonedasCincuenta + _MonedasCien + _MonedasQuinientos)
            Dim _TotalBilletes As Integer = (_BilletesMil + _BilletesDosMil + _BilletesCincoMil + _BilletesDiezMil + _BilletesVeinteMil + _BilletesCincuentaMil)
            _MontoTotal = _TotalMonedas + _TotalBilletes + _MontoTarjeta

            lbMontoFinal.Text = "Monto ₡" + convertir_formato_miles_decimales(_MontoTotal)
        Catch ex As Exception
            MsgBox("Monto demasiado alto")
            _CampoNumerico.Text = 0
            _CampoNumerico.Value = 0
            _CampoNumerico.Focus()
            _CampoNumerico.Select(0, _CampoNumerico.Text.Length)

        End Try
    End Sub

    Private Sub num5_ValueChanged(sender As Object, e As EventArgs) Handles num5.ValueChanged

        CalculaMontoFinal(num5)

    End Sub

    Private Sub num10_ValueChanged(sender As Object, e As EventArgs) Handles num10.ValueChanged

        CalculaMontoFinal(num10)

    End Sub

    Private Sub num25_ValueChanged(sender As Object, e As EventArgs) Handles num25.ValueChanged

        CalculaMontoFinal(num25)

    End Sub

    Private Sub num50_ValueChanged(sender As Object, e As EventArgs) Handles num50.ValueChanged

        CalculaMontoFinal(num50)

    End Sub

    Private Sub num100_ValueChanged(sender As Object, e As EventArgs) Handles num100.ValueChanged

        CalculaMontoFinal(num100)

    End Sub

    Private Sub num500_ValueChanged(sender As Object, e As EventArgs) Handles num500.ValueChanged
        CalculaMontoFinal(num500)
    End Sub

    Private Sub num1000_ValueChanged(sender As Object, e As EventArgs) Handles num1Mil.ValueChanged
        CalculaMontoFinal(num1Mil)
    End Sub

    Private Sub num2000_ValueChanged(sender As Object, e As EventArgs) Handles num2Mil.ValueChanged
        CalculaMontoFinal(num2Mil)
    End Sub

    Private Sub num5000_ValueChanged(sender As Object, e As EventArgs) Handles num5Mil.ValueChanged
        CalculaMontoFinal(num5Mil)
    End Sub

    Private Sub num10000_ValueChanged(sender As Object, e As EventArgs) Handles num10Mil.ValueChanged
        CalculaMontoFinal(num10Mil)
    End Sub

    Private Sub num20000_ValueChanged(sender As Object, e As EventArgs) Handles num20Mil.ValueChanged
        CalculaMontoFinal(num20Mil)
    End Sub

    Private Sub num50000_ValueChanged(sender As Object, e As EventArgs) Handles num50Mil.ValueChanged
        CalculaMontoFinal(num50Mil)
    End Sub

    Private Sub num5_Leave(sender As Object, e As EventArgs) Handles num5.Leave
        num5.Text = num5.Value.ToString
    End Sub

    Private Sub num10_Leave(sender As Object, e As EventArgs) Handles num10.Leave
        num10.Text = num10.Value.ToString
    End Sub

    Private Sub num25_Leave(sender As Object, e As EventArgs) Handles num25.Leave
        num25.Text = num25.Value.ToString
    End Sub

    Private Sub num50_Leave(sender As Object, e As EventArgs) Handles num50.Leave
        num50.Text = num50.Value.ToString
    End Sub

    Private Sub num100_Leave(sender As Object, e As EventArgs) Handles num100.Leave
        num100.Text = num100.Value.ToString
    End Sub

    Private Sub num500_Leave(sender As Object, e As EventArgs) Handles num500.Leave
        num500.Text = num500.Value.ToString
    End Sub

    Private Sub num1000_Leave(sender As Object, e As EventArgs) Handles num1Mil.Leave
        num1Mil.Text = num1Mil.Value.ToString
    End Sub

    Private Sub num2000_Leave(sender As Object, e As EventArgs) Handles num2Mil.Leave
        num2Mil.Text = num2Mil.Value.ToString
    End Sub

    Private Sub num5000_Leave(sender As Object, e As EventArgs) Handles num5Mil.Leave
        num5Mil.Text = num5Mil.Value.ToString
    End Sub

    Private Sub num10000_Leave(sender As Object, e As EventArgs) Handles num10Mil.Leave
        num10Mil.Text = num10Mil.Value.ToString
    End Sub

    Private Sub num20000_Leave(sender As Object, e As EventArgs) Handles num20Mil.Leave
        num20Mil.Text = num20Mil.Value.ToString
    End Sub

    Private Sub num50000_Leave(sender As Object, e As EventArgs) Handles num50Mil.Leave
        num50Mil.Text = num50Mil.Value.ToString
    End Sub

    Private Sub num5_Enter(sender As Object, e As EventArgs) Handles num5.Enter
        num5.Select(0, num5.Text.Length)
    End Sub

    Private Sub num10_Enter(sender As Object, e As EventArgs) Handles num10.Enter
        num10.Select(0, num10.Text.Length)
    End Sub

    Private Sub num25_Enter(sender As Object, e As EventArgs) Handles num25.Enter
        num25.Select(0, num25.Text.Length)
    End Sub

    Private Sub num50_Enter(sender As Object, e As EventArgs) Handles num50.Enter
        num50.Select(0, num50.Text.Length)
    End Sub

    Private Sub num100_Enter(sender As Object, e As EventArgs) Handles num100.Enter
        num100.Select(0, num100.Text.Length)
    End Sub

    Private Sub num500_Enter(sender As Object, e As EventArgs) Handles num500.Enter
        num500.Select(0, num500.Text.Length)
    End Sub

    Private Sub num1000_Enter(sender As Object, e As EventArgs) Handles num1Mil.Enter
        num1Mil.Select(0, num1Mil.Text.Length)
    End Sub

    Private Sub num2000_Enter(sender As Object, e As EventArgs) Handles num2Mil.Enter
        num2Mil.Select(0, num2Mil.Text.Length)
    End Sub

    Private Sub num5000_Enter(sender As Object, e As EventArgs) Handles num5Mil.Enter
        num5Mil.Select(0, num5Mil.Text.Length)
    End Sub

    Private Sub num10000_Enter(sender As Object, e As EventArgs) Handles num10Mil.Enter
        num10Mil.Select(0, num10Mil.Text.Length)
    End Sub

    Private Sub num20000_Enter(sender As Object, e As EventArgs) Handles num20Mil.Enter
        num20Mil.Select(0, num20Mil.Text.Length)
    End Sub

    Private Sub num50000_Enter(sender As Object, e As EventArgs) Handles num50Mil.Enter
        num50Mil.Select(0, num50Mil.Text.Length)
    End Sub

    Private Sub nudMontoTarjeta_Enter(sender As Object, e As EventArgs) Handles nudMontoTarjeta.Enter
        nudMontoTarjeta.Select(0, nudMontoTarjeta.Text.Length)
    End Sub

    Private Sub nudMontoTarjeta_Leave(sender As Object, e As EventArgs) Handles nudMontoTarjeta.Leave
        nudMontoTarjeta.Text = nudMontoTarjeta.Value.ToString
    End Sub

    Private Sub nudMontoTarjeta_ValueChanged(sender As Object, e As EventArgs) Handles nudMontoTarjeta.ValueChanged
        CalculaMontoFinal(nudMontoTarjeta)
    End Sub

    Private Sub btnCerrarCaja_Click(sender As Object, e As EventArgs) Handles btnCerrarCaja.Click

        If _MontoTotal > 0 Then
            ImprimirCierreCaja()
            LimpiarCampos()
        End If

    End Sub

    Private Sub ImprimirCierreCaja()


        If _TipoImpresaTermica Then
            StartPrint()
            If prn.PrinterIsOpen = True Then
                PrintCierreCaja(_MontosDinero, convertir_formato_miles_decimales(_MontoTotal))
                EndPrint()
            End If
        Else
            StartPrintMatriz()
            If prn_matriz.PrinterIsOpen = True Then
                PrintCierreCajaMatriz(_MontosDinero, convertir_formato_miles_decimales(_MontoTotal))
                EndPrintMatriz()
            End If
        End If

    End Sub

    Private Sub LimpiarCampos()

        nudMontoTarjeta.Value = 0
        num5.Value = 0
        num10.Value = 0
        num25.Value = 0
        num50.Value = 0
        num100.Value = 0
        num500.Value = 0
        num1Mil.Value = 0
        num2Mil.Value = 0
        num5Mil.Value = 0
        num10Mil.Value = 0
        num20Mil.Value = 0
        num50Mil.Value = 0
        _MontoTotal = 0

    End Sub

    Private Sub FrArqueo_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.WindowState = FormWindowState.Normal
    End Sub
End Class