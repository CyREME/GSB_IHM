Imports System.Windows.Forms
Imports System.Data
Imports Oracle.ManagedDataAccess.Client

Public Class HistoriqueVisites

    ' On va stocker dynamiquement l'ID de la personne qu'on observe
    Private idVisiteurCible As Integer

    Private Sub HistoriqueVisites_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Configuration des DataGridView
        SetupTableaux()

        ' 2. On vérifie qui est connecté pour adapter l'interface
        If Login.Role = "Delegue" Then
            ' C'est un délégué : on affiche la liste et on la remplit
            lbl_Collaborateur.Visible = True
            Liste_Collaborateurs.Visible = True
            ChargerCollaborateurs()
        Else
            ' C'est un visiteur : on cache la liste et on cible son propre ID
            lbl_Collaborateur.Visible = False
            Liste_Collaborateurs.Visible = False
            idVisiteurCible = Login.IdUtilisateur

            ' On charge ses données
            RemplirListeAnnees()
            ActualiserSynthese()
        End If
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

    ' ---------------------------------------------------------
    ' NOUVEAU : GESTION DES COLLABORATEURS POUR LE DÉLÉGUÉ
    ' ---------------------------------------------------------
    Private Sub ChargerCollaborateurs()
        Try
            ' Requête astucieuse avec UNION ALL et une colonne "TRI" pour forcer "Moi-même" tout en haut !
            Dim sql As String = $"SELECT ID_USER, 'Moi-même' AS NOMCOMPLET, 1 AS TRI " &
                                $"FROM UTILISATEUR WHERE ID_USER = {Login.IdUtilisateur} " &
                                $"UNION ALL " &
                                $"SELECT ID_USER, NOM || ' ' || PRENOM AS NOMCOMPLET, 2 AS TRI " &
                                $"FROM UTILISATEUR WHERE ROLE = 'Visiteur' AND ID_DELEGUE = {Login.IdUtilisateur} " &
                                $"ORDER BY TRI, NOMCOMPLET"

            Dim dt As DataTable = Conn.getData(sql)

            RemoveHandler Liste_Collaborateurs.SelectedIndexChanged, AddressOf Liste_Collaborateurs_SelectedIndexChanged

            Liste_Collaborateurs.DataSource = dt
            Liste_Collaborateurs.DisplayMember = "NOMCOMPLET"
            Liste_Collaborateurs.ValueMember = "ID_USER"

            AddHandler Liste_Collaborateurs.SelectedIndexChanged, AddressOf Liste_Collaborateurs_SelectedIndexChanged

            ' On sélectionne "Moi-même" par défaut au chargement
            If Liste_Collaborateurs.Items.Count > 0 Then
                Liste_Collaborateurs.SelectedIndex = 0
                idVisiteurCible = Convert.ToInt32(Liste_Collaborateurs.SelectedValue)
                RemplirListeAnnees()
                ActualiserSynthese()
            End If

        Catch ex As Exception
            MessageBox.Show("Erreur lors du chargement de l'équipe : " & ex.Message)
        End Try
    End Sub

    Private Sub Liste_Collaborateurs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Liste_Collaborateurs.SelectedIndexChanged
        ' Dès qu'on change de collaborateur, on met à jour la cible et on recharge tout !
        If Liste_Collaborateurs.SelectedValue IsNot Nothing Then
            idVisiteurCible = Convert.ToInt32(Liste_Collaborateurs.SelectedValue)
            RemplirListeAnnees()
            ActualiserSynthese()
        End If
    End Sub


    ' ---------------------------------------------------------
    ' GESTION DES ANNÉES
    ' ---------------------------------------------------------
    Private Sub RemplirListeAnnees()
        ' Récupère toutes les années distinctes des visites pour la CIBLE
        Dim sql As String = $"SELECT DISTINCT TO_CHAR(DATE_VISITE, 'YYYY') as ANNEE FROM COMPTE_RENDU WHERE ID_USER = {idVisiteurCible} ORDER BY ANNEE DESC"
        Dim dt As DataTable = Conn.getData(sql)

        RemoveHandler Liste_Annee.SelectedIndexChanged, AddressOf Liste_Annee_SelectedIndexChanged

        Liste_Annee.Items.Clear()
        Liste_Annee.Items.Add("Toutes")
        For Each row As DataRow In dt.Rows
            Liste_Annee.Items.Add(row("ANNEE").ToString())
        Next
        Liste_Annee.SelectedIndex = 0 ' Sélectionne "Toutes" par défaut

        AddHandler Liste_Annee.SelectedIndexChanged, AddressOf Liste_Annee_SelectedIndexChanged
    End Sub

    Private Sub Liste_Annee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Liste_Annee.SelectedIndexChanged
        ActualiserSynthese()
    End Sub


    ' ---------------------------------------------------------
    ' LOGIQUE DE CALCUL ET AFFICHAGE
    ' ---------------------------------------------------------
    Private Sub ActualiserSynthese()
        ' Sécurité si la liste est vide
        If Liste_Annee.SelectedItem Is Nothing Then Return

        Dim anneeFiltre As String = Liste_Annee.SelectedItem.ToString()
        Dim conditionAnnee As String = If(anneeFiltre = "Toutes", "", $" AND TO_CHAR(CR.DATE_VISITE, 'YYYY') = '{anneeFiltre}'")
        Dim conditionAnneeSimple As String = If(anneeFiltre = "Toutes", "", $" AND TO_CHAR(DATE_VISITE, 'YYYY') = '{anneeFiltre}'")

        Try
            ' 1. Mise à jour des Labels
            MettreAJourCompteurs(conditionAnnee, conditionAnneeSimple)

            ' 2. Tableau de Gauche : Synthèse Praticiens
            Dim sqlPrat As String = "SELECT P.NOM, TO_CHAR(MAX(CR.DATE_VISITE), 'DD/MM/YYYY') as ""Dernière Visite"", " &
                                   "COUNT(CR.ID_COMPTE_RENDU) as ""Total Visites"", " &
                                   "ROUND(AVG(P.COEF_CONFIANCE), 1) as ""Moy. Confiance"" " &
                                   "FROM COMPTE_RENDU CR " &
                                   "JOIN PRATICIEN P ON CR.ID_PRATICIEN = P.ID_PRATICIEN " &
                                   $"WHERE CR.ID_USER = {idVisiteurCible} {conditionAnnee} " &
                                   "GROUP BY P.NOM"
            Tableau_Synthese_Praticiens.DataSource = Conn.getData(sqlPrat)

            ' 3. Tableau de Droite : Répartition d'Activité
            Dim sqlActivite As String = "SELECT M.LBL_MOTIF as ""Motif"", COUNT(CR.ID_COMPTE_RENDU) as ""Nombre"" " &
                                       "FROM COMPTE_RENDU CR " &
                                       "JOIN MOTIF_VISITE M ON CR.MOTIF_VISITE = M.ID_MOTIF " &
                                       $"WHERE CR.ID_USER = {idVisiteurCible} {conditionAnnee} " &
                                       "GROUP BY M.LBL_MOTIF"
            Tableau_Activite.DataSource = Conn.getData(sqlActivite)

        Catch ex As Exception
        End Try
    End Sub

    Private Sub MettreAJourCompteurs(conditionCR As String, conditionSimple As String)
        ' Compte des visites
        Dim resVisites = Conn.getData($"SELECT COUNT(*) FROM COMPTE_RENDU WHERE ID_USER = {idVisiteurCible} {conditionSimple}")
        If resVisites.Rows.Count > 0 Then
            lbl_visites.Text = "Nombre total de visites : " & resVisites.Rows(0)(0).ToString()
        End If

        ' Somme des échantillons distribués
        Dim sqlEch As String = "SELECT NVL(SUM(E.QUANTITE), 0) FROM ECHANTILLON E " &
                              "JOIN COMPTE_RENDU CR ON E.ID_COMPTE_RENDU = CR.ID_COMPTE_RENDU " &
                              $"WHERE CR.ID_USER = {idVisiteurCible} {conditionCR}"
        Dim resEch = Conn.getData(sqlEch)
        If resEch.Rows.Count > 0 Then
            lbl_echantillon.Text = "Nombre total d'échantillons : " & resEch.Rows(0)(0).ToString()
        End If
    End Sub

End Class