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
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.lblPotegi2 = New System.Windows.Forms.Label()
        Me.lblGodziny = New System.Windows.Forms.Label()
        Me.lblMinuty = New System.Windows.Forms.Label()
        Me.lblSekundy = New System.Windows.Forms.Label()
        Me.tmrCzas = New System.Windows.Forms.Timer(Me.components)
        Me.lblMiliSekundy = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(422, 94)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 0
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(422, 151)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(422, 212)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 2
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'lblPotegi2
        '
        Me.lblPotegi2.AutoSize = True
        Me.lblPotegi2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblPotegi2.Location = New System.Drawing.Point(148, 32)
        Me.lblPotegi2.Name = "lblPotegi2"
        Me.lblPotegi2.Size = New System.Drawing.Size(204, 31)
        Me.lblPotegi2.TabIndex = 3
        Me.lblPotegi2.Text = "32 16  8  4  2  1 "
        '
        'lblGodziny
        '
        Me.lblGodziny.AutoSize = True
        Me.lblGodziny.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblGodziny.Location = New System.Drawing.Point(80, 63)
        Me.lblGodziny.Name = "lblGodziny"
        Me.lblGodziny.Size = New System.Drawing.Size(275, 63)
        Me.lblGodziny.TabIndex = 4
        Me.lblGodziny.Text = "H: 000000"
        '
        'lblMinuty
        '
        Me.lblMinuty.AutoSize = True
        Me.lblMinuty.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblMinuty.Location = New System.Drawing.Point(71, 126)
        Me.lblMinuty.Name = "lblMinuty"
        Me.lblMinuty.Size = New System.Drawing.Size(281, 63)
        Me.lblMinuty.TabIndex = 5
        Me.lblMinuty.Text = "M: 000000"
        '
        'lblSekundy
        '
        Me.lblSekundy.AutoSize = True
        Me.lblSekundy.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblSekundy.Location = New System.Drawing.Point(80, 189)
        Me.lblSekundy.Name = "lblSekundy"
        Me.lblSekundy.Size = New System.Drawing.Size(272, 63)
        Me.lblSekundy.TabIndex = 6
        Me.lblSekundy.Text = "S: 000000"
        '
        'tmrCzas
        '
        Me.tmrCzas.Interval = 10
        '
        'lblMiliSekundy
        '
        Me.lblMiliSekundy.AutoSize = True
        Me.lblMiliSekundy.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblMiliSekundy.Location = New System.Drawing.Point(32, 252)
        Me.lblMiliSekundy.Name = "lblMiliSekundy"
        Me.lblMiliSekundy.Size = New System.Drawing.Size(347, 63)
        Me.lblMiliSekundy.TabIndex = 7
        Me.lblMiliSekundy.Text = "mS: 0000000"
        '
        'FormularzGlowny
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(546, 341)
        Me.Controls.Add(Me.lblMiliSekundy)
        Me.Controls.Add(Me.lblSekundy)
        Me.Controls.Add(Me.lblMinuty)
        Me.Controls.Add(Me.lblGodziny)
        Me.Controls.Add(Me.lblPotegi2)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnReset)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Name = "FormularzGlowny"
        Me.Text = "Stoper binarny"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnReset As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents lblPotegi2 As Label
    Friend WithEvents lblGodziny As Label
    Friend WithEvents lblMinuty As Label
    Friend WithEvents lblSekundy As Label
    Friend WithEvents tmrCzas As Timer
    Friend WithEvents lblMiliSekundy As Label
End Class
