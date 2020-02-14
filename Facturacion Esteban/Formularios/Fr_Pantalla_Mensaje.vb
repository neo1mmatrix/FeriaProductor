Public Class Fr_Pantalla_Mensaje

    Dim _MontoCambio As String
    Dim _Segundos As Integer

    Public Sub New(ByVal p_monto As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        If Not (String.IsNullOrEmpty(p_monto)) Then
            _MontoCambio = p_monto
        End If

    End Sub
    Private Sub Fr_Pantalla_Mensaje_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCambio.Parent = PictureBox1
        lblMonto.Parent = PictureBox1
    End Sub

    Private Sub Fr_Pantalla_Mensaje_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown

        lblMonto.Text = _MontoCambio
        _Segundos = 0
        Timer1.Start()
        btnAceptar.Focus()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

        _Segundos += 1
        If _Segundos = 50 Then
            Timer1.Stop()
            _Segundos = 0
            Me.Close()
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles PictureBox1.PreviewKeyDown
        Me.Close()
    End Sub

    Private Sub lblMonto_PreviewKeyDown(sender As Object, e As PreviewKeyDownEventArgs) Handles lblMonto.PreviewKeyDown
        Me.Close()
    End Sub

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click

        Me.Close()

    End Sub
End Class