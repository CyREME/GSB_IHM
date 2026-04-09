Imports System.Windows.Forms
Imports System.Data
Imports Oracle.ManagedDataAccess.Client

Public Class VueEquipeVisiteurs

    Private Sub VueEquipeVisiteurs_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AppliquerStyleTableaux(Tab)
        ChargerAnnees()
    End Sub

    ' --- STYLE DU TABLEAU ---
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

    ' ---------------------------------------------------------
    ' 1. CHARGER LES ANNÉES
    ' ---------------------------------------------------------
    Public Sub ChargerAnnees()
        Try
            ' On cherche les années d'activité de l'équipe de CE délégué
            Dim sql As String = "SELECT DISTINCT TO_CHAR(CR.DATE_VISITE, 'YYYY') AS ANNEE " &
                                "FROM COMPTE_RENDU CR " &
                                "JOIN UTILISATEUR V ON CR.ID_USER = V.ID_USER " &
                                "WHERE V.ROLE = 'Visiteur' AND V.ID_DELEGUE = " & Login.IdUtilisateur & " " &
                                "ORDER BY ANNEE DESC"

            Dim dt As DataTable = Conn.getData(sql)

            RemoveHandler Liste_Annee.SelectedIndexChanged, AddressOf Liste_Annee_SelectedIndexChanged
            Liste_Annee.DataSource = dt
            Liste_Annee.DisplayMember = "ANNEE"
            Liste_Annee.ValueMember = "ANNEE"
            AddHandler Liste_Annee.SelectedIndexChanged, AddressOf Liste_Annee_SelectedIndexChanged

            If Liste_Annee.Items.Count > 0 Then
                Liste_Annee.SelectedIndex = 0
                ActualiserTableau()
            Else
                Tab.DataSource = Nothing
            End If

        Catch ex As Exception
            MessageBox.Show("Erreur lors du chargement des années : " & ex.Message, "Erreur SQL", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Liste_Annee_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Liste_Annee.SelectedIndexChanged
        ActualiserTableau()
    End Sub

    ' ---------------------------------------------------------
    ' 2. METTRE À JOUR LE TABLEAU DES VISITEURS
    ' ---------------------------------------------------------
    Public Sub ActualiserTableau()
        If Liste_Annee.SelectedValue Is Nothing Then Return

        Dim anneeChoisie As String = Liste_Annee.SelectedValue.ToString()

        Try
            Tab.DataSource = Nothing
            Tab.Columns.Clear()

            ' On liste chaque visiteur de l'équipe et ses statistiques
            Dim sql As String = "SELECT V.ID_USER AS ""ID"", " &
                                "V.NOM || ' ' || V.PRENOM AS ""Visiteur"", " &
                                "COUNT(DISTINCT CR.ID_COMPTE_RENDU) AS ""Total Visites"", " &
                                "NVL(SUM(E.QUANTITE), 0) AS ""Total Échantillons"", " &
                                "ROUND(AVG(P.COEF_CONFIANCE), 2) AS ""Moyenne Confiance"", " &
                                "TO_CHAR(MAX(CR.DATE_VISITE), 'DD/MM/YYYY') AS ""Dernière Visite"" " &
                                "FROM UTILISATEUR V " &
                                "LEFT JOIN COMPTE_RENDU CR ON V.ID_USER = CR.ID_USER AND TO_CHAR(CR.DATE_VISITE, 'YYYY') = '" & anneeChoisie & "' " &
                                "LEFT JOIN ECHANTILLON E ON CR.ID_COMPTE_RENDU = E.ID_COMPTE_RENDU " &
                                "LEFT JOIN PRATICIEN P ON CR.ID_PRATICIEN = P.ID_PRATICIEN " &
                                "WHERE V.ROLE = 'Visiteur' AND V.ID_DELEGUE = " & Login.IdUtilisateur & " " &
                                "GROUP BY V.ID_USER, V.NOM, V.PRENOM " &
                                "ORDER BY V.NOM"

            Dim dt As DataTable = Conn.getData(sql)

            If dt IsNot Nothing Then
                Tab.DataSource = dt

                ' On cache l'ID, il n'est pas utile à l'affichage
                If Tab.Columns.Contains("ID") Then
                    Tab.Columns("ID").Visible = False
                End If

                Tab.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
                Tab.ReadOnly = True
                Tab.AllowUserToAddRows = False
                Tab.AllowUserToDeleteRows = False
                Tab.SelectionMode = DataGridViewSelectionMode.FullRowSelect
            End If

        Catch ex As Exception
        End Try
    End Sub

End Class