<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Delegue
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
        Login_label = New Label()
        FlowLayoutPanel1 = New FlowLayoutPanel()
        SuspendLayout()
        ' 
        ' Login_label
        ' 
        Login_label.Anchor = AnchorStyles.Top
        Login_label.AutoSize = True
        Login_label.Font = New Font("Arial Rounded MT Bold", 24F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Login_label.ForeColor = SystemColors.ButtonHighlight
        Login_label.Location = New Point(293, 38)
        Login_label.Name = "Login_label"
        Login_label.Size = New Size(103, 37)
        Login_label.TabIndex = 0
        Login_label.Text = "Login"
        Login_label.TextAlign = ContentAlignment.TopCenter
        ' 
        ' FlowLayoutPanel1
        ' 
        FlowLayoutPanel1.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        FlowLayoutPanel1.Location = New Point(201, 178)
        FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        FlowLayoutPanel1.Size = New Size(298, 288)
        FlowLayoutPanel1.TabIndex = 1
        ' 
        ' Delegue
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(83), CByte(175), CByte(255))
        ClientSize = New Size(721, 602)
        Controls.Add(FlowLayoutPanel1)
        Controls.Add(Login_label)
        FormBorderStyle = FormBorderStyle.None
        Name = "Delegue"
        Text = "Delegue"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Login_label As Label
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
End Class
