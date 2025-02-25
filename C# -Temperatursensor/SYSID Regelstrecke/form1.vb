Option Explicit On
Option Strict Off
Imports System.Data.OleDb
Public Class form1
    Inherits System.Windows.Forms.Form
    '####################################
    'Karte Befehle
    '####################################

    Private Declare Function OpenDevice Lib "k8055d.dll" (ByVal CardAddress As Integer) As Integer
    Private Declare Sub CloseDevice Lib "k8055d.dll" ()
    Private Declare Function ReadAnalogChannel Lib "k8055d.dll" (ByVal Channel As Integer) As Integer
    Private Declare Sub ReadAllAnalog Lib "k8055d.dll" (ByRef Data1 As Integer, ByRef Data2 As Integer)
    Private Declare Sub OutputAnalogChannel Lib "k8055d.dll" (ByVal Channel As Integer, ByVal Data As Integer)
    Private Declare Sub OutputAllAnalog Lib "k8055d.dll" (ByVal Data1 As Integer, ByVal Data2 As Integer)
    Private Declare Sub ClearAnalogChannel Lib "k8055d.dll" (ByVal Channel As Integer)
    Private Declare Sub SetAllAnalog Lib "k8055d.dll" ()
    Private Declare Sub ClearAllAnalog Lib "k8055d.dll" ()
    Private Declare Sub SetAnalogChannel Lib "k8055d.dll" (ByVal Channel As Integer)
    Private Declare Sub WriteAllDigital Lib "k8055d.dll" (ByVal Data As Integer)
    Private Declare Sub ClearDigitalChannel Lib "k8055d.dll" (ByVal Channel As Integer)
    Private Declare Sub ClearAllDigital Lib "k8055d.dll" ()
    Private Declare Sub SetDigitalChannel Lib "k8055d.dll" (ByVal Channel As Integer)
    Private Declare Sub SetAllDigital Lib "k8055d.dll" ()
    Private Declare Function ReadDigitalChannel Lib "k8055d.dll" (ByVal Channel As Integer) As Boolean
    Private Declare Function ReadAllDigital Lib "k8055d.dll" () As Integer
    Private Declare Function ReadCounter Lib "k8055d.dll" (ByVal CounterNr As Integer) As Integer
    Private Declare Sub ResetCounter Lib "k8055d.dll" (ByVal CounterNr As Integer)
    Private Declare Sub SetCounterDebounceTime Lib "k8055d.dll" (ByVal CounterNr As Integer, ByVal DebounceTime As Integer)

    '####################################
    'Meine Deklaration
    '####################################
    Dim Digital1 As Boolean
    Dim Analog1 As Integer

    Dim zahlen As String = "1234567890"
    Dim zahlen2 As String = "abcdefghijklmnopqrstvwxyz"
    Dim p(9), q(25) As Char
    
    Dim sekunde As Integer

    Dim istwert As Single
    Dim sollwert As Single
    Dim connected As Boolean = False
    Dim stufe As Integer
    Dim soll2 As Single

    Dim festerwert, startstop As Boolean
    Dim prozent As Integer
    Public umrechnungswert As Single

    Dim ausgabewert As Single
    Dim time As Single
    Dim sekunden, minuten, stunden, tage, zeit, zformat, zintervall As Single
    Dim stufenintervall As Integer


    Dim pumrechnung As Single

    Dim connection As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Regelstrecke.mdb")
    Dim command As New OleDbCommand("", connection)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '####################################
        'Karte ini
        '####################################

        Dim i As Integer
        Dim CardAddress As Integer

        For i = 0 To 3
            CardAddress = OpenDevice(i)
            If CardAddress <> -1 Then Exit For
        Next i

        Select Case CardAddress
            Case 0, 1, 2, 3
                lblconnect.Text = "Connected"
                lblconnect.ForeColor = Color.Green
                lblnum.Text = CardAddress.ToString
                lblnum.ForeColor = Color.Green
                connected = True
            Case -1
                lblconnect.Text = "Not Found"
                lblconnect.ForeColor = Color.Red
                connected = False
        End Select

        '####################################
        'Setze Werte
        '####################################

        Call ini()

    End Sub
    Private Sub ini()

        TrackBar1.Minimum = 0
        TrackBar1.Maximum = 100
        txtprozent.Text = TrackBar1.Value
     


        ComboBox1.Items.Add("Millisekunden")
        ComboBox1.Items.Add("Sekunden")
        ComboBox1.Items.Add("Minuten")
        ComboBox1.Items.Add("Stunden")
        ComboBox1.Items.Add("Tage")

        ComboBox2.Items.Add("Millisekunden")
        ComboBox2.Items.Add("Sekunden")
        ComboBox2.Items.Add("Minuten")
        ComboBox2.Items.Add("Stunden")
        ComboBox2.Items.Add("Tage")

        TextBox1.Text = Identifikation.Interval

        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0

        umrechnungswert = -1

        CheckBox1.Checked = True
        startstop = True


        For i = 0 To 9
            p(i) = zahlen.Substring(i)
        Next
        For i = 0 To 25
            q(i) = zahlen2.Substring(i)
        Next
        txtumrechnung.Text = "5000"
        umrechnungswert = 5000
    End Sub
    Private Sub Btnend_Click(sender As Object, e As EventArgs) Handles Btnend.Click

        '####################################
        'Setze alles zurück; Beende
        '####################################

        ClearAllDigital()
        CloseDevice()
        Me.Close()

    End Sub
    Private Sub btnhelp_Click(sender As Object, e As EventArgs) Handles btnhelp.Click

        '####################################
        'Zeige Hilfe an
        '####################################

        formhelp.Show()

    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        '####################################
        'Festerwert und Prozent angabe = AN
        '####################################
        Label3.Text = "Prozent"
        CheckBox2.Checked = False
        txtprozent.Enabled = True
        TrackBar1.Enabled = True
        festerwert = True

    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged

        '####################################
        'Sprunghaft = AN
        '####################################

        Label3.Text = "Stufenintervall"
        CheckBox1.Checked = False
        festerwert = False
        stufenintervall = TrackBar1.Value

    End Sub

    Private Sub txtprozent_TextChanged(sender As Object, e As EventArgs) Handles txtprozent.TextChanged
        '####################################
        'Prozentangabe nur zahlen
        '####################################

        If txtprozent.Text.IndexOfAny(p) > -1 And txtprozent.Text.IndexOfAny(q) < 0 Then
            Dim zahl As Integer = Convert.ToInt32(txtprozent.Text)
            If zahl < 101 And zahl > 0 Then
                prozent = zahl
            End If
        End If

    End Sub
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        '####################################
        'Prozentangabe 
        '####################################

        txtprozent.Text = TrackBar1.Value

    End Sub

    Private Sub Identifikation_Tick(sender As Object, e As EventArgs) Handles Identifikation.Tick
        time = time + Identifikation.Interval
        '####################################
        'Lese Ist Zustand * Umrechnungsfaktor
        '####################################

        Analog1 = ReadAnalogChannel(1)
        istwert = Analog1 / 255
        istwert = istwert * umrechnungswert

        '########################################################################
        'Sollwert ermitteln/ Fester wert
        '########################################################################

        If festerwert = True Then
            ausgabewert = ((umrechnungswert * (prozent / 100)) / umrechnungswert) * 255
            OutputAnalogChannel(1, ausgabewert)

            '####################################
            'Zeit ermitteln
            '####################################

            Select Case ComboBox1.SelectedItem.ToString
                Case "Millisekunden"

                Case "Sekunden"
                    time = time / 1000
                Case "Minuten"
                    time = time / 1000 / 60
                Case "Stunden"
                    time = time / 1000 / 60 / 60
                Case "Tage"
                    time = time / 1000 / 60 / 60 / 24
            End Select


            '####################################
            'In die Datenbank schreiben
            '####################################

            Try
                command.CommandText = " INSERT INTO Messwerte (Zeitwerte,Sollwerte,Istwerte) VALUES ('" & time & "','" & (umrechnungswert * (prozent / 100)) & "','" & istwert & "')"
                connection.Open()
                command.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            connection.Close()
            soll2 = (umrechnungswert * (prozent / 100))
        End If

        '########################################################################
        'Sollwert ermitteln/ Stufenweise
        '########################################################################

        If festerwert = False Then

            pumrechnung = (prozent * stufe) / 100
            If pumrechnung > 1 Then
                pumrechnung = 1
            End If

            ausgabewert = ((umrechnungswert * pumrechnung) / umrechnungswert) * 255
            OutputAnalogChannel(1, ausgabewert)

            '####################################
            'Zeit ermitteln
            '####################################

            Select Case ComboBox1.SelectedItem.ToString
                Case "Millisekunden"

                Case "Sekunden"
                    time = time / 1000
                Case "Minuten"
                    time = time / 1000 / 60
                Case "Stunden"
                    time = time / 1000 / 60 / 60
                Case "Tage"
                    time = time / 1000 / 60 / 60 / 24
            End Select

            '####################################
            'In die Datenbank schreiben
            '####################################

            Try
                command.CommandText = " INSERT INTO Messwerte (Zeitwerte,Sollwerte,Istwerte) VALUES ('" & time & "','" & umrechnungswert * pumrechnung & "','" & istwert & "')"
                connection.Open()
                command.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            connection.Close()

            soll2 = umrechnungswert * pumrechnung
            stufe = stufe + 1
        End If



    End Sub

    Private Sub txtumrechnung_TextChanged(sender As Object, e As EventArgs) Handles txtumrechnung.TextChanged

        '####################################
        'Setze Sollwert
        '####################################

        If txtumrechnung.Text.IndexOfAny(p) > -1 And txtumrechnung.Text.IndexOfAny(q) < 0 Then
            Dim zahl As Integer = Convert.ToInt32(txtumrechnung.Text)
            umrechnungswert = zahl
        End If

    End Sub
    Private Sub Btnstart_Click(sender As Object, e As EventArgs) Handles Btnstart.Click
    
        '####################################
        'Timer an/aus
        '####################################

        Notaus.Enabled = True
        ClearAllDigital()

        If startstop = True Then
            time = 0
            Identifikation.Enabled = True
            stufe = 1
            Btnstart.Image = WindowsApplication1.My.Resources.Resources.appbar_stop
            lbleinaus.ForeColor = Color.Green
            lbleinaus.Text = "Ein"
            startstop = False

            sekunde = 0
            sec.Enabled = True

            '####################################
            'Datenbank leeren
            '####################################

            Try
                command.CommandText = " DELETE * FROM Messwerte"
                connection.Open()
                command.ExecuteNonQuery()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            connection.Close()

        Else
            Identifikation.Enabled = False
            Btnstart.Image = WindowsApplication1.My.Resources.Resources.appbar_control_play
            lbleinaus.ForeColor = Color.Red
            lbleinaus.Text = "Aus"
            startstop = True

            sekunde = 0
            sec.Enabled = False
            Label9.Text = "-"
        End If

    End Sub
    Private Sub check_Tick(sender As Object, e As EventArgs) Handles check.Tick

        '####################################
        'Checken ob alle nötigen 
        'informationen vorhanden sind
        '####################################

        zformat = ComboBox2.SelectedIndex
        zintervall = ComboBox1.SelectedIndex


        If festerwert = True And umrechnungswert > -1 And prozent > -1 And zformat > -1 And zintervall > -1 Then
            Me.Btnstart.Enabled = True
        ElseIf festerwert = False And umrechnungswert > -1 And zformat > -1 And zintervall > -1 Then
            Me.Btnstart.Enabled = True
        Else
            Me.Btnstart.Enabled = False
        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        '####################################
        'zintervall
        '####################################

        If TextBox1.Text.IndexOfAny(p) > -1 And TextBox1.Text.IndexOfAny(q) < 0 Then
            Dim zahl As Integer = Convert.ToInt32(TextBox1.Text)
            Select Case ComboBox2.SelectedItem.ToString
                Case "Millisekunden"
                    Identifikation.Interval = zahl
                Case "Sekunden"
                    Identifikation.Interval = zahl * 1000
                Case "Minuten"
                    Identifikation.Interval = zahl * 60000
                Case "Stunden"
                    Identifikation.Interval = zahl * 60000 * 60
                Case "Tage"
                    Identifikation.Interval = zahl * 60000 * 60 * 24
            End Select
        End If

    End Sub

    Private Sub Notaus_Tick(sender As Object, e As EventArgs) Handles Notaus.Tick

        Digital1 = ReadDigitalChannel(1)
        If Digital1 = True Then
            Identifikation.Enabled = False
            lbleinaus.ForeColor = Color.Red
            lbleinaus.Text = "AUS"
            Btnstart.Image = WindowsApplication1.My.Resources.Resources.appbar_control_play
            ClearAllDigital()
        End If

    End Sub

    Private Sub sec_Tick(sender As Object, e As EventArgs) Handles sec.Tick

        '####################################
        'Obiger Timer

        '####################################

        sekunde = sekunde + 1
        If sekunde < 60 Then
            Label9.Text = Math.Round(Convert.ToDecimal(sekunde), 2).ToString() & "s"
        Else
            Label9.Text = Math.Round(Convert.ToDecimal(sekunde / 60), 2).ToString() & "m"
        End If

        Label14.Text = soll2
        Label16.Text = istwert

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        '####################################
        'Zeige Auswertung an
        '####################################

        auswertung.Show()


    End Sub

  
    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged

        '####################################
        'textchange verursachen 
        '####################################

        Dim txt As String
        txt = TextBox1.Text
        TextBox1.Text = ""
        TextBox1.Text = txt

    End Sub
End Class
