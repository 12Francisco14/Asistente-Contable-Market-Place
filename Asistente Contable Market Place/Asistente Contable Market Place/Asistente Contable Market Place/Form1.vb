Public Class Form1
    Private pict As PictureBox()
    'declaracion de matrices
    Private count As Integer = 0
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        pict = New PictureBox(4) {pictureBox1, pictureBox2, pictureBox3, pictureBox4, pictureBox5}
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If count < 5 Then
            pict(count).BackgroundImage = Asistente_Contable_Market_Place.My.Resources.Circle2
            count += 1
            label1.Text = "Cargando al " & (count * 20) & " %"
        Else
            Timer1.Enabled = False
            Dim a As New LOGIN
            Me.Hide()
            a.ShowDialog()
        End If
    End Sub
End Class
