<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Visiteur
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
        PanelHeader = New Panel()
        lbl_nom = New Label()
        Panel2 = New Panel()
        btn_Compte_Rendu = New Button()
        btn_Vision_Synthese = New Button()
        btn_Historique_Visites = New Button()
        PanelAffichage = New Panel()
        btn_exit_Panel = New Panel()
        btn_logout_Panel = New Panel()
        PanelHeader.SuspendLayout()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelHeader
        ' 
        PanelHeader.BackColor = Color.FromArgb(CByte(81), CByte(175), CByte(255))
        PanelHeader.BackgroundImageLayout = ImageLayout.None
        PanelHeader.Controls.Add(btn_exit_Panel)
        PanelHeader.Controls.Add(btn_logout_Panel)
        PanelHeader.Controls.Add(lbl_nom)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.ForeColor = SystemColors.ControlText
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(1069, 60)
        PanelHeader.TabIndex = 1
        ' 
        ' lbl_nom
        ' 
        lbl_nom.Dock = DockStyle.Left
        lbl_nom.Font = New Font("Spline Sans Mono", 26.0F)
        lbl_nom.ForeColor = SystemColors.ControlText
        lbl_nom.Location = New Point(0, 0)
        lbl_nom.Margin = New Padding(4, 0, 4, 0)
        lbl_nom.Name = "lbl_nom"
        lbl_nom.Size = New Size(644, 60)
        lbl_nom.TabIndex = 6
        lbl_nom.Text = "NOM / PRENOM VISITEUR"
        lbl_nom.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(69), CByte(149), CByte(217))
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(btn_Compte_Rendu)
        Panel2.Controls.Add(btn_Vision_Synthese)
        Panel2.Controls.Add(btn_Historique_Visites)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 60)
        Panel2.Margin = New Padding(4, 3, 4, 3)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(250, 573)
        Panel2.TabIndex = 2
        ' 
        ' btn_Compte_Rendu
        ' 
        btn_Compte_Rendu.Font = New Font("Spline Sans Mono", 14.0F)
        btn_Compte_Rendu.ImageAlign = ContentAlignment.TopCenter
        btn_Compte_Rendu.Location = New Point(10, 50)
        btn_Compte_Rendu.Name = "btn_Compte_Rendu"
        btn_Compte_Rendu.Size = New Size(230, 40)
        btn_Compte_Rendu.TabIndex = 8
        btn_Compte_Rendu.Text = "Compte Rendu"
        btn_Compte_Rendu.UseVisualStyleBackColor = True
        ' 
        ' btn_Vision_Synthese
        ' 
        btn_Vision_Synthese.Font = New Font("Spline Sans Mono", 14.0F)
        btn_Vision_Synthese.ImageAlign = ContentAlignment.TopCenter
        btn_Vision_Synthese.Location = New Point(10, 270)
        btn_Vision_Synthese.Name = "btn_Vision_Synthese"
        btn_Vision_Synthese.Size = New Size(230, 40)
        btn_Vision_Synthese.TabIndex = 10
        btn_Vision_Synthese.Text = "Vision Synthétiques"
        btn_Vision_Synthese.UseVisualStyleBackColor = True
        ' 
        ' btn_Historique_Visites
        ' 
        btn_Historique_Visites.Font = New Font("Spline Sans Mono", 14.0F)
        btn_Historique_Visites.Location = New Point(10, 160)
        btn_Historique_Visites.Name = "btn_Historique_Visites"
        btn_Historique_Visites.Size = New Size(230, 40)
        btn_Historique_Visites.TabIndex = 9
        btn_Historique_Visites.Text = "Historique Visites"
        btn_Historique_Visites.UseVisualStyleBackColor = True
        ' 
        ' PanelAffichage
        ' 
        PanelAffichage.Dock = DockStyle.Fill
        PanelAffichage.Location = New Point(250, 60)
        PanelAffichage.Name = "PanelAffichage"
        PanelAffichage.Size = New Size(819, 573)
        PanelAffichage.TabIndex = 3
        ' 
        ' btn_exit_Panel
        ' 
        btn_exit_Panel.Location = New Point(1017, 12)
        btn_exit_Panel.Name = "btn_exit_Panel"
        btn_exit_Panel.Size = New Size(40, 40)
        btn_exit_Panel.TabIndex = 10
        ' 
        ' btn_logout_Panel
        ' 
        btn_logout_Panel.Location = New Point(835, 12)
        btn_logout_Panel.Name = "btn_logout_Panel"
        btn_logout_Panel.Size = New Size(163, 40)
        btn_logout_Panel.TabIndex = 9
        ' 
        ' Visiteur
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoSize = True
        AutoValidate = AutoValidate.EnablePreventFocusChange
        ClientSize = New Size(1069, 633)
        Controls.Add(PanelAffichage)
        Controls.Add(Panel2)
        Controls.Add(PanelHeader)
        FormBorderStyle = FormBorderStyle.None
        Name = "Visiteur"
        Text = "Visiteur"
        PanelHeader.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelHeader As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btn_Vision_Synthese As Button
    Friend WithEvents btn_Historique_Visites As Button
    Friend WithEvents btn_Compte_Rendu As Button
    Friend WithEvents btn_Deconnexion As Button
    Friend WithEvents btn_exit As Button
    Friend WithEvents lbl_nom As Label
    Friend WithEvents PanelAffichage As Panel
    Friend WithEvents btn_exit_Panel As Panel
    Friend WithEvents btn_logout_Panel As Panel
End Class
