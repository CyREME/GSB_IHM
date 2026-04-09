<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VueTableauRegionSecteur
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
        Liste_Visiteurs = New ComboBox()
        Liste_Delegues = New ComboBox()
        lbl_Visiteur = New Label()
        lbl_Delegue = New Label()
        Tab = New DataGridView()
        CType(Tab, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Liste_Visiteurs
        ' 
        Liste_Visiteurs.FormattingEnabled = True
        Liste_Visiteurs.Location = New Point(252, 58)
        Liste_Visiteurs.Name = "Liste_Visiteurs"
        Liste_Visiteurs.Size = New Size(147, 23)
        Liste_Visiteurs.TabIndex = 8
        ' 
        ' Liste_Delegues
        ' 
        Liste_Delegues.FormattingEnabled = True
        Liste_Delegues.Location = New Point(25, 58)
        Liste_Delegues.Name = "Liste_Delegues"
        Liste_Delegues.Size = New Size(147, 23)
        Liste_Delegues.TabIndex = 9
        ' 
        ' lbl_Visiteur
        ' 
        lbl_Visiteur.Font = New Font("Spline Sans Mono", 12F)
        lbl_Visiteur.Location = New Point(252, 31)
        lbl_Visiteur.Name = "lbl_Visiteur"
        lbl_Visiteur.Size = New Size(147, 24)
        lbl_Visiteur.TabIndex = 6
        lbl_Visiteur.Text = "Visiteur :"
        lbl_Visiteur.TextAlign = ContentAlignment.TopCenter
        ' 
        ' lbl_Delegue
        ' 
        lbl_Delegue.Font = New Font("Spline Sans Mono", 12F)
        lbl_Delegue.Location = New Point(25, 31)
        lbl_Delegue.Name = "lbl_Delegue"
        lbl_Delegue.Size = New Size(147, 24)
        lbl_Delegue.TabIndex = 7
        lbl_Delegue.Text = "Délégué :"
        lbl_Delegue.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Tab
        ' 
        Tab.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Tab.Location = New Point(25, 98)
        Tab.Margin = New Padding(4, 3, 4, 3)
        Tab.Name = "Tab"
        Tab.ReadOnly = True
        Tab.Size = New Size(769, 444)
        Tab.TabIndex = 5
        ' 
        ' VueTableauRegionSecteur
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Liste_Visiteurs)
        Controls.Add(Liste_Delegues)
        Controls.Add(lbl_Visiteur)
        Controls.Add(lbl_Delegue)
        Controls.Add(Tab)
        Name = "VueTableauRegionSecteur"
        Size = New Size(819, 573)
        CType(Tab, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents Liste_Visiteurs As ComboBox
    Friend WithEvents Liste_Delegues As ComboBox
    Friend WithEvents lbl_Visiteur As Label
    Friend WithEvents lbl_Delegue As Label
    Friend WithEvents Tab As DataGridView

End Class
