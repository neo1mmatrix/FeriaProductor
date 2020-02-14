<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrArqueo
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrArqueo))
        Me.gbCantidad = New System.Windows.Forms.GroupBox()
        Me.dgvCaja = New Facturacion_Esteban.MEPDataGridView()
        Me.cFecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cNumeroFactura = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cCliente = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cMonto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.num50Mil = New System.Windows.Forms.NumericUpDown()
        Me.lbCincuentaMil = New System.Windows.Forms.Label()
        Me.lbVeinteMil = New System.Windows.Forms.Label()
        Me.lbDiezMil = New System.Windows.Forms.Label()
        Me.lbCincoMil = New System.Windows.Forms.Label()
        Me.lbDosMil = New System.Windows.Forms.Label()
        Me.lbMil = New System.Windows.Forms.Label()
        Me.lbQuinientos = New System.Windows.Forms.Label()
        Me.lbCien = New System.Windows.Forms.Label()
        Me.lbCincuenta = New System.Windows.Forms.Label()
        Me.lbVeintecienco = New System.Windows.Forms.Label()
        Me.lbDiez = New System.Windows.Forms.Label()
        Me.lbCinco = New System.Windows.Forms.Label()
        Me.num20Mil = New System.Windows.Forms.NumericUpDown()
        Me.num10Mil = New System.Windows.Forms.NumericUpDown()
        Me.num5Mil = New System.Windows.Forms.NumericUpDown()
        Me.num2Mil = New System.Windows.Forms.NumericUpDown()
        Me.num1Mil = New System.Windows.Forms.NumericUpDown()
        Me.num500 = New System.Windows.Forms.NumericUpDown()
        Me.num100 = New System.Windows.Forms.NumericUpDown()
        Me.num50 = New System.Windows.Forms.NumericUpDown()
        Me.num25 = New System.Windows.Forms.NumericUpDown()
        Me.num10 = New System.Windows.Forms.NumericUpDown()
        Me.num5 = New System.Windows.Forms.NumericUpDown()
        Me.gbMonto = New System.Windows.Forms.GroupBox()
        Me.lbMontoTarjeta = New System.Windows.Forms.Label()
        Me.nudMontoTarjeta = New System.Windows.Forms.NumericUpDown()
        Me.lbMontoFinal = New System.Windows.Forms.Label()
        Me.btnCerrarCaja = New System.Windows.Forms.Button()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.gbCantidad.SuspendLayout()
        CType(Me.dgvCaja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num50Mil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num20Mil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num10Mil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num5Mil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num2Mil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num1Mil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num500, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num100, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.num5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbMonto.SuspendLayout()
        CType(Me.nudMontoTarjeta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbCantidad
        '
        Me.gbCantidad.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gbCantidad.Controls.Add(Me.dgvCaja)
        Me.gbCantidad.Controls.Add(Me.num50Mil)
        Me.gbCantidad.Controls.Add(Me.lbCincuentaMil)
        Me.gbCantidad.Controls.Add(Me.lbVeinteMil)
        Me.gbCantidad.Controls.Add(Me.lbDiezMil)
        Me.gbCantidad.Controls.Add(Me.lbCincoMil)
        Me.gbCantidad.Controls.Add(Me.lbDosMil)
        Me.gbCantidad.Controls.Add(Me.lbMil)
        Me.gbCantidad.Controls.Add(Me.lbQuinientos)
        Me.gbCantidad.Controls.Add(Me.lbCien)
        Me.gbCantidad.Controls.Add(Me.lbCincuenta)
        Me.gbCantidad.Controls.Add(Me.lbVeintecienco)
        Me.gbCantidad.Controls.Add(Me.lbDiez)
        Me.gbCantidad.Controls.Add(Me.lbCinco)
        Me.gbCantidad.Controls.Add(Me.num20Mil)
        Me.gbCantidad.Controls.Add(Me.num10Mil)
        Me.gbCantidad.Controls.Add(Me.num5Mil)
        Me.gbCantidad.Controls.Add(Me.num2Mil)
        Me.gbCantidad.Controls.Add(Me.num1Mil)
        Me.gbCantidad.Controls.Add(Me.num500)
        Me.gbCantidad.Controls.Add(Me.num100)
        Me.gbCantidad.Controls.Add(Me.num50)
        Me.gbCantidad.Controls.Add(Me.num25)
        Me.gbCantidad.Controls.Add(Me.num10)
        Me.gbCantidad.Controls.Add(Me.num5)
        Me.gbCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbCantidad.Location = New System.Drawing.Point(12, 12)
        Me.gbCantidad.Name = "gbCantidad"
        Me.gbCantidad.Size = New System.Drawing.Size(550, 282)
        Me.gbCantidad.TabIndex = 0
        Me.gbCantidad.TabStop = False
        Me.gbCantidad.Text = "Cantidad"
        '
        'dgvCaja
        '
        Me.dgvCaja.AllowUserToAddRows = False
        Me.dgvCaja.AllowUserToDeleteRows = False
        Me.dgvCaja.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCaja.ColumnHeadersHeight = 40
        Me.dgvCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvCaja.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cFecha, Me.cNumeroFactura, Me.cCliente, Me.cMonto})
        Me.dgvCaja.Location = New System.Drawing.Point(150, 175)
        Me.dgvCaja.Name = "dgvCaja"
        Me.dgvCaja.Size = New System.Drawing.Size(249, 101)
        Me.dgvCaja.TabIndex = 20
        Me.dgvCaja.Visible = False
        '
        'cFecha
        '
        Me.cFecha.HeaderText = "Fecha"
        Me.cFecha.Name = "cFecha"
        Me.cFecha.Width = 150
        '
        'cNumeroFactura
        '
        Me.cNumeroFactura.HeaderText = "Nro Factura"
        Me.cNumeroFactura.Name = "cNumeroFactura"
        Me.cNumeroFactura.Width = 120
        '
        'cCliente
        '
        Me.cCliente.HeaderText = "Cliente"
        Me.cCliente.Name = "cCliente"
        '
        'cMonto
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.cMonto.DefaultCellStyle = DataGridViewCellStyle1
        Me.cMonto.HeaderText = "Monto"
        Me.cMonto.Name = "cMonto"
        Me.cMonto.Width = 200
        '
        'num50Mil
        '
        Me.num50Mil.Location = New System.Drawing.Point(364, 216)
        Me.num50Mil.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.num50Mil.Name = "num50Mil"
        Me.num50Mil.Size = New System.Drawing.Size(150, 29)
        Me.num50Mil.TabIndex = 11
        Me.num50Mil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.num50Mil.ThousandsSeparator = True
        '
        'lbCincuentaMil
        '
        Me.lbCincuentaMil.AutoSize = True
        Me.lbCincuentaMil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCincuentaMil.Location = New System.Drawing.Point(279, 221)
        Me.lbCincuentaMil.Name = "lbCincuentaMil"
        Me.lbCincuentaMil.Size = New System.Drawing.Size(74, 20)
        Me.lbCincuentaMil.TabIndex = 23
        Me.lbCincuentaMil.Text = "₡ 50.000"
        '
        'lbVeinteMil
        '
        Me.lbVeinteMil.AutoSize = True
        Me.lbVeinteMil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbVeinteMil.Location = New System.Drawing.Point(279, 186)
        Me.lbVeinteMil.Name = "lbVeinteMil"
        Me.lbVeinteMil.Size = New System.Drawing.Size(74, 20)
        Me.lbVeinteMil.TabIndex = 22
        Me.lbVeinteMil.Text = "₡ 20.000"
        '
        'lbDiezMil
        '
        Me.lbDiezMil.AutoSize = True
        Me.lbDiezMil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDiezMil.Location = New System.Drawing.Point(279, 151)
        Me.lbDiezMil.Name = "lbDiezMil"
        Me.lbDiezMil.Size = New System.Drawing.Size(74, 20)
        Me.lbDiezMil.TabIndex = 21
        Me.lbDiezMil.Text = "₡ 10.000"
        '
        'lbCincoMil
        '
        Me.lbCincoMil.AutoSize = True
        Me.lbCincoMil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCincoMil.Location = New System.Drawing.Point(279, 116)
        Me.lbCincoMil.Name = "lbCincoMil"
        Me.lbCincoMil.Size = New System.Drawing.Size(65, 20)
        Me.lbCincoMil.TabIndex = 20
        Me.lbCincoMil.Text = "₡ 5.000"
        '
        'lbDosMil
        '
        Me.lbDosMil.AutoSize = True
        Me.lbDosMil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDosMil.Location = New System.Drawing.Point(279, 81)
        Me.lbDosMil.Name = "lbDosMil"
        Me.lbDosMil.Size = New System.Drawing.Size(65, 20)
        Me.lbDosMil.TabIndex = 19
        Me.lbDosMil.Text = "₡ 2.000"
        '
        'lbMil
        '
        Me.lbMil.AutoSize = True
        Me.lbMil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMil.Location = New System.Drawing.Point(279, 46)
        Me.lbMil.Name = "lbMil"
        Me.lbMil.Size = New System.Drawing.Size(65, 20)
        Me.lbMil.TabIndex = 18
        Me.lbMil.Text = "₡ 1.000"
        '
        'lbQuinientos
        '
        Me.lbQuinientos.AutoSize = True
        Me.lbQuinientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbQuinientos.Location = New System.Drawing.Point(21, 225)
        Me.lbQuinientos.Name = "lbQuinientos"
        Me.lbQuinientos.Size = New System.Drawing.Size(52, 20)
        Me.lbQuinientos.TabIndex = 17
        Me.lbQuinientos.Text = "₡ 500"
        '
        'lbCien
        '
        Me.lbCien.AutoSize = True
        Me.lbCien.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCien.Location = New System.Drawing.Point(21, 190)
        Me.lbCien.Name = "lbCien"
        Me.lbCien.Size = New System.Drawing.Size(52, 20)
        Me.lbCien.TabIndex = 16
        Me.lbCien.Text = "₡ 100"
        '
        'lbCincuenta
        '
        Me.lbCincuenta.AutoSize = True
        Me.lbCincuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCincuenta.Location = New System.Drawing.Point(21, 151)
        Me.lbCincuenta.Name = "lbCincuenta"
        Me.lbCincuenta.Size = New System.Drawing.Size(43, 20)
        Me.lbCincuenta.TabIndex = 15
        Me.lbCincuenta.Text = "₡ 50"
        '
        'lbVeintecienco
        '
        Me.lbVeintecienco.AutoSize = True
        Me.lbVeintecienco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbVeintecienco.Location = New System.Drawing.Point(21, 116)
        Me.lbVeintecienco.Name = "lbVeintecienco"
        Me.lbVeintecienco.Size = New System.Drawing.Size(43, 20)
        Me.lbVeintecienco.TabIndex = 14
        Me.lbVeintecienco.Text = "₡ 25"
        '
        'lbDiez
        '
        Me.lbDiez.AutoSize = True
        Me.lbDiez.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDiez.Location = New System.Drawing.Point(21, 81)
        Me.lbDiez.Name = "lbDiez"
        Me.lbDiez.Size = New System.Drawing.Size(43, 20)
        Me.lbDiez.TabIndex = 13
        Me.lbDiez.Text = "₡ 10"
        '
        'lbCinco
        '
        Me.lbCinco.AutoSize = True
        Me.lbCinco.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCinco.Location = New System.Drawing.Point(21, 46)
        Me.lbCinco.Name = "lbCinco"
        Me.lbCinco.Size = New System.Drawing.Size(34, 20)
        Me.lbCinco.TabIndex = 12
        Me.lbCinco.Text = "₡ 5"
        '
        'num20Mil
        '
        Me.num20Mil.Location = New System.Drawing.Point(364, 181)
        Me.num20Mil.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.num20Mil.Name = "num20Mil"
        Me.num20Mil.Size = New System.Drawing.Size(150, 29)
        Me.num20Mil.TabIndex = 10
        Me.num20Mil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.num20Mil.ThousandsSeparator = True
        '
        'num10Mil
        '
        Me.num10Mil.Location = New System.Drawing.Point(364, 146)
        Me.num10Mil.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.num10Mil.Name = "num10Mil"
        Me.num10Mil.Size = New System.Drawing.Size(150, 29)
        Me.num10Mil.TabIndex = 9
        Me.num10Mil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.num10Mil.ThousandsSeparator = True
        '
        'num5Mil
        '
        Me.num5Mil.Location = New System.Drawing.Point(364, 111)
        Me.num5Mil.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.num5Mil.Name = "num5Mil"
        Me.num5Mil.Size = New System.Drawing.Size(150, 29)
        Me.num5Mil.TabIndex = 8
        Me.num5Mil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.num5Mil.ThousandsSeparator = True
        '
        'num2Mil
        '
        Me.num2Mil.Location = New System.Drawing.Point(364, 76)
        Me.num2Mil.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.num2Mil.Name = "num2Mil"
        Me.num2Mil.Size = New System.Drawing.Size(150, 29)
        Me.num2Mil.TabIndex = 7
        Me.num2Mil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.num2Mil.ThousandsSeparator = True
        '
        'num1Mil
        '
        Me.num1Mil.Location = New System.Drawing.Point(364, 41)
        Me.num1Mil.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.num1Mil.Name = "num1Mil"
        Me.num1Mil.Size = New System.Drawing.Size(150, 29)
        Me.num1Mil.TabIndex = 6
        Me.num1Mil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.num1Mil.ThousandsSeparator = True
        '
        'num500
        '
        Me.num500.Location = New System.Drawing.Point(84, 216)
        Me.num500.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.num500.Name = "num500"
        Me.num500.Size = New System.Drawing.Size(150, 29)
        Me.num500.TabIndex = 5
        Me.num500.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.num500.ThousandsSeparator = True
        '
        'num100
        '
        Me.num100.Location = New System.Drawing.Point(84, 181)
        Me.num100.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.num100.Name = "num100"
        Me.num100.Size = New System.Drawing.Size(150, 29)
        Me.num100.TabIndex = 4
        Me.num100.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.num100.ThousandsSeparator = True
        '
        'num50
        '
        Me.num50.Location = New System.Drawing.Point(84, 146)
        Me.num50.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.num50.Name = "num50"
        Me.num50.Size = New System.Drawing.Size(150, 29)
        Me.num50.TabIndex = 3
        Me.num50.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.num50.ThousandsSeparator = True
        '
        'num25
        '
        Me.num25.Location = New System.Drawing.Point(84, 111)
        Me.num25.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.num25.Name = "num25"
        Me.num25.Size = New System.Drawing.Size(150, 29)
        Me.num25.TabIndex = 2
        Me.num25.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.num25.ThousandsSeparator = True
        '
        'num10
        '
        Me.num10.Location = New System.Drawing.Point(84, 76)
        Me.num10.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.num10.Name = "num10"
        Me.num10.Size = New System.Drawing.Size(150, 29)
        Me.num10.TabIndex = 1
        Me.num10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.num10.ThousandsSeparator = True
        '
        'num5
        '
        Me.num5.Location = New System.Drawing.Point(84, 41)
        Me.num5.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.num5.Name = "num5"
        Me.num5.Size = New System.Drawing.Size(150, 29)
        Me.num5.TabIndex = 0
        Me.num5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.num5.ThousandsSeparator = True
        '
        'gbMonto
        '
        Me.gbMonto.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.gbMonto.Controls.Add(Me.lbMontoTarjeta)
        Me.gbMonto.Controls.Add(Me.nudMontoTarjeta)
        Me.gbMonto.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbMonto.Location = New System.Drawing.Point(12, 321)
        Me.gbMonto.Name = "gbMonto"
        Me.gbMonto.Size = New System.Drawing.Size(550, 105)
        Me.gbMonto.TabIndex = 1
        Me.gbMonto.TabStop = False
        Me.gbMonto.Text = "Monto"
        '
        'lbMontoTarjeta
        '
        Me.lbMontoTarjeta.AutoSize = True
        Me.lbMontoTarjeta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMontoTarjeta.Location = New System.Drawing.Point(31, 55)
        Me.lbMontoTarjeta.Name = "lbMontoTarjeta"
        Me.lbMontoTarjeta.Size = New System.Drawing.Size(129, 20)
        Me.lbMontoTarjeta.TabIndex = 24
        Me.lbMontoTarjeta.Text = "Monto de Tarjeta"
        '
        'nudMontoTarjeta
        '
        Me.nudMontoTarjeta.DecimalPlaces = 2
        Me.nudMontoTarjeta.Location = New System.Drawing.Point(166, 50)
        Me.nudMontoTarjeta.Maximum = New Decimal(New Integer() {1410065407, 2, 0, 0})
        Me.nudMontoTarjeta.Name = "nudMontoTarjeta"
        Me.nudMontoTarjeta.Size = New System.Drawing.Size(211, 29)
        Me.nudMontoTarjeta.TabIndex = 1
        Me.nudMontoTarjeta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.nudMontoTarjeta.ThousandsSeparator = True
        '
        'lbMontoFinal
        '
        Me.lbMontoFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMontoFinal.Location = New System.Drawing.Point(12, 444)
        Me.lbMontoFinal.Name = "lbMontoFinal"
        Me.lbMontoFinal.Size = New System.Drawing.Size(550, 25)
        Me.lbMontoFinal.TabIndex = 18
        Me.lbMontoFinal.Text = "Monto ₡ 0"
        '
        'btnCerrarCaja
        '
        Me.btnCerrarCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrarCaja.Location = New System.Drawing.Point(196, 472)
        Me.btnCerrarCaja.Name = "btnCerrarCaja"
        Me.btnCerrarCaja.Size = New System.Drawing.Size(193, 37)
        Me.btnCerrarCaja.TabIndex = 19
        Me.btnCerrarCaja.Text = "Cerrar Caja"
        Me.btnCerrarCaja.UseVisualStyleBackColor = True
        '
        'dtpHasta
        '
        Me.dtpHasta.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.dtpHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHasta.Location = New System.Drawing.Point(344, 444)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.ShowUpDown = True
        Me.dtpHasta.Size = New System.Drawing.Size(135, 22)
        Me.dtpHasta.TabIndex = 21
        Me.dtpHasta.Visible = False
        '
        'dtpInicio
        '
        Me.dtpInicio.CustomFormat = "dd/MM/yyyy HH:mm"
        Me.dtpInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpInicio.Location = New System.Drawing.Point(192, 444)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.ShowUpDown = True
        Me.dtpInicio.Size = New System.Drawing.Size(135, 22)
        Me.dtpInicio.TabIndex = 20
        Me.dtpInicio.Visible = False
        '
        'FrArqueo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.ClientSize = New System.Drawing.Size(576, 516)
        Me.Controls.Add(Me.dtpHasta)
        Me.Controls.Add(Me.dtpInicio)
        Me.Controls.Add(Me.btnCerrarCaja)
        Me.Controls.Add(Me.lbMontoFinal)
        Me.Controls.Add(Me.gbMonto)
        Me.Controls.Add(Me.gbCantidad)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrArqueo"
        Me.Text = "Caja - Cierre"
        Me.gbCantidad.ResumeLayout(False)
        Me.gbCantidad.PerformLayout()
        CType(Me.dgvCaja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num50Mil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num20Mil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num10Mil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num5Mil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num2Mil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num1Mil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num500, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num100, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.num5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbMonto.ResumeLayout(False)
        Me.gbMonto.PerformLayout()
        CType(Me.nudMontoTarjeta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbCantidad As GroupBox
    Friend WithEvents num50Mil As NumericUpDown
    Friend WithEvents lbCincuentaMil As Label
    Friend WithEvents lbVeinteMil As Label
    Friend WithEvents lbDiezMil As Label
    Friend WithEvents lbCincoMil As Label
    Friend WithEvents lbDosMil As Label
    Friend WithEvents lbMil As Label
    Friend WithEvents lbQuinientos As Label
    Friend WithEvents lbCien As Label
    Friend WithEvents lbCincuenta As Label
    Friend WithEvents lbVeintecienco As Label
    Friend WithEvents lbDiez As Label
    Friend WithEvents lbCinco As Label
    Friend WithEvents num20Mil As NumericUpDown
    Friend WithEvents num10Mil As NumericUpDown
    Friend WithEvents num5Mil As NumericUpDown
    Friend WithEvents num2Mil As NumericUpDown
    Friend WithEvents num1Mil As NumericUpDown
    Friend WithEvents num500 As NumericUpDown
    Friend WithEvents num100 As NumericUpDown
    Friend WithEvents num50 As NumericUpDown
    Friend WithEvents num25 As NumericUpDown
    Friend WithEvents num10 As NumericUpDown
    Friend WithEvents num5 As NumericUpDown
    Friend WithEvents gbMonto As GroupBox
    Friend WithEvents lbMontoFinal As Label
    Friend WithEvents lbMontoTarjeta As Label
    Friend WithEvents nudMontoTarjeta As NumericUpDown
    Friend WithEvents btnCerrarCaja As Button
    Friend WithEvents dgvCaja As MEPDataGridView
    Friend WithEvents cFecha As DataGridViewTextBoxColumn
    Friend WithEvents cNumeroFactura As DataGridViewTextBoxColumn
    Friend WithEvents cCliente As DataGridViewTextBoxColumn
    Friend WithEvents cMonto As DataGridViewTextBoxColumn
    Friend WithEvents dtpHasta As DateTimePicker
    Friend WithEvents dtpInicio As DateTimePicker
End Class
