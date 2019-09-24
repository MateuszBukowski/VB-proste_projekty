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
        Me.textbWprowadz = New System.Windows.Forms.TextBox()
        Me.btnBin = New System.Windows.Forms.Button()
        Me.btnDec = New System.Windows.Forms.Button()
        Me.btnHex = New System.Windows.Forms.Button()
        Me.lblBin = New System.Windows.Forms.Label()
        Me.lblDec = New System.Windows.Forms.Label()
        Me.lblHex = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.radioBin = New System.Windows.Forms.RadioButton()
        Me.radioDec = New System.Windows.Forms.RadioButton()
        Me.radioHex = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'textbWprowadz
        '
        Me.textbWprowadz.Location = New System.Drawing.Point(12, 12)
        Me.textbWprowadz.Name = "textbWprowadz"
        Me.textbWprowadz.Size = New System.Drawing.Size(169, 20)
        Me.textbWprowadz.TabIndex = 0
        '
        'btnBin
        '
        Me.btnBin.Location = New System.Drawing.Point(187, 70)
        Me.btnBin.Name = "btnBin"
        Me.btnBin.Size = New System.Drawing.Size(75, 23)
        Me.btnBin.TabIndex = 1
        Me.btnBin.Text = "BIN"
        Me.btnBin.UseVisualStyleBackColor = True
        '
        'btnDec
        '
        Me.btnDec.Location = New System.Drawing.Point(187, 103)
        Me.btnDec.Name = "btnDec"
        Me.btnDec.Size = New System.Drawing.Size(75, 23)
        Me.btnDec.TabIndex = 2
        Me.btnDec.Text = "DEC"
        Me.btnDec.UseVisualStyleBackColor = True
        '
        'btnHex
        '
        Me.btnHex.Location = New System.Drawing.Point(187, 136)
        Me.btnHex.Name = "btnHex"
        Me.btnHex.Size = New System.Drawing.Size(75, 23)
        Me.btnHex.TabIndex = 3
        Me.btnHex.Text = "HEX"
        Me.btnHex.UseVisualStyleBackColor = True
        '
        'lblBin
        '
        Me.lblBin.AutoSize = True
        Me.lblBin.Location = New System.Drawing.Point(12, 75)
        Me.lblBin.Name = "lblBin"
        Me.lblBin.Size = New System.Drawing.Size(31, 13)
        Me.lblBin.TabIndex = 4
        Me.lblBin.Text = "BIN: "
        '
        'lblDec
        '
        Me.lblDec.AutoSize = True
        Me.lblDec.Location = New System.Drawing.Point(12, 108)
        Me.lblDec.Name = "lblDec"
        Me.lblDec.Size = New System.Drawing.Size(35, 13)
        Me.lblDec.TabIndex = 5
        Me.lblDec.Text = "DEC: "
        '
        'lblHex
        '
        Me.lblHex.AutoSize = True
        Me.lblHex.Location = New System.Drawing.Point(12, 141)
        Me.lblHex.Name = "lblHex"
        Me.lblHex.Size = New System.Drawing.Size(35, 13)
        Me.lblHex.TabIndex = 6
        Me.lblHex.Text = "HEX: "
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(187, 38)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 7
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'radioBin
        '
        Me.radioBin.AutoSize = True
        Me.radioBin.Location = New System.Drawing.Point(15, 44)
        Me.radioBin.Name = "radioBin"
        Me.radioBin.Size = New System.Drawing.Size(43, 17)
        Me.radioBin.TabIndex = 12
        Me.radioBin.TabStop = True
        Me.radioBin.Text = "BIN"
        Me.radioBin.UseVisualStyleBackColor = True
        '
        'radioDec
        '
        Me.radioDec.AutoSize = True
        Me.radioDec.Location = New System.Drawing.Point(73, 44)
        Me.radioDec.Name = "radioDec"
        Me.radioDec.Size = New System.Drawing.Size(47, 17)
        Me.radioDec.TabIndex = 13
        Me.radioDec.TabStop = True
        Me.radioDec.Text = "DEC"
        Me.radioDec.UseVisualStyleBackColor = True
        '
        'radioHex
        '
        Me.radioHex.AutoSize = True
        Me.radioHex.Location = New System.Drawing.Point(134, 44)
        Me.radioHex.Name = "radioHex"
        Me.radioHex.Size = New System.Drawing.Size(47, 17)
        Me.radioHex.TabIndex = 14
        Me.radioHex.TabStop = True
        Me.radioHex.Text = "HEX"
        Me.radioHex.UseVisualStyleBackColor = True
        '
        'FormularzGlowny
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(272, 189)
        Me.Controls.Add(Me.radioHex)
        Me.Controls.Add(Me.radioDec)
        Me.Controls.Add(Me.radioBin)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.lblHex)
        Me.Controls.Add(Me.lblDec)
        Me.Controls.Add(Me.lblBin)
        Me.Controls.Add(Me.btnHex)
        Me.Controls.Add(Me.btnDec)
        Me.Controls.Add(Me.btnBin)
        Me.Controls.Add(Me.textbWprowadz)
        Me.Name = "FormularzGlowny"
        Me.Text = "Konwerter Bin Dec Hex"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents textbWprowadz As TextBox
    Friend WithEvents btnBin As Button
    Friend WithEvents btnDec As Button
    Friend WithEvents btnHex As Button
    Friend WithEvents lblBin As Label
    Friend WithEvents lblDec As Label
    Friend WithEvents lblHex As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents radioBin As RadioButton
    Friend WithEvents radioDec As RadioButton
    Friend WithEvents radioHex As RadioButton
End Class
