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
        Panel1 = New Panel()
        Panel3 = New Panel()
        Panel2 = New Panel()
        Button1 = New Button()
        Button3 = New Button()
        Button2 = New Button()
        FileSystemWatcher1 = New IO.FileSystemWatcher()
        DateTimePicker1 = New DateTimePicker()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        ComboBox1 = New ComboBox()
        ComboBox2 = New ComboBox()
        CheckedListBox1 = New CheckedListBox()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        NumericUpDown1 = New NumericUpDown()
        DataGridView1 = New DataGridView()
        Button4 = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).BeginInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(83), CByte(175), CByte(225))
        Panel1.BackgroundImageLayout = ImageLayout.None
        Panel1.BorderStyle = BorderStyle.FixedSingle
        Panel1.Controls.Add(Panel3)
        Panel1.Dock = DockStyle.Top
        Panel1.ForeColor = Color.CornflowerBlue
        Panel1.Location = New Point(0, 0)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1069, 60)
        Panel1.TabIndex = 1
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.White
        Panel3.BorderStyle = BorderStyle.FixedSingle
        Panel3.Location = New Point(879, 11)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(177, 38)
        Panel3.TabIndex = 0
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.SteelBlue
        Panel2.BorderStyle = BorderStyle.FixedSingle
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button2)
        Panel2.Location = New Point(0, 60)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(200, 578)
        Panel2.TabIndex = 2
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(55, 54)
        Button1.Name = "Button1"
        Button1.Size = New Size(95, 39)
        Button1.TabIndex = 8
        Button1.Text = "Compte Rendu"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Location = New Point(55, 368)
        Button3.Name = "Button3"
        Button3.Size = New Size(91, 38)
        Button3.TabIndex = 10
        Button3.Text = "Vision Synthétiques"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button2
        ' 
        Button2.Location = New Point(55, 210)
        Button2.Name = "Button2"
        Button2.Size = New Size(89, 38)
        Button2.TabIndex = 9
        Button2.Text = "Historique"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' FileSystemWatcher1
        ' 
        FileSystemWatcher1.EnableRaisingEvents = True
        FileSystemWatcher1.SynchronizingObject = Me
        ' 
        ' DateTimePicker1
        ' 
        DateTimePicker1.Location = New Point(380, 87)
        DateTimePicker1.Name = "DateTimePicker1"
        DateTimePicker1.Size = New Size(200, 23)
        DateTimePicker1.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(225, 93)
        Label1.Name = "Label1"
        Label1.Size = New Size(62, 15)
        Label1.TabIndex = 4
        Label1.Text = "Date Visite"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(225, 127)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 15)
        Label2.TabIndex = 5
        Label2.Text = "Praticien vu"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(225, 160)
        Label3.Name = "Label3"
        Label3.Size = New Size(67, 15)
        Label3.TabIndex = 6
        Label3.Text = "Motif Visite"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(225, 197)
        Label4.Name = "Label4"
        Label4.Size = New Size(104, 15)
        Label4.TabIndex = 7
        Label4.Text = "Produits Présentés"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(225, 233)
        Label5.Name = "Label5"
        Label5.Size = New Size(84, 15)
        Label5.TabIndex = 8
        Label5.Text = "Détails Produit"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(225, 271)
        Label6.Name = "Label6"
        Label6.Size = New Size(64, 15)
        Label6.TabIndex = 9
        Label6.Text = "Bilan Visite"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(225, 369)
        Label7.Name = "Label7"
        Label7.Size = New Size(138, 15)
        Label7.TabIndex = 10
        Label7.Text = "Coefficiant de Confiance"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(225, 405)
        Label8.Name = "Label8"
        Label8.Size = New Size(149, 15)
        Label8.TabIndex = 11
        Label8.Text = "Liste échantillons/Quantité"
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Location = New Point(380, 119)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(121, 23)
        ComboBox1.TabIndex = 12
        ' 
        ' ComboBox2
        ' 
        ComboBox2.FormattingEnabled = True
        ComboBox2.Location = New Point(380, 152)
        ComboBox2.Name = "ComboBox2"
        ComboBox2.Size = New Size(121, 23)
        ComboBox2.TabIndex = 13
        ' 
        ' CheckedListBox1
        ' 
        CheckedListBox1.FormattingEnabled = True
        CheckedListBox1.Location = New Point(380, 190)
        CheckedListBox1.Name = "CheckedListBox1"
        CheckedListBox1.Size = New Size(120, 22)
        CheckedListBox1.TabIndex = 14
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(380, 233)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(100, 23)
        TextBox1.TabIndex = 15
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(380, 271)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(267, 23)
        TextBox2.TabIndex = 16
        ' 
        ' NumericUpDown1
        ' 
        NumericUpDown1.Location = New Point(380, 361)
        NumericUpDown1.Name = "NumericUpDown1"
        NumericUpDown1.Size = New Size(120, 23)
        NumericUpDown1.TabIndex = 17
        ' 
        ' DataGridView1
        ' 
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(380, 405)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.Size = New Size(125, 62)
        DataGridView1.TabIndex = 18
        ' 
        ' Button4
        ' 
        Button4.Location = New Point(396, 516)
        Button4.Name = "Button4"
        Button4.Size = New Size(75, 23)
        Button4.TabIndex = 19
        Button4.Text = "VALIDER"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Visiteur
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        AutoValidate = AutoValidate.EnablePreventFocusChange
        ClientSize = New Size(1069, 634)
        Controls.Add(Button4)
        Controls.Add(DataGridView1)
        Controls.Add(NumericUpDown1)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(CheckedListBox1)
        Controls.Add(ComboBox2)
        Controls.Add(ComboBox1)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DateTimePicker1)
        Controls.Add(Panel2)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Visiteur"
        Text = "Visiteur"
        Panel1.ResumeLayout(False)
        Panel2.ResumeLayout(False)
        CType(FileSystemWatcher1, ComponentModel.ISupportInitialize).EndInit()
        CType(NumericUpDown1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents FileSystemWatcher1 As IO.FileSystemWatcher
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents CheckedListBox1 As CheckedListBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
End Class
