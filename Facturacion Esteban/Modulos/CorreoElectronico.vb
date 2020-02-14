Imports System.Globalization
Imports System.Net.Mail

Module CorreoElectronico

    'Variables para usar en el boton de enviar correo
    Dim smtp As New SmtpClient 'protocolo de transferencia

    Public Sub EnviarCorreo(ByVal contrasena As String, ByVal correoEnvia As String,
                            ByVal asunto As String, ByVal correoDestino As String, ByVal tablaDetalles As DataGridView,
                            ByVal clienteNombre As String, ByVal facturaNumero As String, ByVal fechaFactura As String,
                            ByVal totalFactura As String, ByVal p_descuento As Double, ByVal p_impuesto As Double,
                            ByVal p_leyenda As String, ByVal linea2 As Array, ByVal p_empresa As String,
                            ByVal p_subtotal As Double)

        Dim message As New MailMessage
        Dim contrasenna As String = desencriptar(correoEnvia, contrasena)
        Dim correo As String = correoEnvia
        Dim archivo As Attachment = Nothing
        Dim leyenda As String = "Autorizaci&oacute;n mediante Resoluci&oacute;n No. DGT-R-48-2016 del 07/10/2016 de la DGTD"
        Dim codigo, cantidad, producto As String
        Dim precioUnitario, subtotal, total As Double
        Dim descuento, impuesto, subtotalFactura, impuestoArticulo As Double
        descuento = p_descuento
        impuesto = p_impuesto
        subtotalFactura = p_subtotal - impuesto
        correo = "esteban26mora@gmail.com"
        total = totalFactura
        Try

            'Codigo para enviar mensaje
            message.From = New MailAddress(correoEnvia)
            message.To.Add(correoDestino)

            'Encabezado del correo 
            message.Subject = asunto

            'Configuracion del  smtp
            smtp.EnableSsl = True
            smtp.Port = 587
            smtp.UseDefaultCredentials = False
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network
            smtp.Credentials = New Net.NetworkCredential(correo, contrasenna)

            'Establece el gestor de correos de salida
            If correo.Contains("hotmail") Then
                smtp.Host = "smtp.live.com" 'hotmail
            ElseIf correo.Contains("gmail") Then
                smtp.Host = "smtp.gmail.com" 'gmail
            End If

            Dim vBody As String = ""
            vBody &= "<H1><font color=""blue""><CENTER>" & p_empresa & "</CENTER></font></H1>"
            vBody &= "<p><font color=""black"">"

            For Each Value In linea2
                If Value <> "" Then
                    vBody &= "<center>" & Value & "</center>"
                End If
            Next

            vBody &= "</font></p>"
            vBody &= "<BR>"

            vBody &= "<p>Cliente: " & clienteNombre
            vBody &= "<br>Factura Nro:" & facturaNumero
            vBody &= "<br>Fecha: " & fechaFactura & " </p>"

            vBody &= "<TABLE style=""width:100%"", border=""1"">"
            vBody &= "<TBODY>"
            vBody &= "<TR>"
            vBody &= "<TH BGCOLOR=""#73f6fd""> CODIGO </TH>"
            vBody &= "<TH BGCOLOR=""#73f6fd""> PRODUCTO </TH>"
            vBody &= "<TH BGCOLOR=""#73f6fd""> CANTIDAD </TH>"
            vBody &= "<TH BGCOLOR=""#73f6fd""> PRECIO U.</TH>"
            vBody &= "<TH BGCOLOR=""#73f6fd""> IMP.</TH>"
            vBody &= "<TH BGCOLOR=""#73f6fd""> SUBTOTAL </TH>"
            vBody &= "</TR>"

            For i = 0 To tablaDetalles.Rows.Count - 1

                codigo = tablaDetalles.Item(0, i).Value.ToString
                producto = tablaDetalles.Item(1, i).Value.ToString
                cantidad = tablaDetalles.Item(2, i).Value.ToString
                precioUnitario = tablaDetalles.Item(3, i).Value.ToString
                subtotal = tablaDetalles.Item(5, i).Value
                impuestoArticulo = tablaDetalles.Item(4, i).Value

                vBody &= "<TR><TD width=""10%"">"
                vBody &= codigo & "</TD>"
                vBody &= "<TD width=""50%"">"
                vBody &= producto & "</TD>"
                vBody &= "<TD style='text-align:right;vertical-align:middle', width=""10%"">"
                vBody &= cantidad & " </TD>"
                vBody &= "<TD style='text-align:right;vertical-align:middle', width=""10%""> "
                vBody &= precioUnitario.ToString("N", CultureInfo.InvariantCulture) & "</TD>"
                vBody &= "<TD style='text-align:right;vertical-align:middle', width=""5%""> "
                vBody &= impuestoArticulo.ToString("N", CultureInfo.InvariantCulture) & "</TD>"
                vBody &= "<TD style='text-align:right;vertical-align:middle', width=""15%""> "
                vBody &= subtotal.ToString("N", CultureInfo.InvariantCulture) & "</TD>"
                vBody &= "</TR>"

            Next
            vBody &= "</TBODY>"
            vBody &= "</TABLE>"
            vBody &= "<BR>"

            'Montos de la factura, Descuentos e impuestos
            If descuento > 0 Or impuesto > 0 Then vBody &= "<strong><font size=""2"">Subtotal: " & subtotalFactura.ToString("N", CultureInfo.InvariantCulture) & "</font></strong><BR>"
            If impuesto > 0 Then vBody &= "Impuesto: " & impuesto.ToString("N", CultureInfo.InvariantCulture) & "<BR>"
            If descuento > 0 Then vBody &= "Descuento: " & descuento.ToString("N", CultureInfo.InvariantCulture) & "<BR>"

            vBody &= "<p><strong><font size=""5"">Total: " & total.ToString("N", CultureInfo.InvariantCulture) & "</font></strong></p>"

            'Pie de Pagina
            vBody &= "<p>" & leyenda & "</p>"

            message.Body = vBody

            'Configuracion del mensaje
            message.SubjectEncoding = System.Text.Encoding.UTF8
            message.Priority = System.Net.Mail.MailPriority.Normal
            message.IsBodyHtml = True


            'Enviamos el mensaje 
            smtp.Send(message)

            MessageBox.Show("Mensaje enviado Exitosamente")
        Catch ex As Exception
            If ex.ToString.Contains("Authentication Required") Then
                MsgBox("Es necesario que actives la opcion de Permitir el acceso de aplicaciones menos seguras en google, en el siguiente enlace " & "https://myaccount.google.com/lesssecureapps")
            ElseIf ex.ToString.Contains("user not authenticated") Then
                MsgBox("Problemas de Autentificacion, Revise que el correo y la contraseña sean correctos")
            Else
                MessageBox.Show("Fallo en el envio de mensaje " & ex.ToString)
            End If

        End Try

    End Sub

    'ENCRIPTA LOS DATOS
    Public Function encriptar(ByVal contra As String, ByVal texto As String)

        Try
            Dim contenedor As New Simple3Des(contra)
            Dim texto_cifrado As String = contenedor.EncryptData(texto)
            Return texto_cifrado
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return Nothing
        End Try

    End Function

    'DESENCRIPTA LOS DATOS
    Public Function desencriptar(ByVal contra As String, ByVal texto As String)

        Try
            Dim contenedor As New Simple3Des(contra)
            Dim texto_sin_encriptar As String = contenedor.DecryptData(texto)
            Return texto_sin_encriptar
        Catch ex As Exception
            MsgBox(ex.ToString)
            Return Nothing
        End Try

    End Function

End Module
