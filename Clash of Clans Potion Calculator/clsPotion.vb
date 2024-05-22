Public Class Potion
    Private duration As Integer
    Private multiplier As Integer
    Private name As String
    Private label As String

    Public Sub New(title As String, length As Integer, boost As Integer)
        duration = length
        multiplier = boost
        name = title
    End Sub

    Public Function makeLabel() As String
        Return ($"{name} ({multiplier}x for {duration / 60}m)")
    End Function

    Public Function getDuration() As Integer
        Return duration
    End Function

    Public Function getMultiplier() As Integer
        Return multiplier
    End Function
End Class
