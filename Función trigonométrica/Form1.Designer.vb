<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.RadioButton_Adyacente = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Opuesto = New System.Windows.Forms.RadioButton()
        Me.RadioButton_Hipotenusa = New System.Windows.Forms.RadioButton()
        Me.TextBox_Adyacente = New System.Windows.Forms.TextBox()
        Me.TextBox_Opuesto = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button_Run = New System.Windows.Forms.Button()
        Me.TextBox_Hipotenusa = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadioButton_Adyacente
        '
        Me.RadioButton_Adyacente.AutoSize = True
        Me.RadioButton_Adyacente.ForeColor = System.Drawing.Color.Black
        Me.RadioButton_Adyacente.Location = New System.Drawing.Point(12, 25)
        Me.RadioButton_Adyacente.Name = "RadioButton_Adyacente"
        Me.RadioButton_Adyacente.Size = New System.Drawing.Size(81, 19)
        Me.RadioButton_Adyacente.TabIndex = 0
        Me.RadioButton_Adyacente.TabStop = True
        Me.RadioButton_Adyacente.Text = "Adyacente"
        Me.RadioButton_Adyacente.UseVisualStyleBackColor = True
        '
        'RadioButton_Opuesto
        '
        Me.RadioButton_Opuesto.AutoSize = True
        Me.RadioButton_Opuesto.ForeColor = System.Drawing.Color.Black
        Me.RadioButton_Opuesto.Location = New System.Drawing.Point(265, 25)
        Me.RadioButton_Opuesto.Name = "RadioButton_Opuesto"
        Me.RadioButton_Opuesto.Size = New System.Drawing.Size(71, 19)
        Me.RadioButton_Opuesto.TabIndex = 1
        Me.RadioButton_Opuesto.TabStop = True
        Me.RadioButton_Opuesto.Text = "Opuesto"
        Me.RadioButton_Opuesto.UseVisualStyleBackColor = True
        '
        'RadioButton_Hipotenusa
        '
        Me.RadioButton_Hipotenusa.AutoSize = True
        Me.RadioButton_Hipotenusa.ForeColor = System.Drawing.Color.Black
        Me.RadioButton_Hipotenusa.Location = New System.Drawing.Point(133, 25)
        Me.RadioButton_Hipotenusa.Name = "RadioButton_Hipotenusa"
        Me.RadioButton_Hipotenusa.Size = New System.Drawing.Size(88, 19)
        Me.RadioButton_Hipotenusa.TabIndex = 2
        Me.RadioButton_Hipotenusa.TabStop = True
        Me.RadioButton_Hipotenusa.Text = "Hipotenusa"
        Me.RadioButton_Hipotenusa.UseVisualStyleBackColor = True
        '
        'TextBox_Adyacente
        '
        Me.TextBox_Adyacente.Location = New System.Drawing.Point(119, 310)
        Me.TextBox_Adyacente.Name = "TextBox_Adyacente"
        Me.TextBox_Adyacente.Size = New System.Drawing.Size(52, 20)
        Me.TextBox_Adyacente.TabIndex = 4
        '
        'TextBox_Opuesto
        '
        Me.TextBox_Opuesto.Location = New System.Drawing.Point(284, 181)
        Me.TextBox_Opuesto.Name = "TextBox_Opuesto"
        Me.TextBox_Opuesto.Size = New System.Drawing.Size(52, 20)
        Me.TextBox_Opuesto.TabIndex = 5
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 85)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(266, 219)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Button_Run
        '
        Me.Button_Run.ForeColor = System.Drawing.Color.Black
        Me.Button_Run.Location = New System.Drawing.Point(157, 363)
        Me.Button_Run.Name = "Button_Run"
        Me.Button_Run.Size = New System.Drawing.Size(75, 23)
        Me.Button_Run.TabIndex = 7
        Me.Button_Run.Text = "Run"
        Me.Button_Run.UseVisualStyleBackColor = True
        '
        'TextBox_Hipotenusa
        '
        Me.TextBox_Hipotenusa.Location = New System.Drawing.Point(12, 120)
        Me.TextBox_Hipotenusa.Name = "TextBox_Hipotenusa"
        Me.TextBox_Hipotenusa.Size = New System.Drawing.Size(52, 20)
        Me.TextBox_Hipotenusa.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(177, 313)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(26, 15)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Cm"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(70, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(26, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Cm"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(341, 181)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 15)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Cm"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(379, 398)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox_Hipotenusa)
        Me.Controls.Add(Me.Button_Run)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox_Opuesto)
        Me.Controls.Add(Me.TextBox_Adyacente)
        Me.Controls.Add(Me.RadioButton_Hipotenusa)
        Me.Controls.Add(Me.RadioButton_Opuesto)
        Me.Controls.Add(Me.RadioButton_Adyacente)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RadioButton_Adyacente As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Opuesto As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton_Hipotenusa As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox_Adyacente As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_Opuesto As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button_Run As System.Windows.Forms.Button
    Friend WithEvents TextBox_Hipotenusa As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label

End Class
