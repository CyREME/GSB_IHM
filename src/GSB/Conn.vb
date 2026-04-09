Public Class Conn
    ' Attention à bien mettre le bon User Id ici
    Private Shared ReadOnly chaineConnexion As String =
        "Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=10.0.221.5)(PORT=1521)))(CONNECT_DATA=(SERVICE_NAME=ORA05)));User Id=adminDB;Password=Iroise29;Connection Timeout=10;"

    Public Shared Function GetConnection() As OracleConnection
        Return New OracleConnection(chaineConnexion)
    End Function

    ' Methode pour récupérer des données depuis la base de données
    Public Shared Function getData(sql As String) As DataTable
        Dim dt As New DataTable()
        Using conn As OracleConnection = GetConnection()
            Dim cmd As New OracleCommand(sql, conn)
            Dim da As New OracleDataAdapter(cmd)
            da.Fill(dt)
        End Using
        Return dt
    End Function

    ' Méthode pour insert, update ou delete des données dans la base de données
    Public Shared Sub execute(sql As String)
        Using conn As OracleConnection = GetConnection()
            conn.Open()
            Dim cmd As New OracleCommand(sql, conn)
            cmd.ExecuteNonQuery()
        End Using
    End Sub

End Class