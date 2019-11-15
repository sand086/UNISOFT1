<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CrearUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CrearUsuarios))
        Me.FileSystemWatcher1 = New System.IO.FileSystemWatcher()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.NombreUsuario = New System.Windows.Forms.Label()
        Me.Correo = New System.Windows.Forms.Label()
        Me.Contraseña = New System.Windows.Forms.Label()
        Me.NombreU = New System.Windows.Forms.TextBox()
        Me.CorreoU = New System.Windows.Forms.TextBox()
        Me.contrasena = New System.Windows.Forms.TextBox()
        Me.CrearUsuario = New System.Windows.Forms.Button()
        Me.CancelarUsuario = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FileSystemWatcher1
        '
        Me.FileSystemWatcher1.EnableRaisingEvents = True
        Me.FileSystemWatcher1.SynchronizingObject = Me
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.UNISOFT.My.Resources.Resources.unisoft
        Me.PictureBox1.Location = New System.Drawing.Point(141, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(197, 137)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.UseWaitCursor = True
        '
        'NombreUsuario
        '
        Me.NombreUsuario.AutoSize = True
        Me.NombreUsuario.Location = New System.Drawing.Point(127, 200)
        Me.NombreUsuario.Name = "NombreUsuario"
        Me.NombreUsuario.Size = New System.Drawing.Size(91, 13)
        Me.NombreUsuario.TabIndex = 2
        Me.NombreUsuario.Text = "Nombre Completo"
        '
        'Correo
        '
        Me.Correo.AutoSize = True
        Me.Correo.Location = New System.Drawing.Point(127, 271)
        Me.Correo.Name = "Correo"
        Me.Correo.Size = New System.Drawing.Size(38, 13)
        Me.Correo.TabIndex = 3
        Me.Correo.Text = "Correo"
        '
        'Contraseña
        '
        Me.Contraseña.AutoSize = True
        Me.Contraseña.Location = New System.Drawing.Point(127, 339)
        Me.Contraseña.Name = "Contraseña"
        Me.Contraseña.Size = New System.Drawing.Size(61, 13)
        Me.Contraseña.TabIndex = 4
        Me.Contraseña.Text = "Contraseña"
        '
        'NombreU
        '
        Me.NombreU.Location = New System.Drawing.Point(130, 232)
        Me.NombreU.Name = "NombreU"
        Me.NombreU.Size = New System.Drawing.Size(195, 20)
        Me.NombreU.TabIndex = 6
        '
        'CorreoU
        '
        Me.CorreoU.Location = New System.Drawing.Point(130, 297)
        Me.CorreoU.Name = "CorreoU"
        Me.CorreoU.Size = New System.Drawing.Size(195, 20)
        Me.CorreoU.TabIndex = 7
        '
        'contrasena
        '
        Me.contrasena.Location = New System.Drawing.Point(130, 365)
        Me.contrasena.Name = "contrasena"
        Me.contrasena.Size = New System.Drawing.Size(195, 20)
        Me.contrasena.TabIndex = 8
        '
        'CrearUsuario
        '
        Me.CrearUsuario.Location = New System.Drawing.Point(159, 391)
        Me.CrearUsuario.Name = "CrearUsuario"
        Me.CrearUsuario.Size = New System.Drawing.Size(129, 31)
        Me.CrearUsuario.TabIndex = 10
        Me.CrearUsuario.Text = "Crear Usuario"
        Me.CrearUsuario.UseVisualStyleBackColor = True
        '
        'CancelarUsuario
        '
        Me.CancelarUsuario.Location = New System.Drawing.Point(130, 466)
        Me.CancelarUsuario.Name = "CancelarUsuario"
        Me.CancelarUsuario.Size = New System.Drawing.Size(129, 31)
        Me.CancelarUsuario.TabIndex = 11
        Me.CancelarUsuario.Text = "Cancelar"
        Me.CancelarUsuario.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(172, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 25)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Crear Usuarios"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'CrearUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(495, 482)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CancelarUsuario)
        Me.Controls.Add(Me.CrearUsuario)
        Me.Controls.Add(Me.contrasena)
        Me.Controls.Add(Me.CorreoU)
        Me.Controls.Add(Me.NombreU)
        Me.Controls.Add(Me.Contraseña)
        Me.Controls.Add(Me.Correo)
        Me.Controls.Add(Me.NombreUsuario)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(511, 521)
        Me.MinimumSize = New System.Drawing.Size(511, 521)
        Me.Name = "CrearUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CrearUsuarios"
        CType(Me.FileSystemWatcher1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CrearUsuario As Button
    Friend WithEvents contrasena As TextBox
    Friend WithEvents CorreoU As TextBox
    Friend WithEvents NombreU As TextBox
    Friend WithEvents Contraseña As Label
    Friend WithEvents Correo As Label
    Friend WithEvents NombreUsuario As Label
    Friend WithEvents CancelarUsuario As Button
    Friend WithEvents Label1 As Label
End Class
