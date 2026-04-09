Imports System.Windows.Forms
Imports System.Data

Public Class HistoriqueVisitesDelegue

    ' On stocke la liste prête à l'emploi de l'équipe (ex: "IN (2, 3, 10)")
    Private conditionEquipe As String = ""

    Private Sub HistoriqueVisitesDelegue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. On récupère les ID de l'équipe au démarrage
        Dim sqlEquipe As String = $"SELECT ID_USER FROM UTILISATEUR WHERE ID_USER = {Login.IdUtilisateur} OR ID_DELEGUE = {Login.IdUtilisateur}"
        Dim dtEquipe As DataTable = Conn.getData(sqlEquipe)

        If dtEquipe IsNot Nothing AndAlso dtEquipe.Rows.Count > 0 Then
            Dim ids As New List(Of String)
            For Each row As DataRow In dtEquipe.Rows
                ids.Add(row("ID_USER").ToString())
            Next
            conditionEquipe = "IN (" & String.Join(", ", ids) & ")"
        Else
            conditionEquipe = $"= {Login.IdUtilisateur}"
        End If

        ' 2. Configuration des Tableaux et du Style GSB
        SetupTableaux()
        AppliquerStyleTableaux(Tableau_Synthese_Praticiens)
        AppliquerStyleTableaux(Tableau_Activite)

        ' 3. Remplissage des données
        RemplirListeAnnees()
    End Sub

    ' --- STYLE DES TABLEAUX ---
    Private Sub AppliquerStyleTableaux(grid As DataGridView)
        grid.BackgroundColor = Color.White
        grid.BorderStyle = BorderStyle.None
        grid.RowHeadersVisible = False ' Supprime la petite colonne vide à gauche
        grid.EnableHeadersVisualStyles = False
        grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None

        ' En-tête Bleu
        grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(83, 175, 255)
        grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        grid.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)

        ' Lignes épurées
        grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 245, 250)
        grid.DefaultCellStyle.SelectionForeColor = Color.Black
        grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        grid.GridColor = Color.FromArgb(230, 230, 230)
    End Sub

    Private Sub SetupTableaux()
        ' Tableau de gauche (Liste des visites)
        With Tableau_Synthese_Praticiens
            .AllowUserToAddRows = False
            .RowHeadersVisible = False
            .ReadOnly = True
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            .MultiSelect = False ' On empêche la sélection multiple pour l'interactivité
        End With

        ' Tableau de droite (Détails de la visite)
        With Tableau_Activite
            .AllowUserToAddRows = False
            .RowHeadersVisible = False
            .ReadOnly = True
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End With
    End Sub

    Private Sub RemplirListeAnnees()
        Dim sql As String = $"SELECT DISTINCT TO_CHAR(DATE_VISITE, 'YYYY') as ANNEE FROM COMPTE_RENDU WHERE ID_USER {conditionEquipe} ORDER BY ANNEE DESC"
        Dim dt As DataTable = Conn.getData(sql)

        RemoveHandler Liste_Annee.SelectedIndexChanged, AddressOf Liste_Annee_SelectedIndexChanged
        Liste_Annee.Items.Clear()
        Liste_Annee.Items.Add("Toutes")

        If dt IsNot Nothing Then
            For Each row As DataRow In dt.Rows
                Liste_Annee.Items.Add(row("ANNEE").ToString())
            Next
        End If

        Liste_Annee.SelectedIndex = 0
        AddHandler Liste_Annee.SelectedIndexChanged, AddressOf Liste_Annee_SelectedIndexChanged

        ActualiserSynthese()
    End Sub

    Private Sub Liste_Annee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Liste_Annee.SelectedIndexChanged
        ActualiserSynthese()
    End Sub

    Private Sub ActualiserSynthese()
        If Liste_Annee.SelectedItem Is Nothing Then Return

        Dim anneeFiltre As String = Liste_Annee.SelectedItem.ToString()
        Dim conditionAnnee As String = If(anneeFiltre = "Toutes", "", $" AND TO_CHAR(CR.DATE_VISITE, 'YYYY') = '{anneeFiltre}'")
        Dim conditionAnneeSimple As String = If(anneeFiltre = "Toutes", "", $" AND TO_CHAR(DATE_VISITE, 'YYYY') = '{anneeFiltre}'")

        Try
            ' 1. Mise à jour des Labels
            Dim resVisites = Conn.getData($"SELECT COUNT(*) FROM COMPTE_RENDU WHERE ID_USER {conditionEquipe} {conditionAnneeSimple}")
            If resVisites IsNot Nothing AndAlso resVisites.Rows.Count > 0 Then
                lbl_visites.Text = "Nombre total de visites de l'équipe : " & resVisites.Rows(0)(0).ToString()
            End If

            Dim sqlEch As String = "SELECT NVL(SUM(E.QUANTITE), 0) FROM ECHANTILLON E JOIN COMPTE_RENDU CR ON E.ID_COMPTE_RENDU = CR.ID_COMPTE_RENDU " &
                                  $"WHERE CR.ID_USER {conditionEquipe} {conditionAnnee}"
            Dim resEch = Conn.getData(sqlEch)
            If resEch IsNot Nothing AndAlso resEch.Rows.Count > 0 Then
                lbl_echantillon.Text = "Nombre total d'échantillons distribués : " & resEch.Rows(0)(0).ToString()
            End If

            ' 2. Tableau de Gauche : LISTE DES VISITES CHRONOLOGIQUES
            Dim sqlVisites As String = "SELECT CR.ID_COMPTE_RENDU, " &
                                       "TO_CHAR(CR.DATE_VISITE, 'MM/YYYY') as ""Date"", " &
                                       "U.NOM || ' ' || U.PRENOM as ""Visiteur"", " &
                                       "P.NOM as ""Praticien"" " &
                                       "FROM COMPTE_RENDU CR " &
                                       "JOIN UTILISATEUR U ON CR.ID_USER = U.ID_USER " &
                                       "JOIN PRATICIEN P ON CR.ID_PRATICIEN = P.ID_PRATICIEN " &
                                       $"WHERE CR.ID_USER {conditionEquipe} {conditionAnnee} " &
                                       "ORDER BY CR.DATE_VISITE DESC"

            ' On retire l'écouteur d'événement pour ne pas faire planter l'application pendant la création des lignes
            RemoveHandler Tableau_Synthese_Praticiens.SelectionChanged, AddressOf Tableau_Synthese_Praticiens_SelectionChanged

            Tableau_Synthese_Praticiens.DataSource = Conn.getData(sqlVisites)

            ' Astuce clé : On cache la colonne ID_COMPTE_RENDU à l'utilisateur, mais on la garde pour relier nos tableaux !
            If Tableau_Synthese_Praticiens.Columns.Contains("ID_COMPTE_RENDU") Then
                Tableau_Synthese_Praticiens.Columns("ID_COMPTE_RENDU").Visible = False
            End If

            AddHandler Tableau_Synthese_Praticiens.SelectionChanged, AddressOf Tableau_Synthese_Praticiens_SelectionChanged

            ' 3. On simule un clic sur la première ligne pour remplir le tableau de droite immédiatement
            If Tableau_Synthese_Praticiens.Rows.Count > 0 Then
                Tableau_Synthese_Praticiens.Rows(0).Selected = True
                AfficherDetailsVisite()
            Else
                Tableau_Activite.DataSource = Nothing ' On vide la droite si la gauche est vide
            End If

        Catch ex As Exception
            MessageBox.Show("Erreur SQL : " & ex.Message)
        End Try
    End Sub

    ' =========================================================================
    ' L'INTERACTIVITÉ : CLIC À GAUCHE = DÉTAILS À DROITE
    ' =========================================================================

    Private Sub Tableau_Synthese_Praticiens_SelectionChanged(sender As Object, e As EventArgs) Handles Tableau_Synthese_Praticiens.SelectionChanged
        AfficherDetailsVisite()
    End Sub

    Private Sub AfficherDetailsVisite()
        ' S'il n'y a pas de ligne sélectionnée, on arrête
        If Tableau_Synthese_Praticiens.SelectedRows.Count = 0 Then Return

        ' On récupère l'ID caché du compte-rendu qu'on vient de cliquer
        Dim idCompteRendu As String = Tableau_Synthese_Praticiens.SelectedRows(0).Cells("ID_COMPTE_RENDU").Value.ToString()

        Try
            ' On va chercher uniquement les détails de CE compte-rendu précis
            Dim sqlDetails As String = "SELECT " &
                                       "P.COEF_CONFIANCE as ""Coef. Confiance"", " &
                                       "NVL((SELECT SUM(QUANTITE) FROM ECHANTILLON E WHERE E.ID_COMPTE_RENDU = CR.ID_COMPTE_RENDU), 0) as ""Nb. Échantillons"", " &
                                       "CR.STATUS_MEDECIN as ""Statut"", " &
                                       "CR.BILAN_VISITE as ""Notation / Bilan"" " &
                                       "FROM COMPTE_RENDU CR " &
                                       "JOIN PRATICIEN P ON CR.ID_PRATICIEN = P.ID_PRATICIEN " &
                                       $"WHERE CR.ID_COMPTE_RENDU = {idCompteRendu}"

            Tableau_Activite.DataSource = Conn.getData(sqlDetails)

        Catch ex As Exception
            ' On met sous silence les erreurs mineures lors du clic rapide
        End Try
    End Sub

End Class