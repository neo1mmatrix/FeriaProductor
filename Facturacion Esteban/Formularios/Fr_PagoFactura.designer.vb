<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Fr_PagoFactura
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.txtTotalFacturado = New System.Windows.Forms.TextBox()
        Me.txtPagaCon = New System.Windows.Forms.TextBox()
        Me.txtCambio = New System.Windows.Forms.TextBox()
        Me.lblTotalFacturado = New System.Windows.Forms.Label()
        Me.lblPagaCon = New System.Windows.Forms.Label()
        Me.lblCambio = New System.Windows.Forms.Label()
        Me.btnPagar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTotalFacturado
        '
        Me.txtTotalFacturado.BackColor = System.Drawing.Color.Yellow
        Me.txtTotalFacturado.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalFacturado.Location = New System.Drawing.Point(308, 75)
        Me.txtTotalFacturado.Margin = New System.Windows.Forms.Padding(3, 3, 3, 15)
        Me.txtTotalFacturado.Name = "txtTotalFacturado"
        Me.txtTotalFacturado.Size = New System.Drawing.Size(414, 40)
        Me.txtTotalFacturado.TabIndex = 0
        Me.txtTotalFacturado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPagaCon
        '
        Me.txtPagaCon.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPagaCon.Location = New System.Drawing.Point(308, 158)
        Me.txtPagaCon.Margin = New System.Windows.Forms.Padding(3, 3, 3, 15)
        Me.txtPagaCon.Name = "txtPagaCon"
        Me.txtPagaCon.Size = New System.Drawing.Size(414, 40)
        Me.txtPagaCon.TabIndex = 1
        Me.txtPagaCon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCambio
        '
        Me.txtCambio.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCambio.Location = New System.Drawing.Point(308, 241)
        Me.txtCambio.Name = "txtCambio"
        Me.txtCambio.Size = New System.Drawing.Size(414, 40)
        Me.txtCambio.TabIndex = 2
        Me.txtCambio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblTotalFacturado
        '
        Me.lblTotalFacturado.AutoSize = True
        Me.lblTotalFacturado.BackColor = System.Drawing.Color.Transparent
        Me.lblTotalFacturado.Font = New System.Drawing.Font("Lucida Sans", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalFacturado.Location = New System.Drawing.Point(443, 43)
        Me.lblTotalFacturado.Margin = New System.Windows.Forms.Padding(3, 0, 3, 7)
        Me.lblTotalFacturado.Name = "lblTotalFacturado"
        Me.lblTotalFacturado.Size = New System.Drawing.Size(203, 27)
        Me.lblTotalFacturado.TabIndex = 3
        Me.lblTotalFacturado.Text = "Monto A Cobrar"
        '
        'lblPagaCon
        '
        Me.lblPagaCon.AutoSize = True
        Me.lblPagaCon.BackColor = System.Drawing.Color.Transparent
        Me.lblPagaCon.Font = New System.Drawing.Font("Lucida Sans", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPagaCon.Location = New System.Drawing.Point(480, 124)
        Me.lblPagaCon.Margin = New System.Windows.Forms.Padding(3, 0, 3, 7)
        Me.lblPagaCon.Name = "lblPagaCon"
        Me.lblPagaCon.Size = New System.Drawing.Size(102, 27)
        Me.lblPagaCon.TabIndex = 4
        Me.lblPagaCon.Text = "Efectivo"
        '
        'lblCambio
        '
        Me.lblCambio.AutoSize = True
        Me.lblCambio.BackColor = System.Drawing.Color.Transparent
        Me.lblCambio.Font = New System.Drawing.Font("Lucida Sans", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCambio.Location = New System.Drawing.Point(482, 205)
        Me.lblCambio.Margin = New System.Windows.Forms.Padding(3, 0, 3, 7)
        Me.lblCambio.Name = "lblCambio"
        Me.lblCambio.Size = New System.Drawing.Size(104, 27)
        Me.lblCambio.TabIndex = 5
        Me.lblCambio.Text = "Cambio"
        '
        'btnPagar
        '
        Me.btnPagar.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPagar.Location = New System.Drawing.Point(525, 319)
        Me.btnPagar.Name = "btnPagar"
        Me.btnPagar.Size = New System.Drawing.Size(200, 52)
        Me.btnPagar.TabIndex = 6
        Me.btnPagar.Text = "Aceptar"
        Me.btnPagar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelar.Location = New System.Drawing.Point(308, 319)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(200, 52)
        Me.btnCancelar.TabIndex = 7
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.Facturacion_Esteban.My.Resources.Resources.FondoPantalla1
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(1024, 450)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'Fr_PagoFactura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnPagar)
        Me.Controls.Add(Me.lblCambio)
        Me.Controls.Add(Me.lblPagaCon)
        Me.Controls.Add(Me.lblTotalFacturado)
        Me.Controls.Add(Me.txtCambio)
        Me.Controls.Add(Me.txtPagaCon)
        Me.Controls.Add(Me.txtTotalFacturado)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximumSize = New System.Drawing.Size(1044, 493)
        Me.MinimumSize = New System.Drawing.Size(1044, 493)
        Me.Name = "Fr_PagoFactura"
        Me.Text = "Pago de Factura"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtTotalFacturado As TextBox
    Friend WithEvents txtPagaCon As TextBox
    Friend WithEvents txtCambio As TextBox
    Friend WithEvents lblTotalFacturado As Label
    Friend WithEvents lblPagaCon As Label
    Friend WithEvents lblCambio As Label
    Friend WithEvents btnPagar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
