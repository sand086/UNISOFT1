
Imports System.Data
Imports System.Data.SqlClient
Imports System.Threading
Public Class CrearUsuarios
    Public Conexion As String = "Data Source = DAVE\SQLEXPRESS; Initial Catalog = UsuariosUnisoft; Integrated Security = True"
    Private Sub CrearUsuario_Click(sender As Object, e As EventArgs) Handles CrearUsuario.Click
        Dim InsertUsuario As String
        Dim Nombre As String = NombreU.Text.ToUpper
        Dim correo As String = CorreoU.Text
        Dim pass As String = contrasena.Text
        'INSERTAMOS EL USUARIO EN LA TABLA DE UserUnisotf
        Using connection1 As New SqlConnection(Conexion)
            InsertUsuario = "insert into UserUnisotf values(" + "'" + Nombre + "'" + "," + "'" + correo + "'" + "," + "'" + pass + "'" + ", 0,0,0,0,0,0)"
            Dim command1 As New SqlCommand(InsertUsuario, connection1)
            command1.Parameters.Add("@Nombre", SqlDbType.VarChar)
            command1.Parameters("@Nombre").Value = Nombre
            command1.Parameters.Add("@correo", SqlDbType.VarChar)
            command1.Parameters("@correo").Value = correo
            command1.Parameters.Add("@pass", SqlDbType.VarChar)
            command1.Parameters("@pass").Value = pass

            Try
                connection1.Open()
                command1.ExecuteNonQuery()
                connection1.Close()
            Catch ex As Exception
                MsgBox("Nose Guardo El Registro Reportarlo a IT!")
                InicioSesion.Show()
                Me.Close()
            End Try
            Thread.Sleep(10000)
            MsgBox("Se Guardado el Registro Exitosamente!")
            InicioSesion.Show()
            Me.Hide()
            'LIMPIAMOS VARIABLES
            NombreU.Clear()
            CorreoU.Clear()
            contrasena.Clear()
        End Using
    End Sub
    Private Sub CancelarUsuario_Click(sender As Object, e As EventArgs) Handles CancelarUsuario.Click
        InicioSesion.Show()
        Me.Close()
    End Sub
End Class