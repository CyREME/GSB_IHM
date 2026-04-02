<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class btn_logout
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
        btn_Deconnexion = New Button()
        SuspendLayout()
        ' 
        ' btn_Deconnexion
        ' 
        btn_Deconnexion.Anchor = AnchorStyles.Top
        btn_Deconnexion.BackColor = Color.White
        btn_Deconnexion.BackgroundImageLayout = ImageLayout.Stretch
        btn_Deconnexion.Font = New Font("Spline Sans Mono", 14F)
        btn_Deconnexion.ForeColor = Color.Black
        btn_Deconnexion.ImageAlign = ContentAlignment.TopCenter
        btn_Deconnexion.Location = New Point(0, 0)
        btn_Deconnexion.Margin = New Padding(4, 3, 4, 3)
        btn_Deconnexion.Name = "btn_Deconnexion"
        btn_Deconnexion.Size = New Size(163, 40)
        btn_Deconnexion.TabIndex = 4
        btn_Deconnexion.Text = "Deconnexion"
        btn_Deconnexion.UseVisualStyleBackColor = False
        ' 
        ' btn_logout
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(btn_Deconnexion)
        Name = "btn_logout"
        Size = New Size(163, 40)
        ResumeLayout(False)
    End Sub

    Friend WithEvents btn_Deconnexion As Button

End Class
