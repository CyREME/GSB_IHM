Public Class Responsable

    Private colorBtnSelect As Color = Color.FromArgb(83, 175, 255)

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

End Class