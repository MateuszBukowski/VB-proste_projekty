<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularzGlowny
    Inherits System.Windows.Forms.Form

    'Formularz przesłania metodę dispose, aby wyczyścić listę składników.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wymagane przez Projektanta formularzy systemu Windows
    Private components As System.ComponentModel.IContainer

    'UWAGA: następująca procedura jest wymagana przez Projektanta formularzy systemu Windows
    'Możesz to modyfikować, używając Projektanta formularzy systemu Windows. 
    'Nie należy modyfikować za pomocą edytora kodu.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnUstaw = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.lblPotega2 = New System.Windows.Forms.Label()
        Me.lblGodziny = New System.Windows.Forms.Label()
        Me.lblMinuty = New System.Windows.Forms.Label()
        Me.lblSekundy = New System.Windows.Forms.Label()
        Me.cobGodziny = New System.Windows.Forms.ComboBox()
        Me.cobMinuty = New System.Windows.Forms.ComboBox()
        Me.cobSekundy = New System.Windows.Forms.ComboBox()
        Me.lblWybierzGodziny = New System.Windows.Forms.Label()
        Me.lblWybierzMinuty = New System.Windows.Forms.Label()
        Me.lblWybierSekundy = New System.Windows.Forms.Label()
        Me.tmrOdlicz = New System.Windows.Forms.Timer(Me.components)
        Me.btnReset = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnUstaw
        '
        Me.btnUstaw.Location = New System.Drawing.Point(54, 12)
        Me.btnUstaw.Name = "btnUstaw"
        Me.btnUstaw.Size = New System.Drawing.Size(75, 23)
        Me.btnUstaw.TabIndex = 0
        Me.btnUstaw.Text = "Ustaw"
        Me.btnUstaw.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(160, 12)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(160, 41)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 2
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'lblPotega2
        '
        Me.lblPotega2.AutoSize = True
        Me.lblPotega2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblPotega2.Location = New System.Drawing.Point(81, 165)
        Me.lblPotega2.Name = "lblPotega2"
        Me.lblPotega2.Size = New System.Drawing.Size(190, 31)
        Me.lblPotega2.TabIndex = 3
        Me.lblPotega2.Text = "32 16 8  4  2  1"
        '
        'lblGodziny
        '
        Me.lblGodziny.AutoSize = True
        Me.lblGodziny.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblGodziny.Location = New System.Drawing.Point(10, 196)
        Me.lblGodziny.Name = "lblGodziny"
        Me.lblGodziny.Size = New System.Drawing.Size(275, 63)
        Me.lblGodziny.TabIndex = 4
        Me.lblGodziny.Text = "H: 000000"
        '
        'lblMinuty
        '
        Me.lblMinuty.AutoSize = True
        Me.lblMinuty.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblMinuty.Location = New System.Drawing.Point(2, 273)
        Me.lblMinuty.Name = "lblMinuty"
        Me.lblMinuty.Size = New System.Drawing.Size(281, 63)
        Me.lblMinuty.TabIndex = 5
        Me.lblMinuty.Text = "M: 000000"
        '
        'lblSekundy
        '
        Me.lblSekundy.AutoSize = True
        Me.lblSekundy.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblSekundy.Location = New System.Drawing.Point(10, 344)
        Me.lblSekundy.Name = "lblSekundy"
        Me.lblSekundy.Size = New System.Drawing.Size(272, 63)
        Me.lblSekundy.TabIndex = 6
        Me.lblSekundy.Text = "S: 000000"
        '
        'cobGodziny
        '
        Me.cobGodziny.FormattingEnabled = True
        Me.cobGodziny.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "12"})
        Me.cobGodziny.Location = New System.Drawing.Point(21, 105)
        Me.cobGodziny.Name = "cobGodziny"
        Me.cobGodziny.Size = New System.Drawing.Size(60, 21)
        Me.cobGodziny.TabIndex = 8
        Me.cobGodziny.Text = "0"
        '
        'cobMinuty
        '
        Me.cobMinuty.FormattingEnabled = True
        Me.cobMinuty.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.cobMinuty.Location = New System.Drawing.Point(126, 105)
        Me.cobMinuty.Name = "cobMinuty"
        Me.cobMinuty.Size = New System.Drawing.Size(60, 21)
        Me.cobMinuty.TabIndex = 9
        Me.cobMinuty.Text = "0"
        '
        'cobSekundy
        '
        Me.cobSekundy.FormattingEnabled = True
        Me.cobSekundy.Items.AddRange(New Object() {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "33", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.cobSekundy.Location = New System.Drawing.Point(222, 105)
        Me.cobSekundy.Name = "cobSekundy"
        Me.cobSekundy.Size = New System.Drawing.Size(60, 21)
        Me.cobSekundy.TabIndex = 10
        Me.cobSekundy.Text = "0"
        '
        'lblWybierzGodziny
        '
        Me.lblWybierzGodziny.AutoSize = True
        Me.lblWybierzGodziny.Location = New System.Drawing.Point(18, 83)
        Me.lblWybierzGodziny.Name = "lblWybierzGodziny"
        Me.lblWybierzGodziny.Size = New System.Drawing.Size(48, 13)
        Me.lblWybierzGodziny.TabIndex = 11
        Me.lblWybierzGodziny.Text = "Godziny:"
        '
        'lblWybierzMinuty
        '
        Me.lblWybierzMinuty.AutoSize = True
        Me.lblWybierzMinuty.Location = New System.Drawing.Point(123, 83)
        Me.lblWybierzMinuty.Name = "lblWybierzMinuty"
        Me.lblWybierzMinuty.Size = New System.Drawing.Size(41, 13)
        Me.lblWybierzMinuty.TabIndex = 12
        Me.lblWybierzMinuty.Text = "Minuty:"
        '
        'lblWybierSekundy
        '
        Me.lblWybierSekundy.AutoSize = True
        Me.lblWybierSekundy.Location = New System.Drawing.Point(219, 83)
        Me.lblWybierSekundy.Name = "lblWybierSekundy"
        Me.lblWybierSekundy.Size = New System.Drawing.Size(52, 13)
        Me.lblWybierSekundy.TabIndex = 13
        Me.lblWybierSekundy.Text = "Sekundy:"
        '
        'tmrOdlicz
        '
        Me.tmrOdlicz.Interval = 1000
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(54, 41)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'FormularzGlowny
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(314, 416)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblWybierSekundy)
        Me.Controls.Add(Me.lblWybierzMinuty)
        Me.Controls.Add(Me.lblWybierzGodziny)
        Me.Controls.Add(Me.cobSekundy)
        Me.Controls.Add(Me.cobMinuty)
        Me.Controls.Add(Me.cobGodziny)
        Me.Controls.Add(Me.lblSekundy)
        Me.Controls.Add(Me.lblMinuty)
        Me.Controls.Add(Me.lblGodziny)
        Me.Controls.Add(Me.lblPotega2)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnUstaw)
        Me.Name = "FormularzGlowny"
        Me.Text = "Minutnik Binarny"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnUstaw As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents lblPotega2 As Label
    Friend WithEvents lblGodziny As Label
    Friend WithEvents lblMinuty As Label
    Friend WithEvents lblSekundy As Label
    Friend WithEvents cobGodziny As ComboBox
    Friend WithEvents cobMinuty As ComboBox
    Friend WithEvents cobSekundy As ComboBox
    Friend WithEvents lblWybierzGodziny As Label
    Friend WithEvents lblWybierzMinuty As Label
    Friend WithEvents lblWybierSekundy As Label
    Friend WithEvents tmrOdlicz As Timer
    Friend WithEvents btnReset As Button
End Class
