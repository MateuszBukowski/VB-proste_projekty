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
        Me.lblGodzina = New System.Windows.Forms.Label()
        Me.lblData = New System.Windows.Forms.Label()
        Me.czasZegar = New System.Windows.Forms.Timer(Me.components)
        Me.grbDataGodzina = New System.Windows.Forms.GroupBox()
        Me.grbStoper = New System.Windows.Forms.GroupBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.lblStoper = New System.Windows.Forms.Label()
        Me.btnStopStoper = New System.Windows.Forms.Button()
        Me.btnStartStoper = New System.Windows.Forms.Button()
        Me.gpbOdliczanie = New System.Windows.Forms.GroupBox()
        Me.btnUstawOdliczanie = New System.Windows.Forms.Button()
        Me.btnStopOdliczanie = New System.Windows.Forms.Button()
        Me.btnStartOdliczanie = New System.Windows.Forms.Button()
        Me.lblSekundy = New System.Windows.Forms.Label()
        Me.lblMinuty = New System.Windows.Forms.Label()
        Me.lblGodziny = New System.Windows.Forms.Label()
        Me.numudSekundyOdliczanie = New System.Windows.Forms.NumericUpDown()
        Me.numudMinutyOdliczanie = New System.Windows.Forms.NumericUpDown()
        Me.numudGodzinyOdliczanie = New System.Windows.Forms.NumericUpDown()
        Me.lblOdliczanie = New System.Windows.Forms.Label()
        Me.gpbInterwaly = New System.Windows.Forms.GroupBox()
        Me.lblSekundyOpis = New System.Windows.Forms.Label()
        Me.lblMinutyOpis = New System.Windows.Forms.Label()
        Me.nudSekundyInterwal4 = New System.Windows.Forms.NumericUpDown()
        Me.nudSekundyInterwal3 = New System.Windows.Forms.NumericUpDown()
        Me.nudSekundyInterwal2 = New System.Windows.Forms.NumericUpDown()
        Me.nudSekundyInterwal1 = New System.Windows.Forms.NumericUpDown()
        Me.btnUstawInterwaly = New System.Windows.Forms.Button()
        Me.btnStopInterwaly = New System.Windows.Forms.Button()
        Me.btnStartInterwaly = New System.Windows.Forms.Button()
        Me.nudMinutyInterwal4 = New System.Windows.Forms.NumericUpDown()
        Me.nudMinutyInterwal3 = New System.Windows.Forms.NumericUpDown()
        Me.nudMinutyInterwal2 = New System.Windows.Forms.NumericUpDown()
        Me.nudMinutyInterwal1 = New System.Windows.Forms.NumericUpDown()
        Me.lblNazwaInterwal4 = New System.Windows.Forms.Label()
        Me.lblNazwaInterwal3 = New System.Windows.Forms.Label()
        Me.lblNazwaInterwal2 = New System.Windows.Forms.Label()
        Me.lblNazwaInterwal1 = New System.Windows.Forms.Label()
        Me.lblInterwal4 = New System.Windows.Forms.Label()
        Me.lblInterwal3 = New System.Windows.Forms.Label()
        Me.lblInterwal2 = New System.Windows.Forms.Label()
        Me.lblInterwal1 = New System.Windows.Forms.Label()
        Me.czasStoper = New System.Windows.Forms.Timer(Me.components)
        Me.czasOdliczanie = New System.Windows.Forms.Timer(Me.components)
        Me.czasInterwal = New System.Windows.Forms.Timer(Me.components)
        Me.chbAlarm = New System.Windows.Forms.CheckBox()
        Me.comboGodziny = New System.Windows.Forms.ComboBox()
        Me.comboMinuty = New System.Windows.Forms.ComboBox()
        Me.grbDataGodzina.SuspendLayout()
        Me.grbStoper.SuspendLayout()
        Me.gpbOdliczanie.SuspendLayout()
        CType(Me.numudSekundyOdliczanie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numudMinutyOdliczanie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numudGodzinyOdliczanie, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbInterwaly.SuspendLayout()
        CType(Me.nudSekundyInterwal4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSekundyInterwal3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSekundyInterwal2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudSekundyInterwal1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMinutyInterwal4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMinutyInterwal3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMinutyInterwal2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudMinutyInterwal1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblGodzina
        '
        Me.lblGodzina.AutoSize = True
        Me.lblGodzina.Font = New System.Drawing.Font("Microsoft Sans Serif", 32.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblGodzina.Location = New System.Drawing.Point(15, 35)
        Me.lblGodzina.Name = "lblGodzina"
        Me.lblGodzina.Size = New System.Drawing.Size(183, 51)
        Me.lblGodzina.TabIndex = 0
        Me.lblGodzina.Text = "Godzina"
        '
        'lblData
        '
        Me.lblData.AutoSize = True
        Me.lblData.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblData.Location = New System.Drawing.Point(219, 22)
        Me.lblData.Name = "lblData"
        Me.lblData.Size = New System.Drawing.Size(58, 26)
        Me.lblData.TabIndex = 1
        Me.lblData.Text = "Data"
        '
        'czasZegar
        '
        Me.czasZegar.Enabled = True
        Me.czasZegar.Interval = 1000
        '
        'grbDataGodzina
        '
        Me.grbDataGodzina.Controls.Add(Me.comboMinuty)
        Me.grbDataGodzina.Controls.Add(Me.comboGodziny)
        Me.grbDataGodzina.Controls.Add(Me.chbAlarm)
        Me.grbDataGodzina.Controls.Add(Me.lblGodzina)
        Me.grbDataGodzina.Controls.Add(Me.lblData)
        Me.grbDataGodzina.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.grbDataGodzina.Location = New System.Drawing.Point(12, 7)
        Me.grbDataGodzina.Name = "grbDataGodzina"
        Me.grbDataGodzina.Size = New System.Drawing.Size(475, 99)
        Me.grbDataGodzina.TabIndex = 2
        Me.grbDataGodzina.TabStop = False
        Me.grbDataGodzina.Text = "Data i godzina"
        '
        'grbStoper
        '
        Me.grbStoper.Controls.Add(Me.btnReset)
        Me.grbStoper.Controls.Add(Me.lblStoper)
        Me.grbStoper.Controls.Add(Me.btnStopStoper)
        Me.grbStoper.Controls.Add(Me.btnStartStoper)
        Me.grbStoper.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.grbStoper.Location = New System.Drawing.Point(12, 112)
        Me.grbStoper.Name = "grbStoper"
        Me.grbStoper.Size = New System.Drawing.Size(475, 100)
        Me.grbStoper.TabIndex = 3
        Me.grbStoper.TabStop = False
        Me.grbStoper.Text = "Stoper"
        '
        'btnReset
        '
        Me.btnReset.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnReset.Location = New System.Drawing.Point(383, 71)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 5
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'lblStoper
        '
        Me.lblStoper.AutoSize = True
        Me.lblStoper.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblStoper.Location = New System.Drawing.Point(6, 28)
        Me.lblStoper.Name = "lblStoper"
        Me.lblStoper.Size = New System.Drawing.Size(199, 39)
        Me.lblStoper.TabIndex = 4
        Me.lblStoper.Text = "00:00:00:00"
        '
        'btnStopStoper
        '
        Me.btnStopStoper.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnStopStoper.Location = New System.Drawing.Point(383, 42)
        Me.btnStopStoper.Name = "btnStopStoper"
        Me.btnStopStoper.Size = New System.Drawing.Size(75, 23)
        Me.btnStopStoper.TabIndex = 3
        Me.btnStopStoper.Text = "Stop"
        Me.btnStopStoper.UseVisualStyleBackColor = True
        '
        'btnStartStoper
        '
        Me.btnStartStoper.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnStartStoper.Location = New System.Drawing.Point(383, 15)
        Me.btnStartStoper.Name = "btnStartStoper"
        Me.btnStartStoper.Size = New System.Drawing.Size(75, 23)
        Me.btnStartStoper.TabIndex = 2
        Me.btnStartStoper.Text = "Start"
        Me.btnStartStoper.UseVisualStyleBackColor = True
        '
        'gpbOdliczanie
        '
        Me.gpbOdliczanie.Controls.Add(Me.btnUstawOdliczanie)
        Me.gpbOdliczanie.Controls.Add(Me.btnStopOdliczanie)
        Me.gpbOdliczanie.Controls.Add(Me.btnStartOdliczanie)
        Me.gpbOdliczanie.Controls.Add(Me.lblSekundy)
        Me.gpbOdliczanie.Controls.Add(Me.lblMinuty)
        Me.gpbOdliczanie.Controls.Add(Me.lblGodziny)
        Me.gpbOdliczanie.Controls.Add(Me.numudSekundyOdliczanie)
        Me.gpbOdliczanie.Controls.Add(Me.numudMinutyOdliczanie)
        Me.gpbOdliczanie.Controls.Add(Me.numudGodzinyOdliczanie)
        Me.gpbOdliczanie.Controls.Add(Me.lblOdliczanie)
        Me.gpbOdliczanie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gpbOdliczanie.Location = New System.Drawing.Point(12, 218)
        Me.gpbOdliczanie.Name = "gpbOdliczanie"
        Me.gpbOdliczanie.Size = New System.Drawing.Size(475, 115)
        Me.gpbOdliczanie.TabIndex = 4
        Me.gpbOdliczanie.TabStop = False
        Me.gpbOdliczanie.Text = "Odliczanie"
        '
        'btnUstawOdliczanie
        '
        Me.btnUstawOdliczanie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnUstawOdliczanie.Location = New System.Drawing.Point(383, 73)
        Me.btnUstawOdliczanie.Name = "btnUstawOdliczanie"
        Me.btnUstawOdliczanie.Size = New System.Drawing.Size(75, 23)
        Me.btnUstawOdliczanie.TabIndex = 11
        Me.btnUstawOdliczanie.Text = "Ustaw"
        Me.btnUstawOdliczanie.UseVisualStyleBackColor = True
        '
        'btnStopOdliczanie
        '
        Me.btnStopOdliczanie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnStopOdliczanie.Location = New System.Drawing.Point(383, 45)
        Me.btnStopOdliczanie.Name = "btnStopOdliczanie"
        Me.btnStopOdliczanie.Size = New System.Drawing.Size(75, 23)
        Me.btnStopOdliczanie.TabIndex = 10
        Me.btnStopOdliczanie.Text = "Stop"
        Me.btnStopOdliczanie.UseVisualStyleBackColor = True
        '
        'btnStartOdliczanie
        '
        Me.btnStartOdliczanie.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnStartOdliczanie.Location = New System.Drawing.Point(383, 16)
        Me.btnStartOdliczanie.Name = "btnStartOdliczanie"
        Me.btnStartOdliczanie.Size = New System.Drawing.Size(75, 23)
        Me.btnStartOdliczanie.TabIndex = 9
        Me.btnStartOdliczanie.Text = "Start"
        Me.btnStartOdliczanie.UseVisualStyleBackColor = True
        '
        'lblSekundy
        '
        Me.lblSekundy.AutoSize = True
        Me.lblSekundy.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblSekundy.Location = New System.Drawing.Point(254, 80)
        Me.lblSekundy.Name = "lblSekundy"
        Me.lblSekundy.Size = New System.Drawing.Size(63, 17)
        Me.lblSekundy.TabIndex = 8
        Me.lblSekundy.Text = "Sekundy"
        '
        'lblMinuty
        '
        Me.lblMinuty.AutoSize = True
        Me.lblMinuty.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblMinuty.Location = New System.Drawing.Point(254, 50)
        Me.lblMinuty.Name = "lblMinuty"
        Me.lblMinuty.Size = New System.Drawing.Size(49, 17)
        Me.lblMinuty.TabIndex = 7
        Me.lblMinuty.Text = "Minuty"
        '
        'lblGodziny
        '
        Me.lblGodziny.AutoSize = True
        Me.lblGodziny.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblGodziny.Location = New System.Drawing.Point(254, 18)
        Me.lblGodziny.Name = "lblGodziny"
        Me.lblGodziny.Size = New System.Drawing.Size(60, 17)
        Me.lblGodziny.TabIndex = 6
        Me.lblGodziny.Text = "Godziny"
        '
        'numudSekundyOdliczanie
        '
        Me.numudSekundyOdliczanie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.numudSekundyOdliczanie.Location = New System.Drawing.Point(196, 80)
        Me.numudSekundyOdliczanie.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.numudSekundyOdliczanie.Name = "numudSekundyOdliczanie"
        Me.numudSekundyOdliczanie.Size = New System.Drawing.Size(39, 26)
        Me.numudSekundyOdliczanie.TabIndex = 5
        '
        'numudMinutyOdliczanie
        '
        Me.numudMinutyOdliczanie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.numudMinutyOdliczanie.Location = New System.Drawing.Point(196, 48)
        Me.numudMinutyOdliczanie.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.numudMinutyOdliczanie.Name = "numudMinutyOdliczanie"
        Me.numudMinutyOdliczanie.Size = New System.Drawing.Size(39, 26)
        Me.numudMinutyOdliczanie.TabIndex = 4
        '
        'numudGodzinyOdliczanie
        '
        Me.numudGodzinyOdliczanie.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.numudGodzinyOdliczanie.Location = New System.Drawing.Point(196, 16)
        Me.numudGodzinyOdliczanie.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.numudGodzinyOdliczanie.Name = "numudGodzinyOdliczanie"
        Me.numudGodzinyOdliczanie.Size = New System.Drawing.Size(39, 26)
        Me.numudGodzinyOdliczanie.TabIndex = 3
        '
        'lblOdliczanie
        '
        Me.lblOdliczanie.AutoSize = True
        Me.lblOdliczanie.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblOdliczanie.Location = New System.Drawing.Point(10, 43)
        Me.lblOdliczanie.Name = "lblOdliczanie"
        Me.lblOdliczanie.Size = New System.Drawing.Size(151, 39)
        Me.lblOdliczanie.TabIndex = 2
        Me.lblOdliczanie.Text = "00:00:00"
        '
        'gpbInterwaly
        '
        Me.gpbInterwaly.Controls.Add(Me.lblSekundyOpis)
        Me.gpbInterwaly.Controls.Add(Me.lblMinutyOpis)
        Me.gpbInterwaly.Controls.Add(Me.nudSekundyInterwal4)
        Me.gpbInterwaly.Controls.Add(Me.nudSekundyInterwal3)
        Me.gpbInterwaly.Controls.Add(Me.nudSekundyInterwal2)
        Me.gpbInterwaly.Controls.Add(Me.nudSekundyInterwal1)
        Me.gpbInterwaly.Controls.Add(Me.btnUstawInterwaly)
        Me.gpbInterwaly.Controls.Add(Me.btnStopInterwaly)
        Me.gpbInterwaly.Controls.Add(Me.btnStartInterwaly)
        Me.gpbInterwaly.Controls.Add(Me.nudMinutyInterwal4)
        Me.gpbInterwaly.Controls.Add(Me.nudMinutyInterwal3)
        Me.gpbInterwaly.Controls.Add(Me.nudMinutyInterwal2)
        Me.gpbInterwaly.Controls.Add(Me.nudMinutyInterwal1)
        Me.gpbInterwaly.Controls.Add(Me.lblNazwaInterwal4)
        Me.gpbInterwaly.Controls.Add(Me.lblNazwaInterwal3)
        Me.gpbInterwaly.Controls.Add(Me.lblNazwaInterwal2)
        Me.gpbInterwaly.Controls.Add(Me.lblNazwaInterwal1)
        Me.gpbInterwaly.Controls.Add(Me.lblInterwal4)
        Me.gpbInterwaly.Controls.Add(Me.lblInterwal3)
        Me.gpbInterwaly.Controls.Add(Me.lblInterwal2)
        Me.gpbInterwaly.Controls.Add(Me.lblInterwal1)
        Me.gpbInterwaly.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.gpbInterwaly.Location = New System.Drawing.Point(12, 339)
        Me.gpbInterwaly.Name = "gpbInterwaly"
        Me.gpbInterwaly.Size = New System.Drawing.Size(475, 168)
        Me.gpbInterwaly.TabIndex = 5
        Me.gpbInterwaly.TabStop = False
        Me.gpbInterwaly.Text = "Interwały"
        '
        'lblSekundyOpis
        '
        Me.lblSekundyOpis.AutoSize = True
        Me.lblSekundyOpis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblSekundyOpis.Location = New System.Drawing.Point(249, 22)
        Me.lblSekundyOpis.Name = "lblSekundyOpis"
        Me.lblSekundyOpis.Size = New System.Drawing.Size(54, 15)
        Me.lblSekundyOpis.TabIndex = 22
        Me.lblSekundyOpis.Text = "Sekundy"
        '
        'lblMinutyOpis
        '
        Me.lblMinutyOpis.AutoSize = True
        Me.lblMinutyOpis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblMinutyOpis.Location = New System.Drawing.Point(190, 22)
        Me.lblMinutyOpis.Name = "lblMinutyOpis"
        Me.lblMinutyOpis.Size = New System.Drawing.Size(43, 15)
        Me.lblMinutyOpis.TabIndex = 21
        Me.lblMinutyOpis.Text = "Minuty"
        '
        'nudSekundyInterwal4
        '
        Me.nudSekundyInterwal4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.nudSekundyInterwal4.Location = New System.Drawing.Point(253, 136)
        Me.nudSekundyInterwal4.Name = "nudSekundyInterwal4"
        Me.nudSekundyInterwal4.Size = New System.Drawing.Size(52, 23)
        Me.nudSekundyInterwal4.TabIndex = 20
        '
        'nudSekundyInterwal3
        '
        Me.nudSekundyInterwal3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.nudSekundyInterwal3.Location = New System.Drawing.Point(253, 106)
        Me.nudSekundyInterwal3.Name = "nudSekundyInterwal3"
        Me.nudSekundyInterwal3.Size = New System.Drawing.Size(52, 23)
        Me.nudSekundyInterwal3.TabIndex = 19
        '
        'nudSekundyInterwal2
        '
        Me.nudSekundyInterwal2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.nudSekundyInterwal2.Location = New System.Drawing.Point(253, 76)
        Me.nudSekundyInterwal2.Name = "nudSekundyInterwal2"
        Me.nudSekundyInterwal2.Size = New System.Drawing.Size(52, 23)
        Me.nudSekundyInterwal2.TabIndex = 18
        '
        'nudSekundyInterwal1
        '
        Me.nudSekundyInterwal1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.nudSekundyInterwal1.Location = New System.Drawing.Point(253, 46)
        Me.nudSekundyInterwal1.Name = "nudSekundyInterwal1"
        Me.nudSekundyInterwal1.Size = New System.Drawing.Size(52, 23)
        Me.nudSekundyInterwal1.TabIndex = 17
        '
        'btnUstawInterwaly
        '
        Me.btnUstawInterwaly.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnUstawInterwaly.Location = New System.Drawing.Point(385, 130)
        Me.btnUstawInterwaly.Name = "btnUstawInterwaly"
        Me.btnUstawInterwaly.Size = New System.Drawing.Size(75, 23)
        Me.btnUstawInterwaly.TabIndex = 16
        Me.btnUstawInterwaly.Text = "Ustaw"
        Me.btnUstawInterwaly.UseVisualStyleBackColor = True
        '
        'btnStopInterwaly
        '
        Me.btnStopInterwaly.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnStopInterwaly.Location = New System.Drawing.Point(385, 80)
        Me.btnStopInterwaly.Name = "btnStopInterwaly"
        Me.btnStopInterwaly.Size = New System.Drawing.Size(75, 23)
        Me.btnStopInterwaly.TabIndex = 15
        Me.btnStopInterwaly.Text = "Stop"
        Me.btnStopInterwaly.UseVisualStyleBackColor = True
        '
        'btnStartInterwaly
        '
        Me.btnStartInterwaly.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.btnStartInterwaly.Location = New System.Drawing.Point(385, 30)
        Me.btnStartInterwaly.Name = "btnStartInterwaly"
        Me.btnStartInterwaly.Size = New System.Drawing.Size(75, 23)
        Me.btnStartInterwaly.TabIndex = 14
        Me.btnStartInterwaly.Text = "Start"
        Me.btnStartInterwaly.UseVisualStyleBackColor = True
        '
        'nudMinutyInterwal4
        '
        Me.nudMinutyInterwal4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.nudMinutyInterwal4.Location = New System.Drawing.Point(185, 136)
        Me.nudMinutyInterwal4.Name = "nudMinutyInterwal4"
        Me.nudMinutyInterwal4.Size = New System.Drawing.Size(52, 23)
        Me.nudMinutyInterwal4.TabIndex = 13
        '
        'nudMinutyInterwal3
        '
        Me.nudMinutyInterwal3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.nudMinutyInterwal3.Location = New System.Drawing.Point(185, 106)
        Me.nudMinutyInterwal3.Name = "nudMinutyInterwal3"
        Me.nudMinutyInterwal3.Size = New System.Drawing.Size(52, 23)
        Me.nudMinutyInterwal3.TabIndex = 12
        '
        'nudMinutyInterwal2
        '
        Me.nudMinutyInterwal2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.nudMinutyInterwal2.Location = New System.Drawing.Point(185, 76)
        Me.nudMinutyInterwal2.Name = "nudMinutyInterwal2"
        Me.nudMinutyInterwal2.Size = New System.Drawing.Size(52, 23)
        Me.nudMinutyInterwal2.TabIndex = 11
        '
        'nudMinutyInterwal1
        '
        Me.nudMinutyInterwal1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.nudMinutyInterwal1.Location = New System.Drawing.Point(185, 46)
        Me.nudMinutyInterwal1.Name = "nudMinutyInterwal1"
        Me.nudMinutyInterwal1.Size = New System.Drawing.Size(52, 23)
        Me.nudMinutyInterwal1.TabIndex = 10
        '
        'lblNazwaInterwal4
        '
        Me.lblNazwaInterwal4.AutoSize = True
        Me.lblNazwaInterwal4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblNazwaInterwal4.Location = New System.Drawing.Point(15, 138)
        Me.lblNazwaInterwal4.Name = "lblNazwaInterwal4"
        Me.lblNazwaInterwal4.Size = New System.Drawing.Size(57, 17)
        Me.lblNazwaInterwal4.TabIndex = 9
        Me.lblNazwaInterwal4.Text = "Czwarty"
        '
        'lblNazwaInterwal3
        '
        Me.lblNazwaInterwal3.AutoSize = True
        Me.lblNazwaInterwal3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblNazwaInterwal3.Location = New System.Drawing.Point(15, 108)
        Me.lblNazwaInterwal3.Name = "lblNazwaInterwal3"
        Me.lblNazwaInterwal3.Size = New System.Drawing.Size(47, 17)
        Me.lblNazwaInterwal3.TabIndex = 8
        Me.lblNazwaInterwal3.Text = "Trzeci"
        '
        'lblNazwaInterwal2
        '
        Me.lblNazwaInterwal2.AutoSize = True
        Me.lblNazwaInterwal2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblNazwaInterwal2.Location = New System.Drawing.Point(15, 78)
        Me.lblNazwaInterwal2.Name = "lblNazwaInterwal2"
        Me.lblNazwaInterwal2.Size = New System.Drawing.Size(42, 17)
        Me.lblNazwaInterwal2.TabIndex = 7
        Me.lblNazwaInterwal2.Text = "Drugi"
        '
        'lblNazwaInterwal1
        '
        Me.lblNazwaInterwal1.AutoSize = True
        Me.lblNazwaInterwal1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.lblNazwaInterwal1.Location = New System.Drawing.Point(15, 48)
        Me.lblNazwaInterwal1.Name = "lblNazwaInterwal1"
        Me.lblNazwaInterwal1.Size = New System.Drawing.Size(63, 17)
        Me.lblNazwaInterwal1.TabIndex = 6
        Me.lblNazwaInterwal1.Text = "Pierwszy"
        '
        'lblInterwal4
        '
        Me.lblInterwal4.AutoSize = True
        Me.lblInterwal4.Location = New System.Drawing.Point(102, 138)
        Me.lblInterwal4.Name = "lblInterwal4"
        Me.lblInterwal4.Size = New System.Drawing.Size(49, 20)
        Me.lblInterwal4.TabIndex = 5
        Me.lblInterwal4.Text = "00:00"
        '
        'lblInterwal3
        '
        Me.lblInterwal3.AutoSize = True
        Me.lblInterwal3.Location = New System.Drawing.Point(102, 108)
        Me.lblInterwal3.Name = "lblInterwal3"
        Me.lblInterwal3.Size = New System.Drawing.Size(49, 20)
        Me.lblInterwal3.TabIndex = 4
        Me.lblInterwal3.Text = "00:00"
        '
        'lblInterwal2
        '
        Me.lblInterwal2.AutoSize = True
        Me.lblInterwal2.Location = New System.Drawing.Point(102, 78)
        Me.lblInterwal2.Name = "lblInterwal2"
        Me.lblInterwal2.Size = New System.Drawing.Size(49, 20)
        Me.lblInterwal2.TabIndex = 3
        Me.lblInterwal2.Text = "00:00"
        '
        'lblInterwal1
        '
        Me.lblInterwal1.AutoSize = True
        Me.lblInterwal1.Location = New System.Drawing.Point(102, 48)
        Me.lblInterwal1.Name = "lblInterwal1"
        Me.lblInterwal1.Size = New System.Drawing.Size(49, 20)
        Me.lblInterwal1.TabIndex = 2
        Me.lblInterwal1.Text = "00:00"
        '
        'czasStoper
        '
        '
        'czasOdliczanie
        '
        Me.czasOdliczanie.Interval = 1000
        '
        'czasInterwal
        '
        Me.czasInterwal.Interval = 1000
        '
        'chbAlarm
        '
        Me.chbAlarm.AutoSize = True
        Me.chbAlarm.Location = New System.Drawing.Point(224, 69)
        Me.chbAlarm.Name = "chbAlarm"
        Me.chbAlarm.Size = New System.Drawing.Size(69, 24)
        Me.chbAlarm.TabIndex = 2
        Me.chbAlarm.Text = "Alarm"
        Me.chbAlarm.UseVisualStyleBackColor = True
        '
        'comboGodziny
        '
        Me.comboGodziny.FormattingEnabled = True
        Me.comboGodziny.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24"})
        Me.comboGodziny.Location = New System.Drawing.Point(311, 65)
        Me.comboGodziny.Name = "comboGodziny"
        Me.comboGodziny.Size = New System.Drawing.Size(50, 28)
        Me.comboGodziny.TabIndex = 3
        '
        'comboMinuty
        '
        Me.comboMinuty.FormattingEnabled = True
        Me.comboMinuty.Items.AddRange(New Object() {"01", "02", "03", "04", "05", "06", "07", "08", "09", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31", "32", "34", "35", "36", "37", "38", "39", "40", "41", "42", "43", "44", "45", "46", "47", "48", "49", "50", "51", "52", "53", "54", "55", "56", "57", "58", "59"})
        Me.comboMinuty.Location = New System.Drawing.Point(383, 65)
        Me.comboMinuty.Name = "comboMinuty"
        Me.comboMinuty.Size = New System.Drawing.Size(50, 28)
        Me.comboMinuty.TabIndex = 4
        '
        'FormularzGlowny
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(499, 513)
        Me.Controls.Add(Me.gpbInterwaly)
        Me.Controls.Add(Me.gpbOdliczanie)
        Me.Controls.Add(Me.grbStoper)
        Me.Controls.Add(Me.grbDataGodzina)
        Me.Name = "FormularzGlowny"
        Me.Text = "Hronometr"
        Me.grbDataGodzina.ResumeLayout(False)
        Me.grbDataGodzina.PerformLayout()
        Me.grbStoper.ResumeLayout(False)
        Me.grbStoper.PerformLayout()
        Me.gpbOdliczanie.ResumeLayout(False)
        Me.gpbOdliczanie.PerformLayout()
        CType(Me.numudSekundyOdliczanie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numudMinutyOdliczanie, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numudGodzinyOdliczanie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbInterwaly.ResumeLayout(False)
        Me.gpbInterwaly.PerformLayout()
        CType(Me.nudSekundyInterwal4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSekundyInterwal3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSekundyInterwal2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudSekundyInterwal1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMinutyInterwal4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMinutyInterwal3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMinutyInterwal2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudMinutyInterwal1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents lblGodzina As Label
    Friend WithEvents lblData As Label
    Friend WithEvents czasZegar As Timer
    Friend WithEvents grbDataGodzina As GroupBox
    Friend WithEvents grbStoper As GroupBox
    Friend WithEvents gpbOdliczanie As GroupBox
    Friend WithEvents gpbInterwaly As GroupBox
    Friend WithEvents btnStopStoper As Button
    Friend WithEvents btnStartStoper As Button
    Friend WithEvents lblStoper As Label
    Friend WithEvents czasStoper As Timer
    Friend WithEvents btnReset As Button
    Friend WithEvents btnUstawOdliczanie As Button
    Friend WithEvents btnStopOdliczanie As Button
    Friend WithEvents btnStartOdliczanie As Button
    Friend WithEvents lblSekundy As Label
    Friend WithEvents lblMinuty As Label
    Friend WithEvents lblGodziny As Label
    Friend WithEvents numudSekundyOdliczanie As NumericUpDown
    Friend WithEvents numudMinutyOdliczanie As NumericUpDown
    Friend WithEvents numudGodzinyOdliczanie As NumericUpDown
    Friend WithEvents lblOdliczanie As Label
    Friend WithEvents lblInterwal4 As Label
    Friend WithEvents lblInterwal3 As Label
    Friend WithEvents lblInterwal2 As Label
    Friend WithEvents lblInterwal1 As Label
    Friend WithEvents lblNazwaInterwal4 As Label
    Friend WithEvents lblNazwaInterwal3 As Label
    Friend WithEvents lblNazwaInterwal2 As Label
    Friend WithEvents lblNazwaInterwal1 As Label
    Friend WithEvents nudMinutyInterwal4 As NumericUpDown
    Friend WithEvents nudMinutyInterwal3 As NumericUpDown
    Friend WithEvents nudMinutyInterwal2 As NumericUpDown
    Friend WithEvents nudMinutyInterwal1 As NumericUpDown
    Friend WithEvents btnUstawInterwaly As Button
    Friend WithEvents btnStopInterwaly As Button
    Friend WithEvents btnStartInterwaly As Button
    Friend WithEvents nudSekundyInterwal4 As NumericUpDown
    Friend WithEvents nudSekundyInterwal3 As NumericUpDown
    Friend WithEvents nudSekundyInterwal2 As NumericUpDown
    Friend WithEvents nudSekundyInterwal1 As NumericUpDown
    Friend WithEvents lblSekundyOpis As Label
    Friend WithEvents lblMinutyOpis As Label
    Friend WithEvents czasOdliczanie As Timer
    Friend WithEvents czasInterwal As Timer
    Friend WithEvents comboMinuty As ComboBox
    Friend WithEvents comboGodziny As ComboBox
    Friend WithEvents chbAlarm As CheckBox
End Class
