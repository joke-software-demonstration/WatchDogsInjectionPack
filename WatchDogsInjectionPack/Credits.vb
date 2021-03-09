Public Class Credits
    Dim Slide As Integer = 1
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Slide = Slide + 1
        If Slide = 2 Then
            Me.BackgroundImage = My.Resources.Credits_02
        ElseIf Slide = 3 Then
            Me.BackgroundImage = Nothing
            Timer1.Interval = 16000
            AxWindowsMediaPlayer1.URL = ("C:\Program Files (x86)\Newfiddy Soft\WatchDogsInjectionPack\Credits_04.mp4")
            AxWindowsMediaPlayer1.Show()
        ElseIf Slide = 4 Then
            Timer1.Interval = 20000
            Label1.Show()
            Label2.Show()
            Label3.Show()
            AxWindowsMediaPlayer1.URL = ("C:\Program Files (x86)\Newfiddy Soft\WatchDogsInjectionPack\Credits_03.mp4")
        ElseIf Slide = 5 Then
            Timer1.Interval = 17000
            Label1.Text = "Director"
            Label2.Text = "Rashid Kapoor"
            AxWindowsMediaPlayer1.URL = ("C:\Program Files (x86)\Newfiddy Soft\WatchDogsInjectionPack\Credits_05.mp4")
        ElseIf Slide = 6 Then
            Timer1.Interval = 16000
            Label1.Text = "Financial Manager"
            Label2.Text = "Susan Rosanne"
            AxWindowsMediaPlayer1.URL = ("C:\Program Files (x86)\Newfiddy Soft\WatchDogsInjectionPack\Credits_06.mp4")
        ElseIf Slide = 7 Then
            Timer1.Interval = 6000
            Label1.Text = "Technical Supervisor"
            Label2.Text = "Mr. Tea"
            AxWindowsMediaPlayer1.URL = ("C:\Program Files (x86)\Newfiddy Soft\WatchDogsInjectionPack\Credits_07.mp4")
        ElseIf Slide = 8 Then
            Timer1.Interval = 7000
            Label1.Text = "Project Co-ordinator"
            Label2.Text = "Michael Pay"
            AxWindowsMediaPlayer1.URL = ("C:\Program Files (x86)\Newfiddy Soft\WatchDogsInjectionPack\Credits_08.mp4")
        ElseIf Slide = 9 Then
            Timer1.Interval = 6000
            Label1.Text = "Beta Tester"
            Label2.Text = "Kirigaya Kazuto"
            AxWindowsMediaPlayer1.URL = ("C:\Program Files (x86)\Newfiddy Soft\WatchDogsInjectionPack\Credits_09.mp4")
        ElseIf Slide = 11 Then
            Timer1.Interval = 26000
            Label1.Text = "Janitor"
            Label2.Text = "Walter Whyte"
            AxWindowsMediaPlayer1.URL = ("C:\Program Files (x86)\Newfiddy Soft\WatchDogsInjectionPack\Credits_11.mp4")
        ElseIf Slide = 12 Then
            Timer1.Interval = 17000
            Label1.Text = "Technical Supporter"
            Label2.Text = "Damien Pholdes"
            AxWindowsMediaPlayer1.URL = ("C:\Program Files (x86)\Newfiddy Soft\WatchDogsInjectionPack\Credits_12.mp4")
        ElseIf Slide = 13 Then
            AxWindowsMediaPlayer1.Hide()
            Label1.Hide()
            Label3.Hide()
            Label2.Hide()
            Me.BackgroundImage = My.Resources.Credits_13
            Timer1.Enabled = False
            Application.DoEvents()
            Threading.Thread.Sleep(5000)
            Form1.Close()
            Me.Close()
        End If
    End Sub

    Private Sub Credits_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Form1.Close()
    End Sub

    Private Sub Credits_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.credits, AudioPlayMode.Background)
    End Sub
End Class