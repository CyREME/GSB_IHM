Imports System.Windows.Forms

Public Class Delegue

    Private Property MoveForm As Boolean
    Private Property MoveForm_MousePosition As Point
    Private Property MoveForm_Position As Point

    ' Couleurs du thème moderne
    Private colorMenuFond As Color = Color.FromArgb(45, 52, 70)
    Private colorMenuActif As Color = Color.FromArgb(245, 247, 250)
    Private colorTexteActif As Color = Color.FromArgb(45, 52, 70)
    Private colorTexteInactif As Color = Color.White

    ' Pages
    Dim VueRegion As New VueRegion()
    Dim VueEquipe As New VueEquipeVisiteurs()
    Dim PageCR As New CompteRendu()
    Dim HistVisit As New HistoriqueVisitesDelegue()
    ' (Il manque peut-être la page de l'équipe des visiteurs ici selon votre architecture)

    Dim WithEvents btn_logout As New btn_logout()
    Dim WithEvents btn_deco As New btn_exit()


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
    Private Sub Delegue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_nom.Text = "Délégué : " & Login.PrenomUtilisateur & " " & Login.NomUtilisateur

        btn_logout_Panel.Controls.Clear()
        btn_logout_Panel.Controls.Add(btn_logout)

        btn_exit_Panel.Controls.Clear()
        btn_exit_Panel.Controls.Add(btn_deco)

        ' Charger la vue région par défaut
        btn_Regions.PerformClick()
    End Sub

    ' =========================================================
    ' METHODES OPTIMISEES POUR LE MENU
    ' =========================================================
    Private Sub ActiverBouton(btnActif As Button)
        btn_Regions.BackColor = colorMenuFond
        btn_Regions.ForeColor = colorTexteInactif

        btn_Visiteurs.BackColor = colorMenuFond
        btn_Visiteurs.ForeColor = colorTexteInactif

        btn_Compte_Rendue.BackColor = colorMenuFond
        btn_Compte_Rendue.ForeColor = colorTexteInactif

        btn_Historique_Visites.BackColor = colorMenuFond
        btn_Historique_Visites.ForeColor = colorTexteInactif

        btnActif.BackColor = colorMenuActif
        btnActif.ForeColor = colorTexteActif
    End Sub

    Private Sub ChangerPage(page As UserControl)
        PanelAffichage.Controls.Clear()
        page.Dock = DockStyle.Fill
        PanelAffichage.Controls.Add(page)
    End Sub

    ' =========================================================
    ' CLICS SUR LE MENU
    ' =========================================================
    Private Sub btn_Regions_Click(sender As Object, e As EventArgs) Handles btn_Regions.Click
        ActiverBouton(btn_Regions)
        ChangerPage(VueRegion)
    End Sub

    Private Sub btn_Visiteurs_Click(sender As Object, e As EventArgs) Handles btn_Visiteurs.Click
        ActiverBouton(btn_Visiteurs)

        ' ON APPELLE ENFIN LA BONNE VUE POUR L'ÉQUIPE !
        ChangerPage(VueEquipe)
    End Sub

    Private Sub btn_Compte_Rendue_Click(sender As Object, e As EventArgs) Handles btn_Compte_Rendue.Click
        ActiverBouton(btn_Compte_Rendue)
        ChangerPage(PageCR)
    End Sub

    Private Sub btn_Historique_Visites_Click(sender As Object, e As EventArgs) Handles btn_Historique_Visites.Click
        ActiverBouton(btn_Historique_Visites)
        ChangerPage(HistVisit)
    End Sub

<<<<<<< HEAD
=======





    Private Sub btn_exit_Click(sender As Object, e As EventArgs)
        Close
    End Sub

    Private Sub PanelAffichage_Paint(sender As Object, e As PaintEventArgs) Handles PanelAffichage.Paint

    End Sub
>>>>>>> e8681ec723fb5e285a95e6b69690cbbaf2d4e883
End Class