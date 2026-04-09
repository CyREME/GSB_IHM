<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VueSecteurRegionResp
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
        Liste_Visiteurs.DropDownStyle = ComboBoxStyle.DropDownList
        Liste_Visiteurs.Font = New Font("Segoe UI", 12.0F)
        Liste_Visiteurs.FormattingEnabled = True
        Liste_Visiteurs.Location = New Point(252, 53)
        Liste_Visiteurs.Name = "Liste_Visiteurs"
        Liste_Visiteurs.Size = New Size(200, 29)
        Liste_Visiteurs.TabIndex = 8
        ' 
        ' Liste_Delegues
        ' 
        Liste_Delegues.DropDownStyle = ComboBoxStyle.DropDownList
        Liste_Delegues.Font = New Font("Segoe UI", 12.0F)
        Liste_Delegues.FormattingEnabled = True
        Liste_Delegues.Location = New Point(25, 53)
        Liste_Delegues.Name = "Liste_Delegues"
        Liste_Delegues.Size = New Size(200, 29)
        Liste_Delegues.TabIndex = 9
        ' 
        ' lbl_Visiteur
        ' 
        lbl_Visiteur.AutoSize = True
        lbl_Visiteur.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        lbl_Visiteur.ForeColor = Color.FromArgb(CByte(45), CByte(52), CByte(70))
        lbl_Visiteur.Location = New Point(252, 26)
        lbl_Visiteur.Name = "lbl_Visiteur"
        lbl_Visiteur.Size = New Size(77, 21)
        lbl_Visiteur.TabIndex = 6
        lbl_Visiteur.Text = "Visiteur :"
        ' 
        ' lbl_Delegue
        ' 
        lbl_Delegue.AutoSize = True
        lbl_Delegue.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        lbl_Delegue.ForeColor = Color.FromArgb(CByte(45), CByte(52), CByte(70))
        lbl_Delegue.Location = New Point(25, 26)
        lbl_Delegue.Name = "lbl_Delegue"
        lbl_Delegue.Size = New Size(79, 21)
        lbl_Delegue.TabIndex = 7
        lbl_Delegue.Text = "Délégué :"
        ' 
        ' Tab
        ' 
        Tab.AllowUserToAddRows = False
        Tab.AllowUserToDeleteRows = False
        Tab.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Tab.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Tab.Location = New Point(25, 95)
        Tab.Name = "Tab"
        Tab.ReadOnly = True
        Tab.Size = New Size(769, 444)
        Tab.TabIndex = 5
        ' 
        ' VueTableauRegionSecteur
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
        Controls.Add(Liste_Visiteurs)
        Controls.Add(Liste_Delegues)
        Controls.Add(lbl_Visiteur)
        Controls.Add(lbl_Delegue)
        Controls.Add(Tab)
        Name = "VueTableauRegionSecteur"
        Size = New Size(819, 573)
        CType(Tab, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Liste_Visiteurs As ComboBox
    Friend WithEvents Liste_Delegues As ComboBox
    Friend WithEvents lbl_Visiteur As Label
    Friend WithEvents lbl_Delegue As Label
    Friend WithEvents Tab As DataGridView

End Class