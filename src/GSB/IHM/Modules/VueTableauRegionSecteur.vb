Imports Oracle.ManagedDataAccess.Client

Public Class VueTableauRegionSecteur

    Public ModeActuel As String = "Regions"

    ' Événement que le formulaire parent (Responsable.vb) pourra écouter
    Public Event DemandeObservationVisiteur(idVisiteur As Integer)

    Private Sub VueTableauRegionSecteur_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActualiserTableau()
    End Sub

    ' ---------------------------------------------------------
    ' ÉVÉNEMENTS
    ' ---------------------------------------------------------
    Private Sub Liste_Delegues_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Liste_Delegues.SelectedIndexChanged
        If Liste_Visiteurs.Visible AndAlso Liste_Delegues.SelectedValue IsNot Nothing Then
            ChargerListeVisiteurs(Convert.ToInt32(Liste_Delegues.SelectedValue))
        End If
        ActualiserTableau()
    End Sub

    Private Sub Liste_Visiteurs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Liste_Visiteurs.SelectedIndexChanged
        ActualiserTableau()
    End Sub

    ' ---------------------------------------------------------
    ' FONCTION PRINCIPALE (Le tableau)
    ' ---------------------------------------------------------
    Public Sub ActualiserTableau()
        Dim sql As String = ""

        Try
            ' On vide complètement le tableau et ses colonnes 
            Tab.DataSource = Nothing
            Tab.Columns.Clear()

            ' =========================================================
            ' CAS 1 : MODE RÉGIONS
            ' =========================================================
            If ModeActuel = "Regions" Then
                If Liste_Delegues.Visible AndAlso Not Liste_Visiteurs.Visible Then
                    If Liste_Delegues.SelectedValue IsNot Nothing Then
                        sql = "SELECT U.ID_USER AS ""ID"", " &
                              "U.NOM || ' ' || U.PRENOM AS ""Visiteur"", " &
                              "COUNT(DISTINCT CR.ID_COMPTE_RENDU) AS ""Total Visites"", " &
                              "NVL(SUM(E.QUANTITE), 0) AS ""Total Échantillons"", " &
                              "ROUND(AVG(P.COEF_CONFIANCE), 2) AS ""Moyenne Confiance"", " &
                              "TO_CHAR(MAX(CR.DATE_VISITE), 'DD/MM/YYYY') AS ""Dernière Visite"", " &
                              "TO_CHAR(MAX(CR.DATE_SAISIE), 'DD/MM/YYYY') AS ""Dernière Saisie"" " &
                              "FROM UTILISATEUR U " &
                              "LEFT JOIN COMPTE_RENDU CR ON U.ID_USER = CR.ID_USER " &
                              "LEFT JOIN ECHANTILLON E ON CR.ID_COMPTE_RENDU = E.ID_COMPTE_RENDU " &
                              "LEFT JOIN PRATICIEN P ON CR.ID_PRATICIEN = P.ID_PRATICIEN " &
                              "WHERE U.ROLE = 'Visiteur' AND U.ID_DELEGUE = " & Liste_Delegues.SelectedValue.ToString() & " " &
                              "GROUP BY U.ID_USER, U.NOM, U.PRENOM"
                    End If
                Else
                    sql = "SELECT r.Lbl_Region AS ""Région"", s.Lbl_Secteur AS ""Secteur"" " &
                          "FROM Region r JOIN Secteur s ON r.ID_Region = s.ID_Region"
                End If

                ' =========================================================
                ' CAS 2 : MODE DÉLÉGUÉS
                ' =========================================================
            ElseIf ModeActuel = "Delegues" Then
                sql = "SELECT ID_User AS ""ID"", Nom, Prenom " &
                      "FROM Utilisateur WHERE Role = 'Delegue' AND ID_SECTEUR_RESP = " & Login.IdUtilisateur

                ' =========================================================
                ' CAS 3 : MODE VISITEURS (Affichage des comptes rendus)
                ' =========================================================
            ElseIf ModeActuel = "Visiteurs" Then
                If Liste_Delegues.Visible AndAlso Liste_Visiteurs.Visible Then
                    If Liste_Visiteurs.SelectedValue IsNot Nothing Then

                        ' ---> NOUVELLE REQUÊTE : L'historique des visites du visiteur choisi <---
                        sql = "SELECT " &
                              "TO_CHAR(CR.DATE_VISITE, 'DD/MM/YYYY') AS ""Date visite"", " &
                              "TO_CHAR(CR.DATE_SAISIE, 'DD/MM/YYYY') AS ""Date saisie"", " &
                              "P.NOM AS ""Praticien vu"", " &
                              "CR.BILAN_VISITE AS ""Bilan"", " &
                              "NVL(SUM(E.QUANTITE), 0) AS ""Nb. Échantillons"", " &
                              "P.COEF_CONFIANCE AS ""Coef. Confiance"" " &
                              "FROM COMPTE_RENDU CR " &
                              "JOIN PRATICIEN P ON CR.ID_PRATICIEN = P.ID_PRATICIEN " &
                              "LEFT JOIN ECHANTILLON E ON CR.ID_COMPTE_RENDU = E.ID_COMPTE_RENDU " &
                              "WHERE CR.ID_USER = " & Liste_Visiteurs.SelectedValue.ToString() & " " &
                              "GROUP BY CR.ID_COMPTE_RENDU, CR.DATE_VISITE, CR.DATE_SAISIE, P.NOM, CR.BILAN_VISITE, P.COEF_CONFIANCE " &
                              "ORDER BY CR.DATE_VISITE DESC"

                    End If
                End If
            End If

            ' --- EXÉCUTION ET AFFICHAGE ---
            If Not String.IsNullOrEmpty(sql) Then
                Dim dt As DataTable = Conn.getData(sql)
                Tab.DataSource = dt

                ' Ajout du bouton Observer (seulement en mode Régions)
                If ModeActuel = "Regions" AndAlso Liste_Delegues.Visible AndAlso Not Liste_Visiteurs.Visible Then
                    Dim btnCol As New DataGridViewButtonColumn()
                    btnCol.Name = "BtnObserver"
                    btnCol.HeaderText = "Action"
                    btnCol.Text = "Observer"
                    btnCol.UseColumnTextForButtonValue = True
                    Tab.Columns.Add(btnCol)
                End If

                ' ---> GESTION INTELLIGENTE DES LARGEURS DE COLONNES <---
                Tab.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells

                If Tab.Columns.Contains("Bilan") Then
                    ' On étire la colonne Bilan car c'est elle qui contient le plus de texte !
                    Tab.Columns("Bilan").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                ElseIf Tab.Columns.Contains("Visiteur") Then
                    Tab.Columns("Visiteur").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                ElseIf Tab.Columns.Contains("Région") Then
                    Tab.Columns("Région").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                ElseIf Tab.Columns.Count > 0 Then
                    Tab.Columns(Tab.Columns.Count - 1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                End If

                ' ---> LECTURE SEULE <---
                Tab.ReadOnly = True
                Tab.AllowUserToAddRows = False
                Tab.AllowUserToDeleteRows = False
            End If

        Catch ex As Exception
        End Try
    End Sub

    ' ---------------------------------------------------------
    ' ÉVÉNEMENT : CLIC DANS LE TABLEAU
    ' ---------------------------------------------------------
    Private Sub Tab_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tab.CellContentClick
        If e.RowIndex >= 0 AndAlso Tab.Columns(e.ColumnIndex).Name = "BtnObserver" Then
            Dim idDuVisiteur As Integer = Convert.ToInt32(Tab.Rows(e.RowIndex).Cells("ID").Value)
            RaiseEvent DemandeObservationVisiteur(idDuVisiteur)
        End If
    End Sub

    ' ---------------------------------------------------------
    ' MÉTHODES DE REMPLISSAGE DES COMBOBOX
    ' ---------------------------------------------------------
    Public Sub ChargerListeDelegues()
        Dim sql As String = "SELECT ID_USER, NOM || ' ' || PRENOM AS NOMCOMPLET " &
                            "FROM UTILISATEUR WHERE ROLE = 'Delegue' AND ID_SECTEUR_RESP = " & Login.IdUtilisateur

        Dim dt As DataTable = Conn.getData(sql)
        RemoveHandler Liste_Delegues.SelectedIndexChanged, AddressOf Liste_Delegues_SelectedIndexChanged
        Liste_Delegues.DataSource = dt
        Liste_Delegues.DisplayMember = "NOMCOMPLET"
        Liste_Delegues.ValueMember = "ID_USER"
        AddHandler Liste_Delegues.SelectedIndexChanged, AddressOf Liste_Delegues_SelectedIndexChanged

        ' Si on a des délégués, on charge ses visiteurs (ce qui va actualiser le tableau)
        If Liste_Delegues.Items.Count > 0 Then
            ChargerListeVisiteurs(Convert.ToInt32(Liste_Delegues.SelectedValue))
        Else
            ' S'il n'y a pas de délégué, on force quand même l'actualisation pour vider le tableau
            ActualiserTableau()
        End If
    End Sub

    Public Sub ChargerListeVisiteurs(idDelegue As Integer)
        Dim sql As String = "SELECT ID_USER, NOM || ' ' || PRENOM AS NOMCOMPLET " &
                            "FROM UTILISATEUR WHERE ROLE = 'Visiteur' AND ID_DELEGUE = " & idDelegue.ToString()

        Dim dt As DataTable = Conn.getData(sql)
        RemoveHandler Liste_Visiteurs.SelectedIndexChanged, AddressOf Liste_Visiteurs_SelectedIndexChanged
        Liste_Visiteurs.DataSource = dt
        Liste_Visiteurs.DisplayMember = "NOMCOMPLET"
        Liste_Visiteurs.ValueMember = "ID_USER"
        AddHandler Liste_Visiteurs.SelectedIndexChanged, AddressOf Liste_Visiteurs_SelectedIndexChanged

        ' ---> NOUVEAU : On force le tableau à s'afficher avec les données du visiteur fraîchement chargé !
        ActualiserTableau()
    End Sub

End Class