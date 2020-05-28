Public Class Enlarged
    Dim StopWatch As New Diagnostics.Stopwatch
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim elapsed As TimeSpan = Me.StopWatch.Elapsed
        Label1.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", Math.Floor(elapsed.TotalHours), elapsed.Minutes, elapsed.Seconds, elapsed.Milliseconds)
    End Sub
    Private Sub Start_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StartButton.Click
        If StartButton.Text = "Start" Then
            Timer1.Start()
            Me.StopWatch.Start()
            StartButton.Text = "Stop"
        Else
            Timer1.Stop()
            Me.StopWatch.Stop()
            StartButton.Text = "Start"
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetButton.Click
        Me.StopWatch.Reset()
        Label1.Text = "00:00:00:000"
        ListBox1.Items.Clear()
    End Sub

    Private Sub Button3_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LapButton.Click
        ListBox1.Items.Add(Label1.Text)
    End Sub

    Private Sub RestoreButton_Click(sender As Object, e As EventArgs) Handles RestoreButton.Click
        Main.Show()
        Me.Close()
    End Sub
End Class