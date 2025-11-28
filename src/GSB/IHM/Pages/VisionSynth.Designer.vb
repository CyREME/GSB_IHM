<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VisionSynth
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
        DataGridView2 = New DataGridView()
        DataGridView1 = New DataGridView()
        lbl_echantillon = New Label()
        DatePickerMin = New DateTimePicker()
        Label1 = New Label()
        DatePickerMax = New DateTimePicker()
        CType(DataGridView2, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' DataGridView2
        ' 
        DataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView2.Location = New Point(431, 115)
        DataGridView2.Name = "DataGridView2"
        DataGridView2.Size = New Size(355, 432)
        DataGridView2.TabIndex = 6
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(33, 115)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(355, 432)
        DataGridView1.TabIndex = 5
        ' 
        ' lbl_echantillon
        ' 
        lbl_echantillon.AutoSize = True
        lbl_echantillon.Font = New Font("Spline Sans Mono", 9F)
        lbl_echantillon.Location = New Point(33, 56)
        lbl_echantillon.Name = "lbl_echantillon"
        lbl_echantillon.Size = New Size(162, 17)
        lbl_echantillon.TabIndex = 4
        lbl_echantillon.Text = "Periode d'anlayse : De"
        ' 
        ' DatePickerMin
        ' 
        DatePickerMin.Location = New Point(201, 53)
        DatePickerMin.Name = "DatePickerMin"
        DatePickerMin.Size = New Size(200, 23)
        DatePickerMin.TabIndex = 7
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Spline Sans Mono", 9F)
        Label1.Location = New Point(407, 56)
        Label1.Name = "Label1"
        Label1.Size = New Size(22, 17)
        Label1.TabIndex = 4
        Label1.Text = "au"
        ' 
        ' DatePickerMax
        ' 
        DatePickerMax.Location = New Point(435, 53)
        DatePickerMax.Name = "DatePickerMax"
        DatePickerMax.Size = New Size(200, 23)
        DatePickerMax.TabIndex = 7
        ' 
        ' VisionSynth
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(DatePickerMax)
        Controls.Add(DatePickerMin)
        Controls.Add(DataGridView2)
        Controls.Add(DataGridView1)
        Controls.Add(Label1)
        Controls.Add(lbl_echantillon)
        Name = "VisionSynth"
        Size = New Size(819, 573)
        CType(DataGridView2, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents lbl_echantillon As Label
    Friend WithEvents DatePickerMin As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents DatePickerMax As DateTimePicker

End Class
