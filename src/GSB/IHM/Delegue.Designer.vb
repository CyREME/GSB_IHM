<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Delegue
    Inherits System.Windows.Forms.Form

    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    Private components As System.ComponentModel.IContainer

    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Panel1 = New Panel()
        btn_Historique_Visites = New Button()
        btn_Compte_Rendue = New Button()
        btn_Visiteurs = New Button()
        btn_Regions = New Button()
        PanelHeader = New Panel()
        btn_exit_Panel = New Panel()
        btn_logout_Panel = New Panel()
        lbl_nom = New Label()
        PanelAffichage = New Panel()
        Panel1.SuspendLayout()
        PanelHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(45), CByte(52), CByte(70))
        Panel1.Controls.Add(btn_Historique_Visites)
        Panel1.Controls.Add(btn_Compte_Rendue)
        Panel1.Controls.Add(btn_Visiteurs)
        Panel1.Controls.Add(btn_Regions)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(0, 80, 0, 0)
        Panel1.Size = New Size(250, 633)
        Panel1.TabIndex = 6
        ' 
        ' btn_Regions
        ' 
        btn_Regions.Cursor = Cursors.Hand
        btn_Regions.Dock = DockStyle.Top
        btn_Regions.FlatAppearance.BorderSize = 0
        btn_Regions.FlatStyle = FlatStyle.Flat
        btn_Regions.Font = New Font("Segoe UI", 12.0F)
        btn_Regions.ForeColor = Color.White
        btn_Regions.Location = New Point(0, 80)
        btn_Regions.Name = "btn_Regions"
        btn_Regions.Size = New Size(250, 50)
        btn_Regions.TabIndex = 3
        btn_Regions.Text = "  Vue Région"
        btn_Regions.TextAlign = ContentAlignment.MiddleLeft
        btn_Regions.UseVisualStyleBackColor = True
        ' 
        ' btn_Visiteurs
        ' 
        btn_Visiteurs.Cursor = Cursors.Hand
        btn_Visiteurs.Dock = DockStyle.Top
        btn_Visiteurs.FlatAppearance.BorderSize = 0
        btn_Visiteurs.FlatStyle = FlatStyle.Flat
        btn_Visiteurs.Font = New Font("Segoe UI", 12.0F)
        btn_Visiteurs.ForeColor = Color.White
        btn_Visiteurs.Location = New Point(0, 130)
        btn_Visiteurs.Name = "btn_Visiteurs"
        btn_Visiteurs.Size = New Size(250, 50)
        btn_Visiteurs.TabIndex = 3
        btn_Visiteurs.Text = "  Équipe Visiteurs"
        btn_Visiteurs.TextAlign = ContentAlignment.MiddleLeft
        btn_Visiteurs.UseVisualStyleBackColor = True
        ' 
        ' btn_Compte_Rendue
        ' 
        btn_Compte_Rendue.Cursor = Cursors.Hand
        btn_Compte_Rendue.Dock = DockStyle.Top
        btn_Compte_Rendue.FlatAppearance.BorderSize = 0
        btn_Compte_Rendue.FlatStyle = FlatStyle.Flat
        btn_Compte_Rendue.Font = New Font("Segoe UI", 12.0F)
        btn_Compte_Rendue.ForeColor = Color.White
        btn_Compte_Rendue.Location = New Point(0, 180)
        btn_Compte_Rendue.Name = "btn_Compte_Rendue"
        btn_Compte_Rendue.Size = New Size(250, 50)
        btn_Compte_Rendue.TabIndex = 3
        btn_Compte_Rendue.Text = "  Saisir un Compte-Rendu"
        btn_Compte_Rendue.TextAlign = ContentAlignment.MiddleLeft
        btn_Compte_Rendue.UseVisualStyleBackColor = True
        ' 
        ' btn_Historique_Visites
        ' 
        btn_Historique_Visites.Cursor = Cursors.Hand
        btn_Historique_Visites.Dock = DockStyle.Top
        btn_Historique_Visites.FlatAppearance.BorderSize = 0
        btn_Historique_Visites.FlatStyle = FlatStyle.Flat
        btn_Historique_Visites.Font = New Font("Segoe UI", 12.0F)
        btn_Historique_Visites.ForeColor = Color.White
        btn_Historique_Visites.Location = New Point(0, 230)
        btn_Historique_Visites.Name = "btn_Historique_Visites"
        btn_Historique_Visites.Size = New Size(250, 50)
        btn_Historique_Visites.TabIndex = 4
        btn_Historique_Visites.Text = "  Historique des Visites"
        btn_Historique_Visites.TextAlign = ContentAlignment.MiddleLeft
        btn_Historique_Visites.UseVisualStyleBackColor = True
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.White
        PanelHeader.Controls.Add(btn_exit_Panel)
        PanelHeader.Controls.Add(btn_logout_Panel)
        PanelHeader.Controls.Add(lbl_nom)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(250, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(819, 60)
        PanelHeader.TabIndex = 7
        ' 
        ' btn_exit_Panel
        ' 
<<<<<<< HEAD
        btn_exit_Panel.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btn_exit_Panel.Location = New Point(767, 10)
=======
        btn_exit_Panel.Location = New Point(1017, 12)
>>>>>>> e8681ec723fb5e285a95e6b69690cbbaf2d4e883
        btn_exit_Panel.Name = "btn_exit_Panel"
        btn_exit_Panel.Size = New Size(40, 40)
        btn_exit_Panel.TabIndex = 12
        ' 
        ' btn_logout_Panel
        ' 
<<<<<<< HEAD
        btn_logout_Panel.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btn_logout_Panel.Location = New Point(598, 10)
=======
        btn_logout_Panel.Location = New Point(835, 12)
>>>>>>> e8681ec723fb5e285a95e6b69690cbbaf2d4e883
        btn_logout_Panel.Name = "btn_logout_Panel"
        btn_logout_Panel.Size = New Size(163, 40)
        btn_logout_Panel.TabIndex = 11
        ' 
        ' lbl_nom
        ' 
        lbl_nom.Dock = DockStyle.Left
<<<<<<< HEAD
        lbl_nom.Font = New Font("Segoe UI Semibold", 18.0F, FontStyle.Bold)
        lbl_nom.ForeColor = Color.FromArgb(CByte(45), CByte(52), CByte(70))
        lbl_nom.Location = New Point(0, 0)
        lbl_nom.Name = "lbl_nom"
        lbl_nom.Padding = New Padding(20, 0, 0, 0)
        lbl_nom.Size = New Size(591, 60)
        lbl_nom.TabIndex = 4
        lbl_nom.Text = "NOM / PRENOM DELEGUE"
        lbl_nom.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' PanelAffichage
        ' 
        PanelAffichage.BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
=======
        lbl_nom.Font = New Font("Spline Sans Mono", 26F)
        lbl_nom.Location = New Point(0, 0)
        lbl_nom.Margin = New Padding(4, 0, 4, 0)
        lbl_nom.Name = "lbl_nom"
        lbl_nom.Size = New Size(644, 60)
        lbl_nom.TabIndex = 4
        lbl_nom.Text = "NOM / PRENOM DELEGUE"
        lbl_nom.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PanelAffichage
        ' 
>>>>>>> e8681ec723fb5e285a95e6b69690cbbaf2d4e883
        PanelAffichage.Dock = DockStyle.Fill
        PanelAffichage.Location = New Point(250, 60)
        PanelAffichage.Name = "PanelAffichage"
        PanelAffichage.Size = New Size(819, 573)
        PanelAffichage.TabIndex = 8
        ' 
        ' Delegue
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1069, 633)
        Controls.Add(PanelAffichage)
        Controls.Add(PanelHeader)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Delegue"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Delegue"
        Panel1.ResumeLayout(False)
        PanelHeader.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_Visiteurs As Button
    Friend WithEvents btn_Regions As Button
    Friend WithEvents btn_Compte_Rendue As Button
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents lbl_nom As Label
    Friend WithEvents btn_Historique_Visites As Button
    Friend WithEvents PanelAffichage As Panel
    Friend WithEvents btn_exit_Panel As Panel
    Friend WithEvents btn_logout_Panel As Panel
End Class