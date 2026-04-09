Public Class Responsable

    Private Property MoveForm As Boolean
    Private Property MoveForm_MousePosition As Point
    Private Property MoveForm_Position As Point
    Private colorBtnSelect As Color = Color.FromArgb(83, 175, 255)

    Dim WithEvents VueTab As New VueTableauRegionSecteur()
    Dim WithEvents btn_logout As New btn_logout()
    Dim WithEvents btn_exit As New btn_exit

    ' ... (Gardez vos méthodes PanelHeader_MouseDown, MouseMove, MouseUp intactes ici) ...

    Private Sub Responsable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_nom.Text = Login.PrenomUtilisateur & " " & Login.NomUtilisateur

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

    Private Sub btn_Secteur_Click(sender As Object, e As EventArgs) Handles btn_Secteur.Click
        btn_Secteur.BackColor = colorBtnSelect
        btn_Secteur.ForeColor = Color.FromArgb(255, 255, 255)
        btn_Regions.BackColor = Color.FromArgb(255, 255, 255)
        btn_Regions.ForeColor = Color.FromArgb(0, 0, 0)
        btn_Visiteurs.BackColor = Color.FromArgb(255, 255, 255)
        btn_Visiteurs.ForeColor = Color.FromArgb(0, 0, 0)

        VueTab.lbl_Delegue.Visible = False
        VueTab.Liste_Delegues.Visible = False
        VueTab.lbl_Visiteur.Visible = False
        VueTab.Liste_Visiteurs.Visible = False

        ' ---> MODIFIÉ : On active le mode Secteur et on charge le tableau <---
        VueTab.ModeActuel = "Secteur"
        VueTab.ActualiserTableau()
    End Sub

    Private Sub btn_Regions_Click(sender As Object, e As EventArgs) Handles btn_Regions.Click
        btn_Secteur.BackColor = Color.FromArgb(255, 255, 255)
        btn_Secteur.ForeColor = Color.FromArgb(0, 0, 0)
        btn_Regions.BackColor = colorBtnSelect
        btn_Regions.ForeColor = Color.FromArgb(255, 255, 255)
        btn_Visiteurs.BackColor = Color.FromArgb(255, 255, 255)
        btn_Visiteurs.ForeColor = Color.FromArgb(0, 0, 0)

        VueTab.lbl_Delegue.Visible = True
        VueTab.Liste_Delegues.Visible = True
        VueTab.lbl_Visiteur.Visible = False
        VueTab.Liste_Visiteurs.Visible = False

        VueTab.ModeActuel = "Regions"
        VueTab.ChargerListeDelegues()
    End Sub

    Private Sub btn_Visiteurs_Click(sender As Object, e As EventArgs) Handles btn_Visiteurs.Click
        btn_Secteur.BackColor = Color.FromArgb(255, 255, 255)
        btn_Secteur.ForeColor = Color.FromArgb(0, 0, 0)
        btn_Regions.BackColor = Color.FromArgb(255, 255, 255)
        btn_Regions.ForeColor = Color.FromArgb(0, 0, 0)
        btn_Visiteurs.BackColor = colorBtnSelect
        btn_Visiteurs.ForeColor = Color.FromArgb(255, 255, 255)

        VueTab.ModeActuel = "Visiteurs"
        VueTab.lbl_Delegue.Visible = True
        VueTab.Liste_Delegues.Visible = True
        VueTab.lbl_Visiteur.Visible = True
        VueTab.Liste_Visiteurs.Visible = True

        VueTab.ChargerListeDelegues()

        If VueTab.Liste_Delegues.Items.Count = 0 Then
            VueTab.lbl_Visiteur.Visible = False
            VueTab.Liste_Visiteurs.Visible = False
            MessageBox.Show("Vous n'avez aucun délégué dans votre secteur.")
        End If
    End Sub

    ' =========================================================
    ' NOUVEAU : Clic sur Observer dans l'onglet SECTEUR
    ' =========================================================
    Private Sub VueTab_DemandeObservationDelegue(idDelegue As Integer) Handles VueTab.DemandeObservationDelegue
        ' On simule un clic sur l'onglet Régions pour changer les couleurs
        btn_Regions.PerformClick()

        ' La méthode PerformClick a déjà chargé les délégués, 
        ' on a plus qu'à forcer la sélection du bon délégué !
        VueTab.Liste_Delegues.SelectedValue = idDelegue
    End Sub

    ' =========================================================
    ' CORRECTION : Clic sur Observer dans l'onglet RÉGIONS
    ' =========================================================
    Private Sub VueTab_DemandeObservationVisiteur(idVisiteur As Integer) Handles VueTab.DemandeObservationVisiteur
        ' On change les couleurs des boutons
        btn_Secteur.BackColor = Color.FromArgb(255, 255, 255)
        btn_Secteur.ForeColor = Color.FromArgb(0, 0, 0)
        btn_Regions.BackColor = Color.FromArgb(255, 255, 255)
        btn_Regions.ForeColor = Color.FromArgb(0, 0, 0)
        btn_Visiteurs.BackColor = colorBtnSelect
        btn_Visiteurs.ForeColor = Color.FromArgb(255, 255, 255)

        VueTab.ModeActuel = "Visiteurs"
        VueTab.lbl_Visiteur.Visible = True
        VueTab.Liste_Visiteurs.Visible = True

        ' ---> LA CORRECTION EST ICI : On force le remplissage de la liste des visiteurs AVANT <---
        VueTab.ChargerListeVisiteurs(Convert.ToInt32(VueTab.Liste_Delegues.SelectedValue))

        ' Ensuite on peut sélectionner le visiteur, et le tableau s'actualisera tout seul !
        VueTab.Liste_Visiteurs.SelectedValue = idVisiteur
    End Sub

    Private Sub btn_exit_Click(sender As Object, e As EventArgs)
        Close()
    End Sub

    Private Sub btn_Deconnexion_Click(sender As Object, e As EventArgs)
        ' Code de déconnexion...
    End Sub

End Class