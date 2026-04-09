<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VueRegion
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Tab = New DataGridView()
        lbl_annee = New Label()
        Liste_Annee = New ComboBox()
        CType(Tab, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
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
        ' lbl_annee
        ' 
        lbl_annee.Font = New Font("Spline Sans Mono", 12.0F)
        lbl_annee.Location = New Point(25, 31)
        lbl_annee.Name = "lbl_annee"
        lbl_annee.Size = New Size(147, 22)
        lbl_annee.TabIndex = 6
        lbl_annee.Text = "Année :"
        lbl_annee.TextAlign = ContentAlignment.TopCenter
        ' 
        ' Liste_Annee
        ' 
        Liste_Annee.FormattingEnabled = True
        Liste_Annee.Location = New Point(25, 58)
        Liste_Annee.Name = "Liste_Annee"
        Liste_Annee.Size = New Size(147, 23)
        Liste_Annee.TabIndex = 7
        ' 
        ' VueRegion
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Liste_Annee)
        Controls.Add(lbl_annee)
        Controls.Add(Tab)
        Name = "VueRegion"
        Size = New Size(819, 573)
        CType(Tab, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub
    Friend WithEvents Tab As DataGridView
    Friend WithEvents lbl_annee As Label
    Friend WithEvents Liste_Annee As ComboBox

End Class
