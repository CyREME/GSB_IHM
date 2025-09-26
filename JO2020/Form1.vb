Imports System.Globalization
Imports System.Reflection.Metadata
Imports System.Text.RegularExpressions

Public Class Form1

    Dim Champ_N As Boolean = False
    Dim Champ_P As Boolean = False
    Dim Champ_D As Boolean = False
    Dim Champ_S As Boolean = False


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnValide.Click
        Dim fenetre As New Form2()
        fenetre.Show()

    End Sub






    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Date_Jour.TextChanged
        Dim dateStr As String = Date_Jour.Text & "/" & Date_Mois.Text & "/" & Date_An.Text

    End Sub

    Private Sub Date_Jour_TextChanged(sender As Object, e As EventArgs) Handles Date_Jour.TextChanged
        Dim jour As Integer


        If Date_Jour.Text = "" Then
            Date_Jour.Focus()

        ElseIf Integer.TryParse(Date_Jour.Text, jour) Then
            If jour < 1 Or jour > 31 Then
                Date_Jour.Text = ""
                MessageBox.Show("Le jour doit être compris entre 1 et 31")
            End If

        Else
            Date_Jour.Text = ""
            MessageBox.Show("Le jour doit être un nombre entier")
        End If



        If Date_Jour.Text <> "" And jour >= 1 AndAlso jour <= 31 Then
            Date_Mois.Enabled = True

            DateN.Text = jour

        Else
            DateN.Text = ""
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
                Date_An.Enabled = False

            End If


        ElseIf Not Integer.TryParse(Date_Mois.Text, mois) And Date_Mois.Text <> "" Then
            Date_Mois.Text = ""
            MessageBox.Show("Le mois doit être un nombre entier")
            Date_An.Enabled = False
        End If

        If mois >= 1 AndAlso mois <= 12 Then
            Date_Jour.Enabled = True

            Dim culture As CultureInfo = CultureInfo.CurrentCulture
            DateN.Text = Date_Jour.Text & " " & culture.DateTimeFormat.AbbreviatedMonthNames(mois - 1)
            Date_An.Enabled = True


        Else

            DateN.Text = Date_Jour.Text
        End If



    End Sub
    Private Sub Date_An_TextChanged(sender As Object, e As EventArgs) Handles Date_An.TextChanged
        Dim culture As CultureInfo = CultureInfo.CurrentCulture
        Dim an As Integer
        Dim mois As Integer = Date_Mois.Text
        Dim jour As Integer = Date_Jour.Text


        If Integer.TryParse(Date_An.Text, an) Then


            If Date_An.TextLength = 4 Then

                Dim MaxJour As Integer = DateTime.DaysInMonth(an, mois)

                If an < 1950 Or an > 2009 Then
                    MessageBox.Show("L'année doit être comprise entre 1950 et 2009")

                End If

                If jour >= 0 AndAlso jour > MaxJour Then
                    MessageBox.Show("Le jour doit être compris entre 1 et " & MaxJour)
                    Date_Jour.Focus()
                End If

            End If

        ElseIf Not Integer.TryParse(Date_An.Text, an) And Date_An.Text <> "" Then
            Date_An.Text = ""
            MessageBox.Show("L'année doit être un nombre entier")
        End If


        If Date_An.TextLength = 4 And an >= 1950 AndAlso an <= 2009 Then
            DateN.Text = DateN.Text & " " & Date_An.Text

            Champ_D = True

        Else
            DateN.Text = jour & " " & culture.DateTimeFormat.AbbreviatedMonthNames(mois - 1)
            Champ_D = False
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

    Public Sub button_enabled()

        btnValide.Enabled = Champ_D And Champ_N And Champ_P And Champ_S And Selection_Sport.SelectedIndex <> -1

    End Sub



    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Selection_Sport.SelectedIndexChanged


        button_enabled()

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles Medaille_Or.CheckedChanged, Medaille_Argent.CheckedChanged, Medaille_Bronze.CheckedChanged, Abandon.CheckedChanged
        If Medaille_Or.Checked Then
            Score.Text = "1"
        ElseIf Medaille_Argent.Checked Then
            Score.Text = "2"
        ElseIf Medaille_Bronze.Checked Then
            Score.Text = "3"
        ElseIf Abandon.Checked Then
            Score.Text = "DNF"
        End If
    End Sub

    Private Sub TextBox5_TextChanged_1(sender As Object, e As EventArgs) Handles Score.TextChanged

        If Score.text = "1" Then
            Medaille_Or.Checked = True
        Else
            Medaille_Or.Checked = False
        End If


        If Score.text = "2" Then
            Medaille_Argent.Checked = True
        Else
            Medaille_Argent.Checked = False
        End If

        If Score.text = "3" Then
            Medaille_Bronze.Checked = True
        Else
            Medaille_Bronze.Checked = False
        End If

        If Score.text = "DNF" Then
            Abandon.Checked = True
        Else
            Abandon.Checked = False
        End If


        If Score.Text <> "" Then

            Champ_S = True

        Else
            Champ_S = False
        End If

        button_enabled()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class



