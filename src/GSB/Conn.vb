Public Class Conn
    ' Attention à bien mettre le bon User Id ici
    Private Shared ReadOnly chaineConnexion As String =
        "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=10.0.221.5)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=ORA05)));User Id=adminDB;Password=Iroise29;Connection Timeout=10;"

    Public Shared Function GetConnection() As OracleConnection
        Return New OracleConnection(chaineConnexion)
    End Function
End Class