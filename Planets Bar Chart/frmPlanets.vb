
Option Strict On
Option Explicit On
Public Class frmPlanets
    Private Sub btnShow_Click(sender As Object, e As EventArgs) Handles btnShow.Click
        'Number of planets before Pluto was "let go"
        Const intNUM_PLANETS As Integer = 9
        'Planet names
        Dim strArrayPlanetNames() As String =
        {"Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune", "Pluto"}
        'diameter of each planet in miles
        Dim intArrayPlanetSizes() As Integer =
        {3031, 7521, 7926, 4223, 88846, 74898, 31763, 30800, 1430}


    End Sub
End Class
