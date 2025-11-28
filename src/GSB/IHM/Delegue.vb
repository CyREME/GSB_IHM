Imports Mysqlx.XDevAPI.Relational

Public Class Delegue

    Private Property MoveForm As Boolean
    Private Property MoveForm_MousePosition As Point
    Private Property MoveForm_Position As Point
    Private colorBtnSelect As Color = Color.FromArgb(83, 175, 255)

    Dim VueTab As New VueTableauRegionSecteur()
    Dim PageCR As New CompteRendu()
    Dim HistVisit As New HistoriqueVisites()


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




    Private Sub Delegue_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        btn_Regions.BackColor = colorBtnSelect
        btn_Regions.ForeColor = Color.FromArgb(255, 255, 255)

        btn_Visiteurs.BackColor = Color.FromArgb(255, 255, 255)
        btn_Visiteurs.ForeColor = Color.FromArgb(0, 0, 0)

        btn_Compte_Rendue.BackColor = Color.FromArgb(255, 255, 255)
        btn_Compte_Rendue.ForeColor = Color.FromArgb(0, 0, 0)

        btn_Historique_Visites.BackColor = Color.FromArgb(255, 255, 255)
        btn_Historique_Visites.ForeColor = Color.FromArgb(0, 0, 0)

        'Changement de l'affichage de la page dans le panneau
        PanelAffichage.Controls.Clear()

        VueTab.Dock = DockStyle.Fill

        VueTab.lbl_Delegue.Visible = False
        VueTab.Liste_Delegues.Visible = False

        VueTab.lbl_Visiteur.Visible = False
        VueTab.Liste_Visiteurs.Visible = False

        VueTab.lbl_Visiteur.Location() = New Point(25, 31)
        VueTab.Liste_Visiteurs.Location() = New Point(25, 58)


        PanelAffichage.Controls.Add(VueTab)

    End Sub



    Private Sub btn_Regions_Click(sender As Object, e As EventArgs) Handles btn_Regions.Click
        btn_Regions.BackColor = colorBtnSelect
        btn_Regions.ForeColor = Color.FromArgb(255, 255, 255)

        btn_Visiteurs.BackColor = Color.FromArgb(255, 255, 255)
        btn_Visiteurs.ForeColor = Color.FromArgb(0, 0, 0)

        btn_Compte_Rendue.BackColor = Color.FromArgb(255, 255, 255)
        btn_Compte_Rendue.ForeColor = Color.FromArgb(0, 0, 0)

        btn_Historique_Visites.BackColor = Color.FromArgb(255, 255, 255)
        btn_Historique_Visites.ForeColor = Color.FromArgb(0, 0, 0)



        'Changement de l'affichage de la page dans le panneau
        PanelAffichage.Controls.Clear()

        VueTab.Dock = DockStyle.Fill

        VueTab.lbl_Delegue.Visible = False
        VueTab.Liste_Delegues.Visible = False

        VueTab.lbl_Visiteur.Visible = False
        VueTab.Liste_Visiteurs.Visible = False


        PanelAffichage.Controls.Add(VueTab)

    End Sub

    Private Sub btn_Visiteur_Click(sender As Object, e As EventArgs) Handles btn_Visiteurs.Click

        btn_Visiteurs.BackColor = colorBtnSelect
        btn_Visiteurs.ForeColor = Color.FromArgb(255, 255, 255)

        btn_Regions.BackColor = Color.FromArgb(255, 255, 255)
        btn_Regions.ForeColor = Color.FromArgb(0, 0, 0)

        btn_Compte_Rendue.BackColor = Color.FromArgb(255, 255, 255)
        btn_Compte_Rendue.ForeColor = Color.FromArgb(0, 0, 0)

        btn_Historique_Visites.BackColor = Color.FromArgb(255, 255, 255)
        btn_Historique_Visites.ForeColor = Color.FromArgb(0, 0, 0)



        'Changement de l'affichage de la page dans le panneau
        PanelAffichage.Controls.Clear()

        VueTab.Dock = DockStyle.Fill

        VueTab.lbl_Visiteur.Visible = True
        VueTab.Liste_Visiteurs.Visible = True


        PanelAffichage.Controls.Add(VueTab)

    End Sub



    Private Sub btn_Compte_Rendue_Click(sender As Object, e As EventArgs) Handles btn_Compte_Rendue.Click

        btn_Compte_Rendue.BackColor = colorBtnSelect
        btn_Compte_Rendue.ForeColor = Color.FromArgb(255, 255, 255)

        btn_Regions.BackColor = Color.FromArgb(255, 255, 255)
        btn_Regions.ForeColor = Color.FromArgb(0, 0, 0)

        btn_Visiteurs.BackColor = Color.FromArgb(255, 255, 255)
        btn_Visiteurs.ForeColor = Color.FromArgb(0, 0, 0)

        btn_Historique_Visites.BackColor = Color.FromArgb(255, 255, 255)
        btn_Historique_Visites.ForeColor = Color.FromArgb(0, 0, 0)

        'Changement de l'affichage de la page dans le panneau
        PanelAffichage.Controls.Clear()

        PageCR.Dock = DockStyle.Fill

        PanelAffichage.Controls.Add(PageCR)

    End Sub



    Private Sub btn_Historique_Visites_Click(sender As Object, e As EventArgs) Handles btn_Historique_Visites.Click

        btn_Historique_Visites.BackColor = colorBtnSelect
        btn_Historique_Visites.ForeColor = Color.FromArgb(255, 255, 255)

        btn_Regions.BackColor = Color.FromArgb(255, 255, 255)
        btn_Regions.ForeColor = Color.FromArgb(0, 0, 0)

        btn_Visiteurs.BackColor = Color.FromArgb(255, 255, 255)
        btn_Visiteurs.ForeColor = Color.FromArgb(0, 0, 0)

        btn_Compte_Rendue.BackColor = Color.FromArgb(255, 255, 255)
        btn_Compte_Rendue.ForeColor = Color.FromArgb(0, 0, 0)

        'Changement de l'affichage de la page dans le panneau
        PanelAffichage.Controls.Clear()

        HistVisit.Dock = DockStyle.Fill

        PanelAffichage.Controls.Add(HistVisit)

    End Sub






    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub
End Class