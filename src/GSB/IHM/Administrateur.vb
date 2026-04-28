Imports System.Windows.Forms

Public Class Administrateur
    Private Property MoveForm As Boolean
    Private Property MoveForm_MousePosition As Point
    Private Property MoveForm_Position As Point

    ' Couleurs thématiques
    Private colorMenuFond As Color = Color.FromArgb(45, 52, 70)
    Private colorMenuActif As Color = Color.FromArgb(245, 247, 250)
    Private colorTexteActif As Color = Color.FromArgb(45, 52, 70)
    Private colorTexteInactif As Color = Color.White

    ' Instance unique du module
    Private ModuleJournal As journalSession

    Dim WithEvents btn_logout As New btn_logout()
    Dim WithEvents btn_exit As New btn_exit()

    Private Sub Administrateur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            ' Configuration de l'entête
            lbl_nom.Text = "ADMINISTRATION : " & Login.PrenomUtilisateur & " " & Login.NomUtilisateur

            ' Chargement des contrôles utilisateurs (boutons exit/logout)
            btn_logout_Panel.Controls.Add(btn_logout)
            btn_exit_Panel.Controls.Add(btn_exit)

            ' Création du module de log
            ModuleJournal = New journalSession()

            ' Lancement par défaut sur le journal des sessions
            btn_Journal_Sessions.PerformClick()

        Catch ex As Exception
            MessageBox.Show("Erreur lors de l'initialisation de l'interface : " & ex.Message)
        End Try
    End Sub

    Private Sub ActiverBouton(btnActif As Button)
        btn_Journal_Sessions.BackColor = colorMenuFond
        btn_Journal_Sessions.ForeColor = colorTexteInactif
        btn_Analyse_Activite.BackColor = colorMenuFond
        btn_Analyse_Activite.ForeColor = colorTexteInactif

        btnActif.BackColor = colorMenuActif
        btnActif.ForeColor = colorTexteActif
    End Sub

    Private Sub ChangerPage(page As UserControl)
        If page IsNot Nothing Then
            PanelAffichage.Controls.Clear()
            page.Dock = DockStyle.Fill
            PanelAffichage.Controls.Add(page)
        End If
    End Sub

    ' --- EVENEMENTS CLIC ---
    Private Sub btn_Journal_Sessions_Click(sender As Object, e As EventArgs) Handles btn_Journal_Sessions.Click
        ActiverBouton(btn_Journal_Sessions)
        ModuleJournal.ModeActuel = "DETAIL"
        ChangerPage(ModuleJournal)
        ModuleJournal.ActualiserDonnees()
    End Sub

    Private Sub btn_Analyse_Activite_Click(sender As Object, e As EventArgs) Handles btn_Analyse_Activite.Click
        ActiverBouton(btn_Analyse_Activite)
        ModuleJournal.ModeActuel = "CUMUL"
        ChangerPage(ModuleJournal)
        ModuleJournal.ActualiserDonnees()
    End Sub

    ' --- GESTION DEPLACEMENT ---
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
End Class