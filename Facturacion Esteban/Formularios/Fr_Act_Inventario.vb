Public Class Fr_Act_Inventario

    Dim barcode_antiguo As String = ""

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Btn_Salir.Click

        Fr_Detalle_Articulos.Show()
        Me.Close()

    End Sub

    Private Sub txtPrecio1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Precio1.KeyPress

        NumerosyDecimal(Txt_Precio1, e)

    End Sub

    Private Sub txtPrecio2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Precio2.KeyPress

        NumerosyDecimal(Txt_Precio2, e)

    End Sub

    Private Sub txtPrecio3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Precio3.KeyPress

        NumerosyDecimal(Txt_Precio3, e)

    End Sub

    Private Sub txtPrecio4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txt_Precio4.KeyPress

        NumerosyDecimal(Txt_Precio4, e)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Btn_Actualizar.Click

        Try

            If Txt_Descripcion.Text <> "" And Txt_Precio1.Text <> "" And Txt_Precio2.Text <> "" And Txt_Precio3.Text <> "" And Txt_Precio4.Text <> "" Then
                UPD_ART(Txt_Codigo.Text, Txt_Descripcion.Text, CDbl(Txt_Precio1.Text), CDbl(Txt_Precio2.Text), CDbl(Txt_Precio3.Text),
                            CDbl(Txt_Precio4.Text), Txt_Tipo.Text, False, 0, txt_barcode.Text.Trim)
                MsgBox("ACTUALIZADO CORRECTAMENTE", MsgBoxStyle.Information, "ACTUALIZACION")
                Fr_Detalle_Articulos.Show()
                Me.Close()
            End If

        Catch ex As Exception
            Logger.e("Error con excepción", ex, New StackFrame(True))
            ex.ToString()
        End Try

    End Sub

    Private Sub txt_barcode_TextChanged(sender As Object, e As EventArgs) Handles txt_barcode.TextChanged



    End Sub

    Private Sub txt_barcode_Leave(sender As Object, e As EventArgs) Handles txt_barcode.Leave
        Dim disponible As Boolean = True

        If (txt_barcode.Text.Trim <> "") And (barcode_antiguo <> txt_barcode.Text) Then
            SEL_BARCODE(txt_barcode.Text.Trim, disponible)
        End If

        If Not disponible Then
            txt_barcode.Clear()
            MsgBox("El barcode ya esta en uso", MsgBoxStyle.Information)
            txt_barcode.Text = barcode_antiguo
            txt_barcode.Select()
            txt_barcode.SelectionStart = 0
            txt_barcode.SelectionLength = txt_barcode.Text.Length
        ElseIf txt_barcode.Text.Trim = "" Then
            txt_barcode.Text = barcode_antiguo
        ElseIf txt_barcode.Text = "NULO" Then
            txt_barcode.Text = ""
        End If

    End Sub

    Private Sub Fr_Act_Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Txt_Precio4_Leave(sender As Object, e As EventArgs) Handles Txt_Precio4.Leave
        Btn_Actualizar.Select()
    End Sub

    Private Sub Fr_Act_Inventario_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        barcode_antiguo = txt_barcode.Text

    End Sub
End Class