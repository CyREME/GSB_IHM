Public Class Form2
    Public Sub New(nom As String, prenom As String,
                   DayBorn As Integer, MonthBorn As Integer, YearBorn As Integer,
                   discipline As String,
                   score As Integer,
                   abandon As Boolean,
                   m_OR As Boolean, m_argent As Boolean, m_bronze As Boolean)


        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.



        Me.Label1.Text = Form1.NomInput.Text & " " & Form1.PrenomInput.Text & ", " & (Year(DateTime.Now) - Form1.Date_An.Text) & " ans née le " & Format(Form1.Date_Jour.Text, "00") & "/" & Format(Form1.Date_Mois.Text, "00") & "/" & Form1.Date_An.Text

        If discipline.ToLower() = "badminton" Then
            Me.Label2.Text = "Discipline : " & Form1.Selection_Sport.SelectedItem.ToString()
        ElseIf discipline.ToLower() = "athlétisme" Then
            Me.Label2.Text = "Discipline : ATH"

        ElseIf discipline.ToLower() = "aviron" Then
            Me.Label2.Text = "Discipline : AVI"
        End If
        If Form1.Abandon.Checked Then
            Me.Label3.Text = "Abandon : oui"
        Else
            Me.Label3.Text = "Abandon : non"
        End If

        Me.Label4.Text = "Score : " & Form1.Score.Text

        Dim medals As String = "Aucune médaille"

        If m_OR Then
            medals = "Médaille : Or "
        End If
        If m_argent Then
            medals = "Médaille : Argent "
        End If
        If m_bronze Then
            medals = "Médaille : Bronze "
        End If

        Me.Label5.Text = medals

    End Sub
End Class