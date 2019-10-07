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
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnStop = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblGodziny = New System.Windows.Forms.Label()
        Me.lblMinuty = New System.Windows.Forms.Label()
        Me.lblSekundy = New System.Windows.Forms.Label()
        Me.lblMiliSekundy = New System.Windows.Forms.Label()
        Me.lblPotega16 = New System.Windows.Forms.Label()
        Me.TmrCzas = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btnStart
        '
        Me.btnStart.Location = New System.Drawing.Point(244, 85)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(75, 23)
        Me.btnStart.TabIndex = 0
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnStop
        '
        Me.btnStop.Location = New System.Drawing.Point(244, 149)
        Me.btnStop.Name = "btnStop"
        Me.btnStop.Size = New System.Drawing.Size(75, 23)
        Me.btnStop.TabIndex = 1
        Me.btnStop.Text = "Stop"
        Me.btnStop.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(244, 217)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblGodziny
        '
        Me.lblGodziny.AutoSize = True
        Me.lblGodziny.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblGodziny.Location = New System.Drawing.Point(54, 74)
        Me.lblGodziny.Name = "lblGodziny"
        Me.lblGodziny.Size = New System.Drawing.Size(155, 63)
        Me.lblGodziny.TabIndex = 9
        Me.lblGodziny.Text = "H: 00"
        '
        'lblMinuty
        '
        Me.lblMinuty.AutoSize = True
        Me.lblMinuty.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblMinuty.Location = New System.Drawing.Point(48, 137)
        Me.lblMinuty.Name = "lblMinuty"
        Me.lblMinuty.Size = New System.Drawing.Size(161, 63)
        Me.lblMinuty.TabIndex = 10
        Me.lblMinuty.Text = "M: 00"
        '
        'lblSekundy
        '
        Me.lblSekundy.AutoSize = True
        Me.lblSekundy.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblSekundy.Location = New System.Drawing.Point(54, 200)
        Me.lblSekundy.Name = "lblSekundy"
        Me.lblSekundy.Size = New System.Drawing.Size(152, 63)
        Me.lblSekundy.TabIndex = 11
        Me.lblSekundy.Text = "S: 00"
        '
        'lblMiliSekundy
        '
        Me.lblMiliSekundy.AutoSize = True
        Me.lblMiliSekundy.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblMiliSekundy.Location = New System.Drawing.Point(12, 263)
        Me.lblMiliSekundy.Name = "lblMiliSekundy"
        Me.lblMiliSekundy.Size = New System.Drawing.Size(197, 63)
        Me.lblMiliSekundy.TabIndex = 12
        Me.lblMiliSekundy.Text = "mS: 00"
        '
        'lblPotega16
        '
        Me.lblPotega16.AutoSize = True
        Me.lblPotega16.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblPotega16.Location = New System.Drawing.Point(106, 19)
        Me.lblPotega16.Name = "lblPotega16"
        Me.lblPotega16.Size = New System.Drawing.Size(96, 31)
        Me.lblPotega16.TabIndex = 13
        Me.lblPotega16.Text = "256 16"
        '
        'TmrCzas
        '
        Me.TmrCzas.Interval = 1000
        '
        'FormularzGlowny
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 352)
        Me.Controls.Add(Me.lblPotega16)
        Me.Controls.Add(Me.lblMiliSekundy)
        Me.Controls.Add(Me.lblSekundy)
        Me.Controls.Add(Me.lblMinuty)
        Me.Controls.Add(Me.lblGodziny)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnStop)
        Me.Controls.Add(Me.btnStart)
        Me.Name = "FormularzGlowny"
        Me.Text = "Stoper HEX"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnStart As Button
    Friend WithEvents btnStop As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents lblGodziny As Label
    Friend WithEvents lblMinuty As Label
    Friend WithEvents lblSekundy As Label
    Friend WithEvents lblMiliSekundy As Label
    Friend WithEvents lblPotega16 As Label
    Friend WithEvents TmrCzas As Timer
End Class
