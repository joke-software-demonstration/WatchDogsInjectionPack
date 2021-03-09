Public Class GameNotRunning

    Private Sub GameNotRunning_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.PlaySystemSound(Media.SystemSounds.Asterisk)
        My.Computer.Audio.Play(My.Resources.NO, AudioPlayMode.Background)
    End Sub

    Private Sub GameNotRunning_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        Me.Close()
    End Sub
End Class