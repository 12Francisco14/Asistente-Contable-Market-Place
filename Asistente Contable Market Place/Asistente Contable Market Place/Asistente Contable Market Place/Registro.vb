Public Class Registro
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        If TextBox1.Text = "" Then
            MessageBox.Show("Asegúrese de ingresar el Nombre", "◄ AVISO | Asitente Contable►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox2.Text = "" Then
            MessageBox.Show("Asegúrese de ingresar el apellido", "◄ AVISO | Asitente Contable►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox3.Text = "" Then
            MessageBox.Show("Asegúrese de ingresar el Usuario", "◄ AVISO | Asitente Contable►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox4.Text = "" Then
            MessageBox.Show("Asegúrese de ingresar la Contraseña", "◄ AVISO | Asitente Contable►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        ElseIf TextBox3.Text = My.Settings.Usuario Then
            MessageBox.Show("Usuario ya existe", "◄ AVISO | Asitente Contable►", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1)
        Else
            My.Settings.Nombre = TextBox1.Text
            My.Settings.Apellido = TextBox2.Text
            My.Settings.Usuario = TextBox3.Text
            My.Settings.Contraseña = TextBox4.Text
            My.Settings.Save()
            My.Settings.Reload()
            MsgBox("Datos guardados Correctamente!!")
            TextBox1.Text = ""
            TextBox2.Text = ""
            TextBox3.Text = ""
            TextBox4.Text = ""
        End If
    End Sub

    Private Sub iconcerrar_Click(sender As Object, e As EventArgs) Handles iconcerrar.Click
        Me.Close()
    End Sub

    Private Sub iconminimizar_Click(sender As Object, e As EventArgs)
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox4.UseSystemPasswordChar = False
        Else
            TextBox4.UseSystemPasswordChar = True
        End If
    End Sub
End Class