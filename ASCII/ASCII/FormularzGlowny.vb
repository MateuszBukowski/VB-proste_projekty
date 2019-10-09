Public Class FormularzGlowny
    Private strTablicaASCII(2, 4) As String

    Private Sub BtnWyswietl_Click(sender As Object, e As EventArgs) Handles btnWyswietl.Click
        Dim intWiersz As Integer
        PrzypiszTablice()
        intWiersz = CInt(tbPodajZnak.Text)
        tbBin.Text = strTablicaASCII(intWiersz, 0)
        tbDec.Text = strTablicaASCII(intWiersz, 1)
        tbHex.Text = strTablicaASCII(intWiersz, 2)
        tbZnak.Text = strTablicaASCII(intWiersz, 3)
        tbSkrot.Text = strTablicaASCII(intWiersz, 4)
    End Sub
    Private Sub PrzypiszTablice()
        strTablicaASCII(0, 0) = "00000 0000"
        strTablicaASCII(0, 1) = "0"
        strTablicaASCII(0, 2) = "00"
        strTablicaASCII(0, 3) = "Null"
        strTablicaASCII(0, 4) = "NUL"

        strTablicaASCII(1, 0) = "00000 0001"
        strTablicaASCII(1, 1) = "1"
        strTablicaASCII(1, 2) = "01"
        strTablicaASCII(1, 3) = "Start of Heading"
        strTablicaASCII(1, 4) = "SOH"

        strTablicaASCII(2, 0) = "00000 0010"
        strTablicaASCII(2, 1) = "2"
        strTablicaASCII(2, 2) = "02"
        strTablicaASCII(2, 3) = "Start of Text"
        strTablicaASCII(2, 4) = "STX"
    End Sub

End Class
