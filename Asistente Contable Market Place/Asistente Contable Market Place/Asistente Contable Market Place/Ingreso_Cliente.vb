Public Class Ingreso_Cliente

    Private Sub iconcerrar_Click(sender As System.Object, e As System.EventArgs) Handles iconcerrar.Click
        Me.Close()
    End Sub

    Private Sub iconminimizar_Click(sender As System.Object, e As System.EventArgs) Handles iconminimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If GroupBox3.Visible = True Then
            GroupBox3.Visible = False
        Else
            GroupBox3.Visible = True

        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CLIENTESBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles CLIENTESBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CLIENTESBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AsistenteDataSet)

    End Sub

    Private Sub Ingreso_Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AsistenteDataSet.CLIENTES' Puede moverla o quitarla según sea necesario.
        Me.CLIENTESTableAdapter.Fill(Me.AsistenteDataSet.CLIENTES)

    End Sub

    Private Sub CLIENTESDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles CLIENTESDataGridView.CellContentClick

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        DateTimePicker1.Text = ""
        TextBox7.Text = ""
        Generar_Id()
    End Sub
    Public Sub Generar_Id()
        Dim obj As New generanumeroaleatorio
        Dim unarray As Object = obj.Numeros_Aleatorios
        TextBox2.Text = "CL-000" & (unarray(1)) & (unarray(2))
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.CLIENTESTableAdapter.InsertarCliente(TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, DateTimePicker1.Text, TextBox7.Text)
        Me.CLIENTESTableAdapter.Fill(Me.AsistenteDataSet.CLIENTES)
        MsgBox("¡¡Datos guardados!!)")
    End Sub
End Class