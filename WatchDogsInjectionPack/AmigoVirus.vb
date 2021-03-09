Public Class AmigoVirus
    Private Declare Function SystemParametersInfo Lib "user32" Alias "SystemParametersInfoA" (ByVal uAction As Integer, ByVal uParam As Integer, ByVal lpvParam As String, ByVal fuWinIni As Integer) As Integer
    Private Sub AmigoVirus_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
        SystemParametersInfo(20, 0, "C:\Program Files (x86)\Dr Amigo\GoodWallpaper4U.jpg", &H1)
    End Sub

    Private Sub AmigoVirus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.AMIGOINJECTION, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Testosterone.Click
        Label1.Text = "Oh my Good SAR, U Realize Last scan ON PC WAS:"
        Testosterone.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            Process.Start("C:\Program Files (x86)\Dr Amigo\Dr Amigo Home Security 2009 1.2.exe", "ScanUrgent")
        Catch ex As Exception
            My.Computer.Audio.Play(My.Resources.Erawr, AudioPlayMode.Background)
            Label1.Text = ("Oh S!£F*%T!!!!!!! Dr AMIGO NOT INSTALLED!!!!!")
            Label2.Text = ("AAAAAAAAAA")
            Label3.Text = ("Let's Rectify . . .")
            Label4.Hide()
            Testosterone.Hide()
            Button1.Hide()
            Application.DoEvents()
            Threading.Thread.Sleep(2000)
            Process.Start("https://quality-entertainment.github.io/qa-website/dramigo")
        End Try
        My.Computer.Audio.Stop()
        Form1.Hide()
        Me.Close()
    End Sub
End Class