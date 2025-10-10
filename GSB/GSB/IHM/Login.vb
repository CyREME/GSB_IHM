Public Class Login

    Private Property MoveForm As Boolean
    Private Property MoveForm_MousePosition As Point


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Txt_Username.Text = "Login"
        Txt_Username.ForeColor = Color.DarkGray

        Txt_Password.Text = "Mot de passe"
        Txt_Password.ForeColor = Color.DarkGray
        Txt_Password.PasswordChar = ""
    End Sub

    Private Sub Txt_Username_TextChanged_1(sender As Object, e As EventArgs) Handles Txt_Username.GotFocus
        If Txt_Username.Text = "Login" Then
            Txt_Username.Text = ""
            Txt_Username.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Txt_Username_LostFocus(sender As Object, e As EventArgs) Handles Txt_Username.LostFocus
        If Txt_Username.Text = "" Then
            Txt_Username.Text = "Login"
            Txt_Username.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub Txt_Password_TextChanged_1(sender As Object, e As EventArgs) Handles Txt_Password.GotFocus
        If Txt_Password.Text = "Mot de passe" Then
            Txt_Password.Text = ""
            Txt_Password.PasswordChar = "*"c
            Txt_Password.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Txt_Password_LostFocus(sender As Object, e As EventArgs) Handles Txt_Password.LostFocus
        If Txt_Password.Text = "" Then
            Txt_Password.Text = "Mot de passe"
            Txt_Password.PasswordChar = ""
            Txt_Password.ForeColor = Color.DarkGray
        End If
    End Sub

    Private Sub Panel5_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel5.MouseUp
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Panel5_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel5.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
            MoveForm_MousePosition = e.Location
        End If
    End Sub


    Private Sub Panel5_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel5.MouseMove
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub
End Class