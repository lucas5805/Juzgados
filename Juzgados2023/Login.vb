Public Class Login
    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'Juzgados2023DataSet.login' Puede moverla o quitarla según sea necesario.
        Me.LoginTableAdapter.Fill(Me.Juzgados2023DataSet.login)
        Me.LoginTableAdapter.Fill(Me.Juzgados2023DataSet.login)
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim usuario As String = TextBox1.Text
        Dim contra As String = TextBox2.Text
        Dim correcto As Boolean = False

        For Each row As DataRow In Juzgados2023DataSet.login.Rows
            If usuario = row("usuario").ToString() AndAlso contra = row("Contrasena").ToString() Then
                correcto = True
                Exit For
            End If
        Next

        If correcto = True Then
            Menuprincipal.Show()
            Me.Close()
        Else
            MessageBox.Show("Usuario o contraseña incorrectos", "Error de inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class