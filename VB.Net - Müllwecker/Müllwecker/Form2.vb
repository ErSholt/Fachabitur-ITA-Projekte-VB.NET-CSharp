Public Class Form2

    Dim i As Integer = -1
    Dim l As Integer = -1
    Dim letztes As Integer
    Dim farbe(2000), farbe1 As String
    Dim datum(2000), datum1 As Date
    Dim neu As Boolean = False

    Private Sub btntermin_Click(sender As Object, e As EventArgs) Handles btntermin.Click
        'Gibt den vorher eingegebenen Termin in die Liste ein

        datum1 = txtdatum.Text
        farbe1 = txtfarbe.Text

        FileOpen(1, "terminliste.txt", OpenMode.Append)
        WriteLine(1, datum1, farbe1)
        FileClose(1)

        neu = True

    End Sub

    Private Sub btnanzeige_Click(sender As Object, e As EventArgs) Handles btnanzeige.Click
        'Zeigt alle Termine in der Listbox an

        lstanzeige.Items.Clear()
        i = -1

        FileOpen(1, "terminliste.txt", OpenMode.Input)
        Do While Not EOF(1)
            i = i + 1
            Input(1, datum(i))
            Input(1, farbe(i))



            lstanzeige.Items.Add(datum(i) & ", " & farbe(i))
        Loop
        FileClose(1)


    End Sub

    Private Sub btnfertig_Click(sender As Object, e As EventArgs) Handles btnfertig.Click
        'Schließt die Config und updatet den müllwecker mit den neuesten daten, fals neue dazu kamen

        If neu = True Then
            i = i - 1

            FileOpen(1, "terminliste.txt", OpenMode.Input)
            Do While Not EOF(1)

                i = i + 1
                Input(1, datum(i))
                Input(1, farbe(i))

                If datum(i) = Today.AddDays(1) Then

                    If farbe(i) = "blau" Then
                        Form1.picanzeige.BackColor = Color.Blue
                        Exit Do

                    ElseIf farbe(i) = "gelb" Then
                        Form1.picanzeige.BackColor = Color.Yellow
                        Exit Do

                    ElseIf farbe(i) = "braun" Then
                        Form1.picanzeige.BackColor = Color.SaddleBrown
                        Exit Do

                    ElseIf farbe(i) = "schwarz" Then
                        Form1.picanzeige.BackColor = Color.Black
                        Exit Do

                    ElseIf farbe(i) = "rot" Then
                        Form1.picanzeige.BackColor = Color.Red
                        Exit Do

                    End If

                End If

            Loop
            FileClose(1)

            Me.Close()
            Form1.Show()

        ElseIf neu = False Then
            Me.Close()
            Form1.Show()
        End If


    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        btntermin.Enabled = False

        neu = False


    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        'Führt ein komplettes reset der liste durch

        FileOpen(1, "terminliste.txt", OpenMode.Output)
        FileClose(1)
        Form1.picanzeige.BackColor = Color.Transparent



    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtdatum_TextChanged(sender As Object, e As EventArgs) Handles txtdatum.TextChanged

        If IsDate(txtdatum.Text) And (txtfarbe.Text = "blau" Or txtfarbe.Text = "rot" Or txtfarbe.Text = "schwarz" Or txtfarbe.Text = "gelb") Then


            btntermin.Enabled = True

        Else

            btntermin.Enabled = True


        End If



    End Sub

    Private Sub txtfarbe_TextChanged(sender As Object, e As EventArgs) Handles txtfarbe.TextChanged

        If IsDate(txtdatum.Text) And (txtfarbe.Text = "blau" Or txtfarbe.Text = "rot" Or txtfarbe.Text = "schwarz" Or txtfarbe.Text = "gelb") Then


            btntermin.Enabled = True
        Else
           
            btntermin.Enabled = False

        End If





    End Sub

    Private Sub btnalt_Click(sender As Object, e As EventArgs) Handles btnalt.Click

        i = -1
        FileOpen(1, "terminliste.txt", OpenMode.Input)
        Do While Not EOF(1)
            i = i + 1
            Input(1, datum(i))
            Input(1, farbe(i))

        Loop
        FileClose(1)
        letztes = i


        FileOpen(1, "terminliste.txt", OpenMode.Output)
        For i = -1 To letztes
            If datum(i) >= Today.AddDays(1) Then
                WriteLine(1, datum(i), farbe(i))
            Else

            End If
        Next i
        FileClose(1)



    End Sub
End Class