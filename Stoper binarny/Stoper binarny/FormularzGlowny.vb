Public Class FormularzGlowny
    Private intMiliSekundy As Integer = 0
    Private intSekundy As Integer = 0
    Private intMinuty As Integer = 0
    Private intGodziny As Integer = 0
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lblGodziny.Text = "H: 000000"
        lblMinuty.Text = "M: 000000"
        lblSekundy.Text = "S: 000000"
    End Sub
    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        tmrCzas.Enabled = True
    End Sub
    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        tmrCzas.Enabled = False
    End Sub
    Private Sub TmrCzas_Tick(sender As Object, e As EventArgs) Handles tmrCzas.Tick
        ZwiekszMiliSekundy()
    End Sub
    Private Sub ZwiekszMiliSekundy()
        Dim strMiliSekundyBin As String
        If intMiliSekundy <= 100 Then
            intMiliSekundy = intMiliSekundy + 1
            strMiliSekundyBin = KonwertujDecNaBin(intMiliSekundy)
            strMiliSekundyBin = SprawdzZeraMiliSekundy(strMiliSekundyBin)
            lblMiliSekundy.Text = "mS: " & strMiliSekundyBin
        Else
            intMiliSekundy = 0
            ZwiekszSekundy()
        End If
    End Sub
    Private Sub ZwiekszSekundy()
        Dim strSekundyBin As String
        If intSekundy <= 60 Then
            intSekundy = intSekundy + 1
            strSekundyBin = KonwertujDecNaBin(intSekundy)
            strSekundyBin = SprawdzZera(strSekundyBin)
            lblSekundy.Text = "S: " & strSekundyBin
        Else
            intSekundy = 0
            ZwiekszMinuty()
        End If
    End Sub
    Private Sub ZwiekszMinuty()
        Dim strMinutyBin As String
        If intMinuty <= 60 Then
            intMinuty = intMinuty + 1
            strMinutyBin = KonwertujDecNaBin(intMinuty)
            strMinutyBin = SprawdzZera(strMinutyBin)
            lblMinuty.Text = "M: " & strMinutyBin
        Else
            intMinuty = 0
            ZwiekszGodziny()
        End If
    End Sub
    Private Sub ZwiekszGodziny()
        Dim strGodzinyBin As String
        If intGodziny <= 60 Then
            intGodziny = intGodziny + 1
            strGodzinyBin = KonwertujDecNaBin(intGodziny)
            strGodzinyBin = SprawdzZera(strGodzinyBin)
            lblGodziny.Text = "H: " & strGodzinyBin
        Else
            tmrCzas.Enabled = False
        End If
    End Sub
    Private Function KonwertujDecNaBin(ByVal intCzasDec As Integer) As String
        'Algorytm: dzielimy na dwa i zapisuję resztę z dzielenia 1 lub zero do stringa.
        'Dopólki wynik nie jest mniejszy od 1.
        'Od dołu do góry czytamy (od ostatniego do pierwszego) i wychodzi liczba binarna.
        Dim intLiczba As Integer
        Dim strModulo As String
        intLiczba = intCzasDec
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
    Private Function SprawdzZera(ByVal strCzas As String) As String
        Dim intIloscZnakow As Integer = 0
        Dim intIleZerDodac As Integer = 0
        Dim strCzasUstawioneZera As String = ""
        intIloscZnakow = CInt(Len(strCzas))
        If intIloscZnakow < 6 Then
            intIleZerDodac = 6 - intIloscZnakow
            strCzasUstawioneZera = strCzas
            For index As Integer = intIleZerDodac To 1 Step -1
                strCzasUstawioneZera = "0" & strCzasUstawioneZera
            Next
        Else
            strCzasUstawioneZera = strCzas
        End If
        Return strCzasUstawioneZera
    End Function
    Private Function SprawdzZeraMiliSekundy(ByVal strCzas As String) As String
        Dim intIloscZnakow As Integer = 0
        Dim intIleZerDodac As Integer = 0
        Dim strCzasUstawioneZera As String = ""
        intIloscZnakow = CInt(Len(strCzas))
        If intIloscZnakow < 7 Then
            intIleZerDodac = 7 - intIloscZnakow
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
