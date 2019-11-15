<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UnisoftInicio
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UnisoftInicio))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ingresarsistema = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.UNISOFT.My.Resources.Resources.unisoftInicio
        Me.PictureBox1.Location = New System.Drawing.Point(381, 153)
        Me.PictureBox1.MaximumSize = New System.Drawing.Size(385, 225)
        Me.PictureBox1.MinimumSize = New System.Drawing.Size(385, 225)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(385, 225)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'ingresarsistema
        '
        Me.ingresarsistema.BackColor = System.Drawing.Color.Black
        Me.ingresarsistema.FlatAppearance.BorderSize = 0
        Me.ingresarsistema.ForeColor = System.Drawing.Color.White
        Me.ingresarsistema.Location = New System.Drawing.Point(494, 401)
        Me.ingresarsistema.Name = "ingresarsistema"
        Me.ingresarsistema.Size = New System.Drawing.Size(164, 48)
        Me.ingresarsistema.TabIndex = 1
        Me.ingresarsistema.Text = "Ingresar"
        Me.ingresarsistema.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(381, 480)
        Me.ProgressBar1.MaximumSize = New System.Drawing.Size(385, 23)
        Me.ProgressBar1.MinimumSize = New System.Drawing.Size(385, 23)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(385, 23)
        Me.ProgressBar1.TabIndex = 2
        '
        'Timer1
        '
        '
        'UnisoftInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1165, 607)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.ingresarsistema)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(1181, 646)
        Me.MinimumSize = New System.Drawing.Size(1181, 646)
        Me.Name = "UnisoftInicio"
        Me.Text = "UNISOFT"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ingresarsistema As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Timer1 As Timer
End Class
