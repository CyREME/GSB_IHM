Public Class btn_logout
    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_Deconnexion.Click
        ' 1. On réinitialise l'affichage de la page Login
        Login.Txt_Username.Text = "Login"
        Login.Txt_Username.ForeColor = Color.DarkGray
        Login.Txt_Password.Text = "Mot de passe"
        Login.Txt_Password.ForeColor = Color.DarkGray
        Login.Txt_Password.PasswordChar = ""

        ' 2. On réaffiche la page de connexion
        Login.Show()

        ' 3. On trouve la fenêtre qui contient ce bouton et on la ferme
        Dim fenetreParente As Form = Me.FindForm()
        If fenetreParente IsNot Nothing Then
            fenetreParente.Close()
        End If

    End Sub
End Class