Imports System.Windows.Forms
Imports System.Data

Public Class CompteRendu
    Private modeAffichage As String = "PRODUIT"
    Private tableEchantillonsMemoire As New DataTable
    Private dvRecherche As DataView

    ' Couleurs pour nos boutons d'onglets
    Private colorOngletActif As Color = Color.FromArgb(83, 175, 255)
    Private colorTexteActif As Color = Color.White
    Private colorOngletInactif As Color = Color.FromArgb(230, 235, 240)
    Private colorTexteInactif As Color = Color.FromArgb(100, 100, 100)

    Private Sub CompteRendu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Configuration de la Table Echantillons
        If tableEchantillonsMemoire.Columns.Count = 0 Then
            tableEchantillonsMemoire.Columns.Add("ID_PRODUIT", GetType(Integer))
            tableEchantillonsMemoire.Columns.Add("NOM", GetType(String))
            tableEchantillonsMemoire.Columns.Add("QUANTITE", GetType(Integer))
        End If

        Tableau_Echantillons.DataSource = tableEchantillonsMemoire
        If Tableau_Echantillons.Columns.Contains("ID_PRODUIT") Then
            Tableau_Echantillons.Columns("ID_PRODUIT").Visible = False
        End If

        ' 2. Appliquer le style moderne aux tableaux
        AppliquerStyleTableaux(Tableau_Recherche)
        AppliquerStyleTableaux(Tableau_Echantillons)

        ' 3. Initialisation
        RemplirListeMotifs()
        AfficherProduits()
    End Sub

    ' --- STYLE DES TABLEAUX ---
    Private Sub AppliquerStyleTableaux(grid As DataGridView)
        grid.BackgroundColor = Color.White
        grid.BorderStyle = BorderStyle.None
        grid.RowHeadersVisible = False ' Supprime la colonne vide disgracieuse à gauche
        grid.EnableHeadersVisualStyles = False
        grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None

        ' En-tête Bleu GSB
        grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(83, 175, 255)
        grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        grid.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)

        ' Lignes épurées
        grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 245, 250)
        grid.DefaultCellStyle.SelectionForeColor = Color.Black
        grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        grid.GridColor = Color.FromArgb(230, 230, 230)
    End Sub

    Private Sub ActiverOnglet(btnActif As Button)
        Btn_Produit.BackColor = colorOngletInactif
        Btn_Produit.ForeColor = colorTexteInactif
        Btn_Praticien.BackColor = colorOngletInactif
        Btn_Praticien.ForeColor = colorTexteInactif

        btnActif.BackColor = colorOngletActif
        btnActif.ForeColor = colorTexteActif
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
        End Try
    End Sub

    ' --- PARTIE GAUCHE (Recherche) ---
    Private Sub AfficherProduits()
        modeAffichage = "PRODUIT"
        ActiverOnglet(Btn_Produit)
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
        btnCol.HeaderText = "Ajout"
        btnCol.Text = "➕"
        btnCol.UseColumnTextForButtonValue = True
        btnCol.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells

        ' Style spécifique au bouton '+'
        btnCol.FlatStyle = FlatStyle.Flat
        btnCol.DefaultCellStyle.ForeColor = Color.FromArgb(40, 167, 69)
        btnCol.DefaultCellStyle.Font = New Font("Segoe UI", 12, FontStyle.Bold)

        Tableau_Recherche.Columns.Add(btnCol)
        Tableau_Recherche.Columns("NOMCOMMERCIAL").HeaderText = "Nom du Produit"
        Tableau_Recherche.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
    End Sub

    Private Sub AfficherPraticiens()
        modeAffichage = "PRATICIEN"
        ActiverOnglet(Btn_Praticien)
        Tableau_Recherche.Columns.Clear()

        Dim dt As DataTable = Conn.getData("SELECT ID_PRATICIEN, NOM, SPECIALITE, ADRESSE FROM PRATICIEN")
        dvRecherche = New DataView(dt)
        Tableau_Recherche.DataSource = dvRecherche

        If Tableau_Recherche.Columns.Contains("ID_PRATICIEN") Then
            Tableau_Recherche.Columns("ID_PRATICIEN").Visible = False
        End If

        Barre_Recherche.Clear()
        Tableau_Recherche.Columns("NOM").HeaderText = "Praticien"
        Tableau_Recherche.Columns("SPECIALITE").HeaderText = "Spécialité"
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

        ElseIf modeAffichage = "PRATICIEN" And e.RowIndex >= 0 Then
            Dim nom As String = Tableau_Recherche.Rows(e.RowIndex).Cells("NOM").Value.ToString()
            Dim specialite As String = Tableau_Recherche.Rows(e.RowIndex).Cells("SPECIALITE").Value.ToString()
            txt_nom__praticien.Text = nom & " - " & specialite
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
            If txt_nom__praticien.Tag Is Nothing OrElse txt_nom__praticien.Text = "" Then
                MessageBox.Show("Veuillez sélectionner un praticien dans le tableau de recherche.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            If Liste_Motif.SelectedValue Is Nothing Then
                MessageBox.Show("Veuillez sélectionner un motif de visite.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
            End If

            Dim idPraticien As Integer = CInt(txt_nom__praticien.Tag)
            Dim idMotif As Integer = CInt(Liste_Motif.SelectedValue)
            Dim bilan As String = TextBox2.Text.Replace("'", "''")

            Dim resID = Conn.getData("SELECT COALESCE(MAX(ID_COMPTE_RENDU), 0) + 1 FROM COMPTE_RENDU")
            Dim nextID As Integer = Convert.ToInt32(resID.Rows(0)(0))

            Dim sqlCR As String = $"INSERT INTO COMPTE_RENDU (ID_COMPTE_RENDU, DATE_VISITE, DATE_SAISIE, MOTIF_VISITE, BILAN_VISITE, ID_USER, ID_PRATICIEN) " &
                                  $"VALUES ({nextID}, TO_DATE('{Date_Visite.Value.ToString("dd/MM/yyyy")}', 'DD/MM/YYYY'), SYSDATE, {idMotif}, '{bilan}', {Login.IdUtilisateur}, {idPraticien})"
            Conn.execute(sqlCR)

            For Each r As DataRow In tableEchantillonsMemoire.Rows
                Dim sqlEch As String = $"INSERT INTO ECHANTILLON (ID_PRODUIT, ID_COMPTE_RENDU, QUANTITE) VALUES ({r("ID_PRODUIT")}, {nextID}, {r("QUANTITE")})"
                Conn.execute(sqlEch)
            Next

            MessageBox.Show("Compte-rendu enregistré avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information)

            tableEchantillonsMemoire.Clear()
            TextBox2.Clear()
            txt_nom__praticien.Clear()
            txt_nom__praticien.Tag = Nothing
            Txt_Description.Clear()
            Date_Visite.Value = DateTime.Now

        Catch ex As Exception
            MessageBox.Show("Erreur lors de la validation : " & ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class