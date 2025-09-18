Imports System.Globalization
Imports System.Reflection.Metadata
Imports System.Text.RegularExpressions

Public Class Form1

    Dim Champ_N As Boolean = False
    Dim Champ_P As Boolean = False
    Dim Champ_D As Boolean = False
    Dim Champ_S As Boolean = False


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nom As String = Me.PrenomInput.Text
        Dim prenom As String = Me.NomInput.Text
        Dim DayBorn As Integer = Me.Date_Jour.Text
        Dim MonthBorn As Integer = Me.Date_Mois.Text
        Dim YearBorn As Integer = Me.Date_An.Text
        Dim discipline As String = Me.Selection_Sport.SelectedItem.ToString()
        Dim score As Integer = Me.Score.Text
        Dim abandon As Boolean = Me.Abandon.Checked
        Dim m_OR As Boolean = Me.Medaille_Or.Checked
        Dim m_argent As Boolean = Me.Medaille_Argent.Checked
        Dim m_bronze As Boolean = Me.Medaille_Bronze.Checked

        Dim fenetre As New Form2(nom, prenom, DayBorn, MonthBorn, YearBorn, discipline,
                                 score, abandon, m_OR, m_argent, m_bronze)

        fenetre.Show()

    End Sub




    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Date_Jour.TextChanged
        Dim dateStr As String = Date_Jour.Text & "/" & Date_Mois.Text & "/" & Date_An.Text


    End Sub

    Private Sub Date_Jour_TextChanged(sender As Object, e As EventArgs) Handles Date_Jour.TextChanged
        Dim jour As Integer
        Dim mois As Integer = Date_Mois.Text
        Dim an As Integer = Date_An.Text
        Dim MaxJour As Integer = DateTime.DaysInMonth(an, mois)

        If Date_Jour.Text = "" Then
            Date_Jour.Focus()

        ElseIf Integer.TryParse(Date_Jour.Text, jour) Then
            If jour < 1 Or jour > MaxJour Then
                Date_Jour.Text = ""
                MessageBox.Show("Le jour doit être compris entre 1 et " & MaxJour)
            End If

        Else
            Date_Jour.Text = ""
            MessageBox.Show("Le jour doit être un nombre entier")
        End If



        If Date_Jour.Text <> "" And jour >= 1 AndAlso jour <= MaxJour Then
            Dim culture As CultureInfo = CultureInfo.CurrentCulture
            DateN.Text = jour & " " & culture.DateTimeFormat.AbbreviatedMonthNames(mois - 1) & " " & an
            Champ_D = True
        Else
            DateN.Text = mois & " " & an
        End If

        button_enabled()
    End Sub

    Private Sub Date_Mois_TextChanged(sender As Object, e As EventArgs) Handles Date_Mois.TextChanged
        Dim mois As Integer

        If Date_Mois.Text = "" Then
            Date_Jour.Enabled = False
        End If

        If Integer.TryParse(Date_Mois.Text, mois) Then

            If mois < 1 Or mois > 12 Then
                Date_Mois.Text = ""
                MessageBox.Show("Le mois doit être comprise entre 1 et 12")
                Date_Jour.Enabled = False

            End If


        ElseIf Not Integer.TryParse(Date_Mois.Text, mois) And Date_Mois.Text <> "" Then
            Date_Mois.Text = ""
            MessageBox.Show("Le mois doit être un nombre entier")
            Date_Jour.Enabled = False
        End If

        If mois >= 1 AndAlso mois <= 12 Then
            Date_Jour.Enabled = True



            Dim culture As CultureInfo = CultureInfo.CurrentCulture
            DateN.Text = culture.DateTimeFormat.AbbreviatedMonthNames(mois - 1) & " " & Me.Date_An.Text
            Date_Mois.Focus()

        Else

            DateN.Text = Me.Date_An.Text
        End If



    End Sub

    Private Sub Date_An_TextChanged(sender As Object, e As EventArgs) Handles Date_An.TextChanged
        Dim an As Integer

        If Integer.TryParse(Date_An.Text, an) Then

            If Date_An.TextLength = 4 Then

                If an < 1950 Or an > 2009 Then
                    MessageBox.Show("L'année doit être comprise entre 1950 et 2009")

                End If

            Else
                Date_Mois.Enabled = False

            End If

        ElseIf Not Integer.TryParse(Date_An.Text, an) And Date_An.Text <> "" Then
            Date_An.Text = ""
            MessageBox.Show("L'année doit être un nombre entier")
        End If


        If Date_An.TextLength = 4 And an >= 1950 AndAlso an <= 2009 Then
            Date_Mois.Enabled = True
            DateN.Text = Date_An.Text
            Date_Mois.Focus()
        Else
            Date_Mois.Enabled = False
            Date_Jour.Enabled = False
            DateN.Text = ""
        End If




    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles NomInput.TextChanged
        If NomInput.Text <> "" Then
            Champ_N = True
        Else
            Champ_N = False
        End If

        button_enabled()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles PrenomInput.TextChanged
        If PrenomInput.Text <> "" Then
            Champ_P = True
        Else
            Champ_P = False
        End If

        button_enabled()

    End Sub

    Public Function button_enabled() As Boolean
        If Champ_N And Champ_P And Champ_D And Champ_S Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Function

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Selection_Sport.SelectedIndexChanged
        If Selection_Sport.SelectedItem.ToString() <> "" Then
            Champ_S = True
        Else
            Champ_S = False
        End If

        button_enabled()

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles Medaille_Or.CheckedChanged, Medaille_Argent.CheckedChanged, Medaille_Bronze.CheckedChanged
        If Medaille_Or.Checked Then
            Score.Text = "1"
        ElseIf Medaille_Argent.Checked Then
            Score.Text = "2"
        ElseIf Medaille_Bronze.Checked Then
            Score.Text = "3"
        End If
    End Sub

    Private Sub TextBox5_TextChanged_1(sender As Object, e As EventArgs) Handles Score.TextChanged
        If Score.Text = "1" Then
            Medaille_Or.Checked = True
        ElseIf Score.Text = "2" Then

            Medaille_Argent.Checked = True
        ElseIf Score.Text = "3" Then
            Medaille_Bronze.Checked = True


        End If
    End Sub

End Class



