<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Responsable
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
        btn_Visiteurs = New Button()
        btn_Regions = New Button()
        btn_Secteur = New Button()
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
        Panel1.Controls.Add(btn_Visiteurs)
        Panel1.Controls.Add(btn_Regions)
        Panel1.Controls.Add(btn_Secteur)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Padding = New Padding(0, 80, 0, 0)
        Panel1.Size = New Size(250, 633)
        Panel1.TabIndex = 2
        ' 
        ' btn_Secteur
        ' 
        btn_Secteur.Cursor = Cursors.Hand
        btn_Secteur.Dock = DockStyle.Top
        btn_Secteur.FlatAppearance.BorderSize = 0
        btn_Secteur.FlatStyle = FlatStyle.Flat
        btn_Secteur.Font = New Font("Segoe UI", 12.0F)
        btn_Secteur.ForeColor = Color.White
        btn_Secteur.Location = New Point(0, 80)
        btn_Secteur.Name = "btn_Secteur"
        btn_Secteur.Size = New Size(250, 50)
        btn_Secteur.TabIndex = 3
        btn_Secteur.Text = "  Vue Secteur"
        btn_Secteur.TextAlign = ContentAlignment.MiddleLeft
        btn_Secteur.UseVisualStyleBackColor = True
        ' 
        ' btn_Regions
        ' 
        btn_Regions.Cursor = Cursors.Hand
        btn_Regions.Dock = DockStyle.Top
        btn_Regions.FlatAppearance.BorderSize = 0
        btn_Regions.FlatStyle = FlatStyle.Flat
        btn_Regions.Font = New Font("Segoe UI", 12.0F)
        btn_Regions.ForeColor = Color.White
        btn_Regions.Location = New Point(0, 130)
        btn_Regions.Name = "btn_Regions"
        btn_Regions.Size = New Size(250, 50)
        btn_Regions.TabIndex = 4
        btn_Regions.Text = "  Vue Régions"
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
        btn_Visiteurs.Location = New Point(0, 180)
        btn_Visiteurs.Name = "btn_Visiteurs"
        btn_Visiteurs.Size = New Size(250, 50)
        btn_Visiteurs.TabIndex = 5
        btn_Visiteurs.Text = "  Vue Visiteurs"
        btn_Visiteurs.TextAlign = ContentAlignment.MiddleLeft
        btn_Visiteurs.UseVisualStyleBackColor = True
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
        btn_exit_Panel.TabIndex = 8
        ' 
        ' btn_logout_Panel
        ' 
        btn_logout_Panel.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btn_logout_Panel.Location = New Point(598, 10)
        btn_logout_Panel.Name = "btn_logout_Panel"
        btn_logout_Panel.Size = New Size(163, 40)
        btn_logout_Panel.TabIndex = 7
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
        lbl_nom.Text = "NOM / PRENOM RESPONSABLE"
        lbl_nom.TextAlign = ContentAlignment.MiddleLeft
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
        ' Responsable
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1069, 633)
        Controls.Add(PanelAffichage)
        Controls.Add(PanelHeader)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Responsable"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Responsable"
        Panel1.ResumeLayout(False)
        PanelHeader.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents lbl_nom As Label
    Friend WithEvents btn_Visiteurs As Button
    Friend WithEvents btn_Regions As Button
    Friend WithEvents btn_Secteur As Button
    Friend WithEvents PanelAffichage As Panel
    Friend WithEvents btn_logout_Panel As Panel
    Friend WithEvents btn_exit_Panel As Panel
End Class