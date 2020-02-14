﻿Public Class Fr_Config

    'CARGA LAS VARIABLES DE INICIO
    Private Sub inicio()
        Dim filas As Integer = 0
        'Consulta todas las configuraciones guardades
        SEL_CONGIFURACION(Txt_Nombre_Empresa.Text, Txt_Numero_Factura.Text, txtImpresoraMatriz.Text, Chb_Thermal.Checked, Chb_precios_anteriores.Checked,
                          Txt_Linea1.Text, Txt_Linea2.Text, Txt_Linea3.Text, Txt_Linea4.Text, Txt_Linea5.Text, Txt_Linea6.Text,
                          Txt_Leyenda.Text, Txt_Cotizacion.Text, filas, txtCorreo.Text, txtContrasena1.Text, chbBarcode.Checked, txtImpresoraTermica.Text)
        If filas = 0 Then
            INS_CONFIG("Mi Empresa")
            Txt_Numero_Factura.Text = "0"
            Txt_Cotizacion.Text = "0"
            Txt_Nombre_Empresa.Text = "Mi Empresa"
        End If
        txtContrasena2.Text = txtContrasena1.Text
    End Sub

    'GUARDA LA CONFIGURACION
    Private Sub guardar_config()

        Dim respuesta As String = Nothing
        Dim contrasena = encriptar(txtCorreo.Text, txtContrasena1.Text)
        UPD_CONFIGURACION(Txt_Nombre_Empresa.Text, Txt_Numero_Factura.Text, txtImpresoraMatriz.Text, Chb_Thermal.Checked, Chb_precios_anteriores.Checked,
                          Txt_Linea1.Text, Txt_Linea2.Text, Txt_Linea3.Text, Txt_Linea4.Text, Txt_Linea5.Text, Txt_Linea6.Text,
                          Txt_Leyenda.Text, Txt_Cotizacion.Text, respuesta, txtCorreo.Text, txtImpresoraTermica.Text, contrasena, chbBarcode.Checked)
        If respuesta = "Datos Guardados Correctamente" Then
            MsgBox("Cambios Guardados", MsgBoxStyle.Information)
            Fr_Inicio.Show()
            Me.Close()
        Else
            MsgBox(respuesta)
        End If


    End Sub

    Private Sub Config_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        inicio()

    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click

        Fr_Inicio.Show()
        Me.Close()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click

        If txtContrasena1.Text <> "" Or txtContrasena2.Text <> "" Then
            If txtContrasena1.Text <> txtContrasena2.Text Then
                txtContrasena1.Focus()
                MsgBox("Las contraseñas no coinciden...")
            Else
                guardar_config()
            End If
        Else
            guardar_config()
        End If

    End Sub

    Private Sub txtNumeroFactura_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Numero_Factura.KeyPress

        NumerosyDecimal(Txt_Numero_Factura, e)

    End Sub

    Private Sub txt_cotizacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Cotizacion.KeyPress

        NumerosyDecimal(Txt_Cotizacion, e)

    End Sub

    Private Sub txtContrasena2_Leave(sender As Object, e As EventArgs) Handles txtContrasena2.Leave


    End Sub
End Class