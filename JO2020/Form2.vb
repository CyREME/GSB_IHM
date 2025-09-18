Public Class Form2
    Public Sub New(nom As String, prenom As String,
                   DayBorn As Integer, MonthBorn As Integer, YearBorn As Integer,
                   discipline As String,
                   score As Integer,
                   abandon As Boolean,
                   m_OR As Boolean, m_argent As Boolean, m_bronze As Boolean)

        Dim Month_s As String = Format(MonthBorn, "00")
        Dim Day_s As String = Format(MonthBorn, "00")

        Dim Age As Integer = Year(DateTime.Now) - YearBorn


        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.



        Me.Label1.Text = Form1.Text & " " & prenom & ", " & Age & " ans née le " & Day_s & "/" & Month_s & "/" & Form1.Date_An.Text

        If discipline.ToLower() = "badminton" Then
            Me.Label2.Text = "Discipline : BAD"
        ElseIf discipline.ToLower() = "athlétisme" Then
            Me.Label2.Text = "Discipline : ATH"

        ElseIf discipline.ToLower() = "aviron" Then
            Me.Label2.Text = "Discipline : AVI"
        End If
        If abandon Then
            Me.Label3.Text = "Abandon : oui"
        Else
            Me.Label3.Text = "Abandon : non"
        End If

        Me.Label4.Text = "Score : " & score

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