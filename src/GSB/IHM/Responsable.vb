Public Class Responsable

    Private Property MoveForm As Boolean
    Private Property MoveForm_MousePosition As Point
    Private Property MoveForm_Position As Point
    Private colorBtnSelect As Color = Color.FromArgb(83, 175, 255)




    '' Ici c'est pour pouvoir déplacer la fenêtre en cliquant sur le panel du haut ou le label Login
    Private Sub PanelHeader_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelHeader.MouseDown, lbl_nom.MouseDown
        MoveForm = True
        MoveForm_MousePosition = Cursor.Position
        MoveForm_Position = Location
    End Sub

    Private Sub PanelHeader_MouseMove(sender As Object, e As MouseEventArgs) Handles PanelHeader.MouseMove, lbl_nom.MouseUp, lbl_nom.MouseMove
        If MoveForm Then
            Dim dif = New Point(Cursor.Position.X - MoveForm_MousePosition.X, Cursor.Position.Y - MoveForm_MousePosition.Y)
            Location = New Point(MoveForm_Position.X + dif.X, MoveForm_Position.Y + dif.Y)
        End If
    End Sub

    Private Sub PanelHeader_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelHeader.MouseUp, lbl_nom.MouseUp
        MoveForm = False
    End Sub









    Private Sub Responsable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl_Delegue.Visible = False
        Liste_Delegues.Visible = False

        lbl_Visiteur.Visible = False
        Liste_Visiteurs.Visible = False

        btn_Secteur.BackColor = colorBtnSelect
        btn_Secteur.ForeColor = Color.FromArgb(255, 255, 255)

        btn_Regions.BackColor = Color.FromArgb(255, 255, 255)
        btn_Regions.ForeColor = Color.FromArgb(0, 0, 0)

        btn_Visiteurs.BackColor = Color.FromArgb(255, 255, 255)
        btn_Visiteurs.ForeColor = Color.FromArgb(0, 0, 0)

    End Sub



    Private Sub btn_Secteur_Click(sender As Object, e As EventArgs) Handles btn_Secteur.Click
        lbl_Delegue.Visible = False
        Liste_Delegues.Visible = False

        lbl_Visiteur.Visible = False
        Liste_Visiteurs.Visible = False

        btn_Secteur.BackColor = colorBtnSelect
        btn_Secteur.ForeColor = Color.FromArgb(255, 255, 255)

        btn_Regions.BackColor = Color.FromArgb(255, 255, 255)
        btn_Regions.ForeColor = Color.FromArgb(0, 0, 0)

        btn_Visiteurs.BackColor = Color.FromArgb(255, 255, 255)
        btn_Visiteurs.ForeColor = Color.FromArgb(0, 0, 0)
    End Sub



    Private Sub btn_Regions_Click(sender As Object, e As EventArgs) Handles btn_Regions.Click
        lbl_Delegue.Visible = True
        Liste_Delegues.Visible = True

        lbl_Visiteur.Visible = False
        Liste_Visiteurs.Visible = False

        btn_Secteur.BackColor = Color.FromArgb(255, 255, 255)
        btn_Secteur.ForeColor = Color.FromArgb(0, 0, 0)

        btn_Regions.BackColor = colorBtnSelect
        btn_Regions.ForeColor = Color.FromArgb(255, 255, 255)

        btn_Visiteurs.BackColor = Color.FromArgb(255, 255, 255)
        btn_Visiteurs.ForeColor = Color.FromArgb(0, 0, 0)
    End Sub



    Private Sub btn_Visiteurs_Click(sender As Object, e As EventArgs) Handles btn_Visiteurs.Click
        lbl_Delegue.Visible = True
        Liste_Delegues.Visible = True

        lbl_Visiteur.Visible = True
        Liste_Visiteurs.Visible = True

        btn_Secteur.BackColor = Color.FromArgb(255, 255, 255)
        btn_Secteur.ForeColor = Color.FromArgb(0, 0, 0)

        btn_Regions.BackColor = Color.FromArgb(255, 255, 255)
        btn_Regions.ForeColor = Color.FromArgb(0, 0, 0)

        btn_Visiteurs.BackColor = colorBtnSelect
        btn_Visiteurs.ForeColor = Color.FromArgb(255, 255, 255)
    End Sub



    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles btn_exit.Click
        Me.Close()
    End Sub

    Private Sub btn_Deconnexion_Click(sender As Object, e As EventArgs) Handles btn_Deconnexion.Click

    End Sub
End Class