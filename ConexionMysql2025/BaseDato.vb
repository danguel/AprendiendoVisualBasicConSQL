'importo espacio de nombre conector
Imports MySql.Data.MySqlClient

Module BaseDato
    'declaro variable/objeto conexion global
    Friend conexion As MySqlConnection

    Sub conectar()
        'uso try para controlar errores
        Try
            'genero conexion nueva
            conexion = New MySqlConnection

            Dim Cadena As String
            'traigo el string de conexion desde el txt
            Cadena = My.Computer.FileSystem.ReadAllText(My.Application.Info.DirectoryPath + "\conexion.txt")


            'genero string de conexion
            'Cadena = "server=localhost; user id=root; password=123456;database=biblioteca;port=3306;"

            'configuro la propiedad de la conexion
            conexion.ConnectionString = Cadena

            'pruebo la conexion
            conexion.Open()

            MsgBox("UD SE HA CONECTADO SUCESSFULL!! OH YEA!!")

            'cierro la conexion
            conexion.Close()

        Catch ex As Exception
            'obtengo el mensaje del conector o servidor
            MsgBox(ex.Message)

            MsgBox("ERROR DE BASE DE DATOS")
        End Try

    End Sub

End Module
