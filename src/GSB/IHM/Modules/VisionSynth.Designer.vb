<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VisionSynth
    Inherits System.Windows.Forms.UserControl

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
        Liste_Annee = New ComboBox()
        lbl_annee = New Label()
        lbl_visites = New Label()
        lbl_echantillon = New Label()
        Tableau_Synthese_Praticiens = New DataGridView()
        Tableau_Activite = New DataGridView()
        CType(Tableau_Synthese_Praticiens, ComponentModel.ISupportInitialize).BeginInit()
        CType(Tableau_Activite, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Liste_Annee
        ' 
        Liste_Annee.DropDownStyle = ComboBoxStyle.DropDownList
        Liste_Annee.Font = New Font("Segoe UI", 12.0F)
        Liste_Annee.FormattingEnabled = True
        Liste_Annee.Location = New Point(33, 53)
        Liste_Annee.Name = "Liste_Annee"
        Liste_Annee.Size = New Size(150, 29)
        Liste_Annee.TabIndex = 0
        ' 
        ' lbl_annee
        ' 
        lbl_annee.AutoSize = True
        lbl_annee.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        lbl_annee.ForeColor = Color.FromArgb(CByte(45), CByte(52), CByte(70))
        lbl_annee.Location = New Point(33, 26)
        lbl_annee.Name = "lbl_annee"
        lbl_annee.Size = New Size(141, 21)
        lbl_annee.TabIndex = 1
        lbl_annee.Text = "Filtrer par année :"
        ' 
        ' lbl_visites
        ' 
        lbl_visites.AutoSize = True
        lbl_visites.Font = New Font("Segoe UI", 12.0F)
        lbl_visites.ForeColor = Color.FromArgb(CByte(45), CByte(52), CByte(70))
        lbl_visites.Location = New Point(33, 103)
        lbl_visites.Name = "lbl_visites"
        lbl_visites.Size = New Size(174, 21)
        lbl_visites.TabIndex = 2
        lbl_visites.Text = "Nombre total de visites :"
        ' 
        ' lbl_echantillon
        ' 
        lbl_echantillon.AutoSize = True
        lbl_echantillon.Font = New Font("Segoe UI", 12.0F)
        lbl_echantillon.ForeColor = Color.FromArgb(CByte(45), CByte(52), CByte(70))
        lbl_echantillon.Location = New Point(33, 140)
        lbl_echantillon.Name = "lbl_echantillon"
        lbl_echantillon.Size = New Size(265, 21)
        lbl_echantillon.TabIndex = 2
        lbl_echantillon.Text = "Nombre total d'échantillons distribués :"
        ' 
        ' Tableau_Synthese_Praticiens
        ' 
        Tableau_Synthese_Praticiens.AllowUserToAddRows = False
        Tableau_Synthese_Praticiens.AllowUserToDeleteRows = False
        Tableau_Synthese_Praticiens.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Tableau_Synthese_Praticiens.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Tableau_Synthese_Praticiens.Location = New Point(33, 177)
        Tableau_Synthese_Praticiens.Name = "Tableau_Synthese_Praticiens"
        Tableau_Synthese_Praticiens.Size = New Size(400, 360)
        Tableau_Synthese_Praticiens.TabIndex = 3
        ' 
        ' Tableau_Activite
        ' 
        Tableau_Activite.AllowUserToAddRows = False
        Tableau_Activite.AllowUserToDeleteRows = False
        Tableau_Activite.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Tableau_Activite.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Tableau_Activite.Location = New Point(450, 177)
        Tableau_Activite.Name = "Tableau_Activite"
        Tableau_Activite.Size = New Size(336, 360)
        Tableau_Activite.TabIndex = 3
        ' 
        ' VisionSynth
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
        Controls.Add(Tableau_Activite)
        Controls.Add(Tableau_Synthese_Praticiens)
        Controls.Add(lbl_echantillon)
        Controls.Add(lbl_visites)
        Controls.Add(lbl_annee)
        Controls.Add(Liste_Annee)
        Name = "VisionSynth"
        Size = New Size(819, 573)
        CType(Tableau_Synthese_Praticiens, ComponentModel.ISupportInitialize).EndInit()
        CType(Tableau_Activite, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Liste_Annee As ComboBox
    Friend WithEvents lbl_annee As Label
    Friend WithEvents lbl_visites As Label
    Friend WithEvents lbl_echantillon As Label
    Friend WithEvents Tableau_Synthese_Praticiens As DataGridView
    Friend WithEvents Tableau_Activite As DataGridView

End Class