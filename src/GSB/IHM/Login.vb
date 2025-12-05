Imports Oracle.ManagedDataAccess.Client
Imports Conn
Public Class Login

    Private Property MoveForm As Boolean
    Private Property MoveForm_MousePosition As Point
    Private Property MoveForm_Position As Point


    '' Partie connexion à la base de données
    Dim connexionSql As OracleConnection




    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim test As New Conn
        Try
            Dim connexion As OracleConnection = test.GetConnection()
            connexion.Open()
            MessageBox.Show("Connexion réussie !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)
            connexion.Close()
        Catch ex As Exception
            MessageBox.Show("Erreur de connexion : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try













        Txt_Username.Text = "Login"
        Txt_Username.ForeColor = Color.DarkGray
        Txt_Password.Text = "Mot de passe"
        Txt_Password.ForeColor = Color.DarkGray
        Txt_Password.PasswordChar = ""

    End Sub






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
End Class