<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Administrateur
    Inherits System.Windows.Forms.Form

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
        Me.PanelMenu = New System.Windows.Forms.Panel()
        Me.btn_Analyse_Activite = New System.Windows.Forms.Button()
        Me.btn_Journal_Sessions = New System.Windows.Forms.Button()
        Me.PanelHeader = New System.Windows.Forms.Panel()
        Me.btn_exit_Panel = New System.Windows.Forms.Panel()
        Me.btn_logout_Panel = New System.Windows.Forms.Panel()
        Me.lbl_nom = New System.Windows.Forms.Label()
        Me.PanelAffichage = New System.Windows.Forms.Panel()
        Me.PanelMenu.SuspendLayout()
        Me.PanelHeader.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanelMenu
        '
        Me.PanelMenu.BackColor = System.Drawing.Color.FromArgb(CByte(45), CByte(52), CByte(70))
        Me.PanelMenu.Controls.Add(Me.btn_Analyse_Activite)
        Me.PanelMenu.Controls.Add(Me.btn_Journal_Sessions)
        Me.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me.PanelMenu.Location = New System.Drawing.Point(0, 0)
        Me.PanelMenu.Name = "PanelMenu"
        Me.PanelMenu.Padding = New System.Windows.Forms.Padding(0, 80, 0, 0)
        Me.PanelMenu.Size = New System.Drawing.Size(250, 633)
        Me.PanelMenu.TabIndex = 0
        '
        'btn_Analyse_Activite
        '
        Me.btn_Analyse_Activite.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Analyse_Activite.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Analyse_Activite.FlatAppearance.BorderSize = 0
        Me.btn_Analyse_Activite.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Analyse_Activite.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btn_Analyse_Activite.ForeColor = System.Drawing.Color.White
        Me.btn_Analyse_Activite.Location = New System.Drawing.Point(0, 130)
        Me.btn_Analyse_Activite.Name = "btn_Analyse_Activite"
        Me.btn_Analyse_Activite.Size = New System.Drawing.Size(250, 50)
        Me.btn_Analyse_Activite.TabIndex = 1
        Me.btn_Analyse_Activite.Text = "  Analyse de l'activité"
        Me.btn_Analyse_Activite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_Journal_Sessions
        '
        Me.btn_Journal_Sessions.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_Journal_Sessions.Dock = System.Windows.Forms.DockStyle.Top
        Me.btn_Journal_Sessions.FlatAppearance.BorderSize = 0
        Me.btn_Journal_Sessions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_Journal_Sessions.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btn_Journal_Sessions.ForeColor = System.Drawing.Color.White
        Me.btn_Journal_Sessions.Location = New System.Drawing.Point(0, 80)
        Me.btn_Journal_Sessions.Name = "btn_Journal_Sessions"
        Me.btn_Journal_Sessions.Size = New System.Drawing.Size(250, 50)
        Me.btn_Journal_Sessions.TabIndex = 0
        Me.btn_Journal_Sessions.Text = "  Journal des sessions"
        Me.btn_Journal_Sessions.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelHeader
        '
        Me.PanelHeader.BackColor = System.Drawing.Color.White
        Me.PanelHeader.Controls.Add(Me.btn_exit_Panel)
        Me.PanelHeader.Controls.Add(Me.btn_logout_Panel)
        Me.PanelHeader.Controls.Add(Me.lbl_nom)
        Me.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelHeader.Location = New System.Drawing.Point(250, 0)
        Me.PanelHeader.Name = "PanelHeader"
        Me.PanelHeader.Size = New System.Drawing.Size(819, 60)
        Me.PanelHeader.TabIndex = 1
        '
        'btn_exit_Panel
        '
        Me.btn_exit_Panel.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Me.btn_exit_Panel.Location = New System.Drawing.Point(767, 10)
        Me.btn_exit_Panel.Name = "btn_exit_Panel"
        Me.btn_exit_Panel.Size = New System.Drawing.Size(40, 40)
        Me.btn_exit_Panel.TabIndex = 2
        '
        'btn_logout_Panel
        '
        Me.btn_logout_Panel.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        Me.btn_logout_Panel.Location = New System.Drawing.Point(598, 10)
        Me.btn_logout_Panel.Name = "btn_logout_Panel"
        Me.btn_logout_Panel.Size = New System.Drawing.Size(163, 40)
        Me.btn_logout_Panel.TabIndex = 1
        '
        'lbl_nom
        '
        Me.lbl_nom.Dock = System.Windows.Forms.DockStyle.Left
        Me.lbl_nom.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_nom.ForeColor = System.Drawing.Color.FromArgb(CByte(45), CByte(52), CByte(70))
        Me.lbl_nom.Location = New System.Drawing.Point(0, 0)
        Me.lbl_nom.Name = "lbl_nom"
        Me.lbl_nom.Padding = New System.Windows.Forms.Padding(20, 0, 0, 0)
        Me.lbl_nom.Size = New System.Drawing.Size(591, 60)
        Me.lbl_nom.TabIndex = 0
        Me.lbl_nom.Text = "ADMINISTRATION"
        Me.lbl_nom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanelAffichage
        '
        Me.PanelAffichage.BackColor = System.Drawing.Color.FromArgb(CByte(245), CByte(247), CByte(250))
        Me.PanelAffichage.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelAffichage.Location = New System.Drawing.Point(250, 60)
        Me.PanelAffichage.Name = "PanelAffichage"
        Me.PanelAffichage.Size = New System.Drawing.Size(819, 573)
        Me.PanelAffichage.TabIndex = 2
        '
        'Administrateur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1069, 633)
        Me.Controls.Add(Me.PanelAffichage)
        Me.Controls.Add(Me.PanelHeader)
        Me.Controls.Add(Me.PanelMenu)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Administrateur"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administrateur"
        Me.PanelMenu.ResumeLayout(False)
        Me.PanelHeader.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelMenu As Panel
    Friend WithEvents btn_Analyse_Activite As Button
    Friend WithEvents btn_Journal_Sessions As Button
    Friend WithEvents PanelHeader As Panel
    Friend WithEvents lbl_nom As Label
    Friend WithEvents PanelAffichage As Panel
    Friend WithEvents btn_logout_Panel As Panel
    Friend WithEvents btn_exit_Panel As Panel
End Class