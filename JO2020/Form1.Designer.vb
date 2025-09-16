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
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        Label3 = New Label()
        Date_Jour = New TextBox()
        Label5 = New Label()
        GroupBox1 = New GroupBox()
        Label10 = New Label()
        TextBox5 = New TextBox()
        RadioButton4 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        ComboBox1 = New ComboBox()
        Label9 = New Label()
        RadioButton1 = New RadioButton()
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
        Label1.Location = New Point(21, 69)
        Label1.Name = "Label1"
        Label1.Size = New Size(34, 15)
        Label1.TabIndex = 0
        Label1.Text = "Nom"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(21, 120)
        Label2.Name = "Label2"
        Label2.Size = New Size(54, 15)
        Label2.TabIndex = 1
        Label2.Text = "Prénoms"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(101, 120)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(348, 23)
        TextBox1.TabIndex = 2
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(101, 69)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(348, 23)
        TextBox2.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(21, 275)
        Label3.Name = "Label3"
        Label3.Size = New Size(53, 15)
        Label3.TabIndex = 4
        Label3.Text = "Dicipline"
        ' 
        ' Date_Jour
        ' 
        Date_Jour.Enabled = False
        Date_Jour.Location = New Point(101, 234)
        Date_Jour.MaxLength = 2
        Date_Jour.Name = "Date_Jour"
        Date_Jour.Size = New Size(36, 23)
        Date_Jour.TabIndex = 7
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(21, 237)
        Label5.Name = "Label5"
        Label5.Size = New Size(31, 15)
        Label5.TabIndex = 10
        Label5.Text = "Date"
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Label10)
        GroupBox1.Controls.Add(TextBox5)
        GroupBox1.Controls.Add(RadioButton4)
        GroupBox1.Controls.Add(RadioButton3)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(ComboBox1)
        GroupBox1.Controls.Add(Label9)
        GroupBox1.Controls.Add(RadioButton1)
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
        GroupBox1.Controls.Add(TextBox2)
        GroupBox1.Controls.Add(TextBox1)
        GroupBox1.Location = New Point(12, 74)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(461, 488)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Location = New Point(335, 363)
        Label10.Name = "Label10"
        Label10.Size = New Size(36, 15)
        Label10.TabIndex = 25
        Label10.Text = "Score"
        ' 
        ' TextBox5
        ' 
        TextBox5.Location = New Point(377, 362)
        TextBox5.Name = "TextBox5"
        TextBox5.Size = New Size(59, 23)
        TextBox5.TabIndex = 24
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.CheckAlign = ContentAlignment.MiddleRight
        RadioButton4.Location = New Point(201, 447)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(61, 19)
        RadioButton4.TabIndex = 23
        RadioButton4.TabStop = True
        RadioButton4.Text = "Bronze"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.CheckAlign = ContentAlignment.MiddleRight
        RadioButton3.Location = New Point(201, 422)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(61, 19)
        RadioButton3.TabIndex = 22
        RadioButton3.TabStop = True
        RadioButton3.Text = "Argent"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.CheckAlign = ContentAlignment.MiddleRight
        RadioButton2.Location = New Point(201, 397)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(61, 19)
        RadioButton2.TabIndex = 21
        RadioButton2.TabStop = True
        RadioButton2.Text = "Or"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' ComboBox1
        ' 
        ComboBox1.FormattingEnabled = True
        ComboBox1.Items.AddRange(New Object() {"Badminton", "Athlétisme", "Aviron"})
        ComboBox1.Location = New Point(101, 272)
        ComboBox1.Name = "ComboBox1"
        ComboBox1.Size = New Size(348, 23)
        ComboBox1.TabIndex = 20
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Location = New Point(171, 365)
        Label9.Name = "Label9"
        Label9.Size = New Size(52, 15)
        Label9.TabIndex = 19
        Label9.Text = "Médaille"
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.CheckAlign = ContentAlignment.MiddleRight
        RadioButton1.Location = New Point(21, 363)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(74, 19)
        RadioButton1.TabIndex = 18
        RadioButton1.TabStop = True
        RadioButton1.Text = "Abandon"
        RadioButton1.TextImageRelation = TextImageRelation.TextAboveImage
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' DateN
        ' 
        DateN.AutoSize = True
        DateN.Location = New Point(282, 237)
        DateN.Name = "DateN"
        DateN.Size = New Size(0, 15)
        DateN.TabIndex = 16
        ' 
        ' Date_An
        ' 
        Date_An.Location = New Point(185, 234)
        Date_An.MaxLength = 4
        Date_An.Name = "Date_An"
        Date_An.Size = New Size(65, 23)
        Date_An.TabIndex = 15
        ' 
        ' Date_Mois
        ' 
        Date_Mois.Enabled = False
        Date_Mois.Location = New Point(143, 234)
        Date_Mois.MaxLength = 2
        Date_Mois.Name = "Date_Mois"
        Date_Mois.Size = New Size(36, 23)
        Date_Mois.TabIndex = 14
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.ForeColor = Color.DarkGreen
        Label8.Location = New Point(6, 178)
        Label8.Name = "Label8"
        Label8.Size = New Size(110, 30)
        Label8.TabIndex = 13
        Label8.Text = "Naissance"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.ForeColor = Color.DarkGreen
        Label7.Location = New Point(6, 19)
        Label7.Name = "Label7"
        Label7.Size = New Size(96, 30)
        Label7.TabIndex = 12
        Label7.Text = "État civil"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 30F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = Color.DarkGreen
        Label6.Location = New Point(171, 9)
        Label6.Name = "Label6"
        Label6.Size = New Size(174, 54)
        Label6.TabIndex = 13
        Label6.Text = "JO 2020"
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.IndianRed
        Button1.BackgroundImageLayout = ImageLayout.None
        Button1.FlatAppearance.BorderColor = Color.FromArgb(CByte(255), CByte(128), CByte(128))
        Button1.FlatAppearance.BorderSize = 0
        Button1.ForeColor = Color.White
        Button1.Location = New Point(213, 578)
        Button1.Margin = New Padding(0)
        Button1.Name = "Button1"
        Button1.Size = New Size(84, 29)
        Button1.TabIndex = 14
        Button1.Text = "Valider"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(480, 631)
        Controls.Add(Button1)
        Controls.Add(Label6)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "Form1"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
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
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Button1 As Button

End Class
