<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form1))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbleinaus = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblnum = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblconnect = New System.Windows.Forms.Label()
        Me.lblverbindung = New System.Windows.Forms.Label()
        Me.Btnend = New System.Windows.Forms.Button()
        Me.btnhelp = New System.Windows.Forms.Button()
        Me.txtumrechnung = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.txtprozent = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TrackBar1 = New System.Windows.Forms.TrackBar()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Identifikation = New System.Windows.Forms.Timer(Me.components)
        Me.Btnstart = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.check = New System.Windows.Forms.Timer(Me.components)
        Me.Notaus = New System.Windows.Forms.Timer(Me.components)
        Me.sec = New System.Windows.Forms.Timer(Me.components)
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(330, 8)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "Laufzeit"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(344, 21)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 13)
        Me.Label9.TabIndex = 30
        Me.Label9.Text = "--"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(12, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(622, 15)
        Me.Label5.TabIndex = 29
        Me.Label5.Text = "_________________________________________________________________________________" & _
    "__________________________________________________________"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 64)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 13)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "Umrechnungsfaktor"
        '
        'lbleinaus
        '
        Me.lbleinaus.AutoSize = True
        Me.lbleinaus.ForeColor = System.Drawing.Color.Red
        Me.lbleinaus.Location = New System.Drawing.Point(266, 20)
        Me.lbleinaus.Name = "lbleinaus"
        Me.lbleinaus.Size = New System.Drawing.Size(25, 13)
        Me.lbleinaus.TabIndex = 27
        Me.lbleinaus.Text = "Aus"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(233, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Regelungs Status"
        '
        'lblnum
        '
        Me.lblnum.ForeColor = System.Drawing.Color.Red
        Me.lblnum.Location = New System.Drawing.Point(125, 21)
        Me.lblnum.Name = "lblnum"
        Me.lblnum.Size = New System.Drawing.Size(86, 13)
        Me.lblnum.TabIndex = 25
        Me.lblnum.Text = "------------"
        Me.lblnum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(131, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Cardaddress"
        '
        'lblconnect
        '
        Me.lblconnect.AutoSize = True
        Me.lblconnect.ForeColor = System.Drawing.Color.Red
        Me.lblconnect.Location = New System.Drawing.Point(31, 21)
        Me.lblconnect.Name = "lblconnect"
        Me.lblconnect.Size = New System.Drawing.Size(40, 13)
        Me.lblconnect.TabIndex = 23
        Me.lblconnect.Text = "-----------"
        Me.lblconnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblverbindung
        '
        Me.lblverbindung.AutoSize = True
        Me.lblverbindung.Location = New System.Drawing.Point(12, 8)
        Me.lblverbindung.Name = "lblverbindung"
        Me.lblverbindung.Size = New System.Drawing.Size(94, 13)
        Me.lblverbindung.TabIndex = 22
        Me.lblverbindung.Text = "Connection Status"
        '
        'Btnend
        '
        Me.Btnend.BackgroundImage = CType(resources.GetObject("Btnend.BackgroundImage"), System.Drawing.Image)
        Me.Btnend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btnend.Location = New System.Drawing.Point(691, 8)
        Me.Btnend.Name = "Btnend"
        Me.Btnend.Size = New System.Drawing.Size(45, 50)
        Me.Btnend.TabIndex = 35
        Me.Btnend.UseVisualStyleBackColor = True
        '
        'btnhelp
        '
        Me.btnhelp.BackgroundImage = CType(resources.GetObject("btnhelp.BackgroundImage"), System.Drawing.Image)
        Me.btnhelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnhelp.Location = New System.Drawing.Point(638, 8)
        Me.btnhelp.Name = "btnhelp"
        Me.btnhelp.Size = New System.Drawing.Size(47, 50)
        Me.btnhelp.TabIndex = 34
        Me.btnhelp.UseVisualStyleBackColor = True
        '
        'txtumrechnung
        '
        Me.txtumrechnung.ForeColor = System.Drawing.Color.Black
        Me.txtumrechnung.Location = New System.Drawing.Point(118, 61)
        Me.txtumrechnung.Name = "txtumrechnung"
        Me.txtumrechnung.Size = New System.Drawing.Size(86, 20)
        Me.txtumrechnung.TabIndex = 36
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(210, 63)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(45, 17)
        Me.CheckBox1.TabIndex = 37
        Me.CheckBox1.Text = "Fest"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(262, 63)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(56, 17)
        Me.CheckBox2.TabIndex = 38
        Me.CheckBox2.Text = "Stufen"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'txtprozent
        '
        Me.txtprozent.Location = New System.Drawing.Point(638, 109)
        Me.txtprozent.Name = "txtprozent"
        Me.txtprozent.Size = New System.Drawing.Size(77, 20)
        Me.txtprozent.TabIndex = 39
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 40
        Me.Label3.Text = "Prozent"
        '
        'TrackBar1
        '
        Me.TrackBar1.Location = New System.Drawing.Point(6, 109)
        Me.TrackBar1.Maximum = 100
        Me.TrackBar1.Name = "TrackBar1"
        Me.TrackBar1.Size = New System.Drawing.Size(628, 40)
        Me.TrackBar1.TabIndex = 41
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(715, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 31)
        Me.Label6.TabIndex = 42
        Me.Label6.Text = "%"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(3, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(750, 15)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "_________________________________________________________________________________" & _
    "__________________________________________________________"
        '
        'Identifikation
        '
        '
        'Btnstart
        '
        Me.Btnstart.Enabled = False
        Me.Btnstart.Image = Global.WindowsApplication1.My.Resources.Resources.appbar_control_play
        Me.Btnstart.Location = New System.Drawing.Point(638, 148)
        Me.Btnstart.Name = "Btnstart"
        Me.Btnstart.Size = New System.Drawing.Size(98, 37)
        Me.Btnstart.TabIndex = 44
        Me.Btnstart.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(355, 160)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(140, 13)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Zeit Format zur Speicherung"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(501, 157)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 46
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 160)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 47
        Me.Label13.Text = "Regelinterval"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(87, 157)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 48
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(198, 157)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 49
        '
        'check
        '
        Me.check.Enabled = True
        '
        'Notaus
        '
        '
        'sec
        '
        Me.sec.Interval = 1000
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Location = New System.Drawing.Point(222, 8)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(1, 30)
        Me.Label11.TabIndex = 50
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(6, 195)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(740, 23)
        Me.Button1.TabIndex = 51
        Me.Button1.Text = "Auswerten"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(380, 8)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 13)
        Me.Label12.TabIndex = 53
        Me.Label12.Text = "Sollwert"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(394, 21)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 13)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "--"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(430, 8)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(38, 13)
        Me.Label15.TabIndex = 54
        Me.Label15.Text = "Istwert"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(440, 20)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(13, 13)
        Me.Label16.TabIndex = 55
        Me.Label16.Text = "--"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 224)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Btnstart)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TrackBar1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtprozent)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txtumrechnung)
        Me.Controls.Add(Me.Btnend)
        Me.Controls.Add(Me.btnhelp)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbleinaus)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblnum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblconnect)
        Me.Controls.Add(Me.lblverbindung)
        Me.MaximumSize = New System.Drawing.Size(760, 258)
        Me.MinimumSize = New System.Drawing.Size(760, 258)
        Me.Name = "form1"
        Me.ShowIcon = False
        Me.Text = "SYSID Regelstrecke"
        CType(Me.TrackBar1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lbleinaus As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblnum As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblconnect As System.Windows.Forms.Label
    Friend WithEvents lblverbindung As System.Windows.Forms.Label
    Friend WithEvents Btnend As System.Windows.Forms.Button
    Friend WithEvents btnhelp As System.Windows.Forms.Button
    Friend WithEvents txtumrechnung As System.Windows.Forms.TextBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents txtprozent As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TrackBar1 As System.Windows.Forms.TrackBar
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Identifikation As System.Windows.Forms.Timer
    Friend WithEvents Btnstart As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents check As System.Windows.Forms.Timer
    Friend WithEvents Notaus As System.Windows.Forms.Timer
    Friend WithEvents sec As System.Windows.Forms.Timer
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label

End Class
