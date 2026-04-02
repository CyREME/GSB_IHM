<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Login_label = New Label()
        Panel1 = New Panel()
        Txt_Username = New TextBox()
        Panel2 = New Panel()
        PictureBox1 = New PictureBox()
        Panel3 = New Panel()
        PictureBox2 = New PictureBox()
        Panel4 = New Panel()
        Txt_Password = New TextBox()
        PanelHeader = New Panel()
        btn_exit_Panel = New Panel()
        Panel6 = New Panel()
        btn_login = New Button()
        Panel1.SuspendLayout()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        Panel3.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        Panel4.SuspendLayout()
        PanelHeader.SuspendLayout()
        Panel6.SuspendLayout()
        SuspendLayout()
        ' 
        ' Login_label
        ' 
        Login_label.Dock = DockStyle.Fill
        Login_label.Font = New Font("Spline Sans Mono", 38F)
        Login_label.ForeColor = Color.White
        Login_label.Location = New Point(0, 0)
        Login_label.Name = "Login_label"
        Login_label.Size = New Size(721, 100)
        Login_label.TabIndex = 0
        Login_label.Text = "Login"
        Login_label.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.Anchor = AnchorStyles.Top
        Panel1.BackColor = Color.White
        Panel1.Controls.Add(Txt_Username)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(225, 96)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(275, 56)
        Panel1.TabIndex = 1
        ' 
        ' Txt_Username
        ' 
        Txt_Username.BorderStyle = BorderStyle.None
        Txt_Username.Font = New Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_Username.Location = New Point(62, 12)
        Txt_Username.Name = "Txt_Username"
        Txt_Username.Size = New Size(200, 32)
        Txt_Username.TabIndex = 3
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(83), CByte(175), CByte(255))
        Panel2.Controls.Add(PictureBox1)
        Panel2.Location = New Point(4, 4)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(47, 47)
        Panel2.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(5, 5)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(37, 37)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(83), CByte(175), CByte(255))
        Panel3.Controls.Add(PictureBox2)
        Panel3.Location = New Point(4, 4)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(47, 47)
        Panel3.TabIndex = 2
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(5, 5)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(37, 37)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Panel4
        ' 
        Panel4.Anchor = AnchorStyles.Bottom
        Panel4.BackColor = Color.White
        Panel4.Controls.Add(Txt_Password)
        Panel4.Controls.Add(Panel3)
        Panel4.Location = New Point(225, 206)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(275, 56)
        Panel4.TabIndex = 2
        ' 
        ' Txt_Password
        ' 
        Txt_Password.BorderStyle = BorderStyle.None
        Txt_Password.Font = New Font("Arial Rounded MT Bold", 20.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Txt_Password.Location = New Point(62, 12)
        Txt_Password.Name = "Txt_Password"
        Txt_Password.Size = New Size(200, 32)
        Txt_Password.TabIndex = 3
        ' 
        ' PanelHeader
        ' 
        PanelHeader.Controls.Add(btn_exit_Panel)
        PanelHeader.Controls.Add(Login_label)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(721, 100)
        PanelHeader.TabIndex = 3
        ' 
        ' btn_exit_Panel
        ' 
        btn_exit_Panel.Location = New Point(653, 12)
        btn_exit_Panel.Name = "btn_exit_Panel"
        btn_exit_Panel.Size = New Size(56, 56)
        btn_exit_Panel.TabIndex = 1
        ' 
        ' Panel6
        ' 
        Panel6.Anchor = AnchorStyles.None
        Panel6.Controls.Add(btn_login)
        Panel6.Controls.Add(Panel1)
        Panel6.Controls.Add(Panel4)
        Panel6.Location = New Point(0, 99)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(721, 505)
        Panel6.TabIndex = 4
        ' 
        ' btn_login
        ' 
        btn_login.Font = New Font("Spline Sans Mono", 18F)
        btn_login.ForeColor = Color.FromArgb(CByte(83), CByte(175), CByte(255))
        btn_login.Location = New Point(229, 319)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(271, 46)
        btn_login.TabIndex = 3
        btn_login.Text = "SE CONNECTER"
        btn_login.UseVisualStyleBackColor = True
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(83), CByte(175), CByte(255))
        ClientSize = New Size(721, 602)
        Controls.Add(PanelHeader)
        Controls.Add(Panel6)
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        Text = "Login"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        Panel2.ResumeLayout(False)
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        Panel3.ResumeLayout(False)
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        Panel4.ResumeLayout(False)
        Panel4.PerformLayout()
        PanelHeader.ResumeLayout(False)
        Panel6.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Login_label As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Txt_Username As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Txt_Password As TextBox
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btn_login As Button
    Friend WithEvents btn_exit_Panel As Panel
End Class
