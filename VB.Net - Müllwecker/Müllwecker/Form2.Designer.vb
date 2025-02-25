<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtdatum = New System.Windows.Forms.TextBox()
        Me.txtfarbe = New System.Windows.Forms.TextBox()
        Me.btntermin = New System.Windows.Forms.Button()
        Me.btnanzeige = New System.Windows.Forms.Button()
        Me.lstanzeige = New System.Windows.Forms.ListView()
        Me.btnfertig = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnalt = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Datums des Termines eingeben:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "               (TT/MM/YY)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(189, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(170, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Die Farbe der Mülltone einegeben:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(Rot, Blau, Gelb, Schwarz, Braun)"
        '
        'txtdatum
        '
        Me.txtdatum.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.txtdatum.Location = New System.Drawing.Point(16, 42)
        Me.txtdatum.Name = "txtdatum"
        Me.txtdatum.Size = New System.Drawing.Size(156, 20)
        Me.txtdatum.TabIndex = 2
        '
        'txtfarbe
        '
        Me.txtfarbe.Location = New System.Drawing.Point(192, 42)
        Me.txtfarbe.Name = "txtfarbe"
        Me.txtfarbe.Size = New System.Drawing.Size(164, 20)
        Me.txtfarbe.TabIndex = 3
        '
        'btntermin
        '
        Me.btntermin.Location = New System.Drawing.Point(16, 68)
        Me.btntermin.Name = "btntermin"
        Me.btntermin.Size = New System.Drawing.Size(340, 23)
        Me.btntermin.TabIndex = 4
        Me.btntermin.Text = "Eingabe des Termines in die Liste!"
        Me.btntermin.UseVisualStyleBackColor = True
        '
        'btnanzeige
        '
        Me.btnanzeige.Location = New System.Drawing.Point(16, 97)
        Me.btnanzeige.Name = "btnanzeige"
        Me.btnanzeige.Size = New System.Drawing.Size(340, 23)
        Me.btnanzeige.TabIndex = 5
        Me.btnanzeige.Text = "Anzeige aller Termine!"
        Me.btnanzeige.UseVisualStyleBackColor = True
        '
        'lstanzeige
        '
        Me.lstanzeige.Location = New System.Drawing.Point(16, 126)
        Me.lstanzeige.Name = "lstanzeige"
        Me.lstanzeige.Size = New System.Drawing.Size(340, 195)
        Me.lstanzeige.TabIndex = 6
        Me.lstanzeige.UseCompatibleStateImageBehavior = False
        '
        'btnfertig
        '
        Me.btnfertig.Location = New System.Drawing.Point(16, 384)
        Me.btnfertig.Name = "btnfertig"
        Me.btnfertig.Size = New System.Drawing.Size(340, 23)
        Me.btnfertig.TabIndex = 7
        Me.btnfertig.Text = "Fertig"
        Me.btnfertig.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(16, 355)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(340, 23)
        Me.btndelete.TabIndex = 8
        Me.btndelete.Text = "Löschen aller Termine"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnalt
        '
        Me.btnalt.Location = New System.Drawing.Point(16, 326)
        Me.btnalt.Name = "btnalt"
        Me.btnalt.Size = New System.Drawing.Size(340, 23)
        Me.btnalt.TabIndex = 9
        Me.btnalt.Text = "Alte Termine Löschen"
        Me.btnalt.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(375, 409)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnalt)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnfertig)
        Me.Controls.Add(Me.lstanzeige)
        Me.Controls.Add(Me.btnanzeige)
        Me.Controls.Add(Me.btntermin)
        Me.Controls.Add(Me.txtfarbe)
        Me.Controls.Add(Me.txtdatum)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form2"
        Me.ShowIcon = False
        Me.Text = "Müllwecker - Config"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtdatum As System.Windows.Forms.TextBox
    Friend WithEvents txtfarbe As System.Windows.Forms.TextBox
    Friend WithEvents btntermin As System.Windows.Forms.Button
    Friend WithEvents btnanzeige As System.Windows.Forms.Button
    Friend WithEvents lstanzeige As System.Windows.Forms.ListView
    Friend WithEvents btnfertig As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnalt As System.Windows.Forms.Button
End Class
