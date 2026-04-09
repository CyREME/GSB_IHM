Imports System.Windows.Forms
Imports System.Data

Public Class VisionSynth

    Private Sub VisionSynth_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetupTableaux()
        AppliquerStyleTableaux(Tableau_Synthese_Praticiens)
        AppliquerStyleTableaux(Tableau_Activite)
        RemplirListeAnnees()
        ActualiserSynthese()
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

    Private Sub SetupTableaux()
        With Tableau_Synthese_Praticiens
            .AllowUserToAddRows = False
            .RowHeadersVisible = False
            .ReadOnly = True
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End With

        With Tableau_Activite
            .AllowUserToAddRows = False
            .RowHeadersVisible = False
            .ReadOnly = True
            .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            .SelectionMode = DataGridViewSelectionMode.FullRowSelect
        End With
    End Sub

    Private Sub RemplirListeAnnees()
        Dim sql As String = $"SELECT DISTINCT TO_CHAR(DATE_VISITE, 'YYYY') as ANNEE FROM COMPTE_RENDU WHERE ID_USER = {Login.IdUtilisateur} ORDER BY ANNEE DESC"
        Dim dt As DataTable = Conn.getData(sql)

        RemoveHandler Liste_Annee.SelectedIndexChanged, AddressOf Liste_Annee_SelectedIndexChanged
        Liste_Annee.Items.Clear()
        Liste_Annee.Items.Add("Toutes")
        For Each row As DataRow In dt.Rows
            Liste_Annee.Items.Add(row("ANNEE").ToString())
        Next
        Liste_Annee.SelectedIndex = 0
        AddHandler Liste_Annee.SelectedIndexChanged, AddressOf Liste_Annee_SelectedIndexChanged
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
            Dim resVisites = Conn.getData($"SELECT COUNT(*) FROM COMPTE_RENDU WHERE ID_USER = {Login.IdUtilisateur} {conditionAnneeSimple}")
            If resVisites.Rows.Count > 0 Then lbl_visites.Text = "Nombre total de visites : " & resVisites.Rows(0)(0).ToString()

            Dim sqlEch As String = "SELECT NVL(SUM(E.QUANTITE), 0) FROM ECHANTILLON E JOIN COMPTE_RENDU CR ON E.ID_COMPTE_RENDU = CR.ID_COMPTE_RENDU " &
                                  $"WHERE CR.ID_USER = {Login.IdUtilisateur} {conditionAnnee}"
            Dim resEch = Conn.getData(sqlEch)
            If resEch.Rows.Count > 0 Then lbl_echantillon.Text = "Nombre total d'échantillons distribués : " & resEch.Rows(0)(0).ToString()

            Dim sqlPrat As String = "SELECT P.NOM as ""Praticien"", TO_CHAR(MAX(CR.DATE_VISITE), 'DD/MM/YYYY') as ""Dernière Visite"", " &
                                   "COUNT(CR.ID_COMPTE_RENDU) as ""Total Visites"", ROUND(AVG(P.COEF_CONFIANCE), 1) as ""Moy. Confiance"" " &
                                   "FROM COMPTE_RENDU CR JOIN PRATICIEN P ON CR.ID_PRATICIEN = P.ID_PRATICIEN " &
                                   $"WHERE CR.ID_USER = {Login.IdUtilisateur} {conditionAnnee} GROUP BY P.NOM"
            Tableau_Synthese_Praticiens.DataSource = Conn.getData(sqlPrat)

            Dim sqlActivite As String = "SELECT M.LBL_MOTIF as ""Motif"", COUNT(CR.ID_COMPTE_RENDU) as ""Nombre"" " &
                                       "FROM COMPTE_RENDU CR JOIN MOTIF_VISITE M ON CR.MOTIF_VISITE = M.ID_MOTIF " &
                                       $"WHERE CR.ID_USER = {Login.IdUtilisateur} {conditionAnnee} GROUP BY M.LBL_MOTIF"
            Tableau_Activite.DataSource = Conn.getData(sqlActivite)

        Catch ex As Exception
        End Try
    End Sub

End Class