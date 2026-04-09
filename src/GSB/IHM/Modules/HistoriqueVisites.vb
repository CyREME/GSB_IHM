Imports System.Windows.Forms
Imports System.Data

Public Class HistoriqueVisites

    Private Sub HistoriqueVisites_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitialiserDatesParDefaut()

        ' Configuration du style GSB
        AppliquerStyleTableaux(Tableau_Historique)
        AppliquerStyleTableaux(Tableau_Details)

        ' On charge la liste de gauche
        ActualiserHistorique()
    End Sub

    Private Sub AppliquerStyleTableaux(grid As DataGridView)
        grid.BackgroundColor = Color.White
        grid.BorderStyle = BorderStyle.None
        grid.RowHeadersVisible = False
        grid.EnableHeadersVisualStyles = False
        grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        grid.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(83, 175, 255)
        grid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        grid.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        grid.DefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 245, 250)
        grid.DefaultCellStyle.SelectionForeColor = Color.Black
        grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        grid.GridColor = Color.FromArgb(230, 230, 230)
    End Sub

    Private Sub InitialiserDatesParDefaut()
        Try
            Dim sqlDates As String = $"SELECT MIN(DATE_VISITE), MAX(DATE_VISITE) FROM COMPTE_RENDU WHERE ID_USER = {Login.IdUtilisateur}"
            Dim dtDates As DataTable = Conn.getData(sqlDates)

            If dtDates IsNot Nothing AndAlso dtDates.Rows.Count > 0 AndAlso Not IsDBNull(dtDates.Rows(0)(0)) Then
                DatePickerMin.Value = Convert.ToDateTime(dtDates.Rows(0)(0))
                DatePickerMax.Value = Convert.ToDateTime(dtDates.Rows(0)(1))
            Else
                DatePickerMin.Value = New Date(DateTime.Now.Year, DateTime.Now.Month, 1)
                DatePickerMax.Value = DateTime.Now
            End If
        Catch ex As Exception
        End Try
    End Sub

    ' ---------------------------------------------------------
    ' 1. LISTE DE GAUCHE : L'historique chronologique
    ' ---------------------------------------------------------
    Private Sub ActualiserHistorique()
        Dim dateDebut As String = DatePickerMin.Value.ToString("dd/MM/yy")
        Dim dateFin As String = DatePickerMax.Value.ToString("dd/MM/yy")

        Dim sql As String = "SELECT CR.ID_COMPTE_RENDU, " &
                           "TO_CHAR(CR.DATE_VISITE, 'DD/MM/YYYY') as ""Date"", " &
                           "P.NOM as ""Praticien"", " &
                           "M.LBL_MOTIF as ""Motif"", " &
                           "ROUND(P.COEF_CONFIANCE, 1) as ""Confiance"" " &
                           "FROM COMPTE_RENDU CR " &
                           "JOIN PRATICIEN P ON CR.ID_PRATICIEN = P.ID_PRATICIEN " &
                           "JOIN MOTIF_VISITE M ON CR.MOTIF_VISITE = M.ID_MOTIF " &
                           $"WHERE CR.ID_USER = {Login.IdUtilisateur} " &
                           $"AND CR.DATE_VISITE BETWEEN TO_DATE('{dateDebut}', 'DD/MM/YY') AND TO_DATE('{dateFin}', 'DD/MM/YY') " &
                           "ORDER BY CR.DATE_VISITE DESC"

        Try
            ' On retire l'écouteur temporairement pendant le chargement
            RemoveHandler Tableau_Historique.SelectionChanged, AddressOf Tableau_Historique_SelectionChanged

            Tableau_Historique.DataSource = Conn.getData(sql)

            ' On cache l'ID (utile pour le clic, mais moche pour l'utilisateur)
            If Tableau_Historique.Columns.Contains("ID_COMPTE_RENDU") Then
                Tableau_Historique.Columns("ID_COMPTE_RENDU").Visible = False
            End If

            AddHandler Tableau_Historique.SelectionChanged, AddressOf Tableau_Historique_SelectionChanged

            ' On simule un clic sur la première ligne si elle existe
            If Tableau_Historique.Rows.Count > 0 Then
                Tableau_Historique.Rows(0).Selected = True
                AfficherDetailsVisite()
            Else
                Txt_Bilan.Clear()
                Tableau_Details.DataSource = Nothing
            End If
        Catch ex As Exception
        End Try
    End Sub

    ' ---------------------------------------------------------
    ' 2. ÉVÉNEMENTS DE DATES
    ' ---------------------------------------------------------
    Private Sub DatePickerMin_ValueChanged(sender As Object, e As EventArgs) Handles DatePickerMin.ValueChanged
        ActualiserHistorique()
    End Sub

    Private Sub DatePickerMax_ValueChanged(sender As Object, e As EventArgs) Handles DatePickerMax.ValueChanged
        ActualiserHistorique()
    End Sub

    ' ---------------------------------------------------------
    ' 3. L'INTERACTIVITÉ : CLIC À GAUCHE = DÉTAILS À DROITE
    ' ---------------------------------------------------------
    Private Sub Tableau_Historique_SelectionChanged(sender As Object, e As EventArgs) Handles Tableau_Historique.SelectionChanged
        AfficherDetailsVisite()
    End Sub

    Private Sub AfficherDetailsVisite()
        If Tableau_Historique.SelectedRows.Count = 0 Then Return

        Dim idCompteRendu As String = Tableau_Historique.SelectedRows(0).Cells("ID_COMPTE_RENDU").Value.ToString()

        Try
            ' A. On va chercher le texte du Bilan
            Dim sqlBilan As String = $"SELECT BILAN_VISITE FROM COMPTE_RENDU WHERE ID_COMPTE_RENDU = {idCompteRendu}"
            Dim dtBilan = Conn.getData(sqlBilan)
            If dtBilan.Rows.Count > 0 Then
                Txt_Bilan.Text = dtBilan.Rows(0)(0).ToString()
            Else
                Txt_Bilan.Text = "Aucun bilan."
            End If

            ' B. On va chercher la liste des échantillons donnés pendant CETTE visite
            Dim sqlEchantillons As String = "SELECT P.NOMCOMMERCIAL as ""Produit"", E.QUANTITE as ""Quantité"" " &
                                            "FROM ECHANTILLON E " &
                                            "JOIN PRODUIT P ON E.ID_PRODUIT = P.ID_PRODUIT " &
                                            $"WHERE E.ID_COMPTE_RENDU = {idCompteRendu}"

            Tableau_Details.DataSource = Conn.getData(sqlEchantillons)

        Catch ex As Exception
        End Try
    End Sub

End Class