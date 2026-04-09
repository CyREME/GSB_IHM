Imports System.Drawing.Text

Public Class Visiteur
    Private Property MoveForm As Boolean
    Private Property MoveForm_MousePosition As Point
    Private Property MoveForm_Position As Point

    Private colorBtnSelect As Color = Color.FromArgb(83, 175, 255)

    Dim PageCR As New CompteRendu()

    Dim HistVisit As New HistoriqueVisites()

    Dim VisionSynth As New VisionSynth()

    Dim btn_logout As New btn_logout()
    Dim btn_deco As New btn_exit()


    '' Ici c'est pour pouvoir déplacer la fenêtre en cliquant sur le panel du haut ou le label Login
    Private Sub PanelHeader_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelHeader.MouseDown, lbl_nom.MouseDown
        MoveForm = True
        MoveForm_MousePosition = Cursor.Position
        MoveForm_Position = Location
    End Sub

    Private Sub PanelHeader_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelHeader.MouseMove, lbl_nom.MouseUp, lbl_nom.MouseMove
        If MoveForm Then
            Dim dif = New Point(Cursor.Position.X - MoveForm_MousePosition.X, Cursor.Position.Y - MoveForm_MousePosition.Y)
            Location = New Point(MoveForm_Position.X + dif.X, MoveForm_Position.Y + dif.Y)
        End If
    End Sub

    Private Sub PanelHeader_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelHeader.MouseUp, lbl_nom.MouseUp
        MoveForm = False
    End Sub



    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Affichage du Nom et Prénom dans le label
        lbl_nom.Text = Login.PrenomUtilisateur & " " & Login.NomUtilisateur

        'Bouton Compte Rendu Chargée
        btn_Compte_Rendu.BackColor = colorBtnSelect
        btn_Compte_Rendu.ForeColor = Color.FromArgb(255, 255, 255)

        btn_Historique_Visites.BackColor = Color.FromArgb(255, 255, 255)
        btn_Historique_Visites.ForeColor = Color.FromArgb(0, 0, 0)

        btn_Vision_Synthese.BackColor = Color.FromArgb(255, 255, 255)
        btn_Vision_Synthese.ForeColor = Color.FromArgb(0, 0, 0)

        btn_logout_Panel.Controls.Clear()
        btn_logout_Panel.Controls.Add(btn_logout)

        btn_exit_Panel.Controls.Clear()
        btn_exit_Panel.Controls.Add(btn_deco)

        'Affichage dans le panneau du Compte Rendu
        PanelAffichage.Controls.Clear()

        PageCR.Dock = DockStyle.Fill

        PanelAffichage.Controls.Add(PageCR)

    End Sub

    'Gestion des boutons de navigations
    Private Sub btn_Compte_Rendu_Click(sender As Object, e As EventArgs) Handles btn_Compte_Rendu.Click
        'Changement des couleurs des boutons
        btn_Compte_Rendu.BackColor = colorBtnSelect
        btn_Compte_Rendu.ForeColor = Color.FromArgb(255, 255, 255)

        btn_Historique_Visites.BackColor = Color.FromArgb(255, 255, 255)
        btn_Historique_Visites.ForeColor = Color.FromArgb(0, 0, 0)

        btn_Vision_Synthese.BackColor = Color.FromArgb(255, 255, 255)
        btn_Vision_Synthese.ForeColor = Color.FromArgb(0, 0, 0)



        'Changement de l'affichage de la page dans le panneau
        PanelAffichage.Controls.Clear()

        PageCR.Dock = DockStyle.Fill

        PanelAffichage.Controls.Add(PageCR)



    End Sub

    Private Sub btn_Historique_Visites_Click(sender As Object, e As EventArgs) Handles btn_Historique_Visites.Click
        'Changement des couleurs des boutons
        btn_Historique_Visites.BackColor = colorBtnSelect
        btn_Historique_Visites.ForeColor = Color.FromArgb(255, 255, 255)

        btn_Compte_Rendu.BackColor = Color.FromArgb(255, 255, 255)
        btn_Compte_Rendu.ForeColor = Color.FromArgb(0, 0, 0)

        btn_Vision_Synthese.BackColor = Color.FromArgb(255, 255, 255)
        btn_Vision_Synthese.ForeColor = Color.FromArgb(0, 0, 0)



        'Changement de l'affichage de la page dans le panneau
        PanelAffichage.Controls.Clear()

        HistVisit.Dock = DockStyle.Fill

        PanelAffichage.Controls.Add(HistVisit)


    End Sub

    Private Sub btn_Vision_Synthese_Click(sender As Object, e As EventArgs) Handles btn_Vision_Synthese.Click
        'Changement des couleurs des boutons
        btn_Vision_Synthese.BackColor = colorBtnSelect
        btn_Vision_Synthese.ForeColor = Color.FromArgb(255, 255, 255)

        btn_Compte_Rendu.BackColor = Color.FromArgb(255, 255, 255)
        btn_Compte_Rendu.ForeColor = Color.FromArgb(0, 0, 0)

        btn_Historique_Visites.BackColor = Color.FromArgb(255, 255, 255)
        btn_Historique_Visites.ForeColor = Color.FromArgb(0, 0, 0)



        'Changement de l'affichage de la page dans le panneau
        PanelAffichage.Controls.Clear()

        VisionSynth.Dock = DockStyle.Fill

        PanelAffichage.Controls.Add(VisionSynth)

    End Sub
End Class