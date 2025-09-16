Imports System.Globalization
Imports System.Reflection.Metadata

Public Class Form1

    Dim dateNaiss As String = ""

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nom As String = Me.TextBox1.Text
        Dim prenom As String = Me.TextBox2.Text
        Dim DayBorn As Integer = Me.Date_Jour.Text
        Dim MonthBorn As Integer = Me.Date_Mois.Text
        Dim YearBorn As Integer = Me.Date_An.Text
        Dim discipline As String = Me.ComboBox1.SelectedItem.ToString()
        Dim score As Integer = Me.TextBox5.Text
        Dim abandon As Boolean = Me.RadioButton1.Checked
        Dim m_OR As Boolean = Me.RadioButton2.Checked
        Dim m_argent As Boolean = Me.RadioButton3.Checked
        Dim m_bronze As Boolean = Me.RadioButton4.Checked

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
            dateNaiss = jour & " " & dateNaiss
            DateN.Text = dateNaiss
        End If

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
            dateNaiss = culture.DateTimeFormat.AbbreviatedMonthNames(mois - 1) & " " & dateNaiss

            DateN.Text = dateNaiss


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

            dateNaiss = an
            DateN.Text = dateNaiss

        End If



    End Sub
End Class
