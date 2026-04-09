Imports System.Windows.Forms
Imports System.Drawing

Public Class btn_logout

    ' 1. Action de déconnexion (inchangée)
    Private Sub btn_logout_Click(sender As Object, e As EventArgs) Handles btn_Deconnexion.Click
        ' On réinitialise l'affichage de la page Login
        Login.Txt_Username.Text = "Login"
        Login.Txt_Username.ForeColor = Color.DarkGray
        Login.Txt_Password.Text = "Mot de passe"
        Login.Txt_Password.ForeColor = Color.DarkGray
        Login.Txt_Password.PasswordChar = ""

        ' On réaffiche la page de connexion
        Login.Show()

        ' On trouve la fenêtre qui contient ce bouton et on la ferme
        Dim fenetreParente As Form = Me.FindForm()
        If fenetreParente IsNot Nothing Then
            fenetreParente.Close()
        End If
    End Sub

    ' 2. Animation au survol de la souris (UX Moderne)
    Private Sub btn_Deconnexion_MouseEnter(sender As Object, e As EventArgs) Handles btn_Deconnexion.MouseEnter
        ' Au survol, on met le texte en rouge clair pour indiquer la déconnexion
        btn_Deconnexion.ForeColor = Color.FromArgb(220, 53, 69)
        ' Fond très légèrement grisé pour montrer qu'on le survole
        btn_Deconnexion.BackColor = Color.FromArgb(245, 245, 245)
    End Sub

    Private Sub btn_Deconnexion_MouseLeave(sender As Object, e As EventArgs) Handles btn_Deconnexion.MouseLeave
        ' Quand la souris part, on remet le style par défaut (Blanc et Gris foncé)
        btn_Deconnexion.ForeColor = Color.FromArgb(100, 100, 100)
        btn_Deconnexion.BackColor = Color.White
    End Sub

End Class