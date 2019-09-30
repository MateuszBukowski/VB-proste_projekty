<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormularzGlowny
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblGodziny = New System.Windows.Forms.Label()
        Me.lblMinuty = New System.Windows.Forms.Label()
        Me.lblSekundy = New System.Windows.Forms.Label()
        Me.lblPotegi2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblGodziny
        '
        Me.lblGodziny.AutoSize = True
        Me.lblGodziny.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblGodziny.Location = New System.Drawing.Point(13, 43)
        Me.lblGodziny.Name = "lblGodziny"
        Me.lblGodziny.Size = New System.Drawing.Size(273, 63)
        Me.lblGodziny.TabIndex = 0
        Me.lblGodziny.Text = "H:   00000"
        '
        'lblMinuty
        '
        Me.lblMinuty.AutoSize = True
        Me.lblMinuty.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblMinuty.Location = New System.Drawing.Point(4, 106)
        Me.lblMinuty.Name = "lblMinuty"
        Me.lblMinuty.Size = New System.Drawing.Size(281, 63)
        Me.lblMinuty.TabIndex = 1
        Me.lblMinuty.Text = "M: 000000"
        '
        'lblSekundy
        '
        Me.lblSekundy.AutoSize = True
        Me.lblSekundy.Font = New System.Drawing.Font("Microsoft Sans Serif", 40.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblSekundy.Location = New System.Drawing.Point(13, 170)
        Me.lblSekundy.Name = "lblSekundy"
        Me.lblSekundy.Size = New System.Drawing.Size(272, 63)
        Me.lblSekundy.TabIndex = 2
        Me.lblSekundy.Text = "S: 000000"
        '
        'lblPotegi2
        '
        Me.lblPotegi2.AutoSize = True
        Me.lblPotegi2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblPotegi2.Location = New System.Drawing.Point(82, 10)
        Me.lblPotegi2.Name = "lblPotegi2"
        Me.lblPotegi2.Size = New System.Drawing.Size(186, 26)
        Me.lblPotegi2.TabIndex = 3
        Me.lblPotegi2.Text = "32  16  8   4   2   1"
        '
        'FormularzGlowny
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(287, 237)
        Me.Controls.Add(Me.lblPotegi2)
        Me.Controls.Add(Me.lblSekundy)
        Me.Controls.Add(Me.lblMinuty)
        Me.Controls.Add(Me.lblGodziny)
        Me.Name = "FormularzGlowny"
        Me.Text = "Zegar Binarny"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblGodziny As Label
    Friend WithEvents lblMinuty As Label
    Friend WithEvents lblSekundy As Label
    Friend WithEvents lblPotegi2 As Label
End Class
