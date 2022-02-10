Public Class generanumeroaleatorio
    Public Function Numeros_Aleatorios()
        Randomize()
        Dim Xnum(9) As Integer
        Dim i As Integer
        Dim starindex As Long
        Dim aleatorio As New Random


        Dim obj As Object
        For i = 0 To 9
            Xnum(i) = i

        Next

        For i = 0 To 9
            starindex = aleatorio.Next(0, 9)
            obj = Xnum(i)
            Xnum(i) = Xnum(starindex)
            Xnum(starindex) = obj

        Next
        Return Xnum

    End Function




End Class
