Public Class FormularzGlowny
    Private dblRoznica As Double
    Private dblWynik As Double
    Private dblMaxPotega As Double
    Private strWynik As String
    Private Sub BtnBin_Click(sender As Object, e As EventArgs) Handles btnBin.Click
        If radioBin.Checked = True Then
            lblBin.Text = "BIN: " & textbWprowadz.Text
        ElseIf radioDec.Checked = True Then
            lblBin.Text = "BIN: " & DecToBin(CInt(textbWprowadz.Text))
        ElseIf radioHex.Checked = True Then
            lblBin.Text = HexToBin(textbWprowadz.Text)
        Else
            MessageBox.Show("Wskaż jakiego rodzaju liczbę prowadziłeś.")
        End If
    End Sub
    Private Sub BtnDec_Click(sender As Object, e As EventArgs) Handles btnDec.Click
        If radioBin.Checked = True Then
            BinToDec()
        ElseIf radioDec.Checked = True Then
            lblDec.Text = "DEC: " & textbWprowadz.Text
        ElseIf radioHex.Checked = True Then
            lblDec.Text = HexToDec(textbWprowadz.Text)
        Else
            MessageBox.Show("Wskaż jakiego rodzaju liczbę prowadziłeś.")
        End If
    End Sub
    Private Sub BtnHex_Click(sender As Object, e As EventArgs) Handles btnHex.Click
        If radioBin.Checked = True Then
            lblHex.Text = "HEX: " & BinToHex(textbWprowadz.Text)
        ElseIf radioDec.Checked = True Then
            DecToHex()
        ElseIf radioHex.Checked = True Then
            lblHex.Text = "HEX: " & textbWprowadz.Text
        Else
            MessageBox.Show("Wskaż jakiego rodzaju liczbę prowadziłeś.")
        End If
    End Sub
    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lblBin.Text = "BIN: "
        lblHex.Text = "HEX: "
        lblDec.Text = "DEC: "
    End Sub
    Private Function DecToBin(ByVal intLiczbaDec As Integer) As String
        'Binarny na dzieisętny
        'Algorytm: dzielimy na dwa i zapisuję resztę z dzielenia 1 lub zero do stringa.
        'Dopólki wynik nie jest mniejszy od 1.
        'Od dołu do góry czytamy (od ostatniego do pierwszego) i wychodzi liczba binarna.
        Dim intLiczba As Integer
        Dim strModulo As String
        intLiczba = intLiczbaDec
        strModulo = ""
        Do While intLiczba <> 0
            strModulo = strModulo & CStr(intLiczba Mod 2)
            intLiczba = (intLiczba \ 2)
        Loop
        'Odwróć string strModulo
        strModulo = StrReverse(strModulo)
        'Wpisz wynik do etykiety
        Return strModulo
    End Function
    Private Function HexToBin(ByVal strLiczbaHex As String) As String
        'Hex to bin
        Dim strWynik As String
        strWynik = "BIN: Heks"
        Return strWynik
    End Function
    Private Function HexToDec(ByVal strLiczbaHex As String) As String
        'HexToDec
        Dim strWynik As String
        strWynik = "DEC: Heks"
        Return strWynik
    End Function
    Private Sub BinToDec()
        Dim iloscZnakow As Integer
        Dim potega As Integer
        Dim cyfra As Double
        Dim suma As Double
        Dim temp As String
        'Długość ciągu znaków
        iloscZnakow = CInt(Len(textbWprowadz.Text))
        'GetChar(String, Int32)
        lblDec.Text = "DEC: "
        potega = 0
        suma = 0
        'Od ostatniego znaku do pierwszego
        For index As Integer = iloscZnakow To 1 Step -1
            temp = GetChar(textbWprowadz.Text, index)
            If temp = "1" Then
                cyfra = (2 ^ potega)
                suma = suma + cyfra
            End If
            potega = potega + 1
        Next index
        'Wypełij etykiete DEC wynikiem
        lblDec.Text = "DEC: " & CStr(suma)

    End Sub
    Private Function BinToHex(ByVal strLiczbaHex As String) As String
        'bin to hex
        Dim strWynik As String
        strWynik = "Heks"
        Return strWynik
    End Function
    Private Sub DecToHex()
        Dim dblOblicz As Double
        Debug.WriteLine("**************************************")
        'Ustaw początek napisu w etykiecie
        lblHex.Text = "HEX: "
        dblOblicz = CDbl(textbWprowadz.Text)
        Do While dblOblicz >= 16
            ZnajdzNajwiekszaPotege(dblOblicz)
            dblWynik = dblOblicz / (16 ^ dblMaxPotega)
            Debug.Write("dblWynik: ")
            Debug.WriteLine(dblWynik)
            dblWynik = Math.Truncate(dblWynik)
            Debug.Write("dblWynik: ")
            Debug.WriteLine(dblWynik)
            KonwertujWynikDecNaHex(dblWynik)
            lblHex.Text = lblHex.Text & strWynik
            dblOblicz = dblOblicz - (dblWynik * (16 ^ dblMaxPotega))
        Loop
        'Wstaw resztę
        KonwertujWynikDecNaHex(dblOblicz)
        lblHex.Text = lblHex.Text & CStr(strWynik)
    End Sub
    Private Sub ZnajdzNajwiekszaPotege(ByRef dblLiczba As Double)
        Dim dblPotega16 As Double
        Dim dblWynikPotegi As Double
        dblPotega16 = 0
        dblWynikPotegi = 16 ^ dblPotega16
        dblMaxPotega = 0
        Do While dblWynikPotegi <= dblLiczba
            dblMaxPotega = dblPotega16
            Debug.Write("dblMaxPotega: ")
            Debug.WriteLine(dblMaxPotega)
            dblPotega16 = dblPotega16 + 1
            dblWynikPotegi = 16 ^ dblPotega16
        Loop

    End Sub
    Private Sub KonwertujWynikDecNaHex(ByRef dblDec As Double)
        Select Case dblDec
            Case 1, 2, 3, 4, 5, 6, 7, 8, 9
                strWynik = CStr(dblWynik)
            Case 10
                strWynik = "A"
            Case 11
                strWynik = "B"
            Case 12
                strWynik = "C"
            Case 13
                strWynik = "D"
            Case 14
                strWynik = "E"
            Case 15
                strWynik = "F"
            Case 16
                strWynik = "G"
        End Select
    End Sub
End Class
