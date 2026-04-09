<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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
        ' PanelHeader
        ' 
        PanelHeader.Controls.Add(btn_exit_Panel)
        PanelHeader.Dock = DockStyle.Top
        PanelHeader.Location = New Point(0, 0)
        PanelHeader.Name = "PanelHeader"
        PanelHeader.Size = New Size(721, 50)
        PanelHeader.TabIndex = 3
        ' 
        ' btn_exit_Panel
        ' 
        btn_exit_Panel.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btn_exit_Panel.Cursor = Cursors.Hand
        btn_exit_Panel.Location = New Point(665, 12)
        btn_exit_Panel.Name = "btn_exit_Panel"
        btn_exit_Panel.Size = New Size(35, 35)
        btn_exit_Panel.TabIndex = 1
        ' 
        ' Panel6
        ' 
        Panel6.Anchor = AnchorStyles.None
        Panel6.BackColor = Color.White
        Panel6.Controls.Add(Login_label)
        Panel6.Controls.Add(btn_login)
        Panel6.Controls.Add(Panel1)
        Panel6.Controls.Add(Panel4)
        Panel6.Location = New Point(160, 80)
        Panel6.Name = "Panel6"
        Panel6.Size = New Size(400, 430)
        Panel6.TabIndex = 4
        ' 
        ' Login_label
        ' 
        Login_label.Dock = DockStyle.Top
        Login_label.Font = New Font("Segoe UI", 24.0F, FontStyle.Bold)
        Login_label.ForeColor = Color.FromArgb(CByte(83), CByte(175), CByte(255))
        Login_label.Location = New Point(0, 0)
        Login_label.Name = "Login_label"
        Login_label.Size = New Size(400, 100)
        Login_label.TabIndex = 0
        Login_label.Text = "Connexion"
        Login_label.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
        Panel1.Controls.Add(Txt_Username)
        Panel1.Controls.Add(Panel2)
        Panel1.Location = New Point(50, 130)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(300, 47)
        Panel1.TabIndex = 1
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = Color.FromArgb(CByte(83), CByte(175), CByte(255))
        Panel2.Controls.Add(PictureBox1)
        Panel2.Dock = DockStyle.Left
        Panel2.Location = New Point(0, 0)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(47, 47)
        Panel2.TabIndex = 2
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(8, 8)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(30, 30)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Txt_Username
        ' 
        Txt_Username.BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
        Txt_Username.BorderStyle = BorderStyle.None
        Txt_Username.Font = New Font("Segoe UI", 14.25F)
        Txt_Username.ForeColor = Color.DimGray
        Txt_Username.Location = New Point(60, 10)
        Txt_Username.Name = "Txt_Username"
        Txt_Username.Size = New Size(220, 26)
        Txt_Username.TabIndex = 3
        ' 
        ' Panel4
        ' 
        Panel4.BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
        Panel4.Controls.Add(Txt_Password)
        Panel4.Controls.Add(Panel3)
        Panel4.Location = New Point(50, 200)
        Panel4.Name = "Panel4"
        Panel4.Size = New Size(300, 47)
        Panel4.TabIndex = 2
        ' 
        ' Panel3
        ' 
        Panel3.BackColor = Color.FromArgb(CByte(83), CByte(175), CByte(255))
        Panel3.Controls.Add(PictureBox2)
        Panel3.Dock = DockStyle.Left
        Panel3.Location = New Point(0, 0)
        Panel3.Name = "Panel3"
        Panel3.Size = New Size(47, 47)
        Panel3.TabIndex = 2
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(8, 8)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(30, 30)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Txt_Password
        ' 
        Txt_Password.BackColor = Color.FromArgb(CByte(245), CByte(247), CByte(250))
        Txt_Password.BorderStyle = BorderStyle.None
        Txt_Password.Font = New Font("Segoe UI", 14.25F)
        Txt_Password.ForeColor = Color.DimGray
        Txt_Password.Location = New Point(60, 10)
        Txt_Password.Name = "Txt_Password"
        Txt_Password.Size = New Size(220, 26)
        Txt_Password.TabIndex = 3
        ' 
        ' btn_login
        ' 
        btn_login.BackColor = Color.FromArgb(CByte(83), CByte(175), CByte(255))
        btn_login.Cursor = Cursors.Hand
        btn_login.FlatAppearance.BorderSize = 0
        btn_login.FlatStyle = FlatStyle.Flat
        btn_login.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        btn_login.ForeColor = Color.White
        btn_login.Location = New Point(50, 290)
        btn_login.Name = "btn_login"
        btn_login.Size = New Size(300, 50)
        btn_login.TabIndex = 3
        btn_login.Text = "SE CONNECTER"
        btn_login.UseVisualStyleBackColor = False
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(83), CByte(175), CByte(255))
        ClientSize = New Size(721, 602)
        Controls.Add(PanelHeader)
        Controls.Add(Panel6)
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        StartPosition = FormStartPosition.CenterScreen
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