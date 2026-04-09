Imports System.Windows.Forms

Public Class Responsable

    Private Property MoveForm As Boolean
    Private Property MoveForm_MousePosition As Point
    Private Property MoveForm_Position As Point

    ' Couleurs du thème moderne
    Private colorMenuFond As Color = Color.FromArgb(45, 52, 70) ' Bleu nuit
    Private colorMenuActif As Color = Color.FromArgb(245, 247, 250) ' Gris clair du fond
    Private colorTexteActif As Color = Color.FromArgb(45, 52, 70)
    Private colorTexteInactif As Color = Color.White

    Dim WithEvents VueTab As New VueSecteurRegionResp()
    Dim WithEvents btn_logout As New btn_logout()
    Dim WithEvents btn_exit As New btn_exit()

    ' =========================================================
    ' DEPLACEMENT FENETRE
    ' =========================================================
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

    ' =========================================================
    ' INITIALISATION
    ' =========================================================
    Private Sub Responsable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_nom.Text = "Responsable : " & Login.PrenomUtilisateur & " " & Login.NomUtilisateur

        btn_logout_Panel.Controls.Clear()
        btn_logout_Panel.Controls.Add(btn_logout)

        btn_exit_Panel.Controls.Clear()
        btn_exit_Panel.Controls.Add(btn_exit)

        PanelAffichage.Controls.Clear()
        VueTab.Dock = DockStyle.Fill
        PanelAffichage.Controls.Add(VueTab)

        ' On lance le clic sur Secteur au démarrage
        btn_Secteur.PerformClick()
    End Sub

    ' =========================================================
    ' METHODE OPTIMISEE POUR LE THEME
    ' =========================================================
    Private Sub ActiverBouton(btnActif As Button)
        btn_Secteur.BackColor = colorMenuFond
        btn_Secteur.ForeColor = colorTexteInactif

        btn_Regions.BackColor = colorMenuFond
        btn_Regions.ForeColor = colorTexteInactif

        btn_Visiteurs.BackColor = colorMenuFond
        btn_Visiteurs.ForeColor = colorTexteInactif

        btnActif.BackColor = colorMenuActif
        btnActif.ForeColor = colorTexteActif
    End Sub

    ' =========================================================
    ' CLICS SUR LE MENU
    ' =========================================================
    Private Sub btn_Secteur_Click(sender As Object, e As EventArgs) Handles btn_Secteur.Click
        ActiverBouton(btn_Secteur)

        VueTab.lbl_Delegue.Visible = False
        VueTab.Liste_Delegues.Visible = False
        VueTab.lbl_Visiteur.Visible = False
        VueTab.Liste_Visiteurs.Visible = False

        VueTab.ModeActuel = "Secteur"
        VueTab.ActualiserTableau()
    End Sub

    Private Sub btn_Regions_Click(sender As Object, e As EventArgs) Handles btn_Regions.Click
        ActiverBouton(btn_Regions)

        VueTab.lbl_Delegue.Visible = True
        VueTab.Liste_Delegues.Visible = True
        VueTab.lbl_Visiteur.Visible = False
        VueTab.Liste_Visiteurs.Visible = False

        VueTab.ModeActuel = "Regions"
        VueTab.ChargerListeDelegues()
    End Sub

    Private Sub btn_Visiteurs_Click(sender As Object, e As EventArgs) Handles btn_Visiteurs.Click
        ActiverBouton(btn_Visiteurs)

        VueTab.ModeActuel = "Visiteurs"
        VueTab.lbl_Delegue.Visible = True
        VueTab.Liste_Delegues.Visible = True
        VueTab.lbl_Visiteur.Visible = True
        VueTab.Liste_Visiteurs.Visible = True

        VueTab.ChargerListeDelegues()

        If VueTab.Liste_Delegues.Items.Count = 0 Then
            VueTab.lbl_Visiteur.Visible = False
            VueTab.Liste_Visiteurs.Visible = False
            MessageBox.Show("Vous n'avez aucun délégué dans votre secteur.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    ' =========================================================
    ' ÉVÉNEMENTS PERSONNALISÉS (INTERACTIVITÉ ENTRE ONGLETS)
    ' =========================================================
    Private Sub VueTab_DemandeObservationDelegue(idDelegue As Integer) Handles VueTab.DemandeObservationDelegue
        btn_Regions.PerformClick()
        VueTab.Liste_Delegues.SelectedValue = idDelegue
    End Sub

    Private Sub VueTab_DemandeObservationVisiteur(idVisiteur As Integer) Handles VueTab.DemandeObservationVisiteur
        ' 1. On mémorise le délégué actuellement sélectionné avant que la vue ne change !
        Dim idDelegueActuel As Integer = Convert.ToInt32(VueTab.Liste_Delegues.SelectedValue)

        ' 2. On change de page (cela simule le clic sur "Vue Visiteurs")
        btn_Visiteurs.PerformClick()

        ' 3. On FORCE la re-sélection du délégué mémorisé
        VueTab.Liste_Delegues.SelectedValue = idDelegueActuel

        ' 4. On charge la liste des visiteurs pour CE délégué
        VueTab.ChargerListeVisiteurs(idDelegueActuel)

        ' 5. On sélectionne enfin le visiteur ciblé par le bouton Observer
        VueTab.Liste_Visiteurs.SelectedValue = idVisiteur
    End Sub

End Class