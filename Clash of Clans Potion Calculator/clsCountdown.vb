'The countdowns break if the computer goes zzzzz but i dont care
Public Class Countdown
    Private timeLeft As Integer
    Private hasEnded As Boolean

    Private myBox As GroupBox
    Private cdLabel As Label
    Private cdProgress As ProgressBar
    Private cdButton As Button

    Private flowp As FlowLayoutPanel


    Public Sub New(ByVal seconds As Integer, ByVal flp As FlowLayoutPanel, ByVal title As String)
        timeLeft = seconds
        hasEnded = False

        myBox = New GroupBox With {
        .Size = New Size(497, 120),
        .Text = title
        }

        cdLabel = New Label With {
        .AutoSize = False,
        .Dock = DockStyle.Top,
        .Size = New Size(491, 51),
        .TextAlign = ContentAlignment.MiddleCenter,
        .Font = New Font("Microsoft Sans Serif", 12, GraphicsUnit.Point)
        }

        cdProgress = New ProgressBar With {
        .Size = New Size(387, 34),
        .Maximum = seconds,
        .Location = New Point(10, 76),
        .Step = 1,
        .Value = seconds,
        .Style = ProgressBarStyle.Continuous
        }

        cdButton = New Button With {
        .Size = New Size(88, 34),
        .Location = New Point(403, 76),
        .Text = "Cancel"
        }

        myBox.Controls.AddRange({
        cdLabel,
        cdButton,
        cdProgress
        })
        flp.Controls.Add(myBox)

        flowp = flp

        AddHandler cdButton.Click, AddressOf stopAlarm
    End Sub
    Private Function formatTimeLeft() As String
        Dim calcTime As Decimal = timeLeft
        Dim daysLeft, hoursLeft, minutesLeft, secondsLeft As Integer
        If calcTime / 86400 >= 1 Then
            daysLeft = calcTime \ 86400
            calcTime = calcTime Mod 86400
        End If
        If calcTime / 3600 >= 1 Then
            hoursLeft = calcTime \ 3600
            calcTime = calcTime Mod 3600
        End If


        If calcTime / 60 >= 1 Then
            minutesLeft = calcTime \ 60
            calcTime = calcTime Mod 60
        End If


        If calcTime / 1 >= 1 Then
            secondsLeft = calcTime \ 1
            calcTime = calcTime Mod 1
        End If
        Return $"{daysLeft} Day{If(daysLeft = 1, "", "s")} {hoursLeft} Hour{If(hoursLeft = 1, "", "s")} {minutesLeft} Minute{If(minutesLeft = 1, "", "s")} {secondsLeft} Second{If(secondsLeft = 1, "", "s")}"


    End Function
    Public Sub tick()
        timeLeft -= 1
        cdLabel.Text = formatTimeLeft()

        If timeLeft >= 0 Then
            cdProgress.Value -= 1
        End If

        If timeLeft < 0 AndAlso Not hasEnded Then
            soundAlarm()
            hasEnded = True
        End If
    End Sub
    Public Sub soundAlarm()
        If Not hasEnded Then
            My.Computer.Audio.Play(My.Resources.Alarm, AudioPlayMode.BackgroundLoop)
        End If
    End Sub
    Public Sub stopAlarm()
        My.Computer.Audio.Stop()
        flowp.Controls.Remove(myBox)
        hasEnded = True
    End Sub
    Public Sub endCountdown()
        If hasEnded Then
            stopAlarm()
        End If

    End Sub
End Class