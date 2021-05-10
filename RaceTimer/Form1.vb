Public Class frmRaceTimer
    Dim sTime As String 'Holds the time as a string
    Dim Hour, Minute, Second, Millisecond As Integer 'holds hour, minute, second and millisecond as integer
    Dim sHour, sMinute, sSecond, sMillisecond As String 'holds hour, minute, second and millisecond as string

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        btnStop.Select()
        lstTimer.Items.Clear()
        For Hour = 0 To 23 'Limits Hour to 24 hours
            For Minute = 0 To 59 'Limits Minute to 59 mins
                For Second = 0 To 59 'Limits Second to 59 secs
                    For Millisecond = 0 To 99 'Limits Millisecond to 99 msecs
                        System.Threading.Thread.Sleep(0.501) 'Sleep value should be adjusted according to the speed of the computer. Higher value = slower iteration
                        Application.DoEvents() 'Ads a pause in the the loop
                        sHour = Hour 'makes string sHour equal to Hour
                        sMinute = Minute
                        sSecond = Second
                        sMillisecond = Millisecond
                        If Hour < 10 Then
                            sHour = "0" & Hour
                        End If
                        If Minute < 10 Then
                            sMinute = "0" & Minute
                        End If
                        If Second < 10 Then
                            sSecond = "0" & Second
                        End If
                        If Millisecond < 10 Then
                            sMillisecond = "0" & Millisecond
                        End If
                        lblDisplay.Text = sHour & "" & ":" & "" & sMinute & "" & ":" & "" & sSecond & "" & ":" & "" & sMillisecond
                        sTime = lblDisplay.Text 'Assigns valie to sTime as the text acquired from lblDisplay
                    Next
                Next
            Next
        Next

    End Sub
    Private Sub btnLap_Click(sender As Object, e As EventArgs) Handles btnLap.Click
        lstTimer.Items.Add(sTime) 'Laps the timer adds the time on the listbox. 
    End Sub

    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        btnStart.Select() 'Focuses on btnStart
        lstTimer.Items.Clear() 'Clears the listibox
        lstTimer.Items.Add("Final Time:" & sTime) 'Displays final time
        Do
            Millisecond = 0
            Second = 0
            Minute = 0
            Hour = 0
            lblDisplay.Text = "00:00:00:00" 'Resets the timer
            Application.DoEvents() 'Ads pause to the loop
        Loop
    End Sub
End Class
