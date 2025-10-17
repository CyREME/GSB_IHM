<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Délégué
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
        Panel1 = New Panel()
        Panel2 = New Panel()
        Panel3 = New Panel()
        Panel4 = New Panel()
        Panel5 = New Panel()
        Panel6 = New Panel()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(83), CByte(175), CByte(225))
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Panel3)
        Panel1.Controls.Add(Panel2)
        Panel1.Dock = DockStyle.Top
        Panel1.ForeColor = Color.CornflowerBlue
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1069, 60)
        Panel1.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.SteelBlue
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Location = New Point(0, 66)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(200, 578)
        Panel2.TabIndex = 3
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Location = New Point(880, 12)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(177, 38)
        Panel3.TabIndex = 4
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.SteelBlue
        Panel4.BorderStyle = BorderStyle.FixedSingle
        Panel4.Location = New Point(0, 60)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(200, 578)
        Panel4.TabIndex = 3
        ' 
        ' Panel5
        ' 
        Panel5.BackColor = SystemColors.ActiveBorder
        Panel5.BorderStyle = BorderStyle.FixedSingle
        Panel5.Location = New Point(228, 357)
        Panel5.Name = "Panel5"
        Panel5.Size = New Size(813, 252)
        Panel5.TabIndex = 4
        ' 
        ' Panel6
        ' 
        Panel6.BackColor = SystemColors.ActiveBorder
        Panel6.BorderStyle = BorderStyle.FixedSingle
        Panel6.Location = New Point(228, 83)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(813, 252)
        Panel6.TabIndex = 5
        ' 
        ' Délégué
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1069, 634)
        Controls.Add(Panel6)
        Controls.Add(Panel5)
        Controls.Add(Panel4)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Délégué"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Login"
        Panel1.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
End Class
