Public Class Proveedores
    Private Sub iconcerrar_Click(sender As System.Object, e As System.EventArgs) Handles iconcerrar.Click
        Me.Close()
    End Sub

    Private Sub iconminimizar_Click(sender As System.Object, e As System.EventArgs) Handles iconminimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        DateTimePicker1.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        Generar_Id()
    End Sub
    Public Sub Generar_Id()
        Dim obj As New generanumeroaleatorio
        Dim unarray As Object = obj.Numeros_Aleatorios
        TextBox2.Text = "PRV-00" & (unarray(1)) & (unarray(2))
    End Sub

    Private Sub PROVEEDORBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PROVEEDORBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PROVEEDORBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AsistenteDataSet)

    End Sub

    Private Sub Proveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AsistenteDataSet.PROVEEDOR' Puede moverla o quitarla según sea necesario.
        Me.PROVEEDORTableAdapter.Fill(Me.AsistenteDataSet.PROVEEDOR)

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If GroupBox3.Visible = True Then
            GroupBox3.Visible = False
        Else
            GroupBox3.Visible = True

        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.PROVEEDORTableAdapter.InsertarProv(TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox8.Text, TextBox9.Text)
        Me.PROVEEDORTableAdapter.Fill(Me.AsistenteDataSet.PROVEEDOR)
        MsgBox("¡¡Datos guardados!!)")
    End Sub
End Class