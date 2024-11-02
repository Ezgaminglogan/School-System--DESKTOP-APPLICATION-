Imports MySql.Data.MySqlClient

Module Connect
    Public Function cons() As MySqlConnection
        Return New MySqlConnection("SERVER = localhost; USER ID = root; PASSWORD = ; DATABASE = schoolsystem;")
    End Function
End Module
