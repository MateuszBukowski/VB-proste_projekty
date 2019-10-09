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
        Me.btnWyswietl = New System.Windows.Forms.Button()
        Me.tbPodajZnak = New System.Windows.Forms.TextBox()
        Me.lblOpis = New System.Windows.Forms.Label()
        Me.lblDec = New System.Windows.Forms.Label()
        Me.lblHex = New System.Windows.Forms.Label()
        Me.lblBin = New System.Windows.Forms.Label()
        Me.tbDec = New System.Windows.Forms.TextBox()
        Me.tbHex = New System.Windows.Forms.TextBox()
        Me.tbBin = New System.Windows.Forms.TextBox()
        Me.lblZnak = New System.Windows.Forms.Label()
        Me.lblSkrot = New System.Windows.Forms.Label()
        Me.tbSkrot = New System.Windows.Forms.TextBox()
        Me.tbZnak = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'btnWyswietl
        '
        Me.btnWyswietl.Location = New System.Drawing.Point(278, 41)
        Me.btnWyswietl.Name = "btnWyswietl"
        Me.btnWyswietl.Size = New System.Drawing.Size(75, 23)
        Me.btnWyswietl.TabIndex = 0
        Me.btnWyswietl.Text = "Wyświetl"
        Me.btnWyswietl.UseVisualStyleBackColor = True
        '
        'tbPodajZnak
        '
        Me.tbPodajZnak.Location = New System.Drawing.Point(22, 41)
        Me.tbPodajZnak.Name = "tbPodajZnak"
        Me.tbPodajZnak.Size = New System.Drawing.Size(223, 20)
        Me.tbPodajZnak.TabIndex = 1
        '
        'lblOpis
        '
        Me.lblOpis.AutoSize = True
        Me.lblOpis.Location = New System.Drawing.Point(19, 25)
        Me.lblOpis.Name = "lblOpis"
        Me.lblOpis.Size = New System.Drawing.Size(88, 13)
        Me.lblOpis.TabIndex = 2
        Me.lblOpis.Text = "Podaj znak DEC:"
        '
        'lblDec
        '
        Me.lblDec.AutoSize = True
        Me.lblDec.Location = New System.Drawing.Point(142, 94)
        Me.lblDec.Name = "lblDec"
        Me.lblDec.Size = New System.Drawing.Size(29, 13)
        Me.lblDec.TabIndex = 3
        Me.lblDec.Text = "DEC"
        '
        'lblHex
        '
        Me.lblHex.AutoSize = True
        Me.lblHex.Location = New System.Drawing.Point(275, 94)
        Me.lblHex.Name = "lblHex"
        Me.lblHex.Size = New System.Drawing.Size(29, 13)
        Me.lblHex.TabIndex = 4
        Me.lblHex.Text = "HEX"
        '
        'lblBin
        '
        Me.lblBin.AutoSize = True
        Me.lblBin.Location = New System.Drawing.Point(19, 94)
        Me.lblBin.Name = "lblBin"
        Me.lblBin.Size = New System.Drawing.Size(25, 13)
        Me.lblBin.TabIndex = 5
        Me.lblBin.Text = "BIN"
        '
        'tbDec
        '
        Me.tbDec.Location = New System.Drawing.Point(145, 110)
        Me.tbDec.Name = "tbDec"
        Me.tbDec.Size = New System.Drawing.Size(100, 20)
        Me.tbDec.TabIndex = 6
        '
        'tbHex
        '
        Me.tbHex.Location = New System.Drawing.Point(278, 110)
        Me.tbHex.Name = "tbHex"
        Me.tbHex.Size = New System.Drawing.Size(100, 20)
        Me.tbHex.TabIndex = 7
        '
        'tbBin
        '
        Me.tbBin.Location = New System.Drawing.Point(22, 110)
        Me.tbBin.Name = "tbBin"
        Me.tbBin.Size = New System.Drawing.Size(100, 20)
        Me.tbBin.TabIndex = 8
        '
        'lblZnak
        '
        Me.lblZnak.AutoSize = True
        Me.lblZnak.Location = New System.Drawing.Point(400, 94)
        Me.lblZnak.Name = "lblZnak"
        Me.lblZnak.Size = New System.Drawing.Size(32, 13)
        Me.lblZnak.TabIndex = 9
        Me.lblZnak.Text = "Znak"
        '
        'lblSkrot
        '
        Me.lblSkrot.AutoSize = True
        Me.lblSkrot.Location = New System.Drawing.Point(533, 94)
        Me.lblSkrot.Name = "lblSkrot"
        Me.lblSkrot.Size = New System.Drawing.Size(32, 13)
        Me.lblSkrot.TabIndex = 10
        Me.lblSkrot.Text = "Skrot"
        '
        'tbSkrot
        '
        Me.tbSkrot.Location = New System.Drawing.Point(536, 110)
        Me.tbSkrot.Name = "tbSkrot"
        Me.tbSkrot.Size = New System.Drawing.Size(100, 20)
        Me.tbSkrot.TabIndex = 11
        '
        'tbZnak
        '
        Me.tbZnak.Location = New System.Drawing.Point(403, 110)
        Me.tbZnak.Name = "tbZnak"
        Me.tbZnak.Size = New System.Drawing.Size(100, 20)
        Me.tbZnak.TabIndex = 12
        '
        'FormularzGlowny
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 209)
        Me.Controls.Add(Me.tbZnak)
        Me.Controls.Add(Me.tbSkrot)
        Me.Controls.Add(Me.lblSkrot)
        Me.Controls.Add(Me.lblZnak)
        Me.Controls.Add(Me.tbBin)
        Me.Controls.Add(Me.tbHex)
        Me.Controls.Add(Me.tbDec)
        Me.Controls.Add(Me.lblBin)
        Me.Controls.Add(Me.lblHex)
        Me.Controls.Add(Me.lblDec)
        Me.Controls.Add(Me.lblOpis)
        Me.Controls.Add(Me.tbPodajZnak)
        Me.Controls.Add(Me.btnWyswietl)
        Me.Name = "FormularzGlowny"
        Me.Text = "ASCII"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnWyswietl As Button
    Friend WithEvents tbPodajZnak As TextBox
    Friend WithEvents lblOpis As Label
    Friend WithEvents lblDec As Label
    Friend WithEvents lblHex As Label
    Friend WithEvents lblBin As Label
    Friend WithEvents tbDec As TextBox
    Friend WithEvents tbHex As TextBox
    Friend WithEvents tbBin As TextBox
    Friend WithEvents lblZnak As Label
    Friend WithEvents lblSkrot As Label
    Friend WithEvents tbSkrot As TextBox
    Friend WithEvents tbZnak As TextBox
End Class
