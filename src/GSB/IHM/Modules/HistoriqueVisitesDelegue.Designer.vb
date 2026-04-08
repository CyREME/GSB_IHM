<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistoriqueVisitesDelegue
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Tableau_Activite = New DataGridView()
        Tableau_Synthese_Praticiens = New DataGridView()
        lbl_echantillon = New Label()
        lbl_visites = New Label()
        lbl_annee = New Label()
        Liste_Annee = New ComboBox()
        CType(Tableau_Activite, ComponentModel.ISupportInitialize).BeginInit()
        CType(Tableau_Synthese_Praticiens, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Tableau_Activite
        ' 
        Tableau_Activite.AllowUserToAddRows = False
        Tableau_Activite.AllowUserToDeleteRows = False
        Tableau_Activite.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Tableau_Activite.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Tableau_Activite.Location = New Point(431, 172)
        Tableau_Activite.Name = "Tableau_Activite"
        Tableau_Activite.Size = New Size(355, 380)
        Tableau_Activite.TabIndex = 8
        ' 
        ' Tableau_Synthese_Praticiens
        ' 
        Tableau_Synthese_Praticiens.AllowUserToAddRows = False
        Tableau_Synthese_Praticiens.AllowUserToDeleteRows = False
        Tableau_Synthese_Praticiens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Tableau_Synthese_Praticiens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Tableau_Synthese_Praticiens.Location = New Point(33, 172)
        Tableau_Synthese_Praticiens.Name = "Tableau_Synthese_Praticiens"
        Tableau_Synthese_Praticiens.Size = New Size(355, 380)
        Tableau_Synthese_Praticiens.TabIndex = 9
        ' 
        ' lbl_echantillon
        ' 
        lbl_echantillon.AutoSize = True
        lbl_echantillon.Font = New Font("Spline Sans Mono", 9F)
        lbl_echantillon.Location = New Point(33, 135)
        lbl_echantillon.Name = "lbl_echantillon"
        lbl_echantillon.Size = New Size(274, 17)
        lbl_echantillon.TabIndex = 6
        lbl_echantillon.Text = "Nombre total d'échantillon distribué :"
        ' 
        ' lbl_visites
        ' 
        lbl_visites.AutoSize = True
        lbl_visites.Font = New Font("Spline Sans Mono", 9F)
        lbl_visites.Location = New Point(33, 98)
        lbl_visites.Name = "lbl_visites"
        lbl_visites.Size = New Size(176, 17)
        lbl_visites.TabIndex = 7
        lbl_visites.Text = "Nombre total de visite :"
        ' 
        ' lbl_annee
        ' 
        lbl_annee.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lbl_annee.Font = New Font("Spline Sans Mono", 14F)
        lbl_annee.Location = New Point(33, 21)
        lbl_annee.Name = "lbl_annee"
        lbl_annee.Size = New Size(121, 24)
        lbl_annee.TabIndex = 5
        lbl_annee.Text = "Année"
        lbl_annee.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Liste_Annee
        ' 
        Liste_Annee.FormattingEnabled = True
        Liste_Annee.Location = New Point(33, 48)
        Liste_Annee.Name = "Liste_Annee"
        Liste_Annee.Size = New Size(121, 23)
        Liste_Annee.TabIndex = 4
        ' 
        ' HistoriqueVisitesDelegue
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Tableau_Activite)
        Controls.Add(Tableau_Synthese_Praticiens)
        Controls.Add(lbl_echantillon)
        Controls.Add(lbl_visites)
        Controls.Add(lbl_annee)
        Controls.Add(Liste_Annee)
        Name = "HistoriqueVisitesDelegue"
        Size = New Size(819, 573)
        CType(Tableau_Activite, ComponentModel.ISupportInitialize).EndInit()
        CType(Tableau_Synthese_Praticiens, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Tableau_Activite As DataGridView
    Friend WithEvents Tableau_Synthese_Praticiens As DataGridView
    Friend WithEvents lbl_echantillon As Label
    Friend WithEvents lbl_visites As Label
    Friend WithEvents lbl_annee As Label
    Friend WithEvents Liste_Annee As ComboBox

End Class
