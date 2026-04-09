<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VueEquipeVisiteurs
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
        Tab = New DataGridView()
        lbl_annee = New Label()
        Liste_Annee = New ComboBox()
        CType(Tab, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Tab
        ' 
        Tab.AllowUserToAddRows = False
        Tab.AllowUserToDeleteRows = False
        Tab.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Tab.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Tab.Location = New Point(25, 95)
        Tab.Margin = New Padding(4, 3, 4, 3)
        Tab.Name = "Tab"
        Tab.ReadOnly = True
        Tab.Size = New Size(769, 444)
        Tab.TabIndex = 5
        ' 
        ' lbl_annee
        ' 
        lbl_annee.AutoSize = True
        lbl_annee.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        lbl_annee.ForeColor = Color.FromArgb(CByte(45), CByte(52), CByte(70))
        lbl_annee.Location = New Point(25, 26)
        lbl_annee.Name = "lbl_annee"
        lbl_annee.Size = New Size(141, 21)
        lbl_annee.TabIndex = 6
        lbl_annee.Text = "Filtrer par année :"
        ' 
        ' Liste_Annee
        ' 
        Liste_Annee.DropDownStyle = ComboBoxStyle.DropDownList
        Liste_Annee.Font = New Font("Segoe UI", 12.0F)
        Liste_Annee.FormattingEnabled = True
        Liste_Annee.Location = New Point(25, 53)
        Liste_Annee.Name = "Liste_Annee"
        Liste_Annee.Size = New Size(150, 29)
        Liste_Annee.TabIndex = 7
        ' 
        ' VueEquipeVisiteurs
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
        Controls.Add(Liste_Annee)
        Controls.Add(lbl_annee)
        Controls.Add(Tab)
        Name = "VueEquipeVisiteurs"
        Size = New Size(819, 573)
        CType(Tab, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Tab As DataGridView
    Friend WithEvents lbl_annee As Label
    Friend WithEvents Liste_Annee As ComboBox

End Class