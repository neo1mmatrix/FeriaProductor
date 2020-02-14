Public Class Fr_Clientes

    'Public tel As String
    'LIMPIA LOS CAMPOS DEL FORMULARIO

    Private Sub limpiar()

        Txt_Cod_Nombre.Clear()
        Txt_Nombre.Clear()
        Txt_Telefono.Clear()
        For i As Integer = 0 To 2
            DGV_Direcion.Rows(i).Cells(0).Value = ""
        Next
        Txt_Cod_Nombre.Focus()
        Txt_Advertencia.Text = "ADVERTENCIA"
        Chb_Tipo_Impresora.Checked = False

    End Sub

    'SE CARGAN LOS CAMPOS DE INICIO DEL FORMULARIO
    Private Sub inicio()

        For i As Integer = 0 To 2
            DGV_Direcion.Rows.Add()
        Next
        SEL_CLIENTE_TODOS(LvClientes)
        SEL_VENDEDORES(Cb_Vendedor, Lv_Vendedor)
        Cb_Vendedor.SelectedItem = "CAJA"

    End Sub
    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        inicio()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Agregar.Click

        If (Txt_Cod_Nombre.Text = "") Then
            MsgBox("INGRESE UN CODIGO DE CLIENTE")
        ElseIf (Txt_Nombre.Text = "") Then
            MsgBox("INGRESE EL NOMBRE DEL CLIENTE")
        Else
            If Txt_Advertencia.Text = "ADVERTENCIA" Then
                Txt_Advertencia.Text = ""
            End If
            Txt_Nombre.Text = Txt_Nombre.Text.Replace("'", "`")
            INS_CLIENTE(Txt_Cod_Nombre.Text, Txt_Nombre.Text, DGV_Direcion.Rows(0).Cells(0).Value,
                   DGV_Direcion.Rows(1).Cells(0).Value, DGV_Direcion.Rows(2).Cells(0).Value,
                   Txt_Telefono.Text, Txt_Advertencia.Text, Chb_Tipo_Impresora.Checked,
                        CInt(Lv_Vendedor.Items.Item(Cb_Vendedor.SelectedIndex).SubItems(0).Text), txtEmail.Text.Trim)
            If Fr_Crear_Facturas.Visible Then
                Fr_Crear_Facturas.Txt_Codigo_Cliente.Text = Txt_Cod_Nombre.Text
                SEL_CLIENTE_FACT(Txt_Cod_Nombre.Text, vp_cli_id, Fr_Crear_Facturas.DGV_Comentarios, vp_advertencia, vp_telefono,
                                 vp_ticket_matriz, vp_vendedor_auto, Fr_Crear_Facturas.clienteEmail)
                Fr_Crear_Facturas.Txt_Codigo_Cliente.Focus()
                Me.Close()
            ElseIf Fr_Crea_Cotizacion.Visible Then
                Fr_Crea_Cotizacion.Txt_Codigo_Cliente.Text = Txt_Cod_Nombre.Text
                SEL_CLIENTE_FACT(Txt_Cod_Nombre.Text, vp_cli_id, Fr_Crea_Cotizacion.DGV_Comentarios, vp_advertencia, vp_telefono, vp_ticket_matriz, vp_vendedor_auto, "")
                Fr_Crea_Cotizacion.Txt_Codigo_Articulo.Focus()
                Me.Close()
            Else
                limpiar()
            End If

        End If


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click

        Me.Close()

    End Sub

    Private Sub txtCodNombre_Leave(sender As Object, e As EventArgs) Handles Txt_Cod_Nombre.Leave

        If Txt_Nombre.Text <> "" And Txt_Cod_Nombre.Text <> "" Then
            MsgBox("El cliente ya existe")
            Txt_Cod_Nombre.Clear()
            Txt_Cod_Nombre.Focus()
        End If

    End Sub

    Private Sub txtCodNombre_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Cod_Nombre.KeyUp

        Txt_Nombre.Clear()
        SEL_CLIENTE(Txt_Cod_Nombre.Text, Txt_Nombre.Text)

    End Sub

    Private Sub txtBusquedaNombre_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Busqueda_Id.KeyUp

        LvClientes.Items.Clear()
        SEL_CLIENTE_IDF(Txt_Busqueda_Id.Text, LvClientes)

    End Sub

    Private Sub txtBusquedaNom_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Busqueda_Nombre.KeyUp

        LvClientes.Items.Clear()
        SEL_CLIENTE_NOMF(Txt_Busqueda_Nombre.Text, LvClientes)

    End Sub

    Private Sub txtNombre_KeyUp(sender As Object, e As KeyEventArgs) Handles Txt_Nombre.KeyUp

        If Txt_Nombre.Text.Length > 3 Then
            LvClientes.Items.Clear()
            SEL_CLIENTE_NOMF(Txt_Nombre.Text, LvClientes)
        ElseIf Txt_Nombre.Text.Length = 0 Then
            LvClientes.Items.Clear()
            SEL_CLIENTE_TODOS(LvClientes)
        End If

    End Sub

    Private Sub LvClientes_DoubleClick(sender As Object, e As EventArgs) Handles LvClientes.DoubleClick

        btnSeleccionar_Click(sender, New System.EventArgs())

    End Sub

    Private Sub btnSeleccionar_Click(sender As Object, e As EventArgs) Handles Btn_Seleccionar.Click

        Try
            If Fr_Crear_Facturas.Visible = True Then
                Fr_Crear_Facturas.Txt_Codigo_Cliente.Text = LvClientes.FocusedItem.Text
                SEL_CLIENTE_FACT(LvClientes.FocusedItem.Text, vp_cli_id, Fr_Crear_Facturas.DGV_Comentarios, vp_advertencia,
                                 vp_telefono, vp_ticket_matriz, vp_vendedor_auto, txtEmail.Text)
                Fr_Crear_Facturas.Txt_Codigo_Articulo.Focus()
                Me.Close()
            End If
        Catch ex As Exception
            If ex.ToString.Contains("NullReference") Then
                MsgBox("SELECCIONE UN CLIENTE", MsgBoxStyle.Information, "CUIDADO")
            Else
                MsgBox(ex.ToString)
                Logger.e("Error con excepción", ex, New StackFrame(True))
            End If
        End Try

    End Sub

    Private Sub txt_advertencia_Enter(sender As Object, e As EventArgs) Handles Txt_Advertencia.Enter

        If Txt_Advertencia.Text = "ADVERTENCIA" Then
            Txt_Advertencia.Clear()
        End If

    End Sub

    Private Sub txt_advertencia_Leave(sender As Object, e As EventArgs) Handles Txt_Advertencia.Leave

        If Txt_Advertencia.Text = "" Then
            Txt_Advertencia.Text = "ADVERTENCIA"
        End If

    End Sub

End Class