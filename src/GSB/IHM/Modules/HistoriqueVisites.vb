Imports System.Windows.Forms
Imports System.Data

Public Class HistoriqueVisites
    ' On définit l'ID du visiteur (à dynamiser plus tard via le Login)
    Private idVisiteur As Integer = 3

    Private Sub HistoriqueVisites_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Configuration des DataGridView
        SetupTableaux()

        ' 2. Charger les années disponibles dans la base
        RemplirListeAnnees()

        ' 3. Charger les données initiales (Toutes les années par défaut)
        ActualiserSynthese()
    End Sub

    Private Sub SetupTableaux()
        ' Synthèse Praticiens (Gauche)
        With Tableau_Synthese_Praticiens
            .AllowUserToAddRows = False
            .RowHeadersVisible = False
            .ReadOnly = True
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End With

        ' Répartition Activité (Droite)
        With Tableau_Activite
            .AllowUserToAddRows = False
            .RowHeadersVisible = False
            .ReadOnly = True
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        End With
    End Sub

    Private Sub RemplirListeAnnees()
        ' Récupère toutes les années distinctes des visites pour ce visiteur
        Dim sql As String = $"SELECT DISTINCT TO_CHAR(DATE_VISITE, 'YYYY') as ANNEE FROM COMPTE_RENDU WHERE ID_USER = {idVisiteur} ORDER BY ANNEE DESC"
        Dim dt As DataTable = Conn.getData(sql)

        Liste_Annee.Items.Clear()
        Liste_Annee.Items.Add("Toutes")
        For Each row As DataRow In dt.Rows
            Liste_Annee.Items.Add(row("ANNEE").ToString())
        Next
        Liste_Annee.SelectedIndex = 0 ' Sélectionne "Toutes" par défaut
    End Sub

    ' --- LOGIQUE DE CALCUL ET AFFICHAGE ---

    Private Sub ActualiserSynthese()
        Dim anneeFiltre As String = Liste_Annee.SelectedItem.ToString()
        Dim conditionAnnee As String = If(anneeFiltre = "Toutes", "", $" AND TO_CHAR(DATE_VISITE, 'YYYY') = '{anneeFiltre}'")

        ' 1. Mise à jour des Labels (Nombre total de visites et échantillons)
        MettreAJourCompteurs(conditionAnnee)

        ' 2. Tableau de Gauche : Synthèse Praticiens
        ' On calcule la date max, le compte et la moyenne par praticien
        Dim sqlPrat As String = "SELECT P.NOM, MAX(CR.DATE_VISITE) as ""Dernière Visite"", " &
                               "COUNT(CR.ID_COMPTE_RENDU) as ""Total Visites"", " &
                               "ROUND(AVG(P.COEF_CONFIANCE), 1) as ""Moy. Confiance"" " &
                               "FROM COMPTE_RENDU CR " &
                               "JOIN PRATICIEN P ON CR.ID_PRATICIEN = P.ID_PRATICIEN " &
                               $"WHERE CR.ID_USER = {idVisiteur} {conditionAnnee} " &
                               "GROUP BY P.NOM"
        Tableau_Synthese_Praticiens.DataSource = Conn.getData(sqlPrat)

        ' 3. Tableau de Droite : Répartition d'Activité (Par Motif)
        Dim sqlActivite As String = "SELECT M.LBL_MOTIF as ""Motif"", COUNT(CR.ID_COMPTE_RENDU) as ""Nombre"" " &
                                   "FROM COMPTE_RENDU CR " &
                                   "JOIN MOTIF_VISITE M ON CR.MOTIF_VISITE = M.ID_MOTIF " &
                                   $"WHERE CR.ID_USER = {idVisiteur} {conditionAnnee} " &
                                   "GROUP BY M.LBL_MOTIF"
        Tableau_Activite.DataSource = Conn.getData(sqlActivite)
    End Sub

    Private Sub MettreAJourCompteurs(condition As String)
        ' Compte des visites
        Dim resVisites = Conn.getData($"SELECT COUNT(*) FROM COMPTE_RENDU WHERE ID_USER = {idVisiteur} {condition}")
        lbl_visites.Text = "Nombre total de visites : " & resVisites.Rows(0)(0).ToString()

        ' Somme des échantillons distribués
        Dim sqlEch As String = "SELECT COALESCE(SUM(E.QUANTITE), 0) FROM ECHANTILLON E " &
                              "JOIN COMPTE_RENDU CR ON E.ID_COMPTE_RENDU = CR.ID_COMPTE_RENDU " &
                              $"WHERE CR.ID_USER = {idVisiteur} {condition}"
        Dim resEch = Conn.getData(sqlEch)
        lbl_echantillon.Text = "Nombre total d'échantillons : " & resEch.Rows(0)(0).ToString()
    End Sub

    ' --- EVENEMENTS ---

    Private Sub Liste_Annee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Liste_Annee.SelectedIndexChanged
        ActualiserSynthese()
    End Sub
End Class