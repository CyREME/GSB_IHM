<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Responsable
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
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
        Panel1.BackColor = Color.FromArgb(CByte(69), CByte(149), CByte(217))
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(btn_Visiteurs)
        Panel1.Controls.Add(btn_Regions)
        Panel1.Controls.Add(btn_Secteur)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 60)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.MaximumSize = New Size(250, 573)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(250, 573)
        Panel1.TabIndex = 2
        ' 
        ' btn_Visiteurs
        ' 
        btn_Visiteurs.Anchor = AnchorStyles.Top
        btn_Visiteurs.BackColor = Color.White
        btn_Visiteurs.BackgroundImageLayout = ImageLayout.Stretch
        btn_Visiteurs.Font = New Font("Spline Sans Mono", 18F)
        btn_Visiteurs.ForeColor = Color.Black
        btn_Visiteurs.ImageAlign = ContentAlignment.TopCenter
        btn_Visiteurs.Location = New Point(9, 270)
        btn_Visiteurs.Name = "btn_Visiteurs"
        btn_Visiteurs.Size = New Size(230, 40)
        btn_Visiteurs.TabIndex = 3
        btn_Visiteurs.Text = "Visiteur"
        btn_Visiteurs.TextAlign = ContentAlignment.TopCenter
        btn_Visiteurs.UseVisualStyleBackColor = False
        ' 
        ' btn_Regions
        ' 
        btn_Regions.Anchor = AnchorStyles.Top
        btn_Regions.BackColor = Color.White
        btn_Regions.BackgroundImageLayout = ImageLayout.Stretch
        btn_Regions.Font = New Font("Spline Sans Mono", 18F)
        btn_Regions.ForeColor = Color.Black
        btn_Regions.ImageAlign = ContentAlignment.TopCenter
        btn_Regions.Location = New Point(9, 160)
        btn_Regions.Name = "btn_Regions"
        btn_Regions.Size = New Size(230, 40)
        btn_Regions.TabIndex = 3
        btn_Regions.Text = "Régions"
        btn_Regions.TextAlign = ContentAlignment.TopCenter
        btn_Regions.UseVisualStyleBackColor = False
        ' 
        ' btn_Secteur
        ' 
        btn_Secteur.Anchor = AnchorStyles.Top
        btn_Secteur.BackColor = Color.White
        btn_Secteur.BackgroundImageLayout = ImageLayout.Stretch
        btn_Secteur.FlatAppearance.BorderSize = 0
        btn_Secteur.Font = New Font("Spline Sans Mono", 18F)
        btn_Secteur.ForeColor = Color.Black
        btn_Secteur.ImageAlign = ContentAlignment.TopCenter
        btn_Secteur.Location = New Point(9, 50)
        btn_Secteur.Name = "btn_Secteur"
        btn_Secteur.Size = New Size(230, 40)
        btn_Secteur.TabIndex = 3
        btn_Secteur.Text = "Secteur"
        btn_Secteur.TextAlign = ContentAlignment.TopCenter
        btn_Secteur.UseVisualStyleBackColor = False
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.FromArgb(CByte(81), CByte(175), CByte(255))
        PanelHeader.BackgroundImageLayout = ImageLayout.None
        PanelHeader.Controls.Add(btn_exit_Panel)
        PanelHeader.Controls.Add(btn_logout_Panel)
        PanelHeader.Controls.Add(lbl_nom)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(1069, 60)
        PanelHeader.TabIndex = 1
        ' 
        ' btn_exit_Panel
        ' 
        btn_exit_Panel.Location = New Point(1018, 10)
        btn_exit_Panel.Name = "btn_exit_Panel"
        btn_exit_Panel.Size = New Size(40, 40)
        btn_exit_Panel.TabIndex = 8
        ' 
        ' btn_logout_Panel
        ' 
        btn_logout_Panel.Location = New Point(836, 10)
        btn_logout_Panel.Name = "btn_logout_Panel"
        btn_logout_Panel.Size = New Size(163, 40)
        btn_logout_Panel.TabIndex = 7
        ' 
        ' lbl_nom
        ' 
        lbl_nom.Dock = DockStyle.Left
        lbl_nom.Font = New Font("Spline Sans Mono", 26F)
        lbl_nom.Location = New Point(0, 0)
        lbl_nom.Margin = New Padding(4, 0, 4, 0)
        lbl_nom.Name = "lbl_nom"
        lbl_nom.Size = New Size(644, 60)
        lbl_nom.TabIndex = 6
        lbl_nom.Text = "NOM / PRENOM RESPONSABLE"
        lbl_nom.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PanelAffichage
        ' 
        PanelAffichage.Dock = DockStyle.Fill
        PanelAffichage.Location = New Point(250, 60)
        PanelAffichage.Name = "PanelAffichage"
        PanelAffichage.Size = New Size(819, 573)
        PanelAffichage.TabIndex = 3
        ' 
        ' Responsable
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1069, 633)
        Controls.Add(PanelAffichage)
        Controls.Add(Panel1)
        Controls.Add(PanelHeader)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 3, 4, 3)
        Name = "Responsable"
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
