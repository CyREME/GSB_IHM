Imports System.Data

Public Class journalSession

    ' Cette variable permet de savoir si on affiche le DETAIL ou le CUMUL
    Public Property ModeActuel As String = "DETAIL"

    Private Sub journalSession_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AppliquerStyleTableau(TabPrincipal)
        ActualiserDonnees()
    End Sub

    Private Sub AppliquerStyleTableau(dgv As DataGridView)
        dgv.EnableHeadersVisualStyles = False
        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(83, 175, 255)
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 10, FontStyle.Bold)
        dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(240, 245, 250)
        dgv.DefaultCellStyle.SelectionForeColor = Color.Black
        dgv.GridColor = Color.FromArgb(230, 230, 230)
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
    End Sub

    Public Sub ActualiserDonnees()
        Try
            Dim filtre As String = txt_recherche.Text.Replace("'", "''")
            Dim sql As String = ""

            If ModeActuel = "DETAIL" Then
                ' --- MODE 1 : HISTORIQUE DETAILLE ---
                Me.lbl_titre.Text = "Historique détaillé des sessions"
                sql = "SELECT * FROM VIEW_JOURNAL_CONNEXIONS"
                If Not String.IsNullOrEmpty(filtre) Then
                    sql &= $" WHERE NOM LIKE '%{filtre}%' OR PRENOM LIKE '%{filtre}%' OR LOGIN_UTILISATEUR LIKE '%{filtre}%'"
                End If

                Dim dt As DataTable = Conn.getData(sql)
                TabPrincipal.DataSource = dt

                If dt IsNot Nothing Then
                    TabPrincipal.Columns("ID_LOG").HeaderText = "N° Session"
                    TabPrincipal.Columns("LOGIN_UTILISATEUR").HeaderText = "Login"
                    TabPrincipal.Columns("NOM").HeaderText = "Nom"
                    TabPrincipal.Columns("PRENOM").HeaderText = "Prénom"
                    TabPrincipal.Columns("DATE_DEBUT").HeaderText = "Connecté le"
                    TabPrincipal.Columns("DUREE_SESSION").HeaderText = "Durée"
                End If

            Else
                ' --- MODE 2 : CUMUL PAR UTILISATEUR ---
                Me.lbl_titre.Text = "Temps total par utilisateur"
                sql = "SELECT * FROM VIEW_CUMUL_DUREE_UTILISATEURS"
                If Not String.IsNullOrEmpty(filtre) Then
                    sql &= $" WHERE NOM LIKE '%{filtre}%' OR PRENOM LIKE '%{filtre}%'"
                End If

                Dim dt As DataTable = Conn.getData(sql)
                TabPrincipal.DataSource = dt

                If dt IsNot Nothing Then
                    TabPrincipal.Columns("ID_USER").HeaderText = "ID"
                    TabPrincipal.Columns("NOM").HeaderText = "Nom"
                    TabPrincipal.Columns("PRENOM").HeaderText = "Prénom"
                    TabPrincipal.Columns("NB_SESSIONS").HeaderText = "Nb Sessions"
                    TabPrincipal.Columns("TEMPS_TOTAL_SESSION").HeaderText = "Durée Totale Cumulée"
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txt_recherche_TextChanged(sender As Object, e As EventArgs) Handles txt_recherche.TextChanged
        ActualiserDonnees()
    End Sub

    Private Sub btn_purger_Click(sender As Object, e As EventArgs) Handles btn_purger.Click
        If MessageBox.Show("Purger tout l'historique ?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Conn.setData("DELETE FROM LOG_SESSIONS")
            ActualiserDonnees()
        End If
    End Sub
End Class