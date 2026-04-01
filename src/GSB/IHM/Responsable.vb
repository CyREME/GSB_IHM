Public Class Responsable

    Private Property MoveForm As Boolean
    Private Property MoveForm_MousePosition As Point
    Private Property MoveForm_Position As Point
    Private colorBtnSelect As Color = Color.FromArgb(83, 175, 255)

    Dim WithEvents VueTab As New VueTableauRegionSecteur()


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









    Private Sub Responsable_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Affichage du Nom et Prénom dans le label
        lbl_nom.Text = Login.PrenomUtilisateur & " " & Login.NomUtilisateur

        btn_Secteur.BackColor = colorBtnSelect
        btn_Secteur.ForeColor = Color.FromArgb(255, 255, 255)

        btn_Regions.BackColor = Color.FromArgb(255, 255, 255)
        btn_Regions.ForeColor = Color.FromArgb(0, 0, 0)

        btn_Visiteurs.BackColor = Color.FromArgb(255, 255, 255)
        btn_Visiteurs.ForeColor = Color.FromArgb(0, 0, 0)

        'Affichage dans le panneau du Compte Rendu
        PanelAffichage.Controls.Clear()

        VueTab.lbl_Delegue.Visible = False
        VueTab.Liste_Delegues.Visible = False

        VueTab.lbl_Visiteur.Visible = False
        VueTab.Liste_Visiteurs.Visible = False

        VueTab.Dock = DockStyle.Fill

        PanelAffichage.Controls.Add(VueTab)

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

        ' 1. On indique le mode AVANT TOUT
        VueTab.ModeActuel = "Visiteurs"

        ' 2. TRÈS IMPORTANT : On rend les listes visibles AVANT de charger les données
        ' Sinon ActualiserTableau() va croire qu'elles sont cachées et ne rien afficher !
        VueTab.lbl_Delegue.Visible = True
        VueTab.Liste_Delegues.Visible = True
        VueTab.lbl_Visiteur.Visible = True
        VueTab.Liste_Visiteurs.Visible = True

        ' 3. On charge les délégués (Le module va automatiquement charger les visiteurs en cascade)
        VueTab.ChargerListeDelegues()

        ' 4. On vérifie s'il y a des délégués. S'il n'y en a pas, on recache la liste des visiteurs.
        If VueTab.Liste_Delegues.Items.Count = 0 Then
            VueTab.lbl_Visiteur.Visible = False
            VueTab.Liste_Visiteurs.Visible = False
            MessageBox.Show("Vous n'avez aucun délégué dans votre secteur.")
        End If

    End Sub


    ' ---------------------------------------------------------
    ' ÉVÉNEMENT : REDIRECTION DEPUIS LE BOUTON "OBSERVER"
    ' ---------------------------------------------------------
    Private Sub VueTab_DemandeObservationVisiteur(idVisiteur As Integer) Handles VueTab.DemandeObservationVisiteur

        ' 1. On change l'apparence des boutons du menu gauche (comme si on avait cliqué sur Visiteurs)
        btn_Secteur.BackColor = Color.FromArgb(255, 255, 255)
        btn_Secteur.ForeColor = Color.FromArgb(0, 0, 0)

        btn_Regions.BackColor = Color.FromArgb(255, 255, 255)
        btn_Regions.ForeColor = Color.FromArgb(0, 0, 0)

        btn_Visiteurs.BackColor = colorBtnSelect
        btn_Visiteurs.ForeColor = Color.FromArgb(255, 255, 255)

        ' 2. On change le mode d'affichage du composant
        VueTab.ModeActuel = "Visiteurs"

        ' 3. On affiche la combobox des visiteurs (Celle des délégués est déjà affichée)
        VueTab.lbl_Visiteur.Visible = True
        VueTab.Liste_Visiteurs.Visible = True

        ' 4. On sélectionne le bon visiteur dans la liste
        VueTab.Liste_Visiteurs.SelectedValue = idVisiteur

        ' 5. LA CORRECTION EST ICI : On force le tableau à se rafraîchir immédiatement !
        ' Cela garantit que les données s'affichent tout de suite, même si le visiteur 
        ' était déjà sélectionné par défaut en arrière-plan.
        VueTab.ActualiserTableau()

    End Sub



    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_Deconnexion_Click(sender As Object, e As EventArgs) Handles btn_Deconnexion.Click

    End Sub

End Class