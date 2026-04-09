Imports Oracle.ManagedDataAccess.Client

Public Class VueRegion

    ' Se déclenche au chargement du composant
    Private Sub VueRegion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Au lieu d'actualiser directement le tableau, on charge d'abord les années.
        ' L'actualisation du tableau se fera automatiquement après !
        ChargerAnnees()
    End Sub

    ' ---------------------------------------------------------
    ' 1. MÉTHODE POUR REMPLIR LA COMBOBOX DES ANNÉES
    ' ---------------------------------------------------------
    Public Sub ChargerAnnees()
        Try
            ' On cherche uniquement les années distinctes (YYYY) des visites de la région du délégué
            Dim sql As String = "SELECT DISTINCT TO_CHAR(CR.DATE_VISITE, 'YYYY') AS ANNEE " &
                                "FROM COMPTE_RENDU CR " &
                                "JOIN UTILISATEUR V ON CR.ID_USER = V.ID_USER " &
                                "WHERE V.ROLE = 'Visiteur' " &
                                "AND V.ID_REGION = (SELECT ID_REGION FROM UTILISATEUR WHERE ID_USER = " & Login.IdUtilisateur & ") " &
                                "ORDER BY ANNEE DESC" ' Tri décroissant : la plus récente sera en haut !

            Dim dt As DataTable = Conn.getData(sql)

            ' On désactive temporairement l'écouteur d'événement pour éviter les bugs pendant le remplissage
            RemoveHandler Liste_Annee.SelectedIndexChanged, AddressOf Liste_Annee_SelectedIndexChanged

            Liste_Annee.DataSource = dt
            Liste_Annee.DisplayMember = "ANNEE"
            Liste_Annee.ValueMember = "ANNEE"

            ' On réactive l'écouteur d'événement
            AddHandler Liste_Annee.SelectedIndexChanged, AddressOf Liste_Annee_SelectedIndexChanged

            ' S'il y a des années trouvées, on sélectionne la première (la plus récente par défaut)
            ' Et on lance l'actualisation du tableau !
            If Liste_Annee.Items.Count > 0 Then
                Liste_Annee.SelectedIndex = 0
                ActualiserTableau()
            Else
                Tab.DataSource = Nothing ' Si aucune visite, on vide le tableau
            End If

        Catch ex As Exception
            MessageBox.Show("Erreur lors du chargement des années : " & ex.Message, "Erreur SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' ---------------------------------------------------------
    ' 2. ÉVÉNEMENT QUAND ON CHANGE L'ANNÉE DANS LA COMBOBOX
    ' ---------------------------------------------------------
    Private Sub Liste_Annee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Liste_Annee.SelectedIndexChanged
        ' Dès que le délégué choisit une autre année, on met à jour le tableau
        ActualiserTableau()
    End Sub

    ' ---------------------------------------------------------
    ' 3. FONCTION PRINCIPALE (Mise à jour avec filtre)
    ' ---------------------------------------------------------
    Public Sub ActualiserTableau()
        ' Sécurité : on vérifie qu'une année est bien sélectionnée
        If Liste_Annee.SelectedValue Is Nothing Then Return

        Dim anneeChoisie As String = Liste_Annee.SelectedValue.ToString()

        Try
            Tab.DataSource = Nothing
            Tab.Columns.Clear()

            ' On ajoute le filtre "TO_CHAR(CR.DATE_VISITE, 'YYYY') = anneeChoisie" dans le WHERE
            Dim sql As String = "SELECT " &
                                "TO_CHAR(CR.DATE_VISITE, 'MM/YYYY') AS ""Période (Mois/Année)"", " &
                                "COUNT(DISTINCT V.ID_USER) AS ""Nb. Visiteurs"", " &
                                "COUNT(DISTINCT CR.ID_COMPTE_RENDU) AS ""Nb. Visites"", " &
                                "NVL(SUM(E.QUANTITE), 0) AS ""Échantillons distribués"" " &
                                "FROM COMPTE_RENDU CR " &
                                "JOIN UTILISATEUR V ON CR.ID_USER = V.ID_USER " &
                                "LEFT JOIN ECHANTILLON E ON CR.ID_COMPTE_RENDU = E.ID_COMPTE_RENDU " &
                                "WHERE V.ROLE = 'Visiteur' " &
                                "AND V.ID_REGION = (SELECT ID_REGION FROM UTILISATEUR WHERE ID_USER = " & Login.IdUtilisateur & ") " &
                                "AND TO_CHAR(CR.DATE_VISITE, 'YYYY') = '" & anneeChoisie & "' " &
                                "GROUP BY TO_CHAR(CR.DATE_VISITE, 'MM/YYYY') " &
                                "ORDER BY MAX(CR.DATE_VISITE) DESC"

            Dim dt As DataTable = Conn.getData(sql)

            If dt IsNot Nothing Then
                Tab.DataSource = dt
                Tab.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                Tab.ReadOnly = True
                Tab.AllowUserToAddRows = False
                Tab.AllowUserToDeleteRows = False
                Tab.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            End If

        Catch ex As Exception
            MessageBox.Show("Erreur lors du chargement des statistiques de la région : " & ex.Message, "Erreur SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class