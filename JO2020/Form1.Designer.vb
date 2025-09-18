<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        PrenomInput = New TextBox()
        NomInput = New TextBox()
        Label3 = New Label()
        Date_Jour = New TextBox()
        Label5 = New Label()
        GroupBox1 = New GroupBox()
        Label10 = New Label()
        Score = New TextBox()
        Medaille_Bronze = New RadioButton()
        Medaille_Argent = New RadioButton()
        Medaille_Or = New RadioButton()
        Selection_Sport = New ComboBox()
        Label9 = New Label()
        Abandon = New RadioButton()
        DateN = New Label()
        Date_An = New TextBox()
        Date_Mois = New TextBox()
        Label8 = New Label()
        Label7 = New Label()
        Label6 = New Label()
        Button1 = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(24, 92)
        Label1.Name = "Label1"
        Label1.Size = New Size(56, 20)
        Label1.TabIndex = 0
        Label1.Text = "Nom  *"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(24, 160)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 20)
        Label2.TabIndex = 1
        Label2.Text = "Prénoms  *"
        ' 
        ' PrenomInput
        ' 
        PrenomInput.Location = New Point(115, 160)
        PrenomInput.Margin = New Padding(3, 4, 3, 4)
        PrenomInput.Name = "PrenomInput"
        PrenomInput.Size = New Size(397, 27)
        PrenomInput.TabIndex = 2
        ' 
        ' NomInput
        ' 
        NomInput.Location = New Point(115, 92)
        NomInput.Margin = New Padding(3, 4, 3, 4)
        NomInput.Name = "NomInput"
        NomInput.Size = New Size(397, 27)
        NomInput.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(24, 367)
        Label3.Name = "Label3"
        Label3.Size = New Size(82, 20)
        Label3.TabIndex = 4
        Label3.Text = "Dicipline  *"
        ' 
        ' Date_Jour
        ' 
        Date_Jour.Enabled = False
        Date_Jour.Location = New Point(115, 312)
        Date_Jour.Margin = New Padding(3, 4, 3, 4)
        Date_Jour.MaxLength = 2
        Date_Jour.Name = "Date_Jour"
        Date_Jour.Size = New Size(41, 27)
        Date_Jour.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(24, 316)
        Label5.Name = "Label5"
        Label5.Size = New Size(55, 20)
        Label5.TabIndex = 10
        Label5.Text = "Date  *"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(Score)
        GroupBox1.Controls.Add(Medaille_Bronze)
        GroupBox1.Controls.Add(Medaille_Argent)
        GroupBox1.Controls.Add(Medaille_Or)
        GroupBox1.Controls.Add(Selection_Sport)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(Abandon)
        GroupBox1.Controls.Add(DateN)
        GroupBox1.Controls.Add(Date_An)
        GroupBox1.Controls.Add(Date_Mois)
        GroupBox1.Controls.Add(Label8)
        GroupBox1.Controls.Add(Label7)
        GroupBox1.Controls.Add(Label1)
        GroupBox1.Controls.Add(Label2)
        GroupBox1.Controls.Add(Label5)
        GroupBox1.Controls.Add(Label3)
        GroupBox1.Controls.Add(Date_Jour)
        GroupBox1.Controls.Add(NomInput)
        GroupBox1.Controls.Add(PrenomInput)
        GroupBox1.Location = New Point(14, 99)
        GroupBox1.Margin = New Padding(3, 4, 3, 4)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Padding = New Padding(3, 4, 3, 4)
        GroupBox1.Size = New Size(527, 651)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(383, 484)
        Label10.Name = "Label10"
        Label10.Size = New Size(46, 20)
        Label10.TabIndex = 25
        Label10.Text = "Score"
        ' 
        ' Score
        ' 
        Score.Location = New Point(431, 483)
        Score.Margin = New Padding(3, 4, 3, 4)
        Score.Name = "Score"
        Score.Size = New Size(67, 27)
        Score.TabIndex = 24
        ' 
        ' Medaille_Bronze
        ' 
        Medaille_Bronze.AutoSize = True
        Medaille_Bronze.CheckAlign = ContentAlignment.MiddleRight
        Medaille_Bronze.Location = New Point(230, 596)
        Medaille_Bronze.Margin = New Padding(3, 4, 3, 4)
        Medaille_Bronze.Name = "Medaille_Bronze"
        Medaille_Bronze.Size = New Size(76, 24)
        Medaille_Bronze.TabIndex = 23
        Medaille_Bronze.TabStop = True
        Medaille_Bronze.Text = "Bronze"
        Medaille_Bronze.UseVisualStyleBackColor = True
        ' 
        ' Medaille_Argent
        ' 
        Medaille_Argent.AutoSize = True
        Medaille_Argent.CheckAlign = ContentAlignment.MiddleRight
        Medaille_Argent.Location = New Point(230, 563)
        Medaille_Argent.Margin = New Padding(3, 4, 3, 4)
        Medaille_Argent.Name = "Medaille_Argent"
        Medaille_Argent.Size = New Size(75, 24)
        Medaille_Argent.TabIndex = 22
        Medaille_Argent.TabStop = True
        Medaille_Argent.Text = "Argent"
        Medaille_Argent.UseVisualStyleBackColor = True
        ' 
        ' Medaille_Or
        ' 
        Medaille_Or.CheckAlign = ContentAlignment.MiddleRight
        Medaille_Or.Location = New Point(230, 529)
        Medaille_Or.Margin = New Padding(3, 4, 3, 4)
        Medaille_Or.Name = "Medaille_Or"
        Medaille_Or.Size = New Size(70, 25)
        Medaille_Or.TabIndex = 21
        Medaille_Or.TabStop = True
        Medaille_Or.Text = "Or"
        Medaille_Or.UseVisualStyleBackColor = True
        ' 
        ' Selection_Sport
        ' 
        Selection_Sport.DropDownStyle = ComboBoxStyle.DropDownList
        Selection_Sport.FormattingEnabled = True
        Selection_Sport.Items.AddRange(New Object() {"Badminton", "Athlétisme", "Aviron", "BasketBall", "Football"})
        Selection_Sport.Location = New Point(115, 363)
        Selection_Sport.Margin = New Padding(3, 4, 3, 4)
        Selection_Sport.Name = "Selection_Sport"
        Selection_Sport.Size = New Size(397, 28)
        Selection_Sport.TabIndex = 20
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(195, 487)
        Label9.Name = "Label9"
        Label9.Size = New Size(67, 20)
        Label9.TabIndex = 19
        Label9.Text = "Médaille"
        ' 
        ' Abandon
        ' 
        Abandon.AutoSize = True
        Abandon.CheckAlign = ContentAlignment.MiddleRight
        Abandon.Location = New Point(24, 484)
        Abandon.Margin = New Padding(3, 4, 3, 4)
        Abandon.Name = "Abandon"
        Abandon.Size = New Size(91, 24)
        Abandon.TabIndex = 18
        Abandon.TabStop = True
        Abandon.Text = "Abandon"
        Abandon.TextImageRelation = TextImageRelation.TextAboveImage
        Abandon.UseVisualStyleBackColor = True
        ' 
        ' DateN
        ' 
        DateN.AutoSize = True
        DateN.Location = New Point(322, 316)
        DateN.Name = "DateN"
        DateN.Size = New Size(0, 20)
        DateN.TabIndex = 16
        ' 
        ' Date_An
        ' 
        Date_An.Location = New Point(211, 312)
        Date_An.Margin = New Padding(3, 4, 3, 4)
        Date_An.MaxLength = 4
        Date_An.Name = "Date_An"
        Date_An.Size = New Size(74, 27)
        Date_An.TabIndex = 15
        ' 
        ' Date_Mois
        ' 
        Date_Mois.Enabled = False
        Date_Mois.Location = New Point(163, 312)
        Date_Mois.Margin = New Padding(3, 4, 3, 4)
        Date_Mois.MaxLength = 2
        Date_Mois.Name = "Date_Mois"
        Date_Mois.Size = New Size(41, 27)
        Date_Mois.TabIndex = 14
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.DarkGreen
        Label8.Location = New Point(7, 237)
        Label8.Name = "Label8"
        Label8.Size = New Size(144, 37)
        Label8.TabIndex = 13
        Label8.Text = "Naissance"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.DarkGreen
        Label7.Location = New Point(7, 25)
        Label7.Name = "Label7"
        Label7.Size = New Size(127, 37)
        Label7.TabIndex = 12
        Label7.Text = "État civil"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.DarkGreen
        Label6.Location = New Point(195, 12)
        Label6.Name = "Label6"
        Label6.Size = New Size(219, 67)
        Label6.TabIndex = 13
        Label6.Text = "JO 2020"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.IndianRed
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.Enabled = False
        Button1.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Button1.FlatAppearance.BorderSize = 0
        Button1.ForeColor = Color.White
        Button1.Location = New Point(243, 771)
        Button1.Margin = New Padding(0)
        Button1.Name = "Button1"
        Button1.Size = New Size(96, 39)
        Button1.TabIndex = 14
        Button1.Text = "Valider"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(549, 841)
        Controls.Add(Button1)
        Controls.Add(Label6)
        Controls.Add(GroupBox1)
        Margin = New Padding(3, 4, 3, 4)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PrenomInput As TextBox
    Friend WithEvents NomInput As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Date_Jour As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents DateN As Label
    Friend WithEvents Date_An As TextBox
    Friend WithEvents Date_Mois As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Abandon As RadioButton
    Friend WithEvents Selection_Sport As ComboBox
    Friend WithEvents Medaille_Or As RadioButton
    Friend WithEvents Medaille_Bronze As RadioButton
    Friend WithEvents Medaille_Argent As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents Score As TextBox
    Friend WithEvents Button1 As Button

End Class
