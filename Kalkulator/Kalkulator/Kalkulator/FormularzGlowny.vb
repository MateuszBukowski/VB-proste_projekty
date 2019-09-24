Public Class FormularzGlowny
    Private dblPierwszaLiczba As Double
    Private dblDrugaLiczba As Double
    Private znak As String

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        txtWyswietlacz.Text = txtWyswietlacz.Text & "7"
    End Sub
    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        txtWyswietlacz.Text = txtWyswietlacz.Text & "8"
    End Sub
    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        txtWyswietlacz.Text = txtWyswietlacz.Text & "9"
    End Sub
    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        txtWyswietlacz.Text = txtWyswietlacz.Text & "4"
    End Sub
    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        txtWyswietlacz.Text = txtWyswietlacz.Text & "5"
    End Sub
    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        txtWyswietlacz.Text = txtWyswietlacz.Text & "6"
    End Sub
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        txtWyswietlacz.Text = txtWyswietlacz.Text & "1"
    End Sub
    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        txtWyswietlacz.Text = txtWyswietlacz.Text & "2"
    End Sub
    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        txtWyswietlacz.Text = txtWyswietlacz.Text & "3"
    End Sub
    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        txtWyswietlacz.Text = txtWyswietlacz.Text & "0"
    End Sub
    Private Sub BtnPrzecinek_Click(sender As Object, e As EventArgs) Handles btnPrzecinek.Click
        txtWyswietlacz.Text = txtWyswietlacz.Text & ","
    End Sub

    Private Sub BtnDzielenie_Click(sender As Object, e As EventArgs) Handles btnDzielenie.Click
        dblPierwszaLiczba = CInt(txtWyswietlacz.Text)
        znak = "/"
        lblZnak.Text = znak
        txtWyswietlacz.Text = ""
    End Sub
    Private Sub BtnMnozenie_Click(sender As Object, e As EventArgs) Handles btnMnozenie.Click
        dblPierwszaLiczba = CInt(txtWyswietlacz.Text)
        znak = "*"
        lblZnak.Text = znak
        txtWyswietlacz.Text = ""
    End Sub
    Private Sub BtnOdejmowanie_Click(sender As Object, e As EventArgs) Handles btnOdejmowanie.Click
        dblPierwszaLiczba = CInt(txtWyswietlacz.Text)
        znak = "-"
        lblZnak.Text = znak
        txtWyswietlacz.Text = ""
    End Sub
    Private Sub BtnDodawanie_Click(sender As Object, e As EventArgs) Handles btnDodawanie.Click
        dblPierwszaLiczba = CInt(txtWyswietlacz.Text)
        znak = "+"
        lblZnak.Text = znak
        txtWyswietlacz.Text = ""
    End Sub

    Private Sub BtnWynik_Click(sender As Object, e As EventArgs) Handles btnWynik.Click
        Dim dblWynik As Double
        dblDrugaLiczba = CInt(txtWyswietlacz.Text)
        Select Case znak
            Case "/"
                dblWynik = (dblPierwszaLiczba / dblDrugaLiczba)
                txtWyswietlacz.Text = CStr(dblWynik)
            Case "*"
                dblWynik = (dblPierwszaLiczba * dblDrugaLiczba)
                txtWyswietlacz.Text = CStr(dblWynik)
            Case "+"
                dblWynik = (dblPierwszaLiczba + dblDrugaLiczba)
                txtWyswietlacz.Text = CStr(dblWynik)
            Case "-"
                dblWynik = (dblPierwszaLiczba - dblDrugaLiczba)
                txtWyswietlacz.Text = CStr(dblWynik)
        End Select

    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtWyswietlacz.Text = ""
        dblPierwszaLiczba = 0
        dblDrugaLiczba = 0
        znak = ""
    End Sub
End Class
