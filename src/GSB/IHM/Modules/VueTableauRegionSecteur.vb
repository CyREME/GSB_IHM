Imports Oracle.ManagedDataAccess.Client

Public Class VueTableauRegionSecteur

    Public ModeActuel As String = "Regions"

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
            If ModeActuel = "Regions" Then
                sql = "SELECT r.Lbl_Region AS ""Région"", s.Lbl_Secteur AS ""Secteur"" " &
                      "FROM Region r JOIN Secteur s ON r.ID_Region = s.ID_Region"

            ElseIf ModeActuel = "Delegues" Then
                ' ---> MODIFIÉ : On cherche les Délégués qui appartiennent au Responsable connecté
                sql = "SELECT ID_User AS ""ID"", Nom, Prenom " &
                      "FROM Utilisateur WHERE Role = 'Delegue' AND ID_SECTEUR_RESP = " & Login.IdUtilisateur

            ElseIf ModeActuel = "Visiteurs" Then
                If Liste_Delegues.Visible AndAlso Liste_Visiteurs.Visible Then
                    If Liste_Visiteurs.SelectedValue IsNot Nothing Then
                        sql = "SELECT Nom, Prenom, Matricule, Date_Embauche, Budget " &
                              "FROM Utilisateur WHERE Role = 'Visiteur' AND ID_User = " & Liste_Visiteurs.SelectedValue.ToString()
                    End If

                ElseIf Liste_Delegues.Visible AndAlso Not Liste_Visiteurs.Visible Then
                    If Liste_Delegues.SelectedValue IsNot Nothing Then
                        ' Ici on affiche tous les visiteurs du délégué sélectionné
                        sql = "SELECT ID_User AS ""ID"", Nom, Prenom, Identite " &
                              "FROM Utilisateur WHERE Role = 'Visiteur' AND ID_Delegue = " & Liste_Delegues.SelectedValue.ToString()
                    End If
                End If
            End If

            If Not String.IsNullOrEmpty(sql) Then
                Dim dt As DataTable = Conn.getData(sql)
                Tab.DataSource = dt
                Tab.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Else
                Tab.DataSource = Nothing
            End If

        Catch ex As Exception
        End Try
    End Sub

    ' ---------------------------------------------------------
    ' MÉTHODES DE REMPLISSAGE DES COMBOBOX (Les listes)
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

        ' Dès que la liste des délégués est chargée, on force le chargement des visiteurs 
        ' du tout premier délégué de la liste (s'il y en a au moins un)
        If Liste_Delegues.Items.Count > 0 Then
            ChargerListeVisiteurs(Convert.ToInt32(Liste_Delegues.SelectedValue))
            ActualiserTableau() ' On met à jour le tableau central
        End If
    End Sub

    Public Sub ChargerListeVisiteurs(idDelegue As Integer)
        ' On remplit la 2ème liste avec les visiteurs du Délégué choisi
        Dim sql As String = "SELECT ID_USER, NOM || ' ' || PRENOM AS NOMCOMPLET " &
                            "FROM UTILISATEUR WHERE ROLE = 'Visiteur' AND ID_DELEGUE = " & idDelegue.ToString()

        Dim dt As DataTable = Conn.getData(sql)

        RemoveHandler Liste_Visiteurs.SelectedIndexChanged, AddressOf Liste_Visiteurs_SelectedIndexChanged

        Liste_Visiteurs.DataSource = dt
        Liste_Visiteurs.DisplayMember = "NOMCOMPLET"
        Liste_Visiteurs.ValueMember = "ID_USER"

        AddHandler Liste_Visiteurs.SelectedIndexChanged, AddressOf Liste_Visiteurs_SelectedIndexChanged
    End Sub

End Class