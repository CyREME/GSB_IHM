Public Class Form2
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.

        Dim discipline As String = Form1.Selection_Sport.SelectedItem.ToString().Substring(0, 3).ToUpper()
        Dim an As String = Form1.Date_An.Text
        Dim mois As Integer = Val(Form1.Date_Mois.text)
        Dim jour As Integer = Val(Form1.Date_Jour.text)

        Me.Label1.Text = Form1.NomInput.Text & " " & Form1.PrenomInput.Text & ", " & (Year(DateTime.Now) - Form1.Date_An.Text) & " ans née le " & Format(jour, "00") & "/" & Format(mois, "00") & "/" & Form1.Date_An.Text



        Me.Label2.Text = "Discipline : " & discipline



        If Form1.Abandon.Checked Then
            Me.Label3.Text = "Abandon : oui"
        Else
            Me.Label3.Text = "Abandon : non"
        End If


        Me.Label4.Text = "Score : " & Form1.Score.Text


        Dim medals As String = "Aucune médaille"

        If Form1.Medaille_Or.Checked Then
            Me.Label5.Text = "Médaille d'Or"

        ElseIf Form1.Medaille_Argent.Checked Then
            Me.Label5.Text = "Médaille d'Argent"

        ElseIf Form1.Medaille_Bronze.Checked Then
            Me.Label5.Text = "Médaille de Bronze"

        End If

        Me.Label5.Text = medals

    End Sub
End Class