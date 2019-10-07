Public Class FormularzGlowny
    Private intMiliSekundy As Integer = 0
    Private intSekundy As Integer = 0
    Private intMinuty As Integer = 0
    Private intGodziny As Integer = 0
    Private dblWynik As Double
    Private strWynikDecHex As String
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lblGodziny.Text = "H: 00"
        lblMinuty.Text = "M: 00"
        lblSekundy.Text = "S: 00"
        lblMiliSekundy.Text = "mS: 000"
    End Sub
    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        TmrCzas.Enabled = True
    End Sub
    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        TmrCzas.Enabled = False
    End Sub
    Private Sub TmrCzas_Tick(sender As Object, e As EventArgs) Handles TmrCzas.Tick
        ZwiekszMiliSekundy()
    End Sub
    Private Sub ZwiekszMiliSekundy()
        Dim strMiliSekundyHEX As String
        If intMiliSekundy <= 100 Then
            intMiliSekundy = intMiliSekundy + 1
            strMiliSekundyHEX = KonwertujDecNaHex(CStr(intMiliSekundy))
            'strMiliSekundyHEX = SprawdzZera(strMiliSekundyHEX)
            lblMiliSekundy.Text = "mS: " & strMiliSekundyHEX
        Else
            intMiliSekundy = 0
            ZwiekszSekundy()
        End If
    End Sub
    Private Sub ZwiekszSekundy()
        Dim strSekundyHEX As String
        If intSekundy <= 60 Then
            intSekundy = intSekundy + 1
            strSekundyHEX = KonwertujDecNaHex(CStr(intSekundy))
            'strSekundyHEX = SprawdzZera(strSekundyHEX)
            lblSekundy.Text = "S: " & strSekundyHEX
        Else
            intSekundy = 0
            ZwiekszMinuty()
        End If
    End Sub
    Private Sub ZwiekszMinuty()
        Dim strMinutyHEX As String
        If intMinuty <= 60 Then
            intMinuty = intMinuty + 1
            strMinutyHEX = KonwertujDecNaHex(CStr(intMinuty))
            'strMinutyHEX = SprawdzZera(strMinutyHEX)
            lblMinuty.Text = "M: " & strMinutyHEX
        Else
            intMinuty = 0
            ZwiekszGodziny()
        End If
    End Sub
    Private Sub ZwiekszGodziny()
        Dim strGodzinyHEX As String
        If intGodziny <= 60 Then
            intGodziny = intGodziny + 1
            strGodzinyHEX = KonwertujDecNaHex(CStr(intGodziny))
            'strGodzinyHEX = SprawdzZera(strGodzinyHEX)
            lblGodziny.Text = "H: " & strGodzinyHEX
        Else
            TmrCzas.Enabled = False
        End If
    End Sub
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
    Private Function KonwertujDecNaHex(ByRef strLiczbaDec As String) As String
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
        If dblOblicz <= 16 Then
            dblWynik = CDbl(strLiczbaDec)
            strGotowyWynik = KonwertujWynikDecNaHex(dblOblicz)
        Else
            strGotowyWynik = strGotowyWynik & KonwertujWynikDecNaHex(dblOblicz)
        End If
        Return strGotowyWynik
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
    Private Function SprawdzZera(ByVal strCzas As String) As String
        Dim intIloscZnakow As Integer = 0
        Dim intIleZerDodac As Integer = 0
        Dim strCzasUstawioneZera As String = ""
        intIloscZnakow = CInt(Len(strCzas))
        If intIloscZnakow < 2 Then
            intIleZerDodac = 2 - intIloscZnakow
            strCzasUstawioneZera = strCzas
            For index As Integer = intIleZerDodac To 1 Step -1
                strCzasUstawioneZera = "0" & strCzasUstawioneZera
            Next
        Else
            strCzasUstawioneZera = strCzas
        End If
        Return strCzasUstawioneZera
    End Function
End Class
