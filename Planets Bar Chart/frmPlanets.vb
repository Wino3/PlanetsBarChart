
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

        For P As Integer = 0 To intNUM_PLANETS - 1
            Dim strPlanets As String
            strPlanets = $"Planets: {strArrayPlanetNames(P)} Diameter:{intArrayPlanetSizes(P)}"
            lstPlanets.Items.Add(strPlanets)

            Dim strAstersks As String = GetDiameterAsAsterisks(intArrayPlanetSizes(P))

            lstPlanets.Items.Add(strAstersks)



        Next

    End Sub
    Public Function GetDiameterAsAsterisks(intDiameter As Integer) As String
        Dim intNumAsterisks As Integer = intDiameter \ 1000
        Dim strResults As String = ""
        For A As Integer = 1 To intNumAsterisks
            strResults = "*" + strResults
        Next
        Return strResults

    End Function
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstPlanets.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub


End Class
