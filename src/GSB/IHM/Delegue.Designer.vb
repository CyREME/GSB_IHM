<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Delegue
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
        btn_Historique_Visites = New Button()
        btn_Visiteurs = New Button()
        btn_Regions = New Button()
        btn_Compte_Rendue = New Button()
        Tableau = New DataGridView()
        PanelHeader = New Panel()
        lbl_nom = New Label()
        btn_Deconnexion = New Button()
        btn_exit = New Button()
        Liste_Visiteurs = New ComboBox()
        lbl_Visiteur = New Label()
        Panel1.SuspendLayout()
        CType(Tableau, ComponentModel.ISupportInitialize).BeginInit()
        PanelHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(69), CByte(149), CByte(217))
        Panel1.Controls.Add(btn_Historique_Visites)
        Panel1.Controls.Add(btn_Visiteurs)
        Panel1.Controls.Add(btn_Regions)
        Panel1.Controls.Add(btn_Compte_Rendue)
        Panel1.Dock = DockStyle.Left
        Panel1.Location = New Point(0, 60)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(250, 573)
        Panel1.TabIndex = 6
        ' 
        ' btn_Historique_Visites
        ' 
        btn_Historique_Visites.Anchor = AnchorStyles.Top
        btn_Historique_Visites.BackColor = Color.White
        btn_Historique_Visites.BackgroundImageLayout = ImageLayout.Stretch
        btn_Historique_Visites.Font = New Font("Spline Sans Mono", 14F)
        btn_Historique_Visites.ForeColor = Color.Black
        btn_Historique_Visites.ImageAlign = ContentAlignment.TopCenter
        btn_Historique_Visites.Location = New Point(10, 380)
        btn_Historique_Visites.Name = "btn_Historique_Visites"
        btn_Historique_Visites.Size = New Size(230, 40)
        btn_Historique_Visites.TabIndex = 4
        btn_Historique_Visites.Text = "Historique Visites"
        btn_Historique_Visites.TextAlign = ContentAlignment.TopCenter
        btn_Historique_Visites.UseVisualStyleBackColor = False
        ' 
        ' btn_Visiteurs
        ' 
        btn_Visiteurs.Anchor = AnchorStyles.Top
        btn_Visiteurs.BackColor = Color.White
        btn_Visiteurs.BackgroundImageLayout = ImageLayout.Stretch
        btn_Visiteurs.Font = New Font("Spline Sans Mono", 16F)
        btn_Visiteurs.ForeColor = Color.Black
        btn_Visiteurs.ImageAlign = ContentAlignment.TopCenter
        btn_Visiteurs.Location = New Point(10, 160)
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
        btn_Regions.Font = New Font("Spline Sans Mono", 16F)
        btn_Regions.ForeColor = Color.Black
        btn_Regions.ImageAlign = ContentAlignment.TopCenter
        btn_Regions.Location = New Point(10, 50)
        btn_Regions.Name = "btn_Regions"
        btn_Regions.Size = New Size(230, 40)
        btn_Regions.TabIndex = 3
        btn_Regions.Text = "Régions"
        btn_Regions.TextAlign = ContentAlignment.TopCenter
        btn_Regions.UseVisualStyleBackColor = False
        ' 
        ' btn_Compte_Rendue
        ' 
        btn_Compte_Rendue.Anchor = AnchorStyles.Top
        btn_Compte_Rendue.BackColor = Color.White
        btn_Compte_Rendue.BackgroundImageLayout = ImageLayout.Stretch
        btn_Compte_Rendue.FlatAppearance.BorderSize = 0
        btn_Compte_Rendue.Font = New Font("Spline Sans Mono", 16F)
        btn_Compte_Rendue.ForeColor = Color.Black
        btn_Compte_Rendue.ImageAlign = ContentAlignment.TopCenter
        btn_Compte_Rendue.Location = New Point(10, 270)
        btn_Compte_Rendue.Name = "btn_Compte_Rendue"
        btn_Compte_Rendue.Size = New Size(230, 40)
        btn_Compte_Rendue.TabIndex = 3
        btn_Compte_Rendue.Text = "Compte Rendue"
        btn_Compte_Rendue.TextAlign = ContentAlignment.TopCenter
        btn_Compte_Rendue.UseVisualStyleBackColor = False
        ' 
        ' Tableau
        ' 
        Tableau.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Tableau.Location = New Point(270, 150)
        Tableau.Margin = New Padding(4, 3, 4, 3)
        Tableau.Name = "Tableau"
        Tableau.Size = New Size(769, 444)
        Tableau.TabIndex = 5
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.FromArgb(CByte(81), CByte(175), CByte(255))
        PanelHeader.Controls.Add(lbl_nom)
        PanelHeader.Controls.Add(btn_Deconnexion)
        PanelHeader.Controls.Add(btn_exit)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(1069, 60)
        PanelHeader.TabIndex = 7
        ' 
        ' lbl_nom
        ' 
        lbl_nom.Dock = DockStyle.Left
        lbl_nom.Font = New Font("Spline Sans Mono", 26F)
        lbl_nom.Location = New Point(0, 0)
        lbl_nom.Margin = New Padding(4, 0, 4, 0)
        lbl_nom.Name = "lbl_nom"
        lbl_nom.Size = New Size(644, 60)
        lbl_nom.TabIndex = 4
        lbl_nom.Text = "NOM / PRENOM DELEGUE"
        lbl_nom.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' btn_Deconnexion
        ' 
        btn_Deconnexion.Anchor = AnchorStyles.Top
        btn_Deconnexion.BackColor = Color.White
        btn_Deconnexion.BackgroundImageLayout = ImageLayout.Stretch
        btn_Deconnexion.Font = New Font("Spline Sans Mono", 14F)
        btn_Deconnexion.ForeColor = Color.Black
        btn_Deconnexion.ImageAlign = ContentAlignment.TopCenter
        btn_Deconnexion.Location = New Point(836, 10)
        btn_Deconnexion.Margin = New Padding(4, 3, 4, 3)
        btn_Deconnexion.Name = "btn_Deconnexion"
        btn_Deconnexion.Size = New Size(163, 40)
        btn_Deconnexion.TabIndex = 3
        btn_Deconnexion.Text = "Deconnexion"
        btn_Deconnexion.UseVisualStyleBackColor = False
        ' 
        ' btn_exit
        ' 
        btn_exit.Anchor = AnchorStyles.Top
        btn_exit.BackColor = Color.Red
        btn_exit.BackgroundImageLayout = ImageLayout.Stretch
        btn_exit.FlatAppearance.BorderColor = Color.Red
        btn_exit.FlatAppearance.BorderSize = 0
        btn_exit.FlatStyle = FlatStyle.Popup
        btn_exit.Font = New Font("Spline Sans Mono", 75F, FontStyle.Bold, GraphicsUnit.Document, CByte(0))
        btn_exit.ForeColor = Color.White
        btn_exit.ImageAlign = ContentAlignment.BottomCenter
        btn_exit.Location = New Point(1018, 10)
        btn_exit.Name = "btn_exit"
        btn_exit.Size = New Size(40, 40)
        btn_exit.TabIndex = 3
        btn_exit.Text = "X"
        btn_exit.TextAlign = ContentAlignment.TopRight
        btn_exit.UseVisualStyleBackColor = False
        ' 
        ' Liste_Visiteurs
        ' 
        Liste_Visiteurs.FormattingEnabled = True
        Liste_Visiteurs.Location = New Point(270, 110)
        Liste_Visiteurs.Name = "Liste_Visiteurs"
        Liste_Visiteurs.Size = New Size(147, 23)
        Liste_Visiteurs.TabIndex = 10
        Liste_Visiteurs.Visible = False
        ' 
        ' lbl_Visiteur
        ' 
        lbl_Visiteur.Font = New Font("Spline Sans Mono", 12F)
        lbl_Visiteur.Location = New Point(270, 83)
        lbl_Visiteur.Name = "lbl_Visiteur"
        lbl_Visiteur.Size = New Size(147, 24)
        lbl_Visiteur.TabIndex = 8
        lbl_Visiteur.Text = "Visiteur :"
        lbl_Visiteur.TextAlign = ContentAlignment.TopCenter
        lbl_Visiteur.Visible = False
        ' 
        ' Delegue
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.Control
        ClientSize = New Size(1069, 633)
        Controls.Add(Panel1)
        Controls.Add(Tableau)
        Controls.Add(PanelHeader)
        Controls.Add(Liste_Visiteurs)
        Controls.Add(lbl_Visiteur)
        FormBorderStyle = FormBorderStyle.None
        Name = "Delegue"
        Text = "Delegue"
        Panel1.ResumeLayout(False)
        CType(Tableau, ComponentModel.ISupportInitialize).EndInit()
        PanelHeader.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btn_Visiteurs As Button
    Friend WithEvents btn_Regions As Button
    Friend WithEvents btn_Compte_Rendue As Button
    Friend WithEvents Tableau As DataGridView
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents lbl_nom As Label
    Friend WithEvents btn_Deconnexion As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents btn_Historique_Visites As Button
    Friend WithEvents Liste_Visiteurs As ComboBox
    Friend WithEvents lbl_Visiteur As Label
End Class
