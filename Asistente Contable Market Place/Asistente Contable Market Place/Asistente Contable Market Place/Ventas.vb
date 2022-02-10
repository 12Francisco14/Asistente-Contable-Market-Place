Public Class Ventas

    Private Sub iconminimizar_Click(sender As System.Object, e As System.EventArgs) 
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub iconcerrar_Click(sender As System.Object, e As System.EventArgs) Handles iconcerrar.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

        Generar_Id()

    End Sub
    Public Sub Generar_Id()
        Dim obj As New generanumeroaleatorio
        Dim unarray As Object = obj.Numeros_Aleatorios
        TextBox2.Text = "000" & (unarray(1)) & (unarray(2))
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click
        Dim Total As Integer
        Dim Sub_Total As Integer
        Dim Total_Pagar As Integer
        Dim Des As Double
        Dim Imp As Double

        TextBox18.Text = Total_Pagar
        Total = TextBox5.Text * TextBox6.Text
        TextBox7.Text = Total
        Des = Val(TextBox7.Text) * 0.05
        TextBox12.Text = Des
        Sub_Total = Val(TextBox7.Text) - Val(TextBox12.Text)
        TextBox14.Text = Sub_Total
        Imp = Val(TextBox14.Text) * 0.15
        TextBox13.Text = Imp
        Total_Pagar = Val(TextBox14.Text) + Val(TextBox13.Text)
        TextBox18.Text = Total_Pagar
    End Sub

    Private Sub TextBox12_TextChanged(sender As Object, e As EventArgs) Handles TextBox12.TextChanged

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click
        If GroupBox3.Visible = True Then
            GroupBox3.Visible = False
        Else
            GroupBox3.Visible = True

        End If
    End Sub

    Private Sub VENTASBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VENTASBindingNavigatorSaveItem.Click
        Me.VENTASBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.AsistenteDataSet)

    End Sub

    Private Sub Ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'AsistenteDataSet.VENTAS' Puede moverla o quitarla según sea necesario.
        Me.VENTASTableAdapter.Fill(Me.AsistenteDataSet.VENTAS)

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Me.VENTASTableAdapter.InsertarVentas(TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox12.Text, TextBox14.Text, TextBox13.Text, TextBox18.Text)
        Me.VENTASTableAdapter.Fill(Me.AsistenteDataSet.VENTAS)
        MsgBox("¡¡Datos guardados!!)")
    End Sub
    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.VENTASTableAdapter.Editar_Ventas(TextBox2.Text, TextBox3.Text, TextBox4.Text, TextBox5.Text, TextBox6.Text, TextBox7.Text, TextBox12.Text, TextBox14.Text, TextBox13.Text, TextBox18.Text, TextBox2.Text)
        Me.VENTASTableAdapter.Fill(Me.AsistenteDataSet.VENTAS)
        MsgBox("¡¡Datos Editados!!)")
    End Sub

    Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click
        Me.VENTASTableAdapter.Eliminar_Ventas(TextBox2.Text)
        Me.VENTASTableAdapter.Fill(Me.AsistenteDataSet.VENTAS)
        MsgBox("¡¡Datos Eliminados!!)")
    End Sub
End Class