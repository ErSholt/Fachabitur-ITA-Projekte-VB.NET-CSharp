Public Class Form1
    Dim i, x As Integer
    Dim datum(2000), datum1 As Date
    Dim farbe(2000) As String



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Verbergt den Müllwecker und zeigt die Config an

        Form2.Show()
        Me.Hide()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label1.Text = "Morgen am " & Today.AddDays(1) & " muss die Mülltonne mit folgender Farbe raus gestellt werden:"





      

        'Sucht nach dem termin in der liste für morgen und zeigt dann in der picture box die farbe der dazu gehörigen mülltonne an
        i = -1
        FileOpen(1, "terminliste.txt", OpenMode.Input)
        Do While Not EOF(1)

            i = i + 1
            Input(1, datum(i))
            Input(1, farbe(i))

            If datum(i) = Today.AddDays(1) Then

                If farbe(i) = "blau" Then
                    picanzeige.BackColor = Color.Blue
                    Exit Do

                ElseIf farbe(i) = "gelb" Then
                    picanzeige.BackColor = Color.Yellow
                    Exit Do

                ElseIf farbe(i) = "braun" Then
                    picanzeige.BackColor = Color.SaddleBrown
                    Exit Do

                ElseIf farbe(i) = "schwarz" Then
                    picanzeige.BackColor = Color.Black
                    Exit Do

                ElseIf farbe(i) = "rot" Then
                    picanzeige.BackColor = Color.Red
                    Exit Do


                End If

            End If

        Loop
        FileClose(1)


    End Sub

    
    Private Sub btnende_Click(sender As Object, e As EventArgs) Handles btnende.Click
        'schließt den Müllwecker

        End

    End Sub
End Class
