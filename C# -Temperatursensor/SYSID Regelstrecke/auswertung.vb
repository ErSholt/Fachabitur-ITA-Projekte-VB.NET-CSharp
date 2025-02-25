Option Explicit On
Option Strict Off
Imports System.Data.OleDb
Class auswertung

    Dim connection As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=Regelstrecke.mdb")
    Dim command As New OleDbCommand("", connection)
    Dim da As New OleDbDataAdapter(Command)
    Dim ds As New DataSet
    Dim dt As New DataTable
    Dim Zeile As DataRow

    Dim p(9), q(25) As Char
    Dim grf As Graphics
    Dim P1 As New Pen(Color.DarkGray, 1)
    Dim P2 As New Pen(Color.Red, 1)
    Dim P3 As New Pen(Color.Green, 1)
    Dim P4 As New Pen(Color.DarkGray, 1)
    Dim F1 As New Font("Arial", 6)
    Dim F2 As New Font("Arial", 15)
    Dim B1 As New SolidBrush(Color.Black)

    Dim ersterstart As Boolean = True
    Dim ersterstart2 As Boolean = True

    Dim maxy, alty, alty2 As Single
    Dim maxy25, maxy50, maxy75, maxx As Single
    Dim i, a, a2 As Integer
    Dim time As Single
    Dim weite As Single

    Dim fehler As Integer

    Private Sub auswertung_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.MinimumSize = New Size(534, 103)
        Me.MaximumSize = New Size(534, 103)

        ComboBox1.Items.Add("Millisekunden")
        ComboBox1.Items.Add("Sekunden")
        ComboBox1.Items.Add("Minuten")
        ComboBox1.Items.Add("Stunden")
        ComboBox1.Items.Add("Tage")

        ComboBox1.SelectedIndex = 0
        grf = PictureBox1.CreateGraphics()
    End Sub

    Private Sub Btnstart_Click(sender As Object, e As EventArgs) Handles Btnstart.Click

        '####################################
        'Zählen
        '####################################


    
        command.CommandText = "SELECT * FROM Messwerte"
        ds.Clear()
        connection.Open()
        da.Fill(ds, "Messungen")
        dt = ds.Tables.Item("Messungen")
        connection.Close()
        ersterstart = True
        ersterstart2 = True

        For Each Me.Zeile In dt.Rows
            i = i + 1
            maxx = Zeile!Zeitwerte
        Next



        weite = (480 - 20) / i



        '############################################################################################################
        'Grafisch und Tabelarisch
        '############################################################################################################

        If CheckBox1.Checked = True And CheckBox2.Checked = True Then

            Me.MinimumSize = New Size(534, 469)
            Me.MaximumSize = New Size(534, 469)
            PictureBox1.Location = New Size(9, 222)
            DataGridView1.Visible = True
            PictureBox1.Visible = True

            '####################################
            'Grafisch
            '####################################
            Call grafik()

            '####################################
            'Tabellarisch
            '####################################

            Call datenbank()
            '############################################################################################################
            'Nur Grafisch
            '############################################################################################################
        ElseIf CheckBox1.Checked = False And CheckBox2.Checked = True Then
          

            Me.MinimumSize = New Size(534, 309)
            Me.MaximumSize = New Size(534, 309)
            PictureBox1.Location = New Size(9, 66)
            DataGridView1.Visible = False
            PictureBox1.Visible = True
            Call grafik()

            '############################################################################################################
            'Nur Tabellarisch
            '############################################################################################################

        ElseIf CheckBox1.Checked = True And CheckBox2.Checked = False Then

            DataGridView1.Visible = True
            PictureBox1.Visible = False
            Me.MinimumSize = New Size(534, 260)
            Me.MaximumSize = New Size(534, 260)
            Call datenbank()
        End If


    End Sub

    Private Sub Btnend_Click(sender As Object, e As EventArgs) Handles Btnend.Click
        Me.Close()
    End Sub
    Private Sub grafik()


        i = 0
        a = 0
        a2 = 0
        ersterstart = True
        ersterstart2 = True

        For Each Me.Zeile In dt.Rows
            i = i + 1
        Next


        weite = (PictureBox1.Width - 20) / i
        '####################################
        'Setze werte
        '####################################
        maxy = form1.umrechnungswert

        maxy25 = maxy * 0.25
        maxy50 = maxy * 0.5
        maxy75 = maxy * 0.75

 

        '####################################
        'Zeichne Tabelle
        '####################################



        grf.DrawLine(P1, 20, 50, PictureBox1.Width, 50)
        grf.DrawLine(P1, 20, 100, PictureBox1.Width, 100)
        grf.DrawLine(P1, 20, 150, PictureBox1.Width, 150)
        grf.DrawLine(P1, 20, 180, 20, 0)

        grf.DrawString(maxy75, F1, B1, 0, 45)
        grf.DrawString(maxy50, F1, B1, 0, 95)
        grf.DrawString(maxy25, F1, B1, 0, 145)
        grf.DrawString(0, F2, B1, 20, 180)

        For Each Me.Zeile In dt.Rows
            '####################################
            'Zeichne istwert / sollwert
            '####################################

            time = Zeile!Zeitwerte
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

            '******istwert
            Dim ywert, next2 As Single
            ywert = Zeile!Istwerte / (maxy / 100)
            next2 = (200 / 100) * ywert

            If ersterstart = True Then
                ersterstart = False
                grf.DrawLine(P2, 20, 200, 20 + weite * a + weite, 200 - next2)
                alty = next2
            Else
                a = a + 1
                grf.DrawLine(P2, 20 + weite * a, 200 - alty, 20 + weite * a + weite, 200 - next2)
                alty = next2
            End If

            '******Sollwert
            Dim ywert3, next3 As Single
            ywert3 = Zeile!Sollwerte / (maxy / 100)
            next3 = (200 / 100) * ywert3

            If ersterstart2 = True Then
                ersterstart2 = False
                grf.DrawLine(P3, 20, 200, 20 + weite * a2 + weite, 200 - next3)
                alty2 = next3
            Else
                a2 = a2 + 1
                grf.DrawLine(P3, 20 + weite * a2, 200 - alty2, 20 + weite * a2 + weite, 200 - next3)
                alty2 = next3
            End If

            '####################################
            '´Zeitabschnitte
            'Hatte funktioniert doch aus unbekannten problemen plötzlich nicht mehr 
            '####################################

            'Select Case weite * a2
            '    Case (480 / 10) * 2
            '        grf.DrawString(time, F2, B1, 20 + weite * a2, 180)
            '        grf.DrawLine(P1, 20 + weite * a2, 200, 20 + weite * a2, 0)
            '    Case (480 / 10) * 4
            '        grf.DrawString(time, F2, B1, 20 + weite * a2, 180)
            '        grf.DrawLine(P1, 20 + weite * a2, 200, 20 + weite * a2, 0)
            '    Case (480 / 10) * 6
            '        grf.DrawString(time, F2, B1, 20 + weite * a2, 180)
            '        grf.DrawLine(P1, 20 + weite * a2, 200, 20 + weite * a2, 0)
            '    Case (480 / 10) * 8
            '        grf.DrawString(time, F2, B1, 20 + weite * a2, 180)
            '        grf.DrawLine(P1, 20 + weite * a2, 200, 20 + weite * a2, 0)
            '    Case 480
            '        grf.DrawString(time, F2, B1, 20 + weite * a2, 180)
            '        grf.DrawLine(P1, 20 + weite * a2, 200, 20 + weite * a2, 0)
            'End Select

            'fehler = fehler + 1
            'Select Case fehler
            '    Case fehler = Int(i / 5)
            '        grf.DrawString(time, F2, B1, 20 + weite * a2, 180)
            '        grf.DrawLine(P1, 20 + weite * a2, 200, 20 + weite * a2, 0)
            '        fehler = 0
            'End Select

        Next












    End Sub
    Private Sub datenbank()
        ds.Clear()
        command.CommandText = "SELECT * FROM Messwerte"
        Try
            connection.Open()
            da.Fill(ds, "Messen")
            connection.Close()
            DataGridView1.DataBindings.Clear()
            DataGridView1.DataBindings.Add("datasource", ds, "Messen")     '
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox1_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox1.MouseMove
        Dim YPos = e.Y
        Dim XPos = e.X
        Label1.Visible = False
        Label5.Visible = False
        Label11.Visible = False
        CheckBox1.Visible = False
        CheckBox2.Visible = False
        ComboBox1.Visible = False

        Select Case ComboBox1.SelectedItem.ToString

            Case "Millisekunden"
                If 100 - YPos / 2 < 0 Then
                    lblgrad.Text = "Wert " & (100 - YPos / 2 * -1) * (form1.umrechnungswert / 100) & " | " & ((maxx / 500) * XPos + 20) & "mil"
                Else
                    lblgrad.Text = "Wert " & (100 - YPos / 2) * (form1.umrechnungswert / 100) & " | " & ((maxx / 500) * XPos + 20) & "mil"
                End If
            Case "Sekunden"
                If 100 - YPos / 2 < 0 Then
                    lblgrad.Text = "Wert " & (100 - YPos / 2 * -1) * (form1.umrechnungswert / 100) & " | " & ((maxx / 500) * XPos + 20) / 60 & "Sec"
                Else
                    lblgrad.Text = "Wert " & (100 - YPos / 2) * (form1.umrechnungswert / 100) & " | " & ((maxx / 500) * XPos + 20) / 60 & "Sec"
                End If
            Case "Minuten"
                If 100 - YPos / 2 < 0 Then
                    lblgrad.Text = "Wert " & (100 - YPos / 2 * -1) * (form1.umrechnungswert / 100) & " | " & ((maxx / 500) * XPos + 20) / 60 / 60 & "M"
                Else
                    lblgrad.Text = "Wert " & (100 - YPos / 2) * (form1.umrechnungswert / 100) & " | " & ((maxx / 500) * XPos + 20) / 60 / 60 & "M"
                End If
            Case "Stunden"
                If 100 - YPos / 2 < 0 Then
                    lblgrad.Text = "Wert " & (100 - YPos / 2 * -1) * (form1.umrechnungswert / 100) & " | " & ((maxx / 500) * XPos + 20) / 60 / 60 / 60 & "H"
                Else
                    lblgrad.Text = "Wert " & (100 - YPos / 2) * (form1.umrechnungswert / 100) & " | " & ((maxx / 500) * XPos + 20) / 60 / 60 / 60 & "H"
                End If
            Case "Tage"
                If 100 - YPos / 2 < 0 Then
                    lblgrad.Text = "Wert " & (100 - YPos / 2 * -1) * (form1.umrechnungswert / 100) & " | " & ((maxx / 500) * XPos + 20) / 60 / 60 / 60 / 24 & "T"
                Else
                    lblgrad.Text = "Wert " & (100 - YPos / 2) * (form1.umrechnungswert / 100) & " | " & ((maxx / 500) * XPos + 20) / 60 / 60 / 60 / 24 & "T"
                End If
        End Select


        lblgrad.Visible = True

    End Sub

    Private Sub PictureBox1_MouseLeave(sender As Object, e As EventArgs) Handles PictureBox1.MouseLeave
        Label1.Visible = True
        Label5.Visible = True
        Label11.Visible = True
        CheckBox1.Visible = True
        CheckBox2.Visible = True
        ComboBox1.Visible = True

        lblgrad.Visible = False
    End Sub
End Class