Public Class Empleados

    Private Sub iconcerrar_Click(sender As System.Object, e As System.EventArgs) Handles iconcerrar.Click
        Me.Close()

    End Sub

    Private Sub iconminimizar_Click(sender As System.Object, e As System.EventArgs) Handles iconminimizar.Click

    End Sub

    Private Sub EMPLEADOSBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles EMPLEADOSBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EMPLEADOSBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AsistenteDataSet)

    End Sub

    Private Sub Empleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AsistenteDataSet.EMPLEADOS' Puede moverla o quitarla según sea necesario.
        Me.EMPLEADOSTableAdapter.Fill(Me.AsistenteDataSet.EMPLEADOS)

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        If GroupBox3.Visible = True Then
            GroupBox3.Visible = False
        Else
            GroupBox3.Visible = True

        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        ComboBox1.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        ComboBox2.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        DateTimePicker1.Text = ""
        Generar_Id()
    End Sub
    Public Sub Generar_Id()
        Dim obj As New generanumeroaleatorio
        Dim unarray As Object = obj.Numeros_Aleatorios
        TextBox2.Text = "EMP-00" & (unarray(1)) & (unarray(2))
    End Sub
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.EMPLEADOSTableAdapter.InsertarEmpleado(TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, ComboBox1.Text, TextBox6.Text, TextBox7.Text, ComboBox2.Text, TextBox8.Text, TextBox9.Text, DateTimePicker1.Text)
        Me.EMPLEADOSTableAdapter.Fill(Me.AsistenteDataSet.EMPLEADOS)
        MsgBox("¡¡Datos guardados!!)")
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.EMPLEADOSTableAdapter.Editar_Em(TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, ComboBox1.Text, TextBox6.Text, TextBox7.Text, ComboBox2.Text, TextBox8.Text, TextBox9.Text, DateTimePicker1.Text, TextBox2.Text)
        Me.EMPLEADOSTableAdapter.Fill(Me.AsistenteDataSet.EMPLEADOS)
        MsgBox("¡¡Datos Editados!!)")
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.EMPLEADOSTableAdapter.Eliminar(TextBox2.Text)
        Me.EMPLEADOSTableAdapter.Fill(Me.AsistenteDataSet.EMPLEADOS)
        MsgBox("¡¡Datos Borrados)")
    End Sub
End Class