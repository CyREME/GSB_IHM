Imports System.Windows.Forms
Imports System.Drawing

Public Class btn_exit

    ' 1. Action de fermeture (inchangée, elle était parfaite)
    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fenetreParente As Form = Me.FindForm()
        If fenetreParente IsNot Nothing Then
            fenetreParente.Close()
        End If
    End Sub

    ' 2. Animation au survol de la souris (UX Moderne)
    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        ' Quand on survole, le texte devient blanc (le Designer gère déjà le fond rouge)
        Button1.ForeColor = Color.White
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        ' Quand la souris part, on remet le texte en gris foncé
        Button1.ForeColor = Color.FromArgb(100, 100, 100)
    End Sub

End Class