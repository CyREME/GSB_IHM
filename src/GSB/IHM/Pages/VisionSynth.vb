Imports System.Windows.Forms
Imports System.Data

Public Class VisionSynth
    ' ID du visiteur connecté (à dynamiser selon votre système de login)
    Private idVisiteur As Integer = 3

    Private Sub VisionSynth_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 1. Initialiser les dates par défaut (Première et Dernière visite)
        InitialiserDatesParDefaut()

        ' 2. Configurer le tableau
        With Tableau_vision_synthèse
            .AllowUserToAddRows = False
            .RowHeadersVisible = False
            .ReadOnly = True
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End With

        ' 3. Charger les données
        ActualiserVisionSynthese()
    End Sub

    Private Sub InitialiserDatesParDefaut()
        Try
            ' On cherche la date min et max dans la table compte_rendu pour ce visiteur
            Dim sqlDates As String = $"SELECT MIN(DATE_VISITE), MAX(DATE_VISITE) FROM COMPTE_RENDU WHERE ID_USER = {idVisiteur}"
            Dim dtDates As DataTable = Conn.getData(sqlDates)

            If dtDates.Rows.Count > 0 AndAlso Not IsDBNull(dtDates.Rows(0)(0)) Then
                ' On règle les DatePickers
                DatePickerMin.Value = Convert.ToDateTime(dtDates.Rows(0)(0))
                DatePickerMax.Value = Convert.ToDateTime(dtDates.Rows(0)(1))
            Else
                ' Si aucune visite, on met par défaut le mois en cours
                DatePickerMin.Value = New Date(DateTime.Now.Year, DateTime.Now.Month, 1)
                DatePickerMax.Value = DateTime.Now
            End If
        Catch ex As Exception
            MessageBox.Show("Erreur lors de l'initialisation des dates : " & ex.Message)
        End Try
    End Sub

    Private Sub ActualiserVisionSynthese()
        ' On formate les dates pour Oracle (JJ/MM/AA)
        Dim dateDebut As String = DatePickerMin.Value.ToString("dd/MM/yy")
        Dim dateFin As String = DatePickerMax.Value.ToString("dd/MM/yy")

        ' Requête de synthèse : on regroupe par Mois/Année pour voir l'évolution de la productivité
        ' On compte les visites et on somme les échantillons liés
        Dim sql As String = "SELECT TO_CHAR(CR.DATE_VISITE, 'MM/YYYY') as ""Période"", " &
                           "COUNT(DISTINCT CR.ID_COMPTE_RENDU) as ""Nb Visites"", " &
                           "COUNT(DISTINCT CR.ID_PRATICIEN) as ""Praticiens différents"", " &
                           "NVL(SUM(E.QUANTITE), 0) as ""Échantillons distribués"" " &
                           "FROM COMPTE_RENDU CR " &
                           "LEFT JOIN ECHANTILLON E ON CR.ID_COMPTE_RENDU = E.ID_COMPTE_RENDU " &
                           $"WHERE CR.ID_USER = {idVisiteur} " &
                           $"AND CR.DATE_VISITE BETWEEN TO_DATE('{dateDebut}', 'DD/MM/YY') AND TO_DATE('{dateFin}', 'DD/MM/YY') " &
                           "GROUP BY TO_CHAR(CR.DATE_VISITE, 'MM/YYYY'), TO_CHAR(CR.DATE_VISITE, 'YYYYMM') " &
                           "ORDER BY TO_CHAR(CR.DATE_VISITE, 'YYYYMM') DESC"

        Tableau_vision_synthèse.DataSource = Conn.getData(sql)
    End Sub

    ' --- ÉVÉNEMENTS ---

    ' Quand l'utilisateur change une date, le tableau se met à jour instantanément
    Private Sub DatePickerMin_ValueChanged(sender As Object, e As EventArgs) Handles DatePickerMin.ValueChanged
        ActualiserVisionSynthese()
    End Sub

    Private Sub DatePickerMax_ValueChanged(sender As Object, e As EventArgs) Handles DatePickerMax.ValueChanged
        ActualiserVisionSynthese()
    End Sub
End Class