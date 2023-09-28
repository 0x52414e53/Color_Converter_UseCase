Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim userInput As String = TextBox1.Text.ToLower()

        Dim colorResult As String

        Select Case userInput
            Case "r", "R"
                colorResult = "Red"
            Case "b", "B"
                colorResult = "Blue"
            Case "g", "G"
                colorResult = "Green"
            Case Else
                colorResult = "Unknown color"
        End Select
        TextBox2.Text = colorResult
    End Sub
End Class