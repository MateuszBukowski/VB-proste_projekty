Public Class FormularzGlowny
    'Zmienna do daty i czasu
    Private dteAktualnaData As Date
    Private alarm As String
    'Zmienne do stopera
    Private intSetnaSekunda As Integer = 0
    Private intSekunda As Integer = 0
    Private intLicznikSekund As Integer = 0
    Private intMinuta As Integer = 0
    Private intLicznikMinut As Integer = 0
    Private intGodzina As Integer = 0
    Private intLicznikGodzin As Integer = 0
    Private strZeroSekunda As String = "0"
    Private strZeroMinuta As String = "0"
    Private strZeroGodzina As String = "0"
    'Zmienne dla Odliczania
    Private intSekundaOdlicz As Integer = 0
    Private intUstawionaOdliczSekunda As Integer = 0
    Private intUstawionaOdliczMinuta As Integer = 0
    Private intUstawionaOdliczGodzina As Integer = 0
    Private strZeroSekundaOdlicz As String = "0"
    Private strZeroMinutaOdlicz As String = "0"
    Private strZeroGodzinaOdlicz As String = "0"
    'Zmienne dla Interwałów
    Private nudMinutyInterwalX() As NumericUpDown = {nudMinutyInterwal1, nudMinutyInterwal2, nudMinutyInterwal3, nudMinutyInterwal4}
    Private nudSekundyInterwalX() As NumericUpDown = {nudSekundyInterwal1, nudSekundyInterwal2, nudSekundyInterwal3, nudSekundyInterwal4}
    Private lblLabelX() As Label = {lblInterwal1, lblInterwal2, lblInterwal3, lblInterwal4}
    Private intMinutyInterwal(3) As Integer
    Private intSekundyInterwal(3) As Integer
    Private intKtoryInterwal As Integer
    Private strZeroSekundaInterwal As String = "0"
    Private strZeroMinutaInterwal As String = "0"

    'Zegar i data **************************************************************************************************************************************
    Private Sub CzasZegar_Tick(sender As Object, e As EventArgs) Handles czasZegar.Tick
        dteAktualnaData = Date.Now
        lblGodzina.Text = CStr(Format(dteAktualnaData, "HH:mm:ss"))
        lblData.Text = CStr(Format(dteAktualnaData, "dd MMMM, yyyy r."))
        If chbAlarm.Checked Then
            alarm = comboGodziny.Text & ":" & comboMinuty.Text & ":00"
        End If
        If alarm = lblGodzina.Text Then
            Dim intLicznik As Integer
            For intLicznik = 1 To 8 Step 1
                My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
                System.Threading.Thread.Sleep(500)
            Next intLicznik
        End If
    End Sub

    'Stoper **************************************************************************************************************************************
    Private Sub ZwiekszSetneSekundyLicznik()
        If intSetnaSekunda < 9 Then
            intSetnaSekunda = intSetnaSekunda + 1
        Else
            intSetnaSekunda = 0
            intLicznikSekund = intLicznikSekund + 1
            If intSekunda < 59 Then
                intSekunda = intSekunda + 1
            End If
        End If
    End Sub
    Private Sub ZwiekszSekundyLicznik()
        If intLicznikSekund <= 59 Then
            ZwiekszSetneSekundyLicznik()
            If intSekunda > 9 Then
                strZeroSekunda = ""
            Else
                strZeroSekunda = "0"
            End If
        Else
            intSekunda = 0
            intLicznikSekund = 0
            intLicznikMinut = intLicznikMinut + 1
            If intMinuta < 59 Then
                intMinuta = intMinuta + 1
            End If
        End If
    End Sub
    Private Sub ZwiekszMinutyLicznik()
        If intLicznikMinut <= 59 Then
            ZwiekszSekundyLicznik()
            If intMinuta > 9 Then
                strZeroMinuta = ""
            Else
                strZeroMinuta = "0"
            End If
        Else
            intMinuta = 0
            intLicznikMinut = 0
            intLicznikGodzin = intLicznikGodzin + 1
            If intGodzina < 59 Then
                intGodzina = intGodzina + 1
            End If
        End If
    End Sub
    Private Sub ZwiekszGodzinyLicznik()
        If intLicznikGodzin <= 59 Then
            ZwiekszMinutyLicznik()
            If intGodzina > 9 Then
                strZeroGodzina = ""
            Else
                strZeroGodzina = "0"
            End If
        Else
            czasStoper.Enabled = False
        End If
    End Sub
    Private Sub CzasStoper_Tick(sender As Object, e As EventArgs) Handles czasStoper.Tick
        lblStoper.Text = CStr(strZeroGodzina & intGodzina & ":" & strZeroMinuta & intMinuta & ":" & strZeroSekunda & intSekunda & ":0" & intSetnaSekunda)
        ZwiekszGodzinyLicznik()
    End Sub
    Private Sub BtnStartStoper_Click(sender As Object, e As EventArgs) Handles btnStartStoper.Click
        czasStoper.Enabled = True
    End Sub
    Private Sub BtnStopStoper_Click(sender As Object, e As EventArgs) Handles btnStopStoper.Click
        czasStoper.Enabled = False
    End Sub
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Zerowanie
        intSetnaSekunda = 0
        intSekunda = 0
        intMinuta = 0
        intGodzina = 0
        strZeroSekunda = "0"
        strZeroMinuta = "0"
        strZeroGodzina = "0"
        lblStoper.Text = "00:00:00:00"
    End Sub

    'Odliczanie **************************************************************************************************************************************
    Private Sub odliczSekundy()
        If intUstawionaOdliczSekunda <= 10 Then
            strZeroSekundaOdlicz = "0"
        Else
            strZeroSekundaOdlicz = ""
        End If
        If intUstawionaOdliczSekunda > 0 Then
            intUstawionaOdliczSekunda = intUstawionaOdliczSekunda - 1
        Else
            odliczMinuty()
        End If
    End Sub
    Private Sub odliczMinuty()
        If intUstawionaOdliczMinuta <= 10 Then
            strZeroMinutaOdlicz = "0"
        Else
            strZeroMinutaOdlicz = ""
        End If
        If intUstawionaOdliczMinuta > 0 Then
            intUstawionaOdliczMinuta = intUstawionaOdliczMinuta - 1
            intUstawionaOdliczSekunda = 59
            strZeroSekundaOdlicz = ""
        Else
            odliczGodziny()
        End If
    End Sub
    Private Sub odliczGodziny()
        If intUstawionaOdliczGodzina <= 10 Then
            strZeroGodzinaOdlicz = "0"
        Else
            strZeroGodzinaOdlicz = ""
        End If
        If intUstawionaOdliczGodzina > 0 Then
            intUstawionaOdliczGodzina = intUstawionaOdliczGodzina - 1
            intUstawionaOdliczMinuta = 59
            strZeroMinutaOdlicz = ""
        End If

    End Sub
    Private Sub CzasOdliczanie_Tick(sender As Object, e As EventArgs) Handles czasOdliczanie.Tick
        If lblOdliczanie.Text = "00:00:00" Then
            Dim intLicznik As Integer
            For intLicznik = 1 To 8 Step 1
                My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
                System.Threading.Thread.Sleep(500)
                'Inne dzwieki systemowe
                'My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Beep)
                'My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Exclamation)
                'My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Hand)
            Next intLicznik
            czasOdliczanie.Enabled = False
        Else
            lblOdliczanie.Text = CStr(strZeroGodzinaOdlicz & intUstawionaOdliczGodzina & ":" & strZeroMinutaOdlicz & intUstawionaOdliczMinuta & ":" & strZeroSekundaOdlicz & intUstawionaOdliczSekunda)
            odliczSekundy()
        End If

    End Sub
    Private Sub BtnStartOdliczanie_Click(sender As Object, e As EventArgs) Handles btnStartOdliczanie.Click
        czasOdliczanie.Enabled = True
    End Sub
    Private Sub BtnStopOdliczanie_Click(sender As Object, e As EventArgs) Handles btnStopOdliczanie.Click
        czasOdliczanie.Enabled = False
    End Sub
    Private Sub BtnUstawOdliczanie_Click(sender As Object, e As EventArgs) Handles btnUstawOdliczanie.Click
        'Pobierz godziny,minuty i sekundy z pól NumUpDown i wstaw do zmiennych
        intUstawionaOdliczSekunda = CInt(numudSekundyOdliczanie.Value)
        intUstawionaOdliczMinuta = CInt(numudMinutyOdliczanie.Value)
        intUstawionaOdliczGodzina = CInt(numudGodzinyOdliczanie.Value)
        'Ustaw zera na początku godzin, minut i sekund
        If intUstawionaOdliczSekunda <= 9 Then
            strZeroSekundaOdlicz = "0"
        Else
            strZeroSekundaOdlicz = ""
        End If
        If intUstawionaOdliczMinuta <= 9 Then
            strZeroMinutaOdlicz = "0"
        Else
            strZeroMinutaOdlicz = ""
        End If
        If intUstawionaOdliczGodzina <= 9 Then
            strZeroGodzinaOdlicz = "0"
        Else
            strZeroGodzinaOdlicz = ""
        End If
        'Wstaw do pola etykiety
        lblOdliczanie.Text = CStr(strZeroGodzinaOdlicz & intUstawionaOdliczGodzina & ":" & strZeroMinutaOdlicz & intUstawionaOdliczMinuta & ":" & strZeroSekundaOdlicz & intUstawionaOdliczSekunda)
    End Sub

    'Interwały **************************************************************************************************************************************
    Private Sub ustawZera(ByVal uzInterwal As Integer, ByVal MinSek As String)
        If MinSek = "sekundy" Then
            If intSekundyInterwal(uzInterwal) < 10 Then
                strZeroSekundaInterwal = "0"
            Else
                strZeroSekundaInterwal = ""
            End If
        ElseIf MinSek = "minuty" Then
            If intMinutyInterwal(uzInterwal) < 10 Then
                strZeroMinutaInterwal = "0"
            Else
                strZeroMinutaInterwal = ""
            End If
        End If
    End Sub
    Private Sub odliczSekundyInterwalu(ByVal osiInterwal As Integer)
        ustawZera(osiInterwal, "sekundy")
        If intSekundyInterwal(osiInterwal) > 0 Then
            intSekundyInterwal(osiInterwal) = intSekundyInterwal(osiInterwal) - 1
        Else
            odliczMinutyInterwalu(osiInterwal)
        End If
    End Sub
    Private Sub odliczMinutyInterwalu(ByVal omiInterwal As Integer)
        ustawZera(omiInterwal, "minuty")
        If intMinutyInterwal(omiInterwal) > 0 Then
            intMinutyInterwal(omiInterwal) = intMinutyInterwal(omiInterwal) - 1
            intSekundyInterwal(intKtoryInterwal) = 59
            strZeroSekundaInterwal = ""
        Else
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
            intKtoryInterwal = intKtoryInterwal + 1
        End If
    End Sub
    Private Sub CzasInterwal_Tick(sender As Object, e As EventArgs) Handles czasInterwal.Tick
        If intKtoryInterwal < 4 Then
            ustawZera(intKtoryInterwal, "minuty")
            ustawZera(intKtoryInterwal, "sekundy")
            lblLabelX(intKtoryInterwal).Text = strZeroMinutaInterwal.ToString & intMinutyInterwal(intKtoryInterwal).ToString & ":" & strZeroSekundaInterwal.ToString & intSekundyInterwal(intKtoryInterwal).ToString
            odliczSekundyInterwalu(intKtoryInterwal)
        Else
            For intLicznik As Integer = 1 To 6 Step 1
                My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
                System.Threading.Thread.Sleep(1000)
                'Inne dzwieki systemowe
                'My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Beep)
                'My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Exclamation)
                'My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Hand)
            Next intLicznik
            czasInterwal.Enabled = False
        End If
    End Sub
    Private Sub BtnStartInterwaly_Click(sender As Object, e As EventArgs) Handles btnStartInterwaly.Click
        czasInterwal.Enabled = True
    End Sub
    Private Sub BtnStopInterwaly_Click(sender As Object, e As EventArgs) Handles btnStopInterwaly.Click
        czasInterwal.Enabled = False
    End Sub
    Private Sub BtnUstawInterwaly_Click(sender As Object, e As EventArgs) Handles btnUstawInterwaly.Click
        ' Zapisanie nazw kontrolek do tablic.
        ' Tablica - nudMinutyInterwalX() - posiada zapisane nazwy kontrolek: minut
        ' Tablica - nudSekundyInterwalX() - posiada zapisane nazwy kontrolek: sekund
        ' Tablica - lblLabelX() - posiada zapisane nazwy kontrolek: label1 - 4  
        ' Tablica - intMinutyInterwal(3) - posiada wartośći z pol numUpDown typu Decimal
        ' Tablica - intSekundyInterwal(3) - posiada wartośći z pol numUpDown typu Decimal
        ' *******************************************************************************
        ' Etykiety
        lblLabelX(0) = lblInterwal1
        lblLabelX(1) = lblInterwal2
        lblLabelX(2) = lblInterwal3
        lblLabelX(3) = lblInterwal4
        ' Pola numeryczne minut
        nudMinutyInterwalX(0) = nudMinutyInterwal1
        nudMinutyInterwalX(1) = nudMinutyInterwal2
        nudMinutyInterwalX(2) = nudMinutyInterwal3
        nudMinutyInterwalX(3) = nudMinutyInterwal4
        ' Pola numeryczne sekund
        nudSekundyInterwalX(0) = nudSekundyInterwal1
        nudSekundyInterwalX(1) = nudSekundyInterwal2
        nudSekundyInterwalX(2) = nudSekundyInterwal3
        nudSekundyInterwalX(3) = nudSekundyInterwal4
        'Wpisanie wartođci kontrolek NumericUpDown do tablic sekundy i minuty, potrzebne do wykonania odliczania.
        For indexInterwal As Integer = 0 To 3 Step 1
            intMinutyInterwal(indexInterwal) = CInt(nudMinutyInterwalX(indexInterwal).Value)
            intSekundyInterwal(indexInterwal) = CInt(nudSekundyInterwalX(indexInterwal).Value)
        Next indexInterwal
        ' Wpisanie do etykiet wartości z pól NumUpDown, wybranych przez użytkownika
        For labelIndex As Integer = 0 To 3 Step 1
            ustawZera(labelIndex, "minuty")
            ustawZera(labelIndex, "sekundy")
            lblLabelX(labelIndex).Text = strZeroMinutaInterwal.ToString & nudMinutyInterwalX(labelIndex).Value.ToString & ":" & strZeroSekundaInterwal.ToString & nudSekundyInterwalX(labelIndex).Value.ToString
        Next labelIndex
        ' Ustaw pierwszy interwał
        intKtoryInterwal = 0
    End Sub
End Class
