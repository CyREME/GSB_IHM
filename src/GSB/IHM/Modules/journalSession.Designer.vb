<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class journalSession
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
        Me.lbl_titre = New System.Windows.Forms.Label()
        Me.txt_recherche = New System.Windows.Forms.TextBox()
        Me.lbl_search = New System.Windows.Forms.Label()
        Me.btn_purger = New System.Windows.Forms.Button()
        Me.TabPrincipal = New System.Windows.Forms.DataGridView()
        CType(Me.TabPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_titre
        '
        Me.lbl_titre.AutoSize = True
        Me.lbl_titre.Font = New System.Drawing.Font("Segoe UI Semibold", 16.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_titre.ForeColor = System.Drawing.Color.FromArgb(CByte(45), CByte(52), CByte(70))
        Me.lbl_titre.Location = New System.Drawing.Point(25, 20)
        Me.lbl_titre.Name = "lbl_titre"
        Me.lbl_titre.Size = New System.Drawing.Size(201, 30)
        Me.lbl_titre.TabIndex = 1
        Me.lbl_titre.Text = "Suivi des Sessions"
        '
        'lbl_search
        '
        Me.lbl_search.AutoSize = True
        Me.lbl_search.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.lbl_search.Location = New System.Drawing.Point(25, 57)
        Me.lbl_search.Name = "lbl_search"
        Me.lbl_search.Size = New System.Drawing.Size(126, 15)
        Me.lbl_search.TabIndex = 3
        Me.lbl_search.Text = "Chercher un utilisateur :"
        '
        'txt_recherche
        '
        Me.txt_recherche.Font = New System.Drawing.Font("Segoe UI", 11.0!)
        Me.txt_recherche.Location = New System.Drawing.Point(25, 75)
        Me.txt_recherche.Name = "txt_recherche"
        Me.txt_recherche.PlaceholderText = "Filtrer par nom ou login..."
        Me.txt_recherche.Size = New System.Drawing.Size(250, 27)
        Me.txt_recherche.TabIndex = 2
        '
        'btn_purger
        '
        Me.btn_purger.BackColor = System.Drawing.Color.FromArgb(CByte(231), CByte(76), CByte(60))
        Me.btn_purger.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_purger.Font = New System.Drawing.Font("Segoe UI Bold", 9.0!)
        Me.btn_purger.ForeColor = System.Drawing.Color.White
        Me.btn_purger.Location = New System.Drawing.Point(644, 72)
        Me.btn_purger.Name = "btn_purger"
        Me.btn_purger.Size = New System.Drawing.Size(150, 32)
        Me.btn_purger.TabIndex = 4
        Me.btn_purger.Text = "PURGER L'HISTORIQUE"
        Me.btn_purger.UseVisualStyleBackColor = False
        '
        'TabPrincipal
        '
        Me.TabPrincipal.AllowUserToAddRows = False
        Me.TabPrincipal.AllowUserToDeleteRows = False
        Me.TabPrincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.TabPrincipal.BackgroundColor = System.Drawing.Color.White
        Me.TabPrincipal.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TabPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TabPrincipal.Location = New System.Drawing.Point(25, 115)
        Me.TabPrincipal.Name = "TabPrincipal"
        Me.TabPrincipal.ReadOnly = True
        Me.TabPrincipal.RowHeadersVisible = False
        Me.TabPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TabPrincipal.Size = New System.Drawing.Size(769, 425)
        Me.TabPrincipal.TabIndex = 5
        '
        'journalSession
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CByte(245), CByte(247), CByte(250))
        Me.Controls.Add(Me.TabPrincipal)
        Me.Controls.Add(Me.btn_purger)
        Me.Controls.Add(Me.lbl_search)
        Me.Controls.Add(Me.txt_recherche)
        Me.Controls.Add(Me.lbl_titre)
        Me.Name = "journalSession"
        Me.Size = New System.Drawing.Size(819, 573)
        CType(Me.TabPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TabPrincipal As DataGridView
    Friend WithEvents lbl_titre As Label
    Friend WithEvents txt_recherche As TextBox
    Friend WithEvents lbl_search As Label
    Friend WithEvents btn_purger As Button
End Class