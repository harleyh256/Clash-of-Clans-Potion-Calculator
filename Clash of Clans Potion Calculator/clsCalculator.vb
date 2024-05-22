
Public Class Calculator
    Private result() As Integer = {0, 0, 0, 0}
    Private totalResult As Integer

    Private Function findAmountToKeep(ByVal upgradeLength As Integer, ByVal boostLength As Integer, potCount As Integer, boost As Integer)
        If (upgradeLength / boost) - (boostLength * potCount) > 0 Then
            Return upgradeLength - (boostLength * boost * potCount)
        Else
            Return 0
        End If
    End Function
    Public Sub calculate(pot As Potion, potionCount As Integer, dayCount As Integer, hourCount As Integer, minuteCount As Integer, secondCount As Integer)
        Dim fullTime As Decimal = (dayCount * 86400) + (hourCount * 3600) + (minuteCount * 60) + secondCount
        Dim shrunkTime, remainingTime As Decimal
        Dim totalSecs As Decimal

        remainingTime = findAmountToKeep(fullTime, pot.getDuration, potionCount, pot.getMultiplier)
        shrunkTime = (fullTime - remainingTime) / pot.getMultiplier

        totalSecs = shrunkTime + remainingTime

        Dim calcTime As Decimal = totalSecs
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

        result(0) = daysLeft
        result(1) = hoursLeft
        result(2) = minutesLeft
        result(3) = secondsLeft

        totalResult = totalSecs
    End Sub

    Public Function getString() As String
        Return $"{result(0)} Day{If(result(0) = 1, "", "s")} {result(1)} Hour{If(result(1) = 1, "", "s")} {result(2)} Minute{If(result(2) = 1, "", "s")} {result(3)} Second{If(result(3) = 1, "", "s")}"
    End Function
    Public Function getColour(pot As Potion, potionCount As Integer) As Color
        If totalResult <= potionCount * pot.getDuration Then
            Return Color.Green
        Else
            Return Color.Red
        End If
    End Function
    Public Function getTotalSecs() As Integer
        Return totalResult
    End Function
End Class
