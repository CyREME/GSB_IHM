Imports System.Drawing.Text

Public Class Visiteur
    Private Property MoveForm As Boolean
    Private Property MoveForm_MousePosition As Point
    Private Property MoveForm_Position As Point

    ' Couleurs du thème moderne
    Private colorMenuFond As Color = Color.FromArgb(45, 52, 70) ' Bleu nuit
    Private colorMenuActif As Color = Color.FromArgb(245, 247, 250) ' Gris très clair (comme le fond)
    Private colorTexteActif As Color = Color.FromArgb(45, 52, 70)
    Private colorTexteInactif As Color = Color.White

    ' Pages
    Dim PageCR As New CompteRendu()
    Dim HistVisit As New HistoriqueVisites()
    Dim VisionSynth As New VisionSynth()

    ' Boutons système
    Dim btn_logout As New btn_logout()
    Dim btn_deco As New btn_exit()


    '' Déplacement de la fenêtre
    Private Sub PanelHeader_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelHeader.MouseDown, lbl_nom.MouseDown
        MoveForm = True
        MoveForm_MousePosition = Cursor.Position
        MoveForm_Position = Location
    End Sub

    Private Sub PanelHeader_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelHeader.MouseMove, lbl_nom.MouseMove
        If MoveForm Then
            Dim dif = New Point(Cursor.Position.X - MoveForm_MousePosition.X, Cursor.Position.Y - MoveForm_MousePosition.Y)
            Location = New Point(MoveForm_Position.X + dif.X, MoveForm_Position.Y + dif.Y)
        End If
    End Sub

    Private Sub PanelHeader_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelHeader.MouseUp, lbl_nom.MouseUp
        MoveForm = False
    End Sub


    Private Sub Visiteur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Affichage du Nom et Prénom dans le label
        lbl_nom.Text = "Bonjour, " & Login.PrenomUtilisateur & " " & Login.NomUtilisateur

        ' Ajout des boutons système
        btn_logout_Panel.Controls.Clear()
        btn_logout_Panel.Controls.Add(btn_logout)

        btn_exit_Panel.Controls.Clear()
        btn_exit_Panel.Controls.Add(btn_deco)

        ' Charger la première page par défaut
        ActiverBouton(btn_Compte_Rendu)
        ChangerPage(PageCR)
    End Sub

    ' ---------------------------------------------------------
    ' METHODES OPTIMISEES POUR LE MENU
    ' ---------------------------------------------------------

    ' Cette méthode gère le design visuel des boutons en 1 clic
    Private Sub ActiverBouton(btnActif As Button)
        ' 1. On remet tous les boutons à l'état inactif (Fond bleu nuit, Texte blanc)
        btn_Compte_Rendu.BackColor = colorMenuFond
        btn_Compte_Rendu.ForeColor = colorTexteInactif

        btn_Historique_Visites.BackColor = colorMenuFond
        btn_Historique_Visites.ForeColor = colorTexteInactif

        btn_Vision_Synthese.BackColor = colorMenuFond
        btn_Vision_Synthese.ForeColor = colorTexteInactif

        ' 2. On illumine le bouton sélectionné (Fond clair, Texte bleu nuit)
        btnActif.BackColor = colorMenuActif
        btnActif.ForeColor = colorTexteActif
    End Sub

    ' Cette méthode gère l'affichage des UserControls
    Private Sub ChangerPage(page As UserControl)
        PanelAffichage.Controls.Clear()
        page.Dock = DockStyle.Fill
        PanelAffichage.Controls.Add(page)
    End Sub


    ' ---------------------------------------------------------
    ' CLICS SUR LE MENU
    ' ---------------------------------------------------------

    Private Sub btn_Compte_Rendu_Click(sender As Object, e As EventArgs) Handles btn_Compte_Rendu.Click
        ActiverBouton(btn_Compte_Rendu)
        ChangerPage(PageCR)
    End Sub

    Private Sub btn_Historique_Visites_Click(sender As Object, e As EventArgs) Handles btn_Historique_Visites.Click
        ActiverBouton(btn_Historique_Visites)
        ChangerPage(HistVisit)
    End Sub

    Private Sub btn_Vision_Synthese_Click(sender As Object, e As EventArgs) Handles btn_Vision_Synthese.Click
        ActiverBouton(btn_Vision_Synthese)
        ChangerPage(VisionSynth)
    End Sub

End Class