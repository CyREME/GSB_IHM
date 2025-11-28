<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HistoriqueVisites
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
        Liste_Annee = New ComboBox()
        lbl_annee = New Label()
        lbl_visites = New Label()
        lbl_echantillon = New Label()
        DataGridView1 = New DataGridView()
        DataGridView2 = New DataGridView()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Liste_Annee
        ' 
        Liste_Annee.FormattingEnabled = True
        Liste_Annee.Location = New Point(33, 53)
        Liste_Annee.Name = "Liste_Annee"
        Liste_Annee.Size = New Size(121, 23)
        Liste_Annee.TabIndex = 0
        ' 
        ' lbl_annee
        ' 
        lbl_annee.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        lbl_annee.Font = New Font("Spline Sans Mono", 14F)
        lbl_annee.Location = New Point(33, 26)
        lbl_annee.Name = "lbl_annee"
        lbl_annee.Size = New Size(121, 24)
        lbl_annee.TabIndex = 1
        lbl_annee.Text = "Année"
        lbl_annee.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' lbl_visites
        ' 
        lbl_visites.AutoSize = True
        lbl_visites.Font = New Font("Spline Sans Mono", 9F)
        lbl_visites.Location = New Point(33, 103)
        lbl_visites.Name = "lbl_visites"
        lbl_visites.Size = New Size(176, 17)
        lbl_visites.TabIndex = 2
        lbl_visites.Text = "Nombre total de visite :"
        ' 
        ' lbl_echantillon
        ' 
        lbl_echantillon.AutoSize = True
        lbl_echantillon.Font = New Font("Spline Sans Mono", 9F)
        lbl_echantillon.Location = New Point(33, 140)
        lbl_echantillon.Name = "lbl_echantillon"
        lbl_echantillon.Size = New Size(274, 17)
        lbl_echantillon.TabIndex = 2
        lbl_echantillon.Text = "Nombre total d'échantillon distribué :"
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(33, 177)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(355, 380)
        DataGridView1.TabIndex = 3
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(431, 177)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.Size = New Size(355, 380)
        DataGridView2.TabIndex = 3
        ' 
        ' HistoriqueVisites
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(DataGridView2)
        Controls.Add(DataGridView1)
        Controls.Add(lbl_echantillon)
        Controls.Add(lbl_visites)
        Controls.Add(lbl_annee)
        Controls.Add(Liste_Annee)
        Name = "HistoriqueVisites"
        Size = New Size(819, 573)
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Liste_Annee As ComboBox
    Friend WithEvents lbl_annee As Label
    Friend WithEvents lbl_visites As Label
    Friend WithEvents lbl_echantillon As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataGridView2 As DataGridView

End Class
