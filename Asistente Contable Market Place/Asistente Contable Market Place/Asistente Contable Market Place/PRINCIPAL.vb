Public Class PRINCIPAL

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        lblhora.Text = DateTime.Now.ToString("hh:mm:ss ")
        lblFecha.Text = DateTime.Now.ToShortDateString()
    End Sub

    Private Sub btnMenu_Click(sender As System.Object, e As System.EventArgs) Handles btnMenu.Click
        If (MenuVertical.Width = 250) Then

            MenuVertical.Width = 70

        Else
            MenuVertical.Width = 250
        End If
    End Sub

    Private Sub iconminimizar_Click(sender As System.Object, e As System.EventArgs) Handles iconminimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
    Private Sub iconrestaurar_Click(sender As Object, e As EventArgs) Handles iconrestaurar.Click
        Me.WindowState = FormWindowState.Normal
        iconrestaurar.Visible = False
        iconmaximizar.Visible = True
    End Sub

    Private Sub iconmaximizar_Click_2(sender As Object, e As EventArgs) Handles iconmaximizar.Click
        Me.WindowState = FormWindowState.Maximized
        iconrestaurar.Visible = True
        iconmaximizar.Visible = False
    End Sub

    Private Sub iconcerrar_Click(sender As System.Object, e As System.EventArgs) Handles iconcerrar.Click
        If MessageBox.Show("Estas seguro que desea Salir", "◄ AVISO | Asitente Contable►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) = DialogResult.Yes Then
            End
        End If
    End Sub

    Private Sub PictureBox12_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox12.MouseClick
        If panelContenedor.Visible = True Then
            panelContenedor.Visible = False
        Else
            panelContenedor.Visible = True
        End If
    End Sub

    Private Sub Button13_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Button13.MouseClick
        If Inventario.Visible = False Then
            panelContenedor.Hide()
            Dim a As New Inventario
            a.ShowDialog()

        Else
            panelContenedor.Show()
        End If
    End Sub

    Private Sub Button11_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Button11.MouseClick
        If Ingreso_Cliente.Visible = False Then
            panelContenedor.Hide()
            Dim a As New Ingreso_Cliente
            a.ShowDialog()

        Else
            panelContenedor.Show()
        End If
    End Sub

    Private Sub Button1_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Button1.MouseClick
        If Empleados.Visible = False Then
            panelContenedor.Hide()
            Dim a As New Empleados
            a.ShowDialog()

        Else
            panelContenedor.Show()
        End If

    End Sub

    Private Sub Button10_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Button10.MouseClick
        If Proveedores.Visible = False Then
            panelContenedor.Hide()
            Dim a As New Proveedores
            a.ShowDialog()

        Else
            panelContenedor.Show()
        End If
    End Sub

    Private Sub Button12_MouseClick(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Button12.MouseClick
        If Ventas.Visible = False Then
            panelContenedor.Hide()
            Dim a As New Ventas
            a.ShowDialog()

        Else
            panelContenedor.Show()
        End If
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If Ventas.Visible = False Then
            panelContenedor.Hide()
            Dim a As New Registro
            a.ShowDialog()

        Else
            panelContenedor.Show()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        If Ingreso_Cliente.Visible = False Then
            panelContenedor.Hide()
            Dim a As New Ingreso_Cliente
            a.ShowDialog()

        Else
            panelContenedor.Show()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        If Ingreso_Cliente.Visible = False Then
            panelContenedor.Hide()
            Dim a As New Empleados
            a.ShowDialog()

        Else
            panelContenedor.Show()
        End If
    End Sub

    Private Sub pictureBox6_Click(sender As Object, e As EventArgs) Handles pictureBox6.Click
        If Ingreso_Cliente.Visible = False Then
            panelContenedor.Hide()
            Dim a As New Proveedores
            a.ShowDialog()

        Else
            panelContenedor.Show()
        End If
    End Sub

    Private Sub PictureBox8_Click(sender As Object, e As EventArgs) Handles PictureBox8.Click
        If Ingreso_Cliente.Visible = False Then
            panelContenedor.Hide()
            Dim a As New Inventario
            a.ShowDialog()

        Else
            panelContenedor.Show()
        End If
    End Sub

    Private Sub pictureBox5_Click(sender As Object, e As EventArgs) Handles pictureBox5.Click
        If Ingreso_Cliente.Visible = False Then
            panelContenedor.Hide()
            Dim a As New Registro
            a.ShowDialog()

        Else
            panelContenedor.Show()
        End If
    End Sub

    Private Sub pictureBox4_Click(sender As Object, e As EventArgs) Handles pictureBox4.Click
        If Ingreso_Cliente.Visible = False Then
            panelContenedor.Hide()
            Dim a As New Ventas
            a.ShowDialog()

        Else
            panelContenedor.Show()
        End If
    End Sub
End Class