Imports System.Windows.Forms
Imports System.Data

Public Class CompteRendu
    Private modeAffichage As String = "PRODUIT"
    Private tableEchantillonsMemoire As New DataTable
    Private dvRecherche As DataView ' Pour filtrer les praticiens et les produits sans recharger la base





    Private Sub CompteRendu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Setup Table Echantillons (Droite)
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

        AfficherProduits()


        ' Fixer la largeur de la colonne d'en-tête à 25 pixels
        Tableau_Recherche.RowHeadersWidth = 25
        Tableau_Recherche.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing

        Tableau_Echantillons.RowHeadersWidth = 25
        Tableau_Echantillons.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing

    End Sub

    ' --- PARTIE GAUCHE ---
    Private Sub AfficherProduits()
        modeAffichage = "PRODUIT"
        Tableau_Recherche.Columns.Clear()

        Dim dt As DataTable = Conn.getData("SELECT ID_PRODUIT, NOMCOMMERCIAL FROM PRODUIT")

        ' On initialise le DataView avec la DataTable
        dvRecherche = New DataView(dt)
        ' On lie le DataView au DataGrid au lieu de la DataTable directement
        Tableau_Recherche.DataSource = dvRecherche

        If Tableau_Recherche.Columns.Contains("ID_PRODUIT") Then
            Tableau_Recherche.Columns("ID_PRODUIT").Visible = False
        End If

        ' Important : On vide la barre de recherche quand on change de mode
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
        ' On vérifie que le DataView est bien initialisé
        If dvRecherche IsNot Nothing Then
            Try
                ' On crée le filtre selon le mode (Produit ou Praticien)
                If modeAffichage = "PRODUIT" Then
                    ' Filtre sur le nom commercial (le % permet de chercher n'importe où dans le mot)
                    dvRecherche.RowFilter = "NOMCOMMERCIAL LIKE '%" & Barre_Recherche.Text.Replace("'", "''") & "%'"
                Else
                    ' Filtre sur le nom du praticien
                    dvRecherche.RowFilter = "NOM LIKE '%" & Barre_Recherche.Text.Replace("'", "''") & "%'"
                End If
            Catch ex As Exception
                ' En cas d'erreur de saisie (caractères spéciaux)
                dvRecherche.RowFilter = ""
            End Try
        End If
    End Sub

    Private Sub Tableau_Recherche_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tableau_Recherche.CellContentClick
        ' Si on clique sur le bouton "+"
        If modeAffichage = "PRODUIT" AndAlso Tableau_Recherche.Columns(e.ColumnIndex).Name = "Action" AndAlso e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = Tableau_Recherche.Rows(e.RowIndex)
            Dim idProd As Integer = row.Cells("ID_PRODUIT").Value
            Dim nomProd As String = row.Cells("NOMCOMMERCIAL").Value

            ' Ajouter à la liste de droite (quantité 1 par défaut, modifiable ensuite)
            AjouterEchantillon(idProd, nomProd)
        End If
    End Sub

    Private Sub Tableau_Recherche_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles Tableau_Recherche.CellClick
        ' Affichage de la description (sans ajouter)
        If e.RowIndex >= 0 And modeAffichage = "PRODUIT" Then
            Dim id As Integer = Tableau_Recherche.Rows(e.RowIndex).Cells("ID_PRODUIT").Value
            Dim dt As DataTable = Conn.getData("SELECT * FROM PRODUIT WHERE ID_PRODUIT = " & id)
            If dt.Rows.Count > 0 Then
                Txt_Description.Text = dt.Rows(0)("COMPOSITION").ToString() & vbCrLf & dt.Rows(0)("EFFETS_THERAPEUTIQUES").ToString()
            End If


            ' --- CAS PRATICIEN ---
        ElseIf modeAffichage = "PRATICIEN" Then
            ' On récupère le nom du praticien de la ligne cliquée
            Dim nomSelectionne As String = Tableau_Recherche.Rows(e.RowIndex).Cells("NOM").Value.ToString()

            ' On l'affiche dans votre TextBox
            Nom_Praticien.Text = nomSelectionne

            ' OPTIONNEL : Vous pouvez aussi stocker l'ID du praticien dans le Tag 
            ' de la TextBox pour l'utiliser lors de la validation finale (INSERT)
            Nom_Praticien.Tag = Tableau_Recherche.Rows(e.RowIndex).Cells("ID_PRATICIEN").Value
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
            ' On récupère le dernier ID + 1
            Dim resID = Conn.getData("SELECT COALESCE(MAX(ID_COMPTE_RENDU), 0) + 1 FROM COMPTE_RENDU")
            Dim nextID As Integer = Convert.ToInt32(resID.Rows(0)(0))

            ' Insert CR (Exemple avec ID statiques pour test, à lier à vos combos)
            Dim sqlCR As String = $"INSERT INTO COMPTE_RENDU (ID_COMPTE_RENDU, DATE_VISITE, DATE_SAISIE, MOTIF_VISITE, BILAN_VISITE, ID_USER, ID_PRATICIEN) " &
                                 $"VALUES ({nextID}, SYSDATE, SYSDATE, 1, 'Visite effectuée', 3, 1)"
            Conn.execute(sqlCR)

            ' Insert Echantillons
            For Each r As DataRow In tableEchantillonsMemoire.Rows
                Dim sqlEch As String = $"INSERT INTO ECHANTILLON (ID_PRODUIT, ID_COMPTE_RENDU, QUANTITE) VALUES ({r("ID_PRODUIT")}, {nextID}, {r("QUANTITE")})"
                Conn.execute(sqlEch)
            Next

            MessageBox.Show("Enregistré avec succès !")
            tableEchantillonsMemoire.Clear()
        Catch ex As Exception
            MessageBox.Show("Erreur : " & ex.Message)
        End Try
    End Sub

End Class