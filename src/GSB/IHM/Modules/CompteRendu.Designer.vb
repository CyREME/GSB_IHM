<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CompteRendu
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
        Tableau_Recherche = New DataGridView()
        Btn_Praticien = New Button()
        Btn_Produit = New Button()
        Btn_Valider = New Button()
        Tableau_Echantillons = New DataGridView()
        NumericUpDown1 = New NumericUpDown()
        TextBox2 = New TextBox()
        Barre_Recherche = New TextBox()
        Liste_Motif = New ComboBox()
        lbl_Liste_Echantillon = New Label()
        lbl_Coef_Confiance = New Label()
        lbl_Bilan_Visite = New Label()
        lbl_Details_Produit = New Label()
        lbl_Motif_Visite = New Label()
        lbl_Praticien_Vu = New Label()
        lbl_Date_Visite = New Label()
        Date_Visite = New DateTimePicker()
        Txt_Description = New TextBox()
        txt_nom__praticien = New TextBox()
        CType(Tableau_Recherche, ComponentModel.ISupportInitialize).BeginInit()
        CType(Tableau_Echantillons, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Tableau_Recherche
        ' 
        Tableau_Recherche.AllowUserToAddRows = False
        Tableau_Recherche.AllowUserToDeleteRows = False
        Tableau_Recherche.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Tableau_Recherche.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Tableau_Recherche.Location = New Point(362, 95)
        Tableau_Recherche.Name = "Tableau_Recherche"
        Tableau_Recherche.Size = New Size(428, 414)
        Tableau_Recherche.TabIndex = 41
        ' 
        ' Btn_Praticien
        ' 
        Btn_Praticien.Cursor = Cursors.Hand
        Btn_Praticien.FlatAppearance.BorderSize = 0
        Btn_Praticien.FlatStyle = FlatStyle.Flat
        Btn_Praticien.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Btn_Praticien.Location = New Point(576, 64)
        Btn_Praticien.Name = "Btn_Praticien"
        Btn_Praticien.Size = New Size(214, 30)
        Btn_Praticien.TabIndex = 40
        Btn_Praticien.Text = "PRATICIENS"
        Btn_Praticien.UseVisualStyleBackColor = True
        ' 
        ' Btn_Produit
        ' 
        Btn_Produit.Cursor = Cursors.Hand
        Btn_Produit.FlatAppearance.BorderSize = 0
        Btn_Produit.FlatStyle = FlatStyle.Flat
        Btn_Produit.Font = New Font("Segoe UI", 10.0F, FontStyle.Bold)
        Btn_Produit.Location = New Point(362, 64)
        Btn_Produit.Name = "Btn_Produit"
        Btn_Produit.Size = New Size(214, 30)
        Btn_Produit.TabIndex = 39
        Btn_Produit.Text = "PRODUITS"
        Btn_Produit.UseVisualStyleBackColor = True
        ' 
        ' Btn_Valider
        ' 
        Btn_Valider.BackColor = Color.FromArgb(CByte(40), CByte(167), CByte(69))
        Btn_Valider.Cursor = Cursors.Hand
        Btn_Valider.FlatAppearance.BorderSize = 0
        Btn_Valider.FlatStyle = FlatStyle.Flat
        Btn_Valider.Font = New Font("Segoe UI", 12.0F, FontStyle.Bold)
        Btn_Valider.ForeColor = Color.White
        Btn_Valider.Location = New Point(530, 522)
        Btn_Valider.Name = "Btn_Valider"
        Btn_Valider.Size = New Size(104, 40)
        Btn_Valider.TabIndex = 38
        Btn_Valider.Text = "VALIDER"
        Btn_Valider.UseVisualStyleBackColor = False
        ' 
        ' Tableau_Echantillons
        ' 
        Tableau_Echantillons.AllowUserToAddRows = False
        Tableau_Echantillons.AllowUserToDeleteRows = False
        Tableau_Echantillons.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Tableau_Echantillons.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Tableau_Echantillons.Location = New Point(16, 425)
        Tableau_Echantillons.Name = "Tableau_Echantillons"
        Tableau_Echantillons.Size = New Size(288, 133)
        Tableau_Echantillons.TabIndex = 37
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.DecimalPlaces = 2
        NumericUpDown1.Font = New Font("Segoe UI", 10.0F)
        NumericUpDown1.Location = New Point(184, 374)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(120, 25)
        NumericUpDown1.TabIndex = 35
        ' 
        ' TextBox2
        ' 
        TextBox2.Font = New Font("Segoe UI", 10.0F)
        TextBox2.Location = New Point(16, 291)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(288, 68)
        TextBox2.TabIndex = 34
        ' 
        ' Barre_Recherche
        ' 
        Barre_Recherche.Font = New Font("Segoe UI", 11.0F)
        Barre_Recherche.Location = New Point(362, 31)
        Barre_Recherche.Name = "Barre_Recherche"
        Barre_Recherche.PlaceholderText = " Rechercher..."
        Barre_Recherche.Size = New Size(428, 27)
        Barre_Recherche.TabIndex = 32
        ' 
        ' Liste_Motif
        ' 
        Liste_Motif.Font = New Font("Segoe UI", 10.0F)
        Liste_Motif.FormattingEnabled = True
        Liste_Motif.Location = New Point(104, 105)
        Liste_Motif.Name = "Liste_Motif"
        Liste_Motif.Size = New Size(200, 25)
        Liste_Motif.TabIndex = 30
        ' 
        ' lbl_Liste_Echantillon
        ' 
        lbl_Liste_Echantillon.AutoSize = True
        lbl_Liste_Echantillon.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        lbl_Liste_Echantillon.ForeColor = Color.FromArgb(CByte(45), CByte(52), CByte(70))
        lbl_Liste_Echantillon.Location = New Point(16, 403)
        lbl_Liste_Echantillon.Name = "lbl_Liste_Echantillon"
        lbl_Liste_Echantillon.Size = New Size(162, 19)
        lbl_Liste_Echantillon.TabIndex = 29
        lbl_Liste_Echantillon.Text = "Échantillons distribués"
        ' 
        ' lbl_Coef_Confiance
        ' 
        lbl_Coef_Confiance.AutoSize = True
        lbl_Coef_Confiance.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        lbl_Coef_Confiance.ForeColor = Color.FromArgb(CByte(45), CByte(52), CByte(70))
        lbl_Coef_Confiance.Location = New Point(16, 376)
        lbl_Coef_Confiance.Name = "lbl_Coef_Confiance"
        lbl_Coef_Confiance.Size = New Size(160, 19)
        lbl_Coef_Confiance.TabIndex = 28
        lbl_Coef_Confiance.Text = "Coefficient de confiance"
        ' 
        ' lbl_Bilan_Visite
        ' 
        lbl_Bilan_Visite.AutoSize = True
        lbl_Bilan_Visite.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        lbl_Bilan_Visite.ForeColor = Color.FromArgb(CByte(45), CByte(52), CByte(70))
        lbl_Bilan_Visite.Location = New Point(16, 269)
        lbl_Bilan_Visite.Name = "lbl_Bilan_Visite"
        lbl_Bilan_Visite.Size = New Size(96, 19)
        lbl_Bilan_Visite.TabIndex = 27
        lbl_Bilan_Visite.Text = "Bilan de visite"
        ' 
        ' lbl_Details_Produit
        ' 
        lbl_Details_Produit.AutoSize = True
        lbl_Details_Produit.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        lbl_Details_Produit.ForeColor = Color.FromArgb(CByte(45), CByte(52), CByte(70))
        lbl_Details_Produit.Location = New Point(16, 134)
        lbl_Details_Produit.Name = "lbl_Details_Produit"
        lbl_Details_Produit.Size = New Size(125, 19)
        lbl_Details_Produit.TabIndex = 26
        lbl_Details_Produit.Text = "Détails du Produit"
        ' 
        ' lbl_Motif_Visite
        ' 
        lbl_Motif_Visite.AutoSize = True
        lbl_Motif_Visite.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        lbl_Motif_Visite.ForeColor = Color.FromArgb(CByte(45), CByte(52), CByte(70))
        lbl_Motif_Visite.Location = New Point(16, 108)
        lbl_Motif_Visite.Name = "lbl_Motif_Visite"
        lbl_Motif_Visite.Size = New Size(44, 19)
        lbl_Motif_Visite.TabIndex = 24
        lbl_Motif_Visite.Text = "Motif"
        ' 
        ' lbl_Praticien_Vu
        ' 
        lbl_Praticien_Vu.AutoSize = True
        lbl_Praticien_Vu.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        lbl_Praticien_Vu.ForeColor = Color.FromArgb(CByte(45), CByte(52), CByte(70))
        lbl_Praticien_Vu.Location = New Point(16, 70)
        lbl_Praticien_Vu.Name = "lbl_Praticien_Vu"
        lbl_Praticien_Vu.Size = New Size(62, 19)
        lbl_Praticien_Vu.TabIndex = 23
        lbl_Praticien_Vu.Text = "Praticien"
        ' 
        ' lbl_Date_Visite
        ' 
        lbl_Date_Visite.AutoSize = True
        lbl_Date_Visite.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        lbl_Date_Visite.ForeColor = Color.FromArgb(CByte(45), CByte(52), CByte(70))
        lbl_Date_Visite.Location = New Point(16, 34)
        lbl_Date_Visite.Name = "lbl_Date_Visite"
        lbl_Date_Visite.Size = New Size(38, 19)
        lbl_Date_Visite.TabIndex = 22
        lbl_Date_Visite.Text = "Date"
        ' 
        ' Date_Visite
        ' 
        Date_Visite.Font = New Font("Segoe UI", 10.0F)
        Date_Visite.Location = New Point(104, 31)
        Date_Visite.Name = "Date_Visite"
        Date_Visite.Size = New Size(200, 25)
        Date_Visite.TabIndex = 21
        ' 
        ' Txt_Description
        ' 
        Txt_Description.BackColor = Color.White
        Txt_Description.Font = New Font("Segoe UI", 10.0F)
        Txt_Description.Location = New Point(16, 156)
        Txt_Description.Multiline = True
        Txt_Description.Name = "Txt_Description"
        Txt_Description.ReadOnly = True
        Txt_Description.Size = New Size(288, 100)
        Txt_Description.TabIndex = 34
        ' 
        ' txt_nom__praticien
        ' 
        txt_nom__praticien.BackColor = Color.White
        txt_nom__praticien.Font = New Font("Segoe UI", 10.0F)
        txt_nom__praticien.Location = New Point(104, 67)
        txt_nom__praticien.Name = "txt_nom__praticien"
        txt_nom__praticien.PlaceholderText = "Sélectionnez à droite ➔"
        txt_nom__praticien.ReadOnly = True
        txt_nom__praticien.Size = New Size(200, 25)
        txt_nom__praticien.TabIndex = 42
        ' 
        ' CompteRendu
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
        Controls.Add(txt_nom__praticien)
        Controls.Add(Tableau_Recherche)
        Controls.Add(Btn_Praticien)
        Controls.Add(Btn_Produit)
        Controls.Add(Btn_Valider)
        Controls.Add(Tableau_Echantillons)
        Controls.Add(NumericUpDown1)
        Controls.Add(Txt_Description)
        Controls.Add(TextBox2)
        Controls.Add(Barre_Recherche)
        Controls.Add(Liste_Motif)
        Controls.Add(lbl_Liste_Echantillon)
        Controls.Add(lbl_Coef_Confiance)
        Controls.Add(lbl_Bilan_Visite)
        Controls.Add(lbl_Details_Produit)
        Controls.Add(lbl_Motif_Visite)
        Controls.Add(lbl_Praticien_Vu)
        Controls.Add(lbl_Date_Visite)
        Controls.Add(Date_Visite)
        Name = "CompteRendu"
        Size = New Size(819, 573)
        CType(Tableau_Recherche, ComponentModel.ISupportInitialize).EndInit()
        CType(Tableau_Echantillons, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Tableau_Recherche As DataGridView
    Friend WithEvents Btn_Praticien As Button
    Friend WithEvents Btn_Produit As Button
    Friend WithEvents Btn_Valider As Button
    Friend WithEvents Tableau_Echantillons As DataGridView
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Barre_Recherche As TextBox
    Friend WithEvents Liste_Motif As ComboBox
    Friend WithEvents lbl_Liste_Echantillon As Label
    Friend WithEvents lbl_Coef_Confiance As Label
    Friend WithEvents lbl_Bilan_Visite As Label
    Friend WithEvents lbl_Details_Produit As Label
    Friend WithEvents lbl_Motif_Visite As Label
    Friend WithEvents lbl_Praticien_Vu As Label
    Friend WithEvents lbl_Date_Visite As Label
    Friend WithEvents Date_Visite As DateTimePicker
    Friend WithEvents Txt_Description As TextBox
    Friend WithEvents txt_nom__praticien As TextBox

End Class