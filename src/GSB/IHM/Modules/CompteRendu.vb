Imports System.Windows.Forms
Imports System.Data

Public Class CompteRendu
    Private modeAffichage As String = "PRODUIT"
    Private tableEchantillonsMemoire As New DataTable
    Private dvRecherche As DataView ' Pour filtrer les praticiens et les produits sans recharger la base

    Private Sub CompteRendu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Configuration de la Table Echantillons (Droite)
        If tableEchantillonsMemoire.Columns.Count = 0 Then
            tableEchantillonsMemoire.Columns.Add("ID_PRODUIT", GetType(Integer))
            tableEchantillonsMemoire.Columns.Add("NOM", GetType(String))
            tableEchantillonsMemoire.Columns.Add("QUANTITE", GetType(Integer))
        End If

        Tableau_Echantillons.DataSource = tableEchantillonsMemoire

        ' MASQUER L'ID DANS LE TABLEAU DES ECHANTILLONS (à droite)
        If Tableau_Echantillons.Columns.Contains("ID_PRODUIT") Then
            Tableau_Echantillons.Columns("ID_PRODUIT").Visible = False
        End If

        ' Fixer la largeur de la colonne d'en-tête à 25 pixels
        Tableau_Recherche.RowHeadersWidth = 25
        Tableau_Recherche.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing

        Tableau_Echantillons.RowHeadersWidth = 25
        Tableau_Echantillons.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing

        ' 2. Initialisation des composants de saisie
        RemplirListeMotifs()
        ' (On a supprimé RemplirListePraticiens car on utilise maintenant txt_nom__praticien)

        ' 3. Affichage par défaut de la liste de recherche
        AfficherProduits()
    End Sub

    ' --- INITIALISATION DES COMBOBOX ---

    Private Sub RemplirListeMotifs()
        Try
            Dim sql As String = "SELECT ID_MOTIF, LBL_MOTIF FROM MOTIF_VISITE ORDER BY ID_MOTIF"
            Dim dtMotifs As DataTable = Conn.getData(sql)

            Liste_Motif.DataSource = dtMotifs
            Liste_Motif.DisplayMember = "LBL_MOTIF"
            Liste_Motif.ValueMember = "ID_MOTIF"
        Catch ex As Exception
            MessageBox.Show("Erreur lors du chargement des motifs : " & ex.Message)
        End Try
    End Sub

    ' --- PARTIE GAUCHE (Recherche) ---

    Private Sub AfficherProduits()
        modeAffichage = "PRODUIT"
        Tableau_Recherche.Columns.Clear()

        Dim dt As DataTable = Conn.getData("SELECT ID_PRODUIT, NOMCOMMERCIAL FROM PRODUIT")

        dvRecherche = New DataView(dt)
        Tableau_Recherche.DataSource = dvRecherche

        If Tableau_Recherche.Columns.Contains("ID_PRODUIT") Then
            Tableau_Recherche.Columns("ID_PRODUIT").Visible = False
        End If

        Barre_Recherche.Clear()

        Dim btnCol As New DataGridViewButtonColumn()
        btnCol.Name = "Action"
        btnCol.HeaderText = "Ajouter"
        btnCol.Text = "+"
        btnCol.UseColumnTextForButtonValue = True
        btnCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        Tableau_Recherche.Columns.Add(btnCol)
        Tableau_Recherche.Columns("NOMCOMMERCIAL").HeaderText = "Produit"
        Tableau_Recherche.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub AfficherPraticiens()
        modeAffichage = "PRATICIEN"
        Tableau_Recherche.Columns.Clear()

        Dim dt As DataTable = Conn.getData("SELECT ID_PRATICIEN, NOM, SPECIALITE, ADRESSE FROM PRATICIEN")

        dvRecherche = New DataView(dt)
        Tableau_Recherche.DataSource = dvRecherche

        If Tableau_Recherche.Columns.Contains("ID_PRATICIEN") Then
            Tableau_Recherche.Columns("ID_PRATICIEN").Visible = False
        End If

        Barre_Recherche.Clear()
        Tableau_Recherche.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub


    Private Sub Btn_Praticien_Click(sender As Object, e As EventArgs) Handles Btn_Praticien.Click
        AfficherPraticiens()
    End Sub

    Private Sub Btn_Produit_Click(sender As Object, e As EventArgs) Handles Btn_Produit.Click
        AfficherProduits()
    End Sub

    ' --- EVENEMENTS TABLEAU RECHERCHE ---

    Private Sub Txt_Recherche_TextChanged(sender As Object, e As EventArgs) Handles Barre_Recherche.TextChanged
        If dvRecherche IsNot Nothing Then
            Try
                If modeAffichage = "PRODUIT" Then
                    dvRecherche.RowFilter = "NOMCOMMERCIAL LIKE '%" & Barre_Recherche.Text.Replace("'", "''") & "%'"
                Else
                    dvRecherche.RowFilter = "NOM LIKE '%" & Barre_Recherche.Text.Replace("'", "''") & "%'"
                End If
            Catch ex As Exception
                dvRecherche.RowFilter = ""
            End Try
        End If
    End Sub

    Private Sub Tableau_Recherche_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tableau_Recherche.CellContentClick
        If modeAffichage = "PRODUIT" AndAlso Tableau_Recherche.Columns(e.ColumnIndex).Name = "Action" AndAlso e.RowIndex >= 0 Then
            Dim row = Tableau_Recherche.Rows(e.RowIndex)
            Dim idProd As Integer = row.Cells("ID_PRODUIT").Value
            Dim nomProd As String = row.Cells("NOMCOMMERCIAL").Value

            AjouterEchantillon(idProd, nomProd)
        End If
    End Sub

    Private Sub Tableau_Recherche_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tableau_Recherche.CellClick
        If e.RowIndex >= 0 And modeAffichage = "PRODUIT" Then
            Dim id As Integer = CInt(Tableau_Recherche.Rows(e.RowIndex).Cells("ID_PRODUIT").Value)
            Dim dt = Conn.getData("SELECT * FROM PRODUIT WHERE ID_PRODUIT = " & id)
            If dt.Rows.Count > 0 Then
                Txt_Description.Text = dt.Rows(0)("COMPOSITION").ToString & vbCrLf & dt.Rows(0)("EFFETS_THERAPEUTIQUES").ToString
            End If

            ' --- NOUVEAU CAS PRATICIEN ---
        ElseIf modeAffichage = "PRATICIEN" And e.RowIndex >= 0 Then
            ' 1. On récupère le Nom et la Spécialité pour faire un bel affichage
            Dim nom As String = Tableau_Recherche.Rows(e.RowIndex).Cells("NOM").Value.ToString()
            Dim specialite As String = Tableau_Recherche.Rows(e.RowIndex).Cells("SPECIALITE").Value.ToString()
            txt_nom__praticien.Text = nom & " - " & specialite

            ' 2. ASTUCE : On stocke l'ID_PRATICIEN secrètement dans la propriété Tag de la TextBox !
            txt_nom__praticien.Tag = Tableau_Recherche.Rows(e.RowIndex).Cells("ID_PRATICIEN").Value
        End If

    End Sub

    ' --- LOGIQUE ECHANTILLONS ---
    Private Sub AjouterEchantillon(id As Integer, nom As String)
        Dim found As Boolean = False
        For Each r As DataRow In tableEchantillonsMemoire.Rows
            If CInt(r("ID_PRODUIT")) = id Then
                r("QUANTITE") = CInt(r("QUANTITE")) + 1
                found = True
                Exit For
            End If
        Next
        If Not found Then
            tableEchantillonsMemoire.Rows.Add(id, nom, 1)
        End If
    End Sub

    ' --- VALIDATION ---
    Private Sub Btn_Valider_Click(sender As Object, e As EventArgs) Handles Btn_Valider.Click
        Try
            ' VERIFICATIONS AVANT INSERTION
            If txt_nom__praticien.Tag Is Nothing OrElse txt_nom__praticien.Text = "" Then
                MessageBox.Show("Veuillez sélectionner un praticien dans le tableau de recherche.")
                Return
            End If

            If Liste_Motif.SelectedValue Is Nothing Then
                MessageBox.Show("Veuillez sélectionner un motif de visite.")
                Return
            End If

            ' On récupère les valeurs
            Dim idPraticien As Integer = CInt(txt_nom__praticien.Tag) ' On récupère l'ID caché !
            Dim idMotif As Integer = CInt(Liste_Motif.SelectedValue)
            Dim bilan As String = TextBox2.Text.Replace("'", "''")

            ' On récupère le dernier ID + 1
            Dim resID = Conn.getData("SELECT COALESCE(MAX(ID_COMPTE_RENDU), 0) + 1 FROM COMPTE_RENDU")
            Dim nextID As Integer = Convert.ToInt32(resID.Rows(0)(0))

            ' Insert CR 
            Dim sqlCR As String = $"INSERT INTO COMPTE_RENDU (ID_COMPTE_RENDU, DATE_VISITE, DATE_SAISIE, MOTIF_VISITE, BILAN_VISITE, ID_USER, ID_PRATICIEN) " &
                                  $"VALUES ({nextID}, TO_DATE('{Date_Visite.Value.ToString("dd/MM/yyyy")}', 'DD/MM/YYYY'), SYSDATE, {idMotif}, '{bilan}', {Login.IdUtilisateur}, {idPraticien})"
            Conn.execute(sqlCR)

            ' Insert Echantillons
            For Each r As DataRow In tableEchantillonsMemoire.Rows
                Dim sqlEch As String = $"INSERT INTO ECHANTILLON (ID_PRODUIT, ID_COMPTE_RENDU, QUANTITE) VALUES ({r("ID_PRODUIT")}, {nextID}, {r("QUANTITE")})"
                Conn.execute(sqlEch)
            Next

            MessageBox.Show("Compte-rendu enregistré avec succès !")

            ' Remise à zéro du formulaire après succès
            tableEchantillonsMemoire.Clear()
            TextBox2.Clear()
            txt_nom__praticien.Clear()
            txt_nom__praticien.Tag = Nothing
            Date_Visite.Value = DateTime.Now

        Catch ex As Exception
            MessageBox.Show("Erreur lors de la validation : " & ex.Message)
        End Try
    End Sub

End Class