Public Class btn_exit

    Private Sub btn_exit_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim fenetreParente As Form = Me.FindForm()
        If fenetreParente IsNot Nothing Then
            fenetreParente.Close()
        End If

    End Sub

End Class
