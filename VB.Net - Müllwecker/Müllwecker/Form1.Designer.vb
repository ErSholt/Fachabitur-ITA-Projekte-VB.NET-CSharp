<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.picanzeige = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnende = New System.Windows.Forms.Button()
        CType(Me.picanzeige, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 289)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(406, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Config"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'picanzeige
        '
        Me.picanzeige.BackColor = System.Drawing.Color.Transparent
        Me.picanzeige.Location = New System.Drawing.Point(13, 40)
        Me.picanzeige.Name = "picanzeige"
        Me.picanzeige.Size = New System.Drawing.Size(406, 243)
        Me.picanzeige.TabIndex = 1
        Me.picanzeige.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Made by Erik Südholt"
        '
        'btnende
        '
        Me.btnende.Location = New System.Drawing.Point(13, 319)
        Me.btnende.Name = "btnende"
        Me.btnende.Size = New System.Drawing.Size(406, 23)
        Me.btnende.TabIndex = 3
        Me.btnende.Text = "Beenden"
        Me.btnende.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 351)
        Me.Controls.Add(Me.btnende)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.picanzeige)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Müllwecker"
        CType(Me.picanzeige, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents picanzeige As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnende As System.Windows.Forms.Button

End Class
