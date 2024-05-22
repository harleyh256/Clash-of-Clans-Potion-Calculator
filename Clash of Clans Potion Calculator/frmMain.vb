Imports System.IO
Imports System.Resources

Public Class frmMain
    Public countdowns As New List(Of Countdown)
    Public potions As New List(Of Potion)

    Private totalSecs As Decimal = 0
    Private potionModifiers() As Integer = {36000, 86400}

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrClock.Start()
        cbxPotion.Items.Clear()

        Dim potionText As String = My.Resources.potions
        Dim potionData() As String

        For Each line As String In potionText.Split(vbNewLine)
            potionData = line.Split(",")
            potions.Add(New Potion(potionData(0), potionData(1), potionData(2)))
        Next

        For Each pot As Potion In potions
            cbxPotion.Items.Add(pot.makeLabel)
        Next

        cbxPotion.SelectedIndex = 0
    End Sub

    Private Sub calculateResult() Handles cbxPotion.SelectedIndexChanged, nudPotions.ValueChanged, nudDays.ValueChanged, nudHours.ValueChanged, nudMinutes.ValueChanged, nudSeconds.ValueChanged

        Dim calc As New Calculator
        Dim result As Integer
        If cbxPotion.SelectedIndex >= 0 Then
            calc.calculate(potions(cbxPotion.SelectedIndex), nudPotions.Value, nudDays.Value, nudHours.Value, nudMinutes.Value, nudSeconds.Value)
            lblResult.Text = calc.getString
            result = calc.getTotalSecs
            lblResult.ForeColor = calc.getColour(potions(cbxPotion.SelectedIndex), nudPotions.Value)
        End If

        If result = 0 Then
            btnTimer.Enabled = False
        Else
            btnTimer.Enabled = True
        End If
    End Sub

    Private Sub btnTimer_Click(sender As Object, e As EventArgs) Handles btnTimer.Click
        'Process.Start($"https://www.google.com/search?q={totalSecs}%20Second%20Timer")
        Dim calc As New Calculator
        calc.calculate(potions(cbxPotion.SelectedIndex), nudPotions.Value, nudDays.Value, nudHours.Value, nudMinutes.Value, nudSeconds.Value)
        countdowns.Add(New Countdown(calc.getTotalSecs, flpTimers, txtCountdownName.Text))
    End Sub


    Private Sub tmrClock_Tick(sender As Object, e As EventArgs) Handles tmrClock.Tick
        For Each cd As Countdown In countdowns
            cd.tick()
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProgressBar1.Value += 1
    End Sub
End Class