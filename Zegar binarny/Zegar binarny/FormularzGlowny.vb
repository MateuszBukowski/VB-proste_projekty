Public Class FormularzGlowny

    Private Sub TmrAktualnyCzas_Tick(sender As Object, e As EventArgs) Handles tmrAktualnyCzas.Tick
        Dim intCzas As Integer = 0
        Dim strCzas As String = ""
        'Przygotuj godzinę i wstaw do etykiety lblGodziny
        intCzas = FormatujCzas("h")
        strCzas = KonwertujDecNaBin(intCzas)
        lblGodziny.Text = "H: " & SprawdzZera(strCzas)
        'Przygotuj minutę i wstaw do etykiety lblMinuty
        intCzas = FormatujCzas("m")
        strCzas = KonwertujDecNaBin(intCzas)
        lblMinuty.Text = "M: " & SprawdzZera(strCzas)
        'Przygotuj sekundę i wstaw do etykiety lblSekundy
        intCzas = FormatujCzas("s")
        strCzas = KonwertujDecNaBin(intCzas)
        lblSekundy.Text = "S: " & SprawdzZera(strCzas)
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
    Private Function FormatujCzas(ByVal strCzasWybierz As String) As Integer
        Dim intFormatowanyCzasBin As Integer
        Dim dteAktualnaData As Date
        dteAktualnaData = Date.Now
        Select Case strCzasWybierz
            Case "h"
                intFormatowanyCzasBin = CInt(Format(dteAktualnaData, "HH"))
            Case "m"
                intFormatowanyCzasBin = CInt(Format(dteAktualnaData, "mm"))
            Case "s"
                intFormatowanyCzasBin = CInt(Format(dteAktualnaData, "ss"))
        End Select

        Return intFormatowanyCzasBin
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

End Class
