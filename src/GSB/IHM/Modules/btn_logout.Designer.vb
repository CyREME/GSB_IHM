<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class btn_logout
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
        btn_Deconnexion = New Button()
        SuspendLayout()
        ' 
        ' btn_Deconnexion
        ' 
        btn_Deconnexion.BackColor = Color.White
        btn_Deconnexion.Cursor = Cursors.Hand
        btn_Deconnexion.Dock = DockStyle.Fill
        btn_Deconnexion.FlatAppearance.BorderSize = 0
        btn_Deconnexion.FlatStyle = FlatStyle.Flat
        btn_Deconnexion.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        btn_Deconnexion.ForeColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        btn_Deconnexion.Location = New Point(0, 0)
        btn_Deconnexion.Name = "btn_Deconnexion"
        btn_Deconnexion.Size = New Size(163, 40)
        btn_Deconnexion.TabIndex = 4
        btn_Deconnexion.Text = "Se déconnecter"
        btn_Deconnexion.UseVisualStyleBackColor = False
        ' 
        ' btn_logout
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(btn_Deconnexion)
        Name = "btn_logout"
        Size = New Size(163, 40)
        ResumeLayout(False)
    End Sub

    Friend WithEvents btn_Deconnexion As Button

End Class