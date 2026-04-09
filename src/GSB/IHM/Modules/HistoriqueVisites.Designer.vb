<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class HistoriqueVisites
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
        Tableau_Historique = New DataGridView()
        Tableau_Details = New DataGridView()
        lbl_periode = New Label()
        DatePickerMin = New DateTimePicker()
        Label1 = New Label()
        DatePickerMax = New DateTimePicker()
        Txt_Bilan = New TextBox()
        lbl_bilan = New Label()
        lbl_echantillons = New Label()
        CType(Tableau_Historique, ComponentModel.ISupportInitialize).BeginInit()
        CType(Tableau_Details, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Tableau_Historique
        ' 
        Tableau_Historique.AllowUserToAddRows = False
        Tableau_Historique.AllowUserToDeleteRows = False
        Tableau_Historique.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Tableau_Historique.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Tableau_Historique.Location = New Point(33, 95)
        Tableau_Historique.Name = "Tableau_Historique"
        Tableau_Historique.ReadOnly = True
        Tableau_Historique.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Tableau_Historique.Size = New Size(400, 445)
        Tableau_Historique.TabIndex = 5
        ' 
        ' Tableau_Details
        ' 
        Tableau_Details.AllowUserToAddRows = False
        Tableau_Details.AllowUserToDeleteRows = False
        Tableau_Details.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        Tableau_Details.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Tableau_Details.Location = New Point(460, 310)
        Tableau_Details.Name = "Tableau_Details"
        Tableau_Details.ReadOnly = True
        Tableau_Details.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        Tableau_Details.Size = New Size(326, 230)
        Tableau_Details.TabIndex = 6
        ' 
        ' lbl_periode
        ' 
        lbl_periode.AutoSize = True
        lbl_periode.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        lbl_periode.ForeColor = Color.FromArgb(CByte(45), CByte(52), CByte(70))
        lbl_periode.Location = New Point(33, 40)
        lbl_periode.Name = "lbl_periode"
        lbl_periode.Size = New Size(160, 21)
        lbl_periode.TabIndex = 4
        lbl_periode.Text = "Période d'analyse : Du"
        ' 
        ' DatePickerMin
        ' 
        DatePickerMin.Font = New Font("Segoe UI", 10.0F)
        DatePickerMin.Location = New Point(195, 38)
        DatePickerMin.Name = "DatePickerMin"
        DatePickerMin.Size = New Size(200, 25)
        DatePickerMin.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Semibold", 12.0F, FontStyle.Bold)
        Label1.ForeColor = Color.FromArgb(CByte(45), CByte(52), CByte(70))
        Label1.Location = New Point(405, 40)
        Label1.Name = "Label1"
        Label1.Size = New Size(27, 21)
        Label1.TabIndex = 4
        Label1.Text = "au"
        ' 
        ' DatePickerMax
        ' 
        DatePickerMax.Font = New Font("Segoe UI", 10.0F)
        DatePickerMax.Location = New Point(440, 38)
        DatePickerMax.Name = "DatePickerMax"
        DatePickerMax.Size = New Size(200, 25)
        DatePickerMax.TabIndex = 7
        ' 
        ' lbl_bilan
        ' 
        lbl_bilan.AutoSize = True
        lbl_bilan.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        lbl_bilan.ForeColor = Color.FromArgb(CByte(83), CByte(175), CByte(255))
        lbl_bilan.Location = New Point(460, 95)
        lbl_bilan.Name = "lbl_bilan"
        lbl_bilan.Size = New Size(99, 19)
        lbl_bilan.TabIndex = 8
        lbl_bilan.Text = "Bilan de Visite"
        ' 
        ' Txt_Bilan
        ' 
        Txt_Bilan.BackColor = Color.White
        Txt_Bilan.Font = New Font("Segoe UI", 10.0F)
        Txt_Bilan.Location = New Point(460, 117)
        Txt_Bilan.Multiline = True
        Txt_Bilan.Name = "Txt_Bilan"
        Txt_Bilan.ReadOnly = True
        Txt_Bilan.ScrollBars = ScrollBars.Vertical
        Txt_Bilan.Size = New Size(326, 150)
        Txt_Bilan.TabIndex = 9
        ' 
        ' lbl_echantillons
        ' 
        lbl_echantillons.AutoSize = True
        lbl_echantillons.Font = New Font("Segoe UI Semibold", 10.0F, FontStyle.Bold)
        lbl_echantillons.ForeColor = Color.FromArgb(CByte(83), CByte(175), CByte(255))
        lbl_echantillons.Location = New Point(460, 288)
        lbl_echantillons.Name = "lbl_echantillons"
        lbl_echantillons.Size = New Size(147, 19)
        lbl_echantillons.TabIndex = 10
        lbl_echantillons.Text = "Échantillons distribués"
        ' 
        ' HistoriqueVisites
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
        Controls.Add(lbl_echantillons)
        Controls.Add(Txt_Bilan)
        Controls.Add(lbl_bilan)
        Controls.Add(DatePickerMax)
        Controls.Add(DatePickerMin)
        Controls.Add(Tableau_Details)
        Controls.Add(Tableau_Historique)
        Controls.Add(Label1)
        Controls.Add(lbl_periode)
        Name = "HistoriqueVisites"
        Size = New Size(819, 573)
        CType(Tableau_Historique, ComponentModel.ISupportInitialize).EndInit()
        CType(Tableau_Details, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Tableau_Historique As DataGridView
    Friend WithEvents Tableau_Details As DataGridView
    Friend WithEvents lbl_periode As Label
    Friend WithEvents DatePickerMin As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents DatePickerMax As DateTimePicker
    Friend WithEvents Txt_Bilan As TextBox
    Friend WithEvents lbl_bilan As Label
    Friend WithEvents lbl_echantillons As Label

End Class