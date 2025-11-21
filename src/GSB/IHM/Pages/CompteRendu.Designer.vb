<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CompteRendu
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
        Tableau_Recherche = New DataGridView()
        btn_Recherche_Praticien = New Button()
        btn_Recherche_Produit = New Button()
        Button4 = New Button()
        DataGridView3 = New DataGridView()
        DataGridView1 = New DataGridView()
        NumericUpDown1 = New NumericUpDown()
        TextBox2 = New TextBox()
        Barre_Recherche = New TextBox()
        Nom_Praticien = New TextBox()
        CheckedListBox1 = New CheckedListBox()
        ComboBox2 = New ComboBox()
        lbl_Liste_Echantillon = New Label()
        lbl_Coef_Confiance = New Label()
        lbl_Bilan_Visite = New Label()
        lbl_Details_Produit = New Label()
        lbl_Produit_Presente = New Label()
        lbl_Motif_Visite = New Label()
        lbl_Praticien_Vu = New Label()
        lbl_Date_Visite = New Label()
        Date_Visite = New DateTimePicker()
        CType(Tableau_Recherche, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView3, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Tableau_Recherche
        ' 
        Tableau_Recherche.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Tableau_Recherche.Location = New Point(482, 131)
        Tableau_Recherche.Name = "Tableau_Recherche"
        Tableau_Recherche.Size = New Size(320, 338)
        Tableau_Recherche.TabIndex = 41
        ' 
        ' btn_Recherche_Praticien
        ' 
        btn_Recherche_Praticien.Location = New Point(652, 101)
        btn_Recherche_Praticien.Name = "btn_Recherche_Praticien"
        btn_Recherche_Praticien.Size = New Size(150, 25)
        btn_Recherche_Praticien.TabIndex = 40
        btn_Recherche_Praticien.Text = "PRATICIEN"
        btn_Recherche_Praticien.UseVisualStyleBackColor = True
        ' 
        ' btn_Recherche_Produit
        ' 
        btn_Recherche_Produit.Location = New Point(482, 101)
        btn_Recherche_Produit.Name = "btn_Recherche_Produit"
        btn_Recherche_Produit.Size = New Size(150, 25)
        btn_Recherche_Produit.TabIndex = 39
        btn_Recherche_Produit.Text = "PRODUITS"
        btn_Recherche_Produit.UseVisualStyleBackColor = True
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(362, 503)
        Button4.Name = "Button4"
        Button4.Size = New Size(104, 36)
        Button4.TabIndex = 38
        Button4.Text = "VALIDER"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' DataGridView3
        ' 
        DataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView3.Location = New Point(184, 407)
        DataGridView3.Name = "DataGridView3"
        DataGridView3.Size = New Size(267, 62)
        DataGridView3.TabIndex = 37
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(184, 182)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(267, 68)
        DataGridView1.TabIndex = 36
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.DecimalPlaces = 2
        NumericUpDown1.Location = New Point(184, 369)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(120, 23)
        NumericUpDown1.TabIndex = 35
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(184, 270)
        TextBox2.Multiline = True
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(267, 68)
        TextBox2.TabIndex = 34
        ' 
        ' Barre_Recherche
        ' 
        Barre_Recherche.Location = New Point(482, 71)
        Barre_Recherche.Name = "Barre_Recherche"
        Barre_Recherche.Size = New Size(320, 23)
        Barre_Recherche.TabIndex = 32
        ' 
        ' Nom_Praticien
        ' 
        Nom_Praticien.Location = New Point(184, 70)
        Nom_Praticien.Name = "Nom_Praticien"
        Nom_Praticien.ReadOnly = True
        Nom_Praticien.Size = New Size(100, 23)
        Nom_Praticien.TabIndex = 33
        ' 
        ' CheckedListBox1
        ' 
        CheckedListBox1.FormattingEnabled = True
        CheckedListBox1.Location = New Point(184, 144)
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.Size = New Size(120, 22)
        CheckedListBox1.TabIndex = 31
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(184, 105)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(121, 23)
        ComboBox2.TabIndex = 30
        ' 
        ' lbl_Liste_Echantillon
        ' 
        lbl_Liste_Echantillon.AutoSize = True
        lbl_Liste_Echantillon.Location = New Point(16, 407)
        lbl_Liste_Echantillon.Name = "lbl_Liste_Echantillon"
        lbl_Liste_Echantillon.Size = New Size(149, 15)
        lbl_Liste_Echantillon.TabIndex = 29
        lbl_Liste_Echantillon.Text = "Liste échantillons/Quantité"
        lbl_Liste_Echantillon.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lbl_Coef_Confiance
        ' 
        lbl_Coef_Confiance.AutoSize = True
        lbl_Coef_Confiance.Location = New Point(16, 369)
        lbl_Coef_Confiance.Name = "lbl_Coef_Confiance"
        lbl_Coef_Confiance.Size = New Size(138, 15)
        lbl_Coef_Confiance.TabIndex = 28
        lbl_Coef_Confiance.Text = "Coefficiant de Confiance"
        lbl_Coef_Confiance.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lbl_Bilan_Visite
        ' 
        lbl_Bilan_Visite.AutoSize = True
        lbl_Bilan_Visite.Location = New Point(16, 270)
        lbl_Bilan_Visite.Name = "lbl_Bilan_Visite"
        lbl_Bilan_Visite.Size = New Size(64, 15)
        lbl_Bilan_Visite.TabIndex = 27
        lbl_Bilan_Visite.Text = "Bilan Visite"
        lbl_Bilan_Visite.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lbl_Details_Produit
        ' 
        lbl_Details_Produit.AutoSize = True
        lbl_Details_Produit.Location = New Point(16, 182)
        lbl_Details_Produit.Name = "lbl_Details_Produit"
        lbl_Details_Produit.Size = New Size(84, 15)
        lbl_Details_Produit.TabIndex = 26
        lbl_Details_Produit.Text = "Détails Produit"
        lbl_Details_Produit.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lbl_Produit_Presente
        ' 
        lbl_Produit_Presente.AutoSize = True
        lbl_Produit_Presente.Location = New Point(16, 144)
        lbl_Produit_Presente.Name = "lbl_Produit_Presente"
        lbl_Produit_Presente.Size = New Size(104, 15)
        lbl_Produit_Presente.TabIndex = 25
        lbl_Produit_Presente.Text = "Produits Présentés"
        lbl_Produit_Presente.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lbl_Motif_Visite
        ' 
        lbl_Motif_Visite.AutoSize = True
        lbl_Motif_Visite.Location = New Point(16, 105)
        lbl_Motif_Visite.Name = "lbl_Motif_Visite"
        lbl_Motif_Visite.Size = New Size(67, 15)
        lbl_Motif_Visite.TabIndex = 24
        lbl_Motif_Visite.Text = "Motif Visite"
        lbl_Motif_Visite.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lbl_Praticien_Vu
        ' 
        lbl_Praticien_Vu.AutoSize = True
        lbl_Praticien_Vu.Location = New Point(16, 70)
        lbl_Praticien_Vu.Name = "lbl_Praticien_Vu"
        lbl_Praticien_Vu.Size = New Size(69, 15)
        lbl_Praticien_Vu.TabIndex = 23
        lbl_Praticien_Vu.Text = "Praticien vu"
        lbl_Praticien_Vu.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' lbl_Date_Visite
        ' 
        lbl_Date_Visite.AutoSize = True
        lbl_Date_Visite.Location = New Point(16, 34)
        lbl_Date_Visite.Name = "lbl_Date_Visite"
        lbl_Date_Visite.Size = New Size(62, 15)
        lbl_Date_Visite.TabIndex = 22
        lbl_Date_Visite.Text = "Date Visite"
        lbl_Date_Visite.TextAlign = ContentAlignment.MiddleRight
        ' 
        ' Date_Visite
        ' 
        Date_Visite.Location = New Point(184, 34)
        Date_Visite.Name = "Date_Visite"
        Date_Visite.Size = New Size(200, 23)
        Date_Visite.TabIndex = 21
        ' 
        ' CompteRendu
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Tableau_Recherche)
        Controls.Add(btn_Recherche_Praticien)
        Controls.Add(btn_Recherche_Produit)
        Controls.Add(Button4)
        Controls.Add(DataGridView3)
        Controls.Add(DataGridView1)
        Controls.Add(NumericUpDown1)
        Controls.Add(TextBox2)
        Controls.Add(Barre_Recherche)
        Controls.Add(Nom_Praticien)
        Controls.Add(CheckedListBox1)
        Controls.Add(ComboBox2)
        Controls.Add(lbl_Liste_Echantillon)
        Controls.Add(lbl_Coef_Confiance)
        Controls.Add(lbl_Bilan_Visite)
        Controls.Add(lbl_Details_Produit)
        Controls.Add(lbl_Produit_Presente)
        Controls.Add(lbl_Motif_Visite)
        Controls.Add(lbl_Praticien_Vu)
        Controls.Add(lbl_Date_Visite)
        Controls.Add(Date_Visite)
        Name = "CompteRendu"
        Size = New Size(819, 573)
        CType(Tableau_Recherche, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView3, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Tableau_Recherche As DataGridView
    Friend WithEvents btn_Recherche_Praticien As Button
    Friend WithEvents btn_Recherche_Produit As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Barre_Recherche As TextBox
    Friend WithEvents Nom_Praticien As TextBox
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents lbl_Liste_Echantillon As Label
    Friend WithEvents lbl_Coef_Confiance As Label
    Friend WithEvents lbl_Bilan_Visite As Label
    Friend WithEvents lbl_Details_Produit As Label
    Friend WithEvents lbl_Produit_Presente As Label
    Friend WithEvents lbl_Motif_Visite As Label
    Friend WithEvents lbl_Praticien_Vu As Label
    Friend WithEvents lbl_Date_Visite As Label
    Friend WithEvents Date_Visite As DateTimePicker

End Class
