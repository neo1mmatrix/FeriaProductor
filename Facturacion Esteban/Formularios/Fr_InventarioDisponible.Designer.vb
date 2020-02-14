<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Fr_InventarioDisponible
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvDetalles = New System.Windows.Forms.DataGridView()
        Me.C_codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_barcode = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_cantidadDisponible = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_cantidadIngresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_disminuyeInventario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.C_id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.lbFiltro = New System.Windows.Forms.Label()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDetalles
        '
        Me.dgvDetalles.AllowUserToAddRows = False
        Me.dgvDetalles.AllowUserToDeleteRows = False
        Me.dgvDetalles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.C_codigo, Me.C_barcode, Me.C_producto, Me.C_cantidadDisponible, Me.C_cantidadIngresa, Me.C_disminuyeInventario, Me.C_id})
        Me.dgvDetalles.Location = New System.Drawing.Point(12, 58)
        Me.dgvDetalles.Name = "dgvDetalles"
        Me.dgvDetalles.Size = New System.Drawing.Size(1065, 292)
        Me.dgvDetalles.TabIndex = 0
        '
        'C_codigo
        '
        Me.C_codigo.HeaderText = "Código"
        Me.C_codigo.Name = "C_codigo"
        Me.C_codigo.ReadOnly = True
        '
        'C_barcode
        '
        Me.C_barcode.HeaderText = "Barcode"
        Me.C_barcode.Name = "C_barcode"
        Me.C_barcode.ReadOnly = True
        '
        'C_producto
        '
        Me.C_producto.HeaderText = "Producto"
        Me.C_producto.Name = "C_producto"
        Me.C_producto.ReadOnly = True
        '
        'C_cantidadDisponible
        '
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.C_cantidadDisponible.DefaultCellStyle = DataGridViewCellStyle4
        Me.C_cantidadDisponible.HeaderText = "Cantidad Disponible"
        Me.C_cantidadDisponible.Name = "C_cantidadDisponible"
        Me.C_cantidadDisponible.ReadOnly = True
        '
        'C_cantidadIngresa
        '
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.C_cantidadIngresa.DefaultCellStyle = DataGridViewCellStyle5
        Me.C_cantidadIngresa.HeaderText = "Ingresa"
        Me.C_cantidadIngresa.Name = "C_cantidadIngresa"
        '
        'C_disminuyeInventario
        '
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        Me.C_disminuyeInventario.DefaultCellStyle = DataGridViewCellStyle6
        Me.C_disminuyeInventario.HeaderText = "Disminuye"
        Me.C_disminuyeInventario.Name = "C_disminuyeInventario"
        '
        'C_id
        '
        Me.C_id.HeaderText = "Id"
        Me.C_id.Name = "C_id"
        Me.C_id.ReadOnly = True
        Me.C_id.Visible = False
        '
        'btnActualizar
        '
        Me.btnActualizar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.btnActualizar.Location = New System.Drawing.Point(442, 376)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(167, 34)
        Me.btnActualizar.TabIndex = 1
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'txtBusqueda
        '
        Me.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBusqueda.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBusqueda.Location = New System.Drawing.Point(85, 28)
        Me.txtBusqueda.MaxLength = 50
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(367, 22)
        Me.txtBusqueda.TabIndex = 2
        '
        'lbFiltro
        '
        Me.lbFiltro.AutoSize = True
        Me.lbFiltro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFiltro.Location = New System.Drawing.Point(39, 31)
        Me.lbFiltro.Name = "lbFiltro"
        Me.lbFiltro.Size = New System.Drawing.Size(40, 16)
        Me.lbFiltro.TabIndex = 3
        Me.lbFiltro.Text = "Filtro:"
        '
        'Fr_InventarioDisponible
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1089, 422)
        Me.Controls.Add(Me.lbFiltro)
        Me.Controls.Add(Me.txtBusqueda)
        Me.Controls.Add(Me.btnActualizar)
        Me.Controls.Add(Me.dgvDetalles)
        Me.Name = "Fr_InventarioDisponible"
        Me.Text = "Inventario"
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvDetalles As DataGridView
    Friend WithEvents C_codigo As DataGridViewTextBoxColumn
    Friend WithEvents C_barcode As DataGridViewTextBoxColumn
    Friend WithEvents C_producto As DataGridViewTextBoxColumn
    Friend WithEvents C_cantidadDisponible As DataGridViewTextBoxColumn
    Friend WithEvents C_cantidadIngresa As DataGridViewTextBoxColumn
    Friend WithEvents C_disminuyeInventario As DataGridViewTextBoxColumn
    Friend WithEvents C_id As DataGridViewTextBoxColumn
    Friend WithEvents btnActualizar As Button
    Friend WithEvents txtBusqueda As TextBox
    Friend WithEvents lbFiltro As Label
End Class
