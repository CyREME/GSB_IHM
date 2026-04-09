<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class btn_exit
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
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Button1
        ' 
        Button1.BackColor = Color.White
        Button1.Cursor = Cursors.Hand
        Button1.Dock = DockStyle.Fill
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(200), CByte(0), CByte(0))
        Button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(232), CByte(17), CByte(35))
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Segoe UI", 14.0F, FontStyle.Bold)
        Button1.ForeColor = Color.FromArgb(CByte(100), CByte(100), CByte(100))
        Button1.Location = New Point(0, 0)
        Button1.Name = "Button1"
        Button1.Size = New Size(40, 40)
        Button1.TabIndex = 6
        Button1.Text = "✕"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' btn_exit
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Button1)
        Name = "btn_exit"
        Size = New Size(40, 40)
        ResumeLayout(False)
    End Sub

    Friend WithEvents Button1 As Button

End Class