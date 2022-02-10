Public Class LOGIN

    Private Sub LOGIN_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        'Centrar el Panel
        Dim desktopSize As Size = System.Windows.Forms.SystemInformation.PrimaryMonitorSize       'Captura el Tamaño del Monitor
        Dim alto As Int32 = (desktopSize.Height - 280) \ 2
        Dim ancho As Int32 = (desktopSize.Width - 500) \ 2
        panel1.Location = New Point(ancho, alto)
        'Fin centrar el Panel

        'Mostrar Fecha y Hora
        lblFecha.Text = DateTime.Now.ToLongDateString()
        lblHora.Text = DateTime.Now.ToLongTimeString()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        'Actualizar cada segundo la Hora
        lblHora.Text = DateTime.Now.ToLongTimeString()
    End Sub

    Private Sub btnmin_Click(sender As System.Object, e As System.EventArgs) Handles btnmin.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btncerrar_Click(sender As System.Object, e As System.EventArgs) Handles btncerrar.Click
        If MessageBox.Show("Estas seguro que desea Salir", "◄ AVISO | Asistente Contable ►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
    Private Sub pictureBox1_MouseHover(sender As Object, e As EventArgs) Handles pictureBox1.MouseHover
        pictureBox1.Size = New Size(100, 92)
        'pictureBox1.BackgroundImageLayout = ImageLayout.Stretch
    End Sub

    Private Sub pictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles pictureBox1.MouseLeave
        pictureBox1.Size = New Size(90, 85)
        'pictureBox1.BackgroundImageLayout = ImageLayout.Zoom
    End Sub

    Private Sub pictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles pictureBox1.Click
        If txtuser.Text = "" Then
            MessageBox.Show("Asegúrese de ingresar el Usuario", "◄ AVISO | Asitente Contable►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf txtpass.Text = "" Then
            MessageBox.Show("Asegúrese de ingresar la Contraseña", "◄ AVISO | Asitente Contable►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
            txtpass.Text = ""
        ElseIf txtuser.Text = My.Settings.Usuario And txtpass.Text = My.Settings.Contraseña Then
            If MessageBox.Show("Bienvenido (a)" & My.Settings.Nombre & " " & My.Settings.Apellido & "", "◄ AVISO | Asitente Contable►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
                Dim a As New PRINCIPAL
                Me.Hide()
                a.ShowDialog()
                txtpass.Text = ""
                txtuser.Text = ""
            Else
                MessageBox.Show("Usted No esta registrado en el sistema", "◄ AVISO | Asitente Contable►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
                txtpass.Text = ""
                txtuser.Text = ""
            End If

        End If
    End Sub
End Class