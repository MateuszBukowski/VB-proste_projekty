Public Class FormularzGlowny
    Private dblWynik As Double
    Private strWynikDecHex As String
    Private Sub BtnBin_Click(sender As Object, e As EventArgs) Handles btnBin.Click
        If radioBin.Checked = True Then
            lblBin.Text = "BIN: " & textbWprowadz.Text
        ElseIf radioDec.Checked = True Then
            lblBin.Text = "BIN: " & DecToBin(textbWprowadz.Text)
        ElseIf radioHex.Checked = True Then
            lblBin.Text = "BIN: " & HexToBin(textbWprowadz.Text)
        Else
            MessageBox.Show("Wskaż jakiego rodzaju liczbę prowadziłeś.")
        End If
    End Sub
    Private Sub BtnDec_Click(sender As Object, e As EventArgs) Handles btnDec.Click
        If radioBin.Checked = True Then
            lblDec.Text = "DEC: " & BinToDec(textbWprowadz.Text)
        ElseIf radioDec.Checked = True Then
            lblDec.Text = "DEC: " & textbWprowadz.Text
        ElseIf radioHex.Checked = True Then
            lblDec.Text = "DEC: " & HexToDec(textbWprowadz.Text)
        Else
            MessageBox.Show("Wskaż jakiego rodzaju liczbę prowadziłeś.")
        End If
    End Sub
    Private Sub BtnHex_Click(sender As Object, e As EventArgs) Handles btnHex.Click
        If radioBin.Checked = True Then
            lblHex.Text = "HEX: " & BinToHex(textbWprowadz.Text)
        ElseIf radioDec.Checked = True Then
            lblHex.Text = "HEX: " & DecToHex(textbWprowadz.Text)
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
        Dim strWynikHexToBin As String
        strWynikHexToBin = HexToDec(strLiczbaHex)
        strWynikHexToBin = DecToBin(strWynikHexToBin)
        Return strWynikHexToBin
    End Function
    Private Function HexToDec(ByVal strLiczbaHex As String) As String
        'Procedura konwersji z Hex na Dec
        '1 | 2  | 3
        '1 | 16 | 256
        Dim intIloscZnakow As Integer
        Dim dblWynikHex As Double
        Dim dblWynikHexZnak As Double
        Dim strZnakHex As String
        'Długość ciągu znaków
        intIloscZnakow = CInt(Len(strLiczbaHex))
        dblWynikHex = 0
        'Od ostatniego znaku do pierwszego
        For index As Integer = 1 To intIloscZnakow Step 1
            strZnakHex = GetChar(strLiczbaHex, index)
            dblWynikHexZnak = (CDbl(KonwertujCyfreHexNaDec(strZnakHex))) * (16 ^ (index - 1))
            dblWynikHex = dblWynikHexZnak + dblWynikHex
        Next
        Return CStr(dblWynikHex)
    End Function
    Private Function BinToDec(ByVal strLiczbaBin As String) As String
        Dim iloscZnakow As Integer
        Dim potega As Integer
        Dim cyfra As Double
        Dim suma As Double
        Dim temp As String
        Dim strWynik As String
        'Długość ciągu znaków
        iloscZnakow = CInt(Len(strLiczbaBin))
        potega = 0
        suma = 0
        'Od ostatniego znaku do pierwszego
        For index As Integer = iloscZnakow To 1 Step -1
            temp = GetChar(strLiczbaBin, index)
            If temp = "1" Then
                cyfra = (2 ^ potega)
                suma = suma + cyfra
            End If
            potega = potega + 1
        Next index
        strWynik = CStr(suma)
        Return strWynik
    End Function
    Private Function BinToHex(ByVal strLiczbaHex As String) As String
        'bin to hex
        Dim strWynikBinToHex As String
        strWynikBinToHex = BinToDec(strLiczbaHex)
        strWynikBinToHex = DecToHex(strWynikBinToHex)
        Return strWynikBinToHex
    End Function
    Private Function DecToHex(ByRef strLiczbaDec As String) As String
        Dim dblOblicz As Double
        Dim strGotowyWynik As String
        Dim dblMaxPotega As Double
        Debug.WriteLine("**************************************")
        strGotowyWynik = ""
        dblOblicz = CDbl(strLiczbaDec)
        Do While dblOblicz >= 16
            dblMaxPotega = ZnajdzNajwiekszaPotege16(dblOblicz)
            dblWynik = dblOblicz / (16 ^ dblMaxPotega)
            Debug.Write("dblWynik: ")
            Debug.WriteLine(dblWynik)
            dblWynik = Math.Truncate(dblWynik)
            Debug.Write("dblWynik: ")
            Debug.WriteLine(dblWynik)
            strGotowyWynik = strGotowyWynik & KonwertujWynikDecNaHex(dblWynik)
            dblOblicz = dblOblicz - (dblWynik * (16 ^ dblMaxPotega))
        Loop
        'Wstaw resztę
        If CInt(strLiczbaDec) <= 16 Then
            strGotowyWynik = KonwertujWynikDecNaHex(dblOblicz)
        Else
            strGotowyWynik = strGotowyWynik & KonwertujWynikDecNaHex(dblOblicz)
        End If
        Return strGotowyWynik
    End Function
    Private Function DecToBin(ByVal strLiczbaDec As String) As String
        'Procedura zamiany liczb dziesiętnych na system binarny
        'najprostszym sposobem jest Dzielić za każdym razem przez 2 i wpisywać resztę 1 lub 0.
        'Teraz wynik czytamy OD DOŁU DO GÓRY, czyli 1111101
        Dim strWynikiDecToBin As String
        Dim dblWynikiDecToBin As Double
        Dim dblLiczbaDec As Double
        dblLiczbaDec = CDbl(strLiczbaDec)
        strWynikiDecToBin = ""
        Do Until dblLiczbaDec = 0
            Debug.Write("dblLiczbaDec: ")
            Debug.WriteLine(dblLiczbaDec)
            dblWynikiDecToBin = (dblLiczbaDec Mod 2)
            strWynikiDecToBin = CStr(dblWynikiDecToBin) & strWynikiDecToBin
            Debug.Write("strWynikiDecToBin: ")
            Debug.WriteLine(strWynikiDecToBin)
            dblLiczbaDec = Math.Truncate(dblLiczbaDec / 2)
        Loop
        Return strWynikiDecToBin
    End Function
    Private Function ZnajdzNajwiekszaPotege16(ByRef dblLiczba As Double) As Double
        Dim dblPotega16 As Double
        Dim dblWynikPotegi As Double
        Dim dblMaxPotega As Double
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
        Return dblMaxPotega
    End Function
    Private Function KonwertujWynikDecNaHex(ByRef dblDec As Double) As String
        Select Case dblDec
            Case 1, 2, 3, 4, 5, 6, 7, 8, 9
                strWynikDecHex = CStr(dblWynik)
            Case 10
                strWynikDecHex = "A"
            Case 11
                strWynikDecHex = "B"
            Case 12
                strWynikDecHex = "C"
            Case 13
                strWynikDecHex = "D"
            Case 14
                strWynikDecHex = "E"
            Case 15
                strWynikDecHex = "F"
            Case 16
                strWynikDecHex = "G"
        End Select
        Return strWynikDecHex
    End Function
    Private Function KonwertujCyfreHexNaDec(ByRef strHex As String) As String
        Dim strCyfraHexDec As String
        strCyfraHexDec = strHex
        Select Case strHex
            Case "A"
                strCyfraHexDec = "10"
            Case "B"
                strCyfraHexDec = "11"
            Case "C"
                strCyfraHexDec = "12"
            Case "D"
                strCyfraHexDec = "13"
            Case "E"
                strCyfraHexDec = "14"
            Case "F"
                strCyfraHexDec = "15"
            Case "G"
                strCyfraHexDec = "16"
        End Select
        Return strCyfraHexDec
    End Function
End Class
