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
        Me.btnUstaw = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.lblPotega2 = New System.Windows.Forms.Label()
        Me.lblGodziny = New System.Windows.Forms.Label()
        Me.lblMinuty = New System.Windows.Forms.Label()
        Me.lblSekundy = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.lblWybierzGodziny = New System.Windows.Forms.Label()
        Me.lblWybierzMinuty = New System.Windows.Forms.Label()
        Me.lblWybierSekundy = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnUstaw
        '
        Me.btnUstaw.Location = New System.Drawing.Point(21, 27)
        Me.btnUstaw.Name = "btnUstaw"
        Me.btnUstaw.Size = New System.Drawing.Size(75, 23)
        Me.btnUstaw.TabIndex = 0
        Me.btnUstaw.Text = "Ustaw"
        Me.btnUstaw.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(126, 27)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(222, 27)
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
        Me.lblPotega2.Location = New System.Drawing.Point(70, 162)
        Me.lblPotega2.Name = "lblPotega2"
        Me.lblPotega2.Size = New System.Drawing.Size(227, 31)
        Me.lblPotega2.TabIndex = 3
        Me.lblPotega2.Text = "64 32 16 8  4  2  1"
        '
        'lblGodziny
        '
        Me.lblGodziny.AutoSize = True
        Me.lblGodziny.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblGodziny.Location = New System.Drawing.Point(10, 196)
        Me.lblGodziny.Name = "lblGodziny"
        Me.lblGodziny.Size = New System.Drawing.Size(305, 63)
        Me.lblGodziny.TabIndex = 4
        Me.lblGodziny.Text = "H: 0000000"
        '
        'lblMinuty
        '
        Me.lblMinuty.AutoSize = True
        Me.lblMinuty.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblMinuty.Location = New System.Drawing.Point(2, 273)
        Me.lblMinuty.Name = "lblMinuty"
        Me.lblMinuty.Size = New System.Drawing.Size(311, 63)
        Me.lblMinuty.TabIndex = 5
        Me.lblMinuty.Text = "M: 0000000"
        '
        'lblSekundy
        '
        Me.lblSekundy.AutoSize = True
        Me.lblSekundy.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblSekundy.Location = New System.Drawing.Point(10, 344)
        Me.lblSekundy.Name = "lblSekundy"
        Me.lblSekundy.Size = New System.Drawing.Size(302, 63)
        Me.lblSekundy.TabIndex = 6
        Me.lblSekundy.Text = "S: 0000000"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(21, 90)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(60, 21)
        Me.ComboBox1.TabIndex = 8
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(126, 90)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(60, 21)
        Me.ComboBox2.TabIndex = 9
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(222, 90)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(60, 21)
        Me.ComboBox3.TabIndex = 10
        '
        'lblWybierzGodziny
        '
        Me.lblWybierzGodziny.AutoSize = True
        Me.lblWybierzGodziny.Location = New System.Drawing.Point(18, 68)
        Me.lblWybierzGodziny.Name = "lblWybierzGodziny"
        Me.lblWybierzGodziny.Size = New System.Drawing.Size(48, 13)
        Me.lblWybierzGodziny.TabIndex = 11
        Me.lblWybierzGodziny.Text = "Godziny:"
        '
        'lblWybierzMinuty
        '
        Me.lblWybierzMinuty.AutoSize = True
        Me.lblWybierzMinuty.Location = New System.Drawing.Point(123, 68)
        Me.lblWybierzMinuty.Name = "lblWybierzMinuty"
        Me.lblWybierzMinuty.Size = New System.Drawing.Size(41, 13)
        Me.lblWybierzMinuty.TabIndex = 12
        Me.lblWybierzMinuty.Text = "Minuty:"
        '
        'lblWybierSekundy
        '
        Me.lblWybierSekundy.AutoSize = True
        Me.lblWybierSekundy.Location = New System.Drawing.Point(219, 68)
        Me.lblWybierSekundy.Name = "lblWybierSekundy"
        Me.lblWybierSekundy.Size = New System.Drawing.Size(52, 13)
        Me.lblWybierSekundy.TabIndex = 13
        Me.lblWybierSekundy.Text = "Sekundy:"
        '
        'FormularzGlowny
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 421)
        Me.Controls.Add(Me.lblWybierSekundy)
        Me.Controls.Add(Me.lblWybierzMinuty)
        Me.Controls.Add(Me.lblWybierzGodziny)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.ComboBox1)
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
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents lblWybierzGodziny As Label
    Friend WithEvents lblWybierzMinuty As Label
    Friend WithEvents lblWybierSekundy As Label
End Class
