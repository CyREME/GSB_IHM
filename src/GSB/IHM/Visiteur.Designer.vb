<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Visiteur
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
        PanelHeader = New Panel()
        btn_exit_Panel = New Panel()
        btn_logout_Panel = New Panel()
        lbl_nom = New Label()
        Panel2 = New Panel()
        btn_Historique_Visites = New Button()
        btn_Vision_Synthese = New Button()
        btn_Compte_Rendu = New Button()
        PanelAffichage = New Panel()
        PanelHeader.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
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
        PanelHeader.TabIndex = 1
        ' 
        ' btn_exit_Panel
        ' 
        btn_exit_Panel.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btn_exit_Panel.Location = New Point(767, 10)
        btn_exit_Panel.Name = "btn_exit_Panel"
        btn_exit_Panel.Size = New Size(40, 40)
        btn_exit_Panel.TabIndex = 10
        ' 
        ' btn_logout_Panel
        ' 
        btn_logout_Panel.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btn_logout_Panel.Location = New Point(598, 10)
        btn_logout_Panel.Name = "btn_logout_Panel"
        btn_logout_Panel.Size = New Size(163, 40)
        btn_logout_Panel.TabIndex = 9
        ' 
        ' lbl_nom
        ' 
        lbl_nom.Dock = DockStyle.Left
        lbl_nom.Font = New Font("Segoe UI Semibold", 18.0F, FontStyle.Bold)
        lbl_nom.ForeColor = Color.FromArgb(CByte(45), CByte(52), CByte(70))
        lbl_nom.Location = New Point(0, 0)
        lbl_nom.Margin = New Padding(4, 0, 4, 0)
        lbl_nom.Name = "lbl_nom"
        lbl_nom.Padding = New Padding(20, 0, 0, 0)
        lbl_nom.Size = New Size(591, 60)
        lbl_nom.TabIndex = 6
        lbl_nom.Text = "NOM / PRENOM VISITEUR"
        lbl_nom.TextAlign = ContentAlignment.MiddleLeft
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(45), CByte(52), CByte(70))
        Panel2.Controls.Add(btn_Historique_Visites)
        Panel2.Controls.Add(btn_Vision_Synthese)
        Panel2.Controls.Add(btn_Compte_Rendu)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Padding = New Padding(0, 80, 0, 0)
        Panel2.Size = New Size(250, 633)
        Panel2.TabIndex = 2
        ' 
        ' btn_Compte_Rendu
        ' 
        btn_Compte_Rendu.Cursor = Cursors.Hand
        btn_Compte_Rendu.Dock = DockStyle.Top
        btn_Compte_Rendu.FlatAppearance.BorderSize = 0
        btn_Compte_Rendu.FlatStyle = FlatStyle.Flat
        btn_Compte_Rendu.Font = New Font("Segoe UI", 12.0F)
        btn_Compte_Rendu.ForeColor = Color.White
        btn_Compte_Rendu.Location = New Point(0, 80)
        btn_Compte_Rendu.Name = "btn_Compte_Rendu"
        btn_Compte_Rendu.Size = New Size(250, 50)
        btn_Compte_Rendu.TabIndex = 8
        btn_Compte_Rendu.Text = "  Compte Rendu"
        btn_Compte_Rendu.TextAlign = ContentAlignment.MiddleLeft
        btn_Compte_Rendu.UseVisualStyleBackColor = True
        ' 
        ' btn_Historique_Visites
        ' 
        btn_Historique_Visites.Cursor = Cursors.Hand
        btn_Historique_Visites.Dock = DockStyle.Top
        btn_Historique_Visites.FlatAppearance.BorderSize = 0
        btn_Historique_Visites.FlatStyle = FlatStyle.Flat
        btn_Historique_Visites.Font = New Font("Segoe UI", 12.0F)
        btn_Historique_Visites.ForeColor = Color.White
        btn_Historique_Visites.Location = New Point(0, 130)
        btn_Historique_Visites.Name = "btn_Historique_Visites"
        btn_Historique_Visites.Size = New Size(250, 50)
        btn_Historique_Visites.TabIndex = 9
        btn_Historique_Visites.Text = "  Historique Visites"
        btn_Historique_Visites.TextAlign = ContentAlignment.MiddleLeft
        btn_Historique_Visites.UseVisualStyleBackColor = True
        ' 
        ' btn_Vision_Synthese
        ' 
        btn_Vision_Synthese.Cursor = Cursors.Hand
        btn_Vision_Synthese.Dock = DockStyle.Top
        btn_Vision_Synthese.FlatAppearance.BorderSize = 0
        btn_Vision_Synthese.FlatStyle = FlatStyle.Flat
        btn_Vision_Synthese.Font = New Font("Segoe UI", 12.0F)
        btn_Vision_Synthese.ForeColor = Color.White
        btn_Vision_Synthese.Location = New Point(0, 180)
        btn_Vision_Synthese.Name = "btn_Vision_Synthese"
        btn_Vision_Synthese.Size = New Size(250, 50)
        btn_Vision_Synthese.TabIndex = 10
        btn_Vision_Synthese.Text = "  Vision Synthétique"
        btn_Vision_Synthese.TextAlign = ContentAlignment.MiddleLeft
        btn_Vision_Synthese.UseVisualStyleBackColor = True
        ' 
        ' PanelAffichage
        ' 
        PanelAffichage.BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
        PanelAffichage.Dock = DockStyle.Fill
        PanelAffichage.Location = New Point(250, 60)
        PanelAffichage.Name = "PanelAffichage"
        PanelAffichage.Size = New Size(819, 573)
        PanelAffichage.TabIndex = 3
        ' 
        ' Visiteur
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1069, 633)
        Controls.Add(PanelAffichage)
        Controls.Add(PanelHeader)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Visiteur"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Visiteur"
        PanelHeader.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_Vision_Synthese As Button
    Friend WithEvents btn_Historique_Visites As Button
    Friend WithEvents btn_Compte_Rendu As Button
    Friend WithEvents lbl_nom As Label
    Friend WithEvents PanelAffichage As Panel
    Friend WithEvents btn_exit_Panel As Panel
    Friend WithEvents btn_logout_Panel As Panel
End Class