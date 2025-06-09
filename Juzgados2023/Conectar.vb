Module Conectar
    Public cmd As New SqlClient.SqlCommand
    Public dr As SqlClient.SqlDataReader
    Public conexion As New SqlClient.SqlConnection("Data Source=DESKTOP-NKI4B61;Initial Catalog=juzgados2023;Persist Security Info=True;User ID=lucas;Password=5805")
    Public Sub conectar() 'FUNCION PARA ABRIR LA CONEXIONv
        Try
            If conexion.State = ConnectionState.Closed Then
                conexion.Open()
                cmd.Connection = conexion

            End If
        Catch ex As Exception
            MsgBox("Error al conectar con el servidor: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub
    Public Sub cerrarConexion()
        If conexion.State = ConnectionState.Open Then
            conexion.Close()
        End If
    End Sub
End Module
