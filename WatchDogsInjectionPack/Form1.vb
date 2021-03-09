Public Class Form1
    Dim unluckiness As Integer
    Public Safetoclose As Boolean = True
    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        unluckiness = (GetRandom(1, 3))
        If unluckiness = 2 Then
            GameNotRunning.ShowDialog()
            My.Computer.Audio.Play(My.Resources.Menu, AudioPlayMode.BackgroundLoop)
        Else
            If CampaignSkipButton.Checked = True Then
                Me.Hide()
                HowDareYou.Show()
            End If
            If RadioButton4.Checked = True Or RadioButton5.Checked = True Or RadioButton6.Checked = True Or RadioButton7.Checked = True Or RadioButton8.Checked = True Then
                My.Computer.Audio.Stop()
                AmigoVirus.ShowDialog()
            End If
            If ShutDownButton.Checked = True Then
                Process.Start("shutdown.exe", "-s -t 1")
            ElseIf MoneyCheatButton.Checked = True Then
                My.Computer.Audio.Play(My.Resources.HAHA, AudioPlayMode.Background)
                Process.Start("ms-calculator://")
            ElseIf NoclipButton.Checked = True Then
                My.Computer.Audio.Play(My.Resources.Wow, AudioPlayMode.Background)
                Dim NewLocationX As Integer = Me.Location.X + 5
                Dim NewLocationY As Integer = Me.Location.Y + 5
                Me.Location = New Point(NewLocationX, NewLocationY)
                Application.DoEvents()
                Threading.Thread.Sleep(100)
                NewLocationX = Me.Location.X + 5
                NewLocationY = Me.Location.Y + 5
                Me.Location = New Point(NewLocationX, NewLocationY)
                Application.DoEvents()
                Threading.Thread.Sleep(100)
                NewLocationX = Me.Location.X + 5
                NewLocationY = Me.Location.Y + 5
                Me.Location = New Point(NewLocationX, NewLocationY)
                Application.DoEvents()
                Threading.Thread.Sleep(100)
                NewLocationX = Me.Location.X + 5
                NewLocationY = Me.Location.Y + 5
                Me.Location = New Point(NewLocationX, NewLocationY)
                Application.DoEvents()
                Threading.Thread.Sleep(100)
                NewLocationX = Me.Location.X + 5
                NewLocationY = Me.Location.Y + 5
                Me.Location = New Point(NewLocationX, NewLocationY)
                Application.DoEvents()
                Threading.Thread.Sleep(100)
                NewLocationX = Me.Location.X + -5
                NewLocationY = Me.Location.Y + 5
                Me.Location = New Point(NewLocationX, NewLocationY)
                Application.DoEvents()
                Threading.Thread.Sleep(100)
                NewLocationX = Me.Location.X + -5
                NewLocationY = Me.Location.Y + 5
                Me.Location = New Point(NewLocationX, NewLocationY)
                Application.DoEvents()
                Threading.Thread.Sleep(100)
                NewLocationX = Me.Location.X + -5
                NewLocationY = Me.Location.Y + 5
                Me.Location = New Point(NewLocationX, NewLocationY)
                Application.DoEvents()
                Threading.Thread.Sleep(100)
                NewLocationX = Me.Location.X + -5
                NewLocationY = Me.Location.Y + 5
                Me.Location = New Point(NewLocationX, NewLocationY)
                Application.DoEvents()
                Threading.Thread.Sleep(100)
                NewLocationX = Me.Location.X + -5
                NewLocationY = Me.Location.Y + 5
                Me.Location = New Point(NewLocationX, NewLocationY)
                Application.DoEvents()
                Threading.Thread.Sleep(100)
                NewLocationX = Me.Location.X + -5
                NewLocationY = Me.Location.Y + 5
                Me.Location = New Point(NewLocationX, NewLocationY)
                Application.DoEvents()
                Threading.Thread.Sleep(100)
                NewLocationX = Me.Location.X + -5
                NewLocationY = Me.Location.Y + 5
                Me.Location = New Point(NewLocationX, NewLocationY)
                Application.DoEvents()
                Threading.Thread.Sleep(100)
                NewLocationX = Me.Location.X + 2
                NewLocationY = Me.Location.Y + -5
                Me.Location = New Point(NewLocationX, NewLocationY)
                Application.DoEvents()
                Threading.Thread.Sleep(100)
                NewLocationX = Me.Location.X + 2
                NewLocationY = Me.Location.Y + -5
                Me.Location = New Point(NewLocationX, NewLocationY)
                Application.DoEvents()
                Threading.Thread.Sleep(100)
                NewLocationX = Me.Location.X + 2
                NewLocationY = Me.Location.Y + -5
                Me.Location = New Point(NewLocationX, NewLocationY)
                Application.DoEvents()
                Threading.Thread.Sleep(100)
                NewLocationX = Me.Location.X + 2
                NewLocationY = Me.Location.Y + -5
                Me.Location = New Point(NewLocationX, NewLocationY)
                Application.DoEvents()
                Threading.Thread.Sleep(100)
                My.Computer.Audio.Play(My.Resources.Menu, AudioPlayMode.BackgroundLoop)
            End If
        End If
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Safetoclose = True Then
            e.Cancel = True
            My.Computer.Audio.Stop()
            Me.Hide()
            Credits.Show()
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        My.Computer.Audio.Play(My.Resources.Menu, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.DoubleClick
        Form3.ShowDialog()
    End Sub

    Private Sub RadioButton2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoneyCheatButton.CheckedChanged

    End Sub

    Private Sub RadioButton3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CampaignSkipButton.CheckedChanged

    End Sub

    Private Sub RadioButton4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton4.CheckedChanged

    End Sub

    Private Sub RadioButton5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton5.CheckedChanged

    End Sub

    Private Sub RadioButton6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton6.CheckedChanged

    End Sub

    Private Sub RadioButton7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton7.CheckedChanged

    End Sub

    Private Sub RadioButton8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton8.CheckedChanged

    End Sub

    Private Sub RadioButton9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ShutDownButton.CheckedChanged

    End Sub

    Private Sub RadioButton1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NoclipButton.CheckedChanged

    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
