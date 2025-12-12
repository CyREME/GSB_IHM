Imports Oracle.ManagedDataAccess.Client
Imports Conn
Imports System.Security.Cryptography
Imports System.Text

Public Class Login

    Private Property MoveForm As Boolean
    Private Property MoveForm_MousePosition As Point
    Private Property MoveForm_Position As Point


    '' Partie connexion à la base de données
    Dim connexionSql As OracleConnection




    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Txt_Username.Text = "Login"
        Txt_Username.ForeColor = Color.DarkGray
        Txt_Password.Text = "Mot de passe"
        Txt_Password.ForeColor = Color.DarkGray
        Txt_Password.PasswordChar = ""

    End Sub


    ' ---------------------------------------------------------
    ' La fonction qui transforme "1234" en "03ac67..."
    ' ---------------------------------------------------------
    Public Function GenererHashSHA256(texte As String) As String
        Using sha256 As SHA256 = SHA256.Create()
            Dim bytes As Byte() = Encoding.UTF8.GetBytes(texte)
            Dim hash As Byte() = sha256.ComputeHash(bytes)
            Dim builder As New StringBuilder()
            For Each b As Byte In hash
                builder.Append(b.ToString("x2"))
            Next
            Return builder.ToString()
        End Using
    End Function



    '' Ici c'est pour pouvoir déplacer la fenêtre en cliquant sur le panel du haut ou le label Login
    Private Sub PanelHeader_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelHeader.MouseDown, Login_label.MouseUp, Login_label.MouseDown
        MoveForm = True
        MoveForm_MousePosition = Cursor.Position
        MoveForm_Position = Location
    End Sub

    Private Sub PanelHeader_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelHeader.MouseMove, Login_label.MouseUp, Login_label.MouseMove
        If MoveForm Then
            Dim dif = New Point(Cursor.Position.X - MoveForm_MousePosition.X, Cursor.Position.Y - MoveForm_MousePosition.Y)
            Location = New Point(MoveForm_Position.X + dif.X, MoveForm_Position.Y + dif.Y)
        End If
    End Sub

    Private Sub PanelHeader_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelHeader.MouseUp, Login_label.MouseUp
        MoveForm = False
    End Sub






    '' Ici c'est ce qui permet d'afficher du texte par défaut dans les textbox et de le faire disparaître quand on clique dessus
    Private Sub Txt_Username_TextChanged_1(sender As Object, e As EventArgs) Handles Txt_Username.GotFocus
        If Txt_Username.Text = "Login" Then
            Txt_Username.Text = ""
            Txt_Username.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Txt_Username_LostFocus(sender As Object, e As EventArgs) Handles Txt_Username.LostFocus
        If Txt_Username.Text = "" Then
            Txt_Username.Text = "Login"
            Txt_Username.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub Txt_Password_TextChanged_1(sender As Object, e As EventArgs) Handles Txt_Password.GotFocus
        If Txt_Password.Text = "Mot de passe" Then
            Txt_Password.Text = ""
            Txt_Password.PasswordChar = "*"c
            Txt_Password.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Txt_Password_LostFocus(sender As Object, e As EventArgs) Handles Txt_Password.LostFocus
        If Txt_Password.Text = "" Then
            Txt_Password.Text = "Mot de passe"
            Txt_Password.PasswordChar = ""
            Txt_Password.ForeColor = Color.DarkGray
        End If
    End Sub






    '' Ici c'est pour les boutons de la fenêtre
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_login_Click(sender As Object, e As EventArgs) Handles btn_login.Click

        If Txt_Password.Text = "Mot de passe" Or Txt_Username.Text = "Login" Then
            MessageBox.Show("Veuillez entrer vos identifiants.")
            Exit Sub
        End If

        ''Recupéraition des informations
        Dim login As String = Txt_Username.Text
        Dim password As String = GenererHashSHA256(Txt_Password.Text)
        Dim role As String = ""

        Dim dbConn As New Conn()
        connexionSql = dbConn.GetConnection()

        Try
            connexionSql.Open()

            Dim sql As String = "SELECT ROLE FROM UTILISATEUR WHERE LOGIN = :p_login AND MOTDEPASSE = :p_mdp"
            Dim cmd As New OracleCommand(sql, connexionSql)

            cmd.Parameters.Add(New OracleParameter("p_login", login))
            cmd.Parameters.Add(New OracleParameter("p_mdp", password))

            Dim result = cmd.ExecuteScalar()

            If result IsNot Nothing Then
                role = result.ToString()

                Select Case role
                    Case "Visiteur"
                        Dim visiteurForm As New Visiteur()
                        visiteurForm.Show()
                        Me.Hide()

                    Case "Delegue"
                        Dim delegueForm As New Delegue()
                        delegueForm.Show()
                        Me.Hide()

                    Case "Responsable"
                        Dim responsableForm As New Responsable()
                        responsableForm.Show()
                        Me.Hide()

                    Case Else
                        MessageBox.Show("Erreur : Rôle inconnu (" & role & ")")
                End Select

            Else
                MessageBox.Show("Identifiant ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        Catch ex As Exception
            MessageBox.Show("Erreur de connexion : " & ex.Message)
        Finally
            If connexionSql.State = ConnectionState.Open Then
                connexionSql.Close()
            End If
        End Try

    End Sub
End Class