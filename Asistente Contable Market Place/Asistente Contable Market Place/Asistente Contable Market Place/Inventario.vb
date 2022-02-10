Public Class Inventario

    Private Sub iconcerrar_Click(sender As System.Object, e As System.EventArgs) Handles iconcerrar.Click
        Me.Close()
    End Sub

    Private Sub iconminimizar_Click(sender As System.Object, e As System.EventArgs) Handles iconminimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub INVENTARIOBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles INVENTARIOBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.INVENTARIOBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AsistenteDataSet)

    End Sub

    Private Sub Inventario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AsistenteDataSet.INVENTARIO' Puede moverla o quitarla según sea necesario.
        Me.INVENTARIOTableAdapter.Fill(Me.AsistenteDataSet.INVENTARIO)

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextBox2.Text = ""
        TextBox3.Text = ""
        ComboBox1.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        DateTimePicker1.Text = ""
        TextBox8.Text = ""

        Generar_Id()

    End Sub
    Public Sub Generar_Id()
        Dim obj As New generanumeroaleatorio
        Dim unarray As Object = obj.Numeros_Aleatorios
        TextBox2.Text = "000" & (unarray(1)) & (unarray(2))
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If GroupBox3.Visible = True Then
            GroupBox3.Visible = False
        Else
            GroupBox3.Visible = True

        End If
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.INVENTARIOTableAdapter.InsertarProducto(TextBox2.Text, TextBox3.Text, ComboBox1.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, DateTimePicker1.Text, TextBox8.Text)
        Me.INVENTARIOTableAdapter.Fill(Me.AsistenteDataSet.INVENTARIO)
        MsgBox("¡¡Datos guardados!!)")
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.INVENTARIOTableAdapter.Editar_Prod(TextBox2.Text, TextBox3.Text, ComboBox1.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, DateTimePicker1.Text, TextBox8.Text, TextBox2.Text)
        Me.INVENTARIOTableAdapter.Fill(Me.AsistenteDataSet.INVENTARIO)
        MsgBox("¡¡Datos Editados!!)")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.INVENTARIOTableAdapter.Eliminar_Prod(TextBox2.Text)
        Me.INVENTARIOTableAdapter.Fill(Me.AsistenteDataSet.INVENTARIO)
        MsgBox("¡¡Datos Eliminados!!)")
    End Sub


End Class