Public Class FormularzGlowny
    Private intSekundy As Integer = 0
    Private intMinuty As Integer = 0
    Private intGodziny As Integer = 0
    Private strGodzinyBin As String = ""
    Private strMinutyBin As String = ""
    Private strSekundyBin As String = ""
    Private Sub BtnUstaw_Click(sender As Object, e As EventArgs) Handles btnUstaw.Click
        intGodziny = CInt(cobGodziny.Text)
        UstawGodziny()
        intMinuty = CInt(cobMinuty.Text)
        UstawMinuty()
        intSekundy = CInt(cobSekundy.Text)
        UstawSekundy()
    End Sub
    Private Sub BtnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        tmrOdlicz.Enabled = True
    End Sub
    Private Sub BtnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        tmrOdlicz.Enabled = False
    End Sub
    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        tmrOdlicz.Enabled = False
        intGodziny = 0
        intMinuty = 0
        intSekundy = 0
        UstawGodziny()
        UstawMinuty()
        UstawSekundy()
        cobGodziny.Text = "0"
        cobMinuty.Text = "0"
        cobSekundy.Text = "0"
    End Sub
    Private Sub TmrOdlicz_Tick(sender As Object, e As EventArgs) Handles tmrOdlicz.Tick
        ZmniejszSekundy()
    End Sub
    Private Sub ZmniejszGodziny()

        If intGodziny > 0 Then
            intGodziny = intGodziny - 1
            UstawGodziny()
            intMinuty = 59
            UstawMinuty()
            intSekundy = 59
            UstawSekundy()
        Else
            tmrOdlicz.Enabled = False
            Dim intLicznik As Integer
            For intLicznik = 1 To 8 Step 1
                My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
                System.Threading.Thread.Sleep(500)
            Next intLicznik
        End If
    End Sub
    Private Sub ZmniejszMinuty()
        If intMinuty > 0 Then
            intMinuty = intMinuty - 1
            UstawMinuty()
            intSekundy = 59
            UstawSekundy()
        Else
            ZmniejszGodziny()
        End If
    End Sub
    Private Sub ZmniejszSekundy()
        If intSekundy > 0 Then
            intSekundy = intSekundy - 1
            UstawSekundy()
        Else
            ZmniejszMinuty()
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
    Private Sub UstawSekundy()
        strSekundyBin = KonwertujDecNaBin(intSekundy)
        strSekundyBin = SprawdzZera(strSekundyBin)
        lblSekundy.Text = "S: " & strSekundyBin
    End Sub
    Private Sub UstawMinuty()
        strMinutyBin = KonwertujDecNaBin(intMinuty)
        strMinutyBin = SprawdzZera(strMinutyBin)
        lblMinuty.Text = "M: " & strMinutyBin
    End Sub
    Private Sub UstawGodziny()
        strGodzinyBin = KonwertujDecNaBin(intGodziny)
        strGodzinyBin = SprawdzZera(strGodzinyBin)
        lblGodziny.Text = "H: " & strGodzinyBin
    End Sub
End Class
