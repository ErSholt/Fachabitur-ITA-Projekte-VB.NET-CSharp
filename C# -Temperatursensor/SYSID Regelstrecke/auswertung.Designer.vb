<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class auswertung
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(auswertung))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Btnend = New System.Windows.Forms.Button()
        Me.Btnstart = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lblgrad = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(9, 66)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(500, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'Btnend
        '
        Me.Btnend.BackgroundImage = CType(resources.GetObject("Btnend.BackgroundImage"), System.Drawing.Image)
        Me.Btnend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Btnend.Location = New System.Drawing.Point(464, 12)
        Me.Btnend.Name = "Btnend"
        Me.Btnend.Size = New System.Drawing.Size(45, 50)
        Me.Btnend.TabIndex = 36
        Me.Btnend.UseVisualStyleBackColor = True
        '
        'Btnstart
        '
        Me.Btnstart.Image = Global.WindowsApplication1.My.Resources.Resources.appbar_control_play
        Me.Btnstart.Location = New System.Drawing.Point(413, 12)
        Me.Btnstart.Name = "Btnstart"
        Me.Btnstart.Size = New System.Drawing.Size(45, 50)
        Me.Btnstart.TabIndex = 45
        Me.Btnstart.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(401, 15)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "_________________________________________________________________________________" & _
    "__________________________________________________________"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 47
        Me.Label1.Text = "Auswertung"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(81, 23)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(81, 17)
        Me.CheckBox1.TabIndex = 48
        Me.CheckBox1.Text = "Tabelarisch"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(168, 23)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(65, 17)
        Me.CheckBox2.TabIndex = 49
        Me.CheckBox2.Text = "Grafisch"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(9, 222)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(500, 200)
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(239, 21)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 51
        '
        'Label11
        '
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label11.Location = New System.Drawing.Point(161, 15)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(1, 30)
        Me.Label11.TabIndex = 52
        '
        'lblgrad
        '
        Me.lblgrad.AutoSize = True
        Me.lblgrad.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgrad.Location = New System.Drawing.Point(60, 21)
        Me.lblgrad.Name = "lblgrad"
        Me.lblgrad.Size = New System.Drawing.Size(95, 31)
        Me.lblgrad.TabIndex = 53
        Me.lblgrad.Text = "Label2"
        Me.lblgrad.Visible = False
        '
        'auswertung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(518, 431)
        Me.Controls.Add(Me.lblgrad)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Btnstart)
        Me.Controls.Add(Me.Btnend)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "auswertung"
        Me.ShowIcon = False
        Me.Text = "Auswertung"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Btnend As System.Windows.Forms.Button
    Friend WithEvents Btnstart As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents lblgrad As System.Windows.Forms.Label
End Class
