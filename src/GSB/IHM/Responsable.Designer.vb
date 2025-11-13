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
        DataGridView1 = New DataGridView()
        Panel1 = New Panel()
        btn_Visiteurs = New Button()
        btn_Regions = New Button()
        btn_Secteur = New Button()
        PanelHeader = New Panel()
        lbl_nom = New Label()
        btn_Deconnexion = New Button()
        btn_exit = New Button()
        lbl_Delegue = New Label()
        Liste_Delegues = New ComboBox()
        lbl_Visiteur = New Label()
        Liste_Visiteurs = New ComboBox()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        PanelHeader.SuspendLayout()
        SuspendLayout()
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(270, 150)
        DataGridView1.Margin = New Padding(4, 3, 4, 3)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(769, 444)
        DataGridView1.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(69, 149, 217)
        Panel1.Controls.Add(btn_Visiteurs)
        Panel1.Controls.Add(btn_Regions)
        Panel1.Controls.Add(btn_Secteur)
        Panel1.Location = New Point(0, 60)
        Panel1.Margin = New Padding(4, 3, 4, 3)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(250, 573)
        Panel1.TabIndex = 1
        ' 
        ' btn_Visiteurs
        ' 
        btn_Visiteurs.Anchor = AnchorStyles.Top
        btn_Visiteurs.BackColor = Color.White
        btn_Visiteurs.BackgroundImageLayout = ImageLayout.Stretch
        btn_Visiteurs.Font = New Font("Spline Sans Mono", 18F)
        btn_Visiteurs.ForeColor = Color.Black
        btn_Visiteurs.ImageAlign = ContentAlignment.TopCenter
        btn_Visiteurs.Location = New Point(10, 270)
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
        btn_Regions.Location = New Point(10, 160)
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
        btn_Secteur.Location = New Point(10, 50)
        btn_Secteur.Name = "btn_Secteur"
        btn_Secteur.Size = New Size(230, 40)
        btn_Secteur.TabIndex = 3
        btn_Secteur.Text = "Secteur"
        btn_Secteur.TextAlign = ContentAlignment.TopCenter
        btn_Secteur.UseVisualStyleBackColor = False
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.FromArgb(81, 175, 255)
        PanelHeader.Controls.Add(lbl_nom)
        PanelHeader.Controls.Add(btn_Deconnexion)
        PanelHeader.Controls.Add(btn_exit)
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Margin = New Padding(4, 3, 4, 3)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(1069, 60)
        PanelHeader.TabIndex = 2
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
        lbl_nom.Text = "NOM / PRENOM RESPONSABLE"
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
        btn_exit.Font = New Font("Spline Sans Mono", 75F, FontStyle.Bold, GraphicsUnit.Document, 0)
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
        ' lbl_Delegue
        ' 
        lbl_Delegue.Font = New Font("Spline Sans Mono", 12F)
        lbl_Delegue.Location = New Point(270, 83)
        lbl_Delegue.Name = "lbl_Delegue"
        lbl_Delegue.Size = New Size(147, 24)
        lbl_Delegue.TabIndex = 3
        lbl_Delegue.Text = "Délégué :"
        lbl_Delegue.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Liste_Delegues
        ' 
        Liste_Delegues.FormattingEnabled = True
        Liste_Delegues.Location = New Point(270, 110)
        Liste_Delegues.Name = "Liste_Delegues"
        Liste_Delegues.Size = New Size(147, 23)
        Liste_Delegues.TabIndex = 4
        ' 
        ' lbl_Visiteur
        ' 
        lbl_Visiteur.Font = New Font("Spline Sans Mono", 12F)
        lbl_Visiteur.Location = New Point(497, 83)
        lbl_Visiteur.Name = "lbl_Visiteur"
        lbl_Visiteur.Size = New Size(147, 24)
        lbl_Visiteur.TabIndex = 3
        lbl_Visiteur.Text = "Visiteur :"
        lbl_Visiteur.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Liste_Visiteurs
        ' 
        Liste_Visiteurs.FormattingEnabled = True
        Liste_Visiteurs.Location = New Point(497, 110)
        Liste_Visiteurs.Name = "Liste_Visiteurs"
        Liste_Visiteurs.Size = New Size(147, 23)
        Liste_Visiteurs.TabIndex = 4
        ' 
        ' Responsable
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1069, 633)
        Controls.Add(Liste_Visiteurs)
        Controls.Add(Liste_Delegues)
        Controls.Add(lbl_Visiteur)
        Controls.Add(lbl_Delegue)
        Controls.Add(PanelHeader)
        Controls.Add(Panel1)
        Controls.Add(DataGridView1)
        FormBorderStyle = FormBorderStyle.None
        Margin = New Padding(4, 3, 4, 3)
        Name = "Responsable"
        Text = "Responsable"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        PanelHeader.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents btn_exit As Button
    Friend WithEvents lbl_nom As Label
    Friend WithEvents btn_Deconnexion As Button
    Friend WithEvents btn_Visiteurs As Button
    Friend WithEvents btn_Regions As Button
    Friend WithEvents btn_Secteur As Button
    Friend WithEvents lbl_Delegue As Label
    Friend WithEvents Liste_Delegues As ComboBox
    Friend WithEvents lbl_Visiteur As Label
    Friend WithEvents Liste_Visiteurs As ComboBox
End Class
